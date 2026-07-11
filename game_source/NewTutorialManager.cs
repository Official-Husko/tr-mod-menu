using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using I2.Loc;
using TMPro;
using UnityEngine;
using WebSocketSharp;

public class NewTutorialManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NNGHIJGBDJO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NewTutorialManager _003C_003E4__this;

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
		public NNGHIJGBDJO(int _003C_003E1__state)
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
			NewTutorialManager newTutorialManager = _003C_003E4__this;
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
				newTutorialManager.FDJFHGOIIJB();
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

	public Action ObjectivesUpdated = delegate
	{
	};

	public Action<bool> OnTutorialActivate = delegate
	{
	};

	public static NewTutorialManager instance;

	public TutorialPhaseBase[] tutorialPhases;

	[HideInInspector]
	public bool canEnterCellar;

	[HideInInspector]
	public bool canLeaveCellar;

	[HideInInspector]
	public bool savingIsBlocked;

	[HideInInspector]
	public bool canOpenTavern;

	[HideInInspector]
	public bool agingBarrelBlocked;

	[HideInInspector]
	public bool quarryBlock;

	[HideInInspector]
	public bool player2Blocked;

	[HideInInspector]
	public bool mopUnlocked;

	private List<TutorialObject> HCNKEFGHGPN = new List<TutorialObject>();

	[HideInInspector]
	public int currentPhase = 99;

	public AudioObject objectiveSound;

	public GameObject tutorialArrowPrefab;

	public GameObject mainPopup;

	public GameObject objectivesPanel;

	public GameObject helpButton;

	public TextImageUI[] objectives;

	public TextMeshProUGUI popupText;

	public Color blueParticlesColor;

	public Color blueLightsColor;

	private Color[] OHKEKDOPADC;

	private Color[] HKEHHKBEIIN;

	private float PBOAEKCEJOM;

	[SerializeField]
	private List<bool> completedObjectives = new List<bool>();

	[HideInInspector]
	public TutorialPhaseBase currentTutorialPhase;

	public bool open;

	public bool tutorialPopUpOpen;

	public AudioObject blueFireStartSound;

	public AudioObject fireLoop;

	[HideInInspector]
	public static MultiAudioSource fireLoopSource;

	[HideInInspector]
	public bool recipePurchased;

	private Table[] IBMBGPOLAIK;

	[HideInInspector]
	public static bool CCCLOBIOMCL { get; private set; }

	public static bool ForceDrinkOrders()
	{
		if ((CCCLOBIOMCL && GetCurrentPhaseID() == 111) || GetCurrentPhaseID() == 114)
		{
			return true;
		}
		return false;
	}

	public static bool HeatLevelBlocked()
	{
		if (CCCLOBIOMCL && (GetCurrentPhaseID() < 135 || FNLFBJFGHBO()))
		{
			return true;
		}
		return false;
	}

	public static void ShowPopUp(string CAEDMEDBEGI)
	{
		if (!instance.tutorialPopUpOpen)
		{
			((TMP_Text)instance.popupText).text = CAEDMEDBEGI;
			instance.mainPopup.SetActive(true);
			instance.tutorialPopUpOpen = true;
		}
	}

	public static bool CrafterBlocked(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		switch (LDLINOBIKPL.placeable.itemSetup.item.JDJGFAACPFC())
		{
		case 672:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 107) || (CCCLOBIOMCL && GetCurrentPhaseID() > 109 && GetCurrentPhaseID() < 117) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		case 1240:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 136) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		case 709:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 136) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		case 673:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 118) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		case 675:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 122) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		}
		return false;
	}

	private void Start()
	{
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(EMNJGLGLLKK));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MFIAHDJCIMO));
	}

	public static void ClosePopUpDirect()
	{
		instance.mainPopup.SetActive(false);
		instance.tutorialPopUpOpen = false;
	}

	public Crafter PLLCPHIELON(int EOACENDMJDI)
	{
		Crafter[] array = Object.FindObjectsOfType<Crafter>();
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].placeable.itemSetup.item.JPNFKDMFKMC() == EOACENDMJDI)
			{
				return array[i];
			}
		}
		return null;
	}

	private void MFADLKJJAFK(bool OEDBPACCOGH)
	{
		if ((Object)(object)helpButton != (Object)null)
		{
			if (OEDBPACCOGH && !helpButton.activeSelf)
			{
				helpButton.SetActive(true);
			}
			else if (!OEDBPACCOGH && helpButton.activeSelf)
			{
				helpButton.SetActive(false);
			}
		}
	}

	public void StartFireTransition()
	{
		((MonoBehaviour)instance).StartCoroutine(APJBPMDCKCH());
	}

	private void FDJFHGOIIJB()
	{
		Crafter[] array = Object.FindObjectsOfType<Crafter>();
		List<Placeable> list = new List<Placeable>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].placeable.itemSetup.item.JDJGFAACPFC() != 672 && array[i].placeable.itemSetup.item.JDJGFAACPFC() != 673 && array[i].placeable.itemSetup.item.JDJGFAACPFC() != 675 && array[i].placeable.itemSetup.item.JDJGFAACPFC() != 709 && array[i].placeable.itemSetup.item.JDJGFAACPFC() != 1240)
			{
				continue;
			}
			if (GetCurrentPhaseID() < 123 && array[i].LCCABPFHCOL == 0)
			{
				if (array[i].placeable.itemSetup.item.JDJGFAACPFC() == 672)
				{
					array[i].SetFuel(11);
				}
				else
				{
					array[i].SetFuel(10);
				}
			}
			list.Add(array[i].placeable);
		}
		SceneReferences.instance.crafterPlaceable = list.ToArray();
	}

	public void OEJFPGJPFNI()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			BOIFDOAKDAN();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(GDICBOIDHJL());
		}
	}

	private IEnumerator APJBPMDCKCH()
	{
		SceneReferences.instance.fireplaceAlphaTransition.Transition();
		float currentLerpTime = 0f;
		while (currentLerpTime < 1f)
		{
			currentLerpTime += Time.deltaTime;
			for (int i = 0; i < SceneReferences.instance.blueFires.Length; i++)
			{
				MainModule main = SceneReferences.instance.blueFires[i].main;
				MinMaxGradient startColor = ((MainModule)(ref main)).startColor;
				((MinMaxGradient)(ref startColor)).color = Color.Lerp(blueParticlesColor, OHKEKDOPADC[i], currentLerpTime);
				((MainModule)(ref main)).startColor = startColor;
			}
			for (int j = 0; j < SceneReferences.instance.blueFireLights.Length; j++)
			{
				SceneReferences.instance.blueFireLights[j].color = Color.Lerp(blueLightsColor, HKEHHKBEIIN[j], currentLerpTime);
			}
			SceneReferences.instance.blueLight.intensity = Mathf.Lerp(PBOAEKCEJOM, 0f, currentLerpTime);
			yield return null;
		}
		((Behaviour)SceneReferences.instance.blueLight).enabled = false;
	}

	public static bool SleepBlocked()
	{
		if (!CCCLOBIOMCL)
		{
			return false;
		}
		if (GetCurrentPhaseID() >= 110 && GetCurrentPhaseID() <= 114)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/SleepBlock");
			return true;
		}
		if (GetCurrentPhaseID() >= 119 && GetCurrentPhaseID() <= 121)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/SleepBlock");
			return true;
		}
		if (GetCurrentPhaseID() == 132 && instance.savingIsBlocked)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/SleepBlock");
			return true;
		}
		if (GetCurrentPhaseID() >= 134 && GetCurrentPhaseID() <= 135)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/SleepBlock");
			return true;
		}
		if (EventsManager.IsActive(EventsManager.EventType.KlaynTavern))
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/KlaynTavernBlock");
			return true;
		}
		return false;
	}

	public static bool OpenTavernBlocked(int JIIGOACEIKL)
	{
		if (CCCLOBIOMCL)
		{
			if (GetCurrentPhaseID() < 110 && !instance.canOpenTavern)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
				return true;
			}
			if ((GetCurrentPhaseID() > 114 && GetCurrentPhaseID() < 133) || (CCCLOBIOMCL && FNLFBJFGHBO()))
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
				return true;
			}
			if (GetCurrentPhaseID() == 133 && !instance.canOpenTavern)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
				return true;
			}
		}
		return false;
	}

	public static bool DecorationModeBlocked(int JIIGOACEIKL)
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() < 103)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
			return true;
		}
		return false;
	}

	private void BOIFDOAKDAN()
	{
		switch (currentPhase)
		{
		case 116:
			currentPhase = 139;
			break;
		case 139:
			currentPhase = 117;
			break;
		case 118:
			currentPhase = 140;
			break;
		case 140:
			currentPhase = 119;
			break;
		case 122:
			currentPhase = 141;
			break;
		case 141:
			currentPhase = 123;
			break;
		case 124:
			currentPhase = 128;
			break;
		case 129:
			currentPhase = 142;
			break;
		case 142:
			currentPhase = 130;
			break;
		case 138:
			currentPhase = 999;
			break;
		default:
			currentPhase++;
			break;
		}
		currentTutorialPhase = null;
		for (int i = 0; i < tutorialPhases.Length; i++)
		{
			if (tutorialPhases[i].GetID() == currentPhase)
			{
				currentTutorialPhase = tutorialPhases[i];
				currentTutorialPhase.SetUp();
				break;
			}
		}
		if ((Object)(object)currentTutorialPhase == (Object)null)
		{
			currentPhase = int.MaxValue;
			CCCLOBIOMCL = false;
			TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD = true;
			ShowObjectives(MFAAMBHBBJO: false);
		}
		else
		{
			ShowObjectives(MFAAMBHBBJO: false);
		}
	}

	public static bool CleanTableBlocked(int JIIGOACEIKL)
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() < 102)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T101");
			return true;
		}
		return false;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MGEBJJNPOPO));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(EMNJGLGLLKK));
		}
	}

	public static bool BlockRepairCrafter()
	{
		if (CCCLOBIOMCL && (GetCurrentPhaseID() < 123 || GetCurrentPhaseID() >= 139))
		{
			return true;
		}
		return false;
	}

	public static void ClosePopUp()
	{
		if (instance.tutorialPopUpOpen)
		{
			ClosePopUpDirect();
			return;
		}
		if (Time.timeScale == 0f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		instance.mainPopup.SetActive(false);
		if ((Object)(object)instance.currentTutorialPhase != (Object)null)
		{
			if (!instance.currentTutorialPhase.objectivesSetUp)
			{
				instance.UpdateObjectives(COGCFDJBDOF: true);
			}
			else
			{
				instance.ShowObjectives(MFAAMBHBBJO: true);
			}
		}
		instance.open = false;
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
		BlockPlayer(APGEBAEHLMM: false);
		if (GameManager.LocalCoop())
		{
			CursorManager.GetPlayer(1).ActivateCursorMask(DAEMAAOLHMG: true);
		}
	}

	public static bool RoadCustomersBlocked()
	{
		if (CCCLOBIOMCL)
		{
			if ((Object)(object)GetCurrentPhase() != (Object)null && GetCurrentPhaseID() >= 110 && GetCurrentPhaseID() < 115)
			{
				if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && TavernSeatingManager.IsThereAnyAvailableSeat())
				{
					return false;
				}
				return true;
			}
			if ((Object)(object)GetCurrentPhase() != (Object)null && (GetCurrentPhaseID() < 133 || FNLFBJFGHBO()))
			{
				return true;
			}
		}
		return false;
	}

	public static bool ContainerBlocked(int JIIGOACEIKL)
	{
		if ((CCCLOBIOMCL && GetCurrentPhaseID() < 102) || (CCCLOBIOMCL && GetCurrentPhaseID() == 102 && !(instance.currentTutorialPhase as T102_Limpiar).containerCanBeOpened))
		{
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/BarkMaiContainerBlock");
			return true;
		}
		return false;
	}

	public void AddAllSupplies()
	{
		SceneReferences.instance.initialChest.RemoveItem(ItemDatabaseAccessor.GetItem(1065));
		SceneReferences.instance.initialChest.RemoveItem(ItemDatabaseAccessor.GetItem(1302));
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1065).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1062).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1061).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1064).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1063).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1060).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1435).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1302).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(609).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1133).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1245).JMDALJBNFML(), 4, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1247).JMDALJBNFML(), 4, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(3018).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(3019).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(4).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(3059).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1118).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(630).JMDALJBNFML(), 8, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(74).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1135).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 20, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(3076).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(11).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
	}

	public static bool DestroyFloorDirtOnLoad()
	{
		if (CCCLOBIOMCL && instance.currentPhase > 102)
		{
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			return true;
		}
		return false;
	}

	protected void Awake()
	{
		instance = this;
		CCCLOBIOMCL = false;
		fireLoopSource = null;
	}

	protected void PFGHDKEPFPL()
	{
		if (!Ext.IsNullOrEmpty(LocalizationManager.GetTranslation("Tutorial_Main_" + currentTutorialPhase.GetID(), true, 0, true, false, (GameObject)null, (string)null, true)))
		{
			open = true;
			PlayerController.AddMovementBlocker((Object)(object)this);
			mainPopup.SetActive(true);
			ShowObjectives(MFAAMBHBBJO: false);
			((TMP_Text)popupText).text = InputUtils.LPGJFAOKMNE(1, LocalizationManager.GetTranslation("Tutorial_Main_" + currentTutorialPhase.GetID(), true, 0, true, false, (GameObject)null, (string)null, true));
			if (GameManager.LocalCoop())
			{
				CursorManager.GetPlayer(1).ActivateCursorMask(DAEMAAOLHMG: false);
			}
		}
	}

	public IEnumerator ActivateTutorialObjectsWithDelay(bool DAEMAAOLHMG)
	{
		while (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			yield return null;
		}
		ActivateTutorialObjects(DAEMAAOLHMG);
	}

	public static void BlockPlayer(bool APGEBAEHLMM)
	{
		if (APGEBAEHLMM)
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
			if (GameManager.LocalCoop())
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
			}
		}
		else
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)instance);
			if (GameManager.LocalCoop())
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)instance);
			}
		}
	}

	private void EMNJGLGLLKK(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!((Object)(object)instance.currentTutorialPhase == (Object)null) && (!GameManager.LocalCoop() || JIIGOACEIKL != 1) && (INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated) && instance.currentTutorialPhase.GetID() > 100 && instance.currentTutorialPhase.objectivesSetUp)
		{
			ShowObjectives(MFAAMBHBBJO: true);
		}
	}

	public void StartTutorial()
	{
		currentPhase = 99;
		instance.player2Blocked = true;
		NextPhase();
		ActivateTutorial(DAEMAAOLHMG: true, ICEGNJDJMLE: false);
	}

	public void ObjectiveCompleted(int MDGILGADLDA, bool BLJPGJKOLNF = true)
	{
		if (completedObjectives != null)
		{
			completedObjectives[MDGILGADLDA] = true;
			if (BLJPGJKOLNF)
			{
				PlayObjectivesCompletedSound();
			}
			UpdateObjectives();
		}
	}

	public static bool CloseTavernBlocked(int JIIGOACEIKL)
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 110 && CCCLOBIOMCL && GetCurrentPhaseID() <= 114)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
			return true;
		}
		return false;
	}

	public void ActivateTutorialObjects(bool DAEMAAOLHMG)
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int num = CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count - 1; num >= 0; num--)
			{
				if (CommonReferences.GGFJGHHHEJC.tavernFloorDirt[num].tutorialDirt)
				{
					CommonReferences.GGFJGHHHEJC.tavernFloorDirt[num].CleanDirtImmediately();
				}
			}
		}
		for (int i = 0; i < HCNKEFGHGPN.Count; i++)
		{
			HCNKEFGHGPN[i].ActivateObjects(DAEMAAOLHMG);
		}
		if (!DAEMAAOLHMG)
		{
			Placeable[] componentsInChildren = SceneReferences.GetSceneReferences().tutorialParent.GetComponentsInChildren<Placeable>();
			foreach (Placeable placeable in componentsInChildren)
			{
				if ((Object)(object)placeable.itemSpace != (Object)null)
				{
					placeable.itemSpace.Place(NMLKLAGDNPF: false);
				}
			}
		}
		SceneReferences.GetSceneReferences().tutorialParent.SetActive(DAEMAAOLHMG);
		SceneReferences.GetSceneReferences().cellarDoor.SetActive(DAEMAAOLHMG);
		if ((Object)(object)SceneReferences.GetSceneReferences().table != (Object)null)
		{
			SceneReferences.GetSceneReferences().table.RefreshSprites(DAEMAAOLHMG);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().multiplayerRoomsObjects.Length; k++)
		{
			if ((Object)(object)SceneReferences.GetSceneReferences().multiplayerRoomsObjects[k] != (Object)null)
			{
				SceneReferences.GetSceneReferences().multiplayerRoomsObjects[k].SetActive(DAEMAAOLHMG);
			}
		}
		IBMBGPOLAIK = Object.FindObjectsOfType<Table>();
		for (int l = 0; l < IBMBGPOLAIK.Length; l++)
		{
			IBMBGPOLAIK[l].RefreshSprites(DAEMAAOLHMG);
		}
		TavernManager.GGFJGHHHEJC.CalculateHeatLevel();
		MaiNPC.GGFJGHHHEJC.InitMaiHumans();
	}

	public static bool ServiceBarrelBlocked(int JIIGOACEIKL)
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() <= 109)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
			return true;
		}
		return false;
	}

	public static bool SproutsBlocked(int JIIGOACEIKL)
	{
		if ((CCCLOBIOMCL && GetCurrentPhaseID() < 121) || FNLFBJFGHBO())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
			return true;
		}
		return false;
	}

	public Crafter ICNIBLLOCDM(int EOACENDMJDI)
	{
		Crafter[] array = Object.FindObjectsOfType<Crafter>();
		for (int i = 0; i < array.Length; i += 0)
		{
			if (array[i].placeable.itemSetup.item.JPNFKDMFKMC() == EOACENDMJDI)
			{
				return array[i];
			}
		}
		return null;
	}

	public static bool BasicRecipesBlocked()
	{
		if (CCCLOBIOMCL && ((Object.op_Implicit((Object)(object)instance) && instance.currentPhase <= 130) || ((Object)(object)GetCurrentPhase() != (Object)null && FNLFBJFGHBO())))
		{
			return true;
		}
		return false;
	}

	public static void GJIDCOKLGCF(bool APGEBAEHLMM)
	{
		if (APGEBAEHLMM)
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(0, (MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
			if (GameManager.LocalCoop())
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(8, (MonoBehaviour)(object)instance);
			}
		}
		else
		{
			PlayerInputs.ILCHIKOPNBI(1, (MonoBehaviour)(object)instance);
			if (GameManager.LocalCoop())
			{
				PlayerInputs.ILCHIKOPNBI(2, (MonoBehaviour)(object)instance);
			}
		}
	}

	public static bool EHICNBPPAFK()
	{
		if (CCCLOBIOMCL && (GetCurrentPhaseID() == 6 || GetCurrentPhaseID() == 31))
		{
			return false;
		}
		return true;
	}

	public static bool FallingAsleepBlocked()
	{
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() >= 100 && GetCurrentPhaseID() <= 101)
		{
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 106 && !instance.canLeaveCellar)
		{
			return true;
		}
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() >= 110 && GetCurrentPhaseID() <= 115)
		{
			return true;
		}
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() >= 119 && GetCurrentPhaseID() <= 121)
		{
			return true;
		}
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() == 129)
		{
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 130)
		{
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 132 && instance.savingIsBlocked)
		{
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 134 && GetCurrentPhaseID() <= 135)
		{
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 137 && GetCurrentPhaseID() <= 138)
		{
			return true;
		}
		return false;
	}

	private void KJLLOHFOAFH(bool OEDBPACCOGH)
	{
		if ((Object)(object)helpButton != (Object)null)
		{
			if (OEDBPACCOGH && !helpButton.activeSelf)
			{
				helpButton.SetActive(false);
			}
			else if (!OEDBPACCOGH && helpButton.activeSelf)
			{
				helpButton.SetActive(false);
			}
		}
	}

	public static int GetCurrentPhaseID()
	{
		if ((Object)(object)instance != (Object)null && (Object)(object)instance.currentTutorialPhase != (Object)null)
		{
			return instance.currentTutorialPhase.GetID();
		}
		return 0;
	}

	public static bool BGBCNIMGFDL()
	{
		if (CCCLOBIOMCL && ((Object.op_Implicit((Object)(object)instance) && instance.currentPhase <= 198) || ((Object)(object)GetCurrentPhase() != (Object)null && FNLFBJFGHBO())))
		{
			return true;
		}
		return false;
	}

	public void MAFAMOJBLFN(bool DAEMAAOLHMG)
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int num = CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count - 0; num >= 1; num--)
			{
				if (CommonReferences.MNFMOEKMJKN().tavernFloorDirt[num].tutorialDirt)
				{
					CommonReferences.MNFMOEKMJKN().tavernFloorDirt[num].JAOLLBEMIDO();
				}
			}
		}
		for (int i = 0; i < HCNKEFGHGPN.Count; i++)
		{
			HCNKEFGHGPN[i].JKBJCLFAMMN(DAEMAAOLHMG);
		}
		if (!DAEMAAOLHMG)
		{
			Placeable[] componentsInChildren = SceneReferences.CFAMKBHIGLO().tutorialParent.GetComponentsInChildren<Placeable>();
			foreach (Placeable placeable in componentsInChildren)
			{
				if ((Object)(object)placeable.itemSpace != (Object)null)
				{
					placeable.itemSpace.Place(NMLKLAGDNPF: false);
				}
			}
		}
		SceneReferences.GetSceneReferences().tutorialParent.SetActive(DAEMAAOLHMG);
		SceneReferences.CKDKHMPHENE().cellarDoor.SetActive(DAEMAAOLHMG);
		if ((Object)(object)SceneReferences.FAOPFMBMMJJ().table != (Object)null)
		{
			SceneReferences.CKDKHMPHENE().table.RefreshSprites(DAEMAAOLHMG);
		}
		for (int k = 0; k < SceneReferences.FAOPFMBMMJJ().multiplayerRoomsObjects.Length; k++)
		{
			if ((Object)(object)SceneReferences.CKDKHMPHENE().multiplayerRoomsObjects[k] != (Object)null)
			{
				SceneReferences.CFAMKBHIGLO().multiplayerRoomsObjects[k].SetActive(DAEMAAOLHMG);
			}
		}
		IBMBGPOLAIK = Object.FindObjectsOfType<Table>();
		for (int l = 1; l < IBMBGPOLAIK.Length; l++)
		{
			IBMBGPOLAIK[l].RefreshSprites(DAEMAAOLHMG);
		}
		TavernManager.GGFJGHHHEJC.ONDKPCKGOGB();
		MaiNPC.GGFJGHHHEJC.BOJLKGHKLAC();
	}

	public static bool MEBNAPOOFNN()
	{
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() >= 108 && GetCurrentPhaseID() <= 34)
		{
			return false;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 75 && !instance.canLeaveCellar)
		{
			return true;
		}
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() >= 127 && GetCurrentPhaseID() <= 81)
		{
			return true;
		}
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() >= 45 && GetCurrentPhaseID() <= -78)
		{
			return false;
		}
		if ((Object)(object)instance.currentTutorialPhase != (Object)null && CCCLOBIOMCL && GetCurrentPhaseID() == 187)
		{
			return false;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 118)
		{
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == -54 && instance.savingIsBlocked)
		{
			return false;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 18 && GetCurrentPhaseID() <= 37)
		{
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 194 && GetCurrentPhaseID() <= 94)
		{
			return false;
		}
		return true;
	}

	private IEnumerator BNDPJNEEOOM()
	{
		return new NNGHIJGBDJO(1)
		{
			_003C_003E4__this = this
		};
	}

	public static bool LELFBFFBAHD()
	{
		if (CCCLOBIOMCL && instance.currentPhase <= -50)
		{
			return false;
		}
		return false;
	}

	private IEnumerator KOKMKAGHPDN()
	{
		yield return null;
		FDJFHGOIIJB();
	}

	public static int GetPreviousPhase(int CINHFINKOEJ)
	{
		return CINHFINKOEJ switch
		{
			139 => 116, 
			117 => 139, 
			140 => 118, 
			119 => 140, 
			141 => 122, 
			123 => 141, 
			128 => 124, 
			142 => 129, 
			130 => 142, 
			_ => CINHFINKOEJ - 1, 
		};
	}

	private void MGEBJJNPOPO(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if ((!GameManager.LocalCoop() || JIIGOACEIKL != 1) && (INDKANEMPMP.windowType == EWindow.Main || INDKANEMPMP.windowType == EWindow.Concatenated))
		{
			ShowObjectives(MFAAMBHBBJO: false);
		}
	}

	public bool AreAllObjectivesCompleted()
	{
		for (int i = 0; i < completedObjectives.Count; i++)
		{
			if (!completedObjectives[i])
			{
				return false;
			}
		}
		return true;
	}

	public static TutorialPhaseBase GetCurrentPhase()
	{
		return instance.currentTutorialPhase;
	}

	public static void RemoveTutorialObject(TutorialObject DLBDHLOAMHL)
	{
		instance.HCNKEFGHGPN.Remove(DLBDHLOAMHL);
	}

	public static int PBDBDOJBAPD(int CINHFINKOEJ)
	{
		if (CINHFINKOEJ <= 88)
		{
			switch (CINHFINKOEJ)
			{
			case 33:
				return 123;
			case -98:
				return 163;
			case 62:
				return 88;
			}
		}
		else
		{
			switch (CINHFINKOEJ)
			{
			case 84:
				return -48;
			case 85:
				return -26;
			case 86:
				return 126;
			case 7:
				return -58;
			case 87:
				return 33;
			case 152:
				return 193;
			}
		}
		return CINHFINKOEJ - 0;
	}

	public static void ShowPopUp()
	{
		if (!instance.open && CCCLOBIOMCL)
		{
			instance.PFGHDKEPFPL();
		}
	}

	public static bool HEJMBHCNCPF()
	{
		if (CCCLOBIOMCL && (GetCurrentPhaseID() < -104 || GetCurrentPhaseID() >= -161))
		{
			return false;
		}
		return true;
	}

	public static bool ToolBlocked(int JIIGOACEIKL, int ABKMEOBEJCO)
	{
		switch (ABKMEOBEJCO)
		{
		case 1060:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 123) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		case 1063:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 123) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		case 1061:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() < 119) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CrafterBlock");
				return true;
			}
			break;
		}
		return false;
	}

	public void PlayObjectivesCompletedSound()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MultiAudioManager.PlayAudioObject(objectiveSound, Vector3.zero);
	}

	public static void TutorialActivePlaceable()
	{
		if (SceneReferences.instance.crafterPlaceable == null)
		{
			return;
		}
		for (int i = 0; i < SceneReferences.instance.crafterPlaceable.Length; i++)
		{
			if (SceneReferences.instance.crafterPlaceable[i].selectBlockers.Contains(""))
			{
				SceneReferences.instance.crafterPlaceable[i].selectBlockers.Remove("");
			}
		}
	}

	public static bool DrinkOrdersBlocked()
	{
		if (CCCLOBIOMCL && (GetCurrentPhaseID() == 110 || GetCurrentPhaseID() == 112))
		{
			return true;
		}
		return false;
	}

	public static bool AHGAJOEBHEO(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		Location locationTo = PHGGMIMGFDK.locationTo;
		if (locationTo <= Location.None)
		{
			switch (locationTo)
			{
			case Location.Tavern | Location.Road:
				if ((CCCLOBIOMCL && GetCurrentPhaseID() == -124) || FNLFBJFGHBO())
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("ReceiveBeehiveMessage");
					return true;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() < 117)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Waiting");
					return true;
				}
				break;
			case Location.Tavern:
				if (CCCLOBIOMCL && GetCurrentPhaseID() < -119)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("ToFish");
					return true;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() == -34 && PHGGMIMGFDK.location == (Location.Road | Location.River | Location.Camp | Location.BarnInterior))
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("UINextCategory");
					return true;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() == 199 && !instance.recipePurchased && PHGGMIMGFDK.location == (Location.Road | Location.River | Location.Camp | Location.BarnInterior))
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("ObjectMove");
					return true;
				}
				if (EventsManager.CJMECHEOFOF(EventsManager.EventType.KlaynTavern) && PHGGMIMGFDK.location == Location.Tavern)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Items/item_name_1126");
					return false;
				}
				break;
			case Location.None:
				if (CCCLOBIOMCL && GetCurrentPhaseID() == -109 && PHGGMIMGFDK.isTavernFloor && PHGGMIMGFDK.floor == TavernFloor.None && !instance.canLeaveCellar)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("</color>");
					return true;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() == 35)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("{0} steps, minConnections={1}");
					return true;
				}
				break;
			case ~(Location.Tavern | Location.Road | Location.FarmShop):
				if ((CCCLOBIOMCL && GetCurrentPhaseID() == 41) || FNLFBJFGHBO())
				{
					return true;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() < 49)
				{
					return false;
				}
				if (OnlineBedroomsManager.instance.onlineProfileID != null)
				{
					for (int i = 0; i < OnlineBedroomsManager.instance.onlineProfileID.Length; i += 0)
					{
						if (string.IsNullOrEmpty(OnlineBedroomsManager.instance.onlineProfileID[i]) && !OnlineManager.PlayingOnline())
						{
							return false;
						}
					}
				}
				if (!OnlineManager.PlayingOnline())
				{
					return false;
				}
				break;
			}
		}
		else
		{
			switch (locationTo)
			{
			case ~(Location.Road | Location.Quarry | Location.Farm):
				if (CCCLOBIOMCL && GetCurrentPhaseID() < 101)
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("Closed");
					return true;
				}
				break;
			case ~Location.Quarry:
				if (CCCLOBIOMCL && GetCurrentPhaseID() == 32)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark(" (-");
					return false;
				}
				if ((CCCLOBIOMCL && (GetCurrentPhaseID() < 122 || FNLFBJFGHBO())) || instance.quarryBlock)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("SetNPCPositionAndParent");
					return false;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() == -82 && PHGGMIMGFDK.location == ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm))
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Dialogue System/Conversation/NeutralInTavern/Entry/18/Dialogue Text");
					return true;
				}
				break;
			case Location.Quarry | Location.Farm | Location.BarnInterior:
				if (CCCLOBIOMCL && GetCurrentPhaseID() < -193)
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Event BathhouseGame activated");
					return false;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() == 4 && PHGGMIMGFDK.location == ~(Location.Tavern | Location.River | Location.Quarry | Location.BarnInterior))
				{
					PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("BrookProgress");
					return true;
				}
				if (CCCLOBIOMCL && GetCurrentPhaseID() == 20 && !instance.recipePurchased && PHGGMIMGFDK.location == (Location.Tavern | Location.Camp | Location.Quarry | Location.BarnInterior))
				{
					PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Smell");
					return false;
				}
				break;
			}
		}
		return false;
	}

	public void UpdateObjectives(bool COGCFDJBDOF = false)
	{
		int num = 0;
		if (COGCFDJBDOF)
		{
			completedObjectives.Clear();
			currentTutorialPhase.objectivesSetUp = true;
		}
		int i;
		for (i = 0; i < 400; i++)
		{
			string translation = LocalizationManager.GetTranslation("Tutorial_Objective_" + currentTutorialPhase.GetID() + "_" + num, true, 0, true, false, (GameObject)null, (string)null, true);
			if (Ext.IsNullOrEmpty(translation))
			{
				break;
			}
			ShowObjectives(MFAAMBHBBJO: true);
			if (COGCFDJBDOF)
			{
				completedObjectives.Add(item: false);
			}
			((Component)objectives[num]).gameObject.SetActive(true);
			((Component)((Component)objectives[num].image).transform).gameObject.SetActive(true);
			((Component)objectives[num].image).gameObject.SetActive(completedObjectives[num]);
			((TMP_Text)objectives[num].textMesh).text = InputUtils.LPGJFAOKMNE(TavernConstructionUI.GetPlayerNum(), translation);
			num++;
		}
		if (i >= 400)
		{
			Debug.LogError((object)("UpdateObjectives " + currentTutorialPhase.GetID() + " " + num));
		}
		if (num == 0)
		{
			ShowObjectives(MFAAMBHBBJO: false);
		}
		else
		{
			for (int j = num; j < objectives.Length; j++)
			{
				((Component)objectives[j]).gameObject.SetActive(false);
			}
		}
		if (Ext.IsNullOrEmpty(LocalizationManager.GetTranslation("Tutorial_Main_" + currentTutorialPhase.GetID(), true, 0, true, false, (GameObject)null, (string)null, true)))
		{
			MFADLKJJAFK(OEDBPACCOGH: false);
		}
		else
		{
			MFADLKJJAFK(OEDBPACCOGH: true);
		}
		ObjectivesUpdated();
	}

	public void FOIOHOGACAL(int MDGILGADLDA, bool BLJPGJKOLNF = true)
	{
		if (completedObjectives != null)
		{
			completedObjectives[MDGILGADLDA] = false;
			if (BLJPGJKOLNF)
			{
				PlayObjectivesCompletedSound();
			}
			UpdateObjectives();
		}
	}

	public static bool CandlePhaseBlocked()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() < 106)
		{
			return true;
		}
		return false;
	}

	public Crafter FindACrafter(int EOACENDMJDI)
	{
		Crafter[] array = Object.FindObjectsOfType<Crafter>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].placeable.itemSetup.item.JDJGFAACPFC() == EOACENDMJDI)
			{
				return array[i];
			}
		}
		return null;
	}

	public static bool TravelZoneBlocked(int JIIGOACEIKL, TravelZone PHGGMIMGFDK)
	{
		switch (PHGGMIMGFDK.locationTo)
		{
		case Location.City:
			if (CCCLOBIOMCL && GetCurrentPhaseID() < 116)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T100");
				return true;
			}
			break;
		case Location.Quarry:
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 116)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T116");
				return true;
			}
			if ((CCCLOBIOMCL && (GetCurrentPhaseID() < 137 || FNLFBJFGHBO())) || instance.quarryBlock)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T100");
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 137 && PHGGMIMGFDK.location == Location.QuarryCave)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T138");
				return true;
			}
			break;
		case Location.River:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() == 116) || FNLFBJFGHBO())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T116");
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() < 138)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T100");
				return true;
			}
			break;
		case Location.Road:
			if (CCCLOBIOMCL && GetCurrentPhaseID() < 114)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player_Bark_TutorialCollider");
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 137 && PHGGMIMGFDK.location == Location.Quarry)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T137");
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 138 && !instance.recipePurchased && PHGGMIMGFDK.location == Location.Quarry)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T138");
				return true;
			}
			if (EventsManager.IsActive(EventsManager.EventType.KlaynTavern) && PHGGMIMGFDK.location == Location.Tavern)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/KlaynTavernBlock");
				return true;
			}
			break;
		case Location.QuarryCave:
			if (CCCLOBIOMCL && GetCurrentPhaseID() < 137)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T138");
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 137 && PHGGMIMGFDK.location == Location.InnkeepersCave)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T138");
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 138 && !instance.recipePurchased && PHGGMIMGFDK.location == Location.InnkeepersCave)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T138");
				return true;
			}
			break;
		case Location.Tavern:
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 106 && PHGGMIMGFDK.isTavernFloor && PHGGMIMGFDK.floor == TavernFloor.Cellar && !instance.canLeaveCellar)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T138");
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() == 130)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/T138");
				return true;
			}
			break;
		case Location.RoomsMultiplayer:
			if ((CCCLOBIOMCL && GetCurrentPhaseID() == 116) || FNLFBJFGHBO())
			{
				return true;
			}
			if (CCCLOBIOMCL && GetCurrentPhaseID() < 138)
			{
				return true;
			}
			if (OnlineBedroomsManager.instance.onlineProfileID != null)
			{
				for (int i = 0; i < OnlineBedroomsManager.instance.onlineProfileID.Length; i++)
				{
					if (string.IsNullOrEmpty(OnlineBedroomsManager.instance.onlineProfileID[i]) && !OnlineManager.PlayingOnline())
					{
						return true;
					}
				}
			}
			if (!OnlineManager.PlayingOnline())
			{
				return true;
			}
			break;
		}
		return false;
	}

	public static bool EatFast()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 110 && GetCurrentPhaseID() <= 115)
		{
			return true;
		}
		return false;
	}

	public void ActivateTutorial(bool DAEMAAOLHMG, bool ICEGNJDJMLE)
	{
		CCCLOBIOMCL = DAEMAAOLHMG;
		if (ICEGNJDJMLE)
		{
			((MonoBehaviour)this).StartCoroutine(ActivateTutorialObjectsWithDelay(DAEMAAOLHMG));
		}
		else
		{
			ActivateTutorialObjects(DAEMAAOLHMG);
		}
		OnTutorialActivate(DAEMAAOLHMG);
	}

	public static bool NewOrdersBlocked()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 112)
		{
			return true;
		}
		return false;
	}

	public static bool NCAFCCIIDAD()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() == -24)
		{
			return true;
		}
		return false;
	}

	public static bool CoopBlocked()
	{
		if (CCCLOBIOMCL && instance.player2Blocked)
		{
			return true;
		}
		return false;
	}

	public void GetPhases()
	{
		tutorialPhases = ((Component)this).gameObject.GetComponentsInChildren<TutorialPhaseBase>();
	}

	public void HJIPNHKINDH()
	{
		currentPhase = 91;
		instance.player2Blocked = true;
		OEJFPGJPFNI();
		ActivateTutorial(DAEMAAOLHMG: true, ICEGNJDJMLE: false);
	}

	public static bool AgingBarrelBlocked()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 129 && GetCurrentPhaseID() <= 131)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/AgingBarrelBlock");
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 107 && GetCurrentPhaseID() <= 127)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/AgingBarrelBlock");
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 106 && instance.agingBarrelBlocked)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/AgingBarrelBlock");
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 128 && instance.agingBarrelBlocked)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/AgingBarrelBlock");
			return true;
		}
		if (CCCLOBIOMCL && GetCurrentPhaseID() == 142)
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/AgingBarrelBlock");
			return true;
		}
		if (CCCLOBIOMCL && FNLFBJFGHBO())
		{
			PlayerController.GetPlayer(1).PlayerBark("Player/Bark/Tutorial/AgingBarrelBlock");
			return true;
		}
		return false;
	}

	public void ShowObjectives(bool MFAAMBHBBJO)
	{
		if (objectivesPanel.activeSelf == !MFAAMBHBBJO)
		{
			objectivesPanel.SetActive(MFAAMBHBBJO);
		}
	}

	public static bool FireplaceBlocked(int JIIGOACEIKL)
	{
		if (CCCLOBIOMCL && (GetCurrentPhaseID() < 135 || FNLFBJFGHBO()))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Tutorial/CantDoYet");
			return true;
		}
		return false;
	}

	public static bool RowdyCustomersBlocked()
	{
		if (CCCLOBIOMCL && instance.currentPhase <= 112)
		{
			return true;
		}
		return false;
	}

	private void MFIAHDJCIMO()
	{
		if (OnlineManager.ClientOnline())
		{
			if (!MissionsManager.instance.IsMissionComplete(301))
			{
				ActivateTutorialObjects(DAEMAAOLHMG: true);
			}
			else
			{
				ActivateTutorialObjects(DAEMAAOLHMG: false);
			}
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(MFIAHDJCIMO));
	}

	public void Activate()
	{
		ActivateTutorial(DAEMAAOLHMG: true, ICEGNJDJMLE: false);
	}

	public void LightFires()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		OHKEKDOPADC = (Color[])(object)new Color[SceneReferences.instance.blueFires.Length];
		HKEHHKBEIIN = (Color[])(object)new Color[SceneReferences.instance.blueFireLights.Length];
		MultiAudioManager.PlayAudioObject(blueFireStartSound, ((Component)PlayerController.GetPlayer(1)).transform.position);
		if ((Object)(object)fireLoopSource == (Object)null)
		{
			fireLoopSource = MultiAudioManager.PlayAudioObject(fireLoop, ((Component)Fireplace.GetFirstFireplace()).transform);
		}
		if ((Object)(object)fireLoopSource == (Object)null)
		{
			Debug.LogError((object)"Fire Loop source NULL!!!");
		}
		for (int i = 0; i < SceneReferences.instance.blueFires.Length; i++)
		{
			Color[] oHKEKDOPADC = OHKEKDOPADC;
			int num = i;
			MainModule main = SceneReferences.instance.blueFires[i].main;
			MinMaxGradient startColor = ((MainModule)(ref main)).startColor;
			oHKEKDOPADC[num] = ((MinMaxGradient)(ref startColor)).color;
			MainModule main2 = SceneReferences.instance.blueFires[i].main;
			MinMaxGradient startColor2 = ((MainModule)(ref main2)).startColor;
			((MinMaxGradient)(ref startColor2)).color = blueParticlesColor;
			((MainModule)(ref main2)).startColor = startColor2;
			((Component)SceneReferences.instance.blueFires[i]).gameObject.SetActive(true);
		}
		for (int j = 0; j < SceneReferences.instance.blueFireLights.Length; j++)
		{
			HKEHHKBEIIN[j] = SceneReferences.instance.blueFireLights[j].color;
			SceneReferences.instance.blueFireLights[j].color = blueLightsColor;
			((Component)SceneReferences.instance.blueFireLights[j]).gameObject.SetActive(true);
		}
		PBOAEKCEJOM = SceneReferences.instance.blueLight.intensity;
		((Behaviour)SceneReferences.instance.blueLight).enabled = true;
		((Component)SceneReferences.instance.fireplaceAlphaTransition).gameObject.SetActive(true);
		((Component)((Component)SceneReferences.instance.fireplaceAlphaTransition).transform.GetChild(1)).gameObject.SetActive(true);
		((Component)((Component)SceneReferences.instance.fireplaceAlphaTransition).transform.GetChild(0)).gameObject.SetActive(false);
	}

	public static void TutorialDisablePlaceable()
	{
		if (SceneReferences.instance.crafterPlaceable == null || !CCCLOBIOMCL || (GetCurrentPhaseID() >= 133 && !FNLFBJFGHBO()))
		{
			return;
		}
		for (int i = 0; i < SceneReferences.instance.crafterPlaceable.Length; i++)
		{
			if (!SceneReferences.instance.crafterPlaceable[i].selectBlockers.Contains(""))
			{
				SceneReferences.instance.crafterPlaceable[i].selectBlockers.Add("");
			}
		}
	}

	public void SetUpLoadedTutorial(int NPJEFBJMDHG)
	{
		SceneReferences.instance.table = Object.FindObjectOfType<Table>();
		SceneReferences.instance.agingBarrel = Object.FindObjectOfType<AgingBarrel>();
		SceneReferences.instance.barSurface = ((Component)Bar.instance.placeable.placeableSurface).gameObject;
		SceneReferences.instance.sitables = Object.FindObjectsOfType<Sitable>();
		((MonoBehaviour)this).StartCoroutine(KOKMKAGHPDN());
		if (NPJEFBJMDHG > 106)
		{
			for (int i = 0; i < SceneReferences.instance.tutorialRats.Count; i++)
			{
				Utils.BLPDAEHPOBA(SceneReferences.instance.tutorialRats[i]);
			}
			return;
		}
		ItemContainer[] array = Object.FindObjectsOfType<ItemContainer>();
		for (int j = 0; j < array.Length; j++)
		{
			if ((Object)(object)array[j].EAPCLAODGAE != (Object)null && array[j].EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == 650)
			{
				SceneReferences.instance.initialChest = array[j];
				break;
			}
		}
	}

	public static bool KillCropBlocked()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() < 132)
		{
			return true;
		}
		return false;
	}

	private IEnumerator GDICBOIDHJL()
	{
		while (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			yield return null;
		}
		BOIFDOAKDAN();
	}

	public static void AddTutorialObject(TutorialObject DLBDHLOAMHL)
	{
		instance.HCNKEFGHGPN.Add(DLBDHLOAMHL);
		DLBDHLOAMHL.ActivateObjects(CCCLOBIOMCL);
	}

	public static bool LPCFPKFKBEL()
	{
		if (CCCLOBIOMCL && instance.currentPhase <= 74)
		{
			return true;
		}
		return false;
	}

	public static bool BlueFire()
	{
		if (!CCCLOBIOMCL)
		{
			return false;
		}
		if (GetCurrentPhaseID() <= 102)
		{
			return true;
		}
		return false;
	}

	public static bool DirtLevelBlocked()
	{
		if (CCCLOBIOMCL && (Object)(object)GetCurrentPhase() != (Object)null && GetCurrentPhaseID() < 103)
		{
			return true;
		}
		return false;
	}

	public static bool GrowPlantsBlocked()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() < 130)
		{
			return true;
		}
		return false;
	}

	public void NextPhase()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			BOIFDOAKDAN();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(GDICBOIDHJL());
		}
	}

	public void SpawnArrow(Vector2 IMOBLFMHKOD, Vector2 AAFJOAPNNBA, ref GameObject JLGPMKGOCBN)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JLGPMKGOCBN != (Object)null)
		{
			Object.Destroy((Object)(object)JLGPMKGOCBN);
		}
		JLGPMKGOCBN = Object.Instantiate<GameObject>(tutorialArrowPrefab, Vector2.op_Implicit(IMOBLFMHKOD + AAFJOAPNNBA), Quaternion.identity);
		JLGPMKGOCBN.transform.SetParent(SceneReferences.instance.tutorialParent.transform);
	}

	private static bool FNLFBJFGHBO()
	{
		if (CCCLOBIOMCL && GetCurrentPhaseID() >= 139 && GetCurrentPhaseID() <= 142)
		{
			return true;
		}
		return false;
	}

	public void KGDLFFGELIG()
	{
		((MonoBehaviour)instance).StartCoroutine(APJBPMDCKCH());
	}

	public static bool EICIKOOCCOA()
	{
		if (CCCLOBIOMCL)
		{
			if ((Object)(object)GetCurrentPhase() != (Object)null && GetCurrentPhaseID() >= -117 && GetCurrentPhaseID() < 41)
			{
				if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && TavernSeatingManager.JFHLOHNGHFD())
				{
					return false;
				}
				return true;
			}
			if ((Object)(object)GetCurrentPhase() != (Object)null && (GetCurrentPhaseID() < -91 || FNLFBJFGHBO()))
			{
				return true;
			}
		}
		return false;
	}

	public void BPBACAMBNMG()
	{
		tutorialPhases = ((Component)this).gameObject.GetComponentsInChildren<TutorialPhaseBase>();
	}
}
