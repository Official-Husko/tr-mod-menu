using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mine/Torch Puzzle Database")]
public class TorchPuzzleDatabase : ScriptableObject
{
	public List<TorchCountGroup> torchGroups = new List<TorchCountGroup>();
}
