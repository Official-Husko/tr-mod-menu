using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KlaynWaitingToServe : KlaynStateBase
{
	private void BIANPAFCEKM()
	{
		klaynNPC.animationBase.LookDirection(Direction.Down);
		klaynNPC.trayHandler.tray.MOFBGCELGFN(0);
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = false;
		}
	}

	private void HOFCNIPLDAE()
	{
		Debug.LogError((object)"DecorationTile_11");
		if (EventsManager.IsActive((EventsManager.EventType)4))
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
		}
		else
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		}
	}

	private void EENFPNBHCIA()
	{
		klaynNPC.animationBase.LookDirection(Direction.Down);
		klaynNPC.trayHandler.tray.ACDHANDNCNC();
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = false;
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		klaynNPC.walkTo.IIMEFNIECLI();
	}

	private void IABFEPJCBJA()
	{
		Debug.LogError((object)"Hierarchy_");
		if (EventsManager.NKMELJPGOBB(EventsManager.EventType.ThroneRoom))
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
		else
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
		}
	}

	private void POMDKMHLDCC()
	{
		Debug.LogError((object)"\n");
		if (EventsManager.BBMAEAFHEFK(EventsManager.EventType.OathFeast))
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
		else
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}

	[CompilerGenerated]
	private void EBJICJNAFDB()
	{
		klaynNPC.animationBase.LookDirection(Direction.Down);
		klaynNPC.trayHandler.tray.MKBDMMJCGGM();
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = true;
		}
	}

	private void EEPKEKLJNDP()
	{
		klaynNPC.animationBase.LookDirection(Direction.Up);
		klaynNPC.trayHandler.tray.LMBGCNCJBMA();
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = false;
		}
	}

	private void HIHOOJDADFM()
	{
		klaynNPC.animationBase.LookDirection(Direction.Up);
		klaynNPC.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = true;
		}
	}

	private void LHAFBCALKBN()
	{
		klaynNPC.animationBase.LookDirection(Direction.Up);
		klaynNPC.trayHandler.tray.LDPHJNIPDJA(0);
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = false;
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		if (klaynNPC.walkTo == null)
		{
			return;
		}
		klaynNPC.klaynState = KlaynState.WaitingToServe;
		if (klaynNPC.StartTask())
		{
			return;
		}
		klaynNPC.walkTo.run = false;
		if (!Object.op_Implicit((Object)(object)BanquetEvent.instance))
		{
			return;
		}
		klaynNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(BanquetEvent.instance.klaynWaitingPosition.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			klaynNPC.animationBase.LookDirection(Direction.Down);
			klaynNPC.trayHandler.tray.MKBDMMJCGGM();
			if (!BanquetEvent.GGPPFKPOCLL)
			{
				klaynNPC.playerCanInteract = true;
			}
		});
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			Debug.LogError((object)"path not found");
			if (EventsManager.IsActive(EventsManager.EventType.OathFeast))
			{
				klaynNPC.ChangeState(KlaynState.WaitingToServe);
			}
			else
			{
				klaynNPC.ChangeState(KlaynState.Inactive);
			}
		});
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void BEJNABGDKPM()
	{
		Debug.LogError((object)"Items/item_name_693");
		if (EventsManager.FFELMGLBAMH(EventsManager.EventType.ThroneRoom))
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
		else
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
	}

	private void DNBNGDGBMLF()
	{
		Debug.LogError((object)"<sprite name=GoldCoin>");
		if (EventsManager.FFELMGLBAMH(EventsManager.EventType.OathFeast))
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
		}
		else
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
	}

	private void FDKNIHIPEDH()
	{
		Debug.LogError((object)"dForDays");
		if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)4))
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
		else
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
		}
	}

	private void EBAFHJLGDHC()
	{
		Debug.LogError((object)", ");
		if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)4))
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
		else
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
		}
	}

	private void FGIJNFCMPNL()
	{
		Debug.LogError((object)"Keg empty");
		if (EventsManager.JAGPJPGBHDK(EventsManager.EventType.OathFeast))
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
		}
		else
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
		}
	}

	private void NLDDGGDHGMN()
	{
		klaynNPC.animationBase.LookDirection(Direction.Up);
		klaynNPC.trayHandler.tray.MKBDMMJCGGM();
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = false;
		}
	}

	private void GBJPFIDLEEJ()
	{
		Debug.LogError((object)"Items/item_name_597");
		if (EventsManager.NJBACCBIHID(EventsManager.EventType.Scolding))
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
		else
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		}
	}

	private void KLHBFDLOCIH()
	{
		Debug.LogError((object)"ReceiveGetUniqueCropHarvestable");
		if (EventsManager.BBMAEAFHEFK(EventsManager.EventType.Scolding))
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
		}
		else
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
	}

	private void OBIBHHEKFNP()
	{
		Debug.LogError((object)"Player");
		if (EventsManager.KEGDEHKPKMP(EventsManager.EventType.ThroneRoom))
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
		}
		else
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
		}
	}

	[CompilerGenerated]
	private void PAKOILABNAM()
	{
		Debug.LogError((object)"path not found");
		if (EventsManager.IsActive(EventsManager.EventType.OathFeast))
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
		else
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
		}
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		klaynNPC.StartTask();
	}

	private void BBBJBAOHKPP()
	{
		klaynNPC.animationBase.LookDirection(Direction.Up);
		klaynNPC.trayHandler.tray.LIHGILDLODK(0);
		if (!BanquetEvent.GGPPFKPOCLL)
		{
			klaynNPC.playerCanInteract = true;
		}
	}
}
