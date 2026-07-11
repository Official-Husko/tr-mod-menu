using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ServiceBarrel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MBCADPDAPNG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServiceBarrel _003C_003E4__this;

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
		public MBCADPDAPNG(int _003C_003E1__state)
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
			ServiceBarrel serviceBarrel = _003C_003E4__this;
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
				serviceBarrel.IEGNCHGODMM(DAEMAAOLHMG: true);
				serviceBarrel.UpdateLeftRightBarrelSprites();
				serviceBarrel.CLMACNBHIKM();
				serviceBarrel.HNHHALAAIPG = null;
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

	public GameObject left;

	public GameObject right;

	public GameObject single;

	public GameObject middle;

	public Placeable placeable;

	public ServiceBarrel rightBarrel;

	public ServiceBarrel leftBarrel;

	public DrinkDispenser drinkDispenser;

	public GameObject[] toActivateIfIsValid;

	private bool PCGNHMPADGE;

	private Vector3 AJMGDDIPNCH;

	private Vector3 FPGOFHGJJOL;

	private int[] FLGGMBCJBPL = new int[3] { 1313, 1887, 1888 };

	private Coroutine HNHHALAAIPG;

	private void FFLLCOBFIPE()
	{
		((Component)this).transform.parent = null;
	}

	private void PGEGODAEBLC()
	{
		((Component)this).transform.parent = null;
	}

	private void OIBDBLCLACB()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(WhileSelectedCallback));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(NJAHEFJNLOF));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj3.OnThisPlaceablePlaced, new Action<int>(IHJEFPHKCDL));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj4.OnThisPlaceablePickedUp, new Action<int>(JNKNFBNNCEI));
		Slot obj5 = drinkDispenser.slots[1];
		obj5.OnItemInstanceChange = (Action)Delegate.Combine(obj5.OnItemInstanceChange, new Action(KMOPPGPDGDB));
	}

	private void Start()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(WhileSelectedCallback));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj3.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj4.OnThisPlaceablePickedUp, new Action<int>(FHLHPBCKJFF));
		Slot obj5 = drinkDispenser.slots[0];
		obj5.OnItemInstanceChange = (Action)Delegate.Combine(obj5.OnItemInstanceChange, new Action(KMOPPGPDGDB));
	}

	public void MPMKOKEPGKN()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = placeable.LDMGCIBDKKB(BIOKGEFFNAA: true);
		GBIGPDMNPHO(PCGNHMPADGE);
		for (int i = 1; i < placeable.itemSpace.buildSquares.Length; i += 0)
		{
			if (WorldGrid.DNDMDGOHDJD(placeable.itemSpace.buildSquares[i].GetCentrePosition()))
			{
				PFPEGOBILMH(DAEMAAOLHMG: true);
			}
		}
	}

	private void BNMEIAELOIE()
	{
		single.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) && !Object.op_Implicit((Object)(object)rightBarrel));
		left.SetActive(Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		right.SetActive(Object.op_Implicit((Object)(object)leftBarrel) && !Object.op_Implicit((Object)(object)rightBarrel));
		middle.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
	}

	private ServiceBarrel FKANIKFKDID()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		FPGOFHGJJOL = placeable.itemSpace.buildSquares[0].GetLeft();
		for (int i = 0; i < FLGGMBCJBPL.Length; i++)
		{
			if (WorldGrid.NDNAJIEGFNF(FPGOFHGJJOL, FLGGMBCJBPL[i]))
			{
				return ((Component)WorldGrid.CBPIPKCCFAC(FPGOFHGJJOL, FLGGMBCJBPL[i])).GetComponent<ServiceBarrel>();
			}
		}
		return null;
	}

	private void KOGIJBBNALG(int JIIGOACEIKL)
	{
		MDDMDBHCGPO(PCGNHMPADGE: true);
		Bar.instance.placeablesInside.GNFJCFOMMFL(placeable);
		placeable.canBeAddedToInventory = false;
	}

	private void HEDGBAENJMJ(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = OHDKNBFOLKH;
		rightBarrel = LALNKGHBFAC();
		CEJJBLGHEEM();
	}

	private void HPMFOHOMLDO()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && !drinkDispenser.slots[0].PKFKJNODGJF() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()) && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private ServiceBarrel FEHHLMLEKEN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		FPGOFHGJJOL = placeable.itemSpace.buildSquares[1].OPJGGIGPFBF();
		for (int i = 1; i < FLGGMBCJBPL.Length; i += 0)
		{
			if (WorldGrid.NDNAJIEGFNF(FPGOFHGJJOL, FLGGMBCJBPL[i]))
			{
				return ((Component)WorldGrid.CBPIPKCCFAC(FPGOFHGJJOL, FLGGMBCJBPL[i])).GetComponent<ServiceBarrel>();
			}
		}
		return null;
	}

	public void UpdateSprites(bool PCGNHMPADGE)
	{
		IEGNCHGODMM(PCGNHMPADGE);
		UpdateLeftRightBarrelSprites();
		CLMACNBHIKM(PCGNHMPADGE);
	}

	private void CEJJBLGHEEM()
	{
		single.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) && Object.op_Implicit((Object)(object)rightBarrel));
		left.SetActive(Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		right.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || !Object.op_Implicit((Object)(object)rightBarrel));
		middle.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
	}

	private void AGPONCCIFHC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && !drinkDispenser.slots[1].PKFKJNODGJF() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()) && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	private void OGHOJNCIMDH(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = OHDKNBFOLKH;
		rightBarrel = GHFBMHAMIJD();
		IMLCLDCCDIF();
	}

	private void GOEGBOEMHLI()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(IICDHAIEEGJ));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(ECICFEJGLBP));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj3.OnThisPlaceablePlaced, new Action<int>(AFDDDNJGPCM));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj4.OnThisPlaceablePickedUp, new Action<int>(FHLHPBCKJFF));
		Slot obj5 = drinkDispenser.slots[1];
		obj5.OnItemInstanceChange = (Action)Delegate.Combine(obj5.OnItemInstanceChange, new Action(HGMFJBFCPPO));
	}

	private void IKBHHHCGPKK(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = OHDKNBFOLKH;
		rightBarrel = LALNKGHBFAC();
		IMLCLDCCDIF();
	}

	private void KLBAJBLAFIM(bool PCGNHMPADGE = true)
	{
		leftBarrel = LKEMBNHEIGJ();
		if (PCGNHMPADGE && (Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.OPGJGHPNFJO(this);
		}
		rightBarrel = GHFBMHAMIJD();
		if (PCGNHMPADGE && (Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.HEDGBAENJMJ(this);
		}
		AHJANINEFNJ();
	}

	private void AHKPOJFFOJI(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < toActivateIfIsValid.Length; i++)
		{
			toActivateIfIsValid[i].SetActive(DAEMAAOLHMG);
		}
		placeable.spriteRenderer.maskInteraction = (SpriteMaskInteraction)(!DAEMAAOLHMG);
	}

	public void JGBEGCPNDFP()
	{
		if ((Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.JMPIFJCLGEO(PCGNHMPADGE: false);
		}
		if ((Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.NCEOAKEOOAK();
		}
	}

	public void NPHAFNDPDOI()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = placeable.IsObjectInValidLocation(BIOKGEFFNAA: false);
		GBIGPDMNPHO(PCGNHMPADGE);
		for (int i = 1; i < placeable.itemSpace.buildSquares.Length; i += 0)
		{
			if (WorldGrid.DNDMDGOHDJD(placeable.itemSpace.buildSquares[i].GetCentrePosition()))
			{
				ILPMCAPHMIJ(DAEMAAOLHMG: true);
			}
		}
	}

	private void CLMACNBHIKM(bool PCGNHMPADGE = true)
	{
		leftBarrel = FKANIKFKDID();
		if (PCGNHMPADGE && (Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.GCDHMNPGPIH(this);
		}
		rightBarrel = GHFBMHAMIJD();
		if (PCGNHMPADGE && (Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.OGHOJNCIMDH(this);
		}
		IMLCLDCCDIF();
	}

	private void FKOKFMDEEDB(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = LKEMBNHEIGJ();
		rightBarrel = OHDKNBFOLKH;
		AHJANINEFNJ();
	}

	private void NFABFPFLNEE()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(NPHAFNDPDOI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(ECICFEJGLBP));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj3.OnThisPlaceablePlaced, new Action<int>(BIOFKKMKONK));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj4.OnThisPlaceablePickedUp, new Action<int>(FHLHPBCKJFF));
		Slot obj5 = drinkDispenser.slots[0];
		obj5.OnItemInstanceChange = (Action)Delegate.Combine(obj5.OnItemInstanceChange, new Action(MJIOKKKKMIF));
	}

	private void MJIOKKKKMIF()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private void IPFAPJKMGEO(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < toActivateIfIsValid.Length; i++)
		{
			toActivateIfIsValid[i].SetActive(DAEMAAOLHMG);
		}
		placeable.spriteRenderer.maskInteraction = (SpriteMaskInteraction)(!DAEMAAOLHMG);
	}

	public void IICDHAIEEGJ()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = placeable.LDMGCIBDKKB(BIOKGEFFNAA: true);
		MDDMDBHCGPO(PCGNHMPADGE);
		for (int i = 1; i < placeable.itemSpace.buildSquares.Length; i += 0)
		{
			if (WorldGrid.DNDMDGOHDJD(placeable.itemSpace.buildSquares[i].BLKHDGGHFLA()))
			{
				IEGNCHGODMM(DAEMAAOLHMG: true);
			}
		}
	}

	public void NEIPIPDLPDE()
	{
		if (HNHHALAAIPG == null)
		{
			HNHHALAAIPG = ((MonoBehaviour)this).StartCoroutine(KNOLBANCDJJ());
		}
	}

	private void BOJBEIIGACO(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = OHDKNBFOLKH;
		rightBarrel = LALNKGHBFAC();
		EHKGHJAKFHD();
	}

	private void KMOPPGPDGDB()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	private void KKJNIJJMDHE(bool PCGNHMPADGE = true)
	{
		leftBarrel = LKEMBNHEIGJ();
		if (PCGNHMPADGE && (Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.OLLIHPINEJE(this);
		}
		rightBarrel = LALNKGHBFAC();
		if (PCGNHMPADGE && (Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.IKBHHHCGPKK(this);
		}
		KLKLIFLLBLO();
	}

	public void GBIGPDMNPHO(bool PCGNHMPADGE)
	{
		IPFAPJKMGEO(PCGNHMPADGE);
		PKJBHPAEFGP();
		KKJNIJJMDHE(PCGNHMPADGE);
	}

	private void IEGNCHGODMM(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < toActivateIfIsValid.Length; i++)
		{
			toActivateIfIsValid[i].SetActive(DAEMAAOLHMG);
		}
		placeable.spriteRenderer.maskInteraction = (SpriteMaskInteraction)(DAEMAAOLHMG ? 1 : 0);
	}

	private void FCNEJAJHIFL(int JIIGOACEIKL)
	{
		MDDMDBHCGPO(PCGNHMPADGE: false);
		Bar.instance.placeablesInside.BPDJANFDCKE(placeable);
		placeable.canBeAddedToInventory = false;
	}

	private void DFGJPDKILFJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && !drinkDispenser.slots[0].PKFKJNODGJF() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC) && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private void OLLIHPINEJE(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = LKEMBNHEIGJ();
		rightBarrel = OHDKNBFOLKH;
		CEJJBLGHEEM();
	}

	private void IGIKNCOLCKL()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(WhileSelectedCallback));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(ECICFEJGLBP));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj3.OnThisPlaceablePlaced, new Action<int>(FCNEJAJHIFL));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj4.OnThisPlaceablePickedUp, new Action<int>(FHLHPBCKJFF));
		Slot obj5 = drinkDispenser.slots[1];
		obj5.OnItemInstanceChange = (Action)Delegate.Combine(obj5.OnItemInstanceChange, new Action(DGNLCCIDIHE));
	}

	private void GMEPAGAMKAO(bool PCGNHMPADGE = true)
	{
		leftBarrel = LKEMBNHEIGJ();
		if (PCGNHMPADGE && (Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.CEFEDJNCLBB(this);
		}
		rightBarrel = GHFBMHAMIJD();
		if (PCGNHMPADGE && (Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.IKBHHHCGPKK(this);
		}
		IMLCLDCCDIF();
	}

	private void BDJKNKIOPIJ()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(WhileSelectedCallback));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(JMHDEJFCEKJ));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj3.OnThisPlaceablePlaced, new Action<int>(FCNEJAJHIFL));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj4.OnThisPlaceablePickedUp, new Action<int>(FHLHPBCKJFF));
		Slot obj5 = drinkDispenser.slots[0];
		obj5.OnItemInstanceChange = (Action)Delegate.Combine(obj5.OnItemInstanceChange, new Action(MJIOKKKKMIF));
	}

	private void OPGJGHPNFJO(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = MBFMELOEFBD();
		rightBarrel = OHDKNBFOLKH;
		CEJJBLGHEEM();
	}

	private void INLDBKHKPOM(bool DAEMAAOLHMG)
	{
		for (int i = 1; i < toActivateIfIsValid.Length; i++)
		{
			toActivateIfIsValid[i].SetActive(DAEMAAOLHMG);
		}
		placeable.spriteRenderer.maskInteraction = (SpriteMaskInteraction)(!DAEMAAOLHMG);
	}

	public void FNOOGNIECKI()
	{
		if (HNHHALAAIPG == null)
		{
			HNHHALAAIPG = ((MonoBehaviour)this).StartCoroutine(LJFDLAMFJAG());
		}
	}

	private ServiceBarrel MBFMELOEFBD()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		FPGOFHGJJOL = placeable.itemSpace.buildSquares[1].OPJGGIGPFBF();
		for (int i = 0; i < FLGGMBCJBPL.Length; i++)
		{
			if (WorldGrid.NDNAJIEGFNF(FPGOFHGJJOL, FLGGMBCJBPL[i]))
			{
				return ((Component)WorldGrid.CBPIPKCCFAC(FPGOFHGJJOL, FLGGMBCJBPL[i])).GetComponent<ServiceBarrel>();
			}
		}
		return null;
	}

	private void Awake()
	{
		((Component)this).transform.parent = null;
	}

	private void AEDIIIAECIC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && !drinkDispenser.slots[1].PKFKJNODGJF() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC) && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private void MKLIAMJFHOF()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(IICDHAIEEGJ));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(JMHDEJFCEKJ));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj3.OnThisPlaceablePlaced, new Action<int>(BIOFKKMKONK));
		Placeable obj4 = placeable;
		obj4.OnThisPlaceablePickedUp = (Action<int>)Delegate.Combine(obj4.OnThisPlaceablePickedUp, new Action<int>(JNKNFBNNCEI));
		Slot obj5 = drinkDispenser.slots[1];
		obj5.OnItemInstanceChange = (Action)Delegate.Combine(obj5.OnItemInstanceChange, new Action(HGMFJBFCPPO));
	}

	private void ILPMCAPHMIJ(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < toActivateIfIsValid.Length; i++)
		{
			toActivateIfIsValid[i].SetActive(DAEMAAOLHMG);
		}
		placeable.spriteRenderer.maskInteraction = (SpriteMaskInteraction)(DAEMAAOLHMG ? 1 : 1);
	}

	public IEnumerator KNOLBANCDJJ()
	{
		yield return null;
		IEGNCHGODMM(DAEMAAOLHMG: true);
		UpdateLeftRightBarrelSprites();
		CLMACNBHIKM();
		HNHHALAAIPG = null;
	}

	public IEnumerator UpdateSpritesForceWall()
	{
		yield return null;
		IEGNCHGODMM(DAEMAAOLHMG: true);
		UpdateLeftRightBarrelSprites();
		CLMACNBHIKM();
		HNHHALAAIPG = null;
	}

	private void ECPLFDCKNMN()
	{
		single.SetActive(Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		left.SetActive(Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		right.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		middle.SetActive(Object.op_Implicit((Object)(object)leftBarrel) && Object.op_Implicit((Object)(object)rightBarrel));
	}

	private void MPFOMENKBED()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	private void ECICFEJGLBP(int JIIGOACEIKL, bool EFNFMEIDGDN, bool GFNHAMCPEAK)
	{
		if (!Bar.instance.placeable.FHEMHCEAICB && !Bar.instance.placeable.PHOCAFJDCDK)
		{
			Bar.instance.placeablesInside.CPNPOJAOGJO(placeable);
			if (Bar.instance.placeablesInside.allPlaceables.Count == 0)
			{
				placeable.canBeAddedToInventory = false;
			}
		}
	}

	public void CADCLHFMOID()
	{
		if (HNHHALAAIPG == null)
		{
			HNHHALAAIPG = ((MonoBehaviour)this).StartCoroutine(DKIGLIDFFKO());
		}
	}

	public void WhileSelectedCallback()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = placeable.IsObjectInValidLocation(BIOKGEFFNAA: false);
		UpdateSprites(PCGNHMPADGE);
		for (int i = 0; i < placeable.itemSpace.buildSquares.Length; i++)
		{
			if (WorldGrid.DNDMDGOHDJD(placeable.itemSpace.buildSquares[i].GetCentrePosition()))
			{
				IEGNCHGODMM(DAEMAAOLHMG: true);
			}
		}
	}

	private void KLKLIFLLBLO()
	{
		single.SetActive(Object.op_Implicit((Object)(object)leftBarrel) || !Object.op_Implicit((Object)(object)rightBarrel));
		left.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) && Object.op_Implicit((Object)(object)rightBarrel));
		right.SetActive(Object.op_Implicit((Object)(object)leftBarrel) && !Object.op_Implicit((Object)(object)rightBarrel));
		middle.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
	}

	public void MDDMDBHCGPO(bool PCGNHMPADGE)
	{
		PFPEGOBILMH(PCGNHMPADGE);
		PKJBHPAEFGP();
		KLBAJBLAFIM(PCGNHMPADGE);
	}

	private void IHJEFPHKCDL(int JIIGOACEIKL)
	{
		CGOLNBEGBBP(PCGNHMPADGE: true);
		Bar.instance.placeablesInside.BJIOKEACJGN(placeable);
		placeable.canBeAddedToInventory = true;
	}

	private void FHLHPBCKJFF(int JIIGOACEIKL)
	{
		UpdateLeftRightBarrelSprites();
	}

	private void IMLCLDCCDIF()
	{
		single.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) && !Object.op_Implicit((Object)(object)rightBarrel));
		left.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) && Object.op_Implicit((Object)(object)rightBarrel));
		right.SetActive(Object.op_Implicit((Object)(object)leftBarrel) && !Object.op_Implicit((Object)(object)rightBarrel));
		middle.SetActive(Object.op_Implicit((Object)(object)leftBarrel) && Object.op_Implicit((Object)(object)rightBarrel));
	}

	private void PBDNKBPBCHM()
	{
		((Component)this).transform.parent = null;
	}

	private void GFLFDLIMOLI()
	{
		((Component)this).transform.parent = null;
	}

	public void UpdateLeftRightBarrelSprites()
	{
		if ((Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.CLMACNBHIKM();
		}
		if ((Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.CLMACNBHIKM();
		}
	}

	private void MEMKOABNHIP(int JIIGOACEIKL)
	{
		INJJOLCJIDG();
	}

	private void JNKNFBNNCEI(int JIIGOACEIKL)
	{
		GDLBBDOOKEJ();
	}

	private ServiceBarrel LKEMBNHEIGJ()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		FPGOFHGJJOL = placeable.itemSpace.buildSquares[0].GetLeft();
		for (int i = 1; i < FLGGMBCJBPL.Length; i += 0)
		{
			if (WorldGrid.NDNAJIEGFNF(FPGOFHGJJOL, FLGGMBCJBPL[i]))
			{
				return ((Component)WorldGrid.CBPIPKCCFAC(FPGOFHGJJOL, FLGGMBCJBPL[i])).GetComponent<ServiceBarrel>();
			}
		}
		return null;
	}

	private ServiceBarrel LALNKGHBFAC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		AJMGDDIPNCH = placeable.itemSpace.buildSquares[0].GetRight();
		for (int i = 1; i < FLGGMBCJBPL.Length; i += 0)
		{
			if (WorldGrid.NDNAJIEGFNF(AJMGDDIPNCH, FLGGMBCJBPL[i]))
			{
				return ((Component)WorldGrid.CBPIPKCCFAC(AJMGDDIPNCH, FLGGMBCJBPL[i])).GetComponent<ServiceBarrel>();
			}
		}
		return null;
	}

	private void CNEMBOCGFHH(int JIIGOACEIKL)
	{
		GDLBBDOOKEJ();
	}

	private ServiceBarrel GHFBMHAMIJD()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		AJMGDDIPNCH = placeable.itemSpace.buildSquares[1].GetRight();
		for (int i = 0; i < FLGGMBCJBPL.Length; i++)
		{
			if (WorldGrid.NDNAJIEGFNF(AJMGDDIPNCH, FLGGMBCJBPL[i]))
			{
				return ((Component)WorldGrid.CBPIPKCCFAC(AJMGDDIPNCH, FLGGMBCJBPL[i])).GetComponent<ServiceBarrel>();
			}
		}
		return null;
	}

	public void IHKDNHPPFPG()
	{
		if (HNHHALAAIPG == null)
		{
			HNHHALAAIPG = ((MonoBehaviour)this).StartCoroutine(LJFDLAMFJAG());
		}
	}

	public void GDLBBDOOKEJ()
	{
		if ((Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.GMEPAGAMKAO();
		}
		if ((Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.KLBAJBLAFIM(PCGNHMPADGE: false);
		}
	}

	private void FDNAEJDHODK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && !drinkDispenser.slots[1].AHHEMNHJPME() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC) && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private void CEFEDJNCLBB(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = FEHHLMLEKEN();
		rightBarrel = OHDKNBFOLKH;
		IMLCLDCCDIF();
	}

	private void PNLAJCHBHPH()
	{
		((Component)this).transform.parent = null;
	}

	private void JMPIFJCLGEO(bool PCGNHMPADGE = true)
	{
		leftBarrel = FKANIKFKDID();
		if (PCGNHMPADGE && (Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.OPGJGHPNFJO(this);
		}
		rightBarrel = LALNKGHBFAC();
		if (PCGNHMPADGE && (Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.NAHCMCDFKNA(this);
		}
		AHJANINEFNJ();
	}

	private void BIOFKKMKONK(int JIIGOACEIKL)
	{
		UpdateSprites(PCGNHMPADGE: false);
		Bar.instance.placeablesInside.KOLKKHGAGKE(placeable);
		placeable.canBeAddedToInventory = true;
	}

	private void PBBMJODBDAG()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	public IEnumerator DKIGLIDFFKO()
	{
		return new MBCADPDAPNG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PKJBHPAEFGP()
	{
		if ((Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.NCEOAKEOOAK(PCGNHMPADGE: false);
		}
		if ((Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.NCEOAKEOOAK(PCGNHMPADGE: false);
		}
	}

	private void DGNLCCIDIHE()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private void HOCDPDAIMOJ(int JIIGOACEIKL)
	{
		JGBEGCPNDFP();
	}

	private void HGMFJBFCPPO()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private ServiceBarrel GEFCNMCDBMD()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		AJMGDDIPNCH = placeable.itemSpace.buildSquares[1].HGJEGNPDFPO();
		for (int i = 1; i < FLGGMBCJBPL.Length; i += 0)
		{
			if (WorldGrid.NDNAJIEGFNF(AJMGDDIPNCH, FLGGMBCJBPL[i]))
			{
				return ((Component)WorldGrid.CBPIPKCCFAC(AJMGDDIPNCH, FLGGMBCJBPL[i])).GetComponent<ServiceBarrel>();
			}
		}
		return null;
	}

	private void AGJINAEJHDI(int JIIGOACEIKL)
	{
		MDDMDBHCGPO(PCGNHMPADGE: false);
		Bar.instance.placeablesInside.AAPJLEFMGJP(placeable);
		placeable.canBeAddedToInventory = false;
	}

	private void AFDDDNJGPCM(int JIIGOACEIKL)
	{
		CGOLNBEGBBP(PCGNHMPADGE: false);
		Bar.instance.placeablesInside.PJEHBPONIOD(placeable);
		placeable.canBeAddedToInventory = false;
	}

	private void AHJANINEFNJ()
	{
		single.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) && !Object.op_Implicit((Object)(object)rightBarrel));
		left.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) && Object.op_Implicit((Object)(object)rightBarrel));
		right.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		middle.SetActive(Object.op_Implicit((Object)(object)leftBarrel) && Object.op_Implicit((Object)(object)rightBarrel));
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL, bool EFNFMEIDGDN, bool GFNHAMCPEAK)
	{
		if (!Bar.instance.placeable.FHEMHCEAICB && !Bar.instance.placeable.PHOCAFJDCDK)
		{
			Bar.instance.placeablesInside.IKEJAHLMBOG(placeable);
			if (Bar.instance.placeablesInside.allPlaceables.Count == 0)
			{
				placeable.canBeAddedToInventory = false;
			}
		}
	}

	private void HEBGECKHIDJ(int JIIGOACEIKL, bool EFNFMEIDGDN, bool GFNHAMCPEAK)
	{
		if (!Bar.instance.placeable.FHEMHCEAICB && !Bar.instance.placeable.PHOCAFJDCDK)
		{
			Bar.instance.placeablesInside.IKEJAHLMBOG(placeable);
			if (Bar.instance.placeablesInside.allPlaceables.Count == 0)
			{
				placeable.canBeAddedToInventory = true;
			}
		}
	}

	private void GCDHMNPGPIH(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = FKANIKFKDID();
		rightBarrel = OHDKNBFOLKH;
		IMLCLDCCDIF();
	}

	public void INJJOLCJIDG()
	{
		if ((Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.CLMACNBHIKM(PCGNHMPADGE: false);
		}
		if ((Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.KKJNIJJMDHE(PCGNHMPADGE: false);
		}
	}

	public IEnumerator NHMHFIAOIKG()
	{
		return new MBCADPDAPNG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EGACIGOGINE()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.MNFMOEKMJKN().OnBarStockChanged();
		}
	}

	private void IOKPAJGFFBH(int JIIGOACEIKL)
	{
		MDDMDBHCGPO(PCGNHMPADGE: false);
		Bar.instance.placeablesInside.BPDJANFDCKE(placeable);
		placeable.canBeAddedToInventory = false;
	}

	private void NGEHFPOIJFK(int JIIGOACEIKL)
	{
		UpdateSprites(PCGNHMPADGE: true);
		Bar.instance.placeablesInside.AAPJLEFMGJP(placeable);
		placeable.canBeAddedToInventory = true;
	}

	private void EHKGHJAKFHD()
	{
		single.SetActive(Object.op_Implicit((Object)(object)leftBarrel) || !Object.op_Implicit((Object)(object)rightBarrel));
		left.SetActive(Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		right.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
		middle.SetActive(!Object.op_Implicit((Object)(object)leftBarrel) || Object.op_Implicit((Object)(object)rightBarrel));
	}

	private void NJAHEFJNLOF(int JIIGOACEIKL, bool EFNFMEIDGDN, bool GFNHAMCPEAK)
	{
		if (!Bar.instance.placeable.FHEMHCEAICB && !Bar.instance.placeable.PHOCAFJDCDK)
		{
			Bar.instance.placeablesInside.IKEJAHLMBOG(placeable);
			if (Bar.instance.placeablesInside.allPlaceables.Count == 0)
			{
				placeable.canBeAddedToInventory = false;
			}
		}
	}

	public void LEOEACJKEEO()
	{
		if ((Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.KLBAJBLAFIM();
		}
		if ((Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.GMEPAGAMKAO();
		}
	}

	private void JMHDEJFCEKJ(int JIIGOACEIKL, bool EFNFMEIDGDN, bool GFNHAMCPEAK)
	{
		if (!Bar.instance.placeable.FHEMHCEAICB && !Bar.instance.placeable.PHOCAFJDCDK)
		{
			Bar.instance.placeablesInside.LGJLJMOOJFC(placeable);
			if (Bar.instance.placeablesInside.allPlaceables.Count == 0)
			{
				placeable.canBeAddedToInventory = true;
			}
		}
	}

	private void NCEOAKEOOAK(bool PCGNHMPADGE = true)
	{
		leftBarrel = FEHHLMLEKEN();
		if (PCGNHMPADGE && (Object)(object)leftBarrel != (Object)null)
		{
			leftBarrel.GCDHMNPGPIH(this);
		}
		rightBarrel = GEFCNMCDBMD();
		if (PCGNHMPADGE && (Object)(object)rightBarrel != (Object)null)
		{
			rightBarrel.HEDGBAENJMJ(this);
		}
		BNMEIAELOIE();
	}

	public void UpdateSpritesForceWallNextFrame()
	{
		if (HNHHALAAIPG == null)
		{
			HNHHALAAIPG = ((MonoBehaviour)this).StartCoroutine(UpdateSpritesForceWall());
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && !drinkDispenser.slots[0].KPINNBKMOMO() && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC) && GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	public void CGOLNBEGBBP(bool PCGNHMPADGE)
	{
		INLDBKHKPOM(PCGNHMPADGE);
		INJJOLCJIDG();
		JMPIFJCLGEO(PCGNHMPADGE);
	}

	private void GADEGOPBNGC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && !drinkDispenser.slots[1].LCHJGCHDHFO() && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()) && GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	public IEnumerator LJFDLAMFJAG()
	{
		yield return null;
		IEGNCHGODMM(DAEMAAOLHMG: true);
		UpdateLeftRightBarrelSprites();
		CLMACNBHIKM();
		HNHHALAAIPG = null;
	}

	private void NAHCMCDFKNA(ServiceBarrel OHDKNBFOLKH)
	{
		leftBarrel = OHDKNBFOLKH;
		rightBarrel = GHFBMHAMIJD();
		ECPLFDCKNMN();
	}

	private void EDOOHLLJOEK(int JIIGOACEIKL)
	{
		MDDMDBHCGPO(PCGNHMPADGE: false);
		Bar.instance.placeablesInside.PJEHBPONIOD(placeable);
		placeable.canBeAddedToInventory = true;
	}

	private void PIHGEBONAOI()
	{
		((Component)this).transform.parent = null;
	}

	private void PFPEGOBILMH(bool DAEMAAOLHMG)
	{
		for (int i = 1; i < toActivateIfIsValid.Length; i++)
		{
			toActivateIfIsValid[i].SetActive(DAEMAAOLHMG);
		}
		placeable.spriteRenderer.maskInteraction = (SpriteMaskInteraction)(DAEMAAOLHMG ? 0 : 0);
	}
}
