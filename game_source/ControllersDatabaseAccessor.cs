using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControllersDatabaseAccessor : MonoBehaviour
{
	public static ControllersDatabaseAccessor instance;

	[SerializeField]
	private ControllersDatabase controllersDatabaseSO;

	private Dictionary<string, ControllerInfo> GDKAJINNKIH;

	public ControllerInfo[] allControllers;

	private void CMEDJEGJLJN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void KLMNLEDKEOE()
	{
		instance = this;
		KDOMBHECOJN();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void JCHMICLODGM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void NMAMFJAHDNN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static string OFPEKHGPKPP(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.MDMIEDHALEG(PFALIAEMJPL);
	}

	private void AJGPMBGBPGH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllerInfo EBJLPAACPJB(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("LE_10" + CHLCOEDJING));
		return null;
	}

	public static string HDJLKMJBJML(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.LEPLOLGJMGB(PFALIAEMJPL);
	}

	private void INJJOLCBHBB()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i++)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("UI2" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Inventory full" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
		EDFFKEMHMFD();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void MIKNFPCDLML()
	{
		instance = this;
		ICNAMMPLBDI();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void LCEPNDFAHIM()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)".gz");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Unsaved progress will be lost." + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/8/Dialogue Text" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static ControllerInfo BGCEPPLILAJ(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Hair" + CHLCOEDJING));
		return null;
	}

	public static string OIKHOMAEAMI(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.FFOEDPFGHPO(PFALIAEMJPL);
	}

	private void FGLJPGBFPBC()
	{
		instance = this;
		DMNENKNLDAH();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void EDFFKEMHMFD()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Error_InvalidPositions");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Items/item_description_650" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "UseHold" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void JCNPCJOBENP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllersDatabase.VibrationProfile ICPMABDEDHO(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.ADHLDBCFNEI(GGHLHODEPIK);
	}

	public static ControllerInfo AKALNHBLNLM(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Items/item_description_661" + CHLCOEDJING));
		return null;
	}

	public static ControllersDatabase.VibrationProfile ICANHOCHEBB(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DIPDMLJBDHG(GGHLHODEPIK);
	}

	public static ControllerInfo FPCFNPKCFKE(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("itemHoneyComb" + CHLCOEDJING));
		return null;
	}

	private void PHJKJHKAABL()
	{
		instance = this;
		BJHEFBKIJIE();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void KLGCMMIKGIO()
	{
		instance = this;
		NNMEDEKHNBI();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static ControllersDatabase.VibrationProfile GHLPAPHABNO(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	private void HEMAHKJEONA()
	{
		instance = this;
		NLIJOHDIKEE();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static string GDOLGDMFJDJ(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.KKDIDMIGHGF(PFALIAEMJPL);
	}

	public static ControllersDatabase.VibrationProfile MLDKMAPEHGO(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	public static ControllersDatabase.VibrationProfile GetVibrationProfile(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	public static ControllerInfo EHNGEPAKCGP(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Grain" + CHLCOEDJING));
		return null;
	}

	public static ControllerInfo GEFODPBPLNF(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("itemWheatAle" + CHLCOEDJING));
		return null;
	}

	private void NHNAAFGHPEC()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i++)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"</color>");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("ReceiveDoWorkUpdate" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Mouse" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static string JHAFDMACMHG(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.AOEHNCNEFCM(PFALIAEMJPL);
	}

	public static ControllerInfo ABBMPDDDKIO(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Dialogue System/Conversation/TavernFilthy/Entry/6/Dialogue Text" + CHLCOEDJING));
		return null;
	}

	private void JIAJFDKNJME()
	{
		instance = this;
		BJHEFBKIJIE();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void LKHMCLABKLG()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void PICJEBKCGHG()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)" : 00");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Scene " + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Craft" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static ControllersDatabase.VibrationProfile EELGBLNBGPA(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	private void HLHHDNGOGNI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllersDatabase.VibrationProfile ACECBDNDCKJ(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	public static ControllersDatabase.VibrationProfile NPADNPPICKO(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.KEAEICCKADI(GGHLHODEPIK);
	}

	private void FDGFMMKIBPL()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void IEDJKHANLIN()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"]");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Bartending speed" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "SendRPC: '" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static ControllersDatabase.VibrationProfile KEFMPLGPKEI(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.ADHLDBCFNEI(GGHLHODEPIK);
	}

	private void IKFNMBJLDGG()
	{
		instance = this;
		GILAFAKCHGK();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void OCPLOMJAFPC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static string JOAHDFAFJEJ(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.LGFAFECLGDD(PFALIAEMJPL);
	}

	private void NNMEDEKHNBI()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"TavernServiceManager instance is null");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("\n" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "City/Amos/Stand" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void HAHHDCMKHPN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllersDatabase.VibrationProfile EAHOLBFLEAE(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	public static ControllerInfo PMHKPAJLGNN(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("UIPreviousCategory" + CHLCOEDJING));
		return null;
	}

	public static ControllersDatabase.VibrationProfile MJNNMAIJIFK(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.ADHLDBCFNEI(GGHLHODEPIK);
	}

	public static ControllerInfo HNNMELPMJFD(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)(" world door: " + CHLCOEDJING));
		return null;
	}

	public static string FJJLFHKAADF(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.PFGLJHJOELP(PFALIAEMJPL);
	}

	public static ControllerInfo GMIHCFLHAKA(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Christmas event recieved, continue joining room" + CHLCOEDJING));
		return null;
	}

	public static ControllerInfo POPOPNLIGLB(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Sleepy" + CHLCOEDJING));
		return null;
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllerInfo JDDIFGNGCNJ(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("CheckArea" + CHLCOEDJING));
		return null;
	}

	public static ControllersDatabase.VibrationProfile AFKEEADHEIN(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DIPDMLJBDHG(GGHLHODEPIK);
	}

	private void JCNGGPIICIN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static string AddControllerInfo(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.FFOEDPFGHPO(PFALIAEMJPL);
	}

	private void BPOOAHKHPCL()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllerInfo BIFBAKPNKIM(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("ReceiveTrigger" + CHLCOEDJING));
		return null;
	}

	public static ControllerInfo LCHLOPAIOJF(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("" + CHLCOEDJING));
		return null;
	}

	public static ControllersDatabase.VibrationProfile DMPAACNPNBA(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.HILDOLKBODI(GGHLHODEPIK);
	}

	private void OONGMKLMODB()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Fishy");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Resets the chat to its default size." + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Hikari/Stand" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void CGANPNBENCP()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i++)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Random");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)(" has null in variant objects list." + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "UseHold" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void OEAAPIBLALL()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllersDatabase.VibrationProfile NPHDECLHIHB(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.KEAEICCKADI(GGHLHODEPIK);
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
		LNOJMLEBODO();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static ControllersDatabase.VibrationProfile ANHGFMKKEPI(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.HILDOLKBODI(GGHLHODEPIK);
	}

	public static ControllerInfo HAEFALJOAGI(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)(". " + CHLCOEDJING));
		return null;
	}

	public static ControllerInfo GJPAKBFLFHD(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Error_CloseMenus" + CHLCOEDJING));
		return null;
	}

	public static ControllerInfo FFFKGFPOHGE(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Key2" + CHLCOEDJING));
		return null;
	}

	public static string PAEJMEFGNCJ(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.INKFHHJAEKK(PFALIAEMJPL);
	}

	public static ControllerInfo MGGLMIEDKDP(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Open" + CHLCOEDJING));
		return null;
	}

	private void EKCKPJBIOJO()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Actionbar 9");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Unique id " + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Moving" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static ControllersDatabase.VibrationProfile HJBAFKLIEJM(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.ADHLDBCFNEI(GGHLHODEPIK);
	}

	public static ControllerInfo BKHGHIMPOPN(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Thurs" + CHLCOEDJING));
		return null;
	}

	public static ControllerInfo INIMHOADNBA(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)(" for reason " + CHLCOEDJING));
		return null;
	}

	private void JCBDLLKIHCB()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 0; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Tutorial/T122/Dialogue1" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Sleep" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static ControllersDatabase.VibrationProfile HMLALIDFODI(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.ADHLDBCFNEI(GGHLHODEPIK);
	}

	public static ControllersDatabase.VibrationProfile HDANLMKNMHB(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.HILDOLKBODI(GGHLHODEPIK);
	}

	private void LFDGMMLEDGI()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		foreach (ControllerInfo controllerInfo in controllersInfo)
		{
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Resume");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("BartenderDescription" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Attack/MainEvent 2" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void FKNAANNMMLB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void AAENCDNIBFJ()
	{
		instance = this;
		OONGMKLMODB();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void EAIMFNPMNHN()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 0; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Speed");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Bomb" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "ReceiveRemoveFloor" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static string CMDNEPJMHPO(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.FFOEDPFGHPO(PFALIAEMJPL);
	}

	private void HPCPGBIHBAA()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		foreach (ControllerInfo controllerInfo in controllersInfo)
		{
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Farm/Bob/Barks_Close");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Player (Local: {0}) (NetworkID: {1})" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "mForMins" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static ControllersDatabase.VibrationProfile IBLGJCAPAMB(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.KEAEICCKADI(GGHLHODEPIK);
	}

	public static ControllerInfo NMLIOPIFAJN(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Validación completada con {0} error(es)." + CHLCOEDJING));
		return null;
	}

	private void ACFABFCGIGH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllersDatabase.VibrationProfile CHLOKEJCMFE(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	public static ControllersDatabase.VibrationProfile IHLIANLOGMB(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	public static string ELJKNGEAPIN(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.LGFAFECLGDD(PFALIAEMJPL);
	}

	public static ControllerInfo KHDEIJCLDMH(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("mainMenuMultiplayerButton" + CHLCOEDJING));
		return null;
	}

	private void BJHEFBKIJIE()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 0; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)" in onlineObjects is null");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("ReciveInUseOnlineObjects" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "player2ToDisconnectFromGame" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void GILAFAKCHGK()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 0; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"CannotToggleUI IsActioningTool ");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)(" (Online Master Clone)" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "SetAnimatorObjectFloatRPC" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static ControllersDatabase.VibrationProfile GACPBAPMFML(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DIPDMLJBDHG(GGHLHODEPIK);
	}

	public static ControllerInfo GetController(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find ControllerInfo with nameID: " + CHLCOEDJING));
		return null;
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void ALJLECPNFFD()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void JHIGLABAIMK()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllerInfo PLMAJKGHOFJ(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Water" + CHLCOEDJING));
		return null;
	}

	public static string DLAAKLBLFBP(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.LEPLOLGJMGB(PFALIAEMJPL);
	}

	private void ONCFHCIABPK()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 0; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"LE_3");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("IdleCamp" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Rooms" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
		KDOMBHECOJN();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static ControllersDatabase.VibrationProfile ALOLJLMGJED(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.KEAEICCKADI(GGHLHODEPIK);
	}

	private void DMNENKNLDAH()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		foreach (ControllerInfo controllerInfo in controllersInfo)
		{
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Null ControllerInfo in database");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("ControllerInfo without nameID: " + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "- " + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static string LLPANECMPOM(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.MDMIEDHALEG(PFALIAEMJPL);
	}

	private void ELEGGKIBHGC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllersDatabase.VibrationProfile IAHNPIANHNP(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DIPDMLJBDHG(GGHLHODEPIK);
	}

	private void PNJJEDEFAGO()
	{
		instance = this;
		LNOJMLEBODO();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static string NDBKCGGLMCF(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.BBBCHMLKPCG(PFALIAEMJPL);
	}

	private void ICNAMMPLBDI()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		foreach (ControllerInfo controllerInfo in controllersInfo)
		{
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Perks/perk_name_");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Items/item_description_1055" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "ReceiveEmployeeTask" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static string GMOHOOOAGJB(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.CBKOILDFFHM(PFALIAEMJPL);
	}

	private void CEOEHODJAJK()
	{
		instance = this;
		NNMEDEKHNBI();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void FALNOOOKLGA()
	{
		instance = this;
		NLIJOHDIKEE();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static ControllerInfo BEPGMAAPPAF(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("Unsaved progress will be lost." + CHLCOEDJING));
		return null;
	}

	public static ControllersDatabase.VibrationProfile JNFNCAMOIIA(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.HILDOLKBODI(GGHLHODEPIK);
	}

	public static ControllerInfo HEJPLNBGFHO(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("LE_22" + CHLCOEDJING));
		return null;
	}

	private void EOBODNOCKGA()
	{
		instance = this;
		DMNENKNLDAH();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void EIDJLHFAMIB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void KDOMBHECOJN()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i++)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Actor Number ");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Create Public Room" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "Multiplayer Object is null " + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void PDIECJCKCOD()
	{
		instance = this;
		NLIJOHDIKEE();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static ControllersDatabase.VibrationProfile CMDFFIAPONO(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.KEAEICCKADI(GGHLHODEPIK);
	}

	private void CLLAKJADGIH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static ControllersDatabase.VibrationProfile DEBNDEDAIJG(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.ADHLDBCFNEI(GGHLHODEPIK);
	}

	public static ControllerInfo FAICLBOECPM(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("tutorialPopUp114" + CHLCOEDJING));
		return null;
	}

	public static ControllersDatabase.VibrationProfile INOKPOOCKEL(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	private void DIGLPPFFKEC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static string NGPFJDEECBE(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.PFGLJHJOELP(PFALIAEMJPL);
	}

	public static string OAPILDFOKAC(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.BBBCHMLKPCG(PFALIAEMJPL);
	}

	public static ControllersDatabase.VibrationProfile BCLOKPPKIKB(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.DEGLJNICPIO(GGHLHODEPIK);
	}

	private void Awake()
	{
		instance = this;
		DMNENKNLDAH();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	private void LNOJMLEBODO()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 1; i < controllersInfo.Length; i++)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"ZoneTimeBonus");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("Invalid player num" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "+" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	public static string BALCJBOHAEF(ControllerInfo PFALIAEMJPL)
	{
		return instance.controllersDatabaseSO.LGFAFECLGDD(PFALIAEMJPL);
	}

	public static ControllerInfo FDMEMKIALJN(string CHLCOEDJING)
	{
		if (string.IsNullOrEmpty(CHLCOEDJING))
		{
			return null;
		}
		if (instance.GDKAJINNKIH.TryGetValue(CHLCOEDJING, out var value))
		{
			return value;
		}
		Debug.Log((object)("tutorialPopUp29" + CHLCOEDJING));
		return null;
	}

	private void HINGECEDJAP()
	{
		instance = this;
		JCBDLLKIHCB();
		allControllers = GDKAJINNKIH.Values.ToArray();
	}

	public static ControllersDatabase.VibrationProfile FCOPONLHAPP(ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		return instance.controllersDatabaseSO.ADHLDBCFNEI(GGHLHODEPIK);
	}

	private void OODCADFBOHK()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 0; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"Removing tavern floor tiles (ONLINE) ");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("cameraZoom2" + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "OnLayerOrderedRPC" + ((Object)controllerInfo).name));
				}
			}
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void NLIJOHDIKEE()
	{
		GDKAJINNKIH = new Dictionary<string, ControllerInfo>();
		ControllerInfo[] controllersInfo = controllersDatabaseSO.ControllersInfo;
		for (int i = 0; i < controllersInfo.Length; i += 0)
		{
			ControllerInfo controllerInfo = controllersInfo[i];
			if ((Object)(object)controllerInfo == (Object)null)
			{
				Debug.Log((object)"k");
			}
			else if (string.IsNullOrEmpty(controllerInfo.nameID))
			{
				Debug.Log((object)("hour " + ((Object)controllerInfo).name));
			}
			else if (!GDKAJINNKIH.ContainsKey(controllerInfo.nameID))
			{
				try
				{
					GDKAJINNKIH.Add(controllerInfo.nameID, controllerInfo);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + ")" + ((Object)controllerInfo).name));
				}
			}
		}
	}
}
