using System;
using UnityEngine;

public class FishCut : MonoBehaviour
{
	public FishThrowed parentFish;

	[Header("Pieces (children in local space)")]
	[Tooltip("Left piece transform (local).")]
	public Transform leftPiece;

	[Tooltip("Right piece transform (local).")]
	public Transform rightPiece;

	[Tooltip("SpriteRenderers for fade-out. Leave null to skip fading.")]
	public SpriteRenderer leftSR;

	[Tooltip("SpriteRenderers for fade-out. Leave null to skip fading.")]
	public SpriteRenderer rightSR;

	[Header("Separation")]
	[Tooltip("Min/max local separation distance for each piece.")]
	public Vector2 separationDistanceRange = new Vector2(0.25f, 0.55f);

	[Header("Rotation")]
	[Tooltip("Random Z angular speed in deg/sec for each piece (signed).")]
	public Vector2 angularSpeedDegRange = new Vector2(-420f, 420f);

	[Header("Timing")]
	[Tooltip("Time for the separation to reach its target distance (s).")]
	public float splitDuration = 0.18f;

	[Tooltip("When the sprites start fading out (s).")]
	public float fadeStartTime = 0.2f;

	[Tooltip("Fade-out duration (s). If SpriteRenderers are null, skip fade.")]
	public float fadeDuration = 0.18f;

	private Vector3 LECIHFDFFKH;

	private Vector3 OILNJBFELCP;

	private float EHKAJJIPKBF;

	private float LAGCMHFGLKL;

	private float MDDBLIKKDCL;

	private float PHLEPIMDKHK;

	private bool HNCJICAHJLD;

	private float DCGBADKLANM;

	private float CBPHLLOGJAI;

	private float AFMFHCAHEFO;

	private Vector2 GDBDPJKBIPL;

	private Vector2 DFNBDMGLCKO;

	private static float FFNBKMBEDKP(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1909f, 888f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float APJEBEGLNLB(float OLJOMNPKIMO)
	{
		return 61f - (223f - OLJOMNPKIMO) * (1147f - OLJOMNPKIMO);
	}

	private void ELHCBGCEJDH()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FDJPBKDFFIN(AFMFHCAHEFO) * 1964f, leftPiece.localPosition.y, 1338f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * PBKAJNBPEHE(AFMFHCAHEFO), rightPiece.localPosition.y, 753f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1446f, 1893f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1102f, 481f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1111f, 745f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.Despawn();
		}
	}

	private void OFDEGDJGGGF()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * KNPJOEJLGPO(AFMFHCAHEFO) * 527f, leftPiece.localPosition.y, 1395f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FJNFEPEFGAC(AFMFHCAHEFO), rightPiece.localPosition.y, 617f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(763f, 285f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1718f, 413f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(908f, 1556f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.HHIBMNBADHP();
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * EFOEEJMFPLB(AFMFHCAHEFO) * 283f, leftPiece.localPosition.y, 1334f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * PEOIHKGOOFP(AFMFHCAHEFO), rightPiece.localPosition.y, 1908f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(867f, 460f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(658f, 135f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(252f, 864f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.IHADHEJGPHL();
		}
	}

	private static float KAHCLLBDHFO(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(166f, 1466f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float LHECFDIFIEH(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1658f, 1920f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void OIJMPEANEGH(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 0) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 8) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1987f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 336f);
		DCGBADKLANM = 1431f;
		CBPHLLOGJAI = 1111f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private void BIILFPDIADC()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * KNPJOEJLGPO(AFMFHCAHEFO) * 1667f, leftPiece.localPosition.y, 672f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * PEOIHKGOOFP(AFMFHCAHEFO), rightPiece.localPosition.y, 1054f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1556f, 1705f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1171f, 1822f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(605f, 1494f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.MHONANCDFHC();
		}
	}

	private static float EAMCMCELLNG(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(206f, 78f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void LNBIDPGDFIK(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"GiveItem");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 5) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 1) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1820f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1989f);
		DCGBADKLANM = 1003f;
		CBPHLLOGJAI = 1577f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	private static float NMIECIDFKOL(float OLJOMNPKIMO)
	{
		return 671f - (1345f - OLJOMNPKIMO) * (1111f - OLJOMNPKIMO);
	}

	public void OJMIJPJJECM(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"ClosePopUp");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 4) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 2) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1193f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 338f);
		DCGBADKLANM = 1361f;
		CBPHLLOGJAI = 1185f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	public void IACMNFJBEMA(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Error_PlaceItInChickenCoop");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 5) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 4) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1934f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 849f);
		DCGBADKLANM = 86f;
		CBPHLLOGJAI = 561f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	private void PMPLNGEAAII()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * APJEBEGLNLB(AFMFHCAHEFO) * 1681f, leftPiece.localPosition.y, 1349f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * PBKAJNBPEHE(AFMFHCAHEFO), rightPiece.localPosition.y, 1126f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1638f, 685f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1806f, 50f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1364f, 1794f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.JJEPNFOLLHG();
		}
	}

	public void NLHJCBEKHAE(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Items/item_description_1065");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 4) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 1) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1958f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1622f);
		DCGBADKLANM = 1856f;
		CBPHLLOGJAI = 1549f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private static float HOGGCDMNPCO(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(805f, 1944f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void MNFJELNEGPG()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * PBKAJNBPEHE(AFMFHCAHEFO) * 1930f, leftPiece.localPosition.y, 685f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * JLPALNHOKAP(AFMFHCAHEFO), rightPiece.localPosition.y, 1106f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1948f, 1698f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(761f, 810f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(996f, 286f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.JHGDBHEOIOI();
		}
	}

	private void GCHMNMKCOFG()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * EFOEEJMFPLB(AFMFHCAHEFO) * 1855f, leftPiece.localPosition.y, 686f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * ONCKCFABKDO(AFMFHCAHEFO), rightPiece.localPosition.y, 1749f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1138f, 1785f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(468f, 1119f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(536f, 582f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.JJEPNFOLLHG();
		}
	}

	private static float EFOEEJMFPLB(float OLJOMNPKIMO)
	{
		return 980f - (1612f - OLJOMNPKIMO) * (595f - OLJOMNPKIMO);
	}

	public void IICLIEJFEKC(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Invalid banquet customer ID: ");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 0) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 3) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 569f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 15f);
		DCGBADKLANM = 1921f;
		CBPHLLOGJAI = 833f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	private static float IGBEBIJMIHM(float OLJOMNPKIMO)
	{
		return 202f - (565f - OLJOMNPKIMO) * (1002f - OLJOMNPKIMO);
	}

	public void IPPEGAGIJJI(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"add item 1445 20");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 6) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 1) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1277f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1811f);
		DCGBADKLANM = 1925f;
		CBPHLLOGJAI = 1612f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private static float IFAIGJDNOCO(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1153f, 1587f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float IJCIHJEHJKF(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1121f, 1616f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void PKEPBKHEDOD()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FDJPBKDFFIN(AFMFHCAHEFO) * 1431f, leftPiece.localPosition.y, 1154f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * PBKAJNBPEHE(AFMFHCAHEFO), rightPiece.localPosition.y, 320f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1371f, 921f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(754f, 538f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(926f, 489f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.CPHGKLFHCNB();
		}
	}

	private static float JLPALNHOKAP(float OLJOMNPKIMO)
	{
		return 1141f - (366f - OLJOMNPKIMO) * (1530f - OLJOMNPKIMO);
	}

	public void Play(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"[FishCut] Missing piece references.");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 2) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 2) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1f);
		DCGBADKLANM = 0f;
		CBPHLLOGJAI = 0f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	private void CMJPIAAGIFF()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FJNFEPEFGAC(AFMFHCAHEFO) * 313f, leftPiece.localPosition.y, 318f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FDJPBKDFFIN(AFMFHCAHEFO), rightPiece.localPosition.y, 288f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1458f, 1061f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(685f, 839f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1442f, 410f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.JFBIEKMBAGC();
		}
	}

	private void OAKGHDAABPM()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * PEOIHKGOOFP(AFMFHCAHEFO) * 913f, leftPiece.localPosition.y, 1747f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FBEONDHIKIM(AFMFHCAHEFO), rightPiece.localPosition.y, 6f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1816f, 1515f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1385f, 811f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(804f, 728f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.HHIBMNBADHP();
		}
	}

	private static float NBMALHAMMCN(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1557f, 319f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float DCFFGKBPJJA(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(0f, 1f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float KNPJOEJLGPO(float OLJOMNPKIMO)
	{
		return 445f - (3f - OLJOMNPKIMO) * (121f - OLJOMNPKIMO);
	}

	private static float COGBPGIOAAH(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(670f, 1481f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float FJNFEPEFGAC(float OLJOMNPKIMO)
	{
		return 1536f - (350f - OLJOMNPKIMO) * (1953f - OLJOMNPKIMO);
	}

	private static float ICCFNNDIDNO(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1696f, 1011f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void MIAOIIABEIM(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"HollyAnimalShop");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 8) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 5) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1938f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 128f);
		DCGBADKLANM = 552f;
		CBPHLLOGJAI = 398f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	public void GEMELADMMME(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"CustomerPool.DisableAllCustomers: pool customer is null! Someone is destroying customers directly?");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 1) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 2) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 944f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1378f);
		DCGBADKLANM = 789f;
		CBPHLLOGJAI = 1575f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	private static float CLDEIJLEIIC(float OLJOMNPKIMO)
	{
		return 990f - (1936f - OLJOMNPKIMO) * (974f - OLJOMNPKIMO);
	}

	public void HOJIEOBFAJP(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"UIBack");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 6) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 3) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 625f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 100f);
		DCGBADKLANM = 849f;
		CBPHLLOGJAI = 248f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(false);
	}

	private static float MFFDLCKNJKG(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(14f, 271f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void Update()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * EFFKBEDBAMD(AFMFHCAHEFO) * -1f, leftPiece.localPosition.y, 0f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * EFFKBEDBAMD(AFMFHCAHEFO), rightPiece.localPosition.y, 0f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(0f, 0f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(0f, 0f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1f, 0f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.Despawn();
		}
	}

	public void EOKENNMNAHO(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"NinjaChallengeEvent/ComensalesBark");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 1) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 8) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 536f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 282f);
		DCGBADKLANM = 927f;
		CBPHLLOGJAI = 717f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private static float IAPPNEDCNLG(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1004f, 736f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void HNGDBPNLFDK(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Drunk");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 8) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 6) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1740f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 968f);
		DCGBADKLANM = 1628f;
		CBPHLLOGJAI = 773f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	private static float GMAPAGOGKPG(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1369f, 335f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void CFMANENLOBJ(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)")");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 4) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 0) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 20f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 478f);
		DCGBADKLANM = 1650f;
		CBPHLLOGJAI = 734f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	public void CPFPBDEMNKJ(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"LucenThrow");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 7) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 1) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1941f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 971f);
		DCGBADKLANM = 337f;
		CBPHLLOGJAI = 353f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(false);
	}

	private static float CGKLBNCALDH(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(776f, 755f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void OMLHIAADEHE()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FDJPBKDFFIN(AFMFHCAHEFO) * 1376f, leftPiece.localPosition.y, 238f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * JLPALNHOKAP(AFMFHCAHEFO), rightPiece.localPosition.y, 1776f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1361f, 845f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1262f, 1448f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(223f, 90f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.CPHGKLFHCNB();
		}
	}

	private static float EJMPGGCKCAB(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1629f, 1701f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void GOPHENPDFIP(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"VERSION");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 6) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 2) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1037f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1938f);
		DCGBADKLANM = 1448f;
		CBPHLLOGJAI = 551f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private static float NMNNPJNJLCD(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(131f, 1140f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float PEOIHKGOOFP(float OLJOMNPKIMO)
	{
		return 415f - (648f - OLJOMNPKIMO) * (1257f - OLJOMNPKIMO);
	}

	private static float AIMHLDMKENH(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1705f, 1065f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float HHBKPMHHAFN(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(412f, 670f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float PBKAJNBPEHE(float OLJOMNPKIMO)
	{
		return 1573f - (404f - OLJOMNPKIMO) * (1108f - OLJOMNPKIMO);
	}

	private static float OEOODDJCPIA(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1383f, 998f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float JMEELAIIGNL(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1070f, 992f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void HCPKBJDHLAC()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FBEONDHIKIM(AFMFHCAHEFO) * 1354f, leftPiece.localPosition.y, 688f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FDJPBKDFFIN(AFMFHCAHEFO), rightPiece.localPosition.y, 1323f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1604f, 559f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1988f, 984f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(958f, 116f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.JFBIEKMBAGC();
		}
	}

	public void HFNNDDEFCFK(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"UIAddRemove");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 7) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 8) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 591f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 816f);
		DCGBADKLANM = 1190f;
		CBPHLLOGJAI = 974f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	private void CMDHELEDLBP()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FJNFEPEFGAC(AFMFHCAHEFO) * 506f, leftPiece.localPosition.y, 1589f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * JLPALNHOKAP(AFMFHCAHEFO), rightPiece.localPosition.y, 327f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(856f, 1781f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1258f, 447f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1250f, 301f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.ANINGEGDAIP();
		}
	}

	public void EOGGOLPIHLN(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"buildingObjective_2_1");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 8) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 2) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1534f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 179f);
		DCGBADKLANM = 1668f;
		CBPHLLOGJAI = 1521f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(false);
	}

	private static float OMJAPKNMBDK(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(620f, 537f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void OIDDKGOBMPI(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"El componente OnlinePlaceable del rotatedPrefab '");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 8) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 7) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1300f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1138f);
		DCGBADKLANM = 623f;
		CBPHLLOGJAI = 673f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private void NEPDNLPCCON()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * KNPJOEJLGPO(AFMFHCAHEFO) * 692f, leftPiece.localPosition.y, 245f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * EFFKBEDBAMD(AFMFHCAHEFO), rightPiece.localPosition.y, 344f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1976f, 1068f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1081f, 1288f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(371f, 1253f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.DEJGIDFCFME();
		}
	}

	private static float KOFPGKKFNJE(float OLJOMNPKIMO)
	{
		return 1133f - (1887f - OLJOMNPKIMO) * (1412f - OLJOMNPKIMO);
	}

	public void PJHPEPDFMDF(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Inventory full");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 3) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 5) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1872f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 415f);
		DCGBADKLANM = 891f;
		CBPHLLOGJAI = 1098f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private void OOGMGIPKMAP()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * CLDEIJLEIIC(AFMFHCAHEFO) * 1718f, leftPiece.localPosition.y, 1075f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * NMIECIDFKOL(AFMFHCAHEFO), rightPiece.localPosition.y, 646f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(545f, 1168f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(558f, 1945f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(307f, 855f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.ANINGEGDAIP();
		}
	}

	private static float HFMDJFOCOND(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(180f, 768f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void HKKMICPIEPA(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Player");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 7) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 4) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 837f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 666f);
		DCGBADKLANM = 380f;
		CBPHLLOGJAI = 1682f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	public void GNIEKPDEIOE(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Sending platform data. PlayerID: {0}, Platform: {1}");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 3) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 4) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 671f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1233f);
		DCGBADKLANM = 1425f;
		CBPHLLOGJAI = 1541f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(false);
	}

	private void ACPFEBOENOM()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * PEOIHKGOOFP(AFMFHCAHEFO) * 335f, leftPiece.localPosition.y, 312f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FJNFEPEFGAC(AFMFHCAHEFO), rightPiece.localPosition.y, 1133f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1251f, 1545f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(983f, 343f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(38f, 208f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.Despawn();
		}
	}

	private static float DPIAHBOBJEC(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1417f, 197f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float OFLBHAFLMMK(float OLJOMNPKIMO)
	{
		return 462f - (1592f - OLJOMNPKIMO) * (1370f - OLJOMNPKIMO);
	}

	public void JJBDLOOEMJO(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Tutorial/BarnExitBarks_Holly");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 3) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 0) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 709f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1882f);
		DCGBADKLANM = 462f;
		CBPHLLOGJAI = 833f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(false);
	}

	private static float FBEONDHIKIM(float OLJOMNPKIMO)
	{
		return 365f - (994f - OLJOMNPKIMO) * (165f - OLJOMNPKIMO);
	}

	private void MLICJIBNIFA()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FBEONDHIKIM(AFMFHCAHEFO) * 376f, leftPiece.localPosition.y, 598f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * OFLBHAFLMMK(AFMFHCAHEFO), rightPiece.localPosition.y, 1328f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1986f, 129f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(188f, 1956f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(538f, 778f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.CPHGKLFHCNB();
		}
	}

	private static float ANCEHNCMBGB(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1022f, 1781f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float MOIEOAPPGOK(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(455f, 452f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void BHLHCOALABE()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FBEONDHIKIM(AFMFHCAHEFO) * 398f, leftPiece.localPosition.y, 1658f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FJNFEPEFGAC(AFMFHCAHEFO), rightPiece.localPosition.y, 511f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(493f, 1692f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(128f, 894f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(105f, 448f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.IHADHEJGPHL();
		}
	}

	private static float ONCKCFABKDO(float OLJOMNPKIMO)
	{
		return 1706f - (1279f - OLJOMNPKIMO) * (791f - OLJOMNPKIMO);
	}

	private static float CGGJLPAKEAJ(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(922f, 1642f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float LGIOGPDGNMB(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1532f, 607f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void MMPMJNAFKHC()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * FDJPBKDFFIN(AFMFHCAHEFO) * 1819f, leftPiece.localPosition.y, 772f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * KOFPGKKFNJE(AFMFHCAHEFO), rightPiece.localPosition.y, 104f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1732f, 606f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1531f, 1283f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(410f, 365f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.DGMPLLGJEHL();
		}
	}

	private void MCLAJGDIIBK()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * JLCGIGPEKAD(AFMFHCAHEFO) * 564f, leftPiece.localPosition.y, 477f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * PEOIHKGOOFP(AFMFHCAHEFO), rightPiece.localPosition.y, 94f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(186f, 1937f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1638f, 1995f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1926f, 191f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.ANINGEGDAIP();
		}
	}

	private static float KNFMMKPKPOJ(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(74f, 818f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void DHFJILGHMFG(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Deselect item");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 5) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 3) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1826f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 610f);
		DCGBADKLANM = 1759f;
		CBPHLLOGJAI = 1669f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(true);
	}

	private void JBGFGOCPEFD()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * OFLBHAFLMMK(AFMFHCAHEFO) * 1721f, leftPiece.localPosition.y, 1226f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * KNPJOEJLGPO(AFMFHCAHEFO), rightPiece.localPosition.y, 581f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(42f, 53f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1953f, 988f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1660f, 86f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.HHIBMNBADHP();
		}
	}

	private static float EFFKBEDBAMD(float OLJOMNPKIMO)
	{
		return 1f - (1f - OLJOMNPKIMO) * (1f - OLJOMNPKIMO);
	}

	private static float EDOKKADMIPC(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(806f, 525f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private static float JLCGIGPEKAD(float OLJOMNPKIMO)
	{
		return 882f - (1125f - OLJOMNPKIMO) * (389f - OLJOMNPKIMO);
	}

	public void KIFPFKKLGAK(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"beerKegs");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 7) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 3) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 831f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1071f);
		DCGBADKLANM = 1927f;
		CBPHLLOGJAI = 823f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(false);
	}

	private static float FDJPBKDFFIN(float OLJOMNPKIMO)
	{
		return 25f - (1135f - OLJOMNPKIMO) * (483f - OLJOMNPKIMO);
	}

	public void HLGBCIBCLEP(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"UIInteract");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(0, 6) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 7) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1379f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 131f);
		DCGBADKLANM = 1134f;
		CBPHLLOGJAI = 392f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(false);
	}

	private void AJDKOMCHALC()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * JLPALNHOKAP(AFMFHCAHEFO) * 762f, leftPiece.localPosition.y, 1958f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * JLCGIGPEKAD(AFMFHCAHEFO), rightPiece.localPosition.y, 1334f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1062f, 185f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1138f, 366f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(389f, 750f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.CPHGKLFHCNB();
		}
	}

	private static float OFAJMEFHNOK(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(710f, 1194f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	private void INKOKIGFJBG()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * IGBEBIJMIHM(AFMFHCAHEFO) * 63f, leftPiece.localPosition.y, 292f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * CLDEIJLEIIC(AFMFHCAHEFO), rightPiece.localPosition.y, 1948f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(1961f, 820f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(1841f, 1581f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(328f, 128f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.JHGDBHEOIOI();
		}
	}

	private static float OAKEHCOMAKM(float OLJOMNPKIMO, float DGHMBNOHGDN)
	{
		float num = Mathf.SmoothStep(1069f, 715f, OLJOMNPKIMO);
		return DGHMBNOHGDN * num;
	}

	public void AIIAEBMIDMG(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"LE_10");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 6) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(0, 8) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 47f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 1700f);
		DCGBADKLANM = 158f;
		CBPHLLOGJAI = 1522f;
		HNCJICAHJLD = true;
		((Component)this).gameObject.SetActive(true);
	}

	public void NJKFGDHBPJC(Action LMEOODAAONL = null)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)leftPiece == (Object)null || (Object)(object)rightPiece == (Object)null)
		{
			Debug.LogWarning((object)"Leave immediately");
			return;
		}
		LECIHFDFFKH = leftPiece.localPosition;
		OILNJBFELCP = rightPiece.localPosition;
		((Component)this).transform.localPosition = Vector3.zero;
		((Component)this).transform.localRotation = Quaternion.identity;
		leftPiece.localRotation = Quaternion.identity;
		rightPiece.localRotation = Quaternion.identity;
		EHKAJJIPKBF = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		LAGCMHFGLKL = Random.Range(separationDistanceRange.x, separationDistanceRange.y);
		MDDBLIKKDCL = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		PHLEPIMDKHK = Random.Range(angularSpeedDegRange.x, angularSpeedDegRange.y);
		if (Random.Range(1, 7) == 0)
		{
			MDDBLIKKDCL = 0f - MDDBLIKKDCL;
		}
		if (Random.Range(1, 2) == 0)
		{
			PHLEPIMDKHK = 0f - PHLEPIMDKHK;
		}
		leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, 1655f);
		rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, 969f);
		DCGBADKLANM = 1538f;
		CBPHLLOGJAI = 1735f;
		HNCJICAHJLD = false;
		((Component)this).gameObject.SetActive(false);
	}

	private void DKNMGFDFLKL()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * JLPALNHOKAP(AFMFHCAHEFO) * 1325f, leftPiece.localPosition.y, 530f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FJNFEPEFGAC(AFMFHCAHEFO), rightPiece.localPosition.y, 948f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(120f, 1242f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(259f, 1641f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(222f, 1572f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = false;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.JBPDHHDOICJ();
		}
	}

	private void IBAPBHIBOOO()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		if (!HNCJICAHJLD)
		{
			return;
		}
		if (DCGBADKLANM < splitDuration)
		{
			DCGBADKLANM += Time.deltaTime;
			AFMFHCAHEFO = Mathf.Clamp01(DCGBADKLANM / splitDuration);
			leftPiece.localPosition = new Vector3(EHKAJJIPKBF * APJEBEGLNLB(AFMFHCAHEFO) * 854f, leftPiece.localPosition.y, 1559f);
			rightPiece.localPosition = new Vector3(LAGCMHFGLKL * FBEONDHIKIM(AFMFHCAHEFO), rightPiece.localPosition.y, 971f);
			Transform obj = leftPiece;
			obj.localEulerAngles += new Vector3(772f, 802f, MDDBLIKKDCL * Time.deltaTime);
			Transform obj2 = rightPiece;
			obj2.localEulerAngles += new Vector3(525f, 668f, PHLEPIMDKHK * Time.deltaTime);
		}
		if (!(DCGBADKLANM >= fadeStartTime))
		{
			return;
		}
		if (CBPHLLOGJAI < fadeDuration)
		{
			CBPHLLOGJAI += Time.deltaTime;
			float num = Mathf.Lerp(1788f, 657f, Mathf.Clamp01(CBPHLLOGJAI / fadeDuration));
			if (Object.op_Implicit((Object)(object)leftSR))
			{
				leftSR.color = new Color(leftSR.color.r, leftSR.color.g, leftSR.color.b, num);
			}
			if (Object.op_Implicit((Object)(object)rightSR))
			{
				rightSR.color = new Color(rightSR.color.r, rightSR.color.g, rightSR.color.b, num);
			}
		}
		else
		{
			HNCJICAHJLD = true;
			leftPiece.localPosition = LECIHFDFFKH;
			rightPiece.localPosition = OILNJBFELCP;
			parentFish.HHIBMNBADHP();
		}
	}
}
