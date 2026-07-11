using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T113_AcabarCerveza : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T113_AcabarCerveza _003C_003E4__this;

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
		public ILGBEHOLOGL(int _003C_003E1__state)
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
			T113_AcabarCerveza t113_AcabarCerveza = _003C_003E4__this;
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
				t113_AcabarCerveza.LHKIJABBBPM();
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
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T113_AcabarCerveza _003C_003E4__this;

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
		public DBHBDMOHMPM(int _003C_003E1__state)
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
			T113_AcabarCerveza t113_AcabarCerveza = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0069;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0069;
			case 3:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", t113_AcabarCerveza.triggerPlayerNum);
				goto IL_00d8;
			case 4:
				_003C_003E1__state = -1;
				goto IL_00d8;
			case 5:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.ShowPopUp();
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(t113_AcabarCerveza.DPIFOKCMOIC));
					return false;
				}
				IL_00d8:
				if (t113_AcabarCerveza.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.waitRealtime1;
				_003C_003E1__state = 5;
				return true;
				IL_0069:
				if (!t113_AcabarCerveza.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t113_AcabarCerveza).StartCoroutine(t113_AcabarCerveza.CDICFNAMCEE());
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

	private void NFGPGANGBNL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().DEBMDAEBEKA(-121) && !Inventory.BNMEANGDMIP(1).HasItem(-23) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.GetItem(-118, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.IOBMIHLMGNH(3, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(4) && !PlayerController.GetPlayer(4).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.KMBGJEKCJFJ(-94)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FFAGCBMPJON));
				((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().AHMOBAJJDDH(34) && !Inventory.IMJOOACMADK(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(174) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.COEFFIHKMJG(-154)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(CICDFJKNMON));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator OGOFIFJCMEB()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator JPFGGJMNOKH()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JBBPOCHHHND()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator DECKMELAPMA()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void LLOCIDPONNB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().LFIALOLFOOD(124) && !Inventory.JFIPFFDLDKB(0, LAGHIOKLJGH: true).CJFHKNKCBHA(133) && !PlayerController.GetPlayer(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.CPMMBEPEJLO(-24, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.NHHOGHLEODI(4).JKLEPGLMCEG(29) && !PlayerController.OPHDCMJLLEC(6).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.EABMGELAAPG(-155, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FFAGCBMPJON));
				((MonoBehaviour)this).StartCoroutine(GHMAHJJPJCD());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().HasDrink(69) && !Inventory.IOLAIFGMHEA(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-132) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.COEFFIHKMJG(163, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FFAGCBMPJON));
			((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
		}
	}

	private IEnumerator NCNGHNLFCBO()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GHMAHJJPJCD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CFGLAPAKKAL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NFKOJBMCIBI()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator OBCHIKLEMKF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGEOMOOKOEP()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator BPMIGCIFGML()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
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
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator AELFLHCNMBB()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LFANGJJGBFG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	public override int GetID()
	{
		return 113;
	}

	private IEnumerator IGFOJFFHNJF()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator AOGGKPMBLBK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GEFGNPHFAHG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NDFMAMKPANE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PBONGBBBFIO(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().LFIALOLFOOD(104) && !Inventory.IAAFEENHLKB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-111) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.GetItem(106, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.AELPIFHLOAH(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(44) && !PlayerController.OPHDCMJLLEC(4).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.CPMMBEPEJLO(81, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(IKCMEHNHLOE));
				((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().DEBMDAEBEKA(139) && !Inventory.GIAOPMIDGPL(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-193) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.AFOACBIHNCL(88, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KFNABNFOBAB));
			((MonoBehaviour)this).StartCoroutine(JCKBLHHGOHC());
		}
	}

	private IEnumerator AGFLJLODJJK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIFEIKLKIMF()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void CICDFJKNMON(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().LFIALOLFOOD(70) && !Inventory.ILAOFABODGO(0, LAGHIOKLJGH: true).HasItem(47) && !PlayerController.GetPlayer(0).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.CPMMBEPEJLO(117, GGBBJNBBLMF: true)) && !Inventory.IAAFEENHLKB(4, LAGHIOKLJGH: true).HasItem(171) && !PlayerController.OPHDCMJLLEC(2).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.AFOACBIHNCL(131, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DNJMHDBOGOC));
				((MonoBehaviour)this).StartCoroutine(GEFGNPHFAHG());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.AHMOBAJJDDH(126) && !Inventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-71) && !PlayerController.GetPlayer(0).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.GOKIDLOELKB(69, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HCHBPBIAKEA));
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
		}
	}

	private IEnumerator EAIFKHKDDEI()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator KGIJEMPBBED()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HPBMLBGIIOM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().HADIAMMDNKB(29) && !Inventory.GFHCACLMFDK(0).JKLEPGLMCEG(-155) && !PlayerController.GetPlayer(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.AFOACBIHNCL(110)) && !Inventory.MPDMDABCCCA(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-91) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.AFOACBIHNCL(-121)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOCIDPONNB));
				((MonoBehaviour)this).StartCoroutine(JPFGGJMNOKH());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().HasDrink(180) && !Inventory.MJJHNNJKEMO(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(28) && !PlayerController.GetPlayer(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.EABMGELAAPG(49)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EDBMEAGMKME));
			((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
		}
	}

	private void IKCMEHNHLOE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().BLOAFCBKKNA(-144) && !Inventory.KCOBKJNCKNP(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(175) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.CPMMBEPEJLO(80, GGBBJNBBLMF: true)) && !Inventory.JPDEFKLINCL(1, LAGHIOKLJGH: true).CJFHKNKCBHA(64) && !PlayerController.OPHDCMJLLEC(7).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.EABMGELAAPG(-53, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BIEONCCCFKM));
				((MonoBehaviour)this).StartCoroutine(FEEJKJJEEPO());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.LFIALOLFOOD(105) && !Inventory.OCJGHINCLJM(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(8) && !PlayerController.GetPlayer(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.CPMMBEPEJLO(-129, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EABGNABJLHM));
			((MonoBehaviour)this).StartCoroutine(FEEJKJJEEPO());
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator EKMOJHNJOCG()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator DNAAOCABLNF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ADFMBGJOMKK()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void AGIFOLMHLAH(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JFNOOMJMHCB().ODINMCGGHKB(-192) && !Inventory.HHONLOCNFNC(0).JKLEPGLMCEG(129) && !PlayerController.GetPlayer(0).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.CPMMBEPEJLO(51)) && !Inventory.IOLAIFGMHEA(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(90) && !PlayerController.GetPlayer(5).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.GetItem(97, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EDBMEAGMKME));
				((MonoBehaviour)this).StartCoroutine(KGIJEMPBBED());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().LFIALOLFOOD(67) && !Inventory.HHONLOCNFNC(0, LAGHIOKLJGH: true).CJFHKNKCBHA(128) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.GOKIDLOELKB(170)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PBONGBBBFIO));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator JCKBLHHGOHC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HNFCACDCBBO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AOJFNNKFCBL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void EABGNABJLHM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().AKLEGLCOOCO(186) && !Inventory.MJJHNNJKEMO(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(112) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.AFOACBIHNCL(-40, GGBBJNBBLMF: true)) && !Inventory.KCOBKJNCKNP(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(93) && !PlayerController.GetPlayer(6).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.EABMGELAAPG(92, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DNJMHDBOGOC));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().LFIALOLFOOD(-162) && !Inventory.NBEGPFFBKPO(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(192) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.EABMGELAAPG(-109, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HJENDBMEPNF));
			((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
		}
	}

	private void KFNABNFOBAB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().ODINMCGGHKB(-7) && !Inventory.MPDMDABCCCA(1).JKLEPGLMCEG(-110) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.EABMGELAAPG(-183, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.JPDEFKLINCL(0, LAGHIOKLJGH: true).JKLEPGLMCEG(195) && !PlayerController.GetPlayer(5).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.GetItem(-179, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PFDGBLEGLKO));
				((MonoBehaviour)this).StartCoroutine(JKLDKCKPFBJ());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().AKLEGLCOOCO(140) && !Inventory.JPDEFKLINCL(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-122) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.KMBGJEKCJFJ(-44, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DBMJAJEPNJB));
			((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
		}
	}

	private void DNJMHDBOGOC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().FHPJNNDCNOI(-139) && !Inventory.GIAOPMIDGPL(0, LAGHIOKLJGH: true).HasItem(198) && !PlayerController.GetPlayer(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.CPMMBEPEJLO(70, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.JDADPDBHJFO(0).HasItem(-179) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.COEFFIHKMJG(-140, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(OHLJFPCBCMH));
				((MonoBehaviour)this).StartCoroutine(AELFLHCNMBB());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().BLOAFCBKKNA(198) && !Inventory.JDADPDBHJFO(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-145) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.INJBNHPGCIJ(-134)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BIEONCCCFKM));
			((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
		}
	}

	private IEnumerator EHDIMBMCIDK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBOCOLCBOIL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JKLDKCKPFBJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BDBMGIKGDNG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KHGKHBIEADF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().DEBMDAEBEKA(164) && !Inventory.NBEGPFFBKPO(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(130) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.INJBNHPGCIJ(77, GGBBJNBBLMF: true)) && !Inventory.NPANPNIDKDG(1, LAGHIOKLJGH: true).JKLEPGLMCEG(138) && !PlayerController.GetPlayer(0).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.COEFFIHKMJG(-55, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(NEDDFKEKEKB));
				((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().LFIALOLFOOD(-106) && !Inventory.AFMOAONHHNL(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(146) && !PlayerController.GetPlayer(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.KMBGJEKCJFJ(28, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOCIDPONNB));
			((MonoBehaviour)this).StartCoroutine(JCKBLHHGOHC());
		}
	}

	private IEnumerator LGDNIGIMDKP()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void FFAGCBMPJON(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().BLOAFCBKKNA(-73) && !Inventory.JPDEFKLINCL(0).JKLEPGLMCEG(-170) && !PlayerController.GetPlayer(0).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.COEFFIHKMJG(-114)) && !Inventory.IECFJGHAIDO(1, LAGHIOKLJGH: true).JKLEPGLMCEG(-196) && !PlayerController.OPHDCMJLLEC(3).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.GOKIDLOELKB(24, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KFNABNFOBAB));
				((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().AKLEGLCOOCO(-45) && !Inventory.IMJOOACMADK(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-189) && !PlayerController.GetPlayer(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.GOKIDLOELKB(-117, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOFDFALKNL));
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
		}
	}

	private IEnumerator JAKPMNEGELN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HFFIGEDMMJF()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator PPEKNALPDJI()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator HGFPMNKEMAC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator KCJAAGLPFEE()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BJKKIJIKPMC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFMMNGELPGN()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BCALBKDNAJH()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IDGLEKCBIMF()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BCPNMIIJIEJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator KMOGEGDEDPC()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FJBKBPOLINL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HJENDBMEPNF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().ODINMCGGHKB(33) && !Inventory.KCOBKJNCKNP(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(0) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.GOKIDLOELKB(-154, GGBBJNBBLMF: true)) && !Inventory.OCJGHINCLJM(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-112) && !PlayerController.GetPlayer(6).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.AFOACBIHNCL(-144, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(NFGPGANGBNL));
				((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
			}
		}
		else if (!DrinkDispensersManager.JFNOOMJMHCB().HasDrink(-51) && !Inventory.EIFPKCAFDIB(0).HasItem(178) && !PlayerController.GetPlayer(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.KMBGJEKCJFJ(-134, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(NFGPGANGBNL));
			((MonoBehaviour)this).StartCoroutine(BCPNMIIJIEJ());
		}
	}

	private IEnumerator JOBFBHOMJNC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OHLJFPCBCMH(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().FHPJNNDCNOI(-137) && !Inventory.DACNEICGAAE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-86) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.EABMGELAAPG(96, GGBBJNBBLMF: true)) && !Inventory.IOBMIHLMGNH(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-125) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.KMBGJEKCJFJ(-183, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HPBMLBGIIOM));
				((MonoBehaviour)this).StartCoroutine(BCPNMIIJIEJ());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().FHPJNNDCNOI(175) && !Inventory.NPANPNIDKDG(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-147) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.GetItem(-60, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(NEDDFKEKEKB));
			((MonoBehaviour)this).StartCoroutine(BCPNMIIJIEJ());
		}
	}

	private void DBMJAJEPNJB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().AKLEGLCOOCO(-68) && !Inventory.AGEHIILFADF(1).HasItem(67) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.CPMMBEPEJLO(199, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-5) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.INJBNHPGCIJ(162, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HCHBPBIAKEA));
				((MonoBehaviour)this).StartCoroutine(FEEJKJJEEPO());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().DEBMDAEBEKA(52) && !Inventory.BDPPNLODPGN(1).HasItem(83) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.GetItem(-140, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EDBMEAGMKME));
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
		}
	}

	private IEnumerator DBCADKNONKE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DNLEAJAPNOM()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EDBMEAGMKME(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().BLOAFCBKKNA(-25) && !Inventory.BDPPNLODPGN(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-189) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.INJBNHPGCIJ(8, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.KEHIBCAHKPJ(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-197) && !PlayerController.GetPlayer(3).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.CPMMBEPEJLO(67, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HJENDBMEPNF));
				((MonoBehaviour)this).StartCoroutine(HNFCACDCBBO());
			}
		}
		else if (!DrinkDispensersManager.OLHBLKIAFOM().LFIALOLFOOD(175) && !Inventory.IMJOOACMADK(0).CJFHKNKCBHA(147) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.EABMGELAAPG(31, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(CICDFJKNMON));
			((MonoBehaviour)this).StartCoroutine(JPFGGJMNOKH());
		}
	}

	private IEnumerator DABNLFBDKGN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CLCOEDFCDPK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JGGBPKEJMIJ()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NEDDFKEKEKB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().ODINMCGGHKB(-123) && !Inventory.NHHOGHLEODI(1).HasItem(-103) && !PlayerController.GetPlayer(0).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.CPMMBEPEJLO(184, GGBBJNBBLMF: true)) && !Inventory.GIAOPMIDGPL(7, LAGHIOKLJGH: true).HasItem(82) && !PlayerController.OPHDCMJLLEC(7).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.INJBNHPGCIJ(-35, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EABGNABJLHM));
				((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().AHMOBAJJDDH(147) && !Inventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(194) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.GOKIDLOELKB(130, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PFDGBLEGLKO));
			((MonoBehaviour)this).StartCoroutine(CFGLAPAKKAL());
		}
	}

	private void CMIJCAHCMEA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().DEBMDAEBEKA(183) && !Inventory.IECFJGHAIDO(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(118) && !PlayerController.GetPlayer(1).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.INJBNHPGCIJ(-75, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.JFIPFFDLDKB(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(193) && !PlayerController.GetPlayer(6).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.GetItem(-11, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(OHLJFPCBCMH));
				((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().HADIAMMDNKB(-155) && !Inventory.MPDMDABCCCA(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-99) && !PlayerController.GetPlayer(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.AFOACBIHNCL(152, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LLOFDFALKNL));
			((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
		}
	}

	private IEnumerator LFKPHADFFDG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOFDOHFANIE()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator KMIBOOOFJKB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NCHPMDFONEL()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator BLNKHNHGFPB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void BIEONCCCFKM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().AKLEGLCOOCO(68) && !Inventory.OPHDCMJLLEC(0, LAGHIOKLJGH: true).JKLEPGLMCEG(106) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.GetItem(-28, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.OPHDCMJLLEC(0, LAGHIOKLJGH: true).HasItem(-12) && !PlayerController.GetPlayer(7).trayHandler.tray.NPMGIIIBGNP(ItemDatabaseAccessor.KMBGJEKCJFJ(110)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(CMIJCAHCMEA));
				((MonoBehaviour)this).StartCoroutine(GHMAHJJPJCD());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().LFIALOLFOOD(150) && !Inventory.DACNEICGAAE(1).HasItem(-134) && !PlayerController.GetPlayer(0).trayHandler.tray.EDNOMELCHEP(ItemDatabaseAccessor.GetItem(-187, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PBONGBBBFIO));
			((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
		}
	}

	private void OOANAMPPINM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().DEBMDAEBEKA(198) && !Inventory.GIAOPMIDGPL(0).HasItem(-68) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.GetItem(-145, GGBBJNBBLMF: true, DAINLFIMLIH: false)) && !Inventory.JPDEFKLINCL(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(60) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.EABMGELAAPG(-95)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HJENDBMEPNF));
				((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().AHMOBAJJDDH(-52) && !Inventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-85) && !PlayerController.GetPlayer(0).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.COEFFIHKMJG(-54, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(NEDDFKEKEKB));
			((MonoBehaviour)this).StartCoroutine(CLCOEDFCDPK());
		}
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

	private void LLOFDFALKNL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().HADIAMMDNKB(-128) && !Inventory.GIAOPMIDGPL(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(161) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.EABMGELAAPG(33, GGBBJNBBLMF: true)) && !Inventory.PLHHJCNKNFO(8).JKLEPGLMCEG(-80) && !PlayerController.OPHDCMJLLEC(3).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.CPMMBEPEJLO(36, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DNJMHDBOGOC));
				((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.AKLEGLCOOCO(166) && !Inventory.KEHIBCAHKPJ(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-122) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.GetItem(44)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HCHBPBIAKEA));
			((MonoBehaviour)this).StartCoroutine(CFGLAPAKKAL());
		}
	}

	private IEnumerator AJJPECIKMJN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MHOCCJMNGLC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().FHPJNNDCNOI(18) && !Inventory.BDENIHLMMHB(1).JKLEPGLMCEG(140) && !PlayerController.GetPlayer(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.KMBGJEKCJFJ(-165, GGBBJNBBLMF: true)) && !Inventory.GFHCACLMFDK(3, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(108) && !PlayerController.GetPlayer(3).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.CPMMBEPEJLO(72, GGBBJNBBLMF: true)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HPBMLBGIIOM));
				((MonoBehaviour)this).StartCoroutine(GEFGNPHFAHG());
			}
		}
		else if (!DrinkDispensersManager.BNDNMBGJEKP().HasDrink(-150) && !Inventory.BDENIHLMMHB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-33) && !PlayerController.GetPlayer(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.KMBGJEKCJFJ(-153, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PBONGBBBFIO));
			((MonoBehaviour)this).StartCoroutine(HNFCACDCBBO());
		}
	}

	private IEnumerator LHIPOAGIOJK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CAKPGBAIIPI()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void HCHBPBIAKEA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().ODINMCGGHKB(125) && !Inventory.ILAOFABODGO(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-95) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.INJBNHPGCIJ(-15, GGBBJNBBLMF: false, DAINLFIMLIH: false)) && !Inventory.OCJGHINCLJM(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(69) && !PlayerController.GetPlayer(7).trayHandler.tray.LDKPEFIKJCF(ItemDatabaseAccessor.GetItem(-46)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HPBMLBGIIOM));
				((MonoBehaviour)this).StartCoroutine(HNNEPLACIAC());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().KJNJPJJMMFG(56) && !Inventory.BNMEANGDMIP(0).HasItem(-62) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.AFOACBIHNCL(-151, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(NFGPGANGBNL));
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
		}
	}

	private void HOADPBHHCFO(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().AKLEGLCOOCO(78) && !Inventory.BDPPNLODPGN(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(-99) && !PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.GOKIDLOELKB(101, GGBBJNBBLMF: true)) && !Inventory.KCOBKJNCKNP(1).JKLEPGLMCEG(-199) && !PlayerController.GetPlayer(4).trayHandler.tray.OJMICKHDJGO(ItemDatabaseAccessor.EABMGELAAPG(177)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HPBMLBGIIOM));
				((MonoBehaviour)this).StartCoroutine(CLCOEDFCDPK());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.AHMOBAJJDDH(-38) && !Inventory.BDPPNLODPGN(1).HasItem(101) && !PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.GOKIDLOELKB(-112)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(NFGPGANGBNL));
			((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
		}
	}

	private IEnumerator ELPDKDFFJJD()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private void OALNPABCPMD(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().HADIAMMDNKB(173) && !Inventory.OPHDCMJLLEC(1).CJFHKNKCBHA(-89) && !PlayerController.GetPlayer(1).trayHandler.tray.OFNAOLAMFJA(ItemDatabaseAccessor.EABMGELAAPG(163)) && !Inventory.KEHIBCAHKPJ(6, LAGHIOKLJGH: true).JKLEPGLMCEG(-70) && !PlayerController.OPHDCMJLLEC(7).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.COEFFIHKMJG(-168, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PFDGBLEGLKO));
				((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
			}
		}
		else if (!DrinkDispensersManager.GGFJGHHHEJC.LFIALOLFOOD(178) && !Inventory.BDENIHLMMHB(0).HasItem(113) && !PlayerController.GetPlayer(1).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.INJBNHPGCIJ(197, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(OOANAMPPINM));
			((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
		}
	}

	private IEnumerator FAEKOKEINEH()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBENGPAEGCL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void NNGGNEKLGLE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.LFIALOLFOOD(182) && !Inventory.NHHOGHLEODI(0, LAGHIOKLJGH: true).HasItem(124) && !PlayerController.GetPlayer(0).trayHandler.tray.IHCMCKDNODF(ItemDatabaseAccessor.KMBGJEKCJFJ(-138, GGBBJNBBLMF: true)) && !Inventory.KEHIBCAHKPJ(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-90) && !PlayerController.OPHDCMJLLEC(3).trayHandler.tray.LDMNMBJFOMA(ItemDatabaseAccessor.COEFFIHKMJG(191, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
				((MonoBehaviour)this).StartCoroutine(FJBKBPOLINL());
			}
		}
		else if (!DrinkDispensersManager.OPILDPFDFKJ().KJNJPJJMMFG(47) && !Inventory.GFHCACLMFDK(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(15) && !PlayerController.GetPlayer(1).trayHandler.tray.MJOLPEJHKAK(ItemDatabaseAccessor.GOKIDLOELKB(168, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(OHLJFPCBCMH));
			((MonoBehaviour)this).StartCoroutine(FJBKBPOLINL());
		}
	}

	private void PFDGBLEGLKO(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (GameManager.LocalCoop())
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().ODINMCGGHKB(-117) && !Inventory.NLEFGNHMJNN(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(23) && !PlayerController.GetPlayer(0).trayHandler.tray.EJNLGKAEDKM(ItemDatabaseAccessor.CPMMBEPEJLO(6)) && !Inventory.KCOBKJNCKNP(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-11) && !PlayerController.GetPlayer(6).trayHandler.tray.DEFDACJAHHG(ItemDatabaseAccessor.GOKIDLOELKB(77, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KHGKHBIEADF));
				((MonoBehaviour)this).StartCoroutine(GHMAHJJPJCD());
			}
		}
		else if (!DrinkDispensersManager.JHMAMLIPBNN().KJNJPJJMMFG(-11) && !Inventory.IECFJGHAIDO(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-84) && !PlayerController.GetPlayer(0).trayHandler.tray.LOKKMKODJNJ(ItemDatabaseAccessor.COEFFIHKMJG(80, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HPBMLBGIIOM));
			((MonoBehaviour)this).StartCoroutine(JKLDKCKPFBJ());
		}
	}

	private IEnumerator CCOGIOADJKC()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator OOGKJFJEHFO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator BBGHMMLBAME()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator HCCJFBLCABN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PGGLCNBNAFB()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DPIFOKCMOIC));
	}

	private IEnumerator HNNEPLACIAC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator FEEJKJJEEPO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LILMJIIMODP()
	{
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T113/Dialogue1", triggerPlayerNum);
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
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FPIHNICAJHI()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}
}
