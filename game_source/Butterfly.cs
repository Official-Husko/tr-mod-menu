using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
	public Animator animator;

	private Vector3 AJLJHLHGGBD;

	private Direction FCGBJEIIMBC;

	private float LGLDPMAABLA;

	private void CKCHKHNBBFG()
	{
		if (LGLDPMAABLA > 666f)
		{
			AFAHMLNIEJB();
			LGLDPMAABLA = 999f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void FGGPGOEAEKK()
	{
		if (LGLDPMAABLA > 1846f)
		{
			MDJLJJFODGJ();
			LGLDPMAABLA = 658f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void BELOIFKPNMM()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.DDJALPPNIJE();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 860f;
		animator.SetInteger("Year", 1);
	}

	private void BNIKICAEIND()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GLIBMFJEALE();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1142f;
		animator.SetInteger("SetAnimatorObjectIntRPC", 0);
	}

	private void BHKNJOEBCKA()
	{
		if (LGLDPMAABLA > 92f)
		{
			IGOPBADIPPO();
			LGLDPMAABLA = 1435f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void NKDFMFFDGKC()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.DDJALPPNIJE();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1861f;
		animator.SetInteger("Quest Done", 1);
	}

	private void IIOHMDNGFDH()
	{
		if (LGLDPMAABLA > 1936f)
		{
			AFAHMLNIEJB();
			LGLDPMAABLA = 1648f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void CEIIFHIBIFI()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> butterflies = CharacterSpritesDBAccessor.GetButterflies();
		SpriteInfo oJKJDNNBJOF = butterflies[Random.Range(0, butterflies.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1734f;
		animator.SetInteger("Interact", 0);
	}

	private void MCMKNBIBDFF()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.DDJALPPNIJE();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1243f;
		animator.SetInteger("Disappear", 0);
	}

	private void KACEOJDPLKB()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> butterflies = CharacterSpritesDBAccessor.GetButterflies();
		SpriteInfo oJKJDNNBJOF = butterflies[Random.Range(1, butterflies.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1750f;
		animator.SetInteger("ReceiveThrowSlowingSpikes", 1);
	}

	private void ELHCBGCEJDH()
	{
		if (LGLDPMAABLA > 780f)
		{
			AFAHMLNIEJB();
			LGLDPMAABLA = 0f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void PMPLNGEAAII()
	{
		if (LGLDPMAABLA > 666f)
		{
			CINNGOAOJMB();
			LGLDPMAABLA = 1458f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void GJMLHECPGBP()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.DDJALPPNIJE();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(1, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 884f;
		animator.SetInteger("Can't find seat. Reason: MaxCustomer", 1);
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADJHJCIHLKA();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1291f;
		animator.SetInteger("Tutorial/T300/Dialogue2", 1);
	}

	private void PKEPBKHEDOD()
	{
		if (LGLDPMAABLA > 754f)
		{
			MDHAJLINGCB();
			LGLDPMAABLA = 188f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void ICMNODPLPBK()
	{
		if (LGLDPMAABLA > 693f)
		{
			MDJLJJFODGJ();
			LGLDPMAABLA = 507f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void IGOPBADIPPO()
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
			if (val.x < 1108f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.x > 1024f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (val.y < 775f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 1521f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 1667f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)6 && val.x > 1762f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1749f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1338f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/10/Dialogue Text", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)8)
			{
				((Component)this).transform.localScale = new Vector3(1867f, 316f, 1939f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1105f, 1340f, 1926f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void IAICCKPOBMJ()
	{
		if (LGLDPMAABLA > 1390f)
		{
			CINNGOAOJMB();
			LGLDPMAABLA = 1123f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OAKGHDAABPM()
	{
		if (LGLDPMAABLA > 623f)
		{
			AFAHMLNIEJB();
			LGLDPMAABLA = 1919f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void GHPFCKGMLDA()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GLIBMFJEALE();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(1, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 587f;
		animator.SetInteger("", 0);
	}

	private void HIPNEFOEJPL()
	{
		if (LGLDPMAABLA > 977f)
		{
			MDHAJLINGCB();
			LGLDPMAABLA = 1012f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void MFMMHDPGCBO()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.PHPHNFDIAMO();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 928f;
		animator.SetInteger("Intro07", 1);
	}

	private void KDBJHCAEGCM()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> butterflies = CharacterSpritesDBAccessor.GetButterflies();
		SpriteInfo oJKJDNNBJOF = butterflies[Random.Range(0, butterflies.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1204f;
		animator.SetInteger("Menu scene is loaded, unloading...", 1);
	}

	private void Start()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> butterflies = CharacterSpritesDBAccessor.GetButterflies();
		SpriteInfo oJKJDNNBJOF = butterflies[Random.Range(0, butterflies.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 0f;
		animator.SetInteger("Direction", 0);
	}

	private void AFAHMLNIEJB()
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
			if (val.x < 1329f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.x > 859f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (val.y < 1963f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 944f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Right && val.x < 954f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 1140f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 782f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 272f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Player/Bark/Tutorial/T138", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)6)
			{
				((Component)this).transform.localScale = new Vector3(862f, 74f, 1915f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(358f, 871f, 548f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void KJOJLHCDFPP()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.PHPHNFDIAMO();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1221f;
		animator.SetInteger("Duplicate editor action id found: ", 1);
	}

	private void NIHJCJJKDBA()
	{
		if (LGLDPMAABLA > 1065f)
		{
			CINNGOAOJMB();
			LGLDPMAABLA = 1968f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void BHLHCOALABE()
	{
		if (LGLDPMAABLA > 1371f)
		{
			MDHAJLINGCB();
			LGLDPMAABLA = 820f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void JMDOCHBJGKG()
	{
		if (LGLDPMAABLA > 745f)
		{
			CINNGOAOJMB();
			LGLDPMAABLA = 1790f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OIAHJHNPPCO()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.PHPHNFDIAMO();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(1, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1554f;
		animator.SetInteger("Farm/Buzz/Bark_Searching", 0);
	}

	private void CINNGOAOJMB()
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
			if (val.x < 358f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.x > 1188f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (val.y < 203f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 1798f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 1566f)
			{
				FCGBJEIIMBC = (Direction)6;
			}
			else if (FCGBJEIIMBC == Direction.Diagonal && val.x > 1755f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 1236f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1853f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Ingredients list count == 0!", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Up)
			{
				((Component)this).transform.localScale = new Vector3(79f, 733f, 1746f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1856f, 949f, 818f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void Update()
	{
		if (LGLDPMAABLA > 0.3f)
		{
			HOLEHHECNDF();
			LGLDPMAABLA = 0f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void HOLEHHECNDF()
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

	private void AAOMCHHNKKM()
	{
		if (LGLDPMAABLA > 759f)
		{
			CINNGOAOJMB();
			LGLDPMAABLA = 1804f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void PJLKGOACDEN()
	{
		if (LGLDPMAABLA > 823f)
		{
			MDHAJLINGCB();
			LGLDPMAABLA = 1898f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void HJDLNCOAKIK()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.JJKLOBMIIEA();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1497f;
		animator.SetInteger("", 1);
	}

	private void EBNENBFLEKB()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.PHPHNFDIAMO();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(0, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 62f;
		animator.SetInteger("Dialogue System/Conversation/Rowdy/Entry/3/Dialogue Text", 0);
	}

	private void MDHAJLINGCB()
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
			if (val.x < 1150f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (val.x > 87f)
			{
				FCGBJEIIMBC = (Direction)7;
			}
			else if (val.y < 1368f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (val.y > 947f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == (Direction)5 && val.x < 381f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == Direction.Diagonal && val.x > 1704f)
			{
				FCGBJEIIMBC = (Direction)8;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.y < 492f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1363f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("itemRedPotato", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Right)
			{
				((Component)this).transform.localScale = new Vector3(1212f, 822f, 649f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(154f, 1270f, 1702f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void MDJLJJFODGJ()
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
			if (val.x < 993f)
			{
				FCGBJEIIMBC = Direction.Left;
			}
			else if (val.x > 571f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (val.y < 236f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (val.y > 827f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else if (FCGBJEIIMBC == Direction.Down && val.x < 1758f)
			{
				FCGBJEIIMBC = (Direction)5;
			}
			else if (FCGBJEIIMBC == (Direction)8 && val.x > 1603f)
			{
				FCGBJEIIMBC = Direction.Diagonal;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y < 877f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else if (FCGBJEIIMBC == Direction.Up && val.y > 1157f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Error_BarIsBlocking", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)7)
			{
				((Component)this).transform.localScale = new Vector3(1039f, 753f, 694f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1319f, 700f, 1715f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
	}

	private void FOHGHCPODBJ()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		List<SpriteInfo> list = CharacterSpritesDBAccessor.DDJALPPNIJE();
		SpriteInfo oJKJDNNBJOF = list[Random.Range(1, list.Count)];
		((Component)this).GetComponent<ReskinAnimation>().ChangeSpriteInfo(oJKJDNNBJOF);
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 331f;
		animator.SetInteger("times played: ", 0);
	}

	private void MNFMLJJBKNC()
	{
		if (LGLDPMAABLA > 46f)
		{
			IGOPBADIPPO();
			LGLDPMAABLA = 40f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}
}
