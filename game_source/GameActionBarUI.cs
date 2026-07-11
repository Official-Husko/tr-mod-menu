using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameActionBarUI : ActionBarUI
{
	[CompilerGenerated]
	private sealed class FAGAECFAEGP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameActionBarUI _003C_003E4__this;

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
		public FAGAECFAEGP(int _003C_003E1__state)
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
			GameActionBarUI gameActionBarUI = _003C_003E4__this;
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
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				gameActionBarUI.OpenUI();
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
	private sealed class EJHNBKLINFJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameActionBarUI _003C_003E4__this;

		public int playerNum;

		public int numSelected;

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
		public EJHNBKLINFJ(int _003C_003E1__state)
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
			GameActionBarUI gameActionBarUI = _003C_003E4__this;
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
				gameActionBarUI.BIFGKIKALBK(playerNum, numSelected);
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

	public static GameActionBarUI[] instances = new GameActionBarUI[3];

	public GameObject trayTicket;

	public GameObject[] trayTickets;

	public Sprite beer;

	public Sprite water;

	public Image[] trayTicketsSprites;

	public Image[] trayTicketsColors;

	public Progressor trayRadialKey;

	public Progressor trayRadialButton;

	public BaitInfoUI baitInfo;

	public ToolRowsInfoUI toolRowsInfo;

	private bool MELILFOPIPM;

	private Slot PPFIBIBKBBI;

	private List<Slot> CDEMNCNPNAP = new List<Slot>();

	private void PDFHEBPDCPB()
	{
		instances[0].BOBCIFEDJED();
		instances[0].IDLAGJNLPJL();
	}

	private void LLMIOJFHPKM(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 0; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	public void MBONNCDBIPM()
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(KJEPKNADCBD());
	}

	private void FNOBMMFFEJI(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	private void HCDJECJLHHM()
	{
		instances[0].OpenUI();
		instances[0].BOBCIFEDJED();
		instances[5].CloseUI();
	}

	public static GameActionBarUI PJIGCLMPHKP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AEPBMHIHNJA(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 0; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
	}

	private void KCOFAJBKHAO()
	{
		((MonoBehaviour)this).StartCoroutine(FGJDEMFBAHI(base.JIIGOACEIKL, ActionBarInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).FDOFGNEDJMK()));
	}

	private IEnumerator MGBPJPMMFGG(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		return new EJHNBKLINFJ(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			numSelected = NJNDJNGLDGK
		};
	}

	public static GameActionBarUI DIMABMEHNNI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static GameActionBarUI EKEDKKKPAEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BIFGKIKALBK(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 0; i < uiSlots.Length; i++)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
	}

	private void JJPJBLEEPFP(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 0; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
	}

	private void MMANKOFCDGO()
	{
		((MonoBehaviour)this).StartCoroutine(PKIHJFCHPFA(base.JIIGOACEIKL, ActionBarInventory.IPBEEBLCHHA(base.JIIGOACEIKL, LAGHIOKLJGH: true).JGJJDOHBEMJ()));
	}

	private void CEIKCGEJNGK()
	{
		instances[1].CloseUI();
		instances[1].IDLAGJNLPJL();
	}

	private void FEPFNOEGFEM()
	{
		((MonoBehaviour)this).StartCoroutine(JGNOOKBIAKP(base.JIIGOACEIKL, ActionBarInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CMHNEHPIBDN()));
	}

	public void AGIEMAPKFNF(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private IEnumerator EIBJGNJCFDI(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		yield return null;
		BIFGKIKALBK(JIIGOACEIKL, NJNDJNGLDGK);
	}

	private IEnumerator EKJBDNGBHFE(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		return new EJHNBKLINFJ(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			numSelected = NJNDJNGLDGK
		};
	}

	public void OnWorldLoaded()
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(OOCHIDEHLAI());
	}

	public void CFPIPHBGMFK(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	public static GameActionBarUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FMEOHOJOCNF(bool JGINKGFMIOE)
	{
		for (int i = 1; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private void MMPIDNALNJL()
	{
		instances[1].IDLAGJNLPJL();
		instances[1].BOBCIFEDJED();
		instances[5].CloseUI();
	}

	private IEnumerator DDEABLNFDIN()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PKIHJFCHPFA(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		return new EJHNBKLINFJ(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			numSelected = NJNDJNGLDGK
		};
	}

	private IEnumerator HHCKJPOHFLF(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		return new EJHNBKLINFJ(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			numSelected = NJNDJNGLDGK
		};
	}

	private IEnumerator CNBOPNIFCFA()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JIBHLLJGGEN()
	{
		((MonoBehaviour)this).StartCoroutine(LDOHKKFCOOD(base.JIIGOACEIKL, ActionBarInventory.MHDKNEKDKII(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DOMHGEAFCAP()));
	}

	private void HBPJDFPDFIF(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 0; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	private void NMPKBILIHBJ()
	{
		instances[0].BOBCIFEDJED();
		instances[1].OpenUI();
	}

	public void SetAutomaticTransfer(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private void FCFDLPNGDBP()
	{
		instances[0].BOBCIFEDJED();
		instances[0].EDHEIFHAAKO();
	}

	private void OOGPJBFKHLI()
	{
		instances[0].CloseUI();
		instances[0].OpenUI();
	}

	public void HEFCNBGFPGL(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i += 0)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	public void JDFDLEEELFH()
	{
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(FNPDCCBCAJD());
	}

	private void NOEMNGBNLCE()
	{
		instances[1].BOBCIFEDJED();
		instances[0].EDHEIFHAAKO();
	}

	private void AGGCIDNJFMB(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
	}

	private IEnumerator LDOHKKFCOOD(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		yield return null;
		BIFGKIKALBK(JIIGOACEIKL, NJNDJNGLDGK);
	}

	public void MAKKDPBOHNK()
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(DAPEFIDBNFN());
	}

	private void OnEnable()
	{
		((MonoBehaviour)this).StartCoroutine(FGJDEMFBAHI(base.JIIGOACEIKL, ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetCurrentSlotSelected()));
	}

	private IEnumerator CKNHBCHIEHC()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HOMGFLMAJLM(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	public static GameActionBarUI GDFNPHJJCPP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BGGONGNJHLI()
	{
		instances[0].BOBCIFEDJED();
		instances[1].OpenUI();
	}

	private IEnumerator EHBKNOEHFPM()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ECFPIMHGGNP(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i++)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	public void DCNMGOHCLNH(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i += 0)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	public static GameActionBarUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void JAOFMNCEMEM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		for (int i = 0; i < uiSlots.Length; i++)
		{
			if (uiSlots[i].IHENCGDNPBL.Equals(ADEBNALPEHE))
			{
				MELILFOPIPM = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetCurrentSlotSelected() != i;
				ActionBarInventory.GetPlayer(JIIGOACEIKL).SetCurrentSlotSelected(i);
			}
		}
	}

	public void LMKCLPLJMPA()
	{
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(MNDACPGIOFN());
	}

	private void GKIMNPJBGMK()
	{
		instances[0].OpenUI();
		instances[0].BOBCIFEDJED();
		instances[5].CloseUI();
	}

	public static GameActionBarUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JHGDBLMEFMP()
	{
		((MonoBehaviour)this).StartCoroutine(JGNOOKBIAKP(base.JIIGOACEIKL, ActionBarInventory.ADHIHCNAKFP(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FDOFGNEDJMK()));
	}

	private void LJBDGLCFHNE()
	{
		instances[1].CloseUI();
		instances[1].EDHEIFHAAKO();
	}

	public static GameActionBarUI HEGPDGJEOPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static GameActionBarUI PPJMPMKLCME(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void EOKOKNIAHAO(bool JGINKGFMIOE)
	{
		for (int i = 1; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private IEnumerator MNDACPGIOFN()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KOFDLKFJBNF(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	private void BNLMMKCJCDK()
	{
		instances[1].BOBCIFEDJED();
		instances[1].IDLAGJNLPJL();
	}

	private void AOMNIAGDCKI()
	{
		instances[0].CloseUI();
		instances[0].EDHEIFHAAKO();
	}

	private void HNKMCINHGDA()
	{
		instances[1].OpenUI();
		instances[1].BOBCIFEDJED();
		instances[1].CloseUI();
	}

	private void DADNFLMIAFL(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i++)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].FocusSlotActionBar(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	private IEnumerator KGJIDNPPKFD()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	public static GameActionBarUI AGNKKAPMHLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static GameActionBarUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KMCILNGBGMH()
	{
		instances[0].EDHEIFHAAKO();
		instances[0].BOBCIFEDJED();
		instances[8].CloseUI();
	}

	public static GameActionBarUI JGNOJMLHPOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OHAGFHOPGJI(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
	}

	private void ECHOEJGKPJF()
	{
		instances[0].CloseUI();
		instances[1].EDHEIFHAAKO();
	}

	private void CIGGOLPGKOO()
	{
		instances[0].CloseUI();
		instances[0].OpenUI();
	}

	public static GameActionBarUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator OOLEMEDHPEI()
	{
		yield return null;
		yield return null;
		OpenUI();
	}

	public void GMCFIEDIGCB(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i += 0)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private IEnumerator BMDMBBJPGEB()
	{
		yield return null;
		yield return null;
		OpenUI();
	}

	public static GameActionBarUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static GameActionBarUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Start()
	{
		base.Start();
		ActionBarInventory player = ActionBarInventory.GetPlayer(base.JIIGOACEIKL);
		player.OnSelectionChanged = (Action<int, int>)Delegate.Combine(player.OnSelectionChanged, new Action<int, int>(BIFGKIKALBK));
		BIFGKIKALBK(base.JIIGOACEIKL, ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetCurrentSlotSelected());
		if (numInstance == 0)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OnWorldLoaded));
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		}
	}

	private void MIBHNLGIKBP()
	{
		instances[0].BOBCIFEDJED();
		instances[1].EDHEIFHAAKO();
	}

	public override bool SlotRightClicked(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (ADEBNALPEHE != null && ADEBNALPEHE.itemInstance != null)
		{
			Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
			int num = ((!PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) || ADEBNALPEHE.Stack <= 1) ? ADEBNALPEHE.Stack : (ADEBNALPEHE.Stack / 2));
			CDEMNCNPNAP.Clear();
			for (int i = 0; i < num; i++)
			{
				if (MainUI.CurrentSlots(JIIGOACEIKL) != null)
				{
					PPFIBIBKBBI = FMONHONFMOM(ADEBNALPEHE.itemInstance);
					if (PPFIBIBKBBI != null)
					{
						ADEBNALPEHE.MEODNPFJDMH(CDPAMNIPPEC: false);
						if (!CDEMNCNPNAP.Contains(PPFIBIBKBBI))
						{
							CDEMNCNPNAP.Add(PPFIBIBKBBI);
						}
						continue;
					}
				}
				if (!((Object)(object)currentContainer != (Object)null) || currentContainer.onlyDelivery)
				{
					break;
				}
				PPFIBIBKBBI = Utils.CHMEHDFPGCI(JIIGOACEIKL, ADEBNALPEHE.itemInstance, currentContainer.slots, currentContainer.GetMaxStack(ADEBNALPEHE.itemInstance), null, null, null, null, FoodType.None, null, OECLHGILEOL: false, CDPAMNIPPEC: false);
				if (PPFIBIBKBBI != null)
				{
					ADEBNALPEHE.MEODNPFJDMH(CDPAMNIPPEC: false);
					if (!CDEMNCNPNAP.Contains(PPFIBIBKBBI))
					{
						CDEMNCNPNAP.Add(PPFIBIBKBBI);
					}
				}
			}
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg), HOMFPAFAOGD: true, null, null, 0.5f);
			if (CDEMNCNPNAP.Count > 0)
			{
				if (OnlineManager.PlayingOnline())
				{
					if (!CDEMNCNPNAP.Contains(ADEBNALPEHE))
					{
						CDEMNCNPNAP.Add(ADEBNALPEHE);
					}
					OnlineSlotsManager.instance.SendSlots(CDEMNCNPNAP.ToArray());
				}
				return true;
			}
		}
		return false;
	}

	private void NDCOJAMLGNK()
	{
		instances[0].CloseUI();
		instances[1].EDHEIFHAAKO();
	}

	private void LJKBNNHGEOM()
	{
		instances[1].CloseUI();
		instances[1].OpenUI();
	}

	private void MJFAPALDBCO()
	{
		instances[1].IDLAGJNLPJL();
		instances[0].BOBCIFEDJED();
		instances[6].BOBCIFEDJED();
	}

	private void GCPOOGINBND(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i++)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	private void HFFCCDLHHDD()
	{
		instances[1].EDHEIFHAAKO();
		instances[1].BOBCIFEDJED();
		instances[3].BOBCIFEDJED();
	}

	public void INJNMCCGFIF()
	{
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(EHBKNOEHFPM());
	}

	public void DDLGPEJGJCG(bool JGINKGFMIOE)
	{
		for (int i = 1; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private void OJLGPAJPCHG()
	{
		((MonoBehaviour)this).StartCoroutine(HHCKJPOHFLF(base.JIIGOACEIKL, ActionBarInventory.DACNEICGAAE(base.JIIGOACEIKL, LAGHIOKLJGH: true).FDOFGNEDJMK()));
	}

	private IEnumerator POHKEGGLBML(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		yield return null;
		BIFGKIKALBK(JIIGOACEIKL, NJNDJNGLDGK);
	}

	private IEnumerator GFACJLHEKDL(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		yield return null;
		BIFGKIKALBK(JIIGOACEIKL, NJNDJNGLDGK);
	}

	protected override bool GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (base.GKAJFEOGKMD(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (MainUI.CurrentSlots(JIIGOACEIKL) != null)
			{
				PPFIBIBKBBI = FMONHONFMOM(ADEBNALPEHE.itemInstance);
				if (PPFIBIBKBBI != null)
				{
					Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
					ADEBNALPEHE.MEODNPFJDMH(CDPAMNIPPEC: false);
					if (OnlineManager.PlayingOnline())
					{
						OnlineSlotsManager.instance.SendSlots(new Slot[2] { ADEBNALPEHE, PPFIBIBKBBI });
					}
					return true;
				}
			}
			Container currentContainer = MainUI.GetCurrentContainer(JIIGOACEIKL);
			if (Object.op_Implicit((Object)(object)currentContainer) && !currentContainer.onlyDelivery)
			{
				PPFIBIBKBBI = Utils.CHMEHDFPGCI(JIIGOACEIKL, ADEBNALPEHE.itemInstance, currentContainer.slots, currentContainer.GetMaxStack(ADEBNALPEHE.itemInstance), null, null, null, null, FoodType.None, null, OECLHGILEOL: false, CDPAMNIPPEC: false);
				if (PPFIBIBKBBI != null)
				{
					Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
					ADEBNALPEHE.MEODNPFJDMH(CDPAMNIPPEC: false);
					if (OnlineManager.PlayingOnline())
					{
						OnlineSlotsManager.instance.SendSlots(new Slot[2] { ADEBNALPEHE, PPFIBIBKBBI });
					}
					return true;
				}
			}
		}
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			for (int i = 0; i < uiSlots.Length; i++)
			{
				if (uiSlots[i].IHENCGDNPBL.Equals(ADEBNALPEHE))
				{
					ActionBarInventory.GetPlayer(JIIGOACEIKL).SetCurrentSlotSelected(i);
					ActionBarInventory.GetPlayer(JIIGOACEIKL).ActionSelectedItem(JIIGOACEIKL, KLGOCJMGKFO: true, CGBJIEHMIKG: true, OBICAGCGMBC: true, MELILFOPIPM);
					return true;
				}
			}
		}
		return true;
	}

	private void JPKENCMNEMM()
	{
		instances[0].OpenUI();
		instances[0].CloseUI();
		instances[0].CloseUI();
	}

	private void LNNAJMBIDAE()
	{
		instances[1].CloseUI();
		instances[1].IDLAGJNLPJL();
	}

	private IEnumerator HGCHIKOLOOI()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove") && SelectObject.GetPlayer(base.JIIGOACEIKL).focusedSlot != null)
		{
			DropItemsFocusedSlot();
		}
		if (Utils.DDPONGCPCNG(base.JIIGOACEIKL) && !DecorationMode.GetPlayer(base.JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (Item.MLBOMGHINCA(ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetSelectedItem(), null) && ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetSelectedItem() is Rod)
			{
				baitInfo.UpdatePosition(BJFHJCFOEHG: true);
			}
			else
			{
				baitInfo.UpdatePosition(BJFHJCFOEHG: false);
			}
			if (Item.MLBOMGHINCA(ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetSelectedItem(), null) && ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetSelectedItem() is Tool tool && tool.FEDHOEJNAII(base.JIIGOACEIKL) > 1 && (tool is WateringCan || tool is Hoe || tool is Spade))
			{
				ToolInstance toolInstance = ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetSelectedItemInstance() as ToolInstance;
				toolRowsInfo.SetRowsNumber(toolInstance.selectedRowCount, tool.FEDHOEJNAII(base.JIIGOACEIKL), tool.toolType);
				toolRowsInfo.UpdatePosition(BJFHJCFOEHG: true);
			}
			else
			{
				toolRowsInfo.UpdatePosition(BJFHJCFOEHG: false);
			}
		}
		else
		{
			baitInfo.UpdatePosition(BJFHJCFOEHG: false);
			toolRowsInfo.UpdatePosition(BJFHJCFOEHG: false);
		}
	}

	private void CEOHBCKABGB()
	{
		instances[0].BOBCIFEDJED();
		instances[0].OpenUI();
	}

	private void AGMLGNDDINL()
	{
		instances[0].OpenUI();
		instances[1].CloseUI();
		instances[2].CloseUI();
	}

	private void FGJOIGLLNHN()
	{
		instances[1].CloseUI();
		instances[0].IDLAGJNLPJL();
	}

	private void NDDECMKACON(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
	}

	public void COBGOPCEBAC()
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(CKNHBCHIEHC());
	}

	private void HADCIGKNFKK()
	{
		instances[0].CloseUI();
		instances[1].OpenUI();
	}

	private IEnumerator JGFMEGHIPLO()
	{
		return new FAGAECFAEGP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AJOAKOCODOC()
	{
		((MonoBehaviour)this).StartCoroutine(EIBJGNJCFDI(base.JIIGOACEIKL, ActionBarInventory.IPBEEBLCHHA(base.JIIGOACEIKL).FDOFGNEDJMK()));
	}

	private IEnumerator JGNOOKBIAKP(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		yield return null;
		BIFGKIKALBK(JIIGOACEIKL, NJNDJNGLDGK);
	}

	private void HJKONJICGML()
	{
		((MonoBehaviour)this).StartCoroutine(FDMFCGPPLAF(base.JIIGOACEIKL, ActionBarInventory.ADHIHCNAKFP(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LIMCJONFMPN()));
	}

	private void PMMGCDBMMMN()
	{
		((MonoBehaviour)this).StartCoroutine(FDMFCGPPLAF(base.JIIGOACEIKL, ActionBarInventory.BNMEANGDMIP(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KFLNAJIBFIF()));
	}

	private IEnumerator OOCHIDEHLAI()
	{
		yield return null;
		yield return null;
		OpenUI();
	}

	private void BNPFGDOJKEK(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	public static GameActionBarUI NDPAJCGHGOB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ABFHNMGGEKH(bool JGINKGFMIOE)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private void KAGNKGEAPCH()
	{
		instances[0].CloseUI();
		instances[1].IDLAGJNLPJL();
	}

	public override void OpenUI()
	{
		if (!IsOpen() && !Utils.FNLJGAEHNKA() && (!GameManager.LocalCoop() || !LocalCooperativeManager.instance.cameraFocusedOnOnePlayer))
		{
			base.OpenUI();
			BIFGKIKALBK(base.JIIGOACEIKL, ActionBarInventory.GetPlayer(base.JIIGOACEIKL).GetCurrentSlotSelected());
		}
	}

	private void NMPFHHEFOPH()
	{
		((MonoBehaviour)this).StartCoroutine(EIBJGNJCFDI(base.JIIGOACEIKL, ActionBarInventory.IPBEEBLCHHA(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NLIEGDDKKIJ()));
	}

	private IEnumerator KJEPKNADCBD()
	{
		yield return null;
		yield return null;
		OpenUI();
	}

	private void ANMOAFFGEOE()
	{
		((MonoBehaviour)this).StartCoroutine(PKIHJFCHPFA(base.JIIGOACEIKL, ActionBarInventory.BNMEANGDMIP(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NLIEGDDKKIJ()));
	}

	public static GameActionBarUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator FNPDCCBCAJD()
	{
		yield return null;
		yield return null;
		OpenUI();
	}

	private IEnumerator JCHHFODEPMM(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		return new EJHNBKLINFJ(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			numSelected = NJNDJNGLDGK
		};
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void MKPGOJDPPNK(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	public void GPGGFBFIKDK(bool JGINKGFMIOE)
	{
		for (int i = 0; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	public void LCFOAJJHGPA(bool JGINKGFMIOE)
	{
		for (int i = 1; i < uiSlots.Length; i++)
		{
			uiSlots[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	public static GameActionBarUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
		}
	}

	private void FJFLGDADEKM()
	{
		((MonoBehaviour)this).StartCoroutine(PEAIOLJBDHK(base.JIIGOACEIKL, ActionBarInventory.IPBEEBLCHHA(base.JIIGOACEIKL, LAGHIOKLJGH: true).FDOFGNEDJMK()));
	}

	public static GameActionBarUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator NDBPGIONECO()
	{
		yield return null;
		yield return null;
		OpenUI();
	}

	public static GameActionBarUI BGABEMMDDEH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator FDMFCGPPLAF(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		yield return null;
		BIFGKIKALBK(JIIGOACEIKL, NJNDJNGLDGK);
	}

	private void KFFLLKINKGP()
	{
		instances[0].CloseUI();
		instances[0].OpenUI();
	}

	private void ECMNKBGIMBO(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		for (int i = 1; i < uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				uiSlots[i].OJIAJLBFLCN(JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				uiSlots[i].LPLKIAKNEED(JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
	}

	private IEnumerator DAPEFIDBNFN()
	{
		yield return null;
		yield return null;
		OpenUI();
	}

	private void BNEPNPNOOFD()
	{
		instances[1].IDLAGJNLPJL();
		instances[0].CloseUI();
		instances[6].CloseUI();
	}

	private void ENLDJAEFHIJ()
	{
		instances[1].CloseUI();
		instances[0].EDHEIFHAAKO();
	}

	private IEnumerator FGJDEMFBAHI(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		yield return null;
		BIFGKIKALBK(JIIGOACEIKL, NJNDJNGLDGK);
	}

	public static GameActionBarUI PPDMGBACONH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator PEAIOLJBDHK(int JIIGOACEIKL, int NJNDJNGLDGK)
	{
		return new EJHNBKLINFJ(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			numSelected = NJNDJNGLDGK
		};
	}

	private void CFMNPAOICDB()
	{
		instances[1].BOBCIFEDJED();
		instances[0].EDHEIFHAAKO();
	}

	public static GameActionBarUI FHPEHDDFOIB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
