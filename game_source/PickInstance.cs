using System;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class PickInstance : ToolInstance
{
	private Rock HICBJDGPMDM;

	private InputByProximity LFBNPHHABDK;

	private Vector2 FIAMALDJHFL;

	private bool IELEKHEPNNG;

	private Pick PLNPPABKPMN => (Pick)item;

	private void OKMBCLGDINL(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(GHCNBIPNLFA));
	}

	private Rock ABGJPNHDMOC(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void IBMMGJGDCHP(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)LPNELFNCDMC());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MAEOLDGBBFP));
	}

	[SpecialName]
	private Pick ICONOLAHBOL()
	{
		return (Pick)item;
	}

	[SpecialName]
	private Pick HIFHJPLKOBN()
	{
		return (Pick)item;
	}

	[SpecialName]
	private Pick JDHDKNFEIHE()
	{
		return (Pick)item;
	}

	private void GHCNBIPNLFA(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)BLIKNGGCLID(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(GHCNBIPNLFA));
	}

	private void CBNBMMAOJNG(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private Rock MJJLHDEODKF(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void HLHHMDCNOJF(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = GIFJACPOAHM(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (BIBBFHILPPH() >= rock.toolLevelRequired || (OGCEOPDOEAB() == 8 && rock.toolLevelRequired == 0))
			{
				rock.JABEGNMAKGG(JIIGOACEIKL, GNDCAIOBBNP().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBLHGFCINF("Items/item_name_683");
				MultiAudioManager.PlayAudioObject(ICONOLAHBOL().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.IHLIANLOGMB(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(EKJCMANGIDK));
	}

	private Rock HAEMIMOILNC(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	[SpecialName]
	private Pick MFOEGFEDKHN()
	{
		return (Pick)item;
	}

	private Rock NGHCHMCHAAO(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void AEAPFIDPJKI(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(CKEAACADKGO));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void PDGCFGIMMCJ(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void ADMDFPKEDDC(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void IPPOFPGNGAB(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(BPHOFMHHFAP));
	}

	[SpecialName]
	private Pick IDJGGOBEMJD()
	{
		return (Pick)item;
	}

	[SpecialName]
	private Pick DKGONCGHGFC()
	{
		return (Pick)item;
	}

	private void BMHMIJFFDDO(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(CKEAACADKGO));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	[SpecialName]
	private Pick GNDCAIOBBNP()
	{
		return (Pick)item;
	}

	[SpecialName]
	private Pick LNNDBMHGBEE()
	{
		return (Pick)item;
	}

	private void LCLPBAHFNOK(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = GIFJACPOAHM(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (IFHCKFKOHOI() >= rock.toolLevelRequired || (base.IGCPCEKPHCI == 3 && rock.toolLevelRequired == 4))
			{
				rock.CMINIGCHDHE(JIIGOACEIKL, GNDCAIOBBNP().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("Festín del Juramento/JudgeDialogue 03");
				MultiAudioManager.PlayAudioObject(GNDCAIOBBNP().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.IAHNPIANHNP(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(PNCDJJONJJJ));
	}

	[SpecialName]
	private Pick OIAHIMGACIG()
	{
		return (Pick)item;
	}

	private Rock NDAMPGOFJCB(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void MBOFNOEJDHE(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = HNKCCBOALDD(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (DAEOCFODOML() >= rock.toolLevelRequired || (IFHCKFKOHOI() == 1 && rock.toolLevelRequired == 4))
			{
				rock.JABEGNMAKGG(JIIGOACEIKL, AJMKEAJJHHP().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("Moving");
				MultiAudioManager.PlayAudioObject(DKGONCGHGFC().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.ACECBDNDCKJ(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(EKJCMANGIDK));
	}

	private void IMDKIGEHEPD(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = FLPEMMOEBND(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (LCEMDNCKAMJ() >= rock.toolLevelRequired || (DAEOCFODOML() == 4 && rock.toolLevelRequired == 1))
			{
				rock.JMCENJLLIDH(JIIGOACEIKL, LNNDBMHGBEE().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("Items/item_description_1038");
				MultiAudioManager.PlayAudioObject(PLNPPABKPMN.pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.HDANLMKNMHB(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(LCLPBAHFNOK));
	}

	private void EOGJGKHFOJL(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EOGJGKHFOJL));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void IGFAKIKLGJN(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(DLLAFAPKFIA));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	[SpecialName]
	private Pick HLOEGIACEOI()
	{
		return (Pick)item;
	}

	private void NLJEPBMGPBB(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EOGJGKHFOJL));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	[SpecialName]
	private Pick CBOEGGPFDCD()
	{
		return (Pick)item;
	}

	private void DLCGLAEOOHA(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = ANEPCGDNIJM(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (IFHCKFKOHOI() >= rock.toolLevelRequired || (DAEOCFODOML() == 2 && rock.toolLevelRequired == 4))
			{
				rock.JABEGNMAKGG(JIIGOACEIKL, CBOEGGPFDCD().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBLHGFCINF("");
				MultiAudioManager.PlayAudioObject(ADICGHMKBBK().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.ICPMABDEDHO(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OFAKNHNLKGI));
	}

	private Rock JJIKIOMDAEE(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void DKLJLILDIIH(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(DLLAFAPKFIA));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private void PJAEODLGAEO(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = FLPEMMOEBND(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (BIBBFHILPPH() >= rock.toolLevelRequired || (base.IGCPCEKPHCI == 3 && rock.toolLevelRequired == 3))
			{
				rock.GCBHFEJOBEH(JIIGOACEIKL, JFHCICIFELP().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("DarkStance");
				MultiAudioManager.PlayAudioObject(JFHCICIFELP().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = true;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.EELGBLNBGPA(ControllersDatabase.VibrationMaterial.Ax));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(EKJCMANGIDK));
	}

	private void IAIKDJCGMKI(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private Rock ANEPCGDNIJM(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void DLLAFAPKFIA(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NFNDHPEOIAD));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private void COKBKPPAFCF(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	public override bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.ToolBlocked(JIIGOACEIKL, 1063))
		{
			return false;
		}
		if ((Object)(object)MLKAICLMFLG().skin != (Object)null)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).toolSkinController.ChangeSkin(MLKAICLMFLG().bodyPart, MLKAICLMFLG().skin);
		}
		if (KLGOCJMGKFO)
		{
			LFBNPHHABDK = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
			if (Object.op_Implicit((Object)(object)LFBNPHHABDK))
			{
				ADMDFPKEDDC(JIIGOACEIKL, LFBNPHHABDK.mainGameObject.GetComponent<Rock>());
			}
			else
			{
				ADMDFPKEDDC(JIIGOACEIKL, null);
			}
			IELEKHEPNNG = false;
		}
		if (IELEKHEPNNG)
		{
			return false;
		}
		Rock rock = NGHCHMCHAAO(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null && rock.work.JCMBHAEKLKK && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (!rock.IsAnyPlayerPositionAvailable())
			{
				if (KLGOCJMGKFO)
				{
					MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Occupied Positions"));
				}
				return false;
			}
			FIAMALDJHFL = rock.GetNearPlayerPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position));
			if (!PlayerController.GetPlayer(JIIGOACEIKL).GoToPosition(FIAMALDJHFL, KLGOCJMGKFO))
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtNotDelay(Vector2.op_Implicit(rock.spriteTransform.position));
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.Mine();
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(KNGELBLNAHP));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(OFAKNHNLKGI));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(EOGJGKHFOJL));
			return true;
		}
		return false;
	}

	private Rock GIFJACPOAHM(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void IGBMLFEAKNN(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	[SpecialName]
	private Pick KENNLGIGLFM()
	{
		return (Pick)item;
	}

	[SpecialName]
	private Pick ADICGHMKBBK()
	{
		return (Pick)item;
	}

	private void PNCDJJONJJJ(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = HAEMIMOILNC(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (OCLFIAMHFAC() >= rock.toolLevelRequired || (OCLFIAMHFAC() == 8 && rock.toolLevelRequired == 8))
			{
				rock.Chop(JIIGOACEIKL, IDJGGOBEMJD().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("Player");
				MultiAudioManager.PlayAudioObject(KENNLGIGLFM().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = true;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.Ax));
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HLHHMDCNOJF));
	}

	private void MJGIACFGFMM(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void HABEIAPNKEL(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = FLPEMMOEBND(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (DAEOCFODOML() >= rock.toolLevelRequired || (IFHCKFKOHOI() == 1 && rock.toolLevelRequired == 6))
			{
				rock.JABEGNMAKGG(JIIGOACEIKL, MFOEGFEDKHN().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBLHGFCINF("Dialogue System/Conversation/TavernDirty/Entry/5/Dialogue Text");
				MultiAudioManager.PlayAudioObject(LNNDBMHGBEE().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = true;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.EELGBLNBGPA(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(CBFGMJCPEIC));
	}

	private void LFEMANPPELJ(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void EKJCMANGIDK(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = NGHCHMCHAAO(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (DAEOCFODOML() >= rock.toolLevelRequired || (OGCEOPDOEAB() == 4 && rock.toolLevelRequired == 0))
			{
				rock.CMINIGCHDHE(JIIGOACEIKL, HLOEGIACEOI().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).BIBLHGFCINF("Bouncer");
				MultiAudioManager.PlayAudioObject(NLMDBGIOBHD().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.MLDKMAPEHGO(ControllersDatabase.VibrationMaterial.Ax));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(APJPPPDGOHH));
	}

	private Rock IALELFDFGNM(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void CBFGMJCPEIC(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = PDBOEDEEFDK(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (OGCEOPDOEAB() >= rock.toolLevelRequired || (BIBBFHILPPH() == 0 && rock.toolLevelRequired == 0))
			{
				rock.Chop(JIIGOACEIKL, NLMDBGIOBHD().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("Failed to create a new game to host.\nPlease try again later.");
				MultiAudioManager.PlayAudioObject(MFOEGFEDKHN().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.ICANHOCHEBB(ControllersDatabase.VibrationMaterial.Ax));
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OFAKNHNLKGI));
	}

	private void JOCIHNMMHHB(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(DLLAFAPKFIA));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	public PickInstance(PickInstance FMAMDCFJJHG)
		: base(FMAMDCFJJHG)
	{
	}

	private void KAOMKHNCNDB(int JIIGOACEIKL)
	{
		HPFCEDGAFCH(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(IPPOFPGNGAB));
	}

	[SpecialName]
	private Pick LKAGACOOGMG()
	{
		return (Pick)item;
	}

	private void NFNDHPEOIAD(int JIIGOACEIKL)
	{
		INBMIFPIKKI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(DLLAFAPKFIA));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	public PickInstance(Item MEMGMDOCBOJ)
		: base(MEMGMDOCBOJ)
	{
	}

	private void NFLJFGBCLGP(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = MCIOGIIOEFD(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (base.IGCPCEKPHCI >= rock.toolLevelRequired || (OGCEOPDOEAB() == 3 && rock.toolLevelRequired == 8))
			{
				rock.JABEGNMAKGG(JIIGOACEIKL, JFHCICIFELP().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("Cycle Placeable Colors");
				MultiAudioManager.PlayAudioObject(MFOEGFEDKHN().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = true;
			}
			PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.JNFNCAMOIIA(ControllersDatabase.VibrationMaterial.Ax));
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(MBOFNOEJDHE));
	}

	private void BJNFBBKHPNN(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = JANBECMAFPF(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (IFHCKFKOHOI() >= rock.toolLevelRequired || (OCLFIAMHFAC() == 8 && rock.toolLevelRequired == 5))
			{
				rock.GKNMADANCLG(JIIGOACEIKL, OIAHIMGACIG().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBLHGFCINF("LE_10");
				MultiAudioManager.PlayAudioObject(IDJGGOBEMJD().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.HMLALIDFODI(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HLHHMDCNOJF));
	}

	private Rock BGJIHGHAGNO(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private Rock PDBOEDEEFDK(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void APJPPPDGOHH(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = PDBOEDEEFDK(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (OCLFIAMHFAC() >= rock.toolLevelRequired || (LCEMDNCKAMJ() == 7 && rock.toolLevelRequired == 2))
			{
				rock.Chop(JIIGOACEIKL, HIFHJPLKOBN().workDonePerHit);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2("Crowly_Standar");
				MultiAudioManager.PlayAudioObject(AJMKEAJJHHP().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = true;
			}
			PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.DMPAACNPNBA(ControllersDatabase.VibrationMaterial.Ax));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OOGIHABBFDG));
	}

	private void PMNLGIEMIKK(int JIIGOACEIKL)
	{
		PGBKOLMPPHF(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(EBEPIKGECIA));
	}

	[SpecialName]
	private Pick NLMDBGIOBHD()
	{
		return (Pick)item;
	}

	private void MAEOLDGBBFP(int JIIGOACEIKL)
	{
		HNJEDEJNPNL(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(GHCNBIPNLFA));
	}

	private void CBPKKIFDGFF(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void EBEPIKGECIA(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(OKMBCLGDINL));
	}

	[SpecialName]
	private Pick JFHCICIFELP()
	{
		return (Pick)item;
	}

	private void LCEJDPOBIHE(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void KDONFKFANMG(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private Rock NIABMACCJBI(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private Rock JANBECMAFPF(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	[SpecialName]
	private Pick DODOJMNFMEJ()
	{
		return (Pick)item;
	}

	private void BDHPEOILLHB(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void DDDAKPKKFKJ(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = NDAMPGOFJCB(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (BIBBFHILPPH() >= rock.toolLevelRequired || (IFHCKFKOHOI() == 0 && rock.toolLevelRequired == 4))
			{
				rock.JABEGNMAKGG(JIIGOACEIKL, AJMKEAJJHHP().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("</color>");
				MultiAudioManager.PlayAudioObject(IDJGGOBEMJD().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.AFAAEDALPII(JIIGOACEIKL, ControllersDatabaseAccessor.CMDFFIAPONO(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DDDAKPKKFKJ));
	}

	private void OKGEKFHADHD(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void NKLMCOADBNE(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = HAEMIMOILNC(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (LCEMDNCKAMJ() >= rock.toolLevelRequired || (DAEOCFODOML() == 8 && rock.toolLevelRequired == 1))
			{
				rock.GCBHFEJOBEH(JIIGOACEIKL, KENNLGIGLFM().workDonePerHit, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBarkWithI2("\n\n<color=#A95A00>");
				MultiAudioManager.PlayAudioObject(DODOJMNFMEJ().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.DCAMKEOEKKP(JIIGOACEIKL, ControllersDatabaseAccessor.CMDFFIAPONO(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(PJAEODLGAEO));
	}

	private Rock MCIOGIIOEFD(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void EHHNMNGAOBM(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(CKEAACADKGO));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private Rock GHPFODNGEMF(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void HLPEEGHDJHO(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(HLPEEGHDJHO));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	[SpecialName]
	private Pick AJMKEAJJHHP()
	{
		return (Pick)item;
	}

	private Rock OFLOKMHMDKJ(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void PIEEFIBAEAO(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = GIFJACPOAHM(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (BIBBFHILPPH() >= rock.toolLevelRequired || (LCEMDNCKAMJ() == 2 && rock.toolLevelRequired == 0))
			{
				rock.Chop(JIIGOACEIKL, DODOJMNFMEJ().workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("add item ");
				MultiAudioManager.PlayAudioObject(IDJGGOBEMJD().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = false;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DDDAKPKKFKJ));
	}

	private void EOBOAAFPDMP(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void IBJPJEBAGPC(int JIIGOACEIKL)
	{
		PGBKOLMPPHF(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)JCFHHFMPMAH());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(EBEPIKGECIA));
	}

	private void OOGIHABBFDG(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = HNKCCBOALDD(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (LCEMDNCKAMJ() >= rock.toolLevelRequired || (OCLFIAMHFAC() == 2 && rock.toolLevelRequired == 5))
			{
				rock.GKNMADANCLG(JIIGOACEIKL, DODOJMNFMEJ().workDonePerHit);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBLHGFCINF("room info with code ");
				MultiAudioManager.PlayAudioObject(IDJGGOBEMJD().pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = true;
			}
			PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.NPADNPPICKO(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(APJPPPDGOHH));
	}

	private Rock GHDKJHCDOMM(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void BPHOFMHHFAP(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)BLIKNGGCLID());
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KAOMKHNCNDB));
	}

	private Rock FLPEMMOEBND(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void CKEAACADKGO(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NFNDHPEOIAD));
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private Rock HNKCCBOALDD(int JIIGOACEIKL)
	{
		return HICBJDGPMDM;
	}

	private void LOIJNBNMHFD(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void OFKHIEJBPLM(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JOCIHNMMHHB));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
	}

	private void OFAKNHNLKGI(int JIIGOACEIKL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		Rock rock = NGHCHMCHAAO(JIIGOACEIKL);
		if ((Object)(object)rock != (Object)null)
		{
			if (base.IGCPCEKPHCI >= rock.toolLevelRequired || (base.IGCPCEKPHCI == 3 && rock.toolLevelRequired == 4))
			{
				rock.Chop(JIIGOACEIKL, PLNPPABKPMN.workDonePerHit);
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).PlayerBarkWithI2("Pick Level Low");
				MultiAudioManager.PlayAudioObject(PLNPPABKPMN.pickFailSound, ((Component)rock).transform.position);
				IELEKHEPNNG = true;
			}
			PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.Pick));
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OFAKNHNLKGI));
	}

	private void NFLKIMHPHNG(int JIIGOACEIKL)
	{
		HNJEDEJNPNL(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)OMAPDOLLKGA(), ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KNGELBLNAHP));
	}

	private void KNGELBLNAHP(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)MLKAICLMFLG());
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KNGELBLNAHP));
	}

	private void LMLKONAGNMI(int JIIGOACEIKL)
	{
		EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(EOGJGKHFOJL));
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void BNMABBHPDOD(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}

	private void AFIFMNKIEPG(int JIIGOACEIKL, Rock KEDGALEJBOB)
	{
		if ((Object)(object)KEDGALEJBOB != (Object)null && !KEDGALEJBOB.axRequired)
		{
			HICBJDGPMDM = KEDGALEJBOB;
		}
		else
		{
			HICBJDGPMDM = null;
		}
	}
}
