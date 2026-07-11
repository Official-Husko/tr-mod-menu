using System;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/Mop")]
public class Mop : Tool, IActionable
{
	[CompilerGenerated]
	private sealed class OFDDJGPEJGL
	{
		public Mop _003C_003E4__this;

		public int playerNum;

		internal void EDNAIHMAGND()
		{
			_003C_003E4__this.FGINLPKDDEP(playerNum);
		}

		internal void LMJNLHGCDDC()
		{
			_003C_003E4__this.FGINLPKDDEP(playerNum);
		}
	}

	public float speedCleaningDirt = 1f;

	private Action action;

	private Action action2;

	private GameObject hitObject;

	private FloorDirt floorDirt;

	private Table table;

	private FloorDirt floorDirt1;

	private FloorDirt floorDirt2;

	private InputByProximity currentInput;

	private void JNGEFEMKIGC(int JIIGOACEIKL)
	{
		ODKEEELIIJP(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(JLLEJJDFMOC));
	}

	private void BAKICLLNAGA(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.JHEHMLIPPAA(JIIGOACEIKL).KLFMPEJAGCO(DMBFKFLDDLH: true);
			LMEFFPBLKDK(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(DJLKBKBJFDK));
		}
		else
		{
			ICKDIEEPHGL(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void FEOMJKPJDAC(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(FEOMJKPJDAC));
	}

	private void HBGMBHNEHOA(int JIIGOACEIKL)
	{
		if (GHLPLIDJGKP(JIIGOACEIKL))
		{
			HeldTools.MFJNNCFFDEH(JIIGOACEIKL).GCBDIOFFDAH(DMBFKFLDDLH: true);
			EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(FHNHPFEPEOJ));
		}
		else
		{
			BBGOGACOIMM(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void GLAHBKJALAO(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KGNJENAKJNM));
	}

	private void DOGIFNBCCOF(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 0 && (JIIGOACEIKL >= 0 || !OnlineManager.ClientOnline())))
		{
			HeldTools.GIHKIEGFJNM(JIIGOACEIKL).CPLFJFJAOGA();
		}
	}

	private void AKGCBDEPCEK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(PHLBOEPONDK));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void BLFIEMPICFK(int JIIGOACEIKL)
	{
		if (HJBDLCNGCLN(JIIGOACEIKL))
		{
			HeldTools.JHEHMLIPPAA(JIIGOACEIKL).AJGDJEGLKFP(DMBFKFLDDLH: false);
			IAPMFGEHBMM(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(GCJLNOHIMJN));
		}
		else
		{
			KEAELNMELLO(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private FloorDirt MFINOKJCANA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void HOEPJEHDNLC(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(DLLNNHALHPK));
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(GMOGJCICKON));
		}
		else
		{
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator3.OnToolHit, new Action<int>(MDDNMBHOHCL));
		}
		CharacterAnimator characterAnimator4 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator4.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator4.OnToolEnd, new Action<int>(GCJLNOHIMJN));
	}

	private void OFFEPHHKKAE(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void LFOBFPMOLAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HHBJAILPHNM));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void PBMOMMEGEHF(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.GIHKIEGFJNM(JIIGOACEIKL).GODBPJAJGEB(DMBFKFLDDLH: false);
			LMEFFPBLKDK(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(BAKICLLNAGA));
		}
		else
		{
			AEECFCJIMIJ(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void JLFHHJAKKCH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(CFJOOFOAKOB));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private void JLLEJJDFMOC(int JIIGOACEIKL)
	{
		GOFFCPIPNNO(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(INLBEPFMMDH));
	}

	private void PLPMPDMBIAD(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.NPANPNIDKDG(JIIGOACEIKL).CJOIAIFBBIN(DMBFKFLDDLH: false);
			HCHCPFBFPLK(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(BAKICLLNAGA));
		}
		else
		{
			KEAELNMELLO(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private void OBLOCOBNBKJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(AKGCBDEPCEK));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void IFBBAPAKGGG(int JIIGOACEIKL)
	{
		ODKEEELIIJP(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(OCJFIPHFNAB));
	}

	public override void ActionEnd(int JIIGOACEIKL)
	{
		if ((Object)(object)DAJFJLOBNHL(JIIGOACEIKL) != (Object)null)
		{
			DAJFJLOBNHL(JIIGOACEIKL).Stop();
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
		}
	}

	private void CFJOOFOAKOB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(BPEIBLOFFLA));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private FloorDirt CGAFBBIDDFL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	public bool JOKFGOJJOED(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.GetPlayer(JIIGOACEIKL).actionToolDone)
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			KLGOCJMGKFO = true;
		}
		UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone = false;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 0)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).ABGDFIDOCCL();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if (Object.op_Implicit((Object)(object)currentInput) && (Object)(object)MFINOKJCANA(JIIGOACEIKL) == (Object)null && KLGOCJMGKFO)
			{
				CNCPNNHJAOE(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)OLDAJDBCLHH(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)EHMBKLMBAED(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetTrigger("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text", HALNIEBONKH: true);
				HOEPJEHDNLC(JIIGOACEIKL);
				return true;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).ALPHFOIMNIA(" ") && !PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButton("itemChocolateWort"))
				{
					return true;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 8f)
				{
					return false;
				}
				KLGOCJMGKFO = false;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("Could not check is DLC ") && ((Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null || !InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).HOMHFEJHKIF().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 1308f))
			{
				if (KLGOCJMGKFO)
				{
					IJFEDIJNMDE(JIIGOACEIKL, 292f);
					if (JIIGOACEIKL == 0)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					PFGHKEJDPMJ(JIIGOACEIKL, GNKMPAPJLCM(JIIGOACEIKL) + Time.deltaTime);
					if (MMLOLBMOAFB(JIIGOACEIKL) < holdTime)
					{
						return true;
					}
					MKMABNJFPAC(JIIGOACEIKL, FHMDFFIDFAI(JIIGOACEIKL) - holdTime);
				}
				JMLLOEKMKFA(JIIGOACEIKL);
				HeldTools.FLOIJFPDJGG(JIIGOACEIKL).GODBPJAJGEB(DMBFKFLDDLH: false);
				EEGPDDJCMFI(JIIGOACEIKL);
				return true;
			}
		}
		else if ((Object)(object)OAHPGDKFGFE(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return EHMBKLMBAED(JIIGOACEIKL).EELFIIHLDCB(JIIGOACEIKL, speedCleaningDirt);
		}
		return false;
	}

	private void JBMHCINMBGF(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).KLFMPEJAGCO(DMBFKFLDDLH: true);
			HCHCPFBFPLK(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(NFGEGBAFLNK));
		}
		else
		{
			NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private void IODJMEEFMJA(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 0)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void KFGAPCBEEHI(int JIIGOACEIKL)
	{
		ACJIEGKNIAJ(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(LIFNBAPIOFN));
	}

	private void NFDLNOEMFBE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(KJKGKCNIIFB));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private void ACFKKHCFOEI(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 0 && (JIIGOACEIKL >= 1 || !OnlineManager.ClientOnline())))
		{
			HeldTools.JHEHMLIPPAA(JIIGOACEIKL).LOKAJGKNNOB();
		}
	}

	public bool ECKGJAHMFAL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			KLGOCJMGKFO = false;
		}
		UseObject.GetPlayer(JIIGOACEIKL).actionToolDone = false;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 0)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).ABGDFIDOCCL();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)OLDAJDBCLHH(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				IODJMEEFMJA(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)BAAGJLHNGCD(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)OAHPGDKFGFE(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetTrigger("LE_15");
				HOEPJEHDNLC(JIIGOACEIKL);
				return false;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LKOGGHNGBKD("ObjectMove") && !PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButton("Items/item_description_1175"))
				{
					return false;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 577f)
				{
					return true;
				}
				KLGOCJMGKFO = false;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GetBool("Hide") && ((Object)(object)InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null || !InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).ABGDFIDOCCL().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DBAEGBDEPFK() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 1670f))
			{
				if (KLGOCJMGKFO)
				{
					MKMABNJFPAC(JIIGOACEIKL, 1550f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					IJFEDIJNMDE(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) + Time.deltaTime);
					if (MMLOLBMOAFB(JIIGOACEIKL) < holdTime)
					{
						return true;
					}
					OIGCDGEMCNK(JIIGOACEIKL, FHMDFFIDFAI(JIIGOACEIKL) - holdTime);
				}
				JMLLOEKMKFA(JIIGOACEIKL);
				HeldTools.NPANPNIDKDG(JIIGOACEIKL).GCBDIOFFDAH(DMBFKFLDDLH: false);
				CKFBFHIGJHO(JIIGOACEIKL);
				return false;
			}
		}
		else if ((Object)(object)KHMHJJNLGFP(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return OAHPGDKFGFE(JIIGOACEIKL).GBJGKICAKKK(JIIGOACEIKL, speedCleaningDirt);
		}
		return true;
	}

	private void LIFOEADBCOL(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 0 && (JIIGOACEIKL >= 1 || !OnlineManager.ClientOnline())))
		{
			HeldTools.JBFDEAGDJEL(JIIGOACEIKL).GIOFPMFNCDP();
		}
	}

	private void LIFNBAPIOFN(int JIIGOACEIKL)
	{
		GOFFCPIPNNO(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(INLBEPFMMDH));
	}

	private FloorDirt PPEAIOOOPCP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void LCOIHJLEOKE(int JIIGOACEIKL)
	{
		GOFFCPIPNNO(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(CDKHDHIMNBL));
	}

	private void AHHHIEDCBHB(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.MFJNNCFFDEH(JIIGOACEIKL).MHIHCNMEOJC(DMBFKFLDDLH: false);
			EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(BAKICLLNAGA));
		}
		else
		{
			IIMPDNEIAMB(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void MCJKDANIPED(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void HAIGMMAKCLK(int JIIGOACEIKL)
	{
		if (KGALGJPFOJO(JIIGOACEIKL))
		{
			HeldTools.IJMLNIHAOGK(JIIGOACEIKL).KOCODBEHAJD(DMBFKFLDDLH: true);
			EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(FHNHPFEPEOJ));
		}
		else
		{
			IHKALDEHDCH(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private FloorDirt KMIECPAIJOE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void CLMALGKJIEH(int JIIGOACEIKL)
	{
		IOHAEIGGJDD(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(FEOMJKPJDAC));
	}

	private void CDKHDHIMNBL(int JIIGOACEIKL)
	{
		IOHAEIGGJDD(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(INLBEPFMMDH));
	}

	private FloorDirt FAIKMLHOBPM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void GCJLNOHIMJN(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.IDGHAADJPCK(JIIGOACEIKL).AGNGFBDKJPK(DMBFKFLDDLH: true);
			HCHCPFBFPLK(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(PBMOMMEGEHF));
		}
		else
		{
			IHKALDEHDCH(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private void NNIKHKPJJKD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(LFOBFPMOLAK));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void FODJOJGMAHO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(FODJOJGMAHO));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void HHIJEMCFNOG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DECDFDPICOO));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private void MDDNMBHOHCL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(MDDNMBHOHCL));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private void APBKOIPDILJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(HHBJAILPHNM));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private FloorDirt DAJFJLOBNHL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void DMJLLOFIKOO(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 1 || !OnlineManager.HHDBMDMFEMP())))
		{
			HeldTools.DACNEICGAAE(JIIGOACEIKL).LMAJJKBBFAD();
		}
	}

	private void IEMNIBNBNKP(int JIIGOACEIKL)
	{
		GOFFCPIPNNO(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(INLBEPFMMDH));
	}

	private void GMOGJCICKON(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(KJKGKCNIIFB));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private void DECDFDPICOO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(FODJOJGMAHO));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private FloorDirt HAKAHOCPAAG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.GetPlayer(JIIGOACEIKL).actionToolDone)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = false;
		}
		UseObject.GetPlayer(JIIGOACEIKL).actionToolDone = true;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 1)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if (Object.op_Implicit((Object)(object)currentInput) && (Object)(object)DAJFJLOBNHL(JIIGOACEIKL) == (Object)null && KLGOCJMGKFO)
			{
				HJEMBPOJLFH(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)DAJFJLOBNHL(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)DAJFJLOBNHL(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetTrigger("Mop");
				JCHFGPOFJLC(JIIGOACEIKL);
				return true;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Interact") && !PlayerInputs.GetPlayer(JIIGOACEIKL).GetButton("Use"))
				{
					return false;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 0.3f)
				{
					return false;
				}
				KLGOCJMGKFO = true;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("UseHold") && ((Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null || !InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && ((Object)(object)floorDirt != (Object)null || PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 0.5f))
			{
				if (KLGOCJMGKFO)
				{
					EFGDCGFFKFF(JIIGOACEIKL, 0f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
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
				HeldTools.GetPlayer(JIIGOACEIKL).SetMopActive(DMBFKFLDDLH: true);
				JCHFGPOFJLC(JIIGOACEIKL);
				return true;
			}
		}
		else if ((Object)(object)DAJFJLOBNHL(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return DAJFJLOBNHL(JIIGOACEIKL).Clean(JIIGOACEIKL, speedCleaningDirt);
		}
		return false;
	}

	private void EEGPDDJCMFI(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(GEDMPBIHBCO));
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(ANFGBKLNFJB));
		}
		else
		{
			CharacterAnimator characterAnimator3 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator3.OnToolHit, new Action<int>(HHIJEMCFNOG));
		}
		CharacterAnimator characterAnimator4 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator4.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator4.OnToolEnd, new Action<int>(BAKICLLNAGA));
	}

	private void HNFJLDKGKNL(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(FEOMJKPJDAC));
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(OMIMIJPGION));
		}
		else
		{
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator3.OnToolHit, new Action<int>(NNIKHKPJJKD));
		}
		CharacterAnimator characterAnimator4 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator4.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator4.OnToolEnd, new Action<int>(MJMBONJBMGJ));
	}

	private void CKFBFHIGJHO(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(LCOIHJLEOKE));
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			CharacterAnimator characterAnimator2 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(AOHFLPPBONN));
		}
		else
		{
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator3.OnToolHit, new Action<int>(NNIKHKPJJKD));
		}
		CharacterAnimator characterAnimator4 = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator4.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator4.OnToolEnd, new Action<int>(PBMOMMEGEHF));
	}

	private void GEBIJJPNDCH(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void GMPGKAMCMBD(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 0 || !OnlineManager.HHDBMDMFEMP())))
		{
			HeldTools.DACNEICGAAE(JIIGOACEIKL).CHBIECCDAJF();
		}
	}

	private void MJMBONJBMGJ(int JIIGOACEIKL)
	{
		if (GHLPLIDJGKP(JIIGOACEIKL))
		{
			HeldTools.FLOIJFPDJGG(JIIGOACEIKL).DFGHMDNCBCP(DMBFKFLDDLH: true);
			HCHCPFBFPLK(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JBMHCINMBGF));
		}
		else
		{
			MOPEAIHAJON(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void GJJLNKBMAKD(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void PHLBOEPONDK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OMIMIJPGION));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void BOIPMHJMGIP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(BOIPMHJMGIP));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private FloorDirt BAAGJLHNGCD(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	public bool MEPINLHDLCB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.GetPlayer(JIIGOACEIKL).actionToolDone)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = false;
		}
		UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone = false;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 0)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).GFCOOKLMLNE();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)CCIKFKMDIMC(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				GJJLNKBMAKD(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)CCIKFKMDIMC(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)BAAGJLHNGCD(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("/Display Name");
				CMKLFLEFIBJ(JIIGOACEIKL);
				return false;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.GetPlayer(JIIGOACEIKL).KFAFNEJNDDL("[MinePuzzleManager] Not enough spawners even with fallback for {0} (needed {1}). Trying another type.") && !PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButton("qualityWater2"))
				{
					return true;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 1498f)
				{
					return false;
				}
				KLGOCJMGKFO = true;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.GetBool(")") && ((Object)(object)InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).HBIKILDEHFI() == (Object)null || !InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 590f))
			{
				if (KLGOCJMGKFO)
				{
					EFGDCGFFKFF(JIIGOACEIKL, 341f);
					if (JIIGOACEIKL == 0)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					EFGDCGFFKFF(JIIGOACEIKL, GNKMPAPJLCM(JIIGOACEIKL) + Time.deltaTime);
					if (FHMDFFIDFAI(JIIGOACEIKL) < holdTime)
					{
						return false;
					}
					CIPHHJHDOIA(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) - holdTime);
				}
				JMLLOEKMKFA(JIIGOACEIKL);
				HeldTools.FLOIJFPDJGG(JIIGOACEIKL).GCBDIOFFDAH(DMBFKFLDDLH: false);
				CKFBFHIGJHO(JIIGOACEIKL);
				return false;
			}
		}
		else if ((Object)(object)OAHPGDKFGFE(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return APEMBKJAKFJ(JIIGOACEIKL).EELFIIHLDCB(JIIGOACEIKL, speedCleaningDirt);
		}
		return true;
	}

	private void CMKLFLEFIBJ(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(KFGAPCBEEHI));
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(ANFGBKLNFJB));
		}
		else
		{
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator3.OnToolHit, new Action<int>(MDDNMBHOHCL));
		}
		CharacterAnimator characterAnimator4 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator4.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator4.OnToolEnd, new Action<int>(NFGEGBAFLNK));
	}

	private void AMMOAACAIFN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DECDFDPICOO));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void KCFABNAGBNN(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(OLIECFIDFJD));
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(KJKGKCNIIFB));
		}
		else
		{
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator3.OnToolHit, new Action<int>(JLFHHJAKKCH));
		}
		CharacterAnimator characterAnimator4 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator4.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator4.OnToolEnd, new Action<int>(HAIGMMAKCLK));
	}

	public bool EHHCPOCLAJA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = false;
		}
		UseObject.JBFDEAGDJEL(JIIGOACEIKL).actionToolDone = true;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 0)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).ABGDFIDOCCL();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)APEMBKJAKFJ(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				CNCPNNHJAOE(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)CGAFBBIDDFL(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)OAHPGDKFGFE(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("Dog");
				HOEPJEHDNLC(JIIGOACEIKL);
				return false;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).KFAFNEJNDDL("Top") && !PlayerInputs.GetPlayer(JIIGOACEIKL).JDLEBBLKOFF("Invalid player num"))
				{
					return false;
				}
				if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK > 996f)
				{
					return false;
				}
				KLGOCJMGKFO = true;
			}
			if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD() && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("UIScrollDown") && ((Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null || !InputByProximityManager.GetPlayer(JIIGOACEIKL).GDJNPPCMIBL().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DBAEGBDEPFK() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 505f))
			{
				if (KLGOCJMGKFO)
				{
					IJFEDIJNMDE(JIIGOACEIKL, 1929f);
					if (JIIGOACEIKL == 0)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					CIPHHJHDOIA(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) + Time.deltaTime);
					if (PBIEIJOICJL(JIIGOACEIKL) < holdTime)
					{
						return true;
					}
					PFGHKEJDPMJ(JIIGOACEIKL, PBIEIJOICJL(JIIGOACEIKL) - holdTime);
				}
				JOLOOFLEAON(JIIGOACEIKL);
				HeldTools.EIFPKCAFDIB(JIIGOACEIKL).AGNGFBDKJPK(DMBFKFLDDLH: false);
				KCFABNAGBNN(JIIGOACEIKL);
				return false;
			}
		}
		else if ((Object)(object)DHNOODMPOAP(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return CCIKFKMDIMC(JIIGOACEIKL).AEBLENEONED(JIIGOACEIKL, speedCleaningDirt);
		}
		return true;
	}

	private FloorDirt OAHPGDKFGFE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	public bool FPOPMBEJFLM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.GetPlayer(JIIGOACEIKL).actionToolDone)
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = false;
		}
		UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone = true;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 0)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).GDJNPPCMIBL();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if (Object.op_Implicit((Object)(object)currentInput) && (Object)(object)EHMBKLMBAED(JIIGOACEIKL) == (Object)null && KLGOCJMGKFO)
			{
				NKCAEFAJDKP(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)DHNOODMPOAP(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)FAIKMLHOBPM(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("Body Part Dictionary:\n[\n", HALNIEBONKH: true);
				CKFBFHIGJHO(JIIGOACEIKL);
				return true;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.GetPlayer(JIIGOACEIKL).LKOGGHNGBKD("Pool Object from ") && !PlayerInputs.GetPlayer(JIIGOACEIKL).JDLEBBLKOFF("<size="))
				{
					return true;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 428f)
				{
					return true;
				}
				KLGOCJMGKFO = true;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("\n<color=#822F00>") && ((Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null || !InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HBIKILDEHFI().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).GABNNLJOMHI() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 1937f))
			{
				if (KLGOCJMGKFO)
				{
					EFGDCGFFKFF(JIIGOACEIKL, 404f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					GJNOFPDHCMA(JIIGOACEIKL, GNKMPAPJLCM(JIIGOACEIKL) + Time.deltaTime);
					if (PBIEIJOICJL(JIIGOACEIKL) < holdTime)
					{
						return false;
					}
					GPFCALFMEAM(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) - holdTime);
				}
				MDFJCMMOHJA(JIIGOACEIKL);
				HeldTools.OGKNJNINGMH(JIIGOACEIKL).HKKJPGGJCII(DMBFKFLDDLH: false);
				HOEPJEHDNLC(JIIGOACEIKL);
				return true;
			}
		}
		else if ((Object)(object)EHMBKLMBAED(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return APEMBKJAKFJ(JIIGOACEIKL).GBJGKICAKKK(JIIGOACEIKL, speedCleaningDirt);
		}
		return false;
	}

	private void CCEPCFDJHAH(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 0)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void PGBBFLOOMID(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 0 || !OnlineManager.HHDBMDMFEMP())))
		{
			HeldTools.FIHGMLABOBB(JIIGOACEIKL).LOKAJGKNNOB();
		}
	}

	private void IKOFBGKFLKE(int JIIGOACEIKL)
	{
		GGDHPGBLJGI(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(FEOMJKPJDAC));
	}

	private FloorDirt NBPOCLKEKLA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void LNLJDOJBHKB(int JIIGOACEIKL)
	{
		if (HJBDLCNGCLN(JIIGOACEIKL))
		{
			HeldTools.EJKCBAKCBEO(JIIGOACEIKL).HKKJPGGJCII(DMBFKFLDDLH: true);
			IAPMFGEHBMM(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JBMHCINMBGF));
		}
		else
		{
			AEECFCJIMIJ(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	public bool JNKIOAJBKGE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.JBFDEAGDJEL(JIIGOACEIKL).actionToolDone)
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = true;
		}
		UseObject.JBFDEAGDJEL(JIIGOACEIKL).actionToolDone = true;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 1)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HBIKILDEHFI();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if (Object.op_Implicit((Object)(object)currentInput) && (Object)(object)KMIECPAIJOE(JIIGOACEIKL) == (Object)null && KLGOCJMGKFO)
			{
				IODJMEEFMJA(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)EHMBKLMBAED(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)KHMHJJNLGFP(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("Error in TavernEventManager.EndOfDayEventCheck: ");
				HNFJLDKGKNL(JIIGOACEIKL);
				return false;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).ALPHFOIMNIA("ExampleMethodSetTitle") && !PlayerInputs.GetPlayer(JIIGOACEIKL).ENIPCNOKAOM("Check to enable"))
				{
					return true;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 1973f)
				{
					return true;
				}
				KLGOCJMGKFO = false;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("Items/item_description_1034") && ((Object)(object)InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).HBIKILDEHFI() == (Object)null || !InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).GFCOOKLMLNE().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 746f))
			{
				if (KLGOCJMGKFO)
				{
					EFGDCGFFKFF(JIIGOACEIKL, 395f);
					if (JIIGOACEIKL == 0)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					MKMABNJFPAC(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) + Time.deltaTime);
					if (NLLFCOOCKDF(JIIGOACEIKL) < holdTime)
					{
						return false;
					}
					DJDDPBBIHLB(JIIGOACEIKL, PBIEIJOICJL(JIIGOACEIKL) - holdTime);
				}
				BLODLBPHFDJ(JIIGOACEIKL);
				HeldTools.GetPlayer(JIIGOACEIKL).HKKJPGGJCII(DMBFKFLDDLH: true);
				EEGPDDJCMFI(JIIGOACEIKL);
				return false;
			}
		}
		else if ((Object)(object)OGOCPFCKDCK(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return APEMBKJAKFJ(JIIGOACEIKL).AEBLENEONED(JIIGOACEIKL, speedCleaningDirt);
		}
		return false;
	}

	private void HHBJAILPHNM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(BPEIBLOFFLA));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private FloorDirt EHMBKLMBAED(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void JCHFGPOFJLC(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = true;
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(FEOMJKPJDAC));
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			CharacterAnimator characterAnimator2 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator2.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator2.OnToolHit, new Action<int>(AOHFLPPBONN));
		}
		else
		{
			CharacterAnimator characterAnimator3 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator3.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator3.OnToolHit, new Action<int>(FODJOJGMAHO));
		}
		CharacterAnimator characterAnimator4 = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator4.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator4.OnToolEnd, new Action<int>(MPOGBAHELON));
	}

	private void PCNFEIEKHAO(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 0 || !OnlineManager.ClientOnline())))
		{
			HeldTools.EIFPKCAFDIB(JIIGOACEIKL).LOKAJGKNNOB();
		}
	}

	private void DBMLDLJALDG(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 1 || !OnlineManager.HHDBMDMFEMP())))
		{
			HeldTools.IDGHAADJPCK(JIIGOACEIKL).GIOFPMFNCDP();
		}
	}

	public bool IKPNNKPDGPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.GetPlayer(JIIGOACEIKL).actionToolDone)
		{
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			KLGOCJMGKFO = false;
		}
		UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone = true;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 0)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).ABGDFIDOCCL();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)OAHPGDKFGFE(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				CCEPCFDJHAH(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)KHMHJJNLGFP(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)MFINOKJCANA(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetTrigger("Locks the game so no new players can join even if there's still room.", HALNIEBONKH: true);
				HOEPJEHDNLC(JIIGOACEIKL);
				return true;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("Items/item_name_636") && !PlayerInputs.GetPlayer(JIIGOACEIKL).ENIPCNOKAOM("Observation"))
				{
					return false;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 1816f)
				{
					return false;
				}
				KLGOCJMGKFO = false;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP() && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("City/PetShop/Nessy/PerritosAbandonados3") && ((Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null || !InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).GetCurrentFocusedInputElement().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 1171f))
			{
				if (KLGOCJMGKFO)
				{
					MKMABNJFPAC(JIIGOACEIKL, 1665f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					GJNOFPDHCMA(JIIGOACEIKL, FHMDFFIDFAI(JIIGOACEIKL) + Time.deltaTime);
					if (PBIEIJOICJL(JIIGOACEIKL) < holdTime)
					{
						return true;
					}
					PFGHKEJDPMJ(JIIGOACEIKL, PBIEIJOICJL(JIIGOACEIKL) - holdTime);
				}
				BLODLBPHFDJ(JIIGOACEIKL);
				HeldTools.OGKNJNINGMH(JIIGOACEIKL).DFGHMDNCBCP(DMBFKFLDDLH: true);
				CKFBFHIGJHO(JIIGOACEIKL);
				return true;
			}
		}
		else if ((Object)(object)PPEAIOOOPCP(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return BAAGJLHNGCD(JIIGOACEIKL).FFFCFIOKCCB(JIIGOACEIKL, speedCleaningDirt);
		}
		return true;
	}

	private void HJEMBPOJLFH(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void BFAHMIIBMDN(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 1 || !OnlineManager.ClientOnline())))
		{
			HeldTools.JBFDEAGDJEL(JIIGOACEIKL).HKOOLEACKNB();
		}
	}

	private void NFGEGBAFLNK(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.GIAOPMIDGPL(JIIGOACEIKL).KOCODBEHAJD(DMBFKFLDDLH: false);
			EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(JBMHCINMBGF));
		}
		else
		{
			IHKALDEHDCH(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void KGNJENAKJNM(int JIIGOACEIKL)
	{
		IOHAEIGGJDD(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(FEOMJKPJDAC));
	}

	private void BPEIBLOFFLA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(DECDFDPICOO));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void GDNEDEPECHE(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void GEDMPBIHBCO(int JIIGOACEIKL)
	{
		ACJIEGKNIAJ(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(GLAHBKJALAO));
	}

	private void HCBEFLMLPCF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(MDDNMBHOHCL));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private void HCIKIGMAKAN(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 1 || !OnlineManager.HHDBMDMFEMP())))
		{
			HeldTools.EIFPKCAFDIB(JIIGOACEIKL).HKOOLEACKNB();
		}
	}

	public bool IJHFHABALCP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone)
		{
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = false;
		}
		UseObject.JBFDEAGDJEL(JIIGOACEIKL).actionToolDone = false;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 1)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).HOMHFEJHKIF();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)MFINOKJCANA(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				DCOMOJEBFFB(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)HAKAHOCPAAG(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)OGOCPFCKDCK(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("ReceiveAddToPlaceableSurface");
				CKFBFHIGJHO(JIIGOACEIKL);
				return false;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).ALPHFOIMNIA("Cancel") && !PlayerInputs.GetPlayer(JIIGOACEIKL).DEPIHKBMKLP("{0} - The mine piece {1} has a variant object with puzzle altar but the piece ID doesn't match the altar piece ID. Piece ID: {2} - Altar Piece ID: {3}"))
				{
					return true;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 994f)
				{
					return false;
				}
				KLGOCJMGKFO = false;
			}
			if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("Plant") && ((Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null || !InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).ABGDFIDOCCL().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK < 651f))
			{
				if (KLGOCJMGKFO)
				{
					CIPHHJHDOIA(JIIGOACEIKL, 1674f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					MPECPKPFKFB(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) + Time.deltaTime);
					if (NLLFCOOCKDF(JIIGOACEIKL) < holdTime)
					{
						return true;
					}
					OJIBPBKGGNK(JIIGOACEIKL, LJJKANNAHCM(JIIGOACEIKL) - holdTime);
				}
				JOLOOFLEAON(JIIGOACEIKL);
				HeldTools.DACNEICGAAE(JIIGOACEIKL).DFGHMDNCBCP(DMBFKFLDDLH: false);
				CKFBFHIGJHO(JIIGOACEIKL);
				return true;
			}
		}
		else if ((Object)(object)CCIKFKMDIMC(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return CGAFBBIDDFL(JIIGOACEIKL).HBLLEFBCDAP(JIIGOACEIKL, speedCleaningDirt);
		}
		return true;
	}

	private FloorDirt OLDAJDBCLHH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	public bool FDDMANBCACB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.JBFDEAGDJEL(JIIGOACEIKL).actionToolDone)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = false;
		}
		UseObject.GetPlayer(JIIGOACEIKL).actionToolDone = false;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 1)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.JOFDIPFMIHF(JIIGOACEIKL).HBIKILDEHFI();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)PPEAIOOOPCP(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				DCOMOJEBFFB(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)KHMHJJNLGFP(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)OAHPGDKFGFE(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK)
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("Items/item_description_622");
				HNFJLDKGKNL(JIIGOACEIKL);
				return false;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).KFAFNEJNDDL("<br/>Processor Count: ") && !PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButton("<sprite name=white_arrow_right> "))
				{
					return false;
				}
				if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GHKOCEOEKGK > 1728f)
				{
					return false;
				}
				KLGOCJMGKFO = false;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IMLECKKPLCP() && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.JEJPKGILEDB("ReceiveRoomRequest") && ((Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HBIKILDEHFI() == (Object)null || !InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).HBIKILDEHFI().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 309f))
			{
				if (KLGOCJMGKFO)
				{
					CIPHHJHDOIA(JIIGOACEIKL, 1637f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					CIPHHJHDOIA(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) + Time.deltaTime);
					if (GNKMPAPJLCM(JIIGOACEIKL) < holdTime)
					{
						return false;
					}
					PFGHKEJDPMJ(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) - holdTime);
				}
				KOGOMPONEDP(JIIGOACEIKL);
				HeldTools.IJMLNIHAOGK(JIIGOACEIKL).KOCODBEHAJD(DMBFKFLDDLH: true);
				HNFJLDKGKNL(JIIGOACEIKL);
				return true;
			}
		}
		else if ((Object)(object)MFINOKJCANA(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return KMIECPAIJOE(JIIGOACEIKL).GBJGKICAKKK(JIIGOACEIKL, speedCleaningDirt);
		}
		return false;
	}

	private void FHNHPFEPEOJ(int JIIGOACEIKL)
	{
		if (KGALGJPFOJO(JIIGOACEIKL))
		{
			HeldTools.IJMLNIHAOGK(JIIGOACEIKL).KOCODBEHAJD(DMBFKFLDDLH: false);
			IAPMFGEHBMM(JIIGOACEIKL);
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(LNLJDOJBHKB));
		}
		else
		{
			MOPEAIHAJON(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void DLLNNHALHPK(int JIIGOACEIKL)
	{
		ODKEEELIIJP(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(GLAHBKJALAO));
	}

	private void IEILBGBCOKO(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void OLIECFIDFJD(int JIIGOACEIKL)
	{
		ODKEEELIIJP(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KGNJENAKJNM));
	}

	public bool CCAIAGGNIPO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone)
		{
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = false;
		}
		UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone = true;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 1)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.NMGNGAEEKIO(JIIGOACEIKL).GetCurrentFocusedInputElement();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)EHMBKLMBAED(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				DCOMOJEBFFB(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)DAJFJLOBNHL(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)OGOCPFCKDCK(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.IHLIHEEAIMD())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("Successfully signed in");
				JCHFGPOFJLC(JIIGOACEIKL);
				return true;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).KFAFNEJNDDL("NextItem") && !PlayerInputs.GetPlayer(JIIGOACEIKL).DEPIHKBMKLP(" sent to delivery chest. WallFloor invalid"))
				{
					return false;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 1906f)
				{
					return true;
				}
				KLGOCJMGKFO = true;
			}
			if (!PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("Hurt") && ((Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null || !InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).GDJNPPCMIBL().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.GetPlayer(JIIGOACEIKL).BIBGIOPFJAF() && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD() && ((Object)(object)floorDirt != (Object)null || PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 1605f))
			{
				if (KLGOCJMGKFO)
				{
					OJIBPBKGGNK(JIIGOACEIKL, 1350f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					GPFCALFMEAM(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) + Time.deltaTime);
					if (LEHHFMELACA(JIIGOACEIKL) < holdTime)
					{
						return false;
					}
					GJNOFPDHCMA(JIIGOACEIKL, NLLFCOOCKDF(JIIGOACEIKL) - holdTime);
				}
				JMLLOEKMKFA(JIIGOACEIKL);
				HeldTools.IJMLNIHAOGK(JIIGOACEIKL).MHIHCNMEOJC(DMBFKFLDDLH: false);
				CKFBFHIGJHO(JIIGOACEIKL);
				return true;
			}
		}
		else if ((Object)(object)KHMHJJNLGFP(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return DAJFJLOBNHL(JIIGOACEIKL).LKECKENGGHM(JIIGOACEIKL, speedCleaningDirt);
		}
		return false;
	}

	private void BMGEHNNFDME(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 0 && (JIIGOACEIKL >= 0 || !OnlineManager.ClientOnline())))
		{
			HeldTools.GIHKIEGFJNM(JIIGOACEIKL).LMAJJKBBFAD();
		}
	}

	private void JMACINFOBCA(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 0)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void KJKGKCNIIFB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(OMIMIJPGION));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void ANFGBKLNFJB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(FKPIFAJOKDO));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void AOHFLPPBONN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(AOHFLPPBONN));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void FKPIFAJOKDO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(KJKGKCNIIFB));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private void FGINLPKDDEP(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 1 || !OnlineManager.ClientOnline())))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).ActivateHitCollider();
		}
	}

	private void DJLKBKBJFDK(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).NGFIPKJIEBB(DMBFKFLDDLH: true);
			EPEECLGBHMI(JIIGOACEIKL);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(HAIGMMAKCLK));
		}
		else
		{
			NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: false);
		}
	}

	private void INLBEPFMMDH(int JIIGOACEIKL)
	{
		JLADECOLHPI(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KFGAPCBEEHI));
	}

	private void LBGBIJGALNM(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 0 && (JIIGOACEIKL >= 1 || !OnlineManager.HHDBMDMFEMP())))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).LMAJJKBBFAD();
		}
	}

	private void EDFOJJOOMGE(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 1 || !OnlineManager.HHDBMDMFEMP())))
		{
			HeldTools.NPANPNIDKDG(JIIGOACEIKL).GIOFPMFNCDP();
		}
	}

	private void OMIMIJPGION(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(GMOGJCICKON));
		MultiAudioManager.PlayAudioObject(sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
	}

	private void MPOGBAHELON(int JIIGOACEIKL)
	{
		if (MJDLOICFCNH(JIIGOACEIKL))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).SetMopActive(DMBFKFLDDLH: false);
			EPEECLGBHMI(JIIGOACEIKL, GLLNEFAPDDF: true);
			PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE = false;
			CharacterAnimator characterAnimator = PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator;
			characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(MPOGBAHELON));
		}
		else
		{
			NPFKHAFMDAG(JIIGOACEIKL, NJHMBMGKCPL: true);
		}
	}

	private void NKCAEFAJDKP(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 0)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private void FOMBLDIKFEA(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 1 || !OnlineManager.ClientOnline())))
		{
			HeldTools.EJKCBAKCBEO(JIIGOACEIKL).HKLIFCGGMHN();
		}
	}

	private FloorDirt CCIKFKMDIMC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void JGCEAFIPEHM(int JIIGOACEIKL)
	{
		if (!OnlineManager.PlayingOnline() || (JIIGOACEIKL <= 1 && (JIIGOACEIKL >= 0 || !OnlineManager.ClientOnline())))
		{
			HeldTools.GetPlayer(JIIGOACEIKL).GIOFPMFNCDP();
		}
	}

	private FloorDirt DHNOODMPOAP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void OLLHKKCKIDN(int JIIGOACEIKL)
	{
		HEPAAHFBBOF(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(KGNJENAKJNM));
	}

	private void DCOMOJEBFFB(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	public bool EEOBNABBHHF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (UseObject.JBFDEAGDJEL(JIIGOACEIKL).actionToolDone)
		{
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			KLGOCJMGKFO = true;
		}
		UseObject.JDPMNBOLMJC(JIIGOACEIKL).actionToolDone = true;
		hitObject = null;
		if (KLGOCJMGKFO)
		{
			if (JIIGOACEIKL == 1)
			{
				floorDirt1 = null;
				action = delegate
				{
				};
			}
			else
			{
				floorDirt2 = null;
				action2 = delegate
				{
				};
			}
			table = null;
			currentInput = InputByProximityManager.NMGNGAEEKIO(JIIGOACEIKL).GDJNPPCMIBL();
		}
		if (Object.op_Implicit((Object)(object)currentInput))
		{
			floorDirt = currentInput.mainGameObject.GetComponent<FloorDirt>();
			table = currentInput.mainGameObject.GetComponent<Table>();
		}
		else
		{
			floorDirt = null;
			table = null;
		}
		if (Object.op_Implicit((Object)(object)floorDirt))
		{
			if ((!Object.op_Implicit((Object)(object)currentInput) || (Object)(object)NBPOCLKEKLA(JIIGOACEIKL) == (Object)null) && KLGOCJMGKFO)
			{
				GDNEDEPECHE(JIIGOACEIKL, floorDirt);
			}
			if ((Object)(object)BAAGJLHNGCD(JIIGOACEIKL) != (Object)null)
			{
				hitObject = ((Component)DHNOODMPOAP(JIIGOACEIKL)).gameObject;
			}
		}
		if (!PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (Object.op_Implicit((Object)(object)floorDirt) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK)
			{
				PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookAtSelectedNotDelay(JIIGOACEIKL);
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/34/Dialogue Text", HALNIEBONKH: true);
				CKFBFHIGJHO(JIIGOACEIKL);
				return true;
			}
			if (Object.op_Implicit((Object)(object)table))
			{
				if (!PlayerInputs.GetPlayer(JIIGOACEIKL).LKOGGHNGBKD("ReceiveEmployeeTask") && !PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).DEPIHKBMKLP("Distilling"))
				{
					return true;
				}
				if (PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK > 1208f)
				{
					return true;
				}
				KLGOCJMGKFO = true;
			}
			if (!PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator.MLBGEKOIALK && !PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.GetBool("Close") && ((Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null || !InputByProximityManager.JOFDIPFMIHF(JIIGOACEIKL).GetCurrentFocusedInputElement().disableActionableItemsWhenFocused || Object.op_Implicit((Object)(object)table)) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH && ((Object)(object)floorDirt != (Object)null || PlayerInputs.GetPlayer(JIIGOACEIKL).GHKOCEOEKGK < 480f))
			{
				if (KLGOCJMGKFO)
				{
					IJFEDIJNMDE(JIIGOACEIKL, 1027f);
					if (JIIGOACEIKL == 1)
					{
						action = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
					else
					{
						action2 = delegate
						{
							FGINLPKDDEP(JIIGOACEIKL);
						};
					}
				}
				else
				{
					PFGHKEJDPMJ(JIIGOACEIKL, LEHHFMELACA(JIIGOACEIKL) + Time.deltaTime);
					if (NLLFCOOCKDF(JIIGOACEIKL) < holdTime)
					{
						return false;
					}
					CIPHHJHDOIA(JIIGOACEIKL, MMLOLBMOAFB(JIIGOACEIKL) - holdTime);
				}
				GPHLEINIMDB(JIIGOACEIKL);
				HeldTools.FIHGMLABOBB(JIIGOACEIKL).KLFMPEJAGCO(DMBFKFLDDLH: false);
				KCFABNAGBNN(JIIGOACEIKL);
				return false;
			}
		}
		else if ((Object)(object)FAIKMLHOBPM(JIIGOACEIKL) != (Object)null && (Object)(object)hitObject != (Object)null)
		{
			return KHMHJJNLGFP(JIIGOACEIKL).LKECKENGGHM(JIIGOACEIKL, speedCleaningDirt);
		}
		return false;
	}

	private void OCJFIPHFNAB(int JIIGOACEIKL)
	{
		PCEHBFMDBMG(JIIGOACEIKL);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(LCOIHJLEOKE));
	}

	private void CNCPNNHJAOE(int JIIGOACEIKL, FloorDirt DDJECCPKNKG)
	{
		if (JIIGOACEIKL == 1)
		{
			floorDirt1 = DDJECCPKNKG;
		}
		else
		{
			floorDirt2 = DDJECCPKNKG;
		}
	}

	private FloorDirt APEMBKJAKFJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private FloorDirt OGOCPFCKDCK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}

	private void ABLBFBNJPIH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			action();
		}
		else
		{
			action2();
		}
		CharacterAnimator characterAnimator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.characterAnimator;
		characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(LFOBFPMOLAK));
		MultiAudioManager.PlayAudioObject(weaponSound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
	}

	private FloorDirt KHMHJJNLGFP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return floorDirt1;
		}
		return floorDirt2;
	}
}
