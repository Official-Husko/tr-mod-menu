using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KyrohWaitingToServe : KyrohStateBase
{
	private void LGFIPIOIIAK()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Right);
		kyrohNPC.trayHandler.tray.FIJLPLJMJFA(0);
	}

	private void PFPACOIJOBF()
	{
		kyrohNPC.animationBase.LookDirection((Direction)8);
		kyrohNPC.trayHandler.tray.ACDHANDNCNC(0, GFNHAMCPEAK: false);
	}

	private void FGIJNFCMPNL()
	{
		Debug.LogError((object)"Dialogue System/Conversation/Crowly_Barks_Shop/Entry/5/Dialogue Text");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.ServingCustomer);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Inactive);
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		if (kyrohNPC.walkTo == null)
		{
			return;
		}
		kyrohNPC.kyrohState = KyrohState.WaitingToServe;
		if (kyrohNPC.StartTask())
		{
			return;
		}
		kyrohNPC.walkTo.run = false;
		kyrohNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(NinjaChallengeEvent.instance.movePositions[0].position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = kyrohNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			kyrohNPC.animationBase.LookDirection(Direction.Right);
			kyrohNPC.trayHandler.tray.MKBDMMJCGGM();
		});
		NPCWalkTo walkTo2 = kyrohNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			Debug.LogError((object)"path not found");
			if (NinjaChallenge.ADDLIAMDPBL)
			{
				kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			}
			else
			{
				kyrohNPC.ChangeState(KyrohState.Inactive);
			}
		});
		kyrohNPC.walkTo.PEHELKCIECB();
	}

	[CompilerGenerated]
	private void EBJICJNAFDB()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Right);
		kyrohNPC.trayHandler.tray.MKBDMMJCGGM();
	}

	private void POMDKMHLDCC()
	{
		Debug.LogError((object)"");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.TakingFood);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Inactive);
		}
	}

	private void PMLEFGEBEPG()
	{
		Debug.LogError((object)"Angry");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.ThrowingSpikes);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.Idle);
		}
	}

	[CompilerGenerated]
	private void PAKOILABNAM()
	{
		Debug.LogError((object)"path not found");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.Inactive);
		}
	}

	private void DNBNGDGBMLF()
	{
		Debug.LogError((object)" dying!");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.TakingFood);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Idle);
		}
	}

	private void DALEMNHMNMG()
	{
		Debug.LogError((object)" CloseUI ConstructionUI");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.WaitingToServe);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		}
	}

	private void IABFEPJCBJA()
	{
		Debug.LogError((object)". ");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.ChangeState(KyrohState.Inactive);
		}
		else
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.Inactive);
		}
	}

	private void EBAFHJLGDHC()
	{
		Debug.LogError((object)"Close UI");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.WaitingToServe);
		}
		else
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.Inactive);
		}
	}

	private void JJNNPIFGNOK()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Diagonal);
		kyrohNPC.trayHandler.tray.ACDHANDNCNC();
	}

	private void CKLPPPMGEDD()
	{
		kyrohNPC.animationBase.LookDirection((Direction)8);
		kyrohNPC.trayHandler.tray.FIJLPLJMJFA(0, GFNHAMCPEAK: false);
	}

	private void DCJCGGGNBJD()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		kyrohNPC.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		kyrohNPC.StartTask();
	}

	private void MEBGJJKKCND()
	{
		Debug.LogError((object)"IsRaining");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.Idle);
		}
	}

	private void PIKOKJBENEJ()
	{
		Debug.LogError((object)"/");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.PreparingFood);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Inactive);
		}
	}

	private void NAGNHPOJCLC()
	{
		Debug.LogError((object)"Items/item_description_1122");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
		}
		else
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.Idle);
		}
	}

	private void EMIFIILKHDG()
	{
		Debug.LogError((object)"Gameplay");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.ChangeState(KyrohState.Idle);
		}
		else
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.Idle);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		kyrohNPC.walkTo.IIMEFNIECLI();
	}

	private void OCOFPDCEDBF()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Diagonal);
		kyrohNPC.trayHandler.tray.NBODABCGELG(0, GFNHAMCPEAK: false);
	}

	private void KOGLOHPKOBI()
	{
		Debug.LogError((object)"Player with actor number {0} removed from Players dictionary. Entries left: {1}");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WalkTo);
		}
		else
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.Inactive);
		}
	}

	private void LLHCABGCKGI()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Down);
		kyrohNPC.trayHandler.tray.FIJLPLJMJFA();
	}

	private void LHAFBCALKBN()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Right);
		kyrohNPC.trayHandler.tray.IOCOONMEGLI(0, GFNHAMCPEAK: false);
	}

	private void KNIAJALOAPG()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Diagonal);
		kyrohNPC.trayHandler.tray.IOCOONMEGLI(1, GFNHAMCPEAK: false);
	}

	private void GIKJLOMIIJM()
	{
		Debug.LogError((object)"ReceiveSpadeActionMaster");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.ServingCustomer);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		}
	}

	private void FKKALIFGCHB()
	{
		Debug.LogError((object)"");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
		}
		else
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.Inactive);
		}
	}

	private void FDKNIHIPEDH()
	{
		Debug.LogError((object)" was shared and assigned ID ");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.PreparingFood);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.Inactive);
		}
	}

	private void GCMHOJMBDFG()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		kyrohNPC.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
	}

	private void OBIBHHEKFNP()
	{
		Debug.LogError((object)"Kick out");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.ServingCustomer);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Idle);
		}
	}

	private void CNNCAGEEFEI()
	{
		Debug.LogError((object)"\n");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.PreparingFood);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Inactive);
		}
	}

	private void FJLBNDCBDBP()
	{
		Debug.LogError((object)"ReceiveFishCuttingEventThrowScene");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.Inactive);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Idle);
		}
	}

	private void PLPHFBBKNAE()
	{
		Debug.LogError((object)"Ax Level Low");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.Idle);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		}
	}

	private void NFCCHJBOOLP()
	{
		Debug.LogError((object)"Exit build mode");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.PreparingFood);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		}
	}

	private void BIANPAFCEKM()
	{
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		kyrohNPC.trayHandler.tray.IOCOONMEGLI(0);
	}

	private void IHOLGAHHNND()
	{
		kyrohNPC.animationBase.LookDirection((Direction)8);
		kyrohNPC.trayHandler.tray.LDPHJNIPDJA(0);
	}

	private void KLHBFDLOCIH()
	{
		Debug.LogError((object)"Dialogue System/Conversation/NeutralInTavern/Entry/16/Dialogue Text");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.ChangeState(KyrohState.WalkTo);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Inactive);
		}
	}

	private void JOOPEDPEMNK()
	{
		Debug.LogError((object)"Error_Money");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.Idle);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Idle);
		}
	}

	private void FIMIHJAFHCM()
	{
		Debug.LogError((object)"Place");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.Idle);
		}
		else
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.Idle);
		}
	}

	private void GNDNMOEFDPD()
	{
		Debug.LogError((object)"popUpBuilding10");
		if (NinjaChallenge.ADDLIAMDPBL)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.ServingCustomer);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.Idle);
		}
	}
}
