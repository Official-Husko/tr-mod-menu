using System;
using UnityEngine;

public class WalkToState
{
	private bool LCHBIEAICAK;

	public DialogueNPCBase npc;

	public void AFKGJCIANOF()
	{
		if (!LCHBIEAICAK && npc.walkTo != null && npc.walkTo.GOACFCOOJLK(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = false;
		}
	}

	public void GFABFDHPJOK()
	{
		if (!LCHBIEAICAK && npc.walkTo != null && npc.walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = true;
		}
	}

	private void PDOBHPLPKHG()
	{
		if (npc.endWalkDirection != Direction.Diagonal)
		{
			npc.animationBase.SetDirection(npc.endWalkDirection);
			npc.endWalkDirection = Direction.Diagonal;
		}
		if (npc.disable)
		{
			npc.ChangeState(DialogueNPCBase.p_Inactive);
			npc.disable = false;
		}
		else
		{
			npc.ChangeState(DialogueNPCBase.p_Waiting);
		}
		if (!string.IsNullOrEmpty(npc.endTriggerAnimation))
		{
			npc.animationBase.SetTrigger(npc.endTriggerAnimation);
			npc.endTriggerAnimation = null;
		}
		npc.WalkToCompleted();
		if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)npc.onlineNPC))
		{
			npc.onlineNPC.SendActorPosition();
			npc.onlineNPC.SendNPCDirection();
		}
	}

	public void PCADHOMGHND(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		BFGPMEKLDDB();
	}

	private void MFELPPLNNIN()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = true;
		npc.animationBase.IGONGEODOFP = false;
		npc.walkTo.run = false;
		npc.walkTo.HELOLJBENMK(npc.targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EJPFGEHOKPK));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		npc.walkTo.EHDKLBLKBEO();
	}

	public void BKHOPNGPLFE(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		MFELPPLNNIN();
	}

	public void JLPLOHELCAF(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		JLAHJOOAKID();
	}

	public void PEDHBENHANF(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		JLAHJOOAKID();
	}

	public void NDHIAFFAEPB(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		KNLPDIAANLE();
	}

	public void JDHKHKJOKFF()
	{
		if (!LCHBIEAICAK && npc.walkTo != null && npc.walkTo.IIMEFNIECLI())
		{
			LCHBIEAICAK = true;
		}
	}

	private void JLAHJOOAKID()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = true;
		npc.animationBase.IGONGEODOFP = false;
		npc.walkTo.run = false;
		npc.walkTo.DHFPOCOEONG(npc.targetWalkTo, AHDHLIECIGH: false);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AHPFECCLOBB));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MDLHDGDLANK));
		npc.walkTo.PEHELKCIECB();
	}

	private void HFCKHCAJHAK()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		npc.animationBase.IGONGEODOFP = false;
		npc.walkTo.run = false;
		npc.walkTo.GHDMBFOAAHK(npc.targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ANAHMLJAENA));
		npc.walkTo.EHDKLBLKBEO();
	}

	private void JEJGIAPPCLG()
	{
		npc.ChangeState(DialogueNPCBase.p_WalkTo);
	}

	private void MDLHDGDLANK()
	{
		npc.ChangeState(DialogueNPCBase.p_WalkTo);
	}

	private void DKFOJDHBGEJ()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		npc.animationBase.IGONGEODOFP = false;
		npc.walkTo.run = false;
		npc.walkTo.FNNPPBDFBCI(npc.targetWalkTo, AHDHLIECIGH: false);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		npc.walkTo.PEHELKCIECB();
	}

	private void EJPFGEHOKPK()
	{
		if (npc.endWalkDirection != 0)
		{
			npc.animationBase.SetDirection(npc.endWalkDirection);
			npc.endWalkDirection = Direction.Diagonal;
		}
		if (npc.disable)
		{
			npc.ChangeState(DialogueNPCBase.p_Inactive);
			npc.disable = false;
		}
		else
		{
			npc.ChangeState(DialogueNPCBase.p_Waiting);
		}
		if (!string.IsNullOrEmpty(npc.endTriggerAnimation))
		{
			npc.animationBase.SetTrigger(npc.endTriggerAnimation);
			npc.endTriggerAnimation = null;
		}
		npc.WalkToCompleted();
		if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)npc.onlineNPC))
		{
			npc.onlineNPC.SendActorPosition();
			npc.onlineNPC.SendNPCDirection();
		}
	}

	public void NLOEGNNLKKE()
	{
		if (!LCHBIEAICAK && npc.walkTo != null && npc.walkTo.BODEPFFAHLE())
		{
			LCHBIEAICAK = false;
		}
	}

	public void PGOMAJKGFPE(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		JLAHJOOAKID();
	}

	private void CCHENCELDDJ()
	{
		npc.ChangeState(DialogueNPCBase.p_WalkTo);
	}

	public void CMALDGECKDI(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		DKFOJDHBGEJ();
	}

	public void KKMPLBFGEDA(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		HFCKHCAJHAK();
	}

	private void MMPGIKGMFMA()
	{
		if (npc.endWalkDirection != 0)
		{
			npc.animationBase.SetDirection(npc.endWalkDirection);
			npc.endWalkDirection = (Direction)6;
		}
		if (npc.disable)
		{
			npc.ChangeState(DialogueNPCBase.p_Inactive);
			npc.disable = false;
		}
		else
		{
			npc.ChangeState(DialogueNPCBase.p_Waiting);
		}
		if (!string.IsNullOrEmpty(npc.endTriggerAnimation))
		{
			npc.animationBase.SetTrigger(npc.endTriggerAnimation, HALNIEBONKH: true);
			npc.endTriggerAnimation = null;
		}
		npc.WalkToCompleted();
		if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)npc.onlineNPC))
		{
			npc.onlineNPC.SendActorPosition();
			npc.onlineNPC.SendNPCDirection();
		}
	}

	public void KFBEAPDIHMF(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		HFCKHCAJHAK();
	}

	private void JLJEFENEFMG()
	{
		if (npc.endWalkDirection != Direction.Down)
		{
			npc.animationBase.SetDirection(npc.endWalkDirection);
			npc.endWalkDirection = Direction.Diagonal;
		}
		if (npc.disable)
		{
			npc.ChangeState(DialogueNPCBase.p_Inactive);
			npc.disable = false;
		}
		else
		{
			npc.ChangeState(DialogueNPCBase.p_Waiting);
		}
		if (!string.IsNullOrEmpty(npc.endTriggerAnimation))
		{
			npc.animationBase.SetTrigger(npc.endTriggerAnimation, HALNIEBONKH: true);
			npc.endTriggerAnimation = null;
		}
		npc.WalkToCompleted();
		if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)npc.onlineNPC))
		{
			npc.onlineNPC.SendActorPosition();
			npc.onlineNPC.SendNPCDirection();
		}
	}

	public void AHPNEDOLBII()
	{
		if (!LCHBIEAICAK && npc.walkTo != null && npc.walkTo.PLAGPJAKCKL())
		{
			LCHBIEAICAK = false;
		}
	}

	public void FGCMIBJIIHB(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		HBEDMMIKHLG();
	}

	public void FGJPOPCBFNE()
	{
		if (!LCHBIEAICAK && npc.walkTo != null && npc.walkTo.GOACFCOOJLK(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = false;
		}
	}

	private void MAILEMECPME()
	{
		if (npc.endWalkDirection != Direction.Diagonal)
		{
			npc.animationBase.SetDirection(npc.endWalkDirection);
			npc.endWalkDirection = Direction.Diagonal;
		}
		if (npc.disable)
		{
			npc.ChangeState(DialogueNPCBase.p_Inactive);
			npc.disable = true;
		}
		else
		{
			npc.ChangeState(DialogueNPCBase.p_Waiting);
		}
		if (!string.IsNullOrEmpty(npc.endTriggerAnimation))
		{
			npc.animationBase.SetTrigger(npc.endTriggerAnimation);
			npc.endTriggerAnimation = null;
		}
		npc.WalkToCompleted();
		if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)npc.onlineNPC))
		{
			npc.onlineNPC.SendActorPosition();
			npc.onlineNPC.HMKAFNJCKKI();
		}
	}

	private void ACOJHBFFFIF()
	{
		npc.ChangeState(DialogueNPCBase.p_WalkTo);
	}

	private void HBEDMMIKHLG()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		npc.animationBase.IGONGEODOFP = false;
		npc.walkTo.run = true;
		npc.walkTo.DHFPOCOEONG(npc.targetWalkTo);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ANAHMLJAENA));
		npc.walkTo.NOFKEMGPFEO();
	}

	public void LHKJNOPGGEO(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		KNLPDIAANLE();
	}

	private void KNLPDIAANLE()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = true;
		npc.animationBase.IGONGEODOFP = false;
		npc.walkTo.run = true;
		npc.walkTo.GLHBJNDMIDC(npc.targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AHPFECCLOBB));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JEJGIAPPCLG));
		npc.walkTo.EHDKLBLKBEO();
	}

	public void PMLHDLPJPDG()
	{
		if (!LCHBIEAICAK && npc.walkTo != null && npc.walkTo.IIMEFNIECLI(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = false;
		}
	}

	private void AHPFECCLOBB()
	{
		if (npc.endWalkDirection != Direction.Right)
		{
			npc.animationBase.SetDirection(npc.endWalkDirection);
			npc.endWalkDirection = (Direction)6;
		}
		if (npc.disable)
		{
			npc.ChangeState(DialogueNPCBase.p_Inactive);
			npc.disable = true;
		}
		else
		{
			npc.ChangeState(DialogueNPCBase.p_Waiting);
		}
		if (!string.IsNullOrEmpty(npc.endTriggerAnimation))
		{
			npc.animationBase.SetTrigger(npc.endTriggerAnimation);
			npc.endTriggerAnimation = null;
		}
		npc.WalkToCompleted();
		if (OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)npc.onlineNPC))
		{
			npc.onlineNPC.SendActorPosition();
			npc.onlineNPC.HMKAFNJCKKI();
		}
	}

	private void ANAHMLJAENA()
	{
		npc.ChangeState(DialogueNPCBase.p_WalkTo);
	}

	private void BFGPMEKLDDB()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		npc.animationBase.IGONGEODOFP = false;
		npc.walkTo.run = true;
		npc.walkTo.JDHMPOJKOLF(npc.targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EJPFGEHOKPK));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CCHENCELDDJ));
		npc.walkTo.NOFKEMGPFEO();
	}

	public void LBMAPIJJMGL(DialogueNPCBase JFLENDJFAOE)
	{
		npc = JFLENDJFAOE;
		DKFOJDHBGEJ();
	}
}
