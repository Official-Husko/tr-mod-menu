using System;
using System.Collections.Generic;
using UnityEngine;

public class ReplacePrefabs : MonoBehaviour
{
	[Serializable]
	public class PrefabReplacement
	{
		public GameObject prefabA;

		public GameObject prefabB;
	}

	public List<PrefabReplacement> replacements = new List<PrefabReplacement>();
}
