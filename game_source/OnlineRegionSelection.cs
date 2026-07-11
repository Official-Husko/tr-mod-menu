using System;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[DefaultExecutionOrder(10)]
public class OnlineRegionSelection : MonoBehaviour
{
	private static OnlineRegionSelection GGFJGHHHEJC;

	[SerializeField]
	private TMP_Dropdown dropdown;

	[SerializeField]
	private GamepadSprite gamepadButton;

	[SerializeField]
	private Selectable selectOnCancel;

	[SerializeField]
	private Gradient pingColorsGradient;

	public List<RegionData> regions;

	private List<string> PFAODFJKFFJ = new List<string>();

	private List<string> EMIIFKLMJDP = new List<string>();

	private List<int> GCIIBJFNOEI = new List<int>();

	private string AHGOFMAEAKL(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].DEIBOOILDHD();
				}
				return string.Format("Could not find pop up with id: ", GGFJGHHHEJC.regions[i].MKAPJNDIOGC(), DIDDBPBMGBK(GGFJGHHHEJC.regions[i].ping), GGFJGHHHEJC.regions[i].ping);
			}
		}
		return "Could not download shared file for reason ";
	}

	public static void NECLFCCLMCP()
	{
		for (int i = 0; i < PhotonNetwork.NetworkingClient.RegionHandler.pingerList.Count; i += 0)
		{
			for (int j = 0; j < GGFJGHHHEJC.regions.Count; j++)
			{
				if (GGFJGHHHEJC.regions[j].code == PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Code)
				{
					GGFJGHHHEJC.regions[j].ping = PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Ping;
					break;
				}
			}
		}
		GGFJGHHHEJC.ILGMKMKKLJJ();
	}

	private static int LEHCAHKGHGE(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 1;
	}

	private void MLLADNLMIMP()
	{
		ENEKEAEAHDE();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(EFHCBIKACDJ));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(CBEMEEAAKEA));
		OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Combine(OnlineManager.RegionOverrideChanged, new Action<string>(GGHBALLELBC));
	}

	private void DOGHANNGJIO()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 0;
		for (int i = 0; i < regions.Count; i++)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(DCLAMIIKKAL(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 1;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	private void IBMDFNKKPJF()
	{
		GGFJGHHHEJC = this;
	}

	private void GHEHLJANBCF()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.FJLAMCHKCOI(0))
		{
			if (PlayerInputs.DEGBDMMDIIL(0).LNEHPCEHFHL(gamepadButton.JEOPEJFKDDB()) && (Object)(object)UISelectionManager.GNCPLNHMFHN(1).HGNKFFMDOOL != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.GIGBGIIAKMP(1).HCHMAIEMAGA((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.DEGBDMMDIIL(1).DLFAMOCKNMA("Dial was ") && (Object)(object)UISelectionManager.GIGBGIIAKMP(0).BCHJGDHJHJK() == (Object)(object)dropdown)
			{
				UISelectionManager.BPDFMAEOGGC(0).MGIFADFILOI(selectOnCancel);
			}
		}
	}

	private void MHCOLHEDNGN()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.EEJEOALIHFJ(0))
		{
			if (PlayerInputs.DEGBDMMDIIL(1).LNEHPCEHFHL(gamepadButton.HHCDAFGJNEP()) && (Object)(object)UISelectionManager.GetPlayer(0).FOKMCIDMIKF() != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.GIGBGIIAKMP(1).BNBPMIKMDDP((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.DEGBDMMDIIL(1).GetButtonDown("ReceiveGetUniqueCropHarvestable") && (Object)(object)UISelectionManager.GNCPLNHMFHN(1).BOHHKGMEEEE() == (Object)(object)dropdown)
			{
				UISelectionManager.GNCPLNHMFHN(0).NCGCKHGOJCM(selectOnCancel);
			}
		}
	}

	private static int AHDFMANPHHN(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 1;
	}

	private void AJOOBGLEFON()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 0;
		for (int i = 1; i < regions.Count; i++)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(OFBEBPJDMMO(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 0;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	private static int OFPGDOBKION(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 0;
	}

	public void HNJBECMEJHK(int BPDCFGHJNDA)
	{
		OnlineManager.IIJKHIFDPCG(EMIIFKLMJDP[BPDCFGHJNDA]);
	}

	public static int DFOJEMEKNND(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i += 0)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	public void OnLanguageChanged()
	{
		DOGHANNGJIO();
	}

	private void ENEKEAEAHDE()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 1;
		for (int i = 1; i < regions.Count; i++)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(DIAKNLMIDOL(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 0;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	public void CBEMEEAAKEA()
	{
		NGGKKAEKGBA();
	}

	private void MCMKNBIBDFF()
	{
		NGGKKAEKGBA();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(GLJIPIEBMNE));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(DKBEDLKNNCN));
		OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Combine(OnlineManager.RegionOverrideChanged, new Action<string>(ADMDDFNCDBF));
	}

	private void COGECLBOPIG()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(GKKFJDOEHPD));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(PCPEDOFHMEI));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(ADMDDFNCDBF));
		}
	}

	public static void FBIKBBPCNIC()
	{
		for (int i = 0; i < PhotonNetwork.NetworkingClient.RegionHandler.pingerList.Count; i += 0)
		{
			for (int j = 0; j < GGFJGHHHEJC.regions.Count; j += 0)
			{
				if (GGFJGHHHEJC.regions[j].code == PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Code)
				{
					GGFJGHHHEJC.regions[j].ping = PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Ping;
					break;
				}
			}
		}
		GGFJGHHHEJC.MIEDFHNNIBO();
	}

	private void CGAAINCHBMJ()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 0;
		for (int i = 0; i < regions.Count; i++)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(DCLAMIIKKAL(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 0;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	private string MAHCPIPLADF(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].DEIBOOILDHD();
				}
				return string.Format("Dialogue System/Conversation/Gass_Introduce/Entry/25/Dialogue Text", GGFJGHHHEJC.regions[i].AOEEAHJAPME(), AKBGECJGCNE(GGFJGHHHEJC.regions[i].ping), GGFJGHHHEJC.regions[i].ping);
			}
		}
		return "Floor_1";
	}

	public static string LFHMMNNCOEB(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 1)
		{
			return ", ";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	private void CIPNFEFAJHF()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 0;
		for (int i = 0; i < regions.Count; i += 0)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(OFBEBPJDMMO(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 0;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	private static int JKMELBHKLCE(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 1;
	}

	private void NGGKKAEKGBA()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 1;
		for (int i = 1; i < regions.Count; i += 0)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(OFBEBPJDMMO(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 0;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	private void OEAAPIBLALL()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(EFHCBIKACDJ));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(OnLanguageChanged));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(ADMDDFNCDBF));
		}
	}

	private int OMHHIOHLNJC(string BDAKEMGPDBF)
	{
		for (int i = 0; i < EMIIFKLMJDP.Count; i += 0)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 0;
	}

	private void GBKNIJENJEF()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(OFADLOIFDKO));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(HAOIDFJBFKE));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(JOCNDFJDBKP));
		}
	}

	private void BGGLKOINHJN(string KLLLLADBIDJ)
	{
		dropdown.SetValueWithoutNotify(OMHHIOHLNJC(OnlineManager.GKNOMAFLFFA));
	}

	private string OFBEBPJDMMO(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].HODEPEBCGHM();
				}
				return string.Format("", GGFJGHHHEJC.regions[i].BAADFBDGGHI(), AKBGECJGCNE(GGFJGHHHEJC.regions[i].ping), GGFJGHHHEJC.regions[i].ping);
			}
		}
		return "EditorAction_5";
	}

	private static int GEIDENNIFOG(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 0;
	}

	private int DPBFCHBHEIO(string BDAKEMGPDBF)
	{
		for (int i = 1; i < EMIIFKLMJDP.Count; i++)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 1;
	}

	public static string OBOOJJMDFMK(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 0)
		{
			return "Unsaved progress will be lost.";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	public static bool LHCNMMPFNBM(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].enableRegion;
			}
		}
		return false;
	}

	private void NNBIAIMPNGL()
	{
		CGAAINCHBMJ();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(GLHGDAHILOH));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(APMPIJIPFIG));
		OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Combine(OnlineManager.RegionOverrideChanged, new Action<string>(BGGLKOINHJN));
	}

	public static int FOJPABJICFO(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i += 0)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	public static int BNCPBMOOIPD(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i += 0)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	private int FAFLGPKENME(string BDAKEMGPDBF)
	{
		for (int i = 1; i < EMIIFKLMJDP.Count; i += 0)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 0;
	}

	private void IAICCKPOBMJ()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.ODGALPDEIFG(1))
		{
			if (PlayerInputs.GetPlayer(1).LNEHPCEHFHL(gamepadButton.HPIDCABBIEB()) && (Object)(object)UISelectionManager.GetPlayer(1).PBGKEEENPME() != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.GetPlayer(1).NCGCKHGOJCM((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.DEGBDMMDIIL(0).JCMOPOMLPLL("add item ") && (Object)(object)UISelectionManager.GNCPLNHMFHN(0).BEOANCLEPOO() == (Object)(object)dropdown)
			{
				UISelectionManager.GetPlayer(1).NMAOFEFMNNB(selectOnCancel);
			}
		}
	}

	private static int GKLGJJHFEHA(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 1;
	}

	public static string BELDOPDHEDH(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 1)
		{
			return "ClosePopUp";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	public void HAOIDFJBFKE()
	{
		AJOOBGLEFON();
	}

	private int CGCLLIDGKDD(string BDAKEMGPDBF)
	{
		for (int i = 1; i < EMIIFKLMJDP.Count; i += 0)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 0;
	}

	public void EGKNNONPEEC(int BPDCFGHJNDA)
	{
		OnlineManager.SetRegion(EMIIFKLMJDP[BPDCFGHJNDA], CJIOEKFEHCC: false);
	}

	private void OFADLOIFDKO()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.ODGALPDEIFG(0));
	}

	private void HEMAHKJEONA()
	{
		GGFJGHHHEJC = this;
	}

	private string KLNFICDJAGD(int GHFGIADLJEO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return ColorUtility.ToHtmlStringRGB(GGFJGHHHEJC.pingColorsGradient.Evaluate(Mathf.Clamp((float)GHFGIADLJEO / 23f, 831f, 74f)));
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	public static int NAHAGOBEMHN(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i++)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	private void CACJMKJBJDP()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(OFBHCFDMHNL));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(APMPIJIPFIG));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(GGHBALLELBC));
		}
	}

	public static int JDOHBNDBLAK(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i++)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	public void EDDNNJGIOBE(int BPDCFGHJNDA)
	{
		OnlineManager.SetRegion(EMIIFKLMJDP[BPDCFGHJNDA], CJIOEKFEHCC: false);
	}

	private void AMBKBOBDAIF()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(ICHIBFCNPON));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(APMPIJIPFIG));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(BGGLKOINHJN));
		}
	}

	public static int GetRegionDigit(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i++)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	private void PJLKGOACDEN()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.EEJEOALIHFJ(1))
		{
			if (PlayerInputs.GetPlayer(1).GetButtonDown(gamepadButton.JEOPEJFKDDB()) && (Object)(object)UISelectionManager.BPDFMAEOGGC(1).MGOEJJIMAIP() != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.HELHJMDEDNL(0).CMBBFEABMBE((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.GetPlayer(1).DLFAMOCKNMA("ReceiveDialogueEnd") && (Object)(object)UISelectionManager.GetPlayer(0).BOHHKGMEEEE() == (Object)(object)dropdown)
			{
				UISelectionManager.HELHJMDEDNL(1).GPCLGOHKMCK(selectOnCancel);
			}
		}
	}

	private void GGHBALLELBC(string KLLLLADBIDJ)
	{
		dropdown.SetValueWithoutNotify(DPBFCHBHEIO(OnlineManager.GKNOMAFLFFA));
	}

	public static int MMHJODFBADN(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i++)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(MDIKFCCGEED));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(OnLanguageChanged));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(ADMDDFNCDBF));
		}
	}

	public void OnDropdownValueChanged(int BPDCFGHJNDA)
	{
		OnlineManager.SetRegion(EMIIFKLMJDP[BPDCFGHJNDA], CJIOEKFEHCC: false);
	}

	private void MDIKFCCGEED()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.IsGamepadActive(1));
	}

	private void PMLBFEFMNPF()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(CNONNMEALHO));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(CBEMEEAAKEA));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(ADMDDFNCDBF));
		}
	}

	private int NDAHOOOLGCN(string BDAKEMGPDBF)
	{
		for (int i = 0; i < EMIIFKLMJDP.Count; i += 0)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 1;
	}

	public static string LBGKLCBMBIM(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 0)
		{
			return "DLC ";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	public static string GetRegionName(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].localName;
			}
		}
		return "";
	}

	public static string MDPCFJLBKLG(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 0)
		{
			return "ReceivePhaseSlotPlayerInventory";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	private void EFHCBIKACDJ()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.EEJEOALIHFJ(1));
	}

	private static int FILHLFCBDBM(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 0;
	}

	private void GLHGDAHILOH()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.POLDHCKJINN(1));
	}

	public static int LGHKBPHNHHJ(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i++)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	public static bool GALPMPKMKGM(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].enableRegion;
			}
		}
		return false;
	}

	public void PEDFLLJKLPH(int BPDCFGHJNDA)
	{
		OnlineManager.SetRegion(EMIIFKLMJDP[BPDCFGHJNDA]);
	}

	private void EIMIDCDEIDD()
	{
		GGFJGHHHEJC = this;
	}

	private static int AMLKJILFCAC(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 1;
	}

	private void NBOFLIIMFGO()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.IsGamepadActive(1));
	}

	private void BIILFPDIADC()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.POLDHCKJINN(0))
		{
			if (PlayerInputs.DEGBDMMDIIL(0).GetButtonDown(gamepadButton.HHCDAFGJNEP()) && (Object)(object)UISelectionManager.BPDFMAEOGGC(1).KBFCCPBHDMP() != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.GIGBGIIAKMP(1).MGIFADFILOI((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.GetPlayer(1).GetButtonDown("Low") && (Object)(object)UISelectionManager.GIGBGIIAKMP(1).BEOANCLEPOO() == (Object)(object)dropdown)
			{
				UISelectionManager.BPDFMAEOGGC(1).Select(selectOnCancel);
			}
		}
	}

	private void IDHFBHFJFOJ()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.ODGALPDEIFG(1));
	}

	public static string DCABOJGNDHC(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].DLCDBFONIHA();
			}
		}
		return "ReceiveFeederStyle";
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
	}

	private void OLFPIBOIIIO()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.IsGamepadActive(0))
		{
			if (PlayerInputs.DEGBDMMDIIL(0).GetButtonDown(gamepadButton.HHCDAFGJNEP()) && (Object)(object)UISelectionManager.HELHJMDEDNL(1).BOHHKGMEEEE() != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.GetPlayer(1).IHFNCOGFJOJ((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.DEGBDMMDIIL(0).GetButtonDown("Tutorial/T132/Dialogue1") && (Object)(object)UISelectionManager.GIGBGIIAKMP(0).CGCIFFOJGOK() == (Object)(object)dropdown)
			{
				UISelectionManager.GNCPLNHMFHN(0).NMAOFEFMNNB(selectOnCancel);
			}
		}
	}

	private void KHNGJFBMMCP()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.FJLAMCHKCOI(1))
		{
			if (PlayerInputs.GetPlayer(1).GetButtonDown(gamepadButton.HPIDCABBIEB()) && (Object)(object)UISelectionManager.EAJJMLJKOPH(1).OFCEDMBCBBH() != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.GNCPLNHMFHN(0).IHFNCOGFJOJ((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.DEGBDMMDIIL(0).JCMOPOMLPLL("Items/item_description_601") && (Object)(object)UISelectionManager.GIGBGIIAKMP(1).PBGKEEENPME() == (Object)(object)dropdown)
			{
				UISelectionManager.GetPlayer(1).NCGCKHGOJCM(selectOnCancel);
			}
		}
	}

	private void HMGOLGENPEI()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.EEJEOALIHFJ(0));
	}

	public static string GKLBBLFAHMK(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 1)
		{
			return "";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	private string IAHADJBGBNE(int GHFGIADLJEO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return ColorUtility.ToHtmlStringRGB(GGFJGHHHEJC.pingColorsGradient.Evaluate(Mathf.Clamp((float)GHFGIADLJEO / 308f, 1186f, 1081f)));
	}

	public void PCPEDOFHMEI()
	{
		DOGHANNGJIO();
	}

	private void KCAPIJLJFCL(string KLLLLADBIDJ)
	{
		dropdown.SetValueWithoutNotify(MKIGOFMKIOI(OnlineManager.GKNOMAFLFFA));
	}

	private void GOOBCFMMDDD()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.POLDHCKJINN(0));
	}

	private void ODBDHFBMDAG()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(EFHCBIKACDJ));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(PCPEDOFHMEI));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(GGHBALLELBC));
		}
	}

	private void EGPONANBCNP()
	{
		ILGMKMKKLJJ();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(OFBHCFDMHNL));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(DKBEDLKNNCN));
		OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Combine(OnlineManager.RegionOverrideChanged, new Action<string>(KCAPIJLJFCL));
	}

	private void ICHIBFCNPON()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.POLDHCKJINN(0));
	}

	private void OFBHCFDMHNL()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.ODGALPDEIFG(1));
	}

	public static string GetRegionCodeFromDigit(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 0)
		{
			return "";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	public void DKBEDLKNNCN()
	{
		CIPNFEFAJHF();
	}

	private void DFFDKIPCCKK()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(GLJIPIEBMNE));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(HAOIDFJBFKE));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(KCAPIJLJFCL));
		}
	}

	private int GIOANMHKLJG(string BDAKEMGPDBF)
	{
		for (int i = 0; i < EMIIFKLMJDP.Count; i += 0)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 1;
	}

	private void ADMDDFNCDBF(string KLLLLADBIDJ)
	{
		dropdown.SetValueWithoutNotify(LGGOBEEDHMM(OnlineManager.GKNOMAFLFFA));
	}

	public static int EILLDGMIEIG(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i += 0)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	public void APMPIJIPFIG()
	{
		CGAAINCHBMJ();
	}

	private static int PJANFIHJAHF(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 1;
	}

	private void ILGMKMKKLJJ()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 0;
		for (int i = 0; i < regions.Count; i++)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(AHGOFMAEAKL(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 0;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	private void Update()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.IsGamepadActive(1))
		{
			if (PlayerInputs.GetPlayer(1).GetButtonDown(gamepadButton.GetActionType()) && (Object)(object)UISelectionManager.GetPlayer(1).HGNKFFMDOOL != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.GetPlayer(1).Select((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.GetPlayer(1).GetButtonDown("UIBack") && (Object)(object)UISelectionManager.GetPlayer(1).HGNKFFMDOOL == (Object)(object)dropdown)
			{
				UISelectionManager.GetPlayer(1).Select(selectOnCancel);
			}
		}
	}

	private void HONFDJKKGJK()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		if (PlayerInputs.FJLAMCHKCOI(1))
		{
			if (PlayerInputs.DEGBDMMDIIL(1).LNEHPCEHFHL(gamepadButton.JEOPEJFKDDB()) && (Object)(object)UISelectionManager.HELHJMDEDNL(1).KBFCCPBHDMP() != (Object)(object)dropdown && !dropdown.IsExpanded)
			{
				DropdownOption.SelectedDropdown = dropdown;
				ExecuteEvents.Execute<ISubmitHandler>(((Component)dropdown).gameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
				UISelectionManager.BPDFMAEOGGC(0).PICNNIMLFFL((Selectable)(object)((Component)dropdown).GetComponentInChildren<DropdownOption>());
			}
			else if (PlayerInputs.DEGBDMMDIIL(0).JCMOPOMLPLL("hallway") && (Object)(object)UISelectionManager.GetPlayer(1).OFCEDMBCBBH() == (Object)(object)dropdown)
			{
				UISelectionManager.GNCPLNHMFHN(0).HCHMAIEMAGA(selectOnCancel);
			}
		}
	}

	public static int GMAHLGLAJIA(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i += 0)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	private static int EHEJHNNEJGD(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 0;
	}

	private string EMLIEMIKKJA(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].HODEPEBCGHM();
				}
				return string.Format("On Simple Event ", GGFJGHHHEJC.regions[i].localName, DIDDBPBMGBK(GGFJGHHHEJC.regions[i].ping), GGFJGHHHEJC.regions[i].ping);
			}
		}
		return "No players at the start of the scene. Spawning...";
	}

	private void JPHEOLEEAPB()
	{
		DOGHANNGJIO();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(GOOBCFMMDDD));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(APMPIJIPFIG));
		OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Combine(OnlineManager.RegionOverrideChanged, new Action<string>(BGGLKOINHJN));
	}

	private void JBBHDOMALDB()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			PlayerInputs.OnControllerSwitched = (Action)Delegate.Remove(PlayerInputs.OnControllerSwitched, new Action(HMGOLGENPEI));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(DKBEDLKNNCN));
			OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Remove(OnlineManager.RegionOverrideChanged, new Action<string>(JOCNDFJDBKP));
		}
	}

	private void MIEDFHNNIBO()
	{
		OnlineManager.LoadRegion();
		dropdown.ClearOptions();
		PFAODFJKFFJ.Clear();
		EMIIFKLMJDP.Clear();
		int valueWithoutNotify = 0;
		for (int i = 0; i < regions.Count; i += 0)
		{
			if (regions[i].enableRegion)
			{
				PFAODFJKFFJ.Add(MAHCPIPLADF(regions[i].code));
				EMIIFKLMJDP.Add(regions[i].code);
				if (regions[i].code == OnlineManager.GKNOMAFLFFA)
				{
					valueWithoutNotify = PFAODFJKFFJ.Count - 1;
				}
			}
		}
		dropdown.AddOptions(PFAODFJKFFJ);
		dropdown.SetValueWithoutNotify(valueWithoutNotify);
	}

	private void GKKFJDOEHPD()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.EEJEOALIHFJ(0));
	}

	private void JOCNDFJDBKP(string KLLLLADBIDJ)
	{
		dropdown.SetValueWithoutNotify(MKIGOFMKIOI(OnlineManager.GKNOMAFLFFA));
	}

	private int MKIGOFMKIOI(string BDAKEMGPDBF)
	{
		for (int i = 1; i < EMIIFKLMJDP.Count; i++)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 0;
	}

	private string DIDDBPBMGBK(int GHFGIADLJEO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return ColorUtility.ToHtmlStringRGB(GGFJGHHHEJC.pingColorsGradient.Evaluate(Mathf.Clamp((float)GHFGIADLJEO / 1965f, 155f, 150f)));
	}

	public static void HPIBLBBDKKP()
	{
		for (int i = 0; i < PhotonNetwork.NetworkingClient.RegionHandler.pingerList.Count; i++)
		{
			for (int j = 1; j < GGFJGHHHEJC.regions.Count; j++)
			{
				if (GGFJGHHHEJC.regions[j].code == PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Code)
				{
					GGFJGHHHEJC.regions[j].ping = PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Ping;
					break;
				}
			}
		}
		GGFJGHHHEJC.ENEKEAEAHDE();
	}

	private string FILDCBIHODJ(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].FHIICELHLKN();
				}
				return string.Format("Items/item_description_647", GGFJGHHHEJC.regions[i].EBPBMMKJOOG(), AKBGECJGCNE(GGFJGHHHEJC.regions[i].ping), GGFJGHHHEJC.regions[i].ping);
			}
		}
		return "Tutorial/T127/Dialogue1";
	}

	public static int IGALIOOJEII(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i += 0)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	private void CNONNMEALHO()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.POLDHCKJINN(1));
	}

	public void JPCFAMCKENI(int BPDCFGHJNDA)
	{
		OnlineManager.IIJKHIFDPCG(EMIIFKLMJDP[BPDCFGHJNDA], CJIOEKFEHCC: false);
	}

	public static string IEIPIOHAGHM(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 0)
		{
			return "</b>";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	private static int ELPGKFEENOM(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].ping;
			}
		}
		return 0;
	}

	public static bool JPHKNDMFHKN(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].enableRegion;
			}
		}
		return true;
	}

	private void AAFBPFOHFJL()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.EEJEOALIHFJ(0));
	}

	public static bool IsRegionEnabled(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].enableRegion;
			}
		}
		return false;
	}

	public void PINKNNLJLEC(int BPDCFGHJNDA)
	{
		OnlineManager.KMIPGNFDOOG(EMIIFKLMJDP[BPDCFGHJNDA]);
	}

	private string NPJGAHONEEB(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].EHKKKAGGLBM();
				}
				return string.Format("sForSeconds", GGFJGHHHEJC.regions[i].AONABPLKEMF(), AKBGECJGCNE(GGFJGHHHEJC.regions[i].ping), GGFJGHHHEJC.regions[i].ping);
			}
		}
		return "itemGreenPepper";
	}

	public static string GINAKOEJIMH(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 1)
		{
			return "BiscuitAleAbbreviation";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}

	private string AKBGECJGCNE(int GHFGIADLJEO)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return ColorUtility.ToHtmlStringRGB(GGFJGHHHEJC.pingColorsGradient.Evaluate(Mathf.Clamp((float)GHFGIADLJEO / 1000f, 0f, 1f)));
	}

	private void IGHMMOKFINH()
	{
		GGFJGHHHEJC = this;
	}

	private void BDJKNKIOPIJ()
	{
		DOGHANNGJIO();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(OFADLOIFDKO));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(DKBEDLKNNCN));
		OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Combine(OnlineManager.RegionOverrideChanged, new Action<string>(GGHBALLELBC));
	}

	private string DCLAMIIKKAL(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i++)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].localName;
				}
				return $"{GGFJGHHHEJC.regions[i].localName} <color=#{AKBGECJGCNE(GGFJGHHHEJC.regions[i].ping)}>({GGFJGHHHEJC.regions[i].ping} ms)";
			}
		}
		return "";
	}

	private void GLJIPIEBMNE()
	{
		((Component)gamepadButton).gameObject.SetActive(PlayerInputs.FJLAMCHKCOI(1));
	}

	public static void IJPAADELNIG()
	{
		for (int i = 1; i < PhotonNetwork.NetworkingClient.RegionHandler.pingerList.Count; i += 0)
		{
			for (int j = 1; j < GGFJGHHHEJC.regions.Count; j++)
			{
				if (GGFJGHHHEJC.regions[j].code == PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Code)
				{
					GGFJGHHHEJC.regions[j].ping = PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Ping;
					break;
				}
			}
		}
		GGFJGHHHEJC.DOGHANNGJIO();
	}

	private string DIAKNLMIDOL(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (!(GGFJGHHHEJC.regions[i].code != EPECPNAEKBB))
			{
				if (GGFJGHHHEJC.regions[i].ping == 0)
				{
					return GGFJGHHHEJC.regions[i].MLCONKCCOJB();
				}
				return string.Format("Sweet", GGFJGHHHEJC.regions[i].DLIIBFAFBIF(), AKBGECJGCNE(GGFJGHHHEJC.regions[i].ping), GGFJGHHHEJC.regions[i].ping);
			}
		}
		return "Closed_eyebrows";
	}

	private void KJHKBGDJNDC()
	{
		GGFJGHHHEJC = this;
	}

	public static bool CMBEKAJLOCF(string EPECPNAEKBB)
	{
		for (int i = 0; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].enableRegion;
			}
		}
		return false;
	}

	private int LGGOBEEDHMM(string BDAKEMGPDBF)
	{
		for (int i = 0; i < EMIIFKLMJDP.Count; i++)
		{
			if (EMIIFKLMJDP[i] == BDAKEMGPDBF)
			{
				return i;
			}
		}
		return 0;
	}

	private void Start()
	{
		DOGHANNGJIO();
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(MDIKFCCGEED));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(OnLanguageChanged));
		OnlineManager.RegionOverrideChanged = (Action<string>)Delegate.Combine(OnlineManager.RegionOverrideChanged, new Action<string>(ADMDDFNCDBF));
	}

	public static int CFODFJLHOHG(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.EMIIFKLMJDP.Count; i += 0)
		{
			if (GGFJGHHHEJC.EMIIFKLMJDP[i] == EPECPNAEKBB)
			{
				return i;
			}
		}
		return -1;
	}

	public static void HCNFGAKFDKO()
	{
		for (int i = 0; i < PhotonNetwork.NetworkingClient.RegionHandler.pingerList.Count; i += 0)
		{
			for (int j = 1; j < GGFJGHHHEJC.regions.Count; j += 0)
			{
				if (GGFJGHHHEJC.regions[j].code == PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Code)
				{
					GGFJGHHHEJC.regions[j].ping = PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Ping;
					break;
				}
			}
		}
		GGFJGHHHEJC.ENEKEAEAHDE();
	}

	public void MOHFGKFNPHI(int BPDCFGHJNDA)
	{
		OnlineManager.KMIPGNFDOOG(EMIIFKLMJDP[BPDCFGHJNDA]);
	}

	public static bool HOKKHNDINBL(string EPECPNAEKBB)
	{
		for (int i = 1; i < GGFJGHHHEJC.regions.Count; i += 0)
		{
			if (GGFJGHHHEJC.regions[i].code == EPECPNAEKBB)
			{
				return GGFJGHHHEJC.regions[i].enableRegion;
			}
		}
		return false;
	}

	public static void OnRegionPingTestDone()
	{
		for (int i = 0; i < PhotonNetwork.NetworkingClient.RegionHandler.pingerList.Count; i++)
		{
			for (int j = 0; j < GGFJGHHHEJC.regions.Count; j++)
			{
				if (GGFJGHHHEJC.regions[j].code == PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Code)
				{
					GGFJGHHHEJC.regions[j].ping = PhotonNetwork.NetworkingClient.RegionHandler.pingerList[i].region.Ping;
					break;
				}
			}
		}
		GGFJGHHHEJC.DOGHANNGJIO();
	}

	public static string ADPHIKKNDNF(int LNFEGPHEJCP)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null || GGFJGHHHEJC.EMIIFKLMJDP == null || GGFJGHHHEJC.EMIIFKLMJDP.Count <= 0)
		{
			return " ";
		}
		return GGFJGHHHEJC.EMIIFKLMJDP[LNFEGPHEJCP];
	}
}
