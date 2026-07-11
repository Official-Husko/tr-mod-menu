using UnityEngine;

public class BanquetCustomerStateEatingAtTable : BanquetCustomerStateBase
{
	private int reorders;

	private float nextEat;

	private float nextDrink;

	private bool drinkAnimation;

	private void CPGMEEHEADJ()
	{
	}

	private void EBDFIINHOLL()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		banquetCustomer.banquetCustomerState = BanquetCustomerState.EatingAtTable;
		AOHAFGHNHPJ();
		reorders = 0;
		nextEat = Time.time + Random.Range(1f, 3f);
		drinkAnimation = false;
		nextDrink = Time.time + Random.Range(4f, 6f);
		if (BanquetEvent.GGPPFKPOCLL)
		{
			banquetCustomer.drinking = true;
		}
		npc.animationBase.SetBool("Drink", banquetCustomer.drinking);
		OnlineManager.IsMasterClient();
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (WorldTime.TickTimeIsBlocked())
		{
			nextEat += Time.deltaTime;
			nextDrink += Time.deltaTime;
			return;
		}
		if (banquetCustomer.drinking)
		{
			if (Time.time > nextDrink)
			{
				drinkAnimation = !drinkAnimation;
				if (drinkAnimation)
				{
					nextDrink = Time.time + Random.Range(1f, 2f);
				}
				else
				{
					nextDrink = Time.time + Random.Range(4f, 6f);
				}
				banquetCustomer.spoon.SetActive(false);
				banquetCustomer.mug.SetActive(true);
				npc.animationBase.SetBool("Drink", drinkAnimation);
			}
		}
		else if (Time.time > nextEat)
		{
			nextEat = Time.time + Random.Range(1f, 3f);
			banquetCustomer.spoon.SetActive(true);
			banquetCustomer.mug.SetActive(false);
			npc.animationBase.SetTrigger("Eat");
		}
		banquetCustomer.customerSpeech.CustomerSittingDown();
	}

	private void HHDNCGNAOGM()
	{
	}

	private void AHMPBPMAIJA()
	{
	}

	private void AOHAFGHNHPJ()
	{
	}

	private void BIFOKLDIHID()
	{
	}

	private void CAPAFOGCMCC()
	{
	}

	private void IGPJEBGPPMK()
	{
	}

	private void OOHLCMLEINI()
	{
	}

	private void HEKJMIGHLLK()
	{
	}

	private void PBJBMEJEDEM()
	{
	}

	private void ANADDGCOHOC()
	{
	}

	private void JLGFJNLNJAI()
	{
	}

	private void OMAJNNODHLN()
	{
	}

	private void IJDBJGGAJNB()
	{
	}

	private void OPLOEGLMDOD()
	{
	}

	private void OBDNPEAJENF()
	{
	}

	private void PLEHMLGFLHG()
	{
	}

	private void EMIPBALMLEI()
	{
	}

	private void NPCJDNFBNDJ()
	{
	}

	private void AGCFJJHFINJ()
	{
	}

	private void FJFKFJKDCAL()
	{
	}

	private void KCPCCADHDHL()
	{
	}

	private void CMLPILDDCHA()
	{
	}

	private void BFFKGNGFGCF()
	{
	}

	private void CODICEEJHNN()
	{
	}

	private void JGGGGJAAPIE()
	{
	}

	private void LIEDGBFHOLI()
	{
	}

	private void FHBBLAIOPJD()
	{
	}

	private void MAOFNCEHANG()
	{
	}

	private void ODEPGPIBOKD()
	{
	}

	private void FGENHLPKFBE()
	{
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		drinkAnimation = false;
		npc.animationBase.SetBool("Drink", EGFGNGJGBOP: false);
		OnlineManager.IsMasterClient();
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
	}

	private void IADCPBFPFHJ()
	{
	}

	private void BDLBNEPKLLM()
	{
	}
}
