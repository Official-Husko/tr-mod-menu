using System;
using UnityEngine;

[Serializable]
public struct UpgradeRoomInfo
{
	public UpgradedRoom[] upgrades;

	public GameObject[] moveObjects;

	public BoxCollider2D cameraBounds;
}
