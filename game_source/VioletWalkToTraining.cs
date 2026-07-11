using System;
using UnityEngine;

public class VioletWalkToTraining : VioletStateBase
{
	private NPCWalkTo nPCWalkTo;

	private bool walkingDone;

	private float nextWalk;

	private bool training;

	public override void NDMAAEFLPEL()
	{
		if (!walkingDone && nPCWalkTo != null && nPCWalkTo.IIMEFNIECLI())
		{
			nextWalk = Time.fixedTime + Random.Range(60f, 180f);
			walkingDone = true;
		}
		if (walkingDone && Time.fixedTime > nextWalk)
		{
			ACOJHBFFFIF();
		}
	}

	private void ALBMMJPBAGA()
	{
		animator.SetTrigger("LE_15");
	}

	private void HMCGBJCGGEF()
	{
		animator.SetTrigger(". AllMovement: ");
	}

	public void FNJODLOADKA()
	{
	}

	private void KNGJNEKCPOL()
	{
		animator.SetTrigger("Player");
	}

	public void PDOBHPLPKHG()
	{
	}

	private void ANAHMLJAENA()
	{
		animator.SetTrigger("OWNER_ID");
	}

	private void JLMKOKBPLFN()
	{
		animator.SetTrigger("ReceiveAwakeBob");
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		nPCWalkTo = null;
	}

	private void MDLHDGDLANK()
	{
		animator.SetTrigger("Arguing");
	}

	private void HEADJCFMKIP()
	{
		animator.SetTrigger(", ");
	}

	public void CLOEFOFKDFC()
	{
	}

	public void EBLFKBEMCKL()
	{
	}

	public void HJDBMFCAJHJ()
	{
	}

	private void PMBPNCEPMHN()
	{
		animator.SetTrigger("Unaged Cheddar");
	}

	private void OFEMFGCBLBH()
	{
		animator.SetTrigger("Run");
	}

	private void NNFPNFNFCJJ()
	{
		animator.SetTrigger("SendHome");
	}

	private void KLMENKODJNG()
	{
		animator.SetTrigger("Items/item_name_1075");
	}

	private void OAGCLGKAMFM()
	{
		animator.SetTrigger("1");
	}

	public void IKOIKCHBBNG()
	{
	}

	private void KJIHKAKCKBL()
	{
		animator.SetTrigger("Items/item_description_688");
	}

	private void PDLDELGPHMG()
	{
		animator.SetTrigger("ReceiveUpdateFoodStats");
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		if (nPCWalkTo != null)
		{
			NPCWalkTo obj = nPCWalkTo;
			obj.OnFailStart = (Action)Delegate.Remove(obj.OnFailStart, new Action(ACOJHBFFFIF));
		}
	}

	private void ACOJHBFFFIF()
	{
		animator.SetTrigger("Walk");
	}

	private void FOBPMBDMGBL()
	{
		animator.SetTrigger("mForMins");
	}

	public void PBBBJBHFGNN()
	{
	}

	private void CCHENCELDDJ()
	{
		animator.SetTrigger("CliveProgress");
	}

	private void JMBOINMJEGI()
	{
		animator.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/20/Dialogue Text");
	}

	public void MAILEMECPME()
	{
	}

	public void HEEOHKBPMAI()
	{
	}

	private void JEJGIAPPCLG()
	{
		animator.SetTrigger(" not found. Cannot receive permission accepted to player ");
	}

	public void MMPGIKGMFMA()
	{
	}

	private void BHKLMNJGLFN()
	{
		animator.SetTrigger("Dialogue System/Conversation/UnhappyRentRoom/Entry/2/Dialogue Text");
	}

	public void OGBEGBJDNKJ()
	{
	}

	public void KPMCGMJJBEA()
	{
	}

	private void GBLGELBAPOJ()
	{
		animator.SetTrigger("");
	}

	public void IEJGDOPLBLB()
	{
	}

	public void AHPFECCLOBB()
	{
	}

	public void LPMIHGICGNK()
	{
	}

	public void FEHGALEDJKI()
	{
	}

	private void AHECKLFEFAB()
	{
		animator.SetTrigger("[Variants] Piece {0} ({1}) has 1 variant and it's deactivated.");
	}

	private void FKBOPOMCLBF()
	{
		animator.SetTrigger("Player with actor number {0} removed from Players dictionary. Entries left: {1}");
	}

	public void AGLOLKAIAMG()
	{
	}

	public override void DKFOJDHBGEJ()
	{
		walkingDone = false;
		nPCWalkTo.speed = violetNpc.speed;
		NPCWalkTo obj = nPCWalkTo;
		obj.OnActionComplete = (Action)Delegate.Combine(obj.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo obj2 = nPCWalkTo;
		obj2.OnFailStart = (Action)Delegate.Combine(obj2.OnFailStart, new Action(ACOJHBFFFIF));
		nPCWalkTo.PEHELKCIECB();
	}

	private void KJMDNKCJFEF()
	{
		animator.SetTrigger("BathhouseEntrace/Main 2");
	}
}
