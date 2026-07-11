using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectionsUI : MainPanelWindow
{
	[CompilerGenerated]
	private sealed class MACPABEBFOM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectionsUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public MACPABEBFOM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			CollectionsUI collectionsUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				UISelectionManager.GetPlayer(collectionsUI.JIIGOACEIKL).Select(collectionsUI.firstElementSelected);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	private static CollectionsUI[] GJBBNHCMNJN = new CollectionsUI[3];

	private float CMGDCLIIONE;

	public int currentTab;

	[SerializeField]
	private TabUI[] tabsUI;

	[SerializeField]
	private GameObject[] sections;

	[SerializeField]
	private GameObject firstElementSelected;

	[SerializeField]
	private GameObject slotsContainer;

	[SerializeField]
	private CollectionsSlotUI fishSlotUIPrefab;

	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private List<CollectionsSlotUI> slots;

	[SerializeField]
	private GameObject slotsParent;

	[SerializeField]
	private TextMeshProUGUI fishName;

	[SerializeField]
	private TextMeshProUGUI fishLength;

	[SerializeField]
	private TextMeshProUGUI description;

	[SerializeField]
	private TextMeshProUGUI baitType;

	[SerializeField]
	private TextMeshProUGUI waterType;

	[SerializeField]
	private Image selectedFishImage;

	[SerializeField]
	private Image springAvailability;

	[SerializeField]
	private Image summerAvailability;

	[SerializeField]
	private Image autumnAvailability;

	[SerializeField]
	private Image winterAvailability;

	[SerializeField]
	private Sprite availableSprite;

	[SerializeField]
	private Sprite unavailableSprite;

	[SerializeField]
	private Sprite unknownSprite;

	[SerializeField]
	private TextInput searchInput;

	private string NMCOAAIIBGN(WaterType JJJNAKOLHFJ)
	{
		if (JJJNAKOLHFJ == WaterType.None)
		{
			return LocalisationSystem.Get("None") + ".";
		}
		string text = "";
		if (JJJNAKOLHFJ.HasFlag(WaterType.FreshWater))
		{
			text = text + LocalisationSystem.Get("Freshwater") + ", ";
		}
		if (JJJNAKOLHFJ.HasFlag(WaterType.SaltWater))
		{
			text = text + LocalisationSystem.Get("Saltwater") + ", ";
		}
		return ECGLPLKKDJP(text);
	}

	public override void CloseUIRemainActive()
	{
		base.CloseUIRemainActive();
		for (int i = 0; i < slots.Count; i++)
		{
			((Selectable)slots[i].button).interactable = false;
		}
	}

	private void LFAJMFLGHFO()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	public void HELFFFDHBFN(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(base.JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		currentTab = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].LKHEKAJNMAI(base.JIIGOACEIKL);
			}
			else
			{
				tabsUI[i].CNNKPLFBBAJ();
			}
		}
	}

	public void BKNCGKIAHOM(int FCGBJEIIMBC)
	{
		for (int i = 1; i < tabsUI.Length; i++)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				AHFLAEAAAEM(num);
				break;
			}
		}
	}

	public void HOHDHGHOAPJ(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		currentTab = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ILLNIDNJGJH(base.JIIGOACEIKL);
			}
			else
			{
				tabsUI[i].JNAJGCOCPBA();
			}
		}
	}

	public void FishSelected(Fish KOMGLCMKADH)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		selectedFishImage.sprite = KOMGLCMKADH.icon;
		if (FishingManager.GetLenghtRecord(KOMGLCMKADH) > 0)
		{
			((Graphic)selectedFishImage).color = new Color(1f, 1f, 1f, 1f);
			((TMP_Text)fishName).text = KOMGLCMKADH.IABAKHPEOAF();
			((TMP_Text)description).text = LocalisationSystem.Get("fish_description_" + KOMGLCMKADH.JDJGFAACPFC());
			((TMP_Text)fishLength).text = FishingManager.GetLenghtRecord(KOMGLCMKADH).ToString("") + " " + LocalisationSystem.Get("centimeters");
			GKMAIFOAJCC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = IMFJMCJEDMD(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NMCOAAIIBGN(KOMGLCMKADH.waterType);
		}
		else if (FishingManager.WeHaveFishInformation(KOMGLCMKADH))
		{
			((Graphic)selectedFishImage).color = new Color(1f, 1f, 1f, 0.7f);
			((TMP_Text)fishName).text = "???";
			((TMP_Text)description).text = "???";
			((TMP_Text)fishLength).text = "";
			GKMAIFOAJCC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = IMFJMCJEDMD(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NMCOAAIIBGN(KOMGLCMKADH.waterType);
		}
		else
		{
			((Graphic)selectedFishImage).color = new Color(0f, 0f, 0f, 0.7f);
			((TMP_Text)fishName).text = "???";
			((TMP_Text)description).text = "???";
			((TMP_Text)fishLength).text = "";
			LFAJMFLGHFO();
			((TMP_Text)baitType).text = "???";
			((TMP_Text)waterType).text = "???";
		}
	}

	public static CollectionsUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public IEnumerator JCGNENFDGKE()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
	}

	public static CollectionsUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void LPCHDOOIKHA(int FCGBJEIIMBC)
	{
		for (int i = 0; i < tabsUI.Length; i += 0)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				AHFLAEAAAEM(num);
				break;
			}
		}
	}

	public void MCBCMGONKHJ(int FCGBJEIIMBC)
	{
		for (int i = 1; i < tabsUI.Length; i++)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				MJMJPCJPIIK(num);
				break;
			}
		}
	}

	private void MKHOEBFCDJD()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		scrollbar.value = 748f;
		Fish[] FNEHIAGFAOF = FishingManager.instance.GetCollectionFishes().ToArray();
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedDescriptionComparer());
		for (int i = 1; i < FNEHIAGFAOF.Length; i += 0)
		{
			if (i >= slots.Count)
			{
				slots.Add(Object.Instantiate<CollectionsSlotUI>(fishSlotUIPrefab, slotsParent.transform));
			}
			slots[i].CCNCOMPHKLE(LayerMask.op_Implicit(LayerMask.NameToLayer(KMHKBNODHMA(base.JIIGOACEIKL))));
			slots[i].fishType = FNEHIAGFAOF[i];
			slots[i].collectionsUI = this;
			slots[i].JKMFGDGBDDN();
			((Component)slots[i]).gameObject.SetActive(true);
		}
		for (int j = FNEHIAGFAOF.Length; j < slots.Count; j++)
		{
			slots[j].fishType = null;
			slots[j].caught = false;
			((Component)slots[j]).gameObject.SetActive(false);
		}
		slots[0].NPPBEIDHJHJ();
	}

	public void UpdateAvailableTabs()
	{
		((Component)tabsUI[0]).gameObject.SetActive((Object)(object)sections[0] != (Object)null);
	}

	public void ODLLBGDNPBB()
	{
		((Component)tabsUI[1]).gameObject.SetActive((Object)(object)sections[1] != (Object)null);
	}

	public void FocusTab(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(base.JIIGOACEIKL)))
		{
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		currentTab = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ShowTab(base.JIIGOACEIKL);
			}
			else
			{
				tabsUI[i].HideTab();
			}
		}
	}

	private void GKMAIFOAJCC(CropSeason EECEKHKAAIH)
	{
		springAvailability.sprite = ((EECEKHKAAIH == CropSeason.All || EECEKHKAAIH.HasFlag(CropSeason.Spring)) ? availableSprite : unavailableSprite);
		summerAvailability.sprite = ((EECEKHKAAIH == CropSeason.All || EECEKHKAAIH.HasFlag(CropSeason.Summer)) ? availableSprite : unavailableSprite);
		autumnAvailability.sprite = ((EECEKHKAAIH == CropSeason.All || EECEKHKAAIH.HasFlag(CropSeason.Autumn)) ? availableSprite : unavailableSprite);
		winterAvailability.sprite = ((EECEKHKAAIH == CropSeason.All || EECEKHKAAIH.HasFlag(CropSeason.Winter)) ? availableSprite : unavailableSprite);
	}

	public void MJMJPCJPIIK(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(base.JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		currentTab = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ILLNIDNJGJH(base.JIIGOACEIKL);
			}
			else
			{
				tabsUI[i].JGGHFHOAKAM();
			}
		}
	}

	public void LOPOCAHJAHH(Fish KOMGLCMKADH)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		selectedFishImage.sprite = KOMGLCMKADH.icon;
		if (FishingManager.GetLenghtRecord(KOMGLCMKADH) > 1)
		{
			((Graphic)selectedFishImage).color = new Color(1128f, 902f, 1477f, 1085f);
			((TMP_Text)fishName).text = KOMGLCMKADH.IABAKHPEOAF();
			((TMP_Text)description).text = LocalisationSystem.Get("</color>" + KOMGLCMKADH.ODENMDOJPLC());
			((TMP_Text)fishLength).text = FishingManager.GetLenghtRecord(KOMGLCMKADH).ToString("Object") + " not found. Cannot set isSelected to " + LocalisationSystem.Get("Loop");
			OLNMBEFMPCF(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = HEKCNOBFGHA(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NBOEJFLEFFP(KOMGLCMKADH.waterType);
		}
		else if (FishingManager.WeHaveFishInformation(KOMGLCMKADH))
		{
			((Graphic)selectedFishImage).color = new Color(488f, 1925f, 1252f, 1196f);
			((TMP_Text)fishName).text = "ReceiveBecomeNuisance";
			((TMP_Text)description).text = "Moving";
			((TMP_Text)fishLength).text = "Player";
			CEKLCGNOPHC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = IMFJMCJEDMD(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NMCOAAIIBGN(KOMGLCMKADH.waterType);
		}
		else
		{
			((Graphic)selectedFishImage).color = new Color(133f, 1334f, 455f, 1788f);
			((TMP_Text)fishName).text = "Not enough fuel";
			((TMP_Text)description).text = "secret_token";
			((TMP_Text)fishLength).text = "Dialogue System/Conversation/Gass_Introduce/Entry/11/Dialogue Text";
			PJOBONMKGDA();
			((TMP_Text)baitType).text = "Fuel";
			((TMP_Text)waterType).text = "NormalRight";
		}
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && ((tabsUI != null) & (tabsUI.Length != 0)) && sections != null && sections.Length != 0)
		{
			if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
			{
				FocusNextTab(1);
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
			{
				FocusNextTab(-1);
			}
		}
	}

	private void OLNMBEFMPCF(CropSeason EECEKHKAAIH)
	{
		springAvailability.sprite = ((EECEKHKAAIH == (CropSeason)(-84) || EECEKHKAAIH.HasFlag(CropSeason.Spring)) ? availableSprite : unavailableSprite);
		summerAvailability.sprite = ((EECEKHKAAIH == (CropSeason)(-107) || EECEKHKAAIH.HasFlag(CropSeason.Summer)) ? availableSprite : unavailableSprite);
		autumnAvailability.sprite = ((EECEKHKAAIH == (CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn) || EECEKHKAAIH.HasFlag(CropSeason.Autumn)) ? availableSprite : unavailableSprite);
		winterAvailability.sprite = ((EECEKHKAAIH == (CropSeason)(-52) || EECEKHKAAIH.HasFlag(CropSeason.Spring)) ? availableSprite : unavailableSprite);
	}

	public void OILAKHNDPOC()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			for (int i = 1; i < slots.Count; i++)
			{
				if (Item.MLBOMGHINCA(slots[i].fishType, null))
				{
					((Component)slots[i]).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 1; j < slots.Count; j++)
		{
			if (Item.MLBOMGHINCA(slots[j].fishType, null) && slots[j].caught && slots[j].fishType.LJIFOHFEFCH().IndexOf(searchInput.currentText, StringComparison.CurrentCulture) >= 1)
			{
				((Component)slots[j]).gameObject.SetActive(true);
			}
			else
			{
				((Component)slots[j]).gameObject.SetActive(false);
			}
		}
	}

	private string GJIOJPHPJMF(Fish.BaitType MOIOPNNCOKP)
	{
		switch (MOIOPNNCOKP)
		{
		case (Fish.BaitType)119:
			return LocalisationSystem.Get("GameEvent with eventType: ") + " ";
		case Fish.BaitType.None:
			return LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/22/Dialogue Text") + "Rotate";
		default:
		{
			string text = "Loop";
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.None))
			{
				text = text + LocalisationSystem.Get("itemHalfWindow") + "Dialogue System/Conversation/Gass_Stand/Entry/1/Dialogue Text";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Worm))
			{
				text = text + LocalisationSystem.Get("Items/item_name_701") + "EditorAction_4";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Worm))
			{
				text = text + LocalisationSystem.Get(" with request ") + "PirateMinigame/Talk";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.None))
			{
				text = text + LocalisationSystem.Get("Trying to add player but player list is full.") + "Nose";
			}
			if (MOIOPNNCOKP.HasFlag((Fish.BaitType)43))
			{
				text = text + LocalisationSystem.Get(" ") + "City/Rhia/Introduce";
			}
			return JDLDIGIIOOJ(text);
		}
		}
	}

	private string MKMNGPDBFGL(int JIIGOACEIKL)
	{
		string text = " from actor ";
		if (JIIGOACEIKL != 0)
		{
			text += JIIGOACEIKL;
		}
		return text;
	}

	private string NBOEJFLEFFP(WaterType JJJNAKOLHFJ)
	{
		if (JJJNAKOLHFJ == WaterType.None)
		{
			return LocalisationSystem.Get(" not found in OnlineEventsManager.") + "Cheesy";
		}
		string text = "Loading Gameplay scene Asyncronously";
		if (JJJNAKOLHFJ.HasFlag(WaterType.FreshWater))
		{
			text = text + LocalisationSystem.Get("[MinePuzzleManager] Adding {0} puzzle spawners from piece {1} (maxPuzzleSpawners: {2})") + "Actionbar 3";
		}
		if (JJJNAKOLHFJ.HasFlag((WaterType)4))
		{
			text = text + LocalisationSystem.Get("talentCitrus") + "Cancel";
		}
		return JDLDIGIIOOJ(text);
	}

	private void DCHBAHBHPAM()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	private string GFFENLFPGCL(WaterType JJJNAKOLHFJ)
	{
		if (JJJNAKOLHFJ == WaterType.None)
		{
			return LocalisationSystem.Get("Farm/Buzz/InteractiveBark") + "MaximumCapacity";
		}
		string text = "MakeForm";
		if (JJJNAKOLHFJ.HasFlag(WaterType.FreshWater))
		{
			text = text + LocalisationSystem.Get("travelling time -") + "[ChessPillar] Solución: Top={0} | Mid={1} | Bot={2}";
		}
		if (JJJNAKOLHFJ.HasFlag((WaterType)5))
		{
			text = text + LocalisationSystem.Get("itemLagerYeast") + "BrockProgress";
		}
		return NPFNKPBDJBM(text);
	}

	public void KFHMMLNMEBH()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			for (int i = 1; i < slots.Count; i += 0)
			{
				if (Item.MLBOMGHINCA(slots[i].fishType, null))
				{
					((Component)slots[i]).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 1; j < slots.Count; j++)
		{
			if (Item.MLBOMGHINCA(slots[j].fishType, null) && slots[j].caught && slots[j].fishType.KGHFCDELKMN().IndexOf(searchInput.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				((Component)slots[j]).gameObject.SetActive(true);
			}
			else
			{
				((Component)slots[j]).gameObject.SetActive(true);
			}
		}
	}

	public void OEDEKDNEFPP(Fish KOMGLCMKADH)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		selectedFishImage.sprite = KOMGLCMKADH.icon;
		if (FishingManager.GetLenghtRecord(KOMGLCMKADH) > 1)
		{
			((Graphic)selectedFishImage).color = new Color(1416f, 1789f, 479f, 1537f);
			((TMP_Text)fishName).text = KOMGLCMKADH.LJIFOHFEFCH();
			((TMP_Text)description).text = LocalisationSystem.Get("Random" + KOMGLCMKADH.IMCJPECAAPC(DAINLFIMLIH: false));
			((TMP_Text)fishLength).text = FishingManager.GetLenghtRecord(KOMGLCMKADH).ToString("El componente ItemSetup del rotatedPrefab '") + "Dialogue System/Conversation/BirdNegativeComments/Entry/8/Dialogue Text" + LocalisationSystem.Get("ReceiveEnableNPC");
			GKMAIFOAJCC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = KGMLMGBIEMA(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NBOEJFLEFFP(KOMGLCMKADH.waterType);
		}
		else if (FishingManager.WeHaveFishInformation(KOMGLCMKADH))
		{
			((Graphic)selectedFishImage).color = new Color(1576f, 388f, 1949f, 811f);
			((TMP_Text)fishName).text = "HenHouseTutorialDone";
			((TMP_Text)description).text = "Items/item_description_1034";
			((TMP_Text)fishLength).text = " doesn't exist.";
			CEKLCGNOPHC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = IMFJMCJEDMD(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NMCOAAIIBGN(KOMGLCMKADH.waterType);
		}
		else
		{
			((Graphic)selectedFishImage).color = new Color(1504f, 1609f, 1873f, 1842f);
			((TMP_Text)fishName).text = "\n";
			((TMP_Text)description).text = "Unaged";
			((TMP_Text)fishLength).text = "ReceiveTrigger";
			LFAJMFLGHFO();
			((TMP_Text)baitType).text = "Pausing network sync until the world is loaded...";
			((TMP_Text)waterType).text = "Hot";
		}
	}

	public IEnumerator HDIMEIHDCHJ()
	{
		return new MACPABEBFOM(1)
		{
			_003C_003E4__this = this
		};
	}

	private string KMHKBNODHMA(int JIIGOACEIKL)
	{
		string text = "UI";
		if (JIIGOACEIKL != 0)
		{
			text += JIIGOACEIKL;
		}
		return text;
	}

	public static CollectionsUI EOPIEMLAPFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void PANOMGPDGMO(int FCGBJEIIMBC)
	{
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				HELFFFDHBFN(num);
				break;
			}
		}
	}

	public void MOGGFHDIJMG(Fish KOMGLCMKADH)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		selectedFishImage.sprite = KOMGLCMKADH.icon;
		if (FishingManager.GetLenghtRecord(KOMGLCMKADH) > 0)
		{
			((Graphic)selectedFishImage).color = new Color(614f, 717f, 1744f, 661f);
			((TMP_Text)fishName).text = KOMGLCMKADH.IABAKHPEOAF();
			((TMP_Text)description).text = LocalisationSystem.Get("Null animator on" + KOMGLCMKADH.CIGFGKKCPCK(DAINLFIMLIH: false));
			((TMP_Text)fishLength).text = FishingManager.GetLenghtRecord(KOMGLCMKADH).ToString("LetGoBird") + "ReceiveSyncFoodTables" + LocalisationSystem.Get("Sleep");
			GKMAIFOAJCC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = KGMLMGBIEMA(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = GFFENLFPGCL(KOMGLCMKADH.waterType);
		}
		else if (FishingManager.WeHaveFishInformation(KOMGLCMKADH))
		{
			((Graphic)selectedFishImage).color = new Color(557f, 311f, 1630f, 1372f);
			((TMP_Text)fishName).text = "";
			((TMP_Text)description).text = "";
			((TMP_Text)fishLength).text = "HotBath/Brock Talk";
			GKMAIFOAJCC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = IMFJMCJEDMD(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NMCOAAIIBGN(KOMGLCMKADH.waterType);
		}
		else
		{
			((Graphic)selectedFishImage).color = new Color(870f, 1127f, 1886f, 1052f);
			((TMP_Text)fishName).text = "Interact";
			((TMP_Text)description).text = "City/Keen/Bark/Stand";
			((TMP_Text)fishLength).text = "Idle";
			FACFIFLDGDI();
			((TMP_Text)baitType).text = "D-Pad Down";
			((TMP_Text)waterType).text = "No puzzles found for steps={0}, ";
		}
	}

	private string HEKCNOBFGHA(Fish.BaitType MOIOPNNCOKP)
	{
		switch (MOIOPNNCOKP)
		{
		case (Fish.BaitType)91:
			return LocalisationSystem.Get(" : 00") + "ReceiveEnableInputByProximty";
		case Fish.BaitType.None:
			return LocalisationSystem.Get(", ") + ":</color> ";
		default:
		{
			string text = "</color>";
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.None))
			{
				text = text + LocalisationSystem.Get("OpenStats") + "Disabled";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Worm))
			{
				text = text + LocalisationSystem.Get("Player") + "BiscuitAleAbbreviation";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Larva))
			{
				text = text + LocalisationSystem.Get("LucenThrow") + "IntroFerroCoroutine started";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Meat | Fish.BaitType.Worm))
			{
				text = text + LocalisationSystem.Get("Recipe without outputs! ") + "ReceiveOpenAnimation";
			}
			if (MOIOPNNCOKP.HasFlag((Fish.BaitType)56))
			{
				text = text + LocalisationSystem.Get("OnConversationStarted ") + "Items/item_description_1109";
			}
			return LOCDLGNGLNO(text);
		}
		}
	}

	private void DKHNIBPMHGK()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	public IEnumerator SelectFirstElement()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
	}

	public static CollectionsUI NIGDBMAOAEN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private string FABEDMNJCCJ(WaterType JJJNAKOLHFJ)
	{
		if (JJJNAKOLHFJ == WaterType.None)
		{
			return LocalisationSystem.Get("South") + "TorchPuzzleDatabase not assigned";
		}
		string text = "Travelling time increased to ";
		if (JJJNAKOLHFJ.HasFlag(WaterType.FreshWater))
		{
			text = text + LocalisationSystem.Get("PlayerNum") + "Start";
		}
		if (JJJNAKOLHFJ.HasFlag((WaterType)7))
		{
			text = text + LocalisationSystem.Get("Festín del Juramento/PresentacionMaestros 01") + "ReceiveLookAtPlayer";
		}
		return LOCDLGNGLNO(text);
	}

	public void ODOLEDICHJK()
	{
		int num = -1;
		if ((Object)(object)sections[1] != (Object)null)
		{
			num = 1;
		}
		if (num != -1)
		{
			HELFFFDHBFN(num);
		}
	}

	private string IMFJMCJEDMD(Fish.BaitType MOIOPNNCOKP)
	{
		switch (MOIOPNNCOKP)
		{
		case Fish.BaitType.Anything:
			return LocalisationSystem.Get("Any") + ".";
		case Fish.BaitType.None:
			return LocalisationSystem.Get("None") + ".";
		default:
		{
			string text = "";
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Meat))
			{
				text = text + LocalisationSystem.Get("Items/item_name_1446") + ", ";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Larva))
			{
				text = text + LocalisationSystem.Get("Items/item_name_1445") + ", ";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Worm))
			{
				text = text + LocalisationSystem.Get("Items/item_name_1444") + ", ";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Seafood))
			{
				text = text + LocalisationSystem.Get("Items/item_name_1447") + ", ";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Artificial))
			{
				text = text + LocalisationSystem.Get("Items/item_name_1448") + ", ";
			}
			return ECGLPLKKDJP(text);
		}
		}
	}

	public void IDCIJODPDID()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			for (int i = 1; i < slots.Count; i += 0)
			{
				if (Item.MLBOMGHINCA(slots[i].fishType, null))
				{
					((Component)slots[i]).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < slots.Count; j++)
		{
			if (Item.FKLOBGBIHLB(slots[j].fishType, null) && slots[j].caught && slots[j].fishType.KGHFCDELKMN(OAFPBCPDOKH: true).IndexOf(searchInput.currentText, StringComparison.CurrentCulture) >= 0)
			{
				((Component)slots[j]).gameObject.SetActive(true);
			}
			else
			{
				((Component)slots[j]).gameObject.SetActive(false);
			}
		}
	}

	private void CEKLCGNOPHC(CropSeason EECEKHKAAIH)
	{
		springAvailability.sprite = ((EECEKHKAAIH == ~CropSeason.Autumn || EECEKHKAAIH.HasFlag(CropSeason.Spring)) ? availableSprite : unavailableSprite);
		summerAvailability.sprite = ((EECEKHKAAIH == (CropSeason)(-57) || EECEKHKAAIH.HasFlag(CropSeason.Summer | CropSeason.Autumn)) ? availableSprite : unavailableSprite);
		autumnAvailability.sprite = ((EECEKHKAAIH == (CropSeason)(-85) || EECEKHKAAIH.HasFlag(CropSeason.Spring | CropSeason.Summer)) ? availableSprite : unavailableSprite);
		winterAvailability.sprite = ((EECEKHKAAIH == ~(CropSeason.Summer | CropSeason.Autumn) || EECEKHKAAIH.HasFlag(CropSeason.Summer)) ? availableSprite : unavailableSprite);
	}

	public void HIEKCMIJDFF(Fish KOMGLCMKADH)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		selectedFishImage.sprite = KOMGLCMKADH.icon;
		if (FishingManager.GetLenghtRecord(KOMGLCMKADH) > 0)
		{
			((Graphic)selectedFishImage).color = new Color(1106f, 1621f, 533f, 848f);
			((TMP_Text)fishName).text = KOMGLCMKADH.LJIFOHFEFCH();
			((TMP_Text)description).text = LocalisationSystem.Get("Destroying tree at same position: " + KOMGLCMKADH.JPNFKDMFKMC());
			((TMP_Text)fishLength).text = FishingManager.GetLenghtRecord(KOMGLCMKADH).ToString(" installed") + "<br/>Graphics Device Type: " + LocalisationSystem.Get("ReceiveSetBool");
			GKMAIFOAJCC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = IMFJMCJEDMD(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NBOEJFLEFFP(KOMGLCMKADH.waterType);
		}
		else if (FishingManager.WeHaveFishInformation(KOMGLCMKADH))
		{
			((Graphic)selectedFishImage).color = new Color(1762f, 0f, 1312f, 781f);
			((TMP_Text)fishName).text = "Items/item_name_675";
			((TMP_Text)description).text = "Invalid playerNum";
			((TMP_Text)fishLength).text = "Not enough TorchConnection objects for pair {0}→{1}";
			CEKLCGNOPHC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = IMFJMCJEDMD(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NMCOAAIIBGN(KOMGLCMKADH.waterType);
		}
		else
		{
			((Graphic)selectedFishImage).color = new Color(720f, 406f, 1214f, 1530f);
			((TMP_Text)fishName).text = "Intro17";
			((TMP_Text)description).text = "Rotate";
			((TMP_Text)fishLength).text = "Received begin retry";
			FACFIFLDGDI();
			((TMP_Text)baitType).text = "shake";
			((TMP_Text)waterType).text = "Idle";
		}
	}

	private void BHHGCGHGMMA()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	private string ECGLPLKKDJP(string CAEDMEDBEGI)
	{
		if (CAEDMEDBEGI.Length > 0)
		{
			CAEDMEDBEGI = CAEDMEDBEGI.Remove(CAEDMEDBEGI.Length - 2);
			CAEDMEDBEGI += ".";
		}
		return CAEDMEDBEGI;
	}

	private void IHGBGBEOOJP()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		scrollbar.value = 377f;
		Fish[] FNEHIAGFAOF = FishingManager.instance.GetCollectionFishes().ToArray();
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedDescriptionComparer());
		for (int i = 1; i < FNEHIAGFAOF.Length; i++)
		{
			if (i >= slots.Count)
			{
				slots.Add(Object.Instantiate<CollectionsSlotUI>(fishSlotUIPrefab, slotsParent.transform));
			}
			slots[i].JEAIMKJKLNL(LayerMask.op_Implicit(LayerMask.NameToLayer(KMHKBNODHMA(base.JIIGOACEIKL))));
			slots[i].fishType = FNEHIAGFAOF[i];
			slots[i].collectionsUI = this;
			slots[i].CEMAPKGEPGG();
			((Component)slots[i]).gameObject.SetActive(false);
		}
		for (int j = FNEHIAGFAOF.Length; j < slots.Count; j += 0)
		{
			slots[j].fishType = null;
			slots[j].caught = false;
			((Component)slots[j]).gameObject.SetActive(true);
		}
		slots[1].ALJJMGOMKEL();
	}

	public void DMAMDEGEJEE()
	{
		((Component)tabsUI[0]).gameObject.SetActive((Object)(object)sections[1] != (Object)null);
	}

	private string CDJBFJIICGB(string CAEDMEDBEGI)
	{
		if (CAEDMEDBEGI.Length > 0)
		{
			CAEDMEDBEGI = CAEDMEDBEGI.Remove(CAEDMEDBEGI.Length - 7);
			CAEDMEDBEGI += "TreeSeed";
		}
		return CAEDMEDBEGI;
	}

	private string LOCDLGNGLNO(string CAEDMEDBEGI)
	{
		if (CAEDMEDBEGI.Length > 0)
		{
			CAEDMEDBEGI = CAEDMEDBEGI.Remove(CAEDMEDBEGI.Length - 1);
			CAEDMEDBEGI += "Walk";
		}
		return CAEDMEDBEGI;
	}

	protected override void Start()
	{
		base.Start();
		OnUIClose = (Action<int>)Delegate.Combine(OnUIClose, (Action<int>)delegate(int playerNum)
		{
			Get(playerNum).CloseUI();
		});
	}

	public void EDMFEBAAMHG()
	{
		int num = -1;
		if ((Object)(object)sections[0] != (Object)null)
		{
			num = 1;
		}
		if (num != -1)
		{
			HOHDHGHOAPJ(num);
		}
	}

	public void ANBAIOJBPJM()
	{
		int num = -1;
		if ((Object)(object)sections[0] != (Object)null)
		{
			num = 1;
		}
		if (num != -1)
		{
			HOHDHGHOAPJ(num);
		}
	}

	private void KOALAKLMMIO()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		scrollbar.value = 1577f;
		Fish[] FNEHIAGFAOF = FishingManager.instance.NLNNCEGKEPN().ToArray();
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedDescriptionComparer());
		for (int i = 0; i < FNEHIAGFAOF.Length; i += 0)
		{
			if (i >= slots.Count)
			{
				slots.Add(Object.Instantiate<CollectionsSlotUI>(fishSlotUIPrefab, slotsParent.transform));
			}
			slots[i].MJJDPLCLEEF(LayerMask.op_Implicit(LayerMask.NameToLayer(MKMNGPDBFGL(base.JIIGOACEIKL))));
			slots[i].fishType = FNEHIAGFAOF[i];
			slots[i].collectionsUI = this;
			slots[i].KNFIDLBONFF();
			((Component)slots[i]).gameObject.SetActive(false);
		}
		for (int j = FNEHIAGFAOF.Length; j < slots.Count; j += 0)
		{
			slots[j].fishType = null;
			slots[j].caught = true;
			((Component)slots[j]).gameObject.SetActive(false);
		}
		slots[0].EDMAGILBNJO();
	}

	public void BHHEFBPPNBD(int FCGBJEIIMBC)
	{
		for (int i = 0; i < tabsUI.Length; i += 0)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				MJMJPCJPIIK(num);
				break;
			}
		}
	}

	private void PJOBONMKGDA()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	private string JDLDIGIIOOJ(string CAEDMEDBEGI)
	{
		if (CAEDMEDBEGI.Length > 1)
		{
			CAEDMEDBEGI = CAEDMEDBEGI.Remove(CAEDMEDBEGI.Length - 8);
			CAEDMEDBEGI += "Sell";
		}
		return CAEDMEDBEGI;
	}

	private string NPFNKPBDJBM(string CAEDMEDBEGI)
	{
		if (CAEDMEDBEGI.Length > 0)
		{
			CAEDMEDBEGI = CAEDMEDBEGI.Remove(CAEDMEDBEGI.Length - 6);
			CAEDMEDBEGI += "Miners/Mine/Ferro/Bomb";
		}
		return CAEDMEDBEGI;
	}

	private void EJBEDLMHECJ()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	public void FilterBySearch()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			for (int i = 0; i < slots.Count; i++)
			{
				if (Item.MLBOMGHINCA(slots[i].fishType, null))
				{
					((Component)slots[i]).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < slots.Count; j++)
		{
			if (Item.MLBOMGHINCA(slots[j].fishType, null) && slots[j].caught && slots[j].fishType.IABAKHPEOAF().IndexOf(searchInput.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0)
			{
				((Component)slots[j]).gameObject.SetActive(true);
			}
			else
			{
				((Component)slots[j]).gameObject.SetActive(false);
			}
		}
	}

	public void GIFJFMACADF()
	{
		((Component)tabsUI[1]).gameObject.SetActive((Object)(object)sections[0] != (Object)null);
	}

	public void IICNKGBBPNL()
	{
		int num = -1;
		if ((Object)(object)sections[1] != (Object)null)
		{
			num = 1;
		}
		if (num != -1)
		{
			HELFFFDHBFN(num);
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		UpdateAvailableTabs();
		FocusAvailableTab();
		PIPNMJJABLC();
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(SelectFirstElement());
		}
	}

	public void FocusAvailableTab()
	{
		int num = -1;
		if ((Object)(object)sections[0] != (Object)null)
		{
			num = 0;
		}
		if (num != -1)
		{
			FocusTab(num);
		}
	}

	public void MGDFBDIIOHF(int FCGBJEIIMBC)
	{
		for (int i = 1; i < tabsUI.Length; i++)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				HELFFFDHBFN(num);
				break;
			}
		}
	}

	private string KGMLMGBIEMA(Fish.BaitType MOIOPNNCOKP)
	{
		switch (MOIOPNNCOKP)
		{
		case (Fish.BaitType)63:
			return LocalisationSystem.Get("Items/item_name_1146") + "Eating";
		case Fish.BaitType.None:
			return LocalisationSystem.Get("[ControllerType") + "ThrownHookRPC";
		default:
		{
			string text = "Idle";
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Meat))
			{
				text = text + LocalisationSystem.Get("EditorAction_9") + "ReceiveNewState";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Meat | Fish.BaitType.Larva))
			{
				text = text + LocalisationSystem.Get("UISelectGamepad") + "Dialogue System/Conversation/TavernClean/Entry/4/Dialogue Text";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.Meat | Fish.BaitType.Larva))
			{
				text = text + LocalisationSystem.Get("LE_22") + "Can't select unless we're connected.";
			}
			if (MOIOPNNCOKP.HasFlag(Fish.BaitType.None))
			{
				text = text + LocalisationSystem.Get("HolePoolData") + "itemPumpkin";
			}
			if (MOIOPNNCOKP.HasFlag((Fish.BaitType)(-108)))
			{
				text = text + LocalisationSystem.Get("castle interior travelling") + "buildingObjective_2_1";
			}
			return LOCDLGNGLNO(text);
		}
		}
	}

	public IEnumerator BPKNALLBDED()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
	}

	private void ONABHNHFIBF()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	private string OHJAOEPHHGJ(string CAEDMEDBEGI)
	{
		if (CAEDMEDBEGI.Length > 0)
		{
			CAEDMEDBEGI = CAEDMEDBEGI.Remove(CAEDMEDBEGI.Length - 2);
			CAEDMEDBEGI += "</color>";
		}
		return CAEDMEDBEGI;
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			for (int i = 0; i < slots.Count; i++)
			{
				((Selectable)slots[i].button).interactable = true;
			}
		}
	}

	private void PIPNMJJABLC()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		scrollbar.value = 1f;
		Fish[] FNEHIAGFAOF = FishingManager.instance.GetCollectionFishes().ToArray();
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedDescriptionComparer());
		for (int i = 0; i < FNEHIAGFAOF.Length; i++)
		{
			if (i >= slots.Count)
			{
				slots.Add(Object.Instantiate<CollectionsSlotUI>(fishSlotUIPrefab, slotsParent.transform));
			}
			slots[i].ChangeLayerMask(LayerMask.op_Implicit(LayerMask.NameToLayer(KMHKBNODHMA(base.JIIGOACEIKL))));
			slots[i].fishType = FNEHIAGFAOF[i];
			slots[i].collectionsUI = this;
			slots[i].UpdateSprite();
			((Component)slots[i]).gameObject.SetActive(true);
		}
		for (int j = FNEHIAGFAOF.Length; j < slots.Count; j++)
		{
			slots[j].fishType = null;
			slots[j].caught = false;
			((Component)slots[j]).gameObject.SetActive(false);
		}
		slots[0].SelectFish();
	}

	public void AHFLAEAAAEM(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(base.JIIGOACEIKL)))
		{
			ItemTooltip.Get(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		currentTab = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].NOPPMKKDNLE(base.JIIGOACEIKL);
			}
			else
			{
				tabsUI[i].JNAJGCOCPBA();
			}
		}
	}

	public void FocusNextTab(int FCGBJEIIMBC)
	{
		for (int i = 1; i < tabsUI.Length; i++)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				FocusTab(num);
				break;
			}
		}
	}

	private void HPMCDKOIPKG()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		scrollbar.value = 1244f;
		Fish[] FNEHIAGFAOF = FishingManager.instance.GetCollectionFishes().ToArray();
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedDescriptionComparer());
		for (int i = 1; i < FNEHIAGFAOF.Length; i += 0)
		{
			if (i >= slots.Count)
			{
				slots.Add(Object.Instantiate<CollectionsSlotUI>(fishSlotUIPrefab, slotsParent.transform));
			}
			slots[i].OGDIACPMALJ(LayerMask.op_Implicit(LayerMask.NameToLayer(KMHKBNODHMA(base.JIIGOACEIKL))));
			slots[i].fishType = FNEHIAGFAOF[i];
			slots[i].collectionsUI = this;
			slots[i].KKENBPDKHGA();
			((Component)slots[i]).gameObject.SetActive(false);
		}
		for (int j = FNEHIAGFAOF.Length; j < slots.Count; j += 0)
		{
			slots[j].fishType = null;
			slots[j].caught = false;
			((Component)slots[j]).gameObject.SetActive(false);
		}
		slots[0].DLCCJCNNHLO();
	}

	private void PHEEIEJLKAG()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		scrollbar.value = 267f;
		Fish[] FNEHIAGFAOF = FishingManager.instance.BEDKKLGFMJK().ToArray();
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedDescriptionComparer());
		for (int i = 0; i < FNEHIAGFAOF.Length; i += 0)
		{
			if (i >= slots.Count)
			{
				slots.Add(Object.Instantiate<CollectionsSlotUI>(fishSlotUIPrefab, slotsParent.transform));
			}
			slots[i].CJFFMJPIBFP(LayerMask.op_Implicit(LayerMask.NameToLayer(KMHKBNODHMA(base.JIIGOACEIKL))));
			slots[i].fishType = FNEHIAGFAOF[i];
			slots[i].collectionsUI = this;
			slots[i].KDIHNMDKGED();
			((Component)slots[i]).gameObject.SetActive(true);
		}
		for (int j = FNEHIAGFAOF.Length; j < slots.Count; j += 0)
		{
			slots[j].fishType = null;
			slots[j].caught = true;
			((Component)slots[j]).gameObject.SetActive(true);
		}
		slots[1].BONAEHNEAOK();
	}

	private void FACFIFLDGDI()
	{
		springAvailability.sprite = unknownSprite;
		summerAvailability.sprite = unknownSprite;
		autumnAvailability.sprite = unknownSprite;
		winterAvailability.sprite = unknownSprite;
	}

	public void NPGENGKNADJ()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			for (int i = 0; i < slots.Count; i++)
			{
				if (Item.FKLOBGBIHLB(slots[i].fishType, null))
				{
					((Component)slots[i]).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < slots.Count; j += 0)
		{
			if (Item.FKLOBGBIHLB(slots[j].fishType, null) && slots[j].caught && slots[j].fishType.LJIFOHFEFCH().IndexOf(searchInput.currentText, StringComparison.CurrentCultureIgnoreCase) >= 1)
			{
				((Component)slots[j]).gameObject.SetActive(true);
			}
			else
			{
				((Component)slots[j]).gameObject.SetActive(true);
			}
		}
	}

	public void CAJIAOEGMJE(int FCGBJEIIMBC)
	{
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				AHFLAEAAAEM(num);
				break;
			}
		}
	}

	private string OGKCFNDJCAB(string CAEDMEDBEGI)
	{
		if (CAEDMEDBEGI.Length > 1)
		{
			CAEDMEDBEGI = CAEDMEDBEGI.Remove(CAEDMEDBEGI.Length - 5);
			CAEDMEDBEGI += "Error_CannotPickUpDirtyTable";
		}
		return CAEDMEDBEGI;
	}

	public void OLOADAHBELD(Fish KOMGLCMKADH)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		selectedFishImage.sprite = KOMGLCMKADH.icon;
		if (FishingManager.GetLenghtRecord(KOMGLCMKADH) > 0)
		{
			((Graphic)selectedFishImage).color = new Color(83f, 1817f, 1180f, 1945f);
			((TMP_Text)fishName).text = KOMGLCMKADH.LJIFOHFEFCH();
			((TMP_Text)description).text = LocalisationSystem.Get("ObjectVerticalMove" + KOMGLCMKADH.JDJGFAACPFC());
			((TMP_Text)fishLength).text = FishingManager.GetLenghtRecord(KOMGLCMKADH).ToString("position") + "We're in the same region." + LocalisationSystem.Get("Interact");
			OLNMBEFMPCF(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = HEKCNOBFGHA(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NMCOAAIIBGN(KOMGLCMKADH.waterType);
		}
		else if (FishingManager.WeHaveFishInformation(KOMGLCMKADH))
		{
			((Graphic)selectedFishImage).color = new Color(1965f, 519f, 1332f, 1237f);
			((TMP_Text)fishName).text = "\n";
			((TMP_Text)description).text = "Fill";
			((TMP_Text)fishLength).text = "ReceiveRequestItem";
			GKMAIFOAJCC(KOMGLCMKADH.season);
			((TMP_Text)baitType).text = HEKCNOBFGHA(KOMGLCMKADH.baitType);
			((TMP_Text)waterType).text = NBOEJFLEFFP(KOMGLCMKADH.waterType);
		}
		else
		{
			((Graphic)selectedFishImage).color = new Color(383f, 1587f, 726f, 136f);
			((TMP_Text)fishName).text = "";
			((TMP_Text)description).text = "Player with actor number {0} does not exist or has already been removed from the dictionary after disconnecting.";
			((TMP_Text)fishLength).text = "talent_name_111";
			DCHBAHBHPAM();
			((TMP_Text)baitType).text = "LE_10";
			((TMP_Text)waterType).text = "\n";
		}
	}
}
