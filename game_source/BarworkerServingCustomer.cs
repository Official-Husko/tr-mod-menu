using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BarworkerServingCustomer : BarworkerBaseState
{
	[CompilerGenerated]
	private sealed class PCNNOPLPFMF
	{
		public BarworkerServingCustomer _003C_003E4__this;

		public Animator animator;

		internal void MCGGOAKFPLO()
		{
			if (!Bar.instance.waitingAtBar.Contains(_003C_003E4__this.barworker.customerServing.npc))
			{
				_003C_003E4__this.barworker.customerServing = null;
			}
			else if (Bar.instance.waitingAtBar.Contains(_003C_003E4__this.barworker.customerServing.npc) && !((Behaviour)_003C_003E4__this.barworker.customerServing.npc).enabled)
			{
				Bar.instance.waitingAtBar.Remove(_003C_003E4__this.barworker.customerServing.npc);
				_003C_003E4__this.barworker.customerServing = null;
			}
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}

		internal void CCMNDPOJOEB()
		{
			_003C_003E4__this.CIEONIBLNFN();
			CommonReferences.GGFJGHHHEJC.OnBarworkerGoingToWork(1);
		}
	}

	private float timer;

	private List<Customer> customersRequestingDrink;

	private Customer nextCustomer;

	private void ADNKCBBAFKK()
	{
		barworker.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.AddDrinksFromTray(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	private void OHKOCJPGDGM()
	{
		barworker.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.MACHMLPKPJE(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	private void DLJBMBPFILA()
	{
		barworker.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.IAJANHEMKIK(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	private void AENMBGOKPLK()
	{
		barworker.OEONGPFALKH.isActive = false;
		nextCustomer = BBFGAJAJHBN();
		if ((Object)(object)nextCustomer == (Object)null)
		{
			barworker.AFGFJCLADFA();
			return;
		}
		barworker.customerServing = nextCustomer;
		barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
	}

	private void FACFGCKPOAL()
	{
		staff.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(0, NLCDDFDGACP: false, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	private void ENBKAKJMJFL()
	{
		staff.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(0, NLCDDFDGACP: false, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	private void JLMHMBCPLLF()
	{
		barworker.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.AOICMMGOPCN(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	public Customer CECNIEMLPPI()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0] && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 0; j < customersRequestingDrink.Count; j++)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.OHAPOKICCNK(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.MKBDMMJCGGM();
		return null;
	}

	private void IIFBCIOEKLL()
	{
		staff.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(1, NLCDDFDGACP: true, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	public Customer HKHLLPMHNPN()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0] && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 0; j < customersRequestingDrink.Count; j++)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.HLPNLBHBIFL(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.LMBGCNCJBMA(0, GFNHAMCPEAK: false);
		return null;
	}

	private void IKCOOFEAEKA()
	{
		barworker.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.AddDrinksFromTray(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	private void EKKFALPKHHP()
	{
		staff.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(1, NLCDDFDGACP: false, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	private void KFNCCILIONN()
	{
		barworker.OEONGPFALKH.isActive = false;
		nextCustomer = NOBBFKBNGGB();
		if ((Object)(object)nextCustomer == (Object)null)
		{
			barworker.StartTask();
			return;
		}
		barworker.customerServing = nextCustomer;
		barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
	}

	public Customer KNBJPNHDLDH()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1] && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 1; j < customersRequestingDrink.Count; j++)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.IIPPFEHNLKB(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.LIHGILDLODK(0);
		return null;
	}

	public Customer AIJJGEJIMAD()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1] && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 0; j < customersRequestingDrink.Count; j++)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.HADIAMMDNKB(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.MOFBGCELGFN();
		return null;
	}

	private void OFBFOBEJEML()
	{
		barworker.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.AKPCJBCIGEM(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	private void AFGHHGHKMIP()
	{
		staff.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(1, NLCDDFDGACP: true, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	private void NFEENKLEDNB()
	{
		barworker.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.IAJANHEMKIK(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	public Customer JEBPCOHJBDG()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0] && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 1; j < customersRequestingDrink.Count; j += 0)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.AIMCMHBMIMP(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.FIJLPLJMJFA(1, GFNHAMCPEAK: false);
		return null;
	}

	private void OLEODLHNNHH()
	{
		staff.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(0, NLCDDFDGACP: true, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	public Customer CMGKENNFJEE()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1] && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 1; j < customersRequestingDrink.Count; j += 0)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.FPNEGBNKILJ(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.LMBGCNCJBMA(1, GFNHAMCPEAK: false);
		return null;
	}

	public Customer PELCHDAAKNI()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1] && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 0; j < customersRequestingDrink.Count; j += 0)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.MNAILNGHBFF(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.IOCOONMEGLI(0, GFNHAMCPEAK: false);
		return null;
	}

	public Customer FIPEKJPOEDC()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0] && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 1; j < customersRequestingDrink.Count; j++)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.MNAILNGHBFF(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.MOFBGCELGFN();
		return null;
	}

	private void JDEECHHFIMJ()
	{
		barworker.OEONGPFALKH.isActive = false;
		nextCustomer = CECNIEMLPPI();
		if ((Object)(object)nextCustomer == (Object)null)
		{
			barworker.StartTask();
			return;
		}
		barworker.customerServing = nextCustomer;
		barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
	}

	private void CIEONIBLNFN()
	{
		staff.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(1, NLCDDFDGACP: false, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	private void FJELIIMBACE()
	{
		barworker.OEONGPFALKH.isActive = true;
		nextCustomer = KNBJPNHDLDH();
		if ((Object)(object)nextCustomer == (Object)null)
		{
			barworker.GHMFNBDCKCA();
			return;
		}
		barworker.customerServing = nextCustomer;
		barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		barworker.barworkerState = BarworkerState.ServingCustomer;
		timer = 0f;
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			if (barworker.customerServing.customerState == CustomerState.OrderInTable)
			{
				barworker.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(DrinksTable.instance.barworkerPos.position), AHDHLIECIGH: false);
				NPCWalkTo walkTo = barworker.OEONGPFALKH;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IKCOOFEAEKA));
			}
			else
			{
				barworker.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(new Vector3(((Component)barworker.customerServing).transform.position.x, Bar.instance.DIOPEKDLCIH.position.y)), AHDHLIECIGH: false);
				NPCWalkTo walkTo2 = barworker.OEONGPFALKH;
				walkTo2.OnActionComplete = (Action)Delegate.Combine(walkTo2.OnActionComplete, (Action)delegate
				{
					CIEONIBLNFN();
					CommonReferences.GGFJGHHHEJC.OnBarworkerGoingToWork(1);
				});
			}
			NPCWalkTo walkTo3 = barworker.OEONGPFALKH;
			walkTo3.OnFailStart = (Action)Delegate.Combine(walkTo3.OnFailStart, (Action)delegate
			{
				if (!Bar.instance.waitingAtBar.Contains(barworker.customerServing.npc))
				{
					barworker.customerServing = null;
				}
				else if (Bar.instance.waitingAtBar.Contains(barworker.customerServing.npc) && !((Behaviour)barworker.customerServing.npc).enabled)
				{
					Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
					barworker.customerServing = null;
				}
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			});
			barworker.OEONGPFALKH.PEHELKCIECB();
		}
		else
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	private void FICJLIFBHLP()
	{
		staff.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(0, NLCDDFDGACP: false, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	private void EAOHPBOMGPJ()
	{
		barworker.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.AOICMMGOPCN(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	private void GAMPCCCINNP()
	{
		staff.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(1, NLCDDFDGACP: false, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	public Customer GAMLJIMHHOD()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0] && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 0; j < customersRequestingDrink.Count; j++)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.HADIAMMDNKB(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.MKBDMMJCGGM();
		return null;
	}

	private void OENJPLDAEPN()
	{
		barworker.npc.requestInfo.avoidWalls = true;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			DrinksTable.instance.GALGLEEKGGH(barworker.trayHandler.tray);
			Bar.instance.waitingAtBar.Remove(barworker.customerServing.npc);
			barworker.customerServing = null;
		}
	}

	private void DICPCJGFHNB()
	{
		barworker.OEONGPFALKH.isActive = false;
		nextCustomer = JEBPCOHJBDG();
		if ((Object)(object)nextCustomer == (Object)null)
		{
			barworker.NODFMKLGPME();
			return;
		}
		barworker.customerServing = nextCustomer;
		barworker.behaviour.SetTrigger(StaffBaseState.p_ServingCustomer);
	}

	public Customer NOBBFKBNGGB()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0] && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 0; j < customersRequestingDrink.Count; j += 0)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.CJDPJHKCPFA(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.ACDHANDNCNC(1, GFNHAMCPEAK: false);
		return null;
	}

	public Customer BBFGAJAJHBN()
	{
		if (!barworker.trayHandler.tray.currentDrinks.Any())
		{
			return null;
		}
		if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[1] && barworker.JFCLIAFAOEK.tasks[1])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI()
				select i).ToList();
		}
		else if (barworker.JFCLIAFAOEK != null && barworker.JFCLIAFAOEK.tasks[0])
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.WaitingAtBar
				select i).ToList();
		}
		else
		{
			customersRequestingDrink = (from x in Bar.instance.waitingAtBar
				select x.customer into i
				where i.currentRequest.JEPBBEBJEFI() && i.customerState == CustomerState.OrderInTable
				select i).ToList();
		}
		for (int j = 1; j < customersRequestingDrink.Count; j++)
		{
			if (customersRequestingDrink[j].currentRequest != null && barworker.trayHandler.tray.ELCABOAPCMH(customersRequestingDrink[j].currentRequest))
			{
				return customersRequestingDrink[j];
			}
		}
		barworker.trayHandler.tray.LDPHJNIPDJA(0);
		return null;
	}

	private void OKNNPLEINFN()
	{
		staff.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Up);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(1, NLCDDFDGACP: false, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	private void IOKFOMPCBDC()
	{
		staff.npc.requestInfo.avoidWalls = false;
		barworker.characterAnimation.LookDirection(Direction.Down);
		if ((Object)(object)barworker.customerServing != (Object)null)
		{
			barworker.customerServing.ServeCustomer(0, NLCDDFDGACP: true, barworker.trayHandler.tray, barworker);
			barworker.customerServing = null;
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (barworker.OEONGPFALKH.IIMEFNIECLI())
		{
			if (timer >= barworker.timeAfterServe)
			{
				JDEECHHFIMJ();
			}
			else
			{
				timer += Time.fixedDeltaTime;
			}
		}
	}
}
