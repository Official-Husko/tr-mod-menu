using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class FarmConstructionManager : ConstructionManager
{
	[CompilerGenerated]
	private sealed class HBIEEDKACEH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public FarmConstructionManager _003C_003E4__this;

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
		public HBIEEDKACEH(int _003C_003E1__state)
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
			FarmConstructionManager mOBFJEDPIPM = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait075;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerController.RemoveMovementBlocker(playerNum, (Object)(object)mOBFJEDPIPM);
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

	[CompilerGenerated]
	private sealed class FDEMKGGJHNO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public FDEMKGGJHNO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)BuzzNPC.GGFJGHHHEJC != (Object)null)
				{
					BuzzNPC.GGFJGHHHEJC.inBuild = false;
					BuzzNPC.GGFJGHHHEJC.busy = false;
				}
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

	public static FarmConstructionManager instance;

	[SerializeField]
	private Transform roadCameraMin;

	[SerializeField]
	private Transform roadCameraMax;

	public static bool instantiatingGO;

	public List<FarmBuilding> allBuildings = new List<FarmBuilding>();

	[SerializeField]
	private List<FarmBuilding> completedBuildings = new List<FarmBuilding>();

	private int BGDBAGMAMHB = -1;

	public static Placeable OIFCIKGLCJB { get; private set; }

	private static int JIIGOACEIKL => FarmConstructionUI.NLCDDFDGACP;

	public override bool LNLJMCONDNE
	{
		get
		{
			return PHGHJDMCKCN;
		}
		set
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			PHGHJDMCKCN = value;
			RemoveAccessInstantiated();
			if (!OnlineManager.PlayingOnline() && !GameManager.LocalCoop())
			{
				WorldTime.JJICPIINBEH = PHGHJDMCKCN;
			}
			instantiatingGO = false;
			if (PHGHJDMCKCN)
			{
				ConstructionManager.current = this;
				PlayerController.AddMovementBlocker((Object)(object)this);
				((Component)cameraTarget).transform.position = ((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern)).transform.position;
				CommonReferences.GGFJGHHHEJC.SetCinemachineTarget(1, ((Component)cameraTarget).transform);
				cameraTarget.LNLJMCONDNE = true;
				if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CursorManager.GetPlayer(JIIGOACEIKL).CursorAppears();
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineFarmConstructionManager.instance.SendFarmConstructionActivated();
				}
				OnActivated(JIIGOACEIKL);
				return;
			}
			ConstructionManager.current = null;
			((Component)GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap).gameObject.SetActive(false);
			((Component)GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap).gameObject.SetActive(false);
			DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH = false;
			PlayerController.RemoveMovementBlocker((Object)(object)this);
			CommonReferences.GGFJGHHHEJC.SetCinemachineTarget(1, ((Component)CameraTarget.GetPlayer(1)).transform);
			cameraTarget.LNLJMCONDNE = false;
			cameraTarget.SetCurrentBuilding(null);
			EditorTileMaps.ResetEditorTiles();
			if (OnlineManager.PlayingOnline())
			{
				OnlineFarmConstructionManager.instance.SendFarmConstructionDeactivated();
			}
			OnDeactivated(JIIGOACEIKL);
		}
	}

	public override EditorAction CHFHMMNELGP
	{
		get
		{
			return GDIFLANEEPG;
		}
		set
		{
			GDIFLANEEPG = value;
			OnEditorActionChanged(GDIFLANEEPG);
			RemoveAccessInstantiated();
			UpdateVisual();
		}
	}

	public static bool HCGPNLDHHKF
	{
		get
		{
			GetAllBuildings();
			for (int i = 0; i < instance.allBuildings.Count; i++)
			{
				if (!instance.allBuildings[i].IsBuilt())
				{
					return true;
				}
				if (instance.allBuildings[i].KAPKMMGKEPJ > 0)
				{
					return true;
				}
			}
			return false;
		}
	}

	public static bool CEHBPNMGCMM
	{
		get
		{
			HOFCEDEHDPA();
			if (instance.completedBuildings.Count == 0 || instance.completedBuildings[0] is Barn)
			{
				return false;
			}
			return true;
		}
	}

	public static bool HBCJHEBFBAO
	{
		get
		{
			HOFCEDEHDPA();
			for (int i = 0; i < instance.completedBuildings.Count; i++)
			{
				if (instance.completedBuildings[i] is HenHouse)
				{
					return true;
				}
			}
			return false;
		}
	}

	public static bool CNEEPCGBBBL
	{
		get
		{
			HOFCEDEHDPA();
			for (int i = 0; i < instance.completedBuildings.Count; i++)
			{
				if (instance.completedBuildings[i] is Barn)
				{
					return true;
				}
			}
			return false;
		}
	}

	public static bool CEJNMAGCNLD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > ((Component)instance.roadCameraMin).transform.position.x && IMOBLFMHKOD.x < ((Component)instance.roadCameraMax).transform.position.x && IMOBLFMHKOD.y > ((Component)instance.roadCameraMin).transform.position.y)
		{
			return IMOBLFMHKOD.y < ((Component)instance.roadCameraMax).transform.position.y;
		}
		return false;
	}

	public void OtherPlayerActivatedFarmMode(bool KBNNPAKJDJM = false)
	{
		if (!KBNNPAKJDJM)
		{
			CACBPHGMFLA();
			((MonoBehaviour)this).Invoke("CACBPHGMFLA", 2f);
		}
		BlockBuzzInteraction();
	}

	public static FarmBuilding GANFKPNMGPE(int BPDCFGHJNDA)
	{
		return instance.completedBuildings[BPDCFGHJNDA];
	}

	[SpecialName]
	public static Placeable AHAPLDALHDD()
	{
		return _003CIFDODNKJGDP_003Ek__BackingField;
	}

	protected override void NFHHEMPGCNM(int JIIGOACEIKL)
	{
		if (!LNLJMCONDNE)
		{
			return;
		}
		if (instantiatingGO)
		{
			ConstructionAction constructionAction = EditorActionsDBAccessor.GetFarmActions(CHFHMMNELGP)[0];
			if ((Object)(object)constructionAction != (Object)null && (Object)(object)constructionAction.instantiateGO != (Object)null)
			{
				ChangeInstantiatedGO(constructionAction.instantiateGO);
			}
		}
		UpdateVisual();
	}

	public static List<FarmBuilding> GetBuildings()
	{
		return instance.allBuildings;
	}

	private void OABDMFLOGDJ()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		if (!ConstructionManager.currentInstantiatedGO.IsObjectInValidLocation(BIOKGEFFNAA: true) || !ConstructionManager.currentInstantiatedGO.DeselectAction(JIIGOACEIKL))
		{
			return;
		}
		ConstructionAction firstFarmAction = EditorActionsDBAccessor.GetFirstFarmAction(CHFHMMNELGP);
		FarmConstructionUI.GGFJGHHHEJC.playerInfo.KJLGKKDALAJ.DBDCGABABOP(firstFarmAction, CDPAMNIPPEC: true);
		SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
		FarmBuilding component = ((Component)ConstructionManager.currentInstantiatedGO).GetComponent<FarmBuilding>();
		component.SetConstructionPhase(0);
		component.ResetImprovement();
		component.changeLayers.ResetLayers();
		FarmConstructionActionsUI.GGFJGHHHEJC.AddBuilding(component);
		FarmConstructionActionsUI.GGFJGHHHEJC.ActivateBackgroundBuilding(DAEMAAOLHMG: true);
		FarmConstructionActionsUI.GGFJGHHHEJC.MoveCamera(NEFNAPBJHHJ: false);
		ConstructionManager.currentInstantiatedGO = null;
		instantiatingGO = false;
		cameraTarget.SetCurrentBuilding(null);
		UpdateVisual();
		FarmConstructionUI.GGFJGHHHEJC.Close();
		Debug.Log((object)"Empieza a construir");
		Result variable = DialogueLua.GetVariable("BuzzBuildExit");
		if (((Result)(ref variable)).asInt == 0)
		{
			BuzzNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Farm/Buzz/BuildExit");
			return;
		}
		variable = DialogueLua.GetVariable("BuzzBuildExit");
		if (((Result)(ref variable)).asInt == 1)
		{
			DialogueManager.Bark("Farm/Buzz/BuildExit", ((Component)BuzzNPC.GGFJGHHHEJC).transform);
		}
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	protected override void LAEIKGKFPKB(int JIIGOACEIKL)
	{
		if (LNLJMCONDNE)
		{
			RemoveAccessInstantiated();
			UpdateVisual();
		}
	}

	public static FarmBuilding GetCompletedBuilding(int BPDCFGHJNDA)
	{
		return instance.completedBuildings[BPDCFGHJNDA];
	}

	public static bool FKMDDKBDCLJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > ((Component)instance.roadCameraMin).transform.position.x && IMOBLFMHKOD.x < ((Component)instance.roadCameraMax).transform.position.x && IMOBLFMHKOD.y > ((Component)instance.roadCameraMin).transform.position.y)
		{
			return IMOBLFMHKOD.y < ((Component)instance.roadCameraMax).transform.position.y;
		}
		return true;
	}

	[SpecialName]
	public static bool DJAKMPLNNEG()
	{
		KHOGJGCDELO();
		for (int i = 0; i < instance.allBuildings.Count; i++)
		{
			if (!instance.allBuildings[i].IsBuilt())
			{
				return false;
			}
			if (instance.allBuildings[i].KAPKMMGKEPJ > 1)
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	public static bool FLIKJEDMNNK()
	{
		GetAllBuildings();
		for (int i = 0; i < instance.allBuildings.Count; i += 0)
		{
			if (!instance.allBuildings[i].IsBuilt())
			{
				return false;
			}
			if (instance.allBuildings[i].KAPKMMGKEPJ > 1)
			{
				return false;
			}
		}
		return false;
	}

	public static void KHOGJGCDELO()
	{
		instance.allBuildings.Clear();
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL())
			{
				return;
			}
			if (currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == 26 || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 179)
			{
				FarmBuilding component = ((Component)currentPlaceables[i]).GetComponent<FarmBuilding>();
				instance.allBuildings.Add(component);
			}
		}
		HOFCEDEHDPA();
		if (Object.op_Implicit((Object)(object)FarmConstructionActionsUI.DCAEBALADIM()))
		{
			FarmConstructionActionsUI.GGFJGHHHEJC.currentBuildingNum = 1;
			if (instance.completedBuildings.Count > 1)
			{
				FarmConstructionActionsUI.GGFJGHHHEJC.currentBuilding = instance.completedBuildings[1];
			}
			else
			{
				FarmConstructionActionsUI.GGFJGHHHEJC.currentBuilding = null;
			}
		}
	}

	public static void BPONMLCCIAL()
	{
		if (instance.PHGHJDMCKCN)
		{
			if (instantiatingGO)
			{
				((Component)GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap).gameObject.SetActive(ConstructionManager.currentInstantiatedGO.itemSetup.item.JGHNDJBCFAJ() == -63);
				((Component)GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap).gameObject.SetActive(ConstructionManager.currentInstantiatedGO.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 130);
			}
			else if ((Object)(object)OIFCIKGLCJB != (Object)null)
			{
				((Component)GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap).gameObject.SetActive(AHAPLDALHDD().itemSetup.item.JGHNDJBCFAJ() == -169);
				((Component)GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap).gameObject.SetActive(OIFCIKGLCJB.itemSetup.item.JGHNDJBCFAJ() == 147);
			}
			else
			{
				((Component)GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap).gameObject.SetActive(false);
				((Component)GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap).gameObject.SetActive(true);
			}
			FarmConstructionActionsUI.GGFJGHHHEJC.IIGKKEOOANA(!instantiatingGO);
			if (DecorationMode.IGMCBPOPNCA(ConstructionUI.current.JIIGOACEIKL).IDPGEBNGDJD())
			{
				EditorTileMaps.BPABEMMGPOD();
			}
		}
	}

	public void AFHOMGNGMPK()
	{
		UnblockBuzzInteractionWithDelay();
	}

	public static bool IsInsideBuildLimits(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > ((Component)instance.roadCameraMin).transform.position.x && IMOBLFMHKOD.x < ((Component)instance.roadCameraMax).transform.position.x && IMOBLFMHKOD.y > ((Component)instance.roadCameraMin).transform.position.y)
		{
			return IMOBLFMHKOD.y < ((Component)instance.roadCameraMax).transform.position.y;
		}
		return false;
	}

	private IEnumerator NBKIAPJKNNL(int JIIGOACEIKL)
	{
		return new HBIEEDKACEH(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void OtherPlayerDeactivatedFarmMode()
	{
		UnblockBuzzInteractionWithDelay();
	}

	public static bool HMDJEMGNPJN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (IMOBLFMHKOD.x > ((Component)instance.roadCameraMin).transform.position.x && IMOBLFMHKOD.x < ((Component)instance.roadCameraMax).transform.position.x && IMOBLFMHKOD.y > ((Component)instance.roadCameraMin).transform.position.y)
		{
			return IMOBLFMHKOD.y < ((Component)instance.roadCameraMax).transform.position.y;
		}
		return false;
	}

	private void Update()
	{
		if (LNLJMCONDNE)
		{
			PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).ToggleBuildMode();
			if (!DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH)
			{
				CMADPLAHBEG();
			}
		}
	}

	private IEnumerator NJIMOFCNHCD()
	{
		yield return CommonReferences.wait1;
		if ((Object)(object)BuzzNPC.GGFJGHHHEJC != (Object)null)
		{
			BuzzNPC.GGFJGHHHEJC.inBuild = false;
			BuzzNPC.GGFJGHHHEJC.busy = false;
		}
	}

	private IEnumerator OCBFIDHNEEE()
	{
		return new FDEMKGGJHNO(1);
	}

	public static void GetAllBuildings()
	{
		instance.allBuildings.Clear();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA)
			{
				return;
			}
			if (currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1230 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1231)
			{
				FarmBuilding component = ((Component)currentPlaceables[i]).GetComponent<FarmBuilding>();
				instance.allBuildings.Add(component);
			}
		}
		HOFCEDEHDPA();
		if (Object.op_Implicit((Object)(object)FarmConstructionActionsUI.GGFJGHHHEJC))
		{
			FarmConstructionActionsUI.GGFJGHHHEJC.currentBuildingNum = 0;
			if (instance.completedBuildings.Count > 0)
			{
				FarmConstructionActionsUI.GGFJGHHHEJC.currentBuilding = instance.completedBuildings[0];
			}
			else
			{
				FarmConstructionActionsUI.GGFJGHHHEJC.currentBuilding = null;
			}
		}
	}

	private void IFMIDIBLPOK()
	{
		SelectObject.GetPlayer(ACKIFIBCIFA()).MGAPCJMMIAF(ConstructionManager.currentInstantiatedGO);
		if (PlayerInputs.FJLAMCHKCOI(OGCICFOBBLA()))
		{
			CursorManager.GetPlayer(OGCICFOBBLA()).LLJCIJIDEJG();
		}
		CursorManager.CMDGPJEIIJI(OGCICFOBBLA()).JHMPKHNEDEL(CursorManager.CursorType.Select);
		PlayerInputs.DEGBDMMDIIL(ACKIFIBCIFA()).AMMIOLBGBPB("Error Fireplace.TurnOff: ");
	}

	public static void CBIHEJCEGJJ(bool EGFGNGJGBOP)
	{
		instance.LNLJMCONDNE = EGFGNGJGBOP;
	}

	protected override void CMADPLAHBEG()
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null)
		{
			ConstructionManager.currentInstantiatedGO.OnHover(JIIGOACEIKL);
			if (!PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Interact"))
			{
				return;
			}
			ConstructionAction firstFarmAction = EditorActionsDBAccessor.GetFirstFarmAction(CHFHMMNELGP);
			if (ConstructionManager.currentInstantiatedGO.IsObjectInValidLocation(BIOKGEFFNAA: true) && FarmConstructionUI.GGFJGHHHEJC.playerInfo.CanPay(firstFarmAction))
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
				CursorManager.GetPlayer(JIIGOACEIKL).ChangeCursorTexture(CursorManager.CursorType.Default);
				if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
				}
				MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("BuildConfirmation", JIIGOACEIKL), ConstructionManager.currentInstantiatedGO.itemSetup.item.IABAKHPEOAF());
				MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(OABDMFLOGDJ));
				MainUI.GetYesNoDialogue().AddNoAction(new UnityAction(NAFJJJBNDKB));
			}
		}
		else if ((Object)(object)OIFCIKGLCJB != (Object)null)
		{
			OIFCIKGLCJB.OnHover(JIIGOACEIKL);
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Interact") && DeselectAtPosition(((Component)OIFCIKGLCJB).transform.position))
			{
				FarmConstructionActionsUI.GGFJGHHHEJC.GoToPreviousState();
				UpdateVisual();
				cameraTarget.SetCurrentBuilding(null);
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
				CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
			}
		}
		else
		{
			HoverObject.GetPlayer(JIIGOACEIKL).Hover(null);
		}
	}

	public static void BOCOLGLDFEN(Placeable DIANGLDOOOM)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		OIFCIKGLCJB = DIANGLDOOOM;
		SelectObject.BNMEANGDMIP(ACKIFIBCIFA()).SelectPlaceable(OIFCIKGLCJB);
		OIFCIKGLCJB.SetMouseOffset(Vector3.zero);
		if (OnlineManager.HHDBMDMFEMP())
		{
			AHAPLDALHDD().StartMoving(1, PHJILIBHABG: false, GFNHAMCPEAK: false, MAFODGNALFJ: true, MCFNOAFOIHE: false);
		}
		if (PlayerInputs.FJLAMCHKCOI(ACKIFIBCIFA()))
		{
			CursorManager.GetPlayer(ACKIFIBCIFA()).MGGNJMAAOID();
			CursorManager.GetPlayer(OGCICFOBBLA()).AMDJLKEGEIA(new Vector3(1565f, 1629f));
		}
		AHAPLDALHDD().itemSpace.checkConstructionPositions = false;
		OIFCIKGLCJB.itemSpace.checkHerbs = true;
		FarmBuilding component = ((Component)OIFCIKGLCJB).GetComponent<FarmBuilding>();
		component.changeLayers.HBMHCLEPLCC();
		instance.cameraTarget.CILPNJNGBOH(component);
		PlayerInputs.DEGBDMMDIIL(ACKIFIBCIFA()).AMMIOLBGBPB("Not enough ingredients");
		UpdateVisual();
	}

	public static void JOMOCKEOLJO(Placeable DIANGLDOOOM)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		OIFCIKGLCJB = DIANGLDOOOM;
		SelectObject.BNMEANGDMIP(ACKIFIBCIFA()).MGAPCJMMIAF(OIFCIKGLCJB);
		AHAPLDALHDD().SetMouseOffset(Vector3.zero);
		if (OnlineManager.HHDBMDMFEMP())
		{
			AHAPLDALHDD().StartMoving(0, PHJILIBHABG: true, GFNHAMCPEAK: false);
		}
		if (PlayerInputs.ODGALPDEIFG(ACKIFIBCIFA()))
		{
			CursorManager.CMDGPJEIIJI(OGCICFOBBLA()).LLJCIJIDEJG();
			CursorManager.CMDGPJEIIJI(ACKIFIBCIFA()).EJCCBDAALHH(new Vector3(1421f, 360f));
		}
		AHAPLDALHDD().itemSpace.checkConstructionPositions = false;
		OIFCIKGLCJB.itemSpace.checkHerbs = true;
		FarmBuilding component = ((Component)AHAPLDALHDD()).GetComponent<FarmBuilding>();
		component.changeLayers.KNDAEECDJFA();
		instance.cameraTarget.SetCurrentBuilding(component);
		PlayerInputs.DEGBDMMDIIL(OGCICFOBBLA()).SwitchMapCategoryNextFrame("Citrus");
		BPONMLCCIAL();
	}

	private IEnumerator KAJACKNOHGK()
	{
		yield return CommonReferences.wait1;
		if ((Object)(object)BuzzNPC.GGFJGHHHEJC != (Object)null)
		{
			BuzzNPC.GGFJGHHHEJC.inBuild = false;
			BuzzNPC.GGFJGHHHEJC.busy = false;
		}
	}

	public static Barn GetBarn()
	{
		HOFCEDEHDPA();
		for (int i = 0; i < instance.completedBuildings.Count; i++)
		{
			if (instance.completedBuildings[i] is Barn result)
			{
				return result;
			}
		}
		return null;
	}

	public static FarmBuilding JNAMFKEEFAE(int BPDCFGHJNDA)
	{
		return instance.allBuildings[BPDCFGHJNDA];
	}

	private void NAFJJJBNDKB()
	{
		SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(ConstructionManager.currentInstantiatedGO);
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			CursorManager.GetPlayer(JIIGOACEIKL).CursorAppears();
		}
		CursorManager.GetPlayer(JIIGOACEIKL).ChangeCursorTexture(CursorManager.CursorType.Placing);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("Game");
	}

	private IEnumerator FMLIFGFCCHF()
	{
		yield return CommonReferences.wait1;
		if ((Object)(object)BuzzNPC.GGFJGHHHEJC != (Object)null)
		{
			BuzzNPC.GGFJGHHHEJC.inBuild = false;
			BuzzNPC.GGFJGHHHEJC.busy = false;
		}
	}

	private static void HOFCEDEHDPA()
	{
		if (instance.BGDBAGMAMHB == WorldTime.NOAOJJLNHJJ.DKGMLALMDEH())
		{
			return;
		}
		instance.completedBuildings.Clear();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && (currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1230 || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1231))
			{
				FarmBuilding component = ((Component)currentPlaceables[i]).GetComponent<FarmBuilding>();
				if (component.IsBuilt())
				{
					instance.completedBuildings.Add(component);
				}
			}
		}
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			instance.BGDBAGMAMHB = WorldTime.NOAOJJLNHJJ.DKGMLALMDEH();
		}
	}

	[SpecialName]
	private static int OGCICFOBBLA()
	{
		return FarmConstructionUI.NAFIKJBIGAB();
	}

	public static void NEOMIAMGFIG(FarmBuilding MAAFFAMLKKG)
	{
		instance.allBuildings.Remove(MAAFFAMLKKG);
	}

	private void CACBPHGMFLA()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(1).UpdateZone();
		if (!((Object)(object)Barn.instance == (Object)null) && PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.BarnInterior)
		{
			PlayerController.TeleportPlayer(1, TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.BarnInterior).GetCentrePosition() - new Vector3(0f, 1f), Location.Road);
			PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Down;
			PlayerController.AddMovementBlocker(1, (Object)(object)this);
			((MonoBehaviour)this).StartCoroutine(LNFPCGEBPKH(1));
			InteractObject.GetPlayer(1).SetCurrentInteract(null, null);
		}
	}

	public static void UpdateVisual()
	{
		if (instance.PHGHJDMCKCN)
		{
			if (instantiatingGO)
			{
				((Component)GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap).gameObject.SetActive(ConstructionManager.currentInstantiatedGO.itemSetup.item.JDJGFAACPFC() == 1230);
				((Component)GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap).gameObject.SetActive(ConstructionManager.currentInstantiatedGO.itemSetup.item.JDJGFAACPFC() == 1231);
			}
			else if ((Object)(object)OIFCIKGLCJB != (Object)null)
			{
				((Component)GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap).gameObject.SetActive(OIFCIKGLCJB.itemSetup.item.JDJGFAACPFC() == 1230);
				((Component)GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap).gameObject.SetActive(OIFCIKGLCJB.itemSetup.item.JDJGFAACPFC() == 1231);
			}
			else
			{
				((Component)GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap).gameObject.SetActive(false);
				((Component)GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap).gameObject.SetActive(false);
			}
			FarmConstructionActionsUI.GGFJGHHHEJC.ActivateContent(!instantiatingGO);
			if (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH)
			{
				EditorTileMaps.ResetEditorTiles();
			}
		}
	}

	public static void RemoveBuilding(FarmBuilding MAAFFAMLKKG)
	{
		instance.allBuildings.Remove(MAAFFAMLKKG);
	}

	public static FarmBuilding GetBuilding(int BPDCFGHJNDA)
	{
		return instance.allBuildings[BPDCFGHJNDA];
	}

	public static void SetActived(bool EGFGNGJGBOP)
	{
		instance.LNLJMCONDNE = EGFGNGJGBOP;
	}

	public static FarmBuilding MHMGMLOPAOI(int BPDCFGHJNDA)
	{
		return instance.allBuildings[BPDCFGHJNDA];
	}

	[SpecialName]
	public static bool IJCLOFLLLPA()
	{
		KHOGJGCDELO();
		for (int i = 1; i < instance.allBuildings.Count; i++)
		{
			if (!instance.allBuildings[i].IsBuilt())
			{
				return false;
			}
			if (instance.allBuildings[i].KAPKMMGKEPJ > 1)
			{
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	public static bool NLPIACLMFHM()
	{
		KHOGJGCDELO();
		for (int i = 0; i < instance.allBuildings.Count; i += 0)
		{
			if (!instance.allBuildings[i].IsBuilt())
			{
				return false;
			}
			if (instance.allBuildings[i].KAPKMMGKEPJ > 1)
			{
				return true;
			}
		}
		return true;
	}

	public override void ChangeInstantiatedGO(GameObject DIEMDFCBEFB)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DIEMDFCBEFB != (Object)null)
		{
			instantiatingGO = true;
		}
		if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null)
		{
			if ((Object)(object)DIEMDFCBEFB != (Object)null && ConstructionManager.currentInstantiatedGO.itemSetup.item.JDJGFAACPFC() == DIEMDFCBEFB.GetComponent<Placeable>().itemSetup.item.JDJGFAACPFC())
			{
				return;
			}
			RemoveAccessInstantiated();
		}
		if ((Object)(object)DIEMDFCBEFB != (Object)null)
		{
			Vector3 iMOBLFMHKOD;
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				iMOBLFMHKOD = ((Component)cameraTarget).transform.position;
				CursorManager.GetPlayer(JIIGOACEIKL).CursorAppears();
			}
			else
			{
				iMOBLFMHKOD = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			}
			ConstructionManager.currentInstantiatedGO = Object.Instantiate<GameObject>(DIEMDFCBEFB, Utils.BMBMPKNANAC(iMOBLFMHKOD), Quaternion.identity).GetComponent<Placeable>();
			ConstructionManager.currentInstantiatedGO.Action(JIIGOACEIKL, KLGOCJMGKFO: true);
			ConstructionManager.currentInstantiatedGO.itemSpace.checkConstructionPositions = true;
			ConstructionManager.currentInstantiatedGO.itemSpace.checkHerbs = false;
			FarmBuilding component = ((Component)ConstructionManager.currentInstantiatedGO).GetComponent<FarmBuilding>();
			cameraTarget.SetCurrentBuilding(component);
			component.changeLayers.Change();
		}
		UpdateVisual();
	}

	private IEnumerator NAPNCGCGPPP()
	{
		yield return CommonReferences.wait1;
		if ((Object)(object)BuzzNPC.GGFJGHHHEJC != (Object)null)
		{
			BuzzNPC.GGFJGHHHEJC.inBuild = false;
			BuzzNPC.GGFJGHHHEJC.busy = false;
		}
	}

	public void BlockBuzzInteraction()
	{
		if ((Object)(object)BuzzNPC.GGFJGHHHEJC != (Object)null)
		{
			BuzzNPC.GGFJGHHHEJC.inBuild = true;
			BuzzNPC.GGFJGHHHEJC.busy = true;
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public static bool DeselectAtPosition(Vector3 IMOBLFMHKOD, bool AINPJHKNJGL = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Component)OIFCIKGLCJB).transform.position = IMOBLFMHKOD;
		((Component)OIFCIKGLCJB).GetComponent<FarmBuilding>().changeLayers.ResetLayers();
		if ((AINPJHKNJGL || OIFCIKGLCJB.IsObjectInValidLocation(BIOKGEFFNAA: true)) && OIFCIKGLCJB.DeselectAction(JIIGOACEIKL))
		{
			SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
			OIFCIKGLCJB = null;
			return true;
		}
		return false;
	}

	public void AMJEBKHAEGG()
	{
		if ((Object)(object)BuzzNPC.CNDNOECMKME() != (Object)null)
		{
			BuzzNPC.KGPJPILAHDE().inBuild = true;
			BuzzNPC.NEFIEJALANL().busy = true;
		}
	}

	public static FarmConstructionManager OMEPPDMCFAO()
	{
		return instance;
	}

	public static void AddBuilding(FarmBuilding MAAFFAMLKKG)
	{
		instance.allBuildings.Add(MAAFFAMLKKG);
	}

	public static Barn CBDFNEMIAPM()
	{
		HOFCEDEHDPA();
		for (int i = 0; i < instance.completedBuildings.Count; i += 0)
		{
			if (instance.completedBuildings[i] is Barn result)
			{
				return result;
			}
		}
		return null;
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void StartMoveBuilding(Placeable DIANGLDOOOM)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		OIFCIKGLCJB = DIANGLDOOOM;
		SelectObject.GetPlayer(JIIGOACEIKL).SelectPlaceable(OIFCIKGLCJB);
		OIFCIKGLCJB.SetMouseOffset(Vector3.zero);
		if (OnlineManager.ClientOnline())
		{
			OIFCIKGLCJB.StartMoving(1, PHJILIBHABG: false, GFNHAMCPEAK: true);
		}
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			CursorManager.GetPlayer(JIIGOACEIKL).CursorAppears();
			CursorManager.GetPlayer(JIIGOACEIKL).SetCursorPositionFromViewport(new Vector3(0.5f, 0.5f));
		}
		OIFCIKGLCJB.itemSpace.checkConstructionPositions = true;
		OIFCIKGLCJB.itemSpace.checkHerbs = false;
		FarmBuilding component = ((Component)OIFCIKGLCJB).GetComponent<FarmBuilding>();
		component.changeLayers.Change();
		instance.cameraTarget.SetCurrentBuilding(component);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("Game");
		UpdateVisual();
	}

	public static bool IsActived()
	{
		return instance.LNLJMCONDNE;
	}

	public static FarmConstructionManager GetInstance()
	{
		return instance;
	}

	public override void CancelChanges()
	{
	}

	public static List<FarmBuilding> GetCompletedBuildings()
	{
		return instance.completedBuildings;
	}

	private IEnumerator LNFPCGEBPKH(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait075;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
	}

	[SpecialName]
	private static int ACKIFIBCIFA()
	{
		return FarmConstructionUI.NAFIKJBIGAB();
	}

	public void UnblockBuzzInteractionWithDelay()
	{
		((MonoBehaviour)this).StartCoroutine(NJIMOFCNHCD());
	}

	public static HenHouse GetHenHouse()
	{
		HOFCEDEHDPA();
		for (int i = 0; i < instance.completedBuildings.Count; i++)
		{
			if (instance.completedBuildings[i] is HenHouse result)
			{
				return result;
			}
		}
		return null;
	}

	public void KNODEFFBLCD()
	{
		((MonoBehaviour)this).StartCoroutine(FMLIFGFCCHF());
	}
}
