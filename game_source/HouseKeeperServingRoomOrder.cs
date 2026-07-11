using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeperServingRoomOrder : HouseKeeperBaseState
{
	[CompilerGenerated]
	private sealed class KDPLPOCCBKB
	{
		public Animator animator;

		internal void CCMNDPOJOEB()
		{
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private List<CustomerOrder> customersOrders;

	private CustomerOrder customerOrder;

	private void CJOMBMDJKBD()
	{
		customerOrder = LJBCIGADMCK();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK(0, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void FFHDFKJKGAA()
	{
		customerOrder = LNIKJMHPDDK();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void AFGHHGHKMIP()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.ServeRoomCustomer(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		DKKCHLOAMBJ();
	}

	private CustomerOrder LEELPKIDKHN()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i += 0)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.IPKBBGHCJNE())
			{
				if (houseKeeper.trayHandler.tray.OHAPOKICCNK(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void NDOGNNGLCHI()
	{
		customerOrder = JALAAOODHIH();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK();
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void CFCGMAFEKMB()
	{
		customerOrder = IPNJEMFMMOP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void POJNAPFIJBO()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OJNGOEHODEO(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false, 1);
			houseKeeper.customerOrder = null;
		}
		PEDFGPGOLNA();
	}

	private void NAIBCKHDGKE()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OJNGOEHODEO(1, houseKeeper.trayHandler.tray, houseKeeper);
			houseKeeper.customerOrder = null;
		}
		MCFHKLDDIDI();
	}

	private CustomerOrder LJGOEMBGDEP()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.JLCBECDECBP())
			{
				if (houseKeeper.trayHandler.tray.HLPNLBHBIFL(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)houseKeeper.customerOrder == (Object)null || !houseKeeper.customerOrder.requesting)
		{
			JHMPNKBFCKF();
		}
	}

	private CustomerOrder PGIKAIIGMOF()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.BIIJEMDLBDP())
			{
				if (houseKeeper.trayHandler.tray.IIPPFEHNLKB(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void DKKCHLOAMBJ()
	{
		customerOrder = KAIAAOLJAPL();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.FIJLPLJMJFA();
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void GKJEPDLCEHE()
	{
		customerOrder = IHLAIJCOKJP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MOFBGCELGFN(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void OCOPNGJIOFC()
	{
		customerOrder = PAMFIPFAKIM();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LMBGCNCJBMA();
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder LFMGKBPAHKN()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.MNAILNGHBFF(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void NCANJOFIPFI()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.FINFOOHHAGB(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		HIKLLEBDPMO();
	}

	private void JHMPNKBFCKF()
	{
		customerOrder = HCPJFINPEKP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM();
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void LAFHEOPCGCJ()
	{
		customerOrder = LJBCIGADMCK();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LDPHJNIPDJA(0);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void HFIHNHMMDKO()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EAKDJBOJFJJ(1, houseKeeper.trayHandler.tray, houseKeeper);
			houseKeeper.customerOrder = null;
		}
		BKIIJLOJIDB();
	}

	private void MHBBGFODHPE()
	{
		customerOrder = KAIAAOLJAPL();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LMBGCNCJBMA(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void JDACKOGAFIH()
	{
		customerOrder = PGNPMNCCEBF();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void JPBIKNOPKMN()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EHPNDEFLMLL(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		OCOPNGJIOFC();
	}

	private void AOFKFAOPPNL()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.BMLGDIBOAJO(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		PHFAEIIKBDK();
	}

	private void EOFMNLMKMAI()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OOEMCJFBDCI(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		LMCOFJLLLHF();
	}

	private void BKIIJLOJIDB()
	{
		customerOrder = PHKJKNAAFFO();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK(0, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder KMKBFKAEHGF()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.IIPPFEHNLKB(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder JALAAOODHIH()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GetRoomOrders().Count; i += 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.BAHJFDHLDEI())
			{
				if (houseKeeper.trayHandler.tray.BCNKFHHDMAG(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder DPKBNIAHHII()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IPKBBGHCJNE())
			{
				if (houseKeeper.trayHandler.tray.FPNEGBNKILJ(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder LJBCIGADMCK()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.JLCBECDECBP())
			{
				if (houseKeeper.trayHandler.tray.CJDPJHKCPFA(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder EGBMNNKNOMD()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.BAHJFDHLDEI())
			{
				if (houseKeeper.trayHandler.tray.PKIIMJBGCDP(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void KGCJJJNLNLB()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.ServeRoomCustomer(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false, 1);
			houseKeeper.customerOrder = null;
		}
		NLKPDIFANDA();
	}

	private CustomerOrder JOPCFNBDHAE()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i += 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.BIIJEMDLBDP())
			{
				if (houseKeeper.trayHandler.tray.IIPPFEHNLKB(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder KOOMBFHEFOO()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.CJDPJHKCPFA(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void OBBEJFELEBK()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.GCDAOAKLJMN(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		CJOMBMDJKBD();
	}

	private void MGDOHGDDNIO()
	{
		customerOrder = LCGHKIJBJCJ();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MOFBGCELGFN();
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void ALPLLJHLOJL()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EAKDJBOJFJJ(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		OCOPNGJIOFC();
	}

	private CustomerOrder IHLAIJCOKJP()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IPKBBGHCJNE())
			{
				if (houseKeeper.trayHandler.tray.OHAPOKICCNK(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder CJOALNIJBGG()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i += 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.HADIAMMDNKB(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void BPJAAPDELPN()
	{
		customerOrder = KMKBFKAEHGF();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.IOCOONMEGLI(0, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder FDJBCGAKNFE()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.IIPPFEHNLKB(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void LBCGIBONCHN()
	{
		customerOrder = DPKBNIAHHII();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder GFFOPENAAKI()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.CJDPJHKCPFA(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void MCKEMHFGKGB()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OOEMCJFBDCI(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		LAFHEOPCGCJ();
	}

	private CustomerOrder LNIKJMHPDDK()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.IPKBBGHCJNE())
			{
				if (houseKeeper.trayHandler.tray.PKIIMJBGCDP(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder NDOMLMCEJOE()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.BAHJFDHLDEI())
			{
				if (houseKeeper.trayHandler.tray.ELCABOAPCMH(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void GBLEMIDMFME()
	{
		customerOrder = KHPHMNCPIPB();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder KHMJBKKHFML()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.HLPNLBHBIFL(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void BPCCOOCDHAD()
	{
		customerOrder = PBNFGKIPIJH();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.ACDHANDNCNC();
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder PAMFIPFAKIM()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.BIIJEMDLBDP())
			{
				if (houseKeeper.trayHandler.tray.OHAPOKICCNK(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void EKNHPDAIKHO()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EFJLLLAEJFH(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		EKDOEPJAGEG();
	}

	private void LAOMNOJKJNG()
	{
		customerOrder = PNMHIDLIJJM();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder KAIAAOLJAPL()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.BIIJEMDLBDP())
			{
				if (houseKeeper.trayHandler.tray.AIMCMHBMIMP(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder HCPJFINPEKP()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.JEPBBEBJEFI())
			{
				if (houseKeeper.trayHandler.tray.OHAPOKICCNK(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void HIKLLEBDPMO()
	{
		customerOrder = IPDINABOGCH();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.ACDHANDNCNC(0, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void CIFKKICJLPB()
	{
		customerOrder = LBHDGOIAAMA();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LDPHJNIPDJA();
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void BNIENIFMOAM()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EFJLLLAEJFH(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		MGDOHGDDNIO();
	}

	private void LNIFINAHKBL()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.GCDAOAKLJMN(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		CBKDMBNCHHG();
	}

	private void IFFEMCDIEIN()
	{
		customerOrder = IHLAIJCOKJP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MOFBGCELGFN(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder HFLGEFAEHKJ()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.JEPBBEBJEFI())
			{
				if (houseKeeper.trayHandler.tray.OHAPOKICCNK(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void IAIHGPJIBJC()
	{
		customerOrder = KMKBFKAEHGF();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM(0, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder KHPHMNCPIPB()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IPKBBGHCJNE())
			{
				if (houseKeeper.trayHandler.tray.PKIIMJBGCDP(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void EKDOEPJAGEG()
	{
		customerOrder = LJGOEMBGDEP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder PHKJKNAAFFO()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.PKIIMJBGCDP(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void CIEONIBLNFN()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.ServeRoomCustomer(1, houseKeeper.trayHandler.tray, houseKeeper);
			houseKeeper.customerOrder = null;
		}
		JHMPNKBFCKF();
	}

	private CustomerOrder DCIDEJMNCMD()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.BCNKFHHDMAG(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder IPNJEMFMMOP()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i += 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.FPNEGBNKILJ(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void KCPIACOMBHG()
	{
		customerOrder = LNIKJMHPDDK();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void ACAGKMPCFLA()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.FINFOOHHAGB(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		GBLEMIDMFME();
	}

	private CustomerOrder KMAHIFBFDIO()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i += 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.BAHJFDHLDEI())
			{
				if (houseKeeper.trayHandler.tray.MNAILNGHBFF(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void NHKKOCEALCO()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OJNGOEHODEO(0, houseKeeper.trayHandler.tray, houseKeeper);
			houseKeeper.customerOrder = null;
		}
		EPEGPGOLMHC();
	}

	private void NLLGFLAOKON()
	{
		customerOrder = HEGCLGCCEHO();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM(0, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder CJLAPEIGPFI()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.BIIJEMDLBDP())
			{
				if (houseKeeper.trayHandler.tray.HLPNLBHBIFL(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void KDKMJJDHJCF()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EFJLLLAEJFH(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		LAFHEOPCGCJ();
	}

	private void BOLNLHPANHD()
	{
		customerOrder = HFLGEFAEHKJ();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.NBODABCGELG(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void MBGCFBJNLEB()
	{
		customerOrder = KMKBFKAEHGF();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.ACDHANDNCNC(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder NMOBMKLKDIK()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.BAHJFDHLDEI())
			{
				if (houseKeeper.trayHandler.tray.FPNEGBNKILJ(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void HEFKHMHCAED()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EFJLLLAEJFH(1, houseKeeper.trayHandler.tray, houseKeeper);
			houseKeeper.customerOrder = null;
		}
		KCPIACOMBHG();
	}

	private CustomerOrder PBNFGKIPIJH()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.IPKBBGHCJNE())
			{
				if (houseKeeper.trayHandler.tray.AIMCMHBMIMP(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder DEMCKOLMADA()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.JEPBBEBJEFI())
			{
				if (houseKeeper.trayHandler.tray.AIMCMHBMIMP(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void OIACIEFEHPG()
	{
		customerOrder = PNMHIDLIJJM();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void NOENDPDGKAF()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.ServeRoomCustomer(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		CIFKKICJLPB();
	}

	private void LPPFFEBFIIC()
	{
		customerOrder = KHMJBKKHFML();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder ONHEFAGBFAL()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.ELCABOAPCMH(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void HKDPMMEAHHK()
	{
		customerOrder = DHALIBEGKHF();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK(0);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void DGPFIJMPOGI()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.BMLGDIBOAJO(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		LBCGIBONCHN();
	}

	private CustomerOrder IDNKPDGOHCF()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.HLPNLBHBIFL(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder PGNPMNCCEBF()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.ELCABOAPCMH(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder LKAKMHBIINP()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.JLCBECDECBP())
			{
				if (houseKeeper.trayHandler.tray.BCNKFHHDMAG(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void ENBKAKJMJFL()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.NACIDEMFDDJ(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		LAOMNOJKJNG();
	}

	private void AFBCNPAPNLF()
	{
		customerOrder = PNMHIDLIJJM();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MOFBGCELGFN(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void CFNNJOLOPJI()
	{
		customerOrder = KHMJBKKHFML();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LDPHJNIPDJA(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder EMCNEFFDICM()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.JEPBBEBJEFI())
			{
				if (houseKeeper.trayHandler.tray.FPNEGBNKILJ(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.OEONGPFALKH.IIMEFNIECLI();
	}

	private CustomerOrder IJBCCOAJDOB()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.BIIJEMDLBDP())
			{
				if (houseKeeper.trayHandler.tray.PKIIMJBGCDP(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder FKCPAMMDMBP()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.BIIJEMDLBDP())
			{
				if (houseKeeper.trayHandler.tray.HLPNLBHBIFL(RentedRoomsManager.GetRoomOrders()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder IPDINABOGCH()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.CJDPJHKCPFA(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void NHMGFOAHFGK()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EAKDJBOJFJJ(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		EPEGPGOLMHC();
	}

	private void PKLMKKOIFGD()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.FINFOOHHAGB(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		GKJEPDLCEHE();
	}

	private void GGKBFHNGEKN()
	{
		customerOrder = KMKBFKAEHGF();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LMBGCNCJBMA(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void NLEGCDFKEDO()
	{
		customerOrder = JALAAOODHIH();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.IOCOONMEGLI();
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void LMCOFJLLLHF()
	{
		customerOrder = HCPJFINPEKP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.IOCOONMEGLI(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void FICJLIFBHLP()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OOEMCJFBDCI(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false, 1);
			houseKeeper.customerOrder = null;
		}
		BPCCOOCDHAD();
	}

	private void FCONJNGJFIG()
	{
		customerOrder = CJLAPEIGPFI();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void FMGLOFFJKIM()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EFJLLLAEJFH(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false, 1);
			houseKeeper.customerOrder = null;
		}
		OCOPNGJIOFC();
	}

	private void GAGHAPHIFFN()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.BMLGDIBOAJO(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		BMFMEIFIHDK();
	}

	private void EPEGPGOLMHC()
	{
		customerOrder = IPDINABOGCH();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.IOCOONMEGLI(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void KJLADIHJOIO()
	{
		customerOrder = LJGOEMBGDEP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.FIJLPLJMJFA();
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.houseKeeperState = HouseKeeperState.ServingRoomOrder;
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
			{
				houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(houseKeeper.customerOrder.rentedRoomDoor.orderPositionBelow.position));
			}
			else
			{
				houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(houseKeeper.customerOrder.rentedRoomDoor.orderPositionAbove.position));
			}
			NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CIEONIBLNFN));
			NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			});
			houseKeeper.OEONGPFALKH.PEHELKCIECB();
		}
		else
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void BMFMEIFIHDK()
	{
		customerOrder = IPDINABOGCH();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LMBGCNCJBMA();
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void PHFAEIIKBDK()
	{
		customerOrder = EGBMNNKNOMD();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK();
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder PIINEBLHEMD()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i += 0)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.ELCABOAPCMH(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void JBAGMINAOPJ()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OJNGOEHODEO(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		HDGJBENPFOF();
	}

	private void LCNMALONBKD()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OOEMCJFBDCI(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false, 1);
			houseKeeper.customerOrder = null;
		}
		BNJLEFFGEIA();
	}

	private CustomerOrder DHALIBEGKHF()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.IIPPFEHNLKB(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void FMPKPBGCNDG()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.NACIDEMFDDJ(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		KCPIACOMBHG();
	}

	private CustomerOrder LCGHKIJBJCJ()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.JLCBECDECBP())
			{
				if (houseKeeper.trayHandler.tray.HADIAMMDNKB(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder PNMHIDLIJJM()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.KEGINBPMPNA().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.BAHJFDHLDEI())
			{
				if (houseKeeper.trayHandler.tray.BCNKFHHDMAG(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[0];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder LBHDGOIAAMA()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i += 0)
		{
			if (RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest.IPKBBGHCJNE())
			{
				if (houseKeeper.trayHandler.tray.HADIAMMDNKB(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 1)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private CustomerOrder CGCALJMJONN()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GLJNFKFJMFF().Count; i++)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.IJLGJNLFNDB())
			{
				if (houseKeeper.trayHandler.tray.HADIAMMDNKB(RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void PEDFGPGOLNA()
	{
		customerOrder = IJBCCOAJDOB();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.IOCOONMEGLI(0);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void HHHJBEMBLOP()
	{
		customerOrder = IPNJEMFMMOP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LMBGCNCJBMA();
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void IPOMIMFHBOC()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.EAKDJBOJFJJ(0, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		FCONJNGJFIG();
	}

	private void HDGJBENPFOF()
	{
		customerOrder = PHKJKNAAFFO();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK();
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void IPJPFNKNNGL()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.NACIDEMFDDJ(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		HKDPMMEAHHK();
	}

	private void CMDBPCFJBID()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OOEMCJFBDCI(1, houseKeeper.trayHandler.tray, houseKeeper);
			houseKeeper.customerOrder = null;
		}
		EKDOEPJAGEG();
	}

	private void OIGIAKBBBHP()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OJNGOEHODEO(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: false);
			houseKeeper.customerOrder = null;
		}
		AFBCNPAPNLF();
	}

	private CustomerOrder DHEONAOKCDP()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.BAHJFDHLDEI())
			{
				if (houseKeeper.trayHandler.tray.PKIIMJBGCDP(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.KEGINBPMPNA()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void CBKDMBNCHHG()
	{
		customerOrder = FKCPAMMDMBP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.LMBGCNCJBMA(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private CustomerOrder HEGCLGCCEHO()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 1; i < RentedRoomsManager.GetRoomOrders().Count; i += 0)
		{
			if (RentedRoomsManager.KEGINBPMPNA()[i].roomItemRequest.JLCBECDECBP())
			{
				if (houseKeeper.trayHandler.tray.ELCABOAPCMH(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}

	private void MCFHKLDDIDI()
	{
		customerOrder = LKAKMHBIINP();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MOFBGCELGFN(1, GFNHAMCPEAK: false);
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void NLKPDIFANDA()
	{
		customerOrder = PAMFIPFAKIM();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void OEKNIKOJNGO()
	{
		customerOrder = LBHDGOIAAMA();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.OHAJMGCPGMK(0);
			houseKeeper.StartTask();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void BNJLEFFGEIA()
	{
		customerOrder = LEELPKIDKHN();
		if ((Object)(object)customerOrder == (Object)null)
		{
			houseKeeper.trayHandler.tray.MKBDMMJCGGM();
			houseKeeper.GAAHCGLGHKG();
		}
		else
		{
			houseKeeper.customerOrder = customerOrder;
			houseKeeper.behaviour.SetTrigger(StaffBaseState.p_ServingRoomOrder);
		}
	}

	private void PJOBGBOBMPH()
	{
		if (houseKeeper.customerOrder.rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Down);
		}
		else
		{
			houseKeeper.characterAnimation.LookDirection(Direction.Up);
		}
		if ((Object)(object)houseKeeper.customerOrder != (Object)null)
		{
			houseKeeper.customerOrder.OJNGOEHODEO(1, houseKeeper.trayHandler.tray, houseKeeper, CDPAMNIPPEC: true, 1);
			houseKeeper.customerOrder = null;
		}
		GGKBFHNGEKN();
	}

	private CustomerOrder KCOJJCGFNOL()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (!houseKeeper.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		customersOrders = new List<CustomerOrder>();
		for (int i = 0; i < RentedRoomsManager.GetRoomOrders().Count; i++)
		{
			if (RentedRoomsManager.GetRoomOrders()[i].roomItemRequest.AJKDEIPDLHI())
			{
				if (houseKeeper.trayHandler.tray.OHAPOKICCNK(RentedRoomsManager.GLJNFKFJMFF()[i].roomItemRequest))
				{
					customersOrders.Add(RentedRoomsManager.GLJNFKFJMFF()[i]);
				}
			}
			else
			{
				customersOrders.Add(RentedRoomsManager.GetRoomOrders()[i]);
			}
		}
		if (customersOrders.Count == 0)
		{
			return customersOrders[1];
		}
		if (customersOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(customersOrders.ToArray(), ((Component)houseKeeper).transform.position);
		}
		return null;
	}
}
