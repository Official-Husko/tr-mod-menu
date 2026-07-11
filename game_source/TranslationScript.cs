using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TranslationScript : MonoBehaviour
{
	[Serializable]
	public class Corners
	{
		public Transform baseFrom;

		public Transform cornerFrom;

		public Transform cornerTo;
	}

	[Space(20f)]
	public Corners[] corners;

	public List<Tilemap> tilemaps;

	public bool removeTilemap;
}
