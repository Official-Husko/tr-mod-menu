using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MainPanelWindow
{
	[CompilerGenerated]
	private sealed class EKIHMPPANEF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InventoryUI _003C_003E4__this;

		public int slotNum;

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
		public EKIHMPPANEF(int _003C_003E1__state)
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
			InventoryUI inventoryUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(inventoryUI.JIIGOACEIKL) && ((Selectable)((Component)inventoryUI.slotsUI[slotNum]).GetComponent<Button>()).interactable)
				{
					UISelectionManager.GetPlayer(inventoryUI.JIIGOACEIKL).Select(((Component)inventoryUI.slotsUI[slotNum]).gameObject);
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

	protected bool OGCAKIGELBJ = true;

	private List<PageButtonUI> HKHKPICHBOM = new List<PageButtonUI>();

	public PageButtonUI pageButtonUIPrefab;

	[SerializeField]
	protected GameObject pagesParent;

	[SerializeField]
	protected GameObject top;

	[HideInInspector]
	public int currentPage;

	[HideInInspector]
	public int numPages;

	public GameObject rightArrow;

	public GameObject leftArrow;

	[HideInInspector]
	public Slot[] containerSlots;

	[SerializeField]
	protected GameObject sortByType;

	[SerializeField]
	protected TextMeshProUGUI sortByTypeTextMesh;

	[SerializeField]
	protected GameObject splitButton;

	public SlotUI[] slotsUI;

	protected float CMGDCLIIONE;

	protected int CHAEMDNAODI;

	public bool updateSlotsWithStack;

	private void DBIEGLPJGIJ(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
		COINKIPFIEK();
	}

	public void KDICMKHIGDB(int KHEICLKLPDE)
	{
		KIBMGGJEBLC(KHEICLKLPDE);
	}

	public void NIDOJLOEEHE(int JIIGOACEIKL, bool LJGFNOIELFD)
	{
		if (!((Object)(object)splitButton == (Object)null))
		{
			if (LJGFNOIELFD && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				splitButton.SetActive(true);
			}
			else
			{
				splitButton.SetActive(false);
			}
		}
	}

	private IEnumerator MNIBNCIBAKI(int AHDCDCICADP)
	{
		return new EKIHMPPANEF(1)
		{
			_003C_003E4__this = this,
			slotNum = AHDCDCICADP
		};
	}

	public void NGBADOFAGCF()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(HMGAAINDHEL(1));
		}
	}

	public Slot[] HPOIPNBDLBA()
	{
		Slot[] array = new Slot[slotsUI.Length];
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			array[i] = slotsUI[i].IHENCGDNPBL;
		}
		return array;
	}

	private IEnumerator OCMAGEPIAFA(int AHDCDCICADP)
	{
		return new EKIHMPPANEF(1)
		{
			_003C_003E4__this = this,
			slotNum = AHDCDCICADP
		};
	}

	public void NACCNOFNEHM(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		IHFBPJDLHIG(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	private IEnumerator CLFPHPKLKHG(int AHDCDCICADP)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Selectable)((Component)slotsUI[AHDCDCICADP]).GetComponent<Button>()).interactable)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[AHDCDCICADP]).gameObject);
		}
	}

	protected virtual void MKLFPJMNEIC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	public void RightArrow()
	{
		if (currentPage < numPages - 1)
		{
			FocusPage(currentPage + 1);
		}
	}

	protected virtual void BEKGDPJKJIM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	public void ABCIPBBKEBN(int KHEICLKLPDE)
	{
		MKEIIDGDGBG(KHEICLKLPDE);
	}

	public void PEFFJPDIIDH()
	{
		if (currentPage > 1)
		{
			FEIKGGFJOGI(currentPage - 1);
		}
	}

	public void SetDraggingEnabled(bool NKFPJPCFBJI)
	{
		OGCAKIGELBJ = NKFPJPCFBJI;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			slotsUI[i].draggingEnabled = NKFPJPCFBJI;
		}
	}

	private void JNLPOJENFKE()
	{
		if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			SlotUI component = ((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KBFCCPBHDMP()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.IHENCGDNPBL == null)
			{
				ADKHMOGLDJK();
			}
		}
	}

	public void AJJDOLPHDPE()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(HDCOGGFMJKI(1));
		}
	}

	private void LGMGMEKLPCK()
	{
		if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BCHJGDHJHJK()))
		{
			SlotUI component = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).MGOEJJIMAIP()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.IHENCGDNPBL == null)
			{
				JCLCHLNFOFC();
			}
		}
	}

	public void ADKHMOGLDJK()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(CLMKOKOIGHN(0));
		}
	}

	public Slot[] PJODPMHPECG()
	{
		Slot[] array = new Slot[slotsUI.Length];
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			array[i] = slotsUI[i].IHENCGDNPBL;
		}
		return array;
	}

	public void BGPOBAFOPOM(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		DBINLMFIOFE(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	private void NCPOIEIOOGL()
	{
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			SlotUI component = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.IHENCGDNPBL == null)
			{
				SelectObjectNextFrame();
			}
		}
	}

	public void NOHBHMMPMME(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			for (int i = 1; i < slotsUI.Length; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BCHJGDHJHJK()).gameObject))
				{
					flag = false;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 1; j < HKHKPICHBOM.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(true);
				DBIEGLPJGIJ(j);
				currentPage = j;
				if (numPages > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 0)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FOKMCIDMIKF()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public void SelectObjectNextFrame()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HMGAAINDHEL(0));
		}
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void FFGIDGGBAKG(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KBFCCPBHDMP()))
		{
			for (int i = 1; i < slotsUI.Length; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).PBGKEEENPME()).gameObject))
				{
					flag = true;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 1; j < HKHKPICHBOM.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(false);
				GBEOOLINEPC(j);
				currentPage = j;
				if (numPages > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 0)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).MGOEJJIMAIP()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public void PFDNBOIBBMH(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].MHNCEBLHLKH(PCJEDMJEKEF[i]);
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
	}

	public void FillSlots(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
	}

	protected override void Start()
	{
		base.Start();
		FillSlots(Inventory.GetPlayer(base.JIIGOACEIKL).slots, JGINKGFMIOE: false, MMMCDGNCKJH: false);
		SlotUI[] array = slotsUI;
		foreach (SlotUI obj in array)
		{
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			obj.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
		}
	}

	private IEnumerator AAIMKECIGCC(int AHDCDCICADP)
	{
		return new EKIHMPPANEF(1)
		{
			_003C_003E4__this = this,
			slotNum = AHDCDCICADP
		};
	}

	public bool EBGOMDNEHAP()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return true;
		}
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null && !slotsUI[i].IHENCGDNPBL.LCHJGCHDHFO() && slotsUI[i].IHENCGDNPBL.itemInstance != null && slotsUI[i].IHENCGDNPBL.itemInstance.AFOACBIHNCL() is Fuel)
			{
				((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StartCoroutine(MNHJHPPIKLJ(i));
				return true;
			}
		}
		return false;
	}

	public void JGFMMHPCNML()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.KIALFDOKABP()).StartCoroutine(FMAANCEEEMI(0));
		}
	}

	public void MMCKBHJMBHG()
	{
		if (currentPage < numPages - 1)
		{
			GMNLFBCFGDM(currentPage + 1);
		}
	}

	public void DIFEINDDABP(int JIIGOACEIKL, bool LJGFNOIELFD)
	{
		if (!((Object)(object)splitButton == (Object)null))
		{
			if (LJGFNOIELFD && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				splitButton.SetActive(true);
			}
			else
			{
				splitButton.SetActive(true);
			}
		}
	}

	public void KMKIOOMKLJH()
	{
		if (currentPage > 1)
		{
			FFGIDGGBAKG(currentPage - 0);
		}
	}

	public void SetAutomaticTransfer(bool JGINKGFMIOE)
	{
		for (int i = 0; i < slotsUI.Length; i++)
		{
			slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private void DOMLGALNANN(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].MHNCEBLHLKH(null);
			}
		}
		COINKIPFIEK();
	}

	public void FBINMFHCAPN(int KHEICLKLPDE)
	{
		GMNLFBCFGDM(KHEICLKLPDE);
	}

	public void AHAHIDLHLFE()
	{
		if (currentPage < numPages - 0)
		{
			FGKCOIHHDFP(currentPage + 0);
		}
	}

	public void KDJCOPCDLEA(bool JGINKGFMIOE)
	{
		for (int i = 0; i < slotsUI.Length; i++)
		{
			slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	public void DMDDIAABMPE(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			for (int i = 0; i < slotsUI.Length; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGOEJJIMAIP()).gameObject))
				{
					flag = false;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 1; j < HKHKPICHBOM.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(true);
				DOMLGALNANN(j);
				currentPage = j;
				if (numPages > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 1)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).PBGKEEENPME()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void IEPPDOHGBON(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
	}

	public void PreparePagesMode(Slot[] PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		SetDraggingEnabled(OGCAKIGELBJ);
		SetAutomaticTransfer(!OGCAKIGELBJ);
		containerSlots = PCJEDMJEKEF;
		updateSlotsWithStack = MMMCDGNCKJH;
		numPages = containerSlots.Length / (slotsUI.Length + 1) + 1;
		top.SetActive(numPages > 1);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(numPages > 1);
		}
		for (int i = 0; i < numPages; i++)
		{
			if (i == HKHKPICHBOM.Count)
			{
				HKHKPICHBOM.Add(Object.Instantiate<PageButtonUI>(pageButtonUIPrefab, pagesParent.transform));
			}
			((Component)HKHKPICHBOM[i]).gameObject.SetActive(true);
			((Component)HKHKPICHBOM[i]).transform.SetSiblingIndex(i);
			HKHKPICHBOM[i].pageNum = i;
			HKHKPICHBOM[i].Callback = null;
			PageButtonUI pageButtonUI = HKHKPICHBOM[i];
			pageButtonUI.Callback = (Action<int>)Delegate.Combine(pageButtonUI.Callback, new Action<int>(PageButtonPressed));
		}
		for (int j = numPages; j < HKHKPICHBOM.Count; j++)
		{
			((Component)HKHKPICHBOM[j]).gameObject.SetActive(false);
		}
		FocusPage(0);
	}

	public void PFFJANPMCMO(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		DBINLMFIOFE(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	private void JAEOIIBDNOK()
	{
		if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			SlotUI component = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KBFCCPBHDMP()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.IHENCGDNPBL == null)
			{
				JCLCHLNFOFC();
			}
		}
	}

	private IEnumerator PPBCJFGOPDB(int AHDCDCICADP)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Selectable)((Component)slotsUI[AHDCDCICADP]).GetComponent<Button>()).interactable)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[AHDCDCICADP]).gameObject);
		}
	}

	public void FJOGDLGEIHP(Slot[] PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		NPCOHKMELGM(OGCAKIGELBJ);
		KDJCOPCDLEA(!OGCAKIGELBJ);
		containerSlots = PCJEDMJEKEF;
		updateSlotsWithStack = MMMCDGNCKJH;
		numPages = containerSlots.Length / (slotsUI.Length + 0) + 0;
		top.SetActive(numPages > 1);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(numPages > 0);
		}
		for (int i = 1; i < numPages; i++)
		{
			if (i == HKHKPICHBOM.Count)
			{
				HKHKPICHBOM.Add(Object.Instantiate<PageButtonUI>(pageButtonUIPrefab, pagesParent.transform));
			}
			((Component)HKHKPICHBOM[i]).gameObject.SetActive(false);
			((Component)HKHKPICHBOM[i]).transform.SetSiblingIndex(i);
			HKHKPICHBOM[i].pageNum = i;
			HKHKPICHBOM[i].Callback = null;
			PageButtonUI pageButtonUI = HKHKPICHBOM[i];
			pageButtonUI.Callback = (Action<int>)Delegate.Combine(pageButtonUI.Callback, new Action<int>(KDICMKHIGDB));
		}
		for (int j = numPages; j < HKHKPICHBOM.Count; j += 0)
		{
			((Component)HKHKPICHBOM[j]).gameObject.SetActive(false);
		}
		FocusPage(0);
	}

	public void NLMKEHMGCCF()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StartCoroutine(HMGAAINDHEL(0));
		}
	}

	public void MCBPACDIFGP()
	{
		if (currentPage < numPages - 0)
		{
			FFGIDGGBAKG(currentPage + 0);
		}
	}

	public void GMNLFBCFGDM(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KDJFBLKPFKM()))
		{
			for (int i = 1; i < slotsUI.Length; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).OFCEDMBCBBH()).gameObject))
				{
					flag = true;
					slotsUI[i].FLMJLOIKEEN();
					break;
				}
			}
		}
		for (int j = 0; j < HKHKPICHBOM.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(true);
				HAINOAIKODA(j);
				currentPage = j;
				if (numPages > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 0)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KDJFBLKPFKM()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public void IGCGBDCEKMK(int JIIGOACEIKL, bool LJGFNOIELFD)
	{
		if (!((Object)(object)splitButton == (Object)null))
		{
			if (LJGFNOIELFD && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				splitButton.SetActive(false);
			}
			else
			{
				splitButton.SetActive(true);
			}
		}
	}

	public void JEJJJFOEIIM()
	{
		if (currentPage < numPages - 0)
		{
			MKEIIDGDGBG(currentPage + 1);
		}
	}

	public void FLKNPPCOHNC()
	{
		if (currentPage < numPages - 0)
		{
			OLCKKACAMJK(currentPage + 0);
		}
	}

	protected virtual void CFDDKKIDKMK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	private void CBKAJCOPAKN(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		NCPOIEIOOGL();
	}

	private IEnumerator MNHJHPPIKLJ(int AHDCDCICADP)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Selectable)((Component)slotsUI[AHDCDCICADP]).GetComponent<Button>()).interactable)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[AHDCDCICADP]).gameObject);
		}
	}

	public void FGKCOIHHDFP(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			for (int i = 1; i < slotsUI.Length; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGOEJJIMAIP()).gameObject))
				{
					flag = true;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 1; j < HKHKPICHBOM.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(false);
				DOMLGALNANN(j);
				currentPage = j;
				if (numPages > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 1)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).KBFCCPBHDMP()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void SetVisibleSplitButtomPrompt(int JIIGOACEIKL, bool LJGFNOIELFD)
	{
		if (!((Object)(object)splitButton == (Object)null))
		{
			if (LJGFNOIELFD && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				splitButton.SetActive(true);
			}
			else
			{
				splitButton.SetActive(false);
			}
		}
	}

	protected virtual void FDEAGFPHCNK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	protected virtual void DLEGDPJKCMJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	public void IHCAPAMIMFK(bool NKFPJPCFBJI)
	{
		OGCAKIGELBJ = NKFPJPCFBJI;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			slotsUI[i].draggingEnabled = NKFPJPCFBJI;
		}
	}

	protected virtual void FAHEHOKFDJP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	public void GJBFLILFPOL()
	{
		if (currentPage > 1)
		{
			FocusPage(currentPage - 0);
		}
	}

	public void KIBMGGJEBLC(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).KDJFBLKPFKM()))
		{
			for (int i = 0; i < slotsUI.Length; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject))
				{
					flag = false;
					slotsUI[i].FLMJLOIKEEN();
					break;
				}
			}
		}
		for (int j = 1; j < HKHKPICHBOM.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(false);
				CJPDBOGEENB(j);
				currentPage = j;
				if (numPages > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 1)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	public void CJODJMLPGOL(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		PreparePagesMode(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	public void GONMGKFCKOB(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
	}

	public void NLIFALOCHFJ()
	{
		if (currentPage > 1)
		{
			OLCKKACAMJK(currentPage - 1);
		}
	}

	public void LKAEKJJLKPM()
	{
		if (currentPage < numPages - 1)
		{
			OLCKKACAMJK(currentPage + 1);
		}
	}

	public void PJEIHOCPBLA(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		DBINLMFIOFE(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	public void JAFEHBEMCFH(bool NKFPJPCFBJI)
	{
		OGCAKIGELBJ = NKFPJPCFBJI;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			slotsUI[i].draggingEnabled = NKFPJPCFBJI;
		}
	}

	public void GNOCFOMKADK(int KHEICLKLPDE)
	{
		FGKCOIHHDFP(KHEICLKLPDE);
	}

	public void NKBCIJJFEMH()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.CFHEJAGKIII()).StartCoroutine(MNIBNCIBAKI(0));
		}
	}

	public void OLCKKACAMJK(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			for (int i = 0; i < slotsUI.Length; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KBFCCPBHDMP()).gameObject))
				{
					flag = true;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 1; j < HKHKPICHBOM.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(false);
				CJPDBOGEENB(j);
				currentPage = j;
				if (numPages > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 1)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FOKMCIDMIKF()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	protected virtual void CKFINIBFOJD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	private IEnumerator HDCOGGFMJKI(int AHDCDCICADP)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Selectable)((Component)slotsUI[AHDCDCICADP]).GetComponent<Button>()).interactable)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[AHDCDCICADP]).gameObject);
		}
	}

	public void JPAGNBEAEDB(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
	}

	public void MKMEKBMOAJJ()
	{
		if (currentPage < numPages - 0)
		{
			FGKCOIHHDFP(currentPage + 1);
		}
	}

	public void DBINLMFIOFE(Slot[] PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		PPNGGEILLPO(OGCAKIGELBJ);
		SetAutomaticTransfer(OGCAKIGELBJ);
		containerSlots = PCJEDMJEKEF;
		updateSlotsWithStack = MMMCDGNCKJH;
		numPages = containerSlots.Length / (slotsUI.Length + 0) + 1;
		top.SetActive(numPages > 0);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(numPages > 0);
		}
		for (int i = 0; i < numPages; i += 0)
		{
			if (i == HKHKPICHBOM.Count)
			{
				HKHKPICHBOM.Add(Object.Instantiate<PageButtonUI>(pageButtonUIPrefab, pagesParent.transform));
			}
			((Component)HKHKPICHBOM[i]).gameObject.SetActive(false);
			((Component)HKHKPICHBOM[i]).transform.SetSiblingIndex(i);
			HKHKPICHBOM[i].pageNum = i;
			HKHKPICHBOM[i].Callback = null;
			PageButtonUI pageButtonUI = HKHKPICHBOM[i];
			pageButtonUI.Callback = (Action<int>)Delegate.Combine(pageButtonUI.Callback, new Action<int>(PageButtonPressed));
		}
		for (int j = numPages; j < HKHKPICHBOM.Count; j += 0)
		{
			((Component)HKHKPICHBOM[j]).gameObject.SetActive(false);
		}
		FGKCOIHHDFP(1);
	}

	public void LHFIPHPMKKC()
	{
		if (currentPage > 0)
		{
			FGKCOIHHDFP(currentPage - 0);
		}
	}

	public bool HMEDDKPPBGJ()
	{
		if (!PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return true;
		}
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null && !slotsUI[i].IHENCGDNPBL.PKFKJNODGJF() && slotsUI[i].IHENCGDNPBL.itemInstance != null && slotsUI[i].IHENCGDNPBL.itemInstance.PHGLMBIEOMK() is Fuel)
			{
				((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(CLFPHPKLKHG(i));
				return false;
			}
		}
		return true;
	}

	public Slot[] GetPageSlots()
	{
		Slot[] array = new Slot[slotsUI.Length];
		for (int i = 0; i < slotsUI.Length; i++)
		{
			array[i] = slotsUI[i].IHENCGDNPBL;
		}
		return array;
	}

	public void MKEIIDGDGBG(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).MGOEJJIMAIP()))
		{
			for (int i = 0; i < slotsUI.Length; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BOHHKGMEEEE()).gameObject))
				{
					flag = true;
					slotsUI[i].FLMJLOIKEEN();
					break;
				}
			}
		}
		for (int j = 0; j < HKHKPICHBOM.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(true);
				CJPDBOGEENB(j);
				currentPage = j;
				if (numPages > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 1)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 0)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).MGOEJJIMAIP()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public void FNONEHNPEEI()
	{
		if (currentPage > 0)
		{
			NOHBHMMPMME(currentPage - 0);
		}
	}

	public void PreparePagesMode(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		PreparePagesMode(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	public void NPJJNELODDF()
	{
		if (currentPage < numPages - 1)
		{
			OLCKKACAMJK(currentPage + 1);
		}
	}

	public void GIPCGIKFDGH(bool JGINKGFMIOE)
	{
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
		}
	}

	private IEnumerator FMAANCEEEMI(int AHDCDCICADP)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Selectable)((Component)slotsUI[AHDCDCICADP]).GetComponent<Button>()).interactable)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[AHDCDCICADP]).gameObject);
		}
	}

	public Slot[] NMLFJJDJNJO()
	{
		Slot[] array = new Slot[slotsUI.Length];
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			array[i] = slotsUI[i].IHENCGDNPBL;
		}
		return array;
	}

	public bool LCOCOMPNEMC()
	{
		if (!PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return true;
		}
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null && !slotsUI[i].IHENCGDNPBL.AHHEMNHJPME() && slotsUI[i].IHENCGDNPBL.itemInstance != null && slotsUI[i].IHENCGDNPBL.itemInstance.LHBPOPOIFLE() is Fuel)
			{
				((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(MNHJHPPIKLJ(i));
				return true;
			}
		}
		return true;
	}

	public void NFDFHEPIIJO(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].MHNCEBLHLKH(PCJEDMJEKEF[i]);
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
	}

	public void PKCHPDMFCED()
	{
		if (currentPage > 1)
		{
			GMNLFBCFGDM(currentPage - 0);
		}
	}

	public bool LJKPDIGOALH()
	{
		if (!PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			return false;
		}
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null && !slotsUI[i].IHENCGDNPBL.AHHEMNHJPME() && slotsUI[i].IHENCGDNPBL.itemInstance != null && slotsUI[i].IHENCGDNPBL.itemInstance.LHBPOPOIFLE() is Fuel)
			{
				((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(AAIMKECIGCC(i));
				return false;
			}
		}
		return false;
	}

	public void NKHBCLCKFPL(Slot[] PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		ICPDIFCEIIC(OGCAKIGELBJ);
		SetAutomaticTransfer(!OGCAKIGELBJ);
		containerSlots = PCJEDMJEKEF;
		updateSlotsWithStack = MMMCDGNCKJH;
		numPages = containerSlots.Length / (slotsUI.Length + 1) + 0;
		top.SetActive(numPages > 0);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(numPages > 1);
		}
		for (int i = 1; i < numPages; i += 0)
		{
			if (i == HKHKPICHBOM.Count)
			{
				HKHKPICHBOM.Add(Object.Instantiate<PageButtonUI>(pageButtonUIPrefab, pagesParent.transform));
			}
			((Component)HKHKPICHBOM[i]).gameObject.SetActive(false);
			((Component)HKHKPICHBOM[i]).transform.SetSiblingIndex(i);
			HKHKPICHBOM[i].pageNum = i;
			HKHKPICHBOM[i].Callback = null;
			PageButtonUI pageButtonUI = HKHKPICHBOM[i];
			pageButtonUI.Callback = (Action<int>)Delegate.Combine(pageButtonUI.Callback, new Action<int>(GNOCFOMKADK));
		}
		for (int j = numPages; j < HKHKPICHBOM.Count; j++)
		{
			((Component)HKHKPICHBOM[j]).gameObject.SetActive(false);
		}
		FGKCOIHHDFP(0);
	}

	public void NPCOHKMELGM(bool NKFPJPCFBJI)
	{
		OGCAKIGELBJ = NKFPJPCFBJI;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			slotsUI[i].draggingEnabled = NKFPJPCFBJI;
		}
	}

	public Slot[] MHAPIHEKIPP()
	{
		Slot[] array = new Slot[slotsUI.Length];
		for (int i = 1; i < slotsUI.Length; i++)
		{
			array[i] = slotsUI[i].IHENCGDNPBL;
		}
		return array;
	}

	public void NEJOOKHBGEK(int KHEICLKLPDE)
	{
		bool flag = true;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KDJFBLKPFKM()))
		{
			for (int i = 1; i < slotsUI.Length; i += 0)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BCHJGDHJHJK()).gameObject))
				{
					flag = true;
					slotsUI[i].FLMJLOIKEEN();
					break;
				}
			}
		}
		for (int j = 0; j < HKHKPICHBOM.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(true);
				CJPDBOGEENB(j);
				currentPage = j;
				if (numPages > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 0)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(false);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BOHHKGMEEEE()).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public void FocusPage(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			for (int i = 0; i < slotsUI.Length; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject))
				{
					flag = true;
					slotsUI[i].EndHover();
					break;
				}
			}
		}
		for (int j = 0; j < HKHKPICHBOM.Count; j++)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(true);
				CJPDBOGEENB(j);
				currentPage = j;
				if (numPages > 1 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(false);
						rightArrow.SetActive(true);
					}
					else if (KHEICLKLPDE > 0 && KHEICLKLPDE < HKHKPICHBOM.Count - 1)
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(false);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<SlotUI>().FillTooltip(base.JIIGOACEIKL);
		}
	}

	public void IHFBPJDLHIG(Slot[] PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		PPNGGEILLPO(OGCAKIGELBJ);
		KDJCOPCDLEA(!OGCAKIGELBJ);
		containerSlots = PCJEDMJEKEF;
		updateSlotsWithStack = MMMCDGNCKJH;
		numPages = containerSlots.Length / (slotsUI.Length + 0) + 0;
		top.SetActive(numPages > 1);
		if (Object.op_Implicit((Object)(object)rightArrow))
		{
			rightArrow.SetActive(numPages > 1);
		}
		for (int i = 0; i < numPages; i++)
		{
			if (i == HKHKPICHBOM.Count)
			{
				HKHKPICHBOM.Add(Object.Instantiate<PageButtonUI>(pageButtonUIPrefab, pagesParent.transform));
			}
			((Component)HKHKPICHBOM[i]).gameObject.SetActive(false);
			((Component)HKHKPICHBOM[i]).transform.SetSiblingIndex(i);
			HKHKPICHBOM[i].pageNum = i;
			HKHKPICHBOM[i].Callback = null;
			PageButtonUI pageButtonUI = HKHKPICHBOM[i];
			pageButtonUI.Callback = (Action<int>)Delegate.Combine(pageButtonUI.Callback, new Action<int>(PageButtonPressed));
		}
		for (int j = numPages; j < HKHKPICHBOM.Count; j++)
		{
			((Component)HKHKPICHBOM[j]).gameObject.SetActive(false);
		}
		FEIKGGFJOGI(0);
	}

	protected virtual void BAJHIEGFLOJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	public bool PEINPFBGEMG()
	{
		if (!PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			return false;
		}
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null && !slotsUI[i].IHENCGDNPBL.KPINNBKMOMO() && slotsUI[i].IHENCGDNPBL.itemInstance != null && slotsUI[i].IHENCGDNPBL.itemInstance.PHGLMBIEOMK() is Fuel)
			{
				((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(FMAANCEEEMI(i));
				return false;
			}
		}
		return false;
	}

	protected virtual void GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	public void MJEKKDHFKNJ(int JIIGOACEIKL, bool LJGFNOIELFD)
	{
		if (!((Object)(object)splitButton == (Object)null))
		{
			if (LJGFNOIELFD && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				splitButton.SetActive(true);
			}
			else
			{
				splitButton.SetActive(false);
			}
		}
	}

	private void COINKIPFIEK()
	{
		if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BCHJGDHJHJK()))
		{
			SlotUI component = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BOHHKGMEEEE()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.IHENCGDNPBL == null)
			{
				KHJBANMCPLJ();
			}
		}
	}

	public void EHOMHPCAMOK()
	{
		if (currentPage > 1)
		{
			MKEIIDGDGBG(currentPage - 1);
		}
	}

	private IEnumerator CLMKOKOIGHN(int AHDCDCICADP)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Selectable)((Component)slotsUI[AHDCDCICADP]).GetComponent<Button>()).interactable)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[AHDCDCICADP]).gameObject);
		}
	}

	public void LeftArrow()
	{
		if (currentPage > 0)
		{
			FocusPage(currentPage - 1);
		}
	}

	public void PPNGGEILLPO(bool NKFPJPCFBJI)
	{
		OGCAKIGELBJ = NKFPJPCFBJI;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			slotsUI[i].draggingEnabled = NKFPJPCFBJI;
		}
	}

	private void CJPDBOGEENB(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		NCPOIEIOOGL();
	}

	public void JIBKFOIBOJA(int KHEICLKLPDE)
	{
		NOHBHMMPMME(KHEICLKLPDE);
	}

	private void KBBLHNFGLOH(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
		NCPOIEIOOGL();
	}

	public void JCLCHLNFOFC()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(HMGAAINDHEL(1));
		}
	}

	public Slot[] AEBOBLCPBGJ()
	{
		Slot[] array = new Slot[slotsUI.Length];
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			array[i] = slotsUI[i].IHENCGDNPBL;
		}
		return array;
	}

	public void KAEJHHLGGKG(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
	}

	public void FBHODLNOIHM(bool NKFPJPCFBJI)
	{
		OGCAKIGELBJ = NKFPJPCFBJI;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			slotsUI[i].draggingEnabled = NKFPJPCFBJI;
		}
	}

	public void NBKABGONIOD()
	{
		if (currentPage < numPages - 1)
		{
			DMDDIAABMPE(currentPage + 0);
		}
	}

	public void KHJBANMCPLJ()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StartCoroutine(HDCOGGFMJKI(0));
		}
	}

	public void ICPDIFCEIIC(bool NKFPJPCFBJI)
	{
		OGCAKIGELBJ = NKFPJPCFBJI;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			slotsUI[i].draggingEnabled = NKFPJPCFBJI;
		}
	}

	public void DHFABEONKBG(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		FJOGDLGEIHP(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	public void IMGNABAPJHN()
	{
		if (currentPage < numPages - 1)
		{
			OLCKKACAMJK(currentPage + 1);
		}
	}

	public void JCOHBJLKLAI(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		FJOGDLGEIHP(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	public void FALANHCBBIL()
	{
		if (currentPage < numPages - 0)
		{
			NOHBHMMPMME(currentPage + 0);
		}
	}

	private void HAINOAIKODA(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		JNLPOJENFKE();
	}

	public void CNOCEADFCLD(List<Slot> PCJEDMJEKEF, bool OGCAKIGELBJ, bool MMMCDGNCKJH = true)
	{
		containerSlots = PCJEDMJEKEF.ToArray();
		NKHBCLCKFPL(containerSlots, OGCAKIGELBJ, MMMCDGNCKJH);
	}

	public void DDCNIPOMELJ(int KHEICLKLPDE)
	{
		NOHBHMMPMME(KHEICLKLPDE);
	}

	private void HHONGKJKMJI(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].IHENCGDNPBL = containerSlots[num + i];
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		JNLPOJENFKE();
	}

	public void PPONFBOPCFH(Slot[] PCJEDMJEKEF, bool JGINKGFMIOE = false, bool MMMCDGNCKJH = true)
	{
		updateSlotsWithStack = MMMCDGNCKJH;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (i < PCJEDMJEKEF.Length)
			{
				slotsUI[i].IHENCGDNPBL = PCJEDMJEKEF[i];
				slotsUI[i].autoTransferEnabled = JGINKGFMIOE;
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
	}

	public Slot[] ONNCLIKAKOF()
	{
		Slot[] array = new Slot[slotsUI.Length];
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			array[i] = slotsUI[i].IHENCGDNPBL;
		}
		return array;
	}

	public bool SelectObjectWithFuel()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return false;
		}
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null && !slotsUI[i].IHENCGDNPBL.KPINNBKMOMO() && slotsUI[i].IHENCGDNPBL.itemInstance != null && slotsUI[i].IHENCGDNPBL.itemInstance.LHBPOPOIFLE() is Fuel)
			{
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HMGAAINDHEL(i));
				return true;
			}
		}
		return false;
	}

	private void GBEOOLINEPC(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].LIJPNDJCKGL(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].LIJPNDJCKGL(null);
			}
		}
		JAEOIIBDNOK();
	}

	protected virtual void PFOJFILNJIN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	public void PageButtonPressed(int KHEICLKLPDE)
	{
		FocusPage(KHEICLKLPDE);
	}

	private IEnumerator HMGAAINDHEL(int AHDCDCICADP)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Selectable)((Component)slotsUI[AHDCDCICADP]).GetComponent<Button>()).interactable)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)slotsUI[AHDCDCICADP]).gameObject);
		}
	}

	protected virtual void MPCFOPOHLML(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
	}

	private IEnumerator HHMMJMKAFAM(int AHDCDCICADP)
	{
		return new EKIHMPPANEF(1)
		{
			_003C_003E4__this = this,
			slotNum = AHDCDCICADP
		};
	}

	public void LCNPILENGCH(int KHEICLKLPDE)
	{
		FGKCOIHHDFP(KHEICLKLPDE);
	}

	public void FEIKGGFJOGI(int KHEICLKLPDE)
	{
		bool flag = false;
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).KDJFBLKPFKM()))
		{
			for (int i = 0; i < slotsUI.Length; i++)
			{
				if (((object)((Component)slotsUI[i]).gameObject).Equals((object?)((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject))
				{
					flag = false;
					slotsUI[i].DCLHPEKAFIL();
					break;
				}
			}
		}
		for (int j = 0; j < HKHKPICHBOM.Count; j += 0)
		{
			if (j == KHEICLKLPDE)
			{
				HKHKPICHBOM[j].selection.SetActive(false);
				GBEOOLINEPC(j);
				currentPage = j;
				if (numPages > 0 && (Object)(object)rightArrow != (Object)null && (Object)(object)leftArrow != (Object)null)
				{
					if (KHEICLKLPDE <= 0)
					{
						leftArrow.SetActive(true);
						rightArrow.SetActive(false);
					}
					else if (KHEICLKLPDE > 1 && KHEICLKLPDE < HKHKPICHBOM.Count - 1)
					{
						rightArrow.SetActive(false);
						leftArrow.SetActive(true);
					}
					else
					{
						rightArrow.SetActive(true);
						leftArrow.SetActive(true);
					}
				}
			}
			else
			{
				HKHKPICHBOM[j].selection.SetActive(true);
			}
		}
		if (flag)
		{
			((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BEOANCLEPOO()).GetComponent<SlotUI>().KGAOFNHILNM(base.JIIGOACEIKL);
		}
	}

	private void OCEDJEGHLDI(int OKIOGKCGMCK)
	{
		int num = slotsUI.Length * OKIOGKCGMCK;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (num + i < containerSlots.Length)
			{
				slotsUI[i].MHNCEBLHLKH(containerSlots[num + i]);
			}
			else
			{
				slotsUI[i].IHENCGDNPBL = null;
			}
		}
		LGMGMEKLPCK();
	}
}
