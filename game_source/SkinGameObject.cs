using System;
using UnityEngine;

[Serializable]
public struct SkinGameObject
{
	public GameObject gameObject;

	public SpriteRenderer spriteRenderer;

	public Collider2D itemBase;

	public PhysicalSpace physicalSpace;
}
