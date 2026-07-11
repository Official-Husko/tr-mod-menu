using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeperLightingFireplace : HouseKeeperBaseState
{
	[CompilerGenerated]
	private sealed class JMMCCFDNGFI
	{
		public HouseKeeperLightingFireplace _003C_003E4__this;

		public Animator animator;

		public Vector3 lightingPositionFree;

		internal void CCMNDPOJOEB()
		{
			if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Hot)
			{
				_003C_003E4__this.houseKeeper.fireplace.SetOn(AODONKKHPBP: false);
			}
			else if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
			{
				if (_003C_003E4__this.houseKeeper.fireplace.currentFuel <= 0f && _003C_003E4__this.houseKeeper.fireplace.slots[0].KPINNBKMOMO())
				{
					_003C_003E4__this.houseKeeper.fireplace.AddItemInstance(1, ItemDatabaseAccessor.GetItem(1055).JMDALJBNFML());
				}
				_003C_003E4__this.houseKeeper.fireplace.SetOn(AODONKKHPBP: true);
			}
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}

		internal void MCGGOAKFPLO()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			if (!_003C_003E4__this.houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(lightingPositionFree)))
			{
				_003C_003E4__this.houseKeeper.positionsBlocked.Add(Vector2.op_Implicit(lightingPositionFree));
			}
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.OEONGPFALKH.IIMEFNIECLI();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)houseKeeper.fireplace == (Object)null)
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		houseKeeper.houseKeeperState = HouseKeeperState.LightingFireplace;
		Vector3 lightingPositionFree = houseKeeper.fireplace.GetLightingPositionFree(houseKeeper.positionsBlocked);
		houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(lightingPositionFree));
		NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Hot)
			{
				houseKeeper.fireplace.SetOn(AODONKKHPBP: false);
			}
			else if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
			{
				if (houseKeeper.fireplace.currentFuel <= 0f && houseKeeper.fireplace.slots[0].KPINNBKMOMO())
				{
					houseKeeper.fireplace.AddItemInstance(1, ItemDatabaseAccessor.GetItem(1055).JMDALJBNFML());
				}
				houseKeeper.fireplace.SetOn(AODONKKHPBP: true);
			}
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		});
		NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			if (!houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(lightingPositionFree)))
			{
				houseKeeper.positionsBlocked.Add(Vector2.op_Implicit(lightingPositionFree));
			}
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		});
		houseKeeper.OEONGPFALKH.PEHELKCIECB();
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)houseKeeper.fireplace == (Object)null || houseKeeper.fireplace.placeable.FHEMHCEAICB)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
		else if ((!GameManager.PlayingOnline() || !houseKeeper.fireplace.placeable.onlinePlaceable.CLHLNFFGOGA) && TavernManager.GGFJGHHHEJC.ABKMALJOCCC != HeatLevel.Hot && TavernManager.GGFJGHHHEJC.ABKMALJOCCC != 0)
		{
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}
}
