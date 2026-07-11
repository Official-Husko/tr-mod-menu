using System;
using UnityEngine;

public class WaiterLeaving : WaiterBaseState
{
	private void LFPJOALAOEL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void ACPGELKPHKN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)waiter != (Object)null)
		{
			NPCWalkTo walkTo = waiter.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Remove(walkTo.OnActionComplete, new Action(DMOMPOOJHIL));
			NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Remove(walkTo2.OnFailStart, new Action(DMOMPOOJHIL));
		}
	}

	private void OHALEKFNPMK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void OBICCBIJGNN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void DIEOOLLOOML()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void FPMJPPDGBAP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void BODDPBMPLIC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void CHDFJMKAMFN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void DMOMPOOJHIL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.waiterState = WaiterState.Leaving;
		waiter.ResetFloorDirt();
		if (Object.op_Implicit((Object)(object)waiter.tableServing))
		{
			waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: false, waiter.tableServing.placeable.placeableSurface);
		}
		waiter.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)NPCRoadManager.GetRandomSpawner()).transform.position));
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DMOMPOOJHIL));
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DMOMPOOJHIL));
		waiter.OEONGPFALKH.PEHELKCIECB();
	}

	private void BEKFBAAPJIK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void HNFJNGNLFLE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void KMGPFMCNICE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void BDEPLNMCKHK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void BHFBPDOBMPK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void MJDJJNOKNML()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void GICGBJKFALO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void LCPEHOGIDEC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void LDJDAEPJIKA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void AGHPMIKLDGH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void HAOBGHOJJOG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void OMNAHPPIMIA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void CMBIOPKFHBM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void OEDNMIMJEKK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void DICPHLFBFJN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void BCFBIDJCMGN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void PAJLGMONPKP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void BACLKHCHOEK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void JIHFGHJOEFB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void BDAGNMAMEBJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void PBBGNPELIPO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		waiter.OEONGPFALKH.IIMEFNIECLI();
	}

	private void BECPDAGOEDC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void FHMINPAJPMO()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void IKFBGFBKIEF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void CJAJFMKMHEE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void GEILFDMKIMD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void LJOAKMDDIAA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void DOJJLEJBEHG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void NANGPEPINGF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void CBBGCOPDLOJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void ENNJNONPDPH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void FPDNCPBHDPE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void PGEKAJPKDFD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void LBBOMKADODB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void LOIGKMAAMDC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}

	private void KGECIMMLILH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)waiter).gameObject);
		}
	}
}
