using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T111_ServirCervezas : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class BGBGBBECCHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T111_ServirCervezas _003C_003E4__this;

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
		public BGBGBBECCHB(int _003C_003E1__state)
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
			T111_ServirCervezas t111_ServirCervezas = _003C_003E4__this;
			switch (num)
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
				t111_ServirCervezas.LHKIJABBBPM();
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
	private sealed class OBPMBDOHEAB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T111_ServirCervezas _003C_003E4__this;

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
		public OBPMBDOHEAB(int _003C_003E1__state)
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
			T111_ServirCervezas t111_ServirCervezas = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0082;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0082;
			case 3:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", t111_ServirCervezas.triggerPlayerNum);
				goto IL_00f1;
			case 4:
				_003C_003E1__state = -1;
				goto IL_00f1;
			case 5:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.ShowPopUp();
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(t111_ServirCervezas.DPIFOKCMOIC));
					return false;
				}
				IL_00f1:
				if (t111_ServirCervezas.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.waitRealtime1;
				_003C_003E1__state = 5;
				return true;
				IL_0082:
				if (!t111_ServirCervezas.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t111_ServirCervezas).StartCoroutine(t111_ServirCervezas.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
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

	private int BHPIHLNNFOF;

	private void MOJEHBDAFEM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().BLOAFCBKKNA(72) && !Inventory.IAAFEENHLKB(0, LAGHIOKLJGH: true).CJFHKNKCBHA(-90) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.GOKIDLOELKB(-60, GGBBJNBBLMF: true)) && !Inventory.KEHIBCAHKPJ(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(163) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.COEFFIHKMJG(-4)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EDBMEAGMKME));
				((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().ODINMCGGHKB(-3) && !Inventory.KEHIBCAHKPJ(0).HasItem(-17) && !PlayerController.GetPlayer(1).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.AFOACBIHNCL(-7, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FFAGCBMPJON));
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
		}
	}

	private IEnumerator AGFLJLODJJK()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void LNBLCJOHFDI(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().AHMOBAJJDDH(-69) && !Inventory.OPHDCMJLLEC(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(33) && !PlayerController.GetPlayer(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.EABMGELAAPG(40, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.IOLAIFGMHEA(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(192) && !PlayerController.OPHDCMJLLEC(8).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.INJBNHPGCIJ(48, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EJIKCOGOLON));
				((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().KJNJPJJMMFG(157) && !Inventory.KEHIBCAHKPJ(1, LAGHIOKLJGH: true).CJFHKNKCBHA(-137) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.AFOACBIHNCL(115, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EEKCIKFJFPA));
			((MonoBehaviour)this).StartCoroutine(CFCMKAPFPCE());
		}
	}

	private IEnumerator NCBODCOOANK()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void DPIFOKCMOIC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.HasDrink(1533) && !Inventory.GetPlayer(1).HasItem(1533) && !PlayerController.GetPlayer(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.GetItem(1533)) && !Inventory.GetPlayer(2).HasItem(1533) && !PlayerController.GetPlayer(2).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.GetItem(1533)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.HasDrink(1533) && !Inventory.GetPlayer(1).HasItem(1533) && !PlayerController.GetPlayer(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.GetItem(1533)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void LHHGNOALIKB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JFNOOMJMHCB().ODINMCGGHKB(-153) && !Inventory.KCOBKJNCKNP(0).HasItem(-121) && !PlayerController.GetPlayer(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.CPMMBEPEJLO(-185, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.JDADPDBHJFO(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-185) && !PlayerController.GetPlayer(3).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.AFOACBIHNCL(93, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JNEOBBPBNAI));
				((MonoBehaviour)this).StartCoroutine(FLECFIDDCJE());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().HasDrink(193) && !Inventory.OPHDCMJLLEC(0, LAGHIOKLJGH: true).HasItem(40) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.AFOACBIHNCL(67)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PCBEPNCIMKK));
			((MonoBehaviour)this).StartCoroutine(BCPNMIIJIEJ());
		}
	}

	private IEnumerator HHDLDPPCLPE()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator NKOJNIDHGBJ()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MDFFFPLNDAP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IPFJPIGKLBE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.LFIALOLFOOD(132) && !Inventory.NLEFGNHMJNN(1).CJFHKNKCBHA(44) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.EABMGELAAPG(161, GGBBJNBBLMF: true)) && !Inventory.AELPIFHLOAH(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(171) && !PlayerController.OPHDCMJLLEC(2).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.GOKIDLOELKB(6, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KBPFEFKKHDA));
				((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().LFIALOLFOOD(-72) && !Inventory.GFHCACLMFDK(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-136) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.EABMGELAAPG(-186, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(IKCMEHNHLOE));
			((MonoBehaviour)this).StartCoroutine(ODILJEKMFLO());
		}
	}

	private void BEHCIMINICF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().HasDrink(-156) && !Inventory.IOLAIFGMHEA(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(89) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.COEFFIHKMJG(-127, GGBBJNBBLMF: true)) && !Inventory.GFHCACLMFDK(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(44) && !PlayerController.GetPlayer(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.GetItem(21, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BIFDLDIDJMB));
				((MonoBehaviour)this).StartCoroutine(ODILJEKMFLO());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().LFIALOLFOOD(11) && !Inventory.IGMCBPOPNCA(1, LAGHIOKLJGH: true).HasItem(-150) && !PlayerController.GetPlayer(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.CPMMBEPEJLO(-156, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EJIKCOGOLON));
			((MonoBehaviour)this).StartCoroutine(BCPNMIIJIEJ());
		}
	}

	private IEnumerator BCNPEOJDCIF()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IHGGOFFGMBD()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NNKFBMKFBMN()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KBPFEFKKHDA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().HADIAMMDNKB(81) && !Inventory.IECFJGHAIDO(0).CJFHKNKCBHA(55) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.AFOACBIHNCL(-78, GGBBJNBBLMF: true)) && !Inventory.NBEGPFFBKPO(2, LAGHIOKLJGH: true).HasItem(9) && !PlayerController.OPHDCMJLLEC(3).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.GOKIDLOELKB(0, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DKHIOIANENC));
				((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
			}
		}
		else if (!DrinkDispensersManager.OLHBLKIAFOM().FHPJNNDCNOI(-164) && !Inventory.NLEFGNHMJNN(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(94) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.GOKIDLOELKB(-11, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LJFHBGEMNLM));
			((MonoBehaviour)this).StartCoroutine(NBAELEJAFAN());
		}
	}

	private void JPMPHHGCIAB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().HasDrink(38) && !Inventory.HHONLOCNFNC(0, LAGHIOKLJGH: true).JKLEPGLMCEG(82) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.EABMGELAAPG(150, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.JPDEFKLINCL(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(75) && !PlayerController.GetPlayer(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.GetItem(-58, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LHHGNOALIKB));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			}
		}
		else if (!DrinkDispensersManager.OLHBLKIAFOM().KJNJPJJMMFG(-38) && !Inventory.IOLAIFGMHEA(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(27) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.EABMGELAAPG(-77, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PELAJAMHPGE));
			((MonoBehaviour)this).StartCoroutine(NBAELEJAFAN());
		}
	}

	private IEnumerator BCPNMIIJIEJ()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JECHOKLEDDA()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LLOFDFALKNL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JFNOOMJMHCB().ODINMCGGHKB(38) && !Inventory.BNMEANGDMIP(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-105) && !PlayerController.GetPlayer(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.EABMGELAAPG(-64, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.ILAOFABODGO(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(187) && !PlayerController.OPHDCMJLLEC(8).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.GOKIDLOELKB(-150, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
				((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().FHPJNNDCNOI(57) && !Inventory.IOBMIHLMGNH(1).JKLEPGLMCEG(-40) && !PlayerController.GetPlayer(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.GOKIDLOELKB(121)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JGHLMBGPAAL));
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator AOJFNNKFCBL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ODILJEKMFLO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AJOIEAICINP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NCNGHNLFCBO()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void BNGDOCEOPBA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().ODINMCGGHKB(54) && !Inventory.DAEEJGKLOCF(1).HasItem(-148) && !PlayerController.GetPlayer(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.EABMGELAAPG(-86, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.KCOBKJNCKNP(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(-144) && !PlayerController.OPHDCMJLLEC(5).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.EABMGELAAPG(-69, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JGHLMBGPAAL));
				((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().ODINMCGGHKB(107) && !Inventory.AGEHIILFADF(0).CJFHKNKCBHA(139) && !PlayerController.GetPlayer(0).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.AFOACBIHNCL(81)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PELAJAMHPGE));
			((MonoBehaviour)this).StartCoroutine(FDAPBNJHNJG());
		}
	}

	private void PELAJAMHPGE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().KJNJPJJMMFG(-110) && !Inventory.MJJHNNJKEMO(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(86) && !PlayerController.GetPlayer(1).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.GOKIDLOELKB(126, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.HHONLOCNFNC(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-58) && !PlayerController.GetPlayer(8).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.CPMMBEPEJLO(-145, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LCDLJJNCFNI));
				((MonoBehaviour)this).StartCoroutine(FDAPBNJHNJG());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().AKLEGLCOOCO(111) && !Inventory.BDPPNLODPGN(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(109) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.GOKIDLOELKB(-65, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HPBMLBGIIOM));
			((MonoBehaviour)this).StartCoroutine(BCNPEOJDCIF());
		}
	}

	private void EEKCIKFJFPA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.AHMOBAJJDDH(34) && !Inventory.PLHHJCNKNFO(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(131) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.INJBNHPGCIJ(-64, GGBBJNBBLMF: true)) && !Inventory.BDENIHLMMHB(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(-154) && !PlayerController.GetPlayer(0).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.KMBGJEKCJFJ(-2, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LHFAGIJNKLJ));
				((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().DEBMDAEBEKA(171) && !Inventory.IMJOOACMADK(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-186) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.KMBGJEKCJFJ(12, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BPNOEAOJIHP));
			((MonoBehaviour)this).StartCoroutine(ODILJEKMFLO());
		}
	}

	private void ABPKDFKACOJ(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().HADIAMMDNKB(-98) && !Inventory.IOLAIFGMHEA(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-24) && !PlayerController.GetPlayer(1).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.COEFFIHKMJG(199)) && !Inventory.EIFPKCAFDIB(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-67) && !PlayerController.GetPlayer(8).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.GetItem(-153, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(OICHHPJOMDL));
				((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().AKLEGLCOOCO(90) && !Inventory.HHONLOCNFNC(0, LAGHIOKLJGH: true).HasItem(157) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.AFOACBIHNCL(-88, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BIFDLDIDJMB));
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
		}
	}

	private IEnumerator BAGKLMIFNIH()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBOCOLCBOIL()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FAEKOKEINEH()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator OGOFIFJCMEB()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AFHGHLOCAPA()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JHBNODHNMCI()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator AJJPECIKMJN()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GACJBLGDMFG()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LJFHBGEMNLM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().AHMOBAJJDDH(-197) && !Inventory.IOLAIFGMHEA(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-193) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.EABMGELAAPG(199, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.MPDMDABCCCA(0, LAGHIOKLJGH: true).JKLEPGLMCEG(130) && !PlayerController.OPHDCMJLLEC(6).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.INJBNHPGCIJ(181, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DBMJAJEPNJB));
				((MonoBehaviour)this).StartCoroutine(ODILJEKMFLO());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().AHMOBAJJDDH(37) && !Inventory.KEHIBCAHKPJ(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-33) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.GOKIDLOELKB(-71)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LNBLCJOHFDI));
			((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
		}
	}

	private void DCGCHOGGHDM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.DEBMDAEBEKA(-104) && !Inventory.OPHDCMJLLEC(0, LAGHIOKLJGH: true).CJFHKNKCBHA(-74) && !PlayerController.GetPlayer(0).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.EABMGELAAPG(-175, GGBBJNBBLMF: true)) && !Inventory.IMJOOACMADK(2).CJFHKNKCBHA(-101) && !PlayerController.GetPlayer(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.KMBGJEKCJFJ(169, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DNJMHDBOGOC));
				((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
			}
		}
		else if (!DrinkDispensersManager.OLHBLKIAFOM().HasDrink(-56) && !Inventory.DACNEICGAAE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-35) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.GOKIDLOELKB(23, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DCGCHOGGHDM));
			((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
		}
	}

	private IEnumerator NBONAPPPLMN()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator BCALBKDNAJH()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator NHGHCANHKFA()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CLCOEDFCDPK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AAGGGIONDAG()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void JGHLMBGPAAL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().ODINMCGGHKB(3) && !Inventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).HasItem(40) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.AFOACBIHNCL(-29, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.MPDMDABCCCA(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-167) && !PlayerController.GetPlayer(4).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.EABMGELAAPG(123, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(OICHHPJOMDL));
				((MonoBehaviour)this).StartCoroutine(JDJNAEIOJLP());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.ODINMCGGHKB(46) && !Inventory.EIFPKCAFDIB(0).HasItem(145) && !PlayerController.GetPlayer(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.AFOACBIHNCL(45, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOFDFALKNL));
			((MonoBehaviour)this).StartCoroutine(GACJBLGDMFG());
		}
	}

	private IEnumerator ANLLGDBMBAE()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKCEGEOJLO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ELPDKDFFJJD()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBAELEJAFAN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void GCLPDEFENHL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().LFIALOLFOOD(-195) && !Inventory.DAEEJGKLOCF(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(198) && !PlayerController.GetPlayer(1).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.EABMGELAAPG(37, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.MHFEFCLBAJG(2, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-53) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.GOKIDLOELKB(-192)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BNGDOCEOPBA));
				((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().AHMOBAJJDDH(-68) && !Inventory.IGMCBPOPNCA(0).JKLEPGLMCEG(162) && !PlayerController.GetPlayer(0).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.KMBGJEKCJFJ(-167, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(IPFJPIGKLBE));
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
		}
	}

	private IEnumerator KMIBOOOFJKB()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void AJDKJBHKEJN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JFNOOMJMHCB().KJNJPJJMMFG(-183) && !Inventory.OPHDCMJLLEC(1).JKLEPGLMCEG(-121) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.KMBGJEKCJFJ(-30, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.NHHOGHLEODI(0).HasItem(-111) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.GetItem(161, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(MBDJIDCDOAF));
				((MonoBehaviour)this).StartCoroutine(NBAELEJAFAN());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.AHMOBAJJDDH(143) && !Inventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-121) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.GOKIDLOELKB(191, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(IKCMEHNHLOE));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private IEnumerator AAOCEAKDPDK()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator KFKLJPJJFLJ()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator EOCBHNPFJLL()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	public override int GetID()
	{
		return 111;
	}

	private IEnumerator MIGPNMAOJPK()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OICHHPJOMDL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().DEBMDAEBEKA(35) && !Inventory.GIAOPMIDGPL(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(80) && !PlayerController.GetPlayer(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.GetItem(147)) && !Inventory.NHHOGHLEODI(2, LAGHIOKLJGH: true).HasItem(81) && !PlayerController.GetPlayer(6).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.INJBNHPGCIJ(16, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LJFHBGEMNLM));
				((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.ODINMCGGHKB(54) && !Inventory.NLEFGNHMJNN(0, LAGHIOKLJGH: true).HasItem(-107) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.KMBGJEKCJFJ(-186)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FFAGCBMPJON));
			((MonoBehaviour)this).StartCoroutine(NHGHCANHKFA());
		}
	}

	private IEnumerator FDAPBNJHNJG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void IKCMEHNHLOE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().AKLEGLCOOCO(140) && !Inventory.JFIPFFDLDKB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(150) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.GOKIDLOELKB(-52)) && !Inventory.IOLAIFGMHEA(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-46) && !PlayerController.OPHDCMJLLEC(4).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.AFOACBIHNCL(173)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOFDFALKNL));
				((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().DEBMDAEBEKA(163) && !Inventory.EIFPKCAFDIB(0).HasItem(24) && !PlayerController.GetPlayer(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.KMBGJEKCJFJ(116, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PCBEPNCIMKK));
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
		}
	}

	private IEnumerator KMOGEGDEDPC()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void JIHPKHPNDGE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.AKLEGLCOOCO(5) && !Inventory.KCOBKJNCKNP(0, LAGHIOKLJGH: true).JKLEPGLMCEG(52) && !PlayerController.GetPlayer(0).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.GetItem(102)) && !Inventory.ILAOFABODGO(0).JKLEPGLMCEG(-107) && !PlayerController.GetPlayer(5).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.KMBGJEKCJFJ(137, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DKHIOIANENC));
				((MonoBehaviour)this).StartCoroutine(NCBODCOOANK());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().HasDrink(-42) && !Inventory.GFHCACLMFDK(1).CJFHKNKCBHA(25) && !PlayerController.GetPlayer(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.COEFFIHKMJG(8, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EDBMEAGMKME));
			((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
		}
	}

	private void OOANAMPPINM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().HasDrink(184) && !Inventory.ILAOFABODGO(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(-127) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.CPMMBEPEJLO(114, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.IMJOOACMADK(5).JKLEPGLMCEG(-162) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.GOKIDLOELKB(-174)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(ABPKDFKACOJ));
				((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().AKLEGLCOOCO(-94) && !Inventory.IMJOOACMADK(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-10) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.CPMMBEPEJLO(128)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PELAJAMHPGE));
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
		}
	}

	private IEnumerator HHLKPNANHKK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JBBPOCHHHND()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator CFCMKAPFPCE()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FCJODFOFODL()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void MBDJIDCDOAF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().HADIAMMDNKB(67) && !Inventory.MPDMDABCCCA(1).JKLEPGLMCEG(176) && !PlayerController.GetPlayer(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.EABMGELAAPG(41, GGBBJNBBLMF: true)) && !Inventory.IECFJGHAIDO(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(120) && !PlayerController.OPHDCMJLLEC(5).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.GetItem(-8, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(ABPKDFKACOJ));
				((MonoBehaviour)this).StartCoroutine(JECHOKLEDDA());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().BLOAFCBKKNA(191) && !Inventory.GetPlayer(1).HasItem(-107) && !PlayerController.GetPlayer(0).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.GOKIDLOELKB(79, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOFDFALKNL));
			((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
		}
	}

	private void HPBMLBGIIOM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().AKLEGLCOOCO(154) && !Inventory.JDADPDBHJFO(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-156) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.KMBGJEKCJFJ(60, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.GFHCACLMFDK(3, LAGHIOKLJGH: true).CJFHKNKCBHA(70) && !PlayerController.GetPlayer(1).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.GetItem(-87, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JLKAAJKJHNE));
				((MonoBehaviour)this).StartCoroutine(JDJNAEIOJLP());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.DEBMDAEBEKA(52) && !Inventory.AGEHIILFADF(1).CJFHKNKCBHA(-56) && !PlayerController.GetPlayer(0).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.EABMGELAAPG(146)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FFAGCBMPJON));
			((MonoBehaviour)this).StartCoroutine(BCNPEOJDCIF());
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
		BHPIHLNNFOF = 0;
	}

	private IEnumerator HGFPMNKEMAC()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BPNOEAOJIHP(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().HasDrink(84) && !Inventory.BNMEANGDMIP(1, LAGHIOKLJGH: true).CJFHKNKCBHA(170) && !PlayerController.GetPlayer(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.CPMMBEPEJLO(66)) && !Inventory.BDENIHLMMHB(2, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(172) && !PlayerController.GetPlayer(8).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.COEFFIHKMJG(-125, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DCGCHOGGHDM));
				((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.HADIAMMDNKB(96) && !Inventory.HHONLOCNFNC(1, LAGHIOKLJGH: true).JKLEPGLMCEG(88) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.KMBGJEKCJFJ(-32, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PBONGBBBFIO));
			((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
		}
	}

	private IEnumerator GEFGNPHFAHG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void PBONGBBBFIO(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().AKLEGLCOOCO(142) && !Inventory.ILAOFABODGO(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-168) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.AFOACBIHNCL(45)) && !Inventory.BDENIHLMMHB(1).CJFHKNKCBHA(-96) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.EABMGELAAPG(-84, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
				((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().FHPJNNDCNOI(-56) && !Inventory.NBEGPFFBKPO(1).CJFHKNKCBHA(-39) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.EABMGELAAPG(-170, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DNJMHDBOGOC));
			((MonoBehaviour)this).StartCoroutine(GACJBLGDMFG());
		}
	}

	private IEnumerator JLDPBKAEOJH()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JOBFBHOMJNC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void DBMJAJEPNJB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().DEBMDAEBEKA(121) && !Inventory.OPHDCMJLLEC(1).CJFHKNKCBHA(181) && !PlayerController.GetPlayer(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.CPMMBEPEJLO(146)) && !Inventory.DAEEJGKLOCF(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(157) && !PlayerController.GetPlayer(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.CPMMBEPEJLO(-72, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(GCLPDEFENHL));
				((MonoBehaviour)this).StartCoroutine(JDJNAEIOJLP());
			}
		}
		else if (!DrinkDispensersManager.OLHBLKIAFOM().FHPJNNDCNOI(-2) && !Inventory.AFMOAONHHNL(0, LAGHIOKLJGH: true).CJFHKNKCBHA(24) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.EABMGELAAPG(144, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PBONGBBBFIO));
			((MonoBehaviour)this).StartCoroutine(JDJNAEIOJLP());
		}
	}

	private IEnumerator BOMICOPCCML()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void DKHIOIANENC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.AKLEGLCOOCO(-53) && !Inventory.IAAFEENHLKB(0, LAGHIOKLJGH: true).CJFHKNKCBHA(129) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.GetItem(-179, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.NHHOGHLEODI(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-172) && !PlayerController.OPHDCMJLLEC(7).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.GOKIDLOELKB(150, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FFAGCBMPJON));
				((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.DEBMDAEBEKA(-186) && !Inventory.BDENIHLMMHB(0).JKLEPGLMCEG(-133) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.COEFFIHKMJG(127)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LHHGNOALIKB));
			((MonoBehaviour)this).StartCoroutine(JECHOKLEDDA());
		}
	}

	private void DNJMHDBOGOC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.HADIAMMDNKB(86) && !Inventory.MHFEFCLBAJG(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(26) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.EABMGELAAPG(-102, GGBBJNBBLMF: true)) && !Inventory.KEHIBCAHKPJ(5).CJFHKNKCBHA(37) && !PlayerController.GetPlayer(5).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.GetItem(180, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOFDFALKNL));
				((MonoBehaviour)this).StartCoroutine(NBAELEJAFAN());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.BLOAFCBKKNA(10) && !Inventory.AFMOAONHHNL(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(174) && !PlayerController.GetPlayer(0).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.CPMMBEPEJLO(95, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(ABPKDFKACOJ));
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator KEBCOCFPNIG()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void LCDLJJNCFNI(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().FHPJNNDCNOI(-116) && !Inventory.AELPIFHLOAH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-40) && !PlayerController.GetPlayer(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.EABMGELAAPG(-52, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.OPHDCMJLLEC(3, LAGHIOKLJGH: true).JKLEPGLMCEG(-151) && !PlayerController.GetPlayer(3).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.CPMMBEPEJLO(125, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(ANCOABBOFPD));
				((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
			}
		}
		else if (!DrinkDispensersManager.OLHBLKIAFOM().HasDrink(170) && !Inventory.IAAFEENHLKB(1, LAGHIOKLJGH: true).JKLEPGLMCEG(53) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.CPMMBEPEJLO(-8, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DKHIOIANENC));
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
		}
	}

	private IEnumerator DNAAOCABLNF()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ALLNELLCCFL()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MJKLEEHELIH()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JDJNAEIOJLP()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PCBEPNCIMKK(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().HADIAMMDNKB(151) && !Inventory.NHHOGHLEODI(0).JKLEPGLMCEG(-3) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.GOKIDLOELKB(-192, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.JDADPDBHJFO(3, LAGHIOKLJGH: true).CJFHKNKCBHA(43) && !PlayerController.GetPlayer(3).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.KMBGJEKCJFJ(-80, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KELIMCCOOCE));
				((MonoBehaviour)this).StartCoroutine(JECHOKLEDDA());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().ODINMCGGHKB(-9) && !Inventory.IOLAIFGMHEA(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(186) && !PlayerController.GetPlayer(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.EABMGELAAPG(174, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(MBDJIDCDOAF));
			((MonoBehaviour)this).StartCoroutine(NBAELEJAFAN());
		}
	}

	private void EJIKCOGOLON(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().LFIALOLFOOD(3) && !Inventory.BNMEANGDMIP(0).HasItem(18) && !PlayerController.GetPlayer(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.EABMGELAAPG(185, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.GetPlayer(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-19) && !PlayerController.GetPlayer(5).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.CPMMBEPEJLO(42, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JNEOBBPBNAI));
				((MonoBehaviour)this).StartCoroutine(MJKLEEHELIH());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().AKLEGLCOOCO(-82) && !Inventory.AFMOAONHHNL(0).HasItem(95) && !PlayerController.GetPlayer(0).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.EABMGELAAPG(196, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PCBEPNCIMKK));
			((MonoBehaviour)this).StartCoroutine(JDJNAEIOJLP());
		}
	}

	private IEnumerator EKMOJHNJOCG()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator NPCCKFEDCHI()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MGHHGMLMMJC()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFKKGFOFLBJ()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NHPCNDODFAK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JKFNHFDPOJN()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AEMAMJOHIOA()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FFAGCBMPJON(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().AKLEGLCOOCO(-108) && !Inventory.MPDMDABCCCA(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-163) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.KMBGJEKCJFJ(61)) && !Inventory.DAEEJGKLOCF(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(96) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.KMBGJEKCJFJ(41)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(OICHHPJOMDL));
				((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().LFIALOLFOOD(-2) && !Inventory.IAAFEENHLKB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(115) && !PlayerController.GetPlayer(0).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.KMBGJEKCJFJ(-40, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HPBMLBGIIOM));
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
		}
	}

	private void KELIMCCOOCE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().DEBMDAEBEKA(45) && !Inventory.BDPPNLODPGN(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(64) && !PlayerController.GetPlayer(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.GetItem(101)) && !Inventory.AFMOAONHHNL(5, LAGHIOKLJGH: true).HasItem(-122) && !PlayerController.GetPlayer(0).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.INJBNHPGCIJ(-138, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BIFDLDIDJMB));
				((MonoBehaviour)this).StartCoroutine(JDJNAEIOJLP());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().FHPJNNDCNOI(32) && !Inventory.PLHHJCNKNFO(1).JKLEPGLMCEG(146) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.EABMGELAAPG(98, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JPMPHHGCIAB));
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
		}
	}

	private IEnumerator JIBIJLBJMCH()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void JLKAAJKJHNE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.ODINMCGGHKB(22) && !Inventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-123) && !PlayerController.GetPlayer(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.INJBNHPGCIJ(24, GGBBJNBBLMF: true)) && !Inventory.DAEEJGKLOCF(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(80) && !PlayerController.GetPlayer(8).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.GetItem(-57, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EEKCIKFJFPA));
				((MonoBehaviour)this).StartCoroutine(FDAPBNJHNJG());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().BLOAFCBKKNA(-169) && !Inventory.IOLAIFGMHEA(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(-116) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.AFOACBIHNCL(-146)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LCDLJJNCFNI));
			((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
		}
	}

	private void EDBMEAGMKME(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().ODINMCGGHKB(-94) && !Inventory.NLEFGNHMJNN(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-109) && !PlayerController.GetPlayer(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.GOKIDLOELKB(45, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.IECFJGHAIDO(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(149) && !PlayerController.GetPlayer(2).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.CPMMBEPEJLO(-164, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BPNOEAOJIHP));
				((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.LFIALOLFOOD(136) && !Inventory.BNMEANGDMIP(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(4) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.AFOACBIHNCL(4, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EEKCIKFJFPA));
			((MonoBehaviour)this).StartCoroutine(HFKKGFOFLBJ());
		}
	}

	private IEnumerator FLECFIDDCJE()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JNEOBBPBNAI(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().AKLEGLCOOCO(71) && !Inventory.IMJOOACMADK(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(5) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.GetItem(107)) && !Inventory.MJJHNNJKEMO(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(74) && !PlayerController.GetPlayer(8).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.CPMMBEPEJLO(74, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LCDLJJNCFNI));
				((MonoBehaviour)this).StartCoroutine(BCNPEOJDCIF());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().AHMOBAJJDDH(-132) && !Inventory.GFHCACLMFDK(0).HasItem(-52) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.KMBGJEKCJFJ(-67, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JIHPKHPNDGE));
			((MonoBehaviour)this).StartCoroutine(MGHHGMLMMJC());
		}
	}

	private IEnumerator OFOLEPNOONG()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPCPNKEMCNM()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void ANCOABBOFPD(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().AKLEGLCOOCO(154) && !Inventory.PLHHJCNKNFO(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(110) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.CPMMBEPEJLO(-161, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.GFHCACLMFDK(0).CJFHKNKCBHA(20) && !PlayerController.GetPlayer(8).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.EABMGELAAPG(-120, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JIHPKHPNDGE));
				((MonoBehaviour)this).StartCoroutine(CFCMKAPFPCE());
			}
		}
		else if (!DrinkDispensersManager.OLHBLKIAFOM().FHPJNNDCNOI(28) && !Inventory.IOBMIHLMGNH(0, LAGHIOKLJGH: true).CJFHKNKCBHA(-191) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.COEFFIHKMJG(55, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JPMPHHGCIAB));
			((MonoBehaviour)this).StartCoroutine(GACJBLGDMFG());
		}
	}

	private void LHFAGIJNKLJ(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().KJNJPJJMMFG(45) && !Inventory.AELPIFHLOAH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-180) && !PlayerController.GetPlayer(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.CPMMBEPEJLO(-32, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.IOLAIFGMHEA(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(34) && !PlayerController.GetPlayer(6).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.COEFFIHKMJG(-118)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KHGKHBIEADF));
				((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().HADIAMMDNKB(55) && !Inventory.AGEHIILFADF(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(84) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.EABMGELAAPG(21, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PCBEPNCIMKK));
			((MonoBehaviour)this).StartCoroutine(JOBFBHOMJNC());
		}
	}

	private void BIFDLDIDJMB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.KJNJPJJMMFG(8) && !Inventory.PLHHJCNKNFO(1, LAGHIOKLJGH: true).HasItem(-122) && !PlayerController.GetPlayer(0).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.COEFFIHKMJG(-85, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.KEHIBCAHKPJ(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-130) && !PlayerController.GetPlayer(4).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.KMBGJEKCJFJ(117, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EEKCIKFJFPA));
				((MonoBehaviour)this).StartCoroutine(BCNPEOJDCIF());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().AKLEGLCOOCO(-185) && !Inventory.OPHDCMJLLEC(0, LAGHIOKLJGH: true).JKLEPGLMCEG(-18) && !PlayerController.GetPlayer(1).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.AFOACBIHNCL(14, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LHHGNOALIKB));
			((MonoBehaviour)this).StartCoroutine(JECHOKLEDDA());
		}
	}

	private IEnumerator ELNHMAPENDB()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator OPCHFFMKPCN()
	{
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiHuman;
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T111/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator LFANGJJGBFG()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KHGKHBIEADF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JFNOOMJMHCB().ODINMCGGHKB(-195) && !Inventory.MHFEFCLBAJG(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(-99) && !PlayerController.GetPlayer(0).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.KMBGJEKCJFJ(-140, GGBBJNBBLMF: true)) && !Inventory.OCJGHINCLJM(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(103) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.GOKIDLOELKB(-2)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EEKCIKFJFPA));
				((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().DEBMDAEBEKA(-40) && !Inventory.NBEGPFFBKPO(0).HasItem(-35) && !PlayerController.GetPlayer(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.AFOACBIHNCL(-185, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
			((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
		}
	}
}
