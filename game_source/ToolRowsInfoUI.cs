using System;
using UnityEngine;
using UnityEngine.UI;

public class ToolRowsInfoUI : MonoBehaviour
{
	public enum ToolType
	{
		Spade,
		Hoe,
		WateringCan
	}

	[SerializeField]
	private RectTransform rect;

	[SerializeField]
	private Image toolImage;

	[SerializeField]
	private Image[] rowImages;

	[SerializeField]
	private Sprite greenRow;

	[SerializeField]
	private Sprite blueRow;

	[SerializeField]
	private Sprite darkRow;

	[SerializeField]
	private Sprite spade;

	[SerializeField]
	private Sprite hoe;

	[SerializeField]
	private Sprite wateringcan;

	private float JMELDOKNMNN = 61f;

	private float EDCEENFHCMI = 30f;

	private float NOLFMLNLJJG;

	private float DBEFBFPAOAA;

	private float AFMFHCAHEFO;

	private float DCGBADKLANM;

	private bool DOKIBLBIBAL;

	private int JIIGOACEIKL;

	public void NHBDHJNOPKE(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 778f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1586f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1419f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 858f * 1545f);
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
			DCGBADKLANM = 387f - Mathf.Cos(DCGBADKLANM * 1438f * 1173f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void GGOPCJOAOMC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(".gz")) ? 1 : 0);
	}

	private void OKHLEMPJONN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("No seat or table!")) ? 8 : 0);
	}

	public void FIAJHCONMDB(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void GFLFDLIMOLI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("(")) ? 1 : 5);
	}

	private void DKNNLPFIBIK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("TooHot")) ? 1 : 8);
	}

	public void FEAGCCPBBBA(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1179f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 783f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 553f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1731f * 1059f);
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
			DCGBADKLANM = 1510f - Mathf.Cos(DCGBADKLANM * 1757f * 977f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void CBEDJAEPEHA(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void DAHPPCPPOFO(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1031f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 119f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1115f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 893f * 1549f);
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
			DCGBADKLANM = 741f - Mathf.Cos(DCGBADKLANM * 1799f * 68f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void PNDCOEOKHKM(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void IPDEHGNFHEN(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void GACGDCMGNHF()
	{
		ItemInstance itemInstance = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBBGBHPJOAG();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	private void BODICIENBEH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Hurt")) ? 1 : 4);
	}

	public void NDFGBINFABL()
	{
		ItemInstance itemInstance = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).KFDBMPDPJBF();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).MBDMEFMMGEI(JIIGOACEIKL);
		}
	}

	public void GFBNADDDAIO(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 599f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 690f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 87f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1038f * 884f);
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
			DCGBADKLANM = 239f - Mathf.Cos(DCGBADKLANM * 1850f * 558f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void NNEBAHFHINE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Editor action without ID: ")) ? 1 : 8);
	}

	public void BIEKMBNPGNP()
	{
		ItemInstance itemInstance = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).BBBGBHPJOAG();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	private void FALNOOOKLGA()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Player2")) ? 1 : 0);
	}

	public void HOELKPEBKNE()
	{
		ItemInstance itemInstance = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).MFDBJINDCAO();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	public void ILECPFFPBMC(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 595f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1305f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1271f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1787f * 812f);
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
			DCGBADKLANM = 1566f - Mathf.Cos(DCGBADKLANM * 1586f * 663f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void KLGCMMIKGIO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("mForMins")) ? 4 : 0);
	}

	public void DLDLHJBNKNA(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void KKNHADAMLFP()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("[Player1Name]")) ? 8 : 0);
	}

	public void JEKGABGNCBM()
	{
		ItemInstance itemInstance = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).JHDFIPFOHDP();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	public void MGOBKOBMAHG(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void KLMNLEDKEOE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Buy")) ? 8 : 0);
	}

	public void ANPEOFFEHOJ()
	{
		ItemInstance itemInstance = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KFDBMPDPJBF();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	private void CEOEHODJAJK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Jump")) ? 1 : 7);
	}

	public void JNDLCDDCMNK()
	{
		ItemInstance selectedItemInstance = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItemInstance();
		if (selectedItemInstance is WateringCanInstance || selectedItemInstance is HoeInstance || selectedItemInstance is SpadeInstance)
		{
			(selectedItemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	public void OAEOFJPJMAC(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void KFJANCLHEDN(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 333f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1098f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 476f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 965f * 377f);
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
			DCGBADKLANM = 1790f - Mathf.Cos(DCGBADKLANM * 1559f * 1701f);
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1465f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 50f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 888f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1732f * 228f);
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
			DCGBADKLANM = 672f - Mathf.Cos(DCGBADKLANM * 1883f * 1441f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void GIIPHEOBPJB(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void PCFMFEDCMIA()
	{
		ItemInstance selectedItemInstance = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItemInstance();
		if (selectedItemInstance is WateringCanInstance || selectedItemInstance is HoeInstance || selectedItemInstance is SpadeInstance)
		{
			(selectedItemInstance as ToolInstance).MBDMEFMMGEI(JIIGOACEIKL);
		}
	}

	public void PLFFLFININO(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 6f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1469f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 290f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1151f * 529f);
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
			DCGBADKLANM = 481f - Mathf.Cos(DCGBADKLANM * 1258f * 806f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void OPBJADINFLD(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void HJBFJNGHHCJ()
	{
		ItemInstance itemInstance = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).BBBGBHPJOAG();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).LEPKFPEMJMC(JIIGOACEIKL);
		}
	}

	public void BOKOOHELAKD(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void BGBFJPJLPMF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("qualityWater")) ? 1 : 5);
	}

	public void FDEBBJAHIEM(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void KLHIMJFCHPD()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("</color>")) ? 1 : 8);
	}

	public void JBOOADIMEBL(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 186f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1114f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1233f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 628f * 31f);
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
			DCGBADKLANM = 404f - Mathf.Cos(DCGBADKLANM * 1380f * 1519f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void POLEBBAGNGK(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1611f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1026f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1608f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 146f * 1560f);
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
			DCGBADKLANM = 358f - Mathf.Cos(DCGBADKLANM * 1522f * 1180f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void KGBPKJOENGC(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void CEEOGDDCPIL()
	{
		ItemInstance itemInstance = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KFDBMPDPJBF();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).MBDMEFMMGEI(JIIGOACEIKL);
		}
	}

	public void PMOAHPPLLGI()
	{
		ItemInstance selectedItemInstance = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItemInstance();
		if (selectedItemInstance is WateringCanInstance || selectedItemInstance is HoeInstance || selectedItemInstance is SpadeInstance)
		{
			(selectedItemInstance as ToolInstance).LEPKFPEMJMC(JIIGOACEIKL);
		}
	}

	private void OCJOAHDNDIJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("on player sleep")) ? 1 : 0);
	}

	public void JBGKPGFAKCL()
	{
		ItemInstance itemInstance = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).BBBGBHPJOAG();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).LEPKFPEMJMC(JIIGOACEIKL);
		}
	}

	public void CMANGMLDMDA()
	{
		ItemInstance itemInstance = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOADDJLNIBN();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	private void NCPNBBCNBIM()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Player2")) ? 1 : 3);
	}

	public void GBDILCPGFAA(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 501f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1612f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 930f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 711f * 837f);
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
			DCGBADKLANM = 1234f - Mathf.Cos(DCGBADKLANM * 181f * 705f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void HFCPGAIGAIP(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 119f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 714f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1949f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1111f * 190f);
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
			DCGBADKLANM = 96f - Mathf.Cos(DCGBADKLANM * 1475f * 1661f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void DKDLOBOLNFH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Sleep")) ? 1 : 0);
	}

	public void HCLIAFHAMNF(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 355f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1823f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1269f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 340f * 567f);
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
			DCGBADKLANM = 1445f - Mathf.Cos(DCGBADKLANM * 1077f * 331f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void NHPJDCIEHPI(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void DLJFJFPOGJE(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 413f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 841f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 519f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1831f * 848f);
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
			DCGBADKLANM = 895f - Mathf.Cos(DCGBADKLANM * 1552f * 616f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void GJDEOEHLGMF(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 733f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 891f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1161f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 607f * 622f);
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
			DCGBADKLANM = 510f - Mathf.Cos(DCGBADKLANM * 1464f * 495f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void AHNDNOMFLOL(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void PEFKNEPONAG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ReceiveRequestChristmasEvent")) ? 1 : 2);
	}

	private void COKBJNMAMDI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("]")) ? 1 : 0);
	}

	public void PEANKPKHJHB(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void OPFLIHAMIJL()
	{
		ItemInstance itemInstance = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBBGBHPJOAG();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).MBDMEFMMGEI(JIIGOACEIKL);
		}
	}

	private void AAENCDNIBFJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Attack/MainEvent 8")) ? 6 : 0);
	}

	public void DHGGNDHNPHM(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void HDENCDOEODO(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void KGIKOECKEHI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Animal")) ? 1 : 5);
	}

	private void EFCNKPEPELL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" at ")) ? 2 : 0);
	}

	private void FFHIGDJEFJE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Cat")) ? 1 : 8);
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Available")) ? 1 : 5);
	}

	private void NMKGOAJLMDG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ReceivePassOutActions")) ? 1 : 7);
	}

	public void JEGFLMIMIAF(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void PDHDHFDJJFJ(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void CGFONGDFGDK(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 484f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1481f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1056f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1780f * 456f);
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
			DCGBADKLANM = 1992f - Mathf.Cos(DCGBADKLANM * 874f * 1596f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void LDLBMMMLEDJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/TooHot/Entry/4/Dialogue Text")) ? 7 : 0);
	}

	public void OFBBMEDALCN(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 41f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 727f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1850f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1680f * 1722f);
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
			DCGBADKLANM = 711f - Mathf.Cos(DCGBADKLANM * 1800f * 940f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void DFNCJMEHEKM(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void HCNBOJNELMC(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 811f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 607f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1685f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1106f * 1943f);
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
			DCGBADKLANM = 955f - Mathf.Cos(DCGBADKLANM * 928f * 1792f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void BOIKEKENOHG()
	{
		ItemInstance itemInstance = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOADDJLNIBN();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	public void MFAEIGNLOMN(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 727f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1012f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1266f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1458f * 98f);
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
			DCGBADKLANM = 1625f - Mathf.Cos(DCGBADKLANM * 1999f * 1771f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void IncreaseRowsButton()
	{
		ItemInstance selectedItemInstance = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItemInstance();
		if (selectedItemInstance is WateringCanInstance || selectedItemInstance is HoeInstance || selectedItemInstance is SpadeInstance)
		{
			(selectedItemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	public void CCGBPCLLIMF(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void ODFCNFACEBM()
	{
		ItemInstance itemInstance = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).BBBGBHPJOAG();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	private void CIICEKEJANM()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text")) ? 0 : 0);
	}

	private void JDAMCMODANB()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" * ")) ? 1 : 6);
	}

	public void DOFLGCBPFJN(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void NCPHPDDHJKA(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void KNCCMFGEKKF(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1875f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 696f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 597f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1948f * 628f);
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
			DCGBADKLANM = 1161f - Mathf.Cos(DCGBADKLANM * 667f * 1965f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void LAJFBPKABAP(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void JDMMNLGBEJA(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void GFFODEALLMF(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 720f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 468f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 542f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1325f * 501f);
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
			DCGBADKLANM = 1622f - Mathf.Cos(DCGBADKLANM * 1007f * 191f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void AMNCIAEMBFO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" original price: ")) ? 1 : 6);
	}

	public void EKHKAIOCKBK(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void NCHGLHLJCIJ(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1615f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 922f;
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
				((Component)this).gameObject.SetActive(false);
			}
			if (DBEFBFPAOAA < AFMFHCAHEFO)
			{
				DBEFBFPAOAA += Time.deltaTime;
				DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 741f * 251f);
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
			DCGBADKLANM = 601f - Mathf.Cos(DCGBADKLANM * 1371f * 124f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void MDDBFMMKIIN(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 20f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1286f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1588f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 952f * 1047f);
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
			DCGBADKLANM = 160f - Mathf.Cos(DCGBADKLANM * 377f * 103f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void KBDOCCNBFGN()
	{
		ItemInstance itemInstance = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).MFDBJINDCAO();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).MBDMEFMMGEI(JIIGOACEIKL);
		}
	}

	private void DIMAPDNCBAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Grass")) ? 1 : 6);
	}

	public void IJDKFNLLCGF()
	{
		ItemInstance itemInstance = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JHDFIPFOHDP();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).LEPKFPEMJMC(JIIGOACEIKL);
		}
	}

	public void DKOHHONCJOC()
	{
		ItemInstance itemInstance = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOADDJLNIBN();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).MBDMEFMMGEI(JIIGOACEIKL);
		}
	}

	public void BHNFJMHABPO(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void PKOMKLHPKFP(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void BCKKKBPOKKM(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void EGDCDJNOLBI()
	{
		ItemInstance itemInstance = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).MFDBJINDCAO();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	private void MMNBJPDJHGK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Normal")) ? 7 : 0);
	}

	public void BBHPJKGEMMD()
	{
		ItemInstance itemInstance = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).MFDBJINDCAO();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).LEPKFPEMJMC(JIIGOACEIKL);
		}
	}

	public void ADHHMODHOAA(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1160f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1624f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 350f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1852f * 991f);
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
			DCGBADKLANM = 1950f - Mathf.Cos(DCGBADKLANM * 226f * 1004f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void EFJFJJDGGGI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Sleep")) ? 1 : 5);
	}

	public void KBOLMFJEFCL(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1034f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1305f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1177f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 335f * 1638f);
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
			DCGBADKLANM = 552f - Mathf.Cos(DCGBADKLANM * 1542f * 375f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void CHAJEGILDBK(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 138f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1397f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 254f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 76f * 621f);
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
			DCGBADKLANM = 1758f - Mathf.Cos(DCGBADKLANM * 1608f * 225f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void OOIHNJHMBMC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Talk")) ? 3 : 0);
	}

	public void NOABOBGHPKG(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1144f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1587f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1412f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 190f * 1994f);
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
			DCGBADKLANM = 244f - Mathf.Cos(DCGBADKLANM * 1942f * 1131f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void AODFOMCFLOC(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 154f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1958f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1989f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 553f * 169f);
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
			DCGBADKLANM = 100f - Mathf.Cos(DCGBADKLANM * 1504f * 1378f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void UpdatePosition(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
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

	public void SetRowsNumber(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i++)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void PGEGODAEBLC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Run")) ? 0 : 0);
	}

	public void GOHLOPOAOMG()
	{
		ItemInstance itemInstance = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KFDBMPDPJBF();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).CBMEOBPDDOO(JIIGOACEIKL);
		}
	}

	public void AHJFEHBCFDL(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1789f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1651f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 122f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1440f * 1838f);
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
			DCGBADKLANM = 823f - Mathf.Cos(DCGBADKLANM * 1763f * 1210f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void HIEOPDIKFNE(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 389f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1473f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 400f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1406f * 199f);
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
			DCGBADKLANM = 1259f - Mathf.Cos(DCGBADKLANM * 642f * 453f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void BAMFMFKODKE()
	{
		ItemInstance itemInstance = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JHDFIPFOHDP();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).LEPKFPEMJMC(JIIGOACEIKL);
		}
	}

	public void AHNMFJDNMGI(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void CFKNJLIPNAK(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 217f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 1894f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 175f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1377f * 613f);
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
			DCGBADKLANM = 1095f - Mathf.Cos(DCGBADKLANM * 40f * 1170f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void LHABENPEMPB()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("</color></b>")) ? 1 : 2);
	}

	public void JEDILMDAOBO(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 0; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	public void HBPICMHMIMF()
	{
		ItemInstance itemInstance = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOADDJLNIBN();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).LEPKFPEMJMC(JIIGOACEIKL);
		}
	}

	public void NHBAJIMBCGF()
	{
		ItemInstance itemInstance = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).MFDBJINDCAO();
		if (itemInstance is WateringCanInstance || itemInstance is HoeInstance || itemInstance is SpadeInstance)
		{
			(itemInstance as ToolInstance).MBDMEFMMGEI(JIIGOACEIKL);
		}
	}

	private void CLNBMOPMNOF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" (Host)")) ? 4 : 0);
	}

	public void CHFMDMDBNCE(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1391f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 458f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 609f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 582f * 136f);
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
			DCGBADKLANM = 433f - Mathf.Cos(DCGBADKLANM * 775f * 1973f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void PCHMOIDHNPA(int MLAFGGDFHJB, int EONJGMONIOM, ToolType NAEINDDPMFO)
	{
		switch (NAEINDDPMFO)
		{
		case ToolType.Spade:
			toolImage.sprite = spade;
			break;
		case ToolType.Hoe:
			toolImage.sprite = hoe;
			break;
		case ToolType.WateringCan:
			toolImage.sprite = wateringcan;
			break;
		}
		for (int i = 1; i < rowImages.Length; i += 0)
		{
			if (i < EONJGMONIOM)
			{
				if (i < MLAFGGDFHJB)
				{
					rowImages[i].sprite = greenRow;
				}
				else
				{
					rowImages[i].sprite = blueRow;
				}
			}
			else
			{
				rowImages[i].sprite = darkRow;
			}
		}
	}

	private void FPNCANODJKE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Pick Level Low")) ? 1 : 0);
	}

	public void FFEGIMACOJE(bool BJFHJCFOEHG)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 452f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 545f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1648f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 151f * 682f);
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
			DCGBADKLANM = 220f - Mathf.Cos(DCGBADKLANM * 1542f * 248f);
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		if (!BJFHJCFOEHG && !((Component)this).gameObject.activeSelf)
		{
			return;
		}
		if (DOKIBLBIBAL != BJFHJCFOEHG)
		{
			NOLFMLNLJJG = rect.anchoredPosition.y;
			DOKIBLBIBAL = BJFHJCFOEHG;
			DBEFBFPAOAA = 1977f;
			if (BJFHJCFOEHG)
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - JMELDOKNMNN) * 292f;
			}
			else
			{
				AFMFHCAHEFO = Mathf.Abs(rect.anchoredPosition.y - EDCEENFHCMI) * 1062f;
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
				DCGBADKLANM = Mathf.Sin(DCGBADKLANM * 1922f * 1749f);
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
			DCGBADKLANM = 210f - Mathf.Cos(DCGBADKLANM * 1958f * 1101f);
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, Mathf.Lerp(NOLFMLNLJJG, EDCEENFHCMI, DCGBADKLANM));
		}
		else if (!((Component)this).gameObject.activeSelf)
		{
			rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, EDCEENFHCMI);
			((Component)this).gameObject.SetActive(false);
		}
	}
}
