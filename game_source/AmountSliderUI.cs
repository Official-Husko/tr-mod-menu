using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmountSliderUI : UIWindow
{
	[SerializeField]
	private Slider amountSlider;

	[SerializeField]
	private TextMeshProUGUI textBox;

	[SerializeField]
	private RectTransform textBoxRect;

	[SerializeField]
	private UpDownSlider sliderScript;

	public static AmountSliderUI[] instances = new AmountSliderUI[3];

	public ItemInstance currentItem;

	private Container IAOOIEMCLBG;

	public void BJPJHNHMMEB(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 574f)
		{
			((TMP_Text)textBox).text = "bed instance null" + AODONKKHPBP + "LE_2";
		}
		else
		{
			((TMP_Text)textBox).text = "PLAYER" + Math.Abs(AODONKKHPBP) + "Rotate Placeable";
		}
	}

	public void MDFDPHIIAEL(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			OLILICGNGNL(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			FCBIIGNGDGG(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 7)
		{
			AECFCJIGEOK(amountSlider.value);
		}
	}

	public void FHDJNJCIKCN(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 1430f)
		{
			((TMP_Text)textBox).text = "ReceiveRemoveTableOrderBanquetCustomer" + AODONKKHPBP + "Disabled";
		}
		else
		{
			((TMP_Text)textBox).text = "Trying to add a player that's already on the list." + Math.Abs(AODONKKHPBP) + "TorchPuzzleDatabase not assigned";
		}
	}

	public void OOPLFEFLDDB(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void FOMOAANKPEB(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 798f)
		{
			((TMP_Text)textBox).text = "Dialogue System/Conversation/TavernFilthy/Entry/2/Dialogue Text" + AODONKKHPBP + "Items/item_name_1083";
		}
		else
		{
			((TMP_Text)textBox).text = "BanquetOrdersManager is not initialized." + Math.Abs(AODONKKHPBP) + "OnlinePlayer";
		}
	}

	public void PCHGKHDNNFI(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = 60 - LJALBEIAFCG + 91 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = false;
	}

	public void GBAIMLKDKAH(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 566f)
		{
			((TMP_Text)textBox).text = "Bomb" + AODONKKHPBP + "Club";
		}
		else
		{
			((TMP_Text)textBox).text = "Interact" + Math.Abs(AODONKKHPBP) + "";
		}
	}

	public void PFLEGMCHLIF(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			OLILICGNGNL(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			GBOIBPOKCNG(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 7)
		{
			DMLHGBALHON(amountSlider.value);
		}
	}

	public void DNNFNDDNPHA(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	private void GCMHJBDMGNP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 1424f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	private void AAOCBIOAHDJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 708f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public static AmountSliderUI JCBPABNCBPI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void AAINBMEHMIK(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = -40 - LJALBEIAFCG + 109 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = false;
	}

	private void AECFCJIGEOK(float MGNOBNCMDJG)
	{
		string[] array = new string[8];
		array[1] = "check keybinds";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[3] = "\n\n\nMine Level Info:\n";
		array[7] = currentItem.FBEHKKOKNDJ();
		array[6] = "Ninja Orders Manager is not initialized.";
		array[5] = ((MGNOBNCMDJG >= 33f) ? " " : "Zone not found");
		Debug.Log((object)string.Concat(array));
	}

	public static AmountSliderUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void GDCGBOPDMHB(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 1192f)
		{
			((TMP_Text)textBox).text = "Cancel" + AODONKKHPBP + "Farm/Buzz/Bark_Build";
		}
		else
		{
			((TMP_Text)textBox).text = "itemRosemarySeeds" + Math.Abs(AODONKKHPBP) + "ReceiveNewLetter";
		}
	}

	public void SetItem(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	private void DEJCNNIAELF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 1666f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	private void LGHINIPNKDO(float MGNOBNCMDJG)
	{
		string[] array = new string[7];
		array[1] = "AceT_Quest";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[3] = "talent_name_102";
		array[1] = currentItem.ONMFAMHKGLA(OAFPBCPDOKH: true);
		array[8] = ":</color> ";
		array[0] = ((MGNOBNCMDJG >= 1330f) ? "MainProgress" : "Read");
		Debug.Log((object)string.Concat(array));
	}

	private void NOBDACNJAIN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 511f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void GHEENHHCIOF(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void FDGNPADHABD(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 2f)
		{
			((TMP_Text)textBox).text = "UIInteract" + AODONKKHPBP + "Puente_EA/Talk 1";
		}
		else
		{
			((TMP_Text)textBox).text = "Intro/TavernAlone" + Math.Abs(AODONKKHPBP) + "Bomb";
		}
	}

	public void DisplayAmountToAdd(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = 99 - LJALBEIAFCG + 99 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = true;
	}

	public void ELKKJLHKPKH(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 7f)
		{
			((TMP_Text)textBox).text = "AceT_Quest" + AODONKKHPBP + "You have to use the PixelPerfectCamera script on the assigned UI camera!";
		}
		else
		{
			((TMP_Text)textBox).text = "No banquet barrel found with drink: " + Math.Abs(AODONKKHPBP) + "Warm";
		}
	}

	private void NJKCCOKFOMI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 140f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void NMFFDAGDHNF(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public static AmountSliderUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CKGJNDHGBIK(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void AIHOKFEGHPI(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void BAGGPABPKAG(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void PCALJMPIDDM(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 733f)
		{
			((TMP_Text)textBox).text = "Grab" + AODONKKHPBP + "{0} photon instantiation. ViewID: {1}";
		}
		else
		{
			((TMP_Text)textBox).text = "add item " + Math.Abs(AODONKKHPBP) + "ReceiveOfferingUIOpened";
		}
	}

	private void OLILICGNGNL(float MGNOBNCMDJG)
	{
		string[] array = new string[8];
		array[0] = "Render mode: ";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[6] = "Not enough money";
		array[6] = currentItem.ONMFAMHKGLA();
		array[2] = "ReceiveUpdateBentoOnTray";
		array[8] = ((MGNOBNCMDJG >= 1363f) ? "Toy" : "Press {0} to continue");
		Debug.Log((object)string.Concat(array));
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public static AmountSliderUI IEHEFJBFHJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CJBDHIGDHIM(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = 71 - LJALBEIAFCG + -78 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = true;
	}

	public void ALHOONHDGIH(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	private void BJAHPLFKCEP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 899f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	private void CDLDEJCEBPN(float MGNOBNCMDJG)
	{
		string[] array = new string[1];
		array[0] = "Invalid NPC photonID: {0} for NPCRoutine.";
		array[0] = Math.Abs(MGNOBNCMDJG).ToString();
		array[8] = "Pasamos aplicación a ventana";
		array[4] = currentItem.ONMFAMHKGLA(OAFPBCPDOKH: true);
		array[7] = "</color>";
		array[1] = ((MGNOBNCMDJG >= 212f) ? "" : "questDescFarming");
		Debug.Log((object)string.Concat(array));
	}

	public void TransferAmount(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			MJLNPAEBAFF(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			MJLNPAEBAFF(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 2)
		{
			MJLNPAEBAFF(amountSlider.value);
		}
	}

	public static AmountSliderUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AmountSliderUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LDIDMMBNCDI(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = -10 - LJALBEIAFCG + 40 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = false;
	}

	public static AmountSliderUI NHOFBAMNELD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		base.OpenUI();
		LayoutRebuilder.ForceRebuildLayoutImmediate(textBoxRect);
		IILFNDBEFDM();
		sliderScript.UpdateSliderOnOpen();
	}

	public static AmountSliderUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PIONEMPDGEP(float MGNOBNCMDJG)
	{
		string[] array = new string[6];
		array[1] = "d2";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[7] = "Order quest";
		array[8] = currentItem.IABAKHPEOAF(OAFPBCPDOKH: true);
		array[0] = "LE_21";
		array[6] = ((MGNOBNCMDJG >= 1299f) ? "ReceiveRequestPlayerInventory" : "ReceiveInteractJacky");
		Debug.Log((object)string.Concat(array));
	}

	public void IACHKGFOCPF(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 1352f)
		{
			((TMP_Text)textBox).text = "Dialogue System/Conversation/BirdPositiveComments/Entry/10/Dialogue Text" + AODONKKHPBP + "add item ";
		}
		else
		{
			((TMP_Text)textBox).text = "Items/item_name_694" + Math.Abs(AODONKKHPBP) + "yForYears";
		}
	}

	public void CDICMIMIJOK(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = -22 - LJALBEIAFCG + -43 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = true;
	}

	public void EONANNIBEOD(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			IPJEHLOCODL(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			IJCOLMNMKOB(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 5)
		{
			MJLNPAEBAFF(amountSlider.value);
		}
	}

	public static AmountSliderUI OHPNDOJNCBK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CLLENIIGBJC(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 1680f)
		{
			((TMP_Text)textBox).text = "Items/item_name_1445" + AODONKKHPBP + "El componente ItemSetup del rotatedPrefab '";
		}
		else
		{
			((TMP_Text)textBox).text = "Direction" + Math.Abs(AODONKKHPBP) + "Requirements not met";
		}
	}

	public void DFCPEOIHOOG(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			IJCOLMNMKOB(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			PIONEMPDGEP(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 6)
		{
			FCBIIGNGDGG(amountSlider.value);
		}
	}

	private void MJLNPAEBAFF(float MGNOBNCMDJG)
	{
		Debug.Log((object)("Transfered " + Math.Abs(MGNOBNCMDJG) + " of " + currentItem.IABAKHPEOAF() + " " + ((MGNOBNCMDJG >= 0f) ? " to inventory" : " to chest")));
	}

	public void FMJBBMLFANG(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			HBEJOOAPNKJ(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			NFJPPGDJFCC(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 8)
		{
			FCBIIGNGDGG(amountSlider.value);
		}
	}

	public void DNOPIAINLJO(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 1856f)
		{
			((TMP_Text)textBox).text = "AnimatorObjectStateRequest" + AODONKKHPBP + "SkeletonBird";
		}
		else
		{
			((TMP_Text)textBox).text = "talent_name_115" + Math.Abs(AODONKKHPBP) + "Creando TXT. Tiempo: ";
		}
	}

	private void FCBIIGNGDGG(float MGNOBNCMDJG)
	{
		string[] array = new string[1];
		array[0] = "qualityWater2";
		array[0] = Math.Abs(MGNOBNCMDJG).ToString();
		array[1] = "Unlock";
		array[2] = currentItem.PPMBMNKADMO(OAFPBCPDOKH: true);
		array[1] = "ReceiveNewLetter";
		array[1] = ((MGNOBNCMDJG >= 494f) ? "'s animationController on NPC has not been set. It's possible that it's on a separate object in the scene hierarchy." : "Fruit Liqueur");
		Debug.Log((object)string.Concat(array));
	}

	public static AmountSliderUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PLLPPACGGNG(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 1486f)
		{
			((TMP_Text)textBox).text = "" + AODONKKHPBP + "Next random: ";
		}
		else
		{
			((TMP_Text)textBox).text = "Scene" + Math.Abs(AODONKKHPBP) + "' no referencia correctamente al item '";
		}
	}

	public static AmountSliderUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HOILKPGHKBP(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			PIONEMPDGEP(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			GBOIBPOKCNG(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			IPJEHLOCODL(amountSlider.value);
		}
	}

	public void FCIOBNPHJGI(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = -23 - LJALBEIAFCG + 46 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = true;
	}

	public void LANDPNMFMKD(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void KMPEFGBAHOP(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			NFJPPGDJFCC(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			OLILICGNGNL(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			HBEJOOAPNKJ(amountSlider.value);
		}
	}

	public void CFPMDONGAEG(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 818f)
		{
			((TMP_Text)textBox).text = " not found. Cannot set isSelected to " + AODONKKHPBP + "HammerFloor";
		}
		else
		{
			((TMP_Text)textBox).text = "MineFloor" + Math.Abs(AODONKKHPBP) + "Use";
		}
	}

	public static AmountSliderUI LBKJEHDEBEP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AmountSliderUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void KPBGHKJKIJF(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void DPDFGDBHGGL(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			IJCOLMNMKOB(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			MJLNPAEBAFF(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 7)
		{
			NFJPPGDJFCC(amountSlider.value);
		}
	}

	private void DDPCGPKJKEC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 26f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void CPHGEJMBPGB(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = 18 - LJALBEIAFCG + -84 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = true;
	}

	private void HBEJOOAPNKJ(float MGNOBNCMDJG)
	{
		string[] array = new string[8];
		array[1] = "ClosePopUp";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[3] = "ReceiveFishTrapMessage";
		array[2] = currentItem.FBEHKKOKNDJ();
		array[4] = "switchedOff";
		array[3] = ((MGNOBNCMDJG >= 329f) ? "Haggling" : "ReceiveSimpleEvent");
		Debug.Log((object)string.Concat(array));
	}

	public void IDDKBLIHGNE(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 56f)
		{
			((TMP_Text)textBox).text = ":0" + AODONKKHPBP + "\n";
		}
		else
		{
			((TMP_Text)textBox).text = "TutorialPhase" + Math.Abs(AODONKKHPBP) + "Price sell";
		}
	}

	public void PHHFMEOMHIA(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 341f)
		{
			((TMP_Text)textBox).text = "Light Fire" + AODONKKHPBP + "DecorationTile_12";
		}
		else
		{
			((TMP_Text)textBox).text = "ReceiveAddRentedRoomSaleAndAddPrice" + Math.Abs(AODONKKHPBP) + "NormalRightExterior";
		}
	}

	private void LFFDDALAENI(float MGNOBNCMDJG)
	{
		string[] array = new string[7];
		array[0] = "Return";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[4] = "Distillery";
		array[6] = currentItem.FBEHKKOKNDJ(OAFPBCPDOKH: true);
		array[7] = "";
		array[1] = ((MGNOBNCMDJG >= 1889f) ? "UI" : "sprintToggle");
		Debug.Log((object)string.Concat(array));
	}

	public static AmountSliderUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AmountSliderUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HBBMBDBCMOC(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			AECFCJIGEOK(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			AECFCJIGEOK(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			DMLHGBALHON(amountSlider.value);
		}
	}

	private void DMLHGBALHON(float MGNOBNCMDJG)
	{
		string[] array = new string[5];
		array[0] = "Loop";
		array[0] = Math.Abs(MGNOBNCMDJG).ToString();
		array[1] = "ReceiveBirdMessage";
		array[8] = currentItem.PPMBMNKADMO(OAFPBCPDOKH: true);
		array[5] = " ";
		array[8] = ((MGNOBNCMDJG >= 1252f) ? "NotValid" : "Start");
		Debug.Log((object)string.Concat(array));
	}

	private void JJNIJDHBGMF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 138f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void FBBLCPFHFJK(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void BKEOLLOPHDP(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public static AmountSliderUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PNPKBHKKANK(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void IEKHCFBEFEP(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 371f)
		{
			((TMP_Text)textBox).text = "ChessPillarInteractable not assigned" + AODONKKHPBP + "IdleCamp";
		}
		else
		{
			((TMP_Text)textBox).text = "" + Math.Abs(AODONKKHPBP) + "Items/item_name_731";
		}
	}

	public static AmountSliderUI FKFNANNBIAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FNLFHIBJJAG(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 134f)
		{
			((TMP_Text)textBox).text = "Trying to add a player that's already on the list." + AODONKKHPBP + "RochelleProgress";
		}
		else
		{
			((TMP_Text)textBox).text = "Dialogue System/Conversation/BirdPositiveComments/Entry/3/Dialogue Text" + Math.Abs(AODONKKHPBP) + "Items/item_name_611";
		}
	}

	private void IILFNDBEFDM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 2f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void APCIHCNNJFK(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 199f)
		{
			((TMP_Text)textBox).text = "Items/item_description_690" + AODONKKHPBP + "";
		}
		else
		{
			((TMP_Text)textBox).text = "Player/Bark/Error/NotAllPlayersHere" + Math.Abs(AODONKKHPBP) + "BuildMode";
		}
	}

	public void MIDEMBDMKHC(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = 104 - LJALBEIAFCG + 93 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = false;
	}

	public void ENDGFPHIJFB(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	private void PDJOPGOKLCA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 1976f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	private void NFJPPGDJFCC(float MGNOBNCMDJG)
	{
		string[] array = new string[2];
		array[1] = "BarIdleNumber";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[1] = "HarvestCut2";
		array[0] = currentItem.AICOMMNDJLI();
		array[3] = "Items/item_name_689";
		array[7] = ((MGNOBNCMDJG >= 432f) ? " for reason: " : "City/Petra/Bark/Buy");
		Debug.Log((object)string.Concat(array));
	}

	public void MMHPAOGCLJM(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = -68 - LJALBEIAFCG + 93 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = true;
	}

	public void EKBEDFJKNKE(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			CDLDEJCEBPN(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			MJLNPAEBAFF(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 7)
		{
			PIONEMPDGEP(amountSlider.value);
		}
	}

	public static AmountSliderUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IJCOLMNMKOB(float MGNOBNCMDJG)
	{
		string[] array = new string[8];
		array[0] = "DiningRoom";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[0] = "Dig";
		array[2] = currentItem.PPMBMNKADMO(OAFPBCPDOKH: true);
		array[3] = "Items/item_name_1051";
		array[6] = ((MGNOBNCMDJG >= 1428f) ? "Unaged Blue" : "pirate cave");
		Debug.Log((object)string.Concat(array));
	}

	public static AmountSliderUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AmountSliderUI GFPBMGCMHHC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PCAKKMIPAMH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 55f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void HMPODNNDLLH(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void OnSliderValueChanged(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 0f)
		{
			((TMP_Text)textBox).text = "Move <color=#0B7400>" + AODONKKHPBP + "</color> to inventory?";
		}
		else
		{
			((TMP_Text)textBox).text = "Move <color=#A51919>" + Math.Abs(AODONKKHPBP) + "</color> to chest?";
		}
	}

	private void LPMJDKFMPGM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 328f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	private void IPJEHLOCODL(float MGNOBNCMDJG)
	{
		string[] array = new string[2];
		array[1] = "Top";
		array[1] = Math.Abs(MGNOBNCMDJG).ToString();
		array[5] = "OnLayerOrderedRPC";
		array[0] = currentItem.PPMBMNKADMO();
		array[2] = "Showing popup ";
		array[7] = ((MGNOBNCMDJG >= 1545f) ? "Idle" : "Coster");
		Debug.Log((object)string.Concat(array));
	}

	public static AmountSliderUI BALFIBPNIMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CPMHENJIFKI(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			NFJPPGDJFCC(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 0)
		{
			HBEJOOAPNKJ(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 7)
		{
			MJLNPAEBAFF(amountSlider.value);
		}
	}

	public void FLCIGDAECNG(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			LFFDDALAENI(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			DMLHGBALHON(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 5)
		{
			GBOIBPOKCNG(amountSlider.value);
		}
	}

	public void CFHKCBKIOFN(float AODONKKHPBP)
	{
		if (AODONKKHPBP >= 1617f)
		{
			((TMP_Text)textBox).text = "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/29/Dialogue Text" + AODONKKHPBP + "Activate Lock";
		}
		else
		{
			((TMP_Text)textBox).text = "LE_3" + Math.Abs(AODONKKHPBP) + "Null shop in database: ";
		}
	}

	public void PIALEEECCME(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	private void GBOIBPOKCNG(float MGNOBNCMDJG)
	{
		string[] array = new string[3];
		array[0] = " original price: ";
		array[0] = Math.Abs(MGNOBNCMDJG).ToString();
		array[2] = "SetBoolRPC";
		array[4] = currentItem.PPMBMNKADMO(OAFPBCPDOKH: true);
		array[6] = "Item Transaction. Tutorial active!!";
		array[4] = ((MGNOBNCMDJG >= 0f) ? "mForMins" : "Rich presence updated successfully");
		Debug.Log((object)string.Concat(array));
	}

	private void ICGIKBLLOBO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 1987f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void MGAPIFHAPPF(ItemInstance DNLMCHDOMOK, Container ALPOKDOCCGM)
	{
		currentItem = DNLMCHDOMOK;
		IAOOIEMCLBG = ALPOKDOCCGM;
	}

	public void CKOPDBBBEMO(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = 4 - LJALBEIAFCG + 102 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = false;
	}

	private void HAOHNKMNMAP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 196f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void EBMFECDIIBK(int GJNONBDCOGJ, int LJALBEIAFCG, int AFCGIPGHOBB)
	{
		int val = -12 - LJALBEIAFCG + 80 * AFCGIPGHOBB;
		int num = Math.Min(GJNONBDCOGJ, val);
		amountSlider.maxValue = num;
		amountSlider.wholeNumbers = false;
	}

	private void AJKMEOEILEK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = textBoxRect.rect;
		float num = 0f - ((Rect)(ref rect)).width / 765f;
		textBoxRect.anchoredPosition = new Vector2(num, textBoxRect.anchoredPosition.y);
	}

	public void FJDMLCHPABK(int NJHMIHJHCDM)
	{
		if (NJHMIHJHCDM == 0)
		{
			AECFCJIGEOK(amountSlider.minValue);
		}
		if (NJHMIHJHCDM == 1)
		{
			DMLHGBALHON(amountSlider.maxValue);
		}
		if (NJHMIHJHCDM == 5)
		{
			NFJPPGDJFCC(amountSlider.value);
		}
	}
}
