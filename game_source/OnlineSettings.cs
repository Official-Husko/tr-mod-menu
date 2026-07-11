using System;
using UnityEngine;

public class OnlineSettings : ScriptableObject
{
	[Serializable]
	public class MessageLimit
	{
		[Range(1f, 1000f)]
		public int TavernFloorTilesPerMessage = 200;

		[Range(1f, 1000f)]
		public int PlaceablesPerMessage = 50;

		[Range(1f, 1000f)]
		public int TerrainWorldTilesPerMessage = 300;

		[Range(1f, 1000f)]
		public int CropsPerMessage = 400;

		[Range(1f, 1000f)]
		public int TreesPerMessage = 10;

		[Range(1f, 1000f)]
		public int HerbsPerMessage = 100;
	}

	[Range(0.1f, 1f)]
	[Tooltip("To avoid buffer congestion, network messages for loading tasks will be deferred by this amount.\nIdeally a handshake implementation should be added.")]
	public float waitTimeBetweenMessages = 0.25f;

	public MessageLimit MessageLimits;

	public bool enableDebugsRPCs;

	public bool enableDebugsPositionsAndRotations;
}
