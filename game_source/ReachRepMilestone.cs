using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Quest/Reach Rep Milestone")]
public class ReachRepMilestone : Quest
{
	public int requiredRepMilestone;

	private void OKNFGGEGBHP(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			EPIMKBNCFCK(1, 1);
		}
	}

	private void JNKOBDPPHPI(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(1, 0);
		}
	}

	private void MKPEKMNLKHL(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(1, 0);
		}
	}

	private void BLNFODCDIDF(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(0, 1);
		}
	}

	private void CAGGGBEBDEC(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(0, 0);
		}
	}

	private void LBCKNAOBDFB(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			GKDGCBNNHAD(0, 1);
		}
	}

	public override void MHOGPMHEAFN()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HJFEJJICHEM));
		MFHHJFEJAMF();
	}

	private void IHNHDCLJDPJ(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(0, 1);
		}
	}

	private void EDLFOKNNMFB(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			GKDGCBNNHAD(1, 0);
		}
	}

	private void LHPADNJAGEE(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			GKDGCBNNHAD(0, 1);
		}
	}

	private void DJHHDGGOEOO(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			GKDGCBNNHAD(1, 1);
		}
	}

	private void JLNGICMOELA(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			EPIMKBNCFCK(0, 1);
		}
	}

	private void MMOBHLBIBEG(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(0, 0);
		}
	}

	private void LGFLEHPBFOI(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			EPIMKBNCFCK(1, 1);
		}
	}

	private void IBINELAHFHF(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			EPIMKBNCFCK(1, 1);
		}
	}

	private void LNODFLIAPDL(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(0, 0);
		}
	}

	private void MFHMCFCGPIE(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			EPIMKBNCFCK(0, 1);
		}
	}

	private void LHNIANMLIOH(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			GKDGCBNNHAD(0, 0);
		}
	}

	public override void OEICMCIGNKO()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HJFEJJICHEM));
		HJFEJJICHEM(TavernReputation.GetMilestone());
	}

	private void HJFEJJICHEM(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			EPIMKBNCFCK(1, 1);
		}
	}

	private void GGJHBKFFDPP(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(1, 0);
		}
	}

	private void CPJKAHEJKDL(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA == requiredRepMilestone)
		{
			PIGBLLFBKHD(1, 0);
		}
	}
}
