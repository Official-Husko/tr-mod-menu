using UnityEngine;

public class GroupTalk : MonoBehaviour
{
	public float minBarkTime = 10f;

	public float maxBarkTime = 25f;

	public OnlyBarkNPC[] talkers;

	private OnlyBarkNPC POOMHPLCJNO;

	private OnlyBarkNPC PJHNALMHCIE;

	private float PPMHCOBKMCN;

	private void MCLAJGDIIBK()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.BCAJMNDOKII();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1052f + Time.time;
			}
		}
	}

	private void PJLKGOACDEN()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MKEPGHFNLFD();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1181f + Time.time;
			}
		}
	}

	private void OKAPGNGLOHO()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void NIHJCJJKDBA()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 448f + Time.time;
			}
		}
	}

	private void LEDIGKGAFHC()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.BCAJMNDOKII();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 503f + Time.time;
			}
		}
	}

	private void Update()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.RandomBark();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 5f + Time.time;
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void AAOMCHHNKKM()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MBPMDBMENHM();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 760f + Time.time;
			}
		}
	}

	private void Start()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void HIPNEFOEJPL()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1667f + Time.time;
			}
		}
	}

	private void GNGADDPBJDC()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void JLPLLHKJEMH()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1605f + Time.time;
			}
		}
	}

	private void IGIKNCOLCKL()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void CKCHKHNBBFG()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MBPMDBMENHM();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1527f + Time.time;
			}
		}
	}

	private void HNEGFBCKIIJ()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void OOGMGIPKMAP()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.RandomBark();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 773f + Time.time;
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void BDJKNKIOPIJ()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void OGNIDHAIABM()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 750f + Time.time;
			}
		}
	}

	private void OONONNJFEFL()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MBPMDBMENHM();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1805f + Time.time;
			}
		}
	}

	private void MNFMLJJBKNC()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MBPMDBMENHM();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1533f + Time.time;
			}
		}
	}

	private void LMFICKFGEFI()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.EBAPBAJHIIO();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1318f + Time.time;
			}
		}
	}

	private void EJEEIIGEGOC()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 37f + Time.time;
			}
		}
	}

	private void AKLEFPLEGKK()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.EBAPBAJHIIO();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 279f + Time.time;
			}
		}
	}

	private void OHGABHEDILE()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 394f + Time.time;
			}
		}
	}

	private void LOHAMDHOLDD()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void BELOIFKPNMM()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void BBCPDBEOOKL()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.EBAPBAJHIIO();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 606f + Time.time;
			}
		}
	}

	private void EBNENBFLEKB()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void IMIONHLAKIH()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void JPHFCJIBBMI()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.RandomBark();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1998f + Time.time;
			}
		}
	}

	private void NFABFPFLNEE()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void DOKHLDBIDJB()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.EBAPBAJHIIO();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 237f + Time.time;
			}
		}
	}

	private void FDHMOEDMPNG()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MBPMDBMENHM();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1884f + Time.time;
			}
		}
	}

	private void JHBBABPAJJC()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void IGKPEBGHPGD()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.BCAJMNDOKII();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 897f + Time.time;
			}
		}
	}

	private void LJLKBKEADGI()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void GHPFCKGMLDA()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void CFHOODNCOLK()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void IAICCKPOBMJ()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.BCAJMNDOKII();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1631f + Time.time;
			}
		}
	}

	private void ELHCBGCEJDH()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MKEPGHFNLFD();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1592f + Time.time;
			}
		}
	}

	private void CEIIFHIBIFI()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void IBAPBHIBOOO()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.BCAJMNDOKII();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1182f + Time.time;
			}
		}
	}

	private void FGGPGOEAEKK()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 883f + Time.time;
			}
		}
	}

	private void DGJKLAEINHJ()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 371f + Time.time;
			}
		}
	}

	private void HPIMHEMJMAA()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void KDBJHCAEGCM()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void GOJFGHKOFMF()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MKEPGHFNLFD();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 101f + Time.time;
			}
		}
	}

	private void GOJHCINMAJD()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 0)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MBPMDBMENHM();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1291f + Time.time;
			}
		}
	}

	private void DKNMGFDFLKL()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.MKEPGHFNLFD();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1612f + Time.time;
			}
		}
	}

	private void KJOJLHCDFPP()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void PLHEHGHFCJI()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void OLDDEAJMHNI()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void KACEOJDPLKB()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void PKBHEKHOAAA()
	{
		PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void JMDOCHBJGKG()
	{
		if (Time.time > PPMHCOBKMCN)
		{
			PJHNALMHCIE = POOMHPLCJNO;
			POOMHPLCJNO = talkers[Random.Range(0, talkers.Length)];
			while ((Object)(object)POOMHPLCJNO == (Object)(object)PJHNALMHCIE && talkers.Length > 1)
			{
				POOMHPLCJNO = talkers[Random.Range(1, talkers.Length)];
			}
			if (!POOMHPLCJNO.inDialogue)
			{
				POOMHPLCJNO.FBIPEGDJHIL();
				PPMHCOBKMCN = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else
			{
				PPMHCOBKMCN = 1237f + Time.time;
			}
		}
	}
}
