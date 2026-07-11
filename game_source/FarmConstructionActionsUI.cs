using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cinemachine;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class FarmConstructionActionsUI : MonoBehaviour
{
	public enum FarmTab
	{
		Construction,
		Modification
	}

	public enum MainActions
	{
		ImprovementButton,
		InstalationsButton,
		CustomizeButton,
		MoveButton,
		DemolishButton
	}

	public enum AnimalFeederActions
	{
		ImproveFeeder,
		CustomizeFeeder
	}

	public enum FarmStates
	{
		MainActions,
		CustomizeBuilding,
		Instalations,
		AnimalFeederActions,
		MoveBuilding,
		ImproveFeeder,
		CustomizeFeeder
	}

	public struct StateInfo
	{
		public FarmStates state;

		public int feederNum;

		public StateInfo(FarmStates NJHMBMGKCPL, int LBPKKJIHBBH = 0)
		{
			state = NJHMBMGKCPL;
			feederNum = LBPKKJIHBBH;
		}
	}

	[SerializeField]
	private GameObject content;

	[SerializeField]
	private Animator[] tabsAnimatorUI;

	[SerializeField]
	private GameObject[] tabsContentsUI;

	public List<FarmConstructionElementUI> buildElementsUI = new List<FarmConstructionElementUI>();

	[SerializeField]
	private List<FarmConstructionElementUI> actionsElementsUI = new List<FarmConstructionElementUI>();

	[SerializeField]
	private List<FarmConstructionElementUI> instalationsElementsUI = new List<FarmConstructionElementUI>();

	[SerializeField]
	private List<ConstructionSlotUI> constructionSlotsUI = new List<ConstructionSlotUI>();

	[SerializeField]
	private GameObject constructionActionsParent;

	[SerializeField]
	private GameObject constructionInstalationsParent;

	[SerializeField]
	private GameObject constructionSlotsParent;

	[SerializeField]
	private GameObject constructionSlotPrefab;

	[SerializeField]
	private GameObject barnPrefab;

	[SerializeField]
	private GameObject henHousePrefab;

	[SerializeField]
	private GameObject barnUI;

	[SerializeField]
	private GameObject chickenHouseUI;

	[SerializeField]
	private TextMeshProUGUI buildingName;

	[SerializeField]
	private GameObject backgroundBuilding;

	[SerializeField]
	private Button previousBuildingButton;

	[SerializeField]
	private Button nextBuildingButton;

	[SerializeField]
	private GameObject gamepadButtonsNextBuilding;

	[SerializeField]
	private GameObject backButton;

	[SerializeField]
	private GameObject closeButton;

	[SerializeField]
	private int barnsMax = 1;

	[SerializeField]
	private int henHousesMax = 2;

	public int currentBuildingNum;

	public FarmBuilding currentBuilding;

	[SerializeField]
	private int currentFeeder;

	[SerializeField]
	private int currentTab = -1;

	[SerializeField]
	private int currentSlot;

	[SerializeField]
	private AnimalFeeder[] feedersList;

	[SerializeField]
	private Sprite improveIcon;

	[SerializeField]
	private Sprite instalationsIcon;

	[SerializeField]
	private Sprite customizeIcon;

	[SerializeField]
	private Sprite moveIcon;

	[SerializeField]
	private Sprite demolishIcon;

	private float CMGDCLIIONE;

	private Vector3 APDPIMMFDLC;

	[SerializeField]
	private VolumeProfile volumeProfile;

	private DepthOfField BJANJDOMGMN;

	private Coroutine NEAOHDIJIMB;

	private Stack<StateInfo> KEICADJGCJK = new Stack<StateInfo>();

	private static FarmConstructionActionsUI IADEMLIIDPC;

	private bool MIANIFPOHNL;

	private bool ICNNBMDAKDN;

	private int JIIGOACEIKL => FarmConstructionUI.NLCDDFDGACP;

	public static FarmConstructionActionsUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionsUI>();
			}
			return IADEMLIIDPC;
		}
	}

	private void LKGKMAHKHKC(FarmConstructionElementUI KAPEILOBFLF)
	{
		StateInfo eOAONHNCDDO = KEICADJGCJK.Peek();
		int buttonNum = KAPEILOBFLF.buttonNum;
		AEKJHJAOCBC(eOAONHNCDDO, buttonNum);
		NEFHAHALAKK();
		UpdateUIGamepadSelection();
	}

	private void IIKAAECGGJB(int ABAIKKGKDGD = 0)
	{
		barnUI.SetActive(false);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.Close();
	}

	public void PreviousBuilding()
	{
		if (FarmConstructionManager.GetCompletedBuildings().Count > 0)
		{
			currentBuildingNum = Utils.NMLNAGFLNMC(currentBuildingNum - 1, FarmConstructionManager.GetCompletedBuildings().Count);
			currentBuilding = FarmConstructionManager.GetCompletedBuilding(currentBuildingNum);
			MDDNFHLJHNH();
			HHDOHBBHFFL(KEICADJGCJK.Peek());
		}
	}

	public void Update()
	{
		if (TutorialFarmConstruction.instance.inTutorial)
		{
			return;
		}
		if (MainUI.GetYesNoDialogue().IsOpen())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("UIBack") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Cancel"))
			{
				MainUI.GetYesNoDialogue().CloseUI();
			}
			return;
		}
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			gamepadButtonsNextBuilding.SetActive(((Selectable)nextBuildingButton).interactable);
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "UINextPage"))
			{
				if (currentTab < tabsAnimatorUI.Length - 1 && FarmConstructionManager.GetCompletedBuildings().Count > 0)
				{
					FocusTab(currentTab + 1);
				}
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousPage"))
			{
				if (currentTab > 0)
				{
					FocusTab(currentTab - 1);
				}
			}
			else if (currentTab == 1)
			{
				if (((Component)nextBuildingButton).gameObject.activeSelf && ((Selectable)nextBuildingButton).interactable && Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
				{
					NextBuilding();
				}
				else if (((Component)previousBuildingButton).gameObject.activeSelf && ((Selectable)previousBuildingButton).interactable && Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
				{
					PreviousBuilding();
				}
			}
		}
		else
		{
			gamepadButtonsNextBuilding.SetActive(false);
		}
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("UIBack") || PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Cancel"))
		{
			BackPressed();
		}
	}

	private void LBOFFAAPPMP()
	{
		FarmConstructionAction dGINFJFHMJC = ((!(feedersList[currentFeeder] is AnimalFeederFood)) ? EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveWaterFeeder) : EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveFoodFeeder));
		if (!FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ.DBDCGABABOP(dGINFJFHMJC, feedersList[currentFeeder].EONJGMONIOM, CDPAMNIPPEC: true))
		{
			return;
		}
		ActivateContent(DAEMAAOLHMG: true);
		if (currentBuilding is Barn)
		{
			if (feedersList[currentFeeder] is AnimalFeederFood)
			{
				(feedersList[currentFeeder] as AnimalFeederFood).Improve();
			}
			else
			{
				feedersList[currentFeeder].Improve();
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.SendImproveFeeder(feedersList[currentFeeder].id, feedersList[currentFeeder].feederType);
			}
		}
		HHDOHBBHFFL(KEICADJGCJK.Peek());
	}

	private void NLLJOANELHI(ConstructionSlotUI NPCJBOEMNJB)
	{
		PMAOHDNHKBO(NPCJBOEMNJB);
		int lDKDODKEIHJ = 0;
		if (currentBuilding is Barn barn)
		{
			lDKDODKEIHJ = constructionSlotsUI[currentSlot].ICEAJNDEOAB.id;
			barn.SetStyle(constructionSlotsUI[currentSlot].ICEAJNDEOAB);
		}
		else if (currentBuilding is HenHouse henHouse)
		{
			lDKDODKEIHJ = constructionSlotsUI[currentSlot].ONLCBJNNJMB.id;
			henHouse.SetStyle(constructionSlotsUI[currentSlot].ONLCBJNNJMB);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineFarmConstructionManager.instance.SendBuildingStyle(currentBuilding.placeable.BEIPALOAAJJ, lDKDODKEIHJ);
		}
	}

	private void IHIKONGGIMB()
	{
		ActivateContent(DAEMAAOLHMG: true);
		FLLNGGAKCJM();
		MoveCamera(NEFNAPBJHHJ: false);
		JHKOFMLAKOB();
		DPIPEJKOCMO(NCLCPJJOGKN: true);
		if (currentBuilding.EONJGMONIOM < 2)
		{
			PLDEHPGCFMM(0, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UpgradeToLevel"), (currentBuilding.EONJGMONIOM + 2).ToString()), improveIcon);
		}
		else
		{
			LFMLABBFGLO(0);
		}
		if (currentBuilding is Barn)
		{
			PLDEHPGCFMM(1, LocalisationSystem.Get("Facilities"), instalationsIcon);
		}
		else
		{
			LFMLABBFGLO(1);
		}
		PLDEHPGCFMM(2, LocalisationSystem.Get("Customize"), customizeIcon);
		PLDEHPGCFMM(3, LocalisationSystem.Get("MoveConstructionMode"), moveIcon);
		PLDEHPGCFMM(4, LocalisationSystem.Get("Demolish"), demolishIcon);
		ICIBLKBHKMA(actionsElementsUI, 5);
		MDDNFHLJHNH();
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			FarmConstructionElementUI farmConstructionElementUI = buildElementsUI[0];
			farmConstructionElementUI.OnPointerEnterAction = (Action<int>)Delegate.Combine(farmConstructionElementUI.OnPointerEnterAction, new Action<int>(KPPFLCMFGJJ));
			FarmConstructionElementUI farmConstructionElementUI2 = buildElementsUI[0];
			farmConstructionElementUI2.OnPointerExitAction = (Action<int>)Delegate.Combine(farmConstructionElementUI2.OnPointerExitAction, new Action<int>(IIKAAECGGJB));
			FarmConstructionElementUI farmConstructionElementUI3 = buildElementsUI[1];
			farmConstructionElementUI3.OnPointerEnterAction = (Action<int>)Delegate.Combine(farmConstructionElementUI3.OnPointerEnterAction, new Action<int>(LPIAHJGJBCC));
			FarmConstructionElementUI farmConstructionElementUI4 = buildElementsUI[1];
			farmConstructionElementUI4.OnPointerExitAction = (Action<int>)Delegate.Combine(farmConstructionElementUI4.OnPointerExitAction, new Action<int>(BCADACBFBLM));
			for (int i = 0; i < actionsElementsUI.Count; i++)
			{
				FarmConstructionElementUI farmConstructionElementUI5 = actionsElementsUI[i];
				farmConstructionElementUI5.OnButtonPressed = (Action<FarmConstructionElementUI>)Delegate.Combine(farmConstructionElementUI5.OnButtonPressed, new Action<FarmConstructionElementUI>(PBCNONJMOMI));
			}
			for (int j = 0; j < instalationsElementsUI.Count; j++)
			{
				FarmConstructionElementUI farmConstructionElementUI6 = instalationsElementsUI[j];
				farmConstructionElementUI6.OnButtonPressed = (Action<FarmConstructionElementUI>)Delegate.Combine(farmConstructionElementUI6.OnButtonPressed, new Action<FarmConstructionElementUI>(PBCNONJMOMI));
			}
		}
	}

	private void OnDisable()
	{
		if (!FarmConstructionUI.GGFJGHHHEJC.IsOpen())
		{
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCameraCinemachine(JIIGOACEIKL)).gameObject.GetComponent<CinemachineConfiner>().m_ConfineScreenEdges = true;
			ActivateBackgroundBuilding(DAEMAAOLHMG: false);
		}
	}

	public void FocusAllAnimalFeeders()
	{
		if (feedersList != null)
		{
			for (int i = 0; i < feedersList.Length; i++)
			{
				feedersList[i].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: true);
			}
		}
	}

	private void DIGJGNMIGIN(int MENBAFNNBFB, Action<ConstructionSlotUI> OKNOJJEFEBE)
	{
		if (MENBAFNNBFB >= constructionSlotsUI.Count)
		{
			constructionSlotsUI.Add(Object.Instantiate<GameObject>(constructionSlotPrefab, constructionSlotsParent.transform).GetComponent<ConstructionSlotUI>());
		}
		((Component)constructionSlotsUI[MENBAFNNBFB]).gameObject.SetActive(true);
		((Component)constructionSlotsUI[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		constructionSlotsUI[MENBAFNNBFB].OnButtonPressed = OKNOJJEFEBE;
	}

	private void EEENOOKGDEJ(int ABAIKKGKDGD = 0)
	{
		barnUI.SetActive(true);
		FarmConstructionActionInfoUI.EFPJLFMBPLL().Close();
	}

	public void ActivateContent(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
		COJPEDFACJC();
		AIJHPNOAPFJ();
	}

	private IEnumerator MHOIPHKAAJA(bool MDMAAIKFBFB)
	{
		float t = 0f;
		if (MDMAAIKFBFB)
		{
			((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(1.5f);
			((VolumeComponent)BJANJDOMGMN).active = true;
		}
		while (t < 1f)
		{
			if (MDMAAIKFBFB)
			{
				t += Time.unscaledDeltaTime;
				((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(1.5f, 10f, t));
			}
			else
			{
				t += Time.unscaledDeltaTime * 3f;
				((VolumeParameter<float>)(object)BJANJDOMGMN.focusDistance).Override(Mathf.Lerp(10f, 1.5f, t));
			}
			yield return null;
		}
		if (!MDMAAIKFBFB)
		{
			((VolumeComponent)BJANJDOMGMN).active = false;
		}
		NEAOHDIJIMB = null;
	}

	public void PPBMFEJCPCI()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		FarmConstructionActionInfoUI.DGCNCEDIFOF().Close();
		if (currentTab == 0)
		{
			IIKAAECGGJB(1);
			BCADACBFBLM(1);
			if (FarmConstructionManager.instantiatingGO)
			{
				FarmConstructionManager.instantiatingGO = false;
				FarmConstructionManager.OMEPPDMCFAO().RemoveAccessInstantiated();
				ActivateBackgroundBuilding(DAEMAAOLHMG: false);
				NLDEOPKHJBA(DAEMAAOLHMG: true);
				MoveCamera(NEFNAPBJHHJ: false);
				CursorManager.GetPlayer(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: false);
				FarmConstructionManager.OMEPPDMCFAO().cameraTarget.SetCurrentBuilding(null);
				PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).SwitchMapCategoryNextFrame("Message queue is paused");
				UpdateUIGamepadSelection();
			}
			else
			{
				ActivateBackgroundBuilding(DAEMAAOLHMG: true);
				FarmConstructionUI.BGMJCCFNNDL().CloseUI();
			}
		}
		else if (currentTab == 1)
		{
			if (KEICADJGCJK.Peek().state == FarmStates.ImproveFeeder)
			{
				FarmConstructionManager.DeselectAtPosition(APDPIMMFDLC, AINPJHKNJGL: true);
				PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).AMMIOLBGBPB("City/Rhia/Introduce");
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: true);
			}
			GoToPreviousState();
		}
		FarmConstructionManager.UpdateVisual();
		DFIMAPPGBPM();
	}

	public void AddBuilding(FarmBuilding CKIAGLNMEHD)
	{
		FarmConstructionManager.AddBuilding(CKIAGLNMEHD);
		AIJHPNOAPFJ();
	}

	public void HPEKPAIFLIN()
	{
		NLDEOPKHJBA(DAEMAAOLHMG: false);
		MoveCamera(NEFNAPBJHHJ: false);
		KEICADJGCJK.Pop();
		if (KEICADJGCJK.Count == 0)
		{
			FarmConstructionUI.KHMEGDIABBF().CloseUI();
		}
		else
		{
			StateInfo eOAONHNCDDO = KEICADJGCJK.Peek();
			HHDOHBBHFFL(eOAONHNCDDO);
		}
		UpdateUIGamepadSelection();
	}

	public void GoToPreviousState()
	{
		ActivateContent(DAEMAAOLHMG: true);
		MoveCamera(NEFNAPBJHHJ: false);
		KEICADJGCJK.Pop();
		if (KEICADJGCJK.Count == 0)
		{
			FarmConstructionUI.GGFJGHHHEJC.CloseUI();
		}
		else
		{
			StateInfo eOAONHNCDDO = KEICADJGCJK.Peek();
			HHDOHBBHFFL(eOAONHNCDDO);
		}
		UpdateUIGamepadSelection();
	}

	private void PBCNONJMOMI(FarmConstructionElementUI KAPEILOBFLF)
	{
		StateInfo eOAONHNCDDO = KEICADJGCJK.Peek();
		int buttonNum = KAPEILOBFLF.buttonNum;
		AEKJHJAOCBC(eOAONHNCDDO, buttonNum);
		OJLFKEDECLK();
		UpdateUIGamepadSelection();
	}

	private void JHKOFMLAKOB()
	{
		constructionActionsParent.SetActive(true);
		constructionInstalationsParent.SetActive(false);
		constructionSlotsParent.SetActive(false);
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)actionsElementsUI[0]).gameObject);
		}
	}

	private void JBOHJMGABIC()
	{
		if (feedersList == null)
		{
			return;
		}
		for (int i = 1; i < feedersList.Length; i++)
		{
			if (feedersList[i].EPBLEDFPJIM)
			{
				feedersList[i].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: false);
			}
		}
	}

	private void ADPNCBDMDBG()
	{
		ActivateContent(DAEMAAOLHMG: true);
		HHDOHBBHFFL(KEICADJGCJK.Peek());
	}

	private void OLEOBJGOOBG(int ABAIKKGKDGD)
	{
		switch (KEICADJGCJK.Peek().state)
		{
		case FarmStates.MainActions:
			FarmConstructionActionInfoUI.GGFJGHHHEJC.Close();
			break;
		case FarmStates.Instalations:
			GDLOFJFKMDN(ABAIKKGKDGD);
			break;
		case FarmStates.AnimalFeederActions:
			FarmConstructionActionInfoUI.GGFJGHHHEJC.Close();
			break;
		case FarmStates.CustomizeBuilding:
			break;
		}
	}

	private void JMEODMCKCMA()
	{
		FarmConstructionAction dGINFJFHMJC = ((!(feedersList[currentFeeder] is AnimalFeederFood)) ? EditorActionsDBAccessor.IMDIAGEMCDL((EditorAction)(-5)) : EditorActionsDBAccessor.GetFirstFarmAction((EditorAction)30));
		if (!FarmConstructionUI.OOKBNHMMFON().playerInfo.PPEOOLCNAGN().DBDCGABABOP(dGINFJFHMJC, feedersList[currentFeeder].EONJGMONIOM, CDPAMNIPPEC: true))
		{
			return;
		}
		NLDEOPKHJBA(DAEMAAOLHMG: true);
		if (currentBuilding is Barn)
		{
			if (feedersList[currentFeeder] is AnimalFeederFood)
			{
				(feedersList[currentFeeder] as AnimalFeederFood).Improve();
			}
			else
			{
				feedersList[currentFeeder].Improve();
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.MOELMLLAPOO(feedersList[currentFeeder].id, feedersList[currentFeeder].feederType);
			}
		}
		HHDOHBBHFFL(KEICADJGCJK.Peek());
	}

	public void NGAHBFKKCFO()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		FarmConstructionActionInfoUI.MAIDHAPANEB().FIBLMHAKCCI();
		if (currentTab == 0)
		{
			IIKAAECGGJB(1);
			PLJFOMENCPD(1);
			if (FarmConstructionManager.instantiatingGO)
			{
				FarmConstructionManager.instantiatingGO = true;
				FarmConstructionManager.OMEPPDMCFAO().RemoveAccessInstantiated();
				ActivateBackgroundBuilding(DAEMAAOLHMG: false);
				NLDEOPKHJBA(DAEMAAOLHMG: false);
				MoveCamera(NEFNAPBJHHJ: true);
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: true);
				FarmConstructionManager.GetInstance().cameraTarget.SetCurrentBuilding(null);
				PlayerInputs.GetPlayer(JIIGOACEIKL).AMMIOLBGBPB("/unlock: ");
				UpdateUIGamepadSelection();
			}
			else
			{
				ActivateBackgroundBuilding(DAEMAAOLHMG: false);
				FarmConstructionUI.DGCNCEDIFOF().BOBCIFEDJED();
			}
		}
		else if (currentTab == 0)
		{
			if (KEICADJGCJK.Peek().state == (FarmStates)8)
			{
				FarmConstructionManager.DeselectAtPosition(APDPIMMFDLC);
				PlayerInputs.GetPlayer(JIIGOACEIKL).AMMIOLBGBPB("Game Over! ");
				CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
			}
			HPEKPAIFLIN();
		}
		FarmConstructionManager.BPONMLCCIAL();
		DFIMAPPGBPM();
	}

	private void GDLOFJFKMDN(int ABAIKKGKDGD)
	{
		feedersList[ABAIKKGKDGD].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: false);
	}

	public void FOCPMMFKFPL(int KHEICLKLPDE)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (KHEICLKLPDE == -1)
		{
			FarmConstructionManager.GetAllBuildings();
			KHEICLKLPDE = ((MIANIFPOHNL && ICNNBMDAKDN) ? 1 : 0);
		}
		else if (currentTab == KHEICLKLPDE)
		{
			COJPEDFACJC();
			return;
		}
		currentTab = KHEICLKLPDE;
		COJPEDFACJC();
		FGMHIOEIOFD();
		IIKAAECGGJB(1);
		PLJFOMENCPD(1);
		if (currentTab == 0)
		{
			ActivateBackgroundBuilding(DAEMAAOLHMG: false);
			CPDOKNKOAHL();
			if (WorldGrid.HJPCBBGHPDA(((Component)FarmConstructionManager.OMEPPDMCFAO().cameraTarget).transform.position) != Location.River)
			{
				MAFAFNMNCEM();
			}
		}
		else if (currentTab == 1)
		{
			ActivateBackgroundBuilding(DAEMAAOLHMG: false);
			MoveCamera(NEFNAPBJHHJ: true);
			FarmConstructionManager.KHOGJGCDELO();
			KEICADJGCJK.Clear();
			MEPNDGKMOJH();
			NextState(FarmStates.MainActions, 1);
		}
		FarmConstructionManager.BPONMLCCIAL();
		NEFHAHALAKK();
		UpdateUIGamepadSelection();
	}

	private void DKIJHLPLHIG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		APDPIMMFDLC = ((Component)currentBuilding.placeable).transform.position;
		FarmConstructionManager.StartMoveBuilding(currentBuilding.placeable);
		NextState(FarmStates.MoveBuilding);
	}

	private void FMHAPOBELOL(ConstructionSlotUI NPCJBOEMNJB)
	{
		constructionSlotsUI[currentSlot].SetSelected(HGNKFFMDOOL: false);
		NPCJBOEMNJB.OCACOLMODDN(HGNKFFMDOOL: false);
		currentSlot = ((Component)NPCJBOEMNJB).transform.GetSiblingIndex();
	}

	private void HINGECEDJAP()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			FarmConstructionElementUI farmConstructionElementUI = buildElementsUI[0];
			farmConstructionElementUI.OnPointerEnterAction = (Action<int>)Delegate.Combine(farmConstructionElementUI.OnPointerEnterAction, new Action<int>(KPPFLCMFGJJ));
			FarmConstructionElementUI farmConstructionElementUI2 = buildElementsUI[1];
			farmConstructionElementUI2.OnPointerExitAction = (Action<int>)Delegate.Combine(farmConstructionElementUI2.OnPointerExitAction, new Action<int>(EEENOOKGDEJ));
			FarmConstructionElementUI farmConstructionElementUI3 = buildElementsUI[1];
			farmConstructionElementUI3.OnPointerEnterAction = (Action<int>)Delegate.Combine(farmConstructionElementUI3.OnPointerEnterAction, new Action<int>(LPIAHJGJBCC));
			FarmConstructionElementUI farmConstructionElementUI4 = buildElementsUI[1];
			farmConstructionElementUI4.OnPointerExitAction = (Action<int>)Delegate.Combine(farmConstructionElementUI4.OnPointerExitAction, new Action<int>(PLJFOMENCPD));
			for (int i = 1; i < actionsElementsUI.Count; i += 0)
			{
				FarmConstructionElementUI farmConstructionElementUI5 = actionsElementsUI[i];
				farmConstructionElementUI5.OnButtonPressed = (Action<FarmConstructionElementUI>)Delegate.Combine(farmConstructionElementUI5.OnButtonPressed, new Action<FarmConstructionElementUI>(LKGKMAHKHKC));
			}
			for (int j = 0; j < instalationsElementsUI.Count; j++)
			{
				FarmConstructionElementUI farmConstructionElementUI6 = instalationsElementsUI[j];
				farmConstructionElementUI6.OnButtonPressed = (Action<FarmConstructionElementUI>)Delegate.Combine(farmConstructionElementUI6.OnButtonPressed, new Action<FarmConstructionElementUI>(LKGKMAHKHKC));
			}
		}
	}

	private void MDDNFHLJHNH()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)buildingName).text = ((Component)currentBuilding).GetComponent<ItemSetup>().item.IABAKHPEOAF();
		((Component)CommonReferences.GGFJGHHHEJC.GetMainCameraCinemachine(JIIGOACEIKL)).gameObject.GetComponent<CinemachineConfiner>().m_ConfineScreenEdges = true;
		((Component)FarmConstructionManager.GetInstance().cameraTarget).transform.position = ((Component)currentBuilding).transform.position + new Vector3(1.5f, 0f);
	}

	private void JPCNHOHHPBP(ConstructionSlotUI NPCJBOEMNJB)
	{
		PMAOHDNHKBO(NPCJBOEMNJB);
		if (currentBuilding is Barn barn)
		{
			if (feedersList[currentFeeder] is AnimalFeederFood)
			{
				barn.animalSpaces[feedersList[currentFeeder].id].foodFeeder.SetStyle(NPCJBOEMNJB.ONLCBJNNJMB);
			}
			else
			{
				(barn.waterFeeders[feedersList[currentFeeder].id] as AnimalFeederWater).SetStyle(NPCJBOEMNJB.ONLCBJNNJMB);
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.SendFeederStyle(feedersList[currentFeeder].id, feedersList[currentFeeder].feederType, NPCJBOEMNJB.ONLCBJNNJMB.id);
			}
		}
	}

	private void HHDOHBBHFFL(StateInfo EOAONHNCDDO)
	{
		if (EOAONHNCDDO.state == FarmStates.MainActions)
		{
			IHIKONGGIMB();
		}
		else if (EOAONHNCDDO.state == FarmStates.Instalations)
		{
			BJLPICMFPOA();
		}
		else if (EOAONHNCDDO.state == FarmStates.CustomizeBuilding)
		{
			NGCGFKDGEIO();
		}
		else if (EOAONHNCDDO.state == FarmStates.AnimalFeederActions)
		{
			OGFLCIKPBMM();
		}
		else if (EOAONHNCDDO.state == FarmStates.CustomizeFeeder)
		{
			EBJJIDLDODO();
		}
		else if (EOAONHNCDDO.state == FarmStates.MoveBuilding)
		{
			EELFHEHJEGF();
		}
		UpdateUIGamepadSelection();
	}

	private void JBBBAONNNIG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		APDPIMMFDLC = ((Component)currentBuilding.placeable).transform.position;
		FarmConstructionManager.JOMOCKEOLJO(currentBuilding.placeable);
		NextState((FarmStates)7, 1);
	}

	public void ResetCurrentTab()
	{
		currentTab = -1;
	}

	[SpecialName]
	public static FarmConstructionActionsUI DCAEBALADIM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<FarmConstructionActionsUI>();
		}
		return IADEMLIIDPC;
	}

	private void JPDHHBFMIMI(int OKNOJJEFEBE, string GEGDHHIDEEF, AnimalFeeder OHPCAOHHOEA)
	{
		instalationsElementsUI[OKNOJJEFEBE].UpdateFeederInfo(GEGDHHIDEEF, OHPCAOHHOEA);
	}

	private void IBHEIHCEKFB()
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)buildingName).text = ((Component)currentBuilding).GetComponent<ItemSetup>().item.IABAKHPEOAF();
		Barn barn = currentBuilding as Barn;
		((Component)CommonReferences.GGFJGHHHEJC.GetMainCameraCinemachine(JIIGOACEIKL)).gameObject.GetComponent<CinemachineConfiner>().m_ConfineScreenEdges = false;
		((Component)FarmConstructionManager.GetInstance().cameraTarget).transform.position = CommonReferences.GGFJGHHHEJC.allBarnScenes[barn.EONJGMONIOM].cameraPosition.transform.position;
	}

	public void FFGEEGKLNJE()
	{
		if (FarmConstructionManager.GetCompletedBuildings().Count > 0)
		{
			currentBuildingNum = Utils.NMLNAGFLNMC(currentBuildingNum - 1, FarmConstructionManager.GetCompletedBuildings().Count);
			currentBuilding = FarmConstructionManager.GANFKPNMGPE(currentBuildingNum);
			MDDNFHLJHNH();
			HHDOHBBHFFL(KEICADJGCJK.Peek());
		}
	}

	private void AEKJHJAOCBC(StateInfo EOAONHNCDDO, int EAIIFODBKAE)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		if (EOAONHNCDDO.state == FarmStates.MainActions)
		{
			switch (EAIIFODBKAE)
			{
			case 0:
			{
				FarmConstructionAction dGINFJFHMJC = ((!(currentBuilding is Barn)) ? EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveChickenHouse) : EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveBarn));
				if (FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ.JEANPDCCPEF(dGINFJFHMJC, currentBuilding.EONJGMONIOM))
				{
					ActivateContent(DAEMAAOLHMG: false);
					MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
					if (currentBuilding is Barn)
					{
						((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("UpgradeConfirmation", JIIGOACEIKL), LocalisationSystem.GetStringWithTags("Items/item_name_1230", JIIGOACEIKL));
					}
					else
					{
						((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("UpgradeConfirmation", JIIGOACEIKL), LocalisationSystem.GetStringWithTags("Items/item_name_1231", JIIGOACEIKL));
					}
					MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(MBJLHHEKGGP));
					MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(ADPNCBDMDBG));
				}
				break;
			}
			case 1:
				NextState(FarmStates.Instalations);
				break;
			case 2:
				NextState(FarmStates.CustomizeBuilding);
				break;
			case 3:
				DKIJHLPLHIG();
				break;
			case 4:
			{
				ActivateContent(DAEMAAOLHMG: false);
				MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
				string text = ((!(currentBuilding is Barn)) ? LocalisationSystem.GetStringWithTags("Items/item_name_1231", JIIGOACEIKL) : LocalisationSystem.GetStringWithTags("Items/item_name_1230", JIIGOACEIKL));
				if (currentBuilding.GetAllAnimals().Count > 0)
				{
					((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("DemolishConfirmationWithAnimals", JIIGOACEIKL), text, currentBuilding.GetAllAnimals().Count.ToString());
				}
				else
				{
					((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("DemolishConfirmation", JIIGOACEIKL), text);
				}
				MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(NJLCJEFFGLG));
				MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(ADPNCBDMDBG));
				break;
			}
			}
		}
		else if (EOAONHNCDDO.state == FarmStates.Instalations)
		{
			currentFeeder = EAIIFODBKAE;
			FPOEGNJFFGN(EAIIFODBKAE);
			if (feedersList[currentFeeder] is AnimalFeederFood)
			{
				((TMP_Text)buildingName).text = LocalisationSystem.Get("Trough") + " " + (EAIIFODBKAE + 1);
			}
			else
			{
				((TMP_Text)buildingName).text = LocalisationSystem.Get("WaterTrough") + " " + (EAIIFODBKAE + 1);
			}
			NextState(FarmStates.AnimalFeederActions, EAIIFODBKAE);
		}
		else
		{
			if (EOAONHNCDDO.state != FarmStates.AnimalFeederActions)
			{
				return;
			}
			switch (EAIIFODBKAE)
			{
			case 0:
			{
				FarmConstructionAction dGINFJFHMJC2 = ((!(feedersList[currentFeeder] is AnimalFeederFood)) ? EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveWaterFeeder) : EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveFoodFeeder));
				if (FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ.JEANPDCCPEF(dGINFJFHMJC2, feedersList[currentFeeder].EONJGMONIOM))
				{
					ActivateContent(DAEMAAOLHMG: false);
					MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
					if (feedersList[currentFeeder] is AnimalFeederFood)
					{
						((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UpgradeObjectConfirmation"), LocalisationSystem.Get("Trough"));
					}
					else
					{
						((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UpgradeObjectConfirmation"), LocalisationSystem.Get("WaterTrough"));
					}
					MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(LBOFFAAPPMP));
					MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(ADPNCBDMDBG));
				}
				break;
			}
			case 1:
				NextState(FarmStates.CustomizeFeeder, EOAONHNCDDO.feederNum);
				break;
			}
		}
	}

	private void DPIPEJKOCMO(bool NCLCPJJOGKN)
	{
		if (FarmConstructionManager.GetCompletedBuildings().Count <= 1)
		{
			((Selectable)previousBuildingButton).interactable = false;
			((Selectable)nextBuildingButton).interactable = false;
		}
		else
		{
			((Selectable)previousBuildingButton).interactable = NCLCPJJOGKN;
			((Selectable)nextBuildingButton).interactable = NCLCPJJOGKN;
		}
	}

	private void NJLCJEFFGLG()
	{
		FarmConstructionManager.RemoveBuilding(currentBuilding);
		FarmConstructionManager.GetCompletedBuildings().Remove(currentBuilding);
		currentBuilding.Demolish(JIIGOACEIKL);
		ActivateContent(DAEMAAOLHMG: true);
		ADFLNPAOHMG();
		if (FarmConstructionManager.GetCompletedBuildings().Count > 0)
		{
			currentBuildingNum = 0;
			currentBuilding = FarmConstructionManager.GetCompletedBuilding(0);
			MDDNFHLJHNH();
			AIELCBNLOFI(0);
		}
	}

	public void AFBHCKAACHH()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		FarmConstructionActionInfoUI.DGCNCEDIFOF().Close();
		if (currentTab == 0)
		{
			EEENOOKGDEJ();
			BCADACBFBLM();
			if (FarmConstructionManager.instantiatingGO)
			{
				FarmConstructionManager.instantiatingGO = true;
				FarmConstructionManager.GetInstance().RemoveAccessInstantiated();
				ActivateBackgroundBuilding(DAEMAAOLHMG: false);
				ActivateContent(DAEMAAOLHMG: true);
				MoveCamera(NEFNAPBJHHJ: false);
				CursorManager.GetPlayer(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: true);
				FarmConstructionManager.GetInstance().cameraTarget.OEFDANFNGEO(null);
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("Mouth");
				UpdateUIGamepadSelection();
			}
			else
			{
				ActivateBackgroundBuilding(DAEMAAOLHMG: false);
				FarmConstructionUI.EKDNJDJHONF().CloseUI();
			}
		}
		else if (currentTab == 1)
		{
			if (KEICADJGCJK.Peek().state == FarmStates.CustomizeFeeder)
			{
				FarmConstructionManager.DeselectAtPosition(APDPIMMFDLC, AINPJHKNJGL: true);
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("onlineregion");
				CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: true);
			}
			GoToPreviousState();
		}
		FarmConstructionManager.BPONMLCCIAL();
		NEFHAHALAKK();
	}

	public void NextState(FarmStates GMIKOECBPON, int LBPKKJIHBBH = 0)
	{
		StateInfo stateInfo = new StateInfo(GMIKOECBPON, LBPKKJIHBBH);
		KEICADJGCJK.Push(stateInfo);
		HHDOHBBHFFL(stateInfo);
	}

	private void FLLNGGAKCJM()
	{
		if (feedersList == null)
		{
			return;
		}
		for (int i = 0; i < feedersList.Length; i++)
		{
			if (feedersList[i].EPBLEDFPJIM)
			{
				feedersList[i].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: false);
			}
		}
	}

	public void MoveCamera(bool NEFNAPBJHHJ)
	{
		FarmConstructionManager.GetInstance().cameraTarget.LNLJMCONDNE = NEFNAPBJHHJ;
	}

	private void COJPEDFACJC()
	{
		for (int i = 0; i < tabsAnimatorUI.Length; i++)
		{
			if (i == currentTab)
			{
				continue;
			}
			if (i < currentTab)
			{
				if (i != 0)
				{
					tabsAnimatorUI[i].SetTrigger("NormalLeft");
				}
				else
				{
					tabsAnimatorUI[i].SetTrigger("NormalLeftExterior");
				}
			}
			else if (i < tabsAnimatorUI.Length - 1)
			{
				tabsAnimatorUI[i].SetTrigger("NormalRight");
			}
			else
			{
				tabsAnimatorUI[i].SetTrigger("NormalRightExterior");
			}
			tabsAnimatorUI[i].ResetTrigger("Selected");
			tabsContentsUI[i].SetActive(false);
		}
		if (currentTab >= 0 && currentTab < tabsAnimatorUI.Length)
		{
			tabsContentsUI[currentTab].SetActive(true);
			tabsAnimatorUI[currentTab].ResetTrigger("Normal");
			tabsAnimatorUI[currentTab].SetTrigger("Selected");
		}
	}

	private void KIJPMFIKIBF()
	{
		constructionActionsParent.SetActive(false);
		constructionInstalationsParent.SetActive(false);
		constructionSlotsParent.SetActive(false);
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).LDAGOHPIGNA(((Component)instalationsElementsUI[1]).gameObject);
		}
	}

	public void DFFJKHEPBCP()
	{
		if (FarmConstructionManager.GetCompletedBuildings().Count > 0)
		{
			currentBuildingNum = Utils.NMLNAGFLNMC(currentBuildingNum - 1, FarmConstructionManager.GetCompletedBuildings().Count);
			currentBuilding = FarmConstructionManager.GANFKPNMGPE(currentBuildingNum);
			MDDNFHLJHNH();
			HHDOHBBHFFL(KEICADJGCJK.Peek());
		}
	}

	private void IMPONGFGLAI()
	{
		FarmConstructionAction dGINFJFHMJC = ((!(feedersList[currentFeeder] is AnimalFeederFood)) ? EditorActionsDBAccessor.IMDIAGEMCDL((EditorAction)90) : EditorActionsDBAccessor.GetFirstFarmAction((EditorAction)41));
		if (!FarmConstructionUI.EKDNJDJHONF().playerInfo.BLFALIKICFH().DBDCGABABOP(dGINFJFHMJC, feedersList[currentFeeder].EONJGMONIOM, CDPAMNIPPEC: true))
		{
			return;
		}
		IIGKKEOOANA(DAEMAAOLHMG: false);
		if (currentBuilding is Barn)
		{
			if (feedersList[currentFeeder] is AnimalFeederFood)
			{
				(feedersList[currentFeeder] as AnimalFeederFood).Improve();
			}
			else
			{
				feedersList[currentFeeder].Improve();
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.FOCOECLEFGE(feedersList[currentFeeder].id, feedersList[currentFeeder].feederType);
			}
		}
		HHDOHBBHFFL(KEICADJGCJK.Peek());
	}

	private void HMLCNDHCFJO()
	{
		constructionActionsParent.SetActive(false);
		constructionInstalationsParent.SetActive(true);
		constructionSlotsParent.SetActive(false);
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)instalationsElementsUI[0]).gameObject);
		}
	}

	private void EJHIJNAAJPL(ConstructionSlotUI NPCJBOEMNJB)
	{
		HAFFDOAFLAA(NPCJBOEMNJB);
		int lDKDODKEIHJ = 0;
		if (currentBuilding is Barn barn)
		{
			lDKDODKEIHJ = constructionSlotsUI[currentSlot].POHKABMMKDG().id;
			barn.JLPJCGMJINB(constructionSlotsUI[currentSlot].POHKABMMKDG());
		}
		else if (currentBuilding is HenHouse henHouse)
		{
			lDKDODKEIHJ = constructionSlotsUI[currentSlot].IIDBBIKDBGM().id;
			henHouse.ECECBMAAHJN(constructionSlotsUI[currentSlot].IIDBBIKDBGM());
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineFarmConstructionManager.instance.KLBNMEBPPPG(currentBuilding.placeable.BEIPALOAAJJ, lDKDODKEIHJ);
		}
	}

	private void BCADACBFBLM(int ABAIKKGKDGD = 0)
	{
		chickenHouseUI.SetActive(false);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.Close();
	}

	private void CPDOKNKOAHL()
	{
		int num = 0;
		int num2 = 1;
		for (int i = 1; i < FarmConstructionManager.GetBuildings().Count; i++)
		{
			if (FarmConstructionManager.MHMGMLOPAOI(i) is Barn)
			{
				num += 0;
			}
			else
			{
				num2 += 0;
			}
		}
		MIANIFPOHNL = num < barnsMax;
		FarmConstructionElementUI farmConstructionElementUI = buildElementsUI[0];
		string[] array = new string[3];
		array[0] = barnPrefab.GetComponent<ItemSetup>().item.LJIFOHFEFCH();
		array[1] = "F1";
		array[6] = num.ToString();
		array[0] = "Items/item_description_604";
		array[2] = barnsMax.ToString();
		array[1] = "City/Lia/Bark/Bye";
		farmConstructionElementUI.BOILBNHGKGO(string.Concat(array));
		buildElementsUI[0].NCGDJKGNEHB(MIANIFPOHNL);
		ICNNBMDAKDN = num2 < henHousesMax;
		FarmConstructionElementUI farmConstructionElementUI2 = buildElementsUI[1];
		string[] array2 = new string[2];
		array2[0] = henHousePrefab.GetComponent<ItemSetup>().item.IABAKHPEOAF(OAFPBCPDOKH: true);
		array2[1] = "SetTriggerRPC";
		array2[5] = num2.ToString();
		array2[4] = "Fire Loop source NULL!!!";
		array2[6] = henHousesMax.ToString();
		array2[6] = "TooDark";
		farmConstructionElementUI2.CAKBJGFOOMF(string.Concat(array2));
		buildElementsUI[0].NCGDJKGNEHB(ICNNBMDAKDN);
	}

	public void ActivateBackgroundBuilding(bool DAEMAAOLHMG)
	{
		backgroundBuilding.SetActive(DAEMAAOLHMG);
		if (NEAOHDIJIMB != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(NEAOHDIJIMB);
		}
		if ((Object)(object)BJANJDOMGMN == (Object)null)
		{
			volumeProfile.TryGet<DepthOfField>(ref BJANJDOMGMN);
		}
		NEAOHDIJIMB = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(MHOIPHKAAJA(DAEMAAOLHMG));
	}

	public void BackPressed()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		FarmConstructionActionInfoUI.GGFJGHHHEJC.Close();
		if (currentTab == 0)
		{
			IIKAAECGGJB();
			BCADACBFBLM();
			if (FarmConstructionManager.instantiatingGO)
			{
				FarmConstructionManager.instantiatingGO = false;
				FarmConstructionManager.GetInstance().RemoveAccessInstantiated();
				ActivateBackgroundBuilding(DAEMAAOLHMG: true);
				ActivateContent(DAEMAAOLHMG: true);
				MoveCamera(NEFNAPBJHHJ: false);
				CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
				FarmConstructionManager.GetInstance().cameraTarget.SetCurrentBuilding(null);
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
				UpdateUIGamepadSelection();
			}
			else
			{
				ActivateBackgroundBuilding(DAEMAAOLHMG: false);
				FarmConstructionUI.GGFJGHHHEJC.CloseUI();
			}
		}
		else if (currentTab == 1)
		{
			if (KEICADJGCJK.Peek().state == FarmStates.MoveBuilding)
			{
				FarmConstructionManager.DeselectAtPosition(APDPIMMFDLC, AINPJHKNJGL: true);
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
				CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
			}
			GoToPreviousState();
		}
		FarmConstructionManager.UpdateVisual();
		OJLFKEDECLK();
	}

	private void OGFLCIKPBMM()
	{
		JHKOFMLAKOB();
		if (feedersList[currentFeeder].EONJGMONIOM < 2)
		{
			PLDEHPGCFMM(0, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UpgradeToLevel"), (feedersList[currentFeeder].EONJGMONIOM + 2).ToString()), improveIcon);
		}
		else
		{
			LFMLABBFGLO(0);
		}
		PLDEHPGCFMM(1, LocalisationSystem.Get("Customize"), customizeIcon);
		ICIBLKBHKMA(actionsElementsUI, 2);
	}

	private void MKJNIOBKFIH(SpritesList[] IHEGMFLCDLJ, Action<ConstructionSlotUI> OKNOJJEFEBE)
	{
		for (int i = 0; i < IHEGMFLCDLJ.Length; i++)
		{
			DIGJGNMIGIN(i, OKNOJJEFEBE);
			constructionSlotsUI[i].UpdateSlot(IHEGMFLCDLJ[i], i == currentSlot);
		}
		for (int j = IHEGMFLCDLJ.Length; j < constructionSlotsUI.Count; j++)
		{
			((Component)constructionSlotsUI[j]).gameObject.SetActive(false);
		}
	}

	private void GAJGNGAMPAI(int ABAIKKGKDGD)
	{
		feedersList[ABAIKKGKDGD].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: false);
	}

	private void MAFAFNMNCEM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		((Component)FarmConstructionManager.GetInstance().cameraTarget).transform.position = ((Component)TravelZonesManager.EKDNJDJHONF().JKPNCIFMAOO(Location.Tavern, Location.None)).transform.position;
	}

	private void ADFLNPAOHMG()
	{
		FarmConstructionManager.GetAllBuildings();
		((Component)tabsAnimatorUI[1]).gameObject.SetActive(FarmConstructionManager.GetCompletedBuildings().Count > 0);
		DPIPEJKOCMO(NCLCPJJOGKN: true);
		if (FarmConstructionManager.GetCompletedBuildings().Count == 0)
		{
			FocusTab(0);
		}
	}

	private void FACHEAGHDJD()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)buildingName).text = ((Component)currentBuilding).GetComponent<ItemSetup>().item.LJIFOHFEFCH();
		((Component)CommonReferences.GGFJGHHHEJC.LKKPDJBNGNK(JIIGOACEIKL)).gameObject.GetComponent<CinemachineConfiner>().m_ConfineScreenEdges = false;
		((Component)FarmConstructionManager.GetInstance().cameraTarget).transform.position = ((Component)currentBuilding).transform.position + new Vector3(745f, 1642f);
	}

	private void KPPFLCMFGJJ(int ABAIKKGKDGD = 0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		barnUI.SetActive(true);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.Open(JIIGOACEIKL);
		MoneyMaterials moneyMaterials = FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ;
		FarmConstructionActionInfoUI.GGFJGHHHEJC.UpdateCurrentSlotInfo(EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.CreateBarn).cost, moneyMaterials);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.ShowUpgradeInfo(EditorAction.CreateBarn);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.SetWorldPosition(Vector2.op_Implicit(Vector2.zero), Direction.Down);
	}

	private void LGKLPPDIAIL()
	{
		NLDEOPKHJBA(DAEMAAOLHMG: false);
		MoveCamera(NEFNAPBJHHJ: false);
	}

	private void EELFHEHJEGF()
	{
		ActivateContent(DAEMAAOLHMG: false);
		MoveCamera(NEFNAPBJHHJ: true);
	}

	private void DFIMAPPGBPM()
	{
		if (KEICADJGCJK == null || KEICADJGCJK.Count <= 0)
		{
			closeButton.SetActive(false);
			backButton.SetActive(false);
		}
		else
		{
			closeButton.SetActive(true);
			backButton.SetActive(true);
		}
	}

	private void PLDEHPGCFMM(int OKNOJJEFEBE, string GEGDHHIDEEF, Sprite HEJNLFCKOKE)
	{
		actionsElementsUI[OKNOJJEFEBE].UpdateActionInfo(GEGDHHIDEEF, HEJNLFCKOKE);
	}

	private void NGCGFKDGEIO()
	{
		HFAMINMNPEL();
		if (currentBuilding is Barn barn)
		{
			IconMaterial[] barnMaterials = CharacterSpritesDBAccessor.GetBarnMaterials();
			for (int i = 0; i < barnMaterials.Length; i++)
			{
				if (barnMaterials[i].id == barn.style.id)
				{
					currentSlot = i;
					break;
				}
			}
			MKJNIOBKFIH(barnMaterials);
		}
		else
		{
			if (!(currentBuilding is HenHouse henHouse))
			{
				return;
			}
			SpritesList[] henHouseStyles = CharacterSpritesDBAccessor.GetHenHouseStyles();
			for (int j = 0; j < henHouseStyles.Length; j++)
			{
				if (henHouseStyles[j].id == henHouse.style.id)
				{
					currentSlot = j;
					break;
				}
			}
			MKJNIOBKFIH(henHouseStyles, NLLJOANELHI);
		}
	}

	private void NEFHAHALAKK()
	{
		if (KEICADJGCJK == null || KEICADJGCJK.Count <= 0)
		{
			closeButton.SetActive(false);
			backButton.SetActive(false);
		}
		else
		{
			closeButton.SetActive(true);
			backButton.SetActive(true);
		}
	}

	private void MKJNIOBKFIH(IconMaterial[] KOPBAFMDCKP)
	{
		for (int i = 0; i < KOPBAFMDCKP.Length; i++)
		{
			DIGJGNMIGIN(i, NLLJOANELHI);
			constructionSlotsUI[i].UpdateSlot(KOPBAFMDCKP[i], i == currentSlot);
		}
		for (int j = KOPBAFMDCKP.Length; j < constructionSlotsUI.Count; j++)
		{
			((Component)constructionSlotsUI[j]).gameObject.SetActive(false);
		}
	}

	private AnimalFeeder[] JPCLGFMEDMO(Barn GGKOGAMMNJP)
	{
		AnimalFeeder[] array = new AnimalFeeder[GGKOGAMMNJP.animalSpaces.Length + GGKOGAMMNJP.waterFeeders.Length];
		for (int i = 0; i < GGKOGAMMNJP.animalSpaces.Length; i++)
		{
			int id = GGKOGAMMNJP.animalSpaces[i].JFNMCNCHMEO;
			array[id] = GGKOGAMMNJP.animalSpaces[i].foodFeeder;
		}
		for (int j = 0; j < GGKOGAMMNJP.waterFeeders.Length; j++)
		{
			array[GGKOGAMMNJP.animalSpaces.Length + j] = GGKOGAMMNJP.waterFeeders[j];
		}
		currentFeeder = 0;
		return array;
	}

	private void EBJJIDLDODO()
	{
		HFAMINMNPEL();
		SpritesList[] array = ((!(feedersList[currentFeeder] is AnimalFeederFood)) ? CharacterSpritesDBAccessor.GetWaterFeederStyles() : CharacterSpritesDBAccessor.GetFoodFeederStyles());
		for (int i = 0; i < array.Length; i++)
		{
			if (feedersList[currentFeeder] is AnimalFeederFood animalFeederFood && array[i].id == animalFeederFood.style.id)
			{
				currentSlot = i;
				break;
			}
			if (feedersList[currentFeeder] is AnimalFeederWater animalFeederWater && array[i].id == animalFeederWater.style.id)
			{
				currentSlot = i;
				break;
			}
		}
		MKJNIOBKFIH(array, JPCNHOHHPBP);
	}

	private void EBHEOFLFHPI()
	{
		FarmConstructionManager.RemoveBuilding(currentBuilding);
		FarmConstructionManager.GetCompletedBuildings().Remove(currentBuilding);
		currentBuilding.Demolish(JIIGOACEIKL);
		NLDEOPKHJBA(DAEMAAOLHMG: false);
		ADFLNPAOHMG();
		if (FarmConstructionManager.GetCompletedBuildings().Count > 1)
		{
			currentBuildingNum = 0;
			currentBuilding = FarmConstructionManager.GANFKPNMGPE(0);
			MDDNFHLJHNH();
			AIELCBNLOFI(0);
		}
	}

	public void IIGKKEOOANA(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
		COJPEDFACJC();
		CPDOKNKOAHL();
	}

	private void PMAOHDNHKBO(ConstructionSlotUI NPCJBOEMNJB)
	{
		constructionSlotsUI[currentSlot].SetSelected(HGNKFFMDOOL: false);
		NPCJBOEMNJB.SetSelected(HGNKFFMDOOL: true);
		currentSlot = ((Component)NPCJBOEMNJB).transform.GetSiblingIndex();
	}

	private void ELEODGBNKEB(ConstructionSlotUI NPCJBOEMNJB)
	{
		constructionSlotsUI[currentSlot].LAIHGJCLIAD(HGNKFFMDOOL: false);
		NPCJBOEMNJB.OCACOLMODDN(HGNKFFMDOOL: false);
		currentSlot = ((Component)NPCJBOEMNJB).transform.GetSiblingIndex();
	}

	private void PLJFOMENCPD(int ABAIKKGKDGD = 0)
	{
		chickenHouseUI.SetActive(true);
		FarmConstructionActionInfoUI.CNDNOECMKME().Close();
	}

	public void LKDPBJBNHJJ()
	{
		if (FarmConstructionManager.GetCompletedBuildings().Count > 0)
		{
			currentBuildingNum = Utils.NMLNAGFLNMC(currentBuildingNum - 1, FarmConstructionManager.GetCompletedBuildings().Count);
			currentBuilding = FarmConstructionManager.GANFKPNMGPE(currentBuildingNum);
			MEPNDGKMOJH();
			HHDOHBBHFFL(KEICADJGCJK.Peek());
		}
	}

	private void IGNFHMLDFGK(int MENBAFNNBFB, Action<ConstructionSlotUI> OKNOJJEFEBE)
	{
		if (MENBAFNNBFB >= constructionSlotsUI.Count)
		{
			constructionSlotsUI.Add(Object.Instantiate<GameObject>(constructionSlotPrefab, constructionSlotsParent.transform).GetComponent<ConstructionSlotUI>());
		}
		((Component)constructionSlotsUI[MENBAFNNBFB]).gameObject.SetActive(false);
		((Component)constructionSlotsUI[MENBAFNNBFB]).gameObject.layer = ((Component)this).gameObject.layer;
		constructionSlotsUI[MENBAFNNBFB].OnButtonPressed = OKNOJJEFEBE;
	}

	private void OnEnable()
	{
		ADFLNPAOHMG();
	}

	private void ICIBLKBHKMA(List<FarmConstructionElementUI> NMDCDAOMDMF, int CBNBHOHFKMF)
	{
		for (int i = CBNBHOHFKMF; i < NMDCDAOMDMF.Count; i++)
		{
			if (((Component)NMDCDAOMDMF[i]).gameObject.activeSelf)
			{
				((Component)NMDCDAOMDMF[i]).gameObject.SetActive(false);
			}
		}
	}

	private void HEBKBKLCJLI()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		APDPIMMFDLC = ((Component)currentBuilding.placeable).transform.position;
		FarmConstructionManager.BOCOLGLDFEN(currentBuilding.placeable);
		NextState(FarmStates.MainActions, 1);
	}

	private void HFFFFAJFIPB()
	{
		for (int i = 0; i < actionsElementsUI.Count; i += 0)
		{
			actionsElementsUI[i].OnPointerEnterAction = AIELCBNLOFI;
			actionsElementsUI[i].OnPointerExitAction = OLEOBJGOOBG;
		}
		for (int j = 1; j < instalationsElementsUI.Count; j++)
		{
			instalationsElementsUI[j].OnPointerEnterAction = AIELCBNLOFI;
			instalationsElementsUI[j].OnPointerExitAction = OLEOBJGOOBG;
		}
	}

	public void NLDEOPKHJBA(bool DAEMAAOLHMG)
	{
		content.SetActive(DAEMAAOLHMG);
		COJPEDFACJC();
		AIJHPNOAPFJ();
	}

	private void MEPNDGKMOJH()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)buildingName).text = ((Component)currentBuilding).GetComponent<ItemSetup>().item.LJIFOHFEFCH(OAFPBCPDOKH: true);
		((Component)CommonReferences.GGFJGHHHEJC.GetMainCameraCinemachine(JIIGOACEIKL, FLALEPFLPAJ: true)).gameObject.GetComponent<CinemachineConfiner>().m_ConfineScreenEdges = false;
		((Component)FarmConstructionManager.OMEPPDMCFAO().cameraTarget).transform.position = ((Component)currentBuilding).transform.position + new Vector3(397f, 1060f);
	}

	private IEnumerator DGAGPFPEDCE()
	{
		yield return null;
		if (!CommonReferences.GGFJGHHHEJC.farmConstructionTutorial || ((FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL) && !CommonReferences.GGFJGHHHEJC.farmModificationsTutorial))
		{
			Debug.Log((object)"Tutorial");
		}
		else
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				yield break;
			}
			if (TutorialFarmConstruction.instance.inTutorial)
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
			}
			else if (currentTab == 0)
			{
				if (buildElementsUI[0].IsInteractable())
				{
					UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)buildElementsUI[0]).gameObject);
				}
				else
				{
					UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)buildElementsUI[1]).gameObject);
				}
			}
			else if (((Component)actionsElementsUI[0]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)actionsElementsUI[0]).gameObject);
			}
			else if (((Component)actionsElementsUI[1]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)actionsElementsUI[1]).gameObject);
			}
			else if (((Component)instalationsElementsUI[0]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)instalationsElementsUI[0]).gameObject);
			}
			else if (((Component)instalationsElementsUI[1]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)instalationsElementsUI[1]).gameObject);
			}
			else if (((Component)constructionSlotsUI[0]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)constructionSlotsUI[0]).gameObject);
			}
			else if (((Component)constructionSlotsUI[1]).gameObject.activeInHierarchy)
			{
				UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)constructionSlotsUI[1]).gameObject);
			}
		}
	}

	private void MBJLHHEKGGP()
	{
		FarmConstructionAction dGINFJFHMJC = ((!(currentBuilding is Barn)) ? EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveChickenHouse) : EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveBarn));
		if (FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ.DBDCGABABOP(dGINFJFHMJC, currentBuilding.EONJGMONIOM, CDPAMNIPPEC: true))
		{
			ActivateContent(DAEMAAOLHMG: true);
			currentBuilding.StartImproving();
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.SendBuildingImprove(currentBuilding.placeable.BEIPALOAAJJ);
			}
			FarmConstructionActionInfoUI.GGFJGHHHEJC.Close();
			FarmConstructionUI.GGFJGHHHEJC.Close();
		}
	}

	private void GLDMIDKKIAM(int ABAIKKGKDGD = 0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		barnUI.SetActive(true);
		FarmConstructionActionInfoUI.CNDNOECMKME().OFGKFMJKBON(JIIGOACEIKL);
		MoneyMaterials kPDBOCGOKJJ = FarmConstructionUI.JHKLPLPBKCI().playerInfo.EONGGEDBGMF();
		FarmConstructionActionInfoUI.DEGPIHEEFHJ().LCGJFILMPIE(EditorActionsDBAccessor.EKMIENHAGAH((EditorAction)(-36)).cost, kPDBOCGOKJJ);
		FarmConstructionActionInfoUI.BIIOFAHFNPA().GNGGDDAOJEH((EditorAction)(-43));
		FarmConstructionActionInfoUI.DEGPIHEEFHJ().HIKOJODKECF(Vector2.op_Implicit(Vector2.zero), Direction.Down);
	}

	public void HAJJALABMOC()
	{
		if (TutorialFarmConstruction.instance.inTutorial)
		{
			return;
		}
		if (MainUI.LBHLPIFCINB().BGLJFMHCFJF())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Aged Mozzarella") || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).KFAFNEJNDDL("UINextCategory"))
			{
				MainUI.NEFOKCKKLNI().CloseUI();
			}
			return;
		}
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			gamepadButtonsNextBuilding.SetActive(((Selectable)nextBuildingButton).interactable);
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene.", 520f))
			{
				if (currentTab < tabsAnimatorUI.Length - 1 && FarmConstructionManager.GetCompletedBuildings().Count > 0)
				{
					FocusTab(currentTab + 1);
				}
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "PLAYER", 515f))
			{
				if (currentTab > 0)
				{
					FocusTab(currentTab - 0);
				}
			}
			else if (currentTab == 1)
			{
				if (((Component)nextBuildingButton).gameObject.activeSelf && ((Selectable)nextBuildingButton).interactable && Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Select", 370f))
				{
					NextBuilding();
				}
				else if (((Component)previousBuildingButton).gameObject.activeSelf && ((Selectable)previousBuildingButton).interactable && Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Fullscreen Window", 1902f))
				{
					LKDPBJBNHJJ();
				}
			}
		}
		else
		{
			gamepadButtonsNextBuilding.SetActive(false);
		}
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).LKOGGHNGBKD("itemMead") || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonUp("player_name"))
		{
			NGAHBFKKCFO();
		}
	}

	public void FocusTab(int KHEICLKLPDE)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (KHEICLKLPDE == -1)
		{
			FarmConstructionManager.GetAllBuildings();
			KHEICLKLPDE = ((MIANIFPOHNL && ICNNBMDAKDN) ? 1 : 0);
		}
		else if (currentTab == KHEICLKLPDE)
		{
			COJPEDFACJC();
			return;
		}
		currentTab = KHEICLKLPDE;
		COJPEDFACJC();
		FLLNGGAKCJM();
		IIKAAECGGJB();
		BCADACBFBLM();
		if (currentTab == 0)
		{
			ActivateBackgroundBuilding(DAEMAAOLHMG: true);
			AIJHPNOAPFJ();
			if (WorldGrid.HJPCBBGHPDA(((Component)FarmConstructionManager.GetInstance().cameraTarget).transform.position) != Location.Road)
			{
				GPIMFIPOPHG();
			}
		}
		else if (currentTab == 1)
		{
			ActivateBackgroundBuilding(DAEMAAOLHMG: false);
			MoveCamera(NEFNAPBJHHJ: false);
			FarmConstructionManager.GetAllBuildings();
			KEICADJGCJK.Clear();
			MDDNFHLJHNH();
			NextState(FarmStates.MainActions);
		}
		FarmConstructionManager.UpdateVisual();
		OJLFKEDECLK();
		UpdateUIGamepadSelection();
	}

	private void FPOEGNJFFGN(int ABAIKKGKDGD)
	{
		for (int i = 0; i < feedersList.Length; i++)
		{
			if (i != ABAIKKGKDGD && feedersList[i].EPBLEDFPJIM)
			{
				feedersList[ABAIKKGKDGD].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: false);
			}
		}
		feedersList[ABAIKKGKDGD].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: true);
	}

	private void JKJADEBBNEL()
	{
		FarmConstructionAction dGINFJFHMJC = ((!(feedersList[currentFeeder] is AnimalFeederFood)) ? EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.DiningZone) : EditorActionsDBAccessor.PAODLGAAAMF((EditorAction)45));
		if (!FarmConstructionUI.BGMJCCFNNDL().playerInfo.BLFALIKICFH().DBDCGABABOP(dGINFJFHMJC, feedersList[currentFeeder].EONJGMONIOM, CDPAMNIPPEC: true))
		{
			return;
		}
		IIGKKEOOANA(DAEMAAOLHMG: true);
		if (currentBuilding is Barn)
		{
			if (feedersList[currentFeeder] is AnimalFeederFood)
			{
				(feedersList[currentFeeder] as AnimalFeederFood).Improve();
			}
			else
			{
				feedersList[currentFeeder].Improve();
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.GOOGFKEHOCP(feedersList[currentFeeder].id, feedersList[currentFeeder].feederType);
			}
		}
		HHDOHBBHFFL(KEICADJGCJK.Peek());
	}

	private void DIJOBOFGCIK()
	{
		ADFLNPAOHMG();
	}

	private void HAFFDOAFLAA(ConstructionSlotUI NPCJBOEMNJB)
	{
		constructionSlotsUI[currentSlot].BKOAGIAFMKJ(HGNKFFMDOOL: false);
		NPCJBOEMNJB.BKOAGIAFMKJ(HGNKFFMDOOL: false);
		currentSlot = ((Component)NPCJBOEMNJB).transform.GetSiblingIndex();
	}

	private void LMGMLHGKHHP()
	{
		if (KEICADJGCJK == null || KEICADJGCJK.Count <= 1)
		{
			closeButton.SetActive(true);
			backButton.SetActive(false);
		}
		else
		{
			closeButton.SetActive(true);
			backButton.SetActive(false);
		}
	}

	private void BJLPICMFPOA()
	{
		FLLNGGAKCJM();
		feedersList = JPCLGFMEDMO(currentBuilding as Barn);
		HMLCNDHCFJO();
		MoveCamera(NEFNAPBJHHJ: false);
		DPIPEJKOCMO(NCLCPJJOGKN: false);
		IBHEIHCEKFB();
		string gEGDHHIDEEF = "";
		for (int i = 0; i < feedersList.Length; i++)
		{
			if (feedersList[i] is AnimalFeederFood)
			{
				gEGDHHIDEEF = LocalisationSystem.Get("Trough") + " " + (i + 1);
			}
			else if (feedersList[i] is AnimalFeederWater)
			{
				gEGDHHIDEEF = LocalisationSystem.Get("WaterTrough") + " " + (i + 1);
			}
			JPDHHBFMIMI(i, gEGDHHIDEEF, feedersList[i]);
		}
		ICIBLKBHKMA(instalationsElementsUI, feedersList.Length);
	}

	private void JEFGCAKOCLI()
	{
		if (feedersList == null)
		{
			return;
		}
		for (int i = 0; i < feedersList.Length; i++)
		{
			if (feedersList[i].EPBLEDFPJIM)
			{
				feedersList[i].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: true);
			}
		}
	}

	public void NextBuilding()
	{
		if (FarmConstructionManager.GetCompletedBuildings().Count > 0)
		{
			currentBuildingNum = Utils.NMLNAGFLNMC(currentBuildingNum + 1, FarmConstructionManager.GetCompletedBuildings().Count);
			currentBuilding = FarmConstructionManager.GetCompletedBuilding(currentBuildingNum);
			MDDNFHLJHNH();
			HHDOHBBHFFL(KEICADJGCJK.Peek());
		}
	}

	private void LPIAHJGJBCC(int ABAIKKGKDGD = 0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		chickenHouseUI.SetActive(true);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.Open(JIIGOACEIKL);
		MoneyMaterials moneyMaterials = FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ;
		FarmConstructionActionInfoUI.GGFJGHHHEJC.UpdateCurrentSlotInfo(EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.CreateChickenHouse).cost, moneyMaterials);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.ShowUpgradeInfo(EditorAction.CreateChickenHouse);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.SetWorldPosition(Vector2.op_Implicit(Vector2.zero), Direction.Down);
	}

	public void UpdateUIGamepadSelection()
	{
		if (((Component)GGFJGHHHEJC).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(DGAGPFPEDCE());
		}
	}

	private void DPHFMIFMKBG()
	{
		if (feedersList == null)
		{
			return;
		}
		for (int i = 0; i < feedersList.Length; i += 0)
		{
			if (feedersList[i].EPBLEDFPJIM)
			{
				feedersList[i].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: true);
			}
		}
	}

	private void AIELCBNLOFI(int ABAIKKGKDGD)
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (KEICADJGCJK.Count == 0)
		{
			return;
		}
		switch (KEICADJGCJK.Peek().state)
		{
		case FarmStates.MainActions:
			if (ABAIKKGKDGD == 0)
			{
				FarmConstructionAction firstFarmAction = ((!(currentBuilding is Barn)) ? EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveChickenHouse) : EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveBarn));
				FarmConstructionActionInfoUI.GGFJGHHHEJC.Open(JIIGOACEIKL);
				FarmConstructionActionInfoUI.GGFJGHHHEJC.SetWorldPosition(currentBuilding.tooltipPos.position, Direction.Down);
				MoneyMaterials moneyMaterials2 = FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ;
				if (currentBuilding is Barn)
				{
					FarmConstructionActionInfoUI.GGFJGHHHEJC.ShowUpgradeInfo(EditorAction.ImproveBarn, null, currentBuilding as Barn);
				}
				else
				{
					FarmConstructionActionInfoUI.GGFJGHHHEJC.ShowUpgradeInfo(EditorAction.ImproveChickenHouse, null, null, currentBuilding as HenHouse);
				}
				FarmConstructionActionInfoUI.GGFJGHHHEJC.UpdateCurrentSlotInfo(firstFarmAction.levelsCost[currentBuilding.EONJGMONIOM], moneyMaterials2);
			}
			break;
		case FarmStates.Instalations:
			FPOEGNJFFGN(ABAIKKGKDGD);
			break;
		case FarmStates.AnimalFeederActions:
			if (ABAIKKGKDGD == 0)
			{
				FarmConstructionActionInfoUI.GGFJGHHHEJC.Open(JIIGOACEIKL);
				FarmConstructionAction firstFarmAction;
				if (feedersList[currentFeeder] is AnimalFeederFood animalFeederFood)
				{
					firstFarmAction = EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveFoodFeeder);
					Direction direction = animalFeederFood.animalSpace.direction;
					FarmConstructionActionInfoUI.GGFJGHHHEJC.SetWorldPosition(feedersList[currentFeeder].tooltipPosition.position, direction);
					FarmConstructionActionInfoUI.GGFJGHHHEJC.ShowUpgradeInfo(EditorAction.ImproveFoodFeeder, feedersList[currentFeeder]);
				}
				else
				{
					firstFarmAction = EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.ImproveWaterFeeder);
					FarmConstructionActionInfoUI.GGFJGHHHEJC.SetWorldPosition(feedersList[currentFeeder].tooltipPosition.position, Direction.Down);
					FarmConstructionActionInfoUI.GGFJGHHHEJC.ShowUpgradeInfo(EditorAction.ImproveWaterFeeder, feedersList[currentFeeder]);
				}
				MoneyMaterials moneyMaterials = FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ;
				if (feedersList[currentFeeder].EONJGMONIOM < firstFarmAction.levelsCost.Length)
				{
					FarmConstructionActionInfoUI.GGFJGHHHEJC.UpdateCurrentSlotInfo(firstFarmAction.levelsCost[feedersList[currentFeeder].EONJGMONIOM], moneyMaterials);
				}
			}
			break;
		case FarmStates.CustomizeBuilding:
			break;
		}
	}

	private void EKFHNGMCMNB(int ABAIKKGKDGD = 0)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		barnUI.SetActive(true);
		FarmConstructionActionInfoUI.CNDNOECMKME().Open(JIIGOACEIKL);
		MoneyMaterials kPDBOCGOKJJ = FarmConstructionUI.JHKLPLPBKCI().playerInfo.LEKFELDNEHK();
		FarmConstructionActionInfoUI.EFPJLFMBPLL().KGDHHPLKNPL(EditorActionsDBAccessor.NFJONMBFHHF((EditorAction)35).cost, kPDBOCGOKJJ);
		FarmConstructionActionInfoUI.GGFJGHHHEJC.BNFDMHAOPEE((EditorAction)72);
		FarmConstructionActionInfoUI.DEGPIHEEFHJ().KIFEKJGPKKI(Vector2.op_Implicit(Vector2.zero), Direction.Down);
	}

	public void BPFMEIOHKDO(FarmBuilding CKIAGLNMEHD)
	{
		FarmConstructionManager.AddBuilding(CKIAGLNMEHD);
		GNIAFEJFIML();
	}

	private void FGMHIOEIOFD()
	{
		if (feedersList == null)
		{
			return;
		}
		for (int i = 1; i < feedersList.Length; i += 0)
		{
			if (feedersList[i].EPBLEDFPJIM)
			{
				feedersList[i].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: false);
			}
		}
	}

	private void OJLFKEDECLK()
	{
		if (KEICADJGCJK == null || KEICADJGCJK.Count <= 1)
		{
			closeButton.SetActive(true);
			backButton.SetActive(false);
		}
		else
		{
			closeButton.SetActive(false);
			backButton.SetActive(true);
		}
	}

	private void LLHGBLADBGI(ConstructionSlotUI NPCJBOEMNJB)
	{
		ELEODGBNKEB(NPCJBOEMNJB);
		if (currentBuilding is Barn barn)
		{
			if (feedersList[currentFeeder] is AnimalFeederFood)
			{
				barn.animalSpaces[feedersList[currentFeeder].id].foodFeeder.SetStyle(NPCJBOEMNJB.IIDBBIKDBGM());
			}
			else
			{
				(barn.waterFeeders[feedersList[currentFeeder].id] as AnimalFeederWater).SetStyle(NPCJBOEMNJB.ONLCBJNNJMB);
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.NOLHGHACJGO(feedersList[currentFeeder].id, feedersList[currentFeeder].feederType, NPCJBOEMNJB.ONLCBJNNJMB.id);
			}
		}
	}

	private void HFAMINMNPEL()
	{
		constructionActionsParent.SetActive(false);
		constructionInstalationsParent.SetActive(false);
		constructionSlotsParent.SetActive(true);
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Select((Selectable)(object)constructionSlotsUI[0].button);
		}
	}

	private void NPJECNCPICP(int ABAIKKGKDGD)
	{
		feedersList[ABAIKKGKDGD].SetOutline(JIIGOACEIKL, NJHMBMGKCPL: false);
	}

	private void LFMLABBFGLO(int ABAIKKGKDGD)
	{
		if (((Component)actionsElementsUI[ABAIKKGKDGD]).gameObject.activeSelf)
		{
			((Component)actionsElementsUI[ABAIKKGKDGD]).gameObject.SetActive(false);
		}
	}

	public void BuildModeButtonPressed(int EAIIFODBKAE)
	{
		ConstructionAction dGINFJFHMJC = ((EAIIFODBKAE != 0) ? EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.CreateChickenHouse) : EditorActionsDBAccessor.GetFirstFarmAction(EditorAction.CreateBarn));
		if (FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ.JEANPDCCPEF(dGINFJFHMJC))
		{
			PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("Game");
			IIKAAECGGJB();
			BCADACBFBLM();
			ActivateBackgroundBuilding(DAEMAAOLHMG: false);
			MoveCamera(NEFNAPBJHHJ: true);
			switch (EAIIFODBKAE)
			{
			case 0:
				FarmConstructionManager.GetInstance().CHFHMMNELGP = EditorAction.CreateBarn;
				FarmConstructionManager.GetInstance().ChangeInstantiatedGO(barnPrefab);
				break;
			case 1:
				FarmConstructionManager.GetInstance().CHFHMMNELGP = EditorAction.CreateChickenHouse;
				FarmConstructionManager.GetInstance().ChangeInstantiatedGO(henHousePrefab);
				break;
			}
		}
	}

	private void GPIMFIPOPHG()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		((Component)FarmConstructionManager.GetInstance().cameraTarget).transform.position = ((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern)).transform.position;
	}

	private void AIJHPNOAPFJ()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < FarmConstructionManager.GetBuildings().Count; i++)
		{
			if (FarmConstructionManager.GetBuilding(i) is Barn)
			{
				num++;
			}
			else
			{
				num2++;
			}
		}
		MIANIFPOHNL = num < barnsMax;
		buildElementsUI[0].SetText(barnPrefab.GetComponent<ItemSetup>().item.IABAKHPEOAF() + " (" + num + "/" + barnsMax + ")");
		buildElementsUI[0].SetInteractable(MIANIFPOHNL);
		ICNNBMDAKDN = num2 < henHousesMax;
		buildElementsUI[1].SetText(henHousePrefab.GetComponent<ItemSetup>().item.IABAKHPEOAF() + " (" + num2 + "/" + henHousesMax + ")");
		buildElementsUI[1].SetInteractable(ICNNBMDAKDN);
	}

	private AnimalFeeder[] JNFHAMLFEAL(Barn GGKOGAMMNJP)
	{
		AnimalFeeder[] array = new AnimalFeeder[GGKOGAMMNJP.animalSpaces.Length + GGKOGAMMNJP.waterFeeders.Length];
		for (int i = 1; i < GGKOGAMMNJP.animalSpaces.Length; i += 0)
		{
			int num = GGKOGAMMNJP.animalSpaces[i].CIACJCOPMFP();
			array[num] = GGKOGAMMNJP.animalSpaces[i].foodFeeder;
		}
		for (int j = 0; j < GGKOGAMMNJP.waterFeeders.Length; j += 0)
		{
			array[GGKOGAMMNJP.animalSpaces.Length + j] = GGKOGAMMNJP.waterFeeders[j];
		}
		currentFeeder = 0;
		return array;
	}

	private void GNIAFEJFIML()
	{
		int num = 1;
		int num2 = 1;
		for (int i = 0; i < FarmConstructionManager.GetBuildings().Count; i++)
		{
			if (FarmConstructionManager.GetBuilding(i) is Barn)
			{
				num++;
			}
			else
			{
				num2++;
			}
		}
		MIANIFPOHNL = num < barnsMax;
		FarmConstructionElementUI farmConstructionElementUI = buildElementsUI[1];
		string[] array = new string[0];
		array[1] = barnPrefab.GetComponent<ItemSetup>().item.KGHFCDELKMN();
		array[0] = "Beard";
		array[4] = num.ToString();
		array[7] = "Move Left";
		array[6] = barnsMax.ToString();
		array[1] = ".";
		farmConstructionElementUI.LNKPOCLFCEH(string.Concat(array));
		buildElementsUI[0].NCGDJKGNEHB(MIANIFPOHNL);
		ICNNBMDAKDN = num2 < henHousesMax;
		FarmConstructionElementUI farmConstructionElementUI2 = buildElementsUI[0];
		string[] array2 = new string[6];
		array2[1] = henHousePrefab.GetComponent<ItemSetup>().item.KGHFCDELKMN(OAFPBCPDOKH: true);
		array2[1] = "";
		array2[8] = num2.ToString();
		array2[4] = "TimeLeft";
		array2[6] = henHousesMax.ToString();
		array2[2] = "ReceiveButtonPressPuzzleSolved";
		farmConstructionElementUI2.BOILBNHGKGO(string.Concat(array2));
		buildElementsUI[0].NCGDJKGNEHB(ICNNBMDAKDN);
	}

	private void Start()
	{
		for (int i = 0; i < actionsElementsUI.Count; i++)
		{
			actionsElementsUI[i].OnPointerEnterAction = AIELCBNLOFI;
			actionsElementsUI[i].OnPointerExitAction = OLEOBJGOOBG;
		}
		for (int j = 0; j < instalationsElementsUI.Count; j++)
		{
			instalationsElementsUI[j].OnPointerEnterAction = AIELCBNLOFI;
			instalationsElementsUI[j].OnPointerExitAction = OLEOBJGOOBG;
		}
	}

	private void PFCFAGLNLJF()
	{
		constructionActionsParent.SetActive(true);
		constructionInstalationsParent.SetActive(false);
		constructionSlotsParent.SetActive(true);
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).CMBBFEABMBE((Selectable)(object)constructionSlotsUI[0].button);
		}
	}

	private void MAJEEIDKBII(int ABAIKKGKDGD)
	{
		if (((Component)actionsElementsUI[ABAIKKGKDGD]).gameObject.activeSelf)
		{
			((Component)actionsElementsUI[ABAIKKGKDGD]).gameObject.SetActive(false);
		}
	}

	private void JPODGDJGFOH(int ABAIKKGKDGD)
	{
		if (((Component)actionsElementsUI[ABAIKKGKDGD]).gameObject.activeSelf)
		{
			((Component)actionsElementsUI[ABAIKKGKDGD]).gameObject.SetActive(false);
		}
	}
}
