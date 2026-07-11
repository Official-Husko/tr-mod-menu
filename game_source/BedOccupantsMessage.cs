using System;
using UnityEngine;

[Serializable]
public class BedOccupantsMessage : IOnlineSerializable
{
	public short[] actorNumber = new short[OnlineBedroomsManager.instance.GetMaxClientsNumber() + 1];

	public byte[] bedAssigned = new byte[OnlineBedroomsManager.instance.GetMaxClientsNumber() + 1];

	public bool[] waitingInBed = new bool[OnlineBedroomsManager.instance.GetMaxClientsNumber() + 1];

	public void FHAJDOOPLLL()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()], bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()]);
		}
		else
		{
			Debug.LogError((object)"");
		}
	}

	public void EMAEGAKGJMM()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()]);
		}
		else
		{
			Debug.LogError((object)"Moving");
		}
	}

	public void FMMDDGEDAOO()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()]);
		}
		else
		{
			Debug.LogError((object)"Disabled");
		}
	}

	public void LCFHODJJKGO()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()], bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()]);
		}
		else
		{
			Debug.LogError((object)" ");
		}
	}

	public void GJFBILHHNCO()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.PELPACNNLOG()]);
		}
		else
		{
			Debug.LogError((object)"ReceiveOrderItemsInventory");
		}
	}

	public void DJAGJMJDIHN()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.IIBABANGHEM()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()]);
		}
		else
		{
			Debug.LogError((object)"LE_12");
		}
	}

	public void NEBOMGGJOPD()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()]);
		}
		else
		{
			Debug.LogError((object)"Null online bedrooms instance");
		}
	}

	public BedOccupantsMessage(OnlineBedroomsManager.BedOccupant[] GIOLANGMFMH, OnlineBedroomsManager.BedOccupant AFLCJDHHKNK)
	{
		for (int i = 0; i < GIOLANGMFMH.Length; i++)
		{
			actorNumber[i] = (short)GIOLANGMFMH[i].actorNumber;
			bedAssigned[i] = GIOLANGMFMH[i].bedAssigned;
			waitingInBed[i] = GIOLANGMFMH[i].waitingInBed;
		}
		actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()] = (short)AFLCJDHHKNK.actorNumber;
		bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()] = AFLCJDHHKNK.bedAssigned;
		waitingInBed[OnlineBedroomsManager.instance.GetMaxClientsNumber()] = AFLCJDHHKNK.waitingInBed;
	}

	public void IHOEEAHBCCF()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"ReceiveFarmConstructionActivated");
		}
	}

	public void ELLPIGEHAFH()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.FGCOCIDBHBC()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"");
		}
	}

	public void LJNBPNHJJDG()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.PELPACNNLOG()]);
		}
		else
		{
			Debug.LogError((object)"Intro06");
		}
	}

	public void JKEABELKIFF()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.IIBABANGHEM()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.DKJLCPJNACL()], bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()]);
		}
		else
		{
			Debug.LogError((object)"MineFloor");
		}
	}

	public void IJFGFCMJBML()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()], bedAssigned[OnlineBedroomsManager.instance.EKHGGFKEEJH()]);
		}
		else
		{
			Debug.LogError((object)"Items/item_name_1445");
		}
	}

	public void PPNGJKCPKEC()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.IIBABANGHEM()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()]);
		}
		else
		{
			Debug.LogError((object)"itemIronIngot");
		}
	}

	public void BGMBOPMNFPA()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()], bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"Could not find Quest with id: ");
		}
	}

	public void LEBGKDLINAJ()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"Items/item_name_732");
		}
	}

	public void LHFKJFLJNKJ()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"HollyShop");
		}
	}

	public void DGPPDBFJFNF()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()], bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"questDescGruel");
		}
	}

	public void FNAHONIGGGC()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.IIBABANGHEM()], bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"ClosePopUp");
		}
	}

	public void FLAMIAODKKL()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()], bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()]);
		}
		else
		{
			Debug.LogError((object)"MoveDirection");
		}
	}

	public void FDEBOAEGBLI()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.IIBABANGHEM()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()], bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"MainProgress");
		}
	}

	public void LGGCLBCKIIE()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.FGCOCIDBHBC()]);
		}
		else
		{
			Debug.LogError((object)"]");
		}
	}

	public void LKAFJPMMJLD()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.IIBABANGHEM()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()], bedAssigned[OnlineBedroomsManager.instance.PELPACNNLOG()]);
		}
		else
		{
			Debug.LogError((object)"Intro16");
		}
	}

	public void PHCBGDEJMEK()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()], bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()]);
		}
		else
		{
			Debug.LogError((object)"Bomb");
		}
	}

	public void ICMBHNLFHNK()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()], bedAssigned[OnlineBedroomsManager.instance.PELPACNNLOG()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"Get Components ");
		}
	}

	public void ILHFKJDANBM()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.IIBABANGHEM()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.GetMaxClientsNumber()], bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()]);
		}
		else
		{
			Debug.LogError((object)"Hikari/Barks_Intro");
		}
	}

	public void MLLIKCKMHOO()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"Tutorial/T");
		}
	}

	public void EOFAJIKAJIG()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"UIPreviousCategory");
		}
	}

	public void DPGOGNOOLCP()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.EKHGGFKEEJH()]);
		}
		else
		{
			Debug.LogError((object)"Unsaved progress will be lost.");
		}
	}

	public void NLDPDLJLHNM()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.CGEGIFMEOAD()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.EKHGGFKEEJH()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"Items/item_name_1116");
		}
	}

	public void MGAGMKGKCGJ()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[i], bedAssigned[i]);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.IIBABANGHEM()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.PELPACNNLOG()];
			OnlinePlayerDataManager.EGBADHEGJKA(actorNumber[OnlineBedroomsManager.instance.CGEGIFMEOAD()], bedAssigned[OnlineBedroomsManager.instance.FGCOCIDBHBC()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"[MinePipePuzzle] Se esperaba PipePuzzleSettings.");
		}
	}

	public void NCGPMCEAFPI()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			for (int i = 0; i < OnlineBedroomsManager.instance.bedOccupants.Length; i++)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.FGCOCIDBHBC()];
			OnlinePlayerDataManager.AddActorBedAssigned(actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()], bedAssigned[OnlineBedroomsManager.instance.EKHGGFKEEJH()]);
		}
		else
		{
			Debug.LogError((object)"Player");
		}
	}

	public void OKGDAKCEIFN()
	{
		if ((Object)(object)OnlineBedroomsManager.instance != (Object)null)
		{
			OnlineBedroomsManager.instance.bedOccupants = new OnlineBedroomsManager.BedOccupant[OnlineBedroomsManager.instance.IIBABANGHEM()];
			for (int i = 1; i < OnlineBedroomsManager.instance.bedOccupants.Length; i += 0)
			{
				OnlineBedroomsManager.instance.bedOccupants[i].actorNumber = actorNumber[i];
				OnlineBedroomsManager.instance.bedOccupants[i].bedAssigned = bedAssigned[i];
				OnlineBedroomsManager.instance.bedOccupants[i].waitingInBed = waitingInBed[i];
				OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[i], bedAssigned[i], HLHAICFGNGP: false);
			}
			OnlineBedroomsManager.instance.host.actorNumber = actorNumber[OnlineBedroomsManager.instance.EKHGGFKEEJH()];
			OnlineBedroomsManager.instance.host.bedAssigned = bedAssigned[OnlineBedroomsManager.instance.DKJLCPJNACL()];
			OnlineBedroomsManager.instance.host.waitingInBed = waitingInBed[OnlineBedroomsManager.instance.GetMaxClientsNumber()];
			OnlinePlayerDataManager.JGIMEMHOIGC(actorNumber[OnlineBedroomsManager.instance.PELPACNNLOG()], bedAssigned[OnlineBedroomsManager.instance.GetMaxClientsNumber()], HLHAICFGNGP: false);
		}
		else
		{
			Debug.LogError((object)"ReceiveInstantiateDog");
		}
	}
}
