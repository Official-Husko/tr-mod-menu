using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FoodFeederUI : UIWindow
{
	[CompilerGenerated]
	private sealed class POEFHEKHMKN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FoodFeederUI _003C_003E4__this;

		public SlotUI slotUI;

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
		public POEFHEKHMKN(int _003C_003E1__state)
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
			FoodFeederUI foodFeederUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(foodFeederUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(foodFeederUI.JIIGOACEIKL).Select(((Component)slotUI).GetComponent<Selectable>());
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
	private sealed class IOKOLPOMHJG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FoodFeederUI _003C_003E4__this;

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
		public IOKOLPOMHJG(int _003C_003E1__state)
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
			FoodFeederUI foodFeederUI = _003C_003E4__this;
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
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < foodFeederUI.slotsContentSizeFitter.Length; i++)
				{
					((Behaviour)foodFeederUI.slotsContentSizeFitter[i]).enabled = false;
					((Behaviour)foodFeederUI.slotsContentSizeFitter[i]).enabled = true;
				}
				return false;
			}
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

	private static FoodFeederUI[] GJBBNHCMNJN = new FoodFeederUI[3];

	[SerializeField]
	private SlotUI[] slotsUI;

	[SerializeField]
	private TextMeshProUGUI maxStackText;

	[SerializeField]
	private ContentSizeFitter[] slotsContentSizeFitter;

	private int BCGMJPMMGFD;

	private AnimalFeeder OHPCAOHHOEA;

	private Container ALPOKDOCCGM;

	public static FoodFeederUI MIMFFJHBFDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void JCGJBECHIPB()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).AJCLODBGGHA(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FCGJCBJGOIG());
		}
		GameInventoryUI.MENNLOGFNOK(base.JIIGOACEIKL).PJEIHOCPBLA(list, OGCAKIGELBJ: true);
	}

	private void ODLKCAEDBIE(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack);
		DLPJEKOEPEH();
	}

	public void EGEJKHEKKIE(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(ECJGPBBCNHF));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		POFKAJNAFAI();
	}

	private void BKCHPMMFDJB()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).OMCMMDDGHFB());
		}
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).PFFJANPMCMO(list, OGCAKIGELBJ: true);
	}

	public void SetAnimalFeeder(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i++)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(UpdateTextNumber));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		UpdateTextNumber();
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).Close();
			NIILOKCNLEN();
			base.OpenUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Sound.GGFJGHHHEJC.openWood[0], HOMFPAFAOGD: true);
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
		}
	}

	private IEnumerator EIBJFNFHALI()
	{
		return new IOKOLPOMHJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BIKGJLNBLOP()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < slotsUI.Length; i++)
		{
			slotsUI[i].draggingEnabled = false;
			SlotUI obj = slotsUI[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj2 = slotsUI[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj3 = slotsUI[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
	}

	private void LABMOLAGILN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1);
		MIIMICCMIAL();
	}

	private IEnumerator CFJMHMNBEJB()
	{
		return new IOKOLPOMHJG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OAFGOKJDEFB()
	{
		int num = 1;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "MainProgress" + BCGMJPMMGFD;
	}

	private void BICKFPGPION()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).AJCLODBGGHA(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OMCMMDDGHFB());
		}
		GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).NACCNOFNEHM(list, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void BDDKJFCKLDM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 0, GFNHAMCPEAK: false);
		JNPLIMFICFA();
	}

	public void OFJLKONMNML(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(ECJGPBBCNHF));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		OAFGOKJDEFB();
	}

	public void AJMPDAAKJCK()
	{
		int num = 1;
		for (int i = 0; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "Items/item_name_627" + BCGMJPMMGFD;
	}

	private void BOBKKADBCGO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 0, GFNHAMCPEAK: false);
		LNKHHADLPPD();
	}

	public void CPCONNFDPDH(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(EOOMGEGIIEM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		CEOKPPBELDM();
	}

	public void GEFAJNKPOCF()
	{
		int num = 1;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "Loop" + BCGMJPMMGFD;
	}

	public static FoodFeederUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void IOIPMDBIEML()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots());
		}
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).PFFJANPMCMO(list, OGCAKIGELBJ: false);
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	private void MOBFJKCPPCF()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).FCGJCBJGOIG());
		}
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).CJODJMLPGOL(list, OGCAKIGELBJ: true);
	}

	public void OGJIENDOJKG(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(OAGJIJOIDLM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		UpdateTextNumber();
	}

	public void AJKNDBDGBHC(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(ELNJBIPPHOJ));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		MDJAHIDHFPM();
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			for (int i = 0; i < slotsUI.Length; i++)
			{
				MainUI.RemoveFromCurrentSlots(base.JIIGOACEIKL, slotsUI[i].IHENCGDNPBL);
			}
			if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)OHPCAOHHOEA.onlineAnimalFeederFood))
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(OHPCAOHHOEA.onlineAnimalFeederFood);
			}
			if (Object.op_Implicit((Object)(object)ALPOKDOCCGM))
			{
				Container aLPOKDOCCGM = ALPOKDOCCGM;
				aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Remove(aLPOKDOCCGM.OnContainerChanged, new Action(UpdateTextNumber));
			}
			OHPCAOHHOEA = null;
			ALPOKDOCCGM = null;
		}
	}

	private IEnumerator CGCGGCFKPLI()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	public void POFKAJNAFAI()
	{
		int num = 0;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + " set to follow: " + BCGMJPMMGFD;
	}

	public static FoodFeederUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void KGFDKPFPJNC(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i++)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(ELNJBIPPHOJ));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		ELNJBIPPHOJ();
	}

	private void GOEMPOGBCJM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 0, GFNHAMCPEAK: false);
		NIILOKCNLEN();
	}

	private void IOBCAMEHPNH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack);
		LNKHHADLPPD();
	}

	public static FoodFeederUI FHPEHDDFOIB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void OAGJIJOIDLM()
	{
		int num = 1;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + " and cannot be added again for " + BCGMJPMMGFD;
	}

	private IEnumerator KHILGHGDADB(SlotUI PHJNJCJJHID)
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void FPLKOGHBJHH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1);
		FGEDMGFICAN();
	}

	private void BDFAGNMHKJB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1);
		IOIPMDBIEML();
	}

	public void NBEMPMPHADB(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(NEBHOKMGADN));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		CEOKPPBELDM();
	}

	private IEnumerator HMGAAINDHEL(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public void CBKLDHGHMOK(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(ELNJBIPPHOJ));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		NEBHOKMGADN();
	}

	private void GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1);
		NIILOKCNLEN();
	}

	private void GIBFJPCAEEM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack);
		NIILOKCNLEN();
	}

	private void CCDMDIOLEEC()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).AJCLODBGGHA(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FCGJCBJGOIG());
		}
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).NACCNOFNEHM(list, OGCAKIGELBJ: true);
	}

	public void GPFCLOLONGE(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].MHNCEBLHLKH(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].MHNCEBLHLKH(null);
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(AJMPDAAKJCK));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		DFPNEHCGJMA();
	}

	public void LLEKJIFPEJP(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].LIJPNDJCKGL(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].MHNCEBLHLKH(null);
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(OAGJIJOIDLM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		DFPNEHCGJMA();
	}

	public void DKGNCIPIFAK(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].LIJPNDJCKGL(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(CEOKPPBELDM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		GEFAJNKPOCF();
	}

	private IEnumerator EFCEHBIOCME(SlotUI PHJNJCJJHID)
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	public void KHFGPAFLGFA(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(CEOKPPBELDM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		GEFAJNKPOCF();
	}

	private IEnumerator NFBKNOHICBL()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	private IEnumerator FDJHNCPELAI()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	public void GENKNBBJDIG(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].MHNCEBLHLKH(null);
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(NEBHOKMGADN));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		OAGJIJOIDLM();
	}

	public void OIDEJGNIBLN(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i++)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(UpdateTextNumber));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		ECJGPBBCNHF();
	}

	public static FoodFeederUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void EKPCIHFHHGJ(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i++)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].MHNCEBLHLKH(null);
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(NEBHOKMGADN));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		CEOKPPBELDM();
	}

	public static FoodFeederUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void MIIMICCMIAL()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots());
		}
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).BGPOBAFOPOM(list, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	public static FoodFeederUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void ECJGPBBCNHF()
	{
		int num = 1;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "itemSingleTable" + BCGMJPMMGFD;
	}

	private IEnumerator DGHMMGJGCKJ()
	{
		return new IOKOLPOMHJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PADEMCFKMCE(SlotUI PHJNJCJJHID)
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void CCCIEIPADDK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1);
		FPKEPAFFBDK();
	}

	private void IJJFCOBACFM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, GFNHAMCPEAK: false);
		BICKFPGPION();
	}

	public static FoodFeederUI OMLGNAJPLDE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void DLPJEKOEPEH()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FCGJCBJGOIG());
		}
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).JCOHBJLKLAI(list, OGCAKIGELBJ: true);
	}

	private IEnumerator LNHJBAMIHGE()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	private void NIILOKCNLEN()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetAllSlots());
		}
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(list, OGCAKIGELBJ: false);
	}

	public void EOOMGEGIIEM()
	{
		int num = 0;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "Quest 39 done, complete mission 301" + BCGMJPMMGFD;
	}

	public void FNCGILNMEFK(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(false);
			slotsUI[i].MHNCEBLHLKH(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(AJMPDAAKJCK));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		DFPNEHCGJMA();
	}

	public void DFPNEHCGJMA()
	{
		int num = 1;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "Items/item_description_1058" + BCGMJPMMGFD;
	}

	private IEnumerator HOGNPKJODIL()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	private void IPOPHKODNOD()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).OMCMMDDGHFB());
		}
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).JCOHBJLKLAI(list, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private IEnumerator HPKKBLBMEKP(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public void KAFBAHKFOMD(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i++)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(OAFGOKJDEFB));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		OAGJIJOIDLM();
	}

	public static FoodFeederUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void ABLCHNDINIA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1);
		OMABEEOPNGJ();
	}

	public void ELNJBIPPHOJ()
	{
		int num = 0;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "\n<color=#A95A00>" + BCGMJPMMGFD;
	}

	private void MNMOCGFLKIJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 0, GFNHAMCPEAK: false);
		FGEDMGFICAN();
	}

	private IEnumerator MGIKEAMLILJ()
	{
		return new IOKOLPOMHJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AHGCDIOKLEG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 0, GFNHAMCPEAK: false);
		IOIPMDBIEML();
	}

	private void NIGLHEDALIF()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).GetAllSlots());
		}
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).BGPOBAFOPOM(list, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private IEnumerator JIAKBDEDOCK()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	private void IIHPJOCBGBE(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1, GFNHAMCPEAK: false);
		JHLAAGKGPEB();
	}

	private void GANMBHKDMOG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 0, GFNHAMCPEAK: false);
		DGEHMMDJBHJ();
	}

	private IEnumerator LGMGANPOKDE(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public void FHACFIBEIAA(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 1; i < OHPCAOHHOEA.container.slots.Length; i++)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].IHENCGDNPBL = OHPCAOHHOEA.container.slots[i];
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(EOOMGEGIIEM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		MDJAHIDHFPM();
	}

	private IEnumerator IFGCDIGPGPP(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	private IEnumerator GDJJLHPOKDA()
	{
		return new IOKOLPOMHJG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NEBHOKMGADN()
	{
		int num = 1;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "\n" + BCGMJPMMGFD;
	}

	public void CGGGMGIBPPL(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j += 0)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(false);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(OAGJIJOIDLM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		DFPNEHCGJMA();
	}

	private IEnumerator MEKCPIDCOPN()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	private IEnumerator KLBHFOGFIAJ()
	{
		return new IOKOLPOMHJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DGEHMMDJBHJ()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots());
		}
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).PreparePagesMode(list, OGCAKIGELBJ: true);
	}

	private void ELMEGKOAFFP()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBDOBNLMLGM());
		}
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(list, OGCAKIGELBJ: true);
	}

	private void PFOJFILNJIN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack);
		NIILOKCNLEN();
	}

	private void PCFFMFEOBLI()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetAllSlots());
		}
		GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).JCOHBJLKLAI(list, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private IEnumerator BBPLMEBLKFA()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	private void IIMKCBONPHL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1);
		NIILOKCNLEN();
	}

	private IEnumerator CKAKOHCHPHH(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public void BLODKADEDAH(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i++)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].MHNCEBLHLKH(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].IHENCGDNPBL = null;
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(CEOKPPBELDM));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		ELNJBIPPHOJ();
	}

	private void FPKEPAFFBDK()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots());
		}
		GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).CJODJMLPGOL(list, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void NBFDDKAHFJN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, 1, GFNHAMCPEAK: false);
		NIGLHEDALIF();
	}

	public static FoodFeederUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private IEnumerator EJFPIDAAODG(SlotUI PHJNJCJJHID)
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	private void LNKHHADLPPD()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).GetAllSlots());
		}
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).CNOCEADFCLD(list, OGCAKIGELBJ: false);
	}

	private void BJBANLPPKLM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack);
		DLPJEKOEPEH();
	}

	private IEnumerator MJDMBNPHPNL(SlotUI PHJNJCJJHID)
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)PHJNJCJJHID).GetComponent<Selectable>());
		}
	}

	public static FoodFeederUI BFCEHJIIAHN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void DACCFBBLECH(AnimalFeeder OHPCAOHHOEA, int JFNMCNCHMEO, int BCGMJPMMGFD)
	{
		for (int i = 0; i < OHPCAOHHOEA.container.slots.Length; i += 0)
		{
			((Component)slotsUI[i]).gameObject.SetActive(true);
			slotsUI[i].LIJPNDJCKGL(OHPCAOHHOEA.container.slots[i]);
		}
		for (int j = OHPCAOHHOEA.container.slots.Length; j < slotsUI.Length; j++)
		{
			slotsUI[j].LIJPNDJCKGL(null);
			((Component)slotsUI[j]).gameObject.SetActive(true);
		}
		this.OHPCAOHHOEA = OHPCAOHHOEA;
		ALPOKDOCCGM = OHPCAOHHOEA.container;
		Container aLPOKDOCCGM = ALPOKDOCCGM;
		aLPOKDOCCGM.OnContainerChanged = (Action)Delegate.Combine(aLPOKDOCCGM.OnContainerChanged, new Action(AJMPDAAKJCK));
		this.BCGMJPMMGFD = BCGMJPMMGFD;
		ECJGPBBCNHF();
	}

	private void FGEDMGFICAN()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i++)
			{
				list.AddRange(PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).GetAllSlots());
		}
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).BGPOBAFOPOM(list, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private IEnumerator OBBHBDIFEOO()
	{
		yield return null;
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
	}

	public void UpdateTextNumber()
	{
		int num = 0;
		for (int i = 0; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "/" + BCGMJPMMGFD;
	}

	private void JHBOFENMOCP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack);
		FGEDMGFICAN();
	}

	private IEnumerator GJKFNNJJPNK(SlotUI PHJNJCJJHID)
	{
		return new POEFHEKHMKN(1)
		{
			_003C_003E4__this = this,
			slotUI = PHJNJCJJHID
		};
	}

	public void MDJAHIDHFPM()
	{
		int num = 1;
		for (int i = 1; i < slotsUI.Length; i += 0)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "UIInteract" + BCGMJPMMGFD;
	}

	private void GGKJGEALPKI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		OHPCAOHHOEA.AnimalFeederSlotPressed(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, GFNHAMCPEAK: false);
		MOBFJKCPPCF();
	}

	public void CEOKPPBELDM()
	{
		int num = 1;
		for (int i = 1; i < slotsUI.Length; i++)
		{
			if (slotsUI[i].IHENCGDNPBL != null)
			{
				num += slotsUI[i].IHENCGDNPBL.Stack;
			}
		}
		((TMP_Text)maxStackText).text = num + "TermasInterior/Rin/Intro" + BCGMJPMMGFD;
	}

	private void JNPLIMFICFA()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).FCGJCBJGOIG());
		}
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).BGPOBAFOPOM(list, OGCAKIGELBJ: false);
	}

	private void OMABEEOPNGJ()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 1; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null, DDAPJEAJGGA: true));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FCGJCBJGOIG());
		}
		GameInventoryUI.AEJKCONFPHB(base.JIIGOACEIKL).JCOHBJLKLAI(list, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		for (int i = 0; i < slotsContentSizeFitter.Length; i++)
		{
			((Behaviour)slotsContentSizeFitter[i]).enabled = false;
			((Behaviour)slotsContentSizeFitter[i]).enabled = true;
		}
		((MonoBehaviour)this).StartCoroutine(HOGNPKJODIL());
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		Slot[] containerSlots = GameInventoryUI.Get(base.JIIGOACEIKL).containerSlots;
		if (containerSlots != null && containerSlots.Where((Slot x) => x != null && !x.KPINNBKMOMO()).ToArray().Length == 0)
		{
			for (int j = 0; j < slotsUI.Length; j++)
			{
				if (slotsUI[j].IHENCGDNPBL != null && !slotsUI[j].IHENCGDNPBL.KPINNBKMOMO())
				{
					((MonoBehaviour)this).StartCoroutine(HMGAAINDHEL(slotsUI[j]));
					return;
				}
			}
		}
		GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
	}

	private void JHLAAGKGPEB()
	{
		List<Slot> list;
		if (ALPOKDOCCGM.allowedItemsList.Length != 0)
		{
			list = new List<Slot>();
			for (int i = 0; i < ALPOKDOCCGM.allowedItemsList.Length; i += 0)
			{
				list.AddRange(PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(ALPOKDOCCGM.allowedItemsList[i], null));
			}
		}
		else
		{
			list = new List<Slot>(PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).FCGJCBJGOIG());
		}
		GameInventoryUI.NALKHGMLALJ(base.JIIGOACEIKL).DHFABEONKBG(list, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}
}
