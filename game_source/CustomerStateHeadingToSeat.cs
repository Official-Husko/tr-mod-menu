using System;
using System.Runtime.CompilerServices;

public class CustomerStateHeadingToSeat : CustomerStateBase
{
	private NPCSitDown CLPLLDDHHOO;

	private void GBEHGIANNLI()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.KNFNJFFCFNO(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)67, KCNFNAICINO: false);
		}
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		CLPLLDDHHOO.IIMEFNIECLI();
	}

	private void OCIIACGNKAJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
	}

	private void KPDFIADBMCA()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
	}

	private void FJMCJAMCGCK()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.KNFNJFFCFNO(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)101, KCNFNAICINO: false);
		}
	}

	private void IBLKIJKCLIC()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-10), KCNFNAICINO: false);
		}
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		CLPLLDDHHOO = new NPCSitDown(JHIFLALPEBF);
		NPCSitDown cLPLLDDHHOO = CLPLLDDHHOO;
		cLPLLDDHHOO.OnActionComplete = (Action)Delegate.Combine(cLPLLDDHHOO.OnActionComplete, (Action)delegate
		{
			if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
			{
				PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
			}
			else
			{
				PJNGMCJIHME.ChangeState(CustomerState.WaitingForBarSpot);
			}
		});
		NPCSitDown cLPLLDDHHOO2 = CLPLLDDHHOO;
		cLPLLDDHHOO2.OnFailStart = (Action)Delegate.Combine(cLPLLDDHHOO2.OnFailStart, (Action)delegate
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		});
		CLPLLDDHHOO.PEHELKCIECB();
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		if (CLPLLDDHHOO != null)
		{
			CLPLLDDHHOO.JKGGEMBAPAJ();
			CLPLLDDHHOO = null;
		}
	}

	private void NDDCFAFOEDG()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
	}

	private void BCLMAHMJDBJ()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-44), KCNFNAICINO: false);
		}
	}

	private void PDGNBFMPKIL()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.KNFNJFFCFNO(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)52);
		}
	}

	private void AKBOLNAHOHB()
	{
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
	}

	private void CKBHHKGJJIK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void MLOAGJDGDDC()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.RequestRoom);
		}
	}

	private void CMIHJJBOPFF()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)39);
		}
	}

	[CompilerGenerated]
	private void LCGBPKOBFIF()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingForBarSpot);
		}
	}

	private void GEEOEEPJDFG()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-117), KCNFNAICINO: false);
		}
	}

	private void EIJAPABMJEA()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
	}

	private void CHNNGAGKOKM()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
	}

	private void DFIEJJIOGMI()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
	}

	private void OBCLIGAIPDF()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-58));
		}
	}

	private void EAOBIJCOMJB()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
	}

	private void PIOEMJCPJGD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
	}

	private void NGACMCANKEP()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)36);
		}
	}

	private void DFNLIDFLAOJ()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.AFOACBIHNCL(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)44);
		}
	}

	private void BHPOIECBPGE()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-60), KCNFNAICINO: false);
		}
	}

	private void CJLFPPIBPPK()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.AFOACBIHNCL(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-14));
		}
	}

	private void CGJAMCKNHDM()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
	}

	private void LCIJCABMLFP()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.KNFNJFFCFNO(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-94), KCNFNAICINO: false);
		}
	}

	public override int GetStateEnumID()
	{
		return 5;
	}

	private void FKAHNIOAHLO()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
	}

	private void EEDDIOBDPHB()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.KNFNJFFCFNO(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)93);
		}
	}

	private void CLEJPNKAMKF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
	}

	private void EFJJFKKLDLL()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void AKDKBCKLPLD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
	}

	private void OPEBPDKEINN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
	}

	private void CBAPIFOMBGA()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.AFOACBIHNCL(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)82, KCNFNAICINO: false);
		}
	}

	private void LHEKFJLDNNI()
	{
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
	}

	private void CBMNGNMPKJF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
	}

	private void EDEGDANOINJ()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-16));
		}
	}

	private void GKPFENACJIE()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
	}

	private void HPKDAONNIIB()
	{
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
	}

	private void KOLLEKNOOOA()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
	}

	private void MIHAKFBDALK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
	}

	private void HAFJFBOPDNN()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-31), KCNFNAICINO: false);
		}
	}

	private void KIDHPDBEMMO()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)49, KCNFNAICINO: false);
		}
	}

	private void COMEKIOEKDO()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-99));
		}
	}

	private void BGPKOFFLHEC()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
	}

	private void MKNOCJOKMEK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
	}

	private void EMGIHJHINPH()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-81), KCNFNAICINO: false);
		}
	}

	private void HFKHMGEANMB()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
	}

	private void CLDELIBIPOP()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void KNCNPFCABOH()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void HLGNJCNNBLD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
	}

	private void KAGLGHGMMPJ()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)26);
		}
	}

	private void AHIFMAGJFJK()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)76, KCNFNAICINO: false);
		}
	}

	private void GIMFJMNCKDA()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.LHBPOPOIFLE(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)57);
		}
	}

	private void PNGCPCLBHOL()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
	}

	private void FAJHKFOCBLB()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-96), KCNFNAICINO: false);
		}
	}

	private void HGKFBJCBABB()
	{
		if (PJNGMCJIHME.currentItem != null && Item.MLBOMGHINCA(PJNGMCJIHME.currentItem.AFOACBIHNCL(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-125));
		}
	}

	private void LFGFMJAJFOJ()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.PHGLMBIEOMK(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-106), KCNFNAICINO: false);
		}
	}

	private void IAEOCIGDFMM()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.AFOACBIHNCL(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)81);
		}
	}

	private void GLCNPGEFAJE()
	{
		if (PJNGMCJIHME.currentItem != null && Item.FKLOBGBIHLB(PJNGMCJIHME.currentItem.AFOACBIHNCL(), null))
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)30);
		}
	}

	private void LCACBHMDPIM()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
	}

	[CompilerGenerated]
	private void LLHHMNJJFIO()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void OGHFFNHBKFK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
	}
}
