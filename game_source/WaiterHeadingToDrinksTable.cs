using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WaiterHeadingToDrinksTable : WaiterBaseState
{
	private void OHHLABNIEFG()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void IJKIFECCGEP()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Up;
		DrinksTable.instance.FGFIBIELLIC(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void IIEGDHJEEKC()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Up;
		DrinksTable.instance.MMCECCBBBDL(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void FIKLNLMANCH()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.DKFFNIGKNPP(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void IGOGKMLCLPI()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.GJNFDDPOMJE(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void OGBEGBJDNKJ()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.TakeDrinksFromTable(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void FLMLNPMJIJK()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HILLNFIICFK()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Down);
		DrinksTable.instance.GJNFDDPOMJE(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void AJNCHDGJHOI()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EBLFKBEMCKL()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Down);
		DrinksTable.instance.DAPFNHCDBMJ(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	[CompilerGenerated]
	private void EBJICJNAFDB()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void MOOGNGIMGLN()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CNJMNBAKEEK()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.GLAOPEIGJLN(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void GOPIJNFDCME()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.BPCMPDNOGJH(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void PFPACOIJOBF()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EEPKEKLJNDP()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void IFMAJLPPADF()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DJNOFCBINHM()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.TakeDrinksFromTable(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void HIHOOJDADFM()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void APGLLOHDPHO()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Down);
		DrinksTable.instance.FGFIBIELLIC(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void PDOBHPLPKHG()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Up;
		DrinksTable.instance.TakeDrinksFromTable(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void IKOIKCHBBNG()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Up;
		DrinksTable.instance.MMCECCBBBDL(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void AOECEGFIODA()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JJJIFKOAFON()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.waiterState = WaiterState.HeadingToDrinksTable;
		waiter.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(DrinksTable.instance.waiterPos.position));
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		});
		waiter.OEONGPFALKH.PEHELKCIECB();
	}

	private void CLOEFOFKDFC()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Up;
		DrinksTable.instance.FGFIBIELLIC(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void PBBBJBHFGNN()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.ICGENOOPBNI(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void IEJGDOPLBLB()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.BPCMPDNOGJH(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void ABMMONFHFGF()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.DAPFNHCDBMJ(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void MAILEMECPME()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Down);
		DrinksTable.instance.TakeDrinksFromTable(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void KNGGNKILOLI()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JJEDBGNFDMM()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JGLIBANKFCK()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void EBLEAJFOEJL()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.MMCECCBBBDL(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void EENFPNBHCIA()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void COACMHKHDBL()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.DKFFNIGKNPP(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void FOEBEJHKEKE()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.MMCECCBBBDL(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void FEHGALEDJKI()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.ICGENOOPBNI(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void HFNILMKAKLM()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FBAJNIFGECM()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HFLKMPBGNGE()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void FOMBKAFNPBL()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CKLPPPMGEDD()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HJDBMFCAJHJ()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Down);
		DrinksTable.instance.GLAOPEIGJLN(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void KPMCGMJJBEA()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.TakeDrinksFromTable(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void LLHCABGCKGI()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void AAPBBHOHMIJ()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Down);
		DrinksTable.instance.GLAOPEIGJLN(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void AHPFECCLOBB()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.FGFIBIELLIC(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void LACDAMFANIM()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.GJNFDDPOMJE(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void GBCLMMCEBKC()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void JLBMCMCCDNN()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.DAPFNHCDBMJ(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void BEEDFJOOPAH()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.GLAOPEIGJLN(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void NBDDLOKNGCL()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void BFNAPCFJKKB()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Up;
		DrinksTable.instance.BPCMPDNOGJH(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void AGLDNOHPHFD()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.DKFFNIGKNPP(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void LHAFBCALKBN()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void OPPGIPAGEOC()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void HEEOHKBPMAI()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(0);
		waiter.characterAnimation.FCGBJEIIMBC = Direction.Down;
		DrinksTable.instance.DAPFNHCDBMJ(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void KKDGJFFLCJC()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NOOBCABMHAO()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void IDBCMIMFHJC()
	{
		CommonReferences.MNFMOEKMJKN().OnWaiterGoingToWork(1);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.GLAOPEIGJLN(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}

	private void JHMAINNNMBA()
	{
		waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (DrinksTable.instance.currentDrinks.Count == 0)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
		else
		{
			waiter.OEONGPFALKH.IIMEFNIECLI();
		}
	}

	private void EIAMODMOLIL()
	{
		CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(0);
		waiter.characterAnimation.NCAJNNHBHJM(Direction.Up);
		DrinksTable.instance.ICGENOOPBNI(waiter.trayHandler.tray, waiter);
		waiter.behaviour.SetTrigger(StaffBaseState.p_ServingTableOrder);
	}
}
