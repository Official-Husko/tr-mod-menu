using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AgingBarrelUI : UIWindow
{
	[CompilerGenerated]
	private sealed class PIKLMFNNLDM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AgingBarrelUI _003C_003E4__this;

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
		public PIKLMFNNLDM(int _003C_003E1__state)
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
			AgingBarrelUI agingBarrelUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(agingBarrelUI.JIIGOACEIKL))
				{
					SlotUI[] array = agingBarrelUI.NKGHEGFGFEM(agingBarrelUI.agingBarrel.agingSlotsNum);
					for (int i = 0; i < array.Length; i++)
					{
						if (!array[i].IHENCGDNPBL.KPINNBKMOMO())
						{
							UISelectionManager.GetPlayer(agingBarrelUI.JIIGOACEIKL).Select(((Component)array[i]).GetComponent<Selectable>());
							break;
						}
						UISelectionManager.GetPlayer(agingBarrelUI.JIIGOACEIKL).Deselect();
						GameInventoryUI.Get(agingBarrelUI.JIIGOACEIKL).SelectObjectNextFrame();
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

	public AgingBarrel agingBarrel;

	[SerializeField]
	private SlotUI[] inputSlot;

	[SerializeField]
	private SlotUI[] inputSlot3;

	[SerializeField]
	private SlotUI[] inputSlot5;

	public static AgingBarrelUI[] instances = new AgingBarrelUI[3];

	public GameObject[] agingContents;

	public Progressor[] progressor;

	public Progressor[] progressor3;

	public Progressor[] progressor5;

	public Sprite spriteSlotActive;

	public Sprite spriteSlotDisable;

	private bool ENHNEGAHLON;

	public static AgingBarrelUI BPBMLNJGGII(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void NGPAHDJKOMK()
	{
		for (int i = 1; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(OOBKBGEHMEC));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(KIKHCGHGEAJ));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(BEOGIGNABFB));
		}
		for (int j = 1; j < inputSlot3.Length; j++)
		{
			SlotUI obj4 = inputSlot3[j];
			obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj4.OnSlotLeftClick, new Action<int, Slot>(OOBKBGEHMEC));
			SlotUI obj5 = inputSlot3[j];
			obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj5.OnSlotRightClick, new Action<int, Slot>(BOGEFBAODIJ));
			SlotUI obj6 = inputSlot3[j];
			obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj6.OnAutomaticTransfer, new Action<int, Slot>(AFJKLJKPNNB));
		}
		for (int k = 0; k < inputSlot5.Length; k++)
		{
			SlotUI obj7 = inputSlot5[k];
			obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj7.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
			SlotUI obj8 = inputSlot5[k];
			obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj8.OnSlotRightClick, new Action<int, Slot>(IICLGNHLNPN));
			SlotUI obj9 = inputSlot5[k];
			obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj9.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
		}
	}

	public static AgingBarrelUI IJJJEMKCNJM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IJJFCOBACFM(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 0)
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_1134"), 188f);
		}
		else
		{
			GDEMFDGKFBH();
		}
	}

	public void JBALLPPLIFD(int ABAIKKGKDGD)
	{
		for (int i = 0; i < agingContents.Length; i++)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	private void KEGGLFFIMFH()
	{
		ENHNEGAHLON = true;
		SlotUI[] array = PMBKDLCENMO(agingBarrel.agingSlotsNum);
		for (int i = 1; i < array.Length; i++)
		{
			array[i].MHNCEBLHLKH(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 8)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 2)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 0)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 2)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.NNCOKOFBKHE(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	public void NEFEIJMJGCD(int ABAIKKGKDGD)
	{
		for (int i = 1; i < agingContents.Length; i++)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	private bool GICOPKCABLF(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[1].PCCLMIEGMCE(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 5)
		{
			return (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged;
		}
		return false;
	}

	protected override void Update()
	{
		base.Update();
		if (!IsOpen() || agingBarrel.timer == null)
		{
			return;
		}
		if (agingBarrel.timer.Length >= 5)
		{
			for (int i = 0; i < progressor5.Length; i++)
			{
				if (progressor5 != null && (Object)(object)agingBarrel.timer[i].progressor != (Object)null)
				{
					progressor5[i].BHGJPBGINCG = agingBarrel.timer[i].GetProgressValue();
				}
				else if (progressor5 != null)
				{
					progressor5[i].BHGJPBGINCG = 0f;
				}
			}
			return;
		}
		if (agingBarrel.timer.Length >= 3)
		{
			for (int j = 0; j < progressor3.Length; j++)
			{
				if (progressor3 != null && (Object)(object)agingBarrel.timer[j].progressor != (Object)null)
				{
					progressor3[j].BHGJPBGINCG = agingBarrel.timer[j].GetProgressValue();
				}
				else if (progressor3 != null)
				{
					progressor3[j].BHGJPBGINCG = 0f;
				}
			}
			return;
		}
		for (int k = 0; k < progressor.Length; k++)
		{
			if (progressor != null && (Object)(object)agingBarrel.timer[k].progressor != (Object)null)
			{
				progressor[k].BHGJPBGINCG = agingBarrel.timer[k].GetProgressValue();
			}
			else if (progressor != null)
			{
				progressor[k].BHGJPBGINCG = 0f;
			}
		}
	}

	private void KFHFKBPOMAL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Masters/Klayn/Banquet"), 232f);
		}
		else
		{
			JDLGLCBHBNG();
		}
	}

	private void JCPBADGHKCM()
	{
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(IJJFCOBACFM));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
		for (int j = 1; j < inputSlot3.Length; j++)
		{
			SlotUI obj4 = inputSlot3[j];
			obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj4.OnSlotLeftClick, new Action<int, Slot>(JEPNBKGEDAC));
			SlotUI obj5 = inputSlot3[j];
			obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj5.OnSlotRightClick, new Action<int, Slot>(KNDMEBCMOBP));
			SlotUI obj6 = inputSlot3[j];
			obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj6.OnAutomaticTransfer, new Action<int, Slot>(JEPNBKGEDAC));
		}
		for (int k = 1; k < inputSlot5.Length; k++)
		{
			SlotUI obj7 = inputSlot5[k];
			obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj7.OnSlotLeftClick, new Action<int, Slot>(BOBKKADBCGO));
			SlotUI obj8 = inputSlot5[k];
			obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj8.OnSlotRightClick, new Action<int, Slot>(KFHFKBPOMAL));
			SlotUI obj9 = inputSlot5[k];
			obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj9.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
		}
	}

	private void OOBKBGEHMEC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("\n"), 1381f);
			}
		}
		else
		{
			HCHIMFALOGD();
		}
	}

	private void KIKHCGHGEAJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
		if (FNNBABJKAIH > 0)
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("questRequired"), 136f);
		}
		else
		{
			GDEMFDGKFBH();
		}
	}

	private void BOGEFBAODIJ(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("popUpBuilding5"), 872f);
		}
		else
		{
			HCHIMFALOGD();
		}
	}

	private void LMNKOMLKIAA()
	{
		if (ENHNEGAHLON)
		{
			MJGNGGNLKJK();
		}
	}

	private void DDFCGOFPLCA()
	{
		for (int i = 1; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(AFJKLJKPNNB));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(BEOGIGNABFB));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(OOBKBGEHMEC));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(AFJKLJKPNNB));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(BEOGIGNABFB));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(KNDMEBCMOBP));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(JEPNBKGEDAC));
			}
		}
	}

	private SlotUI[] AIJODJDPGHF(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	public static AgingBarrelUI BDJFHFHLJGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KNDMEBCMOBP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Right Stick Button"), 244f);
		}
		else
		{
			JDLGLCBHBNG();
		}
	}

	public static AgingBarrelUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[CompilerGenerated]
	private bool OGBAMOAPIMG(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[0].GPLKPEPAFOM(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 4)
		{
			return (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged;
		}
		return false;
	}

	public void ActiveContent(int ABAIKKGKDGD)
	{
		for (int i = 0; i < agingContents.Length; i++)
		{
			agingContents[i].SetActive(false);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < inputSlot.Length; i++)
		{
			inputSlot[i].draggingEnabled = false;
		}
		for (int j = 0; j < inputSlot3.Length; j++)
		{
			inputSlot3[j].draggingEnabled = false;
		}
		for (int k = 0; k < inputSlot5.Length; k++)
		{
			inputSlot5[k].draggingEnabled = false;
		}
	}

	public static AgingBarrelUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PFOJFILNJIN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 0)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Inventory full"));
		}
		else
		{
			NIILOKCNLEN();
		}
	}

	private void IOBCAMEHPNH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("start fish"), 336f);
		}
		else
		{
			BEDHHHFPIBD();
		}
	}

	private void LateUpdate()
	{
		if (ENHNEGAHLON)
		{
			HAOMJJDJIKC();
		}
	}

	private void AFJKLJKPNNB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("waterQualityTestDone"), 1145f);
			}
		}
		else
		{
			HIGOCKHIGBF();
		}
	}

	private void ABGLNGIILCA()
	{
		ENHNEGAHLON = true;
		SlotUI[] array = NKGHEGFGFEM(agingBarrel.agingSlotsNum);
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].IHENCGDNPBL = agingBarrel.inputSlot[i];
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 7)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 6)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 7)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 3)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.MPMEMCEAGDP(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void IAFFLKFFEGG(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("add item "), 442f);
			}
		}
		else
		{
			NNMAPBIKEKJ();
		}
	}

	private void HGOOHJJFGDD()
	{
		for (int i = 1; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BEOGIGNABFB));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(MFFBEPKGKDP));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(AFJKLJKPNNB));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(BEOGIGNABFB));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(IOBCAMEHPNH));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(BOBKKADBCGO));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(OOBKBGEHMEC));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(KFHFKBPOMAL));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
			}
		}
	}

	private void NIILOKCNLEN()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL).GetAllSlots()
			select (x) into NCPGNLOJGAF
			where NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[0].GPLKPEPAFOM(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 4 && (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged
			select NCPGNLOJGAF).ToList();
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void IGBGDNILPJG()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = DIOOBOCCNEA(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].IHENCGDNPBL = agingBarrel.inputSlot[i];
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 4)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.MPMEMCEAGDP(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 1)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = true;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
				MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	public static AgingBarrelUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void GCKNEJIFGFI(int ABAIKKGKDGD)
	{
		for (int i = 1; i < agingContents.Length; i++)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	private void BLBNAPODBEB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.PKFKJNODGJF())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Attack/MainEvent 2"), 81f);
			}
		}
		else
		{
			BPMAFFOKDJP();
		}
	}

	public void DOIJHOBBELL(int ABAIKKGKDGD)
	{
		for (int i = 0; i < agingContents.Length; i += 0)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	private void PFJDMDKOBMH()
	{
		for (int i = 1; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BEOGIGNABFB));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(CNIAFHAMLHL));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(AFJKLJKPNNB));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(CNIAFHAMLHL));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(OOBKBGEHMEC));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(PJPIDMDMFAA));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
			}
		}
	}

	private void LEDHDOPACJI(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("null sprite"), 196f);
		}
		else
		{
			JDLGLCBHBNG();
		}
	}

	private void BOBKKADBCGO(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Debug"), 1027f);
			}
		}
		else
		{
			HIGOCKHIGBF();
		}
	}

	private void PJPIDMDMFAA(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 1)
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("SmokeBomb"), 1437f);
		}
		else
		{
			JECLPOMBINJ();
		}
	}

	private void HIGOCKHIGBF()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).BBDOBNLMLGM()
			select (x)).Where(FMBDGOAFBEA).ToList();
		GameInventoryUI.MENNLOGFNOK(base.JIIGOACEIKL).BGPOBAFOPOM(pCJEDMJEKEF, OGCAKIGELBJ: true);
	}

	private void BECJDDINEFN()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = OCIBKDJNMJF(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].LIJPNDJCKGL(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 1)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					MainUI.PFIMFMJJMHK(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 5)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 8)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = true;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.NNCOKOFBKHE(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void HJKKGGCKHKK()
	{
		if (ENHNEGAHLON)
		{
			EJENADHNLDA();
		}
	}

	private void LDEELPOCNEM()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = DIOOBOCCNEA(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].IHENCGDNPBL = agingBarrel.inputSlot[i];
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 0)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 2)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.NNCOKOFBKHE(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 2)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 3)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.PFIMFMJJMHK(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void BPMAFFOKDJP()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).BBDOBNLMLGM()
			select (x) into NCPGNLOJGAF
			where NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[0].GPLKPEPAFOM(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 4 && (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged
			select NCPGNLOJGAF).ToList();
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).BGPOBAFOPOM(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void JECLPOMBINJ()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).FCGJCBJGOIG()
			select (x)).Where(PIAAPGDLKMJ).ToList();
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).BGPOBAFOPOM(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void MFFBEPKGKDP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
		if (FNNBABJKAIH > 1)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("ObjectVerticalMove"), 601f);
		}
		else
		{
			BPMAFFOKDJP();
		}
	}

	public static AgingBarrelUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			NIILOKCNLEN();
			ENHNEGAHLON = true;
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.openWood), HOMFPAFAOGD: true);
			LJCDLOIMPPF();
		}
	}

	private void GMNJJIGMJEG()
	{
		if (ENHNEGAHLON)
		{
			MJGNGGNLKJK();
		}
	}

	private void KNPEGPBNEFP()
	{
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BEOGIGNABFB));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PJPIDMDMFAA));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(BEOGIGNABFB));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 1; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(JEPNBKGEDAC));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(KNDMEBCMOBP));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(IAFFLKFFEGG));
			}
		}
		for (int k = 0; k < inputSlot5.Length; k += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(KFHCLPLLEJH));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
			}
		}
	}

	public void JODAEMHIOGJ(int ABAIKKGKDGD)
	{
		for (int i = 0; i < agingContents.Length; i += 0)
		{
			agingContents[i].SetActive(false);
		}
		agingContents[ABAIKKGKDGD].SetActive(false);
	}

	private void NLCBFHCGCBH()
	{
		for (int i = 1; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(KFHFKBPOMAL));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
			}
		}
		for (int k = 0; k < inputSlot5.Length; k++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(KIKHCGHGEAJ));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(BEOGIGNABFB));
			}
		}
	}

	private void FPCBCILFIMN()
	{
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(CNIAFHAMLHL));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 1; j < inputSlot3.Length; j++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(IICLGNHLNPN));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(AFJKLJKPNNB));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(KNDMEBCMOBP));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(AFJKLJKPNNB));
			}
		}
	}

	private void IICLGNHLNPN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get(" "), 1617f);
		}
		else
		{
			JECLPOMBINJ();
		}
	}

	private void GDEMFDGKFBH()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).BBDOBNLMLGM()
			select (x)).Where(KGKBJGGMOPE).ToList();
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).NACCNOFNEHM(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void JOFDJHCFACP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH);
		if (FNNBABJKAIH > 1)
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Left Stick Up"), 110f);
		}
		else
		{
			JECLPOMBINJ();
		}
	}

	private void DEDDGMJNEPI()
	{
		if (ENHNEGAHLON)
		{
			KEGGLFFIMFH();
		}
	}

	private IEnumerator HDCLLENAFFA()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		SlotUI[] array = NKGHEGFGFEM(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)array[i]).GetComponent<Selectable>());
				break;
			}
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	private SlotUI[] JALEBADHBKC(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	private void MJGNGGNLKJK()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = PGJPIEGCNIG(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].IHENCGDNPBL = agingBarrel.inputSlot[i];
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 7)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					MainUI.MDLCJHPNKJB(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 6)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 1)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = true;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void ILDICDKOLEP()
	{
		if (ENHNEGAHLON)
		{
			DIDLEPOKBGL();
		}
	}

	private IEnumerator IIDHJGFJHHF()
	{
		return new PIKLMFNNLDM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OLOFBDBBODN(int ABAIKKGKDGD)
	{
		for (int i = 0; i < agingContents.Length; i++)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(false);
	}

	private IEnumerator GMFBFOJHLII()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		SlotUI[] array = NKGHEGFGFEM(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)array[i]).GetComponent<Selectable>());
				break;
			}
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	public void JOHMBCLAPIH(int ABAIKKGKDGD)
	{
		for (int i = 1; i < agingContents.Length; i += 0)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	private void HAAFNKAJFDO()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = MFFIABEEFJB(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].LIJPNDJCKGL(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 0)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 1)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 8)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 5)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.MDLCJHPNKJB(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void BEOGIGNABFB(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1, CDPAMNIPPEC: false))
		{
			if (!ADEBNALPEHE.LCHJGCHDHFO())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("UI/ColorPicker"), 498f);
			}
		}
		else
		{
			NNMAPBIKEKJ();
		}
	}

	private SlotUI[] MFFIABEEFJB(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	private void ODDFDFHFAGD()
	{
		for (int i = 1; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BEOGIGNABFB));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PJPIDMDMFAA));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 1; j < inputSlot3.Length; j++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(BOBKKADBCGO));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(MFFBEPKGKDP));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
			}
		}
		for (int k = 0; k < inputSlot5.Length; k += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(KNDMEBCMOBP));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
			}
		}
	}

	private bool KGKBJGGMOPE(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[1].FPBONPGAKED(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 2)
		{
			return (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged;
		}
		return true;
	}

	private void KFHCLPLLEJH(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get(" %"), 422f);
		}
		else
		{
			BPMAFFOKDJP();
		}
	}

	private void ECJEGMEBBAM()
	{
		if (ENHNEGAHLON)
		{
			KEGGLFFIMFH();
		}
	}

	private void NIHPGPKCFHK()
	{
		for (int i = 1; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(IAFFLKFFEGG));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(AFJKLJKPNNB));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(JHBOFENMOCP));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(DDCJJOAHOLK));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(IAFFLKFFEGG));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(MFFBEPKGKDP));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
			}
		}
	}

	private bool FMBDGOAFBEA(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[1].MDABLLHEDAC(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 4)
		{
			return (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged;
		}
		return false;
	}

	private void JHNDCOEEGNK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("ReceiveEndIntroLucen"), 900f);
			}
		}
		else
		{
			JECLPOMBINJ();
		}
	}

	private void JDLGLCBHBNG()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).BBDOBNLMLGM()
			select (x)).Where(PIAAPGDLKMJ).ToList();
		GameInventoryUI.MENNLOGFNOK(base.JIIGOACEIKL).JCOHBJLKLAI(pCJEDMJEKEF, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
	}

	private void LJCDLOIMPPF()
	{
		for (int i = 0; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
			}
		}
		for (int k = 0; k < inputSlot5.Length; k++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
			}
		}
	}

	private void ABBMBGINFBP()
	{
		for (int i = 1; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(BOBKKADBCGO));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(IAFFLKFFEGG));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(BEOGIGNABFB));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(KFHFKBPOMAL));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(DDCJJOAHOLK));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(BHMJHLPFLGP));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(IAFFLKFFEGG));
			}
		}
	}

	private SlotUI[] ANFOELBLGJP(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	public void KIILNJJMMBP(int ABAIKKGKDGD)
	{
		for (int i = 1; i < agingContents.Length; i++)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(false);
	}

	private void BHMJHLPFLGP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 0)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("ReceiveDereserveSpotAdoptionSignal"), 1505f);
		}
		else
		{
			HCHIMFALOGD();
		}
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

	private void CNIAFHAMLHL(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 1);
		if (FNNBABJKAIH > 1)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("): "), 232f);
		}
		else
		{
			GDEMFDGKFBH();
		}
	}

	private void JEPNBKGEDAC(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Furniture"), 789f);
			}
		}
		else
		{
			HCHIMFALOGD();
		}
	}

	private void EJENADHNLDA()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = ANFOELBLGJP(agingBarrel.agingSlotsNum);
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].MHNCEBLHLKH(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 6)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.NNCOKOFBKHE(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 8)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 8)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = true;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.NNCOKOFBKHE(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private SlotUI[] PGJPIEGCNIG(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	private void MEHILHIAGKE()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).OMCMMDDGHFB()
			select (x)).Where(NICIEFABKIJ).ToList();
		GameInventoryUI.AEJKCONFPHB(base.JIIGOACEIKL).PFFJANPMCMO(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void LPOFBKLGMFA()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FCGJCBJGOIG()
			select (x)).Where(GICOPKCABLF).ToList();
		GameInventoryUI.BGIMGOJDLFG(base.JIIGOACEIKL).NACCNOFNEHM(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private void BEDHHHFPIBD()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).BBDOBNLMLGM()
			select (x)).Where(NICIEFABKIJ).ToList();
		GameInventoryUI.Get(base.JIIGOACEIKL).CNOCEADFCLD(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
	}

	private SlotUI[] NKGHEGFGFEM(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			base.CloseUI();
			GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			MainUI.ClearCurrentSlots(base.JIIGOACEIKL);
			HCKEINLEHOA();
		}
	}

	private void PEDABKILCOH()
	{
		if (ENHNEGAHLON)
		{
			HLGLHGPBGMF();
		}
	}

	public void NFBGPJLJFNJ(int ABAIKKGKDGD)
	{
		for (int i = 1; i < agingContents.Length; i += 0)
		{
			agingContents[i].SetActive(false);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	public static AgingBarrelUI LBKJEHDEBEP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LOEELCMBOGA()
	{
		for (int i = 1; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(IJJFCOBACFM));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(IAFFLKFFEGG));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(KIKHCGHGEAJ));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(BEOGIGNABFB));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(KNDMEBCMOBP));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
			}
		}
	}

	public static AgingBarrelUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LOAILCIAGPE(int ABAIKKGKDGD)
	{
		for (int i = 0; i < agingContents.Length; i += 0)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(false);
	}

	private void NNMAPBIKEKJ()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).OMCMMDDGHFB()
			select (x)).Where(PIAAPGDLKMJ).ToList();
		GameInventoryUI.AEJKCONFPHB(base.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	private void DDCJJOAHOLK(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		if (!Utils.DKHBBNHMOEB(JIIGOACEIKL, ADEBNALPEHE, 1))
		{
			if (!ADEBNALPEHE.AHHEMNHJPME())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get(" x "), 854f);
			}
		}
		else
		{
			HIGOCKHIGBF();
		}
	}

	public void IJACEODJCME(int ABAIKKGKDGD)
	{
		for (int i = 1; i < agingContents.Length; i += 0)
		{
			agingContents[i].SetActive(true);
		}
		agingContents[ABAIKKGKDGD].SetActive(false);
	}

	private void CBKMCHOBGLK()
	{
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(OOBKBGEHMEC));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(CNIAFHAMLHL));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(DDCJJOAHOLK));
		}
		for (int j = 1; j < inputSlot3.Length; j += 0)
		{
			SlotUI obj4 = inputSlot3[j];
			obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj4.OnSlotLeftClick, new Action<int, Slot>(JEPNBKGEDAC));
			SlotUI obj5 = inputSlot3[j];
			obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj5.OnSlotRightClick, new Action<int, Slot>(IICLGNHLNPN));
			SlotUI obj6 = inputSlot3[j];
			obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj6.OnAutomaticTransfer, new Action<int, Slot>(AFJKLJKPNNB));
		}
		for (int k = 1; k < inputSlot5.Length; k += 0)
		{
			SlotUI obj7 = inputSlot5[k];
			obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj7.OnSlotLeftClick, new Action<int, Slot>(AFJKLJKPNNB));
			SlotUI obj8 = inputSlot5[k];
			obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj8.OnSlotRightClick, new Action<int, Slot>(JHBOFENMOCP));
			SlotUI obj9 = inputSlot5[k];
			obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj9.OnAutomaticTransfer, new Action<int, Slot>(OOBKBGEHMEC));
		}
	}

	private void IHDEBGJLOIG()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = PMBKDLCENMO(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].LIJPNDJCKGL(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 7)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.MDLCJHPNKJB(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 6)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 1)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.MDLCJHPNKJB(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	public static AgingBarrelUI GFPBMGCMHHC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void NODNNAAMCPB()
	{
		if (ENHNEGAHLON)
		{
			IHDEBGJLOIG();
		}
	}

	private void JHBOFENMOCP(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FAIGKGNBDGB(JIIGOACEIKL, ADEBNALPEHE, ADEBNALPEHE.Stack, out var FNNBABJKAIH, 0, CDPAMNIPPEC: false);
		if (FNNBABJKAIH > 1)
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("mainMenuMultiplayerButton"), 1872f);
		}
		else
		{
			GDEMFDGKFBH();
		}
	}

	private void ECHBDCFPPOO()
	{
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(JEPNBKGEDAC));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(KIKHCGHGEAJ));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(AFJKLJKPNNB));
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			SlotUI obj4 = inputSlot3[j];
			obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj4.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
			SlotUI obj5 = inputSlot3[j];
			obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj5.OnSlotRightClick, new Action<int, Slot>(KFHCLPLLEJH));
			SlotUI obj6 = inputSlot3[j];
			obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj6.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
		}
		for (int k = 0; k < inputSlot5.Length; k++)
		{
			SlotUI obj7 = inputSlot5[k];
			obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj8 = inputSlot5[k];
			obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj8.OnSlotRightClick, new Action<int, Slot>(IICLGNHLNPN));
			SlotUI obj9 = inputSlot5[k];
			obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj9.OnAutomaticTransfer, new Action<int, Slot>(DDCJJOAHOLK));
		}
	}

	private void HPLOIMBBFAJ()
	{
		for (int i = 0; i < inputSlot.Length; i += 0)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(IAFFLKFFEGG));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(KFHFKBPOMAL));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
		}
		for (int j = 1; j < inputSlot3.Length; j += 0)
		{
			SlotUI obj4 = inputSlot3[j];
			obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj4.OnSlotLeftClick, new Action<int, Slot>(IAFFLKFFEGG));
			SlotUI obj5 = inputSlot3[j];
			obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj5.OnSlotRightClick, new Action<int, Slot>(BOGEFBAODIJ));
			SlotUI obj6 = inputSlot3[j];
			obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj6.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
		}
		for (int k = 1; k < inputSlot5.Length; k++)
		{
			SlotUI obj7 = inputSlot5[k];
			obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj7.OnSlotLeftClick, new Action<int, Slot>(BLBNAPODBEB));
			SlotUI obj8 = inputSlot5[k];
			obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj8.OnSlotRightClick, new Action<int, Slot>(KFHFKBPOMAL));
			SlotUI obj9 = inputSlot5[k];
			obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj9.OnAutomaticTransfer, new Action<int, Slot>(AFJKLJKPNNB));
		}
	}

	private bool PIAAPGDLKMJ(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[1].FPBONPGAKED(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 3)
		{
			return (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged;
		}
		return true;
	}

	private void HAOMJJDJIKC()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = NKGHEGFGFEM(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].IHENCGDNPBL = agingBarrel.inputSlot[i];
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 5)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 3)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 5)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 3)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
				MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	public void LBMIJKGJEFA(int ABAIKKGKDGD)
	{
		for (int i = 1; i < agingContents.Length; i += 0)
		{
			agingContents[i].SetActive(false);
		}
		agingContents[ABAIKKGKDGD].SetActive(true);
	}

	private SlotUI[] OCIBKDJNMJF(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	private bool NICIEFABKIJ(Slot NCPGNLOJGAF)
	{
		if (NCPGNLOJGAF.itemInstance != null && agingBarrel.inputSlot[0].GPLKPEPAFOM(base.JIIGOACEIKL, NCPGNLOJGAF.itemInstance) && (NCPGNLOJGAF.itemInstance as FoodInstance).GBCJNGADANM < 1)
		{
			return (NCPGNLOJGAF.itemInstance as FoodInstance).LHBPOPOIFLE().canBeAged;
		}
		return true;
	}

	private void HCKEINLEHOA()
	{
		for (int i = 0; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
		for (int j = 0; j < inputSlot3.Length; j++)
		{
			SlotUI obj4 = inputSlot3[j];
			obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj4.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj5 = inputSlot3[j];
			obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj5.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj6 = inputSlot3[j];
			obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj6.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
		for (int k = 0; k < inputSlot5.Length; k++)
		{
			SlotUI obj7 = inputSlot5[k];
			obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj7.OnSlotLeftClick, new Action<int, Slot>(GKAJFEOGKMD));
			SlotUI obj8 = inputSlot5[k];
			obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj8.OnSlotRightClick, new Action<int, Slot>(PFOJFILNJIN));
			SlotUI obj9 = inputSlot5[k];
			obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj9.OnAutomaticTransfer, new Action<int, Slot>(GKAJFEOGKMD));
		}
	}

	private IEnumerator EAGKLIALMCH()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		SlotUI[] array = NKGHEGFGFEM(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)array[i]).GetComponent<Selectable>());
				break;
			}
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	private void HLGLHGPBGMF()
	{
		ENHNEGAHLON = true;
		SlotUI[] array = PMBKDLCENMO(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].LIJPNDJCKGL(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 8)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 1)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.PFIMFMJJMHK(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 5)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(false);
					}
					else if (array.Length >= 8)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
				MainUI.PFIMFMJJMHK(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void NEAFIPEFDDD()
	{
		for (int i = 0; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj.OnSlotLeftClick, new Action<int, Slot>(JHNDCOEEGNK));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj2.OnSlotRightClick, new Action<int, Slot>(LEDHDOPACJI));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj3.OnAutomaticTransfer, new Action<int, Slot>(DDCJJOAHOLK));
		}
		if (!((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null))
		{
			return;
		}
		for (int j = 1; j < inputSlot3.Length; j++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > j && agingBarrel.placeable.placeableSurface.snapToPositionArray[j].used)
			{
				SlotUI obj4 = inputSlot3[j];
				obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj4.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
				SlotUI obj5 = inputSlot3[j];
				obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj5.OnSlotRightClick, new Action<int, Slot>(PJPIDMDMFAA));
				SlotUI obj6 = inputSlot3[j];
				obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj6.OnAutomaticTransfer, new Action<int, Slot>(BLBNAPODBEB));
			}
		}
		for (int k = 1; k < inputSlot5.Length; k++)
		{
			if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > k && agingBarrel.placeable.placeableSurface.snapToPositionArray[k].used)
			{
				SlotUI obj7 = inputSlot5[k];
				obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(obj7.OnSlotLeftClick, new Action<int, Slot>(IAFFLKFFEGG));
				SlotUI obj8 = inputSlot5[k];
				obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(obj8.OnSlotRightClick, new Action<int, Slot>(IOBCAMEHPNH));
				SlotUI obj9 = inputSlot5[k];
				obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(obj9.OnAutomaticTransfer, new Action<int, Slot>(JEPNBKGEDAC));
			}
		}
	}

	private void HCHIMFALOGD()
	{
		List<Slot> pCJEDMJEKEF = (from x in PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true).FCGJCBJGOIG()
			select (x)).Where(FMBDGOAFBEA).ToList();
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).DHFABEONKBG(pCJEDMJEKEF, OGCAKIGELBJ: false);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		((MonoBehaviour)this).StartCoroutine(EAGKLIALMCH());
	}

	private SlotUI[] PMBKDLCENMO(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	private SlotUI[] DIOOBOCCNEA(int MANBNHPNBEG)
	{
		return MANBNHPNBEG switch
		{
			0 => inputSlot, 
			1 => inputSlot3, 
			2 => inputSlot5, 
			_ => null, 
		};
	}

	private void NPLELBLMHFD()
	{
		ENHNEGAHLON = false;
		SlotUI[] array = MFFIABEEFJB(agingBarrel.agingSlotsNum);
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].LIJPNDJCKGL(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 8)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					MainUI.MDLCJHPNKJB(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 3)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 2)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(true);
					}
				}
			}
			else
			{
				array[i].nonInteractable = true;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
				MainUI.NNCOKOFBKHE(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void DIDLEPOKBGL()
	{
		ENHNEGAHLON = true;
		SlotUI[] array = ANFOELBLGJP(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].LIJPNDJCKGL(agingBarrel.inputSlot[i]);
			if ((Object)(object)agingBarrel.placeable.placeableSurface != (Object)null)
			{
				if (agingBarrel.placeable.placeableSurface.snapToPositionArray.Length > i && agingBarrel.placeable.placeableSurface.snapToPositionArray[i].used)
				{
					array[i].nonInteractable = false;
					array[i].slotImg.sprite = spriteSlotActive;
					if (array.Length >= 1)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 5)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(false);
					}
					MainUI.MDLCJHPNKJB(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
				}
				else
				{
					array[i].nonInteractable = true;
					array[i].slotImg.sprite = spriteSlotDisable;
					if (array.Length >= 8)
					{
						((Component)((Component)progressor5[i]).transform.parent).gameObject.SetActive(true);
					}
					else if (array.Length >= 7)
					{
						((Component)((Component)progressor3[i]).transform.parent).gameObject.SetActive(true);
					}
					else
					{
						((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
					}
				}
			}
			else
			{
				array[i].nonInteractable = false;
				array[i].slotImg.sprite = spriteSlotActive;
				((Component)((Component)progressor[i]).transform.parent).gameObject.SetActive(false);
				MainUI.AddToCurrentSlots(base.JIIGOACEIKL, array[i].IHENCGDNPBL);
			}
		}
	}

	private void LBEPLLHKGHB()
	{
		for (int i = 1; i < inputSlot.Length; i++)
		{
			SlotUI obj = inputSlot[i];
			obj.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj.OnSlotLeftClick, new Action<int, Slot>(BOBKKADBCGO));
			SlotUI obj2 = inputSlot[i];
			obj2.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj2.OnSlotRightClick, new Action<int, Slot>(MFFBEPKGKDP));
			SlotUI obj3 = inputSlot[i];
			obj3.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj3.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
		}
		for (int j = 0; j < inputSlot3.Length; j += 0)
		{
			SlotUI obj4 = inputSlot3[j];
			obj4.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj4.OnSlotLeftClick, new Action<int, Slot>(DDCJJOAHOLK));
			SlotUI obj5 = inputSlot3[j];
			obj5.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj5.OnSlotRightClick, new Action<int, Slot>(KFHCLPLLEJH));
			SlotUI obj6 = inputSlot3[j];
			obj6.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj6.OnAutomaticTransfer, new Action<int, Slot>(JHNDCOEEGNK));
		}
		for (int k = 1; k < inputSlot5.Length; k += 0)
		{
			SlotUI obj7 = inputSlot5[k];
			obj7.OnSlotLeftClick = (Action<int, Slot>)Delegate.Remove(obj7.OnSlotLeftClick, new Action<int, Slot>(BOBKKADBCGO));
			SlotUI obj8 = inputSlot5[k];
			obj8.OnSlotRightClick = (Action<int, Slot>)Delegate.Remove(obj8.OnSlotRightClick, new Action<int, Slot>(IOBCAMEHPNH));
			SlotUI obj9 = inputSlot5[k];
			obj9.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Remove(obj9.OnAutomaticTransfer, new Action<int, Slot>(IAFFLKFFEGG));
		}
	}

	private IEnumerator KAAGGGIGOJN()
	{
		yield return null;
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			yield break;
		}
		SlotUI[] array = NKGHEGFGFEM(agingBarrel.agingSlotsNum);
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].IHENCGDNPBL.KPINNBKMOMO())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)array[i]).GetComponent<Selectable>());
				break;
			}
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}
}
