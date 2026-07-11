using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CustomerStateDespawning : CustomerStateBase
{
	private NPCDespawn JMNLIMJHMDH;

	private void FAJHKFOCBLB()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
	}

	private void FIEPIFMNIMC()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
	}

	private void KAGLGHGMMPJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
	}

	private void CBAPIFOMBGA()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
	}

	private void AKAFFFBNBBK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
	}

	private void KIDHPDBEMMO()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void MKDDCNMGCMC()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
	}

	private void MLOAGJDGDDC()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		JMNLIMJHMDH.IIMEFNIECLI();
	}

	private void CLAPDFBJDPF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void DBEECAACONH()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
	}

	private void CPBDFBIFCEB()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void CJLFPPIBPPK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
	}

	private void MOEEJOAPPEM()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void OCDGLIIDNLD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void DFNLIDFLAOJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void DNJPOBLJNAN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
	}

	public override int GetStateEnumID()
	{
		return 2;
	}

	private void IOEIAGGFFNP()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
	}

	private void EDEGDANOINJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
	}

	private void HPPJJGGEFBM()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void COMEKIOEKDO()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
	}

	private void EMGIHJHINPH()
	{
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
	}

	private void HAFJFBOPDNN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		JMNLIMJHMDH = new NPCDespawn(MNNOHBNGPMB: Vector2.op_Implicit(((Component)((!JHIFLALPEBF.spawnedLeft) ? NPCRoadManager.GetLeftSideSpawner(JHIFLALPEBF.spawnedIndex) : NPCRoadManager.GetRightSideSpawner(JHIFLALPEBF.spawnedIndex))).transform.position), JHIFLALPEBF: JHIFLALPEBF);
		NPCDespawn jMNLIMJHMDH = JMNLIMJHMDH;
		jMNLIMJHMDH.OnFailStart = (Action)Delegate.Combine(jMNLIMJHMDH.OnFailStart, (Action)delegate
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		});
		JMNLIMJHMDH.PEHELKCIECB();
	}

	private void FJMCJAMCGCK()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
	}

	private void JAFBDLNLBMA()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
	}

	private void ANFKPJKGFLN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
	}

	private void FLHFMICMIFD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
	}

	private void OBCLIGAIPDF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
	}

	private void IBLKIJKCLIC()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void GLCNPGEFAJE()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
	}

	private void PDGNBFMPKIL()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
	}

	private void CIIBGPONALD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
	}

	private void BCLMAHMJDBJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
	}

	private void EIBIFHHHDCI()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void HFFLDGMNNMM()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
	}

	private void HGKFBJCBABB()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void MKNODHOHINN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
	}

	[CompilerGenerated]
	private void LCGBPKOBFIF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
	}

	private void LFGFMJAJFOJ()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
	}

	private void CMIHJJBOPFF()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		if (JMNLIMJHMDH != null)
		{
			JMNLIMJHMDH.JKGGEMBAPAJ();
			JMNLIMJHMDH = null;
		}
	}

	private void NDLNNHPEBDH()
	{
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
	}

	private void LKHFIOGLCCG()
	{
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
	}

	private void EKGPLHMIIKC()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
	}

	private void LKHLNBPBBFN()
	{
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
	}

	private void KMHGAIAKJAD()
	{
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
	}
}
