public class CustomerStateBase : GenericStateBase
{
	protected HumanNPC JHIFLALPEBF;

	protected Customer PJNGMCJIHME;

	public override void InitializeState(GenericStateMachine ELKILIBAAKF, bool GDHCBGCIIKG = false)
	{
		base.InitializeState(ELKILIBAAKF, GDHCBGCIIKG);
		AGCLAOMNOGI = ELKILIBAAKF;
		JHIFLALPEBF = (AGCLAOMNOGI as CustomerStateMachine).npc;
		PJNGMCJIHME = (AGCLAOMNOGI as CustomerStateMachine).customer;
	}

	public override string GetStateName()
	{
		return ((object)this).GetType().ToString().Substring(13);
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.npc.walkTo != null)
		{
			PJNGMCJIHME.npc.walkTo.isActive = false;
		}
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		base.UpdateState(GDHCBGCIIKG);
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
	}
}
