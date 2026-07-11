using UnityEngine;

[CreateAssetMenu(menuName = "Game/CustomerInfo")]
public class CustomerInfo : ScriptableObject
{
	public int floorDirtProbability = 55;

	public int rateMakeFloorDirt = 5;

	public int requestAgainProbability = 50;

	public int timeEatingMin = 60;

	public int timeEatingMax = 120;

	public int timeEatingLastOrdersMin = 15;

	public int timeEatingLastOrdersMax = 25;

	public int testRateRowdyCustomers = 10;

	public int rowdyCustomersProbability = 7;

	public int calmRowdyCustomersProbability = 50;

	public float timeAfterNextRowdyCustomer = 20f;

	public float roomDoesntMeetRequirementsPenalty = 0.3f;

	public float dirtinessMultiplier = 4f;

	public Vector2Int roomOrdersRate = new Vector2Int(30, 60);

	public float comfortMultiplier = 0.4f;

	public float propBadServiceMult = 0.8f;

	public float player2Multiplier = 0.75f;

	public int repComfortMin = 30;

	public float roomOrdersReputiationMultiplier = 0.3f;

	public int trendsMultiplier = 8;

	public int uniqueItemsMultiplier = 4;

	public float requestOrderPatience = 10f;

	public float requestRoomPatience = 30f;

	public float tableDirtyPenalty = 0.01f;

	public float tableVeryDirtyPenalty = 0.02f;

	public float notEnoughLightEvery10secs = 0.05f;

	public float tavernDirty = 0.02f;

	public float tavernFilthy = 0.03f;

	public float tavernDisgusting = 0.04f;

	public float temperaturePenalty = 0.02f;

	public float rowdyCustomerNearPenalty = 0.02f;

	public float withoutAnyFoodAtBar = 0.02f;

	public float leaveWillingly = 0.2f;

	public float floorDirtPenalty = 0.05f;

	public float beingANuisancePenalty = 0.1f;

	public float longTimeWaitingPenalty = 0.01f;

	public bool showService;
}
