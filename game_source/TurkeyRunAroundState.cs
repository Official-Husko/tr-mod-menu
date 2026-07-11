using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TurkeyRunAroundState : TurkeyStateBase
{
	[CompilerGenerated]
	private sealed class BMHPIJHLCEF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurkeyRunAroundState _003C_003E4__this;

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
		public BMHPIJHLCEF(int _003C_003E1__state)
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
			TurkeyRunAroundState turkeyRunAroundState = _003C_003E4__this;
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
				turkeyRunAroundState.delayFirstWalkCoroutine = null;
				turkeyRunAroundState.turkeyNpc.hitCollider.SetActive(false);
				turkeyRunAroundState.FEBCKGENPKJ();
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

	private bool walkingDone;

	private int runningAgainCount;

	private float timeBetweenPlayerIsClose;

	private Coroutine delayFirstWalkCoroutine;

	private List<Vector2> validPositions = new List<Vector2>();

	private void EIJGFNNIOBN()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (DOJLLOMBDLK())
			{
				CBKPHHPCJNF();
			}
			else
			{
				CBJLABJEILL();
			}
		}
	}

	public void GEAKPMEBBAI()
	{
		walkingDone = false;
		if (AGOKOEKINHB())
		{
			DKFOJDHBGEJ();
		}
		else
		{
			ELBKDLCHPFP();
		}
	}

	public void FGBHCDMMNLL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(JGLKEFCBKNK()));
			turkeyNpc.turkeyAnimation.CGEADHOLHCH(" ", EGFGNGJGBOP: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GEAKPMEBBAI));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LGDLDAJIAGG));
			turkeyNpc.walkTo.PEHELKCIECB();
		}
	}

	private void FLPKCDGPDFE()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("Wed");
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		walkingDone = false;
		runningAgainCount = 0;
		timeBetweenPlayerIsClose = Time.fixedTime + 2f;
		if (delayFirstWalkCoroutine != null)
		{
			((MonoBehaviour)turkeyNpc).StopCoroutine(delayFirstWalkCoroutine);
		}
		delayFirstWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(HDFABCEGPEB());
	}

	private bool OHPMCCBDKOI()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 1843f;
			}
			return false;
		}
		return true;
	}

	private bool PCKIAMNJOOP()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 1)
		{
			if (runningAgainCount >= 3)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 685f;
			}
			return false;
		}
		return true;
	}

	public void FOEBEJHKEKE()
	{
		walkingDone = false;
		if (AOEDBGFLLIO())
		{
			MOGCENECLIG();
		}
		else
		{
			FEBCKGENPKJ();
		}
	}

	private Vector3 KMHOGDPILAF()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 32;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1575f, 800f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(233f, 791f)));
		}
		return Vector3.zero;
	}

	private void LPNPJIPAALL()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (HGMLCPFBBMG())
			{
				MAGDABOLFDI();
			}
			else
			{
				NMGADFKMNAO();
			}
		}
	}

	private Vector3 JNODCGFKHCP()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -99;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(869f, 560f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1641f, 1418f)));
		}
		return Vector3.zero;
	}

	private void GDNGOFCCDEG()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (OHPMCCBDKOI())
			{
				MAGDABOLFDI();
			}
			else
			{
				OBMFCPMFECG();
			}
		}
	}

	public void FFBCNOIAOGO()
	{
		walkingDone = false;
		if (NOPEJPDOLIN())
		{
			DKFOJDHBGEJ();
		}
		else
		{
			PJFEFLDGEOI();
		}
	}

	private void DEEIFGLNMLP()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (IGPKFOFNMPM())
			{
				DNIPBIPJKLJ();
			}
			else
			{
				BLHEKDCEDHN();
			}
		}
	}

	private void FICLGDADLPC()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("PlayerJoined_F");
		}
	}

	public void FMONIDGJANG()
	{
		walkingDone = true;
		if (BBHOGECENBG())
		{
			MAGDABOLFDI();
		}
		else
		{
			ELBKDLCHPFP();
		}
	}

	private IEnumerator PLFIMLFDEDI()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private bool PEHIHJDLHLG()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 559f;
			}
			return false;
		}
		return false;
	}

	private Vector3 BAILNODIKPF()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -27;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(319f, 6f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(382f, 178f)));
		}
		return Vector3.zero;
	}

	private void BOPKHICDNDN()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (LGEGLIDLEKG())
			{
				FLPKCDGPDFE();
			}
			else
			{
				FGBHCDMMNLL();
			}
		}
	}

	private Vector3 KDLDLLBPGKK()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 35;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1104f, 1576f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(865f, 913f)));
		}
		return Vector3.zero;
	}

	private bool JFKLNADKKHN()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 8)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 1107f;
			}
			return true;
		}
		return false;
	}

	private bool KNJGCKDGGOO()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 8)
		{
			if (runningAgainCount >= 7)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 210f;
			}
			return false;
		}
		return false;
	}

	private void KDGAMOHKDEK()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (KNJGCKDGGOO())
			{
				FFAGAMOLPPC();
			}
			else
			{
				HNIKBNBHMAN();
			}
		}
	}

	private IEnumerator IFGEEIEECAH()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private IEnumerator ACDMPDNHFGB()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private Vector3 CKGPKGFIMFN()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 2;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1856f, 305f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(706f, 51f)));
		}
		return Vector3.zero;
	}

	private IEnumerator IDHLDJEHLPH()
	{
		return new BMHPIJHLCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LGDLDAJIAGG()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (JFKLNADKKHN())
			{
				LNPDDCNHFMG();
			}
			else
			{
				KPEMDKAOANI();
			}
		}
	}

	private IEnumerator OEFNLAODJAN()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void HAMNLIFECJM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.BDIKOLNFKGD(Vector2.op_Implicit(MBGCGKIBBLB()), AHDHLIECIGH: false);
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("", EGFGNGJGBOP: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GEAKPMEBBAI));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EIJGFNNIOBN));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	public void NMGADFKMNAO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount++;
			walkingDone = true;
			turkeyNpc.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(AGINCIJBCBJ()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.SetBool("Dialogue System/Conversation/Gass_Introduce/Entry/10/Dialogue Text", EGFGNGJGBOP: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FOEBEJHKEKE));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DEEIFGLNMLP));
			turkeyNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private void LNPDDCNHFMG()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("qualityWater");
		}
	}

	public void ELBKDLCHPFP()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = true;
			turkeyNpc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(KMHOGDPILAF()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.SetBool("add item ", EGFGNGJGBOP: false, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GEAKPMEBBAI));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(MMHHDMMLDIN));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	public void CBJLABJEILL()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(EELCJJEJBKL()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("Build mode active", EGFGNGJGBOP: false, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MKJDIMFOGIA));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AOBEPCDGKAF));
			turkeyNpc.walkTo.PEHELKCIECB();
		}
	}

	public void FEABMPCBCGO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(MBGCGKIBBLB()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.SetBool("Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FOEBEJHKEKE));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EEOMBEMDIBE));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private Vector3 MBGCGKIBBLB()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 109;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1992f, 1810f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[1]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(148f, 270f)));
		}
		return Vector3.zero;
	}

	private IEnumerator IMPHJIMLAGD()
	{
		return new BMHPIJHLCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private Vector3 KBBJHHILGEJ()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = 120;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = true;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(482f, 127f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(892f, 478f)));
		}
		return Vector3.zero;
	}

	private bool IGPKFOFNMPM()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 1)
		{
			if (runningAgainCount >= 4)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 444f;
			}
			return false;
		}
		return false;
	}

	private IEnumerator PMKBMJLEFKF()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void NIAOCKALMHH()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("force intro");
		}
	}

	public void CAELADBMLFL()
	{
		walkingDone = false;
		if (BBHOGECENBG())
		{
			LNPDDCNHFMG();
		}
		else
		{
			BFEEOOADGBO();
		}
	}

	public void BEEDFJOOPAH()
	{
		walkingDone = false;
		if (GLJACHDODOA())
		{
			MOGCENECLIG();
		}
		else
		{
			HAMNLIFECJM();
		}
	}

	private void PDLDNJNEMAF()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (PEHIHJDLHLG())
			{
				DKFOJDHBGEJ();
			}
			else
			{
				ELBKDLCHPFP();
			}
		}
	}

	private IEnumerator KLPGBMBAECE()
	{
		return new BMHPIJHLCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AOLEDENFMOJ()
	{
		walkingDone = true;
		if (HGMLCPFBBMG())
		{
			FIMIBFLFOGE();
		}
		else
		{
			MJNLKJFHMGK();
		}
	}

	public void BFEEOOADGBO()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount++;
			walkingDone = false;
			turkeyNpc.walkTo.DBHOIIIHIIM(Vector2.op_Implicit(JGLKEFCBKNK()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.SetBool("Need to learn previous XP increase!", EGFGNGJGBOP: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KNIBOAEFGPJ));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DEEIFGLNMLP));
			turkeyNpc.walkTo.PEHELKCIECB();
		}
	}

	private IEnumerator MAKELABBCAA()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private IEnumerator DMLGBOGFBDH()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private void FOBOCHCBJPP()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (PEHIHJDLHLG())
			{
				MOGCENECLIG();
			}
			else
			{
				ELBKDLCHPFP();
			}
		}
	}

	private void IFPOFFPFFOA()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (PCKIAMNJOOP())
			{
				FICLGDADLPC();
			}
			else
			{
				BMFECDGJCKE();
			}
		}
	}

	public void HNIKBNBHMAN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(AGINCIJBCBJ()));
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("Turn Off", EGFGNGJGBOP: false, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EEOMBEMDIBE));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private void IKDDFHOHHHM()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (KNJGCKDGGOO())
			{
				FIMIBFLFOGE();
			}
			else
			{
				BMFECDGJCKE();
			}
		}
	}

	private bool NOPEJPDOLIN()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 4)
		{
			if (runningAgainCount >= 7)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 740f;
			}
			return true;
		}
		return true;
	}

	private void MOGCENECLIG()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("Seat without table (sendOnline -> ");
		}
	}

	public void FEBCKGENPKJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)turkeyNpc != (Object)null))
		{
			return;
		}
		runningAgainCount++;
		walkingDone = false;
		turkeyNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(JGLKEFCBKNK()));
		turkeyNpc.turkeyAnimation.SetBool("Run", EGFGNGJGBOP: true);
		turkeyNpc.rb.velocity = Vector2.zero;
		turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
		turkeyNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = turkeyNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = turkeyNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (!((Object)(object)turkeyNpc == (Object)null))
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
		turkeyNpc.walkTo.PEHELKCIECB();
	}

	private Vector3 AGINCIJBCBJ()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -48;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1595f, 1423f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(430f, 929f)));
		}
		return Vector3.zero;
	}

	public void BMFECDGJCKE()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.HELOLJBENMK(Vector2.op_Implicit(JNODCGFKHCP()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("", EGFGNGJGBOP: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KNIBOAEFGPJ));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IFPOFFPFFOA));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	[CompilerGenerated]
	private void LEFJEHLJPPP()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
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

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if (delayFirstWalkCoroutine != null)
		{
			((MonoBehaviour)turkeyNpc).StopCoroutine(delayFirstWalkCoroutine);
		}
		delayFirstWalkCoroutine = null;
		turkeyNpc.turkeyAnimation.SetBool("Run", EGFGNGJGBOP: false);
	}

	private IEnumerator KNFIGOKBJNL()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void NMNFMFCOCGP()
	{
		walkingDone = true;
		if (PEHIHJDLHLG())
		{
			FFAGAMOLPPC();
		}
		else
		{
			KPEMDKAOANI();
		}
	}

	private bool BBHOGECENBG()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 7)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 1187f;
			}
			return true;
		}
		return false;
	}

	private void CBKPHHPCJNF()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("Game");
		}
	}

	public void KCINDOCIKAI()
	{
		walkingDone = true;
		if (AOEDBGFLLIO())
		{
			FLPKCDGPDFE();
		}
		else
		{
			FEBCKGENPKJ();
		}
	}

	private void MAGDABOLFDI()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("UIAddRemove");
		}
	}

	public void NFADIDBOFMC()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = true;
			turkeyNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(JNODCGFKHCP()));
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("Sound", EGFGNGJGBOP: false, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CAELADBMLFL));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IFPOFFPFFOA));
			turkeyNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private IEnumerator HDFABCEGPEB()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private Vector3 IKIHMHDLKNB()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.None;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -93;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1985f, 1368f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 1; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = true;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1010f, 1458f)));
		}
		return Vector3.zero;
	}

	private IEnumerator EFCLIJDBDKE()
	{
		return new BMHPIJHLCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GMAHMPCJGFN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.GHDMBFOAAHK(Vector2.op_Implicit(BAILNODIKPF()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.SetBool("ObjectMove", EGFGNGJGBOP: false);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FMONIDGJANG));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EIJGFNNIOBN));
			turkeyNpc.walkTo.PEHELKCIECB();
		}
	}

	public void EIAMODMOLIL()
	{
		walkingDone = true;
		if (PEHIHJDLHLG())
		{
			FLPKCDGPDFE();
		}
		else
		{
			FEABMPCBCGO();
		}
	}

	private Vector3 EELCJJEJBKL()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = -16;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1995f, 1879f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(378f, 1400f)));
		}
		return Vector3.zero;
	}

	private IEnumerator GINKADPJAFF()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public override void EHBJGKOOOFF()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		turkeyNpc.walkTo.IIMEFNIECLI();
		if (runningAgainCount < 3 && turkeyNpc.walkTo.isActive && !walkingDone && Time.fixedTime > timeBetweenPlayerIsClose && Vector2.Distance(turkeyNpc.walkTo.target, Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > Vector2.Distance(turkeyNpc.walkTo.target, Vector2.op_Implicit(turkeyNpc.hitPosition)))
		{
			timeBetweenPlayerIsClose = Time.fixedTime + 2f;
			turkeyNpc.walkTo.isActive = false;
			FEBCKGENPKJ();
		}
	}

	private IEnumerator OJNPHIIIGMO()
	{
		return new BMHPIJHLCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PDOBHPLPKHG()
	{
		walkingDone = true;
		if (GLNDDIJCDJJ())
		{
			DKFOJDHBGEJ();
		}
		else
		{
			FEBCKGENPKJ();
		}
	}

	private bool GLJACHDODOA()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 2)
		{
			if (runningAgainCount >= 1)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 1815f;
			}
			return false;
		}
		return true;
	}

	public void OBMFCPMFECG()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount++;
			walkingDone = false;
			turkeyNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(AGINCIJBCBJ()), AHDHLIECIGH: false, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.CGEADHOLHCH(" // Replaced for ", EGFGNGJGBOP: false);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FOEBEJHKEKE));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FOBOCHCBJPP));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private IEnumerator PDJCFJHGKOC()
	{
		return new BMHPIJHLCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AHGPPHKBONN()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void EBKELGLKDBH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(KDLDLLBPGKK()));
			turkeyNpc.turkeyAnimation.SetBool("Sending upgrade tool RPC for toolID: ", EGFGNGJGBOP: false);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(AOLEDENFMOJ));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LHLBGLMBJGJ));
			turkeyNpc.walkTo.PEHELKCIECB();
		}
	}

	private void AMIAGLLJELM()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("ReceiveRecord");
		}
	}

	public void BBHODALHMAD()
	{
		walkingDone = false;
		if (GLNDDIJCDJJ())
		{
			CHJOPGFLEGM();
		}
		else
		{
			GNEEBFMCPOH();
		}
	}

	public void COACMHKHDBL()
	{
		walkingDone = false;
		if (KNJGCKDGGOO())
		{
			LNPDDCNHFMG();
		}
		else
		{
			CBJLABJEILL();
		}
	}

	public void BLHEKDCEDHN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.JJDCANFBFMK(Vector2.op_Implicit(BAILNODIKPF()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.SetBool("ReceiveKick", EGFGNGJGBOP: false, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FOEBEJHKEKE));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OAKCCCHPNCJ));
			turkeyNpc.walkTo.EHDKLBLKBEO();
		}
	}

	public void MKJDIMFOGIA()
	{
		walkingDone = true;
		if (BBHOGECENBG())
		{
			FLPKCDGPDFE();
		}
		else
		{
			HNIKBNBHMAN();
		}
	}

	private Vector3 NJJOPKOMJBD()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = false;
			bBJDPIJPLPA.minDistance = -77;
			bBJDPIJPLPA.checkNodeFree = false;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = true;
			bBJDPIJPLPA.avoidPath = false;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(1929f, 1549f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i += 0)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1741f, 763f)));
		}
		return Vector3.zero;
	}

	private void FIMIBFLFOGE()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 0;
			animator.SetTrigger("Item in hole: ");
		}
	}

	private IEnumerator ILNJCJKKGHK()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void PKKNFNMFOON()
	{
		walkingDone = false;
		if (KNJGCKDGGOO())
		{
			GCPKCLJCDJF();
		}
		else
		{
			HNIKBNBHMAN();
		}
	}

	private void DKFOJDHBGEJ()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = false;
			runningAgainCount = 0;
			animator.SetTrigger("Walk");
		}
	}

	private void AOBEPCDGKAF()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (IGPKFOFNMPM())
			{
				MAGDABOLFDI();
			}
			else
			{
				BLHEKDCEDHN();
			}
		}
	}

	private void CHJOPGFLEGM()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("F2");
		}
	}

	private void MMHHDMMLDIN()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (DOJLLOMBDLK())
			{
				GCPKCLJCDJF();
			}
			else
			{
				FEABMPCBCGO();
			}
		}
	}

	private IEnumerator HCDKEFODAOE()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private bool LGEGLIDLEKG()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 6)
		{
			if (runningAgainCount >= 6)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 25f;
			}
			return false;
		}
		return true;
	}

	private bool AOEDBGFLLIO()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 1)
		{
			if (runningAgainCount >= 4)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 1111f;
			}
			return false;
		}
		return true;
	}

	private void OAKCCCHPNCJ()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (IGPKFOFNMPM())
			{
				DKFOJDHBGEJ();
			}
			else
			{
				MJNLKJFHMGK();
			}
		}
	}

	public void PJFEFLDGEOI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.DHFPOCOEONG(Vector2.op_Implicit(EELCJJEJBKL()));
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("Sprint time", EGFGNGJGBOP: false, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(COACMHKHDBL));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KDGAMOHKDEK));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	public void HMOPLHDOPKK()
	{
		walkingDone = false;
		if (GLJACHDODOA())
		{
			AMIAGLLJELM();
		}
		else
		{
			BLHEKDCEDHN();
		}
	}

	public void MJNLKJFHMGK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)turkeyNpc != (Object)null))
		{
			return;
		}
		runningAgainCount += 0;
		walkingDone = true;
		turkeyNpc.walkTo.EJPGFOEDPBG(Vector2.op_Implicit(JNODCGFKHCP()));
		turkeyNpc.turkeyAnimation.CGEADHOLHCH(" ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		turkeyNpc.rb.velocity = Vector2.zero;
		turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
		turkeyNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = turkeyNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BBHODALHMAD));
		NPCWalkTo walkTo2 = turkeyNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, (Action)delegate
		{
			if (!((Object)(object)turkeyNpc == (Object)null))
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
		turkeyNpc.walkTo.NOFKEMGPFEO();
	}

	private void ODDGCOCNMNK()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (IGPKFOFNMPM())
			{
				AMIAGLLJELM();
			}
			else
			{
				GMAHMPCJGFN();
			}
		}
	}

	public void GNEEBFMCPOH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = true;
			turkeyNpc.walkTo.GDGGABHLNOH(Vector2.op_Implicit(JGLKEFCBKNK()), AHDHLIECIGH: false);
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("popUpBuilding3", EGFGNGJGBOP: true, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KNIBOAEFGPJ));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IKDDFHOHHHM));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	public void KPEMDKAOANI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.CGFMBJFGLAG(Vector2.op_Implicit(JNODCGFKHCP()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.SetBool("ReceiveStatuePuzzleSolved", EGFGNGJGBOP: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BEEDFJOOPAH));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EIJGFNNIOBN));
			turkeyNpc.walkTo.PEHELKCIECB();
		}
	}

	private void LHLBGLMBJGJ()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (KNJGCKDGGOO())
			{
				FICLGDADLPC();
			}
			else
			{
				DPBFJMEAPJH();
			}
		}
	}

	private bool AGOKOEKINHB()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 0)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 1148f;
			}
			return true;
		}
		return true;
	}

	private void GCPKCLJCDJF()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("LetGoBird");
		}
	}

	public void DPBFJMEAPJH()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.GLHBJNDMIDC(Vector2.op_Implicit(NJJOPKOMJBD()));
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("Stop", EGFGNGJGBOP: true, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GEAKPMEBBAI));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PDLDNJNEMAF));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private void FFAGAMOLPPC()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = false;
			runningAgainCount = 1;
			animator.SetTrigger(" perk 23 propina ");
		}
	}

	private bool HGMLCPFBBMG()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 0)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 1645f;
			}
			return true;
		}
		return true;
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
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 3f;
			}
			return false;
		}
		return true;
	}

	private IEnumerator AFHDCPHPJOK()
	{
		return new BMHPIJHLCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GLGMKBLHODN()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	private Vector3 JGLKEFCBKNK()
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
			bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
			bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
			bBJDPIJPLPA.checkDistance = true;
			bBJDPIJPLPA.minDistance = 10;
			bBJDPIJPLPA.checkNodeFree = true;
			bBJDPIJPLPA.checkCanPlaceObject = false;
			bBJDPIJPLPA.checkFarmable = false;
			bBJDPIJPLPA.avoidPath = true;
			Utils.CLGHKOEGACP(Vector2.op_Implicit(((Component)turkeyNpc).transform.position), new Vector2(20f, 20f), bBJDPIJPLPA, ref validPositions);
			validPositions.HOOBEDNMNFK();
			if (validPositions.Count != 0)
			{
				for (int i = 0; i < validPositions.Count; i++)
				{
					Vector3 val = Vector2.op_Implicit(validPositions[i]);
					if (Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) < Vector2.Distance(Vector2.op_Implicit(val), Vector2.op_Implicit(turkeyNpc.hitPosition)))
					{
						return val;
					}
				}
				return Vector2.op_Implicit(validPositions[0]);
			}
			bBJDPIJPLPA.checkDistance = false;
			return Vector2.op_Implicit(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(20f, 20f)));
		}
		return Vector3.zero;
	}

	public void PEJIEBMAMFD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount += 0;
			walkingDone = false;
			turkeyNpc.walkTo.HELOLJBENMK(Vector2.op_Implicit(MBGCGKIBBLB()), AHDHLIECIGH: false);
			turkeyNpc.turkeyAnimation.SetBool("<sprite name=\"ironBarIcon\">", EGFGNGJGBOP: true, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PKKNFNMFOON));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AOBEPCDGKAF));
			turkeyNpc.walkTo.EHDKLBLKBEO();
		}
	}

	private void EEOMBEMDIBE()
	{
		if (!((Object)(object)turkeyNpc == (Object)null))
		{
			if (IGPKFOFNMPM())
			{
				DNIPBIPJKLJ();
			}
			else
			{
				PJFEFLDGEOI();
			}
		}
	}

	private void DNIPBIPJKLJ()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && Object.op_Implicit((Object)(object)animator))
		{
			turkeyNpc.walkTo.isActive = true;
			runningAgainCount = 1;
			animator.SetTrigger("You lose...");
		}
	}

	public void HLLKGGLLPKN()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)turkeyNpc != (Object)null)
		{
			runningAgainCount++;
			walkingDone = true;
			turkeyNpc.walkTo.OGLJDLEGJAA(Vector2.op_Implicit(KDLDLLBPGKK()), AHDHLIECIGH: true, NGAKHGJANLO: false);
			turkeyNpc.turkeyAnimation.CGEADHOLHCH("HotBath/Bark", EGFGNGJGBOP: true, HALNIEBONKH: true);
			turkeyNpc.rb.velocity = Vector2.zero;
			turkeyNpc.walkTo.speed = turkeyNpc.runSpeed;
			turkeyNpc.walkTo.findNearPosiblePosition = false;
			NPCWalkTo walkTo = turkeyNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KNIBOAEFGPJ));
			NPCWalkTo walkTo2 = turkeyNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DEEIFGLNMLP));
			turkeyNpc.walkTo.NOFKEMGPFEO();
		}
	}

	private IEnumerator NINHKPCEOFL()
	{
		yield return CommonReferences.wait05;
		delayFirstWalkCoroutine = null;
		turkeyNpc.hitCollider.SetActive(false);
		FEBCKGENPKJ();
	}

	public void KNIBOAEFGPJ()
	{
		walkingDone = true;
		if (DOJLLOMBDLK())
		{
			FLPKCDGPDFE();
		}
		else
		{
			GNEEBFMCPOH();
		}
	}

	private bool DOJLLOMBDLK()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (runningAgainCount < 5)
		{
			if (runningAgainCount >= 4)
			{
				return Vector2.Distance(Vector2.op_Implicit(turkeyNpc.hitPosition), Vector2.op_Implicit(((Component)turkeyNpc).transform.position)) > 722f;
			}
			return false;
		}
		return false;
	}
}
