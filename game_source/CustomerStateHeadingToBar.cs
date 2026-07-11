using System;
using System.Runtime.CompilerServices;

public class CustomerStateHeadingToBar : CustomerStateBase
{
	private NPCGoToBar NLHCJGIEIBP;

	private void EFPLPKKCBMN()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)5)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-112), KCNFNAICINO: false);
		}
	}

	private void OCIIACGNKAJ()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != (NPCState)3)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)35, KCNFNAICINO: false);
		}
	}

	private void DGKMFKFCACB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-69), KCNFNAICINO: false);
		}
	}

	private void NLADFNFFGLA()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-27));
		}
	}

	private void OGHFFNHBKFK()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)119);
		}
	}

	private void OIGFAMIFKNH()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)8)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-66), KCNFNAICINO: false);
		}
	}

	private void CLAPDFBJDPF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		if (NLHCJGIEIBP != null)
		{
			NLHCJGIEIBP.IIMEFNIECLI();
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
	}

	private void CGJAMCKNHDM()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-43), KCNFNAICINO: false);
		}
	}

	private void JMDFNGLHAFJ()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)5)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)89, KCNFNAICINO: false);
		}
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		if (NLHCJGIEIBP != null)
		{
			NLHCJGIEIBP.JKGGEMBAPAJ();
			NLHCJGIEIBP = null;
		}
	}

	private void LFGFMJAJFOJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
	}

	private void HAFJFBOPDNN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
	}

	private void LFAPDBPGILB()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-27));
		}
	}

	private void MKNODHOHINN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			return;
		}
		NLHCJGIEIBP = new NPCGoToBar(JHIFLALPEBF);
		NPCGoToBar nLHCJGIEIBP = NLHCJGIEIBP;
		nLHCJGIEIBP.OnTavernEntered = (Action)Delegate.Combine(nLHCJGIEIBP.OnTavernEntered, new Action(PJNGMCJIHME.customerSpeech.CustomerEnterTavern));
		NPCGoToBar nLHCJGIEIBP2 = NLHCJGIEIBP;
		nLHCJGIEIBP2.OnActionComplete = (Action)Delegate.Combine(nLHCJGIEIBP2.OnActionComplete, (Action)delegate
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		});
		NPCGoToBar nLHCJGIEIBP3 = NLHCJGIEIBP;
		nLHCJGIEIBP3.OnFailStart = (Action)Delegate.Combine(nLHCJGIEIBP3.OnFailStart, (Action)delegate
		{
			if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			}
			if (JHIFLALPEBF.EOAONHNCDDO != NPCState.Sitting)
			{
				PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			}
			else
			{
				PJNGMCJIHME.ChangeState(CustomerState.WaitingForBarSpot);
			}
		});
		NLHCJGIEIBP.PEHELKCIECB();
	}

	private void KIDHPDBEMMO()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
	}

	private void JAFBDLNLBMA()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
	}

	private void OCDGLIIDNLD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
	}

	private void KOLLEKNOOOA()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)20, KCNFNAICINO: false);
		}
	}

	[CompilerGenerated]
	private void LCGBPKOBFIF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
	}

	private void AKBOLNAHOHB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != (NPCState)8)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-4));
		}
	}

	private void BHFFBOGPECI()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)125, KCNFNAICINO: false);
		}
	}

	private void AKAFFFBNBBK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
	}

	public override int GetStateEnumID()
	{
		return 3;
	}

	private void CKBHHKGJJIK()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)6)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-52));
		}
	}

	private void CHNNGAGKOKM()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-120), KCNFNAICINO: false);
		}
	}

	private void BCLMAHMJDBJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
	}

	[CompilerGenerated]
	private void LLHHMNJJFIO()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingForBarSpot);
		}
	}

	private void FLHFMICMIFD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
	}

	private void EAOBIJCOMJB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != (NPCState)8)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-72));
		}
	}

	private void DJBEBFJGBDL()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-31), KCNFNAICINO: false);
		}
	}

	private void HPKDAONNIIB()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)5)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-115));
		}
	}
}
