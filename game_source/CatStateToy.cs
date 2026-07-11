using System;
using UnityEngine;

public class CatStateToy : CatStateBase
{
	private Vector3 target;

	private bool walkFinished;

	private float endState;

	private float finishAction;

	private PetToy petToy;

	public void IJKIFECCGEP()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void JLBMCMCCDNN()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void NDKHHJBEMBJ()
	{
		animator.SetTrigger("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
	}

	public void EJPFGEHOKPK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void HOGBHJLDIPL()
	{
		animator.SetTrigger("Current Orders");
	}

	public void ABMMONFHFGF()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void PKCODIDOBJO()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		catNpc.catAnimation.SetBool("Toy", EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendSetBool("Toy", AODONKKHPBP: false);
		}
	}

	public void CKGFIHKADBM()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void JEECJGJGMKL()
	{
		animator.SetTrigger("----> Recipe ");
	}

	private void DMMGLMKEMNJ()
	{
		animator.SetTrigger("LearnPrecision");
	}

	public void IKOIKCHBBNG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void ICBHCBGAONN()
	{
		animator.SetTrigger("Error_FloorTilesLimit");
	}

	public void BHELEAIBPAH()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void KIMEBNLKFBK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void NCHPGNANPGN()
	{
		animator.SetTrigger("City/Chuck/Introduce");
	}

	public void KMFMHKIPDAL()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void BFNAPCFJKKB()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		catNpc.walkingAgainCount = 0;
		target = Vector3.zero;
		walkFinished = false;
		petToy = PetToy.GetClosestToy(Vector2.op_Implicit(((Component)catNpc).transform.position));
		target = ((Component)petToy).transform.position;
		catNpc.WaitToWalk(this);
	}

	public void HILLNFIICFK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void FDFOBDGPNLH()
	{
		animator.SetTrigger("TavernServiceManager tavernStats is empty.");
	}

	private void CHOJDAOBKOI()
	{
		animator.SetTrigger("Items/item_name_1108");
	}

	public void CNJMNBAKEEK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void NIHGBBEOCNB()
	{
		animator.SetTrigger("Misc");
	}

	public void ALDAHNKKOGE()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void FMEAFAADLPL()
	{
		animator.SetTrigger("RecieveMaiInBar");
	}

	public void GBDLGKNDBIK()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		base.DKFOJDHBGEJ();
		catNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(target), AHDHLIECIGH: false);
		catNpc.walkTo.speed = catNpc.speed;
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PDCLHMGJIMK));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void AGLDNOHPHFD()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void KNGKEAPDNLP()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void JHIGABPNINH()
	{
		animator.SetTrigger("Bouncer/");
	}

	public void JLJEFENEFMG()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void EDDFAALFNGB()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void BDEDPGDNEJF()
	{
		animator.SetTrigger("User logged on: ");
	}

	public void MMHIOJMIJMP()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void IEJGDOPLBLB()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void FLGCPNKDALN()
	{
		animator.SetTrigger("PlayerJoined");
	}

	private void KCIIJJJADBE()
	{
		animator.SetTrigger("Dialogue System/Conversation/Gass_Barks_Bye/Entry/3/Dialogue Text");
	}

	private void BKMEJIGMCGM()
	{
		animator.SetTrigger("dForDays");
	}

	private void IFLMHMKPHAF()
	{
		animator.SetTrigger("Items/item_name_622");
	}

	public void CNJOADLENGP()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void OBHFDPLPAGM()
	{
		animator.SetTrigger("Select Theme");
	}

	private void PFJGOIOJIKC()
	{
		animator.SetTrigger("AddQuest2");
	}

	private void ADLOEKOAHFK()
	{
		animator.SetTrigger("Not enough money");
	}

	public void AHPFECCLOBB()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void HMOPLHDOPKK()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void CLOEFOFKDFC()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void BEEDFJOOPAH()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void APGLLOHDPHO()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void PDOBHPLPKHG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void HMOFIMHPKBE()
	{
		animator.SetTrigger("Misc");
	}

	private void OOLEHIEBLLD()
	{
		animator.SetTrigger("NotValid");
	}

	public void GOPIJNFDCME()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void MKJDIMFOGIA()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void FNJODLOADKA()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void NHMPNFHGFJL()
	{
		animator.SetTrigger("Disabled");
	}

	public void AAPBBHOHMIJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void HEJJIGAGFGO()
	{
		animator.SetTrigger("ReceiveTavernStatsLoad");
	}

	public void DJNOFCBINHM()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void PADPIEKGNMH()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void PCFNCMPNBDI()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void MEMMDHBLNBA()
	{
		animator.SetTrigger("DemolishConfirmationWithAnimals");
	}

	public void KNIBOAEFGPJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void BFGEFKOODNA()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void IJCLNLKKIAF()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void NNGIDOAHFLF()
	{
		animator.SetTrigger("Bother");
	}

	public void OKHDMEMEIEJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void AGLOLKAIAMG()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void IGOGKMLCLPI()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void MAILEMECPME()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void PBBBJBHFGNN()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void DCLMGAKHJDP()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void PDCLHMGJIMK()
	{
		animator.SetTrigger("Walk");
	}

	public override void GFBLAEEOPAO()
	{
		if (!walkFinished)
		{
			if ((Object)(object)petToy == (Object)null)
			{
				PDCLHMGJIMK();
				return;
			}
			if ((Object)(object)petToy != (Object)null && Object.op_Implicit((Object)(object)petToy.placeable) && petToy.placeable.OGKDEFAGEBL)
			{
				PDCLHMGJIMK();
				return;
			}
		}
		if (!catNpc.walkTo.IIMEFNIECLI())
		{
			return;
		}
		if (!walkFinished)
		{
			Object.Destroy((Object)(object)((Component)petToy).gameObject);
			catNpc.catAnimation.SetBool("Toy", EGFGNGJGBOP: true);
			if (OnlineManager.IsMasterClient())
			{
				catNpc.onlineCat.SendSetBool("Toy", AODONKKHPBP: true);
			}
			walkFinished = true;
			finishAction = Time.fixedTime + (float)Random.Range(10, 15);
			endState = finishAction + 2f;
		}
		if (Time.fixedTime > finishAction)
		{
			catNpc.catAnimation.SetDirection(Direction.Down);
			catNpc.catAnimation.SetBool("Toy", EGFGNGJGBOP: false);
			if (OnlineManager.IsMasterClient())
			{
				catNpc.onlineCat.SendSetBool("Toy", AODONKKHPBP: false);
			}
			if (Time.fixedTime > endState)
			{
				PDCLHMGJIMK();
			}
		}
	}

	public void HNFMJFJPDNN()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void AEILMHNGMPJ()
	{
		animator.SetTrigger("RoadBlocked/Main");
	}

	public void KBCKFDDDEGE()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void PKKNFNMFOON()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void EBLEAJFOEJL()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void GNLIBMPMCIH()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void MMPGIKGMFMA()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}
}
