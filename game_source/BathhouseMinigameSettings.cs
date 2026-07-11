using System;
using UnityEngine;

public class BathhouseMinigameSettings : ScriptableObject
{
	[Serializable]
	public class DifficultySettings
	{
		[Tooltip("Time to complete the game, in seconds.")]
		public float timeToCompleteTheGame = 90f;

		[Tooltip("Min and max temperature change per second.")]
		public FloatRange temperatureVariation = new FloatRange
		{
			min = 0.03f,
			max = 0.08f
		};

		[Tooltip("Min and Max time until next temperature change wave, in seconds.")]
		public FloatRange timeToTemperatureWave = new FloatRange
		{
			min = 2f,
			max = 6f
		};

		[Tooltip("Min and Max time the temperature change wave lasts, in seconds.")]
		public FloatRange temperatureWaveDuration = new FloatRange
		{
			min = 3f,
			max = 6f
		};

		[Tooltip("Multiplier for the temperature change during a wave.")]
		public float waveMultiplier = 2f;

		[Range(0f, 1f)]
		[Tooltip("Threshold for the danger zone.")]
		public float dangerZoneThreshold = 0.2f;

		[Tooltip("Max time a pool can be in the danger zone before players lose.")]
		public float maxTimeInDangerZone = 5f;
	}

	public DifficultySettings normalMode;

	public DifficultySettings easyMode;

	[Header("Settings")]
	[Tooltip("How much the UI indicator slows down when approaching the target temperature.")]
	public float uiDampingFactor = 9f;

	[Tooltip("How fast the UI indicator accelerates towards the target position.")]
	public float uiAccelerationFactor = 4f;

	public Color coldPoolColor;

	public Color hotPoolColor;
}
