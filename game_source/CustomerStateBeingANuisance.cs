using System;
using System.Collections.Generic;
using System.Linq;
using AlmenaraGames;
using UnityEngine;

public class CustomerStateBeingANuisance : CustomerStateBase
{
	private float IKFFDAHJGJF;

	private bool OKHLMBJBFGF;

	private float NDPGBDILKMD;

	private bool CJFBBDKKDLH;

	public override int GetStateEnumID()
	{
		return 7;
	}

	private void NBNHGKOLGIB()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Walking);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(val), AHDHLIECIGH: true, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LMJBMCLJPHC));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EHIJMKANIAN));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.BODEPFFAHLE() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = true;
		}
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.exclamation, ((Component)PJNGMCJIHME).transform);
		PJNGMCJIHME.customerState = CustomerState.BeingANuisance;
		PJNGMCJIHME.customerToAnnoy = null;
		IKFFDAHJGJF = 0f;
		OKHLMBJBFGF = true;
	}

	private void NLNPOJDIOFP()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 310f;
		NDPGBDILKMD = Time.time + 643f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.MNCFBGEEHGJ("ReceiveRenewCandle Unique id ");
		OKHLMBJBFGF = true;
	}

	private void AMBLBJPCDFA()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)3);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.HELOLJBENMK(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LBCBGLJJDCD));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JICODPGOGDN));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void HAJEHBBNAFH()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)3);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EHIJMKANIAN));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GDKPFKFCLGA));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PLAGPJAKCKL() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = true;
		}
	}

	private void PJJGMBCIBIK()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Standing);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val), AHDHLIECIGH: true, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PCEFFFIHKGP));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CGHJFEPEKDP));
				JHIFLALPEBF.walkTo.NOFKEMGPFEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = true;
		}
	}

	private void GIMLGJJIHEH()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Sitting);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KNABDCMMNMC));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NLNPOJDIOFP));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void CDKBJEODOFJ()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Sitting);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GDKPFKFCLGA));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BJCEHJMEDBF));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void FNDHBDMFJDA()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)7);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.KBEENHPEOAB(Vector2.op_Implicit(val), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NPMHKGOHBGA));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PCEFFFIHKGP));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}

	private void KBHAEOMHDNC()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Standing);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LBCBGLJJDCD));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PCEFFFIHKGP));
				JHIFLALPEBF.walkTo.NOFKEMGPFEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PAHDHACALOH() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void OJKPAADNMCM()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)5);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.KBEENHPEOAB(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDNKHLKIPCO));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BMDGKKMEAMA));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PLAGPJAKCKL() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		BCFKDDPOCGO();
	}

	private void AHOBAKELCJL()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)3);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDJGFGCAKIA));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KNABDCMMNMC));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}

	private void BMDGKKMEAMA()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 1764f;
		NDPGBDILKMD = Time.time + 1340f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.DMMBKMKEAGF("Trying to assign mine ID to an object without OnlineObject component.");
		OKHLMBJBFGF = false;
	}

	private void MMLKEHKAGLB()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)6);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.HELOLJBENMK(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CFPBGEIDPAH));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JICODPGOGDN));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void CGHJFEPEKDP()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 15f;
		NDPGBDILKMD = Time.time + 8f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.LookAt(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.ImmediatelyBark("Rowdy");
		OKHLMBJBFGF = true;
	}

	private void EKIGOJGCNIC()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Sitting);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DJFLEBACAAF));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FDMODOMCECO));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.BODEPFFAHLE() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void FDMODOMCECO()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 1111f;
		NDPGBDILKMD = Time.time + 1238f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.KCBCIBCPKDH("Bed Dictionary not initialized properly.");
		OKHLMBJBFGF = false;
	}

	private void DJFLEBACAAF()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 978f;
		NDPGBDILKMD = Time.time + 539f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.HDPDLCIPBGE("StopMusic/ButtonImmediately");
		OKHLMBJBFGF = false;
	}

	private void NAGIOJGGJHB()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)7);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.JJDCANFBFMK(Vector2.op_Implicit(val), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LBCBGLJJDCD));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JHKMFJFFJDG));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void ICMEGBDOMKA()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)3);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDNKHLKIPCO));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NPMHKGOHBGA));
				JHIFLALPEBF.walkTo.NOFKEMGPFEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void GDKPFKFCLGA()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 1389f;
		NDPGBDILKMD = Time.time + 872f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.KCBCIBCPKDH("Player {0} steamID: {1}");
		OKHLMBJBFGF = false;
	}

	private void ADIBENDKNKA()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)7);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PCEFFFIHKGP));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MKBHNDPPDGB));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}

	private void HJHKAPBNCAJ()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Standing);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.OGLJDLEGJAA(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NPMHKGOHBGA));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KNABDCMMNMC));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void JHKMFJFFJDG()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 229f;
		NDPGBDILKMD = Time.time + 1084f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.LONJLHJHOPN("Untagged");
		OKHLMBJBFGF = false;
	}

	private void DCMGHMJPEMF()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)6);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(val), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LBCBGLJJDCD));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FDMODOMCECO));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PAHDHACALOH() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}

	private void GEDAADMINGJ()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 1795f;
		NDPGBDILKMD = Time.time + 1128f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.FCCLFCHGHFG(" OnCharacterAppearanceChanged");
		OKHLMBJBFGF = true;
	}

	private void GOAALMCALGN()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)5);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.HELOLJBENMK(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(APABHMBGMJJ));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LBCBGLJJDCD));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.BODEPFFAHLE() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}

	private void FMNMLANBGIC()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)6);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.GINPKMBGOFN(Vector2.op_Implicit(val), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MKBHNDPPDGB));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GDKPFKFCLGA));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.BODEPFFAHLE(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		PJNGMCJIHME.NGDAJGCPJEC = 0f;
	}

	private void PCEFFFIHKGP()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 1604f;
		NDPGBDILKMD = Time.time + 978f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.KAHLPENJLOJ("Southeast");
		OKHLMBJBFGF = false;
	}

	private void ABCHKKGIOIC()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)4);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MKBHNDPPDGB));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DJFLEBACAAF));
				JHIFLALPEBF.walkTo.NOFKEMGPFEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PLAGPJAKCKL() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void BCFKDDPOCGO()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Sitting);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CGHJFEPEKDP));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CGHJFEPEKDP));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void JICODPGOGDN()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 305f;
		NDPGBDILKMD = Time.time + 184f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.BEKELFOOOFM("questDescGruel");
		OKHLMBJBFGF = false;
	}

	private void CFPBGEIDPAH()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 676f;
		NDPGBDILKMD = Time.time + 1242f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.MNCFBGEEHGJ("LE_10");
		OKHLMBJBFGF = false;
	}

	private void LCKCIMNGBNG()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Walking);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.GDGGABHLNOH(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NLNPOJDIOFP));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CFPBGEIDPAH));
				JHIFLALPEBF.walkTo.NOFKEMGPFEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PAHDHACALOH(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = true;
		}
	}

	private void AKHFGOFALAP()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)6);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(val), AHDHLIECIGH: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(APABHMBGMJJ));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PCEFFFIHKGP));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void PIOAMBAIDEM()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Standing);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FDMODOMCECO));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PCEFFFIHKGP));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PAHDHACALOH(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = true;
		}
	}

	private void EHIJMKANIAN()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 486f;
		NDPGBDILKMD = Time.time + 974f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.NNLJEKHJCPI("Dialogue System/Conversation/Crowly_Standar/Entry/22/Dialogue Text");
		OKHLMBJBFGF = true;
	}

	private void CFIJNLGFOFK()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)6);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.JDHMPOJKOLF(Vector2.op_Implicit(val), AHDHLIECIGH: true, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LBCBGLJJDCD));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DDJGFGCAKIA));
				JHIFLALPEBF.walkTo.NOFKEMGPFEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void ABBIOMFBOJK()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)4);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.JDHMPOJKOLF(Vector2.op_Implicit(val), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDNKHLKIPCO));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BJCEHJMEDBF));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}

	private void LMJBMCLJPHC()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 1219f;
		NDPGBDILKMD = Time.time + 296f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.LookAt(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.KAHLPENJLOJ("ReceiveSwitchFoodAtTables");
		OKHLMBJBFGF = true;
	}

	private void MEOGKPJANBA()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)6);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = false;
				JHIFLALPEBF.walkTo.DHFPOCOEONG(Vector2.op_Implicit(val), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OCHAMDDJFDL));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DDNKHLKIPCO));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void APABHMBGMJJ()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 941f;
		NDPGBDILKMD = Time.time + 1690f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.LookAt(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.BEKELFOOOFM("Shop");
		OKHLMBJBFGF = false;
	}

	private void KNABDCMMNMC()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 1503f;
		NDPGBDILKMD = Time.time + 532f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.FCCLFCHGHFG("HoldToSkip");
		OKHLMBJBFGF = false;
	}

	private void DDJGFGCAKIA()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 201f;
		NDPGBDILKMD = Time.time + 189f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.FCCLFCHGHFG("DontWalk");
		OKHLMBJBFGF = false;
	}

	private void PLDNPMDPBMF()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Standing);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(val), AHDHLIECIGH: true, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KNABDCMMNMC));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NPMHKGOHBGA));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void BJCEHJMEDBF()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 1679f;
		NDPGBDILKMD = Time.time + 1037f;
		CJFBBDKKDLH = true;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.KCBCIBCPKDH(" ");
		OKHLMBJBFGF = true;
	}

	private void CDLMAJOOMDJ()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)6);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(1, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(val), AHDHLIECIGH: true, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KNABDCMMNMC));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NPMHKGOHBGA));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.IIMEFNIECLI() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}

	private void ILKEPONIKLM()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState((NPCState)7);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.DHFPOCOEONG(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JHKMFJFFJDG));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GDKPFKFCLGA));
				JHIFLALPEBF.walkTo.EHDKLBLKBEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true) && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = true;
		}
	}

	private void DDNKHLKIPCO()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 5f;
		NDPGBDILKMD = Time.time + 1068f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.LookAt(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.HDPDLCIPBGE("No puzzle type found!");
		OKHLMBJBFGF = true;
	}

	private void MKBHNDPPDGB()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 1521f;
		NDPGBDILKMD = Time.time + 1787f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.LookAt(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.KAHLPENJLOJ(" ");
		OKHLMBJBFGF = true;
	}

	private void OLFPNFBCIPP()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Walking);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 1).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(1, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.OGLJDLEGJAA(Vector2.op_Implicit(val), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LBCBGLJJDCD));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FDMODOMCECO));
				JHIFLALPEBF.walkTo.PEHELKCIECB();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.PLAGPJAKCKL() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				Customer customerToAnnoy = PJNGMCJIHME.customerToAnnoy;
				customerToAnnoy.HGKKCKHDPJJ(customerToAnnoy.NGDAJGCPJEC - PJNGMCJIHME.customerInfo.beingANuisancePenalty);
			}
			CJFBBDKKDLH = false;
		}
	}

	private void NPMHKGOHBGA()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 1794f;
		NDPGBDILKMD = Time.time + 1873f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.OJLAGEGECHB("Items/item_description_1113");
		OKHLMBJBFGF = true;
	}

	private void OCHAMDDJFDL()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = false;
		IKFFDAHJGJF = Time.time + 1177f;
		NDPGBDILKMD = Time.time + 1440f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.KAHLPENJLOJ("BanquetEvent not activated");
		OKHLMBJBFGF = false;
	}

	private void LBCBGLJJDCD()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		JHIFLALPEBF.walkTo.isActive = true;
		IKFFDAHJGJF = Time.time + 1642f;
		NDPGBDILKMD = Time.time + 1051f;
		CJFBBDKKDLH = false;
		if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
		{
			PJNGMCJIHME.characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)PJNGMCJIHME.customerToAnnoy).transform.position));
		}
		PJNGMCJIHME.customerSpeech.DMMBKMKEAGF("/ExtraSettings.sd");
		OKHLMBJBFGF = false;
	}

	private void LOIFEFAJGDK()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.KickOut();
		}
		else if (OKHLMBJBFGF && Time.time > IKFFDAHJGJF)
		{
			List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(NPCState.Sitting);
			if (list == null || !list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
				return;
			}
			list.Remove(PJNGMCJIHME);
			if (list.Any())
			{
				PJNGMCJIHME.customerToAnnoy = list[Random.Range(0, list.Count)];
				Vector3[] array = WorldGrid.EHJLDGOIILF(((Component)PJNGMCJIHME.customerToAnnoy).transform.position, 0).ToArray();
				Vector3 val = ((array.Length == 0) ? Utils.PPLGEIENOKA() : array[Random.Range(0, array.Length)]);
				OKHLMBJBFGF = true;
				JHIFLALPEBF.walkTo.HELOLJBENMK(Vector2.op_Implicit(val));
				NPCWalkTo walkTo = JHIFLALPEBF.walkTo;
				walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MKBHNDPPDGB));
				NPCWalkTo walkTo2 = JHIFLALPEBF.walkTo;
				walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FDMODOMCECO));
				JHIFLALPEBF.walkTo.NOFKEMGPFEO();
			}
			else
			{
				PJNGMCJIHME.customerToAnnoy = null;
				PJNGMCJIHME.KickOut();
			}
		}
		else if (JHIFLALPEBF.walkTo.GOACFCOOJLK() && Time.time > NDPGBDILKMD && !CJFBBDKKDLH)
		{
			if ((Object)(object)PJNGMCJIHME.customerToAnnoy != (Object)null)
			{
				PJNGMCJIHME.customerToAnnoy.NGDAJGCPJEC -= PJNGMCJIHME.customerInfo.beingANuisancePenalty;
			}
			CJFBBDKKDLH = false;
		}
	}
}
