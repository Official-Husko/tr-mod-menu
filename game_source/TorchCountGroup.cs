using System;
using System.Collections.Generic;

[Serializable]
public class TorchCountGroup
{
	public int torchCount;

	public List<DifficultyGroup> difficulties = new List<DifficultyGroup>();
}
