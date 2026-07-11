using UnityEngine;

public class FlyingInsect : MonoBehaviour
{
	public Animator animator;

	private Vector3 AJLJHLHGGBD;

	private Direction FCGBJEIIMBC;

	private float LGLDPMAABLA;

	private void POEAFBCLNCO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1159f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 695f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y < 1567f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 707f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x < 1685f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 1131f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1005f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1825f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Pool Parent ", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Down)
			{
				((Component)this).transform.localScale = new Vector3(1995f, 1371f, 504f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(928f, 1586f, 1127f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MLICJIBNIFA()
	{
		if (LGLDPMAABLA > 495f)
		{
			AOJFHBFIBEG();
			LGLDPMAABLA = 1466f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void LHFOFAMDKEO()
	{
		if (LGLDPMAABLA > 205f)
		{
			ODHKMLEIPBA();
			LGLDPMAABLA = 47f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void KFBOPABEJNL()
	{
		if (LGLDPMAABLA > 579f)
		{
			MMHKDBJNBPE();
			LGLDPMAABLA = 1738f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void ONOAGANPECB()
	{
		if (LGLDPMAABLA > 1558f)
		{
			FCGFKNCOKOH();
			LGLDPMAABLA = 470f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void GHEHLJANBCF()
	{
		if (LGLDPMAABLA > 1877f)
		{
			MMHKDBJNBPE();
			LGLDPMAABLA = 656f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void PAANMOOEPNP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 322f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.x > 355f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (val.y < 916f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 676f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x < 322f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 1367f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1221f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 476f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("ReceiveLastOrder", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(1791f, 1169f, 66f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1034f, 1944f, 570f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void JPHFCJIBBMI()
	{
		if (LGLDPMAABLA > 1691f)
		{
			MAFPGMKKGMJ();
			LGLDPMAABLA = 1637f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void NNMHEBGADFF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 113f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.x > 88f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (val.y < 1908f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1238f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x < 593f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x > 1550f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 618f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 129f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Items/item_description_1052", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(228f, 407f, 683f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1948f, 93f, 1519f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void ONFDADJFNML()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 30f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.x > 228f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.y < 108f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 552f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x < 195f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (FCGBJEIIMBC == Direction.Diagonal && val.x > 1928f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 670f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 255f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("A number is needed.", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Up)
			{
				((Component)this).transform.localScale = new Vector3(1147f, 1015f, 290f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(382f, 1387f, 1633f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
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
		LGLDPMAABLA = 1569f;
		animator.SetInteger("ReceiveHit", 0);
	}

	private void DINNLJHPEHE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 624f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.x > 1581f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.y < 781f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 261f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 83f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x > 782f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 338f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 40f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Invalid year: ", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(1070f, 1815f, 1098f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(236f, 93f, 225f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void AKLEFPLEGKK()
	{
		if (LGLDPMAABLA > 1541f)
		{
			BDEAEKAOKMD();
			LGLDPMAABLA = 314f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void FGBHLJINGGP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1827f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (val.x > 1102f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y < 1298f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 42f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 436f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x > 543f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1366f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1764f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene.", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)5)
			{
				((Component)this).transform.localScale = new Vector3(585f, 1838f, 407f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1028f, 1532f, 1045f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void AGBHNHHNJHL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 149f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.x > 1071f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.y < 1076f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 315f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.x < 934f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x > 1532f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1731f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 456f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("ZuzzuProgress", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)5)
			{
				((Component)this).transform.localScale = new Vector3(414f, 955f, 574f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(323f, 336f, 1309f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void OKAPGNGLOHO()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 675f;
		animator.SetInteger("Friend ", 0);
	}

	private void NJNCKELODLF()
	{
		if (LGLDPMAABLA > 607f)
		{
			DIJAMJIJHPF();
			LGLDPMAABLA = 1600f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void HBMDEHPHAPF()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 931f;
		animator.SetInteger("shopOpen", 1);
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
		LGLDPMAABLA = 814f;
		animator.SetInteger("ReceiveTavernStatsInfo", 1);
	}

	private void HNEGFBCKIIJ()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 146f;
		animator.SetInteger("OnlinePlayer", 0);
	}

	private void BHKNJOEBCKA()
	{
		if (LGLDPMAABLA > 1674f)
		{
			NCNDHBPCONJ();
			LGLDPMAABLA = 855f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OKHHJDNNNPF()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1600f;
		animator.SetInteger("", 0);
	}

	private void PEIFJDIGKOC()
	{
		if (LGLDPMAABLA > 1107f)
		{
			NCNDHBPCONJ();
			LGLDPMAABLA = 1761f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void MFIBFFDBNGI()
	{
		if (LGLDPMAABLA > 495f)
		{
			NNMHEBGADFF();
			LGLDPMAABLA = 1647f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void NLEOCLFFOBJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1895f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.x > 548f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (val.y < 1853f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 130f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x < 1294f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x > 1683f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1331f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 860f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger(")", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(1746f, 1501f, 580f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1679f, 497f, 898f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MGMLDHPOLGK()
	{
		if (LGLDPMAABLA > 1571f)
		{
			NNMHEBGADFF();
			LGLDPMAABLA = 271f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void FCGFKNCOKOH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 331f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 1084f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (val.y < 326f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 1593f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x < 762f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x > 533f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1338f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1967f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Gameplay", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Up)
			{
				((Component)this).transform.localScale = new Vector3(1171f, 118f, 1193f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1591f, 1875f, 281f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void FHOKEHOOGNH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1369f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.x > 1415f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.y < 1413f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 344f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x < 1337f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x > 908f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 108f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1629f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Output is not ready", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)6)
			{
				((Component)this).transform.localScale = new Vector3(35f, 1146f, 47f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1310f, 1952f, 301f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void IGIKNCOLCKL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1566f;
		animator.SetInteger("Ale", 1);
	}

	private void MLLADNLMIMP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 463f;
		animator.SetInteger("LE_11", 1);
	}

	private void CLOKMCONOMN()
	{
		if (LGLDPMAABLA > 1344f)
		{
			POEAFBCLNCO();
			LGLDPMAABLA = 1651f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void GHPLPIEJFPO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 35f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.x > 1069f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.y < 1618f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 815f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 443f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Diagonal && val.x > 1514f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1782f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 17f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("{0} selected on index: {1}", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)7)
			{
				((Component)this).transform.localScale = new Vector3(1985f, 1754f, 1280f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1277f, 1881f, 61f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void HFMJPMEALMO()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 358f;
		animator.SetInteger("via End-Segment", 0);
	}

	private void IBAPBHIBOOO()
	{
		if (LGLDPMAABLA > 1849f)
		{
			NNMHEBGADFF();
			LGLDPMAABLA = 647f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void MGEFHLHJLAD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1486f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.x > 1456f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y < 1354f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 189f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x < 1892f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x > 1934f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1946f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 859f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Send begin retry", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)5)
			{
				((Component)this).transform.localScale = new Vector3(920f, 1225f, 1687f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1014f, 606f, 1220f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void NDGAOOCAPJM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1154f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.x > 534f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.y < 89f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 1443f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Diagonal && val.x < 1740f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 486f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 879f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1109f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Dialogue System/Conversation/TooHot/Entry/5/Dialogue Text", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Left)
			{
				((Component)this).transform.localScale = new Vector3(972f, 301f, 255f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1300f, 614f, 1626f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void Update()
	{
		if (LGLDPMAABLA > 0.3f)
		{
			NCNDHBPCONJ();
			LGLDPMAABLA = 0f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void JPOLFKMLHNH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 277f;
		animator.SetInteger("Black modules", 0);
	}

	private void AOJFHBFIBEG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 947f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.x > 1678f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.y < 1440f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 1015f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.x < 25f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x > 680f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 910f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1794f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Unaged", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(539f, 948f, 1123f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(607f, 832f, 1194f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void AAMGJPJKPDF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1330f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.x > 1495f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (val.y < 1999f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1374f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x < 543f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x > 1338f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 182f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1527f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("ReceiveAdoptions", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)5)
			{
				((Component)this).transform.localScale = new Vector3(147f, 1597f, 248f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1533f, 5f, 452f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MMHKDBJNBPE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1744f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.x > 710f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.y < 471f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 212f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x < 220f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x > 1515f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1590f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 208f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Klayn not find path to banquet barrel at ", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)7)
			{
				((Component)this).transform.localScale = new Vector3(1902f, 1514f, 1655f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(635f, 1572f, 23f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void HMOCIFELJFK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 659f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.x > 312f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.y < 1834f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1122f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 1193f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.x > 1635f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 542f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1825f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("ReceiveBasePuzzle", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)5)
			{
				((Component)this).transform.localScale = new Vector3(860f, 1520f, 998f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(899f, 1438f, 1788f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void PKBHEKHOAAA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 119f;
		animator.SetInteger("NoEresDigno/EndEvent2", 1);
	}

	private void ICFHPJHBPDN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 440f;
		animator.SetInteger("00", 1);
	}

	private void PJIMENLPNOE()
	{
		if (LGLDPMAABLA > 839f)
		{
			FLDCLANKMEG();
			LGLDPMAABLA = 8f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void FEJDEHPIFMD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 292f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 931f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.y < 1673f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 1820f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 1039f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x > 1101f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1927f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1897f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("GroundCliffs", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Left)
			{
				((Component)this).transform.localScale = new Vector3(731f, 1038f, 68f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1863f, 1845f, 1693f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void LKLODJLDELO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 451f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.x > 984f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y < 1906f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 259f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Diagonal && val.x < 462f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Diagonal && val.x > 1670f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 246f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 173f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Open", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(1314f, 1859f, 477f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1205f, 287f, 1410f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void ACPFEBOENOM()
	{
		if (LGLDPMAABLA > 1938f)
		{
			FEJDEHPIFMD();
			LGLDPMAABLA = 82f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OAKGHDAABPM()
	{
		if (LGLDPMAABLA > 828f)
		{
			PDBJLPAKNNF();
			LGLDPMAABLA = 1538f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OHGABHEDILE()
	{
		if (LGLDPMAABLA > 619f)
		{
			OMADNIGJMOJ();
			LGLDPMAABLA = 1221f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void HPHABKNHKBA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 313f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.x > 1750f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.y < 882f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 7f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x < 1538f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x > 821f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 356f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 524f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("bed", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(233f, 1592f, 614f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(504f, 577f, 239f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void POFDOILPANH()
	{
		if (LGLDPMAABLA > 571f)
		{
			FHOKEHOOGNH();
			LGLDPMAABLA = 1435f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void DIJAMJIJHPF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 334f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.x > 1111f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.y < 1831f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 867f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x < 1015f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 1257f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 920f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 328f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Keg not full", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(316f, 1879f, 489f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1301f, 1082f, 1660f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void HBLJGDLKMOD()
	{
		if (LGLDPMAABLA > 547f)
		{
			JLICAOOAAHO();
			LGLDPMAABLA = 391f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void PDBJLPAKNNF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1279f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 1000f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.y < 242f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 1364f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 1064f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x > 558f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1309f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1256f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Mai/LearnPrecision", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(783f, 1857f, 813f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1181f, 656f, 1557f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void FPOIFOGELHC()
	{
		if (LGLDPMAABLA > 506f)
		{
			DNOCOJMLDML();
			LGLDPMAABLA = 1984f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void GOEGBOEMHLI()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1823f;
		animator.SetInteger("Mop", 1);
	}

	private void FNNIHFOBJOP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 843f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 1227f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y < 851f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 318f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 1848f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.x > 1935f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 178f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 24f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Get Components ", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(342f, 1880f, 1650f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1514f, 1381f, 167f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
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
		LGLDPMAABLA = 749f;
		animator.SetInteger("Items/item_description_1031", 1);
	}

	private void EOJFOJEANLL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1293f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 183f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (val.y < 1956f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 935f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 265f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x > 776f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 925f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1082f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger(" / ", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)6)
			{
				((Component)this).transform.localScale = new Vector3(1069f, 998f, 1197f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(587f, 589f, 720f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void NIHJCJJKDBA()
	{
		if (LGLDPMAABLA > 206f)
		{
			BHOCOPGIAFL();
			LGLDPMAABLA = 1642f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void MCLAJGDIIBK()
	{
		if (LGLDPMAABLA > 416f)
		{
			HPHABKNHKBA();
			LGLDPMAABLA = 335f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void DOENEBKICHE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 215f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.x > 678f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.y < 1467f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 959f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 1566f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x > 1529f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1830f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 22f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("[MinePuzzleManager] Altar activated at position {0}", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Left)
			{
				((Component)this).transform.localScale = new Vector3(767f, 371f, 1381f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1669f, 205f, 1565f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void CMLLBIDFNEB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1687f;
		animator.SetInteger("No floor dirt found.", 0);
	}

	private void NEPDNLPCCON()
	{
		if (LGLDPMAABLA > 1040f)
		{
			PDBJLPAKNNF();
			LGLDPMAABLA = 1145f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void FPOLALIICJA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1293f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.x > 1747f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.y < 1957f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 973f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x < 1196f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x > 452f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1262f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 128f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Cancel", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(652f, 430f, 325f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1731f, 1372f, 312f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void CFIIEJDJFPB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1215f;
		animator.SetInteger("TermasInterior/Zuzzu/Intro", 1);
	}

	private void JFNGHMPCIPK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 883f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.x > 1194f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.y < 283f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1205f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 541f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x > 1738f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 473f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 71f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("RPC Receive Reset All Talents From Other ", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(1104f, 396f, 420f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(810f, 1600f, 489f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void JLICAOOAAHO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 87f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.x > 1037f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (val.y < 1113f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 260f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 157f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x > 1893f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1142f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 191f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Struggle", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Down)
			{
				((Component)this).transform.localScale = new Vector3(1206f, 1871f, 611f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1693f, 1573f, 684f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void CEOOADKAFEK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1597f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.x > 1415f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y < 622f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 428f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x < 1595f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.x > 61f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1869f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 7f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("%><sprite name=RightStick></size>", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)8)
			{
				((Component)this).transform.localScale = new Vector3(1642f, 62f, 1955f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(61f, 1653f, 245f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MAFPGMKKGMJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1764f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.x > 628f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.y < 1516f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1807f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x < 768f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x > 26f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 738f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 905f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Missing fade image", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)7)
			{
				((Component)this).transform.localScale = new Vector3(1305f, 296f, 501f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1583f, 1166f, 1461f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
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
		LGLDPMAABLA = 1516f;
		animator.SetInteger("Left Stick Right", 1);
	}

	private void CNBLOMJJECI()
	{
		if (LGLDPMAABLA > 274f)
		{
			DNOCOJMLDML();
			LGLDPMAABLA = 1865f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void DKNMGFDFLKL()
	{
		if (LGLDPMAABLA > 1869f)
		{
			NNMHEBGADFF();
			LGLDPMAABLA = 92f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OLFPIBOIIIO()
	{
		if (LGLDPMAABLA > 356f)
		{
			LKLODJLDELO();
			LGLDPMAABLA = 863f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void EBNJADODONG()
	{
		if (LGLDPMAABLA > 1005f)
		{
			IEIDPOIIBMD();
			LGLDPMAABLA = 1576f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void BHOCOPGIAFL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 659f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (val.x > 1251f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.y < 134f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 627f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x < 1244f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 1015f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1976f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1583f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger(" : 00", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Up)
			{
				((Component)this).transform.localScale = new Vector3(1391f, 804f, 1643f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1671f, 1810f, 66f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void IEIDPOIIBMD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 109f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.x > 224f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.y < 1722f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 176f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 1378f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 1877f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1723f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 509f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Items/item_name_1143", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(1856f, 228f, 1748f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1525f, 577f, 348f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void OMADNIGJMOJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 367f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.x > 14f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.y < 353f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1638f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x < 862f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 567f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 794f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 41f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Meditation", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)5)
			{
				((Component)this).transform.localScale = new Vector3(511f, 644f, 1691f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(13f, 66f, 272f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void LANGHIOBJIH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 550f;
		animator.SetInteger("itemSageSeeds", 1);
	}

	private void MFMMHDPGCBO()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 908f;
		animator.SetInteger("ReceiveFarmConstructionDeactivated", 1);
	}

	private void AKDPJCEJKPN()
	{
		if (LGLDPMAABLA > 48f)
		{
			DIJAMJIJHPF();
			LGLDPMAABLA = 767f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void MEAFJDDNAJB()
	{
		if (LGLDPMAABLA > 1533f)
		{
			PDBJLPAKNNF();
			LGLDPMAABLA = 1747f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void CCEKJEDMJAP()
	{
		if (LGLDPMAABLA > 1853f)
		{
			FHOKEHOOGNH();
			LGLDPMAABLA = 929f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void EHBIMKJILDA()
	{
		if (LGLDPMAABLA > 1573f)
		{
			ONFDADJFNML();
			LGLDPMAABLA = 343f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OMLHIAADEHE()
	{
		if (LGLDPMAABLA > 1080f)
		{
			DNOCOJMLDML();
			LGLDPMAABLA = 1478f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void AJDKOMCHALC()
	{
		if (LGLDPMAABLA > 194f)
		{
			FJMLLDCAIHP();
			LGLDPMAABLA = 1685f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void NPMLFHDHJBE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 675f;
		animator.SetInteger("Cancel", 1);
	}

	private void ODHKMLEIPBA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1356f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 1480f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.y < 1688f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 548f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 993f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 877f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1568f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 821f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("EditorAction_8", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)5)
			{
				((Component)this).transform.localScale = new Vector3(1252f, 912f, 660f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1300f, 1759f, 183f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void BDEAEKAOKMD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 152f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.x > 351f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y < 773f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1785f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.x < 1306f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.x > 963f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1852f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1076f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("tutorialPopUp76", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Down)
			{
				((Component)this).transform.localScale = new Vector3(973f, 83f, 90f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(323f, 71f, 847f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void HCEDMLJNOBL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1423f;
		animator.SetInteger("(empty)", 1);
	}

	private void FLDCLANKMEG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 711f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 1862f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.y < 850f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1316f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x < 1510f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x > 1505f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 422f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1888f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Not enough ingredients", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)7)
			{
				((Component)this).transform.localScale = new Vector3(193f, 18f, 1732f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(943f, 1004f, 229f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
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

	private void PMPLNGEAAII()
	{
		if (LGLDPMAABLA > 1648f)
		{
			FHOKEHOOGNH();
			LGLDPMAABLA = 607f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void DNOCOJMLDML()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1497f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.x > 1422f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.y < 1333f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1883f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)7 && val.x < 101f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x > 1872f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1827f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1914f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Walk", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(1591f, 317f, 882f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(168f, 775f, 1501f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MFPEIPCMEEB()
	{
		if (LGLDPMAABLA > 48f)
		{
			FNNIHFOBJOP();
			LGLDPMAABLA = 1610f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void NDLCBLKOBLF()
	{
		if (LGLDPMAABLA > 1172f)
		{
			LKLODJLDELO();
			LGLDPMAABLA = 647f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void DLNOLBHCIGC()
	{
		if (LGLDPMAABLA > 1659f)
		{
			NCNDHBPCONJ();
			LGLDPMAABLA = 810f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void NELBHAMPBPL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1046f;
		animator.SetInteger("ReceiveHerbAction", 1);
	}

	private void ODKGLIDMCNP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 463f;
		animator.SetInteger("PirateMinigame/Minigame2", 1);
	}

	private void FJMLLDCAIHP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 384f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.x > 1166f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.y < 541f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1755f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 150f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x > 554f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 22f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1473f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Dialogue System/Conversation/Gass_Stand/Entry/6/Dialogue Text", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Down)
			{
				((Component)this).transform.localScale = new Vector3(1069f, 682f, 649f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1482f, 628f, 810f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void BEGLOAKAICN()
	{
		if (LGLDPMAABLA > 989f)
		{
			MGEFHLHJLAD();
			LGLDPMAABLA = 1143f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void GHHBJOBEMJI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < 1013f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.x > 890f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y < 421f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1635f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x < 1588f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x > 901f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 1776f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 374f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Key item fished: ", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(1575f, 624f, 663f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1232f, 154f, 815f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void NCNDHBPCONJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (val.x < -0.04f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.x > 0.04f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (val.y < -0.04f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 0.04f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Left && val.x < -0.01f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x > 0.01f)
			{
				FCGBJEIIMBC = Direction.Right;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < -0.01f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 0.01f)
			{
				FCGBJEIIMBC = Direction.Up;
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
	}

	private void JECHMEFJABD()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 219f;
		animator.SetInteger("Use", 0);
	}

	private void IAAGKLPMAMK()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 43f;
		animator.SetInteger("Dialogue System/Conversation/Gass_Quest/Entry/14/Dialogue Text", 0);
	}

	private void EIGEIJJPFFP()
	{
		if (LGLDPMAABLA > 1296f)
		{
			BDEAEKAOKMD();
			LGLDPMAABLA = 1847f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OEMIMEIDMFE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1092f;
		animator.SetInteger("Right", 0);
	}
}
