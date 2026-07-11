using System;
using UnityEngine;

[Serializable]
public class SeatingGroup
{
	public Vector2Int buildSquares;

	public Transform transform;

	public Direction direction;

	public bool occupied;

	public bool applyCanSeat;
}
