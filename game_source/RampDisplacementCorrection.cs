using UnityEngine;

public class RampDisplacementCorrection : MonoBehaviour
{
	public enum DisplacementType
	{
		Ramp,
		Arc
	}

	public DisplacementType type;

	public Direction direction;

	public float horizontalSize;

	[SerializeField]
	protected Vector2 displacement;

	private void DEKJGPJMAPC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/NeutralInTavern/Entry/17/Dialogue Text"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Invalid player num"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
	}

	private Vector2 GLCHCNMPFOF(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == (Direction)8)
		{
			return displacement * 1531f;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == (Direction)6)
		{
			return displacement * 888f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 834f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1830f;
		}
		return Vector2.zero;
	}

	private void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Cellar"))
		{
			PlayerController.GetPlayer(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveLoadMine"))
		{
			PlayerController.OPHDCMJLLEC(3).additionalDisplacement.Add(this);
		}
	}

	public virtual Vector2 CDAJBDGKBKD(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => FENPNJFFAKK(ANJLGNHMKAO), 
			DisplacementType.Arc => BFMICMFLLNC(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private Vector2 FFHOELIAEJN(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == (Direction)7 && direction == (Direction)5)
		{
			return displacement * 543f;
		}
		if (ANJLGNHMKAO == (Direction)8 && direction == Direction.Down)
		{
			return displacement * 845f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 1947f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 513f;
		}
		return Vector2.zero;
	}

	private Vector2 PECIDFBMLGP(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Diagonal && direction == Direction.Up)
		{
			return displacement * 59f;
		}
		if (ANJLGNHMKAO == Direction.Left && direction == (Direction)6)
		{
			return displacement * 1868f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 400f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 519f;
		}
		return Vector2.zero;
	}

	private Vector2 PLBOKHOPECO(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == (Direction)8)
		{
			return displacement * 61f;
		}
		if (ANJLGNHMKAO == (Direction)8 && direction == Direction.Diagonal)
		{
			return displacement * 134f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 359f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 405f;
		}
		return Vector2.zero;
	}

	private void JIDIKJNICGP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Checking current game language"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemSausage"))
		{
			PlayerController.GetPlayer(4).additionalDisplacement.Remove(this);
		}
	}

	private void ILOJBCEKLDF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Clean"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Pirates/Brook/Intro"))
		{
			PlayerController.GetPlayer(6).additionalDisplacement.Remove(this);
		}
	}

	private Vector2 IHFDMLPOLEI(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == Direction.Right)
		{
			return displacement * 1990f;
		}
		if (ANJLGNHMKAO == (Direction)6 && direction == Direction.Up)
		{
			return displacement * 284f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 1992f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 236f;
		}
		return Vector2.zero;
	}

	public virtual Vector2 AGFANFMPLJK(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DisplacementType displacementType = type;
		if (displacementType != 0)
		{
			if (displacementType == DisplacementType.Ramp)
			{
				return KCMANDLDEIJ(ANJLGNHMKAO, GJPDOHGJOLC);
			}
			return Vector2.zero;
		}
		return LIAKPAPJGFF(ANJLGNHMKAO);
	}

	private Vector2 EADKKOLOMMF(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)6:
			if (GJPDOHGJOLC.x > 1736f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(365f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(751f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Left:
			if (GJPDOHGJOLC.x > 1682f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(327f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1215f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private Vector2 MPIGKFPMJFG(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)7:
			if (GJPDOHGJOLC.x > 455f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(807f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1364f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case (Direction)8:
			if (GJPDOHGJOLC.x > 483f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1374f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1341f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private Vector2 FBNHAKGAHHJ(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)5:
			if (GJPDOHGJOLC.x > 281f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(251f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(389f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Left:
			if (GJPDOHGJOLC.x > 833f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(16f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(649f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NinjaChallengeEvent/Lose 2"))
		{
			PlayerController.GetPlayer(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			PlayerController.GetPlayer(6).additionalDisplacement.Add(this);
		}
	}

	private void CMMHCNOAFCI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Not enough money"))
		{
			PlayerController.OPHDCMJLLEC(4).additionalDisplacement.Add(this);
		}
	}

	private void HJIJHEONIIG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" NPCAnimation: direction changed to "))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Compressed file doesn't exist: "))
		{
			PlayerController.GetPlayer(3).additionalDisplacement.Remove(this);
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIVertical"))
		{
			PlayerController.GetPlayer(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("FishCuttingEvent/Lose1"))
		{
			PlayerController.GetPlayer(2).additionalDisplacement.Add(this);
		}
	}

	public virtual Vector2 MADFBNKCKCO(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DisplacementType displacementType = type;
		if (displacementType != 0)
		{
			if (displacementType == DisplacementType.Ramp)
			{
				return KCMANDLDEIJ(ANJLGNHMKAO, GJPDOHGJOLC);
			}
			return Vector2.zero;
		}
		return LIAKPAPJGFF(ANJLGNHMKAO);
	}

	private Vector2 KFIMNDLJELC(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == (Direction)6 && direction == Direction.Up)
		{
			return displacement * 1941f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == (Direction)6)
		{
			return displacement * 1670f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 653f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 455f;
		}
		return Vector2.zero;
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Pause"))
		{
			PlayerController.GetPlayer(3).additionalDisplacement.Add(this);
		}
	}

	private Vector2 HGOINFHBAFC(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Left:
			if (GJPDOHGJOLC.x > 1606f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(794f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(976f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Right:
			if (GJPDOHGJOLC.x > 1667f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(665f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1056f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void NLJMNADCDIN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" will be destroyed by "))
		{
			PlayerController.GetPlayer(1).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("k"))
		{
			PlayerController.OPHDCMJLLEC(8).additionalDisplacement.Remove(this);
		}
	}

	public virtual Vector2 JFKHDIGBFFD(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => GLCHCNMPFOF(ANJLGNHMKAO), 
			DisplacementType.Arc => IPODGDLBBJJ(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Right"))
		{
			PlayerController.GetPlayer(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("StopMusic/ButtonImmediately"))
		{
			PlayerController.GetPlayer(4).additionalDisplacement.Add(this);
		}
	}

	private void GAANFGOOBGC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Perks/playerPerk_name_"))
		{
			PlayerController.GetPlayer(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Sweet"))
		{
			PlayerController.OPHDCMJLLEC(5).additionalDisplacement.Add(this);
		}
	}

	private Vector2 GDMMIDBMMAP(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Up:
			if (GJPDOHGJOLC.x > 1894f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1422f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1499f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Down:
			if (GJPDOHGJOLC.x > 1619f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(173f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1024f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	public virtual Vector2 JJOFKLMMGKN(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => EKKLEKIIJEO(ANJLGNHMKAO), 
			DisplacementType.Arc => EMADKOEPIJP(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private Vector2 JKGLKBIHKCP(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Right:
			if (GJPDOHGJOLC.x > 1843f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(626f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(598f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Diagonal:
			if (GJPDOHGJOLC.x > 1336f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1397f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(63f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Interact"))
		{
			PlayerController.GetPlayer(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Invite region: "))
		{
			PlayerController.GetPlayer(8).additionalDisplacement.Add(this);
		}
	}

	private Vector2 IPODGDLBBJJ(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)5:
			if (GJPDOHGJOLC.x > 513f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(653f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(59f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Down:
			if (GJPDOHGJOLC.x > 1427f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(516f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(408f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	public virtual Vector2 GJHNCBOPFMK(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => KEACINMBNKD(ANJLGNHMKAO), 
			DisplacementType.Arc => BFMICMFLLNC(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private void JDFDGHGMIEO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Item NULL in index "))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Farm/Arthur/Main"))
		{
			PlayerController.GetPlayer(6).additionalDisplacement.Remove(this);
		}
	}

	public virtual Vector2 GGJFJLEENNI(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DisplacementType displacementType = type;
		if (displacementType != 0)
		{
			if (displacementType == DisplacementType.Ramp)
			{
				return EADKKOLOMMF(ANJLGNHMKAO, GJPDOHGJOLC);
			}
			return Vector2.zero;
		}
		return PLBOKHOPECO(ANJLGNHMKAO);
	}

	private Vector2 PKCGOEABEIM(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Left && direction == Direction.Up)
		{
			return displacement * 1153f;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == (Direction)5)
		{
			return displacement * 1339f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1653f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1937f;
		}
		return Vector2.zero;
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Reputation decreased..."))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Granting item "))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Add(this);
		}
	}

	private void ENKFHHEMHGG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Comfort"))
		{
			PlayerController.GetPlayer(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Sending finish minigame"))
		{
			PlayerController.OPHDCMJLLEC(7).additionalDisplacement.Remove(this);
		}
	}

	private Vector2 BFMICMFLLNC(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)5:
			if (GJPDOHGJOLC.x > 557f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(340f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(211f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case (Direction)7:
			if (GJPDOHGJOLC.x > 185f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1777f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(980f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Initial DevConsole message: "))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TooCold/Entry/2/Dialogue Text"))
		{
			PlayerController.GetPlayer(3).additionalDisplacement.Add(this);
		}
	}

	private Vector2 NDCDOMOBKMK(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == (Direction)6 && direction == (Direction)5)
		{
			return displacement * 1963f;
		}
		if (ANJLGNHMKAO == Direction.Diagonal && direction == (Direction)7)
		{
			return displacement * 1945f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 423f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 856f;
		}
		return Vector2.zero;
	}

	private Vector2 FACOHABFPHC(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == (Direction)7)
		{
			return displacement * 737f;
		}
		if (ANJLGNHMKAO == (Direction)8 && direction == Direction.Up)
		{
			return displacement * 1734f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1026f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 1886f;
		}
		return Vector2.zero;
	}

	private Vector2 FANOBJLHKCE(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Left && direction == Direction.Right)
		{
			return displacement * 516f;
		}
		if (ANJLGNHMKAO == Direction.Diagonal && direction == Direction.Left)
		{
			return displacement * 1638f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1788f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 635f;
		}
		return Vector2.zero;
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			PlayerController.GetPlayer(1).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			PlayerController.GetPlayer(2).additionalDisplacement.Remove(this);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			PlayerController.GetPlayer(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			PlayerController.GetPlayer(2).additionalDisplacement.Add(this);
		}
	}

	private Vector2 EKKLEKIIJEO(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Diagonal && direction == Direction.Left)
		{
			return displacement * 294f;
		}
		if (ANJLGNHMKAO == (Direction)6 && direction == Direction.Up)
		{
			return displacement * 938f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 76f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 1345f;
		}
		return Vector2.zero;
	}

	private Vector2 LNOKOECEPEK(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == (Direction)7)
		{
			return displacement * 1546f;
		}
		if (ANJLGNHMKAO == (Direction)6 && direction == Direction.Up)
		{
			return displacement * 215f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 417f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 933f;
		}
		return Vector2.zero;
	}

	private Vector2 FENPNJFFAKK(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Diagonal)
		{
			return displacement * 1706f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == (Direction)6)
		{
			return displacement * 1487f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1226f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 1834f;
		}
		return Vector2.zero;
	}

	private Vector2 NCIHBAIPALF(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Right:
			if (GJPDOHGJOLC.x > 1179f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(618f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1813f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case (Direction)5:
			if (GJPDOHGJOLC.x > 65f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(216f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(367f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void LFPJOBMFDAC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("HalloweenEvent"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("LoveB&H"))
		{
			PlayerController.OPHDCMJLLEC(5).additionalDisplacement.Add(this);
		}
	}

	public virtual Vector2 NAJKHNCKLBG(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => PKCGOEABEIM(ANJLGNHMKAO), 
			DisplacementType.Arc => NCIHBAIPALF(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(". Time since startup: "))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Move Forward"))
		{
			PlayerController.GetPlayer(3).additionalDisplacement.Remove(this);
		}
	}

	private Vector2 MFNMELLAHKB(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == (Direction)8)
		{
			return displacement * 1486f;
		}
		if (ANJLGNHMKAO == Direction.Left && direction == Direction.Left)
		{
			return displacement * 1878f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 1278f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 275f;
		}
		return Vector2.zero;
	}

	public virtual Vector2 PFDHJJACHKA(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => MFNMELLAHKB(ANJLGNHMKAO), 
			DisplacementType.Arc => EADKKOLOMMF(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	public virtual Vector2 PHMBKHLFPAP(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => KFIMNDLJELC(ANJLGNHMKAO), 
			DisplacementType.Arc => NCIHBAIPALF(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private void KGAPHAIFAFH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("DisableAllCustomers"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("petshop travelling"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
	}

	public virtual Vector2 DJGAHDBIKCK(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DisplacementType displacementType = type;
		if (displacementType != 0)
		{
			if (displacementType == DisplacementType.Ramp)
			{
				return FBNHAKGAHHJ(ANJLGNHMKAO, GJPDOHGJOLC);
			}
			return Vector2.zero;
		}
		return FACOHABFPHC(ANJLGNHMKAO);
	}

	public virtual Vector2 MDAHBBGIBMD(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => FACOHABFPHC(ANJLGNHMKAO), 
			DisplacementType.Arc => KCMANDLDEIJ(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private Vector2 IKDEPHNBELM(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		if (ANJLGNHMKAO == Direction.Up)
		{
			if (GJPDOHGJOLC.x > 215f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(563f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(435f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		}
		if (ANJLGNHMKAO == Direction.Up)
		{
			if (GJPDOHGJOLC.x > 758f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1211f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(702f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		}
		return Vector2.zero;
	}

	private void CENNMFKEOED(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1104"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("\n \n"))
		{
			PlayerController.GetPlayer(7).additionalDisplacement.Remove(this);
		}
	}

	private Vector2 LMOAFELGOJK(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Up:
			if (GJPDOHGJOLC.x > 872f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(534f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(684f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case (Direction)7:
			if (GJPDOHGJOLC.x > 1769f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(729f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(543f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Eating"))
		{
			PlayerController.GetPlayer(7).additionalDisplacement.Add(this);
		}
	}

	private void PMLKGEDCLBL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("' no referencia correctamente al item '"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("inviteFromDifferentRegion"))
		{
			PlayerController.GetPlayer(8).additionalDisplacement.Add(this);
		}
	}

	public virtual Vector2 OFDENADKKAN(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DisplacementType displacementType = type;
		if (displacementType != 0)
		{
			if (displacementType == DisplacementType.Ramp)
			{
				return IKDEPHNBELM(ANJLGNHMKAO, GJPDOHGJOLC);
			}
			return Vector2.zero;
		}
		return PECIDFBMLGP(ANJLGNHMKAO);
	}

	private Vector2 GKOGJBDICLL(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Left && direction == Direction.Right)
		{
			return displacement * -1f;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == Direction.Left)
		{
			return displacement * -1f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * -1f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * -1f;
		}
		return Vector2.zero;
	}

	public virtual Vector2 MAGHJNKMDIG(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DisplacementType displacementType = type;
		if (displacementType != 0)
		{
			if (displacementType == DisplacementType.Ramp)
			{
				return MHCKPHPLGPA(ANJLGNHMKAO, GJPDOHGJOLC);
			}
			return Vector2.zero;
		}
		return MFNMELLAHKB(ANJLGNHMKAO);
	}

	private void LBJEAHNNMCN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			PlayerController.OPHDCMJLLEC(7).additionalDisplacement.Remove(this);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Use"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Direction"))
		{
			PlayerController.OPHDCMJLLEC(4).additionalDisplacement.Add(this);
		}
	}

	private Vector2 NBNKIKGMCFG(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == (Direction)8)
		{
			return displacement * 90f;
		}
		if (ANJLGNHMKAO == Direction.Left && direction == (Direction)8)
		{
			return displacement * 1195f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 518f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1298f;
		}
		return Vector2.zero;
	}

	private Vector2 DMDIBOINACE(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == (Direction)8 && direction == (Direction)8)
		{
			return displacement * 1388f;
		}
		if (ANJLGNHMKAO == (Direction)5 && direction == Direction.Left)
		{
			return displacement * 1925f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1949f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 553f;
		}
		return Vector2.zero;
	}

	private Vector2 ACEGOLGLEIH(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Left:
			if (GJPDOHGJOLC.x > 0f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(0f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(0f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Right:
			if (GJPDOHGJOLC.x > 0f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(0f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(0f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private Vector2 DNNOBCCBGML(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 114f;
		}
		if (ANJLGNHMKAO == Direction.Diagonal && direction == (Direction)8)
		{
			return displacement * 831f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1050f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 428f;
		}
		return Vector2.zero;
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReputationBuildMode"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Hurt"))
		{
			PlayerController.GetPlayer(1).additionalDisplacement.Add(this);
		}
	}

	private Vector2 KCMANDLDEIJ(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)8:
			if (GJPDOHGJOLC.x > 542f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1453f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(195f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Left:
			if (GJPDOHGJOLC.x > 666f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1642f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(420f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void ONNMDGBPGEI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Sony DualSense"))
		{
			PlayerController.GetPlayer(0).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Gass_Stand/Entry/10/Dialogue Text"))
		{
			PlayerController.OPHDCMJLLEC(6).additionalDisplacement.Add(this);
		}
	}

	private Vector2 EMADKOEPIJP(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)5:
			if (GJPDOHGJOLC.x > 1105f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(930f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1424f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Diagonal:
			if (GJPDOHGJOLC.x > 58f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(385f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(638f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void NHOPACFEAKA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Idle"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveOfferingUIOpened"))
		{
			PlayerController.GetPlayer(5).additionalDisplacement.Remove(this);
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[MinePipePuzzle] Recibido swap online: {0} <-> {1}"))
		{
			PlayerController.GetPlayer(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemBlackWort"))
		{
			PlayerController.GetPlayer(1).additionalDisplacement.Add(this);
		}
	}

	public virtual Vector2 GetDisplacement(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => GKOGJBDICLL(ANJLGNHMKAO), 
			DisplacementType.Arc => ACEGOLGLEIH(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private Vector2 LJGBLABENOG(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Down:
			if (GJPDOHGJOLC.x > 1161f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(581f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1469f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case Direction.Left:
			if (GJPDOHGJOLC.x > 1803f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(706f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1904f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Interact"))
		{
			PlayerController.OPHDCMJLLEC(0).additionalDisplacement.Remove(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("itemDragonFruitSeeds"))
		{
			PlayerController.GetPlayer(3).additionalDisplacement.Remove(this);
		}
	}

	private Vector2 KEACINMBNKD(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == (Direction)7 && direction == (Direction)5)
		{
			return displacement * 1747f;
		}
		if (ANJLGNHMKAO == Direction.Diagonal && direction == Direction.Left)
		{
			return displacement * 1105f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1445f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1781f;
		}
		return Vector2.zero;
	}

	private Vector2 AFKMPJNAFII(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == (Direction)8 && direction == Direction.Down)
		{
			return displacement * 750f;
		}
		if (ANJLGNHMKAO == Direction.Diagonal && direction == (Direction)8)
		{
			return displacement * 1048f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1924f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Up)
		{
			return displacement * 1559f;
		}
		return Vector2.zero;
	}

	private Vector2 DFPBLFFJCIG(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case Direction.Diagonal:
			if (GJPDOHGJOLC.x > 201f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1211f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(1389f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case (Direction)7:
			if (GJPDOHGJOLC.x > 193f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(344f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(452f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}

	public virtual Vector2 INPKNPPKPKD(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(type switch
		{
			DisplacementType.Ramp => PLBOKHOPECO(ANJLGNHMKAO), 
			DisplacementType.Arc => LMOAFELGOJK(ANJLGNHMKAO, GJPDOHGJOLC), 
			_ => Vector2.zero, 
		});
	}

	private Vector2 IBMHMJCGPBP(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == Direction.Up)
		{
			return displacement * 1982f;
		}
		if (ANJLGNHMKAO == Direction.Right && direction == Direction.Down)
		{
			return displacement * 1039f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Down)
		{
			return displacement * 95f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1252f;
		}
		return Vector2.zero;
	}

	private void LIEIDOIDBLJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemWater"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Can't find seat. Reason: Tavern Closed"))
		{
			PlayerController.OPHDCMJLLEC(1).additionalDisplacement.Add(this);
		}
	}

	private Vector2 LIAKPAPJGFF(Direction ANJLGNHMKAO)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		if (ANJLGNHMKAO == direction)
		{
			return displacement;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Diagonal)
		{
			return displacement * 1357f;
		}
		if (ANJLGNHMKAO == Direction.Down && direction == Direction.Right)
		{
			return displacement * 719f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1847f;
		}
		if (ANJLGNHMKAO == Direction.Up && direction == Direction.Up)
		{
			return displacement * 1834f;
		}
		return Vector2.zero;
	}

	public virtual Vector2 NBHGMFNAOGI(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DisplacementType displacementType = type;
		if (displacementType != 0)
		{
			if (displacementType == DisplacementType.Ramp)
			{
				return LJGBLABENOG(ANJLGNHMKAO, GJPDOHGJOLC);
			}
			return Vector2.zero;
		}
		return DMDIBOINACE(ANJLGNHMKAO);
	}

	private Vector2 MHCKPHPLGPA(Direction ANJLGNHMKAO, Vector2 GJPDOHGJOLC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		GJPDOHGJOLC -= Vector2.op_Implicit(((Component)this).transform.position);
		switch (ANJLGNHMKAO)
		{
		case (Direction)5:
			if (GJPDOHGJOLC.x > 1616f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(1964f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(364f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
		case (Direction)6:
			if (GJPDOHGJOLC.x > 75f)
			{
				return Vector2.Lerp(Vector2.zero, new Vector2(859f, 0f - displacement.y), GJPDOHGJOLC.x / horizontalSize);
			}
			GJPDOHGJOLC.x = Mathf.Abs(GJPDOHGJOLC.x);
			return Vector2.Lerp(Vector2.zero, new Vector2(251f, displacement.y), GJPDOHGJOLC.x / horizontalSize);
		default:
			return Vector2.zero;
		}
	}
}
