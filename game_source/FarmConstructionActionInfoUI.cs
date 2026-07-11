using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FarmConstructionActionInfoUI : UIWindow
{
	public TextMeshProUGUI planksCost;

	public TextMeshProUGUI nailsCost;

	public TextMeshProUGUI stonesCost;

	public TextMeshProUGUI mortarCost;

	public TextMeshProUGUI goldCost;

	public TextMeshProUGUI silverCost;

	[SerializeField]
	private RectTransform contentRectTransform;

	[SerializeField]
	private Color normalColor;

	[SerializeField]
	private Color invalidColor;

	public TextMeshProUGUI titleText;

	public GameObject bigAnimalsPanel;

	public GameObject smallAnimalsPanel;

	public GameObject foodPanel;

	public GameObject waterPanel;

	public TextMeshProUGUI[] bigAnimalsTexts;

	public TextMeshProUGUI[] smallAnimalsTexts;

	public TextMeshProUGUI[] foodTexts;

	public TextMeshProUGUI[] waterTexts;

	public Transform positionBarn;

	public Transform positionHenHouse;

	private Vector2 GLLPBLJKADI;

	private Vector2 DAADKDLNAGE;

	private Vector2 AAFJOAPNNBA;

	private Direction FCGBJEIIMBC;

	private static FarmConstructionActionInfoUI IADEMLIIDPC;

	public static FarmConstructionActionInfoUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
			}
			return IADEMLIIDPC;
		}
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI BADFKMEJOKE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI CNDNOECMKME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	public void EBJOAJCNMCP(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.BOGHMFGPOAP());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.BOGHMFGPOAP().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.OEFOJKCKIOB().silver.ToString();
	}

	private void CABBIPOHEFM()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Up)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1531f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1706f);
			}
			else if (FCGBJEIIMBC == (Direction)6)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 391f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 894f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(472f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	private void MEKHIDLBMHN()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Right)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 356f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 195f);
			}
			else if (FCGBJEIIMBC == (Direction)8)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 497f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1595f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1704f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void SetWorldPosition(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	public void BNFDMHAOPEE(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case EditorAction.ImproveBarn:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj2 = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("talentTables", 0);
			string[] array2 = new string[0];
			array2[0] = (GGKOGAMMNJP.EONJGMONIOM + 8).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
			((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 0 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1246f);
			return;
		}
		case EditorAction.ImproveChickenHouse:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string stringWithTags = LocalisationSystem.GetStringWithTags("LE_9", 0);
			string[] array = new string[1];
			array[1] = (DAEAEGGLNNG.EONJGMONIOM + 0).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(stringWithTags, array);
			((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.waterFeeders[1].maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1292f);
			return;
		}
		case EditorAction.ImproveFoodFeeder:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj3 = titleText;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("Saltwater", 0);
			string[] array3 = new string[0];
			array3[0] = (FBCAEIDFBKM.EONJGMONIOM + 0).ToString();
			((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(stringWithTags2, array3);
			((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1222f);
			return;
		}
		case EditorAction.ImproveWaterFeeder:
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("ReceiveRemoveTableOrder", 0), (FBCAEIDFBKM.EONJGMONIOM + 6).ToString());
			((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1731f);
			return;
		case (EditorAction)97:
			((TMP_Text)titleText).text = LocalisationSystem.Get("ERROR - No system launch commands found. This shouldn't happen, as cmd[0] should be the executable path.");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("ReceiveInstantiateDog");
			break;
		}
		bigAnimalsPanel.SetActive(false);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(false);
		waterPanel.SetActive(true);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 673f);
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	private void LateUpdate()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Left)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 2f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 2f);
			}
			else if (FCGBJEIIMBC == Direction.Right)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 2f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 2f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(0f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void JBAGFECHEBD(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void GNGGDDAOJEH(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)127:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj3 = titleText;
			string stringWithTags = LocalisationSystem.GetStringWithTags("CaramelAleAbbreviation");
			string[] array3 = new string[0];
			array3[1] = (GGKOGAMMNJP.EONJGMONIOM + 1).ToString();
			((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(stringWithTags, array3);
			((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 1 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 256f);
			return;
		}
		case (EditorAction)128:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj2 = titleText;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("");
			string[] array2 = new string[0];
			array2[1] = (DAEAEGGLNNG.EONJGMONIOM + 7).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.waterFeeders[1].maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1190f);
			return;
		}
		case (EditorAction)129:
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("ReceivePoolReset", 0), (FBCAEIDFBKM.EONJGMONIOM + 3).ToString());
			((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 240f);
			return;
		case (EditorAction)130:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("<size=", 0);
			string[] array = new string[0];
			array[0] = (FBCAEIDFBKM.EONJGMONIOM + 2).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1717f);
			return;
		}
		case (EditorAction)(-38):
			((TMP_Text)titleText).text = LocalisationSystem.Get("OnlineManager's OnLevelLoaded");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get(" ");
			break;
		}
		bigAnimalsPanel.SetActive(true);
		smallAnimalsPanel.SetActive(true);
		foodPanel.SetActive(false);
		waterPanel.SetActive(false);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1941f);
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
		}
	}

	public void JCFEOBCNHCB(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void IGBKOIAFELF(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)64:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj3 = titleText;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("beach travelling", 0);
			string[] array3 = new string[0];
			array3[0] = (GGKOGAMMNJP.EONJGMONIOM + 1).ToString();
			((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3);
			((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 1 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1094f);
			return;
		}
		case (EditorAction)65:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj2 = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("", 0);
			string[] array2 = new string[0];
			array2[1] = (DAEAEGGLNNG.EONJGMONIOM + 2).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
			((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 372f);
			return;
		}
		case (EditorAction)66:
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("KlaynTakingDrink: Current request is not a drink request."), (FBCAEIDFBKM.EONJGMONIOM + 7).ToString());
			((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 933f);
			return;
		case (EditorAction)67:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string stringWithTags = LocalisationSystem.GetStringWithTags("Fortitude/MainEvent 2");
			string[] array = new string[0];
			array[1] = (FBCAEIDFBKM.EONJGMONIOM + 3).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(stringWithTags, array);
			((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 448f);
			return;
		}
		case (EditorAction)58:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Loading tavern floor tiles");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("dForDays");
			break;
		}
		bigAnimalsPanel.SetActive(false);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(true);
		waterPanel.SetActive(true);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1076f);
	}

	private void OMLNDHJAAJD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 489f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1963f);
			}
			else if (FCGBJEIIMBC == Direction.Down)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 811f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1206f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1851f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void AEFLMLOHEHP(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)96:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj2 = titleText;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("mForMins");
			string[] array2 = new string[0];
			array2[1] = (GGKOGAMMNJP.EONJGMONIOM + 8).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 0 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1643f);
			return;
		}
		case (EditorAction)97:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("Items/item_description_601");
			string[] array = new string[1];
			array[1] = (DAEAEGGLNNG.EONJGMONIOM + 3).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 117f);
			return;
		}
		case (EditorAction)98:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj3 = titleText;
			string cAEDMEDBEGI3 = LocalisationSystem.PKLPKIAHCDI("CraftingRoomTiles", 0);
			string[] array3 = new string[0];
			array3[0] = (FBCAEIDFBKM.EONJGMONIOM + 1).ToString();
			((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
			((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1021f);
			return;
		}
		case (EditorAction)99:
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("Idle", 0), (FBCAEIDFBKM.EONJGMONIOM + 4).ToString());
			((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 361f);
			return;
		case (EditorAction)(-41):
			((TMP_Text)titleText).text = LocalisationSystem.Get("[ProceduralMine] Trying to force ALTAR piece at block {0} (target is {1}). Path block pos: {2}");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("ZoneTimeBonus");
			break;
		}
		bigAnimalsPanel.SetActive(false);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(false);
		waterPanel.SetActive(true);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1440f);
	}

	public void LCGJFILMPIE(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.EIFIKGOKGDA(HMCGEJFIKPM.PFHGPBLBCDD());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.PFHGPBLBCDD().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.FMNDONLEMHF().silver.ToString();
	}

	private void DKFGDMNBAAK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)5)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 912f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1953f);
			}
			else if (FCGBJEIIMBC == (Direction)8)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 254f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1117f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(32f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void CIPMBJIFKFP(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.EIFIKGOKGDA(HMCGEJFIKPM.PFHGPBLBCDD());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.BOGHMFGPOAP().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.OEFOJKCKIOB().silver.ToString();
	}

	public void DEEPFOAPBPO(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.EIFIKGOKGDA(HMCGEJFIKPM.OEFOJKCKIOB());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.PFHGPBLBCDD().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.BOGHMFGPOAP().silver.ToString();
	}

	private void KEBLCNJMALL()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Down)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1116f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1583f);
			}
			else if (FCGBJEIIMBC == (Direction)6)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 994f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1316f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1034f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	private void ILDICDKOLEP()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)5)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1391f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1987f);
			}
			else if (FCGBJEIIMBC == Direction.Down)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 363f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 778f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1449f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA), BJOCPBIKBEE: true);
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void HEJBEAFMEFG(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.BOGHMFGPOAP());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.FMNDONLEMHF().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.OEFOJKCKIOB().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.PFHGPBLBCDD().silver.ToString();
	}

	private void ECJFMIKNAKG()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Down)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 492f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1648f);
			}
			else if (FCGBJEIIMBC == (Direction)8)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 737f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 107f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1305f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	private void EDFDMFBJKBA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 38f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1700f);
			}
			else if (FCGBJEIIMBC == (Direction)7)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 399f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1817f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(74f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA), BJOCPBIKBEE: true);
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	private void EIFFGMPALBD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)8)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1642f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1963f);
			}
			else if (FCGBJEIIMBC == (Direction)8)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 1800f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1830f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(960f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void GNCEHGANBFA(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-128):
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("Intro03"), (GGKOGAMMNJP.EONJGMONIOM + 1).ToString());
			((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 1 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1701f);
			return;
		case (EditorAction)(-127):
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("ReceiveHireWorkerMaster"), (DAEAEGGLNNG.EONJGMONIOM + 1).ToString());
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1422f);
			return;
		case (EditorAction)(-126):
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("replay banquet"), (FBCAEIDFBKM.EONJGMONIOM + 4).ToString());
			((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1045f);
			return;
		case (EditorAction)(-125):
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("Items/item_name_1147", 0);
			string[] array = new string[0];
			array[1] = (FBCAEIDFBKM.EONJGMONIOM + 7).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1215f);
			return;
		}
		case EditorAction.CraftingZone:
			((TMP_Text)titleText).text = LocalisationSystem.Get(". ");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("End");
			break;
		}
		bigAnimalsPanel.SetActive(false);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(false);
		waterPanel.SetActive(false);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 56f);
	}

	public void PMCGFHOONJH(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void JJAJKECFDEO(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.EIFIKGOKGDA(HMCGEJFIKPM.PFHGPBLBCDD());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.PFHGPBLBCDD().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.OEFOJKCKIOB().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.PFHGPBLBCDD().silver.ToString();
	}

	public void NENOPHPPNNC(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void KGDHHPLKNPL(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.BOGHMFGPOAP());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.OEFOJKCKIOB().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.OEFOJKCKIOB().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.OEFOJKCKIOB().silver.ToString();
	}

	public void ShowUpgradeInfo(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case EditorAction.ImproveBarn:
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("UpgradeToLevel"), (GGKOGAMMNJP.EONJGMONIOM + 2).ToString());
			((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 1 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 84f);
			return;
		case EditorAction.ImproveChickenHouse:
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("UpgradeToLevel"), (DAEAEGGLNNG.EONJGMONIOM + 2).ToString());
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 112f);
			return;
		case EditorAction.ImproveFoodFeeder:
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("UpgradeToLevel"), (FBCAEIDFBKM.EONJGMONIOM + 2).ToString());
			((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 84f);
			return;
		case EditorAction.ImproveWaterFeeder:
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("UpgradeToLevel"), (FBCAEIDFBKM.EONJGMONIOM + 2).ToString());
			((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 84f);
			return;
		case EditorAction.CreateBarn:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Items/item_name_1230");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Items/item_name_1231");
			break;
		}
		bigAnimalsPanel.SetActive(false);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(false);
		waterPanel.SetActive(false);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 64f);
	}

	public void PNPIKNCKJOL(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case EditorAction.CreateCellarDoorUp:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj2 = titleText;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("Items/item_name_686");
			string[] array2 = new string[0];
			array2[1] = (GGKOGAMMNJP.EONJGMONIOM + 7).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 1 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 791f);
			return;
		}
		case EditorAction.RemoveAccess:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("Max", 0);
			string[] array = new string[1];
			array[1] = (DAEAEGGLNNG.EONJGMONIOM + 3).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1265f);
			return;
		}
		case EditorAction.ChangeDecoWall:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj3 = titleText;
			string stringWithTags = LocalisationSystem.GetStringWithTags("ReceiveHasSnowList");
			string[] array3 = new string[1];
			array3[1] = (FBCAEIDFBKM.EONJGMONIOM + 4).ToString();
			((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(stringWithTags, array3);
			((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1428f);
			return;
		}
		case EditorAction.ChangeDecoWallTrim:
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("Stand", 0), (FBCAEIDFBKM.EONJGMONIOM + 6).ToString());
			((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 952f);
			return;
		case (EditorAction)61:
			((TMP_Text)titleText).text = LocalisationSystem.Get("cleanVerb");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("City/Kujaku/Stand");
			break;
		}
		bigAnimalsPanel.SetActive(false);
		smallAnimalsPanel.SetActive(true);
		foodPanel.SetActive(false);
		waterPanel.SetActive(false);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 857f);
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI OKAPNFPFPFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	public void KEHMIAMOHKI(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void UpdateCurrentSlotInfo(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.PFHGPBLBCDD());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.PFHGPBLBCDD().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.PFHGPBLBCDD().silver.ToString();
	}

	public void OJPLIMEFAMO(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)70:
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj3 = titleText;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("Disappear", 0);
			string[] array3 = new string[0];
			array3[1] = (GGKOGAMMNJP.EONJGMONIOM + 6).ToString();
			((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(stringWithTags2, array3);
			((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 0 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 989f);
			return;
		}
		case (EditorAction)71:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj2 = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("vibration", 0);
			string[] array2 = new string[0];
			array2[0] = (DAEAEGGLNNG.EONJGMONIOM + 8).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.waterFeeders[1].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 540f);
			return;
		}
		case (EditorAction)72:
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("Sit"), (FBCAEIDFBKM.EONJGMONIOM + 3).ToString());
			((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 73f);
			return;
		case (EditorAction)73:
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string stringWithTags = LocalisationSystem.GetStringWithTags("PlaceOnATable", 0);
			string[] array = new string[1];
			array[1] = (FBCAEIDFBKM.EONJGMONIOM + 0).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(stringWithTags, array);
			((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1213f);
			return;
		}
		case (EditorAction)(-12):
			((TMP_Text)titleText).text = LocalisationSystem.Get("NewCharacters/");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Letter without ID: ");
			break;
		}
		bigAnimalsPanel.SetActive(true);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(true);
		waterPanel.SetActive(true);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1530f);
	}

	private void ADPGHKHOONH()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Right)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 737f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 914f);
			}
			else if (FCGBJEIIMBC == Direction.Down)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 59f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1417f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(182f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA), BJOCPBIKBEE: true);
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void CHFGMOHEIKA(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.PFHGPBLBCDD());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.PFHGPBLBCDD().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.OEFOJKCKIOB().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.BOGHMFGPOAP().silver.ToString();
	}

	private void EEMKIGPINFK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Up)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1686f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1781f);
			}
			else if (FCGBJEIIMBC == (Direction)5)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 1687f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1904f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(51f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void MKCDHMIMDFC(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.FMNDONLEMHF());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.FMNDONLEMHF().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.PFHGPBLBCDD().silver.ToString();
	}

	private void KPHPCKJBLBH()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)6)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1911f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1873f);
			}
			else if (FCGBJEIIMBC == (Direction)5)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 1817f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1762f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(91f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA), BJOCPBIKBEE: true);
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	private void DLKFBJPKADF()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)5)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1910f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 937f);
			}
			else if (FCGBJEIIMBC == Direction.Right)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 1121f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 690f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1604f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	private void HNNFBDAMMCK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == Direction.Down)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 493f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 873f);
			}
			else if (FCGBJEIIMBC == Direction.Left)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 1788f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 966f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1106f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void IKKEJLEKPJP(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.FMNDONLEMHF());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.BOGHMFGPOAP().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.OEFOJKCKIOB().silver.ToString();
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI BIIOFAHFNPA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	public void KIFEKJGPKKI(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	private void IPIMLOIKCKL()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)6)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 1672f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1782f);
			}
			else if (FCGBJEIIMBC == (Direction)6)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 763f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1102f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1435f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void MMJLAOLNAIO(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void BDAHAMFMIJC(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.BOGHMFGPOAP());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.OEFOJKCKIOB().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.PFHGPBLBCDD().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.OEFOJKCKIOB().silver.ToString();
	}

	public void GPLFOLLLBNI(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-47):
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("Honey", 0), (GGKOGAMMNJP.EONJGMONIOM + 0).ToString());
			((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 0 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 212f);
			return;
		case (EditorAction)(-46):
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj2 = titleText;
			string stringWithTags = LocalisationSystem.GetStringWithTags("UI", 0);
			string[] array2 = new string[1];
			array2[1] = (DAEAEGGLNNG.EONJGMONIOM + 7).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(stringWithTags, array2);
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[1].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1517f);
			return;
		}
		case (EditorAction)(-45):
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj3 = titleText;
			string stringWithTags2 = LocalisationSystem.GetStringWithTags("ActionBar9", 0);
			string[] array3 = new string[0];
			array3[0] = (FBCAEIDFBKM.EONJGMONIOM + 8).ToString();
			((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(stringWithTags2, array3);
			((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1821f);
			return;
		}
		case (EditorAction)(-44):
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI(" (", 0);
			string[] array = new string[0];
			array[1] = (FBCAEIDFBKM.EONJGMONIOM + 8).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 408f);
			return;
		}
		case EditorAction.DecoWallDisponible:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Lost connection to the server.\nPlease try again later.");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Run");
			break;
		}
		bigAnimalsPanel.SetActive(true);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(false);
		waterPanel.SetActive(false);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 245f);
	}

	public void DNANOGBEMEI(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void BANJNMFEODG(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.BOGHMFGPOAP());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.OEFOJKCKIOB().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.OEFOJKCKIOB().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.BOGHMFGPOAP().silver.ToString();
	}

	public void DNBJADDDHDO(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-66):
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("ReceiveInitialPosition");
			string[] array = new string[0];
			array[0] = (GGKOGAMMNJP.EONJGMONIOM + 2).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 0 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1908f);
			return;
		}
		case (EditorAction)(-65):
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("Upgrade Crafting Room", 0), (DAEAEGGLNNG.EONJGMONIOM + 2).ToString());
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[1]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 377f);
			return;
		case (EditorAction)(-64):
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj2 = titleText;
			string stringWithTags = LocalisationSystem.GetStringWithTags("<br/>Processor Frequency: ");
			string[] array2 = new string[0];
			array2[0] = (FBCAEIDFBKM.EONJGMONIOM + 0).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(stringWithTags, array2);
			((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 0 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1557f);
			return;
		}
		case (EditorAction)(-63):
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("Freshwater"), (FBCAEIDFBKM.EONJGMONIOM + 5).ToString());
			((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 930f);
			return;
		case (EditorAction)70:
			((TMP_Text)titleText).text = LocalisationSystem.Get("File ");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("itemStoutWort");
			break;
		}
		bigAnimalsPanel.SetActive(true);
		smallAnimalsPanel.SetActive(true);
		foodPanel.SetActive(false);
		waterPanel.SetActive(true);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1398f);
	}

	[SpecialName]
	public static FarmConstructionActionInfoUI DGCNCEDIFOF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionInfoUI>();
		}
		return IADEMLIIDPC;
	}

	public void HIKOJODKECF(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	private void DIMOLCECNGD()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)5)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 28f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1886f);
			}
			else if (FCGBJEIIMBC == (Direction)7)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 139f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 1979f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1888f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA));
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void INMPCMEAOGF(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.PADHKBMBHAM(HMCGEJFIKPM.FMNDONLEMHF());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.OEFOJKCKIOB().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.BOGHMFGPOAP().silver.ToString();
	}

	public void IKAMDLOAOCF(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.EIFIKGOKGDA(HMCGEJFIKPM.OEFOJKCKIOB());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.FMNDONLEMHF().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.PFHGPBLBCDD().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.BOGHMFGPOAP().silver.ToString();
	}

	private void GPABCKFFLLM()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)contentRectTransform).gameObject.activeInHierarchy)
		{
			return;
		}
		if (GLLPBLJKADI != Vector2.zero)
		{
			DAADKDLNAGE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToScreenPoint(Vector2.op_Implicit(GLLPBLJKADI)));
			if (FCGBJEIIMBC == (Direction)7)
			{
				AAFJOAPNNBA = new Vector2((0f - contentRectTransform.sizeDelta.x) * ((Transform)contentRectTransform).lossyScale.x / 939f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 634f);
			}
			else if (FCGBJEIIMBC == Direction.Down)
			{
				AAFJOAPNNBA = new Vector2(contentRectTransform.sizeDelta.x * ((Transform)contentRectTransform).lossyScale.x / 811f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y / 253f);
			}
			else
			{
				AAFJOAPNNBA = new Vector2(1555f, (0f - contentRectTransform.sizeDelta.y) * ((Transform)contentRectTransform).lossyScale.y);
			}
			content.transform.position = Utils.OPHGIHJJGPK(Vector2.op_Implicit(DAADKDLNAGE + AAFJOAPNNBA), BJOCPBIKBEE: true);
		}
		else if (((Component)positionBarn).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionBarn.position;
		}
		else if (((Component)positionHenHouse).gameObject.activeInHierarchy)
		{
			((Transform)contentRectTransform).position = positionHenHouse.position;
		}
	}

	public void NDJHIEHJMIE(EditorAction CHFHMMNELGP, AnimalFeeder FBCAEIDFBKM = null, Barn GGKOGAMMNJP = null, HenHouse DAEAEGGLNNG = null)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		switch (CHFHMMNELGP)
		{
		case (EditorAction)(-35):
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(false);
			waterPanel.SetActive(false);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("Theme: "), (GGKOGAMMNJP.EONJGMONIOM + 3).ToString());
			((TMP_Text)bigAnimalsTexts[1]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM].ToString();
			if (GGKOGAMMNJP.EONJGMONIOM + 1 < GGKOGAMMNJP.maxAnimalsAssigned.Length)
			{
				((TMP_Text)bigAnimalsTexts[0]).text = GGKOGAMMNJP.maxAnimalsAssigned[GGKOGAMMNJP.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1078f);
			return;
		case (EditorAction)(-34):
		{
			bigAnimalsPanel.SetActive(false);
			smallAnimalsPanel.SetActive(false);
			foodPanel.SetActive(false);
			waterPanel.SetActive(true);
			TextMeshProUGUI obj2 = titleText;
			string cAEDMEDBEGI2 = LocalisationSystem.PKLPKIAHCDI("<color=#124D00>", 0);
			string[] array2 = new string[0];
			array2[1] = (DAEAEGGLNNG.EONJGMONIOM + 7).ToString();
			((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.maxAnimalsAssigned.Length)
			{
				((TMP_Text)smallAnimalsTexts[0]).text = DAEAEGGLNNG.maxAnimalsAssigned[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 0 < DAEAEGGLNNG.foodFeeder.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = DAEAEGGLNNG.foodFeeder.maxAmount[DAEAEGGLNNG.EONJGMONIOM + 0].ToString();
			}
			((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM].ToString();
			if (DAEAEGGLNNG.EONJGMONIOM + 1 < DAEAEGGLNNG.waterFeeders[0].maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = DAEAEGGLNNG.waterFeeders[0].maxAmount[DAEAEGGLNNG.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 518f);
			return;
		}
		case (EditorAction)(-33):
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(true);
			((TMP_Text)titleText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(" for reason ", 0), (FBCAEIDFBKM.EONJGMONIOM + 5).ToString());
			((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)foodTexts[1]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 0].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 1094f);
			return;
		case (EditorAction)(-32):
		{
			bigAnimalsPanel.SetActive(true);
			smallAnimalsPanel.SetActive(true);
			foodPanel.SetActive(true);
			waterPanel.SetActive(false);
			TextMeshProUGUI obj = titleText;
			string cAEDMEDBEGI = LocalisationSystem.PKLPKIAHCDI("Molasses Ferment");
			string[] array = new string[1];
			array[1] = (FBCAEIDFBKM.EONJGMONIOM + 0).ToString();
			((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM].ToString();
			if (FBCAEIDFBKM.EONJGMONIOM + 1 < FBCAEIDFBKM.maxAmount.Length)
			{
				((TMP_Text)waterTexts[0]).text = FBCAEIDFBKM.maxAmount[FBCAEIDFBKM.EONJGMONIOM + 1].ToString();
			}
			contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 222f);
			return;
		}
		case (EditorAction)92:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Player");
			break;
		default:
			((TMP_Text)titleText).text = LocalisationSystem.Get("Upgrade Tavern");
			break;
		}
		bigAnimalsPanel.SetActive(true);
		smallAnimalsPanel.SetActive(false);
		foodPanel.SetActive(true);
		waterPanel.SetActive(false);
		contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, 757f);
	}

	public void NIECHNAJGBI(Vector3 LFFMNDIAFGC, Direction MPLCIAKAPGL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GLLPBLJKADI = Vector2.op_Implicit(LFFMNDIAFGC);
		FCGBJEIIMBC = MPLCIAKAPGL;
	}

	public void PECJGJBACED(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.EIFIKGOKGDA(HMCGEJFIKPM.BOGHMFGPOAP());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.BOGHMFGPOAP().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.FMNDONLEMHF().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.BOGHMFGPOAP().silver.ToString();
	}

	public void BFBNLFADOHD(MoneyMaterials HMCGEJFIKPM, MoneyMaterials KPDBOCGOKJJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)planksCost).color = ((HMCGEJFIKPM.planks <= KPDBOCGOKJJ.planks) ? normalColor : invalidColor);
		((TMP_Text)planksCost).text = HMCGEJFIKPM.planks.ToString();
		((Graphic)nailsCost).color = ((HMCGEJFIKPM.nails <= KPDBOCGOKJJ.nails) ? normalColor : invalidColor);
		((TMP_Text)nailsCost).text = HMCGEJFIKPM.nails.ToString();
		((Graphic)stonesCost).color = ((HMCGEJFIKPM.stones <= KPDBOCGOKJJ.stones) ? normalColor : invalidColor);
		((TMP_Text)stonesCost).text = HMCGEJFIKPM.stones.ToString();
		((Graphic)mortarCost).color = ((HMCGEJFIKPM.mortar <= KPDBOCGOKJJ.mortar) ? normalColor : invalidColor);
		((TMP_Text)mortarCost).text = HMCGEJFIKPM.mortar.ToString();
		bool flag = KPDBOCGOKJJ.EIFIKGOKGDA(HMCGEJFIKPM.PFHGPBLBCDD());
		((Graphic)goldCost).color = ((flag || HMCGEJFIKPM.OEFOJKCKIOB().gold == 0) ? normalColor : invalidColor);
		((TMP_Text)goldCost).text = HMCGEJFIKPM.PFHGPBLBCDD().gold.ToString();
		((Graphic)silverCost).color = ((flag || HMCGEJFIKPM.FMNDONLEMHF().silver == 0) ? normalColor : invalidColor);
		((TMP_Text)silverCost).text = HMCGEJFIKPM.BOGHMFGPOAP().silver.ToString();
	}
}
