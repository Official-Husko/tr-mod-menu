using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActionBarInventory : Container
{
	[CompilerGenerated]
	private sealed class DFKBOJFBDLM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActionBarInventory _003C_003E4__this;

		public int playerNum;

		public bool buttonDown;

		public bool checkPrefab;

		public bool slotClicked;

		public bool slotChanged;

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
		public DFKBOJFBDLM(int _003C_003E1__state)
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
			ActionBarInventory actionBarInventory = _003C_003E4__this;
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
				actionBarInventory.ActionSelectedItem(playerNum, buttonDown, checkPrefab, slotClicked, slotChanged);
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

	private static ActionBarInventory IADEMLIIDPC;

	private static ActionBarInventory BBINLIGKIPE;

	private static ActionBarInventory[] CFFBMLNPMJD = new ActionBarInventory[5];

	public Action<int, int> OnSelectionChanged = delegate
	{
	};

	public bool scrollingEnabled = true;

	private float AIIHEFHCNFB;

	private InputByProximity LFBNPHHABDK;

	private float CMGDCLIIONE;

	public bool onlineInstance;

	public int playerNum = 1;

	public bool autoDecoMode;

	private int GAANHLBHAKM;

	private List<MonoBehaviour> IILDLOOCPKN = new List<MonoBehaviour>();

	private Slot[] BLMADJJOAKA;

	private ScrollArea CEMHJDMCPLK;

	private bool HPDHIIIFIBF
	{
		get
		{
			if (PiratesGameManager.Playing)
			{
				return false;
			}
			if (FishCuttingGameManager.Playing)
			{
				return false;
			}
			if (BathhouseGameManager.Playing)
			{
				return false;
			}
			return IILDLOOCPKN.Count == 0;
		}
	}

	public int LIMCJONFMPN()
	{
		return GAANHLBHAKM;
	}

	private static ActionBarInventory ANLKPPNOONC(int JFNMCNCHMEO)
	{
		return CFFBMLNPMJD[JFNMCNCHMEO];
	}

	public void PCENBDCACKD(int NJNDJNGLDGK)
	{
		if (NJNDJNGLDGK != GAANHLBHAKM)
		{
			OnSelectionChanged(playerNum, NJNDJNGLDGK);
			GAANHLBHAKM = NJNDJNGLDGK;
			if (GetSelectedItemInstance() is ToolInstance toolInstance)
			{
				toolInstance.GMLNCJAOEOI(playerNum);
			}
		}
		else
		{
			GAANHLBHAKM = NJNDJNGLDGK;
		}
	}

	public ItemInstance MFDBJINDCAO()
	{
		if (slots[CMHNEHPIBDN()].itemInstance != null)
		{
			return slots[JDBAHDFLONL()].itemInstance;
		}
		return null;
	}

	public int DJPNPFGECBF()
	{
		return GAANHLBHAKM;
	}

	public Item GetSelectedItem()
	{
		if (slots[GetCurrentSlotSelected()] != null)
		{
			if (slots[GetCurrentSlotSelected()].itemInstance != null)
			{
				return slots[GetCurrentSlotSelected()].itemInstance.LHBPOPOIFLE();
			}
			return null;
		}
		return null;
	}

	public ItemInstance JHDFIPFOHDP()
	{
		if (slots[DOMHGEAFCAP()].itemInstance != null)
		{
			return slots[LIMCJONFMPN()].itemInstance;
		}
		return null;
	}

	private static ActionBarInventory FDPKLOPMNNJ(int JFNMCNCHMEO)
	{
		return CFFBMLNPMJD[JFNMCNCHMEO];
	}

	private static ActionBarInventory GNDKIDIANOL(int JFNMCNCHMEO)
	{
		return CFFBMLNPMJD[JFNMCNCHMEO];
	}

	public bool JMPHCKCNEFK(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (HPDHIIIFIBF && SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = MBOHNGNNCED();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return false;
			}
		}
		return false;
	}

	public int GetCurrentSlotSelected()
	{
		return GAANHLBHAKM;
	}

	public Slot DNEDPKCLAJF(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	public void SetCurrentSlotSelected(int NJNDJNGLDGK)
	{
		if (NJNDJNGLDGK != GAANHLBHAKM)
		{
			OnSelectionChanged(playerNum, NJNDJNGLDGK);
			GAANHLBHAKM = NJNDJNGLDGK;
			if (GetSelectedItemInstance() is ToolInstance toolInstance)
			{
				toolInstance.NFHHKCIBLDC(playerNum);
			}
		}
		else
		{
			GAANHLBHAKM = NJNDJNGLDGK;
		}
	}

	public ItemInstance GetSelectedItemInstance()
	{
		if (slots[GetCurrentSlotSelected()].itemInstance != null)
		{
			return slots[GetCurrentSlotSelected()].itemInstance;
		}
		return null;
	}

	public bool ANEDLALLPMD(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (GGLJBGHPAMN() && SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = KPFJCEMDJPE();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return true;
			}
		}
		return true;
	}

	public void CMILAEGGOOK(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	public static ActionBarInventory MHDKNEKDKII(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return OMJPAJJLMDA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return ANLKPPNOONC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Abandon quest?" + JFNMCNCHMEO));
		return null;
	}

	[SpecialName]
	private bool IMNBGNDBFDB()
	{
		if (PiratesGameManager.Playing)
		{
			return true;
		}
		if (FishCuttingGameManager.Playing)
		{
			return false;
		}
		if (BathhouseGameManager.Playing)
		{
			return false;
		}
		return IILDLOOCPKN.Count == 0;
	}

	public Slot MIPGHCNCOEL()
	{
		return slots[NLIEGDDKKIJ()];
	}

	private IActionable IAEDLCHIELP()
	{
		if (GetSelectedItem() is IActionable result)
		{
			return result;
		}
		if (BBBGBHPJOAG() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public Slot IKKLGIKJNNG()
	{
		return slots[JGJJDOHBEMJ()];
	}

	public Item FGGKCJDFNEK()
	{
		if (slots[OEGNHIHFBOL()] != null)
		{
			if (slots[JGJJDOHBEMJ()].itemInstance != null)
			{
				return slots[NLIEGDDKKIJ()].itemInstance.PHGLMBIEOMK();
			}
			return null;
		}
		return null;
	}

	public static ActionBarInventory IFGBDFBGAED(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return GNDKIDIANOL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return MHEFLBMGOAJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("BartenderDescription" + JFNMCNCHMEO));
		return null;
	}

	public void PJPLGNOJLNG(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	private IActionable APOHLHBNEOG()
	{
		if (GetSelectedItem() is IActionable result)
		{
			return result;
		}
		if (MFDBJINDCAO() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public void ECBINJJHNJG(int NJNDJNGLDGK)
	{
		if (NJNDJNGLDGK != GAANHLBHAKM)
		{
			OnSelectionChanged(playerNum, NJNDJNGLDGK);
			GAANHLBHAKM = NJNDJNGLDGK;
			if (MFDBJINDCAO() is ToolInstance toolInstance)
			{
				toolInstance.EIFFKPDDJJC(playerNum);
			}
		}
		else
		{
			GAANHLBHAKM = NJNDJNGLDGK;
		}
	}

	public static ActionBarInventory IPBEEBLCHHA(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return GNDKIDIANOL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return ANLKPPNOONC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 1)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("NinjaChallengeEvent/Lose" + JFNMCNCHMEO));
		return null;
	}

	private IActionable BAPPPBEHIGH()
	{
		if (GetSelectedItem() is IActionable result)
		{
			return result;
		}
		if (JHDFIPFOHDP() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public void RemoveAllActionBarBlockers()
	{
		IILDLOOCPKN.Clear();
	}

	private void OMFFMHDMPFM(int JIIGOACEIKL)
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN() || !GameActionBarUI.BGABEMMDDEH(JIIGOACEIKL).IsOpen())
		{
			return;
		}
		if (scrollingEnabled && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null)
		{
			AIIHEFHCNFB = 1977f;
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Unique id ", 1927f))
			{
				AIIHEFHCNFB = 1454f;
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Run", 1094f))
			{
				AIIHEFHCNFB = 982f;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
			{
				AIIHEFHCNFB = 131f;
			}
			if (AIIHEFHCNFB > 1149f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
				{
					CEMHJDMCPLK.MPNLJBBCCFE();
				}
				else if (HPDHIIIFIBF)
				{
					PHGOBJDNKPH(Utils.NMLNAGFLNMC(LIMCJONFMPN() + 0, GameManager.LocalCoop() ? 1 : 116));
				}
			}
			else if (AIIHEFHCNFB < 425f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.DNIAHANNGBP();
				}
				else if (IMNBGNDBFDB())
				{
					KCLLEEJKLOE(Utils.NMLNAGFLNMC(ECDLIFKKNMM() - 1, GameManager.LocalCoop() ? 7 : 26));
				}
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetAnyButtonDown())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Activate Lock"))
			{
				OIOFGDMJCHJ(1);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("LE_18"))
			{
				PHGOBJDNKPH(1);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).JCMOPOMLPLL("Room missing required items"))
			{
				PHGOBJDNKPH(7);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("positions count is 0"))
			{
				ECBINJJHNJG(2);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("Pathfinding error startPos: "))
			{
				KCLLEEJKLOE(1);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("...Failed"))
			{
				PCENBDCACKD(7);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("ReceiveLevelPoints"))
			{
				KCLLEEJKLOE(8);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("PlayerLeftBed_F"))
			{
				PHGOBJDNKPH(6);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("NinjaChallengeEvent/Main"))
			{
				KCLLEEJKLOE(7);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("Sun"))
			{
				SetCurrentSlotSelected(-16);
			}
		}
		if (Utils.FFLNGLMHLBO() && Object.op_Implicit((Object)(object)JDAFPKOHJPC()) && FGGKCJDFNEK().CIGFGKKCPCK(DAINLFIMLIH: false) == -188 && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + new Vector3(1706f, 60f));
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("talentPickles"));
		}
	}

	public void RemoveActionBarBlockers(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	private static ActionBarInventory MHEFLBMGOAJ(int JFNMCNCHMEO)
	{
		return CFFBMLNPMJD[JFNMCNCHMEO];
	}

	public bool EAHLICCEIAK(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = false, int BKFCHPEAJEI = 1)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		if (GGLJBGHPAMN())
		{
			IActionable actionable = KMOPCJGAAGK();
			if (actionable != null && SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected == null && !MELILFOPIPM)
			{
				if (!OBICAGCGMBC || GetSelectedItem().CIGFGKKCPCK() == 99)
				{
					if (!OBICAGCGMBC && BKFCHPEAJEI == 1)
					{
						return actionable.Action(JIIGOACEIKL, KLGOCJMGKFO);
					}
					if (!OBICAGCGMBC && BKFCHPEAJEI == 5)
					{
						return actionable.SecondAction(JIIGOACEIKL, KLGOCJMGKFO);
					}
				}
			}
			else if (KLGOCJMGKFO && CGBJIEHMIKG && Item.FKLOBGBIHLB(GetSelectedItem(), null) && (Object)(object)JDAFPKOHJPC().LLCLICBABLN() != (Object)null && !(JDAFPKOHJPC() is Tool) && GetSelectedItem().PHGCBMPGGLI().GetComponent<IActionable>() != null)
			{
				if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected != null && ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null || !SelectObject.GetPlayer(JIIGOACEIKL).placeable.PickUp(JIIGOACEIKL)))
				{
					return false;
				}
				if (OnlineManager.HHDBMDMFEMP() && OnlineObjectsManager.instance.requestDone)
				{
					return true;
				}
				Placeable component = JDAFPKOHJPC().LLCLICBABLN().GetComponent<Placeable>();
				if (Object.op_Implicit((Object)(object)component) && !component.multipleInstances && PlaceablesManager.GGFJGHHHEJC.GMMFDGFLEJA(JDAFPKOHJPC()))
				{
					MainUI.ShowErrorText(LocalisationSystem.Get("Player/Bark/Error/NotAllPlayersHere"), Vector2.op_Implicit(((Component)GameActionBarUI.Get(JIIGOACEIKL).uiSlots[JGJJDOHBEMJ()]).transform.position), 1947f);
					return true;
				}
				Vector3 val = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() : ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				LFBNPHHABDK = InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).GDJNPPCMIBL();
				if (!MELILFOPIPM && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI() && Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode && ((Object)(object)LFBNPHHABDK == (Object)null || (Object)(object)LFBNPHHABDK.placeable == (Object)null || (Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) == (Object)null || ((Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) != (Object)null && !(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter).crafter.BNPHKHHEKJM)))
				{
					if (Object.op_Implicit((Object)(object)LFBNPHHABDK) && LFBNPHHABDK.disableActionableItemsWhenFocused)
					{
						return true;
					}
					Debug.Log((object)" (");
					TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
					if ((Object)(object)tilemapScene != (Object)null && tilemapScene.canUseDecorationMode)
					{
						DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GAFDHNANIJF(AODONKKHPBP: true);
						autoDecoMode = false;
					}
				}
				GameObject val2 = Object.Instantiate<GameObject>(GetSelectedItem().LLCLICBABLN(), val, Quaternion.identity);
				if (val2.GetComponent<IActionable>().Action(JIIGOACEIKL, KLGOCJMGKFO))
				{
					ItemSetup component2 = val2.GetComponent<ItemSetup>();
					if (Object.op_Implicit((Object)(object)component2))
					{
						if (JDAFPKOHJPC().canBeStacked)
						{
							component2.IMABPOBBIFK(MFDBJINDCAO().KNFNJFFCFNO().JEDPCLGBLBA(JHDFIPFOHDP()));
						}
						else
						{
							component2.PNAOANMDHIJ(JHDFIPFOHDP());
						}
					}
					slots[OEGNHIHFBOL()].MBCIJPPOGJG(CDPAMNIPPEC: false);
					return false;
				}
				Utils.BLPDAEHPOBA(val2);
			}
		}
		return false;
	}

	private void MFPEIPCMEEB()
	{
		if (playerNum == 0 || (GameManager.LocalCoop() && playerNum <= 3))
		{
			EOBHDCPAKFO(playerNum);
		}
	}

	public bool ActionSelectedItem(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = false, int BKFCHPEAJEI = 1)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		if (HPDHIIIFIBF)
		{
			IActionable actionable = MBOHNGNNCED();
			if (actionable != null && SelectObject.GetPlayer(JIIGOACEIKL).selected == null && !MELILFOPIPM)
			{
				if (!OBICAGCGMBC || GetSelectedItem().JDJGFAACPFC() == 1323)
				{
					if (!OBICAGCGMBC && BKFCHPEAJEI == 1)
					{
						return actionable.Action(JIIGOACEIKL, KLGOCJMGKFO);
					}
					if (!OBICAGCGMBC && BKFCHPEAJEI == 2)
					{
						return actionable.SecondAction(JIIGOACEIKL, KLGOCJMGKFO);
					}
				}
			}
			else if (KLGOCJMGKFO && CGBJIEHMIKG && Item.MLBOMGHINCA(GetSelectedItem(), null) && (Object)(object)GetSelectedItem().PHGCBMPGGLI() != (Object)null && !(GetSelectedItem() is Tool) && GetSelectedItem().PHGCBMPGGLI().GetComponent<IActionable>() != null)
			{
				if (SelectObject.GetPlayer(JIIGOACEIKL).selected != null && ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null || !SelectObject.GetPlayer(JIIGOACEIKL).placeable.PickUp(JIIGOACEIKL)))
				{
					return false;
				}
				if (OnlineManager.ClientOnline() && OnlineObjectsManager.instance.requestDone)
				{
					return false;
				}
				Placeable component = GetSelectedItem().PHGCBMPGGLI().GetComponent<Placeable>();
				if (Object.op_Implicit((Object)(object)component) && !component.multipleInstances && PlaceablesManager.GGFJGHHHEJC.ExistsPlaceable(GetSelectedItem()))
				{
					MainUI.ShowErrorText(LocalisationSystem.Get("Error_CannotPlaceTwoObjects"), Vector2.op_Implicit(((Component)GameActionBarUI.Get(JIIGOACEIKL).uiSlots[GetCurrentSlotSelected()]).transform.position));
					return false;
				}
				Vector3 val = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() : ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
				LFBNPHHABDK = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
				if (!MELILFOPIPM && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode && ((Object)(object)LFBNPHHABDK == (Object)null || (Object)(object)LFBNPHHABDK.placeable == (Object)null || (Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) == (Object)null || ((Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) != (Object)null && !(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter).crafter.BNPHKHHEKJM)))
				{
					if (Object.op_Implicit((Object)(object)LFBNPHHABDK) && LFBNPHHABDK.disableActionableItemsWhenFocused)
					{
						return false;
					}
					Debug.Log((object)"ActiveDecoMode");
					TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
					if ((Object)(object)tilemapScene != (Object)null && tilemapScene.canUseDecorationMode)
					{
						DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH = true;
						autoDecoMode = true;
					}
				}
				GameObject val2 = Object.Instantiate<GameObject>(GetSelectedItem().PHGCBMPGGLI(), val, Quaternion.identity);
				if (val2.GetComponent<IActionable>().Action(JIIGOACEIKL, KLGOCJMGKFO))
				{
					ItemSetup component2 = val2.GetComponent<ItemSetup>();
					if (Object.op_Implicit((Object)(object)component2))
					{
						if (GetSelectedItem().canBeStacked)
						{
							component2.DNLMCHDOMOK = GetSelectedItemInstance().LHBPOPOIFLE().KDNBBPJCNDJ(GetSelectedItemInstance());
						}
						else
						{
							component2.DNLMCHDOMOK = GetSelectedItemInstance();
						}
					}
					slots[GetCurrentSlotSelected()].MEODNPFJDMH();
					return true;
				}
				Utils.BLPDAEHPOBA(val2);
			}
		}
		return false;
	}

	public bool JKOKBKAMENA(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = false, int BKFCHPEAJEI = 1)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		if (HPDHIIIFIBF)
		{
			IActionable actionable = CFEBGABFDFM();
			if (actionable != null && SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected == null && !MELILFOPIPM)
			{
				if (!OBICAGCGMBC || FGGKCJDFNEK().JGHNDJBCFAJ() == 78)
				{
					if (!OBICAGCGMBC && BKFCHPEAJEI == 0)
					{
						return actionable.Action(JIIGOACEIKL, KLGOCJMGKFO);
					}
					if (!OBICAGCGMBC && BKFCHPEAJEI == 4)
					{
						return actionable.SecondAction(JIIGOACEIKL, KLGOCJMGKFO);
					}
				}
			}
			else if (KLGOCJMGKFO && CGBJIEHMIKG && Item.MLBOMGHINCA(JDAFPKOHJPC(), null) && (Object)(object)GetSelectedItem().PHGCBMPGGLI() != (Object)null && !(JDAFPKOHJPC() is Tool) && GetSelectedItem().LLCLICBABLN().GetComponent<IActionable>() != null)
			{
				if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected != null && ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null || !SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.PickUp(JIIGOACEIKL)))
				{
					return true;
				}
				if (OnlineManager.ClientOnline() && OnlineObjectsManager.instance.requestDone)
				{
					return true;
				}
				Placeable component = FGGKCJDFNEK().LLCLICBABLN().GetComponent<Placeable>();
				if (Object.op_Implicit((Object)(object)component) && !component.multipleInstances && PlaceablesManager.MNFMOEKMJKN().GMMFDGFLEJA(FGGKCJDFNEK()))
				{
					MainUI.ShowErrorText(LocalisationSystem.Get(""), Vector2.op_Implicit(((Component)GameActionBarUI.PHDBJGOEKHB(JIIGOACEIKL).uiSlots[JGJJDOHBEMJ()]).transform.position), 1038f);
					return false;
				}
				Vector3 val = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() : ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
				LFBNPHHABDK = InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).HBIKILDEHFI();
				if (!MELILFOPIPM && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).KNFEPKBIHND() && Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode && ((Object)(object)LFBNPHHABDK == (Object)null || (Object)(object)LFBNPHHABDK.placeable == (Object)null || (Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) == (Object)null || ((Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) != (Object)null && !(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter).crafter.BNPHKHHEKJM)))
				{
					if (Object.op_Implicit((Object)(object)LFBNPHHABDK) && LFBNPHHABDK.disableActionableItemsWhenFocused)
					{
						return false;
					}
					Debug.Log((object)"No se encuentra sprite renderer en ");
					TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
					if ((Object)(object)tilemapScene != (Object)null && tilemapScene.canUseDecorationMode)
					{
						DecorationMode.HBDCJFLINDA(JIIGOACEIKL).LAJPGLFEAIC(AODONKKHPBP: false);
						autoDecoMode = true;
					}
				}
				GameObject val2 = Object.Instantiate<GameObject>(FGGKCJDFNEK().PHGCBMPGGLI(), val, Quaternion.identity);
				if (val2.GetComponent<IActionable>().Action(JIIGOACEIKL, KLGOCJMGKFO))
				{
					ItemSetup component2 = val2.GetComponent<ItemSetup>();
					if (Object.op_Implicit((Object)(object)component2))
					{
						if (GetSelectedItem().canBeStacked)
						{
							component2.DNLMCHDOMOK = GetSelectedItemInstance().AFOACBIHNCL().LJBOJBAPDAD(GOADDJLNIBN());
						}
						else
						{
							component2.NGGENKGBAIO(JHDFIPFOHDP());
						}
					}
					slots[CMHNEHPIBDN()].POHFJCEAKML(CDPAMNIPPEC: false);
					return true;
				}
				Utils.BLPDAEHPOBA(val2);
			}
		}
		return false;
	}

	public void OCJBIDIDJNN(MonoBehaviour NPJDIDHOEFB)
	{
		if (!IILDLOOCPKN.Contains(NPJDIDHOEFB))
		{
			IILDLOOCPKN.Add(NPJDIDHOEFB);
		}
	}

	private void DNPNAGONAMH(int JIIGOACEIKL)
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers() || !GameActionBarUI.NDPAJCGHGOB(JIIGOACEIKL).IsOpen())
		{
			return;
		}
		if (scrollingEnabled && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable == (Object)null)
		{
			AIIHEFHCNFB = 494f;
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "ReceiveToggleOpenBarnCanceled", 1004f))
			{
				AIIHEFHCNFB = 596f;
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "OrderDelivered", 1868f))
			{
				AIIHEFHCNFB = 1339f;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
			{
				AIIHEFHCNFB = 397f;
			}
			if (AIIHEFHCNFB > 903f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
				{
					CEMHJDMCPLK.PLCEAAPMMOO();
				}
				else if (IMNBGNDBFDB())
				{
					OIOFGDMJCHJ(Utils.NMLNAGFLNMC(DJPNPFGECBF() + 1, GameManager.LocalCoop() ? 3 : 100));
				}
			}
			else if (AIIHEFHCNFB < 885f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.DOJJLDCLJEN();
				}
				else if (IMNBGNDBFDB())
				{
					ECBINJJHNJG(Utils.NMLNAGFLNMC(KFLNAJIBFIF() - 0, GameManager.LocalCoop() ? 5 : 39));
				}
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).CACFPALCHAH())
		{
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("ReceiveUpdatePoints"))
			{
				SetCurrentSlotSelected(0);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("chatSounds"))
			{
				PCENBDCACKD(0);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("fishDishes"))
			{
				KCLLEEJKLOE(3);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("decrease reputation"))
			{
				KCLLEEJKLOE(0);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).JCMOPOMLPLL("Tutorial/T136/Dialogue1"))
			{
				SetCurrentSlotSelected(5);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("MaxProductValue"))
			{
				OIOFGDMJCHJ(5);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("Items/item_name_1040"))
			{
				SetCurrentSlotSelected(3);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(" added to delivery chest"))
			{
				PCENBDCACKD(6);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown(""))
			{
				PCENBDCACKD(5);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("\n"))
			{
				ECBINJJHNJG(-79);
			}
		}
		if (Utils.FFLNGLMHLBO() && Object.op_Implicit((Object)(object)GetSelectedItem()) && JDAFPKOHJPC().JDJGFAACPFC(DAINLFIMLIH: false) == 129 && (Object)(object)InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(748f, 222f));
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Error_DrinkLimitOnTray"));
		}
	}

	private IEnumerator BGNNKCPEKCE(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = true)
	{
		return new DFKBOJFBDLM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			buttonDown = KLGOCJMGKFO,
			checkPrefab = CGBJIEHMIKG,
			slotClicked = OBICAGCGMBC,
			slotChanged = MELILFOPIPM
		};
	}

	public int FDOFGNEDJMK()
	{
		return GAANHLBHAKM;
	}

	public void DKOJDCLFGAO(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = true)
	{
		((MonoBehaviour)this).StartCoroutine(FAJEBIPIIGF(JIIGOACEIKL, KLGOCJMGKFO, CGBJIEHMIKG, OBICAGCGMBC, MELILFOPIPM));
	}

	public void JEGBMANMEFD(MonoBehaviour NPJDIDHOEFB)
	{
		if (!IILDLOOCPKN.Contains(NPJDIDHOEFB))
		{
			IILDLOOCPKN.Add(NPJDIDHOEFB);
		}
	}

	public static ActionBarInventory GetPlayer(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Invalid playerNum " + JFNMCNCHMEO));
		return null;
	}

	public int ECDLIFKKNMM()
	{
		return GAANHLBHAKM;
	}

	public Slot MNIDFIJLHLL(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	public int JDBAHDFLONL()
	{
		return GAANHLBHAKM;
	}

	public override Slot AddItemInstance(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		if (HasItem(BGLFLHDNOKJ, GameManager.LocalCoop() ? BLMADJJOAKA : slots))
		{
			return Utils.CHMEHDFPGCI(JIIGOACEIKL, BGLFLHDNOKJ, GameManager.LocalCoop() ? BLMADJJOAKA : slots, BGLFLHDNOKJ.LHBPOPOIFLE().amountStack, null, null, null, null, FoodType.None, null, OECLHGILEOL: false, CDPAMNIPPEC);
		}
		if (OJKJLIPNHOI && GetSelectedSlot().KPINNBKMOMO())
		{
			if (!Utils.DOOILKJLDHD(BGLFLHDNOKJ, this))
			{
				return null;
			}
			if (GetSelectedSlot().FEEOFAGCONJ(JIIGOACEIKL, BGLFLHDNOKJ, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true))
			{
				return GetSelectedSlot();
			}
			return null;
		}
		return Utils.CHMEHDFPGCI(JIIGOACEIKL, BGLFLHDNOKJ, GameManager.LocalCoop() ? BLMADJJOAKA : slots, GetMaxStack(BGLFLHDNOKJ), null, null, null, null, FoodType.None, null, OECLHGILEOL: false, CDPAMNIPPEC);
	}

	public ItemInstance BBBGBHPJOAG()
	{
		if (slots[OEGNHIHFBOL()].itemInstance != null)
		{
			return slots[OEGNHIHFBOL()].itemInstance;
		}
		return null;
	}

	public void KCLLEEJKLOE(int NJNDJNGLDGK)
	{
		if (NJNDJNGLDGK != GAANHLBHAKM)
		{
			OnSelectionChanged(playerNum, NJNDJNGLDGK);
			GAANHLBHAKM = NJNDJNGLDGK;
			if (GOADDJLNIBN() is ToolInstance toolInstance)
			{
				toolInstance.MDDMJAMDMNI(playerNum);
			}
		}
		else
		{
			GAANHLBHAKM = NJNDJNGLDGK;
		}
	}

	public bool PENGFJBFIFJ(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (IMNBGNDBFDB() && SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = MBOHNGNNCED();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return false;
			}
		}
		return false;
	}

	public bool LNBINPJINAJ(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (IMNBGNDBFDB() && SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = BAPPPBEHIGH();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 0)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return true;
			}
		}
		return true;
	}

	private IEnumerator BHEHIEOLLCC(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = true)
	{
		return new DFKBOJFBDLM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			buttonDown = KLGOCJMGKFO,
			checkPrefab = CGBJIEHMIKG,
			slotClicked = OBICAGCGMBC,
			slotChanged = MELILFOPIPM
		};
	}

	public Slot KNFAAADOMNC(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	public Slot GetSelectedSlot()
	{
		return slots[GetCurrentSlotSelected()];
	}

	public Slot PFCKPOFHPAC()
	{
		return slots[FDOFGNEDJMK()];
	}

	public void PHGOBJDNKPH(int NJNDJNGLDGK)
	{
		if (NJNDJNGLDGK != GAANHLBHAKM)
		{
			OnSelectionChanged(playerNum, NJNDJNGLDGK);
			GAANHLBHAKM = NJNDJNGLDGK;
			if (JHDFIPFOHDP() is ToolInstance toolInstance)
			{
				toolInstance.BDICJHGOPGO(playerNum);
			}
		}
		else
		{
			GAANHLBHAKM = NJNDJNGLDGK;
		}
	}

	private static ActionBarInventory OMJPAJJLMDA(int JFNMCNCHMEO)
	{
		return CFFBMLNPMJD[JFNMCNCHMEO];
	}

	public void HECIFLOMDEB()
	{
		IILDLOOCPKN.Clear();
	}

	public bool DGFOPICIIHA(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (IMNBGNDBFDB() && SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = APOHLHBNEOG();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return false;
			}
		}
		return true;
	}

	public int NLIEGDDKKIJ()
	{
		return GAANHLBHAKM;
	}

	public ItemInstance GOADDJLNIBN()
	{
		if (slots[HOJKGHEDAJO()].itemInstance != null)
		{
			return slots[CMHNEHPIBDN()].itemInstance;
		}
		return null;
	}

	public int HOJKGHEDAJO()
	{
		return GAANHLBHAKM;
	}

	public static ActionBarInventory DACNEICGAAE(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return ANLKPPNOONC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return MHEFLBMGOAJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("" + JFNMCNCHMEO));
		return null;
	}

	public int CMHNEHPIBDN()
	{
		return GAANHLBHAKM;
	}

	private IActionable KMOPCJGAAGK()
	{
		if (GetSelectedItem() is IActionable result)
		{
			return result;
		}
		if (JHDFIPFOHDP() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public Slot LBKLHMMHLMC(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	public bool EKHCFCIHDJI(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (HPDHIIIFIBF && SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = BAPPPBEHIGH();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return false;
			}
		}
		return false;
	}

	public bool INIJDPHJBDD(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = false, int BKFCHPEAJEI = 1)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		if (CBLKCKNBCFL())
		{
			IActionable actionable = KMOPCJGAAGK();
			if (actionable != null && SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected == null && !MELILFOPIPM)
			{
				if (!OBICAGCGMBC || FGGKCJDFNEK().JGHNDJBCFAJ() == 156)
				{
					if (!OBICAGCGMBC && BKFCHPEAJEI == 1)
					{
						return actionable.Action(JIIGOACEIKL, KLGOCJMGKFO);
					}
					if (!OBICAGCGMBC && BKFCHPEAJEI == 1)
					{
						return actionable.SecondAction(JIIGOACEIKL, KLGOCJMGKFO);
					}
				}
			}
			else if (KLGOCJMGKFO && CGBJIEHMIKG && Item.FKLOBGBIHLB(GetSelectedItem(), null) && (Object)(object)GetSelectedItem().LLCLICBABLN() != (Object)null && !(FGGKCJDFNEK() is Tool) && GetSelectedItem().LLCLICBABLN().GetComponent<IActionable>() != null)
			{
				if (SelectObject.GetPlayer(JIIGOACEIKL).selected != null && ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null || !SelectObject.GetPlayer(JIIGOACEIKL).placeable.PickUp(JIIGOACEIKL)))
				{
					return false;
				}
				if (OnlineManager.HHDBMDMFEMP() && OnlineObjectsManager.instance.requestDone)
				{
					return false;
				}
				Placeable component = GetSelectedItem().PHGCBMPGGLI().GetComponent<Placeable>();
				if (Object.op_Implicit((Object)(object)component) && !component.multipleInstances && PlaceablesManager.OJJDNLEFNPJ().DFAGHJAFBHN(GetSelectedItem()))
				{
					MainUI.ShowErrorText(LocalisationSystem.Get(" "), Vector2.op_Implicit(((Component)GameActionBarUI.IEKODILKIHJ(JIIGOACEIKL).uiSlots[ECDLIFKKNMM()]).transform.position), 398f);
					return true;
				}
				Vector3 val = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() : ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
				LFBNPHHABDK = InputByProximityManager.JOFDIPFMIHF(JIIGOACEIKL).HOMHFEJHKIF();
				if (!MELILFOPIPM && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH && Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode && ((Object)(object)LFBNPHHABDK == (Object)null || (Object)(object)LFBNPHHABDK.placeable == (Object)null || (Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) == (Object)null || ((Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) != (Object)null && !(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter).crafter.BNPHKHHEKJM)))
				{
					if (Object.op_Implicit((Object)(object)LFBNPHHABDK) && LFBNPHHABDK.disableActionableItemsWhenFocused)
					{
						return true;
					}
					Debug.Log((object)"quest_name_16");
					TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
					if ((Object)(object)tilemapScene != (Object)null && tilemapScene.canUseDecorationMode)
					{
						DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DDHHFMBJNHB(AODONKKHPBP: true);
						autoDecoMode = true;
					}
				}
				GameObject val2 = Object.Instantiate<GameObject>(FGGKCJDFNEK().PHGCBMPGGLI(), val, Quaternion.identity);
				if (val2.GetComponent<IActionable>().Action(JIIGOACEIKL, KLGOCJMGKFO))
				{
					ItemSetup component2 = val2.GetComponent<ItemSetup>();
					if (Object.op_Implicit((Object)(object)component2))
					{
						if (GetSelectedItem().canBeStacked)
						{
							component2.ECIHHBKDPML(GOADDJLNIBN().AFOACBIHNCL().ELKNKIOFNCN(JHDFIPFOHDP()));
						}
						else
						{
							component2.NGGENKGBAIO(JHDFIPFOHDP());
						}
					}
					slots[JGJJDOHBEMJ()].FMEPMEKLHIJ();
					return true;
				}
				Utils.BLPDAEHPOBA(val2);
			}
		}
		return true;
	}

	public Slot GetSlot(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	public Slot EBJMBIPBLFN(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	private void NEDADNGKAOM(int JIIGOACEIKL)
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers() || !GameActionBarUI.AKMJEPMHFMO(JIIGOACEIKL).BGLJFMHCFJF())
		{
			return;
		}
		if (scrollingEnabled && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable == (Object)null)
		{
			AIIHEFHCNFB = 272f;
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Shanty", 1237f))
			{
				AIIHEFHCNFB = 1278f;
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Items/item_name_1117", 324f))
			{
				AIIHEFHCNFB = 646f;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
			{
				AIIHEFHCNFB = 1400f;
			}
			if (AIIHEFHCNFB > 1178f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
				{
					CEMHJDMCPLK.CKFKIKGDADN();
				}
				else if (GGLJBGHPAMN())
				{
					PHGOBJDNKPH(Utils.NMLNAGFLNMC(LIMCJONFMPN() + 1, GameManager.LocalCoop() ? 5 : 123));
				}
			}
			else if (AIIHEFHCNFB < 1379f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
				{
					CEMHJDMCPLK.FKNEFDPLJKH();
				}
				else if (GGLJBGHPAMN())
				{
					SetCurrentSlotSelected(Utils.NMLNAGFLNMC(ECDLIFKKNMM() - 1, GameManager.LocalCoop() ? 5 : 28));
				}
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.GetPlayer(JIIGOACEIKL).CACFPALCHAH())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ReceiveCatPosition"))
			{
				SetCurrentSlotSelected(0);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("- "))
			{
				OIOFGDMJCHJ(1);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Ingredient null!"))
			{
				OIOFGDMJCHJ(6);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("AlexPoysky"))
			{
				OIOFGDMJCHJ(4);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("sprintHold"))
			{
				PCENBDCACKD(5);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).JCMOPOMLPLL(" (Client)"))
			{
				KCLLEEJKLOE(6);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).JCMOPOMLPLL("itemAvocado"))
			{
				PCENBDCACKD(3);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Bucket"))
			{
				SetCurrentSlotSelected(2);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ProductValue"))
			{
				OIOFGDMJCHJ(1);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("ErrorServerTimeout"))
			{
				PCENBDCACKD(13);
			}
		}
		if (Utils.FFLNGLMHLBO() && Object.op_Implicit((Object)(object)FGGKCJDFNEK()) && GetSelectedItem().JPNFKDMFKMC(DAINLFIMLIH: false) == 142 && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			ButtonsContext.SetPosition(JIIGOACEIKL, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + new Vector3(845f, 1162f));
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Bed not found! Unique id: "));
		}
	}

	private IActionable FPMGGNCGBJM()
	{
		if (JDAFPKOHJPC() is IActionable result)
		{
			return result;
		}
		if (GOADDJLNIBN() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public bool BMPFEGFGNLJ(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (HPDHIIIFIBF && SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = FPMGGNCGBJM();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return true;
			}
		}
		return true;
	}

	private void OIOIODLJEGF(int JIIGOACEIKL)
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers() || !GameActionBarUI.Get(JIIGOACEIKL).IsOpen())
		{
			return;
		}
		if (scrollingEnabled && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null)
		{
			AIIHEFHCNFB = 0f;
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "ScrollUp"))
			{
				AIIHEFHCNFB = 1f;
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "ScrollDown"))
			{
				AIIHEFHCNFB = -1f;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
			{
				AIIHEFHCNFB = 0f;
			}
			if (AIIHEFHCNFB > 0f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.ScrollUp();
				}
				else if (HPDHIIIFIBF)
				{
					SetCurrentSlotSelected(Utils.NMLNAGFLNMC(GetCurrentSlotSelected() + 1, GameManager.LocalCoop() ? 8 : 10));
				}
			}
			else if (AIIHEFHCNFB < 0f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.ScrollDown();
				}
				else if (HPDHIIIFIBF)
				{
					SetCurrentSlotSelected(Utils.NMLNAGFLNMC(GetCurrentSlotSelected() - 1, GameManager.LocalCoop() ? 8 : 10));
				}
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).GetAnyButtonDown())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar1"))
			{
				SetCurrentSlotSelected(0);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar2"))
			{
				SetCurrentSlotSelected(1);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar3"))
			{
				SetCurrentSlotSelected(2);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar4"))
			{
				SetCurrentSlotSelected(3);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar5"))
			{
				SetCurrentSlotSelected(4);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar6"))
			{
				SetCurrentSlotSelected(5);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar7"))
			{
				SetCurrentSlotSelected(6);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar8"))
			{
				SetCurrentSlotSelected(7);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar9"))
			{
				SetCurrentSlotSelected(8);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("ActionBar10"))
			{
				SetCurrentSlotSelected(9);
			}
		}
		if (Utils.FFLNGLMHLBO() && Object.op_Implicit((Object)(object)GetSelectedItem()) && GetSelectedItem().JDJGFAACPFC() == 1323 && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			ButtonsContext.SetPosition(JIIGOACEIKL, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(0f, 1.2f));
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Use"));
		}
	}

	public bool EndSelectedItem(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (HPDHIIIFIBF && SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = MBOHNGNNCED();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	private bool GGLJBGHPAMN()
	{
		if (PiratesGameManager.Playing)
		{
			return true;
		}
		if (FishCuttingGameManager.Playing)
		{
			return false;
		}
		if (BathhouseGameManager.Playing)
		{
			return true;
		}
		return IILDLOOCPKN.Count == 0;
	}

	public bool DBCJNAPFFCP(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (HPDHIIIFIBF && SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = APOHLHBNEOG();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	private bool LKLCLBMMDMF()
	{
		if (PiratesGameManager.Playing)
		{
			return true;
		}
		if (FishCuttingGameManager.Playing)
		{
			return false;
		}
		if (BathhouseGameManager.Playing)
		{
			return false;
		}
		return IILDLOOCPKN.Count == 1;
	}

	public int OEGNHIHFBOL()
	{
		return GAANHLBHAKM;
	}

	public bool DMKBILLFPHO(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = false, int BKFCHPEAJEI = 1)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		if (LKLCLBMMDMF())
		{
			IActionable actionable = HLLHIOAGCEJ();
			if (actionable != null && SelectObject.GetPlayer(JIIGOACEIKL).selected == null && !MELILFOPIPM)
			{
				if (!OBICAGCGMBC || FGGKCJDFNEK().IMCJPECAAPC() == 117)
				{
					if (!OBICAGCGMBC && BKFCHPEAJEI == 1)
					{
						return actionable.Action(JIIGOACEIKL, KLGOCJMGKFO);
					}
					if (!OBICAGCGMBC && BKFCHPEAJEI == 0)
					{
						return actionable.SecondAction(JIIGOACEIKL, KLGOCJMGKFO);
					}
				}
			}
			else if (KLGOCJMGKFO && CGBJIEHMIKG && Item.FKLOBGBIHLB(GetSelectedItem(), null) && (Object)(object)GetSelectedItem().PHGCBMPGGLI() != (Object)null && !(GetSelectedItem() is Tool) && FGGKCJDFNEK().LLCLICBABLN().GetComponent<IActionable>() != null)
			{
				if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).selected != null && ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null || !SelectObject.GetPlayer(JIIGOACEIKL).placeable.PickUp(JIIGOACEIKL)))
				{
					return false;
				}
				if (OnlineManager.ClientOnline() && OnlineObjectsManager.instance.requestDone)
				{
					return true;
				}
				Placeable component = GetSelectedItem().PHGCBMPGGLI().GetComponent<Placeable>();
				if (Object.op_Implicit((Object)(object)component) && !component.multipleInstances && PlaceablesManager.AJIGOHGPFPP().DFAGHJAFBHN(FGGKCJDFNEK()))
				{
					MainUI.ShowErrorText(LocalisationSystem.Get("Tutorial/T113/Dialogue1"), Vector2.op_Implicit(((Component)GameActionBarUI.AKMJEPMHFMO(JIIGOACEIKL).uiSlots[ECDLIFKKNMM()]).transform.position), 828f);
					return false;
				}
				Vector3 val = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() : ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position);
				LFBNPHHABDK = InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).HBIKILDEHFI();
				if (!MELILFOPIPM && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DFNMDDHOIJI() && Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).canUseDecorationMode && ((Object)(object)LFBNPHHABDK == (Object)null || (Object)(object)LFBNPHHABDK.placeable == (Object)null || (Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) == (Object)null || ((Object)(object)(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter) != (Object)null && !(LFBNPHHABDK.placeable.onlinePlaceable as OnlineCrafter).crafter.BNPHKHHEKJM)))
				{
					if (Object.op_Implicit((Object)(object)LFBNPHHABDK) && LFBNPHHABDK.disableActionableItemsWhenFocused)
					{
						return false;
					}
					Debug.Log((object)"{0} - Altar piece ID {1} matches this piece ID {2}. Activating only variants with altar.");
					TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
					if ((Object)(object)tilemapScene != (Object)null && tilemapScene.canUseDecorationMode)
					{
						DecorationMode.GetPlayer(JIIGOACEIKL).LAJPGLFEAIC(AODONKKHPBP: true);
						autoDecoMode = false;
					}
				}
				GameObject val2 = Object.Instantiate<GameObject>(GetSelectedItem().PHGCBMPGGLI(), val, Quaternion.identity);
				if (val2.GetComponent<IActionable>().Action(JIIGOACEIKL, KLGOCJMGKFO))
				{
					ItemSetup component2 = val2.GetComponent<ItemSetup>();
					if (Object.op_Implicit((Object)(object)component2))
					{
						if (GetSelectedItem().canBeStacked)
						{
							component2.IMABPOBBIFK(MFDBJINDCAO().PHGLMBIEOMK().KDNBBPJCNDJ(BBBGBHPJOAG()));
						}
						else
						{
							component2.ECIHHBKDPML(MFDBJINDCAO());
						}
					}
					slots[NLIEGDDKKIJ()].MBCIJPPOGJG(CDPAMNIPPEC: false);
					return true;
				}
				Utils.BLPDAEHPOBA(val2);
			}
		}
		return false;
	}

	public void JPFMEEFCHAE()
	{
		IILDLOOCPKN.Clear();
	}

	private IActionable CFEBGABFDFM()
	{
		if (FGGKCJDFNEK() is IActionable result)
		{
			return result;
		}
		if (MFDBJINDCAO() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	private void BEGLOAKAICN()
	{
		if (playerNum == 0 || (GameManager.LocalCoop() && playerNum <= 6))
		{
			OIOIODLJEGF(playerNum);
		}
	}

	public Slot FFKEAICPOLC(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	public Slot GEAMCEMDJFJ()
	{
		return slots[CMAOFAPMLEO()];
	}

	public void HDOECMMAIPG(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = true)
	{
		((MonoBehaviour)this).StartCoroutine(FAJEBIPIIGF(JIIGOACEIKL, KLGOCJMGKFO, CGBJIEHMIKG, OBICAGCGMBC, MELILFOPIPM));
	}

	protected override void Awake()
	{
		if (onlineInstance)
		{
			CFFBMLNPMJD[playerNum] = this;
		}
		else if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else if (playerNum == 2)
		{
			BBINLIGKIPE = this;
		}
		base.Awake();
		BLMADJJOAKA = new Slot[8];
		for (int i = 0; i < 8; i++)
		{
			BLMADJJOAKA[i] = slots[i];
		}
	}

	public Slot GPKEPFHIAME(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	private void FMKINAPGBLK(int JIIGOACEIKL)
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN() || !GameActionBarUI.NDPAJCGHGOB(JIIGOACEIKL).BGLJFMHCFJF())
		{
			return;
		}
		if (scrollingEnabled && (Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable == (Object)null)
		{
			AIIHEFHCNFB = 551f;
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "(empty)", 1556f))
			{
				AIIHEFHCNFB = 810f;
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "ReceiveUnlockPerkLevel", 829f))
			{
				AIIHEFHCNFB = 838f;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
			{
				AIIHEFHCNFB = 1702f;
			}
			if (AIIHEFHCNFB > 426f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
				{
					CEMHJDMCPLK.INDALBNEMCD();
				}
				else if (CBLKCKNBCFL())
				{
					PHGOBJDNKPH(Utils.NMLNAGFLNMC(NLIEGDDKKIJ() + 1, GameManager.LocalCoop() ? 3 : (-42)));
				}
			}
			else if (AIIHEFHCNFB < 285f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
				{
					CEMHJDMCPLK.KIDJEGKDAOE();
				}
				else if (IMNBGNDBFDB())
				{
					PCENBDCACKD(Utils.NMLNAGFLNMC(JGJJDOHBEMJ() - 1, GameManager.LocalCoop() ? 4 : (-122)));
				}
			}
		}
		if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && PlayerInputs.GetPlayer(JIIGOACEIKL).GetAnyButtonDown())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("Leave smoothly"))
			{
				KCLLEEJKLOE(1);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("Balance/MainEvent"))
			{
				OIOFGDMJCHJ(1);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("cloudy"))
			{
				OIOFGDMJCHJ(6);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("LE_10"))
			{
				ECBINJJHNJG(3);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("MapBeach"))
			{
				KCLLEEJKLOE(4);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("stuck recovery"))
			{
				KCLLEEJKLOE(8);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).JCMOPOMLPLL("Player {0} ID: {1}, platform: {2}"))
			{
				PCENBDCACKD(2);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA(" nulo en "))
			{
				PHGOBJDNKPH(5);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("Player2"))
			{
				OIOFGDMJCHJ(6);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Dialogue System/Conversation/Gass_Quest/Entry/12/Dialogue Text"))
			{
				ECBINJJHNJG(-95);
			}
		}
		if (Utils.FFLNGLMHLBO() && Object.op_Implicit((Object)(object)JDAFPKOHJPC()) && JDAFPKOHJPC().JGHNDJBCFAJ(DAINLFIMLIH: false) == 150 && (Object)(object)InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(406f, 1895f));
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Game"));
		}
	}

	public void OIOFGDMJCHJ(int NJNDJNGLDGK)
	{
		if (NJNDJNGLDGK != GAANHLBHAKM)
		{
			OnSelectionChanged(playerNum, NJNDJNGLDGK);
			GAANHLBHAKM = NJNDJNGLDGK;
			if (GOADDJLNIBN() is ToolInstance toolInstance)
			{
				toolInstance.KHBLOPADBAF(playerNum);
			}
		}
		else
		{
			GAANHLBHAKM = NJNDJNGLDGK;
		}
	}

	public Slot NBEINBNMKJG()
	{
		return slots[GetCurrentSlotSelected()];
	}

	public Slot CHIDEFOLBBN(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	private void EOBHDCPAKFO(int JIIGOACEIKL)
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN() || !GameActionBarUI.BGABEMMDDEH(JIIGOACEIKL).IsOpen())
		{
			return;
		}
		if (scrollingEnabled && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable == (Object)null)
		{
			AIIHEFHCNFB = 220f;
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "OnlinePlayer", 1504f))
			{
				AIIHEFHCNFB = 546f;
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "Error compressing files! ", 1359f))
			{
				AIIHEFHCNFB = 965f;
			}
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
			{
				AIIHEFHCNFB = 907f;
			}
			if (AIIHEFHCNFB > 560f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.KLFHMEKHDJE();
				}
				else if (LKLCLBMMDMF())
				{
					OIOFGDMJCHJ(Utils.NMLNAGFLNMC(KFLNAJIBFIF() + 1, GameManager.LocalCoop() ? 8 : (-19)));
				}
			}
			else if (AIIHEFHCNFB < 335f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.EMMCDALHMNH();
				}
				else if (IMNBGNDBFDB())
				{
					KCLLEEJKLOE(Utils.NMLNAGFLNMC(GetCurrentSlotSelected() - 1, GameManager.LocalCoop() ? 1 : (-105)));
				}
			}
		}
		if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).CACFPALCHAH())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Sleep"))
			{
				PCENBDCACKD(0);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Game"))
			{
				ECBINJJHNJG(0);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("Clean"))
			{
				SetCurrentSlotSelected(3);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("UI2"))
			{
				OIOFGDMJCHJ(6);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text"))
			{
				SetCurrentSlotSelected(6);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("ProductValue"))
			{
				PHGOBJDNKPH(0);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Up Arrow"))
			{
				PCENBDCACKD(7);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("Invalid item"))
			{
				ECBINJJHNJG(4);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL(" "))
			{
				SetCurrentSlotSelected(7);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).DLFAMOCKNMA("Player"))
			{
				ECBINJJHNJG(-123);
			}
		}
		if (Utils.FFLNGLMHLBO() && Object.op_Implicit((Object)(object)GetSelectedItem()) && FGGKCJDFNEK().ODENMDOJPLC() == -84 && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(1853f, 948f));
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Create Private Room"));
		}
	}

	private IActionable NEMIHBOPAPB()
	{
		if (JDAFPKOHJPC() is IActionable result)
		{
			return result;
		}
		if (GOADDJLNIBN() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public void FFKGINHPBGG(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	public int KFLNAJIBFIF()
	{
		return GAANHLBHAKM;
	}

	public void KNIIOANIIDB(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	private IEnumerator FAJEBIPIIGF(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = true)
	{
		yield return null;
		ActionSelectedItem(JIIGOACEIKL, KLGOCJMGKFO, CGBJIEHMIKG, OBICAGCGMBC, MELILFOPIPM);
	}

	public void ActionSelectedItemNextFrame(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = true)
	{
		((MonoBehaviour)this).StartCoroutine(FAJEBIPIIGF(JIIGOACEIKL, KLGOCJMGKFO, CGBJIEHMIKG, OBICAGCGMBC, MELILFOPIPM));
	}

	private IActionable KOADNEFHKBL()
	{
		if (FGGKCJDFNEK() is IActionable result)
		{
			return result;
		}
		if (MFDBJINDCAO() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	private IActionable KPFJCEMDJPE()
	{
		if (GetSelectedItem() is IActionable result)
		{
			return result;
		}
		if (GOADDJLNIBN() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public Slot KDJMFELBOPM()
	{
		return slots[HOJKGHEDAJO()];
	}

	public void ONNIGCGMPHG(int JIIGOACEIKL, bool KLGOCJMGKFO, bool CGBJIEHMIKG, bool OBICAGCGMBC, bool MELILFOPIPM = true)
	{
		((MonoBehaviour)this).StartCoroutine(BGNNKCPEKCE(JIIGOACEIKL, KLGOCJMGKFO, CGBJIEHMIKG, OBICAGCGMBC, MELILFOPIPM));
	}

	public void AddActionBarBlockers(MonoBehaviour NPJDIDHOEFB)
	{
		if (!IILDLOOCPKN.Contains(NPJDIDHOEFB))
		{
			IILDLOOCPKN.Add(NPJDIDHOEFB);
		}
	}

	public int DOMHGEAFCAP()
	{
		return GAANHLBHAKM;
	}

	public void CBAOECAHPDI(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	public void HMGBGIMEBII()
	{
		IILDLOOCPKN.Clear();
	}

	private void NMHPGOGGPNG(int JIIGOACEIKL)
	{
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers() || !GameActionBarUI.PHDBJGOEKHB(JIIGOACEIKL).HDEPMJIDJEM())
		{
			return;
		}
		if (scrollingEnabled && (Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable == (Object)null)
		{
			AIIHEFHCNFB = 1542f;
			if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "\n", 612f))
			{
				AIIHEFHCNFB = 381f;
			}
			else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "CannotToggleUI Holding ", 1109f))
			{
				AIIHEFHCNFB = 131f;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
			{
				AIIHEFHCNFB = 1863f;
			}
			if (AIIHEFHCNFB > 1830f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.CIFCOAFCANC();
				}
				else if (GGLJBGHPAMN())
				{
					PHGOBJDNKPH(Utils.NMLNAGFLNMC(ECDLIFKKNMM() + 1, GameManager.LocalCoop() ? 6 : (-72)));
				}
			}
			else if (AIIHEFHCNFB < 416f && !OnlineChatUI.IsMouseOverChat())
			{
				CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(JIIGOACEIKL);
				if ((Object)(object)CEMHJDMCPLK != (Object)null && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					CEMHJDMCPLK.BEAODPOABDC();
				}
				else if (CBLKCKNBCFL())
				{
					PHGOBJDNKPH(Utils.NMLNAGFLNMC(OEGNHIHFBOL() - 1, GameManager.LocalCoop() ? 1 : (-66)));
				}
			}
		}
		if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && PlayerInputs.GetPlayer(JIIGOACEIKL).GetAnyButtonDown())
		{
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("The index ("))
			{
				PCENBDCACKD(1);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Dialogue System/Conversation/Crowly_Standar/Entry/26/Dialogue Text"))
			{
				KCLLEEJKLOE(1);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("ReceiveStartWork"))
			{
				PHGOBJDNKPH(3);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DLFAMOCKNMA("tutorialPopUp103"))
			{
				ECBINJJHNJG(0);
			}
			if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("Staff"))
			{
				KCLLEEJKLOE(0);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown("Dialogue System/Conversation/Crowly_Standar/Entry/17/Dialogue Text"))
			{
				KCLLEEJKLOE(2);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("CookiesNeeded"))
			{
				ECBINJJHNJG(0);
			}
			if (PlayerInputs.GetPlayer(JIIGOACEIKL).JCMOPOMLPLL("Items/item_name_666"))
			{
				OIOFGDMJCHJ(7);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonDown("ReceiveSimpleEvent"))
			{
				ECBINJJHNJG(3);
			}
			if (!GameManager.LocalCoop() && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonDown(""))
			{
				ECBINJJHNJG(-70);
			}
		}
		if (Utils.FFLNGLMHLBO() && Object.op_Implicit((Object)(object)FGGKCJDFNEK()) && GetSelectedItem().JDJGFAACPFC() == 43 && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + new Vector3(1099f, 503f));
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Hiding Keyboard "));
		}
	}

	public void OIMDEHAGLIG(MonoBehaviour NPJDIDHOEFB)
	{
		if (!IILDLOOCPKN.Contains(NPJDIDHOEFB))
		{
			IILDLOOCPKN.Add(NPJDIDHOEFB);
		}
	}

	public void GDBBPKDNLBD(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	private IActionable HLLHIOAGCEJ()
	{
		if (JDAFPKOHJPC() is IActionable result)
		{
			return result;
		}
		if (GetSelectedItemInstance() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public Slot MAFFKOAAANA(int AHDCDCICADP)
	{
		return slots[AHDCDCICADP];
	}

	public int CMAOFAPMLEO()
	{
		return GAANHLBHAKM;
	}

	public void GLINKPIHPFH(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	private IActionable LIIKCJKNGNN()
	{
		if (GetSelectedItem() is IActionable result)
		{
			return result;
		}
		if (GetSelectedItemInstance() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public int JGJJDOHBEMJ()
	{
		return GAANHLBHAKM;
	}

	public bool PMPJOFHBIED(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (LKLCLBMMDMF() && SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = APOHLHBNEOG();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return false;
			}
		}
		return false;
	}

	private IActionable MBOHNGNNCED()
	{
		if (GetSelectedItem() is IActionable result)
		{
			return result;
		}
		if (GetSelectedItemInstance() is IActionable result2)
		{
			return result2;
		}
		return null;
	}

	public ItemInstance KFDBMPDPJBF()
	{
		if (slots[CMHNEHPIBDN()].itemInstance != null)
		{
			return slots[NLIEGDDKKIJ()].itemInstance;
		}
		return null;
	}

	public void KLKKIGKPGMK(MonoBehaviour NPJDIDHOEFB)
	{
		IILDLOOCPKN.Remove(NPJDIDHOEFB);
	}

	private static ActionBarInventory NCLHALJNBFL(int JFNMCNCHMEO)
	{
		return CFFBMLNPMJD[JFNMCNCHMEO];
	}

	public void DHGALNNGPLG()
	{
		IILDLOOCPKN.Clear();
	}

	public void ECHDABJBKJD()
	{
		IILDLOOCPKN.Clear();
	}

	[SpecialName]
	private bool CBLKCKNBCFL()
	{
		if (PiratesGameManager.Playing)
		{
			return true;
		}
		if (FishCuttingGameManager.Playing)
		{
			return true;
		}
		if (BathhouseGameManager.Playing)
		{
			return false;
		}
		return IILDLOOCPKN.Count == 0;
	}

	public static ActionBarInventory ADHIHCNAKFP(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return GNDKIDIANOL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return GNDKIDIANOL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Items/item_name_1039" + JFNMCNCHMEO));
		return null;
	}

	public static ActionBarInventory BNMEANGDMIP(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return GNDKIDIANOL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("" + JFNMCNCHMEO));
		return null;
	}

	public Item JDAFPKOHJPC()
	{
		if (slots[JDBAHDFLONL()] != null)
		{
			if (slots[FDOFGNEDJMK()].itemInstance != null)
			{
				return slots[CMAOFAPMLEO()].itemInstance.AFOACBIHNCL();
			}
			return null;
		}
		return null;
	}

	private void Update()
	{
		if (playerNum == 1 || (GameManager.LocalCoop() && playerNum <= 2))
		{
			OIOIODLJEGF(playerNum);
		}
	}

	public bool KBDPMOKNOLP(int JIIGOACEIKL, int BKFCHPEAJEI)
	{
		if (IMNBGNDBFDB() && SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			IActionable actionable = KMOPCJGAAGK();
			if (actionable != null)
			{
				if (BKFCHPEAJEI == 1)
				{
					actionable.ActionEnd(JIIGOACEIKL);
				}
				else
				{
					actionable.SecondActionEnd(JIIGOACEIKL);
				}
				return true;
			}
		}
		return true;
	}
}
