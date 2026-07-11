using UnityEngine;

public class OnlineDestructibleObject : OnlineObject
{
	public enum OnlineAction
	{
		MopHit
	}

	public DestructibleObject destructibleObject;

	private void LJLKBKEADGI()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				AddToDictionary();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Road | Location.Camp | Location.Quarry))
			{
				Debug.LogError((object)("ReceiveObjectInteract" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void HCEDMLJNOBL()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				PFDIEIBOFEP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Farm | Location.BarnInterior))
			{
				Debug.LogError((object)("Inventory full" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void ODKGLIDMCNP()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				JMKHLGIEGIJ();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.River | Location.BarnInterior | Location.FarmShop))
			{
				Debug.LogError((object)(" to disconnect from the game" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void NNBIAIMPNGL()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				MNONJPAPOOO();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.FarmShop))
			{
				Debug.LogError((object)("IntensitySectionCanvas/IntensitySection" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void ANPIAENICLN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void HFFFFAJFIPB()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				AddToDictionary();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior))
			{
				Debug.LogError((object)("[CrystalPuzzle] - Initialize" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void ADDMDJBOPHO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MKHOBCEDDOF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void HLJJEKJDGCC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void ODNGBEOKEFK()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				MGLBDAPBPLH();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Road | Location.River | Location.Farm | Location.FarmShop))
			{
				Debug.LogError((object)("Mouth" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void FHADDEPCEFB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BAMGLNPFOMK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void AHFGOOHOLEL()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				AddToDictionary();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				Debug.LogError((object)("ToFish" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void CEIIFHIBIFI()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				FLJHNCDAFBG();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Camp | Location.Farm))
			{
				Debug.LogError((object)("" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void LFJEDPINJNM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void JKEDODIKKAL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MHGONLCHOLI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void JLCFNPBBKEK()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				NMFLEPLJIKD();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.River | Location.Camp | Location.Farm))
			{
				Debug.LogError((object)("{0} - Deactivating variant object {1} at index {2} for piece {3}. Next variant index: {4}" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void DONOEOGPLJL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JNILKBHHHKM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void EJKCFDAJAMM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void CFIIEJDJFPB()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				MNONJPAPOOO();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.Farm | Location.BarnInterior))
			{
				Debug.LogError((object)("Bouncer/" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void PFLBPMIEKGF()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				FLJHNCDAFBG();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.Camp | Location.Farm))
			{
				Debug.LogError((object)(" " + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void IIJGJAFMOAF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	private void NCIBKMLIIAJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				JMKHLGIEGIJ();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm))
			{
				Debug.LogError((object)("No banquet barrel found with drink: " + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void BNIKICAEIND()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				MGLBDAPBPLH();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Road | Location.Camp | Location.FarmShop))
			{
				Debug.LogError((object)("Eating" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void HKGFOENINAL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void HOFKJPBBLGP()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				AddToDictionary();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Tavern | Location.Road | Location.Camp | Location.BarnInterior))
			{
				Debug.LogError((object)("Error in DogHoleManager.ResetDogHoles: " + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void BGENEAOILOF()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				FLJHNCDAFBG();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.River | Location.Camp | Location.Quarry))
			{
				Debug.LogError((object)("Error_UnableToBeReached" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				DPFBCALDJCP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				Debug.LogError((object)("GetOnlinePlaceable() not found any uniqueId " + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void LMDAMNHJFOJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void PGJJBPALEGM()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				JMKHLGIEGIJ();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Road | Location.Quarry | Location.FarmShop))
			{
				Debug.LogError((object)("bath travelling" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void EOGHJNGJFID()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				FLJHNCDAFBG();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior))
			{
				Debug.LogError((object)("itemCoconutSeeds" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void MFLCNPOLEBG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GEKELCMDIEN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MLKJBPJOEPJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	private void CAIJLMJBMLA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				MGLBDAPBPLH();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Road | Location.River | Location.FarmShop))
			{
				Debug.LogError((object)("LE_10" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void PNGLBMNLBIJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OOOGLMCCPIH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void CEBMBHNJPOC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void BNLFKLAFHJJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GHEBCANDDPA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void HLHIIOHOMHE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void HJDLNCOAKIK()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				FLJHNCDAFBG();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Tavern | Location.River | Location.Camp | Location.FarmShop))
			{
				Debug.LogError((object)("itemWater" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void DCKKIDMJKJM()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				DPFBCALDJCP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.FarmShop))
			{
				Debug.LogError((object)("Exit build mode" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void HNEGFBCKIIJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				PFDIEIBOFEP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Road | Location.River | Location.BarnInterior | Location.FarmShop))
			{
				Debug.LogError((object)("Items/item_description_620" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void GMBMFPMMNHI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	private void OLDDEAJMHNI()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				PFDIEIBOFEP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Road | Location.River | Location.FarmShop))
			{
				Debug.LogError((object)("Throw" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void Start()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				AddToDictionary();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != Location.Mine)
			{
				Debug.LogError((object)("Unique ID not set for " + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void ENIKHCEOBGM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void NKDFMFFDGKC()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				NMFLEPLJIKD();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Road | Location.River | Location.BarnInterior))
			{
				Debug.LogError((object)("Sit" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void SendMopHit()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void FPLFMKAHGGP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void HJBAMGJJGIO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void COLMANAKFOB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void CAOKPIIFHBJ()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				FLJHNCDAFBG();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Quarry | Location.Farm | Location.FarmShop))
			{
				Debug.LogError((object)("" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void NFABFPFLNEE()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				NMFLEPLJIKD();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Road | Location.Quarry | Location.FarmShop))
			{
				Debug.LogError((object)("Eat" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void MFMMHDPGCBO()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				DPFBCALDJCP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.Quarry | Location.FarmShop))
			{
				Debug.LogError((object)("Player_Bark_TutorialCollider" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void LOHAMDHOLDD()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				PFDIEIBOFEP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.River | Location.Quarry | Location.Farm))
			{
				Debug.LogError((object)("qualityWater" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void JLLLINFJNBC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void EGACIHOKJLH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 0)
			{
				MGLBDAPBPLH();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != ~(Location.Tavern | Location.Farm))
			{
				Debug.LogError((object)(":</color> " + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	private void OIAHJHNPPCO()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				FLJHNCDAFBG();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Road | Location.Farm | Location.BarnInterior))
			{
				Debug.LogError((object)("Select Theme" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		destructibleObject = ((Component)((Component)this).transform).GetComponent<DestructibleObject>();
	}

	public void KBBJGLPKHEF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 0)
		{
			destructibleObject.OnMopHit(CDPAMNIPPEC: false);
		}
	}

	public void BHFAKLJKLPG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	private void IMIONHLAKIH()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				NMFLEPLJIKD();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Road | Location.Quarry | Location.FarmShop))
			{
				Debug.LogError((object)("PhysicalSpace" + ((Object)((Component)this).gameObject).name));
			}
		}
	}

	public void ILNFAAGCJIB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	private void CHIJGHPHCNA()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (uniqueId > 1)
			{
				DPFBCALDJCP();
			}
			else if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != (Location.Tavern | Location.Camp | Location.BarnInterior))
			{
				Debug.LogError((object)("BirdInAChest_Error" + ((Object)((Component)this).gameObject).name));
			}
		}
	}
}
