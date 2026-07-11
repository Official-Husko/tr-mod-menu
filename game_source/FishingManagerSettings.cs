using System;
using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(fileName = "FishingManagerSettingsSO", menuName = "FishingManagerSettings")]
public class FishingManagerSettings : ScriptableObject
{
	[Serializable]
	public class DifficultySettings
	{
		public float barReductionPerSecond = 0.15f;

		public float hitProgression = 0.05f;

		public float hitReduction = 0.02f;

		public FloatRange movementTime = new FloatRange
		{
			min = 1f,
			max = 2f
		};

		public FloatRange movementDistance = new FloatRange
		{
			min = 50f,
			max = 200f
		};

		public FloatRange stopTime = new FloatRange
		{
			min = 0f,
			max = 0.5f
		};
	}

	public bool EASY_FISHING;

	public DifficultySettings normalMode;

	public DifficultySettings easyMode;

	public float height = 2f;

	public float rollUpHeight = 3f;

	public float initialDelayTime = 1.5f;

	public int totalTime = 8;

	public float timeBetweenBites = 0.3f;

	public float realBiteDuration = 1f;

	public Vector2Int bitesNum = new Vector2Int(3, 5);

	public float time = 0.75f;

	public float rollUpTime = 0.6f;

	public float rollUpWaitTime = 0.3f;

	public float shakeAmount = 3f;

	public float shakePeriod = 0.1f;

	public float randomVariation = 0.5f;

	public float gamepadMovementSpeed = 200f;

	public Color positiveGlowColor;

	public Color negativeGlowColor;

	public Sprite normalBox;

	public Sprite greenBox;

	public Sprite redBox;

	public AudioObject reelSound;
}
