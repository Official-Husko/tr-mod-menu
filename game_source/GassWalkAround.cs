using System;
using UnityEngine;

public class GassWalkAround : GassStateBase
{
	private bool walkingDone;

	private float nextWalk;

	public void NHCAPCCBNAL()
	{
		nextWalk = Time.time + Random.Range(1390f, 892f);
	}

	public void IDBCMIMFHJC()
	{
		nextWalk = Time.time + Random.Range(879f, 1652f);
	}

	public void PKCODIDOBJO()
	{
		nextWalk = Time.time + Random.Range(1099f, 1158f);
	}

	private void PMBPNCEPMHN()
	{
		animator.SetTrigger(" ");
	}

	public void GNLIBMPMCIH()
	{
		nextWalk = Time.time + Random.Range(1738f, 1141f);
	}

	private void GBLGELBAPOJ()
	{
		animator.SetTrigger("Style");
	}

	private void KLMENKODJNG()
	{
		animator.SetTrigger("</color>");
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		NPCWalkTo walkTo = gassNpc.walkTo;
		walkTo.OnFailStart = (Action)Delegate.Remove(walkTo.OnFailStart, new Action(ACOJHBFFFIF));
	}

	public void GFLNGGGPGCF()
	{
		nextWalk = Time.time + Random.Range(301f, 1705f);
	}

	public void HACNKBFKNHH()
	{
		nextWalk = Time.time + Random.Range(129f, 546f);
	}

	public void CLOEFOFKDFC()
	{
		nextWalk = Time.time + Random.Range(1864f, 485f);
	}

	public void BEEDFJOOPAH()
	{
		nextWalk = Time.time + Random.Range(1338f, 1121f);
	}

	public void PBBBJBHFGNN()
	{
		nextWalk = Time.time + Random.Range(1875f, 671f);
	}

	public void LPMIHGICGNK()
	{
		nextWalk = Time.time + Random.Range(1508f, 1155f);
	}

	public void AHPFECCLOBB()
	{
		nextWalk = Time.time + Random.Range(1812f, 43f);
	}

	private void BOOBKGLCDFK()
	{
		animator.SetTrigger("Items/item_name_607");
	}

	private void JEJGIAPPCLG()
	{
		animator.SetTrigger("Plant");
	}

	public void EBLFKBEMCKL()
	{
		nextWalk = Time.time + Random.Range(1939f, 1832f);
	}

	private void NAKLGHHDBAN()
	{
		animator.SetTrigger(":</color> ");
	}

	private void KNGJNEKCPOL()
	{
		animator.SetTrigger("Hold\nIntensity");
	}

	public void IHEHHCLJFDK()
	{
		nextWalk = Time.time + Random.Range(842f, 1600f);
	}

	private void JMBOINMJEGI()
	{
		animator.SetTrigger("Player2");
	}

	private void ACOJHBFFFIF()
	{
		animator.SetTrigger("Walk");
	}

	private void JLMKOKBPLFN()
	{
		animator.SetTrigger("BetterDuringTwoMonths");
	}

	private void EILPPGGCANE()
	{
		animator.SetTrigger("Items/item_name_622");
	}

	private void MJDFKJBFMPO()
	{
		animator.SetTrigger("LE_19");
	}

	public void IKOIKCHBBNG()
	{
		nextWalk = Time.time + Random.Range(1617f, 217f);
	}

	public void AGLDNOHPHFD()
	{
		nextWalk = Time.time + Random.Range(1314f, 1993f);
	}

	private void BHKLMNJGLFN()
	{
		animator.SetTrigger("cornHarvested");
	}

	public override void DLKMCEIBAFG()
	{
		if (!walkingDone && gassNpc.walkTo.IIMEFNIECLI())
		{
			nextWalk = Time.fixedTime + Random.Range(2f, 10f);
			walkingDone = true;
		}
		if (walkingDone && Time.fixedTime > nextWalk)
		{
			ACOJHBFFFIF();
		}
	}

	public override void DKFOJDHBGEJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		walkingDone = false;
		gassNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(gassNpc.walkPoints[Random.Range(0, gassNpc.walkPoints.Length)].transform.position));
		gassNpc.walkTo.speed = gassNpc.speed;
		NPCWalkTo walkTo = gassNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = gassNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		gassNpc.walkTo.PEHELKCIECB();
	}

	private void CCHENCELDDJ()
	{
		animator.SetTrigger("Cannot load old character saved");
	}

	private void FKBOPOMCLBF()
	{
		animator.SetTrigger("/Localisation.txt");
	}

	private void KJMDNKCJFEF()
	{
		animator.SetTrigger("Invalid item");
	}

	private void OKOKOMPNFDF()
	{
		animator.SetTrigger(":<color=#3a0603> +");
	}

	private void FOBPMBDMGBL()
	{
		animator.SetTrigger("Unique ID not set for online rock ");
	}

	private void GONBDDJHANF()
	{
		animator.SetTrigger("\n");
	}

	private void HMCGBJCGGEF()
	{
		animator.SetTrigger("Items/item_name_597");
	}

	private void ANAHMLJAENA()
	{
		animator.SetTrigger("Farm/Buzz/Door_Bark_Searching");
	}

	private void PBMBOPDALGD()
	{
		animator.SetTrigger("Dog");
	}

	private void DKDBFNCODIK()
	{
		animator.SetTrigger("Dialogue System/Conversation/EnterTavernFood/Entry/1/Dialogue Text");
	}

	public void HEEOHKBPMAI()
	{
		nextWalk = Time.time + Random.Range(589f, 1860f);
	}

	public void KPMCGMJJBEA()
	{
		nextWalk = Time.time + Random.Range(1333f, 355f);
	}

	private void NNFPNFNFCJJ()
	{
		animator.SetTrigger("</color>");
	}

	public void MMHIOJMIJMP()
	{
		nextWalk = Time.time + Random.Range(940f, 278f);
	}

	public void PDOBHPLPKHG()
	{
		nextWalk = Time.time + Random.Range(2f, 4f);
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		DKFOJDHBGEJ();
	}

	private void OAGCLGKAMFM()
	{
		animator.SetTrigger("00");
	}
}
