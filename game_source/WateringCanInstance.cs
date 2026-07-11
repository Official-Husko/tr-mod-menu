using System;
using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class WateringCanInstance : ToolInstance
{
	private FertileSoil IGDHGFMMCAA;

	private FertileSoil GLPMMEJFBNB;

	private Vector2 BKNEGILJAEL = Vector2.zero;

	private Vector3 ANAOEGHGFIH;

	private string BMHHBCGBJPK;

	private bool IMLECPKHMPI;

	private FertileSoil[] KOGOFNAFGJB = new FertileSoil[12];

	private Vector3 ECJLMIPAFGP;

	private Direction INBEEKCIFBA;

	private void AKPLEGFNHJB(int JIIGOACEIKL)
	{
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(AKPLEGFNHJB));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	public override bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
		if (NJGGMEJGKBM(JIIGOACEIKL))
		{
			HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)))));
		}
		else
		{
			HCJIFAGBKHL(JIIGOACEIKL, GMAFNNMMFAK(JIIGOACEIKL));
		}
		PLNGELGLDLP(JIIGOACEIKL);
		ButtonsContext.SetPosition(JIIGOACEIKL, IPCCNCABHHM(JIIGOACEIKL) + Vector3.up * 0.3f);
		HKHGGNIFJKK(JIIGOACEIKL, LBBDJMCLEMG(IPCCNCABHHM(JIIGOACEIKL)));
		IOCKFAELDMD(JIIGOACEIKL);
		GLPMMEJFBNB = POCOONAIBCB(JIIGOACEIKL);
		BMHHBCGBJPK = "Watering";
		for (int i = 0; i < KOGOFNAFGJB.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)KOGOFNAFGJB[i]) && Object.op_Implicit((Object)(object)KOGOFNAFGJB[i].plantedCropSetter))
			{
				KOGOFNAFGJB[i].plantedCropSetter.UnfocusCrop();
			}
		}
		LBEDOABMKJB(JIIGOACEIKL, Vector2.op_Implicit(IPCCNCABHHM(JIIGOACEIKL)), selectedRowCount);
		if (PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			return true;
		}
		if (!IMLECPKHMPI || FOFLMHDABPG(JIIGOACEIKL) != HGECFPCPOHN(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get(BMHHBCGBJPK));
			IMLECPKHMPI = true;
		}
		return true;
	}

	public FertileSoil AMECAJHLNME(int JIIGOACEIKL)
	{
		return GLPMMEJFBNB;
	}

	private void JHIIJCIEFNO(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 1; i <= 4 && i <= selectedRowCount; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				Vector2 val = CFAGHFFAODK;
				switch (j)
				{
				case 1:
					val += Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 0.5f;
					break;
				case 2:
					val -= Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 0.5f;
					break;
				}
				for (int k = 1; k < i; k++)
				{
					val = FHIKFFPGAEG(JIIGOACEIKL, val);
				}
				if (!NGPKDIIHCHM(val))
				{
					continue;
				}
				FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(val);
				if ((Object)(object)fertileSoil != (Object)null)
				{
					PFFMHPFKJMF(fertileSoil);
					if (OnlineManager.PlayingOnline())
					{
						list.Add(val);
					}
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineWorldTilesManager.instance.SendWateringCanAction(list);
			}
		}
	}

	public void PAHCDACHGBB(int JIIGOACEIKL, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ANAOEGHGFIH = IMOBLFMHKOD;
	}

	public WateringCanInstance(Item MEMGMDOCBOJ)
		: base(MEMGMDOCBOJ)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0006: Unknown result type (might be due to invalid IL or missing references)


	private void LHELNLDNDJG(Vector2 IMOBLFMHKOD, int JIIGOACEIKL, int MOFKEDGAOEE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!NGPKDIIHCHM(IMOBLFMHKOD))
		{
			return;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(IMOBLFMHKOD), CommonReferences.MNFMOEKMJKN().selectedGridSquare, MOFKEDGAOEE);
		if (!PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			KOGOFNAFGJB[MOFKEDGAOEE] = LBBDJMCLEMG(Vector2.op_Implicit(IMOBLFMHKOD));
			if (Object.op_Implicit((Object)(object)KOGOFNAFGJB[MOFKEDGAOEE]) && Object.op_Implicit((Object)(object)KOGOFNAFGJB[MOFKEDGAOEE].plantedCropSetter))
			{
				KOGOFNAFGJB[MOFKEDGAOEE].plantedCropSetter.GKDNBDPGLAO(JIIGOACEIKL);
			}
		}
	}

	private void LBEDOABMKJB(int JIIGOACEIKL, Vector2 CFAGHFFAODK, int DAKANNEEEPJ)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i <= 4 && i <= DAKANNEEEPJ; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				Vector2 val = CFAGHFFAODK;
				switch (j)
				{
				case 1:
					val += Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 0.5f;
					break;
				case 2:
					val -= Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 0.5f;
					break;
				}
				for (int k = 1; k < i; k++)
				{
					val = FHIKFFPGAEG(JIIGOACEIKL, val);
				}
				DAIEMFEAJOJ(val, JIIGOACEIKL, j + (i - 1) * 3);
			}
		}
	}

	public static void KAIFAHEGAFM(float[] NCPGNLOJGAF, float[] JLMAILGJNCE)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		for (int i = 0; i < NCPGNLOJGAF.Length; i++)
		{
			((Vector2)(ref val))._002Ector(NCPGNLOJGAF[i], JLMAILGJNCE[i]);
			PFFMHPFKJMF(Utils.KJOMDMEIAEJ<FertileSoil>(val));
			if (i == 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.wateringCan, Vector2.op_Implicit(val));
			}
		}
	}

	public static void KHHLNANJPCO(float[] NCPGNLOJGAF, float[] JLMAILGJNCE)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		for (int i = 0; i < NCPGNLOJGAF.Length; i += 0)
		{
			((Vector2)(ref val))._002Ector(NCPGNLOJGAF[i], JLMAILGJNCE[i]);
			PFFMHPFKJMF(Utils.KJOMDMEIAEJ<FertileSoil>(val, 67));
			if (i == 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.wateringCan, Vector2.op_Implicit(val));
			}
		}
	}

	private void BOBAMOFPEPG(Vector2 IMOBLFMHKOD, int JIIGOACEIKL, int MOFKEDGAOEE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!NGPKDIIHCHM(IMOBLFMHKOD))
		{
			return;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(IMOBLFMHKOD), CommonReferences.GGFJGHHHEJC.selectedGridSquare, MOFKEDGAOEE);
		if (!PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			KOGOFNAFGJB[MOFKEDGAOEE] = LBBDJMCLEMG(Vector2.op_Implicit(IMOBLFMHKOD));
			if (Object.op_Implicit((Object)(object)KOGOFNAFGJB[MOFKEDGAOEE]) && Object.op_Implicit((Object)(object)KOGOFNAFGJB[MOFKEDGAOEE].plantedCropSetter))
			{
				KOGOFNAFGJB[MOFKEDGAOEE].plantedCropSetter.JICFALBCNIC(JIIGOACEIKL);
			}
		}
	}

	public override bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.None)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			return true;
		}
		HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL)));
		if (Object.op_Implicit((Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA)) && WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).snowTilemaps.snowTilemaps))
		{
			return false;
		}
		if (!WorldGrid.LKBLKCFOEPA(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) || DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) != ZoneType.WithoutZone)
		{
			return false;
		}
		if (WorldGrid.NALIAAMAKAL(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).GetTilemaps(SeasonManager.EECEKHKAAIH)))
		{
			return false;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL) + Vector2.op_Implicit(WorldGrid.allNeighbours[i].position))) != ZoneType.WithoutZone)
			{
				return false;
			}
		}
		if (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) == GroundType.Ground)
		{
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
			{
				Vector3 iMOBLFMHKOD = Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL) + Vector2.op_Implicit(WorldGrid.allNeighbours[j].position));
				if (WorldGrid.GJHHDIJOILG(iMOBLFMHKOD, JGDOHPCLJPM: true) && WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD) != GroundType.TilledEarth)
				{
					return false;
				}
			}
		}
		if (!base.KNIMLGOGFPA.groundTypeAllowed.HasFlag(WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))))
		{
			return false;
		}
		if (WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)), JGDOHPCLJPM: true))
		{
			return false;
		}
		if (WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))) == WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL)))
		{
			PAHCDACHGBB(JIIGOACEIKL, WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))));
			PMILEJPHHIJ(JIIGOACEIKL, Utils.JPKPFDEBGEO(PlayerController.GetPlayerDirection(JIIGOACEIKL)));
		}
		else
		{
			PAHCDACHGBB(JIIGOACEIKL, Vector2.op_Implicit(CDDDLMFHLAI(JIIGOACEIKL)));
			PMILEJPHHIJ(JIIGOACEIKL, Utils.JPKPFDEBGEO(Utils.EIDFHLPBICI(CDDDLMFHLAI(JIIGOACEIKL) - Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)))));
		}
		return true;
	}

	private void HFHKAEHDEMJ(int JIIGOACEIKL)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EBNHANPIIKJ(JIIGOACEIKL, Vector2.op_Implicit(IPCCNCABHHM(JIIGOACEIKL)));
		MultiAudioManager.PlayAudioObject(LMHDGKJIHMK().sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DAGDKCCIEHB));
	}

	private bool PMMOPHHMIKP(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) == GroundType.TilledEarth;
	}

	private FertileSoil LBBDJMCLEMG(Vector3 DEACEMMGPHA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.MMIIIKBJKBA<FertileSoil>(DEACEMMGPHA);
	}

	public void HKHGGNIFJKK(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	public FertileSoil CCILBAOJMLA(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	public Vector3 IPCCNCABHHM(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ANAOEGHGFIH;
	}

	public WateringCanInstance(WateringCanInstance GPMJPMCEIED)
		: base(GPMJPMCEIED)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0006: Unknown result type (might be due to invalid IL or missing references)


	private void AIOLPHODIHG(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.UnfocusCrop();
		}
	}

	public override void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		IOCKFAELDMD(JIIGOACEIKL);
		IMLECPKHMPI = false;
		for (int i = 0; i < KOGOFNAFGJB.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)KOGOFNAFGJB[i]) && Object.op_Implicit((Object)(object)KOGOFNAFGJB[i].plantedCropSetter))
			{
				KOGOFNAFGJB[i].plantedCropSetter.UnfocusCrop();
			}
		}
	}

	private void DAGDKCCIEHB(int JIIGOACEIKL)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		JHIIJCIEFNO(JIIGOACEIKL, Vector2.op_Implicit(IPCCNCABHHM(JIIGOACEIKL)));
		MultiAudioManager.PlayAudioObject(MLKAICLMFLG().sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DAGDKCCIEHB));
	}

	public void MGNFNCAOPHH(int JIIGOACEIKL, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ANAOEGHGFIH = IMOBLFMHKOD;
	}

	private void AHAPJGFJFPP(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i <= 3 && i <= selectedRowCount; i++)
		{
			for (int j = 1; j < 8; j += 0)
			{
				Vector2 val = CFAGHFFAODK;
				switch (j)
				{
				case 1:
					val += Vector2.op_Implicit(Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL))) * 365f;
					break;
				case 4:
					val -= Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 1243f;
					break;
				}
				for (int k = 1; k < i; k++)
				{
					val = MMBONNFKKKG(JIIGOACEIKL, val);
				}
				if (!NGPKDIIHCHM(val))
				{
					continue;
				}
				FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(val, 18);
				if ((Object)(object)fertileSoil != (Object)null)
				{
					PFFMHPFKJMF(fertileSoil);
					if (OnlineManager.PlayingOnline())
					{
						list.Add(val);
					}
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineWorldTilesManager.instance.BPPOIINPOJG(list);
			}
		}
	}

	public Vector2 FOFLMHDABPG(int JIIGOACEIKL)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	public Vector2 CDDDLMFHLAI(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)) - WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL));
		INBEEKCIFBA = Utils.EIDFHLPBICI(Vector2.op_Implicit(ECJLMIPAFGP));
		return Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(INBEEKCIFBA) * 0.5f));
	}

	public override bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		if (NBFBPMNMBJG(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			base.Action(JIIGOACEIKL, KLGOCJMGKFO);
			if (KLGOCJMGKFO)
			{
				BKNEGILJAEL = Vector2.zero;
			}
			HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
			if (FOFLMHDABPG(JIIGOACEIKL) != HGECFPCPOHN(JIIGOACEIKL))
			{
				HKHGGNIFJKK(JIIGOACEIKL, LBBDJMCLEMG(IPCCNCABHHM(JIIGOACEIKL)));
				if (HCFJKBIIMIK(JIIGOACEIKL) == 1 && (Object)(object)POCOONAIBCB(JIIGOACEIKL) != (Object)null)
				{
					return false;
				}
				if (HCFJKBIIMIK(JIIGOACEIKL) == 2 && (Object)(object)POCOONAIBCB(JIIGOACEIKL) == (Object)null)
				{
					return false;
				}
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(Vector2.op_Implicit(IPCCNCABHHM(JIIGOACEIKL)));
				if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold"))
				{
					PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Watering();
				}
				PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
				PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
				CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
				characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(OGNJKPFOPMD));
				CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
				characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(DAGDKCCIEHB));
				CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
				characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(AKPLEGFNHJB));
				return true;
			}
		}
		return false;
	}

	private void EBNHANPIIKJ(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i <= 7 && i <= selectedRowCount; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				Vector2 val = CFAGHFFAODK;
				switch (j)
				{
				case 1:
					val += Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 129f;
					break;
				case 5:
					val -= Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 1185f;
					break;
				}
				for (int k = 0; k < i; k++)
				{
					val = NLCBPLKNGPI(JIIGOACEIKL, val);
				}
				if (!NGPKDIIHCHM(val))
				{
					continue;
				}
				FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(val, -117);
				if ((Object)(object)fertileSoil != (Object)null)
				{
					PFFMHPFKJMF(fertileSoil);
					if (OnlineManager.PlayingOnline())
					{
						list.Add(val);
					}
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineWorldTilesManager.instance.LKCJPHIFMLO(list);
			}
		}
	}

	public Vector2 DOMAKMAHHKA(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)) - WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL));
		INBEEKCIFBA = Utils.EIDFHLPBICI(Vector2.op_Implicit(ECJLMIPAFGP));
		return Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(INBEEKCIFBA) * 1186f));
	}

	public override void IOCKFAELDMD(int JIIGOACEIKL)
	{
		base.IOCKFAELDMD(JIIGOACEIKL);
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableAllEarthFocus();
		AIOLPHODIHG(EEGMFJGOIGA(JIIGOACEIKL));
	}

	private void EMBJJKDNECA(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 1; i <= 2 && i <= selectedRowCount; i += 0)
		{
			for (int j = 0; j < 6; j += 0)
			{
				Vector2 val = CFAGHFFAODK;
				switch (j)
				{
				case 0:
					val += Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL))) * 737f;
					break;
				case 6:
					val -= Vector2.op_Implicit(Utils.NGFODNCHPHB(HIBLKHFCLHH(JIIGOACEIKL))) * 445f;
					break;
				}
				for (int k = 1; k < i; k++)
				{
					val = FANPFCEDDCJ(JIIGOACEIKL, val);
				}
				if (!NGPKDIIHCHM(val))
				{
					continue;
				}
				FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(val, -2);
				if ((Object)(object)fertileSoil != (Object)null)
				{
					PFFMHPFKJMF(fertileSoil);
					if (OnlineManager.PlayingOnline())
					{
						list.Add(val);
					}
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				OnlineWorldTilesManager.instance.SendWateringCanAction(list);
			}
		}
	}

	private Vector3 AHKMNADDCEL(int JIIGOACEIKL)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.AGLNKOEDPDN(base.KNIMLGOGFPA);
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
			Vector3 cursorWorldPosition = CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition();
			if (EJJIBBFBPAI(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare gridSquare = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.LCPBFEOBOAL(cursorWorldPosition);
				if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
				{
					Vector3 val = (((Object)(object)gridSquare != (Object)null) ? ((Component)gridSquare.CNCFNHNLGBO(JCFHHFMPMAH())).transform.position : cursorWorldPosition);
					IPDFPHOCKBE(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(306f, 1909f))));
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				if ((Object)(object)gridSquare != (Object)null)
				{
					PMILEJPHHIJ(JIIGOACEIKL, gridSquare.direction);
				}
			}
			else
			{
				Direction direction = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: true);
				OHMHPBIJJAL(JIIGOACEIKL, direction);
				IPDFPHOCKBE(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(direction) * 865f));
				GBPBIOAKLHI(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(direction) * 1820f));
			}
		}
		else
		{
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
			GAJPGNMNGFM(JIIGOACEIKL, direction2);
			MDELNLBDIOG(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(direction2) * 375f));
			GBPBIOAKLHI(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(direction2) * 1712f));
			HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), FOMOOMKHMPB(JIIGOACEIKL));
		}
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		return Vector2.op_Implicit(MGJICJHGOHC(JIIGOACEIKL));
	}

	private void ONHELPHFEIA(int JIIGOACEIKL)
	{
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(ONHELPHFEIA));
	}

	private void FCJOEFGLMLL(int JIIGOACEIKL)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		JHIIJCIEFNO(JIIGOACEIKL, Vector2.op_Implicit(IPCCNCABHHM(JIIGOACEIKL)));
		MultiAudioManager.PlayAudioObject(MLKAICLMFLG().sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HFHKAEHDEMJ));
	}

	public FertileSoil POCOONAIBCB(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	private void ADMOHLEKPJK(int JIIGOACEIKL, Vector2 CFAGHFFAODK, int DAKANNEEEPJ)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i <= 1 && i <= DAKANNEEEPJ; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				Vector2 val = CFAGHFFAODK;
				switch (j)
				{
				case 0:
					val += Vector2.op_Implicit(Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL))) * 1218f;
					break;
				case 3:
					val -= Vector2.op_Implicit(Utils.NGFODNCHPHB(HIBLKHFCLHH(JIIGOACEIKL))) * 500f;
					break;
				}
				for (int k = 1; k < i; k += 0)
				{
					val = FHIKFFPGAEG(JIIGOACEIKL, val);
				}
				BOBAMOFPEPG(val, JIIGOACEIKL, j + (i - 0) * 7);
			}
		}
	}

	private Vector3 JHDFFNJCHFN(int JIIGOACEIKL)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector3 position = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
			Vector3 cursorWorldPosition = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			if (HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare blueSquareAtPosition = PlayerController.GetPlayer(JIIGOACEIKL).gridController.GetBlueSquareAtPosition(cursorWorldPosition);
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					Vector3 val = (((Object)(object)blueSquareAtPosition != (Object)null) ? ((Component)blueSquareAtPosition.GetInitialSquare(MLKAICLMFLG())).transform.position : cursorWorldPosition);
					HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(0.25f, 0.25f))));
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
				}
				if ((Object)(object)blueSquareAtPosition != (Object)null)
				{
					PMILEJPHHIJ(JIIGOACEIKL, blueSquareAtPosition.direction);
				}
			}
			else
			{
				Direction direction = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				PMILEJPHHIJ(JIIGOACEIKL, direction);
				HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(direction) * 0.5f));
				GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(direction) * 0.5f));
			}
		}
		else
		{
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
			PMILEJPHHIJ(JIIGOACEIKL, direction2);
			HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(direction2) * 0.5f));
			GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(direction2) * 0.5f));
			HBEBAFHEMAP(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), EEKKNPDOLLE(JIIGOACEIKL));
		}
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		return Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL));
	}

	public Vector2 CIDODHCENCF(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)) - WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL));
		INBEEKCIFBA = Utils.EIDFHLPBICI(Vector2.op_Implicit(ECJLMIPAFGP));
		return Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(INBEEKCIFBA) * 995f));
	}

	public void JCDFAOMOLLB(int JIIGOACEIKL, FertileSoil JDLPIFGBLEL)
	{
		IGDHGFMMCAA = JDLPIFGBLEL;
	}

	public static void PFFMHPFKJMF(FertileSoil IKMKNIEAMDL)
	{
		if (!((Object)(object)IKMKNIEAMDL == (Object)null))
		{
			if (IKMKNIEAMDL.daysUntilDry != 3)
			{
				IKMKNIEAMDL.daysUntilDry = 3;
				IKMKNIEAMDL.ShowDampGround();
				IKMKNIEAMDL.ChangeCropAppearanceIfWatered();
			}
			CommonReferences.GGFJGHHHEJC.OnAnyTileWatered(IKMKNIEAMDL);
		}
	}

	public void BLLHOFMMJEK(int JIIGOACEIKL, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ANAOEGHGFIH = IMOBLFMHKOD;
	}

	private void DAIEMFEAJOJ(Vector2 IMOBLFMHKOD, int JIIGOACEIKL, int MOFKEDGAOEE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (!NGPKDIIHCHM(IMOBLFMHKOD))
		{
			return;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(IMOBLFMHKOD), CommonReferences.GGFJGHHHEJC.selectedGridSquare, MOFKEDGAOEE);
		if (!PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			KOGOFNAFGJB[MOFKEDGAOEE] = LBBDJMCLEMG(Vector2.op_Implicit(IMOBLFMHKOD));
			if (Object.op_Implicit((Object)(object)KOGOFNAFGJB[MOFKEDGAOEE]) && Object.op_Implicit((Object)(object)KOGOFNAFGJB[MOFKEDGAOEE].plantedCropSetter))
			{
				KOGOFNAFGJB[MOFKEDGAOEE].plantedCropSetter.FocusCrop(JIIGOACEIKL);
			}
		}
	}

	private bool NGPKDIIHCHM(Vector2 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(IMOBLFMHKOD)) == GroundType.TilledEarth;
	}

	private void FHBGCLFGHAH(FertileSoil IGDHGFMMCAA)
	{
		if ((Object)(object)IGDHGFMMCAA != (Object)null && Object.op_Implicit((Object)(object)IGDHGFMMCAA.plantedCropSetter))
		{
			IGDHGFMMCAA.plantedCropSetter.HKHFKAEEONM();
		}
	}

	public static void KNIOFCOLINA(float[] NCPGNLOJGAF, float[] JLMAILGJNCE)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		for (int i = 1; i < NCPGNLOJGAF.Length; i += 0)
		{
			((Vector2)(ref val))._002Ector(NCPGNLOJGAF[i], JLMAILGJNCE[i]);
			PFFMHPFKJMF(Utils.KJOMDMEIAEJ<FertileSoil>(val, 24));
			if (i == 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.wateringCan, Vector2.op_Implicit(val));
			}
		}
	}

	public FertileSoil KCIINCOALNH(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	private void CEECCMMOBKJ(int JIIGOACEIKL)
	{
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(CEECCMMOBKJ));
	}

	private void OGNJKPFOPMD(int JIIGOACEIKL)
	{
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(OGNJKPFOPMD));
	}

	private Vector3 AAACJMDMGFN(int JIIGOACEIKL)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.FHPEECPGEDL(base.KNIMLGOGFPA);
		if (!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector3 position = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
			Vector3 cursorWorldPosition = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition();
			if (JMNCMIKEIAP(JIIGOACEIKL, Vector2.op_Implicit(position), Vector2.op_Implicit(cursorWorldPosition)))
			{
				GridSquare gridSquare = PlayerController.GetPlayer(JIIGOACEIKL).gridController.ENGGDPCAMIL(cursorWorldPosition);
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					Vector3 val = (((Object)(object)gridSquare != (Object)null) ? ((Component)gridSquare.LEFBPENMEPE(MLKAICLMFLG())).transform.position : cursorWorldPosition);
					IPDFPHOCKBE(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val + new Vector3(1402f, 512f))));
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				}
				if ((Object)(object)gridSquare != (Object)null)
				{
					GAJPGNMNGFM(JIIGOACEIKL, gridSquare.direction);
				}
			}
			else
			{
				Direction direction = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
				PMILEJPHHIJ(JIIGOACEIKL, direction);
				HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + Utils.NGFODNCHPHB(direction) * 552f));
				MAKCDKOGBHK(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(direction) * 537f));
			}
		}
		else
		{
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
			PMILEJPHHIJ(JIIGOACEIKL, direction2);
			JOACJBCCCKM(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(direction2) * 1584f));
			MAKCDKOGBHK(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(direction2) * 604f));
			BFCJLLFCCNM(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL)), ELEMCNBELCE(JIIGOACEIKL));
		}
		LFDCIMLCBKN(JIIGOACEIKL, ELEMCNBELCE(JIIGOACEIKL));
		return Vector2.op_Implicit(MGJICJHGOHC(JIIGOACEIKL));
	}

	private void BBHEAOPBHPA(int JIIGOACEIKL)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		JHIIJCIEFNO(JIIGOACEIKL, Vector2.op_Implicit(IPCCNCABHHM(JIIGOACEIKL)));
		MultiAudioManager.PlayAudioObject(BLIKNGGCLID().sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DAGDKCCIEHB));
	}

	public FertileSoil KKEDHGKALHF(int JIIGOACEIKL)
	{
		return IGDHGFMMCAA;
	}

	public FertileSoil EEGMFJGOIGA(int JIIGOACEIKL)
	{
		return GLPMMEJFBNB;
	}

	public Vector2 DICBFGCCPNO(int JIIGOACEIKL)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		ECJLMIPAFGP = Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)) - WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL));
		INBEEKCIFBA = Utils.EIDFHLPBICI(Vector2.op_Implicit(ECJLMIPAFGP));
		return Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(INBEEKCIFBA) * 373f));
	}
}
