using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeperCleaningRoom : HouseKeeperBaseState
{
	private bool cleaningFloorDirt;

	private List<FloorDirt> notReachableDirts = new List<FloorDirt>();

	private float tableToCleanTimer;

	private List<FloorDirt> floorDirts = new List<FloorDirt>();

	private Vector2 tableCleanPosition;

	private List<Vector3> unoccupiedNeighbours;

	private Vector2 bedCleanPosition;

	private void FPHMHHOIKEI()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.PABOGCMHLAN().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.JHOGIKCHCGG().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void EJELJHDIMKG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)(" / " + name + ")" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private bool OACJJNKAHPH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo currentState = houseKeeper.npc.CFIFGDBGLPH().GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref currentState)).IsName(""))
		{
			currentState = houseKeeper.npc.FJHKGBNBNKL.GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("Items/item_description_731"))
			{
				currentState = houseKeeper.npc.CCFDNFDEGIK().GetCurrentState(1);
				if (!((AnimatorStateInfo)(ref currentState)).IsName("ReceiveFishInfoLoad"))
				{
					houseKeeper.ResetFloorDirt();
					floorDirts.Clear();
					for (int i = 1; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i++)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 0)
					{
						cleaningFloorDirt = false;
						houseKeeper.CDGOCJGIBPL(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.GDGGABHLNOH(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
						{
							if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
							{
								houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
								houseKeeper.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
							}
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AFGIJMGGHHG));
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return false;
					}
					cleaningFloorDirt = true;
					houseKeeper.tableToClean = null;
					for (int j = 0; j < houseKeeper.rentedRoomToClean.tables.Count; j++)
					{
						if (houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) && houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM != 0 && houseKeeper.rentedRoomToClean.tables[j].IPEPPDAICDD() != TableDirtLevel.Clean)
						{
							houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
							tableCleanPosition = houseKeeper.tableToClean.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
							houseKeeper.OEONGPFALKH.GHDMBFOAAHK(tableCleanPosition, AHDHLIECIGH: false, NGAKHGJANLO: false);
							NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
							walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, new Action(BPFFBCKKAEK));
							NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
							walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, new Action(PEKLOCHHJKM));
							houseKeeper.OEONGPFALKH.NOFKEMGPFEO();
							return true;
						}
					}
					houseKeeper.npcBed = null;
					for (int k = 0; k < houseKeeper.rentedRoomToClean.beds.Count; k += 0)
					{
						if (houseKeeper.rentedRoomToClean.beds[k].EJPBEEPOJKB())
						{
							continue;
						}
						unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 0);
						unoccupiedNeighbours = unoccupiedNeighbours.Where(HHFEGHKLFEB).ToList();
						if (unoccupiedNeighbours.Count == 0)
						{
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"Items/item_name_1134");
							}
							houseKeeper.OEONGPFALKH.isActive = true;
							continue;
						}
						houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
						bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.GHDMBFOAAHK(bedCleanPosition);
						NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
						walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, (Action)delegate
						{
							if ((Object)(object)houseKeeper.npcBed != (Object)null)
							{
								houseKeeper.npc.FJHKGBNBNKL.LookAtObject(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
							}
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
						walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, new Action(EJELJHDIMKG));
						houseKeeper.OEONGPFALKH.NOFKEMGPFEO();
						return true;
					}
					return false;
				}
			}
		}
		return false;
	}

	private void OCNGMJPADLL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "UIInteract");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("UI" + obj + "/" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool OELDHOHAKAP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo currentState = houseKeeper.npc.FJHKGBNBNKL.GetCurrentState(0);
		if (!((AnimatorStateInfo)(ref currentState)).IsName("MopUp"))
		{
			currentState = houseKeeper.npc.FJHKGBNBNKL.GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref currentState)).IsName("MopRight"))
			{
				currentState = houseKeeper.npc.FJHKGBNBNKL.GetCurrentState(0);
				if (!((AnimatorStateInfo)(ref currentState)).IsName("MopDown"))
				{
					houseKeeper.ResetFloorDirt();
					floorDirts.Clear();
					for (int i = 0; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i++)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 0)
					{
						cleaningFloorDirt = true;
						houseKeeper.SetFloorDirt(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
						{
							if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
							{
								houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
								houseKeeper.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
							}
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
						{
							notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
							houseKeeper.ResetFloorDirt();
							cleaningFloorDirt = false;
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return true;
					}
					cleaningFloorDirt = false;
					houseKeeper.tableToClean = null;
					for (int j = 0; j < houseKeeper.rentedRoomToClean.tables.Count; j++)
					{
						if (!houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) || houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM == TableDirtLevel.Perfect || houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM == TableDirtLevel.Clean)
						{
							continue;
						}
						houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
						tableCleanPosition = houseKeeper.tableToClean.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
						houseKeeper.OEONGPFALKH.FNNPPBDFBCI(tableCleanPosition, AHDHLIECIGH: false);
						NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
						walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, (Action)delegate
						{
							if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
							{
								houseKeeper.npc.FJHKGBNBNKL.LookAtObject(((Component)houseKeeper.tableToClean).gameObject, MAPFDGCKBLD: false);
							}
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
						walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, (Action)delegate
						{
							//IL_000c: Unknown result type (might be due to invalid IL or missing references)
							//IL_0024: Unknown result type (might be due to invalid IL or missing references)
							//IL_0070: Unknown result type (might be due to invalid IL or missing references)
							//IL_0075: Unknown result type (might be due to invalid IL or missing references)
							if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
							{
								houseKeeper.positionsBlocked.Add(tableCleanPosition);
							}
							if (Application.isEditor)
							{
								string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "");
								Vector2 val2 = tableCleanPosition;
								Debug.LogWarning((object)("House keeper OnFailStart cleaning table " + obj + " at " + ((object)(Vector2)(ref val2)).ToString()));
							}
							houseKeeper.tableToClean = null;
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return true;
					}
					houseKeeper.npcBed = null;
					for (int k = 0; k < houseKeeper.rentedRoomToClean.beds.Count; k++)
					{
						if (houseKeeper.rentedRoomToClean.beds[k].IDHLOLDLLOE)
						{
							continue;
						}
						unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 1);
						unoccupiedNeighbours = unoccupiedNeighbours.Where((Vector3 NCPGNLOJGAF) => !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF))).ToList();
						if (unoccupiedNeighbours.Count == 0)
						{
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"Bed without valid position");
							}
							houseKeeper.OEONGPFALKH.isActive = false;
							continue;
						}
						houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
						bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.FNNPPBDFBCI(bedCleanPosition, AHDHLIECIGH: false);
						NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
						walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, (Action)delegate
						{
							if ((Object)(object)houseKeeper.npcBed != (Object)null)
							{
								houseKeeper.npc.FJHKGBNBNKL.LookAtObject(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
							}
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
						walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, (Action)delegate
						{
							//IL_000c: Unknown result type (might be due to invalid IL or missing references)
							//IL_0024: Unknown result type (might be due to invalid IL or missing references)
							//IL_0056: Unknown result type (might be due to invalid IL or missing references)
							//IL_005b: Unknown result type (might be due to invalid IL or missing references)
							if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
							{
								houseKeeper.positionsBlocked.Add(bedCleanPosition);
							}
							if (Application.isEditor)
							{
								string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
								Vector2 val = bedCleanPosition;
								Debug.LogWarning((object)("House keeper OnFailStart cleaning bed " + name + " at " + ((object)(Vector2)(ref val)).ToString()));
							}
							houseKeeper.npcBed = null;
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return true;
					}
					return false;
				}
			}
		}
		return true;
	}

	[CompilerGenerated]
	private void ALDINLEIBMN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("House keeper OnFailStart cleaning table " + obj + " at " + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void BDABKPPKKFK()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.EPLLKPJIAFF().LookAtObject(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool FBPMIKBOGLJ(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void CMGLEDKFCGL()
	{
		notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		houseKeeper.KDALMEOFMII();
		cleaningFloorDirt = true;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (WorldGrid.AGKGGAFFFGM(((Component)houseKeeper).transform.position) != ZoneType.RentedRoom)
		{
			if (houseKeeper.JFCLIAFAOEK != null && houseKeeper.JFCLIAFAOEK.tasks[0] && RoomReceptionDesk.IsThereAnyRequestNotAttended())
			{
				houseKeeper.StartTask();
				return;
			}
			if (houseKeeper.JFCLIAFAOEK != null && houseKeeper.JFCLIAFAOEK.tasks[1] && RentedRoomsManager.GetRoomOrders().Any())
			{
				houseKeeper.StartTask();
				return;
			}
		}
		if ((Object)(object)houseKeeper.tableToClean != (Object)null || cleaningFloorDirt || (Object)(object)houseKeeper.npcBed != (Object)null)
		{
			if (houseKeeper.OEONGPFALKH.isActive || !houseKeeper.OEONGPFALKH.complete)
			{
				return;
			}
			if (cleaningFloorDirt)
			{
				if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
				{
					if (houseKeeper.CleanFloorDirt(houseKeeper.DDJECCPKNKG, houseKeeper.cleaningFloorDirtSpeed))
					{
						houseKeeper.ResetFloorDirt();
						cleaningFloorDirt = false;
						houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
					}
				}
				else
				{
					houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
					cleaningFloorDirt = false;
				}
			}
			else if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean))
			{
				houseKeeper.npc.FJHKGBNBNKL.SetCleaning(houseKeeper.tableToClean.PDPKEPEBPIK > 0f, houseKeeper.tableToClean.placeable.placeableSurface);
				if (houseKeeper.npc.FJHKGBNBNKL.characterAnimator.MLBGEKOIALK && !houseKeeper.npc.FJHKGBNBNKL.characterAnimator.stoppingToClean)
				{
					houseKeeper.tableToClean.WorkerCleaning(GAKAOLIJCFH() * Time.deltaTime);
				}
				if (houseKeeper.tableToClean.PDPKEPEBPIK <= 0f)
				{
					if (tableToCleanTimer >= 3f)
					{
						houseKeeper.tableToClean = null;
						tableToCleanTimer = 0f;
					}
					else
					{
						tableToCleanTimer += Time.deltaTime;
					}
				}
				if (!houseKeeper.npc.FJHKGBNBNKL.characterAnimator.MLBGEKOIALK && houseKeeper.npc.FJHKGBNBNKL.characterAnimator.stoppingToClean)
				{
					houseKeeper.tableToClean = null;
					tableToCleanTimer = 0f;
				}
			}
			else if (Object.op_Implicit((Object)(object)houseKeeper.npcBed))
			{
				houseKeeper.npcBed.MakeBed(0, houseKeeper.npc.FJHKGBNBNKL, IPMPKPBKOFC());
				if (houseKeeper.npcBed.IDHLOLDLLOE)
				{
					houseKeeper.npcBed = null;
				}
			}
		}
		else if (!OELDHOHAKAP())
		{
			houseKeeper.rentedRoomToClean.CleanRoom(DNJLKIIJLFN: true);
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void PFMPMAGFILB()
	{
		notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		houseKeeper.MNENEHEHBJD();
		cleaningFloorDirt = true;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool JFAHDGCIDDD(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private float GIBFMPBAKLL()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(65) / 848f;
	}

	private void BNGFPEINEBB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "HotBath/Rochelle Talk");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("BarnTutorialDone" + obj + "DiningRoom" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.houseKeeperState = HouseKeeperState.CleaningRoom;
		cleaningFloorDirt = false;
		houseKeeper.ResetFloorDirt();
		houseKeeper.tableToClean = null;
		houseKeeper.rentedRoomToClean = RentedRoomsManager.GetRentedRoom(HouseKeeper.GetInstance().OGJIFKFFIAM);
		if ((Object)(object)houseKeeper.rentedRoomToClean == (Object)null)
		{
			houseKeeper.StartTask();
		}
	}

	private void GGHHGFEBHFH()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.OLHBCAHONME().DGJJGINNOOH(((Component)houseKeeper.tableToClean).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool HOMBOBKMEHE(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void HIEOCDOBJGP()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.OLHBCAHONME().DGJJGINNOOH(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool PFBJKFEKGHD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo val = houseKeeper.npc.OAHOFAKKBBA().GetCurrentState(1);
		if (!((AnimatorStateInfo)(ref val)).IsName(" could not be unlocked for reason: "))
		{
			val = houseKeeper.npc.DKMPEPHLBGI().IBPGIGLEEFK(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/3/Dialogue Text"))
			{
				val = houseKeeper.npc.DKMPEPHLBGI().IBPGIGLEEFK(0);
				if (!((AnimatorStateInfo)(ref val)).IsName("add letter"))
				{
					houseKeeper.MNENEHEHBJD();
					floorDirts.Clear();
					for (int i = 1; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i++)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 1)
					{
						cleaningFloorDirt = true;
						houseKeeper.HBAMKHLMCEN(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.OGLJDLEGJAA(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ILNPGDGMEIA));
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AFGIJMGGHHG));
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return false;
					}
					cleaningFloorDirt = false;
					houseKeeper.tableToClean = null;
					for (int j = 0; j < houseKeeper.rentedRoomToClean.tables.Count; j += 0)
					{
						if (houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) && houseKeeper.rentedRoomToClean.tables[j].CDLMMHAHDON() != 0 && houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM != 0)
						{
							houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
							tableCleanPosition = houseKeeper.tableToClean.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
							houseKeeper.OEONGPFALKH.EJPGFOEDPBG(tableCleanPosition, AHDHLIECIGH: false, NGAKHGJANLO: false);
							NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
							walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, new Action(FOLFFHKFNDB));
							NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
							walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, new Action(LEKMBNLCCCN));
							houseKeeper.OEONGPFALKH.NOFKEMGPFEO();
							return true;
						}
					}
					houseKeeper.npcBed = null;
					for (int k = 0; k < houseKeeper.rentedRoomToClean.beds.Count; k++)
					{
						if (!houseKeeper.rentedRoomToClean.beds[k].JAFKAMIDNPJ())
						{
							unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 1);
							unoccupiedNeighbours = unoccupiedNeighbours.Where(PDKEGGLHCIA).ToList();
							if (unoccupiedNeighbours.Count != 0)
							{
								houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
								bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
								houseKeeper.OEONGPFALKH.BDIKOLNFKGD(bedCleanPosition);
								NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
								walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, new Action(OJCBBCIIBOE));
								NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
								walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, new Action(JKGBKOPAHBK));
								houseKeeper.OEONGPFALKH.PEHELKCIECB();
								return true;
							}
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"Bird materials empty ");
							}
							houseKeeper.OEONGPFALKH.isActive = true;
						}
					}
					return true;
				}
			}
		}
		return true;
	}

	private void DFBJOBDNGKM()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.IMGOIBOHCIK().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void MKFHMNEDBHN()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.DCMNEPOPBKA().LookAtObject(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float IPMPKPBKOFC()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(48) / 100f;
	}

	private float MECLHDMHPCE()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(63) / 679f;
	}

	private void OIEEOFBGAPJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("Unique id " + name + "Inventory full" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void HOKKGALBOEO()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.PAMGMEAHNCI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.NOJMFFFDAJA().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void NBBDHDEPBCH()
	{
		notReachableDirts.Add(houseKeeper.KMBIMIINPLF());
		houseKeeper.KDALMEOFMII();
		cleaningFloorDirt = true;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void IDKGKGLHDEB()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.BFBEDHOHEPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.KOIKANGEOFD().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void IENDBBJLKEE()
	{
		notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		houseKeeper.KDALMEOFMII();
		cleaningFloorDirt = false;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		cleaningFloorDirt = false;
		houseKeeper.rentedRoomToClean = null;
		houseKeeper.OGJIFKFFIAM = -1;
		houseKeeper.ResetFloorDirt();
		houseKeeper.tableToClean = null;
	}

	private void OMBCGOLFGED()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("Normal" + name + "Pirates/Brook/Stand" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool GENANAPLAGC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo val = houseKeeper.npc.DKMPEPHLBGI().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Items/item_name_1144"))
		{
			val = houseKeeper.npc.JEFADBEHABI().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("tForTech"))
			{
				val = houseKeeper.npc.CFIFGDBGLPH().IBPGIGLEEFK(1);
				if (!((AnimatorStateInfo)(ref val)).IsName("TutorialPhase"))
				{
					houseKeeper.KDALMEOFMII();
					floorDirts.Clear();
					for (int i = 1; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i += 0)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 1)
					{
						cleaningFloorDirt = true;
						houseKeeper.HBAMKHLMCEN(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.GHDMBFOAAHK(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HNBKCMBGDOJ));
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DAADDHEGPCG));
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return true;
					}
					cleaningFloorDirt = false;
					houseKeeper.tableToClean = null;
					for (int j = 1; j < houseKeeper.rentedRoomToClean.tables.Count; j++)
					{
						if (houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) && houseKeeper.rentedRoomToClean.tables[j].IPEPPDAICDD() != 0 && houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM != TableDirtLevel.Clean)
						{
							houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
							tableCleanPosition = houseKeeper.tableToClean.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
							houseKeeper.OEONGPFALKH.GDGGABHLNOH(tableCleanPosition, AHDHLIECIGH: true, NGAKHGJANLO: false);
							NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
							walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, new Action(FGHJKDLFODF));
							NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
							walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, new Action(BLNMDDBCJIE));
							houseKeeper.OEONGPFALKH.PEHELKCIECB();
							return true;
						}
					}
					houseKeeper.npcBed = null;
					for (int k = 0; k < houseKeeper.rentedRoomToClean.beds.Count; k += 0)
					{
						if (!houseKeeper.rentedRoomToClean.beds[k].JAFKAMIDNPJ())
						{
							unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 0);
							unoccupiedNeighbours = unoccupiedNeighbours.Where(HHFEGHKLFEB).ToList();
							if (unoccupiedNeighbours.Count != 0)
							{
								houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
								bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
								houseKeeper.OEONGPFALKH.GINPKMBGOFN(bedCleanPosition, AHDHLIECIGH: false);
								NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
								walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, new Action(HIEOCDOBJGP));
								NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
								walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, new Action(OMBCGOLFGED));
								houseKeeper.OEONGPFALKH.PEHELKCIECB();
								return false;
							}
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"Hurt");
							}
							houseKeeper.OEONGPFALKH.isActive = false;
						}
					}
					return false;
				}
			}
		}
		return false;
	}

	private void GNOAMCHMIAM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("itemRug" + name + "Move Forward" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void KDKLCMGEDMB()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.CGBPBCDLOCM().DGJJGINNOOH(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void DGKPGLAOAFL()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.BFBEDHOHEPH().DGJJGINNOOH(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void KEJLKJPFDFK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "dForDays");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("flashLights" + obj + "- " + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void MNOCFOAJHPP()
	{
		notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		houseKeeper.MNENEHEHBJD();
		cleaningFloorDirt = false;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool ABECNGMBJEH(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	[CompilerGenerated]
	private void NLHIOKKGLNG()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.FJHKGBNBNKL.LookAtObject(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	[CompilerGenerated]
	private void EIOBDNGDOBI()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.FJHKGBNBNKL.LookAtObject(((Component)houseKeeper.tableToClean).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	[CompilerGenerated]
	private void BCEIIGHMFKP()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.FJHKGBNBNKL.SetTrigger(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float OLOGHMOAALC()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(70) / 113f;
	}

	private void GNJCCMGLGCE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "HandUp");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("ReceiveAnimalSetProduction" + obj + "() Ingredient " + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void DOFOFKDEEMG()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.CCFDNFDEGIK().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.GDDFKLAEACF().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private bool AJIBJMHNABB(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void CIDALJPNPBD()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.IBGCFFIFPBL().DGJJGINNOOH(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void ECPPJCNKMJP()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.OOOCIMIMIIH()))
		{
			houseKeeper.npc.CFIFGDBGLPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.KOIKANGEOFD().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private float AOGOIHEMKPF()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(-59) / 1023f;
	}

	private bool NLDCCPKLFGL(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void CLBPNCOOIKH()
	{
		notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		houseKeeper.ResetFloorDirt();
		cleaningFloorDirt = false;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float FNDBHHCFHHN()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-70) / 1423f;
	}

	private void PEKLOCHHJKM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "Items/item_description_1085");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("" + obj + "ReceiveStopWaitingForBanquetEvent" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float HGLDGNJBEML()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-21) / 368f;
	}

	private void HLLAJAOFIOH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)(" " + name + "F2" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void HNBKCMBGDOJ()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.FJHKGBNBNKL.SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.CGBPBCDLOCM().FHOAPHBOOAH(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private bool FFMBDKPPDBF(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void GNMJGMAHHFL()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.DHMMHOPEMLF().LookAtObject(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void DICMCLEAFGO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("ObjectVerticalMove" + name + " has null in variant objects list." + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	[CompilerGenerated]
	private void DKONEOCBGFI()
	{
		notReachableDirts.Add(houseKeeper.DDJECCPKNKG);
		houseKeeper.ResetFloorDirt();
		cleaningFloorDirt = false;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	[CompilerGenerated]
	private void GICAPPGGIIA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("House keeper OnFailStart cleaning bed " + name + " at " + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void GHJJDHGNGCJ()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.CGBPBCDLOCM().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.GHNLDKEOCFA().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float HBCMIHNLHGH()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(13) / 517f;
	}

	private void CCOBOGFOOID()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.OAHOFAKKBBA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.BFBEDHOHEPH().IDNHDBIKNKP(StaffBaseState.p_Mop, HALNIEBONKH: true);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	[CompilerGenerated]
	private bool GHACCNODLDF(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private bool NAHALHFMOMJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo val = houseKeeper.npc.DKMPEPHLBGI().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("Intro"))
		{
			val = houseKeeper.npc.GHNLDKEOCFA().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName("Dialogue System/Conversation/Crowly_Introduce/Entry/16/Dialogue Text"))
			{
				val = houseKeeper.npc.GHNLDKEOCFA().GetCurrentState(1);
				if (!((AnimatorStateInfo)(ref val)).IsName("[StuckRecovery] No hay safe points para el player {0}"))
				{
					houseKeeper.KDALMEOFMII();
					floorDirts.Clear();
					for (int i = 0; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i += 0)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 1)
					{
						cleaningFloorDirt = false;
						houseKeeper.HBAMKHLMCEN(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.JDHMPOJKOLF(Vector2.op_Implicit(((Component)houseKeeper.MKCBJAGOKLE()).transform.position), AHDHLIECIGH: false);
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IHDOKLHKPNP));
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DAADDHEGPCG));
						houseKeeper.OEONGPFALKH.NOFKEMGPFEO();
						return true;
					}
					cleaningFloorDirt = true;
					houseKeeper.tableToClean = null;
					for (int j = 0; j < houseKeeper.rentedRoomToClean.tables.Count; j += 0)
					{
						if (houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) && houseKeeper.rentedRoomToClean.tables[j].CDLMMHAHDON() != 0 && houseKeeper.rentedRoomToClean.tables[j].IPEPPDAICDD() != TableDirtLevel.Clean)
						{
							houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
							tableCleanPosition = houseKeeper.tableToClean.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
							houseKeeper.OEONGPFALKH.CGFMBJFGLAG(tableCleanPosition);
							NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
							walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, new Action(FHNJLEDBDKH));
							NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
							walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, new Action(OCNGMJPADLL));
							houseKeeper.OEONGPFALKH.PEHELKCIECB();
							return false;
						}
					}
					houseKeeper.npcBed = null;
					for (int k = 0; k < houseKeeper.rentedRoomToClean.beds.Count; k++)
					{
						if (houseKeeper.rentedRoomToClean.beds[k].IDHLOLDLLOE)
						{
							continue;
						}
						unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 1);
						unoccupiedNeighbours = unoccupiedNeighbours.Where(DJBGINJPDNH).ToList();
						if (unoccupiedNeighbours.Count == 0)
						{
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"Top");
							}
							houseKeeper.OEONGPFALKH.isActive = false;
							continue;
						}
						houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
						bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.GINPKMBGOFN(bedCleanPosition, AHDHLIECIGH: false);
						NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
						walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, new Action(HBDJADBODJA));
						NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
						walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, (Action)delegate
						{
							//IL_000c: Unknown result type (might be due to invalid IL or missing references)
							//IL_0024: Unknown result type (might be due to invalid IL or missing references)
							//IL_0056: Unknown result type (might be due to invalid IL or missing references)
							//IL_005b: Unknown result type (might be due to invalid IL or missing references)
							if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
							{
								houseKeeper.positionsBlocked.Add(bedCleanPosition);
							}
							if (Application.isEditor)
							{
								string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
								Vector2 val2 = bedCleanPosition;
								Debug.LogWarning((object)("House keeper OnFailStart cleaning bed " + name + " at " + ((object)(Vector2)(ref val2)).ToString()));
							}
							houseKeeper.npcBed = null;
							houseKeeper.OEONGPFALKH.isActive = false;
						});
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return false;
					}
					return true;
				}
			}
		}
		return false;
	}

	private void GJKFOCEKELC()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.CGBPBCDLOCM().DGJJGINNOOH(((Component)houseKeeper.tableToClean).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void BLNMDDBCJIE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "Player left with left piece in inventory, dropping it on the ground.");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("Set Quality to " + obj + "no ing" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void FOLFFHKFNDB()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.DHMMHOPEMLF().LookAtObject(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void CKCOPLJBPAP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "MissionsDatabaseAccessor instance is null. Make sure it is initialized before calling this method.");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)(" " + obj + "Items/item_name_645" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void GGNLCCPDAHN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("add item " + name + "ValueRemainingMs" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void LOPEMLPMLFO()
	{
		notReachableDirts.Add(houseKeeper.MKCBJAGOKLE());
		houseKeeper.MNENEHEHBJD();
		cleaningFloorDirt = true;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float FDCBNOJKCKK()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(-61) / 1123f;
	}

	private void JKGBKOPAHBK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("Eye-lashes" + name + "Farm/Buzz/Bark_Searching" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void AKJAFCLBFKB()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.PABOGCMHLAN().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false);
			houseKeeper.npc.PABOGCMHLAN().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void IAJJIBJEDFA()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.IBGCFFIFPBL().LookAtObject(((Component)houseKeeper.npcBed).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool CNKHEHAMBHK(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private bool FPOFLGLALHH(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void OJCBBCIIBOE()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.FNGPCELFEHO().DGJJGINNOOH(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float BJKOLMJGJPL()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(90) / 814f;
	}

	private void DPHPJDOHHBK()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.EPLLKPJIAFF().DGJJGINNOOH(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private float FKJDAEJMKJP()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(-106) / 391f;
	}

	private bool KLBPKEJALDG(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void EAMPGBFGCBJ()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.CGBPBCDLOCM().DGJJGINNOOH(((Component)houseKeeper.npcBed).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void AFGIJMGGHHG()
	{
		notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		houseKeeper.KDALMEOFMII();
		cleaningFloorDirt = true;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void BLFFHPMBGNN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "tavern travelling");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("Perks/playerPerk_description_" + obj + "Items/item_name_1061" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private float PPKPBAMILBP()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-29) / 1069f;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (((Object)(object)houseKeeper.tableToClean != (Object)null || cleaningFloorDirt || (Object)(object)houseKeeper.npcBed != (Object)null) && houseKeeper.OEONGPFALKH.IIMEFNIECLI())
		{
			houseKeeper.OEONGPFALKH.isActive = false;
		}
	}

	private float AEFCHFPEMFB()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(101) / 950f;
	}

	private float HAJHABACGLG()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(16) / 380f;
	}

	private float APOPBDDPEFN()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-50) / 772f;
	}

	private void LFICJOKPOKN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "sender not found!");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)("" + obj + "Items/item_name_1127" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void PGCNHGLOCGN()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.FJHKGBNBNKL.LookAtObject(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void PAOJAGEMLGG()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.NOJMFFFDAJA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.EPLLKPJIAFF().SetTrigger(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float AANFGPJOHNA()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-117) / 1372f;
	}

	private void OIAKHJMKEEN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("Player" + name + "Player2" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool MCBGNFAINHD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo val = houseKeeper.npc.PNGIDKBCGCK().IBPGIGLEEFK(1);
		if (!((AnimatorStateInfo)(ref val)).IsName("scaleUI"))
		{
			val = houseKeeper.npc.LNJABLMFNNE().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("This ingredient is temporarily available"))
			{
				val = houseKeeper.npc.OAHOFAKKBBA().IBPGIGLEEFK(1);
				if (!((AnimatorStateInfo)(ref val)).IsName("Starting Tutorial Phase: "))
				{
					houseKeeper.MNENEHEHBJD();
					floorDirts.Clear();
					for (int i = 0; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i += 0)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 0)
					{
						cleaningFloorDirt = false;
						houseKeeper.BILMFIMGHMI(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.DBHOIIIHIIM(Vector2.op_Implicit(((Component)houseKeeper.DDJECCPKNKG).transform.position), AHDHLIECIGH: false);
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OIEEMBNHDHM));
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MNOCFOAJHPP));
						houseKeeper.OEONGPFALKH.PEHELKCIECB();
						return false;
					}
					cleaningFloorDirt = true;
					houseKeeper.tableToClean = null;
					for (int j = 0; j < houseKeeper.rentedRoomToClean.tables.Count; j += 0)
					{
						if (houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) && houseKeeper.rentedRoomToClean.tables[j].CDLMMHAHDON() != 0 && houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM != 0)
						{
							houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
							tableCleanPosition = houseKeeper.tableToClean.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
							houseKeeper.OEONGPFALKH.KBEENHPEOAB(tableCleanPosition);
							NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
							walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, new Action(FOLFFHKFNDB));
							NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
							walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, new Action(BLNMDDBCJIE));
							houseKeeper.OEONGPFALKH.NOFKEMGPFEO();
							return false;
						}
					}
					houseKeeper.npcBed = null;
					for (int k = 0; k < houseKeeper.rentedRoomToClean.beds.Count; k += 0)
					{
						if (!houseKeeper.rentedRoomToClean.beds[k].IDHLOLDLLOE)
						{
							unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 1);
							unoccupiedNeighbours = unoccupiedNeighbours.Where(NLDCCPKLFGL).ToList();
							if (unoccupiedNeighbours.Count != 0)
							{
								houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
								bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
								houseKeeper.OEONGPFALKH.HELOLJBENMK(bedCleanPosition, AHDHLIECIGH: true, NGAKHGJANLO: false);
								NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
								walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, new Action(EAMPGBFGCBJ));
								NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
								walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, new Action(OMBCGOLFGED));
								houseKeeper.OEONGPFALKH.NOFKEMGPFEO();
								return false;
							}
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"itemSoup");
							}
							houseKeeper.OEONGPFALKH.isActive = true;
						}
					}
					return true;
				}
			}
		}
		return false;
	}

	private void GAHCHNHPHLG()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.BKPDJIDCAEO().DGJJGINNOOH(((Component)houseKeeper.npcBed).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void ILNPGDGMEIA()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.MKCBJAGOKLE()))
		{
			houseKeeper.npc.JEFADBEHABI().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.OHKDOEFGKFA().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private float GAKAOLIJCFH()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(48) / 100f;
	}

	private void LEKMBNLCCCN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(tableCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(tableCleanPosition);
		}
		if (Application.isEditor)
		{
			string obj = (((Object)(object)houseKeeper.tableToClean != (Object)null) ? ((Object)((Component)houseKeeper.tableToClean).gameObject).name : "LE_2");
			Vector2 val = tableCleanPosition;
			Debug.LogWarning((object)(", " + obj + "Error_CannotPickUpDirtyTable" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.tableToClean = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void KFEENJLPKEL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("Tutorial/T" + name + " " + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float PPFEKLCCJGE()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-97) / 610f;
	}

	private void IHDOKLHKPNP()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.GHNLDKEOCFA().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: false, HALNIEBONKH: true);
			houseKeeper.npc.CGBPBCDLOCM().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float FNHBEPCIEFA()
	{
		return houseKeeper.cleaningTableSpeed + houseKeeper.cleaningTableSpeed * (float)houseKeeper.GetPerkValue(-98) / 888f;
	}

	private void OCPHNNJFPBG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("MainProgress" + name + "Items/item_name_1038" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void HBDJADBODJA()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.DCMNEPOPBKA().LookAtObject(((Component)houseKeeper.npcBed).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void OIEEMBNHDHM()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.KMBIMIINPLF()))
		{
			houseKeeper.npc.BFBEDHOHEPH().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true, HALNIEBONKH: true);
			houseKeeper.npc.GHNLDKEOCFA().IDNHDBIKNKP(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void JCBGACPANBH()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.DKLMKBPEHAJ().LookAtObject(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private bool PDKEGGLHCIA(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private bool LBDOFNDNLNG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo val = houseKeeper.npc.PNGIDKBCGCK().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName("UIBack"))
		{
			val = houseKeeper.npc.PABOGCMHLAN().GetCurrentState(1);
			if (!((AnimatorStateInfo)(ref val)).IsName("No bed assigned to player num: {0}"))
			{
				val = houseKeeper.npc.OAHOFAKKBBA().IBPGIGLEEFK(1);
				if (!((AnimatorStateInfo)(ref val)).IsName("ReceiveNewEmployees"))
				{
					houseKeeper.ResetFloorDirt();
					floorDirts.Clear();
					for (int i = 0; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i++)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 0)
					{
						cleaningFloorDirt = false;
						houseKeeper.CDGOCJGIBPL(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)houseKeeper.OOOCIMIMIIH()).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DFBJOBDNGKM));
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DAADDHEGPCG));
						houseKeeper.OEONGPFALKH.EHDKLBLKBEO();
						return false;
					}
					cleaningFloorDirt = true;
					houseKeeper.tableToClean = null;
					for (int j = 1; j < houseKeeper.rentedRoomToClean.tables.Count; j += 0)
					{
						if (houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) && houseKeeper.rentedRoomToClean.tables[j].IPEPPDAICDD() != 0 && houseKeeper.rentedRoomToClean.tables[j].IPEPPDAICDD() != 0)
						{
							houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
							tableCleanPosition = houseKeeper.tableToClean.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
							houseKeeper.OEONGPFALKH.DBHOIIIHIIM(tableCleanPosition);
							NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
							walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, new Action(DPHPJDOHHBK));
							NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
							walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, new Action(PEKLOCHHJKM));
							houseKeeper.OEONGPFALKH.PEHELKCIECB();
							return true;
						}
					}
					houseKeeper.npcBed = null;
					for (int k = 0; k < houseKeeper.rentedRoomToClean.beds.Count; k++)
					{
						if (!houseKeeper.rentedRoomToClean.beds[k].JAFKAMIDNPJ())
						{
							unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 1);
							unoccupiedNeighbours = unoccupiedNeighbours.Where(JFAHDGCIDDD).ToList();
							if (unoccupiedNeighbours.Count != 0)
							{
								houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
								bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
								houseKeeper.OEONGPFALKH.KBEENHPEOAB(bedCleanPosition, AHDHLIECIGH: false);
								NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
								walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, new Action(EAMPGBFGCBJ));
								NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
								walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, new Action(OCPHNNJFPBG));
								houseKeeper.OEONGPFALKH.EHDKLBLKBEO();
								return true;
							}
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"Player sleep with right piece in inventory, dropping it on the ground.");
							}
							houseKeeper.OEONGPFALKH.isActive = true;
						}
					}
					return true;
				}
			}
		}
		return false;
	}

	private float FFCDIIEGNFI()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-127) / 270f;
	}

	private bool NCMDDLKKBAN(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void BPFFBCKKAEK()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.DKMPEPHLBGI().LookAtObject(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private float LOMLDFEFPKK()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-123) / 1454f;
	}

	private bool GLDBJEBLPGM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo val = houseKeeper.npc.DCMNEPOPBKA().IBPGIGLEEFK(0);
		if (!((AnimatorStateInfo)(ref val)).IsName(" : 00"))
		{
			val = houseKeeper.npc.PNGIDKBCGCK().GetCurrentState(0);
			if (!((AnimatorStateInfo)(ref val)).IsName(""))
			{
				val = houseKeeper.npc.CFIFGDBGLPH().GetCurrentState(0);
				if (!((AnimatorStateInfo)(ref val)).IsName("Tutorial/Chicken_Holly"))
				{
					houseKeeper.ResetFloorDirt();
					floorDirts.Clear();
					for (int i = 1; i < houseKeeper.rentedRoomToClean.allFloorDirt.Count; i++)
					{
						if (!notReachableDirts.Contains(houseKeeper.rentedRoomToClean.allFloorDirt[i]))
						{
							floorDirts.Add(houseKeeper.rentedRoomToClean.allFloorDirt[i]);
						}
					}
					if (floorDirts.Count > 0)
					{
						cleaningFloorDirt = false;
						houseKeeper.SetFloorDirt(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)houseKeeper).transform.position));
						houseKeeper.OEONGPFALKH.GDGGABHLNOH(Vector2.op_Implicit(((Component)houseKeeper.KMBIMIINPLF()).transform.position));
						NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
						walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GHJJDHGNGCJ));
						NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
						walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AFGIJMGGHHG));
						houseKeeper.OEONGPFALKH.EHDKLBLKBEO();
						return true;
					}
					cleaningFloorDirt = false;
					houseKeeper.tableToClean = null;
					for (int j = 1; j < houseKeeper.rentedRoomToClean.tables.Count; j++)
					{
						if (houseKeeper.rentedRoomToClean.tables[j].IsAnyPositionToCleanAvailable(houseKeeper.positionsBlocked) && houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM != 0 && houseKeeper.rentedRoomToClean.tables[j].JNHCCCBICDM != 0)
						{
							houseKeeper.tableToClean = houseKeeper.rentedRoomToClean.tables[j];
							tableCleanPosition = houseKeeper.tableToClean.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), houseKeeper.positionsBlocked);
							houseKeeper.OEONGPFALKH.KBEENHPEOAB(tableCleanPosition, AHDHLIECIGH: false);
							NPCWalkTo walkTo3 = houseKeeper.OEONGPFALKH;
							walkTo3.OnActionComplete = (Action)Delegate.Combine(walkTo3.OnActionComplete, new Action(FHNJLEDBDKH));
							NPCWalkTo walkTo4 = houseKeeper.OEONGPFALKH;
							walkTo4.OnFailStart = (Action)Delegate.Combine(walkTo4.OnFailStart, new Action(PEKLOCHHJKM));
							houseKeeper.OEONGPFALKH.NOFKEMGPFEO();
							return true;
						}
					}
					houseKeeper.npcBed = null;
					for (int k = 1; k < houseKeeper.rentedRoomToClean.beds.Count; k += 0)
					{
						if (!houseKeeper.rentedRoomToClean.beds[k].LILIGKKMAOJ())
						{
							unoccupiedNeighbours = WorldGrid.HALEJLJFMLJ(((Component)houseKeeper.rentedRoomToClean.beds[k]).GetComponent<Placeable>(), 1);
							unoccupiedNeighbours = unoccupiedNeighbours.Where(JFAHDGCIDDD).ToList();
							if (unoccupiedNeighbours.Count != 0)
							{
								houseKeeper.npcBed = houseKeeper.rentedRoomToClean.beds[k];
								bedCleanPosition = Vector2.op_Implicit(Utils.JOJPOKBFANL(unoccupiedNeighbours.ToArray(), ((Component)houseKeeper).transform.position));
								houseKeeper.OEONGPFALKH.FNNPPBDFBCI(bedCleanPosition, AHDHLIECIGH: true, NGAKHGJANLO: false);
								NPCWalkTo walkTo5 = houseKeeper.OEONGPFALKH;
								walkTo5.OnActionComplete = (Action)Delegate.Combine(walkTo5.OnActionComplete, new Action(JCBGACPANBH));
								NPCWalkTo walkTo6 = houseKeeper.OEONGPFALKH;
								walkTo6.OnFailStart = (Action)Delegate.Combine(walkTo6.OnFailStart, new Action(OIAKHJMKEEN));
								houseKeeper.OEONGPFALKH.EHDKLBLKBEO();
								return false;
							}
							if (Application.isEditor)
							{
								Debug.LogWarning((object)"RinProgress");
							}
							houseKeeper.OEONGPFALKH.isActive = false;
						}
					}
					return true;
				}
			}
		}
		return true;
	}

	private bool OLDALBJAGEI(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void FGHJKDLFODF()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.NOJMFFFDAJA().LookAtObject(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private float HFLCLAAMBAK()
	{
		return houseKeeper.makeBedSpeed + houseKeeper.makeBedSpeed * (float)houseKeeper.GetPerkValue(-128) / 507f;
	}

	private void DAADDHEGPCG()
	{
		notReachableDirts.Add(houseKeeper.OOOCIMIMIIH());
		houseKeeper.ResetFloorDirt();
		cleaningFloorDirt = true;
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void FJOKDPLPJKB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.positionsBlocked.Contains(bedCleanPosition))
		{
			houseKeeper.positionsBlocked.Add(bedCleanPosition);
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)houseKeeper.npcBed).gameObject).name;
			Vector2 val = bedCleanPosition;
			Debug.LogWarning((object)("ReceivePhaseSlotFromContainer" + name + " : 00" + ((object)(Vector2)(ref val)).ToString()));
		}
		houseKeeper.npcBed = null;
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private bool HHFEGHKLFEB(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private bool DJBGINJPDNH(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return !houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private bool PEECBNGNPHL(Vector3 NCPGNLOJGAF)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return houseKeeper.positionsBlocked.Contains(Vector2.op_Implicit(NCPGNLOJGAF));
	}

	private void FHNJLEDBDKH()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.tableToClean) && !houseKeeper.tableToClean.placeable.FHEMHCEAICB)
		{
			houseKeeper.npc.OLHBCAHONME().LookAtObject(((Component)houseKeeper.tableToClean).gameObject);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}

	private void KIHMEDDJDKH()
	{
		if ((Object)(object)houseKeeper.npcBed != (Object)null)
		{
			houseKeeper.npc.BKPDJIDCAEO().DGJJGINNOOH(((Component)houseKeeper.npcBed).gameObject, MAPFDGCKBLD: false);
		}
		houseKeeper.OEONGPFALKH.isActive = true;
	}

	private void HHMJOEOFLIN()
	{
		if (Object.op_Implicit((Object)(object)houseKeeper.DDJECCPKNKG))
		{
			houseKeeper.npc.BIFKPMIMAEC().SetBool(StaffBaseState.p_UseHold, EGFGNGJGBOP: true);
			houseKeeper.npc.CCFDNFDEGIK().FHOAPHBOOAH(StaffBaseState.p_Mop);
		}
		houseKeeper.OEONGPFALKH.isActive = false;
	}
}
