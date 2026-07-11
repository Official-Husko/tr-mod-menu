using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ShopElement
{
	public ShopItem shopItem;

	public Recipe recipe;

	public int amount;

	public ItemInstance itemInstance { get; private set; }

	public Item item
	{
		get
		{
			if (!((Object)(object)recipe != (Object)null))
			{
				return shopItem.item;
			}
			return recipe.output.item;
		}
	}

	public bool unlimited
	{
		get
		{
			if (!((Object)(object)recipe != (Object)null))
			{
				return shopItem.unlimited;
			}
			return false;
		}
	}

	[SpecialName]
	public bool PPAHHJBKNOJ()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	[SpecialName]
	private void ILHNOMMMNJL(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
	}

	[SpecialName]
	public bool OCMOJMLCBBK()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	[SpecialName]
	public ItemInstance NKCMJAOFLFH()
	{
		return itemInstance;
	}

	[SpecialName]
	public Item NOMDPFMPEII()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	[SpecialName]
	public Item BGCPMHHHLHG()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	[SpecialName]
	public ItemInstance NGKPILAELHO()
	{
		return itemInstance;
	}

	[SpecialName]
	public ItemInstance MFGDIJDAJII()
	{
		return itemInstance;
	}

	public void OMOHBIPBPKH()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			ILHNOMMMNJL(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			itemInstance = shopItem.item.JMDALJBNFML();
		}
	}

	[SpecialName]
	public ItemInstance BNFDKIDPEFD()
	{
		return itemInstance;
	}

	public Price LFHFOJKPJAI()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.GHDCKOJGAMM((int)(recipe.shopSilverPrice * 1628f));
			eNDNDAOPKHD = Price.EMJKENIECGH(eNDNDAOPKHD, (float)(-115 - PerksDatabaseAccessor.NGMJIGOPGDK(92, 0, LDNMDAHFBGG: true)) / 174f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.LFJHHLGOCPP(eNDNDAOPKHD, (float)(-57 - PerksDatabaseAccessor.NGMJIGOPGDK(87, 1)) / 1766f);
		}
		if (!LACFFEBNHKL().LMPKIMILCPN(SeasonManager.ADEICKHEPFI()))
		{
			eNDNDAOPKHD = Price.ILJPLDEDGPH(eNDNDAOPKHD, Price.CBCAAHPFLGO(NOMDPFMPEII().price, 703f));
		}
		return eNDNDAOPKHD;
	}

	public void MAOMPPAJKPD()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			ALPLLHLLMGC(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			itemInstance = shopItem.item.JMDALJBNFML();
		}
	}

	[SpecialName]
	public ItemInstance BODBEPJAFHL()
	{
		return itemInstance;
	}

	[SpecialName]
	public bool FGEFPBCMAMA()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	public void PFCBBEIEKBM()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			FAPBDMPCHPA(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			ALPLLHLLMGC(shopItem.item.JMDALJBNFML());
		}
	}

	public ShopElement(ShopItem EPBCFCNEOCF, int MGNOBNCMDJG, ItemInstance DNLMCHDOMOK = null)
	{
		shopItem = EPBCFCNEOCF;
		recipe = null;
		if (DNLMCHDOMOK == null)
		{
			itemInstance = EPBCFCNEOCF.item.JMDALJBNFML();
		}
		else
		{
			itemInstance = DNLMCHDOMOK;
		}
		amount = MGNOBNCMDJG;
	}

	public void DGIFAONFHFJ()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			ALPLLHLLMGC(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			itemInstance = shopItem.item.JMDALJBNFML();
		}
	}

	public Price HJGAOGPHJHF()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.GHDCKOJGAMM((int)(recipe.shopSilverPrice * 1415f));
			eNDNDAOPKHD = Price.LFJHHLGOCPP(eNDNDAOPKHD, (float)(-79 - PerksDatabaseAccessor.NGMJIGOPGDK(-45, 0, LDNMDAHFBGG: true)) / 1007f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.MPPPFDKJGNI(eNDNDAOPKHD, (float)(-34 - PerksDatabaseAccessor.GetPlayerPerkValue(85, 0, LDNMDAHFBGG: true)) / 872f);
		}
		if (!AJFBPLGGHLE().LMPKIMILCPN(SeasonManager.EEGJBDCBKFD()))
		{
			eNDNDAOPKHD = Price.IGEAFJCEGEM(eNDNDAOPKHD, Price.CBCAAHPFLGO(item.price, 1052f));
		}
		return eNDNDAOPKHD;
	}

	public Price HNGEJNDLALE()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.GHDCKOJGAMM((int)(recipe.shopSilverPrice * 100f));
			eNDNDAOPKHD = Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)(100 - PerksDatabaseAccessor.GetPlayerPerkValue(32)) / 100f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)(100 - PerksDatabaseAccessor.GetPlayerPerkValue(31)) / 100f);
		}
		if (!item.PJDJHNOFOAN(SeasonManager.EECEKHKAAIH))
		{
			eNDNDAOPKHD = Price.GMJIFJAEANF(eNDNDAOPKHD, Price.FAFHFJGOHPK(item.price, 0.2f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public ItemInstance KIPHICGPKHO()
	{
		return itemInstance;
	}

	[SpecialName]
	public bool BILKBOCKMAI()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	[SpecialName]
	private void FAPBDMPCHPA(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
	}

	[SpecialName]
	public ItemInstance HHBICHCGPPK()
	{
		return itemInstance;
	}

	public Price JKMODCDMMEE()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.HNDGIKFAKNC((int)(recipe.shopSilverPrice * 351f));
			eNDNDAOPKHD = Price.CBCAAHPFLGO(eNDNDAOPKHD, (float)(45 - PerksDatabaseAccessor.NGMJIGOPGDK(-18, 1, LDNMDAHFBGG: true)) / 1139f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.LBOFJOBAGKA(eNDNDAOPKHD, (float)(10 - PerksDatabaseAccessor.GetPlayerPerkValue(-66, 0, LDNMDAHFBGG: true)) / 205f);
		}
		if (!LACFFEBNHKL().PAEEPJCIPFF(SeasonManager.LPGPJPPLHKG()))
		{
			eNDNDAOPKHD = Price.NJGIKAIFCNA(eNDNDAOPKHD, Price.EMJKENIECGH(item.price, 1045f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public bool PEJNAGBKOEI()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	public void KLFEPJJKKBD()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			ILHNOMMMNJL(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			GMGBGGBKGNI(shopItem.item.JMDALJBNFML());
		}
	}

	[SpecialName]
	private void GMGBGGBKGNI(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
	}

	[SpecialName]
	public Item EGJLDMLKLNC()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	public Price DJCJMJBEHFO()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.OMDBJINNHPC((int)(recipe.shopSilverPrice * 284f));
			eNDNDAOPKHD = Price.CBCAAHPFLGO(eNDNDAOPKHD, (float)(82 - PerksDatabaseAccessor.GetPlayerPerkValue(-18, 1)) / 1413f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)(-85 - PerksDatabaseAccessor.NGMJIGOPGDK(-46, 1, LDNMDAHFBGG: true)) / 931f);
		}
		if (!AJFBPLGGHLE().PAEEPJCIPFF(SeasonManager.PJMGHIMKFJL()))
		{
			eNDNDAOPKHD = Price.IGEAFJCEGEM(eNDNDAOPKHD, Price.LFJHHLGOCPP(KMIOEMCGOJG().price, 1998f));
		}
		return eNDNDAOPKHD;
	}

	public void BJEDNMLOPEN()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			itemInstance = recipe.output.item.JMDALJBNFML();
		}
		else
		{
			itemInstance = shopItem.item.JMDALJBNFML();
		}
	}

	public Price IKBOPEDDABA()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.IFMFKEMHHLM((int)(recipe.shopSilverPrice * 1522f));
			eNDNDAOPKHD = Price.MPPPFDKJGNI(eNDNDAOPKHD, (float)(-124 - PerksDatabaseAccessor.NGMJIGOPGDK(-75, 1)) / 1508f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)(87 - PerksDatabaseAccessor.NGMJIGOPGDK(29, 1, LDNMDAHFBGG: true)) / 687f);
		}
		if (!KMIOEMCGOJG().PAEEPJCIPFF(SeasonManager.KCJFCHNPIBJ()))
		{
			eNDNDAOPKHD = Price.ILJPLDEDGPH(eNDNDAOPKHD, Price.FAFHFJGOHPK(NOMDPFMPEII().price, 134f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public ItemInstance FOFEOHPPMMA()
	{
		return itemInstance;
	}

	[SpecialName]
	public bool LCDCLDGFPNM()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	[SpecialName]
	public ItemInstance BKCJMBGKDNA()
	{
		return itemInstance;
	}

	public Price JJJLJKBLGCH()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.LEDHAKFAHCI((int)(recipe.shopSilverPrice * 1220f));
			eNDNDAOPKHD = Price.CBCAAHPFLGO(eNDNDAOPKHD, (float)(92 - PerksDatabaseAccessor.NGMJIGOPGDK(-47, 1)) / 437f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.LFJHHLGOCPP(eNDNDAOPKHD, (float)(112 - PerksDatabaseAccessor.GetPlayerPerkValue(-53, 0, LDNMDAHFBGG: true)) / 282f);
		}
		if (!item.PAEEPJCIPFF(SeasonManager.EECEKHKAAIH))
		{
			eNDNDAOPKHD = Price.ILJPLDEDGPH(eNDNDAOPKHD, Price.MPPPFDKJGNI(BGCPMHHHLHG().price, 1712f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public ItemInstance PJAFAAGCMEI()
	{
		return itemInstance;
	}

	[SpecialName]
	public bool PBHINHCKDMD()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	public void JCGFMEGONAA()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			itemInstance = recipe.output.item.JMDALJBNFML();
		}
		else
		{
			ILHNOMMMNJL(shopItem.item.JMDALJBNFML());
		}
	}

	public Price GOFIJNHEBJI()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.OMDBJINNHPC((int)(recipe.shopSilverPrice * 1865f));
			eNDNDAOPKHD = Price.MMCDFKKJOHE(eNDNDAOPKHD, (float)(125 - PerksDatabaseAccessor.NGMJIGOPGDK(2, 0, LDNMDAHFBGG: true)) / 443f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.MPPPFDKJGNI(eNDNDAOPKHD, (float)(78 - PerksDatabaseAccessor.GetPlayerPerkValue(33, 1, LDNMDAHFBGG: true)) / 500f);
		}
		if (!KMIOEMCGOJG().NAGFJDBDNOA(SeasonManager.NHKAHEEGEGF()))
		{
			eNDNDAOPKHD = Price.GMJIFJAEANF(eNDNDAOPKHD, Price.MPPPFDKJGNI(LPIBILEAIOL().price, 708f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public bool LENDPJOIMBM()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	[SpecialName]
	public bool ECPCCFIELEP()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	[SpecialName]
	public bool FEPGHNJNHKB()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	[SpecialName]
	public Item LACFFEBNHKL()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	public void KGMLFOKACJO()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			GMGBGGBKGNI(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			GMGBGGBKGNI(shopItem.item.JMDALJBNFML());
		}
	}

	[SpecialName]
	public ItemInstance IAAECDPPPKD()
	{
		return itemInstance;
	}

	[SpecialName]
	public Item AJFBPLGGHLE()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	[SpecialName]
	public Item LPIBILEAIOL()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	[SpecialName]
	public ItemInstance PGDLGEMHCOH()
	{
		return itemInstance;
	}

	[SpecialName]
	public bool COJCALHOAFC()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	[SpecialName]
	public bool OJHDCEAJGNH()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	public ShopElement(ShopElement IFKKAOEBOFP)
	{
		shopItem = IFKKAOEBOFP.shopItem;
		recipe = IFKKAOEBOFP.recipe;
		amount = IFKKAOEBOFP.amount;
		itemInstance = new ItemInstance(IFKKAOEBOFP.itemInstance);
	}

	[SpecialName]
	public bool OAKIJEEJDNC()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	[SpecialName]
	private void ALPLLHLLMGC(ItemInstance AODONKKHPBP)
	{
		itemInstance = AODONKKHPBP;
	}

	public Price PPIBALBGLHB()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.DHMGJGHCCJD((int)(recipe.shopSilverPrice * 1813f));
			eNDNDAOPKHD = Price.LBOFJOBAGKA(eNDNDAOPKHD, (float)(108 - PerksDatabaseAccessor.NGMJIGOPGDK(-103, 1, LDNMDAHFBGG: true)) / 411f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.LFJHHLGOCPP(eNDNDAOPKHD, (float)(115 - PerksDatabaseAccessor.NGMJIGOPGDK(67, 1)) / 988f);
		}
		if (!BGCPMHHHLHG().LMPKIMILCPN(SeasonManager.NHKAHEEGEGF()))
		{
			eNDNDAOPKHD = Price.IGEAFJCEGEM(eNDNDAOPKHD, Price.EMJKENIECGH(LPIBILEAIOL().price, 402f));
		}
		return eNDNDAOPKHD;
	}

	public ShopElement(Recipe JNLKEMLDFIM)
	{
		shopItem = null;
		recipe = JNLKEMLDFIM;
		amount = 1;
		if (Object.op_Implicit((Object)(object)JNLKEMLDFIM.output.item))
		{
			itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
		}
		else
		{
			itemInstance = null;
		}
	}

	[SpecialName]
	public ItemInstance AFOOOEAJCNP()
	{
		return itemInstance;
	}

	public void KAJJLEMPIOP()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			ILHNOMMMNJL(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			FAPBDMPCHPA(shopItem.item.JMDALJBNFML());
		}
	}

	[SpecialName]
	public Item KMIOEMCGOJG()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	public Price JMEJAMCMPIE()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.IFMFKEMHHLM((int)(recipe.shopSilverPrice * 619f));
			eNDNDAOPKHD = Price.CBCAAHPFLGO(eNDNDAOPKHD, (float)(-32 - PerksDatabaseAccessor.GetPlayerPerkValue(68)) / 239f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.EMJKENIECGH(eNDNDAOPKHD, (float)(61 - PerksDatabaseAccessor.NGMJIGOPGDK(-55)) / 1488f);
		}
		if (!LBBEIEHEHJM().PJDJHNOFOAN(SeasonManager.NHKAHEEGEGF()))
		{
			eNDNDAOPKHD = Price.BIJDAACPLPB(eNDNDAOPKHD, Price.LBOFJOBAGKA(BGCPMHHHLHG().price, 929f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public ItemInstance BAKAGAJOMAP()
	{
		return itemInstance;
	}

	[SpecialName]
	public bool CEOEFPILOFL()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	public void HOEBCDPBDOA()
	{
		if (Object.op_Implicit((Object)(object)recipe))
		{
			ALPLLHLLMGC(recipe.output.item.JMDALJBNFML());
		}
		else
		{
			ILHNOMMMNJL(shopItem.item.JMDALJBNFML());
		}
	}

	[SpecialName]
	public bool JFMGCCCLABE()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	public Price PBLBHAFNOBH()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.LEDHAKFAHCI((int)(recipe.shopSilverPrice * 317f));
			eNDNDAOPKHD = Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)(-120 - PerksDatabaseAccessor.GetPlayerPerkValue(53)) / 484f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.CBCAAHPFLGO(eNDNDAOPKHD, (float)(-27 - PerksDatabaseAccessor.NGMJIGOPGDK(-63, 1, LDNMDAHFBGG: true)) / 167f);
		}
		if (!AJFBPLGGHLE().PJDJHNOFOAN(SeasonManager.EEGJBDCBKFD()))
		{
			eNDNDAOPKHD = Price.HKAKDIKLBBJ(eNDNDAOPKHD, Price.LBOFJOBAGKA(LPIBILEAIOL().price, 540f));
		}
		return eNDNDAOPKHD;
	}

	public Price FDKELEJDKPA()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.DHMGJGHCCJD((int)(recipe.shopSilverPrice * 655f));
			eNDNDAOPKHD = Price.MMCDFKKJOHE(eNDNDAOPKHD, (float)(-98 - PerksDatabaseAccessor.NGMJIGOPGDK(-108, 1, LDNMDAHFBGG: true)) / 1825f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.LBOFJOBAGKA(eNDNDAOPKHD, (float)(-81 - PerksDatabaseAccessor.GetPlayerPerkValue(98, 0, LDNMDAHFBGG: true)) / 1094f);
		}
		if (!AJFBPLGGHLE().PJDJHNOFOAN(SeasonManager.KCJFCHNPIBJ()))
		{
			eNDNDAOPKHD = Price.BIJDAACPLPB(eNDNDAOPKHD, Price.LBOFJOBAGKA(LBBEIEHEHJM().price, 1920f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public bool CNDBCHJHLDK()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	[SpecialName]
	public Item LBBEIEHEHJM()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.item;
		}
		return recipe.output.item;
	}

	public Price PDIHJNJIEJA()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.GHDCKOJGAMM((int)(recipe.shopSilverPrice * 1544f));
			eNDNDAOPKHD = Price.LFJHHLGOCPP(eNDNDAOPKHD, (float)(-60 - PerksDatabaseAccessor.NGMJIGOPGDK(-1, 1, LDNMDAHFBGG: true)) / 1386f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.MMCDFKKJOHE(eNDNDAOPKHD, (float)(-25 - PerksDatabaseAccessor.GetPlayerPerkValue(-69)) / 1260f);
		}
		if (!LACFFEBNHKL().PAEEPJCIPFF(SeasonManager.BLCGOEMGKGH()))
		{
			eNDNDAOPKHD = Price.ILJPLDEDGPH(eNDNDAOPKHD, Price.LBOFJOBAGKA(item.price, 388f));
		}
		return eNDNDAOPKHD;
	}

	public Price JNIJFBKHNKJ()
	{
		Price eNDNDAOPKHD;
		if ((Object)(object)recipe != (Object)null)
		{
			eNDNDAOPKHD = Price.LEDHAKFAHCI((int)(recipe.shopSilverPrice * 246f));
			eNDNDAOPKHD = Price.MMCDFKKJOHE(eNDNDAOPKHD, (float)(93 - PerksDatabaseAccessor.GetPlayerPerkValue(-2)) / 1026f);
		}
		else
		{
			eNDNDAOPKHD = shopItem.item.price;
			eNDNDAOPKHD = Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)(11 - PerksDatabaseAccessor.NGMJIGOPGDK(85, 1, LDNMDAHFBGG: true)) / 1612f);
		}
		if (!EGJLDMLKLNC().LMPKIMILCPN(SeasonManager.KCJFCHNPIBJ()))
		{
			eNDNDAOPKHD = Price.IGEAFJCEGEM(eNDNDAOPKHD, Price.MPPPFDKJGNI(NOMDPFMPEII().price, 529f));
		}
		return eNDNDAOPKHD;
	}

	[SpecialName]
	public bool ENOAEACMMOB()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return false;
	}

	[SpecialName]
	public bool KDCACDHNNDA()
	{
		if (!((Object)(object)recipe != (Object)null))
		{
			return shopItem.unlimited;
		}
		return true;
	}

	[SpecialName]
	public ItemInstance PBBFBFFPFJC()
	{
		return itemInstance;
	}
}
