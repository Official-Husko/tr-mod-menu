using System;
using UnityEngine;

[Serializable]
public struct RecipeWeightEntry
{
	public RecipeSource[] recipes;

	[Range(0f, 100f)]
	public int weight;
}
