using System;
using System.Collections.Generic;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsContext : UIWindow
{
	private static ButtonsContext IADEMLIIDPC;

	private static ButtonsContext BBINLIGKIPE;

	public bool update = true;

	[SerializeField]
	private CraftingAction craftingAction;

	[SerializeField]
	private GameObject cropInfoPanel;

	[SerializeField]
	private SegmentedProgressBar cropGrowthBar;

	[SerializeField]
	private SegmentedProgressBar cropWaterBar;

	[SerializeField]
	private GameObject cropWaterBarContainer;

	[SerializeField]
	private Sprite seed;

	[SerializeField]
	private Sprite leaf;

	[SerializeField]
	private Sprite apple;

	[SerializeField]
	private Image growthLeftIcon;

	[SerializeField]
	private Image growthRightIcon;

	[SerializeField]
	private SlotUI cropSlotUI;

	[SerializeField]
	private ChickensInsideHenHouseUI chickensInsideHenHouse;

	[SerializeField]
	private GameObject beerTapBar;

	[SerializeField]
	private FeederContextUI foodFeeder3ContextUI;

	[SerializeField]
	private FeederContextUI foodFeeder18ContextUI;

	[SerializeField]
	private FeederContextUI waterFeederContextUI;

	[SerializeField]
	private ButtonsContextPanel[] buttonsList;

	private string[] GAMKEOPHBKO;

	private int ALNLMHOHACL;

	private Vector3 BPLKIPALDNP;

	private ActionElementMap KBMOOCGHDKH;

	private Controller JOOBIKDBBKE;

	private static Sprite HEJNLFCKOKE;

	public void KMELAPPABIN(int BGIHHIKDCEI, int AGOAHFEOEAE)
	{
		if (!((Component)waterFeederContextUI).gameObject.activeSelf)
		{
			((Component)waterFeederContextUI).gameObject.SetActive(false);
		}
		waterFeederContextUI.slot.fillAmount = (float)BGIHHIKDCEI / (float)AGOAHFEOEAE;
	}

	public void DGCNABGBDJE(int BGIHHIKDCEI, int AGOAHFEOEAE)
	{
		if (!((Component)waterFeederContextUI).gameObject.activeSelf)
		{
			((Component)waterFeederContextUI).gameObject.SetActive(true);
		}
		waterFeederContextUI.slot.fillAmount = (float)BGIHHIKDCEI / (float)AGOAHFEOEAE;
	}

	private void GDLGGIJKHFK(ActionType JKJJKBAFNMO, string CAEDMEDBEGI)
	{
		if (ALNLMHOHACL >= buttonsList.Length)
		{
			return;
		}
		if (GAMKEOPHBKO[ALNLMHOHACL] != CAEDMEDBEGI)
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				POBPKHJOPCH(JKJJKBAFNMO, CAEDMEDBEGI);
			}
			else
			{
				AKAKJLNNMBD(JKJJKBAFNMO, CAEDMEDBEGI);
			}
			GAMKEOPHBKO[ALNLMHOHACL] = CAEDMEDBEGI;
		}
		if (!((Component)buttonsList[ALNLMHOHACL]).gameObject.activeSelf)
		{
			((Component)buttonsList[ALNLMHOHACL]).gameObject.SetActive(true);
		}
		ALNLMHOHACL++;
		if (!LKOJBFMGMAE)
		{
			OpenUI();
		}
	}

	public void ResetButtons()
	{
		if (!IsOpen())
		{
			return;
		}
		CloseUI();
		for (int i = 0; i < buttonsList.Length; i++)
		{
			if (((Component)buttonsList[i]).gameObject.activeSelf)
			{
				GAMKEOPHBKO[i] = "";
				((Component)buttonsList[i]).gameObject.SetActive(false);
			}
		}
		ALNLMHOHACL = 0;
	}

	protected override void Awake()
	{
		base.Awake();
		if (base.JIIGOACEIKL == 1)
		{
			IADEMLIIDPC = this;
		}
		else if (base.JIIGOACEIKL == 2)
		{
			BBINLIGKIPE = this;
		}
	}

	public static void CPIIFPCIJEP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.MKDNBBNPMHE();
		}
		else if (Object.op_Implicit((Object)(object)BBINLIGKIPE))
		{
			BBINLIGKIPE.MKDNBBNPMHE();
		}
	}

	public void EAGIIBPKFAF(bool MDIKPGGBNLI, ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true)
	{
		if (cropInfoPanel.activeSelf != MDIKPGGBNLI)
		{
			cropInfoPanel.SetActive(MDIKPGGBNLI);
		}
		if (!MDIKPGGBNLI)
		{
			return;
		}
		if (DNLMCHDOMOK != null || Item.MLBOMGHINCA(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.LCHJGCHDHFO())
			{
				cropSlotUI.IHENCGDNPBL.MEODNPFJDMH();
			}
			cropSlotUI.IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
			cropSlotUI.JOGLJKIFGNL();
		}
		cropGrowthBar.AHPOPCJNGGI(LFKJEGFJNIP, HDLEOKEFLBM);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(true);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(false);
			}
			cropWaterBar.ELOCEEBLMLC(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
	}

	public void ResetWaterFeederBar()
	{
		((Component)waterFeederContextUI).gameObject.SetActive(false);
	}

	private void GJHLDICNKNE(int JIIGOACEIKL, int AOMKKCKBKCC)
	{
		DKCMJENPPFA();
	}

	public void HMHHMFGPHNA()
	{
		((Component)foodFeeder3ContextUI).gameObject.SetActive(true);
		((Component)foodFeeder18ContextUI).gameObject.SetActive(false);
	}

	private string MAMPPHNLMDH(string OKNOJJEFEBE)
	{
		InputUtils.AAPOEKOONKL(base.JIIGOACEIKL, (ControllerType)0, OKNOJJEFEBE, out var INAPMPEEDPO, NGDDAAFCDIL: false);
		if (INAPMPEEDPO != "None")
		{
			return "[" + (string.IsNullOrEmpty(LocalisationSystem.Get(INAPMPEEDPO)) ? INAPMPEEDPO : LocalisationSystem.Get(INAPMPEEDPO)) + "] ";
		}
		return "";
	}

	private void HCKMHIHALBL()
	{
		TutorialManager instance = TutorialManager.GGFJGHHHEJC;
		instance.OnPopUp = (Action)Delegate.Combine(instance.OnPopUp, new Action(CloseUI));
		TutorialManager instance2 = TutorialManager.GGFJGHHHEJC;
		instance2.OnMinimise = (Action)Delegate.Combine(instance2.OnMinimise, new Action(IDLAGJNLPJL));
	}

	public void NMJDALIOPIO(Timer LHACKABKHDN)
	{
		if (!beerTapBar.gameObject.activeSelf)
		{
			beerTapBar.gameObject.SetActive(true);
		}
		craftingAction.KBFFOEOCAGI(LHACKABKHDN);
	}

	public void SoftResetButtons()
	{
		ALNLMHOHACL = 0;
	}

	public void EGBAEODEMAL(int BGIHHIKDCEI, int AGOAHFEOEAE)
	{
		if (!((Component)waterFeederContextUI).gameObject.activeSelf)
		{
			((Component)waterFeederContextUI).gameObject.SetActive(false);
		}
		waterFeederContextUI.slot.fillAmount = (float)BGIHHIKDCEI / (float)AGOAHFEOEAE;
	}

	public void SetFoodFeederBar(int BGIHHIKDCEI, int AGOAHFEOEAE)
	{
		if (AGOAHFEOEAE <= 3)
		{
			if (!((Component)foodFeeder3ContextUI).gameObject.activeSelf)
			{
				((Component)foodFeeder3ContextUI).gameObject.SetActive(true);
			}
			foodFeeder3ContextUI.slot.fillAmount = (float)BGIHHIKDCEI / (float)AGOAHFEOEAE;
		}
		else
		{
			if (!((Component)foodFeeder18ContextUI).gameObject.activeSelf)
			{
				((Component)foodFeeder18ContextUI).gameObject.SetActive(true);
			}
			foodFeeder18ContextUI.slot.fillAmount = (float)BGIHHIKDCEI / (float)AGOAHFEOEAE;
		}
	}

	private void AFHGDCBNALO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.parent.position = Utils.BMBMPKNANAC(BPLKIPALDNP);
	}

	public static void ResetAllCrafterAction()
	{
		IADEMLIIDPC.MKDNBBNPMHE();
		BBINLIGKIPE.MKDNBBNPMHE();
	}

	private void OnDisable()
	{
		if ((Object)(object)TutorialManager.GGFJGHHHEJC != (Object)null)
		{
			TutorialManager instance = TutorialManager.GGFJGHHHEJC;
			instance.OnPopUp = (Action)Delegate.Remove(instance.OnPopUp, new Action(CloseUI));
			TutorialManager instance2 = TutorialManager.GGFJGHHHEJC;
			instance2.OnMinimise = (Action)Delegate.Remove(instance2.OnMinimise, new Action(OpenUI));
		}
	}

	public static ButtonsContext GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void SetChickensInsideHenHouse(List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		if (!((Component)chickensInsideHenHouse).gameObject.activeSelf)
		{
			((Component)chickensInsideHenHouse).gameObject.SetActive(true);
		}
		chickensInsideHenHouse.ShowChickens(base.JIIGOACEIKL, BBEDNMLFDLK, AGOAHFEOEAE, BMEGJBEPFKB);
	}

	private string EHHMMJIICCA(string OKNOJJEFEBE)
	{
		InputUtils.AAPOEKOONKL(base.JIIGOACEIKL, (ControllerType)0, OKNOJJEFEBE, out var INAPMPEEDPO, NGDDAAFCDIL: false, "Incorrect room mode {0}");
		if (INAPMPEEDPO != "On Simple Event ")
		{
			return "PlayerBed" + (string.IsNullOrEmpty(LocalisationSystem.Get(INAPMPEEDPO)) ? INAPMPEEDPO : LocalisationSystem.Get(INAPMPEEDPO)) + "Dialogue System/Conversation/NeutralInTavern/Entry/3/Dialogue Text";
		}
		return "Player/Bark/Fishing/NoFish";
	}

	protected override void Update()
	{
		base.Update();
		craftingAction.SetProgressBarValue();
	}

	public void SetBeerTapBar(Timer LHACKABKHDN)
	{
		if (!beerTapBar.gameObject.activeSelf)
		{
			beerTapBar.gameObject.SetActive(true);
		}
		craftingAction.SetCrafterTimer(LHACKABKHDN);
	}

	public string GetSpriteTagWithActionName(ActionType JKJJKBAFNMO, int KKANDELPDKP = 150)
	{
		if (JKJJKBAFNMO.Equals(ActionType.PrevNext))
		{
			string text = "<size=" + KKANDELPDKP + "%>";
			HEJNLFCKOKE = GetSpriteWithActionType(ActionType.PreviousItem);
			if ((Object)(object)HEJNLFCKOKE != (Object)null)
			{
				text = text + "<sprite name=" + ((Object)HEJNLFCKOKE).name + ">";
			}
			HEJNLFCKOKE = GetSpriteWithActionType(ActionType.NextItem);
			if ((Object)(object)HEJNLFCKOKE != (Object)null)
			{
				text = text + "<sprite name=" + ((Object)HEJNLFCKOKE).name + ">";
			}
			text += "</size>";
			if ((Object)(object)HEJNLFCKOKE != (Object)null || (Object)(object)HEJNLFCKOKE != (Object)null)
			{
				return text;
			}
			return JKJJKBAFNMO.ToString();
		}
		HEJNLFCKOKE = GetSpriteWithActionType(JKJJKBAFNMO);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			return "<size=" + KKANDELPDKP + "%><sprite name=" + ((Object)HEJNLFCKOKE).name + "></size>";
		}
		return JKJJKBAFNMO.ToString();
	}

	public static void NHECENBLBAH(int JIIGOACEIKL, ActionType JKJJKBAFNMO, string CAEDMEDBEGI)
	{
		if (JIIGOACEIKL == 0)
		{
			IADEMLIIDPC.GDLGGIJKHFK(JKJJKBAFNMO, CAEDMEDBEGI);
		}
		else
		{
			BBINLIGKIPE.GDLGGIJKHFK(JKJJKBAFNMO, CAEDMEDBEGI);
		}
	}

	public void ResetFoodFeederBar()
	{
		((Component)foodFeeder3ContextUI).gameObject.SetActive(false);
		((Component)foodFeeder18ContextUI).gameObject.SetActive(false);
	}

	public void ResetBeerTapBar()
	{
		beerTapBar.gameObject.SetActive(false);
	}

	public static void KBPDNGECKJN(int JIIGOACEIKL, Vector3 BKFLNOJNOLI)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.JBFDJKCKCPJ(BKFLNOJNOLI);
		}
		else
		{
			BBINLIGKIPE.AECCMKBENLO(BKFLNOJNOLI);
		}
	}

	public void OOFBLCGEFPM(List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		if (!((Component)chickensInsideHenHouse).gameObject.activeSelf)
		{
			((Component)chickensInsideHenHouse).gameObject.SetActive(true);
		}
		chickensInsideHenHouse.KNPLHPJGMKB(base.JIIGOACEIKL, BBEDNMLFDLK, AGOAHFEOEAE, BMEGJBEPFKB);
	}

	public void OKNJNHNCKHA()
	{
		if ((Object)(object)craftingAction != (Object)null)
		{
			craftingAction.AADAAFACMDH();
		}
	}

	public void PEFFCIKOKND()
	{
		((Component)foodFeeder3ContextUI).gameObject.SetActive(false);
		((Component)foodFeeder18ContextUI).gameObject.SetActive(true);
	}

	private void OJBBJDCDIEK(int JIIGOACEIKL, int AOMKKCKBKCC)
	{
		ResetButtons();
	}

	public string EDGPALOLLAA(ActionType JKJJKBAFNMO, int KKANDELPDKP = 150)
	{
		if (JKJJKBAFNMO.Equals(ActionType.Hold))
		{
			string text = "Left" + KKANDELPDKP + "Disabled";
			HEJNLFCKOKE = GetSpriteWithActionType(ActionType.Use);
			if ((Object)(object)HEJNLFCKOKE != (Object)null)
			{
				text = text + "itemRoseWine" + ((Object)HEJNLFCKOKE).name + "Could not find ControllerInfo with nameID: ";
			}
			HEJNLFCKOKE = GetSpriteWithActionType(ActionType.PreviousItem);
			if ((Object)(object)HEJNLFCKOKE != (Object)null)
			{
				text = text + "LE_15" + ((Object)HEJNLFCKOKE).name + "https://www.isolatedgames.com/bug-report/index.php";
			}
			text += "ReceiveSetDirection";
			if ((Object)(object)HEJNLFCKOKE != (Object)null || (Object)(object)HEJNLFCKOKE != (Object)null)
			{
				return text;
			}
			return JKJJKBAFNMO.ToString();
		}
		HEJNLFCKOKE = GetSpriteWithActionType(JKJJKBAFNMO);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			string[] array = new string[2];
			array[0] = "Random";
			array[0] = KKANDELPDKP.ToString();
			array[8] = " ";
			array[7] = ((Object)HEJNLFCKOKE).name;
			array[5] = ") (rep: ";
			return string.Concat(array);
		}
		return JKJJKBAFNMO.ToString();
	}

	private void OMPAHBFCNLM(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		ResetButtons();
	}

	public void EMJBNNPGBIB(float COAPHJJHNIO)
	{
		if (!beerTapBar.gameObject.activeSelf)
		{
			beerTapBar.gameObject.SetActive(false);
		}
		craftingAction.DBKEGHGBEFA(COAPHJJHNIO);
	}

	private void FIFBIECCMLA()
	{
		if (((Component)craftingAction).gameObject.activeSelf)
		{
			((Component)craftingAction).gameObject.SetActive(false);
		}
	}

	public static void AddButton(int JIIGOACEIKL, ActionType JKJJKBAFNMO, string CAEDMEDBEGI)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.GDLGGIJKHFK(JKJJKBAFNMO, CAEDMEDBEGI);
		}
		else
		{
			BBINLIGKIPE.GDLGGIJKHFK(JKJJKBAFNMO, CAEDMEDBEGI);
		}
	}

	public void AGMPGNAAIHK()
	{
		if ((Object)(object)craftingAction != (Object)null)
		{
			craftingAction.EAAIENJGEIP();
		}
	}

	protected override void Start()
	{
		base.Start();
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
		GAMKEOPHBKO = new string[buttonsList.Length];
		ResetButtons();
		ActionBarInventory player = ActionBarInventory.GetPlayer(base.JIIGOACEIKL);
		player.OnSelectionChanged = (Action<int, int>)Delegate.Combine(player.OnSelectionChanged, new Action<int, int>(OJBBJDCDIEK));
		MKDNBBNPMHE();
		ResetBeerTapBar();
	}

	public void NMENADOBDCP(List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		if (!((Component)chickensInsideHenHouse).gameObject.activeSelf)
		{
			((Component)chickensInsideHenHouse).gameObject.SetActive(true);
		}
		chickensInsideHenHouse.HEIIBJEEBCJ(base.JIIGOACEIKL, BBEDNMLFDLK, AGOAHFEOEAE, BMEGJBEPFKB);
	}

	public Sprite GetSpriteWithActionType(ActionType JKJJKBAFNMO)
	{
		JOOBIKDBBKE = PlayerInputs.GetPlayerControllers(base.JIIGOACEIKL).GetLastActiveController((ControllerType)2);
		if (JOOBIKDBBKE == null)
		{
			JOOBIKDBBKE = ReInput.controllers.GetLastActiveController((ControllerType)2);
		}
		KBMOOCGHDKH = PlayerInputs.GetPlayerControllers(base.JIIGOACEIKL).maps.GetFirstElementMapWithAction(JOOBIKDBBKE, JKJJKBAFNMO.ToString(), false);
		if (KBMOOCGHDKH != null)
		{
			return GetSpriteWithElementName(KBMOOCGHDKH.elementIdentifierName, JOOBIKDBBKE);
		}
		return null;
	}

	public string BBJHLNPOKDB(string FFBDILCCPIP, Controller JOOBIKDBBKE, int KKANDELPDKP = 150)
	{
		if (string.IsNullOrEmpty(FFBDILCCPIP))
		{
			return "OnlinePlayer";
		}
		if (FFBDILCCPIP.Equals("itemPeach"))
		{
			return "Miners/Mine/Ferro/Bomb" + KKANDELPDKP + "LE_3";
		}
		if (FFBDILCCPIP.Equals("cameraZoom2"))
		{
			return "/" + KKANDELPDKP + "Error in ProceduralMine.OnPlayerSleep: ";
		}
		if (FFBDILCCPIP.Contains("Player with actor number {0} removed from Players dictionary. Entries left: {1}") && FFBDILCCPIP.Contains("No path to psai soundtrack file set!") && FFBDILCCPIP.Contains("UI2") && FFBDILCCPIP.Contains("Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/3/Dialogue Text"))
		{
			return "UINextPage" + KKANDELPDKP + "Items/item_description_1036";
		}
		if (FFBDILCCPIP.Contains("NinjaChallengeEvent/ComensalesBark") && FFBDILCCPIP.Contains("ReceiveItemsFromOtherPlayer") && FFBDILCCPIP.Contains("1") && FFBDILCCPIP.Contains("Dialogue System/Conversation/Gass_Quest/Entry/46/Dialogue Text"))
		{
			return "Direction" + KKANDELPDKP + "setDefaultSettings";
		}
		HEJNLFCKOKE = GetSpriteWithElementName(FFBDILCCPIP, JOOBIKDBBKE);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			string[] array = new string[5];
			array[1] = "Could not find item with id: ";
			array[0] = KKANDELPDKP.ToString();
			array[2] = "Offer";
			array[8] = ((Object)HEJNLFCKOKE).name;
			array[6] = "Eat";
			return string.Concat(array);
		}
		return FFBDILCCPIP;
	}

	public string GetSpriteTagWithElementName(string FFBDILCCPIP, Controller JOOBIKDBBKE, int KKANDELPDKP = 150)
	{
		if (string.IsNullOrEmpty(FFBDILCCPIP))
		{
			return "";
		}
		if (FFBDILCCPIP.Equals("Left Stick Y / Left Stick X"))
		{
			return "<size=" + KKANDELPDKP + "%><sprite name=LeftStick></size>";
		}
		if (FFBDILCCPIP.Equals("Right Stick Y / Right Stick X"))
		{
			return "<size=" + KKANDELPDKP + "%><sprite name=RightStick></size>";
		}
		if (FFBDILCCPIP.Contains("Left Stick Left") && FFBDILCCPIP.Contains("Left Stick Right") && FFBDILCCPIP.Contains("Left Stick Up") && FFBDILCCPIP.Contains("Left Stick Down"))
		{
			return "<size=" + KKANDELPDKP + "%><sprite name=LeftStick></size>";
		}
		if (FFBDILCCPIP.Contains("Right Stick Left") && FFBDILCCPIP.Contains("Right Stick Right") && FFBDILCCPIP.Contains("Right Stick Up") && FFBDILCCPIP.Contains("Right Stick Down"))
		{
			return "<size=" + KKANDELPDKP + "%><sprite name=RightStick></size>";
		}
		HEJNLFCKOKE = GetSpriteWithElementName(FFBDILCCPIP, JOOBIKDBBKE);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			return "<size=" + KKANDELPDKP + "%><sprite name=" + ((Object)HEJNLFCKOKE).name + "></size>";
		}
		return FFBDILCCPIP;
	}

	private void POBPKHJOPCH(ActionType JKJJKBAFNMO, string CAEDMEDBEGI)
	{
		if (JKJJKBAFNMO == ActionType.Hold)
		{
			JKJJKBAFNMO = ActionType.Interact;
		}
		((TMP_Text)buttonsList[ALNLMHOHACL].textMeshProUGUI).text = "";
		TextMeshProUGUI textMeshProUGUI = buttonsList[ALNLMHOHACL].textMeshProUGUI;
		((TMP_Text)textMeshProUGUI).text = ((TMP_Text)textMeshProUGUI).text + GetSpriteTagWithActionName(JKJJKBAFNMO, 125);
		TextMeshProUGUI textMeshProUGUI2 = buttonsList[ALNLMHOHACL].textMeshProUGUI;
		((TMP_Text)textMeshProUGUI2).text = ((TMP_Text)textMeshProUGUI2).text + " " + CAEDMEDBEGI;
	}

	public void HideAgingRank()
	{
		if ((Object)(object)craftingAction != (Object)null)
		{
			craftingAction.HideAgingRank();
		}
	}

	private void AKAKJLNNMBD(ActionType JKJJKBAFNMO, string CAEDMEDBEGI)
	{
		if (JKJJKBAFNMO == ActionType.Hold)
		{
			JKJJKBAFNMO = ActionType.Interact;
		}
		((TMP_Text)buttonsList[ALNLMHOHACL].textMeshProUGUI).text = MAMPPHNLMDH(JKJJKBAFNMO.ToString()) + " " + CAEDMEDBEGI;
	}

	public void DKCMJENPPFA()
	{
		if (!BGLJFMHCFJF())
		{
			return;
		}
		CloseUI();
		for (int i = 0; i < buttonsList.Length; i++)
		{
			if (((Component)buttonsList[i]).gameObject.activeSelf)
			{
				GAMKEOPHBKO[i] = "Accept order";
				((Component)buttonsList[i]).gameObject.SetActive(false);
			}
		}
		ALNLMHOHACL = 1;
	}

	public string KEFAJLKDHEC(string FFBDILCCPIP, Controller JOOBIKDBBKE, int KKANDELPDKP = 150)
	{
		if (string.IsNullOrEmpty(FFBDILCCPIP))
		{
			return "HalloweenEvent";
		}
		if (FFBDILCCPIP.Equals("Share"))
		{
			return "[MapChest] (" + KKANDELPDKP + "questDescCraftPorridge";
		}
		if (FFBDILCCPIP.Equals("mForMins"))
		{
			return "Drunk" + KKANDELPDKP + "Style";
		}
		if (FFBDILCCPIP.Contains("Dialogue System/Conversation/Rowdy/Entry/7/Dialogue Text") && FFBDILCCPIP.Contains("OnlinePlayer") && FFBDILCCPIP.Contains("Items/item_description_1105") && FFBDILCCPIP.Contains("Fire Loop source NULL!!!"))
		{
			return "ReceiveIdleAtTable" + KKANDELPDKP + "itemGreenbean";
		}
		if (FFBDILCCPIP.Contains("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/30/Dialogue Text") && FFBDILCCPIP.Contains("Select") && FFBDILCCPIP.Contains("LE_10") && FFBDILCCPIP.Contains("Items/item_name_1118"))
		{
			return " for user " + KKANDELPDKP + "";
		}
		HEJNLFCKOKE = GetSpriteWithElementName(FFBDILCCPIP, JOOBIKDBBKE);
		if ((Object)(object)HEJNLFCKOKE != (Object)null)
		{
			string[] array = new string[7];
			array[0] = "Invalid tavern floor {0}";
			array[0] = KKANDELPDKP.ToString();
			array[0] = "SalonDelTrono/TweekTalk";
			array[3] = ((Object)HEJNLFCKOKE).name;
			array[3] = "";
			return string.Concat(array);
		}
		return FFBDILCCPIP;
	}

	private void IAGIEBHBLNO(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		ResetButtons();
	}

	public void ShowCropInfoPanel(bool MDIKPGGBNLI, ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true)
	{
		if (cropInfoPanel.activeSelf != MDIKPGGBNLI)
		{
			cropInfoPanel.SetActive(MDIKPGGBNLI);
		}
		if (!MDIKPGGBNLI)
		{
			return;
		}
		if (DNLMCHDOMOK != null || Item.MLBOMGHINCA(DNLMCHDOMOK.LHBPOPOIFLE(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.KPINNBKMOMO())
			{
				cropSlotUI.IHENCGDNPBL.MEODNPFJDMH(CDPAMNIPPEC: false);
			}
			cropSlotUI.IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK);
			cropSlotUI.UpdateSlot();
		}
		cropGrowthBar.SetSegmentCount(LFKJEGFJNIP, HDLEOKEFLBM);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(false);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(true);
			}
			cropWaterBar.SetSegmentCount(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
	}

	private void HMOMBAFIJAI()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		if ((Object)(object)BBINLIGKIPE == (Object)(object)this)
		{
			BBINLIGKIPE = null;
		}
	}

	private void AECCMKBENLO(Vector3 BKFLNOJNOLI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BPLKIPALDNP = BKFLNOJNOLI;
	}

	public void SetCrafterAction(ItemInstanceAmount IAIHNNNGNKH)
	{
		if (!((Component)craftingAction).gameObject.activeSelf)
		{
			((Component)craftingAction).gameObject.SetActive(true);
		}
		craftingAction.SetItemInstanceAmount(base.JIIGOACEIKL, IAIHNNNGNKH);
	}

	public void SetWaterFeederBar(int BGIHHIKDCEI, int AGOAHFEOEAE)
	{
		if (!((Component)waterFeederContextUI).gameObject.activeSelf)
		{
			((Component)waterFeederContextUI).gameObject.SetActive(true);
		}
		waterFeederContextUI.slot.fillAmount = (float)BGIHHIKDCEI / (float)AGOAHFEOEAE;
	}

	public static void ResetCrafterAction(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.MKDNBBNPMHE();
		}
		else if (Object.op_Implicit((Object)(object)BBINLIGKIPE))
		{
			BBINLIGKIPE.MKDNBBNPMHE();
		}
	}

	public void ResetChickensInsideHenHouse()
	{
		((Component)chickensInsideHenHouse).gameObject.SetActive(false);
	}

	public void SetBeerTapBar(float COAPHJJHNIO)
	{
		if (!beerTapBar.gameObject.activeSelf)
		{
			beerTapBar.gameObject.SetActive(true);
		}
		craftingAction.SetCrafterProgress(COAPHJJHNIO);
	}

	public static Sprite GetSpriteWithElementName(string FFBDILCCPIP, Controller JOOBIKDBBKE)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if (JOOBIKDBBKE != null && (int)JOOBIKDBBKE.type != 2)
		{
			return ControllersDatabaseAccessor.GetController("Xbox").GLOIGJFJGME(FFBDILCCPIP);
		}
		if (JOOBIKDBBKE != null && (JOOBIKDBBKE.name.Contains("Sony DualShock") || JOOBIKDBBKE.name.Contains("Sony DualSense")))
		{
			return ControllersDatabaseAccessor.GetController("DualShock").GLOIGJFJGME(FFBDILCCPIP);
		}
		HEJNLFCKOKE = ControllersDatabaseAccessor.GetController("Xbox").GLOIGJFJGME(FFBDILCCPIP);
		if ((Object)(object)HEJNLFCKOKE == (Object)null)
		{
			HEJNLFCKOKE = ControllersDatabaseAccessor.GetController("DualShock").GLOIGJFJGME(FFBDILCCPIP);
		}
		return HEJNLFCKOKE;
	}

	private void MKDNBBNPMHE()
	{
		if (((Component)craftingAction).gameObject.activeSelf)
		{
			((Component)craftingAction).gameObject.SetActive(false);
		}
	}

	private void OnDestroy()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		if ((Object)(object)BBINLIGKIPE == (Object)(object)this)
		{
			BBINLIGKIPE = null;
		}
	}

	public void INILGGIBHKF(ItemInstanceAmount IAIHNNNGNKH)
	{
		if (!((Component)craftingAction).gameObject.activeSelf)
		{
			((Component)craftingAction).gameObject.SetActive(false);
		}
		craftingAction.CPOEABKLOKP(base.JIIGOACEIKL, IAIHNNNGNKH);
	}

	private void LateUpdate()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.parent.position = Utils.BMBMPKNANAC(BPLKIPALDNP);
	}

	public void NJOLGGEIFFC()
	{
		beerTapBar.gameObject.SetActive(true);
	}

	private void IMPCCGDOFOH(ActionType JKJJKBAFNMO, string CAEDMEDBEGI)
	{
		if (JKJJKBAFNMO == ActionType.Hold)
		{
			JKJJKBAFNMO = ActionType.Interact;
		}
		((TMP_Text)buttonsList[ALNLMHOHACL].textMeshProUGUI).text = "BarkActor";
		TextMeshProUGUI textMeshProUGUI = buttonsList[ALNLMHOHACL].textMeshProUGUI;
		((TMP_Text)textMeshProUGUI).text = ((TMP_Text)textMeshProUGUI).text + GetSpriteTagWithActionName(JKJJKBAFNMO, 84);
		TextMeshProUGUI textMeshProUGUI2 = buttonsList[ALNLMHOHACL].textMeshProUGUI;
		((TMP_Text)textMeshProUGUI2).text = ((TMP_Text)textMeshProUGUI2).text + "ReceiveDeletedLetterIndex" + CAEDMEDBEGI;
	}

	public static void IJKLIHJIOEN(int JIIGOACEIKL, ActionType JKJJKBAFNMO, string CAEDMEDBEGI)
	{
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.GDLGGIJKHFK(JKJJKBAFNMO, CAEDMEDBEGI);
		}
		else
		{
			BBINLIGKIPE.GDLGGIJKHFK(JKJJKBAFNMO, CAEDMEDBEGI);
		}
	}

	public void GFAAGFCIHKI(List<AnimalNPC> BBEDNMLFDLK, int AGOAHFEOEAE, ChickenNPC BMEGJBEPFKB)
	{
		if (!((Component)chickensInsideHenHouse).gameObject.activeSelf)
		{
			((Component)chickensInsideHenHouse).gameObject.SetActive(false);
		}
		chickensInsideHenHouse.FFEDPNCKHEJ(base.JIIGOACEIKL, BBEDNMLFDLK, AGOAHFEOEAE, BMEGJBEPFKB);
	}

	public static void SetPosition(int JIIGOACEIKL, Vector3 BKFLNOJNOLI)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (JIIGOACEIKL == 1)
		{
			IADEMLIIDPC.JBFDJKCKCPJ(BKFLNOJNOLI);
		}
		else
		{
			BBINLIGKIPE.JBFDJKCKCPJ(BKFLNOJNOLI);
		}
	}

	private void OnEnable()
	{
		TutorialManager instance = TutorialManager.GGFJGHHHEJC;
		instance.OnPopUp = (Action)Delegate.Combine(instance.OnPopUp, new Action(CloseUI));
		TutorialManager instance2 = TutorialManager.GGFJGHHHEJC;
		instance2.OnMinimise = (Action)Delegate.Combine(instance2.OnMinimise, new Action(OpenUI));
	}

	public void ShowAgingRank()
	{
		if ((Object)(object)craftingAction != (Object)null)
		{
			craftingAction.ShowAgingRank();
		}
	}

	public void CKLCLKHBKKG(bool MDIKPGGBNLI, ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true)
	{
		if (cropInfoPanel.activeSelf != MDIKPGGBNLI)
		{
			cropInfoPanel.SetActive(MDIKPGGBNLI);
		}
		if (!MDIKPGGBNLI)
		{
			return;
		}
		if (DNLMCHDOMOK != null || Item.MLBOMGHINCA(DNLMCHDOMOK.PHGLMBIEOMK(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.KPINNBKMOMO())
			{
				cropSlotUI.IHENCGDNPBL.FMEPMEKLHIJ();
			}
			cropSlotUI.IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
			cropSlotUI.JOGLJKIFGNL();
		}
		cropGrowthBar.ELOCEEBLMLC(LFKJEGFJNIP, HDLEOKEFLBM);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(false);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(true);
			}
			cropWaterBar.DJGGLJIFPAB(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
	}

	public void EHMLIFAMGFI()
	{
		((Component)chickensInsideHenHouse).gameObject.SetActive(false);
	}

	private void JBFDJKCKCPJ(Vector3 BKFLNOJNOLI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BPLKIPALDNP = BKFLNOJNOLI;
	}

	public static void JPOLMCJLGFK()
	{
		IADEMLIIDPC.FIFBIECCMLA();
		BBINLIGKIPE.MKDNBBNPMHE();
	}

	public void ADPLGJLJLFD()
	{
		((Component)waterFeederContextUI).gameObject.SetActive(true);
	}
}
