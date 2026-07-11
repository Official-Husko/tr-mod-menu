using System;
using UnityEngine;

[Serializable]
public class TorchPuzzleSettings : PuzzleBaseSettings
{
	[Tooltip("Number of torches in the puzzle")]
	public Vector2Int numOfTorches;

	[Tooltip("Number of steps required to the optimal solution")]
	public Vector2Int easySolutionSteps;

	[Tooltip("Minimum number of connections other than our own that the torch must have")]
	[Range(1f, 5f)]
	public int easyMinTorchConnections = 1;

	[Tooltip("Number of steps required to the optimal solution")]
	public Vector2Int normalSolutionSteps;

	[Tooltip("Minimum number of connections other than our own that the torch must have")]
	[Range(1f, 5f)]
	public int normalMinTorchConnections = 1;
}
