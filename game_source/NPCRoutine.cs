using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class NPCRoutine : MonoBehaviour
{
	public enum RoutineAction
	{
		Walk,
		WalkAround,
		WaitForEvent,
		Bark,
		Dialogue,
		Animation,
		Spawn,
		Disable,
		Teleport,
		Enable,
		ResetAnimation
	}

	[Flags]
	public enum Day
	{
		None = 0,
		Mon = 1,
		Tue = 2,
		Wed = 4,
		Thurs = 8,
		Fri = 0x10,
		Sat = 0x20,
		Sun = 0x40,
		All = 0x7F
	}

	public enum StepEnd
	{
		None,
		Delay,
		AnimationEnd,
		WaitEvent
	}

	[Serializable]
	public struct Routine
	{
		public string name;

		public RoutineConfiguration info;
	}

	[Serializable]
	public class RoutineConfiguration
	{
		public Day day = Day.All;

		public bool priority;

		public bool noStopRoutine;

		public bool constant;

		public bool tutorialRoutine;

		public bool instantiate;

		public GameObject prefab;

		public Location location;

		public List<Hours> hours;

		public List<Step> stepsList;

		public bool npcEvent;

		public List<NPCRoutine> eventNpcList;

		public bool npcBarkEvent;

		public List<DialogueNPCBase> barkEventNpcList;
	}

	[Serializable]
	public struct Step
	{
		public RoutineAction action;

		public Transform target;

		public bool selectDir;

		public bool noNearestNode;

		public Direction direction;

		public Transform[] targets;

		public Direction[] directions;

		public string parameterName;

		public float minRandom;

		public float maxRandom;

		public bool collider;

		public bool parent;

		public Transform parentTransform;

		public StepEnd stepEnd;

		public float delay;
	}

	[Serializable]
	public struct Hours
	{
		public float startHour;

		public bool random;

		public float finalStartHour;

		public bool actionCompleted;
	}

	[CompilerGenerated]
	private sealed class CMHIMHKDNEN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NPCRoutine _003C_003E4__this;

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
		public CMHIMHKDNEN(int _003C_003E1__state)
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
			NPCRoutine nPCRoutine = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (nPCRoutine.barkEventBusy || nPCRoutine.npc.inBark)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (nPCRoutine.currentRoutine != -1 && nPCRoutine.routines[nPCRoutine.currentRoutine].info.stepsList[nPCRoutine.currentStep].action == RoutineAction.Animation)
			{
				if (nPCRoutine.routines[nPCRoutine.currentRoutine].info.npcEvent)
				{
					for (int i = 0; i < nPCRoutine.routines[nPCRoutine.currentRoutine].info.eventNpcList.Count; i++)
					{
						if (nPCRoutine.routines[nPCRoutine.currentRoutine].info.eventNpcList[i].animController.CKDIBPCNJMA != -1)
						{
							nPCRoutine.routines[nPCRoutine.currentRoutine].info.eventNpcList[i].animController.StopAnimation();
						}
						nPCRoutine.routines[nPCRoutine.currentRoutine].info.eventNpcList[i].OGFOEKELKEJ();
					}
				}
				if (nPCRoutine.routines[nPCRoutine.currentRoutine].info.stepsList[nPCRoutine.currentStep].action == RoutineAction.Animation && nPCRoutine.routines[nPCRoutine.currentRoutine].info.stepsList[nPCRoutine.currentStep].collider)
				{
					((Behaviour)nPCRoutine.npc.visualCollider).enabled = false;
				}
				nPCRoutine.OGFOEKELKEJ();
			}
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

	[CompilerGenerated]
	private sealed class HEHDDEPIHBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NPCRoutine _003C_003E4__this;

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
		public HEHDDEPIHBI(int _003C_003E1__state)
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
			NPCRoutine nPCRoutine = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (nPCRoutine.currentRoutine == -1)
				{
					goto IL_0081;
				}
			}
			if (nPCRoutine.routines[nPCRoutine.currentRoutine].info.eventNpcList.Any((NPCRoutine npcRoutine) => npcRoutine.currentRoutine != -1 && npcRoutine.currentStep != -1 && npcRoutine.routines[npcRoutine.currentRoutine].info.stepsList[npcRoutine.currentStep].action == RoutineAction.Walk))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_0081;
			IL_0081:
			nPCRoutine.currentStep++;
			if (nPCRoutine.currentStep < nPCRoutine.routines[nPCRoutine.currentRoutine].info.stepsList.Count)
			{
				nPCRoutine.ONDHBDBMMLN(nPCRoutine.routines[nPCRoutine.currentRoutine].info.stepsList[nPCRoutine.currentStep]);
			}
			else
			{
				nPCRoutine.StopRoutine();
			}
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

	public DialogueNPCBase npc;

	public AnimationController animController;

	public int currentRoutine = -1;

	public int currentStep = -1;

	public Transform spawnPosition;

	public List<Routine> routines;

	[HideInInspector]
	public bool busy;

	[HideInInspector]
	public bool specialEvent;

	[HideInInspector]
	public bool barkEventBusy;

	public bool inTutorial;

	public string barkReset;

	[HideInInspector]
	public bool noDisableOnReset;

	public List<Transform> possibleParents = new List<Transform>();

	private bool JIHGNGJANBI;

	private float EBFHLIJCFOF;

	private float NDJAMMFIHDE;

	private int PJJKJDJLGHM = -1;

	private int MCLFJLMFLEP = -1;

	private int CNJIGFKGOMK = -1;

	private float HGKLIFBDLEC;

	private float FLHBPHPKIML;

	private int FEGCAPOBGPH;

	private int NALIKBGNKNG;

	private int HHNDAHJAEEH = -1;

	private bool NKCDODIDAJC;

	private Direction OOPPAOMELCM;

	private Direction PAAFKBPAPHB;

	private bool GAKKHFFPMHE;

	private int HFFLGFGFEBN;

	private Coroutine AOMHMCMMFJO;

	[HideInInspector]
	public bool loveEvent;

	[HideInInspector]
	public bool botherEvent;

	private int PLAKHJJJMAH;

	private int AAOPFLKEKKM;

	private Hours IEGCEEEINDL;

	public Action<NPCRoutine> NPCEnabled = delegate
	{
	};

	public Action<NPCRoutine> NPCDisabled = delegate
	{
	};

	public Action<NPCRoutine, string> NPCParentChanged = delegate
	{
	};

	public Action<NPCRoutine, float, float> NPCPositionUpdated = delegate
	{
	};

	private NPCWalkTo CBOBNOLJEJG
	{
		get
		{
			if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
			{
				return npc.walkTo;
			}
			Debug.LogError((object)("NPCWalkTo is null in NPCRoutine. Make sure the routine " + ((Object)((Component)this).gameObject).name + " has NPC attached"), (Object)(object)((Component)this).gameObject);
			return null;
		}
	}

	private bool IEIBPLHADJG(Routine BINIPDHAEJI)
	{
		if ((Object)(object)WorldTime.GetInstance() == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < BINIPDHAEJI.info.hours.Count; i++)
		{
			PLAKHJJJMAH = (int)BINIPDHAEJI.info.hours[i].startHour;
			AAOPFLKEKKM = (int)((BINIPDHAEJI.info.hours[i].startHour - (float)PLAKHJJJMAH) * 60f);
			if (!BINIPDHAEJI.info.hours[i].actionCompleted && (((uint)BINIPDHAEJI.info.day & (uint)(int)Mathf.Pow(2f, (float)WorldTime.NOAOJJLNHJJ.day)) != 0 || (BINIPDHAEJI.info.tutorialRoutine && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 116)) && WorldTime.NOAOJJLNHJJ.hour >= PLAKHJJJMAH && WorldTime.NOAOJJLNHJJ.min >= AAOPFLKEKKM && ((float)WorldTime.NOAOJJLNHJJ.hour < BINIPDHAEJI.info.hours[i].finalStartHour || BINIPDHAEJI.name == "Sleep"))
			{
				if (BINIPDHAEJI.info.npcBarkEvent && BINIPDHAEJI.info.barkEventNpcList.Any((DialogueNPCBase npcRoutine) => (Object)(object)npcRoutine.GetInstance() == (Object)null))
				{
					return false;
				}
				IEGCEEEINDL = BINIPDHAEJI.info.hours[i];
				IEGCEEEINDL.actionCompleted = true;
				BINIPDHAEJI.info.hours[i] = IEGCEEEINDL;
				return true;
			}
			if (!BINIPDHAEJI.info.hours[i].actionCompleted && (float)WorldTime.NOAOJJLNHJJ.hour > BINIPDHAEJI.info.hours[i].finalStartHour)
			{
				IEGCEEEINDL = BINIPDHAEJI.info.hours[i];
				IEGCEEEINDL.actionCompleted = true;
				BINIPDHAEJI.info.hours[i] = IEGCEEEINDL;
				return false;
			}
		}
		return false;
	}

	private void BBGEEFFODFA()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		busy = true;
		animController.StopAnimNow();
		StopRoutine();
		if (!noDisableOnReset)
		{
			((Component)npc).transform.position = spawnPosition.position;
			DisableNPC();
		}
		if (!string.IsNullOrEmpty(barkReset))
		{
			DialogueLua.SetVariable(barkReset, (object)0);
		}
		DialogueLua.SetVariable("[ConfigureActivePuzzle] - No current Puzzle asignado", (object)1);
		for (int i = 0; i < routines.Count; i += 0)
		{
			if (routines[i].info.hours.Count > 0)
			{
				for (int j = 0; j < routines[i].info.hours.Count; j++)
				{
					IEGCEEEINDL = routines[i].info.hours[j];
					IEGCEEEINDL.actionCompleted = false;
					routines[i].info.hours[j] = IEGCEEEINDL;
				}
			}
		}
	}

	private void EDBDJLPHGGJ()
	{
		if (!GameManager.CIOEICMHCCK && !inTutorial && !OnlineManager.ClientOnline())
		{
			BBGEEFFODFA();
		}
	}

	private void HEOAIGHOLLD()
	{
		if (!GameManager.CIOEICMHCCK && !inTutorial && !OnlineManager.ClientOnline())
		{
			PGMHFMAJMGD();
		}
	}

	public void EnableNPC()
	{
		npc.content.SetActive(true);
		NPCEnabled?.Invoke(this);
	}

	private void DIKPOHPGNLG()
	{
		if (!npc.inUse || (npc.inUse && loveEvent))
		{
			CBOBNOLJEJG.IIMEFNIECLI();
		}
	}

	public void Busy()
	{
		if (!busy)
		{
			FEGCAPOBGPH = currentRoutine;
			NALIKBGNKNG = currentStep;
			JIHGNGJANBI = false;
			if (animController.CKDIBPCNJMA != -1 && !animController.animations[animController.CKDIBPCNJMA].noStop)
			{
				animController.StopAnimation();
			}
			if (currentRoutine != -1 && !routines[currentRoutine].info.noStopRoutine)
			{
				StopRoutine();
			}
			busy = true;
		}
	}

	private void PGPMMPKMCDM(Step ACFILKKNODL)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		switch (ACFILKKNODL.action)
		{
		case RoutineAction.Walk:
			CCAPKALNPFN(((Component)this).transform.parent);
			if (Vector3.Distance(((Component)npc).transform.position, ACFILKKNODL.target.position) > 115f)
			{
				GAKKHFFPMHE = ACFILKKNODL.noNearestNode;
				CJFIDPLGOMB(Vector2.op_Implicit(ACFILKKNODL.target.position), CCBHHDMLHHJ: false, Direction.Up);
			}
			else
			{
				PDOBHPLPKHG();
			}
			break;
		case RoutineAction.WalkAround:
			ANHHCLIBPPL(((Component)this).transform.parent);
			HFFLGFGFEBN = Random.Range(0, ACFILKKNODL.targets.Length);
			GAKKHFFPMHE = ACFILKKNODL.noNearestNode;
			Walk(Vector2.op_Implicit(ACFILKKNODL.targets[HFFLGFGFEBN].position), CCBHHDMLHHJ: false, Direction.Up);
			if (FLHBPHPKIML == 93f)
			{
				FLHBPHPKIML = Time.time + ACFILKKNODL.delay;
			}
			break;
		case RoutineAction.Animation:
			animController.KJACCELPLGL(ACFILKKNODL.parameterName, ACFILKKNODL.stepEnd == StepEnd.None, ACFILKKNODL.delay);
			if (ACFILKKNODL.collider)
			{
				((Behaviour)npc.visualCollider).enabled = true;
			}
			if (ACFILKKNODL.stepEnd == (StepEnd)4)
			{
				CNJIGFKGOMK = currentStep;
				BADBBAKKILH();
			}
			break;
		case RoutineAction.Bark:
			PJJKJDJLGHM = currentStep;
			EBFHLIJCFOF = Time.time + 481f;
			BADBBAKKILH();
			break;
		case RoutineAction.Dialogue:
			MCLFJLMFLEP = currentStep;
			NDJAMMFIHDE = Time.time + 1696f;
			BADBBAKKILH();
			break;
		case RoutineAction.Disable:
			DisableNPC();
			BADBBAKKILH();
			break;
		case RoutineAction.Teleport:
			if ((Object)(object)ACFILKKNODL.target != (Object)null)
			{
				((Component)npc).transform.position = ACFILKKNODL.target.position;
			}
			if (ACFILKKNODL.parent)
			{
				CCAPKALNPFN(ACFILKKNODL.parentTransform);
			}
			else
			{
				CCAPKALNPFN(((Component)this).transform.parent);
			}
			if (ACFILKKNODL.selectDir)
			{
				((MonoBehaviour)this).StartCoroutine(PMADEFMAGPH(ACFILKKNODL.direction));
			}
			BADBBAKKILH();
			break;
		case RoutineAction.Enable:
			EnableNPC();
			BADBBAKKILH();
			break;
		case RoutineAction.ResetAnimation:
			animController.ENCKDMLFHEA();
			if (ACFILKKNODL.delay != 278f)
			{
				((MonoBehaviour)this).StartCoroutine(DKPPANMFFLE(ACFILKKNODL.delay + Time.time));
			}
			else
			{
				OGFOEKELKEJ();
			}
			break;
		}
		NPCPositionUpdated?.Invoke(this, ((Component)npc).transform.position.x, ((Component)npc).transform.position.y);
	}

	private void DJHLPCMMFPO()
	{
		if (!npc.inUse || (npc.inUse && loveEvent))
		{
			CBOBNOLJEJG.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void MMAMJDLONFA()
	{
		if (!GameManager.ILMDHNFFIKH() && !inTutorial && !OnlineManager.ClientOnline())
		{
			EANIEJJHHEP();
		}
	}

	private void PDCLHMGJIMK()
	{
		if (routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.WalkAround)
		{
			if (HGKLIFBDLEC != 0f && Time.time > HGKLIFBDLEC)
			{
				ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
				HGKLIFBDLEC = 0f;
			}
			if (FLHBPHPKIML != 0f && Time.time > FLHBPHPKIML)
			{
				FLHBPHPKIML = 0f;
				OGFOEKELKEJ();
			}
		}
	}

	public void SetNPCPosition(float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		npc.onlineNPC.SetPosition(PEAKHLPNPHI, NPDBPKNHKPC);
	}

	public void IAMFOLPDNPJ()
	{
		npc.content.SetActive(true);
		NPCEnabled?.Invoke(this);
	}

	private void Start()
	{
		OEOLKCOOAID();
	}

	private void CEAHNNJGJCL()
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		if (MCLFJLMFLEP == -1)
		{
			return;
		}
		if (currentStep > MCLFJLMFLEP + 1)
		{
			NDJAMMFIHDE = 0f;
			MCLFJLMFLEP = -1;
		}
		else
		{
			if (NDJAMMFIHDE == 0f || Time.time < NDJAMMFIHDE)
			{
				return;
			}
			if (MainUI.IsAnyUIOpen(1) || MainUI.IsAnyUIOpen(2))
			{
				if (Time.time > NDJAMMFIHDE)
				{
					NDJAMMFIHDE = Time.time + 5f;
				}
				return;
			}
			for (int i = 0; i < routines[currentRoutine].info.stepsList.Count; i++)
			{
				if (routines[currentRoutine].info.stepsList[i].action != RoutineAction.Dialogue)
				{
					continue;
				}
				if (routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.WalkAround && routines[currentRoutine].info.stepsList[currentStep].action != RoutineAction.WalkAround && !CBOBNOLJEJG.isActive)
				{
					NDJAMMFIHDE = Time.time + 5f;
					continue;
				}
				if (!npc.inUse && npc.canTalk)
				{
					if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)npc).transform.position)) < 50f && Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)npc).transform.position)) > 3f)
					{
						npc.dialogue.conversation = routines[currentRoutine].info.stepsList[MCLFJLMFLEP].parameterName;
						npc.barkDialogue = true;
						npc.SelectDialogueUI();
						npc.main = true;
						npc.dialogue.OnUse();
						npc.onlineBarkDialogue = true;
					}
					NDJAMMFIHDE = Time.time + Random.Range(routines[currentRoutine].info.stepsList[i].minRandom, routines[currentRoutine].info.stepsList[i].maxRandom);
					break;
				}
				NDJAMMFIHDE = Time.time + 5f;
			}
		}
	}

	private IEnumerator FOMEEELLODD()
	{
		while (barkEventBusy || npc.inBark)
		{
			yield return null;
		}
		if (currentRoutine == -1 || routines[currentRoutine].info.stepsList[currentStep].action != RoutineAction.Animation)
		{
			yield break;
		}
		if (routines[currentRoutine].info.npcEvent)
		{
			for (int i = 0; i < routines[currentRoutine].info.eventNpcList.Count; i++)
			{
				if (routines[currentRoutine].info.eventNpcList[i].animController.CKDIBPCNJMA != -1)
				{
					routines[currentRoutine].info.eventNpcList[i].animController.StopAnimation();
				}
				routines[currentRoutine].info.eventNpcList[i].OGFOEKELKEJ();
			}
		}
		if (routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.Animation && routines[currentRoutine].info.stepsList[currentStep].collider)
		{
			((Behaviour)npc.visualCollider).enabled = false;
		}
		OGFOEKELKEJ();
	}

	private void EFJACNJMJLD()
	{
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		if (PJJKJDJLGHM == -1)
		{
			return;
		}
		if (currentStep > PJJKJDJLGHM + 1)
		{
			EBFHLIJCFOF = 0f;
			PJJKJDJLGHM = -1;
			return;
		}
		if (routines[currentRoutine].info.npcEvent)
		{
			barkEventBusy = false;
			for (int i = 0; i < routines[currentRoutine].info.eventNpcList.Count; i++)
			{
				if (routines[currentRoutine].info.eventNpcList[i].npc.inBark)
				{
					barkEventBusy = true;
					break;
				}
			}
			if (!barkEventBusy && !npc.inBark)
			{
				npc.inEvent = false;
				routines[currentRoutine].info.eventNpcList.ForEach(delegate(NPCRoutine npcRoutine)
				{
					npcRoutine.npc.inEvent = false;
				});
			}
			else
			{
				npc.inEvent = true;
				routines[currentRoutine].info.eventNpcList.ForEach(delegate(NPCRoutine npcRoutine)
				{
					npcRoutine.npc.inEvent = true;
				});
			}
		}
		if (routines[currentRoutine].info.npcBarkEvent)
		{
			barkEventBusy = routines[currentRoutine].info.barkEventNpcList.Any((DialogueNPCBase npcRoutine) => npcRoutine.GetInstance().inBark);
			if (!barkEventBusy && !npc.inBark)
			{
				npc.inEvent = false;
				routines[currentRoutine].info.barkEventNpcList.ForEach(delegate(DialogueNPCBase npcRoutine)
				{
					npcRoutine.GetInstance().inEvent = false;
				});
			}
			else
			{
				npc.inEvent = true;
				routines[currentRoutine].info.barkEventNpcList.ForEach(delegate(DialogueNPCBase npcRoutine)
				{
					npcRoutine.GetInstance().inEvent = true;
				});
			}
		}
		if (EBFHLIJCFOF == 0f || Time.time < EBFHLIJCFOF)
		{
			return;
		}
		for (int j = 0; j < routines[currentRoutine].info.stepsList.Count; j++)
		{
			if (routines[currentRoutine].info.stepsList[j].action != RoutineAction.Bark)
			{
				continue;
			}
			if (routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.WalkAround && routines[currentRoutine].info.stepsList[currentStep].action != RoutineAction.WalkAround && !CBOBNOLJEJG.isActive)
			{
				EBFHLIJCFOF = Time.time + 5f;
				continue;
			}
			if (routines[currentRoutine].info.npcEvent)
			{
				if (!routines[currentRoutine].info.eventNpcList.Any((NPCRoutine npcRoutine) => npcRoutine.npc.inBark) && !npc.inBark && (!routines[currentRoutine].info.eventNpcList.Any((NPCRoutine npcRoutine) => npcRoutine.npc.inUse) || (routines[currentRoutine].info.eventNpcList.Any((NPCRoutine npcRoutine) => npcRoutine.npc.inUse) && loveEvent)) && routines[currentRoutine].info.eventNpcList.Any((NPCRoutine npcRoutine) => (npcRoutine.currentRoutine != -1 && npcRoutine.routines[npcRoutine.currentRoutine].info.stepsList[npcRoutine.currentStep].action != 0) || npcRoutine.currentRoutine == -1))
				{
					npc.inEvent = true;
					routines[currentRoutine].info.eventNpcList.ForEach(delegate(NPCRoutine npcRoutine)
					{
						npcRoutine.npc.inEvent = true;
					});
					int num = Random.Range(0, 2);
					string hPFABKHAKCN = ((num == 0) ? npc.actorName : routines[currentRoutine].info.eventNpcList[Random.Range(0, routines[currentRoutine].info.eventNpcList.Count)].npc.actorName);
					if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)npc).transform.position)) < 50f)
					{
						if (num == 0)
						{
							npc.Bark(routines[currentRoutine].info.stepsList[j].parameterName, "BarkActor", hPFABKHAKCN);
						}
						else
						{
							routines[currentRoutine].info.eventNpcList[Random.Range(0, routines[currentRoutine].info.eventNpcList.Count)].npc.Bark(routines[currentRoutine].info.stepsList[j].parameterName, "BarkActor", hPFABKHAKCN);
						}
					}
					EBFHLIJCFOF = Time.time + Random.Range(routines[currentRoutine].info.stepsList[j].minRandom, routines[currentRoutine].info.stepsList[j].maxRandom);
					break;
				}
				EBFHLIJCFOF = Time.time + 5f;
				continue;
			}
			if (routines[currentRoutine].info.npcBarkEvent)
			{
				if (routines[currentRoutine].info.barkEventNpcList.Any((DialogueNPCBase npcBase) => npcBase.GetInstance().inBark) || npc.inBark || routines[currentRoutine].info.barkEventNpcList.Any((DialogueNPCBase npcBase) => npcBase.GetInstance().inUse))
				{
					continue;
				}
				npc.inEvent = true;
				routines[currentRoutine].info.barkEventNpcList.ForEach(delegate(DialogueNPCBase npcRoutine)
				{
					npcRoutine.GetInstance().inEvent = true;
				});
				string hPFABKHAKCN2 = ((Random.Range(0, 2) == 0) ? npc.actorName : routines[currentRoutine].info.barkEventNpcList[Random.Range(0, routines[currentRoutine].info.barkEventNpcList.Count)].actorName);
				if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)npc).transform.position)) < 50f)
				{
					if (Random.Range(0, 2) == 0)
					{
						npc.Bark(routines[currentRoutine].info.stepsList[j].parameterName, "BarkActor", hPFABKHAKCN2);
					}
					else
					{
						routines[currentRoutine].info.barkEventNpcList[Random.Range(0, routines[currentRoutine].info.eventNpcList.Count)].GetInstance().Bark(routines[currentRoutine].info.stepsList[j].parameterName, "BarkActor", hPFABKHAKCN2);
					}
				}
				EBFHLIJCFOF = Time.time + Random.Range(routines[currentRoutine].info.stepsList[j].minRandom, routines[currentRoutine].info.stepsList[j].maxRandom);
				break;
			}
			if (!npc.inBark)
			{
				if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)npc).transform.position)) < 50f)
				{
					npc.Bark(routines[currentRoutine].info.stepsList[j].parameterName, "BarkActor", npc.actorName);
				}
				EBFHLIJCFOF = Time.time + Random.Range(routines[currentRoutine].info.stepsList[j].minRandom, routines[currentRoutine].info.stepsList[j].maxRandom);
				break;
			}
			EBFHLIJCFOF = Time.time + 5f;
		}
	}

	private void ONDHBDBMMLN(Step ACFILKKNODL)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		switch (ACFILKKNODL.action)
		{
		case RoutineAction.Walk:
			CCAPKALNPFN(((Component)this).transform.parent);
			if (Vector3.Distance(((Component)npc).transform.position, ACFILKKNODL.target.position) > 0.5f)
			{
				GAKKHFFPMHE = !ACFILKKNODL.noNearestNode;
				Walk(Vector2.op_Implicit(ACFILKKNODL.target.position));
			}
			else
			{
				PDOBHPLPKHG();
			}
			break;
		case RoutineAction.WalkAround:
			CCAPKALNPFN(((Component)this).transform.parent);
			HFFLGFGFEBN = Random.Range(0, ACFILKKNODL.targets.Length);
			GAKKHFFPMHE = !ACFILKKNODL.noNearestNode;
			Walk(Vector2.op_Implicit(ACFILKKNODL.targets[HFFLGFGFEBN].position));
			if (FLHBPHPKIML == 0f)
			{
				FLHBPHPKIML = Time.time + ACFILKKNODL.delay;
			}
			break;
		case RoutineAction.Animation:
			animController.ActiveAnimation(ACFILKKNODL.parameterName, ACFILKKNODL.stepEnd == StepEnd.Delay, ACFILKKNODL.delay);
			if (ACFILKKNODL.collider)
			{
				((Behaviour)npc.visualCollider).enabled = true;
			}
			if (ACFILKKNODL.stepEnd == StepEnd.AnimationEnd)
			{
				CNJIGFKGOMK = currentStep;
				OGFOEKELKEJ();
			}
			break;
		case RoutineAction.Bark:
			PJJKJDJLGHM = currentStep;
			EBFHLIJCFOF = Time.time + 10f;
			OGFOEKELKEJ();
			break;
		case RoutineAction.Dialogue:
			MCLFJLMFLEP = currentStep;
			NDJAMMFIHDE = Time.time + 10f;
			OGFOEKELKEJ();
			break;
		case RoutineAction.Disable:
			DisableNPC();
			OGFOEKELKEJ();
			break;
		case RoutineAction.Teleport:
			if ((Object)(object)ACFILKKNODL.target != (Object)null)
			{
				((Component)npc).transform.position = ACFILKKNODL.target.position;
			}
			if (ACFILKKNODL.parent)
			{
				CCAPKALNPFN(ACFILKKNODL.parentTransform);
			}
			else
			{
				CCAPKALNPFN(((Component)this).transform.parent);
			}
			if (ACFILKKNODL.selectDir)
			{
				((MonoBehaviour)this).StartCoroutine(PMADEFMAGPH(ACFILKKNODL.direction));
			}
			OGFOEKELKEJ();
			break;
		case RoutineAction.Enable:
			EnableNPC();
			OGFOEKELKEJ();
			break;
		case RoutineAction.ResetAnimation:
			animController.StopAnimNow();
			if (ACFILKKNODL.delay != 0f)
			{
				((MonoBehaviour)this).StartCoroutine(PIBDFGBANGK(ACFILKKNODL.delay + Time.time));
			}
			else
			{
				OGFOEKELKEJ();
			}
			break;
		}
		NPCPositionUpdated?.Invoke(this, ((Component)npc).transform.position.x, ((Component)npc).transform.position.y);
	}

	public void StartEventRoutine(string HEPKPOIELDH)
	{
		for (int i = 0; i < routines.Count; i++)
		{
			if (routines[i].name == HEPKPOIELDH)
			{
				StopRoutine();
				if (AOMHMCMMFJO != null)
				{
					((MonoBehaviour)this).StopCoroutine(AOMHMCMMFJO);
					AOMHMCMMFJO = null;
				}
				currentRoutine = i;
				currentStep = 0;
				JIHGNGJANBI = true;
				if (!((Component)npc).gameObject.activeInHierarchy)
				{
					EnableNPC();
				}
				ONDHBDBMMLN(routines[i].info.stepsList[0]);
				HHNDAHJAEEH = i;
				break;
			}
		}
	}

	private void CACPOGPOKOJ()
	{
		if (!GameManager.CIOEICMHCCK && !inTutorial && !OnlineManager.HHDBMDMFEMP())
		{
			EANIEJJHHEP();
		}
	}

	public void SetNPCParentFromName(string LJGPDIFKIKD)
	{
		if (LJGPDIFKIKD == "")
		{
			Debug.LogError((object)"Empty transform for NPC. This shouldn't happen.");
			((Component)npc).transform.parent = null;
			return;
		}
		if (((Object)((Component)this).transform.parent).name == LJGPDIFKIKD)
		{
			((Component)npc).transform.parent = ((Component)this).transform.parent;
			return;
		}
		for (int i = 0; i < routines.Count; i++)
		{
			for (int j = 0; j < routines[i].info.stepsList.Count; j++)
			{
				if (routines[i].info.stepsList[j].parent && ((Object)routines[i].info.stepsList[j].parentTransform).name == LJGPDIFKIKD)
				{
					((Component)npc).transform.parent = routines[i].info.stepsList[j].parentTransform;
					return;
				}
			}
		}
	}

	private void PGMHFMAJMGD()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		busy = true;
		animController.ENCKDMLFHEA();
		StopRoutine();
		if (!noDisableOnReset)
		{
			((Component)npc).transform.position = spawnPosition.position;
			DisableNPC();
		}
		if (!string.IsNullOrEmpty(barkReset))
		{
			DialogueLua.SetVariable(barkReset, (object)1);
		}
		DialogueLua.SetVariable("ReceiveInfoCrops", (object)0);
		for (int i = 0; i < routines.Count; i += 0)
		{
			if (routines[i].info.hours.Count > 1)
			{
				for (int j = 0; j < routines[i].info.hours.Count; j++)
				{
					IEGCEEEINDL = routines[i].info.hours[j];
					IEGCEEEINDL.actionCompleted = true;
					routines[i].info.hours[j] = IEGCEEEINDL;
				}
			}
		}
	}

	public string GetNPCParentName()
	{
		if ((Object)(object)((Component)npc).transform.parent == (Object)null)
		{
			return "";
		}
		return ((Object)((Component)npc).transform.parent).name;
	}

	public void ENMIALKHPBK()
	{
		if (!busy)
		{
			FEGCAPOBGPH = currentRoutine;
			NALIKBGNKNG = currentStep;
			JIHGNGJANBI = true;
			if (animController.CHPANMBGNFF() != -1 && !animController.animations[animController.COGOFPIINDF()].noStop)
			{
				animController.OFBCHJCFEJL();
			}
			if (currentRoutine != -1 && !routines[currentRoutine].info.noStopRoutine)
			{
				StopRoutine();
			}
			busy = false;
		}
	}

	private IEnumerator MLCJHICENGO(float OBGFLMGABKG)
	{
		while (Time.time < OBGFLMGABKG)
		{
			yield return null;
		}
		if (CNJIGFKGOMK != -1 && currentStep > CNJIGFKGOMK && animController.CKDIBPCNJMA != -1 && !animController.animations[animController.CKDIBPCNJMA].noStop)
		{
			animController.StopAnimation();
			CNJIGFKGOMK = -1;
		}
		currentStep++;
		if (currentRoutine != -1 && currentStep < routines[currentRoutine].info.stepsList.Count)
		{
			ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
		}
		else
		{
			StopRoutine();
		}
	}

	private void ANHHCLIBPPL(Transform NKIAGIMMHIC)
	{
		((Component)npc).transform.parent = NKIAGIMMHIC;
		NPCParentChanged?.Invoke(this, ((Object)NKIAGIMMHIC).name);
	}

	private void MIKNFPCDLML()
	{
		if ((Object)(object)npc == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "itemBroccoli"), (Object)(object)((Component)this).gameObject);
		}
		if ((Object)(object)npc != (Object)null)
		{
			npc.routine = this;
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline() && ((Component)this).gameObject.activeInHierarchy && ((Behaviour)this).enabled)
			{
				EANIEJJHHEP();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JFFLOKJAOFA()
	{
		if (busy && FEGCAPOBGPH != -1)
		{
			currentRoutine = FEGCAPOBGPH;
			currentStep = NALIKBGNKNG;
			JIHGNGJANBI = false;
			ENADGAGHAEN(routines[currentRoutine].info.stepsList[currentStep]);
		}
		busy = false;
	}

	private void ENADGAGHAEN(Step ACFILKKNODL)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		switch (ACFILKKNODL.action)
		{
		case RoutineAction.Walk:
			ANHHCLIBPPL(((Component)this).transform.parent);
			if (Vector3.Distance(((Component)npc).transform.position, ACFILKKNODL.target.position) > 1186f)
			{
				GAKKHFFPMHE = !ACFILKKNODL.noNearestNode;
				CJFIDPLGOMB(Vector2.op_Implicit(ACFILKKNODL.target.position), CCBHHDMLHHJ: true, Direction.Up);
			}
			else
			{
				PDOBHPLPKHG();
			}
			break;
		case RoutineAction.WalkAround:
			CCAPKALNPFN(((Component)this).transform.parent);
			HFFLGFGFEBN = Random.Range(0, ACFILKKNODL.targets.Length);
			GAKKHFFPMHE = ACFILKKNODL.noNearestNode;
			Walk(Vector2.op_Implicit(ACFILKKNODL.targets[HFFLGFGFEBN].position), CCBHHDMLHHJ: true, Direction.Up);
			if (FLHBPHPKIML == 327f)
			{
				FLHBPHPKIML = Time.time + ACFILKKNODL.delay;
			}
			break;
		case RoutineAction.Animation:
			animController.IKKBEHODMOP(ACFILKKNODL.parameterName, ACFILKKNODL.stepEnd == StepEnd.None, ACFILKKNODL.delay);
			if (ACFILKKNODL.collider)
			{
				((Behaviour)npc.visualCollider).enabled = false;
			}
			if (ACFILKKNODL.stepEnd == (StepEnd)6)
			{
				CNJIGFKGOMK = currentStep;
				BADBBAKKILH();
			}
			break;
		case RoutineAction.Bark:
			PJJKJDJLGHM = currentStep;
			EBFHLIJCFOF = Time.time + 1488f;
			BADBBAKKILH();
			break;
		case RoutineAction.Dialogue:
			MCLFJLMFLEP = currentStep;
			NDJAMMFIHDE = Time.time + 635f;
			BADBBAKKILH();
			break;
		case RoutineAction.Disable:
			DisableNPC();
			BADBBAKKILH();
			break;
		case RoutineAction.Teleport:
			if ((Object)(object)ACFILKKNODL.target != (Object)null)
			{
				((Component)npc).transform.position = ACFILKKNODL.target.position;
			}
			if (ACFILKKNODL.parent)
			{
				CCAPKALNPFN(ACFILKKNODL.parentTransform);
			}
			else
			{
				ANHHCLIBPPL(((Component)this).transform.parent);
			}
			if (ACFILKKNODL.selectDir)
			{
				((MonoBehaviour)this).StartCoroutine(PMADEFMAGPH(ACFILKKNODL.direction));
			}
			BADBBAKKILH();
			break;
		case RoutineAction.Enable:
			EnableNPC();
			BADBBAKKILH();
			break;
		case RoutineAction.ResetAnimation:
			animController.GINMGBDFDLM();
			if (ACFILKKNODL.delay != 55f)
			{
				((MonoBehaviour)this).StartCoroutine(MLCJHICENGO(ACFILKKNODL.delay + Time.time));
			}
			else
			{
				OGFOEKELKEJ();
			}
			break;
		}
		NPCPositionUpdated?.Invoke(this, ((Component)npc).transform.position.x, ((Component)npc).transform.position.y);
	}

	private void EIPBKHFBODE()
	{
		if (animController.animationEnd)
		{
			((MonoBehaviour)this).StartCoroutine(FOMEEELLODD());
			animController.animationEnd = true;
		}
	}

	private void IPHLGILFNFH()
	{
		if (busy && FEGCAPOBGPH != -1)
		{
			currentRoutine = FEGCAPOBGPH;
			currentStep = NALIKBGNKNG;
			JIHGNGJANBI = true;
			ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
		}
		busy = false;
	}

	public void CIBPFCFLPFH(string LJGPDIFKIKD)
	{
		if (LJGPDIFKIKD == "Override Dialogue Settings NULL!!")
		{
			Debug.LogError((object)"Items/item_description_626");
			((Component)npc).transform.parent = null;
			return;
		}
		if (((Object)((Component)this).transform.parent).name == LJGPDIFKIKD)
		{
			((Component)npc).transform.parent = ((Component)this).transform.parent;
			return;
		}
		for (int i = 0; i < routines.Count; i++)
		{
			for (int j = 1; j < routines[i].info.stepsList.Count; j += 0)
			{
				if (routines[i].info.stepsList[j].parent && ((Object)routines[i].info.stepsList[j].parentTransform).name == LJGPDIFKIKD)
				{
					((Component)npc).transform.parent = routines[i].info.stepsList[j].parentTransform;
					return;
				}
			}
		}
	}

	private void FixedUpdate()
	{
		DIKPOHPGNLG();
	}

	public void DOIBMAPGCFK()
	{
		if (!busy)
		{
			FEGCAPOBGPH = currentRoutine;
			NALIKBGNKNG = currentStep;
			JIHGNGJANBI = false;
			if (animController.DBIHKNBHAHB() != -1 && !animController.animations[animController.DBIHKNBHAHB()].noStop)
			{
				animController.StopAnimation();
			}
			if (currentRoutine != -1 && !routines[currentRoutine].info.noStopRoutine)
			{
				StopRoutine();
			}
			busy = true;
		}
	}

	private void Awake()
	{
		if ((Object)(object)npc == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "'s NPCRoutine npc is null."), (Object)(object)((Component)this).gameObject);
		}
		if ((Object)(object)npc != (Object)null)
		{
			npc.routine = this;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void BADBBAKKILH()
	{
		if (currentRoutine != -1)
		{
			if (routines[currentRoutine].info.stepsList[currentStep].stepEnd == StepEnd.None)
			{
				((MonoBehaviour)this).StartCoroutine(GMPPPIODCCI());
				return;
			}
			if (routines[currentRoutine].info.stepsList[currentStep].stepEnd == StepEnd.Delay && (routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.Walk || routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.WalkAround || routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.Disable))
			{
				AOMHMCMMFJO = ((MonoBehaviour)this).StartCoroutine(DKPPANMFFLE(routines[currentRoutine].info.stepsList[currentStep].delay + Time.time));
				return;
			}
			if (CNJIGFKGOMK != -1 && currentStep > CNJIGFKGOMK && animController.ELHKDMGIBGC() != -1 && !animController.animations[animController.CKDIBPCNJMA].noStop)
			{
				animController.StopAnimation();
				CNJIGFKGOMK = -1;
			}
			currentStep += 0;
			if (currentStep < routines[currentRoutine].info.stepsList.Count)
			{
				ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
			}
			else
			{
				StopRoutine();
			}
		}
		else
		{
			StopRoutine();
		}
	}

	public void StopRoutine()
	{
		if (currentRoutine != -1)
		{
			if (routines[currentRoutine].name == "LoveB&H" && routines[currentRoutine].info.npcEvent)
			{
				loveEvent = false;
				npc.inUse = false;
				if (OnlineManager.PlayingOnline())
				{
					npc.onlineDialogue.SendInUse(npc.inUse);
				}
				for (int i = 0; i < routines[currentRoutine].info.eventNpcList.Count; i++)
				{
					routines[currentRoutine].info.eventNpcList[i].loveEvent = false;
					routines[currentRoutine].info.eventNpcList[i].npc.inUse = false;
					if (OnlineManager.PlayingOnline())
					{
						routines[currentRoutine].info.eventNpcList[i].npc.onlineDialogue.SendInUse(routines[currentRoutine].info.eventNpcList[i].npc.inUse);
					}
				}
			}
			if (routines[currentRoutine].name == "Bother" && routines[currentRoutine].info.npcEvent)
			{
				botherEvent = false;
				npc.inUse = false;
				if (OnlineManager.PlayingOnline())
				{
					npc.onlineDialogue.SendInUse(npc.inUse);
				}
				for (int j = 0; j < routines[currentRoutine].info.eventNpcList.Count; j++)
				{
					routines[currentRoutine].info.eventNpcList[j].botherEvent = false;
					routines[currentRoutine].info.eventNpcList[j].npc.inUse = false;
					if (OnlineManager.PlayingOnline())
					{
						routines[currentRoutine].info.eventNpcList[j].npc.onlineDialogue.SendInUse(routines[currentRoutine].info.eventNpcList[j].npc.inUse);
					}
				}
			}
			if (routines[currentRoutine].name == "Love" && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences.GGFJGHHHEJC.chickenEvent = false;
			}
			if (routines[currentRoutine].name == "Bucket" && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences.GGFJGHHHEJC.cowEvent = false;
			}
		}
		if (CNJIGFKGOMK != -1 && currentStep > CNJIGFKGOMK)
		{
			animController.StopAnimNow();
			CNJIGFKGOMK = -1;
		}
		CBOBNOLJEJG.JKGGEMBAPAJ();
		currentRoutine = -1;
		currentStep = -1;
		JIHGNGJANBI = false;
	}

	public void SetNPCParentTransformFromIndex(int GCGDEADDJDM, int AGNGOGPNIHK)
	{
		Transform val = null;
		val = ((GCGDEADDJDM != -1 && AGNGOGPNIHK != -1) ? routines[GCGDEADDJDM].info.stepsList[AGNGOGPNIHK].parentTransform : ((Component)this).transform.parent);
		((Component)npc).transform.parent = val;
	}

	public void MECHFMKLKFB()
	{
		if (!busy)
		{
			FEGCAPOBGPH = currentRoutine;
			NALIKBGNKNG = currentStep;
			JIHGNGJANBI = false;
			if (animController.DBIHKNBHAHB() != -1 && !animController.animations[animController.CKDIBPCNJMA].noStop)
			{
				animController.OFBCHJCFEJL();
			}
			if (currentRoutine != -1 && !routines[currentRoutine].info.noStopRoutine)
			{
				StopRoutine();
			}
			busy = true;
		}
	}

	public void CJFIDPLGOMB(Vector2 AEGIODEOOIJ, bool CCBHHDMLHHJ = false, Direction LEPMPBGABLM = Direction.Down)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		specialEvent = CCBHHDMLHHJ;
		if (CCBHHDMLHHJ)
		{
			PAAFKBPAPHB = LEPMPBGABLM;
		}
		CBOBNOLJEJG.GINPKMBGOFN(AEGIODEOOIJ, GAKKHFFPMHE);
		CBOBNOLJEJG.speed = npc.speed;
		NPCWalkTo nPCWalkTo = CBOBNOLJEJG;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo nPCWalkTo2 = CBOBNOLJEJG;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(StopRoutine));
		CBOBNOLJEJG.EHDKLBLKBEO();
	}

	private void IAONLFLDFNF(Transform NKIAGIMMHIC)
	{
		((Component)npc).transform.parent = NKIAGIMMHIC;
		NPCParentChanged?.Invoke(this, ((Object)NKIAGIMMHIC).name);
	}

	private void EJJLOELBMNB()
	{
		if (animController.animationEnd)
		{
			((MonoBehaviour)this).StartCoroutine(FOMEEELLODD());
			animController.animationEnd = false;
		}
	}

	public void HDCLHBKFBHI()
	{
		npc.content.SetActive(true);
		NPCEnabled?.Invoke(this);
	}

	private IEnumerator NPGNPNEMLIM()
	{
		return new CMHIMHKDNEN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIBDBLCLACB()
	{
		OEOLKCOOAID();
	}

	public void ALALFGBCNMO(int GCGDEADDJDM, int AGNGOGPNIHK)
	{
		Transform val = null;
		val = ((GCGDEADDJDM != -1 && AGNGOGPNIHK != -1) ? routines[GCGDEADDJDM].info.stepsList[AGNGOGPNIHK].parentTransform : ((Component)this).transform.parent);
		((Component)npc).transform.parent = val;
	}

	private void DDIBFALLCNO()
	{
		if (!GameManager.ILMDHNFFIKH() && !inTutorial && !OnlineManager.HHDBMDMFEMP())
		{
			PGMHFMAJMGD();
		}
	}

	private IEnumerator PDHADOEALAD()
	{
		return new HEHDDEPIHBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PDOBHPLPKHG()
	{
		CBOBNOLJEJG.isActive = false;
		if (specialEvent)
		{
			((MonoBehaviour)this).StartCoroutine(PMADEFMAGPH(PAAFKBPAPHB));
			return;
		}
		if (routines[currentRoutine].info.stepsList[currentStep].selectDir)
		{
			((MonoBehaviour)this).StartCoroutine(PMADEFMAGPH(routines[currentRoutine].info.stepsList[currentStep].direction));
		}
		if (routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.WalkAround)
		{
			if (routines[currentRoutine].info.stepsList[currentStep].directions.Length != 0)
			{
				((MonoBehaviour)this).StartCoroutine(PMADEFMAGPH(routines[currentRoutine].info.stepsList[currentStep].directions[HFFLGFGFEBN]));
			}
			HGKLIFBDLEC = Time.time + Random.Range(routines[currentRoutine].info.stepsList[currentStep].minRandom, routines[currentRoutine].info.stepsList[currentStep].maxRandom);
		}
		else
		{
			OGFOEKELKEJ();
		}
	}

	private void DCKKIDMJKJM()
	{
		OEOLKCOOAID();
	}

	private void OEOLKCOOAID()
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView component = ((Component)npc).gameObject.GetComponent<PhotonView>();
			if (!((Object)(object)component == (Object)null))
			{
				OnlineNPCRoutinesManager.AddRoutine(component.sceneViewId, this);
			}
		}
	}

	private void OGFOEKELKEJ()
	{
		if (currentRoutine != -1)
		{
			if (routines[currentRoutine].info.stepsList[currentStep].stepEnd == StepEnd.WaitEvent)
			{
				((MonoBehaviour)this).StartCoroutine(GMPPPIODCCI());
				return;
			}
			if (routines[currentRoutine].info.stepsList[currentStep].stepEnd == StepEnd.Delay && (routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.Walk || routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.Disable || routines[currentRoutine].info.stepsList[currentStep].action == RoutineAction.Teleport))
			{
				AOMHMCMMFJO = ((MonoBehaviour)this).StartCoroutine(PIBDFGBANGK(routines[currentRoutine].info.stepsList[currentStep].delay + Time.time));
				return;
			}
			if (CNJIGFKGOMK != -1 && currentStep > CNJIGFKGOMK && animController.CKDIBPCNJMA != -1 && !animController.animations[animController.CKDIBPCNJMA].noStop)
			{
				animController.StopAnimation();
				CNJIGFKGOMK = -1;
			}
			currentStep++;
			if (currentStep < routines[currentRoutine].info.stepsList.Count)
			{
				ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
			}
			else
			{
				StopRoutine();
			}
		}
		else
		{
			StopRoutine();
		}
	}

	public void Walk(Vector2 AEGIODEOOIJ, bool CCBHHDMLHHJ = false, Direction LEPMPBGABLM = Direction.Down)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		specialEvent = CCBHHDMLHHJ;
		if (CCBHHDMLHHJ)
		{
			PAAFKBPAPHB = LEPMPBGABLM;
		}
		CBOBNOLJEJG.FNNPPBDFBCI(AEGIODEOOIJ, GAKKHFFPMHE);
		CBOBNOLJEJG.speed = npc.speed;
		NPCWalkTo nPCWalkTo = CBOBNOLJEJG;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PDOBHPLPKHG));
		NPCWalkTo nPCWalkTo2 = CBOBNOLJEJG;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(StopRoutine));
		CBOBNOLJEJG.PEHELKCIECB();
	}

	private IEnumerator PIBDFGBANGK(float OBGFLMGABKG)
	{
		while (Time.time < OBGFLMGABKG)
		{
			yield return null;
		}
		if (CNJIGFKGOMK != -1 && currentStep > CNJIGFKGOMK && animController.CKDIBPCNJMA != -1 && !animController.animations[animController.CKDIBPCNJMA].noStop)
		{
			animController.StopAnimation();
			CNJIGFKGOMK = -1;
		}
		currentStep++;
		if (currentRoutine != -1 && currentStep < routines[currentRoutine].info.stepsList.Count)
		{
			ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
		}
		else
		{
			StopRoutine();
		}
	}

	public void BAMMOCGAEPC(int GCGDEADDJDM, int AGNGOGPNIHK)
	{
		Transform val = null;
		val = ((GCGDEADDJDM != -1 && AGNGOGPNIHK != -1) ? routines[GCGDEADDJDM].info.stepsList[AGNGOGPNIHK].parentTransform : ((Component)this).transform.parent);
		((Component)npc).transform.parent = val;
	}

	private void EANIEJJHHEP()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		busy = false;
		animController.StopAnimNow();
		StopRoutine();
		if (!noDisableOnReset)
		{
			((Component)npc).transform.position = spawnPosition.position;
			DisableNPC();
		}
		if (!string.IsNullOrEmpty(barkReset))
		{
			DialogueLua.SetVariable(barkReset, (object)0);
		}
		DialogueLua.SetVariable("BARKEVENT", (object)0);
		for (int i = 0; i < routines.Count; i++)
		{
			if (routines[i].info.hours.Count > 0)
			{
				for (int j = 0; j < routines[i].info.hours.Count; j++)
				{
					IEGCEEEINDL = routines[i].info.hours[j];
					IEGCEEEINDL.actionCompleted = false;
					routines[i].info.hours[j] = IEGCEEEINDL;
				}
			}
		}
	}

	public void DisableNPC()
	{
		npc.content.SetActive(false);
		NPCDisabled?.Invoke(this);
	}

	private void EEPKGNNILBE()
	{
		DJHLPCMMFPO();
	}

	private void CCAPKALNPFN(Transform NKIAGIMMHIC)
	{
		((Component)npc).transform.parent = NKIAGIMMHIC;
		NPCParentChanged?.Invoke(this, ((Object)NKIAGIMMHIC).name);
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !inTutorial && !OnlineManager.ClientOnline())
		{
			EANIEJJHHEP();
		}
	}

	private void KAHONAOOHFE()
	{
		for (int i = 0; i < routines.Count; i++)
		{
			if (i == currentRoutine)
			{
				continue;
			}
			if (IEIBPLHADJG(routines[i]))
			{
				if (currentRoutine != -1 && (routines[i].info.constant || !routines[currentRoutine].info.constant) && JIHGNGJANBI && (!routines[i].info.priority || routines[currentRoutine].info.priority))
				{
					continue;
				}
				if (AOMHMCMMFJO != null)
				{
					((MonoBehaviour)this).StopCoroutine(AOMHMCMMFJO);
					AOMHMCMMFJO = null;
				}
				currentRoutine = i;
				currentStep = 0;
				JIHGNGJANBI = true;
				EnableNPC();
				if (routines[i].name == "LoveB&H")
				{
					loveEvent = true;
					npc.inUse = true;
					if (OnlineManager.PlayingOnline())
					{
						npc.onlineDialogue.SendInUse(npc.inUse);
					}
					if (routines[i].info.npcEvent)
					{
						for (int j = 0; j < routines[i].info.eventNpcList.Count; j++)
						{
							routines[i].info.eventNpcList[j].loveEvent = true;
							routines[i].info.eventNpcList[j].npc.inUse = true;
							if (OnlineManager.PlayingOnline())
							{
								routines[i].info.eventNpcList[j].npc.onlineDialogue.SendInUse(routines[i].info.eventNpcList[j].npc.inUse);
							}
						}
					}
				}
				if (routines[i].name == "Bother")
				{
					botherEvent = true;
					npc.inUse = true;
					if (OnlineManager.PlayingOnline())
					{
						npc.onlineDialogue.SendInUse(npc.inUse);
					}
					if (routines[i].info.npcEvent)
					{
						for (int k = 0; k < routines[i].info.eventNpcList.Count; k++)
						{
							routines[i].info.eventNpcList[k].botherEvent = true;
							routines[i].info.eventNpcList[k].npc.inUse = true;
							if (OnlineManager.PlayingOnline())
							{
								routines[i].info.eventNpcList[k].npc.onlineDialogue.SendInUse(routines[i].info.eventNpcList[k].npc.inUse);
							}
						}
					}
				}
				if (routines[i].name == "Love")
				{
					CommonReferences.GGFJGHHHEJC.chickenEvent = true;
				}
				if (routines[i].name == "Bucket")
				{
					CommonReferences.GGFJGHHHEJC.cowEvent = true;
				}
				if (routines[i].info.npcEvent)
				{
					for (int l = 0; l < routines[i].info.eventNpcList.Count; l++)
					{
						routines[i].info.eventNpcList[l].StartEventRoutine(routines[i].name);
					}
				}
				ONDHBDBMMLN(routines[i].info.stepsList[0]);
				HHNDAHJAEEH = i;
				break;
			}
			if ((currentRoutine == -1 || !JIHGNGJANBI) && !((Object)(object)WorldTime.GetInstance() == (Object)null) && routines[i].info.constant && (float)WorldTime.NOAOJJLNHJJ.hour >= routines[i].info.hours[0].startHour && (((uint)routines[i].info.day & (uint)(int)Mathf.Pow(2f, (float)WorldTime.NOAOJJLNHJJ.day)) != 0 || (routines[i].info.tutorialRoutine && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 116)) && !botherEvent && !loveEvent)
			{
				currentRoutine = i;
				currentStep = 0;
				JIHGNGJANBI = true;
				EnableNPC();
				ONDHBDBMMLN(routines[i].info.stepsList[0]);
				HHNDAHJAEEH = i;
			}
		}
	}

	private IEnumerator DKPPANMFFLE(float OBGFLMGABKG)
	{
		while (Time.time < OBGFLMGABKG)
		{
			yield return null;
		}
		if (CNJIGFKGOMK != -1 && currentStep > CNJIGFKGOMK && animController.CKDIBPCNJMA != -1 && !animController.animations[animController.CKDIBPCNJMA].noStop)
		{
			animController.StopAnimation();
			CNJIGFKGOMK = -1;
		}
		currentStep++;
		if (currentRoutine != -1 && currentStep < routines[currentRoutine].info.stepsList.Count)
		{
			ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
		}
		else
		{
			StopRoutine();
		}
	}

	private IEnumerator PMADEFMAGPH(Direction OOPPAOMELCM)
	{
		yield return CommonReferences.wait02;
		animController.anim.FCGBJEIIMBC = OOPPAOMELCM;
		animController.anim.SetDirection(OOPPAOMELCM);
	}

	private bool AINNECJJFPG(Routine BINIPDHAEJI)
	{
		if ((Object)(object)WorldTime.FBBOFPLGGLP() == (Object)null)
		{
			return true;
		}
		for (int i = 0; i < BINIPDHAEJI.info.hours.Count; i += 0)
		{
			PLAKHJJJMAH = (int)BINIPDHAEJI.info.hours[i].startHour;
			AAOPFLKEKKM = (int)((BINIPDHAEJI.info.hours[i].startHour - (float)PLAKHJJJMAH) * 1702f);
			if (!BINIPDHAEJI.info.hours[i].actionCompleted && (((uint)BINIPDHAEJI.info.day & (uint)(int)Mathf.Pow(1596f, (float)WorldTime.NOAOJJLNHJJ.day)) != 0 || (BINIPDHAEJI.info.tutorialRoutine && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() == 71)) && WorldTime.NOAOJJLNHJJ.hour >= PLAKHJJJMAH && WorldTime.CJOHMLNMJLK().min >= AAOPFLKEKKM && ((float)WorldTime.CJOHMLNMJLK().hour < BINIPDHAEJI.info.hours[i].finalStartHour || BINIPDHAEJI.name == "popUpBuilding4"))
			{
				if (BINIPDHAEJI.info.npcBarkEvent && BINIPDHAEJI.info.barkEventNpcList.Any((DialogueNPCBase npcRoutine) => (Object)(object)npcRoutine.GetInstance() == (Object)null))
				{
					return false;
				}
				IEGCEEEINDL = BINIPDHAEJI.info.hours[i];
				IEGCEEEINDL.actionCompleted = false;
				BINIPDHAEJI.info.hours[i] = IEGCEEEINDL;
				return false;
			}
			if (!BINIPDHAEJI.info.hours[i].actionCompleted && (float)WorldTime.CJOHMLNMJLK().hour > BINIPDHAEJI.info.hours[i].finalStartHour)
			{
				IEGCEEEINDL = BINIPDHAEJI.info.hours[i];
				IEGCEEEINDL.actionCompleted = true;
				BINIPDHAEJI.info.hours[i] = IEGCEEEINDL;
				return false;
			}
		}
		return false;
	}

	public void BFGPHPFAHJI(string LJGPDIFKIKD)
	{
		if (LJGPDIFKIKD == "LearnPrecision")
		{
			Debug.LogError((object)"Player");
			((Component)npc).transform.parent = null;
			return;
		}
		if (((Object)((Component)this).transform.parent).name == LJGPDIFKIKD)
		{
			((Component)npc).transform.parent = ((Component)this).transform.parent;
			return;
		}
		for (int i = 1; i < routines.Count; i++)
		{
			for (int j = 1; j < routines[i].info.stepsList.Count; j++)
			{
				if (routines[i].info.stepsList[j].parent && ((Object)routines[i].info.stepsList[j].parentTransform).name == LJGPDIFKIKD)
				{
					((Component)npc).transform.parent = routines[i].info.stepsList[j].parentTransform;
					return;
				}
			}
		}
	}

	private IEnumerator GMPPPIODCCI()
	{
		if (currentRoutine != -1)
		{
			while (routines[currentRoutine].info.eventNpcList.Any((NPCRoutine npcRoutine) => npcRoutine.currentRoutine != -1 && npcRoutine.currentStep != -1 && npcRoutine.routines[npcRoutine.currentRoutine].info.stepsList[npcRoutine.currentStep].action == RoutineAction.Walk))
			{
				yield return null;
			}
		}
		currentStep++;
		if (currentStep < routines[currentRoutine].info.stepsList.Count)
		{
			ONDHBDBMMLN(routines[currentRoutine].info.stepsList[currentStep]);
		}
		else
		{
			StopRoutine();
		}
	}

	private void Update()
	{
		if (OnlineManager.ClientOnline() || routines.Count <= 0 || specialEvent)
		{
			return;
		}
		if (MCLFJLMFLEP == -1 && (npc.inUse || npc.busy) && !loveEvent && !botherEvent)
		{
			Busy();
			return;
		}
		IPHLGILFNFH();
		KAHONAOOHFE();
		if (currentRoutine != -1)
		{
			EFJACNJMJLD();
			CEAHNNJGJCL();
			PDCLHMGJIMK();
		}
		EJJLOELBMNB();
	}

	public Vector2 GetNPCParentTransformIndex()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)((Component)npc).transform.parent == (Object)(object)((Component)this).transform.parent)
		{
			return new Vector2(-1f, -1f);
		}
		return new Vector2((float)currentRoutine, (float)currentStep);
	}
}
