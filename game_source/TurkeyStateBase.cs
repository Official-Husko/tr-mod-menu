using UnityEngine;

public class TurkeyStateBase : StateMachineBehaviour
{
	protected TurkeyNPC turkeyNpc;

	protected Animator animator;

	public virtual void IEHAIBNPBDJ()
	{
	}

	public virtual void LJBAGHCBAGC()
	{
	}

	public virtual void IEAENLGAJBH()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		turkeyNpc = ((Component)ONDMDLMHMHK).GetComponent<TurkeyNPC>();
		animator = ONDMDLMHMHK;
		turkeyNpc.currentTurkeyState = this;
		turkeyNpc.walkTo.isActive = false;
	}

	public virtual void DLLEGKJNFFM()
	{
	}

	public virtual void CFFNKGEKKDA()
	{
	}

	public virtual void MLMCJEPPJHA()
	{
	}

	public virtual void KGKNBFLMFEI()
	{
	}

	public virtual void FBAFAOMLKMG()
	{
	}

	public virtual void ODPGGKEGKFK()
	{
	}

	public virtual void KFPHOGGLGHB()
	{
	}

	public virtual void NNHMECCLBJJ()
	{
	}

	public virtual void EHBJGKOOOFF()
	{
	}
}
