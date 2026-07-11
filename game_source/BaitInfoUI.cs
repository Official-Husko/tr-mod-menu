using System;
using UnityEngine;
using UnityEngine.UI;

public class BaitInfoUI : MonoBehaviour
{
	public RectTransform rect;

	public GameActionBarUI gameActionBarUI;

	public Image baitType;

	private float JMELDOKNMNN = 61f;

	private float EDCEENFHCMI = 30f;

	private float NOLFMLNLJJG;

	private float DBEFBFPAOAA;

	private float AFMFHCAHEFO;

	private float DCGBADKLANM;

	private bool DOKIBLBIBAL;

	private int JIIGOACEIKL;

	public void DAHPPCPPOFO(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 171f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1874f;
				IOMONCDIGIL();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 887f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 18f * 1417f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 177f - Mathf.Cos(DCGBADKLANM * 32f * 1246f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void LEBHNCHHIFM()
	{
		if (FishingController.AIMEAJAHLAA(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = true;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.AIMEAJAHLAA(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void NJBGLFLGLPC()
	{
		BaitSelectorUI.MIAOGLENOHL(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void CNHNOHDOIIC(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 50f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1358f;
				LFFMJNMNCFE();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1120f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1370f * 1859f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1304f - Mathf.Cos(DCGBADKLANM * 1241f * 1537f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void ALJBDANBCKE()
	{
		BaitSelectorUI.JHOHGMODKGM(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void OFCPCNBGHAH()
	{
		BaitSelectorUI.JHOHGMODKGM(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void MECPMONCHGB(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1149f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 719f;
				IKFDJNLLGAI();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1886f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 691f * 498f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1162f - Mathf.Cos(DCGBADKLANM * 47f * 1367f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void FFEGIMACOJE(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 38f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1502f;
				ONBLCFHMIOD();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1367f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 287f * 419f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1962f - Mathf.Cos(DCGBADKLANM * 1932f * 671f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void NBFMCKOEIFB()
	{
		if (FishingController.LAMFGLIGLOP(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.GDFNPHJJCPP(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void JDHLGBPLGME(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 30f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1752f;
				BMLLAICJNPM();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 34f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1190f * 785f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 367f - Mathf.Cos(DCGBADKLANM * 999f * 66f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void GMGCPKAKNMB()
	{
		BaitSelectorUI.Get(JIIGOACEIKL).OpenUI();
	}

	public void DKINAPFGJPF()
	{
		if (FishingController.AIMEAJAHLAA(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = true;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = false;
		}
		baitType.sprite = FishingManager.PJKCAOMKBJO(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void CHAJEGILDBK(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1809f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 311f;
				IKNLLDAAGOB();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 829f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1451f * 946f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1137f - Mathf.Cos(DCGBADKLANM * 101f * 812f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void BFJAFDPEPON(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 163f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 949f;
				ONBLCFHMIOD();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 864f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1054f * 1402f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 396f - Mathf.Cos(DCGBADKLANM * 1760f * 229f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void FHKFEMCOJHJ()
	{
		BaitSelectorUI.HICGKNJMGOE(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void KHDIJGAHFOP()
	{
		BaitSelectorUI.LIFMPGJIEKC(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void DPMDHKKKPOH(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1418f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1301f;
				LEBHNCHHIFM();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1735f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 314f * 504f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 301f - Mathf.Cos(DCGBADKLANM * 731f * 204f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void HCLIAFHAMNF(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1500f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 393f;
				MMMGFHAHLNC();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1836f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 546f * 1131f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 936f - Mathf.Cos(DCGBADKLANM * 1187f * 1212f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void KJHKBGDJNDC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("/")) ? 1 : 4);
	}

	public void PLFFLFININO(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1788f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 763f;
				DHCKILLKOBF();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1764f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1204f * 177f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1935f - Mathf.Cos(DCGBADKLANM * 1092f * 1872f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void KEMCCGBBBNJ(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1949f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 478f;
				BMLLAICJNPM();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 2f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1550f * 1856f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 185f - Mathf.Cos(DCGBADKLANM * 1101f * 1086f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void CKIOGOCOGHG()
	{
		BaitSelectorUI.LIFMPGJIEKC(JIIGOACEIKL).IDLAGJNLPJL();
	}

	private void JDAMCMODANB()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_name_643")) ? 1 : 3);
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("[MinePuzzleManager] Ordered puzzle queue for level {0}: [{1}]")) ? 1 : 0);
	}

	private void HDHPOAPLEJC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Serve")) ? 3 : 0);
	}

	public void MDDBFMMKIIN(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 836f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 78f;
				NBFMCKOEIFB();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 906f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 233f * 640f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1261f - Mathf.Cos(DCGBADKLANM * 1111f * 1568f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void BMLLAICJNPM()
	{
		if (FishingController.JHOHGMODKGM(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.PPAMBJOEMFH(FishingController.AIMEAJAHLAA(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	private void HEMAHKJEONA()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("talentMildAle")) ? 4 : 0);
	}

	public void PCDLKDLFLJO(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1146f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1371f;
				UpdateBaitType();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1897f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1665f * 155f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1157f - Mathf.Cos(DCGBADKLANM * 1229f * 446f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void JNCHADGMGJI(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 220f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 551f;
				DOKLDEBPDDL();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 3f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 867f * 1789f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1363f - Mathf.Cos(DCGBADKLANM * 445f * 1297f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void KJMAPMLJOGG()
	{
		BaitSelectorUI.DEBKDBICLIC(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void KCEGBNAHIIB()
	{
		if (FishingController.LAMFGLIGLOP(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = false;
		}
		baitType.sprite = FishingManager.PJKCAOMKBJO(FishingController.GDFNPHJJCPP(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void NCFLCENMCCK()
	{
		BaitSelectorUI.Get(JIIGOACEIKL).OpenUI();
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void MMMGFHAHLNC()
	{
		if (FishingController.NAGEHKBLJDL(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void UpdatePosition(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 0f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 0.016f;
				UpdateBaitType();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 0.016f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * MathF.PI * 0.5f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1f - Mathf.Cos(DCGBADKLANM * MathF.PI * 0.5f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void NKMDLFMDCDB()
	{
		BaitSelectorUI.MIAOGLENOHL(JIIGOACEIKL).IDLAGJNLPJL();
	}

	private void PNJJEDEFAGO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Open")) ? 5 : 0);
	}

	private void KDHLJKMKFMG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("chatx")) ? 0 : 0);
	}

	public void HHEKDAMBGPA(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1309f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1769f;
				CPFIPPNPKHD();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 805f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1978f * 861f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 715f - Mathf.Cos(DCGBADKLANM * 144f * 344f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void FEAGCCPBBBA(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1609f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 4f;
				DKINAPFGJPF();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1076f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 810f * 1867f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 720f - Mathf.Cos(DCGBADKLANM * 112f * 428f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void OPGPPNAPMIE(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1592f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1434f;
				OAOJPPINCDJ();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1755f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1973f * 560f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1731f - Mathf.Cos(DCGBADKLANM * 1908f * 549f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void IDDLOOKBJFB(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 220f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 152f;
				BONLLGGHBAG();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 441f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1367f * 561f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1104f - Mathf.Cos(DCGBADKLANM * 1404f * 1421f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void IKNLLDAAGOB()
	{
		if (FishingController.NAGEHKBLJDL(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	private void AGLMGDNBHBF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Hide")) ? 3 : 0);
	}

	public void PMFFGNHBNNE(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1456f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 996f;
				MMMGFHAHLNC();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1845f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 531f * 1253f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 605f - Mathf.Cos(DCGBADKLANM * 1802f * 364f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void OCJOAHDNDIJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("BaseCamp")) ? 3 : 0);
	}

	private void DADPOICMNPI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" will be destroyed in ")) ? 1 : 0);
	}

	public void UpdateBaitType()
	{
		if (FishingController.Get(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.Get(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	private void PBDNKBPBCHM()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("CloseBoxSound ")) ? 2 : 0);
	}

	private void AJGLDLLIIFO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LE_10")) ? 1 : 1);
	}

	public void AEJGLIKBMEM(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 612f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 699f;
				CPFIPPNPKHD();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 509f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1167f * 202f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 919f - Mathf.Cos(DCGBADKLANM * 1746f * 766f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void BCCCDCCCKHO()
	{
		BaitSelectorUI.HICGKNJMGOE(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void ONBLCFHMIOD()
	{
		if (FishingController.AIMEAJAHLAA(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = false;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.JHOHGMODKGM(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void IHMLDFPOJPG()
	{
		if (FishingController.LAMFGLIGLOP(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.NIGDBMAOAEN(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void OGABGPFFAKN(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 776f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1557f;
				OAOJPPINCDJ();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 433f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1155f * 1733f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 219f - Mathf.Cos(DCGBADKLANM * 429f * 1118f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void CKLELFFPFNH(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1892f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1040f;
				OAOJPPINCDJ();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1762f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 818f * 1821f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 131f - Mathf.Cos(DCGBADKLANM * 382f * 1410f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void CGFONGDFGDK(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 794f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 375f;
				FFAKJNDKOCG();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1342f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1667f * 54f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 374f - Mathf.Cos(DCGBADKLANM * 325f * 88f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void IKFDJNLLGAI()
	{
		if (FishingController.GDFNPHJJCPP(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = true;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.PPAMBJOEMFH(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void FCEPGKFAAPF()
	{
		BaitSelectorUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void DAEJABDJFMA()
	{
		BaitSelectorUI.Get(JIIGOACEIKL).OpenUI();
	}

	public void FKCFHKGJONP(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 913f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1206f;
				BONLLGGHBAG();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1278f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1588f * 1638f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1987f - Mathf.Cos(DCGBADKLANM * 1156f * 1781f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void JBJFMOACMHJ(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1436f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 811f;
				DOKLDEBPDDL();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 249f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 132f * 973f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1528f - Mathf.Cos(DCGBADKLANM * 504f * 1591f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void DOKLDEBPDDL()
	{
		if (FishingController.JHOHGMODKGM(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = false;
		}
		baitType.sprite = FishingManager.PPAMBJOEMFH(FishingController.Get(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void NFMPCNNBKPF()
	{
		BaitSelectorUI.MIAOGLENOHL(JIIGOACEIKL).OpenUI();
	}

	public void FPBMKPJCNNP()
	{
		if (FishingController.NAGEHKBLJDL(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.PPAMBJOEMFH(FishingController.NAGEHKBLJDL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	private void BHAFCBHENPL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/NeutralInTavern/Entry/1/Dialogue Text")) ? 6 : 0);
	}

	private void EIHMDMMOPCM()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LE_21")) ? 8 : 0);
	}

	public void EKFBIEJFNMJ(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1883f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 222f;
				IKFDJNLLGAI();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 174f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 355f * 1461f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1228f - Mathf.Cos(DCGBADKLANM * 610f * 1758f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void OAOJPPINCDJ()
	{
		if (FishingController.NAGEHKBLJDL(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = false;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.AIMEAJAHLAA(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void DHCKILLKOBF()
	{
		if (FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = true;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = false;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void LFFMJNMNCFE()
	{
		if (FishingController.NAGEHKBLJDL(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.PJKCAOMKBJO(FishingController.LAMFGLIGLOP(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void CPFIPPNPKHD()
	{
		if (FishingController.GDFNPHJJCPP(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = true;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void BONLLGGHBAG()
	{
		if (FishingController.NIGDBMAOAEN(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = true;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = false;
		}
		baitType.sprite = FishingManager.BaitItem(FishingController.GDFNPHJJCPP(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void JHJDECHKCFH(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 259f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 402f;
				OAOJPPINCDJ();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 118f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 206f * 1f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 879f - Mathf.Cos(DCGBADKLANM * 1627f * 584f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void EHMOJOBGDOI()
	{
		BaitSelectorUI.MIAOGLENOHL(JIIGOACEIKL).OpenUI();
	}

	public void OpenBaitSelectorUI()
	{
		BaitSelectorUI.Get(JIIGOACEIKL).OpenUI();
	}

	public void ADHILIJAPFC()
	{
		BaitSelectorUI.HICGKNJMGOE(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void JPFACLLPKCM(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1281f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1959f;
				DHCKILLKOBF();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 379f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 485f * 90f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 37f - Mathf.Cos(DCGBADKLANM * 788f * 1914f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void OAFNGDPJGAL()
	{
		BaitSelectorUI.LPJPJMPOHPG(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void BHILMKKKNAH()
	{
		BaitSelectorUI.HICGKNJMGOE(JIIGOACEIKL).OpenUI();
	}

	public void JNEPNJDICHN(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 405f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1860f;
				NBFMCKOEIFB();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 63f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(true);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 138f * 276f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1423f - Mathf.Cos(DCGBADKLANM * 132f * 1125f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void FFAKJNDKOCG()
	{
		if (FishingController.NAGEHKBLJDL(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.PJKCAOMKBJO(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void AAJPEPIHJHN(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1455f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 403f;
				MMMGFHAHLNC();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 679f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1251f * 189f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 1186f - Mathf.Cos(DCGBADKLANM * 45f * 169f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void DKNNLPFIBIK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" CloseUI ConstructionUI")) ? 1 : 0);
	}

	public void IOMONCDIGIL()
	{
		if (FishingController.Get(gameActionBarUI.JIIGOACEIKL).baitSelected == Fish.BaitType.None)
		{
			if (((Behaviour)baitType).enabled)
			{
				((Behaviour)baitType).enabled = false;
			}
			return;
		}
		if (!((Behaviour)baitType).enabled)
		{
			((Behaviour)baitType).enabled = true;
		}
		baitType.sprite = FishingManager.PJKCAOMKBJO(FishingController.NDJAMDLOIJL(gameActionBarUI.JIIGOACEIKL).baitSelected).sprite;
	}

	public void FODHIBNOKBI(bool BJFHJCFOEHG)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1581f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 440f;
				IKFDJNLLGAI();
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 626f;
			}
		}
		if (BJFHJCFOEHG)
		{
			if (!((Component)this).gameObject.activeSelf)
			{
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 607f * 318f);
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, JMELDOKNMNN, DCGBADKLANM));
			}
			else
			{
				rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, JMELDOKNMNN);
			}
		}
		else if (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = 569f - Mathf.Cos(DCGBADKLANM * 826f * 1482f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}
}
