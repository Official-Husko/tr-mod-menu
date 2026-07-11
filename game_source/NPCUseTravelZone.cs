using System;
using UnityEngine;

public class NPCUseTravelZone : NPCAction
{
	private TravelZone PHGGMIMGFDK;

	public NPCUseTravelZone(HumanNPC JHIFLALPEBF, TravelZone PHGGMIMGFDK)
	{
		npc = JHIFLALPEBF;
		this.PHGGMIMGFDK = PHGGMIMGFDK;
	}

	public override void PEHELKCIECB()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)PHGGMIMGFDK).transform.position));
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnSuccessfulStart = (Action)Delegate.Combine(walkTo.OnSuccessfulStart, new Action(base.EGDEAFHIKAI));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IALPAKDIDKG));
		npc.walkTo.PEHELKCIECB();
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
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (complete)
		{
			return true;
		}
		if (npc.walkTo.IIMEFNIECLI())
		{
			((Component)npc).transform.position = PHGGMIMGFDK.GetTravelZoneTo().GetCentrePosition();
			CharacterAnimation component = ((Component)npc).GetComponent<CharacterAnimation>();
			if ((Object)(object)component != (Object)null)
			{
				component.LookDirectionByAngle(Vector2.op_Implicit(((Component)npc).transform.position - PHGGMIMGFDK.GetTravelZoneTo().GetRandomPosition()));
			}
			EGIBBBDHEGC();
			return true;
		}
		return false;
	}
}
