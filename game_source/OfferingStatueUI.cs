using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OfferingStatueUI : UIWindow
{
	[CompilerGenerated]
	private sealed class IJCEBJADHNP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OfferingStatueUI _003C_003E4__this;

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
		public IJCEBJADHNP(int _003C_003E1__state)
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
			OfferingStatueUI offeringStatueUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(offeringStatueUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(offeringStatueUI.JIIGOACEIKL).Select(((Component)offeringStatueUI.slotUI).gameObject);
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

	public SlotUI slotUI;

	public static OfferingStatueUI[] instances = new OfferingStatueUI[3];

	private OfferingStatuePuzzle ONCCKDONEFG;

	private OfferingStatueAnimator BNAJNKBCLEJ;

	private bool IDOIABFOKOP;

	private void MLKEHEGLCOI()
	{
		if (LKOJBFMGMAE)
		{
			JAOINIIELBL();
		}
	}

	public void JAOINIIELBL()
	{
		if (!LKOJBFMGMAE || (Object)(object)ONCCKDONEFG == (Object)null)
		{
			return;
		}
		IDOIABFOKOP = false;
		Slot slot = slotUI.IHENCGDNPBL;
		ItemInstance itemInstance = slot.itemInstance;
		if (itemInstance == null)
		{
			BOBCIFEDJED();
			return;
		}
		Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Remove(offeringSlot.OnItemAdded, new Action(JGJPGEJKGEN));
		Slot slot2 = ONCCKDONEFG.ACBPPCPKCBG();
		slot2.OnItemRemoved = (Action)Delegate.Remove(slot2.OnItemRemoved, new Action(CIJFFFFDFFL));
		if (ONCCKDONEFG.JMKGMCMLGGF(itemInstance.PHGLMBIEOMK()))
		{
			slot.POHFJCEAKML();
			ONCCKDONEFG.PuzzleSolved(base.JIIGOACEIKL, CDPAMNIPPEC: false);
			ONCCKDONEFG.FEDOBLBCLAF();
			ONCCKDONEFG.PNGGHNBGMJN(IEJDPOEOIBO: true);
			ONCCKDONEFG = null;
		}
		else
		{
			ONCCKDONEFG.PlayFailAnimation();
			OnlinePuzzleManager.instance.IMDBDEDDKAK(ONCCKDONEFG.GetManager().mineLevel);
		}
		CloseUI();
	}

	private void JGJPGEJKGEN()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			Slot slot = ONCCKDONEFG.HCIPKANLPKJ();
			if (!slot.AHHEMNHJPME())
			{
				OnlinePuzzleManager.instance.PEIIHKMJGBB(ONCCKDONEFG.GetManager().mineLevel, slot.itemInstance.KNFNJFFCFNO().IMCJPECAAPC());
			}
		}
	}

	private IEnumerator DJJCICNCBFM()
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DECOHOILHBN()
	{
		if (!LKOJBFMGMAE || (Object)(object)ONCCKDONEFG == (Object)null)
		{
			return;
		}
		IDOIABFOKOP = false;
		Slot slot = slotUI.IHENCGDNPBL;
		ItemInstance itemInstance = slot.itemInstance;
		if (itemInstance == null)
		{
			CloseUI();
			return;
		}
		Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Remove(offeringSlot.OnItemAdded, new Action(LGIBNILPDEK));
		Slot slot2 = ONCCKDONEFG.HCIPKANLPKJ();
		slot2.OnItemRemoved = (Action)Delegate.Remove(slot2.OnItemRemoved, new Action(DKOJDJHDAAM));
		if (ONCCKDONEFG.MKFCIKFPGPE(itemInstance.KNFNJFFCFNO()))
		{
			slot.POHFJCEAKML();
			ONCCKDONEFG.LGMNNAIIMPM(base.JIIGOACEIKL, CDPAMNIPPEC: false);
			ONCCKDONEFG.DHILGLJPFDL();
			ONCCKDONEFG.ClosePuzzle();
			ONCCKDONEFG = null;
		}
		else
		{
			ONCCKDONEFG.PNJBDOOMIDB();
			OnlinePuzzleManager.instance.IMDBDEDDKAK(ONCCKDONEFG.NAMECAKIKHJ().mineLevel);
		}
		CloseUI();
	}

	private void HJKONJICGML()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(EPCIILDJAOG));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(MHEJAMJFKDG));
	}

	private void NIILOKCNLEN()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetAllSlots()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void ILBLPFDELDK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null || ADEBNALPEHE.KPINNBKMOMO())
		{
			return;
		}
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
			}
		}
		else
		{
			BNAJNKBCLEJ.Deactivate();
			NIILOKCNLEN();
		}
	}

	private void KGKGIHMPAHK()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
			if (!offeringSlot.KPINNBKMOMO())
			{
				OnlinePuzzleManager.instance.SendOfferingItemPlaced(ONCCKDONEFG.GetManager().mineLevel, offeringSlot.itemInstance.LHBPOPOIFLE().JDJGFAACPFC());
			}
		}
	}

	private void BFKCHCLJIPL()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(EPCIILDJAOG));
	}

	public static OfferingStatueUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MEOHNKGMOHJ(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.MHNCEBLHLKH(KILHLOPKOMH.ACBPPCPKCBG());
		Slot slot = KILHLOPKOMH.ACBPPCPKCBG();
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(NPDPHEILOLB));
		Slot offeringSlot = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot.OnItemRemoved = (Action)Delegate.Combine(offeringSlot.OnItemRemoved, new Action(EMDBPBAFGPB));
		MainUI.LIIGLHOFDBK(JIIGOACEIKL, KILHLOPKOMH.PBAOFGDCIDD(), 0);
	}

	private void DKOJDJHDAAM()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			BNAJNKBCLEJ.BJJOHMJACDG();
			OnlinePuzzleManager.instance.MEJEPBCAGHO(ONCCKDONEFG.CEMEKIJMEAN().mineLevel);
		}
	}

	public void MEICGMGOHBO(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.IHENCGDNPBL = KILHLOPKOMH.HCIPKANLPKJ();
		Slot slot = KILHLOPKOMH.ACBPPCPKCBG();
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(AJGPAHAMNKB));
		Slot slot2 = KILHLOPKOMH.HCIPKANLPKJ();
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(MIBIMHAICPD));
		MainUI.SetCurrentContainer(JIIGOACEIKL, KILHLOPKOMH.FMKBICCBMDK(), 1);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		MainUI.ResumeGame();
		if (slotUI.IHENCGDNPBL.KPINNBKMOMO())
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HMGAAINDHEL());
		}
	}

	private void OnDisable()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(ILBLPFDELDK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(ILBLPFDELDK));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(ILBLPFDELDK));
	}

	private void MNEAOFNAKIP()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(HGDKENOLMHK));
	}

	private void NPDPHEILOLB()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			Slot slot = ONCCKDONEFG.HCIPKANLPKJ();
			if (!slot.AHHEMNHJPME())
			{
				OnlinePuzzleManager.instance.PEIIHKMJGBB(ONCCKDONEFG.NAMECAKIKHJ().mineLevel, slot.itemInstance.PHGLMBIEOMK().JDJGFAACPFC(DAINLFIMLIH: false));
			}
		}
	}

	private void OnEnable()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(ILBLPFDELDK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(ILBLPFDELDK));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(ILBLPFDELDK));
	}

	private void GJEEHONNGJM()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).PJEIHOCPBLA(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void CIAIAEJIMCM()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(ILBLPFDELDK));
	}

	public void APBIFKKCHNP(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.LIJPNDJCKGL(KILHLOPKOMH.GetOfferingSlot());
		Slot offeringSlot = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Combine(offeringSlot.OnItemAdded, new Action(KGKGIHMPAHK));
		Slot slot = KILHLOPKOMH.HCIPKANLPKJ();
		slot.OnItemRemoved = (Action)Delegate.Combine(slot.OnItemRemoved, new Action(MIBIMHAICPD));
		MainUI.SetCurrentContainer(JIIGOACEIKL, KILHLOPKOMH.EAFDBPADLNA(), 1);
	}

	public static OfferingStatueUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void MKGKKAJHLAO()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(CEFJPFKBLAJ));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(EPCIILDJAOG));
	}

	private IEnumerator INJMPMFGLPB()
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HLLPJIECENJ()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.MOKEEMCFJPE())
		{
			BNAJNKBCLEJ.HIGKNDNMLFC();
			OnlinePuzzleManager.instance.SendOfferingItemCleared(ONCCKDONEFG.GetManager().mineLevel);
		}
	}

	private void JIBHLLJGGEN()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(CEFJPFKBLAJ));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(CCHBCMDNLKM));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(HGDKENOLMHK));
	}

	public void SetOffering(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.IHENCGDNPBL = KILHLOPKOMH.GetOfferingSlot();
		Slot offeringSlot = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Combine(offeringSlot.OnItemAdded, new Action(KGKGIHMPAHK));
		Slot offeringSlot2 = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot2.OnItemRemoved = (Action)Delegate.Combine(offeringSlot2.OnItemRemoved, new Action(GJKFDDBIDPA));
		MainUI.SetCurrentContainer(JIIGOACEIKL, KILHLOPKOMH.GetOfferingContainer(), 0);
	}

	private IEnumerator HHMMJMKAFAM()
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MHEJAMJFKDG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null || ADEBNALPEHE.KPINNBKMOMO())
		{
			return;
		}
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get(""), 1062f);
			}
		}
		else
		{
			BNAJNKBCLEJ.BJJOHMJACDG();
			LILJCAOBMFH();
		}
	}

	private void JECLPOMBINJ()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.MENNLOGFNOK(base.JIIGOACEIKL).CNOCEADFCLD(pCJEDMJEKEF, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private void JECACMKIALB()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
			if (!offeringSlot.PKFKJNODGJF())
			{
				OnlinePuzzleManager.instance.SendOfferingItemPlaced(ONCCKDONEFG.BELBIDDGNJN().mineLevel, offeringSlot.itemInstance.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false));
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void KJEKMDEKGMB(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.IHENCGDNPBL = KILHLOPKOMH.ACBPPCPKCBG();
		Slot slot = KILHLOPKOMH.ACBPPCPKCBG();
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(JGJPGEJKGEN));
		Slot slot2 = KILHLOPKOMH.ACBPPCPKCBG();
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(DKOJDJHDAAM));
		MainUI.SetCurrentContainer(JIIGOACEIKL, KILHLOPKOMH.LNGEKOJNKKM(), 0);
	}

	private void FNDJALHNLME()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(NJPADCBAJEC));
	}

	private void EPFDKCELPDD()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(ILBLPFDELDK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(ILBLPFDELDK));
	}

	private void LILJCAOBMFH()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).FCGJCBJGOIG()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.BGIMGOJDLFG(base.JIIGOACEIKL).JCOHBJLKLAI(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void NNMAPBIKEKJ()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FCGJCBJGOIG()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).CJODJMLPGOL(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private void GBNHKMLABGI()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(EPCIILDJAOG));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(MHEJAMJFKDG));
	}

	public void KLFJCONMBOO()
	{
		if (!LKOJBFMGMAE || (Object)(object)ONCCKDONEFG == (Object)null)
		{
			return;
		}
		IDOIABFOKOP = false;
		Slot slot = slotUI.IHENCGDNPBL;
		ItemInstance itemInstance = slot.itemInstance;
		if (itemInstance == null)
		{
			BOBCIFEDJED();
			return;
		}
		Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Remove(offeringSlot.OnItemAdded, new Action(AJGPAHAMNKB));
		Slot slot2 = ONCCKDONEFG.ACBPPCPKCBG();
		slot2.OnItemRemoved = (Action)Delegate.Remove(slot2.OnItemRemoved, new Action(NJJBPOCJFLG));
		if (ONCCKDONEFG.ABAFFBFGIHJ(itemInstance.KNFNJFFCFNO()))
		{
			slot.DJFOMFDOOKM(CDPAMNIPPEC: false);
			ONCCKDONEFG.KAKAIKPJBPF(base.JIIGOACEIKL, CDPAMNIPPEC: false);
			ONCCKDONEFG.PlaySuccessAnimation();
			ONCCKDONEFG.ClosePuzzle();
			ONCCKDONEFG = null;
		}
		else
		{
			ONCCKDONEFG.PlayFailAnimation();
			OnlinePuzzleManager.instance.SendOfferingFail(ONCCKDONEFG.NAMECAKIKHJ().mineLevel);
		}
		BOBCIFEDJED();
	}

	private void HGDKENOLMHK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null || ADEBNALPEHE.KPINNBKMOMO())
		{
			return;
		}
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("/Cheats.txt"), 1515f);
			}
		}
		else
		{
			BNAJNKBCLEJ.PLOCNJBAAHO();
			LILJCAOBMFH();
		}
	}

	private void NKPPFMBKJND()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).BBDOBNLMLGM()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.NALKHGMLALJ(base.JIIGOACEIKL).CJODJMLPGOL(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private void HMMBCKNLOOD()
	{
		if (LKOJBFMGMAE)
		{
			KLFJCONMBOO();
		}
	}

	private void LLLEALLKBMH()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(CCHBCMDNLKM));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(HGDKENOLMHK));
	}

	private void PCFFMFEOBLI()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).PJEIHOCPBLA(pCJEDMJEKEF, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private void IANGDMHMCEL()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(HGDKENOLMHK));
	}

	private void MIBIMHAICPD()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.MOKEEMCFJPE())
		{
			BNAJNKBCLEJ.EOCALKHEIJM();
			OnlinePuzzleManager.instance.SendOfferingItemCleared(ONCCKDONEFG.NAMECAKIKHJ().mineLevel);
		}
	}

	protected override void Start()
	{
		base.Start();
		slotUI.autoTransferEnabled = true;
	}

	private void LPKHACNBCLA()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(CCHBCMDNLKM));
	}

	public override void CloseUI()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		if (!IDOIABFOKOP)
		{
			OnOfferingItem();
			return;
		}
		IDOIABFOKOP = false;
		if ((Object)(object)ONCCKDONEFG != (Object)null)
		{
			Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
			offeringSlot.OnItemAdded = (Action)Delegate.Remove(offeringSlot.OnItemAdded, new Action(KGKGIHMPAHK));
			Slot offeringSlot2 = ONCCKDONEFG.GetOfferingSlot();
			offeringSlot2.OnItemRemoved = (Action)Delegate.Remove(offeringSlot2.OnItemRemoved, new Action(GJKFDDBIDPA));
			ONCCKDONEFG.ClosePuzzle();
			ONCCKDONEFG = null;
		}
		BNAJNKBCLEJ = null;
		MainUI.SetCurrentContainer(base.JIIGOACEIKL, null, 0);
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(new List<Slot>(Inventory.GetPlayer(base.JIIGOACEIKL).slots), OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		base.CloseUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(EFIMLDGMNEI));
	}

	public static OfferingStatueUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OnOfferingItem()
	{
		if (!LKOJBFMGMAE || (Object)(object)ONCCKDONEFG == (Object)null)
		{
			return;
		}
		IDOIABFOKOP = true;
		Slot slot = slotUI.IHENCGDNPBL;
		ItemInstance itemInstance = slot.itemInstance;
		if (itemInstance == null)
		{
			CloseUI();
			return;
		}
		Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Remove(offeringSlot.OnItemAdded, new Action(KGKGIHMPAHK));
		Slot offeringSlot2 = ONCCKDONEFG.GetOfferingSlot();
		offeringSlot2.OnItemRemoved = (Action)Delegate.Remove(offeringSlot2.OnItemRemoved, new Action(GJKFDDBIDPA));
		if (ONCCKDONEFG.IsOfferedItemValid(itemInstance.LHBPOPOIFLE()))
		{
			slot.MEODNPFJDMH();
			ONCCKDONEFG.PuzzleSolved(base.JIIGOACEIKL, CDPAMNIPPEC: true);
			ONCCKDONEFG.PlaySuccessAnimation();
			ONCCKDONEFG.ClosePuzzle(IEJDPOEOIBO: true);
			ONCCKDONEFG = null;
		}
		else
		{
			ONCCKDONEFG.PlayFailAnimation();
			OnlinePuzzleManager.instance.SendOfferingFail(ONCCKDONEFG.GetManager().mineLevel);
		}
		CloseUI();
	}

	private void HGEKPHOPJCD()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(CCHBCMDNLKM));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(MHEJAMJFKDG));
	}

	private void PGDAOMNADHA()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(EPCIILDJAOG));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(EPCIILDJAOG));
	}

	private void ALBGFPMHJPH()
	{
		if (LKOJBFMGMAE)
		{
			LBMHGJACBHG();
		}
	}

	private void PGDBFGFMGKI()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(ILBLPFDELDK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj2.OnAutomaticTransfer, new Action<int, Slot>(CEFJPFKBLAJ));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj3.OnSlotRightClick, new Action<int, Slot>(ILBLPFDELDK));
	}

	private void CEFJPFKBLAJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null || ADEBNALPEHE.PKFKJNODGJF())
		{
			return;
		}
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/15/Dialogue Text"), 1526f);
			}
		}
		else
		{
			BNAJNKBCLEJ.HIGKNDNMLFC();
			BICKFPGPION();
		}
	}

	private void EFIMLDGMNEI()
	{
		if (LKOJBFMGMAE)
		{
			OnOfferingItem();
		}
	}

	public static OfferingStatueUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LGIBNILPDEK()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			Slot slot = ONCCKDONEFG.ACBPPCPKCBG();
			if (!slot.AHHEMNHJPME())
			{
				OnlinePuzzleManager.instance.CDECKNBBGBG(ONCCKDONEFG.NAMECAKIKHJ().mineLevel, slot.itemInstance.PHGLMBIEOMK().ODENMDOJPLC(DAINLFIMLIH: false));
			}
		}
	}

	private void AJGPAHAMNKB()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			Slot slot = ONCCKDONEFG.HCIPKANLPKJ();
			if (!slot.LCHJGCHDHFO())
			{
				OnlinePuzzleManager.instance.PEIIHKMJGBB(ONCCKDONEFG.CEMEKIJMEAN().mineLevel, slot.itemInstance.KNFNJFFCFNO().CIGFGKKCPCK(DAINLFIMLIH: false));
			}
		}
	}

	public static OfferingStatueUI GDFNPHJJCPP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ABLDHJKDGGP()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.MOKEEMCFJPE())
		{
			BNAJNKBCLEJ.PLOCNJBAAHO();
			OnlinePuzzleManager.instance.SendOfferingItemCleared(ONCCKDONEFG.AJHGOJEHLED().mineLevel);
		}
	}

	private void LMABGOIHALE()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			BNAJNKBCLEJ.PLOCNJBAAHO();
			OnlinePuzzleManager.instance.JAGLHKLPIDN(ONCCKDONEFG.NAMECAKIKHJ().mineLevel);
		}
	}

	private IEnumerator FMAANCEEEMI()
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PJKBEFFDJIP(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.LIJPNDJCKGL(KILHLOPKOMH.ACBPPCPKCBG());
		Slot slot = KILHLOPKOMH.HCIPKANLPKJ();
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(JECACMKIALB));
		Slot offeringSlot = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot.OnItemRemoved = (Action)Delegate.Combine(offeringSlot.OnItemRemoved, new Action(ABLDHJKDGGP));
		MainUI.GBEIHIDIDAD(JIIGOACEIKL, KILHLOPKOMH.GetOfferingContainer(), 0);
	}

	private void ADEBBJOALDN()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(EPCIILDJAOG));
	}

	private void MAEGGDLLHBG()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(HGDKENOLMHK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(MHEJAMJFKDG));
	}

	public void LOOMJLANNEG(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.IHENCGDNPBL = KILHLOPKOMH.ACBPPCPKCBG();
		Slot slot = KILHLOPKOMH.HCIPKANLPKJ();
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(HPBOLEAPOMP));
		Slot slot2 = KILHLOPKOMH.ACBPPCPKCBG();
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(EMDBPBAFGPB));
		MainUI.PCMOFKMCNCM(JIIGOACEIKL, KILHLOPKOMH.EAFDBPADLNA(), 1);
	}

	private void CIJFFFFDFFL()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.MOKEEMCFJPE())
		{
			BNAJNKBCLEJ.HIGKNDNMLFC();
			OnlinePuzzleManager.instance.JAGLHKLPIDN(ONCCKDONEFG.GetManager().mineLevel);
		}
	}

	private IEnumerator ACPOEMMHEOJ()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotUI).gameObject);
		}
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotUI).gameObject);
		}
	}

	private void MEHILHIAGKE()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBDOBNLMLGM()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).JCOHBJLKLAI(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void NJJBPOCJFLG()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.MOKEEMCFJPE())
		{
			BNAJNKBCLEJ.EOCALKHEIJM();
			OnlinePuzzleManager.instance.SendOfferingItemCleared(ONCCKDONEFG.CEMEKIJMEAN().mineLevel);
		}
	}

	private void GJKFDDBIDPA()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			BNAJNKBCLEJ.Deactivate();
			OnlinePuzzleManager.instance.SendOfferingItemCleared(ONCCKDONEFG.GetManager().mineLevel);
		}
	}

	private void EMDBPBAFGPB()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			BNAJNKBCLEJ.BJJOHMJACDG();
			OnlinePuzzleManager.instance.SendOfferingItemCleared(ONCCKDONEFG.GetManager().mineLevel);
		}
	}

	private void JNNJIDAFBPI()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(CEFJPFKBLAJ));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(HGDKENOLMHK));
	}

	public void LBMHGJACBHG()
	{
		if (!LKOJBFMGMAE || (Object)(object)ONCCKDONEFG == (Object)null)
		{
			return;
		}
		IDOIABFOKOP = false;
		Slot slot = slotUI.IHENCGDNPBL;
		ItemInstance itemInstance = slot.itemInstance;
		if (itemInstance == null)
		{
			BOBCIFEDJED();
			return;
		}
		Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Remove(offeringSlot.OnItemAdded, new Action(JECACMKIALB));
		Slot slot2 = ONCCKDONEFG.HCIPKANLPKJ();
		slot2.OnItemRemoved = (Action)Delegate.Remove(slot2.OnItemRemoved, new Action(CIJFFFFDFFL));
		if (ONCCKDONEFG.JMKGMCMLGGF(itemInstance.PHGLMBIEOMK()))
		{
			slot.DJFOMFDOOKM(CDPAMNIPPEC: false);
			ONCCKDONEFG.PuzzleSolved(base.JIIGOACEIKL, CDPAMNIPPEC: false);
			ONCCKDONEFG.DHILGLJPFDL();
			ONCCKDONEFG.PNGGHNBGMJN();
			ONCCKDONEFG = null;
		}
		else
		{
			ONCCKDONEFG.PlayFailAnimation();
			OnlinePuzzleManager.instance.SendOfferingFail(ONCCKDONEFG.GetManager().mineLevel);
		}
		BOBCIFEDJED();
	}

	private IEnumerator IKLPJGGBJFI()
	{
		return new IJCEBJADHNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GGGBFIPEKAC()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBDOBNLMLGM()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.Get(base.JIIGOACEIKL).CNOCEADFCLD(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private void AHCPFICKFHA()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(CCHBCMDNLKM));
	}

	private void AMGHIFFGHDI()
	{
		if (LKOJBFMGMAE)
		{
			JAOINIIELBL();
		}
	}

	private void BICKFPGPION()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FCGJCBJGOIG()
			where x.itemInstance != null
			select x).ToList();
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).PJEIHOCPBLA(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			NIILOKCNLEN();
			base.OpenUI();
			DJJFMDHGOKN(EFIMLDGMNEI);
		}
	}

	private IEnumerator KKCGLOKCIML()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotUI).gameObject);
		}
	}

	private void HPBOLEAPOMP()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.IsReceivingFromNetwork())
		{
			Slot slot = ONCCKDONEFG.HCIPKANLPKJ();
			if (!slot.AHHEMNHJPME())
			{
				OnlinePuzzleManager.instance.PEIIHKMJGBB(ONCCKDONEFG.CEMEKIJMEAN().mineLevel, slot.itemInstance.PHGLMBIEOMK().IMCJPECAAPC(DAINLFIMLIH: false));
			}
		}
	}

	public void OJGHFJMCKDB(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.MHNCEBLHLKH(KILHLOPKOMH.GetOfferingSlot());
		Slot offeringSlot = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot.OnItemAdded = (Action)Delegate.Combine(offeringSlot.OnItemAdded, new Action(PBOHJILCMHI));
		Slot offeringSlot2 = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot2.OnItemRemoved = (Action)Delegate.Combine(offeringSlot2.OnItemRemoved, new Action(HLLPJIECENJ));
		MainUI.GBEIHIDIDAD(JIIGOACEIKL, KILHLOPKOMH.EAFDBPADLNA(), 0);
	}

	private void NJPADCBAJEC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null || ADEBNALPEHE.AHHEMNHJPME())
		{
			return;
		}
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Modifiers"), 1800f);
			}
		}
		else
		{
			BNAJNKBCLEJ.EOCALKHEIJM();
			NNMAPBIKEKJ();
		}
	}

	public static OfferingStatueUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Update()
	{
		if (IsOpen())
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown(ActionType.UIAddRemove))
			{
				OnOfferingItem();
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown(ActionType.ClosePopUp))
			{
				OnOfferingItem();
			}
		}
		base.Update();
	}

	private void CCHBCMDNLKM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null || ADEBNALPEHE.PKFKJNODGJF())
		{
			return;
		}
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Idle"), 128f);
			}
		}
		else
		{
			BNAJNKBCLEJ.BJJOHMJACDG();
			PCFFMFEOBLI();
		}
	}

	private void KJJAGKNOFIG()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(ILBLPFDELDK));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(NJPADCBAJEC));
	}

	private void BPINJGFECPF()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(NJPADCBAJEC));
		SlotUI obj2 = slotUI;
		obj2.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj2.OnAutomaticTransfer, new Action<int, Slot>(MHEJAMJFKDG));
		SlotUI obj3 = slotUI;
		obj3.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj3.OnSlotRightClick, new Action<int, Slot>(HGDKENOLMHK));
	}

	public void EJBAFPGLGKP(OfferingStatuePuzzle KILHLOPKOMH, OfferingStatueAnimator ONDMDLMHMHK, int JIIGOACEIKL)
	{
		ONCCKDONEFG = KILHLOPKOMH;
		BNAJNKBCLEJ = ONDMDLMHMHK;
		slotUI.MHNCEBLHLKH(KILHLOPKOMH.ACBPPCPKCBG());
		Slot slot = KILHLOPKOMH.ACBPPCPKCBG();
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(LGIBNILPDEK));
		Slot offeringSlot = KILHLOPKOMH.GetOfferingSlot();
		offeringSlot.OnItemRemoved = (Action)Delegate.Combine(offeringSlot.OnItemRemoved, new Action(ABLDHJKDGGP));
		MainUI.SetCurrentContainer(JIIGOACEIKL, KILHLOPKOMH.EAFDBPADLNA(), 1);
	}

	private void PBOHJILCMHI()
	{
		if (!((Object)(object)ONCCKDONEFG == (Object)null) && !ONCCKDONEFG.MOKEEMCFJPE())
		{
			Slot offeringSlot = ONCCKDONEFG.GetOfferingSlot();
			if (!offeringSlot.KPINNBKMOMO())
			{
				OnlinePuzzleManager.instance.CDECKNBBGBG(ONCCKDONEFG.GetManager().mineLevel, offeringSlot.itemInstance.PHGLMBIEOMK().ODENMDOJPLC(DAINLFIMLIH: false));
			}
		}
	}

	public static OfferingStatueUI OCCEHEMCGJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EPCIILDJAOG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if ((Object)(object)ONCCKDONEFG == (Object)null || ADEBNALPEHE.KPINNBKMOMO())
		{
			return;
		}
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Error Fireplace.TurnOff: "), 1955f);
			}
		}
		else
		{
			BNAJNKBCLEJ.HIGKNDNMLFC();
			PCFFMFEOBLI();
		}
	}
}
