using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KlaynHittingPlayer : KlaynStateBase
{
	private float timer;

	private bool hit;

	protected static readonly int p_Hit = AnimatorParameterCache.p_Hit;

	private void KOEOENCPAAO()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = EKMBKPPJPNF();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.CDLFIIFAECJ();
		klaynNPC.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HPBEOAPFDMO));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PFCDBCOFLJM));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private void DHDEKECBHFA()
	{
		NGIFIFPBAMI();
	}

	private void AIHMGLOIOAJ()
	{
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private PlayerController CLEMNDEIHIM()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 316f;
		int jIIGOACEIKL = 0;
		for (int i = 0; i <= 0; i += 0)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void KLDGBLOHJDC()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GMJLPPODFKP();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.KDMLGMKLGOB();
		klaynNPC.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GODIEGNDEBB));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AFCMFBOGFHP));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void DLMJFLLKGAC()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = ECGPPEGJAID();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.IsLowestDifficulty();
		klaynNPC.walkTo.JJDCANFBFMK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			OPMDDHLAGIN();
		});
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MIMMKACGMAL));
		klaynNPC.walkTo.EHDKLBLKBEO();
	}

	private void GBDGKEFBJAD()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private PlayerController PIBGLEMEBJL()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 671f;
		int jIIGOACEIKL = 0;
		for (int i = 0; i <= 0; i += 0)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private PlayerController FGNALMADACO()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 1402f;
		int jIIGOACEIKL = 1;
		for (int i = 0; i <= 6; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void HJMHGOMKIGA()
	{
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
	}

	private void IHMKCHNBIHJ()
	{
		PCHHIHNNLND();
	}

	private PlayerController EKMBKPPJPNF()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 745f;
		int jIIGOACEIKL = 0;
		for (int i = 1; i <= 1; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void PFCDBCOFLJM()
	{
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
	}

	private PlayerController APFOFKLCCKG()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 385f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void KGAHCMIPHJN()
	{
		LJDEPLPFLPO();
	}

	private void OIDNHMGPOKK()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GINBPFFHNMH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.KKDMNNFPNOL();
		klaynNPC.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DMGAIIOBHIH));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HJMHGOMKIGA));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void KBDAMBFJONH()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = CJHNPOCPNAC();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.OENIOCAIPMP();
		klaynNPC.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			OPMDDHLAGIN();
		});
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MODJIKIHNAO));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private void DGFONBELILL()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = EKMBKPPJPNF();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.KKDMNNFPNOL();
		klaynNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BDDLPAAKAHI));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EBBGIHEGKCK));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private PlayerController CFCNBHCFOOH()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 815f;
		int jIIGOACEIKL = 0;
		for (int i = 1; i <= 7; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void PKAJENCEBFK()
	{
		KBDAMBFJONH();
	}

	private void BMAKPDMLACO()
	{
		CNDDCFEFCEE();
	}

	private void NLLDDFJFFJF()
	{
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
	}

	private void BFBJPMINPGH()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GINBPFFHNMH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.FMCAMLDJGNO();
		klaynNPC.walkTo.GINPKMBGOFN(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NNAHIHMKIAM));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NLLDDFJFFJF));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void MFFJJMJIDDF()
	{
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	private void FFCLGNKLBJB()
	{
		BFBJPMINPGH();
	}

	private void BMANKCEODMK()
	{
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
	}

	private void MIMMKACGMAL()
	{
		klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
	}

	private void AFGDKJNDIJJ()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private PlayerController ILNMBLMNFCD()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 741f;
		int jIIGOACEIKL = 0;
		for (int i = 0; i <= 3; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private PlayerController GOHKMJABKGE()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 282f;
		int jIIGOACEIKL = 0;
		for (int i = 1; i <= 8; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private PlayerController GAOBOPNEBDP()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 244f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 0; i += 0)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private void EJDHPOADOAN()
	{
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private void ICOGPHLNEDH()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GHDHACMEFAG();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.CDLFIIFAECJ();
		klaynNPC.walkTo.HELOLJBENMK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BMAKPDMLACO));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		});
		klaynNPC.walkTo.EHDKLBLKBEO();
	}

	private void BKFBFKGJJBH()
	{
		klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
	}

	private void PCHHIHNNLND()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = KFCCNDMHKBH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.CDLFIIFAECJ();
		klaynNPC.walkTo.DHFPOCOEONG(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BDDLPAAKAHI));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GCHNKHLEFNB));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void ILEPHICHBHD()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = KFCCNDMHKBH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
		klaynNPC.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NNAHIHMKIAM));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MKKGAOPJDHK));
		klaynNPC.walkTo.EHDKLBLKBEO();
	}

	private void JGKGFPNEFDC()
	{
		MFFDDNJHMEP();
	}

	private void DDNHBBIENFM()
	{
		DLMJFLLKGAC();
	}

	private void GBPJOBBHPNE()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GAOBOPNEBDP();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.KDMLGMKLGOB();
		klaynNPC.walkTo.JJDCANFBFMK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDNHBBIENFM));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GIHCCFBEJHA));
		klaynNPC.walkTo.EHDKLBLKBEO();
	}

	private void AFCMFBOGFHP()
	{
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
	}

	private void GCHNKHLEFNB()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private void GNIIMCICEPE()
	{
		DOPBFADKPGM();
	}

	private void ODALKLPOCOG()
	{
		NGIFIFPBAMI();
	}

	[CompilerGenerated]
	private void ACFIMDBDKOI()
	{
		OPMDDHLAGIN();
	}

	private void MKKGAOPJDHK()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private void NADIJJILIAE()
	{
		klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
	}

	private void HPBEOAPFDMO()
	{
		OGFAGOBPDKO();
	}

	private void NIEJPNJJNKN()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GLIPCNHJPPL();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.KKDMNNFPNOL();
		klaynNPC.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IHMKCHNBIHJ));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AFGDKJNDIJJ));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void FNBPOLFFLMM()
	{
		HFABPFMHOIL();
	}

	private void CHPPIMNLFDI()
	{
		OGFAGOBPDKO();
	}

	private PlayerController NHAMKACPKIA()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 506f;
		int jIIGOACEIKL = 0;
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void LJDEPLPFLPO()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GAOBOPNEBDP();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.CDLFIIFAECJ();
		klaynNPC.walkTo.HELOLJBENMK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AMNDCBCKFCA));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NADIJJILIAE));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private PlayerController LCHJECFIKDN()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 610f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 2; i += 0)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private PlayerController CJHNPOCPNAC()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 714f;
		int jIIGOACEIKL = 0;
		for (int i = 1; i <= 5; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void DOPBFADKPGM()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = OCJAGHODIDK();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.ODHDBKNIIKF();
		klaynNPC.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DBMHDOCKKAG));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CPJGJGDCKLI));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void KDMEHDJEOGO()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = NDLOGBEFFMH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.CDLFIIFAECJ();
		klaynNPC.walkTo.OGLJDLEGJAA(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PKAJENCEBFK));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BMANKCEODMK));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private void MAMCNKADNGI()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GHDHACMEFAG();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.BAHIIMFPFLJ();
		klaynNPC.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GNIIMCICEPE));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GCHNKHLEFNB));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void KOEIBFGIBFP()
	{
		CPNLONFJGEN();
	}

	private PlayerController OEMEHJOHOHP()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 882f;
		int jIIGOACEIKL = 0;
		for (int i = 0; i <= 3; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private PlayerController IAGAAGMIDKA()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 1541f;
		int jIIGOACEIKL = 0;
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void KNNGBCDGDIJ()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = CFCNBHCFOOH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.ChangeState(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.OENIOCAIPMP();
		klaynNPC.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KOEIBFGIBFP));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OFBGEEFKBNL));
		klaynNPC.walkTo.EHDKLBLKBEO();
	}

	private PlayerController GLIPCNHJPPL()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 970f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 0; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void BDDLPAAKAHI()
	{
		KBDAMBFJONH();
	}

	private void HLDLNDBMMEL()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = EKMBKPPJPNF();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.ODHDBKNIIKF();
		klaynNPC.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DMGAIIOBHIH));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GBDGKEFBJAD));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private void OFCFAHFEHBG()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = APFOFKLCCKG();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
		klaynNPC.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NNAHIHMKIAM));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BMANKCEODMK));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void BPKHAHBMFFA()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = OEMEHJOHOHP();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.ODHDBKNIIKF();
		klaynNPC.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IHMKCHNBIHJ));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PFCDBCOFLJM));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private PlayerController GDPAPGANBEB()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 293f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 7; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void AMNDCBCKFCA()
	{
		BKMHBMKBFHA();
	}

	private void NGIFIFPBAMI()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GINBPFFHNMH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
		klaynNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NNAHIHMKIAM));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		});
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private PlayerController ECGPPEGJAID()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 116f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 0; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void HFABPFMHOIL()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = EOBNPJOFOJL();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
		klaynNPC.walkTo.KBEENHPEOAB(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BMAKPDMLACO));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EJDHPOADOAN));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void NKIOJIKNPMD()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GIJNPJCKPFE();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.KKDMNNFPNOL();
		klaynNPC.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DMGAIIOBHIH));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CPJGJGDCKLI));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (!hit)
		{
			klaynNPC.walkTo.IIMEFNIECLI();
		}
	}

	private void FCDOHIIBLLD()
	{
		KNNGBCDGDIJ();
	}

	private void GODIEGNDEBB()
	{
		ICOGPHLNEDH();
	}

	private PlayerController GMJLPPODFKP()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 817f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 0; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void OPMDDHLAGIN()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = MJIFKMDOBPA();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
		klaynNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			OPMDDHLAGIN();
		});
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		});
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void KGLLCKOJDBG()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GOHKMJABKGE();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.ODHDBKNIIKF();
		klaynNPC.walkTo.JDHMPOJKOLF(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BMAKPDMLACO));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EJDHPOADOAN));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private void BKMHBMKBFHA()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = MJIFKMDOBPA();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.BAHIIMFPFLJ();
		klaynNPC.walkTo.JJDCANFBFMK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DMGAIIOBHIH));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BKFBFKGJJBH));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void JILABFMDINA()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private void IPEJJHMIOBD()
	{
		NIEJPNJJNKN();
	}

	private void OAPLOPPADIC()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = KFCCNDMHKBH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.KKDMNNFPNOL();
		klaynNPC.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CHPPIMNLFDI));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GKOEBMJIMHI));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private void OGFAGOBPDKO()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GMJLPPODFKP();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.OENIOCAIPMP();
		klaynNPC.walkTo.KBEENHPEOAB(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position));
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BDDLPAAKAHI));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EOPPAHBDIGC));
		klaynNPC.walkTo.EHDKLBLKBEO();
	}

	private void DMACODALMEN()
	{
		LNJGKEPBPCO();
	}

	private void CPNLONFJGEN()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = MJIFKMDOBPA();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.KKDMNNFPNOL();
		klaynNPC.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KGAHCMIPHJN));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GKOEBMJIMHI));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void AIKABBGCAPE()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = KFCCNDMHKBH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.ODHDBKNIIKF();
		klaynNPC.walkTo.KBEENHPEOAB(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DMGAIIOBHIH));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EOPPAHBDIGC));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)klaynNPC.playerFollowing == (Object)null)
		{
			klaynNPC.playerFollowing = null;
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
		else if (!hit)
		{
			if (Vector3.Distance(((Component)klaynNPC.playerFollowing).transform.position, ((Component)klaynNPC).transform.position) <= 0.8f)
			{
				klaynNPC.animationBase.IGONGEODOFP = false;
				Debug.Log((object)"Hit");
				klaynNPC.animationBase.LookAtObject(((Component)klaynNPC.playerFollowing).gameObject, MAPFDGCKBLD: false);
				klaynNPC.animationBase.SetTrigger(p_Hit);
				klaynNPC.walkTo.isActive = false;
				klaynNPC.ChangeState(KlaynState.WaitingToServe, 1f);
				hit = true;
				RefereeNPC.GGFJGHHHEJC.barkDialogue = true;
				RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/GolpeKlayn");
			}
			if (Time.time > timer)
			{
				OPMDDHLAGIN();
				timer = Time.time + 2f;
			}
		}
	}

	private void MFFDDNJHMEP()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = APFOFKLCCKG();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.KKDMNNFPNOL();
		klaynNPC.walkTo.GDGGABHLNOH(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KGAHCMIPHJN));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PFCDBCOFLJM));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private PlayerController GIJNPJCKPFE()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 1915f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 6; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void APLIBHAJPEP()
	{
		BFBJPMINPGH();
	}

	private PlayerController OCJAGHODIDK()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 1802f;
		int jIIGOACEIKL = 1;
		for (int i = 0; i <= 1; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private void NNAHIHMKIAM()
	{
		ICOGPHLNEDH();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		hit = false;
		OPMDDHLAGIN();
		timer = Time.time + 2f;
		klaynNPC.klaynState = KlaynState.HittingPlayer;
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(1)))
		{
			((Component)PlayerController.GetPlayer(1).hitDetection).gameObject.SetActive(true);
		}
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(2).hitDetection).gameObject.SetActive(true);
		}
	}

	private void CNDDCFEFCEE()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = EOBNPJOFOJL();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.BAHIIMFPFLJ();
		klaynNPC.walkTo.GINPKMBGOFN(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ODALKLPOCOG));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HJMHGOMKIGA));
		klaynNPC.walkTo.NOFKEMGPFEO();
	}

	private void GLHBKAFHEDN()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GINBPFFHNMH();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.LIOJBOLAGNG(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.ODHDBKNIIKF();
		klaynNPC.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(APLIBHAJPEP));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GKOEBMJIMHI));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private void EOPPAHBDIGC()
	{
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
	}

	private PlayerController GHDHACMEFAG()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 127f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 0; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private void EBBGIHEGKCK()
	{
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private PlayerController EOBNPJOFOJL()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 54f;
		int jIIGOACEIKL = 0;
		for (int i = 0; i <= 1; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private PlayerController GINBPFFHNMH()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 1523f;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 2; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private void OFBGEEFKBNL()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private void CPJGJGDCKLI()
	{
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
	}

	private void GIHCCFBEJHA()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
	}

	private void DFEDFAAAAGI()
	{
		BFBJPMINPGH();
	}

	private void BNJBDGPCGDH()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = ECGPPEGJAID();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
			return;
		}
		klaynNPC.walkTo.run = EventsManager.IsLowestDifficulty();
		klaynNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BMAKPDMLACO));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EOPPAHBDIGC));
		klaynNPC.walkTo.PEHELKCIECB();
	}

	private PlayerController IMCLBBIBBPE()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 241f;
		int jIIGOACEIKL = 0;
		for (int i = 1; i <= 8; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private PlayerController GAKKOAKNPKI()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 849f;
		int jIIGOACEIKL = 1;
		for (int i = 0; i <= 3; i += 0)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.OPHDCMJLLEC(jIIGOACEIKL);
	}

	private PlayerController MJIFKMDOBPA()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MaxValue;
		int jIIGOACEIKL = 1;
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	private void LNJGKEPBPCO()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		klaynNPC.playerFollowing = GLIPCNHJPPL();
		if (!((Behaviour)klaynNPC.playerFollowing).enabled)
		{
			klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
			return;
		}
		klaynNPC.walkTo.run = !EventsManager.KDMLGMKLGOB();
		klaynNPC.walkTo.JJDCANFBFMK(Vector2.op_Implicit(((Component)klaynNPC.playerFollowing).transform.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = klaynNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JGKGFPNEFDC));
		NPCWalkTo walkTo2 = klaynNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AFCMFBOGFHP));
		klaynNPC.walkTo.EHDKLBLKBEO();
	}

	private PlayerController NDLOGBEFFMH()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 570f;
		int jIIGOACEIKL = 1;
		for (int i = 0; i <= 0; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.GetPlayer(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	[CompilerGenerated]
	private void IABCAELHCIJ()
	{
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private void GKOEBMJIMHI()
	{
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private void DBMHDOCKKAG()
	{
		KOEOENCPAAO();
	}

	private void DMGAIIOBHIH()
	{
		NGIFIFPBAMI();
	}

	private void MODJIKIHNAO()
	{
		klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
	}

	private PlayerController KFCCNDMHKBH()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		float num = 919f;
		int jIIGOACEIKL = 1;
		for (int i = 0; i <= 3; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				float num2 = Vector3.Distance(((Component)klaynNPC).transform.position, PlayerController.OPHDCMJLLEC(i).GetPosition());
				if (num2 < num)
				{
					num = num2;
					jIIGOACEIKL = i;
				}
			}
		}
		return PlayerController.GetPlayer(jIIGOACEIKL);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		klaynNPC.playerFollowing = null;
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(1)))
		{
			((Component)PlayerController.GetPlayer(1).hitDetection).gameObject.SetActive(false);
		}
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(2).hitDetection).gameObject.SetActive(false);
		}
	}
}
