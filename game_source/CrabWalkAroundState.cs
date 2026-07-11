using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CrabWalkAroundState : CrabStateBase
{
	[CompilerGenerated]
	private sealed class AJFNOLGGMID : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrabWalkAroundState _003C_003E4__this;

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
			CrabWalkAroundState crabWalkAroundState = _003C_003E4__this;
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
				crabWalkAroundState.waitingToWalkTime = Time.time + 2f;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (Time.time < crabWalkAroundState.waitingToWalkTime)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			crabWalkAroundState.crabNpc.waitToWalkCoroutine = null;
			crabWalkAroundState.DKFOJDHBGEJ();
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

	private void KJMDNKCJFEF()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("via End-Segment");
		}
	}

	public void HLJJDEIBKOJ()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(OOGDCGCFKHB());
		}
	}

	public void BCDEHNHEGPJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.DBHOIIIHIIM(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1969f, 424f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(OMPINFKNJAF));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ENOEOGABPIC));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	private void GONBDDJHANF()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("No floor dirt found.");
		}
	}

	public void HGGNGLIKDAH()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(CPJLJOBHLDF());
		}
	}

	private void ENOEOGABPIC()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(" has null in occupy nodes with colliders list.");
		}
	}

	public void DLFBDNPEKAE()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void FOEBEJHKEKE()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void DHFOEHFPLNB()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private void INACOMEAINH()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("KyrohScene");
		}
	}

	public void CAKIFDOCNKO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Ground | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.KBEENHPEOAB(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1215f, 111f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CNIEDLKPGBK));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KKDJEKACAIE));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	private IEnumerator MEEIILHGLFJ()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FJLPBMIKNAH()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KEDBLNJIIGF()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JEILNMLNLEB());
		}
	}

	public void MAGDABOLFDI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.None;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.JDHMPOJKOLF(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(7f, 215f)), AHDHLIECIGH: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MKJDIMFOGIA));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KKDJEKACAIE));
		crabNpc.walkTo.NOFKEMGPFEO();
	}

	private IEnumerator ACAADIALHOM()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GIBANKONFHA()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DIHKIFGMKPB()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void IJCLNLKKIAF()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private IEnumerator LJEJCNBKPPH()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DKFOJDHBGEJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Floor;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.FNNPPBDFBCI(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(10f, 10f)));
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		crabNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator OLCKJFJADGM()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DHMDNCIBEKG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.Ground | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.BDIKOLNFKGD(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1235f, 1829f)), AHDHLIECIGH: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(IJCLNLKKIAF));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JMLELHEJBPJ));
		crabNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator OECLCDJMGLF()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void OFEMFGCBLBH()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("ThrownHookRPC");
		}
	}

	private void JCFADDLAGBL()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("NetworkSync ");
		}
	}

	private void LFBMFAHPBIM()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(" ");
		}
	}

	private void EBBAPFKABDB()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("<b><color=#9A3F00>");
		}
	}

	public void MALBJKNHHKO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.OGLJDLEGJAA(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(134f, 1933f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MGBFANKBLGN));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GONBDDJHANF));
		crabNpc.walkTo.PEHELKCIECB();
	}

	public void EEPFEGCLIOH()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private void MFOGPNPNHFE()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("#.##%");
		}
	}

	public void JLLBJMPBEED()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.FNNPPBDFBCI(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(704f, 1153f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HNFMJFJPDNN));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KKDJEKACAIE));
		crabNpc.walkTo.PEHELKCIECB();
	}

	public void AJDJBEMILKL()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(PBDCCAKPKPH());
		}
	}

	private IEnumerator HFJCHPAEBJJ()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PIKOADACHCB()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FOBPMBDMGBL()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("ReceiveKick");
		}
	}

	public void EHKMGOHOADL()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JIMPLLJAMMJ());
		}
	}

	private void OIJCKGLLHKM()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Snow");
		}
	}

	public override void ACBBHJIMGCC()
	{
		if (!walkingDone && crabNpc.walkTo.IIMEFNIECLI())
		{
			nextWalk = Time.fixedTime + Random.Range(5f, 15f);
			walkingDone = true;
		}
		if (walkingDone && Time.fixedTime > nextWalk)
		{
			ACOJHBFFFIF();
		}
	}

	private IEnumerator CNLNIDBNMIF()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GFNIINMHHEB()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CHEMAKGDEID()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.JDHMPOJKOLF(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1643f, 1358f)));
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EEPFEGCLIOH));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(LFBMFAHPBIM));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	public void DDEALIAKDPN()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(OECLCDJMGLF());
		}
	}

	public void AEGGBPOJABO()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(FJLPBMIKNAH());
		}
	}

	private void OKOKOMPNFDF()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("VERSION");
		}
	}

	public void BFNAPCFJKKB()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private void ALBMMJPBAGA()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(":</color> ");
		}
	}

	public void DDLGEGPJGBP()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void GLKLGFBAOCC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Floor;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.GLHBJNDMIDC(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(305f, 1675f)));
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JEPBPABEDGE));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OFEMFGCBLBH));
		crabNpc.walkTo.PEHELKCIECB();
	}

	private void AEEANHACPGH()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("MineChessPillarPuzzle requires ChessPillarPuzzleSettings");
		}
	}

	public void MGBFANKBLGN()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void DFBOJLFKMBP()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private IEnumerator MPOFNNAHMBE()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void OFPIDDFHPDK()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(HFJCHPAEBJJ());
		}
	}

	public void LPMIHGICGNK()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void CLOEFOFKDFC()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void PLKEHLOPOHN()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void LBBPHODBACP()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(KFOHBBLCKLE());
		}
	}

	public void GNMGPKLJCKN()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(FJLPBMIKNAH());
		}
	}

	public void LBLEOMBONOD()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(NEAKIEFOIOG());
		}
	}

	public void MLDKFGJFAMG()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(CNLNIDBNMIF());
		}
	}

	public void CNJMNBAKEEK()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private void ACOJHBFFFIF()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Walk");
		}
	}

	public void MKLFIJMCLLK()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(GFNIINMHHEB());
		}
	}

	private IEnumerator LLHHCPHEBMI()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NABJFOADAND()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.DHFPOCOEONG(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(306f, 802f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DLFBDNPEKAE));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AEEANHACPGH));
		crabNpc.walkTo.NOFKEMGPFEO();
	}

	private IEnumerator JEILNMLNLEB()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HNFMJFJPDNN()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private IEnumerator EJOCJPKJPPD()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JLPDGFJJNAK()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("plantedTrees");
		}
	}

	public void KCINDOCIKAI()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private IEnumerator CPJLJOBHLDF()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ODOOJBAGKPE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.BDIKOLNFKGD(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(104f, 752f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CAEDALACKDD));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OLAEADOHAAE));
		crabNpc.walkTo.NOFKEMGPFEO();
	}

	public void CGLODOJDIJA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Ground;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.JJDCANFBFMK(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1818f, 1089f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDLGEGPJGBP));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JCFADDLAGBL));
		crabNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator OOGDCGCFKHB()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ONPAEAMCPJJ()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JIMPLLJAMMJ());
		}
	}

	public void OMPINFKNJAF()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private void DKMIGLDKNIO()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("player2ToDisconnectFromGame");
		}
	}

	public void BGAPLNMPBFP()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void BLEOCFFEHGN()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JIMPLLJAMMJ());
		}
	}

	private void LNEONEDDBMF()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Items/item_description_594");
		}
	}

	private void CPBPGLIBJNP()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Old drink in bar menu sent to player inventory or delivery chest ");
		}
	}

	public void PAAHMBHMKLI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.OGLJDLEGJAA(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(703f, 1939f)));
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDLGEGPJGBP));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DGJLEFHPOEC));
		crabNpc.walkTo.PEHELKCIECB();
	}

	public void NOKPIFFKCLE()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(ICENHBEDIEO());
		}
	}

	public void DHGFHNALOAH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Ground;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.GLHBJNDMIDC(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1562f, 1067f)), AHDHLIECIGH: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(KGLFHLHBFBH));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JCFADDLAGBL));
		crabNpc.walkTo.PEHELKCIECB();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		if (!TestQualityPCSettings.instance.active)
		{
			walkingDone = false;
			ONDMDLMHMHK.SetBool("Run", false);
			nextWalk = Time.fixedTime + Random.Range(5f, 15f);
			FLMGBOAGFMO();
		}
	}

	public void HDMLONEJHDD()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(OLCKJFJADGM());
		}
	}

	public void FLPKCDGPDFE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.Ground | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.KBEENHPEOAB(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1398f, 970f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CNIEDLKPGBK));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(AEEANHACPGH));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	public void NFGKFCGLCDO()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(EEAOPMNBOAB());
		}
	}

	public void PDOBHPLPKHG()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private IEnumerator EEAOPMNBOAB()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CAELADBMLFL()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private IEnumerator PBDCCAKPKPH()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void IGOGKMLCLPI()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void LHHPNMOEAGL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Floor;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.DHFPOCOEONG(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1077f, 1372f)));
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(NKAMNKDKLHI));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DKMIGLDKNIO));
		crabNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator KFOHBBLCKLE()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void CNIEDLKPGBK()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private void DGJLEFHPOEC()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Metal");
		}
	}

	private void DMGEKAGCEKD()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("ReceiveCollectItemsMaster");
		}
	}

	public void OKKFCJEKBOM()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JIMPLLJAMMJ());
		}
	}

	public void LODNIOGLMDC()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private IEnumerator ICENHBEDIEO()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void KECCBCEAOLG()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(GFNIINMHHEB());
		}
	}

	public void CKGFIHKADBM()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private IEnumerator NEAKIEFOIOG()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private IEnumerator OOLDOPFNKBG()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OCDPJEHPCIH()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private void NONECPIELOP()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Items/item_description_700");
		}
	}

	private IEnumerator JMAEEDKCLLJ()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void JMLELHEJBPJ()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("ChatDefaultName");
		}
	}

	public void KMLPABKICCD()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(CNLNIDBNMIF());
		}
	}

	private IEnumerator FNHLCLBJNBO()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JKMFNFMKKAL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.Ground;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.CGFMBJFGLAG(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(708f, 787f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JLPDGFJJNAK));
		crabNpc.walkTo.PEHELKCIECB();
	}

	private void OLAEADOHAAE()
	{
		crabNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("LE_19");
		}
	}

	public void IEJGDOPLBLB()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void ODKNNOBCILE()
	{
		crabNpc.walkingAgainCount = 0;
	}

	private void NHFGBBBCJNM()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Player Destroyed. Num Players: ");
		}
	}

	public void KAOELCAEOKK()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(GFNIINMHHEB());
		}
	}

	public void KGLFHLHBFBH()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void KPMCGMJJBEA()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void JEPBPABEDGE()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void LFEJAFAKIGF()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(FJLPBMIKNAH());
		}
	}

	public void HMOPLHDOPKK()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private void KKDJEKACAIE()
	{
		crabNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Right Shift");
		}
	}

	public void NKAMNKDKLHI()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void GFDNHLLFABF()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(PIKOADACHCB());
		}
	}

	private IEnumerator BINCILDPFKA()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DACLDIGLCHC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.BDIKOLNFKGD(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(10f, 487f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BFNAPCFJKKB));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KJMDNKCJFEF));
		crabNpc.walkTo.PEHELKCIECB();
	}

	public void DGLIMBMPOFD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.OGLJDLEGJAA(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1795f, 73f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CNIEDLKPGBK));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JLPDGFJJNAK));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	public void KEKCOAJKJCO()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JMAEEDKCLLJ());
		}
	}

	public void DFLPJLDBGEG()
	{
		crabNpc.walkingAgainCount = 1;
	}

	private IEnumerator JIMPLLJAMMJ()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MFELPPLNNIN()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Ground | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.GLHBJNDMIDC(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1457f, 1276f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HNFMJFJPDNN));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(OKOKOMPNFDF));
		crabNpc.walkTo.PEHELKCIECB();
	}

	public void PGHFECICALJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.None;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.GINPKMBGOFN(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(71f, 1305f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DDLGEGPJGBP));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KJMDNKCJFEF));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	public void DMDPGCNAAJP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.Ground;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.DBHOIIIHIIM(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1381f, 1356f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BGAPLNMPBFP));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(INACOMEAINH));
		crabNpc.walkTo.NOFKEMGPFEO();
	}

	public void ABDHBPEMFOO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.Ground;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.DBHOIIIHIIM(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1944f, 1311f)));
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(JEPBPABEDGE));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JCFADDLAGBL));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	public void LJILHGOKKMJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.None;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.GINPKMBGOFN(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(792f, 13f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DFBOJLFKMBP));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(FOBPMBDMGBL));
		crabNpc.walkTo.PEHELKCIECB();
	}

	public void CAEDALACKDD()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void MDOEDAKBFKO()
	{
		crabNpc.walkingAgainCount = 1;
	}

	public void FLMGBOAGFMO()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(NEAKIEFOIOG());
		}
	}

	public void FICLGDADLPC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.TilledEarth;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.JJDCANFBFMK(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(145f, 1714f)));
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CNIEDLKPGBK));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GONBDDJHANF));
		crabNpc.walkTo.NOFKEMGPFEO();
	}

	public void MKJDIMFOGIA()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void EBLEAJFOEJL()
	{
		crabNpc.walkingAgainCount = 0;
	}

	public void CKHPHGBOHHC()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(CPJLJOBHLDF());
		}
	}

	public void OMCIGJCNEHO()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(JIMPLLJAMMJ());
		}
	}

	public void ICPNACCECDA()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(EEAOPMNBOAB());
		}
	}

	public void FNKLJJOGABD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.avoidGroundType = GroundType.Floor;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.DHFPOCOEONG(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(471f, 1139f)), AHDHLIECIGH: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MGBFANKBLGN));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ALBMMJPBAGA));
		crabNpc.walkTo.EHDKLBLKBEO();
	}

	public void JOIEMEGHDDM()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(HFJCHPAEBJJ());
		}
	}

	private IEnumerator BGDNKAMJCLN()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		crabNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private IEnumerator FOPLGGMCCDN()
	{
		return new AJFNOLGGMID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EGNKMKHDKHJ()
	{
		if (crabNpc.waitToWalkCoroutine == null)
		{
			crabNpc.waitToWalkCoroutine = ((MonoBehaviour)crabNpc).StartCoroutine(OOGDCGCFKHB());
		}
	}

	public void HKIEDFHDAJD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.Ground;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.GDGGABHLNOH(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1988f, 615f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(ODKNNOBCILE));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(DGJLEFHPOEC));
		crabNpc.walkTo.NOFKEMGPFEO();
	}

	public void NLNKGGFMIIK()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)crabNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.avoidGroundType = GroundType.Grass | GroundType.Ground;
		crabNpc.rb.velocity = Vector2.zero;
		crabNpc.walkTo.DHFPOCOEONG(Utils.JBGFJENPEIM(((Component)crabNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1697f, 261f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		crabNpc.walkTo.speed = crabNpc.speed;
		crabNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = crabNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HMOPLHDOPKK));
		NPCWalkTo walkTo2 = crabNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(EBBAPFKABDB));
		crabNpc.walkTo.PEHELKCIECB();
	}
}
