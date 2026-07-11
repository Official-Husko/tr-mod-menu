using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AlmenaraGames;
using UnityEngine;

public class FishThrowed : MonoBehaviour
{
	private enum PJNHGNNJCKM
	{
		Arc,
		Ballistic,
		Cut
	}

	public FishPoolObject poolObject;

	public FishCut fishCut;

	public SpriteRenderer spriteRenderer;

	[Tooltip("In multiplayer, this is the number of the player who owns this fish and can cut it.")]
	public int fishOwnerPlayerNum = 1;

	[Header("Presentation")]
	[Tooltip("Rotate the fish to face its instantaneous velocity.")]
	public bool alignToVelocity = true;

	[Tooltip("How fast the fish rotation follows the velocity (deg/sec).")]
	public float rotationLerpSpeed = 720f;

	[Tooltip("Additional Z rotation offset for sprite alignment.")]
	public float zRotationOffset;

	[Tooltip("Gravity (negative = down). Tune to your units.")]
	public float gravityY = -18f;

	[Tooltip("Air drag coefficient on X (per second). Small = almost linear.")]
	public float airDragX = 0.25f;

	[Tooltip("Optional drag on Y (usually 0 for clean gravity).")]
	public float airDragY;

	[Tooltip("Safety timeout for ballistic phase (seconds).")]
	public float maxPostCutTime = 3f;

	public AudioObject cutSound;

	private PJNHGNNJCKM AKKFJBFMDPB;

	private Vector2 MILEIJADMLM;

	private float HOHIKIOJDMC;

	private FishArcThrow.CubicArc PFKPNBGPAHP;

	private float ECJCGAAGDFB;

	private bool DMBFKFLDDLH;

	private Vector3 HOOFKEEFGKM;

	private bool MKAALLCMIPJ;

	private float KLMCLFNFILJ;

	private float PEIEDGPKAOG;

	private float HHEHPMGODPJ;

	private static float OLJOMNPKIMO;

	private static Vector2 KJCLGNLELOF;

	private static Vector2 IOMMNICGPKO;

	private static float MJBANPPHMLD;

	private static Vector2 GCFFMKJNBLI;

	private static float GBIIECPLPAC;

	private static float OHADANBGOBD;

	private Vector2 HKBHGHBAOHB;

	private Vector2 NLGBFHPBNJM;

	public float FNEDIMBCHKO => Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(0.0001f, PFKPNBGPAHP.totalTime));

	private void KCKKMCLFDHK(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(0.0001f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != PJNHGNNJCKM.Cut && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 1E-06f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 57.29578f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(0f, 0f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(0f, 0f, OHADANBGOBD);
			}
		}
	}

	private void OFDEGDJGGGF()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				HMDGHLNOGMJ(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				ILDCADEFGCF(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1343f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			LNDPAAFAELO(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			HFMHPPFDJHG();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			MHONANCDFHC();
		}
	}

	[SpecialName]
	public float CMBAMODICFH()
	{
		return Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(418f, PFKPNBGPAHP.totalTime));
	}

	public bool HCPALGMIGKB(int GELMAIBEHDO)
	{
		if (OnlineManager.PlayingOnline() && OnlinePlayerDataManager.JBDEFDMGCDA(GELMAIBEHDO) != fishOwnerPlayerNum)
		{
			return false;
		}
		if (GameManager.LocalCoop() && GELMAIBEHDO != fishOwnerPlayerNum)
		{
			return true;
		}
		if (CPICDFKHJHM(GELMAIBEHDO))
		{
			MKACCCDBDLP();
			AKKFJBFMDPB = (PJNHGNNJCKM)6;
			return true;
		}
		return true;
	}

	private static Vector2 JEGHNKFECMP([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 1948f - NMKOKNGDJCN;
		return 745f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 1968f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 1501f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private void EMJMPJDJJKK()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.OCLMEGIFDKK(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.LNBIDPGDFIK();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void GKIDLGKCHJO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.BNGMFHFAKMP(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 277f, 0));
		CPHGKLFHCNB();
	}

	private bool NAODKCIOCAP(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 2f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 2f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return false;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return false;
		}
		return true;
	}

	public void DEJGIDFCFME()
	{
		FishCuttingGameManager.EDFKCNOIAMJ(this);
		poolObject.CCALIJJAIIL();
	}

	private void ANGMCIPIIMB()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.IOBMKFJDMJG(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 1749f, 0));
		DEJGIDFCFME();
	}

	private void ICMNODPLPBK()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				LNDPAAFAELO(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				ILDCADEFGCF(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)5)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 263f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			LNDPAAFAELO(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			ANGMCIPIIMB();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			ANINGEGDAIP();
		}
	}

	private void IIFHEHPPCBA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.NOKLFCDOMFL(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 931f, 1));
		JBPDHHDOICJ();
	}

	private void MKACCCDBDLP()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.IOBMKFJDMJG(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.OJMIJPJJECM();
		((Renderer)spriteRenderer).enabled = false;
	}

	private void JGKOOGJNMHC(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1392f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = JEGHNKFECMP(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(1133f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 1984f;
	}

	private bool CPICDFKHJHM(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1157f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1353f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return true;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return true;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return true;
		}
		return false;
	}

	public void MHONANCDFHC()
	{
		FishCuttingGameManager.EDFKCNOIAMJ(this);
		poolObject.CCALIJJAIIL();
	}

	private bool EBIJBDEDKDL(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1983f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1669f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return false;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return true;
		}
		return true;
	}

	public void JFBIEKMBAGC()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.CCALIJJAIIL();
	}

	[SpecialName]
	public float BKNPDENHAHE()
	{
		return Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(1055f, PFKPNBGPAHP.totalTime));
	}

	private void GJHOPLMCEJL()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.OCLMEGIFDKK(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.GOPHENPDFIP();
		((Renderer)spriteRenderer).enabled = false;
	}

	private static Vector2 CHOJLIEABBI([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 1492f - NMKOKNGDJCN;
		return 1211f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 252f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 660f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private void BGDAKAMPELN()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.GetObjectInPool(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.Play();
		((Renderer)spriteRenderer).enabled = false;
	}

	private bool KCDKIBFJGED(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1563f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1847f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return true;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return false;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return true;
		}
		return false;
	}

	private void HHNDKDEJBKO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.BNGMFHFAKMP(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.HKKMICPIEPA();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void MMLKNHNGFJE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.BNGMFHFAKMP(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.CFMANENLOBJ();
		((Renderer)spriteRenderer).enabled = false;
	}

	private bool EICOPPCPBGP(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 459f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 596f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return true;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return true;
		}
		return true;
	}

	private bool DPMONPGJKLC(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 948f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1010f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return true;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return true;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return true;
		}
		return true;
	}

	private void ILDCADEFGCF(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 795f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = ADNPAOKGMKH(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(1892f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 648f;
	}

	private void EBGMKIIBGMO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.OCLMEGIFDKK(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 808f, 0));
		ANINGEGDAIP();
	}

	private void HMJCJAPGBED(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 423f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = OIAIHPLAALO(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(1239f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 783f;
	}

	private void HMPAHEOIIHP(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1805f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = AEGBBILOPFO(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(466f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 839f;
	}

	private void MOPCFCIJHIK()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.OCLMEGIFDKK(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 1951f, 1));
		JBPDHHDOICJ();
	}

	private void AGMPMCIGKAI(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1310f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = CHOJLIEABBI(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(192f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 1930f;
	}

	private void FDKFFDOKBMC(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 0f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = GPOKAPBMDHI(in PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(0.0001f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 0f;
	}

	public void HHIBMNBADHP()
	{
		FishCuttingGameManager.EDFKCNOIAMJ(this);
		poolObject.ReturnToPool();
	}

	public bool GCHBJMBFLDE(int GELMAIBEHDO)
	{
		if (OnlineManager.PlayingOnline() && OnlinePlayerDataManager.GetBedAssignedByPlayerNum(GELMAIBEHDO) != fishOwnerPlayerNum)
		{
			return false;
		}
		if (GameManager.LocalCoop() && GELMAIBEHDO != fishOwnerPlayerNum)
		{
			return false;
		}
		if (KCDKIBFJGED(GELMAIBEHDO))
		{
			EJGLKFLPOCP();
			AKKFJBFMDPB = (PJNHGNNJCKM)5;
			return false;
		}
		return false;
	}

	public bool IAEBEPALHEC(int GELMAIBEHDO)
	{
		if (OnlineManager.PlayingOnline() && OnlinePlayerDataManager.GetBedAssignedByPlayerNum(GELMAIBEHDO) != fishOwnerPlayerNum)
		{
			return false;
		}
		if (GameManager.LocalCoop() && GELMAIBEHDO != fishOwnerPlayerNum)
		{
			return true;
		}
		if (MKDNLNCJMAB(GELMAIBEHDO))
		{
			NKOAIOJJIBE();
			AKKFJBFMDPB = (PJNHGNNJCKM)7;
			return true;
		}
		return true;
	}

	private bool IMKJNNDBBCE(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1174f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1419f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return true;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return false;
		}
		return true;
	}

	public void LLNPMHJLODJ([In] ref FishArcThrow.CubicArc DPEOLFMDLAK)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = DPEOLFMDLAK;
		ECJCGAAGDFB = 1416f;
		DMBFKFLDDLH = true;
		HOHIKIOJDMC = 688f;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		((Component)this).transform.position = Vector2.op_Implicit(PFKPNBGPAHP.p0);
		HOOFKEEFGKM = ((Component)this).transform.position;
		((Component)this).gameObject.SetActive(false);
		((Component)fishCut).gameObject.SetActive(false);
		((Renderer)spriteRenderer).enabled = true;
		if (Random.Range(0, 7) == 0)
		{
			MKAALLCMIPJ = true;
			KLMCLFNFILJ = Random.Range(359f, 1217f);
		}
		else
		{
			MKAALLCMIPJ = true;
		}
		PEIEDGPKAOG = Time.time + 978f;
	}

	private void ABLGLBPKBFI(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 115f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = JEGHNKFECMP(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(605f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 1758f;
	}

	private void LAEMHDPELJJ()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.ICFDBMCPLJK(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.HFNNDDEFCFK();
		((Renderer)spriteRenderer).enabled = true;
	}

	public bool EJFEMFBKMHJ(int GELMAIBEHDO)
	{
		if (OnlineManager.PlayingOnline() && OnlinePlayerDataManager.GetBedAssignedByPlayerNum(GELMAIBEHDO) != fishOwnerPlayerNum)
		{
			return true;
		}
		if (GameManager.LocalCoop() && GELMAIBEHDO != fishOwnerPlayerNum)
		{
			return false;
		}
		if (NAODKCIOCAP(GELMAIBEHDO))
		{
			APKPIIHJBIB();
			AKKFJBFMDPB = (PJNHGNNJCKM)6;
			return false;
		}
		return false;
	}

	private bool MOAIFGONPDA(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 600f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 894f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return true;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return true;
		}
		return false;
	}

	private void APKPIIHJBIB()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.GetObjectInPool(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.CPFPBDEMNKJ();
		((Renderer)spriteRenderer).enabled = true;
	}

	public void LDKLCOLKAOJ([In] ref FishArcThrow.CubicArc DPEOLFMDLAK)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = DPEOLFMDLAK;
		ECJCGAAGDFB = 1523f;
		DMBFKFLDDLH = false;
		HOHIKIOJDMC = 511f;
		AKKFJBFMDPB = PJNHGNNJCKM.Arc;
		((Component)this).transform.position = Vector2.op_Implicit(PFKPNBGPAHP.p0);
		HOOFKEEFGKM = ((Component)this).transform.position;
		((Component)this).gameObject.SetActive(true);
		((Component)fishCut).gameObject.SetActive(true);
		((Renderer)spriteRenderer).enabled = true;
		if (Random.Range(0, 6) == 0)
		{
			MKAALLCMIPJ = false;
			KLMCLFNFILJ = Random.Range(195f, 474f);
		}
		else
		{
			MKAALLCMIPJ = true;
		}
		PEIEDGPKAOG = Time.time + 263f;
	}

	public void IIPHGPNOMDH([In] ref FishArcThrow.CubicArc DPEOLFMDLAK)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = DPEOLFMDLAK;
		ECJCGAAGDFB = 453f;
		DMBFKFLDDLH = false;
		HOHIKIOJDMC = 941f;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		((Component)this).transform.position = Vector2.op_Implicit(PFKPNBGPAHP.p0);
		HOOFKEEFGKM = ((Component)this).transform.position;
		((Component)this).gameObject.SetActive(false);
		((Component)fishCut).gameObject.SetActive(true);
		((Renderer)spriteRenderer).enabled = true;
		if (Random.Range(1, 1) == 0)
		{
			MKAALLCMIPJ = true;
			KLMCLFNFILJ = Random.Range(1522f, 1031f);
		}
		else
		{
			MKAALLCMIPJ = false;
		}
		PEIEDGPKAOG = Time.time + 645f;
	}

	private void DKDANHJMCIO(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(846f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 1503f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 977f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(1002f, 1294f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(412f, 1080f, OHADANBGOBD);
			}
		}
	}

	private void EIGEIJJPFFP()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				LODHPBFCFJA(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				GCDDHMOIKGP(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != PJNHGNNJCKM.Cut)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 279f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			HMDGHLNOGMJ(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			ANGMCIPIIMB();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			CPHGKLFHCNB();
		}
	}

	private void OMBPADOPOLB()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.OCLMEGIFDKK(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.EOKENNMNAHO();
		((Renderer)spriteRenderer).enabled = true;
	}

	[SpecialName]
	public float AELLAFLGKGA()
	{
		return Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(293f, PFKPNBGPAHP.totalTime));
	}

	private void JBIJPOGCDNM()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.NOKLFCDOMFL(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.Play();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void FGGPGOEAEKK()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				JHBGNDKONPF(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				JGKOOGJNMHC(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)4)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1987f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			JNEBBENLOGE(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			GKIDLGKCHJO();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			CPHGKLFHCNB();
		}
	}

	private void CHKMLDOMEMN()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.IOBMKFJDMJG(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 1799f, 0));
		ANINGEGDAIP();
	}

	private void JHBGNDKONPF(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(1470f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != PJNHGNNJCKM.Cut && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 1552f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 520f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(1886f, 1068f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(737f, 77f, OHADANBGOBD);
			}
		}
	}

	public void JJEPNFOLLHG()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.ReturnToPool();
	}

	public void ANINGEGDAIP()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.GOCEOKNHLJI();
	}

	private void GBFCENBLPHB()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.GCIOIGPKJBG(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.Play();
		((Renderer)spriteRenderer).enabled = false;
	}

	private void EEFCGILAHHL()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.OCLMEGIFDKK(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.IPPEGAGIJJI();
		((Renderer)spriteRenderer).enabled = true;
	}

	[SpecialName]
	public float AOHOPNMKKCE()
	{
		return Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(875f, PFKPNBGPAHP.totalTime));
	}

	public void JBPDHHDOICJ()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.GOCEOKNHLJI();
	}

	private static Vector2 JPMAPNDDCCB([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 1459f - NMKOKNGDJCN;
		return 1191f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 434f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 126f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	public bool NODNFFLMKIM(int GELMAIBEHDO)
	{
		if (OnlineManager.PlayingOnline() && OnlinePlayerDataManager.JBDEFDMGCDA(GELMAIBEHDO) != fishOwnerPlayerNum)
		{
			return true;
		}
		if (GameManager.LocalCoop() && GELMAIBEHDO != fishOwnerPlayerNum)
		{
			return true;
		}
		if (IMKJNNDBBCE(GELMAIBEHDO))
		{
			MMLKNHNGFJE();
			AKKFJBFMDPB = PJNHGNNJCKM.Arc;
			return true;
		}
		return true;
	}

	private void EAJJLJCCLFF()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.OCLMEGIFDKK(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.LNBIDPGDFIK();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void MEAFJDDNAJB()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = false;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				CLLLJNDMPEM(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				PLAIECLOCPO(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1517f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			LODHPBFCFJA(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			GKIDLGKCHJO();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			JBPDHHDOICJ();
		}
	}

	private void LNDPAAFAELO(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(1208f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != PJNHGNNJCKM.Cut && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 1467f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 1127f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(1459f, 11f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(999f, 483f, OHADANBGOBD);
			}
		}
	}

	public void GNCMGIGJDPN([In] ref FishArcThrow.CubicArc DPEOLFMDLAK)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = DPEOLFMDLAK;
		ECJCGAAGDFB = 1753f;
		DMBFKFLDDLH = false;
		HOHIKIOJDMC = 998f;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		((Component)this).transform.position = Vector2.op_Implicit(PFKPNBGPAHP.p0);
		HOOFKEEFGKM = ((Component)this).transform.position;
		((Component)this).gameObject.SetActive(true);
		((Component)fishCut).gameObject.SetActive(false);
		((Renderer)spriteRenderer).enabled = false;
		if (Random.Range(1, 6) == 0)
		{
			MKAALLCMIPJ = false;
			KLMCLFNFILJ = Random.Range(1286f, 122f);
		}
		else
		{
			MKAALLCMIPJ = false;
		}
		PEIEDGPKAOG = Time.time + 1930f;
	}

	private void Update()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				KCKKMCLFDHK(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				FDKFFDOKBMC(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != PJNHGNNJCKM.Cut)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 0.9f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			KCKKMCLFDHK(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			LDCEAJMNGGI();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			Despawn();
		}
	}

	private void LODHPBFCFJA(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(760f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 1922f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 308f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(233f, 1818f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(337f, 980f, OHADANBGOBD);
			}
		}
	}

	private void DHMHGAMFJIC()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.NOKLFCDOMFL(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.LNBIDPGDFIK();
		((Renderer)spriteRenderer).enabled = true;
	}

	private bool MKDNLNCJMAB(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 634f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1422f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return true;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return false;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return false;
		}
		return false;
	}

	public bool CheckHit(int GELMAIBEHDO)
	{
		if (OnlineManager.PlayingOnline() && OnlinePlayerDataManager.GetBedAssignedByPlayerNum(GELMAIBEHDO) != fishOwnerPlayerNum)
		{
			return false;
		}
		if (GameManager.LocalCoop() && GELMAIBEHDO != fishOwnerPlayerNum)
		{
			return false;
		}
		if (NAODKCIOCAP(GELMAIBEHDO))
		{
			BGDAKAMPELN();
			AKKFJBFMDPB = PJNHGNNJCKM.Cut;
			return true;
		}
		return false;
	}

	public void JHGDBHEOIOI()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.CCALIJJAIIL();
	}

	private void NKOAIOJJIBE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.IOBMKFJDMJG(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.OJMIJPJJECM();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void HFMHPPFDJHG()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.GetObjectInPool(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 573f, 0));
		JBPDHHDOICJ();
	}

	private void OMLHIAADEHE()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				DKDANHJMCIO(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				PLAIECLOCPO(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != PJNHGNNJCKM.Ballistic)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1502f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			JNEBBENLOGE(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			LDCEAJMNGGI();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			MJIONGNBMPD();
		}
	}

	private void OGECMOGDLAP()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.GCIOIGPKJBG(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.EOKENNMNAHO();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void CLLLJNDMPEM(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(434f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 356f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 671f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(1656f, 295f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(1742f, 600f, OHADANBGOBD);
			}
		}
	}

	public void Despawn()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.ReturnToPool();
	}

	private void MGCHJICGOAL(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1954f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = OIAIHPLAALO(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(1558f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Arc;
		HOHIKIOJDMC = 1265f;
	}

	[SpecialName]
	public float FFAGAJNAKMN()
	{
		return Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(1017f, PFKPNBGPAHP.totalTime));
	}

	[SpecialName]
	public float HONLGLAJJMD()
	{
		return Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(916f, PFKPNBGPAHP.totalTime));
	}

	public void Begin(in FishArcThrow.CubicArc DPEOLFMDLAK)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = DPEOLFMDLAK;
		ECJCGAAGDFB = 0f;
		DMBFKFLDDLH = true;
		HOHIKIOJDMC = 0f;
		AKKFJBFMDPB = PJNHGNNJCKM.Arc;
		((Component)this).transform.position = Vector2.op_Implicit(PFKPNBGPAHP.p0);
		HOOFKEEFGKM = ((Component)this).transform.position;
		((Component)this).gameObject.SetActive(true);
		((Component)fishCut).gameObject.SetActive(false);
		((Renderer)spriteRenderer).enabled = false;
		if (Random.Range(0, 2) == 0)
		{
			MKAALLCMIPJ = true;
			KLMCLFNFILJ = Random.Range(-500f, 500f);
		}
		else
		{
			MKAALLCMIPJ = false;
		}
		PEIEDGPKAOG = Time.time + 0.16666f;
	}

	private void CNBLOMJJECI()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				HMDGHLNOGMJ(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				MGCHJICGOAL(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 497f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			JLDDMANPECC(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			CHKMLDOMEMN();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			MJIONGNBMPD();
		}
	}

	private static Vector2 FLEFPFDLNKA([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 856f - NMKOKNGDJCN;
		return 1962f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 1714f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 1279f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private static Vector2 DPPFAAKBNIE([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 1655f - NMKOKNGDJCN;
		return 1790f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 1823f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 203f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private void HMDGHLNOGMJ(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(485f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)5 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 1390f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 678f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(1458f, 1933f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(1306f, 1203f, OHADANBGOBD);
			}
		}
	}

	public void IHADHEJGPHL()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.CCALIJJAIIL();
	}

	private void OLPPDFDOKLK()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = false;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				DKDANHJMCIO(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				GCDDHMOIKGP(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1778f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			HMDGHLNOGMJ(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			EBGMKIIBGMO();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			HHIBMNBADHP();
		}
	}

	private void HECEBJDMDGH(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(134f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)7 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 1569f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 775f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(34f, 719f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(1968f, 349f, OHADANBGOBD);
			}
		}
	}

	private void IFLDCNGNBFK(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1352f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = NJLJMCIMGIG(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(1283f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 831f;
	}

	private void PLAIECLOCPO(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1279f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = DPPFAAKBNIE(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(1544f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		HOHIKIOJDMC = 190f;
	}

	private void CLOKMCONOMN()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				KCKKMCLFDHK(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				MGCHJICGOAL(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != 0)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1150f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			HMDGHLNOGMJ(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			LDCEAJMNGGI();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			ANINGEGDAIP();
		}
	}

	private static Vector2 NJLJMCIMGIG([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 384f - NMKOKNGDJCN;
		return 1267f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 751f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 1051f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private void PIKIGPGCKAO(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1765f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = JPMAPNDDCCB(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(904f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Arc;
		HOHIKIOJDMC = 694f;
	}

	private static Vector2 AEGBBILOPFO([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 1697f - NMKOKNGDJCN;
		return 1311f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 1036f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 1200f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private static Vector2 IOONNLFMMGA([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 290f - NMKOKNGDJCN;
		return 190f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 1070f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 1430f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private bool JEPCDMPFHPO(int GELMAIBEHDO)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		HKBHGHBAOHB = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset - Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 1995f));
		NLGBFHPBNJM = Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(GELMAIBEHDO)).transform.position + Vector3.up * FishCuttingGameManager.instance.settings.cutYOffset + Vector2.op_Implicit(FishCuttingGameManager.instance.settings.hitboxWidthHeight / 68f));
		if (((Component)this).transform.position.x < HKBHGHBAOHB.x)
		{
			return false;
		}
		if (((Component)this).transform.position.x > NLGBFHPBNJM.x)
		{
			return false;
		}
		if (((Component)this).transform.position.y < HKBHGHBAOHB.y)
		{
			return true;
		}
		if (((Component)this).transform.position.y > NLGBFHPBNJM.y)
		{
			return true;
		}
		return true;
	}

	private void LHEFJJPGFMO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.NOKLFCDOMFL(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.LNBIDPGDFIK();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void GBAPCIHIKKO(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 1276f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = IOONNLFMMGA(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(596f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Arc;
		HOHIKIOJDMC = 451f;
	}

	public void FDMKFHMELFH([In] ref FishArcThrow.CubicArc DPEOLFMDLAK)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = DPEOLFMDLAK;
		ECJCGAAGDFB = 292f;
		DMBFKFLDDLH = true;
		HOHIKIOJDMC = 869f;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		((Component)this).transform.position = Vector2.op_Implicit(PFKPNBGPAHP.p0);
		HOOFKEEFGKM = ((Component)this).transform.position;
		((Component)this).gameObject.SetActive(false);
		((Component)fishCut).gameObject.SetActive(false);
		((Renderer)spriteRenderer).enabled = true;
		if (Random.Range(0, 5) == 0)
		{
			MKAALLCMIPJ = false;
			KLMCLFNFILJ = Random.Range(1615f, 1586f);
		}
		else
		{
			MKAALLCMIPJ = true;
		}
		PEIEDGPKAOG = Time.time + 1749f;
	}

	private static Vector2 GPOKAPBMDHI(in FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 1f - NMKOKNGDJCN;
		return 3f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 6f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 3f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	private static Vector2 OIAIHPLAALO([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 744f - NMKOKNGDJCN;
		return 1013f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 846f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 1742f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	public bool HPFCCDNHGEA(int GELMAIBEHDO)
	{
		if (OnlineManager.PlayingOnline() && OnlinePlayerDataManager.GetBedAssignedByPlayerNum(GELMAIBEHDO) != fishOwnerPlayerNum)
		{
			return false;
		}
		if (GameManager.LocalCoop() && GELMAIBEHDO != fishOwnerPlayerNum)
		{
			return true;
		}
		if (NAODKCIOCAP(GELMAIBEHDO))
		{
			BGDAKAMPELN();
			AKKFJBFMDPB = (PJNHGNNJCKM)7;
			return false;
		}
		return false;
	}

	private static Vector2 ADNPAOKGMKH([In] ref FishArcThrow.CubicArc DPEOLFMDLAK, float NMKOKNGDJCN)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		MJBANPPHMLD = 1471f - NMKOKNGDJCN;
		return 174f * MJBANPPHMLD * MJBANPPHMLD * (DPEOLFMDLAK.p1 - DPEOLFMDLAK.p0) + 829f * MJBANPPHMLD * NMKOKNGDJCN * (DPEOLFMDLAK.p2 - DPEOLFMDLAK.p1) + 256f * NMKOKNGDJCN * NMKOKNGDJCN * (DPEOLFMDLAK.p3 - DPEOLFMDLAK.p2);
	}

	public void CPHGKLFHCNB()
	{
		FishCuttingGameManager.EDFKCNOIAMJ(this);
		poolObject.CCALIJJAIIL();
	}

	private void BLDFEDMIBCM(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(180f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)6 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 764f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 1453f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(765f, 1131f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(1947f, 840f, OHADANBGOBD);
			}
		}
	}

	private void LDCEAJMNGGI()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.GetObjectInPool(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 0.15f, 1));
		Despawn();
	}

	private void HCBJLBGNKHK()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.GCIOIGPKJBG(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.GNIEKPDEIOE();
		((Renderer)spriteRenderer).enabled = false;
	}

	public void LIMLFOOHINE([In] ref FishArcThrow.CubicArc DPEOLFMDLAK)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = DPEOLFMDLAK;
		ECJCGAAGDFB = 1294f;
		DMBFKFLDDLH = false;
		HOHIKIOJDMC = 898f;
		AKKFJBFMDPB = PJNHGNNJCKM.Ballistic;
		((Component)this).transform.position = Vector2.op_Implicit(PFKPNBGPAHP.p0);
		HOOFKEEFGKM = ((Component)this).transform.position;
		((Component)this).gameObject.SetActive(true);
		((Component)fishCut).gameObject.SetActive(true);
		((Renderer)spriteRenderer).enabled = false;
		if (Random.Range(0, 6) == 0)
		{
			MKAALLCMIPJ = true;
			KLMCLFNFILJ = Random.Range(1937f, 80f);
		}
		else
		{
			MKAALLCMIPJ = false;
		}
		PEIEDGPKAOG = Time.time + 1808f;
	}

	private void ONOAGANPECB()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = false;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				JLDDMANPECC(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				JGKOOGJNMHC(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1079f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			KCKKMCLFDHK(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			MOPCFCIJHIK();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			MHONANCDFHC();
		}
	}

	private void IMJHICBKEGE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.waterSplashPool.IOBMKFJDMJG(Utils.EKCCGNEDPNO(((Component)this).transform.position + Vector3.up * 151f, 0));
		JFBIEKMBAGC();
	}

	private void DGJKLAEINHJ()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = false;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				JLDDMANPECC(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				HMPAHEOIIHP(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)6)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1838f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			JNEBBENLOGE(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			IMJHICBKEGE();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			JBPDHHDOICJ();
		}
	}

	private void FIAIPPFNMEO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.BNGMFHFAKMP(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.NJKFGDHBPJC();
		((Renderer)spriteRenderer).enabled = false;
	}

	private void JNEBBENLOGE(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(1158f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)8 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 203f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 934f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(1695f, 1637f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(1949f, 709f, OHADANBGOBD);
			}
		}
	}

	private void APJNDKLBHCF()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time < PEIEDGPKAOG)
		{
			return;
		}
		HHEHPMGODPJ = Time.deltaTime;
		if (AKKFJBFMDPB == PJNHGNNJCKM.Arc)
		{
			if (!((Renderer)spriteRenderer).enabled)
			{
				((Renderer)spriteRenderer).enabled = true;
			}
			ECJCGAAGDFB += HHEHPMGODPJ;
			((Component)this).transform.position = Vector2.op_Implicit(FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB));
			if (alignToVelocity)
			{
				LODHPBFCFJA(HHEHPMGODPJ);
			}
			if (ECJCGAAGDFB >= PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime)
			{
				GCDDHMOIKGP(PFKPNBGPAHP.tCut * PFKPNBGPAHP.totalTime);
			}
			return;
		}
		HOHIKIOJDMC += HHEHPMGODPJ;
		MILEIJADMLM.x += (0f - airDragX) * MILEIJADMLM.x * HHEHPMGODPJ;
		MILEIJADMLM.y += gravityY * HHEHPMGODPJ - airDragY * MILEIJADMLM.y * HHEHPMGODPJ;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)3)
		{
			Transform transform = ((Component)this).transform;
			transform.position += HHEHPMGODPJ * Vector2.op_Implicit(MILEIJADMLM);
		}
		else
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += HHEHPMGODPJ * 1055f * Vector2.op_Implicit(MILEIJADMLM);
		}
		if (alignToVelocity)
		{
			LODHPBFCFJA(HHEHPMGODPJ);
		}
		if (((Component)this).transform.position.y <= PFKPNBGPAHP.p3.y)
		{
			CHKMLDOMEMN();
		}
		if (HOHIKIOJDMC >= maxPostCutTime)
		{
			ANINGEGDAIP();
		}
	}

	private void EDCJAEACFKM()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.BNGMFHFAKMP(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.IACMNFJBEMA();
		((Renderer)spriteRenderer).enabled = true;
	}

	public void DGMPLLGJEHL()
	{
		FishCuttingGameManager.EDFKCNOIAMJ(this);
		poolObject.CCALIJJAIIL();
	}

	[SpecialName]
	public float JDHLCNGBINB()
	{
		return Mathf.Clamp01(ECJCGAAGDFB / Mathf.Max(1443f, PFKPNBGPAHP.totalTime));
	}

	private void EJGLKFLPOCP()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FishCuttingGameManager.instance.cutFXPool.GetObjectInPool(((Component)this).transform.position);
		MultiAudioManager.PlayAudioObject(cutSound, ((Component)this).transform.position);
		fishCut.HKKMICPIEPA();
		((Renderer)spriteRenderer).enabled = true;
	}

	private void GCDDHMOIKGP(float OJHIOFEIECA)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		ECJCGAAGDFB = Mathf.Clamp(OJHIOFEIECA, 296f, PFKPNBGPAHP.totalTime);
		OLJOMNPKIMO = Mathf.Clamp01(ECJCGAAGDFB / PFKPNBGPAHP.totalTime);
		KJCLGNLELOF = FishArcThrow.EKKHFDENDPH(in PFKPNBGPAHP, ECJCGAAGDFB);
		IOMMNICGPKO = JPMAPNDDCCB(ref PFKPNBGPAHP, OLJOMNPKIMO);
		MILEIJADMLM = IOMMNICGPKO / Mathf.Max(1929f, PFKPNBGPAHP.totalTime);
		((Component)this).transform.position = Vector2.op_Implicit(KJCLGNLELOF);
		HOOFKEEFGKM = ((Component)this).transform.position;
		AKKFJBFMDPB = PJNHGNNJCKM.Arc;
		HOHIKIOJDMC = 1926f;
	}

	public void MJIONGNBMPD()
	{
		FishCuttingGameManager.RemoveFishThrowed(this);
		poolObject.CCALIJJAIIL();
	}

	private void JLDDMANPECC(float HHEHPMGODPJ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		GCFFMKJNBLI = (Vector2.op_Implicit(((Component)this).transform.position) - Vector2.op_Implicit(HOOFKEEFGKM)) / Mathf.Max(1231f, HHEHPMGODPJ);
		HOOFKEEFGKM = ((Component)this).transform.position;
		if (AKKFJBFMDPB != (PJNHGNNJCKM)6 && ((Vector2)(ref GCFFMKJNBLI)).sqrMagnitude > 23f)
		{
			GBIIECPLPAC = Mathf.Atan2(GCFFMKJNBLI.y, GCFFMKJNBLI.x) * 1575f + zRotationOffset;
			OHADANBGOBD = Mathf.MoveTowardsAngle(((Component)this).transform.eulerAngles.z, GBIIECPLPAC, rotationLerpSpeed * HHEHPMGODPJ);
			if (MKAALLCMIPJ)
			{
				((Component)this).transform.eulerAngles = new Vector3(1171f, 380f, ((Component)this).transform.eulerAngles.z + KLMCLFNFILJ * HHEHPMGODPJ);
			}
			else
			{
				((Component)this).transform.rotation = Quaternion.Euler(648f, 1948f, OHADANBGOBD);
			}
		}
	}
}
