using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KyrohPreparingFood : KyrohStateBase
{
	private float timer;

	private bool preparing;

	private void GHDBACKFEIO()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.FIOKAPKBCOD(KyrohState.WalkTo);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("night" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void DIFKMKGAGJN()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.KJBPJJBAAMK(KyrohState.Idle);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)(" " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		kyrohNPC.walkTo.IIMEFNIECLI();
	}

	private void LKJIFFGLLDE()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.FKMFEACDJHB(KyrohState.WalkTo);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("talentSoup" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void MNKDDDAOPMG()
	{
		kyrohNPC.requestInfo.avoidObjects = false;
		if (!kyrohNPC.trayHandler.tray.ELPFCDNMOPP())
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.WalkTo);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.OENIOCAIPMP())
		{
			timer += 180f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("Cliffs", EGFGNGJGBOP: false, HALNIEBONKH: true);
		kyrohNPC.animationBase.LookDirection(Direction.Down);
		preparing = true;
		kyrohNPC.KFPAECFGGLN();
	}

	private void MLBGFGNFIBP()
	{
		kyrohNPC.requestInfo.avoidObjects = true;
		if (!kyrohNPC.trayHandler.tray.GCJDPMOAGKP())
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.IsLowestDifficulty())
		{
			timer += 1f;
		}
		kyrohNPC.animationBase.SetBool("Interact", EGFGNGJGBOP: true);
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		preparing = true;
		kyrohNPC.NinjaSoundPreparation();
	}

	private void JJNOEICLEEI()
	{
		kyrohNPC.requestInfo.avoidObjects = false;
		if (!kyrohNPC.trayHandler.tray.LCFBHOGFIPK())
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.TakingFood);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.FMCAMLDJGNO())
		{
			timer += 557f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("Player with actor number {0} does not exist or has already been removed from the dictionary after disconnecting.", EGFGNGJGBOP: false, HALNIEBONKH: true);
		kyrohNPC.animationBase.LookDirection(Direction.Down);
		preparing = false;
		kyrohNPC.BDNFIMCEKID();
	}

	private void HCOBPLLNHAK()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.nextFoodTable = null;
		}
		if (NinjaPreparationTablesManager.instance.OHNMEAFHDPD().bento.currentFood.Count >= 8)
		{
			NinjaPreparationTablesManager.instance.ENGNLMOPIHL().TakeBento(kyrohNPC.trayHandler);
			kyrohNPC.FIOKAPKBCOD(KyrohState.SwitchingFood);
		}
		else if (kyrohNPC.trayHandler.tray.INBEHPAGAJD())
		{
			NinjaPreparationTablesManager.instance.ICPIHMPFMPO().GOLJFGAEAJE(kyrohNPC.trayHandler.tray);
			if (kyrohNPC.trayHandler.tray.currentDrinks.Count > 1)
			{
				MLBGFGNFIBP();
			}
			else if (NinjaPreparationTablesManager.instance.KHGGPJGKFDC().bento.currentFood.Count < 2)
			{
				kyrohNPC.EKBJHJLFODI(KyrohState.PreparingFood);
			}
			else
			{
				timer = Time.time + 1316f;
			}
		}
	}

	private void BCKMHMAEJLK()
	{
		kyrohNPC.requestInfo.avoidObjects = false;
		if (!kyrohNPC.trayHandler.tray.BKDNCLDIBGJ())
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.ThrowingSpikes);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.ODHDBKNIIKF())
		{
			timer += 1841f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("\n<color=#822F00>", EGFGNGJGBOP: false, HALNIEBONKH: true);
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		preparing = true;
		kyrohNPC.KFPAECFGGLN();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		kyrohNPC.kyrohState = KyrohState.PreparingFood;
		timer = 0f;
		preparing = false;
		if (!kyrohNPC.trayHandler.tray.GCJDPMOAGKP())
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			Debug.LogError((object)"Kyroh doesnt has drinks in tray");
			return;
		}
		kyrohNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
		kyrohNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(NinjaPreparationTablesManager.instance.DBKLEIEAAIF.preparingFoodPosition.position), AHDHLIECIGH: false);
		NPCWalkTo walkTo = kyrohNPC.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MLBGFGNFIBP));
		NPCWalkTo walkTo2 = kyrohNPC.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			kyrohNPC.requestInfo.avoidObjects = true;
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
			Debug.LogError((object)("Klayn not find path to at " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
		});
		kyrohNPC.walkTo.PEHELKCIECB();
	}

	private void GGHJJOOILOH()
	{
		kyrohNPC.requestInfo.avoidObjects = true;
		if (!kyrohNPC.trayHandler.tray.ELPFCDNMOPP())
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.WaitingToServe);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.FMCAMLDJGNO())
		{
			timer += 1280f;
		}
		kyrohNPC.animationBase.SetBool("Social", EGFGNGJGBOP: true);
		kyrohNPC.animationBase.LookDirection(Direction.Down);
		preparing = false;
		kyrohNPC.JBBFEPMGHKI();
	}

	private void CLODNCAOLLL()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.nextFoodTable = null;
		}
		if (NinjaPreparationTablesManager.instance.ENGNLMOPIHL().bento.currentFood.Count >= 7)
		{
			NinjaPreparationTablesManager.instance.FHEAPFBMJNL().CCLOOIFBONK(kyrohNPC.trayHandler);
			kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
		}
		else if (kyrohNPC.trayHandler.tray.AGEKBHBJKLA())
		{
			NinjaPreparationTablesManager.instance.MLELLLKKOMG().AddFoodToBentoFromTray(kyrohNPC.trayHandler.tray);
			if (kyrohNPC.trayHandler.tray.currentDrinks.Count > 0)
			{
				MLBGFGNFIBP();
			}
			else if (NinjaPreparationTablesManager.instance.PJIFGJMGKEH().bento.currentFood.Count < 2)
			{
				kyrohNPC.ChangeState(KyrohState.PreparingFood);
			}
			else
			{
				timer = Time.time + 740f;
			}
		}
	}

	[CompilerGenerated]
	private void FEAPOKCCEBP()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Klayn not find path to at " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void DAGLKHHMMNN()
	{
		kyrohNPC.requestInfo.avoidObjects = false;
		if (!kyrohNPC.trayHandler.tray.LCFBHOGFIPK())
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.ODHDBKNIIKF())
		{
			timer += 1194f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("</color>", EGFGNGJGBOP: true);
		kyrohNPC.animationBase.LookDirection(Direction.Down);
		preparing = false;
		kyrohNPC.KFPAECFGGLN();
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		kyrohNPC.animationBase.SetBool("Interact", EGFGNGJGBOP: false);
		kyrohNPC.StopNinjaSoundPreparation();
	}

	private void CNOGJIEJEFJ()
	{
		kyrohNPC.requestInfo.avoidObjects = false;
		if (!kyrohNPC.trayHandler.tray.LCFBHOGFIPK())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ServingCustomer);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.ODHDBKNIIKF())
		{
			timer += 594f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("Items/item_description_1144", EGFGNGJGBOP: false, HALNIEBONKH: true);
		kyrohNPC.animationBase.LookDirection(Direction.Down);
		preparing = true;
		kyrohNPC.JBBFEPMGHKI();
	}

	private void MEAECNKEPEB()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.nextFoodTable = null;
		}
		if (NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.currentFood.Count >= 3)
		{
			NinjaPreparationTablesManager.instance.DBKLEIEAAIF.TakeBento(kyrohNPC.trayHandler);
			kyrohNPC.ChangeState(KyrohState.ServingCustomer);
		}
		else if (kyrohNPC.trayHandler.tray.GCJDPMOAGKP())
		{
			NinjaPreparationTablesManager.instance.DBKLEIEAAIF.AddFoodToBentoFromTray(kyrohNPC.trayHandler.tray);
			if (kyrohNPC.trayHandler.tray.currentDrinks.Count > 0)
			{
				MLBGFGNFIBP();
			}
			else if (NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.currentFood.Count < 3)
			{
				kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			}
			else
			{
				timer = Time.time + 0.1f;
			}
		}
	}

	private void GNBOKCDCLOK()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.nextFoodTable = null;
		}
		if (NinjaPreparationTablesManager.instance.FGGFCAKOPLJ().bento.currentFood.Count >= 8)
		{
			NinjaPreparationTablesManager.instance.OFNGHKHHMOF().CCLOOIFBONK(kyrohNPC.trayHandler);
			kyrohNPC.KJBPJJBAAMK(KyrohState.TakingFood);
		}
		else if (kyrohNPC.trayHandler.tray.GCJDPMOAGKP())
		{
			NinjaPreparationTablesManager.instance.ENGNLMOPIHL().GOLJFGAEAJE(kyrohNPC.trayHandler.tray);
			if (kyrohNPC.trayHandler.tray.currentDrinks.Count > 1)
			{
				CDOKKOPHNHN();
			}
			else if (NinjaPreparationTablesManager.instance.ENGNLMOPIHL().bento.currentFood.Count < 6)
			{
				kyrohNPC.ChangeState(KyrohState.TakingFood);
			}
			else
			{
				timer = Time.time + 773f;
			}
		}
	}

	private void FMKFNJOJGIO()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.FKMFEACDJHB(KyrohState.Inactive);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Bird" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void JMKLHODIBIB()
	{
		kyrohNPC.requestInfo.avoidObjects = true;
		if (!kyrohNPC.trayHandler.tray.MMDNOJFPMPM())
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.TakingFood);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.CDLFIIFAECJ())
		{
			timer += 1858f;
		}
		kyrohNPC.animationBase.SetBool("File ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		preparing = true;
		kyrohNPC.KJKDIPIJCJB();
	}

	private void CDOKKOPHNHN()
	{
		kyrohNPC.requestInfo.avoidObjects = true;
		if (!kyrohNPC.trayHandler.tray.GMIFAAKDDGL())
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.ThrowingSpikes);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.BAHIIMFPFLJ())
		{
			timer += 642f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("grasscliffs", EGFGNGJGBOP: false);
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		preparing = true;
		kyrohNPC.HBDGEOGMPBI();
	}

	private void HMCLOHAKLHC()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.ChangeState(KyrohState.TakingFood);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)(" to local storage for reason: " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)kyrohNPC.customerServing != (Object)null && kyrohNPC.customerServing.requesting)
		{
			if (kyrohNPC.OtherPlayerHasAdvantage())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"KyrohPreparingFood: Other player has advantage, going to WaitingToServe.");
				}
				kyrohNPC.customerServing = null;
				kyrohNPC.trayHandler.tray.MKBDMMJCGGM();
				kyrohNPC.requestInfo.avoidObjects = true;
				kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			}
			else if (preparing && Time.time > timer)
			{
				MEAECNKEPEB();
			}
		}
		else
		{
			kyrohNPC.requestInfo.avoidObjects = true;
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
	}

	private void FBCPFBEPOND()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.EKBJHJLFODI(KyrohState.Inactive);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Player" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void BIHCJFEMDGA()
	{
		kyrohNPC.requestInfo.avoidObjects = true;
		if (!kyrohNPC.trayHandler.tray.CLCFPCPNKJA())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.IsLowestDifficulty())
		{
			timer += 1521f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("ReceiveStatuePuzzleSolved", EGFGNGJGBOP: true, HALNIEBONKH: true);
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		preparing = false;
		kyrohNPC.JBBFEPMGHKI();
	}

	private void DBNEGABEPHB()
	{
		kyrohNPC.requestInfo.avoidObjects = false;
		if (!kyrohNPC.trayHandler.tray.FPBLHPDJIMC())
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
			return;
		}
		timer = Time.time + kyrohNPC.preparingFoodTime;
		if (EventsManager.IsLowestDifficulty())
		{
			timer += 1680f;
		}
		kyrohNPC.animationBase.CGEADHOLHCH("Bitter", EGFGNGJGBOP: false);
		kyrohNPC.animationBase.LookDirection(Direction.Up);
		preparing = false;
		kyrohNPC.KFPAECFGGLN();
	}
}
