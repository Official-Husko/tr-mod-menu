using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildSquare : Square
{
	[HideInInspector]
	public bool invertX;

	public bool manageCanPlaceObjects = true;

	private Vector3 CIBPOBINPHE;

	private ZoneType GIBJPCAFCJB;

	[HideInInspector]
	public bool ignoreNodes;

	public void OAIBPEEFIJB(ItemSpace HJDEBNFJIND, bool NMLKLAGDNPF, Placeable EAPCLAODGAE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameplayUI.NGIMIHFFNMH() == (Object)null))
		{
			if (!ignoreNodes)
			{
				WorldGrid.FPHAMKKBNMC(((Component)this).transform.position + offset);
			}
			if (manageCanPlaceObjects)
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position + offset, !NMLKLAGDNPF);
				WorldGrid.AAPAHBCLANN(((Component)this).transform.position + offset, !NMLKLAGDNPF);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.PCGNGKPHKLC(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			else
			{
				WorldGrid.AKLCFEPBONI(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (EAPCLAODGAE.currentLocation == Location.None && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null))
			{
				HMEHPLAENLC(NMLKLAGDNPF, EAPCLAODGAE.itemSetup.item.groundEffect, HJDEBNFJIND.placeable.currentLocation);
			}
		}
	}

	public bool LIGOLEHCFOL(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.MetalWorkshop | ZoneType.StoneWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.MetalWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.StoneWorkshop) && GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return true;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(~SpecificType.PlayerBed))
		{
			if (!WorldGrid.KELFJIPHBFP(DCAPKPOGHPK()).HasFlag(~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.NextToWall)))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(1194f, 366f) + offset).HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.StairsUp))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(1297f, 1467f) + offset).HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar)))
			{
				return true;
			}
			if (WorldGrid.KELFJIPHBFP(DCAPKPOGHPK()).HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.StairsUp | SpecificType.StairsDown))
			{
				return false;
			}
			return true;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGroundDetails) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.FHMDNECBLIL())
		{
			if (GameManager.OPGGPLEOGCG())
			{
				return true;
			}
			for (int i = 0; i < 2; i += 0)
			{
				if (NIOMKEFAKIO(i))
				{
					return true;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 35) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == ~(SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.PlayerBed))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return false;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false);
		}
		return true;
	}

	public bool ENPBNONDPLA(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.MetalWorkshop | ZoneType.StoneWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.StoneWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.DiningRoom | ZoneType.CraftingRoom)) && GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != ZoneType.WithoutZone && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.StoneWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return true;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall))
		{
			if (!WorldGrid.KELFJIPHBFP(FANOLHHEFBO()).HasFlag(SpecificType.CellarDoor))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(340f, 1799f) + offset).HasFlag(~(SpecificType.CellarDoor | SpecificType.Bar)))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(967f, 858f) + offset).HasFlag(~(SpecificType.Door | SpecificType.StairsUp | SpecificType.Bar)))
			{
				return true;
			}
			if (WorldGrid.KELFJIPHBFP(FANOLHHEFBO()).HasFlag(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.StairsDown))
			{
				return false;
			}
			return true;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.FHMDNECBLIL())
		{
			if (GameManager.NoPlayers())
			{
				return true;
			}
			for (int i = 1; i < 6; i++)
			{
				if (LPINAPKCNCO(i))
				{
					return false;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.JPNFKDMFKMC() == 168) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == (SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.PlayerBed))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return true;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset);
		}
		return true;
	}

	public bool IsValid(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.Anywhere) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.AnyWorkArea) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.Anywhere) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.AnyWorkArea) && GIBJPCAFCJB != ZoneType.WithoutZone && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != ZoneType.WithoutZone && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.AnyWorkArea))
			{
				return false;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.Anywhere) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return false;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(SpecificType.ServiceBarrel))
		{
			if (!WorldGrid.KELFJIPHBFP(GetCentrePosition()).HasFlag(SpecificType.Bar))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(-1f, 0f) + offset).HasFlag(SpecificType.Bar))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(0.5f, 0f) + offset).HasFlag(SpecificType.Bar))
			{
				return false;
			}
			if (WorldGrid.KELFJIPHBFP(GetCentrePosition()).HasFlag(SpecificType.ServiceBarrel))
			{
				return false;
			}
			return true;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGrass) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.CCIKENEGHCA)
		{
			if (GameManager.NoPlayers())
			{
				return false;
			}
			for (int i = 1; i < 5; i++)
			{
				if (LPINAPKCNCO(i))
				{
					return false;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.JDJGFAACPFC() == 1230) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == SpecificType.Seat)
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return true;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset);
		}
		return true;
	}

	public ZoneType IOLGJHAFIKC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
	}

	public void GFGPHHEBJBL()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 438f;
		}
	}

	private bool DEAMHLFAKHL(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return true;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > LHJHAMOOGBM().x && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > GetTilePosition().y && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x <= DGIIFLPHIEK().x + 1020f)
		{
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y <= CLAGGKKKFIC().y + 945f;
		}
		return false;
	}

	public void JNKIBHBHIAO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 1058f;
		}
	}

	public void IIOHMDNGFDH()
	{
		CKGJMFMIFHL();
	}

	private void GBDFJHEDEHH(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.GenerateGrass:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case GroundEffect.GenerateGrassDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			case GroundEffect.None:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK);
				}
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.None:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.TilledEarth, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.GenerateGroundDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			case GroundEffect.GenerateGrass:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.Ground))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == (GroundEffect)7 || CHNGLEDEDFG == GroundEffect.GenerateGround || CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
			}
		}
	}

	public bool HPEHHOIMMOB(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return true;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.CraftingRoom | ZoneType.RentedRoom)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop)) && GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return true;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != ZoneType.WithoutZone && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop)))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.StoneWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return true;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(SpecificType.Door | SpecificType.Bar | SpecificType.NextToWall))
		{
			if (!WorldGrid.KELFJIPHBFP(GetCentrePosition()).HasFlag(~(SpecificType.RoomDoor | SpecificType.Bar | SpecificType.PlayerBed)))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(1079f, 621f) + offset).HasFlag(~(SpecificType.RoomDoor | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(287f, 836f) + offset).HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				return false;
			}
			if (WorldGrid.KELFJIPHBFP(CBALBDIFOGF()).HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.NextToWall))
			{
				return false;
			}
			return true;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGroundDetails) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return true;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.FHMDNECBLIL())
		{
			if (GameManager.OPGGPLEOGCG())
			{
				return true;
			}
			for (int i = 0; i < 4; i += 0)
			{
				if (DEAMHLFAKHL(i))
				{
					return false;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.JDJGFAACPFC() == -179) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == (SpecificType.RoomDoor | SpecificType.Bar | SpecificType.StairsDown))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return true;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset);
		}
		return true;
	}

	private bool HMCJBCKJALC(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > GetTilePosition().x && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > EEIOMIBKLGJ().y && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x <= FMIAJFOBOEH().x + 1814f)
		{
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y <= CPPBAHGKNMD().y + 745f;
		}
		return false;
	}

	private void JKOJPPJNACG(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.RemoveDetails:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.GenerateGrass:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Ground)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.GenerateGrassDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Ground)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK);
				}
				break;
			case GroundEffect.GenerateGround:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, BAIMHDBJPDK);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.GenerateGroundDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, BAIMHDBJPDK);
				}
				break;
			default:
				if (CHNGLEDEDFG == GroundEffect.GenerateGrassDetails && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Ground)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == GroundEffect.RemoveDetails || CHNGLEDEDFG == GroundEffect.GenerateGrass || CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
			}
		}
	}

	public void HBOKFFLGDKI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 1350f;
		}
	}

	public void CKGJMFMIFHL()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 1227f;
		}
	}

	private bool INKABCDECKI(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return true;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > NECKEGAJPOO().x && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > CPPBAHGKNMD().y && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x <= EEIOMIBKLGJ().x + 864f)
		{
			return !(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y <= EAACFPHCPNF().y + 356f);
		}
		return false;
	}

	public bool IBFAAHDLGHO(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return true;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop)) && GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return true;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return false;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar)))
		{
			if (!WorldGrid.KELFJIPHBFP(FGGMIOHMGFL()).HasFlag(SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(227f, 1153f) + offset).HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(1010f, 719f) + offset).HasFlag(SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed))
			{
				return false;
			}
			if (WorldGrid.KELFJIPHBFP(KDFECDEEDHL()).HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return false;
			}
			return true;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.None || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == (GroundEffect)7) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return true;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.CCIKENEGHCA)
		{
			if (GameManager.NoPlayers())
			{
				return true;
			}
			for (int i = 1; i < 5; i++)
			{
				if (CAHPNKEJJAP(i))
				{
					return false;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.JPNFKDMFKMC() == 154) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == ~(SpecificType.RoomDoor | SpecificType.Bar))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return true;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false);
		}
		return true;
	}

	public void LIGFAEHADNL(ItemSpace HJDEBNFJIND, bool NMLKLAGDNPF, Placeable EAPCLAODGAE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameplayUI.GGFJGHHHEJC == (Object)null))
		{
			if (!ignoreNodes)
			{
				WorldGrid.FPHAMKKBNMC(((Component)this).transform.position + offset);
			}
			if (manageCanPlaceObjects)
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position + offset, NMLKLAGDNPF);
				WorldGrid.AAPAHBCLANN(((Component)this).transform.position + offset, NMLKLAGDNPF);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.PCGNGKPHKLC(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			else
			{
				WorldGrid.AKLCFEPBONI(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (EAPCLAODGAE.currentLocation == (Location.Tavern | Location.Road | Location.River) && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null))
			{
				JKOJPPJNACG(NMLKLAGDNPF, EAPCLAODGAE.itemSetup.item.groundEffect, HJDEBNFJIND.placeable.currentLocation);
			}
		}
	}

	public bool EDPEDOLADPI(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.StoneWorkshop) && GIBJPCAFCJB != ZoneType.WithoutZone && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return true;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return false;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(~(SpecificType.CellarDoor | SpecificType.NextToWall)))
		{
			if (!WorldGrid.KELFJIPHBFP(DCAPKPOGHPK()).HasFlag(~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed)))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(858f, 1389f) + offset).HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(156f, 712f) + offset).HasFlag(~(SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return true;
			}
			if (WorldGrid.KELFJIPHBFP(CBALBDIFOGF()).HasFlag(SpecificType.Door | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				return true;
			}
			return false;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.None || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGroundDetails) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return true;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.FHMDNECBLIL())
		{
			if (GameManager.OPGGPLEOGCG())
			{
				return true;
			}
			for (int i = 0; i < 3; i += 0)
			{
				if (CAHPNKEJJAP(i))
				{
					return true;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.CIGFGKKCPCK() == 37) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == ~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.StairsUp | SpecificType.PlayerBed))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return false;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset);
		}
		return true;
	}

	private bool KOOCALDJLPF(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return true;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > CPPBAHGKNMD().x && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > FMIAJFOBOEH().y && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x <= DGIIFLPHIEK().x + 1898f)
		{
			return !(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y <= EEIOMIBKLGJ().y + 725f);
		}
		return true;
	}

	private bool NIOMKEFAKIO(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return true;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > CLAGGKKKFIC().x && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > LHJHAMOOGBM().y && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x <= BDHOPKNNAND().x + 712f)
		{
			return !(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y <= NECKEGAJPOO().y + 253f);
		}
		return true;
	}

	private bool LPINAPKCNCO(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > GetTilePosition().x && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > GetTilePosition().y && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x <= GetTilePosition().x + 0.5f)
		{
			return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y <= GetTilePosition().y + 0.5f;
		}
		return false;
	}

	protected override void Awake()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		base.Awake();
		CIBPOBINPHE = offset;
	}

	public ZoneType GOEKOFOAFFK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
	}

	public ZoneType LELHBKPLIGJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
	}

	public void MGMLDHPOLGK()
	{
		BHNCBKCJFPK();
	}

	private void OEEHEIPKGBL(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.GenerateGrass:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case GroundEffect.None:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Ground)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Floor)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.None:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground | GroundType.TilledEarth, BAIMHDBJPDK, Season.Summer);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				break;
			case GroundEffect.GenerateGround:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Floor, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			case (GroundEffect)7:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == (GroundEffect)8 || CHNGLEDEDFG == GroundEffect.RemoveDetails || CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
			}
		}
	}

	public void HEBOOLOBEAN(ItemSpace HJDEBNFJIND, bool NMLKLAGDNPF, Placeable EAPCLAODGAE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameplayUI.DGCNCEDIFOF() == (Object)null))
		{
			if (!ignoreNodes)
			{
				WorldGrid.FPHAMKKBNMC(((Component)this).transform.position + offset);
			}
			if (manageCanPlaceObjects)
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position + offset, !NMLKLAGDNPF);
				WorldGrid.AAPAHBCLANN(((Component)this).transform.position + offset, !NMLKLAGDNPF);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.PCGNGKPHKLC(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			else
			{
				WorldGrid.AKLCFEPBONI(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (EAPCLAODGAE.currentLocation == (Location.Tavern | Location.River) && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null))
			{
				BELAMJDJNIP(NMLKLAGDNPF, EAPCLAODGAE.itemSetup.item.groundEffect, HJDEBNFJIND.placeable.currentLocation);
			}
		}
	}

	private bool KKLBBOLKADH(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > PMGANCLAFGA().x && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > LHJHAMOOGBM().y && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x <= PPCNGEDDIAI().x + 1647f)
		{
			return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y <= GetTilePosition().y + 1254f;
		}
		return false;
	}

	public void BNIAAJEBPNP(ItemSpace HJDEBNFJIND, bool NMLKLAGDNPF, Placeable EAPCLAODGAE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameplayUI.DBJCACLEFGK() == (Object)null))
		{
			if (!ignoreNodes)
			{
				WorldGrid.FPHAMKKBNMC(((Component)this).transform.position + offset);
			}
			if (manageCanPlaceObjects)
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position + offset, NMLKLAGDNPF);
				WorldGrid.AAPAHBCLANN(((Component)this).transform.position + offset, !NMLKLAGDNPF);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.PCGNGKPHKLC(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			else
			{
				WorldGrid.AKLCFEPBONI(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (EAPCLAODGAE.currentLocation == Location.Camp && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null))
			{
				EMJLGOFCACJ(NMLKLAGDNPF, EAPCLAODGAE.itemSetup.item.groundEffect, HJDEBNFJIND.placeable.currentLocation);
			}
		}
	}

	private void JAEGOLINCOO(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case (GroundEffect)8:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case (GroundEffect)6:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case (GroundEffect)6:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer);
				}
				break;
			case GroundEffect.GenerateGround:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.TilledEarth, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				break;
			case (GroundEffect)7:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground | GroundType.TilledEarth, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				break;
			case GroundEffect.RemoveDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Floor)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == (GroundEffect)7 || CHNGLEDEDFG == GroundEffect.RemoveDetails || CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
			}
		}
	}

	public ZoneType PBEIOKCCDAE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
	}

	private bool JJLONOJIKBH(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return true;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > EEIOMIBKLGJ().x && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > FMIAJFOBOEH().y && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x <= CLAGGKKKFIC().x + 219f)
		{
			return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y <= CLAGGKKKFIC().y + 547f;
		}
		return true;
	}

	public void IPIKPJKKKEM(ItemSpace HJDEBNFJIND, bool NMLKLAGDNPF, Placeable EAPCLAODGAE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameplayUI.NGIMIHFFNMH() == (Object)null))
		{
			if (!ignoreNodes)
			{
				WorldGrid.FPHAMKKBNMC(((Component)this).transform.position + offset);
			}
			if (manageCanPlaceObjects)
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position + offset, NMLKLAGDNPF);
				WorldGrid.AAPAHBCLANN(((Component)this).transform.position + offset, !NMLKLAGDNPF);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.PCGNGKPHKLC(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			else
			{
				WorldGrid.AKLCFEPBONI(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (EAPCLAODGAE.currentLocation == Location.None && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null))
			{
				EMJLGOFCACJ(NMLKLAGDNPF, EAPCLAODGAE.itemSetup.item.groundEffect, HJDEBNFJIND.placeable.currentLocation);
			}
		}
	}

	public bool BNPNHMOAGCC(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.StoneWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.CraftingRoom | ZoneType.Cellar)) && GIBJPCAFCJB != ZoneType.WithoutZone && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.StoneWorkshop))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.RentedRoom) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return true;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(SpecificType.Door | SpecificType.RoomDoor | SpecificType.NextToWall))
		{
			if (!WorldGrid.KELFJIPHBFP(KGGGPHEMLII()).HasFlag(SpecificType.StairsUp | SpecificType.PlayerBed))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(23f, 435f) + offset).HasFlag(SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(1117f, 609f) + offset).HasFlag(~(SpecificType.Door | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return false;
			}
			if (WorldGrid.KELFJIPHBFP(GetCentrePosition()).HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return true;
			}
			return false;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == (GroundEffect)7) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return true;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.FHMDNECBLIL())
		{
			if (GameManager.CAGIBNLHJBN())
			{
				return true;
			}
			for (int i = 0; i < 1; i += 0)
			{
				if (NIOMKEFAKIO(i))
				{
					return false;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.ODENMDOJPLC() == 54) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == ~(SpecificType.Door | SpecificType.Bar | SpecificType.StairsDown))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return false;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false);
		}
		return true;
	}

	public void Update()
	{
		CheckNegativeScale();
	}

	private bool EFBGGKILKBE(Transform HMDKCHKIAHD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (HMDKCHKIAHD.position.x > EEIOMIBKLGJ().x && HMDKCHKIAHD.position.y > NECKEGAJPOO().y && HMDKCHKIAHD.position.x <= PMGANCLAFGA().x + 1256f)
		{
			return HMDKCHKIAHD.position.y <= CHBNAPAIFIE().y + 419f;
		}
		return false;
	}

	private bool NCMHKAOFEII(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > CHBNAPAIFIE().x && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > GetTilePosition().y && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x <= GetTilePosition().x + 1875f)
		{
			return !(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y <= PMGANCLAFGA().y + 447f);
		}
		return false;
	}

	public ZoneType AILFENLBNON()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
	}

	private void BELAMJDJNIP(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.GenerateGrassDetails:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case GroundEffect.GenerateGrass:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			case GroundEffect.GenerateGround:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.GenerateGround:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				break;
			case GroundEffect.GenerateGrass:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground | GroundType.TilledEarth, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			case GroundEffect.None:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Ground)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == GroundEffect.GenerateGrassDetails || CHNGLEDEDFG == GroundEffect.GenerateGroundDetails || CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
			}
		}
	}

	private bool KNFLDFPPMKF(Transform HMDKCHKIAHD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (HMDKCHKIAHD.position.x > CLAGGKKKFIC().x && HMDKCHKIAHD.position.y > EEIOMIBKLGJ().y && HMDKCHKIAHD.position.x <= PMGANCLAFGA().x + 848f)
		{
			return !(HMDKCHKIAHD.position.y <= BDHOPKNNAND().y + 1291f);
		}
		return true;
	}

	public void LEONHPICEDK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 202f;
		}
	}

	private bool FOCMFCJDIBK(Transform HMDKCHKIAHD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (HMDKCHKIAHD.position.x > GetTilePosition().x && HMDKCHKIAHD.position.y > GetTilePosition().y && HMDKCHKIAHD.position.x <= GetTilePosition().x + 0.5f)
		{
			return HMDKCHKIAHD.position.y <= GetTilePosition().y + 0.5f;
		}
		return false;
	}

	public bool OMKBIHKANLI(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~ZoneType.MetalWorkshop) && GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return true;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != ZoneType.WithoutZone && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return true;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(~(SpecificType.Door | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.StairsDown)))
		{
			if (!WorldGrid.KELFJIPHBFP(FANOLHHEFBO()).HasFlag(~(SpecificType.CellarDoor | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return true;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(203f, 1652f) + offset).HasFlag(SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.PlayerBed))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(421f, 981f) + offset).HasFlag(SpecificType.StairsUp))
			{
				return false;
			}
			if (WorldGrid.KELFJIPHBFP(FGGMIOHMGFL()).HasFlag(~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return false;
			}
			return false;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.None) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return true;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.CCIKENEGHCA)
		{
			if (GameManager.NoPlayers())
			{
				return true;
			}
			for (int i = 1; i < 1; i += 0)
			{
				if (INKABCDECKI(i))
				{
					return true;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 3) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == ~(SpecificType.Door | SpecificType.RoomDoor | SpecificType.PlayerBed))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return true;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset);
		}
		return false;
	}

	public void JLPLLHKJEMH()
	{
		GLGDKGPKACO();
	}

	public void GLGDKGPKACO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 828f;
		}
	}

	private bool OHKPEKHMIFN(Transform HMDKCHKIAHD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (HMDKCHKIAHD.position.x > CPPBAHGKNMD().x && HMDKCHKIAHD.position.y > JGPJPOPDNGI().y && HMDKCHKIAHD.position.x <= PPCNGEDDIAI().x + 1289f)
		{
			return !(HMDKCHKIAHD.position.y <= CLAGGKKKFIC().y + 1733f);
		}
		return false;
	}

	public ZoneType GetZoneType()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
	}

	public void HIPNEFOEJPL()
	{
		CheckNegativeScale();
	}

	public void AKLEFPLEGKK()
	{
		JNKIBHBHIAO();
	}

	private bool PCPFOIIALII(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > CLAGGKKKFIC().x && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > PMGANCLAFGA().y && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x <= FMIAJFOBOEH().x + 302f)
		{
			return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y <= EAACFPHCPNF().y + 60f;
		}
		return false;
	}

	public void EJEEIIGEGOC()
	{
		CKGJMFMIFHL();
	}

	public void CCIJKOLGILP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 755f;
		}
	}

	public bool MBHNNMJBCFC(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.StoneWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.DiningRoom | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.StoneWorkshop) && GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.MetalWorkshop))
			{
				return false;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.CraftingRoom | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return true;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(SpecificType.Door | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.StairsDown))
		{
			if (!WorldGrid.KELFJIPHBFP(BOBEIFEGLOL()).HasFlag(~SpecificType.StairsUp))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(731f, 1100f) + offset).HasFlag(~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall)))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(1212f, 1465f) + offset).HasFlag(~(SpecificType.RoomDoor | SpecificType.Bar)))
			{
				return false;
			}
			if (WorldGrid.KELFJIPHBFP(FGGMIOHMGFL()).HasFlag(SpecificType.None))
			{
				return false;
			}
			return false;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == (GroundEffect)8) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.FHMDNECBLIL())
		{
			if (GameManager.CAGIBNLHJBN())
			{
				return false;
			}
			for (int i = 1; i < 4; i += 0)
			{
				if (CAHPNKEJJAP(i))
				{
					return true;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 95) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == (SpecificType.CellarDoor | SpecificType.StairsUp | SpecificType.PlayerBed))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return true;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false);
		}
		return true;
	}

	public void CheckNegativeScale()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= -1f;
		}
	}

	public void BHNCBKCJFPK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 1057f;
		}
	}

	public void IOIKGHMGBIA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		offset = CIBPOBINPHE;
		if (invertX)
		{
			offset.x *= 100f;
		}
	}

	private void KJHOBJMJIHP(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case (GroundEffect)7:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case GroundEffect.GenerateGrassDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Ground | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case (GroundEffect)8:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Summer);
				}
				return;
			case GroundEffect.GenerateGround:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground, BAIMHDBJPDK, Season.Summer);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case (GroundEffect)7:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Summer);
				}
				break;
			case (GroundEffect)6:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == GroundEffect.RemoveDetails || CHNGLEDEDFG == GroundEffect.RemoveDetails || CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
			}
		}
	}

	public void Place(ItemSpace HJDEBNFJIND, bool NMLKLAGDNPF, Placeable EAPCLAODGAE)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameplayUI.GGFJGHHHEJC == (Object)null))
		{
			if (!ignoreNodes)
			{
				WorldGrid.FPHAMKKBNMC(((Component)this).transform.position + offset);
			}
			if (manageCanPlaceObjects)
			{
				WorldGrid.CFAHJNLAJNK(((Component)this).transform.position + offset, !NMLKLAGDNPF);
				WorldGrid.AAPAHBCLANN(((Component)this).transform.position + offset, !NMLKLAGDNPF);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.PCGNGKPHKLC(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			else
			{
				WorldGrid.AKLCFEPBONI(((Component)this).transform.position + offset, HJDEBNFJIND.placeable);
			}
			if (NMLKLAGDNPF)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (EAPCLAODGAE.currentLocation == Location.Road && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null))
			{
				JKOJPPJNACG(NMLKLAGDNPF, EAPCLAODGAE.itemSetup.item.groundEffect, HJDEBNFJIND.placeable.currentLocation);
			}
		}
	}

	private void EMJLGOFCACJ(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			if (CHNGLEDEDFG == GroundEffect.RemoveDetails)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.RemoveDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			case GroundEffect.GenerateGrassDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer);
				}
				return;
			case GroundEffect.None:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.None:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground, BAIMHDBJPDK, Season.Summer);
				}
				break;
			case (GroundEffect)8:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == GroundEffect.GenerateGrassDetails || CHNGLEDEDFG == GroundEffect.GenerateGrassDetails || CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
			}
		}
	}

	private bool CAHPNKEJJAP(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x > NECKEGAJPOO().x && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > CHBNAPAIFIE().y && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.x <= GetTilePosition().x + 1129f)
		{
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y <= CLAGGKKKFIC().y + 196f;
		}
		return true;
	}

	private bool JBBKPKNLOBE(int JIIGOACEIKL)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return false;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x > CLAGGKKKFIC().x && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > PMGANCLAFGA().y && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.x <= LHJHAMOOGBM().x + 1438f)
		{
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y <= EAACFPHCPNF().y + 1019f;
		}
		return false;
	}

	public ZoneType ENGMBLNEDDE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
	}

	private void NFNBPDNBIHM(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case (GroundEffect)8:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				break;
			case GroundEffect.GenerateGroundDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.RemoveDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer);
				}
				break;
			case GroundEffect.GenerateGround:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.TilledEarth, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.None:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			default:
				if (CHNGLEDEDFG == GroundEffect.GenerateGround && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.Ground))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == (GroundEffect)6 || CHNGLEDEDFG == (GroundEffect)7 || CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
			}
			if (CHNGLEDEDFG == GroundEffect.GenerateGround)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
			}
		}
	}

	private void BKFIJLKLHJF(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case (GroundEffect)8:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.GenerateGroundDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Ground | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				break;
			case GroundEffect.GenerateGrass:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			case GroundEffect.None:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground | GroundType.TilledEarth, BAIMHDBJPDK);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				break;
			case GroundEffect.RemoveDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			case (GroundEffect)6:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == GroundEffect.GenerateGrass || CHNGLEDEDFG == (GroundEffect)7 || CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
			}
		}
	}

	private void NHNHPNPFKAE(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.GenerateGroundDetails:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case GroundEffect.GenerateGround:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			case GroundEffect.RemoveDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.Ground))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				return;
			case GroundEffect.None:
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			}
			if (CHNGLEDEDFG == GroundEffect.GenerateGroundDetails)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
			}
			else if (CHNGLEDEDFG == GroundEffect.GenerateGroundDetails && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
			{
				WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
			}
		}
		else
		{
			if (CHNGLEDEDFG == GroundEffect.GenerateGroundDetails || CHNGLEDEDFG == GroundEffect.GenerateGroundDetails || CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: true);
			}
		}
	}

	private void HMEHPLAENLC(bool NMLKLAGDNPF, GroundEffect CHNGLEDEDFG, Location BAIMHDBJPDK)
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		if (NMLKLAGDNPF)
		{
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.GenerateGround:
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case GroundEffect.RemoveDetails:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Ground | GroundType.TilledEarth))
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
				return;
			case GroundEffect.None:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK);
				}
				return;
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground | GroundType.TilledEarth, BAIMHDBJPDK, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: false);
				return;
			}
			switch (CHNGLEDEDFG)
			{
			case GroundEffect.None:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, BAIMHDBJPDK, Season.Summer);
				}
				break;
			case (GroundEffect)8:
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass, BAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
				}
				break;
			}
		}
		else
		{
			if (CHNGLEDEDFG == (GroundEffect)7 || CHNGLEDEDFG == (GroundEffect)6 || CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.JEEPIKKPBFI(((Component)this).transform.position + offset, NKFPJPCFBJI: true);
			}
			if (CHNGLEDEDFG == GroundEffect.None)
			{
				WorldGrid.OIIPHEICEAN(((Component)this).transform.position + offset, GIDOELBFLJH: false);
			}
		}
	}

	public bool OPIIEJKANJC(ItemSpace HJDEBNFJIND, bool FCILKADOPNE, bool CPKIGCHMGLN, SpecificType CPPHBDEOJEC, bool MAEMOHMDGGN, bool GBNEPPJNIDI)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		GIBJPCAFCJB = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if (!CPKIGCHMGLN)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.MetalWorkshop) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return true;
			}
		}
		else if (FCILKADOPNE)
		{
			if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
			{
				return false;
			}
		}
		else if ((Object)(object)HJDEBNFJIND.placeable.areaSpace != (Object)null)
		{
			if (GIBJPCAFCJB != 0 && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(GIBJPCAFCJB) && !HJDEBNFJIND.placeable.areaSpace.zoneType.HasFlag(ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop))
			{
				return true;
			}
		}
		else if (!HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(~(ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.MetalWorkshop)) && !HJDEBNFJIND.placeable.zoneTypeNeeded.HasFlag(GIBJPCAFCJB))
		{
			return true;
		}
		if (HJDEBNFJIND.placeable.specificRules.HasFlag(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.PlayerBed | SpecificType.NextToWall))
		{
			if (!WorldGrid.KELFJIPHBFP(EHGDHOMFDGM()).HasFlag(~(SpecificType.CellarDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.NextToWall)))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(258f, 1783f) + offset).HasFlag(~(SpecificType.CellarDoor | SpecificType.Door)))
			{
				return false;
			}
			if (!WorldGrid.KELFJIPHBFP(((Component)this).transform.position + new Vector3(518f, 11f) + offset).HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.PlayerBed))
			{
				return true;
			}
			if (WorldGrid.KELFJIPHBFP(KGGGPHEMLII()).HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.PlayerBed | SpecificType.StairsDown)))
			{
				return false;
			}
			return true;
		}
		if (Object.op_Implicit((Object)(object)HJDEBNFJIND.placeable.itemSetup.item) && (HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.GenerateGround || HJDEBNFJIND.placeable.itemSetup.item.groundEffect == GroundEffect.None) && !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || (GBNEPPJNIDI && WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset)))
		{
			return true;
		}
		if (!HJDEBNFJIND.placeable.groundTypeNeeded.HasFlag(WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (!HJDEBNFJIND.placeable.attachedToPlayer && !HJDEBNFJIND.placeable.CCIKENEGHCA)
		{
			if (GameManager.NoPlayers())
			{
				return true;
			}
			for (int i = 0; i < 4; i++)
			{
				if (PCPFOIIALII(i))
				{
					return false;
				}
			}
		}
		if (MAEMOHMDGGN && Object.op_Implicit((Object)(object)Utils.GCGNCHFNEBJ<TileBase>((HJDEBNFJIND.placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -94) ? GameTileMaps.GGFJGHHHEJC.barnConstructionPositionsTilemap : GameTileMaps.GGFJGHHHEJC.henHouseConstructionPositionsTilemap, ((Component)this).transform.position + offset)))
		{
			return false;
		}
		if (CPKIGCHMGLN)
		{
			if (CPPHBDEOJEC == ~(SpecificType.RoomDoor | SpecificType.StairsUp))
			{
				if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
				{
					return WorldGrid.HLGNIMNEKAL(((Component)this).transform.position + offset, HJDEBNFJIND.placeable.GetDirection());
				}
				return true;
			}
			return WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false);
		}
		return false;
	}
}
