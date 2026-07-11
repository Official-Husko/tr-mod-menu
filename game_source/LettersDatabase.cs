using System;
using UnityEngine;

public class LettersDatabase : ScriptableObject
{
	[Serializable]
	public struct Character
	{
		public string name;

		public string localisedNameKey;

		public Sprite portrait;

		public Sprite bodySprite;
	}

	public Character[] characters;

	public Letter[] letters;
}
