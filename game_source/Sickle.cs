using System;
using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Sickle")]
public class Sickle : Tool, IActionable
{
	public bool EHHCPOCLAJA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD() && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("[MinePuzzleManager] Setting destructible objects for current puzzle. Count: {0} Current Puzzle = null? {1}") && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).MDOKKKHKKKE() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 1549f)
		{
			if (KLGOCJMGKFO)
			{
				OIGCDGEMCNK(JIIGOACEIKL, 437f);
			}
			else
			{
				GPFCALFMEAM(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) + Time.deltaTime);
				if (FHMDFFIDFAI(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				CGGDMGHENEB(JIIGOACEIKL, NLLFCOOCKDF(JIIGOACEIKL) - holdTime);
			}
			JMLLOEKMKFA(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(PHCDOHOECKE));
			CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(BBLHGLKPBHE));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(LIKIPPCHENE));
			return true;
		}
		return false;
	}

	public void FAEBLMPHEAK(int JIIGOACEIKL)
	{
	}

	public bool HBMNFIPLFDK(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return true;
	}

	public void IDOGCFPCAEO(int JIIGOACEIKL)
	{
	}

	private void BPBPGOKFEGM(int JIIGOACEIKL)
	{
		HeldTools.GIHKIEGFJNM(JIIGOACEIKL).EOKNKLAKLMJ(DMBFKFLDDLH: false);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(BPBPGOKFEGM));
		PlayerInputs.CDMFLDNDCPD(JIIGOACEIKL, ControllersDatabaseAccessor.CMDFFIAPONO(ControllersDatabase.VibrationMaterial.Pick));
	}

	private void BFEAPNMJPFA(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 1 && OnlineManager.MasterOrOffline()) || (JIIGOACEIKL == 1 && OnlineManager.PlayingOnline()))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).ActivateCutCollider();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(BFEAPNMJPFA));
	}

	public bool HEKGALMDLIL(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return true;
	}

	public bool CCKFFGGDIMA(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return false;
	}

	public bool EHOOBFJPPOI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD() && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("SetAnimationControllerIndexesRPC") && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).HBIKILDEHFI() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 266f)
		{
			if (KLGOCJMGKFO)
			{
				CIPHHJHDOIA(JIIGOACEIKL, 131f);
			}
			else
			{
				MKMABNJFPAC(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) + Time.deltaTime);
				if (NLLFCOOCKDF(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				IJFEDIJNMDE(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) - holdTime);
			}
			KOGOMPONEDP(JIIGOACEIKL);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(BPBPGOKFEGM));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(BBLHGLKPBHE));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(PDJDOGALHJO));
			return true;
		}
		return false;
	}

	private void FHANDKJCIHK(int JIIGOACEIKL)
	{
		HeldTools.GetPlayer(JIIGOACEIKL).SetSickleActive(DMBFKFLDDLH: true);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(FHANDKJCIHK));
		PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(ControllersDatabase.VibrationMaterial.SickleSwing));
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold") && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 1f)
		{
			if (KLGOCJMGKFO)
			{
				EFGDCGFFKFF(JIIGOACEIKL, 0f);
			}
			else
			{
				EFGDCGFFKFF(JIIGOACEIKL, FHMDFFIDFAI(JIIGOACEIKL) + Time.deltaTime);
				if (FHMDFFIDFAI(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				EFGDCGFFKFF(JIIGOACEIKL, FHMDFFIDFAI(JIIGOACEIKL) - holdTime);
			}
			MDFJCMMOHJA(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(FHANDKJCIHK));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(BFEAPNMJPFA));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(LIKIPPCHENE));
			return true;
		}
		return false;
	}

	private void IFAOCGMNAAE(int JIIGOACEIKL)
	{
		if (NDAGFLIIIHK(JIIGOACEIKL))
		{
			HeldTools.GIAOPMIDGPL(JIIGOACEIKL).SetSickleActive(DMBFKFLDDLH: false);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(PDJDOGALHJO));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			ICKDIEEPHGL(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	public void LBMKLIDKHJD(int JIIGOACEIKL)
	{
	}

	private void PDJDOGALHJO(int JIIGOACEIKL)
	{
		if (HJBDLCNGCLN(JIIGOACEIKL))
		{
			HeldTools.IJMLNIHAOGK(JIIGOACEIKL).MILMCMOPKLB(DMBFKFLDDLH: true);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(LIKIPPCHENE));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			AEECFCJIMIJ(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void LIKIPPCHENE(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).SetSickleActive(DMBFKFLDDLH: false);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(LIKIPPCHENE));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	public bool NIDBEIMJJJH(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return true;
	}

	private void BBLHGLKPBHE(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 0 && OnlineManager.PGAGDFAEEFB()) || (JIIGOACEIKL == 1 && OnlineManager.PlayingOnline()))
		{
			HeldTools.JBFDEAGDJEL(JIIGOACEIKL).LGLMLCKOCKI();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(BBLHGLKPBHE));
	}

	private void PHCDOHOECKE(int JIIGOACEIKL)
	{
		HeldTools.FIHGMLABOBB(JIIGOACEIKL).MILMCMOPKLB(DMBFKFLDDLH: false);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(BPBPGOKFEGM));
		PlayerInputs.TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.GACPBAPMFML((ControllersDatabase.VibrationMaterial)6));
	}
}
