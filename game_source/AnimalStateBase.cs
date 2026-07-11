using UnityEngine;

public class AnimalStateBase : StateMachineBehaviour
{
	protected AnimalNPC animalNpc;

	protected Animator animator;

	protected static readonly int p_Sleep = AnimatorParameterCache.p_Sleep;

	protected static readonly int p_Walk = AnimatorParameterCache.p_Walk;

	protected static readonly int p_Dead = AnimatorParameterCache.p_Dead;

	public virtual void IDCNECBFEGJ()
	{
	}

	public virtual void IPLJMBIJOGK()
	{
	}

	public virtual void PBLGLBCBLGH()
	{
	}

	public virtual void KCNOKAMIJFP()
	{
	}

	public virtual void PAIDKLAOBEE()
	{
	}

	public virtual void ECDHNLCCJBH()
	{
	}

	public virtual void PPMIHMFFCEC()
	{
	}

	public virtual void FPPLFBOFPPC()
	{
	}

	public virtual void DKDCHEPJDJF()
	{
	}

	public virtual void BDGNNIKAJPK()
	{
	}

	public virtual void EHPMAKPLJDC()
	{
	}

	public virtual void BMCNPFGDHOG()
	{
	}

	public virtual void PDGMMBHCJOK()
	{
	}

	public virtual void POPBDHILPKG()
	{
	}

	public virtual void MBBLMGLHLIG()
	{
	}

	public virtual void DHPLEGIDOIG()
	{
	}

	public virtual void LGNKIGPAIFJ()
	{
	}

	public virtual void CHHJPPLLEMN()
	{
	}

	public virtual void FIFOFGAKALF()
	{
	}

	public virtual void DMMLGIAOPOD()
	{
	}

	public virtual void IGNFGEOINHA()
	{
	}

	public virtual void NMPGAHGIGGA()
	{
	}

	public virtual void DOBNHIHMLNF()
	{
	}

	public virtual void NPHFDLONKMJ()
	{
	}

	public virtual void AODCHNJGJEP()
	{
	}

	public virtual void PCOCKMHPIEL()
	{
	}

	public virtual void FAOOFFGNJIA()
	{
	}

	public virtual void EADOONJADOE()
	{
	}

	public virtual void JAPHMMBBIML()
	{
	}

	public virtual void GGMOKAFHJMK()
	{
	}

	public virtual void OKICIKCAGDG()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if ((Object)(object)animalNpc == (Object)null)
		{
			animalNpc = ((Component)ONDMDLMHMHK).GetComponent<AnimalNPC>();
		}
		animator = ONDMDLMHMHK;
		animalNpc.currentAnimalState = this;
		animalNpc.walkTo.isActive = false;
	}

	public virtual void CLNBHLOOBBK()
	{
	}

	public virtual void AINBOAONIBI()
	{
	}

	public virtual void CDCHKGGIHPP()
	{
	}

	public virtual void KDOFFAMJPID()
	{
	}

	public virtual void BIAHLBNDHFK()
	{
	}
}
