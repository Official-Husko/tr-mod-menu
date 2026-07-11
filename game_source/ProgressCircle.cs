using System;
using UnityEngine;

public class ProgressCircle : Progressor
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Sprite[] states;

	public override float BHGJPBGINCG
	{
		set
		{
			base.BHGJPBGINCG = value;
			int val = Mathf.RoundToInt(COAPHJJHNIO * (float)(states.Length - 2));
			val = Math.Max(Math.Min(val, states.Length), 0);
			spriteRenderer.sprite = states[val];
			if (COAPHJJHNIO == 1f)
			{
				spriteRenderer.sprite = states[states.Length - 1];
			}
		}
	}
}
