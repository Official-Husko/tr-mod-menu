using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InteriorsAction
{
	public DecorationTile decoTile;

	public Sprite icon;

	public bool activated = true;

	[HideInInspector]
	public List<DecorationTile> decoTilesList = new List<DecorationTile>();
}
