using System;
using UnityEngine;

public class DogToyState : DogStateBase
{
	private bool walkingDone = true;

	private PetToy dogToy;

	public void DKGAIJNMFBO()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.ChangeState((DogState)8);
		}
	}

	public void INOAOAEGNAL()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.CHFKPKDBIJL(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.ChangeState((DogState)7);
		}
	}

	public void IAEENJONEPD()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA(DogState.Stopped);
		}
	}

	public void HNFMJFJPDNN()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void FEHGALEDJKI()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		NPCWalkTo walkTo = dogNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Remove(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = dogNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Remove(walkTo2.OnFailStart, new Action(NNBPENENIIC));
	}

	public override void HMLMFDKLCCM()
	{
		if (!walkingDone && dogNPC.walkTo.IIMEFNIECLI())
		{
			Object.Destroy((Object)(object)((Component)dogToy).gameObject);
			dogNPC.dogAnimation.DogAnimations(DogNPC.DogInteractionType.Toy);
			walkingDone = true;
		}
		else if (walkingDone)
		{
			dogNPC.dogAnimation.DogAnimations(DogNPC.DogInteractionType.Toy);
		}
	}

	public void NFMLNKAFCNK()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.CHFKPKDBIJL(DogState.FindHole);
		}
	}

	public void FOEBEJHKEKE()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void BBHODALHMAD()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void IJKIFECCGEP()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void HILLNFIICFK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void GFLNGGGPGCF()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void IPKFEPKJIJE()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void GIJICLMDDPD()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GNCLBACINCA(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA((DogState)8);
		}
	}

	public void FFEIDFCNAMA()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.IHMEOKNMHIJ(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA((DogState)6);
		}
	}

	public void GNLIBMPMCIH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void EPOODBHJIAA()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.CHFKPKDBIJL(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
	}

	public void HMNPBBDKJCD()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN(DogState.Idle);
		}
	}

	public void CDJGIBMEEGG()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.ChangeState((DogState)6);
		}
	}

	public void DLFBDNPEKAE()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void FKFMIABEDCH()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
	}

	public void BOJOFAFIICG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void CKGNACMBJLG()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.IHMEOKNMHIJ(DogState.FindHole);
		}
	}

	public void KJBCLEMCEDD()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN((DogState)8);
		}
	}

	public void CHKECONHFPP()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GNCLBACINCA(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.ChangeState(DogState.Stopped);
		}
	}

	public void AJJIICECMDO()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void NHCAPCCBNAL()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void KEOPLJIICAK()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN((DogState)6);
		}
	}

	public void HMLFDDDGGBO()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void GIOCOKJJADI()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GNCLBACINCA(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.IHMEOKNMHIJ(DogState.Toy);
		}
	}

	public void JMLLEEKDLKG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void DOPAKBIFDBH()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.CHFKPKDBIJL(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA(DogState.Stopped);
		}
	}

	public void JHJPHDEJLJO()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.ChangeState(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.IHMEOKNMHIJ(DogState.Stopped);
		}
	}

	public void LDAOOEAGMGG()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.ChangeState(DogState.Stopped);
		}
	}

	public void DCGPJAMJBGC()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.CHFKPKDBIJL(DogState.FindHole);
		}
	}

	public void PDOBHPLPKHG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void CAELADBMLFL()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void KPMCGMJJBEA()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void DOMBACOKPCK()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GNCLBACINCA(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.CHFKPKDBIJL((DogState)6);
		}
	}

	public void JOEBOPLDEPN()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.CHFKPKDBIJL(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN((DogState)6);
		}
	}

	public void JFKIMFNGCJA()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.CHFKPKDBIJL(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.CHFKPKDBIJL((DogState)8);
		}
	}

	public void MKJDIMFOGIA()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void AAPBBHOHMIJ()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void BNBDNIEFBLF()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
	}

	public void JLJEFENEFMG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		dogToy = PetToy.GetClosestToy(Vector2.op_Implicit(((Component)dogNPC).transform.position));
		DKFOJDHBGEJ();
	}

	public void LBELGDFFBGL()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.ChangeState(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.CHFKPKDBIJL((DogState)8);
		}
	}

	public void LPCOADBOKED()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.ChangeState(DogState.FindHole);
		}
	}

	public void IDBCMIMFHJC()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void PMGGBGFBOAN()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA(DogState.Idle);
		}
	}

	public void GBDLGKNDBIK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void HMOPLHDOPKK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void AFIBEMKCFAG()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GIIJKKALBEM(DogState.Idle);
		}
	}

	public void GMCINBCEPJO()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void IJCLNLKKIAF()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void AGLDNOHPHFD()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		walkingDone = false;
		dogNPC.StartWalking(Vector2.op_Implicit(((Component)dogToy).gameObject.transform.position), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: true);
	}

	public void ALDAHNKKOGE()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void KNCDDGGAKLC()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
	}

	public void PADPIEKGNMH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void EJNOLAJEKGL()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.ChangeState(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA(DogState.IdleNearPlayer);
		}
	}

	public void NNBPENENIIC()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.ChangeState(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.ChangeState(DogState.Idle);
		}
	}

	public void BKNBKDKIDNJ()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void FJNPFILECCM()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void JKJHDNOJLEO()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA((DogState)6);
		}
	}

	public void PLNCGCKGGPL()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GIIJKKALBEM((DogState)8);
		}
	}

	public void KIMEBNLKFBK()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void CLOEFOFKDFC()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void BEEDFJOOPAH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void HJDBMFCAJHJ()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void EBLEAJFOEJL()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void MIGDKMBHMHC()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GNCLBACINCA(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
	}

	public void HEEOHKBPMAI()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void PAPBICGNLFO()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.IHMEOKNMHIJ(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA((DogState)7);
		}
	}

	public void PBBBJBHFGNN()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void ABMMONFHFGF()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void GCNAPIKOOOE()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.IHMEOKNMHIJ(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.ChangeState(DogState.Idle);
		}
	}

	public void CEDKNKOPKAH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void LACDAMFANIM()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void CHGINGNAENF()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.CHFKPKDBIJL(DogState.Stopped);
		}
	}

	public void PNLCMEHGHMH()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GIIJKKALBEM((DogState)7);
		}
	}

	public void IMGMIIABINE()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.ChangeState(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA((DogState)6);
		}
	}

	public void EGJLEIHNJGL()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GNCLBACINCA(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.ChangeState(DogState.Idle);
		}
	}

	public void CHNAMAFBMMK()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.GIIJKKALBEM(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.CHFKPKDBIJL(DogState.IdleNearPlayer);
		}
	}

	public void IIEGDHJEEKC()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void IKOIKCHBBNG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void CNJOADLENGP()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void GFHMIMDFMLH()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.ChangeState(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.GIIJKKALBEM(DogState.FindHole);
		}
	}

	public void MAMACONCDGM()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.CHFKPKDBIJL(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.ChangeState((DogState)6);
		}
	}

	public void KDFIIOCOBAJ()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.JINJODIENIN(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GNCLBACINCA(DogState.Idle);
		}
	}

	public void BFGEFKOODNA()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void NDJEJLOECNE()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.GOBIELKMHHF());
	}

	public void MDNOABLFKAJ()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.CHFKPKDBIJL(DogState.IdleNearPlayer);
		}
		else
		{
			dogNPC.JINJODIENIN(DogState.IdleNearPlayer);
		}
	}

	public void KHKIJGICIFF()
	{
		if ((Object)(object)dogNPC.playerFollowing != (Object)null)
		{
			dogNPC.ChangeState(DogState.FollowPlayer);
		}
		else
		{
			dogNPC.GIIJKKALBEM(DogState.FollowPlayer);
		}
	}
}
