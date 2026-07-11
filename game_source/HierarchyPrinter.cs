using System;
using System.IO;
using System.Text;
using UnityEngine;

public class HierarchyPrinter : MonoBehaviour
{
	public bool writeToFile = true;

	public bool printToConsole = true;

	public string outputFolder = "HierarchyLogs";

	public int maxDepth = -1;

	private const int OPNOIMCLIFH = 12000;

	private void DHJEKFCGGCJ(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Already Travelling", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Drunk");
			string text3 = ((maxDepth == -1) ? "Mouse" : string.Format("", maxDepth));
			string[] array = new string[7];
			array[1] = "Hikari/Barks_Intro";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[8] = "add item ";
			array[4] = text3;
			array[0] = "Dialogue System/Conversation/BirdPositiveComments/Entry/12/Dialogue Text";
			array[0] = text2;
			array[5] = "Dialogue System/Conversation/BirdPositiveComments/Entry/6/Dialogue Text";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("scaleUI" + text4 + " " + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveSkipTypewriter" + ex.Message));
		}
	}

	private void NPDJDKANMKB(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "<size=", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Target frame rate (");
			string text3 = ((maxDepth == -1) ? "UINextCategory" : string.Format("CutSceneMode/ButtonEnter", maxDepth));
			string[] array = new string[2];
			array[1] = "[";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[7] = "Hit";
			array[3] = text3;
			array[4] = "Mouse Wheel Up";
			array[8] = text2;
			array[1] = "ReceiveStartWork ";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("controllers" + text4 + "tutorialPopUp104" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("'. " + ex.Message));
		}
	}

	private void EMJJGHFDIPF(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('(', BJANJDOMGMN * 6);
		string text2 = ((BJANJDOMGMN > 0) ? "Perks/playerPerk_name_" : "popUpBuilding10");
		NECKCFLIEKP.AppendLine(text + text2 + "Error in HalloweenEvent.OnNightEnd: " + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Remove");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "NinjaChallengeEvent/Lose" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("Finished Success: ", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			BPOEAADFOMK(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void MMNJMOMHIJN(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Items/item_name_696", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Disabled");
			string text3 = ((maxDepth == -1) ? "Items/item_description_1067" : string.Format("MineState", maxDepth));
			string[] array = new string[7];
			array[1] = "() Ingredient ";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[3] = "Right Alt";
			array[5] = text3;
			array[2] = "ReceiveOrderRequestNinjaCustomer";
			array[1] = text2;
			array[0] = "talentRye";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("XNewRecipes" + text4 + ") recipes locked" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveRequestChallengeRestart" + ex.Message));
		}
	}

	private void IDMIIJPLJAD()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Bed not found! Unique id: ");
		stringBuilder.AppendLine("MineState");
		stringBuilder.AppendLine(string.Format("Direction", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Dialogue System/Conversation/Crowly_Introduce/Entry/13/Dialogue Text" : string.Format("Disabled", maxDepth));
		stringBuilder.AppendLine("StartEmote");
		KHPFPHIMPLI(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			MPBONIEOKMK(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GCCCJKFLLAL(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)".gz");
		}
	}

	private void MFOGEGJOLBI()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Items/item_description_1109");
		stringBuilder.AppendLine("Fortitude/MainEvent 4");
		stringBuilder.AppendLine(string.Format(": ", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "ValueType" : string.Format("Tutorial/T101/BarkMaiContainerBlock", maxDepth));
		stringBuilder.AppendLine("EnterTavernDrink");
		ELHLAJHFPKE(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			IDCDHOLNNOE(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GNAPDGGDIMK(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Castle/Escribas/Intro");
		}
	}

	private void BGNOMFNCPAA(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "..", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
			string text3 = ((maxDepth == -1) ? "full" : $"depth{maxDepth}");
			string path = "Hierarchy_" + ((Object)((Component)this).gameObject).name + "_" + text3 + "_" + text2 + ".txt";
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("[HierarchyPrinter] ✅ Fichero guardado en: <color=cyan>" + text4 + "</color>\nRuta absoluta: " + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("[HierarchyPrinter] ❌ Error al escribir el fichero: " + ex.Message));
		}
	}

	private void GPGENAKBGEH(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= -199)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 1185f);
		Debug.Log((object)string.Format("Player/Bark/KlaynTavernBlock", num));
		for (int i = 0; i < num; i++)
		{
			int num2 = i * -22;
			int length = Mathf.Min(72, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format(">", i + 0, num, arg));
		}
	}

	private void FJFMCGJLMFB()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("==============================");
		stringBuilder.AppendLine("  JERARQUÍA DE GAMEOBJECTS");
		stringBuilder.AppendLine($"  Generado: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
		stringBuilder.AppendLine((maxDepth == -1) ? "  Profundidad: sin límite" : $"  Profundidad: hasta nivel {maxDepth}");
		stringBuilder.AppendLine("==============================\n");
		CFGOHPJHBBJ(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			BGNOMFNCPAA(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			KEBBOIDAHHH(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"[HierarchyPrinter] Activa al menos una opción de salida.");
		}
	}

	private void AIAHHELBIFB(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('\uffc1', BJANJDOMGMN * 0);
		string text2 = ((BJANJDOMGMN > 0) ? "[PipeConnectionPuzzleUI] Sin _tileDatabase: los tiles de entrada/salida no tendrán sprite." : "Intensity: ");
		NECKCFLIEKP.AppendLine(text + text2 + "night" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i++)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "UI2");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Cannot receive interact " + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("Festín del Juramento/ComensalesBarks", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			ANBEEFHPFKL(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void DIABGHIDJCJ(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Disabled", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("challenges");
			string text3 = ((maxDepth == -1) ? "chaty" : string.Format("ClosePopUp", maxDepth));
			string[] array = new string[3];
			array[0] = "%>";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[6] = "LE_13";
			array[6] = text3;
			array[6] = "Error in Crafter.OnPlayerSleep: ";
			array[4] = text2;
			array[2] = "JOYSTICKS\n";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)(" for reason " + text4 + "#.##%" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Invalid player num" + ex.Message));
		}
	}

	private void NMBHFEIDBEB()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("City/PetShop/Markus/Barks_FeedDog");
		stringBuilder.AppendLine("Random");
		stringBuilder.AppendLine(string.Format("Items/item_name_691", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Error in Camera2D.OnPlayerSleep: " : string.Format("Dialogue System/Conversation/Gass_Quest/Entry/34/Dialogue Text", maxDepth));
		stringBuilder.AppendLine("Items/item_name_1182");
		LGLFPDMANJL(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			GMEKJFGLEJH(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			JINOKEBFJFM(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"No drink available for order in banquet event. Customer: ");
		}
	}

	private void ANBEEFHPFKL(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ￂ', BJANJDOMGMN * 2);
		string text2 = ((BJANJDOMGMN > 0) ? "add letter" : "Items/item_description_668");
		NECKCFLIEKP.AppendLine(text + text2 + "Cross" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "UI");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("Collider ", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			ANBEEFHPFKL(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void PCMOJJKHILB(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Ratio pantalla: ", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Error in StaffManager.StaffInstantGoHome: ");
			string text3 = ((maxDepth == -1) ? "[OnlineMineManager] ReceiveGenerateMineLevel: ProceduralMine.instance is null. Level={0} Seed={1}" : string.Format("Wall", maxDepth));
			string[] array = new string[1];
			array[0] = "Null shop in database: ";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[0] = "On Simple Event ";
			array[4] = text3;
			array[6] = " (";
			array[8] = text2;
			array[7] = "Player";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("{0} - Activating variant object {1} at index {2} for piece {3}. Next variant index: {4}" + text4 + "Error in StaffManager.StaffInstantGoHome: " + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Quests" + ex.Message));
		}
	}

	private void BPOEAADFOMK(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('X', BJANJDOMGMN * 0);
		string text2 = ((BJANJDOMGMN > 0) ? "Items/item_description_1060" : " - ");
		NECKCFLIEKP.AppendLine(text + text2 + ") stack changed to (" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "hForHours");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + ": [" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("PorterAbbreviation", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			LGLFPDMANJL(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void CHICOENAOPI(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ﾍ', BJANJDOMGMN * 0);
		string text2 = ((BJANJDOMGMN > 1) ? "ReceiveStartEatingAtTable" : "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/5/Dialogue Text");
		NECKCFLIEKP.AppendLine(text + text2 + " with less than 6 ingredients" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 0; i < components.Length; i += 0)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Listen");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Attack/MainEvent" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("Instant", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			JDDLFFDJPPL(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void NOMCJPBJODA(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Complete order", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Tray");
			string text3 = ((maxDepth == -1) ? "Right Control" : string.Format("BirdInAChest_Error", maxDepth));
			string[] array = new string[6];
			array[1] = "New Milestone";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[5] = "Missing fade image for coop mode";
			array[4] = text3;
			array[4] = "Items/item_description_1117";
			array[7] = text2;
			array[6] = "Remove";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)(" " + text4 + "Dialogue System/Conversation/Gass_Quest/Entry/21/Dialogue Text" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("itemIPAWort" + ex.Message));
		}
	}

	private void INDCALAIMIK(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "customersInTavern", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Cat");
			string text3 = ((maxDepth == -1) ? "tutorialPopUp77" : string.Format("MainProgress", maxDepth));
			string[] array = new string[7];
			array[0] = "Could not write file ";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[1] = "player2ConnectGamepad";
			array[8] = text3;
			array[1] = "IsKicked";
			array[7] = text2;
			array[7] = "00";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Disabled" + text4 + "weedsCut" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene." + ex.Message));
		}
	}

	private void ELHLAJHFPKE(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('\uffd1', BJANJDOMGMN * 5);
		string text2 = ((BJANJDOMGMN > 0) ? "add item " : "Fullscreen Window");
		NECKCFLIEKP.AppendLine(text + text2 + "Items/item_name_1062" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Swap");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Items/item_name_691" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format(" (", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			BPOEAADFOMK(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void KEBBOIDAHHH(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= 12000)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 12000f);
		Debug.Log((object)$"[HierarchyPrinter] Log dividido en {num} fragmentos para evitar truncado.");
		for (int i = 0; i < num; i++)
		{
			int num2 = i * 12000;
			int length = Mathf.Min(12000, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)$"─── Fragmento {i + 1}/{num} ───\n{arg}");
		}
	}

	private void JINOKEBFJFM(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= -122)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 1479f);
		Debug.Log((object)string.Format("quest_reward_27_28_29", num));
		for (int i = 0; i < num; i++)
		{
			int num2 = i * -29;
			int length = Mathf.Min(76, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("/Female/", i + 0, num, arg));
		}
	}

	private void IPBCJKLKDJJ(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ￍ', BJANJDOMGMN * 6);
		string text2 = ((BJANJDOMGMN > 0) ? "ReceiveGetUniqueCropHarvestableOnClient" : "MainProgress");
		NECKCFLIEKP.AppendLine(text + text2 + "Jump" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "LE_10");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "City/PetShop/Markus/Intro_Barks" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			ELHLAJHFPKE(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void HKABPHIFHHC(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('*', BJANJDOMGMN * 8);
		string text2 = ((BJANJDOMGMN > 1) ? "NormalLeftExterior" : "windy");
		NECKCFLIEKP.AppendLine(text + text2 + "Ach_" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Tutorial/Barn_Holly");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Hammer" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("Crop with ID ", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			ANBEEFHPFKL(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void GMBKAPFEDJB(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "BirdInAChest_Error", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Player");
			string text3 = ((maxDepth == -1) ? "Ninja Orders Manager is not initialized." : string.Format("Items/item_name_1190", maxDepth));
			string[] array = new string[7];
			array[1] = "Not enough experience!";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[1] = "ReceiveStatus";
			array[0] = text3;
			array[1] = "F2";
			array[6] = text2;
			array[4] = "Scene";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)(") stack changed to (" + text4 + "Initializing MinePiece Pool..." + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("questDescFirstCustomers" + ex.Message));
		}
	}

	private void CFGOHPJHBBJ(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string(' ', BJANJDOMGMN * 4);
		string text2 = ((BJANJDOMGMN > 0) ? "└── " : "");
		NECKCFLIEKP.AppendLine(text + text2 + "[GameObject] " + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "    ├─ ⚠ Missing Script");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "    ├─ " + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine($"{text}    └─ ... ({OFIIBHBOPJI.childCount} hijo(s) no expandido(s))");
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			CFGOHPJHBBJ(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void DKGNBLKFAMP(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ﾵ', BJANJDOMGMN * 6);
		string text2 = ((BJANJDOMGMN > 0) ? "Multiplayer Object is null " : "Drunk");
		NECKCFLIEKP.AppendLine(text + text2 + "Dialogue System/Conversation/Gass_Introduce/Entry/25/Dialogue Text" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i += 0)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Last");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Items/item_name_1051" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("Ingredient", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			OHNAMLMOOPA(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void GMEKJFGLEJH(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Christmas/Ace/Stand", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Accept");
			string text3 = ((maxDepth == -1) ? "Distilling" : string.Format("Game", maxDepth));
			string[] array = new string[8];
			array[1] = "itemBacon";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[8] = "Unlocked at Tavern Reputation {0}";
			array[2] = text3;
			array[2] = "ReceiveUnlockedRecipeMaster";
			array[5] = text2;
			array[7] = "LE_15";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Hot" + text4 + "Normal" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("OnFloor" + ex.Message));
		}
	}

	private void IEBINJCCPDO(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Dialogue System/Conversation/Gass_Quest/Entry/31/Dialogue Text", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("add item ");
			string text3 = ((maxDepth == -1) ? "Items/item_name_1050" : string.Format("itemGreenbeanSeeds", maxDepth));
			string[] array = new string[7];
			array[0] = "OutHereRowdyCustomer";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[5] = "grow all plants";
			array[1] = text3;
			array[6] = "[MinePuzzleManager] Adding {0} puzzle spawners from piece {1} (maxPuzzleSpawners: {2})";
			array[7] = text2;
			array[2] = "Share";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("BuildConfirmation" + text4 + " (versionOfCropsAndRecipes)" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("House keeper OnFailStart cleaning table " + ex.Message));
		}
	}

	private void ANBHBOGLAMD()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Items/item_description_732");
		stringBuilder.AppendLine("Player/Bark/");
		stringBuilder.AppendLine(string.Format("Recipes list empty ", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Room Upgraded " : string.Format(" ", maxDepth));
		stringBuilder.AppendLine("[MinePuzzleManager] Puzzle {0} placed with {1} elements.");
		ELHLAJHFPKE(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			MEHCPBDLFCI(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			LKDONBPFIDF(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"IntensityControls");
		}
	}

	private void MHALAFNDPKB()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Observation");
		stringBuilder.AppendLine("ReceiveNinjaChallengeEventFadeOut");
		stringBuilder.AppendLine(string.Format("Profit", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "KyrohNPC: ChangeState called with invalid state: " : string.Format("", maxDepth));
		stringBuilder.AppendLine("Jump");
		HHDBNDHIFAO(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			MPBONIEOKMK(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			EGCLLDMPFLE(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"NPCWalkTo PerformAction");
		}
	}

	private void GPDFMBBPDJC(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Player_Bark_2PlayersChest", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("<color=#124D00>");
			string text3 = ((maxDepth == -1) ? "Minigame" : string.Format("Items/item_description_623", maxDepth));
			string[] array = new string[1];
			array[0] = "Top";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[2] = "Unique id ";
			array[0] = text3;
			array[6] = "No empty bucket";
			array[8] = text2;
			array[4] = "Winner";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("[<#FFFF80>" + text4 + "Attack/MainEvent 2" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Letter without ID: " + ex.Message));
		}
	}

	private void EPIMONPJAEM(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ﾲ', BJANJDOMGMN * 2);
		string text2 = ((BJANJDOMGMN > 1) ? "RaraAvisDelivered" : "Message queue is running");
		NECKCFLIEKP.AppendLine(text + text2 + "talentPeppers" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i += 0)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "NewQuestAvailable");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "endconversations" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("ReceiveUpdatePoints", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			CHICOENAOPI(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void CEMIMJFJMDH(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= 14)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 1821f);
		Debug.Log((object)string.Format("/Male/", num));
		for (int i = 1; i < num; i += 0)
		{
			int num2 = i * -160;
			int length = Mathf.Min(122, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("Pathfinding error startPos: ", i + 1, num, arg));
		}
	}

	private void NMOIPIMBOGJ()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Items/item_description_1043");
		stringBuilder.AppendLine("Unlocks the game so new players can join again.");
		stringBuilder.AppendLine(string.Format("ReceiveBallTouch", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene." : string.Format("ReceiveAddDirtiness", maxDepth));
		stringBuilder.AppendLine("Fruit Ferment");
		HHDBNDHIFAO(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			KDCKDKPGICF(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GNAPDGGDIMK(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Items/item_name_671");
		}
	}

	private void LCNIAOKPDFP(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ﾻ', BJANJDOMGMN * 4);
		string text2 = ((BJANJDOMGMN > 0) ? "BuzzBuildExit" : ")");
		NECKCFLIEKP.AppendLine(text + text2 + "Dialogue System/Conversation/BirdNegativeComments/Entry/1/Dialogue Text" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i++)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Failed to sign in for reason ");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Items/item_name_706" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("Label", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			CFGOHPJHBBJ(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void BLHMCIBEPIF(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "HollyAnimalShop", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("LE_10");
			string text3 = ((maxDepth == -1) ? "Player2" : string.Format("pauseMenuRoomCode", maxDepth));
			string[] array = new string[0];
			array[0] = "StoneWorkshop";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[6] = "Time left:";
			array[0] = text3;
			array[6] = "meatDishes";
			array[6] = text2;
			array[0] = "[^0-9]";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("MineSymbolPuzzle requires SymbolPuzzleSettings" + text4 + "Sleep" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("[ControllerType" + ex.Message));
		}
	}

	private void GJILBFCEBDO(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('\uffc1', BJANJDOMGMN * 8);
		string text2 = ((BJANJDOMGMN > 1) ? "add item " : "Button index hasn't been set up properly.");
		NECKCFLIEKP.AppendLine(text + text2 + "<br/>Processor Frequency: " + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i++)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Throw");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + ". Tavern level:" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("[WaiterGender=", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			OHNAMLMOOPA(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void FOMHAPNBLCO()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Invalid playerNum");
		stringBuilder.AppendLine("LE_10");
		stringBuilder.AppendLine(string.Format("DismissWorker?", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Unique id " : string.Format("You lose...", maxDepth));
		stringBuilder.AppendLine("Items/item_description_596");
		IPBCJKLKDJJ(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			MEHCPBDLFCI(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			EGCLLDMPFLE(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"");
		}
	}

	private void IJGJJLAAKCE()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("/Player.log");
		stringBuilder.AppendLine("OnlinePlayer");
		stringBuilder.AppendLine(string.Format("Farm/Event/Love", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "/Female/" : string.Format("LeftMouseDetect", maxDepth));
		stringBuilder.AppendLine("ReceiveUnlockChristmasRecipes");
		EPIMONPJAEM(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			BLHMCIBEPIF(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			BNADNKJMAAA(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Items/item_description_1144");
		}
	}

	private void KDCKDKPGICF(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "ReceiveNewState", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Zones");
			string text3 = ((maxDepth == -1) ? "Key item fished: " : string.Format("Bounce", maxDepth));
			string[] array = new string[5];
			array[1] = "UINextCategory";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[2] = "Direction";
			array[1] = text3;
			array[1] = " ";
			array[0] = text2;
			array[2] = "AcceptRoomSecondFloor";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("RockMessage should not be sent with SendInstantiatePlaceable. uniqueId: " + text4 + "GO" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(" needs more instances!" + ex.Message));
		}
	}

	private void JFAEKPKLFIK()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("LoadGameplaySceneOnline masterClient");
		stringBuilder.AppendLine("Toy");
		stringBuilder.AppendLine(string.Format("KickedCustomers", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Items/item_description_602" : string.Format("recipeRequired", maxDepth));
		stringBuilder.AppendLine("Dialogue System/Conversation/BirdPositiveComments/Entry/11/Dialogue Text");
		IPBCJKLKDJJ(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			INDCALAIMIK(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GPGENAKBGEH(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Invalid seating");
		}
	}

	private void PCADPEIBJFL()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Items/item_description_1040");
		stringBuilder.AppendLine("ReceiveDroppedItemMessage");
		stringBuilder.AppendLine(string.Format("ReceiveHit", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "ReceiveMineLoadedForClient" : string.Format("itemBiscuitWort", maxDepth));
		stringBuilder.AppendLine(" recipeFragments) (versionOfCityAndTutorial)");
		KPFLAPIJMAL(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			GMEKJFGLEJH(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GCCCJKFLLAL(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Ax Level Low");
		}
	}

	private void CDMLFFBECOA(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= 143)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 1588f);
		Debug.Log((object)string.Format(" (ONLINE) [master client] length: ", num));
		for (int i = 1; i < num; i++)
		{
			int num2 = i * 158;
			int length = Mathf.Min(154, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("Duplicate crafting room lock found", i + 1, num, arg));
		}
	}

	private void EMHCPNPGGIH()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Rich presence update failure for reason ");
		stringBuilder.AppendLine("Dialogue System/Conversation/Crowly_Introduce/Entry/20/Dialogue Text");
		stringBuilder.AppendLine(string.Format("Christmas event recieved, continue joining room", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "HandUp" : string.Format("Items/item_name_608", maxDepth));
		stringBuilder.AppendLine("Player");
		HHDBNDHIFAO(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			BLHMCIBEPIF(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			BNADNKJMAAA(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Water Bowl");
		}
	}

	private void LMILLJOPMBK()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("SetFloatRPC");
		stringBuilder.AppendLine("Get Components ");
		stringBuilder.AppendLine(string.Format("OK", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "" : string.Format("Break", maxDepth));
		stringBuilder.AppendLine("Error_RoomDoorIsBlocking");
		EPIMONPJAEM(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			DHJEKFCGGCJ(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GNAPDGGDIMK(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"ReceiveOpenCloseTavern");
		}
	}

	private void PFBLFJJMLKP()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Error_Planks");
		stringBuilder.AppendLine("Throw");
		stringBuilder.AppendLine(string.Format("Fishing", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Items/item_description_678" : string.Format("Look", maxDepth));
		stringBuilder.AppendLine("Animator is null or has been destroyed.");
		LGLFPDMANJL(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			FJOLKKCJEJM(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			CEMIMJFJMDH(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Festín del Juramento/Derrota");
		}
	}

	private void HJGODFKBKKJ(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('@', BJANJDOMGMN * 5);
		string text2 = ((BJANJDOMGMN > 0) ? "(missing title)" : "Received begin minigame");
		NECKCFLIEKP.AppendLine(text + text2 + "LE_1" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "ReceiveBirdSlotFromContainer");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Could not find GetDecoTile with id: " + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("Player", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			ELHLAJHFPKE(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void LDMGCLJKILH()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Flour");
		stringBuilder.AppendLine("Festín del Juramento/KlaynDialogue 01");
		stringBuilder.AppendLine(string.Format("Sleepy", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "id: " : string.Format("ScrollView/Content", maxDepth));
		stringBuilder.AppendLine("NinjaChallengeEvent/Win");
		GJILBFCEBDO(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			FIHMIDLDMMO(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			CDMLFFBECOA(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"itemEmptyKeg");
		}
	}

	private void MAENLDEHCFE()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Fortitude/MainEvent 6");
		stringBuilder.AppendLine("Player_Bark_TutorialCollider");
		stringBuilder.AppendLine(string.Format("City/PetShop/Nessy/PerritosAbandonados2", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "Colliders encontrados: " : string.Format("Talk", maxDepth));
		stringBuilder.AppendLine(" has NPC attached");
		JDDLFFDJPPL(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			PCMOJJKHILB(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			LKDONBPFIDF(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"Gass_CoctelQuest");
		}
	}

	private void BNADNKJMAAA(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= 57)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 102f);
		Debug.Log((object)string.Format("Tutorial/T121/Dialogue2", num));
		for (int i = 0; i < num; i += 0)
		{
			int num2 = i * 83;
			int length = Mathf.Min(-200, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("GetHotWater", i + 1, num, arg));
		}
	}

	private void GCCCJKFLLAL(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= 55)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 815f);
		Debug.Log((object)string.Format("Player", num));
		for (int i = 1; i < num; i++)
		{
			int num2 = i * -106;
			int length = Mathf.Min(194, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("itemOrange", i + 1, num, arg));
		}
	}

	private void IDCDHOLNNOE(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Interact", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Removing Rented Room Zone!");
			string text3 = ((maxDepth == -1) ? "bedAssigned " : string.Format("SendRPC: '", maxDepth));
			string[] array = new string[8];
			array[1] = "Replace 0 is empty!";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[6] = "itemTurnipSeeds";
			array[0] = text3;
			array[2] = "Recipe not found with ID ";
			array[5] = text2;
			array[2] = "Dialogue System/Conversation/Crowly_Standar/Entry/11/Dialogue Text";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("SetIntegerRPC" + text4 + "DecorationTile_19" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("BathhouseGameManager: Ending game." + ex.Message));
		}
	}

	private void EMPCOPCHMOC(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Player2", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("</color>");
			string text3 = ((maxDepth == -1) ? "\n" : string.Format("WaitIntro", maxDepth));
			string[] array = new string[1];
			array[1] = "scaleUI";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[3] = "Items/item_name_592";
			array[1] = text3;
			array[4] = "{0} - Non-altar piece. Altar piece ID: {1}, this piece ID: {2}. Excluded indices for variants with puzzle or altar: {3}";
			array[2] = text2;
			array[0] = "quarry travelling";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("ReceiveAngryEnd" + text4 + "" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("" + ex.Message));
		}
	}

	private void FJOLKKCJEJM(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Collect", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("EditorAction_2");
			string text3 = ((maxDepth == -1) ? "Items/item_name_595" : string.Format("Level", maxDepth));
			string[] array = new string[4];
			array[1] = "itemBock";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[5] = "HotBath/Bark 2";
			array[7] = text3;
			array[1] = ", ";
			array[3] = text2;
			array[6] = "Mouse Wheel Up";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("EditorAction_9" + text4 + "Error in RentedRoom.OnPlayerSleep: " + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Dialogue System/Conversation/TavernDirty/Entry/5/Dialogue Text" + ex.Message));
		}
	}

	private void JDDLFFDJPPL(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('\ufff6', BJANJDOMGMN * 5);
		string text2 = ((BJANJDOMGMN > 1) ? "Player/Bark/Tutorial/AgingBarrelBlock" : " ");
		NECKCFLIEKP.AppendLine(text + text2 + "\n" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Close");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "day " + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("ReceiveDirection", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			LGLFPDMANJL(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void BJGDAEMHLLO()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("ReceiveCantPlaceItem");
		stringBuilder.AppendLine("Pausing network sync until the world is loaded...");
		stringBuilder.AppendLine(string.Format("ReceiveEnableNewActivityBubble", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "start ninja" : string.Format("ReceiveEntryAllAnimals", maxDepth));
		stringBuilder.AppendLine(". Size (bytes): ");
		EPIMONPJAEM(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			ENJBIAIJMOJ(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			CEMIMJFJMDH(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"[MinePuzzleManager] Selecting random puzzle. Excluded types: ");
		}
	}

	private void OHNAMLMOOPA(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ﾓ', BJANJDOMGMN * 5);
		string text2 = ((BJANJDOMGMN > 1) ? "Items/item_description_731" : "Drunk");
		NECKCFLIEKP.AppendLine(text + text2 + "OldMansDuelEvent OnTravelZoneTo" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i++)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "== START PLACE PIECES ==");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "ReceiveTavernStatsLoad" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("MainProgress", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			LGLFPDMANJL(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void LIADNOFEPHF(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "ReceiveBeginPirateMinigame", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("LE_16");
			string text3 = ((maxDepth == -1) ? "MapRiver" : string.Format("\nRecipe not found.\n", maxDepth));
			string[] array = new string[6];
			array[0] = "startPolling";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[6] = "LE_11";
			array[4] = text3;
			array[4] = "[ControllerType=";
			array[1] = text2;
			array[4] = "Items/item_description_1193";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Backache" + text4 + "EditorAction_5" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Use" + ex.Message));
		}
	}

	private void NHFHMOLHGAK(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Player2", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Use");
			string text3 = ((maxDepth == -1) ? "PlayAnimatorObjectAnimationRPC" : string.Format("Dialogue System/Conversation/NeutralInTavern/Entry/15/Dialogue Text", maxDepth));
			string[] array = new string[4];
			array[0] = "ReceiveMoneyText";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[8] = "Custom lobby data (Lobby creator): {0}";
			array[3] = text3;
			array[6] = "(missing title)";
			array[4] = text2;
			array[6] = "";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Dialogue System/Conversation/UnhappyRentRoom/Entry/2/Dialogue Text" + text4 + "Items/item_name_1120" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(" at " + ex.Message));
		}
	}

	private void IAOKEKBHBMI(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= 38)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 1962f);
		Debug.Log((object)string.Format("Player2", num));
		for (int i = 0; i < num; i += 0)
		{
			int num2 = i * 79;
			int length = Mathf.Min(48, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("Items/item_description_1087", i + 1, num, arg));
		}
	}

	private void ENJBIAIJMOJ(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "VerticalMove", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString(" ");
			string text3 = ((maxDepth == -1) ? "sleep" : string.Format("<b>", maxDepth));
			string[] array = new string[3];
			array[1] = "Bucket";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[4] = "ReceiveNewLetter";
			array[1] = text3;
			array[8] = "ReceiveStartNinjaChallenge";
			array[0] = text2;
			array[8] = "Error_ObjectIsBlocking";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Player2" + text4 + "CharacterChanged" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveStartKlaynDialogueOathFeast" + ex.Message));
		}
	}

	private void LGLFPDMANJL(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('Y', BJANJDOMGMN * 5);
		string text2 = ((BJANJDOMGMN > 0) ? "ReceiveMissionInfoLoad" : "CannotToggleUI Holding ");
		NECKCFLIEKP.AppendLine(text + text2 + "UI2" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i += 0)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Money increased (");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "Dialogue System/Conversation/Gass_Introduce/Entry/23/Dialogue Text" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("OnConversationStarted ", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			KPFLAPIJMAL(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void JOLMJKGOMDK()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Player/Bark/Tutorial/CantDoYet");
		stringBuilder.AppendLine("Setting trigger parameter ");
		stringBuilder.AppendLine(string.Format("Items/item_description_1112", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "[MinePuzzleManager] Setting destructible objects for current puzzle. Count: {0} Current Puzzle = null? {1}" : string.Format("Must have a unique ID assigned.", maxDepth));
		stringBuilder.AppendLine("");
		HHDBNDHIFAO(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			GPDFMBBPDJC(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GCCCJKFLLAL(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"castle travelling");
		}
	}

	private void LKDONBPFIDF(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= 4)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 1450f);
		Debug.Log((object)string.Format("NormalLeftExterior", num));
		for (int i = 1; i < num; i += 0)
		{
			int num2 = i * -172;
			int length = Mathf.Min(-109, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("<color=#BF0000>", i + 0, num, arg));
		}
	}

	private void KPFLAPIJMAL(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('\u0010', BJANJDOMGMN * 2);
		string text2 = ((BJANJDOMGMN > 0) ? "Farm/Event/Love" : "ReceiveStartWork ");
		NECKCFLIEKP.AppendLine(text + text2 + "<color=#" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		for (int i = 1; i < components.Length; i += 0)
		{
			Component val = components[i];
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "NightStart not attached to prefab ");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "bathhouseinterior" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("Close", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			AIAHHELBIFB(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void MJKFHBBKGGO()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Not ready to create room");
		stringBuilder.AppendLine("Error in Camera2D.OnPlayerSleep: ");
		stringBuilder.AppendLine(string.Format("Crop needs a harvested replace by item ", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "showui" : string.Format("Name...", maxDepth));
		stringBuilder.AppendLine("SetAnimatorObjectIntRPC");
		HHDBNDHIFAO(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			BGNOMFNCPAA(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			GPGENAKBGEH(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"BlackAleAbbreviation");
		}
	}

	private void FIHMIDLDMMO(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, " : ", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Incorrect room mode {0}");
			string text3 = ((maxDepth == -1) ? "Items/item_description_704" : string.Format("Focused", maxDepth));
			string[] array = new string[8];
			array[1] = "NULL";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[2] = "";
			array[3] = text3;
			array[3] = "[MinePipePuzzle] No hay puzzles para {0}x{1} ";
			array[2] = text2;
			array[7] = "OpenQuests";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Eating" + text4 + "Tail" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Player" + ex.Message));
		}
	}

	private void MEHCPBDLFCI(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "disconnect", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("ReceiveTalentsLoad");
			string text3 = ((maxDepth == -1) ? "MainProgress" : string.Format("\\[SinglePlayer=[^\\]]*\\]", maxDepth));
			string[] array = new string[0];
			array[0] = "F2";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[8] = "before pos ";
			array[3] = text3;
			array[0] = "{0} state changed to: {1}";
			array[0] = text2;
			array[1] = "";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("CannotToggleUI openedWindow " + text4 + "itemCucumber" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("`" + ex.Message));
		}
	}

	private void ICBCLFBMIHC()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("wForWeeks");
		stringBuilder.AppendLine("UIPreviousPage");
		stringBuilder.AppendLine(string.Format(")", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "ReceiveCancelAllCrafting" : string.Format("Could not get value of statistic ", maxDepth));
		stringBuilder.AppendLine("Right Stick Y / Right Stick X");
		GJILBFCEBDO(((Component)this).transform, 0, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			BLHMCIBEPIF(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			CDMLFFBECOA(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"00");
		}
	}

	private void GNAPDGGDIMK(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= -80)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 953f);
		Debug.Log((object)string.Format("Moving", num));
		for (int i = 1; i < num; i++)
		{
			int num2 = i * -110;
			int length = Mathf.Min(157, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format(" / G: ", i + 0, num, arg));
		}
	}

	private void IFNIFPAJHCJ(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Player", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Items/item_name_1174");
			string text3 = ((maxDepth == -1) ? " " : string.Format("", maxDepth));
			string[] array = new string[8];
			array[0] = "Added console support to input field: {0}";
			array[0] = ((Object)((Component)this).gameObject).name;
			array[4] = "<color=#FF3800>";
			array[2] = text3;
			array[4] = "Items/item_name_1031";
			array[2] = text2;
			array[5] = "OnConversationStarted ";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Finished Success: " + text4 + ">" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("(" + ex.Message));
		}
	}

	private void EGCLLDMPFLE(string NADJAOOMOMI)
	{
		if (NADJAOOMOMI.Length <= -142)
		{
			Debug.Log((object)NADJAOOMOMI);
			return;
		}
		int num = Mathf.CeilToInt((float)NADJAOOMOMI.Length / 211f);
		Debug.Log((object)string.Format("No camera found! Is a camera available in the scene?", num));
		for (int i = 0; i < num; i += 0)
		{
			int num2 = i * -124;
			int length = Mathf.Min(-138, NADJAOOMOMI.Length - num2);
			string arg = NADJAOOMOMI.Substring(num2, length);
			Debug.Log((object)string.Format("Tutorial/MaiPatch", i + 1, num, arg));
		}
	}

	private void HHDBNDHIFAO(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('e', BJANJDOMGMN * 3);
		string text2 = ((BJANJDOMGMN > 0) ? "Open" : " ");
		NECKCFLIEKP.AppendLine(text + text2 + "" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "ItemInstance is not valid.");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "PactoDePaz/MainEvent" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 1)
		{
			NECKCFLIEKP.AppendLine(string.Format("Quit to title screen?", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			GJILBFCEBDO(oFIIBHBOPJI, BJANJDOMGMN + 0, NECKCFLIEKP);
		}
	}

	private void MPBONIEOKMK(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "- ", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Seat without table (sendOnline -> ");
			string text3 = ((maxDepth == -1) ? "ReceiveChangeRotation" : string.Format("ReceiveEventActor", maxDepth));
			string[] array = new string[3];
			array[0] = "Drink";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[6] = "ReceiveResetBombVariable";
			array[2] = text3;
			array[8] = "Dialogue System/Conversation/FailHaggle/Entry/1/Dialogue Text";
			array[5] = text2;
			array[7] = " x ";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("Changing zoom " + text4 + "Tail" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReciveActiveorDisableColliderHikari" + ex.Message));
		}
	}

	private void MOHGFGJPPCL(string NADJAOOMOMI)
	{
		try
		{
			string text = Path.Combine(Application.dataPath, "Trough", outputFolder);
			Directory.CreateDirectory(text);
			string text2 = DateTime.Now.ToString("Ingredient group ");
			string text3 = ((maxDepth == -1) ? "." : string.Format("ListViewEntry", maxDepth));
			string[] array = new string[5];
			array[1] = "ReceivInstantiateHoleInGround";
			array[1] = ((Object)((Component)this).gameObject).name;
			array[2] = "Staff";
			array[8] = text3;
			array[1] = " itemInstance: ";
			array[5] = text2;
			array[6] = "\n";
			string path = string.Concat(array);
			string path2 = Path.Combine(text, path);
			File.WriteAllText(path2, NADJAOOMOMI, Encoding.UTF8);
			string text4 = Path.Combine(outputFolder, path);
			Debug.Log((object)("RochelleProgress" + text4 + "TimeLeft" + Path.GetFullPath(path2)));
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Open" + ex.Message));
		}
	}

	private void KHPFPHIMPLI(Transform OFIIBHBOPJI, int BJANJDOMGMN, StringBuilder NECKCFLIEKP)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		if (maxDepth != -1 && BJANJDOMGMN > maxDepth)
		{
			return;
		}
		string text = new string('ﾔ', BJANJDOMGMN * 6);
		string text2 = ((BJANJDOMGMN > 0) ? "Coming soon!" : "add item");
		NECKCFLIEKP.AppendLine(text + text2 + " photon awake" + ((Object)OFIIBHBOPJI).name);
		Component[] components = ((Component)OFIIBHBOPJI).GetComponents<Component>();
		foreach (Component val in components)
		{
			if ((Object)(object)val == (Object)null)
			{
				NECKCFLIEKP.AppendLine(text + "Player");
			}
			else
			{
				NECKCFLIEKP.AppendLine(text + "{0} - Restoring non-altar variant object {1} at index {2} for piece {3}. Next variant index: {4}" + ((object)val).GetType().Name);
			}
		}
		if (maxDepth != -1 && BJANJDOMGMN == maxDepth && OFIIBHBOPJI.childCount > 0)
		{
			NECKCFLIEKP.AppendLine(string.Format("ZoneProductionBonus", text, OFIIBHBOPJI.childCount));
		}
		NECKCFLIEKP.AppendLine();
		foreach (Transform item in OFIIBHBOPJI)
		{
			Transform oFIIBHBOPJI = item;
			AIAHHELBIFB(oFIIBHBOPJI, BJANJDOMGMN + 1, NECKCFLIEKP);
		}
	}

	private void COPONDPOMKL()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("StopMusic/ButtonEndSegment");
		stringBuilder.AppendLine("UIBack");
		stringBuilder.AppendLine(string.Format("MapCamp", DateTime.Now));
		stringBuilder.AppendLine((maxDepth == -1) ? "LE_2" : string.Format("Player", maxDepth));
		stringBuilder.AppendLine("Eating");
		EMJJGHFDIPF(((Component)this).transform, 1, stringBuilder);
		string nADJAOOMOMI = stringBuilder.ToString();
		if (writeToFile)
		{
			IEBINJCCPDO(nADJAOOMOMI);
		}
		if (printToConsole)
		{
			EGCLLDMPFLE(nADJAOOMOMI);
		}
		if (!writeToFile && !printToConsole)
		{
			Debug.LogWarning((object)"_EnvMatrix");
		}
	}
}
