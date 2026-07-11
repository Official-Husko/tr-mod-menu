using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SnapToPosition
{
	public Item item;

	public GameObject instantiateGO;

	public Item[] items;

	public GameObject[] instantiateGOs;

	public Transform transform;

	public bool fixedY;

	public bool randomScaleX;

	public bool canBeRepeated;

	public bool canBePickupable;

	public int group;

	public string sortingLayerName;

	public bool used;

	public int sortingOrder;

	public GameObject gameObjectToActivate;

	public List<int> snapToPositionNeeded = new List<int>();
}
