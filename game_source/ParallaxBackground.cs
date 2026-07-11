using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
	public static ParallaxBackground instance;

	public Transform parallaxContent;

	public ParallaxLayer[] parallaxLayers;

	public SpriteRenderer[] skySpriteRenderers;

	public SpriteRenderer[] sunsetSpriteRenderers;

	public SpriteRenderer[] nightSpriteRenderers;

	public SpriteRenderer[] stars;

	public SpriteRenderer[] baseSpriteRenderers;

	public SpriteRenderer[] baseCloudsSpriteRenderers;

	public SpriteRenderer[] nightCloudsSpriteRenderers;

	public SpriteRenderer cloudySky;

	[Tooltip("GameObjects to activate when the weather is cloudy")]
	public GameObject[] cloudyGameObjectsToActivate;

	[Tooltip("GameObjects to deactivate when the weather is cloudy")]
	public GameObject[] cloudyGameObjectsToDeactivate;

	public Sprite[] sunriseSprites;

	public Sprite[] sunsetSprites;

	public ParallaxFogParticles[] fogParticles;

	public Transform moonParent;

	public Transform moon;

	public Vector2 maxParallaxDisplacement = new Vector2(10f, 5f);

	public Vector2 maxParallaxPosition;

	public Vector2 minParallaxPosition;

	public Vector2 maxCameraPosition;

	public Vector2 minCameraPosition;

	public Color cloudyBaseTint = new Color(0.8f, 0.8f, 0.8f);

	public Color cloudyBaseCloudsTint = new Color(0.7f, 0.7f, 0.7f);

	public Color cloudyNightCloudsTint = new Color(0.4f, 0.4f, 0.4f);

	private Vector2 GANGIABPKEJ;

	private float OLLBKGHNHNC;

	private float JLLLGPGBCOK;

	private float PLAJPAEMMLC;

	private float NKBNMECJNJH;

	private Vector2 FMJGLNEFOPE;

	private Color BNGKHCDELOD;

	public void MACFLEPLHAG(Color FLABEDBELMF)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < fogParticles.Length; i += 0)
		{
			fogParticles[i].HIJAPNAPAAL(FLABEDBELMF);
		}
	}

	private void JNNJIDAFBPI()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
			if ((Object)(object)Weather.instance != (Object)null)
			{
				WeatherUI.instance.EINPNGDJGBK(skySpriteRenderers, sunriseSprites, sunsetSprites, sunsetSpriteRenderers, nightSpriteRenderers, stars);
			}
		}
	}

	public void BGGDEHBCMFD(float GLOEPFGFIME)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		moonParent.localEulerAngles = new Vector3(1353f, 1585f, GLOEPFGFIME);
		moon.eulerAngles = Vector3.zero;
		moon.localPosition = Vector2.op_Implicit(FMJGLNEFOPE);
		moon.position = Utils.EKCCGNEDPNO(moon.position, 0);
	}

	public void FFKENCEPLDB(Color FLABEDBELMF)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < fogParticles.Length; i += 0)
		{
			fogParticles[i].LCNDHMMCEMJ(FLABEDBELMF);
		}
	}

	public void AKBGGGELEAI(Color FLABEDBELMF)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (IsCloudy())
		{
			cloudySky.color = FLABEDBELMF;
		}
	}

	private void ONNAGOCFJML()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		instance = this;
		MKHGBGFPGJF();
		WeatherUI.instance.IGJCDDIOOHN(skySpriteRenderers, sunriseSprites, sunsetSprites, sunsetSpriteRenderers, nightSpriteRenderers, stars);
		FMJGLNEFOPE = Vector2.op_Implicit(moon.localPosition);
		for (int i = 0; i < parallaxLayers.Length; i += 0)
		{
			parallaxLayers[i].DGOPHOOPGOM(this);
		}
	}

	public void SetMoonRotation(float GLOEPFGFIME)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		moonParent.localEulerAngles = new Vector3(0f, 0f, GLOEPFGFIME);
		moon.eulerAngles = Vector3.zero;
		moon.localPosition = Vector2.op_Implicit(FMJGLNEFOPE);
		moon.position = Utils.EKCCGNEDPNO(moon.position, 1);
	}

	public static void MHILKJPMINO(int JIIGOACEIKL)
	{
		if ((Object)(object)instance != (Object)null)
		{
			instance.LJAANLBEFBI(JIIGOACEIKL);
		}
	}

	private void LMPCDDGFBGD()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		instance = this;
		MKHGBGFPGJF();
		WeatherUI.instance.FCOHNKMHKDL(skySpriteRenderers, sunriseSprites, sunsetSprites, sunsetSpriteRenderers, nightSpriteRenderers, stars);
		FMJGLNEFOPE = Vector2.op_Implicit(moon.localPosition);
		for (int i = 0; i < parallaxLayers.Length; i++)
		{
			parallaxLayers[i].SetupParallaxLayer(this);
		}
	}

	public static bool HLGGPIIJJGA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		return ((Renderer)instance.cloudySky).enabled;
	}

	public void APIIIDLOJPI(Color FLABEDBELMF)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (HLGGPIIJJGA())
		{
			cloudySky.color = FLABEDBELMF;
		}
	}

	public void UpdateParticlesColor(Color FLABEDBELMF)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < fogParticles.Length; i++)
		{
			fogParticles[i].UpdateParticlesColor(FLABEDBELMF);
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
			if ((Object)(object)Weather.instance != (Object)null)
			{
				WeatherUI.instance.RemoveSkySprites(skySpriteRenderers, sunriseSprites, sunsetSprites, sunsetSpriteRenderers, nightSpriteRenderers, stars);
			}
		}
	}

	public void NKCMBPICGPB(Color FLABEDBELMF)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < fogParticles.Length; i += 0)
		{
			fogParticles[i].NOOIPIMEGMH(FLABEDBELMF);
		}
	}

	public static void RenderParallax(int JIIGOACEIKL)
	{
		if ((Object)(object)instance != (Object)null)
		{
			instance.LJAANLBEFBI(JIIGOACEIKL);
		}
	}

	public void ELKBBMKICLJ(float GLOEPFGFIME)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		moonParent.localEulerAngles = new Vector3(1625f, 1139f, GLOEPFGFIME);
		moon.eulerAngles = Vector3.zero;
		moon.localPosition = Vector2.op_Implicit(FMJGLNEFOPE);
		moon.position = Utils.EKCCGNEDPNO(moon.position, 0);
	}

	private void LJAANLBEFBI(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		GANGIABPKEJ = Vector2.op_Implicit(((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL)).transform.position);
		OLLBKGHNHNC = Mathf.InverseLerp(minCameraPosition.x, maxCameraPosition.x, GANGIABPKEJ.x);
		JLLLGPGBCOK = Mathf.InverseLerp(minCameraPosition.y, maxCameraPosition.y, GANGIABPKEJ.y);
		PLAJPAEMMLC = Mathf.Lerp(minParallaxPosition.x, maxParallaxPosition.x, OLLBKGHNHNC);
		NKBNMECJNJH = Mathf.Lerp(minParallaxPosition.y, maxParallaxPosition.y, JLLLGPGBCOK);
		parallaxContent.localPosition = new Vector3(PLAJPAEMMLC, NKBNMECJNJH, ((Component)this).transform.position.z);
		parallaxContent.position = Utils.EKCCGNEDPNO(parallaxContent.position, JIIGOACEIKL);
		for (int i = 0; i < parallaxLayers.Length; i++)
		{
			parallaxLayers[i].SetParallaxMovement(OLLBKGHNHNC, JLLLGPGBCOK, JIIGOACEIKL);
		}
	}

	public static bool HNFFHMHFCIO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return ((Renderer)instance.cloudySky).enabled;
	}

	public static void KAEBEPOOIOJ(int JIIGOACEIKL)
	{
		if ((Object)(object)instance != (Object)null)
		{
			instance.FNMDJEPHGIF(JIIGOACEIKL);
		}
	}

	private void OnEnable()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		instance = this;
		MKHGBGFPGJF();
		WeatherUI.instance.AddSkySprites(skySpriteRenderers, sunriseSprites, sunsetSprites, sunsetSpriteRenderers, nightSpriteRenderers, stars);
		FMJGLNEFOPE = Vector2.op_Implicit(moon.localPosition);
		for (int i = 0; i < parallaxLayers.Length; i++)
		{
			parallaxLayers[i].SetupParallaxLayer(this);
		}
	}

	public void UpdateCloudySkyColor(Color FLABEDBELMF)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (IsCloudy())
		{
			cloudySky.color = FLABEDBELMF;
		}
	}

	private void MKHGBGFPGJF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Weather.instance == (Object)null)
		{
			return;
		}
		if (Weather.currentWeather.HasFlag(Weather.WeatherType.Cloudy) || Weather.currentWeather.HasFlag(Weather.WeatherType.StormClouds) || Weather.currentWeather.HasFlag(Weather.WeatherType.Rain) || Weather.currentWeather.HasFlag(Weather.WeatherType.Snow) || Weather.currentWeather.HasFlag(Weather.WeatherType.PrecipitationStormyClouds))
		{
			for (int i = 0; i < baseSpriteRenderers.Length; i++)
			{
				baseSpriteRenderers[i].color = cloudyBaseTint;
			}
			for (int j = 0; j < baseCloudsSpriteRenderers.Length; j++)
			{
				baseCloudsSpriteRenderers[j].color = cloudyBaseCloudsTint;
			}
			BNGKHCDELOD.g = cloudyNightCloudsTint.g;
			BNGKHCDELOD.b = cloudyNightCloudsTint.b;
			BNGKHCDELOD.r = cloudyNightCloudsTint.r;
			for (int k = 0; k < nightCloudsSpriteRenderers.Length; k++)
			{
				BNGKHCDELOD.a = nightCloudsSpriteRenderers[k].color.a;
				nightCloudsSpriteRenderers[k].color = BNGKHCDELOD;
			}
			((Renderer)cloudySky).enabled = true;
			for (int l = 0; l < cloudyGameObjectsToActivate.Length; l++)
			{
				if ((Object)(object)cloudyGameObjectsToActivate[l] != (Object)null)
				{
					cloudyGameObjectsToActivate[l].SetActive(true);
				}
			}
			for (int m = 0; m < cloudyGameObjectsToDeactivate.Length; m++)
			{
				if ((Object)(object)cloudyGameObjectsToDeactivate[m] != (Object)null)
				{
					cloudyGameObjectsToDeactivate[m].SetActive(false);
				}
			}
			return;
		}
		for (int n = 0; n < baseSpriteRenderers.Length; n++)
		{
			baseSpriteRenderers[n].color = Color.white;
		}
		for (int num = 0; num < baseCloudsSpriteRenderers.Length; num++)
		{
			baseCloudsSpriteRenderers[num].color = Color.white;
		}
		BNGKHCDELOD.g = 1f;
		BNGKHCDELOD.b = 1f;
		BNGKHCDELOD.r = 1f;
		for (int num2 = 0; num2 < nightCloudsSpriteRenderers.Length; num2++)
		{
			BNGKHCDELOD.a = nightCloudsSpriteRenderers[num2].color.a;
			nightCloudsSpriteRenderers[num2].color = BNGKHCDELOD;
		}
		((Renderer)cloudySky).enabled = false;
		for (int num3 = 0; num3 < cloudyGameObjectsToActivate.Length; num3++)
		{
			if ((Object)(object)cloudyGameObjectsToActivate[num3] != (Object)null)
			{
				cloudyGameObjectsToActivate[num3].SetActive(false);
			}
		}
		for (int num4 = 0; num4 < cloudyGameObjectsToDeactivate.Length; num4++)
		{
			if ((Object)(object)cloudyGameObjectsToDeactivate[num4] != (Object)null)
			{
				cloudyGameObjectsToDeactivate[num4].SetActive(true);
			}
		}
	}

	public void EKDPBBGMAFI(Color FLABEDBELMF)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (HNFFHMHFCIO())
		{
			cloudySky.color = FLABEDBELMF;
		}
	}

	private void FNMDJEPHGIF(int JIIGOACEIKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		GANGIABPKEJ = Vector2.op_Implicit(((Component)CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(JIIGOACEIKL)).transform.position);
		OLLBKGHNHNC = Mathf.InverseLerp(minCameraPosition.x, maxCameraPosition.x, GANGIABPKEJ.x);
		JLLLGPGBCOK = Mathf.InverseLerp(minCameraPosition.y, maxCameraPosition.y, GANGIABPKEJ.y);
		PLAJPAEMMLC = Mathf.Lerp(minParallaxPosition.x, maxParallaxPosition.x, OLLBKGHNHNC);
		NKBNMECJNJH = Mathf.Lerp(minParallaxPosition.y, maxParallaxPosition.y, JLLLGPGBCOK);
		parallaxContent.localPosition = new Vector3(PLAJPAEMMLC, NKBNMECJNJH, ((Component)this).transform.position.z);
		parallaxContent.position = Utils.EKCCGNEDPNO(parallaxContent.position, JIIGOACEIKL);
		for (int i = 1; i < parallaxLayers.Length; i += 0)
		{
			parallaxLayers[i].LBNJDMPILCP(OLLBKGHNHNC, JLLLGPGBCOK, JIIGOACEIKL);
		}
	}

	public void MNGNMKBIDGF(float GLOEPFGFIME)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		moonParent.localEulerAngles = new Vector3(294f, 646f, GLOEPFGFIME);
		moon.eulerAngles = Vector3.zero;
		moon.localPosition = Vector2.op_Implicit(FMJGLNEFOPE);
		moon.position = Utils.EKCCGNEDPNO(moon.position, 1);
	}

	public void PMGNKKNNDIA(Color FLABEDBELMF)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < fogParticles.Length; i += 0)
		{
			fogParticles[i].BKOHCFDCCIC(FLABEDBELMF);
		}
	}

	public static bool IsCloudy()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return ((Renderer)instance.cloudySky).enabled;
	}
}
