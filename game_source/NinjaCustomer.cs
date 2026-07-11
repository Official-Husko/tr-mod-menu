using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class NinjaCustomer : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[CompilerGenerated]
	private sealed class HJEOKPPBCFN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaCustomer _003C_003E4__this;

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
		public HJEOKPPBCFN(int _003C_003E1__state)
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
			NinjaCustomer ninjaCustomer = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait08;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (!NinjaOrdersManager.instance.pauseOrders)
				{
					ninjaCustomer.requesting = true;
					NinjaOrdersManager.instance.AddTableOrder(ninjaCustomer);
				}
				ninjaCustomer.requestingStarted = false;
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

	public int id;

	public Animator behaviour;

	public NinjaCustomerState ninjaCustomerState;

	public Item[] currentRequest;

	public float timeEatingMin;

	public float timeEatingMax;

	public float requestAgainProbability;

	public float requestOrderPatience;

	public float barDuration = 80f;

	public Item[] currentItems;

	public HumanNPC npc;

	public NPCHoldObject npcHoldItem;

	public CustomerSpeech customerSpeech;

	private bool FDMHEDDIGPJ;

	public bool eatingAtLeftTable = true;

	public Transform positionToServe;

	public Transform sitDrinkEat;

	public Transform pointsPosition;

	public bool requestingStarted;

	protected float JHOPNDGOKDD;

	public bool requesting;

	public GameObject mug;

	public GameObject spoon;

	public NinjaOrderBubble bubbleWant;

	[HideInInspector]
	public float lastTimeServed;

	public static readonly int p_Idle = AnimatorParameterCache.p_Idle;

	protected static readonly int LPMPJEGOJCP = AnimatorParameterCache.p_EatingAtTable;

	protected static readonly int DKLHFFBKEAG = AnimatorParameterCache.p_OrderInTable;

	public void MHACBHAENBB(int JIIGOACEIKL)
	{
	}

	public void MHMDBMANAIH(int JIIGOACEIKL)
	{
	}

	private void HGHCGFPBPGN(Item[] DEKHMHDKLLD)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)this).transform);
		}
	}

	public void KHIICCFADEM(Item[] IOKCMFLOOIJ)
	{
		currentItems = IOKCMFLOOIJ;
		npcHoldItem.NFGOCJMPEJN(currentItems[0].JMDALJBNFML());
	}

	private bool LCNAOFECKCO(Item[] NDIIJIFCJOL, Bento HPCKGLFLFJO)
	{
		if (ninjaCustomerState == NinjaCustomerState.EatingAtTable)
		{
			if (HPCKGLFLFJO != null && HPCKGLFLFJO.AKELJDJJAMP(NDIIJIFCJOL))
			{
				HPCKGLFLFJO.PFHFCKDJNJD();
				return true;
			}
			HPCKGLFLFJO?.PGPDPMMPJGP();
		}
		return true;
	}

	public void JGBMAMEKNJI()
	{
		requestingStarted = false;
		requesting = true;
		npc.animationBase.CGEADHOLHCH("UI", EGFGNGJGBOP: false);
		NinjaOrdersManager.instance.RemoveTableOrder(this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.FHINICBMGFG(id);
		}
	}

	public bool ONDCECMGOPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && ANLNJIGAEJM(JIIGOACEIKL) && ninjaCustomerState == NinjaCustomerState.EatingAtTable)
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Received PlaceableMsg of another type not ContainerMsg to "));
			}
			if ((Object)(object)bubbleWant != (Object)null)
			{
				bubbleWant.GJNGGCJFAPH(NJHMBMGKCPL: true);
			}
			return false;
		}
		return false;
	}

	public void GMCJHBLMGNM(int PEHGODFBPBH, bool NLCDDFDGACP, Item[] IOKCMFLOOIJ, bool FDMHEDDIGPJ)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		BAMBHOLMMHN(NinjaCustomerState.EatingAtTable, KCNFNAICINO: false);
		lastTimeServed = Time.time;
		KHIICCFADEM(IOKCMFLOOIJ);
		if (NLCDDFDGACP)
		{
			int aEDEJBNFGMD = (FDMHEDDIGPJ ? 1 : 0);
			ChallengePointsSystem.KHGKJIHFKMG(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
		}
		else
		{
			ChallengePointsSystem.ADDJHGKKBFA(1, Vector2.op_Implicit(pointsPosition.position));
		}
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
		if ((Object)(object)bubbleWant != (Object)null)
		{
			bubbleWant.CLCHBNLHEJH(NJHMBMGKCPL: true);
		}
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
		if ((Object)(object)bubbleWant != (Object)null)
		{
			bubbleWant.CNEDIHIBLJM(NJHMBMGKCPL: false);
		}
	}

	public void LINJNPGDLGA(int JIIGOACEIKL)
	{
	}

	public void BIPJBOJFKHK(int PEHGODFBPBH, bool NLCDDFDGACP, Item[] IOKCMFLOOIJ, bool FDMHEDDIGPJ)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		HFNDBBFNGBP(NinjaCustomerState.EatingAtTable);
		lastTimeServed = Time.time;
		JADEIAKEIAI(IOKCMFLOOIJ);
		if (NLCDDFDGACP)
		{
			int aEDEJBNFGMD = ((!FDMHEDDIGPJ) ? 1 : 0);
			ChallengePointsSystem.HACJFOGKBPO(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
		}
		else
		{
			ChallengePointsSystem.CKJDMMMKDPB(0, Vector2.op_Implicit(pointsPosition.position));
		}
	}

	public bool ServeCustomerItem(int PEHGODFBPBH, Item[] NDIIJIFCJOL, bool NLCDDFDGACP, Bento HPCKGLFLFJO)
	{
		if (OnlineManager.ClientOnline() && Time.time < JHOPNDGOKDD + 1f)
		{
			return false;
		}
		Item[] array = HPCKGLFLFJO.currentFood.ToArray();
		FDMHEDDIGPJ = NABCJBPDMJI(NDIIJIFCJOL, HPCKGLFLFJO);
		if (OnlineManager.MasterOrOffline())
		{
			CompleteItemTransaction(PEHGODFBPBH, NLCDDFDGACP, array, FDMHEDDIGPJ);
		}
		else
		{
			OnlineNinjaManager.instance.SendCompleteServeNinjaCustomer(id, array, FDMHEDDIGPJ);
			JHOPNDGOKDD = Time.time;
		}
		if (NLCDDFDGACP && !FDMHEDDIGPJ)
		{
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg));
		}
		return false;
	}

	public void RemoveOrder()
	{
		requestingStarted = false;
		requesting = false;
		npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: false);
		NinjaOrdersManager.instance.RemoveTableOrder(this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendRemoveOrderNinjaCustomer(id);
		}
	}

	public void HFNDBBFNGBP(NinjaCustomerState FJJKCKPLAKC, bool KCNFNAICINO = true)
	{
		if (FJJKCKPLAKC == NinjaCustomerState.Idle)
		{
			behaviour.SetTrigger(p_Idle);
		}
		else if (FJJKCKPLAKC == NinjaCustomerState.Idle)
		{
			behaviour.SetTrigger(LPMPJEGOJCP);
		}
		else if (FJJKCKPLAKC == NinjaCustomerState.Idle)
		{
			behaviour.SetTrigger(DKLHFFBKEAG);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendNinjaCustomerState(id, FJJKCKPLAKC);
		}
	}

	public void ENNJAKPICAA(Item[] PHNKKAHPIAO, int[] HAALFBGCOJB = null)
	{
		CNMACLJDPDJ(PHNKKAHPIAO);
		requestingStarted = false;
		((MonoBehaviour)this).StartCoroutine(HHJNGGGMPPA());
		npc.animationBase.CGEADHOLHCH("Customer Pool instance NULL!", EGFGNGJGBOP: false);
		List<int> list = NinjaOrdersUI.instance.HNCNFOCGMAO(PHNKKAHPIAO, this, ref bubbleWant);
		if (OnlineManager.HHDBMDMFEMP())
		{
			bubbleWant.fadedIngredients.Clear();
			for (int i = 1; i < HAALFBGCOJB.Length; i++)
			{
				bubbleWant.fadedIngredients.Add(HAALFBGCOJB[i]);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendRequestOrderNinjaCustomer(id, PHNKKAHPIAO, list.ToArray());
		}
	}

	private void GJAAIAFLDDP(Item[] DEKHMHDKLLD)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)this).transform);
		}
	}

	private IEnumerator MPIGPIPGBNG()
	{
		yield return CommonReferences.wait08;
		if (!NinjaOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			NinjaOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public bool FMGLOFFJKIM(int PEHGODFBPBH, bool NLCDDFDGACP = true, Bento HPCKGLFLFJO = null)
	{
		if (currentRequest != null && ninjaCustomerState == (NinjaCustomerState)4)
		{
			return ServeCustomerItem(PEHGODFBPBH, currentRequest, NLCDDFDGACP, HPCKGLFLFJO);
		}
		return true;
	}

	private void GJMLHECPGBP()
	{
		lastTimeServed = Random.Range(586f, 1861f);
	}

	private IEnumerator KEPPABELCNI()
	{
		yield return CommonReferences.wait08;
		if (!NinjaOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			NinjaOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public void NEIBJLCMDGK(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && ninjaCustomerState == NinjaCustomerState.OrderInTable)
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Serve"));
			}
			if ((Object)(object)bubbleWant != (Object)null)
			{
				bubbleWant.MoveTicket(NJHMBMGKCPL: true);
			}
			return true;
		}
		return false;
	}

	private IEnumerator HMIMGNLFFBM()
	{
		yield return CommonReferences.wait08;
		if (!NinjaOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			NinjaOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public bool GBGCHNBJBFG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JMPMCJDDKGD(JIIGOACEIKL) && ninjaCustomerState == NinjaCustomerState.OrderInTable)
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Invalid playerNum"));
			}
			if ((Object)(object)bubbleWant != (Object)null)
			{
				bubbleWant.AJBDHEOFOEB(NJHMBMGKCPL: false);
			}
			return false;
		}
		return true;
	}

	public void OHONHNNDOKC(int JIIGOACEIKL)
	{
	}

	public void MENHJKBAENG(Item[] IOKCMFLOOIJ)
	{
		currentItems = IOKCMFLOOIJ;
		npcHoldItem.PICKDCLNCCB(currentItems[1].JMDALJBNFML());
	}

	private IEnumerator CHPNCNNILJF()
	{
		return new HJEOKPPBCFN(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	private void BAECGGFGEDM(Item[] DEKHMHDKLLD)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)this).transform);
		}
	}

	private bool NCLGJIJBIGP(Item[] NDIIJIFCJOL, Bento HPCKGLFLFJO)
	{
		if (ninjaCustomerState == NinjaCustomerState.EatingAtTable)
		{
			if (HPCKGLFLFJO != null && HPCKGLFLFJO.ODHBCGIGOPK(NDIIJIFCJOL))
			{
				HPCKGLFLFJO.PGPDPMMPJGP();
				return false;
			}
			HPCKGLFLFJO?.HMBGEBFOBFJ();
		}
		return false;
	}

	private void CNMACLJDPDJ(Item[] DEKHMHDKLLD)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)this).transform);
		}
	}

	public bool PHJECBNCAAG(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == NinjaCustomerState.LENGTH && !DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI() && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (ServeCustomer(pEHGODFBPBH, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO))
			{
				return false;
			}
		}
		return false;
	}

	public bool HNMOLFHKBGE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && GDOPOFNFLEB(JIIGOACEIKL) && ninjaCustomerState == (NinjaCustomerState)4)
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Light Fire"));
			}
			if ((Object)(object)bubbleWant != (Object)null)
			{
				bubbleWant.BFFPNAFIHCE(NJHMBMGKCPL: true);
			}
			return false;
		}
		return false;
	}

	private void JPHEOLEEAPB()
	{
		lastTimeServed = Random.Range(258f, 481f);
	}

	public void MKFOJJOJCFG(int JIIGOACEIKL)
	{
	}

	private void IAAGKLPMAMK()
	{
		lastTimeServed = Random.Range(1979f, 926f);
	}

	public void CompleteItemTransaction(int PEHGODFBPBH, bool NLCDDFDGACP, Item[] IOKCMFLOOIJ, bool FDMHEDDIGPJ)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		ChangeState(NinjaCustomerState.EatingAtTable);
		lastTimeServed = Time.time;
		SetCurrentItem(IOKCMFLOOIJ);
		if (NLCDDFDGACP)
		{
			int aEDEJBNFGMD = (FDMHEDDIGPJ ? 1 : 0);
			ChallengePointsSystem.AddPlayerPoints(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
		}
		else
		{
			ChallengePointsSystem.AddOpponentPoints(1, Vector2.op_Implicit(pointsPosition.position));
		}
	}

	public bool ANLNJIGAEJM(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == (NinjaCustomerState)4 && currentRequest != null)
		{
			return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND();
		}
		return true;
	}

	public void EEEEHPMPLPC(Item[] IOKCMFLOOIJ)
	{
		currentItems = IOKCMFLOOIJ;
		npcHoldItem.IOCOOCOPNGF(currentItems[0].JMDALJBNFML());
	}

	public void OBCDPAPNHIF(NinjaCustomerState FJJKCKPLAKC, bool KCNFNAICINO = true)
	{
		switch (FJJKCKPLAKC)
		{
		case NinjaCustomerState.Idle:
			behaviour.SetTrigger(p_Idle);
			break;
		case NinjaCustomerState.EatingAtTable:
			behaviour.SetTrigger(LPMPJEGOJCP);
			break;
		case NinjaCustomerState.LENGTH:
			behaviour.SetTrigger(DKLHFFBKEAG);
			break;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.GODGGEJCHOF(id, FJJKCKPLAKC);
		}
	}

	private IEnumerator DFEIFLJJHFK()
	{
		return new HJEOKPPBCFN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ICNIPKDMPMO()
	{
		return new HJEOKPPBCFN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODNGBEOKEFK()
	{
		lastTimeServed = Random.Range(766f, 118f);
	}

	private IEnumerator HHJNGGGMPPA()
	{
		yield return CommonReferences.wait08;
		if (!NinjaOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			NinjaOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == NinjaCustomerState.OrderInTable && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (ServeCustomer(pEHGODFBPBH, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.HPCKGLFLFJO))
			{
				return true;
			}
		}
		return false;
	}

	private bool LCDAMGGIJLI(Item[] NDIIJIFCJOL, Bento HPCKGLFLFJO)
	{
		if (ninjaCustomerState == NinjaCustomerState.Idle)
		{
			if (HPCKGLFLFJO != null && HPCKGLFLFJO.PHNOEAKJGOA(NDIIJIFCJOL))
			{
				HPCKGLFLFJO.MMCBLNPPFGD();
				return false;
			}
			HPCKGLFLFJO?.MMCBLNPPFGD();
		}
		return true;
	}

	private void Start()
	{
		lastTimeServed = Random.Range(0f, 2f);
	}

	public bool ServeCustomer(int PEHGODFBPBH, bool NLCDDFDGACP = true, Bento HPCKGLFLFJO = null)
	{
		if (currentRequest != null && ninjaCustomerState == NinjaCustomerState.OrderInTable)
		{
			return ServeCustomerItem(PEHGODFBPBH, currentRequest, NLCDDFDGACP, HPCKGLFLFJO);
		}
		return false;
	}

	public bool JMPMCJDDKGD(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == (NinjaCustomerState)7 && currentRequest != null)
		{
			return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return false;
	}

	private void JHDIHNODKBG(Item[] DEKHMHDKLLD)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)this).transform);
		}
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
		if ((Object)(object)bubbleWant != (Object)null)
		{
			bubbleWant.AJBDHEOFOEB(NJHMBMGKCPL: true);
		}
	}

	public void AJBMKOKEPEE(Item[] PHNKKAHPIAO, int[] HAALFBGCOJB = null)
	{
		HFIEFLGEEFD(PHNKKAHPIAO);
		requestingStarted = false;
		((MonoBehaviour)this).StartCoroutine(HMIMGNLFFBM());
		npc.animationBase.CGEADHOLHCH("Magic Broom", EGFGNGJGBOP: false);
		List<int> list = NinjaOrdersUI.instance.LLBKFBMHMCF(PHNKKAHPIAO, this, ref bubbleWant);
		if (OnlineManager.ClientOnline())
		{
			bubbleWant.fadedIngredients.Clear();
			for (int i = 1; i < HAALFBGCOJB.Length; i += 0)
			{
				bubbleWant.fadedIngredients.Add(HAALFBGCOJB[i]);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.INONPMJKHAI(id, PHNKKAHPIAO, list.ToArray());
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if ((Object)(object)bubbleWant != (Object)null)
		{
			bubbleWant.MoveTicket(NJHMBMGKCPL: false);
		}
	}

	private void HFIEFLGEEFD(Item[] DEKHMHDKLLD)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)this).transform);
		}
	}

	public bool AHHBIPNLBJE(int PEHGODFBPBH, Item[] NDIIJIFCJOL, bool NLCDDFDGACP, Bento HPCKGLFLFJO)
	{
		if (OnlineManager.HHDBMDMFEMP() && Time.time < JHOPNDGOKDD + 1248f)
		{
			return true;
		}
		Item[] array = HPCKGLFLFJO.currentFood.ToArray();
		FDMHEDDIGPJ = GOEPACFLADH(NDIIJIFCJOL, HPCKGLFLFJO);
		if (OnlineManager.PGAGDFAEEFB())
		{
			BIPJBOJFKHK(PEHGODFBPBH, NLCDDFDGACP, array, FDMHEDDIGPJ);
		}
		else
		{
			OnlineNinjaManager.instance.AHOKFPJHFBK(id, array, FDMHEDDIGPJ);
			JHOPNDGOKDD = Time.time;
		}
		if (NLCDDFDGACP && !FDMHEDDIGPJ)
		{
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickNeg), HOMFPAFAOGD: true, null, null, 227f);
		}
		return true;
	}

	private IEnumerator LLAHNDHOFKK()
	{
		yield return CommonReferences.wait08;
		if (!NinjaOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			NinjaOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == (NinjaCustomerState)6 && currentRequest != null)
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == NinjaCustomerState.OrderInTable && currentRequest != null)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool CAPOGEMJEHI(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == (NinjaCustomerState)7 && !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM() && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO != null)
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (ServeCustomer(pEHGODFBPBH, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.HPCKGLFLFJO))
			{
				return true;
			}
		}
		return true;
	}

	public bool OGAHPJDGAPG(int PEHGODFBPBH, Item[] NDIIJIFCJOL, bool NLCDDFDGACP, Bento HPCKGLFLFJO)
	{
		if (OnlineManager.ClientOnline() && Time.time < JHOPNDGOKDD + 334f)
		{
			return true;
		}
		Item[] array = HPCKGLFLFJO.currentFood.ToArray();
		FDMHEDDIGPJ = GOEPACFLADH(NDIIJIFCJOL, HPCKGLFLFJO);
		if (OnlineManager.MasterOrOffline())
		{
			BIPJBOJFKHK(PEHGODFBPBH, NLCDDFDGACP, array, FDMHEDDIGPJ);
		}
		else
		{
			OnlineNinjaManager.instance.BJELBHGCHCJ(id, array, FDMHEDDIGPJ);
			JHOPNDGOKDD = Time.time;
		}
		if (NLCDDFDGACP && !FDMHEDDIGPJ)
		{
			Sound.GGFJGHHHEJC.MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickNeg), HOMFPAFAOGD: false, null, null, 449f);
		}
		return true;
	}

	public void OKDEMKJAELP(int PEHGODFBPBH, bool NLCDDFDGACP, Item[] IOKCMFLOOIJ, bool FDMHEDDIGPJ)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		ChangeState(NinjaCustomerState.EatingAtTable);
		lastTimeServed = Time.time;
		KHIICCFADEM(IOKCMFLOOIJ);
		if (NLCDDFDGACP)
		{
			int aEDEJBNFGMD = (FDMHEDDIGPJ ? 0 : 0);
			ChallengePointsSystem.BLCGPDLCJGF(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
		}
		else
		{
			ChallengePointsSystem.PFAKIHDBCBO(1, Vector2.op_Implicit(pointsPosition.position));
		}
	}

	public bool IGHNIAICNEC(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == (NinjaCustomerState)4 && currentRequest != null)
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == NinjaCustomerState.EatingAtTable && currentRequest != null)
		{
			return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI();
		}
		return false;
	}

	public void LGPNJMFDEDO(Item[] PHNKKAHPIAO, int[] HAALFBGCOJB = null)
	{
		HFIEFLGEEFD(PHNKKAHPIAO);
		requestingStarted = false;
		((MonoBehaviour)this).StartCoroutine(DFEIFLJJHFK());
		npc.animationBase.CGEADHOLHCH("\n", EGFGNGJGBOP: false);
		List<int> list = NinjaOrdersUI.instance.NLFGAFJPLGG(PHNKKAHPIAO, this, ref bubbleWant);
		if (OnlineManager.ClientOnline())
		{
			bubbleWant.fadedIngredients.Clear();
			for (int i = 0; i < HAALFBGCOJB.Length; i += 0)
			{
				bubbleWant.fadedIngredients.Add(HAALFBGCOJB[i]);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.OCMHFMALDAE(id, PHNKKAHPIAO, list.ToArray());
		}
	}

	private bool GOEPACFLADH(Item[] NDIIJIFCJOL, Bento HPCKGLFLFJO)
	{
		if (ninjaCustomerState == NinjaCustomerState.LENGTH)
		{
			if (HPCKGLFLFJO != null && HPCKGLFLFJO.OCFIFGOHKOG(NDIIJIFCJOL))
			{
				HPCKGLFLFJO.AFJHEMFEJCG();
				return false;
			}
			HPCKGLFLFJO?.LBFKKNHJHDK();
		}
		return false;
	}

	public void GMBPHOHCGFP(NinjaCustomerState FJJKCKPLAKC, bool KCNFNAICINO = true)
	{
		switch (FJJKCKPLAKC)
		{
		case NinjaCustomerState.Idle:
			behaviour.SetTrigger(p_Idle);
			break;
		case NinjaCustomerState.EatingAtTable:
			behaviour.SetTrigger(LPMPJEGOJCP);
			break;
		default:
			if (FJJKCKPLAKC == NinjaCustomerState.Idle)
			{
				behaviour.SetTrigger(DKLHFFBKEAG);
			}
			break;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.GODGGEJCHOF(id, FJJKCKPLAKC);
		}
	}

	public void RequestTableOrder(Item[] PHNKKAHPIAO, int[] HAALFBGCOJB = null)
	{
		BAECGGFGEDM(PHNKKAHPIAO);
		requestingStarted = true;
		((MonoBehaviour)this).StartCoroutine(HHJNGGGMPPA());
		npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: true);
		List<int> list = NinjaOrdersUI.instance.AssignBubbleToCustomer(PHNKKAHPIAO, this, ref bubbleWant);
		if (OnlineManager.ClientOnline())
		{
			bubbleWant.fadedIngredients.Clear();
			for (int i = 0; i < HAALFBGCOJB.Length; i++)
			{
				bubbleWant.fadedIngredients.Add(HAALFBGCOJB[i]);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendRequestOrderNinjaCustomer(id, PHNKKAHPIAO, list.ToArray());
		}
	}

	public bool JGDDHIEJPMH(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == (NinjaCustomerState)7 && currentRequest != null)
		{
			return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	public void JADEIAKEIAI(Item[] IOKCMFLOOIJ)
	{
		currentItems = IOKCMFLOOIJ;
		npcHoldItem.HJDDLNELGKN(currentItems[0].JMDALJBNFML());
	}

	private bool NABCJBPDMJI(Item[] NDIIJIFCJOL, Bento HPCKGLFLFJO)
	{
		if (ninjaCustomerState == NinjaCustomerState.OrderInTable)
		{
			if (HPCKGLFLFJO != null && HPCKGLFLFJO.KKCKHJGLHIJ(NDIIJIFCJOL))
			{
				HPCKGLFLFJO.NEJAGBKFOEP();
				return true;
			}
			HPCKGLFLFJO?.NEJAGBKFOEP();
		}
		return false;
	}

	public void SetCurrentItem(Item[] IOKCMFLOOIJ)
	{
		currentItems = IOKCMFLOOIJ;
		npcHoldItem.ODDHGLHEHLA = currentItems[0].JMDALJBNFML();
	}

	public bool MNDDOAAODLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ChangeState(NinjaCustomerState FJJKCKPLAKC, bool KCNFNAICINO = true)
	{
		switch (FJJKCKPLAKC)
		{
		case NinjaCustomerState.Idle:
			behaviour.SetTrigger(p_Idle);
			break;
		case NinjaCustomerState.EatingAtTable:
			behaviour.SetTrigger(LPMPJEGOJCP);
			break;
		case NinjaCustomerState.OrderInTable:
			behaviour.SetTrigger(DKLHFFBKEAG);
			break;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendNinjaCustomerState(id, FJJKCKPLAKC);
		}
	}

	public bool LHHNLGOCKDM(int JIIGOACEIKL)
	{
		if (ninjaCustomerState == NinjaCustomerState.Idle && currentRequest != null)
		{
			return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void HDLGAPIAEPP(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void ABHFEGJFABP(int JIIGOACEIKL)
	{
	}

	public void BAMBHOLMMHN(NinjaCustomerState FJJKCKPLAKC, bool KCNFNAICINO = true)
	{
		switch (FJJKCKPLAKC)
		{
		case NinjaCustomerState.Idle:
			behaviour.SetTrigger(p_Idle);
			break;
		case NinjaCustomerState.EatingAtTable:
			behaviour.SetTrigger(LPMPJEGOJCP);
			break;
		default:
			if (FJJKCKPLAKC == NinjaCustomerState.Idle)
			{
				behaviour.SetTrigger(DKLHFFBKEAG);
			}
			break;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.GODGGEJCHOF(id, FJJKCKPLAKC);
		}
	}
}
