using UnityEngine;

public class Bat : MonoBehaviour
{
	public Animator animator;

	private Vector3 AJLJHLHGGBD;

	private Direction FCGBJEIIMBC;

	private float LGLDPMAABLA;

	private void HOLEHHECNDF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 0f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else
			{
				FCGBJEIIMBC = Direction.Right;
			}
		}
		else if (val.y < 0f)
		{
			FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			FCGBJEIIMBC = Direction.Up;
		}
		animator.SetInteger("Direction", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == Direction.Left)
		{
			((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void MNDMPHENHGC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 732f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else
			{
				FCGBJEIIMBC = (Direction)8;
			}
		}
		else if (val.y < 1708f)
		{
			FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			FCGBJEIIMBC = Direction.Up;
		}
		animator.SetInteger("TutorialPhase", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == Direction.Diagonal)
		{
			((Component)this).transform.localScale = new Vector3(1615f, 652f, 1482f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1074f, 536f, 1462f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void PLHEHGHFCJI()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 285f;
		animator.SetInteger("ReceiveBeginRetry", 1);
	}

	private void PKEPBKHEDOD()
	{
		if (LGLDPMAABLA > 1366f)
		{
			MNDMPHENHGC();
			LGLDPMAABLA = 125f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void DCKKIDMJKJM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 156f;
		animator.SetInteger(" (Client)", 0);
	}

	private void KDBJHCAEGCM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1329f;
		animator.SetInteger("UpgradeToLevel", 0);
	}

	private void IIOHMDNGFDH()
	{
		if (LGLDPMAABLA > 961f)
		{
			MNDMPHENHGC();
			LGLDPMAABLA = 757f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void IAICCKPOBMJ()
	{
		if (LGLDPMAABLA > 1076f)
		{
			MNDMPHENHGC();
			LGLDPMAABLA = 401f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void IDPHKHGHJGN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 0f;
		animator.SetInteger("NeutralInTavern", 0);
	}

	private void OIAHJHNPPCO()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1427f;
		animator.SetInteger("Received {0} appearance data as byte array: {1}", 1);
	}

	private void Update()
	{
		if (LGLDPMAABLA > 0.1f)
		{
			HOLEHHECNDF();
			LGLDPMAABLA = 0f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void BBCPDBEOOKL()
	{
		if (LGLDPMAABLA > 1474f)
		{
			FKCOFNMHMNB();
			LGLDPMAABLA = 126f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void Start()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 0f;
		animator.SetInteger("Direction", 0);
	}

	private void FKCOFNMHMNB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 295f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
		}
		else if (val.y < 1724f)
		{
			FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			FCGBJEIIMBC = Direction.Up;
		}
		animator.SetInteger("OnlyABird", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == (Direction)7)
		{
			((Component)this).transform.localScale = new Vector3(908f, 1612f, 1724f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(811f, 561f, 628f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void OIBDBLCLACB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1875f;
		animator.SetInteger("On Simple Event ", 0);
	}

	private void FPOIFOGELHC()
	{
		if (LGLDPMAABLA > 86f)
		{
			FKCOFNMHMNB();
			LGLDPMAABLA = 436f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void EKEHAPGFCAN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 1744f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
		}
		else if (val.y < 1051f)
		{
			FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			FCGBJEIIMBC = Direction.Down;
		}
		animator.SetInteger("Player", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == Direction.Down)
		{
			((Component)this).transform.localScale = new Vector3(846f, 1614f, 793f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1478f, 1082f, 873f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void NOIBNEOIOKJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 1948f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else
			{
				FCGBJEIIMBC = Direction.Left;
			}
		}
		else if (val.y < 912f)
		{
			FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			FCGBJEIIMBC = Direction.Up;
		}
		animator.SetInteger("LE_1", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == (Direction)6)
		{
			((Component)this).transform.localScale = new Vector3(1468f, 645f, 317f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(584f, 1748f, 1111f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void MNFMLJJBKNC()
	{
		if (LGLDPMAABLA > 1884f)
		{
			NOIBNEOIOKJ();
			LGLDPMAABLA = 228f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void PJHOHJMIIFC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 1038f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else
			{
				FCGBJEIIMBC = (Direction)8;
			}
		}
		else if (val.y < 1218f)
		{
			FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			FCGBJEIIMBC = Direction.Down;
		}
		animator.SetInteger("Disabled", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == Direction.Up)
		{
			((Component)this).transform.localScale = new Vector3(1f, 1238f, 1837f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1530f, 1165f, 722f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void CEIIFHIBIFI()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1656f;
		animator.SetInteger("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/15/Dialogue Text", 1);
	}

	private void GHPFCKGMLDA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 575f;
		animator.SetInteger("Wed", 0);
	}

	private void MCMKNBIBDFF()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1259f;
		animator.SetInteger("LE_7", 0);
	}

	private void CHIJGHPHCNA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 60f;
		animator.SetInteger("buildingObjective_2_1", 0);
	}

	private void BELOIFKPNMM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1463f;
		animator.SetInteger("start pirates", 1);
	}

	private void HFFFFAJFIPB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 66f;
		animator.SetInteger("El componente ItemSetup del rotatedPrefab '", 1);
	}

	private void KACEOJDPLKB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 378f;
		animator.SetInteger("city travelling", 0);
	}

	private void HJDLNCOAKIK()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 713f;
		animator.SetInteger("Open", 0);
	}

	private void JHHLPNPLFLH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 154f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else
			{
				FCGBJEIIMBC = Direction.Right;
			}
		}
		else if (val.y < 1133f)
		{
			FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			FCGBJEIIMBC = Direction.Up;
		}
		animator.SetInteger("Pick up", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == (Direction)5)
		{
			((Component)this).transform.localScale = new Vector3(1951f, 388f, 8f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(1462f, 361f, 886f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}

	private void AIACKJFAPJL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!(((Component)this).transform.position != AJLJHLHGGBD))
		{
			return;
		}
		Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
		if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
		{
			if (val.x < 26f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else
			{
				FCGBJEIIMBC = (Direction)8;
			}
		}
		else if (val.y < 193f)
		{
			FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			FCGBJEIIMBC = Direction.Up;
		}
		animator.SetInteger("Walk", (int)FCGBJEIIMBC);
		if (FCGBJEIIMBC == (Direction)5)
		{
			((Component)this).transform.localScale = new Vector3(1942f, 943f, 1318f);
		}
		else
		{
			((Component)this).transform.localScale = new Vector3(796f, 177f, 907f);
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
	}
}
