using System;
using UnityEngine;

[Serializable]
public struct ItemsWeightEntry
{
	public ItemEntry[] items;

	[Tooltip("Número de items a seleccionar aleatoriamente de la lista")]
	public int count;

	[Range(0f, 100f)]
	public int weight;
}
