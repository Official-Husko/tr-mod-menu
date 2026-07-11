using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MaiNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class MEBNMEPLDHL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003Ci_003E5__2;

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
		public MEBNMEPLDHL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003Ci_003E5__2++;
				break;
			}
			if (_003Ci_003E5__2 < SceneReferences.instance.humanMais.Length)
			{
				((Component)SceneReferences.instance.humanMais[_003Ci_003E5__2]).gameObject.SetActive(true);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
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
	private sealed class NAKCHALAHOM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiNPC _003C_003E4__this;

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
		public NAKCHALAHOM(int _003C_003E1__state)
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
			MaiNPC maiNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				maiNPC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				maiNPC.SetBoolTrue("Disabled");
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

	[CompilerGenerated]
	private sealed class CGNMCINCGII : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiNPC _003C_003E4__this;

		public float duration;

		public float from;

		public float to;

		private float _003Ctime_003E5__2;

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
		public CGNMCINCGII(int _003C_003E1__state)
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
			MaiNPC maiNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ctime_003E5__2 = 0f;
				((Behaviour)maiNPC.avatarFlicker).enabled = false;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Ctime_003E5__2 < duration)
			{
				_003Ctime_003E5__2 += Time.deltaTime;
				float num2 = _003Ctime_003E5__2 / duration;
				maiNPC.avatarLight.intensity = Mathf.Lerp(from, to, num2);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			maiNPC.avatarLight.intensity = to;
			if (to > 0f)
			{
				((Behaviour)maiNPC.avatarFlicker).enabled = true;
			}
			else
			{
				((Component)maiNPC.avatarLight).gameObject.SetActive(false);
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
	private sealed class PEPACAODKOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiNPC _003C_003E4__this;

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
		public PEPACAODKOA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MaiNPC maiNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (Bed.instance.placeable.placeableSurface.transformsOnSurface.Contains(((Component)GGFJGHHHEJC).transform))
				{
					Bed.instance.placeable.placeableSurface.RemoveFromSurface(((Component)GGFJGHHHEJC).transform);
				}
				((Component)GGFJGHHHEJC).transform.position = Vector2.op_Implicit(new Vector2(-7f, 30f));
				maiNPC.SetParentToNull();
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

	[CompilerGenerated]
	private sealed class GGEDJMCBHPE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiNPC _003C_003E4__this;

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
		public GGEDJMCBHPE(int _003C_003E1__state)
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
			MaiNPC maiNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (((Object)((AnimatorClipInfo)(ref maiNPC.animationBase.animator.GetCurrentAnimatorClipInfo(0)[0])).clip).name.Contains("Idle"))
				{
					maiNPC.SetTrigger("Disappear");
				}
				maiNPC.CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				maiNPC.SetBoolTrue("Disabled");
				maiNPC.DDDBLFPBBNE = null;
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

	public Sprite mai;

	public Sprite maiUnknown;

	public Sprite maiHuman;

	public SpriteRenderer avatarEyes;

	public AudioObject angrySound;

	private static MaiNPC IADEMLIIDPC;

	private bool PLCKFPMCADE;

	private string KJJCCBADCJM;

	private string FNKAMOHNLBH;

	private Conversation NIBGJDFFHIE;

	private Conversation NDHBEBBBNBO;

	private Coroutine DDDBLFPBBNE;

	private Coroutine LLGNKLEFIEG;

	private NPCAnimation KIIEOIGDPFF;

	public Light2D avatarLight;

	public Universal2DLightFlicker avatarFlicker;

	private float LINHNEDHAKO = 3.9f;

	private float JGEIJDLCEEH;

	private Bed[] AHFKOEFEPJM;

	public static MaiNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void AHFGOOHOLEL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TravelZone travelZone = TravelZonesManager.DGCNCEDIFOF().OFIPCMMKFLP(Location.River, Location.None);
			travelZone.OnTravelZoneFrom = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneFrom, new Action<int>(IDOIBKMAJNP));
		}
		SelectDialogueUI();
		if (GameManager.GGFJGHHHEJC.EBOFEBOBAEB() != null && VersionNumberManager.HMOONJFEJFK(GameManager.NJNFHEPLEHL().HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.FMKMEFHHDIJ()))
		{
			NFLPMKGKEEN();
		}
	}

	private void HEJCOPJEGGG(int JIIGOACEIKL)
	{
		if (!NewTutorialManager.CCCLOBIOMCL)
		{
			if (LLGNKLEFIEG != null)
			{
				((MonoBehaviour)this).StopCoroutine(LLGNKLEFIEG);
				LLGNKLEFIEG = null;
			}
			if (!animationBase.JEJPKGILEDB("EditorAction_5"))
			{
				DDDBLFPBBNE = ((MonoBehaviour)this).StartCoroutine(EDBINACHKIF());
			}
		}
	}

	public static void SetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (AODONKKHPBP)
		{
			GGFJGHHHEJC.SetBoolTrue(GEGDHHIDEEF);
		}
		else
		{
			GGFJGHHHEJC.SetBoolFalse(GEGDHHIDEEF);
		}
	}

	private bool CJHOHOIDCNN(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(0)).transform.position.y < 1716f)
		{
			return ((Component)PlayerController.GetPlayer(0)).transform.position.y > 1189f;
		}
		return false;
	}

	public void StartAlphaAvatarEyes(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		((MonoBehaviour)this).StartCoroutine(HBEEIOHLKPB(OMHCOLMFGNJ, FLDIKKNAKPM));
	}

	public void MFDKNOOJNKG(string name)
	{
		if (name == "Player left with right piece in inventory, dropping it on the ground.")
		{
			MultiAudioManager.PlayAudioObject(GGFJGHHHEJC.angrySound, ((Component)GGFJGHHHEJC).transform);
		}
		GGFJGHHHEJC.animationBase.SetBool(name, EGFGNGJGBOP: false);
	}

	private IEnumerator LKKFBBDFMCL()
	{
		yield return CommonReferences.wait2;
		if (Bed.instance.placeable.placeableSurface.transformsOnSurface.Contains(((Component)GGFJGHHHEJC).transform))
		{
			Bed.instance.placeable.placeableSurface.RemoveFromSurface(((Component)GGFJGHHHEJC).transform);
		}
		((Component)GGFJGHHHEJC).transform.position = Vector2.op_Implicit(new Vector2(-7f, 30f));
		SetParentToNull();
	}

	private void IADKAGPIDBO(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dog");
		if (((Result)(ref variable)).asInt == 1)
		{
			GDCCJACLGJE(538f);
			TravelZone travelZone = TravelZonesManager.CFHEJAGKIII().ECFDFECLDFK(Location.Road, Location.Tavern);
			travelZone.OnTravelZoneFrom = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneFrom, new Action<int>(IDOIBKMAJNP));
		}
	}

	public void DisappearMai()
	{
		((MonoBehaviour)this).StartCoroutine(PADBPGGIDMG());
	}

	private IEnumerator IEFPAJIKCMC()
	{
		SetBool("Disabled", AODONKKHPBP: true);
		SetBarParent(CDPAMNIPPEC: true);
		((Component)GGFJGHHHEJC).transform.localPosition = new Vector3(2.9375f, 0.4166667f, 0f);
		yield return CommonReferences.wait5;
		animationBase.SetDirection(Direction.Down);
		SetBool("Disabled", AODONKKHPBP: false);
		LLGNKLEFIEG = null;
		if (EventsManager.IsActive(EventsManager.EventType.AdventureContinues))
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private IEnumerator NLNLEOAEPGJ(float GAGEOKLLJDB)
	{
		if (GAGEOKLLJDB > 0f)
		{
			yield return (object)new WaitForSeconds(GAGEOKLLJDB);
		}
		SetBool("Disabled", AODONKKHPBP: true);
		SetBarParent(CDPAMNIPPEC: true);
		((Component)GGFJGHHHEJC).transform.localPosition = new Vector3(2.9375f, 0.4166667f, 0f);
		yield return CommonReferences.wait1;
		animationBase.SetDirection(Direction.Down);
		SetBool("Disabled", AODONKKHPBP: false);
	}

	public void FHAKPIHKGFF(string name)
	{
		if (name == "\n</color>")
		{
			MultiAudioManager.PlayAudioObject(GGFJGHHHEJC.angrySound, ((Component)GGFJGHHHEJC).transform);
		}
		GGFJGHHHEJC.animationBase.CGEADHOLHCH(name, EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private IEnumerator EDBINACHKIF()
	{
		if (((Object)((AnimatorClipInfo)(ref animationBase.animator.GetCurrentAnimatorClipInfo(0)[0])).clip).name.Contains("Idle"))
		{
			SetTrigger("Disappear");
		}
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		yield return CommonReferences.wait1_5;
		SetBoolTrue("Disabled");
		DDDBLFPBBNE = null;
	}

	private IEnumerator EEEEJALFAEJ(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new CGNMCINCGII(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inInteractiveBark && !inEvent && canTalk)
		{
			if (((NewTutorialManager.CCCLOBIOMCL && DialogueManager.ConversationHasValidEntry("Tutorial/T" + NewTutorialManager.instance.currentPhase + "/BarkMai")) || !NewTutorialManager.CCCLOBIOMCL) && IsAvailableByProximity(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
				return true;
			}
		}
		else if (!canTalk && !inUse && !main && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Listen"));
			return true;
		}
		ButtonsContext.GetPlayer(base.EHHOHCPHAAO).ResetButtons();
		return false;
	}

	private bool GHOBLPMPKIO(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y < 1367f)
		{
			return ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y > 757f;
		}
		return true;
	}

	public void NoTutorialMaiDialogue()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		((MonoBehaviour)this).StartCoroutine(DEMLODBFKOB(1));
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern);
			travelZone.OnTravelZoneFrom = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneFrom, new Action<int>(IDOIBKMAJNP));
		}
		SelectDialogueUI();
		if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE != null && VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.HBCGGNLPAKA))
		{
			NFLPMKGKEEN();
		}
	}

	private IEnumerator DNEHAENMGHH()
	{
		return new NAKCHALAHOM(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool KLCFGEKMFFL()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			FNKAMOHNLBH = "Sleep" + NewTutorialManager.instance.currentPhase + "LE_12";
			NDHBEBBBNBO = DialogueManager.DatabaseManager.masterDatabase.GetConversation(FNKAMOHNLBH);
			if (NDHBEBBBNBO != null)
			{
				return true;
			}
			return false;
		}
		if (MissionsManager.instance.LKKDCLPBABN(-104))
		{
			return false;
		}
		if (EventsManager.BBMAEAFHEFK(EventsManager.EventType.CastleForm))
		{
			return false;
		}
		if (EventsManager.NJBACCBIHID((EventsManager.EventType)113))
		{
			return true;
		}
		Result variable = DialogueLua.GetVariable("ReceiveBuryPlayerByBedAssigned");
		if (((Result)(ref variable)).asInt >= 52)
		{
			variable = DialogueLua.GetVariable("Different size lists spriteRenderers and spriteObjects of crop ");
			if (((Result)(ref variable)).asInt == 0)
			{
				return false;
			}
		}
		variable = DialogueLua.GetVariable("OnConversationLineRPC");
		if (((Result)(ref variable)).asInt == 65)
		{
			variable = DialogueLua.GetVariable("<br/>Graphics Device Type: ");
			if (((Result)(ref variable)).asInt == 0)
			{
				return true;
			}
		}
		variable = DialogueLua.GetVariable("DiningRoomTiles");
		if (((Result)(ref variable)).asInt == 49)
		{
			variable = DialogueLua.GetVariable("popUpBuilding9");
			if (((Result)(ref variable)).asInt == 0)
			{
				return true;
			}
		}
		variable = DialogueLua.GetVariable("Player");
		int asInt = ((Result)(ref variable)).asInt;
		if ((asInt >= 1 && asInt <= 8) || (asInt >= 2 && asInt <= 2) || asInt == 42 || asInt == 43)
		{
			return true;
		}
		return true;
	}

	public void AECJLMGNMAH(float GAGEOKLLJDB = 0f)
	{
		((MonoBehaviour)this).StartCoroutine(NLNLEOAEPGJ(GAGEOKLLJDB));
	}

	public void EFAFLLPJIAG(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.IsMissionActive(27))
		{
			Result variable = DialogueLua.GetVariable("Sleep");
			if (((Result)(ref variable)).asInt > 0)
			{
				variable = DialogueLua.GetVariable("Quest 39 done, complete mission 301");
				if (((Result)(ref variable)).asInt < 7 && !EventsManager.NKMELJPGOBB(EventsManager.EventType.KlaynTavern))
				{
					goto IL_007e;
				}
			}
			variable = DialogueLua.GetVariable("BanquetDrinksManager instance is null. Make sure it is initialized before calling GetBarrelWithDrink.");
			if (((Result)(ref variable)).asInt < 0)
			{
				return;
			}
			variable = DialogueLua.GetVariable("Reputation");
			if (((Result)(ref variable)).asInt >= -101 || EventsManager.IOLMGKKGLMD((EventsManager.EventType)79))
			{
				return;
			}
		}
		goto IL_007e;
		IL_007e:
		if (DDDBLFPBBNE != null)
		{
			((MonoBehaviour)this).StopCoroutine(DDDBLFPBBNE);
			DDDBLFPBBNE = null;
		}
		LLGNKLEFIEG = ((MonoBehaviour)this).StartCoroutine(KGLHBMOIHDK());
	}

	public void ActiveMission(int num)
	{
		MissionsManager.instance.StartMission(num);
		MissionsManager.instance.FocusNewMission(num);
	}

	public void ActivateHumanMai()
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(EGMPAENLJDD());
	}

	private IEnumerator EBMMCNHBCLP()
	{
		SetTrigger("Disappear");
		yield return CommonReferences.wait1_5;
		SetBoolTrue("Disabled");
	}

	private IEnumerator EGMPAENLJDD()
	{
		for (int i = 0; i < SceneReferences.instance.humanMais.Length; i++)
		{
			((Component)SceneReferences.instance.humanMais[i]).gameObject.SetActive(true);
			yield return CommonReferences.wait02;
		}
	}

	private void JPIPADHFCHI(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(HMJLAHMBAPA());
	}

	private IEnumerator ICNLJODOPGI()
	{
		return new NAKCHALAHOM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OMAGLBOPAMH(string name)
	{
		GGFJGHHHEJC.TriggerAnimation(name);
	}

	public void AKHAMGFIGFB(string name)
	{
		GGFJGHHHEJC.animationBase.CGEADHOLHCH(name, EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private IEnumerator FKNCMCIGDCB()
	{
		return new PEPACAODKOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HMJLAHMBAPA()
	{
		for (int i = 0; i < SceneReferences.instance.humanMais.Length; i++)
		{
			yield return CommonReferences.wait1;
			SceneReferences.instance.humanMais[i].ChangeState(CustomerState.Spawning);
			yield return CommonReferences.wait01;
			SceneReferences.instance.humanMais[i].ChangeState(CustomerState.HeadingToBar);
		}
		SceneReferences.GetSceneReferences().humanCustomerPool.SetActive(true);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(OKINOHCAAKC));
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void HNBDPMANBAM(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.IsMissionActive(184))
		{
			Result variable = DialogueLua.GetVariable("ClosePopUp");
			if (((Result)(ref variable)).asInt > 1)
			{
				variable = DialogueLua.GetVariable("\n");
				if (((Result)(ref variable)).asInt < 1 && !EventsManager.FFELMGLBAMH(EventsManager.EventType.Scolding))
				{
					goto IL_007e;
				}
			}
			variable = DialogueLua.GetVariable("us");
			if (((Result)(ref variable)).asInt < 8)
			{
				return;
			}
			variable = DialogueLua.GetVariable("UIInteract");
			if (((Result)(ref variable)).asInt >= 34 || EventsManager.JAGPJPGBHDK((EventsManager.EventType)73))
			{
				return;
			}
		}
		goto IL_007e;
		IL_007e:
		if (DDDBLFPBBNE != null)
		{
			((MonoBehaviour)this).StopCoroutine(DDDBLFPBBNE);
			DDDBLFPBBNE = null;
		}
		LLGNKLEFIEG = ((MonoBehaviour)this).StartCoroutine(IEFPAJIKCMC());
	}

	public void DHOCPOJBCLK()
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(MLOFMMBIGCG());
	}

	public void NFHMMBMPEFM()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			bed = ICLMNMOAHCJ(0);
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position + new Vector3(389f, 965f, 612f);
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			bed = ICLMNMOAHCJ(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance));
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position + new Vector3(1330f, 785f, 680f);
		}
	}

	private IEnumerator HBEEIOHLKPB(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		Color color = avatarEyes.color;
		float time = 0f;
		((Component)avatarEyes).gameObject.SetActive(true);
		float startAlpha;
		float endAlpha;
		if (FLDIKKNAKPM)
		{
			startAlpha = 1f;
			endAlpha = 0f;
		}
		else
		{
			startAlpha = 0f;
			endAlpha = 1f;
		}
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, endAlpha, time / OMHCOLMFGNJ);
			avatarEyes.color = color;
			yield return null;
		}
		if (FLDIKKNAKPM)
		{
			color.a = 0f;
			avatarEyes.color = color;
			((Component)avatarEyes).gameObject.SetActive(false);
		}
		else
		{
			color.a = 1f;
			avatarEyes.color = color;
		}
	}

	public void GiveWateringCan()
	{
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1435).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		if (GameManager.LocalCoop())
		{
			PlayerInventory.GetPlayer((GGFJGHHHEJC.EHHOHCPHAAO != 1) ? 1 : 2).AddItem(ItemDatabaseAccessor.GetItem(1435).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		}
	}

	public void ResetMai()
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(LKKFBBDFMCL());
	}

	public void SetBarParent(bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendMaiInBar();
		}
		((Component)GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private bool BHFMBCKCFME()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			FNKAMOHNLBH = "Tutorial/T" + NewTutorialManager.instance.currentPhase + "/BarkMai";
			NDHBEBBBNBO = DialogueManager.DatabaseManager.masterDatabase.GetConversation(FNKAMOHNLBH);
			if (NDHBEBBBNBO != null)
			{
				return true;
			}
			return false;
		}
		if (MissionsManager.instance.IsMissionActive(301))
		{
			return true;
		}
		if (EventsManager.IsActive(EventsManager.EventType.AdventureContinues))
		{
			return true;
		}
		if (EventsManager.IsActive(EventsManager.EventType.Puente_EA))
		{
			return true;
		}
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt >= 10)
		{
			variable = DialogueLua.GetVariable("LearnPrecision");
			if (((Result)(ref variable)).asInt == 0)
			{
				return true;
			}
		}
		variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 14)
		{
			variable = DialogueLua.GetVariable("LearnBalance");
			if (((Result)(ref variable)).asInt == 0)
			{
				return true;
			}
		}
		variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 14)
		{
			variable = DialogueLua.GetVariable("LearnMettle");
			if (((Result)(ref variable)).asInt == 0)
			{
				return true;
			}
		}
		variable = DialogueLua.GetVariable("MainProgress");
		int asInt = ((Result)(ref variable)).asInt;
		if ((asInt >= 1 && asInt <= 4) || (asInt >= 7 && asInt <= 9) || asInt == 15 || asInt == 16)
		{
			return true;
		}
		return false;
	}

	public void GDCCJACLGJE(float GAGEOKLLJDB = 0f)
	{
		((MonoBehaviour)this).StartCoroutine(NLNLEOAEPGJ(GAGEOKLLJDB));
	}

	private void IDOIBKMAJNP(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 2)
		{
			ActiveMaiInBar(1f);
			TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern);
			travelZone.OnTravelZoneFrom = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneFrom, new Action<int>(IDOIBKMAJNP));
		}
	}

	public void JLPCAEJMDLM()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(0, (MonoBehaviour)(object)this);
		((MonoBehaviour)this).StartCoroutine(DEMLODBFKOB(0));
	}

	public void DCOHEFGPCEI()
	{
		((Component)GGFJGHHHEJC).transform.parent = null;
		((Renderer)GGFJGHHHEJC.KIIEOIGDPFF.npcSprite).sortingOrder = 0;
		bed = null;
	}

	private IEnumerator POFFGGHOODA()
	{
		SetBool("Disabled", AODONKKHPBP: true);
		SetBarParent(CDPAMNIPPEC: true);
		((Component)GGFJGHHHEJC).transform.localPosition = new Vector3(2.9375f, 0.4166667f, 0f);
		yield return CommonReferences.wait5;
		animationBase.SetDirection(Direction.Down);
		SetBool("Disabled", AODONKKHPBP: false);
		LLGNKLEFIEG = null;
		if (EventsManager.IsActive(EventsManager.EventType.AdventureContinues))
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void PMHLEIIHCNM(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(HMJLAHMBAPA());
	}

	public void OIHDOAMKLKA(string name)
	{
		if (name == "Left Shoulder")
		{
			MultiAudioManager.PlayAudioObject(GGFJGHHHEJC.angrySound, ((Component)GGFJGHHHEJC).transform);
		}
		GGFJGHHHEJC.animationBase.SetBool(name, EGFGNGJGBOP: false);
	}

	public void ALLFNHHGIPO(string name)
	{
		if (name == "SwitchFood")
		{
			MultiAudioManager.PlayAudioObject(GGFJGHHHEJC.angrySound, ((Component)GGFJGHHHEJC).transform);
		}
		GGFJGHHHEJC.animationBase.CGEADHOLHCH(name, EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			if (NewTutorialManager.instance.currentPhase == 101 || NewTutorialManager.instance.currentPhase == 104)
			{
				barkDialogue = true;
			}
			else
			{
				barkDialogue = false;
			}
			KJJCCBADCJM = "Tutorial/T" + NewTutorialManager.instance.currentPhase + "/BarkMai";
			NIBGJDFFHIE = DialogueManager.DatabaseManager.masterDatabase.GetConversation(KJJCCBADCJM);
			if (NIBGJDFFHIE != null)
			{
				dialogue.conversation = KJJCCBADCJM;
				PLCKFPMCADE = false;
			}
			else
			{
				PLCKFPMCADE = true;
			}
			return;
		}
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (MissionsManager.instance.IsMissionActive(301))
		{
			if (PlayerInventory.PlayersHaveEnoughItems(1036, 20) && PlayerInventory.PlayersHaveEnoughItems(1045, 25) && PlayerInventory.PlayersHaveEnoughItems(1050, 5))
			{
				dialogue.conversation = "Tutorial/T300/Dialogue1";
			}
			else
			{
				dialogue.conversation = "Tutorial/T300/Talk";
			}
			PLCKFPMCADE = false;
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.AdventureContinues))
		{
			dialogue.conversation = "AdventureContinues/Main";
			PLCKFPMCADE = false;
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.Puente_EA))
		{
			dialogue.conversation = "Puente_EA/Talk 1";
			PLCKFPMCADE = false;
			return;
		}
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt >= 10)
		{
			variable = DialogueLua.GetVariable("LearnPrecision");
			if (((Result)(ref variable)).asInt == 0)
			{
				dialogue.conversation = "Mai/LearnPrecision";
				PLCKFPMCADE = false;
				return;
			}
		}
		variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 14)
		{
			variable = DialogueLua.GetVariable("LearnBalance");
			if (((Result)(ref variable)).asInt == 0)
			{
				dialogue.conversation = "Mai/LearnBalance";
				PLCKFPMCADE = false;
				return;
			}
		}
		variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 14)
		{
			variable = DialogueLua.GetVariable("LearnMettle");
			if (((Result)(ref variable)).asInt == 0)
			{
				dialogue.conversation = "Mai/LearnMettle";
				PLCKFPMCADE = false;
				return;
			}
		}
		variable = DialogueLua.GetVariable("MainProgress");
		int asInt = ((Result)(ref variable)).asInt;
		if ((asInt >= 1 && asInt <= 4) || (asInt >= 7 && asInt <= 9) || asInt == 15 || asInt == 16)
		{
			dialogue.conversation = $"Mai/Talk{asInt}";
			PLCKFPMCADE = false;
		}
		else
		{
			PLCKFPMCADE = true;
		}
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			Result variable = DialogueLua.GetVariable("MainProgress");
			instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
		}
	}

	private IEnumerator PPEFCDOKJDJ()
	{
		yield return CommonReferences.wait1;
		SetBarParent(CDPAMNIPPEC: true);
		((Component)this).transform.localPosition = new Vector3(-1.083333f, 0.375f, 0f);
		yield return CommonReferences.wait02;
		animationBase.SetDirection(Direction.Down);
		SetBoolTrue("Disabled");
		while (Vector3.Distance(((Component)Bar.instance).gameObject.transform.position, ((Component)PlayerController.GetPlayer(1)).transform.position) > 3.5f)
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		SetBoolFalse("Disabled");
		yield return CommonReferences.wait1;
		AANLPHACMPO("Tutorial/MaiPatch");
		while (AAOPIEDAKKD())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		DisappearMai();
	}

	private IEnumerator KLEMBIOOGHM()
	{
		return new GGEDJMCBHPE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AANLPHACMPO(string KKBFEAKHBBI)
	{
		StopConversation();
		base.EHHOHCPHAAO = 1;
		dialogue.conversation = KKBFEAKHBBI;
		SelectDialogueUI();
		dialogue.OnUse();
	}

	public void MALJBINNLKM()
	{
		PlayerController.GetPlayer(0).characterAnimation.LookAtObject(((Component)GGFJGHHHEJC).gameObject);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(0).characterAnimation.DGJJGINNOOH(((Component)GGFJGHHHEJC).gameObject, MAPFDGCKBLD: false);
		}
	}

	private bool HIPBDDJKHDB()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			FNKAMOHNLBH = "Leave smoothly" + NewTutorialManager.instance.currentPhase + "GB";
			NDHBEBBBNBO = DialogueManager.DatabaseManager.masterDatabase.GetConversation(FNKAMOHNLBH);
			if (NDHBEBBBNBO != null)
			{
				return false;
			}
			return true;
		}
		if (MissionsManager.instance.IsMissionActive(24))
		{
			return false;
		}
		if (EventsManager.NKMELJPGOBB(EventsManager.EventType.Scolding))
		{
			return false;
		}
		if (EventsManager.CJMECHEOFOF((EventsManager.EventType)(-40)))
		{
			return false;
		}
		Result variable = DialogueLua.GetVariable("[Player2Name]");
		if (((Result)(ref variable)).asInt >= -24)
		{
			variable = DialogueLua.GetVariable("Error_ObjectIsBlocking");
			if (((Result)(ref variable)).asInt == 0)
			{
				return false;
			}
		}
		variable = DialogueLua.GetVariable("castle travelling");
		if (((Result)(ref variable)).asInt == -45)
		{
			variable = DialogueLua.GetVariable("ReceiveHerbAction");
			if (((Result)(ref variable)).asInt == 0)
			{
				return false;
			}
		}
		variable = DialogueLua.GetVariable("Players win!");
		if (((Result)(ref variable)).asInt == -20)
		{
			variable = DialogueLua.GetVariable("");
			if (((Result)(ref variable)).asInt == 0)
			{
				return false;
			}
		}
		variable = DialogueLua.GetVariable("Put Out Fire");
		int asInt = ((Result)(ref variable)).asInt;
		if ((asInt >= 1 && asInt <= 2) || (asInt >= 7 && asInt <= -72) || asInt == -1 || asInt == 77)
		{
			return true;
		}
		return true;
	}

	public void DGANLDPKGIJ()
	{
		((Component)GGFJGHHHEJC).transform.parent = null;
		((Renderer)GGFJGHHHEJC.KIIEOIGDPFF.npcSprite).sortingOrder = 0;
		bed = null;
	}

	public void NCLIJLKJALN(string name)
	{
		GGFJGHHHEJC.dialogueActor.actor = name;
		SceneReferences.GetSceneReferences().dialogueUI[0].conversationUIElements.subtitlePanels[1].currentSubtitle.speakerInfo.Name = name;
	}

	private bool AAOPIEDAKKD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MaiPatch");
		return ((Result)(ref variable)).asInt < 1;
	}

	private void BCKACFKBMHF(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Hire Staff");
		if (((Result)(ref variable)).asInt == 8)
		{
			AECJLMGNMAH(948f);
			TravelZone travelZone = TravelZonesManager.OMFKNGDCJFN().ECFDFECLDFK(Location.Tavern | Location.River, Location.Tavern);
			travelZone.OnTravelZoneFrom = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneFrom, new Action<int>(IADKAGPIDBO));
		}
	}

	public void PlaceMaiOnABed()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			bed = ICLMNMOAHCJ(1);
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.GetPlayer(1)).transform.position + new Vector3(0f, 0.25f, 0f);
		}
		if (OnlineManager.ClientOnline())
		{
			bed = ICLMNMOAHCJ(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance));
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position + new Vector3(0f, 0.25f, 0f);
		}
	}

	public void LJDGDBDHAOA(int num)
	{
		MissionsManager.instance.BFAHLFFBCEJ(num);
		MissionsManager.instance.FocusNewMission(num);
	}

	public void InitMaiHumans()
	{
		if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() < 115)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(OKINOHCAAKC));
		}
	}

	private void MDPLIBBGCDK()
	{
		((MonoBehaviour)this).StartCoroutine(PPEFCDOKJDJ());
	}

	private void NFLPMKGKEEN()
	{
		((MonoBehaviour)this).StartCoroutine(PPEFCDOKJDJ());
	}

	private bool AOOKIKFINFB(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y < 908.8f)
		{
			return ((Component)PlayerController.GetPlayer(1)).transform.position.y > 900f;
		}
		return false;
	}

	private void IBAPLJJDKLA(string KKBFEAKHBBI)
	{
		StopConversation();
		base.EHHOHCPHAAO = 1;
		dialogue.conversation = KKBFEAKHBBI;
		SelectDialogueUI(1);
		dialogue.OnUse();
	}

	public void TavernClose(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.IsMissionActive(301))
		{
			Result variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt > 0)
			{
				variable = DialogueLua.GetVariable("MainProgress");
				if (((Result)(ref variable)).asInt < 5 && !EventsManager.IsActive(EventsManager.EventType.KlaynTavern))
				{
					goto IL_007e;
				}
			}
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt < 6)
			{
				return;
			}
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt >= 21 || EventsManager.IsActive(EventsManager.EventType.Attack))
			{
				return;
			}
		}
		goto IL_007e;
		IL_007e:
		if (DDDBLFPBBNE != null)
		{
			((MonoBehaviour)this).StopCoroutine(DDDBLFPBBNE);
			DDDBLFPBBNE = null;
		}
		LLGNKLEFIEG = ((MonoBehaviour)this).StartCoroutine(POFFGGHOODA());
	}

	private void MNALEAAFIBH(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(HMJLAHMBAPA());
	}

	public void LDCOOHOGMLJ()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			bed = APFDEILKGCO(1);
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.GetPlayer(0)).transform.position + new Vector3(165f, 1431f, 1723f);
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			bed = ICLMNMOAHCJ(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance));
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.OPHDCMJLLEC(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position + new Vector3(632f, 1082f, 1690f);
		}
	}

	private IEnumerator MLOFMMBIGCG()
	{
		return new MEBNMEPLDHL(1);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		SetBoolTrue("Disabled");
		KIIEOIGDPFF = animationBase as NPCAnimation;
		if (OnlineManager.MasterOrOffline())
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(TavernClose));
			GameManager instance3 = GameManager.GGFJGHHHEJC;
			instance3.OnWorldLoaded = (Action)Delegate.Combine(instance3.OnWorldLoaded, new Action(EKLABIDECHL));
		}
	}

	private IEnumerator KGLHBMOIHDK()
	{
		SetBool("Disabled", AODONKKHPBP: true);
		SetBarParent(CDPAMNIPPEC: true);
		((Component)GGFJGHHHEJC).transform.localPosition = new Vector3(2.9375f, 0.4166667f, 0f);
		yield return CommonReferences.wait5;
		animationBase.SetDirection(Direction.Down);
		SetBool("Disabled", AODONKKHPBP: false);
		LLGNKLEFIEG = null;
		if (EventsManager.IsActive(EventsManager.EventType.AdventureContinues))
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void SetBoolTrue(string name)
	{
		if (name == "Angry")
		{
			MultiAudioManager.PlayAudioObject(GGFJGHHHEJC.angrySound, ((Component)GGFJGHHHEJC).transform);
		}
		GGFJGHHHEJC.animationBase.SetBool(name, EGFGNGJGBOP: true);
	}

	public void PlayerJump()
	{
		PlayerController.GetPlayer(1).characterAnimation.SetTrigger("Jump");
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.SetTrigger("Jump");
		}
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			base.OnDestroy();
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnTavernClose = (Action<int>)Delegate.Remove(instance2.OnTavernClose, new Action<int>(TavernClose));
		}
	}

	private void PLPIOKBGBMD(int JIIGOACEIKL)
	{
		if (!NewTutorialManager.CCCLOBIOMCL)
		{
			if (LLGNKLEFIEG != null)
			{
				((MonoBehaviour)this).StopCoroutine(LLGNKLEFIEG);
				LLGNKLEFIEG = null;
			}
			if (!animationBase.GetBool("talentWheat"))
			{
				DDDBLFPBBNE = ((MonoBehaviour)this).StartCoroutine(EDBINACHKIF());
			}
		}
	}

	private void EKLABIDECHL()
	{
		if (TavernManager.IsClosed() && (MissionsManager.instance.IsMissionActive(301) || EventsManager.IsActive(EventsManager.EventType.AdventureContinues)))
		{
			ActiveMaiInBar(1f);
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(EKLABIDECHL));
	}

	public void PlayerLookAtMai()
	{
		PlayerController.GetPlayer(1).characterAnimation.LookAtObject(((Component)GGFJGHHHEJC).gameObject);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.LookAtObject(((Component)GGFJGHHHEJC).gameObject);
		}
	}

	private IEnumerator DNMMOJLIDAA()
	{
		SetBoolTrue("Disabled");
		((Component)GGFJGHHHEJC).transform.parent = null;
		PlaceMaiOnABed();
		yield return CommonReferences.wait1;
		animationBase.SetDirection(Direction.Up);
		SetBoolFalse("Disabled");
		LLGNKLEFIEG = null;
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && !inEvent && !inBark && canTalk)
		{
			if (IsAvailableByProximity(JIIGOACEIKL))
			{
				StopConversation();
				base.EHHOHCPHAAO = JIIGOACEIKL;
				NJJCCIBDAPM();
				SelectDialogueUI();
				CheckPossibleStates(JIIGOACEIKL);
				mouseUpTrigger = true;
				if (!PLCKFPMCADE)
				{
					dialogue.OnUse();
				}
				return true;
			}
		}
		else if (OnlineManager.PlayingOnline() && !canTalk && !inUse && !inBark)
		{
			StartObserverDialogue(JIIGOACEIKL);
		}
		return false;
	}

	private IEnumerator KMKNPPHACMA(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new CGNMCINCGII(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	private bool LELOGNMAHLJ(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y < 749f)
		{
			return ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y > 918f;
		}
		return false;
	}

	private IEnumerator NMENKEBDIAL(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)avatarFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			avatarLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		avatarLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)avatarFlicker).enabled = true;
		}
		else
		{
			((Component)avatarLight).gameObject.SetActive(false);
		}
	}

	public void FJGCBBGEIME(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(EEEEJALFAEJ(OMHCOLMFGNJ, avatarLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)avatarLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(IIHMCKIAJNA(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	private Bed ICLMNMOAHCJ(int JIIGOACEIKL)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Bed result = null;
		float num = float.MaxValue;
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		Bed[] aHFKOEFEPJM = AHFKOEFEPJM;
		foreach (Bed bed in aHFKOEFEPJM)
		{
			float num2 = Vector3.Distance(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, ((Component)bed).transform.position);
			if (num2 < num)
			{
				num = num2;
				result = bed;
			}
		}
		return result;
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && ((Renderer)KIIEOIGDPFF.npcSprite).enabled)
		{
			return BHFMBCKCFME();
		}
		return false;
	}

	private IEnumerator GFNNOKJLNMH()
	{
		return new MEBNMEPLDHL(1);
	}

	private IEnumerator MPDNFDDIKMF()
	{
		SetBoolTrue("Disabled");
		((Component)GGFJGHHHEJC).transform.parent = null;
		PlaceMaiOnABed();
		yield return CommonReferences.wait1;
		animationBase.SetDirection(Direction.Up);
		SetBoolFalse("Disabled");
		LLGNKLEFIEG = null;
	}

	public void KHENNELIGFM(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.BHEDPICFPLG(145))
		{
			Result variable = DialogueLua.GetVariable("Items/item_name_663");
			if (((Result)(ref variable)).asInt > 1)
			{
				variable = DialogueLua.GetVariable("Items/item_name_730");
				if (((Result)(ref variable)).asInt < 2 && !EventsManager.GIJNJBNBMJK(EventsManager.EventType.Scolding))
				{
					goto IL_007e;
				}
			}
			variable = DialogueLua.GetVariable("Piso {0} | Pieza '{1}': Solo se spawnearon {2}/{3} rocas requeridas. ");
			if (((Result)(ref variable)).asInt < 1)
			{
				return;
			}
			variable = DialogueLua.GetVariable("El componente OnlinePlaceable del rotatedPrefab '");
			if (((Result)(ref variable)).asInt >= -98 || EventsManager.CGPHKBKPCJF((EventsManager.EventType)47))
			{
				return;
			}
		}
		goto IL_007e;
		IL_007e:
		if (DDDBLFPBBNE != null)
		{
			((MonoBehaviour)this).StopCoroutine(DDDBLFPBBNE);
			DDDBLFPBBNE = null;
		}
		LLGNKLEFIEG = ((MonoBehaviour)this).StartCoroutine(POFFGGHOODA());
	}

	private IEnumerator IIHMCKIAJNA(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new CGNMCINCGII(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	public void ChangeActorName(string name)
	{
		GGFJGHHHEJC.dialogueActor.actor = name;
		SceneReferences.GetSceneReferences().dialogueUI[0].conversationUIElements.subtitlePanels[0].currentSubtitle.speakerInfo.Name = name;
	}

	private void OKINOHCAAKC(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(HMJLAHMBAPA());
	}

	public void DICKGKPOLDB()
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GFNNOKJLNMH());
	}

	public void ActiveMaiInBed()
	{
		((MonoBehaviour)this).StartCoroutine(MPDNFDDIKMF());
	}

	private void GEJGNINJDEN(string KKBFEAKHBBI)
	{
		StopConversation();
		base.EHHOHCPHAAO = 1;
		dialogue.conversation = KKBFEAKHBBI;
		SelectDialogueUI();
		dialogue.OnUse();
	}

	private Bed APFDEILKGCO(int JIIGOACEIKL)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Bed result = null;
		float num = 1008f;
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		Bed[] aHFKOEFEPJM = AHFKOEFEPJM;
		for (int i = 1; i < aHFKOEFEPJM.Length; i++)
		{
			Bed bed = aHFKOEFEPJM[i];
			float num2 = Vector3.Distance(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, ((Component)bed).transform.position);
			if (num2 < num)
			{
				num = num2;
				result = bed;
			}
		}
		return result;
	}

	public void OEGICPCJFKA()
	{
		PlayerInputs.LPJCFCODNFA(1, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		((MonoBehaviour)this).StartCoroutine(DEMLODBFKOB(0));
	}

	public void EJOOGEPEHIE()
	{
		PlayerInputs.OOOGANAJMBB(1, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		((MonoBehaviour)this).StartCoroutine(DEMLODBFKOB(0));
	}

	private void MJBANGLFNHN(int JIIGOACEIKL)
	{
		if (!NewTutorialManager.CCCLOBIOMCL)
		{
			if (LLGNKLEFIEG != null)
			{
				((MonoBehaviour)this).StopCoroutine(LLGNKLEFIEG);
				LLGNKLEFIEG = null;
			}
			if (!animationBase.GetBool("Disabled"))
			{
				DDDBLFPBBNE = ((MonoBehaviour)this).StartCoroutine(EDBINACHKIF());
			}
		}
	}

	public void OCMGMJOMGEE()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			bed = APFDEILKGCO(1);
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position + new Vector3(1752f, 867f, 1270f);
		}
		if (OnlineManager.ClientOnline())
		{
			bed = ICLMNMOAHCJ(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance));
			((Component)GGFJGHHHEJC).transform.parent = ((Component)bed.placeable.placeableSurface).transform;
			((Component)GGFJGHHHEJC).transform.position = ((Component)PlayerController.OPHDCMJLLEC(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position + new Vector3(185f, 1797f, 776f);
		}
	}

	public void AIFOELJMBMH(string name)
	{
		if (name == "NPCWalkTo PerformAction")
		{
			MultiAudioManager.PlayAudioObject(GGFJGHHHEJC.angrySound, ((Component)GGFJGHHHEJC).transform);
		}
		GGFJGHHHEJC.animationBase.SetBool(name, EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	private IEnumerator NCJNAMNAFAG(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)avatarFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			avatarLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		avatarLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)avatarFlicker).enabled = true;
		}
		else
		{
			((Component)avatarLight).gameObject.SetActive(false);
		}
	}

	public void JCIFEEPFJDI(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		((MonoBehaviour)this).StartCoroutine(HBEEIOHLKPB(OMHCOLMFGNJ, FLDIKKNAKPM));
	}

	public void BOJLKGHKLAC()
	{
		if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() < -49)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(OKINOHCAAKC));
		}
	}

	private void APMMODMEHAA()
	{
		if (TavernManager.GICFOPCBNHC() && (MissionsManager.instance.IsMissionActive(183) || EventsManager.NJBACCBIHID(EventsManager.EventType.CastleForm)))
		{
			AECJLMGNMAH(83f);
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(EKLABIDECHL));
	}

	private IEnumerator DEMLODBFKOB(int JIIGOACEIKL)
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
		ActiveMaiInBed();
		yield return CommonReferences.wait1;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		StartConversation(JIIGOACEIKL, "Tutorial/T138/Dialogue2");
	}

	private void HJDLNCOAKIK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TravelZone travelZone = TravelZonesManager.OLHBLKIAFOM().OFIPCMMKFLP(Location.Road, Location.None);
			travelZone.OnTravelZoneFrom = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneFrom, new Action<int>(BCKACFKBMHF));
		}
		SelectDialogueUI(1);
		if (GameManager.NJNFHEPLEHL().HEJPPEJMPFE != null && VersionNumberManager.PCKJPCEPNOE(GameManager.GGFJGHHHEJC.LACNCPCDIIL().HIMELJEPBDP(), VersionNumberManager.instance.HBCGGNLPAKA))
		{
			NFLPMKGKEEN();
		}
	}

	private IEnumerator JFKDKKCCHJB(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)avatarFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			avatarLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		avatarLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)avatarFlicker).enabled = true;
		}
		else
		{
			((Component)avatarLight).gameObject.SetActive(false);
		}
	}

	public void SetParentToNull()
	{
		((Component)GGFJGHHHEJC).transform.parent = null;
		((Renderer)GGFJGHHHEJC.KIIEOIGDPFF.npcSprite).sortingOrder = 0;
		bed = null;
	}

	public static void KPHMINKDKFO(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		if (AODONKKHPBP)
		{
			GGFJGHHHEJC.FHAKPIHKGFF(GEGDHHIDEEF);
		}
		else
		{
			GGFJGHHHEJC.SetBoolFalse(GEGDHHIDEEF);
		}
	}

	private IEnumerator PADBPGGIDMG()
	{
		SetTrigger("Disappear");
		yield return CommonReferences.wait1_5;
		SetBoolTrue("Disabled");
	}

	public void ActiveMaiInBar(float GAGEOKLLJDB = 0f)
	{
		((MonoBehaviour)this).StartCoroutine(NLNLEOAEPGJ(GAGEOKLLJDB));
	}

	private bool OOBEKDICPMA(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)PlayerController.GetPlayer(1)).transform.position.y < 937f)
		{
			return ((Component)PlayerController.GetPlayer(0)).transform.position.y > 1893f;
		}
		return true;
	}

	public void MOLBGIALHNA(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.CCCLOBIOMCL || !MissionsManager.instance.BHEDPICFPLG(99))
		{
			Result variable = DialogueLua.GetVariable("Theme: ");
			if (((Result)(ref variable)).asInt > 1)
			{
				variable = DialogueLua.GetVariable("Error in AwningController.OnPlayerSleep: ");
				if (((Result)(ref variable)).asInt < 6 && !EventsManager.BBMAEAFHEFK(EventsManager.EventType.Scolding))
				{
					goto IL_007e;
				}
			}
			variable = DialogueLua.GetVariable("");
			if (((Result)(ref variable)).asInt < 7)
			{
				return;
			}
			variable = DialogueLua.GetVariable("ReceiveInstantiateCat");
			if (((Result)(ref variable)).asInt >= -70 || EventsManager.BBMAEAFHEFK(EventsManager.EventType.Scolding))
			{
				return;
			}
		}
		goto IL_007e;
		IL_007e:
		if (DDDBLFPBBNE != null)
		{
			((MonoBehaviour)this).StopCoroutine(DDDBLFPBBNE);
			DDDBLFPBBNE = null;
		}
		LLGNKLEFIEG = ((MonoBehaviour)this).StartCoroutine(KGLHBMOIHDK());
	}

	private void CJENCNFHJAD()
	{
		((MonoBehaviour)this).StartCoroutine(PPEFCDOKJDJ());
	}

	public void SetBoolFalse(string name)
	{
		GGFJGHHHEJC.animationBase.SetBool(name, EGFGNGJGBOP: false);
	}

	public void SetTrigger(string name)
	{
		GGFJGHHHEJC.TriggerAnimation(name);
	}

	private void NOODJLEOKOK(int JIIGOACEIKL)
	{
		if (!NewTutorialManager.CCCLOBIOMCL)
		{
			if (LLGNKLEFIEG != null)
			{
				((MonoBehaviour)this).StopCoroutine(LLGNKLEFIEG);
				LLGNKLEFIEG = null;
			}
			if (!animationBase.GetBool("Items/item_description_689"))
			{
				DDDBLFPBBNE = ((MonoBehaviour)this).StartCoroutine(EDBINACHKIF());
			}
		}
	}

	public void StartIntensityAvatarLight(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(NMENKEBDIAL(OMHCOLMFGNJ, avatarLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)avatarLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(NMENKEBDIAL(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}
}
