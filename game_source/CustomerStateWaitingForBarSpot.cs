using UnityEngine;

public class CustomerStateWaitingForBarSpot : CustomerStateBase
{
	private float KPADPEAHHEI;

	public override int GetStateEnumID()
	{
		return 9;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		KPADPEAHHEI = Time.time + 1f;
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		if (GameManager.isLoading || GameManager.CIOEICMHCCK)
		{
			return;
		}
		base.UpdateState(GDHCBGCIIKG);
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		else if (Time.time > KPADPEAHHEI && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if (Bar.instance.GetEmptyBarSpace(JHIFLALPEBF, out var _))
			{
				PJNGMCJIHME.RemoveHeldItem(JODFPIMBMCD: true);
				PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			}
			KPADPEAHHEI = Time.time + 2f;
		}
	}
}
