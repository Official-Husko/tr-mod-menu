using System;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class CustomerStateRequestingRoom : CustomerStateBase
{
	private float BGELPKAELFA;

	private int MOKLKLNAJEP;

	private float NBIHJLMPPFF;

	private float DPAHMOPBLIE;

	private void GHILGLKLBDE()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.DKLMKBPEHAJ().animator.GetInteger("MainProgress") == 0)
			{
				JHIFLALPEBF.NOJMFFFDAJA().SetInt("Complete order", MOKLKLNAJEP);
				JHIFLALPEBF.DKLMKBPEHAJ().SetTrigger("BarnTutorialDone");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.PABOGCMHLAN().SetInt("UISelectGamepad", 0);
				LDLCLOBFLJH();
			}
		}
	}

	private void HEIINNLADDB()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)24);
		}
	}

	private void IOCBOKALELP()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.BFBEDHOHEPH().animator.GetInteger("lightInEditorEnabled in DayLight checkbox enabled. Remember to disable") == 0)
			{
				JHIFLALPEBF.BKPDJIDCAEO().SetInt("</color>\nRuta absoluta: ", MOKLKLNAJEP);
				JHIFLALPEBF.DCMNEPOPBKA().SetTrigger("Drink");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.PAMGMEAHNCI().SetInt("Arguing", 0, HALNIEBONKH: true);
				PBADOMLIEJK();
			}
		}
	}

	private void FHEOAAHPCAL()
	{
		MOKLKLNAJEP = Random.Range(0, 0);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1069f, 836f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(1873f, 1964f);
		}
		else
		{
			DPAHMOPBLIE = 1035f;
		}
	}

	private void FIABGKLEDAA()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.OLHBCAHONME().animator.GetInteger("City/Petra/Stand") == 0)
			{
				JHIFLALPEBF.GHNLDKEOCFA().SetInt(" ", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.BIFKPMIMAEC().SetTrigger("Bouncer/");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.OHKDOEFGKFA().SetInt("Quests", 0);
				OMGNLMIEAOC();
			}
		}
	}

	private void KBCKFDDDEGE()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.AJCPFEMEHNF().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		HOFJGKGFJPH();
	}

	private void PHPGDCBOHCJ()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)8)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-101), KCNFNAICINO: false);
		}
	}

	private void DDAPINAIBPO()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.DKLMKBPEHAJ().animator.GetInteger("Items/item_name_1181") == 0)
			{
				JHIFLALPEBF.NDPNCJAOGNL().SetInt("CheckIfNewActivity ", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.DKMPEPHLBGI().SetTrigger("Failed to sign in for reason ", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.GDDFKLAEACF().SetInt("VerticalMove", 0, HALNIEBONKH: true);
				EKCBGODFMBL();
			}
		}
	}

	private void ABNCOFNDGHH()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(276f, 252f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.KBGPJKHJBMP(PJNGMCJIHME);
	}

	private void FFGILHAFMKE()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(639f, 1935f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.KBGPJKHJBMP(PJNGMCJIHME);
	}

	private void IGJIBHKEEFK()
	{
		MOKLKLNAJEP = Random.Range(1, 0);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(584f, 890f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 5)
		{
			DPAHMOPBLIE = Random.Range(376f, 875f);
		}
		else
		{
			DPAHMOPBLIE = 704f;
		}
	}

	private void CIIAFGNACCO()
	{
		MOKLKLNAJEP = Random.Range(1, 8);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(907f, 523f);
		if (MOKLKLNAJEP == 3 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(1768f, 870f);
		}
		else
		{
			DPAHMOPBLIE = 308f;
		}
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		JHIFLALPEBF.walkTo.IIMEFNIECLI();
	}

	private void KLHOKCCMGCO()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-58));
		}
	}

	private void BEEDFJOOPAH()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.FEDJFNCCPDD().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		PBJFJOOOBGC();
	}

	private void GEAKPMEBBAI()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.KAIKMCMMHLL().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		DKBCGMILFJB();
	}

	private void FMNEKGGOLGP()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1019f, 674f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.EKDMCEKEHAO(PJNGMCJIHME);
	}

	public override int GetStateEnumID()
	{
		return 12;
	}

	private void FJNPFILECCM()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		FJIAJIFPBOH();
	}

	private void LDLCLOBFLJH()
	{
		MOKLKLNAJEP = Random.Range(1, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(529f, 1248f);
		if (MOKLKLNAJEP == 5 || MOKLKLNAJEP == 1)
		{
			DPAHMOPBLIE = Random.Range(942f, 783f);
		}
		else
		{
			DPAHMOPBLIE = 225f;
		}
	}

	private void IEJGDOPLBLB()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		FJIAJIFPBOH();
	}

	private void KHAELGDDELD()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.PAMGMEAHNCI().animator.GetInteger("Top") == 0)
			{
				JHIFLALPEBF.NDPNCJAOGNL().SetInt("Fishy", MOKLKLNAJEP);
				JHIFLALPEBF.DKMPEPHLBGI().SetTrigger("", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.CCFDNFDEGIK().SetInt("Disabled", 1);
				GEDAAFHOGJF();
			}
		}
	}

	private void DIHKIFGMKPB()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.OJGPNDMOPFA().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		FCBGAOFNEFF();
	}

	private void HPPBBFFIGHI()
	{
		MOKLKLNAJEP = Random.Range(0, 7);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1651f, 730f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 4)
		{
			DPAHMOPBLIE = Random.Range(1496f, 38f);
		}
		else
		{
			DPAHMOPBLIE = 1042f;
		}
	}

	private void IMOCKODKLKK()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1064f, 926f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.KBGPJKHJBMP(PJNGMCJIHME);
	}

	private void OCLKPFCGPNA()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1467f, 215f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.KHGNCDPLJFB(PJNGMCJIHME);
	}

	private void HOFJGKGFJPH()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1530f, 1529f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.OKMMNPLHLGJ(PJNGMCJIHME);
	}

	private void JMKNGACOGEC()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(399f, 1860f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.FLEAKKFGIOG(PJNGMCJIHME);
	}

	private void CKGFIHKADBM()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.KGMBAGFAEOC().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		FMNEKGGOLGP();
	}

	private void ININOGCFGAB()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1672f, 609f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.EKDMCEKEHAO(PJNGMCJIHME);
	}

	private void KLBNGHLIEFJ()
	{
		MOKLKLNAJEP = Random.Range(1, 6);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(921f, 937f);
		if (MOKLKLNAJEP == 1 || MOKLKLNAJEP == 4)
		{
			DPAHMOPBLIE = Random.Range(1332f, 1597f);
		}
		else
		{
			DPAHMOPBLIE = 840f;
		}
	}

	private void NPCNCAHKEEC()
	{
		MOKLKLNAJEP = Random.Range(1, 8);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(7f, 14f);
		if (MOKLKLNAJEP == 2 || MOKLKLNAJEP == 6)
		{
			DPAHMOPBLIE = Random.Range(4f, 8f);
		}
		else
		{
			DPAHMOPBLIE = 1f;
		}
	}

	private void BGPAOKGKHGN()
	{
		MOKLKLNAJEP = Random.Range(1, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1235f, 1247f);
		if (MOKLKLNAJEP == 5 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(1886f, 522f);
		}
		else
		{
			DPAHMOPBLIE = 361f;
		}
	}

	private void FJIAJIFPBOH()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1178f, 192f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.EKDMCEKEHAO(PJNGMCJIHME);
	}

	private void FOMOHLGGMFJ()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.DKMPEPHLBGI().animator.GetInteger("Social") == 0)
			{
				JHIFLALPEBF.BIFKPMIMAEC().SetInt("", MOKLKLNAJEP);
				JHIFLALPEBF.DKMPEPHLBGI().SetTrigger("Items/item_name_639");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.PAMGMEAHNCI().SetInt(" could not be removed because it does not exist", 0);
				KLBNGHLIEFJ();
			}
		}
	}

	private void KAAAHKMBIAL()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1615f, 793f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.KBGPJKHJBMP(PJNGMCJIHME);
	}

	private void EINCAALFHLM()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-40), KCNFNAICINO: false);
		}
	}

	private void AGCCDIKJKMO()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.GHNLDKEOCFA().animator.GetInteger("BanquetOrdersManager is not initialized.") == 0)
			{
				JHIFLALPEBF.PNGIDKBCGCK().SetInt("UI2", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.DKLMKBPEHAJ().SetTrigger("Destroying all animals");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.BFBEDHOHEPH().SetInt("popUpBuilding11", 0);
				NLBCDBANLCL();
			}
		}
	}

	private void LLGDMJEHJFK()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)5)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-126), KCNFNAICINO: false);
		}
	}

	private void NOHHPGHPNLH()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-113), KCNFNAICINO: false);
		}
	}

	private void JADBNFDKCKC()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != (NPCState)8)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)38, KCNFNAICINO: false);
		}
	}

	private void MJEBIPIAIEG()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.CGBPBCDLOCM().animator.GetInteger("NoEresDigno/KyrohTalks") == 0)
			{
				JHIFLALPEBF.LNJABLMFNNE().SetInt("itemBacon", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.OAHOFAKKBBA().SetTrigger("SetNPCParent", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.BFBEDHOHEPH().SetInt("Give", 0, HALNIEBONKH: true);
				KLBNGHLIEFJ();
			}
		}
	}

	private void CNIEDLKPGBK()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.KAIKMCMMHLL().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		KAAAHKMBIAL();
	}

	private void GGOMONLPNBD()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.LNJABLMFNNE().animator.GetInteger("<mark=#000000><alpha=#00> ") == 0)
			{
				JHIFLALPEBF.DKMPEPHLBGI().SetInt("[MinePuzzleManager] All puzzle types used across levels. Resetting used list for level {0}.", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.DKLMKBPEHAJ().SetTrigger("Player2", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.KOIKANGEOFD().SetInt("Perks/perk_description_", 1);
				KIFNICDMFAA();
			}
		}
	}

	[CompilerGenerated]
	private void HBCCALLAOFD()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingForBarSpot);
		}
	}

	private void BEGJHBGMPCD()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.GDDFKLAEACF().animator.GetInteger("Grab") == 0)
			{
				JHIFLALPEBF.EPLLKPJIAFF().SetInt("Interact", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.LNJABLMFNNE().SetTrigger("Hire", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.DHMMHOPEMLF().SetInt("meatDishes", 0, HALNIEBONKH: true);
				HBJDJGPEMLK();
			}
		}
	}

	private void HACNKBFKNHH()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.AJCPFEMEHNF().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		FOHCLIJLDOO();
	}

	private void KIFNICDMFAA()
	{
		MOKLKLNAJEP = Random.Range(1, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1032f, 464f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(41f, 893f);
		}
		else
		{
			DPAHMOPBLIE = 871f;
		}
	}

	private void PGLCNPIOOJN()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)3)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-50), KCNFNAICINO: false);
		}
	}

	private void CNJOADLENGP()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.GetPlaceable().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		HOFJGKGFJPH();
	}

	private void OBGLHBFDACO()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		LMIOGKAHHFM();
	}

	private void KNGKEAPDNLP()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.GetPlaceable().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		LFJPJEJAIPK();
	}

	private void ADJGBCOLFAO()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)5)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-35), KCNFNAICINO: false);
		}
	}

	private void IEHHAAACOFB()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.IMGOIBOHCIK().animator.GetInteger("[MinePuzzleManager] No MinePuzzleBase found for type {0}.") == 0)
			{
				JHIFLALPEBF.DHMMHOPEMLF().SetInt(":</color> ", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.FNGPCELFEHO().SetTrigger("Player2", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.PABOGCMHLAN().SetInt("Items/item_description_1116", 1, HALNIEBONKH: true);
				BKMCMPCECFD();
			}
		}
	}

	private void DNEJLOIDPKF()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1574f, 584f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.CKPKLEDCDFO(PJNGMCJIHME);
	}

	private void GBNHFIJDMPB()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-7));
		}
	}

	private void LODNIOGLMDC()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.KGMBAGFAEOC().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		FJIAJIFPBOH();
	}

	private void DGMIJKFEDHJ()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.IMGOIBOHCIK().animator.GetInteger("Multiplayer") == 0)
			{
				JHIFLALPEBF.BIFKPMIMAEC().SetInt("Walk", MOKLKLNAJEP);
				JHIFLALPEBF.JEFADBEHABI().SetTrigger("PopUpGen error: ", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.BMCNJOEAJBH().SetInt("Could not check user signed in status for reason ", 1, HALNIEBONKH: true);
				GHBNOEJMGPL();
			}
		}
	}

	private void CPKPKPGNLEO()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.GetPlaceable().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		LFJPJEJAIPK();
	}

	private void DGGCPMEDMPF()
	{
		MOKLKLNAJEP = Random.Range(0, 7);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(118f, 557f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 0)
		{
			DPAHMOPBLIE = Random.Range(1696f, 1236f);
		}
		else
		{
			DPAHMOPBLIE = 686f;
		}
	}

	private void HBJDJGPEMLK()
	{
		MOKLKLNAJEP = Random.Range(1, 3);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(621f, 1498f);
		if (MOKLKLNAJEP == 4 || MOKLKLNAJEP == 1)
		{
			DPAHMOPBLIE = Random.Range(230f, 322f);
		}
		else
		{
			DPAHMOPBLIE = 1265f;
		}
	}

	private void GFLNGGGPGCF()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		FCNEIPMJHIF();
	}

	private void DFIJPGBFBHL()
	{
		MOKLKLNAJEP = Random.Range(0, 7);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(765f, 28f);
		if (MOKLKLNAJEP == 8 || MOKLKLNAJEP == 5)
		{
			DPAHMOPBLIE = Random.Range(1441f, 1963f);
		}
		else
		{
			DPAHMOPBLIE = 1f;
		}
	}

	private void MJBDDKNMDAH()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)106, KCNFNAICINO: false);
		}
	}

	private void CMJOOLGAKON()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.BMCNJOEAJBH().animator.GetInteger("Last") == 0)
			{
				JHIFLALPEBF.NOJMFFFDAJA().SetInt(" state", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.APBNLDNECGJ().SetTrigger("BarIdle");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.OLHBCAHONME().SetInt("add item ", 0, HALNIEBONKH: true);
				PBADOMLIEJK();
			}
		}
	}

	private void KBLJPNHKJDL()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(-0.3f, 0.3f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.RequestRoom(PJNGMCJIHME);
	}

	private void IPAMBDDEKNA()
	{
		MOKLKLNAJEP = Random.Range(0, 1);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1651f, 1888f);
		if (MOKLKLNAJEP == 3 || MOKLKLNAJEP == 0)
		{
			DPAHMOPBLIE = Random.Range(874f, 616f);
		}
		else
		{
			DPAHMOPBLIE = 170f;
		}
	}

	private void FMONIDGJANG()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.GetPlaceable().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		FOHCLIJLDOO();
	}

	private void OICMKLPNBHL()
	{
		MOKLKLNAJEP = Random.Range(1, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1244f, 610f);
		if (MOKLKLNAJEP == 5 || MOKLKLNAJEP == 5)
		{
			DPAHMOPBLIE = Random.Range(778f, 785f);
		}
		else
		{
			DPAHMOPBLIE = 1914f;
		}
	}

	private void EJPFGEHOKPK()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.KGMBAGFAEOC().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		FBMPEONJAGK();
	}

	private void CLOEFOFKDFC()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KAIKMCMMHLL().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.GetPlaceable().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		}
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		FOHCLIJLDOO();
	}

	private void BOMFHMEFPNO()
	{
		MOKLKLNAJEP = Random.Range(1, 8);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(470f, 1969f);
		if (MOKLKLNAJEP == 0 || MOKLKLNAJEP == 7)
		{
			DPAHMOPBLIE = Random.Range(1745f, 577f);
		}
		else
		{
			DPAHMOPBLIE = 806f;
		}
	}

	private void BKMCMPCECFD()
	{
		MOKLKLNAJEP = Random.Range(0, 7);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(383f, 187f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 2)
		{
			DPAHMOPBLIE = Random.Range(985f, 809f);
		}
		else
		{
			DPAHMOPBLIE = 1975f;
		}
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		JHIFLALPEBF.FJHKGBNBNKL.SetInt("BarIdleNumber", 0);
		JHIFLALPEBF.FJHKGBNBNKL.SetTrigger("Stand");
		RoomReceptionDesk.DereserveSpot();
		PJNGMCJIHME.requestingRoom = false;
		RoomReceptionDesk.instance.SetNegotiateRoom(AODONKKHPBP: false);
	}

	private void JDGDHHPPDNI()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.DKMPEPHLBGI().animator.GetInteger(" FixedState().") == 0)
			{
				JHIFLALPEBF.CFIFGDBGLPH().SetInt(")\n", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.JHOGIKCHCGG().SetTrigger("BathhouseGame/Talk");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.CCFDNFDEGIK().SetInt(", ", 1);
				BOMFHMEFPNO();
			}
		}
	}

	private void OKGIPEBGFCF()
	{
		MOKLKLNAJEP = Random.Range(0, 3);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1260f, 450f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 4)
		{
			DPAHMOPBLIE = Random.Range(1437f, 684f);
		}
		else
		{
			DPAHMOPBLIE = 459f;
		}
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		base.UpdateState(GDHCBGCIIKG);
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
	}

	private void ODEFMFNCNAF()
	{
		MOKLKLNAJEP = Random.Range(1, 4);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1116f, 1306f);
		if (MOKLKLNAJEP == 8 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(251f, 157f);
		}
		else
		{
			DPAHMOPBLIE = 1402f;
		}
	}

	private void NLBCDBANLCL()
	{
		MOKLKLNAJEP = Random.Range(0, 1);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(694f, 897f);
		if (MOKLKLNAJEP == 0 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(1404f, 556f);
		}
		else
		{
			DPAHMOPBLIE = 877f;
		}
	}

	private void GEDAAFHOGJF()
	{
		MOKLKLNAJEP = Random.Range(1, 4);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1833f, 1719f);
		if (MOKLKLNAJEP == 1 || MOKLKLNAJEP == 6)
		{
			DPAHMOPBLIE = Random.Range(1152f, 763f);
		}
		else
		{
			DPAHMOPBLIE = 284f;
		}
	}

	private void KINIFOCAHIO()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-123));
		}
	}

	private void AJJIICECMDO()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.KAIKMCMMHLL().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		IMOCKODKLKK();
	}

	private void FGMDOGCPLCC()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)62, KCNFNAICINO: false);
		}
	}

	private void BKNBKDKIDNJ()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.OJGPNDMOPFA().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		FBEKCFEJLLB();
	}

	private void CFFKBDFCMGF()
	{
		MOKLKLNAJEP = Random.Range(0, 7);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(488f, 1642f);
		if (MOKLKLNAJEP == 5 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(1347f, 513f);
		}
		else
		{
			DPAHMOPBLIE = 232f;
		}
	}

	private void IIEGDHJEEKC()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		FCBGAOFNEFF();
	}

	private void LJAOLACPMIB()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.JEFADBEHABI().animator.GetInteger("Idle") == 0)
			{
				JHIFLALPEBF.DKLMKBPEHAJ().SetInt("FindSeat", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.OHKDOEFGKFA().SetTrigger("UIInteract", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.IMGOIBOHCIK().SetInt("NotValid", 1, HALNIEBONKH: true);
				CFFKBDFCMGF();
			}
		}
	}

	private void OELMAICAJBA()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.LNJABLMFNNE().animator.GetInteger("Inventory full") == 0)
			{
				JHIFLALPEBF.PABOGCMHLAN().SetInt("ReceiveLevelPoints", MOKLKLNAJEP);
				JHIFLALPEBF.BKPDJIDCAEO().SetTrigger("City/PetShop/Nessy/PerritosAbandonados");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.GDDFKLAEACF().SetInt("Festín del Juramento/PresentacionMaestros 01", 0, HALNIEBONKH: true);
				OKGIPEBGFCF();
			}
		}
	}

	private void GDFMEPCPDHK()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.IBGCFFIFPBL().animator.GetInteger("ReceiveStopPlayingChallenge") == 0)
			{
				JHIFLALPEBF.IBGCFFIFPBL().SetInt("popUpBuilding17", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.OJELDLIEDNI().SetTrigger("travelling time -", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.DHMMHOPEMLF().SetInt("Selected", 1, HALNIEBONKH: true);
				EKCBGODFMBL();
			}
		}
	}

	private void HGFNPEIMDIM()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.CCFDNFDEGIK().animator.GetInteger("Press {0} to continue") == 0)
			{
				JHIFLALPEBF.GHNLDKEOCFA().SetInt("LoopVolume", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.BFBEDHOHEPH().SetTrigger("force intro");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.APBNLDNECGJ().SetInt("South", 0);
				IPAMBDDEKNA();
			}
		}
	}

	private void OAFBOCBJHKH()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != (NPCState)5)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)26, KCNFNAICINO: false);
		}
	}

	private void JAIPNOEMIEO()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.BKPDJIDCAEO().animator.GetInteger("PirateMinigame/Lose2") == 0)
			{
				JHIFLALPEBF.DKLMKBPEHAJ().SetInt("DisableNPC", MOKLKLNAJEP);
				JHIFLALPEBF.DCMNEPOPBKA().SetTrigger("Items/item_name_666");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.PAMGMEAHNCI().SetInt("\n</color>", 1, HALNIEBONKH: true);
				IPAMBDDEKNA();
			}
		}
	}

	private void HEGOGBCKLFN()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-26));
		}
	}

	private void NGKAOPBAFEL()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)46, KCNFNAICINO: false);
		}
	}

	private void OHLEADOJEAE()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-51));
		}
	}

	private void PBJFJOOOBGC()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1736f, 296f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.OKMMNPLHLGJ(PJNGMCJIHME);
	}

	private void ACCHPCNIIPP()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != (NPCState)3)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-55));
		}
	}

	private void OMGNLMIEAOC()
	{
		MOKLKLNAJEP = Random.Range(1, 0);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1338f, 1699f);
		if (MOKLKLNAJEP == 1 || MOKLKLNAJEP == 1)
		{
			DPAHMOPBLIE = Random.Range(712f, 872f);
		}
		else
		{
			DPAHMOPBLIE = 644f;
		}
	}

	private void GPDFGHLOLKA()
	{
		MOKLKLNAJEP = Random.Range(1, 6);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1039f, 973f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(203f, 534f);
		}
		else
		{
			DPAHMOPBLIE = 199f;
		}
	}

	private void IGJBOCJNLHB()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.KAIKMCMMHLL().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		}
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		IMOCKODKLKK();
	}

	private void EKCBGODFMBL()
	{
		MOKLKLNAJEP = Random.Range(0, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1386f, 423f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(1999f, 885f);
		}
		else
		{
			DPAHMOPBLIE = 1419f;
		}
	}

	private void ABMMONFHFGF()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		JMKNGACOGEC();
	}

	private void LFJPJEJAIPK()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(536f, 1324f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.RequestRoom(PJNGMCJIHME);
	}

	private void PFCOMFEHBKN()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)113);
		}
	}

	private void DOMMOCIEKNP()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-127), KCNFNAICINO: false);
		}
	}

	private void EAKELBPIHMA()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != (NPCState)3)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-69), KCNFNAICINO: false);
		}
	}

	private void CAJJELMJNAA()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)104);
		}
	}

	private void FBMPEONJAGK()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1120f, 1279f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.FFGILHAFMKE(PJNGMCJIHME);
	}

	private void KAMPMOCKADM()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.DCMNEPOPBKA().animator.GetInteger("Items/item_name_1230") == 0)
			{
				JHIFLALPEBF.DKLMKBPEHAJ().SetInt("[", MOKLKLNAJEP);
				JHIFLALPEBF.BFBEDHOHEPH().SetTrigger("FishCuttingEvent/Talk2");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.CFIFGDBGLPH().SetInt("MainProgress", 1, HALNIEBONKH: true);
				AHMIPAOHKPA();
			}
		}
	}

	private void PKCODIDOBJO()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.AJCPFEMEHNF().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		FCNEIPMJHIF();
	}

	private void HAHLCBCBHNE()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)96, KCNFNAICINO: false);
		}
	}

	private void BHHIKGOHIKG()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.JEFADBEHABI().animator.GetInteger("00") == 0)
			{
				JHIFLALPEBF.JHOGIKCHCGG().SetInt("xpModDescCleaning", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.DKMPEPHLBGI().SetTrigger("CraftingRoomTiles");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.OLHBCAHONME().SetInt("stormy", 0, HALNIEBONKH: true);
				BKMCMPCECFD();
			}
		}
	}

	private void GLEHCFOJEGH()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.EPLLKPJIAFF().animator.GetInteger("DisableNPC") == 0)
			{
				JHIFLALPEBF.GHNLDKEOCFA().SetInt(" state: ", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.DKLMKBPEHAJ().SetTrigger("itemButter", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.LNJABLMFNNE().SetInt("El componente ItemSetup del rotatedPrefab '", 1, HALNIEBONKH: true);
				PBADOMLIEJK();
			}
		}
	}

	private void KNNALICIDEN()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KAIKMCMMHLL().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.EJEECOMAMBP().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		FOHCLIJLDOO();
	}

	private void AHMIPAOHKPA()
	{
		MOKLKLNAJEP = Random.Range(0, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(228f, 1370f);
		if (MOKLKLNAJEP == 2 || MOKLKLNAJEP == 7)
		{
			DPAHMOPBLIE = Random.Range(540f, 803f);
		}
		else
		{
			DPAHMOPBLIE = 360f;
		}
	}

	private void PBADOMLIEJK()
	{
		MOKLKLNAJEP = Random.Range(0, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1762f, 1553f);
		if (MOKLKLNAJEP == 1 || MOKLKLNAJEP == 7)
		{
			DPAHMOPBLIE = Random.Range(12f, 1108f);
		}
		else
		{
			DPAHMOPBLIE = 1149f;
		}
	}

	private void FOHCLIJLDOO()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1555f, 1609f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.KBGPJKHJBMP(PJNGMCJIHME);
	}

	private void CJEKIAKEOOF()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.OAHOFAKKBBA().animator.GetInteger("TavernVision") == 0)
			{
				JHIFLALPEBF.BIFKPMIMAEC().SetInt("\">", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.GDDFKLAEACF().SetTrigger("Kicks the corresponding player from the game. Kicked players can rejoin if you do not lock the game.");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.FNGPCELFEHO().SetInt("Items/item_description_1117", 0);
				BGPAOKGKHGN();
			}
		}
	}

	private void FCNEIPMJHIF()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1154f, 1684f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.RequestRoom(PJNGMCJIHME);
	}

	private void FCBGAOFNEFF()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1783f, 188f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.FLEAKKFGIOG(PJNGMCJIHME);
	}

	private void IKJDEPKEGLE()
	{
		MOKLKLNAJEP = Random.Range(0, 0);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(92f, 724f);
		if (MOKLKLNAJEP == 4 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(96f, 1512f);
		}
		else
		{
			DPAHMOPBLIE = 1793f;
		}
	}

	private void FBEKCFEJLLB()
	{
		CommonReferences.MNFMOEKMJKN().OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(205f, 326f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.CKPKLEDCDFO(PJNGMCJIHME);
	}

	private void FNKIODOAHPN()
	{
		if (!RoomReceptionDesk.NNCFEBHLIBO())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.OJGPNDMOPFA().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.KGMBAGFAEOC().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		KBLJPNHKJDL();
	}

	private void NJAHKMEELFP()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.CCFDNFDEGIK().animator.GetInteger("Mai/LearnBalance") == 0)
			{
				JHIFLALPEBF.DCMNEPOPBKA().SetInt("Disabled", MOKLKLNAJEP, HALNIEBONKH: true);
				JHIFLALPEBF.IMGOIBOHCIK().SetTrigger("LE_21", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.BFBEDHOHEPH().SetInt(" ", 1, HALNIEBONKH: true);
				EKCBGODFMBL();
			}
		}
	}

	private void FNJODLOADKA()
	{
		if (!RoomReceptionDesk.KLKDEMKNHNN())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.EJEECOMAMBP().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.KAIKMCMMHLL().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		FOHCLIJLDOO();
	}

	private void GHBNOEJMGPL()
	{
		MOKLKLNAJEP = Random.Range(0, 7);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1896f, 1978f);
		if (MOKLKLNAJEP == 8 || MOKLKLNAJEP == 2)
		{
			DPAHMOPBLIE = Random.Range(1637f, 1763f);
		}
		else
		{
			DPAHMOPBLIE = 1290f;
		}
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		BGELPKAELFA = Time.time + PJNGMCJIHME.customerInfo.requestRoomPatience;
		PJNGMCJIHME.customerType = CustomerType.Guest;
		PJNGMCJIHME.NGDAJGCPJEC = 1f;
		RoomReceptionDesk.ReserveSpot(PJNGMCJIHME);
		JHIFLALPEBF.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(RoomReceptionDesk.GetCustomerPositionTransform().position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			}
			if (JHIFLALPEBF.EOAONHNCDDO != NPCState.Sitting)
			{
				PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			}
			else
			{
				PJNGMCJIHME.ChangeState(CustomerState.WaitingForBarSpot);
			}
		});
		JHIFLALPEBF.walkTo.PEHELKCIECB();
	}

	private void BGAPLNMPBFP()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.KGMBAGFAEOC().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.FEDJFNCCPDD().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		KBLJPNHKJDL();
	}

	private void ELENCDPFGLJ()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
	}

	private void JNBHECPEPMA()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.DHMMHOPEMLF().animator.GetInteger("Dialogue System/Conversation/NeutralInTavern/Entry/19/Dialogue Text") == 0)
			{
				JHIFLALPEBF.NDPNCJAOGNL().SetInt("Toy", MOKLKLNAJEP);
				JHIFLALPEBF.DKLMKBPEHAJ().SetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/33/Dialogue Text");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.BIFKPMIMAEC().SetInt(" => ", 0, HALNIEBONKH: true);
				OKGIPEBGFCF();
			}
		}
	}

	private void GPGNLGKDGJO()
	{
		if (Time.time > BGELPKAELFA)
		{
			Customer pJNGMCJIHME = PJNGMCJIHME;
			pJNGMCJIHME.HGKKCKHDPJJ(pJNGMCJIHME.NGDAJGCPJEC - Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty);
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.BIFKPMIMAEC().animator.GetInteger("UIInteract") == 0)
			{
				JHIFLALPEBF.JEFADBEHABI().SetInt("ReceiveReduceDirtiness", MOKLKLNAJEP);
				JHIFLALPEBF.PABOGCMHLAN().SetTrigger("Honey", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.CFIFGDBGLPH().SetInt("\n<color=#822F00>", 1);
				EKCBGODFMBL();
			}
		}
	}

	private void HMJLJGAHDAM()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)19);
		}
	}

	private void EPKOMEBNAMG()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.FJHKGBNBNKL.animator.GetInteger("BarIdleNumber") == 0)
			{
				JHIFLALPEBF.FJHKGBNBNKL.SetInt("BarIdleNumber", MOKLKLNAJEP);
				JHIFLALPEBF.FJHKGBNBNKL.SetTrigger("BarIdle");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.FJHKGBNBNKL.SetInt("BarIdleNumber", 0);
				NPCNCAHKEEC();
			}
		}
	}

	private void LMIOGKAHHFM()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(1);
		PJNGMCJIHME.requestingRoom = true;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(1013f, 437f)), CDPAMNIPPEC: false);
		RoomReceptionDesk.CKPKLEDCDFO(PJNGMCJIHME);
	}

	private void GAJKLOGNKGF()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-70));
		}
	}

	private void IILMFJLEBCC()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.CCFDNFDEGIK().animator.GetInteger("\n") == 0)
			{
				JHIFLALPEBF.IBGCFFIFPBL().SetInt("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/20/Dialogue Text", MOKLKLNAJEP);
				JHIFLALPEBF.NDPNCJAOGNL().SetTrigger("Trying to add player but player list is full.");
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.BFBEDHOHEPH().SetInt("Halloween/Trick/Bark", 1, HALNIEBONKH: true);
				HPPBBFFIGHI();
			}
		}
	}

	private void CCJCBBJHLPA()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)3)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-20));
		}
	}

	private void DKBCGMILFJB()
	{
		CommonReferences.GGFJGHHHEJC.OnGuestRequestingRoom(0);
		PJNGMCJIHME.requestingRoom = false;
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.SetNewRoomRequest(new RoomRequest(PJNGMCJIHME, Random.Range(186f, 763f)), CDPAMNIPPEC: true);
		RoomReceptionDesk.FLEAKKFGIOG(PJNGMCJIHME);
	}

	private void LPCNGDBJBIC()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.DCMNEPOPBKA().animator.GetInteger("triggerPlayerNum") == 0)
			{
				JHIFLALPEBF.NOJMFFFDAJA().SetInt("", MOKLKLNAJEP);
				JHIFLALPEBF.DKMPEPHLBGI().SetTrigger("NoEresDigno/KyrohTalks", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.PABOGCMHLAN().SetInt("Creado blackmodule parent: ", 1);
				GEDAAFHOGJF();
			}
		}
	}

	private void IJEECEJLKPH()
	{
		if (Time.time > BGELPKAELFA)
		{
			PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.longTimeWaitingPenalty;
		}
		if (Time.time > BGELPKAELFA && Time.timeSinceLevelLoad >= NBIHJLMPPFF)
		{
			if (JHIFLALPEBF.CCFDNFDEGIK().animator.GetInteger("Could not check user signed in status for reason ") == 0)
			{
				JHIFLALPEBF.CCFDNFDEGIK().SetInt("Items/item_name_676", MOKLKLNAJEP);
				JHIFLALPEBF.OAHOFAKKBBA().SetTrigger("FishMiniGameWin", HALNIEBONKH: true);
				NBIHJLMPPFF = Time.timeSinceLevelLoad + DPAHMOPBLIE;
			}
			else
			{
				JHIFLALPEBF.PAMGMEAHNCI().SetInt("tutorialPopUp23", 1);
				IKJDEPKEGLE();
			}
		}
	}

	private void JEPBPABEDGE()
	{
		if (!RoomReceptionDesk.FGPEEPCCFHK())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.FEDJFNCCPDD().direction))
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Utils.ABNPPDOGEPM(RoomReceptionDesk.FEDJFNCCPDD().direction));
		}
		else
		{
			PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		HOFJGKGFJPH();
	}

	private void PDOBHPLPKHG()
	{
		if (!RoomReceptionDesk.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		if (Utils.ABPDGOHBKIG(RoomReceptionDesk.GetPlaceable().direction))
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(RoomReceptionDesk.GetPlaceable().direction);
		}
		else
		{
			PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		KBLJPNHKJDL();
	}
}
