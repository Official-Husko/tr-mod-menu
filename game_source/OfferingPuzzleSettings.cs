using System;
using UnityEngine;

[Serializable]
public class OfferingPuzzleSettings : PuzzleBaseSettings
{
	[Tooltip("Pool de items posibles. Se selecciona uno aleatoriamente al inicializar el puzzle.")]
	public RequiredItemEntry[] possibleRequiredItems;
}
