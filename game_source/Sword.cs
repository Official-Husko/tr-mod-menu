using System;
using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Sword")]
public class Sword : Tool, IActionable
{
	private float currentShield;

	private float currentShield2;

	public void LBMKLIDKHJD(int JIIGOACEIKL)
	{
	}

	public override void SecondActionEnd(int JIIGOACEIKL)
	{
		Debug.Log((object)"SecondActionEnd");
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetBool("Shield", EGFGNGJGBOP: false);
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
	}

	private void EGNMOGBABGE(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentShield = LGLDPMAABLA;
		}
		else
		{
			currentShield2 = LGLDPMAABLA;
		}
	}

	private void NPALBNDFOIA(int JIIGOACEIKL)
	{
		HeldTools.OGKNJNINGMH(JIIGOACEIKL).KGPLMANNGCE(DMBFKFLDDLH: true);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(NPALBNDFOIA));
	}

	public void CDGBECJBMIE(int JIIGOACEIKL)
	{
	}

	public void ODCBOFHIPKF(int JIIGOACEIKL)
	{
	}

	private void HPCFAEFABPA(int JIIGOACEIKL)
	{
		if (GHLPLIDJGKP(JIIGOACEIKL))
		{
			HeldTools.EJKCBAKCBEO(JIIGOACEIKL).PLJNCILBFKF(DMBFKFLDDLH: false);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(BJMENBGHFNK));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			KEAELNMELLO(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	public bool OHINFBCDKLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GetBool("UINextCategory") && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 16f)
		{
			if (KLGOCJMGKFO)
			{
				MPECPKPFKFB(JIIGOACEIKL, 1017f);
			}
			else
			{
				OIGCDGEMCNK(JIIGOACEIKL, FHMDFFIDFAI(JIIGOACEIKL) + Time.deltaTime);
				if (MMLOLBMOAFB(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				OJIBPBKGGNK(JIIGOACEIKL, PBIEIJOICJL(JIIGOACEIKL) - holdTime);
			}
			KIHCIFEJADL(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(NKECNIHCCCI));
			CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(JOGEJFMEOAH));
			CharacterAnimator characterAnimator3 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(OKLJJMPIGFM));
			return true;
		}
		return false;
	}

	public bool OEFLFKLLJHF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("ActionBar5") && (Object)(object)InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM() && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 550f)
		{
			if (KLGOCJMGKFO)
			{
				GJNOFPDHCMA(JIIGOACEIKL, 574f);
			}
			else
			{
				MPECPKPFKFB(JIIGOACEIKL, FHMDFFIDFAI(JIIGOACEIKL) + Time.deltaTime);
				if (FHMDFFIDFAI(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				CGGDMGHENEB(JIIGOACEIKL, GNKMPAPJLCM(JIIGOACEIKL) - holdTime);
			}
			GPHLEINIMDB(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(AIKKGKGMCCP));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(FIHBMGGJDGM));
			CharacterAnimator characterAnimator3 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(ODDEPBIAPCL));
			return false;
		}
		return false;
	}

	private void CNFJEGDEAJO(int JIIGOACEIKL)
	{
		if (EJOLHENJGIM(JIIGOACEIKL))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).SetSwordActive(DMBFKFLDDLH: true);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JMNOHEMOJMM));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		}
		else
		{
			IHKALDEHDCH(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void GNDJAEOAFNB(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentShield = LGLDPMAABLA;
		}
		else
		{
			currentShield2 = LGLDPMAABLA;
		}
	}

	private void OKLJJMPIGFM(int JIIGOACEIKL)
	{
		if (HJBDLCNGCLN(JIIGOACEIKL))
		{
			HeldTools.DACNEICGAAE(JIIGOACEIKL).NOJOIODMAGN(DMBFKFLDDLH: true);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(OKLJJMPIGFM));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		}
		else
		{
			AEECFCJIMIJ(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	public bool ECKGJAHMFAL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("MainProgress") && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 711f)
		{
			if (KLGOCJMGKFO)
			{
				CGGDMGHENEB(JIIGOACEIKL, 984f);
			}
			else
			{
				OJIBPBKGGNK(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) + Time.deltaTime);
				if (LEHHFMELACA(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				MPECPKPFKFB(JIIGOACEIKL, PBIEIJOICJL(JIIGOACEIKL) - holdTime);
			}
			BLODLBPHFDJ(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(NGPFAPDONLF));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(DEIMNIAMMAL));
			CharacterAnimator characterAnimator3 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(LNAIMKNADDF));
			return false;
		}
		return true;
	}

	public bool IOKEOGEPNHB(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return true;
	}

	private void JMNOHEMOJMM(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).SetSwordActive(DMBFKFLDDLH: false);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JMNOHEMOJMM));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	public void KGDNPEPNCKD(int JIIGOACEIKL)
	{
	}

	private void FOFBNLHGIMF(int JIIGOACEIKL)
	{
		if (GHLPLIDJGKP(JIIGOACEIKL))
		{
			HeldTools.MFJNNCFFDEH(JIIGOACEIKL).PMADAOCEHGD(DMBFKFLDDLH: false);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(GFDIEJJFLJA));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			KEAELNMELLO(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	public bool AFDFEDHLEHF(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return false;
	}

	private void IOHCCOBNHIF(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentShield = LGLDPMAABLA;
		}
		else
		{
			currentShield2 = LGLDPMAABLA;
		}
	}

	public bool MAMOMPOHECM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB(" (versionOfCropsAndRecipes)") && (Object)(object)InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IDPGEBNGDJD() && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 330f)
		{
			if (KLGOCJMGKFO)
			{
				GPFCALFMEAM(JIIGOACEIKL, 1253f);
			}
			else
			{
				OIGCDGEMCNK(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) + Time.deltaTime);
				if (MMLOLBMOAFB(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				OIGCDGEMCNK(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) - holdTime);
			}
			JMLLOEKMKFA(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(AMCCCEBJLEA));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(DEIMNIAMMAL));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(BJMENBGHFNK));
			return true;
		}
		return true;
	}

	private float PPMHGICGALI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return currentShield2;
		}
		return currentShield;
	}

	public bool JBDNBDGKOON(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return false;
	}

	public void HLIHKHIDIJC(int JIIGOACEIKL)
	{
	}

	private void MBMCKKJLGGM(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 0)
		{
			currentShield = LGLDPMAABLA;
		}
		else
		{
			currentShield2 = LGLDPMAABLA;
		}
	}

	public bool JEJCKDOFMGO(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return false;
	}

	private void EEFHLOOBAGL(int JIIGOACEIKL)
	{
		HeldTools.JHEHMLIPPAA(JIIGOACEIKL).NAAILELIDMJ(DMBFKFLDDLH: true);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(OFINOMABIIE));
	}

	public void HGLAFBPDMAL(int JIIGOACEIKL)
	{
	}

	public bool IGPBCEMHDPN(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return false;
	}

	public bool BKGIMGHGBMO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("RentingRooms") && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE() && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 10f)
		{
			if (KLGOCJMGKFO)
			{
				CBMIMDHIFDD(JIIGOACEIKL, 833f);
			}
			else
			{
				GNDJAEOAFNB(JIIGOACEIKL, GICDOEMGFCF(JIIGOACEIKL) + Time.deltaTime);
				if (HJDODLCKAFE(JIIGOACEIKL) < holdTime)
				{
					return true;
				}
				IOHCCOBNHIF(JIIGOACEIKL, EHFPPGGCNKE(JIIGOACEIKL) - holdTime);
			}
			Debug.Log((object)"next pos ");
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetInt("UseHold", PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.animator.GetInteger("SalonDelTrono/KlaynTalk"), HALNIEBONKH: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetTrigger("ReceiveCompleteServeNinjaCustomer", HALNIEBONKH: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.CGEADHOLHCH("RoadBlocked", EGFGNGJGBOP: true, HALNIEBONKH: true);
			return true;
		}
		return false;
	}

	private void AIKKGKGMCCP(int JIIGOACEIKL)
	{
		HeldTools.EIFPKCAFDIB(JIIGOACEIKL).PLJNCILBFKF(DMBFKFLDDLH: true);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(EEFHLOOBAGL));
	}

	public void PNJNNPIMPPB(int JIIGOACEIKL)
	{
	}

	private void OIDOKIDICME(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 1 && OnlineManager.MasterOrOffline()) || (JIIGOACEIKL == 1 && OnlineManager.PlayingOnline()))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).ActivateCutCollider();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OIDOKIDICME));
	}

	public bool IJHFHABALCP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("SprintHoldAction") && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).HBIKILDEHFI() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM() && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 1903f)
		{
			if (KLGOCJMGKFO)
			{
				MKMABNJFPAC(JIIGOACEIKL, 556f);
			}
			else
			{
				CGGDMGHENEB(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) + Time.deltaTime);
				if (NLLFCOOCKDF(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				GJNOFPDHCMA(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) - holdTime);
			}
			JMLLOEKMKFA(JIIGOACEIKL);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(NKECNIHCCCI));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(FIHBMGGJDGM));
			CharacterAnimator characterAnimator3 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(BJMENBGHFNK));
			return true;
		}
		return true;
	}

	private void HPLGFIHKOKG(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 1)
		{
			currentShield = LGLDPMAABLA;
		}
		else
		{
			currentShield2 = LGLDPMAABLA;
		}
	}

	public bool AKJGMAEGLKN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("ReceiveEnable") && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM() && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 593f)
		{
			if (KLGOCJMGKFO)
			{
				EGNMOGBABGE(JIIGOACEIKL, 1022f);
			}
			else
			{
				CBMIMDHIFDD(JIIGOACEIKL, HJDODLCKAFE(JIIGOACEIKL) + Time.deltaTime);
				if (MDAEKAFJLBJ(JIIGOACEIKL) < holdTime)
				{
					return true;
				}
				HPLGFIHKOKG(JIIGOACEIKL, BNHCEIJPELK(JIIGOACEIKL) - holdTime);
			}
			Debug.Log((object)"ChatWelcomeToTavern_F");
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetInt("Items/item_name_1093", PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.animator.GetInteger("Pause"), HALNIEBONKH: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetTrigger("Dots");
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.CGEADHOLHCH("Dialogue System/Conversation/TooHot/Entry/1/Dialogue Text", EGFGNGJGBOP: true, HALNIEBONKH: true);
			return false;
		}
		return false;
	}

	private float MDAEKAFJLBJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return currentShield2;
		}
		return currentShield;
	}

	private void NGPFAPDONLF(int JIIGOACEIKL)
	{
		HeldTools.GetPlayer(JIIGOACEIKL).SetSwordActive(DMBFKFLDDLH: true);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(NGPFAPDONLF));
	}

	private void CBMIMDHIFDD(int JIIGOACEIKL, float LGLDPMAABLA)
	{
		if (JIIGOACEIKL == 0)
		{
			currentShield = LGLDPMAABLA;
		}
		else
		{
			currentShield2 = LGLDPMAABLA;
		}
	}

	private float HJDODLCKAFE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return currentShield2;
		}
		return currentShield;
	}

	public bool AIOCJAIIMMG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GetBool("Unique id ") && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE() && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 721f)
		{
			if (KLGOCJMGKFO)
			{
				CGGDMGHENEB(JIIGOACEIKL, 1335f);
			}
			else
			{
				MKMABNJFPAC(JIIGOACEIKL, NLLFCOOCKDF(JIIGOACEIKL) + Time.deltaTime);
				if (PBIEIJOICJL(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				CIPHHJHDOIA(JIIGOACEIKL, LJJKANNAHCM(JIIGOACEIKL) - holdTime);
			}
			JOLOOFLEAON(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(EEFHLOOBAGL));
			CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(JOGEJFMEOAH));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(FOFBNLHGIMF));
			return false;
		}
		return true;
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
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(NGPFAPDONLF));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(OIDOKIDICME));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(JMNOHEMOJMM));
			return true;
		}
		return false;
	}

	public new bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold") && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 1f)
		{
			if (KLGOCJMGKFO)
			{
				EGNMOGBABGE(JIIGOACEIKL, 0f);
			}
			else
			{
				EGNMOGBABGE(JIIGOACEIKL, PPMHGICGALI(JIIGOACEIKL) + Time.deltaTime);
				if (PPMHGICGALI(JIIGOACEIKL) < holdTime)
				{
					return false;
				}
				EGNMOGBABGE(JIIGOACEIKL, PPMHGICGALI(JIIGOACEIKL) - holdTime);
			}
			Debug.Log((object)"SecondAction");
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetInt("AimDirection", PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.animator.GetInteger("Direction"));
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetTrigger("ShieldTrigger");
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetBool("Shield", EGFGNGJGBOP: true);
			return true;
		}
		return false;
	}

	private void HKBOOHPLNKP(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 1 && OnlineManager.MasterOrOffline()) || (JIIGOACEIKL == 0 && OnlineManager.PlayingOnline()))
		{
			HeldTools.JHEHMLIPPAA(JIIGOACEIKL).MAPLDFDBHCM();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OIDOKIDICME));
	}

	private float GICDOEMGFCF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return currentShield2;
		}
		return currentShield;
	}

	public bool AJGAJLJIPGI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("OpenConsole") && (Object)(object)InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).HBIKILDEHFI() == (Object)null && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 181f)
		{
			if (KLGOCJMGKFO)
			{
				CBMIMDHIFDD(JIIGOACEIKL, 694f);
			}
			else
			{
				EGNMOGBABGE(JIIGOACEIKL, MDAEKAFJLBJ(JIIGOACEIKL) + Time.deltaTime);
				if (BNHCEIJPELK(JIIGOACEIKL) < holdTime)
				{
					return true;
				}
				IOHCCOBNHIF(JIIGOACEIKL, PPMHGICGALI(JIIGOACEIKL) - holdTime);
			}
			Debug.Log((object)"Error_RoomDoorIsBlocking");
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetInt("Interact", PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.animator.GetInteger("Inventory full"));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.SetTrigger("CheckArea");
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.animation.CGEADHOLHCH("MainProgress", EGFGNGJGBOP: true, HALNIEBONKH: true);
			return false;
		}
		return true;
	}

	private void GJAMAOJIJPE(int JIIGOACEIKL)
	{
		HeldTools.JBFDEAGDJEL(JIIGOACEIKL).KGPLMANNGCE(DMBFKFLDDLH: false);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(AMCCCEBJLEA));
	}

	public void FDPHAKLEDEB(int JIIGOACEIKL)
	{
	}

	private float EHFPPGGCNKE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 0)
		{
			return currentShield2;
		}
		return currentShield;
	}

	public void OBHFIFPKIGG(int JIIGOACEIKL)
	{
	}

	public bool KAJFPDHENOC(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return false;
	}

	public bool HEKGALMDLIL(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return true;
	}

	private void AMCCCEBJLEA(int JIIGOACEIKL)
	{
		HeldTools.DACNEICGAAE(JIIGOACEIKL).MCDFGFJBCFP(DMBFKFLDDLH: false);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(AIKKGKGMCCP));
	}

	private void OFINOMABIIE(int JIIGOACEIKL)
	{
		HeldTools.EIFPKCAFDIB(JIIGOACEIKL).LPJCHBNJJEE(DMBFKFLDDLH: false);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(NGPFAPDONLF));
	}

	private void ODDEPBIAPCL(int JIIGOACEIKL)
	{
		if (NDAGFLIIIHK(JIIGOACEIKL))
		{
			HeldTools.JBFDEAGDJEL(JIIGOACEIKL).SetSwordActive(DMBFKFLDDLH: true);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(LNAIMKNADDF));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			AEECFCJIMIJ(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private void BJMENBGHFNK(int JIIGOACEIKL)
	{
		if (EJOLHENJGIM(JIIGOACEIKL))
		{
			HeldTools.FIHGMLABOBB(JIIGOACEIKL).PLJNCILBFKF(DMBFKFLDDLH: true);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(CNFJEGDEAJO));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		}
		else
		{
			BBGOGACOIMM(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void GFDIEJJFLJA(int JIIGOACEIKL)
	{
		if (GHLPLIDJGKP(JIIGOACEIKL))
		{
			HeldTools.DACNEICGAAE(JIIGOACEIKL).PJPDABKJANH(DMBFKFLDDLH: false);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(ODDEPBIAPCL));
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
		else
		{
			NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private float BNHCEIJPELK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL != 1)
		{
			return currentShield2;
		}
		return currentShield;
	}

	private void NKPJNPDDHFN(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 0 && OnlineManager.PGAGDFAEEFB()) || (JIIGOACEIKL == 1 && OnlineManager.PlayingOnline()))
		{
			HeldTools.FLOIJFPDJGG(JIIGOACEIKL).LGLMLCKOCKI();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OALBJCPGCHK));
	}

	public void DKMBNHLMLBJ(int JIIGOACEIKL)
	{
	}

	private void HJDMBKKHKFC(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 0 && OnlineManager.PGAGDFAEEFB()) || (JIIGOACEIKL == 0 && OnlineManager.PlayingOnline()))
		{
			HeldTools.OGKNJNINGMH(JIIGOACEIKL).BMIBAADJOGA();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HJDMBKKHKFC));
	}

	private void LNAIMKNADDF(int JIIGOACEIKL)
	{
		if (NDAGFLIIIHK(JIIGOACEIKL))
		{
			HeldTools.IJMLNIHAOGK(JIIGOACEIKL).MCDFGFJBCFP(DMBFKFLDDLH: false);
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(HPCFAEFABPA));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		}
		else
		{
			ICKDIEEPHGL(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private void DEIMNIAMMAL(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 1 && OnlineManager.PGAGDFAEEFB()) || (JIIGOACEIKL == 1 && OnlineManager.PlayingOnline()))
		{
			HeldTools.DACNEICGAAE(JIIGOACEIKL).NIFDOHJIDIB();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(FIHBMGGJDGM));
	}

	private void NKECNIHCCCI(int JIIGOACEIKL)
	{
		HeldTools.FIHGMLABOBB(JIIGOACEIKL).MGEFKGLFDFO(DMBFKFLDDLH: false);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(OFINOMABIIE));
	}

	public bool KAEPNLFDIPH(int JIIGOACEIKL, ToolInstance ACFLBADEHDN)
	{
		return false;
	}

	public void KCDOKIIPBGC(int JIIGOACEIKL)
	{
	}

	private void JOGEJFMEOAH(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 1 && OnlineManager.MasterOrOffline()) || (JIIGOACEIKL == 1 && OnlineManager.PlayingOnline()))
		{
			HeldTools.NPANPNIDKDG(JIIGOACEIKL).NIFDOHJIDIB();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OIDOKIDICME));
	}

	private void OALBJCPGCHK(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 1 && OnlineManager.MasterOrOffline()) || (JIIGOACEIKL == 0 && OnlineManager.PlayingOnline()))
		{
			HeldTools.EJKCBAKCBEO(JIIGOACEIKL).IJDFIPHNKNH();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(FIHBMGGJDGM));
	}

	public bool IKPNNKPDGPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GetBool("Profit") && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).HBIKILDEHFI() == (Object)null && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI() && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 1390f)
		{
			if (KLGOCJMGKFO)
			{
				CGGDMGHENEB(JIIGOACEIKL, 49f);
			}
			else
			{
				GPFCALFMEAM(JIIGOACEIKL, LJJKANNAHCM(JIIGOACEIKL) + Time.deltaTime);
				if (FHMDFFIDFAI(JIIGOACEIKL) < holdTime)
				{
					return true;
				}
				CIPHHJHDOIA(JIIGOACEIKL, PBIEIJOICJL(JIIGOACEIKL) - holdTime);
			}
			KIHCIFEJADL(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(AMCCCEBJLEA));
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(OALBJCPGCHK));
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator3.OnToolEnd, new Action<int>(BJMENBGHFNK));
			return true;
		}
		return true;
	}

	private void FIHBMGGJDGM(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL < 1 && OnlineManager.MasterOrOffline()) || (JIIGOACEIKL == 0 && OnlineManager.PlayingOnline()))
		{
			HeldTools.IJMLNIHAOGK(JIIGOACEIKL).ActivateCutCollider();
		}
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HKBOOHPLNKP));
	}
}
