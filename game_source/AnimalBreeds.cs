using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Animal Breeds")]
public class AnimalBreeds : ScriptableObject
{
	[Serializable]
	public struct AnimalBreed
	{
		public int id;

		public Sprite icon;
	}

	public AnimalBreed[] breeds;
}
