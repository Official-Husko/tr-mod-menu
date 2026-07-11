using System.Collections.Generic;
using UnityEngine;

public class WaterInteractionController : MonoBehaviour
{
	public int playerNum = 1;

	public CharacterAnimator characterAnimator;

	public Transform mask;

	public FloatingMovement floatingMovement;

	public Vector2 maskHeightRange;

	public SpriteRenderer playerShadow;

	public float waterDepth;

	public float maxDistanceDepth = 3f;

	public float heightMultiplierMin = 0.4f;

	public GenericPool waterWavesPool;

	public float waterWavesRate = 0.5f;

	public float particlesDepthAppears = 2f;

	public SpriteRenderer waterContact;

	public Vector2 contactDistance = new Vector2(1f, 3f);

	public Vector3 sideScale = new Vector3(0.7f, 1f, 1f);

	private float MLAINFPLOFJ;

	private float IFGHJIMEFIN;

	private Color EMCCHMNLFJH = Color.white;

	private List<Vector2> OCOCKJEJDNM = new List<Vector2>();

	private void KHNGJFBMMCP()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.ICFDBMCPLJK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1828f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1495f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(893f, 1208f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void AEMPCMILANL()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(363f, 902f, 1501f, 1261f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "talentWoodwork";
	}

	public void KNJBPNKFJJC()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "ReceiveCatPosition";
	}

	private void PHLLBPLOLFO()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.BNGMFHFAKMP(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 180f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1480f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1597f, 1894f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void HHLHCBPLENA()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(826f, 83f, 1965f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1038f);
			}
		}
	}

	private void JFIOGGNAFNB()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(1233f, 1839f, 1073f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1646f);
			}
		}
	}

	public void LAADMMNHHGA()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "FadeOut";
	}

	public void CHDGJHNBNEJ()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "-1";
	}

	public void MBMFDJHDNCI()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 286f && ((Component)this).transform.localScale.x > 1309f)
		{
			((Component)this).transform.localScale = new Vector3(154f, 152f, 527f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1200f && ((Component)this).transform.localScale.x < 1096f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.MCMKNJLPPIC(((Component)mask).transform.position);
		floatingMovement.EGNMJDIJELH(Mathf.Lerp(heightMultiplierMin, 60f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1740f))));
	}

	public void IMOMHCNPCEC()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "";
	}

	public void GGDMGADLMOG()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Theme: ";
	}

	public void CNFELPNGNOB()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "before pos ";
	}

	public void OJLGOCFKLJE()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(165f, 1402f, 679f, 1518f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "LE_21";
	}

	public void JLLHILICJOC()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "\n";
	}

	private void NPCJEOMKLDJ()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(1358f, 760f, 116f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 249f);
			}
		}
	}

	private void NMIJACDOGMF()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.IOBMKFJDMJG(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 772f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1114f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(111f, 95f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void PFANFGPFOFM()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "talentSausages";
	}

	public void IEJDHAPPIMD()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1496f && ((Component)this).transform.localScale.x > 377f)
		{
			((Component)this).transform.localScale = new Vector3(1677f, 923f, 532f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 612f && ((Component)this).transform.localScale.x < 930f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.CalculateOffset(((Component)mask).transform.position);
		floatingMovement.HIEECJBHHOL(Mathf.Lerp(heightMultiplierMin, 1705f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1796f))));
	}

	public void KHCDKNGMMCA()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Wilson/Bark/Bark_Bye";
	}

	private void HCPKBJDHLAC()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 63f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1839f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1118f, 1849f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void HFIHGHBLLAM()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(1616f, 1633f, 1790f, 600f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Key2";
	}

	public void AJMEFFOGPPE()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 862f && ((Component)this).transform.localScale.x > 1713f)
		{
			((Component)this).transform.localScale = new Vector3(26f, 1289f, 1006f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1066f && ((Component)this).transform.localScale.x < 230f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.NGPEAOKIHKJ(((Component)mask).transform.position);
		floatingMovement.PLPFMHJBICE(Mathf.Lerp(heightMultiplierMin, 1355f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 14f))));
	}

	public void IFBKCNJGADL()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Bartender";
	}

	public void OKEGMHBDHIP()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "End Event ";
	}

	private void NMIMPLOIEHN()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(1909f, 1347f, 1214f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1694f);
			}
		}
	}

	public void PMMGCDBMMMN()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(1669f, 662f, 1535f, 660f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Items/item_name_650";
	}

	public void DAKLOGKFLLD()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 913f && ((Component)this).transform.localScale.x > 755f)
		{
			((Component)this).transform.localScale = new Vector3(1492f, 1998f, 365f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1281f && ((Component)this).transform.localScale.x < 228f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.MCMKNJLPPIC(((Component)mask).transform.position);
		floatingMovement.IIMNCCOLPGG(Mathf.Lerp(heightMultiplierMin, 148f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1372f))));
	}

	public void MKHMCIFFOFJ()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(1563f, 1130f, 1540f, 1962f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Item Transaction. Tutorial active!!";
	}

	public void LateUpdate()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 0f && ((Component)this).transform.localScale.x > 0f)
		{
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 0f && ((Component)this).transform.localScale.x < 0f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.CalculateOffset(((Component)mask).transform.position);
		floatingMovement.LIDGIPGPHJJ = Mathf.Lerp(heightMultiplierMin, 1f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 0.5f)));
	}

	private void PDKPDDNBOOO()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(61f, 1118f, 1845f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1722f);
			}
		}
	}

	public void OnEnable()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(1f, 1f, 1f, 0f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Floor";
	}

	private void DHBMBJOLGDE()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.ICFDBMCPLJK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1302f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 101f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(871f, 1159f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void NFPEFLHLIMM()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1529f && ((Component)this).transform.localScale.x > 344f)
		{
			((Component)this).transform.localScale = new Vector3(1308f, 1593f, 1156f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1400f && ((Component)this).transform.localScale.x < 63f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.IHBHAIFEBHP(((Component)mask).transform.position);
		floatingMovement.EGNMJDIJELH(Mathf.Lerp(heightMultiplierMin, 240f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 285f))));
	}

	public void HHHEACKHADN()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(925f, 460f, 857f, 901f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Workbench";
	}

	private void GCHMNMKCOFG()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 269f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1791f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1675f, 1399f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void ADGMAKKMINA()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(120f, 489f, 1850f, 1250f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "bed instance null";
	}

	private void MLICJIBNIFA()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 792f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 76f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(19f, 574f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void HCEHKDGMECG()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "bedAssigned ";
	}

	public void DIMOLCECNGD()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 496f && ((Component)this).transform.localScale.x > 365f)
		{
			((Component)this).transform.localScale = new Vector3(1302f, 221f, 438f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 594f && ((Component)this).transform.localScale.x < 1173f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.GFNGFKKFNOF(((Component)mask).transform.position);
		floatingMovement.DEKHOGGKHHC(Mathf.Lerp(heightMultiplierMin, 424f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 162f))));
	}

	public void NBBFLJNPLEA()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(746f, 287f, 1206f, 1974f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "'. ";
	}

	private void AGKPBDMEHKC()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(1361f, 673f, 692f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1351f);
			}
		}
	}

	private void ALPKNHGMDJB()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(467f, 1983f, 899f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 18f);
			}
		}
	}

	public void NLEOMMPMBDF()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 447f && ((Component)this).transform.localScale.x > 673f)
		{
			((Component)this).transform.localScale = new Vector3(1529f, 1090f, 431f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 116f && ((Component)this).transform.localScale.x < 938f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.IJOBGPCEHEF(((Component)mask).transform.position);
		floatingMovement.IIMNCCOLPGG(Mathf.Lerp(heightMultiplierMin, 1533f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1993f))));
	}

	private void JMCEPBNDMDO()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(1587f, 372f, 945f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 321f);
			}
		}
	}

	private void NJNCKELODLF()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.NOKLFCDOMFL(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1583f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1916f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1419f, 1789f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void MDKBJMJJDED()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1126f, 1847f, 1992f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1666f);
			}
		}
	}

	public void ECHMKEAGFFO()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "Occupied Positions";
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1f, 1f, 0.5f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 0.1f);
			}
		}
	}

	public void OnDisable()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "OnFloor";
	}

	public void LPKHACNBCLA()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(1502f, 588f, 797f, 373f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Items/item_name_1121";
	}

	private void EBNJADODONG()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.ICFDBMCPLJK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 888f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1491f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1979f, 1412f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void DEFJFAFNANA()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "yForYears";
	}

	public void CMMMINEGNFP()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "No bed assigned to player num: {0}";
	}

	public void MJKHMOILBFB()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "quarry travelling";
	}

	public void FBHBEAJFBAH()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "SurpriseJump";
	}

	private void GGCCOKCOMEE()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.ICFDBMCPLJK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 729f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 812f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1913f, 1746f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void PJLKGOACDEN()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.NOKLFCDOMFL(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 964f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1162f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1918f, 651f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void CCBLGJADPEO()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "Move Right";
	}

	private void PEIFJDIGKOC()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.OCLMEGIFDKK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1698f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1669f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1945f, 175f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GCIOIGPKJBG(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 578f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1376f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(786f, 851f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void JJHHBJPMEKI()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "You have to use the PixelPerfectCamera script on the assigned UI camera!";
	}

	private void NKODEJGMEJN()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(977f, 1186f, 131f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1348f);
			}
		}
	}

	public void ICJLBIODGAL()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1395f && ((Component)this).transform.localScale.x > 37f)
		{
			((Component)this).transform.localScale = new Vector3(1275f, 1629f, 1841f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1822f && ((Component)this).transform.localScale.x < 421f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.IJMAEMJBNBI(((Component)mask).transform.position);
		floatingMovement.OIEIMOIJFCM(Mathf.Lerp(heightMultiplierMin, 1846f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 881f))));
	}

	private void IIGLLFDCDEP()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1771f, 1087f, 1054f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 221f);
			}
		}
	}

	public void BODEIHFOAMI()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1438f && ((Component)this).transform.localScale.x > 22f)
		{
			((Component)this).transform.localScale = new Vector3(1932f, 1136f, 745f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1151f && ((Component)this).transform.localScale.x < 1653f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.CalculateOffset(((Component)mask).transform.position);
		floatingMovement.CACEJBLLICF(Mathf.Lerp(heightMultiplierMin, 1118f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1885f))));
	}

	private void DELKCCJINKB()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(930f, 361f, 1726f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 311f);
			}
		}
	}

	public void AIPIBFONECC()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 494f && ((Component)this).transform.localScale.x > 839f)
		{
			((Component)this).transform.localScale = new Vector3(1280f, 498f, 1308f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 110f && ((Component)this).transform.localScale.x < 1193f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.COOIPCDMFHE(((Component)mask).transform.position);
		floatingMovement.HIEECJBHHOL(Mathf.Lerp(heightMultiplierMin, 1528f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1067f))));
	}

	public void AIFOBFHCHGK()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = ". Time since startup: ";
	}

	private void LMFICKFGEFI()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 951f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 904f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(357f, 1311f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void Update()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 0f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 0.8f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(0f, 0.8f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void IJNPEAAOOEK()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(205f, 504f, 192f, 1809f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Items/item_name_1050";
	}

	public void NDDPKJIHKNA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1328f && ((Component)this).transform.localScale.x > 1931f)
		{
			((Component)this).transform.localScale = new Vector3(139f, 1191f, 295f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1844f && ((Component)this).transform.localScale.x < 1679f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.CalculateOffset(((Component)mask).transform.position);
		floatingMovement.OOPMCHAAKOK(Mathf.Lerp(heightMultiplierMin, 606f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1156f))));
	}

	public void EPFJBCOKEHC()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "";
	}

	public void PJOAFKEIPPD()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(119f, 1938f, 1599f, 577f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Get Components ";
	}

	public void DCFEJOKEIKN()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 503f && ((Component)this).transform.localScale.x > 178f)
		{
			((Component)this).transform.localScale = new Vector3(1029f, 1143f, 612f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 994f && ((Component)this).transform.localScale.x < 1382f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.CalculateOffset(((Component)mask).transform.position);
		floatingMovement.DEKHOGGKHHC(Mathf.Lerp(heightMultiplierMin, 253f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 216f))));
	}

	private void JMAAFFBIBCG()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.IOBMKFJDMJG(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 983f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 321f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(990f, 874f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void OJDPLJIKIEL()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 176f && ((Component)this).transform.localScale.x > 828f)
		{
			((Component)this).transform.localScale = new Vector3(538f, 627f, 801f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1634f && ((Component)this).transform.localScale.x < 1874f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.COOIPCDMFHE(((Component)mask).transform.position);
		floatingMovement.NCEKLMGNLLI(Mathf.Lerp(heightMultiplierMin, 1856f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 857f))));
	}

	public void JGHCBKCOLPJ()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "MeditationIntro";
	}

	private void JOBDOKMNOBF()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(986f, 1236f, 1940f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1127f);
			}
		}
	}

	public void PKLDCIJGHMH()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(1102f, 114f, 383f, 76f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "#.##%";
	}

	private void IDAALKJNNDI()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1052f, 42f, 939f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1426f);
			}
		}
	}

	public void HIGGKFMBCFM()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1405f && ((Component)this).transform.localScale.x > 395f)
		{
			((Component)this).transform.localScale = new Vector3(816f, 586f, 43f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 411f && ((Component)this).transform.localScale.x < 1728f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.CalculateOffset(((Component)mask).transform.position);
		floatingMovement.NCEKLMGNLLI(Mathf.Lerp(heightMultiplierMin, 1812f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1457f))));
	}

	public void LDBBNBEBKLA()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "UIInteract";
	}

	private void PABBJIJLOIP()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(610f, 1158f, 1409f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1911f);
			}
		}
	}

	private void FPOIFOGELHC()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.ICFDBMCPLJK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1703f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1671f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(969f, 454f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void AEABNMAKCOM()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(775f, 1015f, 1645f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1901f);
			}
		}
	}

	public void IJMBEEEGCGF()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(1711f, 431f, 1243f, 1765f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Next Reward";
	}

	public void JCHHIMAOBNG()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 451f && ((Component)this).transform.localScale.x > 1764f)
		{
			((Component)this).transform.localScale = new Vector3(289f, 717f, 806f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 882f && ((Component)this).transform.localScale.x < 674f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.CalculateOffset(((Component)mask).transform.position);
		floatingMovement.DEKHOGGKHHC(Mathf.Lerp(heightMultiplierMin, 1453f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 916f))));
	}

	private void AKLEFPLEGKK()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1005f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1781f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1338f, 51f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void GNAHKAHPCFB()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.NOKLFCDOMFL(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 392f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1885f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1158f, 1270f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void JIIFJJFHBBN()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1348f, 1646f, 1989f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 471f);
			}
		}
	}

	public void DNNIGMOJDCO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1284f && ((Component)this).transform.localScale.x > 1794f)
		{
			((Component)this).transform.localScale = new Vector3(1523f, 1197f, 762f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1165f && ((Component)this).transform.localScale.x < 249f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.NGPEAOKIHKJ(((Component)mask).transform.position);
		floatingMovement.BHCPFOAFNAE(Mathf.Lerp(heightMultiplierMin, 1504f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 738f))));
	}

	public void BHLAGCODJGJ()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 742f && ((Component)this).transform.localScale.x > 187f)
		{
			((Component)this).transform.localScale = new Vector3(1533f, 1192f, 276f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 953f && ((Component)this).transform.localScale.x < 594f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.GFNGFKKFNOF(((Component)mask).transform.position);
		floatingMovement.JMMFCCFHFBI(Mathf.Lerp(heightMultiplierMin, 1101f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 434f))));
	}

	public void CPEEDJMOHMO()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Cancel";
	}

	public void DNJADOEECLA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1387f && ((Component)this).transform.localScale.x > 1662f)
		{
			((Component)this).transform.localScale = new Vector3(1558f, 1344f, 1391f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1953f && ((Component)this).transform.localScale.x < 84f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.MCMKNJLPPIC(((Component)mask).transform.position);
		floatingMovement.LADJKDAEMKG(Mathf.Lerp(heightMultiplierMin, 1638f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1583f))));
	}

	public void DCCJBKGNAOP()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(1335f, 1800f, 995f, 1861f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Player";
	}

	private void KIHGNKJJBND()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(1279f, 1636f, 1337f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1698f);
			}
		}
	}

	private void EIGEIJJPFFP()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.IOBMKFJDMJG(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1009f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1241f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(495f, 453f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void FIIEBCCFGJE()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Items/item_description_1099";
	}

	public void FNPHGGLAFKA()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = ")";
	}

	public void ECLPOBGFELA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1678f && ((Component)this).transform.localScale.x > 100f)
		{
			((Component)this).transform.localScale = new Vector3(115f, 1403f, 1428f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1483f && ((Component)this).transform.localScale.x < 666f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.GFNGFKKFNOF(((Component)mask).transform.position);
		floatingMovement.EGNMJDIJELH(Mathf.Lerp(heightMultiplierMin, 1227f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 45f))));
	}

	private void HCKBMOKECOA()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.OCLMEGIFDKK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1445f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 663f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(28f, 948f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void GGPDPOAICOM()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.NOKLFCDOMFL(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1313f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 558f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(248f, 479f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void LMEJFGKCHEF()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1666f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 154f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1059f, 1918f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void GBAKNAINDJM()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(1628f, 1835f, 239f, 506f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Talking";
	}

	public void ADEBBJOALDN()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "ReceiveInfoTerrain";
	}

	private void DFMDLAEHLBJ()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(231f, 1341f, 1912f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 589f);
			}
		}
	}

	public void IILOKDBOODL()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "input info";
	}

	private void MNEGGMBGDLP()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(989f, 1954f, 765f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1246f);
			}
		}
	}

	private void KJBFCDKKIDO()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.GetPlayer(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1526f, 909f, 109f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 791f);
			}
		}
	}

	private void DGJKLAEINHJ()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.GetObjectInPool(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 156f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1026f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1852f, 745f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void OKAEGLLMBNO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1606f && ((Component)this).transform.localScale.x > 1948f)
		{
			((Component)this).transform.localScale = new Vector3(1912f, 1495f, 1381f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 746f && ((Component)this).transform.localScale.x < 1106f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.IJMAEMJBNBI(((Component)mask).transform.position);
		floatingMovement.MDLKJCLGHPP(Mathf.Lerp(heightMultiplierMin, 575f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 590f))));
	}

	public void DIEKBCKJMPH()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Player";
	}

	private void LEDIGKGAFHC()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.ICFDBMCPLJK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1820f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 891f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1832f, 442f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void HJKONJICGML()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(72f, 1607f, 508f, 1151f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Herbal";
	}

	public void NMPFHHEFOPH()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(1577f, 887f, 918f, 1140f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = " - ";
	}

	private void GOKBDDFNDFH()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.IOBMKFJDMJG(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 12f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1325f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1243f, 12f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void BONEKIAPEIK()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "SetTriggerRPC";
	}

	private void ACPFEBOENOM()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.BNGMFHFAKMP(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1891f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1407f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1694f, 292f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void GGJCOLOBAAP()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1904f, 1668f, 477f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1828f);
			}
		}
	}

	public void BEOIOFIHCKN()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(368f, 262f, 584f, 1090f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "BarkActor";
	}

	private void LDMDHDACNFJ()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.OCLMEGIFDKK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1349f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 768f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(543f, 1805f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void FCFHPOIGLNK()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i += 0)
			{
				Gizmos.color = new Color(544f, 1617f, 800f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1666f);
			}
		}
	}

	private void PMPLNGEAAII()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.NOKLFCDOMFL(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 1730f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1687f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1566f, 1773f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	private void EBFJOAEJPGE()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.GetPlayer(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.OCLMEGIFDKK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 397f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 643f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(751f, 650f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void HKFGIKEBNJN()
	{
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		((Renderer)playerShadow).sortingLayerName = "Item with id ";
	}

	private void MNFJELNEGPG()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time > IFGHJIMEFIN)
		{
			IFGHJIMEFIN = Time.time + waterWavesRate;
			if (PlayerController.OPHDCMJLLEC(playerNum).moving && waterDepth > particlesDepthAppears)
			{
				waterWavesPool.OCLMEGIFDKK(((Component)mask).transform.position);
			}
		}
		if (waterDepth < contactDistance.x)
		{
			EMCCHMNLFJH.a = 708f;
		}
		else if (waterDepth > contactDistance.y)
		{
			EMCCHMNLFJH.a = 1263f;
		}
		else
		{
			EMCCHMNLFJH.a = Mathf.Lerp(1646f, 1109f, (waterDepth - contactDistance.x) / (maxDistanceDepth - contactDistance.x));
		}
		waterContact.color = EMCCHMNLFJH;
		if (PlayerController.IsPlayerDirectionLeftOrRight(playerNum))
		{
			((Component)waterContact).transform.localScale = sideScale;
		}
		else
		{
			((Component)waterContact).transform.localScale = Vector3.one;
		}
	}

	public void MALMHCKLOBO()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 56f && ((Component)this).transform.localScale.x > 1309f)
		{
			((Component)this).transform.localScale = new Vector3(1140f, 1759f, 1134f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1065f && ((Component)this).transform.localScale.x < 1680f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.OPDKNKAAIEK(((Component)mask).transform.position);
		floatingMovement.PLPFMHJBICE(Mathf.Lerp(heightMultiplierMin, 1067f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 77f))));
	}

	public void GLPFNIFNGKC()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Close UI";
	}

	public void CCJOOMDHMKM()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(408f, 1159f, 1423f, 1877f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "questNameCraftingRoom";
	}

	public void PGDBFGFMGKI()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		waterContact.color = new Color(610f, 1415f, 1631f, 70f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = " (";
	}

	private void MGLFLPAMIAA()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 1; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(1583f, 1761f, 1091f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1160f);
			}
		}
	}

	public void MAGILKJCCJE()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Placed item has no item setup component: ";
	}

	public void ELEFOPHJICI()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: true);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Christmas Event activated: ";
	}

	public void EDFDMFBJKBA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1245f && ((Component)this).transform.localScale.x > 1439f)
		{
			((Component)this).transform.localScale = new Vector3(1954f, 339f, 828f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1021f && ((Component)this).transform.localScale.x < 1144f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.DJGFFKNFOMD(((Component)mask).transform.position);
		floatingMovement.PHAJJKPOILL(Mathf.Lerp(heightMultiplierMin, 1300f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1972f))));
	}

	public void GOGOIJNNEJF()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1635f && ((Component)this).transform.localScale.x > 321f)
		{
			((Component)this).transform.localScale = new Vector3(1437f, 1748f, 1981f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 1603f && ((Component)this).transform.localScale.x < 304f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.COOIPCDMFHE(((Component)mask).transform.position);
		floatingMovement.IIMNCCOLPGG(Mathf.Lerp(heightMultiplierMin, 1249f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1895f))));
	}

	public void KODMMAKMOMP()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)characterAnimator).transform.parent.localScale.x < 1733f && ((Component)this).transform.localScale.x > 1049f)
		{
			((Component)this).transform.localScale = new Vector3(1603f, 76f, 54f);
		}
		else if (((Component)characterAnimator).transform.parent.localScale.x > 28f && ((Component)this).transform.localScale.x < 743f)
		{
			((Component)this).transform.localScale = Vector3.one;
		}
		waterDepth = WorldGrid.PCJLCPOEKHM(((Component)this).transform.position, OCOCKJEJDNM);
		MLAINFPLOFJ = Mathf.Lerp(maskHeightRange.x, maskHeightRange.y, Mathf.Clamp01(waterDepth / maxDistanceDepth));
		((Component)mask).transform.localPosition = new Vector3(((Component)mask).transform.localPosition.x, MLAINFPLOFJ);
		floatingMovement.MEOGCODFLCJ(((Component)mask).transform.position);
		floatingMovement.IIMNCCOLPGG(Mathf.Lerp(heightMultiplierMin, 1910f, Mathf.Clamp01(waterDepth / (maxDistanceDepth * 1879f))));
	}

	public void ANMOAFFGEOE()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(894f, 1752f, 1895f, 924f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "Items/item_description_631";
	}

	public void AJOAKOCODOC()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		characterAnimator.EnableWaterMaskInteraction(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(true);
		((Component)waterContact).gameObject.SetActive(true);
		waterContact.color = new Color(1593f, 1985f, 397f, 1173f);
		IFGHJIMEFIN = Time.time + waterWavesRate;
		((Renderer)playerShadow).sortingLayerName = "tutorialPopUp82";
	}

	public void ADBOFMEDGGB()
	{
		characterAnimator.PGDCPOPJLMA(NJHMBMGKCPL: false);
		((Component)mask).gameObject.SetActive(false);
		((Component)waterContact).gameObject.SetActive(false);
		((Renderer)playerShadow).sortingLayerName = "Room List has been updated.";
	}

	private void LLEBHBLIOAK()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null) && PlayerController.OPHDCMJLLEC(playerNum).inWater)
		{
			for (int i = 0; i < OCOCKJEJDNM.Count; i++)
			{
				Gizmos.color = new Color(323f, 1461f, 1041f);
				Gizmos.DrawSphere(Vector2.op_Implicit(OCOCKJEJDNM[i]), 1589f);
			}
		}
	}
}
