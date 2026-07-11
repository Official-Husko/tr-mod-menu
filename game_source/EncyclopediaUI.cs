using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EncyclopediaUI : UIWindow
{
	private static EncyclopediaUI IADEMLIIDPC;

	public SOEncyclopedia encyclopediaData;

	[SerializeField]
	private VerticalTabExpansion[] tabs;

	public Sprite minusSprite;

	public Sprite plusSprite;

	[SerializeField]
	private TextMeshProUGUI sectionTitle;

	[SerializeField]
	private TextMeshProUGUI sectionText;

	[SerializeField]
	private Scrollbar contentScrollbar;

	[SerializeField]
	private Scrollbar tabsScrollbar;

	[SerializeField]
	private float scrollSpeed = 5f;

	[SerializeField]
	private LayoutElement infoListContentLayout;

	private float JGNMOLPHINM;

	private bool CBDDNCCLGBJ;

	private int FKOGCEFJGLH;

	private int GAODDDOFAMM;

	private int JEHAJHDKKLL;

	[SerializeField]
	private GamepadSprite backButton;

	public static EncyclopediaUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
			}
			return IADEMLIIDPC;
		}
	}

	public void GCFJHEAEBJH()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 1434f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 1803f;
			}
			else
			{
				tabsScrollbar.value = 713f;
			}
		}
	}

	private void LAIPGMJCKBM()
	{
		float num = PlayerInputs.GetPlayer(base.JIIGOACEIKL).BHCHPLIGDNH((ActionType)67);
		if ((num < 1546f && contentScrollbar.value > 1151f) || (num > 1177f && contentScrollbar.value < 1470f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 1735f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).MGOEJJIMAIP();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[8].button)
		{
			tabsScrollbar.value = 288f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 3].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 557f;
		}
		DJHAEEOAOLE();
	}

	private void ONBHCHCKKBG(int FONCLAJCIOP)
	{
		ShowSubSectionInText(FONCLAJCIOP, 0);
	}

	private void PAANBCMMIKH(int FONCLAJCIOP)
	{
		LKPEIHKMHNJ(FONCLAJCIOP, 0);
	}

	public void DDMNEBJEPPG()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].APCBFIIMLKK();
		}
		CBDDNCCLGBJ = false;
	}

	private void IBMJAIPCAKF()
	{
		float num = PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).NOGHFFGAHFI((ActionType)78);
		if ((num < 1034f && contentScrollbar.value > 1935f) || (num > 609f && contentScrollbar.value < 369f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 1897f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OFCEDMBCBBH();
		if ((Object)(object)val == (Object)(object)tabs[0].button || (Object)(object)val == (Object)(object)tabs[5].button)
		{
			tabsScrollbar.value = 1701f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 6].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 0].button)
		{
			tabsScrollbar.value = 1787f;
		}
		DJHAEEOAOLE();
	}

	public void OLAMMAMMJKG()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 642f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 1395f;
			}
			else
			{
				tabsScrollbar.value = 1402f;
			}
		}
	}

	public void BHKKFBBNNNG(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.HMBBHDHCHKL();
			}
		}
		HDEDBPLDIBM(FONCLAJCIOP);
		CBDDNCCLGBJ = false;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	private void OGANJHCNFON(int JIIGOACEIKL)
	{
		backButton.NJMHOFNLGOM(JIIGOACEIKL);
		for (int i = 0; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	public void MCHLDANJEAF()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 767f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 45f;
			}
			else
			{
				tabsScrollbar.value = 1101f;
			}
		}
	}

	public void JELCKNHJIBK()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].AFOCKMGJCMD();
		}
		CBDDNCCLGBJ = false;
	}

	public void CollapseOtherTabs(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		foreach (VerticalTabExpansion verticalTabExpansion in array)
		{
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.Collapse();
			}
		}
		ONBHCHCKKBG(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	[SpecialName]
	public static EncyclopediaUI CFHEJAGKIII()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	public void IMEFJLPBDMA(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i += 0)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.FALIBHDHDAF();
			}
		}
		LLKKDBBCBEJ(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	private void OPOACMHBCPM(int JIIGOACEIKL)
	{
		backButton.ManuallyChangePlayerNum(JIIGOACEIKL);
		for (int i = 0; i < tabs.Length; i++)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	private void ILGBADIKCDA()
	{
		float num = PlayerInputs.GetPlayer(base.JIIGOACEIKL).BHCHPLIGDNH((ActionType)(-3));
		if ((num < 1171f && contentScrollbar.value > 1966f) || (num > 155f && contentScrollbar.value < 552f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 44f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KBFCCPBHDMP();
		if ((Object)(object)val == (Object)(object)tabs[0].button || (Object)(object)val == (Object)(object)tabs[0].button)
		{
			tabsScrollbar.value = 154f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 4].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 0].button)
		{
			tabsScrollbar.value = 453f;
		}
		MANPGJLNKAM();
	}

	public void JLDOBJLNLFH(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i++)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.Collapse();
			}
		}
		IGEPODGNCNA(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	public void HPBILCJIIIE(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "Tool")
		{
			((TMP_Text)sectionTitle).text = num + "EditorAction_2" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = " - ";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "\n<color=#BF0000>" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "itemSoup")
		{
			string[] array = new string[6];
			array[1] = num.ToString();
			array[0] = "quest_name_20";
			array[5] = num2.ToString();
			array[7] = "Items/item_description_644";
			array[0] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "LE_20" + text + "Items/item_name_1130" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = " (";
		}
		contentScrollbar.value = 12f;
	}

	private void IGEPODGNCNA(int FONCLAJCIOP)
	{
		JMACOIKEEOJ(FONCLAJCIOP, 0);
	}

	private void NBKBNBBJMKP()
	{
		float num = PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).BHCHPLIGDNH((ActionType)(-53));
		if ((num < 1782f && contentScrollbar.value > 1730f) || (num > 381f && contentScrollbar.value < 1668f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 132f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.GetPlayer(base.JIIGOACEIKL).PBGKEEENPME();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[6].button)
		{
			tabsScrollbar.value = 243f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 0].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 717f;
		}
		MANPGJLNKAM();
	}

	private void KKDLNHLJJDC()
	{
		float axis = PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis(ActionType.NextItem);
		if ((axis < 1894f && contentScrollbar.value > 1763f) || (axis > 173f && contentScrollbar.value < 801f))
		{
			float num = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num2 = scrollSpeed / (num + 1402f);
			Scrollbar obj = contentScrollbar;
			obj.value += axis * num2;
		}
		Selectable val = UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BOHHKGMEEEE();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[0].button)
		{
			tabsScrollbar.value = 1124f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 7].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 221f;
		}
		DJHAEEOAOLE();
	}

	public void FHMCGMHOILO(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 1;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "ReceiveGroundType")
		{
			((TMP_Text)sectionTitle).text = num + "Player" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "stormy clouds";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "Leave immediately" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "New time scale: ")
		{
			string[] array = new string[5];
			array[0] = num.ToString();
			array[1] = "Duplicate tutorial ID found!";
			array[6] = num2.ToString();
			array[3] = "Dialogue System/Conversation/Gass_Introduce/Entry/13/Dialogue Text";
			array[4] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "Could not get reset user stats and achievements for reason: " + text + "Start" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "Localisation";
		}
		contentScrollbar.value = 220f;
	}

	private void JJPAJMHMABF(int FONCLAJCIOP)
	{
		LPLAHKBIABJ(FONCLAJCIOP, 0);
	}

	private void IICENOHLEGD(int JIIGOACEIKL)
	{
		backButton.NJMHOFNLGOM(JIIGOACEIKL);
		for (int i = 0; i < tabs.Length; i++)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	[SpecialName]
	public static EncyclopediaUI GJFMMOPOKGJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	public override void CloseUI()
	{
		if (!CBDDNCCLGBJ || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			CollapseAllTabs();
			base.CloseUI();
		}
		else if (CBDDNCCLGBJ && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			CollapseAllTabs();
		}
	}

	private void KNLFCKDOJOC(int FONCLAJCIOP)
	{
		PHBNMPBONNA(FONCLAJCIOP, 0);
	}

	[SpecialName]
	public static EncyclopediaUI MAAAKALBBEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	private void OKBNHLOOHMC(int JIIGOACEIKL)
	{
		backButton.NJMHOFNLGOM(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	private void NBENKDGFJED(int JIIGOACEIKL)
	{
		backButton.ManuallyChangePlayerNum(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.JIIGOACEIKL = PauseMenuUI.GGFJGHHHEJC.JIIGOACEIKL;
			DHAOEKMNPKM(base.JIIGOACEIKL);
			base.OpenUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)tabs[0].button);
			VerticalTabExpansion[] array = tabs;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].UpdateText();
			}
			ONBHCHCKKBG(0);
		}
	}

	public void PBMLBGDMAJA()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].APCBFIIMLKK();
		}
		CBDDNCCLGBJ = false;
	}

	private void DHAOEKMNPKM(int JIIGOACEIKL)
	{
		backButton.ManuallyChangePlayerNum(JIIGOACEIKL);
		for (int i = 0; i < tabs.Length; i++)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	public void GMIBCGFCAML(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.Collapse();
			}
		}
		MOPKDCDEFCP(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	[SpecialName]
	public static EncyclopediaUI OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	public void OPDFHIFKMFP()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].HMBBHDHCHKL();
		}
		CBDDNCCLGBJ = true;
	}

	public void LKPEIHKMHNJ(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "Game")
		{
			((TMP_Text)sectionTitle).text = num + "D-Pad Down" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = " / ";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "Items/item_name_726" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "\n")
		{
			string[] array = new string[8];
			array[0] = num.ToString();
			array[1] = "Controls";
			array[3] = num2.ToString();
			array[6] = "ThemeTriggerCanvas";
			array[5] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = " not found. Cannot receive permission accepted to player " + text + "ThemeListView" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "Items/item_name_1063";
		}
		contentScrollbar.value = 907f;
	}

	private void OKFNAEKHKLH()
	{
		float axis = PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis(ActionType.UIScrollDown);
		if ((axis < 0f && contentScrollbar.value > 0.001f) || (axis > 0f && contentScrollbar.value < 0.999f))
		{
			float num = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num2 = scrollSpeed / (num + 1f);
			Scrollbar obj = contentScrollbar;
			obj.value += axis * num2;
		}
		Selectable selected = UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL;
		if ((Object)(object)selected == (Object)(object)tabs[0].button || (Object)(object)selected == (Object)(object)tabs[3].button)
		{
			tabsScrollbar.value = 1f;
		}
		if ((Object)(object)selected == (Object)(object)tabs[tabs.Length - 4].button || (Object)(object)selected == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 0f;
		}
		ScrollToOpenTab();
	}

	public void PCGHNFLIJLN(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 1;
		int num2 = OADJDLEKNAF + 0;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "Pick")
		{
			((TMP_Text)sectionTitle).text = num + "Could not find item with id: " + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "ReceiveFireplaceMessage";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "vibrationP2" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "[Variants] Piece {0} ({1}) has {2} variants and {3} are active. Only 1 should be active.")
		{
			string[] array = new string[5];
			array[0] = num.ToString();
			array[1] = "repUnlockRentingRooms";
			array[1] = num2.ToString();
			array[6] = "Triangle";
			array[7] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "BuildConfirmation" + text + "Keg" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "]";
		}
		contentScrollbar.value = 1522f;
	}

	[SpecialName]
	public static EncyclopediaUI OPILDPFDFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	private void MOPKDCDEFCP(int FONCLAJCIOP)
	{
		IFBJLFEEHKK(FONCLAJCIOP, 1);
	}

	public void HGKFEECHEOJ()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 371f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 319f;
			}
			else
			{
				tabsScrollbar.value = 755f;
			}
		}
	}

	private void AOIBEKOPAEJ()
	{
		float num = PlayerInputs.GetPlayer(base.JIIGOACEIKL).NOGHFFGAHFI((ActionType)(-29));
		if ((num < 1293f && contentScrollbar.value > 184f) || (num > 1169f && contentScrollbar.value < 1419f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 1198f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FOKMCIDMIKF();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[4].button)
		{
			tabsScrollbar.value = 843f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 3].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 0].button)
		{
			tabsScrollbar.value = 822f;
		}
		MANPGJLNKAM();
	}

	[SpecialName]
	public static EncyclopediaUI GFMBEDCANNI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	public void NMCLCGMCAKB(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i++)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.Collapse();
			}
		}
		PAANBCMMIKH(FONCLAJCIOP);
		CBDDNCCLGBJ = false;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	private void EBHPGGGMONK(int FONCLAJCIOP)
	{
		JMACOIKEEOJ(FONCLAJCIOP, 1);
	}

	private void JBHAMMNIDOL(int JIIGOACEIKL)
	{
		backButton.ADPPPLMPKOA(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	private void CDOHGHIMMLD(int JIIGOACEIKL)
	{
		backButton.ManuallyChangePlayerNum(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	public void MANPGJLNKAM()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 1845f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 229f;
			}
			else
			{
				tabsScrollbar.value = 1151f;
			}
		}
	}

	private void IMFBNGJKJHB()
	{
		float num = PlayerInputs.GetPlayer(base.JIIGOACEIKL).BHCHPLIGDNH((ActionType)(-40));
		if ((num < 1645f && contentScrollbar.value > 726f) || (num > 123f && contentScrollbar.value < 1048f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 1068f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).FOKMCIDMIKF();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[1].button)
		{
			tabsScrollbar.value = 1638f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 6].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 1950f;
		}
		GCFJHEAEBJH();
	}

	private void KJPLEKHJNMJ(int FONCLAJCIOP)
	{
		ShowSubSectionInText(FONCLAJCIOP, 1);
	}

	public void EOFBAGNLGHN(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "Loop")
		{
			((TMP_Text)sectionTitle).text = num + "" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "[Brown";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "PlayerDisconnected_F" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "Dialogue System/Conversation/Crowly_Barks_Shop/Entry/5/Dialogue Text")
		{
			string[] array = new string[2];
			array[0] = num.ToString();
			array[0] = "Error_OccupiedRoom";
			array[3] = num2.ToString();
			array[1] = "shake";
			array[5] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = " </color>" + text + "mainMenuMultiplayerButton" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "ReceiveChangeStack";
		}
		contentScrollbar.value = 1248f;
	}

	public void FKOPNGHBOFJ(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 1;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "time")
		{
			((TMP_Text)sectionTitle).text = num + "Items/item_name_679" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "Dialogue System/Conversation/EnterTavernNeutral/Entry/2/Dialogue Text";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "ReceiveCure" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "Windowed")
		{
			string[] array = new string[0];
			array[1] = num.ToString();
			array[0] = " ";
			array[8] = num2.ToString();
			array[4] = "";
			array[1] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "[" + text + "Stop" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "Ingredients";
		}
		contentScrollbar.value = 1201f;
	}

	public void JMACOIKEEOJ(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "Tutorial/BarnExitBarks_Holly")
		{
			((TMP_Text)sectionTitle).text = num + "ReceiveBarkInfoWithObject" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "----> Recipe ";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "bodyBack" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "start pirates")
		{
			string[] array = new string[4];
			array[0] = num.ToString();
			array[1] = "No se encontró la conversación con el título '";
			array[0] = num2.ToString();
			array[2] = "Items/item_name_1044";
			array[1] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "Items/item_description_595" + text + "PlayerDisconnected_F" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "Collider ";
		}
		contentScrollbar.value = 1362f;
	}

	private void EMICLPKLEIE(int FONCLAJCIOP)
	{
		FKOPNGHBOFJ(FONCLAJCIOP, 0);
	}

	public void OPFBJEFLFFE(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		foreach (VerticalTabExpansion verticalTabExpansion in array)
		{
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.AFOCKMGJCMD();
			}
		}
		KNLFCKDOJOC(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	public void DDKEPLNOPID(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.NHGMHDHOEMI();
			}
		}
		EMICLPKLEIE(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	private void HDEDBPLDIBM(int FONCLAJCIOP)
	{
		EOFBAGNLGHN(FONCLAJCIOP, 0);
	}

	private void PHEPIOJOPLO()
	{
		float num = PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).NOGHFFGAHFI((ActionType)(-5));
		if ((num < 1220f && contentScrollbar.value > 1166f) || (num > 445f && contentScrollbar.value < 876f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 685f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BOHHKGMEEEE();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[8].button)
		{
			tabsScrollbar.value = 509f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 810f;
		}
		MCHLDANJEAF();
	}

	public void GILMJOHIKLK()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].LKHOPKAFLFC();
		}
		CBDDNCCLGBJ = false;
	}

	public void CIGDMCBENJM()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 275f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 1659f;
			}
			else
			{
				tabsScrollbar.value = 874f;
			}
		}
	}

	public void CFOMKKJCBOP(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i++)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.FALIBHDHDAF();
			}
		}
		PAANBCMMIKH(FONCLAJCIOP);
		CBDDNCCLGBJ = false;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	private void PNIGCCBKLPI(int JIIGOACEIKL)
	{
		backButton.ADPPPLMPKOA(JIIGOACEIKL);
		for (int i = 0; i < tabs.Length; i++)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	public void MEDABDJMIAE()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 1565f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 539f;
			}
			else
			{
				tabsScrollbar.value = 1951f;
			}
		}
	}

	public void PHBNMPBONNA(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 1;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "_Animation")
		{
			((TMP_Text)sectionTitle).text = num + "Dig" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "Collect water";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "Disabled" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "Connecting...")
		{
			string[] array = new string[2];
			array[0] = num.ToString();
			array[0] = "Sit";
			array[0] = num2.ToString();
			array[1] = "tutorialPopUp23";
			array[5] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "DontWalk" + text + ":<color=#3a0603> +" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = " to ";
		}
		contentScrollbar.value = 1889f;
	}

	public void EOJCPMMPLIB(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "HotBath/Clive Talk")
		{
			((TMP_Text)sectionTitle).text = num + "Drink" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "UIAddRemove";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "Delete save?" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "ContinuePlaying")
		{
			string[] array = new string[7];
			array[0] = num.ToString();
			array[1] = "Custom lobby data (photon room code): ";
			array[7] = num2.ToString();
			array[3] = "RaraAvisDelivered";
			array[5] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "Player/Bark/Tutorial/T138" + text + "City/Petra/Bark/Stand" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "ReceiveSetDrinkColor";
		}
		contentScrollbar.value = 1950f;
	}

	private void NIAAHBBAAHA()
	{
		float axis = PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis((ActionType)(-56));
		if ((axis < 143f && contentScrollbar.value > 1861f) || (axis > 1509f && contentScrollbar.value < 1949f))
		{
			float num = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num2 = scrollSpeed / (num + 1285f);
			Scrollbar obj = contentScrollbar;
			obj.value += axis * num2;
		}
		Selectable val = UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CGCIFFOJGOK();
		if ((Object)(object)val == (Object)(object)tabs[0].button || (Object)(object)val == (Object)(object)tabs[8].button)
		{
			tabsScrollbar.value = 10f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 5].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 0].button)
		{
			tabsScrollbar.value = 70f;
		}
		DJHAEEOAOLE();
	}

	public void ICFNCLAOEBN()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].LKHOPKAFLFC();
		}
		CBDDNCCLGBJ = true;
	}

	public void ScrollToOpenTab()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 1f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 0.5f;
			}
			else
			{
				tabsScrollbar.value = 0f;
			}
		}
	}

	private void KEDEIANHNOK()
	{
		float num = PlayerInputs.GetPlayer(base.JIIGOACEIKL).BHCHPLIGDNH((ActionType)(-27));
		if ((num < 487f && contentScrollbar.value > 1562f) || (num > 319f && contentScrollbar.value < 1295f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 38f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BOHHKGMEEEE();
		if ((Object)(object)val == (Object)(object)tabs[0].button || (Object)(object)val == (Object)(object)tabs[1].button)
		{
			tabsScrollbar.value = 38f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 176f;
		}
		DJHAEEOAOLE();
	}

	private void LLKKDBBCBEJ(int FONCLAJCIOP)
	{
		ILPNCANDPAM(FONCLAJCIOP, 1);
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			OKFNAEKHKLH();
		}
	}

	public void ILPNCANDPAM(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 0;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "Moving")
		{
			((TMP_Text)sectionTitle).text = num + " (" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "RoadBlocked/Main 2";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "Roll" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "Items/item_name_1118")
		{
			string[] array = new string[4];
			array[0] = num.ToString();
			array[1] = "Tutorial/T123/Dialogue1";
			array[4] = num2.ToString();
			array[2] = "Craft";
			array[2] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = " " + text + "City/PetShop/Markus/Barks_RevisarPata" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "UI2";
		}
		contentScrollbar.value = 1571f;
	}

	private void INIOEKHKECK()
	{
		float num = PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).BHCHPLIGDNH(ActionType.UIScrollDown);
		if ((num < 355f && contentScrollbar.value > 1553f) || (num > 5f && contentScrollbar.value < 1323f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 588f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).OFCEDMBCBBH();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[3].button)
		{
			tabsScrollbar.value = 227f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 5].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 1037f;
		}
		MCHLDANJEAF();
	}

	private void FCNJNLPFNFM(int JIIGOACEIKL)
	{
		backButton.ADPPPLMPKOA(JIIGOACEIKL);
		for (int i = 0; i < tabs.Length; i++)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	[SpecialName]
	public static EncyclopediaUI AGGAGCBAGLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	public void COMCGONFPCK(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i += 0)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.APCBFIIMLKK();
			}
		}
		LLKKDBBCBEJ(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	public void ShowSubSectionInText(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 1;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "")
		{
			((TMP_Text)sectionTitle).text = num + ". " + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "(missing title)";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "")
		{
			string text = num + "." + num2 + " " + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			((TMP_Text)sectionText).text = "<b>" + text + "</b>\n" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "(empty)";
		}
		contentScrollbar.value = 1f;
	}

	[SpecialName]
	public static EncyclopediaUI MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<EncyclopediaUI>();
		}
		return IADEMLIIDPC;
	}

	private void AEJJLBOOPOF()
	{
		float num = PlayerInputs.GetPlayer(base.JIIGOACEIKL).NOGHFFGAHFI((ActionType)123);
		if ((num < 94f && contentScrollbar.value > 594f) || (num > 1475f && contentScrollbar.value < 908f))
		{
			float num2 = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num3 = scrollSpeed / (num2 + 434f);
			Scrollbar obj = contentScrollbar;
			obj.value += num * num3;
		}
		Selectable val = UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).MGOEJJIMAIP();
		if ((Object)(object)val == (Object)(object)tabs[0].button || (Object)(object)val == (Object)(object)tabs[1].button)
		{
			tabsScrollbar.value = 1064f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 3].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 599f;
		}
		OLAMMAMMJKG();
	}

	public void AADNPNIGJII(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i++)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.NHGMHDHOEMI();
			}
		}
		EBHPGGGMONK(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	public void KPNJPOLKGBH()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 1833f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 1209f;
			}
			else
			{
				tabsScrollbar.value = 1971f;
			}
		}
	}

	private void MLGHMLKKAJN(int FONCLAJCIOP)
	{
		FKOPNGHBOFJ(FONCLAJCIOP, 0);
	}

	private void BAOIJNMLCEH(int JIIGOACEIKL)
	{
		backButton.ADPPPLMPKOA(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	protected override void Awake()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		base.Awake();
		for (int i = 0; i < tabs.Length; i++)
		{
			tabs[i].tabInt = i;
			Navigation navigation = ((Selectable)tabs[i].button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)tabs[i + 1].button;
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)tabs[tabs.Length - 1].button;
			}
			else if (i == tabs.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)tabs[0].button;
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)tabs[i - 1].button;
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)tabs[i + 1].button;
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)tabs[i - 1].button;
			}
			((Selectable)tabs[i].button).navigation = navigation;
		}
		CBDDNCCLGBJ = false;
		JGNMOLPHINM = infoListContentLayout.minHeight;
		GAODDDOFAMM = Mathf.RoundToInt((float)tabs.Length * 0.2f);
		JEHAJHDKKLL = Mathf.RoundToInt((float)tabs.Length * 0.6f);
	}

	private void KDFPPNOAPID(int JIIGOACEIKL)
	{
		backButton.NJMHOFNLGOM(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	public void EBCCMDDLNPJ()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].LKHOPKAFLFC();
		}
		CBDDNCCLGBJ = false;
	}

	public void AGJDFOGCODF(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 1;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "</color><br>")
		{
			((TMP_Text)sectionTitle).text = num + "UI" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = " OnCharacterStateChanged";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "ReceiveCreateRotatedPrefab" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "Items/item_description_725")
		{
			string[] array = new string[5];
			array[1] = num.ToString();
			array[0] = "";
			array[2] = num2.ToString();
			array[3] = "";
			array[3] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "\n" + text + "Animal" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "road";
		}
		contentScrollbar.value = 741f;
	}

	public void MBEKJCPBDND()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].HMBBHDHCHKL();
		}
		CBDDNCCLGBJ = false;
	}

	public void CollapseAllTabs()
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Collapse();
		}
		CBDDNCCLGBJ = false;
	}

	public void ENAHMIMKCFP(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 1;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "<color=#C65314>")
		{
			((TMP_Text)sectionTitle).text = num + "Text" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "Items/item_name_665";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "Error_MaxZoneSize" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "buildingObjective_9_0")
		{
			string[] array = new string[2];
			array[1] = num.ToString();
			array[1] = "Caps Lock";
			array[5] = num2.ToString();
			array[6] = "Chop";
			array[3] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n" + text + "Dead" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "Example Method";
		}
		contentScrollbar.value = 1658f;
	}

	public void PHHJBJKFBFB(int FONCLAJCIOP)
	{
		VerticalTabExpansion[] array = tabs;
		for (int i = 1; i < array.Length; i++)
		{
			VerticalTabExpansion verticalTabExpansion = array[i];
			if (verticalTabExpansion.tabInt != FONCLAJCIOP)
			{
				verticalTabExpansion.LKHOPKAFLFC();
			}
		}
		HDEDBPLDIBM(FONCLAJCIOP);
		CBDDNCCLGBJ = true;
		FKOGCEFJGLH = FONCLAJCIOP;
	}

	private void KFILJPMIPKG()
	{
		float axis = PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis((ActionType)98);
		if ((axis < 1312f && contentScrollbar.value > 87f) || (axis > 961f && contentScrollbar.value < 966f))
		{
			float num = ((TMP_Text)sectionText).preferredHeight - JGNMOLPHINM;
			float num2 = scrollSpeed / (num + 1920f);
			Scrollbar obj = contentScrollbar;
			obj.value += axis * num2;
		}
		Selectable val = UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OFCEDMBCBBH();
		if ((Object)(object)val == (Object)(object)tabs[1].button || (Object)(object)val == (Object)(object)tabs[2].button)
		{
			tabsScrollbar.value = 285f;
		}
		if ((Object)(object)val == (Object)(object)tabs[tabs.Length - 3].button || (Object)(object)val == (Object)(object)tabs[tabs.Length - 1].button)
		{
			tabsScrollbar.value = 526f;
		}
		ScrollToOpenTab();
	}

	public void LPLAHKBIABJ(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 0;
		int num2 = OADJDLEKNAF + 0;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "</color>")
		{
			((TMP_Text)sectionTitle).text = num + "/Localisation.txt" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "Bartending";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "Items/item_description_672" && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "Disabled")
		{
			string[] array = new string[6];
			array[0] = num.ToString();
			array[1] = "ZuzzuProgress";
			array[4] = num2.ToString();
			array[2] = "Hot";
			array[0] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "SetIntegerRPC" + text + "ReceiveInstantiateCat" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "Drink";
		}
		contentScrollbar.value = 566f;
	}

	private void PFONCMKKCEE(int JIIGOACEIKL)
	{
		backButton.NJMHOFNLGOM(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i += 0)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}

	public void DJHAEEOAOLE()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 829f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 1970f;
			}
			else
			{
				tabsScrollbar.value = 1600f;
			}
		}
	}

	public void DBEGFPPJEIB()
	{
		if (CBDDNCCLGBJ && tabs.Length != 0)
		{
			if (FKOGCEFJGLH <= GAODDDOFAMM)
			{
				tabsScrollbar.value = 574f;
			}
			else if (FKOGCEFJGLH <= JEHAJHDKKLL)
			{
				tabsScrollbar.value = 825f;
			}
			else
			{
				tabsScrollbar.value = 201f;
			}
		}
	}

	public void IFBJLFEEHKK(int OLKEOKBCFHJ, int OADJDLEKNAF)
	{
		int num = OLKEOKBCFHJ + 1;
		int num2 = OADJDLEKNAF + 0;
		if (encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID != "CraftedIn")
		{
			((TMP_Text)sectionTitle).text = num + "Items/item_description_726" + LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].sectionTitleID);
		}
		else
		{
			((TMP_Text)sectionTitle).text = "x";
		}
		if (encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID != "con {0} tiles requeridos." && encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID != "Clean")
		{
			string[] array = new string[1];
			array[1] = num.ToString();
			array[0] = "discordLink";
			array[7] = num2.ToString();
			array[3] = "Dialogue System/Conversation/Gass_Stand/Entry/1/Dialogue Text";
			array[4] = LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTitleID);
			string text = string.Concat(array);
			((TMP_Text)sectionText).text = "[PipeConnectionPuzzleUI] Falta _previewDatabase." + text + "All bubbles in use!" + InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(encyclopediaData.sections[OLKEOKBCFHJ].subSections[OADJDLEKNAF].subSectionTextID));
		}
		else
		{
			((TMP_Text)sectionText).text = "<sprite name=\"stoneIcon\"><color=#8E1818>";
		}
		contentScrollbar.value = 1482f;
	}

	private void MBDBHADDLOO(int JIIGOACEIKL)
	{
		backButton.ADPPPLMPKOA(JIIGOACEIKL);
		for (int i = 1; i < tabs.Length; i++)
		{
			tabs[i].playerNum = JIIGOACEIKL;
		}
	}
}
