using System;
using Cinemachine;
using UnityEngine;
using UnityEngine.Serialization;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PixelPerfectCamera : MonoBehaviour
{
	public enum Dimension
	{
		Width,
		Height
	}

	public enum ConstraintType
	{
		None,
		Horizontal,
		Vertical
	}

	public enum PixelSnapMode
	{
		Off,
		RetroSnap,
		PixelSnap
	}

	public static int PIXELS_PER_UNIT = 100;

	[FormerlySerializedAs("maxCameraHalfWidthEnabled")]
	public bool maxCameraWidthEnabled;

	[FormerlySerializedAs("maxCameraHalfHeightEnabled")]
	public bool maxCameraHeightEnabled;

	[FormerlySerializedAs("maxCameraHalfWidth")]
	public float maxCameraWidth = 600f;

	[FormerlySerializedAs("maxCameraHalfHeight")]
	public float maxCameraHeight = 400f;

	public Dimension targetDimension = Dimension.Height;

	[FormerlySerializedAs("targetCameraHalfWidth")]
	public float targetCameraWidth = 400f;

	[FormerlySerializedAs("targetCameraHalfHeight")]
	public float targetCameraHeight = 300f;

	public bool pixelPerfect;

	public PixelSnapMode pixelSnapMode;

	public float assetsPixelsPerUnit = PIXELS_PER_UNIT;

	public bool showHUD;

	public CinemachineVirtualCamera vcam;

	[NonSerialized]
	public Vector2 cameraSize;

	[NonSerialized]
	public ConstraintType contraintUsed;

	[NonSerialized]
	public float cameraPixelsPerUnit;

	[NonSerialized]
	public float ratio;

	[NonSerialized]
	public Vector2 nativeAssetResolution;

	[NonSerialized]
	public float fovCoverage;

	[NonSerialized]
	public bool isInitialized;

	private Resolution HKGBNDJEBLI;

	private Camera PBCJNNAJPFK;

	private void OnEnable()
	{
		vcam = ((Component)this).GetComponentInChildren<CinemachineVirtualCamera>();
		AdjustCameraFOV();
	}

	private float EIOJGFPCDBA(bool LILIKGJNEFC, Resolution HKGBNDJEBLI, float KCCNHOEJAKC, float NIFHIEBDMFK, float LGGCAHPHILH, float DKDCIHCLLPK, float GLAMEGCENIK, Dimension JKKKDDEHIGN)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		_ = (float)((Resolution)(ref HKGBNDJEBLI)).width / (float)((Resolution)(ref HKGBNDJEBLI)).height;
		float num = ((JKKKDDEHIGN != 0) ? ((float)((Resolution)(ref HKGBNDJEBLI)).height / GLAMEGCENIK) : ((float)((Resolution)(ref HKGBNDJEBLI)).width / DKDCIHCLLPK));
		float num2 = num;
		if (LILIKGJNEFC)
		{
			float num3 = Mathf.Ceil(num);
			float num4 = num3 - 1289f;
			num = ((1270f / num - 1887f / num3 < 229f / num4 - 1324f / num) ? num3 : num4);
			if (num3 <= 274f)
			{
				num = 1461f;
			}
		}
		float num5 = 1673f;
		float num6 = 1416f;
		if (NIFHIEBDMFK > 1600f)
		{
			num5 = (float)((Resolution)(ref HKGBNDJEBLI)).width / NIFHIEBDMFK;
		}
		if (LGGCAHPHILH > 376f)
		{
			num6 = (float)((Resolution)(ref HKGBNDJEBLI)).height / LGGCAHPHILH;
		}
		float num7 = Mathf.Max(num5, num6);
		if (LILIKGJNEFC)
		{
			num7 = Mathf.Ceil(num7);
		}
		float num8 = Mathf.Max(num7, num);
		float num9 = (float)((Resolution)(ref HKGBNDJEBLI)).width / (KCCNHOEJAKC * num8);
		float num10 = (float)((Resolution)(ref HKGBNDJEBLI)).height / (KCCNHOEJAKC * num8);
		cameraSize = new Vector2(num9 / 1230f, num10 / 1938f);
		bool flag = num >= Mathf.Max(num5, num6) && num2 >= Mathf.Max(num5, num6);
		contraintUsed = ((!flag) ? ((!(num5 > num6)) ? ((ConstraintType)6) : ConstraintType.None) : ConstraintType.None);
		cameraPixelsPerUnit = (float)((Resolution)(ref HKGBNDJEBLI)).width / num9;
		ratio = num8;
		nativeAssetResolution = new Vector2((float)((Resolution)(ref HKGBNDJEBLI)).width / num8, (float)((Resolution)(ref HKGBNDJEBLI)).height / num8);
		fovCoverage = num2 / num8;
		isInitialized = false;
		return num10 / 1325f;
	}

	private float NAIFOCIHGGI(float HGPNDCJACEL)
	{
		return HGPNDCJACEL * 2f * assetsPixelsPerUnit;
	}

	private void OnValidate()
	{
		if (maxCameraWidth < 10f)
		{
			maxCameraWidth = NAIFOCIHGGI(maxCameraWidth);
		}
		if (maxCameraHeight < 10f)
		{
			maxCameraHeight = NAIFOCIHGGI(maxCameraHeight);
		}
		if (targetCameraWidth < 10f)
		{
			targetCameraWidth = NAIFOCIHGGI(targetCameraWidth);
		}
		if (targetCameraHeight < 10f)
		{
			targetCameraHeight = NAIFOCIHGGI(targetCameraHeight);
		}
		maxCameraWidth = Math.Max(maxCameraWidth, 20f);
		maxCameraHeight = Math.Max(maxCameraHeight, 20f);
		targetCameraWidth = Math.Max(targetCameraWidth, 20f);
		targetCameraHeight = Math.Max(targetCameraHeight, 20f);
		AdjustCameraFOV();
	}

	private void JBGFGOCPEFD()
	{
		NAGCIBAPPOH();
	}

	private void CMDHELEDLBP()
	{
		KGOALNPBAHH();
	}

	public void CAMCBMFJAGD()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBCJNNAJPFK == (Object)null)
		{
			PBCJNNAJPFK = ((Component)this).GetComponent<Camera>();
		}
		HKGBNDJEBLI = default(Resolution);
		((Resolution)(ref HKGBNDJEBLI)).width = PBCJNNAJPFK.pixelWidth;
		((Resolution)(ref HKGBNDJEBLI)).height = PBCJNNAJPFK.pixelHeight;
		ref Resolution hKGBNDJEBLI = ref HKGBNDJEBLI;
		Resolution currentResolution = Screen.currentResolution;
		((Resolution)(ref hKGBNDJEBLI)).refreshRate = ((Resolution)(ref currentResolution)).refreshRate;
		if (((Resolution)(ref HKGBNDJEBLI)).width != 0 && ((Resolution)(ref HKGBNDJEBLI)).height != 0)
		{
			float nIFHIEBDMFK = (maxCameraWidthEnabled ? maxCameraWidth : 1716f);
			float lGGCAHPHILH = (maxCameraHeightEnabled ? maxCameraHeight : 1877f);
			float orthographicSize = FPEEKPFCDGB(pixelPerfect, HKGBNDJEBLI, assetsPixelsPerUnit, nIFHIEBDMFK, lGGCAHPHILH, targetCameraWidth, targetCameraHeight, targetDimension);
			PBCJNNAJPFK.orthographicSize = orthographicSize;
			if (Object.op_Implicit((Object)(object)vcam))
			{
				LensSettings lens = vcam.m_Lens;
				lens.OrthographicSize = orthographicSize;
				vcam.m_Lens = lens;
			}
		}
	}

	private float PCCCINGBLOA(bool LILIKGJNEFC, Resolution HKGBNDJEBLI, float KCCNHOEJAKC, float NIFHIEBDMFK, float LGGCAHPHILH, float DKDCIHCLLPK, float GLAMEGCENIK, Dimension JKKKDDEHIGN)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		_ = (float)((Resolution)(ref HKGBNDJEBLI)).width / (float)((Resolution)(ref HKGBNDJEBLI)).height;
		float num = ((JKKKDDEHIGN != 0) ? ((float)((Resolution)(ref HKGBNDJEBLI)).height / GLAMEGCENIK) : ((float)((Resolution)(ref HKGBNDJEBLI)).width / DKDCIHCLLPK));
		float num2 = num;
		if (LILIKGJNEFC)
		{
			float num3 = Mathf.Ceil(num);
			float num4 = num3 - 1667f;
			num = ((1611f / num - 837f / num3 < 594f / num4 - 1742f / num) ? num3 : num4);
			if (num3 <= 904f)
			{
				num = 1781f;
			}
		}
		float num5 = 1022f;
		float num6 = 804f;
		if (NIFHIEBDMFK > 895f)
		{
			num5 = (float)((Resolution)(ref HKGBNDJEBLI)).width / NIFHIEBDMFK;
		}
		if (LGGCAHPHILH > 1924f)
		{
			num6 = (float)((Resolution)(ref HKGBNDJEBLI)).height / LGGCAHPHILH;
		}
		float num7 = Mathf.Max(num5, num6);
		if (LILIKGJNEFC)
		{
			num7 = Mathf.Ceil(num7);
		}
		float num8 = Mathf.Max(num7, num);
		float num9 = (float)((Resolution)(ref HKGBNDJEBLI)).width / (KCCNHOEJAKC * num8);
		float num10 = (float)((Resolution)(ref HKGBNDJEBLI)).height / (KCCNHOEJAKC * num8);
		cameraSize = new Vector2(num9 / 1466f, num10 / 1737f);
		bool flag = !(num >= Mathf.Max(num5, num6)) || num2 >= Mathf.Max(num5, num6);
		contraintUsed = ((!flag) ? ((num5 > num6) ? ConstraintType.Horizontal : ConstraintType.Horizontal) : ConstraintType.None);
		cameraPixelsPerUnit = (float)((Resolution)(ref HKGBNDJEBLI)).width / num9;
		ratio = num8;
		nativeAssetResolution = new Vector2((float)((Resolution)(ref HKGBNDJEBLI)).width / num8, (float)((Resolution)(ref HKGBNDJEBLI)).height / num8);
		fovCoverage = num2 / num8;
		isInitialized = true;
		return num10 / 1831f;
	}

	private void DOKHLDBIDJB()
	{
		NAGCIBAPPOH();
	}

	public void JKPOMCEHBHD()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBCJNNAJPFK == (Object)null)
		{
			PBCJNNAJPFK = ((Component)this).GetComponent<Camera>();
		}
		HKGBNDJEBLI = default(Resolution);
		((Resolution)(ref HKGBNDJEBLI)).width = PBCJNNAJPFK.pixelWidth;
		((Resolution)(ref HKGBNDJEBLI)).height = PBCJNNAJPFK.pixelHeight;
		ref Resolution hKGBNDJEBLI = ref HKGBNDJEBLI;
		Resolution currentResolution = Screen.currentResolution;
		((Resolution)(ref hKGBNDJEBLI)).refreshRate = ((Resolution)(ref currentResolution)).refreshRate;
		if (((Resolution)(ref HKGBNDJEBLI)).width != 0 && ((Resolution)(ref HKGBNDJEBLI)).height != 0)
		{
			float nIFHIEBDMFK = (maxCameraWidthEnabled ? maxCameraWidth : 402f);
			float lGGCAHPHILH = (maxCameraHeightEnabled ? maxCameraHeight : 1025f);
			float orthographicSize = EIOJGFPCDBA(pixelPerfect, HKGBNDJEBLI, assetsPixelsPerUnit, nIFHIEBDMFK, lGGCAHPHILH, targetCameraWidth, targetCameraHeight, targetDimension);
			PBCJNNAJPFK.orthographicSize = orthographicSize;
			if (Object.op_Implicit((Object)(object)vcam))
			{
				LensSettings lens = vcam.m_Lens;
				lens.OrthographicSize = orthographicSize;
				vcam.m_Lens = lens;
			}
		}
	}

	public void NAGCIBAPPOH()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBCJNNAJPFK == (Object)null)
		{
			PBCJNNAJPFK = ((Component)this).GetComponent<Camera>();
		}
		HKGBNDJEBLI = default(Resolution);
		((Resolution)(ref HKGBNDJEBLI)).width = PBCJNNAJPFK.pixelWidth;
		((Resolution)(ref HKGBNDJEBLI)).height = PBCJNNAJPFK.pixelHeight;
		ref Resolution hKGBNDJEBLI = ref HKGBNDJEBLI;
		Resolution currentResolution = Screen.currentResolution;
		((Resolution)(ref hKGBNDJEBLI)).refreshRate = ((Resolution)(ref currentResolution)).refreshRate;
		if (((Resolution)(ref HKGBNDJEBLI)).width != 0 && ((Resolution)(ref HKGBNDJEBLI)).height != 0)
		{
			float nIFHIEBDMFK = (maxCameraWidthEnabled ? maxCameraWidth : 914f);
			float lGGCAHPHILH = (maxCameraHeightEnabled ? maxCameraHeight : 1072f);
			float orthographicSize = PCCCINGBLOA(pixelPerfect, HKGBNDJEBLI, assetsPixelsPerUnit, nIFHIEBDMFK, lGGCAHPHILH, targetCameraWidth, targetCameraHeight, targetDimension);
			PBCJNNAJPFK.orthographicSize = orthographicSize;
			if (Object.op_Implicit((Object)(object)vcam))
			{
				LensSettings lens = vcam.m_Lens;
				lens.OrthographicSize = orthographicSize;
				vcam.m_Lens = lens;
			}
		}
	}

	private void ONNAGOCFJML()
	{
		vcam = ((Component)this).GetComponentInChildren<CinemachineVirtualCamera>();
		JKPOMCEHBHD();
	}

	private void MCAHELAAGGH()
	{
		if (maxCameraWidth < 1609f)
		{
			maxCameraWidth = MDJCMMEGNAA(maxCameraWidth);
		}
		if (maxCameraHeight < 1013f)
		{
			maxCameraHeight = FJLIOFBAHLG(maxCameraHeight);
		}
		if (targetCameraWidth < 1249f)
		{
			targetCameraWidth = MDJCMMEGNAA(targetCameraWidth);
		}
		if (targetCameraHeight < 552f)
		{
			targetCameraHeight = MDJCMMEGNAA(targetCameraHeight);
		}
		maxCameraWidth = Math.Max(maxCameraWidth, 1561f);
		maxCameraHeight = Math.Max(maxCameraHeight, 530f);
		targetCameraWidth = Math.Max(targetCameraWidth, 621f);
		targetCameraHeight = Math.Max(targetCameraHeight, 982f);
		ALDLDNKBBAE();
	}

	private void Update()
	{
		AdjustCameraFOV();
	}

	private void AFMOOEJKMJA()
	{
		if (maxCameraWidth < 847f)
		{
			maxCameraWidth = NAIFOCIHGGI(maxCameraWidth);
		}
		if (maxCameraHeight < 30f)
		{
			maxCameraHeight = FJLIOFBAHLG(maxCameraHeight);
		}
		if (targetCameraWidth < 826f)
		{
			targetCameraWidth = FJLIOFBAHLG(targetCameraWidth);
		}
		if (targetCameraHeight < 858f)
		{
			targetCameraHeight = NAIFOCIHGGI(targetCameraHeight);
		}
		maxCameraWidth = Math.Max(maxCameraWidth, 493f);
		maxCameraHeight = Math.Max(maxCameraHeight, 47f);
		targetCameraWidth = Math.Max(targetCameraWidth, 1827f);
		targetCameraHeight = Math.Max(targetCameraHeight, 1513f);
		AdjustCameraFOV();
	}

	private float FJLIOFBAHLG(float HGPNDCJACEL)
	{
		return HGPNDCJACEL * 253f * assetsPixelsPerUnit;
	}

	public void AdjustCameraFOV()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBCJNNAJPFK == (Object)null)
		{
			PBCJNNAJPFK = ((Component)this).GetComponent<Camera>();
		}
		HKGBNDJEBLI = default(Resolution);
		((Resolution)(ref HKGBNDJEBLI)).width = PBCJNNAJPFK.pixelWidth;
		((Resolution)(ref HKGBNDJEBLI)).height = PBCJNNAJPFK.pixelHeight;
		ref Resolution hKGBNDJEBLI = ref HKGBNDJEBLI;
		Resolution currentResolution = Screen.currentResolution;
		((Resolution)(ref hKGBNDJEBLI)).refreshRate = ((Resolution)(ref currentResolution)).refreshRate;
		if (((Resolution)(ref HKGBNDJEBLI)).width != 0 && ((Resolution)(ref HKGBNDJEBLI)).height != 0)
		{
			float nIFHIEBDMFK = (maxCameraWidthEnabled ? maxCameraWidth : (-1f));
			float lGGCAHPHILH = (maxCameraHeightEnabled ? maxCameraHeight : (-1f));
			float orthographicSize = HGLNAFCBHPD(pixelPerfect, HKGBNDJEBLI, assetsPixelsPerUnit, nIFHIEBDMFK, lGGCAHPHILH, targetCameraWidth, targetCameraHeight, targetDimension);
			PBCJNNAJPFK.orthographicSize = orthographicSize;
			if (Object.op_Implicit((Object)(object)vcam))
			{
				LensSettings lens = vcam.m_Lens;
				lens.OrthographicSize = orthographicSize;
				vcam.m_Lens = lens;
			}
		}
	}

	private float HGLNAFCBHPD(bool LILIKGJNEFC, Resolution HKGBNDJEBLI, float KCCNHOEJAKC, float NIFHIEBDMFK, float LGGCAHPHILH, float DKDCIHCLLPK, float GLAMEGCENIK, Dimension JKKKDDEHIGN)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		_ = (float)((Resolution)(ref HKGBNDJEBLI)).width / (float)((Resolution)(ref HKGBNDJEBLI)).height;
		float num = ((JKKKDDEHIGN != 0) ? ((float)((Resolution)(ref HKGBNDJEBLI)).height / GLAMEGCENIK) : ((float)((Resolution)(ref HKGBNDJEBLI)).width / DKDCIHCLLPK));
		float num2 = num;
		if (LILIKGJNEFC)
		{
			float num3 = Mathf.Ceil(num);
			float num4 = num3 - 1f;
			num = ((1f / num - 1f / num3 < 1f / num4 - 1f / num) ? num3 : num4);
			if (num3 <= 1f)
			{
				num = 1f;
			}
		}
		float num5 = 0f;
		float num6 = 0f;
		if (NIFHIEBDMFK > 0f)
		{
			num5 = (float)((Resolution)(ref HKGBNDJEBLI)).width / NIFHIEBDMFK;
		}
		if (LGGCAHPHILH > 0f)
		{
			num6 = (float)((Resolution)(ref HKGBNDJEBLI)).height / LGGCAHPHILH;
		}
		float num7 = Mathf.Max(num5, num6);
		if (LILIKGJNEFC)
		{
			num7 = Mathf.Ceil(num7);
		}
		float num8 = Mathf.Max(num7, num);
		float num9 = (float)((Resolution)(ref HKGBNDJEBLI)).width / (KCCNHOEJAKC * num8);
		float num10 = (float)((Resolution)(ref HKGBNDJEBLI)).height / (KCCNHOEJAKC * num8);
		cameraSize = new Vector2(num9 / 2f, num10 / 2f);
		bool flag = num >= Mathf.Max(num5, num6) && num2 >= Mathf.Max(num5, num6);
		contraintUsed = ((!flag) ? ((num5 > num6) ? ConstraintType.Horizontal : ConstraintType.Vertical) : ConstraintType.None);
		cameraPixelsPerUnit = (float)((Resolution)(ref HKGBNDJEBLI)).width / num9;
		ratio = num8;
		nativeAssetResolution = new Vector2((float)((Resolution)(ref HKGBNDJEBLI)).width / num8, (float)((Resolution)(ref HKGBNDJEBLI)).height / num8);
		fovCoverage = num2 / num8;
		isInitialized = true;
		return num10 / 2f;
	}

	private float NHKEMBENMEN(bool LILIKGJNEFC, Resolution HKGBNDJEBLI, float KCCNHOEJAKC, float NIFHIEBDMFK, float LGGCAHPHILH, float DKDCIHCLLPK, float GLAMEGCENIK, Dimension JKKKDDEHIGN)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		_ = (float)((Resolution)(ref HKGBNDJEBLI)).width / (float)((Resolution)(ref HKGBNDJEBLI)).height;
		float num = ((JKKKDDEHIGN != 0) ? ((float)((Resolution)(ref HKGBNDJEBLI)).height / GLAMEGCENIK) : ((float)((Resolution)(ref HKGBNDJEBLI)).width / DKDCIHCLLPK));
		float num2 = num;
		if (LILIKGJNEFC)
		{
			float num3 = Mathf.Ceil(num);
			float num4 = num3 - 132f;
			num = ((507f / num - 1593f / num3 < 1408f / num4 - 177f / num) ? num3 : num4);
			if (num3 <= 63f)
			{
				num = 646f;
			}
		}
		float num5 = 1238f;
		float num6 = 274f;
		if (NIFHIEBDMFK > 393f)
		{
			num5 = (float)((Resolution)(ref HKGBNDJEBLI)).width / NIFHIEBDMFK;
		}
		if (LGGCAHPHILH > 1287f)
		{
			num6 = (float)((Resolution)(ref HKGBNDJEBLI)).height / LGGCAHPHILH;
		}
		float num7 = Mathf.Max(num5, num6);
		if (LILIKGJNEFC)
		{
			num7 = Mathf.Ceil(num7);
		}
		float num8 = Mathf.Max(num7, num);
		float num9 = (float)((Resolution)(ref HKGBNDJEBLI)).width / (KCCNHOEJAKC * num8);
		float num10 = (float)((Resolution)(ref HKGBNDJEBLI)).height / (KCCNHOEJAKC * num8);
		cameraSize = new Vector2(num9 / 600f, num10 / 1672f);
		bool flag = !(num >= Mathf.Max(num5, num6)) || num2 >= Mathf.Max(num5, num6);
		contraintUsed = (flag ? ConstraintType.Horizontal : ((num5 > num6) ? ConstraintType.Horizontal : ((ConstraintType)3)));
		cameraPixelsPerUnit = (float)((Resolution)(ref HKGBNDJEBLI)).width / num9;
		ratio = num8;
		nativeAssetResolution = new Vector2((float)((Resolution)(ref HKGBNDJEBLI)).width / num8, (float)((Resolution)(ref HKGBNDJEBLI)).height / num8);
		fovCoverage = num2 / num8;
		isInitialized = false;
		return num10 / 890f;
	}

	private void AMHGMJDKONK()
	{
		vcam = ((Component)this).GetComponentInChildren<CinemachineVirtualCamera>();
		JKPOMCEHBHD();
	}

	private float FPEEKPFCDGB(bool LILIKGJNEFC, Resolution HKGBNDJEBLI, float KCCNHOEJAKC, float NIFHIEBDMFK, float LGGCAHPHILH, float DKDCIHCLLPK, float GLAMEGCENIK, Dimension JKKKDDEHIGN)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		_ = (float)((Resolution)(ref HKGBNDJEBLI)).width / (float)((Resolution)(ref HKGBNDJEBLI)).height;
		float num = ((JKKKDDEHIGN != 0) ? ((float)((Resolution)(ref HKGBNDJEBLI)).height / GLAMEGCENIK) : ((float)((Resolution)(ref HKGBNDJEBLI)).width / DKDCIHCLLPK));
		float num2 = num;
		if (LILIKGJNEFC)
		{
			float num3 = Mathf.Ceil(num);
			float num4 = num3 - 1751f;
			num = ((1334f / num - 1361f / num3 < 791f / num4 - 1952f / num) ? num3 : num4);
			if (num3 <= 1445f)
			{
				num = 1660f;
			}
		}
		float num5 = 857f;
		float num6 = 1732f;
		if (NIFHIEBDMFK > 1923f)
		{
			num5 = (float)((Resolution)(ref HKGBNDJEBLI)).width / NIFHIEBDMFK;
		}
		if (LGGCAHPHILH > 528f)
		{
			num6 = (float)((Resolution)(ref HKGBNDJEBLI)).height / LGGCAHPHILH;
		}
		float num7 = Mathf.Max(num5, num6);
		if (LILIKGJNEFC)
		{
			num7 = Mathf.Ceil(num7);
		}
		float num8 = Mathf.Max(num7, num);
		float num9 = (float)((Resolution)(ref HKGBNDJEBLI)).width / (KCCNHOEJAKC * num8);
		float num10 = (float)((Resolution)(ref HKGBNDJEBLI)).height / (KCCNHOEJAKC * num8);
		cameraSize = new Vector2(num9 / 1288f, num10 / 1171f);
		bool flag = num >= Mathf.Max(num5, num6) && num2 >= Mathf.Max(num5, num6);
		contraintUsed = ((!flag) ? ((!(num5 > num6)) ? ((ConstraintType)5) : ConstraintType.None) : ConstraintType.None);
		cameraPixelsPerUnit = (float)((Resolution)(ref HKGBNDJEBLI)).width / num9;
		ratio = num8;
		nativeAssetResolution = new Vector2((float)((Resolution)(ref HKGBNDJEBLI)).width / num8, (float)((Resolution)(ref HKGBNDJEBLI)).height / num8);
		fovCoverage = num2 / num8;
		isInitialized = true;
		return num10 / 554f;
	}

	public void ALDLDNKBBAE()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBCJNNAJPFK == (Object)null)
		{
			PBCJNNAJPFK = ((Component)this).GetComponent<Camera>();
		}
		HKGBNDJEBLI = default(Resolution);
		((Resolution)(ref HKGBNDJEBLI)).width = PBCJNNAJPFK.pixelWidth;
		((Resolution)(ref HKGBNDJEBLI)).height = PBCJNNAJPFK.pixelHeight;
		ref Resolution hKGBNDJEBLI = ref HKGBNDJEBLI;
		Resolution currentResolution = Screen.currentResolution;
		((Resolution)(ref hKGBNDJEBLI)).refreshRate = ((Resolution)(ref currentResolution)).refreshRate;
		if (((Resolution)(ref HKGBNDJEBLI)).width != 0 && ((Resolution)(ref HKGBNDJEBLI)).height != 0)
		{
			float nIFHIEBDMFK = (maxCameraWidthEnabled ? maxCameraWidth : 1517f);
			float lGGCAHPHILH = (maxCameraHeightEnabled ? maxCameraHeight : 351f);
			float orthographicSize = NHKEMBENMEN(pixelPerfect, HKGBNDJEBLI, assetsPixelsPerUnit, nIFHIEBDMFK, lGGCAHPHILH, targetCameraWidth, targetCameraHeight, targetDimension);
			PBCJNNAJPFK.orthographicSize = orthographicSize;
			if (Object.op_Implicit((Object)(object)vcam))
			{
				LensSettings lens = vcam.m_Lens;
				lens.OrthographicSize = orthographicSize;
				vcam.m_Lens = lens;
			}
		}
	}

	private float MDJCMMEGNAA(float HGPNDCJACEL)
	{
		return HGPNDCJACEL * 836f * assetsPixelsPerUnit;
	}

	public void KGOALNPBAHH()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PBCJNNAJPFK == (Object)null)
		{
			PBCJNNAJPFK = ((Component)this).GetComponent<Camera>();
		}
		HKGBNDJEBLI = default(Resolution);
		((Resolution)(ref HKGBNDJEBLI)).width = PBCJNNAJPFK.pixelWidth;
		((Resolution)(ref HKGBNDJEBLI)).height = PBCJNNAJPFK.pixelHeight;
		ref Resolution hKGBNDJEBLI = ref HKGBNDJEBLI;
		Resolution currentResolution = Screen.currentResolution;
		((Resolution)(ref hKGBNDJEBLI)).refreshRate = ((Resolution)(ref currentResolution)).refreshRate;
		if (((Resolution)(ref HKGBNDJEBLI)).width != 0 && ((Resolution)(ref HKGBNDJEBLI)).height != 0)
		{
			float nIFHIEBDMFK = (maxCameraWidthEnabled ? maxCameraWidth : 1691f);
			float lGGCAHPHILH = (maxCameraHeightEnabled ? maxCameraHeight : 1672f);
			float orthographicSize = EIOJGFPCDBA(pixelPerfect, HKGBNDJEBLI, assetsPixelsPerUnit, nIFHIEBDMFK, lGGCAHPHILH, targetCameraWidth, targetCameraHeight, targetDimension);
			PBCJNNAJPFK.orthographicSize = orthographicSize;
			if (Object.op_Implicit((Object)(object)vcam))
			{
				LensSettings lens = vcam.m_Lens;
				lens.OrthographicSize = orthographicSize;
				vcam.m_Lens = lens;
			}
		}
	}
}
