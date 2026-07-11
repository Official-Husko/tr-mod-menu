using System;
using UnityEngine;

public class NPCGoToBar : NPCAction
{
	public Action OnTavernEntered = delegate
	{
	};

	private Vector3 FHIHALCPJHL;

	private void MDOMHDIMIMO(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.River && PHGGMIMGFDK.locationTo == Location.None)
		{
			OnTavernEntered();
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerTavernEntered();
		}
	}

	private void KGDGNJFBEOA(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Road | Location.River) && PHGGMIMGFDK.locationTo == Location.Tavern)
		{
			OnTavernEntered();
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerTavernEntered();
		}
	}

	private void FELBJFCKPML(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.River && PHGGMIMGFDK.locationTo == Location.Tavern)
		{
			OnTavernEntered();
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerTavernEntered();
		}
	}

	private void OJKBHDIJEOM(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.Tavern && PHGGMIMGFDK.locationTo == Location.None)
		{
			OnTavernEntered();
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerTavernEntered();
		}
	}

	private void NCIIAAEINFC(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road | Location.River) && PHGGMIMGFDK.locationTo == Location.Tavern)
		{
			OnTavernEntered();
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerTavernEntered();
		}
	}

	private void IDHNAGCPMLJ(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road) && PHGGMIMGFDK.locationTo == Location.Tavern)
		{
			OnTavernEntered();
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerTavernEntered();
		}
	}

	private void HEBFLGAPIAK(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.Road && PHGGMIMGFDK.locationTo == Location.Tavern)
		{
			OnTavernEntered();
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerTavernEntered();
		}
	}

	protected override void IALPAKDIDKG()
	{
		Bar.instance.LeaveBar(npc as HumanNPC);
		Bar.instance.waitingAtBar.Remove(npc as HumanNPC);
		base.IALPAKDIDKG();
	}

	private void ABDMBDFENHM(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road) && PHGGMIMGFDK.locationTo == Location.None)
		{
			OnTavernEntered();
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerTavernEntered();
		}
	}

	public override void PEHELKCIECB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (Bar.instance.GetEmptyBarSpace(npc as HumanNPC, out FHIHALCPJHL))
		{
			npc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(FHIHALCPJHL), AHDHLIECIGH: false);
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.OnTravelZoneUsed = (Action<TravelZone>)Delegate.Combine(walkTo.OnTravelZoneUsed, new Action<TravelZone>(LFPLCELJKJE));
			NPCWalkTo walkTo2 = npc.walkTo;
			walkTo2.OnSuccessfulStart = (Action)Delegate.Combine(walkTo2.OnSuccessfulStart, new Action(base.EGDEAFHIKAI));
			NPCWalkTo walkTo3 = npc.walkTo;
			walkTo3.OnFailStart = (Action)Delegate.Combine(walkTo3.OnFailStart, new Action(IALPAKDIDKG));
			npc.walkTo.PEHELKCIECB();
		}
		else
		{
			IALPAKDIDKG();
		}
	}

	private void LFPLCELJKJE(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.Road && PHGGMIMGFDK.locationTo == Location.Tavern)
		{
			OnTavernEntered();
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerTavernEntered();
		}
	}

	public override void JKGGEMBAPAJ()
	{
		if (npc.walkTo != null)
		{
			npc.walkTo.JKGGEMBAPAJ();
		}
		base.JKGGEMBAPAJ();
	}

	public override bool IIMEFNIECLI(bool OEBNHGNJEJL = false)
	{
		if (complete)
		{
			return true;
		}
		if (npc.walkTo.IIMEFNIECLI())
		{
			EGIBBBDHEGC();
			return true;
		}
		return false;
	}

	private void IMPENKGLGCP(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == Location.River && PHGGMIMGFDK.locationTo == Location.Tavern)
		{
			OnTavernEntered();
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerTavernEntered();
		}
	}

	public NPCGoToBar(HumanNPC JHIFLALPEBF)
	{
		npc = JHIFLALPEBF;
	}

	private void HLJECEGECAM(TravelZone PHGGMIMGFDK)
	{
		if (PHGGMIMGFDK.location == (Location.Tavern | Location.Road | Location.River) && PHGGMIMGFDK.locationTo == Location.None)
		{
			OnTavernEntered();
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerTavernEntered();
		}
	}
}
