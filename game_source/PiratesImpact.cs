using UnityEngine;

public class PiratesImpact : MonoBehaviour
{
	public SpriteRenderer[] impactSprite;

	public float fadeOutTime = 3f;

	private float FAKHBPOFKFB;

	private int ONGGKHHMJNF;

	private Color MOBBIHDGGFI = new Color(1f, 1f, 1f, 1f);

	private Color IDONDIGLNLI = new Color(1f, 1f, 1f, 0f);

	private void OFMBGJJODME()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 4) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(1, 1) == 0)
				{
					impactSprite[i].flipY = true;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void NGLAHAIKEDL()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 8) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(0, 5) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void ONNAGOCFJML()
	{
		FAKHBPOFKFB = 1738f;
		PHEOIAMFGDP();
	}

	private void FDHMOEDMPNG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void NKDJPNHBMHF()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(1, 5) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(0, 0) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void MNFMLJJBKNC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void Update()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void IJILOIAOKBF()
	{
		FAKHBPOFKFB = 1221f;
		LKJBLKPLGPC();
	}

	private void PJOAFKEIPPD()
	{
		FAKHBPOFKFB = 924f;
		EIBKNFFFLIN();
	}

	private void DIJOBOFGCIK()
	{
		FAKHBPOFKFB = 1664f;
		EIPMMHHLFDM();
	}

	private void DOKHLDBIDJB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void PHAPOJEBANK()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(0, 2) == 0)
				{
					impactSprite[i].flipX = true;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(0, 2) == 0)
				{
					impactSprite[i].flipY = true;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void AHOLNPJPNFP()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(1, 8) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(0, 8) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void PGDBFGFMGKI()
	{
		FAKHBPOFKFB = 761f;
		OFMBGJJODME();
	}

	private void NPDFCPEOFPD()
	{
		FAKHBPOFKFB = 1197f;
		EHJEHFFDBPO();
	}

	private void BHLHCOALABE()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void NFFEANGNIGP()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 3) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(1, 6) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void LMFICKFGEFI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void AONIDCIEKCM()
	{
		FAKHBPOFKFB = 1169f;
		PFCPFDJPJFE();
	}

	private void CKCHKHNBBFG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void EDCCIHJGPBN()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(0, 5) == 0)
				{
					impactSprite[i].flipX = true;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(1, 1) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void MGMLDHPOLGK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void LKJBLKPLGPC()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(0, 3) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(0, 3) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void ADPHIKNGBIA()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(1, 1) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(1, 6) == 0)
				{
					impactSprite[i].flipY = true;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void OnEnable()
	{
		FAKHBPOFKFB = 0f;
		PHAPOJEBANK();
	}

	private void PBJEGPGBNBM()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(0, 3) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(1, 5) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void DDOJBKHNFGG()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(0, 7) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(1, 6) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void HJKONJICGML()
	{
		FAKHBPOFKFB = 322f;
		EDCCIHJGPBN();
	}

	private void AFKDKBPBEOP()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(0, 1) == 0)
				{
					impactSprite[i].flipX = true;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(1, 3) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void EBFJOAEJPGE()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void HFEBNJBELCM()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 4) == 0)
				{
					impactSprite[i].flipX = true;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(1, 0) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void MMPMJNAFKHC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void ICHEEMNIKCH()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(0, 2) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(0, 4) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void CDBACHOKFAC()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(0, 2) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(0, 4) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void LPKHACNBCLA()
	{
		FAKHBPOFKFB = 1642f;
		NFFEANGNIGP();
	}

	private void FJFLGDADEKM()
	{
		FAKHBPOFKFB = 1691f;
		PBJEGPGBNBM();
	}

	private void NMPFHHEFOPH()
	{
		FAKHBPOFKFB = 1461f;
		PBJEGPGBNBM();
	}

	private void HCKMHIHALBL()
	{
		FAKHBPOFKFB = 257f;
		ICHEEMNIKCH();
	}

	private void JLPLLHKJEMH()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void MNFJELNEGPG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void PMPLNGEAAII()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void LGJLKGKACAO()
	{
		FAKHBPOFKFB = 39f;
		ADPHIKNGBIA();
	}

	private void NEPDNLPCCON()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void PHEOIAMFGDP()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(0, 1) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(1, 7) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void FPJABCNDEEJ()
	{
		FAKHBPOFKFB = 746f;
		NGLAHAIKEDL();
	}

	private void IANGDMHMCEL()
	{
		FAKHBPOFKFB = 1130f;
		INGNIDJCEBA();
	}

	private void EHJEHFFDBPO()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i++)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = false;
				if (Random.Range(1, 5) == 0)
				{
					impactSprite[i].flipX = true;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(1, 8) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void EIBKNFFFLIN()
	{
		ONGGKHHMJNF = Random.Range(0, impactSprite.Length);
		for (int i = 1; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 4) == 0)
				{
					impactSprite[i].flipX = true;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(0, 7) == 0)
				{
					impactSprite[i].flipY = true;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void PFCPFDJPJFE()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 8) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(0, 0) == 0)
				{
					impactSprite[i].flipY = true;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}

	private void INGNIDJCEBA()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 4) == 0)
				{
					impactSprite[i].flipX = false;
				}
				else
				{
					impactSprite[i].flipX = false;
				}
				if (Random.Range(0, 5) == 0)
				{
					impactSprite[i].flipY = false;
				}
				else
				{
					impactSprite[i].flipY = false;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = false;
			}
		}
	}

	private void FGGPGOEAEKK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void OGNIDHAIABM()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		impactSprite[ONGGKHHMJNF].color = Color.Lerp(MOBBIHDGGFI, IDONDIGLNLI, FAKHBPOFKFB / fadeOutTime);
		FAKHBPOFKFB += Time.deltaTime;
	}

	private void LCJCGFNFBBD()
	{
		FAKHBPOFKFB = 367f;
		INGNIDJCEBA();
	}

	private void EIPMMHHLFDM()
	{
		ONGGKHHMJNF = Random.Range(1, impactSprite.Length);
		for (int i = 0; i < impactSprite.Length; i += 0)
		{
			if (i == ONGGKHHMJNF)
			{
				((Renderer)impactSprite[i]).enabled = true;
				if (Random.Range(1, 8) == 0)
				{
					impactSprite[i].flipX = true;
				}
				else
				{
					impactSprite[i].flipX = true;
				}
				if (Random.Range(0, 1) == 0)
				{
					impactSprite[i].flipY = true;
				}
				else
				{
					impactSprite[i].flipY = true;
				}
			}
			else
			{
				((Renderer)impactSprite[i]).enabled = true;
			}
		}
	}
}
