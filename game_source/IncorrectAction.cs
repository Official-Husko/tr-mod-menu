using System;
using UnityEngine;

[Serializable]
public struct IncorrectAction
{
	public IncorrectActionType type;

	[Tooltip("Solo se usa si el tipo es WaitTime")]
	public float waitTime;
}
