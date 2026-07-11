using System;
using UnityEngine;

public class Inventory : Container
{
	private static Inventory IADEMLIIDPC;

	private static Inventory BBINLIGKIPE;

	private static Inventory[] BFMGIFGHMCL = new Inventory[5];

	public bool onlineInstance;

	public int playerNum = 1;

	private static Inventory KEAGCALPNIG(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory PLHHJCNKNFO(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FJLHACOOCBA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return KOCOIKLJDMD(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Grab" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory GFHCACLMFDK(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return MOAAELBDFJC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 4 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return HFMJIMKIJIC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("RPC Receive Reset All Talents From Other " + JFNMCNCHMEO));
		return null;
	}

	public static Inventory MPDMDABCCCA(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return POLIFKLKBHF(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FJLHACOOCBA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 4)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("High quality water" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory EMCBLLMIDDE(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AAODNIFIFAM(NJFHGEPEDKC)];
	}

	public static Inventory IOMBGDJHJDC(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FFGHJBPOMNG(NJFHGEPEDKC)];
	}

	public static Inventory PAKOKEBMALK(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.BFCFMMNKJAL(NJFHGEPEDKC)];
	}

	public static Inventory EBOJNNPNHJD(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.JOKHDHBAABH(NJFHGEPEDKC)];
	}

	private static Inventory IGBHPMEKOKN(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory BGJBPDEBEJH(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	public static Inventory IOLAIFGMHEA(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FDACHPCLFMI(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return MEENBNFFFKN(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Items/item_description_1139" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory MKEMFFAPKLM(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory DILHDONEDBB(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory BDENIHLMMHB(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return APLFNCEFOIP(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return KODADALGKKF(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 4)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Player" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory PCHCKKPEFCN(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory DFCHIPCNBGM(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory IAAFEENHLKB(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return DEJOAECLBGL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BJMONCGLJAL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)(": Prefab direction not found!" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory IKAEFEPNADI(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return BACCFIPHGOL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return DILHDONEDBB(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Player" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory DAEEJGKLOCF(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return JBIMMOBEFJN(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return DILHDONEDBB(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("City/Hallmund/Bark/Tool" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory KODADALGKKF(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory ICAFKDFGIOM(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FFGHJBPOMNG(NJFHGEPEDKC)];
	}

	public static Inventory FOFIHBOJMEN(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.JOKHDHBAABH(NJFHGEPEDKC)];
	}

	protected override void Awake()
	{
		if (onlineInstance)
		{
			BFMGIFGHMCL[playerNum] = this;
		}
		else if (playerNum == 1)
		{
			IADEMLIIDPC = this;
		}
		else if (playerNum == 2)
		{
			BBINLIGKIPE = this;
		}
		else
		{
			Debug.LogException(new Exception("Invalid playerNum"));
		}
		base.Awake();
	}

	public static Inventory OPLHBOGGHNP(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	public static Inventory OPHDCMJLLEC(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FJLHACOOCBA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BACCFIPHGOL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("MineFloor" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory MHFEFCLBAJG(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return KODADALGKKF(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 4 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return KOCOIKLJDMD(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 4)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("(missing title)" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory BJMONCGLJAL(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory MPCBGFKFDEE(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.EODODAMMHLB(NJFHGEPEDKC)];
	}

	public static Inventory IKOLNIMDFGD(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FFGHJBPOMNG(NJFHGEPEDKC)];
	}

	public static Inventory ILAOFABODGO(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return BJMONCGLJAL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return DFCHIPCNBGM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)(" at " + JFNMCNCHMEO));
		return null;
	}

	public static Inventory DACNEICGAAE(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return BJMONCGLJAL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return DKMMJBHOIIP(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("/" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory PEMOHNKCBGB(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory ECIMBOLILAF(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FDFNHAGNJOD(NJFHGEPEDKC)];
	}

	private static Inventory FDACHPCLFMI(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory ODLDIGCEGBP(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FDFNHAGNJOD(NJFHGEPEDKC)];
	}

	private static Inventory KBIPGPLJHMP(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory NLEFGNHMJNN(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return BPOLLLOCPFA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return CPPMHOKIIAK(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Chat deselected" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory INCGGMFMLFC(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.EODODAMMHLB(NJFHGEPEDKC)];
	}

	public static Inventory OCJGHINCLJM(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return DFCHIPCNBGM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return PJOFLIAJGAD(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Jump" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory OFFHAGOJJLD(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	public static Inventory IMJOOACMADK(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return PJOFLIAJGAD(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return JLDOKPJPDLM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory BACCFIPHGOL(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory DEJOAECLBGL(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory JDADPDBHJFO(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return MIGAMAJJIAA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return POLIFKLKBHF(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("SkeletonBird" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory BDPPNLODPGN(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return IGNIKLDIHNM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BPOLLLOCPFA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 1)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Items/item_description_705" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory FAGOJJGLLLP(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FFGHJBPOMNG(NJFHGEPEDKC)];
	}

	private static Inventory PJGMBMMNPGL(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory HHONLOCNFNC(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return MIGAMAJJIAA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BJMONCGLJAL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("LE_10" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory EFPAGNILEAJ(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory EJDPAILJCFJ(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FDFNHAGNJOD(NJFHGEPEDKC)];
	}

	public static Inventory PJMGKNBPAMG(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AJNNFDAEIFB(NJFHGEPEDKC)];
	}

	public static Inventory IDLOFOGJCMH(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	private static Inventory CBEPOBEKONM(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory GetPlayer(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDPKLOPMNNJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Invalid playerNum " + JFNMCNCHMEO));
		return null;
	}

	public static Inventory IECFJGHAIDO(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FFLMGFOHHKK(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDACHPCLFMI(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("ReceiveRandomOrderQuests" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory KOCOIKLJDMD(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory CHCMGKNDCPD(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AAODNIFIFAM(NJFHGEPEDKC)];
	}

	public static Inventory DFOHLCPPKCM(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.JOKHDHBAABH(NJFHGEPEDKC)];
	}

	public static Inventory HFLMEIMOLMJ(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.BFCFMMNKJAL(NJFHGEPEDKC)];
	}

	public static Inventory JFIPFFDLDKB(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return POLIFKLKBHF(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return DFONEOPPNAN(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("ReceiveSetLife" + JFNMCNCHMEO));
		return null;
	}

	public override Slot AddItemInstance(int JIIGOACEIKL, ItemInstance BGLFLHDNOKJ, bool OJKJLIPNHOI = false, bool CDPAMNIPPEC = true)
	{
		if (GameManager.LocalCoop())
		{
			if (GameInventoryUI.Get(JIIGOACEIKL).IsOpen())
			{
				Slot slot = Utils.CHMEHDFPGCI(JIIGOACEIKL, BGLFLHDNOKJ, GameInventoryUI.Get(JIIGOACEIKL).GetPageSlots(), GetMaxStack(BGLFLHDNOKJ), null, null, null, null, FoodType.None, null, OECLHGILEOL: false, CDPAMNIPPEC);
				if (slot != null)
				{
					return slot;
				}
			}
			else if (MainInventoryUI.Get(JIIGOACEIKL).IsOpen())
			{
				Slot slot2 = Utils.CHMEHDFPGCI(JIIGOACEIKL, BGLFLHDNOKJ, MainInventoryUI.Get(JIIGOACEIKL).GetPageSlots(), GetMaxStack(BGLFLHDNOKJ), null, null, null, null, FoodType.None, null, OECLHGILEOL: false, CDPAMNIPPEC);
				if (slot2 != null)
				{
					return slot2;
				}
			}
		}
		return base.AddItemInstance(JIIGOACEIKL, BGLFLHDNOKJ, OJKJLIPNHOI, CDPAMNIPPEC);
	}

	public static Inventory FGPANFCEAFP(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AAODNIFIFAM(NJFHGEPEDKC)];
	}

	public static Inventory BGBPECOMHPH(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AAODNIFIFAM(NJFHGEPEDKC)];
	}

	public static Inventory EKKFEILDAGE(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.EODODAMMHLB(NJFHGEPEDKC)];
	}

	public static Inventory OMDMPGDMGIP(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AAODNIFIFAM(NJFHGEPEDKC)];
	}

	public static Inventory LLAJBACNNCG(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.EODODAMMHLB(NJFHGEPEDKC)];
	}

	private static Inventory FDPKLOPMNNJ(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory DNJBNNEFHAB(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AJNNFDAEIFB(NJFHGEPEDKC)];
	}

	public static Inventory MOJHECKNNFC(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FDFNHAGNJOD(NJFHGEPEDKC)];
	}

	private static Inventory HFMJIMKIJIC(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory GFILNFFCBOB(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.JOKHDHBAABH(NJFHGEPEDKC)];
	}

	private static Inventory APLFNCEFOIP(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory BDHMAFFIHGM(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory KCOBKJNCKNP(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FJLHACOOCBA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BJMONCGLJAL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("UIBack" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory GIAOPMIDGPL(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return HFMJIMKIJIC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return KLIHGOAJHJH(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Failed to join the game because the host is loading or in a cutscene.\nPlease try again later." + JFNMCNCHMEO));
		return null;
	}

	public static Inventory ECNPNCLIPEO(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.BFCFMMNKJAL(NJFHGEPEDKC)];
	}

	public static Inventory LCBAAKDOJPE(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.BFCFMMNKJAL(NJFHGEPEDKC)];
	}

	public static Inventory NBEGPFFBKPO(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return CPPMHOKIIAK(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 1 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FFLMGFOHHKK(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Items/item_description_1177" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory JBIMMOBEFJN(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory AGEHIILFADF(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return LFANEMOHMJB(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return JLDOKPJPDLM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("ReceiveObjectInteract" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory CCJOCAEMNIM(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	private static Inventory DKMMJBHOIIP(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory HCOFIGMFCGA(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.BFCFMMNKJAL(NJFHGEPEDKC)];
	}

	private static Inventory FJLHACOOCBA(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory JLDOKPJPDLM(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory KHFLLHNGOMO(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FDFNHAGNJOD(NJFHGEPEDKC)];
	}

	public static Inventory AELPIFHLOAH(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return DEJOAECLBGL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return NECMPEJIOFC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Player" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory LPBOGHFCABN(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AAODNIFIFAM(NJFHGEPEDKC)];
	}

	private static Inventory MOAAELBDFJC(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory MEENBNFFFKN(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory DFONEOPPNAN(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory KLIHGOAJHJH(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory OPMGMBAHPBD(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.JOKHDHBAABH(NJFHGEPEDKC)];
	}

	private static Inventory NECMPEJIOFC(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory FHAJGFAECOM(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.EODODAMMHLB(NJFHGEPEDKC)];
	}

	public static Inventory NHHOGHLEODI(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FFLMGFOHHKK(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BJMONCGLJAL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 6)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory IGMCBPOPNCA(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return JMPAJNLHEOG(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FJLHACOOCBA(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("castle interior travelling" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory FFGEAGBKEGD(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory AFMOAONHHNL(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return EFPAGNILEAJ(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDACHPCLFMI(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Drink" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory FGELEDGOFOI(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FDFNHAGNJOD(NJFHGEPEDKC)];
	}

	public static Inventory MCGJGGIBODB(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FDFNHAGNJOD(NJFHGEPEDKC)];
	}

	private static Inventory CPPMHOKIIAK(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory KEHIBCAHKPJ(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return IGNIKLDIHNM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return BDHMAFFIHGM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Sit" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory EIFPKCAFDIB(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return DILHDONEDBB(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return DFCHIPCNBGM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 1)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("SetNPCPositionAndParent" + JFNMCNCHMEO));
		return null;
	}

	private static Inventory LFANEMOHMJB(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory BNMEANGDMIP(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return PJGMBMMNPGL(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FFLMGFOHHKK(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("A 'PsaiCoreManager' component is missing in your Scene! psai won't work without it. Please add it manually to any GameObject in your Scene (found in 'Psai/Scripts/Essential'), or drag & drop the 'Psai.prefab' from the 'Psai' folder into your Scene. The Psai.prefab also comes with the PsaiPlayer user interface, which may safely be removed from your Scene if not needed. We further recommend to add/keep a 'PsaiSoundtrackLoader' component for convenient loading of Soundtracks." + JFNMCNCHMEO));
		return null;
	}

	public static Inventory JPDEFKLINCL(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return DILHDONEDBB(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return FDACHPCLFMI(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 0)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("tutorialPopUp106" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory JFOPGMCMOPN(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.JOKHDHBAABH(NJFHGEPEDKC)];
	}

	public static Inventory IOBMIHLMGNH(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 1)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return BDHMAFFIHGM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 2 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return MOAAELBDFJC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Highest Room ID: {0}" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory MLAMNGFKIOJ(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	public static Inventory HAFEKFBFFLO(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	private static Inventory JMPAJNLHEOG(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory BPOLLLOCPFA(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory MJJHNNJKEMO(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return FFGEAGBKEGD(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 8 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return NECMPEJIOFC(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 3)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("Resolucion: " + JFNMCNCHMEO));
		return null;
	}

	public static Inventory NPANPNIDKDG(int JFNMCNCHMEO, bool LAGHIOKLJGH = false, bool ADPNMHGBFKG = false)
	{
		if (JFNMCNCHMEO == 0)
		{
			return IADEMLIIDPC;
		}
		if (ADPNMHGBFKG)
		{
			return CBEPOBEKONM(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 5 && LAGHIOKLJGH)
		{
			return BBINLIGKIPE;
		}
		if (OnlineManager.PlayingOnline())
		{
			return DFONEOPPNAN(JFNMCNCHMEO);
		}
		if (JFNMCNCHMEO == 7)
		{
			return BBINLIGKIPE;
		}
		Debug.LogError((object)("itemPaperCoaster" + JFNMCNCHMEO));
		return null;
	}

	public static Inventory LCFBHGGPIBD(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.AAODNIFIFAM(NJFHGEPEDKC)];
	}

	public static Inventory OPHPBCJNDDD(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.BFCFMMNKJAL(NJFHGEPEDKC)];
	}

	public static Inventory GetPlayerOnlineWithActor(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	public static Inventory MKJIFBHAPGJ(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}

	private static Inventory MIGAMAJJIAA(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory FFLMGFOHHKK(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory JDCOFLLOKBL(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory POLIFKLKBHF(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory PJOFLIAJGAD(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory IGNIKLDIHNM(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	private static Inventory BMFGHALJNCN(int JFNMCNCHMEO)
	{
		return BFMGIFGHMCL[JFNMCNCHMEO];
	}

	public static Inventory OKFLMHHCBPJ(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.FFGHJBPOMNG(NJFHGEPEDKC)];
	}

	public static Inventory DJGHHODAGCM(int NJFHGEPEDKC)
	{
		return BFMGIFGHMCL[OnlineBedroomsManager.instance.GetPlayerBed(NJFHGEPEDKC)];
	}
}
