using System;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class CustomerStateAdoption : CustomerStateBase
{
	private float BGELPKAELFA;

	private int MOKLKLNAJEP;

	private float NBIHJLMPPFF;

	private float DPAHMOPBLIE;

	private void HJDBMFCAJHJ()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		PGKDDFPAOPM();
	}

	private void JMPLIPEMFBC()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void ENGHDGKLGMH()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void AKGILGHBFAL()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		JHIFLALPEBF.walkTo.IIMEFNIECLI();
	}

	private void CFKIFPOEBLO()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.RequestRoom);
		}
	}

	private void GPNCLGLPKIE()
	{
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void HILLNFIICFK()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		KLBJLHOADMB();
	}

	private void JNJHINPKBKJ()
	{
		MOKLKLNAJEP = Random.Range(0, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(149f, 39f);
		if (MOKLKLNAJEP == 2 || MOKLKLNAJEP == 1)
		{
			DPAHMOPBLIE = Random.Range(1313f, 875f);
		}
		else
		{
			DPAHMOPBLIE = 1224f;
		}
	}

	private void HIBLPBMEDMG()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void AKFILCLMJNK()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void HKLICBAMELE()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void POBPKJDCLGB()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	public override int GetStateEnumID()
	{
		return 14;
	}

	private void JOIAJOAEHGP()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != (NPCState)8)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
	}

	private void HOMABHHHGHA()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)19);
		}
	}

	private void IPAMBDDEKNA()
	{
		MOKLKLNAJEP = Random.Range(0, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(281f, 802f);
		if (MOKLKLNAJEP == 8 || MOKLKLNAJEP == 2)
		{
			DPAHMOPBLIE = Random.Range(1610f, 491f);
		}
		else
		{
			DPAHMOPBLIE = 81f;
		}
	}

	private void AHPFECCLOBB()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		DLAMJMKIDAI();
	}

	private void DCAMFDCHLNE()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)26, KCNFNAICINO: false);
		}
	}

	private void OGBEGBJDNKJ()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		ODHIHPILICE();
	}

	private void FOEBEJHKEKE()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		JDIDHADPCBC();
	}

	private void DMJNLLFEJEB()
	{
		MOKLKLNAJEP = Random.Range(1, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1410f, 620f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 2)
		{
			DPAHMOPBLIE = Random.Range(1300f, 547f);
		}
		else
		{
			DPAHMOPBLIE = 1473f;
		}
	}

	private void OKJGAFMEKJI()
	{
		MOKLKLNAJEP = Random.Range(1, 3);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(83f, 1463f);
		if (MOKLKLNAJEP == 8 || MOKLKLNAJEP == 6)
		{
			DPAHMOPBLIE = Random.Range(169f, 1332f);
		}
		else
		{
			DPAHMOPBLIE = 1679f;
		}
	}

	private void OBGLHBFDACO()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		JFIPMMAACIO();
	}

	private void MADNDCOMODB()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void HACNKBFKNHH()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		GALGAFCFAIK();
	}

	private void EAOKHKCHKJC()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-50));
		}
	}

	private void ABMMONFHFGF()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		HIBLPBMEDMG();
	}

	private void CBNDCCIIMPP()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		JHIFLALPEBF.FJHKGBNBNKL.SetInt("BarIdleNumber", 0);
		JHIFLALPEBF.FJHKGBNBNKL.SetTrigger("Stand");
		AdoptionSignal.DereserveSpot();
	}

	private void KLBJLHOADMB()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void EIAFACOJHKD()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-87));
		}
	}

	private void BJJFGPHCPFE()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void OJKEAOEBCOB()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void DEEDLMJMFLL()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void EINCAALFHLM()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)23, KCNFNAICINO: false);
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

	private void ALDAHNKKOGE()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		HNNLNPIPEGK();
	}

	private void CKGOOBGJFKG()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		if (JHIFLALPEBF.LLNABOMIIOM() != 0)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-17), KCNFNAICINO: false);
		}
	}

	private void PMIOPAFPEOH()
	{
		MOKLKLNAJEP = Random.Range(0, 8);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1701f, 10f);
		if (MOKLKLNAJEP == 1 || MOKLKLNAJEP == 4)
		{
			DPAHMOPBLIE = Random.Range(812f, 1569f);
		}
		else
		{
			DPAHMOPBLIE = 488f;
		}
	}

	private void KCCNMJLJGPD()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)114, KCNFNAICINO: false);
		}
	}

	private void FOCFLKEJJLE()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void CCJCBBJHLPA()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)6)
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-31), KCNFNAICINO: false);
		}
	}

	private void IKOIKCHBBNG()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		AAEENFLPFMN();
	}

	private void GIKDOPHDOEH()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void IIMJHEMNOLM()
	{
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void GMCINBCEPJO()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		JMPLIPEMFBC();
	}

	private void PGKDDFPAOPM()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void CKGFIHKADBM()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		PLFFOCGAHIN();
	}

	private void HMELBFHBDKF()
	{
		MOKLKLNAJEP = Random.Range(1, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1982f, 699f);
		if (MOKLKLNAJEP == 5 || MOKLKLNAJEP == 6)
		{
			DPAHMOPBLIE = Random.Range(1318f, 1704f);
		}
		else
		{
			DPAHMOPBLIE = 838f;
		}
	}

	private void DJDGHCIFAKE()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void JFIPMMAACIO()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void IEJGDOPLBLB()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		DLKLKAELGLF();
	}

	private void AAEENFLPFMN()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void ODFIDIKFIJP()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void FONOEMJKBGA()
	{
		MOKLKLNAJEP = Random.Range(1, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1316f, 885f);
		if (MOKLKLNAJEP == 4 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(188f, 1310f);
		}
		else
		{
			DPAHMOPBLIE = 554f;
		}
	}

	private void IKABHLBGNBE()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		JFIPMMAACIO();
	}

	private void NHCAPCCBNAL()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		AAEENFLPFMN();
	}

	private void GPEKGEFNIIO()
	{
		MOKLKLNAJEP = Random.Range(1, 1);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(751f, 1811f);
		if (MOKLKLNAJEP == 4 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(1062f, 843f);
		}
		else
		{
			DPAHMOPBLIE = 365f;
		}
	}

	private void GALGAFCFAIK()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void LOEOOBFNDIN()
	{
		MOKLKLNAJEP = Random.Range(0, 1);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(413f, 697f);
		if (MOKLKLNAJEP == 5 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(892f, 348f);
		}
		else
		{
			DPAHMOPBLIE = 376f;
		}
	}

	private void INALLGBPHFJ()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)18, KCNFNAICINO: false);
		}
	}

	private void ODHIHPILICE()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void NPODAKPGDAP()
	{
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void OMKBAIKNEFP()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void GFLNGGGPGCF()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		HIJAKMABDIO();
	}

	private void LLMMFPBNBCH()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void HIJAKMABDIO()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void AODBKPKJEBA()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)6)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)127, KCNFNAICINO: false);
		}
	}

	private void ELJDPLIHJHN()
	{
		MOKLKLNAJEP = Random.Range(1, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1585f, 1328f);
		if (MOKLKLNAJEP == 2 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(1840f, 1198f);
		}
		else
		{
			DPAHMOPBLIE = 1631f;
		}
	}

	private void BPDIPFFEMNI()
	{
		MOKLKLNAJEP = Random.Range(1, 6);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1441f, 1718f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 2)
		{
			DPAHMOPBLIE = Random.Range(1339f, 1111f);
		}
		else
		{
			DPAHMOPBLIE = 648f;
		}
	}

	private void PLFFOCGAHIN()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void DLKLKAELGLF()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void CEIKBLGMJPK()
	{
		MOKLKLNAJEP = Random.Range(0, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1602f, 1938f);
		if (MOKLKLNAJEP == 5 || MOKLKLNAJEP == 7)
		{
			DPAHMOPBLIE = Random.Range(775f, 1892f);
		}
		else
		{
			DPAHMOPBLIE = 840f;
		}
	}

	private void CJLMPJIHBOJ()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void PDOBHPLPKHG()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		AKFILCLMJNK();
	}

	private void JLJODNAEANE()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-24), KCNFNAICINO: false);
		}
	}

	private void FJNPFILECCM()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		PGKDDFPAOPM();
	}

	private void IHEGBEOCIKH()
	{
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void OPPLKANBCPA()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)6)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)53);
		}
	}

	private void OKHDMEMEIEJ()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		AKFILCLMJNK();
	}

	private void MBFJBIFCDEI()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void ACFDDOELPKN()
	{
		MOKLKLNAJEP = Random.Range(1, 1);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(895f, 397f);
		if (MOKLKLNAJEP == 0 || MOKLKLNAJEP == 2)
		{
			DPAHMOPBLIE = Random.Range(992f, 223f);
		}
		else
		{
			DPAHMOPBLIE = 311f;
		}
	}

	private void KDBHFJEHKMA()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)66);
		}
	}

	private void OJOJGBLAPBB()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		HKLICBAMELE();
	}

	private void NBBNLPCAOGK()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		}
		if (JHIFLALPEBF.DJAFGOHMNBK() != NPCState.Sitting)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-49));
		}
	}

	private void JDIDHADPCBC()
	{
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
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

	private void NFJMICLBNNL()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-27));
		}
	}

	private void DGGCPMEDMPF()
	{
		MOKLKLNAJEP = Random.Range(1, 6);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(668f, 254f);
		if (MOKLKLNAJEP == 0 || MOKLKLNAJEP == 4)
		{
			DPAHMOPBLIE = Random.Range(1607f, 779f);
		}
		else
		{
			DPAHMOPBLIE = 357f;
		}
	}

	private void KAHODFJEHPA()
	{
		MOKLKLNAJEP = Random.Range(1, 1);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1273f, 1749f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 0)
		{
			DPAHMOPBLIE = Random.Range(590f, 257f);
		}
		else
		{
			DPAHMOPBLIE = 626f;
		}
	}

	private void EJGGKAOEJEP()
	{
		MOKLKLNAJEP = Random.Range(1, 6);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(777f, 1969f);
		if (MOKLKLNAJEP == 8 || MOKLKLNAJEP == 8)
		{
			DPAHMOPBLIE = Random.Range(681f, 1188f);
		}
		else
		{
			DPAHMOPBLIE = 171f;
		}
	}

	private void GIGMBFBENFJ()
	{
		MOKLKLNAJEP = Random.Range(0, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(233f, 1697f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 0)
		{
			DPAHMOPBLIE = Random.Range(1930f, 1504f);
		}
		else
		{
			DPAHMOPBLIE = 441f;
		}
	}

	private void BPIINBDAPJL()
	{
		MOKLKLNAJEP = Random.Range(0, 3);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(399f, 1737f);
		if (MOKLKLNAJEP == 0 || MOKLKLNAJEP == 4)
		{
			DPAHMOPBLIE = Random.Range(302f, 911f);
		}
		else
		{
			DPAHMOPBLIE = 527f;
		}
	}

	private void FMONIDGJANG()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Down);
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		POBPKJDCLGB();
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		base.UpdateState(GDHCBGCIIKG);
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		}
	}

	private void GBDLGKNDBIK()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		DJDGHCIFAKE();
	}

	private void HPDBOIGJDMD()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != NPCState.Standing)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-29), KCNFNAICINO: false);
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
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		BGELPKAELFA = Time.time + PJNGMCJIHME.customerInfo.requestRoomPatience;
		PJNGMCJIHME.customerType = CustomerType.Traveller;
		PJNGMCJIHME.NGDAJGCPJEC = 1f;
		AdoptionSignal.ReserveSpot(PJNGMCJIHME);
		JHIFLALPEBF.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(AdoptionSignal.GetCustomerPositionTransform().position), AHDHLIECIGH: false);
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

	private void IPHMPMHMFMB()
	{
		MOKLKLNAJEP = Random.Range(1, 2);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1285f, 1144f);
		if (MOKLKLNAJEP == 8 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(79f, 1433f);
		}
		else
		{
			DPAHMOPBLIE = 886f;
		}
	}

	private void MIECEICLDII()
	{
		MOKLKLNAJEP = Random.Range(1, 5);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(544f, 36f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 2)
		{
			DPAHMOPBLIE = Random.Range(1552f, 1676f);
		}
		else
		{
			DPAHMOPBLIE = 1742f;
		}
	}

	private void BNOPPMEIHAN()
	{
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void JFKPPBCBIIB()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.DLLLCEOKMBH() != (NPCState)5)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-54));
		}
	}

	private void EGGJOKBJFNJ()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void IKJCMHLDEFL()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)4)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-30));
		}
	}

	private void IPKFEPKJIJE()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		POBPKJDCLGB();
	}

	private void ANJCJEHIGCA()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		NKDCMOKKDOI();
	}

	private void DLAMJMKIDAI()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void OEEBBCBHHGH()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void JCHPJKLJMOO()
	{
		MOKLKLNAJEP = Random.Range(1, 8);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(87f, 1433f);
		if (MOKLKLNAJEP == 6 || MOKLKLNAJEP == 0)
		{
			DPAHMOPBLIE = Random.Range(1798f, 1779f);
		}
		else
		{
			DPAHMOPBLIE = 518f;
		}
	}

	private void MABAJJMOFMF()
	{
		MOKLKLNAJEP = Random.Range(0, 8);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(721f, 309f);
		if (MOKLKLNAJEP == 7 || MOKLKLNAJEP == 5)
		{
			DPAHMOPBLIE = Random.Range(1363f, 1196f);
		}
		else
		{
			DPAHMOPBLIE = 69f;
		}
	}

	private void KIMEBNLKFBK()
	{
		if (!AdoptionSignal.IsValid())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Despawning);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		}
		HIBLPBMEDMG();
	}

	private void HNNLNPIPEGK()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void NKDCMOKKDOI()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
		AdoptionSignal.RequestAdoption(PJNGMCJIHME);
	}

	private void BHELEAIBPAH()
	{
		if (!AdoptionSignal.ICPPNLMIIEC())
		{
			PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (PJNGMCJIHME.currentMoodState != 0)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		}
		OJKEAOEBCOB();
	}

	private void IHHAHAIIFJB()
	{
		MOKLKLNAJEP = Random.Range(1, 6);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1237f, 74f);
		if (MOKLKLNAJEP == 4 || MOKLKLNAJEP == 3)
		{
			DPAHMOPBLIE = Random.Range(212f, 1236f);
		}
		else
		{
			DPAHMOPBLIE = 874f;
		}
	}

	private void KINIFOCAHIO()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar);
		}
		if (JHIFLALPEBF.PBLBPGPJFHI() != (NPCState)6)
		{
			PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-37), KCNFNAICINO: false);
		}
	}

	private void OJFILNACKCG()
	{
		MOKLKLNAJEP = Random.Range(0, 8);
		NBIHJLMPPFF = Time.timeSinceLevelLoad + Random.Range(1204f, 1023f);
		if (MOKLKLNAJEP == 3 || MOKLKLNAJEP == 7)
		{
			DPAHMOPBLIE = Random.Range(1120f, 1725f);
		}
		else
		{
			DPAHMOPBLIE = 830f;
		}
	}

	private void FGMDOGCPLCC()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG() || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		}
		if (JHIFLALPEBF.EOAONHNCDDO != (NPCState)7)
		{
			PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		}
		else
		{
			PJNGMCJIHME.ChangeState((CustomerState)(-108));
		}
	}

	private void HEEOHKBPMAI()
	{
		if (!AdoptionSignal.BELCCHBEFKE())
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
			return;
		}
		PJNGMCJIHME.characterAnimation.NCAJNNHBHJM(Direction.Up);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		ODHIHPILICE();
	}
}
