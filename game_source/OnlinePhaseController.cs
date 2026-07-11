public class OnlinePhaseController : OnlinePlaceable
{
	public override PlaceableMsg CreateMsg()
	{
		return new PhaseControllerMessage(this);
	}
}
