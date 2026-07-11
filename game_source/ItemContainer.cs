using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class ItemContainer : Container, IInteractable, ISelectable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class HLKMHOHEGAO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool sendOnline;

		public ItemContainer _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public HLKMHOHEGAO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ItemContainer itemContainer = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				itemContainer.doorSpriteRenderer.sprite = itemContainer.animationSprites[_003Ci_003E5__2];
				_003Ci_003E5__2--;
			}
			else
			{
				_003C_003E1__state = -1;
				if (sendOnline && OnlineManager.PlayingOnline())
				{
					itemContainer.AMGDALMNHHB.SendCloseAnimation();
				}
				if (!itemContainer.hasAnimation)
				{
					goto IL_00fa;
				}
				itemContainer.NKEMALMMOBL = true;
				if (itemContainer.changeColours)
				{
					itemContainer.secondarySpriteAnimation.playBackwards = true;
					((Behaviour)itemContainer.secondarySpriteAnimation).enabled = false;
					((Behaviour)itemContainer.secondarySpriteAnimation).enabled = true;
				}
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)itemContainer).transform);
				_003Ci_003E5__2 = itemContainer.animationSprites.Length - 2;
			}
			if (_003Ci_003E5__2 >= 0)
			{
				_003C_003E2__current = (object)new WaitForSeconds(itemContainer.frameRate);
				_003C_003E1__state = 1;
				return true;
			}
			itemContainer.NKEMALMMOBL = false;
			goto IL_00fa;
			IL_00fa:
			itemContainer.KMBGLHKHBII = false;
			if (Object.op_Implicit((Object)(object)itemContainer.EAPCLAODGAE))
			{
				itemContainer.EAPCLAODGAE.selectBlockers.Remove(itemContainer.MFHACMAHGHC);
			}
			return false;
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
	private sealed class OLOCMOBCMFH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemContainer _003C_003E4__this;

		public bool sendOnline;

		public int playerNum;

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
		public OLOCMOBCMFH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ItemContainer itemContainer = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				itemContainer.KMBGLHKHBII = true;
				if (sendOnline && OnlineManager.PlayingOnline())
				{
					itemContainer.AMGDALMNHHB.SendOpenAnimation();
				}
				if (itemContainer.OpenAnimation((MonoBehaviour)(object)itemContainer))
				{
					_003C_003E2__current = ((MonoBehaviour)itemContainer).StartCoroutine(Utils.KAHHFCFDJIK(playerNum, itemContainer.frameRate, itemContainer.animationSprites, itemContainer.doorSpriteRenderer, (MonoBehaviour)(object)itemContainer));
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			PlayerInputs.GetPlayer(playerNum).mouseUpBlockers.Remove((MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
			SelectObject.GetPlayer(playerNum).PickUpAndResetSelected();
			if (Object.op_Implicit((Object)(object)itemContainer.EAPCLAODGAE) && !itemContainer.EAPCLAODGAE.selectBlockers.Contains(itemContainer.MFHACMAHGHC))
			{
				itemContainer.EAPCLAODGAE.selectBlockers.Add(itemContainer.MFHACMAHGHC);
			}
			ContainerUI containerUI = ((!itemContainer.bigContainer) ? ((ContainerUI)SmallContainerUI.Get(playerNum)) : ((ContainerUI)BigContainerUI.Get(playerNum)));
			containerUI.SetContainer(itemContainer, itemContainer.EAPCLAODGAE);
			containerUI.NBKOCCODEKN = (MonoBehaviour)(object)itemContainer;
			if (itemContainer.changeColours)
			{
				containerUI.colorButtonScript.colourCollection = itemContainer.containerColours;
				containerUI.colorButtonScript.UpdateColor(itemContainer.containerColours.colourSelections[itemContainer.containerColor].mainColor);
				containerUI.colorButtonScript.NCHKDCMNDAD = itemContainer.containerColor;
				containerUI.colorButtonScript.useColourCollection = true;
			}
			SelectObject.GetPlayer(playerNum).SetSelected(itemContainer, ((Component)itemContainer).gameObject, itemContainer.EAPCLAODGAE);
			containerUI.FillSlots(itemContainer.slots, itemContainer, itemContainer.onlyDelivery, itemContainer.draggingEnabled, itemContainer.maxPages);
			InteractObject.GetPlayer(playerNum).interactingObject = ((Component)itemContainer).gameObject;
			containerUI.OpenUI();
			itemContainer.OnOpened();
			return false;
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

	public Action OnOpened = delegate
	{
	};

	public Action OnClosed = delegate
	{
	};

	public bool bigContainer;

	public int maxPages = 5;

	[SerializeField]
	private SO_ColourCollection containerColours;

	[SerializeField]
	private SpriteRenderer secondarySprite;

	public bool draggingEnabled = true;

	[SerializeField]
	private OpenSound openSound;

	[SerializeField]
	private Placeable _placeable;

	public bool hasAnimation;

	public float frameRate = 0.125f;

	public SpriteRenderer doorSpriteRenderer;

	public Sprite[] animationSprites;

	public SpriteAnimation secondarySpriteAnimation;

	private bool KMBGLHKHBII;

	private bool NKEMALMMOBL;

	private string MFHACMAHGHC = "Output is not ready";

	private static bool OEMPBKBAMFB;

	private static bool LKOGFHBDIPF;

	public Placeable EAPCLAODGAE => _placeable;

	private OnlineItemContainer AMGDALMNHHB => EAPCLAODGAE.onlinePlaceable as OnlineItemContainer;

	public void ChangeContainerColours(int MENBAFNNBFB, bool CDPAMNIPPEC = true)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		containerColor = MENBAFNNBFB;
		doorSpriteRenderer.color = containerColours.colourSelections[MENBAFNNBFB].mainColor;
		secondarySprite.color = containerColours.colourSelections[MENBAFNNBFB].secondaryColor;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			AMGDALMNHHB.SendItemContainerColor(containerColor);
		}
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Puente_EA/Talk 1"));
			return false;
		}
		return true;
	}

	public virtual bool LBNJPLCFLEE(int JIIGOACEIKL)
	{
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).mouseUpBlockers.Count > 0)
		{
			return false;
		}
		if (KMBGLHKHBII)
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL) && !NewTutorialManager.ContainerBlocked(JIIGOACEIKL))
		{
			PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).mouseUpBlockers.Add((MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
			if (OnlineManager.PlayingOnline())
			{
				PlayerInputs.LPJCFCODNFA(JIIGOACEIKL, (MonoBehaviour)(object)GameManager.GGFJGHHHEJC, ANJCLPDCJHL: true);
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(LNOEOEGPCBD().onlinePlaceable.uniqueId);
				return false;
			}
			if (JIIGOACEIKL == 7)
			{
				if (LKOGFHBDIPF)
				{
					return true;
				}
			}
			else if (OEMPBKBAMFB)
			{
				return true;
			}
			if (JIIGOACEIKL == 8)
			{
				LKOGFHBDIPF = false;
			}
			else
			{
				OEMPBKBAMFB = false;
			}
			((MonoBehaviour)this).StartCoroutine(OGJDHOMLGFK(JIIGOACEIKL, CDPAMNIPPEC: false));
			return true;
		}
		return true;
	}

	public bool OpenAnimation(MonoBehaviour NPJDIDHOEFB)
	{
		KMBGLHKHBII = true;
		if ((Object)(object)NPJDIDHOEFB != (Object)null || hasAnimation)
		{
			Sound.GGFJGHHHEJC.PlayOpenSound(openSound, ((Component)this).transform);
		}
		if (hasAnimation)
		{
			if (changeColours)
			{
				secondarySpriteAnimation.playBackwards = false;
				((Behaviour)secondarySpriteAnimation).enabled = false;
				((Behaviour)secondarySpriteAnimation).enabled = true;
			}
			if ((Object)(object)NPJDIDHOEFB == (Object)null)
			{
				((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(1, frameRate, animationSprites, doorSpriteRenderer, NPJDIDHOEFB));
			}
			return true;
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void OBMDKCBKFGO(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		POKJLIJJKDC();
	}

	public bool OEJADJPDOHK(int JIIGOACEIKL)
	{
		return true;
	}

	private void GGHMHPDKCHC(int JIIGOACEIKL)
	{
		CraftingInventory.AddItem(this);
	}

	protected override void Start()
	{
		base.Start();
		if (changeColours)
		{
			ChangeContainerColours(containerColor, CDPAMNIPPEC: false);
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		if (bigContainer)
		{
			BigContainerUI.Get(JIIGOACEIKL).CloseUI();
		}
		else
		{
			SmallContainerUI.Get(JIIGOACEIKL).CloseUI();
		}
		OnClosed();
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences.GGFJGHHHEJC.OnAnyContainerClosed(this);
		}
		if (JIIGOACEIKL == 2)
		{
			LKOGFHBDIPF = false;
		}
		else
		{
			OEMPBKBAMFB = false;
		}
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(EAPCLAODGAE.onlinePlaceable);
		}
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		if (!NKEMALMMOBL)
		{
			((MonoBehaviour)this).StartCoroutine(CloseContainer());
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(EAPCLAODGAE.onlinePlaceable);
		}
		return true;
	}

	protected override void Awake()
	{
		base.Awake();
		if ((Object)(object)_placeable == (Object)null)
		{
			_placeable = ((Component)this).GetComponent<Placeable>();
		}
		if ((Object)(object)_placeable != (Object)null)
		{
			Placeable placeable = _placeable;
			placeable.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(placeable.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable placeable2 = _placeable;
			placeable2.OnThisPlaceableLoaded = (Action)Delegate.Combine(placeable2.OnThisPlaceableLoaded, new Action(HFMLOABCKBL));
			Placeable placeable3 = _placeable;
			placeable3.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(placeable3.OnThisPlaceablePlaced, new Action<int>(GGHMHPDKCHC));
		}
		MOCMKNHDMCI();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool PBEPBBPAFOH(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		PlayerInputs.ILCHIKOPNBI(JIIGOACEIKL, (MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
		if (IsAvailableByProximity(JIIGOACEIKL) && !KMBGLHKHBII)
		{
			if (JIIGOACEIKL == 1)
			{
				if (LKOGFHBDIPF)
				{
					return false;
				}
			}
			else if (OEMPBKBAMFB)
			{
				return false;
			}
			if (JIIGOACEIKL == 3)
			{
				LKOGFHBDIPF = true;
			}
			else
			{
				OEMPBKBAMFB = false;
			}
			((MonoBehaviour)this).StartCoroutine(OGJDHOMLGFK(JIIGOACEIKL));
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(ENLGJFFFOJN().onlinePlaceable);
		}
		return false;
	}

	public void BOHBDMHDIDC(int JIIGOACEIKL)
	{
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CraftingInventory.NBGMKMNIDIE(this);
		}
	}

	public bool FCLFHOFIJAK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public IEnumerator HNHLBIMAHIA(bool CDPAMNIPPEC = true)
	{
		return new HLKMHOHEGAO(1)
		{
			_003C_003E4__this = this,
			sendOnline = CDPAMNIPPEC
		};
	}

	private void FLOFJHNAIKP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CraftingInventory.APEOKJGBMGJ(this);
		}
	}

	public IEnumerator OGJDHOMLGFK(int JIIGOACEIKL, bool CDPAMNIPPEC = true)
	{
		return new OLOCMOBCMFH(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sendOnline = CDPAMNIPPEC
		};
	}

	public bool NFHJCBBJBGB(MonoBehaviour NPJDIDHOEFB)
	{
		KMBGLHKHBII = false;
		if ((Object)(object)NPJDIDHOEFB != (Object)null || hasAnimation)
		{
			Sound.DIHCEGINELM().JLFGDJCANGF(openSound, ((Component)this).transform);
		}
		if (hasAnimation)
		{
			if (changeColours)
			{
				secondarySpriteAnimation.playBackwards = false;
				((Behaviour)secondarySpriteAnimation).enabled = true;
				((Behaviour)secondarySpriteAnimation).enabled = false;
			}
			if ((Object)(object)NPJDIDHOEFB == (Object)null)
			{
				((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(0, frameRate, animationSprites, doorSpriteRenderer, NPJDIDHOEFB));
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public Placeable LNOEOEGPCBD()
	{
		return _placeable;
	}

	private void MOCMKNHDMCI()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			if (slots[i] != null)
			{
				slots[i].onlineObject = EAPCLAODGAE.onlinePlaceable;
			}
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void BLGAHKOIAOF()
	{
		CraftingInventory.RemoveItem(this);
	}

	private void NOILIOLOOBJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			CraftingInventory.JFBBLOHNIKI(this);
		}
	}

	public bool BBCJCNGNGIC(int JIIGOACEIKL)
	{
		return true;
	}

	public bool BGHCJHPNKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool KDKCLGIABEO(int JIIGOACEIKL)
	{
		return true;
	}

	public void GCBLINFFFKC(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	private void POKJLIJJKDC()
	{
		CraftingInventory.RemoveItem(this);
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
		if (IsAvailableByProximity(JIIGOACEIKL) && !KMBGLHKHBII)
		{
			if (JIIGOACEIKL == 2)
			{
				if (LKOGFHBDIPF)
				{
					return false;
				}
			}
			else if (OEMPBKBAMFB)
			{
				return false;
			}
			if (JIIGOACEIKL == 2)
			{
				LKOGFHBDIPF = true;
			}
			else
			{
				OEMPBKBAMFB = true;
			}
			((MonoBehaviour)this).StartCoroutine(OpenContainer(JIIGOACEIKL));
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(EAPCLAODGAE.onlinePlaceable);
		}
		return false;
	}

	private void HFMLOABCKBL()
	{
		GGHMHPDKCHC(1);
	}

	private void KKKECJOIJNJ()
	{
		for (int i = 1; i < slots.Length; i++)
		{
			if (slots[i] != null)
			{
				slots[i].onlineObject = LNOEOEGPCBD().onlinePlaceable;
			}
		}
	}

	public IEnumerator OpenContainer(int JIIGOACEIKL, bool CDPAMNIPPEC = true)
	{
		KMBGLHKHBII = true;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			AMGDALMNHHB.SendOpenAnimation();
		}
		if (OpenAnimation((MonoBehaviour)(object)this))
		{
			yield return ((MonoBehaviour)this).StartCoroutine(Utils.KAHHFCFDJIK(JIIGOACEIKL, frameRate, animationSprites, doorSpriteRenderer, (MonoBehaviour)(object)this));
		}
		PlayerInputs.GetPlayer(JIIGOACEIKL).mouseUpBlockers.Remove((MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
		SelectObject.GetPlayer(JIIGOACEIKL).PickUpAndResetSelected();
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE) && !EAPCLAODGAE.selectBlockers.Contains(MFHACMAHGHC))
		{
			EAPCLAODGAE.selectBlockers.Add(MFHACMAHGHC);
		}
		ContainerUI containerUI = ((!bigContainer) ? ((ContainerUI)SmallContainerUI.Get(JIIGOACEIKL)) : ((ContainerUI)BigContainerUI.Get(JIIGOACEIKL)));
		containerUI.SetContainer(this, EAPCLAODGAE);
		containerUI.NBKOCCODEKN = (MonoBehaviour)(object)this;
		if (changeColours)
		{
			containerUI.colorButtonScript.colourCollection = containerColours;
			containerUI.colorButtonScript.UpdateColor(containerColours.colourSelections[containerColor].mainColor);
			containerUI.colorButtonScript.NCHKDCMNDAD = containerColor;
			containerUI.colorButtonScript.useColourCollection = true;
		}
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, EAPCLAODGAE);
		containerUI.FillSlots(slots, this, onlyDelivery, draggingEnabled, maxPages);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		containerUI.OpenUI();
		OnOpened();
	}

	public void EGBOBCAAAEH(int JIIGOACEIKL)
	{
	}

	public virtual bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).mouseUpBlockers.Count > 1)
		{
			return true;
		}
		if (KMBGLHKHBII)
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL) && !NewTutorialManager.ContainerBlocked(JIIGOACEIKL))
		{
			PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).mouseUpBlockers.Add((MonoBehaviour)(object)GameManager.NJNFHEPLEHL());
			if (OnlineManager.PlayingOnline())
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)GameManager.NJNFHEPLEHL());
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(LNOEOEGPCBD().onlinePlaceable.uniqueId);
				return false;
			}
			if (JIIGOACEIKL == 3)
			{
				if (LKOGFHBDIPF)
				{
					return false;
				}
			}
			else if (OEMPBKBAMFB)
			{
				return true;
			}
			if (JIIGOACEIKL == 8)
			{
				LKOGFHBDIPF = true;
			}
			else
			{
				OEMPBKBAMFB = true;
			}
			((MonoBehaviour)this).StartCoroutine(OGJDHOMLGFK(JIIGOACEIKL, CDPAMNIPPEC: false));
			return true;
		}
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE) && (EAPCLAODGAE.FHEMHCEAICB || EAPCLAODGAE.PHOCAFJDCDK))
		{
			return false;
		}
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return !NKEMALMMOBL;
		}
		return false;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CraftingInventory.RemoveItem(this);
		}
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public virtual bool MouseUp(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).mouseUpBlockers.Count > 0)
		{
			return false;
		}
		if (KMBGLHKHBII)
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL) && !NewTutorialManager.ContainerBlocked(JIIGOACEIKL))
		{
			PlayerInputs.GetPlayer(JIIGOACEIKL).mouseUpBlockers.Add((MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
			if (OnlineManager.PlayingOnline())
			{
				PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(EAPCLAODGAE.onlinePlaceable.uniqueId);
				return false;
			}
			if (JIIGOACEIKL == 2)
			{
				if (LKOGFHBDIPF)
				{
					return false;
				}
			}
			else if (OEMPBKBAMFB)
			{
				return false;
			}
			if (JIIGOACEIKL == 2)
			{
				LKOGFHBDIPF = true;
			}
			else
			{
				OEMPBKBAMFB = true;
			}
			((MonoBehaviour)this).StartCoroutine(OpenContainer(JIIGOACEIKL));
			return true;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	[SpecialName]
	public Placeable ENLGJFFFOJN()
	{
		return _placeable;
	}

	private void BGFKPBNFIKI(int JIIGOACEIKL)
	{
		CraftingInventory.BCJLLNIBKNN(this);
	}

	public IEnumerator CloseContainer(bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			AMGDALMNHHB.SendCloseAnimation();
		}
		if (hasAnimation)
		{
			NKEMALMMOBL = true;
			if (changeColours)
			{
				secondarySpriteAnimation.playBackwards = true;
				((Behaviour)secondarySpriteAnimation).enabled = false;
				((Behaviour)secondarySpriteAnimation).enabled = true;
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.closeDoor, ((Component)this).transform);
			for (int i = animationSprites.Length - 2; i >= 0; i--)
			{
				yield return (object)new WaitForSeconds(frameRate);
				doorSpriteRenderer.sprite = animationSprites[i];
			}
			NKEMALMMOBL = false;
		}
		KMBGLHKHBII = false;
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.selectBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		BLGAHKOIAOF();
	}
}
