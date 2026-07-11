using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BouncerCalmRowdyCustomer : BouncerBaseState
{
	private Vector2 position;

	private void LCFGGBIJCOA()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.JDHMPOJKOLF(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CPHDJCOFLKM));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IEIOKEMFHNE));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void PMENOFBEENL()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.OGLJDLEGJAA(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JHBCBJOIDBB));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BJKMKAFIJII));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void DJPBCAJKGMA()
	{
		bouncer.DelayCalm();
	}

	private void DHLDDMHPBOG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CGNIAKONKKA()
	{
		bouncer.NCOGIKKJNDJ();
	}

	private void BLIBGOILDHH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PCLCCFEPIJD()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.GLHBJNDMIDC(position, AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NGBDLGJOBOL));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MLLADJMKBIE));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void OBJJMGLGBNJ()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.JDHMPOJKOLF(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KMLEAPANEHB));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PAFMBICKLHK));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void JBMBHPOMFEM()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.FNNPPBDFBCI(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CPHDJCOFLKM));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HFLPCNEALCG));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void MLLADJMKBIE()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CPHDJCOFLKM()
	{
		bouncer.LPHNBEHACJI();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.calm = false;
		bouncer.bouncerState = BouncerState.HeadingToRowdyCustomer;
		if ((Object)(object)bouncer.customer == (Object)null)
		{
			bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
		else
		{
			HCHDDHFCOAP();
		}
	}

	private void MAIHPMDBGLC()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DFOLONMEHFH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CLJBKOGFEEC()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.DBHOIIIHIIM(position, AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JHBCBJOIDBB));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DHLDDMHPBOG));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void JOJAHDCJBCL()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.BDIKOLNFKGD(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KMLABHEMMHH));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BLIBGOILDHH));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void AIHPEDGNHDM()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.JDHMPOJKOLF(position, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ADGALKKJADM));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HLKFHINFFBP));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void LAJPOFMLPOC()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.EJPGFOEDPBG(position, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KMLABHEMMHH));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		});
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void PCBJIOGFAAN()
	{
		bouncer.DelayCalm();
	}

	private void MJBOICNHPFG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	[CompilerGenerated]
	private void GFMCHJNMELP()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BGPGDBBLKLP()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PICKONBNLEG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JIFKJIEDPFJ()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void IDDCPIGOAIJ()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DMDGFHBKFPL()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.DHFPOCOEONG(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DJPBCAJKGMA));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JIFKJIEDPFJ));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void OKKEBEEDGOF()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DHKJCGAOLFH()
	{
		bouncer.NCOGIKKJNDJ();
	}

	private void FIABAPLCEPH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JFMGLBGDPBO()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BJKMKAFIJII()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PODIHDCCKIE()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BPIIMCGDBBM()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.FNNPPBDFBCI(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BGCEAGOHLBH));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PAFMBICKLHK));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void PLEFHMMHFLF()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.KBEENHPEOAB(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BGCEAGOHLBH));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HKJMKCNINPO));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void KJOPMCGMDOF()
	{
		bouncer.LPHNBEHACJI();
	}

	private void PAFMBICKLHK()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void OJJNCMAJKHK()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void ADGALKKJADM()
	{
		bouncer.AIFLHAHBFNK();
	}

	private void HKJMKCNINPO()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NOAMMFPKIPJ()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.JDHMPOJKOLF(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JHBCBJOIDBB));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MLLADJMKBIE));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void LMIFMGBELBP()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.DBHOIIIHIIM(position, AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NGBDLGJOBOL));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LPBADPCFMJL));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void HCHDDHFCOAP()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.FNNPPBDFBCI(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			bouncer.DelayCalm();
		});
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		});
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		bouncer.OEONGPFALKH.IIMEFNIECLI();
	}

	private void JHBCBJOIDBB()
	{
		bouncer.NCOGIKKJNDJ();
	}

	private void KMLEAPANEHB()
	{
		bouncer.LPHNBEHACJI();
	}

	private void DGIAGINNJBE()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.BDIKOLNFKGD(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KJOPMCGMDOF));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NHFMIJEPJGL));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void IEIOKEMFHNE()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KMIKMLGNIFI()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.JDHMPOJKOLF(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DHKJCGAOLFH));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PAFMBICKLHK));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void ONKLDDNGEMB()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HPFABMLNBDB()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.GHDMBFOAAHK(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			bouncer.DelayCalm();
		});
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JFMGLBGDPBO));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void BNJGHNEJKHM()
	{
		bouncer.DelayCalm();
	}

	private void EDKDLNCGMEO()
	{
		bouncer.AIFLHAHBFNK();
	}

	[CompilerGenerated]
	private void GABOACANHPG()
	{
		bouncer.DelayCalm();
	}

	private void MAENLHFMLKE()
	{
		bouncer.AIFLHAHBFNK();
	}

	private void HLKFHINFFBP()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JMCIDBDEPNL()
	{
		bouncer.NCOGIKKJNDJ();
	}

	private void BGBADDBIBLA()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void LFPPIHHNBFC()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NGBDLGJOBOL()
	{
		bouncer.NCOGIKKJNDJ();
	}

	private void ELCLDFFAMMN()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.FNNPPBDFBCI(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PCBJIOGFAAN));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MAIHPMDBGLC));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void ACEHHPOKBHA()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.CGFMBJFGLAG(position, AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BNJGHNEJKHM));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BNDPKCAFALN));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void BNDPKCAFALN()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HBIKAEEJDNP()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.GHDMBFOAAHK(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BNJGHNEJKHM));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BNDPKCAFALN));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void FPOGHKAPIFB()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NHFMIJEPJGL()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BGCEAGOHLBH()
	{
		bouncer.LPHNBEHACJI();
	}

	private void KMLABHEMMHH()
	{
		bouncer.NCOGIKKJNDJ();
	}

	private void GKCMGGLOFKC()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.FNNPPBDFBCI(position, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PCBJIOGFAAN));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BGPGDBBLKLP));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void LKHOCPFBKNM()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.GLHBJNDMIDC(position, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ADGALKKJADM));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PODIHDCCKIE));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void HFLPCNEALCG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BLJOMMFJIEI()
	{
		bouncer.LPHNBEHACJI();
	}

	private void KFMGIFDLMMK()
	{
		bouncer.DelayCalm();
	}

	private void PCDNEPOMEGE()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.CGFMBJFGLAG(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MAENLHFMLKE));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DFOLONMEHFH));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
		else if (bouncer.customer.customerState == CustomerState.BeingANuisance)
		{
			bouncer.behaviour.SetTrigger(StaffBaseState.p_KickRowdyCustomer);
		}
		else if (bouncer.calm)
		{
			bouncer.DelayTrigger(StaffBaseState.p_Waiting, 1f);
			bouncer.calm = false;
		}
	}

	private void KPAPHBGFCKH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EMJAFIPDLHN()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.DHFPOCOEONG(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BGCEAGOHLBH));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FPOGHKAPIFB));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void NPCPBAHOJLL()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JPEPDAKKNDK()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NLCBEJLDEDI()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void MIJKKHEHJLI()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)bouncer.customer.npc.seat != (Object)null)
		{
			position = Utils.MJEACANINDN(bouncer.customer.npc.seat.entryPosition);
		}
		else
		{
			position = Vector2.op_Implicit(Utils.MJEACANINDN(((Component)bouncer.customer).transform.position));
		}
		bouncer.OEONGPFALKH.EJPGFOEDPBG(position);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KJOPMCGMDOF));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JIFKJIEDPFJ));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void LPBADPCFMJL()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}
}
