using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BouncerBringBackWorkers : BouncerBaseState
{
	private void PABMIJLJMOP()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false, HALNIEBONKH: true);
		bouncer.HMHMLMNDHKM();
	}

	private void CHKAHIKNHBN()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.GHDMBFOAAHK(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(223f, 341f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EEHOJFKPHPF));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JHEAMICKHOO));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void FCNOKOBFHLE()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.DelayGoToWork();
	}

	private void NGMAFPKDCCG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DKDELFGCJBM()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (bouncer.workerBringingBack is Barworker { barworkerState: not BarworkerState.AvoidingWork })
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
		else if (bouncer.workerBringingBack is Waiter { waiterState: not WaiterState.AvoidingWork })
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
		else if (bouncer.workerBringingBack is HouseKeeper { houseKeeperState: not HouseKeeperState.AvoidingWork })
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void MIJKKHEHJLI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.KBEENHPEOAB(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(138f, 1836f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OMPNDDNKLCI));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MHDNMFMLNJM));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void LIHNOKAOGKL()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.DelayGoToWork();
	}

	private void AANBAPKFHLP()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KDMFGHBEEMF()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BOBGOHLKJKK()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}

	private void BIFLFMICNFK()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DCOCOIONHPG()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.HMHMLMNDHKM();
	}

	private void DLHLLDIJODK()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.DHFPOCOEONG(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(250f, 1053f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LGAOLKHKLNC));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ALIIELGIMND));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void LCFGGBIJCOA()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.DHFPOCOEONG(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(661f, 1413f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LIHNOKAOGKL));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LEGMKGDAEGG));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void PAHLGILFBPI()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.DelayGoToWork();
	}

	private void CFONPMDLBAG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void LGAOLKHKLNC()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}

	private void OKBNLHIFEHI()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.HMHMLMNDHKM();
	}

	private void DDCPKBIDFOG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NIPIAKFBKCB()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}

	private void AIHPEDGNHDM()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.CGFMBJFGLAG(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(945f, 1341f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BOBGOHLKJKK));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CNOOEKEEHBJ));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void JLLEIMFMNOG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JIGMDCEFLHM()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void LEGMKGDAEGG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HAAJHMJNECC()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.BDIKOLNFKGD(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1050f, 1429f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DCOCOIONHPG));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ALIIELGIMND));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void DJGINOEKHLA()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CHJBNPFPIKP()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}

	private void JHEAMICKHOO()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JCOMJIANEFH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HCHDDHFCOAP()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(0f, -0.5f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
			bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
			bouncer.DelayGoToWork();
		});
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		});
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void KIKBBGFPGOP()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.DelayGoToWork();
	}

	private void AFIFFKHBDNM()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	[CompilerGenerated]
	private void ICMJAPLONAM()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.DelayGoToWork();
	}

	private void EKOKMHLOOFI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.DBHOIIIHIIM(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(993f, 548f)), AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KIKBBGFPGOP));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JLLEIMFMNOG));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void HPFABMLNBDB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.GHDMBFOAAHK(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1577f, 656f)), AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DLCPONIBGKN));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AANKJGILLEB));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void AKIIILJEJNB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.CGFMBJFGLAG(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1464f, 574f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IIHCNAFLGPJ));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JCOMJIANEFH));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void ADBDBCNJLHD()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.HMHMLMNDHKM();
	}

	private void KMOFPPJCGJK()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Up);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.DelayGoToWork();
	}

	private void EGAOFOJFEEA()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.HMHMLMNDHKM();
	}

	private void OMMCPCMFBPF()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}

	private void KKCICEHCBHN()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.HMHMLMNDHKM();
	}

	private void PCDNEPOMEGE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.GDGGABHLNOH(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1550f, 792f)), AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OKBNLHIFEHI));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DKDELFGCJBM));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void GDIEHGAMOHL()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.DelayGoToWork();
	}

	private void IIHCNAFLGPJ()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Up);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.DelayGoToWork();
	}

	private void BPIIMCGDBBM()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.GHDMBFOAAHK(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1479f, 259f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OKBNLHIFEHI));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BIFLFMICNFK));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void DBMNKGNPHMK()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CNOOEKEEHBJ()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void GMPCFGHGIDI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.OGLJDLEGJAA(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1549f, 1286f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DLCPONIBGKN));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		});
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void NOAMMFPKIPJ()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.JJDCANFBFMK(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(478f, 1880f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OKBNLHIFEHI));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JHEAMICKHOO));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void JADPPCBNGHM()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.HMHMLMNDHKM();
	}

	private void MHDNMFMLNJM()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	[CompilerGenerated]
	private void MLKELBNHAMF()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void ALIIELGIMND()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KNKEMEDPNMB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.BDIKOLNFKGD(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1462f, 983f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(APFMAMIAIEN));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AANBAPKFHLP));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void LDLEJEOCNLP()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EOFLOIBNJGA()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.EJPGFOEDPBG(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1478f, 75f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KIKBBGFPGOP));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JIGMDCEFLHM));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void PADBFGHCIME()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.JJDCANFBFMK(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(713f, 1179f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EGAOFOJFEEA));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CNOOEKEEHBJ));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void HBIKAEEJDNP()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.KBEENHPEOAB(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(994f, 1078f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NLMEJPCGHIA));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AANKJGILLEB));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void NDDMPFGGFDO()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void GNKEHCEKCLO()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BFHPJCDLHKG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1888f, 705f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ADBDBCNJLHD));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MHDNMFMLNJM));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void JLAMBPECFON()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}

	private void APFMAMIAIEN()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.DelayGoToWork();
	}

	private void BENLLAACKKL()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Down);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.HMHMLMNDHKM();
	}

	private void DKLGHEELCJB()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.JJDCANFBFMK(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1154f, 102f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DCOCOIONHPG));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NGMAFPKDCCG));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void OAGELAIIAJJ()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EEGBFDFLDCJ()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void OMPNDDNKLCI()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.HMHMLMNDHKM();
	}

	private void EEHOJFKPHPF()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Up);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.HMHMLMNDHKM();
	}

	private void MIHHCCOLOFM()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.DelayGoToWork();
	}

	private void NLMEJPCGHIA()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Up;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.HMHMLMNDHKM();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.calm = false;
		bouncer.bouncerState = BouncerState.BringBackWorkers;
		if ((Object)(object)bouncer.workerBringingBack == (Object)null)
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
		else
		{
			HCHDDHFCOAP();
		}
	}

	private void AANKJGILLEB()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.workerBringingBack = null;
	}

	private void NFHBILOAAAF()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		bouncer.OEONGPFALKH.IIMEFNIECLI();
	}

	private void JBMBHPOMFEM()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.HELOLJBENMK(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1034f, 944f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ADBDBCNJLHD));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EEGBFDFLDCJ));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void FBONIBLAILM()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true);
		bouncer.HMHMLMNDHKM();
	}

	private void JLEMNKGGANG()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.DHFPOCOEONG(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(459f, 614f)), AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FCNOKOBFHLE));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GNKEHCEKCLO));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void MBOHHEKIEBI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.KBEENHPEOAB(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(395f, 248f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MIHHCCOLOFM));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DDCPKBIDFOG));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void KNLJLNLBIKO()
	{
		bouncer.characterAnimation.FCGBJEIIMBC = Direction.Down;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		bouncer.DelayGoToWork();
	}

	private void KCFPANIDIDA()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Up);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}

	private void OKLDBHLDLNM()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void LAJPOFMLPOC()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.EJPGFOEDPBG(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(381f, 1029f)), AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OMPNDDNKLCI));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KDMFGHBEEMF));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void EAJGDOOBNFO()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.GLHBJNDMIDC(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1272f, 780f)));
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PABMIJLJMOP));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DJGINOEKHLA));
		bouncer.OEONGPFALKH.NOFKEMGPFEO();
	}

	private void ICBOJCEIPFJ()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.GDGGABHLNOH(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(1414f, 561f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PABMIJLJMOP));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GNKEHCEKCLO));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void DOMMNLAACGD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.OGLJDLEGJAA(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(227f, 1753f)), AHDHLIECIGH: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BOBGOHLKJKK));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OAGELAIIAJJ));
		bouncer.OEONGPFALKH.PEHELKCIECB();
	}

	private void FEJHMMEOPCG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HEJNHHOLOHD()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		bouncer.OEONGPFALKH.JDHMPOJKOLF(Vector2.op_Implicit(((Component)bouncer.workerBringingBack).transform.position + new Vector3(923f, 843f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = bouncer.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OKBNLHIFEHI));
		NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JLLEIMFMNOG));
		bouncer.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void DLCPONIBGKN()
	{
		bouncer.characterAnimation.NCAJNNHBHJM(Direction.Up);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: true, HALNIEBONKH: true);
		bouncer.DelayGoToWork();
	}
}
