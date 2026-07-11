using UnityEngine;

[CreateAssetMenu(menuName = "Game/Worker Perk")]
public class EmployeePerk : Perk
{
	public WorkerType workerType;

	public bool negative;

	public float silverCost;

	public int[] incompatibilities;
}
