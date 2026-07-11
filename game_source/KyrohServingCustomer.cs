using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.Utilities;
using UnityEngine;

public class KyrohServingCustomer : KyrohStateBase
{
	private float timer;

	private void NGDKBCODKLO()
	{
		KFFOEKHEMDE();
	}

	private void PLOPILENLJK()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(0, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void CIEONIBLNFN()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(0, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	public NinjaCustomer KLEHFIGKCCP()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
		return null;
	}

	private void NOFNCOOLPML()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = OGGJNJCFBOH();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.TakingFood);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.ChangeState(KyrohState.SwitchingFood);
	}

	private void FOGCIEMLAGL()
	{
		KJBELCGHNFP();
	}

	[CompilerGenerated]
	private void ENAFABOMBGM()
	{
		CIEONIBLNFN();
	}

	private void OIBMMKFGINL()
	{
		FMGLOFFJKIM();
	}

	public NinjaCustomer FMLCLFDPGDM()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
		return null;
	}

	public NinjaCustomer OHELHCEIMKL()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
		return null;
	}

	public NinjaCustomer OFNLCHHDBJC()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.NBODABCGELG();
		return null;
	}

	private void DLNAACJGHHO()
	{
		GMPKEJLNPKL();
	}

	public NinjaCustomer KNFMGGEECOM()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.OHAJMGCPGMK(0);
		return null;
	}

	private void FMPKPBGCNDG()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(0, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void ONGEPFNBPND()
	{
		FOBIOBIABJF();
	}

	public NinjaCustomer OGGJNJCFBOH()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LIHGILDLODK(0, GFNHAMCPEAK: false);
		return null;
	}

	private void ECBCDOKLDMP()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(1, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void IBPGIJMFHKO()
	{
		EBLGEBFLKGM();
	}

	private void MAAKHLLLPJA()
	{
		kyrohNPC.walkTo.isActive = true;
		NinjaCustomer ninjaCustomer = OFNLCHHDBJC();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.TakingFood);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.GLLDOLHPIBD(KyrohState.TakingFood);
	}

	private void KFFOEKHEMDE()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(0, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void EBLGEBFLKGM()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(0, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void DACDGMOODOL()
	{
		EBLGEBFLKGM();
	}

	private void GGOCJKFPCIK()
	{
		ECBCDOKLDMP();
	}

	public NinjaCustomer LGMGEBKHBME()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.FIJLPLJMJFA();
		return null;
	}

	private void FOBIOBIABJF()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(0, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void FMGLOFFJKIM()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(1, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void OBBEJFELEBK()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(1, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void LEINHANFOJI()
	{
		Debug.LogError((object)"P1Cam");
		kyrohNPC.FIOKAPKBCOD(KyrohState.PreparingFood);
	}

	public NinjaCustomer PELCHDAAKNI()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.ACDHANDNCNC();
		return null;
	}

	private void FJLNIANALKO()
	{
		Debug.LogError((object)"");
		kyrohNPC.FIOKAPKBCOD(KyrohState.PreparingFood);
	}

	private void AFGHHGHKMIP()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(0, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (kyrohNPC.walkTo.isActive && (Object)(object)kyrohNPC.customerServing != (Object)null && !kyrohNPC.customerServing.requesting)
		{
			JDEECHHFIMJ();
		}
	}

	private void PBMCOHJBCMC()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = KNFMGGEECOM();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.PreparingFood);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.KJBPJJBAAMK(KyrohState.ThrowingSpikes);
	}

	public NinjaCustomer IIAPKOJDJCA()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.NBODABCGELG();
		return null;
	}

	private void FDMALGFJPNO()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = DLCKOIMNNFG();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.WalkTo);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.ChangeState(KyrohState.PreparingFood);
	}

	private void GFGOALHGIKM()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(1, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void KAJJLDICJHP()
	{
		Debug.LogError((object)"Player2");
		kyrohNPC.ChangeState(KyrohState.WaitingToServe);
	}

	private void AFFECIEOKEC()
	{
		ECBCDOKLDMP();
	}

	private void MKEDHGFOOFK()
	{
		PJOBGBOBMPH();
	}

	private void DOIGFKKNIFL()
	{
		FMPKPBGCNDG();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		kyrohNPC.kyrohState = KyrohState.ServingCustomer;
		timer = 0f;
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
			kyrohNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(kyrohNPC.customerServing.positionToServe.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = kyrohNPC.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				CIEONIBLNFN();
			});
			NPCWalkTo walkTo2 = kyrohNPC.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				Debug.LogError((object)"Kyroh path not found to customer");
				kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			});
			kyrohNPC.walkTo.PEHELKCIECB();
		}
		else
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
		}
	}

	public NinjaCustomer BCJBCGEOHPI()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.MOFBGCELGFN();
		return null;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (kyrohNPC.walkTo.IIMEFNIECLI())
		{
			if (timer >= kyrohNPC.timeAfterServe)
			{
				JDEECHHFIMJ();
			}
			else
			{
				timer += Time.fixedDeltaTime;
			}
		}
	}

	public NinjaCustomer CECNIEMLPPI()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.MKBDMMJCGGM();
		return null;
	}

	public NinjaCustomer LJCAKGACAIE()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.MOFBGCELGFN(0);
		return null;
	}

	private void NNNNFLIDOAO()
	{
		PLOPILENLJK();
	}

	private void HPLAAKOEDNM()
	{
		IBBJHBDANEP();
	}

	private void MCLHHHJHAFK()
	{
		EDJKIEBEIPP();
	}

	private void HPMMJPDMFMB()
	{
		ECBCDOKLDMP();
	}

	private void JDLCOEDAALO()
	{
		PLOPILENLJK();
	}

	public NinjaCustomer BJJMFFCCHIP()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
		return null;
	}

	private void LKJHLKBGANP()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = OGGJNJCFBOH();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.Idle);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.FKMFEACDJHB(KyrohState.ThrowingSpikes);
	}

	private void ANHKCGGOGOA()
	{
		CIEONIBLNFN();
	}

	private void CJMLBAHAKIK()
	{
		Debug.LogError((object)" at ");
		kyrohNPC.EKBJHJLFODI(KyrohState.WalkTo);
	}

	public NinjaCustomer KNBJPNHDLDH()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LMBGCNCJBMA(0);
		return null;
	}

	public NinjaCustomer MOIFOPGBIAP()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LMBGCNCJBMA();
		return null;
	}

	private void JOODGMODJPF()
	{
		OBBEJFELEBK();
	}

	public NinjaCustomer NCPPMABLNMO()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LMBGCNCJBMA(0, GFNHAMCPEAK: false);
		return null;
	}

	public NinjaCustomer IBHEGBKHKLK()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LDPHJNIPDJA(0, GFNHAMCPEAK: false);
		return null;
	}

	private void JDEECHHFIMJ()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = CECNIEMLPPI();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.ChangeState(KyrohState.ServingCustomer);
	}

	public NinjaCustomer GAMLJIMHHOD()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LIHGILDLODK(0);
		return null;
	}

	private void JJMJBJBEOIM()
	{
		kyrohNPC.walkTo.isActive = true;
		NinjaCustomer ninjaCustomer = KNBJPNHDLDH();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.ChangeState(KyrohState.ServingCustomer);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.FKMFEACDJHB(KyrohState.WaitingToServe);
	}

	private void PJOBGBOBMPH()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(1, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void AOLKBJBKBCD()
	{
		Debug.LogError((object)"F2");
		kyrohNPC.GLLDOLHPIBD(KyrohState.ServingCustomer);
	}

	private void JJNEGNLHOHJ()
	{
		kyrohNPC.walkTo.isActive = true;
		NinjaCustomer ninjaCustomer = KLEHFIGKCCP();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.ChangeState(KyrohState.PreparingFood);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
	}

	private void FMGEECEKFIJ()
	{
		FMGLOFFJKIM();
	}

	private void LDLECMJPEDE()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(1, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void IBBJHBDANEP()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(0, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void BBIGIMJLFGK()
	{
		LDLECMJPEDE();
	}

	private void ILHEPKFCGEE()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = OGGJNJCFBOH();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.ChangeState(KyrohState.WalkTo);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.GLLDOLHPIBD(KyrohState.ServingCustomer);
	}

	private void IHOPMGEKFHE()
	{
		kyrohNPC.walkTo.isActive = true;
		NinjaCustomer ninjaCustomer = NCPPMABLNMO();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.GLLDOLHPIBD(KyrohState.PreparingFood);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.EKBJHJLFODI(KyrohState.TakingFood);
	}

	private void AEFECFMIHGM()
	{
		kyrohNPC.walkTo.isActive = true;
		NinjaCustomer ninjaCustomer = KNBJPNHDLDH();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.PreparingFood);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.GLLDOLHPIBD(KyrohState.WalkTo);
	}

	public NinjaCustomer AJPECNDNNND()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LDPHJNIPDJA();
		return null;
	}

	private void GAMIOJNBPAE()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = IIAPKOJDJCA();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.FKMFEACDJHB(KyrohState.Idle);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.FIOKAPKBCOD(KyrohState.WaitingToServe);
	}

	private void KJBELCGHNFP()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(1, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void AEJEBMDAPHD()
	{
		IBBJHBDANEP();
	}

	private void DGHJMBHEHFM()
	{
		Debug.LogError((object)"Clear");
		kyrohNPC.FKMFEACDJHB(KyrohState.WalkTo);
	}

	private void DGIIGADFMLD()
	{
		ECBCDOKLDMP();
	}

	private void ENBKAKJMJFL()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(0, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	public NinjaCustomer JDINFFGIGEO()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.NBODABCGELG(0, GFNHAMCPEAK: false);
		return null;
	}

	private void EDJKIEBEIPP()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(0, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void GKLAINMMPMB()
	{
		IBBJHBDANEP();
	}

	private void DJMHKBCINEP()
	{
		kyrohNPC.walkTo.isActive = true;
		NinjaCustomer ninjaCustomer = KNFMGGEECOM();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.EKBJHJLFODI(KyrohState.Inactive);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.KJBPJJBAAMK(KyrohState.SwitchingFood);
	}

	[CompilerGenerated]
	private void IHOBPKMHJMD()
	{
		Debug.LogError((object)"Kyroh path not found to customer");
		kyrohNPC.ChangeState(KyrohState.WaitingToServe);
	}

	public NinjaCustomer DLCKOIMNNFG()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.IOCOONMEGLI(0, GFNHAMCPEAK: false);
		return null;
	}

	public NinjaCustomer AMPKFGJHKEH()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
		return null;
	}

	private void ACAGKMPCFLA()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.ServeCustomer(1, NLCDDFDGACP: true, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void LPEJDNJDAJJ()
	{
		kyrohNPC.walkTo.isActive = true;
		NinjaCustomer ninjaCustomer = DLCKOIMNNFG();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.ChangeState(KyrohState.WaitingToServe);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.FKMFEACDJHB(KyrohState.SwitchingFood);
	}

	private void JILFODKILOG()
	{
		CIEONIBLNFN();
	}

	private void LLNCELBADFO()
	{
		Debug.LogError((object)"New FadeCamera added for player ");
		kyrohNPC.FKMFEACDJHB(KyrohState.WaitingToServe);
	}

	private void GMPKEJLNPKL()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)kyrohNPC.customerServing != (Object)null)
		{
			kyrohNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)kyrohNPC.customerServing).transform.position - ((Component)kyrohNPC).transform.position)));
			kyrohNPC.customerServing.FMGLOFFJKIM(0, NLCDDFDGACP: false, kyrohNPC.trayHandler.HPCKGLFLFJO);
			kyrohNPC.customerServing = null;
			kyrohNPC.trayHandler.InitializeBento();
		}
	}

	private void IFDNMELCNNG()
	{
		LDLECMJPEDE();
	}

	private void CEHAIEIALHJ()
	{
		Debug.LogError((object)"Adding quest done 35 - First room");
		kyrohNPC.KJBPJJBAAMK(KyrohState.WaitingToServe);
	}

	private void EJEFDBIABGN()
	{
		kyrohNPC.walkTo.isActive = false;
		NinjaCustomer ninjaCustomer = KNFMGGEECOM();
		if ((Object)(object)ninjaCustomer == (Object)null)
		{
			kyrohNPC.FIOKAPKBCOD(KyrohState.Idle);
			return;
		}
		kyrohNPC.customerServing = ninjaCustomer;
		kyrohNPC.ChangeState(KyrohState.Idle);
	}

	private void PCAOHFFAHCN()
	{
		Debug.LogError((object)"Dig");
		kyrohNPC.FKMFEACDJHB(KyrohState.Idle);
	}

	private void AJEKOAINFBB()
	{
		Debug.LogError((object)"HitCollider");
		kyrohNPC.FKMFEACDJHB(KyrohState.ServingCustomer);
	}

	public NinjaCustomer JEBPCOHJBDG()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)kyrohNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		kyrohNPC.trayHandler.tray.LIHGILDLODK(0);
		return null;
	}
}
