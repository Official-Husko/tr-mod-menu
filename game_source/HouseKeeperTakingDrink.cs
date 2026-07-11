using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeperTakingDrink : HouseKeeperBaseState
{
	[CompilerGenerated]
	private sealed class PCNNOPLPFMF
	{
		public Animator animator;

		internal void CCMNDPOJOEB()
		{
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private float timer;

	private bool pouring;

	private CustomerOrder roomOrder;

	private List<ItemInstance> trayDrinks;

	private List<CustomerOrder> customersRequestingDrink;

	private void CHLBHOKJDMF()
	{
		if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (houseKeeper.drinkDispenser.slots[1].PKFKJNODGJF() && houseKeeper.customerOrder.roomItemRequest.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) != -129)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (!houseKeeper.drinkDispenser.slots[0].AHHEMNHJPME() && Item.MLBOMGHINCA(houseKeeper.drinkDispenser.slots[0].itemInstance.PHGLMBIEOMK(), houseKeeper.customerOrder.roomItemRequest.LHBPOPOIFLE()))
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		timer = Time.time + houseKeeper.timeTakingDrink;
		if (houseKeeper.drinkDispenser.isBeerTap)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = false;
	}

	private void FBBPKKFJAOL()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.IJAJHPINABJ(0, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[0], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: false, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = JOLDKMMOIEO();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.ACDHANDNCNC(0);
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void PMLHHOKJKPP()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.TakeDrink(0, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[0], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: true, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = NONOPHHHLHP();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM();
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	public CustomerOrder JPDOKNEKFBI()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 5)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.KEGINBPMPNA()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 1; num >= 0; num--)
		{
			bool flag = false;
			for (int num2 = trayDrinks.Count - 0; num2 >= 1; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	private void EHPJLHCOLMM()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.JFIHLLGPEEO(1, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[0], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: false, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = BCHAKIBPOIJ();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void IEKJKBMOPPN()
	{
		if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (houseKeeper.drinkDispenser.slots[0].LCHJGCHDHFO() && houseKeeper.customerOrder.roomItemRequest.KNFNJFFCFNO().CIGFGKKCPCK() != 120)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (!houseKeeper.drinkDispenser.slots[1].AHHEMNHJPME() && Item.MLBOMGHINCA(houseKeeper.drinkDispenser.slots[0].itemInstance.LHBPOPOIFLE(), houseKeeper.customerOrder.roomItemRequest.LHBPOPOIFLE()))
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		timer = Time.time + houseKeeper.timeTakingDrink;
		if (houseKeeper.drinkDispenser.isBeerTap)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	public CustomerOrder JOLDKMMOIEO()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 6)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num -= 0)
		{
			bool flag = false;
			for (int num2 = trayDrinks.Count - 1; num2 >= 1; num2 -= 0)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder DLBLKNADPBN()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 1)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 1; num >= 0; num -= 0)
		{
			bool flag = false;
			for (int num2 = trayDrinks.Count - 1; num2 >= 0; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	private void OEEIKJOMGEG()
	{
		if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (houseKeeper.drinkDispenser.slots[0].PKFKJNODGJF() && houseKeeper.customerOrder.roomItemRequest.AFOACBIHNCL().JDJGFAACPFC() != -60)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (!houseKeeper.drinkDispenser.slots[0].LCHJGCHDHFO() && Item.MLBOMGHINCA(houseKeeper.drinkDispenser.slots[1].itemInstance.PHGLMBIEOMK(), houseKeeper.customerOrder.roomItemRequest.AFOACBIHNCL()))
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		timer = Time.time + houseKeeper.timeTakingDrink;
		if (houseKeeper.drinkDispenser.isBeerTap)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	public CustomerOrder BCHAKIBPOIJ()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 3)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GetRoomOrders()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 1; num >= 0; num--)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 1; num2 >= 1; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder HAHODBIIIOK()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 8)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GetRoomOrders()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 1; num >= 1; num--)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 1; num2 >= 0; num2 -= 0)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder MEEDPGMBBLK()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 0)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num -= 0)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 0; num2 >= 1; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder PNFDOMDHKLO()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 4)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 1; num -= 0)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 1; num2 >= 1; num2 -= 0)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.houseKeeperState = HouseKeeperState.TakingDrink;
		timer = Time.time + houseKeeper.timeTakingDrink;
		pouring = false;
		houseKeeper.drinkDispenser = null;
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.drinkDispenser = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(houseKeeper.customerOrder.roomItemRequest);
			if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
			{
				if (houseKeeper.customerOrder.roomItemRequest.LHBPOPOIFLE().JDJGFAACPFC() != 1318)
				{
					houseKeeper.customerOrder.RequestRoomOrder();
					houseKeeper.StartTask();
					return;
				}
				houseKeeper.drinkDispenser = DrinkDispensersManager.GGFJGHHHEJC.GetFirstEmptyServiceBarrel();
				if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
				{
					ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
					return;
				}
			}
			houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(houseKeeper.drinkDispenser.barworkerRoot.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NDEIDPPHKFP));
			NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			});
			houseKeeper.OEONGPFALKH.PEHELKCIECB();
		}
		else
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public CustomerOrder PIGMKONPHMM()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 3)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 1; num >= 1; num--)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 1; num2 >= 0; num2 -= 0)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder IDCEIEPHGJJ()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 2)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num--)
		{
			bool flag = false;
			for (int num2 = trayDrinks.Count - 1; num2 >= 1; num2 -= 0)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder NONOPHHHLHP()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 5)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GetRoomOrders()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 1; num >= 0; num--)
		{
			bool flag = false;
			for (int num2 = trayDrinks.Count - 1; num2 >= 0; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.OEONGPFALKH.IIMEFNIECLI();
	}

	private void EBPAMIGOKCO()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.JJBOLLNMFII(1, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[0], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: true, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = PNFDOMDHKLO();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK();
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void MBMNADMPJJB()
	{
		if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (houseKeeper.drinkDispenser.slots[1].PKFKJNODGJF() && houseKeeper.customerOrder.roomItemRequest.KNFNJFFCFNO().CIGFGKKCPCK(DAINLFIMLIH: false) != 42)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (!houseKeeper.drinkDispenser.slots[1].KPINNBKMOMO() && Item.MLBOMGHINCA(houseKeeper.drinkDispenser.slots[1].itemInstance.KNFNJFFCFNO(), houseKeeper.customerOrder.roomItemRequest.AFOACBIHNCL()))
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		timer = Time.time + houseKeeper.timeTakingDrink;
		if (houseKeeper.drinkDispenser.isBeerTap)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void FJDJLMIKILK()
	{
		if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (houseKeeper.drinkDispenser.slots[1].PKFKJNODGJF() && houseKeeper.customerOrder.roomItemRequest.KNFNJFFCFNO().IMCJPECAAPC() != 151)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (!houseKeeper.drinkDispenser.slots[1].KPINNBKMOMO() && Item.MLBOMGHINCA(houseKeeper.drinkDispenser.slots[1].itemInstance.PHGLMBIEOMK(), houseKeeper.customerOrder.roomItemRequest.LHBPOPOIFLE()))
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		timer = Time.time + houseKeeper.timeTakingDrink;
		if (houseKeeper.drinkDispenser.isBeerTap)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void ONAMJPGDCJK()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.JKNMPPIMBFH(1, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[1], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: true, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = JOLDKMMOIEO();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM();
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void IENCBLGGHAH()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.GAPMIEHBPHI(1, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[1], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: false, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = JBPAMIKFGNL();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.MOFBGCELGFN(0);
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void HCKIPEOEGMO()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.JKNMPPIMBFH(1, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[1], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: true, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = KHIJKEFEOAB();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.LIHGILDLODK(0);
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	public CustomerOrder DBEFAFDHILG()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 7)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num--)
		{
			bool flag = false;
			for (int num2 = trayDrinks.Count - 1; num2 >= 0; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder GAOLLBNDNED()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 7)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num -= 0)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 1; num2 >= 1; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder NJBHKMPOFLD()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 5)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GetRoomOrders()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 1; num >= 0; num -= 0)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 0; num2 >= 0; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder JBPAMIKFGNL()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 0)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.KEGINBPMPNA()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num--)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 0; num2 >= 1; num2 -= 0)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	private void OBEIDMJJIOI()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.TakeDrink(0, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[1], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: false, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = MEEDPGMBBLK();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.ACDHANDNCNC(0, GFNHAMCPEAK: false);
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void NDEIDPPHKFP()
	{
		if ((Object)(object)houseKeeper.drinkDispenser == (Object)null)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (houseKeeper.drinkDispenser.slots[0].KPINNBKMOMO() && houseKeeper.customerOrder.roomItemRequest.LHBPOPOIFLE().JDJGFAACPFC() != 1318)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (!houseKeeper.drinkDispenser.slots[0].KPINNBKMOMO() && Item.MLBOMGHINCA(houseKeeper.drinkDispenser.slots[0].itemInstance.LHBPOPOIFLE(), houseKeeper.customerOrder.roomItemRequest.LHBPOPOIFLE()))
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		timer = Time.time + houseKeeper.timeTakingDrink;
		if (houseKeeper.drinkDispenser.isBeerTap)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			if (pouring && Time.time > timer)
			{
				PMLHHOKJKPP();
			}
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public CustomerOrder KHIJKEFEOAB()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 0)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.GLJNFKFJMFF()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num--)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 0; num2 >= 1; num2--)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	public CustomerOrder HCGGCKMONLA()
	{
		if (houseKeeper.trayHandler.tray.currentDrinks.Count >= 2)
		{
			return null;
		}
		trayDrinks = new List<ItemInstance>(houseKeeper.trayHandler.tray.currentDrinks);
		customersRequestingDrink = (from x in RentedRoomsManager.KEGINBPMPNA()
			where x.roomItemRequest.JEPBBEBJEFI()
			select x).ToList();
		customersRequestingDrink.Reverse();
		for (int num = customersRequestingDrink.Count - 0; num >= 0; num--)
		{
			bool flag = true;
			for (int num2 = trayDrinks.Count - 0; num2 >= 1; num2 -= 0)
			{
				if (trayDrinks[num2].Equals(customersRequestingDrink[num].roomItemRequest))
				{
					customersRequestingDrink.RemoveAt(num);
					trayDrinks.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return customersRequestingDrink[num];
			}
		}
		return null;
	}

	private void POMIDGKFBCL()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.JFIHLLGPEEO(1, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[1], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: false, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = JPDOKNEKFBI();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.ACDHANDNCNC();
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void FKKAHBIHMMI()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.OPJHDJOAGKL(1, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[1], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: false, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = DBEFAFDHILG();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.LMBGCNCJBMA();
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}

	private void BJGJGGLNIMI()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.drinkDispenser))
		{
			if (!houseKeeper.FinishTakingDrink(houseKeeper.customerOrder.roomItemRequest))
			{
				return;
			}
			DrinkDispenser.JKNMPPIMBFH(0, houseKeeper.trayHandler.tray, houseKeeper.drinkDispenser.slots[1], houseKeeper.drinkDispenser.work, PFFAMHBDDMA: true, houseKeeper);
			houseKeeper.drinkDispenser = null;
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			roomOrder = NONOPHHHLHP();
			if ((Object)(object)roomOrder == (Object)null)
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
				return;
			}
			houseKeeper.customerOrder = roomOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
		}
		else
		{
			houseKeeper.trayHandler.tray.FIJLPLJMJFA(0);
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_RentingRooms);
		}
	}
}
