using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Save : MonoBehaviour
{
	private static Save _instance;

	public const string SAVE_LOCATION = "/GameSaves/";

	private const string SAVE_SUBDIRECTORY = "File_";

	private const string BACKUP_NAME = "Save.backup";

	private string loadedFileSubdirectory = "";

	private bool loadedFromBackup;

	private BinaryFormatter bf;

	private FileStream tempFile;

	private SaveData data;

	public static Save instance
	{
		get
		{
			if ((Object)(object)_instance == (Object)null)
			{
				_instance = Object.FindObjectOfType<Save>();
			}
			return _instance;
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)_instance, (MonoBehaviour)(object)this))
		{
			_instance = this;
			ValidateCloudSaves();
		}
	}

	private void Start()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(BackupSave));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BackupSave));
	}

	private void ValidateCloudSaves()
	{
		string[] directories = Directory.GetDirectories(Application.persistentDataPath + "/GameSaves/");
		for (int i = 0; i < directories.Length; i++)
		{
			if (Directory.GetFiles(directories[i]).Length == 0)
			{
				Directory.Delete(directories[i]);
			}
		}
		directories = Directory.GetDirectories(Application.persistentDataPath + "/GameSaves/");
		for (int j = 0; j < directories.Length; j++)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
			FileInfo[] array = (from p in directoryInfo.GetFiles("*.save")
				orderby p.LastWriteTime
				select p).ToArray();
			if (array.Length <= 1)
			{
				continue;
			}
			if (File.Exists(directoryInfo.FullName + "/Save.backup"))
			{
				File.Delete(directoryInfo.FullName + "/Save.backup");
			}
			for (int k = 1; k < array.Length; k++)
			{
				string newFileSubfolder = GetNewFileSubfolder();
				Debug.Log((object)("Moving " + array[k].FullName + " from " + directoryInfo.FullName + " to " + newFileSubfolder));
				Directory.CreateDirectory(newFileSubfolder);
				try
				{
					File.Move(array[k].FullName, newFileSubfolder + array[k].Name);
				}
				catch (Exception ex)
				{
					Debug.LogError((object)ex.Message);
				}
			}
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(BackupSave));
			if ((Object)(object)OnlineLoadManager.instance != (Object)null)
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BackupSave));
			}
		}
	}

	private void BackupSave()
	{
		if (string.IsNullOrEmpty(GameManager.GGFJGHHHEJC.PMKCJJCGKBB))
		{
			return;
		}
		if (loadedFromBackup)
		{
			Debug.Log((object)new Exception("Save file was corrupted and restored from a backup, so we don't want to override the backup file."));
			return;
		}
		string currentSaveName = GameManager.GGFJGHHHEJC.PMKCJJCGKBB;
		Debug.Log((object)("Checking file for backup..." + currentSaveName));
		if (!HasBackup(currentSaveName))
		{
			CreateBackup(currentSaveName);
		}
		else
		{
			UpdateBackup(currentSaveName);
		}
	}

	private void CreateBackup(string fileName)
	{
		Debug.LogError((object)"File has no backup, creating backup subdirectory...");
		string newFileSubfolder = GetNewFileSubfolder();
		Directory.CreateDirectory(newFileSubfolder);
		string text = SaveFileString();
		File.Copy(Application.persistentDataPath + "/GameSaves/" + fileName, newFileSubfolder + text);
		File.SetLastWriteTimeUtc(newFileSubfolder + text, DateTime.UtcNow);
		File.Copy(Application.persistentDataPath + "/GameSaves/" + fileName, newFileSubfolder + "Save.backup");
		File.SetLastWriteTimeUtc(newFileSubfolder + "Save.backup", DateTime.UtcNow);
		GameManager.GGFJGHHHEJC.PMKCJJCGKBB = text;
		loadedFileSubdirectory = newFileSubfolder;
		Debug.LogError((object)("Backup directory created at: " + newFileSubfolder));
		if (IsValidSaveData(text))
		{
			DeleteSave(fileName);
		}
	}

	private void UpdateBackup(string fileName)
	{
		Debug.Log((object)"File is in a backup subdirectory. Updating backup...");
		string text = ((!string.IsNullOrEmpty(loadedFileSubdirectory)) ? loadedFileSubdirectory : GetFileSubfolder(fileName));
		try
		{
			File.Copy(text + fileName, text + "Save.backup", overwrite: true);
			File.SetLastWriteTimeUtc(text + "Save.backup", DateTime.UtcNow);
		}
		catch
		{
			Debug.LogError((object)("Error backing up file: " + text + fileName));
		}
	}

	private bool HasBackup(string fileName)
	{
		return !File.Exists(Application.persistentDataPath + "/GameSaves/" + fileName);
	}

	public string GetFileSubfolder(string fileName)
	{
		string text = Application.persistentDataPath + "/GameSaves/File_" + 1 + "/";
		DirectoryInfo directoryInfo = new DirectoryInfo(Application.persistentDataPath + "/GameSaves/");
		for (int i = 0; i < directoryInfo.GetDirectories().Length; i++)
		{
			text = Application.persistentDataPath + "/GameSaves/" + directoryInfo.GetDirectories()[i].Name + "/";
			if (File.Exists(text + fileName))
			{
				return text;
			}
		}
		return null;
	}

	private string GetNewFileSubfolder()
	{
		int num = 1;
		string text = Application.persistentDataPath + "/GameSaves/File_" + num + "/";
		while (Directory.Exists(text))
		{
			if (Directory.GetFiles(text).Length == 0)
			{
				return text;
			}
			num++;
			text = Application.persistentDataPath + "/GameSaves/File_" + num + "/";
		}
		return text;
	}

	public static string GetFilePath(string fileName)
	{
		if (instance.GetFileSubfolder(fileName) != null)
		{
			if (instance.loadedFromBackup)
			{
				return instance.GetFileSubfolder(fileName) + "Save.backup";
			}
			return instance.GetFileSubfolder(fileName) + fileName;
		}
		return Application.persistentDataPath + "/GameSaves/" + fileName;
	}

	public SaveData GetSaveData(string fileName)
	{
		loadedFromBackup = false;
		tempFile = null;
		data = null;
		if (bf == null)
		{
			bf = new BinaryFormatter();
		}
		string fileSubfolder = GetFileSubfolder(fileName);
		try
		{
			tempFile = File.Open(Application.persistentDataPath + "/GameSaves/" + fileName, FileMode.Open);
		}
		catch (FileNotFoundException ex)
		{
			tempFile = null;
			if (string.IsNullOrEmpty(fileSubfolder))
			{
				Debug.LogError((object)("No save file found: " + ex.FileName));
				return null;
			}
			try
			{
				tempFile = File.Open(fileSubfolder + fileName, FileMode.Open);
			}
			catch
			{
				Debug.LogError((object)("Error opening file: " + fileSubfolder + fileName));
				return null;
			}
		}
		try
		{
			data = (SaveData)bf.Deserialize(tempFile);
		}
		catch
		{
			data = null;
			tempFile.Close();
			Debug.Log((object)("Deserialize SaveData error: " + fileName));
			return GetBackupData(fileName);
		}
		tempFile.Close();
		return data;
	}

	private SaveData GetBackupData(string fileName)
	{
		loadedFromBackup = true;
		Debug.Log((object)"Attempting to restore with a backup...");
		tempFile = null;
		data = null;
		if (bf == null)
		{
			bf = new BinaryFormatter();
		}
		string fileSubfolder = GetFileSubfolder(fileName);
		if (fileSubfolder == null)
		{
			Debug.LogError((object)("Could not find backup for file: " + fileName + ".\nThis should only happen with files corrupted before the new backup system."));
			return null;
		}
		try
		{
			tempFile = File.Open(fileSubfolder + "Save.backup", FileMode.Open);
		}
		catch
		{
			Debug.LogError((object)("Error opening backup file: " + fileSubfolder + "Save.backup"));
			return null;
		}
		try
		{
			data = (SaveData)bf.Deserialize(tempFile);
		}
		catch
		{
			Debug.LogError((object)("Deserialize SaveData backup error: " + fileSubfolder + "Save.backup"));
			return null;
		}
		Debug.Log((object)"Backup data retrieved successfully");
		tempFile.Close();
		return data;
	}

	public bool IsValidSaveData(string fileName)
	{
		SaveData saveData = GetSaveData(fileName);
		if (saveData != null)
		{
			for (int i = 0; i < saveData.HIMELJEPBDP().Length; i++)
			{
				if (saveData.HIMELJEPBDP()[i] > 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	public string DuplicateGame(string fileToDuplicate)
	{
		data = GetSaveData(fileToDuplicate);
		if (data == null)
		{
			Debug.LogError((object)"There was an error when duplicating the file. This should only happen with files corrupted before the backup system.");
			return "";
		}
		string text = Application.persistentDataPath + "/GameSaves/";
		string text2 = SaveFileString();
		string fileSubfolder = GetFileSubfolder(fileToDuplicate);
		string newFileSubfolder = GetNewFileSubfolder();
		Directory.CreateDirectory(newFileSubfolder);
		if (fileSubfolder == null)
		{
			if (!File.Exists(text + fileToDuplicate))
			{
				Debug.LogError((object)"Could not find file to duplicate.");
				return null;
			}
			File.Copy(text + fileToDuplicate, newFileSubfolder + text2);
			DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text + fileToDuplicate);
			lastWriteTimeUtc.AddSeconds(1.0);
			File.SetLastWriteTimeUtc(newFileSubfolder + text2, lastWriteTimeUtc);
		}
		else
		{
			if (!File.Exists(fileSubfolder + fileToDuplicate))
			{
				Debug.LogError((object)"Could not find file to duplicate.");
				return null;
			}
			File.Copy(fileSubfolder + fileToDuplicate, newFileSubfolder + text2);
			if (File.Exists(fileSubfolder + "Save.backup"))
			{
				File.Copy(fileSubfolder + "Save.backup", newFileSubfolder + "Save.backup");
			}
			DateTime lastWriteTimeUtc2 = File.GetLastWriteTimeUtc(fileSubfolder + fileToDuplicate);
			lastWriteTimeUtc2.AddSeconds(1.0);
			File.SetLastWriteTimeUtc(newFileSubfolder + text2, lastWriteTimeUtc2);
			if (File.Exists(newFileSubfolder + "Save.backup"))
			{
				File.SetLastWriteTimeUtc(newFileSubfolder + "Save.backup", lastWriteTimeUtc2);
			}
		}
		return text2;
	}

	public string SaveGame(bool isNewFile = false, string overrideSaveSubfolder = null)
	{
		string path = Application.persistentDataPath + "/GameSaves/";
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		SelectObject.GetPlayer(1).Deselect();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(2)) && OnlineManager.MasterOrOffline())
		{
			SelectObject.GetPlayer(2).Deselect();
		}
		if (OnlineManager.MasterOrOffline())
		{
			data = new SaveData();
			data.OFLMAICHLLK();
		}
		else
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC) && GameManager.GGFJGHHHEJC.HEJPPEJMPFE != null)
			{
				data = GameManager.GGFJGHHHEJC.HEJPPEJMPFE;
			}
			else
			{
				data = new SaveData();
				GameManager.GGFJGHHHEJC.HEJPPEJMPFE = data;
				data.EGEJDAHNMJE();
			}
			data.GKEBFIPMBEG();
		}
		if (bf == null)
		{
			bf = new BinaryFormatter();
		}
		string text = SaveFileString();
		string text2 = null;
		if (overrideSaveSubfolder != null && overrideSaveSubfolder != loadedFileSubdirectory && Directory.Exists(overrideSaveSubfolder))
		{
			text2 = loadedFileSubdirectory;
			loadedFileSubdirectory = overrideSaveSubfolder;
		}
		if (isNewFile || string.IsNullOrEmpty(loadedFileSubdirectory))
		{
			string newFileSubfolder = GetNewFileSubfolder();
			Debug.Log((object)("Saving..." + newFileSubfolder + "\nNew file."));
			Directory.CreateDirectory(newFileSubfolder);
			tempFile = File.Create(newFileSubfolder + text);
			GameManager.GGFJGHHHEJC.PMKCJJCGKBB = text;
			loadedFileSubdirectory = newFileSubfolder;
		}
		else
		{
			Debug.Log((object)("Saving..." + loadedFileSubdirectory));
			tempFile = File.Create(loadedFileSubdirectory + text);
			GameManager.GGFJGHHHEJC.PMKCJJCGKBB = text;
		}
		bf.Serialize(tempFile, data);
		tempFile.Close();
		if (text2 != null && Directory.Exists(text2))
		{
			Directory.Delete(text2, recursive: true);
		}
		return text;
	}

	public void PrepareLoadGame(string fileName)
	{
		data = GetSaveData(fileName);
		if (VersionNumberManager.IsAnOlderVersion(data.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
		{
			CharacterCreatorUI.loadGame = data;
			CharacterCreatorUI.loadFilename = fileName;
			CharacterCreatorUI.Get(1).OpenUI();
		}
		else
		{
			LoadGame(fileName, data);
		}
	}

	public void PrepareLoadGameOnline(string fileName)
	{
		Debug.Log((object)"Prepare Load Game Online");
		data = GetSaveData(fileName);
		if (VersionNumberManager.IsAnOlderVersion(data.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
		{
			Debug.LogError((object)"ERROR: Make sure the game is up to date before connecting online.");
		}
		else
		{
			LoadGame(fileName, data);
		}
	}

	public void LoadGame(string fileName, SaveData data)
	{
		Debug.Log((object)"LoadGame");
		Sound.GGFJGHHHEJC.blockSound.Add((MonoBehaviour)(object)this);
		if ((Object)(object)SelectObject.GetPlayer(1) != (Object)null)
		{
			SelectObject.GetPlayer(1).Deselect();
		}
		if ((Object)(object)SelectObject.GetPlayer(2) != (Object)null)
		{
			SelectObject.GetPlayer(2).Deselect();
		}
		GameManager.GGFJGHHHEJC.HEJPPEJMPFE = data;
		GameManager.GGFJGHHHEJC.PMKCJJCGKBB = fileName;
		loadedFileSubdirectory = GetFileSubfolder(fileName);
		Sound.GGFJGHHHEJC.blockSound.Remove((MonoBehaviour)(object)this);
		SaveUI.instance.StartFadeIntoGame(newGame: false);
	}

	public void MoveSave(string fileName, string newFileName)
	{
		Debug.Log((object)("Moving save from " + fileName + " to " + newFileName));
		File.Move(Application.persistentDataPath + "/GameSaves/" + fileName, Application.persistentDataPath + "/GameSaves/" + newFileName);
		File.SetLastWriteTimeUtc(Application.persistentDataPath + "/GameSaves/" + newFileName, DateTime.UtcNow);
	}

	public void DeleteSave(string fileName, bool deleteBackup = false)
	{
		string fileSubfolder = GetFileSubfolder(fileName);
		if (fileSubfolder != null)
		{
			if (deleteBackup && File.Exists(fileSubfolder + "Save.backup"))
			{
				File.Delete(fileSubfolder + "Save.backup");
			}
			File.Delete(fileSubfolder + fileName);
		}
		else
		{
			File.Delete(Application.persistentDataPath + "/GameSaves/" + fileName);
		}
	}

	public string[] GetAllSaveFiles()
	{
		string path = Application.persistentDataPath + "/GameSaves/";
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
			return new string[0];
		}
		return (from p in new DirectoryInfo(path).GetFiles("*.save", SearchOption.AllDirectories)
			orderby p.LastWriteTime descending
			select p into s
			where s.Name.EndsWith(".save")
			select s into f
			select f.Name).ToArray();
	}

	public string SaveFileString()
	{
		DateTime now = DateTime.Now;
		return "SaveFile-" + now.Day + "-" + now.Month + "-" + now.Year + "-" + now.Hour + "-" + now.Minute + "-" + now.Second + ".save";
	}

	public void SaveKeybinds()
	{
		string text = Application.persistentDataPath + "/GameSaves/";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		if (!GameManager.NoPlayers())
		{
			SelectObject.GetPlayer(1).Deselect();
			if ((Object)(object)SelectObject.GetPlayer(2) != (Object)null)
			{
				SelectObject.GetPlayer(2).Deselect();
			}
		}
		if (bf == null)
		{
			bf = new BinaryFormatter();
		}
		tempFile = File.Create(text + (string.IsNullOrEmpty("keybinds.kbsd") ? SaveFileString() : "keybinds.kbsd"));
		bf.Serialize(tempFile, KeybindUI.GGFJGHHHEJC.keybindsSave);
		tempFile.Close();
	}

	public void LoadKeybinds()
	{
		KeybindUI.GGFJGHHHEJC.keybindsSave = GetKeybindSaveData();
		if (KeybindUI.GGFJGHHHEJC.keybindsSave == null)
		{
			KeybindUI.GGFJGHHHEJC.keybindsSave = new KeybindsSaveData();
		}
	}

	public KeybindsSaveData GetKeybindSaveData()
	{
		tempFile = null;
		try
		{
			tempFile = File.Open(Application.persistentDataPath + "/GameSaves/keybinds.kbsd", FileMode.Open);
		}
		catch (FileNotFoundException ex)
		{
			Debug.Log((object)("No save file found: " + ex.FileName));
			return null;
		}
		if (bf == null)
		{
			bf = new BinaryFormatter();
		}
		KeybindsSaveData result = null;
		try
		{
			result = (KeybindsSaveData)bf.Deserialize(tempFile);
		}
		catch
		{
			Debug.Log((object)"Deserialize SaveData error: keybinds.kbsd");
		}
		tempFile.Close();
		return result;
	}
}
