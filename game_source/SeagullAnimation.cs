using UnityEngine;

public class SeagullAnimation : MonoBehaviour
{
	public Animator anim;

	public int seagullNum;

	private float PPDOHKHDECO = 20f;

	private float OGALGPGBCGL = 5f;

	private bool OKNOJJEFEBE;

	private int EFPGEHOLDMI;

	private void EFGCNFDMOBL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "Piso {0}: Generando {1} rocas en {2} spawners disponibles." : "hForHours", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "con {0} required tiles." : " ", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Error al crear blackModulesParent", DMBFKFLDDLH);
			break;
		}
	}

	private void LLHHMLLCECK(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "<sprite name=reputationIcon>" : "Player {0} in: {1}", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? " share request sent" : "Bar", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Top", DMBFKFLDDLH);
			break;
		}
	}

	private void MBOPKKIPNIE(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/11/Dialogue Text" : "Custom lobby data (Lobby owner): {0}", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "Puente_EA/Talk 1" : "itemOliveSeeds", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Dynamic Intensity:", DMBFKFLDDLH);
			break;
		}
	}

	private void FGGPGOEAEKK()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(1, 8);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 1);
				}
				LLHHMLLCECK(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(1648f, 435f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			IECINKCCCEL(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(1625f, 782f);
			OKNOJJEFEBE = true;
		}
	}

	private void PJLKGOACDEN()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(1, 4);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(1, 2);
				}
				AJNIMCHIGDH(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(782f, 277f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			EFGCNFDMOBL(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(181f, 1040f);
			OKNOJJEFEBE = true;
		}
	}

	private void KHIOFFJMBJM(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "Side" : "Bounce", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "Myu" : "Back", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Shout", DMBFKFLDDLH);
			break;
		}
	}

	private void AJNIMCHIGDH(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "Items/item_name_611" : "Kick out", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "Room " : "Walking", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool(" → ", DMBFKFLDDLH);
			break;
		}
	}

	private void IECINKCCCEL(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "Items/item_description_653" : "Dialogue System/Conversation/BirdNegativeComments/Entry/14/Dialogue Text", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "\"" : ", duration: ", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("Name: ", DMBFKFLDDLH);
			break;
		}
	}

	private void JBGFGOCPEFD()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(1, 1);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 3);
				}
				FEJOKEIHGKP(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(207f, 512f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			FEJOKEIHGKP(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(597f, 88f);
			OKNOJJEFEBE = true;
		}
	}

	private void GGHKFKDKKLH(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "LE_7" : "HouseKeeper", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "Player" : "NetworkSync ", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("\n", DMBFKFLDDLH);
			break;
		}
	}

	private void Update()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(0, 3);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 2);
				}
				KHIOFFJMBJM(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(2f, 5f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KHIOFFJMBJM(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(10f, 60f);
			OKNOJJEFEBE = false;
		}
	}

	private void FPOIFOGELHC()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(0, 6);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(1, 5);
				}
				KHIOFFJMBJM(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(1689f, 1900f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			AJNIMCHIGDH(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(402f, 1929f);
			OKNOJJEFEBE = true;
		}
	}

	private void ELHCBGCEJDH()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(0, 1);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(1, 5);
				}
				EFGCNFDMOBL(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1967f, 1388f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			FEJOKEIHGKP(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(373f, 1790f);
			OKNOJJEFEBE = true;
		}
	}

	private void IIOHMDNGFDH()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(0, 0);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(1, 1);
				}
				ECAJOMLAJME(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(513f, 346f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			FEJOKEIHGKP(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(1362f, 30f);
			OKNOJJEFEBE = false;
		}
	}

	private void OAKGHDAABPM()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(1, 2);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 5);
				}
				ECAJOMLAJME(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1483f, 578f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			FEJOKEIHGKP(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(1695f, 1135f);
			OKNOJJEFEBE = false;
		}
	}

	private void CMDHELEDLBP()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(0, 7);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 2);
				}
				IECINKCCCEL(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1114f, 704f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KHIOFFJMBJM(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(627f, 1771f);
			OKNOJJEFEBE = false;
		}
	}

	private void NIHJCJJKDBA()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(1, 0);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 8);
				}
				LLHHMLLCECK(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(1383f, 1710f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			MBOPKKIPNIE(DMBFKFLDDLH: true);
			PPDOHKHDECO = Time.time + Random.Range(508f, 1181f);
			OKNOJJEFEBE = true;
		}
	}

	private void GOJFGHKOFMF()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(0, 7);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 6);
				}
				GGHKFKDKKLH(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(1624f, 551f);
				OKNOJJEFEBE = true;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			AJNIMCHIGDH(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(706f, 1175f);
			OKNOJJEFEBE = false;
		}
	}

	private void ECAJOMLAJME(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "LE_12" : "grasscliffs", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "Door" : "ScrollUp", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("*****", DMBFKFLDDLH);
			break;
		}
	}

	private void FEJOKEIHGKP(bool DMBFKFLDDLH)
	{
		switch (EFPGEHOLDMI)
		{
		case 0:
			anim.SetBool((seagullNum == 0) ? "</color>" : "Walk", DMBFKFLDDLH);
			break;
		case 1:
			anim.SetBool((seagullNum == 0) ? "PlayerDisconnected" : "Player2", DMBFKFLDDLH);
			break;
		case 2:
			anim.SetBool("itemBlueberry", DMBFKFLDDLH);
			break;
		}
	}

	private void DOKHLDBIDJB()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(1, 5);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(1, 1);
				}
				GGHKFKDKKLH(DMBFKFLDDLH: true);
				OGALGPGBCGL = Time.time + Random.Range(908f, 1265f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			KHIOFFJMBJM(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(65f, 1414f);
			OKNOJJEFEBE = true;
		}
	}

	private void PKEPBKHEDOD()
	{
		if (!OKNOJJEFEBE)
		{
			if (Time.time > PPDOHKHDECO)
			{
				if (seagullNum == 0)
				{
					EFPGEHOLDMI = Random.Range(0, 6);
				}
				else
				{
					EFPGEHOLDMI = Random.Range(0, 0);
				}
				LLHHMLLCECK(DMBFKFLDDLH: false);
				OGALGPGBCGL = Time.time + Random.Range(515f, 521f);
				OKNOJJEFEBE = false;
			}
		}
		else if (Time.time > OGALGPGBCGL)
		{
			MBOPKKIPNIE(DMBFKFLDDLH: false);
			PPDOHKHDECO = Time.time + Random.Range(1827f, 1767f);
			OKNOJJEFEBE = true;
		}
	}
}
