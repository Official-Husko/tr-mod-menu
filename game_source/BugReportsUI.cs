using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text;
using Galaxy.Api;
using Photon.Pun;
using Photon.Realtime;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;

public class BugReportsUI : UIWindow
{
	[CompilerGenerated]
	private sealed class DCLMLJDCLAD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BugReportsUI _003C_003E4__this;

		public DisconnectCause _cause;

		private Stopwatch _003Cstopwatch_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public DCLMLJDCLAD(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			BugReportsUI bugReportsUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Debug.Log((object)"Enviando Reporte de desconnexion");
				GGFJGHHHEJC.JMKIBLAFONN();
				GGFJGHHHEJC.CCHNFGMJIBN();
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003Cstopwatch_003E5__2 = new Stopwatch();
				_003Cstopwatch_003E5__2.Start();
				bugReportsUI.CFJJGHKGILL();
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				Debug.Log((object)("Creando TXT. Tiempo: " + _003Cstopwatch_003E5__2.ElapsedMilliseconds));
				bugReportsUI.JPMEGIBNDEM(new string[2]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString()
				});
				Debug.Log((object)("Partida comprimida. Tiempo: " + _003Cstopwatch_003E5__2.ElapsedMilliseconds));
				bugReportsUI.LPPDIJCDBIJ = bugReportsUI.GDBFBBCGDMM + bugReportsUI.IKJLNKFLBHH + bugReportsUI.GLFBPIBBLND + ".gz";
				_003C_003E2__current = ((MonoBehaviour)bugReportsUI).StartCoroutine(bugReportsUI.MLPBGLOBGMH("disconnect", bugReportsUI.HBILFLLKHGP, OnlineManager.JMGLCMGHAIA ? "1" : "0", "", "", "", ((object)(DisconnectCause)(ref _cause)).ToString(), OnlineManager.MLLIAIAGJDD, OnlineManager.DAKLDLGLIBI, bugReportsUI.POCOMFHHMOO(), bugReportsUI.BLAOEIFLGMP()));
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				if (!bugReportsUI.ECPEFDHOFHN)
				{
					Debug.Log((object)("Correo Enviado. Tiempo: " + _003Cstopwatch_003E5__2.ElapsedMilliseconds));
					bugReportsUI.BDANEFBBBMC = false;
				}
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class HAAGNBLGOOB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BugReportsUI _003C_003E4__this;

		private Stopwatch _003Cstopwatch_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public HAAGNBLGOOB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			BugReportsUI bugReportsUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Debug.Log((object)"Enviando Reporte");
				bugReportsUI.BNHHIGDPPKI = "";
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003Cstopwatch_003E5__2 = new Stopwatch();
				_003Cstopwatch_003E5__2.Start();
				bugReportsUI.BNHHIGDPPKI = bugReportsUI.txt.text;
				bugReportsUI.BNHHIGDPPKI = bugReportsUI.BNHHIGDPPKI + "\n\n\nMine Level Info:\n" + bugReportsUI.LEMLHLHOBBC();
				((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(false);
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				bugReportsUI.AKCFHLFHNGC();
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(true);
				_003C_003E2__current = CommonReferences.waitRealtime2;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				bugReportsUI.CFJJGHKGILL();
				_003C_003E2__current = null;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				if (bugReportsUI.IFLJALGKJIC)
				{
					Debug.Log((object)("Creando TXT. Tiempo: " + _003Cstopwatch_003E5__2.ElapsedMilliseconds));
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				goto IL_0246;
			case 6:
				_003C_003E1__state = -1;
				if (File.Exists(bugReportsUI.DOJMNMDLNBB))
				{
					bugReportsUI.JPMEGIBNDEM(new string[3]
					{
						Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
						(Application.persistentDataPath + "/Player.log").ToString(),
						bugReportsUI.DOJMNMDLNBB
					});
				}
				else
				{
					Debug.LogError((object)"Screenshot not found");
					bugReportsUI.JPMEGIBNDEM(new string[2]
					{
						Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
						(Application.persistentDataPath + "/Player.log").ToString()
					});
				}
				Debug.Log((object)("Partida comprimida. Tiempo: " + _003Cstopwatch_003E5__2.ElapsedMilliseconds));
				goto IL_0246;
			case 7:
			{
				_003C_003E1__state = -1;
				string text = (OnlineManager.PlayingOnline() ? "Multiplayer" : (GameManager.LocalCoop() ? "LocalCoop" : "SinglePlayer"));
				string bHNGKNLCAKF = (OnlineManager.IsMasterClient() ? "1" : "0");
				string hMBFOKONAMK = (OnlineManager.PlayingOnline() ? PhotonNetwork.CurrentRoom.PlayerCount.ToString() : "1");
				bugReportsUI.LPPDIJCDBIJ = bugReportsUI.GDBFBBCGDMM + bugReportsUI.IKJLNKFLBHH + bugReportsUI.GLFBPIBBLND + ".gz";
				string hBILFLLKHGP = bugReportsUI.HBILFLLKHGP;
				string bNHHIGDPPKI = bugReportsUI.BNHHIGDPPKI;
				string lFOABHEEMCC = text;
				_003C_003E2__current = ((MonoBehaviour)bugReportsUI).StartCoroutine(bugReportsUI.MLPBGLOBGMH("bug", hBILFLLKHGP, bHNGKNLCAKF, bNHHIGDPPKI, lFOABHEEMCC, hMBFOKONAMK, "", "", "", "", bugReportsUI.BLAOEIFLGMP()));
				_003C_003E1__state = 8;
				return true;
			}
			case 8:
				_003C_003E1__state = -1;
				if (!bugReportsUI.ECPEFDHOFHN)
				{
					Debug.Log((object)("Correo Enviado. Tiempo: " + _003Cstopwatch_003E5__2.ElapsedMilliseconds));
					_003C_003E2__current = null;
					_003C_003E1__state = 9;
					return true;
				}
				break;
			case 9:
				_003C_003E1__state = -1;
				bugReportsUI.txt.text = "";
				_003C_003E2__current = null;
				_003C_003E1__state = 10;
				return true;
			case 10:
				_003C_003E1__state = -1;
				bugReportsUI.sendingPanel.SetActive(false);
				bugReportsUI.sentPanel.SetActive(true);
				_003C_003E2__current = CommonReferences.waitRealtime3;
				_003C_003E1__state = 11;
				return true;
			case 11:
				{
					_003C_003E1__state = -1;
					bugReportsUI.sentPanel.SetActive(false);
					bugReportsUI.BDANEFBBBMC = false;
					if (!bugReportsUI.ECPEFDHOFHN)
					{
						bugReportsUI.CloseUI();
					}
					break;
				}
				IL_0246:
				_003C_003E2__current = null;
				_003C_003E1__state = 7;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class DEFDACBLGHF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string reportType;

		public string playerName;

		public BugReportsUI _003C_003E4__this;

		public string isMaster;

		public string selectedObjs;

		public string description;

		public string gameMode;

		public string playerCount;

		public string disconnectCause;

		public string roomName;

		public string region;

		public string playerLocations;

		private UnityWebRequest _003Cwww_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					NONHBLMCNAM();
				}
			}
		}

		private void NONHBLMCNAM()
		{
			_003C_003E1__state = -1;
			if (_003Cwww_003E5__2 != null)
			{
				((IDisposable)_003Cwww_003E5__2).Dispose();
			}
		}

		[DebuggerHidden]
		public DEFDACBLGHF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		private bool MoveNext()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Invalid comparison between Unknown and I4
			bool result;
			try
			{
				int num = _003C_003E1__state;
				BugReportsUI bugReportsUI = _003C_003E4__this;
				switch (num)
				{
				default:
					result = false;
					break;
				case 0:
				{
					_003C_003E1__state = -1;
					WWWForm val = new WWWForm();
					val.AddField("secret_token", "c58d309f-046c-4717-8c8c-cd8d9be873c4");
					val.AddField("report_type", reportType);
					val.AddField("player_name", playerName);
					val.AddField("version", VersionNumberManager.instance.version);
					val.AddField("initial_version", VersionNumberManager.instance.initialVersionNumber.ToString());
					val.AddField("hardware_info", bugReportsUI.KFDICFIDKDO());
					val.AddField("is_master", isMaster);
					val.AddField("selected_objects", selectedObjs);
					val.AddField("description", description);
					val.AddField("game_mode", gameMode);
					val.AddField("player_count", playerCount);
					val.AddField("disconnect_cause", disconnectCause);
					val.AddField("room_name", roomName);
					val.AddField("region", region);
					val.AddField("player_locations", playerLocations);
					if (!string.IsNullOrEmpty(bugReportsUI.LPPDIJCDBIJ) && File.Exists(bugReportsUI.LPPDIJCDBIJ))
					{
						byte[] array = File.ReadAllBytes(bugReportsUI.LPPDIJCDBIJ);
						val.AddBinaryData("attachment", array, Path.GetFileName(bugReportsUI.LPPDIJCDBIJ), "application/gzip");
					}
					else
					{
						Debug.LogError((object)("Compressed file doesn't exist: " + bugReportsUI.LPPDIJCDBIJ));
					}
					_003Cwww_003E5__2 = UnityWebRequest.Post("https://www.isolatedgames.com/bug-report/index.php", val);
					_003C_003E1__state = -3;
					_003C_003E2__current = _003Cwww_003E5__2.SendWebRequest();
					_003C_003E1__state = 1;
					result = true;
					break;
				}
				case 1:
					_003C_003E1__state = -3;
					if ((int)_003Cwww_003E5__2.result != 1)
					{
						Debug.LogError((object)("Bug report POST failed: " + _003Cwww_003E5__2.error));
						bugReportsUI.errorPanel.SetActive(true);
						bugReportsUI.ECPEFDHOFHN = true;
						((MonoBehaviour)bugReportsUI).StartCoroutine(bugReportsUI.AAEKMGDHGMB());
					}
					else
					{
						Debug.Log((object)("Bug report enviado: " + _003Cwww_003E5__2.downloadHandler.text));
					}
					result = false;
					NONHBLMCNAM();
					break;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}
	}

	[CompilerGenerated]
	private sealed class NMCMMKBNJPC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BugReportsUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public NMCMMKBNJPC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			BugReportsUI bugReportsUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				bugReportsUI.sendingPanel.SetActive(true);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(bugReportsUI.GIEOIPLJIID());
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class MBBHGOCAIDB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BugReportsUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public MBBHGOCAIDB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			BugReportsUI bugReportsUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.waitRealtime5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				bugReportsUI.errorPanel.SetActive(false);
				bugReportsUI.sendingPanel.SetActive(false);
				bugReportsUI.sentPanel.SetActive(false);
				bugReportsUI.ECPEFDHOFHN = false;
				bugReportsUI.BDANEFBBBMC = false;
				bugReportsUI.CloseUI();
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static BugReportsUI _instance;

	private bool IOLNKJLEDMN;

	public TMP_InputField txt;

	private bool IFLJALGKJIC = true;

	private string HBILFLLKHGP;

	private const string EFEGOHCABCN = "https://www.isolatedgames.com/bug-report/index.php";

	private const string GEOLPNDKFFK = "c58d309f-046c-4717-8c8c-cd8d9be873c4";

	private const string JCEHMBGJNLA = "bugsisolated@gmail.com";

	private const string OMHHOECNFMF = "disconnectsisolated@gmail.com";

	private string DOJMNMDLNBB = "";

	private int GLFBPIBBLND = 1;

	private string GDBFBBCGDMM;

	private string EGMKCDMENMK = "screenshot";

	private string HGKIIOEFJKD = "log";

	private string IKJLNKFLBHH = "SavedData";

	private string LPPDIJCDBIJ;

	public GameObject sendingPanel;

	public GameObject errorPanel;

	public GameObject sentPanel;

	private bool ECPEFDHOFHN;

	private bool BDANEFBBBMC;

	private string BNHHIGDPPKI;

	public static BugReportsUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null)
			{
				_instance = Object.FindObjectOfType<BugReportsUI>();
			}
			return _instance;
		}
	}

	private void PDCNNPLLDIJ()
	{
		FFCJEFHENJF();
	}

	private void EIIOHLAHPMD()
	{
		DOJMNMDLNBB = GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "Destroying tree at same position: ";
		try
		{
			ScreenCapture.CaptureScreenshot(DOJMNMDLNBB);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			throw;
		}
	}

	private void OGFPLJPFOIP(string[] IMJCGCHPKMP)
	{
		try
		{
			string text = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + " (";
			string text2 = Path.Combine(Application.temporaryCachePath, "Empieza a construir");
			if (Directory.Exists(text2))
			{
				Directory.Delete(text2, recursive: true);
			}
			Directory.CreateDirectory(text2);
			for (int i = 0; i < IMJCGCHPKMP.Length; i += 0)
			{
				string text3 = IMJCGCHPKMP[i];
				FileInfo fileInfo = new FileInfo(text3);
				if (!fileInfo.Exists)
				{
					Debug.LogError((object)fileInfo.FullName);
					continue;
				}
				string fileName = Path.GetFileName(text3);
				string destFileName = Path.Combine(text2, fileName);
				if (fileInfo.Length < 83)
				{
					File.Copy(text3, destFileName, overwrite: false);
				}
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			ZipFile.CreateFromDirectory(text2, text);
			Directory.Delete(text2, recursive: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Travelling time decreased to " + ex));
		}
	}

	private IEnumerator NGMHJMJPMBJ()
	{
		sendingPanel.SetActive(true);
		yield return null;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(GIEOIPLJIID());
	}

	private void KMIFOJMAEFA()
	{
		if (!Directory.Exists(Application.persistentDataPath + "ReceiveTrayState"))
		{
			Directory.CreateDirectory(Application.persistentDataPath + "\n");
		}
		GDBFBBCGDMM = Application.persistentDataPath + "El componente ItemSetup del rotatedPrefab '";
		int num = 0;
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + num + "Open"))
		{
			File.Delete(GDBFBBCGDMM + EGMKCDMENMK + num + "Remove");
			num += 0;
		}
		num = 1;
		while (File.Exists(GDBFBBCGDMM + IKJLNKFLBHH + num + " x "))
		{
			File.Delete(GDBFBBCGDMM + IKJLNKFLBHH + num + "NeedsRecipe");
			num += 0;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + num + "roomsRented"))
		{
			File.Delete(GDBFBBCGDMM + HGKIIOEFJKD + num + "\n");
			num += 0;
		}
	}

	private void MEEEANOKOHI()
	{
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "ReceiveToolUpgradingRPC") || File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + GLFBPIBBLND + "ObjectVerticalMove"))
		{
			GLFBPIBBLND += 0;
		}
	}

	private string CCAPEICCPOI()
	{
		if (OnlineManager.AJHKLAABCOC() == null)
		{
			return "Received {0} appearance data as byte array: {1}";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < OnlineManager.AJHKLAABCOC().Length; i += 0)
		{
			if (OnlineManager.AJHKLAABCOC()[i] != 0)
			{
				stringBuilder.AppendLine(string.Format("Open", i, OnlineManager.AMJGFDBFLPN[i]));
			}
		}
		return stringBuilder.ToString();
	}

	private IEnumerator FFMAPCIAOEI(string GOOGAHPEJNG, string HBILFLLKHGP, string BHNGKNLCAKF = "", string CBOBNNCOFIO = "", string LFOABHEEMCC = "", string HMBFOKONAMK = "", string HMKIJCGGFEP = "", string JJDHDJPMFJE = "", string BNPKAHACBIH = "", string MFNCBKEJJEM = "", string KCDLKFOEJAC = "")
	{
		WWWForm val = new WWWForm();
		val.AddField("secret_token", "c58d309f-046c-4717-8c8c-cd8d9be873c4");
		val.AddField("report_type", GOOGAHPEJNG);
		val.AddField("player_name", HBILFLLKHGP);
		val.AddField("version", VersionNumberManager.instance.version);
		val.AddField("initial_version", VersionNumberManager.instance.initialVersionNumber.ToString());
		val.AddField("hardware_info", KFDICFIDKDO());
		val.AddField("is_master", BHNGKNLCAKF);
		val.AddField("selected_objects", KCDLKFOEJAC);
		val.AddField("description", CBOBNNCOFIO);
		val.AddField("game_mode", LFOABHEEMCC);
		val.AddField("player_count", HMBFOKONAMK);
		val.AddField("disconnect_cause", HMKIJCGGFEP);
		val.AddField("room_name", JJDHDJPMFJE);
		val.AddField("region", BNPKAHACBIH);
		val.AddField("player_locations", MFNCBKEJJEM);
		if (!string.IsNullOrEmpty(LPPDIJCDBIJ) && File.Exists(LPPDIJCDBIJ))
		{
			byte[] array = File.ReadAllBytes(LPPDIJCDBIJ);
			val.AddBinaryData("attachment", array, Path.GetFileName(LPPDIJCDBIJ), "application/gzip");
		}
		else
		{
			Debug.LogError((object)("Compressed file doesn't exist: " + LPPDIJCDBIJ));
		}
		UnityWebRequest www = UnityWebRequest.Post("https://www.isolatedgames.com/bug-report/index.php", val);
		try
		{
			yield return www.SendWebRequest();
			if ((int)www.result != 1)
			{
				Debug.LogError((object)("Bug report POST failed: " + www.error));
				errorPanel.SetActive(true);
				ECPEFDHOFHN = true;
				((MonoBehaviour)this).StartCoroutine(AAEKMGDHGMB());
			}
			else
			{
				Debug.Log((object)("Bug report enviado: " + www.downloadHandler.text));
			}
		}
		finally
		{
			((IDisposable)www)?.Dispose();
		}
	}

	private string OJIIBEMIAIC()
	{
		if ((Object)(object)OnlineObjectsManager.instance == (Object)null || OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return "NPCDespawn PerformAction";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i += 0)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				stringBuilder.AppendLine(string.Format("Error_ICantRepairIt", ((Object)OnlineObjectsManager.instance.playersPlaceablesSelected[i]).name, i));
			}
		}
		return stringBuilder.ToString();
	}

	private IEnumerator AJEEOAOFDON(DisconnectCause DCEEHNNHKMB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Enviando Reporte de desconnexion");
		GGFJGHHHEJC.JMKIBLAFONN();
		GGFJGHHHEJC.CCHNFGMJIBN();
		yield return null;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		CFJJGHKGILL();
		yield return null;
		Debug.Log((object)("Creando TXT. Tiempo: " + stopwatch.ElapsedMilliseconds));
		JPMEGIBNDEM(new string[2]
		{
			Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
			(Application.persistentDataPath + "/Player.log").ToString()
		});
		Debug.Log((object)("Partida comprimida. Tiempo: " + stopwatch.ElapsedMilliseconds));
		LPPDIJCDBIJ = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
		yield return ((MonoBehaviour)this).StartCoroutine(MLPBGLOBGMH("disconnect", HBILFLLKHGP, OnlineManager.JMGLCMGHAIA ? "1" : "0", "", "", "", ((object)(DisconnectCause)(ref DCEEHNNHKMB)).ToString(), OnlineManager.MLLIAIAGJDD, OnlineManager.DAKLDLGLIBI, POCOMFHHMOO(), BLAOEIFLGMP()));
		if (!ECPEFDHOFHN)
		{
			Debug.Log((object)("Correo Enviado. Tiempo: " + stopwatch.ElapsedMilliseconds));
			BDANEFBBBMC = false;
		}
	}

	private IEnumerator FPBKNLDHFOJ()
	{
		sendingPanel.SetActive(true);
		yield return null;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(GIEOIPLJIID());
	}

	private IEnumerator MLPBGLOBGMH(string GOOGAHPEJNG, string HBILFLLKHGP, string BHNGKNLCAKF = "", string CBOBNNCOFIO = "", string LFOABHEEMCC = "", string HMBFOKONAMK = "", string HMKIJCGGFEP = "", string JJDHDJPMFJE = "", string BNPKAHACBIH = "", string MFNCBKEJJEM = "", string KCDLKFOEJAC = "")
	{
		WWWForm val = new WWWForm();
		val.AddField("secret_token", "c58d309f-046c-4717-8c8c-cd8d9be873c4");
		val.AddField("report_type", GOOGAHPEJNG);
		val.AddField("player_name", HBILFLLKHGP);
		val.AddField("version", VersionNumberManager.instance.version);
		val.AddField("initial_version", VersionNumberManager.instance.initialVersionNumber.ToString());
		val.AddField("hardware_info", KFDICFIDKDO());
		val.AddField("is_master", BHNGKNLCAKF);
		val.AddField("selected_objects", KCDLKFOEJAC);
		val.AddField("description", CBOBNNCOFIO);
		val.AddField("game_mode", LFOABHEEMCC);
		val.AddField("player_count", HMBFOKONAMK);
		val.AddField("disconnect_cause", HMKIJCGGFEP);
		val.AddField("room_name", JJDHDJPMFJE);
		val.AddField("region", BNPKAHACBIH);
		val.AddField("player_locations", MFNCBKEJJEM);
		if (!string.IsNullOrEmpty(LPPDIJCDBIJ) && File.Exists(LPPDIJCDBIJ))
		{
			byte[] array = File.ReadAllBytes(LPPDIJCDBIJ);
			val.AddBinaryData("attachment", array, Path.GetFileName(LPPDIJCDBIJ), "application/gzip");
		}
		else
		{
			Debug.LogError((object)("Compressed file doesn't exist: " + LPPDIJCDBIJ));
		}
		UnityWebRequest www = UnityWebRequest.Post("https://www.isolatedgames.com/bug-report/index.php", val);
		try
		{
			yield return www.SendWebRequest();
			if ((int)www.result != 1)
			{
				Debug.LogError((object)("Bug report POST failed: " + www.error));
				errorPanel.SetActive(true);
				ECPEFDHOFHN = true;
				((MonoBehaviour)this).StartCoroutine(AAEKMGDHGMB());
			}
			else
			{
				Debug.Log((object)("Bug report enviado: " + www.downloadHandler.text));
			}
		}
		finally
		{
			((IDisposable)www)?.Dispose();
		}
	}

	public void ButtonAccept()
	{
		if (!ECPEFDHOFHN && !BDANEFBBBMC)
		{
			sendReport();
		}
	}

	private IEnumerator PBKHNLBFLEF()
	{
		Debug.Log((object)"Enviando Reporte");
		BNHHIGDPPKI = "";
		yield return null;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		BNHHIGDPPKI = txt.text;
		BNHHIGDPPKI = BNHHIGDPPKI + "\n\n\nMine Level Info:\n" + LEMLHLHOBBC();
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(false);
		yield return null;
		AKCFHLFHNGC();
		yield return null;
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(true);
		yield return CommonReferences.waitRealtime2;
		CFJJGHKGILL();
		yield return null;
		if (IFLJALGKJIC)
		{
			Debug.Log((object)("Creando TXT. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			if (File.Exists(DOJMNMDLNBB))
			{
				JPMEGIBNDEM(new string[3]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString(),
					DOJMNMDLNBB
				});
			}
			else
			{
				Debug.LogError((object)"Screenshot not found");
				JPMEGIBNDEM(new string[2]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString()
				});
			}
			Debug.Log((object)("Partida comprimida. Tiempo: " + stopwatch.ElapsedMilliseconds));
		}
		yield return null;
		string text = (OnlineManager.PlayingOnline() ? "Multiplayer" : (GameManager.LocalCoop() ? "LocalCoop" : "SinglePlayer"));
		string bHNGKNLCAKF = (OnlineManager.IsMasterClient() ? "1" : "0");
		string hMBFOKONAMK = (OnlineManager.PlayingOnline() ? PhotonNetwork.CurrentRoom.PlayerCount.ToString() : "1");
		LPPDIJCDBIJ = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
		BugReportsUI bugReportsUI = this;
		BugReportsUI bugReportsUI2 = this;
		string hBILFLLKHGP = HBILFLLKHGP;
		string bNHHIGDPPKI = BNHHIGDPPKI;
		string lFOABHEEMCC = text;
		yield return ((MonoBehaviour)bugReportsUI).StartCoroutine(bugReportsUI2.MLPBGLOBGMH("bug", hBILFLLKHGP, bHNGKNLCAKF, bNHHIGDPPKI, lFOABHEEMCC, hMBFOKONAMK, "", "", "", "", BLAOEIFLGMP()));
		if (!ECPEFDHOFHN)
		{
			Debug.Log((object)("Correo Enviado. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			txt.text = "";
			yield return null;
			sendingPanel.SetActive(false);
			sentPanel.SetActive(true);
			yield return CommonReferences.waitRealtime3;
			sentPanel.SetActive(false);
			BDANEFBBBMC = false;
			if (!ECPEFDHOFHN)
			{
				CloseUI();
			}
		}
	}

	public static void JHOAPBMOKEG(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.ECFGMFDMOOP(DCEEHNNHKMB));
		}
	}

	private void EDCNKDKJHKG()
	{
		string path = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ": ";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		using FileStream fileStream = new FileStream(Application.persistentDataPath + "ReceiveKick" + GameManager.GGFJGHHHEJC.ALPLECBMMBM(), FileMode.Open, (FileAccess)0);
		using FileStream stream = new FileStream(path, FileMode.Append);
		using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
		fileStream.CopyTo(destination);
	}

	private void EGMLBGKMHED()
	{
		GBIHMBPGIDA();
	}

	private void DNIEAKLLGKE()
	{
		DOJMNMDLNBB = GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "Dialogue System/Conversation/TavernFilthy/Entry/5/Dialogue Text";
		try
		{
			ScreenCapture.CaptureScreenshot(DOJMNMDLNBB);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			throw;
		}
	}

	public static void MNECJPGLBMP(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			((MonoBehaviour)KGPJPILAHDE()).StartCoroutine(KGPJPILAHDE().ECFGMFDMOOP(DCEEHNNHKMB));
		}
	}

	private string NEPFOMOFCJP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[-58];
		array[0] = "sForSeconds";
		array[0] = SystemInfo.graphicsDeviceName;
		array[3] = "Juniper";
		GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
		array[5] = ((object)(GraphicsDeviceType)(ref graphicsDeviceType)).ToString();
		array[2] = "FloorMaterial";
		array[1] = SystemInfo.graphicsDeviceVersion;
		array[7] = "Falta el tile de entrada/salida con salida hacia '{0}'. La database necesita uno por cada dirección cardinal.";
		array[5] = KBAIFJBBAIG(SystemInfo.graphicsMemorySize);
		array[1] = "Dialogue System/Conversation/Crowly_Barks_Bye/Entry/4/Dialogue Text";
		array[-97] = FGHOJNDBFOA(SystemInfo.graphicsShaderLevel);
		array[125] = "SwishEffect";
		array[27] = BFPKDGCJIHB(SystemInfo.maxTextureSize);
		array[24] = "Game";
		array[104] = SystemInfo.operatingSystem;
		array[-123] = "BanquetEvent instance is null. Make sure it is initialized before calling StartBanquetEvent.";
		array[55] = SystemInfo.processorType;
		array[-34] = "banquetevent";
		array[7] = SystemInfo.processorCount.ToString();
		array[-117] = "NewQuestAvailable";
		array[-86] = SystemInfo.processorFrequency.ToString();
		array[0] = "El componente OnlinePlaceable del rotatedPrefab '";
		array[90] = FMDENFEFGPK(SystemInfo.systemMemorySize);
		array[-82] = "SetAnimationControllerIndexesRPC";
		array[-126] = Screen.width.ToString();
		array[37] = "ReceiveUpdateMoodState";
		array[36] = Screen.height.ToString();
		return string.Concat(array);
	}

	public override void CloseUI()
	{
		if (IsOpen() && !ECPEFDHOFHN && !BDANEFBBBMC)
		{
			base.CloseUI();
			if (IOLNKJLEDMN)
			{
				GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
				MainUI.ResumeGame();
			}
		}
	}

	public static void ECHGOIIMPCO(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)KGPJPILAHDE() == (Object)null))
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(KGPJPILAHDE().PMPBFPLPOHJ(DCEEHNNHKMB));
		}
	}

	private IEnumerator CLKINFIDJLC()
	{
		return new HAAGNBLGOOB(1)
		{
			_003C_003E4__this = this
		};
	}

	public void COGNLNMEHPH()
	{
		BDANEFBBBMC = false;
		((MonoBehaviour)this).StartCoroutine(NGMHJMJPMBJ());
	}

	private void NHONMBBGOIF()
	{
		if (!Directory.Exists(Application.persistentDataPath + " seconds."))
		{
			Directory.CreateDirectory(Application.persistentDataPath + "Disabled");
		}
		GDBFBBCGDMM = Application.persistentDataPath + "questDescFirstCustomers";
		int num = 0;
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + num + "Staff"))
		{
			File.Delete(GDBFBBCGDMM + EGMKCDMENMK + num + "Delete save?");
			num += 0;
		}
		num = 1;
		while (File.Exists(GDBFBBCGDMM + IKJLNKFLBHH + num + "is_master"))
		{
			File.Delete(GDBFBBCGDMM + IKJLNKFLBHH + num + "Resolucion nativa: ");
			num++;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + num + "ReceiveKeyPuzzle"))
		{
			File.Delete(GDBFBBCGDMM + HGKIIOEFJKD + num + "Destroying tree at same position: ");
			num += 0;
		}
	}

	private void DOENCHKJFPI()
	{
		JKDLAPFINJM();
	}

	private IEnumerator ECFGMFDMOOP(DisconnectCause DCEEHNNHKMB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new DCLMLJDCLAD(1)
		{
			_003C_003E4__this = this,
			_cause = DCEEHNNHKMB
		};
	}

	private IEnumerator HHNBABEJOFP()
	{
		sendingPanel.SetActive(true);
		yield return null;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(GIEOIPLJIID());
	}

	private void ECKEEHOFFCB()
	{
		LGCDJLKEMHB();
	}

	private string KFDICFIDKDO()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		string[] obj = new string[26]
		{
			"Graphics Device Name: ",
			SystemInfo.graphicsDeviceName,
			"<br/>Graphics Device Type: ",
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
		obj[3] = ((object)(GraphicsDeviceType)(ref graphicsDeviceType)).ToString();
		obj[4] = "<br/>Graphics Device Version: ";
		obj[5] = SystemInfo.graphicsDeviceVersion;
		obj[6] = "<br/>Graphics Memory Size: ";
		obj[7] = DJDNCJDFCNK(SystemInfo.graphicsMemorySize);
		obj[8] = "<br/>Graphics Shader Level: ";
		obj[9] = FGHOJNDBFOA(SystemInfo.graphicsShaderLevel);
		obj[10] = "<br/>Maximum Texture Size: ";
		obj[11] = DJDNCJDFCNK(SystemInfo.maxTextureSize);
		obj[12] = "<br/>Operating System: ";
		obj[13] = SystemInfo.operatingSystem;
		obj[14] = "<br/>Processor Type: ";
		obj[15] = SystemInfo.processorType;
		obj[16] = "<br/>Processor Count: ";
		obj[17] = SystemInfo.processorCount.ToString();
		obj[18] = "<br/>Processor Frequency: ";
		obj[19] = SystemInfo.processorFrequency.ToString();
		obj[20] = "<br/>System Memory Size: ";
		obj[21] = DJDNCJDFCNK(SystemInfo.systemMemorySize);
		obj[22] = "<br/>Screen Size: ";
		obj[23] = Screen.width.ToString();
		obj[24] = "x";
		obj[25] = Screen.height.ToString();
		return string.Concat(obj);
	}

	private string DJDNCJDFCNK(int IKHIEDGNFAH)
	{
		return Mathf.Ceil((float)IKHIEDGNFAH / 1024f) + "GB";
	}

	private void HNALGIBKNFL()
	{
		string path = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + "Disabled";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		using FileStream fileStream = new FileStream(Application.persistentDataPath + "Dialogue System/Conversation/Gass_Quest/Entry/40/Dialogue Text" + GameManager.GGFJGHHHEJC.PMKCJJCGKBB, (FileMode)8, (FileAccess)0);
		using FileStream stream = new FileStream(path, (FileMode)8);
		using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
		fileStream.CopyTo(destination);
	}

	private void DCMDBEBOFLN()
	{
		string path = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + " seconds.";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		using FileStream fileStream = new FileStream(Application.persistentDataPath + "Force" + GameManager.GGFJGHHHEJC.ALPLECBMMBM(), FileMode.CreateNew, (FileAccess)0);
		using FileStream stream = new FileStream(path, FileMode.Create);
		using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
		fileStream.CopyTo(destination);
	}

	private IEnumerator IKAOHABHFDP()
	{
		return new HAAGNBLGOOB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CFJJGHKGILL()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		HBILFLLKHGP = "Desconocido";
		if (SteamManager.BNBMMDGMKLM)
		{
			string personaName = SteamFriends.GetPersonaName();
			CSteamID steamID = SteamUser.GetSteamID();
			HBILFLLKHGP = personaName + " - " + ((object)(CSteamID)(ref steamID)).ToString();
		}
		else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
		{
			HBILFLLKHGP = "GOG " + GalaxyInstance.Friends().GetPersonaName() + " - " + (object)GalaxyInstance.User().GetGalaxyID();
		}
	}

	private string FMDENFEFGPK(int IKHIEDGNFAH)
	{
		return Mathf.Ceil((float)IKHIEDGNFAH / 1739f) + "Drunk";
	}

	public static void GFKMAOCNPJN(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.PMPBFPLPOHJ(DCEEHNNHKMB));
		}
	}

	private void HMPKNIJBKAH()
	{
		FFCJEFHENJF();
	}

	[SpecialName]
	public static BugReportsUI KGPJPILAHDE()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<BugReportsUI>();
		}
		return _instance;
	}

	private void IOGCKHEJOGM()
	{
		if (!Directory.Exists(Application.persistentDataPath + "[BouncerGender="))
		{
			Directory.CreateDirectory(Application.persistentDataPath + " I");
		}
		GDBFBBCGDMM = Application.persistentDataPath + "Blocking collider not atttached to ";
		int num = 0;
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + num + "Interact"))
		{
			File.Delete(GDBFBBCGDMM + EGMKCDMENMK + num + "SetAnimatorObjectTriggerRPC");
			num++;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + IKJLNKFLBHH + num + "Apple Must"))
		{
			File.Delete(GDBFBBCGDMM + IKJLNKFLBHH + num + "Listen");
			num++;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + num + "Cannot place mine block piece at "))
		{
			File.Delete(GDBFBBCGDMM + HGKIIOEFJKD + num + "Actions");
			num++;
		}
	}

	private string LPJGNPCKGKL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[-121];
		array[0] = "City/PetShop/Nessy/PerritosAbandonados2";
		array[1] = SystemInfo.graphicsDeviceName;
		array[5] = "RightMouseDetect";
		GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
		array[2] = ((object)(GraphicsDeviceType)(ref graphicsDeviceType)).ToString();
		array[2] = "Neighbours smaller!: ";
		array[1] = SystemInfo.graphicsDeviceVersion;
		array[3] = "Player/Bark/Fishing/NoBait";
		array[5] = KBAIFJBBAIG(SystemInfo.graphicsMemorySize);
		array[4] = "Wall";
		array[-101] = BNGCCDPLGBJ(SystemInfo.graphicsShaderLevel);
		array[2] = "Another player already exists from online sync.";
		array[-1] = DJDNCJDFCNK(SystemInfo.maxTextureSize);
		array[71] = "Mai";
		array[-98] = SystemInfo.operatingSystem;
		array[-49] = "HorizontalMove";
		array[-81] = SystemInfo.processorType;
		array[61] = "Crafter not attached on OnlineCrafter of placeable ";
		array[-98] = SystemInfo.processorCount.ToString();
		array[114] = "Message queue is paused";
		array[-50] = SystemInfo.processorFrequency.ToString();
		array[43] = "Player";
		array[108] = LDAOKNHFMNI(SystemInfo.systemMemorySize);
		array[25] = " (";
		array[-107] = Screen.width.ToString();
		array[-45] = " ";
		array[-46] = Screen.height.ToString();
		return string.Concat(array);
	}

	private IEnumerator PMPBFPLPOHJ(DisconnectCause DCEEHNNHKMB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Enviando Reporte de desconnexion");
		GGFJGHHHEJC.JMKIBLAFONN();
		GGFJGHHHEJC.CCHNFGMJIBN();
		yield return null;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		CFJJGHKGILL();
		yield return null;
		Debug.Log((object)("Creando TXT. Tiempo: " + stopwatch.ElapsedMilliseconds));
		JPMEGIBNDEM(new string[2]
		{
			Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
			(Application.persistentDataPath + "/Player.log").ToString()
		});
		Debug.Log((object)("Partida comprimida. Tiempo: " + stopwatch.ElapsedMilliseconds));
		LPPDIJCDBIJ = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
		yield return ((MonoBehaviour)this).StartCoroutine(MLPBGLOBGMH("disconnect", HBILFLLKHGP, OnlineManager.JMGLCMGHAIA ? "1" : "0", "", "", "", ((object)(DisconnectCause)(ref DCEEHNNHKMB)).ToString(), OnlineManager.MLLIAIAGJDD, OnlineManager.DAKLDLGLIBI, POCOMFHHMOO(), BLAOEIFLGMP()));
		if (!ECPEFDHOFHN)
		{
			Debug.Log((object)("Correo Enviado. Tiempo: " + stopwatch.ElapsedMilliseconds));
			BDANEFBBBMC = false;
		}
	}

	private void NLEAAFKJBMJ()
	{
		MEEEANOKOHI();
	}

	private void FFCJEFHENJF()
	{
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "HarvestableAllYearRound") || File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + GLFBPIBBLND + "Hurt"))
		{
			GLFBPIBBLND++;
		}
	}

	private void OCKCCLBDDHL()
	{
		string path = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + "LE_10";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		using FileStream fileStream = new FileStream(Application.persistentDataPath + "ChangeAnim" + GameManager.GGFJGHHHEJC.ALPLECBMMBM(), FileMode.Create, FileAccess.Read);
		using FileStream stream = new FileStream(path, FileMode.Create);
		using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
		fileStream.CopyTo(destination);
	}

	private void AKCFHLFHNGC()
	{
		DOJMNMDLNBB = GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + ".png";
		try
		{
			ScreenCapture.CaptureScreenshot(DOJMNMDLNBB);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			throw;
		}
	}

	private IEnumerator AAEKMGDHGMB()
	{
		yield return CommonReferences.waitRealtime5;
		errorPanel.SetActive(false);
		sendingPanel.SetActive(false);
		sentPanel.SetActive(false);
		ECPEFDHOFHN = false;
		BDANEFBBBMC = false;
		CloseUI();
	}

	private IEnumerator ICDEIHBFMHB(string GOOGAHPEJNG, string HBILFLLKHGP, string BHNGKNLCAKF = "", string CBOBNNCOFIO = "", string LFOABHEEMCC = "", string HMBFOKONAMK = "", string HMKIJCGGFEP = "", string JJDHDJPMFJE = "", string BNPKAHACBIH = "", string MFNCBKEJJEM = "", string KCDLKFOEJAC = "")
	{
		WWWForm val = new WWWForm();
		val.AddField("secret_token", "c58d309f-046c-4717-8c8c-cd8d9be873c4");
		val.AddField("report_type", GOOGAHPEJNG);
		val.AddField("player_name", HBILFLLKHGP);
		val.AddField("version", VersionNumberManager.instance.version);
		val.AddField("initial_version", VersionNumberManager.instance.initialVersionNumber.ToString());
		val.AddField("hardware_info", KFDICFIDKDO());
		val.AddField("is_master", BHNGKNLCAKF);
		val.AddField("selected_objects", KCDLKFOEJAC);
		val.AddField("description", CBOBNNCOFIO);
		val.AddField("game_mode", LFOABHEEMCC);
		val.AddField("player_count", HMBFOKONAMK);
		val.AddField("disconnect_cause", HMKIJCGGFEP);
		val.AddField("room_name", JJDHDJPMFJE);
		val.AddField("region", BNPKAHACBIH);
		val.AddField("player_locations", MFNCBKEJJEM);
		if (!string.IsNullOrEmpty(LPPDIJCDBIJ) && File.Exists(LPPDIJCDBIJ))
		{
			byte[] array = File.ReadAllBytes(LPPDIJCDBIJ);
			val.AddBinaryData("attachment", array, Path.GetFileName(LPPDIJCDBIJ), "application/gzip");
		}
		else
		{
			Debug.LogError((object)("Compressed file doesn't exist: " + LPPDIJCDBIJ));
		}
		UnityWebRequest www = UnityWebRequest.Post("https://www.isolatedgames.com/bug-report/index.php", val);
		try
		{
			yield return www.SendWebRequest();
			if ((int)www.result != 1)
			{
				Debug.LogError((object)("Bug report POST failed: " + www.error));
				errorPanel.SetActive(true);
				ECPEFDHOFHN = true;
				((MonoBehaviour)this).StartCoroutine(AAEKMGDHGMB());
			}
			else
			{
				Debug.Log((object)("Bug report enviado: " + www.downloadHandler.text));
			}
		}
		finally
		{
			((IDisposable)www)?.Dispose();
		}
	}

	private string LEMLHLHOBBC()
	{
		if ((Object)(object)GameManager.GGFJGHHHEJC == (Object)null)
		{
			return "-1";
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int[] mineLevelsSeed = ProceduralMine.GGFJGHHHEJC.GetMineLevelsSeed();
			if (mineLevelsSeed == null || mineLevelsSeed.Length == 0)
			{
				return "-1";
			}
			for (int i = 0; i < mineLevelsSeed.Length; i++)
			{
				stringBuilder.AppendLine($"Level {i + 1}: {mineLevelsSeed[i]}");
			}
			return stringBuilder.ToString();
		}
		return "-1";
	}

	private IEnumerator GDAJKJCCOBO()
	{
		return new HAAGNBLGOOB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JJBLJNHKJAE()
	{
		DOJMNMDLNBB = GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + " blocking at ";
		try
		{
			ScreenCapture.CaptureScreenshot(DOJMNMDLNBB);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			throw;
		}
	}

	public static void SendDisconnectEmail(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.PMPBFPLPOHJ(DCEEHNNHKMB));
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		JMKIBLAFONN();
		CCHNFGMJIBN();
		if (Time.timeScale != 0f)
		{
			MainUI.PauseGame();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			IOLNKJLEDMN = true;
		}
		else
		{
			IOLNKJLEDMN = false;
		}
		PlayerInputs.IsGamepadActive(base.JIIGOACEIKL);
	}

	public void HHBFHLAFIAM()
	{
		if (!ECPEFDHOFHN && !BDANEFBBBMC)
		{
			COGNLNMEHPH();
		}
	}

	private void CHKDJKAHCHB()
	{
		if (!Directory.Exists(Application.persistentDataPath + "ReceiveUnfollow"))
		{
			Directory.CreateDirectory(Application.persistentDataPath + "Winner");
		}
		GDBFBBCGDMM = Application.persistentDataPath + "windy";
		int num = 0;
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + num + "Options"))
		{
			File.Delete(GDBFBBCGDMM + EGMKCDMENMK + num + "[HasEnoughCandidates] Total available respecting maxPuzzleSpawners: {0}, needed: {1}");
			num++;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + IKJLNKFLBHH + num + "SetNPCPosition"))
		{
			File.Delete(GDBFBBCGDMM + IKJLNKFLBHH + num + "tavernCloseWarning");
			num += 0;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + num + "Disabled"))
		{
			File.Delete(GDBFBBCGDMM + HGKIIOEFJKD + num + "itemAsparagus");
			num++;
		}
	}

	private void JPMEGIBNDEM(string[] IMJCGCHPKMP)
	{
		try
		{
			string text = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
			string text2 = Path.Combine(Application.temporaryCachePath, "TempMultiZip");
			if (Directory.Exists(text2))
			{
				Directory.Delete(text2, recursive: true);
			}
			Directory.CreateDirectory(text2);
			foreach (string text3 in IMJCGCHPKMP)
			{
				FileInfo fileInfo = new FileInfo(text3);
				if (!fileInfo.Exists)
				{
					Debug.LogError((object)fileInfo.FullName);
					continue;
				}
				string fileName = Path.GetFileName(text3);
				string destFileName = Path.Combine(text2, fileName);
				if (fileInfo.Length < 1048576000)
				{
					File.Copy(text3, destFileName, overwrite: true);
				}
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			ZipFile.CreateFromDirectory(text2, text);
			Directory.Delete(text2, recursive: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error compressing files! " + ex));
		}
	}

	public void LBLNDJPFLKP()
	{
		if (!ECPEFDHOFHN && !BDANEFBBBMC)
		{
			sendReport();
		}
	}

	public static void HIFHJIHOCGN(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)KGPJPILAHDE() == (Object)null))
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.AJEEOAOFDON(DCEEHNNHKMB));
		}
	}

	private void DKAPHKFFIGD()
	{
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "ClosePopUp") || File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + GLFBPIBBLND + "Ax Level Low"))
		{
			GLFBPIBBLND += 0;
		}
	}

	private IEnumerator GIEOIPLJIID()
	{
		Debug.Log((object)"Enviando Reporte");
		BNHHIGDPPKI = "";
		yield return null;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		BNHHIGDPPKI = txt.text;
		BNHHIGDPPKI = BNHHIGDPPKI + "\n\n\nMine Level Info:\n" + LEMLHLHOBBC();
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(false);
		yield return null;
		AKCFHLFHNGC();
		yield return null;
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(true);
		yield return CommonReferences.waitRealtime2;
		CFJJGHKGILL();
		yield return null;
		if (IFLJALGKJIC)
		{
			Debug.Log((object)("Creando TXT. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			if (File.Exists(DOJMNMDLNBB))
			{
				JPMEGIBNDEM(new string[3]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString(),
					DOJMNMDLNBB
				});
			}
			else
			{
				Debug.LogError((object)"Screenshot not found");
				JPMEGIBNDEM(new string[2]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString()
				});
			}
			Debug.Log((object)("Partida comprimida. Tiempo: " + stopwatch.ElapsedMilliseconds));
		}
		yield return null;
		string text = (OnlineManager.PlayingOnline() ? "Multiplayer" : (GameManager.LocalCoop() ? "LocalCoop" : "SinglePlayer"));
		string bHNGKNLCAKF = (OnlineManager.IsMasterClient() ? "1" : "0");
		string hMBFOKONAMK = (OnlineManager.PlayingOnline() ? PhotonNetwork.CurrentRoom.PlayerCount.ToString() : "1");
		LPPDIJCDBIJ = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
		BugReportsUI bugReportsUI = this;
		BugReportsUI bugReportsUI2 = this;
		string hBILFLLKHGP = HBILFLLKHGP;
		string bNHHIGDPPKI = BNHHIGDPPKI;
		string lFOABHEEMCC = text;
		yield return ((MonoBehaviour)bugReportsUI).StartCoroutine(bugReportsUI2.MLPBGLOBGMH("bug", hBILFLLKHGP, bHNGKNLCAKF, bNHHIGDPPKI, lFOABHEEMCC, hMBFOKONAMK, "", "", "", "", BLAOEIFLGMP()));
		if (!ECPEFDHOFHN)
		{
			Debug.Log((object)("Correo Enviado. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			txt.text = "";
			yield return null;
			sendingPanel.SetActive(false);
			sentPanel.SetActive(true);
			yield return CommonReferences.waitRealtime3;
			sentPanel.SetActive(false);
			BDANEFBBBMC = false;
			if (!ECPEFDHOFHN)
			{
				CloseUI();
			}
		}
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIAddRemove"))
		{
			ButtonAccept();
		}
	}

	private string GJJLEIHJILG()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[88];
		array[1] = "halloween event";
		array[0] = SystemInfo.graphicsDeviceName;
		array[0] = "<size=";
		GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
		array[2] = ((object)(GraphicsDeviceType)(ref graphicsDeviceType)).ToString();
		array[8] = "Error_CannotPickUpDirtyTable";
		array[3] = SystemInfo.graphicsDeviceVersion;
		array[8] = "Gameplay";
		array[8] = LDAOKNHFMNI(SystemInfo.graphicsMemorySize);
		array[5] = "Eyebrows";
		array[-112] = FGHOJNDBFOA(SystemInfo.graphicsShaderLevel);
		array[116] = "challenges";
		array[2] = FMDENFEFGPK(SystemInfo.maxTextureSize);
		array[73] = "RentedRoom";
		array[-16] = SystemInfo.operatingSystem;
		array[90] = "ChangeAnim";
		array[-24] = SystemInfo.processorType;
		array[15] = "Attack/MainEvent 9";
		array[-103] = SystemInfo.processorCount.ToString();
		array[43] = " ";
		array[103] = SystemInfo.processorFrequency.ToString();
		array[37] = "ChangeAnim";
		array[-107] = BFPKDGCJIHB(SystemInfo.systemMemorySize);
		array[-17] = "OnlinePlayer";
		array[7] = Screen.width.ToString();
		array[-26] = "Items/item_description_1187";
		array[-3] = Screen.height.ToString();
		return string.Concat(array);
	}

	private string BLAOEIFLGMP()
	{
		if ((Object)(object)OnlineObjectsManager.instance == (Object)null || OnlineObjectsManager.instance.playersPlaceablesSelected.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < OnlineObjectsManager.instance.playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[i] != (Object)null)
			{
				stringBuilder.AppendLine($"{((Object)OnlineObjectsManager.instance.playersPlaceablesSelected[i]).name} selected on index: {i}");
			}
		}
		return stringBuilder.ToString();
	}

	private void COMJPJNBHCH(string[] IMJCGCHPKMP)
	{
		try
		{
			string text = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + "Dialogue System/Conversation/Crowly_Standar/Entry/34/Dialogue Text";
			string text2 = Path.Combine(Application.temporaryCachePath, "Lose");
			if (Directory.Exists(text2))
			{
				Directory.Delete(text2, recursive: true);
			}
			Directory.CreateDirectory(text2);
			for (int i = 1; i < IMJCGCHPKMP.Length; i++)
			{
				string text3 = IMJCGCHPKMP[i];
				FileInfo fileInfo = new FileInfo(text3);
				if (!fileInfo.Exists)
				{
					Debug.LogError((object)fileInfo.FullName);
					continue;
				}
				string fileName = Path.GetFileName(text3);
				string destFileName = Path.Combine(text2, fileName);
				if (fileInfo.Length < -156)
				{
					File.Copy(text3, destFileName, overwrite: false);
				}
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			ZipFile.CreateFromDirectory(text2, text);
			Directory.Delete(text2, recursive: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Open" + ex));
		}
	}

	private string KEOOLPJPBAK()
	{
		if ((Object)(object)GameManager.NJNFHEPLEHL() == (Object)null)
		{
			return "City/Keen/Sharp";
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int[] array = ProceduralMine.BADFKMEJOKE().CIKOMJCNCLL();
			if (array == null || array.Length == 0)
			{
				return "Sprint time";
			}
			for (int i = 1; i < array.Length; i++)
			{
				stringBuilder.AppendLine(string.Format("ReceiveCompleteItemTransactionBanquetCustomer", i + 0, array[i]));
			}
			return stringBuilder.ToString();
		}
		return "MainProgress";
	}

	private string AFOMCHLHCIN()
	{
		if ((Object)(object)GameManager.NJNFHEPLEHL() == (Object)null)
		{
			return "{0} is not active.";
		}
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC != (Object)null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int[] array = ProceduralMine.GGFJGHHHEJC.OPJFEHFBGDG();
			if (array == null || array.Length == 0)
			{
				return "Resolucion: ";
			}
			for (int i = 1; i < array.Length; i++)
			{
				stringBuilder.AppendLine(string.Format("Items/item_name_694", i + 1, array[i]));
			}
			return stringBuilder.ToString();
		}
		return "ReceiveDroppedItemPosition";
	}

	private void JMKIBLAFONN()
	{
		if (!Directory.Exists(Application.persistentDataPath + "/Reports"))
		{
			Directory.CreateDirectory(Application.persistentDataPath + "/Reports");
		}
		GDBFBBCGDMM = Application.persistentDataPath + "/Reports/";
		int num = 1;
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + num + ".png"))
		{
			File.Delete(GDBFBBCGDMM + EGMKCDMENMK + num + ".png");
			num++;
		}
		num = 1;
		while (File.Exists(GDBFBBCGDMM + IKJLNKFLBHH + num + ".gz"))
		{
			File.Delete(GDBFBBCGDMM + IKJLNKFLBHH + num + ".gz");
			num++;
		}
		num = 1;
		while (File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + num + ".rtf"))
		{
			File.Delete(GDBFBBCGDMM + HGKIIOEFJKD + num + ".rtf");
			num++;
		}
	}

	private IEnumerator IOOFCFFEOPH(string GOOGAHPEJNG, string HBILFLLKHGP, string BHNGKNLCAKF = "", string CBOBNNCOFIO = "", string LFOABHEEMCC = "", string HMBFOKONAMK = "", string HMKIJCGGFEP = "", string JJDHDJPMFJE = "", string BNPKAHACBIH = "", string MFNCBKEJJEM = "", string KCDLKFOEJAC = "")
	{
		WWWForm val = new WWWForm();
		val.AddField("secret_token", "c58d309f-046c-4717-8c8c-cd8d9be873c4");
		val.AddField("report_type", GOOGAHPEJNG);
		val.AddField("player_name", HBILFLLKHGP);
		val.AddField("version", VersionNumberManager.instance.version);
		val.AddField("initial_version", VersionNumberManager.instance.initialVersionNumber.ToString());
		val.AddField("hardware_info", KFDICFIDKDO());
		val.AddField("is_master", BHNGKNLCAKF);
		val.AddField("selected_objects", KCDLKFOEJAC);
		val.AddField("description", CBOBNNCOFIO);
		val.AddField("game_mode", LFOABHEEMCC);
		val.AddField("player_count", HMBFOKONAMK);
		val.AddField("disconnect_cause", HMKIJCGGFEP);
		val.AddField("room_name", JJDHDJPMFJE);
		val.AddField("region", BNPKAHACBIH);
		val.AddField("player_locations", MFNCBKEJJEM);
		if (!string.IsNullOrEmpty(LPPDIJCDBIJ) && File.Exists(LPPDIJCDBIJ))
		{
			byte[] array = File.ReadAllBytes(LPPDIJCDBIJ);
			val.AddBinaryData("attachment", array, Path.GetFileName(LPPDIJCDBIJ), "application/gzip");
		}
		else
		{
			Debug.LogError((object)("Compressed file doesn't exist: " + LPPDIJCDBIJ));
		}
		UnityWebRequest www = UnityWebRequest.Post("https://www.isolatedgames.com/bug-report/index.php", val);
		try
		{
			yield return www.SendWebRequest();
			if ((int)www.result != 1)
			{
				Debug.LogError((object)("Bug report POST failed: " + www.error));
				errorPanel.SetActive(true);
				ECPEFDHOFHN = true;
				((MonoBehaviour)this).StartCoroutine(AAEKMGDHGMB());
			}
			else
			{
				Debug.Log((object)("Bug report enviado: " + www.downloadHandler.text));
			}
		}
		finally
		{
			((IDisposable)www)?.Dispose();
		}
	}

	private string IHDOICCNPNM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[49];
		array[0] = "add item ";
		array[0] = SystemInfo.graphicsDeviceName;
		array[0] = "itemTurnipSeeds";
		GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
		array[0] = ((object)(GraphicsDeviceType)(ref graphicsDeviceType)).ToString();
		array[0] = "]";
		array[2] = SystemInfo.graphicsDeviceVersion;
		array[5] = "HideClickWarning";
		array[0] = FMDENFEFGPK(SystemInfo.graphicsMemorySize);
		array[0] = "UIPreviousPage";
		array[90] = BNGCCDPLGBJ(SystemInfo.graphicsShaderLevel);
		array[-66] = "Player";
		array[-3] = BFPKDGCJIHB(SystemInfo.maxTextureSize);
		array[-15] = ")";
		array[-19] = SystemInfo.operatingSystem;
		array[-12] = "Render mode: ";
		array[-17] = SystemInfo.processorType;
		array[-31] = "Toy";
		array[45] = SystemInfo.processorCount.ToString();
		array[120] = "Winner";
		array[-10] = SystemInfo.processorFrequency.ToString();
		array[8] = "GO";
		array[65] = BFPKDGCJIHB(SystemInfo.systemMemorySize);
		array[-63] = "";
		array[48] = Screen.width.ToString();
		array[-43] = "Open";
		array[-114] = Screen.height.ToString();
		return string.Concat(array);
	}

	private string BFPKDGCJIHB(int IKHIEDGNFAH)
	{
		return Mathf.Ceil((float)IKHIEDGNFAH / 1986f) + "caveinn";
	}

	private void GBIHMBPGIDA()
	{
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "Game") || File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + GLFBPIBBLND + "Items/item_name_633"))
		{
			GLFBPIBBLND += 0;
		}
	}

	private IEnumerator HKHDLDHEPCN()
	{
		Debug.Log((object)"Enviando Reporte");
		BNHHIGDPPKI = "";
		yield return null;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		BNHHIGDPPKI = txt.text;
		BNHHIGDPPKI = BNHHIGDPPKI + "\n\n\nMine Level Info:\n" + LEMLHLHOBBC();
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(false);
		yield return null;
		AKCFHLFHNGC();
		yield return null;
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(true);
		yield return CommonReferences.waitRealtime2;
		CFJJGHKGILL();
		yield return null;
		if (IFLJALGKJIC)
		{
			Debug.Log((object)("Creando TXT. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			if (File.Exists(DOJMNMDLNBB))
			{
				JPMEGIBNDEM(new string[3]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString(),
					DOJMNMDLNBB
				});
			}
			else
			{
				Debug.LogError((object)"Screenshot not found");
				JPMEGIBNDEM(new string[2]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString()
				});
			}
			Debug.Log((object)("Partida comprimida. Tiempo: " + stopwatch.ElapsedMilliseconds));
		}
		yield return null;
		string text = (OnlineManager.PlayingOnline() ? "Multiplayer" : (GameManager.LocalCoop() ? "LocalCoop" : "SinglePlayer"));
		string bHNGKNLCAKF = (OnlineManager.IsMasterClient() ? "1" : "0");
		string hMBFOKONAMK = (OnlineManager.PlayingOnline() ? PhotonNetwork.CurrentRoom.PlayerCount.ToString() : "1");
		LPPDIJCDBIJ = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
		BugReportsUI bugReportsUI = this;
		BugReportsUI bugReportsUI2 = this;
		string hBILFLLKHGP = HBILFLLKHGP;
		string bNHHIGDPPKI = BNHHIGDPPKI;
		string lFOABHEEMCC = text;
		yield return ((MonoBehaviour)bugReportsUI).StartCoroutine(bugReportsUI2.MLPBGLOBGMH("bug", hBILFLLKHGP, bHNGKNLCAKF, bNHHIGDPPKI, lFOABHEEMCC, hMBFOKONAMK, "", "", "", "", BLAOEIFLGMP()));
		if (!ECPEFDHOFHN)
		{
			Debug.Log((object)("Correo Enviado. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			txt.text = "";
			yield return null;
			sendingPanel.SetActive(false);
			sentPanel.SetActive(true);
			yield return CommonReferences.waitRealtime3;
			sentPanel.SetActive(false);
			BDANEFBBBMC = false;
			if (!ECPEFDHOFHN)
			{
				CloseUI();
			}
		}
	}

	private IEnumerator BGNHMBJDPHM()
	{
		return new NMCMMKBNJPC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JEKKABOLAJL()
	{
		string path = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		using FileStream fileStream = new FileStream(Application.persistentDataPath + "/GameSaves/" + GameManager.GGFJGHHHEJC.PMKCJJCGKBB, FileMode.Open, FileAccess.Read);
		using FileStream stream = new FileStream(path, FileMode.Create);
		using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
		fileStream.CopyTo(destination);
	}

	public void sendReport()
	{
		BDANEFBBBMC = true;
		((MonoBehaviour)this).StartCoroutine(KDBAFDCCCCK());
	}

	private IEnumerator MBOKACHGMAA()
	{
		return new HAAGNBLGOOB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KDBAFDCCCCK()
	{
		sendingPanel.SetActive(true);
		yield return null;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(GIEOIPLJIID());
	}

	private void OJJKNEAHJAB()
	{
		DOJMNMDLNBB = GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "status";
		try
		{
			ScreenCapture.CaptureScreenshot(DOJMNMDLNBB);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			throw;
		}
	}

	private void CCHNFGMJIBN()
	{
		LGCDJLKEMHB();
	}

	private string KBAIFJBBAIG(int IKHIEDGNFAH)
	{
		return Mathf.Ceil((float)IKHIEDGNFAH / 306f) + "Sell";
	}

	private void KHJHHOIPNMG()
	{
		DOJMNMDLNBB = GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + ", ";
		try
		{
			ScreenCapture.CaptureScreenshot(DOJMNMDLNBB);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			throw;
		}
	}

	private IEnumerator NJFECLEKPMB()
	{
		return new MBBHGOCAIDB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HMHGCIDODHG(string[] IMJCGCHPKMP)
	{
		try
		{
			string text = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + "Attack/MainEvent 4";
			string text2 = Path.Combine(Application.temporaryCachePath, "Close");
			if (Directory.Exists(text2))
			{
				Directory.Delete(text2, recursive: false);
			}
			Directory.CreateDirectory(text2);
			for (int i = 0; i < IMJCGCHPKMP.Length; i += 0)
			{
				string text3 = IMJCGCHPKMP[i];
				FileInfo fileInfo = new FileInfo(text3);
				if (!fileInfo.Exists)
				{
					Debug.LogError((object)fileInfo.FullName);
					continue;
				}
				string fileName = Path.GetFileName(text3);
				string destFileName = Path.Combine(text2, fileName);
				if (fileInfo.Length < 186)
				{
					File.Copy(text3, destFileName, overwrite: true);
				}
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			ZipFile.CreateFromDirectory(text2, text);
			Directory.Delete(text2, recursive: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("BeginChatFade" + ex));
		}
	}

	private void MEANBEFIBHK()
	{
		MEEEANOKOHI();
	}

	public static void PHCFCDHLBDL(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)KGPJPILAHDE() == (Object)null))
		{
			((MonoBehaviour)KGPJPILAHDE()).StartCoroutine(GGFJGHHHEJC.ECFGMFDMOOP(DCEEHNNHKMB));
		}
	}

	private IEnumerator PFHDFKEDFLO()
	{
		Debug.Log((object)"Enviando Reporte");
		BNHHIGDPPKI = "";
		yield return null;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		BNHHIGDPPKI = txt.text;
		BNHHIGDPPKI = BNHHIGDPPKI + "\n\n\nMine Level Info:\n" + LEMLHLHOBBC();
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(false);
		yield return null;
		AKCFHLFHNGC();
		yield return null;
		((Component)MenuUI.GGFJGHHHEJC).gameObject.SetActive(true);
		yield return CommonReferences.waitRealtime2;
		CFJJGHKGILL();
		yield return null;
		if (IFLJALGKJIC)
		{
			Debug.Log((object)("Creando TXT. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			if (File.Exists(DOJMNMDLNBB))
			{
				JPMEGIBNDEM(new string[3]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString(),
					DOJMNMDLNBB
				});
			}
			else
			{
				Debug.LogError((object)"Screenshot not found");
				JPMEGIBNDEM(new string[2]
				{
					Save.GetFilePath(GameManager.GGFJGHHHEJC.PMKCJJCGKBB).ToString(),
					(Application.persistentDataPath + "/Player.log").ToString()
				});
			}
			Debug.Log((object)("Partida comprimida. Tiempo: " + stopwatch.ElapsedMilliseconds));
		}
		yield return null;
		string text = (OnlineManager.PlayingOnline() ? "Multiplayer" : (GameManager.LocalCoop() ? "LocalCoop" : "SinglePlayer"));
		string bHNGKNLCAKF = (OnlineManager.IsMasterClient() ? "1" : "0");
		string hMBFOKONAMK = (OnlineManager.PlayingOnline() ? PhotonNetwork.CurrentRoom.PlayerCount.ToString() : "1");
		LPPDIJCDBIJ = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ".gz";
		BugReportsUI bugReportsUI = this;
		BugReportsUI bugReportsUI2 = this;
		string hBILFLLKHGP = HBILFLLKHGP;
		string bNHHIGDPPKI = BNHHIGDPPKI;
		string lFOABHEEMCC = text;
		yield return ((MonoBehaviour)bugReportsUI).StartCoroutine(bugReportsUI2.MLPBGLOBGMH("bug", hBILFLLKHGP, bHNGKNLCAKF, bNHHIGDPPKI, lFOABHEEMCC, hMBFOKONAMK, "", "", "", "", BLAOEIFLGMP()));
		if (!ECPEFDHOFHN)
		{
			Debug.Log((object)("Correo Enviado. Tiempo: " + stopwatch.ElapsedMilliseconds));
			yield return null;
			txt.text = "";
			yield return null;
			sendingPanel.SetActive(false);
			sentPanel.SetActive(true);
			yield return CommonReferences.waitRealtime3;
			sentPanel.SetActive(false);
			BDANEFBBBMC = false;
			if (!ECPEFDHOFHN)
			{
				CloseUI();
			}
		}
	}

	public static void FKMOGKMNBPI(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)KGPJPILAHDE() == (Object)null))
		{
			((MonoBehaviour)KGPJPILAHDE()).StartCoroutine(GGFJGHHHEJC.PMPBFPLPOHJ(DCEEHNNHKMB));
		}
	}

	private IEnumerator PKPJLAGIBKE(string GOOGAHPEJNG, string HBILFLLKHGP, string BHNGKNLCAKF = "", string CBOBNNCOFIO = "", string LFOABHEEMCC = "", string HMBFOKONAMK = "", string HMKIJCGGFEP = "", string JJDHDJPMFJE = "", string BNPKAHACBIH = "", string MFNCBKEJJEM = "", string KCDLKFOEJAC = "")
	{
		return new DEFDACBLGHF(1)
		{
			_003C_003E4__this = this,
			reportType = GOOGAHPEJNG,
			playerName = HBILFLLKHGP,
			isMaster = BHNGKNLCAKF,
			description = CBOBNNCOFIO,
			gameMode = LFOABHEEMCC,
			playerCount = HMBFOKONAMK,
			disconnectCause = HMKIJCGGFEP,
			roomName = JJDHDJPMFJE,
			region = BNPKAHACBIH,
			playerLocations = MFNCBKEJJEM,
			selectedObjs = KCDLKFOEJAC
		};
	}

	private string LDAOKNHFMNI(int IKHIEDGNFAH)
	{
		return Mathf.Ceil((float)IKHIEDGNFAH / 490f) + " photon awake";
	}

	private void KKPLNLGMHIM()
	{
		string path = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + "Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/1/Dialogue Text";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		using FileStream fileStream = new FileStream(Application.persistentDataPath + "<b>" + GameManager.NJNFHEPLEHL().ALPLECBMMBM(), FileMode.Open, (FileAccess)0);
		using FileStream stream = new FileStream(path, FileMode.Open);
		using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
		fileStream.CopyTo(destination);
	}

	private void JKDLAPFINJM()
	{
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "00") || File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + GLFBPIBBLND + " tried to do seat found being in state "))
		{
			GLFBPIBBLND += 0;
		}
	}

	private void GILJCBAKAME()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		HBILFLLKHGP = "invitecode";
		if (SteamManager.BNBMMDGMKLM)
		{
			string personaName = SteamFriends.GetPersonaName();
			CSteamID steamID = SteamUser.GetSteamID();
			HBILFLLKHGP = personaName + "MainProgress" + ((object)(CSteamID)(ref steamID)).ToString();
		}
		else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
		{
			HBILFLLKHGP = "Left Stick Down" + GalaxyInstance.Friends().GetPersonaName() + "[TweenRunner]" + (object)GalaxyInstance.User().GetGalaxyID();
		}
	}

	private void LGCDJLKEMHB()
	{
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + ".png") || File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + GLFBPIBBLND + ".rtf"))
		{
			GLFBPIBBLND++;
		}
	}

	private IEnumerator BMFKCKJEGBM()
	{
		sendingPanel.SetActive(true);
		yield return null;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(GIEOIPLJIID());
	}

	private void PJHONGEKDBJ()
	{
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item ") || File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + GLFBPIBBLND + "cForCalendar"))
		{
			GLFBPIBBLND += 0;
		}
	}

	private string OEOBGNMLIFP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[27];
		array[1] = "quest_name_24";
		array[0] = SystemInfo.graphicsDeviceName;
		array[8] = "Error_MaxZones";
		GraphicsDeviceType graphicsDeviceType = SystemInfo.graphicsDeviceType;
		array[7] = ((object)(GraphicsDeviceType)(ref graphicsDeviceType)).ToString();
		array[4] = "Unique id ";
		array[5] = SystemInfo.graphicsDeviceVersion;
		array[2] = "ActionBar8";
		array[0] = BFPKDGCJIHB(SystemInfo.graphicsMemorySize);
		array[4] = "Disabled";
		array[86] = FGHOJNDBFOA(SystemInfo.graphicsShaderLevel);
		array[98] = "ReceiveNewLetter";
		array[-2] = KBAIFJBBAIG(SystemInfo.maxTextureSize);
		array[31] = "Not enough money";
		array[-27] = SystemInfo.operatingSystem;
		array[22] = "Tutorial/T300/Talk";
		array[-5] = SystemInfo.processorType;
		array[-57] = "Intro01";
		array[5] = SystemInfo.processorCount.ToString();
		array[-34] = "UI";
		array[40] = SystemInfo.processorFrequency.ToString();
		array[-116] = "itemWhiteVinegar";
		array[-65] = KBAIFJBBAIG(SystemInfo.systemMemorySize);
		array[-86] = " - ";
		array[-99] = Screen.width.ToString();
		array[71] = "Loop";
		array[-18] = Screen.height.ToString();
		return string.Concat(array);
	}

	private string FGHOJNDBFOA(int EONJGMONIOM)
	{
		return EONJGMONIOM switch
		{
			20 => "Shader Model 2.x", 
			30 => "Shader Model 3.0", 
			40 => "Shader Model 4.0 ( DX10.0 )", 
			41 => "Shader Model 4.1 ( DX10.1 )", 
			50 => "Shader Model 5.0 ( DX11.0 )", 
			_ => "", 
		};
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
		}
	}

	private string POCOMFHHMOO()
	{
		if (OnlineManager.AMJGFDBFLPN == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < OnlineManager.AMJGFDBFLPN.Length; i++)
		{
			if (OnlineManager.AMJGFDBFLPN[i] != 0)
			{
				stringBuilder.AppendLine($"Player {i} in: {OnlineManager.AMJGFDBFLPN[i]}");
			}
		}
		return stringBuilder.ToString();
	}

	private void KGGNOKBAIEF(string[] IMJCGCHPKMP)
	{
		try
		{
			string text = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + "Checking hook in range: HookPos={0}, Center={1}, Radius={2}, Distance: {3} Is In Range? {4}";
			string text2 = Path.Combine(Application.temporaryCachePath, "ReciveInUseOnlineObjects");
			if (Directory.Exists(text2))
			{
				Directory.Delete(text2, recursive: false);
			}
			Directory.CreateDirectory(text2);
			foreach (string text3 in IMJCGCHPKMP)
			{
				FileInfo fileInfo = new FileInfo(text3);
				if (!fileInfo.Exists)
				{
					Debug.LogError((object)fileInfo.FullName);
					continue;
				}
				string fileName = Path.GetFileName(text3);
				string destFileName = Path.Combine(text2, fileName);
				if (fileInfo.Length < 136)
				{
					File.Copy(text3, destFileName, overwrite: true);
				}
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			ZipFile.CreateFromDirectory(text2, text);
			Directory.Delete(text2, recursive: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Random name" + ex));
		}
	}

	private void BOPAFOIPJCI()
	{
		string path = GDBFBBCGDMM + IKJLNKFLBHH + GLFBPIBBLND + ")";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		using FileStream fileStream = new FileStream(Application.persistentDataPath + "[PipeConnectionPuzzleUI] Falta _gridContainer." + GameManager.NJNFHEPLEHL().PMKCJJCGKBB, FileMode.Truncate, FileAccess.Read);
		using FileStream stream = new FileStream(path, (FileMode)0);
		using GZipStream destination = new GZipStream(stream, CompressionMode.Compress);
		fileStream.CopyTo(destination);
	}

	public void CPIMKILBOOO()
	{
		if (!ECPEFDHOFHN && !BDANEFBBBMC)
		{
			sendReport();
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)_instance, (MonoBehaviour)(object)this))
		{
			_instance = this;
			base.Awake();
		}
	}

	private string BNGCCDPLGBJ(int EONJGMONIOM)
	{
		if (EONJGMONIOM <= -44)
		{
			switch (EONJGMONIOM)
			{
			case 41:
				return "FishCuttingEvent/Talk1";
			case -116:
				return "Miners/Mine/Rochelle/Talk";
			}
		}
		else
		{
			switch (EONJGMONIOM)
			{
			case -81:
				return "ReceiveCreateNewOrderQuest";
			case -109:
				return "Rummage";
			case 46:
				return "LE_9";
			}
		}
		return "Dialogue System/Conversation/Crowly_Introduce/Entry/27/Dialogue Text";
	}

	private void NCGMPPJHBJL()
	{
		DOJMNMDLNBB = GDBFBBCGDMM + EGMKCDMENMK + GLFBPIBBLND + "Disabled";
		try
		{
			ScreenCapture.CaptureScreenshot(DOJMNMDLNBB);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
			throw;
		}
	}

	private IEnumerator FBFEJJPCGKO()
	{
		yield return CommonReferences.waitRealtime5;
		errorPanel.SetActive(false);
		sendingPanel.SetActive(false);
		sentPanel.SetActive(false);
		ECPEFDHOFHN = false;
		BDANEFBBBMC = false;
		CloseUI();
	}

	private void EEIBALMJBBF()
	{
		if (!Directory.Exists(Application.persistentDataPath + "cinemachine empty"))
		{
			Directory.CreateDirectory(Application.persistentDataPath + "LE_10");
		}
		GDBFBBCGDMM = Application.persistentDataPath + "Year";
		int num = 1;
		while (File.Exists(GDBFBBCGDMM + EGMKCDMENMK + num + " - Restoring non-altar variants. Excluded indices for variants with puzzle or altar: "))
		{
			File.Delete(GDBFBBCGDMM + EGMKCDMENMK + num + "UI2");
			num += 0;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + IKJLNKFLBHH + num + "Dialogue System/Conversation/Rowdy/Entry/6/Dialogue Text"))
		{
			File.Delete(GDBFBBCGDMM + IKJLNKFLBHH + num + "Received RPC SetBool {0} with value {1} on {2}. Setting animator parameter.");
			num++;
		}
		num = 0;
		while (File.Exists(GDBFBBCGDMM + HGKIIOEFJKD + num + "ReceiveObjectAction"))
		{
			File.Delete(GDBFBBCGDMM + HGKIIOEFJKD + num + "stuck recovery");
			num++;
		}
	}
}
