using UnityEngine;

public class KyrohStateBase : StateMachineBehaviour
{
	protected KyrohNPC kyrohNPC;

	public virtual void FKCOPHFELKD()
	{
	}

	public virtual void JBABHOJPFPG()
	{
	}

	public virtual void PGJLFLKDLAE()
	{
	}

	public virtual void PMLHDLPJPDG()
	{
	}

	public virtual void MAGACCHLAOE()
	{
	}

	public virtual void DGIFHBIJDDE()
	{
	}

	public virtual void DEFIFMAOPCM()
	{
	}

	public virtual void GFABFDHPJOK()
	{
	}

	public virtual void LALGIJBMOMI()
	{
	}

	public virtual void OHJIFGGCDAN()
	{
	}

	public virtual void DHJOHHEMMFK()
	{
	}

	public virtual void OGFKFGAMGCE()
	{
	}

	public virtual void NBNCMOAPDOG()
	{
	}

	public virtual void JMLDAJEFMPE()
	{
	}

	public virtual void HHPANGDONBN()
	{
	}

	public virtual void MOEJIBLELHP()
	{
	}

	public virtual void NODDNBFDJGO()
	{
	}

	public virtual void CLJBKGOGBII()
	{
	}

	public virtual void NLOEGNNLKKE()
	{
	}

	public virtual void JDHKHKJOKFF()
	{
	}

	public virtual void FGJPOPCBFNE()
	{
	}

	public virtual void HEDGGNKENPB()
	{
	}

	public virtual void MJENOBKFPIN()
	{
	}

	public virtual void OBJHHNMMCGF()
	{
	}

	public virtual void AFKGJCIANOF()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if ((Object)(object)kyrohNPC == (Object)null)
		{
			kyrohNPC = ((Component)ONDMDLMHMHK).GetComponent<KyrohNPC>();
		}
		kyrohNPC.kyrohStateBase = this;
		kyrohNPC.walkTo.isActive = false;
	}
}
