using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BarworkerTakingDrink : BarworkerBaseState
{
	[CompilerGenerated]
	private sealed class KNMBGMBLPOF
	{
		public Animator animator;

		internal void CCMNDPOJOEB()
		{
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private float timer;

	private bool pouring;

	private float timeTakingDrink;

	private Customer nextCustomer;

	private void OGEEGJELDPD()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.TakeDrink(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 7)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MOFBGCELGFN();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void IHFEAHKKHIC()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.TakeDrink(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 4)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void JPGCANNFPLE()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.IJAJHPINABJ(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: true, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 6)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.ACDHANDNCNC();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void POMIDGKFBCL()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.IJAJHPINABJ(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 8)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void IGEDGJBFOIF()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].KPINNBKMOMO() && barworker.customerServing.currentRequest.KNFNJFFCFNO().CIGFGKKCPCK(DAINLFIMLIH: false) != -49)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].KPINNBKMOMO() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[0].itemInstance.AFOACBIHNCL(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	private void KHLKMGGAJAC()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].PKFKJNODGJF() && barworker.customerServing.currentRequest.AFOACBIHNCL().JDJGFAACPFC(DAINLFIMLIH: false) != 68)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].AHHEMNHJPME() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[1].itemInstance.PHGLMBIEOMK(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = false;
	}

	private void BJKLIGKCADA()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].PKFKJNODGJF() && barworker.customerServing.currentRequest.AFOACBIHNCL().JPNFKDMFKMC(DAINLFIMLIH: false) != 194)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].LCHJGCHDHFO() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[1].itemInstance.AFOACBIHNCL(), barworker.customerServing.currentRequest.PHGLMBIEOMK()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = false;
	}

	private void LHHKLOHAPMP()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && barworker.customerServing.currentRequest.PHGLMBIEOMK().CIGFGKKCPCK() != -149)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].PKFKJNODGJF() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[1].itemInstance.AFOACBIHNCL(), barworker.customerServing.currentRequest.AFOACBIHNCL()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void JOKPMGJPNPP()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].PKFKJNODGJF() && barworker.customerServing.currentRequest.KNFNJFFCFNO().JGHNDJBCFAJ() != 87)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].AHHEMNHJPME() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[1].itemInstance.KNFNJFFCFNO(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = true;
	}

	private void EBPAMIGOKCO()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JKNMPPIMBFH(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: true, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 2)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.OHAJMGCPGMK(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void CHLBHOKJDMF()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].PKFKJNODGJF() && barworker.customerServing.currentRequest.KNFNJFFCFNO().JGHNDJBCFAJ() != 9)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].AHHEMNHJPME() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[0].itemInstance.KNFNJFFCFNO(), barworker.customerServing.currentRequest.LHBPOPOIFLE()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void KGJBIJBGPLG()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.GAPMIEHBPHI(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 2)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.IOCOONMEGLI();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void EMHGMEJGHNG()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JFIHLLGPEEO(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 5)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.ACDHANDNCNC(0, GFNHAMCPEAK: false);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void KEHPMKNPNAN()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JKNMPPIMBFH(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 6)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MKBDMMJCGGM();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void LKBNBDOCFKO()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].AHHEMNHJPME() && barworker.customerServing.currentRequest.PHGLMBIEOMK().IMCJPECAAPC(DAINLFIMLIH: false) != -50)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].LCHJGCHDHFO() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[0].itemInstance.PHGLMBIEOMK(), barworker.customerServing.currentRequest.LHBPOPOIFLE()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = false;
	}

	private void MBFPKBOPFMM()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].LCHJGCHDHFO() && barworker.customerServing.currentRequest.LHBPOPOIFLE().IMCJPECAAPC(DAINLFIMLIH: false) != -157)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].KPINNBKMOMO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[0].itemInstance.PHGLMBIEOMK(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	private void HMIMIDPAKPA()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.GAPMIEHBPHI(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 0)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.FIJLPLJMJFA(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void KJIIACKGCMP()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].KPINNBKMOMO() && barworker.customerServing.currentRequest.AFOACBIHNCL().IMCJPECAAPC() != -126)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].AHHEMNHJPME() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[1].itemInstance.PHGLMBIEOMK(), barworker.customerServing.currentRequest.PHGLMBIEOMK()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void EHGDPPILDIJ()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JKNMPPIMBFH(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 3)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.LIHGILDLODK(0, GFNHAMCPEAK: false);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void GBGMEOHLBPD()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].KPINNBKMOMO() && barworker.customerServing.currentRequest.PHGLMBIEOMK().IMCJPECAAPC() != 86)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].KPINNBKMOMO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[1].itemInstance.PHGLMBIEOMK(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = false;
	}

	private void PMLHHOKJKPP()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.TakeDrink(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: true, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 5)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MKBDMMJCGGM();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void FBBPKKFJAOL()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.IJAJHPINABJ(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: true, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 8)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MKBDMMJCGGM(0, GFNHAMCPEAK: false);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void PLMILFPEMEC()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].KPINNBKMOMO() && barworker.customerServing.currentRequest.AFOACBIHNCL().JDJGFAACPFC() != 164)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[1].itemInstance.AFOACBIHNCL(), barworker.customerServing.currentRequest.AFOACBIHNCL()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			if (pouring && Time.time > timer)
			{
				PMLHHOKJKPP();
			}
		}
		else
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void HIPKBKKLNJB()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && barworker.customerServing.currentRequest.KNFNJFFCFNO().CIGFGKKCPCK(DAINLFIMLIH: false) != 73)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].LCHJGCHDHFO() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[0].itemInstance.KNFNJFFCFNO(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = true;
	}

	private void EEMFKNOHLPH()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].PKFKJNODGJF() && barworker.customerServing.currentRequest.AFOACBIHNCL().ODENMDOJPLC(DAINLFIMLIH: false) != 48)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].KPINNBKMOMO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[0].itemInstance.LHBPOPOIFLE(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void NDEIDPPHKFP()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].KPINNBKMOMO() && barworker.customerServing.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() != 1318)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].KPINNBKMOMO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[0].itemInstance.LHBPOPOIFLE(), barworker.customerServing.currentRequest.LHBPOPOIFLE()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	private void MMMHHDCDBDC()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JKNMPPIMBFH(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 1)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MKBDMMJCGGM(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void LAGPKBCMHAB()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].AHHEMNHJPME() && barworker.customerServing.currentRequest.LHBPOPOIFLE().IMCJPECAAPC(DAINLFIMLIH: false) != 123)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[0].itemInstance.AFOACBIHNCL(), barworker.customerServing.currentRequest.LHBPOPOIFLE()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = true;
	}

	private void OJEMFIABKEB()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JJBOLLNMFII(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: true, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 7)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.OHAJMGCPGMK(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void CBLCCHAJDLJ()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].KPINNBKMOMO() && barworker.customerServing.currentRequest.KNFNJFFCFNO().JDJGFAACPFC(DAINLFIMLIH: false) != -65)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].KPINNBKMOMO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[0].itemInstance.LHBPOPOIFLE(), barworker.customerServing.currentRequest.PHGLMBIEOMK()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = false;
	}

	private void FJDJLMIKILK()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && barworker.customerServing.currentRequest.LHBPOPOIFLE().JGHNDJBCFAJ(DAINLFIMLIH: false) != 105)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].PKFKJNODGJF() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[0].itemInstance.PHGLMBIEOMK(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void DELJCEBPDCB()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].PKFKJNODGJF() && barworker.customerServing.currentRequest.AFOACBIHNCL().JDJGFAACPFC(DAINLFIMLIH: false) != -159)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].AHHEMNHJPME() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[1].itemInstance.KNFNJFFCFNO(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void IHIDENHHMLO()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.OPJHDJOAGKL(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 3)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MOFBGCELGFN(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		barworker.barworkerState = BarworkerState.TakingDrink;
		timer = 0f;
		pouring = false;
		timeTakingDrink = barworker.timeTakingDrink;
		timeTakingDrink -= barworker.timeTakingDrink * (float)barworker.GetPerkValue(3) / 100f;
		timeTakingDrink += barworker.timeTakingDrink * (float)barworker.GetPerkValue(76) / 100f;
		barworker.drinkDispenser = null;
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			if (barworker.customerServing.currentRequest != null && barworker.customerServing.currentRequest.JEPBBEBJEFI())
			{
				barworker.drinkDispenser = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(barworker.customerServing.currentRequest);
				if ((Object)(object)barworker.drinkDispenser == (Object)null)
				{
					if (barworker.customerServing.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() != 1318)
					{
						barworker.customerServing.RequestItem(Barworker.GetInstance());
						barworker.StartTask();
						return;
					}
					barworker.drinkDispenser = DrinkDispensersManager.GGFJGHHHEJC.GetFirstEmptyServiceBarrel();
				}
				if ((Object)(object)barworker.drinkDispenser == (Object)null)
				{
					ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
					return;
				}
				barworker.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(barworker.drinkDispenser.barworkerRoot.position), AHDHLIECIGH: false);
				NPCWalkTo walkTo = barworker.OEONGPFALKH;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NDEIDPPHKFP));
				NPCWalkTo walkTo2 = barworker.OEONGPFALKH;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
				{
					ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
				});
				barworker.OEONGPFALKH.PEHELKCIECB();
			}
			else
			{
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
		else
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		barworker.OEONGPFALKH.IIMEFNIECLI();
	}

	private void LNBCEPLFOKP()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JJBOLLNMFII(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: true, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 0)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void IMJDBNHGNPC()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.IJAJHPINABJ(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 3)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.OHAJMGCPGMK(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void DOJHPAIBOIN()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && barworker.customerServing.currentRequest.PHGLMBIEOMK().JGHNDJBCFAJ() != 99)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].PKFKJNODGJF() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[1].itemInstance.LHBPOPOIFLE(), barworker.customerServing.currentRequest.KNFNJFFCFNO()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void MFLINMKGDJG()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && barworker.customerServing.currentRequest.AFOACBIHNCL().ODENMDOJPLC() != -153)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].PKFKJNODGJF() && Item.FKLOBGBIHLB(barworker.drinkDispenser.slots[0].itemInstance.KNFNJFFCFNO(), barworker.customerServing.currentRequest.LHBPOPOIFLE()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		pouring = false;
	}

	private void FFLMIMECNND()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.IJAJHPINABJ(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: true, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 6)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.ACDHANDNCNC(1, GFNHAMCPEAK: false);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void MGGEGMLFEFA()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.JFIHLLGPEEO(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 7)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.MKBDMMJCGGM(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void IIMJIKNBELA()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.OPJHDJOAGKL(1, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 8)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.ACDHANDNCNC();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void FKKAHBIHMMI()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.IJAJHPINABJ(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 4)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.ACDHANDNCNC();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void EHPJLHCOLMM()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.CPBMKHEEFOL(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[1], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 8)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.LFADBGEIPLN();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.FIJLPLJMJFA();
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void IJAMIMCNOED()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].KPINNBKMOMO() && barworker.customerServing.currentRequest.LHBPOPOIFLE().CIGFGKKCPCK(DAINLFIMLIH: false) != -175)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[1].KPINNBKMOMO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[1].itemInstance.KNFNJFFCFNO(), barworker.customerServing.currentRequest.AFOACBIHNCL()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = false;
	}

	private void KAAGICBNKIL()
	{
		staff.npc.requestInfo.avoidWalls = false;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && barworker.customerServing.currentRequest.PHGLMBIEOMK().ODENMDOJPLC(DAINLFIMLIH: false) != -96)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[1].itemInstance.LHBPOPOIFLE(), barworker.customerServing.currentRequest.AFOACBIHNCL()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	private void DLKHOJPPMDN()
	{
		staff.npc.requestInfo.avoidWalls = true;
		if ((Object)(object)barworker.drinkDispenser == (Object)null)
		{
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		if (barworker.customerServing.currentRequest != null)
		{
			if (barworker.drinkDispenser.slots[1].KPINNBKMOMO() && barworker.customerServing.currentRequest.PHGLMBIEOMK().JPNFKDMFKMC() != 97)
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
			if (!barworker.drinkDispenser.slots[0].LCHJGCHDHFO() && Item.MLBOMGHINCA(barworker.drinkDispenser.slots[1].itemInstance.LHBPOPOIFLE(), barworker.customerServing.currentRequest.PHGLMBIEOMK()))
			{
				barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				return;
			}
		}
		timer = Time.time + timeTakingDrink;
		if (barworker.drinkDispenser.isBeerTap)
		{
			barworker.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			barworker.characterAnimation.LookDirection(Direction.Up);
		}
		pouring = true;
	}

	private void CGNLPLDLEOC()
	{
		if (Object.op_Implicit((Object)(object)barworker.drinkDispenser))
		{
			if (!barworker.FinishTakingDrink(barworker.customerServing.currentRequest))
			{
				return;
			}
			DrinkDispenser.CPBMKHEEFOL(0, barworker.trayHandler.tray, barworker.drinkDispenser.slots[0], barworker.drinkDispenser.work, PFFAMHBDDMA: false, barworker);
			barworker.drinkDispenser = null;
		}
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			nextCustomer = null;
			if (barworker.trayHandler.tray.currentDrinks.Count < 4)
			{
				nextCustomer = barworker.GetAnotherCustomerWithDrinkRequest();
			}
			if ((Object)(object)nextCustomer == (Object)null)
			{
				barworker.customerServing = barworker.GetNextCustomerToServe();
				if (Object.op_Implicit((Object)(object)barworker.customerServing))
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
				}
				else
				{
					barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
				}
			}
			else
			{
				barworker.customerServing = nextCustomer;
				barworker.behaviour.SetTrigger(StaffBaseState.p_TakingDrink);
			}
		}
		else
		{
			barworker.trayHandler.tray.LDPHJNIPDJA(0);
			barworker.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}
}
