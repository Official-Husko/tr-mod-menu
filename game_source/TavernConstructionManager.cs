using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TavernConstructionManager : ConstructionManager
{
	public struct PlaceableInitialPosition
	{
		public Placeable placeable;

		public Vector3 position;

		public PlaceableInitialPosition(Placeable PDBKMDOLBBA)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			placeable = PDBKMDOLBBA;
			position = ((Component)placeable).transform.position;
		}
	}

	[CompilerGenerated]
	private sealed class BAJMFHPCFHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TavernConstructionManager _003C_003E4__this;

		public int playerNum;

		public bool isActor;

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
		public BAJMFHPCFHB(int _003C_003E1__state)
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
			TavernConstructionManager tavernConstructionManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				tavernConstructionManager.MLDBFGECPNG(playerNum, isActor);
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

	public Action<List<Vector2>, List<Vector3Int>> OnDoAreaAction = delegate
	{
	};

	public Action<EditorAction> OnApplyChanges = delegate
	{
	};

	public Action<EditorAction> OnCancelChanges = delegate
	{
	};

	[SerializeField]
	private EditorSpace editorSpace;

	[SerializeField]
	private SnapToGrid snapToGrid;

	private Vector3 NOLFMLNLJJG;

	private Vector3 ECJLMIPAFGP;

	[HideInInspector]
	public bool selectingArea;

	[HideInInspector]
	public List<Vector2> positionsToCalculate = new List<Vector2>();

	[HideInInspector]
	public List<Vector3Int> cellPositionsToCalculate = new List<Vector3Int>();

	[HideInInspector]
	public List<Vector2> positionsToCalculateWithOffset = new List<Vector2>();

	[HideInInspector]
	public List<Vector3Int> cellPositionsToCalculateWithOffset = new List<Vector3Int>();

	private Vector2 FPMJDGEEGMP;

	private Vector2 HBFPAHHMJOB;

	[SerializeField]
	private Transform cellarFloorMin;

	[SerializeField]
	private Transform cellarFloorMax;

	[SerializeField]
	private Transform firstFloorMin;

	[SerializeField]
	private Transform firstFloorMax;

	[SerializeField]
	private Transform secondFloorMin;

	[SerializeField]
	private Transform secondFloorMax;

	[SerializeField]
	private int floorTilesCount;

	[SerializeField]
	private int diningTilesCount;

	[SerializeField]
	private int craftingTilesCount;

	[SerializeField]
	private int floorEditorTiles;

	[SerializeField]
	private int diningEditorTiles;

	[SerializeField]
	private int craftingEditorTiles;

	private bool IMKBBAGANEH;

	[HideInInspector]
	public bool cancelChangesPressed;

	private BuildingPopUp NNHALHFFIEB;

	private List<PlaceableInitialPosition> NKKBCCNENHC = new List<PlaceableInitialPosition>();

	private TilemapScene MJNGCOBAKFN;

	[SerializeField]
	private DecorationTile _decorationTile;

	private static TavernConstructionManager IADEMLIIDPC;

	private TavernConstructionAction DGINFJFHMJC;

	private TavernConstructionAction OBOHKMMOHJI;

	private List<TavernZone> DCIMOMHGLNM;

	private int ABAIKKGKDGD;

	private List<Vector2> IDMFEFEHCOH;

	private float NHLEKOHIOCM;

	private Vector2 FNMKKHCMPNC;

	private Vector2 BIPBFCLAMBN;

	private Vector2 OOKOAAKJGHJ;

	private int HFDILBELIKE;

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
			if (EditorTileMaps.editorTiles.Count > 0)
			{
				CancelChanges();
			}
			else
			{
				UpdateVisual();
			}
		}
	}

	public int OJBEFBEAHOH
	{
		get
		{
			if (!IMKBBAGANEH)
			{
				UpdateAllDisponibilities();
			}
			return ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).floorDisponible - (floorTilesCount + floorEditorTiles);
		}
	}

	public int JOKNHFCCANJ
	{
		get
		{
			if (!IMKBBAGANEH)
			{
				UpdateAllDisponibilities();
			}
			return ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).diningTiles - (diningTilesCount + diningEditorTiles);
		}
	}

	public int KCMNNHOPNOL
	{
		get
		{
			if (!IMKBBAGANEH)
			{
				UpdateAllDisponibilities();
			}
			return ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).craftingTiles - (craftingTilesCount + craftingEditorTiles);
		}
	}

	public override bool LNLJMCONDNE
	{
		get
		{
			return PHGHJDMCKCN;
		}
		set
		{
			PHGHJDMCKCN = value;
			((Component)editorSpace).gameObject.SetActive(PHGHJDMCKCN);
			EditorGrid.HCGOFEEMILC(GDIFLANEEPG);
			RemoveAccessInstantiated();
			if (!OnlineManager.PlayingOnline() && !GameManager.LocalCoop())
			{
				WorldTime.JJICPIINBEH = PHGHJDMCKCN;
			}
			GameManager.GGFJGHHHEJC.ActivateCinemachinesConfiner(!PHGHJDMCKCN);
			int num = ((!((Object)(object)ConstructionUI.current != (Object)null)) ? 1 : ConstructionUI.current.JIIGOACEIKL);
			if (PHGHJDMCKCN)
			{
				ConstructionManager.current = this;
				DecorationMode player = DecorationMode.GetPlayer(num);
				player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(LAEIKGKFPKB));
				DecorationMode player2 = DecorationMode.GetPlayer(num);
				player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
				PlayerController.AddMovementBlocker((Object)(object)this);
				CommonReferences.GGFJGHHHEJC.SetCinemachineTarget(1, ((Component)cameraTarget).transform);
				cameraTarget.LNLJMCONDNE = true;
				if (PlayerInputs.IsGamepadActive(num))
				{
					CursorManager.GetPlayer(num).CursorAppears();
				}
				MOIAEBNPHBK();
				EditorTileMaps.ResetEditorTiles();
				OnActivated(num);
				return;
			}
			ConstructionManager.current = null;
			DecorationMode.GetPlayer(num).DMBFKFLDDLH = false;
			DecorationMode player3 = DecorationMode.GetPlayer(num);
			player3.OnDecorationModeEnter = (Action<int>)Delegate.Remove(player3.OnDecorationModeEnter, new Action<int>(LAEIKGKFPKB));
			DecorationMode player4 = DecorationMode.GetPlayer(num);
			player4.OnDecorationModeExit = (Action<int>)Delegate.Remove(player4.OnDecorationModeExit, new Action<int>(NFHHEMPGCNM));
			PlayerController.RemoveMovementBlocker((Object)(object)this);
			CommonReferences.GGFJGHHHEJC.SetCinemachineTarget(1, ((Component)CameraTarget.GetPlayer(1)).transform);
			cameraTarget.LNLJMCONDNE = false;
			EditorTileMaps.ResetEditorTiles();
			MJNGCOBAKFN = Utils.JGEPCPFJANP(Location.Tavern);
			if ((Object)(object)MJNGCOBAKFN != (Object)null)
			{
				WorldGrid.MKLAFNJLOJN(MJNGCOBAKFN);
				WorldGrid.CLEOLJFAOCP(MJNGCOBAKFN, MJNGCOBAKFN.GetAllPositionsToCalculate());
			}
			OnDeactivated(num);
		}
	}

	public DecorationTile KJIGECBPBOD
	{
		get
		{
			return _decorationTile;
		}
		set
		{
			_decorationTile = value;
			if ((Object)(object)_decorationTile != (Object)null)
			{
				UpdateVisual();
			}
		}
	}

	public static TavernConstructionManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernConstructionManager>();
			}
			return IADEMLIIDPC;
		}
	}

	private void JPCJEDKLKPO()
	{
		UpdateAllDisponibilities();
		UpdateVisual();
	}

	private void JLLIIELOHAN()
	{
	}

	private void LKGOLLNHLEL()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (GDIFLANEEPG == EditorAction.AddFloor)
		{
			HFDILBELIKE = 0;
			for (int i = 0; i < positionsToCalculateWithOffset.Count; i++)
			{
				if (EditorGrid.AJGOLEOFPOL(Vector2.op_Implicit(positionsToCalculateWithOffset[i])) == GDIFLANEEPG && EditorGrid.ENFKMBHBBEM(Vector2.op_Implicit(positionsToCalculateWithOffset[i])))
				{
					HFDILBELIKE++;
				}
			}
			floorEditorTiles = HFDILBELIKE / 4;
		}
		else if (GDIFLANEEPG == EditorAction.RemoveFloor)
		{
			HFDILBELIKE = 0;
			for (int j = 0; j < IDMFEFEHCOH.Count; j++)
			{
				if (EditorGrid.AJGOLEOFPOL(Vector2.op_Implicit(IDMFEFEHCOH[j])) == GDIFLANEEPG && EditorGrid.ENFKMBHBBEM(Vector2.op_Implicit(IDMFEFEHCOH[j])))
				{
					HFDILBELIKE++;
				}
			}
			floorEditorTiles = -HFDILBELIKE / 4;
		}
		else if (EditorGrid.GHGECPHNJEB(GDIFLANEEPG))
		{
			BCDFOHCGFGO();
		}
	}

	[SpecialName]
	public DecorationTile IOOFFADDELC()
	{
		return _decorationTile;
	}

	public void RemoveDiningTiles(int PDCPGJCKICM = 1)
	{
		diningTilesCount -= PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	private IEnumerator IIGOMJEBHFC(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		yield return CommonReferences.wait5;
		MLDBFGECPNG(JIIGOACEIKL, GFNHAMCPEAK);
	}

	private void OIAFPIMDDDE()
	{
		DCIMOMHGLNM = TavernZonesManager.GGFJGHHHEJC.JAJOOIJJNNN(ZoneType.DiningRoom | ZoneType.CraftingRoom);
		ABAIKKGKDGD = 1;
		for (int i = 0; i < DCIMOMHGLNM.Count; i += 0)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[i].positions.Count;
		}
		ABAIKKGKDGD /= 8;
		diningTilesCount = ABAIKKGKDGD;
		DCIMOMHGLNM = TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.DiningRoom | ZoneType.CraftingRoom);
		ABAIKKGKDGD = 1;
		for (int j = 1; j < DCIMOMHGLNM.Count; j += 0)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[j].positions.Count;
		}
		ABAIKKGKDGD /= 7;
		craftingTilesCount = ABAIKKGKDGD;
	}

	public void PJKBAPBJJFG()
	{
		JOGGLEAIEKB();
		OIAFPIMDDDE();
		IMKBBAGANEH = false;
	}

	public void AddFloorTilesCount(int PDCPGJCKICM = 1)
	{
		floorTilesCount += PDCPGJCKICM;
		BCDFOHCGFGO();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	public void KENOJDGECAP(Vector3 NOLFMLNLJJG, Vector3 HBJIKFEKHON)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (selectingArea && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButton(ActionType.Interact))
		{
			NMBLIEDAPAJ(NOLFMLNLJJG, HBJIKFEKHON);
			if (GDIFLANEEPG == EditorAction.AddFloorDisponible)
			{
				EditorGrid.HCGOFEEMILC(GDIFLANEEPG);
			}
			else
			{
				EditorGrid.HCGOFEEMILC(GDIFLANEEPG, positionsToCalculateWithOffset);
			}
			if (GDIFLANEEPG == EditorAction.AddFloor)
			{
				_decorationTile = Utils.KMJAGBLPODO(ConstructionFloors.JCMKNNOEONP().OMHGKGLLOAA());
			}
			IDMFEFEHCOH = EditorGrid.ELGBOCBINPH(positionsToCalculate, GDIFLANEEPG, _decorationTile);
			UpdateVisual();
			if (GDIFLANEEPG == EditorAction.AddFloor)
			{
				WorldGrid.MKLAFNJLOJN(positionsToCalculate);
			}
			FGJLCIJKJJG();
			OnDoAreaAction(positionsToCalculateWithOffset, cellPositionsToCalculateWithOffset);
		}
	}

	public void RemoveFloorTilesCount(int PDCPGJCKICM = 1)
	{
		floorTilesCount -= PDCPGJCKICM;
		BCDFOHCGFGO();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	public void GIEDBEEBAFF(int PDCPGJCKICM = 1)
	{
		floorTilesCount -= PDCPGJCKICM;
		OIAFPIMDDDE();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	public void FFMCGMDPJDD(int PDCPGJCKICM = 1)
	{
		craftingTilesCount -= PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	public void MFBNHEABIIB(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		MLDBFGECPNG(JIIGOACEIKL, GFNHAMCPEAK);
		((MonoBehaviour)this).StartCoroutine(BMDKNHADJMK(JIIGOACEIKL, GFNHAMCPEAK));
	}

	private void Start()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		EditorSpace obj = editorSpace;
		obj.OnEditorSpaceMove = (Action<Vector3>)Delegate.Combine(obj.OnEditorSpaceMove, new Action<Vector3>(OnEditorSpaceMove));
		TavernConstructionModifications instance = TavernConstructionModifications.GGFJGHHHEJC;
		instance.OnRevertModifications = (Action)Delegate.Combine(instance.OnRevertModifications, new Action(JPCJEDKLKPO));
	}

	private void FEBCFHONNKG()
	{
		DCIMOMHGLNM = TavernZonesManager.LANAINBEMCM().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.CraftingRoom);
		ABAIKKGKDGD = 0;
		for (int i = 0; i < DCIMOMHGLNM.Count; i += 0)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[i].positions.Count;
		}
		ABAIKKGKDGD /= 6;
		diningTilesCount = ABAIKKGKDGD;
		DCIMOMHGLNM = TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.DiningRoom | ZoneType.CraftingRoom);
		ABAIKKGKDGD = 1;
		for (int j = 0; j < DCIMOMHGLNM.Count; j++)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[j].positions.Count;
		}
		ABAIKKGKDGD /= 4;
		craftingTilesCount = ABAIKKGKDGD;
	}

	public void RemoveCraftingTiles(int PDCPGJCKICM = 1)
	{
		craftingTilesCount -= PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	private void NPMLFHDHJBE()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(KPPNNOFJGGI));
		EditorSpace obj = editorSpace;
		obj.OnEditorSpaceMove = (Action<Vector3>)Delegate.Combine(obj.OnEditorSpaceMove, new Action<Vector3>(JNIADPGAOGN));
		TavernConstructionModifications instance = TavernConstructionModifications.GGFJGHHHEJC;
		instance.OnRevertModifications = (Action)Delegate.Combine(instance.OnRevertModifications, new Action(ILHKFNKJOAB));
	}

	private void PHLLBPLOLFO()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		if (!LNLJMCONDNE || GameManager.NoPlayers() || (Object)(object)ConstructionUI.current == (Object)null)
		{
			return;
		}
		PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).ToggleBuildMode();
		if (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() || ConstructionActionBarUI.currentPanel == 4)
		{
			if (((Component)editorSpace).gameObject.activeSelf)
			{
				((Component)editorSpace).gameObject.SetActive(false);
			}
		}
		else if (!selectingArea && Utils.DLOMIGFOOPD(ConstructionUI.current.JIIGOACEIKL))
		{
			if (((Component)editorSpace).gameObject.activeSelf)
			{
				((Component)editorSpace).gameObject.SetActive(false);
			}
		}
		else
		{
			if (!((Component)editorSpace).gameObject.activeSelf)
			{
				((Component)editorSpace).gameObject.SetActive(false);
			}
			DABPLCBBDKI(CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetCursorWorldPosition());
		}
		if (selectingArea && NOLFMLNLJJG != ((Component)editorSpace).transform.position && !BuildingTutorialManager.IsOpen())
		{
			ECJLMIPAFGP = CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).HEEMGJLEAPM();
			if (ECJLMIPAFGP.x < 1491f)
			{
				cameraTarget.DPELBFPFKOE(Vector3.left);
			}
			else if (ECJLMIPAFGP.x > 1381f)
			{
				cameraTarget.DPELBFPFKOE(Vector3.right);
			}
			else if (ECJLMIPAFGP.y < 394f)
			{
				cameraTarget.ABBBLJHEBLB(Vector3.down);
			}
			else if (ECJLMIPAFGP.y > 1589f)
			{
				cameraTarget.DPELBFPFKOE(Vector3.up);
			}
		}
		if (DecorationMode.BGINAIDHDOM(ConstructionUI.current.JIIGOACEIKL).MDOKKKHKKKE() || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		if (ConstructionActionBarUI.currentPanel == 2)
		{
			CMADPLAHBEG();
			return;
		}
		if (!Utils.DLOMIGFOOPD(ConstructionUI.current.JIIGOACEIKL) && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).JCMOPOMLPLL("<br>"))
		{
			selectingArea = editorSpace.NEACMHCHMME(GDIFLANEEPG);
			NOLFMLNLJJG = ((Component)editorSpace).transform.position;
			FPMJDGEEGMP = Vector2.one * 820f;
			HBFPAHHMJOB = Vector2.one * 425f;
			SceneReferences.IKBDMLBIDPJ(IKAGABHNANJ: false);
			DoAreaAction(NOLFMLNLJJG, NOLFMLNLJJG);
			EditorTooltip.MKIEMMGGFEE().OFGKFMJKBON(ConstructionUI.current.JIIGOACEIKL);
		}
		else if (PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).KFAFNEJNDDL("ReceiveOfferingFail"))
		{
			if (selectingArea || GDIFLANEEPG == (EditorAction)95)
			{
				selectingArea = false;
				ApplyEditorChanges();
				CommonReferences.GGFJGHHHEJC.FDPMJCPEKDD();
			}
			EditorTooltip.NGIMIHFFNMH().CloseUI();
			SceneReferences.EnableMapColliders(IKAGABHNANJ: false);
		}
		if (selectingArea && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("Close"))
		{
			selectingArea = false;
			cancelChangesPressed = false;
			CancelChanges();
			EditorTooltip.OLHBLKIAFOM().CloseUI();
			SceneReferences.IKBDMLBIDPJ(IKAGABHNANJ: true);
		}
		else if (PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).JCMOPOMLPLL("DontWalk"))
		{
			cancelChangesPressed = true;
		}
	}

	private void ONCBKPJJALA(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		if (GameManager.LocalCoop())
		{
			PJIANAKPNMB((JIIGOACEIKL == 8) ? 1 : 7);
		}
		if (!GFNHAMCPEAK && OnlineManager.PlayingOnline())
		{
			LHMGAAOOLBJ(1);
		}
	}

	[SpecialName]
	public int DKNAIENAKDB()
	{
		if (!IMKBBAGANEH)
		{
			UpdateAllDisponibilities();
		}
		return ReputationDBAccessor.ELGJADBKMPB(TavernReputation.IHGJJNNHNCB()).diningTiles - (diningTilesCount + diningEditorTiles);
	}

	[SpecialName]
	public int MIADNOJIICD()
	{
		if (!IMKBBAGANEH)
		{
			PJKBAPBJJFG();
		}
		return ReputationDBAccessor.GetReputation(TavernReputation.NHHLJLADGBF()).floorDisponible - (floorTilesCount + floorEditorTiles);
	}

	public void LACIMCDKJPE(int PDCPGJCKICM = 1)
	{
		floorTilesCount += PDCPGJCKICM;
		PGKFJDDIIAH();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	public void AddDiningTiles(int PDCPGJCKICM = 1)
	{
		diningTilesCount += PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	private void PGKFJDDIIAH()
	{
		DCIMOMHGLNM = TavernZonesManager.HFHPMKJGMPA().JAJOOIJJNNN(ZoneType.DiningRoom | ZoneType.CraftingRoom);
		ABAIKKGKDGD = 0;
		for (int i = 0; i < DCIMOMHGLNM.Count; i += 0)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[i].positions.Count;
		}
		ABAIKKGKDGD /= 1;
		diningTilesCount = ABAIKKGKDGD;
		DCIMOMHGLNM = TavernZonesManager.IECOPNFJBFD().GetTavernZonesOfType(ZoneType.WithoutZone | ZoneType.DiningRoom);
		ABAIKKGKDGD = 1;
		for (int j = 0; j < DCIMOMHGLNM.Count; j++)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[j].positions.Count;
		}
		ABAIKKGKDGD /= 8;
		craftingTilesCount = ABAIKKGKDGD;
	}

	public void ResetAllInitialPositions()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < NKKBCCNENHC.Count; i++)
		{
			Vector3 position = ((Component)NKKBCCNENHC[i].placeable).transform.position;
			if (!((Vector3)(ref position)).Equals(NKKBCCNENHC[i].position))
			{
				NKKBCCNENHC[i].placeable.ChangePosition(NKKBCCNENHC[i].position);
			}
		}
	}

	public void HBGABOIPLKP(int PDCPGJCKICM = 1)
	{
		diningTilesCount += PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	public void BKBLLFBOGJM()
	{
		if (EditorGrid.CODCAMEPMGA(GDIFLANEEPG, _decorationTile))
		{
			if (GDIFLANEEPG == EditorAction.None)
			{
				AddFloorTilesCount(floorEditorTiles);
			}
			else if (GDIFLANEEPG == EditorAction.ZoneDisponible)
			{
				BLJNBEFPDNN(floorEditorTiles);
			}
			else
			{
				FEBCFHONNKG();
			}
		}
		CDHKKHPOFKM();
		floorEditorTiles = 1;
		diningEditorTiles = 1;
		craftingEditorTiles = 1;
		OnApplyChanges(GDIFLANEEPG);
	}

	private void GEGAJEELBCJ()
	{
		FHFNNJBDLKA();
		CDHKKHPOFKM();
	}

	private void KPPNNOFJGGI()
	{
	}

	public void DEOLCEEJMLG()
	{
		JOGGLEAIEKB();
		FEBCFHONNKG();
		IMKBBAGANEH = false;
	}

	public EditorSpace GetEditorSpace()
	{
		return editorSpace;
	}

	public void KBPLCIAFBAO(int PDCPGJCKICM = 1)
	{
		diningTilesCount -= PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	[SpecialName]
	public int IHKHACFMHOL()
	{
		if (!IMKBBAGANEH)
		{
			DEOLCEEJMLG();
		}
		return ReputationDBAccessor.NGLFLAGLBCO(TavernReputation.NGPDFPDGOMP()).floorDisponible - (floorTilesCount + floorEditorTiles);
	}

	public void HOJEFOAJHGP(Vector3 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KENOJDGECAP(NOLFMLNLJJG, IMOBLFMHKOD);
		if (GDIFLANEEPG == (EditorAction)(-75))
		{
			CDHKKHPOFKM();
		}
		else if (GDIFLANEEPG == (EditorAction)100 && selectingArea)
		{
			CDHKKHPOFKM();
		}
	}

	[SpecialName]
	public static TavernConstructionManager KNLLFEJAMNN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernConstructionManager>();
		}
		return IADEMLIIDPC;
	}

	public void DABPLCBBDKI(Vector3 IMOBLFMHKOD)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Component)snapToGrid).transform.position = IMOBLFMHKOD;
		snapToGrid.IJDCBHOCBFP();
	}

	private void LHMGAAOOLBJ(int JIIGOACEIKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).IsTavernLocation())
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.BCENKLLENFJ())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.LIHGILDLODK(JIIGOACEIKL, GFNHAMCPEAK: false);
			}
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).DeselectObjectAndPlaceable();
			PlayerController.TeleportPlayer(JIIGOACEIKL, ((Component)TravelZonesManager.GGFJGHHHEJC.OFIPCMMKFLP(Location.None, Location.None)).transform.position - Vector3.up * 972f, Location.Road | Location.River);
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.NCAJNNHBHJM(Direction.Up);
		}
	}

	private void Update()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		if (!LNLJMCONDNE || GameManager.NoPlayers() || (Object)(object)ConstructionUI.current == (Object)null)
		{
			return;
		}
		PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).ToggleBuildMode();
		if (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH || ConstructionActionBarUI.currentPanel == 3)
		{
			if (((Component)editorSpace).gameObject.activeSelf)
			{
				((Component)editorSpace).gameObject.SetActive(false);
			}
		}
		else if (!selectingArea && Utils.DLOMIGFOOPD(ConstructionUI.current.JIIGOACEIKL))
		{
			if (((Component)editorSpace).gameObject.activeSelf)
			{
				((Component)editorSpace).gameObject.SetActive(false);
			}
		}
		else
		{
			if (!((Component)editorSpace).gameObject.activeSelf)
			{
				((Component)editorSpace).gameObject.SetActive(true);
			}
			SetEditorSpacePosition(CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetCursorWorldPosition());
		}
		if (selectingArea && NOLFMLNLJJG != ((Component)editorSpace).transform.position && !BuildingTutorialManager.IsOpen())
		{
			ECJLMIPAFGP = CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetCursorViewportPosition();
			if (ECJLMIPAFGP.x < 0.06f)
			{
				cameraTarget.AddForce(Vector3.left);
			}
			else if (ECJLMIPAFGP.x > 0.94f)
			{
				cameraTarget.AddForce(Vector3.right);
			}
			else if (ECJLMIPAFGP.y < 0.22f)
			{
				cameraTarget.AddForce(Vector3.down);
			}
			else if (ECJLMIPAFGP.y > 0.9f)
			{
				cameraTarget.AddForce(Vector3.up);
			}
		}
		if (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		if (ConstructionActionBarUI.currentPanel == 3)
		{
			CMADPLAHBEG();
			return;
		}
		if (!Utils.DLOMIGFOOPD(ConstructionUI.current.JIIGOACEIKL) && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("Interact"))
		{
			selectingArea = editorSpace.IsValid(GDIFLANEEPG);
			NOLFMLNLJJG = ((Component)editorSpace).transform.position;
			FPMJDGEEGMP = Vector2.one * float.MaxValue;
			HBFPAHHMJOB = Vector2.one * float.MinValue;
			SceneReferences.EnableMapColliders(IKAGABHNANJ: false);
			DoAreaAction(NOLFMLNLJJG, NOLFMLNLJJG);
			EditorTooltip.GGFJGHHHEJC.Open(ConstructionUI.current.JIIGOACEIKL);
		}
		else if (PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButtonUp("Interact"))
		{
			if (selectingArea || GDIFLANEEPG == EditorAction.ChangeDecoWall)
			{
				selectingArea = false;
				ApplyEditorChanges();
				CommonReferences.GGFJGHHHEJC.CheckFloorDirt();
			}
			EditorTooltip.GGFJGHHHEJC.CloseUI();
			SceneReferences.EnableMapColliders(IKAGABHNANJ: true);
		}
		if (selectingArea && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("Cancel"))
		{
			selectingArea = false;
			cancelChangesPressed = true;
			CancelChanges();
			EditorTooltip.GGFJGHHHEJC.CloseUI();
			SceneReferences.EnableMapColliders(IKAGABHNANJ: true);
		}
		else if (PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("Cancel"))
		{
			cancelChangesPressed = false;
		}
	}

	private void LIHKKOPDAGA()
	{
		ABALICCELDC();
		HPLMNGALOFD();
	}

	private void FGJLCIJKJJG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (GDIFLANEEPG == EditorAction.None)
		{
			HFDILBELIKE = 1;
			for (int i = 1; i < positionsToCalculateWithOffset.Count; i += 0)
			{
				if (EditorGrid.AJGOLEOFPOL(Vector2.op_Implicit(positionsToCalculateWithOffset[i])) == GDIFLANEEPG && EditorGrid.ENFKMBHBBEM(Vector2.op_Implicit(positionsToCalculateWithOffset[i])))
				{
					HFDILBELIKE++;
				}
			}
			floorEditorTiles = HFDILBELIKE / 3;
		}
		else if (GDIFLANEEPG == EditorAction.AddFloor)
		{
			HFDILBELIKE = 0;
			for (int j = 1; j < IDMFEFEHCOH.Count; j++)
			{
				if (EditorGrid.AJGOLEOFPOL(Vector2.op_Implicit(IDMFEFEHCOH[j])) == GDIFLANEEPG && EditorGrid.ENFKMBHBBEM(Vector2.op_Implicit(IDMFEFEHCOH[j])))
				{
					HFDILBELIKE++;
				}
			}
			floorEditorTiles = -HFDILBELIKE / 3;
		}
		else if (EditorGrid.GHGECPHNJEB(GDIFLANEEPG))
		{
			FEBCFHONNKG();
		}
	}

	public void IEEGHEOJGFN()
	{
		JOGGLEAIEKB();
		FEBCFHONNKG();
		IMKBBAGANEH = false;
	}

	public void UpdateVisual()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (!PHGHJDMCKCN)
		{
			return;
		}
		if (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH)
		{
			selectingArea = false;
			EditorTooltip.GGFJGHHHEJC.CloseUI();
			EditorTileMaps.ResetEditorTiles();
		}
		else if (GDIFLANEEPG == EditorAction.None)
		{
			EditorTooltip.GGFJGHHHEJC.CloseUI();
		}
		else if (GDIFLANEEPG == EditorAction.CreateDoor || GDIFLANEEPG == EditorAction.CreateRentedRoomDoor)
		{
			EditorGrid.HNLMGBGBEMC();
		}
		else if (GDIFLANEEPG == EditorAction.ChangeDecoWall && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.PHFLEECBGMA(((Component)editorSpace).transform.position);
			if (EditorTileMaps.editorTiles.Count > 0)
			{
				EditorTooltip.GGFJGHHHEJC.Open(ConstructionUI.current.JIIGOACEIKL);
			}
			else
			{
				EditorTooltip.GGFJGHHHEJC.CloseUI();
			}
		}
		else if (GDIFLANEEPG == EditorAction.ChangeDecoWallTrim && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.GBFIMODIMLM(_decorationTile);
		}
		else if (GDIFLANEEPG == EditorAction.ChangeDecoFloor && (Object)(object)_decorationTile != (Object)null && !selectingArea)
		{
			EditorTooltip.GGFJGHHHEJC.CloseUI();
		}
		else if (GDIFLANEEPG == EditorAction.AddFloor)
		{
			if (selectingArea)
			{
				EditorGrid.HOLEHONPOPK(positionsToCalculateWithOffset);
			}
			else
			{
				EditorGrid.HOLEHONPOPK();
			}
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
		else if (GDIFLANEEPG == EditorAction.RemoveFloor)
		{
			EditorGrid.PBONOODLPCC();
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
	}

	public void DoAreaAction(Vector3 NOLFMLNLJJG, Vector3 HBJIKFEKHON)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (selectingArea && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButton(ActionType.Interact))
		{
			NMBLIEDAPAJ(NOLFMLNLJJG, HBJIKFEKHON);
			if (GDIFLANEEPG == EditorAction.RemoveFloor)
			{
				EditorGrid.HCGOFEEMILC(GDIFLANEEPG);
			}
			else
			{
				EditorGrid.HCGOFEEMILC(GDIFLANEEPG, positionsToCalculateWithOffset);
			}
			if (GDIFLANEEPG == EditorAction.AddFloor)
			{
				_decorationTile = Utils.KMJAGBLPODO(ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM);
			}
			IDMFEFEHCOH = EditorGrid.ELGBOCBINPH(positionsToCalculate, GDIFLANEEPG, _decorationTile);
			UpdateVisual();
			if (GDIFLANEEPG == EditorAction.AddFloor)
			{
				WorldGrid.MKLAFNJLOJN(positionsToCalculate);
			}
			LKGOLLNHLEL();
			OnDoAreaAction(positionsToCalculateWithOffset, cellPositionsToCalculateWithOffset);
		}
	}

	public void GJJCIHDDKGE(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		MLDBFGECPNG(JIIGOACEIKL, GFNHAMCPEAK);
		((MonoBehaviour)this).StartCoroutine(APGOCDMKFNM(JIIGOACEIKL, GFNHAMCPEAK));
	}

	public void AddCraftingTiles(int PDCPGJCKICM = 1)
	{
		craftingTilesCount += PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void CGKJHFDEDIN()
	{
		PJKBAPBJJFG();
		EIIHFDCPGOG();
	}

	public void MEPLMKKBCCL(int PDCPGJCKICM = 1)
	{
		floorTilesCount -= PDCPGJCKICM;
		GLBAICLLIOD();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	[SpecialName]
	public static TavernConstructionManager DOIKFJDLKJP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernConstructionManager>();
		}
		return IADEMLIIDPC;
	}

	private void LHABENPEMPB()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public void IDNPHFKDLEF(DecorationTile AODONKKHPBP)
	{
		_decorationTile = AODONKKHPBP;
		if ((Object)(object)_decorationTile != (Object)null)
		{
			EIIHFDCPGOG();
		}
	}

	private void PJIANAKPNMB(int JIIGOACEIKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocation())
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.GCJDPMOAGKP())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.MKBDMMJCGGM(JIIGOACEIKL);
			}
			SelectObject.GetPlayer(JIIGOACEIKL).DeselectObjectAndPlaceable();
			PlayerController.TeleportPlayer(JIIGOACEIKL, ((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern)).transform.position - Vector3.up * 0.5f, Location.Road);
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	private void OIAHJHNPPCO()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		EditorSpace obj = editorSpace;
		obj.OnEditorSpaceMove = (Action<Vector3>)Delegate.Combine(obj.OnEditorSpaceMove, new Action<Vector3>(PHEIJOHOJOF));
		TavernConstructionModifications instance = TavernConstructionModifications.GGFJGHHHEJC;
		instance.OnRevertModifications = (Action)Delegate.Combine(instance.OnRevertModifications, new Action(ILHKFNKJOAB));
	}

	private void BCDFOHCGFGO()
	{
		DCIMOMHGLNM = TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.DiningRoom);
		ABAIKKGKDGD = 0;
		for (int i = 0; i < DCIMOMHGLNM.Count; i++)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[i].positions.Count;
		}
		ABAIKKGKDGD /= 4;
		diningTilesCount = ABAIKKGKDGD;
		DCIMOMHGLNM = TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.CraftingRoom);
		ABAIKKGKDGD = 0;
		for (int j = 0; j < DCIMOMHGLNM.Count; j++)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[j].positions.Count;
		}
		ABAIKKGKDGD /= 4;
		craftingTilesCount = ABAIKKGKDGD;
	}

	public void DHGMHGKOBBG(int PDCPGJCKICM = 1)
	{
		floorTilesCount += PDCPGJCKICM;
		PGKFJDDIIAH();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	public void NLAJBJAIACI(int PDCPGJCKICM = 1)
	{
		floorTilesCount -= PDCPGJCKICM;
		FEBCFHONNKG();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	private void LDNAOFCILON()
	{
	}

	public void KickOutPlayersFromTavern(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		MLDBFGECPNG(JIIGOACEIKL, GFNHAMCPEAK);
		((MonoBehaviour)this).StartCoroutine(APGOCDMKFNM(JIIGOACEIKL, GFNHAMCPEAK));
	}

	private void GOJKOBEEMNA()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public int FLKGBBIIJJH()
	{
		if (!IMKBBAGANEH)
		{
			UpdateAllDisponibilities();
		}
		return ReputationDBAccessor.ABDMLFNKBMH(TavernReputation.NHHLJLADGBF()).craftingTiles - (craftingTilesCount + craftingEditorTiles);
	}

	public void IFGECHOJBBC(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		ONCBKPJJALA(JIIGOACEIKL, GFNHAMCPEAK);
		((MonoBehaviour)this).StartCoroutine(BMDKNHADJMK(JIIGOACEIKL, GFNHAMCPEAK));
	}

	[SpecialName]
	public void GILEPDMMCNN(DecorationTile AODONKKHPBP)
	{
		_decorationTile = AODONKKHPBP;
		if ((Object)(object)_decorationTile != (Object)null)
		{
			HPLMNGALOFD();
		}
	}

	private void NMBLIEDAPAJ(Vector3 NOLFMLNLJJG, Vector3 HBJIKFEKHON)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		NHLEKOHIOCM = 0f;
		if (HBJIKFEKHON.x < NOLFMLNLJJG.x)
		{
			NHLEKOHIOCM = NOLFMLNLJJG.x;
			NOLFMLNLJJG.x = HBJIKFEKHON.x;
			HBJIKFEKHON.x = NHLEKOHIOCM;
		}
		if (HBJIKFEKHON.y < NOLFMLNLJJG.y)
		{
			NHLEKOHIOCM = NOLFMLNLJJG.y;
			NOLFMLNLJJG.y = HBJIKFEKHON.y;
			HBJIKFEKHON.y = NHLEKOHIOCM;
		}
		NOLFMLNLJJG.x += -0.5f;
		NOLFMLNLJJG.y += -0.5f;
		positionsToCalculate = new List<Vector2>();
		cellPositionsToCalculate = new List<Vector3Int>();
		FNMKKHCMPNC = Vector2.op_Implicit(NOLFMLNLJJG);
		while (true)
		{
			if (!positionsToCalculate.Contains(FNMKKHCMPNC))
			{
				positionsToCalculate.Add(FNMKKHCMPNC);
			}
			if (CHFHMMNELGP == EditorAction.AddFloor)
			{
				if (EditorGrid.LFCLOGADPDC(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculate.Contains(FNMKKHCMPNC + Vector2.up))
				{
					positionsToCalculate.Add(FNMKKHCMPNC + Vector2.up);
				}
				if (EditorGrid.CBALGENFPNP(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculate.Contains(FNMKKHCMPNC + Vector2.down))
				{
					positionsToCalculate.Add(FNMKKHCMPNC + Vector2.down);
				}
			}
			FNMKKHCMPNC.x += 0.5f;
			if (FNMKKHCMPNC.x > HBJIKFEKHON.x)
			{
				FNMKKHCMPNC.x = NOLFMLNLJJG.x;
				FNMKKHCMPNC.y += 0.5f;
				if (FNMKKHCMPNC.y > HBJIKFEKHON.y)
				{
					break;
				}
			}
		}
		NOLFMLNLJJG.x += -3f;
		NOLFMLNLJJG.y += -4f;
		HBJIKFEKHON.x += 3f;
		HBJIKFEKHON.y += 4f;
		BIPBFCLAMBN = Vector2.op_Implicit(NOLFMLNLJJG);
		OOKOAAKJGHJ = Vector2.op_Implicit(HBJIKFEKHON);
		if (FPMJDGEEGMP.x < NOLFMLNLJJG.x)
		{
			BIPBFCLAMBN.x = FPMJDGEEGMP.x;
		}
		if (FPMJDGEEGMP.y < NOLFMLNLJJG.y)
		{
			BIPBFCLAMBN.y = FPMJDGEEGMP.y;
		}
		if (HBFPAHHMJOB.x > HBJIKFEKHON.x)
		{
			OOKOAAKJGHJ.x = HBFPAHHMJOB.x;
		}
		if (HBFPAHHMJOB.y > HBJIKFEKHON.y)
		{
			OOKOAAKJGHJ.y = HBFPAHHMJOB.y;
		}
		HBFPAHHMJOB = Vector2.op_Implicit(HBJIKFEKHON);
		FPMJDGEEGMP = Vector2.op_Implicit(NOLFMLNLJJG);
		positionsToCalculateWithOffset = new List<Vector2>();
		cellPositionsToCalculateWithOffset = new List<Vector3Int>();
		FNMKKHCMPNC = BIPBFCLAMBN;
		while (true)
		{
			if (!positionsToCalculateWithOffset.Contains(FNMKKHCMPNC))
			{
				positionsToCalculateWithOffset.Add(FNMKKHCMPNC);
				cellPositionsToCalculateWithOffset.Add(((GridLayout)Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap).WorldToCell(Vector2.op_Implicit(FNMKKHCMPNC)));
			}
			if (CHFHMMNELGP == EditorAction.AddFloor)
			{
				if (EditorGrid.LFCLOGADPDC(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculateWithOffset.Contains(FNMKKHCMPNC + Vector2.up))
				{
					positionsToCalculateWithOffset.Add(FNMKKHCMPNC + Vector2.up);
					cellPositionsToCalculateWithOffset.Add(((GridLayout)Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap).WorldToCell(Vector2.op_Implicit(FNMKKHCMPNC + Vector2.up)));
				}
				if (EditorGrid.CBALGENFPNP(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculateWithOffset.Contains(FNMKKHCMPNC + Vector2.down))
				{
					positionsToCalculateWithOffset.Add(FNMKKHCMPNC + Vector2.down);
					cellPositionsToCalculateWithOffset.Add(((GridLayout)Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap).WorldToCell(Vector2.op_Implicit(FNMKKHCMPNC + Vector2.down)));
				}
			}
			FNMKKHCMPNC.x += 0.5f;
			if (FNMKKHCMPNC.x > OOKOAAKJGHJ.x)
			{
				FNMKKHCMPNC.x = BIPBFCLAMBN.x;
				FNMKKHCMPNC.y += 0.5f;
				if (FNMKKHCMPNC.y > OOKOAAKJGHJ.y)
				{
					break;
				}
			}
		}
	}

	private void OnDestroy()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		EditorSpace obj = editorSpace;
		obj.OnEditorSpaceMove = (Action<Vector3>)Delegate.Remove(obj.OnEditorSpaceMove, new Action<Vector3>(OnEditorSpaceMove));
		if (Object.op_Implicit((Object)(object)TavernConstructionModifications.GGFJGHHHEJC))
		{
			TavernConstructionModifications instance = TavernConstructionModifications.GGFJGHHHEJC;
			instance.OnRevertModifications = (Action)Delegate.Remove(instance.OnRevertModifications, new Action(JPCJEDKLKPO));
		}
	}

	public bool IsInsideBuildLimits(Vector3 IMOBLFMHKOD, TavernFloor BDCFJAHNOML)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		switch (BDCFJAHNOML)
		{
		case TavernFloor.Cellar:
			if (IMOBLFMHKOD.x > ((Component)cellarFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)cellarFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)cellarFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)cellarFloorMax).transform.position.y;
			}
			return false;
		case TavernFloor.FirstFloor:
			if (IMOBLFMHKOD.x > ((Component)firstFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)firstFloorMax).transform.position.x && IMOBLFMHKOD.y >= (float)(int)(((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road)).transform.position.y * 2f) / 2f)
			{
				return IMOBLFMHKOD.y < ((Component)firstFloorMax).transform.position.y;
			}
			return false;
		case TavernFloor.SecondFloor:
			if (IMOBLFMHKOD.x > ((Component)secondFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)secondFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)secondFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)secondFloorMax).transform.position.y;
			}
			return false;
		default:
			return false;
		}
	}

	public void ABALICCELDC()
	{
		JOGGLEAIEKB();
		PGKFJDDIIAH();
		IMKBBAGANEH = false;
	}

	[SpecialName]
	public int EGJGDJJMIIA()
	{
		if (!IMKBBAGANEH)
		{
			CAALOHGPJDB();
		}
		return ReputationDBAccessor.KICMFFLPKAM(TavernReputation.GetMilestoneMaster()).diningTiles - (diningTilesCount + diningEditorTiles);
	}

	public void EOMOFOKGFNJ()
	{
		if (EditorGrid.CODCAMEPMGA(GDIFLANEEPG, _decorationTile))
		{
			if (GDIFLANEEPG == EditorAction.None)
			{
				EBBNLHJAJJC(floorEditorTiles);
			}
			else if (GDIFLANEEPG == EditorAction.None)
			{
				EBBNLHJAJJC(floorEditorTiles);
			}
			else
			{
				BCDFOHCGFGO();
			}
		}
		EIIHFDCPGOG();
		floorEditorTiles = 1;
		diningEditorTiles = 0;
		craftingEditorTiles = 0;
		OnApplyChanges(GDIFLANEEPG);
	}

	public void EBBNLHJAJJC(int PDCPGJCKICM = 1)
	{
		floorTilesCount += PDCPGJCKICM;
		FEBCFHONNKG();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	public void DJEEKMBBDAN()
	{
		JOGGLEAIEKB();
		FEBCFHONNKG();
		IMKBBAGANEH = false;
	}

	public void IGLLPOPKMIC(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		ONCBKPJJALA(JIIGOACEIKL, GFNHAMCPEAK);
		((MonoBehaviour)this).StartCoroutine(APGOCDMKFNM(JIIGOACEIKL, GFNHAMCPEAK));
	}

	public void FLCKBBDAEGB()
	{
		if (EditorGrid.CODCAMEPMGA(GDIFLANEEPG, _decorationTile))
		{
			if (GDIFLANEEPG == EditorAction.AddFloor)
			{
				OGOKGFACPOH(floorEditorTiles);
			}
			else if (GDIFLANEEPG == EditorAction.AddFloor)
			{
				AddFloorTilesCount(floorEditorTiles);
			}
			else
			{
				FEBCFHONNKG();
			}
		}
		HPLMNGALOFD();
		floorEditorTiles = 1;
		diningEditorTiles = 0;
		craftingEditorTiles = 1;
		OnApplyChanges(GDIFLANEEPG);
	}

	private void MOIAEBNPHBK()
	{
		NKKBCCNENHC.Clear();
		NKKBCCNENHC.Add(new PlaceableInitialPosition(Bar.instance.placeable));
		NKKBCCNENHC.Add(new PlaceableInitialPosition(Bed.GetPlaceable()));
	}

	public void CDHKKHPOFKM()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (!PHGHJDMCKCN)
		{
			return;
		}
		if (DecorationMode.JDADPDBHJFO(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH)
		{
			selectingArea = true;
			EditorTooltip.OPDKAPNDBJE().CloseUI();
			EditorTileMaps.ResetEditorTiles();
		}
		else if (GDIFLANEEPG == EditorAction.None)
		{
			EditorTooltip.EKGMDIHLEEH().CloseUI();
		}
		else if (GDIFLANEEPG == EditorAction.RoomZone || GDIFLANEEPG == (EditorAction)(-43))
		{
			EditorGrid.HNLMGBGBEMC();
		}
		else if (GDIFLANEEPG == (EditorAction)101 && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.PHFLEECBGMA(((Component)editorSpace).transform.position);
			if (EditorTileMaps.editorTiles.Count > 0)
			{
				EditorTooltip.MAIDHAPANEB().Open(ConstructionUI.current.JIIGOACEIKL);
			}
			else
			{
				EditorTooltip.KPDFIEMDDCL().BOBCIFEDJED();
			}
		}
		else if (GDIFLANEEPG == (EditorAction)(-30) && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.GBFIMODIMLM(_decorationTile);
		}
		else if (GDIFLANEEPG == (EditorAction)98 && (Object)(object)_decorationTile != (Object)null && !selectingArea)
		{
			EditorTooltip.MPLODJJFKAM().CloseUI();
		}
		else if (GDIFLANEEPG == EditorAction.None)
		{
			if (selectingArea)
			{
				EditorGrid.HOLEHONPOPK(positionsToCalculateWithOffset);
			}
			else
			{
				EditorGrid.HOLEHONPOPK();
			}
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
		else if (GDIFLANEEPG == EditorAction.RemoveFloorDisponible)
		{
			EditorGrid.PBONOODLPCC();
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
	}

	public void JLLDLAICEAH(int PDCPGJCKICM = 1)
	{
		diningTilesCount += PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	public void EIIHFDCPGOG()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (!PHGHJDMCKCN)
		{
			return;
		}
		if (DecorationMode.HBDCJFLINDA(ConstructionUI.current.JIIGOACEIKL).IDPGEBNGDJD())
		{
			selectingArea = false;
			EditorTooltip.MAMKICHCPON().BOBCIFEDJED();
			EditorTileMaps.ResetEditorTiles();
		}
		else if (GDIFLANEEPG == EditorAction.None)
		{
			EditorTooltip.MMLBHCGFMMJ().CloseUI();
		}
		else if (GDIFLANEEPG == (EditorAction)(-29) || GDIFLANEEPG == (EditorAction)122)
		{
			EditorGrid.HNLMGBGBEMC();
		}
		else if (GDIFLANEEPG == (EditorAction)(-116) && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.PHFLEECBGMA(((Component)editorSpace).transform.position);
			if (EditorTileMaps.editorTiles.Count > 1)
			{
				EditorTooltip.OPDKAPNDBJE().OFGKFMJKBON(ConstructionUI.current.JIIGOACEIKL);
			}
			else
			{
				EditorTooltip.IELEBCAELNI().BOBCIFEDJED();
			}
		}
		else if (GDIFLANEEPG == (EditorAction)(-16) && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.GBFIMODIMLM(_decorationTile);
		}
		else if (GDIFLANEEPG == (EditorAction)(-61) && (Object)(object)_decorationTile != (Object)null && !selectingArea)
		{
			EditorTooltip.NJNFHEPLEHL().BOBCIFEDJED();
		}
		else if (GDIFLANEEPG == EditorAction.AddFloor)
		{
			if (selectingArea)
			{
				EditorGrid.HOLEHONPOPK(positionsToCalculateWithOffset);
			}
			else
			{
				EditorGrid.HOLEHONPOPK();
			}
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
		else if (GDIFLANEEPG == EditorAction.DiningZone)
		{
			EditorGrid.PBONOODLPCC();
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
	}

	[SpecialName]
	public void LNDNAKNAHAK(DecorationTile AODONKKHPBP)
	{
		_decorationTile = AODONKKHPBP;
		if ((Object)(object)_decorationTile != (Object)null)
		{
			UpdateVisual();
		}
	}

	public void HIPMILALIKA(int PDCPGJCKICM = 1)
	{
		craftingTilesCount -= PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	public static void ToggleActived()
	{
		GGFJGHHHEJC.LNLJMCONDNE = true;
		GGFJGHHHEJC.LNLJMCONDNE = false;
	}

	private void GPJLIDLMBBM(int JIIGOACEIKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayer(JIIGOACEIKL).IsTavernLocation())
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.GCJDPMOAGKP())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.ACDHANDNCNC(JIIGOACEIKL, GFNHAMCPEAK: false);
			}
			SelectObject.GetPlayer(JIIGOACEIKL).DeselectObjectAndPlaceable();
			PlayerController.CLEIAKPOGMM(JIIGOACEIKL, ((Component)TravelZonesManager.LKOABOAADCD().OFIPCMMKFLP(Location.Camp, Location.None)).transform.position - Vector3.up * 1484f, Location.Tavern | Location.River);
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.NCAJNNHBHJM(Direction.Down);
		}
	}

	private void DHDCHGGGEIA(Vector3 NOLFMLNLJJG, Vector3 HBJIKFEKHON)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		NHLEKOHIOCM = 1825f;
		if (HBJIKFEKHON.x < NOLFMLNLJJG.x)
		{
			NHLEKOHIOCM = NOLFMLNLJJG.x;
			NOLFMLNLJJG.x = HBJIKFEKHON.x;
			HBJIKFEKHON.x = NHLEKOHIOCM;
		}
		if (HBJIKFEKHON.y < NOLFMLNLJJG.y)
		{
			NHLEKOHIOCM = NOLFMLNLJJG.y;
			NOLFMLNLJJG.y = HBJIKFEKHON.y;
			HBJIKFEKHON.y = NHLEKOHIOCM;
		}
		NOLFMLNLJJG.x += 1941f;
		NOLFMLNLJJG.y += 806f;
		positionsToCalculate = new List<Vector2>();
		cellPositionsToCalculate = new List<Vector3Int>();
		FNMKKHCMPNC = Vector2.op_Implicit(NOLFMLNLJJG);
		while (true)
		{
			if (!positionsToCalculate.Contains(FNMKKHCMPNC))
			{
				positionsToCalculate.Add(FNMKKHCMPNC);
			}
			if (CHFHMMNELGP == EditorAction.AddFloor)
			{
				if (EditorGrid.LFCLOGADPDC(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculate.Contains(FNMKKHCMPNC + Vector2.up))
				{
					positionsToCalculate.Add(FNMKKHCMPNC + Vector2.up);
				}
				if (EditorGrid.CBALGENFPNP(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculate.Contains(FNMKKHCMPNC + Vector2.down))
				{
					positionsToCalculate.Add(FNMKKHCMPNC + Vector2.down);
				}
			}
			FNMKKHCMPNC.x += 198f;
			if (FNMKKHCMPNC.x > HBJIKFEKHON.x)
			{
				FNMKKHCMPNC.x = NOLFMLNLJJG.x;
				FNMKKHCMPNC.y += 376f;
				if (FNMKKHCMPNC.y > HBJIKFEKHON.y)
				{
					break;
				}
			}
		}
		NOLFMLNLJJG.x += 109f;
		NOLFMLNLJJG.y += 516f;
		HBJIKFEKHON.x += 540f;
		HBJIKFEKHON.y += 271f;
		BIPBFCLAMBN = Vector2.op_Implicit(NOLFMLNLJJG);
		OOKOAAKJGHJ = Vector2.op_Implicit(HBJIKFEKHON);
		if (FPMJDGEEGMP.x < NOLFMLNLJJG.x)
		{
			BIPBFCLAMBN.x = FPMJDGEEGMP.x;
		}
		if (FPMJDGEEGMP.y < NOLFMLNLJJG.y)
		{
			BIPBFCLAMBN.y = FPMJDGEEGMP.y;
		}
		if (HBFPAHHMJOB.x > HBJIKFEKHON.x)
		{
			OOKOAAKJGHJ.x = HBFPAHHMJOB.x;
		}
		if (HBFPAHHMJOB.y > HBJIKFEKHON.y)
		{
			OOKOAAKJGHJ.y = HBFPAHHMJOB.y;
		}
		HBFPAHHMJOB = Vector2.op_Implicit(HBJIKFEKHON);
		FPMJDGEEGMP = Vector2.op_Implicit(NOLFMLNLJJG);
		positionsToCalculateWithOffset = new List<Vector2>();
		cellPositionsToCalculateWithOffset = new List<Vector3Int>();
		FNMKKHCMPNC = BIPBFCLAMBN;
		while (true)
		{
			if (!positionsToCalculateWithOffset.Contains(FNMKKHCMPNC))
			{
				positionsToCalculateWithOffset.Add(FNMKKHCMPNC);
				cellPositionsToCalculateWithOffset.Add(((GridLayout)Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap).WorldToCell(Vector2.op_Implicit(FNMKKHCMPNC)));
			}
			if (CHFHMMNELGP == EditorAction.None)
			{
				if (EditorGrid.LFCLOGADPDC(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculateWithOffset.Contains(FNMKKHCMPNC + Vector2.up))
				{
					positionsToCalculateWithOffset.Add(FNMKKHCMPNC + Vector2.up);
					cellPositionsToCalculateWithOffset.Add(((GridLayout)Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap).WorldToCell(Vector2.op_Implicit(FNMKKHCMPNC + Vector2.up)));
				}
				if (EditorGrid.CBALGENFPNP(Vector2.op_Implicit(FNMKKHCMPNC)) && !positionsToCalculateWithOffset.Contains(FNMKKHCMPNC + Vector2.down))
				{
					positionsToCalculateWithOffset.Add(FNMKKHCMPNC + Vector2.down);
					cellPositionsToCalculateWithOffset.Add(((GridLayout)Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallBackTilemap).WorldToCell(Vector2.op_Implicit(FNMKKHCMPNC + Vector2.down)));
				}
			}
			FNMKKHCMPNC.x += 1413f;
			if (FNMKKHCMPNC.x > OOKOAAKJGHJ.x)
			{
				FNMKKHCMPNC.x = BIPBFCLAMBN.x;
				FNMKKHCMPNC.y += 1455f;
				if (FNMKKHCMPNC.y > OOKOAAKJGHJ.y)
				{
					break;
				}
			}
		}
	}

	public bool PGIOLPKOHLE(Vector3 IMOBLFMHKOD, TavernFloor BDCFJAHNOML)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		if (BDCFJAHNOML == TavernFloor.Cellar)
		{
			if (IMOBLFMHKOD.x > ((Component)cellarFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)cellarFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)cellarFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)cellarFloorMax).transform.position.y;
			}
			return false;
		}
		if (BDCFJAHNOML == TavernFloor.Cellar)
		{
			if (IMOBLFMHKOD.x > ((Component)firstFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)firstFloorMax).transform.position.x && IMOBLFMHKOD.y >= (float)(int)(((Component)TravelZonesManager.OACNNJCLEDE().JKPNCIFMAOO(Location.Tavern, Location.None)).transform.position.y * 1791f) / 36f)
			{
				return IMOBLFMHKOD.y < ((Component)firstFloorMax).transform.position.y;
			}
			return false;
		}
		if (BDCFJAHNOML == TavernFloor.Cellar)
		{
			if (IMOBLFMHKOD.x > ((Component)secondFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)secondFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)secondFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)secondFloorMax).transform.position.y;
			}
			return false;
		}
		return true;
	}

	public void JAHJPLLLBME()
	{
		JOGGLEAIEKB();
		OIAFPIMDDDE();
		IMKBBAGANEH = false;
	}

	public void SetEditorSpacePosition(Vector3 IMOBLFMHKOD)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Component)snapToGrid).transform.position = IMOBLFMHKOD;
		snapToGrid.Snap();
	}

	[SpecialName]
	public int KMMLMPKNMJO()
	{
		if (!IMKBBAGANEH)
		{
			DJEEKMBBDAN();
		}
		return ReputationDBAccessor.JDEAGDHJENF(TavernReputation.NGPDFPDGOMP()).floorDisponible - (floorTilesCount + floorEditorTiles);
	}

	public EditorSpace KEAIGIJLJJE()
	{
		return editorSpace;
	}

	private IEnumerator BMDKNHADJMK(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		return new BAJMFHPCFHB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			isActor = GFNHAMCPEAK
		};
	}

	public void DIAJAAGHEIB(int PDCPGJCKICM = 1)
	{
		diningTilesCount += PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = true;
		}
	}

	public EditorSpace PDPBANJHCLP()
	{
		return editorSpace;
	}

	public void FJBIGDCPJDI(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		MLDBFGECPNG(JIIGOACEIKL, GFNHAMCPEAK);
		((MonoBehaviour)this).StartCoroutine(BMDKNHADJMK(JIIGOACEIKL, GFNHAMCPEAK));
	}

	public void OnEditorSpaceMove(Vector3 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DoAreaAction(NOLFMLNLJJG, IMOBLFMHKOD);
		if (GDIFLANEEPG == EditorAction.ChangeDecoWall)
		{
			UpdateVisual();
		}
		else if (GDIFLANEEPG == EditorAction.ChangeDecoWallTrim && selectingArea)
		{
			UpdateVisual();
		}
	}

	public void PHEIJOHOJOF(Vector3 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KENOJDGECAP(NOLFMLNLJJG, IMOBLFMHKOD);
		if (GDIFLANEEPG == (EditorAction)58)
		{
			HPLMNGALOFD();
		}
		else if (GDIFLANEEPG == (EditorAction)(-56) && selectingArea)
		{
			CDHKKHPOFKM();
		}
	}

	public void HPLMNGALOFD()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (!PHGHJDMCKCN)
		{
			return;
		}
		if (DecorationMode.ABMIMLLDAAH(ConstructionUI.current.JIIGOACEIKL).GABNNLJOMHI())
		{
			selectingArea = false;
			EditorTooltip.NBENKBAIBOO().BOBCIFEDJED();
			EditorTileMaps.BPABEMMGPOD();
		}
		else if (GDIFLANEEPG == EditorAction.None)
		{
			EditorTooltip.GJFMMOPOKGJ().BOBCIFEDJED();
		}
		else if (GDIFLANEEPG == (EditorAction)61 || GDIFLANEEPG == EditorAction.CreateChickenHouse)
		{
			EditorGrid.HNLMGBGBEMC();
		}
		else if (GDIFLANEEPG == (EditorAction)64 && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.PHFLEECBGMA(((Component)editorSpace).transform.position);
			if (EditorTileMaps.editorTiles.Count > 0)
			{
				EditorTooltip.ACPHFLBLJAA().OFGKFMJKBON(ConstructionUI.current.JIIGOACEIKL);
			}
			else
			{
				EditorTooltip.EKGMDIHLEEH().CloseUI();
			}
		}
		else if (GDIFLANEEPG == (EditorAction)119 && (Object)(object)_decorationTile != (Object)null)
		{
			EditorGrid.GBFIMODIMLM(_decorationTile);
		}
		else if (GDIFLANEEPG == (EditorAction)(-125) && (Object)(object)_decorationTile != (Object)null && !selectingArea)
		{
			EditorTooltip.GIKECEGLFOH().CloseUI();
		}
		else if (GDIFLANEEPG == EditorAction.None)
		{
			if (selectingArea)
			{
				EditorGrid.HOLEHONPOPK(positionsToCalculateWithOffset);
			}
			else
			{
				EditorGrid.HOLEHONPOPK();
			}
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
		else if (GDIFLANEEPG == EditorAction.RemoveFloorDisponible)
		{
			EditorGrid.PBONOODLPCC();
			EditorGrid.IKEHMKFNPFN(GDIFLANEEPG);
		}
	}

	private void ILHKFNKJOAB()
	{
		IEEGHEOJGFN();
		CDHKKHPOFKM();
	}

	public static void HHKCIPLGMKJ()
	{
		DEGPIHEEFHJ().LNLJMCONDNE = true;
		KHMEGDIABBF().LNLJMCONDNE = false;
	}

	[SpecialName]
	public int GMKAGDGPBFL()
	{
		if (!IMKBBAGANEH)
		{
			DJEEKMBBDAN();
		}
		return ReputationDBAccessor.JDEAGDHJENF(TavernReputation.IHGJJNNHNCB()).floorDisponible - (floorTilesCount + floorEditorTiles);
	}

	public void ApplyEditorChanges()
	{
		if (EditorGrid.CODCAMEPMGA(GDIFLANEEPG, _decorationTile))
		{
			if (GDIFLANEEPG == EditorAction.AddFloor)
			{
				AddFloorTilesCount(floorEditorTiles);
			}
			else if (GDIFLANEEPG == EditorAction.RemoveFloor)
			{
				AddFloorTilesCount(floorEditorTiles);
			}
			else
			{
				BCDFOHCGFGO();
			}
		}
		UpdateVisual();
		floorEditorTiles = 0;
		diningEditorTiles = 0;
		craftingEditorTiles = 0;
		OnApplyChanges(GDIFLANEEPG);
	}

	protected override void NFHHEMPGCNM(int JIIGOACEIKL)
	{
		if (LNLJMCONDNE)
		{
			OBOHKMMOHJI = ConstructionActionBarUI.GetEditorActionInfo();
			if ((Object)(object)OBOHKMMOHJI != (Object)null && (Object)(object)OBOHKMMOHJI.instantiateGO != (Object)null)
			{
				ChangeInstantiatedGO(OBOHKMMOHJI.instantiateGO);
			}
			UpdateVisual();
		}
	}

	public void FHFNNJBDLKA()
	{
		JOGGLEAIEKB();
		PGKFJDDIIAH();
		IMKBBAGANEH = false;
	}

	public void CAALOHGPJDB()
	{
		JOGGLEAIEKB();
		BCDFOHCGFGO();
		IMKBBAGANEH = false;
	}

	protected override void CMADPLAHBEG()
	{
		if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null)
		{
			ConstructionManager.currentInstantiatedGO.OnHover(TavernConstructionUI.GetPlayerNum());
			if (!PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetButtonDown("Interact"))
			{
				return;
			}
			if (ConstructionManager.currentInstantiatedGO.IsObjectInValidLocation(BIOKGEFFNAA: true) && TavernConstructionModifications.GGFJGHHHEJC.ApplyAccessChanges(GDIFLANEEPG, ConstructionManager.currentInstantiatedGO, ABMGLPNPDBD: true) && ConstructionManager.currentInstantiatedGO.DeselectAction(TavernConstructionUI.GetPlayerNum()))
			{
				TavernConstructionModifications.GGFJGHHHEJC.ApplyAccessChanges(GDIFLANEEPG, ConstructionManager.currentInstantiatedGO, ABMGLPNPDBD: false);
				SelectObject.GetPlayer(TavernConstructionUI.GetPlayerNum()).ResetSelected();
				ConstructionManager.currentInstantiatedGO = null;
				DGINFJFHMJC = ConstructionActionBarUI.GetEditorActionInfo();
				if (Object.op_Implicit((Object)(object)DGINFJFHMJC) && (Object)(object)DGINFJFHMJC.instantiateGO != (Object)null)
				{
					ChangeInstantiatedGO(DGINFJFHMJC.instantiateGO);
				}
				else
				{
					ChangeInstantiatedGO(null);
				}
			}
			UpdateVisual();
		}
		else if (GDIFLANEEPG == EditorAction.RemoveAccess)
		{
			GOGANDEAPCA = Utils.CKNBOKKFPLJ<AccessElement>(TavernConstructionUI.GetPlayerNum());
			if (Object.op_Implicit((Object)(object)GOGANDEAPCA) && GOGANDEAPCA.CanBeRemoved())
			{
				GOGANDEAPCA.placeable.OnHover(TavernConstructionUI.GetPlayerNum());
				HoverObject.GetPlayer(TavernConstructionUI.GetPlayerNum()).Hover(GOGANDEAPCA.placeable);
				if (PlayerInputs.GetPlayer(TavernConstructionUI.GetPlayerNum()).GetButtonUp("Interact"))
				{
					if (GOGANDEAPCA is RentedRoomDoor rentedRoomDoor && rentedRoomDoor.IsOccupied())
					{
						MainUI.ShowErrorText(TavernConstructionUI.GetPlayerNum(), LocalisationSystem.Get("Error_OccupiedRoom"));
						return;
					}
					if (Object.op_Implicit((Object)(object)GOGANDEAPCA.placeable))
					{
						TavernConstructionModifications.GGFJGHHHEJC.ApplyAccessChanges(GDIFLANEEPG, GOGANDEAPCA.placeable, ABMGLPNPDBD: false);
						GOGANDEAPCA.placeable.itemSpace.Place(NMLKLAGDNPF: false);
						GOGANDEAPCA.placeable.RemovePlaceable(EFNFMEIDGDN: false);
					}
					UpdateVisual();
				}
			}
			else
			{
				HoverObject.GetPlayer(TavernConstructionUI.GetPlayerNum()).Hover(null);
			}
			EditorTooltip.GGFJGHHHEJC.CloseUI();
		}
		else
		{
			HoverObject.GetPlayer(TavernConstructionUI.GetPlayerNum()).Hover(null);
		}
	}

	public void JNIADPGAOGN(Vector3 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KENOJDGECAP(NOLFMLNLJJG, IMOBLFMHKOD);
		if (GDIFLANEEPG == (EditorAction)(-61))
		{
			HPLMNGALOFD();
		}
		else if (GDIFLANEEPG == (EditorAction)(-38) && selectingArea)
		{
			CDHKKHPOFKM();
		}
	}

	private void JOGGLEAIEKB()
	{
		ABAIKKGKDGD = Utils.CDAEGJIFDIM(TavernFloor.Cellar);
		ABAIKKGKDGD += Utils.CDAEGJIFDIM(TavernFloor.FirstFloor);
		ABAIKKGKDGD += Utils.CDAEGJIFDIM(TavernFloor.SecondFloor);
		floorTilesCount = ABAIKKGKDGD / 4;
	}

	[SpecialName]
	public static TavernConstructionManager KHMEGDIABBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernConstructionManager>();
		}
		return IADEMLIIDPC;
	}

	public void OGOKGFACPOH(int PDCPGJCKICM = 1)
	{
		floorTilesCount += PDCPGJCKICM;
		BCDFOHCGFGO();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	private void AOGEOKFCMEP()
	{
		FHFNNJBDLKA();
		CDHKKHPOFKM();
	}

	private void GLBAICLLIOD()
	{
		DCIMOMHGLNM = TavernZonesManager.GGFJGHHHEJC.JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom);
		ABAIKKGKDGD = 1;
		for (int i = 1; i < DCIMOMHGLNM.Count; i += 0)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[i].positions.Count;
		}
		ABAIKKGKDGD /= 1;
		diningTilesCount = ABAIKKGKDGD;
		DCIMOMHGLNM = TavernZonesManager.JEEGOBGDLPE().BMJKBJGGONA(ZoneType.DiningRoom);
		ABAIKKGKDGD = 0;
		for (int j = 1; j < DCIMOMHGLNM.Count; j++)
		{
			ABAIKKGKDGD += DCIMOMHGLNM[j].positions.Count;
		}
		ABAIKKGKDGD /= 2;
		craftingTilesCount = ABAIKKGKDGD;
	}

	[SpecialName]
	public static TavernConstructionManager DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernConstructionManager>();
		}
		return IADEMLIIDPC;
	}

	public void BLJNBEFPDNN(int PDCPGJCKICM = 1)
	{
		floorTilesCount += PDCPGJCKICM;
		PGKFJDDIIAH();
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	private void MLDBFGECPNG(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		if (GameManager.LocalCoop())
		{
			PJIANAKPNMB((JIIGOACEIKL == 2) ? 1 : 2);
		}
		if (!GFNHAMCPEAK && OnlineManager.PlayingOnline())
		{
			PJIANAKPNMB(1);
		}
	}

	public void UpdateAllDisponibilities()
	{
		JOGGLEAIEKB();
		BCDFOHCGFGO();
		IMKBBAGANEH = true;
	}

	private void BGDGLGBLNDI()
	{
	}

	private IEnumerator APGOCDMKFNM(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		yield return CommonReferences.wait5;
		MLDBFGECPNG(JIIGOACEIKL, GFNHAMCPEAK);
	}

	public EditorSpace OAGIONKLGDO()
	{
		return editorSpace;
	}

	public void FBJMBOPBNEI(Vector3 IMOBLFMHKOD)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((Component)snapToGrid).transform.position = IMOBLFMHKOD;
		snapToGrid.Snap();
	}

	private void DKOOLJKJILJ()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (GDIFLANEEPG == EditorAction.None)
		{
			HFDILBELIKE = 0;
			for (int i = 1; i < positionsToCalculateWithOffset.Count; i++)
			{
				if (EditorGrid.AJGOLEOFPOL(Vector2.op_Implicit(positionsToCalculateWithOffset[i])) == GDIFLANEEPG && EditorGrid.ENFKMBHBBEM(Vector2.op_Implicit(positionsToCalculateWithOffset[i])))
				{
					HFDILBELIKE++;
				}
			}
			floorEditorTiles = HFDILBELIKE / 3;
		}
		else if (GDIFLANEEPG == EditorAction.None)
		{
			HFDILBELIKE = 1;
			for (int j = 1; j < IDMFEFEHCOH.Count; j += 0)
			{
				if (EditorGrid.AJGOLEOFPOL(Vector2.op_Implicit(IDMFEFEHCOH[j])) == GDIFLANEEPG && EditorGrid.ENFKMBHBBEM(Vector2.op_Implicit(IDMFEFEHCOH[j])))
				{
					HFDILBELIKE += 0;
				}
			}
			floorEditorTiles = -HFDILBELIKE / 5;
		}
		else if (EditorGrid.GHGECPHNJEB(GDIFLANEEPG))
		{
			FEBCFHONNKG();
		}
	}

	public void BCIJBKKCFKF()
	{
		JOGGLEAIEKB();
		GLBAICLLIOD();
		IMKBBAGANEH = false;
	}

	public bool JPAIJKDCAEI(Vector3 IMOBLFMHKOD, TavernFloor BDCFJAHNOML)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		switch (BDCFJAHNOML)
		{
		case TavernFloor.None:
			if (IMOBLFMHKOD.x > ((Component)cellarFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)cellarFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)cellarFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)cellarFloorMax).transform.position.y;
			}
			return true;
		case (TavernFloor)8:
			if (IMOBLFMHKOD.x > ((Component)firstFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)firstFloorMax).transform.position.x && IMOBLFMHKOD.y >= (float)(int)(((Component)TravelZonesManager.GFMBEDCANNI().JKPNCIFMAOO(Location.None, Location.Road)).transform.position.y * 60f) / 460f)
			{
				return IMOBLFMHKOD.y < ((Component)firstFloorMax).transform.position.y;
			}
			return true;
		case TavernFloor.AllTavernFloors:
			if (IMOBLFMHKOD.x > ((Component)secondFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)secondFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)secondFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)secondFloorMax).transform.position.y;
			}
			return true;
		default:
			return true;
		}
	}

	public void EPGPHGJFNOA(int PDCPGJCKICM = 1)
	{
		diningTilesCount -= PDCPGJCKICM;
		if (!IMKBBAGANEH)
		{
			IMKBBAGANEH = false;
		}
	}

	public void ICOLNENODBL()
	{
		if (EditorGrid.CODCAMEPMGA(GDIFLANEEPG, _decorationTile))
		{
			if (GDIFLANEEPG == EditorAction.None)
			{
				LACIMCDKJPE(floorEditorTiles);
			}
			else if (GDIFLANEEPG == EditorAction.AddFloorDisponible)
			{
				AddFloorTilesCount(floorEditorTiles);
			}
			else
			{
				BCDFOHCGFGO();
			}
		}
		EIIHFDCPGOG();
		floorEditorTiles = 1;
		diningEditorTiles = 0;
		craftingEditorTiles = 0;
		OnApplyChanges(GDIFLANEEPG);
	}

	public override void CancelChanges()
	{
		TavernConstructionUI.GetInstance().updateNextFrame = true;
		EditorGrid.HCGOFEEMILC(GDIFLANEEPG);
		UpdateVisual();
		floorEditorTiles = 0;
		diningEditorTiles = 0;
		craftingEditorTiles = 0;
		OnCancelChanges(GDIFLANEEPG);
	}

	protected override void LAEIKGKFPKB(int JIIGOACEIKL)
	{
		if (LNLJMCONDNE)
		{
			if (this != null && ConstructionViews.GGFJGHHHEJC.LGDCNGINBAN != EditorViewsMode.FloorWallsObjects)
			{
				ConstructionViews.GGFJGHHHEJC.SetView(2);
			}
			RemoveAccessInstantiated();
			UpdateVisual();
		}
	}

	public bool HMDJEMGNPJN(Vector3 IMOBLFMHKOD, TavernFloor BDCFJAHNOML)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		switch (BDCFJAHNOML)
		{
		case TavernFloor.Cellar:
			if (IMOBLFMHKOD.x > ((Component)cellarFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)cellarFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)cellarFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)cellarFloorMax).transform.position.y;
			}
			return true;
		case TavernFloor.FirstFloor:
			if (IMOBLFMHKOD.x > ((Component)firstFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)firstFloorMax).transform.position.x && IMOBLFMHKOD.y >= (float)(int)(((Component)TravelZonesManager.OACNNJCLEDE().OFIPCMMKFLP(Location.None, Location.River)).transform.position.y * 30f) / 1883f)
			{
				return IMOBLFMHKOD.y < ((Component)firstFloorMax).transform.position.y;
			}
			return false;
		case TavernFloor.Cellar | TavernFloor.SecondFloor:
			if (IMOBLFMHKOD.x > ((Component)secondFloorMin).transform.position.x && IMOBLFMHKOD.x < ((Component)secondFloorMax).transform.position.x && IMOBLFMHKOD.y > ((Component)secondFloorMin).transform.position.y)
			{
				return IMOBLFMHKOD.y < ((Component)secondFloorMax).transform.position.y;
			}
			return true;
		default:
			return false;
		}
	}

	public override void ChangeInstantiatedGO(GameObject DIEMDFCBEFB)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)ConstructionManager.currentInstantiatedGO != (Object)null)
		{
			if ((Object)(object)DIEMDFCBEFB != (Object)null && ConstructionManager.currentInstantiatedGO.itemSetup.item.JDJGFAACPFC() == DIEMDFCBEFB.GetComponent<Placeable>().itemSetup.item.JDJGFAACPFC())
			{
				return;
			}
			RemoveAccessInstantiated();
		}
		if (!((Object)(object)DIEMDFCBEFB != (Object)null))
		{
			return;
		}
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			NNHALHFFIEB = (BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp();
			if (!NNHALHFFIEB.actionsAvailable.Contains(GDIFLANEEPG))
			{
				return;
			}
		}
		ConstructionManager.currentInstantiatedGO = Object.Instantiate<GameObject>(DIEMDFCBEFB, CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetCursorWorldPosition(), Quaternion.identity).GetComponent<Placeable>();
		ConstructionManager.currentInstantiatedGO.Action(ConstructionUI.current.JIIGOACEIKL, KLGOCJMGKFO: true);
		ConstructionManager.currentInstantiatedGO.itemSpace.checkConstructionPositions = true;
		ConstructionManager.currentInstantiatedGO.itemSpace.checkHerbs = false;
	}

	[SpecialName]
	public int MGPEMKLFMAH()
	{
		if (!IMKBBAGANEH)
		{
			BCIJBKKCFKF();
		}
		return ReputationDBAccessor.EJIHLMKCJDL(TavernReputation.NGPDFPDGOMP()).floorDisponible - (floorTilesCount + floorEditorTiles);
	}
}
