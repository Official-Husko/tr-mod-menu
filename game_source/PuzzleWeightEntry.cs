using System;
using UnityEngine;

[Serializable]
public struct PuzzleWeightEntry
{
	public MinePuzzleType type;

	[Range(0f, 100f)]
	public int weight;
}
