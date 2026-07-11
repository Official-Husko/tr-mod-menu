using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CustomerStateRentRoom : CustomerStateBase
{
	[CompilerGenerated]
	private sealed class IAKINKHMLCC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomerStateRentRoom _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public IAKINKHMLCC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			CustomerStateRentRoom customerStateRentRoom = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			bool flag;
			try
			{
				flag = customerStateRentRoom.KPGFBMODODB();
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex);
				goto IL_004f;
			}
			if (flag)
			{
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_004f;
			IL_004f:
			customerStateRentRoom.GCAFIGOCEKH();
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	private IEnumerator PPHBJPJOPFG()
	{
		return new IAKINKHMLCC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PBHJJBDKNBA()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			if (Utils.HOHLHGJHOKM(Vector2.op_Implicit(PJNGMCJIHME.rentedRoom.zone.positions[0])))
			{
				PJNGMCJIHME.customerSpeech.HDPDLCIPBGE("veggieDishes");
			}
			else
			{
				PJNGMCJIHME.customerSpeech.BEKELFOOOFM("Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text");
			}
			if (PJNGMCJIHME.roomRequest != null)
			{
				TavernServiceManager.LKOABOAADCD().DAJKMIEJCAD(PJNGMCJIHME.roomRequest.finalPrice);
			}
			int num = (int)((float)PJNGMCJIHME.rentedRoom.CalculateReputation() * PJNGMCJIHME.rentedRoom.repPositiveMultiplier * PJNGMCJIHME.NGDAJGCPJEC);
			if (num > 1 && PJNGMCJIHME.roomRequest != null)
			{
				num *= PJNGMCJIHME.roomRequest.daysToStay;
			}
			TavernReputation.AddAndShowReputationGain(num, Vector2.op_Implicit(((Component)PJNGMCJIHME).transform.position), ((Component)PJNGMCJIHME).transform, PJNGMCJIHME.NGDAJGCPJEC);
			Utils.FKKHJPEMNBG("Hanghover", 1);
		}
	}

	private void MAOJCEIAIDC()
	{
		PJNGMCJIHME.rentedRoom.VacateRoom();
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			MainUI.DBKCOHMFDCB(1, LocalisationSystem.Get("Walk Around cannot entry barn "), 863f);
		}
	}

	private void AAMDLIDCNNH()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			if (Utils.HOHLHGJHOKM(Vector2.op_Implicit(PJNGMCJIHME.rentedRoom.zone.positions[1])))
			{
				PJNGMCJIHME.customerSpeech.OJLAGEGECHB("Crowly_RaraAvis");
			}
			else
			{
				PJNGMCJIHME.customerSpeech.NNLJEKHJCPI("Player/Bark/ShovelHole");
			}
			if (PJNGMCJIHME.roomRequest != null)
			{
				TavernServiceManager.JFJOKGAOPHA().JAHPFOFGCBN(PJNGMCJIHME.roomRequest.finalPrice);
			}
			int num = (int)((float)PJNGMCJIHME.rentedRoom.CalculateReputation() * PJNGMCJIHME.rentedRoom.repPositiveMultiplier * PJNGMCJIHME.NGDAJGCPJEC);
			if (num > 0 && PJNGMCJIHME.roomRequest != null)
			{
				num *= PJNGMCJIHME.roomRequest.daysToStay;
			}
			TavernReputation.AddAndShowReputationGain(num, Vector2.op_Implicit(((Component)PJNGMCJIHME).transform.position), ((Component)PJNGMCJIHME).transform, PJNGMCJIHME.NGDAJGCPJEC, CDPAMNIPPEC: false);
			Utils.FKKHJPEMNBG(" ", 1);
		}
	}

	private void PIIMBFJCKDF()
	{
		if (FPPJOBJLFMB())
		{
			((MonoBehaviour)this).StartCoroutine(PPHBJPJOPFG());
		}
		else
		{
			KGBIAIPNDOP();
		}
	}

	private void KPFAMGOKJCC()
	{
		PJNGMCJIHME.rentedRoom.DKGEOKBHAGO();
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			MainUI.DBKCOHMFDCB(1, LocalisationSystem.Get("Items/item_name_1057"), 1703f);
		}
	}

	public override int GetStateEnumID()
	{
		return 10;
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		PJNGMCJIHME.rentedRoom.VacateRoom();
	}

	private bool KPGFBMODODB()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (HouseKeeper.JHLLELHBIDA)
		{
			if (HouseKeeper.GetInstance().houseKeeperState == HouseKeeperState.CleaningRoom && HouseKeeper.GetInstance().OGJIFKFFIAM == PJNGMCJIHME.rentedRoom.JFNMCNCHMEO)
			{
				return true;
			}
			RentedRoom rentedRoom = RentedRoomsManager.GetRentedRoom(WorldGrid.APJABAKKKGD(((Component)HouseKeeper.GetInstance()).transform.position));
			if ((Object)(object)rentedRoom != (Object)null && rentedRoom.JFNMCNCHMEO == PJNGMCJIHME.rentedRoom.JFNMCNCHMEO)
			{
				return true;
			}
		}
		return false;
	}

	private IEnumerator BNHOOICIJAF()
	{
		return new IAKINKHMLCC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BANCFAPEPOD()
	{
		PJNGMCJIHME.rentedRoom.VacateRoom(CDPAMNIPPEC: false);
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			MainUI.ShowErrorText(0, LocalisationSystem.Get("ErrorDisconnectedTitleScreen"), 883f);
		}
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		JHIFLALPEBF.walkTo.IIMEFNIECLI();
	}

	[CompilerGenerated]
	private void HECJJMOPMCF()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			if (Utils.HOHLHGJHOKM(Vector2.op_Implicit(PJNGMCJIHME.rentedRoom.zone.positions[0])))
			{
				PJNGMCJIHME.customerSpeech.ImmediatelyBark("AcceptRoomFirstFloor");
			}
			else
			{
				PJNGMCJIHME.customerSpeech.ImmediatelyBark("AcceptRoomSecondFloor");
			}
			if (PJNGMCJIHME.roomRequest != null)
			{
				TavernServiceManager.GGFJGHHHEJC.AddRentedRoomSaleAndAddPrice(PJNGMCJIHME.roomRequest.finalPrice);
			}
			int num = (int)((float)PJNGMCJIHME.rentedRoom.CalculateReputation() * PJNGMCJIHME.rentedRoom.repPositiveMultiplier * PJNGMCJIHME.NGDAJGCPJEC);
			if (num > 0 && PJNGMCJIHME.roomRequest != null)
			{
				num *= PJNGMCJIHME.roomRequest.daysToStay;
			}
			TavernReputation.AddAndShowReputationGain(num, Vector2.op_Implicit(((Component)PJNGMCJIHME).transform.position), ((Component)PJNGMCJIHME).transform, PJNGMCJIHME.NGDAJGCPJEC);
			Utils.FKKHJPEMNBG("roomsRented", 1);
		}
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: true);
		}
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		PJNGMCJIHME.rentedRoom.occupied = true;
		PJNGMCJIHME.customerType = CustomerType.Guest;
		JHIFLALPEBF.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(PJNGMCJIHME.rentedRoom.GetEnterLocation()));
		NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
		walkTo.OnSuccessfulStart = (Action)Delegate.Combine(walkTo.OnSuccessfulStart, (Action)delegate
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			if (PJNGMCJIHME.firstDayRentingRooms)
			{
				if (Utils.HOHLHGJHOKM(Vector2.op_Implicit(PJNGMCJIHME.rentedRoom.zone.positions[0])))
				{
					PJNGMCJIHME.customerSpeech.ImmediatelyBark("AcceptRoomFirstFloor");
				}
				else
				{
					PJNGMCJIHME.customerSpeech.ImmediatelyBark("AcceptRoomSecondFloor");
				}
				if (PJNGMCJIHME.roomRequest != null)
				{
					TavernServiceManager.GGFJGHHHEJC.AddRentedRoomSaleAndAddPrice(PJNGMCJIHME.roomRequest.finalPrice);
				}
				int num = (int)((float)PJNGMCJIHME.rentedRoom.CalculateReputation() * PJNGMCJIHME.rentedRoom.repPositiveMultiplier * PJNGMCJIHME.NGDAJGCPJEC);
				if (num > 0 && PJNGMCJIHME.roomRequest != null)
				{
					num *= PJNGMCJIHME.roomRequest.daysToStay;
				}
				TavernReputation.AddAndShowReputationGain(num, Vector2.op_Implicit(((Component)PJNGMCJIHME).transform.position), ((Component)PJNGMCJIHME).transform, PJNGMCJIHME.NGDAJGCPJEC);
				Utils.FKKHJPEMNBG("roomsRented", 1);
			}
		});
		NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
		walkTo2.OnActionComplete = (Action)Delegate.Combine(walkTo2.OnActionComplete, (Action)delegate
		{
			if (KPGFBMODODB())
			{
				((MonoBehaviour)this).StartCoroutine(MBGPKNGEHJH());
			}
			else
			{
				GCAFIGOCEKH();
			}
		});
		NPCWalkTo walkTo3 = JHIFLALPEBF.walkTo;
		walkTo3.OnFailStart = (Action)Delegate.Combine(walkTo3.OnFailStart, (Action)delegate
		{
			PJNGMCJIHME.rentedRoom.VacateRoom();
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
			if (PJNGMCJIHME.firstDayRentingRooms)
			{
				MainUI.ShowErrorText(1, LocalisationSystem.Get("Path is blocked"));
			}
		});
		JHIFLALPEBF.walkTo.PEHELKCIECB();
	}

	private IEnumerator MBGPKNGEHJH()
	{
		while (true)
		{
			bool flag;
			try
			{
				flag = KPGFBMODODB();
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex);
				break;
			}
			if (!flag)
			{
				break;
			}
			yield return CommonReferences.wait1;
		}
		GCAFIGOCEKH();
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		base.UpdateState(GDHCBGCIIKG);
		if ((Object)(object)PJNGMCJIHME.rentedRoom == (Object)null || !PJNGMCJIHME.rentedRoom.occupied)
		{
			PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		}
	}

	[CompilerGenerated]
	private void IGCEEOHBNGC()
	{
		if (KPGFBMODODB())
		{
			((MonoBehaviour)this).StartCoroutine(MBGPKNGEHJH());
		}
		else
		{
			GCAFIGOCEKH();
		}
	}

	private void HKMBOFCCLDH()
	{
		if (FPPJOBJLFMB())
		{
			((MonoBehaviour)this).StartCoroutine(BNHOOICIJAF());
		}
		else
		{
			KGBIAIPNDOP();
		}
	}

	private bool FPPJOBJLFMB()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (HouseKeeper.HMPOHCKLNNH())
		{
			if (HouseKeeper.GMBGGBLKHHN().houseKeeperState == HouseKeeperState.Leaving && HouseKeeper.OAPGGAPMOJD().HPACAJGBHHE() == PJNGMCJIHME.rentedRoom.JFNMCNCHMEO)
			{
				return true;
			}
			RentedRoom rentedRoom = RentedRoomsManager.ABOHBEPGDLE(WorldGrid.APJABAKKKGD(((Component)HouseKeeper.OAPGGAPMOJD()).transform.position));
			if ((Object)(object)rentedRoom != (Object)null && rentedRoom.JFNMCNCHMEO == PJNGMCJIHME.rentedRoom.JFNMCNCHMEO)
			{
				return true;
			}
		}
		return false;
	}

	private void GCAFIGOCEKH()
	{
		if (Object.op_Implicit((Object)(object)PJNGMCJIHME.rentedRoom))
		{
			if (PJNGMCJIHME.firstDayRentingRooms)
			{
				PJNGMCJIHME.rentedRoom.SetNewCustomerInRoom(PJNGMCJIHME.npc.characterCreator.humanInfo, PJNGMCJIHME.roomRequest.daysToStay, CDPAMNIPPEC: true);
			}
			else
			{
				PJNGMCJIHME.rentedRoom.SetCustomerInRoom(CDPAMNIPPEC: true);
			}
		}
		Utils.BLPDAEHPOBA(((Component)PJNGMCJIHME).gameObject, 1f);
	}

	[CompilerGenerated]
	private void KKOCFIBNDEA()
	{
		PJNGMCJIHME.rentedRoom.VacateRoom();
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			MainUI.ShowErrorText(1, LocalisationSystem.Get("Path is blocked"));
		}
	}

	private void HDPAPFJIFMI()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		if (PJNGMCJIHME.firstDayRentingRooms)
		{
			if (Utils.HOHLHGJHOKM(Vector2.op_Implicit(PJNGMCJIHME.rentedRoom.zone.positions[1])))
			{
				PJNGMCJIHME.customerSpeech.DMMBKMKEAGF("UI2");
			}
			else
			{
				PJNGMCJIHME.customerSpeech.KAHLPENJLOJ("tutorialPopUp115");
			}
			if (PJNGMCJIHME.roomRequest != null)
			{
				TavernServiceManager.IFPLPBMCKLB().LBOGKHJGOFH(PJNGMCJIHME.roomRequest.finalPrice);
			}
			int num = (int)((float)PJNGMCJIHME.rentedRoom.CalculateReputation() * PJNGMCJIHME.rentedRoom.repPositiveMultiplier * PJNGMCJIHME.NGDAJGCPJEC);
			if (num > 0 && PJNGMCJIHME.roomRequest != null)
			{
				num *= PJNGMCJIHME.roomRequest.daysToStay;
			}
			TavernReputation.AddAndShowReputationGain(num, Vector2.op_Implicit(((Component)PJNGMCJIHME).transform.position), ((Component)PJNGMCJIHME).transform, PJNGMCJIHME.NGDAJGCPJEC);
			Utils.FKKHJPEMNBG("Player/Bark/Tutorial/AgingBarrelBlock", 0);
		}
	}

	private void KGBIAIPNDOP()
	{
		if (Object.op_Implicit((Object)(object)PJNGMCJIHME.rentedRoom))
		{
			if (PJNGMCJIHME.firstDayRentingRooms)
			{
				PJNGMCJIHME.rentedRoom.SetNewCustomerInRoom(PJNGMCJIHME.npc.characterCreator.humanInfo, PJNGMCJIHME.roomRequest.daysToStay, CDPAMNIPPEC: true);
			}
			else
			{
				PJNGMCJIHME.rentedRoom.SetCustomerInRoom(CDPAMNIPPEC: true);
			}
		}
		Utils.BLPDAEHPOBA(((Component)PJNGMCJIHME).gameObject, 844f);
	}

	private IEnumerator JPIKEKNLOAK()
	{
		while (true)
		{
			bool flag;
			try
			{
				flag = KPGFBMODODB();
			}
			catch (Exception ex)
			{
				Debug.LogError((object)ex);
				break;
			}
			if (!flag)
			{
				break;
			}
			yield return CommonReferences.wait1;
		}
		GCAFIGOCEKH();
	}
}
