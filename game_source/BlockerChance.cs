using System;
using UnityEngine;

[Serializable]
public struct BlockerChance
{
	public BlockerType type;

	[Range(0f, 100f)]
	public int weight;
}
