using System;
using UnityEngine;

public class HouseKeeperLeaving : HouseKeeperBaseState
{
	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.houseKeeperState = HouseKeeperState.Leaving;
		houseKeeper.ResetFloorDirt();
		houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)NPCRoadManager.GetRandomSpawner()).transform.position));
		NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
		walkTo.OnFailStart = (Action)Delegate.Combine(walkTo.OnFailStart, new Action(houseKeeper.DestroyHouseKeeper));
		NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
		walkTo2.OnActionComplete = (Action)Delegate.Combine(walkTo2.OnActionComplete, new Action(houseKeeper.DestroyHouseKeeper));
		houseKeeper.OEONGPFALKH.PEHELKCIECB();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.OEONGPFALKH.IIMEFNIECLI();
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)houseKeeper != (Object)null)
		{
			NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Remove(walkTo.OnActionComplete, new Action(houseKeeper.DestroyHouseKeeper));
			NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Remove(walkTo2.OnFailStart, new Action(houseKeeper.DestroyHouseKeeper));
		}
	}
}
