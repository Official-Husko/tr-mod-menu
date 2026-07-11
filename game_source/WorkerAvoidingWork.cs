using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorkerAvoidingWork
{
	private Employee NAKCFGEAGHH;

	private float LHACKABKHDN;

	private float CEJBNJOENIF;

	public void HHPANGDONBN()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 420f;
				NAKCFGEAGHH.behaviour.SetTrigger("Player2");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.IIMEFNIECLI();
			}
		}
	}

	public void MDPBIFCFPPA()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.NMODEMLBJLF();
		}
		NAKCFGEAGHH.avoidingWorkPoint = false;
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
	}

	public void DHJOHHEMMFK()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 1545f;
				NAKCFGEAGHH.behaviour.SetTrigger("Deselect item");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.BODEPFFAHLE();
			}
		}
	}

	public void JDHKHKJOKFF()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 0f;
				NAKCFGEAGHH.behaviour.SetTrigger("Waiting");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.IIMEFNIECLI();
			}
		}
	}

	public void PMLHDLPJPDG()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 874f;
				NAKCFGEAGHH.behaviour.SetTrigger("Inicio");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.BODEPFFAHLE(OEBNHGNJEJL: true);
			}
		}
	}

	public void DNGEAILBLII()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.SendClientsEmployeeBackToWork();
		}
		NAKCFGEAGHH.avoidingWorkPoint = false;
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
	}

	private void AMHJGOPOMEE()
	{
		NAKCFGEAGHH.behaviour.SetTrigger("Replacing Button on gameObject: ");
	}

	public void AHPFECCLOBB()
	{
		NAKCFGEAGHH.characterAnimation.FCGBJEIIMBC = Direction.Down;
		NAKCFGEAGHH.avoidingWorkPoint = true;
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.LFLOIEAGABE();
		}
	}

	private void IIIFCANKMCF()
	{
		NAKCFGEAGHH.behaviour.SetTrigger("InfoSectionCanvas/InfoSection");
	}

	public void CKIBECJIAAE()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeAvoidingWork(0);
		NAKCFGEAGHH.avoidingWorkPoint = true;
		LHACKABKHDN = 1401f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(1, 84) < NAKCFGEAGHH.GetPerkValue(-20))
		{
			CEJBNJOENIF *= 184f;
		}
		NAKCFGEAGHH.OEONGPFALKH.KBEENHPEOAB(Vector2.op_Implicit(SceneReferences.CKDKHMPHENE().avoidWork.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDPPMODKCGH));
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NJJDPEPCHNM));
		NAKCFGEAGHH.OEONGPFALKH.EHDKLBLKBEO();
	}

	public void PDOBHPLPKHG()
	{
		NAKCFGEAGHH.characterAnimation.FCGBJEIIMBC = Direction.Down;
		NAKCFGEAGHH.avoidingWorkPoint = true;
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.SendAtAvoidingWorkPoint();
		}
	}

	public void LKKJMLDGCAK()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.JHPDAOBHAGI();
		}
		NAKCFGEAGHH.avoidingWorkPoint = false;
		CommonReferences.MNFMOEKMJKN().workerAvoidingWork = true;
	}

	public void NHAPCMDFIPH()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeAvoidingWork(1);
		NAKCFGEAGHH.avoidingWorkPoint = false;
		LHACKABKHDN = 1800f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(0, 66) < NAKCFGEAGHH.GetPerkValue(68))
		{
			CEJBNJOENIF *= 1148f;
		}
		NAKCFGEAGHH.OEONGPFALKH.GDGGABHLNOH(Vector2.op_Implicit(SceneReferences.FAOPFMBMMJJ().avoidWork.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDPPMODKCGH));
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IIIFCANKMCF));
		NAKCFGEAGHH.OEONGPFALKH.EHDKLBLKBEO();
	}

	public void EEPKGNNILBE()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 76f;
				NAKCFGEAGHH.behaviour.SetTrigger("Balance/MainEvent");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.IIMEFNIECLI(OEBNHGNJEJL: true);
			}
		}
	}

	public void EHBFECEJGCE()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 1097f;
				NAKCFGEAGHH.behaviour.SetTrigger("player2ToJoinGame");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.PLAGPJAKCKL(OEBNHGNJEJL: true);
			}
		}
	}

	public void MAGACCHLAOE()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 1832f;
				NAKCFGEAGHH.behaviour.SetTrigger("Masters/Klayn/Banquet");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.PAHDHACALOH(OEBNHGNJEJL: true);
			}
		}
	}

	public void LBMAPIJJMGL()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = true;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeAvoidingWork(1);
		NAKCFGEAGHH.avoidingWorkPoint = false;
		LHACKABKHDN = 0f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(0, 100) < NAKCFGEAGHH.GetPerkValue(74))
		{
			CEJBNJOENIF *= 2f;
		}
		NAKCFGEAGHH.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(SceneReferences.GetSceneReferences().avoidWork.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			PDOBHPLPKHG();
		});
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			NAKCFGEAGHH.behaviour.SetTrigger("Waiting");
		});
		NAKCFGEAGHH.OEONGPFALKH.PEHELKCIECB();
	}

	private void NJJDPEPCHNM()
	{
		NAKCFGEAGHH.behaviour.SetTrigger("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/29/Dialogue Text");
	}

	public void HJDBMFCAJHJ()
	{
		NAKCFGEAGHH.characterAnimation.FCGBJEIIMBC = Direction.Down;
		NAKCFGEAGHH.avoidingWorkPoint = false;
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.OKBENHKEEAF();
		}
	}

	private void PDPPMODKCGH()
	{
		IDBCMIMFHJC();
	}

	public void ACPEEPIMGPA()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.MNFMOEKMJKN().workerAvoidingWork = false;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeAvoidingWork(0);
		NAKCFGEAGHH.avoidingWorkPoint = false;
		LHACKABKHDN = 1046f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(1, -3) < NAKCFGEAGHH.GetPerkValue(22))
		{
			CEJBNJOENIF *= 1590f;
		}
		NAKCFGEAGHH.OEONGPFALKH.GLHBJNDMIDC(Vector2.op_Implicit(SceneReferences.GetSceneReferences().avoidWork.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			PDOBHPLPKHG();
		});
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IIIFCANKMCF));
		NAKCFGEAGHH.OEONGPFALKH.NOFKEMGPFEO();
	}

	public WorkerAvoidingWork(Employee NAKCFGEAGHH)
	{
		this.NAKCFGEAGHH = NAKCFGEAGHH;
	}

	[CompilerGenerated]
	private void GKHLGFDCNJP()
	{
		PDOBHPLPKHG();
	}

	private void MEOPNEOFCNA()
	{
		AHPFECCLOBB();
	}

	public void FIAOGLPBCHH()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.DKJOMAAAIBE();
		}
		NAKCFGEAGHH.avoidingWorkPoint = true;
		CommonReferences.MNFMOEKMJKN().workerAvoidingWork = true;
	}

	public void BOCDEPLOKDA()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.MNFMOEKMJKN().workerAvoidingWork = true;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeAvoidingWork(1);
		NAKCFGEAGHH.avoidingWorkPoint = false;
		LHACKABKHDN = 281f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(0, 105) < NAKCFGEAGHH.GetPerkValue(-120))
		{
			CEJBNJOENIF *= 1000f;
		}
		NAKCFGEAGHH.OEONGPFALKH.EJPGFOEDPBG(Vector2.op_Implicit(SceneReferences.FAOPFMBMMJJ().avoidWork.position));
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDPPMODKCGH));
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NJJDPEPCHNM));
		NAKCFGEAGHH.OEONGPFALKH.EHDKLBLKBEO();
	}

	public void BKHOPNGPLFE()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeAvoidingWork(1);
		NAKCFGEAGHH.avoidingWorkPoint = false;
		LHACKABKHDN = 609f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(1, 2) < NAKCFGEAGHH.GetPerkValue(-23))
		{
			CEJBNJOENIF *= 519f;
		}
		NAKCFGEAGHH.OEONGPFALKH.JDHMPOJKOLF(Vector2.op_Implicit(SceneReferences.GetSceneReferences().avoidWork.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MEOPNEOFCNA));
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AMHJGOPOMEE));
		NAKCFGEAGHH.OEONGPFALKH.NOFKEMGPFEO();
	}

	public void GOPIJNFDCME()
	{
		NAKCFGEAGHH.characterAnimation.FCGBJEIIMBC = Direction.Up;
		NAKCFGEAGHH.avoidingWorkPoint = false;
		if (OnlineManager.JPPBEIJDCLJ())
		{
			NAKCFGEAGHH.onlineEmployeeScript.MKFCJKGMCMK();
		}
	}

	public void EPPHNMJONHO()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.FGLCAPLDHOF();
		}
		NAKCFGEAGHH.avoidingWorkPoint = false;
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
	}

	public void JDDIMBBAGMH()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.MNFMOEKMJKN().workerAvoidingWork = true;
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeAvoidingWork(1);
		NAKCFGEAGHH.avoidingWorkPoint = false;
		LHACKABKHDN = 738f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(1, -88) < NAKCFGEAGHH.GetPerkValue(-15))
		{
			CEJBNJOENIF *= 1742f;
		}
		NAKCFGEAGHH.OEONGPFALKH.JDHMPOJKOLF(Vector2.op_Implicit(SceneReferences.CKDKHMPHENE().avoidWork.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MEOPNEOFCNA));
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NJJDPEPCHNM));
		NAKCFGEAGHH.OEONGPFALKH.PEHELKCIECB();
	}

	public void DGIFHBIJDDE()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 1506f;
				NAKCFGEAGHH.behaviour.SetTrigger("HideClickWarning");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.BODEPFFAHLE(OEBNHGNJEJL: true);
			}
		}
	}

	public void NLOEGNNLKKE()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 1738f;
				NAKCFGEAGHH.behaviour.SetTrigger("Received PlaceableMsg of another type not ContainerMsg to ");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.GOACFCOOJLK(OEBNHGNJEJL: true);
			}
		}
	}

	[CompilerGenerated]
	private void JABEJIPHMGI()
	{
		NAKCFGEAGHH.behaviour.SetTrigger("Waiting");
	}

	public void NHCAPCCBNAL()
	{
		NAKCFGEAGHH.characterAnimation.NCAJNNHBHJM(Direction.Down);
		NAKCFGEAGHH.avoidingWorkPoint = true;
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.CGPCDFKIAKP();
		}
	}

	public void CPDKINEBAAH()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.HDODDNEJCGN();
		}
		NAKCFGEAGHH.avoidingWorkPoint = false;
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
	}

	public void DPOELNBBKDE()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.MNFMOEKMJKN().workerAvoidingWork = false;
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeAvoidingWork(1);
		NAKCFGEAGHH.avoidingWorkPoint = true;
		LHACKABKHDN = 1495f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(0, -112) < NAKCFGEAGHH.GetPerkValue(24))
		{
			CEJBNJOENIF *= 192f;
		}
		NAKCFGEAGHH.OEONGPFALKH.GLHBJNDMIDC(Vector2.op_Implicit(SceneReferences.FAOPFMBMMJJ().avoidWork.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MEOPNEOFCNA));
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NJJDPEPCHNM));
		NAKCFGEAGHH.OEONGPFALKH.NOFKEMGPFEO();
	}

	public void LJPDNNLPJAI()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.PLFOKBNDPLO();
		}
		NAKCFGEAGHH.avoidingWorkPoint = true;
		CommonReferences.MNFMOEKMJKN().workerAvoidingWork = false;
	}

	public void CLJBKGOGBII()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 782f;
				NAKCFGEAGHH.behaviour.SetTrigger("CatSize");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.PAHDHACALOH();
			}
		}
	}

	public void OGNKAEGJCCB()
	{
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.PLFOKBNDPLO();
		}
		NAKCFGEAGHH.avoidingWorkPoint = false;
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = false;
	}

	public void IDBCMIMFHJC()
	{
		NAKCFGEAGHH.characterAnimation.FCGBJEIIMBC = Direction.Down;
		NAKCFGEAGHH.avoidingWorkPoint = false;
		if (OnlineManager.IsMasterClient())
		{
			NAKCFGEAGHH.onlineEmployeeScript.BFLBMLILHKH();
		}
	}

	public void MDKNIJCHHCE()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (LHACKABKHDN >= CEJBNJOENIF)
			{
				LHACKABKHDN = 1992f;
				NAKCFGEAGHH.behaviour.SetTrigger("dForDays");
			}
			else
			{
				LHACKABKHDN += Time.fixedDeltaTime;
				NAKCFGEAGHH.OEONGPFALKH.BODEPFFAHLE();
			}
		}
	}

	public void PDMGPCHKEDD()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = true;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeAvoidingWork(0);
		NAKCFGEAGHH.avoidingWorkPoint = true;
		LHACKABKHDN = 264f;
		CEJBNJOENIF = Random.Range(NAKCFGEAGHH.avoidWorkMinTime, NAKCFGEAGHH.avoidWorkMaxTime);
		if (Random.Range(0, 52) < NAKCFGEAGHH.GetPerkValue(-52))
		{
			CEJBNJOENIF *= 312f;
		}
		NAKCFGEAGHH.OEONGPFALKH.OGLJDLEGJAA(Vector2.op_Implicit(SceneReferences.FAOPFMBMMJJ().avoidWork.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = NAKCFGEAGHH.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MEOPNEOFCNA));
		NPCWalkTo walkTo2 = NAKCFGEAGHH.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IIIFCANKMCF));
		NAKCFGEAGHH.OEONGPFALKH.NOFKEMGPFEO();
	}
}
