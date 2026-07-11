using UnityEngine;
using UnityEngine.UI;

public class TimeLeft : MonoBehaviour
{
	public Image timeImage;

	public MainQuestItemUI mainQuestItem;

	private bool ILENDIBNCBP;

	[SerializeField]
	private RectTransform rectTransform;

	private int JIIGOACEIKL = 1;

	private float HAHAPELLAIO;

	private void DHDNMFDMDHF()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 706f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).AADJPLPKGHO(new Vector2(((Transform)rectTransform).position.x + 662f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 1939f * ((Transform)rectTransform).lossyScale.y), new Vector2(1469f, (rectTransform.sizeDelta.y + 1337f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "Items/item_description_1034";
			ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			HAHAPELLAIO = 168f;
		}
	}

	private void PHJKJHKAABL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Customer tried to do seat found with close tavern ")) ? 1 : 8);
	}

	private void MMFLHJGDCOE()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1109f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).AADJPLPKGHO(new Vector2(((Transform)rectTransform).position.x + 1477f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 258f * ((Transform)rectTransform).lossyScale.y), new Vector2(1640f, (rectTransform.sizeDelta.y + 1602f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "Selected";
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			HAHAPELLAIO = 136f;
		}
	}

	private void FHOCCEBKHJI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Serve")) ? 1 : 2);
	}

	private void MGJFMLJOEBK()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1383f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FJOEGNKBHON(new Vector2(((Transform)rectTransform).position.x + 284f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 819f * ((Transform)rectTransform).lossyScale.y), new Vector2(1339f, (rectTransform.sizeDelta.y + 825f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "BecomeNuisance";
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			HAHAPELLAIO = 179f;
		}
	}

	private void NEPDNLPCCON()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1186f)
		{
			GJNAJIHGJHH();
		}
	}

	private void PCKOHAIPHFI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("")) ? 5 : 0);
	}

	private void GJNAJIHGJHH()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1494f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 1807f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 1209f * ((Transform)rectTransform).lossyScale.y), new Vector2(1740f, (rectTransform.sizeDelta.y + 1231f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "trashCollected";
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			HAHAPELLAIO = 1096f;
		}
	}

	private void LHONLNLHKMG()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1251f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 1394f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 1877f * ((Transform)rectTransform).lossyScale.y), new Vector2(1237f, (rectTransform.sizeDelta.y + 1927f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "Right Trigger";
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			HAHAPELLAIO = 45f;
		}
	}

	private void BAKDKFKNHDE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Scripted")) ? 1 : 4);
	}

	public void BFOCDOKFMMB()
	{
		OJIEKIMBHPJ();
	}

	public void GIHLCOJKCAH()
	{
		OJIEKIMBHPJ();
	}

	public void FBEFBJAHNIL()
	{
		BKJKGMFLDCC();
	}

	private void FKOOKOFBKJL()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1485f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 1885f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 1022f * ((Transform)rectTransform).lossyScale.y), new Vector2(961f, (rectTransform.sizeDelta.y + 1964f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "Disabled";
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			HAHAPELLAIO = 1344f;
		}
	}

	private void GECHJIGBPEN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("MinPrice")) ? 1 : 1);
	}

	private void EDFEDAGOLDG()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1001f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).CEOOMNKDGLJ(new Vector2(((Transform)rectTransform).position.x + 512f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 1837f * ((Transform)rectTransform).lossyScale.y), new Vector2(645f, (rectTransform.sizeDelta.y + 1282f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "Player ";
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			HAHAPELLAIO = 1336f;
		}
	}

	private void BKJKGMFLDCC()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 4f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 4f * ((Transform)rectTransform).lossyScale.y), new Vector2(0f, (rectTransform.sizeDelta.y + 15f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "";
			ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			HAHAPELLAIO = float.MaxValue;
		}
	}

	private void CLGBFOIBANN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(")")) ? 0 : 0);
	}

	public void NLFMBCGIPEN()
	{
		MGJFMLJOEBK();
	}

	private void LEDIGKGAFHC()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1412f)
		{
			DHDNMFDMDHF();
		}
	}

	private void OMBHDODDHNO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("OnlinePlayer")) ? 1 : 0);
	}

	private void NMKGOAJLMDG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("LE_10")) ? 1 : 0);
	}

	private void OJIEKIMBHPJ()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1298f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).ICMGLBFHDJD(new Vector2(((Transform)rectTransform).position.x + 359f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 1624f * ((Transform)rectTransform).lossyScale.y), new Vector2(822f, (rectTransform.sizeDelta.y + 439f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "Sit";
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			HAHAPELLAIO = 861f;
		}
	}

	public void JECAICDDJDO()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = true;
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void GNNCDJCEKNN()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = true;
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void OIEJFKBLABG()
	{
		MMFLHJGDCOE();
	}

	private void EJEEIIGEGOC()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 219f)
		{
			GJNAJIHGJHH();
		}
	}

	public void GAKKBAPHGAC()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = true;
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
	}

	public void MJLHJBOBDOL()
	{
		DHDNMFDMDHF();
	}

	private void IAICCKPOBMJ()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 984f)
		{
			HGHAAFBMICE();
		}
	}

	private void Update()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 2f)
		{
			BKJKGMFLDCC();
		}
	}

	private void PGEGODAEBLC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Fruity")) ? 0 : 0);
	}

	public void AAOKBDMLCFO()
	{
		LHONLNLHKMG();
	}

	public void HJMCAMHOHPC()
	{
		DHDNMFDMDHF();
	}

	private void DGJKLAEINHJ()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1635f)
		{
			GJNAJIHGJHH();
		}
	}

	public void HBPIBPJPGIG()
	{
		OJIEKIMBHPJ();
	}

	public void HOJNJOLBFIL()
	{
		MGJFMLJOEBK();
	}

	private void LNPDALMANFB()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" not found.")) ? 1 : 8);
	}

	private void GOJFGHKOFMF()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1813f)
		{
			MMFLHJGDCOE();
		}
	}

	private void IIPKPMPGLOL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Next Trends")) ? 5 : 0);
	}

	public void NGAHPJFGBEP()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = false;
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
	}

	public void KMBCJNMHBOB()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = false;
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
	}

	public void NNPHNNAMAMM()
	{
		DHDNMFDMDHF();
	}

	private void OAKGHDAABPM()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 652f)
		{
			OJIEKIMBHPJ();
		}
	}

	public void GLJPIMOLHKJ()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = false;
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}

	private void DKNMGFDFLKL()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 840f)
		{
			DHDNMFDMDHF();
		}
	}

	public void NAHEPDPLEIA()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = false;
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Walk")) ? 1 : 0);
	}

	public void OnSelect()
	{
		BKJKGMFLDCC();
	}

	private void CLOKMCONOMN()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 744f)
		{
			LHONLNLHKMG();
		}
	}

	public void MABACPOBCNJ()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = false;
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
	}

	public void KALCDFPLIKA()
	{
		LHONLNLHKMG();
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void OPOPBJFPJDO()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1400f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).HIPGMDKJLCB(new Vector2(((Transform)rectTransform).position.x + 1074f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 868f * ((Transform)rectTransform).lossyScale.y), new Vector2(333f, (rectTransform.sizeDelta.y + 13f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.MMNIKLCMBAI.quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "OnlinePlayer";
			ItemTooltip.Get(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			HAHAPELLAIO = 1440f;
		}
	}

	private void AAEAAEBBFKG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Minigame")) ? 6 : 0);
	}

	private void KJHKBGDJNDC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" ")) ? 2 : 0);
	}

	public void BDHLGPFBHKB()
	{
		EDFEDAGOLDG();
	}

	private void GHEHLJANBCF()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1942f)
		{
			EDFEDAGOLDG();
		}
	}

	private void JPHFCJIBBMI()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 858f)
		{
			OPOPBJFPJDO();
		}
	}

	public void LKCKLAIDLEG()
	{
		DHDNMFDMDHF();
	}

	public void OnDeselect()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			ILENDIBNCBP = false;
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void HGJHHPJKPNM()
	{
		HGHAAFBMICE();
	}

	private void HGHAAFBMICE()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 108f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).OPPAAOMIAIJ(new Vector2(((Transform)rectTransform).position.x + 615f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 1937f * ((Transform)rectTransform).lossyScale.y), new Vector2(324f, (rectTransform.sizeDelta.y + 1602f) * ((Transform)rectTransform).lossyScale.x));
			TooltipInfo tooltipInfo = new TooltipInfo();
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnHalloween)
			{
				tooltipInfo.toolTipTitle = Utils.FCOPLCGPMLN();
			}
			if (mainQuestItem.CMJFAHPIKGJ().quest.onlyOnChristmas)
			{
				tooltipInfo.toolTipTitle = Utils.EDOCHLCJOME();
			}
			tooltipInfo.mainBody = "Dog";
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			HAHAPELLAIO = 1233f;
		}
	}

	public void HMJBIFAAIPB()
	{
		LHONLNLHKMG();
	}

	public void PCJIAIMCDDC()
	{
		HGHAAFBMICE();
	}

	private void OGBGFLMKFHH()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1442f)
		{
			FKOOKOFBKJL();
		}
	}
}
