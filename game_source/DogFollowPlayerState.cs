using System;
using UnityEngine;

public class DogFollowPlayerState : DogStateBase
{
	private bool walkingDone = true;

	private float playerDistance;

	private float nextPathFinding;

	public void MMBELNDJBOH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.LNPLBOFPKLF(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.DGIGKJJFKGM(CDPAMNIPPEC: false);
			DAOFIMMNEKO();
		}
	}

	public override void HMLMFDKLCCM()
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		if (!walkingDone && dogNPC.walkTo.IIMEFNIECLI())
		{
			walkingDone = true;
			if ((Object)(object)dogNPC.playerFollowing != (Object)null && TilemapsInfo.ELHHFNFJIAD(dogNPC.playerFollowing.LEOIMFNKFGA) == InteriorType.Exterior)
			{
				playerDistance = Vector3.Distance(((Component)dogNPC).transform.position, ((Component)dogNPC.playerFollowing).transform.position);
				if (playerDistance < 5f && !dogNPC.IsThePlayerMoving())
				{
					dogNPC.ChangeState(DogState.IdleNearPlayer);
				}
				else if (dogNPC.IsThePlayerMoving() && Vector3.Distance(((Component)dogNPC).transform.position, Utils.PFAONDFCNFD(dogNPC.playerFollowing)) > 1f)
				{
					AADENBPAJHN();
				}
			}
		}
		if (Time.timeSinceLevelLoad > nextPathFinding && (Object)(object)dogNPC.playerFollowing != (Object)null && TilemapsInfo.ELHHFNFJIAD(dogNPC.playerFollowing.LEOIMFNKFGA) == InteriorType.Exterior)
		{
			playerDistance = Vector3.Distance(((Component)dogNPC).transform.position, ((Component)dogNPC.playerFollowing).transform.position);
			if (playerDistance < 5f && !dogNPC.IsThePlayerMoving())
			{
				dogNPC.ChangeState(DogState.IdleNearPlayer);
			}
			else if (dogNPC.IsThePlayerMoving() && Vector3.Distance(((Component)dogNPC).transform.position, Utils.PFAONDFCNFD(dogNPC.playerFollowing)) > 1f)
			{
				AADENBPAJHN();
			}
		}
	}

	public void EBLEAJFOEJL()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.OOJJHGOGMGM());
	}

	public void CPMNAJOJEPP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.HPDIAONNFIF(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: false);
			ILEAOGDBLGE();
		}
	}

	public void BNBDNIEFBLF()
	{
		walkingDone = true;
	}

	public void NNBPENENIIC()
	{
		walkingDone = true;
	}

	public void FEHGALEDJKI()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.FLEMLDJBGJP());
	}

	public void PBIHJIMCCPO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.FDLMDLIAFFI(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: false);
			ODOOJBAGKPE();
		}
	}

	public void FNJODLOADKA()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void FJHJDJELOGG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.AMJMFHEPBOM(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.DGIGKJJFKGM(CDPAMNIPPEC: false);
			GKFINLKHKOF();
		}
	}

	public void BOHOLDGCECJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.HFHNBMACJPD(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.GDCFJNFPMGE(CDPAMNIPPEC: true);
			FICLGDADLPC();
		}
	}

	public void FPNNHGBNHGB()
	{
		walkingDone = true;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		NPCWalkTo walkTo = dogNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Remove(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = dogNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Remove(walkTo2.OnFailStart, new Action(NNBPENENIIC));
	}

	public void IAEENJONEPD()
	{
		walkingDone = false;
	}

	public void FHENKAADBHJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.HOJOKLFBDFB(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.JOECEIFKHAJ(CDPAMNIPPEC: false);
			DKCIPEBOEMJ();
		}
	}

	public void CEDKNKOPKAH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void AFIBEMKCFAG()
	{
		walkingDone = true;
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		walkingDone = false;
		dogNPC.StartWalking(positionToGo, NNBPENENIIC, PDOBHPLPKHG, 4f, MFCMOOKEHMN: false);
		nextPathFinding = Time.timeSinceLevelLoad + 1.5f;
	}

	public void LOHPDKPGBNG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.AILJPGKBGAK(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.BCLAMKGEKIO(CDPAMNIPPEC: false);
			NJCMNCBFCLE();
		}
	}

	public void PLNCGCKGGPL()
	{
		walkingDone = true;
	}

	public void NOOLBMCPHGN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.HPDIAONNFIF(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.PPOICOJBOCI(CDPAMNIPPEC: true);
			DENDCNIEANE();
		}
	}

	public void PDOBHPLPKHG()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.ChangeDirectionNextFrame());
	}

	public void AADENBPAJHN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.ELHHFNFJIAD(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.ExitInteraction(CDPAMNIPPEC: true);
			DKFOJDHBGEJ();
		}
	}

	public void HJNIGHNPNPE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.HOJOKLFBDFB(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.IODEEPJHFGG(CDPAMNIPPEC: true);
			JEJCEIHICAF();
		}
	}

	public void PADPIEKGNMH()
	{
		((MonoBehaviour)dogNPC).StartCoroutine(dogNPC.KAPBLFHIDKF());
	}

	public void KNCDDGGAKLC()
	{
		walkingDone = true;
	}

	public void CJFLLCEPALG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		positionToGo = Vector2.op_Implicit(Utils.PFAONDFCNFD(dogNPC.playerFollowing));
		if (TilemapsInfo.HPDIAONNFIF(positionToGo) == InteriorType.Exterior)
		{
			dogNPC.dogAnimation.BJGOFPBMCME(CDPAMNIPPEC: false);
			IGDKBGMCIOE();
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		AADENBPAJHN();
	}

	public void JOEBOPLDEPN()
	{
		walkingDone = true;
	}
}
