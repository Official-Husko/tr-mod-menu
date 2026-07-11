using UnityEngine;

public class NinjaCustomerEatingAtTable : NinjaCustomerStateBase
{
	private float nextEat;

	private void JMHINCGJLOG()
	{
	}

	private void NFAKODHBKBM()
	{
	}

	private void HEKJMIGHLLK()
	{
	}

	private void AHMPBPMAIJA()
	{
	}

	private void FDKINJEGMKG()
	{
	}

	private void DDPAALEEEBF()
	{
	}

	private void PEGONAGCGDG()
	{
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		ninjaChallengeCustomer.ninjaCustomerState = NinjaCustomerState.EatingAtTable;
		nextEat = Time.time + Random.Range(2f, 5f);
		npc.animationBase.SetBool("Eating", EGFGNGJGBOP: true);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		npc.animationBase.SetBool("Eating", EGFGNGJGBOP: false);
		OnlineManager.IsMasterClient();
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
	}

	private void NOENMGFCKEG()
	{
	}

	private void FHBBLAIOPJD()
	{
	}

	private void MLPFPEENMPF()
	{
	}

	private void LCCACFEPCCA()
	{
	}

	private void JCCOJLBLNHF()
	{
	}

	private void CMLPILDDCHA()
	{
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (WorldTime.TickTimeIsBlocked())
		{
			nextEat += Time.deltaTime;
			return;
		}
		if (Time.time > nextEat)
		{
			nextEat = Time.time + Random.Range(2f, 5f);
			npc.animationBase.SetTrigger("Eat");
		}
		ninjaChallengeCustomer.customerSpeech.CustomerSittingDown();
	}

	private void ANADDGCOHOC()
	{
	}

	private void JGGGGJAAPIE()
	{
	}

	private void CODICEEJHNN()
	{
	}

	private void EDKAGLAKLBC()
	{
	}

	private void BOEFIDEKHPG()
	{
	}
}
