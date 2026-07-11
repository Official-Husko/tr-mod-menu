using PixelCrushers.DialogueSystem;

public class RenegotiationEvent : GameEvent
{
	public static RenegotiationEvent instance;

	public override GameEvent GetInstance()
	{
		return instance;
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public override void EndEvent(bool _isActor)
	{
		base.EndEvent(_isActor);
		DialogueLua.SetVariable("MainProgress", (object)12);
		MissionsManager.instance.StartMission(313, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		PeaceAgreementEvent.instance.ActivateEvent();
	}
}
