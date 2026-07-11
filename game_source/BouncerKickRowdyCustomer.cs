using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BouncerKickRowdyCustomer : BouncerBaseState
{
	private float timer;

	private bool hit;

	private void INKNHNOJCCG()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	[CompilerGenerated]
	private void AHIBPHMMELC()
	{
		HCHDDHFCOAP();
	}

	private void LMJIDJDOPDM()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void AMHCDMBNHFL()
	{
		HCJHENEKLCH();
	}

	private void NFIKHLEAEDL()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.HELOLJBENMK(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ACHINJAMJNK));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BCGKJNMODEH));
			bouncer.OEONGPFALKH.NOFKEMGPFEO();
		}
	}

	private void AFLCDJLJJEH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NDABIMEINDK()
	{
		NEPEOPDJLOF();
	}

	private void DNOAEOLEFNM()
	{
		AIHPEDGNHDM();
	}

	private void CNLICJBFKDK()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (!hit && bouncer.OEONGPFALKH.IIMEFNIECLI())
		{
			bouncer.OEONGPFALKH.isActive = false;
		}
	}

	private void FHFMFPJLCMH()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.JJDCANFBFMK(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DNOAEOLEFNM));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LMJIDJDOPDM));
			bouncer.OEONGPFALKH.NOFKEMGPFEO();
		}
	}

	private void ICPEGHHOIPD()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void PAELPCHJPJD()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.GHDMBFOAAHK(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LCJGOPGLGBB));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EALLBINBADE));
			bouncer.OEONGPFALKH.PEHELKCIECB();
		}
	}

	private void DMDGFHBKFPL()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.DHFPOCOEONG(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				HCHDDHFCOAP();
			});
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ICPEGHHOIPD));
			bouncer.OEONGPFALKH.PEHELKCIECB();
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		hit = false;
		timer = Time.time;
		bouncer.calm = false;
		bouncer.bouncerState = BouncerState.KickingRowdyCustomer;
	}

	private void MNMEFCKAAGC()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KMMGBACIDML()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void ACHINJAMJNK()
	{
		HCJHENEKLCH();
	}

	private void EALLBINBADE()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CKCMIJMLLDE()
	{
		HCHDDHFCOAP();
	}

	private void HCHDDHFCOAP()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)bouncer.customer).transform.position));
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				HCHDDHFCOAP();
			});
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			});
			bouncer.OEONGPFALKH.PEHELKCIECB();
		}
	}

	[CompilerGenerated]
	private void CBAIINNKGAL()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DJPGBBDJIBG()
	{
		LAJPOFMLPOC();
	}

	private void BIBLFOLPILB()
	{
		PAELPCHJPJD();
	}

	private void LCJGOPGLGBB()
	{
		LAJPOFMLPOC();
	}

	private void GENMOIAMABF()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.customer = null;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)bouncer.customer == (Object)null || bouncer.customer.customerState == CustomerState.Leaving || !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			bouncer.customer = null;
			bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
		}
		else if (!hit)
		{
			if (Vector3.Distance(((Component)bouncer.customer).transform.position, ((Component)bouncer).transform.position) <= 0.8f)
			{
				Debug.Log((object)"Hit");
				bouncer.characterAnimation.LookAtObject(((Component)bouncer.customer).gameObject);
				bouncer.characterAnimation.SetTrigger(StaffBaseState.p_Hit);
				bouncer.OEONGPFALKH.isActive = false;
				bouncer.DelayTrigger(StaffBaseState.p_Waiting, 1f);
				hit = true;
			}
			if (!bouncer.calm && Time.time > timer)
			{
				HCHDDHFCOAP();
				timer = Time.time + 2f;
			}
		}
	}

	private void AIHPEDGNHDM()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.GLHBJNDMIDC(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DLKNEMPGOLP));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CMBCOAGCIGA));
			bouncer.OEONGPFALKH.NOFKEMGPFEO();
		}
	}

	private void HBIKAEEJDNP()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.GDGGABHLNOH(Vector2.op_Implicit(((Component)bouncer.customer).transform.position));
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DLKNEMPGOLP));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(INKNHNOJCCG));
			bouncer.OEONGPFALKH.NOFKEMGPFEO();
		}
	}

	private void LNMOJHKGGLA()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DBEANIFPCBD()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.GDGGABHLNOH(Vector2.op_Implicit(((Component)bouncer.customer).transform.position));
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DNOAEOLEFNM));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BMJGHKEGBBI));
			bouncer.OEONGPFALKH.PEHELKCIECB();
		}
	}

	private void BMJGHKEGBBI()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void DLKNEMPGOLP()
	{
		GMIPPGOJKMA();
	}

	private void KEAFNECFJML()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void CMBMHJCJFFL()
	{
		PAELPCHJPJD();
	}

	private void MOOKELAEIAK()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.JJDCANFBFMK(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AMHCDMBNHFL));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CMBCOAGCIGA));
			bouncer.OEONGPFALKH.EHDKLBLKBEO();
		}
	}

	private void CMBCOAGCIGA()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void NEPEOPDJLOF()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.HELOLJBENMK(Vector2.op_Implicit(((Component)bouncer.customer).transform.position));
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AMHCDMBNHFL));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KEAFNECFJML));
			bouncer.OEONGPFALKH.EHDKLBLKBEO();
		}
	}

	private void GMIPPGOJKMA()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.GLHBJNDMIDC(Vector2.op_Implicit(((Component)bouncer.customer).transform.position));
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DNOAEOLEFNM));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GENMOIAMABF));
			bouncer.OEONGPFALKH.EHDKLBLKBEO();
		}
	}

	private void HCJHENEKLCH()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.BDIKOLNFKGD(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DJPGBBDJIBG));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MNMEFCKAAGC));
			bouncer.OEONGPFALKH.PEHELKCIECB();
		}
	}

	private void LAJPOFMLPOC()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)bouncer.customer == (Object)null) && !((Object)(object)bouncer.customer.customerToAnnoy == (Object)null))
		{
			if (!((Behaviour)bouncer.customer).enabled)
			{
				bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			}
			bouncer.OEONGPFALKH.GHDMBFOAAHK(Vector2.op_Implicit(((Component)bouncer.customer).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LCJGOPGLGBB));
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CNLICJBFKDK));
			bouncer.OEONGPFALKH.NOFKEMGPFEO();
		}
	}

	private void BCGKJNMODEH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void KODIAGPGAIB()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}

	private void LPIMCBKPFDH()
	{
		bouncer.behaviour.SetTrigger(StaffBaseState.p_Waiting);
	}
}
