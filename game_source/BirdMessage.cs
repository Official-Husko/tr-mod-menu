using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class BirdMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public BirdInstanceMessage birdInstanceMessage;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineBird onlineBird)
		{
			onlineBird.placeable.itemSetup.DNLMCHDOMOK = birdInstanceMessage.ANMBPDJLNFN();
			if (onlineBird.placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
			{
				onlineBird.bird.SetBirdCharacterSpriteAndMaterial(birdInstance.birdId, birdInstance.birdMaterialId);
				onlineBird.placeable.initialMaterial = birdInstance.IEHJMMBMLPO();
			}
		}
		else
		{
			Debug.LogError((object)("Received PlaceableMsg of another type not BirdMessage to " + ((Object)((Component)onlineObject).gameObject).name));
		}
		return onlineObject;
	}

	public BirdMessage(OnlineBird PENHNEELDMK)
		: base(PENHNEELDMK)
	{
		birdInstanceMessage = new BirdInstanceMessage(PENHNEELDMK.placeable.itemSetup.DNLMCHDOMOK as BirdInstance);
	}
}
