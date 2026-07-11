using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Colours", menuName = "Game/ColourCollection")]
public class SO_ColourCollection : ScriptableObject
{
	[Serializable]
	public struct ColourSelection
	{
		public Color mainColor;

		public Color secondaryColor;
	}

	public ColourSelection[] colourSelections;
}
