using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class UIWindow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class FNAFMEIEEBF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWindow _003C_003E4__this;

		public Action action;

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
		public FNAFMEIEEBF(int _003C_003E1__state)
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
			UIWindow uIWindow = _003C_003E4__this;
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
				if (uIWindow.IsOpen())
				{
					PlayerController player = PlayerController.GetPlayer(uIWindow.JIIGOACEIKL);
					player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, action);
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

	[CompilerGenerated]
	private sealed class MBOPHBCHGHM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWindow _003C_003E4__this;

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
		public MBOPHBCHGHM(int _003C_003E1__state)
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
			UIWindow uIWindow = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (!MainUI.IsAnyUIOpen(MainUI.GetYesNoDialogue().JIIGOACEIKL))
				{
					MainUI.ResumeGame();
				}
				else if (MainUI.GetCurrentOpenWindows(MainUI.GetYesNoDialogue().JIIGOACEIKL).Last.Value.compatibleWithCoopMode)
				{
					MainUI.ResumeGame();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (!MainUI.GetYesNoDialogue().slotUI.IHENCGDNPBL.KPINNBKMOMO() && uIWindow.LJGFNOIELFD != null)
				{
					uIWindow.LJGFNOIELFD.ONIFGHNHCPP(uIWindow.JIIGOACEIKL, MainUI.GetYesNoDialogue().GetItemInstance(), CDPAMNIPPEC: true);
					MainUI.GetYesNoDialogue().RemoveItemInstanceFromSlotUI();
				}
				uIWindow.HNBLNEKGKAK = null;
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

	public Action<int> OnUIClose = delegate
	{
	};

	public Action<int> OnUIOpen = delegate
	{
	};

	public Action<int> OnContentActivatedCallback = delegate
	{
	};

	public static Action<int, UIWindow> OnAnyUIOpen = delegate
	{
	};

	public static Action<int, UIWindow> OnAnyUIClose = delegate
	{
	};

	public EWindow windowType;

	public string toggleAction;

	public GameObject content;

	public bool compatibleWithCoopMode = true;

	protected bool LKOJBFMGMAE;

	private List<UIWindow> KCHBCAOLEJL;

	public int numInstance;

	public int _playerNum = 1;

	public GameObject blackBg;

	private Coroutine HNBLNEKGKAK;

	private Slot LJGFNOIELFD;

	public int JIIGOACEIKL
	{
		get
		{
			return _playerNum;
		}
		protected set
		{
			_playerNum = value;
		}
	}

	protected void AMAHHHBOPLP(Action OKNOJJEFEBE)
	{
		((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(MECHPNFNMIO(OKNOJJEFEBE));
	}

	private void DMFIMDIPFEH()
	{
		CommonReferences.GGFJGHHHEJC.RemoveBird(MainUI.GetYesNoDialogue().GetItemInstance() as BirdInstance);
		MainUI.GetYesNoDialogue().RemoveItemInstanceFromSlotUI();
	}

	public virtual void BOBCIFEDJED()
	{
		if (!MainUI.closingAllUI && !LKOJBFMGMAE)
		{
			return;
		}
		LKOJBFMGMAE = true;
		if (!compatibleWithCoopMode && windowType != (EWindow)8)
		{
			DeassignOpenedWindow(JIIGOACEIKL);
		}
		if ((Object)(object)blackBg != (Object)null)
		{
			blackBg.SetActive(true);
		}
		if (windowType == (EWindow)7)
		{
			return;
		}
		content.SetActive(false);
		if (windowType != EWindow.Disabled)
		{
			if ((Object)(object)PlayerInputs.GetPlayer(JIIGOACEIKL) != (Object)null)
			{
				PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).AMMIOLBGBPB("[GenerateAltar] Candidate {0} pos:{1} score:{2:F1} (entrance:{3:F1} big:{4:F1} exit:{5:F1})");
			}
			MainUI.EDFFDPKILIG(this);
		}
		if (!MainUI.closingAllUI && (windowType == EWindow.Concatenated || windowType == (EWindow)7))
		{
			for (LinkedListNode<UIWindow> linkedListNode = MainUI.GetCurrentOpenWindows(JIIGOACEIKL).Last; linkedListNode != null; linkedListNode = linkedListNode.Previous)
			{
				if (linkedListNode.Value.windowType != EWindow.Concatenated)
				{
					linkedListNode.Value.content.SetActive(false);
					linkedListNode.Value.OnContentActivated();
					if ((Object)(object)PlayerInputs.GetPlayer(JIIGOACEIKL) != (Object)null)
					{
						PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("ClosePopUp");
					}
					OnAnyUIOpen(JIIGOACEIKL, linkedListNode.Value);
					break;
				}
			}
		}
		if (!MainUI.closingAllUI && windowType != 0 && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			if (MainUI.AMFNKNLDEKM(JIIGOACEIKL).Count > 0)
			{
				MainUI.FENADAAPCIM(JIIGOACEIKL).Last.Value.AFCBHIBDPIG();
			}
			else if (MainUI.IsAnyUIOpen(JIIGOACEIKL))
			{
				MainUI.NBMKOPMAPJE(JIIGOACEIKL).Last.Value.AFCBHIBDPIG();
			}
		}
		OnUIClose(JIIGOACEIKL);
	}

	public virtual void APHGBMPAHBP()
	{
		if (HDEPMJIDJEM())
		{
			BOBCIFEDJED();
		}
		else
		{
			OpenUI();
		}
	}

	public virtual void DIIDFHCBOOO()
	{
		if (BGLJFMHCFJF())
		{
			BOBCIFEDJED();
		}
		else
		{
			EDHEIFHAAKO();
		}
	}

	public virtual void OpenUI()
	{
		if (LKOJBFMGMAE)
		{
			return;
		}
		if (GameManager.SinglePlayer() && (Object)(object)blackBg != (Object)null)
		{
			blackBg.SetActive(true);
		}
		if (windowType == EWindow.Main)
		{
			if (KCHBCAOLEJL == null)
			{
				KCHBCAOLEJL = new List<UIWindow>();
			}
			KCHBCAOLEJL.Clear();
			foreach (UIWindow currentOpenWindow in MainUI.GetCurrentOpenWindows(JIIGOACEIKL))
			{
				if (currentOpenWindow.windowType == EWindow.Main || currentOpenWindow.windowType == EWindow.Concatenated || currentOpenWindow.windowType == EWindow.ConcatenatedOpened)
				{
					KCHBCAOLEJL.Add(currentOpenWindow);
				}
			}
			foreach (UIWindow item in KCHBCAOLEJL)
			{
				item.CloseUI();
			}
		}
		else if (windowType == EWindow.Concatenated)
		{
			foreach (UIWindow currentOpenWindow2 in MainUI.GetCurrentOpenWindows(JIIGOACEIKL))
			{
				currentOpenWindow2.content.SetActive(false);
			}
		}
		LKOJBFMGMAE = true;
		content.SetActive(true);
		OnContentActivated();
		if (windowType != EWindow.Disabled)
		{
			if (JIIGOACEIKL == 0)
			{
				JIIGOACEIKL = 1;
			}
			PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
			MainUI.AddWindow(this, JIIGOACEIKL);
			OnAnyUIOpen(JIIGOACEIKL, this);
		}
		OnUIOpen(JIIGOACEIKL);
	}

	protected virtual void Update()
	{
		if (!string.IsNullOrEmpty(toggleAction) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(toggleAction) && CCCDKINDOKC())
		{
			ToggleUI();
		}
	}

	public virtual void BFBAKEKIPMC()
	{
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL)) && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.HPNGCKBCAKD(JIIGOACEIKL);
		}
		CCBLLOKHCDK(JIIGOACEIKL);
		OnContentActivatedCallback(JIIGOACEIKL);
	}

	public virtual void IDLAGJNLPJL()
	{
		if (LKOJBFMGMAE)
		{
			return;
		}
		if (GameManager.NBFLEJHLGNB() && (Object)(object)blackBg != (Object)null)
		{
			blackBg.SetActive(true);
		}
		if (windowType == EWindow.Main)
		{
			if (KCHBCAOLEJL == null)
			{
				KCHBCAOLEJL = new List<UIWindow>();
			}
			KCHBCAOLEJL.Clear();
			foreach (UIWindow currentOpenWindow in MainUI.GetCurrentOpenWindows(JIIGOACEIKL))
			{
				if (currentOpenWindow.windowType == EWindow.Main || currentOpenWindow.windowType == EWindow.Main || currentOpenWindow.windowType == (EWindow)7)
				{
					KCHBCAOLEJL.Add(currentOpenWindow);
				}
			}
			foreach (UIWindow item in KCHBCAOLEJL)
			{
				item.BOBCIFEDJED();
			}
		}
		else if (windowType == EWindow.Concatenated)
		{
			foreach (UIWindow item2 in MainUI.AMFNKNLDEKM(JIIGOACEIKL))
			{
				item2.content.SetActive(false);
			}
		}
		LKOJBFMGMAE = false;
		content.SetActive(true);
		PMNCLJJHDPP();
		if (windowType != (EWindow)7)
		{
			if (JIIGOACEIKL == 0)
			{
				OAJBEPDCHIP(0);
			}
			PlayerInputs.GetPlayer(JIIGOACEIKL).AMMIOLBGBPB("MoveDirection");
			MainUI.KDBHGGKKDND(this, JIIGOACEIKL);
			OnAnyUIOpen(JIIGOACEIKL, this);
		}
		OnUIOpen(JIIGOACEIKL);
	}

	public virtual void CloseUIRemainActive()
	{
		if (MainUI.closingAllUI || LKOJBFMGMAE)
		{
			LKOJBFMGMAE = false;
			if ((Object)(object)blackBg != (Object)null)
			{
				blackBg.SetActive(false);
			}
			OnUIClose(JIIGOACEIKL);
		}
	}

	public static bool CanBeOpened(int JIIGOACEIKL, GameObject MEGPBGODLIL)
	{
		if (GameManager.SinglePlayer() || GameManager.NoPlayers())
		{
			return true;
		}
		return !((object)MEGPBGODLIL).Equals((object?)SelectObject.GetPlayer((JIIGOACEIKL != 1) ? 1 : 2).selectedGameObject);
	}

	public virtual void LEKHBBPDAAJ()
	{
		if (HDEPMJIDJEM())
		{
			BOBCIFEDJED();
		}
		else
		{
			OpenUI();
		}
	}

	public bool BGLJFMHCFJF()
	{
		if (LKOJBFMGMAE)
		{
			return content.activeSelf;
		}
		return true;
	}

	public void Close()
	{
		CloseUI();
	}

	public int CheckNextPage(ref float CMGDCLIIONE, int OMLHFIADNJD, int EKLFNJDAKAM, GameObject APFGODJFLME, string NBIFHGGHMEJ, string GOIGHBNLIHC)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		RaycastResult val;
		if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, PlayerInputs.IsGamepadActive(JIIGOACEIKL) ? NBIFHGGHMEJ : "UINextPage", (EKLFNJDAKAM > 2) ? 0.1f : 0.5f) || Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "UIScrollDown", (EKLFNJDAKAM > 2) ? 0.1f : 0.5f))
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				return Utils.NMLNAGFLNMC(OMLHFIADNJD + 1, EKLFNJDAKAM);
			}
			if ((Object)(object)APFGODJFLME == (Object)null)
			{
				return Utils.NMLNAGFLNMC(OMLHFIADNJD + 1, EKLFNJDAKAM);
			}
			List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
			for (int i = 0; i < list.Count; i++)
			{
				val = list[i];
				if (((object)((RaycastResult)(ref val)).gameObject).Equals((object?)APFGODJFLME))
				{
					return Utils.NMLNAGFLNMC(OMLHFIADNJD + 1, EKLFNJDAKAM);
				}
			}
		}
		else if (Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, PlayerInputs.IsGamepadActive(JIIGOACEIKL) ? GOIGHBNLIHC : "UIPreviousPage", (EKLFNJDAKAM > 2) ? 0.1f : 0.5f) || Utils.IIHPGJIJOAD(JIIGOACEIKL, ref CMGDCLIIONE, "UIScrollUp", (EKLFNJDAKAM > 2) ? 0.1f : 0.5f))
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				return Utils.NMLNAGFLNMC(OMLHFIADNJD - 1, EKLFNJDAKAM);
			}
			if ((Object)(object)APFGODJFLME == (Object)null)
			{
				return Utils.NMLNAGFLNMC(OMLHFIADNJD - 1, EKLFNJDAKAM);
			}
			List<RaycastResult> list2 = Utils.OFBMJPNCHAA(JIIGOACEIKL);
			for (int j = 0; j < list2.Count; j++)
			{
				val = list2[j];
				if (((object)((RaycastResult)(ref val)).gameObject).Equals((object?)APFGODJFLME))
				{
					return Utils.NMLNAGFLNMC(OMLHFIADNJD - 1, EKLFNJDAKAM);
				}
			}
		}
		return -1;
	}

	protected bool IFLDGGMAHOO()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return true;
		}
		if ((JIIGOACEIKL == 2 && GameManager.EAOOLEFMIKE()) || (numInstance == 0 && GameManager.LocalCoop()) || (numInstance == 0 && GameManager.SinglePlayer()))
		{
			return true;
		}
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return true;
		}
		if (DevConsole.instance.opened)
		{
			return false;
		}
		if (!PlayerInputs.InputsEnabled(JIIGOACEIKL))
		{
			Debug.Log((object)("" + ((object)PlayerInputs.GetPlayer(JIIGOACEIKL).inputBlockers[0]).GetType().Name));
			return false;
		}
		if (RentRoomUI.JDODHPEDACJ(JIIGOACEIKL).IsOpen() && RentRoomUI.PPJMPMKLCME(JIIGOACEIKL).JIIGOACEIKL == JIIGOACEIKL)
		{
			Debug.Log((object)"Profit");
			return true;
		}
		if (PauseMenuUI.KGPJPILAHDE().IsOpen())
		{
			Debug.Log((object)"Items/item_description_689");
			return true;
		}
		if ((Object)(object)MainUI.openedWindow != (Object)null)
		{
			Debug.Log((object)("itemWhiteGrapes" + ((Object)((Component)MainUI.openedWindow).gameObject).name));
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			Debug.Log((object)"Not enough money");
			return false;
		}
		if (InteractObject.BBJCJFJEFKK(JIIGOACEIKL).KOHOJLBBENG)
		{
			Debug.Log((object)"North");
			return false;
		}
		return true;
	}

	private IEnumerator LIMFCKBOAJB(Action OKNOJJEFEBE)
	{
		return new FNAFMEIEEBF(1)
		{
			_003C_003E4__this = this,
			action = OKNOJJEFEBE
		};
	}

	public bool DropItemsFocusedSlot()
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		if (SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null && !SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.KPINNBKMOMO())
		{
			LJGFNOIELFD = SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot;
			if (LJGFNOIELFD.itemInstance.LHBPOPOIFLE() is Bird)
			{
				MainUI.PauseGame();
				MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
				MainUI.GetYesNoDialogue().SetItemInstanceToSlotUI(LJGFNOIELFD.itemInstance);
				LJGFNOIELFD.FDOBDPPMMBH(LJGFNOIELFD.Stack, CDPAMNIPPEC: true);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("LetGoBird");
				((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
				((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener(new UnityAction(SwapWithLastSlot));
			}
			else
			{
				DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, LJGFNOIELFD.itemInstance, LJGFNOIELFD.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
				LJGFNOIELFD.BGJPNGLONLP(0);
				LJGFNOIELFD.AFPAJHJIHJD(JIIGOACEIKL);
			}
			return true;
		}
		return false;
	}

	private IEnumerator AGLLHDEDBDL()
	{
		if (!MainUI.IsAnyUIOpen(MainUI.GetYesNoDialogue().JIIGOACEIKL))
		{
			MainUI.ResumeGame();
		}
		else if (MainUI.GetCurrentOpenWindows(MainUI.GetYesNoDialogue().JIIGOACEIKL).Last.Value.compatibleWithCoopMode)
		{
			MainUI.ResumeGame();
		}
		yield return null;
		if (!MainUI.GetYesNoDialogue().slotUI.IHENCGDNPBL.KPINNBKMOMO() && LJGFNOIELFD != null)
		{
			LJGFNOIELFD.ONIFGHNHCPP(JIIGOACEIKL, MainUI.GetYesNoDialogue().GetItemInstance(), CDPAMNIPPEC: true);
			MainUI.GetYesNoDialogue().RemoveItemInstanceFromSlotUI();
		}
		HNBLNEKGKAK = null;
	}

	public void GAAIAAPALCI(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	protected bool BDJFDGCALKE()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if ((JIIGOACEIKL == 5 && GameManager.NBFLEJHLGNB()) || (numInstance == 0 && GameManager.LocalCoop()) || (numInstance == 1 && GameManager.HDBECFMPJHL()))
		{
			return true;
		}
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return false;
		}
		if (DevConsole.instance.opened)
		{
			return false;
		}
		if (!PlayerInputs.AFGFCLPJGFO(JIIGOACEIKL))
		{
			Debug.Log((object)("Items/item_name_724" + ((object)PlayerInputs.GetPlayer(JIIGOACEIKL).inputBlockers[1]).GetType().Name));
			return false;
		}
		if (RentRoomUI.NHOFBAMNELD(JIIGOACEIKL).BGLJFMHCFJF() && RentRoomUI.Get(JIIGOACEIKL).JIIGOACEIKL == JIIGOACEIKL)
		{
			Debug.Log((object)"Cleaning");
			return false;
		}
		if (PauseMenuUI.GGFJGHHHEJC.HDEPMJIDJEM())
		{
			Debug.Log((object)"sleep");
			return false;
		}
		if ((Object)(object)MainUI.openedWindow != (Object)null)
		{
			Debug.Log((object)("Items/item_name_1063" + ((Object)((Component)MainUI.openedWindow).gameObject).name));
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			Debug.Log((object)"0");
			return true;
		}
		if (InteractObject.BBJCJFJEFKK(JIIGOACEIKL).KOHOJLBBENG)
		{
			Debug.Log((object)"\n");
			return false;
		}
		return false;
	}

	public void CCBLLOKHCDK(int JIIGOACEIKL)
	{
		if (!compatibleWithCoopMode && windowType != 0 && windowType != 0)
		{
			MainUI.openedWindow = this;
			if (GameManager.LocalCoop())
			{
				PlayerInputs.JBKHOPCMBAC((JIIGOACEIKL != 0) ? 1 : 4, (MonoBehaviour)(object)this);
			}
		}
	}

	public virtual void OnContentActivated()
	{
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL)) && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.AFPAJHJIHJD(JIIGOACEIKL);
		}
		AssignOpenedWindow(JIIGOACEIKL);
		OnContentActivatedCallback(JIIGOACEIKL);
	}

	private void EIEAJEBIPJA()
	{
		CommonReferences.GGFJGHHHEJC.NOOGPNNIGMB(MainUI.MCPEEGPBPLH().BDMNENEAJEM() as BirdInstance);
		MainUI.NEFOKCKKLNI().EOACDLGEIJE();
	}

	protected virtual void Start()
	{
		content.SetActive(false);
		LKOJBFMGMAE = false;
	}

	private IEnumerator KCIGHCAIBOC()
	{
		return new MBOPHBCHGHM(1)
		{
			_003C_003E4__this = this
		};
	}

	public virtual void NLPGKPJMBMG()
	{
		if (HDEPMJIDJEM())
		{
			CloseUI();
		}
		else
		{
			IDLAGJNLPJL();
		}
	}

	public virtual void EDHEIFHAAKO()
	{
		if (LKOJBFMGMAE)
		{
			return;
		}
		if (GameManager.HDBECFMPJHL() && (Object)(object)blackBg != (Object)null)
		{
			blackBg.SetActive(true);
		}
		if (windowType == EWindow.Main)
		{
			if (KCHBCAOLEJL == null)
			{
				KCHBCAOLEJL = new List<UIWindow>();
			}
			KCHBCAOLEJL.Clear();
			foreach (UIWindow currentOpenWindow in MainUI.GetCurrentOpenWindows(JIIGOACEIKL))
			{
				if (currentOpenWindow.windowType == EWindow.Main || currentOpenWindow.windowType == EWindow.Concatenated || currentOpenWindow.windowType == EWindow.Concatenated)
				{
					KCHBCAOLEJL.Add(currentOpenWindow);
				}
			}
			foreach (UIWindow item in KCHBCAOLEJL)
			{
				item.CloseUI();
			}
		}
		else if (windowType == EWindow.Concatenated)
		{
			foreach (UIWindow item2 in MainUI.FENADAAPCIM(JIIGOACEIKL))
			{
				item2.content.SetActive(false);
			}
		}
		LKOJBFMGMAE = false;
		content.SetActive(false);
		BFBAKEKIPMC();
		if (windowType != EWindow.Disabled)
		{
			if (JIIGOACEIKL == 0)
			{
				OAJBEPDCHIP(1);
			}
			PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("");
			MainUI.HFKOOOHHDMC(this, JIIGOACEIKL);
			OnAnyUIOpen(JIIGOACEIKL, this);
		}
		OnUIOpen(JIIGOACEIKL);
	}

	public static bool DNBBFPGEEOK(int JIIGOACEIKL, GameObject MEGPBGODLIL)
	{
		if (GameManager.SinglePlayer() || GameManager.NoPlayers())
		{
			return true;
		}
		return !((object)MEGPBGODLIL).Equals((object?)SelectObject.BNMEANGDMIP((JIIGOACEIKL != 0) ? 1 : 7).selectedGameObject);
	}

	public void AGPKKDHFDLO()
	{
		BOBCIFEDJED();
	}

	private void APFCMHJHGAJ()
	{
		CommonReferences.GGFJGHHHEJC.JCPPLJCNONB(MainUI.LBHLPIFCINB().MJEECOJAMMN() as BirdInstance);
		MainUI.GetYesNoDialogue().NEMHAOFEOIK();
	}

	public void FIBLMHAKCCI()
	{
		CloseUI();
	}

	protected void DNGMHNCJBGP(Action OKNOJJEFEBE)
	{
		((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(MECHPNFNMIO(OKNOJJEFEBE));
	}

	public void OFGKFMJKBON(int JIIGOACEIKL)
	{
		if (!compatibleWithCoopMode)
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
		}
		AssignOpenedWindow(JIIGOACEIKL);
		OpenUI();
	}

	protected static T EJKJJAOHGEL<T>(int JIIGOACEIKL, T[] GJBBNHCMNJN) where T : UIWindow
	{
		if (GJBBNHCMNJN.Length == 2)
		{
			if (JIIGOACEIKL == 1)
			{
				return GJBBNHCMNJN[0];
			}
			return GJBBNHCMNJN[1];
		}
		if (GameManager.SinglePlayer() || GameManager.NoPlayers())
		{
			return GJBBNHCMNJN[0];
		}
		if (JIIGOACEIKL == 1)
		{
			return GJBBNHCMNJN[1];
		}
		return GJBBNHCMNJN[2];
	}

	public void AssignOpenedWindow(int JIIGOACEIKL)
	{
		if (!compatibleWithCoopMode && windowType != EWindow.Disabled && windowType != EWindow.Permanent)
		{
			MainUI.openedWindow = this;
			if (GameManager.LocalCoop())
			{
				PlayerInputs.DisableKeyboardInputs((JIIGOACEIKL != 1) ? 1 : 2, (MonoBehaviour)(object)this);
			}
		}
	}

	private void MMNMKNLFBMN()
	{
		if (!content.activeSelf)
		{
			content.SetActive(true);
			OnContentActivated();
		}
	}

	public bool IsOpen()
	{
		if (LKOJBFMGMAE)
		{
			return content.activeSelf;
		}
		return false;
	}

	public virtual void LMDHLPCIAMP()
	{
		if (HDEPMJIDJEM())
		{
			BOBCIFEDJED();
		}
		else
		{
			OpenUI();
		}
	}

	protected void DJJFMDHGOKN(Action OKNOJJEFEBE)
	{
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(MECHPNFNMIO(OKNOJJEFEBE));
	}

	public virtual void KADDMAFNLKI()
	{
		if (HDEPMJIDJEM())
		{
			BOBCIFEDJED();
		}
		else
		{
			IDLAGJNLPJL();
		}
	}

	protected virtual void JMDOCHBJGKG()
	{
		if (!string.IsNullOrEmpty(toggleAction) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(toggleAction) && BDJFDGCALKE())
		{
			LMDHLPCIAMP();
		}
	}

	public bool HDEPMJIDJEM()
	{
		if (LKOJBFMGMAE)
		{
			return content.activeSelf;
		}
		return true;
	}

	[SpecialName]
	protected void OAJBEPDCHIP(int AODONKKHPBP)
	{
		_playerNum = AODONKKHPBP;
	}

	public virtual void PBFOOLDCHPL()
	{
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL)) && SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).focusedSlot.KJBMKDJNOIP(JIIGOACEIKL);
		}
		CCBLLOKHCDK(JIIGOACEIKL);
		OnContentActivatedCallback(JIIGOACEIKL);
	}

	public void DeassignOpenedWindow(int JIIGOACEIKL)
	{
		if (windowType != EWindow.Permanent)
		{
			MainUI.openedWindow = null;
		}
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputs((JIIGOACEIKL != 1) ? 1 : 2, (MonoBehaviour)(object)this);
		}
	}

	protected bool KPFELAMDMCK()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if ((JIIGOACEIKL == 0 && GameManager.NBFLEJHLGNB()) || (numInstance == 0 && GameManager.LocalCoop()) || (numInstance == 0 && GameManager.HDBECFMPJHL()))
		{
			return false;
		}
		if (!GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return true;
		}
		if (DevConsole.instance.opened)
		{
			return true;
		}
		if (!PlayerInputs.AFGFCLPJGFO(JIIGOACEIKL))
		{
			Debug.Log((object)("(Player 2) Press " + ((object)PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).inputBlockers[0]).GetType().Name));
			return true;
		}
		if (RentRoomUI.LPJPJMPOHPG(JIIGOACEIKL).BGLJFMHCFJF() && RentRoomUI.NHOFBAMNELD(JIIGOACEIKL).JIIGOACEIKL == JIIGOACEIKL)
		{
			Debug.Log((object)"Items/item_name_671");
			return true;
		}
		if (PauseMenuUI.GGFJGHHHEJC.HDEPMJIDJEM())
		{
			Debug.Log((object)"Precision/DrinkEvent4");
			return true;
		}
		if ((Object)(object)MainUI.openedWindow != (Object)null)
		{
			Debug.Log((object)("Cannot load old character saved" + ((Object)((Component)MainUI.openedWindow).gameObject).name));
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			Debug.Log((object)"End");
			return false;
		}
		if (InteractObject.GNCPLNHMFHN(JIIGOACEIKL).KOHOJLBBENG)
		{
			Debug.Log((object)"Moving");
			return false;
		}
		return false;
	}

	public void SwapWithLastSlot()
	{
		if (HNBLNEKGKAK == null)
		{
			HNBLNEKGKAK = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(AGLLHDEDBDL());
		}
	}

	public void SetPlayerNum(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	private IEnumerator MECHPNFNMIO(Action OKNOJJEFEBE)
	{
		yield return null;
		if (IsOpen())
		{
			PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, OKNOJJEFEBE);
		}
	}

	protected bool CCCDKINDOKC()
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if ((JIIGOACEIKL == 2 && GameManager.SinglePlayer()) || (numInstance == 0 && GameManager.LocalCoop()) || (numInstance == 1 && GameManager.SinglePlayer()))
		{
			return false;
		}
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return false;
		}
		if (DevConsole.instance.opened)
		{
			return false;
		}
		if (!PlayerInputs.InputsEnabled(JIIGOACEIKL))
		{
			Debug.Log((object)("CannotToggleUI InputsEnabled " + ((object)PlayerInputs.GetPlayer(JIIGOACEIKL).inputBlockers[0]).GetType().Name));
			return false;
		}
		if (RentRoomUI.Get(JIIGOACEIKL).IsOpen() && RentRoomUI.Get(JIIGOACEIKL).JIIGOACEIKL == JIIGOACEIKL)
		{
			Debug.Log((object)"CannotToggleUI RentRoomUI opened");
			return false;
		}
		if (PauseMenuUI.GGFJGHHHEJC.IsOpen())
		{
			Debug.Log((object)"CannotToggleUI PauseMenuUI opened");
			return false;
		}
		if ((Object)(object)MainUI.openedWindow != (Object)null)
		{
			Debug.Log((object)("CannotToggleUI openedWindow " + ((Object)((Component)MainUI.openedWindow).gameObject).name));
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			Debug.Log((object)"CannotToggleUI IsActioningTool ");
			return false;
		}
		if (InteractObject.GetPlayer(JIIGOACEIKL).KOHOJLBBENG)
		{
			Debug.Log((object)"CannotToggleUI Holding ");
			return false;
		}
		return true;
	}

	public void LFHPDCDJJJO(int JIIGOACEIKL)
	{
		OAJBEPDCHIP(JIIGOACEIKL);
	}

	private void AFCBHIBDPIG()
	{
		if (!content.activeSelf)
		{
			content.SetActive(true);
			PMNCLJJHDPP();
		}
	}

	protected virtual void ELHCBGCEJDH()
	{
		if (!string.IsNullOrEmpty(toggleAction) && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(toggleAction) && BDJFDGCALKE())
		{
			DIIDFHCBOOO();
		}
	}

	public virtual void ToggleUI()
	{
		if (IsOpen())
		{
			CloseUI();
		}
		else
		{
			OpenUI();
		}
	}

	public virtual void CloseUI()
	{
		if (!MainUI.closingAllUI && !LKOJBFMGMAE)
		{
			return;
		}
		LKOJBFMGMAE = false;
		if (!compatibleWithCoopMode && windowType != EWindow.Disabled)
		{
			DeassignOpenedWindow(JIIGOACEIKL);
		}
		if ((Object)(object)blackBg != (Object)null)
		{
			blackBg.SetActive(false);
		}
		if (windowType == EWindow.Permanent)
		{
			return;
		}
		content.SetActive(false);
		if (windowType != EWindow.Disabled)
		{
			if ((Object)(object)PlayerInputs.GetPlayer(JIIGOACEIKL) != (Object)null)
			{
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("Game");
			}
			MainUI.RemoveWindow(this);
		}
		if (!MainUI.closingAllUI && (windowType == EWindow.Concatenated || windowType == EWindow.ConcatenatedOpened))
		{
			for (LinkedListNode<UIWindow> linkedListNode = MainUI.GetCurrentOpenWindows(JIIGOACEIKL).Last; linkedListNode != null; linkedListNode = linkedListNode.Previous)
			{
				if (linkedListNode.Value.windowType != EWindow.Disabled)
				{
					linkedListNode.Value.content.SetActive(true);
					linkedListNode.Value.OnContentActivated();
					if ((Object)(object)PlayerInputs.GetPlayer(JIIGOACEIKL) != (Object)null)
					{
						PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
					}
					OnAnyUIOpen(JIIGOACEIKL, linkedListNode.Value);
					break;
				}
			}
		}
		if (!MainUI.closingAllUI && windowType != EWindow.Disabled && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			if (MainUI.GetCurrentOpenWindows(JIIGOACEIKL).Count > 0)
			{
				MainUI.GetCurrentOpenWindows(JIIGOACEIKL).Last.Value.MMNMKNLFBMN();
			}
			else if (MainUI.IsAnyUIOpen(JIIGOACEIKL))
			{
				MainUI.GetCurrentOpenWindows(JIIGOACEIKL).Last.Value.MMNMKNLFBMN();
			}
		}
		OnUIClose(JIIGOACEIKL);
	}

	protected virtual void PHNJGHKBIIL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("hardware_info")) ? 3 : 0);
	}

	public virtual void MCMPBPFAPMJ()
	{
		if (MainUI.closingAllUI || LKOJBFMGMAE)
		{
			LKOJBFMGMAE = true;
			if ((Object)(object)blackBg != (Object)null)
			{
				blackBg.SetActive(false);
			}
			OnUIClose(JIIGOACEIKL);
		}
	}

	private IEnumerator BHLLKCGHMGM()
	{
		return new MBOPHBCHGHM(1)
		{
			_003C_003E4__this = this
		};
	}

	public virtual void PMNCLJJHDPP()
	{
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL)) && SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot != null)
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).focusedSlot.ICOCPFOBBJE(JIIGOACEIKL);
		}
		CCBLLOKHCDK(JIIGOACEIKL);
		OnContentActivatedCallback(JIIGOACEIKL);
	}

	public void CFNLPBGODAC()
	{
		if (HNBLNEKGKAK == null)
		{
			HNBLNEKGKAK = ((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StartCoroutine(BHLLKCGHMGM());
		}
	}

	protected virtual void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void Open(int JIIGOACEIKL)
	{
		if (!compatibleWithCoopMode)
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
		}
		AssignOpenedWindow(JIIGOACEIKL);
		OpenUI();
	}
}
