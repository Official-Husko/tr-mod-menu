using System;
using UnityEngine;

[Serializable]
public class CrystalPuzzleSettings : PuzzleBaseSettings
{
	[Tooltip("Minimum number of steps in the sequence to solve the puzzle ")]
	[Range(4f, 8f)]
	public int easyMinSteps;

	[Range(4f, 8f)]
	[Tooltip("Maximum number of steps in the sequence to solve the puzzle")]
	public int easyMaxSteps;

	[Range(4f, 8f)]
	[Tooltip("Minimum number of steps in the sequence to solve the puzzle ")]
	public int normalMinSteps;

	[Range(4f, 8f)]
	[Tooltip("Maximum number of steps in the sequence to solve the puzzle")]
	public int normalMaxSteps;
}
