using UnityEngine;

public class CustomerStateOrderInTable : CustomerStateBase
{
	private float BGELPKAELFA;

	public override int GetStateEnumID()
	{
		return 11;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		if ((Object)(object)JHIFLALPEBF.seat != (Object)null)
		{
			JHIFLALPEBF.seat.DirtDish(GLPHCCKKIFD: true, CDPAMNIPPEC: true);
		}
		PJNGMCJIHME.IdleAtTable();
		JHIFLALPEBF.FJHKGBNBNKL.Sit(JHIFLALPEBF.FJHKGBNBNKL.FCGBJEIIMBC);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		BGELPKAELFA = Time.time + PJNGMCJIHME.customerInfo.requestOrderPatience;
		PJNGMCJIHME.RequestTableOrder();
		Bar.instance.AddRequestAtBar(JHIFLALPEBF);
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		base.UpdateState(GDHCBGCIIKG);
		if (Time.time > BGELPKAELFA + 40f)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.longTimeWaitingPenalty * 3f;
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		else if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		if ((Object)(object)JHIFLALPEBF.seat != (Object)null)
		{
			JHIFLALPEBF.seat.CleanDirtyDish();
		}
		PJNGMCJIHME.tableOrder.RemoveTableOrder();
		Bar.instance.RemoveFromWaitingAtBar(JHIFLALPEBF);
		if ((Object)(object)JHIFLALPEBF.seat != (Object)null)
		{
			JHIFLALPEBF.seat.UpdateSpritesHeldItem();
		}
	}
}
