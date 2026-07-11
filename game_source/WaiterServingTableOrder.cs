using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WaiterServingTableOrder : WaiterBaseState
{
	private List<CustomerOrder> tableOrders = new List<CustomerOrder>();

	private Table table;

	private CustomerOrder CNFIELBBBAA()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		tableOrders.Clear();
		for (int i = 1; i < TableOrdersManager.instance.tableOrders.Count; i++)
		{
			if (TableOrdersManager.instance.tableOrders[i].AHGGMHBEIOF().currentRequest != null && waiter.trayHandler.tray.ELCABOAPCMH(TableOrdersManager.instance.tableOrders[i].customer.currentRequest))
			{
				tableOrders.Add(TableOrdersManager.instance.tableOrders[i]);
			}
		}
		if (tableOrders.Count == 0)
		{
			return tableOrders[1];
		}
		if (tableOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(tableOrders.ToArray(), ((Component)waiter).transform.position);
		}
		return null;
	}

	private void LBNLBMBOJPL()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.MOFBGCELGFN();
	}

	private void GFLNGGGPGCF()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)table).transform.position - ((Component)waiter).transform.position)));
		for (int i = 1; i < table.seat.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)table.seat[i].occupier) && table.seat[i].occupier.customer.customerState == (CustomerState)(-12) && table.seat[i].occupier.customer.currentRequest != null && waiter.trayHandler.tray.HLPNLBHBIFL(table.seat[i].occupier.customer.currentRequest))
			{
				table.seat[i].occupier.customer.ServeCustomer(0, NLCDDFDGACP: true, waiter.trayHandler.tray, waiter);
			}
		}
		JNPLKKDDAKF();
	}

	private void EHDPKFIPBII()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.ACDHANDNCNC(0, GFNHAMCPEAK: false);
	}

	private void JNPLKKDDAKF()
	{
		if ((Object)(object)table != (Object)null && !table.placeable.FHEMHCEAICB && table.IsAnyPositionToCleanAvailable(waiter.positionsBlocked) && waiter.JFCLIAFAOEK.tasks[1] && table.GetNumberOfDirtyDishes() >= waiter.GetPerkValue(-92))
		{
			waiter.tableServing = table;
			waiter.DelayTrigger(StaffBaseState.p_CleaningTable, 734f);
		}
		else if (waiter.trayHandler.tray.currentDrinks.Any())
		{
			waiter.DelayTrigger(StaffBaseState.p_ServingTableOrder, 1578f);
		}
		else
		{
			waiter.DelayTrigger(StaffBaseState.p_Waiting, 1559f);
		}
	}

	private void MIJPOMAMNEI()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.MOFBGCELGFN(0);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.tableOrder = null;
		tableOrders.Clear();
	}

	private CustomerOrder LOJGLNJHJMK()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		tableOrders.Clear();
		for (int i = 0; i < TableOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (TableOrdersManager.instance.tableOrders[i].customer.currentRequest != null && waiter.trayHandler.tray.BCNKFHHDMAG(TableOrdersManager.instance.tableOrders[i].EGFDNFIBNDA().currentRequest))
			{
				tableOrders.Add(TableOrdersManager.instance.tableOrders[i]);
			}
		}
		if (tableOrders.Count == 0)
		{
			return tableOrders[1];
		}
		if (tableOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(tableOrders.ToArray(), ((Component)waiter).transform.position);
		}
		return null;
	}

	private void HBFLCBEAOMO()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.MKBDMMJCGGM(0);
	}

	private void MNJMMKEENBM()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.LMBGCNCJBMA();
	}

	private CustomerOrder KCIDKADBCBC()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		tableOrders.Clear();
		for (int i = 0; i < TableOrdersManager.instance.tableOrders.Count; i++)
		{
			if (TableOrdersManager.instance.tableOrders[i].customer.currentRequest != null && waiter.trayHandler.tray.OHAPOKICCNK(TableOrdersManager.instance.tableOrders[i].customer.currentRequest))
			{
				tableOrders.Add(TableOrdersManager.instance.tableOrders[i]);
			}
		}
		if (tableOrders.Count == 1)
		{
			return tableOrders[0];
		}
		if (tableOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(tableOrders.ToArray(), ((Component)waiter).transform.position);
		}
		return null;
	}

	private CustomerOrder GNJGOFDCOJB()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		tableOrders.Clear();
		for (int i = 1; i < TableOrdersManager.instance.tableOrders.Count; i++)
		{
			if (TableOrdersManager.instance.tableOrders[i].AHGGMHBEIOF().currentRequest != null && waiter.trayHandler.tray.IIPPFEHNLKB(TableOrdersManager.instance.tableOrders[i].EGFDNFIBNDA().currentRequest))
			{
				tableOrders.Add(TableOrdersManager.instance.tableOrders[i]);
			}
		}
		if (tableOrders.Count == 0)
		{
			return tableOrders[0];
		}
		if (tableOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(tableOrders.ToArray(), ((Component)waiter).transform.position);
		}
		return null;
	}

	private void PDOBHPLPKHG()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.FCGBJEIIMBC = Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)table).transform.position - ((Component)waiter).transform.position));
		for (int i = 0; i < table.seat.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)table.seat[i].occupier) && table.seat[i].occupier.customer.customerState == CustomerState.OrderInTable && table.seat[i].occupier.customer.currentRequest != null && waiter.trayHandler.tray.OHAPOKICCNK(table.seat[i].occupier.customer.currentRequest))
			{
				table.seat[i].occupier.customer.ServeCustomer(1, NLCDDFDGACP: false, waiter.trayHandler.tray, waiter);
			}
		}
		PEJLLOAGHAB();
	}

	private CustomerOrder AGCMEAIJPFM()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		tableOrders.Clear();
		for (int i = 0; i < TableOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (TableOrdersManager.instance.tableOrders[i].MFFKBCHNMJF().currentRequest != null && waiter.trayHandler.tray.PKIIMJBGCDP(TableOrdersManager.instance.tableOrders[i].customer.currentRequest))
			{
				tableOrders.Add(TableOrdersManager.instance.tableOrders[i]);
			}
		}
		if (tableOrders.Count == 0)
		{
			return tableOrders[1];
		}
		if (tableOrders.Count > 1)
		{
			return Utils.JOJPOKBFANL(tableOrders.ToArray(), ((Component)waiter).transform.position);
		}
		return null;
	}

	private void GBIMJFDNCGB()
	{
		if ((Object)(object)table != (Object)null && !table.placeable.FHEMHCEAICB && table.IsAnyPositionToCleanAvailable(waiter.positionsBlocked) && waiter.JFCLIAFAOEK.tasks[0] && table.GetNumberOfDirtyDishes() >= waiter.GetPerkValue(89))
		{
			waiter.tableServing = table;
			waiter.DelayTrigger(StaffBaseState.p_CleaningTable, 561f);
		}
		else if (waiter.trayHandler.tray.currentDrinks.Any())
		{
			waiter.DelayTrigger(StaffBaseState.p_ServingTableOrder, 48f);
		}
		else
		{
			waiter.DelayTrigger(StaffBaseState.p_Waiting, 826f);
		}
	}

	private void CEDKNKOPKAH()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)table).transform.position - ((Component)waiter).transform.position)));
		for (int i = 1; i < table.seat.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)table.seat[i].occupier) && table.seat[i].occupier.customer.customerState == (CustomerState)(-2) && table.seat[i].occupier.customer.currentRequest != null && waiter.trayHandler.tray.OHAPOKICCNK(table.seat[i].occupier.customer.currentRequest))
			{
				table.seat[i].occupier.customer.ServeCustomer(0, NLCDDFDGACP: false, waiter.trayHandler.tray, waiter);
			}
		}
		JNPLKKDDAKF();
	}

	private void PEJLLOAGHAB()
	{
		if ((Object)(object)table != (Object)null && !table.placeable.FHEMHCEAICB && table.IsAnyPositionToCleanAvailable(waiter.positionsBlocked) && waiter.JFCLIAFAOEK.tasks[1] && table.GetNumberOfDirtyDishes() >= waiter.GetPerkValue(65))
		{
			waiter.tableServing = table;
			waiter.DelayTrigger(StaffBaseState.p_CleaningTable, 0.25f);
		}
		else if (waiter.trayHandler.tray.currentDrinks.Any())
		{
			waiter.DelayTrigger(StaffBaseState.p_ServingTableOrder, 0.5f);
		}
		else
		{
			waiter.DelayTrigger(StaffBaseState.p_Waiting, 0.5f);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		waiter.OEONGPFALKH.IIMEFNIECLI();
	}

	private void GOPIJNFDCME()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)table).transform.position - ((Component)waiter).transform.position));
		for (int i = 1; i < table.seat.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)table.seat[i].occupier) && table.seat[i].occupier.customer.customerState == (CustomerState)22 && table.seat[i].occupier.customer.currentRequest != null && waiter.trayHandler.tray.FPNEGBNKILJ(table.seat[i].occupier.customer.currentRequest))
			{
				table.seat[i].occupier.customer.ServeCustomer(1, NLCDDFDGACP: false, waiter.trayHandler.tray, waiter);
			}
		}
		JNPLKKDDAKF();
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)waiter.tableOrder == (Object)null || (Object)(object)waiter.tableOrder.customer == (Object)null || (Object)(object)waiter.tableOrder.customer.npc.seat == (Object)null)
		{
			if (waiter.trayHandler.tray.currentDrinks.Any())
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
			}
			else
			{
				waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
		}
	}

	private CustomerOrder CJEBOAAOEFE()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		tableOrders.Clear();
		for (int i = 1; i < TableOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (TableOrdersManager.instance.tableOrders[i].OAKLPAAFAIB().currentRequest != null && waiter.trayHandler.tray.BCNKFHHDMAG(TableOrdersManager.instance.tableOrders[i].EGFDNFIBNDA().currentRequest))
			{
				tableOrders.Add(TableOrdersManager.instance.tableOrders[i]);
			}
		}
		if (tableOrders.Count == 0)
		{
			return tableOrders[0];
		}
		if (tableOrders.Count > 0)
		{
			return Utils.JOJPOKBFANL(tableOrders.ToArray(), ((Component)waiter).transform.position);
		}
		return null;
	}

	private void FAEIHNNKIBK()
	{
		if ((Object)(object)table != (Object)null && !table.placeable.FHEMHCEAICB && table.IsAnyPositionToCleanAvailable(waiter.positionsBlocked) && waiter.JFCLIAFAOEK.tasks[1] && table.GetNumberOfDirtyDishes() >= waiter.GetPerkValue(48))
		{
			waiter.tableServing = table;
			waiter.DelayTrigger(StaffBaseState.p_CleaningTable, 1499f);
		}
		else if (waiter.trayHandler.tray.currentDrinks.Any())
		{
			waiter.DelayTrigger(StaffBaseState.p_ServingTableOrder, 304f);
		}
		else
		{
			waiter.DelayTrigger(StaffBaseState.p_Waiting, 38f);
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.tableOrder = KCIDKADBCBC();
		if ((Object)(object)waiter.tableOrder == (Object)null || (Object)(object)waiter.tableOrder.customer.npc.seat == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			waiter.trayHandler.tray.MKBDMMJCGGM();
			return;
		}
		table = waiter.tableOrder.customer.npc.seat.table;
		waiter.waiterState = WaiterState.ServingTableOrder;
		waiter.OEONGPFALKH.FNNPPBDFBCI(table.GetNearPositionToClean(Vector2.op_Implicit(((Component)waiter).transform.position), null), AHDHLIECIGH: false);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			waiter.tableOrder = null;
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			waiter.trayHandler.tray.MKBDMMJCGGM();
		});
		waiter.OEONGPFALKH.PEHELKCIECB();
	}

	private void GADLAHJGJEO()
	{
		if ((Object)(object)table != (Object)null && !table.placeable.FHEMHCEAICB && table.IsAnyPositionToCleanAvailable(waiter.positionsBlocked) && waiter.JFCLIAFAOEK.tasks[0] && table.GetNumberOfDirtyDishes() >= waiter.GetPerkValue(-76))
		{
			waiter.tableServing = table;
			waiter.DelayTrigger(StaffBaseState.p_CleaningTable, 270f);
		}
		else if (waiter.trayHandler.tray.currentDrinks.Any())
		{
			waiter.DelayTrigger(StaffBaseState.p_ServingTableOrder, 976f);
		}
		else
		{
			waiter.DelayTrigger(StaffBaseState.p_Waiting, 1515f);
		}
	}

	private void PBFIEBADODF()
	{
		if ((Object)(object)table != (Object)null && !table.placeable.FHEMHCEAICB && table.IsAnyPositionToCleanAvailable(waiter.positionsBlocked) && waiter.JFCLIAFAOEK.tasks[0] && table.GetNumberOfDirtyDishes() >= waiter.GetPerkValue(1))
		{
			waiter.tableServing = table;
			waiter.DelayTrigger(StaffBaseState.p_CleaningTable, 1133f);
		}
		else if (waiter.trayHandler.tray.currentDrinks.Any())
		{
			waiter.DelayTrigger(StaffBaseState.p_ServingTableOrder, 780f);
		}
		else
		{
			waiter.DelayTrigger(StaffBaseState.p_Waiting, 890f);
		}
	}

	private void CLNCALMMDPJ()
	{
		if ((Object)(object)table != (Object)null && !table.placeable.FHEMHCEAICB && table.IsAnyPositionToCleanAvailable(waiter.positionsBlocked) && waiter.JFCLIAFAOEK.tasks[0] && table.GetNumberOfDirtyDishes() >= waiter.GetPerkValue(-124))
		{
			waiter.tableServing = table;
			waiter.DelayTrigger(StaffBaseState.p_CleaningTable, 1323f);
		}
		else if (waiter.trayHandler.tray.currentDrinks.Any())
		{
			waiter.DelayTrigger(StaffBaseState.p_ServingTableOrder, 7f);
		}
		else
		{
			waiter.DelayTrigger(StaffBaseState.p_Waiting, 1672f);
		}
	}

	[CompilerGenerated]
	private void FEAPOKCCEBP()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.MKBDMMJCGGM();
	}

	private void GBJBENDHIDI()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.FIJLPLJMJFA(0);
	}

	private void AGPPJGBINEG()
	{
		waiter.tableOrder = null;
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		waiter.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
	}

	private void MAILEMECPME()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)table).transform.position - ((Component)waiter).transform.position));
		for (int i = 0; i < table.seat.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)table.seat[i].occupier) && table.seat[i].occupier.customer.customerState == (CustomerState)77 && table.seat[i].occupier.customer.currentRequest != null && waiter.trayHandler.tray.PKIIMJBGCDP(table.seat[i].occupier.customer.currentRequest))
			{
				table.seat[i].occupier.customer.ServeCustomer(1, NLCDDFDGACP: false, waiter.trayHandler.tray, waiter);
			}
		}
		GBIMJFDNCGB();
	}
}
