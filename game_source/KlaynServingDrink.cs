using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.Utilities;
using UnityEngine;

public class KlaynServingDrink : KlaynStateBase
{
	private float timer;

	private void MFBABNNPMCP()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private void JAKIJLDLHFD()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	private void HJLNCGBLHFN()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
	}

	public BanquetCustomer OOLBBHGBNEB()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.OHAPOKICCNK(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.ACDHANDNCNC(0);
		return null;
	}

	private void GJMKKEAIOKA()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = DGBOIEJOODI();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GPBKHBEHIAC((KlaynState)8);
	}

	private void JIHNAHNPNEI()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = CJCLJDALOIO();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
	}

	private void GOFMOMHJKGM()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private void FAOFDEJJPIO()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = JBPAGHGAEMM();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.ChangeState(KlaynState.TakingDrink);
	}

	private void ALICIOMHCPM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.BIBMEENGOJF(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void GDJJGFLEAGM()
	{
		DGPFIJMPOGI();
	}

	private void GAGHAPHIFFN()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.EBLGEBFLKGM(0, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (klaynNPC.walkTo.IIMEFNIECLI())
		{
			if (timer >= klaynNPC.timeAfterServe + (EventsManager.IsLowestDifficulty() ? klaynNPC.timeAfterServe : 0f))
			{
				JDEECHHFIMJ();
			}
			else
			{
				timer += Time.fixedDeltaTime;
			}
		}
	}

	private void CNEANBGDPND()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	public BanquetCustomer HKHLLPMHNPN()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.BCNKFHHDMAG(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.IOCOONMEGLI(1, GFNHAMCPEAK: false);
		return null;
	}

	private void AFFECIEOKEC()
	{
		DGPFIJMPOGI();
	}

	private void NHKKOCEALCO()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FBGEMHMCIMG(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void BNOHBBGBIBH()
	{
		ECBCDOKLDMP();
	}

	private void DMJDDIPIOKN()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = DGBOIEJOODI();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.LIOJBOLAGNG(KlaynState.Wait);
	}

	public BanquetCustomer GICOAAKCDEE()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.BCNKFHHDMAG(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.NBODABCGELG(1, GFNHAMCPEAK: false);
		return null;
	}

	private void CHNIAPPDFLM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FOBIOBIABJF(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void CKHDCFGHHJH()
	{
		klaynNPC.walkTo.isActive = false;
		BanquetCustomer banquetCustomer = GICOAAKCDEE();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.StartTask();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
	}

	private void FDMALGFJPNO()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = OCJGMCHNDPM();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.StartTask();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	private void HIPDGGFHCKP()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = FHGJOPAEMNP();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GIFBCKEOBGP(KlaynState.ServingCustomer);
	}

	private void MFNAPEFDFDB()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = CJCLJDALOIO();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GPBKHBEHIAC(KlaynState.ServingCustomer);
	}

	private void LPBJKNKADIB()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.IAFJNPGMBPO(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void EFDDDFNIKPK()
	{
		klaynNPC.walkTo.isActive = false;
		BanquetCustomer banquetCustomer = OOLBBHGBNEB();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GIFBCKEOBGP(KlaynState.WalkTo);
	}

	[CompilerGenerated]
	private void IHOBPKMHJMD()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private void KCMNBJPOJGN()
	{
		klaynNPC.walkTo.isActive = false;
		BanquetCustomer banquetCustomer = NOFNCLFHAMK();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.LIOJBOLAGNG(KlaynState.WalkTo);
	}

	private void MCLHHHJHAFK()
	{
		HCCEEPOKGAH();
	}

	public BanquetCustomer NOFNCLFHAMK()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.AIMCMHBMIMP(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.OHAJMGCPGMK(0);
		return null;
	}

	private void MPENDMNKLNF()
	{
		MAJNOCFNFIJ();
	}

	private void GAPLDEMNCDB()
	{
		LPBJKNKADIB();
	}

	private void BFPCPABMKBL()
	{
		KGCJJJNLNLB();
	}

	public BanquetCustomer MLGKIHAEMAF()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.ELCABOAPCMH(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
		return null;
	}

	public BanquetCustomer CMGKENNFJEE()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.HLPNLBHBIFL(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.NBODABCGELG();
		return null;
	}

	private void NBENLEKGCKC()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = ECMGFKBMIHG();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.StartTask();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GIFBCKEOBGP((KlaynState)8);
	}

	public BanquetCustomer EJGBDMIFIKH()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.BCNKFHHDMAG(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.OHAJMGCPGMK(0, GFNHAMCPEAK: false);
		return null;
	}

	private void HCCEEPOKGAH()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.IAFJNPGMBPO(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void AJEKOAINFBB()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	private void JEBEBNBJHLH()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
	}

	private void MAAKHLLLPJA()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = AFAGMHBOJMI();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.AMCBBGNIJJP();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.ChangeState(KlaynState.Inactive);
	}

	[CompilerGenerated]
	private void ENAFABOMBGM()
	{
		CIEONIBLNFN();
	}

	public BanquetCustomer AFAGMHBOJMI()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.PKIIMJBGCDP(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.MOFBGCELGFN(1, GFNHAMCPEAK: false);
		return null;
	}

	private void AIHGDADBGKO()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FBGEMHMCIMG(1, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void OAEPMKPNCGJ()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.ChangeState(KlaynState.Inactive);
	}

	private void MPGLLCLADJK()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = JDINFFGIGEO();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.AMCBBGNIJJP();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.ChangeState(KlaynState.Inactive);
	}

	private void PGOBHJCOHCE()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	public BanquetCustomer IFJEAPNMJDP()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.BCNKFHHDMAG(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.IOCOONMEGLI(0, GFNHAMCPEAK: false);
		return null;
	}

	private void FMGEECEKFIJ()
	{
		CIEONIBLNFN();
	}

	private void KDKMJJDHJCF()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.HCCEEPOKGAH(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void PEAEKIIAEHH()
	{
		POJNAPFIJBO();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		klaynNPC.klaynState = KlaynState.ServingCustomer;
		timer = 0f;
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.walkTo.run = !EventsManager.IsLowestDifficulty();
			klaynNPC.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(klaynNPC.customerServing.positionToServe.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = klaynNPC.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				CIEONIBLNFN();
			});
			NPCWalkTo walkTo2 = klaynNPC.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
				{
					klaynNPC.customerServing = null;
				}
				else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
				{
					Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
					klaynNPC.customerServing = null;
				}
				klaynNPC.ChangeState(KlaynState.WaitingToServe);
			});
			klaynNPC.walkTo.PEHELKCIECB();
		}
		else
		{
			klaynNPC.ChangeState(KlaynState.WaitingToServe);
		}
	}

	private void DGPFIJMPOGI()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.EBLGEBFLKGM(0, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void JHEPFPNHNGJ()
	{
		klaynNPC.walkTo.isActive = false;
		BanquetCustomer banquetCustomer = OCJGMCHNDPM();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.AMCBBGNIJJP();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.LIOJBOLAGNG(KlaynState.HittingPlayer);
	}

	private void OBGIKNMKOCE()
	{
		klaynNPC.walkTo.isActive = false;
		BanquetCustomer banquetCustomer = NOFNCLFHAMK();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JBDHDPAFPPH();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.KCKDMOKONBD(KlaynState.Wait);
	}

	private void DNFPMCHNIDO()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.ChangeState(KlaynState.Inactive);
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (klaynNPC.walkTo.isActive && (Object)(object)klaynNPC.customerServing != (Object)null && !klaynNPC.customerServing.requesting)
		{
			JDEECHHFIMJ();
		}
	}

	public BanquetCustomer JDINFFGIGEO()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.HLPNLBHBIFL(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.FIJLPLJMJFA(1, GFNHAMCPEAK: false);
		return null;
	}

	private void JDEECHHFIMJ()
	{
		klaynNPC.walkTo.isActive = false;
		BanquetCustomer banquetCustomer = CECNIEMLPPI();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.StartTask();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.ChangeState(KlaynState.ServingCustomer);
	}

	private void NNAPCAGHNLK()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	private void CPPJBDCADDC()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.IAFJNPGMBPO(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void BIBMEENGOJF()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.ServeCustomer(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void IIFBCIOEKLL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FOBIOBIABJF(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void GAMIOJNBPAE()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = MLGKIHAEMAF();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JDKIFKFNOJL();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	private void EGMPKBHADKI()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
	}

	private void MINAFPLALBK()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = CBMGOOEDCAB();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JDKIFKFNOJL();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GIFBCKEOBGP(KlaynState.Wait);
	}

	private void KFKNHDNAGMN()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
	}

	public BanquetCustomer CBMGOOEDCAB()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.IIPPFEHNLKB(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.ACDHANDNCNC();
		return null;
	}

	private void KJKICFNGIPP()
	{
		klaynNPC.walkTo.isActive = false;
		BanquetCustomer banquetCustomer = OOLBBHGBNEB();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JDKIFKFNOJL();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.LIOJBOLAGNG(KlaynState.Leaving);
	}

	public BanquetCustomer IIAPKOJDJCA()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.BCNKFHHDMAG(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.FIJLPLJMJFA(1, GFNHAMCPEAK: false);
		return null;
	}

	private void ECBCDOKLDMP()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FBGEMHMCIMG(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void BBIGIMJLFGK()
	{
		POJNAPFIJBO();
	}

	private void PBMCOHJBCMC()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = HKHLLPMHNPN();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.JDKIFKFNOJL();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GPBKHBEHIAC(KlaynState.HittingPlayer);
	}

	private void PCAOHFFAHCN()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
	}

	private void CIEONIBLNFN()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.ServeCustomer(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	public BanquetCustomer FHGJOPAEMNP()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.IIPPFEHNLKB(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.LMBGCNCJBMA(0);
		return null;
	}

	public BanquetCustomer CJCLJDALOIO()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.AIMCMHBMIMP(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.LDPHJNIPDJA();
		return null;
	}

	private void GKOGIBCJPIP()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = CBMGOOEDCAB();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.AMCBBGNIJJP();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.ChangeState(KlaynState.HittingPlayer);
	}

	private void DPGLOFNPGEA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FOBIOBIABJF(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void MAJNOCFNFIJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FOBIOBIABJF(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void KGCJJJNLNLB()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FOBIOBIABJF(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	public BanquetCustomer PHKKBKICCIC()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.FPNEGBNKILJ(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.NBODABCGELG(0);
		return null;
	}

	private void DOPPCJCPMBB()
	{
		POJNAPFIJBO();
	}

	private void JPLNFHKANNA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.CCGCKGILGJK(1, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	public BanquetCustomer LAHGHBILOFH()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.HLPNLBHBIFL(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.OHAJMGCPGMK(1, GFNHAMCPEAK: false);
		return null;
	}

	private void IPCOPOENFFO()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.IAFJNPGMBPO(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void ABMGMEKGKNE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.EBLGEBFLKGM(1, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void FJMPGLGGMJA()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GIFBCKEOBGP(KlaynState.WaitingToServe);
	}

	public BanquetCustomer FIPEKJPOEDC()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.MNAILNGHBFF(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.FIJLPLJMJFA(0);
		return null;
	}

	private void AJNIPMKCKIK()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
	}

	public BanquetCustomer BIOGIMNNAMJ()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.BCNKFHHDMAG(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.MOFBGCELGFN(0);
		return null;
	}

	public BanquetCustomer JMAKGMBBBKJ()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.MNAILNGHBFF(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.MKBDMMJCGGM();
		return null;
	}

	private void KENDEMBGMOK()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.KCKDMOKONBD(KlaynState.WaitingToServe);
	}

	private void LJNALIDKFCD()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = NOFNCLFHAMK();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.AMCBBGNIJJP();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.KCKDMOKONBD(KlaynState.HittingPlayer);
	}

	public BanquetCustomer OCJGMCHNDPM()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.MNAILNGHBFF(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.LIHGILDLODK();
		return null;
	}

	private void ONLOMEJBMNO()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
	}

	public BanquetCustomer OGCMGCPDPJN()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.HADIAMMDNKB(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.MKBDMMJCGGM(0);
		return null;
	}

	private void NDFEFKHBCCO()
	{
		klaynNPC.walkTo.isActive = true;
		BanquetCustomer banquetCustomer = OCJGMCHNDPM();
		if ((Object)(object)banquetCustomer == (Object)null)
		{
			klaynNPC.AMCBBGNIJJP();
			return;
		}
		klaynNPC.customerServing = banquetCustomer;
		klaynNPC.GPBKHBEHIAC(KlaynState.ServingCustomer);
	}

	private void MOAIACEHKOJ()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	private void PBCCCEPMNDN()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GIFBCKEOBGP(KlaynState.Inactive);
	}

	private void NEENMFJHMMF()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GPBKHBEHIAC(KlaynState.WaitingToServe);
	}

	private void PNBLIHJPHFJ()
	{
		ALICIOMHCPM();
	}

	public BanquetCustomer NGGIFPHAGCO()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.HADIAMMDNKB(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.NBODABCGELG(0, GFNHAMCPEAK: false);
		return null;
	}

	public BanquetCustomer DGBOIEJOODI()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.ELCABOAPCMH(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.NBODABCGELG(0);
		return null;
	}

	private void MIFPPBIFFFP()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.FOBIOBIABJF(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void OONFADHEPHP()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.MAGIGBCGLGK(0, NLCDDFDGACP: false, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void POJNAPFIJBO()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)klaynNPC.customerServing != (Object)null)
		{
			klaynNPC.animationBase.LookDirection(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)klaynNPC.customerServing).transform.position - ((Component)klaynNPC).transform.position)));
			klaynNPC.customerServing.MAGIGBCGLGK(1, NLCDDFDGACP: true, klaynNPC.trayHandler.tray);
			klaynNPC.customerServing = null;
		}
	}

	private void GPHOBOFNKJE()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.KCKDMOKONBD(KlaynState.Inactive);
	}

	public BanquetCustomer ECMGFKBMIHG()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.FPNEGBNKILJ(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.FIJLPLJMJFA(1, GFNHAMCPEAK: false);
		return null;
	}

	private void LEINHANFOJI()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.LIOJBOLAGNG(KlaynState.Inactive);
	}

	private void NHIAGEAEPNL()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.ChangeState(KlaynState.WaitingToServe);
	}

	private void GBHNJPMPMID()
	{
		if (!Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc))
		{
			klaynNPC.customerServing = null;
		}
		else if (Bar.instance.waitingAtBar.Contains(klaynNPC.customerServing.npc) && !((Behaviour)klaynNPC.customerServing.npc).enabled)
		{
			Bar.instance.waitingAtBar.Remove(klaynNPC.customerServing.npc);
			klaynNPC.customerServing = null;
		}
		klaynNPC.GPBKHBEHIAC(KlaynState.Inactive);
	}

	public BanquetCustomer JBPAGHGAEMM()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.MNAILNGHBFF(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.OHAJMGCPGMK(0);
		return null;
	}

	private void ONBNNIOIPPN()
	{
		LPBJKNKADIB();
	}

	public BanquetCustomer CECNIEMLPPI()
	{
		if (LinqExtensions.IsNullOrEmpty<ItemInstance>((IList<ItemInstance>)klaynNPC.trayHandler.tray.currentDrinks))
		{
			return null;
		}
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			if (BanquetOrdersManager.instance.tableOrders[i].currentRequest != null && klaynNPC.trayHandler.tray.OHAPOKICCNK(BanquetOrdersManager.instance.tableOrders[i].currentRequest))
			{
				return BanquetOrdersManager.instance.tableOrders[i];
			}
		}
		klaynNPC.trayHandler.tray.MKBDMMJCGGM();
		return null;
	}
}
