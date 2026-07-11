using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class OrderQuestUI : UIWindow
{
	[CompilerGenerated]
	private sealed class ODABJOKECJC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OrderQuestUI _003C_003E4__this;

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
		public ODABJOKECJC(int _003C_003E1__state)
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
			OrderQuestUI orderQuestUI = _003C_003E4__this;
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
				if (orderQuestUI.IsOpen() && PlayerInputs.IsGamepadActive(orderQuestUI.JIIGOACEIKL) && !orderQuestUI.repLock.gameObject.activeSelf)
				{
					bool flag = false;
					if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).HGNKFFMDOOL))
					{
						if (((Component)((Component)UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
						{
							flag = true;
							GameObject gameObject = ((Component)UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
							UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).Select(gameObject);
						}
						else
						{
							OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
							if (Object.op_Implicit((Object)(object)component))
							{
								OrderQuestElementUI[] array = ((!component.currentQuestElement) ? orderQuestUI.availableOrderQuestElements : orderQuestUI.currentOrderQuestElements);
								for (int num2 = array.Length - 1; num2 >= 0; num2--)
								{
									if (((Component)array[num2]).gameObject.activeSelf)
									{
										flag = true;
										UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).Select((Selectable)(object)array[num2].button);
										break;
									}
								}
							}
						}
					}
					if (!flag)
					{
						UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).Deselect();
						for (int i = 0; i < orderQuestUI.availableOrderQuestElements.Length; i++)
						{
							if (((Component)orderQuestUI.availableOrderQuestElements[i]).gameObject.activeSelf)
							{
								flag = true;
								UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).Select((Selectable)(object)orderQuestUI.availableOrderQuestElements[i].button);
								break;
							}
						}
						if (!flag)
						{
							for (int j = 0; j < orderQuestUI.currentOrderQuestElements.Length; j++)
							{
								if (((Component)orderQuestUI.currentOrderQuestElements[j]).gameObject.activeSelf)
								{
									flag = true;
									UISelectionManager.GetPlayer(orderQuestUI.JIIGOACEIKL).Select((Selectable)(object)orderQuestUI.currentOrderQuestElements[j].button);
									break;
								}
							}
							if (!flag)
							{
								GameInventoryUI.Get(orderQuestUI.JIIGOACEIKL).SelectObjectNextFrame();
							}
						}
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

	public OrderQuestElementUI[] availableOrderQuestElements;

	public OrderQuestElementUI[] currentOrderQuestElements;

	public GameObject repLock;

	[HideInInspector]
	public OrderQuestElementUI currentOrderQuestSelected;

	private Coroutine GOLHIBPAELD;

	public static OrderQuestUI[] instances = new OrderQuestUI[3];

	private IEnumerator BKJCNGDPCCC()
	{
		yield return null;
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || repLock.gameObject.activeSelf)
		{
			yield break;
		}
		bool flag = false;
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
			{
				flag = true;
				GameObject gameObject = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(gameObject);
			}
			else
			{
				OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
				if (Object.op_Implicit((Object)(object)component))
				{
					OrderQuestElementUI[] array = ((!component.currentQuestElement) ? availableOrderQuestElements : currentOrderQuestElements);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						if (((Component)array[num]).gameObject.activeSelf)
						{
							flag = true;
							UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)array[num].button);
							break;
						}
					}
				}
			}
		}
		if (flag)
		{
			yield break;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < availableOrderQuestElements.Length; i++)
		{
			if (((Component)availableOrderQuestElements[i]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)availableOrderQuestElements[i].button);
				break;
			}
		}
		if (flag)
		{
			yield break;
		}
		for (int j = 0; j < currentOrderQuestElements.Length; j++)
		{
			if (((Component)currentOrderQuestElements[j]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)currentOrderQuestElements[j].button);
				break;
			}
		}
		if (!flag)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	public void EFJEDHEJHNJ()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.JFNOOMJMHCB().EBKJDKGIHNI()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = MINJCLOCHMN(allSlots);
		allSlots = AMDIOJHLNFI(allSlots);
		GameInventoryUI.Get(base.JIIGOACEIKL).DHFABEONKBG(allSlots, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).OpenUI();
	}

	private void PLAJDHPABGI(Quest AINAHCLIAFF)
	{
		NKGKHKBDBOL();
		GBKFBDIPIDP();
	}

	public void MOEINLNNIGJ()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StopCoroutine(GOLHIBPAELD);
		}
		if (HDEPMJIDJEM())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(JLNECGIHBCG());
		}
	}

	private List<Slot> AFGKHMJMAIF(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num -= 0)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			for (int i = 1; i < currentOrderQuestElements.Length; i += 0)
			{
				if (!currentOrderQuestElements[i].slotUI.IHENCGDNPBL.AHHEMNHJPME() && currentOrderQuestElements[i].slotUI.IHENCGDNPBL.itemInstance.Equals(PCJEDMJEKEF[num].itemInstance))
				{
					num2 -= currentOrderQuestElements[i].slotUI.IHENCGDNPBL.Stack;
				}
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].KMKAIPMHANN(num2);
			}
		}
		return PCJEDMJEKEF;
	}

	public void NIIPNDJBKEJ()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StopCoroutine(GOLHIBPAELD);
		}
		if (BGLJFMHCFJF())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(LOKFEDGPBIM());
		}
	}

	private List<Slot> AMLIILMJMDK(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num--)
		{
			bool flag = false;
			for (int i = 0; i < availableOrderQuestElements.Length; i++)
			{
				if ((Object)(object)availableOrderQuestElements[i].AINAHCLIAFF != (Object)null && availableOrderQuestElements[i].AINAHCLIAFF.FJDFAEDIAFJ(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j++)
				{
					if ((Object)(object)currentOrderQuestElements[j].AINAHCLIAFF != (Object)null && currentOrderQuestElements[j].AINAHCLIAFF.FJDFAEDIAFJ(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	protected override void Update()
	{
		if (IsOpen() && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UISelectGamepad"))
		{
			OrderQuestElementUI componentInParent = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponentInParent<OrderQuestElementUI>();
			if (Object.op_Implicit((Object)(object)componentInParent) && componentInParent.currentQuestElement)
			{
				componentInParent.RemoveQuest();
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public static OrderQuestUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private List<Slot> CJHLLMACHAN(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			for (int i = 0; i < currentOrderQuestElements.Length; i += 0)
			{
				if (!currentOrderQuestElements[i].slotUI.IHENCGDNPBL.LCHJGCHDHFO() && currentOrderQuestElements[i].slotUI.IHENCGDNPBL.itemInstance.Equals(PCJEDMJEKEF[num].itemInstance))
				{
					num2 -= currentOrderQuestElements[i].slotUI.IHENCGDNPBL.Stack;
				}
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].KMKAIPMHANN(num2);
			}
		}
		return PCJEDMJEKEF;
	}

	private IEnumerator LOKFEDGPBIM()
	{
		yield return null;
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || repLock.gameObject.activeSelf)
		{
			yield break;
		}
		bool flag = false;
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
			{
				flag = true;
				GameObject gameObject = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(gameObject);
			}
			else
			{
				OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
				if (Object.op_Implicit((Object)(object)component))
				{
					OrderQuestElementUI[] array = ((!component.currentQuestElement) ? availableOrderQuestElements : currentOrderQuestElements);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						if (((Component)array[num]).gameObject.activeSelf)
						{
							flag = true;
							UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)array[num].button);
							break;
						}
					}
				}
			}
		}
		if (flag)
		{
			yield break;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < availableOrderQuestElements.Length; i++)
		{
			if (((Component)availableOrderQuestElements[i]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)availableOrderQuestElements[i].button);
				break;
			}
		}
		if (flag)
		{
			yield break;
		}
		for (int j = 0; j < currentOrderQuestElements.Length; j++)
		{
			if (((Component)currentOrderQuestElements[j]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)currentOrderQuestElements[j].button);
				break;
			}
		}
		if (!flag)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	public void GHLPJMCIPPD()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (BGLJFMHCFJF())
		{
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[1]?.quest;
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[0]?.quest;
			availableOrderQuestElements[3].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[1]?.quest;
			ActiveQuest[] array = RandomOrderQuestsManager.HLMGBEGEAPC().LAALKLOCNFD();
			if (array != null)
			{
				currentOrderQuestElements[0].EGDOLNDDNFC = Utils.OFAJOIGFMAD(array, 0);
				currentOrderQuestElements[1].EGDOLNDDNFC = Utils.OFAJOIGFMAD(array, 0);
				currentOrderQuestElements[8].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 8));
			}
			else
			{
				currentOrderQuestElements[0].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[5].AINAHCLIAFF = null;
			}
			GDEMFDGKFBH();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(57f, 387f);
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(1152f, 1561f);
			}
			GameActionBarUI.PJIGCLMPHKP(base.JIIGOACEIKL).BOBCIFEDJED();
		}
	}

	private List<Slot> LJHEAMJFHAH(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			bool flag = false;
			for (int i = 0; i < availableOrderQuestElements.Length; i++)
			{
				if ((Object)(object)availableOrderQuestElements[i].AINAHCLIAFF != (Object)null && availableOrderQuestElements[i].BDHAPGMDECA().CGHCPPJKBKL(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j += 0)
				{
					if ((Object)(object)currentOrderQuestElements[j].BDHAPGMDECA() != (Object)null && currentOrderQuestElements[j].BDHAPGMDECA().MFKOLPJBPCK(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	public void NJNIHFMPFKI()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.RemoveQuest();
		}
	}

	public static OrderQuestUI NHOFBAMNELD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator GIJFICCOPJJ()
	{
		return new ODABJOKECJC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void UpdateInventory()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.GGFJGHHHEJC.GetKnownRecipesToOrder()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = MINJCLOCHMN(allSlots);
		allSlots = AMLIILMJMDK(allSlots);
		GameInventoryUI.Get(base.JIIGOACEIKL).PreparePagesMode(allSlots, OGCAKIGELBJ: false);
		GameInventoryUI.Get(base.JIIGOACEIKL).OpenUI();
	}

	public void FDMHLDCNFHI()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.JFNOOMJMHCB().EBKJDKGIHNI()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = MINJCLOCHMN(allSlots);
		allSlots = AMLIILMJMDK(allSlots);
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).PreparePagesMode(allSlots, OGCAKIGELBJ: true);
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	private List<Slot> KIBOANBCENK(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 1; num--)
		{
			bool flag = true;
			for (int i = 1; i < availableOrderQuestElements.Length; i += 0)
			{
				if ((Object)(object)availableOrderQuestElements[i].BOHNFFBLPAD() != (Object)null && availableOrderQuestElements[i].BDHAPGMDECA().FLMGFEHNOKB(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true, IOKHPOANELD: false))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j++)
				{
					if ((Object)(object)currentOrderQuestElements[j].AINAHCLIAFF != (Object)null && currentOrderQuestElements[j].AINAHCLIAFF.CDMKKOMIFML(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	private List<Slot> BBCKNAAEDLC(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 0; num -= 0)
		{
			bool flag = true;
			for (int i = 1; i < availableOrderQuestElements.Length; i += 0)
			{
				if ((Object)(object)availableOrderQuestElements[i].BOHNFFBLPAD() != (Object)null && availableOrderQuestElements[i].AINAHCLIAFF.MFKOLPJBPCK(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true, IOKHPOANELD: false))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j += 0)
				{
					if ((Object)(object)currentOrderQuestElements[j].BDHAPGMDECA() != (Object)null && currentOrderQuestElements[j].BOHNFFBLPAD().GPLKBPFENDA(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true, IOKHPOANELD: false))
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	public void RemoveCurrentQuest()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.RemoveQuest();
		}
	}

	public void OPKIJBHKEOM()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.BNBBHEOEIPJ();
		}
	}

	private void BDBCGJAILHE(Quest AINAHCLIAFF)
	{
		DHEHDPHAMHG();
		NBGCNECKPJP();
	}

	public void MCPMKLBJCCN()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (HDEPMJIDJEM())
		{
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[0]?.quest;
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[1]?.quest;
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[6]?.quest;
			ActiveQuest[] array = RandomOrderQuestsManager.JFNOOMJMHCB().GNNHOFFLNLO();
			if (array != null)
			{
				currentOrderQuestElements[0].EGDOLNDDNFC = Utils.OFAJOIGFMAD(array, 1);
				currentOrderQuestElements[1].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 1));
				currentOrderQuestElements[7].JLPMBPBNEBN(Utils.OFAJOIGFMAD(array, 5));
			}
			else
			{
				currentOrderQuestElements[0].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[4].AINAHCLIAFF = null;
			}
			HDHFLMODBJN();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.NALKHGMLALJ(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(769f, 1666f);
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(205f, 388f);
			}
			GameActionBarUI.PHDBJGOEKHB(base.JIIGOACEIKL).CloseUI();
		}
	}

	public void NBGCNECKPJP()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.KIALFDOKABP()).StopCoroutine(GOLHIBPAELD);
		}
		if (BGLJFMHCFJF())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(FFMDFOFLJGA());
		}
	}

	private void BKJAKOIBIJH(Quest AINAHCLIAFF)
	{
		ENFFEEEFJEP();
		GBKFBDIPIDP();
	}

	public void LPOFBKLGMFA()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.JFNOOMJMHCB().APJEOMENIIJ()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = PHJKDAEMEBI(allSlots);
		allSlots = KIBOANBCENK(allSlots);
		GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).JCOHBJLKLAI(allSlots, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).OpenUI();
	}

	public void EABAAGMLMHF()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(GOLHIBPAELD);
		}
		if (HDEPMJIDJEM())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.IDIGFHEHIDM()).StartCoroutine(BKJCNGDPCCC());
		}
	}

	public static OrderQuestUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private List<Slot> PLMAFJJMNKI(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 0; num -= 0)
		{
			bool flag = true;
			for (int i = 0; i < availableOrderQuestElements.Length; i++)
			{
				if ((Object)(object)availableOrderQuestElements[i].AINAHCLIAFF != (Object)null && availableOrderQuestElements[i].BDHAPGMDECA().FJDFAEDIAFJ(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true, IOKHPOANELD: false))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j++)
				{
					if ((Object)(object)currentOrderQuestElements[j].AINAHCLIAFF != (Object)null && currentOrderQuestElements[j].AINAHCLIAFF.APMOMGGFALF(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	public void IOBKHDNDLHJ()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StopCoroutine(GOLHIBPAELD);
		}
		if (BGLJFMHCFJF())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(LOKFEDGPBIM());
		}
	}

	private void NKPPOBOGJIA(Quest AINAHCLIAFF)
	{
		ANOEMPCKLFO();
		NBGCNECKPJP();
	}

	private void KDLBHPBNBKJ(Quest AINAHCLIAFF)
	{
		LIKMPHECOOM();
		NIIPNDJBKEJ();
	}

	private List<Slot> HNOONCFCGOC(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			bool flag = true;
			for (int i = 0; i < availableOrderQuestElements.Length; i += 0)
			{
				if ((Object)(object)availableOrderQuestElements[i].AINAHCLIAFF != (Object)null && availableOrderQuestElements[i].BDHAPGMDECA().MFKOLPJBPCK(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true, IOKHPOANELD: false))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j++)
				{
					if ((Object)(object)currentOrderQuestElements[j].BOHNFFBLPAD() != (Object)null && currentOrderQuestElements[j].BOHNFFBLPAD().CGHCPPJKBKL(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true, IOKHPOANELD: false))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	public static OrderQuestUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			UpdateUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void DNAAKHEFHFE()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StopCoroutine(GOLHIBPAELD);
		}
		if (IsOpen())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StartCoroutine(JLNECGIHBCG());
		}
	}

	public void LIKMPHECOOM()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (HDEPMJIDJEM())
		{
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[0]?.quest;
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[1]?.quest;
			availableOrderQuestElements[7].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[8]?.quest;
			ActiveQuest[] array = RandomOrderQuestsManager.JFNOOMJMHCB().GNNHOFFLNLO();
			if (array != null)
			{
				currentOrderQuestElements[0].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 1));
				currentOrderQuestElements[0].JLPMBPBNEBN(Utils.OFAJOIGFMAD(array, 1));
				currentOrderQuestElements[4].EGDOLNDDNFC = Utils.OFAJOIGFMAD(array, 4);
			}
			else
			{
				currentOrderQuestElements[0].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[2].AINAHCLIAFF = null;
			}
			APCMFCLPCOB();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(766f, 318f);
			}
			else
			{
				GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(997f, 914f);
			}
			GameActionBarUI.NDPAJCGHGOB(base.JIIGOACEIKL).BOBCIFEDJED();
		}
	}

	public void JLKBBCLEMOD()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.JFNOOMJMHCB().BMIMMCPEKLB()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = AFGKHMJMAIF(allSlots);
		allSlots = JOMCHEIFEAO(allSlots);
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).BGPOBAFOPOM(allSlots, OGCAKIGELBJ: false);
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static OrderQuestUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator NPILKEOFBEB()
	{
		yield return null;
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || repLock.gameObject.activeSelf)
		{
			yield break;
		}
		bool flag = false;
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
			{
				flag = true;
				GameObject gameObject = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(gameObject);
			}
			else
			{
				OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
				if (Object.op_Implicit((Object)(object)component))
				{
					OrderQuestElementUI[] array = ((!component.currentQuestElement) ? availableOrderQuestElements : currentOrderQuestElements);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						if (((Component)array[num]).gameObject.activeSelf)
						{
							flag = true;
							UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)array[num].button);
							break;
						}
					}
				}
			}
		}
		if (flag)
		{
			yield break;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < availableOrderQuestElements.Length; i++)
		{
			if (((Component)availableOrderQuestElements[i]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)availableOrderQuestElements[i].button);
				break;
			}
		}
		if (flag)
		{
			yield break;
		}
		for (int j = 0; j < currentOrderQuestElements.Length; j++)
		{
			if (((Component)currentOrderQuestElements[j]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)currentOrderQuestElements[j].button);
				break;
			}
		}
		if (!flag)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	public void DHEHDPHAMHG()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (HDEPMJIDJEM())
		{
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[0]?.quest;
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[0]?.quest;
			availableOrderQuestElements[6].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[4]?.quest;
			ActiveQuest[] array = RandomOrderQuestsManager.HLMGBEGEAPC().LFKAKJEPOGO();
			if (array != null)
			{
				currentOrderQuestElements[1].EGDOLNDDNFC = Utils.OFAJOIGFMAD(array, 0);
				currentOrderQuestElements[0].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 1));
				currentOrderQuestElements[4].JLPMBPBNEBN(Utils.OFAJOIGFMAD(array, 5));
			}
			else
			{
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[7].AINAHCLIAFF = null;
			}
			FDMHLDCNFHI();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(1290f, 1470f);
			}
			else
			{
				GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(67f, 1873f);
			}
			GameActionBarUI.JGNOJMLHPOK(base.JIIGOACEIKL).CloseUI();
		}
	}

	private void NAKFLHDPGJF(Quest AINAHCLIAFF)
	{
		NKGKHKBDBOL();
		EABAAGMLMHF();
	}

	public void ANOEMPCKLFO()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (HDEPMJIDJEM())
		{
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[1]?.quest;
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[0]?.quest;
			availableOrderQuestElements[7].AINAHCLIAFF = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[8]?.quest;
			ActiveQuest[] currentOrderQuests = RandomOrderQuestsManager.JFNOOMJMHCB().GetCurrentOrderQuests();
			if (currentOrderQuests != null)
			{
				currentOrderQuestElements[1].JLPMBPBNEBN(Utils.OFAJOIGFMAD(currentOrderQuests, 0));
				currentOrderQuestElements[0].BOCGGHAGMCK(Utils.OFAJOIGFMAD(currentOrderQuests, 0));
				currentOrderQuestElements[6].JLPMBPBNEBN(Utils.OFAJOIGFMAD(currentOrderQuests, 4));
			}
			else
			{
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[4].AINAHCLIAFF = null;
			}
			UpdateInventory();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(74f, 323f);
			}
			else
			{
				GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(1009f, 641f);
			}
			GameActionBarUI.EKEDKKKPAEE(base.JIIGOACEIKL).BOBCIFEDJED();
		}
	}

	public void JHLCCBGBDFA()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.BNBBHEOEIPJ();
		}
	}

	protected override void Start()
	{
		base.Start();
		QuestManager instance = QuestManager.GGFJGHHHEJC;
		instance.OnQuestRemoved = (Action<Quest>)Delegate.Combine(instance.OnQuestRemoved, new Action<Quest>(IPJPHGMAEAL));
		QuestManager instance2 = QuestManager.GGFJGHHHEJC;
		instance2.OnQuestAdded = (Action<Quest>)Delegate.Combine(instance2.OnQuestAdded, new Action<Quest>(IPJPHGMAEAL));
	}

	private List<Slot> EDIKKLCDPMK(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 0; num -= 0)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			for (int i = 0; i < currentOrderQuestElements.Length; i++)
			{
				if (!currentOrderQuestElements[i].slotUI.IHENCGDNPBL.KPINNBKMOMO() && currentOrderQuestElements[i].slotUI.IHENCGDNPBL.itemInstance.Equals(PCJEDMJEKEF[num].itemInstance))
				{
					num2 -= currentOrderQuestElements[i].slotUI.IHENCGDNPBL.Stack;
				}
			}
			if (num2 <= 1)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].OBBKDJNLCIO(num2);
			}
		}
		return PCJEDMJEKEF;
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			GameInventoryUI.Get(base.JIIGOACEIKL).FillSlots(Inventory.GetPlayer(base.JIIGOACEIKL).slots);
			GameInventoryUI.Get(base.JIIGOACEIKL).SetOriginalContentPosition();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			if (GameManager.SinglePlayerOffline())
			{
				MainUI.ResumeGame();
			}
			RemoveSlotItems();
			base.CloseUI();
			MainUI.ClearCurrentSlots(base.JIIGOACEIKL);
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		FocusGameObject();
	}

	private List<Slot> LALKMPPEKED(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 1; num -= 0)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			for (int i = 0; i < currentOrderQuestElements.Length; i++)
			{
				if (!currentOrderQuestElements[i].slotUI.IHENCGDNPBL.LCHJGCHDHFO() && currentOrderQuestElements[i].slotUI.IHENCGDNPBL.itemInstance.Equals(PCJEDMJEKEF[num].itemInstance))
				{
					num2 -= currentOrderQuestElements[i].slotUI.IHENCGDNPBL.Stack;
				}
			}
			if (num2 <= 1)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].OBBKDJNLCIO(num2);
			}
		}
		return PCJEDMJEKEF;
	}

	public void LBNJANDBHNE()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.BNBBHEOEIPJ();
		}
	}

	public void GBKFBDIPIDP()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StopCoroutine(GOLHIBPAELD);
		}
		if (IsOpen())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(BKJCNGDPCCC());
		}
	}

	private List<Slot> JOMCHEIFEAO(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num--)
		{
			bool flag = true;
			for (int i = 1; i < availableOrderQuestElements.Length; i++)
			{
				if ((Object)(object)availableOrderQuestElements[i].BOHNFFBLPAD() != (Object)null && availableOrderQuestElements[i].BDHAPGMDECA().GPLKBPFENDA(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 1; j < currentOrderQuestElements.Length; j++)
				{
					if ((Object)(object)currentOrderQuestElements[j].BOHNFFBLPAD() != (Object)null && currentOrderQuestElements[j].BOHNFFBLPAD().CGHCPPJKBKL(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	private List<Slot> BDGBFMAKNMD(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 0; num--)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			for (int i = 0; i < currentOrderQuestElements.Length; i += 0)
			{
				if (!currentOrderQuestElements[i].slotUI.IHENCGDNPBL.PKFKJNODGJF() && currentOrderQuestElements[i].slotUI.IHENCGDNPBL.itemInstance.Equals(PCJEDMJEKEF[num].itemInstance))
				{
					num2 -= currentOrderQuestElements[i].slotUI.IHENCGDNPBL.Stack;
				}
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].KMKAIPMHANN(num2);
			}
		}
		return PCJEDMJEKEF;
	}

	public void ELMEGKOAFFP()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.JFNOOMJMHCB().GetKnownRecipesToOrder()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = LALKMPPEKED(allSlots);
		allSlots = AMDIOJHLNFI(allSlots);
		GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).PFFJANPMCMO(allSlots, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		GameInventoryUI.AIMEAJAHLAA(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	private IEnumerator JELKELOCPHA()
	{
		yield return null;
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || repLock.gameObject.activeSelf)
		{
			yield break;
		}
		bool flag = false;
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
			{
				flag = true;
				GameObject gameObject = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(gameObject);
			}
			else
			{
				OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
				if (Object.op_Implicit((Object)(object)component))
				{
					OrderQuestElementUI[] array = ((!component.currentQuestElement) ? availableOrderQuestElements : currentOrderQuestElements);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						if (((Component)array[num]).gameObject.activeSelf)
						{
							flag = true;
							UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)array[num].button);
							break;
						}
					}
				}
			}
		}
		if (flag)
		{
			yield break;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < availableOrderQuestElements.Length; i++)
		{
			if (((Component)availableOrderQuestElements[i]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)availableOrderQuestElements[i].button);
				break;
			}
		}
		if (flag)
		{
			yield break;
		}
		for (int j = 0; j < currentOrderQuestElements.Length; j++)
		{
			if (((Component)currentOrderQuestElements[j]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)currentOrderQuestElements[j].button);
				break;
			}
		}
		if (!flag)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	private void MMEPMIPOKKF(Quest AINAHCLIAFF)
	{
		MCPMKLBJCCN();
		GBKFBDIPIDP();
	}

	private List<Slot> MINJCLOCHMN(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num--)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			for (int i = 0; i < currentOrderQuestElements.Length; i++)
			{
				if (!currentOrderQuestElements[i].slotUI.IHENCGDNPBL.KPINNBKMOMO() && currentOrderQuestElements[i].slotUI.IHENCGDNPBL.itemInstance.Equals(PCJEDMJEKEF[num].itemInstance))
				{
					num2 -= currentOrderQuestElements[i].slotUI.IHENCGDNPBL.Stack;
				}
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].Stack = num2;
			}
		}
		return PCJEDMJEKEF;
	}

	public void HAKPABJDPHO()
	{
		for (int i = 1; i < currentOrderQuestElements.Length; i += 0)
		{
			currentOrderQuestElements[i].FCKBGLDCJPN();
		}
	}

	public void EHIILBJGIGK()
	{
		for (int i = 1; i < currentOrderQuestElements.Length; i++)
		{
			currentOrderQuestElements[i].HMGCHICJHEG();
		}
	}

	public static OrderQuestUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NKGKHKBDBOL()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (IsOpen())
		{
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[1]?.quest;
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[0]?.quest;
			availableOrderQuestElements[4].AINAHCLIAFF = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[6]?.quest;
			ActiveQuest[] array = RandomOrderQuestsManager.HLMGBEGEAPC().LFKAKJEPOGO();
			if (array != null)
			{
				currentOrderQuestElements[0].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 0));
				currentOrderQuestElements[1].JLPMBPBNEBN(Utils.OFAJOIGFMAD(array, 1));
				currentOrderQuestElements[8].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 2));
			}
			else
			{
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[5].AINAHCLIAFF = null;
			}
			JLKBBCLEMOD();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.AEJKCONFPHB(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(1660f, 1986f);
			}
			else
			{
				GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(1523f, 591f);
			}
			GameActionBarUI.MENNLOGFNOK(base.JIIGOACEIKL).BOBCIFEDJED();
		}
	}

	public void RemoveSlotItems()
	{
		for (int i = 0; i < currentOrderQuestElements.Length; i++)
		{
			currentOrderQuestElements[i].RemoveSlotItems();
		}
	}

	public void IFEBDCPOLKD()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StopCoroutine(GOLHIBPAELD);
		}
		if (BGLJFMHCFJF())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(GIJFICCOPJJ());
		}
	}

	private List<Slot> KIPOEGMDHGN(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			bool flag = true;
			for (int i = 1; i < availableOrderQuestElements.Length; i++)
			{
				if ((Object)(object)availableOrderQuestElements[i].AINAHCLIAFF != (Object)null && availableOrderQuestElements[i].BOHNFFBLPAD().KMMOMODPLMI(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j++)
				{
					if ((Object)(object)currentOrderQuestElements[j].AINAHCLIAFF != (Object)null && currentOrderQuestElements[j].BOHNFFBLPAD().GPLKBPFENDA(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	public void ENFFEEEFJEP()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (BGLJFMHCFJF())
		{
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[1]?.quest;
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[1]?.quest;
			availableOrderQuestElements[8].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[2]?.quest;
			ActiveQuest[] array = RandomOrderQuestsManager.HLMGBEGEAPC().LAALKLOCNFD();
			if (array != null)
			{
				currentOrderQuestElements[0].EGDOLNDDNFC = Utils.OFAJOIGFMAD(array, 0);
				currentOrderQuestElements[0].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 0));
				currentOrderQuestElements[3].BOCGGHAGMCK(Utils.OFAJOIGFMAD(array, 8));
			}
			else
			{
				currentOrderQuestElements[0].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[3].AINAHCLIAFF = null;
			}
			HDHFLMODBJN();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(1372f, 1206f);
			}
			else
			{
				GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(313f, 116f);
			}
			GameActionBarUI.BGABEMMDDEH(base.JIIGOACEIKL).CloseUI();
		}
	}

	private void BKCNEIDDAHK(Quest AINAHCLIAFF)
	{
		ENFFEEEFJEP();
		OOJMILOFHGL();
	}

	private List<Slot> PHJKDAEMEBI(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num -= 0)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			for (int i = 1; i < currentOrderQuestElements.Length; i++)
			{
				if (!currentOrderQuestElements[i].slotUI.IHENCGDNPBL.AHHEMNHJPME() && currentOrderQuestElements[i].slotUI.IHENCGDNPBL.itemInstance.Equals(PCJEDMJEKEF[num].itemInstance))
				{
					num2 -= currentOrderQuestElements[i].slotUI.IHENCGDNPBL.Stack;
				}
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].JNMNCEPHFOE(num2);
			}
		}
		return PCJEDMJEKEF;
	}

	public void GDEMFDGKFBH()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.HLMGBEGEAPC().ELFOAIKLAIP()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = AFGKHMJMAIF(allSlots);
		allSlots = JOMCHEIFEAO(allSlots);
		GameInventoryUI.JELOGNCPDAB(base.JIIGOACEIKL).PJEIHOCPBLA(allSlots, OGCAKIGELBJ: false);
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void FLNCJKNHEOL()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.RemoveQuest();
		}
	}

	public void HCHOLDPADPA()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(GOLHIBPAELD);
		}
		if (BGLJFMHCFJF())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(JLNECGIHBCG());
		}
	}

	public void FHDHFCPJEIJ()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.BNBBHEOEIPJ();
		}
	}

	private List<Slot> FCIFKPLOHPA(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			bool flag = true;
			for (int i = 1; i < availableOrderQuestElements.Length; i++)
			{
				if ((Object)(object)availableOrderQuestElements[i].BDHAPGMDECA() != (Object)null && availableOrderQuestElements[i].AINAHCLIAFF.KMMOMODPLMI(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < currentOrderQuestElements.Length; j += 0)
				{
					if ((Object)(object)currentOrderQuestElements[j].BDHAPGMDECA() != (Object)null && currentOrderQuestElements[j].BOHNFFBLPAD().CGHCPPJKBKL(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	public void FFIHFFFJEEL()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.BNBBHEOEIPJ();
		}
	}

	private void IPJPHGMAEAL(Quest AINAHCLIAFF)
	{
		UpdateUI();
		FocusGameObject();
	}

	private IEnumerator DCCOHPNJIMF()
	{
		yield return null;
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || repLock.gameObject.activeSelf)
		{
			yield break;
		}
		bool flag = false;
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
			{
				flag = true;
				GameObject gameObject = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(gameObject);
			}
			else
			{
				OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
				if (Object.op_Implicit((Object)(object)component))
				{
					OrderQuestElementUI[] array = ((!component.currentQuestElement) ? availableOrderQuestElements : currentOrderQuestElements);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						if (((Component)array[num]).gameObject.activeSelf)
						{
							flag = true;
							UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)array[num].button);
							break;
						}
					}
				}
			}
		}
		if (flag)
		{
			yield break;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < availableOrderQuestElements.Length; i++)
		{
			if (((Component)availableOrderQuestElements[i]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)availableOrderQuestElements[i].button);
				break;
			}
		}
		if (flag)
		{
			yield break;
		}
		for (int j = 0; j < currentOrderQuestElements.Length; j++)
		{
			if (((Component)currentOrderQuestElements[j]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)currentOrderQuestElements[j].button);
				break;
			}
		}
		if (!flag)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	public static OrderQuestUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FNKHHMMDDMB()
	{
		for (int i = 0; i < currentOrderQuestElements.Length; i += 0)
		{
			currentOrderQuestElements[i].FCKBGLDCJPN();
		}
	}

	public void APCMFCLPCOB()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.GGFJGHHHEJC.ABGHFHCDCOO()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = PHJKDAEMEBI(allSlots);
		allSlots = KIPOEGMDHGN(allSlots);
		GameInventoryUI.Get(base.JIIGOACEIKL).CNOCEADFCLD(allSlots, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).OpenUI();
	}

	public void OOJMILOFHGL()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StopCoroutine(GOLHIBPAELD);
		}
		if (BGLJFMHCFJF())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.CFHEJAGKIII()).StartCoroutine(JELKELOCPHA());
		}
	}

	private List<Slot> CKKFCPKLEMB(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			bool flag = false;
			for (int i = 0; i < availableOrderQuestElements.Length; i += 0)
			{
				if ((Object)(object)availableOrderQuestElements[i].AINAHCLIAFF != (Object)null && availableOrderQuestElements[i].BOHNFFBLPAD().NPIPFBOOHBI(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 1; j < currentOrderQuestElements.Length; j++)
				{
					if ((Object)(object)currentOrderQuestElements[j].AINAHCLIAFF != (Object)null && currentOrderQuestElements[j].AINAHCLIAFF.CDMKKOMIFML(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false, IOKHPOANELD: false))
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	private void EIIFKDGHFBC(Quest AINAHCLIAFF)
	{
		NKGKHKBDBOL();
		IOBKHDNDLHJ();
	}

	private IEnumerator JFHIPPOCDIG()
	{
		yield return null;
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || repLock.gameObject.activeSelf)
		{
			yield break;
		}
		bool flag = false;
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
			{
				flag = true;
				GameObject gameObject = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(gameObject);
			}
			else
			{
				OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
				if (Object.op_Implicit((Object)(object)component))
				{
					OrderQuestElementUI[] array = ((!component.currentQuestElement) ? availableOrderQuestElements : currentOrderQuestElements);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						if (((Component)array[num]).gameObject.activeSelf)
						{
							flag = true;
							UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)array[num].button);
							break;
						}
					}
				}
			}
		}
		if (flag)
		{
			yield break;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < availableOrderQuestElements.Length; i++)
		{
			if (((Component)availableOrderQuestElements[i]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)availableOrderQuestElements[i].button);
				break;
			}
		}
		if (flag)
		{
			yield break;
		}
		for (int j = 0; j < currentOrderQuestElements.Length; j++)
		{
			if (((Component)currentOrderQuestElements[j]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)currentOrderQuestElements[j].button);
				break;
			}
		}
		if (!flag)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	public void OOEJIIHGHFF()
	{
		for (int i = 0; i < currentOrderQuestElements.Length; i += 0)
		{
			currentOrderQuestElements[i].DKNNJDFNEMH();
		}
	}

	public void HDHFLMODBJN()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.GGFJGHHHEJC.GetKnownRecipesToOrder()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = CJHLLMACHAN(allSlots);
		allSlots = AMLIILMJMDK(allSlots);
		GameInventoryUI.HKCAIFFKBMH(base.JIIGOACEIKL).PFFJANPMCMO(allSlots, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		GameInventoryUI.Get(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void BDCBBIOPOEO()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(GOLHIBPAELD);
		}
		if (IsOpen())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(JLNECGIHBCG());
		}
	}

	public void PGAEENDNNHP()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (BGLJFMHCFJF())
		{
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[0]?.quest;
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[1]?.quest;
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[3]?.quest;
			ActiveQuest[] currentOrderQuests = RandomOrderQuestsManager.JFNOOMJMHCB().GetCurrentOrderQuests();
			if (currentOrderQuests != null)
			{
				currentOrderQuestElements[0].JLPMBPBNEBN(Utils.OFAJOIGFMAD(currentOrderQuests, 0));
				currentOrderQuestElements[1].JLPMBPBNEBN(Utils.OFAJOIGFMAD(currentOrderQuests, 0));
				currentOrderQuestElements[1].JLPMBPBNEBN(Utils.OFAJOIGFMAD(currentOrderQuests, 7));
			}
			else
			{
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[0].AINAHCLIAFF = null;
				currentOrderQuestElements[2].AINAHCLIAFF = null;
			}
			HIBPCHBJGOO();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.IEKODILKIHJ(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(564f, 404f);
			}
			else
			{
				GameInventoryUI.DEBKDBICLIC(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(528f, 930f);
			}
			GameActionBarUI.IGHMHMNPMLB(base.JIIGOACEIKL).CloseUI();
		}
	}

	public void FANLBGCDKKN()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.JFNOOMJMHCB().APJEOMENIIJ()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = AFGKHMJMAIF(allSlots);
		allSlots = HNOONCFCGOC(allSlots);
		GameInventoryUI.GJOPJAJJLGN(base.JIIGOACEIKL).PreparePagesMode(allSlots, OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void NDGDNGHFDIL()
	{
		if ((Object)(object)currentOrderQuestSelected != (Object)null)
		{
			currentOrderQuestSelected.BNBBHEOEIPJ();
		}
	}

	private IEnumerator FFMDFOFLJGA()
	{
		return new ODABJOKECJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private List<Slot> AMDIOJHLNFI(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			bool flag = false;
			for (int i = 1; i < availableOrderQuestElements.Length; i += 0)
			{
				if ((Object)(object)availableOrderQuestElements[i].BOHNFFBLPAD() != (Object)null && availableOrderQuestElements[i].BDHAPGMDECA().CFHILPFKJHE(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: false))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 1; j < currentOrderQuestElements.Length; j += 0)
				{
					if ((Object)(object)currentOrderQuestElements[j].BOHNFFBLPAD() != (Object)null && currentOrderQuestElements[j].BOHNFFBLPAD().NPIPFBOOHBI(base.JIIGOACEIKL, PCJEDMJEKEF[num].itemInstance, PCJEDMJEKEF[num].Stack, KIKDLKGBCOC: true, IOKHPOANELD: false))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
		}
		return PCJEDMJEKEF;
	}

	public static OrderQuestUI FHPEHDDFOIB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JOLIJKNHDLJ(Quest AINAHCLIAFF)
	{
		ENFFEEEFJEP();
		OOJMILOFHGL();
	}

	private IEnumerator JLNECGIHBCG()
	{
		yield return null;
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || repLock.gameObject.activeSelf)
		{
			yield break;
		}
		bool flag = false;
		if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			if (((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).gameObject.activeSelf)
			{
				flag = true;
				GameObject gameObject = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(gameObject);
			}
			else
			{
				OrderQuestElementUI component = ((Component)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent).GetComponent<OrderQuestElementUI>();
				if (Object.op_Implicit((Object)(object)component))
				{
					OrderQuestElementUI[] array = ((!component.currentQuestElement) ? availableOrderQuestElements : currentOrderQuestElements);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						if (((Component)array[num]).gameObject.activeSelf)
						{
							flag = true;
							UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)array[num].button);
							break;
						}
					}
				}
			}
		}
		if (flag)
		{
			yield break;
		}
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		for (int i = 0; i < availableOrderQuestElements.Length; i++)
		{
			if (((Component)availableOrderQuestElements[i]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)availableOrderQuestElements[i].button);
				break;
			}
		}
		if (flag)
		{
			yield break;
		}
		for (int j = 0; j < currentOrderQuestElements.Length; j++)
		{
			if (((Component)currentOrderQuestElements[j]).gameObject.activeSelf)
			{
				flag = true;
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)currentOrderQuestElements[j].button);
				break;
			}
		}
		if (!flag)
		{
			GameInventoryUI.Get(base.JIIGOACEIKL).SelectObjectNextFrame();
		}
	}

	public void FFKBPAILBPP()
	{
		for (int i = 1; i < currentOrderQuestElements.Length; i++)
		{
			currentOrderQuestElements[i].RemoveSlotItems();
		}
	}

	public void FocusGameObject()
	{
		if (GOLHIBPAELD != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(GOLHIBPAELD);
		}
		if (IsOpen())
		{
			GOLHIBPAELD = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(LOKFEDGPBIM());
		}
	}

	public void HIBPCHBJGOO()
	{
		List<Item> aAHCDDHIBFH = (from r in RandomOrderQuestsManager.JFNOOMJMHCB().ABGHFHCDCOO()
			select r.output.item).ToList();
		List<Slot> allSlots = CraftingInventory.GetAllSlots(base.JIIGOACEIKL, aAHCDDHIBFH);
		allSlots = Utils.ENELGLONHKJ(allSlots);
		allSlots = LALKMPPEKED(allSlots);
		allSlots = HNOONCFCGOC(allSlots);
		GameInventoryUI.FFBJPAJKOJH(base.JIIGOACEIKL).PJEIHOCPBLA(allSlots, OGCAKIGELBJ: false);
		GameInventoryUI.BDJFHFHLJGN(base.JIIGOACEIKL).OpenUI();
	}

	private void IMDGEOMENCK(Quest AINAHCLIAFF)
	{
		MCPMKLBJCCN();
		NIIPNDJBKEJ();
	}

	public void UpdateUI()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (IsOpen())
		{
			availableOrderQuestElements[0].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[0]?.quest;
			availableOrderQuestElements[1].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[1]?.quest;
			availableOrderQuestElements[2].AINAHCLIAFF = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[2]?.quest;
			ActiveQuest[] currentOrderQuests = RandomOrderQuestsManager.GGFJGHHHEJC.GetCurrentOrderQuests();
			if (currentOrderQuests != null)
			{
				currentOrderQuestElements[0].EGDOLNDDNFC = Utils.OFAJOIGFMAD(currentOrderQuests, 0);
				currentOrderQuestElements[1].EGDOLNDDNFC = Utils.OFAJOIGFMAD(currentOrderQuests, 1);
				currentOrderQuestElements[2].EGDOLNDDNFC = Utils.OFAJOIGFMAD(currentOrderQuests, 2);
			}
			else
			{
				currentOrderQuestElements[0].AINAHCLIAFF = null;
				currentOrderQuestElements[1].AINAHCLIAFF = null;
				currentOrderQuestElements[2].AINAHCLIAFF = null;
			}
			UpdateInventory();
			if (GameManager.LocalCoop())
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(0f, -60f);
			}
			else
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).contentRect.anchoredPosition = new Vector2(-39f, -65f);
			}
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		}
	}
}
