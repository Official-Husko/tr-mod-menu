using UnityEngine;

public class OnlineTreasureChest : OnlineObject
{
	private TreasureChest OBJHACPHLOE;

	public void LPCCJMOOKPJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1));
	}

	public void PPICAMAGNME(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"ReceiveOfferingPuzzleSolved", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void JNHDFGMOMKA(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Not enough ingredients", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void HLLMHNPLKNN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(0));
	}

	public void OIHIJONNOBF(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Invalid seating", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void OCOGJHJCPGN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(1));
	}

	public void NOGBKJFALJE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(1));
	}

	public void DPFALNNJKFP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(1));
	}

	public void PKBFNMNMFLI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(0));
	}

	public void NABBABDCGHD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(0));
	}

	public void PDMNIFJPCDB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1));
	}

	public void PDBJPAJDGKB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(0));
	}

	public void PLIFJBMCANA(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"[MineVariantsSelector] No valid variants available for piece {0} after full pool regeneration.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void HCJKKNGMFEE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(0));
	}

	public void LBOGKGOBNDC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(1));
	}

	public void HJCOAJEIABK(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Tutorial/T101/Dialogue3", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void BKHGLAHMICE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(0));
	}

	public void NDBBBNBEEOH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(1));
	}

	public void PJANACELJFB(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Items/item_description_609", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void AGMPIBGPHFE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(0));
	}

	public void CPGKEDLBPGM(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"City/Petra/Bark/Stand", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void DBDMJOMOGHL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1));
	}

	public void Initialize(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Must have a unique ID assigned.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void PJHDECMHCIA(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"[Variants] Piece {0} ({1}) has {2} variants and {3} are active. Only 1 should be active.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void OCCMOKCMPFA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1));
	}

	public void BPABBJEEJMO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1));
	}

	public void DNNGLPLEEMJ(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"questDescFermenting", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void EOADCHLNLPK(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Talent without ID: ", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void Dig()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1));
	}

	public void EBIDJHHEMJP(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Error_MaxZones", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public void NBNCKDLELMD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, (byte)OnlinePlayerDataManager.JBDEFDMGCDA(1));
	}

	public void AJPLCFDGBLA(TreasureChest EIIGABICEIA)
	{
		OBJHACPHLOE = EIIGABICEIA;
		uniqueId = OBJHACPHLOE.uniqueID;
		if (uniqueId == 0)
		{
			Debug.LogError((object)"Items/item_description_1052", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			OnlineObjectsManager.instance.AddObjectInDictionary(this);
		}
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH != 0)
		{
			OBJHACPHLOE.OnlineDig(FACPEEACCMH);
		}
	}
}
