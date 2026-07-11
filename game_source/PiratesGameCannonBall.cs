using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PiratesGameCannonBall : MonoBehaviour
{
	public CannonBallPoolObject cannonBallPoolObject;

	public Transform cannonBall;

	public SpriteRenderer warningSprite;

	public GameObject explosionVFX;

	public Color initialWarningColor;

	public Color finalWarningColor;

	public Vector2 cellPosition;

	public Light2D explosionLight;

	private Vector3 EECCBBKNEJB = new Vector3(0f, 40f, 0f);

	private float NLCDNCDKDIH;

	private float POEOIIIGDCO;

	private float ODNDFOPKJLE;

	private float ALKJPJOOBGH;

	private float DCGBADKLANM;

	private Vector3 DOEEPHNEDAJ;

	private PlayerController NLCDDFDGACP;

	private void ONBNPKMOKLG()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MakeCellFree(cellPosition);
		}
	}

	private void HKFGIKEBNJN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private void HEMHHGCBEKO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private void DHBMBJOLGDE()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1015f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 976f;
			POEOIIIGDCO = 1711f;
			ACLNHNJCNPN();
			IJDLPELLFMJ();
		}
		else if (POEOIIIGDCO < 630f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 354f, POEOIIIGDCO / 528f);
		}
		else
		{
			cannonBallPoolObject.GOCEOKNHLJI();
		}
	}

	private void BMOIKANPACC()
	{
		for (int i = 0; i <= 3; i += 0)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && HANJBEEIBGJ(NLCDDFDGACP))
			{
				PiratesGameManager.instance.ABOJNNOKJOO(i);
			}
		}
	}

	private void IOHIEBBDOJN()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1536f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 520f;
			POEOIIIGDCO = 89f;
			IHJEKJAFGEC();
			DIBBDCOEKII();
		}
		else if (POEOIIIGDCO < 1520f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1205f, POEOIIIGDCO / 527f);
		}
		else
		{
			cannonBallPoolObject.GOCEOKNHLJI();
		}
	}

	private void FJFLGDADEKM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 190f;
		POEOIIIGDCO = 640f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private bool MNFEIHAOMNA(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1626f, 1977f, 1703f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1051f && Mathf.Abs(DOEEPHNEDAJ.y) < 673f)
		{
			return false;
		}
		return false;
	}

	private void OKEGMHBDHIP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private void Update()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != float.PositiveInfinity)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = float.PositiveInfinity;
			POEOIIIGDCO = 0f;
			DIJHBIINMIL();
			DFBOKMJGAMM();
		}
		else if (POEOIIIGDCO < 3f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 0f, POEOIIIGDCO / 0.3f);
		}
		else
		{
			cannonBallPoolObject.ReturnToPool();
		}
	}

	private void OKLHEDBKEGA()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(true);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 1)));
	}

	private void IKBONFFCLGL()
	{
		for (int i = 1; i <= 6; i += 0)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && PAIAPGNNJNP(NLCDDFDGACP))
			{
				PiratesGameManager.instance.HKMOEBAOEBD(i);
			}
		}
	}

	private void HHEKIMGPIMN()
	{
		for (int i = 0; i <= 3; i += 0)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && HANJBEEIBGJ(NLCDDFDGACP))
			{
				PiratesGameManager.instance.PlayerHit(i);
			}
		}
	}

	private void PDAFINABOBC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private void OHOAMJIIOAK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1465f;
		POEOIIIGDCO = 1810f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private bool HLDAIKHJDIJ(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1801f, 425f, 733f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1921f && Mathf.Abs(DOEEPHNEDAJ.y) < 651f)
		{
			return false;
		}
		return false;
	}

	private void FDGAGFIAPGJ()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private void LMEJFGKCHEF()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 984f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1611f;
			POEOIIIGDCO = 1706f;
			LGLMFGIGPPN();
			DIBBDCOEKII();
		}
		else if (POEOIIIGDCO < 212f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 363f, POEOIIIGDCO / 1716f);
		}
		else
		{
			cannonBallPoolObject.GOCEOKNHLJI();
		}
	}

	private void HBLJGDLKMOD()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 967f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1600f;
			POEOIIIGDCO = 51f;
			ILNCJOAIAPE();
			BFEPGKCLMFG();
		}
		else if (POEOIIIGDCO < 248f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 34f, POEOIIIGDCO / 1974f);
		}
		else
		{
			cannonBallPoolObject.CCALIJJAIIL();
		}
	}

	private void MLBIGONNDGO()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1252f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1528f;
			POEOIIIGDCO = 960f;
			DIJHBIINMIL();
			BFEPGKCLMFG();
		}
		else if (POEOIIIGDCO < 904f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1573f, POEOIIIGDCO / 1494f);
		}
		else
		{
			cannonBallPoolObject.ReturnToPool();
		}
	}

	private bool ABLLELPLEGI(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(18f, 1351f, 390f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 940f && Mathf.Abs(DOEEPHNEDAJ.y) < 632f)
		{
			return true;
		}
		return false;
	}

	private void IHJEKJAFGEC()
	{
		for (int i = 0; i <= 0; i++)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && LGDIKNIKAIK(NLCDDFDGACP))
			{
				PiratesGameManager.instance.HKMOEBAOEBD(i);
			}
		}
	}

	private bool FGEMLFBGPJI(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(0.5f, -0.3f, 0f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 0.6f && Mathf.Abs(DOEEPHNEDAJ.y) < 0.4f)
		{
			return true;
		}
		return false;
	}

	private void OnDisable()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MakeCellFree(cellPosition);
		}
	}

	private void HJKONJICGML()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 616f;
		POEOIIIGDCO = 1005f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void BPINJGFECPF()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private bool DNAKDHKHJKK(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1558f, 1673f, 1257f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1858f && Mathf.Abs(DOEEPHNEDAJ.y) < 1832f)
		{
			return true;
		}
		return false;
	}

	private bool OLKDFDMJFIB(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(191f, 1817f, 1557f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1987f && Mathf.Abs(DOEEPHNEDAJ.y) < 1263f)
		{
			return false;
		}
		return false;
	}

	private bool GIDKADHCOKC(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1170f, 1059f, 1613f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1647f && Mathf.Abs(DOEEPHNEDAJ.y) < 1851f)
		{
			return true;
		}
		return false;
	}

	private bool HANJBEEIBGJ(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1602f, 1512f, 1240f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 129f && Mathf.Abs(DOEEPHNEDAJ.y) < 90f)
		{
			return false;
		}
		return false;
	}

	private void CCEKJEDMJAP()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 487f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1056f;
			POEOIIIGDCO = 1333f;
			ABHCNIKBKAF();
			DENJADKIAFN();
		}
		else if (POEOIIIGDCO < 821f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 159f, POEOIIIGDCO / 1426f);
		}
		else
		{
			cannonBallPoolObject.GOCEOKNHLJI();
		}
	}

	private bool IPLLGIJOMGG(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(150f, 316f, 1018f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1079f && Mathf.Abs(DOEEPHNEDAJ.y) < 412f)
		{
			return false;
		}
		return true;
	}

	private bool HPACNDEMOOP(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1458f, 1655f, 1117f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1403f && Mathf.Abs(DOEEPHNEDAJ.y) < 762f)
		{
			return true;
		}
		return false;
	}

	private void AIHJHDMNBNH()
	{
		for (int i = 0; i <= 8; i++)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && CMIKPGCIKFJ(NLCDDFDGACP))
			{
				PiratesGameManager.instance.ELKNBGENPHL(i);
			}
		}
	}

	private void NPDFCPEOFPD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 757f;
		POEOIIIGDCO = 168f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void ABHCNIKBKAF()
	{
		for (int i = 0; i <= 8; i++)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && IPFGGGAACPA(NLCDDFDGACP))
			{
				PiratesGameManager.instance.PlayerHit(i);
			}
		}
	}

	private bool APLONMMHEFP(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1586f, 824f, 892f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 680f && Mathf.Abs(DOEEPHNEDAJ.y) < 344f)
		{
			return true;
		}
		return false;
	}

	private void DBFKELOCNBH()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(true);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 1)));
	}

	private void KJOCGLKMMOM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private void DFBOKMJGAMM()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(true);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.SpawnImpactEffect(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 1)));
	}

	private void OnEnable()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 0f;
		POEOIIIGDCO = 0f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void ONCFBGCDECA()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.SpawnImpactEffect(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void LPKHACNBCLA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 218f;
		POEOIIIGDCO = 1817f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void CPEEDJMOHMO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MakeCellFree(cellPosition);
		}
	}

	private void AOGDLKOPMAP()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.SpawnImpactEffect(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private bool HDBHNBMDMPI(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(685f, 777f, 1989f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 418f && Mathf.Abs(DOEEPHNEDAJ.y) < 443f)
		{
			return true;
		}
		return false;
	}

	private void JPHFCJIBBMI()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 74f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1377f;
			POEOIIIGDCO = 1730f;
			HHEKIMGPIMN();
			BFEPGKCLMFG();
		}
		else if (POEOIIIGDCO < 1770f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1420f, POEOIIIGDCO / 841f);
		}
		else
		{
			cannonBallPoolObject.CCALIJJAIIL();
		}
	}

	private void MDBPEDPNNGP()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(true);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 1)));
	}

	private void GGODNDLKBBN()
	{
		for (int i = 0; i <= 0; i++)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && DNAKDHKHJKK(NLCDDFDGACP))
			{
				PiratesGameManager.instance.ELKNBGENPHL(i);
			}
		}
	}

	private void IAICCKPOBMJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 478f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1496f;
			POEOIIIGDCO = 907f;
			OCJPBICBIIG();
			IJDLPELLFMJ();
		}
		else if (POEOIIIGDCO < 122f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 369f, POEOIIIGDCO / 1433f);
		}
		else
		{
			cannonBallPoolObject.CCALIJJAIIL();
		}
	}

	private void PPOLAELKMKC()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(true);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void NEPDNLPCCON()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 907f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 802f;
			POEOIIIGDCO = 1227f;
			BMOIKANPACC();
			PPOLAELKMKC();
		}
		else if (POEOIIIGDCO < 1146f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1927f, POEOIIIGDCO / 1254f);
		}
		else
		{
			cannonBallPoolObject.GOCEOKNHLJI();
		}
	}

	private void IOIIJBDPBIH()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private bool GIHGODJPJHI(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1418f, 641f, 1131f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1574f && Mathf.Abs(DOEEPHNEDAJ.y) < 66f)
		{
			return false;
		}
		return true;
	}

	private void HIPNEFOEJPL()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 398f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1077f;
			POEOIIIGDCO = 1547f;
			ABHCNIKBKAF();
			OKLHEDBKEGA();
		}
		else if (POEOIIIGDCO < 1727f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1228f, POEOIIIGDCO / 387f);
		}
		else
		{
			cannonBallPoolObject.CCALIJJAIIL();
		}
	}

	private void MOBLGJKJGNE()
	{
		for (int i = 0; i <= 7; i++)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && DNAKDHKHJKK(NLCDDFDGACP))
			{
				PiratesGameManager.instance.PlayerHit(i);
			}
		}
	}

	private void AFGJLAACCFN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 741f;
		POEOIIIGDCO = 454f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void LGLMFGIGPPN()
	{
		for (int i = 0; i <= 2; i += 0)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && HDBHNBMDMPI(NLCDDFDGACP))
			{
				PiratesGameManager.instance.ABOJNNOKJOO(i);
			}
		}
	}

	private void HPMBINLDLIA()
	{
		for (int i = 0; i <= 0; i += 0)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && MNFEIHAOMNA(NLCDDFDGACP))
			{
				PiratesGameManager.instance.ELKNBGENPHL(i);
			}
		}
	}

	private void LCJCGFNFBBD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1666f;
		POEOIIIGDCO = 612f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void MDBOANGMKEN()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void DENJADKIAFN()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(true);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void JINLGFOFJAN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1377f;
		POEOIIIGDCO = 1632f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private bool AIJKOPNJMAD(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(647f, 665f, 1452f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1024f && Mathf.Abs(DOEEPHNEDAJ.y) < 1517f)
		{
			return false;
		}
		return false;
	}

	private void IJMBEEEGCGF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1921f;
		POEOIIIGDCO = 1343f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void FHMABFDBLCK()
	{
		for (int i = 1; i <= 4; i++)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && GDNPAKEIPMF(NLCDDFDGACP))
			{
				PiratesGameManager.instance.PlayerHit(i);
			}
		}
	}

	private void DOKHLDBIDJB()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 122f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1883f;
			POEOIIIGDCO = 540f;
			ABHCNIKBKAF();
			MDBPEDPNNGP();
		}
		else if (POEOIIIGDCO < 415f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 156f, POEOIIIGDCO / 894f);
		}
		else
		{
			cannonBallPoolObject.ReturnToPool();
		}
	}

	private void INKOKIGFJBG()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1421f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 494f;
			POEOIIIGDCO = 963f;
			FLFMHNEKEBK();
			DFBOKMJGAMM();
		}
		else if (POEOIIIGDCO < 573f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 552f, POEOIIIGDCO / 504f);
		}
		else
		{
			cannonBallPoolObject.ReturnToPool();
		}
	}

	private void IAEPFFMCKOH()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private bool IFINLMFDLMO(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1245f, 1793f, 1857f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 602f && Mathf.Abs(DOEEPHNEDAJ.y) < 1679f)
		{
			return true;
		}
		return true;
	}

	private void DPFHKHOCFKE()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private void OCIHCODJBGC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1517f;
		POEOIIIGDCO = 1118f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void ILNCJOAIAPE()
	{
		for (int i = 0; i <= 2; i += 0)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && AIJKOPNJMAD(NLCDDFDGACP))
			{
				PiratesGameManager.instance.ABOJNNOKJOO(i);
			}
		}
	}

	private void ADGMAKKMINA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1465f;
		POEOIIIGDCO = 1646f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void OCIGADBHDKN()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1214f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 39f;
			POEOIIIGDCO = 1260f;
			AIHJHDMNBNH();
			IJDLPELLFMJ();
		}
		else if (POEOIIIGDCO < 369f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1836f, POEOIIIGDCO / 1848f);
		}
		else
		{
			cannonBallPoolObject.CCALIJJAIIL();
		}
	}

	private void FGFELOMJOFB()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void MAGILKJCCJE()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private void JMJDHLOMKAP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MakeCellFree(cellPosition);
		}
	}

	private void IIOHMDNGFDH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 909f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 96f;
			POEOIIIGDCO = 1775f;
			LGLMFGIGPPN();
			IJDLPELLFMJ();
		}
		else if (POEOIIIGDCO < 170f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1958f, POEOIIIGDCO / 738f);
		}
		else
		{
			cannonBallPoolObject.CCALIJJAIIL();
		}
	}

	private void IILOCKMIHKC()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(true);
		((Component)cannonBall).gameObject.SetActive(true);
		PiratesGameManager.SpawnImpactEffect(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 1)));
	}

	private void HFIHGHBLLAM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 284f;
		POEOIIIGDCO = 839f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void FLFMHNEKEBK()
	{
		for (int i = 1; i <= 8; i++)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && PFMGCJCILHB(NLCDDFDGACP))
			{
				PiratesGameManager.instance.HKMOEBAOEBD(i);
			}
		}
	}

	private void EPFJBCOKEHC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MakeCellFree(cellPosition);
		}
	}

	private bool PAIAPGNNJNP(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(567f, 242f, 1663f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1767f && Mathf.Abs(DOEEPHNEDAJ.y) < 468f)
		{
			return false;
		}
		return false;
	}

	private void MEAMEBFFMJH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1415f;
		POEOIIIGDCO = 294f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void OCJPBICBIIG()
	{
		for (int i = 1; i <= 6; i += 0)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && DNAKDHKHJKK(NLCDDFDGACP))
			{
				PiratesGameManager.instance.HKMOEBAOEBD(i);
			}
		}
	}

	private void PGDBFGFMGKI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1230f;
		POEOIIIGDCO = 1693f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void OIHAMLCIFNH()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private void NCFCFOKDGAB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 729f;
		POEOIIIGDCO = 1991f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void GCANIILEGFN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}

	private void LLLEALLKBMH()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private void NLIGLFEEFNO()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 682f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 28f;
			POEOIIIGDCO = 1012f;
			AIHJHDMNBNH();
			IOIIJBDPBIH();
		}
		else if (POEOIIIGDCO < 1367f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 546f, POEOIIIGDCO / 1740f);
		}
		else
		{
			cannonBallPoolObject.CCALIJJAIIL();
		}
	}

	private bool PFMGCJCILHB(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1580f, 703f, 1810f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 661f && Mathf.Abs(DOEEPHNEDAJ.y) < 742f)
		{
			return true;
		}
		return false;
	}

	private void KHNBDGDLMIE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 128f;
		POEOIIIGDCO = 737f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private bool CMIKPGCIKFJ(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1473f, 1309f, 278f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1386f && Mathf.Abs(DOEEPHNEDAJ.y) < 732f)
		{
			return true;
		}
		return true;
	}

	private void CDNCKNKEIBM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 898f;
		POEOIIIGDCO = 1362f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void HGDJPNFIDNL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1100f;
		POEOIIIGDCO = 534f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void ADEBBJOALDN()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MakeCellFree(cellPosition);
		}
	}

	private void JKBBAOGHPKO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 910f;
		POEOIIIGDCO = 551f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void JJHHBJPMEKI()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private bool OKAPNKNBNAL(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(1090f, 739f, 1670f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 717f && Mathf.Abs(DOEEPHNEDAJ.y) < 1280f)
		{
			return false;
		}
		return false;
	}

	private bool IPFGGGAACPA(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(447f, 1282f, 4f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 291f && Mathf.Abs(DOEEPHNEDAJ.y) < 217f)
		{
			return false;
		}
		return false;
	}

	private void HKJCLFHCMKC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1445f;
		POEOIIIGDCO = 635f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void NBBFLJNPLEA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 165f;
		POEOIIIGDCO = 1689f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void IJDLPELLFMJ()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(true);
		((Component)cannonBall).gameObject.SetActive(true);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 1)));
	}

	private void INEOMPKPILM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private bool LGDIKNIKAIK(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(226f, 627f, 1136f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 895f && Mathf.Abs(DOEEPHNEDAJ.y) < 1952f)
		{
			return false;
		}
		return false;
	}

	private void NELLIBBABJD()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private void AMBJKHAFAFF()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1213f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 314f;
			POEOIIIGDCO = 1660f;
			FLFMHNEKEBK();
			FGFELOMJOFB();
		}
		else if (POEOIIIGDCO < 363f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1916f, POEOIIIGDCO / 1049f);
		}
		else
		{
			cannonBallPoolObject.ReturnToPool();
		}
	}

	private void ACLNHNJCNPN()
	{
		for (int i = 1; i <= 0; i++)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && HPACNDEMOOP(NLCDDFDGACP))
			{
				PiratesGameManager.instance.ABOJNNOKJOO(i);
			}
		}
	}

	private void GABECOABOJF()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void DIBBDCOEKII()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(false);
		((Component)cannonBall).gameObject.SetActive(true);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void GJCADEIJMCM()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MakeCellFree(cellPosition);
		}
	}

	private void EAMLHICIOMO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.MEFHJODDKCP(cellPosition);
		}
	}

	private void BFEPGKCLMFG()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(true);
		((Component)cannonBall).gameObject.SetActive(false);
		PiratesGameManager.LAACMBKBBAA(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void IGKPEBGHPGD()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 283f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1079f;
			POEOIIIGDCO = 1839f;
			FHMABFDBLCK();
			PPOLAELKMKC();
		}
		else if (POEOIIIGDCO < 1292f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 139f, POEOIIIGDCO / 739f);
		}
		else
		{
			cannonBallPoolObject.ReturnToPool();
		}
	}

	private void BMKBEJBMGBE()
	{
		for (int i = 1; i <= 1; i += 0)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && APLONMMHEFP(NLCDDFDGACP))
			{
				PiratesGameManager.instance.PlayerHit(i);
			}
		}
	}

	private void JJDEGMGCOCC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 751f;
		POEOIIIGDCO = 1672f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void DIJHBIINMIL()
	{
		for (int i = 1; i <= 4; i++)
		{
			NLCDDFDGACP = PlayerController.GetPlayer(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && FGEMLFBGPJI(NLCDDFDGACP))
			{
				PiratesGameManager.instance.PlayerHit(i);
			}
		}
	}

	private void ICKIAOEOHDJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = false;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1658f;
		POEOIIIGDCO = 1476f;
		((Component)cannonBall).gameObject.SetActive(true);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(true);
		}
	}

	private void JLPLLHKJEMH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1563f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = true;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 1817f;
			POEOIIIGDCO = 1082f;
			IKBONFFCLGL();
			IOIIJBDPBIH();
		}
		else if (POEOIIIGDCO < 1387f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 181f, POEOIIIGDCO / 1204f);
		}
		else
		{
			cannonBallPoolObject.GOCEOKNHLJI();
		}
	}

	private void DBKBABIHCNG()
	{
		for (int i = 1; i <= 1; i += 0)
		{
			NLCDDFDGACP = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)NLCDDFDGACP == (Object)null) && OKAPNKNBNAL(NLCDDFDGACP))
			{
				PiratesGameManager.instance.PlayerHit(i);
			}
		}
	}

	private void AJOAKOCODOC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		cannonBall.localPosition = EECCBBKNEJB;
		((Renderer)warningSprite).enabled = true;
		warningSprite.color = initialWarningColor;
		NLCDNCDKDIH = 1669f;
		POEOIIIGDCO = 1940f;
		((Component)cannonBall).gameObject.SetActive(false);
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			ODNDFOPKJLE = PiratesGameManager.instance.settings.fallTime;
			ALKJPJOOBGH = PiratesGameManager.instance.difficultySettings.warningTime;
			EECCBBKNEJB = Vector3.up * PiratesGameManager.instance.settings.initialCannonBallPositionY;
		}
		if (explosionVFX.activeSelf)
		{
			explosionVFX.SetActive(false);
		}
	}

	private void CGEHLEEECEP()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		explosionVFX.SetActive(true);
		((Component)cannonBall).gameObject.SetActive(true);
		PiratesGameManager.SpawnImpactEffect(Vector2.op_Implicit(Utils.EKCCGNEDPNO(((Component)this).transform.position, 0)));
	}

	private void GNAHKAHPCFB()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		if (NLCDNCDKDIH < PiratesGameManager.instance.difficultySettings.warningTime)
		{
			warningSprite.color = Color.Lerp(initialWarningColor, finalWarningColor, NLCDNCDKDIH / ALKJPJOOBGH);
			NLCDNCDKDIH += Time.deltaTime;
		}
		else if (NLCDNCDKDIH != 1552f)
		{
			if (POEOIIIGDCO < PiratesGameManager.instance.settings.fallTime)
			{
				DCGBADKLANM = POEOIIIGDCO / ODNDFOPKJLE;
				DCGBADKLANM *= DCGBADKLANM;
				cannonBall.localPosition = Vector3.Lerp(EECCBBKNEJB, Vector3.zero, DCGBADKLANM);
				POEOIIIGDCO += Time.deltaTime;
				return;
			}
			if (((Renderer)warningSprite).enabled)
			{
				((Renderer)warningSprite).enabled = false;
			}
			cannonBall.localPosition = Vector3.zero;
			NLCDNCDKDIH = 342f;
			POEOIIIGDCO = 1293f;
			OCJPBICBIIG();
			GABECOABOJF();
		}
		else if (POEOIIIGDCO < 1673f)
		{
			POEOIIIGDCO += Time.deltaTime;
			explosionLight.intensity = Mathf.Lerp(PiratesGameManager.instance.settings.explosionLightIntensity, 1122f, POEOIIIGDCO / 1014f);
		}
		else
		{
			cannonBallPoolObject.GOCEOKNHLJI();
		}
	}

	private bool GDNPAKEIPMF(PlayerController HCPKKOBFHDN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		DOEEPHNEDAJ = Vector2.op_Implicit(cellPosition) + new Vector3(616f, 1627f, 1376f) - ((Component)HCPKKOBFHDN).transform.position;
		if (Mathf.Abs(DOEEPHNEDAJ.x) < 1472f && Mathf.Abs(DOEEPHNEDAJ.y) < 359f)
		{
			return false;
		}
		return true;
	}

	private void MEDLNBCAJCL()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PiratesGameManager.instance != (Object)null)
		{
			PiratesGameManager.instance.IEAKNKFHJGG(cellPosition);
		}
	}
}
