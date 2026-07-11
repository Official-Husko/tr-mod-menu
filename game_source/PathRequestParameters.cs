using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PathRequestParameters
{
	public float recto = 0.1f;

	public float diagonal;

	public float pathPenalization = 0.4f;

	public float bonificacionCaminoCaballo = 0.25f;

	public float penalizaciones = 0.1f;

	public float heuristicMultiplier = 1.2f;

	public Dictionary<Vector3, Vector3> cameFrom = new Dictionary<Vector3, Vector3>();

	public Dictionary<Vector3, AStarNode> open = new Dictionary<Vector3, AStarNode>();

	public List<Vector3> nodes;
}
