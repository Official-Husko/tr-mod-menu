using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonsterWalkAroundState : MonsterStateBase
{
	[CompilerGenerated]
	private sealed class CPBICKCBNCD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonsterWalkAroundState _003C_003E4__this;

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
		public CPBICKCBNCD(int _003C_003E1__state)
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
			MonsterWalkAroundState monsterWalkAroundState = _003C_003E4__this;
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
				monsterWalkAroundState.waitingToWalkTime = Time.time + 2f;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (Time.time < monsterWalkAroundState.waitingToWalkTime)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			monsterWalkAroundState.monsterNpc.waitToWalkCoroutine = null;
			monsterWalkAroundState.DKFOJDHBGEJ();
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

	private float nextEat;

	private float waitingToWalkTime;

	private void EHNACEHHOJK()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("UI2");
		}
	}

	private void FKBOPOMCLBF()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Idle");
		}
	}

	public void LJILHGOKKMJ()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("Grass", EGFGNGJGBOP: true, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.SetBool("Hikari/Barks_Intro", EGFGNGJGBOP: false);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.KBEENHPEOAB(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(28f, 1313f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PBBBJBHFGNN));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KLDIIKJAKIB));
		monsterNpc.walkTo.EHDKLBLKBEO();
	}

	public void EIAMODMOLIL()
	{
		monsterNpc.walkingAgainCount = 1;
	}

	public void JDAAMJHGDLE()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(GGNGMFBEGJE());
		}
	}

	public void FCHHBLDKOIK()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(DCBOGHFKJJB());
		}
	}

	public void DODEDPJEOAM()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("Southeast", EGFGNGJGBOP: true);
		monsterNpc.monsterAnimation.SetBool("PlayerBed", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.HELOLJBENMK(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1228f, 1143f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FNJODLOADKA));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BHKLMNJGLFN));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator KCBBFDLPFGH()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void GMCINBCEPJO()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	private IEnumerator GGNGMFBEGJE()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void APCLPKOJFKK()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("ReceiveResetAllPlayersPrepared", EGFGNGJGBOP: true, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.SetBool("Up Arrow", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.MetalWorkshop);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.JJDCANFBFMK(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(23f, 1015f)));
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JMBOINMJEGI));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	private void BHKLMNJGLFN()
	{
		monsterNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Pipe");
		}
	}

	public void FNJODLOADKA()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	private IEnumerator CNLNIDBNMIF()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CAHIIFMAAEA()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("SortByType");
		}
	}

	public void JKFEBEKOKCK()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("end conversations", EGFGNGJGBOP: true, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.CGEADHOLHCH("ErrorDisconnectedTitleScreen", EGFGNGJGBOP: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.MetalWorkshop;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.DBHOIIIHIIM(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1055f, 1166f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CNIEDLKPGBK));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NAKLGHHDBAN));
		monsterNpc.walkTo.EHDKLBLKBEO();
	}

	public void PAAHMBHMKLI()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("Player/Bark/Tutorial/T101", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.SetBool("Adding quest done 35 - First room", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.GINPKMBGOFN(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(3f, 923f)), AHDHLIECIGH: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FOEBEJHKEKE));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GMFONHHLBIO));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	public void EOBGCNMMCGD()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("MopDown", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.CGEADHOLHCH("MinPrice", EGFGNGJGBOP: false);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop);
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.CGFMBJFGLAG(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1870f, 854f)));
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(BCDDGNEGDNL));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACLOFACNPDP));
		monsterNpc.walkTo.NOFKEMGPFEO();
	}

	public void CNIEDLKPGBK()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	private IEnumerator OIDBJNAJCKK()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FKGLCBAFBGA()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(CNLNIDBNMIF());
		}
	}

	private void KLDIIKJAKIB()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(")\n");
		}
	}

	private IEnumerator ICENHBEDIEO()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void NDOHNICDLFC()
	{
		if (!walkingDone && monsterNpc.walkTo.IIMEFNIECLI())
		{
			nextWalk = Time.time + Random.Range(5f, 15f);
			walkingDone = true;
			nextEat = Time.time + Random.Range(3f, 5f);
		}
		if (walkingDone && Time.time < nextWalk)
		{
			monsterNpc.monsterAnimation.SetBool("Eat", EGFGNGJGBOP: true);
			if (Time.time > nextEat)
			{
				monsterNpc.monsterAnimation.SetBool("Loop", !monsterNpc.monsterAnimation.GetBool("Loop"));
				nextEat = Time.time + Random.Range(3f, 5f);
			}
		}
		if (walkingDone && Time.time > nextWalk)
		{
			ACOJHBFFFIF();
		}
	}

	private void JMBOINMJEGI()
	{
		monsterNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Accept");
		}
	}

	private IEnumerator LJFEOCDMLAB()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void DLFBDNPEKAE()
	{
		monsterNpc.walkingAgainCount = 1;
	}

	private IEnumerator JJHFFLDAHCJ()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void IBIHOAPEONB()
	{
		monsterNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("[MinePuzzleManager] Selected puzzle type {0} with random value {1} and cumulative {2}");
		}
	}

	public void KBKMBKENPIP()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("Trying to assign the {0} parameter {1} with the incorrect type ({2}) on {3}.", EGFGNGJGBOP: true, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.CGEADHOLHCH("<color=", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.Cellar | ZoneType.StoneWorkshop);
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.OGLJDLEGJAA(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1507f, 1860f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FOEBEJHKEKE));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CAHIIFMAAEA));
		monsterNpc.walkTo.NOFKEMGPFEO();
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		walkingDone = false;
		ONDMDLMHMHK.SetBool("Run", false);
		nextWalk = Time.fixedTime + Random.Range(5f, 15f);
		nextEat = Time.fixedTime + Random.Range(1f, 3f);
		FLMGBOAGFMO();
	}

	private IEnumerator GFNIINMHHEB()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void HDMLONEJHDD()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(ICENHBEDIEO());
		}
	}

	public void MAILEMECPME()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	public void MIKDBKPPBHP()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(DCBOGHFKJJB());
		}
	}

	private void ACOJHBFFFIF()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Walk");
		}
	}

	public void CNJMNBAKEEK()
	{
		monsterNpc.walkingAgainCount = 1;
	}

	public void MAGDABOLFDI()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("Transform", EGFGNGJGBOP: true, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.SetBool("no ing", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.OGLJDLEGJAA(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1516f, 822f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GOPIJNFDCME));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(NAKLGHHDBAN));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	public void FOEBEJHKEKE()
	{
		monsterNpc.walkingAgainCount = 1;
	}

	public void PBBBJBHFGNN()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	public void JOIEMEGHDDM()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(COMOJKKNGLJ());
		}
	}

	public void JLGHCKAMDPK()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(NEAKIEFOIOG());
		}
	}

	private IEnumerator CGIMCLLGKDB()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private IEnumerator MPOFNNAHMBE()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KJIHKAKCKBL()
	{
		monsterNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Invalid playerNum");
		}
	}

	public void BFGEFKOODNA()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	public void GKFINLKHKOF()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH(" ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.SetBool(" 2", EGFGNGJGBOP: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar);
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.GLHBJNDMIDC(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1626f, 634f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(FOEBEJHKEKE));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KLDIIKJAKIB));
		monsterNpc.walkTo.EHDKLBLKBEO();
	}

	private IEnumerator AGALMLKFIIL()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GOPIJNFDCME()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	public void HMOPLHDOPKK()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	public void BCDDGNEGDNL()
	{
		monsterNpc.walkingAgainCount = 1;
	}

	public void PHCNLDCGHHB()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("hideui", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.SetBool("NotValid", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.DBHOIIIHIIM(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(303f, 269f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PBBBJBHFGNN));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IBIHOAPEONB));
		monsterNpc.walkTo.NOFKEMGPFEO();
	}

	public void JNOHNOBBOHB()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("ReceiveHerbAction", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.CGEADHOLHCH("UI", EGFGNGJGBOP: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.StoneWorkshop;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.DHFPOCOEONG(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(200f, 343f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HILLNFIICFK));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CAHIIFMAAEA));
		monsterNpc.walkTo.NOFKEMGPFEO();
	}

	public void LBBPHODBACP()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(CNLNIDBNMIF());
		}
	}

	private IEnumerator OLCKJFJADGM()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FLMGBOAGFMO()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(NEAKIEFOIOG());
		}
	}

	public void GPBPELPPLCJ()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(COMOJKKNGLJ());
		}
	}

	private IEnumerator COMOJKKNGLJ()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OHDFLHEHING()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("zuzzu");
		}
	}

	public void CHEMAKGDEID()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH(" is not supported by CanvasWorldScaler", EGFGNGJGBOP: false, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.SetBool("] ", EGFGNGJGBOP: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.JJDCANFBFMK(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(17f, 1472f)));
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(HILLNFIICFK));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KPNKHMHMBOF));
		monsterNpc.walkTo.NOFKEMGPFEO();
	}

	public void HGGNGLIKDAH()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(MPOFNNAHMBE());
		}
	}

	public void DNIPBIPJKLJ()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("ErrorUnknownChatCommand", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.CGEADHOLHCH("Items/item_name_628", EGFGNGJGBOP: false);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.FNNPPBDFBCI(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(110f, 139f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(BHKLMNJGLFN));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	private void ACLOFACNPDP()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Christmas/Ace/Stand");
		}
	}

	private IEnumerator DCBOGHFKJJB()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void DHMDNCIBEKG()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		monsterNpc.monsterAnimation.CGEADHOLHCH("Direction", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.JJDCANFBFMK(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1420f, 1782f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EIAMODMOLIL));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GMFONHHLBIO));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	public void NFCLPJONDJB()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("Unaged Blue", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.CGEADHOLHCH("tutorialPopUp112", EGFGNGJGBOP: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop);
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.GDGGABHLNOH(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1956f, 1546f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(CNIEDLKPGBK));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JMBOINMJEGI));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	private void DKDBFNCODIK()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/11/Dialogue Text");
		}
	}

	public void PDOBHPLPKHG()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	private IEnumerator JDHIBEDICEK()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void JCBIDOLCOOD()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("Guards finished walking.", EGFGNGJGBOP: true);
		monsterNpc.monsterAnimation.CGEADHOLHCH("ObjectVerticalMove", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.MetalWorkshop;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.GHDMBFOAAHK(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1088f, 803f)), AHDHLIECIGH: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(MAILEMECPME));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(GMFONHHLBIO));
		monsterNpc.walkTo.EHDKLBLKBEO();
	}

	private void ALEEFHFLAIK()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("");
		}
	}

	public void CINMGEBIDOB()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("Remove", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.CGEADHOLHCH("Wine", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop);
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.EJPGFOEDPBG(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(1240f, 1938f)), AHDHLIECIGH: true, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(EDDFAALFNGB));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ALEEFHFLAIK));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	public void DKFOJDHBGEJ()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("Loop", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.SetBool("Eat", EGFGNGJGBOP: false);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.Anywhere;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.FNNPPBDFBCI(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(10f, 10f)));
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		monsterNpc.walkTo.PEHELKCIECB();
	}

	private IEnumerator LDIKAMJLKLF()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private IEnumerator DNBGGGLJAPJ()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DAMMCOEBEMJ()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(JDHIBEDICEK());
		}
	}

	private void GMFONHHLBIO()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Angry");
		}
	}

	public void HILLNFIICFK()
	{
		monsterNpc.walkingAgainCount = 1;
	}

	public void NNPMNLEDDPD()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(KCBBFDLPFGH());
		}
	}

	private IEnumerator FPLKIKJBLGC()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private IEnumerator JEILNMLNLEB()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private IEnumerator NEAKIEFOIOG()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void ODOOJBAGKPE()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("Networked Object ", EGFGNGJGBOP: false);
		monsterNpc.monsterAnimation.SetBool("Meaty", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = false;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.KBEENHPEOAB(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(402f, 282f)));
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = false;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(GMCINBCEPJO));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(CAHIIFMAAEA));
		monsterNpc.walkTo.NOFKEMGPFEO();
	}

	private IEnumerator FHJLOBMOICG()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	public void MICBIHKIPJP()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(JDHIBEDICEK());
		}
	}

	public void CAKIFDOCNKO()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.CGEADHOLHCH("cloudy", EGFGNGJGBOP: true);
		monsterNpc.monsterAnimation.CGEADHOLHCH("Error in FarmBuilding.OnPlayerSleep: ", EGFGNGJGBOP: false);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop);
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = false;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.CGFMBJFGLAG(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(985f, 181f)), AHDHLIECIGH: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(JMBOINMJEGI));
		monsterNpc.walkTo.EHDKLBLKBEO();
	}

	private void PPBLPFDOBGD()
	{
		monsterNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Price of ");
		}
	}

	public void NOIHDAOBMFO()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(DNBGGGLJAPJ());
		}
	}

	public void EDDFAALFNGB()
	{
		monsterNpc.walkingAgainCount = 0;
	}

	private void KPNKHMHMBOF()
	{
		monsterNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("NormalLeftExterior");
		}
	}

	public void IHKGGOCDPGN()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(OIDBJNAJCKK());
		}
	}

	private IEnumerator HPPNHINDCML()
	{
		yield return null;
		waitingToWalkTime = Time.time + 2f;
		while (Time.time < waitingToWalkTime)
		{
			yield return null;
		}
		monsterNpc.waitToWalkCoroutine = null;
		DKFOJDHBGEJ();
	}

	private void BOOBKGLCDFK()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("quest_name_30");
		}
	}

	private void NAKLGHHDBAN()
	{
		monsterNpc.walkingAgainCount++;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("cameraZoom");
		}
	}

	public void CFGMFNDOPKN()
	{
		if (monsterNpc.waitToWalkCoroutine == null)
		{
			monsterNpc.waitToWalkCoroutine = ((MonoBehaviour)monsterNpc).StartCoroutine(ICENHBEDIEO());
		}
	}

	private void PDLDELGPHMG()
	{
		monsterNpc.walkingAgainCount += 0;
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("ERROR: The object ");
		}
	}

	private IEnumerator CAPCBHEBBII()
	{
		return new CPBICKCBNCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NELKIIMEHBC()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		monsterNpc.monsterAnimation.SetBool("AdventureContinuesEvent OnWorldLoaded ", EGFGNGJGBOP: true);
		monsterNpc.monsterAnimation.CGEADHOLHCH("ReceiveCancelAllCraftingMaster", EGFGNGJGBOP: false);
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = WorldGrid.HJPCBBGHPDA(((Component)monsterNpc).transform.position);
		bBJDPIJPLPA.zoneType = ~(ZoneType.Cellar | ZoneType.StoneWorkshop);
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		bBJDPIJPLPA.checkFarmable = true;
		bBJDPIJPLPA.avoidPath = true;
		monsterNpc.rb.velocity = Vector2.zero;
		monsterNpc.walkTo.HELOLJBENMK(Utils.JBGFJENPEIM(((Component)monsterNpc).transform.position, Vector2Int.one, bBJDPIJPLPA, new Vector2(541f, 1083f)), AHDHLIECIGH: false, NGAKHGJANLO: false);
		monsterNpc.walkTo.speed = monsterNpc.speed;
		monsterNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = monsterNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(DLFBDNPEKAE));
		NPCWalkTo walkTo2 = monsterNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(KPNKHMHMBOF));
		monsterNpc.walkTo.NOFKEMGPFEO();
	}
}
