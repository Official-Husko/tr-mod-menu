using System;
using UnityEngine;

[Serializable]
public class PipeTileInstance
{
	[Tooltip("Reference to the PipeTile ScriptableObject")]
	public PipeTile tile;

	[Tooltip("Unique identifier within this puzzle. Assigned during generation and persists through scrambling.")]
	public int instanceId;

	[Tooltip("If true, this specific tile instance must be part of the connected path to solve the puzzle.")]
	public bool isRequired;

	public PipeTileInstance(PipeTile ILDEFBIANKO, int OPLMAFFLDJC, bool EKPIOGNJCJE = false)
	{
		tile = ILDEFBIANKO;
		instanceId = OPLMAFFLDJC;
		isRequired = EKPIOGNJCJE;
	}
}
