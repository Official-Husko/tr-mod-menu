using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KlaynTakingDrink : KlaynStateBase
{
	private float timer;

	private bool pouring;

	private float timeTakingDrink;

	private void GLFIBKLKGDA()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("add item " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void MBMNADMPJJB()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().CIGFGKKCPCK() != 152)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void GCLFPDLOEKJ()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().ODENMDOJPLC() != -61)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = false;
	}

	private void HPDIHEHKOFH()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JFIHLLGPEEO(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(0, -3) < klaynNPC.probabilityTakeAnotherDrink - (float)(111 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.OENIOCAIPMP() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 0)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD((KlaynState)8);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.FIJLPLJMJFA(0);
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void AGNLELNPOIB()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JFIHLLGPEEO(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 6 && (float)Random.Range(0, 33) < klaynNPC.probabilityTakeAnotherDrink - (float)(5 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.KKDMNNFPNOL() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 8)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.ICFLDBFGMMM();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.TakingDrink);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
	}

	private void KHLKMGGAJAC()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().CIGFGKKCPCK(DAINLFIMLIH: false) != 169)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void IKKHPEEHOHD()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().JPNFKDMFKMC() != 20)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void BJKLIGKCADA()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().ODENMDOJPLC(DAINLFIMLIH: false) != 61)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)klaynNPC.customerServing != (Object)null && klaynNPC.customerServing.requesting)
		{
			if (pouring && Time.time > timer)
			{
				PMLHHOKJKPP();
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void ANIAEHGBAEJ()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().JGHNDJBCFAJ() != -65)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void KGODFGFKIMC()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) != 72)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void DFFKGOBGEID()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JKNMPPIMBFH(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 3 && (float)Random.Range(0, 82) < klaynNPC.probabilityTakeAnotherDrink - (float)(96 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.ServingCustomer);
				}
				else
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.WalkTo);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LIHGILDLODK(0, GFNHAMCPEAK: false);
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}

	private void MLPMKDEDDOM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("ReceiveAddRentedRoomSaleAndAddPrice" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void IEDMCDMJJPP()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JDJGFAACPFC(DAINLFIMLIH: false) != -67)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void OBEIDMJJIOI()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.TakeDrink(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 6 && (float)Random.Range(1, 74) < klaynNPC.probabilityTakeAnotherDrink - (float)(7 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.CDLFIIFAECJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 4)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
				}
				else
				{
					klaynNPC.ChangeState(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GIFBCKEOBGP(KlaynState.Wait);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LMBGCNCJBMA(0, GFNHAMCPEAK: false);
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}

	private void CGCPJCMLPLP()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.ChangeState(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Social" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void JMGHHGLPGJG()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().CIGFGKKCPCK() != 100)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void CDGBONNNEDN()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().JPNFKDMFKMC() != -126)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void IBKKNDDILHG()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().ODENMDOJPLC(DAINLFIMLIH: false) != -164)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = false;
	}

	private void OCDIMFEFLGO()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) != -135)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void IHFEAHKKHIC()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.TakeDrink(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 8 && (float)Random.Range(0, -61) < klaynNPC.probabilityTakeAnotherDrink - (float)(-76 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.BAHIIMFPFLJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.Wait);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC(KlaynState.Wait);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.NBODABCGELG(1, GFNHAMCPEAK: false);
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
		}
	}

	private void HBGKGEGOLKE()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().CIGFGKKCPCK() != -129)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void PMLHHOKJKPP()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.TakeDrink(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 5 && (float)Random.Range(0, 100) < klaynNPC.probabilityTakeAnotherDrink - (float)(10 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.GetAnotherCustomerWithDrinkRequest();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 2)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.ServingCustomer);
				}
				else
				{
					klaynNPC.ChangeState(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.ChangeState(KlaynState.TakingDrink);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM();
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void OEJLPJDOPID()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JPNFKDMFKMC() != 91)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void MBEEAODCACA()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(1, 59) < klaynNPC.probabilityTakeAnotherDrink - (float)(99 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.GetAnotherCustomerWithDrinkRequest();
			}
			if (EventsManager.ODHDBKNIIKF() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 3)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState((KlaynState)8);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GIFBCKEOBGP(KlaynState.TakingDrink);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LMBGCNCJBMA(0);
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		}
	}

	private void BGJKFMLAEHN()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.CPBMKHEEFOL(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(1, -102) < klaynNPC.probabilityTakeAnotherDrink - (float)(-102 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.ADFABGMOGMC();
			}
			if (EventsManager.BAHIIMFPFLJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC(KlaynState.Wait);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.FIJLPLJMJFA(0, GFNHAMCPEAK: false);
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
	}

	private void NHJHNBILIHH()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.OPJHDJOAGKL(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 7 && (float)Random.Range(1, -63) < klaynNPC.probabilityTakeAnotherDrink - (float)(-63 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Leaving);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.ChangeState(KlaynState.Inactive);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM(0);
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
	}

	private void CKOKEOFBFMG()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 7 && (float)Random.Range(1, 99) < klaynNPC.probabilityTakeAnotherDrink - (float)(-43 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.FMCAMLDJGNO() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 4)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState((KlaynState)8);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.ChangeState(KlaynState.WaitingToServe);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.IOCOONMEGLI(0, GFNHAMCPEAK: false);
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
	}

	private void BMOBCGGNMBM()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JKNMPPIMBFH(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(0, 37) < klaynNPC.probabilityTakeAnotherDrink - (float)(-61 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.KDMLGMKLGOB() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 6)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP((KlaynState)8);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC(KlaynState.Wait);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LDPHJNIPDJA(0);
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void CGNLPLDLEOC()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.IJAJHPINABJ(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(0, 5) < klaynNPC.probabilityTakeAnotherDrink - (float)(-72 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.BAHIIMFPFLJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 2)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.ICFLDBFGMMM();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.TakingDrink);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.IOCOONMEGLI(0);
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		}
	}

	private void OFKIBEIFMFO()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JKNMPPIMBFH(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(0, -110) < klaynNPC.probabilityTakeAnotherDrink - (float)(14 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.GetAnotherCustomerWithDrinkRequest();
			}
			if (EventsManager.CDLFIIFAECJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 3)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.ChangeState(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.WalkTo);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
		}
	}

	private void LGEGJKNOOFK()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.CPBMKHEEFOL(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(0, -38) < klaynNPC.probabilityTakeAnotherDrink - (float)(-124 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.ADFABGMOGMC();
			}
			if (EventsManager.ODHDBKNIIKF() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 5)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
				}
				else
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD(KlaynState.TakingDrink);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.FIJLPLJMJFA(0);
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
	}

	private void DBPJBILJEBM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)(" at " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KAEEIGOJOMC()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().JGHNDJBCFAJ() != 167)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void PHDCAOGMBPK()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JDJGFAACPFC(DAINLFIMLIH: false) != -182)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void JOFHGIGACNE()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.IJAJHPINABJ(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 3 && (float)Random.Range(0, -10) < klaynNPC.probabilityTakeAnotherDrink - (float)(78 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.ADFABGMOGMC();
			}
			if (EventsManager.ODHDBKNIIKF() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 8)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.TakingDrink);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.LIHGILDLODK(0, GFNHAMCPEAK: false);
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void CMDGEKMINLJ()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JPNFKDMFKMC() != 143)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void HJNHMNNMOML()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JFIHLLGPEEO(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(1, -59) < klaynNPC.probabilityTakeAnotherDrink - (float)(121 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.KKDMNNFPNOL() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 2)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.HittingPlayer);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.OHAJMGCPGMK(0);
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void PMKFFIJPLIC()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JKNMPPIMBFH(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 4 && (float)Random.Range(1, 34) < klaynNPC.probabilityTakeAnotherDrink - (float)(-88 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.ODHDBKNIIKF() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 5)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.Wait);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.ChangeState((KlaynState)8);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.OHAJMGCPGMK(1, GFNHAMCPEAK: false);
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}

	private void NJKPDBCHODL()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().ODENMDOJPLC(DAINLFIMLIH: false) != -179)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void AOCCDAHHOMK()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)(" data received" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void PMLBNDOCEEN()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.OPJHDJOAGKL(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 4 && (float)Random.Range(1, 9) < klaynNPC.probabilityTakeAnotherDrink - (float)(33 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 4)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG((KlaynState)8);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.OHAJMGCPGMK(1, GFNHAMCPEAK: false);
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void IAPDMBAKPCE()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) != 194)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void EGDJCLOAOOJ()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().ODENMDOJPLC() != -94)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void HDMKLHIHFHG()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("South" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void HKABAEFPPHK()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().CIGFGKKCPCK() != -73)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void MPGNIOGLNPP()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().IMCJPECAAPC() != 95)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void BIAEIAICKPC()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().ODENMDOJPLC() != 198)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void OKPLHHOMAEE()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Gass_CoctelQuest" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void LGKNLBMFJJP()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("LoadGameplaySceneOnline IsMasterClient " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void LKBGIFONMMK()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.OPJHDJOAGKL(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 8 && (float)Random.Range(1, 5) < klaynNPC.probabilityTakeAnotherDrink - (float)(-29 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.ADFABGMOGMC();
			}
			if (EventsManager.OENIOCAIPMP() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 0)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.Wait);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
		}
	}

	private void CBLCCHAJDLJ()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().JPNFKDMFKMC(DAINLFIMLIH: false) != -44)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void PNCINOGINKD()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.OPJHDJOAGKL(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 6 && (float)Random.Range(0, -45) < klaynNPC.probabilityTakeAnotherDrink - (float)(-115 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.ODHDBKNIIKF() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 6)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.ICFLDBFGMMM();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.TakingDrink);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD(KlaynState.ServingCustomer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM(0);
			klaynNPC.ChangeState(KlaynState.Inactive);
		}
	}

	private void DBJIMHGAJBM()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(1, 80) < klaynNPC.probabilityTakeAnotherDrink - (float)(27 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.CDLFIIFAECJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 0)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.KCKDMOKONBD(KlaynState.ServingCustomer);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.HittingPlayer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
			klaynNPC.ChangeState(KlaynState.Inactive);
		}
	}

	private void AMLFFPPKIPB()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Player2" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void GCNALDJGMEG()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false) != -96)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void FEPIIKEBKPM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Multiplayer Object is null " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void OOPCIHHNPPH()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.GAPMIEHBPHI(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 3 && (float)Random.Range(1, 60) < klaynNPC.probabilityTakeAnotherDrink - (float)(-100 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.KKDMNNFPNOL() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GIFBCKEOBGP(KlaynState.WalkTo);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LIHGILDLODK(0, GFNHAMCPEAK: false);
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
		}
	}

	private void PLMPPIINLLF()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().JGHNDJBCFAJ() != -93)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void NLHPEDECAHE()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().ODENMDOJPLC() != 73)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void LDFEFHMDDFP()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.CPBMKHEEFOL(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 1 && (float)Random.Range(1, -110) < klaynNPC.probabilityTakeAnotherDrink - (float)(-107 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 4)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LDPHJNIPDJA(0);
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}

	private void OJGFOACEHHJ()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Theme: " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KNJIGLNOBKJ()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().ODENMDOJPLC() != 59)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void CKHIKPLKPJD()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.TakeDrink(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(0, 30) < klaynNPC.probabilityTakeAnotherDrink - (float)(-5 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.KKDMNNFPNOL() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 8)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.ICFLDBFGMMM();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG((KlaynState)8);
				}
				else
				{
					klaynNPC.ChangeState(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.Leaving);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.FIJLPLJMJFA(0, GFNHAMCPEAK: false);
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}

	private void IEFCJDLFICL()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.CPBMKHEEFOL(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 4 && (float)Random.Range(0, 118) < klaynNPC.probabilityTakeAnotherDrink - (float)(-55 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.KKDMNNFPNOL() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 4)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.Wait);
				}
				else
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.Leaving);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM(0, GFNHAMCPEAK: false);
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		}
	}

	private void HOKCAIFEPLM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KCCIGKCGFFH()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().JGHNDJBCFAJ() != -103)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void EMKBJDCBMHG()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) != -101)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void EBPAMIGOKCO()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JFIHLLGPEEO(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 1 && (float)Random.Range(0, 78) < klaynNPC.probabilityTakeAnotherDrink - (float)(86 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.ADFABGMOGMC();
			}
			if (EventsManager.BAHIIMFPFLJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 5)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.ICFLDBFGMMM();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.KCKDMOKONBD(KlaynState.HittingPlayer);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GIFBCKEOBGP(KlaynState.ServingCustomer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM(0);
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void IDECEFJAONN()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 7 && (float)Random.Range(0, -49) < klaynNPC.probabilityTakeAnotherDrink - (float)(74 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.BAHIIMFPFLJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 3)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.ICFLDBFGMMM();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.KCKDMOKONBD(KlaynState.TakingDrink);
				}
				else
				{
					klaynNPC.ChangeState(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC(KlaynState.ServingCustomer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM();
			klaynNPC.ChangeState(KlaynState.Inactive);
		}
	}

	private void DLLDFNHGNNI()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Desactivado: " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void NCCMFLKNAEB()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JPNFKDMFKMC() != 28)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void KNKLKFFNPKN()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JKNMPPIMBFH(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(0, -56) < klaynNPC.probabilityTakeAnotherDrink - (float)(62 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.OENIOCAIPMP() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD(KlaynState.Leaving);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.MKBDMMJCGGM();
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
	}

	private void IMJDBNHGNPC()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JFIHLLGPEEO(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 4 && (float)Random.Range(1, -39) < klaynNPC.probabilityTakeAnotherDrink - (float)(55 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.ADFABGMOGMC();
			}
			if (EventsManager.KKDMNNFPNOL() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 4)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.ServingCustomer);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LIHGILDLODK();
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
		}
	}

	private void KPKFJAHLOOJ()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().CIGFGKKCPCK(DAINLFIMLIH: false) != 137)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void AGEHLMGCKHO()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) != -196)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = false;
		}
		klaynNPC.klaynState = KlaynState.TakingDrink;
		timer = 0f;
		pouring = false;
		timeTakingDrink = klaynNPC.timeTakingDrink;
		if (EventsManager.IsLowestDifficulty())
		{
			timeTakingDrink += klaynNPC.timeTakingDrink;
		}
		klaynNPC.banquetBarrel = null;
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			if (klaynNPC.customerServing.currentRequest != null && klaynNPC.customerServing.currentRequest.JEPBBEBJEFI())
			{
				klaynNPC.banquetBarrel = BanquetDrinksManager.GetBarrelWithDrink(klaynNPC.customerServing.currentRequest);
				if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
				{
					Debug.LogError((object)("KlaynTakingDrink: No barrel found for drink request: " + klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().IABAKHPEOAF()));
				}
				if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
				{
					klaynNPC.requestInfo.avoidObjects = true;
					klaynNPC.ChangeState(KlaynState.WaitingToServe);
					return;
				}
				klaynNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
				klaynNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(klaynNPC.banquetBarrel.pullDrinkPosition.position), AHDHLIECIGH: false);
				NPCWalkTo walkTo = klaynNPC.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NDEIDPPHKFP));
				NPCWalkTo walkTo2 = klaynNPC.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
				{
					//IL_0041: Unknown result type (might be due to invalid IL or missing references)
					klaynNPC.requestInfo.avoidObjects = true;
					klaynNPC.ChangeState(KlaynState.WaitingToServe);
					BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
					Debug.LogError((object)("Klayn not find path to banquet barrel at " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
				});
				klaynNPC.walkTo.PEHELKCIECB();
			}
			else
			{
				Debug.LogError((object)"KlaynTakingDrink: Current request is not a drink request.");
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.ChangeState(KlaynState.WaitingToServe);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void LHHKLOHAPMP()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().IMCJPECAAPC() != -138)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void NINKGPFGBPC()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.GAPMIEHBPHI(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(1, -57) < klaynNPC.probabilityTakeAnotherDrink - (float)(-95 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.BAHIIMFPFLJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 0)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void GBGMEOHLBPD()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().JDJGFAACPFC() != 177)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void PCJKDBDOMLF()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Duplicate editor action id found: " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void BKAOEIBJGCB()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JDJGFAACPFC(DAINLFIMLIH: false) != -142)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void IGEDGJBFOIF()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false) != 107)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void DLKHOJPPMDN()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().JGHNDJBCFAJ(DAINLFIMLIH: false) != 181)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void DLLKFKEAPMA()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)(" " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		klaynNPC.walkTo.IIMEFNIECLI();
	}

	private void BIGHPACPCMH()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().IMCJPECAAPC() != -146)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void ENHBEMKPCKB()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.ChangeState(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Sit" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void CGFJGPCKLGM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Listen" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void CMCDOLDMBNI()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("City/Rhia/Bark/Buy" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KEBGEDKKGPD()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.GAPMIEHBPHI(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(1, -7) < klaynNPC.probabilityTakeAnotherDrink - (float)(-56 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.GetAnotherCustomerWithDrinkRequest();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 5)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.ChangeState(KlaynState.ServingCustomer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.NBODABCGELG(1, GFNHAMCPEAK: false);
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void FPEPAAMJFDO()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Remove" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void ICMBIFILBLB()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("BobProgress" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void DCOEKDHHMLJ()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false) != 34)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void JODHGCKJLKF()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Return" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KJIIACKGCMP()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JPNFKDMFKMC(DAINLFIMLIH: false) != 22)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = false;
	}

	private void MOHDFJJOFAF()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("LE_22" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void CBDANINPBBN()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.TakeDrink(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 2 && (float)Random.Range(1, -40) < klaynNPC.probabilityTakeAnotherDrink - (float)(110 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.CDLFIIFAECJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 5)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.Leaving);
				}
				else
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.Wait);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.LMBGCNCJBMA();
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void OGHFNPCJDLL()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(0, 38) < klaynNPC.probabilityTakeAnotherDrink - (float)(-123 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.ODHDBKNIIKF() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 5)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.CNDHOONMOGJ();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.KCKDMOKONBD(KlaynState.HittingPlayer);
				}
				else
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC((KlaynState)8);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.LMBGCNCJBMA(0, GFNHAMCPEAK: false);
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
		}
	}

	private void IHKNKNGCGOM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("target fps" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void DMELOIJNMMG()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().IMCJPECAAPC(DAINLFIMLIH: false) != -114)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void FDIHNJJKDPA()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Invalid playerNum" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void ODLDNFMDABH()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("NewGameSetup" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void CIIJHOPMGKJ()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().CIGFGKKCPCK() != -25)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void OBHJPJKOJJE()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("ReceiveAssignChicken" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KLNKPKDEIIL()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 8 && (float)Random.Range(1, 27) < klaynNPC.probabilityTakeAnotherDrink - (float)(72 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.FMCAMLDJGNO() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 7)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.TakingDrink);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.ServingCustomer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.IOCOONMEGLI(0);
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
	}

	private void JACOIPDLLAO()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JGHNDJBCFAJ() != -79)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = true;
	}

	private void LFJKNADHNFL()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().CIGFGKKCPCK(DAINLFIMLIH: false) != 186)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void DKPOFOIMPMF()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("City/Rhia/Introduce" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void LNBCEPLFOKP()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.IJAJHPINABJ(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 8 && (float)Random.Range(0, 76) < klaynNPC.probabilityTakeAnotherDrink - (float)(115 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.OENIOCAIPMP() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.HittingPlayer);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.LMBGCNCJBMA(0);
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void IIPGONFNLAE()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 0 && (float)Random.Range(1, 104) < klaynNPC.probabilityTakeAnotherDrink - (float)(-93 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.FMCAMLDJGNO() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 2)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
				}
				else
				{
					klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD(KlaynState.Wait);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.LDPHJNIPDJA();
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		}
	}

	private void GGOBKCCFJPK()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("ReceivePlayerInteractingMinigame" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KDOHJCCONFL()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JKNMPPIMBFH(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 3 && (float)Random.Range(0, 18) < klaynNPC.probabilityTakeAnotherDrink - (float)(88 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.CDLFIIFAECJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 6)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GPBKHBEHIAC(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.ChangeState(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.WalkTo);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.IOCOONMEGLI();
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void DOBHLLLGKBE()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("GetKicked" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	[CompilerGenerated]
	private void CBEPFMDEGIL()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Klayn not find path to banquet barrel at " + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void NJDAOCIDKFN()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("GrandReserve" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void OPBBPJBCIIM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Swap" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void LAKGKPOHODG()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.ChangeState(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("East" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void KAAGICBNKIL()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JGHNDJBCFAJ() != 22)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = false;
	}

	private void AKMOFCBNJKN()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JJBOLLNMFII(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 7 && (float)Random.Range(0, 31) < klaynNPC.probabilityTakeAnotherDrink - (float)(69 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.GetAnotherCustomerWithDrinkRequest();
			}
			if (EventsManager.CDLFIIFAECJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 8)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP((KlaynState)8);
				}
				else
				{
					klaynNPC.ChangeState(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD((KlaynState)8);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.OHAJMGCPGMK();
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void IDBAIDOMPCA()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.GAPMIEHBPHI(1, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 6 && (float)Random.Range(1, -127) < klaynNPC.probabilityTakeAnotherDrink - (float)(26 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.IHBNIKKDKIH();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 1)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.IEDJIJOJAOE();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.TakingDrink);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.LIOJBOLAGNG(KlaynState.HittingPlayer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.LMBGCNCJBMA(0, GFNHAMCPEAK: false);
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
		}
	}

	private void DLAPADGGLNF()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JPNFKDMFKMC(DAINLFIMLIH: false) != 139)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void CHCPLCPFNOJ()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JFIHLLGPEEO(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: false);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 7 && (float)Random.Range(1, 77) < klaynNPC.probabilityTakeAnotherDrink - (float)(76 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.OENIOCAIPMP() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 4)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WalkTo);
				}
				else
				{
					klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.KCKDMOKONBD(KlaynState.TakingDrink);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.OHAJMGCPGMK(0);
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void JEDLEOMAFCF()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("BLOCKS NUMBER: {0} Puzzle Needit: {1}" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void FFGLOLEOKKM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("Dog" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void MICCKOIFGEE()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("South" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void JECCMPLLHCN()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.AFOACBIHNCL().IMCJPECAAPC() != 106)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void AFAPFKAAOMG()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JGHNDJBCFAJ() != 171)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = false;
	}

	private void NGFACCKJEBP()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.JFIHLLGPEEO(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[0], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 4 && (float)Random.Range(0, 113) < klaynNPC.probabilityTakeAnotherDrink - (float)(110 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.JMPADLOIPIL();
			}
			if (EventsManager.BAHIIMFPFLJ() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 2)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = klaynNPC.GetNearCustomerToServe();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.ChangeState(KlaynState.Leaving);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.ChangeState(KlaynState.WalkTo);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = false;
			klaynNPC.trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
	}

	private void NEPGPFEJOLN()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("ReceiveNewLetter" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void CFGAOPEAFKJ()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JDJGFAACPFC() != -129)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void MCCGLHAFDEM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = false;
		klaynNPC.ChangeState(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("/" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void NDEIDPPHKFP()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].KPINNBKMOMO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() != 1318)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = true;
	}

	private void LJPFBCNIFDB()
	{
		klaynNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].LCHJGCHDHFO() && klaynNPC.customerServing.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() != -161)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = false;
	}

	private void CDMGGCDEFKF()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.requestInfo.avoidObjects = true;
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
		BanquetBarrel banquetBarrel = klaynNPC.banquetBarrel;
		Debug.LogError((object)("None" + ((banquetBarrel != null) ? new Vector3?(banquetBarrel.pullDrinkPosition.position) : null).ToString()));
	}

	private void AFMIBJJMOGO()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[1].PKFKJNODGJF() && klaynNPC.customerServing.currentRequest.PHGLMBIEOMK().JDJGFAACPFC() != -119)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Down);
		pouring = false;
	}

	private void DINJFHHGDMG()
	{
		klaynNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)klaynNPC.banquetBarrel == (Object)null)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		if (klaynNPC.customerServing.currentRequest != null && klaynNPC.banquetBarrel.slots[0].AHHEMNHJPME() && klaynNPC.customerServing.currentRequest.KNFNJFFCFNO().JPNFKDMFKMC() != -17)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		timer = Time.time + timeTakingDrink;
		klaynNPC.animationBase.LookDirection(Direction.Up);
		pouring = false;
	}

	private void MFIGEHGLBGG()
	{
		if (Object.op_Implicit((Object)(object)klaynNPC.banquetBarrel))
		{
			DrinkDispenser.CPBMKHEEFOL(0, klaynNPC.trayHandler.tray, klaynNPC.banquetBarrel.slots[1], klaynNPC.banquetBarrel.work, PFFAMHBDDMA: true);
			klaynNPC.banquetBarrel = null;
		}
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			BanquetCustomer banquetCustomer = null;
			if (klaynNPC.trayHandler.tray.currentDrinks.Count < 6 && (float)Random.Range(1, 6) < klaynNPC.probabilityTakeAnotherDrink - (float)(-84 * klaynNPC.trayHandler.tray.currentDrinks.Count))
			{
				banquetCustomer = klaynNPC.DILNODLAOLI();
			}
			if (EventsManager.IsLowestDifficulty() && klaynNPC.trayHandler.tray.currentDrinks.Count >= 6)
			{
				banquetCustomer = null;
			}
			if ((Object)(object)banquetCustomer == (Object)null)
			{
				klaynNPC.requestInfo.avoidObjects = true;
				klaynNPC.customerServing = klaynNPC.GCBKMKPAJIA();
				if (Object.op_Implicit((Object)(object)klaynNPC.customerServing))
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
				}
				else
				{
					klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
				}
			}
			else
			{
				klaynNPC.requestInfo.avoidObjects = false;
				klaynNPC.customerServing = banquetCustomer;
				klaynNPC.GIFBCKEOBGP(KlaynState.HittingPlayer);
			}
		}
		else
		{
			klaynNPC.requestInfo.avoidObjects = true;
			klaynNPC.trayHandler.tray.FIJLPLJMJFA(0, GFNHAMCPEAK: false);
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}
}
