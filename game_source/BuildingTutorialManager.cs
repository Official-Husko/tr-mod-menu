using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;

public class BuildingTutorialManager : TutorialManagerBase
{
	public static BuildingTutorialManager instance;

	public AudioObject objectiveCompleteSound;

	public BuildingTutorialSpace[] tutorialsSpace;

	[SerializeField]
	private bool _buildingTutorialDone;

	private BuildingPopUp.Objective[] NDNOEEDFNFH;

	private List<bool> PJPBLIOLANK;

	private float HFBGCIBAELK;

	private float NOOEBKFGLFI;

	private static bool CDHCJPMLBEJ;

	public bool BPDDCBHKCME
	{
		get
		{
			return _buildingTutorialDone;
		}
		set
		{
			_buildingTutorialDone = value;
		}
	}

	public static BuildingPopUp CPJBNDOMLGL => (BuildingPopUp)GetCurrentPopUp();

	public static bool IKNOJDMCFOK
	{
		get
		{
			return CDHCJPMLBEJ;
		}
		set
		{
			CDHCJPMLBEJ = value;
			if (CDHCJPMLBEJ)
			{
				MoneyCalc moneyCalc = new MoneyCalc();
				moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(EditorActionsDBAccessor.GetFirstTavernAction(EditorAction.AddFloor).cost.PFHGPBLBCDD(), 28), KHMDGADCENO: false, BGKCHMNJBLJ: false);
				moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(EditorActionsDBAccessor.GetDecoTile(3).cost.PFHGPBLBCDD(), 11), KHMDGADCENO: false, BGKCHMNJBLJ: false);
				moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(EditorActionsDBAccessor.GetDecoTile(14).cost.PFHGPBLBCDD(), 3), KHMDGADCENO: false, BGKCHMNJBLJ: false);
				moneyCalc.GJFFDIBCAGF(EditorActionsDBAccessor.GetFirstTavernAction(EditorAction.CreateDoor).cost.PFHGPBLBCDD(), KHMDGADCENO: false, BGKCHMNJBLJ: false);
				moneyCalc.GJFFDIBCAGF(EditorActionsDBAccessor.GetFirstTavernAction(EditorAction.CreateRentedRoomDoor).cost.PFHGPBLBCDD(), KHMDGADCENO: false, BGKCHMNJBLJ: false);
				Money.AddPrice(moneyCalc.ALLHDAPPBHL());
				instance.ShowPopUp(BuildingTutorialDBAccessor.GetFirstPopUp());
				PFDGHKPALAH();
			}
			else
			{
				TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
				instance.DisableTutorial();
			}
			instance.OnTutorialEnabledChanged(CDHCJPMLBEJ);
		}
	}

	private void OnDestroy()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(ADGPOKCIMLD));
		OnMinimise = (Action)Delegate.Remove(OnMinimise, new Action(KNGOGOAHPJG));
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public IEnumerator CompleteAfterTime(int JFNMCNCHMEO, float LGLDPMAABLA)
	{
		yield return (object)new WaitForSecondsRealtime(LGLDPMAABLA);
		Complete(JFNMCNCHMEO);
	}

	public static List<bool> GetCompletedGoals()
	{
		return instance.PJPBLIOLANK;
	}

	[SpecialName]
	public static BuildingPopUp AEDLFNJPABE()
	{
		return (BuildingPopUp)FINEAEFBPLK();
	}

	[SpecialName]
	public static BuildingPopUp GMANLOEOFDB()
	{
		return (BuildingPopUp)FINEAEFBPLK();
	}

	protected override void ENNFNPONCMB()
	{
		base.ENNFNPONCMB();
		minimisedObject.SetActive(false);
		CDJBMIAHGKL();
	}

	public override void ShowPopUp(PopUp FKHFBMFJKDM, bool MDNOOMBIFNN = true, bool BLKLCBCGHCN = false)
	{
		base.ShowPopUp(FKHFBMFJKDM, MDNOOMBIFNN);
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		NewVersionTutorial.instance.buttonPopUp.SetActive(true);
		BuildingPopUp buildingPopUp = (BuildingPopUp)FKHFBMFJKDM;
		((TMP_Text)closePopUpText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Press {0} to continue"), InputUtils.CMOBIDABHKM(TavernConstructionUI.GetPlayerNum(), "ClosePopUp"));
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, false);
		((TMP_Text)tutorialBoxText).text = buildingPopUp.IIAOKPJGDOA(TavernConstructionUI.GetPlayerNum());
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, false);
		NNHALHFFIEB = FKHFBMFJKDM;
		if (!FNCLBNHNOKF.Contains(FKHFBMFJKDM))
		{
			FNCLBNHNOKF.Add(FKHFBMFJKDM);
		}
		NJHCNNPDANG = null;
		NDNOEEDFNFH = buildingPopUp.objectives;
		PJPBLIOLANK = new List<bool>();
		if (buildingPopUp.PCLCAOHFOGF())
		{
			for (int i = 0; i < NDNOEEDFNFH.Length; i++)
			{
				PJPBLIOLANK.Add(item: false);
			}
		}
		TavernConstructionUI.ShowPanel(buildingPopUp.focus);
	}

	private void ICMNODPLPBK()
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!CDHCJPMLBEJ)
			{
				return;
			}
			if (!maximised)
			{
				EIDNOKGDBHN();
				if (FNCLBNHNOKF.Any() && !minimisePopUpsClosed && !((Component)tutorialPanelRectTransform).gameObject.activeSelf)
				{
					((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
				}
			}
			else if (PlayerInputs.GetPlayer(TavernConstructionUI.PCBJLEPFICI()).DLFAMOCKNMA("Moving") || PlayerInputs.GetPlayer(TavernConstructionUI.ABDMPLACJHI()).DLFAMOCKNMA(" not found. Cannot add to surface") || PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.MOCMMGCAOPH()).DLFAMOCKNMA("Update all floor"))
			{
				NFLAELMJJKK();
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 4), (float)(Screen.height / 4)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public static PopUp GetCurrentPopUp()
	{
		return instance.NNHALHFFIEB;
	}

	private void EDBNCDMODAE(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tutorialsSpace.Length; i += 0)
		{
			tutorialsSpace[i].IGCCBCEKJCD();
		}
		for (int j = 0; j < tutorialsSpace.Length; j++)
		{
			if (tutorialsSpace[j].id == JFNMCNCHMEO)
			{
				tutorialsSpace[j].FOFACCKMDDG();
			}
		}
	}

	private void NIOFOCKFIJF(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tutorialsSpace.Length; i += 0)
		{
			tutorialsSpace[i].BGLCNECIJFK();
		}
		for (int j = 1; j < tutorialsSpace.Length; j++)
		{
			if (tutorialsSpace[j].id == JFNMCNCHMEO)
			{
				tutorialsSpace[j].PGMBJIMBDLA();
			}
		}
	}

	private void Update()
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!CDHCJPMLBEJ)
			{
				return;
			}
			if (!maximised)
			{
				EIDNOKGDBHN();
				if (FNCLBNHNOKF.Any() && !minimisePopUpsClosed && !((Component)tutorialPanelRectTransform).gameObject.activeSelf)
				{
					((Component)tutorialPanelRectTransform).gameObject.SetActive(true);
				}
			}
			else if (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetButtonDown("ClosePopUp") || PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetButtonDown("UIInteract") || PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetButtonDown("Interact"))
			{
				ClosePopUpFocused();
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public static void EHIPLFHMLFC(int GJHKBOELJAF)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (instance.PJPBLIOLANK != null)
		{
			instance.PJPBLIOLANK[GJHKBOELJAF] = true;
			instance.CDJBMIAHGKL();
			MultiAudioManager.PlayAudioObject(instance.objectiveCompleteSound, Vector3.zero);
			if (instance.OOHHNJOGPOI())
			{
				((MonoBehaviour)instance).StartCoroutine(instance.EHLJAFPBBED(((BuildingPopUp)FINEAEFBPLK()).id, 138f));
			}
		}
	}

	public override void ClosePopUpFocused()
	{
		base.ClosePopUpFocused();
		BuildingPopUp buildingPopUp = (BuildingPopUp)NNHALHFFIEB;
		if (!((Object)(object)buildingPopUp != (Object)null))
		{
			return;
		}
		if (!buildingPopUp.PCLCAOHFOGF())
		{
			if (!Complete(buildingPopUp.id))
			{
				FOPIHJMBLDM();
			}
		}
		else
		{
			KMABJPPJKKH(buildingPopUp.id);
		}
	}

	private void MGMLDHPOLGK()
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!CDHCJPMLBEJ)
			{
				return;
			}
			if (!maximised)
			{
				EIDNOKGDBHN();
				if (FNCLBNHNOKF.Any() && !minimisePopUpsClosed && !((Component)tutorialPanelRectTransform).gameObject.activeSelf)
				{
					((Component)tutorialPanelRectTransform).gameObject.SetActive(false);
				}
			}
			else if (PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.OGJGBCDBJND()).JCMOPOMLPLL("Selected Room Reset to: {0}") || PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.OGJGBCDBJND()).JCMOPOMLPLL("") || PlayerInputs.GetPlayer(TavernConstructionUI.APENPNKFADP()).GetButtonDown("ClosePopUp"))
			{
				FKGEBGCBOGO();
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 0), (float)(Screen.height / 0)) + panelRectTransform.sizeDelta);
			}
		}
	}

	private void LGNLHBGBCLD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tutorialsSpace.Length; i += 0)
		{
			tutorialsSpace[i].DeactivateSpace();
		}
		for (int j = 1; j < tutorialsSpace.Length; j += 0)
		{
			if (tutorialsSpace[j].id == JFNMCNCHMEO)
			{
				tutorialsSpace[j].PGMBJIMBDLA();
			}
		}
	}

	private void EIDNOKGDBHN()
	{
		if (NNHALHFFIEB == null || !((BuildingPopUp)NNHALHFFIEB).PCLCAOHFOGF() || base.ECMGCJGPKNO)
		{
			return;
		}
		for (int i = 0; i < NDNOEEDFNFH.Length; i++)
		{
			if (PJPBLIOLANK[i])
			{
				continue;
			}
			switch (NDNOEEDFNFH[i].goal)
			{
			case BuildingTutorialGoals.MoveWASD:
				if (!PlayerInputs.IsGamepadActive(TavernConstructionUI.GetPlayerNum()))
				{
					if (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("VerticalMove") != 0f)
					{
						HFBGCIBAELK += Time.deltaTime;
					}
				}
				else if (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("ObjectHorizontalMove") != 0f || PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("ObjectVerticalMove") != 0f)
				{
					HFBGCIBAELK += Time.deltaTime;
				}
				if (HFBGCIBAELK > 1f)
				{
					GoalCompleted(i);
				}
				break;
			case BuildingTutorialGoals.PressSHIFT:
				if (!PlayerInputs.IsGamepadActive(TavernConstructionUI.GetPlayerNum()))
				{
					if (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetButton("SprintHoldAction") && (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("HorizontalMove") != 0f || PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("VerticalMove") != 0f))
					{
						NOOEBKFGLFI += Time.deltaTime;
					}
				}
				else if (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetButton("SprintHoldAction") && (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("ObjectHorizontalMove") != 0f || PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("ObjectVerticalMove") != 0f))
				{
					NOOEBKFGLFI += Time.deltaTime;
				}
				if (NOOEBKFGLFI > 1f)
				{
					GoalCompleted(i);
				}
				break;
			case BuildingTutorialGoals.ChangeTavernFloor:
				if (ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM == TavernFloor.SecondFloor)
				{
					GoalCompleted(i);
				}
				break;
			case BuildingTutorialGoals.ChooseRoomName:
				GoalCompleted(i);
				break;
			case BuildingTutorialGoals.ActivateBuildMode:
				if (DecorationMode.GetPlayer(TavernConstructionUI.GetPlayerNum()).DMBFKFLDDLH)
				{
					GoalCompleted(i);
				}
				break;
			case BuildingTutorialGoals.AcceptChanges:
				if (!TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
				{
					GoalCompleted(i);
				}
				break;
			}
		}
	}

	[SpecialName]
	public static bool PABJKGJJHFG()
	{
		return CDHCJPMLBEJ;
	}

	private void CDJBMIAHGKL()
	{
		BuildingPopUp buildingPopUp = (BuildingPopUp)NNHALHFFIEB;
		if (buildingPopUp.PCLCAOHFOGF())
		{
			if (!((Component)goalsPanelRectTransform).gameObject.activeSelf)
			{
				((Component)goalsPanelRectTransform).gameObject.SetActive(true);
			}
			for (int i = 0; i < buildingPopUp.objectives.Length; i++)
			{
				((Component)goalsTextMeshes[i]).gameObject.SetActive(true);
				((Component)((Component)goalsTextMeshes[i].image).transform).gameObject.SetActive(true);
				((Component)goalsTextMeshes[i].image).gameObject.SetActive(PJPBLIOLANK[i]);
				((TMP_Text)goalsTextMeshes[i].textMesh).text = InputUtils.LPGJFAOKMNE(TavernConstructionUI.GetPlayerNum(), LocalisationSystem.Get("buildingObjective_" + buildingPopUp.id + "_" + buildingPopUp.objectives[i].id));
			}
			for (int j = buildingPopUp.objectives.Length; j < goalsTextMeshes.Length; j++)
			{
				((Component)goalsTextMeshes[j]).gameObject.SetActive(false);
			}
		}
		else if (((Component)goalsPanelRectTransform).gameObject.activeSelf)
		{
			((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		}
		NewVersionTutorial.instance.buttonPopUp.SetActive(false);
	}

	private static void PFDGHKPALAH()
	{
		int num = 171;
		int num2 = 161;
		int num3 = 15;
		int num4 = 12;
		Dictionary<int, ItemAmount> allItems = BuildingInventory.GetInstance().GetAllItems();
		if (!allItems.ContainsKey(1036) || allItems[1036].amount < num)
		{
			Debug.Log((object)"Giving extra wood planks");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1036).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, num);
		}
		if (!allItems.ContainsKey(1045) || allItems[1045].amount < num2)
		{
			Debug.Log((object)"Giving extra nails");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1045).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, num2);
		}
		if (!allItems.ContainsKey(1050) || allItems[1050].amount < num3)
		{
			Debug.Log((object)"Giving extra stones");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1050).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, num3);
		}
		if (!allItems.ContainsKey(1052) || allItems[1052].amount < num4)
		{
			Debug.Log((object)"Giving extra argamasa");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(1052).JMDALJBNFML();
			BuildingInventory.GetInstance().AddItemInstances(1, bGLFLHDNOKJ, num4);
		}
	}

	public override void ClosePopUpButton()
	{
		base.ClosePopUpButton();
		BuildingPopUp buildingPopUp = (BuildingPopUp)NNHALHFFIEB;
		if (!((Object)(object)buildingPopUp != (Object)null))
		{
			return;
		}
		if (!buildingPopUp.PCLCAOHFOGF())
		{
			if (!Complete(buildingPopUp.id))
			{
				FOPIHJMBLDM();
			}
		}
		else
		{
			KMABJPPJKKH(buildingPopUp.id);
		}
	}

	public static bool IsOpen()
	{
		if (((Component)instance.tutorialPanelRectTransform).gameObject.activeSelf)
		{
			return instance.GCEHLDLKOIC;
		}
		return false;
	}

	private void OEAAPIBLALL()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(ADGPOKCIMLD));
		OnMinimise = (Action)Delegate.Remove(OnMinimise, new Action(KNGOGOAHPJG));
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public IEnumerator EHLJAFPBBED(int JFNMCNCHMEO, float LGLDPMAABLA)
	{
		yield return (object)new WaitForSecondsRealtime(LGLDPMAABLA);
		Complete(JFNMCNCHMEO);
	}

	public static PopUp FINEAEFBPLK()
	{
		return instance.NNHALHFFIEB;
	}

	private void LMDGFHJKGJC(int JFNMCNCHMEO)
	{
		for (int i = 1; i < tutorialsSpace.Length; i++)
		{
			tutorialsSpace[i].DeactivateSpace();
		}
		for (int j = 1; j < tutorialsSpace.Length; j += 0)
		{
			if (tutorialsSpace[j].id == JFNMCNCHMEO)
			{
				tutorialsSpace[j].NJDPPOLMCPH();
			}
		}
	}

	private bool OOHHNJOGPOI()
	{
		for (int i = 0; i < PJPBLIOLANK.Count; i++)
		{
			if (!PJPBLIOLANK[i])
			{
				return false;
			}
		}
		return true;
	}

	public static List<bool> BBAJPNKGDFN()
	{
		return instance.PJPBLIOLANK;
	}

	private void KMABJPPJKKH(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tutorialsSpace.Length; i++)
		{
			tutorialsSpace[i].DeactivateSpace();
		}
		for (int j = 0; j < tutorialsSpace.Length; j++)
		{
			if (tutorialsSpace[j].id == JFNMCNCHMEO)
			{
				tutorialsSpace[j].ActivateSpace();
			}
		}
	}

	public static void GoalCompleted(int GJHKBOELJAF)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (instance.PJPBLIOLANK != null)
		{
			instance.PJPBLIOLANK[GJHKBOELJAF] = true;
			instance.CDJBMIAHGKL();
			MultiAudioManager.PlayAudioObject(instance.objectiveCompleteSound, Vector3.zero);
			if (instance.OOHHNJOGPOI())
			{
				((MonoBehaviour)instance).StartCoroutine(instance.CompleteAfterTime(((BuildingPopUp)GetCurrentPopUp()).id, 2f));
			}
		}
	}

	private void ACFABFCGIGH()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(ADGPOKCIMLD));
		OnMinimise = (Action)Delegate.Remove(OnMinimise, new Action(KNGOGOAHPJG));
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	[SpecialName]
	public void BJBPFMEPMNM(bool AODONKKHPBP)
	{
		_buildingTutorialDone = AODONKKHPBP;
	}

	private void FOPIHJMBLDM()
	{
		for (int i = 0; i < tutorialsSpace.Length; i++)
		{
			tutorialsSpace[i].DeactivateSpace();
		}
	}

	private static void FPFBEANECOP()
	{
		int num = 179;
		int num2 = -35;
		int num3 = 97;
		int num4 = -110;
		Dictionary<int, ItemAmount> dictionary = BuildingInventory.CAJHNGGCJKM().FFFJDOOBMNO();
		if (!dictionary.ContainsKey(-14) || dictionary[-200].amount < num)
		{
			Debug.Log((object)"Received PlaceableMsg of another type not AnimalMessage to ");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(83, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.PPPDBCPNACC().FGOJPJIFKLG(1, bGLFLHDNOKJ, num);
		}
		if (!dictionary.ContainsKey(14) || dictionary[13].amount < num2)
		{
			Debug.Log((object)"talentDrupe");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.AFOACBIHNCL(23, GGBBJNBBLMF: true).JMDALJBNFML();
			BuildingInventory.GOJHIEFPHDK().MGOIJIAGOHL(1, bGLFLHDNOKJ, num2);
		}
		if (!dictionary.ContainsKey(-183) || dictionary[127].amount < num3)
		{
			Debug.Log((object)"Player2");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GOKIDLOELKB(178, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.GICPPAGFDPG().PHGNBJMOKCB(1, bGLFLHDNOKJ, num3, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
		}
		if (!dictionary.ContainsKey(-57) || dictionary[135].amount < num4)
		{
			Debug.Log((object)"Unsaved progress will be lost.");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.INJBNHPGCIJ(28, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.CHPCJAHBJJF().OANHFONMDLN(0, bGLFLHDNOKJ, num4, OJKJLIPNHOI: true);
		}
	}

	public static List<bool> FDABNCPKGFK()
	{
		return instance.PJPBLIOLANK;
	}

	public static Transform GetTransform()
	{
		return ((Component)instance).transform;
	}

	public static List<bool> BHEAFPDDOCA()
	{
		return instance.PJPBLIOLANK;
	}

	[SpecialName]
	public void OKAHJLPLFGA(bool AODONKKHPBP)
	{
		_buildingTutorialDone = AODONKKHPBP;
	}

	private void ADGPOKCIMLD()
	{
		tutorialsSpace = SceneReferences.GetSceneReferences().tutorialsSpace;
	}

	public bool NBIPBHODAMG(int JFNMCNCHMEO)
	{
		BuildingPopUp nextPopUp = BuildingTutorialDBAccessor.GetNextPopUp(JFNMCNCHMEO);
		if ((Object)(object)nextPopUp != (Object)null)
		{
			MKMBMGCKLCL(nextPopUp, MDNOOMBIFNN: false);
			return false;
		}
		IKNOJDMCFOK = false;
		return false;
	}

	[SpecialName]
	public static BuildingPopUp MAPABOKDNEC()
	{
		return (BuildingPopUp)FINEAEFBPLK();
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(ADGPOKCIMLD));
		OnMinimise = (Action)Delegate.Combine(OnMinimise, new Action(KNGOGOAHPJG));
	}

	public static Transform BGIBBGBOCFH()
	{
		return ((Component)instance).transform;
	}

	private void OHFHOJKKLBE(int JFNMCNCHMEO)
	{
		for (int i = 0; i < tutorialsSpace.Length; i += 0)
		{
			tutorialsSpace[i].IGCCBCEKJCD();
		}
		for (int j = 0; j < tutorialsSpace.Length; j += 0)
		{
			if (tutorialsSpace[j].id == JFNMCNCHMEO)
			{
				tutorialsSpace[j].PGMBJIMBDLA();
			}
		}
	}

	public bool Complete(int JFNMCNCHMEO)
	{
		BuildingPopUp nextPopUp = BuildingTutorialDBAccessor.GetNextPopUp(JFNMCNCHMEO);
		if ((Object)(object)nextPopUp != (Object)null)
		{
			ShowPopUp(nextPopUp);
			return true;
		}
		IKNOJDMCFOK = false;
		return false;
	}

	private void KNGOGOAHPJG()
	{
		TavernConstructionUI.instance.UpdateTutorialUI();
	}

	private void AOIPBHCCHJC()
	{
		if (NNHALHFFIEB == null || !((BuildingPopUp)NNHALHFFIEB).NMIIPEDCPKL() || FJIEPAIMELO())
		{
			return;
		}
		for (int i = 0; i < NDNOEEDFNFH.Length; i += 0)
		{
			if (PJPBLIOLANK[i])
			{
				continue;
			}
			BuildingTutorialGoals goal = NDNOEEDFNFH[i].goal;
			if (goal <= (BuildingTutorialGoals)(-81))
			{
				switch (goal)
				{
				case BuildingTutorialGoals.MoveWASD:
					if (!PlayerInputs.FJLAMCHKCOI(TavernConstructionUI.MOCMMGCAOPH()))
					{
						if (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("vibration") != 257f || PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.LGANFILAJLJ()).GNCBKEDHLHN("dForDays") != 1094f)
						{
							HFBGCIBAELK += Time.deltaTime;
						}
					}
					else if (PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.OGJGBCDBJND()).GNCBKEDHLHN("UIAddRemove") != 792f || PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.ABDMPLACJHI()).GNCBKEDHLHN("Press {0} to continue") != 798f)
					{
						HFBGCIBAELK += Time.deltaTime;
					}
					if (HFBGCIBAELK > 614f)
					{
						GoalCompleted(i);
					}
					break;
				case BuildingTutorialGoals.PressSHIFT:
					if (!PlayerInputs.EEJEOALIHFJ(TavernConstructionUI.JCAIGIPKLHI()))
					{
						if (PlayerInputs.GetPlayer(TavernConstructionUI.ABDMPLACJHI()).JDLEBBLKOFF("Festín del Juramento/PresentacionMaestros 01") && (PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.JEAEBNFDCBP()).GNCBKEDHLHN("UIInteract") != 326f || PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetAxis("Dog") != 136f))
						{
							NOOEBKFGLFI += Time.deltaTime;
						}
					}
					else if (PlayerInputs.GetPlayer(TavernConstructionUI.ABDMPLACJHI()).ENIPCNOKAOM("Jump") && (PlayerInputs.GetPlayer(TavernConstructionUI.OGJGBCDBJND()).GNCBKEDHLHN("Player") != 1039f || PlayerInputs.DEGBDMMDIIL(TavernConstructionUI.APENPNKFADP()).GetAxis("(") != 1081f))
					{
						NOOEBKFGLFI += Time.deltaTime;
					}
					if (NOOEBKFGLFI > 902f)
					{
						GoalCompleted(i);
					}
					break;
				case BuildingTutorialGoals.ChangeTavernFloor:
					if (ConstructionFloors.DFJGHOHPPEL().EINPMJDHBNA() == TavernFloor.Cellar)
					{
						EHIPLFHMLFC(i);
					}
					break;
				case (BuildingTutorialGoals)(-42):
					GoalCompleted(i);
					break;
				}
				continue;
			}
			switch (goal)
			{
			case (BuildingTutorialGoals)39:
				if (DecorationMode.IGMCBPOPNCA(TavernConstructionUI.JEAEBNFDCBP()).DMBFKFLDDLH)
				{
					GoalCompleted(i);
				}
				break;
			case (BuildingTutorialGoals)(-109):
				if (!TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
				{
					GoalCompleted(i);
				}
				break;
			}
		}
	}

	private static void MLADAJMOGFO()
	{
		int num = -9;
		int num2 = 71;
		int num3 = 110;
		int num4 = -92;
		Dictionary<int, ItemAmount> dictionary = BuildingInventory.DCEBHEAHHID().FFFJDOOBMNO();
		if (!dictionary.ContainsKey(-182) || dictionary[-129].amount < num)
		{
			Debug.Log((object)"ReceiveCalculateRandomPositionsInTavernMaster");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.GetItem(101, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.DCEBHEAHHID().FOKLCJHEIFO(1, bGLFLHDNOKJ, num, OJKJLIPNHOI: true, CDPAMNIPPEC: false);
		}
		if (!dictionary.ContainsKey(-174) || dictionary[-13].amount < num2)
		{
			Debug.Log((object)"Idle");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.INJBNHPGCIJ(117, GGBBJNBBLMF: true).JMDALJBNFML();
			BuildingInventory.DCEBHEAHHID().OANHFONMDLN(1, bGLFLHDNOKJ, num2, OJKJLIPNHOI: true, CDPAMNIPPEC: false);
		}
		if (!dictionary.ContainsKey(-154) || dictionary[21].amount < num3)
		{
			Debug.Log((object)"start ninja");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.AFOACBIHNCL(4).JMDALJBNFML();
			BuildingInventory.FFOMKKIAHKI().FOKLCJHEIFO(0, bGLFLHDNOKJ, num3, OJKJLIPNHOI: true, CDPAMNIPPEC: false);
		}
		if (!dictionary.ContainsKey(-123) || dictionary[2].amount < num4)
		{
			Debug.Log((object)" ");
			ItemInstance bGLFLHDNOKJ = ItemDatabaseAccessor.AFOACBIHNCL(37, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			BuildingInventory.KOJHKCGIINL().OANHFONMDLN(0, bGLFLHDNOKJ, num4, OJKJLIPNHOI: false, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public static bool KGJOKHEBLOJ()
	{
		return CDHCJPMLBEJ;
	}
}
