using System;
using UnityEngine;

[Serializable]
public struct RequiredItemEntry
{
	public Item[] items;

	[Tooltip("Dialogue key para la pista específica de este item")]
	public string overrideHintDialogueKey;
}
