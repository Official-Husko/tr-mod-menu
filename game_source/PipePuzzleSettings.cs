using System;
using UnityEngine;

[Serializable]
public class PipePuzzleSettings : PuzzleBaseSettings
{
	[Tooltip("Grid width for the pipe puzzle")]
	public int gridWidth = 4;

	[Tooltip("Grid height for the pipe puzzle")]
	public int gridHeight = 4;

	[Tooltip("Required tiles when game difficulty is Fácil")]
	public int requiredTilesCountFacil;

	[Tooltip("Required tiles when game difficulty is Normal")]
	public int requiredTilesCountNormal = 2;
}
