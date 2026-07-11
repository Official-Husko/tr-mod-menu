using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

public class BanquetCustomer : CustomerBase, IProximity, IHoverable, IInteractable
{
	[CompilerGenerated]
	private sealed class BLMFHGJLDMF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BanquetCustomer _003C_003E4__this;

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
		public BLMFHGJLDMF(int _003C_003E1__state)
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
			BanquetCustomer banquetCustomer = _003C_003E4__this;
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
				if (!BanquetOrdersManager.instance.pauseOrders)
				{
					banquetCustomer.requesting = true;
					BanquetOrdersManager.instance.AddTableOrder(banquetCustomer);
				}
				banquetCustomer.requestingStarted = false;
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

	[SerializeField]
	private int id;

	public Animator behaviour;

	public BanquetCustomerState banquetCustomerState;

	public float timeEatingMin;

	public float timeEatingMax;

	public float requestAgainProbability;

	public float requestOrderPatience;

	public bool drinking;

	private bool FDMHEDDIGPJ;

	public bool eatingAtLeftTable = true;

	public Transform positionToServe;

	public Transform sitDrinkEat;

	public Transform pointsPosition;

	public bool requestingStarted;

	public bool requesting;

	public Canvas canvasBubbles;

	public RectTransform bubble;

	public Image drink;

	public Image drinkColor;

	public GameObject mug;

	public GameObject spoon;

	protected static readonly int IIFLFAJODIL = AnimatorParameterCache.p_Waiting;

	protected static readonly int IIMAJJLHICE = AnimatorParameterCache.p_ServingCustomer;

	protected static readonly int BKOCCBLGHPB = AnimatorParameterCache.p_TakingDrink;

	protected static readonly int NHBJKHNBDPH = AnimatorParameterCache.p_ServingTableOrder;

	protected static readonly int LPMPJEGOJCP = AnimatorParameterCache.p_EatingAtTable;

	protected static readonly int DKLHFFBKEAG = AnimatorParameterCache.p_OrderInTable;

	public bool BGHCJHPNKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool LCMAHJCIOIP(int JIIGOACEIKL)
	{
		if (banquetCustomerState == (BanquetCustomerState)5 && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI())
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (EBLGEBFLKGM(pEHGODFBPBH, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
			{
				return false;
			}
		}
		return false;
	}

	public void AKEKMPGHJPL(int PEHGODFBPBH, bool NLCDDFDGACP, ItemInstance HPHELAPHAHN, bool FDMHEDDIGPJ)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		ChangeState(BanquetCustomerState.Inactive, KCNFNAICINO: false);
		SetCurrentItem(HPHELAPHAHN);
		if (BanquetEvent.GGPPFKPOCLL)
		{
			if (NLCDDFDGACP)
			{
				int aEDEJBNFGMD = (FDMHEDDIGPJ ? 1 : (EventsManager.KDMLGMKLGOB() ? 1 : (-1)));
				ChallengePointsSystem.GIOJGGACIEH(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
			}
			else
			{
				ChallengePointsSystem.ACCFIMLJGOO(0, Vector2.op_Implicit(pointsPosition.position));
			}
		}
	}

	public bool CCGCKGILGJK(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == (BanquetCustomerState)4 && currentRequest != null)
		{
			return INFBPILDPFG(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return false;
	}

	public bool BBPIPCMFAMB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && banquetCustomerState == BanquetCustomerState.OrderInTable)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Serve"));
			return true;
		}
		return false;
	}

	public bool IAFJNPGMBPO(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == BanquetCustomerState.Inactive && currentRequest != null)
		{
			return INFBPILDPFG(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return false;
	}

	public void KMAPBDCGIDK(int JIIGOACEIKL)
	{
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	public bool BHLKEMIONKG(int JIIGOACEIKL)
	{
		if (banquetCustomerState == (BanquetCustomerState)5 && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI())
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (FBGEMHMCIMG(pEHGODFBPBH, NLCDDFDGACP: false, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
			{
				return false;
			}
		}
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void BAECGGFGEDM(ItemInstance DEKHMHDKLLD, bool GIMHPAANCDH)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)this).transform);
		}
	}

	public bool DECOJGDAFNH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && banquetCustomerState == (BanquetCustomerState)7)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Idle"));
			return true;
		}
		return true;
	}

	public bool INFBPILDPFG(int PEHGODFBPBH, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Tray DOGOFILIHPJ)
	{
		if (OnlineManager.HHDBMDMFEMP() && Time.time < JHOPNDGOKDD + 111f)
		{
			return true;
		}
		FDMHEDDIGPJ = NABCJBPDMJI(HPHELAPHAHN, DOGOFILIHPJ);
		if (OnlineManager.MasterOrOffline())
		{
			EFNACNKJCDG(PEHGODFBPBH, NLCDDFDGACP, HPHELAPHAHN, FDMHEDDIGPJ);
		}
		else
		{
			OnlineBanquetEventManager.instance.EKDIIPAJPDB(id, HPHELAPHAHN as FoodInstance, FDMHEDDIGPJ);
			JHOPNDGOKDD = Time.time;
		}
		if (NLCDDFDGACP && !FDMHEDDIGPJ)
		{
			Sound.BNBMNOMFFBE().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickNeg));
		}
		return false;
	}

	public void EGBOBCAAAEH(int JIIGOACEIKL)
	{
	}

	private bool NABCJBPDMJI(ItemInstance HPHELAPHAHN, Tray DOGOFILIHPJ)
	{
		if (banquetCustomerState == BanquetCustomerState.OrderInTable)
		{
			if (DOGOFILIHPJ != null && DOGOFILIHPJ.MEODNPFJDMH(HPHELAPHAHN.LHBPOPOIFLE()))
			{
				return true;
			}
			if (DOGOFILIHPJ.GCJDPMOAGKP())
			{
				DOGOFILIHPJ.MHBHHNCFOEG(DOGOFILIHPJ.currentDrinks[0]);
			}
		}
		return false;
	}

	public void FFFAMACMKLI(int JIIGOACEIKL)
	{
	}

	private void CGPEKLPANFD(ItemInstance DEKHMHDKLLD, bool GIMHPAANCDH)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)this).transform);
		}
	}

	public bool OHGLJCKNBFB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && GDOPOFNFLEB(JIIGOACEIKL) && banquetCustomerState == BanquetCustomerState.LENGTH)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("UI"));
			return true;
		}
		return true;
	}

	public bool EBLGEBFLKGM(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == (BanquetCustomerState)5 && currentRequest != null)
		{
			return FPIANJENPJL(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return true;
	}

	private void JBDDDEIANCO(ItemInstance DEKHMHDKLLD, bool GIMHPAANCDH)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)this).transform);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (banquetCustomerState == BanquetCustomerState.OrderInTable && currentRequest != null)
		{
			if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				return PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.GCJDPMOAGKP();
			}
			return false;
		}
		return false;
	}

	public void ChangeState(BanquetCustomerState OPGEOAFCIGE, bool KCNFNAICINO = true)
	{
		switch (OPGEOAFCIGE)
		{
		case BanquetCustomerState.EatingAtTable:
			behaviour.SetTrigger(LPMPJEGOJCP);
			break;
		case BanquetCustomerState.OrderInTable:
			behaviour.SetTrigger(DKLHFFBKEAG);
			break;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineBanquetEventManager.instance.SendBanquetCustomerState(id, OPGEOAFCIGE);
		}
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		if (banquetCustomerState == BanquetCustomerState.EatingAtTable && currentRequest != null)
		{
			if (!DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM())
			{
				return PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.PPOMDGNCBCE();
			}
			return false;
		}
		return true;
	}

	public void CompleteItemTransaction(int PEHGODFBPBH, bool NLCDDFDGACP, ItemInstance HPHELAPHAHN, bool FDMHEDDIGPJ)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		ChangeState(BanquetCustomerState.EatingAtTable);
		SetCurrentItem(HPHELAPHAHN);
		if (BanquetEvent.GGPPFKPOCLL)
		{
			if (NLCDDFDGACP)
			{
				int aEDEJBNFGMD = (FDMHEDDIGPJ ? 1 : ((!EventsManager.IsLowestDifficulty()) ? (-1) : 0));
				ChallengePointsSystem.AddPlayerPoints(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
			}
			else
			{
				ChallengePointsSystem.AddOpponentPoints(1, Vector2.op_Implicit(pointsPosition.position));
			}
		}
	}

	public bool FOBIOBIABJF(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == (BanquetCustomerState)6 && currentRequest != null)
		{
			return INFBPILDPFG(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void JKMLKBPAHHO(int JIIGOACEIKL)
	{
	}

	public void MCBHIOOAIAM(int JIIGOACEIKL)
	{
	}

	public bool OICEBEEANAI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OAFFHDOIDKO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	public bool OLAELPBFNEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void NHHLECPCOFB(int PEHGODFBPBH, bool NLCDDFDGACP, ItemInstance HPHELAPHAHN, bool FDMHEDDIGPJ)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		ChangeState(BanquetCustomerState.EatingAtTable, KCNFNAICINO: false);
		SetCurrentItem(HPHELAPHAHN);
		if (BanquetEvent.GGPPFKPOCLL)
		{
			if (NLCDDFDGACP)
			{
				int aEDEJBNFGMD = (FDMHEDDIGPJ ? 1 : ((!EventsManager.FMCAMLDJGNO()) ? (-1) : 0));
				ChallengePointsSystem.MHGPEIFMIDA(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
			}
			else
			{
				ChallengePointsSystem.ACCFIMLJGOO(0, Vector2.op_Implicit(pointsPosition.position));
			}
		}
	}

	public bool FPIANJENPJL(int PEHGODFBPBH, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Tray DOGOFILIHPJ)
	{
		if (OnlineManager.ClientOnline() && Time.time < JHOPNDGOKDD + 1505f)
		{
			return true;
		}
		FDMHEDDIGPJ = NABCJBPDMJI(HPHELAPHAHN, DOGOFILIHPJ);
		if (OnlineManager.PGAGDFAEEFB())
		{
			AKEKMPGHJPL(PEHGODFBPBH, NLCDDFDGACP, HPHELAPHAHN, FDMHEDDIGPJ);
		}
		else
		{
			OnlineBanquetEventManager.instance.SendCompleteItemTransactionBanquetCustomer(id, HPHELAPHAHN as FoodInstance, FDMHEDDIGPJ);
			JHOPNDGOKDD = Time.time;
		}
		if (NLCDDFDGACP && !FDMHEDDIGPJ)
		{
			Sound.DIHCEGINELM().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg), HOMFPAFAOGD: true, null, null, 251f);
		}
		return true;
	}

	public void RequestTableOrder(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		BAECGGFGEDM(DNLMCHDOMOK, GIMHPAANCDH: true);
		if (currentRequest != null)
		{
			requestingStarted = true;
			((MonoBehaviour)this).StartCoroutine(HHJNGGGMPPA());
			npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: true);
			((Behaviour)canvasBubbles).enabled = true;
			((Component)bubble).gameObject.SetActive(true);
			CustomerOrder.UpdateSprite(currentRequest, drink, drinkColor, NLOOPHNGMLE: true, ANHLFAANEEA);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineBanquetEventManager.instance.SendRequestTableOrderBanquetCustomer(id, DNLMCHDOMOK as FoodInstance);
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (banquetCustomerState == BanquetCustomerState.OrderInTable && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (ServeCustomer(pEHGODFBPBH, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
			{
				return true;
			}
		}
		return false;
	}

	public bool IBMMEBJBHOE(int JIIGOACEIKL)
	{
		if (banquetCustomerState == BanquetCustomerState.LENGTH && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).KNFEPKBIHND())
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (FBGEMHMCIMG(pEHGODFBPBH, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
			{
				return false;
			}
		}
		return false;
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
	}

	private IEnumerator NIMMIBJANNB()
	{
		return new BLMFHGJLDMF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AJBMKOKEPEE(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		JBDDDEIANCO(DNLMCHDOMOK, GIMHPAANCDH: false);
		if (currentRequest != null)
		{
			requestingStarted = true;
			((MonoBehaviour)this).StartCoroutine(BCHLBCFAFLI());
			npc.animationBase.SetBool("Player/Bark/Farm/BuzzHouse_Night", EGFGNGJGBOP: true);
			((Behaviour)canvasBubbles).enabled = true;
			((Component)bubble).gameObject.SetActive(false);
			CustomerOrder.CNIAPGKBKOI(currentRequest, drink, drinkColor, NLOOPHNGMLE: true, ANHLFAANEEA);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineBanquetEventManager.instance.BEKGMECCKKG(id, DNLMCHDOMOK as FoodInstance);
		}
	}

	private void FMOCBEOJCCL(ItemInstance DEKHMHDKLLD, bool GIMHPAANCDH)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)this).transform);
		}
	}

	public bool HCCEEPOKGAH(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == BanquetCustomerState.EatingAtTable && currentRequest != null)
		{
			return ServeCustomerItem(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return true;
	}

	public void GCKMHJLIGGJ()
	{
		requestingStarted = true;
		requesting = true;
		((Component)bubble).gameObject.SetActive(true);
		npc.animationBase.CGEADHOLHCH("Items/item_description_1193", EGFGNGJGBOP: false);
		BanquetOrdersManager.instance.FMBEJCJJGCJ(this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineBanquetEventManager.instance.SendRemoveTableOrderBanquetCustomer(id);
		}
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool KNGDGMPGEBH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MAGIGBCGLGK(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == BanquetCustomerState.OrderInTable && currentRequest != null)
		{
			return INFBPILDPFG(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return true;
	}

	public bool EOFMNLMKMAI(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == BanquetCustomerState.EatingAtTable && currentRequest != null)
		{
			return FPIANJENPJL(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return false;
	}

	public void KOANHOFAJMA(int JIIGOACEIKL)
	{
	}

	public bool HDLNAIBNIHM(int JIIGOACEIKL)
	{
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private IEnumerator BCHLBCFAFLI()
	{
		yield return CommonReferences.wait08;
		if (!BanquetOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			BanquetOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public bool LGDMGLJCBJM(int JIIGOACEIKL)
	{
		if (banquetCustomerState == BanquetCustomerState.LENGTH && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (HCCEEPOKGAH(pEHGODFBPBH, NLCDDFDGACP: true, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
			{
				return true;
			}
		}
		return false;
	}

	public void CNJGEALHFEL(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private IEnumerator LKIMGJANLHF()
	{
		yield return CommonReferences.wait08;
		if (!BanquetOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			BanquetOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public void LOHACMDOBBG(int JIIGOACEIKL)
	{
	}

	public bool NEJMAFFPIBL(int JIIGOACEIKL)
	{
		if (banquetCustomerState == (BanquetCustomerState)4 && currentRequest != null)
		{
			if (!DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE())
			{
				return PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.GCJDPMOAGKP();
			}
			return false;
		}
		return true;
	}

	public bool JAELLHFFLKO(int JIIGOACEIKL)
	{
		if (banquetCustomerState == BanquetCustomerState.LENGTH && !DecorationMode.GetPlayer(JIIGOACEIKL).IDPGEBNGDJD())
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (FOBIOBIABJF(pEHGODFBPBH, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
			{
				return false;
			}
		}
		return false;
	}

	public bool DFHNFGMFGLH(int JIIGOACEIKL)
	{
		if (banquetCustomerState == BanquetCustomerState.EatingAtTable && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).KNFEPKBIHND())
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (MAGIGBCGLGK(pEHGODFBPBH, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
			{
				return true;
			}
		}
		return true;
	}

	public bool BIBMEENGOJF(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == BanquetCustomerState.EatingAtTable && currentRequest != null)
		{
			return INFBPILDPFG(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return true;
	}

	private IEnumerator HHJNGGGMPPA()
	{
		yield return CommonReferences.wait08;
		if (!BanquetOrdersManager.instance.pauseOrders)
		{
			requesting = true;
			BanquetOrdersManager.instance.AddTableOrder(this);
		}
		requestingStarted = false;
	}

	public void RemoveTableOrder()
	{
		requestingStarted = false;
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: false);
		BanquetOrdersManager.instance.RemoveTableOrder(this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineBanquetEventManager.instance.SendRemoveTableOrderBanquetCustomer(id);
		}
	}

	public bool LCABCHMEDOK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && GDOPOFNFLEB(JIIGOACEIKL) && banquetCustomerState == BanquetCustomerState.LENGTH)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
			return true;
		}
		return false;
	}

	public bool BEBIPNCCEMH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && banquetCustomerState == (BanquetCustomerState)4)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("a"));
			return false;
		}
		return true;
	}

	public void PLJMJBPHNLE(BanquetCustomerState OPGEOAFCIGE, bool KCNFNAICINO = true)
	{
		switch (OPGEOAFCIGE)
		{
		case BanquetCustomerState.EatingAtTable:
			behaviour.SetTrigger(LPMPJEGOJCP);
			break;
		case (BanquetCustomerState)4:
			behaviour.SetTrigger(DKLHFFBKEAG);
			break;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineBanquetEventManager.instance.SendBanquetCustomerState(id, OPGEOAFCIGE);
		}
	}

	public bool ServeCustomer(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == BanquetCustomerState.OrderInTable && currentRequest != null)
		{
			return ServeCustomerItem(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return false;
	}

	private void ADNDOGMEMJP(ItemInstance DEKHMHDKLLD, bool GIMHPAANCDH)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD != null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)this).transform);
		}
	}

	public bool FBGEMHMCIMG(int PEHGODFBPBH, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null)
	{
		if (currentRequest != null && banquetCustomerState == BanquetCustomerState.EatingAtTable && currentRequest != null)
		{
			return INFBPILDPFG(PEHGODFBPBH, currentRequest, NLCDDFDGACP, DOGOFILIHPJ);
		}
		return false;
	}

	public void HLEJMAOOBKC()
	{
		requestingStarted = true;
		requesting = true;
		((Component)bubble).gameObject.SetActive(true);
		npc.animationBase.CGEADHOLHCH("Mine", EGFGNGJGBOP: true);
		BanquetOrdersManager.instance.FIEOGHHPFAL(this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineBanquetEventManager.instance.KAHDLGHDLHG(id);
		}
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (banquetCustomerState == (BanquetCustomerState)6 && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DBAEGBDEPFK())
		{
			int pEHGODFBPBH = (OnlineManager.PlayingOnline() ? Bed.instance.numInstance : JIIGOACEIKL);
			if (IAFJNPGMBPO(pEHGODFBPBH, NLCDDFDGACP: true, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
			{
				return false;
			}
		}
		return true;
	}

	public void EFNACNKJCDG(int PEHGODFBPBH, bool NLCDDFDGACP, ItemInstance HPHELAPHAHN, bool FDMHEDDIGPJ)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		currentRequest = null;
		PLJMJBPHNLE(BanquetCustomerState.Inactive);
		SetCurrentItem(HPHELAPHAHN);
		if (BanquetEvent.GGPPFKPOCLL)
		{
			if (NLCDDFDGACP)
			{
				int aEDEJBNFGMD = ((!FDMHEDDIGPJ) ? (EventsManager.OENIOCAIPMP() ? 1 : (-1)) : 0);
				ChallengePointsSystem.GDKKJIHKOMB(PEHGODFBPBH, aEDEJBNFGMD, FDMHEDDIGPJ, Vector2.op_Implicit(pointsPosition.position));
			}
			else
			{
				ChallengePointsSystem.OCBEBEDGKEN(0, Vector2.op_Implicit(pointsPosition.position));
			}
		}
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public void MEMHBEIAICP()
	{
		requestingStarted = true;
		requesting = false;
		((Component)bubble).gameObject.SetActive(true);
		npc.animationBase.SetBool("Error_NoCatFood", EGFGNGJGBOP: true, HALNIEBONKH: true);
		BanquetOrdersManager.instance.EOMJBBGJLKE(this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineBanquetEventManager.instance.DJNFIGEDDHN(id);
		}
	}

	public bool ServeCustomerItem(int PEHGODFBPBH, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Tray DOGOFILIHPJ)
	{
		if (OnlineManager.ClientOnline() && Time.time < JHOPNDGOKDD + 1f)
		{
			return false;
		}
		FDMHEDDIGPJ = NABCJBPDMJI(HPHELAPHAHN, DOGOFILIHPJ);
		if (OnlineManager.MasterOrOffline())
		{
			CompleteItemTransaction(PEHGODFBPBH, NLCDDFDGACP, HPHELAPHAHN, FDMHEDDIGPJ);
		}
		else
		{
			OnlineBanquetEventManager.instance.SendCompleteItemTransactionBanquetCustomer(id, HPHELAPHAHN as FoodInstance, FDMHEDDIGPJ);
			JHOPNDGOKDD = Time.time;
		}
		if (NLCDDFDGACP && !FDMHEDDIGPJ)
		{
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg));
		}
		return false;
	}
}
