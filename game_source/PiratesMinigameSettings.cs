using System;
using UnityEngine;

public class PiratesMinigameSettings : ScriptableObject
{
	[Serializable]
	public class DifficultySettings
	{
		public FloatRange timeBetweenCannonballs = new FloatRange
		{
			min = 0.2f,
			max = 0.8f
		};

		public FloatRange timeBetweenCannonballsToPlayers = new FloatRange
		{
			min = 0.3f,
			max = 1f
		};

		public FloatRange timeBetweenWaves = new FloatRange
		{
			min = 2f,
			max = 5f
		};

		public float timeToCompleteTheGame = 120f;

		public float warningTime = 1.5f;
	}

	public DifficultySettings normalMode;

	public DifficultySettings easyMode;

	public float initialCannonBallPositionY = 20f;

	public float fallTime = 1f;

	public float explosionLightIntensity = 2f;

	public float invincibilityTimeAfterHit = 2f;
}
