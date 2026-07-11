using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WaiterCleaningFloorDirt : WaiterBaseState
{
	private void KJALDFPOJDA()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.JEFADBEHABI().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void MKBPPJBENOI()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	[CompilerGenerated]
	private void EBJICJNAFDB()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
		}
	}

	private void LKIIJNOGJMK()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.JHOGIKCHCGG().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void BLDBHGFOCBN()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.DHMMHOPEMLF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.KOIKANGEOFD().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("BirdCatInteraction"))
		{
			return;
		}
		val = waiter.npc.LNJABLMFNNE().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName(" "))
		{
			val = waiter.npc.JEFADBEHABI().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Dialogue System/Conversation/TavernClean/Entry/8/Dialogue Text"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void LKAAKCIKBMJ()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HCDCANFEEPC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.LNJABLMFNNE().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.CCFDNFDEGIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.DCMNEPOPBKA().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Items/item_name_1080"))
		{
			return;
		}
		val = waiter.npc.BIFKPMIMAEC().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Shader Model 2.x"))
		{
			val = waiter.npc.APBNLDNECGJ().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("Dialogue System/Conversation/Gass_Stand/Entry/11/Dialogue Text"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void JMLBFKGKDBO()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.PNGIDKBCGCK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.CFIFGDBGLPH().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Cat"))
		{
			return;
		}
		val = waiter.npc.BFBEDHOHEPH().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("[CrystalPuzzle] - Initialize"))
		{
			val = waiter.npc.DHMMHOPEMLF().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Waiting for guest player to connect..."))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void JJMFJMJBBDC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.LNJABLMFNNE().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.GHNLDKEOCFA().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName(""))
		{
			return;
		}
		val = waiter.npc.GHNLDKEOCFA().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Intro08"))
		{
			val = waiter.npc.KOIKANGEOFD().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("<mark=#93502D><alpha=#00> "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void HOFCNIPLDAE()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EMIFIILKHDG()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void OFMIDPGHINA()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.BMCNJOEAJBH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.FNGPCELFEHO().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName(""))
		{
			return;
		}
		val = waiter.npc.DKLMKBPEHAJ().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Items/item_description_703"))
		{
			val = waiter.npc.BKPDJIDCAEO().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Tail"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void HGNAGOJDLMN()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.GHNLDKEOCFA().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName("Unique crop not found! Unique ID: "))
		{
			return;
		}
		val = waiter.npc.GDDFKLAEACF().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("StopTime"))
		{
			val = waiter.npc.BFBEDHOHEPH().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName(" "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void GNDNMOEFDPD()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void MFAGCIANIHI()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo currentState = waiter.npc.FJHKGBNBNKL.GetCurrentState(0);
		if (((AnimatorStateInfo)(ref currentState)).IsName(""))
		{
			return;
		}
		currentState = waiter.npc.BKPDJIDCAEO().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("ReceiveServeCustomerOrder"))
		{
			currentState = waiter.npc.FJHKGBNBNKL.GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("</color>"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void DDOMIMCEJBM()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.DCMNEPOPBKA().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void OAPOMCLHINL()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.KOIKANGEOFD().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.PABOGCMHLAN().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void KHGAGOIAFKM()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.FNGPCELFEHO().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void BPIMPFDOLKL()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.DHMMHOPEMLF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo currentState = waiter.npc.PNGIDKBCGCK().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref currentState)).IsName("openedPaths 0 before all blocksGenerationNumber"))
		{
			return;
		}
		currentState = waiter.npc.FNGPCELFEHO().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("Right"))
		{
			currentState = waiter.npc.CFIFGDBGLPH().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("Player"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void KNEBOLFOKMA()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.PAMGMEAHNCI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.OLHBCAHONME().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref val)).IsName("setDefaultSettings"))
		{
			return;
		}
		val = waiter.npc.OAHOFAKKBBA().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("TimeLeft"))
		{
			val = waiter.npc.OJELDLIEDNI().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("City/Lia/Bark/Stand"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void JJNNPIFGNOK()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.BKPDJIDCAEO().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void JMOPHNPJJIB()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HHNOLBGJOLL()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.OHKDOEFGKFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.PAMGMEAHNCI().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Error_PlaceItInChickenCoop"))
		{
			return;
		}
		val = waiter.npc.OAHOFAKKBBA().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("grasscliffs"))
		{
			val = waiter.npc.CGBPBCDLOCM().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Duplicate Quest id found: "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void BOCAKAPOPKF()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EELFIIHLDCB()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.JHOGIKCHCGG().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.BMCNJOEAJBH().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Online Placeable Null"))
		{
			return;
		}
		val = waiter.npc.BFBEDHOHEPH().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("GO"))
		{
			val = waiter.npc.DKLMKBPEHAJ().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName(" "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void DFKNLGHIHMF()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.KOIKANGEOFD().SetTrigger(StaffBaseState.p_Mop);
		}
	}

	private void IKDFLKJFJHI()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CEHIMEJEOAE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.CCFDNFDEGIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.BFBEDHOHEPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.GDDFKLAEACF().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("UINextCategory"))
		{
			return;
		}
		val = waiter.npc.KOIKANGEOFD().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Xbox"))
		{
			val = waiter.npc.IBGCFFIFPBL().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("Player"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void IAMCMHGMEKP()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.BFBEDHOHEPH().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Pick up"))
		{
			return;
		}
		val = waiter.npc.BFBEDHOHEPH().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Checking SignedIn status..."))
		{
			val = waiter.npc.OJELDLIEDNI().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("[MapChest] ("))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void KKDGJFFLCJC()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.OHKDOEFGKFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.OHKDOEFGKFA().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void PAHHMMHEPFL()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.DKLMKBPEHAJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.DCMNEPOPBKA().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref val)).IsName("new save"))
		{
			return;
		}
		val = waiter.npc.GHNLDKEOCFA().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Player"))
		{
			val = waiter.npc.NDPNCJAOGNL().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("SalonDelTrono/PuddingTalk"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void HIIODHPOHCE()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.PABOGCMHLAN().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.OHKDOEFGKFA().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void LJJEPFCFGLJ()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.OHKDOEFGKFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.EPLLKPJIAFF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.GHNLDKEOCFA().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("itemsCrafted"))
		{
			return;
		}
		val = waiter.npc.BKPDJIDCAEO().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("UINextCategory"))
		{
			val = waiter.npc.PAMGMEAHNCI().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Waiting for guards to finish walking..."))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void DLGDMDGMNFJ()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BMMAALICCOL()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EMIHPALDHNL()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.NOJMFFFDAJA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.BIFKPMIMAEC().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.PABOGCMHLAN().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName("talentPickles"))
		{
			return;
		}
		val = waiter.npc.OJELDLIEDNI().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Left Stick Left"))
		{
			val = waiter.npc.DCMNEPOPBKA().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName(" "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void PJHHIEDCOCO()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FKKALIFGCHB()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void IJHPFNLGKAP()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.EPLLKPJIAFF().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void NKHCKAMNAFN()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.PNGIDKBCGCK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.PAMGMEAHNCI().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("Items/item_name_624"))
		{
			return;
		}
		val = waiter.npc.LNJABLMFNNE().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Jump"))
		{
			val = waiter.npc.JEFADBEHABI().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("ActionBar2"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void IBOPLDLKPAL()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void GLGKOJIOKJE()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.JHOGIKCHCGG().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.PNGIDKBCGCK().SetTrigger(StaffBaseState.p_Mop);
		}
	}

	private void BHBLLNOONFI()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FJLBNDCBDBP()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FGJNMMOFEHB()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DALEHFBAJEG()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CNNCAGEEFEI()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void OFLOLBIGFAN()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.IBGCFFIFPBL().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.BIFKPMIMAEC().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void FIAFHAPJMGL()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.NOJMFFFDAJA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.DHMMHOPEMLF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.IBGCFFIFPBL().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Items/item_name_728"))
		{
			return;
		}
		val = waiter.npc.FNGPCELFEHO().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Disabled"))
		{
			val = waiter.npc.CFIFGDBGLPH().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("eh"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void ELOBCIPNKGG()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.NOJMFFFDAJA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.PAMGMEAHNCI().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void AEBLENEONED()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.BIFKPMIMAEC().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.DCMNEPOPBKA().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName("MinProductValue"))
		{
			return;
		}
		val = waiter.npc.OJELDLIEDNI().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Keg empty"))
		{
			val = waiter.npc.EPLLKPJIAFF().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Listview"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void NKGHPMCJCLC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.BIFKPMIMAEC().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.DHMMHOPEMLF().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName("Current game version: "))
		{
			return;
		}
		val = waiter.npc.DHMMHOPEMLF().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Tutorial/BarnExitBarks_Holly"))
		{
			val = waiter.npc.DCMNEPOPBKA().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Interact"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void JGMLEJHGHKI()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.NOJMFFFDAJA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.DHMMHOPEMLF().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("00"))
		{
			return;
		}
		val = waiter.npc.BFBEDHOHEPH().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref val)).IsName(" x "))
		{
			val = waiter.npc.CGBPBCDLOCM().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("AnimatorParameterRequest"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void HNEFEHEKKMH()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.FNGPCELFEHO().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("ErrorCreateDefault"))
		{
			return;
		}
		val = waiter.npc.CCFDNFDEGIK().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("itemLager"))
		{
			val = waiter.npc.PNGIDKBCGCK().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Items/item_description_1092"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void GAILPDGPIHE()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.APBNLDNECGJ().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void CONHDEALNFC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.DKMPEPHLBGI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.PABOGCMHLAN().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.BMCNJOEAJBH().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Items/item_name_663"))
		{
			return;
		}
		val = waiter.npc.PNGIDKBCGCK().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("LE_21"))
		{
			val = waiter.npc.PABOGCMHLAN().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("qualityWater"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void OHKOHIJMPLE()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.JEFADBEHABI().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void HFFBKCCFAOE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.KOIKANGEOFD().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.GDDFKLAEACF().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref val)).IsName("ReceiveNPCDirection"))
		{
			return;
		}
		val = waiter.npc.CCFDNFDEGIK().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Statue1={0} | "))
		{
			val = waiter.npc.BIFKPMIMAEC().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("FerroProgress"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void DMKBOIDDGHO()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.PNGIDKBCGCK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.EPLLKPJIAFF().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void GNIKCPMGPHH()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.OAHOFAKKBBA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.OHKDOEFGKFA().SetTrigger(StaffBaseState.p_Mop);
		}
	}

	private void HBLLEFBCDAP()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.KOIKANGEOFD().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.LNJABLMFNNE().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.DKMPEPHLBGI().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName("Intro05"))
		{
			return;
		}
		val = waiter.npc.DKMPEPHLBGI().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Happy"))
		{
			val = waiter.npc.BMCNJOEAJBH().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("Currently crafting"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void BBBJBAOHKPP()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.NDPNCJAOGNL().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.GHNLDKEOCFA().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void NBDDLOKNGCL()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
			waiter.npc.DKMPEPHLBGI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.GHNLDKEOCFA().SetTrigger(StaffBaseState.p_Mop);
		}
	}

	private void LAOANFMBBFK()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.DKLMKBPEHAJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.CFIFGDBGLPH().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Dialogue System/Conversation/Gass_Quest/Entry/32/Dialogue Text"))
		{
			return;
		}
		val = waiter.npc.PNGIDKBCGCK().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Leave immediately"))
		{
			val = waiter.npc.JEFADBEHABI().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("bath travelling"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void GOGKOPPGMEF()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HBLJIMDNNEM()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.OHKDOEFGKFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.BIFKPMIMAEC().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.DCMNEPOPBKA().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("Sleep"))
		{
			return;
		}
		val = waiter.npc.EPLLKPJIAFF().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("HandUp"))
		{
			val = waiter.npc.GHNLDKEOCFA().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("Recipe without outputs! "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void HAMCAOPMNBN()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EEPKEKLJNDP()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.FJHKGBNBNKL.IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void IBBGLGPGFIC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.BKPDJIDCAEO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.DKLMKBPEHAJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.GDDFKLAEACF().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("0"))
		{
			return;
		}
		val = waiter.npc.PAMGMEAHNCI().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Dialogue System/Conversation/EnterTavernDrink/Entry/4/Dialogue Text"))
		{
			val = waiter.npc.LNJABLMFNNE().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("DecorationTile_21"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void ABJKJEEHOFP()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NOOBCABMHAO()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
			waiter.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.IMGOIBOHCIK().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void ABEDNKBFMDD()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.PABOGCMHLAN().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo currentState = waiter.npc.LNJABLMFNNE().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref currentState)).IsName("SendRoomRequest on Load"))
		{
			return;
		}
		currentState = waiter.npc.KOIKANGEOFD().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref currentState)).IsName(" "))
		{
			currentState = waiter.npc.FJHKGBNBNKL.GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("itemColiflower"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void LPLNIOOHCNA()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.DCMNEPOPBKA().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void PBFHFAFBKKA()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.BKPDJIDCAEO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.GHNLDKEOCFA().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void JJEDBGNFDMM()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.JHOGIKCHCGG().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void KBPEMNJPNOD()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KLHBFDLOCIH()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	[CompilerGenerated]
	private void PAKOILABNAM()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FFEDKPOGAFN()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.OAHOFAKKBBA().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Received pipe tile swap: indexA={0}, indexB={1}, mineLevel={2}"))
		{
			return;
		}
		val = waiter.npc.NOJMFFFDAJA().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("ReceiveBirdSlotFromContainer"))
		{
			val = waiter.npc.DHMMHOPEMLF().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName(" cannot be unloaded at this time. Either it's already unloaded or it's in the process of unloading."))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void NLDDGGDHGMN()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.JEFADBEHABI().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void EBDDLPJJMPK()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void OKOBLGLIIJM()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (!waiter.OEONGPFALKH.isActive)
		{
			waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
		else if (waiter.OEONGPFALKH.complete)
		{
			FALLFMOKLPA();
		}
	}

	private void OEIHOHHKLEB()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void GHNOMJIDFGC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.OAHOFAKKBBA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
		AnimatorStateInfo val = waiter.npc.EPLLKPJIAFF().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("ReceiveGetUp"))
		{
			return;
		}
		val = waiter.npc.OAHOFAKKBBA().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("Rest"))
		{
			val = waiter.npc.KOIKANGEOFD().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("MainProgress"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void JAMGBBCMMPO()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.PAMGMEAHNCI().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void HPOHKHNEBBB()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void OBLICPPMHMJ()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PPMGPNCOIFE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.KOIKANGEOFD().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Exit"))
		{
			return;
		}
		val = waiter.npc.CCFDNFDEGIK().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("popUpBuilding2"))
		{
			val = waiter.npc.GHNLDKEOCFA().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("itemWheatAle"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void FDKNIHIPEDH()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.ResetFloorDirt();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		waiter.OEONGPFALKH.IIMEFNIECLI();
	}

	private void NLEHCPLBEPM()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
			waiter.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.CGBPBCDLOCM().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void HKINGBMHJEE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.CCFDNFDEGIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.DKLMKBPEHAJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.CGBPBCDLOCM().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName("ReceivePlayerInventory"))
		{
			return;
		}
		val = waiter.npc.NDPNCJAOGNL().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Player2"))
		{
			val = waiter.npc.NOJMFFFDAJA().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName(" : "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void FFFCFIOKCCB()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.DHMMHOPEMLF().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("\nRecipe not found.\n"))
		{
			return;
		}
		val = waiter.npc.LNJABLMFNNE().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Run"))
		{
			val = waiter.npc.IMGOIBOHCIK().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("DelayStartConversation "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void CCOGJFPDBIA()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JGLIBANKFCK()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.APBNLDNECGJ().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void KNLNHLHBDHK()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.PAMGMEAHNCI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo currentState = waiter.npc.OAHOFAKKBBA().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref currentState)).IsName("UI"))
		{
			return;
		}
		currentState = waiter.npc.EPLLKPJIAFF().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("VerticalMove"))
		{
			currentState = waiter.npc.GHNLDKEOCFA().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("LE_10"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void AGCDLFPNHDN()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.LNJABLMFNNE().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void PIOOMPINOAG()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.BMCNJOEAJBH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.IMGOIBOHCIK().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void EOPAEDPDMGI()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CFIKIFIDDBB()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.CCFDNFDEGIK().IBPGIGLEEFK(0);
		if (((AnimatorStateInfo)(ref val)).IsName(""))
		{
			return;
		}
		val = waiter.npc.LNJABLMFNNE().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("/ExtraSettings.sd"))
		{
			val = waiter.npc.GDDFKLAEACF().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("_Animation"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void LLODGJICFBE()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void AMILFCKLOND()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.EPLLKPJIAFF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.DCMNEPOPBKA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo currentState = waiter.npc.CGBPBCDLOCM().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref currentState)).IsName("Information"))
		{
			return;
		}
		currentState = waiter.npc.CGBPBCDLOCM().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("Happy"))
		{
			currentState = waiter.npc.DKLMKBPEHAJ().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("Guards finished walking."))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void NJEELDFEEEN()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void AFALIHEINIA()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void ACOMLNAAEAC()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.BGPFFODAEJJ(), waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.KOIKANGEOFD().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.IMGOIBOHCIK().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref val)).IsName("Exit build mode"))
		{
			return;
		}
		val = waiter.npc.FJHKGBNBNKL.IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName(""))
		{
			val = waiter.npc.BFBEDHOHEPH().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName(") "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void GCPPEAMDPEL()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		waiter.waiterState = WaiterState.CleaningFloorDirt;
		if ((Object)(object)waiter.DDJECCPKNKG == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		waiter.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)waiter.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
			{
				CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
				waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
				waiter.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
			}
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
			{
				waiter.notReachableDirts.Add(waiter.DDJECCPKNKG);
			}
			waiter.ResetFloorDirt();
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		});
		waiter.OEONGPFALKH.PEHELKCIECB();
	}

	private void CAEBIJFCHPE()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.DHMMHOPEMLF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo val = waiter.npc.NDPNCJAOGNL().IBPGIGLEEFK(1);
		if (((AnimatorStateInfo)(ref val)).IsName("MainProgress"))
		{
			return;
		}
		val = waiter.npc.NOJMFFFDAJA().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Not enough ingredients"))
		{
			val = waiter.npc.CGBPBCDLOCM().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("<sprite name=\"woodIcon\"><color=#8E1818>"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void ADCJCOIPANH()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BLKMBCBMKDN()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.DCMNEPOPBKA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.GHNLDKEOCFA().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void HFLKMPBGNGE()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.CFIFGDBGLPH().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void CDEDAPNDCPG()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BIANPAFCEKM()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.PAMGMEAHNCI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.PAMGMEAHNCI().SetTrigger(StaffBaseState.p_Mop);
		}
	}

	private void LELJIBDMIEC()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HFNILMKAKLM()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.LNJABLMFNNE().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.CGBPBCDLOCM().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void KCJBGPMCJOA()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.GDDFKLAEACF().GetCurrentState(0);
		if (((AnimatorStateInfo)(ref val)).IsName("- "))
		{
			return;
		}
		val = waiter.npc.BKPDJIDCAEO().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("ReceiveCollectItems"))
		{
			val = waiter.npc.NDPNCJAOGNL().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("' no tiene el booleano rotated marcado"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void IPCLKGNLACP()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.PABOGCMHLAN().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			}
			return;
		}
		waiter.npc.DKMPEPHLBGI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
		AnimatorStateInfo val = waiter.npc.FJHKGBNBNKL.GetCurrentState(1);
		if (((AnimatorStateInfo)(ref val)).IsName("tutorialPopUp77"))
		{
			return;
		}
		val = waiter.npc.GDDFKLAEACF().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Waking up in: "))
		{
			val = waiter.npc.CGBPBCDLOCM().IBPGIGLEEFK(1);
			if (!((AnimatorStateInfo)(ref val)).IsName(" "))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void LANPDPAEBLG()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
			waiter.npc.OHKDOEFGKFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.PAMGMEAHNCI().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void DALEMNHMNMG()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NBBMKCLEPAC()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JJCGCICJHHJ()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			waiter.npc.GDDFKLAEACF().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void NJBCMNBPDHB()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ADGFCNENBMO();
				waiter.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.OJELDLIEDNI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo currentState = waiter.npc.KOIKANGEOFD().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref currentState)).IsName("Disable Bob"))
		{
			return;
		}
		currentState = waiter.npc.DCMNEPOPBKA().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("Drunk"))
		{
			currentState = waiter.npc.CGBPBCDLOCM().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("LE_10"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void IIEFBHMNHOF()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KILNHOCAJHO()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.NDPNCJAOGNL().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			return;
		}
		waiter.npc.JHOGIKCHCGG().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo currentState = waiter.npc.CFIFGDBGLPH().GetCurrentState(1);
		if (((AnimatorStateInfo)(ref currentState)).IsName("MainProgress"))
		{
			return;
		}
		currentState = waiter.npc.JEFADBEHABI().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("Tutorial/T122/Dialogue3"))
		{
			currentState = waiter.npc.BKPDJIDCAEO().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("start ninja"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void FALLFMOKLPA()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			if (waiter.CleanFloorDirt(waiter.DDJECCPKNKG, waiter.cleaningFloorDirtSpeed))
			{
				waiter.ResetFloorDirt();
				waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo currentState = waiter.npc.FJHKGBNBNKL.GetCurrentState(0);
		if (((AnimatorStateInfo)(ref currentState)).IsName("MopUp"))
		{
			return;
		}
		currentState = waiter.npc.FJHKGBNBNKL.GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("MopRight"))
		{
			currentState = waiter.npc.FJHKGBNBNKL.GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("MopDown"))
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void BHKEKABFOOP()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.OJELDLIEDNI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.KOIKANGEOFD().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void NAIJLPCAPKK()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
			waiter.npc.KOIKANGEOFD().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.CFIFGDBGLPH().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void IFMAJLPPADF()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
			waiter.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.DKMPEPHLBGI().SetTrigger(StaffBaseState.p_Mop);
		}
	}

	private void PMMBBDBMDAD()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
			waiter.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			waiter.npc.KOIKANGEOFD().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
	}

	private void MBOCCJJHDBH()
	{
		if ((Object)(object)waiter.BGPFFODAEJJ() != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ResetFloorDirt();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void GLEPMCIPFFH()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
			waiter.npc.IBGCFFIFPBL().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			waiter.npc.DKLMKBPEHAJ().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}

	private void BHLCGNNCBCA()
	{
		if (Object.op_Implicit((Object)(object)waiter.DDJECCPKNKG))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			waiter.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.BMCNJOEAJBH().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
	}

	private void FBLPJKCPKOF()
	{
		if ((Object)(object)waiter.DDJECCPKNKG != (Object)null)
		{
			waiter.notReachableDirts.Add(waiter.BGPFFODAEJJ());
		}
		waiter.ADGFCNENBMO();
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KBBPDMMMPLB()
	{
		if (Object.op_Implicit((Object)(object)waiter.BGPFFODAEJJ()))
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
			waiter.npc.CCFDNFDEGIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			waiter.npc.NOJMFFFDAJA().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
	}
}
