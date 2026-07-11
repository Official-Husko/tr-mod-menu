using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class AnimalMessage : PlaceableMsg
{
	[JsonProperty("1")]
	public AnimalInstanceMessage animalInstanceMessage;

	[JsonProperty("2")]
	public int level;

	[JsonProperty("3")]
	public bool sick;

	[JsonProperty("4")]
	public float productionProgress;

	[JsonProperty("5")]
	public int barnLevel = int.MaxValue;

	[JsonProperty("6")]
	public int spaceIndex = int.MaxValue;

	[JsonProperty("7")]
	public int vitaminsRemainingDays;

	[JsonProperty("8")]
	public int henHouseUniqueID = int.MaxValue;

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		if (onlineObject is OnlineAnimal onlineAnimal)
		{
			onlineAnimal.placeable.itemSetup.DNLMCHDOMOK = animalInstanceMessage.ANMBPDJLNFN();
			onlineAnimal.animalNpc.level = level;
			onlineAnimal.animalNpc.productionProgress = productionProgress;
			onlineAnimal.animalNpc.SetVitamins(vitaminsRemainingDays, CDPAMNIPPEC: false);
			if (barnLevel != int.MaxValue && spaceIndex != int.MaxValue)
			{
				onlineAnimal.AssignAnimal(barnLevel, spaceIndex);
			}
			if (sick)
			{
				onlineAnimal.animalNpc.Sick(CDPAMNIPPEC: false);
			}
			if (henHouseUniqueID != int.MaxValue)
			{
				((MonoBehaviour)onlineAnimal).StartCoroutine(onlineAnimal.AssignHenHouseOnLoad(henHouseUniqueID));
			}
		}
		else
		{
			Debug.LogError((object)("Received PlaceableMsg of another type not AnimalMessage to " + ((Object)((Component)onlineObject).gameObject).name));
		}
		return onlineObject;
	}

	public AnimalMessage(OnlineAnimal EONPHODEBKN)
		: base(EONPHODEBKN)
	{
		animalInstanceMessage = new AnimalInstanceMessage(EONPHODEBKN.placeable.itemSetup.DNLMCHDOMOK as AnimalInstance);
		level = EONPHODEBKN.animalNpc.level;
		productionProgress = EONPHODEBKN.animalNpc.productionProgress;
		sick = EONPHODEBKN.animalNpc.isSick;
		vitaminsRemainingDays = EONPHODEBKN.animalNpc.vitaminsRemainingDays;
		if ((Object)(object)EONPHODEBKN.animalNpc.animalSpace != (Object)null && (Object)(object)Barn.instance != (Object)null)
		{
			barnLevel = Barn.instance.EONJGMONIOM;
			spaceIndex = EONPHODEBKN.animalNpc.animalSpace.JFNMCNCHMEO;
		}
		if (EONPHODEBKN.animalNpc.currentBuilding is HenHouse henHouse)
		{
			henHouseUniqueID = henHouse.onlineHenHouse.uniqueId;
		}
	}
}
