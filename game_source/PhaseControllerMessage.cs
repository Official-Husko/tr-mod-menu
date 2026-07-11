using System;
using Newtonsoft.Json;

[Serializable]
public class PhaseControllerMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public PhaseItemInstanceMessage phaseItemInstanceMessage;

	public PhaseControllerMessage(OnlinePhaseController MBIBELHLIFE)
		: base(MBIBELHLIFE)
	{
		phaseItemInstanceMessage = new PhaseItemInstanceMessage(MBIBELHLIFE.placeable.itemSetup.DNLMCHDOMOK as PhaseItemInstance);
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlinePhaseController onlinePhaseController)
		{
			phaseItemInstanceMessage.BNBJFAHIMNH(onlinePhaseController.placeable.itemSetup.DNLMCHDOMOK);
		}
		return onlineObject;
	}
}
