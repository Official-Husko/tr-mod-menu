using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContainerUI : UIWindow
{
	[CompilerGenerated]
	private sealed class IGBCPMOFHFF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ContainerUI _003C_003E4__this;

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
		public IGBCPMOFHFF(int _003C_003E1__state)
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
			ContainerUI containerUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(containerUI.JIIGOACEIKL))
				{
					if (((Selectable)((Component)containerUI.slotsUI[0]).GetComponent<Button>()).interactable)
					{
						UISelectionManager.GetPlayer(containerUI.JIIGOACEIKL).Select(((Component)containerUI.slotsUI[0]).gameObject);
					}
					else
					{
						GameInventoryUI.Get(containerUI.JIIGOACEIKL).SelectObjectNextFrame();
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

	private Placeable EAPCLAODGAE;

	[HideInInspector]
	public Slot[] containerSlots;

	protected bool OGCAKIGELBJ = true;

	[HideInInspector]
	public int currentPage;

	protected int EKLFNJDAKAM;

	protected int ACMPMOGOEOD;

	[HideInInspector]
	public Slot[] pageSlots;

	[SerializeField]
	protected List<SlotUI> slotsUI;

	[SerializeField]
	private SortInventoryUI sortInventoryUI;

	[SerializeField]
	private GameObject sortByType;

	[SerializeField]
	private GameObject transferButton;

	[SerializeField]
	protected TextMeshProUGUI sortByTypeTextMesh;

	[SerializeField]
	private GamepadSprite sortByTypeGamepadSprite;

	public GameObject sortButtonDisable;

	private Slot[] OPMPOBPEDFB;

	public ColorButton colorButtonScript;

	[SerializeField]
	private GameObject colourButtonObject;

	private bool KNFNPKLEIPC;

	public Container IAOOIEMCLBG { get; private set; }

	public MonoBehaviour NBKOCCODEKN { get; set; }

	public Container ALPOKDOCCGM { get; private set; }

	private int PNMKJCIOPGL()
	{
		if (!(ALPOKDOCCGM is Inventory inventory))
		{
			return 1;
		}
		return inventory.playerNum;
	}

	private int GNDHLBMAHNG()
	{
		if (!((Object)(object)EAPCLAODGAE != (Object)null))
		{
			return 0;
		}
		return EAPCLAODGAE.onlinePlaceable.uniqueId;
	}

	public int DCFEHAJDPDI()
	{
		return slotsUI.Count;
	}

	public int PPGPNLMFEHF()
	{
		return slotsUI.Count;
	}

	private IEnumerator OKMOKOHOAII()
	{
		return new IGBCPMOFHFF(1)
		{
			_003C_003E4__this = this
		};
	}

	public virtual void PJDPPGMDBMC(Slot[] PCJEDMJEKEF, Container ALPOKDOCCGM, bool IFMNAFDGKKK, bool OGCAKIGELBJ, int ACMPMOGOEOD, Slot[] OPMPOBPEDFB = null)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if ((Object)(object)IAOOIEMCLBG != (Object)null)
		{
			((UnityEvent)sortInventoryUI.byType.onClick).RemoveListener(new UnityAction(HHNHNDOEMOH));
		}
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		MGGEPAGGCCM(ALPOKDOCCGM);
		containerSlots = PCJEDMJEKEF;
		this.OGCAKIGELBJ = OGCAKIGELBJ;
		NJOFOAJFBMM(IFMNAFDGKKK);
		sortByType.SetActive(IFMNAFDGKKK);
		if ((Object)(object)ALPOKDOCCGM != (Object)null)
		{
			((UnityEvent)sortInventoryUI.byType.onClick).AddListener(new UnityAction(LAHAAJMFIMK));
		}
	}

	[SpecialName]
	private void MGGEPAGGCCM(Container AODONKKHPBP)
	{
		_003CGJNBAPKILKL_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public Container KGPBMKGHCGG()
	{
		return _003CGJNBAPKILKL_003Ek__BackingField;
	}

	private void FGJMKBAJLPI()
	{
		IAOOIEMCLBG.DKAEEOOJOHN(((Object)(object)EAPCLAODGAE != (Object)null) ? EAPCLAODGAE.BEIPALOAAJJ : 0);
	}

	private int MINNAOMOEAK()
	{
		if (!(ALPOKDOCCGM is Inventory inventory))
		{
			return 1;
		}
		return inventory.playerNum;
	}

	private void BKPCGCLPEME()
	{
		AFBOCEEODOC().DKAEEOOJOHN((!((Object)(object)EAPCLAODGAE != (Object)null)) ? 1 : EAPCLAODGAE.BEIPALOAAJJ, CDPAMNIPPEC: false);
	}

	protected void ODELNEFFCGF(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			slotsUI[i].autoTransferEnabled = BJFHJCFOEHG;
		}
	}

	private int BAPPAJODAEL()
	{
		if (!((Object)(object)EAPCLAODGAE != (Object)null))
		{
			return 1;
		}
		return EAPCLAODGAE.onlinePlaceable.uniqueId;
	}

	public void EDKDKKGBIPG(Container ALPOKDOCCGM, Placeable EAPCLAODGAE = null)
	{
		NHGDLJNOMFH(ALPOKDOCCGM);
		this.EAPCLAODGAE = EAPCLAODGAE;
	}

	protected void EKLFKLIOPEJ(bool OGCAKIGELBJ)
	{
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			slotsUI[i].draggingEnabled = OGCAKIGELBJ;
		}
	}

	private void KGIACKKFILH()
	{
		if (LKOJBFMGMAE && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).NJPFHBINPKE();
		}
	}

	private void OGGFLIPKCJI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, ADBHOJANLEI());
			if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.KPINNBKMOMO())
			{
				KBNANAELBIK();
			}
		}
	}

	private void CGBEIKHPCHL()
	{
		if (LKOJBFMGMAE && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private void GMNFJLNHIJI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	public int CMEJLOIEDEE()
	{
		return slotsUI.Count;
	}

	protected void LIGHIKENLEL(bool OGCAKIGELBJ)
	{
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			slotsUI[i].draggingEnabled = OGCAKIGELBJ;
		}
	}

	private void AGEHBGHNCCF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, MGHPGDJIFAI());
			if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
			{
				COMNOMFHDJD();
			}
		}
	}

	private void BNDEDPBJDME(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, KANDOMKDGAO(), CDPAMNIPPEC: false);
			if (CPNMIBGCKIN().onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
			{
				KBNANAELBIK();
			}
		}
	}

	private void FGDIKDLBMLH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	private void ABGJHIFEDIK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, KKDIAJIOLIC()))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Yes"), 45f);
			}
		}
		else if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
		{
			MPMCPFIFJEF();
		}
	}

	public void HJACPJMFMNF(Slot[] OPMPOBPEDFB)
	{
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).DBINLMFIOFE(OPMPOBPEDFB, OGCAKIGELBJ: false);
	}

	[SpecialName]
	private void LAGBBAPABLM(Container AODONKKHPBP)
	{
		_003CDGBMAFAIOHA_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void MAEGCLMJOJK(MonoBehaviour AODONKKHPBP)
	{
		_003CIHPHOLEHFIE_003Ek__BackingField = AODONKKHPBP;
	}

	public virtual void FillSlots(Slot[] PCJEDMJEKEF, Container ALPOKDOCCGM, bool IFMNAFDGKKK, bool OGCAKIGELBJ, int ACMPMOGOEOD, Slot[] OPMPOBPEDFB = null)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if ((Object)(object)IAOOIEMCLBG != (Object)null)
		{
			((UnityEvent)sortInventoryUI.byType.onClick).RemoveListener(new UnityAction(LAHAAJMFIMK));
		}
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		IAOOIEMCLBG = ALPOKDOCCGM;
		containerSlots = PCJEDMJEKEF;
		this.OGCAKIGELBJ = OGCAKIGELBJ;
		BLKJPKAHOIL(IFMNAFDGKKK);
		sortByType.SetActive(!IFMNAFDGKKK);
		if ((Object)(object)ALPOKDOCCGM != (Object)null)
		{
			((UnityEvent)sortInventoryUI.byType.onClick).AddListener(new UnityAction(LAHAAJMFIMK));
		}
	}

	public void SetContainer(Container ALPOKDOCCGM, Placeable EAPCLAODGAE = null)
	{
		this.ALPOKDOCCGM = ALPOKDOCCGM;
		this.EAPCLAODGAE = EAPCLAODGAE;
	}

	private void KBNANAELBIK()
	{
		int kHEICLKLPDE = currentPage;
		containerSlots = containerSlots.Where((Slot x) => !x.KPINNBKMOMO()).ToArray();
		Utils.BNDMCJGGBFK(slotsUI, containerSlots);
		for (int i = 1; i < slotsUI.Count; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null && slotsUI[i].IHENCGDNPBL.PKFKJNODGJF())
			{
				slotsUI[i].LIJPNDJCKGL(null);
				slotsUI[i].IHENCGDNPBL.isDirty = false;
			}
		}
		(this as BigContainerUI).HJFKMPHCIEN(kHEICLKLPDE);
	}

	public int EHCJIFDLKDN()
	{
		return slotsUI.Count;
	}

	public void GLHOBNCLAEB(bool IFMNAFDGKKK)
	{
		if ((Object)(object)EAHMDMDHLMH() != (Object)null)
		{
			JPKAMFAKIAN().onlyDelivery = IFMNAFDGKKK;
		}
		transferButton.SetActive(IFMNAFDGKKK);
		sortByType.SetActive(IFMNAFDGKKK);
	}

	private void GODMMIGKDLH()
	{
		AGBNIBCONKD().MNLBBGCOIEA(((Object)(object)EAPCLAODGAE != (Object)null) ? EAPCLAODGAE.BEIPALOAAJJ : 0, CDPAMNIPPEC: false);
	}

	private void MOILKOGGGKD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, ADBHOJANLEI());
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1154"), 1899f);
			}
		}
		else if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.LCHJGCHDHFO())
		{
			HGDMPKCDMJE();
		}
	}

	public void JGMNPLDFOPP(bool IFMNAFDGKKK)
	{
		if ((Object)(object)ALPOKDOCCGM != (Object)null)
		{
			ALPOKDOCCGM.onlyDelivery = IFMNAFDGKKK;
		}
		transferButton.SetActive(IFMNAFDGKKK);
		sortByType.SetActive(IFMNAFDGKKK);
	}

	private void KLEAAELDILC()
	{
		ALPOKDOCCGM.containerColor = colorButtonScript.NCHKDCMNDAD;
		(ALPOKDOCCGM as ItemContainer).ChangeContainerColours(ALPOKDOCCGM.containerColor);
	}

	private void IIGPELNPCMO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = false;
		}
	}

	[SpecialName]
	private void BNMEIONMOPD(Container AODONKKHPBP)
	{
		_003CDGBMAFAIOHA_003Ek__BackingField = AODONKKHPBP;
	}

	private void CFIHONNMEDC()
	{
		if (LKOJBFMGMAE && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).Deselect();
		}
	}

	private void FLONMIHGGMM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, JNGLBIMKBCJ());
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
			}
		}
		else if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.KPINNBKMOMO())
		{
			COMNOMFHDJD();
		}
	}

	private void DMEDPJKHEKD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, LKNKLPCKNNJ());
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/8/Dialogue Text"), 1517f);
			}
		}
		else if (EAHMDMDHLMH().onlyDelivery && ADEBNALPEHE.LCHJGCHDHFO())
		{
			KBNANAELBIK();
		}
	}

	private int MGHPGDJIFAI()
	{
		if (!(EAHMDMDHLMH() is Inventory inventory))
		{
			return 1;
		}
		return inventory.playerNum;
	}

	private void KNPNKCKLCLH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, MGHPGDJIFAI());
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("OnConversationLineRPC"), 1418f);
			}
		}
		else if (EAHMDMDHLMH().onlyDelivery && ADEBNALPEHE.AHHEMNHJPME())
		{
			COMNOMFHDJD();
		}
	}

	private void CLIKBHKCBNO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	private void KDNKJMAOMBJ()
	{
		AHBCPGGAENB().HPIAKEJIKMG((!((Object)(object)EAPCLAODGAE != (Object)null)) ? 1 : EAPCLAODGAE.BEIPALOAAJJ);
	}

	public void HICIPMAJJPI()
	{
		pageSlots = new Slot[slotsUI.Count];
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				pageSlots[i] = slotsUI[i].IHENCGDNPBL;
			}
		}
	}

	protected void NJOFOAJFBMM(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			slotsUI[i].autoTransferEnabled = BJFHJCFOEHG;
		}
	}

	private void NPMLBPOCHAH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, ADBHOJANLEI(), CDPAMNIPPEC: false);
			if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
			{
				HGDMPKCDMJE();
			}
		}
	}

	private void LIJBAFKLLIL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	private void JLBCPFFMCBP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, JNGLBIMKBCJ());
			if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.KPINNBKMOMO())
			{
				COMNOMFHDJD();
			}
		}
	}

	private void HGDMPKCDMJE()
	{
		int kHEICLKLPDE = currentPage;
		containerSlots = containerSlots.Where((Slot x) => !x.KPINNBKMOMO()).ToArray();
		Utils.BNDMCJGGBFK(slotsUI, containerSlots);
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null && slotsUI[i].IHENCGDNPBL.AHHEMNHJPME())
			{
				slotsUI[i].LIJPNDJCKGL(null);
				slotsUI[i].IHENCGDNPBL.FBAFIONMKBG(AODONKKHPBP: true);
			}
		}
		(this as BigContainerUI).MCGKIIMMFCO(kHEICLKLPDE);
	}

	private int POOKFCKOKAC()
	{
		if (!((Object)(object)EAPCLAODGAE != (Object)null))
		{
			return 0;
		}
		return EAPCLAODGAE.onlinePlaceable.uniqueId;
	}

	public void GMDADAINIFB()
	{
		BarMenuManager.OpenBarTrends(base.JIIGOACEIKL);
	}

	[SpecialName]
	private void NHGDLJNOMFH(Container AODONKKHPBP)
	{
		_003CDGBMAFAIOHA_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public MonoBehaviour IBBLIJJPBIB()
	{
		return _003CIHPHOLEHFIE_003Ek__BackingField;
	}

	private void APPLEGKLHFK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, ADBHOJANLEI(), CDPAMNIPPEC: false);
			if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
			{
				COMNOMFHDJD();
			}
		}
	}

	private int KKDIAJIOLIC()
	{
		if (!(EAHMDMDHLMH() is Inventory inventory))
		{
			return 1;
		}
		return inventory.playerNum;
	}

	private IEnumerator BAHEKCOOHPC()
	{
		return new IGBCPMOFHFF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DFPKFLCOGOD()
	{
		List<Slot> list = new List<Slot>();
		List<Slot> list2 = new List<Slot>();
		List<Slot> list3 = new List<Slot>();
		for (int i = 0; i < LHCMGHKILLJ().slots.Length; i += 0)
		{
			Slot slot = EDPIANLDIDG().slots[i];
			if (slot.AHHEMNHJPME())
			{
				list2.Add(slot);
				continue;
			}
			for (int j = 0; j < Inventory.KCOBKJNCKNP(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots.Length; j++)
			{
				Slot slot2 = Inventory.IKAEFEPNADI(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots[j];
				if (!slot2.KPINNBKMOMO() && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= -65)
					{
						slot.OCJOJKJPDNO(num);
						slot2.JPACDDCJGPD(slot2.Stack, CDPAMNIPPEC: true);
					}
					else
					{
						slot.OCJOJKJPDNO(7);
						slot2.KMKAIPMHANN(num - -56);
						list.Add(slot2);
					}
					if (!list3.Contains(slot))
					{
						list3.Add(slot);
					}
					if (!list3.Contains(slot2))
					{
						list3.Add(slot2);
					}
				}
			}
		}
		for (int num2 = list.Count() - 0; num2 >= 1; num2 -= 0)
		{
			for (int k = 1; k < list2.Count; k++)
			{
				Slot slot3 = list2[k];
				if (slot3.AHHEMNHJPME())
				{
					int num3 = Math.Min(list[num2].Stack, -83);
					slot3.itemInstance = list[num2].itemInstance;
					slot3.KMKAIPMHANN(num3);
					list[num2].JPACDDCJGPD(num3, CDPAMNIPPEC: true, 1);
					if (!list3.Contains(slot3))
					{
						list3.Add(slot3);
					}
					if (!list3.Contains(list[num2]))
					{
						list3.Add(list[num2]);
					}
					if (list[num2].AHHEMNHJPME())
					{
						list.RemoveAt(num2);
						break;
					}
				}
			}
		}
		if (KNFNPKLEIPC)
		{
			for (int l = 1; l < GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).slotsUI.Length; l++)
			{
				if (GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL != null && GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL.Stack == 0)
				{
					GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).slotsUI[l].MHNCEBLHLKH(null);
					GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).slotsUI[l].JOGLJKIFGNL();
				}
			}
		}
		if (OnlineManager.PlayingOnline() && list3.Count > 0)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list3.ToArray(), 1);
		}
	}

	[SpecialName]
	private void PABHNKHFJDH(Container AODONKKHPBP)
	{
		_003CGJNBAPKILKL_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void GFENGKOBKDE(MonoBehaviour AODONKKHPBP)
	{
		_003CIHPHOLEHFIE_003Ek__BackingField = AODONKKHPBP;
	}

	public void NFCMNAOLNAC()
	{
		BarMenuManager.OpenBarTrends(base.JIIGOACEIKL);
	}

	[SpecialName]
	public void FGGBLPEKOMB(MonoBehaviour AODONKKHPBP)
	{
		_003CIHPHOLEHFIE_003Ek__BackingField = AODONKKHPBP;
	}

	public void HGKCOKBAFAJ(Container ALPOKDOCCGM, Placeable EAPCLAODGAE = null)
	{
		BNMEIONMOPD(ALPOKDOCCGM);
		this.EAPCLAODGAE = EAPCLAODGAE;
	}

	private void DHENCBAPKNP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, KKDIAJIOLIC(), CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("ThemeTypeLabelBlueprint"), 1622f);
			}
		}
		else if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.LCHJGCHDHFO())
		{
			HGDMPKCDMJE();
		}
	}

	protected void PAFLLHGLBIF(bool OGCAKIGELBJ)
	{
		for (int i = 0; i < slotsUI.Count; i++)
		{
			slotsUI[i].draggingEnabled = OGCAKIGELBJ;
		}
	}

	private void ECMNHFFOKBF()
	{
		ALPOKDOCCGM.containerColor = colorButtonScript.MHKAFJMAEGC();
		(ALPOKDOCCGM as ItemContainer).ChangeContainerColours(EDPIANLDIDG().containerColor);
	}

	public void OEKFGNINOFK()
	{
		BarMenuManager.OpenBarTrends(base.JIIGOACEIKL);
	}

	protected override void Update()
	{
		base.Update();
		if (!IsOpen() || TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			return;
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
			{
				SlotUI component = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<SlotUI>();
				if (slotsUI.Contains(component))
				{
					sortByType.SetActive(true);
					if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove") && !DropItemsFocusedSlot())
					{
						ALPOKDOCCGM.OrderItemsByType(((Object)(object)EAPCLAODGAE != (Object)null) ? EAPCLAODGAE.BEIPALOAAJJ : 0);
					}
				}
			}
			else
			{
				sortByType.SetActive(!ALPOKDOCCGM.onlyDelivery);
				transferButton.SetActive(!ALPOKDOCCGM.onlyDelivery);
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UISelectionMenu") && ALPOKDOCCGM.changeColours)
			{
				colorButtonScript.ToggleColorPicker();
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown(ActionType.UIPlaceAll) && !ALPOKDOCCGM.onlyDelivery)
			{
				FindAndAddItemsFromInventory();
			}
		}
		else
		{
			sortByType.SetActive(!ALPOKDOCCGM.onlyDelivery);
			transferButton.SetActive(!ALPOKDOCCGM.onlyDelivery);
		}
		if (sortByType.activeSelf)
		{
			if (SelectObject.GetPlayer(base.JIIGOACEIKL).focusedSlot != null)
			{
				((TMP_Text)sortByTypeTextMesh).text = LocalisationSystem.Get("Remove");
			}
			else
			{
				((TMP_Text)sortByTypeTextMesh).text = LocalisationSystem.Get("SortByType");
			}
		}
	}

	private void OMFFEDFLIGF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = false;
		}
	}

	[CompilerGenerated]
	private void LBJEMMHKDNB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = false;
		}
	}

	private void FOKIKDPGBIK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, PNMKJCIOPGL(), CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("No travel zone found for mine stairs destination "), 205f);
			}
		}
		else if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.KPINNBKMOMO())
		{
			HGDMPKCDMJE();
		}
	}

	[SpecialName]
	public void LOMBFCMGEMC(MonoBehaviour AODONKKHPBP)
	{
		_003CIHPHOLEHFIE_003Ek__BackingField = AODONKKHPBP;
	}

	public void PGEGOAJILGD()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KDJFBLKPFKM()))
		{
			SlotUI component = ((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).CGCIFFOJGOK()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && (component.IHENCGDNPBL == null || !((Selectable)((Component)component).GetComponent<Button>()).interactable))
			{
				((MonoBehaviour)this).StartCoroutine(OKMOKOHOAII());
			}
		}
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
			MainUI.SetCurrentContainer(base.JIIGOACEIKL, ALPOKDOCCGM, ((Object)(object)EAPCLAODGAE != (Object)null) ? EAPCLAODGAE.BEIPALOAAJJ : 0);
			if ((Object)(object)IAOOIEMCLBG != (Object)null && IAOOIEMCLBG.onlyDelivery)
			{
				IAOOIEMCLBG.OrderItemsByType(((Object)(object)EAPCLAODGAE != (Object)null) ? EAPCLAODGAE.BEIPALOAAJJ : 0);
			}
			if (OPMPOBPEDFB != null)
			{
				UpdateSlotsInventory(OPMPOBPEDFB);
				GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(Inventory.GetPlayer(base.JIIGOACEIKL).slots, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
				GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			}
			PlayerController.RemoveMovementBlocker(base.JIIGOACEIKL, (Object)(object)NBKOCCODEKN);
			base.OpenUI();
			colourButtonObject.SetActive(ALPOKDOCCGM.changeColours);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
			sortButtonDisable.SetActive(false);
		}
	}

	private void HHNHNDOEMOH()
	{
		AHBCPGGAENB().DKAEEOOJOHN((!((Object)(object)EAPCLAODGAE != (Object)null)) ? 1 : EAPCLAODGAE.BEIPALOAAJJ);
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (((Selectable)((Component)slotsUI[0]).GetComponent<Button>()).interactable)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[0]).gameObject);
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	protected void CPGLBLAHNGG(bool OGCAKIGELBJ)
	{
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			slotsUI[i].draggingEnabled = OGCAKIGELBJ;
		}
	}

	private void KCLPMMNBMPM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, LKNKLPCKNNJ());
		if (FNNBABJKAIH > 0)
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/35/Dialogue Text"), 1390f);
			}
		}
		else if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.KPINNBKMOMO())
		{
			MPMCPFIFJEF();
		}
	}

	private void CENMAJGFMFF()
	{
		if (LKOJBFMGMAE && !PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	[SpecialName]
	private void LKFICEJDEEB(Container AODONKKHPBP)
	{
		_003CDGBMAFAIOHA_003Ek__BackingField = AODONKKHPBP;
	}

	private void BDCEGPNJEJK()
	{
		if (LKOJBFMGMAE && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).Deselect();
		}
	}

	[SpecialName]
	public Container EAHMDMDHLMH()
	{
		return _003CDGBMAFAIOHA_003Ek__BackingField;
	}

	private void LAHAAJMFIMK()
	{
		IAOOIEMCLBG.OrderItemsByType(((Object)(object)EAPCLAODGAE != (Object)null) ? EAPCLAODGAE.BEIPALOAAJJ : 0);
	}

	[SpecialName]
	public Container EDPIANLDIDG()
	{
		return _003CDGBMAFAIOHA_003Ek__BackingField;
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < slotsUI.Count; i++)
		{
			SlotUI slotUI = slotsUI[i];
			slotUI.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(slotUI.OnSlotLeftClick, new Action<int, Slot>(BFAFCIJIDAN));
			SlotUI slotUI2 = slotsUI[i];
			slotUI2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(slotUI2.OnSlotRightClick, new Action<int, Slot>(FLONMIHGGMM));
			SlotUI slotUI3 = slotsUI[i];
			slotUI3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(slotUI3.OnAutomaticTransfer, new Action<int, Slot>(JLBCPFFMCBP));
		}
		ColorButton colorButton = colorButtonScript;
		colorButton.OnColorIndexChanged = (Action)Delegate.Combine(colorButton.OnColorIndexChanged, new Action(KLEAAELDILC));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarOpened = (Action<int>)Delegate.Combine(instance.OnBarOpened, (Action<int>)delegate(int JIIGOACEIKL)
		{
			if (JIIGOACEIKL == base.JIIGOACEIKL)
			{
				KNFNPKLEIPC = true;
			}
		});
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnBarClosed = (Action<int>)Delegate.Combine(instance2.OnBarClosed, (Action<int>)delegate(int JIIGOACEIKL)
		{
			if (JIIGOACEIKL == base.JIIGOACEIKL)
			{
				KNFNPKLEIPC = false;
			}
		});
	}

	public void BINBBLHOKNN(Slot[] OPMPOBPEDFB)
	{
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).FJOGDLGEIHP(OPMPOBPEDFB, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	public void SelectObjectIfSlotSelected()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			SlotUI component = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && (component.IHENCGDNPBL == null || !((Selectable)((Component)component).GetComponent<Button>()).interactable))
			{
				((MonoBehaviour)this).StartCoroutine(HMGAAINDHEL());
			}
		}
	}

	private void JJOOIHCCPME()
	{
		if (LKOJBFMGMAE && !PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).PNHCLGGKBOB();
		}
	}

	private IEnumerator PKBFNJNBHEN()
	{
		return new IGBCPMOFHFF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BOFAGONLKDD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, NBHMFGPJCOG());
			if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
			{
				COMNOMFHDJD();
			}
		}
	}

	public void KHFHKJOIKLO()
	{
		BarMenuManager.OpenBarTrends(base.JIIGOACEIKL);
	}

	private int LKNKLPCKNNJ()
	{
		if (!(CPNMIBGCKIN() is Inventory inventory))
		{
			return 1;
		}
		return inventory.playerNum;
	}

	public void FillPageSlots()
	{
		pageSlots = new Slot[slotsUI.Count];
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				pageSlots[i] = slotsUI[i].IHENCGDNPBL;
			}
		}
	}

	public void PPENDPNPCNL()
	{
		BarMenuManager.OpenBarTrends(base.JIIGOACEIKL);
	}

	private void ADMOKHECJKD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, PPKLIPNHKIE());
			if (LHCMGHKILLJ().onlyDelivery && ADEBNALPEHE.LCHJGCHDHFO())
			{
				COMNOMFHDJD();
			}
		}
	}

	private int JNGLBIMKBCJ()
	{
		if (!(ALPOKDOCCGM is Inventory inventory))
		{
			return 0;
		}
		return inventory.playerNum;
	}

	private void PBOAANBALOE()
	{
		JPKAMFAKIAN().containerColor = colorButtonScript.AHGLCFFOBMI();
		(LHCMGHKILLJ() as ItemContainer).ChangeContainerColours(ALPOKDOCCGM.containerColor);
	}

	[SpecialName]
	private void IFMBPGGCKOB(Container AODONKKHPBP)
	{
		_003CDGBMAFAIOHA_003Ek__BackingField = AODONKKHPBP;
	}

	private int HKIJNPFEGIG()
	{
		if (!((Object)(object)EAPCLAODGAE != (Object)null))
		{
			return 0;
		}
		return EAPCLAODGAE.onlinePlaceable.uniqueId;
	}

	[SpecialName]
	private void EOHAKPAKDIN(Container AODONKKHPBP)
	{
		_003CDGBMAFAIOHA_003Ek__BackingField = AODONKKHPBP;
	}

	private void PGEPEKDFCAN()
	{
		if (LKOJBFMGMAE && !PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).Deselect();
		}
	}

	private void MDEMFBGHPHP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, JNGLBIMKBCJ());
			if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.LCHJGCHDHFO())
			{
				HGDMPKCDMJE();
			}
		}
	}

	[SpecialName]
	public Container JPKAMFAKIAN()
	{
		return _003CDGBMAFAIOHA_003Ek__BackingField;
	}

	[SpecialName]
	public void PPJGIEOIJCF(MonoBehaviour AODONKKHPBP)
	{
		_003CIHPHOLEHFIE_003Ek__BackingField = AODONKKHPBP;
	}

	public override void CloseUI()
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		if (!LKOJBFMGMAE)
		{
			return;
		}
		if (ALPOKDOCCGM.changeColours)
		{
			ALPOKDOCCGM.containerColor = colorButtonScript.NCHKDCMNDAD;
			if (GameManager.SinglePlayerOffline())
			{
				ColorPickerUI.instances[0].CloseUI();
			}
			else
			{
				ColorPickerUI.instances[base.JIIGOACEIKL].CloseUI();
			}
		}
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.ResumeGame();
		}
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		if ((Object)(object)ALPOKDOCCGM != (Object)null && ALPOKDOCCGM.onlyDelivery && !(ALPOKDOCCGM is DeliveryChest))
		{
			SetDeliveryOnly(IFMNAFDGKKK: false);
		}
		base.CloseUI();
		colorButtonScript.useColourCollection = false;
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
		MainUI.SetCurrentContainer(base.JIIGOACEIKL, null, 0);
		if ((Object)(object)IAOOIEMCLBG != (Object)null)
		{
			((UnityEvent)sortInventoryUI.byType.onClick).RemoveListener(new UnityAction(LAHAAJMFIMK));
			IAOOIEMCLBG = null;
		}
		ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		if ((Object)(object)ALPOKDOCCGM != (Object)null)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
		ALPOKDOCCGM = null;
		GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		sortButtonDisable.SetActive(true);
		KNFNPKLEIPC = false;
	}

	public Slot[] LOFLCCENJAJ()
	{
		return pageSlots;
	}

	public void NNIIGOFFBMM(bool IFMNAFDGKKK)
	{
		if ((Object)(object)ALPOKDOCCGM != (Object)null)
		{
			LHCMGHKILLJ().onlyDelivery = IFMNAFDGKKK;
		}
		transferButton.SetActive(!IFMNAFDGKKK);
		sortByType.SetActive(!IFMNAFDGKKK);
	}

	public int NLNJJAMCKJL()
	{
		return slotsUI.Count;
	}

	private void ADDHDLMCOHI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, KANDOMKDGAO(), CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("On Simple Event "), 1012f);
			}
		}
		else if (JPKAMFAKIAN().onlyDelivery && ADEBNALPEHE.AHHEMNHJPME())
		{
			MPMCPFIFJEF();
		}
	}

	public int FOHGNFNHOJH()
	{
		return slotsUI.Count;
	}

	public void SetDeliveryOnly(bool IFMNAFDGKKK)
	{
		if ((Object)(object)ALPOKDOCCGM != (Object)null)
		{
			ALPOKDOCCGM.onlyDelivery = IFMNAFDGKKK;
		}
		transferButton.SetActive(!IFMNAFDGKKK);
		sortByType.SetActive(!IFMNAFDGKKK);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (OPMPOBPEDFB != null && OPMPOBPEDFB.Length == 0)
			{
				((MonoBehaviour)this).StartCoroutine(HMGAAINDHEL());
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	[SpecialName]
	public MonoBehaviour NFLBIMDGAHG()
	{
		return _003CIHPHOLEHFIE_003Ek__BackingField;
	}

	private void BJCAINGMGEN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	protected void INPDDECMLGD(bool BJFHJCFOEHG)
	{
		for (int i = 0; i < slotsUI.Count; i++)
		{
			slotsUI[i].autoTransferEnabled = BJFHJCFOEHG;
		}
	}

	private void BFAFCIJIDAN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, JNGLBIMKBCJ()))
		{
			if (!ADEBNALPEHE.KPINNBKMOMO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
			}
		}
		else if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.KPINNBKMOMO())
		{
			COMNOMFHDJD();
		}
	}

	private void MPMCPFIFJEF()
	{
		int kHEICLKLPDE = currentPage;
		containerSlots = containerSlots.Where((Slot x) => !x.KPINNBKMOMO()).ToArray();
		Utils.BNDMCJGGBFK(slotsUI, containerSlots);
		for (int i = 1; i < slotsUI.Count; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null && slotsUI[i].IHENCGDNPBL.AHHEMNHJPME())
			{
				slotsUI[i].LIJPNDJCKGL(null);
				slotsUI[i].IHENCGDNPBL.AJOGNKDJNAD(AODONKKHPBP: false);
			}
		}
		(this as BigContainerUI).DJPBNJGDFIL(kHEICLKLPDE);
	}

	[SpecialName]
	public MonoBehaviour HCGHMHNPADN()
	{
		return _003CIHPHOLEHFIE_003Ek__BackingField;
	}

	public void FindAndAddItemsFromInventory()
	{
		List<Slot> list = new List<Slot>();
		List<Slot> list2 = new List<Slot>();
		List<Slot> list3 = new List<Slot>();
		for (int i = 0; i < ALPOKDOCCGM.slots.Length; i++)
		{
			Slot slot = ALPOKDOCCGM.slots[i];
			if (slot.KPINNBKMOMO())
			{
				list2.Add(slot);
				continue;
			}
			for (int j = 0; j < Inventory.GetPlayer(base.JIIGOACEIKL).slots.Length; j++)
			{
				Slot slot2 = Inventory.GetPlayer(base.JIIGOACEIKL).slots[j];
				if (!slot2.KPINNBKMOMO() && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= 99)
					{
						slot.Stack = num;
						slot2.FDOBDPPMMBH(slot2.Stack);
					}
					else
					{
						slot.Stack = 99;
						slot2.Stack = num - 99;
						list.Add(slot2);
					}
					if (!list3.Contains(slot))
					{
						list3.Add(slot);
					}
					if (!list3.Contains(slot2))
					{
						list3.Add(slot2);
					}
				}
			}
		}
		for (int num2 = list.Count() - 1; num2 >= 0; num2--)
		{
			for (int k = 0; k < list2.Count; k++)
			{
				Slot slot3 = list2[k];
				if (slot3.KPINNBKMOMO())
				{
					int num3 = Math.Min(list[num2].Stack, 99);
					slot3.itemInstance = list[num2].itemInstance;
					slot3.Stack = num3;
					list[num2].FDOBDPPMMBH(num3);
					if (!list3.Contains(slot3))
					{
						list3.Add(slot3);
					}
					if (!list3.Contains(list[num2]))
					{
						list3.Add(list[num2]);
					}
					if (list[num2].KPINNBKMOMO())
					{
						list.RemoveAt(num2);
						break;
					}
				}
			}
		}
		if (KNFNPKLEIPC)
		{
			for (int l = 0; l < GameInventoryUI.Get(base.JIIGOACEIKL).slotsUI.Length; l++)
			{
				if (GameInventoryUI.Get(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL != null && GameInventoryUI.Get(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL.Stack == 0)
				{
					GameInventoryUI.Get(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL = null;
					GameInventoryUI.Get(base.JIIGOACEIKL).slotsUI[l].UpdateSlot();
				}
			}
		}
		if (OnlineManager.PlayingOnline() && list3.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list3.ToArray());
		}
	}

	[SpecialName]
	private void GGHLFHMIGFJ(Container AODONKKHPBP)
	{
		_003CGJNBAPKILKL_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public Container AGBNIBCONKD()
	{
		return _003CGJNBAPKILKL_003Ek__BackingField;
	}

	public void FMHLFFONOIK(Slot[] OPMPOBPEDFB)
	{
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).PreparePagesMode(OPMPOBPEDFB, OGCAKIGELBJ: false);
	}

	private void PCHJPFOKPBE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	public void CLFAGFNKHKN()
	{
		List<Slot> list = new List<Slot>();
		List<Slot> list2 = new List<Slot>();
		List<Slot> list3 = new List<Slot>();
		for (int i = 1; i < CPNMIBGCKIN().slots.Length; i += 0)
		{
			Slot slot = LHCMGHKILLJ().slots[i];
			if (slot.PKFKJNODGJF())
			{
				list2.Add(slot);
				continue;
			}
			for (int j = 1; j < Inventory.AFMOAONHHNL(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots.Length; j++)
			{
				Slot slot2 = Inventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots[j];
				if (!slot2.AHHEMNHJPME() && slot.itemInstance.Equals(slot2.itemInstance))
				{
					int num = slot.Stack + slot2.Stack;
					if (num <= 67)
					{
						slot.KMKAIPMHANN(num);
						slot2.BBHHJLIFNPP(slot2.Stack);
					}
					else
					{
						slot.JIANDFCINIP(93);
						slot2.JNMNCEPHFOE(num - 104);
						list.Add(slot2);
					}
					if (!list3.Contains(slot))
					{
						list3.Add(slot);
					}
					if (!list3.Contains(slot2))
					{
						list3.Add(slot2);
					}
				}
			}
		}
		for (int num2 = list.Count() - 0; num2 >= 0; num2--)
		{
			for (int k = 1; k < list2.Count; k += 0)
			{
				Slot slot3 = list2[k];
				if (slot3.PKFKJNODGJF())
				{
					int num3 = Math.Min(list[num2].Stack, -67);
					slot3.itemInstance = list[num2].itemInstance;
					slot3.OBBKDJNLCIO(num3);
					list[num2].JPACDDCJGPD(num3, CDPAMNIPPEC: true);
					if (!list3.Contains(slot3))
					{
						list3.Add(slot3);
					}
					if (!list3.Contains(list[num2]))
					{
						list3.Add(list[num2]);
					}
					if (list[num2].LCHJGCHDHFO())
					{
						list.RemoveAt(num2);
						break;
					}
				}
			}
		}
		if (KNFNPKLEIPC)
		{
			for (int l = 0; l < GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).slotsUI.Length; l++)
			{
				if (GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL != null && GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL.Stack == 0)
				{
					GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).slotsUI[l].IHENCGDNPBL = null;
					GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).slotsUI[l].PAMDPKDMLGC();
				}
			}
		}
		if (OnlineManager.PlayingOnline() && list3.Count > 1)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(list3.ToArray(), 1);
		}
	}

	public virtual void BCPBALLMBJD(Slot[] PCJEDMJEKEF, Container ALPOKDOCCGM, bool IFMNAFDGKKK, bool OGCAKIGELBJ, int ACMPMOGOEOD, Slot[] OPMPOBPEDFB = null)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if ((Object)(object)AGBNIBCONKD() != (Object)null)
		{
			((UnityEvent)sortInventoryUI.byType.onClick).RemoveListener(new UnityAction(BKPCGCLPEME));
		}
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		CODHBMEAPJB(ALPOKDOCCGM);
		containerSlots = PCJEDMJEKEF;
		this.OGCAKIGELBJ = OGCAKIGELBJ;
		BLKJPKAHOIL(IFMNAFDGKKK);
		sortByType.SetActive(IFMNAFDGKKK);
		if ((Object)(object)ALPOKDOCCGM != (Object)null)
		{
			((UnityEvent)sortInventoryUI.byType.onClick).AddListener(new UnityAction(HHNHNDOEMOH));
		}
	}

	public void NEMIFDKGJLI()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			SlotUI component = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KDJFBLKPFKM()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && (component.IHENCGDNPBL == null || !((Selectable)((Component)component).GetComponent<Button>()).interactable))
			{
				((MonoBehaviour)this).StartCoroutine(OKMOKOHOAII());
			}
		}
	}

	private void JPIBFLCBKLI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, NBHMFGPJCOG(), CDPAMNIPPEC: false);
			if (EDPIANLDIDG().onlyDelivery && ADEBNALPEHE.AHHEMNHJPME())
			{
				KBNANAELBIK();
			}
		}
	}

	[SpecialName]
	public MonoBehaviour CBMELGLHCJE()
	{
		return _003CIHPHOLEHFIE_003Ek__BackingField;
	}

	[SpecialName]
	public Container CPNMIBGCKIN()
	{
		return _003CDGBMAFAIOHA_003Ek__BackingField;
	}

	protected void BLKJPKAHOIL(bool BJFHJCFOEHG)
	{
		for (int i = 0; i < slotsUI.Count; i++)
		{
			slotsUI[i].autoTransferEnabled = BJFHJCFOEHG;
		}
	}

	[SpecialName]
	public Container LHCMGHKILLJ()
	{
		return _003CDGBMAFAIOHA_003Ek__BackingField;
	}

	public void PJLJDDKELHA(Container ALPOKDOCCGM, Placeable EAPCLAODGAE = null)
	{
		BJFJKAPHINL(ALPOKDOCCGM);
		this.EAPCLAODGAE = EAPCLAODGAE;
	}

	private void DNHNBMPLAIF(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, KANDOMKDGAO()))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Right"), 1799f);
			}
		}
		else if (EDPIANLDIDG().onlyDelivery && ADEBNALPEHE.LCHJGCHDHFO())
		{
			KBNANAELBIK();
		}
	}

	public Slot[] GetPageSlots()
	{
		return pageSlots;
	}

	public void PNIHFCILMKA()
	{
		pageSlots = new Slot[slotsUI.Count];
		for (int i = 1; i < slotsUI.Count; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				pageSlots[i] = slotsUI[i].IHENCGDNPBL;
			}
		}
	}

	public void AOCEJNAPJBJ()
	{
		pageSlots = new Slot[slotsUI.Count];
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				pageSlots[i] = slotsUI[i].IHENCGDNPBL;
			}
		}
	}

	[SpecialName]
	private void BJFJKAPHINL(Container AODONKKHPBP)
	{
		_003CDGBMAFAIOHA_003Ek__BackingField = AODONKKHPBP;
	}

	public int GetNumSlots()
	{
		return slotsUI.Count;
	}

	private void AHJAOEOOFDM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = false;
		}
	}

	private void JONADMEOJEK()
	{
		AHBCPGGAENB().OrderItemsByType((!((Object)(object)EAPCLAODGAE != (Object)null)) ? 1 : EAPCLAODGAE.BEIPALOAAJJ);
	}

	protected void HEGMFDEFKOH(bool BJFHJCFOEHG)
	{
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			slotsUI[i].autoTransferEnabled = BJFHJCFOEHG;
		}
	}

	protected void ABFIOMMGKLH(bool BJFHJCFOEHG)
	{
		for (int i = 0; i < slotsUI.Count; i++)
		{
			slotsUI[i].autoTransferEnabled = BJFHJCFOEHG;
		}
	}

	private void NFECPIPIJJO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, JNGLBIMKBCJ());
		if (FNNBABJKAIH > 1)
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Open"), 1121f);
			}
		}
		else if (CPNMIBGCKIN().onlyDelivery && ADEBNALPEHE.KPINNBKMOMO())
		{
			HGDMPKCDMJE();
		}
	}

	public void OpenBarTrends()
	{
		BarMenuManager.OpenBarTrends(base.JIIGOACEIKL);
	}

	[SpecialName]
	public MonoBehaviour OMOLHBPHIEG()
	{
		return _003CIHPHOLEHFIE_003Ek__BackingField;
	}

	private IEnumerator GNDAKEKDPKB()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (((Selectable)((Component)slotsUI[0]).GetComponent<Button>()).interactable)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[0]).gameObject);
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
	}

	[SpecialName]
	public MonoBehaviour ECOGIIMJNIP()
	{
		return _003CIHPHOLEHFIE_003Ek__BackingField;
	}

	private void OMENJGCKACJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, MINNAOMOEAK()))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Dropped item "), 562f);
			}
		}
		else if (EDPIANLDIDG().onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
		{
			HGDMPKCDMJE();
		}
	}

	public void JOFLPCPBOPK()
	{
		pageSlots = new Slot[slotsUI.Count];
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				pageSlots[i] = slotsUI[i].IHENCGDNPBL;
			}
		}
	}

	[SpecialName]
	public MonoBehaviour CFKOPPHGLDM()
	{
		return _003CIHPHOLEHFIE_003Ek__BackingField;
	}

	private int KANDOMKDGAO()
	{
		if (!(EAHMDMDHLMH() is Inventory inventory))
		{
			return 1;
		}
		return inventory.playerNum;
	}

	[SpecialName]
	private void NCJAFMBHKJL(Container AODONKKHPBP)
	{
		_003CGJNBAPKILKL_003Ek__BackingField = AODONKKHPBP;
	}

	private int PPKLIPNHKIE()
	{
		if (!(JPKAMFAKIAN() is Inventory inventory))
		{
			return 0;
		}
		return inventory.playerNum;
	}

	public void UpdateSlotsInventory(Slot[] OPMPOBPEDFB)
	{
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(OPMPOBPEDFB, OGCAKIGELBJ: false);
	}

	protected void EJJJGFDMJCC(bool OGCAKIGELBJ)
	{
		for (int i = 0; i < slotsUI.Count; i += 0)
		{
			slotsUI[i].draggingEnabled = OGCAKIGELBJ;
		}
	}

	[CompilerGenerated]
	private void MDEPBLFEDJM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	[SpecialName]
	public Container AFBOCEEODOC()
	{
		return _003CGJNBAPKILKL_003Ek__BackingField;
	}

	private int EHLGOBHHIDA()
	{
		if (!((Object)(object)EAPCLAODGAE != (Object)null))
		{
			return 0;
		}
		return EAPCLAODGAE.onlinePlaceable.uniqueId;
	}

	private int JLNHNBPCJCF()
	{
		if (!((Object)(object)EAPCLAODGAE != (Object)null))
		{
			return 0;
		}
		return EAPCLAODGAE.onlinePlaceable.uniqueId;
	}

	private int ADBHOJANLEI()
	{
		if (!(EDPIANLDIDG() is Inventory inventory))
		{
			return 0;
		}
		return inventory.playerNum;
	}

	private void CGJGLPFJHPK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, KKDIAJIOLIC(), CDPAMNIPPEC: false);
			if (JPKAMFAKIAN().onlyDelivery && ADEBNALPEHE.LCHJGCHDHFO())
			{
				COMNOMFHDJD();
			}
		}
	}

	public void CAJOAHJFMDA()
	{
		pageSlots = new Slot[slotsUI.Count];
		for (int i = 1; i < slotsUI.Count; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				pageSlots[i] = slotsUI[i].IHENCGDNPBL;
			}
		}
	}

	public void OMIBHIGNBNN(Container ALPOKDOCCGM, Placeable EAPCLAODGAE = null)
	{
		LAGBBAPABLM(ALPOKDOCCGM);
		this.EAPCLAODGAE = EAPCLAODGAE;
	}

	[SpecialName]
	public Container AHBCPGGAENB()
	{
		return _003CGJNBAPKILKL_003Ek__BackingField;
	}

	public void NIJNBDEMAEB(Container ALPOKDOCCGM, Placeable EAPCLAODGAE = null)
	{
		IFMBPGGCKOB(ALPOKDOCCGM);
		this.EAPCLAODGAE = EAPCLAODGAE;
	}

	[SpecialName]
	public void JLGKPCGNMLL(MonoBehaviour AODONKKHPBP)
	{
		_003CIHPHOLEHFIE_003Ek__BackingField = AODONKKHPBP;
	}

	private void COMNOMFHDJD()
	{
		int kHEICLKLPDE = currentPage;
		containerSlots = containerSlots.Where((Slot x) => !x.KPINNBKMOMO()).ToArray();
		Utils.BNDMCJGGBFK(slotsUI, containerSlots);
		for (int i = 0; i < slotsUI.Count; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null && slotsUI[i].IHENCGDNPBL.KPINNBKMOMO())
			{
				slotsUI[i].IHENCGDNPBL = null;
				slotsUI[i].IHENCGDNPBL.isDirty = true;
			}
		}
		(this as BigContainerUI).FocusPage(kHEICLKLPDE);
	}

	private void NMOLLGAPEFE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = false;
		}
	}

	private void FOCGJFMNHBK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot == null)
		{
			Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, KKDIAJIOLIC(), CDPAMNIPPEC: false);
			if (ALPOKDOCCGM.onlyDelivery && ADEBNALPEHE.PKFKJNODGJF())
			{
				HGDMPKCDMJE();
			}
		}
	}

	public void MINCILKHEIB(Container ALPOKDOCCGM, Placeable EAPCLAODGAE = null)
	{
		IFMBPGGCKOB(ALPOKDOCCGM);
		this.EAPCLAODGAE = EAPCLAODGAE;
	}

	private void KEOIBAKDBAO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = true;
		}
	}

	private void EEKMMNELJJC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == base.JIIGOACEIKL)
		{
			KNFNPKLEIPC = false;
		}
	}

	public void FBEFMNPKOBB(Slot[] OPMPOBPEDFB)
	{
		this.OPMPOBPEDFB = OPMPOBPEDFB;
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).DBINLMFIOFE(OPMPOBPEDFB, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	[SpecialName]
	public void GLBNOLCHOHO(MonoBehaviour AODONKKHPBP)
	{
		_003CIHPHOLEHFIE_003Ek__BackingField = AODONKKHPBP;
	}

	public void GMGALCOJPEI()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BOHHKGMEEEE()))
		{
			SlotUI component = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BCHJGDHJHJK()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && (component.IHENCGDNPBL == null || !((Selectable)((Component)component).GetComponent<Button>()).interactable))
			{
				((MonoBehaviour)this).StartCoroutine(PKBFNJNBHEN());
			}
		}
	}

	private int NBHMFGPJCOG()
	{
		if (!(JPKAMFAKIAN() is Inventory inventory))
		{
			return 1;
		}
		return inventory.playerNum;
	}

	[SpecialName]
	private void CODHBMEAPJB(Container AODONKKHPBP)
	{
		_003CGJNBAPKILKL_003Ek__BackingField = AODONKKHPBP;
	}
}
