using UnityEngine;

public class GenericNPCStateBase : StateMachineBehaviour
{
	protected GenericNPC npc;

	protected Animator animator;

	protected static readonly int p_Sleep = AnimatorParameterCache.p_Sleep;

	protected static readonly int p_Walk = AnimatorParameterCache.p_Walk;

	protected static readonly int p_Dead = AnimatorParameterCache.p_Dead;

	public virtual void ADIFBKLICLD()
	{
	}

	public virtual void GBAGMNGMENB()
	{
	}

	public virtual void CNLPBAGGFBG()
	{
	}

	public virtual void IKKEDPGDGKG()
	{
	}

	public virtual void PJBEKNNHOCB()
	{
	}

	public virtual void OOEMBOGENAO()
	{
	}

	public virtual void OCMBMFFODCH()
	{
	}

	public virtual void HOJKMDMDEMD()
	{
	}

	public virtual void MPNHDBOKKNL()
	{
	}

	public virtual void EOHCLFCIJHP()
	{
	}

	public virtual void PMAGFLOBEJH()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)ONDMDLMHMHK).GetComponent<GenericNPC>();
		}
		animator = ONDMDLMHMHK;
		npc.currentNpcState = this;
		npc.walkTo.isActive = false;
	}

	public virtual void ANJBKPCBBIC()
	{
	}

	public virtual void CJLHGAJOEMK()
	{
	}

	public virtual void NOPLHMEDIHI()
	{
	}

	public virtual void ILLPGKMJFMO()
	{
	}

	public virtual void DILIFDDMNJH()
	{
	}

	public virtual void DPFMOKIDPMB()
	{
	}

	public virtual void LECGKEIILJN()
	{
	}

	public virtual void HBNHKEOEPGN()
	{
	}

	public virtual void NHDKDMEGAEI()
	{
	}

	public virtual void ILEFMEIHCKD()
	{
	}

	public virtual void MJPJEJNDJCB()
	{
	}

	public virtual void NFINBPJFMJK()
	{
	}
}
