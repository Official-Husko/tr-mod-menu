using UnityEngine;

public class MonsterStateBase : StateMachineBehaviour
{
	protected MonsterNPC monsterNpc;

	protected Animator animator;

	public virtual void JDCLPMNILCJ()
	{
	}

	public virtual void HOGDBKAKBDK()
	{
	}

	public virtual void FKEHFBFPHCJ()
	{
	}

	public virtual void OICFDJHEKJB()
	{
	}

	public virtual void IHNLEBALNOG()
	{
	}

	public virtual void KLGEMMMIHCC()
	{
	}

	public virtual void OJPCBMKFHKJ()
	{
	}

	public virtual void MFKDLJOEGEG()
	{
	}

	public virtual void NDOHNICDLFC()
	{
	}

	public virtual void DMIGGKJGNMI()
	{
	}

	public virtual void PMBMBHOIMMK()
	{
	}

	public virtual void FLINNOCHALI()
	{
	}

	public virtual void DAOHOOAMIDG()
	{
	}

	public virtual void ONOPJAOJHKP()
	{
	}

	public virtual void LADJHMHLEBO()
	{
	}

	public virtual void PGDNDMHDNEN()
	{
	}

	public virtual void NBNJPGOOOAF()
	{
	}

	public virtual void DDKAFKNPDPP()
	{
	}

	public virtual void HMBPLOAINEE()
	{
	}

	public virtual void DCLENOOEJAJ()
	{
	}

	public virtual void AFCIGKICKGP()
	{
	}

	public virtual void COEFDIFIOIA()
	{
	}

	public virtual void BAGEEMHKHAA()
	{
	}

	public virtual void LIDJCMAJIBH()
	{
	}

	public virtual void GEFEDKNAJDB()
	{
	}

	public virtual void GMOHGOHAEOL()
	{
	}

	public virtual void LGPNFPAMEJA()
	{
	}

	public virtual void PIPLEKDNCPB()
	{
	}

	public virtual void FECGHLOKAHH()
	{
	}

	public virtual void HPDPOEKJEFE()
	{
	}

	public virtual void DIGIINAJGEA()
	{
	}

	public virtual void OPHLPCOAGFO()
	{
	}

	public virtual void DDMIBLIMHCI()
	{
	}

	public virtual void COBDDIAPCOM()
	{
	}

	public virtual void HLHANNLMEIG()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		monsterNpc = ((Component)ONDMDLMHMHK).GetComponent<MonsterNPC>();
		animator = ONDMDLMHMHK;
		monsterNpc.currentMonsterState = this;
		monsterNpc.walkTo.isActive = false;
	}

	public virtual void LNMCLNKDLDJ()
	{
	}

	public virtual void HABJMGCMGJM()
	{
	}

	public virtual void LEAOLJGOJCD()
	{
	}

	public virtual void OPJDMNANLKO()
	{
	}

	public virtual void JECLOAFCBBP()
	{
	}
}
