using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeperCleaningFloorDirt : HouseKeeperBaseState
{
	private bool cleaningFloorDirt;

	private void HPPJNPCEKDG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JBFMONMAMBD));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IDFBFKNFHCC));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void LEHKBELOFBO()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void IPJHPAMNNNK()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.OLHBCAHONME().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.OJELDLIEDNI().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = true;
	}

	private void BIIIKCFHMNH()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KDOABPOPCOB()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HKKPKEADCEJ()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CKGFBPOHICJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
				{
					houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
					houseKeeper.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
				}
				cleaningFloorDirt = true;
			});
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
				{
					houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
				}
				houseKeeper.ResetFloorDirt();
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			});
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void COBKONNKFMJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.npc.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KKBCCANMMPL));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HHPODKNPGDM));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void LNOFJDEALGJ()
	{
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JGPKKGFKMEE()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KHHPFGGLOJA()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FKPAEECCKBF));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GHHNJIKOLMA));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void GNPAHFEIBLM()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.PAMGMEAHNCI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.OJELDLIEDNI().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void OHIAGJMALCE()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HHPODKNPGDM()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NFHDKFIHENB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AEHJEIEPMNO));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CEDNGFDFGGF));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void LIALHAAJMBG()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EGHIAGFPDJE()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AACLKIJKIAN));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MAJHGHJPNGM));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void BJJINNDKBKP()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.npc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ANDLKPDOMDK));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BIIIKCFHMNH));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void BKHABKBLDGN()
	{
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BELFAACODIG()
	{
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DAPEONLDJNJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IPJHPAMNNNK));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MONNFKEAPOD));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void JIMIKDENMNH()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.BKPDJIDCAEO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.GHNLDKEOCFA().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = true;
	}

	private void GHHNJIKOLMA()
	{
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void AEHJEIEPMNO()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.EPLLKPJIAFF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.DKLMKBPEHAJ().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void JEOEFKJOJIC()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KKBCCANMMPL));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PMGCJPKGFFE));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void FKPAEECCKBF()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.GDDFKLAEACF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.BMCNJOEAJBH().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = true;
	}

	private void LBGBCEKCBJG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.GINPKMBGOFN(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FKPAEECCKBF));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NHBCEOFANGM));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void OBLKCKNLCCB()
	{
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	[CompilerGenerated]
	private void FNPDDDGJJOO()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = true;
	}

	private void MONNFKEAPOD()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KANJNDJKMPC()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.HELOLJBENMK(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IGBBCLOCHLA));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
				{
					houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
				}
				houseKeeper.ResetFloorDirt();
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			});
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void EKDHLCOOINO()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.BMCNJOEAJBH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.JEFADBEHABI().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void GEJJDBHGOIF()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IGBBCLOCHLA));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MONNFKEAPOD));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void MKEKNHPONBA()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.OJELDLIEDNI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.CCFDNFDEGIK().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void ICEICLKJDNO()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.PABOGCMHLAN().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.NDPNCJAOGNL().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = true;
	}

	private void INBHJEGDBED()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.BMCNJOEAJBH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.BKPDJIDCAEO().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void EMBOOKFBMAK()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PBBOJJEAODL));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OBLKCKNLCCB));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void IPCKFEBEJME()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.BIFKPMIMAEC().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.APBNLDNECGJ().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = true;
	}

	private void ANDLKPDOMDK()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.KOIKANGEOFD().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.GHNLDKEOCFA().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void ABLLPILEIJH()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.GINPKMBGOFN(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(INBHJEGDBED));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KDOABPOPCOB));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void MNEJIKGPKJG()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.DHMMHOPEMLF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.NOJMFFFDAJA().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void IDAIFOFMLBD()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.OAHOFAKKBBA().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = true;
	}

	private void HKGPKFEBAGB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.npc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MAEGIKPBBMD));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AHOEOPIOPFH));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void OPHILFHBPLG()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.CFIFGDBGLPH().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void LPOHCOODPOL()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HPLMNHFEHOI()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void LMBDKECCMAM()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JFLFPIOOHGP()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CEDNGFDFGGF()
	{
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JHFBAEIHCJD()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void MAEGIKPBBMD()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.APBNLDNECGJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.GHNLDKEOCFA().SetTrigger(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void FPMNJJFEIDB()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JNMFDDEKPAL()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ICEICLKJDNO));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OBLKCKNLCCB));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void MBGCLPKKKEB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GNPAHFEIBLM));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADDBAOLLCMF));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void CAKDDOLKLJN()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.EPLLKPJIAFF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.BIFKPMIMAEC().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		cleaningFloorDirt = false;
		houseKeeper.houseKeeperState = HouseKeeperState.CleaningFloorDirt;
		CKGFBPOHICJ();
	}

	private void FOPDPFELHOE()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FFDAHCIJAED()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.PNGIDKBCGCK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.GHNLDKEOCFA().SetTrigger(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = true;
	}

	private void AACLKIJKIAN()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.IBGCFFIFPBL().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.GDDFKLAEACF().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void LPJGLLGBHHO()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EKDHLCOOINO));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PNLFCCMCPEE));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void CKPAAJNPEBE()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.OHKDOEFGKFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.EPLLKPJIAFF().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void NKBOLEKOKBN()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.npc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FKPAEECCKBF));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MONNFKEAPOD));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void MJFEKKPDOIP()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.BMCNJOEAJBH().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void PPOAGJKKJFL()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.npc.walkTo.JDHMPOJKOLF(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JIMIKDENMNH));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HFILEHEAABP));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void HNMNNACPJGF()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.GINPKMBGOFN(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GNPAHFEIBLM));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BELFAACODIG));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void ILCCCLALKKA()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.JDHMPOJKOLF(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FFDAHCIJAED));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IDFBFKNFHCC));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void FKDKOOCIEFG()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.FNGPCELFEHO().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.FNGPCELFEHO().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = true;
	}

	private void NBMDEHPAJEB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.JJDCANFBFMK(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ICEICLKJDNO));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CEDNGFDFGGF));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void KJMJKJADFBE()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void ADCNNLHBKCI()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.CCFDNFDEGIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.PAMGMEAHNCI().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = true;
	}

	private void CHKMJBPLGDP()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.GINPKMBGOFN(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CKPAAJNPEBE));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HKKPKEADCEJ));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void GBEHKPCJFHC()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.KBEENHPEOAB(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AEHJEIEPMNO));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LEHKBELOFBO));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void AOHKMFGAJLB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MJFEKKPDOIP));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OHIAGJMALCE));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void EOHLFFDODBK()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PBBOJJEAODL()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.OHKDOEFGKFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.PNGIDKBCGCK().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void GJHLKAOPCIO()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DLNKINAFEFK()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GNPAHFEIBLM));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADDBAOLLCMF));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void PNNNCJCKJKI()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void AHOEOPIOPFH()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HENHAJABGGO()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KMNBFJMFELI()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.GINPKMBGOFN(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MNEJIKGPKJG));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DCNDOOHLKMJ));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void FPMINLCPMJB()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NNJPNLOHLBJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
				{
					houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
					houseKeeper.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
				}
				cleaningFloorDirt = true;
			});
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HFILEHEAABP));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void AHFLFFCPLGD()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.NOJMFFFDAJA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.JEFADBEHABI().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void LCMLAIPMPEF()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JIMIKDENMNH));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GMMLJHOJNFC));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.npc.walkTo.IIMEFNIECLI();
	}

	private void ADDBAOLLCMF()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DHDKJNLDCDF()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void ICAMHNJFOCF()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FKDKOOCIEFG));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GHHNJIKOLMA));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void KFJKEJIIMJG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FKDKOOCIEFG));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JGPKKGFKMEE));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void EBLHBCAGFOK()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OPHILFHBPLG));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KJMJKJADFBE));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void DGKCCMHPMJP()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.DCMNEPOPBKA().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.ResetFloorDirt();
		houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
	}

	private void KFFIFIPGFIO()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PNLFCCMCPEE()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JBFMONMAMBD()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.IBGCFFIFPBL().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.GDDFKLAEACF().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	[CompilerGenerated]
	private void ABBKDJHAJBK()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PMGCJPKGFFE()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void LDCOPKIIEIC()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CKPJMDABGEH()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.KBEENHPEOAB(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CKPAAJNPEBE));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DHDKJNLDCDF));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void BIMMNKPONMN()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CKPAAJNPEBE));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MONNFKEAPOD));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void FJHDOFAJLKE()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.npc.walkTo.JDHMPOJKOLF(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JBFMONMAMBD));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BIIIKCFHMNH));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void IOGPNKMEPHD()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.npc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EKDHLCOOINO));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BELFAACODIG));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void NHBCEOFANGM()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void IGBBCLOCHLA()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.GDDFKLAEACF().SetTrigger(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = true;
	}

	private void KEDABHMFIDJ()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.BMCNJOEAJBH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.BMCNJOEAJBH().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = true;
	}

	private void HFILEHEAABP()
	{
		if ((Object)(object)houseKeeper.KMBIMIINPLF() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DCNDOOHLKMJ()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.KDALMEOFMII();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FHFBCFGBNFE()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.PAMGMEAHNCI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.BKPDJIDCAEO().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void PHNPMPJNDJG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.npc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position));
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MNEJIKGPKJG));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FOPDPFELHOE));
			houseKeeper.npc.walkTo.NOFKEMGPFEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void LCHEMOMLEAE()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.DKLMKBPEHAJ().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.IBGCFFIFPBL().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = false;
	}

	private void NGAHFBFMLFE()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AACLKIJKIAN));
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FOPDPFELHOE));
			houseKeeper.npc.walkTo.EHDKLBLKBEO();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (!cleaningFloorDirt)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			if (houseKeeper.CleanFloorDirt(houseKeeper.DDJECCPKNKG, houseKeeper.cleaningFloorDirtSpeed))
			{
				houseKeeper.ResetFloorDirt();
				houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			}
			return;
		}
		houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
		AnimatorStateInfo currentState = houseKeeper.npc.FJHKGBNBNKL.GetCurrentState(0);
		if (((AnimatorStateInfo)(ref currentState)).IsName("MopUp"))
		{
			return;
		}
		currentState = houseKeeper.npc.FJHKGBNBNKL.GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("MopRight"))
		{
			currentState = houseKeeper.npc.FJHKGBNBNKL.GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("MopDown"))
			{
				houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private void GMMLJHOJNFC()
	{
		if ((Object)(object)houseKeeper.OOOCIMIMIIH() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HAAKHNLACAL()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.DHMMHOPEMLF().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.JEFADBEHABI().SetTrigger(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		cleaningFloorDirt = true;
	}

	private void IDFBFKNFHCC()
	{
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		}
		houseKeeper.ResetFloorDirt();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FKHHBPIEDFI()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.APBNLDNECGJ().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void MAJHGHJPNGM()
	{
		if ((Object)(object)houseKeeper.DDJECCPKNKG != (Object)null)
		{
			houseKeeper.notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		}
		houseKeeper.MNENEHEHBJD();
		houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KKBCCANMMPL()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.IMGOIBOHCIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.KOIKANGEOFD().SetTrigger(StaffBaseState.p_Mop);
		}
		cleaningFloorDirt = false;
	}

	private void AEJBAOADCJP()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.MKCBJAGOKLE() != (Object)null)
		{
			houseKeeper.npc.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = houseKeeper.npc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
				{
					houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
					houseKeeper.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
				}
				cleaningFloorDirt = true;
			});
			NPCWalkTo walkTo2 = houseKeeper.npc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OHIAGJMALCE));
			houseKeeper.npc.walkTo.PEHELKCIECB();
		}
		else
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}
}
