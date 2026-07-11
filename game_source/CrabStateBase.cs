using UnityEngine;

public class CrabStateBase : StateMachineBehaviour
{
	protected CrabNPC crabNpc;

	protected Animator animator;

	public virtual void KKECMFIHCCG()
	{
	}

	public virtual void MEGBBDPDFMD()
	{
	}

	public virtual void NLELJONPPAC()
	{
	}

	public virtual void DIIGOHOFKCP()
	{
	}

	public virtual void HFOIBPDABFK()
	{
	}

	public virtual void HCGFJOFPLKL()
	{
	}

	public virtual void AJCPAPCOJMI()
	{
	}

	public virtual void DPLJIOFMIJB()
	{
	}

	public virtual void HBBHNKIFAKF()
	{
	}

	public virtual void LHPGFNFEBGE()
	{
	}

	public virtual void BKBLLCBLLCH()
	{
	}

	public virtual void CDCDBGGEFJA()
	{
	}

	public virtual void BOJFGACPOFP()
	{
	}

	public virtual void EAFLAOJAJNI()
	{
	}

	public virtual void NPJHBHLJJBK()
	{
	}

	public virtual void OCHFEKECIDD()
	{
	}

	public virtual void ACBBHJIMGCC()
	{
	}

	public virtual void GNBCFDPCPCM()
	{
	}

	public virtual void ADNGOJKJNFJ()
	{
	}

	public virtual void IPJPDCJBLLO()
	{
	}

	public virtual void KBCAMBLCAAJ()
	{
	}

	public virtual void LKNBDIEAPKD()
	{
	}

	public virtual void LFDEDNGACNG()
	{
	}

	public virtual void IHEODBNLIPI()
	{
	}

	public virtual void IKOHALFABFG()
	{
	}

	public virtual void IGCEKMABCJH()
	{
	}

	public virtual void FPKEFJNDJHP()
	{
	}

	public virtual void CIAMFLMAMJC()
	{
	}

	public virtual void GIHCNGBPOGE()
	{
	}

	public virtual void MMHPBFMLCIG()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		crabNpc = ((Component)ONDMDLMHMHK).GetComponent<CrabNPC>();
		animator = ONDMDLMHMHK;
		crabNpc.currentCrabState = this;
		crabNpc.walkTo.isActive = false;
	}
}
