using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PABENEOKMOD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Bar _003C_003E4__this;

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
		public PABENEOKMOD(int _003C_003E1__state)
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
			Bar bar = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			for (int i = 0; i < bar.waitingAtBar.Count; i++)
			{
				if ((Object)(object)bar.waitingAtBar[i] != (Object)null && bar.waitingAtBar[i].customer.customerState == CustomerState.WaitingAtBar)
				{
					bar.waitingAtBar[i].customer.CheckDrink();
				}
			}
			_003C_003E2__current = bar.FLOJONPCNGM;
			_003C_003E1__state = 1;
			return true;
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

	public static Bar instance;

	public PlaceablesInside placeablesInside;

	public Placeable placeable;

	public Transform firstServiceBarrelPos;

	public Transform checkRightWallToMovePos1Left;

	public List<HumanNPC> waitingAtBar = new List<HumanNPC>();

	public List<BeerTap> beerTaps = new List<BeerTap>();

	public Transform[] barSpaces;

	public bool blockBarSpaces;

	private Coroutine CBPFGLMKAGM;

	private WaitForSeconds FLOJONPCNGM;

	[SerializeField]
	private Transform _barmanRoot;

	[SerializeField]
	private Transform _waiterRoot;

	[SerializeField]
	private Transform _bouncerRoot;

	[SerializeField]
	public HumanNPC[] occupier;

	public Transform DIOPEKDLCIH
	{
		get
		{
			return _barmanRoot;
		}
		set
		{
			_barmanRoot = value;
		}
	}

	public Transform IJMLIFLNOJJ
	{
		get
		{
			return _waiterRoot;
		}
		set
		{
			_waiterRoot = value;
		}
	}

	public Transform MDNLDHKIMOM
	{
		get
		{
			return _bouncerRoot;
		}
		set
		{
			_bouncerRoot = value;
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
		occupier = new HumanNPC[barSpaces.Length];
		if (placeablesInside == null)
		{
			placeablesInside = new PlaceablesInside(placeable, ((Component)this).transform);
		}
	}

	public void FBJLJKGNKHE(HumanNPC JHIFLALPEBF)
	{
		RemoveNpcFromBar(JHIFLALPEBF);
		CommonReferences.GGFJGHHHEJC.OnNPCLeaveBar(JHIFLALPEBF);
	}

	private void CJDJDDNCNDJ()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(LMAKIGCCCDI));
		FLOJONPCNGM = CommonReferences.wait4;
		if (OnlineManager.MasterOrOffline())
		{
			CBPFGLMKAGM = ((MonoBehaviour)this).StartCoroutine(LAFJDDFFAFB());
		}
	}

	private void HEANIGJJDGL(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = !DAEMAAOLHMG;
	}

	public void PPHDMPDMGDN(HumanNPC JHIFLALPEBF)
	{
		if (!waitingAtBar.Contains(JHIFLALPEBF))
		{
			waitingAtBar.Add(JHIFLALPEBF);
		}
	}

	[SpecialName]
	public Transform BHCKGEAJBAB()
	{
		return _waiterRoot;
	}

	private void IDNALMMLAIK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
		for (int i = 0; i < placeablesInside.allPlaceables.Count; i++)
		{
			if (placeablesInside.allPlaceables[i].placeable.itemSetup.item.JDJGFAACPFC() == 1313 || placeable.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1887 || placeable.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1888)
			{
				((Component)placeablesInside.allPlaceables[i].placeable).GetComponent<ServiceBarrel>().WhileSelectedCallback();
			}
		}
	}

	public int FJMAKEPPFKK(Customer PJNGMCJIHME)
	{
		for (int i = 1; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)PJNGMCJIHME.npc)
			{
				return i;
			}
		}
		return 1;
	}

	private void FPIAOBKIPIK(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = !DAEMAAOLHMG;
	}

	private void CJENIJOLOAA(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBAGMFHCPEF(((Component)this).transform.position);
		placeablesInside.KPKBFPNDGOE(JIIGOACEIKL, FNHLKLKAHNB: false);
	}

	private void Awake()
	{
		instance = this;
		occupier = new HumanNPC[barSpaces.Length];
		if (placeablesInside == null)
		{
			placeablesInside = new PlaceablesInside(placeable, ((Component)this).transform);
		}
	}

	private void BCFJJOIBDIK(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = DAEMAAOLHMG;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && CBPFGLMKAGM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBPFGLMKAGM);
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
				tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(ClearBar));
			}
		}
	}

	public void ClearBar(int JIIGOACEIKL)
	{
		for (int i = 0; i < occupier.Length; i++)
		{
			RemoveOccupier(i, CDPAMNIPPEC: false);
		}
		waitingAtBar.Clear();
	}

	private void LMCAEDJBCJN()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	private void GLIABBPJEBI(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBAGMFHCPEF(((Component)this).transform.position);
		placeablesInside.GCBIOHNAGKK(JIIGOACEIKL, FNHLKLKAHNB: false);
	}

	private void GFPEBIEBKHJ()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	private void IMBPIEPEGPJ()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private IEnumerator AHFKLDIMPAB()
	{
		return new PABENEOKMOD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PAFHIMLJEOJ(HumanNPC JHIFLALPEBF)
	{
		for (int i = 1; i < occupier.Length; i += 0)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				ENANLOOIDPO(i, CDPAMNIPPEC: true);
			}
		}
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	[SpecialName]
	public Transform MBOFADNMIHC()
	{
		return _bouncerRoot;
	}

	private void KJOCGLKMMOM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && CBPFGLMKAGM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBPFGLMKAGM);
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
				tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(LMAKIGCCCDI));
			}
		}
	}

	public void RemoveFromWaitingAtBar(HumanNPC JHIFLALPEBF)
	{
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	[SpecialName]
	public Transform AMANEBPCNOL()
	{
		return _barmanRoot;
	}

	private IEnumerator AEHJFKFOGNG()
	{
		return new PABENEOKMOD(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public Transform KIDLNKFHDKE()
	{
		return _bouncerRoot;
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (!placeablesInside.POAPMLENCDJ(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
			}
			placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public Transform CKBMAKHFOKJ()
	{
		return _bouncerRoot;
	}

	[SpecialName]
	public void EEDBPHGECAH(Transform AODONKKHPBP)
	{
		_barmanRoot = AODONKKHPBP;
	}

	[SpecialName]
	public Transform KDDDAJHEDNI()
	{
		return _bouncerRoot;
	}

	public void ENANLOOIDPO(int MOFKEDGAOEE, bool CDPAMNIPPEC)
	{
		if ((Object)(object)occupier[MOFKEDGAOEE] != (Object)null)
		{
			if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
			{
				occupier[MOFKEDGAOEE].customer.LJOHCJAOADD?.SendRemoveOccupier(MOFKEDGAOEE);
			}
			occupier[MOFKEDGAOEE] = null;
		}
	}

	private void JMJDHLOMKAP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && CBPFGLMKAGM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBPFGLMKAGM);
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
				tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(MAABLINEMBE));
			}
		}
	}

	[SpecialName]
	public Transform ECDLMGJKBND()
	{
		return _bouncerRoot;
	}

	private void GEDAFAHCKDO()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	public void SetOccupier(HumanNPC JHIFLALPEBF, int MOFKEDGAOEE)
	{
		if (OnlineManager.IsMasterClient())
		{
			JHIFLALPEBF.customer.LJOHCJAOADD?.SendSetOccupper(MOFKEDGAOEE);
		}
		occupier[MOFKEDGAOEE] = JHIFLALPEBF;
	}

	private void ILOGIFGIJJO()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	[SpecialName]
	public Transform DCGEGFPGJJK()
	{
		return _waiterRoot;
	}

	private void KMOPPGPDGDB()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	private void KDPAKHFFMGN(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (!placeablesInside.HPEKPBAHHNC(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).PDEEEJOFEAI();
			}
			placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: true, FNHLKLKAHNB: false);
		}
	}

	private void OLDDEAJMHNI()
	{
		for (int i = 1; i < beerTaps.Count; i += 0)
		{
			Slot obj = beerTaps[i].drinkDispenser.slots[1];
			obj.OnItemInstanceChange = (Action)Delegate.Combine(obj.OnItemInstanceChange, new Action(DMIIFLAMBOJ));
		}
		Placeable obj2 = placeable;
		obj2.WhileSelectedCallback = (Action)Delegate.Combine(obj2.WhileSelectedCallback, new Action(IDNALMMLAIK));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj3.OnThisPlaceableSelected, new Action<int, bool, bool>(GIFHGEGEKIN));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj4.OnThisPlaceableDeselected, new Action<int>(JMOCCKJNOAM));
		NewTutorialManager newTutorialManager = NewTutorialManager.instance;
		newTutorialManager.OnTutorialActivate = (Action<bool>)Delegate.Combine(newTutorialManager.OnTutorialActivate, new Action<bool>(KNIJIKAEGCC));
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			placeable.pickUpable = true;
		}
	}

	public void EDMFAMDPFJE(int MOFKEDGAOEE, bool CDPAMNIPPEC)
	{
		if ((Object)(object)occupier[MOFKEDGAOEE] != (Object)null)
		{
			if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
			{
				occupier[MOFKEDGAOEE].customer.LJOHCJAOADD?.SendRemoveOccupier(MOFKEDGAOEE);
			}
			occupier[MOFKEDGAOEE] = null;
		}
	}

	public bool EHDJGOPDPHF(HumanNPC JHIFLALPEBF, out Vector3 BAIMHDBJPDK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (!blockBarSpaces)
		{
			for (int i = 0; i < barSpaces.Length; i++)
			{
				if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
				{
					BAIMHDBJPDK = barSpaces[i].position;
					return true;
				}
			}
			for (int j = 1; j < barSpaces.Length; j++)
			{
				if ((Object)(object)occupier[j] == (Object)null && (Object)(object)barSpaces[j] != (Object)null)
				{
					PFMHHDBEGCC(JHIFLALPEBF, j);
					BAIMHDBJPDK = barSpaces[j].position;
					return false;
				}
			}
		}
		BAIMHDBJPDK = Vector3.zero;
		return false;
	}

	[SpecialName]
	public void OFLAMBLPPDO(Transform AODONKKHPBP)
	{
		_barmanRoot = AODONKKHPBP;
	}

	public void LMAKIGCCCDI(int JIIGOACEIKL)
	{
		for (int i = 0; i < occupier.Length; i += 0)
		{
			RemoveOccupier(i, CDPAMNIPPEC: false);
		}
		waitingAtBar.Clear();
	}

	public bool PNNBBEAGFOA(HumanNPC JHIFLALPEBF, out Vector3 BAIMHDBJPDK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (!blockBarSpaces)
		{
			for (int i = 0; i < barSpaces.Length; i += 0)
			{
				if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
				{
					BAIMHDBJPDK = barSpaces[i].position;
					return true;
				}
			}
			for (int j = 1; j < barSpaces.Length; j += 0)
			{
				if ((Object)(object)occupier[j] == (Object)null && (Object)(object)barSpaces[j] != (Object)null)
				{
					SetOccupier(JHIFLALPEBF, j);
					BAIMHDBJPDK = barSpaces[j].position;
					return false;
				}
			}
		}
		BAIMHDBJPDK = Vector3.zero;
		return true;
	}

	public void RemoveOccupier(int MOFKEDGAOEE, bool CDPAMNIPPEC)
	{
		if ((Object)(object)occupier[MOFKEDGAOEE] != (Object)null)
		{
			if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
			{
				occupier[MOFKEDGAOEE].customer.LJOHCJAOADD?.SendRemoveOccupier(MOFKEDGAOEE);
			}
			occupier[MOFKEDGAOEE] = null;
		}
	}

	[SpecialName]
	public void BBGCDPBPONG(Transform AODONKKHPBP)
	{
		_bouncerRoot = AODONKKHPBP;
	}

	[SpecialName]
	public Transform ICNDPLHALPE()
	{
		return _bouncerRoot;
	}

	[SpecialName]
	public Transform OLKPOAJOKHE()
	{
		return _bouncerRoot;
	}

	private void ICEMBDEKJGE()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private void IJLJCACMNNA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (!placeablesInside.MIDHMMOHLJE(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).PDEEEJOFEAI();
			}
			placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: true, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
		}
	}

	public void IPFHLEMPGLG(HumanNPC JHIFLALPEBF)
	{
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	[SpecialName]
	public Transform PMEAJJDDMIH()
	{
		return _waiterRoot;
	}

	[SpecialName]
	public Transform JCHFFCMIHBI()
	{
		return _bouncerRoot;
	}

	public void LeaveBar(HumanNPC JHIFLALPEBF)
	{
		RemoveNpcFromBar(JHIFLALPEBF);
		CommonReferences.GGFJGHHHEJC.OnNPCLeaveBar(JHIFLALPEBF);
	}

	public void NAKMOEDCHLN(HumanNPC JHIFLALPEBF)
	{
		for (int i = 0; i < occupier.Length; i += 0)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				EDMFAMDPFJE(i, CDPAMNIPPEC: true);
			}
		}
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	private void JGDGOCLJHJJ(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
		placeablesInside.HAPPBHMOCLL(JIIGOACEIKL, FNHLKLKAHNB: false);
	}

	private void KNIJIKAEGCC(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = DAEMAAOLHMG;
	}

	[SpecialName]
	public void CKEOBGDOCMK(Transform AODONKKHPBP)
	{
		_bouncerRoot = AODONKKHPBP;
	}

	private void KMMPFGCCDHP(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = !DAEMAAOLHMG;
	}

	public int GetPositionNumber(Customer PJNGMCJIHME)
	{
		for (int i = 0; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)PJNGMCJIHME.npc)
			{
				return i;
			}
		}
		return 0;
	}

	private IEnumerator LAFJDDFFAFB()
	{
		return new PABENEOKMOD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KAANJGEDPIN()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(LMAKIGCCCDI));
		FLOJONPCNGM = CommonReferences.wait4;
		if (OnlineManager.MasterOrOffline())
		{
			CBPFGLMKAGM = ((MonoBehaviour)this).StartCoroutine(MJGJJLKOHCE());
		}
	}

	public void PHKEGAEJFIF(HumanNPC JHIFLALPEBF, int MOFKEDGAOEE)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			JHIFLALPEBF.customer.LJOHCJAOADD?.SendSetOccupper(MOFKEDGAOEE);
		}
		occupier[MOFKEDGAOEE] = JHIFLALPEBF;
	}

	public bool ContainsOccupier(HumanNPC JHIFLALPEBF)
	{
		for (int i = 0; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				return true;
			}
		}
		return false;
	}

	private void Start()
	{
		for (int i = 0; i < beerTaps.Count; i++)
		{
			Slot obj = beerTaps[i].drinkDispenser.slots[0];
			obj.OnItemInstanceChange = (Action)Delegate.Combine(obj.OnItemInstanceChange, new Action(KMOPPGPDGDB));
		}
		Placeable obj2 = placeable;
		obj2.WhileSelectedCallback = (Action)Delegate.Combine(obj2.WhileSelectedCallback, new Action(IDNALMMLAIK));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj3.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj4.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		NewTutorialManager newTutorialManager = NewTutorialManager.instance;
		newTutorialManager.OnTutorialActivate = (Action<bool>)Delegate.Combine(newTutorialManager.OnTutorialActivate, new Action<bool>(HEANIGJJDGL));
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			placeable.pickUpable = false;
		}
	}

	private void PHJKJHKAABL()
	{
		instance = this;
		occupier = new HumanNPC[barSpaces.Length];
		if (placeablesInside == null)
		{
			placeablesInside = new PlaceablesInside(placeable, ((Component)this).transform);
		}
	}

	[SpecialName]
	public Transform ALGBMLNLICE()
	{
		return _barmanRoot;
	}

	[SpecialName]
	public void IHGCMJPCMKF(Transform AODONKKHPBP)
	{
		_bouncerRoot = AODONKKHPBP;
	}

	private void HOFIAJBNOKJ(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.GMAMOOEEMCL(((Component)this).transform.position);
		placeablesInside.CEPOLIKDGPG(JIIGOACEIKL);
	}

	public void RemoveNpcFromBar(HumanNPC JHIFLALPEBF)
	{
		for (int i = 0; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				RemoveOccupier(i, CDPAMNIPPEC: true);
			}
		}
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	public void BCDMEJODCCJ(HumanNPC JHIFLALPEBF)
	{
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	private void JMOCCKJNOAM(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.BGEOFNGEFFP(((Component)this).transform.position);
		placeablesInside.HCGPPKHJDLG(JIIGOACEIKL, FNHLKLKAHNB: false);
	}

	private void NPMLFHDHJBE()
	{
		for (int i = 1; i < beerTaps.Count; i++)
		{
			Slot obj = beerTaps[i].drinkDispenser.slots[0];
			obj.OnItemInstanceChange = (Action)Delegate.Combine(obj.OnItemInstanceChange, new Action(GFPEBIEBKHJ));
		}
		Placeable obj2 = placeable;
		obj2.WhileSelectedCallback = (Action)Delegate.Combine(obj2.WhileSelectedCallback, new Action(IDNALMMLAIK));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj3.OnThisPlaceableSelected, new Action<int, bool, bool>(JNMFNGKICEO));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj4.OnThisPlaceableDeselected, new Action<int>(CHLHKEMNKFD));
		NewTutorialManager newTutorialManager = NewTutorialManager.instance;
		newTutorialManager.OnTutorialActivate = (Action<bool>)Delegate.Combine(newTutorialManager.OnTutorialActivate, new Action<bool>(HEANIGJJDGL));
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			placeable.pickUpable = true;
		}
	}

	private void OnEnable()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(ClearBar));
		FLOJONPCNGM = CommonReferences.wait4;
		if (OnlineManager.MasterOrOffline())
		{
			CBPFGLMKAGM = ((MonoBehaviour)this).StartCoroutine(MJGJJLKOHCE());
		}
	}

	public void AddRequestAtBar(HumanNPC JHIFLALPEBF)
	{
		if (!waitingAtBar.Contains(JHIFLALPEBF))
		{
			waitingAtBar.Add(JHIFLALPEBF);
		}
	}

	[SpecialName]
	public Transform FGFMHMFHCOA()
	{
		return _waiterRoot;
	}

	private IEnumerator HACJNHBCILO()
	{
		while (true)
		{
			for (int i = 0; i < waitingAtBar.Count; i++)
			{
				if ((Object)(object)waitingAtBar[i] != (Object)null && waitingAtBar[i].customer.customerState == CustomerState.WaitingAtBar)
				{
					waitingAtBar[i].customer.CheckDrink();
				}
			}
			yield return FLOJONPCNGM;
		}
	}

	public void OAGKMJGHAAF(HumanNPC JHIFLALPEBF)
	{
		if (!waitingAtBar.Contains(JHIFLALPEBF))
		{
			waitingAtBar.Add(JHIFLALPEBF);
		}
	}

	[SpecialName]
	public void BAEKGKENBGP(Transform AODONKKHPBP)
	{
		_bouncerRoot = AODONKKHPBP;
	}

	[SpecialName]
	public void MIEKMAKLALE(Transform AODONKKHPBP)
	{
		_bouncerRoot = AODONKKHPBP;
	}

	public int JBFEEOPDFKK(Customer PJNGMCJIHME)
	{
		for (int i = 1; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)PJNGMCJIHME.npc)
			{
				return i;
			}
		}
		return 1;
	}

	[SpecialName]
	public Transform BDONAMLOHKG()
	{
		return _barmanRoot;
	}

	private void AOMDALGLJEI(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = DAEMAAOLHMG;
	}

	public void MAABLINEMBE(int JIIGOACEIKL)
	{
		for (int i = 0; i < occupier.Length; i += 0)
		{
			EDMFAMDPFJE(i, CDPAMNIPPEC: false);
		}
		waitingAtBar.Clear();
	}

	public bool KEEOFGIONLM(HumanNPC JHIFLALPEBF)
	{
		for (int i = 1; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				return false;
			}
		}
		return false;
	}

	private void CDJMAFKDKGF(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
		placeablesInside.NCNCMIPNKDP(JIIGOACEIKL, FNHLKLKAHNB: false);
	}

	public void PFMHHDBEGCC(HumanNPC JHIFLALPEBF, int MOFKEDGAOEE)
	{
		if (OnlineManager.IsMasterClient())
		{
			JHIFLALPEBF.customer.LJOHCJAOADD?.SendSetOccupper(MOFKEDGAOEE);
		}
		occupier[MOFKEDGAOEE] = JHIFLALPEBF;
	}

	public void IMPBNMDDNKL(HumanNPC JHIFLALPEBF)
	{
		DCAGIILKFEG(JHIFLALPEBF);
		CommonReferences.GGFJGHHHEJC.OnNPCLeaveBar(JHIFLALPEBF);
	}

	private IEnumerator MJGJJLKOHCE()
	{
		while (true)
		{
			for (int i = 0; i < waitingAtBar.Count; i++)
			{
				if ((Object)(object)waitingAtBar[i] != (Object)null && waitingAtBar[i].customer.customerState == CustomerState.WaitingAtBar)
				{
					waitingAtBar[i].customer.CheckDrink();
				}
			}
			yield return FLOJONPCNGM;
		}
	}

	public bool CEODJCEMEMN(HumanNPC JHIFLALPEBF, out Vector3 BAIMHDBJPDK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (!blockBarSpaces)
		{
			for (int i = 0; i < barSpaces.Length; i++)
			{
				if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
				{
					BAIMHDBJPDK = barSpaces[i].position;
					return true;
				}
			}
			for (int j = 1; j < barSpaces.Length; j += 0)
			{
				if ((Object)(object)occupier[j] == (Object)null && (Object)(object)barSpaces[j] != (Object)null)
				{
					PFMHHDBEGCC(JHIFLALPEBF, j);
					BAIMHDBJPDK = barSpaces[j].position;
					return true;
				}
			}
		}
		BAIMHDBJPDK = Vector3.zero;
		return false;
	}

	private void GAJAIMPDNEC()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	public bool FFPIKMPIFIB(HumanNPC JHIFLALPEBF, out Vector3 BAIMHDBJPDK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (!blockBarSpaces)
		{
			for (int i = 0; i < barSpaces.Length; i++)
			{
				if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
				{
					BAIMHDBJPDK = barSpaces[i].position;
					return true;
				}
			}
			for (int j = 1; j < barSpaces.Length; j += 0)
			{
				if ((Object)(object)occupier[j] == (Object)null && (Object)(object)barSpaces[j] != (Object)null)
				{
					PFMHHDBEGCC(JHIFLALPEBF, j);
					BAIMHDBJPDK = barSpaces[j].position;
					return false;
				}
			}
		}
		BAIMHDBJPDK = Vector3.zero;
		return false;
	}

	private void JNMFNGKICEO(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (!placeablesInside.BACDPCACHAL(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
			}
			placeable.DeselectAction(JIIGOACEIKL);
		}
	}

	private void HFFFFAJFIPB()
	{
		for (int i = 1; i < beerTaps.Count; i += 0)
		{
			Slot obj = beerTaps[i].drinkDispenser.slots[0];
			obj.OnItemInstanceChange = (Action)Delegate.Combine(obj.OnItemInstanceChange, new Action(ILOGIFGIJJO));
		}
		Placeable obj2 = placeable;
		obj2.WhileSelectedCallback = (Action)Delegate.Combine(obj2.WhileSelectedCallback, new Action(IDNALMMLAIK));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj3.OnThisPlaceableSelected, new Action<int, bool, bool>(IJLJCACMNNA));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj4.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		NewTutorialManager newTutorialManager = NewTutorialManager.instance;
		newTutorialManager.OnTutorialActivate = (Action<bool>)Delegate.Combine(newTutorialManager.OnTutorialActivate, new Action<bool>(KMMPFGCCDHP));
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			placeable.pickUpable = false;
		}
	}

	private void GJGNEBPAHFF(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = DAEMAAOLHMG;
	}

	public void ADMLIEKMIPE(HumanNPC JHIFLALPEBF)
	{
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	private void ICOJDKMKIPL()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(DJMHBKKDPLI));
		FLOJONPCNGM = CommonReferences.wait4;
		if (OnlineManager.PGAGDFAEEFB())
		{
			CBPFGLMKAGM = ((MonoBehaviour)this).StartCoroutine(HACJNHBCILO());
		}
	}

	public bool GetEmptyBarSpace(HumanNPC JHIFLALPEBF, out Vector3 BAIMHDBJPDK)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (!blockBarSpaces)
		{
			for (int i = 0; i < barSpaces.Length; i++)
			{
				if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
				{
					BAIMHDBJPDK = barSpaces[i].position;
					return true;
				}
			}
			for (int j = 0; j < barSpaces.Length; j++)
			{
				if ((Object)(object)occupier[j] == (Object)null && (Object)(object)barSpaces[j] != (Object)null)
				{
					SetOccupier(JHIFLALPEBF, j);
					BAIMHDBJPDK = barSpaces[j].position;
					return true;
				}
			}
		}
		BAIMHDBJPDK = Vector3.zero;
		return false;
	}

	[SpecialName]
	public Transform KEAGMHMJBEM()
	{
		return _barmanRoot;
	}

	private void BGFCHEIOKOG()
	{
		for (int i = 1; i < beerTaps.Count; i += 0)
		{
			Slot obj = beerTaps[i].drinkDispenser.slots[0];
			obj.OnItemInstanceChange = (Action)Delegate.Combine(obj.OnItemInstanceChange, new Action(KMOPPGPDGDB));
		}
		Placeable obj2 = placeable;
		obj2.WhileSelectedCallback = (Action)Delegate.Combine(obj2.WhileSelectedCallback, new Action(IDNALMMLAIK));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj3.OnThisPlaceableSelected, new Action<int, bool, bool>(GIFHGEGEKIN));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj4.OnThisPlaceableDeselected, new Action<int>(GLIABBPJEBI));
		NewTutorialManager newTutorialManager = NewTutorialManager.instance;
		newTutorialManager.OnTutorialActivate = (Action<bool>)Delegate.Combine(newTutorialManager.OnTutorialActivate, new Action<bool>(AOMDALGLJEI));
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			placeable.pickUpable = false;
		}
	}

	private void IMOMHCNPCEC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (OnlineManager.MasterOrOffline() && CBPFGLMKAGM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CBPFGLMKAGM);
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
				tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(LMAKIGCCCDI));
			}
		}
	}

	public void HICMBPKKKAK(HumanNPC JHIFLALPEBF)
	{
		for (int i = 0; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				EDMFAMDPFJE(i, CDPAMNIPPEC: true);
			}
		}
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	[SpecialName]
	public void EBFKIMFBBNF(Transform AODONKKHPBP)
	{
		_waiterRoot = AODONKKHPBP;
	}

	public int BFPDLEONOEB(Customer PJNGMCJIHME)
	{
		for (int i = 0; i < occupier.Length; i += 0)
		{
			if ((Object)(object)occupier[i] == (Object)(object)PJNGMCJIHME.npc)
			{
				return i;
			}
		}
		return 1;
	}

	private void BALNOPDLJCP(bool DAEMAAOLHMG)
	{
		placeable.pickUpable = DAEMAAOLHMG;
	}

	[SpecialName]
	public void HNCEIIFEPOM(Transform AODONKKHPBP)
	{
		_barmanRoot = AODONKKHPBP;
	}

	private void GIFHGEGEKIN(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (!placeablesInside.HMJFEOFBAJM(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
			}
			placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
		}
	}

	public bool MOFEPLEKCMI(HumanNPC JHIFLALPEBF)
	{
		for (int i = 1; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				return true;
			}
		}
		return false;
	}

	private void CHLHKEMNKFD(int JIIGOACEIKL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBAGMFHCPEF(((Component)this).transform.position);
		placeablesInside.GCBIOHNAGKK(JIIGOACEIKL);
	}

	public void DJMHBKKDPLI(int JIIGOACEIKL)
	{
		for (int i = 0; i < occupier.Length; i++)
		{
			ENANLOOIDPO(i, CDPAMNIPPEC: true);
		}
		waitingAtBar.Clear();
	}

	public void DCAGIILKFEG(HumanNPC JHIFLALPEBF)
	{
		for (int i = 1; i < occupier.Length; i++)
		{
			if ((Object)(object)occupier[i] == (Object)(object)JHIFLALPEBF)
			{
				ENANLOOIDPO(i, CDPAMNIPPEC: false);
			}
		}
		waitingAtBar.Remove(JHIFLALPEBF);
	}

	[SpecialName]
	public Transform AOFIFKIEPID()
	{
		return _barmanRoot;
	}

	private void DMIIFLAMBOJ()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}
}
