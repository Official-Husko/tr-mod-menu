using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AreaSquare : Square
{
	public AreaSpace areaSpace;

	[SerializeField]
	private bool showSquare = true;

	private List<Placeable> KCJIMDFEBBL;

	private bool PCGNHMPADGE;

	private ZoneType GFBDMNKHKKF;

	private bool MFHGPMNGELB;

	public bool KNODLFFBOEK
	{
		get
		{
			return MFHGPMNGELB;
		}
		set
		{
			((Renderer)sr).enabled = !value;
			MFHGPMNGELB = value;
		}
	}

	[SpecialName]
	public void LMFKIFGFHFD(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = !AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	public bool IsValid()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = !WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) && !WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) && !WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) && WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) && (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Ground);
		if (!PCGNHMPADGE)
		{
			return false;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return false;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != ZoneType.WithoutZone)
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 0; i < KCJIMDFEBBL.Count; i++)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.Anywhere) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.AnyWorkArea) || areaSpace.zoneType == ZoneType.WithoutZone) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return false;
						}
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public void EHGFFELHNKJ()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (CGGBKGLEHKF())
		{
			EKDNMBKHBPI(JLJJNJEMOIG());
		}
		else
		{
			FOBEHKFOMPB(ACJFIEKCKEC: false, 1158f);
		}
	}

	private Color BPCPKAGFDDA()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 1795f);
		}
		return new Color(112f, 1704f, 644f, 1462f);
	}

	public void OBEHIBAFFCN()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			FJAODMJMNGK(AODONKKHPBP: true);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				NDNEAIFEKBK(AODONKKHPBP: false);
			}
			if (AEBCPMPMCCG() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				GDGEJGKMNII(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			NDNEAIFEKBK(AODONKKHPBP: true);
		}
	}

	[SpecialName]
	public void NDNEAIFEKBK(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = !AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	public void GNPMCOAMKCO(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		LJIKHMDFBEJ();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				GEBHAANCNFF(new Color(1271f, 475f, 379f, 350f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				OLCHHCPMGDN(new Color(1487f, 763f, 651f, 186f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.FKPFLPGIHIC(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				ILNKNMEBHLA(new Color(712f, 1230f, 1136f, 1142f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				EKDNMBKHBPI(AIJBLCBIDLP());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				HAEPFHJCGEE(AIJBLCBIDLP());
			}
			else
			{
				ILNKNMEBHLA(new Color(1634f, 1409f, 1060f, 1498f));
			}
		}
	}

	public void ShowSquare()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			KNODLFFBOEK = true;
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				KNODLFFBOEK = false;
			}
			if (IsValid() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				KNODLFFBOEK = true;
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			KNODLFFBOEK = false;
		}
	}

	private Color EBGHGGJNPHG()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 756f);
		}
		return new Color(1024f, 1224f, 128f, 785f);
	}

	public bool FMIGGMHHJNM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = !WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) && !WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) && !WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) && WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) && (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth);
		if (!PCGNHMPADGE)
		{
			return true;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return false;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != ZoneType.WithoutZone)
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 0; i < KCJIMDFEBBL.Count; i++)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar)) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) || areaSpace.zoneType == ZoneType.None) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return false;
						}
						continue;
					}
					return true;
				}
				return true;
			}
			return true;
		}
		return true;
	}

	[SpecialName]
	public bool NNNBJLPFIMB()
	{
		return MFHGPMNGELB;
	}

	public void JODINHPEBGE(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground, Location.River, Season.Summer);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.None, -1, EIPNNOCMLFN: true);
		}
	}

	private Color KGOABNAEGEM()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 1777f);
		}
		return new Color(1461f, 104f, 728f, 1936f);
	}

	public void ACBFEOMDFNF(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ShowSquare();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				HAEPFHJCGEE(new Color(595f, 1319f, 1045f, 556f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				EKDNMBKHBPI(new Color(210f, 179f, 1507f, 1487f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.MJMHLAABFNP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				ILNKNMEBHLA(new Color(1571f, 975f, 1213f, 895f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				ILNKNMEBHLA(BGHNDGJFDJB());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				EKDNMBKHBPI(IIHCABLCCCB());
			}
			else
			{
				GEBHAANCNFF(new Color(1548f, 582f, 1266f, 1808f));
			}
		}
	}

	[SpecialName]
	public void GDGEJGKMNII(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = !AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	private void KACEOJDPLKB()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = true;
		}
	}

	public void HBBHIFNDCDG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			IIJKGPKCEBL(AODONKKHPBP: true);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				EHPBMPPJICB(AODONKKHPBP: false);
			}
			if (AEBCPMPMCCG() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				EHPBMPPJICB(AODONKKHPBP: false);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			HBELMPILGNG(AODONKKHPBP: true);
		}
	}

	public void AOGGEACOLCH(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ANFIJOAJEND();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				ILNKNMEBHLA(new Color(1852f, 1483f, 1938f, 391f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				HAEPFHJCGEE(new Color(1978f, 1426f, 1086f, 1635f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.PECKOFJCBAI(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				ILNKNMEBHLA(new Color(1840f, 223f, 1428f, 301f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.StoneWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				EKDNMBKHBPI(BPCPKAGFDDA());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				OLCHHCPMGDN(AIJBLCBIDLP());
			}
			else
			{
				DJKEOFPBDOI(new Color(1049f, 724f, 1232f, 1035f));
			}
		}
	}

	private void IDHCFOCEPMD()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = true;
		}
	}

	public bool CGGBKGLEHKF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = !WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) && !WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) && !WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) && WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) && (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth));
		if (!PCGNHMPADGE)
		{
			return true;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return false;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != 0)
		{
			return true;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 1; i < KCJIMDFEBBL.Count; i++)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop) || areaSpace.zoneType == ZoneType.None) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return true;
						}
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public void ACFHAEDFLPH(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType, -1, EIPNNOCMLFN: true);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, Location.Tavern | Location.Road | Location.River, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: true, BBHMAKKPFKB: false);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone, -1, EIPNNOCMLFN: true);
		}
	}

	public void FKDAEAPEEPP(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ShowSquare();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				EKDNMBKHBPI(new Color(952f, 1849f, 395f, 390f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				MCPLANAPGEE(new Color(1908f, 1683f, 1292f, 1032f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.FKPFLPGIHIC(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				ILNKNMEBHLA(new Color(1003f, 276f, 76f, 1025f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop) && areaSpace.zoneType != 0)
			{
				EKDNMBKHBPI(KGOABNAEGEM());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				DJKEOFPBDOI(EBGHGGJNPHG());
			}
			else
			{
				ILNKNMEBHLA(new Color(1386f, 1413f, 1316f, 1113f));
			}
		}
	}

	public void BALBGDIODFF()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			FJAODMJMNGK(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				DDFMKOHBCKL(AODONKKHPBP: true);
			}
			if (CGGBKGLEHKF() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				KNODLFFBOEK = true;
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			EHPBMPPJICB(AODONKKHPBP: true);
		}
	}

	private void IOINOMJHICB()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = false;
		}
	}

	private void NNBIAIMPNGL()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = false;
		}
	}

	[SpecialName]
	public void FBGDNAHJBAL(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	private void HPIMHEMJMAA()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = true;
		}
	}

	public void MBOOCABFNJC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			FJAODMJMNGK(AODONKKHPBP: true);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				GDGEJGKMNII(AODONKKHPBP: false);
			}
			if (CGGBKGLEHKF() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				DDFMKOHBCKL(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			KNODLFFBOEK = true;
		}
	}

	[SpecialName]
	public bool EIJEFOCBHPO()
	{
		return MFHGPMNGELB;
	}

	private Color IIHCABLCCCB()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 849f);
		}
		return new Color(791f, 588f, 26f, 1553f);
	}

	public void KMABNPJACAF()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (HFONDEBDCBN())
		{
			SetColor(EBGHGGJNPHG());
		}
		else
		{
			MGCHMMFFBJA(ACJFIEKCKEC: true, 1362f);
		}
	}

	public void CheckIsValidWhileNotSelected(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ShowSquare();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				SetColor(new Color(0f, 0f, 0f, 0f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				SetColor(new Color(0f, 0f, 0f, 0f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.IsInValidLocation(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				SetColor(new Color(0f, 0f, 0f, 0f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == ZoneType.AnyWorkArea && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				SetColor(NNHDHFEAMEG());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				SetColor(NNHDHFEAMEG());
			}
			else
			{
				SetColor(new Color(0f, 0f, 0f, 0f));
			}
		}
	}

	public void LPJPMNMOCNJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			NDNEAIFEKBK(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				FJAODMJMNGK(AODONKKHPBP: false);
			}
			if (AFGNKFCDFBN() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				EHPBMPPJICB(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			NDNEAIFEKBK(AODONKKHPBP: true);
		}
	}

	public void KDKHAPBNHHM(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		MHIGFLPPFFM();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				DJKEOFPBDOI(new Color(704f, 891f, 1752f, 1164f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				EKDNMBKHBPI(new Color(128f, 1677f, 169f, 1694f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.ACHNOOLHJAP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				MCPLANAPGEE(new Color(376f, 1600f, 875f, 864f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop) && areaSpace.zoneType != 0)
			{
				DJKEOFPBDOI(BPCPKAGFDDA());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				HAEPFHJCGEE(KGOABNAEGEM());
			}
			else
			{
				EKDNMBKHBPI(new Color(240f, 1379f, 605f, 689f));
			}
		}
	}

	private void ODKGLIDMCNP()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = true;
		}
	}

	public void EGOMDBKKODO(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ODBOONCJKAC();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				GEBHAANCNFF(new Color(1551f, 80f, 1527f, 1447f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				GEBHAANCNFF(new Color(1714f, 1474f, 1762f, 980f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.PECKOFJCBAI(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				EKDNMBKHBPI(new Color(1802f, 704f, 1101f, 1069f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && areaSpace.zoneType != 0)
			{
				HAEPFHJCGEE(BGHNDGJFDJB());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				HAEPFHJCGEE(GKOFGLGJDKI());
			}
			else
			{
				EKDNMBKHBPI(new Color(1376f, 653f, 1088f, 1047f));
			}
		}
	}

	public void NJGGJJKIGDD(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType, -1, EIPNNOCMLFN: true);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.TilledEarth, Location.Tavern | Location.Road | Location.River, Season.Summer);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.None);
		}
	}

	public void ODBOONCJKAC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			NDNEAIFEKBK(AODONKKHPBP: true);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				FBGDNAHJBAL(AODONKKHPBP: true);
			}
			if (FMIGGMHHJNM() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				FJAODMJMNGK(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			FJAODMJMNGK(AODONKKHPBP: true);
		}
	}

	public void KGPKPLJCJBH(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		HBMMIJKKDHD();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				SetColor(new Color(1959f, 1431f, 1775f, 534f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				HAEPFHJCGEE(new Color(1738f, 1949f, 1659f, 475f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.ACHNOOLHJAP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				GEBHAANCNFF(new Color(154f, 1591f, 1279f, 34f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.DiningRoom | ZoneType.Cellar) && areaSpace.zoneType != 0)
			{
				SetColor(BGHNDGJFDJB());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				ILNKNMEBHLA(NNHDHFEAMEG());
			}
			else
			{
				OLCHHCPMGDN(new Color(1884f, 401f, 1771f, 1281f));
			}
		}
	}

	public void AOBBKOIFEAA(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType, -1, EIPNNOCMLFN: true);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.TilledEarth, Location.Tavern, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone, -1, EIPNNOCMLFN: true);
		}
	}

	public void KIIHGAFIFPC()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (IsValid())
		{
			OLCHHCPMGDN(JLJJNJEMOIG());
		}
		else
		{
			KEBKENOJICG(ACJFIEKCKEC: false, 1859f);
		}
	}

	private void GOEGBOEMHLI()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = true;
		}
	}

	[SpecialName]
	public bool OGOGNPJADLC()
	{
		return MFHGPMNGELB;
	}

	public void BKBMLEHMJCD(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.None, Location.Road | Location.River, Season.Spring, CDPAMNIPPEC: true);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone);
		}
	}

	public void HBMMIJKKDHD()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			KNODLFFBOEK = true;
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				FJAODMJMNGK(AODONKKHPBP: false);
			}
			if (IsValid() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				DDFMKOHBCKL(AODONKKHPBP: false);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			LMFKIFGFHFD(AODONKKHPBP: true);
		}
	}

	public void DGFANNACCAB()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (CJLEPIEJCBL())
		{
			OLCHHCPMGDN(IIHCABLCCCB());
		}
		else
		{
			SetAvailable(ACJFIEKCKEC: false, 796f);
		}
	}

	public void NPHJBGPPBKL(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		CLHBJCAHAEI();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				GEBHAANCNFF(new Color(1728f, 1884f, 1547f, 189f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				ILNKNMEBHLA(new Color(58f, 43f, 763f, 387f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.ACHNOOLHJAP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				MCPLANAPGEE(new Color(1264f, 1904f, 1789f, 511f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.DiningRoom | ZoneType.MetalWorkshop | ZoneType.StoneWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				GEBHAANCNFF(EBGHGGJNPHG());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				HAEPFHJCGEE(GFACOKKHLMH());
			}
			else
			{
				ILNKNMEBHLA(new Color(1504f, 162f, 1726f, 1963f));
			}
		}
	}

	[SpecialName]
	public void IIJKGPKCEBL(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	private Color HFAHLPFHIJI()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 880f);
		}
		return new Color(1773f, 516f, 632f, 1547f);
	}

	public void LJIKHMDFBEJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			NEAOAOLGBOL(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				EHPBMPPJICB(AODONKKHPBP: false);
			}
			if (FMIGGMHHJNM() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				HBELMPILGNG(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			IIJKGPKCEBL(AODONKKHPBP: true);
		}
	}

	public void CIKFCBLEOOL(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		LPJPMNMOCNJ();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				HAEPFHJCGEE(new Color(169f, 684f, 1792f, 633f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				ILNKNMEBHLA(new Color(1520f, 172f, 217f, 745f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.IsInValidLocation(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				OLCHHCPMGDN(new Color(1854f, 245f, 382f, 1541f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop) && areaSpace.zoneType != 0)
			{
				EKDNMBKHBPI(AIJBLCBIDLP());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				DJKEOFPBDOI(BGHNDGJFDJB());
			}
			else
			{
				OLCHHCPMGDN(new Color(484f, 584f, 998f, 1885f));
			}
		}
	}

	public void PKPOHCPMKEL(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		KLGLLAFFJPD();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				GEBHAANCNFF(new Color(1337f, 1854f, 1584f, 695f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				GEBHAANCNFF(new Color(656f, 1232f, 62f, 1417f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.ACHNOOLHJAP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				HAEPFHJCGEE(new Color(1218f, 1268f, 897f, 1851f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.MetalWorkshop | ZoneType.StoneWorkshop) && areaSpace.zoneType != 0)
			{
				MCPLANAPGEE(EBGHGGJNPHG());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				DJKEOFPBDOI(BPCPKAGFDDA());
			}
			else
			{
				HAEPFHJCGEE(new Color(1346f, 1304f, 1697f, 547f));
			}
		}
	}

	public void KKCKOEFGLDN()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (AFGNKFCDFBN())
		{
			EKDNMBKHBPI(AAMONKFDHOD());
		}
		else
		{
			PHHDMNLPOJL(ACJFIEKCKEC: false, 1208f);
		}
	}

	public void PDOKAPFAPKD(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ANFIJOAJEND();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				ILNKNMEBHLA(new Color(1438f, 161f, 588f, 1389f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				GEBHAANCNFF(new Color(384f, 1624f, 850f, 883f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.MJMHLAABFNP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				HAEPFHJCGEE(new Color(1649f, 1123f, 1037f, 25f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				EKDNMBKHBPI(BPCPKAGFDDA());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				ILNKNMEBHLA(IIHCABLCCCB());
			}
			else
			{
				GEBHAANCNFF(new Color(1134f, 420f, 1606f, 768f));
			}
		}
	}

	public void LHABGKECGIK(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		CLHBJCAHAEI();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				OLCHHCPMGDN(new Color(553f, 1093f, 585f, 524f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				OLCHHCPMGDN(new Color(963f, 347f, 273f, 404f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.PECKOFJCBAI(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				HAEPFHJCGEE(new Color(1947f, 1063f, 339f, 1471f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop) && areaSpace.zoneType != 0)
			{
				GEBHAANCNFF(KGOABNAEGEM());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				ILNKNMEBHLA(JCNIFPEPCJG());
			}
			else
			{
				HAEPFHJCGEE(new Color(1056f, 1776f, 1605f, 129f));
			}
		}
	}

	public void PIMGHHGGKHA(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		LPJPMNMOCNJ();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				HAEPFHJCGEE(new Color(1623f, 1312f, 903f, 1684f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				MCPLANAPGEE(new Color(652f, 1332f, 265f, 1983f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.ACHNOOLHJAP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				GEBHAANCNFF(new Color(1359f, 797f, 1866f, 69f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				MCPLANAPGEE(GFACOKKHLMH());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				DJKEOFPBDOI(AAMONKFDHOD());
			}
			else
			{
				HAEPFHJCGEE(new Color(1369f, 1956f, 1926f, 1600f));
			}
		}
	}

	[SpecialName]
	public bool KAPINIMGPDM()
	{
		return MFHGPMNGELB;
	}

	private Color AAMONKFDHOD()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 1421f);
		}
		return new Color(972f, 1312f, 1811f, 1550f);
	}

	public void MFIKAJAIOAJ(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ODBOONCJKAC();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				MCPLANAPGEE(new Color(538f, 380f, 666f, 1665f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				HAEPFHJCGEE(new Color(1105f, 551f, 1539f, 1814f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.FKPFLPGIHIC(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				OLCHHCPMGDN(new Color(8f, 305f, 311f, 1461f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && areaSpace.zoneType != 0)
			{
				EKDNMBKHBPI(NNHDHFEAMEG());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				ILNKNMEBHLA(BGHNDGJFDJB());
			}
			else
			{
				DJKEOFPBDOI(new Color(4f, 470f, 573f, 1176f));
			}
		}
	}

	[SpecialName]
	public bool PMKOFEBAHBJ()
	{
		return MFHGPMNGELB;
	}

	private void Start()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = false;
		}
	}

	public void CheckIsValidWhileSelected()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (IsValid())
		{
			SetColor(NNHDHFEAMEG());
		}
		else
		{
			SetAvailable(ACJFIEKCKEC: false, 1f);
		}
	}

	public bool AEBCPMPMCCG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) || WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) || !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) || WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Floor;
		if (!PCGNHMPADGE)
		{
			return true;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return false;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != 0)
		{
			return true;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 1; i < KCJIMDFEBBL.Count; i++)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.MetalWorkshop) || areaSpace.zoneType == ZoneType.WithoutZone) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return true;
						}
						continue;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public void ActivateArea(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, Location.Road);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone);
		}
	}

	public void JKDGLDEBDDG()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (AFGNKFCDFBN())
		{
			ILNKNMEBHLA(AIJBLCBIDLP());
		}
		else
		{
			BFPOCNBINMB(ACJFIEKCKEC: true, 969f);
		}
	}

	public void LIGKHPIBELN()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (HFONDEBDCBN())
		{
			EKDNMBKHBPI(KGOABNAEGEM());
		}
		else
		{
			HPDGOMIIAEN(ACJFIEKCKEC: true, 104f);
		}
	}

	public void ANFIJOAJEND()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			DDFMKOHBCKL(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				IIJKGPKCEBL(AODONKKHPBP: true);
			}
			if (IsValid() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				GDGEJGKMNII(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			DDFMKOHBCKL(AODONKKHPBP: true);
		}
	}

	[SpecialName]
	public void FJAODMJMNGK(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	public void DLCKAFBGANG(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground | GroundType.TilledEarth, Location.Tavern | Location.River, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false, BBHMAKKPFKB: false);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.None);
		}
	}

	private Color JCNIFPEPCJG()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 120f);
		}
		return new Color(1829f, 588f, 404f, 1909f);
	}

	[SpecialName]
	public void IDNCLBJEHOC(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	public void NMMJHDOCFOM(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		HBBHIFNDCDG();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				SetColor(new Color(1096f, 877f, 609f, 1509f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				HAEPFHJCGEE(new Color(925f, 1377f, 892f, 1744f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.MJMHLAABFNP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				MCPLANAPGEE(new Color(876f, 1573f, 1408f, 1406f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.WithoutZone | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop) && areaSpace.zoneType != 0)
			{
				HAEPFHJCGEE(KGOABNAEGEM());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				SetColor(JLJJNJEMOIG());
			}
			else
			{
				MCPLANAPGEE(new Color(1645f, 119f, 1058f, 570f));
			}
		}
	}

	[SpecialName]
	public void DDFMKOHBCKL(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	public bool AFGNKFCDFBN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = !WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) && !WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) && !WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) && WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) != GroundType.Grass && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth;
		if (!PCGNHMPADGE)
		{
			return true;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return false;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != 0)
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 0; i < KCJIMDFEBBL.Count; i += 0)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.MetalWorkshop) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop) || areaSpace.zoneType == ZoneType.WithoutZone) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return false;
						}
						continue;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public void BNHHBKAGHIK(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground | GroundType.TilledEarth, Location.River, Season.Summer);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone);
		}
	}

	public void LGJDOIAIBFE(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType, -1, EIPNNOCMLFN: true);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground | GroundType.TilledEarth, Location.Tavern | Location.Road);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: true);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.None, -1, EIPNNOCMLFN: true);
		}
	}

	private void IMIONHLAKIH()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = true;
		}
	}

	private Color NNHDHFEAMEG()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 0.5f);
		}
		return new Color(0f, 0f, 0f, 0f);
	}

	public void JIHCMABECBD()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (HPLHFCILIDP())
		{
			OLCHHCPMGDN(HFAHLPFHIJI());
		}
		else
		{
			MNGGKBIAIPH(ACJFIEKCKEC: true, 1972f);
		}
	}

	public void KLGLLAFFJPD()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			LMFKIFGFHFD(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				LMFKIFGFHFD(AODONKKHPBP: false);
			}
			if (HPLHFCILIDP() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				FJAODMJMNGK(AODONKKHPBP: false);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			FBGDNAHJBAL(AODONKKHPBP: false);
		}
	}

	[SpecialName]
	public void HBELMPILGNG(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = !AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	[SpecialName]
	public void EHPBMPPJICB(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	private Color GFACOKKHLMH()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 1525f);
		}
		return new Color(919f, 1198f, 310f, 144f);
	}

	public void DMLGNCHAEMC(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		HBMMIJKKDHD();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				OLCHHCPMGDN(new Color(744f, 1238f, 23f, 597f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				EKDNMBKHBPI(new Color(1478f, 1884f, 1446f, 780f));
			}
			else if (!SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.MJMHLAABFNP(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				SetColor(new Color(151f, 34f, 542f, 1761f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.DiningRoom | ZoneType.WoodWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				MCPLANAPGEE(GFACOKKHLMH());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				GEBHAANCNFF(BGHNDGJFDJB());
			}
			else
			{
				OLCHHCPMGDN(new Color(1958f, 332f, 373f, 1976f));
			}
		}
	}

	public bool HFONDEBDCBN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) || WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) || !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) || (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) != 0 && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.TilledEarth));
		if (!PCGNHMPADGE)
		{
			return false;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return true;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != 0)
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 0; i < KCJIMDFEBBL.Count; i += 0)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.StoneWorkshop)) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.MetalWorkshop)) || areaSpace.zoneType == ZoneType.None) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return true;
						}
						continue;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public void AHHMPGNGCMJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			FJAODMJMNGK(AODONKKHPBP: true);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				FBGDNAHJBAL(AODONKKHPBP: false);
			}
			if (AEBCPMPMCCG() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				IDNCLBJEHOC(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			EHPBMPPJICB(AODONKKHPBP: false);
		}
	}

	public bool CJLEPIEJCBL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = !WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) && !WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) && !WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) && WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) != GroundType.Grass && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Ground | GroundType.TilledEarth);
		if (!PCGNHMPADGE)
		{
			return false;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return true;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != ZoneType.WithoutZone)
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 1; i < KCJIMDFEBBL.Count; i += 0)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.RentedRoom | ZoneType.StoneWorkshop) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar)) || areaSpace.zoneType == ZoneType.None) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return false;
						}
						continue;
					}
					return true;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	public void KHOEJEGBJGP(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType, -1, EIPNNOCMLFN: true);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground | GroundType.TilledEarth, Location.Tavern, Season.Summer);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.None);
		}
	}

	public void IGCBJKALAHN(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType, -1, EIPNNOCMLFN: true);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.Grass)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground, Location.Camp, Season.Summer, CDPAMNIPPEC: true);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: true, BBHMAKKPFKB: false);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone);
		}
	}

	public void EKDLIKKNFMB(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		CLHBJCAHAEI();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				HAEPFHJCGEE(new Color(65f, 351f, 33f, 102f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				ILNKNMEBHLA(new Color(1523f, 232f, 751f, 1530f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.PECKOFJCBAI(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				EKDNMBKHBPI(new Color(1161f, 1918f, 29f, 1998f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop) && areaSpace.zoneType != 0)
			{
				OLCHHCPMGDN(JCNIFPEPCJG());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				DJKEOFPBDOI(JLJJNJEMOIG());
			}
			else
			{
				DJKEOFPBDOI(new Color(1525f, 473f, 723f, 959f));
			}
		}
	}

	public void CFOEEPAHENN()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			NEAOAOLGBOL(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				IDNCLBJEHOC(AODONKKHPBP: false);
			}
			if (IsValid() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				FBGDNAHJBAL(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			IDNCLBJEHOC(AODONKKHPBP: false);
		}
	}

	public void MHIGFLPPFFM()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			NEAOAOLGBOL(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				GDGEJGKMNII(AODONKKHPBP: true);
			}
			if (AFGNKFCDFBN() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				NDNEAIFEKBK(AODONKKHPBP: false);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			DDFMKOHBCKL(AODONKKHPBP: false);
		}
	}

	public void MPOEDJIEMCC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			KNODLFFBOEK = false;
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				NEAOAOLGBOL(AODONKKHPBP: false);
			}
			if (HFONDEBDCBN() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				FJAODMJMNGK(AODONKKHPBP: true);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			LMFKIFGFHFD(AODONKKHPBP: true);
		}
	}

	public bool CPLOKHPFBDO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) || WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) || !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) || (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) != 0 && WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.TilledEarth);
		if (!PCGNHMPADGE)
		{
			return true;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return true;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != ZoneType.WithoutZone)
		{
			return false;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 0; i < KCJIMDFEBBL.Count; i += 0)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(~(ZoneType.CraftingRoom | ZoneType.RentedRoom)) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop)) || areaSpace.zoneType == ZoneType.None) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return false;
						}
						continue;
					}
					return false;
				}
				return true;
			}
			return true;
		}
		return true;
	}

	[SpecialName]
	public void NEAOAOLGBOL(bool AODONKKHPBP)
	{
		((Renderer)sr).enabled = AODONKKHPBP;
		MFHGPMNGELB = AODONKKHPBP;
	}

	private Color GKOFGLGJDKI()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 397f);
		}
		return new Color(75f, 1915f, 1616f, 314f);
	}

	private void HFFFFAJFIPB()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = false;
		}
	}

	public void GBJALKKEOFB(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.TilledEarth, Location.Road | Location.River, Season.Summer);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone);
		}
	}

	[SpecialName]
	public bool FHBFJALFBKN()
	{
		return MFHGPMNGELB;
	}

	public void KAIIMGJAJLK(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		MBOOCABFNJC();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				HAEPFHJCGEE(new Color(286f, 1249f, 161f, 576f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				GEBHAANCNFF(new Color(431f, 630f, 830f, 1182f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.IsInValidLocation(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				SetColor(new Color(1405f, 340f, 1644f, 1087f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				OLCHHCPMGDN(NNHDHFEAMEG());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				HAEPFHJCGEE(AIJBLCBIDLP());
			}
			else
			{
				SetColor(new Color(385f, 878f, 1790f, 160f));
			}
		}
	}

	public void EBONDHJNMHO(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		KLGLLAFFJPD();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				OLCHHCPMGDN(new Color(1939f, 161f, 1789f, 683f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				OLCHHCPMGDN(new Color(1104f, 34f, 1089f, 817f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.FKPFLPGIHIC(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				GEBHAANCNFF(new Color(976f, 15f, 1422f, 495f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.WithoutZone | ZoneType.Cellar | ZoneType.StoneWorkshop) && areaSpace.zoneType != 0)
			{
				ILNKNMEBHLA(BGHNDGJFDJB());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				GEBHAANCNFF(EBGHGGJNPHG());
			}
			else
			{
				ILNKNMEBHLA(new Color(366f, 1248f, 1248f, 1163f));
			}
		}
	}

	public void FJCJIKKGGOM(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		ANFIJOAJEND();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				ILNKNMEBHLA(new Color(843f, 1432f, 1273f, 1563f));
			}
			else if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				ILNKNMEBHLA(new Color(832f, 1403f, 1940f, 1300f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.FKPFLPGIHIC(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				OLCHHCPMGDN(new Color(1910f, 373f, 1011f, 122f));
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded == (ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.StoneWorkshop) && areaSpace.zoneType != ZoneType.WithoutZone)
			{
				ILNKNMEBHLA(KGOABNAEGEM());
			}
			else if (SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				EKDNMBKHBPI(GFACOKKHLMH());
			}
			else
			{
				MCPLANAPGEE(new Color(10f, 641f, 1426f, 1344f));
			}
		}
	}

	public void DDBMPJKLCAI(int JIIGOACEIKL)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		MHIGFLPPFFM();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable))
		{
			if ((Object)(object)SelectObject.GetPlayer(JIIGOACEIKL).placeable.areaSpace != (Object)null)
			{
				MCPLANAPGEE(new Color(447f, 1063f, 533f, 1697f));
			}
			else if ((Object)(object)SelectObject.BNMEANGDMIP(JIIGOACEIKL).placeable.itemSpace == (Object)null)
			{
				DJKEOFPBDOI(new Color(244f, 1948f, 1876f, 1914f));
			}
			else if (!SelectObject.GetPlayer(JIIGOACEIKL).placeable.IsInValidLocation(WorldGrid.HJPCBBGHPDA(((Component)this).transform.position + offset)))
			{
				SetColor(new Color(1783f, 1547f, 1984f, 263f));
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded == ~(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.MetalWorkshop) && areaSpace.zoneType != 0)
			{
				HAEPFHJCGEE(NNHDHFEAMEG());
			}
			else if (SelectObject.GetPlayer(JIIGOACEIKL).placeable.zoneTypeNeeded.HasFlag(areaSpace.zoneType))
			{
				EKDNMBKHBPI(IIHCABLCCCB());
			}
			else
			{
				EKDNMBKHBPI(new Color(383f, 1535f, 980f, 1615f));
			}
		}
	}

	[SpecialName]
	public bool ILGCHNALCMK()
	{
		return MFHGPMNGELB;
	}

	public void GFFMGFKEBLI(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType, -1, EIPNNOCMLFN: true);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Grass | GroundType.Ground | GroundType.TilledEarth, Location.None);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false, BBHMAKKPFKB: false);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone, -1, EIPNNOCMLFN: true);
		}
	}

	public void OGMDLEJPDCP(bool DAEMAAOLHMG, bool JAIAFLHGNJM, bool GOPCJJKMNKJ)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (DAEMAAOLHMG)
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, areaSpace.zoneType);
			if (GOPCJJKMNKJ)
			{
				WorldGrid.CKDDIGCJANA(((Component)this).transform.position + offset);
			}
			if (JAIAFLHGNJM)
			{
				if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None)
				{
					WorldGrid.MMOHADHAAGD(((Component)this).transform.position + offset, GroundType.Ground, Location.Tavern);
				}
				WorldGrid.AAFPODGPJMP(((Component)this).transform.position + offset, DNMKMKDAENO: false, BBHMAKKPFKB: false);
			}
		}
		else
		{
			WorldGrid.NDPILMNDCDK(((Component)this).transform.position + offset, ZoneType.WithoutZone);
		}
	}

	public void CLHBJCAHAEI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (showSquare && WorldGrid.IFLBFJBNPKP(((Component)this).transform.position + offset))
		{
			HBELMPILGNG(AODONKKHPBP: false);
		}
		else if (areaSpace.placeable.FHEMHCEAICB)
		{
			if (showSquare)
			{
				FJAODMJMNGK(AODONKKHPBP: true);
			}
			if (AFGNKFCDFBN() && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) == areaSpace.zoneType)
			{
				IIJKGPKCEBL(AODONKKHPBP: false);
			}
		}
		else if (showSquare && WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset) != areaSpace.zoneType)
		{
			NEAOAOLGBOL(AODONKKHPBP: false);
		}
	}

	private Color BGHNDGJFDJB()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 326f);
		}
		return new Color(15f, 1677f, 1518f, 1477f);
	}

	public void PGHCDGKBOHC()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (AFGNKFCDFBN())
		{
			OLCHHCPMGDN(JLJJNJEMOIG());
		}
		else
		{
			HPDGOMIIAEN(ACJFIEKCKEC: false, 923f);
		}
	}

	public bool HPLHFCILIDP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		PCGNHMPADGE = WorldGrid.ALNFLFCLIEP(((Component)this).transform.position + offset) || WorldGrid.KCJGJHNIPGP(((Component)this).transform.position + offset) || WorldGrid.HENDJJEEOHE(((Component)this).transform.position + offset) || !WorldGrid.LKBLKCFOEPA(((Component)this).transform.position + offset) || WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == GroundType.None || WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + offset) == (GroundType.Grass | GroundType.Ground);
		if (!PCGNHMPADGE)
		{
			return true;
		}
		GFBDMNKHKKF = WorldGrid.AGKGGAFFFGM(((Component)this).transform.position + offset);
		if ((Object)(object)areaSpace == (Object)null)
		{
			return false;
		}
		if (GFBDMNKHKKF != areaSpace.zoneType && GFBDMNKHKKF != ZoneType.WithoutZone)
		{
			return true;
		}
		if (!WorldGrid.NGDHDMAMGPI(((Component)this).transform.position + offset, GCDEDGFDKBL: false))
		{
			KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(((Component)this).transform.position + offset);
			if (KCJIMDFEBBL != null)
			{
				for (int i = 0; i < KCJIMDFEBBL.Count; i += 0)
				{
					if (Object.op_Implicit((Object)(object)KCJIMDFEBBL[i]))
					{
						if ((!((Object)(object)KCJIMDFEBBL[i].areaSpace != (Object)null) || KCJIMDFEBBL[i].areaSpace.zoneType != areaSpace.zoneType) && (Object)(object)KCJIMDFEBBL[i].itemSpace != (Object)null && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop) && (!KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom)) || areaSpace.zoneType == ZoneType.None) && !KCJIMDFEBBL[i].zoneTypeNeeded.HasFlag(areaSpace.zoneType))
						{
							return true;
						}
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	private Color JLJJNJEMOIG()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 1298f);
		}
		return new Color(245f, 696f, 586f, 1586f);
	}

	private Color AIJBLCBIDLP()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		TileBase tileZone = GameTileMaps.GGFJGHHHEJC.GetTileZone(areaSpace.zoneType);
		RuleTile val = (RuleTile)(object)((tileZone is RuleTile) ? tileZone : null);
		if (val != null)
		{
			return new Color(val.m_DefaultColor.r, val.m_DefaultColor.g, val.m_DefaultColor.b, 1298f);
		}
		return new Color(1331f, 1285f, 906f, 60f);
	}

	[SpecialName]
	public bool LBGFKNMNLMN()
	{
		return MFHGPMNGELB;
	}

	private void JPHEOLEEAPB()
	{
		if (!showSquare)
		{
			((Renderer)sr).enabled = true;
		}
	}

	[SpecialName]
	public bool DIPICDJIKLH()
	{
		return MFHGPMNGELB;
	}
}
