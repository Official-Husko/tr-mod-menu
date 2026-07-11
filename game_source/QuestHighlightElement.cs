using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestHighlightElement : FadingWindow
{
	[HideInInspector]
	public ActiveQuest activeQuest;

	[SerializeField]
	private TextMeshProUGUI textMesh;

	[SerializeField]
	private EmphasizeObject emphasizeObject;

	private RectTransform HMDFBECLNFM;

	private bool GFNKNJLAJMD;

	public void EPGKDKJEGKA(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 714f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void AFGKNBBCKCC(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-29)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-25)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Statue2={0}") + "Localisation" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("/Female/");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "Open" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + ")";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1778f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.DOFHMOCEHKH(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}

	public void NBFPFHLCOMP(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 582f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void OKGDAKCEIFN(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[0];
		array[1] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[0] = "Items/item_description_726";
		array[8] = MMNIKLCMBAI.currentAmount.ToString();
		array[4] = "Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/1/Dialogue Text";
		array[1] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[2] = "LE_9";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.JIGJHGIKOAG();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1967f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void CLJBOFODGDM(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 356f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void CMFMBLNHNHI(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[8];
		array[0] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[0] = "Dialogue System/Conversation/Gass_Quest/Entry/45/Dialogue Text";
		array[6] = MMNIKLCMBAI.currentAmount.ToString();
		array[5] = "LucenThrow";
		array[1] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[4] = "No puzzle type found!";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.JJBICEGDGPH();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 716f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void ALPIFDNBHOL(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)76) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.UINextPage));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("ReceiveInstantiateDog") + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/19/Dialogue Text" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "LE_10" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("talentGreens"), text) + "Collect";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 389f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void FFIMPAEIABH(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)109) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)81));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("OpenConsole") + "ErrorWhileSaving" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("</color></b>");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "ObjectHorizontalMove" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "LE_17";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1335f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: true);
		GFNKNJLAJMD = true;
	}

	public void KPHGEFAKPMO(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1649f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void ABCLGCMFMLN(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-68)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)83));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("add item ") + "\n<color=#BF0000>" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get(" ");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "Dialogue System/Conversation/Crowly_Standar/Entry/24/Dialogue Text" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "ChatWelcomeToTavern";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1187f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GBBOMOIEBLJ(AODONKKHPBP: true);
		GFNKNJLAJMD = true;
	}

	public void DPNELLONOJJ(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.ScrollUp) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-56)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Social") + "LearnMettle" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Tutorial/T130/Dialogue1" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("{"), text) + "Player";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1272f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.OACEKDBNFBI(AODONKKHPBP: true);
		GFNKNJLAJMD = true;
	}

	public void INEPEHMHIBC(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[1];
		array[0] = MMNIKLCMBAI.quest.IABAKHPEOAF();
		array[1] = "Controller";
		array[3] = MMNIKLCMBAI.currentAmount.ToString();
		array[6] = "Items/item_name_1089";
		array[4] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[3] = "ReceivePipePuzzle";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.NOKLCKECFIN();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1916f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void AACJMLMJFEG(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)94) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.Hold));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Get Components ") + "Dialogue System/Conversation/NeutralInTavern/Entry/1/Dialogue Text" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("UISelectGamepad");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 228f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GBBOMOIEBLJ(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}

	public void MAHEPMGNFKK(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-51)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-68)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("City/Bruce/Bark/Stand") + "before pos " + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("Player/Bark/Tutorial/AgingBarrelBlock");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Customer ";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1257f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void FJNBMBPBELE(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[0];
		array[0] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[1] = "\n";
		array[8] = MMNIKLCMBAI.currentAmount.ToString();
		array[8] = "LearnMettle";
		array[8] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[2] = "CraftedIn";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.NDBEIJIFDNI();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1748f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void LHFKJFLJNKJ(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[8];
		array[0] = MMNIKLCMBAI.quest.PBIJDIHJIHK();
		array[0] = "Run";
		array[2] = MMNIKLCMBAI.currentAmount.ToString();
		array[1] = "NPCWalkTo is null in NPCRoutine. Make sure the routine ";
		array[0] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[8] = "NeutralInTavern";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.CHLGCNCACIE();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 261f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void GILBLCFNIKO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[3];
		array[1] = MMNIKLCMBAI.quest.FOAPHHKOAEE();
		array[0] = "Disconnected";
		array[8] = MMNIKLCMBAI.currentAmount.ToString();
		array[6] = "Move Down";
		array[2] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[7] = "quest_name_28";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.MGFJGPPHLMJ();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1771f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void ENJCFNFIIMM(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[5];
		array[1] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[0] = "bathhouseinterior";
		array[4] = MMNIKLCMBAI.currentAmount.ToString();
		array[1] = "cameraZoom2";
		array[8] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[7] = "itemOldDoormat";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.CHLGCNCACIE();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 822f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void APGFMJPHHDH(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[2];
		array[0] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[0] = "Entra a dar Mision";
		array[4] = MMNIKLCMBAI.currentAmount.ToString();
		array[6] = "Occupied Positions";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[3] = "OnConversationStarted ";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.IDLGKJAAAHP();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1551f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void FAKELPJCACN(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1939f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void EENOHLJIGKK(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1817f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void OGFAKPCMOHK(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.WASD) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)124));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Wall") + "Side" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "F2" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" : 00"), text) + "Items/item_name_1107";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1421f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: false);
		GFNKNJLAJMD = true;
	}

	public void JLCEMHMPPPG(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[8];
		array[1] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[1] = "ReceiveEmployeeWorkingMaster";
		array[6] = MMNIKLCMBAI.currentAmount.ToString();
		array[4] = "Waiting for scene {0} load on client. Current state: {1}";
		array[1] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[5] = "Remove";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.IDLGKJAAAHP();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1893f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	protected override void Awake()
	{
		base.Awake();
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void UpdateInfo(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		((TMP_Text)textMesh).text = MMNIKLCMBAI.quest.IABAKHPEOAF() + " (" + MMNIKLCMBAI.currentAmount + "/" + MMNIKLCMBAI.quest.requiredAmount + ")";
		if (IsOpen())
		{
			emphasizeObject.StartEmphasize();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 35f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void OICHKNLGOKP(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1131f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void COKOMEOBGIC(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[1];
		array[0] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[1] = "Scene";
		array[1] = MMNIKLCMBAI.currentAmount.ToString();
		array[2] = "Sit";
		array[1] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[6] = "Items/item_description_700";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.BEBIDMBMCDO();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1031f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void DOLDFLLKEHJ(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1722f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void ShowNewQuestAvailable(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.OpenQuests) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.OpenInventory));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("NewQuestAvailable") + "\n" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + " (" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("QuestInfoButton"), text) + ")";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 54f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = true;
		GFNKNJLAJMD = true;
	}

	public void CMMDBGEEEDN(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1212f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void KGDLEELKGEB(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[6];
		array[1] = MMNIKLCMBAI.quest.FOAPHHKOAEE();
		array[0] = "Idle";
		array[8] = MMNIKLCMBAI.currentAmount.ToString();
		array[4] = " to chest";
		array[2] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[3] = "TutorialPhase";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.ANJEKHNMNHB();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 890f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void LGIAIDOJHEH(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 558f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void LBJKBMGMOKH(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[3];
		array[1] = MMNIKLCMBAI.quest.PBIJDIHJIHK();
		array[0] = "Rich presence ";
		array[3] = MMNIKLCMBAI.currentAmount.ToString();
		array[0] = "DiningRoomTiles";
		array[0] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[3] = "Player/Bark/OathFeastBlock";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.NOKLCKECFIN();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 173f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void DMOGKFFDOLB(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-55)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-6)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Key1") + "Attack/MainEvent 9" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("EXTRA ZONES: ");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "[HierarchyPrinter] ❌ Error al escribir el fichero: " + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/8/Dialogue Text";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 34f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = true;
		GFNKNJLAJMD = true;
	}

	public void ELLPIGEHAFH(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[3];
		array[0] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[0] = "";
		array[1] = MMNIKLCMBAI.currentAmount.ToString();
		array[3] = "Tutorial/T127/Dialogue2";
		array[0] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[0] = "0";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.DCLOHJBMBPP();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1193f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void OMDBOEAJLGA(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.OpenXPModifiers) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-117)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("\n") + "TermasInterior/Kenta/Stand" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("itemFirePlace");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "City/Bruce/Bark/Stand" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Resume";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1621f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void MLLIKCKMHOO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[5];
		array[1] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[0] = "Idle";
		array[6] = MMNIKLCMBAI.currentAmount.ToString();
		array[4] = "Far";
		array[8] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[0] = "ScrollDown";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.FAJNKMFAFOP();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 213f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void HKKOKBMHLEJ(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)100) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)65));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("itemWheatBread") + "/BarkMai" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("sprintToggle");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "Sleep" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "\" unlocked";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 806f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = true;
		GFNKNJLAJMD = false;
	}

	public void DHOAFNNIBNK(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1524f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void KADOMALMOFL(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[2];
		array[1] = MMNIKLCMBAI.quest.PBIJDIHJIHK();
		array[0] = "";
		array[7] = MMNIKLCMBAI.currentAmount.ToString();
		array[5] = " - ";
		array[2] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[8] = "itemShrimp";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.MGFJGPPHLMJ();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 69f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void IIJBELEKIEP(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[5];
		array[0] = MMNIKLCMBAI.quest.FOAPHHKOAEE();
		array[1] = "Giving extra argamasa";
		array[5] = MMNIKLCMBAI.currentAmount.ToString();
		array[3] = "Items/item_description_1091";
		array[5] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[3] = "questNameCraftingRoom";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.CDOJIFFDMNP();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 981f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void HAIAKBAPNLD(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)96) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)55));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Wing") + "Error_TableNeedsFreeSpace" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("\nCode not found\n");
			string[] array = new string[0];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "Held Item is a drink in " + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + " (-";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1293f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = true;
		GFNKNJLAJMD = false;
	}

	public void GHLFDNGIGBB(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-53)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-83)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Feed") + "ReceivePlayerInteractingMinigame" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("KickedSpinDirection");
			string[] array = new string[0];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/29/Dialogue Text" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "popUpBuilding14";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1421f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: true);
		GFNKNJLAJMD = true;
	}

	public void ABPDJJNGOGL(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[8];
		array[0] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[0] = "ReceiveLastOrder";
		array[4] = MMNIKLCMBAI.currentAmount.ToString();
		array[5] = "BeardShadow";
		array[5] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[3] = "Bounce";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.CDOJIFFDMNP();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 650f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public override void CloseUI()
	{
		base.CloseUI();
		activeQuest = null;
		if (GFNKNJLAJMD)
		{
			QuestHighlightUI.GLBMEBHHJOI = false;
			GFNKNJLAJMD = false;
		}
		ItemsCollectedUI.ElementClosed(base.JIIGOACEIKL);
	}

	public void OMGGNKNBHNA(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[3];
		array[1] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[1] = "Open";
		array[3] = MMNIKLCMBAI.currentAmount.ToString();
		array[5] = " : ";
		array[1] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[8] = "Items/item_name_1148";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.JIGJHGIKOAG();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 186f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void ShowText(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 35f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void LFLHCMHPMGA(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[6];
		array[0] = MMNIKLCMBAI.quest.FOAPHHKOAEE();
		array[0] = "Items/item_name_593";
		array[2] = MMNIKLCMBAI.currentAmount.ToString();
		array[4] = "SFX";
		array[4] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[5] = "ReceivInstantiateMiscellaneousHarvest";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.NOKLCKECFIN();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1380f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void PPNGJKCPKEC(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[3];
		array[0] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[1] = "Direction";
		array[5] = MMNIKLCMBAI.currentAmount.ToString();
		array[3] = " (";
		array[5] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[6] = " could not be removed because it does not exist";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.StartEmphasize();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1970f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void OGBAHGMGCPC(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1069f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void MFEPPINCOBF(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[6];
		array[0] = MMNIKLCMBAI.quest.PBIJDIHJIHK();
		array[0] = "BathhouseEntrace/Main";
		array[6] = MMNIKLCMBAI.currentAmount.ToString();
		array[2] = "Trying to set a player's steam name but they're not playing on a steam platform";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[4] = "[^0-9]";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.CDOJIFFDMNP();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 950f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void INABELOGDOJ(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1276f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void LGGELJIJHGO(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)117) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-63)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("UI") + "Direction" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("DecorationTile_8");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "Disabled" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Hikari/Stand";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1968f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GPKHNJACJAK(AODONKKHPBP: true);
		GFNKNJLAJMD = true;
	}

	public void JFKBKBCFMCH(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1376f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void CGPNDFJIADE(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[5];
		array[1] = MMNIKLCMBAI.quest.IABAKHPEOAF();
		array[1] = "";
		array[1] = MMNIKLCMBAI.currentAmount.ToString();
		array[0] = "/";
		array[1] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[5] = "Pickles to Encurtidos en Vinagre (Pepino)";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.CHLGCNCACIE();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 398f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void PLPLHKNCLNL(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 431f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void LHGDPPDNKKN(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 94f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void BIGOOGPPGAF(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 114f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void OONLDHLEHFI(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 836f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void IBOGBCCAOKD(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.ScrollUp) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-6)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("UI") + "end dialogue" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Moving" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_description_"), text) + "Disappear";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1461f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.OACEKDBNFBI(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}

	public void CHMAEKMIBDJ(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-47)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)64));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Trends of week ") + "NewGameSetup" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("there are {0} keys and {1} values after deserialization. Make sure that both key and value types are serializable.");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "BarIdle" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Name...";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 587f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GPKHNJACJAK(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void KJOCFOFFLEJ(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[4];
		array[0] = MMNIKLCMBAI.quest.IABAKHPEOAF();
		array[0] = "Empieza a construir";
		array[5] = MMNIKLCMBAI.currentAmount.ToString();
		array[6] = "ReceiveMinigameState";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[1] = "BirdInteract";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.NDBEIJIFDNI();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 879f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void KKCOHCNIBLM(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-11)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-70)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("OnCustomerEnter") + "Events" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("StartEvent can only be called in play mode.");
			string[] array = new string[0];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "HotBath/Rochelle Talk" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Enter";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 718f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.DHBDOHOPEED(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}

	public void HAMKMOKEAFD(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-126)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)81));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Speed") + ", " + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "\n" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("holesDug"), text) + "Float {0} changed to {1} on {2}'s animator. Sending RPC.";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1930f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = false;
		GFNKNJLAJMD = false;
	}

	public void ICKAMMJJGNJ(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-119)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-102)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("ValueName") + "Run" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("low");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "LevelAbbreviation" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Tail";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 635f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}

	public void PDJHKHHAMDJ(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1823f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void ABKABADAFMH(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 617f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void EOHKKIJGDHC(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.Interact) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-25)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("LE_13") + ".gz" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("UIAddRemove");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "PHOTON_ROOM_CODE" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "itemBottle";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 991f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = false;
		GFNKNJLAJMD = false;
	}

	public void EGJPHFLPEOO(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 254f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void CLBINAIBHLI(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-12)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)116));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("FloorTiles") + "Cheddar" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("RightMouseDetect");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "MineShopDatabase: No config found for level " + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/11/Dialogue Text";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1399f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GPKHNJACJAK(AODONKKHPBP: true);
		GFNKNJLAJMD = true;
	}

	public void DFBLKHCPIAG(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[3];
		array[1] = MMNIKLCMBAI.quest.IABAKHPEOAF();
		array[0] = "controllers";
		array[6] = MMNIKLCMBAI.currentAmount.ToString();
		array[4] = "Items/item_name_1143";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[1] = "MaximumReached";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.IDLGKJAAAHP();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1905f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void BLDJDDOGKMN(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[3];
		array[0] = MMNIKLCMBAI.quest.PBIJDIHJIHK();
		array[1] = "Shield";
		array[3] = MMNIKLCMBAI.currentAmount.ToString();
		array[1] = " at ";
		array[1] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[1] = "SortByType";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.IDLGKJAAAHP();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1599f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void BOFOCAPFCCC(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)102) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)71));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("LE_11") + "fishing" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + " : 00" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("["), text) + "TavernManager instance is null, cannot add open tavern blocker.";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 82f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void BAHJBAALJJM(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1980f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void IOJJOFAPGGJ(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)53) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-32)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("BeginFishCuttingMinigameRequest") + "Force" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("Clave pública RSA (XML):");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "Default" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Error: could not find player with name ";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1981f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GBBOMOIEBLJ(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void MHMPMKFFLJL(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[5];
		array[0] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[0] = "Nature";
		array[3] = MMNIKLCMBAI.currentAmount.ToString();
		array[5] = "Perks/playerPerk_description_";
		array[0] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[8] = "MainProgress";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.FAJNKMFAFOP();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1877f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void CMHAOFGFFNC(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-112)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-112)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("MainProgress") + "Enter" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveOfferingItemPlaced");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + " seconds." + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "Options";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1064f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = false;
		GFNKNJLAJMD = true;
	}

	public void CJIFDGBEPPB(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[8];
		array[0] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[1] = "UIAddRemove";
		array[5] = MMNIKLCMBAI.currentAmount.ToString();
		array[3] = "Cannot place mine block piece at ";
		array[5] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[2] = "Staff";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.CIJDOKKMFBB();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1390f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void EHIMPKMEKHO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[5];
		array[1] = MMNIKLCMBAI.quest.PBIJDIHJIHK();
		array[0] = "No content to disable in this NPC!";
		array[4] = MMNIKLCMBAI.currentAmount.ToString();
		array[6] = "<sprite name=white_arrow_right> ";
		array[0] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[5] = "ErrorCreateDefault";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.CHLGCNCACIE();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1921f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void KGFFABGOCHE(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-54)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.Right));
		((TMP_Text)textMesh).text = LocalisationSystem.Get(" ") + "ReceiveTrends" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Food" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" / "), text) + "HalloweenEvent";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1356f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = false;
		GFNKNJLAJMD = true;
	}

	public void BDMPCAIDBHB(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1741f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void PFKKFBPOJJF(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-105)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-1)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Perks/playerPerk_description_") + "Player Bed with actor number {0} is already in the dictionary." + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("Cof");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "Invalid NPC photonID: {0} for NPCRoutine." + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 592f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.DHBDOHOPEED(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}

	public void LCFHODJJKGO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[4];
		array[0] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[0] = "Disappear";
		array[2] = MMNIKLCMBAI.currentAmount.ToString();
		array[6] = "[SinglePlayer=";
		array[0] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[6] = "";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.JIGJHGIKOAG();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1348f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void OJEPPKBMCPO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[7];
		array[0] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[1] = "On";
		array[4] = MMNIKLCMBAI.currentAmount.ToString();
		array[8] = "RequestNPCPositionAndParent";
		array[2] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[1] = "NoEresDigno/EndEvent2";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.MHCEGNGILBD();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 73f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void CPKJMEBJGFH(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1432f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void DNNHLFAFHEM(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-85)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-50)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("???") + "Mooruroa" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_description_632");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "LE_10" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "ReceiveFoodRequestAsDrink";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1559f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: false);
		GFNKNJLAJMD = true;
	}

	public void NGNPOJDKFLP(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[7];
		array[0] = MMNIKLCMBAI.quest.IABAKHPEOAF();
		array[0] = "remaining ms: ";
		array[5] = MMNIKLCMBAI.currentAmount.ToString();
		array[6] = "Normal";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[5] = "UI";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.NOKLCKECFIN();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 577f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void IMCNOKBMHAE(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1741f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void GNDPNHIMCLP(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 564f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void KCAFBENKJJN(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)60) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-12)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Not found ingredients for trends ") + "CliveProgress" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("StopMusic/ButtonImmediately");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "christmasActivated" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "PirateMinigame/Win";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 236f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GPKHNJACJAK(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}

	public void FHAJDOOPLLL(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[8];
		array[0] = MMNIKLCMBAI.quest.HKDMHHCCMJC();
		array[0] = "Inventory";
		array[4] = MMNIKLCMBAI.currentAmount.ToString();
		array[0] = "Player2";
		array[7] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[0] = "Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/11/Dialogue Text";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.CIJDOKKMFBB();
		}
		OpenUI();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1964f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void IPFCPOGFOFO(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)70) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-86)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Can't find seat. Reason: DiningRoom") + "Resolucion nativa: " + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get(" door: ");
			string[] array = new string[0];
			array[1] = text;
			((TMP_Text)obj).text = text2 + "Sleepy" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + " not found. Cannot receive permission accepted to player ";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 654f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GPKHNJACJAK(AODONKKHPBP: true);
		GFNKNJLAJMD = true;
	}

	public void KMFLDFEJCEP(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-21)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)76));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("UIPreviousCategory") + "Serve" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("Occupied Positions");
			string[] array = new string[0];
			array[0] = text;
			((TMP_Text)obj).text = text2 + "Misc" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + ".gz";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 11f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.DOFHMOCEHKH(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void EBDAJKMGIOG(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1721f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void KPBLJLEFIFE(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1152f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void GJFBILHHNCO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[8];
		array[0] = MMNIKLCMBAI.quest.ONFNOJBBPOO();
		array[1] = " - ";
		array[7] = MMNIKLCMBAI.currentAmount.ToString();
		array[3] = "[^0-9]";
		array[8] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[1] = "OnConversationStarted MothersRecipe Event ";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.MGFJGPPHLMJ();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 866f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void FNAHONIGGGC(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[4];
		array[1] = MMNIKLCMBAI.quest.FOAPHHKOAEE();
		array[1] = "";
		array[8] = MMNIKLCMBAI.currentAmount.ToString();
		array[8] = "Use";
		array[5] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[4] = "AllTimeStats";
		((TMP_Text)obj).text = string.Concat(array);
		if (HDEPMJIDJEM())
		{
			emphasizeObject.CIJDOKKMFBB();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1528f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void EOEEPPLPFFM(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 93f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void AFDPJPHDLJO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		base.JIIGOACEIKL = JIIGOACEIKL;
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[2];
		array[0] = MMNIKLCMBAI.quest.IABAKHPEOAF();
		array[1] = "==============================";
		array[0] = MMNIKLCMBAI.currentAmount.ToString();
		array[3] = "";
		array[3] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[5] = "PirateMinigame/Minigame2";
		((TMP_Text)obj).text = string.Concat(array);
		if (BGLJFMHCFJF())
		{
			emphasizeObject.BEBIDMBMCDO();
		}
		EDHEIFHAAKO();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1270f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void OIOHNKBKGLM(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		OAJBEPDCHIP(JIIGOACEIKL);
		activeQuest = MMNIKLCMBAI;
		TextMeshProUGUI obj = textMesh;
		string[] array = new string[5];
		array[0] = MMNIKLCMBAI.quest.PBIJDIHJIHK();
		array[1] = "add item 1447 20";
		array[8] = MMNIKLCMBAI.currentAmount.ToString();
		array[1] = "MissionsDatabaseAccessor instance is null. Make sure it is initialized before calling this method.";
		array[2] = MMNIKLCMBAI.quest.requiredAmount.ToString();
		array[1] = "talent_name_117";
		((TMP_Text)obj).text = string.Concat(array);
		if (IsOpen())
		{
			emphasizeObject.LGDOLOGPDDK();
		}
		IDLAGJNLPJL();
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 729f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void HBJKNDJMMBL(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		OpenUI();
		string text = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)82) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)93));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("UnNuevoMaestro/HikariTalk") + "/" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + " to disconnect from the game" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "itemLargeRock";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 574f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.OACEKDBNFBI(AODONKKHPBP: true);
		GFNKNJLAJMD = false;
	}

	public void INOKDABABPA(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-23)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)99));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("UIPreviousCategory") + "Right Stick Right" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "UIAddRemove" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Actor Number "), text) + "LE_10";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 971f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = true;
		GFNKNJLAJMD = false;
	}

	public void GONIAFDJOLB(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-55)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-114)));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Veggie") + " " + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			string text2 = ((TMP_Text)obj).text;
			string cAEDMEDBEGI = LocalisationSystem.Get("OnlinePlayer");
			string[] array = new string[1];
			array[1] = text;
			((TMP_Text)obj).text = text2 + " " + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array) + "%>";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 471f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = true;
		GFNKNJLAJMD = false;
	}

	public void HCPPBHAENKM(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)118) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)73));
		((TMP_Text)textMesh).text = LocalisationSystem.Get(" with id ") + "HorizontalMove" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + ".png" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ValuePsaiState"), text) + "Item ";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1525f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.MKHLLOGIAAH(AODONKKHPBP: false);
		GFNKNJLAJMD = true;
	}

	public void GNPGLOOOECB(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 906f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = true;
	}

	public void ELOKKBLBAOL(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-49)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.UIInteract));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("ReceiveOfferingItemPlaced") + "Direction" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "Disabled" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("BirdPositiveComments"), text) + "Collect water";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 856f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GLBMEBHHJOI = true;
		GFNKNJLAJMD = true;
	}

	public void GMAOBEFAGHB(int JIIGOACEIKL, string CAEDMEDBEGI)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		IDLAGJNLPJL();
		((TMP_Text)textMesh).text = CAEDMEDBEGI;
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1977f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		GFNKNJLAJMD = false;
	}

	public void AEGCOHMFIGM(int JIIGOACEIKL, string KBCHEGCDELM, bool LFBJCGLGEIN)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		EDHEIFHAAKO();
		string text = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? InputUtils.CMOBIDABHKM(JIIGOACEIKL, (ActionType)(-96)) : InputUtils.CMOBIDABHKM(JIIGOACEIKL, ActionType.UINextPage));
		((TMP_Text)textMesh).text = LocalisationSystem.Get("Disabled") + "ReceiveSelectedObjectPositionClient" + KBCHEGCDELM;
		if (LFBJCGLGEIN)
		{
			TextMeshProUGUI obj = textMesh;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + "PreviousItem" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("=============================="), text) + "UseHold";
		}
		activeQuest = null;
		HMDFBECLNFM.sizeDelta = new Vector2(HMDFBECLNFM.sizeDelta.x, 1971f);
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
		QuestHighlightUI.GBBOMOIEBLJ(AODONKKHPBP: false);
		GFNKNJLAJMD = false;
	}
}
