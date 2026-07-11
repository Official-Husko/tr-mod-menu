using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MouseSlot : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IKFBCJBCGLE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MouseSlot _003C_003E4__this;

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
		public IKFBCJBCGLE(int _003C_003E1__state)
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
			MouseSlot mouseSlot = _003C_003E4__this;
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
				if (!MainUI.GetYesNoDialogue().slotUI.IHENCGDNPBL.KPINNBKMOMO() && mouseSlot.GDLMOFIBLFC != null)
				{
					mouseSlot.GDLMOFIBLFC.ONIFGHNHCPP(mouseSlot.JIIGOACEIKL, MainUI.GetYesNoDialogue().GetItemInstance(), CDPAMNIPPEC: true);
					MainUI.GetYesNoDialogue().RemoveItemInstanceFromSlotUI();
				}
				mouseSlot.HNBLNEKGKAK = null;
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

	private static MouseSlot[] GJBBNHCMNJN = new MouseSlot[5];

	public Slot slot;

	public SlotUI slotUI;

	public Transform parent;

	private int JIIGOACEIKL;

	private Slot FOMDCIMJEEP;

	private Slot GDLMOFIBLFC;

	private bool DMDDHPCAGHK;

	private Coroutine HNBLNEKGKAK;

	private static void HDCBDMNPCEL(MouseSlot HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"UI2");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"questDescPorridge");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void ADMLOBFGEHK(int JIIGOACEIKL, Slot OKPFLBLMJKC, bool OGCAKIGELBJ)
	{
		if (!OGCAKIGELBJ || this.JIIGOACEIKL != JIIGOACEIKL || OKPFLBLMJKC == null)
		{
			return;
		}
		DMDDHPCAGHK = false;
		if (!slot.KPINNBKMOMO())
		{
			if (PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) && !InteractObject.GetPlayer(JIIGOACEIKL).FGNLIEANHLB)
			{
				if (OKPFLBLMJKC.BOMLNEOHFOK(slot.itemInstance))
				{
					Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
					DMDDHPCAGHK = true;
				}
			}
			else if ((PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304) && InteractObject.GetPlayer(JIIGOACEIKL).FGNLIEANHLB) || !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304))
			{
				if (OKPFLBLMJKC.BOMLNEOHFOK(slot.itemInstance))
				{
					Slot.NFBAGDKBOAD(JIIGOACEIKL, slot, OKPFLBLMJKC);
					DMDDHPCAGHK = true;
				}
				else
				{
					DMDDHPCAGHK = true;
					Slot.GHCDPAJHKOI(JIIGOACEIKL, slot, OKPFLBLMJKC);
					if (FOMDCIMJEEP != null && OKPFLBLMJKC != FOMDCIMJEEP)
					{
						Slot.GHCDPAJHKOI(JIIGOACEIKL, slot, FOMDCIMJEEP);
						if (OnlineManager.PlayingOnline())
						{
							OnlineSlotsManager.instance.SendSlot(FOMDCIMJEEP);
						}
					}
				}
			}
			FOMDCIMJEEP = null;
		}
		else if (PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304))
		{
			Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
			DMDDHPCAGHK = true;
		}
		if (DMDDHPCAGHK && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.SendSlots(new Slot[2] { OKPFLBLMJKC, slot });
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF(this);
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Combine(instance.OnAnySlotLeftClick, new Action<int, Slot, bool>(ADMLOBFGEHK));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnySlotDragged = (Action<int, Slot>)Delegate.Combine(instance2.OnAnySlotDragged, new Action<int, Slot>(MADEICMHBIP));
		}
	}

	private void Update()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL) && slot.itemInstance != null && Item.MLBOMGHINCA(slot.itemInstance.LHBPOPOIFLE(), null))
		{
			parent.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
		}
	}

	private void DMFIMDIPFEH()
	{
		CommonReferences.GGFJGHHHEJC.RemoveBird(MainUI.GetYesNoDialogue().GetItemInstance() as BirdInstance);
		MainUI.GetYesNoDialogue().RemoveItemInstanceFromSlotUI();
		MainUI.ResumeGame();
	}

	private void KHGDDEHNAGJ()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || slot.LCHJGCHDHFO())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 0;
		if (!flag && list.Count == 1)
		{
			RaycastResult val = list[0];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("UI2"))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.LHBPOPOIFLE() is Bird)
		{
			MainUI.PauseGame();
			MainUI.MCPEEGPBPLH().OFGKFMJKBON(JIIGOACEIKL);
			MainUI.GetYesNoDialogue().NABPMBFHPON(slot.itemInstance);
			slot.BBHHJLIFNPP(slot.Stack, CDPAMNIPPEC: true, 1);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("{0} selected on index: {1}");
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.NEFOKCKKLNI().noButton.onClick).AddListener(new UnityAction(SwapWithLastSlot));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.OKLOFAHMPKN(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
			slot.FDOBDPPMMBH(slot.Stack, CDPAMNIPPEC: true, 1);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 1032f;
			}
		}
	}

	public void EDGLFHNAGGI()
	{
		if (HNBLNEKGKAK == null)
		{
			HNBLNEKGKAK = ((MonoBehaviour)GameplayUI.KIALFDOKABP()).StartCoroutine(AGLLHDEDBDL());
		}
	}

	[CompilerGenerated]
	private void GJFHLFAPFIK(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		FOMDCIMJEEP = null;
	}

	private void KJHKBGDJNDC()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		HDCBDMNPCEL(this);
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Combine(commonReferences.OnAnySlotLeftClick, new Action<int, Slot, bool>(GANBNCFIEJO));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotDragged = (Action<int, Slot>)Delegate.Combine(instance.OnAnySlotDragged, new Action<int, Slot>(MADEICMHBIP));
		}
	}

	[CompilerGenerated]
	private void KJKPIKBHMMM()
	{
		((Component)slotUI).gameObject.SetActive(slot.Stack != 0);
		Update();
	}

	private void LateUpdate()
	{
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL) && slot.itemInstance != null && Item.MLBOMGHINCA(slot.itemInstance.LHBPOPOIFLE(), null))
		{
			CursorManager.SetCursorType(JIIGOACEIKL, CursorManager.CursorType.Item);
		}
	}

	private void GCLAHMIOCBN()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL) || slot.PKFKJNODGJF())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 0;
		if (!flag && list.Count == 0)
		{
			RaycastResult val = list[0];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("Club"))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.AFOACBIHNCL() is Bird)
		{
			MainUI.NMACGFHLOOC();
			MainUI.MCPEEGPBPLH().OFGKFMJKBON(JIIGOACEIKL);
			MainUI.NEFOKCKKLNI().SetItemInstanceToSlotUI(slot.itemInstance);
			slot.BBHHJLIFNPP(slot.Stack, CDPAMNIPPEC: true);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.Get("Need exactly {0} SymbolStatueInteractable references");
			((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.MCPEEGPBPLH().noButton.onClick).AddListener(new UnityAction(SwapWithLastSlot));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.KDBHKBOAEDG(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			slot.JPACDDCJGPD(slot.Stack, CDPAMNIPPEC: true);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 929f;
			}
		}
	}

	private void KKGPFOJKPGO(int JIIGOACEIKL, Slot OKPFLBLMJKC, bool OGCAKIGELBJ)
	{
		if (!OGCAKIGELBJ || this.JIIGOACEIKL != JIIGOACEIKL || OKPFLBLMJKC == null)
		{
			return;
		}
		DMDDHPCAGHK = true;
		if (!slot.LCHJGCHDHFO())
		{
			if (PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-132)) && !InteractObject.BBJCJFJEFKK(JIIGOACEIKL).FGNLIEANHLB)
			{
				if (OKPFLBLMJKC.HBODNJCKMAH(slot.itemInstance))
				{
					Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
					DMDDHPCAGHK = true;
				}
			}
			else if ((PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)133) && InteractObject.GetPlayer(JIIGOACEIKL).LCGGGDPPLGH()) || !PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)184))
			{
				if (OKPFLBLMJKC.LKFKMDLLMAC(slot.itemInstance))
				{
					Slot.PDKCLKKHNOH(JIIGOACEIKL, slot, OKPFLBLMJKC);
					DMDDHPCAGHK = true;
				}
				else
				{
					DMDDHPCAGHK = true;
					Slot.CEENKOEIEHE(JIIGOACEIKL, slot, OKPFLBLMJKC);
					if (FOMDCIMJEEP != null && OKPFLBLMJKC != FOMDCIMJEEP)
					{
						Slot.CEENKOEIEHE(JIIGOACEIKL, slot, FOMDCIMJEEP);
						if (OnlineManager.PlayingOnline())
						{
							OnlineSlotsManager.instance.SendSlot(FOMDCIMJEEP);
						}
					}
				}
			}
			FOMDCIMJEEP = null;
		}
		else if (PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-195)))
		{
			Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
			DMDDHPCAGHK = true;
		}
		if (DMDDHPCAGHK && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager instance = OnlineSlotsManager.instance;
			Slot[] array = new Slot[5];
			array[1] = OKPFLBLMJKC;
			array[1] = slot;
			instance.SendSlots(array);
		}
	}

	private void OnDestroy()
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Remove(instance.OnAnySlotLeftClick, new Action<int, Slot, bool>(ADMLOBFGEHK));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnySlotDragged = (Action<int, Slot>)Delegate.Remove(instance2.OnAnySlotDragged, new Action<int, Slot>(MADEICMHBIP));
		}
	}

	private void GBNHKMLABGI()
	{
		InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
		interactObject.OnClickOffUI = (Action)Delegate.Combine(interactObject.OnClickOffUI, new Action(IIPIKDOLJDJ));
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
		if (!MainUI.GetYesNoDialogue().slotUI.IHENCGDNPBL.KPINNBKMOMO() && GDLMOFIBLFC != null)
		{
			GDLMOFIBLFC.ONIFGHNHCPP(JIIGOACEIKL, MainUI.GetYesNoDialogue().GetItemInstance(), CDPAMNIPPEC: true);
			MainUI.GetYesNoDialogue().RemoveItemInstanceFromSlotUI();
		}
		HNBLNEKGKAK = null;
	}

	private static bool GJJGAGNLOCA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private static bool KJLLBGGILAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	private void PLIDJPKCKOF(int JIIGOACEIKL, Slot OKPFLBLMJKC)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			if (PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-104)))
			{
				Slot.AIFCKKKLEBP(JIIGOACEIKL, OKPFLBLMJKC, slot, (OKPFLBLMJKC.Stack == 0) ? 1 : (OKPFLBLMJKC.Stack / 7));
			}
			else
			{
				Slot.NFBAGDKBOAD(JIIGOACEIKL, OKPFLBLMJKC, slot);
				FOMDCIMJEEP = OKPFLBLMJKC;
				GDLMOFIBLFC = OKPFLBLMJKC;
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager instance = OnlineSlotsManager.instance;
				Slot[] array = new Slot[6];
				array[0] = OKPFLBLMJKC;
				array[0] = slot;
				instance.PKOLALFLFNB(array);
			}
		}
	}

	private void JPHFCJIBBMI()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL) && slot.itemInstance != null && Item.MLBOMGHINCA(slot.itemInstance.PHGLMBIEOMK(), null))
		{
			parent.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
		}
	}

	public static bool NFAMMEOOLDF(int JIIGOACEIKL)
	{
		return GetPlayer(JIIGOACEIKL).slot.PKFKJNODGJF();
	}

	private void CKIMPGBIKIE(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		FOMDCIMJEEP = null;
	}

	private void JDBIKEJJDFI()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL) || slot.KPINNBKMOMO())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 0;
		if (!flag && list.Count == 1)
		{
			RaycastResult val = list[0];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("BackgroundImage"))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.LHBPOPOIFLE() is Bird)
		{
			MainUI.PauseGame();
			MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
			MainUI.GetYesNoDialogue().SetItemInstanceToSlotUI(slot.itemInstance);
			slot.FDOBDPPMMBH(slot.Stack, CDPAMNIPPEC: true);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("LetGoBird");
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener(new UnityAction(SwapWithLastSlot));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
			slot.FDOBDPPMMBH(slot.Stack, CDPAMNIPPEC: true);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 2f;
			}
		}
	}

	private void AJOBFICNBPN()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || slot.KPINNBKMOMO())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 0;
		if (!flag && list.Count == 0)
		{
			RaycastResult val = list[0];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("Interaction was initiated, but the object is not in range. Only possible in online."))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.LHBPOPOIFLE() is Bird)
		{
			MainUI.MHPHFFHHGJB();
			MainUI.NEFOKCKKLNI().Open(JIIGOACEIKL);
			MainUI.MCPEEGPBPLH().AIPJCMLDEJO(slot.itemInstance);
			slot.FDOBDPPMMBH(slot.Stack);
			((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = LocalisationSystem.Get("roomsRented");
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.MCPEEGPBPLH().noButton.onClick).AddListener(new UnityAction(EDGLFHNAGGI));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.MDJFFOHFGNG(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			slot.FDOBDPPMMBH(slot.Stack, CDPAMNIPPEC: true);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 1429f;
			}
		}
	}

	private void MBMFDJHDNCI()
	{
		if (!OnlineManager.BLGCACDAEHL(JIIGOACEIKL) && slot.itemInstance != null && Item.FKLOBGBIHLB(slot.itemInstance.LHBPOPOIFLE(), null))
		{
			CursorManager.BNBMOFHCNLC(JIIGOACEIKL, (CursorManager.CursorType)7);
		}
	}

	private void MFGANCCJFJK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF(this);
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Combine(commonReferences.OnAnySlotLeftClick, new Action<int, Slot, bool>(HNKMBLPAEDI));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnySlotDragged = (Action<int, Slot>)Delegate.Combine(commonReferences2.OnAnySlotDragged, new Action<int, Slot>(MADEICMHBIP));
		}
	}

	private void DPEDHHNLFFB()
	{
		((Component)slotUI).gameObject.SetActive((uint)slot.Stack > 1u);
		JPHFCJIBBMI();
	}

	private void CLLAKJADGIH()
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Remove(commonReferences.OnAnySlotLeftClick, new Action<int, Slot, bool>(ADMLOBFGEHK));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnySlotDragged = (Action<int, Slot>)Delegate.Remove(commonReferences2.OnAnySlotDragged, new Action<int, Slot>(JOGIIHDAOGO));
		}
	}

	public static bool BPHFLJKCJML(int JIIGOACEIKL)
	{
		return GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO();
	}

	private void ADDLDNPHIHF()
	{
		InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
		player.OnClickOffUI = (Action)Delegate.Combine(player.OnClickOffUI, new Action(CJFFIPFGCNA));
	}

	private void Start()
	{
		if (OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			return;
		}
		if ((Object)(object)slotUI == (Object)null)
		{
			if (JIIGOACEIKL == 1)
			{
				slotUI = CommonReferences.GGFJGHHHEJC.mouseSlotUIPlayer1;
			}
			else if (JIIGOACEIKL == 2)
			{
				slotUI = CommonReferences.GGFJGHHHEJC.mouseSlotUIPlayer2;
			}
			parent = ((Component)slotUI).transform.parent;
		}
		slotUI.IHENCGDNPBL = slot;
		Slot obj = slot;
		obj.OnItemAdded = (Action)Delegate.Combine(obj.OnItemAdded, (Action)delegate
		{
			((Component)slotUI).gameObject.SetActive(slot.Stack != 0);
			Update();
		});
		Slot obj2 = slot;
		obj2.OnItemRemoved = (Action)Delegate.Combine(obj2.OnItemRemoved, (Action)delegate
		{
			((Component)slotUI).gameObject.SetActive(slot.Stack != 0);
			Update();
		});
		((Component)slotUI).gameObject.SetActive(false);
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, (Action<int, UIWindow>)delegate
		{
			FOMDCIMJEEP = null;
		});
	}

	private void JOGIIHDAOGO(int JIIGOACEIKL, Slot OKPFLBLMJKC)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			if (PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-67)))
			{
				Slot.BCEMMDNJAIF(JIIGOACEIKL, OKPFLBLMJKC, slot, (OKPFLBLMJKC.Stack == 0) ? 1 : (OKPFLBLMJKC.Stack / 8));
			}
			else
			{
				Slot.NFBAGDKBOAD(JIIGOACEIKL, OKPFLBLMJKC, slot);
				FOMDCIMJEEP = OKPFLBLMJKC;
				GDLMOFIBLFC = OKPFLBLMJKC;
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.PKOLALFLFNB(new Slot[6] { OKPFLBLMJKC, slot, null, null, null, null }, 1);
			}
		}
	}

	private void FFBDJIJJDMK()
	{
		if (!OnlineManager.BLGCACDAEHL(JIIGOACEIKL) && slot.itemInstance != null && Item.MLBOMGHINCA(slot.itemInstance.LHBPOPOIFLE(), null))
		{
			CursorManager.FPAAGKPLMPM(JIIGOACEIKL, (CursorManager.CursorType)7);
		}
	}

	public void SwapWithLastSlot()
	{
		if (HNBLNEKGKAK == null)
		{
			HNBLNEKGKAK = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(AGLLHDEDBDL());
		}
	}

	private void OnEnable()
	{
		InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
		player.OnClickOffUI = (Action)Delegate.Combine(player.OnClickOffUI, new Action(JDBIKEJJDFI));
	}

	private void JDMMNLKLMAA()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CAAMEEBOAOF(this);
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Combine(commonReferences.OnAnySlotLeftClick, new Action<int, Slot, bool>(HNKMBLPAEDI));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnAnySlotDragged = (Action<int, Slot>)Delegate.Combine(commonReferences2.OnAnySlotDragged, new Action<int, Slot>(PLIDJPKCKOF));
		}
	}

	private void FLFBLIOOLMA()
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Remove(instance.OnAnySlotLeftClick, new Action<int, Slot, bool>(HNKMBLPAEDI));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnySlotDragged = (Action<int, Slot>)Delegate.Remove(instance2.OnAnySlotDragged, new Action<int, Slot>(PLIDJPKCKOF));
		}
	}

	private static bool FEGOKMKGNDC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	private void GANBNCFIEJO(int JIIGOACEIKL, Slot OKPFLBLMJKC, bool OGCAKIGELBJ)
	{
		if (!OGCAKIGELBJ || this.JIIGOACEIKL != JIIGOACEIKL || OKPFLBLMJKC == null)
		{
			return;
		}
		DMDDHPCAGHK = true;
		if (!slot.LCHJGCHDHFO())
		{
			if (PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)125) && !InteractObject.GNCPLNHMFHN(JIIGOACEIKL).LCGGGDPPLGH())
			{
				if (OKPFLBLMJKC.BOMLNEOHFOK(slot.itemInstance))
				{
					Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
					DMDDHPCAGHK = false;
				}
			}
			else if ((PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)127) && InteractObject.GNCPLNHMFHN(JIIGOACEIKL).LCGGGDPPLGH()) || !PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-178)))
			{
				if (OKPFLBLMJKC.LKFKMDLLMAC(slot.itemInstance))
				{
					Slot.PDKCLKKHNOH(JIIGOACEIKL, slot, OKPFLBLMJKC);
					DMDDHPCAGHK = false;
				}
				else
				{
					DMDDHPCAGHK = false;
					Slot.CEENKOEIEHE(JIIGOACEIKL, slot, OKPFLBLMJKC);
					if (FOMDCIMJEEP != null && OKPFLBLMJKC != FOMDCIMJEEP)
					{
						Slot.GHCDPAJHKOI(JIIGOACEIKL, slot, FOMDCIMJEEP);
						if (OnlineManager.PlayingOnline())
						{
							OnlineSlotsManager.instance.SendSlot(FOMDCIMJEEP);
						}
					}
				}
			}
			FOMDCIMJEEP = null;
		}
		else if (PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-167)))
		{
			Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
			DMDDHPCAGHK = false;
		}
		if (DMDDHPCAGHK && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(new Slot[8] { OKPFLBLMJKC, slot, null, null, null, null, null, null });
		}
	}

	private void FECJGKHLBDL(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		FOMDCIMJEEP = null;
	}

	private void IIPIKDOLJDJ()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || slot.LCHJGCHDHFO())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 0;
		if (!flag && list.Count == 1)
		{
			RaycastResult val = list[1];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("Exit build mode"))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.AFOACBIHNCL() is Bird)
		{
			MainUI.MHPHFFHHGJB();
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(JIIGOACEIKL);
			MainUI.NEFOKCKKLNI().JCLBNPICFGM(slot.itemInstance);
			slot.HBMBGCHGEGN(slot.Stack);
			((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = LocalisationSystem.Get("Items/item_description_1134");
			((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener(new UnityAction(EDGLFHNAGGI));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.SpawnDroppedItem(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: true, HFAKAMFMOGM: false, JIIGOACEIKL);
			slot.BBHHJLIFNPP(slot.Stack, CDPAMNIPPEC: true);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 148f;
			}
		}
	}

	public static MouseSlot HELHJMDEDNL(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void KHCJDKHONPK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF(this);
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Combine(instance.OnAnySlotLeftClick, new Action<int, Slot, bool>(HNKMBLPAEDI));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnySlotDragged = (Action<int, Slot>)Delegate.Combine(instance2.OnAnySlotDragged, new Action<int, Slot>(JOGIIHDAOGO));
		}
	}

	private static void FIGJMOHLAKL(MouseSlot HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Pause");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"ChristmasPresentsError");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void EIDJLHFAMIB()
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Remove(commonReferences.OnAnySlotLeftClick, new Action<int, Slot, bool>(GANBNCFIEJO));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotDragged = (Action<int, Slot>)Delegate.Remove(instance.OnAnySlotDragged, new Action<int, Slot>(PLIDJPKCKOF));
		}
	}

	private IEnumerator KAFDHCHGKCL()
	{
		return new IKFBCJBCGLE(1)
		{
			_003C_003E4__this = this
		};
	}

	public static MouseSlot GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void ANMOAFFGEOE()
	{
		InteractObject interactObject = InteractObject.GNCPLNHMFHN(JIIGOACEIKL);
		interactObject.OnClickOffUI = (Action)Delegate.Combine(interactObject.OnClickOffUI, new Action(KHGDDEHNAGJ));
	}

	public static bool IsSlotEmpty(int JIIGOACEIKL)
	{
		return GetPlayer(JIIGOACEIKL).slot.KPINNBKMOMO();
	}

	private void OnDisable()
	{
		if (!((Object)(object)InteractObject.GetPlayer(JIIGOACEIKL) == (Object)null))
		{
			InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
			player.OnClickOffUI = (Action)Delegate.Remove(player.OnClickOffUI, new Action(JDBIKEJJDFI));
		}
	}

	private void MADEICMHBIP(int JIIGOACEIKL, Slot OKPFLBLMJKC)
	{
		if (this.JIIGOACEIKL == JIIGOACEIKL)
		{
			if (PlayerInputs.GetPlayerControllers(JIIGOACEIKL).Keyboard.GetKey((KeyCode)304))
			{
				Slot.IJDEHCDAAHF(JIIGOACEIKL, OKPFLBLMJKC, slot, (OKPFLBLMJKC.Stack == 1) ? 1 : (OKPFLBLMJKC.Stack / 2));
			}
			else
			{
				Slot.NFBAGDKBOAD(JIIGOACEIKL, OKPFLBLMJKC, slot);
				FOMDCIMJEEP = OKPFLBLMJKC;
				GDLMOFIBLFC = OKPFLBLMJKC;
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineSlotsManager.instance.SendSlots(new Slot[2] { OKPFLBLMJKC, slot });
			}
		}
	}

	private void LPKHACNBCLA()
	{
		InteractObject interactObject = InteractObject.BBJCJFJEFKK(JIIGOACEIKL);
		interactObject.OnClickOffUI = (Action)Delegate.Combine(interactObject.OnClickOffUI, new Action(GCLAHMIOCBN));
	}

	private void AOJCCOIHPMH()
	{
		InteractObject player = InteractObject.GetPlayer(JIIGOACEIKL);
		player.OnClickOffUI = (Action)Delegate.Combine(player.OnClickOffUI, new Action(GCLAHMIOCBN));
	}

	private static void CAAMEEBOAOF(MouseSlot HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Trying to add player but player list is full.");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void HNKMBLPAEDI(int JIIGOACEIKL, Slot OKPFLBLMJKC, bool OGCAKIGELBJ)
	{
		if (!OGCAKIGELBJ || this.JIIGOACEIKL != JIIGOACEIKL || OKPFLBLMJKC == null)
		{
			return;
		}
		DMDDHPCAGHK = false;
		if (!slot.LCHJGCHDHFO())
		{
			if (PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)44) && !InteractObject.GetPlayer(JIIGOACEIKL).LCGGGDPPLGH())
			{
				if (OKPFLBLMJKC.BOMLNEOHFOK(slot.itemInstance))
				{
					Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
					DMDDHPCAGHK = true;
				}
			}
			else if ((PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-49)) && InteractObject.BBJCJFJEFKK(JIIGOACEIKL).LCGGGDPPLGH()) || !PlayerInputs.LGGMJONLIGE(JIIGOACEIKL).Keyboard.GetKey((KeyCode)(-21)))
			{
				if (OKPFLBLMJKC.HBODNJCKMAH(slot.itemInstance))
				{
					Slot.NFBAGDKBOAD(JIIGOACEIKL, slot, OKPFLBLMJKC);
					DMDDHPCAGHK = true;
				}
				else
				{
					DMDDHPCAGHK = true;
					Slot.CEENKOEIEHE(JIIGOACEIKL, slot, OKPFLBLMJKC);
					if (FOMDCIMJEEP != null && OKPFLBLMJKC != FOMDCIMJEEP)
					{
						Slot.CEENKOEIEHE(JIIGOACEIKL, slot, FOMDCIMJEEP);
						if (OnlineManager.PlayingOnline())
						{
							OnlineSlotsManager.instance.SendSlot(FOMDCIMJEEP);
						}
					}
				}
			}
			FOMDCIMJEEP = null;
		}
		else if (PlayerInputs.ALKILJCLBOP(JIIGOACEIKL).Keyboard.GetKey((KeyCode)105))
		{
			Slot.MJLNPAEBAFF(JIIGOACEIKL, OKPFLBLMJKC, slot);
			DMDDHPCAGHK = false;
		}
		if (DMDDHPCAGHK && OnlineManager.PlayingOnline())
		{
			OnlineSlotsManager instance = OnlineSlotsManager.instance;
			Slot[] array = new Slot[1];
			array[1] = OKPFLBLMJKC;
			array[1] = slot;
			instance.ILKLIHOGMJP(array, 1);
		}
	}

	private void BKJFLMPOLCH()
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Remove(instance.OnAnySlotLeftClick, new Action<int, Slot, bool>(GANBNCFIEJO));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotDragged = (Action<int, Slot>)Delegate.Remove(commonReferences.OnAnySlotDragged, new Action<int, Slot>(MADEICMHBIP));
		}
	}

	private void GFMFHMDGAJH()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || slot.AHHEMNHJPME())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 0;
		if (!flag && list.Count == 1)
		{
			RaycastResult val = list[1];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("Rummage"))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.KNFNJFFCFNO() is Bird)
		{
			MainUI.MEGGHMCIENG();
			MainUI.NEFOKCKKLNI().Open(JIIGOACEIKL);
			MainUI.GetYesNoDialogue().KMHOCFAMKPH(slot.itemInstance);
			slot.HBMBGCHGEGN(slot.Stack);
			((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.Get("Scene");
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.LBHLPIFCINB().noButton.onClick).AddListener(new UnityAction(SwapWithLastSlot));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.FLPJIPHPNBK(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
			slot.BBHHJLIFNPP(slot.Stack, CDPAMNIPPEC: false, 1);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 431f;
			}
		}
	}

	[CompilerGenerated]
	private void ALAJGDFBAPD()
	{
		((Component)slotUI).gameObject.SetActive(slot.Stack != 0);
		Update();
	}

	private void CIBJEMDPEPF(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		FOMDCIMJEEP = null;
	}

	private void IIPKPMPGLOL()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		FIGJMOHLAKL(this);
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Combine(instance.OnAnySlotLeftClick, new Action<int, Slot, bool>(GANBNCFIEJO));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotDragged = (Action<int, Slot>)Delegate.Combine(commonReferences.OnAnySlotDragged, new Action<int, Slot>(JOGIIHDAOGO));
		}
	}

	private void CJFFIPFGCNA()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || slot.LCHJGCHDHFO())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 1;
		if (!flag && list.Count == 0)
		{
			RaycastResult val = list[0];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("/ExtraSettings.sd"))
			{
				flag = false;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.PHGLMBIEOMK() is Bird)
		{
			MainUI.NMACGFHLOOC(MJKACKBEBPL: false);
			MainUI.MCPEEGPBPLH().OFGKFMJKBON(JIIGOACEIKL);
			MainUI.NEFOKCKKLNI().EHPOHGHHPCJ(slot.itemInstance);
			slot.BBHHJLIFNPP(slot.Stack, CDPAMNIPPEC: true, 1);
			((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.Get("Showing popup ");
			((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.MCPEEGPBPLH().noButton.onClick).AddListener(new UnityAction(EDGLFHNAGGI));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.KDBHKBOAEDG(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
			slot.FDOBDPPMMBH(slot.Stack, CDPAMNIPPEC: true);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 677f;
			}
		}
	}

	private void JDAMCMODANB()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		FIGJMOHLAKL(this);
		if (!OnlineManager.IgnoreDuringOnline(JIIGOACEIKL))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnySlotLeftClick = (Action<int, Slot, bool>)Delegate.Combine(instance.OnAnySlotLeftClick, new Action<int, Slot, bool>(ADMLOBFGEHK));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnySlotDragged = (Action<int, Slot>)Delegate.Combine(commonReferences.OnAnySlotDragged, new Action<int, Slot>(JOGIIHDAOGO));
		}
	}

	private void GLBKAIFOCPO()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || slot.AHHEMNHJPME())
		{
			return;
		}
		List<RaycastResult> list = Utils.OFBMJPNCHAA(JIIGOACEIKL);
		bool flag = list.Count == 0;
		if (!flag && list.Count == 0)
		{
			RaycastResult val = list[1];
			if (((Object)((RaycastResult)(ref val)).gameObject).name.Equals("Melt"))
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		if (slot.itemInstance.KNFNJFFCFNO() is Bird)
		{
			MainUI.PauseGame();
			MainUI.GetYesNoDialogue().OFGKFMJKBON(JIIGOACEIKL);
			MainUI.NEFOKCKKLNI().AIPJCMLDEJO(slot.itemInstance);
			slot.JPACDDCJGPD(slot.Stack);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.Get("questNameFarming");
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(DMFIMDIPFEH));
			((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener(new UnityAction(SwapWithLastSlot));
		}
		else
		{
			DroppedItem droppedItem = DroppedItem.IDDPGGMNFBC(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).gameObject.transform.position, slot.itemInstance, slot.Stack, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
			slot.BBHHJLIFNPP(slot.Stack, CDPAMNIPPEC: true, 1);
			if (Object.op_Implicit((Object)(object)droppedItem))
			{
				droppedItem.pickUpTime = Time.time + 665f;
			}
		}
	}
}
