using System;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class SpadeInstance : ToolInstance
{
	public enum SpadeActionType
	{
		ChangeGround
	}

	private static Vector2 BKNEGILJAEL = Vector2.zero;

	private static FertileSoil JPKDEFCJNGJ;

	private static FertileSoil NNAECFAILLG;

	private InputByProximity LFBNPHHABDK;

	private Tree FFBBBJKKFGB;

	private OEGGFCDCHLE CCEAIHABKLA;

	private bool IMLECPKHMPI;

	private bool OKNOJJEFEBE;

	private Spade ADGMFJHGIGA => (Spade)item;

	public override bool HEKGALMDLIL(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL, LJOINCBGCBP: false)));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
		HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)))));
		PLNGELGLDLP(JIIGOACEIKL);
		ButtonsContext.SetPosition(JIIGOACEIKL, Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL) + Vector2.up * 0.3f));
		if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
		{
			LBEDOABMKJB(JIIGOACEIKL, HGECFPCPOHN(JIIGOACEIKL), EHODBEAJFLF(JIIGOACEIKL), selectedRowCount);
			if (!PlayerController.GetPlayer(JIIGOACEIKL).moving)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Remove"));
			}
			JPKDEFCJNGJ.plantedCropSetter.FocusCrop(JIIGOACEIKL);
		}
		else if (!IMLECPKHMPI || FOFLMHDABPG(JIIGOACEIKL) != HGECFPCPOHN(JIIGOACEIKL))
		{
			if (!GOCEDDNOMPN(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL))))
			{
				ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL)), CommonReferences.GGFJGHHHEJC.redSelectedGridSquare);
			}
			else
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).moving)
				{
					if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL)), null) || WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL))) == GroundType.Grass)
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Remove"));
					}
					else
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Plant"));
					}
				}
				IMLECPKHMPI = true;
				LBEDOABMKJB(JIIGOACEIKL, HGECFPCPOHN(JIIGOACEIKL), EHODBEAJFLF(JIIGOACEIKL), selectedRowCount);
			}
		}
		else if (!IMLECPKHMPI)
		{
			LBEDOABMKJB(JIIGOACEIKL, HGECFPCPOHN(JIIGOACEIKL), EHODBEAJFLF(JIIGOACEIKL), selectedRowCount);
		}
		return true;
	}

	public override bool NBFBPMNMBJG(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL, LJOINCBGCBP: false)));
			NNAECFAILLG = JPKDEFCJNGJ;
			JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(EEKKNPDOLLE(JIIGOACEIKL));
			if ((Object)(object)NNAECFAILLG != (Object)null && (Object)(object)NNAECFAILLG.plantedCropSetter != (Object)null && (Object)(object)NNAECFAILLG != (Object)(object)JPKDEFCJNGJ)
			{
				NNAECFAILLG.plantedCropSetter.UnfocusCrop();
				NNAECFAILLG = JPKDEFCJNGJ;
			}
			if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null && NewTutorialManager.KillCropBlocked())
			{
				return false;
			}
			if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
				return true;
			}
			if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
			{
				return false;
			}
			if (WorldGrid.NALIAAMAKAL(Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL)), Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).GetTilemaps(SeasonManager.EECEKHKAAIH)))
			{
				return false;
			}
			LFBNPHHABDK = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
			if (Object.op_Implicit((Object)(object)LFBNPHHABDK) && Object.op_Implicit((Object)(object)LFBNPHHABDK.mainGameObject.GetComponent<HoleInGround>()))
			{
				return false;
			}
			Vector3 iMOBLFMHKOD = Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL));
			GroundType groundType = WorldGrid.NCEHFMPBBAK(iMOBLFMHKOD);
			if ((groundType == GroundType.Grass || groundType == GroundType.Ground || groundType == GroundType.Stone) && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				return !WorldGrid.GJHHDIJOILG(iMOBLFMHKOD);
			}
			return false;
		}
		if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL) != (Object)null)
		{
			return false;
		}
		if (KCFEHLJDAPN(JIIGOACEIKL) != null)
		{
			return false;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
		return true;
	}

	public static void MBCPIHHCPIO(SpadeActionType BJDFONAKNJP, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (BJDFONAKNJP == SpadeActionType.ChangeGround)
		{
			EBKAAAGIEHB(0, DEACEMMGPHA, DGKJGLMBONI, null);
		}
	}

	private void LICNMOEAGFP(int JIIGOACEIKL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cFAGHFFAODK = DMJBEGINKAG(JIIGOACEIKL);
		OBOAKKIIOEC(JIIGOACEIKL, cFAGHFFAODK);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.AFAAEDALPII(JIIGOACEIKL, ControllersDatabaseAccessor.GHLPAPHABNO((ControllersDatabase.VibrationMaterial)6));
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(AEOAPLPCFMF));
	}

	private OEGGFCDCHLE KCFEHLJDAPN(int JIIGOACEIKL)
	{
		return CCEAIHABKLA;
	}

	private void MPPMCMJFGJP(int JIIGOACEIKL)
	{
		OOJEMLIJNHM(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LPNELFNCDMC());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MPPMCMJFGJP));
	}

	private void AEOAPLPCFMF(int JIIGOACEIKL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cFAGHFFAODK = GFEBNOIMOGI(JIIGOACEIKL);
		FFMNOIOIADK(JIIGOACEIKL, cFAGHFFAODK);
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.IHLIANLOGMB(ControllersDatabase.VibrationMaterial.Spade));
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(PKDKLBPFKPH));
	}

	public override void IOCKFAELDMD(int JIIGOACEIKL)
	{
		base.IOCKFAELDMD(JIIGOACEIKL);
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableAllEarthFocus();
	}

	private void PKDKLBPFKPH(int JIIGOACEIKL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cFAGHFFAODK = HGECFPCPOHN(JIIGOACEIKL);
		AMMEOJPNHHB(JIIGOACEIKL, cFAGHFFAODK);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.Spade));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(PKDKLBPFKPH));
	}

	private OEGGFCDCHLE JLBIAMHMLCM()
	{
		if ((Object)(object)LFBNPHHABDK == (Object)null)
		{
			return null;
		}
		if ((Object)(object)LFBNPHHABDK.mainGameObject == (Object)null)
		{
			return null;
		}
		return LFBNPHHABDK.mainGameObject.GetComponent<OEGGFCDCHLE>();
	}

	public Vector2 FOFLMHDABPG(int JIIGOACEIKL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	private void FIMHKHBBCDE(int JIIGOACEIKL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cFAGHFFAODK = GFEBNOIMOGI(JIIGOACEIKL);
		FFMNOIOIADK(JIIGOACEIKL, cFAGHFFAODK);
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().shovelSfx, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.NPADNPPICKO((ControllersDatabase.VibrationMaterial)8));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(GMAAEAAJBLN));
	}

	private void MAGFHLAPKKO(int JIIGOACEIKL, OEGGFCDCHLE PEJHJFMDGBH)
	{
		CCEAIHABKLA = PEJHJFMDGBH;
	}

	private OEGGFCDCHLE ILHDFGGHHHB()
	{
		if ((Object)(object)LFBNPHHABDK == (Object)null)
		{
			return null;
		}
		if ((Object)(object)LFBNPHHABDK.mainGameObject == (Object)null)
		{
			return null;
		}
		return LFBNPHHABDK.mainGameObject.GetComponent<OEGGFCDCHLE>();
	}

	public void OOBPJJONKHD(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(GBLBGKCDIPK));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	public override void NFHHKCIBLDC(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(JHDFFNJCHFN(JIIGOACEIKL, LJOINCBGCBP: true)));
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.SetGridInfo(base.KNIMLGOGFPA);
	}

	private void KCCEDJAIIJE(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public void HEFLJLEKBKO(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(FKGAONBLEEB));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = true;
		}
	}

	private void BLHKEGOHAHP(int JIIGOACEIKL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cFAGHFFAODK = IMMLPHODPFK(JIIGOACEIKL);
		FFMNOIOIADK(JIIGOACEIKL, cFAGHFFAODK);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().shovelSfx, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.NPADNPPICKO(ControllersDatabase.VibrationMaterial.Ax));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(AEOAPLPCFMF));
	}

	private void MBOMJHNCHHM(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int PHECDJHBEHE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		for (int i = 0; i <= 4 && i <= PHECDJHBEHE; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 901f * (float)(i - 0) * val;
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(val2), POEEJFEHFGF(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 0);
		}
		for (int j = PHECDJHBEHE + 1; j <= 6; j++)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableEarthFocus(j - 0);
		}
	}

	private void JOCAOMOEPDK(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int PHECDJHBEHE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		for (int i = 0; i <= 1 && i <= PHECDJHBEHE; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 1749f * (float)(i - 1) * val;
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(val2), KBFNCADGNLN(Vector2.op_Implicit(val2)) ? CommonReferences.MNFMOEKMJKN().selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
		}
		for (int j = PHECDJHBEHE + 1; j <= 4; j += 0)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.AOCCEKNHIMG(j - 1);
		}
	}

	private void EJADHBAOAKN(int JIIGOACEIKL)
	{
		HNJEDEJNPNL(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LPNELFNCDMC());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(AILFPGHLKAO));
	}

	private void EAHKOGGJMHJ(int JIIGOACEIKL)
	{
		OOJEMLIJNHM(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LMHDGKJIHMK());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(AILFPGHLKAO));
	}

	private Vector3 JHDFFNJCHFN(int JIIGOACEIKL, bool LJOINCBGCBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		Vector2 ePLKICANCAL = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector2 val = Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition());
			if (HBEBAFHEMAP(JIIGOACEIKL, ePLKICANCAL, val))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
				{
					GridSquare blueSquareAtPosition = PlayerController.GetPlayer(JIIGOACEIKL).gridController.GetBlueSquareAtPosition(Vector2.op_Implicit(val));
					Vector3 val2 = (((Object)(object)blueSquareAtPosition != (Object)null) ? ((Component)blueSquareAtPosition.GetInitialSquare(MLKAICLMFLG())).transform.position : Vector2.op_Implicit(val));
					HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val2 + new Vector3(0.25f, 0.25f))));
					if ((Object)(object)blueSquareAtPosition != (Object)null)
					{
						PMILEJPHHIJ(JIIGOACEIKL, blueSquareAtPosition.direction);
					}
					GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: true);
				}
			}
			else if (LJOINCBGCBP || PlayerController.GetPlayer(JIIGOACEIKL).moving)
			{
				GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
				Direction direction = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				Vector3 val3 = Utils.NGFODNCHPHB(direction);
				HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + val3 * 0.5f));
				PMILEJPHHIJ(JIIGOACEIKL, direction);
				GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(val3 * 0.5f));
			}
		}
		else
		{
			GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(direction2) * 0.5f));
			PMILEJPHHIJ(JIIGOACEIKL, direction2);
			GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 0.5f));
			HBEBAFHEMAP(JIIGOACEIKL, ePLKICANCAL, EEKKNPDOLLE(JIIGOACEIKL));
		}
		AGAJDKDCEHJ(JIIGOACEIKL, EEKKNPDOLLE(JIIGOACEIKL));
		return Vector2.op_Implicit(EEKKNPDOLLE(JIIGOACEIKL));
	}

	private void DNIDKJIFNHG(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(DNIDKJIFNHG));
	}

	public bool GOCEDDNOMPN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.GJHHDIJOILG(IMOBLFMHKOD))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) == GroundType.TilledEarth)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD));
			if (Object.op_Implicit((Object)(object)fertileSoil) && (Object)(object)fertileSoil.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				return true;
			}
			return false;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != ZoneType.WithoutZone)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return true;
		}
		return false;
	}

	public void KFKBKIMIAGP(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(KFKBKIMIAGP));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = true;
		}
	}

	private void GMAAEAAJBLN(int JIIGOACEIKL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cFAGHFFAODK = GFEBNOIMOGI(JIIGOACEIKL);
		ECLHLBCDECN(JIIGOACEIKL, cFAGHFFAODK);
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.AFAAEDALPII(JIIGOACEIKL, ControllersDatabaseAccessor.FCOPONLHAPP((ControllersDatabase.VibrationMaterial)7));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(LICNMOEAGFP));
	}

	private Vector2 ALPGDJGJAKA(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		Vector2 val2 = CFAGHFFAODK - val;
		if (Mathf.Abs(val2.x) > Mathf.Abs(val2.y))
		{
			if (!(val2.x > 0f))
			{
				return Vector2.left;
			}
			return Vector2.right;
		}
		if (Mathf.Abs(val2.y) > 0.01f)
		{
			if (!(val2.y > 0f))
			{
				return Vector2.down;
			}
			return Vector2.up;
		}
		return Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)));
	}

	private OEGGFCDCHLE FKFNELLLGMC(int JIIGOACEIKL)
	{
		return CCEAIHABKLA;
	}

	private void AILFPGHLKAO(int JIIGOACEIKL)
	{
		HPFCEDGAFCH(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(AILFPGHLKAO));
	}

	private void HBFCKBAPOEK(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public Vector2 DNICPLBIHLB(int JIIGOACEIKL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	public void EEBPHLFOCLD(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(DFJBAJHNOIE));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	private void NBKILLMCEKH(int JIIGOACEIKL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 cFAGHFFAODK = GFEBNOIMOGI(JIIGOACEIKL);
		FFMNOIOIADK(JIIGOACEIKL, cFAGHFFAODK);
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.shovelSfx, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.NPADNPPICKO(ControllersDatabase.VibrationMaterial.Hoe));
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(LICNMOEAGFP));
	}

	public bool POEEJFEHFGF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.GJHHDIJOILG(IMOBLFMHKOD))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) == (GroundType.Grass | GroundType.Ground))
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD), -77);
			if (Object.op_Implicit((Object)(object)fertileSoil) && (Object)(object)fertileSoil.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				return true;
			}
			return true;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != ZoneType.WithoutZone)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return false;
		}
		return false;
	}

	private Tree KIAHFFBCGCF(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void HKDFIGFHDPM(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public SpadeInstance(SpadeInstance CICPAOIHLJK)
		: base(CICPAOIHLJK)
	{
	}

	private void BEICKAOMMNK(int JIIGOACEIKL)
	{
		PGBKOLMPPHF(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(EJADHBAOAKN));
	}

	public static void BLHICNGCDLD(SpadeActionType BJDFONAKNJP, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (BJDFONAKNJP == SpadeActionType.ChangeGround)
		{
			AJIHIGGJJNH(0, DEACEMMGPHA, DGKJGLMBONI, null);
		}
	}

	public void FPPLLGMFGHN(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EMFNJBMFNNJ));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	private bool OFAKNHNLKGI(int JIIGOACEIKL, bool KLGOCJMGKFO, Vector2 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		OKNOJJEFEBE = true;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(HGECFPCPOHN(JIIGOACEIKL));
		if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(IMOBLFMHKOD);
		}
		if (KCFEHLJDAPN(JIIGOACEIKL) != null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(IMOBLFMHKOD);
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold"))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Spade();
		}
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD), null))
		{
			((Renderer)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.spadeSpriteRenderer).material = ADGMFJHGIGA.snowSpadeMaterial.material;
		}
		else
		{
			((Renderer)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.spadeSpriteRenderer).material = ADGMFJHGIGA.groundSpadeMaterial.material;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(DNIDKJIFNHG));
		CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(PKDKLBPFKPH));
		CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(FKGAONBLEEB));
		return true;
	}

	public void FKGAONBLEEB(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(FKGAONBLEEB));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	public override void ActionEnd(int JIIGOACEIKL)
	{
		OKNOJJEFEBE = false;
		IMLECPKHMPI = false;
	}

	public Vector2 AICNNFCMPDL(int JIIGOACEIKL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	private void LBEDOABMKJB(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int PHECDJHBEHE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		for (int i = 1; i <= 4 && i <= PHECDJHBEHE; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 0.5f * (float)(i - 1) * val;
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(val2), GOCEDDNOMPN(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
		}
		for (int j = PHECDJHBEHE + 1; j <= 4; j++)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableEarthFocus(j - 1);
		}
	}

	public void EMFNJBMFNNJ(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(DFJBAJHNOIE));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = true;
		}
	}

	public void GKONPMECJLB(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EEBPHLFOCLD));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = true;
		}
	}

	private OEGGFCDCHLE NMJDALPONIM(int JIIGOACEIKL)
	{
		return CCEAIHABKLA;
	}

	private void FFMNOIOIADK(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)));
		if (NMJDALPONIM(JIIGOACEIKL) != null)
		{
			LOMHCBDFPCM(JIIGOACEIKL, 7);
			NMJDALPONIM(JIIGOACEIKL).Dig(JIIGOACEIKL, (byte)(OMAPDOLLKGA().toolLevel - 0));
			return;
		}
		if ((Object)(object)KIAHFFBCGCF(JIIGOACEIKL) != (Object)null)
		{
			KGGNKGFPOHF(JIIGOACEIKL, 7);
			IAGHOJNHIPG(JIIGOACEIKL).FIBEDOKCFDA();
			if ((Object)(object)EGPMDLHKCIE(JIIGOACEIKL).LJAIKIENADM() != (Object)null)
			{
				KIAHFFBCGCF(JIIGOACEIKL).JMNCIKLLOBC().GNMOKLCKMOJ(EGPMDLHKCIE(JIIGOACEIKL), DBKCJHDNBCG: true);
			}
			else
			{
				EGPMDLHKCIE(JIIGOACEIKL).ECAJCNALDAO();
			}
			return;
		}
		GroundType dGKJGLMBONI = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(CFAGHFFAODK));
		for (int i = 0; i <= 1 && i <= selectedRowCount; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 105f * (float)(i - 0) * val;
			if (!POEEJFEHFGF(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(val2, -121);
			if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				Utils.BLPDAEHPOBA(((Component)JPKDEFCJNGJ.plantedCropSetter).gameObject);
				continue;
			}
			if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
			{
				switch (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2)))
				{
				case GroundType.Grass:
					FOPJAIJDFKP(JIIGOACEIKL, 1);
					break;
				case GroundType.Grass | GroundType.TilledEarth:
					JONHEOKBPIC(JIIGOACEIKL, 1);
					break;
				case ~(GroundType.Grass | GroundType.Sand):
					NOCJKKFCNKG(JIIGOACEIKL, 6);
					break;
				}
			}
			BKNEGILJAEL = val2;
			if (OnlineManager.PlayingOnline())
			{
				OnlinePlayerActionsManager.instance.MJGJCFFGOAF(SpadeActionType.ChangeGround, val2, dGKJGLMBONI);
			}
			else
			{
				AJIHIGGJJNH(JIIGOACEIKL, val2, dGKJGLMBONI, ONNAKONNOLN());
			}
		}
	}

	public void GNFCNBANFNP(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EEBPHLFOCLD));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	private OEGGFCDCHLE CFCCHMFLKHG()
	{
		if ((Object)(object)LFBNPHHABDK == (Object)null)
		{
			return null;
		}
		if ((Object)(object)LFBNPHHABDK.mainGameObject == (Object)null)
		{
			return null;
		}
		return LFBNPHHABDK.mainGameObject.GetComponent<OEGGFCDCHLE>();
	}

	private void IPFKJLGGLMA(int JIIGOACEIKL)
	{
		OOJEMLIJNHM(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(IPFKJLGGLMA));
	}

	private Tree IAGHOJNHIPG(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void LFNIDEPEOOB(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LMHDGKJIHMK());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MPPMCMJFGJP));
	}

	public static void NOPMIMMBGNL(SpadeActionType BJDFONAKNJP, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (BJDFONAKNJP == SpadeActionType.ChangeGround)
		{
			PCIABJAMJLD(1, DEACEMMGPHA, DGKJGLMBONI, null);
		}
	}

	private OEGGFCDCHLE GAFNLNMICIG()
	{
		if ((Object)(object)LFBNPHHABDK == (Object)null)
		{
			return null;
		}
		if ((Object)(object)LFBNPHHABDK.mainGameObject == (Object)null)
		{
			return null;
		}
		return LFBNPHHABDK.mainGameObject.GetComponent<OEGGFCDCHLE>();
	}

	private void GHFKCGOKDFI(int JIIGOACEIKL, OEGGFCDCHLE PEJHJFMDGBH)
	{
		CCEAIHABKLA = PEJHJFMDGBH;
	}

	public static void NHHFABHENDG(SpadeActionType BJDFONAKNJP, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (BJDFONAKNJP == SpadeActionType.ChangeGround)
		{
			AJIHIGGJJNH(1, DEACEMMGPHA, DGKJGLMBONI, null);
		}
	}

	public static void BNODBAKKIBH(SpadeActionType BJDFONAKNJP, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (BJDFONAKNJP == SpadeActionType.ChangeGround)
		{
			KDHBPMNGDIF(1, DEACEMMGPHA, DGKJGLMBONI, null);
		}
	}

	private Vector2 EINIBMHNEGF(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position);
		Vector2 val2 = CFAGHFFAODK - val;
		if (Mathf.Abs(val2.x) > Mathf.Abs(val2.y))
		{
			if (!(val2.x > 1341f))
			{
				return Vector2.left;
			}
			return Vector2.right;
		}
		if (Mathf.Abs(val2.y) > 825f)
		{
			if (!(val2.y > 1917f))
			{
				return Vector2.down;
			}
			return Vector2.up;
		}
		return Vector2.op_Implicit(Utils.NGFODNCHPHB(HIBLKHFCLHH(JIIGOACEIKL)));
	}

	public bool GHIBOBKCOFG(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.GJHHDIJOILG(IMOBLFMHKOD, JGDOHPCLJPM: true))
		{
			return false;
		}
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) == GroundType.None)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD), 17);
			if (Object.op_Implicit((Object)(object)fertileSoil) && (Object)(object)fertileSoil.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				return false;
			}
			return false;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != 0)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return false;
		}
		return false;
	}

	private void EBAGKGCOKLH(int JIIGOACEIKL, Tree AKDLBHNCKJO)
	{
		FFBBBJKKFGB = AKDLBHNCKJO;
	}

	public bool JOFOMPKFJIB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.GJHHDIJOILG(IMOBLFMHKOD, JGDOHPCLJPM: true))
		{
			return true;
		}
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) == GroundType.Ground)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD), -39);
			if (Object.op_Implicit((Object)(object)fertileSoil) && (Object)(object)fertileSoil.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				return true;
			}
			return true;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != 0)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	private Spade ONNAKONNOLN()
	{
		return (Spade)item;
	}

	private static void EBKAAAGIEHB(int JIIGOACEIKL, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI, Item PLJHEJFDMJB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DEACEMMGPHA));
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(DEACEMMGPHA), null))
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			WorldGrid.MMOHADHAAGD(GBKMNAPGIOM: WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA)) ? (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) : ((WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 1311f)) || WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 1339f))) ? GroundType.Grass : (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth)), IMOBLFMHKOD: Vector2.op_Implicit(DEACEMMGPHA), BAIMHDBJPDK: PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.ChopRock);
		}
		else if (groundType == GroundType.Grass && DGKJGLMBONI == GroundType.Grass)
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: false);
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground | GroundType.TilledEarth, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.SmashSnowman);
		}
		else if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && DGKJGLMBONI == GroundType.TilledEarth)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.None, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer, CDPAMNIPPEC: true);
		}
		else if (groundType == ~GroundType.Ground)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.None, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer, CDPAMNIPPEC: true);
			PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(PLJHEJFDMJB.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		}
	}

	private Vector3 HGKKMBNJMOG(int JIIGOACEIKL, bool LJOINCBGCBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		Vector2 ePLKICANCAL = Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL));
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) || CursorManager.GetControlCursorWithGamepad(JIIGOACEIKL))
		{
			Vector2 val = Vector2.op_Implicit(CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition());
			if (JMNCMIKEIAP(JIIGOACEIKL, ePLKICANCAL, val))
			{
				if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
				{
					GridSquare gridSquare = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.MBAJDGLHILA(Vector2.op_Implicit(val));
					Vector3 val2 = (((Object)(object)gridSquare != (Object)null) ? ((Component)gridSquare.JFDJFHLDPFC(LMHDGKJIHMK())).transform.position : Vector2.op_Implicit(val));
					JOACJBCCCKM(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(val2 + new Vector3(993f, 640f))));
					if ((Object)(object)gridSquare != (Object)null)
					{
						JGALICBLIHB(JIIGOACEIKL, gridSquare.direction);
					}
					AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: false);
				}
			}
			else if (LJOINCBGCBP || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
			{
				AMAJBOOJNIG(JIIGOACEIKL, NKEPKDBENHM: true);
				Direction direction = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
				Vector3 val3 = Utils.NGFODNCHPHB(direction);
				HJINPCNEJCB(JIIGOACEIKL, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + val3 * 200f));
				GAJPGNMNGFM(JIIGOACEIKL, direction);
				GNKMEPDGPCB(JIIGOACEIKL, Vector2.op_Implicit(val3 * 1251f));
			}
		}
		else
		{
			GJDOGKEFFHE(JIIGOACEIKL, NKEPKDBENHM: false);
			Direction direction2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC;
			MDELNLBDIOG(JIIGOACEIKL, Vector2.op_Implicit(PlayerController.GetPlayerPosition(JIIGOACEIKL) + Utils.NGFODNCHPHB(direction2) * 3f));
			JGALICBLIHB(JIIGOACEIKL, direction2);
			MKCJJIIANJD(JIIGOACEIKL, Vector2.op_Implicit(Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC) * 222f));
			HBEBAFHEMAP(JIIGOACEIKL, ePLKICANCAL, EEKKNPDOLLE(JIIGOACEIKL));
		}
		AGAJDKDCEHJ(JIIGOACEIKL, INGEAJAMBGM(JIIGOACEIKL));
		return Vector2.op_Implicit(MGJICJHGOHC(JIIGOACEIKL));
	}

	private void BAHMIPANLNE(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int PHECDJHBEHE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		for (int i = 0; i <= 1 && i <= PHECDJHBEHE; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 192f * (float)(i - 1) * val;
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.EnableEarthFocus(Vector2.op_Implicit(val2), KBFNCADGNLN(Vector2.op_Implicit(val2)) ? CommonReferences.MNFMOEKMJKN().selectedGridSquare : CommonReferences.MNFMOEKMJKN().redSelectedGridSquare, i - 0);
		}
		for (int j = PHECDJHBEHE + 1; j <= 7; j++)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.IJNNJDEBFDJ(j - 1);
		}
	}

	public void GBLBGKCDIPK(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(GBLBGKCDIPK));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = true;
		}
	}

	private void DLJDNHNNOMK(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int PHECDJHBEHE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		for (int i = 0; i <= 8 && i <= PHECDJHBEHE; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 1641f * (float)(i - 0) * val;
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(Vector2.op_Implicit(val2), JOFOMPKFJIB(Vector2.op_Implicit(val2)) ? CommonReferences.MNFMOEKMJKN().selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
		}
		for (int j = PHECDJHBEHE + 1; j <= 1; j++)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.IJNNJDEBFDJ(j - 0);
		}
	}

	private void ECLHLBCDECN(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)));
		if (NMJDALPONIM(JIIGOACEIKL) != null)
		{
			LOMHCBDFPCM(JIIGOACEIKL, 5);
			LBKMMOPJOBO(JIIGOACEIKL).Dig(JIIGOACEIKL, (byte)(LMHDGKJIHMK().toolLevel - 0));
			return;
		}
		if ((Object)(object)KIAHFFBCGCF(JIIGOACEIKL) != (Object)null)
		{
			LOMHCBDFPCM(JIIGOACEIKL, 5);
			KIAHFFBCGCF(JIIGOACEIKL).BGPLFBABHLP();
			if ((Object)(object)EGPMDLHKCIE(JIIGOACEIKL).IDEHGNFCHNH() != (Object)null)
			{
				KIAHFFBCGCF(JIIGOACEIKL).KJBGIENFLHN().KDEMAAHCEEI(IAGHOJNHIPG(JIIGOACEIKL), DBKCJHDNBCG: true);
			}
			else
			{
				EGPMDLHKCIE(JIIGOACEIKL).KMLHBOIKODI();
			}
			return;
		}
		GroundType dGKJGLMBONI = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(CFAGHFFAODK));
		for (int i = 1; i <= 0 && i <= selectedRowCount; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 503f * (float)(i - 0) * val;
			if (!GHIBOBKCOFG(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(val2, 0);
			if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				Utils.BLPDAEHPOBA(((Component)JPKDEFCJNGJ.plantedCropSetter).gameObject);
				continue;
			}
			if (LCNPHFHDLOM(JIIGOACEIKL) == 0)
			{
				GroundType groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2));
				if (groundType == GroundType.Grass)
				{
					NOCJKKFCNKG(JIIGOACEIKL, 0);
				}
				else
				{
					switch (groundType)
					{
					case GroundType.Grass:
						NOCJKKFCNKG(JIIGOACEIKL, 3);
						break;
					case (GroundType)73:
						JONHEOKBPIC(JIIGOACEIKL, 8);
						break;
					}
				}
			}
			BKNEGILJAEL = val2;
			if (OnlineManager.PlayingOnline())
			{
				OnlinePlayerActionsManager.instance.NICFDAGKDBO(SpadeActionType.ChangeGround, val2, dGKJGLMBONI);
			}
			else
			{
				AJIHIGGJJNH(JIIGOACEIKL, val2, dGKJGLMBONI, ADGMFJHGIGA);
			}
		}
	}

	public bool KBFNCADGNLN(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.GJHHDIJOILG(IMOBLFMHKOD, JGDOHPCLJPM: true))
		{
			return true;
		}
		if (WorldGrid.NCEHFMPBBAK(IMOBLFMHKOD) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(IMOBLFMHKOD), 16);
			if (Object.op_Implicit((Object)(object)fertileSoil) && (Object)(object)fertileSoil.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				return false;
			}
			return false;
		}
		if (!WorldGrid.HENDJJEEOHE(IMOBLFMHKOD) && !WorldGrid.KCJGJHNIPGP(IMOBLFMHKOD))
		{
			if (!WorldGrid.LKBLKCFOEPA(IMOBLFMHKOD) || WorldGrid.AGKGGAFFFGM(IMOBLFMHKOD) != ZoneType.WithoutZone)
			{
				return WorldGrid.OINMGKCIGEJ(IMOBLFMHKOD, null);
			}
			return false;
		}
		return true;
	}

	public static void KOIIPMBLION(SpadeActionType BJDFONAKNJP, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (BJDFONAKNJP == SpadeActionType.ChangeGround)
		{
			AJIHIGGJJNH(0, DEACEMMGPHA, DGKJGLMBONI, null);
		}
	}

	public static void KOKPMJCDEEO(SpadeActionType BJDFONAKNJP, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (BJDFONAKNJP == SpadeActionType.ChangeGround)
		{
			EBKAAAGIEHB(0, DEACEMMGPHA, DGKJGLMBONI, null);
		}
	}

	private bool NFLJFGBCLGP(int JIIGOACEIKL, bool KLGOCJMGKFO, Vector2 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		OKNOJJEFEBE = true;
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(IMMLPHODPFK(JIIGOACEIKL));
		if ((Object)(object)KIAHFFBCGCF(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtNotDelay(IMOBLFMHKOD);
		}
		if (LLHEDMMAONE(JIIGOACEIKL) != null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(IMOBLFMHKOD);
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("Dialogue System/Conversation/TavernFilthy/Entry/4/Dialogue Text"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.Spade();
		}
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD), null))
		{
			((Renderer)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.spadeSpriteRenderer).material = ADGMFJHGIGA.snowSpadeMaterial.material;
		}
		else
		{
			((Renderer)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.spadeSpriteRenderer).material = ONNAKONNOLN().groundSpadeMaterial.material;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(EJADHBAOAKN));
		CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(PKDKLBPFKPH));
		CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(FKGAONBLEEB));
		return false;
	}

	private static void AJIHIGGJJNH(int JIIGOACEIKL, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI, Item PLJHEJFDMJB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DEACEMMGPHA));
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(DEACEMMGPHA), null))
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: true, BBHMAKKPFKB: false);
			WorldGrid.MMOHADHAAGD(GBKMNAPGIOM: WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA)) ? GroundType.Grass : ((!WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 711f)) && !WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 1499f))) ? (GroundType.Ground | GroundType.TilledEarth) : GroundType.None), IMOBLFMHKOD: Vector2.op_Implicit(DEACEMMGPHA), BAIMHDBJPDK: PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutGrass);
		}
		else if (groundType == GroundType.Grass && DGKJGLMBONI == GroundType.Grass)
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: false);
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.TilledEarth, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer);
			CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, ActionDone.PlantSeed);
		}
		else if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && DGKJGLMBONI == (GroundType.Ground | GroundType.TilledEarth))
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.None, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer, CDPAMNIPPEC: true);
		}
		else if (groundType == (GroundType)123)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Grass | GroundType.TilledEarth, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Spring, CDPAMNIPPEC: true);
			PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(PLJHEJFDMJB.JMDALJBNFML());
		}
	}

	public void DFJBAJHNOIE(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EMFNJBMFNNJ));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	private OEGGFCDCHLE LLHEDMMAONE(int JIIGOACEIKL)
	{
		return CCEAIHABKLA;
	}

	[SpecialName]
	private Spade FGICJFAGEFO()
	{
		return (Spade)item;
	}

	private static void PCIABJAMJLD(int JIIGOACEIKL, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI, Item PLJHEJFDMJB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DEACEMMGPHA));
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(DEACEMMGPHA), null))
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: false, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
			WorldGrid.MMOHADHAAGD(GBKMNAPGIOM: WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA)) ? GroundType.Grass : ((!WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 1398f)) && !WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 1635f))) ? (GroundType.Grass | GroundType.TilledEarth) : GroundType.None), IMOBLFMHKOD: Vector2.op_Implicit(DEACEMMGPHA), BAIMHDBJPDK: PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, FONLCEPCGEL: Season.Spring, CDPAMNIPPEC: true);
			CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, ActionDone.SmashSnowman);
		}
		else if (groundType == GroundType.None && DGKJGLMBONI == GroundType.None)
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.TilledEarth, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer, CDPAMNIPPEC: true);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.TillEarth);
		}
		else if (groundType == (GroundType.Ground | GroundType.TilledEarth) && DGKJGLMBONI == GroundType.None)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Grass, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer);
		}
		else if (groundType == ~(GroundType.Stone | GroundType.Sand))
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground | GroundType.TilledEarth, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer);
			PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AddItem(PLJHEJFDMJB.JMDALJBNFML(), HMPDLIPFBGD: true);
		}
	}

	private void AMMEOJPNHHB(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(EHODBEAJFLF(JIIGOACEIKL)));
		if (KCFEHLJDAPN(JIIGOACEIKL) != null)
		{
			NOCJKKFCNKG(JIIGOACEIKL, 4);
			KCFEHLJDAPN(JIIGOACEIKL).Dig(JIIGOACEIKL, (byte)(MLKAICLMFLG().toolLevel - 1));
			return;
		}
		if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL) != (Object)null)
		{
			NOCJKKFCNKG(JIIGOACEIKL, 4);
			IAGHOJNHIPG(JIIGOACEIKL).SpawnDroppedItems();
			if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL).GetGenerator() != (Object)null)
			{
				IAGHOJNHIPG(JIIGOACEIKL).GetGenerator().DestroyForestElement(IAGHOJNHIPG(JIIGOACEIKL), DBKCJHDNBCG: true);
			}
			else
			{
				IAGHOJNHIPG(JIIGOACEIKL).DestroyTree();
			}
			return;
		}
		GroundType dGKJGLMBONI = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(CFAGHFFAODK));
		for (int i = 1; i <= 4 && i <= selectedRowCount; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 0.5f * (float)(i - 1) * val;
			if (!GOCEDDNOMPN(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(val2);
			if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				Utils.BLPDAEHPOBA(((Component)JPKDEFCJNGJ.plantedCropSetter).gameObject);
				continue;
			}
			if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
			{
				switch (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2)))
				{
				case GroundType.Grass:
					NOCJKKFCNKG(JIIGOACEIKL, 1);
					break;
				case GroundType.Ground:
					NOCJKKFCNKG(JIIGOACEIKL, 2);
					break;
				case GroundType.Stone:
					NOCJKKFCNKG(JIIGOACEIKL, 3);
					break;
				}
			}
			BKNEGILJAEL = val2;
			if (OnlineManager.PlayingOnline())
			{
				OnlinePlayerActionsManager.instance.StartSpadeAction(SpadeActionType.ChangeGround, val2, dGKJGLMBONI);
			}
			else
			{
				KDHBPMNGDIF(JIIGOACEIKL, val2, dGKJGLMBONI, ADGMFJHGIGA);
			}
		}
	}

	private void KMJCAFAJHHC(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(HIBLKHFCLHH(JIIGOACEIKL)));
		if (FKFNELLLGMC(JIIGOACEIKL) != null)
		{
			KGGNKGFPOHF(JIIGOACEIKL, 0);
			FKFNELLLGMC(JIIGOACEIKL).Dig(JIIGOACEIKL, (byte)(LPNELFNCDMC().toolLevel - 1));
			return;
		}
		if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL) != (Object)null)
		{
			NOCJKKFCNKG(JIIGOACEIKL, 7);
			EGPMDLHKCIE(JIIGOACEIKL).FIBEDOKCFDA();
			if ((Object)(object)KIAHFFBCGCF(JIIGOACEIKL).OPMCDMBOIHJ() != (Object)null)
			{
				KIAHFFBCGCF(JIIGOACEIKL).AMGGNFNIHJK().NEOBFNDLENE(EGPMDLHKCIE(JIIGOACEIKL), DBKCJHDNBCG: true);
			}
			else
			{
				EGPMDLHKCIE(JIIGOACEIKL).JNFCPKHAJOA();
			}
			return;
		}
		GroundType dGKJGLMBONI = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(CFAGHFFAODK));
		for (int i = 0; i <= 6 && i <= selectedRowCount; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 1450f * (float)(i - 0) * val;
			if (!POEEJFEHFGF(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(val2, 105);
			if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				Utils.BLPDAEHPOBA(((Component)JPKDEFCJNGJ.plantedCropSetter).gameObject);
				continue;
			}
			if (LCNPHFHDLOM(JIIGOACEIKL) == 0)
			{
				switch (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2)))
				{
				case GroundType.None:
					LOMHCBDFPCM(JIIGOACEIKL, 1);
					break;
				case GroundType.Grass:
					LOMHCBDFPCM(JIIGOACEIKL, 1);
					break;
				case (GroundType)(-78):
					KGGNKGFPOHF(JIIGOACEIKL, 2);
					break;
				}
			}
			BKNEGILJAEL = val2;
			if (OnlineManager.PlayingOnline())
			{
				OnlinePlayerActionsManager.instance.MJGJCFFGOAF((SpadeActionType)1, val2, dGKJGLMBONI);
			}
			else
			{
				AJIHIGGJJNH(JIIGOACEIKL, val2, dGKJGLMBONI, ONNAKONNOLN());
			}
		}
	}

	public override void LBMKLIDKHJD(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		IOCKFAELDMD(JIIGOACEIKL);
		IMLECPKHMPI = false;
		if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && Object.op_Implicit((Object)(object)JPKDEFCJNGJ.plantedCropSetter))
		{
			JPKDEFCJNGJ.plantedCropSetter.UnfocusCrop();
		}
	}

	public SpadeInstance(Item MEMGMDOCBOJ)
		: base(MEMGMDOCBOJ)
	{
	}

	public override bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			base.Action(JIIGOACEIKL, KLGOCJMGKFO);
			CDLGJOGGFGM(JIIGOACEIKL, null);
			if (NBFBPMNMBJG(JIIGOACEIKL) && GOCEDDNOMPN(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL))))
			{
				KCCEDJAIIJE(JIIGOACEIKL, null);
				if (KLGOCJMGKFO)
				{
					BKNEGILJAEL = Vector2.zero;
				}
				HCJIFAGBKHL(JIIGOACEIKL, Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(NJBOCFNALEJ(JIIGOACEIKL)))));
				if (HCFJKBIIMIK(JIIGOACEIKL) == 1 && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL))) != GroundType.Grass)
				{
					return false;
				}
				if (HCFJKBIIMIK(JIIGOACEIKL) == 2 && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL))) != GroundType.Ground)
				{
					return false;
				}
				if (HCFJKBIIMIK(JIIGOACEIKL) == 3 && WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(HGECFPCPOHN(JIIGOACEIKL))) != GroundType.Stone)
				{
					return false;
				}
				if (HCFJKBIIMIK(JIIGOACEIKL) == 4)
				{
					return false;
				}
				if (FOFLMHDABPG(JIIGOACEIKL) != HGECFPCPOHN(JIIGOACEIKL))
				{
					return OFAKNHNLKGI(JIIGOACEIKL, KLGOCJMGKFO, HGECFPCPOHN(JIIGOACEIKL));
				}
			}
			else
			{
				if (HCFJKBIIMIK(JIIGOACEIKL) != 0 && HCFJKBIIMIK(JIIGOACEIKL) != 4)
				{
					return false;
				}
				KCCEDJAIIJE(JIIGOACEIKL, null);
				LFBNPHHABDK = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
				if ((Object)(object)LFBNPHHABDK != (Object)null)
				{
					KCCEDJAIIJE(JIIGOACEIKL, LFBNPHHABDK.mainGameObject.GetComponent<Tree>());
					CDLGJOGGFGM(JIIGOACEIKL, CFCCHMFLKHG());
					if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL) != (Object)null && IAGHOJNHIPG(JIIGOACEIKL).canUseSpade)
					{
						return OFAKNHNLKGI(JIIGOACEIKL, KLGOCJMGKFO, Vector2.op_Implicit(((Component)LFBNPHHABDK).transform.position));
					}
					if (KCFEHLJDAPN(JIIGOACEIKL) != null)
					{
						return OFAKNHNLKGI(JIIGOACEIKL, KLGOCJMGKFO, Vector2.op_Implicit(((Component)LFBNPHHABDK).transform.position));
					}
				}
			}
		}
		return false;
	}

	public Vector2 KKCKDMNKFOB(int JIIGOACEIKL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	public Vector2 JIEODGMINJC(int JIIGOACEIKL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	private OEGGFCDCHLE BMHJFDAANCI()
	{
		if ((Object)(object)LFBNPHHABDK == (Object)null)
		{
			return null;
		}
		if ((Object)(object)LFBNPHHABDK.mainGameObject == (Object)null)
		{
			return null;
		}
		return LFBNPHHABDK.mainGameObject.GetComponent<OEGGFCDCHLE>();
	}

	private void CDLGJOGGFGM(int JIIGOACEIKL, OEGGFCDCHLE PEJHJFMDGBH)
	{
		CCEAIHABKLA = PEJHJFMDGBH;
	}

	private void OBOAKKIIOEC(int JIIGOACEIKL, Vector2 CFAGHFFAODK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(MKJKBKAKMAB(JIIGOACEIKL)));
		if (FKFNELLLGMC(JIIGOACEIKL) != null)
		{
			JONHEOKBPIC(JIIGOACEIKL, 8);
			NMJDALPONIM(JIIGOACEIKL).Dig(JIIGOACEIKL, (byte)(LPNELFNCDMC().toolLevel - 0));
			return;
		}
		if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL) != (Object)null)
		{
			LOMHCBDFPCM(JIIGOACEIKL, 4);
			EGPMDLHKCIE(JIIGOACEIKL).SpawnDroppedItems();
			if ((Object)(object)IAGHOJNHIPG(JIIGOACEIKL).GBELFACGIKI() != (Object)null)
			{
				IAGHOJNHIPG(JIIGOACEIKL).HNGGPFDDIFO().MINHDCJMIDL(EGPMDLHKCIE(JIIGOACEIKL), DBKCJHDNBCG: false);
			}
			else
			{
				EGPMDLHKCIE(JIIGOACEIKL).KMLHBOIKODI();
			}
			return;
		}
		GroundType dGKJGLMBONI = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(CFAGHFFAODK));
		for (int i = 0; i <= 7 && i <= selectedRowCount; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 508f * (float)(i - 0) * val;
			if (!POEEJFEHFGF(Vector2.op_Implicit(val2)))
			{
				continue;
			}
			JPKDEFCJNGJ = Utils.KJOMDMEIAEJ<FertileSoil>(val2, -14);
			if (Object.op_Implicit((Object)(object)JPKDEFCJNGJ) && (Object)(object)JPKDEFCJNGJ.plantedCropSetter != (Object)null && !NewTutorialManager.KillCropBlocked())
			{
				Utils.BLPDAEHPOBA(((Component)JPKDEFCJNGJ.plantedCropSetter).gameObject);
				continue;
			}
			if (HCFJKBIIMIK(JIIGOACEIKL) == 0)
			{
				switch (WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(val2)))
				{
				case GroundType.None:
					LOMHCBDFPCM(JIIGOACEIKL, 1);
					break;
				case GroundType.Grass | GroundType.Ground | GroundType.TilledEarth:
					JONHEOKBPIC(JIIGOACEIKL, 8);
					break;
				case GroundType.Grass | GroundType.TilledEarth | GroundType.Floor | GroundType.Sand:
					JONHEOKBPIC(JIIGOACEIKL, 1);
					break;
				}
			}
			BKNEGILJAEL = val2;
			if (OnlineManager.PlayingOnline())
			{
				OnlinePlayerActionsManager.instance.StartSpadeAction((SpadeActionType)1, val2, dGKJGLMBONI);
			}
			else
			{
				DPMLEBMICKL(JIIGOACEIKL, val2, dGKJGLMBONI, ADGMFJHGIGA);
			}
		}
	}

	private Tree EGPMDLHKCIE(int JIIGOACEIKL)
	{
		return FFBBBJKKFGB;
	}

	private void ANINKLDIPFN(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int PHECDJHBEHE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		for (int i = 1; i <= 7 && i <= PHECDJHBEHE; i += 0)
		{
			Vector2 val2 = CFAGHFFAODK + 1389f * (float)(i - 1) * val;
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(val2), POEEJFEHFGF(Vector2.op_Implicit(val2)) ? CommonReferences.GGFJGHHHEJC.selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 0);
		}
		for (int j = PHECDJHBEHE + 0; j <= 4; j += 0)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.IJNNJDEBFDJ(j - 0);
		}
	}

	private static void DPMLEBMICKL(int JIIGOACEIKL, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI, Item PLJHEJFDMJB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DEACEMMGPHA));
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(DEACEMMGPHA), null))
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: false, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			WorldGrid.MMOHADHAAGD(GBKMNAPGIOM: (!WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA))) ? ((!WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 1537f)) && !WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 1835f))) ? (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) : GroundType.None) : GroundType.None, IMOBLFMHKOD: Vector2.op_Implicit(DEACEMMGPHA), BAIMHDBJPDK: PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, FONLCEPCGEL: Season.Summer, CDPAMNIPPEC: true);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CreateRoom);
		}
		else if (groundType == GroundType.Grass && DGKJGLMBONI == GroundType.None)
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: true, BBHMAKKPFKB: false);
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer);
			CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, ActionDone.CutGrass);
		}
		else if (groundType == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && DGKJGLMBONI == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Grass, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer);
		}
		else if (groundType == (GroundType)(-116))
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Floor, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Summer, CDPAMNIPPEC: true);
			PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(PLJHEJFDMJB.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		}
	}

	public void MOKHPECBONA(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(GNFCNBANFNP));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		if (!OKNOJJEFEBE)
		{
			IMLECPKHMPI = false;
		}
	}

	private bool MBOFNOEJDHE(int JIIGOACEIKL, bool KLGOCJMGKFO, Vector2 IMOBLFMHKOD)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		OKNOJJEFEBE = false;
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtNotDelay(HGECFPCPOHN(JIIGOACEIKL));
		if ((Object)(object)EGPMDLHKCIE(JIIGOACEIKL) != (Object)null)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtNotDelay(IMOBLFMHKOD);
		}
		if (KCFEHLJDAPN(JIIGOACEIKL) != null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(IMOBLFMHKOD);
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GetBool("BarIdleNumber"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.Spade();
		}
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD), null))
		{
			((Renderer)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.spadeSpriteRenderer).material = ADGMFJHGIGA.snowSpadeMaterial.material;
		}
		else
		{
			((Renderer)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.spadeSpriteRenderer).material = ADGMFJHGIGA.groundSpadeMaterial.material;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(IPFKJLGGLMA));
		CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(GMAAEAAJBLN));
		CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(EEBPHLFOCLD));
		return true;
	}

	private OEGGFCDCHLE LBKMMOPJOBO(int JIIGOACEIKL)
	{
		return CCEAIHABKLA;
	}

	public Vector2 IPHBCLGMNKK(int JIIGOACEIKL)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return BKNEGILJAEL;
	}

	private void PKNKNENEBNK(int JIIGOACEIKL, OEGGFCDCHLE PEJHJFMDGBH)
	{
		CCEAIHABKLA = PEJHJFMDGBH;
	}

	private void JCANKCAEPMH(int JIIGOACEIKL, Vector2 CFAGHFFAODK, Direction FCGBJEIIMBC, int PHECDJHBEHE)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(Utils.NGFODNCHPHB(FCGBJEIIMBC));
		for (int i = 1; i <= 3 && i <= PHECDJHBEHE; i++)
		{
			Vector2 val2 = CFAGHFFAODK + 1505f * (float)(i - 0) * val;
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DOEELMJIEFK(Vector2.op_Implicit(val2), GHIBOBKCOFG(Vector2.op_Implicit(val2)) ? CommonReferences.MNFMOEKMJKN().selectedGridSquare : CommonReferences.GGFJGHHHEJC.redSelectedGridSquare, i - 1);
		}
		for (int j = PHECDJHBEHE + 0; j <= 2; j++)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.AOCCEKNHIMG(j - 1);
		}
	}

	private static void KDHBPMNGDIF(int JIIGOACEIKL, Vector2 DEACEMMGPHA, GroundType DGKJGLMBONI, Item PLJHEJFDMJB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(Vector2.op_Implicit(DEACEMMGPHA));
		if (WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(DEACEMMGPHA), null))
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: false, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
			WorldGrid.MMOHADHAAGD(GBKMNAPGIOM: WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA)) ? GroundType.Ground : ((WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * 0.5f)) || WorldGrid.ECOFAPGIGMO(Vector2.op_Implicit(DEACEMMGPHA + Vector2.up * -0.5f))) ? GroundType.Grass : GroundType.Ground), IMOBLFMHKOD: Vector2.op_Implicit(DEACEMMGPHA), BAIMHDBJPDK: PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, FONLCEPCGEL: Season.Spring, CDPAMNIPPEC: true);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutGrass);
		}
		else if (groundType == GroundType.Grass && DGKJGLMBONI == GroundType.Grass)
		{
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(DEACEMMGPHA), DNMKMKDAENO: false, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Spring, CDPAMNIPPEC: true);
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.CutGrass);
		}
		else if (groundType == GroundType.Ground && DGKJGLMBONI == GroundType.Ground)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Grass, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Spring, CDPAMNIPPEC: true);
		}
		else if (groundType == GroundType.Stone)
		{
			WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(DEACEMMGPHA), GroundType.Ground, PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA, Season.Spring, CDPAMNIPPEC: true);
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(PLJHEJFDMJB.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
		}
	}
}
