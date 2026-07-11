using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TurkeyWalkAroundState : TurkeyStateBase
{
	[CompilerGenerated]
	private sealed class AJFNOLGGMID : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurkeyWalkAroundState _003C_003E4__this;

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
			TurkeyWalkAroundState turkeyWalkAroundState = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				turkeyWalkAroundState.waitingToWalkTime = Time.time + 2f;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (!turkeyWalkAroundState.turkeyNpc.CanWalk() && Time.time < turkeyWalkAroundState.waitingToWalkTime)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			turkeyWalkAroundState.turkeyNpc.waitToWalkCoroutine = null;
			turkeyWalkAroundState.DKFOJDHBGEJ();
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

	private IEnumerator JMAEEDKCLLJ()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HFLCAILNOHC()
	{
		turkeyNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("NinjaChallengeEvent/Main 2");
		}
	}

	private void ACOJHBFFFIF()
	{
		turkeyNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Walk");
		}
	}

	public void GFILCKLGFFH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		turkeyNpc.rb.velocity = Vector2.zero;
		turkeyNpc.walkTo.KBEENHPEOAB(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(930f, 1185f)), AHDHLIECIGH: false);
		turkeyNpc.walkTo.speed = turkeyNpc.speed;
		turkeyNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = turkeyNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BEEDFJOOPAH));
		NPCWalkTo walkTo2 = turkeyNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		turkeyNpc.walkTo.EHDKLBLKBEO();
	}

	private void KJMDNKCJFEF()
	{
		turkeyNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("");
		}
	}

	private void PDLDELGPHMG()
	{
		turkeyNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/8/Dialogue Text");
		}
	}

	private void MDLHDGDLANK()
	{
		turkeyNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("");
		}
	}

	public void MMPGIKGMFMA()
	{
		turkeyNpc.walkingAgainCount = 0;
	}

	public void FLMGBOAGFMO()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(NEAKIEFOIOG());
		}
	}

	public void FCHHBLDKOIK()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(KJGJHFGDKOJ());
		}
	}

	public void AHOBEHAIBEE()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(DCBOGHFKJJB());
		}
	}

	private void JEJGIAPPCLG()
	{
		turkeyNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("repUnlockUpgrade");
		}
	}

	public void CEDKNKOPKAH()
	{
		turkeyNpc.walkingAgainCount = 1;
	}

	public void ICPNACCECDA()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(JMAEEDKCLLJ());
		}
	}

	public void LJGMDKAHDLF()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(AGALMLKFIIL());
		}
	}

	private void PBMBOPDALGD()
	{
		turkeyNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Talent");
		}
	}

	public override void EHBJGKOOOFF()
	{
		if (!walkingDone && turkeyNpc.walkTo.IIMEFNIECLI())
		{
			nextWalk = Time.fixedTime + Random.Range(5f, 15f);
			walkingDone = true;
		}
		if (walkingDone && Time.fixedTime > nextWalk && turkeyNpc.turkeyAnimationState.safeMovement)
		{
			ACOJHBFFFIF();
		}
	}

	private void OAGCLGKAMFM()
	{
		turkeyNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("UINextPage");
		}
	}

	private IEnumerator KKKNMPJCBIC()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HBPGCEKNHOH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		turkeyNpc.rb.velocity = Vector2.zero;
		turkeyNpc.walkTo.GHDMBFOAAHK(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1399f, 1471f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		turkeyNpc.walkTo.speed = turkeyNpc.speed;
		turkeyNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = turkeyNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ALDAHNKKOGE));
		NPCWalkTo walkTo2 = turkeyNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(PBMBOPDALGD));
		turkeyNpc.walkTo.EHDKLBLKBEO();
	}

	public void HDMLONEJHDD()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(AGALMLKFIIL());
		}
	}

	private void KNGJNEKCPOL()
	{
		turkeyNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("buildModeActive");
		}
	}

	private IEnumerator JPJGOEMKAMP()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BOEIPCKONOD()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(DCBOGHFKJJB());
		}
	}

	public void DKFOJDHBGEJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)turkeyNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		turkeyNpc.rb.velocity = Vector2.zero;
		turkeyNpc.walkTo.FNNPPBDFBCI(Utils.JBGFJENPEIM(((Component)turkeyNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(10f, 10f)));
		turkeyNpc.walkTo.speed = turkeyNpc.speed;
		turkeyNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = turkeyNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = turkeyNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		turkeyNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator KJGJHFGDKOJ()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LPMIHGICGNK()
	{
		turkeyNpc.walkingAgainCount = 1;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		walkingDone = false;
		ONDMDLMHMHK.SetBool("Run", false);
		nextWalk = Time.fixedTime + Random.Range(5f, 15f);
		FLMGBOAGFMO();
	}

	public void IHEHHCLJFDK()
	{
		turkeyNpc.walkingAgainCount = 0;
	}

	private void NNFPNFNFCJJ()
	{
		turkeyNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("F2");
		}
	}

	public void DMMJODJMGEG()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(JMAEEDKCLLJ());
		}
	}

	public void FGCFPIBDPDL()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(AGALMLKFIIL());
		}
	}

	private IEnumerator AGALMLKFIIL()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NEAKIEFOIOG()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (!turkeyNpc.CanWalk() && Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		turkeyNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void ALDAHNKKOGE()
	{
		turkeyNpc.walkingAgainCount = 1;
	}

	public void PDOBHPLPKHG()
	{
		turkeyNpc.walkingAgainCount = 0;
	}

	private IEnumerator DCBOGHFKJJB()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (!turkeyNpc.CanWalk() && Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		turkeyNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void BEEDFJOOPAH()
	{
		turkeyNpc.walkingAgainCount = 1;
	}

	public void EGNKMKHDKHJ()
	{
		if (turkeyNpc.waitToWalkCoroutine == null)
		{
			turkeyNpc.waitToWalkCoroutine = ((MonoBehaviour)turkeyNpc).StartCoroutine(AGALMLKFIIL());
		}
	}
}
