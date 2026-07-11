using PixelCrushers.DialogueSystem;

public class GoToHotSPringsEvent : GameEvent
{
	public static GoToHotSPringsEvent instance;

	public override GameEvent GetInstance()
	{
		return instance;
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
		DialogueLua.SetVariable("MainProgress", (object)11);
		MissionsManager.instance.StartMission(312, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RenegotiationEvent.instance.ActivateEvent();
	}
}
