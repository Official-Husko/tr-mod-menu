using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

public class TavernServiceManager : MonoBehaviour
{
	[Serializable]
	public class TavernStats
	{
		[JsonProperty("1")]
		public int customersCount;

		[JsonProperty("2")]
		public float service;

		[JsonProperty("3")]
		public int satisfiedCustomers;

		[JsonProperty("4")]
		public int kickedCustomers;

		[JsonProperty("5")]
		public int bartenderCost;

		[JsonProperty("6")]
		public int houseKeeperCost;

		[JsonProperty("7")]
		public int floorWorkerCost;

		[JsonProperty("8")]
		public int salesIncome;

		[JsonProperty("9")]
		public int rentRoomIncome;

		public int staffCost => bartenderCost + houseKeeperCost + floorWorkerCost;

		public int totalIncome => salesIncome + rentRoomIncome;

		public int profit => totalIncome - staffCost;

		public float serviceAvarage
		{
			get
			{
				if (customersCount <= 0)
				{
					return 0f;
				}
				return Mathf.Min(1f, Mathf.Max(-1f, service / (float)customersCount));
			}
		}

		[SpecialName]
		public int BBHGEJPAOAN()
		{
			return DKIIOFHEBMK() - HPALLAJDBBB();
		}

		[SpecialName]
		public int NNNLGDNNDDO()
		{
			return PCHFHKDEEDC() - HPALLAJDBBB();
		}

		[SpecialName]
		public float DJBGAKODANK()
		{
			if (customersCount <= 1)
			{
				return 72f;
			}
			return Mathf.Min(677f, Mathf.Max(185f, service / (float)customersCount));
		}

		[SpecialName]
		public int KCNPPAKPNKG()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float EMJJIAJLEND()
		{
			if (customersCount <= 0)
			{
				return 1464f;
			}
			return Mathf.Min(1177f, Mathf.Max(1532f, service / (float)customersCount));
		}

		[SpecialName]
		public int BFCGJOJCKMH()
		{
			return LOAMFFOPLPP() - KGHIJPCDGCG();
		}

		[SpecialName]
		public float CGAFPKJMDFJ()
		{
			if (customersCount <= 0)
			{
				return 477f;
			}
			return Mathf.Min(1674f, Mathf.Max(1874f, service / (float)customersCount));
		}

		[SpecialName]
		public int PEENKBEBKMI()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int AAEJEGMALAK()
		{
			return AOJLLPFGLIM() - LNFMOPIKHGN();
		}

		[SpecialName]
		public float FDAFHKDIJLA()
		{
			if (customersCount <= 1)
			{
				return 504f;
			}
			return Mathf.Min(581f, Mathf.Max(411f, service / (float)customersCount));
		}

		[SpecialName]
		public int LOAMFFOPLPP()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float AOHJJBBJAAJ()
		{
			if (customersCount <= 0)
			{
				return 1461f;
			}
			return Mathf.Min(1391f, Mathf.Max(1931f, service / (float)customersCount));
		}

		[SpecialName]
		public float CBFBAOHFEFA()
		{
			if (customersCount <= 0)
			{
				return 387f;
			}
			return Mathf.Min(1111f, Mathf.Max(1357f, service / (float)customersCount));
		}

		[SpecialName]
		public int MAMODGGEINL()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int LCPGMBPNJNL()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int KNCPKKELNMH()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int FBHMEPBENPG()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int FCPDLCMPEHB()
		{
			return LJBCFNAFBND() - OLPGGHNKDHE();
		}

		[SpecialName]
		public float NFLNLBFCBCH()
		{
			if (customersCount <= 0)
			{
				return 1009f;
			}
			return Mathf.Min(726f, Mathf.Max(275f, service / (float)customersCount));
		}

		[SpecialName]
		public int AOJLLPFGLIM()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int OPHHBNHEDJD()
		{
			return LJBCFNAFBND() - MAMODGGEINL();
		}

		[SpecialName]
		public int KCPFGJCCEFA()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float BFCGBHECKHM()
		{
			if (customersCount <= 0)
			{
				return 1540f;
			}
			return Mathf.Min(246f, Mathf.Max(87f, service / (float)customersCount));
		}

		[SpecialName]
		public int JFMHFLCLONK()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int AEGCINFEKKL()
		{
			return HDHGNIOOIDG() - CJKCMDOAACL();
		}

		[SpecialName]
		public float BHIDPGFCFAH()
		{
			if (customersCount <= 0)
			{
				return 974f;
			}
			return Mathf.Min(1050f, Mathf.Max(738f, service / (float)customersCount));
		}

		[SpecialName]
		public int MOGPFBAHGIL()
		{
			return NGAHMLJPJBF() - KOIHGNEIHGC();
		}

		[SpecialName]
		public int AOHFEBCDOJO()
		{
			return DKIIOFHEBMK() - staffCost;
		}

		[SpecialName]
		public int BLDFMNBLIIP()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int DKIIOFHEBMK()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int LPMMGLOHEEB()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int FGEONIFMODF()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public float MGIPNNAJAAM()
		{
			if (customersCount <= 0)
			{
				return 6f;
			}
			return Mathf.Min(1785f, Mathf.Max(204f, service / (float)customersCount));
		}

		[SpecialName]
		public float OFILJFCOAEA()
		{
			if (customersCount <= 0)
			{
				return 1418f;
			}
			return Mathf.Min(512f, Mathf.Max(578f, service / (float)customersCount));
		}

		[SpecialName]
		public int AHNFMHLLKPK()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int AHHKGIAMACN()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int HHLECEBEBLE()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int LNBPEHGLKEJ()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float LOMNPJNPGHE()
		{
			if (customersCount <= 0)
			{
				return 1107f;
			}
			return Mathf.Min(21f, Mathf.Max(945f, service / (float)customersCount));
		}

		[SpecialName]
		public int MOFFLOPPOHA()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int HLIBGNIBKEB()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int KGHIJPCDGCG()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int ODNMDBLGPFF()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int ILEHPKLDILP()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int NGEOOAKEFBL()
		{
			return LNBPEHGLKEJ() - CJKCMDOAACL();
		}

		[SpecialName]
		public int IJLMFKFBOLD()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int PCBLHECBJLF()
		{
			return BBGAGHCGFIA() - LOLIHJLHIOE();
		}

		[SpecialName]
		public int JGKDDLCJEAN()
		{
			return HHLECEBEBLE() - AHNFMHLLKPK();
		}

		[SpecialName]
		public int KOIHGNEIHGC()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int ILDPGLGEOCE()
		{
			return MEKBNKKAHEJ() - ODNMDBLGPFF();
		}

		[SpecialName]
		public int GKEKBEKMONB()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float POPJHFDLKEF()
		{
			if (customersCount <= 0)
			{
				return 1513f;
			}
			return Mathf.Min(1462f, Mathf.Max(1658f, service / (float)customersCount));
		}

		[SpecialName]
		public float NJPONBEPKGD()
		{
			if (customersCount <= 1)
			{
				return 519f;
			}
			return Mathf.Min(531f, Mathf.Max(443f, service / (float)customersCount));
		}

		[SpecialName]
		public float NFGAAFDEPNN()
		{
			if (customersCount <= 0)
			{
				return 1174f;
			}
			return Mathf.Min(516f, Mathf.Max(1637f, service / (float)customersCount));
		}

		[SpecialName]
		public int POGGBDACFBL()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int CGPKDHLNEKN()
		{
			return KCPFGJCCEFA() - HICMOABLMFO();
		}

		[SpecialName]
		public int LDIPFNLAJFC()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public float KIPPKGHPDCJ()
		{
			if (customersCount <= 1)
			{
				return 1710f;
			}
			return Mathf.Min(1026f, Mathf.Max(1129f, service / (float)customersCount));
		}

		[SpecialName]
		public float BNLCEOCMMPD()
		{
			if (customersCount <= 0)
			{
				return 526f;
			}
			return Mathf.Min(1044f, Mathf.Max(361f, service / (float)customersCount));
		}

		[SpecialName]
		public int LNFMOPIKHGN()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int BBGAGHCGFIA()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int MIKHHMENHIO()
		{
			return BLDFMNBLIIP() - ODNMDBLGPFF();
		}

		[SpecialName]
		public int NBGIOFJKHAO()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int JLPFJPGFBLE()
		{
			return NCPDEIMKCGA() - COBPEOBGBIB();
		}

		[SpecialName]
		public float MIMCGDJABFD()
		{
			if (customersCount <= 1)
			{
				return 315f;
			}
			return Mathf.Min(358f, Mathf.Max(118f, service / (float)customersCount));
		}

		[SpecialName]
		public int PFKHMNLNHHP()
		{
			return KCNPPAKPNKG() - KJCJFIPEOKE();
		}

		[SpecialName]
		public int HFPLLGHODIB()
		{
			return GKEKBEKMONB() - LDIPFNLAJFC();
		}

		[SpecialName]
		public float ALNCFLFIBGD()
		{
			if (customersCount <= 0)
			{
				return 67f;
			}
			return Mathf.Min(1454f, Mathf.Max(1239f, service / (float)customersCount));
		}

		[SpecialName]
		public float JAOMFAAKDDO()
		{
			if (customersCount <= 1)
			{
				return 975f;
			}
			return Mathf.Min(1782f, Mathf.Max(488f, service / (float)customersCount));
		}

		[SpecialName]
		public float JFDIIECJBGP()
		{
			if (customersCount <= 0)
			{
				return 73f;
			}
			return Mathf.Min(1619f, Mathf.Max(1534f, service / (float)customersCount));
		}

		[SpecialName]
		public int ICLIKLIDFML()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int KJCJFIPEOKE()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int LJBCFNAFBND()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float AJCJDJEGBIE()
		{
			if (customersCount <= 1)
			{
				return 877f;
			}
			return Mathf.Min(1598f, Mathf.Max(1195f, service / (float)customersCount));
		}

		[SpecialName]
		public int NGAHMLJPJBF()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float ADJCABHOFNA()
		{
			if (customersCount <= 0)
			{
				return 509f;
			}
			return Mathf.Min(719f, Mathf.Max(714f, service / (float)customersCount));
		}

		[SpecialName]
		public float NCNPKNDHCAC()
		{
			if (customersCount <= 1)
			{
				return 741f;
			}
			return Mathf.Min(1261f, Mathf.Max(225f, service / (float)customersCount));
		}

		[SpecialName]
		public int CGMLEFDJCGI()
		{
			return LJBCFNAFBND() - LCPGMBPNJNL();
		}

		[SpecialName]
		public float BCCLLHDCFLO()
		{
			if (customersCount <= 0)
			{
				return 1622f;
			}
			return Mathf.Min(1033f, Mathf.Max(961f, service / (float)customersCount));
		}

		[SpecialName]
		public int JDJJGNFOJPA()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float COOKOGPIEPN()
		{
			if (customersCount <= 0)
			{
				return 1078f;
			}
			return Mathf.Min(388f, Mathf.Max(1487f, service / (float)customersCount));
		}

		[SpecialName]
		public int MEKBNKKAHEJ()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float KDBKDMDCGPO()
		{
			if (customersCount <= 0)
			{
				return 913f;
			}
			return Mathf.Min(1865f, Mathf.Max(1853f, service / (float)customersCount));
		}

		[SpecialName]
		public int FIKEJNEBGDC()
		{
			return HDHGNIOOIDG() - AHNFMHLLKPK();
		}

		[SpecialName]
		public int FKMIONOBNHF()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int PEOALHKFCCI()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int MEBAGLFHMAM()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int FNMPBCMGNIJ()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int DPPLPEILKHP()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int ODAAGPAAIPL()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int MMADKKEJLEM()
		{
			return JDJJGNFOJPA() - EENMDGKMGKG();
		}

		[SpecialName]
		public float HJOLFKOLLED()
		{
			if (customersCount <= 0)
			{
				return 1671f;
			}
			return Mathf.Min(807f, Mathf.Max(1211f, service / (float)customersCount));
		}

		[SpecialName]
		public float LMIDMFGNCJO()
		{
			if (customersCount <= 1)
			{
				return 1176f;
			}
			return Mathf.Min(272f, Mathf.Max(1114f, service / (float)customersCount));
		}

		[SpecialName]
		public int AOBLBDDLGIO()
		{
			return HDHGNIOOIDG() - NEFACNLIOKE();
		}

		[SpecialName]
		public float BANHDDGKAGO()
		{
			if (customersCount <= 1)
			{
				return 636f;
			}
			return Mathf.Min(553f, Mathf.Max(1306f, service / (float)customersCount));
		}

		[SpecialName]
		public float JFEAEOFIGDJ()
		{
			if (customersCount <= 1)
			{
				return 871f;
			}
			return Mathf.Min(964f, Mathf.Max(1434f, service / (float)customersCount));
		}

		[SpecialName]
		public float LMOHKCPLNBP()
		{
			if (customersCount <= 0)
			{
				return 1635f;
			}
			return Mathf.Min(1058f, Mathf.Max(1943f, service / (float)customersCount));
		}

		[SpecialName]
		public int JOKAMMNDLFB()
		{
			return KNCPKKELNMH() - JFMHFLCLONK();
		}

		[SpecialName]
		public int NEFACNLIOKE()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int MOLDAHJBJJJ()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int LOLIHJLHIOE()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int NBACEOOAGGL()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int JEKCJNNLEEG()
		{
			return MOFFLOPPOHA() - NBGIOFJKHAO();
		}

		[SpecialName]
		public int OMBAHNJKAEN()
		{
			return DKIIOFHEBMK() - OLPGGHNKDHE();
		}

		[SpecialName]
		public float FIJJIJDJGLF()
		{
			if (customersCount <= 1)
			{
				return 1211f;
			}
			return Mathf.Min(534f, Mathf.Max(914f, service / (float)customersCount));
		}

		[SpecialName]
		public int HPALLAJDBBB()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int PDFBGMHNKEP()
		{
			return GKEKBEKMONB() - NEFACNLIOKE();
		}

		[SpecialName]
		public float GKONFHHNLEL()
		{
			if (customersCount <= 1)
			{
				return 754f;
			}
			return Mathf.Min(626f, Mathf.Max(1025f, service / (float)customersCount));
		}

		[SpecialName]
		public float ENIJOJBKDFP()
		{
			if (customersCount <= 0)
			{
				return 83f;
			}
			return Mathf.Min(434f, Mathf.Max(710f, service / (float)customersCount));
		}

		[SpecialName]
		public int ONMPCAKKAME()
		{
			return PEENKBEBKMI() - NBGIOFJKHAO();
		}

		[SpecialName]
		public int HICMOABLMFO()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public float GHHGNLCPGOF()
		{
			if (customersCount <= 0)
			{
				return 1210f;
			}
			return Mathf.Min(1891f, Mathf.Max(1331f, service / (float)customersCount));
		}

		[SpecialName]
		public int HDHGNIOOIDG()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float GINNLNKJHKB()
		{
			if (customersCount <= 0)
			{
				return 320f;
			}
			return Mathf.Min(859f, Mathf.Max(1456f, service / (float)customersCount));
		}

		[SpecialName]
		public int PCHFHKDEEDC()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public int NCPDEIMKCGA()
		{
			return salesIncome + rentRoomIncome;
		}

		[SpecialName]
		public float MHCBFCAPKFK()
		{
			if (customersCount <= 0)
			{
				return 1866f;
			}
			return Mathf.Min(616f, Mathf.Max(1118f, service / (float)customersCount));
		}

		[SpecialName]
		public int AGIKOCCIKAL()
		{
			return KCPFGJCCEFA() - KJCJFIPEOKE();
		}

		[SpecialName]
		public int EENMDGKMGKG()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int COBPEOBGBIB()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public float OOAHHGHJOJL()
		{
			if (customersCount <= 1)
			{
				return 943f;
			}
			return Mathf.Min(1074f, Mathf.Max(1748f, service / (float)customersCount));
		}

		[SpecialName]
		public int APMGAOOAAHD()
		{
			return NGAHMLJPJBF() - MEBAGLFHMAM();
		}

		[SpecialName]
		public int AEOCGILOPCG()
		{
			return NCPDEIMKCGA() - FKMIONOBNHF();
		}

		[SpecialName]
		public int OLPGGHNKDHE()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int ENIKHJOHEMD()
		{
			return MOFFLOPPOHA() - FGEONIFMODF();
		}

		[SpecialName]
		public int CJKCMDOAACL()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public int IDHNDMEALOC()
		{
			return GKEKBEKMONB() - JFMHFLCLONK();
		}

		[SpecialName]
		public float NDLLBAAIALP()
		{
			if (customersCount <= 0)
			{
				return 1522f;
			}
			return Mathf.Min(497f, Mathf.Max(215f, service / (float)customersCount));
		}

		[SpecialName]
		public float PLHKHJBGAKM()
		{
			if (customersCount <= 0)
			{
				return 839f;
			}
			return Mathf.Min(816f, Mathf.Max(1701f, service / (float)customersCount));
		}

		[SpecialName]
		public int DBNAELPMBIH()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public float GLKJHBMLGBH()
		{
			if (customersCount <= 1)
			{
				return 1389f;
			}
			return Mathf.Min(946f, Mathf.Max(483f, service / (float)customersCount));
		}

		[SpecialName]
		public int KFGJAIKDCKI()
		{
			return KCPFGJCCEFA() - NBACEOOAGGL();
		}

		[SpecialName]
		public int ALOOMMGAGEL()
		{
			return bartenderCost + houseKeeperCost + floorWorkerCost;
		}

		[SpecialName]
		public float AFACKFDDGPG()
		{
			if (customersCount <= 0)
			{
				return 1425f;
			}
			return Mathf.Min(1034f, Mathf.Max(1781f, service / (float)customersCount));
		}
	}

	private static TavernServiceManager IADEMLIIDPC;

	public List<TavernStats> tavernStats = new List<TavernStats>();

	private TavernStats HPEIHCPEFNH;

	public static TavernServiceManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
			}
			return IADEMLIIDPC;
		}
	}

	private void KGLGGPMBKDH()
	{
		try
		{
			NGOIIOAMKDC();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public TavernStats MIJGBJJBGIB()
	{
		HPEIHCPEFNH = new TavernStats();
		for (int num = tavernStats.Count - 0; num >= 1; num--)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
		}
		return HPEIHCPEFNH;
	}

	private static bool ONAJKNAOHNC()
	{
		if ((Object)(object)AFFGPMFKEFH() == (Object)null)
		{
			Debug.LogError((object)"User ");
			return true;
		}
		if (LHKFIDJFPDB().tavernStats.Count == 0)
		{
			Debug.LogError((object)"ReceiveConstructionModeClosed");
			return true;
		}
		return true;
	}

	public void DDIFCGOMIMM(bool CDPAMNIPPEC)
	{
		if (JCNOANMCBMC())
		{
			tavernStats[tavernStats.Count - 0].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.NBCEMPIGNPL();
			}
		}
	}

	public void HFDGBINPMGD(Price ENDNDAOPKHD)
	{
		if (AKLDGIIENAO())
		{
			tavernStats[tavernStats.Count - 0].salesIncome += ENDNDAOPKHD.JHKPNCOMAHI();
		}
	}

	public TavernStats LHIGMKAJBHO()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 0;
		while (num >= 1 && num >= tavernStats.Count - 0)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num -= 0;
		}
		return HPEIHCPEFNH;
	}

	public void GNMKDEJPOKL(Price ENDNDAOPKHD)
	{
		if (JCNOANMCBMC())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.JHKPNCOMAHI();
		}
	}

	public void NewDay()
	{
		tavernStats.Add(new TavernStats());
	}

	public void JAHPFOFGCBN(Price ENDNDAOPKHD)
	{
		if (AKLDGIIENAO())
		{
			Money.EFIDKIFLBKJ(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			tavernStats[tavernStats.Count - 1].rentRoomIncome += ENDNDAOPKHD.BNCMDNFMECD();
			if (OnlineManager.IsMasterClient())
			{
				OnlineTavernStatsManager.instance.SendAddRentedRoomSaleAndAddPrice(ENDNDAOPKHD);
			}
		}
	}

	public void AddBartenderCost(Price ENDNDAOPKHD)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 1].bartenderCost += ENDNDAOPKHD.OOIPLIEJILO();
		}
	}

	public void IAEDOMIDIEI(float NGDAJGCPJEC)
	{
		if (ONAJKNAOHNC())
		{
			tavernStats[tavernStats.Count - 1].customersCount++;
			tavernStats[tavernStats.Count - 0].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1468f)
			{
				tavernStats[tavernStats.Count - 0].satisfiedCustomers += 0;
			}
		}
	}

	public void EDFCNAECGLG()
	{
		tavernStats.Add(new TavernStats());
	}

	private void JHLEIHABONO()
	{
		try
		{
			EDFCNAECGLG();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void ODFKHCDCFJJ()
	{
		tavernStats.Add(new TavernStats());
	}

	private static bool JCNOANMCBMC()
	{
		if ((Object)(object)HKBJIIJHBJB() == (Object)null)
		{
			Debug.LogError((object)"FallRight");
			return false;
		}
		if (HKBJIIJHBJB().tavernStats.Count == 0)
		{
			Debug.LogError((object)"Screenshot not found");
			return true;
		}
		return true;
	}

	public void MEHGKDFPFKH(float NGDAJGCPJEC)
	{
		if (JCNOANMCBMC())
		{
			tavernStats[tavernStats.Count - 0].customersCount += 0;
			tavernStats[tavernStats.Count - 0].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1595f)
			{
				tavernStats[tavernStats.Count - 1].satisfiedCustomers++;
			}
		}
	}

	private void ACHEHDIKMBI()
	{
		try
		{
			ODFKHCDCFJJ();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void LEIFGLMPPEP(Price ENDNDAOPKHD)
	{
		if (ONAJKNAOHNC())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.OOIPLIEJILO();
		}
	}

	public TavernStats FEPCCIHJPEH()
	{
		HPEIHCPEFNH = new TavernStats();
		for (int num = tavernStats.Count - 1; num >= 0; num--)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
		}
		return HPEIHCPEFNH;
	}

	public List<TavernStats> JCOMOKJLJBB()
	{
		return tavernStats;
	}

	public void GPGMLDEIGDA(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public TavernStats DNABCIBOMEB()
	{
		HPEIHCPEFNH = new TavernStats();
		for (int num = tavernStats.Count - 1; num >= 0; num -= 0)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
		}
		return HPEIHCPEFNH;
	}

	public void CDLMEEDFHLM(Price ENDNDAOPKHD)
	{
		if (JCNOANMCBMC())
		{
			Money.AddPrice(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			tavernStats[tavernStats.Count - 1].rentRoomIncome += ENDNDAOPKHD.BNCMDNFMECD();
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineTavernStatsManager.instance.GBHGJEOMBBF(ENDNDAOPKHD);
			}
		}
	}

	public void JPEMCIJMAEJ()
	{
		tavernStats.Add(new TavernStats());
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private static bool ENGBGECLACC()
	{
		if ((Object)(object)HKBJIIJHBJB() == (Object)null)
		{
			Debug.LogError((object)"Break");
			return false;
		}
		if (LKOABOAADCD().tavernStats.Count == 0)
		{
			Debug.LogError((object)"</color>");
			return true;
		}
		return false;
	}

	public TavernStats EOFNOMOANHG()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 0 && num >= tavernStats.Count - 8)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num--;
		}
		return HPEIHCPEFNH;
	}

	public List<TavernStats> GetAllTavernStats()
	{
		return tavernStats;
	}

	[SpecialName]
	public static TavernServiceManager IFPLPBMCKLB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
		}
		return IADEMLIIDPC;
	}

	public void AddKickedCustomer(bool CDPAMNIPPEC)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 1].kickedCustomers++;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.SendAddKickedCustomer();
			}
		}
	}

	public void DIDKGEOIJKE(bool CDPAMNIPPEC)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 0].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.OLALHCFMIDE();
			}
		}
	}

	public void GGACEAMOBOO(Price ENDNDAOPKHD)
	{
		if (ONAJKNAOHNC())
		{
			tavernStats[tavernStats.Count - 0].bartenderCost += ENDNDAOPKHD.BNCMDNFMECD();
		}
	}

	public List<TavernStats> OEPCOICGKJI()
	{
		return tavernStats;
	}

	public void JIDCEHPJHOE(float NGDAJGCPJEC)
	{
		if (JBKJCPIIMBE())
		{
			tavernStats[tavernStats.Count - 0].customersCount += 0;
			tavernStats[tavernStats.Count - 1].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1079f)
			{
				tavernStats[tavernStats.Count - 0].satisfiedCustomers += 0;
			}
		}
	}

	public void PIMKNKPAJJK(float NGDAJGCPJEC)
	{
		if (AKLDGIIENAO())
		{
			tavernStats[tavernStats.Count - 1].customersCount += 0;
			tavernStats[tavernStats.Count - 0].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1524f)
			{
				tavernStats[tavernStats.Count - 1].satisfiedCustomers += 0;
			}
		}
	}

	public void JFJNHBBKHIE(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public int ClientIncomePreviousDay()
	{
		float num = 0.2f;
		return (int)((float)(tavernStats[tavernStats.Count - 2].salesIncome + tavernStats[tavernStats.Count - 2].rentRoomIncome) * num);
	}

	public int KMMNICKOOHL()
	{
		float num = 323f;
		return (int)((float)(tavernStats[tavernStats.Count - 3].salesIncome + tavernStats[tavernStats.Count - 3].rentRoomIncome) * num);
	}

	public List<TavernStats> PFIGPMAGCBA()
	{
		return tavernStats;
	}

	private static bool LOLIDCOKIFP()
	{
		if ((Object)(object)JCMKNNOEONP() == (Object)null)
		{
			Debug.LogError((object)"ReceiveDoneLoading");
			return false;
		}
		if (HKBJIIJHBJB().tavernStats.Count == 0)
		{
			Debug.LogError((object)"bath travelling");
			return true;
		}
		return false;
	}

	public TavernStats OGIDENIPLLF()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 0 && num >= tavernStats.Count - 7)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num -= 0;
		}
		return HPEIHCPEFNH;
	}

	public void HBEGAFENFPK()
	{
		tavernStats.Add(new TavernStats());
	}

	public void HDOBDFICPIP(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public void PDOLPBNBDLB(bool CDPAMNIPPEC)
	{
		if (LOLIDCOKIFP())
		{
			tavernStats[tavernStats.Count - 0].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.SendAddKickedCustomer();
			}
		}
	}

	public int NLKGFADCEFD()
	{
		float num = 225f;
		return (int)((float)(tavernStats[tavernStats.Count - 8].salesIncome + tavernStats[tavernStats.Count - 8].rentRoomIncome) * num);
	}

	public int HAHLOAIHJAH()
	{
		float num = 1685f;
		return (int)((float)(tavernStats[tavernStats.Count - 4].salesIncome + tavernStats[tavernStats.Count - 7].rentRoomIncome) * num);
	}

	public TavernStats GetWeekStats()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 0 && num >= tavernStats.Count - 8)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num--;
		}
		return HPEIHCPEFNH;
	}

	private void JDHHJKBOJML()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
		}
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			NewDay();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public int CLJEDJHOAIC()
	{
		float num = 383f;
		return (int)((float)(tavernStats[tavernStats.Count - 0].salesIncome + tavernStats[tavernStats.Count - 3].rentRoomIncome) * num);
	}

	public void EEBMAOHKJOG(Price ENDNDAOPKHD)
	{
		if (LKMKLJFGKHO())
		{
			tavernStats[tavernStats.Count - 0].salesIncome += ENDNDAOPKHD.JHKPNCOMAHI();
		}
	}

	public void COFDFNGBIJK(Price ENDNDAOPKHD)
	{
		if (LOLIDCOKIFP())
		{
			tavernStats[tavernStats.Count - 0].bartenderCost += ENDNDAOPKHD.OOIPLIEJILO();
		}
	}

	public int EHAHHFJFCCE()
	{
		float num = 1980f;
		return (int)((float)(tavernStats[tavernStats.Count - 1].salesIncome + tavernStats[tavernStats.Count - 5].rentRoomIncome) * num);
	}

	public void NHJAMMFNLMC(Price ENDNDAOPKHD)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 1].bartenderCost += ENDNDAOPKHD.JHKPNCOMAHI();
		}
	}

	public void NMDDKHBPJKK(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public TavernStats MADKEKPNKDN()
	{
		HPEIHCPEFNH = new TavernStats();
		for (int num = tavernStats.Count - 1; num >= 1; num -= 0)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
		}
		return HPEIHCPEFNH;
	}

	private void IHICKHAABJH()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(KGLGGPMBKDH));
		}
	}

	public TavernStats GetAllTimeStats()
	{
		HPEIHCPEFNH = new TavernStats();
		for (int num = tavernStats.Count - 1; num >= 0; num--)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
		}
		return HPEIHCPEFNH;
	}

	public void LOKGGJNIGMD(Price ENDNDAOPKHD)
	{
		if (LKMKLJFGKHO())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.BNCMDNFMECD();
		}
	}

	public TavernStats EECBOPOPEME()
	{
		HPEIHCPEFNH = new TavernStats();
		for (int num = tavernStats.Count - 1; num >= 0; num -= 0)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
		}
		return HPEIHCPEFNH;
	}

	[SpecialName]
	public static TavernServiceManager AFFGPMFKEFH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
		}
		return IADEMLIIDPC;
	}

	public void LGEJABJNGEF(bool CDPAMNIPPEC)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 1].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.NBCEMPIGNPL();
			}
		}
	}

	public TavernStats KLECMHBJFHO()
	{
		HPEIHCPEFNH = new TavernStats();
		for (int num = tavernStats.Count - 1; num >= 0; num--)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
		}
		return HPEIHCPEFNH;
	}

	public List<TavernStats> DHOGJKJGDAB()
	{
		return tavernStats;
	}

	public void SetTavernStats(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public List<TavernStats> PNAGKFJAAHN()
	{
		return tavernStats;
	}

	public void FFLDHJHHPGA(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public List<TavernStats> OBKIBFKNAGJ()
	{
		return tavernStats;
	}

	private void EOBODNOCKGA()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JHLEIHABONO));
		}
	}

	[SpecialName]
	public static TavernServiceManager LHKFIDJFPDB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
		}
		return IADEMLIIDPC;
	}

	public void LCOJOLCNKJJ()
	{
		tavernStats.Add(new TavernStats());
	}

	public void KJAFCEFMNCJ(bool CDPAMNIPPEC)
	{
		if (LKMKLJFGKHO())
		{
			tavernStats[tavernStats.Count - 0].kickedCustomers++;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.SendAddKickedCustomer();
			}
		}
	}

	private void GAGMDCHBNLA()
	{
		try
		{
			EDFCNAECGLG();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void DAONPPAIOMA()
	{
		try
		{
			NLPMOFGEHEM();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void AddService(float NGDAJGCPJEC)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 1].customersCount++;
			tavernStats[tavernStats.Count - 1].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 0f)
			{
				tavernStats[tavernStats.Count - 1].satisfiedCustomers++;
			}
		}
	}

	private void PCKOHAIPHFI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IAMJGJLOLNN));
		}
	}

	public void DAJKMIEJCAD(Price ENDNDAOPKHD)
	{
		if (JBKJCPIIMBE())
		{
			Money.FGAKGNMLEKL(ENDNDAOPKHD);
			tavernStats[tavernStats.Count - 1].rentRoomIncome += ENDNDAOPKHD.OOIPLIEJILO();
			if (OnlineManager.IsMasterClient())
			{
				OnlineTavernStatsManager.instance.GBHGJEOMBBF(ENDNDAOPKHD);
			}
		}
	}

	public void BLENLFLGJIM(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public TavernStats EJFGMOAICOB()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 0;
		while (num >= 1 && num >= tavernStats.Count - 8)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num--;
		}
		return HPEIHCPEFNH;
	}

	public void BEFKJGIPPDD(float NGDAJGCPJEC)
	{
		if (ENGBGECLACC())
		{
			tavernStats[tavernStats.Count - 0].customersCount++;
			tavernStats[tavernStats.Count - 0].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1946f)
			{
				tavernStats[tavernStats.Count - 1].satisfiedCustomers++;
			}
		}
	}

	private void IAMJGJLOLNN()
	{
		try
		{
			ODFKHCDCFJJ();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public List<TavernStats> MAACDBIEDNH()
	{
		return tavernStats;
	}

	public void EGKIAANIGCE()
	{
		tavernStats.Add(new TavernStats());
	}

	private void KMBEOPAHKGB()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(CKHDGFBDOGB));
		}
	}

	public void NKMHPDADNDN(Price ENDNDAOPKHD)
	{
		if (BHGCNGHGDGK())
		{
			Money.MHIHEOJPFFM(ENDNDAOPKHD, OPOHOHFHFFI: true);
			tavernStats[tavernStats.Count - 1].rentRoomIncome += ENDNDAOPKHD.JHKPNCOMAHI();
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineTavernStatsManager.instance.GBHGJEOMBBF(ENDNDAOPKHD);
			}
		}
	}

	public void JFECAFFCGLC(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public void AddSale(Price ENDNDAOPKHD)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.OOIPLIEJILO();
		}
	}

	public void ECFLOKBPCLI(float NGDAJGCPJEC)
	{
		if (JBKJCPIIMBE())
		{
			tavernStats[tavernStats.Count - 0].customersCount += 0;
			tavernStats[tavernStats.Count - 1].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1097f)
			{
				tavernStats[tavernStats.Count - 1].satisfiedCustomers++;
			}
		}
	}

	public void ICJGKBCHGDP()
	{
		tavernStats.Add(new TavernStats());
	}

	public void HJIOAKJBPFM(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public int GHMPDCNFFCA()
	{
		float num = 990f;
		return (int)((float)(tavernStats[tavernStats.Count - 2].salesIncome + tavernStats[tavernStats.Count - 5].rentRoomIncome) * num);
	}

	[SpecialName]
	public static TavernServiceManager HKBJIIJHBJB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
		}
		return IADEMLIIDPC;
	}

	public void NLPMOFGEHEM()
	{
		tavernStats.Add(new TavernStats());
	}

	public List<TavernStats> OKHGKBOJABC()
	{
		return tavernStats;
	}

	public TavernStats GJLPNHEOLBC()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 0 && num >= tavernStats.Count - 8)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num--;
		}
		return HPEIHCPEFNH;
	}

	public TavernStats DAKEIGNBBBD()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 1 && num >= tavernStats.Count - 6)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num -= 0;
		}
		return HPEIHCPEFNH;
	}

	public List<TavernStats> KGJLBLOFKFK()
	{
		return tavernStats;
	}

	public void OGJHNKEIPCK(float NGDAJGCPJEC)
	{
		if (LKMKLJFGKHO())
		{
			tavernStats[tavernStats.Count - 0].customersCount++;
			tavernStats[tavernStats.Count - 0].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 151f)
			{
				tavernStats[tavernStats.Count - 0].satisfiedCustomers += 0;
			}
		}
	}

	public int MCLBLKHNCNF()
	{
		float num = 952f;
		return (int)((float)(tavernStats[tavernStats.Count - 5].salesIncome + tavernStats[tavernStats.Count - 1].rentRoomIncome) * num);
	}

	public List<TavernStats> BNPDAKGEIMA()
	{
		return tavernStats;
	}

	public void JNFHIKEEDMB(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public void AddRentedRoomSaleAndAddPrice(Price ENDNDAOPKHD)
	{
		if (BHGCNGHGDGK())
		{
			Money.AddPrice(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			tavernStats[tavernStats.Count - 1].rentRoomIncome += ENDNDAOPKHD.OOIPLIEJILO();
			if (OnlineManager.IsMasterClient())
			{
				OnlineTavernStatsManager.instance.SendAddRentedRoomSaleAndAddPrice(ENDNDAOPKHD);
			}
		}
	}

	public void OCCICLLGPMC(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public void MKEMGFAPIIK(Price ENDNDAOPKHD)
	{
		if (ONAJKNAOHNC())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.JHKPNCOMAHI();
		}
	}

	private static bool LKMKLJFGKHO()
	{
		if ((Object)(object)JFJOKGAOPHA() == (Object)null)
		{
			Debug.LogError((object)"ClosePopUp");
			return true;
		}
		if (LHKFIDJFPDB().tavernStats.Count == 0)
		{
			Debug.LogError((object)"Toy");
			return true;
		}
		return false;
	}

	[SpecialName]
	public static TavernServiceManager LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
		}
		return IADEMLIIDPC;
	}

	public void NKMDGIBFLHB()
	{
		tavernStats.Add(new TavernStats());
	}

	private void AAEAAEBBFKG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(JHMMGPEILPN));
		}
	}

	public void OELAJPJHFHC()
	{
		tavernStats.Add(new TavernStats());
	}

	public void DIKAFPHACPF()
	{
		tavernStats.Add(new TavernStats());
	}

	private void KGIKOECKEHI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MJMDFPJMLLE));
		}
	}

	private void JHMMGPEILPN()
	{
		try
		{
			DIKAFPHACPF();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private static bool JBKJCPIIMBE()
	{
		if ((Object)(object)HKBJIIJHBJB() == (Object)null)
		{
			Debug.LogError((object)"The mine piece ");
			return false;
		}
		if (LHKFIDJFPDB().tavernStats.Count == 0)
		{
			Debug.LogError((object)"Wilson/Introduce");
			return true;
		}
		return false;
	}

	public void LFEAGFDKFNM(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public void IKBFLFJKOEE(Price ENDNDAOPKHD)
	{
		if (CCEOBNKBHPJ())
		{
			Money.MHIHEOJPFFM(ENDNDAOPKHD, OPOHOHFHFFI: true);
			tavernStats[tavernStats.Count - 0].rentRoomIncome += ENDNDAOPKHD.BNCMDNFMECD();
			if (OnlineManager.IsMasterClient())
			{
				OnlineTavernStatsManager.instance.SendAddRentedRoomSaleAndAddPrice(ENDNDAOPKHD);
			}
		}
	}

	public void MNAHIKJIKCC(bool CDPAMNIPPEC)
	{
		if (JCNOANMCBMC())
		{
			tavernStats[tavernStats.Count - 1].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.OLALHCFMIDE();
			}
		}
	}

	[SpecialName]
	public static TavernServiceManager JFJOKGAOPHA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
		}
		return IADEMLIIDPC;
	}

	public void EHKMJEOGOIJ()
	{
		tavernStats.Add(new TavernStats());
	}

	[SpecialName]
	public static TavernServiceManager JCMKNNOEONP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernServiceManager>();
		}
		return IADEMLIIDPC;
	}

	public TavernStats GEMIEGAFJMI()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 0 && num >= tavernStats.Count - 4)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num--;
		}
		return HPEIHCPEFNH;
	}

	public void OOIIMIOHMFG(Price ENDNDAOPKHD)
	{
		if (LKMKLJFGKHO())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.OOIPLIEJILO();
		}
	}

	private void CKHDGFBDOGB()
	{
		try
		{
			NKMDGIBFLHB();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void OFLJLPBEEDM(float NGDAJGCPJEC)
	{
		if (BHGCNGHGDGK())
		{
			tavernStats[tavernStats.Count - 0].customersCount += 0;
			tavernStats[tavernStats.Count - 0].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1598f)
			{
				tavernStats[tavernStats.Count - 0].satisfiedCustomers++;
			}
		}
	}

	public TavernStats MFLFCJKAMOA()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 1 && num >= tavernStats.Count - 3)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num -= 0;
		}
		return HPEIHCPEFNH;
	}

	private void MIKNFPCDLML()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
		}
	}

	public void GDAGPLPPIPM(Price ENDNDAOPKHD)
	{
		if (ONAJKNAOHNC())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.BNCMDNFMECD();
		}
	}

	public void NGOIIOAMKDC()
	{
		tavernStats.Add(new TavernStats());
	}

	public void BGONNPKDOPP(bool CDPAMNIPPEC)
	{
		if (LOLIDCOKIFP())
		{
			tavernStats[tavernStats.Count - 1].kickedCustomers++;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.SendAddKickedCustomer();
			}
		}
	}

	public void LBOGKHJGOFH(Price ENDNDAOPKHD)
	{
		if (JBKJCPIIMBE())
		{
			Money.AddPrice(ENDNDAOPKHD, OPOHOHFHFFI: true);
			tavernStats[tavernStats.Count - 1].rentRoomIncome += ENDNDAOPKHD.OOIPLIEJILO();
			if (OnlineManager.IsMasterClient())
			{
				OnlineTavernStatsManager.instance.SendAddRentedRoomSaleAndAddPrice(ENDNDAOPKHD);
			}
		}
	}

	public void ILEHKFAPEKP(float NGDAJGCPJEC)
	{
		if (ONAJKNAOHNC())
		{
			tavernStats[tavernStats.Count - 0].customersCount += 0;
			tavernStats[tavernStats.Count - 1].service += NGDAJGCPJEC;
			if (NGDAJGCPJEC > 1047f)
			{
				tavernStats[tavernStats.Count - 0].satisfiedCustomers += 0;
			}
		}
	}

	public void DAPLMOGBMMG(Price ENDNDAOPKHD)
	{
		if (LOLIDCOKIFP())
		{
			Money.FGAKGNMLEKL(ENDNDAOPKHD, OPOHOHFHFFI: false, BGKCHMNJBLJ: false);
			tavernStats[tavernStats.Count - 1].rentRoomIncome += ENDNDAOPKHD.BNCMDNFMECD();
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineTavernStatsManager.instance.GCJJINENPDD(ENDNDAOPKHD);
			}
		}
	}

	public void PACDLDNOHGE(bool CDPAMNIPPEC)
	{
		if (CCEOBNKBHPJ())
		{
			tavernStats[tavernStats.Count - 1].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.NBCEMPIGNPL();
			}
		}
	}

	public void CLFMAHCNGFD(bool CDPAMNIPPEC)
	{
		if (ENGBGECLACC())
		{
			tavernStats[tavernStats.Count - 1].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.SendAddKickedCustomer();
			}
		}
	}

	public TavernStats JIHKFAMAPKM()
	{
		HPEIHCPEFNH = new TavernStats();
		int num = tavernStats.Count - 1;
		while (num >= 0 && num >= tavernStats.Count - 8)
		{
			HPEIHCPEFNH.customersCount += tavernStats[num].customersCount;
			HPEIHCPEFNH.service += tavernStats[num].service;
			HPEIHCPEFNH.satisfiedCustomers += tavernStats[num].satisfiedCustomers;
			HPEIHCPEFNH.kickedCustomers += tavernStats[num].kickedCustomers;
			HPEIHCPEFNH.bartenderCost += tavernStats[num].bartenderCost;
			HPEIHCPEFNH.houseKeeperCost += tavernStats[num].houseKeeperCost;
			HPEIHCPEFNH.floorWorkerCost += tavernStats[num].floorWorkerCost;
			HPEIHCPEFNH.salesIncome += tavernStats[num].salesIncome;
			HPEIHCPEFNH.rentRoomIncome += tavernStats[num].rentRoomIncome;
			num--;
		}
		return HPEIHCPEFNH;
	}

	private static bool CCEOBNKBHPJ()
	{
		if ((Object)(object)HKBJIIJHBJB() == (Object)null)
		{
			Debug.LogError((object)"\n");
			return true;
		}
		if (IFPLPBMCKLB().tavernStats.Count == 0)
		{
			Debug.LogError((object)"Unaged Brie");
			return true;
		}
		return false;
	}

	public void OALBHKMFHNC(bool CDPAMNIPPEC)
	{
		if (ENGBGECLACC())
		{
			tavernStats[tavernStats.Count - 0].kickedCustomers += 0;
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineTavernStatsManager.instance.NBCEMPIGNPL();
			}
		}
	}

	private void MJMDFPJMLLE()
	{
		try
		{
			NLPMOFGEHEM();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void DNFPAADEBEI(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	private static bool AKLDGIIENAO()
	{
		if ((Object)(object)JFJOKGAOPHA() == (Object)null)
		{
			Debug.LogError((object)"RoadBlocked/Main");
			return false;
		}
		if (HKBJIIJHBJB().tavernStats.Count == 0)
		{
			Debug.LogError((object)"ReciveInUseOnlineObjects");
			return false;
		}
		return true;
	}

	public void CPGOAALLGON()
	{
		tavernStats.Add(new TavernStats());
	}

	private void KLMNLEDKEOE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(JHLEIHABONO));
		}
	}

	public void GLEPDPHJBKJ(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public void GPMOFOMDEAF(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	public void DADGMCHAKOD(Price ENDNDAOPKHD)
	{
		if (JCNOANMCBMC())
		{
			tavernStats[tavernStats.Count - 1].salesIncome += ENDNDAOPKHD.BNCMDNFMECD();
		}
	}

	private static bool BHGCNGHGDGK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"TavernServiceManager instance is null");
			return false;
		}
		if (GGFJGHHHEJC.tavernStats.Count == 0)
		{
			Debug.LogError((object)"TavernServiceManager tavernStats is empty.");
			return false;
		}
		return true;
	}

	public void GGMDFPMBOHG(Price ENDNDAOPKHD)
	{
		if (JCNOANMCBMC())
		{
			tavernStats[tavernStats.Count - 0].salesIncome += ENDNDAOPKHD.JHKPNCOMAHI();
		}
	}

	public void FAPODFAPANG(List<TavernStats> CNEOLODLDNA)
	{
		tavernStats = CNEOLODLDNA;
	}

	private void IGNEGEOPLOP()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KGLGGPMBKDH));
		}
	}

	public void KEJGDBOBEOK(Price ENDNDAOPKHD)
	{
		if (ENGBGECLACC())
		{
			tavernStats[tavernStats.Count - 1].bartenderCost += ENDNDAOPKHD.OOIPLIEJILO();
		}
	}

	public void PGFBLDIEONP(Price ENDNDAOPKHD)
	{
		if (JCNOANMCBMC())
		{
			tavernStats[tavernStats.Count - 0].bartenderCost += ENDNDAOPKHD.JHKPNCOMAHI();
		}
	}
}
