using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HumanNPC : NPC
{
	public Action OnSit = delegate
	{
	};

	public Customer customer;

	public CharacterCreator characterCreator;

	public Seat seat;

	public bool spawnedLeft;

	public int spawnedIndex;

	private Vector3 AJLJHLHGGBD;

	private Vector3 KGAMHMCGNDN;

	public CharacterAnimation FJHKGBNBNKL => animationBase as CharacterAnimation;

	public void PCPNEJOIKAN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (PBLBPGPJFHI() == NPCState.Walking && !((Object)(object)CCFDNFDEGIK() == (Object)null))
		{
			DKLMKBPEHAJ().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 1810f;
			if (CGBPBCDLOCM().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				DKMPEPHLBGI().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), DHMMHOPEMLF().FCGBJEIIMBC));
			}
		}
	}

	public void OBJHHNMMCGF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (LLNABOMIIOM() == NPCState.Walking && !((Object)(object)GDDFKLAEACF() == (Object)null))
		{
			DHMMHOPEMLF().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 248f;
			if (OHKDOEFGKFA().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				PNGIDKBCGCK().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), PABOGCMHLAN().FCGBJEIIMBC);
			}
		}
	}

	public void GAEDNJMJDJD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (PBLBPGPJFHI() == NPCState.Walking && !((Object)(object)FJHKGBNBNKL == (Object)null))
		{
			CFIFGDBGLPH().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1809f);
			if (JEFADBEHABI().LHGMJFGOHFD() && OnlineManager.PGAGDFAEEFB())
			{
				CFIFGDBGLPH().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), NDPNCJAOGNL().FCGBJEIIMBC));
			}
		}
	}

	[SpecialName]
	public CharacterAnimation DKLMKBPEHAJ()
	{
		return animationBase as CharacterAnimation;
	}

	public void FJIJNLKJGKC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (LLNABOMIIOM() == NPCState.Walking && !((Object)(object)APBNLDNECGJ() == (Object)null))
		{
			LNJABLMFNNE().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 475f;
			if (KOIKANGEOFD().CNKHDCIKHCO && OnlineManager.MasterOrOffline())
			{
				OAHOFAKKBBA().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), DKMPEPHLBGI().FCGBJEIIMBC);
			}
		}
	}

	[SpecialName]
	public CharacterAnimation CCFDNFDEGIK()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation DKMPEPHLBGI()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation NDPNCJAOGNL()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation NOJMFFFDAJA()
	{
		return animationBase as CharacterAnimation;
	}

	public void LILOALHNAND()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)OJELDLIEDNI() == (Object)null))
		{
			FJHKGBNBNKL.IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1579f);
			if (GDDFKLAEACF().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				LNJABLMFNNE().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), JEFADBEHABI().FCGBJEIIMBC);
			}
		}
	}

	[SpecialName]
	public CharacterAnimation LNJABLMFNNE()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation FNGPCELFEHO()
	{
		return animationBase as CharacterAnimation;
	}

	public void MDKNIJCHHCE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)BIFKPMIMAEC() == (Object)null))
		{
			BFBEDHOHEPH().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1327f;
			if (BKPDJIDCAEO().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				NDPNCJAOGNL().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), BMCNJOEAJBH().FCGBJEIIMBC));
			}
		}
	}

	public void NDADMKEDAAK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (base.EOAONHNCDDO == NPCState.Walking && !((Object)(object)APBNLDNECGJ() == (Object)null))
		{
			BMCNJOEAJBH().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 660f);
			if (PABOGCMHLAN().LHGMJFGOHFD() && OnlineManager.MasterOrOffline())
			{
				LNJABLMFNNE().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), IBGCFFIFPBL().FCGBJEIIMBC));
			}
		}
	}

	[SpecialName]
	public CharacterAnimation CFIFGDBGLPH()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation CGBPBCDLOCM()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation OAHOFAKKBBA()
	{
		return animationBase as CharacterAnimation;
	}

	protected override void Awake()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animationBase == (Object)null)
		{
			animationBase = ((Component)this).GetComponent<CharacterAnimBase>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		base.Awake();
	}

	[SpecialName]
	public CharacterAnimation OJELDLIEDNI()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation EPLLKPJIAFF()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation OLHBCAHONME()
	{
		return animationBase as CharacterAnimation;
	}

	public void BOKOLOCCLEN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DJAFGOHMNBK() == NPCState.Walking && !((Object)(object)CFIFGDBGLPH() == (Object)null))
		{
			FJHKGBNBNKL.CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 162f;
			if (OLHBCAHONME().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				BFBEDHOHEPH().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), BIFKPMIMAEC().FCGBJEIIMBC);
			}
		}
	}

	public void IGNLHLAAMMN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)CFIFGDBGLPH() == (Object)null))
		{
			JHOGIKCHCGG().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 353f;
			if (BFBEDHOHEPH().LHGMJFGOHFD() && OnlineManager.PGAGDFAEEFB())
			{
				PAMGMEAHNCI().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), JEFADBEHABI().FCGBJEIIMBC);
			}
		}
	}

	public void EFLEPALELDJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (PBLBPGPJFHI() == NPCState.Walking && !((Object)(object)JHOGIKCHCGG() == (Object)null))
		{
			OAHOFAKKBBA().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 933f);
			if (IBGCFFIFPBL().LHGMJFGOHFD() && OnlineManager.MasterOrOffline())
			{
				GDDFKLAEACF().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), APBNLDNECGJ().FCGBJEIIMBC);
			}
		}
	}

	public void HDDBJBECDPP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DJAFGOHMNBK() == NPCState.Walking && !((Object)(object)DKMPEPHLBGI() == (Object)null))
		{
			CGBPBCDLOCM().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 400f);
			if (CFIFGDBGLPH().LHGMJFGOHFD() && OnlineManager.MasterOrOffline())
			{
				EPLLKPJIAFF().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), APBNLDNECGJ().FCGBJEIIMBC));
			}
		}
	}

	public void FKCOPHFELKD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (PBLBPGPJFHI() == NPCState.Walking && !((Object)(object)CGBPBCDLOCM() == (Object)null))
		{
			CCFDNFDEGIK().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1206f);
			if (CFIFGDBGLPH().CNKHDCIKHCO && OnlineManager.MasterOrOffline())
			{
				NDPNCJAOGNL().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), EPLLKPJIAFF().FCGBJEIIMBC);
			}
		}
	}

	[SpecialName]
	public CharacterAnimation IBGCFFIFPBL()
	{
		return animationBase as CharacterAnimation;
	}

	public void HKOFLOPDCEJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (LLNABOMIIOM() == NPCState.Walking && !((Object)(object)DCMNEPOPBKA() == (Object)null))
		{
			GDDFKLAEACF().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 1788f;
			if (JHOGIKCHCGG().LHGMJFGOHFD() && OnlineManager.MasterOrOffline())
			{
				GDDFKLAEACF().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), GHNLDKEOCFA().FCGBJEIIMBC));
			}
		}
	}

	public void NBNCMOAPDOG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DJAFGOHMNBK() == NPCState.Walking && !((Object)(object)APBNLDNECGJ() == (Object)null))
		{
			OHKDOEFGKFA().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 294f);
			if (OHKDOEFGKFA().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				CCFDNFDEGIK().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), DHMMHOPEMLF().FCGBJEIIMBC);
			}
		}
	}

	[SpecialName]
	public CharacterAnimation OHKDOEFGKFA()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation BMCNJOEAJBH()
	{
		return animationBase as CharacterAnimation;
	}

	public void OGFKFGAMGCE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (base.EOAONHNCDDO == NPCState.Walking && !((Object)(object)EPLLKPJIAFF() == (Object)null))
		{
			PAMGMEAHNCI().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1470f;
			if (NOJMFFFDAJA().CNKHDCIKHCO && OnlineManager.MasterOrOffline())
			{
				DCMNEPOPBKA().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), DCMNEPOPBKA().FCGBJEIIMBC));
			}
		}
	}

	[SpecialName]
	public CharacterAnimation BKPDJIDCAEO()
	{
		return animationBase as CharacterAnimation;
	}

	public void LALGIJBMOMI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)CFIFGDBGLPH() == (Object)null))
		{
			DCMNEPOPBKA().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 483f;
			if (OHKDOEFGKFA().LHGMJFGOHFD() && OnlineManager.PGAGDFAEEFB())
			{
				FNGPCELFEHO().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), OLHBCAHONME().FCGBJEIIMBC));
			}
		}
	}

	public void PFNIPILPGFN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)NDPNCJAOGNL() == (Object)null))
		{
			BIFKPMIMAEC().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 1077f;
			if (FNGPCELFEHO().CNKHDCIKHCO && OnlineManager.MasterOrOffline())
			{
				DCMNEPOPBKA().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), IBGCFFIFPBL().FCGBJEIIMBC);
			}
		}
	}

	public void FOIGFCMPAAO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (base.EOAONHNCDDO == NPCState.Walking && !((Object)(object)DKMPEPHLBGI() == (Object)null))
		{
			IBGCFFIFPBL().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 383f;
			if (GHNLDKEOCFA().LHGMJFGOHFD() && OnlineManager.MasterOrOffline())
			{
				DKMPEPHLBGI().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), KOIKANGEOFD().FCGBJEIIMBC);
			}
		}
	}

	[SpecialName]
	public CharacterAnimation DHMMHOPEMLF()
	{
		return animationBase as CharacterAnimation;
	}

	public void DGDCMLPELHD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DJAFGOHMNBK() == NPCState.Walking && !((Object)(object)DKMPEPHLBGI() == (Object)null))
		{
			LNJABLMFNNE().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1193f;
			if (OJELDLIEDNI().LHGMJFGOHFD() && OnlineManager.PGAGDFAEEFB())
			{
				APBNLDNECGJ().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), LNJABLMFNNE().FCGBJEIIMBC));
			}
		}
	}

	[SpecialName]
	public CharacterAnimation KOIKANGEOFD()
	{
		return animationBase as CharacterAnimation;
	}

	public void FixedUpdate()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (base.EOAONHNCDDO == NPCState.Walking && !((Object)(object)FJHKGBNBNKL == (Object)null))
		{
			FJHKGBNBNKL.CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 0f;
			if (FJHKGBNBNKL.CNKHDCIKHCO && OnlineManager.MasterOrOffline())
			{
				FJHKGBNBNKL.FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), FJHKGBNBNKL.FCGBJEIIMBC);
			}
		}
	}

	public void KIGPIILBDAC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (LLNABOMIIOM() == NPCState.Walking && !((Object)(object)LNJABLMFNNE() == (Object)null))
		{
			KOIKANGEOFD().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 149f);
			if (NDPNCJAOGNL().CNKHDCIKHCO && OnlineManager.MasterOrOffline())
			{
				KOIKANGEOFD().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), PNGIDKBCGCK().FCGBJEIIMBC);
			}
		}
	}

	public void DEFIFMAOPCM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (LLNABOMIIOM() == NPCState.Walking && !((Object)(object)OHKDOEFGKFA() == (Object)null))
		{
			PABOGCMHLAN().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1028f);
			if (CFIFGDBGLPH().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				BMCNJOEAJBH().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), DHMMHOPEMLF().FCGBJEIIMBC);
			}
		}
	}

	[SpecialName]
	public CharacterAnimation BFBEDHOHEPH()
	{
		return animationBase as CharacterAnimation;
	}

	public void PGJLFLKDLAE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)PAMGMEAHNCI() == (Object)null))
		{
			DHMMHOPEMLF().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 855f;
			if (JEFADBEHABI().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				PAMGMEAHNCI().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), BMCNJOEAJBH().FCGBJEIIMBC));
			}
		}
	}

	[SpecialName]
	public CharacterAnimation PABOGCMHLAN()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation APBNLDNECGJ()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation DCMNEPOPBKA()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation JHOGIKCHCGG()
	{
		return animationBase as CharacterAnimation;
	}

	public void ODJPLNDJKEA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DJAFGOHMNBK() == NPCState.Walking && !((Object)(object)PAMGMEAHNCI() == (Object)null))
		{
			DKMPEPHLBGI().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 1320f;
			if (GHNLDKEOCFA().LHGMJFGOHFD() && OnlineManager.PGAGDFAEEFB())
			{
				DKMPEPHLBGI().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), OLHBCAHONME().FCGBJEIIMBC));
			}
		}
	}

	public override void ChangeNPCState(NPCState OJGICFBAAMH, bool OACENDACGCC = true)
	{
		if (OJGICFBAAMH == base.EOAONHNCDDO && OACENDACGCC)
		{
			return;
		}
		if (base.EOAONHNCDDO == NPCState.Sitting)
		{
			seat.GetUp();
		}
		base.ChangeNPCState(OJGICFBAAMH, OACENDACGCC);
		switch (OJGICFBAAMH)
		{
		case NPCState.Standing:
			if ((Object)(object)FJHKGBNBNKL != (Object)null)
			{
				FJHKGBNBNKL.CNKHDCIKHCO = false;
			}
			break;
		case NPCState.Sitting:
			seat.SitDown(this);
			if ((Object)(object)FJHKGBNBNKL != (Object)null)
			{
				FJHKGBNBNKL.FCGBJEIIMBC = seat.placeable.GetDirection();
				FJHKGBNBNKL.FCGBJEIIMBC = seat.placeable.GetDirection();
			}
			OnSit();
			break;
		}
	}

	[SpecialName]
	public CharacterAnimation PAMGMEAHNCI()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation JEFADBEHABI()
	{
		return animationBase as CharacterAnimation;
	}

	public void NLOEGNNLKKE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)CCFDNFDEGIK() == (Object)null))
		{
			LNJABLMFNNE().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 350f;
			if (BKPDJIDCAEO().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				PAMGMEAHNCI().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), CFIFGDBGLPH().FCGBJEIIMBC);
			}
		}
	}

	public void NNMGIHNNKED()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)CFIFGDBGLPH() == (Object)null))
		{
			OHKDOEFGKFA().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1913f);
			if (PABOGCMHLAN().CNKHDCIKHCO && OnlineManager.PGAGDFAEEFB())
			{
				DKLMKBPEHAJ().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), NDPNCJAOGNL().FCGBJEIIMBC));
			}
		}
	}

	public void HINEHDJIPGP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)BKPDJIDCAEO() == (Object)null))
		{
			CFIFGDBGLPH().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 412f;
			if (DKMPEPHLBGI().CNKHDCIKHCO && OnlineManager.MasterOrOffline())
			{
				IBGCFFIFPBL().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), EPLLKPJIAFF().FCGBJEIIMBC));
			}
		}
	}

	public void FBNHGAOGDJE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (DLLLCEOKMBH() == NPCState.Walking && !((Object)(object)BKPDJIDCAEO() == (Object)null))
		{
			CCFDNFDEGIK().CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 1273f;
			if (LNJABLMFNNE().LHGMJFGOHFD() && OnlineManager.PGAGDFAEEFB())
			{
				DKMPEPHLBGI().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), CFIFGDBGLPH().FCGBJEIIMBC);
			}
		}
	}

	public override void FindPath(Vector3 NOLFMLNLJJG, Vector3 GGHMLBCCMKL, Action<Vector2[], bool> AABDPKCDEKB)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 nOLFMLNLJJG = ((base.EOAONHNCDDO == NPCState.Sitting && Object.op_Implicit((Object)(object)seat)) ? seat.enteredLocation : NOLFMLNLJJG);
		base.FindPath(nOLFMLNLJJG, GGHMLBCCMKL, AABDPKCDEKB);
	}

	[SpecialName]
	public CharacterAnimation BIFKPMIMAEC()
	{
		return animationBase as CharacterAnimation;
	}

	public void OOBDKJHKPEP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (LLNABOMIIOM() == NPCState.Walking && !((Object)(object)LNJABLMFNNE() == (Object)null))
		{
			BMCNJOEAJBH().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 505f);
			if (OLHBCAHONME().LHGMJFGOHFD() && OnlineManager.MasterOrOffline())
			{
				BMCNJOEAJBH().FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), CCFDNFDEGIK().FCGBJEIIMBC);
			}
		}
	}

	[SpecialName]
	public CharacterAnimation PNGIDKBCGCK()
	{
		return animationBase as CharacterAnimation;
	}

	public void GIHCKNBINMG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (base.EOAONHNCDDO == NPCState.Walking && !((Object)(object)PABOGCMHLAN() == (Object)null))
		{
			PAMGMEAHNCI().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 873f);
			if (CCFDNFDEGIK().LHGMJFGOHFD() && OnlineManager.PGAGDFAEEFB())
			{
				GHNLDKEOCFA().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), PABOGCMHLAN().FCGBJEIIMBC));
			}
		}
	}

	[SpecialName]
	public CharacterAnimation GDDFKLAEACF()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation IMGOIBOHCIK()
	{
		return animationBase as CharacterAnimation;
	}

	[SpecialName]
	public CharacterAnimation GHNLDKEOCFA()
	{
		return animationBase as CharacterAnimation;
	}

	public void GEEPFKHHKDD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (base.EOAONHNCDDO == NPCState.Walking && !((Object)(object)OJELDLIEDNI() == (Object)null))
		{
			BKPDJIDCAEO().IHHBOLPDMCJ(((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 1028f);
			if (BIFKPMIMAEC().LHGMJFGOHFD() && OnlineManager.MasterOrOffline())
			{
				BKPDJIDCAEO().NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(KGAMHMCGNDN), PAMGMEAHNCI().FCGBJEIIMBC));
			}
		}
	}
}
