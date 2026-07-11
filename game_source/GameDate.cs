using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public struct GameDate
{
	[Serializable]
	public struct Time
	{
		public int years;

		public int weeks;

		public int days;

		public int hours;

		public int mins;

		public bool BMKCHHJPPOK()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return true;
		}

		[SpecialName]
		public static Time EBOFLAAEKMD(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return ELIADPDCCCI((ulong)((float)NPGPMHNJMGH(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time FBNFJFFLKKL(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return GHAAEBJLHNM((ulong)((float)ECNDPHEAICN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time GDNHKLNCOAN(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return HFMOADPPKEB((ulong)((float)GODDOILLGOP(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		public bool BIPEMPEDDCE()
		{
			if (years >= 0 && weeks >= 0 && days >= 0 && hours >= 0)
			{
				return mins < 0;
			}
			return true;
		}

		[SpecialName]
		public static Time CDJBKCAJKEI(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return DAPIOIKPOKA(DPGHJDNBGOJ(GIPIMIBOFPI) + GODDOILLGOP(KONAIPOGEGL));
		}

		public bool EGGFDCKAJOA()
		{
			if (years >= 0 && weeks >= 1 && days >= 1 && hours >= 1)
			{
				return mins < 1;
			}
			return true;
		}

		public bool IPGBEHKPNCC()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		[SpecialName]
		public static Time AINGANPMNNN(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return NNMBEHMKMGH((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time BCCMMIENAEH(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return LLGGAHMELHL((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		public bool BMBLACGBGPB()
		{
			if (years >= 0 && weeks >= 1 && days >= 0 && hours >= 1)
			{
				return mins < 1;
			}
			return true;
		}

		public bool KKGFHFFLHNI()
		{
			if (years >= 1 && weeks >= 0 && days >= 1 && hours >= 1)
			{
				return mins < 0;
			}
			return true;
		}

		public bool LEPAJOCACCL()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return true;
		}

		public Time(int MECAHKMLGLH, int NIFCDFGPKEP, int LCBDINCABAC, int IEGCEEEINDL, int MHJECLOHHML)
		{
			years = MECAHKMLGLH;
			weeks = NIFCDFGPKEP;
			days = LCBDINCABAC;
			hours = IEGCEEEINDL;
			mins = MHJECLOHHML;
		}

		[SpecialName]
		public static Time PNONKMFNCEB(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return MNNLLGBJKMK(DPGHJDNBGOJ(GIPIMIBOFPI) + GODDOILLGOP(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time GBGJINBCPPB(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return ELIADPDCCCI((ulong)((float)NPGPMHNJMGH(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time NHBCKCNMMMD(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return NNMBEHMKMGH(BJENFLGPHHN(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		[SpecialName]
		public static Time IHHOKGBMBKL(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return HFMOADPPKEB((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time ININABLGEBI(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return NNMBEHMKMGH(GODDOILLGOP(GIPIMIBOFPI) - GODDOILLGOP(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time KJDLGCLFALG(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return DAPIOIKPOKA((ulong)((float)NPGPMHNJMGH(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		public bool JPHNDFHNCGP()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return false;
		}

		public bool LNPODHBKGCH()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		public override string ToString()
		{
			string text = ((LocalisationSystem.CMIBBDJLMBM.id != 4 && LocalisationSystem.CMIBBDJLMBM.id != 14) ? (((years == 0) ? "" : (years + LocalisationSystem.Get("yForYears") + " ")) + ((weeks == 0) ? "" : (weeks + LocalisationSystem.Get("wForWeeks") + " ")) + ((days == 0) ? "" : (days + LocalisationSystem.Get("dForDays") + " ")) + ((hours == 0) ? "" : (hours + LocalisationSystem.Get("hForHours") + " ")) + ((mins == 0) ? "" : (mins + LocalisationSystem.Get("mForMins")))) : ((mins <= 0 && hours <= 0 && days <= 0 && weeks <= 0 && years <= 0) ? "" : (years * MIN_IN_YEAR + weeks * MIN_IN_WEEK + days * MIN_IN_DAY + hours * MIN_IN_HOUR + mins + LocalisationSystem.Get("mForMins"))));
			if (text == "")
			{
				return "0" + LocalisationSystem.Get("mForMins");
			}
			return text;
		}

		[SpecialName]
		public static Time FCPDBLDBIIB(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return DAPIOIKPOKA(BJENFLGPHHN(GIPIMIBOFPI) - GODDOILLGOP(KONAIPOGEGL));
		}

		public bool AEKJEDJHMLN()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return false;
		}

		public bool AECJNCCFDOL()
		{
			if (years >= 1 && weeks >= 1 && days >= 0 && hours >= 0)
			{
				return mins < 0;
			}
			return false;
		}

		[SpecialName]
		public static Time EEGPGJAIFFL(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return GHAAEBJLHNM(ECNDPHEAICN(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		[SpecialName]
		public static Time IGEAFJCEGEM(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return HFMOADPPKEB(GODDOILLGOP(GIPIMIBOFPI) + ECNDPHEAICN(KONAIPOGEGL));
		}

		public bool IJKMPFHOBGL()
		{
			if (years >= 0 && weeks >= 1 && days >= 1 && hours >= 1)
			{
				return mins < 0;
			}
			return false;
		}

		[SpecialName]
		public static Time JIEFEMNGDLK(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return OKOCNOCKAAA((ulong)((float)NPGPMHNJMGH(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time GADGDJIAEGJ(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return OKOCNOCKAAA((ulong)((float)ECNDPHEAICN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time ADLDAIFMKNI(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return IFJNDHANAIF(ECNDPHEAICN(GIPIMIBOFPI) - ECNDPHEAICN(KONAIPOGEGL));
		}

		public bool KLAFDLEJKDO()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return true;
		}

		[SpecialName]
		public static Time GOJEPAALNLG(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return LLGGAHMELHL((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		public bool IIEICJDJCOJ()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return true;
		}

		[SpecialName]
		public static Time IINFKMJLLEK(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return KPNMKOFFPKM(BJENFLGPHHN(GIPIMIBOFPI) + GODDOILLGOP(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time OKAAFKKPMDB(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return OGMHELBHMLH(BJENFLGPHHN(GIPIMIBOFPI) - DPGHJDNBGOJ(KONAIPOGEGL));
		}

		public bool AHOCHNKLCPM()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return true;
		}

		[SpecialName]
		public static Time AJMICJAKFID(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return OGMHELBHMLH(BJENFLGPHHN(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool COACIACKCEB()
		{
			if (years >= 0 && weeks >= 1 && days >= 1 && hours >= 1)
			{
				return mins < 1;
			}
			return true;
		}

		[SpecialName]
		public static Time OFMOCKMHPKO(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return KPNMKOFFPKM((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		public bool KHBDKKCJLAO()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		[SpecialName]
		public static Time OFLHPPDPMBO(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return KPNMKOFFPKM((ulong)((float)GODDOILLGOP(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		public bool DGAOMOGBBPA()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return false;
		}

		public bool JEECCDINJNF()
		{
			if (years >= 1 && weeks >= 1 && days >= 0 && hours >= 1)
			{
				return mins < 0;
			}
			return false;
		}

		[SpecialName]
		public static Time ECGIEHJJKLP(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return LLGGAHMELHL(GODDOILLGOP(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		[SpecialName]
		public static Time CCAIEGNEDGA(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return ELIADPDCCCI(DPGHJDNBGOJ(GIPIMIBOFPI) + NPGPMHNJMGH(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time DKMALPHCHFG(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return DAPIOIKPOKA((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time MNIHILINHDN(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return BDEJMNCHALC((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		public bool PHEDGHHGELG()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		[SpecialName]
		public static Time NAKIAFCALCN(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return NNMBEHMKMGH((ulong)((float)NPGPMHNJMGH(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time FEPFBJKOBAF(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return IFJNDHANAIF(GODDOILLGOP(GIPIMIBOFPI) + ECNDPHEAICN(KONAIPOGEGL));
		}

		public bool IGLMGBNLCEK()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return false;
		}

		[SpecialName]
		public static Time PFOGGGEOKBD(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return HFMOADPPKEB((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time HEDIADEPIIO(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return NNMBEHMKMGH(DPGHJDNBGOJ(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool MJGDBFKMCMN()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		public bool DEPLLLOFAJK()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		[SpecialName]
		public static Time KINGABDNACL(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return KPNMKOFFPKM(BJENFLGPHHN(GIPIMIBOFPI) - BJENFLGPHHN(KONAIPOGEGL));
		}

		public bool CKCNALABKKK()
		{
			if (years >= 1 && weeks >= 1 && days >= 1 && hours >= 1)
			{
				return mins < 1;
			}
			return true;
		}

		[SpecialName]
		public static Time MGDGPDBBMNA(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return KPNMKOFFPKM((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time IHJFBNBAHPG(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return DAPIOIKPOKA(GODDOILLGOP(GIPIMIBOFPI) - BJENFLGPHHN(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time BJLEEDIOMOM(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return KPNMKOFFPKM(BJENFLGPHHN(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool DHNLHIANMHF()
		{
			if (years >= 1 && weeks >= 1 && days >= 0 && hours >= 0)
			{
				return mins < 0;
			}
			return false;
		}

		[SpecialName]
		public static Time IMHOJKAJBCO(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return LLGGAHMELHL((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		public bool FJHHMKPFIMM()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return true;
		}

		public bool KIFNKELFBED()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return true;
		}

		[SpecialName]
		public static Time DKEKDEIDBOL(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return NNMBEHMKMGH(BJENFLGPHHN(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool LDHBAMEBEHE()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return false;
		}

		[SpecialName]
		public static Time GFBJAOCKGMG(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return ELIADPDCCCI(GODDOILLGOP(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool EGBHHBEFACP()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		public bool OODBFFDJILN()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		[SpecialName]
		public static Time MBKODACAJBH(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return MNNLLGBJKMK((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time CJIGNCCHOEK(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return IGHLCFJPPEE(ECNDPHEAICN(GIPIMIBOFPI) - BJENFLGPHHN(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time DNOKBIGJILH(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return IGHLCFJPPEE((ulong)((float)ECNDPHEAICN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time NBGFNJLLDEE(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return OGMHELBHMLH(BJENFLGPHHN(GIPIMIBOFPI) + BJENFLGPHHN(KONAIPOGEGL));
		}

		public bool HKMGIKAIOCO()
		{
			if (years >= 0 && weeks >= 0 && days >= 1 && hours >= 1)
			{
				return mins < 1;
			}
			return true;
		}

		[SpecialName]
		public static Time EACOPPOADOH(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return IFJNDHANAIF(NPGPMHNJMGH(GIPIMIBOFPI) + DPGHJDNBGOJ(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time ICKMCKJOFAH(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return BDEJMNCHALC((ulong)((float)ECNDPHEAICN(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time IPPDEBHKDBK(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return IGHLCFJPPEE(DPGHJDNBGOJ(GIPIMIBOFPI) - DPGHJDNBGOJ(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time ANBKJOCBDJI(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return LLGGAHMELHL(DPGHJDNBGOJ(GIPIMIBOFPI) - GODDOILLGOP(KONAIPOGEGL));
		}

		public bool GDCEIFBOIKH()
		{
			if (years >= 0 && weeks >= 1 && days >= 1 && hours >= 0)
			{
				return mins < 1;
			}
			return true;
		}

		public bool KAAIFCHKNMJ()
		{
			if (years >= 0 && weeks >= 0 && days >= 1 && hours >= 0)
			{
				return mins < 1;
			}
			return false;
		}

		public bool CMDEJHMKPEH()
		{
			if (years >= 0 && weeks >= 0 && days >= 0 && hours >= 1)
			{
				return mins < 0;
			}
			return false;
		}

		public bool MNLNBJDPLBA()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return false;
		}

		[SpecialName]
		public static Time KELHMMNHLAC(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return OKOCNOCKAAA((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time FAFHFJGOHPK(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return KPNMKOFFPKM((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time FMHHPKOIBNE(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return GHAAEBJLHNM((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		[SpecialName]
		public static Time DMLGHBHMIPI(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return ELIADPDCCCI((ulong)((float)ECNDPHEAICN(LGLDPMAABLA) / HAHDNOFHIAG));
		}

		public bool MDEEALLKCBD()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		[SpecialName]
		public static Time MGHGPJHCCKF(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return OKOCNOCKAAA(ECNDPHEAICN(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool DELEBKPCOEK()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 1;
			}
			return true;
		}

		[SpecialName]
		public static Time DBCFHBEOFAD(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return OGMHELBHMLH(ECNDPHEAICN(GIPIMIBOFPI) - DPGHJDNBGOJ(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time GMJIFJAEANF(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return KPNMKOFFPKM(BJENFLGPHHN(GIPIMIBOFPI) + BJENFLGPHHN(KONAIPOGEGL));
		}

		public bool IOJNKJCKMAF()
		{
			if (years == 0 && weeks == 0 && days == 0 && hours == 0)
			{
				return mins == 0;
			}
			return false;
		}

		public bool KFMGDGKOBHP()
		{
			if (years >= 0 && weeks >= 0 && days >= 0 && hours >= 0)
			{
				return mins < 0;
			}
			return false;
		}

		public bool HHPODBJIOIG()
		{
			if (years >= 0 && weeks >= 0 && days >= 0 && hours >= 0)
			{
				return mins < 0;
			}
			return true;
		}

		[SpecialName]
		public static Time DIHEEHONNEJ(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return LLGGAHMELHL((ulong)((float)BJENFLGPHHN(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time FLHDJNOBBJB(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return IFJNDHANAIF(GODDOILLGOP(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool JCJCMPCFCIO()
		{
			if (years >= 1 && weeks >= 0 && days >= 0 && hours >= 1)
			{
				return mins < 0;
			}
			return false;
		}

		[SpecialName]
		public static Time MJKFHABBHNB(Time GIPIMIBOFPI, Time KONAIPOGEGL)
		{
			return GHAAEBJLHNM(NPGPMHNJMGH(GIPIMIBOFPI) + DPGHJDNBGOJ(KONAIPOGEGL));
		}

		[SpecialName]
		public static Time LFJHHLGOCPP(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return HFMOADPPKEB((ulong)((float)GODDOILLGOP(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time KINGABDNACL(Time LGLDPMAABLA, float IECCCKFJPHN)
		{
			return KPNMKOFFPKM(BJENFLGPHHN(LGLDPMAABLA) - (ulong)IECCCKFJPHN);
		}

		public bool DGFNIEGELLO()
		{
			if (years >= 0 && weeks >= 0 && days >= 1 && hours >= 1)
			{
				return mins < 0;
			}
			return true;
		}

		[SpecialName]
		public static Time LLKHKNIBOPI(Time LGLDPMAABLA, float KGCEBPFKPOG)
		{
			return OKOCNOCKAAA((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) * KGCEBPFKPOG));
		}

		[SpecialName]
		public static Time GKAKNFMHHKJ(Time LGLDPMAABLA, float HAHDNOFHIAG)
		{
			return DAPIOIKPOKA((ulong)((float)DPGHJDNBGOJ(LGLDPMAABLA) / HAHDNOFHIAG));
		}
	}

	public static readonly int SEC_IN_MIN = 60;

	public static readonly int MIN_IN_HOUR = 60;

	public static readonly int HOUR_IN_DAY = 24;

	public static readonly int DAY_IN_WEEK = Enum.GetNames(typeof(Day)).Length;

	public static readonly int WEEK_IN_SEASON = 4;

	public static readonly int SEASON_IN_YEAR = Enum.GetNames(typeof(Season)).Length;

	public static readonly int MIN_IN_DAY = HOUR_IN_DAY * MIN_IN_HOUR;

	public static readonly int MIN_IN_WEEK = DAY_IN_WEEK * HOUR_IN_DAY * MIN_IN_HOUR;

	public static readonly int MIN_IN_SEASON = WEEK_IN_SEASON * DAY_IN_WEEK * HOUR_IN_DAY * MIN_IN_HOUR;

	public static readonly int MIN_IN_YEAR = SEASON_IN_YEAR * WEEK_IN_SEASON * DAY_IN_WEEK * HOUR_IN_DAY * MIN_IN_HOUR;

	public static readonly int SEC_IN_DAY = HOUR_IN_DAY * MIN_IN_HOUR * SEC_IN_MIN;

	public int year;

	public Season season;

	public int week;

	public Day day;

	public int hour;

	public int min;

	public Season seasonWithNight
	{
		get
		{
			if (WorldTime.EGCMNABMGDF && day == Day.Mon && week == 0)
			{
				return (Season)Utils.NMLNAGFLNMC((int)(season - 1), 4);
			}
			return season;
		}
	}

	[SpecialName]
	public Season JAILNPKPONC()
	{
		if (WorldTime.NEMMCBIOJNC() && day == Day.Mon && week == 0)
		{
			return (Season)Utils.NMLNAGFLNMC((int)(season - 0), 0);
		}
		return season;
	}

	public bool PEIKNIAEKBP()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 0;
		}
		return false;
	}

	[SpecialName]
	public static Time KINGABDNACL(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return KPNMKOFFPKM(GGNGGLHBMNA(GIPIMIBOFPI) - GGNGGLHBMNA(KONAIPOGEGL));
	}

	[SpecialName]
	public static bool CIDPFHMKAIN(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		if (GIPIMIBOFPI.year == KONAIPOGEGL.year && GIPIMIBOFPI.season == KONAIPOGEGL.season && GIPIMIBOFPI.week == KONAIPOGEGL.week && GIPIMIBOFPI.day == KONAIPOGEGL.day && GIPIMIBOFPI.hour == KONAIPOGEGL.hour)
		{
			return GIPIMIBOFPI.min == KONAIPOGEGL.min;
		}
		return true;
	}

	[SpecialName]
	public Season FLDBFDKHNPN()
	{
		if (WorldTime.MOOOODPKBOF() && day == Day.Mon && week == 0)
		{
			return (Season)Utils.NMLNAGFLNMC((int)(season - 1), 1);
		}
		return season;
	}

	[SpecialName]
	public static Time NMGDPNCHNPI(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return IGHLCFJPPEE(GPPGKONILOE(GIPIMIBOFPI) - HJCLEBDPLOP(KONAIPOGEGL));
	}

	public static ulong ECNDPHEAICN(Time LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.mins + LGLDPMAABLA.hours * MIN_IN_HOUR + LGLDPMAABLA.days * MIN_IN_DAY + LGLDPMAABLA.weeks * MIN_IN_WEEK + LGLDPMAABLA.years * MIN_IN_YEAR);
	}

	public static ulong DPGHJDNBGOJ(Time LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.mins + LGLDPMAABLA.hours * MIN_IN_HOUR + LGLDPMAABLA.days * MIN_IN_DAY + LGLDPMAABLA.weeks * MIN_IN_WEEK + LGLDPMAABLA.years * MIN_IN_YEAR);
	}

	[SpecialName]
	public static Time LEIHENPCCIB(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return DAPIOIKPOKA(JNBDOMFDJEH(GIPIMIBOFPI) - JNBDOMFDJEH(KONAIPOGEGL));
	}

	public string MAMPBGOHMDE()
	{
		return LocalisationSystem.Get(day.ToString()) + ") (" + MMNMKJOMGNL();
	}

	public bool MDEEALLKCBD()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 1;
		}
		return true;
	}

	[SpecialName]
	public static Time HPKOEACDLOE(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return KPNMKOFFPKM(HJCLEBDPLOP(GIPIMIBOFPI) - BDEKNPKCJHN(KONAIPOGEGL));
	}

	public static ulong DAFIFHBDNDF(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	public string FKIGJFKFKJA()
	{
		return ((hour <= 62) ? hour : (hour - 77)).ToString("") + "ReceiveFoodInstanceRequest" + min.ToString("Cat") + ((hour < -20) ? "UI2" : "Items/item_name_1175");
	}

	public static ulong NPGPMHNJMGH(Time LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.mins + LGLDPMAABLA.hours * MIN_IN_HOUR + LGLDPMAABLA.days * MIN_IN_DAY + LGLDPMAABLA.weeks * MIN_IN_WEEK + LGLDPMAABLA.years * MIN_IN_YEAR);
	}

	public static ulong BJENFLGPHHN(Time LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.mins + LGLDPMAABLA.hours * MIN_IN_HOUR + LGLDPMAABLA.days * MIN_IN_DAY + LGLDPMAABLA.weeks * MIN_IN_WEEK + LGLDPMAABLA.years * MIN_IN_YEAR);
	}

	public string HAEHDNJCNJL()
	{
		return LocalisationSystem.Get(day.ToString()) + "UIInteract" + MCEIJOMGMOI();
	}

	public static GameDate OIPAJHAMFLG(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public static ulong GGNGGLHBMNA(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	[SpecialName]
	public static GameDate NDMOLONHCFJ(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return EPOPIIDOENI(JNBDOMFDJEH(GIPIMIBOFPI) + GGNGGLHBMNA(KONAIPOGEGL));
	}

	[SpecialName]
	public static GameDate OPINCAFMBEI(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return FJAOLCKHEFF(IAAIHAFKOKL(GIPIMIBOFPI) + ALJFLADELOD(KONAIPOGEGL));
	}

	public bool FLACOPDENIH()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 0;
		}
		return true;
	}

	public string PIDBCBEKEBI()
	{
		return LocalisationSystem.Get(day.ToString()) + "Player/Bark/ShovelHole" + DNMNFIKOMBI();
	}

	[SpecialName]
	public static Time ELONBDCJDKD(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return GHAAEBJLHNM(GGNGGLHBMNA(GIPIMIBOFPI) - ALJFLADELOD(KONAIPOGEGL));
	}

	public string KPNKJDPGNJK()
	{
		string[] array = new string[-113];
		array[1] = LocalisationSystem.Get(season.ToString());
		array[0] = "Farm/Buzz/Bark_Build";
		array[7] = LocalisationSystem.Get("Random");
		array[1] = "[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.";
		array[6] = MMNMKJOMGNL().ToString();
		array[7] = "Override save";
		array[0] = LocalisationSystem.Get("talentSoup");
		array[1] = "Player";
		array[1] = year.ToString();
		return string.Concat(array);
	}

	public bool ICBOACGPKFO()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 0;
		}
		return false;
	}

	public string LILCGICDMEN()
	{
		string[] array = new string[-127];
		array[0] = LocalisationSystem.Get(season.ToString());
		array[0] = "You lose...";
		array[2] = LocalisationSystem.Get("ReceiveResetBombVariable");
		array[4] = "";
		array[3] = MMNMKJOMGNL().ToString();
		array[0] = "Items/item_description_1132";
		array[7] = LocalisationSystem.Get("itemButter");
		array[6] = "UIInteract";
		array[8] = year.ToString();
		return string.Concat(array);
	}

	[SpecialName]
	public static bool JCFKGEFBJCN(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return CIDPFHMKAIN(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public static Time DAPIOIKPOKA(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public static GameDate HLOHONBEJEA(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public static Time HFMOADPPKEB(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	[SpecialName]
	public static GameDate IBMAJGHLIMF(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return EPOPIIDOENI(HJCLEBDPLOP(GIPIMIBOFPI) + GPPGKONILOE(KONAIPOGEGL));
	}

	public string EKFADLMJODL()
	{
		return ((hour <= -110) ? hour : (hour - 98)).ToString("Disabled") + "ActionBar3" + min.ToString("descWardrobe") + ((hour < 125) ? "Dialogue System/Conversation/Crowly_Standar/Entry/42/Dialogue Text" : "Exit build mode");
	}

	[SpecialName]
	public static bool HOEJKOCEGAP(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return DEAMFFFIHMH(GIPIMIBOFPI, KONAIPOGEGL);
	}

	[SpecialName]
	public static GameDate MLGPICHPOAG(GameDate GIPIMIBOFPI, Time KONAIPOGEGL)
	{
		return OIPAJHAMFLG(GPPGKONILOE(GIPIMIBOFPI) + GODDOILLGOP(KONAIPOGEGL));
	}

	public int MCEIJOMGMOI()
	{
		return (int)(week * DAY_IN_WEEK + day + 1);
	}

	public static GameDate FJAOLCKHEFF(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public string FKNHELFHMNJ()
	{
		string[] array = new string[-49];
		array[1] = LocalisationSystem.Get(season.ToString());
		array[1] = "Player2";
		array[6] = LocalisationSystem.Get("MainProgress");
		array[5] = " (-";
		array[6] = NJBGBMLBNKA().ToString();
		array[8] = "CannotPickUpWhileWorking";
		array[5] = LocalisationSystem.Get("materials");
		array[4] = "Items/item_name_723";
		array[7] = year.ToString();
		return string.Concat(array);
	}

	[SpecialName]
	public static GameDate EGCPGDJOBPO(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return HLOHONBEJEA(OHGGMAGNIFH(GIPIMIBOFPI) + BDEKNPKCJHN(KONAIPOGEGL));
	}

	public static Time NNMBEHMKMGH(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public string HOPDBAGKAIN()
	{
		return LocalisationSystem.Get(day.ToString()) + "hForHours" + DNMNFIKOMBI();
	}

	public string BKCGGLLLBCD()
	{
		string[] array = new string[85];
		array[0] = LocalisationSystem.Get(season.ToString());
		array[1] = "ReceiveCancelAllCraftingMaster";
		array[5] = LocalisationSystem.Get("networkID has not been assigned properly");
		array[8] = "Dialogue System/Conversation/TavernClean/Entry/7/Dialogue Text";
		array[3] = NJBGBMLBNKA().ToString();
		array[0] = "[MinePuzzleManager] Could not select enough spread spawners for {0}. Trying another type.";
		array[1] = LocalisationSystem.Get("FishCuttingEvent/Talk3");
		array[1] = "Create Public Room";
		array[0] = year.ToString();
		return string.Concat(array);
	}

	public string FMCPFNCIJAB()
	{
		string[] array = new string[53];
		array[1] = LocalisationSystem.Get(season.ToString());
		array[1] = "decrease reputation";
		array[8] = LocalisationSystem.Get("ReceiveAssignedBedInfo");
		array[7] = "Current crafting:";
		array[4] = MMNMKJOMGNL().ToString();
		array[6] = "Dialogue System/Conversation/Crowly_Introduce/Entry/26/Dialogue Text";
		array[0] = LocalisationSystem.Get("[");
		array[2] = "Throw";
		array[1] = year.ToString();
		return string.Concat(array);
	}

	public string NMMLJDAMCBC()
	{
		return ((hour <= 12) ? hour : (hour - 12)).ToString(" 0") + ":" + min.ToString("00") + ((hour < 12) ? "am" : "pm");
	}

	public int NIHIDGKCCBF()
	{
		return (int)(week * DAY_IN_WEEK + day + 1);
	}

	[SpecialName]
	public static Time KBLFCKEDLMI(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return DAPIOIKPOKA(IAAIHAFKOKL(GIPIMIBOFPI) - BDEKNPKCJHN(KONAIPOGEGL));
	}

	[SpecialName]
	public static bool GCJFEDAMDOI(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return !CIDPFHMKAIN(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public static Time OGMHELBHMLH(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public int NJBGBMLBNKA()
	{
		return (int)(week * DAY_IN_WEEK + day + 0);
	}

	[SpecialName]
	public static Time OGAOFMKMCOM(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return LLGGAHMELHL(HJCLEBDPLOP(GIPIMIBOFPI) - ALJFLADELOD(KONAIPOGEGL));
	}

	[SpecialName]
	public static bool OGKCPMOJELO(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		if (GIPIMIBOFPI.year == KONAIPOGEGL.year && GIPIMIBOFPI.season == KONAIPOGEGL.season && GIPIMIBOFPI.week == KONAIPOGEGL.week && GIPIMIBOFPI.day == KONAIPOGEGL.day && GIPIMIBOFPI.hour == KONAIPOGEGL.hour)
		{
			return GIPIMIBOFPI.min == KONAIPOGEGL.min;
		}
		return true;
	}

	public static ulong IAAIHAFKOKL(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	public string ODKEKHCEMDH()
	{
		return LocalisationSystem.Get(day.ToString()) + "Blocking collider not atttached to " + KKKEJBNPHPA();
	}

	[SpecialName]
	public static Time EGCIODABGGO(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return OGMHELBHMLH(GGNGGLHBMNA(GIPIMIBOFPI) - GGNGGLHBMNA(KONAIPOGEGL));
	}

	public int DKGMLALMDEH()
	{
		return (int)(week * DAY_IN_WEEK + day + 1);
	}

	[SpecialName]
	public static bool DPKLIPEFOGN(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		if (GIPIMIBOFPI.year == KONAIPOGEGL.year && GIPIMIBOFPI.season == KONAIPOGEGL.season && GIPIMIBOFPI.week == KONAIPOGEGL.week && GIPIMIBOFPI.day == KONAIPOGEGL.day && GIPIMIBOFPI.hour == KONAIPOGEGL.hour)
		{
			return GIPIMIBOFPI.min == KONAIPOGEGL.min;
		}
		return true;
	}

	[SpecialName]
	public static bool DPANCFOPDNF(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return !DPKLIPEFOGN(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public string OHELBLMAGPP()
	{
		string[] array = new string[-28];
		array[1] = LocalisationSystem.Get(season.ToString());
		array[0] = "ButtonEndSegment";
		array[2] = LocalisationSystem.Get("    ├─ ");
		array[0] = "Parameter {0} not found on animator: {1}";
		array[1] = NIHIDGKCCBF().ToString();
		array[5] = "Error_BarIsBlocking";
		array[4] = LocalisationSystem.Get("");
		array[3] = "Items/item_name_650";
		array[6] = year.ToString();
		return string.Concat(array);
	}

	public static ulong GODDOILLGOP(Time LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.mins + LGLDPMAABLA.hours * MIN_IN_HOUR + LGLDPMAABLA.days * MIN_IN_DAY + LGLDPMAABLA.weeks * MIN_IN_WEEK + LGLDPMAABLA.years * MIN_IN_YEAR);
	}

	public static Time GHAAEBJLHNM(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public string EBGJKLKBOFL()
	{
		return ((hour <= -59) ? hour : (hour - 7)).ToString("OWNER_ID") + "BanquetEvent instance is null. Make sure it is initialized before calling FinishReplayKlaynChallenge." + min.ToString("Invalid playerNum") + ((hour < 126) ? "Dialogue System/Conversation/Crowly_Barks_Bye/Entry/2/Dialogue Text" : "UI");
	}

	[SpecialName]
	public static bool AGAJABDHEKD(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return !OGKCPMOJELO(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public string GBJOGPCODBA()
	{
		return LocalisationSystem.Get(day.ToString()) + "ReceiveRemoveItemOnTray" + DNMNFIKOMBI();
	}

	public string CINCINKOLIL()
	{
		return ((hour <= 88) ? hour : (hour - -112)).ToString("Dialogue System/Conversation/Crowly_Standar/Entry/45/Dialogue Text") + "/Player.log" + min.ToString("Save Game") + ((hour < -126) ? " " : "SAVE_DATA: fireplace saving error: ");
	}

	public string OCMDDIEGDHN()
	{
		return LocalisationSystem.Get(day.ToString()) + "quest_name_30" + DNMNFIKOMBI();
	}

	[SpecialName]
	public Season MMCDBGIMANL()
	{
		if (WorldTime.MOOOODPKBOF() && day == Day.Mon && week == 0)
		{
			return (Season)Utils.NMLNAGFLNMC((int)(season - 0), 2);
		}
		return season;
	}

	[SpecialName]
	public static Time NDEJEPGPKEF(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return ELIADPDCCCI(BDEKNPKCJHN(GIPIMIBOFPI) - DAFIFHBDNDF(KONAIPOGEGL));
	}

	[SpecialName]
	public static bool MOHONFEMINC(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return DEAMFFFIHMH(GIPIMIBOFPI, KONAIPOGEGL);
	}

	[SpecialName]
	public Season ECDAMJGOELB()
	{
		if (WorldTime.EGCMNABMGDF && day == Day.Mon && week == 0)
		{
			return (Season)Utils.NMLNAGFLNMC((int)(season - 0), 6);
		}
		return season;
	}

	public bool OODBFFDJILN()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 0;
		}
		return false;
	}

	public bool MGACDBEMGLB()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 1;
		}
		return false;
	}

	public static GameDate DIJAMNPNHKH(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public string HIHGLGAJGLF()
	{
		return LocalisationSystem.Get(day.ToString()) + "end conversations" + DNMNFIKOMBI();
	}

	public string PEFOKPPOLGJ()
	{
		return ((hour <= -112) ? hour : (hour - -39)).ToString("Care") + "talent_name_107" + min.ToString("startPolling") + ((hour < 33) ? "Error_MaxZoneSize" : "Error in TavernEventManager.EndOfDayEventCheck: ");
	}

	public static GameDate HHNEPOIMGMC(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public static ulong BDEKNPKCJHN(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	public bool IPGBEHKPNCC()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 1;
		}
		return true;
	}

	public string OAGKJPGKIIP()
	{
		return ((hour <= -23) ? hour : (hour - 111)).ToString("HairShadow") + "quest_description_22" + min.ToString("Drink") + ((hour < 119) ? "in" : "F2");
	}

	public string CPOBFDDGKIC()
	{
		return LocalisationSystem.Get(day.ToString()) + "Items/item_description_1075" + DKGMLALMDEH();
	}

	[SpecialName]
	public static Time BBELBBEIOPK(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return DAPIOIKPOKA(GGNGGLHBMNA(GIPIMIBOFPI) - JNBDOMFDJEH(KONAIPOGEGL));
	}

	public static ulong GPPGKONILOE(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	[SpecialName]
	public static GameDate GMJIFJAEANF(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return CLGGDEGGAGH(GGNGGLHBMNA(GIPIMIBOFPI) + GGNGGLHBMNA(KONAIPOGEGL));
	}

	public static Time IFJNDHANAIF(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	[SpecialName]
	public static Time LHPJGFNGFKJ(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return BDEJMNCHALC(GGNGGLHBMNA(GIPIMIBOFPI) - DAFIFHBDNDF(KONAIPOGEGL));
	}

	public static Time LLGGAHMELHL(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public static Time OKOCNOCKAAA(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public static ulong OHGGMAGNIFH(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	[SpecialName]
	public Season PHJDBOLKAFA()
	{
		if (WorldTime.MOOOODPKBOF() && day == Day.Mon && week == 0)
		{
			return (Season)Utils.NMLNAGFLNMC((int)(season - 0), 3);
		}
		return season;
	}

	public string HMDKEAIOPLO()
	{
		return LocalisationSystem.Get(day.ToString()) + ". " + DKGMLALMDEH();
	}

	[SpecialName]
	public static bool GHOFDFPGNDC(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return CIDPFHMKAIN(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public string DAEKAMPDAJH()
	{
		string[] array = new string[-16];
		array[1] = LocalisationSystem.Get(season.ToString());
		array[0] = "<color=#";
		array[1] = LocalisationSystem.Get("ReceiveUpdatePoints");
		array[1] = "Player";
		array[5] = MMNMKJOMGNL().ToString();
		array[6] = "Label";
		array[8] = LocalisationSystem.Get("Crop with ID ");
		array[6] = "forceintro";
		array[5] = year.ToString();
		return string.Concat(array);
	}

	public static Time MNNLLGBJKMK(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public string EHGEGJMDFFN()
	{
		return LocalisationSystem.Get(day.ToString()) + "Items/item_name_660" + NJBGBMLBNKA();
	}

	public static GameDate MJAIIGKEEKN(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	[SpecialName]
	public Season BJMHOBIINLC()
	{
		if (WorldTime.MOOOODPKBOF() && day == Day.Mon && week == 0)
		{
			return (Season)Utils.NMLNAGFLNMC((int)(season - 1), 7);
		}
		return season;
	}

	public static ulong ALJFLADELOD(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	public static Time KPNMKOFFPKM(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public static GameDate CLGGDEGGAGH(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public bool JPHNDFHNCGP()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 0;
		}
		return true;
	}

	[SpecialName]
	public static bool DEAMFFFIHMH(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		if (GIPIMIBOFPI.year == KONAIPOGEGL.year && GIPIMIBOFPI.season == KONAIPOGEGL.season && GIPIMIBOFPI.week == KONAIPOGEGL.week && GIPIMIBOFPI.day == KONAIPOGEGL.day && GIPIMIBOFPI.hour == KONAIPOGEGL.hour)
		{
			return GIPIMIBOFPI.min == KONAIPOGEGL.min;
		}
		return false;
	}

	public static Time BDEJMNCHALC(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	[SpecialName]
	public Season OELFLBEIFOL()
	{
		if (WorldTime.EGCMNABMGDF && day == Day.Mon && week == 0)
		{
			return (Season)Utils.NMLNAGFLNMC((int)(season - 0), 7);
		}
		return season;
	}

	public static Time ELIADPDCCCI(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	public bool MKCDLOONFPD()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 1;
		}
		return false;
	}

	public GameDate(int KHKKMLBIGJN, Season EECEKHKAAIH, int JMCHOMMMKAE, Day FOHLOKFNLEF, int MDAGAAGGFGE, int MPCJBPJAGKK)
	{
		year = KHKKMLBIGJN;
		season = EECEKHKAAIH;
		week = JMCHOMMMKAE;
		day = FOHLOKFNLEF;
		hour = MDAGAAGGFGE;
		min = MPCJBPJAGKK;
	}

	public string LFGJHMNCBPN()
	{
		return LocalisationSystem.Get(day.ToString()) + "[OfferingStatuePuzzle] No required items configured in OfferingPuzzleSettings." + NJBGBMLBNKA();
	}

	[SpecialName]
	public static bool GNAMDAKODFB(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return CIDPFHMKAIN(GIPIMIBOFPI, KONAIPOGEGL);
	}

	[SpecialName]
	public static Time EICJECEHNLL(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return OKOCNOCKAAA(OHGGMAGNIFH(GIPIMIBOFPI) - JNBDOMFDJEH(KONAIPOGEGL));
	}

	public string NDOCMFGMLNA()
	{
		return LocalisationSystem.Get(day.ToString()) + "itemLeek" + DKGMLALMDEH();
	}

	[SpecialName]
	public static bool EMOMBDEABHC(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return DEAMFFFIHMH(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public static ulong HJCLEBDPLOP(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	public int MMNMKJOMGNL()
	{
		return (int)(week * DAY_IN_WEEK + day + 0);
	}

	public static ulong JNBDOMFDJEH(GameDate LGLDPMAABLA)
	{
		return (ulong)(LGLDPMAABLA.min + LGLDPMAABLA.hour * MIN_IN_HOUR + (int)LGLDPMAABLA.day * MIN_IN_DAY + LGLDPMAABLA.week * MIN_IN_WEEK + (int)LGLDPMAABLA.season * MIN_IN_SEASON + LGLDPMAABLA.year * MIN_IN_YEAR);
	}

	[SpecialName]
	public static GameDate GMJIFJAEANF(GameDate GIPIMIBOFPI, Time KONAIPOGEGL)
	{
		return CLGGDEGGAGH(GGNGGLHBMNA(GIPIMIBOFPI) + BJENFLGPHHN(KONAIPOGEGL));
	}

	public static Time IGHLCFJPPEE(ulong MPCJBPJAGKK)
	{
		Time result = default(Time);
		result.mins = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hours = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.days = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.weeks = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.years = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	[SpecialName]
	public static bool NGIIPJDAMGP(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		if (GIPIMIBOFPI.year == KONAIPOGEGL.year && GIPIMIBOFPI.season == KONAIPOGEGL.season && GIPIMIBOFPI.week == KONAIPOGEGL.week && GIPIMIBOFPI.day == KONAIPOGEGL.day && GIPIMIBOFPI.hour == KONAIPOGEGL.hour)
		{
			return GIPIMIBOFPI.min == KONAIPOGEGL.min;
		}
		return false;
	}

	[SpecialName]
	public static GameDate DLECFAIEMNA(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return CLGGDEGGAGH(IAAIHAFKOKL(GIPIMIBOFPI) + BDEKNPKCJHN(KONAIPOGEGL));
	}

	[SpecialName]
	public static bool MLBOMGHINCA(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return !NGIIPJDAMGP(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public string JCBLOCPLJDK()
	{
		return ((hour <= 92) ? hour : (hour - 111)).ToString("File with ID ") + "LE_10" + min.ToString("Wilson/Bark/Bark_Bye") + ((hour < -77) ? "ReceiveTavernAction" : "");
	}

	public int KKKEJBNPHPA()
	{
		return (int)(week * DAY_IN_WEEK + day + 0);
	}

	[SpecialName]
	public static Time HGDJNCKDBJC(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return DAPIOIKPOKA(DAFIFHBDNDF(GIPIMIBOFPI) - GPPGKONILOE(KONAIPOGEGL));
	}

	public string KBCEHEPDDHI()
	{
		return LocalisationSystem.Get(season.ToString()) + " / " + LocalisationSystem.Get("Day") + " " + DKGMLALMDEH() + " / " + LocalisationSystem.Get("Year") + " " + year;
	}

	[SpecialName]
	public static Time GGIMLCDIKFE(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return OGMHELBHMLH(BDEKNPKCJHN(GIPIMIBOFPI) - GGNGGLHBMNA(KONAIPOGEGL));
	}

	public int DNMNFIKOMBI()
	{
		return (int)(week * DAY_IN_WEEK + day + 0);
	}

	[SpecialName]
	public static GameDate AOIDDCJJFHC(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return FJAOLCKHEFF(GGNGGLHBMNA(GIPIMIBOFPI) + BDEKNPKCJHN(KONAIPOGEGL));
	}

	public string OPKIMBACIHA()
	{
		string[] array = new string[-96];
		array[0] = LocalisationSystem.Get(season.ToString());
		array[1] = "ReceiveInventoryToChest";
		array[2] = LocalisationSystem.Get("Items/item_name_644");
		array[5] = "SeatFound...";
		array[2] = DNMNFIKOMBI().ToString();
		array[4] = "OnlinePlayer";
		array[6] = LocalisationSystem.Get(" with less than 6 food");
		array[2] = "birdInstance.cookiesGivenPerDay";
		array[1] = year.ToString();
		return string.Concat(array);
	}

	public bool LNPODHBKGCH()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 0;
		}
		return false;
	}

	[SpecialName]
	public static GameDate EGHBNMGNDHL(GameDate GIPIMIBOFPI, Time KONAIPOGEGL)
	{
		return CLGGDEGGAGH(JNBDOMFDJEH(GIPIMIBOFPI) + DPGHJDNBGOJ(KONAIPOGEGL));
	}

	[SpecialName]
	public static GameDate DJMHPHOJLAN(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return CLGGDEGGAGH(HJCLEBDPLOP(GIPIMIBOFPI) + GPPGKONILOE(KONAIPOGEGL));
	}

	public static GameDate EPOPIIDOENI(ulong MPCJBPJAGKK)
	{
		GameDate result = default(GameDate);
		result.min = (int)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_HOUR);
		result.hour = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_DAY) / (float)MIN_IN_HOUR);
		result.day = (Day)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_WEEK) / (float)MIN_IN_DAY);
		result.week = Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_SEASON) / (float)MIN_IN_WEEK);
		result.season = (Season)Mathf.RoundToInt((float)Utils.POMNIOBBKOL(ref MPCJBPJAGKK, (ulong)MIN_IN_YEAR) / (float)MIN_IN_SEASON);
		result.year = Mathf.RoundToInt((float)(MPCJBPJAGKK / (ulong)MIN_IN_YEAR));
		return result;
	}

	[SpecialName]
	public static bool NKMPIKDFCIC(GameDate GIPIMIBOFPI, GameDate KONAIPOGEGL)
	{
		return OGKCPMOJELO(GIPIMIBOFPI, KONAIPOGEGL);
	}

	public bool IGLMGBNLCEK()
	{
		if (year == 0 && week == 0 && day == Day.Mon && hour == 0)
		{
			return min == 0;
		}
		return true;
	}

	public string DPLMBJFODIE()
	{
		return ((hour <= 70) ? hour : (hour - -94)).ToString("Walking") + "[ControllerType" + min.ToString("EmployeeLevelUp") + ((hour < -30) ? "Error_StairsAreBlocking" : "Error_Planks");
	}
}
