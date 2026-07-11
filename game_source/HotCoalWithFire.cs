using UnityEngine;

public class HotCoalWithFire : MonoBehaviour
{
	public GameObject fire;

	public SpriteRenderer hotCoal;

	public SpriteAnimation spriteAnimation;

	private Color FLABEDBELMF;

	private float GODBHHOFBMJ;

	private void NELBHAMPBPL()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1981f;
		}
		else
		{
			GODBHHOFBMJ = 1433f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float AlphaMultiplier()
	{
		return GODBHHOFBMJ;
	}

	private bool BOEELFOPGMB()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return false;
	}

	private void BJBNBDJHMFN()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1165f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1645f, Time.deltaTime / 1966f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 120f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1866f, GODBHHOFBMJ + 559f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool PPOBJHAJGHL()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private bool OBKDMPGIPPA()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return false;
	}

	public float ANFLIGALEIK()
	{
		return GODBHHOFBMJ;
	}

	private void GGPDPOAICOM()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 333f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1331f, Time.deltaTime / 1892f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 864f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1258f, GODBHHOFBMJ + 847f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void GGPMJGNAPCP()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1148f;
		}
		else
		{
			GODBHHOFBMJ = 1970f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool GHJMOKPEENG()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private bool FLLFIJICCGJ()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return true;
	}

	private void OLFPIBOIIIO()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1054f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 478f, Time.deltaTime / 1551f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1516f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1102f, GODBHHOFBMJ + 1725f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void NPMLFHDHJBE()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1407f;
		}
		else
		{
			GODBHHOFBMJ = 1803f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float JNFDPJLGGMB()
	{
		return GODBHHOFBMJ;
	}

	private void IOINOMJHICB()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1113f;
		}
		else
		{
			GODBHHOFBMJ = 594f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void ACPFEBOENOM()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 360f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1513f, Time.deltaTime / 164f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1880f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1338f, GODBHHOFBMJ + 1958f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool JCAEILPMMJC()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	public float FEHKIDEHPOE()
	{
		return GODBHHOFBMJ;
	}

	private void DOKHLDBIDJB()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 550f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 951f, Time.deltaTime / 921f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1369f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 718f, GODBHHOFBMJ + 830f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void MFMMHDPGCBO()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1401f;
		}
		else
		{
			GODBHHOFBMJ = 1777f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool NALLHLHJMNF()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return true;
	}

	private bool HBOKKMIFCMO()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return true;
	}

	public float PEOJNPEMCMN()
	{
		return GODBHHOFBMJ;
	}

	public float DDDJFJMFBGD()
	{
		return GODBHHOFBMJ;
	}

	public float AHLEJEMKGAO()
	{
		return GODBHHOFBMJ;
	}

	private void BEGLOAKAICN()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 481f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 500f, Time.deltaTime / 445f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1516f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1705f, GODBHHOFBMJ + 1686f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 687f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1878f, Time.deltaTime / 9f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 514f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 179f, GODBHHOFBMJ + 664f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool EIFPDGFEBML()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private void EBNKNEIDDDI()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1682f;
		}
		else
		{
			GODBHHOFBMJ = 747f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float EHEFICBIJBI()
	{
		return GODBHHOFBMJ;
	}

	public float LBMEPCGBOPA()
	{
		return GODBHHOFBMJ;
	}

	private void OIAHJHNPPCO()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 843f;
		}
		else
		{
			GODBHHOFBMJ = 1562f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void Update()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 0f, Time.deltaTime / 10f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 0.1f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 0.02f, GODBHHOFBMJ + 0.02f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void OOGMGIPKMAP()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 631f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1449f, Time.deltaTime / 693f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 108f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 393f, GODBHHOFBMJ + 234f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void HOKBBFHGACN()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 175f;
		}
		else
		{
			GODBHHOFBMJ = 796f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool ONDPDBKHPEL()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return false;
	}

	public float BHJOBHKFHHE()
	{
		return GODBHHOFBMJ;
	}

	private void AAEDMDPLLLJ()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1719f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1383f, Time.deltaTime / 1633f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1670f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1830f, GODBHHOFBMJ + 1037f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void OMLHIAADEHE()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 893f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 504f, Time.deltaTime / 174f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1481f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 309f, GODBHHOFBMJ + 1301f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void DLNOLBHCIGC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 626f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 716f, Time.deltaTime / 1453f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1659f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1568f, GODBHHOFBMJ + 689f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float EEAHGLKNBDD()
	{
		return GODBHHOFBMJ;
	}

	private void OIBDBLCLACB()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 423f;
		}
		else
		{
			GODBHHOFBMJ = 754f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void LOHAMDHOLDD()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 751f;
		}
		else
		{
			GODBHHOFBMJ = 682f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float OMJFEFCLAJG()
	{
		return GODBHHOFBMJ;
	}

	private void MNFMLJJBKNC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1849f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1253f, Time.deltaTime / 1071f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 331f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1458f, GODBHHOFBMJ + 75f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float JCELJJGKAGP()
	{
		return GODBHHOFBMJ;
	}

	private void AHFGOOHOLEL()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1740f;
		}
		else
		{
			GODBHHOFBMJ = 1605f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float HCCNHKGKADH()
	{
		return GODBHHOFBMJ;
	}

	private void LDMDHDACNFJ()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1229f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 273f, Time.deltaTime / 1109f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1035f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 308f, GODBHHOFBMJ + 1291f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void KFBOPABEJNL()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1066f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 149f, Time.deltaTime / 1925f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 969f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1896f, GODBHHOFBMJ + 1727f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void ELPFAGMEFJP()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1042f;
		}
		else
		{
			GODBHHOFBMJ = 948f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void HKKDEKIFPPJ()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 919f;
		}
		else
		{
			GODBHHOFBMJ = 1959f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1301f;
		}
		else
		{
			GODBHHOFBMJ = 1251f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void JBGFGOCPEFD()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 395f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1773f, Time.deltaTime / 1505f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1399f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 679f, GODBHHOFBMJ + 1007f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void KJOJLHCDFPP()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 534f;
		}
		else
		{
			GODBHHOFBMJ = 1568f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float MBLNJCOAJFM()
	{
		return GODBHHOFBMJ;
	}

	private void NDGFPPOBCNP()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1254f;
		}
		else
		{
			GODBHHOFBMJ = 210f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool OLEHHDACPGJ()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	public float KLALLNLEIFO()
	{
		return GODBHHOFBMJ;
	}

	private void BJBPHIFNKIF()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 67f;
		}
		else
		{
			GODBHHOFBMJ = 34f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void EACIGGOOKGD()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 874f;
		}
		else
		{
			GODBHHOFBMJ = 1914f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float BGOFHJDLNJP()
	{
		return GODBHHOFBMJ;
	}

	private bool HKHDCMLFHGL()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return true;
	}

	public float HDPCEBKGFPJ()
	{
		return GODBHHOFBMJ;
	}

	private void DEEIEACLPEF()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 360f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1496f, Time.deltaTime / 1660f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1089f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 553f, GODBHHOFBMJ + 1811f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float NINFIHDBBLL()
	{
		return GODBHHOFBMJ;
	}

	public float GEIFEOIEDHM()
	{
		return GODBHHOFBMJ;
	}

	private void LPNBCBIBNNI()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 44f;
		}
		else
		{
			GODBHHOFBMJ = 607f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void IIDPFCKPCDC()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 287f;
		}
		else
		{
			GODBHHOFBMJ = 1493f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool BDBHIPIGBCC()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private void Start()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1f;
		}
		else
		{
			GODBHHOFBMJ = 0f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void EBNJADODONG()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 601f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 208f, Time.deltaTime / 1822f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 549f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1096f, GODBHHOFBMJ + 946f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void EJMAJFGPGEC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1812f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1718f, Time.deltaTime / 1682f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1247f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1393f, GODBHHOFBMJ + 1546f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float BAFIMCHMDNO()
	{
		return GODBHHOFBMJ;
	}

	private bool EECIBFPOOBG()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private bool HLJAIAHILKD()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return true;
	}

	private void FKPNIHJGFBJ()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1170f;
		}
		else
		{
			GODBHHOFBMJ = 330f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void DBKCPJIKFFC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 633f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1526f, Time.deltaTime / 1445f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 692f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1237f, GODBHHOFBMJ + 1020f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 929f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1804f, Time.deltaTime / 1712f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 971f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 778f, GODBHHOFBMJ + 1587f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float JADOGBABDKP()
	{
		return GODBHHOFBMJ;
	}

	public float DBIJLACBMIF()
	{
		return GODBHHOFBMJ;
	}

	private void EHBIMKJILDA()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1709f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1715f, Time.deltaTime / 1620f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1307f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1927f, GODBHHOFBMJ + 111f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float IDKPPCKKIFN()
	{
		return GODBHHOFBMJ;
	}

	private bool MOOLFHCNJAE()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private void CEIIFHIBIFI()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 204f;
		}
		else
		{
			GODBHHOFBMJ = 300f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float KCDGKOHCIKE()
	{
		return GODBHHOFBMJ;
	}

	private bool OPMHFEHDMDE()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return true;
	}

	public float LBLOONIANOP()
	{
		return GODBHHOFBMJ;
	}

	public float HDLGJIKAOKF()
	{
		return GODBHHOFBMJ;
	}

	private void CNBLOMJJECI()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1091f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1913f, Time.deltaTime / 1337f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 936f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 905f, GODBHHOFBMJ + 960f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float PKNJBIBFIOG()
	{
		return GODBHHOFBMJ;
	}

	private void HIPNEFOEJPL()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 59f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 315f, Time.deltaTime / 1942f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 554f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 542f, GODBHHOFBMJ + 1881f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void JPHEOLEEAPB()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 681f;
		}
		else
		{
			GODBHHOFBMJ = 1296f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void ALNPAFIBJGN()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1721f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 945f, Time.deltaTime / 1011f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1309f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1385f, GODBHHOFBMJ + 250f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool DKJIGJEAOFM()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private void BIILFPDIADC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 528f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1978f, Time.deltaTime / 1974f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 116f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1904f, GODBHHOFBMJ + 1396f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool IOIFJNFDGND()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return true;
	}

	public float MGBEBPINPPP()
	{
		return GODBHHOFBMJ;
	}

	public float KNDKEALKCIM()
	{
		return GODBHHOFBMJ;
	}

	private void GAPJBNMCDDK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 445f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1479f, Time.deltaTime / 685f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1563f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1794f, GODBHHOFBMJ + 848f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float GMNCJKAPIBD()
	{
		return GODBHHOFBMJ;
	}

	public float MCGHGIAFKJD()
	{
		return GODBHHOFBMJ;
	}

	public float AJJFHEAMHOF()
	{
		return GODBHHOFBMJ;
	}

	private void IAICCKPOBMJ()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1877f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1055f, Time.deltaTime / 894f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1456f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 827f, GODBHHOFBMJ + 1564f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool JGHCDPGCNEO()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	public float LBLBNIGDKPP()
	{
		return GODBHHOFBMJ;
	}

	private void GJMLHECPGBP()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1737f;
		}
		else
		{
			GODBHHOFBMJ = 964f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool EJNMMMPNENF()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return true;
	}

	private void DAEJLBJDEIM()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 50f;
		}
		else
		{
			GODBHHOFBMJ = 788f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool EKECIEJDFIK()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	private void LJLKBKEADGI()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 657f;
		}
		else
		{
			GODBHHOFBMJ = 1711f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void GNGADDPBJDC()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 991f;
		}
		else
		{
			GODBHHOFBMJ = 234f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void GHPFCKGMLDA()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1073f;
		}
		else
		{
			GODBHHOFBMJ = 1624f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private bool JFOEMDJNEPM()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return true;
	}

	public float LOEOOPONBDA()
	{
		return GODBHHOFBMJ;
	}

	private bool DPBHBJIANNG()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return false;
	}

	public float NNNDHAKDNAB()
	{
		return GODBHHOFBMJ;
	}

	public float OBCNLCGOMCP()
	{
		return GODBHHOFBMJ;
	}

	public float DKNGCENMGBG()
	{
		return GODBHHOFBMJ;
	}

	private bool LCBBKLLAPFD()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return true;
		}
		return true;
	}

	private void DGJKLAEINHJ()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 58f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 824f, Time.deltaTime / 1813f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 991f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 150f, GODBHHOFBMJ + 1629f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void HELHNJDFPPF()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1597f;
		}
		else
		{
			GODBHHOFBMJ = 1591f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float DMOOLDLMLAJ()
	{
		return GODBHHOFBMJ;
	}

	private void HJMLKEGOJJA()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1099f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 766f, Time.deltaTime / 415f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 168f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1080f, GODBHHOFBMJ + 1063f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float MBCDMGMIGAC()
	{
		return GODBHHOFBMJ;
	}

	private void FDHMOEDMPNG()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 392f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1320f, Time.deltaTime / 51f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 118f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1267f, GODBHHOFBMJ + 890f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void ICMNODPLPBK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 47f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 503f, Time.deltaTime / 718f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 753f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 663f, GODBHHOFBMJ + 434f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void OIDCKGOCGKB()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1025f;
		}
		else
		{
			GODBHHOFBMJ = 662f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float IEPLMGJHMHE()
	{
		return GODBHHOFBMJ;
	}

	private bool MONPOFMIBDO()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return true;
	}

	private bool HNFENLAIPDP()
	{
		if (Object.op_Implicit((Object)(object)spriteAnimation))
		{
			return false;
		}
		return false;
	}

	private void APJNDKLBHCF()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 449f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 617f, Time.deltaTime / 956f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 876f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1264f, GODBHHOFBMJ + 248f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	public float OHJADLHPHEG()
	{
		return GODBHHOFBMJ;
	}

	private void KDBJHCAEGCM()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = 1795f;
		}
		else
		{
			GODBHHOFBMJ = 882f;
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			FLABEDBELMF.a = GODBHHOFBMJ;
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void INGGDMNFMCO()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1472f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1280f, Time.deltaTime / 1583f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1836f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1057f, GODBHHOFBMJ + 1282f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}

	private void LALAFOIGMKN()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (fire.activeInHierarchy)
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 1786f, Time.deltaTime);
		}
		else
		{
			GODBHHOFBMJ = Mathf.Lerp(GODBHHOFBMJ, 943f, Time.deltaTime / 1963f);
		}
		if (!Object.op_Implicit((Object)(object)spriteAnimation) && Object.op_Implicit((Object)(object)hotCoal))
		{
			FLABEDBELMF = hotCoal.color;
			if (GODBHHOFBMJ > 1094f)
			{
				FLABEDBELMF.a = Random.Range(GODBHHOFBMJ - 1769f, GODBHHOFBMJ + 1932f);
			}
			else
			{
				FLABEDBELMF.a = GODBHHOFBMJ;
			}
			hotCoal.color = FLABEDBELMF;
		}
	}
}
