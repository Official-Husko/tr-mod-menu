using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CrabRunAroundState : CrabStateBase
{
	[CompilerGenerated]
	private sealed class KOEKJBLPDAO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrabRunAroundState _003C_003E4__this;

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
			CrabRunAroundState crabRunAroundState = _003C_003E4__this;
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
				crabRunAroundState.delayFirstWalkCoroutine = null;
				crabRunAroundState.crabNpc.hitCollider.SetActive(false);
				crabRunAroundState.FEBCKGENPKJ();
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

	private static List<Vector2> validPositions = new List<Vector2>();

	public override void OnStateUpdate(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateUpdate(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (runningAgainCount < 3 && crabNpc.walkTo.isActive && !crabNpc.walkTo.complete && Time.time > timeBetweenPlayerIsClose && Vector2.Distance(crabNpc.walkTo.target, Vector2.op_Implicit(((Component)crabNpc).transform.position)) > Vector2.Distance(crabNpc.walkTo.target, Vector2.op_Implicit(crabNpc.hitPosition)))
		{
			timeBetweenPlayerIsClose = Time.time + 2f;
			crabNpc.walkTo.isActive = false;
			FEBCKGENPKJ();
		}
	}

	private void DCCPEMHLKOO()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (BDDDCKEICMO())
			{
				DKFOJDHBGEJ();
			}
			else
			{
				PLLCGNGDDLE();
			}
		}
	}

	public void KHIIPJLKOKM()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(KIBPPJIECBJ()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			crabNpc.crabAnimation.CGEADHOLHCH("Roll", EGFGNGJGBOP: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.SendBool(DMBFKFLDDLH: true);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MMPGIKGMFMA));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DJPMDDDGPDA));
			crabNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private void DKFOJDHBGEJ()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("Walk");
		}
	}

	public void MCCINFMLIIJ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(BEEOGHFOPBI()));
			crabNpc.crabAnimation.CGEADHOLHCH("Trying to add a player that's already on the list.", EGFGNGJGBOP: true, HALNIEBONKH: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.GMJDHEANFGH(DMBFKFLDDLH: false);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PPEJPHOAIKD));
			crabNpc.walkTo.NOFKEMGPFEO();
		}
	}

	public void CNJOADLENGP()
	{
		if (HGMLCPFBBMG())
		{
			JLAHJOOAKID();
		}
		else
		{
			NFADIDBOFMC();
		}
	}

	private IEnumerator GLHIAIOHCJF()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		crabNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void PGFCHKPLIHD()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("LicenciaDeApertura/TheloniousDialogue 01");
		}
	}

	private Vector3 BEEOGHFOPBI()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 54;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1685f, 270f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1799f, 62f)));
		}
		return Vector3.zero;
	}

	private Vector3 BDDOMAFNMGP()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 106;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1078f, 1611f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(433f, 625f)));
		}
		return Vector3.zero;
	}

	private void HBPMPEOCILP()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (KMFEKHNDAFP())
			{
				DENDCNIEANE();
			}
			else
			{
				EBKELGLKDBH();
			}
		}
	}

	private void CNLGNBOHFLJ()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (DNJMPIKBALE())
			{
				DENDCNIEANE();
			}
			else
			{
				PLLCGNGDDLE();
			}
		}
	}

	public void EBKELGLKDBH()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)crabNpc != (Object)null))
		{
			return;
		}
		runningAgainCount++;
		crabNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(KDFBJLEIGGK()), AHDHLIECIGH: false);
		crabNpc.crabAnimation.SetBool("ReceiveSpadeActionMaster", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			crabNpc.onlineTurkey.EMEJJDCGOPF(DMBFKFLDDLH: true);
		}
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.speed = crabNpc.runSpeed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (!((Object)(object)crabNpc == (Object)null))
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
		crabNpc.walkTo.NOFKEMGPFEO();
	}

	public void NFADIDBOFMC()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount += 0;
			crabNpc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(KBBJHHILGEJ()), AHDHLIECIGH: false);
			crabNpc.crabAnimation.SetBool("Trying to set a player's steam name but they're not playing on a steam platform", EGFGNGJGBOP: false, HALNIEBONKH: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.MCHIMNKHDME(DMBFKFLDDLH: false);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ABMMONFHFGF));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BJCOIEEKAIH));
			crabNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private bool GLNDDIJCDJJ()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 7)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 3f;
			}
			return false;
		}
		return true;
	}

	private Vector3 JGLKEFCBKNK()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 10;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(20f, 20f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(20f, 20f)));
		}
		return Vector3.zero;
	}

	private IEnumerator EOADPENNPNE()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool HNOMFAHMINJ()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 0)
		{
			if (runningAgainCount >= 4)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 622f;
			}
			return true;
		}
		return true;
	}

	private bool HGMLCPFBBMG()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 3)
		{
			if (runningAgainCount >= 1)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 1207f;
			}
			return false;
		}
		return false;
	}

	public void JPAPOBCAMAB()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.KBEENHPEOAB(Vector2.op_Implicit(FMPNEELPDPI()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			crabNpc.crabAnimation.CGEADHOLHCH("", EGFGNGJGBOP: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.SendBool(DMBFKFLDDLH: true);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MAILEMECPME));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CNLGNBOHFLJ));
			crabNpc.walkTo.PEHELKCIECB();
		}
	}

	private Vector3 KBBJHHILGEJ()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -23;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1747f, 94f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1430f, 1953f)));
		}
		return Vector3.zero;
	}

	private void DGBNDKKBFLM()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (HGMLCPFBBMG())
			{
				DKFOJDHBGEJ();
			}
			else
			{
				CIKBLGGBHOF();
			}
		}
	}

	private void BJCOIEEKAIH()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (COJEALHIHNI())
			{
				IGDKBGMCIOE();
			}
			else
			{
				MCCINFMLIIJ();
			}
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (delayFirstWalkCoroutine != null)
		{
			((MonoBehaviour)crabNpc).StopCoroutine(delayFirstWalkCoroutine);
		}
		delayFirstWalkCoroutine = null;
	}

	private bool DNJMPIKBALE()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 7)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 1470f;
			}
			return false;
		}
		return false;
	}

	public void FEBCKGENPKJ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)crabNpc != (Object)null))
		{
			return;
		}
		runningAgainCount++;
		crabNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(JGLKEFCBKNK()));
		crabNpc.crabAnimation.SetBool("Hurt", EGFGNGJGBOP: false);
		if (OnlineManager.PlayingOnline())
		{
			crabNpc.onlineTurkey.SendBool(DMBFKFLDDLH: false);
		}
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.speed = crabNpc.runSpeed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (!((Object)(object)crabNpc == (Object)null))
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
		crabNpc.walkTo.PEHELKCIECB();
	}

	private Vector3 PJBIONIMEAA()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 31;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1239f, 1771f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(289f, 1767f)));
		}
		return Vector3.zero;
	}

	private bool KPIFDCCMIFA()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 754f;
			}
			return true;
		}
		return true;
	}

	private bool FHNCPDAPGGD()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 1618f;
			}
			return true;
		}
		return false;
	}

	private IEnumerator HJIFADLEMPO()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		crabNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void DELIGODFEIC()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (FHNCPDAPGGD())
			{
				IGDKBGMCIOE();
			}
			else
			{
				CIKBLGGBHOF();
			}
		}
	}

	private Vector3 IBHDEIFDKMJ()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -45;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(560f, 824f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1719f, 875f)));
		}
		return Vector3.zero;
	}

	public void APGLLOHDPHO()
	{
		if (LBALDBOAJLI())
		{
			IDDFGPFEODI();
		}
		else
		{
			JPAPOBCAMAB();
		}
	}

	public void MAILEMECPME()
	{
		if (DNJMPIKBALE())
		{
			DKFOJDHBGEJ();
		}
		else
		{
			KHIIPJLKOKM();
		}
	}

	private void IGDKBGMCIOE()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger("BuzzBuildExit");
		}
	}

	public override void ACBBHJIMGCC()
	{
		crabNpc.walkTo.IIMEFNIECLI();
	}

	private void MFELPPLNNIN()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("PlayerDisconnected_F");
		}
	}

	private bool EFCCOLFENLL()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 1761f;
			}
			return true;
		}
		return true;
	}

	private void DJPMDDDGPDA()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (DJBLDEJHMMD())
			{
				DKFOJDHBGEJ();
			}
			else
			{
				LNFPJJMHBJL();
			}
		}
	}

	private Vector3 KIBPPJIECBJ()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 27;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1196f, 1476f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(911f, 455f)));
		}
		return Vector3.zero;
	}

	private IEnumerator NLFAAFNMLOG()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OPENBHFNDJN()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private Vector3 OMNNMKDHIEE()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 118;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(120f, 114f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(301f, 830f)));
		}
		return Vector3.zero;
	}

	public void ALDAHNKKOGE()
	{
		if (KPIFDCCMIFA())
		{
			MFELPPLNNIN();
		}
		else
		{
			CIKBLGGBHOF();
		}
	}

	private IEnumerator PCFJCOLGPDJ()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		crabNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private bool DJBLDEJHMMD()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 8)
		{
			if (runningAgainCount >= 1)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 567f;
			}
			return false;
		}
		return false;
	}

	private bool BDDDCKEICMO()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 4)
		{
			if (runningAgainCount >= 0)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 1116f;
			}
			return true;
		}
		return true;
	}

	private IEnumerator LBBLJLKHLAK()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		crabNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private IEnumerator JBCAGNFMKFO()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		crabNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void POOOAENOFPD()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.JJDCANFBFMK(Vector2.op_Implicit(KIBPPJIECBJ()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			crabNpc.crabAnimation.CGEADHOLHCH("City/Rhia/Introduce", EGFGNGJGBOP: false, HALNIEBONKH: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.MICLDCIGCCE(DMBFKFLDDLH: false);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MAILEMECPME));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DGBNDKKBFLM));
			crabNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private void AJMCOBABGBO()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (HGMLCPFBBMG())
			{
				IGDKBGMCIOE();
			}
			else
			{
				BHLBEHDEIOO();
			}
		}
	}

	private void JPHEJHOJBNN()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (LBALDBOAJLI())
			{
				IDDFGPFEODI();
			}
			else
			{
				PLLCGNGDDLE();
			}
		}
	}

	public void PKCKLIPCCAL()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(PJBIONIMEAA()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			crabNpc.crabAnimation.SetBool("Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.NNOLGPDBFML(DMBFKFLDDLH: false);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(HBPMPEOCILP));
			crabNpc.walkTo.NOFKEMGPFEO();
		}
	}

	public void LNFPJJMHBJL()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount += 0;
			crabNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(IHNKBKICGDC()));
			crabNpc.crabAnimation.CGEADHOLHCH("Prices", EGFGNGJGBOP: false, HALNIEBONKH: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.GMJDHEANFGH(DMBFKFLDDLH: true);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ALDAHNKKOGE));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BJCOIEEKAIH));
			crabNpc.walkTo.NOFKEMGPFEO();
		}
	}

	public void ABMMONFHFGF()
	{
		if (HNOMFAHMINJ())
		{
			DENDCNIEANE();
		}
		else
		{
			POOOAENOFPD();
		}
	}

	private void AEKLEAFBAKK()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (FHNCPDAPGGD())
			{
				JLAHJOOAKID();
			}
			else
			{
				PKCKLIPCCAL();
			}
		}
	}

	private Vector3 FMPNEELPDPI()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 61;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1689f, 822f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1316f, 1819f)));
		}
		return Vector3.zero;
	}

	private Vector3 EKGKKKFOOFI()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 20;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(741f, 352f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1164f, 118f)));
		}
		return Vector3.zero;
	}

	private IEnumerator JDMDGIGNODP()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private Vector3 KDFBJLEIGGK()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 21;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(465f, 557f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(222f, 978f)));
		}
		return Vector3.zero;
	}

	private void IDDFGPFEODI()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger("Zones");
		}
	}

	private bool KMFEKHNDAFP()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 2)
		{
			if (runningAgainCount >= 5)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 1168f;
			}
			return false;
		}
		return true;
	}

	private bool LBALDBOAJLI()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 2)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 1027f;
			}
			return true;
		}
		return false;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		runningAgainCount = 0;
		timeBetweenPlayerIsClose = Time.time + 2f;
		if (delayFirstWalkCoroutine != null)
		{
			((MonoBehaviour)crabNpc).StopCoroutine(delayFirstWalkCoroutine);
		}
		delayFirstWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JBCAGNFMKFO());
	}

	private Vector3 COLAGABLJFE()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -41;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1151f, 98f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(113f, 458f)));
		}
		return Vector3.zero;
	}

	[CompilerGenerated]
	private void ODECGMHIPFG()
	{
		if (!((Object)(object)crabNpc == (Object)null))
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

	private bool MFNBKFJABEP()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 0)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 321f;
			}
			return true;
		}
		return false;
	}

	private bool COJEALHIHNI()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 3)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(crabNpc.hitPosition), Vector2.op_Implicit(((Component)crabNpc).transform.position)) > 381f;
			}
			return false;
		}
		return false;
	}

	private void DENDCNIEANE()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger("Sleep");
		}
	}

	private Vector3 BAILNODIKPF()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -106;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1224f, 1187f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(109f, 1064f)));
		}
		return Vector3.zero;
	}

	public void CIKBLGGBHOF()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount += 0;
			crabNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(COLAGABLJFE()));
			crabNpc.crabAnimation.CGEADHOLHCH(" ", EGFGNGJGBOP: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.IPBBGJHIAAE(DMBFKFLDDLH: true);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ALDAHNKKOGE));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DCCPEMHLKOO));
			crabNpc.walkTo.EHDKLBLKBEO();
		}
	}

	public void PLLCGNGDDLE()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(BAILNODIKPF()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			crabNpc.crabAnimation.SetBool("Direction", EGFGNGJGBOP: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.IPBBGJHIAAE(DMBFKFLDDLH: true);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MMPGIKGMFMA));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CNLGNBOHFLJ));
			crabNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private IEnumerator DFLBLOHOCIA()
	{
		return new KOEKJBLPDAO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JLAHJOOAKID()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("</color>");
		}
	}

	public void MMPGIKGMFMA()
	{
		if (BDDDCKEICMO())
		{
			PGFCHKPLIHD();
		}
		else
		{
			LNFPJJMHBJL();
		}
	}

	private Vector3 IHNKBKICGDC()
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -100;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)crabNpc).transform.position), new Vector2(1869f, 1924f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)crabNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(crabNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1677f, 926f)));
		}
		return Vector3.zero;
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

	private IEnumerator BPAJALLHGLB()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		crabNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void BMFECDGJCKE()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)crabNpc != (Object)null))
		{
			return;
		}
		runningAgainCount += 0;
		crabNpc.walkTo.HELOLJBENMK(Vector2.op_Implicit(BAILNODIKPF()));
		crabNpc.crabAnimation.CGEADHOLHCH("Dialogue System/Conversation/Crowly_Standar/Entry/30/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline())
		{
			crabNpc.onlineTurkey.SendBool(DMBFKFLDDLH: true);
		}
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.speed = crabNpc.runSpeed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ALDAHNKKOGE));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (!((Object)(object)crabNpc == (Object)null))
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
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	private void NELKIIMEHBC()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = true;
			runningAgainCount = 0;
			animator.SetTrigger("Requirements not met");
		}
	}

	public void BHLBEHDEIOO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(IHNKBKICGDC()), AHDHLIECIGH: false);
			crabNpc.crabAnimation.CGEADHOLHCH("tutorialPopUp82", EGFGNGJGBOP: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.EMEJJDCGOPF(DMBFKFLDDLH: false);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MMPGIKGMFMA));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JPHEJHOJBNN));
			crabNpc.walkTo.PEHELKCIECB();
		}
	}

	private void PPEJPHOAIKD()
	{
		if (!((Object)(object)crabNpc == (Object)null))
		{
			if (DNJMPIKBALE())
			{
				IGDKBGMCIOE();
			}
			else
			{
				JPAPOBCAMAB();
			}
		}
	}

	private void DKCIPEBOEMJ()
	{
		if (Object.op_Implicit((Object)(object)crabNpc) && Object.op_Implicit((Object)(object)animator))
		{
			crabNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("CultivableDuringOneMonth");
		}
	}

	public void PICEEMDAHNE()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)crabNpc != (Object)null)
		{
			runningAgainCount++;
			crabNpc.walkTo.JDHMPOJKOLF(Vector2.op_Implicit(KIBPPJIECBJ()), AHDHLIECIGH: false);
			crabNpc.crabAnimation.SetBool("Struggle", EGFGNGJGBOP: true);
			if (OnlineManager.PlayingOnline())
			{
				crabNpc.onlineTurkey.SendBool(DMBFKFLDDLH: false);
			}
			crabNpc.rb.velocity = Vector2.zero;
			crabNpc.walkTo.speed = crabNpc.runSpeed;
			crabNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = crabNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ALDAHNKKOGE));
			NPCWalkTo walkTo2 = crabNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DGBNDKKBFLM));
			crabNpc.walkTo.PEHELKCIECB();
		}
	}
}
