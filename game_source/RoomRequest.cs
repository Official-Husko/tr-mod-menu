using System;
using UnityEngine;

[Serializable]
public class RoomRequest
{
	public Customer customer;

	public int daysToStay;

	public int floorTiles;

	public int comfort;

	public float haggleChance;

	public Price finalPrice;

	public bool DPDHGMDOPBH(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.PMDPEDGIABG() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort >= comfort;
		}
		return false;
	}

	public bool PNIMDIMDIJC(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.HJLNDIEOMBA() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort < comfort;
		}
		return true;
	}

	public bool MKEOFICAIHC(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.KKMAPKICDEE() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort >= comfort;
		}
		return true;
	}

	public bool JMKKFLMEGCE(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.JLKLJNKOFJN() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort < comfort;
		}
		return false;
	}

	public bool NAELCFCDHOD(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.GetNumFloorTiles() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort >= comfort;
		}
		return false;
	}

	public bool NOOFMIMHELP(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.GetNumFloorTiles() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort >= comfort;
		}
		return true;
	}

	public RoomRequest(Customer PJNGMCJIHME, float GKBHBOHOKPH)
	{
		customer = PJNGMCJIHME;
		haggleChance = GKBHBOHOKPH;
		daysToStay = RentedRoomsManager.DaysToStayRange();
		if (HouseKeeper.JHLLELHBIDA)
		{
			if (Random.Range(0, 100) < HouseKeeper.GetEmployeePerkValue(46))
			{
				daysToStay++;
			}
			if (Random.Range(0, 100) < HouseKeeper.GetEmployeePerkValue(73))
			{
				daysToStay = Mathf.Max(1, daysToStay - 1);
			}
		}
		floorTiles = RentedRoomsManager.GetRandomFloorTilesRequest();
		comfort = RentedRoomsManager.GetRandomComfortRequest();
	}

	public bool LLMCIOIPCID(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.GetNumFloorTiles() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort < comfort;
		}
		return false;
	}

	public RoomRequest(Customer PJNGMCJIHME, float GKBHBOHOKPH, int NOCJBLOBILD, int IAKHILLNFBP, int JKJPNMJPNGH)
	{
		customer = PJNGMCJIHME;
		haggleChance = GKBHBOHOKPH;
		daysToStay = NOCJBLOBILD;
		floorTiles = IAKHILLNFBP;
		comfort = JKJPNMJPNGH;
	}

	public bool MKMLCEFDKLI(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.JLKLJNKOFJN() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort >= comfort;
		}
		return false;
	}

	public bool EEMEMINPOIP(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.GetNumFloorTiles() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort < comfort;
		}
		return false;
	}

	public bool AANNKCHKADP(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.HJLNDIEOMBA() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort >= comfort;
		}
		return true;
	}

	public bool EDAKNKCAAON(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.HJLNDIEOMBA() >= floorTiles)
		{
			return GGNOAHDCPIB.zone.comfort < comfort;
		}
		return true;
	}
}
