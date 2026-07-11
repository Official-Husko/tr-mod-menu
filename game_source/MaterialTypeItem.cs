using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Floor Material")]
public class MaterialTypeItem : Tool, IActionable, ITool
{
	public GroundType groundType;

	public bool NIDBEIMJJJH(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		NDJLMNIJLFI(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(BLCEHNCLHHF(JIIGOACEIKL)))));
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL) + Vector2.up * 1220f));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(OJKCPAAAOGH(JIIGOACEIKL)), CommonReferences.GGFJGHHHEJC.selectedGridSquare);
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Player2"));
		return true;
	}

	public bool JBDNBDGKOON(int JIIGOACEIKL)
	{
		return true;
	}

	public void JKCNBMMHEHC(int JIIGOACEIKL)
	{
	}

	public void LKDEFKFFPPK(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DNBHOHFDJGM();
	}

	public bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 0.5f));
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.Ground) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == ZoneType.WithoutZone && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)));
		}
		return false;
	}

	public void GDFKEIBEPBA(int JIIGOACEIKL)
	{
	}

	public void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		IOCKFAELDMD(JIIGOACEIKL);
	}

	public void KDNOPDLNNBJ(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.AKPDMOBOPHN();
	}

	public bool CBCAJNGLAOI(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		CGEPIJMGBKK(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1568f));
		JCNLMHNEKCF(JIIGOACEIKL, OGIPBMKEAGF(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(OGIPBMKEAGF(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(OGIPBMKEAGF(JIIGOACEIKL))) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth)) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == ZoneType.None && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL)), GCDEDGFDKBL: false);
		}
		return false;
	}

	public bool JAKBKBNDBIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (KPDCENBLCNH(JIIGOACEIKL))
		{
			DOHJBGGDKMO(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(ADNFLGFDOHD(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(EDKKKEMHIDE(JIIGOACEIKL)), groundType, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
			ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedSlot().FMEPMEKLHIJ(CDPAMNIPPEC: false);
			Sound.OKAPNFPFPFP().CHFFLKLLNNJ(Sound.GGFJGHHHEJC.shovel[Random.Range(1, Sound.DIHCEGINELM().shovel.Length)], HOMFPAFAOGD: true, null, null, 1424f);
		}
		return false;
	}

	public bool HKDDKAELFDO()
	{
		return true;
	}

	public void LPOPCKHHJFI(int JIIGOACEIKL)
	{
	}

	public bool OOJKIKIHLAP(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		DOHJBGGDKMO(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(IEGJDNLOPNE(JIIGOACEIKL)))));
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL) + Vector2.up * 1342f));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(HKKDLFKGBHF(JIIGOACEIKL)), CommonReferences.MNFMOEKMJKN().selectedGridSquare);
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("Items/item_description_624"));
		return true;
	}

	public void KKDEDBKGJEN(int JIIGOACEIKL)
	{
	}

	public void LLAALCGJOOJ(int JIIGOACEIKL)
	{
	}

	public bool PCJEFDILJKK(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		MMACOAIACIC(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL) + Vector2.up * 609f));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(DFJIPINODBP(JIIGOACEIKL)), CommonReferences.MNFMOEKMJKN().selectedGridSquare);
		ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("WIP: Jugando online, el modo cooperativo esta deshabilitado. Hay que esconder la interfaz de 'Pulsa X para unirte'. "));
		return false;
	}

	public bool BKAOLKJJGJD(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		GPAFLICPBHE(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1868f));
		AGAJDKDCEHJ(JIIGOACEIKL, OGIPBMKEAGF(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL))) == (GroundType.Ground | GroundType.TilledEarth)) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(NLGOOKPIOCN(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == ZoneType.WithoutZone && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL)));
		}
		return false;
	}

	public bool MFGNFFFMDBP(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		KHJLKHEGLAK(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 204f));
		OBNDGCDBGFP(JIIGOACEIKL, LJEOKENBKBC(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(OGIPBMKEAGF(JIIGOACEIKL))) == GroundType.None || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL))) == GroundType.Floor) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(NLGOOKPIOCN(JIIGOACEIKL))) == ZoneType.WithoutZone && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)));
		}
		return true;
	}

	public bool FOPNNHPLGAE(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		CGEPIJMGBKK(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1795f));
		JCNLMHNEKCF(JIIGOACEIKL, KJOFFEDOOLB(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.None || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NLGOOKPIOCN(JIIGOACEIKL))) == (GroundType.Grass | GroundType.Ground)) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == ZoneType.None && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(NLGOOKPIOCN(JIIGOACEIKL)), GCDEDGFDKBL: false);
		}
		return true;
	}

	public void AENCFMAIHIE(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.AKPDMOBOPHN();
	}

	public void AONJJGAIDBG(int JIIGOACEIKL)
	{
	}

	public bool BLJFOHCGEDP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL))
		{
			MMACOAIACIC(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DFJIPINODBP(JIIGOACEIKL)), groundType, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Spring, CDPAMNIPPEC: true);
			ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NBEINBNMKJG().DJFOMFDOOKM(CDPAMNIPPEC: false);
			Sound.MAIDHAPANEB().GAIDPALIDFG(Sound.BNBMNOMFFBE().shovel[Random.Range(1, Sound.BNBMNOMFFBE().shovel.Length)], HOMFPAFAOGD: true, null, null, 231f);
		}
		return true;
	}

	public void JMBANHEODJP(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		AENCFMAIHIE(JIIGOACEIKL);
	}

	public bool FIHCEEPNOJL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JLLLHDCNIJP(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(GJGABGNAOKI(JIIGOACEIKL)))));
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(HKKDLFKGBHF(JIIGOACEIKL) + Vector2.up * 1714f));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(DFJIPINODBP(JIIGOACEIKL)), CommonReferences.MNFMOEKMJKN().selectedGridSquare, 1);
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("PHOTON_ROOM_CODE"));
		return false;
	}

	public void KFGEABCANAH(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		KDNOPDLNNBJ(JIIGOACEIKL);
	}

	public bool LOHPIFJKEBI(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		PFHANOMDDBL(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1627f));
		JCNLMHNEKCF(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == GroundType.Grass) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL))) == ZoneType.WithoutZone && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL)), GCDEDGFDKBL: false);
		}
		return true;
	}

	public void FPGGCMBGPJF(int JIIGOACEIKL)
	{
	}

	public bool MLJEKIIMCHF(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		DODIJJEPHBO(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 1972f));
		IGLFLKEGAEB(JIIGOACEIKL, DJDNHOLIJCA(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DJDNHOLIJCA(JIIGOACEIKL))) == GroundType.Grass || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL))) == GroundType.Grass) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))) == ZoneType.WithoutZone && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)), GCDEDGFDKBL: false);
		}
		return false;
	}

	public bool CDCDKFEJLOG()
	{
		return true;
	}

	public bool ECKGJAHMFAL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL))
		{
			HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(GJGABGNAOKI(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DFJIPINODBP(JIIGOACEIKL)), groundType, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Spring, CDPAMNIPPEC: true);
			ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KDJMFELBOPM().MEODNPFJDMH(CDPAMNIPPEC: false);
			Sound.MAIDHAPANEB().LNCINHJELIG(Sound.ABDJJBFNLBJ().shovel[Random.Range(1, Sound.OKAPNFPFPFP().shovel.Length)], HOMFPAFAOGD: false, null, null, 49f);
		}
		return true;
	}

	public bool PJBGMLILAOM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (FOPNNHPLGAE(JIIGOACEIKL))
		{
			HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(ADNFLGFDOHD(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(HKKDLFKGBHF(JIIGOACEIKL)), groundType, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Spring, CDPAMNIPPEC: true);
			ActionBarInventory.GetPlayer(JIIGOACEIKL).MIPGHCNCOEL().FMEPMEKLHIJ();
			Sound.ABDJJBFNLBJ().BOFJJFJIBHB(Sound.ABDJJBFNLBJ().shovel[Random.Range(0, Sound.MAIDHAPANEB().shovel.Length)], HOMFPAFAOGD: true, null, null, 291f);
		}
		return true;
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL))
		{
			HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL)), groundType, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
			ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot().MEODNPFJDMH();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Sound.GGFJGHHHEJC.shovel[Random.Range(0, Sound.GGFJGHHHEJC.shovel.Length)]);
		}
		return false;
	}

	public bool HNMPNLKGFCP(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DPDFJMDNNGN()
	{
		return true;
	}

	public bool OHIDJHCJGGJ(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		DOHJBGGDKMO(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(BLCEHNCLHHF(JIIGOACEIKL)))));
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(MEGLKGJDHIG(JIIGOACEIKL) + Vector2.up * 1529f));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL)), CommonReferences.MNFMOEKMJKN().selectedGridSquare);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("GetFloorEntrance travelZone null "));
		return false;
	}

	public bool FDKEMPDCHFB()
	{
		return false;
	}

	public void CDGBECJBMIE(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		LKDEFKFFPPK(JIIGOACEIKL);
	}

	public bool OHINFBCDKLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (MFGNFFFMDBP(JIIGOACEIKL))
		{
			NDJLMNIJLFI(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(MLFDDJONGBL(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(OJKCPAAAOGH(JIIGOACEIKL)), groundType, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer, CDPAMNIPPEC: true);
			ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedSlot().MEODNPFJDMH(CDPAMNIPPEC: false);
			Sound.ABDJJBFNLBJ().PlayOneShotRandomPitch(Sound.MAIDHAPANEB().shovel[Random.Range(0, Sound.BNBMNOMFFBE().shovel.Length)], HOMFPAFAOGD: false, null, null, 745f);
		}
		return true;
	}

	public bool GGAHICGOLLN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (MLJEKIIMCHF(JIIGOACEIKL))
		{
			MMACOAIACIC(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(IEGJDNLOPNE(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL)), groundType, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer);
			ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KDJMFELBOPM().CIDBFIAJIBG();
			Sound.MAIDHAPANEB().IAEMMABJFLH(Sound.DIHCEGINELM().shovel[Random.Range(0, Sound.ABDJJBFNLBJ().shovel.Length)], HOMFPAFAOGD: false, null, null, 956f);
		}
		return false;
	}

	public bool KHKHIBKFCFF(int JIIGOACEIKL)
	{
		return true;
	}

	public void AKOBHJIAMLI(int JIIGOACEIKL)
	{
	}

	public void GKAHJFEALAM(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		AENCFMAIHIE(JIIGOACEIKL);
	}

	public bool CFOJEGMAJMH()
	{
		return true;
	}

	public bool LIFABFGDGEK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (KPDCENBLCNH(JIIGOACEIKL))
		{
			MMACOAIACIC(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(ADNFLGFDOHD(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL)), groundType, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer);
			ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GEAMCEMDJFJ().POHFJCEAKML(CDPAMNIPPEC: false);
			Sound.DIHCEGINELM().LNCINHJELIG(Sound.BNBMNOMFFBE().shovel[Random.Range(1, Sound.ABDJJBFNLBJ().shovel.Length)], HOMFPAFAOGD: false, null, null, 952f);
		}
		return true;
	}

	public bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool KPDCENBLCNH(int JIIGOACEIKL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		DODIJJEPHBO(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 855f));
		IGLFLKEGAEB(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		if ((WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL))) == GroundType.None || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NLGOOKPIOCN(JIIGOACEIKL))) == (GroundType.Grass | GroundType.TilledEarth)) && WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(KJOFFEDOOLB(JIIGOACEIKL))) && WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(LJEOKENBKBC(JIIGOACEIKL))) == ZoneType.WithoutZone && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE())
		{
			return WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(OGIPBMKEAGF(JIIGOACEIKL)));
		}
		return true;
	}

	public bool JKJFPFJPBBF()
	{
		return false;
	}

	public bool DAODKFBNCDH()
	{
		return false;
	}

	public bool FODGNFMBOFE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (MLJEKIIMCHF(JIIGOACEIKL))
		{
			NDJLMNIJLFI(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(BLCEHNCLHHF(JIIGOACEIKL)))));
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(MEGLKGJDHIG(JIIGOACEIKL)), groundType, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer, CDPAMNIPPEC: true);
			ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NBEINBNMKJG().CIDBFIAJIBG(CDPAMNIPPEC: false);
			Sound.MAIDHAPANEB().MFBBFAINMHG(Sound.GGFJGHHHEJC.shovel[Random.Range(0, Sound.BNBMNOMFFBE().shovel.Length)], HOMFPAFAOGD: false, null, null, 1962f);
		}
		return true;
	}

	public bool NEOJIAIDFJN(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EAADFIDLGME()
	{
		return false;
	}

	public bool HEKGALMDLIL(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL) + Vector2.up * 0.3f));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL)), CommonReferences.GGFJGHHHEJC.selectedGridSquare);
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Clear"));
		return true;
	}

	public void IOCKFAELDMD(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableAllEarthFocus();
	}
}
