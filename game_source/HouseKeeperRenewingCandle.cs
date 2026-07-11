using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeperRenewingCandle : HouseKeeperBaseState
{
	private bool renewingCandle;

	private float renewingCandleFinishTime;

	private List<Vector3> EFIHHOPNHID(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == (SpecificType.Bar | SpecificType.NextToWall))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 nearPositionToClean = component.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(nearPositionToClean) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> BGIOPLBFLLL(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar | SpecificType.PlayerBed))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> ADGBLFJFDKI(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> GNNOBNCEJKI(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == (SpecificType.Door | SpecificType.StairsUp | SpecificType.Bar))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private void JOHAIDKGACI()
	{
		houseKeeper.ACOACAMBJIK(houseKeeper.candleHolder);
		houseKeeper.StartTask();
	}

	private List<Vector3> LLGBKMCAJND()
	{
		List<Vector3> list = JFFIMDPMEAI(0);
		if (list.Count == 0)
		{
			list = LHHIBHKAIHB(7);
		}
		return list;
	}

	private List<Vector3> PILHMALFHLB()
	{
		List<Vector3> list = BGIOPLBFLLL(1);
		if (list.Count == 0)
		{
			list = BGIOPLBFLLL(3);
		}
		return list;
	}

	private List<Vector3> HBPHMEJEKLH()
	{
		List<Vector3> list = LHHIBHKAIHB(1);
		if (list.Count == 0)
		{
			list = NGDCPHGHJPC(1);
		}
		return list;
	}

	private List<Vector3> PJHNECMGJGF()
	{
		List<Vector3> list = DMAEHPMBPJD(0);
		if (list.Count == 0)
		{
			list = LHHIBHKAIHB(8);
		}
		return list;
	}

	public void HILLNFIICFK()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = true;
		renewingCandleFinishTime = Time.time + 991f;
		houseKeeper.npc.DKMPEPHLBGI().NCAJNNHBHJM(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position)));
		houseKeeper.npc.LNJABLMFNNE().BNGPBEOAGCH(KOIDJKBBINH: true);
	}

	public void EDDOIJHPBHM()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = false;
		renewingCandleFinishTime = Time.time + 654f;
		houseKeeper.npc.FJHKGBNBNKL.FCGBJEIIMBC = Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position));
		houseKeeper.npc.NOJMFFFDAJA().BNGPBEOAGCH(KOIDJKBBINH: true);
	}

	private List<Vector3> LHHIBHKAIHB(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == ~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.PlayerBed | SpecificType.StairsDown))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> DMAEHPMBPJD(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == ~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.StairsUp | SpecificType.Bar | SpecificType.NextToWall))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 nearPositionToClean = component.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(nearPositionToClean) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	public void EJPFGEHOKPK()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = false;
		renewingCandleFinishTime = Time.time + 735f;
		houseKeeper.npc.PNGIDKBCGCK().NCAJNNHBHJM(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position)));
		houseKeeper.npc.IMGOIBOHCIK().BNGPBEOAGCH(KOIDJKBBINH: true);
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		houseKeeper.npc.FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
		houseKeeper.candleHolder = null;
	}

	private List<Vector3> AOBFEFEPLNJ(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == SpecificType.Table)
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 nearPositionToClean = component.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(nearPositionToClean) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> EODFOGFGFDJ()
	{
		List<Vector3> list = GNNOBNCEJKI(1);
		if (list.Count == 0)
		{
			list = EFIHHOPNHID(0);
		}
		return list;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)houseKeeper.candleHolder == (Object)null || houseKeeper.candleHolder.FHEMHCEAICB)
		{
			houseKeeper.StartTask();
		}
		else if (renewingCandle)
		{
			if (Time.time > renewingCandleFinishTime)
			{
				houseKeeper.npc.FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: false);
				houseKeeper.candleHolder.placeableSurface.RenewCandleIfIsPossible(ItemDatabaseAccessor.GetItem(Utils.FFLNGLMHLBO() ? 1083 : 605));
				houseKeeper.RemoveCandleHolder(houseKeeper.candleHolder);
				houseKeeper.StartTask();
			}
		}
		else if (houseKeeper.IsCandleHolderInRentedRoomOccupiedOrCustomerComingBack(houseKeeper.candleHolder))
		{
			houseKeeper.StartTask();
		}
	}

	private List<Vector3> JFFIMDPMEAI(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == (SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.Bar))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 nearPositionToClean = component.GetNearPositionToClean(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(nearPositionToClean) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> GGGHAIBFPJE(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.PlayerBed | SpecificType.NextToWall))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> HNKGJFAEKIA()
	{
		List<Vector3> list = AOBFEFEPLNJ(1);
		if (list.Count == 0)
		{
			list = AOBFEFEPLNJ(2);
		}
		return list;
	}

	private List<Vector3> EJFHACACDLN(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == ~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.NextToWall | SpecificType.StairsDown))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> DHHHCOHHGPE()
	{
		List<Vector3> list = DMAEHPMBPJD(0);
		if (list.Count == 0)
		{
			list = GGGHAIBFPJE(0);
		}
		return list;
	}

	private void FMKFNJOJGIO()
	{
		houseKeeper.ACOACAMBJIK(houseKeeper.candleHolder);
		houseKeeper.StartTask();
	}

	private void LFODMMEJNDE()
	{
		houseKeeper.IBCPCCJGKHK(houseKeeper.candleHolder);
		houseKeeper.GAAHCGLGHKG();
	}

	private void JFIGNFNPLMO()
	{
		houseKeeper.FCHCMCFFJPD(houseKeeper.candleHolder);
		houseKeeper.StartTask();
	}

	public void PDOBHPLPKHG()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = true;
		renewingCandleFinishTime = Time.time + 1f;
		houseKeeper.npc.FJHKGBNBNKL.FCGBJEIIMBC = Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position));
		houseKeeper.npc.FJHKGBNBNKL.SetInteracting(KOIDJKBBINH: true);
	}

	public void AHPFECCLOBB()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = true;
		renewingCandleFinishTime = Time.time + 1079f;
		houseKeeper.npc.LNJABLMFNNE().FCGBJEIIMBC = Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position));
		houseKeeper.npc.IBGCFFIFPBL().AOBJCNDNKDD(KOIDJKBBINH: false);
	}

	private List<Vector3> GLOAIPPJDCP()
	{
		List<Vector3> list = DMAEHPMBPJD(1);
		if (list.Count == 0)
		{
			list = EFIHHOPNHID(6);
		}
		return list;
	}

	public override void JDHKHKJOKFF()
	{
		base.JDHKHKJOKFF();
		houseKeeper.OEONGPFALKH.IIMEFNIECLI();
	}

	private List<Vector3> KINAPIADKNF(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == (SpecificType.Door | SpecificType.NextToWall))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private void DGONMKKKFGA()
	{
		houseKeeper.CJNNDJFGCOK(houseKeeper.candleHolder);
		houseKeeper.GAAHCGLGHKG();
	}

	public void MMPGIKGMFMA()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = false;
		renewingCandleFinishTime = Time.time + 361f;
		houseKeeper.npc.DKLMKBPEHAJ().NCAJNNHBHJM(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position)));
		houseKeeper.npc.IBGCFFIFPBL().BNGPBEOAGCH(KOIDJKBBINH: false);
	}

	[CompilerGenerated]
	private void FEAPOKCCEBP()
	{
		houseKeeper.RemoveCandleHolder(houseKeeper.candleHolder);
		houseKeeper.StartTask();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)houseKeeper.candleHolder == (Object)null || houseKeeper.candleHolder.FHEMHCEAICB || houseKeeper.candleHolder.isPlaceableOnWall)
		{
			houseKeeper.StartTask();
			return;
		}
		houseKeeper.houseKeeperState = HouseKeeperState.RenewingCandle;
		List<Vector3> list = HNKGJFAEKIA();
		if (list.Count == 0)
		{
			houseKeeper.RemoveCandleHolder(houseKeeper.candleHolder);
			houseKeeper.candleHolder = null;
			houseKeeper.StartTask();
			return;
		}
		renewingCandle = false;
		Vector3 jAFKHHNPOGJ = (Utils.EJPFCKFEMJF(((Component)houseKeeper).transform.position) ? ((Component)houseKeeper).transform.position : TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road).GetCentrePosition());
		houseKeeper.finalPosition = Utils.JOJPOKBFANL(list.ToArray(), jAFKHHNPOGJ);
		houseKeeper.OEONGPFALKH.FNNPPBDFBCI(Vector2.op_Implicit(houseKeeper.finalPosition), AHDHLIECIGH: false);
		NPCWalkTo walkTo = houseKeeper.OEONGPFALKH;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = houseKeeper.OEONGPFALKH;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			houseKeeper.RemoveCandleHolder(houseKeeper.candleHolder);
			houseKeeper.StartTask();
		});
		houseKeeper.OEONGPFALKH.PEHELKCIECB();
	}

	private void FOJKMHBIIIH()
	{
		houseKeeper.FIFAOIKPEFF(houseKeeper.candleHolder);
		houseKeeper.StartTask();
	}

	public void COACMHKHDBL()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = false;
		renewingCandleFinishTime = Time.time + 1991f;
		houseKeeper.npc.OJELDLIEDNI().NCAJNNHBHJM(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position)));
		houseKeeper.npc.OLHBCAHONME().MBMPBFEINMA(KOIDJKBBINH: false);
	}

	public void OGBEGBJDNKJ()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		renewingCandle = true;
		renewingCandleFinishTime = Time.time + 898f;
		houseKeeper.npc.CFIFGDBGLPH().NCAJNNHBHJM(Utils.EIDFHLPBICI(Vector2.op_Implicit(((Component)houseKeeper.candleHolder).transform.position - ((Component)houseKeeper).transform.position)));
		houseKeeper.npc.DKLMKBPEHAJ().MBMPBFEINMA(KOIDJKBBINH: false);
	}

	private List<Vector3> FACAEAFCAAM()
	{
		List<Vector3> list = BGIOPLBFLLL(1);
		if (list.Count == 0)
		{
			list = GNNOBNCEJKI(7);
		}
		return list;
	}

	private List<Vector3> NGDCPHGHJPC(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == ~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.Bar | SpecificType.StairsDown))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}

	private List<Vector3> IMBOAMDENCA(int DFFGLLDDEPN)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)houseKeeper.candleHolder.currentSurface != (Object)null && (Object)(object)houseKeeper.candleHolder.currentSurface.placeable.itemSpace != (Object)null)
		{
			if (houseKeeper.candleHolder.currentSurface.placeable.specificRules == ~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.PlayerBed))
			{
				Table component = ((Component)houseKeeper.candleHolder.currentSurface.placeable).GetComponent<Table>();
				if (Object.op_Implicit((Object)(object)component))
				{
					Vector2 val = component.PBJNLGOBPIJ(Vector2.op_Implicit(((Component)houseKeeper).transform.position), null);
					return new List<Vector3> { Vector2.op_Implicit(val) };
				}
			}
			return WorldGrid.HALEJLJFMLJ(houseKeeper.candleHolder.currentSurface.placeable, DFFGLLDDEPN);
		}
		return WorldGrid.EHJLDGOIILF(((Component)houseKeeper.candleHolder).transform.position, DFFGLLDDEPN);
	}
}
