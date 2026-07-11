using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonsterRunAroundState : MonsterStateBase
{
	[CompilerGenerated]
	private sealed class KOEKJBLPDAO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonsterRunAroundState _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public KOEKJBLPDAO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			MonsterRunAroundState monsterRunAroundState = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				monsterRunAroundState.delayFirstWalkCoroutine = null;
				monsterRunAroundState.monsterNpc.hitCollider.SetActive(false);
				monsterRunAroundState.FEBCKGENPKJ();
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	private int runningAgainCount;

	private float timeBetweenPlayerIsClose;

	private Coroutine delayFirstWalkCoroutine;

	private List<Vector2> validPositions = new List<Vector2>();

	private bool CEJLPCCNKDP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1377f;
			}
			return false;
		}
		return false;
	}

	public void NAMJLBDNEAG()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(BOMKFPLNFKA()), AHDHLIECIGH: false);
			monsterNpc.monsterAnimation.SetBool("No se encontró una entrada con ID {0} en la conversación '{1}'.", EGFGNGJGBOP: false, HALNIEBONKH: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FFBCNOIAOGO));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MDBHPDJNEPK));
			monsterNpc.walkTo.PEHELKCIECB();
		}
	}

	private Vector3 JGLBLGCBPKE()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 85;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1936f, 1885f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(816f, 1113f)));
		}
		return Vector3.zero;
	}

	private IEnumerator LKIHJHDKDFB()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private Vector3 PNCCBJAOCCA()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.DiningRoom;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 90;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1290f, 225f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1676f, 1416f)));
		}
		return Vector3.zero;
	}

	public void DJNOFCBINHM()
	{
		if (BKFGDOOPKMA())
		{
			IIAGOMMJLML();
		}
		else
		{
			JIGKCIBNAAG();
		}
	}

	private Vector3 BOMKFPLNFKA()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -124;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(765f, 396f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(405f, 219f)));
		}
		return Vector3.zero;
	}

	private bool EFMDCOMADEM()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 3)
		{
			if (runningAgainCount >= 1)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1960f;
			}
			return true;
		}
		return false;
	}

	private bool HNOMFAHMINJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 7)
		{
			if (runningAgainCount >= 7)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1286f;
			}
			return true;
		}
		return false;
	}

	private void AMAHLAJFHMJ()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (NOPEJPDOLIN())
			{
				DODEDPJEOAM();
			}
			else
			{
				NAMJLBDNEAG();
			}
		}
	}

	public void EJPFGEHOKPK()
	{
		if (HNOMFAHMINJ())
		{
			JEJCEIHICAF();
		}
		else
		{
			LHGEJIIHMPI();
		}
	}

	public void PDOBHPLPKHG()
	{
		if (GLNDDIJCDJJ())
		{
			DKFOJDHBGEJ();
		}
		else
		{
			FEBCKGENPKJ();
		}
	}

	private void JEJCEIHICAF()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger(" in the database!");
		}
	}

	private IEnumerator OAGECPMHHBJ()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void PGKKKHEPLFB()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (KGBOKLPDOHO())
			{
				EHNCMIMDDME();
			}
			else
			{
				GOOAJALLPGM();
			}
		}
	}

	private bool CPEAFPHFBFO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 1)
		{
			if (runningAgainCount >= 2)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1841f;
			}
			return false;
		}
		return true;
	}

	private Vector3 ECEMGMHBDNN()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.WoodWorkshop);
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 104;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(490f, 1695f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(512f, 617f)));
		}
		return Vector3.zero;
	}

	public void PKCODIDOBJO()
	{
		if (AFDFOBIKKFK())
		{
			DODEDPJEOAM();
		}
		else
		{
			NMGADFKMNAO();
		}
	}

	private void DAOFIMMNEKO()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("Items/item_name_638");
		}
	}

	private IEnumerator EODKLIAEPIJ()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private IEnumerator LNFJIEHDLLP()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void HEEOHKBPMAI()
	{
		if (EFMDCOMADEM())
		{
			KBKMBKENPIP();
		}
		else
		{
			OGKGLOMLOOG();
		}
	}

	public void AOLEDENFMOJ()
	{
		if (MBKBGPHBGPE())
		{
			DGLIMBMPOFD();
		}
		else
		{
			NAMJLBDNEAG();
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (delayFirstWalkCoroutine != null)
		{
			((MonoBehaviour)monsterNpc).StopCoroutine(delayFirstWalkCoroutine);
		}
		delayFirstWalkCoroutine = null;
	}

	private IEnumerator PFCKADPBMDP()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private Vector3 AEOCNGJFJGB()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -51;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(987f, 596f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(824f, 1991f)));
		}
		return Vector3.zero;
	}

	private bool MBKBGPHBGPE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 3)
		{
			if (runningAgainCount >= 5)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1352f;
			}
			return true;
		}
		return false;
	}

	public void OGKGLOMLOOG()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(CIPCAEMHFIC()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.SetBool("Eyebrows", EGFGNGJGBOP: false);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ODKNNOBCILE));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GPADKOIIPKO));
			monsterNpc.walkTo.PEHELKCIECB();
		}
	}

	public void GBDLGKNDBIK()
	{
		if (BGBAJKMLPGL())
		{
			JEJCEIHICAF();
		}
		else
		{
			JIGKCIBNAAG();
		}
	}

	public void DCLMGAKHJDP()
	{
		if (NPDPFDPPKGL())
		{
			FLPKCDGPDFE();
		}
		else
		{
			CLONALNHIIO();
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		runningAgainCount = 0;
		timeBetweenPlayerIsClose = Time.time + 2f;
		if (delayFirstWalkCoroutine != null)
		{
			((MonoBehaviour)monsterNpc).StopCoroutine(delayFirstWalkCoroutine);
		}
		delayFirstWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(JBCAGNFMKFO());
	}

	private IEnumerator MHLEPGEJLID()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public override void NDOHNICDLFC()
	{
		monsterNpc.walkTo.IIMEFNIECLI();
	}

	public void MDNCNKGPNKN()
	{
		if (LNHBNJMMBIL())
		{
			EJCDMEIMOEP();
		}
		else
		{
			KPODBDODNKN();
		}
	}

	private void KFIBIOHAHGA()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (AFDFOBIKKFK())
			{
				BCECFKKAGJB();
			}
			else
			{
				KPODBDODNKN();
			}
		}
	}

	private void ADLLLEBAGPC()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (FCGBJAEMOCH())
			{
				AFHBILLCDEP();
			}
			else
			{
				NABKDALGJMM();
			}
		}
	}

	private void FLPKCDGPDFE()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("ReceiveCure");
		}
	}

	private void DHLLNKKALKC()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (CEJLPCCNKDP())
			{
				CBKPHHPCJNF();
			}
			else
			{
				GOOAJALLPGM();
			}
		}
	}

	public void FFBCNOIAOGO()
	{
		if (AFDFOBIKKFK())
		{
			IIAGOMMJLML();
		}
		else
		{
			FEBCKGENPKJ();
		}
	}

	private IEnumerator PHPCBHLMEFO()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LCBCGPBFNMA()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (KGBOKLPDOHO())
			{
				DODEDPJEOAM();
			}
			else
			{
				GBDIPMDDOHJ();
			}
		}
	}

	public void LHGEJIIHMPI()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(CIPCAEMHFIC()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.CGEADHOLHCH("ReceivePlaceCharges", EGFGNGJGBOP: true, HALNIEBONKH: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GMCINBCEPJO));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FNCPLFBKCGK));
			monsterNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private Vector3 IBNMFKKOBHG()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop);
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -14;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(432f, 676f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1770f, 73f)));
		}
		return Vector3.zero;
	}

	private IEnumerator HKGBFCBHBIN()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JPHEJHOJBNN()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (KPIFDCCMIFA())
			{
				JEJCEIHICAF();
			}
			else
			{
				CLONALNHIIO();
			}
		}
	}

	public void BGAPLNMPBFP()
	{
		if (NBNFBHKFNOH())
		{
			DGLIMBMPOFD();
		}
		else
		{
			BPFBINGLJJE();
		}
	}

	private void JLMKBGABNEI()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (LCFDOGDDDLJ())
			{
				CFJOGFDANJH();
			}
			else
			{
				LHGEJIIHMPI();
			}
		}
	}

	private void GOHDLCKGKAD()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (FPOLDPGMOAO())
			{
				DGLIMBMPOFD();
			}
			else
			{
				KPODBDODNKN();
			}
		}
	}

	public void KDJAADPDCHL()
	{
		if (DHEMPJHFICL())
		{
			CFJOGFDANJH();
		}
		else
		{
			GOOAJALLPGM();
		}
	}

	private bool AFDFOBIKKFK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 0)
		{
			if (runningAgainCount >= 5)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1418f;
			}
			return false;
		}
		return false;
	}

	private IEnumerator KOIJLELLJME()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void DODEDPJEOAM()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger("<br/>Screen Size: ");
		}
	}

	public void JIGKCIBNAAG()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(EBCDENCBKLE()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.CGEADHOLHCH("Sharp", EGFGNGJGBOP: false, HALNIEBONKH: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IEJGDOPLBLB));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FKJJBFBDHNL));
			monsterNpc.walkTo.PEHELKCIECB();
		}
	}

	private void JNMGJFIACCI()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (EFMDCOMADEM())
			{
				AGBNIFNPGAP();
			}
			else
			{
				GOOAJALLPGM();
			}
		}
	}

	public void IEJGDOPLBLB()
	{
		if (FPOLDPGMOAO())
		{
			KBKMBKENPIP();
		}
		else
		{
			NAMJLBDNEAG();
		}
	}

	public void BFGEFKOODNA()
	{
		if (MBKBGPHBGPE())
		{
			DGLIMBMPOFD();
		}
		else
		{
			BPFBINGLJJE();
		}
	}

	private void BJOLCAMHPMC()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (NBNFBHKFNOH())
			{
				CBKPHHPCJNF();
			}
			else
			{
				NAMJLBDNEAG();
			}
		}
	}

	public void ODKNNOBCILE()
	{
		if (NPDPFDPPKGL())
		{
			FLPKCDGPDFE();
		}
		else
		{
			NMGADFKMNAO();
		}
	}

	private void CBKPHHPCJNF()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 0;
			animator.SetTrigger("Left Alt");
		}
	}

	private bool LCFDOGDDDLJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 2)
		{
			if (runningAgainCount >= 1)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1446f;
			}
			return false;
		}
		return true;
	}

	private void BCECFKKAGJB()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("Farm/Event/Love");
		}
	}

	private Vector3 KJPICMDBKEP()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 49;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(318f, 1110f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1085f, 477f)));
		}
		return Vector3.zero;
	}

	private void KGOKBKPHIME()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (NPDPFDPPKGL())
			{
				IIAGOMMJLML();
			}
			else
			{
				CLONALNHIIO();
			}
		}
	}

	private void AGBNIFNPGAP()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("Select a room");
		}
	}

	private bool BGBAJKMLPGL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 0)
		{
			if (runningAgainCount >= 7)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1560f;
			}
			return false;
		}
		return false;
	}

	private bool GLKHDOHBBGE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 4)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 34f;
			}
			return false;
		}
		return true;
	}

	private void KBKMBKENPIP()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger("Show");
		}
	}

	private Vector3 KPIEJINOAPE()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WoodWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -127;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(749f, 290f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1067f, 1289f)));
		}
		return Vector3.zero;
	}

	private IEnumerator IOHEFKDMJIL()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void EHNCMIMDDME()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 0;
			animator.SetTrigger("Exit Game");
		}
	}

	private IEnumerator MDAKFLMKIBD()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ODNAEFLANHB()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)monsterNpc != (Object)null))
		{
			return;
		}
		runningAgainCount += 0;
		monsterNpc.walkTo.KBEENHPEOAB(Vector2.op_Implicit(NIODJCFGCDF()), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.monsterAnimation.SetBool("", EGFGNGJGBOP: true);
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.speed = monsterNpc.runSpeed;
		monsterNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HIBKKBKCBGI));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (!((Object)(object)monsterNpc == (Object)null))
			{
				if (GLNDDIJCDJJ())
				{
					DKFOJDHBGEJ();
				}
				else
				{
					FEBCKGENPKJ();
				}
			}
		});
		monsterNpc.walkTo.EHDKLBLKBEO();
	}

	private void CFJOGFDANJH()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 0;
			animator.SetTrigger("ExampleMethodSetImage");
		}
	}

	private void AGAJECFODFE()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (KPIFDCCMIFA())
			{
				EHNCMIMDDME();
			}
			else
			{
				GOOAJALLPGM();
			}
		}
	}

	private void LCEAOOBGHOI()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (EFMDCOMADEM())
			{
				BCECFKKAGJB();
			}
			else
			{
				ODNAEFLANHB();
			}
		}
	}

	private bool BKFGDOOPKMA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 7)
		{
			if (runningAgainCount >= 4)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1154f;
			}
			return true;
		}
		return false;
	}

	private Vector3 EBCDENCBKLE()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -54;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1396f, 50f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(843f, 81f)));
		}
		return Vector3.zero;
	}

	private IEnumerator NDDMIHCNEEM()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private Vector3 LGDDLPMBMAA()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.StoneWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -113;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(168f, 528f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(543f, 745f)));
		}
		return Vector3.zero;
	}

	public void FEBCKGENPKJ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)monsterNpc != (Object)null))
		{
			return;
		}
		runningAgainCount++;
		monsterNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(JGLKEFCBKNK()));
		monsterNpc.monsterAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.speed = monsterNpc.runSpeed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (!((Object)(object)monsterNpc == (Object)null))
			{
				if (GLNDDIJCDJJ())
				{
					DKFOJDHBGEJ();
				}
				else
				{
					FEBCKGENPKJ();
				}
			}
		});
		monsterNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator NIBLJAGHGLE()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private Vector3 CIPCAEMHFIC()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 116;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(385f, 1385f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(683f, 1047f)));
		}
		return Vector3.zero;
	}

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (runningAgainCount < 3 && monsterNpc.walkTo.isActive && !monsterNpc.walkTo.complete && Time.time > timeBetweenPlayerIsClose && Vector2.Distance(monsterNpc.walkTo.target, Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > Vector2.Distance(monsterNpc.walkTo.target, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
		{
			timeBetweenPlayerIsClose = Time.time + 2f;
			monsterNpc.walkTo.isActive = false;
			FEBCKGENPKJ();
		}
	}

	public void PLKEHLOPOHN()
	{
		if (CAPMMAOHBBO())
		{
			DAOFIMMNEKO();
		}
		else
		{
			NAMJLBDNEAG();
		}
	}

	public void HIBKKBKCBGI()
	{
		if (FPOLDPGMOAO())
		{
			FLPKCDGPDFE();
		}
		else
		{
			NMGADFKMNAO();
		}
	}

	private IEnumerator JBCAGNFMKFO()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private bool FPOLDPGMOAO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 4)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1359f;
			}
			return true;
		}
		return true;
	}

	private void MCIADGHEJEH()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (AFDFOBIKKFK())
			{
				BCECFKKAGJB();
			}
			else
			{
				MLGLKGAOLDL();
			}
		}
	}

	private void DGLIMBMPOFD()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 0;
			animator.SetTrigger("LoadDialogue");
		}
	}

	private bool GLNDDIJCDJJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 7)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 3f;
			}
			return false;
		}
		return true;
	}

	private void IIAGOMMJLML()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = true;
			runningAgainCount = 0;
			animator.SetTrigger("ERROR: The object ");
		}
	}

	private bool CAPMMAOHBBO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 173f;
			}
			return true;
		}
		return false;
	}

	public void PBBBJBHFGNN()
	{
		if (BGBAJKMLPGL())
		{
			DKFOJDHBGEJ();
		}
		else
		{
			NPHLLLHJOLI();
		}
	}

	private Vector3 MAIPHFHIJLF()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -110;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1317f, 1034f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1151f, 1584f)));
		}
		return Vector3.zero;
	}

	private IEnumerator ELOBGOGMBPL()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void OEDOGHAJJEO()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (KGBOKLPDOHO())
			{
				AFHBILLCDEP();
			}
			else
			{
				JIGKCIBNAAG();
			}
		}
	}

	private bool GLJACHDODOA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 2)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 317f;
			}
			return false;
		}
		return true;
	}

	private IEnumerator CIPGIDMBEHO()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NABKDALGJMM()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(ECEMGMHBDNN()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.CGEADHOLHCH("</color>", EGFGNGJGBOP: true, HALNIEBONKH: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MDOEDAKBFKO));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MDBHPDJNEPK));
			monsterNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private void GPADKOIIPKO()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (DHEMPJHFICL())
			{
				IIAGOMMJLML();
			}
			else
			{
				JIGKCIBNAAG();
			}
		}
	}

	public void JDIHPFKOAID()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount += 0;
			monsterNpc.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(EBCDENCBKLE()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.SetBool("Items/item_name_1186", EGFGNGJGBOP: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PKCODIDOBJO));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IGHOLFMIIGJ));
			monsterNpc.walkTo.EHDKLBLKBEO();
		}
	}

	public void BPFBINGLJJE()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(BOMKFPLNFKA()));
			monsterNpc.monsterAnimation.CGEADHOLHCH("BuildMode_ExitAndSave", EGFGNGJGBOP: false, HALNIEBONKH: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IEJGDOPLBLB));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KGOKBKPHIME));
			monsterNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private IEnumerator EGIHLFJDCAN()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private bool KPIFDCCMIFA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 2)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 279f;
			}
			return true;
		}
		return true;
	}

	public void PADPIEKGNMH()
	{
		if (AFDFOBIKKFK())
		{
			DODEDPJEOAM();
		}
		else
		{
			NMGADFKMNAO();
		}
	}

	private IEnumerator INCBCHJAKOC()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MDBHPDJNEPK()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (MBKBGPHBGPE())
			{
				FLPKCDGPDFE();
			}
			else
			{
				GOOAJALLPGM();
			}
		}
	}

	private bool DHEMPJHFICL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 22f;
			}
			return false;
		}
		return false;
	}

	private Vector3 OMBLJKEKMGC()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -17;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1290f, 857f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(305f, 174f)));
		}
		return Vector3.zero;
	}

	public void KPODBDODNKN()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.JJDCANFBFMK(Vector2.op_Implicit(EBCDENCBKLE()));
			monsterNpc.monsterAnimation.SetBool(" does not exist", EGFGNGJGBOP: false);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KDJAADPDCHL));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LCEAOOBGHOI));
			monsterNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private void FKJJBFBDHNL()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (BGBAJKMLPGL())
			{
				KBKMBKENPIP();
			}
			else
			{
				NMGADFKMNAO();
			}
		}
	}

	private void IGHOLFMIIGJ()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (BGBAJKMLPGL())
			{
				CBKPHHPCJNF();
			}
			else
			{
				KPODBDODNKN();
			}
		}
	}

	[CompilerGenerated]
	private void ODECGMHIPFG()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (GLNDDIJCDJJ())
			{
				DKFOJDHBGEJ();
			}
			else
			{
				FEBCKGENPKJ();
			}
		}
	}

	private bool FCGBJAEMOCH()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 1)
		{
			if (runningAgainCount >= 1)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1614f;
			}
			return false;
		}
		return false;
	}

	private Vector3 AOIMEMNBAHE()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ~(ZoneType.DiningRoom | ZoneType.MetalWorkshop);
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 75;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1261f, 1100f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1076f, 524f)));
		}
		return Vector3.zero;
	}

	private Vector3 CHFAIOEMKHB()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 34;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1906f, 1225f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1043f, 1775f)));
		}
		return Vector3.zero;
	}

	public void NPHLLLHJOLI()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(IBNMFKKOBHG()));
			monsterNpc.monsterAnimation.CGEADHOLHCH("Sell", EGFGNGJGBOP: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MDNCNKGPNKN));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PGKKKHEPLFB));
			monsterNpc.walkTo.PEHELKCIECB();
		}
	}

	private bool NBNFBHKFNOH()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 2)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 607f;
			}
			return true;
		}
		return false;
	}

	private Vector3 MGBPMJIIBKA()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 35;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(716f, 1961f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1287f, 1949f)));
		}
		return Vector3.zero;
	}

	private Vector3 NIODJCFGCDF()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -87;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(377f, 1109f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1467f, 342f)));
		}
		return Vector3.zero;
	}

	private bool NPDPFDPPKGL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 7)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1498f;
			}
			return true;
		}
		return false;
	}

	public void CLONALNHIIO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(EBCDENCBKLE()), AHDHLIECIGH: false);
			monsterNpc.monsterAnimation.CGEADHOLHCH("Dialogue System/Conversation/TavernFilthy/Entry/6/Dialogue Text", EGFGNGJGBOP: true, HALNIEBONKH: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MDNCNKGPNKN));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IGHOLFMIIGJ));
			monsterNpc.walkTo.PEHELKCIECB();
		}
	}

	private void JMJBECEGPCO()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (GLKHDOHBBGE())
			{
				KBKMBKENPIP();
			}
			else
			{
				OGKGLOMLOOG();
			}
		}
	}

	private void IKHJPAMKAPK()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (LCFDOGDDDLJ())
			{
				CBKPHHPCJNF();
			}
			else
			{
				NABKDALGJMM();
			}
		}
	}

	private void EJCDMEIMOEP()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger("Tutorial_Main_");
		}
	}

	public void EDPDFAIOHDO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount += 0;
			monsterNpc.walkTo.JJDCANFBFMK(Vector2.op_Implicit(MGBPMJIIBKA()), AHDHLIECIGH: false);
			monsterNpc.monsterAnimation.SetBool("Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text", EGFGNGJGBOP: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DJNOFCBINHM));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ADLLLEBAGPC));
			monsterNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private bool JOFEHFMKHHK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 2)
		{
			if (runningAgainCount >= 2)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1512f;
			}
			return false;
		}
		return true;
	}

	private IEnumerator BIBEPLMLLLP()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PCFJCOLGPDJ()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MBOKDLENCCN()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool KGBOKLPDOHO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 1647f;
			}
			return false;
		}
		return false;
	}

	private IEnumerator GLHIAIOHCJF()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private IEnumerator ALCHCMGDODG()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void GOOAJALLPGM()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount += 0;
			monsterNpc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(PFLKKMEPHPE()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.CGEADHOLHCH("itemRedPotato", EGFGNGJGBOP: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KDJAADPDCHL));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JMJBECEGPCO));
			monsterNpc.walkTo.EHDKLBLKBEO();
		}
	}

	public void MDOEDAKBFKO()
	{
		if (NOPEJPDOLIN())
		{
			AGBNIFNPGAP();
		}
		else
		{
			BPFBINGLJJE();
		}
	}

	public void NMGADFKMNAO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount += 0;
			monsterNpc.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(PNCCBJAOCCA()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.SetBool("hForHours", EGFGNGJGBOP: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PADPIEKGNMH));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KGOKBKPHIME));
			monsterNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private void DKFOJDHBGEJ()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("Walk");
		}
	}

	private Vector3 JGLKEFCBKNK()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.Anywhere;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 10;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(10f, 10f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(10f, 10f)));
		}
		return Vector3.zero;
	}

	private Vector3 OCJNMPDEICO()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.CraftingRoom | ZoneType.StoneWorkshop;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 36;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(380f, 1735f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1237f, 646f)));
		}
		return Vector3.zero;
	}

	public void MLGLKGAOLDL()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount++;
			monsterNpc.walkTo.HELOLJBENMK(Vector2.op_Implicit(CIPCAEMHFIC()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			monsterNpc.monsterAnimation.SetBool("Bouncer/", EGFGNGJGBOP: false);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PLKEHLOPOHN));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IKHJPAMKAPK));
			monsterNpc.walkTo.PEHELKCIECB();
		}
	}

	private void AFHBILLCDEP()
	{
		if (Object.op_Implicit((Object)(object)monsterNpc) && Object.op_Implicit((Object)(object)animator))
		{
			monsterNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger("Dialogue System/Conversation/Gass_Introduce/Entry/16/Dialogue Text");
		}
	}

	private Vector3 PFLKKMEPHPE()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 7;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(1908f, 1174f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1307f, 1905f)));
		}
		return Vector3.zero;
	}

	private Vector3 GCMFBEPHMBO()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WoodWorkshop | ZoneType.StoneWorkshop;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 79;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(296f, 318f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1338f, 117f)));
		}
		return Vector3.zero;
	}

	private Vector3 KNLOMBCMHAD()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -101;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(727f, 417f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(663f, 868f)));
		}
		return Vector3.zero;
	}

	public void GMCINBCEPJO()
	{
		if (DHEMPJHFICL())
		{
			IIAGOMMJLML();
		}
		else
		{
			CLONALNHIIO();
		}
	}

	private void FNCPLFBKCGK()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (HNOMFAHMINJ())
			{
				DGLIMBMPOFD();
			}
			else
			{
				JIGKCIBNAAG();
			}
		}
	}

	private bool NOPEJPDOLIN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 647f;
			}
			return true;
		}
		return false;
	}

	private IEnumerator MKICAMMLHHB()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BHELEAIBPAH()
	{
		if (FCGBJAEMOCH())
		{
			CFJOGFDANJH();
		}
		else
		{
			JDIHPFKOAID();
		}
	}

	private void PADHCINNALK()
	{
		if (!((Object)(object)monsterNpc == (Object)null))
		{
			if (CEJLPCCNKDP())
			{
				AFHBILLCDEP();
			}
			else
			{
				JIGKCIBNAAG();
			}
		}
	}

	private Vector3 BGCOLMBCPLB()
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -119;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)monsterNpc).transform.position), new Vector2(220f, 676f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(monsterNpc.playerHit)).transform.position)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1472f, 244f)));
		}
		return Vector3.zero;
	}

	private IEnumerator NBGCNLMOCGE()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		monsterNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void GBDIPMDDOHJ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)monsterNpc != (Object)null)
		{
			runningAgainCount += 0;
			monsterNpc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(MAIPHFHIJLF()), AHDHLIECIGH: false);
			monsterNpc.monsterAnimation.SetBool("Drink", EGFGNGJGBOP: false, HALNIEBONKH: true);
			monsterNpc.rb.velocity = Vector2.zero;
			monsterNpc.walkTo.speed = monsterNpc.runSpeed;
			monsterNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = monsterNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PBBBJBHFGNN));
			NPCWalkTo walkTo2 = monsterNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FKJJBFBDHNL));
			monsterNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private bool LNHBNJMMBIL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 4)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(monsterNpc.playerHit)).transform.position), Vector2.op_Implicit(((Component)monsterNpc).transform.position)) > 978f;
			}
			return false;
		}
		return true;
	}

	public void KNNALICIDEN()
	{
		if (EFMDCOMADEM())
		{
			CBKPHHPCJNF();
		}
		else
		{
			MLGLKGAOLDL();
		}
	}

	private IEnumerator GHLOKHMIHEH()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}
}
