using System;
using UnityEngine;

public class HeadToPetBowl : CatStateBase
{
	private PetBowl petBowl;

	private bool eating;

	private float currentEatingTime;

	private float eatingTime;

	private bool isDrinking;

	private void PPIGJKICDHO()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Diagonal);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
	}

	private void GDOJCIGIIIB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Left);
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
	}

	public void ILEAOGDBLGE(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 1950f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DHFPOCOEONG(LAFNLCMIHHL, AHDHLIECIGH: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EDDFAALFNGB));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KLAKFLIHPNN));
		catNpc.walkTo.NOFKEMGPFEO();
	}

	private void MEMMDHBLNBA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("LE_3");
		}
	}

	public void HEEOHKBPMAI()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	private void LBJAFIKIHGB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Left;
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Diagonal);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	private void NIHMPEOBCJH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Right);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)7;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		catNpc.catAnimation.SetBool("Eating", EGFGNGJGBOP: false);
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendSetBool("Eating", AODONKKHPBP: false);
		}
	}

	private void NKNAHFGFACN()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Diagonal);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Diagonal;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	private void CMHCHBMEAOJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Right);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
	}

	private void KLAKFLIHPNN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("ReceiveBanquetCustomerState");
		}
	}

	public void JLAHJOOAKID(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 749f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.KBEENHPEOAB(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADLOEKOAHFK));
		catNpc.walkTo.EHDKLBLKBEO();
	}

	private void KLGKLJABDME()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("Menu Mode Settings");
		}
	}

	private void OBHFDPLPAGM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("sprintToggle");
		}
	}

	private void NONIHKEHKKJ()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Left);
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Diagonal);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
	}

	public void BFGPMEKLDDB(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 74f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.GLHBJNDMIDC(LAFNLCMIHHL);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HEEOHKBPMAI));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MEMMDHBLNBA));
		catNpc.walkTo.NOFKEMGPFEO();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		catNpc.walkingAgainCount = 0;
		eating = false;
		catNpc.WaitToWalk(this);
	}

	private void GJPMEDFCILN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("OnlinePlayer");
		}
	}

	public void CAKIFDOCNKO(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 280f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.GDGGABHLNOH(LAFNLCMIHHL, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CLOEFOFKDFC));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADLOEKOAHFK));
		catNpc.walkTo.PEHELKCIECB();
	}

	private void ODJNMNNOOFB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Left);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)8;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
	}

	private void NCMHDAPPNHL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Left);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)5;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
	}

	private void JFFHGOCNBGC()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)5;
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
	}

	private void EHOJJEPMLNI()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Right;
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Left;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	public void EJCDMEIMOEP(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 540f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.GLHBJNDMIDC(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADLOEKOAHFK));
		catNpc.walkTo.PEHELKCIECB();
	}

	private void OBGEJAADINP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM((Direction)7);
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Left);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
	}

	public void FNJODLOADKA()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void AFHBILLCDEP(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 1927f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DHFPOCOEONG(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FMEAFAADLPL));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void FIMIBFLFOGE(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 424f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.GHDMBFOAAHK(LAFNLCMIHHL, AHDHLIECIGH: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IHEHHCLJFDK));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FMEAFAADLPL));
		catNpc.walkTo.NOFKEMGPFEO();
	}

	public void GFLNGGGPGCF()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	public void GHMPKBJMHBA(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 326f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.GINPKMBGOFN(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CLOEFOFKDFC));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADLOEKOAHFK));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void HBPGCEKNHOH(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 247f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DHFPOCOEONG(LAFNLCMIHHL, AHDHLIECIGH: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HEEOHKBPMAI));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LBEBFFAHPAF));
		catNpc.walkTo.NOFKEMGPFEO();
	}

	private void NMDJOHBMAJE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Diagonal);
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM((Direction)5);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
	}

	public override void GFBLAEEOPAO()
	{
		if (catNpc.walkTo.IIMEFNIECLI())
		{
			if (Object.op_Implicit((Object)(object)petBowl))
			{
				if (!eating && ((isDrinking && petBowl.withWater) || (!isDrinking && petBowl.withFood)))
				{
					EHOJJEPMLNI();
					((Component)catNpc).transform.SetParent(((Component)petBowl).transform);
					catNpc.catAnimation.SetBool("Eating", EGFGNGJGBOP: true);
					eating = true;
					if (OnlineManager.IsMasterClient())
					{
						catNpc.onlineCat.SendSetBool("Eating", AODONKKHPBP: true);
					}
				}
				if (petBowl.placeable.FHEMHCEAICB)
				{
					catNpc.MinusRelationship(0, CDPAMNIPPEC: true);
					PDCLHMGJIMK();
				}
			}
			if (eating)
			{
				if (currentEatingTime < eatingTime)
				{
					currentEatingTime += Time.fixedDeltaTime;
				}
				else
				{
					PDCLHMGJIMK();
				}
			}
		}
		if (!eating && WorldTime.EDIPJBOOEHD > (float)(catNpc.stopEatingHour * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			catNpc.MinusRelationship(0, CDPAMNIPPEC: true);
			PDCLHMGJIMK();
		}
	}

	public void PDOBHPLPKHG()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.SendStartWalking();
		}
	}

	private void MAPPKEOMICE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM((Direction)6);
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM((Direction)6);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
	}

	public void EDDFAALFNGB()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void ADLOEKOAHFK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("");
		}
	}

	public void IHEHHCLJFDK()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void MAGDABOLFDI(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 294f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.HELOLJBENMK(LAFNLCMIHHL, AHDHLIECIGH: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HACNKBFKNHH));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KLGKLJABDME));
		catNpc.walkTo.PEHELKCIECB();
	}

	private void JAKECGMLHJN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger(":</color> ");
		}
	}

	public void KMFHAHKJHJP(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 269f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DHFPOCOEONG(LAFNLCMIHHL);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JLBMCMCCDNN));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LBEBFFAHPAF));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void DKFOJDHBGEJ(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 0f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.FNNPPBDFBCI(LAFNLCMIHHL, AHDHLIECIGH: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PDCLHMGJIMK));
		catNpc.walkTo.PEHELKCIECB();
	}

	private void NNMEEOKBILL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("path not found");
		}
	}

	private void JPHBIEKHHBD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM((Direction)6);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
	}

	private void DDMDFAIFHJI()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM((Direction)6);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Right;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	public void KPJAFINEDOJ(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 674f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DBHOIIIHIIM(LAFNLCMIHHL);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FNJODLOADKA));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KIJBNNFMOGF));
		catNpc.walkTo.EHDKLBLKBEO();
	}

	private void NCONPJIKCBB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)6;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	private void LBEBFFAHPAF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text");
		}
	}

	public void CLOEFOFKDFC()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void HKIEDFHDAJD(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 1017f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.GHDMBFOAAHK(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IHEHHCLJFDK));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PDCLHMGJIMK));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void NJCMNCBFCLE(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 399f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DBHOIIIHIIM(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GFLNGGGPGCF));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MOKBNCJHDID));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void CFJOGFDANJH(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 39f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.EJPGFOEDPBG(LAFNLCMIHHL);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EBLFKBEMCKL));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OBHFDPLPAGM));
		catNpc.walkTo.NOFKEMGPFEO();
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		base.DKFOJDHBGEJ();
		petBowl = null;
		currentEatingTime = 0f;
		eatingTime = 15f;
		petBowl = PetBowl.FindTheNearestPetBowl(((Component)catNpc).transform);
		if ((Object)(object)petBowl != (Object)null)
		{
			if (Random.Range(0, 2) == 0 && petBowl.withFood && petBowl.IsAnyPositionAvailable(BNPDMNCBJHL: false, GDCLFLFLFBM: true))
			{
				DKFOJDHBGEJ(petBowl.GetNearPosition(Vector2.op_Implicit(((Component)catNpc).transform.position), BNPDMNCBJHL: false, GDCLFLFLFBM: true));
				isDrinking = false;
			}
			else if (petBowl.withWater && petBowl.IsAnyPositionAvailable(BNPDMNCBJHL: true, GDCLFLFLFBM: true))
			{
				DKFOJDHBGEJ(petBowl.GetNearPosition(Vector2.op_Implicit(((Component)catNpc).transform.position), BNPDMNCBJHL: true, GDCLFLFLFBM: true));
				isDrinking = true;
			}
			else
			{
				PDCLHMGJIMK();
			}
		}
		else
		{
			PDCLHMGJIMK();
		}
	}

	public void OABPINLGOGK(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 379f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.JJDCANFBFMK(LAFNLCMIHHL);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HEEOHKBPMAI));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LBEBFFAHPAF));
		catNpc.walkTo.PEHELKCIECB();
	}

	private void KIJBNNFMOGF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("ReceiveSitDown");
		}
	}

	private void LBMKHJEIMFE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Down)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)8;
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)7;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Up);
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	public void DHGFHNALOAH(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 1795f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DHFPOCOEONG(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HACNKBFKNHH));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FDFOBDGPNLH));
		catNpc.walkTo.EHDKLBLKBEO();
	}

	public void GOEHKDDOGBP(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 731f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.JDHMPOJKOLF(LAFNLCMIHHL, AHDHLIECIGH: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IHEHHCLJFDK));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PLMIJFDHDNB));
		catNpc.walkTo.PEHELKCIECB();
	}

	private void EJBAHGKOBPP()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
			}
			else
			{
				catNpc.catAnimation.FCGBJEIIMBC = (Direction)7;
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	public void JKFEBEKOKCK(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 330f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.DHFPOCOEONG(LAFNLCMIHHL, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JLBMCMCCDNN));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GJPMEDFCILN));
		catNpc.walkTo.NOFKEMGPFEO();
	}

	public void EBLFKBEMCKL()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	public void FFAGAMOLPPC(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = true;
		catNpc.walkTo.followPlayerDistance = 1901f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.EJPGFOEDPBG(LAFNLCMIHHL, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JLBMCMCCDNN));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADLOEKOAHFK));
		catNpc.walkTo.PEHELKCIECB();
	}

	public void NHCAPCCBNAL()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			catNpc.onlineCat.BKBPKPJALKE();
		}
	}

	public void PHCNLDCGHHB(Vector2 LAFNLCMIHHL)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		catNpc.walkTo.speed = catNpc.speed;
		catNpc.walkTo.run = false;
		catNpc.walkTo.followPlayerDistance = 0f;
		catNpc.walkTo.runningSpeed = catNpc.speed;
		catNpc.walkTo.OGLJDLEGJAA(LAFNLCMIHHL);
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = catNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MEMMDHBLNBA));
		catNpc.walkTo.EHDKLBLKBEO();
	}

	public void HACNKBFKNHH()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void PLMIJFDHDNB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("city");
		}
	}

	public void JLBMCMCCDNN()
	{
		if (OnlineManager.IsMasterClient())
		{
			catNpc.onlineCat.LIEJPCHMABD();
		}
	}

	private void FDFOBDGPNLH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("/");
		}
	}

	private void FMEAFAADLPL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger(" (");
		}
	}

	private void MOKBNCJHDID()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("Item ");
		}
	}

	private void DMEMBAMNFJL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (petBowl.placeable.direction == Direction.Up || petBowl.placeable.direction == Direction.Up)
		{
			if (((Component)petBowl).transform.position.x > ((Component)catNpc).transform.position.x)
			{
				catNpc.catAnimation.FCGBJEIIMBC = Direction.Right;
			}
			else
			{
				catNpc.catAnimation.NCAJNNHBHJM(Direction.Left);
			}
		}
		else if (((Component)petBowl).transform.position.y > ((Component)catNpc).transform.position.y)
		{
			catNpc.catAnimation.FCGBJEIIMBC = Direction.Up;
		}
		else
		{
			catNpc.catAnimation.NCAJNNHBHJM(Direction.Down);
		}
	}

	private void GIHIDAECDBC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("Speed");
		}
	}

	private void PDCLHMGJIMK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			((Component)catNpc).transform.SetParent((Transform)null);
			animator.SetTrigger("Walk");
		}
	}
}
