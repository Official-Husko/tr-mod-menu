using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MineModuleSO", menuName = "ScriptableObjects/MinePieceSO", order = 1)]
public class MinePieceSO : ScriptableObject
{
	[Serializable]
	public struct Variant
	{
		public Vector2[] pathNodesCreated;

		public Vector2[] holeValidNodes;
	}

	public Variant[] variants;
}
