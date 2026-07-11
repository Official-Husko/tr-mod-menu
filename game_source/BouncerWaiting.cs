using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BouncerWaiting : BouncerBaseState
{
	[CompilerGenerated]
	private sealed class JMMCCFDNGFI
	{
		public BouncerWaiting _003C_003E4__this;

		public Animator animator;

		internal void MCGGOAKFPLO()
		{
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}

		internal void CCMNDPOJOEB()
		{
			_003C_003E4__this.bouncer.characterAnimation.LookDirection(Direction.Down);
			CommonReferences.GGFJGHHHEJC.OnBouncerGoingToWork(1);
		}
	}

	private Vector3 IAIMKLHGFKJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].npc.LLNABOMIIOM() == (NPCState)4 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 COCHPGGPJOK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.PBLBPGPJFHI() == (NPCState)7 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 KBCKAGFCPNF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.DJAFGOHMNBK() == (NPCState)5 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 EOJBHEOPGLN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].npc.EOAONHNCDDO == (NPCState)5 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 BPCHLONJPLO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.DJAFGOHMNBK() == NPCState.Standing && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 PMGFMEIIADN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.PBLBPGPJFHI() == (NPCState)3 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 ANFABIFCLLF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].npc.EOAONHNCDDO == (NPCState)7 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 OOLJOGDLFED()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].npc.DLLLCEOKMBH() == NPCState.Sitting && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 CHNDIKAJKBO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].npc.DLLLCEOKMBH() == (NPCState)5 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		bouncer.OEONGPFALKH.IIMEFNIECLI();
	}

	private Vector3 CLKCPJHMDIC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].npc.LLNABOMIIOM() == (NPCState)4 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 PJFBKGJDAMC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.PBLBPGPJFHI() == NPCState.Walking && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 MGPPJHGHIIM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.PBLBPGPJFHI() == (NPCState)6 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 EDPJIJPDPHP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.DLLLCEOKMBH() == (NPCState)5 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 EGNDABLPMNF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.DJAFGOHMNBK() == NPCState.Standing && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 BOBOGKLNOOF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.EOAONHNCDDO == NPCState.Sitting && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 GHJHLMBDJIH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.LLNABOMIIOM() == (NPCState)6 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 BMLCBICDHIB()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.DJAFGOHMNBK() == (NPCState)8 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 JPFGGJBNMPM()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].npc.EOAONHNCDDO == NPCState.Standing && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 BPKLIPEDPAK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].npc.DJAFGOHMNBK() == NPCState.Standing && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 NEMEGOMENDL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.LLNABOMIIOM() == (NPCState)4 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 NDJEHBFFFIO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.PBLBPGPJFHI() == (NPCState)7 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 BJKKJAPGBHA()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.LLNABOMIIOM() == (NPCState)5 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 FEJOIIOIALC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.DJAFGOHMNBK() == (NPCState)4 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 HDJOMGKGKDO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].npc.LLNABOMIIOM() == (NPCState)6 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 GMPLGGOGCPN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.PBLBPGPJFHI() == (NPCState)4 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 JCIOJFEDJDJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].npc.EOAONHNCDDO == (NPCState)4 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		bouncer.avoidingWorkEmote.SetBool(StaffBaseState.p_Avoid, false);
		bouncer.bouncerState = BouncerState.Waiting;
		bouncer.customer = null;
		bouncer.characterAnimation.SetBool(StaffBaseState.p_Club, EGFGNGJGBOP: false);
		if (!bouncer.StartTask())
		{
			bouncer.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(((Component)Bar.instance.MDNLDHKIMOM).transform.position), AHDHLIECIGH: false);
			NPCWalkTo walkTo = bouncer.OEONGPFALKH;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
			{
				bouncer.characterAnimation.LookDirection(Direction.Down);
				CommonReferences.GGFJGHHHEJC.OnBouncerGoingToWork(1);
			});
			NPCWalkTo walkTo2 = bouncer.OEONGPFALKH;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
			{
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			});
			bouncer.OEONGPFALKH.PEHELKCIECB();
		}
	}

	private Vector3 NPHJKHNPKBF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].npc.PBLBPGPJFHI() == NPCState.Standing && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 EGOMHKNDNBH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].npc.EOAONHNCDDO == (NPCState)6 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 FDHDDEAGKFD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].npc.DLLLCEOKMBH() == (NPCState)8 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (!bouncer.StartTask() && bouncer.JFCLIAFAOEK != null && bouncer.JFCLIAFAOEK.tasks[1])
		{
			if (Barworker.IsValid() && Barworker.IsAtAvoidingWorkPoint())
			{
				bouncer.workerBringingBack = Barworker.GetInstance();
				bouncer.behaviour.SetTrigger(StaffBaseState.p_BringBackWorkers);
			}
			if (Waiter.IsValid() && Waiter.IsAtAvoidingWorkPoint())
			{
				bouncer.workerBringingBack = Waiter.GetInstance();
				bouncer.behaviour.SetTrigger(StaffBaseState.p_BringBackWorkers);
			}
			if (HouseKeeper.IsValid() && HouseKeeper.IsAtAvoidingWorkPoint())
			{
				bouncer.workerBringingBack = HouseKeeper.GetInstance();
				bouncer.behaviour.SetTrigger(StaffBaseState.p_BringBackWorkers);
			}
		}
	}

	private Vector3 GCAKOCPNIFL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].npc.DLLLCEOKMBH() == (NPCState)4 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}

	private Vector3 IKHNPOCLOHG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return BarMenuManager.PJLOPCHGEMM.position;
		}
		List<Customer> list = new List<Customer>(TavernManager.GGFJGHHHEJC.customers);
		list.Reverse();
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].npc.PBLBPGPJFHI() == (NPCState)6 && (Object)(object)list[i].npc.seat != (Object)null)
			{
				return Vector2.op_Implicit(list[i].npc.seat.entryPosition);
			}
		}
		return Utils.PPLGEIENOKA();
	}
}
