using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class AnimalWalkAroundState : AnimalStateBase
{
	[CompilerGenerated]
	private sealed class EBFHENENKAP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimalWalkAroundState _003C_003E4__this;

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
		public EBFHENENKAP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AnimalWalkAroundState animalWalkAroundState = _003C_003E4__this;
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
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (!animalWalkAroundState.animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			animalWalkAroundState.animalNpc.FFHHEGALBKO.walking = true;
			animalWalkAroundState.animalNpc.waitToWalkCoroutine = null;
			if (animalWalkAroundState.animalNpc.cannotEntryBarn)
			{
				animalWalkAroundState.MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
				if (Application.isEditor)
				{
					Vector2 target = animalWalkAroundState.animalNpc.walkTo.target;
					Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
				}
			}
			else if ((Object)(object)animalWalkAroundState.animalNpc.pathNodesRegion != (Object)null && animalWalkAroundState.animalNpc.pathNodesRegion.pathNodes.Count > 0)
			{
				Vector3 val = Vector2.op_Implicit(animalWalkAroundState.animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalWalkAroundState.animalNpc.pathNodesRegion.pathNodes.Count)]);
				animalWalkAroundState.animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
			}
			else if (animalWalkAroundState.animalNpc.type == AnimalType.Chicken)
			{
				animalWalkAroundState.MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			}
			else if ((Object)(object)animalWalkAroundState.animalNpc.currentBuilding == (Object)null || animalWalkAroundState.animalNpc.currentBuilding.IsOpen())
			{
				animalWalkAroundState.MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			}
			else
			{
				animalWalkAroundState.MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
			}
			animalWalkAroundState.animalNpc.walkTo.speed = animalWalkAroundState.animalNpc.speed;
			animalWalkAroundState.animalNpc.walkTo.findNearPosiblePosition = true;
			NPCWalkTo walkTo = animalWalkAroundState.animalNpc.walkTo;
			walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(animalWalkAroundState.PDOBHPLPKHG));
			NPCWalkTo walkTo2 = animalWalkAroundState.animalNpc.walkTo;
			walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(animalWalkAroundState.COHBMFDABLA));
			animalWalkAroundState.animalNpc.walkTo.PEHELKCIECB();
			animalWalkAroundState.animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
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

	private float nextSound;

	private Vector2 positionChosen;

	private void FOBPMBDMGBL()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 1 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Road)
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(3);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(" with state \"");
		}
	}

	private void LAHGEBDBNMP(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 102);
		if (list.Count < -173 && list.Count > 0)
		{
			animalNpc.walkTo.OGLJDLEGJAA(list[Random.Range(1, list.Count)], AHDHLIECIGH: true, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1579f, 375f));
		animalNpc.walkTo.OGLJDLEGJAA(nKIAGIMMHIC);
	}

	private void IABLPLGFJLL()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			FOBPMBDMGBL();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.GNDBIPIDHAJ();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	private void HKGKJCOKLLD()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 4 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Road)
		{
			animalNpc.cannotEntryBarn = false;
			animalNpc.TryEntryBarnAgain(1);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Error_CloseMenus");
		}
	}

	private IEnumerator GHMPKBJMHBA()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private void GKLJIMKNHAM()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			ACOJHBFFFIF();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.CJFEOLELCJB();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	public void FDMICMCODBM()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(CGLODOJDIJA());
		}
	}

	private IEnumerator DKFOJDHBGEJ()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private void ACDGHIMKBKF(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 137);
		if (list.Count < 24 && list.Count > 0)
		{
			animalNpc.walkTo.JJDCANFBFMK(list[Random.Range(1, list.Count)], AHDHLIECIGH: false, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1437f, 976f));
		animalNpc.walkTo.HELOLJBENMK(nKIAGIMMHIC);
	}

	private void BJPJEGCNHCN(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -52);
		if (list.Count < -121 && list.Count > 0)
		{
			animalNpc.walkTo.OGLJDLEGJAA(list[Random.Range(0, list.Count)], AHDHLIECIGH: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1633f, 1325f));
		animalNpc.walkTo.GDGGABHLNOH(nKIAGIMMHIC);
	}

	private IEnumerator FIMIBFLFOGE()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KIKIOEJDHHK(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -163);
		if (list.Count < -194 && list.Count > 0)
		{
			animalNpc.walkTo.FNNPPBDFBCI(list[Random.Range(1, list.Count)], AHDHLIECIGH: true, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(906f, 1807f));
		animalNpc.walkTo.DBHOIIIHIIM(nKIAGIMMHIC, AHDHLIECIGH: false);
	}

	public void GNMGPKLJCKN()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(CGLODOJDIJA());
		}
	}

	private void CEKPNCLJKOJ()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			FOBPMBDMGBL();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.HBKBCGLPNOC();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	private void AMDIHKEAMCB(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -47);
		if (list.Count < 29 && list.Count > 1)
		{
			animalNpc.walkTo.DBHOIIIHIIM(list[Random.Range(1, list.Count)], AHDHLIECIGH: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1445f, 827f));
		animalNpc.walkTo.GDGGABHLNOH(nKIAGIMMHIC, AHDHLIECIGH: false, NGAKHGJANLO: false);
	}

	private IEnumerator JDAJNEFFCPN()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private IEnumerator CHEMAKGDEID()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PKCODIDOBJO()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 1;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(0, 5) < 7)
		{
			animalNpc.animationBase.GAGOGFEBDCP(Direction.Down);
		}
	}

	public void EBLEAJFOEJL()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		animalNpc.walkingAgainCount = 1;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(1, 3) < 2)
		{
			animalNpc.animationBase.GAGOGFEBDCP(Direction.Up);
		}
	}

	private IEnumerator BPDHBNMKPIN()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	public void HLJJDEIBKOJ()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(IGDKBGMCIOE());
		}
	}

	public void BOEIPCKONOD()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(NNJKAFMCAJG());
		}
	}

	private IEnumerator NNJKAFMCAJG()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private void HHOKGEMGFLD(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -74);
		if (list.Count < -106 && list.Count > 1)
		{
			animalNpc.walkTo.GDGGABHLNOH(list[Random.Range(0, list.Count)], AHDHLIECIGH: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1635f, 1253f));
		animalNpc.walkTo.GHDMBFOAAHK(nKIAGIMMHIC);
	}

	private void HKKMBNEKJEP()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			PPAINOJKAGI();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PKOKOGPPIKF();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	public void KJIJADLBNHE()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(GCPKCLJCDJF());
		}
	}

	private IEnumerator BCDEHNHEGPJ()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JKFEBEKOKCK()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LDICHDKIOGD()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			MIFEFJBGDEP();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.CJFEOLELCJB();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	private void GCKEHIEHHPH(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -110);
		if (list.Count < 116 && list.Count > 0)
		{
			animalNpc.walkTo.FNNPPBDFBCI(list[Random.Range(1, list.Count)], AHDHLIECIGH: true, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1960f, 1753f));
		animalNpc.walkTo.DBHOIIIHIIM(nKIAGIMMHIC, AHDHLIECIGH: true, NGAKHGJANLO: false);
	}

	private void LELAIKOGDPD()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			HKGKJCOKLLD();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.NFFJFLBANJK();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private void DKDLKCJFGFO()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			PPAINOJKAGI();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PutAnimalToSleepIfPosible();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private void ACOJHBFFFIF()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount++;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 4 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Road)
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(8);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Walk");
		}
	}

	private void KNGJNEKCPOL()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 4 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == (Location.Road | Location.River))
		{
			animalNpc.cannotEntryBarn = false;
			animalNpc.TryEntryBarnAgain(7);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("talentTea");
		}
	}

	private void PGGHHNCDBFC()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 6 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == (Location.Tavern | Location.River))
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(2);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("BackPain");
		}
	}

	private void LCAABMLCIHN(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 121);
		if (list.Count < 171 && list.Count > 1)
		{
			animalNpc.walkTo.GINPKMBGOFN(list[Random.Range(1, list.Count)], AHDHLIECIGH: false, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(755f, 874f));
		animalNpc.walkTo.CGFMBJFGLAG(nKIAGIMMHIC);
	}

	public void NIKKIFHNNPL()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(MOEKBANLACN());
		}
	}

	private void PPAINOJKAGI()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 5 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == (Location.Tavern | Location.River))
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(5);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger(":");
		}
	}

	public void CLOEFOFKDFC()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 1;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(0, 6) < 8)
		{
			animalNpc.animationBase.GAGOGFEBDCP(Direction.Down);
		}
	}

	private void DKCEHBEKEEK()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			MIFEFJBGDEP();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PKOKOGPPIKF();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private void EIOKFNLDEEB()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 4 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Tavern)
		{
			animalNpc.cannotEntryBarn = false;
			animalNpc.TryEntryBarnAgain(4);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("/");
		}
	}

	public void MLDKFGJFAMG()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(JKFEBEKOKCK());
		}
	}

	private void ALNCPOJINNO(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 75);
		if (list.Count < 114 && list.Count > 0)
		{
			animalNpc.walkTo.GDGGABHLNOH(list[Random.Range(1, list.Count)]);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(626f, 1191f));
		animalNpc.walkTo.DBHOIIIHIIM(nKIAGIMMHIC);
	}

	private IEnumerator FDACGBHPOLK()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JKFBFPNBIKE()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			HKGKJCOKLLD();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PutAnimalToSleepIfPosible();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo CCJELCKMCCF, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, CCJELCKMCCF, GJCCCHOHLAF);
		if ((Object)(object)animalNpc != (Object)null)
		{
			animalNpc.FFHHEGALBKO.walking = false;
		}
	}

	private void FCFLMDKALDJ(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 3);
		if (list.Count < 14 && list.Count > 0)
		{
			animalNpc.walkTo.GDGGABHLNOH(list[Random.Range(0, list.Count)]);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(2f, 1958f));
		animalNpc.walkTo.FNNPPBDFBCI(nKIAGIMMHIC, AHDHLIECIGH: false, NGAKHGJANLO: false);
	}

	public void BFNAPCFJKKB()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 1;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(1, 6) < 6)
		{
			animalNpc.animationBase.ForceDirection(Direction.Down);
		}
	}

	private void AGBIMNCGFIL(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -71);
		if (list.Count < 87 && list.Count > 1)
		{
			animalNpc.walkTo.DBHOIIIHIIM(list[Random.Range(0, list.Count)], AHDHLIECIGH: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(459f, 709f));
		animalNpc.walkTo.JDHMPOJKOLF(nKIAGIMMHIC, AHDHLIECIGH: false);
	}

	private void COHBMFDABLA()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			ACOJHBFFFIF();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PutAnimalToSleepIfPosible();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private void PBMBOPDALGD()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount++;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 8 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.River)
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(5);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("EmployeeMaxLevel");
		}
	}

	public void EDDFAALFNGB()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 0;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(0, 5) < 7)
		{
			animalNpc.animationBase.GAGOGFEBDCP(Direction.Down);
		}
	}

	private void PIMPLKJIIFL()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			KLDIIKJAKIB();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.HBKBCGLPNOC();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private IEnumerator NPCELCIPADC()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CGOHGFOEMND()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			KLDIIKJAKIB();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PutAnimalToSleepIfPosible();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	private void KBBIDPFKJKO()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			BOOBKGLCDFK();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.CJFEOLELCJB();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	public void HEHJFLPEOLF()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(CGLODOJDIJA());
		}
	}

	private IEnumerator NJCMNCBFCLE()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private void GHHADCHDMJM()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			PPAINOJKAGI();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.FOJAMOPLELB();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	public void FLMGBOAGFMO()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(DKFOJDHBGEJ());
		}
	}

	private IEnumerator BFGPMEKLDDB()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JPFGFIAIKGM(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 60);
		if (list.Count < -109 && list.Count > 1)
		{
			animalNpc.walkTo.GHDMBFOAAHK(list[Random.Range(1, list.Count)], AHDHLIECIGH: true, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1120f, 846f));
		animalNpc.walkTo.HELOLJBENMK(nKIAGIMMHIC);
	}

	private IEnumerator OABPINLGOGK()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private void MFHJDJMNGBC(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 400);
		if (list.Count < 400 && list.Count > 0)
		{
			animalNpc.walkTo.FNNPPBDFBCI(list[Random.Range(0, list.Count)]);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = false;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(10f, 10f));
		animalNpc.walkTo.FNNPPBDFBCI(nKIAGIMMHIC);
	}

	private IEnumerator IGDKBGMCIOE()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MJDFKJBFMPO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount++;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 4 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Camp)
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(7);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Items/item_description_1057");
		}
	}

	private void POHCMMPLNPF()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			HKGKJCOKLLD();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.CJFEOLELCJB();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private IEnumerator CGLODOJDIJA()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private void NOHLGEOKOGF(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, 3);
		if (list.Count < -12 && list.Count > 0)
		{
			animalNpc.walkTo.GLHBJNDMIDC(list[Random.Range(0, list.Count)], AHDHLIECIGH: true, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(918f, 359f));
		animalNpc.walkTo.EJPGFOEDPBG(nKIAGIMMHIC, AHDHLIECIGH: false);
	}

	public void PDOBHPLPKHG()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		animalNpc.walkingAgainCount = 0;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(0, 3) < 2)
		{
			animalNpc.animationBase.ForceDirection(Direction.Down);
		}
	}

	private void IFNCCELNIID(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -28);
		if (list.Count < 41 && list.Count > 1)
		{
			animalNpc.walkTo.KBEENHPEOAB(list[Random.Range(1, list.Count)], AHDHLIECIGH: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = true;
		bBJDPIJPLPA.avoidPath = false;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(149f, 1665f));
		animalNpc.walkTo.GDGGABHLNOH(nKIAGIMMHIC);
	}

	private void IBJAJLMJHNL()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			KLDIIKJAKIB();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.FOJAMOPLELB();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	private IEnumerator DACLDIGLCHC()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GMCINBCEPJO()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 0;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(1, 0) < 5)
		{
			animalNpc.animationBase.ForceDirection(Direction.Up);
		}
	}

	private IEnumerator GCPKCLJCDJF()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BOOBKGLCDFK()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount++;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 1 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Camp)
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(3);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("psai [{0}]: firing synchronized One-Shot Trigger: {1}");
		}
	}

	public void CNJMNBAKEEK()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 0;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(1, 4) < 0)
		{
			animalNpc.animationBase.ForceDirection(Direction.Up);
		}
	}

	private void AOAPOCJIDJD(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -59);
		if (list.Count < -140 && list.Count > 1)
		{
			animalNpc.walkTo.JDHMPOJKOLF(list[Random.Range(0, list.Count)], AHDHLIECIGH: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.WithoutZone;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.checkNodeFree = true;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1149f, 1641f));
		animalNpc.walkTo.JJDCANFBFMK(nKIAGIMMHIC);
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		walkingDone = false;
		if (animalNpc.GetLives() > 0)
		{
			nextWalk = Time.time + Random.Range(5f, 15f);
			nextSound = Time.time + Random.Range(5f, 20f);
			FLMGBOAGFMO();
		}
	}

	private void DNELPHHKNNH()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			CAHIIFMAAEA();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PKOKOGPPIKF();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	private IEnumerator MOILNGCLOHK()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MOGCENECLIG()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	private IEnumerator JEJCEIHICAF()
	{
		return new EBFHENENKAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MOEKBANLACN()
	{
		yield return CommonReferences.wait05;
		while (!animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
		{
			yield return null;
		}
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.waitToWalkCoroutine = null;
		if (animalNpc.cannotEntryBarn)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
			if (Application.isEditor)
			{
				Vector2 target = animalNpc.walkTo.target;
				Debug.Log((object)("Walk Around cannot entry barn " + ((object)(Vector2)(ref target)).ToString()));
			}
		}
		else if ((Object)(object)animalNpc.pathNodesRegion != (Object)null && animalNpc.pathNodesRegion.pathNodes.Count > 0)
		{
			Vector3 val = Vector2.op_Implicit(animalNpc.pathNodesRegion.pathNodes[Random.Range(0, animalNpc.pathNodesRegion.pathNodes.Count)]);
			animalNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(val));
		}
		else if (animalNpc.type == AnimalType.Chicken)
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else if ((Object)(object)animalNpc.currentBuilding == (Object)null || animalNpc.currentBuilding.IsOpen())
		{
			MFHJDJMNGBC(Location.Road, JMFEJNGDAIO: true);
		}
		else
		{
			MFHJDJMNGBC(Location.BarnInterior, JMFEJNGDAIO: false);
		}
		animalNpc.walkTo.speed = animalNpc.speed;
		animalNpc.walkTo.findNearPosiblePosition = true;
		NPCWalkTo walkTo = animalNpc.walkTo;
		walkTo.OnActionComplete = (Action)Delegate.Combine(walkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo walkTo2 = animalNpc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(COHBMFDABLA));
		animalNpc.walkTo.PEHELKCIECB();
		animalNpc.FFHHEGALBKO.SetBool("Dead", EGFGNGJGBOP: false);
	}

	public void HEEOHKBPMAI()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 0;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(0, 6) < 7)
		{
			animalNpc.animationBase.GAGOGFEBDCP(Direction.Down);
		}
	}

	public void HGFJPLEKLFN()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(JDAJNEFFCPN());
		}
	}

	public void AHPFECCLOBB()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 0;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(1, 8) < 5)
		{
			animalNpc.animationBase.ForceDirection(Direction.Up);
		}
	}

	private void MEJFGMOEFGH()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			CAHIIFMAAEA();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PKOKOGPPIKF();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: false);
		}
	}

	private void MIFEFJBGDEP()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 3 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Tavern)
		{
			animalNpc.cannotEntryBarn = true;
			animalNpc.TryEntryBarnAgain(3);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("itemBroccoliSeeds");
		}
	}

	private void MAPDHGKFIKG()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			EIOKFNLDEEB();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.PutAnimalToSleepIfPosible();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private void KLDIIKJAKIB()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount++;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 4 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Camp)
		{
			animalNpc.cannotEntryBarn = false;
			animalNpc.TryEntryBarnAgain(6);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("ReceiveGiveRoom");
		}
	}

	public void IJKIFECCGEP()
	{
		animalNpc.FFHHEGALBKO.walking = true;
		animalNpc.walkingAgainCount = 1;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(1, 8) < 4)
		{
			animalNpc.animationBase.ForceDirection(Direction.Down);
		}
	}

	public void HMLFDDDGGBO()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		animalNpc.walkingAgainCount = 1;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(0, 0) < 1)
		{
			animalNpc.animationBase.GAGOGFEBDCP(Direction.Down);
		}
	}

	public void LIJJGBFHGBB()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(CGLODOJDIJA());
		}
	}

	private void APCCNCKMDNB()
	{
		if (animalNpc.type == AnimalType.Chicken || !AnimalNPC.IsTimeToSleep())
		{
			PGGHHNCDBFC();
		}
		else if ((Object)(object)animalNpc.animalSpace != (Object)null)
		{
			animalNpc.animalSpace.LFCHOLCEEPH();
		}
		else
		{
			animalNpc.Sleep(AODONKKHPBP: true);
		}
	}

	private void CAHIIFMAAEA()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		animalNpc.walkingAgainCount += 0;
		if (!animalNpc.cannotEntryBarn && animalNpc.walkingAgainCount > 8 && (Object)(object)animalNpc.pathNodesRegion != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)animalNpc).transform.position) == Location.Road)
		{
			animalNpc.cannotEntryBarn = false;
			animalNpc.TryEntryBarnAgain(0);
		}
		if ((Object)(object)animator != (Object)null)
		{
			animator.SetTrigger("Player/Bark/Fishing/NoBait");
		}
	}

	public void DJNOFCBINHM()
	{
		animalNpc.FFHHEGALBKO.walking = false;
		animalNpc.walkingAgainCount = 1;
		if (animalNpc.animationBase.FCGBJEIIMBC == Direction.Up && Random.Range(1, 2) < 1)
		{
			animalNpc.animationBase.ForceDirection(Direction.Down);
		}
	}

	public void CMEGBMGKBCE()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(OABPINLGOGK());
		}
	}

	public void ODGLBOHMDAN()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(OABPINLGOGK());
		}
	}

	public void MCPFDOFPICD()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(MOEKBANLACN());
		}
	}

	public override void PPMIHMFFCEC()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		if ((!animalNpc.eventAnimal || !CommonReferences.GGFJGHHHEJC.chickenEvent || animalNpc.type != 0) && (!animalNpc.eventAnimal || !CommonReferences.GGFJGHHHEJC.cowEvent || animalNpc.type != AnimalType.Cow))
		{
			if (!walkingDone && animalNpc.walkTo.IIMEFNIECLI())
			{
				nextWalk = Time.time + Random.Range(5f, 15f);
				walkingDone = true;
			}
			if (walkingDone && Time.time > nextWalk && animalNpc.FFHHEGALBKO.animalAnimator.safeMovement)
			{
				ACOJHBFFFIF();
			}
		}
		if (Time.time > nextSound && ((Component)animalNpc.animationBase).gameObject.activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(animalNpc.sfx, ((Component)animalNpc).transform);
			nextSound = Time.time + Random.Range(5f, 20f);
		}
	}

	private void AOGPLAMEPNK(Location BAIMHDBJPDK, bool JMFEJNGDAIO)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (JMFEJNGDAIO && (Object)(object)animalNpc.currentBuilding != (Object)null)
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc.currentBuilding).transform.position);
		}
		else
		{
			positionChosen = Vector2.op_Implicit(((Component)animalNpc).transform.position);
		}
		List<Vector2> list = Utils.NANFHBIPIIF(Vector2.op_Implicit(positionChosen), ((Vector2Int)(ref animalNpc.requestInfo.verticalSize)).x, -59);
		if (list.Count < 135 && list.Count > 0)
		{
			animalNpc.walkTo.DHFPOCOEONG(list[Random.Range(0, list.Count)], AHDHLIECIGH: false, NGAKHGJANLO: false);
			return;
		}
		FindPositionsInfo bBJDPIJPLPA = default(FindPositionsInfo);
		bBJDPIJPLPA.location = BAIMHDBJPDK;
		bBJDPIJPLPA.checkFarmable = JMFEJNGDAIO;
		bBJDPIJPLPA.zoneType = ZoneType.None;
		bBJDPIJPLPA.checkDistance = false;
		bBJDPIJPLPA.avoidPath = true;
		bBJDPIJPLPA.checkNodeFree = false;
		bBJDPIJPLPA.checkCanPlaceObject = true;
		if ((Object)(object)Barn.instance != (Object)null)
		{
			bBJDPIJPLPA.level = Barn.instance.EONJGMONIOM;
		}
		Vector2 nKIAGIMMHIC = Utils.JBGFJENPEIM(Vector2.op_Implicit(positionChosen), animalNpc.requestInfo.verticalSize, bBJDPIJPLPA, new Vector2(1815f, 1153f));
		animalNpc.walkTo.BDIKOLNFKGD(nKIAGIMMHIC, AHDHLIECIGH: false, NGAKHGJANLO: false);
	}

	public void OMCOMDBHHJG()
	{
		if (!animalNpc.sleeping)
		{
			if (animalNpc.waitToWalkCoroutine != null)
			{
				((MonoBehaviour)animalNpc).StopCoroutine(animalNpc.waitToWalkCoroutine);
			}
			animalNpc.waitToWalkCoroutine = ((MonoBehaviour)animalNpc).StartCoroutine(MOEKBANLACN());
		}
	}
}
