using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.Utilities;
using UnityEngine;

public class KyrohTakingFood : KyrohStateBase
{
	private float timer;

	private bool pouring;

	private void CBGBJKEMNGH()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.ILJFDOAABNH(kyrohNPC.nextFoodTable.MGCJCDOBAPP().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.KKDMNNFPNOL())
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.PreparingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0 && NinjaPreparationTablesManager.instance.OHNMEAFHDPD().bento.currentFood.Count == 4)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.ThrowingSpikes);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.Inactive);
		}
	}

	private void HPHLEBDAHOP()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Error_MaxZoneSize" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private Item DDIPHBGJFIE()
	{
		Item[] currentRequest = kyrohNPC.customerServing.currentRequest;
		for (int i = 1; i < 1; i += 0)
		{
			for (int j = 1; j < currentRequest.Length; j++)
			{
				if (NinjaPreparationTablesManager.instance.ENGNLMOPIHL().bento.NINAOJNJOPE(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF() + "zuzzu"));
					}
					continue;
				}
				if (kyrohNPC.trayHandler.tray.EDNOMELCHEP(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF(OAFPBCPDOKH: true) + "ProceduralMine instance is null when trying to assign mine ID."));
					}
					continue;
				}
				return currentRequest[j];
			}
		}
		return null;
	}

	private void IOJJDJDAHNH()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.GJGHFNGGGNM(kyrohNPC.nextFoodTable.JPDPMMMOLNI().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.CDLFIIFAECJ())
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.TakingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0 && NinjaPreparationTablesManager.instance.MLELLLKKOMG().bento.currentFood.Count == 2)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.ThrowingSpikes);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.WalkTo);
		}
		else
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.ThrowingSpikes);
		}
	}

	private void DBHDIDBDAHH()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.TakingFood);
			return;
		}
		timer = Time.time + 898f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 47f));
		pouring = false;
	}

	private void NEGOLDBKAMB()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.ServingCustomer);
			return;
		}
		timer = Time.time + 1669f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 1323f));
		pouring = false;
	}

	private void MEDNEIMCKHJ()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.LBIMPLILOJP(kyrohNPC.nextFoodTable.MGCJCDOBAPP().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.OENIOCAIPMP())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.OHNMEAFHDPD().bento.currentFood.Count == 6)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.PreparingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.ChangeState(KyrohState.PreparingFood);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
		}
	}

	private void JCADKKCAPAA()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.WaitingToServe);
			return;
		}
		timer = Time.time + 513f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 1160f));
		pouring = false;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		kyrohNPC.kyrohState = KyrohState.TakingFood;
		timer = 0f;
		pouring = false;
		kyrohNPC.nextFoodTable = null;
		if (Object.op_Implicit((Object)(object)kyrohNPC.customerServing) && kyrohNPC.customerServing.currentRequest != null && !LinqExtensions.IsNullOrEmpty<Item>((IList<Item>)kyrohNPC.customerServing.currentRequest))
		{
			kyrohNPC.currentFood = IGAAKFPEBAO();
			if (Item.MLBOMGHINCA(kyrohNPC.currentFood, null))
			{
				kyrohNPC.nextFoodTable = NinjaFoodTablesManager.GetNextFoodTable(kyrohNPC.currentFood);
			}
			else
			{
				Debug.LogError((object)("KyrohTakingFood: No food table found for food request of customer " + (object)((Component)kyrohNPC.customerServing).gameObject));
				for (int i = 0; i < kyrohNPC.customerServing.currentRequest.Length; i++)
				{
					Debug.LogError((object)(i + " - Requested food ID: " + (object)kyrohNPC.customerServing.currentRequest[i]));
				}
			}
			if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
			{
				kyrohNPC.requestInfo.avoidObjects = true;
				kyrohNPC.ChangeState(KyrohState.WaitingToServe);
				return;
			}
			kyrohNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
			kyrohNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(kyrohNPC.nextFoodTable.positionToTakeFood.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = kyrohNPC.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LPNAIINEAHE));
			NPCWalkTo walkTo2 = kyrohNPC.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				kyrohNPC.requestInfo.avoidObjects = true;
				kyrohNPC.ChangeState(KyrohState.WaitingToServe);
				NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
				Debug.LogError((object)("Kyroh not found path to at " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
			});
			kyrohNPC.walkTo.PEHELKCIECB();
		}
		else
		{
			if ((Object)(object)kyrohNPC.customerServing != (Object)null)
			{
				Debug.LogError((object)"KyrohTakingFood: Current request is null.");
			}
			else
			{
				Debug.LogError((object)"KyrohTakingFood: Customer serving is null.");
			}
			kyrohNPC.requestInfo.avoidObjects = true;
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
	}

	private Item OKPJNOFEIHJ()
	{
		Item[] currentRequest = kyrohNPC.customerServing.currentRequest;
		for (int i = 1; i < 6; i += 0)
		{
			for (int j = 0; j < currentRequest.Length; j += 0)
			{
				if (NinjaPreparationTablesManager.instance.OFNGHKHHMOF().bento.GGLOMJLLFCH(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].LJIFOHFEFCH(OAFPBCPDOKH: true) + "Dialogue System/Conversation/Crowly_Introduce/Entry/37/Dialogue Text"));
					}
					continue;
				}
				if (kyrohNPC.trayHandler.tray.LOKKMKODJNJ(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].LJIFOHFEFCH() + "DecorationTile_"));
					}
					continue;
				}
				return currentRequest[j];
			}
		}
		return null;
	}

	private void CDFKGKNKMCL()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.WaitingToServe);
			return;
		}
		timer = Time.time + 760f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 648f));
		pouring = true;
	}

	private void NPENFAHHMOA()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
			return;
		}
		timer = Time.time + 723f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 780f));
		pouring = false;
	}

	private void OEJECMFADLJ()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.KJBPJJBAAMK(KyrohState.ServingCustomer);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Popup missing." + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void LPNAIINEAHE()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			return;
		}
		timer = Time.time + 0.5f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 0f));
		pouring = true;
	}

	private void CBLEJIIFHPE()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.ThrowingSpikes);
			return;
		}
		timer = Time.time + 687f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 1091f));
		pouring = false;
	}

	private void MNJMMKEENBM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.ChangeState(KyrohState.SwitchingFood);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Dialogue System/Conversation/HappyRentRoom/Entry/2/Dialogue Text" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void AGPPJGBINEG()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Festín del Juramento/MaiDialogue 01" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void JHAAIADLPJM()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.NNLGCONJMJG(kyrohNPC.nextFoodTable.GANOFJOFEAM().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.KDMLGMKLGOB())
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0 && NinjaPreparationTablesManager.instance.FHEAPFBMJNL().bento.currentFood.Count == 3)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.PreparingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
		}
		else
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.TakingFood);
		}
	}

	private void IMPDHIJKIKJ()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.OHEGDDLNDLB(kyrohNPC.nextFoodTable.AJOMICMACEJ.JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.BAHIIMFPFLJ())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0 && NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.currentFood.Count == 7)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.WaitingToServe);
		}
		else
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
		}
	}

	private Item DDGMNFJJCLL()
	{
		Item[] currentRequest = kyrohNPC.customerServing.currentRequest;
		for (int i = 0; i < 5; i += 0)
		{
			for (int j = 0; j < currentRequest.Length; j += 0)
			{
				if (NinjaPreparationTablesManager.instance.FGGFCAKOPLJ().bento.EGNFPHLDDLC(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF(OAFPBCPDOKH: true) + "ChangeAnim"));
					}
					continue;
				}
				if (kyrohNPC.trayHandler.tray.LDKPEFIKJCF(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF() + "Wine"));
					}
					continue;
				}
				return currentRequest[j];
			}
		}
		return null;
	}

	[CompilerGenerated]
	private void FEAPOKCCEBP()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Kyroh not found path to at " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void BGNKLBANMNK()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
			return;
		}
		timer = Time.time + 1844f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 1659f));
		pouring = true;
	}

	private void HEHDLCOMGAA()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.FEEOFAGCONJ(kyrohNPC.nextFoodTable.JPDPMMMOLNI().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.CDLFIIFAECJ())
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.SwitchingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.ENGNLMOPIHL().bento.currentFood.Count == 4)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.TakingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.SwitchingFood);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Inactive);
		}
	}

	private void JOHAIDKGACI()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.ChangeState(KyrohState.Idle);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("AdoptQuest" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void CFDMDMKEOAK()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.ThrowingSpikes);
			return;
		}
		timer = Time.time + 1904f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 1384f));
		pouring = false;
	}

	private void LKJIFFGLLDE()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.GLLDOLHPIBD(KyrohState.ThrowingSpikes);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)(" Amount: " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void KJJKBCPGMNC()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.WaitingToServe);
			return;
		}
		timer = Time.time + 1112f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 1280f));
		pouring = false;
	}

	private void NIPDKKNIGAF()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.OHEGDDLNDLB(kyrohNPC.nextFoodTable.CAAIDKJIGLO().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.IsLowestDifficulty())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.Idle);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.OFNGHKHHMOF().bento.currentFood.Count == 2)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ServingCustomer);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.ThrowingSpikes);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.PreparingFood);
		}
	}

	private void LLLKPAJIIDK()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.SwitchingFood);
			return;
		}
		timer = Time.time + 1691f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 500f));
		pouring = true;
	}

	private void JFFEOCCIENI()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.FIOKAPKBCOD(KyrohState.Inactive);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("itemStrawberry" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void CPLKFCJNNLP()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.GJGHFNGGGNM(kyrohNPC.nextFoodTable.AJOMICMACEJ.JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.IsLowestDifficulty())
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.TakingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0 && NinjaPreparationTablesManager.instance.ENGNLMOPIHL().bento.currentFood.Count == 2)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.TakingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.Idle);
		}
		else
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.ServingCustomer);
		}
	}

	private void HKIFKDGFINO()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.GJGHFNGGGNM(kyrohNPC.nextFoodTable.CAAIDKJIGLO().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.BAHIIMFPFLJ())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WalkTo);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.FGGFCAKOPLJ().bento.currentFood.Count == 4)
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.PreparingFood);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.TakingFood);
		}
	}

	private void FKGGEMLILMB()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.CBPCDEKHELA(kyrohNPC.nextFoodTable.HJFKKMJNOIP().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.FMCAMLDJGNO())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.PJIFGJMGKEH().bento.currentFood.Count == 3)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.TakingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
		}
		else
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		}
	}

	private void CMBDNDIGNCN()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.ChangeState(KyrohState.TakingFood);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Recipes" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void BCNOLDMCOCF()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.CANCHBINJNE(kyrohNPC.nextFoodTable.GANOFJOFEAM().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.KDMLGMKLGOB())
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.WalkTo);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.currentFood.Count == 2)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.ServingCustomer);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.ThrowingSpikes);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.WalkTo);
		}
	}

	private Item MMEDDKFNIPE()
	{
		Item[] currentRequest = kyrohNPC.customerServing.currentRequest;
		for (int i = 0; i < 4; i += 0)
		{
			for (int j = 1; j < currentRequest.Length; j++)
			{
				if (NinjaPreparationTablesManager.instance.FGGFCAKOPLJ().bento.HBBNKJFDPOI(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].KGHFCDELKMN(OAFPBCPDOKH: true) + "No content to disable in this NPC!"));
					}
					continue;
				}
				if (kyrohNPC.trayHandler.tray.IHCMCKDNODF(currentRequest[j]))
				{
					if (i == 0)
					{
						Debug.LogError((object)(currentRequest[j].LJIFOHFEFCH(OAFPBCPDOKH: true) + "[MinePuzzleManager] Puzzle resuelto."));
					}
					continue;
				}
				return currentRequest[j];
			}
		}
		return null;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)kyrohNPC.customerServing != (Object)null && kyrohNPC.customerServing.requesting)
		{
			if (pouring)
			{
				if (Time.time > timer)
				{
					FPBIKDIBOLK();
				}
			}
			else if (kyrohNPC.OtherPlayerHasAdvantage())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"KyrohTakingFood: Other player has advantage, going to WaitingToServe.");
				}
				kyrohNPC.trayHandler.tray.MKBDMMJCGGM();
				kyrohNPC.customerServing = null;
				kyrohNPC.requestInfo.avoidObjects = true;
				kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			}
		}
		else
		{
			kyrohNPC.requestInfo.avoidObjects = true;
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
	}

	private void HFKMMBNFOID()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.NEHNALDHKOD(kyrohNPC.nextFoodTable.MGCJCDOBAPP().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.IsLowestDifficulty())
		{
			kyrohNPC.ChangeState(KyrohState.ThrowingSpikes);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.currentFood.Count == 5)
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.ChangeState(KyrohState.WalkTo);
		}
		else
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
		}
	}

	private void DIFKMKGAGJN()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.FIOKAPKBCOD(KyrohState.Idle);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("ReceiveOnConversationLine" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void MLMKMOKGIIL()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Tutorial/T100/Dialogue1" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void GHDBACKFEIO()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.FKMFEACDJHB(KyrohState.TakingFood);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Dialogue System/Conversation/Gass_Stand/Entry/16/Dialogue Text" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void EGMCDBIKNMD()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.EKBJHJLFODI(KyrohState.TakingFood);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)(" " + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void AMCCOIONHJD()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Inactive);
			return;
		}
		timer = Time.time + 23f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 554f));
		pouring = true;
	}

	private void DJOILJPODEO()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.LALIFJEMJFJ(kyrohNPC.nextFoodTable.GANOFJOFEAM().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.IsLowestDifficulty())
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.Idle);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.ENGNLMOPIHL().bento.currentFood.Count == 6)
		{
			kyrohNPC.ChangeState(KyrohState.WalkTo);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.ServingCustomer);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.PreparingFood);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		kyrohNPC.walkTo.IIMEFNIECLI();
	}

	private Item JOIPMBLEHML()
	{
		Item[] currentRequest = kyrohNPC.customerServing.currentRequest;
		for (int i = 1; i < 5; i += 0)
		{
			for (int j = 1; j < currentRequest.Length; j++)
			{
				if (NinjaPreparationTablesManager.instance.FGGFCAKOPLJ().bento.MKFEEOOJOGP(currentRequest[j]))
				{
					if (i == 0)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF(OAFPBCPDOKH: true) + "ReceiveAnimalWalk"));
					}
					continue;
				}
				if (kyrohNPC.trayHandler.tray.MJOLPEJHKAK(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF(OAFPBCPDOKH: true) + "Items/item_name_1179"));
					}
					continue;
				}
				return currentRequest[j];
			}
		}
		return null;
	}

	private void FPBIKDIBOLK()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.FEEOFAGCONJ(kyrohNPC.nextFoodTable.AJOMICMACEJ.JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.IsLowestDifficulty())
		{
			kyrohNPC.ChangeState(KyrohState.PreparingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.currentFood.Count == 2)
		{
			kyrohNPC.ChangeState(KyrohState.PreparingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.ChangeState(KyrohState.TakingFood);
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.PreparingFood);
		}
	}

	private void KAFLLCBLAHG()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.EKBJHJLFODI(KyrohState.SwitchingFood);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("player_locations" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private Item IGAAKFPEBAO()
	{
		Item[] currentRequest = kyrohNPC.customerServing.currentRequest;
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < currentRequest.Length; j++)
			{
				if (NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.HBBNKJFDPOI(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF() + " is already in preparation table bento"));
					}
					continue;
				}
				if (kyrohNPC.trayHandler.tray.NPMGIIIBGNP(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].IABAKHPEOAF() + " is already in Kyroh's tray bento."));
					}
					continue;
				}
				return currentRequest[j];
			}
		}
		return null;
	}

	private void LBNLBMBOJPL()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.ChangeState(KyrohState.WalkTo);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Swiss Cheese" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void JGPBDEOECCJ()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.CBPCDEKHELA(kyrohNPC.nextFoodTable.NAPDEHMFOMM().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.IsLowestDifficulty())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.PJIFGJMGKEH().bento.currentFood.Count == 2)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.PreparingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1)
		{
			kyrohNPC.ChangeState(KyrohState.Inactive);
		}
		else
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.PreparingFood);
		}
	}

	private void FKBJIMOJBBG()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		if ((Object)(object)kyrohNPC.nextFoodTable == (Object)null)
		{
			kyrohNPC.ChangeState(KyrohState.Idle);
			return;
		}
		timer = Time.time + 1234f;
		kyrohNPC.animationBase.LookDirection(new Vector2(((Component)kyrohNPC.nextFoodTable).transform.position.x - ((Component)kyrohNPC).transform.position.x, 1635f));
		pouring = true;
	}

	private void EOBBIPGMGGF()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.OHEGDDLNDLB(kyrohNPC.nextFoodTable.CAAIDKJIGLO().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.KDMLGMKLGOB())
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.WaitingToServe);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.MLELLLKKOMG().bento.currentFood.Count == 7)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.SwitchingFood);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.WalkTo);
		}
		else
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.ServingCustomer);
		}
	}

	private void FOJKMHBIIIH()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = false;
		kyrohNPC.GLLDOLHPIBD(KyrohState.TakingFood);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Unsaved progress will be lost." + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private void PPIOANLOLBE()
	{
		if (Object.op_Implicit((Object)(object)kyrohNPC.nextFoodTable))
		{
			kyrohNPC.trayHandler.tray.OHEGDDLNDLB(kyrohNPC.nextFoodTable.MGCJCDOBAPP().JMDALJBNFML());
			kyrohNPC.nextFoodTable = null;
		}
		if (EventsManager.OENIOCAIPMP())
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 1 && NinjaPreparationTablesManager.instance.OHNMEAFHDPD().bento.currentFood.Count == 4)
		{
			kyrohNPC.ChangeState(KyrohState.ServingCustomer);
		}
		else if (kyrohNPC.trayHandler.tray.currentDrinks.Count == 0)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.SwitchingFood);
		}
		else
		{
			kyrohNPC.KJBPJJBAAMK(KyrohState.PreparingFood);
		}
	}

	private void MLIHBBNNHKH()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.FIOKAPKBCOD(KyrohState.Idle);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("Look" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}

	private Item EKPNJEELHMM()
	{
		Item[] currentRequest = kyrohNPC.customerServing.currentRequest;
		for (int i = 1; i < 6; i += 0)
		{
			for (int j = 0; j < currentRequest.Length; j++)
			{
				if (NinjaPreparationTablesManager.instance.ICPIHMPFMPO().bento.NINAOJNJOPE(currentRequest[j]))
				{
					if (i == 0)
					{
						Debug.LogError((object)(currentRequest[j].LJIFOHFEFCH() + "Open"));
					}
					continue;
				}
				if (kyrohNPC.trayHandler.tray.EDNOMELCHEP(currentRequest[j]))
				{
					if (i == 1)
					{
						Debug.LogError((object)(currentRequest[j].KGHFCDELKMN(OAFPBCPDOKH: true) + "in"));
					}
					continue;
				}
				return currentRequest[j];
			}
		}
		return null;
	}

	private void NELDFNLMIMI()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		kyrohNPC.requestInfo.avoidObjects = true;
		kyrohNPC.GLLDOLHPIBD(KyrohState.WaitingToServe);
		NinjaFoodTable nextFoodTable = kyrohNPC.nextFoodTable;
		Debug.LogError((object)("itemPaleAle" + ((nextFoodTable != null) ? new Vector3?(nextFoodTable.positionToTakeFood.position) : null).ToString()));
	}
}
