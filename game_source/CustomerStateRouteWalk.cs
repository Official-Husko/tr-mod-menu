public class CustomerStateRouteWalk : CustomerStateBase
{
	private NPCDespawn JMNLIMJHMDH;

	public override int GetStateEnumID()
	{
		return 13;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		base.EnterState(GDHCBGCIIKG);
		JMNLIMJHMDH = new NPCDespawn(JHIFLALPEBF, JHIFLALPEBF.path[0]);
		JMNLIMJHMDH.AECNEHGDMNL(JHIFLALPEBF.path);
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		if (JMNLIMJHMDH != null)
		{
			JMNLIMJHMDH.IIMEFNIECLI();
		}
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		if (JMNLIMJHMDH != null)
		{
			JMNLIMJHMDH.JKGGEMBAPAJ();
			JMNLIMJHMDH = null;
		}
	}
}
