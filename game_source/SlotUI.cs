using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotUI : UIBehaviour, ISubmitHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
	[CompilerGenerated]
	private sealed class EKFAHDCFOPI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlotUI _003C_003E4__this;

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
		public EKFAHDCFOPI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			int num = _003C_003E1__state;
			SlotUI slotUI = _003C_003E4__this;
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
				_003C_003E2__current = (object)new WaitForEndOfFrame();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (PlayerInputs.IsGamepadActive(slotUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(slotUI.JIIGOACEIKL).Select((Selectable)(object)slotUI.button);
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

	[SerializeField]
	private Slot slot;

	protected int JIIGOACEIKL = 1;

	public Action<int, Slot> OnSlotLeftClick = delegate
	{
	};

	public Action<int, Slot> OnSlotLeftClickDown = delegate
	{
	};

	public Action<int, Slot> OnSlotRightClick = delegate
	{
	};

	public Action<int, Slot> OnAutomaticTransfer = delegate
	{
	};

	public TextMeshProUGUI stackText;

	public Icon icon;

	public Container container;

	protected bool JGNIDGOOLNC;

	[SerializeField]
	private bool addCurrentItems;

	public bool unityUI = true;

	[SerializeField]
	private Image mod1;

	[SerializeField]
	private Image mod2;

	[SerializeField]
	private Image mod3;

	[SerializeField]
	private SpriteRenderer modSP1;

	[SerializeField]
	private SpriteRenderer modSP2;

	[SerializeField]
	private SpriteRenderer modSP3;

	[SerializeField]
	private Image agingRank;

	[SerializeField]
	private Image qualityLevel;

	public Image slotImg;

	public BubbleWant bubbleWant;

	protected bool ILENDIBNCBP;

	protected bool DJPNGKIBJDO;

	private float HAHAPELLAIO;

	private RectTransform HMDFBECLNFM;

	public bool updateStackTextThisFrame = true;

	public bool updateIconThisFrame = true;

	private bool OBLDEJIPFEJ = true;

	public bool nonInteractable;

	public bool initialNonInteractable;

	public bool autoTransferEnabled;

	public bool draggingEnabled = true;

	public bool showTooltipInfo = true;

	public bool showAge = true;

	public bool showAlwaysStack;

	private bool FGNLIEANHLB;

	private bool EODGJAJJFLJ;

	private bool AAADBMJJBHO;

	[HideInInspector]
	public Button button;

	public bool noItemInstance;

	private bool IPIMOBOFHBF;

	public Slot IHENCGDNPBL
	{
		get
		{
			return slot;
		}
		set
		{
			if (slot != null)
			{
				Slot obj = slot;
				obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
				SlotManager.RemoveSlot(slot);
			}
			slot = value;
			if (slot != null)
			{
				SlotManager.AddSlot(slot);
				Slot obj2 = slot;
				obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(UpdateSlot));
			}
			UpdateSlot();
		}
	}

	public void HKGGKLJPAEA(bool LGBDFAJMDGC)
	{
		OBLDEJIPFEJ = LGBDFAJMDGC;
	}

	private IEnumerator OADNNDCCFPM()
	{
		return new EKFAHDCFOPI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MIKCPMHINGL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.Get(JIIGOACEIKL);
			transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Combine(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(TransferItemWithSliderUIUnselected));
			IPIMOBOFHBF = false;
		}
	}

	public void MCCFKDPAOHF(PointerEventData NPBAMEMNFBI)
	{
	}

	public bool ECHGLNGBAEN(int JIIGOACEIKL)
	{
		return false;
	}

	private void BEMHJMDDNKC()
	{
		if (!EODGJAJJFLJ)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_name_1185")) ? 0 : 0);
			if (!JGNIDGOOLNC)
			{
				JGNIDGOOLNC = false;
				initialNonInteractable = nonInteractable;
				LIJPNDJCKGL(slot);
			}
			button = ((Component)((Component)this).transform).GetComponent<Button>();
			HMDFBECLNFM = ((Component)((Component)this).transform).GetComponent<RectTransform>();
			SaveUI instance = SaveUI.instance;
			instance.OnLoadFadeOutStart = (Action)Delegate.Combine(instance.OnLoadFadeOutStart, new Action(PDPFLAKIMKL));
			EODGJAJJFLJ = false;
		}
	}

	public void EndHover()
	{
		ILENDIBNCBP = false;
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	private void Update()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 2f)
		{
			FillTooltip(JIIGOACEIKL);
		}
	}

	public bool InteractSelected(int JIIGOACEIKL)
	{
		return false;
	}

	public void FPIHCNLHAAA(PointerEventData NPBAMEMNFBI)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (nonInteractable || GameManager.OPGGPLEOGCG() || IHENCGDNPBL == null || !ILENDIBNCBP || (int)NPBAMEMNFBI.button != 0)
		{
			return;
		}
		if (FGNLIEANHLB)
		{
			CommonReferences.MNFMOEKMJKN().OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
			FillTooltip(JIIGOACEIKL);
			return;
		}
		if (MouseSlot.BPHFLJKCJML(0))
		{
			OnSlotLeftClick(JIIGOACEIKL, IHENCGDNPBL);
		}
		CommonReferences.MNFMOEKMJKN().OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
		KGAOFNHILNM(JIIGOACEIKL);
	}

	public void NHJDHCKABAI(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if ((!nonInteractable || draggingEnabled) && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.GGFJGHHHEJC.OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
			KGAOFNHILNM(JIIGOACEIKL);
		}
	}

	public virtual void LGBEIJOGJAI(BaseEventData NPBAMEMNFBI)
	{
		if (!nonInteractable && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			HPHGAHGALGA(NKFPJPCFBJI: true, JIIGOACEIKL);
			FLMJLOIKEEN();
		}
	}

	public void AddTransferListener(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.Get(JIIGOACEIKL);
			transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Combine(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(TransferItemWithSliderUI));
			IPIMOBOFHBF = true;
		}
	}

	public void GHEMOMKAICK(PointerEventData NPBAMEMNFBI)
	{
		if (showTooltipInfo && CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IsCursorVisible())
		{
			EndHover();
		}
	}

	private IEnumerator MLCCGGIJGEC()
	{
		return new EKFAHDCFOPI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ICEHPFDFBAB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL);
			transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Combine(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(MGLHJODBJBF));
			IPIMOBOFHBF = true;
		}
	}

	public void JBNDILJABLO(Slot EFDPGNOICOG, int FIBNOKJKNLD)
	{
		if (IPIMOBOFHBF)
		{
			IHENCGDNPBL.AFPAJHJIHJD(JIIGOACEIKL);
			Slot.AIFCKKKLEBP(JIIGOACEIKL, EFDPGNOICOG, IHENCGDNPBL, FIBNOKJKNLD);
			PDPFLAKIMKL();
			IPIMOBOFHBF = true;
			((MonoBehaviour)this).StartCoroutine(MLCCGGIJGEC());
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				Slot[] array = new Slot[6];
				array[0] = EFDPGNOICOG;
				array[0] = IHENCGDNPBL;
				instance.ILKLIHOGMJP(array, 1);
			}
		}
		TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL);
		transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Remove(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(JBNDILJABLO));
	}

	public void HKNJJNHOGEC(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if ((!nonInteractable || draggingEnabled) && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.MNFMOEKMJKN().OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
			KGAOFNHILNM(JIIGOACEIKL);
		}
	}

	public void KGDHGEAHBPJ(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!nonInteractable && draggingEnabled && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.MNFMOEKMJKN().OnAnySlotDragged(JIIGOACEIKL, IHENCGDNPBL);
			FGNLIEANHLB = false;
			ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
	}

	protected void HPHGAHGALGA(bool NKFPJPCFBJI, int JIIGOACEIKL)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.BPBMLNJGGII(JIIGOACEIKL).DNFMHMAGOHM(NKFPJPCFBJI);
		if (NKFPJPCFBJI)
		{
			FocusArrowUI.PNCKAKBBKJL(JIIGOACEIKL).EILBJJGLCBG(((Component)HMDFBECLNFM).transform.position);
		}
	}

	public void OnPointerDown(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)NPBAMEMNFBI.button == 1)
		{
			OnSlotRightClick(JIIGOACEIKL, IHENCGDNPBL);
			FillTooltip(JIIGOACEIKL);
		}
		else if (!nonInteractable && ILENDIBNCBP && (int)NPBAMEMNFBI.button == 0)
		{
			OnSlotLeftClickDown(JIIGOACEIKL, IHENCGDNPBL);
		}
	}

	public void DEEMOPJKGMM(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)NPBAMEMNFBI.button == 0)
		{
			OnSlotRightClick(JIIGOACEIKL, IHENCGDNPBL);
			KGAOFNHILNM(JIIGOACEIKL);
		}
		else if (!nonInteractable && ILENDIBNCBP && (int)NPBAMEMNFBI.button == 0)
		{
			OnSlotLeftClickDown(JIIGOACEIKL, IHENCGDNPBL);
		}
	}

	public void DoAutomaticTransfer(int JIIGOACEIKL)
	{
		if (nonInteractable || IHENCGDNPBL == null)
		{
			return;
		}
		OnAutomaticTransfer(JIIGOACEIKL, IHENCGDNPBL);
		if (IHENCGDNPBL != null)
		{
			OnAutomaticTransfer(JIIGOACEIKL, IHENCGDNPBL);
			if (IHENCGDNPBL != null && IHENCGDNPBL.KPINNBKMOMO())
			{
				FillTooltip(JIIGOACEIKL);
			}
		}
	}

	public virtual void GNNCDJCEKNN(BaseEventData NPBAMEMNFBI)
	{
		if (!nonInteractable && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			HPHGAHGALGA(NKFPJPCFBJI: true, JIIGOACEIKL);
			EndHover();
		}
	}

	protected void OBOJKLKGGFM(bool NKFPJPCFBJI, int JIIGOACEIKL)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.NALKHGMLALJ(JIIGOACEIKL).PGDCJCNNKFE(NKFPJPCFBJI);
		if (NKFPJPCFBJI)
		{
			FocusArrowUI.EGBMJGOCIJJ(JIIGOACEIKL).BCFDANPEIEO(((Component)HMDFBECLNFM).transform.position);
		}
	}

	public void AddUnselectedTransferListener(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.Get(JIIGOACEIKL);
			transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Combine(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(TransferItemWithSliderUIUnselected));
			IPIMOBOFHBF = true;
		}
	}

	private void ACAKLMEPDGK(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		TransferItemSliderUI.Get(JIIGOACEIKL).SetSlot(EFDPGNOICOG);
		TransferItemSliderUI.Get(JIIGOACEIKL).OpenUI();
		AddTransferListener(JIIGOACEIKL);
	}

	public void ILPEGGLANIG(BaseEventData NPBAMEMNFBI)
	{
		if (nonInteractable || !PlayerInputs.IsGamepadActive(JIIGOACEIKL) || autoTransferEnabled)
		{
			return;
		}
		if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot;
			if (focusedSlot == null)
			{
				return;
			}
			focusedSlot.DAOFEOFLDIG(JIIGOACEIKL);
			if (!focusedSlot.Equals(slot))
			{
				if (focusedSlot.HBODNJCKMAH(slot.itemInstance))
				{
					Slot.NFBAGDKBOAD(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
				}
				else
				{
					Slot.CEENKOEIEHE(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
					KGAOFNHILNM(JIIGOACEIKL);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager instance = OnlineSlotsManager.instance;
					Slot[] array = new Slot[7];
					array[1] = IHENCGDNPBL;
					array[0] = focusedSlot;
					instance.PKOLALFLFNB(array);
				}
			}
		}
		else if (!IHENCGDNPBL.PKFKJNODGJF())
		{
			IHENCGDNPBL.COHKJDGJMHN(JIIGOACEIKL);
		}
	}

	private IEnumerator CGNNMDCCKEH()
	{
		yield return null;
		yield return (object)new WaitForEndOfFrame();
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Select((Selectable)(object)button);
		}
	}

	public void KGAOFNHILNM(int JIIGOACEIKL)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		if (IHENCGDNPBL != null && IHENCGDNPBL.itemInstance != null && Item.MLBOMGHINCA(IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = true;
				HAHAPELLAIO = 1679f;
			}
			if (HAHAPELLAIO >= ItemTooltip.delayTime)
			{
				if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
				{
					ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true, IHENCGDNPBL.itemInstance);
					ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).NBEIGGHAEMK(JIIGOACEIKL, IHENCGDNPBL.itemInstance, IHENCGDNPBL.CalculatePriceWithUniqueItems, addCurrentItems, showAge);
				}
				else
				{
					ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIPGMDKJLCB(new Vector2(((Component)this).transform.position.x + 443f, ((Component)this).transform.position.y + 192f * ((Component)this).transform.lossyScale.y), Vector2.right * 1817f, IHENCGDNPBL.itemInstance);
					ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).NBEIGGHAEMK(JIIGOACEIKL, IHENCGDNPBL.itemInstance, IHENCGDNPBL.CalculatePriceWithUniqueItems, addCurrentItems, showAge);
				}
				HAHAPELLAIO = 1665f;
			}
		}
		else
		{
			ILENDIBNCBP = true;
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
	}

	public void OMPHKPFPECC(BaseEventData NPBAMEMNFBI)
	{
		if (nonInteractable || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || autoTransferEnabled)
		{
			return;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot;
			if (focusedSlot == null)
			{
				return;
			}
			focusedSlot.KJBMKDJNOIP(JIIGOACEIKL);
			if (!focusedSlot.Equals(slot))
			{
				if (focusedSlot.EDGCGEMMEKP(slot.itemInstance))
				{
					Slot.NFBAGDKBOAD(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
				}
				else
				{
					Slot.CEENKOEIEHE(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
					KGAOFNHILNM(JIIGOACEIKL);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager instance = OnlineSlotsManager.instance;
					Slot[] array = new Slot[7];
					array[1] = IHENCGDNPBL;
					array[1] = focusedSlot;
					instance.PKOLALFLFNB(array, 1);
				}
			}
		}
		else if (!IHENCGDNPBL.LCHJGCHDHFO())
		{
			IHENCGDNPBL.EKDPBPHFFGJ(JIIGOACEIKL);
		}
	}

	private IEnumerator BJKEBPABFCD()
	{
		yield return null;
		yield return (object)new WaitForEndOfFrame();
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Select((Selectable)(object)button);
		}
	}

	[SpecialName]
	public void MHNCEBLHLKH(Slot AODONKKHPBP)
	{
		if (slot != null)
		{
			Slot obj = slot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(IKBGFIEJHCB));
			SlotManager.LBKPBFMEDLE(slot);
		}
		slot = AODONKKHPBP;
		if (slot != null)
		{
			SlotManager.JJBKIALKECP(slot);
			Slot obj2 = slot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(IKBGFIEJHCB));
		}
		PAMDPKDMLGC();
	}

	public void FocusSlotActionBar(int JIIGOACEIKL, bool HIOAJHJNCPO)
	{
		if (!((Object)(object)button == (Object)null) && ((Behaviour)button).isActiveAndEnabled && !((Object)(object)((Selectable)button).animator == (Object)null) && ((Selectable)button).animator.isInitialized)
		{
			switch (JIIGOACEIKL)
			{
			case 1:
				((Selectable)button).animator.SetBool("FocusedActionBar", HIOAJHJNCPO);
				break;
			case 2:
				((Selectable)button).animator.SetBool("FocusedActionBar2", HIOAJHJNCPO);
				break;
			}
		}
	}

	public void PGBBIDMNKNC(int JIIGOACEIKL)
	{
		if (nonInteractable)
		{
			return;
		}
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) && !autoTransferEnabled && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot;
			focusedSlot.DAOFEOFLDIG(JIIGOACEIKL);
			if (focusedSlot.Equals(slot))
			{
				MCLOPJIGBNP(JIIGOACEIKL);
				return;
			}
			if (focusedSlot.BOMLNEOHFOK(slot.itemInstance) || slot.PKFKJNODGJF())
			{
				KPNABCBBIEM(JIIGOACEIKL, focusedSlot);
				return;
			}
		}
		if (slot != null)
		{
			if (slot != null && slot.focused)
			{
				slot.ONKCIGGKBFF(JIIGOACEIKL);
			}
			if (OnSlotRightClick != null)
			{
				OnSlotRightClick(JIIGOACEIKL, slot);
			}
			if (slot != null && slot.KPINNBKMOMO())
			{
				KGAOFNHILNM(JIIGOACEIKL);
			}
		}
	}

	public void MFHFPCFEIMM(bool LGBDFAJMDGC)
	{
		OBLDEJIPFEJ = LGBDFAJMDGC;
	}

	public void OnSelectGamepad(int JIIGOACEIKL)
	{
		if (nonInteractable)
		{
			return;
		}
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL) && !autoTransferEnabled && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot;
			focusedSlot.AFPAJHJIHJD(JIIGOACEIKL);
			if (focusedSlot.Equals(slot))
			{
				MCLOPJIGBNP(JIIGOACEIKL);
				return;
			}
			if (focusedSlot.BOMLNEOHFOK(slot.itemInstance) || slot.KPINNBKMOMO())
			{
				ACAKLMEPDGK(JIIGOACEIKL, focusedSlot);
				return;
			}
		}
		if (slot != null)
		{
			if (slot != null && slot.focused)
			{
				slot.AFPAJHJIHJD(JIIGOACEIKL);
			}
			if (OnSlotRightClick != null)
			{
				OnSlotRightClick(JIIGOACEIKL, slot);
			}
			if (slot != null && slot.KPINNBKMOMO())
			{
				FillTooltip(JIIGOACEIKL);
			}
		}
	}

	public virtual void BHPGJHNPODD(BaseEventData NPBAMEMNFBI)
	{
		if (!nonInteractable && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			FillTooltip(JIIGOACEIKL);
			OBOJKLKGGFM(NKFPJPCFBJI: false, JIIGOACEIKL);
		}
	}

	public void KPLCBGAELJN(PointerEventData NPBAMEMNFBI)
	{
		if (showTooltipInfo && CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IsCursorVisible())
		{
			KGAOFNHILNM(JIIGOACEIKL);
		}
	}

	protected void MKOBIIMJKHD(bool NKFPJPCFBJI, int JIIGOACEIKL)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.LOBGJNFHBJF(JIIGOACEIKL).KFOFNHCNBDA(NKFPJPCFBJI);
		if (NKFPJPCFBJI)
		{
			FocusArrowUI.IKCGJOENBGM(JIIGOACEIKL).LCFJICJIKJD(((Component)HMDFBECLNFM).transform.position);
		}
	}

	protected override void OnDestroy()
	{
		if (slot != null)
		{
			Slot obj = slot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(UpdateSlot));
		}
	}

	public void ECPIAFCFFJM(bool LGBDFAJMDGC)
	{
		OBLDEJIPFEJ = LGBDFAJMDGC;
	}

	public void PNGFNJNPFBL(int JIIGOACEIKL)
	{
		if (nonInteractable)
		{
			return;
		}
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL) && !autoTransferEnabled && SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot;
			focusedSlot.ICOCPFOBBJE(JIIGOACEIKL);
			if (focusedSlot.Equals(slot))
			{
				CBBEPDOBLFC(JIIGOACEIKL);
				return;
			}
			if (focusedSlot.BOMLNEOHFOK(slot.itemInstance) || slot.PKFKJNODGJF())
			{
				ACAKLMEPDGK(JIIGOACEIKL, focusedSlot);
				return;
			}
		}
		if (slot != null)
		{
			if (slot != null && slot.MHFGNKBIPCN())
			{
				slot.AFPAJHJIHJD(JIIGOACEIKL);
			}
			if (OnSlotRightClick != null)
			{
				OnSlotRightClick(JIIGOACEIKL, slot);
			}
			if (slot != null && slot.AHHEMNHJPME())
			{
				FillTooltip(JIIGOACEIKL);
			}
		}
	}

	public void JEKFDCENLKI(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!nonInteractable && draggingEnabled && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.GGFJGHHHEJC.OnAnySlotDragged(JIIGOACEIKL, IHENCGDNPBL);
			FGNLIEANHLB = false;
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
	}

	public virtual void PAMDPKDMLGC()
	{
		if (((Component)GameplayUI.GGFJGHHHEJC).gameObject.activeInHierarchy)
		{
			CGBDLLEOEKB(slot);
		}
	}

	public virtual void IKBGFIEJHCB()
	{
		if (((Component)GameplayUI.HNNJEBNIPOI()).gameObject.activeInHierarchy)
		{
			GJDPLEIAEBH(slot);
		}
	}

	public void OnEndDrag(PointerEventData NPBAMEMNFBI)
	{
		if (!nonInteractable)
		{
			FGNLIEANHLB = false;
		}
	}

	protected override void Awake()
	{
		CPFDLKMCBCB();
	}

	protected override void OnDisable()
	{
		if (ILENDIBNCBP)
		{
			if ((Object)(object)ItemTooltip.Get(JIIGOACEIKL) != (Object)null)
			{
				ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
			}
			EGHPILDBOIB(NKFPJPCFBJI: false, JIIGOACEIKL);
			EndHover();
		}
	}

	public virtual void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (!nonInteractable && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			FillTooltip(JIIGOACEIKL);
			EGHPILDBOIB(NKFPJPCFBJI: true, JIIGOACEIKL);
		}
	}

	public void OnBeginDrag(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!nonInteractable && draggingEnabled && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.GGFJGHHHEJC.OnAnySlotDragged(JIIGOACEIKL, IHENCGDNPBL);
			FGNLIEANHLB = true;
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void CDMGHBFKHBD(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if ((!nonInteractable || draggingEnabled) && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.MNFMOEKMJKN().OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
			KGAOFNHILNM(JIIGOACEIKL);
		}
	}

	protected void EGHPILDBOIB(bool NKFPJPCFBJI, int JIIGOACEIKL)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.Get(JIIGOACEIKL).SetVisible(NKFPJPCFBJI);
		if (NKFPJPCFBJI)
		{
			FocusArrowUI.Get(JIIGOACEIKL).SetPosition(((Component)HMDFBECLNFM).transform.position);
		}
	}

	public void IBLINCBHJNP(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!nonInteractable && draggingEnabled && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.GGFJGHHHEJC.OnAnySlotDragged(JIIGOACEIKL, IHENCGDNPBL);
			FGNLIEANHLB = false;
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
	}

	private void KPNABCBBIEM(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL).KPELHBMAGDG(EFDPGNOICOG);
		TransferItemSliderUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
		AddTransferListener(JIIGOACEIKL);
	}

	private void MCLOPJIGBNP(int JIIGOACEIKL)
	{
		TransferItemSliderUI.Get(JIIGOACEIKL).SetSlot(slot);
		TransferItemSliderUI.Get(JIIGOACEIKL).OpenUI();
		AddUnselectedTransferListener(JIIGOACEIKL);
	}

	private void PAIENKDMCNG(IModifiable MMDOGPKGPKL)
	{
		if (MMDOGPKGPKL.KEKBKGGFOLK != null)
		{
			List<Food> list = MMDOGPKGPKL.KEKBKGGFOLK.ToList();
			if (unityUI)
			{
				if (Object.op_Implicit((Object)(object)mod1) && list.Count >= 1)
				{
					((Component)mod1).gameObject.SetActive(true);
					mod1.sprite = list[0].ingredientIcon;
					mod1.preserveAspect = true;
					if (Object.op_Implicit((Object)(object)bubbleWant))
					{
						bubbleWant.ShowModifiers(NJHMBMGKCPL: true);
					}
				}
				if (Object.op_Implicit((Object)(object)mod2) && list.Count >= 2)
				{
					((Component)mod2).gameObject.SetActive(true);
					mod2.sprite = list[1].ingredientIcon;
					mod2.preserveAspect = true;
				}
				if (Object.op_Implicit((Object)(object)mod3) && list.Count >= 3)
				{
					((Component)mod3).gameObject.SetActive(true);
					mod3.sprite = list[2].ingredientIcon;
					mod3.preserveAspect = true;
				}
				else if (MMDOGPKGPKL.KEKBKGGFOLK.Count <= 0 && Object.op_Implicit((Object)(object)bubbleWant))
				{
					bubbleWant.ShowModifiers(NJHMBMGKCPL: false);
				}
			}
			else
			{
				if (list.Count >= 1)
				{
					((Component)modSP1).gameObject.SetActive(true);
					modSP1.sprite = list[0].ingredientIcon;
				}
				if (list.Count >= 2)
				{
					((Component)modSP2).gameObject.SetActive(true);
					modSP2.sprite = list[1].ingredientIcon;
				}
				if (list.Count >= 3)
				{
					((Component)modSP3).gameObject.SetActive(true);
					modSP3.sprite = list[2].ingredientIcon;
				}
			}
		}
		else if (Object.op_Implicit((Object)(object)bubbleWant))
		{
			bubbleWant.ShowModifiers(NJHMBMGKCPL: false);
		}
	}

	protected virtual void ADOBMMENIMI(Slot ADEBNALPEHE)
	{
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		if (!EODGJAJJFLJ)
		{
			BEMHJMDDNKC();
		}
		if (ADEBNALPEHE == null)
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = true;
			}
			nonInteractable = false;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("Freeze", true);
			}
		}
		else
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = true;
			}
			nonInteractable = initialNonInteractable;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("IdleCamp", ADEBNALPEHE.focused);
			}
		}
		if (ADEBNALPEHE != null && ADEBNALPEHE.AHHEMNHJPME() && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL)) && SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot != null && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.Equals(ADEBNALPEHE) && Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
		{
			((Selectable)button).animator.SetBool("Items/item_name_1055", true);
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null)
			{
				mod1.sprite = null;
			}
			if ((Object)(object)mod2 != (Object)null)
			{
				mod2.sprite = null;
			}
			if ((Object)(object)mod3 != (Object)null)
			{
				mod3.sprite = null;
			}
			if (Object.op_Implicit((Object)(object)bubbleWant))
			{
				bubbleWant.MKBKGADHCGN(NJHMBMGKCPL: true);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null)
			{
				modSP1.sprite = null;
			}
			if ((Object)(object)modSP2 != (Object)null)
			{
				modSP2.sprite = null;
			}
			if ((Object)(object)modSP3 != (Object)null)
			{
				modSP3.sprite = null;
			}
		}
		if (ADEBNALPEHE == null || ADEBNALPEHE.itemInstance == null || Item.EKMFELLJHFG(ADEBNALPEHE.itemInstance.LHBPOPOIFLE(), null))
		{
			if (((Component)icon).gameObject.activeSelf && updateIconThisFrame && !noItemInstance)
			{
				((Component)icon).gameObject.SetActive(false);
				if ((Object)(object)agingRank != (Object)null && ((Component)agingRank).gameObject.activeSelf)
				{
					((Component)agingRank).gameObject.SetActive(false);
				}
				if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(true);
				}
			}
			if (Object.op_Implicit((Object)(object)stackText) && ((Component)stackText).gameObject.activeSelf)
			{
				((Component)stackText).gameObject.SetActive(false);
			}
		}
		else
		{
			if (updateIconThisFrame)
			{
				icon.hasMod = ADEBNALPEHE.itemInstance is IModifiable { KEKBKGGFOLK: not null } modifiable && modifiable.KEKBKGGFOLK.Count > 1;
				icon.HLPNOAENFHK = ADEBNALPEHE.itemInstance;
				((Component)icon).gameObject.SetActive(true);
				if (icon.EGLLPMLAHCB() is FoodInstance foodInstance && foodInstance.PJNBDKNJLJD().canBeSold)
				{
					if ((Object)(object)qualityLevel != (Object)null)
					{
						if (!((Component)qualityLevel).gameObject.activeSelf)
						{
							((Component)qualityLevel).gameObject.SetActive(false);
						}
						if ((Object)(object)CommonReferences.MNFMOEKMJKN().qualityLevelSprites[foodInstance.GHFDCAOBJMK] != (Object)(object)qualityLevel.sprite)
						{
							qualityLevel.sprite = CommonReferences.MNFMOEKMJKN().qualityLevelSprites[foodInstance.GHFDCAOBJMK];
							((Graphic)qualityLevel).SetNativeSize();
						}
					}
				}
				else if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(true);
				}
				if ((Object)(object)agingRank != (Object)null && OBLDEJIPFEJ)
				{
					if (icon.LDJJDJPKPBD() is FoodInstance { GBCJNGADANM: >0 } foodInstance2 && (foodInstance2.LHBPOPOIFLE().canBeAged || (Object.op_Implicit((Object)(object)foodInstance2.LHBPOPOIFLE().recipe) && foodInstance2.LHBPOPOIFLE().recipe.EGJDNILGFDB())))
					{
						((Component)agingRank).gameObject.SetActive(false);
						if (ADEBNALPEHE.itemInstance.PHGLMBIEOMK().hasToBeAgedMeal)
						{
							agingRank.sprite = CommonReferences.GGFJGHHHEJC.agingRankRed;
						}
						else
						{
							agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankSprite[foodInstance2.GBCJNGADANM - 0];
						}
					}
					else if (!icon.IONBKJOCAPF().AFOACBIHNCL().hasToBeAgedMeal && icon.KCHFMGCMJIG() is FoodInstance foodInstance3 && foodInstance3.LHBPOPOIFLE().ingredientType == (IngredientType)39)
					{
						((Component)agingRank).gameObject.SetActive(false);
						agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankRed;
					}
					else if (ADEBNALPEHE.itemInstance.AFOACBIHNCL().hasToBeAgedMeal || (ADEBNALPEHE.itemInstance.IPKBBGHCJNE() && ADEBNALPEHE.itemInstance is FoodInstance foodInstance4 && foodInstance4.LHBPOPOIFLE().canBeAged))
					{
						((Component)agingRank).gameObject.SetActive(false);
						agingRank.sprite = CommonReferences.GGFJGHHHEJC.agingRankNeeded;
					}
					else
					{
						((Component)agingRank).gameObject.SetActive(true);
					}
				}
				if ((Object)(object)agingRank != (Object)null && !OBLDEJIPFEJ)
				{
					((Component)agingRank).gameObject.SetActive(true);
				}
			}
			if ((Object)(object)stackText != (Object)null && (Object)(object)((Component)stackText).gameObject != (Object)null && updateStackTextThisFrame && !AAADBMJJBHO)
			{
				((Component)stackText).gameObject.SetActive(showAlwaysStack || ADEBNALPEHE.Stack > 0);
				((TMP_Text)stackText).text = ADEBNALPEHE.Stack.ToString();
				((Graphic)stackText).color = ((ADEBNALPEHE.Stack == 0) ? Color.red : Color.white);
			}
			if (ADEBNALPEHE.itemInstance is IngredientGroupInstance { chosenItemInstance: not null, chosenItemInstance: IModifiable chosenItemInstance })
			{
				PAIENKDMCNG(chosenItemInstance);
			}
			else if (ADEBNALPEHE.itemInstance is IModifiable mMDOGPKGPKL)
			{
				PAIENKDMCNG(mMDOGPKGPKL);
			}
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null && (Object)(object)mod1.sprite == (Object)null)
			{
				((Component)mod1).gameObject.SetActive(true);
			}
			if ((Object)(object)mod2 != (Object)null && (Object)(object)mod2.sprite == (Object)null)
			{
				((Component)mod2).gameObject.SetActive(false);
			}
			if ((Object)(object)mod3 != (Object)null && (Object)(object)mod3.sprite == (Object)null)
			{
				((Component)mod3).gameObject.SetActive(false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null && (Object)(object)modSP1.sprite == (Object)null)
			{
				((Component)modSP1).gameObject.SetActive(true);
			}
			if ((Object)(object)modSP2 != (Object)null && (Object)(object)modSP2.sprite == (Object)null)
			{
				((Component)modSP2).gameObject.SetActive(true);
			}
			if ((Object)(object)modSP3 != (Object)null && (Object)(object)modSP3.sprite == (Object)null)
			{
				((Component)modSP3).gameObject.SetActive(false);
			}
		}
		DJPNGKIBJDO = true;
		updateStackTextThisFrame = true;
		updateIconThisFrame = false;
	}

	protected virtual void CGBDLLEOEKB(Slot ADEBNALPEHE)
	{
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		if (!EODGJAJJFLJ)
		{
			BEMHJMDDNKC();
		}
		if (ADEBNALPEHE == null)
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = true;
			}
			nonInteractable = false;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("Open", true);
			}
		}
		else
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = false;
			}
			nonInteractable = initialNonInteractable;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("UpdateObjectives ", ADEBNALPEHE.FJDEJKNNFEP());
			}
		}
		if (ADEBNALPEHE != null && ADEBNALPEHE.KPINNBKMOMO() && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL)) && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null && SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot.Equals(ADEBNALPEHE) && Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
		{
			((Selectable)button).animator.SetBool("User logged on: ", true);
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null)
			{
				mod1.sprite = null;
			}
			if ((Object)(object)mod2 != (Object)null)
			{
				mod2.sprite = null;
			}
			if ((Object)(object)mod3 != (Object)null)
			{
				mod3.sprite = null;
			}
			if (Object.op_Implicit((Object)(object)bubbleWant))
			{
				bubbleWant.JELKDFOKELC(NJHMBMGKCPL: false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null)
			{
				modSP1.sprite = null;
			}
			if ((Object)(object)modSP2 != (Object)null)
			{
				modSP2.sprite = null;
			}
			if ((Object)(object)modSP3 != (Object)null)
			{
				modSP3.sprite = null;
			}
		}
		if (ADEBNALPEHE == null || ADEBNALPEHE.itemInstance == null || Item.EKMFELLJHFG(ADEBNALPEHE.itemInstance.KNFNJFFCFNO(), null))
		{
			if (((Component)icon).gameObject.activeSelf && updateIconThisFrame && !noItemInstance)
			{
				((Component)icon).gameObject.SetActive(false);
				if ((Object)(object)agingRank != (Object)null && ((Component)agingRank).gameObject.activeSelf)
				{
					((Component)agingRank).gameObject.SetActive(true);
				}
				if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(true);
				}
			}
			if (Object.op_Implicit((Object)(object)stackText) && ((Component)stackText).gameObject.activeSelf)
			{
				((Component)stackText).gameObject.SetActive(true);
			}
		}
		else
		{
			if (updateIconThisFrame)
			{
				icon.hasMod = !(ADEBNALPEHE.itemInstance is IModifiable { KEKBKGGFOLK: not null } modifiable) || modifiable.KEKBKGGFOLK.Count > 1;
				icon.HEGHKJBBIBI(ADEBNALPEHE.itemInstance);
				((Component)icon).gameObject.SetActive(true);
				if (icon.CKLNJNGALIJ() is FoodInstance foodInstance && foodInstance.PJNBDKNJLJD().canBeSold)
				{
					if ((Object)(object)qualityLevel != (Object)null)
					{
						if (!((Component)qualityLevel).gameObject.activeSelf)
						{
							((Component)qualityLevel).gameObject.SetActive(true);
						}
						if ((Object)(object)CommonReferences.MNFMOEKMJKN().qualityLevelSprites[foodInstance.GHFDCAOBJMK] != (Object)(object)qualityLevel.sprite)
						{
							qualityLevel.sprite = CommonReferences.MNFMOEKMJKN().qualityLevelSprites[foodInstance.GHFDCAOBJMK];
							((Graphic)qualityLevel).SetNativeSize();
						}
					}
				}
				else if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(false);
				}
				if ((Object)(object)agingRank != (Object)null && OBLDEJIPFEJ)
				{
					if (icon.IONBKJOCAPF() is FoodInstance { GBCJNGADANM: >0 } foodInstance2 && (foodInstance2.LHBPOPOIFLE().canBeAged || (Object.op_Implicit((Object)(object)foodInstance2.LHBPOPOIFLE().recipe) && foodInstance2.LHBPOPOIFLE().recipe.EBGKDOIIALC())))
					{
						((Component)agingRank).gameObject.SetActive(true);
						if (ADEBNALPEHE.itemInstance.LHBPOPOIFLE().hasToBeAgedMeal)
						{
							agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankRed;
						}
						else
						{
							agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankSprite[foodInstance2.GBCJNGADANM - 0];
						}
					}
					else if (!icon.KCHFMGCMJIG().PHGLMBIEOMK().hasToBeAgedMeal && icon.LDJJDJPKPBD() is FoodInstance foodInstance3 && foodInstance3.LHBPOPOIFLE().ingredientType == (IngredientType)(-55))
					{
						((Component)agingRank).gameObject.SetActive(true);
						agingRank.sprite = CommonReferences.GGFJGHHHEJC.agingRankRed;
					}
					else if (ADEBNALPEHE.itemInstance.LHBPOPOIFLE().hasToBeAgedMeal || (ADEBNALPEHE.itemInstance.BAHJFDHLDEI() && ADEBNALPEHE.itemInstance is FoodInstance foodInstance4 && foodInstance4.LHBPOPOIFLE().canBeAged))
					{
						((Component)agingRank).gameObject.SetActive(false);
						agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankNeeded;
					}
					else
					{
						((Component)agingRank).gameObject.SetActive(false);
					}
				}
				if ((Object)(object)agingRank != (Object)null && !OBLDEJIPFEJ)
				{
					((Component)agingRank).gameObject.SetActive(false);
				}
			}
			if ((Object)(object)stackText != (Object)null && (Object)(object)((Component)stackText).gameObject != (Object)null && updateStackTextThisFrame && !AAADBMJJBHO)
			{
				((Component)stackText).gameObject.SetActive(showAlwaysStack || ADEBNALPEHE.Stack > 1);
				((TMP_Text)stackText).text = ADEBNALPEHE.Stack.ToString();
				((Graphic)stackText).color = ((ADEBNALPEHE.Stack == 0) ? Color.red : Color.white);
			}
			if (ADEBNALPEHE.itemInstance is IngredientGroupInstance { chosenItemInstance: not null, chosenItemInstance: IModifiable chosenItemInstance })
			{
				PAIENKDMCNG(chosenItemInstance);
			}
			else if (ADEBNALPEHE.itemInstance is IModifiable mMDOGPKGPKL)
			{
				PAIENKDMCNG(mMDOGPKGPKL);
			}
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null && (Object)(object)mod1.sprite == (Object)null)
			{
				((Component)mod1).gameObject.SetActive(false);
			}
			if ((Object)(object)mod2 != (Object)null && (Object)(object)mod2.sprite == (Object)null)
			{
				((Component)mod2).gameObject.SetActive(false);
			}
			if ((Object)(object)mod3 != (Object)null && (Object)(object)mod3.sprite == (Object)null)
			{
				((Component)mod3).gameObject.SetActive(false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null && (Object)(object)modSP1.sprite == (Object)null)
			{
				((Component)modSP1).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP2 != (Object)null && (Object)(object)modSP2.sprite == (Object)null)
			{
				((Component)modSP2).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP3 != (Object)null && (Object)(object)modSP3.sprite == (Object)null)
			{
				((Component)modSP3).gameObject.SetActive(true);
			}
		}
		DJPNGKIBJDO = false;
		updateStackTextThisFrame = false;
		updateIconThisFrame = false;
	}

	public void BNLPKMDLMDB(Slot EFDPGNOICOG, int FIBNOKJKNLD)
	{
		if (IPIMOBOFHBF)
		{
			IHENCGDNPBL.HPNGCKBCAKD(JIIGOACEIKL);
			Slot.KAHHHGOHGKE(JIIGOACEIKL, EFDPGNOICOG, IHENCGDNPBL, FIBNOKJKNLD);
			JOGLJKIFGNL();
			IPIMOBOFHBF = true;
			((MonoBehaviour)this).StartCoroutine(MLCCGGIJGEC());
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				Slot[] array = new Slot[0];
				array[1] = EFDPGNOICOG;
				array[0] = IHENCGDNPBL;
				instance.SendSlots(array);
			}
		}
		TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL);
		transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Remove(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(MGLHJODBJBF));
	}

	public void GMNDKOOGDGI(PointerEventData NPBAMEMNFBI)
	{
		if (showTooltipInfo && CursorManager.CMDGPJEIIJI(JIIGOACEIKL).IsCursorVisible())
		{
			FillTooltip(JIIGOACEIKL);
		}
	}

	protected virtual void GJDPLEIAEBH(Slot ADEBNALPEHE)
	{
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		if (!EODGJAJJFLJ)
		{
			CPFDLKMCBCB();
		}
		if (ADEBNALPEHE == null)
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = false;
			}
			nonInteractable = true;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("Focused", false);
			}
		}
		else
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = true;
			}
			nonInteractable = initialNonInteractable;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("Focused", ADEBNALPEHE.focused);
			}
		}
		if (ADEBNALPEHE != null && ADEBNALPEHE.KPINNBKMOMO() && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL)) && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.Equals(ADEBNALPEHE) && Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
		{
			((Selectable)button).animator.SetBool("Focused", false);
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null)
			{
				mod1.sprite = null;
			}
			if ((Object)(object)mod2 != (Object)null)
			{
				mod2.sprite = null;
			}
			if ((Object)(object)mod3 != (Object)null)
			{
				mod3.sprite = null;
			}
			if (Object.op_Implicit((Object)(object)bubbleWant))
			{
				bubbleWant.ShowModifiers(NJHMBMGKCPL: false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null)
			{
				modSP1.sprite = null;
			}
			if ((Object)(object)modSP2 != (Object)null)
			{
				modSP2.sprite = null;
			}
			if ((Object)(object)modSP3 != (Object)null)
			{
				modSP3.sprite = null;
			}
		}
		if (ADEBNALPEHE == null || ADEBNALPEHE.itemInstance == null || Item.NGIIPJDAMGP(ADEBNALPEHE.itemInstance.LHBPOPOIFLE(), null))
		{
			if (((Component)icon).gameObject.activeSelf && updateIconThisFrame && !noItemInstance)
			{
				((Component)icon).gameObject.SetActive(false);
				if ((Object)(object)agingRank != (Object)null && ((Component)agingRank).gameObject.activeSelf)
				{
					((Component)agingRank).gameObject.SetActive(false);
				}
				if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(false);
				}
			}
			if (Object.op_Implicit((Object)(object)stackText) && ((Component)stackText).gameObject.activeSelf)
			{
				((Component)stackText).gameObject.SetActive(false);
			}
		}
		else
		{
			if (updateIconThisFrame)
			{
				icon.hasMod = ADEBNALPEHE.itemInstance is IModifiable { KEKBKGGFOLK: not null } modifiable && modifiable.KEKBKGGFOLK.Count > 0;
				icon.HLPNOAENFHK = ADEBNALPEHE.itemInstance;
				((Component)icon).gameObject.SetActive(true);
				if (icon.HLPNOAENFHK is FoodInstance foodInstance && foodInstance.AJOMICMACEJ.canBeSold)
				{
					if ((Object)(object)qualityLevel != (Object)null)
					{
						if (!((Component)qualityLevel).gameObject.activeSelf)
						{
							((Component)qualityLevel).gameObject.SetActive(true);
						}
						if ((Object)(object)CommonReferences.GGFJGHHHEJC.qualityLevelSprites[foodInstance.GHFDCAOBJMK] != (Object)(object)qualityLevel.sprite)
						{
							qualityLevel.sprite = CommonReferences.GGFJGHHHEJC.qualityLevelSprites[foodInstance.GHFDCAOBJMK];
							((Graphic)qualityLevel).SetNativeSize();
						}
					}
				}
				else if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(false);
				}
				if ((Object)(object)agingRank != (Object)null && OBLDEJIPFEJ)
				{
					if (icon.HLPNOAENFHK is FoodInstance { GBCJNGADANM: >0 } foodInstance2 && (foodInstance2.LHBPOPOIFLE().canBeAged || (Object.op_Implicit((Object)(object)foodInstance2.LHBPOPOIFLE().recipe) && foodInstance2.LHBPOPOIFLE().recipe.EFJKIOMELOB())))
					{
						((Component)agingRank).gameObject.SetActive(true);
						if (ADEBNALPEHE.itemInstance.LHBPOPOIFLE().hasToBeAgedMeal)
						{
							agingRank.sprite = CommonReferences.GGFJGHHHEJC.agingRankRed;
						}
						else
						{
							agingRank.sprite = CommonReferences.GGFJGHHHEJC.agingRankSprite[foodInstance2.GBCJNGADANM - 1];
						}
					}
					else if (!icon.HLPNOAENFHK.LHBPOPOIFLE().hasToBeAgedMeal && icon.HLPNOAENFHK is FoodInstance foodInstance3 && foodInstance3.LHBPOPOIFLE().ingredientType == IngredientType.Cheese)
					{
						((Component)agingRank).gameObject.SetActive(true);
						agingRank.sprite = CommonReferences.GGFJGHHHEJC.agingRankRed;
					}
					else if (ADEBNALPEHE.itemInstance.LHBPOPOIFLE().hasToBeAgedMeal || (ADEBNALPEHE.itemInstance.JEPBBEBJEFI() && ADEBNALPEHE.itemInstance is FoodInstance foodInstance4 && foodInstance4.LHBPOPOIFLE().canBeAged))
					{
						((Component)agingRank).gameObject.SetActive(true);
						agingRank.sprite = CommonReferences.GGFJGHHHEJC.agingRankNeeded;
					}
					else
					{
						((Component)agingRank).gameObject.SetActive(false);
					}
				}
				if ((Object)(object)agingRank != (Object)null && !OBLDEJIPFEJ)
				{
					((Component)agingRank).gameObject.SetActive(false);
				}
			}
			if ((Object)(object)stackText != (Object)null && (Object)(object)((Component)stackText).gameObject != (Object)null && updateStackTextThisFrame && !AAADBMJJBHO)
			{
				((Component)stackText).gameObject.SetActive(showAlwaysStack || ADEBNALPEHE.Stack > 1);
				((TMP_Text)stackText).text = ADEBNALPEHE.Stack.ToString();
				((Graphic)stackText).color = ((ADEBNALPEHE.Stack == 0) ? Color.red : Color.white);
			}
			if (ADEBNALPEHE.itemInstance is IngredientGroupInstance { chosenItemInstance: not null, chosenItemInstance: IModifiable chosenItemInstance })
			{
				PAIENKDMCNG(chosenItemInstance);
			}
			else if (ADEBNALPEHE.itemInstance is IModifiable mMDOGPKGPKL)
			{
				PAIENKDMCNG(mMDOGPKGPKL);
			}
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null && (Object)(object)mod1.sprite == (Object)null)
			{
				((Component)mod1).gameObject.SetActive(false);
			}
			if ((Object)(object)mod2 != (Object)null && (Object)(object)mod2.sprite == (Object)null)
			{
				((Component)mod2).gameObject.SetActive(false);
			}
			if ((Object)(object)mod3 != (Object)null && (Object)(object)mod3.sprite == (Object)null)
			{
				((Component)mod3).gameObject.SetActive(false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null && (Object)(object)modSP1.sprite == (Object)null)
			{
				((Component)modSP1).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP2 != (Object)null && (Object)(object)modSP2.sprite == (Object)null)
			{
				((Component)modSP2).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP3 != (Object)null && (Object)(object)modSP3.sprite == (Object)null)
			{
				((Component)modSP3).gameObject.SetActive(false);
			}
		}
		DJPNGKIBJDO = false;
		updateStackTextThisFrame = true;
		updateIconThisFrame = true;
	}

	public void JEKABEJHKFP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL);
			transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Combine(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(ENBHBBCCLDE));
			IPIMOBOFHBF = true;
		}
	}

	private Container JKMLFFOHBMJ(int JIIGOACEIKL)
	{
		if (BigContainerUI.EIMDPBGBBIF(JIIGOACEIKL).IsOpen())
		{
			return BigContainerUI.AANKLOIDPOA(JIIGOACEIKL).EAHMDMDHLMH();
		}
		if (SmallContainerUI.NIGDBMAOAEN(JIIGOACEIKL).IsOpen())
		{
			return SmallContainerUI.FFOABBDFMNE(JIIGOACEIKL).EDPIANLDIDG();
		}
		return null;
	}

	public virtual bool MouseUp()
	{
		return true;
	}

	private void CBBEPDOBLFC(int JIIGOACEIKL)
	{
		TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL).KPELHBMAGDG(slot);
		TransferItemSliderUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
		AddUnselectedTransferListener(JIIGOACEIKL);
	}

	public virtual void OINBJMOCOIF(BaseEventData NPBAMEMNFBI)
	{
		if (!nonInteractable && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			HPHGAHGALGA(NKFPJPCFBJI: true, JIIGOACEIKL);
			DCLHPEKAFIL();
		}
	}

	protected void CCNJHDMGANI(bool NKFPJPCFBJI, int JIIGOACEIKL)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.MHOKIBDMIPL(JIIGOACEIKL).DLCCNCLHBJP(NKFPJPCFBJI);
		if (NKFPJPCFBJI)
		{
			FocusArrowUI.PJIGCLMPHKP(JIIGOACEIKL).LCNKCFOMGAP(((Component)HMDFBECLNFM).transform.position);
		}
	}

	private Container FLBPFLKDGPA(int JIIGOACEIKL)
	{
		if (BigContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			return BigContainerUI.Get(JIIGOACEIKL).ALPOKDOCCGM;
		}
		if (SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			return SmallContainerUI.Get(JIIGOACEIKL).ALPOKDOCCGM;
		}
		return null;
	}

	public void ResetSpritesMods()
	{
		if (Object.op_Implicit((Object)(object)modSP1))
		{
			modSP1.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)modSP2))
		{
			modSP2.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)modSP3))
		{
			modSP3.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)mod1))
		{
			mod1.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)mod2))
		{
			mod2.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)mod3))
		{
			mod3.sprite = null;
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null && (Object)(object)mod1.sprite == (Object)null)
			{
				((Component)mod1).gameObject.SetActive(false);
			}
			if ((Object)(object)mod2 != (Object)null && (Object)(object)mod2.sprite == (Object)null)
			{
				((Component)mod2).gameObject.SetActive(false);
			}
			if ((Object)(object)mod3 != (Object)null && (Object)(object)mod3.sprite == (Object)null)
			{
				((Component)mod3).gameObject.SetActive(false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null && (Object)(object)modSP1.sprite == (Object)null)
			{
				((Component)modSP1).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP2 != (Object)null && (Object)(object)modSP2.sprite == (Object)null)
			{
				((Component)modSP2).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP3 != (Object)null && (Object)(object)modSP3.sprite == (Object)null)
			{
				((Component)modSP3).gameObject.SetActive(false);
			}
		}
		if (Object.op_Implicit((Object)(object)bubbleWant))
		{
			bubbleWant.ShowModifiers(NJHMBMGKCPL: false);
		}
	}

	public void DCLHPEKAFIL()
	{
		ILENDIBNCBP = false;
		if (Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
	}

	public void ENBHBBCCLDE(Slot EFDPGNOICOG, int FIBNOKJKNLD)
	{
		if (IPIMOBOFHBF)
		{
			IHENCGDNPBL.AFPAJHJIHJD(JIIGOACEIKL);
			Slot.KAHHHGOHGKE(JIIGOACEIKL, EFDPGNOICOG, IHENCGDNPBL, FIBNOKJKNLD);
			PAMDPKDMLGC();
			IPIMOBOFHBF = false;
			((MonoBehaviour)this).StartCoroutine(MLCCGGIJGEC());
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				Slot[] array = new Slot[7];
				array[1] = EFDPGNOICOG;
				array[1] = IHENCGDNPBL;
				instance.LKCOAKJICDB(array);
			}
		}
		TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.Get(JIIGOACEIKL);
		transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Remove(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(JBNDILJABLO));
	}

	public void CKGODCPIEIG(BaseEventData NPBAMEMNFBI)
	{
		if (nonInteractable || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || autoTransferEnabled)
		{
			return;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot;
			if (focusedSlot == null)
			{
				return;
			}
			focusedSlot.HPNGCKBCAKD(JIIGOACEIKL);
			if (!focusedSlot.Equals(slot))
			{
				if (focusedSlot.BOMLNEOHFOK(slot.itemInstance))
				{
					Slot.PDKCLKKHNOH(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
				}
				else
				{
					Slot.GHCDPAJHKOI(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
					KGAOFNHILNM(JIIGOACEIKL);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager.instance.PKOLALFLFNB(new Slot[5] { IHENCGDNPBL, focusedSlot, null, null, null }, 1);
				}
			}
		}
		else if (!IHENCGDNPBL.AHHEMNHJPME())
		{
			IHENCGDNPBL.COHKJDGJMHN(JIIGOACEIKL);
		}
	}

	public void OnDrag(PointerEventData NPBAMEMNFBI)
	{
	}

	public void FMFJMAAOAGI(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if ((!nonInteractable || draggingEnabled) && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.MNFMOEKMJKN().OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
			FillTooltip(JIIGOACEIKL);
		}
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		if (showTooltipInfo && CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			FillTooltip(JIIGOACEIKL);
		}
	}

	protected virtual void AOEIDGIBBFA(Slot ADEBNALPEHE)
	{
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		if (!EODGJAJJFLJ)
		{
			BEMHJMDDNKC();
		}
		if (ADEBNALPEHE == null)
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = false;
			}
			nonInteractable = false;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("", true);
			}
		}
		else
		{
			if ((Object)(object)button != (Object)null)
			{
				((Selectable)button).interactable = false;
			}
			nonInteractable = initialNonInteractable;
			if (Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
			{
				((Selectable)button).animator.SetBool("\\[BartenderGender=[^\\]]*\\]", ADEBNALPEHE.MHFGNKBIPCN());
			}
		}
		if (ADEBNALPEHE != null && ADEBNALPEHE.KPINNBKMOMO() && Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL)) && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.Equals(ADEBNALPEHE) && Object.op_Implicit((Object)(object)button) && Object.op_Implicit((Object)(object)((Selectable)button).animator) && ((Selectable)button).animator.isInitialized && ((Behaviour)((Selectable)button).animator).isActiveAndEnabled)
		{
			((Selectable)button).animator.SetBool("Club", false);
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null)
			{
				mod1.sprite = null;
			}
			if ((Object)(object)mod2 != (Object)null)
			{
				mod2.sprite = null;
			}
			if ((Object)(object)mod3 != (Object)null)
			{
				mod3.sprite = null;
			}
			if (Object.op_Implicit((Object)(object)bubbleWant))
			{
				bubbleWant.CBEEBAGEKMH(NJHMBMGKCPL: false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null)
			{
				modSP1.sprite = null;
			}
			if ((Object)(object)modSP2 != (Object)null)
			{
				modSP2.sprite = null;
			}
			if ((Object)(object)modSP3 != (Object)null)
			{
				modSP3.sprite = null;
			}
		}
		if (ADEBNALPEHE == null || ADEBNALPEHE.itemInstance == null || Item.EKMFELLJHFG(ADEBNALPEHE.itemInstance.KNFNJFFCFNO(), null))
		{
			if (((Component)icon).gameObject.activeSelf && updateIconThisFrame && !noItemInstance)
			{
				((Component)icon).gameObject.SetActive(false);
				if ((Object)(object)agingRank != (Object)null && ((Component)agingRank).gameObject.activeSelf)
				{
					((Component)agingRank).gameObject.SetActive(false);
				}
				if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(false);
				}
			}
			if (Object.op_Implicit((Object)(object)stackText) && ((Component)stackText).gameObject.activeSelf)
			{
				((Component)stackText).gameObject.SetActive(true);
			}
		}
		else
		{
			if (updateIconThisFrame)
			{
				icon.hasMod = !(ADEBNALPEHE.itemInstance is IModifiable { KEKBKGGFOLK: not null } modifiable) || modifiable.KEKBKGGFOLK.Count > 1;
				icon.HLPNOAENFHK = ADEBNALPEHE.itemInstance;
				((Component)icon).gameObject.SetActive(true);
				if (icon.LHLPGEEPJMP() is FoodInstance foodInstance && foodInstance.OANEHEHELGB().canBeSold)
				{
					if ((Object)(object)qualityLevel != (Object)null)
					{
						if (!((Component)qualityLevel).gameObject.activeSelf)
						{
							((Component)qualityLevel).gameObject.SetActive(false);
						}
						if ((Object)(object)CommonReferences.MNFMOEKMJKN().qualityLevelSprites[foodInstance.GHFDCAOBJMK] != (Object)(object)qualityLevel.sprite)
						{
							qualityLevel.sprite = CommonReferences.MNFMOEKMJKN().qualityLevelSprites[foodInstance.GHFDCAOBJMK];
							((Graphic)qualityLevel).SetNativeSize();
						}
					}
				}
				else if ((Object)(object)qualityLevel != (Object)null && ((Component)qualityLevel).gameObject.activeSelf)
				{
					((Component)qualityLevel).gameObject.SetActive(false);
				}
				if ((Object)(object)agingRank != (Object)null && OBLDEJIPFEJ)
				{
					if (icon.IONBKJOCAPF() is FoodInstance { GBCJNGADANM: >1 } foodInstance2 && (foodInstance2.LHBPOPOIFLE().canBeAged || (Object.op_Implicit((Object)(object)foodInstance2.LHBPOPOIFLE().recipe) && foodInstance2.LHBPOPOIFLE().recipe.EFJKIOMELOB())))
					{
						((Component)agingRank).gameObject.SetActive(false);
						if (ADEBNALPEHE.itemInstance.LHBPOPOIFLE().hasToBeAgedMeal)
						{
							agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankRed;
						}
						else
						{
							agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankSprite[foodInstance2.GBCJNGADANM - 0];
						}
					}
					else if (!icon.LDJJDJPKPBD().KNFNJFFCFNO().hasToBeAgedMeal && icon.LDJJDJPKPBD() is FoodInstance foodInstance3 && foodInstance3.LHBPOPOIFLE().ingredientType == IngredientType.Yeast)
					{
						((Component)agingRank).gameObject.SetActive(true);
						agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankRed;
					}
					else if (ADEBNALPEHE.itemInstance.PHGLMBIEOMK().hasToBeAgedMeal || (ADEBNALPEHE.itemInstance.IJLGJNLFNDB() && ADEBNALPEHE.itemInstance is FoodInstance foodInstance4 && foodInstance4.LHBPOPOIFLE().canBeAged))
					{
						((Component)agingRank).gameObject.SetActive(false);
						agingRank.sprite = CommonReferences.MNFMOEKMJKN().agingRankNeeded;
					}
					else
					{
						((Component)agingRank).gameObject.SetActive(false);
					}
				}
				if ((Object)(object)agingRank != (Object)null && !OBLDEJIPFEJ)
				{
					((Component)agingRank).gameObject.SetActive(false);
				}
			}
			if ((Object)(object)stackText != (Object)null && (Object)(object)((Component)stackText).gameObject != (Object)null && updateStackTextThisFrame && !AAADBMJJBHO)
			{
				((Component)stackText).gameObject.SetActive(showAlwaysStack || ADEBNALPEHE.Stack > 0);
				((TMP_Text)stackText).text = ADEBNALPEHE.Stack.ToString();
				((Graphic)stackText).color = ((ADEBNALPEHE.Stack == 0) ? Color.red : Color.white);
			}
			if (ADEBNALPEHE.itemInstance is IngredientGroupInstance { chosenItemInstance: not null, chosenItemInstance: IModifiable chosenItemInstance })
			{
				PAIENKDMCNG(chosenItemInstance);
			}
			else if (ADEBNALPEHE.itemInstance is IModifiable mMDOGPKGPKL)
			{
				PAIENKDMCNG(mMDOGPKGPKL);
			}
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null && (Object)(object)mod1.sprite == (Object)null)
			{
				((Component)mod1).gameObject.SetActive(false);
			}
			if ((Object)(object)mod2 != (Object)null && (Object)(object)mod2.sprite == (Object)null)
			{
				((Component)mod2).gameObject.SetActive(false);
			}
			if ((Object)(object)mod3 != (Object)null && (Object)(object)mod3.sprite == (Object)null)
			{
				((Component)mod3).gameObject.SetActive(false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null && (Object)(object)modSP1.sprite == (Object)null)
			{
				((Component)modSP1).gameObject.SetActive(true);
			}
			if ((Object)(object)modSP2 != (Object)null && (Object)(object)modSP2.sprite == (Object)null)
			{
				((Component)modSP2).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP3 != (Object)null && (Object)(object)modSP3.sprite == (Object)null)
			{
				((Component)modSP3).gameObject.SetActive(false);
			}
		}
		DJPNGKIBJDO = false;
		updateStackTextThisFrame = false;
		updateIconThisFrame = false;
	}

	public virtual void BBDFBFKIOCK(BaseEventData NPBAMEMNFBI)
	{
		if (!nonInteractable && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			FillTooltip(JIIGOACEIKL);
			CCNJHDMGANI(NKFPJPCFBJI: false, JIIGOACEIKL);
		}
	}

	[SpecialName]
	public void LIJPNDJCKGL(Slot AODONKKHPBP)
	{
		if (slot != null)
		{
			Slot obj = slot;
			obj.OnDirtied = (Action)Delegate.Remove(obj.OnDirtied, new Action(PDPFLAKIMKL));
			SlotManager.LBKPBFMEDLE(slot);
		}
		slot = AODONKKHPBP;
		if (slot != null)
		{
			SlotManager.MFOEGLBHALK(slot);
			Slot obj2 = slot;
			obj2.OnDirtied = (Action)Delegate.Combine(obj2.OnDirtied, new Action(PAMDPKDMLGC));
		}
		PAMDPKDMLGC();
	}

	private void OOLFIJEGODP(int JIIGOACEIKL, Slot EFDPGNOICOG)
	{
		TransferItemSliderUI.Get(JIIGOACEIKL).SetSlot(EFDPGNOICOG);
		TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL).OpenUI();
		AIELKAHABBH(JIIGOACEIKL);
	}

	public void OnSubmit(BaseEventData NPBAMEMNFBI)
	{
		if (nonInteractable || !PlayerInputs.IsGamepadActive(JIIGOACEIKL) || autoTransferEnabled)
		{
			return;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot;
			if (focusedSlot == null)
			{
				return;
			}
			focusedSlot.AFPAJHJIHJD(JIIGOACEIKL);
			if (!focusedSlot.Equals(slot))
			{
				if (focusedSlot.BOMLNEOHFOK(slot.itemInstance))
				{
					Slot.NFBAGDKBOAD(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
				}
				else
				{
					Slot.GHCDPAJHKOI(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
					FillTooltip(JIIGOACEIKL);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager.instance.SendSlots(new Slot[2] { IHENCGDNPBL, focusedSlot });
				}
			}
		}
		else if (!IHENCGDNPBL.KPINNBKMOMO())
		{
			IHENCGDNPBL.LHOEAOFOFCO(JIIGOACEIKL);
		}
	}

	public void FPMJAKBLAJN(PointerEventData NPBAMEMNFBI)
	{
	}

	public virtual void PDPFLAKIMKL()
	{
		if (((Component)GameplayUI.NGIMIHFFNMH()).gameObject.activeInHierarchy)
		{
			ADOBMMENIMI(slot);
		}
	}

	public void PNLMGEONMBO(PointerEventData NPBAMEMNFBI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)NPBAMEMNFBI.button == 0)
		{
			OnSlotRightClick(JIIGOACEIKL, IHENCGDNPBL);
			FillTooltip(JIIGOACEIKL);
		}
		else if (!nonInteractable && ILENDIBNCBP && (int)NPBAMEMNFBI.button == 0)
		{
			OnSlotLeftClickDown(JIIGOACEIKL, IHENCGDNPBL);
		}
	}

	public void MGLHJODBJBF(Slot EFDPGNOICOG, int FIBNOKJKNLD)
	{
		if (IPIMOBOFHBF)
		{
			IHENCGDNPBL.DAOFEOFLDIG(JIIGOACEIKL);
			Slot.IJDEHCDAAHF(JIIGOACEIKL, EFDPGNOICOG, IHENCGDNPBL, FIBNOKJKNLD);
			PAMDPKDMLGC();
			IPIMOBOFHBF = false;
			((MonoBehaviour)this).StartCoroutine(BJKEBPABFCD());
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				Slot[] array = new Slot[8];
				array[0] = EFDPGNOICOG;
				array[0] = IHENCGDNPBL;
				instance.MPMAHFAFGNL(array, 1);
			}
		}
		TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.NIDHCIHFOHB(JIIGOACEIKL);
		transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Remove(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(JBNDILJABLO));
	}

	private Container GKAJDFIECAI(int JIIGOACEIKL)
	{
		if (BigContainerUI.ILDNNNMOCOC(JIIGOACEIKL).HDEPMJIDJEM())
		{
			return BigContainerUI.PHDBJGOEKHB(JIIGOACEIKL).LHCMGHKILLJ();
		}
		if (SmallContainerUI.NIGDBMAOAEN(JIIGOACEIKL).IsOpen())
		{
			return SmallContainerUI.AEJKCONFPHB(JIIGOACEIKL).ALPOKDOCCGM;
		}
		return null;
	}

	public void OnDrop(PointerEventData NPBAMEMNFBI)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if ((!nonInteractable || draggingEnabled) && (int)NPBAMEMNFBI.button == 0)
		{
			CommonReferences.GGFJGHHHEJC.OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
			FillTooltip(JIIGOACEIKL);
		}
	}

	private void CPFDLKMCBCB()
	{
		if (!EODGJAJJFLJ)
		{
			JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
			if (!JGNIDGOOLNC)
			{
				JGNIDGOOLNC = true;
				initialNonInteractable = nonInteractable;
				IHENCGDNPBL = slot;
			}
			button = ((Component)((Component)this).transform).GetComponent<Button>();
			HMDFBECLNFM = ((Component)((Component)this).transform).GetComponent<RectTransform>();
			SaveUI instance = SaveUI.instance;
			instance.OnLoadFadeOutStart = (Action)Delegate.Combine(instance.OnLoadFadeOutStart, new Action(UpdateSlot));
			EODGJAJJFLJ = true;
		}
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		if (showTooltipInfo && CursorManager.GetPlayer(JIIGOACEIKL).IsCursorVisible())
		{
			EndHover();
		}
	}

	public void OJIAJLBFLCN(int JIIGOACEIKL, bool HIOAJHJNCPO)
	{
		if (!((Object)(object)button == (Object)null) && ((Behaviour)button).isActiveAndEnabled && !((Object)(object)((Selectable)button).animator == (Object)null) && ((Selectable)button).animator.isInitialized)
		{
			switch (JIIGOACEIKL)
			{
			case 1:
				((Selectable)button).animator.SetBool("Drink", HIOAJHJNCPO);
				break;
			case 4:
				((Selectable)button).animator.SetBool("Dialogue System/Conversation/Gass_Introduce/Entry/18/Dialogue Text", HIOAJHJNCPO);
				break;
			}
		}
	}

	public void TransferItemWithSliderUIUnselected(Slot EFDPGNOICOG, int FIBNOKJKNLD)
	{
		if (!IPIMOBOFHBF)
		{
			return;
		}
		slot.AFPAJHJIHJD(JIIGOACEIKL);
		if (slot.inventoryType == ContainerType.ActionBar || slot.inventoryType == ContainerType.Inventory)
		{
			Container container = FLBPFLKDGPA(JIIGOACEIKL);
			if ((Object)(object)container != (Object)null)
			{
				if (container.CanFitItems(slot.itemInstance, FIBNOKJKNLD))
				{
					container.AddItemInstances(JIIGOACEIKL, slot.itemInstance, FIBNOKJKNLD);
					slot.FDOBDPPMMBH(FIBNOKJKNLD, CDPAMNIPPEC: true);
				}
				else
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
				}
			}
			else if (slot.inventoryType == ContainerType.ActionBar)
			{
				if (PlayerInventory.GetPlayer(JIIGOACEIKL).inventory.CanFitItems(slot.itemInstance, FIBNOKJKNLD))
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL).inventory.AddItemInstances(JIIGOACEIKL, slot.itemInstance, FIBNOKJKNLD);
					slot.FDOBDPPMMBH(FIBNOKJKNLD, CDPAMNIPPEC: true);
				}
				else
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
				}
			}
			else if (slot.inventoryType == ContainerType.Inventory)
			{
				if (PlayerInventory.GetPlayer(JIIGOACEIKL).actionBarInventory.CanFitItems(slot.itemInstance, FIBNOKJKNLD))
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL).actionBarInventory.AddItemInstances(JIIGOACEIKL, slot.itemInstance, FIBNOKJKNLD);
					slot.FDOBDPPMMBH(FIBNOKJKNLD, CDPAMNIPPEC: true);
				}
				else
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
				}
			}
		}
		else if (PlayerInventory.GetPlayer(JIIGOACEIKL).CanFitItemsInPlayerInventory(slot.itemInstance, FIBNOKJKNLD))
		{
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(slot.itemInstance, FIBNOKJKNLD, HMPDLIPFBGD: false, EHGHJNOFMKF: false, !(slot.itemInstance.LHBPOPOIFLE() is Tool));
			slot.FDOBDPPMMBH(FIBNOKJKNLD, CDPAMNIPPEC: true);
		}
		else
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
		}
		UpdateSlot();
		IPIMOBOFHBF = false;
		((MonoBehaviour)this).StartCoroutine(CGNNMDCCKEH());
		TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.Get(JIIGOACEIKL);
		transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Remove(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(TransferItemWithSliderUIUnselected));
	}

	public void AEEPEBLIMJN(PointerEventData NPBAMEMNFBI)
	{
		if (showTooltipInfo && CursorManager.GetPlayer(JIIGOACEIKL).LALPELGNIJB())
		{
			KGAOFNHILNM(JIIGOACEIKL);
		}
	}

	public virtual void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (!nonInteractable && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			EGHPILDBOIB(NKFPJPCFBJI: false, JIIGOACEIKL);
			EndHover();
		}
	}

	public virtual void UpdateSlot()
	{
		if (((Component)GameplayUI.GGFJGHHHEJC).gameObject.activeInHierarchy)
		{
			GJDPLEIAEBH(slot);
		}
	}

	public void LPLKIAKNEED(int JIIGOACEIKL, bool HIOAJHJNCPO)
	{
		if (!((Object)(object)button == (Object)null) && ((Behaviour)button).isActiveAndEnabled && !((Object)(object)((Selectable)button).animator == (Object)null) && ((Selectable)button).animator.isInitialized)
		{
			switch (JIIGOACEIKL)
			{
			case 0:
				((Selectable)button).animator.SetBool("", HIOAJHJNCPO);
				break;
			case 7:
				((Selectable)button).animator.SetBool("[GetFallbackCandidates] Added inactive spawner {0} from piece {1}", HIOAJHJNCPO);
				break;
			}
		}
	}

	public void PPPICFBGPBE()
	{
		if (Object.op_Implicit((Object)(object)modSP1))
		{
			modSP1.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)modSP2))
		{
			modSP2.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)modSP3))
		{
			modSP3.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)mod1))
		{
			mod1.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)mod2))
		{
			mod2.sprite = null;
		}
		if (Object.op_Implicit((Object)(object)mod3))
		{
			mod3.sprite = null;
		}
		if (unityUI)
		{
			if ((Object)(object)mod1 != (Object)null && (Object)(object)mod1.sprite == (Object)null)
			{
				((Component)mod1).gameObject.SetActive(false);
			}
			if ((Object)(object)mod2 != (Object)null && (Object)(object)mod2.sprite == (Object)null)
			{
				((Component)mod2).gameObject.SetActive(false);
			}
			if ((Object)(object)mod3 != (Object)null && (Object)(object)mod3.sprite == (Object)null)
			{
				((Component)mod3).gameObject.SetActive(false);
			}
		}
		else
		{
			if ((Object)(object)modSP1 != (Object)null && (Object)(object)modSP1.sprite == (Object)null)
			{
				((Component)modSP1).gameObject.SetActive(true);
			}
			if ((Object)(object)modSP2 != (Object)null && (Object)(object)modSP2.sprite == (Object)null)
			{
				((Component)modSP2).gameObject.SetActive(false);
			}
			if ((Object)(object)modSP3 != (Object)null && (Object)(object)modSP3.sprite == (Object)null)
			{
				((Component)modSP3).gameObject.SetActive(false);
			}
		}
		if (Object.op_Implicit((Object)(object)bubbleWant))
		{
			bubbleWant.HCBFOIMENJP(NJHMBMGKCPL: false);
		}
	}

	public void TransferItemWithSliderUI(Slot EFDPGNOICOG, int FIBNOKJKNLD)
	{
		if (IPIMOBOFHBF)
		{
			IHENCGDNPBL.AFPAJHJIHJD(JIIGOACEIKL);
			Slot.IJDEHCDAAHF(JIIGOACEIKL, EFDPGNOICOG, IHENCGDNPBL, FIBNOKJKNLD);
			UpdateSlot();
			IPIMOBOFHBF = false;
			((MonoBehaviour)this).StartCoroutine(CGNNMDCCKEH());
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.SendSlots(new Slot[2] { EFDPGNOICOG, IHENCGDNPBL });
			}
		}
		TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.Get(JIIGOACEIKL);
		transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Remove(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(TransferItemWithSliderUI));
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	protected void ICGOPHNHFMO(int JIIGOACEIKL)
	{
		OnSlotLeftClick(JIIGOACEIKL, IHENCGDNPBL);
	}

	public void FLMJLOIKEEN()
	{
		ILENDIBNCBP = true;
		if (Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
	}

	public void SetIsTransferSlot()
	{
		AAADBMJJBHO = true;
		((Component)stackText).gameObject.SetActive(true);
	}

	public void SetCanAgeRankBeVisible(bool LGBDFAJMDGC)
	{
		OBLDEJIPFEJ = LGBDFAJMDGC;
	}

	public void FillTooltip(int JIIGOACEIKL)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		if (IHENCGDNPBL != null && IHENCGDNPBL.itemInstance != null && Item.MLBOMGHINCA(IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = true;
				HAHAPELLAIO = 0f;
			}
			if (HAHAPELLAIO >= ItemTooltip.delayTime)
			{
				if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
				{
					ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true, IHENCGDNPBL.itemInstance);
					ItemTooltip.Get(JIIGOACEIKL).SetItemInstance(JIIGOACEIKL, IHENCGDNPBL.itemInstance, IHENCGDNPBL.CalculatePriceWithUniqueItems, addCurrentItems, showAge);
				}
				else
				{
					ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Component)this).transform.position.x + 45f, ((Component)this).transform.position.y + 18f * ((Component)this).transform.lossyScale.y), Vector2.right * 75f, IHENCGDNPBL.itemInstance);
					ItemTooltip.Get(JIIGOACEIKL).SetItemInstance(JIIGOACEIKL, IHENCGDNPBL.itemInstance, IHENCGDNPBL.CalculatePriceWithUniqueItems, addCurrentItems, showAge);
				}
				HAHAPELLAIO = float.MaxValue;
			}
		}
		else
		{
			ILENDIBNCBP = true;
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public virtual void JOGLJKIFGNL()
	{
		if (((Component)GameplayUI.NGIMIHFFNMH()).gameObject.activeInHierarchy)
		{
			CGBDLLEOEKB(slot);
		}
	}

	public void AIELKAHABBH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == this.JIIGOACEIKL)
		{
			TransferItemSliderUI transferItemSliderUI = TransferItemSliderUI.Get(JIIGOACEIKL);
			transferItemSliderUI.OnTransferSelected = (Action<Slot, int>)Delegate.Combine(transferItemSliderUI.OnTransferSelected, new Action<Slot, int>(MGLHJODBJBF));
			IPIMOBOFHBF = false;
		}
	}

	public void OnPointerUp(PointerEventData NPBAMEMNFBI)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (nonInteractable || GameManager.NoPlayers() || IHENCGDNPBL == null || !ILENDIBNCBP || (int)NPBAMEMNFBI.button != 0)
		{
			return;
		}
		if (FGNLIEANHLB)
		{
			CommonReferences.GGFJGHHHEJC.OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
			FillTooltip(JIIGOACEIKL);
			return;
		}
		if (MouseSlot.IsSlotEmpty(1))
		{
			OnSlotLeftClick(JIIGOACEIKL, IHENCGDNPBL);
		}
		CommonReferences.GGFJGHHHEJC.OnAnySlotLeftClick(JIIGOACEIKL, IHENCGDNPBL, draggingEnabled);
		FillTooltip(JIIGOACEIKL);
	}

	public void GBBICAKFMJK(BaseEventData NPBAMEMNFBI)
	{
		if (nonInteractable || !PlayerInputs.IsGamepadActive(JIIGOACEIKL) || autoTransferEnabled)
		{
			return;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			Slot focusedSlot = SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot;
			if (focusedSlot == null)
			{
				return;
			}
			focusedSlot.AFPAJHJIHJD(JIIGOACEIKL);
			if (!focusedSlot.Equals(slot))
			{
				if (focusedSlot.BOMLNEOHFOK(slot.itemInstance))
				{
					Slot.PDKCLKKHNOH(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
				}
				else
				{
					Slot.GHCDPAJHKOI(JIIGOACEIKL, focusedSlot, IHENCGDNPBL);
					KGAOFNHILNM(JIIGOACEIKL);
				}
				if (OnlineManager.PlayingOnline())
				{
					OnlineSlotsManager instance = OnlineSlotsManager.instance;
					Slot[] array = new Slot[3];
					array[1] = IHENCGDNPBL;
					array[1] = focusedSlot;
					instance.SendSlots(array);
				}
			}
		}
		else if (!IHENCGDNPBL.AHHEMNHJPME())
		{
			IHENCGDNPBL.EKDPBPHFFGJ(JIIGOACEIKL);
		}
	}
}
