using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WaiterCleaningTable : WaiterBaseState
{
	[CompilerGenerated]
	private sealed class JMMCCFDNGFI
	{
		public WaiterCleaningTable _003C_003E4__this;

		public Animator animator;

		public Action _003C_003E9__1;

		internal void CCMNDPOJOEB()
		{
			_003C_003E4__this.CJEOFFHHPEK(delegate
			{
				CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
				TavernManager.GGFJGHHHEJC.blockedTables.Add(_003C_003E4__this.waiter.tableServing);
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Remove(_003C_003E4__this.waiter.tableServing);
				animator.SetTrigger(StaffBaseState.p_Waiting);
			});
		}

		internal void MCGGOAKFPLO()
		{
			CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
			TavernManager.GGFJGHHHEJC.blockedTables.Add(_003C_003E4__this.waiter.tableServing);
			TavernManager.GGFJGHHHEJC.tableNeedsClean.Remove(_003C_003E4__this.waiter.tableServing);
			animator.SetTrigger(StaffBaseState.p_Waiting);
		}
	}

	[CompilerGenerated]
	private sealed class KNMCLJPFFIF
	{
		public WaiterCleaningTable _003C_003E4__this;

		public Vector2 position;

		public Action fail;

		internal void PPNDJCOKJMJ()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!_003C_003E4__this.waiter.positionsBlocked.Contains(position))
			{
				_003C_003E4__this.waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			fail();
		}

		internal void KELMNNMEMGB()
		{
			if (Object.op_Implicit((Object)(object)_003C_003E4__this.waiter) && Object.op_Implicit((Object)(object)_003C_003E4__this.waiter.tableServing))
			{
				_003C_003E4__this.waiter.characterAnimation.LookAtObject(((Component)_003C_003E4__this.waiter.tableServing).gameObject);
				_003C_003E4__this.waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, _003C_003E4__this.waiter.tableServing.placeable.placeableSurface);
			}
			_003C_003E4__this.waiter.cleaningTable = true;
		}
	}

	private float BPDICIAJNIH()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(85) / 906f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-9) / 556f;
	}

	private float CDBPNDPIMEH()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-80) / 390f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-94) / 1307f;
	}

	private float LNFBDFJAIHH()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(56) / 1874f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-110) / 1973f;
	}

	private void KDHKBIFOBDG(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.GDGGABHLNOH(position, AHDHLIECIGH: false);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.EHDKLBLKBEO();
	}

	private void HDDJPPAGMAL(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.GetNearPositionToClean(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.GLHBJNDMIDC(position);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.NOFKEMGPFEO();
	}

	private float OLIPBMDCGKN()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(122) / 1789f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(85) / 255f;
	}

	private float GNELHHMPCLJ()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-66) / 1782f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(55) / 849f;
	}

	private void BGKPIFLIPJB(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.HELOLJBENMK(position, AHDHLIECIGH: false, NGAKHGJANLO: false);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.NOFKEMGPFEO();
	}

	private float CGKOIGOGGIB()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-94) / 1960f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(94) / 999f;
	}

	private float EOMIGFLCILG()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(34) / 1892f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(82) / 957f;
	}

	private float ABACINEBFGK()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(29) / 1297f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(119) / 744f;
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.tableServing = null;
		waiter.cleaningTable = false;
	}

	private float CEGAJKGDAGP()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(9) / 257f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(67) / 1862f;
	}

	private void IIFFOKFBGCL(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.FNNPPBDFBCI(position);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.PEHELKCIECB();
	}

	private float GDCOPHMLGCM()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-53) / 906f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(49) / 712f;
	}

	private void LGKIEDCEJGO(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.GetNearPositionToClean(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.CGFMBJFGLAG(position);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.NOFKEMGPFEO();
	}

	private float NOPJLPANJEM()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-100) / 308f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(17) / 538f;
	}

	private float EJNOIMHFJFB()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(59) / 103f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-44) / 49f;
	}

	private float DMKKBIGGOEO()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(2) / 1312f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(46) / 964f;
	}

	private void NHAKGGMFAPP(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.GetNearPositionToClean(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.JJDCANFBFMK(position);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.NOFKEMGPFEO();
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (waiter.cleaningTable)
		{
			if (waiter.characterAnimation.characterAnimator.MLBGEKOIALK && !waiter.characterAnimation.characterAnimator.stoppingToClean)
			{
				waiter.tableServing.WorkerCleaning(IDFFJFHKGNN() * Time.deltaTime);
			}
		}
		else if (waiter.JFCLIAFAOEK != null && waiter.JFCLIAFAOEK.tasks[0] && DrinksTable.instance.currentDrinks.Any() && Vector3.Distance(((Component)DrinksTable.instance).transform.position, ((Component)waiter).transform.position) < Vector3.Distance(Vector2.op_Implicit(waiter.OEONGPFALKH.target), ((Component)waiter).transform.position))
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_HeadingToDrinksTable);
		}
	}

	private void DNNDPDGJOMO(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.CGFMBJFGLAG(position, AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.EHDKLBLKBEO();
	}

	private float ADGKNEHJJPE()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-119) / 363f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-109) / 278f;
	}

	private float BCJCDNCLNMF()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-52) / 1696f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(30) / 567f;
	}

	private float KOIOJKKLJDH()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-70) / 1128f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(5) / 192f;
	}

	private void KCJAOIMNLMH(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.GetNearPositionToClean(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.CGFMBJFGLAG(position);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.EHDKLBLKBEO();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		waiter.cleaningTable = false;
		waiter.waiterState = WaiterState.CleaningTable;
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		CJEOFFHHPEK(delegate
		{
			CJEOFFHHPEK(delegate
			{
				CommonReferences.GGFJGHHHEJC.OnWaiterGoingToWork(1);
				TavernManager.GGFJGHHHEJC.blockedTables.Add(waiter.tableServing);
				TavernManager.GGFJGHHHEJC.tableNeedsClean.Remove(waiter.tableServing);
				ONDMDLMHMHK.SetTrigger(StaffBaseState.p_Waiting);
			});
		});
	}

	private float IDFFJFHKGNN()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(28) / 100f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(63) / 100f;
	}

	private float JDIHKCNCFDK()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(94) / 329f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(44) / 1588f;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		if (waiter.OEONGPFALKH.IIMEFNIECLI())
		{
			waiter.OEONGPFALKH.isActive = false;
		}
	}

	private void CJEOFFHHPEK(Action OCMBLOGIPIK)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)waiter.tableServing == (Object)null)
		{
			waiter.behaviour.SetTrigger(StaffBaseState.p_Waiting);
			return;
		}
		Vector2 position = waiter.tableServing.GetNearPositionToClean(Vector2.op_Implicit(((Component)waiter).transform.position), waiter.positionsBlocked);
		waiter.OEONGPFALKH.FNNPPBDFBCI(position, AHDHLIECIGH: false);
		NPCWalkTo walkTo = waiter.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, (Action)delegate
		{
			if (Object.op_Implicit((Object)(object)waiter) && Object.op_Implicit((Object)(object)waiter.tableServing))
			{
				waiter.characterAnimation.LookAtObject(((Component)waiter.tableServing).gameObject);
				waiter.characterAnimation.SetCleaning(NJHMBMGKCPL: true, waiter.tableServing.placeable.placeableSurface);
			}
			waiter.cleaningTable = true;
		});
		NPCWalkTo walkTo2 = waiter.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			if (!waiter.positionsBlocked.Contains(position))
			{
				waiter.positionsBlocked.Add(position);
			}
			Debug.Log((object)"OnFailStart cleaningTable");
			OCMBLOGIPIK();
		});
		waiter.OEONGPFALKH.PEHELKCIECB();
	}

	private float KAJFAOOEENK()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(127) / 1381f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-5) / 292f;
	}

	private float IMGLHHKALDP()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(94) / 1146f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-112) / 1976f;
	}

	private float FCDGIJDHNOB()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(8) / 1256f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-66) / 1279f;
	}

	private float JLPJIPNDLDD()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-87) / 1839f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(55) / 412f;
	}

	private float LEOJCMHBIMB()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(55) / 673f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(14) / 1741f;
	}

	private float LODDPFJPKML()
	{
		return waiter.cleaningTableSpeed + waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(-120) / 969f - waiter.cleaningTableSpeed * (float)waiter.GetPerkValue(86) / 110f;
	}
}
