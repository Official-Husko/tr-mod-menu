using System;
using UnityEngine;

public class FishCuttingMinigameSettings : ScriptableObject
{
	[Serializable]
	public class DifficultySettings
	{
		public float timeToCompleteTheGame = 120f;

		public FloatRange timeBetweenThrows = new FloatRange
		{
			min = 0.5f,
			max = 1.5f
		};

		public FloatRange fishFlightTime = new FloatRange
		{
			min = 2.2f,
			max = 2.5f
		};

		[Range(0f, 1f)]
		[Tooltip("Chance of missing a throw, not aiming at a player correctly.")]
		public float unsuccessfulThrowRatio = 0.3f;

		public int fishToCutToWin = 20;
	}

	public DifficultySettings normalMode;

	public DifficultySettings easyMode;

	[Tooltip("Size of the hitbox to check fish cuts, to avoid using colliders. This hitbox located at the player's origin (on their feet) which aligns well with the sword animation.")]
	[Header("Cut Point")]
	public Vector2 hitboxWidthHeight = new Vector2(2.5f, 1f);

	public float cutYOffset = 0.35f;

	public FloatRange tCutRange = new FloatRange
	{
		min = 0.5f,
		max = 0.5f
	};

	[Header("Arc Params")]
	public FloatRange peakBiasY = new FloatRange
	{
		min = 8f,
		max = 16f
	};

	public FloatRange splashXJitter = new FloatRange
	{
		min = 0f,
		max = 0f
	};

	public FloatRange splashYJitter = new FloatRange
	{
		min = 0f,
		max = 0f
	};

	public FloatRange xBias = new FloatRange
	{
		min = -0.3f,
		max = 0.3f
	};

	[Range(1f, 2f)]
	public float animationSpeed = 1.5f;
}
