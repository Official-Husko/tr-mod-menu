using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenericNPCWalkAroundState : GenericNPCStateBase
{
	[CompilerGenerated]
	private sealed class AJFNOLGGMID : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GenericNPCWalkAroundState _003C_003E4__this;

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
		public AJFNOLGGMID(int _003C_003E1__state)
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
			GenericNPCWalkAroundState genericNPCWalkAroundState = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				genericNPCWalkAroundState.npc.simpleAnimController.anim.StopAnimNow();
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				genericNPCWalkAroundState.waitingToWalkTime = Time.time + 2f;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (!genericNPCWalkAroundState.npc.npcAnimation.safeMovement && Time.time < genericNPCWalkAroundState.waitingToWalkTime)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			genericNPCWalkAroundState.npc.waitToWalkCoroutine = null;
			genericNPCWalkAroundState.DKFOJDHBGEJ();
			return false;
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

	private float nextWalk;

	private float waitingToWalkTime;

	public void NOIHDAOBMFO()
	{
		if (npc.waitToWalkCoroutine == null)
		{
			npc.waitToWalkCoroutine = ((MonoBehaviour)npc).StartCoroutine(DGFHNNDJBPJ());
		}
	}

	public void KPMCGMJJBEA()
	{
		npc.walkingAgainCount = 1;
	}

	private void GONBDDJHANF()
	{
		npc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(" state: ");
		}
	}

	public void FLMGBOAGFMO()
	{
		if (npc.waitToWalkCoroutine == null)
		{
			npc.waitToWalkCoroutine = ((MonoBehaviour)npc).StartCoroutine(NEAKIEFOIOG());
		}
	}

	private void ACOJHBFFFIF()
	{
		npc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Walk");
		}
	}

	public void DKCIPEBOEMJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)npc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		npc.walkTo.JJDCANFBFMK(Utils.JBGFJENPEIM(((Component)npc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1016f, 474f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.speed = npc.speed;
		npc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MAILEMECPME));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GBLGELBAPOJ));
		npc.walkTo.NOFKEMGPFEO();
	}

	private IEnumerator HILIFCFJFIM()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KMFHAHKJHJP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)npc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		npc.walkTo.CGFMBJFGLAG(Utils.JBGFJENPEIM(((Component)npc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(796f, 406f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.speed = npc.speed;
		npc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GBLGELBAPOJ));
		npc.walkTo.EHDKLBLKBEO();
	}

	private IEnumerator NEAKIEFOIOG()
	{
		npc.simpleAnimController.anim.StopAnimNow();
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (!npc.npcAnimation.safeMovement && Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		npc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public override void DPFMOKIDPMB()
	{
		if (!walkingDone && npc.walkTo.IIMEFNIECLI())
		{
			nextWalk = Time.fixedTime + Random.Range(npc.nextWalkMin, npc.nextWalkMax);
			walkingDone = true;
		}
		if (walkingDone && Time.fixedTime > nextWalk)
		{
			ACOJHBFFFIF();
		}
	}

	public void GOPIJNFDCME()
	{
		npc.walkingAgainCount = 0;
	}

	public void EDDOIJHPBHM()
	{
		npc.walkingAgainCount = 0;
	}

	public void MAILEMECPME()
	{
		npc.walkingAgainCount = 0;
	}

	public void OGBEGBJDNKJ()
	{
		npc.walkingAgainCount = 0;
	}

	private IEnumerator OIDBJNAJCKK()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GBLGELBAPOJ()
	{
		npc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(" - <b><color=#8C78BA>");
		}
	}

	public void HEEOHKBPMAI()
	{
		npc.walkingAgainCount = 1;
	}

	public void LPMIHGICGNK()
	{
		npc.walkingAgainCount = 0;
	}

	public void PDOBHPLPKHG()
	{
		npc.walkingAgainCount = 0;
	}

	private IEnumerator DCBOGHFKJJB()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DIBALJFLONG()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DKFOJDHBGEJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)npc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		npc.walkTo.FNNPPBDFBCI(Utils.JBGFJENPEIM(((Component)npc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(10f, 10f)));
		npc.walkTo.speed = npc.speed;
		npc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		npc.walkTo.PEHELKCIECB();
	}

	public void GLKLGFBAOCC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)npc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		npc.walkTo.JDHMPOJKOLF(Utils.JBGFJENPEIM(((Component)npc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(929f, 656f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.speed = npc.speed;
		npc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HEEOHKBPMAI));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		npc.walkTo.NOFKEMGPFEO();
	}

	public void COMLEKJGHGI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)npc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		npc.walkTo.DHFPOCOEONG(Utils.JBGFJENPEIM(((Component)npc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1509f, 1047f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.speed = npc.speed;
		npc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EDDOIJHPBHM));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GBLGELBAPOJ));
		npc.walkTo.NOFKEMGPFEO();
	}

	public void NIKMCNDMJAF()
	{
		if (npc.waitToWalkCoroutine == null)
		{
			npc.waitToWalkCoroutine = ((MonoBehaviour)npc).StartCoroutine(KEMKNGOFMFO());
		}
	}

	public void PAAHMBHMKLI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)npc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		npc.walkTo.GLHBJNDMIDC(Utils.JBGFJENPEIM(((Component)npc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1757f, 968f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.speed = npc.speed;
		npc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(LPMIHGICGNK));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GONBDDJHANF));
		npc.walkTo.EHDKLBLKBEO();
	}

	public void IKAHMBFLKNF()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)npc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		npc.walkTo.HELOLJBENMK(Utils.JBGFJENPEIM(((Component)npc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(359f, 524f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.speed = npc.speed;
		npc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MAILEMECPME));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GONBDDJHANF));
		npc.walkTo.PEHELKCIECB();
	}

	public void AJDJBEMILKL()
	{
		if (npc.waitToWalkCoroutine == null)
		{
			npc.waitToWalkCoroutine = ((MonoBehaviour)npc).StartCoroutine(DGFHNNDJBPJ());
		}
	}

	public void NCHDNBKBIKD()
	{
		if (npc.waitToWalkCoroutine == null)
		{
			npc.waitToWalkCoroutine = ((MonoBehaviour)npc).StartCoroutine(KEMKNGOFMFO());
		}
	}

	private IEnumerator AGALMLKFIIL()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KEMKNGOFMFO()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LJGMDKAHDLF()
	{
		if (npc.waitToWalkCoroutine == null)
		{
			npc.waitToWalkCoroutine = ((MonoBehaviour)npc).StartCoroutine(NEAKIEFOIOG());
		}
	}

	public void BOEIPCKONOD()
	{
		if (npc.waitToWalkCoroutine == null)
		{
			npc.waitToWalkCoroutine = ((MonoBehaviour)npc).StartCoroutine(OIDBJNAJCKK());
		}
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		walkingDone = false;
		ONDMDLMHMHK.SetBool("Run", false);
		nextWalk = Time.fixedTime + Random.Range(npc.nextWalkMin, npc.nextWalkMax);
		FLMGBOAGFMO();
	}

	private IEnumerator DGFHNNDJBPJ()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}
}
