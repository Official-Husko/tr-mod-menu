using System;
using System.Collections.Generic;

[Serializable]
public class DifficultyGroup
{
	public int steps;

	public List<TorchPuzzleData> puzzles = new List<TorchPuzzleData>();
}
