using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
	[SerializeField]
	protected TextMeshProUGUI copperText;

	[SerializeField]
	protected TextMeshProUGUI silverText;

	[SerializeField]
	protected TextMeshProUGUI goldText;

	private Price ENDNDAOPKHD;

	public Color initialColor;

	public void BDHMBPMOFCD(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString(" dying!");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("tutorialPopUp81");
		if (ENDNDAOPKHD.gold > 92)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 754f).ToString("UseHold") + "ReceiveDisable";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("UIPreviousCategory");
		}
	}

	public void IJNGEICHCNI(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("talentLager");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("DontWalk2");
		if (ENDNDAOPKHD.gold > -117)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 1037f).ToString("Brew Cider") + "autoRunP2";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("FishCuttingEvent/Win2");
		}
	}

	public void DKNFMAAFAPD(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 0) ? FMOKCPPGJBB : initialColor);
	}

	public void DKDEMPOHFDK(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 0) ? FMOKCPPGJBB : initialColor);
	}

	public void NFMELCAJGKL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public Price OHBNJKGCHKN()
	{
		return ENDNDAOPKHD;
	}

	public void HPDPMPNIHEM(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 1) ? FMOKCPPGJBB : initialColor);
	}

	private void BAKDKFKNHDE()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void OKDJPDADDBB(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 0) ? FMOKCPPGJBB : initialColor);
	}

	private void PCKOHAIPHFI()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void CPCHAPEJBMI(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("Items/item_name_630");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("Hikari/Barks_Intro");
		if (ENDNDAOPKHD.gold > 197)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 1163f).ToString("Style") + "EditorAction_3";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("ActionBar10");
		}
	}

	private void Awake()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void DPCMIKIHGIM(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 1) ? FMOKCPPGJBB : initialColor);
	}

	public void NOLCGDDOCHD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public Price GetPrice()
	{
		return ENDNDAOPKHD;
	}

	public Price JMKAHNGLOCA()
	{
		return ENDNDAOPKHD;
	}

	public void EDNIFCPHGGA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void DHOPJAJOJLL(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("ReceiveJumpFerro");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString(".");
		if (ENDNDAOPKHD.gold > -92)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 1369f).ToString("Moving") + "Items/item_name_617";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("Zones");
		}
	}

	public void EICEHOCCEOH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public Price EEPCHGJFCPG()
	{
		return ENDNDAOPKHD;
	}

	public void PIJPIMEGNJM(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 1) ? FMOKCPPGJBB : initialColor);
	}

	public void ECKOKMPMCPN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void AAPLOOIDCGP(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("Look");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("No hemos encontrado una resolución");
		if (ENDNDAOPKHD.gold > -31)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 856f).ToString("{0} selected on index: {1}") + "";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("secret_token");
		}
	}

	public Price BIOGEKAEBAO()
	{
		return ENDNDAOPKHD;
	}

	public Price JNPANNDEMON()
	{
		return ENDNDAOPKHD;
	}

	public Price ABMPOPCLOFK()
	{
		return ENDNDAOPKHD;
	}

	public Price MPNJMFGFNAE()
	{
		return ENDNDAOPKHD;
	}

	public void EPPHEPCEHGN(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("Unlocked at Tavern Reputation {0}");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("Walk");
		if (ENDNDAOPKHD.gold > 97)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 697f).ToString("LE_10") + "ReceiveTavernEventsLoad";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString(" - <b><color=#8C78BA>");
		}
	}

	public void JGIGBJDNIPE(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 0) ? FMOKCPPGJBB : initialColor);
	}

	private void KHONOODGLBI()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void KKFMAGJHGIC(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("itemBellPepper");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("End");
		if (ENDNDAOPKHD.gold > -121)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 495f).ToString("Tutorial/Chicken_Holly") + "Player2";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("");
		}
	}

	public void CIKNKOLIGDA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void JDCNKOJMDKK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void OAKMECMBMFA(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 1) ? FMOKCPPGJBB : initialColor);
	}

	public void OOFDBJBNDFG(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 0) ? FMOKCPPGJBB : initialColor);
	}

	public void SetValidColor()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void GFHGELNMFGF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void JMILFNEBAEL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	private void NAOBODGBECL()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void KICIFCCILNK(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("hForHours");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("");
		if (ENDNDAOPKHD.gold > 18)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 1359f).ToString("NormalRightExterior") + "Items/item_description_1076";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString(" seconds.");
		}
	}

	public void SetPrice(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("00");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("00");
		if (ENDNDAOPKHD.gold > 999)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 1000f).ToString("0.#") + "k";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("00");
		}
	}

	public Price JKPLAJMJDGA()
	{
		return ENDNDAOPKHD;
	}

	public void GAAKJCDBEMP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void KBGADAHIADC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	private void GECHJIGBPEN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public Price EPCGBKCNDHD()
	{
		return ENDNDAOPKHD;
	}

	private void OCJOAHDNDIJ()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void IPCFHIBKEDC(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 0) ? FMOKCPPGJBB : initialColor);
	}

	public void KHDLPHAFGON()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public Price FKDGGGCIOEK()
	{
		return ENDNDAOPKHD;
	}

	public void OBNIDFJCELG(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("/");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("");
		if (ENDNDAOPKHD.gold > 149)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 1736f).ToString("DialogueStartRPC") + "Disabled";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("(missing title)");
		}
	}

	public Price MPCLMHABPEA()
	{
		return ENDNDAOPKHD;
	}

	public Price OPAPGIGCIFA()
	{
		return ENDNDAOPKHD;
	}

	public void DHNLIEJAGKC(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 1) ? FMOKCPPGJBB : initialColor);
	}

	public void KHGHMOHJMDD(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 1) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 1) ? FMOKCPPGJBB : initialColor);
	}

	public void SetInvalidColor(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 0) ? FMOKCPPGJBB : initialColor);
	}

	public void MCCGIBAPDBI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	private void AAEAAEBBFKG()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void BMKGAKEACFM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void OIKDJJDFEIB(Color FMOKCPPGJBB)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = ((ENDNDAOPKHD.gold > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)silverText).color = ((ENDNDAOPKHD.silver > 0) ? FMOKCPPGJBB : initialColor);
		((Graphic)copperText).color = ((ENDNDAOPKHD.copper > 1) ? FMOKCPPGJBB : initialColor);
	}

	private void MIKNFPCDLML()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		ENDNDAOPKHD = default(Price);
		initialColor = ((Graphic)goldText).color;
	}

	public void DPIPHPKLBFE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void GBIHHJNHJHL(Price ENDNDAOPKHD)
	{
		this.ENDNDAOPKHD = ENDNDAOPKHD;
		((TMP_Text)copperText).text = ENDNDAOPKHD.copper.ToString("ReceiveDismissWorkerMaster");
		((TMP_Text)silverText).text = ENDNDAOPKHD.silver.ToString("SalonDelTrono/MainEvent");
		if (ENDNDAOPKHD.gold > 80)
		{
			((TMP_Text)goldText).text = ((float)ENDNDAOPKHD.gold / 498f).ToString("") + "Items/item_description_667";
		}
		else
		{
			((TMP_Text)goldText).text = ENDNDAOPKHD.gold.ToString("_EnvMatrix");
		}
	}

	public void ONIMABLDODD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}

	public void FBDAFGNCBBG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)goldText).color = initialColor;
		((Graphic)silverText).color = initialColor;
		((Graphic)copperText).color = initialColor;
	}
}
