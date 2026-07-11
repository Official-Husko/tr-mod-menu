using System;
using UnityEngine;

[Serializable]
public struct ItemEntry
{
	public Item item;

	public int minQuantity;

	public int maxQuantity;

	[Range(0f, 100f)]
	public float weight;
}
