using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AgingRackUI : UIWindow
{
	[CompilerGenerated]
	private sealed class EIIBBKEHEOI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AgingRackUI _003C_003E4__this;

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
		public EIIBBKEHEOI(int _003C_003E1__state)
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
			AgingRackUI agingRackUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(agingRackUI.JIIGOACEIKL))
				{
					if (!agingRackUI.inputSlot1.IHENCGDNPBL.KPINNBKMOMO())
					{
						UISelectionManager.GetPlayer(agingRackUI.JIIGOACEIKL).Select(((Component)agingRackUI.inputSlot1).GetComponent<Selectable>());
					}
					else if (!agingRackUI.inputSlot2.IHENCGDNPBL.KPINNBKMOMO())
					{
						UISelectionManager.GetPlayer(agingRackUI.JIIGOACEIKL).Select(((Component)agingRackUI.inputSlot2).GetComponent<Selectable>());
					}
					else if (!agingRackUI.outputSlot1.IHENCGDNPBL.KPINNBKMOMO())
					{
						UISelectionManager.GetPlayer(agingRackUI.JIIGOACEIKL).Select(((Component)agingRackUI.outputSlot1).GetComponent<Selectable>());
					}
					else if (!agingRackUI.outputSlot2.IHENCGDNPBL.KPINNBKMOMO())
					{
						UISelectionManager.GetPlayer(agingRackUI.JIIGOACEIKL).Select(((Component)agingRackUI.outputSlot2).GetComponent<Selectable>());
					}
					else
					{
						GameInventoryUI.Get(agingRackUI.JIIGOACEIKL).SelectObjectNextFrame();
					}
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

	public AgingRack agingRack;

	[SerializeField]
	private SlotUI inputSlot1;

	[SerializeField]
	private SlotUI inputSlot2;

	[SerializeField]
	private SlotUI outputSlot1;

	[SerializeField]
	private SlotUI outputSlot2;

	[SerializeField]
	private Progressor progressBar1;

	[SerializeField]
	private Progressor progressBar2;

	public static AgingRackUI[] instances = new AgingRackUI[3];

	private void MAIMGNMIFKG()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(DJHDGAGGMAG));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(DEMJCAGLCGK));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(DJHDGAGGMAG));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(GOKPJPPNPIO));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(BHMJHLPFLGP));
	}

	private bool MPODMOPOIDF(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.PCCLMIEGMCE(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return false;
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void NIILOKCNLEN()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetAllSlots()
			select (x) into NCPGNLOJGAF
			where NCPGNLOJGAF.itemInstance != null && agingRack.inputSlot1.GPLKPEPAFOM(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance)
			select NCPGNLOJGAF).ToList();
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void IOIJCBMJCGP()
	{
		OKJHNAJBOPJ(progressBar1, inputSlot1, outputSlot1);
		FLNJCOEOIKO(progressBar2, inputSlot2, outputSlot2);
	}

	public static AgingRackUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AgingRackUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BLBDPGCKBHN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("<br/>Graphics Device Version: "), 797f);
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	private void FLNJCOEOIKO(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.KPINNBKMOMO() && !ADDNNEMPKNO.IHENCGDNPBL.PKFKJNODGJF())
		{
			KNKNNPOICFL.JJDKOIOIADG(305f);
		}
		else
		{
			KNKNNPOICFL.FAEDCPGHMCP(1131f);
		}
	}

	private void GAMIEEIGOLE()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).OMCMMDDGHFB()
			select (x)).Where(HFDGLFPFBMF).ToList();
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).PFFJANPMCMO(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void OKJHNAJBOPJ(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.KPINNBKMOMO() && !ADDNNEMPKNO.IHENCGDNPBL.PKFKJNODGJF())
		{
			KNKNNPOICFL.LNMAGEGNGIF(927f);
		}
		else
		{
			KNKNNPOICFL.NIPNGHKNIGN(1911f);
		}
	}

	private void EFPLADDLFAL()
	{
		FLNJCOEOIKO(progressBar1, inputSlot1, outputSlot1);
		DPHBFNMOMPJ(progressBar2, inputSlot2, outputSlot2);
	}

	private void JHNHGAEKBMF(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.KPINNBKMOMO() && !ADDNNEMPKNO.IHENCGDNPBL.KPINNBKMOMO())
		{
			KNKNNPOICFL.BHGJPBGINCG = 1f;
		}
		else
		{
			KNKNNPOICFL.BHGJPBGINCG = 0f;
		}
	}

	public static AgingRackUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IEPJAFLDBJJ()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(BHMJHLPFLGP));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(LFCHHDNDECB));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(BHMJHLPFLGP));
	}

	private IEnumerator GANBMFNPFPE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (!inputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot1).GetComponent<Selectable>());
			}
			else if (!inputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot2).GetComponent<Selectable>());
			}
			else if (!outputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot1).GetComponent<Selectable>());
			}
			else if (!outputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot2).GetComponent<Selectable>());
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	private IEnumerator LELBEAGBNPE()
	{
		return new EIIBBKEHEOI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FPKEPAFFBDK()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBDOBNLMLGM()
			select (x)).Where(ACADBCCENDC).ToList();
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).BGPOBAFOPOM(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private bool NIKFJBNBGNP(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.FPBONPGAKED(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return true;
	}

	private IEnumerator DCPJJCFHEHI()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (!inputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot1).GetComponent<Selectable>());
			}
			else if (!inputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot2).GetComponent<Selectable>());
			}
			else if (!outputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot1).GetComponent<Selectable>());
			}
			else if (!outputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot2).GetComponent<Selectable>());
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	public static AgingRackUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EDBDJLPHGGJ()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI2.OnSlotRightClick, new Action<int, Slot>(LINNKJNIFFL));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI3.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI4.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI5.OnSlotLeftClick, new Action<int, Slot>(BLBDPGCKBHN));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI6.OnSlotRightClick, new Action<int, Slot>(FDEAGFPHCNK));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI8.OnSlotRightClick, new Action<int, Slot>(LEDHDOPACJI));
	}

	private void HPDPHKLOEEL(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.LCHJGCHDHFO() && !ADDNNEMPKNO.IHENCGDNPBL.AHHEMNHJPME())
		{
			KNKNNPOICFL.PKGEJPPEPEC(1798f);
		}
		else
		{
			KNKNNPOICFL.PIDPOCCIFOK(1940f);
		}
	}

	private void CCGAKGKDANO()
	{
		EANACJGEPJJ(progressBar1, inputSlot1, outputSlot1);
		JHNHGAEKBMF(progressBar2, inputSlot2, outputSlot2);
	}

	private void JMMOJEDEKKM()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB()
			select (x)).Where(NIKFJBNBGNP).ToList();
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).DHFABEONKBG(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private IEnumerator EFHPCENHEOD()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (!inputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot1).GetComponent<Selectable>());
			}
			else if (!inputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot2).GetComponent<Selectable>());
			}
			else if (!outputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot1).GetComponent<Selectable>());
			}
			else if (!outputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot2).GetComponent<Selectable>());
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	private void DEMJCAGLCGK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Dig"), 1772f);
			}
		}
		else
		{
			LILJCAOBMFH();
		}
	}

	private void BLBNAPODBEB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("tutorialPopUp81"), 864f);
			}
		}
		else
		{
			MIIMICCMIAL();
		}
	}

	private void ADDLDNPHIHF()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(EJJIOAPDKIM));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(NINCOHFHIAO));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(GOEMPOGBCJM));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(MHJOKKIMBPG));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(GOKPJPPNPIO));
	}

	private void DAPNGAPANJG()
	{
		JHNHGAEKBMF(progressBar1, inputSlot1, outputSlot1);
		JHNHGAEKBMF(progressBar2, inputSlot2, outputSlot2);
	}

	private IEnumerator GMMNENIMEID()
	{
		return new EIIBBKEHEOI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CCMENDGBGAK()
	{
		return new EIIBBKEHEOI(1)
		{
			_003C_003E4__this = this
		};
	}

	[CompilerGenerated]
	private bool KKEEFINCEOE(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.GPLKPEPAFOM(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return false;
	}

	private void OnEnable()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
	}

	public static AgingRackUI GDFNPHJJCPP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AgingRackUI FHKGDLNJFFA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void INEOPOKGKEM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("talentShelves"), 1419f);
			}
		}
		else
		{
			FPKEPAFFBDK();
		}
	}

	private void LEIGBCPBHHK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Food not found, sending a food instance message!"), 182f);
			}
		}
		else
		{
			PDMBEOEGPHJ();
		}
	}

	public static AgingRackUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private bool LKEKIILIGBE(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.FPBONPGAKED(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return false;
	}

	private void ANLHPMPMBFM()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI.OnSlotLeftClick, new Action<int, Slot>(DJHDGAGGMAG));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI2.OnSlotRightClick, new Action<int, Slot>(MHJOKKIMBPG));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI3.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI4.OnSlotRightClick, new Action<int, Slot>(DEMJCAGLCGK));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI5.OnSlotLeftClick, new Action<int, Slot>(ALKHHKEFLCL));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI6.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI7.OnSlotLeftClick, new Action<int, Slot>(LFCHHDNDECB));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI8.OnSlotRightClick, new Action<int, Slot>(MHJOKKIMBPG));
	}

	public static AgingRackUI OCCEHEMCGJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		((MonoBehaviour)this).StartCoroutine(EAGKLIALMCH());
	}

	private void NINCOHFHIAO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("chatSounds"), 1632f);
			}
		}
		else
		{
			PDMBEOEGPHJ();
		}
	}

	private void EEAKGHLCFOM()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI2.OnSlotRightClick, new Action<int, Slot>(LINNKJNIFFL));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI3.OnSlotLeftClick, new Action<int, Slot>(BLBDPGCKBHN));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI4.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI5.OnSlotLeftClick, new Action<int, Slot>(BLBDPGCKBHN));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI6.OnSlotRightClick, new Action<int, Slot>(LEDHDOPACJI));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI7.OnSlotLeftClick, new Action<int, Slot>(ALKHHKEFLCL));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI8.OnSlotRightClick, new Action<int, Slot>(INEOPOKGKEM));
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

	private void PDMBEOEGPHJ()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBDOBNLMLGM()
			select (x)).Where(NIKFJBNBGNP).ToList();
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).BGPOBAFOPOM(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void IIJDMGNLEEN(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.PKFKJNODGJF() && !ADDNNEMPKNO.IHENCGDNPBL.AHHEMNHJPME())
		{
			KNKNNPOICFL.OHNGIDACMMM(795f);
		}
		else
		{
			KNKNNPOICFL.BPPMDMLMGPN(883f);
		}
	}

	private void HIGOCKHIGBF()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots()
			select (x)).Where(ECFHMOJONJH).ToList();
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).NACCNOFNEHM(pCJEDMJEKEF, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private void GFIKJDBNIFK()
	{
		EANACJGEPJJ(progressBar1, inputSlot1, outputSlot1);
		HPDPHKLOEEL(progressBar2, inputSlot2, outputSlot2);
	}

	private void HJKCEFJCEAE(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.PKFKJNODGJF() && !ADDNNEMPKNO.IHENCGDNPBL.LCHJGCHDHFO())
		{
			KNKNNPOICFL.GILHMDPDMPA(1411f);
		}
		else
		{
			KNKNNPOICFL.AKLMBMNEBOG(557f);
		}
	}

	public static AgingRackUI LKJNAHIPOLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator NOPLPJJGAPK()
	{
		return new EIIBBKEHEOI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FCKNMNKHDCJ()
	{
		OKJHNAJBOPJ(progressBar1, inputSlot1, outputSlot1);
		HPDPHKLOEEL(progressBar2, inputSlot2, outputSlot2);
	}

	private void EJJIOAPDKIM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Player"), 1436f);
			}
		}
		else
		{
			LBLNFMIHBEE();
		}
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			MainUI.ClearCurrentSlots(base.JIIGOACEIKL);
		}
	}

	private void GOKPJPPNPIO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Planning"), 1771f);
			}
		}
		else
		{
			GAMIEEIGOLE();
		}
	}

	private void NBFDDKAHFJN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Steam Initialized: False"), 1056f);
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	private void GDEMFDGKFBH()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OMCMMDDGHFB()
			select (x)).Where(DAEGOIOEBGM).ToList();
		GameInventoryUI.MENNLOGFNOK(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	public static AgingRackUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static AgingRackUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BHMJHLPFLGP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Player"), 385f);
			}
		}
		else
		{
			LBLNFMIHBEE();
		}
	}

	private void LINNKJNIFFL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get(" "), 541f);
			}
		}
		else
		{
			HIGOCKHIGBF();
		}
	}

	private void DPHBFNMOMPJ(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.LCHJGCHDHFO() && !ADDNNEMPKNO.IHENCGDNPBL.PKFKJNODGJF())
		{
			KNKNNPOICFL.MCCIGMPHBOF(965f);
		}
		else
		{
			KNKNNPOICFL.NCOOHHBLAAM(971f);
		}
	}

	private void MHJOKKIMBPG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Perks/playerPerk_name_"), 1035f);
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	protected override void Start()
	{
		base.Start();
	}

	private bool OCKABNFCDBO(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.MDABLLHEDAC(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return false;
	}

	private void FDEAGFPHCNK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Tutorial/T112/Dialogue1"), 1245f);
			}
		}
		else
		{
			FPKEPAFFBDK();
		}
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

	private void MAJCIOMJLJB()
	{
		EANACJGEPJJ(progressBar1, inputSlot1, outputSlot1);
		HJKCEFJCEAE(progressBar2, inputSlot2, outputSlot2);
	}

	private void ALKHHKEFLCL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("================== PLACE PIECE ({0}-{1}/{2}) ======================="), 358f);
			}
		}
		else
		{
			GAMIEEIGOLE();
		}
	}

	private void ONNAGOCFJML()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(NBFDDKAHFJN));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(NBFDDKAHFJN));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(DEMJCAGLCGK));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(BLBDPGCKBHN));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(LINNKJNIFFL));
	}

	private void LFCHHDNDECB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Timeout moving player to position in NinjaChallengeEvent.MovePlayerAndKyrohCoroutine"), 445f);
			}
		}
		else
		{
			JMMOJEDEKKM();
		}
	}

	private bool HFDGLFPFBMF(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.JJLPDIIFIFM(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return true;
	}

	private void EANACJGEPJJ(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.AHHEMNHJPME() && !ADDNNEMPKNO.IHENCGDNPBL.PKFKJNODGJF())
		{
			KNKNNPOICFL.ILBBADKPFGL(374f);
		}
		else
		{
			KNKNNPOICFL.FOLMDNFLBOE(1261f);
		}
	}

	private IEnumerator FBLNGNAHCHJ()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (!inputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot1).GetComponent<Selectable>());
			}
			else if (!inputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot2).GetComponent<Selectable>());
			}
			else if (!outputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot1).GetComponent<Selectable>());
			}
			else if (!outputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot2).GetComponent<Selectable>());
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	private void DDCJJOAHOLK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Hanghover"), 1097f);
			}
		}
		else
		{
			MIIMICCMIAL();
		}
	}

	private bool ECFHMOJONJH(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.PCCLMIEGMCE(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return false;
	}

	private void JCGKLDIAHCG()
	{
		DPHBFNMOMPJ(progressBar1, inputSlot1, outputSlot1);
		EANACJGEPJJ(progressBar2, inputSlot2, outputSlot2);
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			NIILOKCNLEN();
			base.OpenUI();
			inputSlot1.IHENCGDNPBL = agingRack.inputSlot1;
			inputSlot2.IHENCGDNPBL = agingRack.inputSlot2;
			outputSlot1.IHENCGDNPBL = agingRack.outputSlot1;
			outputSlot2.IHENCGDNPBL = agingRack.outputSlot2;
			MainUI.AddToCurrentSlots(base.JIIGOACEIKL, inputSlot1.IHENCGDNPBL);
			MainUI.AddToCurrentSlots(base.JIIGOACEIKL, inputSlot2.IHENCGDNPBL);
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.openWood), HOMFPAFAOGD: true);
		}
	}

	private void FCLABOCLACJ()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(BHMJHLPFLGP));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(NBFDDKAHFJN));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(INEOPOKGKEM));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(ALKHHKEFLCL));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(BHMJHLPFLGP));
	}

	private void MMANKOFCDGO()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(ALKHHKEFLCL));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(FDEAGFPHCNK));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(ALKHHKEFLCL));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(NINCOHFHIAO));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(NBFDDKAHFJN));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(INEOPOKGKEM));
	}

	private void LBLNFMIHBEE()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).BBDOBNLMLGM()
			select (x)).Where(DAEGOIOEBGM).ToList();
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).CJODJMLPGOL(pCJEDMJEKEF, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	public static AgingRackUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OJLGOCFKLJE()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(INEOPOKGKEM));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(BLBDPGCKBHN));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(LINNKJNIFFL));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(NBFDDKAHFJN));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(LINNKJNIFFL));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(LFCHHDNDECB));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(INEOPOKGKEM));
	}

	private void MKGKKAJHLAO()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI.OnSlotLeftClick, new Action<int, Slot>(LFCHHDNDECB));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI2.OnSlotRightClick, new Action<int, Slot>(EJJIOAPDKIM));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI3.OnSlotLeftClick, new Action<int, Slot>(DJHDGAGGMAG));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI4.OnSlotRightClick, new Action<int, Slot>(FDEAGFPHCNK));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI5.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI6.OnSlotRightClick, new Action<int, Slot>(NINCOHFHIAO));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI7.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI8.OnSlotRightClick, new Action<int, Slot>(FDEAGFPHCNK));
	}

	public static AgingRackUI PIOIOJFDDNF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void GOEMPOGBCJM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("ReceiveCanBeMoveDroppedItem"), 388f);
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	private void FDGAGFIAPGJ()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI2.OnSlotRightClick, new Action<int, Slot>(MHJOKKIMBPG));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI3.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI4.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI5.OnSlotLeftClick, new Action<int, Slot>(LEIGBCPBHHK));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI6.OnSlotRightClick, new Action<int, Slot>(GOKPJPPNPIO));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI7.OnSlotLeftClick, new Action<int, Slot>(LFCHHDNDECB));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI8.OnSlotRightClick, new Action<int, Slot>(BHMJHLPFLGP));
	}

	private void DJHDGAGGMAG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("MildAleAbbreviation"), 643f);
			}
		}
		else
		{
			JMMOJEDEKKM();
		}
	}

	private void MPMGGLKFMNJ()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(NNBOJPDOGBB));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(GOKPJPPNPIO));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(GOEMPOGBCJM));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(EJJIOAPDKIM));
	}

	private void LEDHDOPACJI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("ReceiveEmployees"), 1932f);
			}
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	private IEnumerator EAGKLIALMCH()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (!inputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot1).GetComponent<Selectable>());
			}
			else if (!inputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)inputSlot2).GetComponent<Selectable>());
			}
			else if (!outputSlot1.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot1).GetComponent<Selectable>());
			}
			else if (!outputSlot2.IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)outputSlot2).GetComponent<Selectable>());
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	private void NNBOJPDOGBB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Cellar"), 1814f);
			}
		}
		else
		{
			HIGOCKHIGBF();
		}
	}

	private void HFIEBNHKALE(Progressor KNKNNPOICFL, SlotUI GKGEKFMGKGP, SlotUI ADDNNEMPKNO)
	{
		if (GKGEKFMGKGP.IHENCGDNPBL.PKFKJNODGJF() && !ADDNNEMPKNO.IHENCGDNPBL.AHHEMNHJPME())
		{
			KNKNNPOICFL.HADLIKGKHOK(1790f);
		}
		else
		{
			KNKNNPOICFL.LNJHLLABNNI(827f);
		}
	}

	private void ANMOAFFGEOE()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(GOEMPOGBCJM));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(DEMJCAGLCGK));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI3.OnSlotLeftClick, new Action<int, Slot>(BLBDPGCKBHN));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI4.OnSlotRightClick, new Action<int, Slot>(DEMJCAGLCGK));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI5.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI6.OnSlotRightClick, new Action<int, Slot>(INEOPOKGKEM));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI7.OnSlotLeftClick, new Action<int, Slot>(DJHDGAGGMAG));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI8.OnSlotRightClick, new Action<int, Slot>(INEOPOKGKEM));
	}

	private void POBELEOEHBL()
	{
		OKJHNAJBOPJ(progressBar1, inputSlot1, outputSlot1);
		FLNJCOEOIKO(progressBar2, inputSlot2, outputSlot2);
	}

	private bool ACADBCCENDC(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.MDABLLHEDAC(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return true;
	}

	private void MIIMICCMIAL()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBDOBNLMLGM()
			select (x)).Where(MPODMOPOIDF).ToList();
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).DHFABEONKBG(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private bool KIELCPGBHBI(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.JHBNILHHEKK(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return true;
	}

	private void OnDisable()
	{
		SlotUI slotUI = inputSlot1;
		slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI2 = inputSlot1;
		slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI3 = inputSlot2;
		slotUI3.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI3.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI4 = inputSlot2;
		slotUI4.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI4.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI5 = outputSlot1;
		slotUI5.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI5.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI6 = outputSlot1;
		slotUI6.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI6.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		SlotUI slotUI7 = outputSlot2;
		slotUI7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(slotUI7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
		SlotUI slotUI8 = outputSlot2;
		slotUI8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(slotUI8.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
	}

	private void LILJCAOBMFH()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBDOBNLMLGM()
			select (x)).Where(OCKABNFCDBO).ToList();
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).BGPOBAFOPOM(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private bool DAEGOIOEBGM(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null)
		{
			return agingRack.inputSlot1.MDABLLHEDAC(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance);
		}
		return false;
	}

	private void OJLKBHCKEEO()
	{
		EANACJGEPJJ(progressBar1, inputSlot1, outputSlot1);
		EANACJGEPJJ(progressBar2, inputSlot2, outputSlot2);
	}
}
