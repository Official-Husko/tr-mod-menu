using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DrinkDispenserUI : UIWindow
{
	[CompilerGenerated]
	private sealed class AOIOJLBLECE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrinkDispenserUI _003C_003E4__this;

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
		public AOIOJLBLECE(int _003C_003E1__state)
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
			DrinkDispenserUI drinkDispenserUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(drinkDispenserUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(drinkDispenserUI.JIIGOACEIKL).Select(((Component)drinkDispenserUI.slotUI).gameObject);
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

	public ColorButton colorButton;

	public GameObject colorButtonPanel;

	private DrinkDispenser MJMNGLHDJFH;

	public static DrinkDispenserUI[] instances = new DrinkDispenserUI[3];

	public void OLIMGEJENCJ(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(NLJMBNIHLAK));
		EOOMHBCLCAK();
		slotUI.MHNCEBLHLKH(MJMNGLHDJFH.slots[1]);
		MainUI.PCMOFKMCNCM(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private void PFMNJJNBKND()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB()
				select (x)).Where(GAHEJHOFLBN)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void JAKILILIBIM()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(HHLFENKEIJI));
	}

	public void OnColorChanged(SpriteColor FJAHJEMPPKH)
	{
		if ((Object)(object)MJMNGLHDJFH != (Object)null)
		{
			MJMNGLHDJFH.ChangeDrinkColor(FJAHJEMPPKH);
		}
	}

	public static DrinkDispenserUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void AIKOLENNNDH(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(GGBKFMGBEFG));
		HJNEMPOFPPI();
		slotUI.LIJPNDJCKGL(MJMNGLHDJFH.slots[1]);
		MainUI.GBEIHIDIDAD(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private IEnumerator CEENFCLMELA()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotUI).gameObject);
		}
	}

	private void EPFDKCELPDD()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(JCDKILCPMDD));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(AHDGAAIMPNO));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(BDFAGNMHKJB));
	}

	private void MPHKFCHFGIK()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(!MJMNGLHDJFH.slots[0].AHHEMNHJPME());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.DPFFIBNLPKG();
		}
	}

	private void JCDKILCPMDD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Eyes"), 1815f);
			}
		}
		else
		{
			POCDDALIIMN();
		}
	}

	private bool MFLLJKKJJJJ(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
	}

	public void HMDEEHIKCLD(SpriteColor FJAHJEMPPKH)
	{
		if ((Object)(object)MJMNGLHDJFH != (Object)null)
		{
			MJMNGLHDJFH.MDNIFBAALBK(FJAHJEMPPKH);
		}
	}

	public void FKHBBAHLKOH(SpriteColor FJAHJEMPPKH)
	{
		if ((Object)(object)MJMNGLHDJFH != (Object)null)
		{
			MJMNGLHDJFH.HBNGHAFIOCE(FJAHJEMPPKH);
		}
	}

	private void CPAEOAAMEFP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("ReceiveGiveUpgradeToolRPC"), 608f);
			}
		}
		else
		{
			HGPHBCCKICN();
		}
	}

	private bool IMJEJLLAOLM(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
	}

	private void CMCMIHNIKPG()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(!MJMNGLHDJFH.slots[1].LCHJGCHDHFO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.FJAHJEMPPKH;
		}
	}

	public void HMKJPNMGAAK(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(GPIOFFEMEPC));
		PONGMMHCJLG();
		slotUI.LIJPNDJCKGL(MJMNGLHDJFH.slots[0]);
		MainUI.SetCurrentContainer(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private void HHLFENKEIJI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("TooDark"), 1449f);
			}
		}
		else
		{
			KOHJLFGNKFJ();
		}
	}

	private IEnumerator OIPHACFIMNN()
	{
		return new AOIOJLBLECE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PONGMMHCJLG()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(MJMNGLHDJFH.slots[0].KPINNBKMOMO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.KDHDHJPNDCM();
		}
	}

	[CompilerGenerated]
	private bool KKEEFINCEOE(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
	}

	private void CHDGJHNBNEJ()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(HHLFENKEIJI));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(BALNEMHMIAF));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(BDFAGNMHKJB));
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			NIILOKCNLEN();
			base.OpenUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Sound.GGFJGHHHEJC.openWood[0], HOMFPAFAOGD: true);
			DJJFMDHGOKN(CGBEIKHPCHL);
		}
	}

	private bool JAPKJJOBKJD(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return true;
	}

	private void CGBEIKHPCHL()
	{
		if (ColorPickerUI.Get(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.Get(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator ECHJLDEKIGF()
	{
		return new AOIOJLBLECE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OPOIPENJGJP()
	{
		GFEFGECOCHK();
	}

	private void FCKOEBAEOPF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("BirdInAChest_Error"), 3f);
			}
		}
		else
		{
			PFMNJJNBKND();
		}
	}

	private IEnumerator NANMJKBFACA()
	{
		return new AOIOJLBLECE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KGIAJJMELDA()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).FCGJCBJGOIG()
			select (x) into NCPGNLOJGAF
			where NCPGNLOJGAF.itemInstance != null && Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH)
			select NCPGNLOJGAF into x
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).CNOCEADFCLD(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void BDFAGNMHKJB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("BanquetEvent instance is null. Make sure it is initialized before calling StartBanquetEvent."), 1608f);
			}
		}
		else
		{
			FDMHLDCNFHI();
		}
	}

	private void DJDLCPCCBHA()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(ABLCHNDINIA));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(AHDGAAIMPNO));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(CPAEOAAMEFP));
	}

	public static DrinkDispenserUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static DrinkDispenserUI OFEFGPCGJDF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void HGPHBCCKICN()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBDOBNLMLGM()
				select (x)).Where(GAHEJHOFLBN)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.Get(base.JIIGOACEIKL).NACCNOFNEHM(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void OCIHCODJBGC()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BDFAGNMHKJB));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(GIFIPGMCNGL));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(BDFAGNMHKJB));
	}

	private void PFOJFILNJIN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	private void GBKELGECFDC()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBDOBNLMLGM()
				select (x)).Where(PPGABIEJEMB)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).JCOHBJLKLAI(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private void OHBLEOIKLNB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Theme: "), 1621f);
			}
		}
		else
		{
			HGPHBCCKICN();
		}
	}

	private void FPJABCNDEEJ()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(CPAEOAAMEFP));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(OHBLEOIKLNB));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(HIJBJFOJDJF));
	}

	private void POCDDALIIMN()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).GetAllSlots()
				select (x)).Where(PPGABIEJEMB)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).CJODJMLPGOL(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotUI).gameObject);
		}
	}

	public void NKHHIPJJHBA(SpriteColor FJAHJEMPPKH)
	{
		if ((Object)(object)MJMNGLHDJFH != (Object)null)
		{
			MJMNGLHDJFH.JANKIIPLLFL(FJAHJEMPPKH);
		}
	}

	private void CMHMHNLALKP()
	{
		GFEFGECOCHK();
	}

	private void AIIINKJPPEF()
	{
		if (ColorPickerUI.MENPEHNHFOA(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.EOPIEMLAPFN(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).PNHCLGGKBOB();
		}
	}

	private void GIFIPGMCNGL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("HostDisconnected"), 690f);
			}
		}
		else
		{
			HGPHBCCKICN();
		}
	}

	public static DrinkDispenserUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BHIFFCNINLE()
	{
		BGBBAJJHHCJ();
	}

	private void FDMHLDCNFHI()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots()
				select (x)).Where(GAHEJHOFLBN)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).PJEIHOCPBLA(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void GGBKFMGBEFG()
	{
		GGABMCBAJDI();
	}

	private void HLPHOADDCMH()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(MJMNGLHDJFH.slots[1].AHHEMNHJPME());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.KGCEBMCNDAH();
		}
	}

	private void BHEMKMHKNKD()
	{
		if (ColorPickerUI.EGBMJGOCIJJ(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.MDFIDKHOPDJ(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).NJPFHBINPKE();
		}
	}

	private void JDNKFCBBOIO()
	{
		HLPHOADDCMH();
	}

	private void GGABMCBAJDI()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(!MJMNGLHDJFH.slots[0].LCHJGCHDHFO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.BNGAJBNFFIL();
		}
	}

	private void CENMAJGFMFF()
	{
		if (ColorPickerUI.LAMFGLIGLOP(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.MDFIDKHOPDJ(base.JIIGOACEIKL).BOBCIFEDJED();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).PNHCLGGKBOB();
		}
	}

	private void NIILOKCNLEN()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetAllSlots()
			select (x) into NCPGNLOJGAF
			where NCPGNLOJGAF.itemInstance != null && Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH)
			select NCPGNLOJGAF into x
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void LDBBNBEBKLA()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(HHLFENKEIJI));
	}

	private void BGBBAJJHHCJ()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(MJMNGLHDJFH.slots[0].KPINNBKMOMO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.IGOIGFCJGAH();
		}
	}

	public static DrinkDispenserUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FCCLMDKIJND()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(MJMNGLHDJFH.slots[0].AHHEMNHJPME());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.DPFFIBNLPKG();
		}
	}

	private IEnumerator FMAANCEEEMI()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotUI).gameObject);
		}
	}

	private void GJEEHONNGJM()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).BBDOBNLMLGM()
				select (x)).Where(HGCOBCACCLG)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.AEJKCONFPHB(base.JIIGOACEIKL).CNOCEADFCLD(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	public void HJBJEMNDLAL(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(CMHMHNLALKP));
		HLPHOADDCMH();
		slotUI.LIJPNDJCKGL(MJMNGLHDJFH.slots[1]);
		MainUI.LIIGLHOFDBK(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void DLILDIINOIP()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(MJMNGLHDJFH.slots[0].AHHEMNHJPME());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.DPFFIBNLPKG();
		}
	}

	public void GIMEBIPKLMM(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(NLJMBNIHLAK));
		DLILDIINOIP();
		slotUI.LIJPNDJCKGL(MJMNGLHDJFH.slots[1]);
		MainUI.LIIGLHOFDBK(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	public void ONJEJFNMPNL(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(JDNKFCBBOIO));
		BGBBAJJHHCJ();
		slotUI.MHNCEBLHLKH(MJMNGLHDJFH.slots[0]);
		MainUI.SetCurrentContainer(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private void FGEDMGFICAN()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FCGJCBJGOIG()
				select (x)).Where(IMJEJLLAOLM)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.AEJKCONFPHB(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void DPCOJJHIHIP()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(!MJMNGLHDJFH.slots[0].KPINNBKMOMO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.KDHDHJPNDCM();
		}
	}

	private void OnEnable()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(MJMNGLHDJFH.placeable.onlinePlaceable);
			}
			DrinkDispenser mJMNGLHDJFH = MJMNGLHDJFH;
			mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Remove(mJMNGLHDJFH.OnContainerChanged, new Action(NLJMBNIHLAK));
			MJMNGLHDJFH = null;
			MainUI.SetCurrentContainer(base.JIIGOACEIKL, null, 0);
			GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(new List<Slot>(Inventory.GetPlayer(base.JIIGOACEIKL).slots), OGCAKIGELBJ: true, MMMCDGNCKJH: false);
			GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			base.CloseUI();
			if (ColorPickerUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				ColorPickerUI.Get(base.JIIGOACEIKL).CloseUI();
			}
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public static DrinkDispenserUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ABLCHNDINIA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1114"), 324f);
			}
		}
		else
		{
			KGIAJJMELDA();
		}
	}

	public void HPJNGAKMBGF(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(NLJMBNIHLAK));
		CMCMIHNIKPG();
		slotUI.LIJPNDJCKGL(MJMNGLHDJFH.slots[0]);
		MainUI.LIIGLHOFDBK(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private void DCIDPHNBOEC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("UI"), 1898f);
			}
		}
		else
		{
			GJEEHONNGJM();
		}
	}

	private void DBKFGPPHFCN()
	{
		if (ColorPickerUI.JDODHPEDACJ(base.JIIGOACEIKL).BGLJFMHCFJF())
		{
			ColorPickerUI.BMFHCBOFHCN(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).PNHCLGGKBOB();
		}
	}

	private IEnumerator MNHJHPPIKLJ()
	{
		return new AOIOJLBLECE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ICDLLAGIOHK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("DecorationTile_15"), 1063f);
			}
		}
		else
		{
			BPMAFFOKDJP();
		}
	}

	private void HIJBJFOJDJF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 0, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Right"), 1960f);
			}
		}
		else
		{
			GBKELGECFDC();
		}
	}

	private void ICGPFJECOPE()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(!MJMNGLHDJFH.slots[1].KPINNBKMOMO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.FJAHJEMPPKH;
		}
	}

	private void IJJFCOBACFM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("<br/>Graphics Shader Level: "), 1359f);
			}
		}
		else
		{
			FGEDMGFICAN();
		}
	}

	private void OGGJNBCJGCE()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(HHLFENKEIJI));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(AHDGAAIMPNO));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(BDFAGNMHKJB));
	}

	protected override void Start()
	{
		base.Start();
		slotUI.autoTransferEnabled = true;
		ColorButton obj = colorButton;
		obj.OnColorChanged = (Action<SpriteColor>)Delegate.Combine(obj.OnColorChanged, new Action<SpriteColor>(OnColorChanged));
	}

	private void PNKMKIJMNBK()
	{
		if (ColorPickerUI.EOPIEMLAPFN(base.JIIGOACEIKL).HDEPMJIDJEM())
		{
			ColorPickerUI.EOPIEMLAPFN(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).PNHCLGGKBOB();
		}
	}

	private void BALNEMHMIAF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Quest without ID: "), 925f);
			}
		}
		else
		{
			HGPHBCCKICN();
		}
	}

	private void LGGGGAJGLMD()
	{
		if (ColorPickerUI.LAIEKOOCNPC(base.JIIGOACEIKL).HDEPMJIDJEM())
		{
			ColorPickerUI.LAIEKOOCNPC(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).NJPFHBINPKE();
		}
	}

	private void GPIOFFEMEPC()
	{
		FCCLMDKIJND();
	}

	private void FJPOJFKABPA()
	{
		GFEFGECOCHK();
	}

	public static DrinkDispenserUI JGNOJMLHPOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JKPNDKJDMJG()
	{
		if (ColorPickerUI.DOGBDIOJAHO(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.JDODHPEDACJ(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).PNHCLGGKBOB();
		}
	}

	private void OnDisable()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
	}

	public void SetDrinkDispenser(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(NLJMBNIHLAK));
		EOOMHBCLCAK();
		slotUI.IHENCGDNPBL = MJMNGLHDJFH.slots[0];
		MainUI.SetCurrentContainer(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private void HJNEMPOFPPI()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(!MJMNGLHDJFH.slots[1].KPINNBKMOMO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.KDHDHJPNDCM();
		}
	}

	private void HGEKPHOPJCD()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(OHBLEOIKLNB));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
	}

	private void KOHJLFGNKFJ()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots()
			select (x) into NCPGNLOJGAF
			where NCPGNLOJGAF.itemInstance != null && Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH)
			select NCPGNLOJGAF into x
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).DHFABEONKBG(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	public void NHDEFDBOFJO(SpriteColor FJAHJEMPPKH)
	{
		if ((Object)(object)MJMNGLHDJFH != (Object)null)
		{
			MJMNGLHDJFH.AAIFCGDJCOA(FJAHJEMPPKH);
		}
	}

	public void KBDBLEDPCNN(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(OPOIPENJGJP));
		CMCMIHNIKPG();
		slotUI.IHENCGDNPBL = MJMNGLHDJFH.slots[0];
		MainUI.GBEIHIDIDAD(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private void NPEOMLFKADO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("ReciveResetDialogueUPetShop"), 1469f);
			}
		}
		else
		{
			FDMHLDCNFHI();
		}
	}

	private void NJJHDDFJFFC()
	{
		if (ColorPickerUI.OCCEHEMCGJF(base.JIIGOACEIKL).BGLJFMHCFJF())
		{
			ColorPickerUI.MDFIDKHOPDJ(base.JIIGOACEIKL).BOBCIFEDJED();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).NJPFHBINPKE();
		}
	}

	private void EOOMHBCLCAK()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(!MJMNGLHDJFH.slots[0].KPINNBKMOMO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.FJAHJEMPPKH;
		}
	}

	private void AHDGAAIMPNO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("00"), 125f);
			}
		}
		else
		{
			GBKELGECFDC();
		}
	}

	private void NMPFHHEFOPH()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(CPAEOAAMEFP));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(IJJFCOBACFM));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(HIJBJFOJDJF));
	}

	private IEnumerator LJCMKAPLHDO()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotUI).gameObject);
		}
	}

	public void DNOHEHINMLP(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(OPOIPENJGJP));
		HLPHOADDCMH();
		slotUI.LIJPNDJCKGL(MJMNGLHDJFH.slots[0]);
		MainUI.PCMOFKMCNCM(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private bool IOCIOBANMIE(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return true;
	}

	private void GFEFGECOCHK()
	{
		if (Object.op_Implicit((Object)(object)MJMNGLHDJFH))
		{
			colorButtonPanel.SetActive(MJMNGLHDJFH.slots[1].LCHJGCHDHFO());
			colorButton.FJAHJEMPPKH = MJMNGLHDJFH.BNGAJBNFFIL();
		}
	}

	private IEnumerator HDCOGGFMJKI()
	{
		return new AOIOJLBLECE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CCJOOMDHMKM()
	{
		SlotUI obj = slotUI;
		obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BDFAGNMHKJB));
		SlotUI obj2 = slotUI;
		obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(IJJFCOBACFM));
		SlotUI obj3 = slotUI;
		obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(BDFAGNMHKJB));
	}

	private void BPMAFFOKDJP()
	{
		List<Slot> pCJEDMJEKEF = (from x in (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).OMCMMDDGHFB()
				select (x)).Where(NOKPINKFIOD)
			where !(x.itemInstance is FoodInstance foodInstance) || !foodInstance.LHBPOPOIFLE().canBeAged || foodInstance.GBCJNGADANM > 0
			select x).ToList();
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).CJODJMLPGOL(pCJEDMJEKEF, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private bool NOKPINKFIOD(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return true;
	}

	private void PHLCHCCAANF()
	{
		if (ColorPickerUI.MENNLOGFNOK(base.JIIGOACEIKL).BGLJFMHCFJF())
		{
			ColorPickerUI.JDODHPEDACJ(base.JIIGOACEIKL).CloseUI();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private bool KLIPNEHIEJI(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
	}

	public static DrinkDispenserUI HEGPDGJEOPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private bool DDEPAJKFIMI(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
	}

	public void NPFBLOHKANM(DrinkDispenser MJMNGLHDJFH, int JIIGOACEIKL)
	{
		this.MJMNGLHDJFH = MJMNGLHDJFH;
		DrinkDispenser mJMNGLHDJFH = this.MJMNGLHDJFH;
		mJMNGLHDJFH.OnContainerChanged = (Action)Delegate.Combine(mJMNGLHDJFH.OnContainerChanged, new Action(GPIOFFEMEPC));
		HLPHOADDCMH();
		slotUI.IHENCGDNPBL = MJMNGLHDJFH.slots[1];
		MainUI.PCMOFKMCNCM(JIIGOACEIKL, MJMNGLHDJFH, MJMNGLHDJFH.drinkDispenserId);
	}

	private void NLJMBNIHLAK()
	{
		EOOMHBCLCAK();
	}

	private void GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	private void GABMGKDLMII()
	{
		FCCLMDKIJND();
	}

	private void FAOOIGPACKN()
	{
		if (ColorPickerUI.JDODHPEDACJ(base.JIIGOACEIKL).BGLJFMHCFJF())
		{
			ColorPickerUI.MDFIDKHOPDJ(base.JIIGOACEIKL).BOBCIFEDJED();
		}
		if (LKOJBFMGMAE && (Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)MJMNGLHDJFH).gameObject)
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).PNHCLGGKBOB();
		}
	}

	private bool HGCOBCACCLG(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
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

	private IEnumerator OHJLHCBLPHM()
	{
		return new AOIOJLBLECE(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool PPGABIEJEMB(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
	}

	private bool LKEKIILIGBE(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return false;
	}

	private bool FJJDNACGBJO(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return true;
	}

	public void GBDBMENFEPP(SpriteColor FJAHJEMPPKH)
	{
		if ((Object)(object)MJMNGLHDJFH != (Object)null)
		{
			MJMNGLHDJFH.AAIFCGDJCOA(FJAHJEMPPKH);
		}
	}

	private bool GAHEJHOFLBN(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return Utils.DOOILKJLDHD(NCPGNLOJGAF.itemInstance, MJMNGLHDJFH);
		}
		return true;
	}
}
