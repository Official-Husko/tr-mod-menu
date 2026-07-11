using UnityEngine;

public class BarnTilemapScene : TilemapScene
{
	public int barnLevel;

	public AnimalSpace[] animalSpaces;

	public AnimalFeederWater[] waterFeeders;

	public GameObject downLeftPosition;

	public GameObject cameraPosition;

	protected override void Awake()
	{
		base.Awake();
		CommonReferences.GGFJGHHHEJC.allBarnScenes.Add(barnLevel, this);
	}
}
