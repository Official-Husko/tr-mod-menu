using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ScoldingEvent : GameEvent
{
	[Serializable]
	public class SpecialEventConfig
	{
		public NPCRoutine[] npcroutines;

		public Transform[] targets;

		public Direction[] directions;

		public Collider2D collider;
	}

	[CompilerGenerated]
	private sealed class ABLJLJDONJM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScoldingEvent _003C_003E4__this;

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
		public ABLJLJDONJM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ScoldingEvent scoldingEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(120f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				break;
			case 2:
				_003C_003E1__state = -1;
				scoldingEvent.scoldingEvent.npcroutines[_003Ci_003E5__2].specialEvent = false;
				scoldingEvent.scoldingEvent.npcroutines[_003Ci_003E5__2].npc.inSpecialEvent = false;
				_003Ci_003E5__2++;
				break;
			}
			if (_003Ci_003E5__2 < scoldingEvent.scoldingEvent.npcroutines.Length)
			{
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(3f, 6f));
				_003C_003E1__state = 2;
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
	private sealed class DEEKGHIBNMM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public ScoldingEvent _003C_003E4__this;

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
		public DEEKGHIBNMM(int _003C_003E1__state)
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
			ScoldingEvent scoldingEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(playerNum).SpecialEventCamController(JCFILMOCAKK: true);
				DialogueCameraTarget.GetPlayer(playerNum).AOKFMJNDDPF = true;
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				DialogueLua.SetVariable("BarkActor", (object)"");
				scoldingEvent.scoldingEvent.npcroutines[0].npc.StartConversation(playerNum, "Farm/Event/RegañinaViolet");
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

	public SpecialEventConfig scoldingEvent;

	public BuzzNPC buzz;

	private bool GLKAOHGJANI;

	private int GELMAIBEHDO;

	private void BDJKNKIOPIJ()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.NEFIEJALANL();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(GDKMKIGMJKD));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JAIFBCOBGGJ));
		}
	}

	private IEnumerator MOOPDOONLBE(int JIIGOACEIKL)
	{
		return new DEEKGHIBNMM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public new void EndEvent()
	{
		PlayerInputs.EnableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
		PlayerController.RemoveMovementBlocker(GELMAIBEHDO, (Object)(object)this);
		((Behaviour)scoldingEvent.collider).enabled = false;
		EventsManager.SetDone(EventsManager.EventType.Scolding, POADAPOJIAI: true);
		((MonoBehaviour)this).StartCoroutine(BABMHAMMEIN());
	}

	private bool LCAEADACOFP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("itemMint");
		if (((Result)(ref variable)).asInt >= 5)
		{
			variable = DialogueLua.GetVariable(" : ");
			if (((Result)(ref variable)).asInt >= 0)
			{
				variable = DialogueLua.GetVariable("Not enough fuel");
				if (((Result)(ref variable)).asInt >= 0)
				{
					variable = DialogueLua.GetVariable("ZoneTimeBonus");
					if (((Result)(ref variable)).asInt >= 1)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private void AKBLAECDPKD()
	{
		try
		{
			OIGNBDIBGGE();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private IEnumerator FACPJBAFOLB()
	{
		return new ABLJLJDONJM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IAMJGJLOLNN()
	{
		try
		{
			DJFAJDHGLDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void OAOMALLBGAM()
	{
		try
		{
			DJFAJDHGLDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private bool DFBDAOPDEDL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/BirdNegativeComments/Entry/9/Dialogue Text");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("No hay datos para el piso ");
			if (((Result)(ref variable)).asInt >= 1)
			{
				variable = DialogueLua.GetVariable("XP increased...");
				if (((Result)(ref variable)).asInt >= 0)
				{
					variable = DialogueLua.GetVariable("[NPCGender=");
					if (((Result)(ref variable)).asInt >= 1)
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	private bool DMNEMCAMJDF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("CraftingRoom");
		if (((Result)(ref variable)).asInt >= 3)
		{
			variable = DialogueLua.GetVariable("UI");
			if (((Result)(ref variable)).asInt >= 1)
			{
				variable = DialogueLua.GetVariable("Items/item_name_1079");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("ToggleGroup/ToggleBasic");
					if (((Result)(ref variable)).asInt >= 1)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private IEnumerator KIKDCFNJKBK()
	{
		yield return (object)new WaitForSeconds(120f);
		for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
		{
			yield return (object)new WaitForSeconds(Random.Range(3f, 6f));
			scoldingEvent.npcroutines[i].specialEvent = false;
			scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
		}
	}

	public void BGAFJBNADBC()
	{
		PlayerInputs.EnableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this, FLHBPHPKIML: true);
		PlayerController.RemoveMovementBlocker(GELMAIBEHDO, (Object)(object)this);
		((Behaviour)scoldingEvent.collider).enabled = true;
		EventsManager.SetDone(EventsManager.EventType.Scolding, POADAPOJIAI: true);
		((MonoBehaviour)this).StartCoroutine(FACPJBAFOLB());
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BKBNGDDBPNO));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(MNCDAHNHNMJ));
			}
		}
	}

	private void KHOFBHDDPKK()
	{
		try
		{
			DJFAJDHGLDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(MHIOILMBLPK));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerAwake = (Action)Delegate.Remove(instance2.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
		}
	}

	private IEnumerator ALAJEKHOFEA(int JIIGOACEIKL)
	{
		return new DEEKGHIBNMM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void CFHOODNCOLK()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.NEFIEJALANL();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BKBNGDDBPNO));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IAMJGJLOLNN));
		}
	}

	private void GIBFJNCCPJL()
	{
		try
		{
			DJFAJDHGLDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private IEnumerator HFLMBNHEGHF()
	{
		yield return (object)new WaitForSeconds(120f);
		for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
		{
			yield return (object)new WaitForSeconds(Random.Range(3f, 6f));
			scoldingEvent.npcroutines[i].specialEvent = false;
			scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
		}
	}

	private void JNJCCIFIKOC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(MHIOILMBLPK));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(KANEHEJILNM));
			}
		}
	}

	public void EANAMMIFCOP()
	{
		PlayerInputs.POBGMHINPHA(GELMAIBEHDO, (MonoBehaviour)(object)this);
		PlayerController.RemoveMovementBlocker(GELMAIBEHDO, (Object)(object)this);
		((Behaviour)scoldingEvent.collider).enabled = true;
		EventsManager.KNMNKAAHEIH(EventsManager.EventType.KlaynTavern, POADAPOJIAI: true);
		((MonoBehaviour)this).StartCoroutine(HBNAMCHAEME());
	}

	private IEnumerator LFMHHBAOKMJ()
	{
		yield return (object)new WaitForSeconds(120f);
		for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
		{
			yield return (object)new WaitForSeconds(Random.Range(3f, 6f));
			scoldingEvent.npcroutines[i].specialEvent = false;
			scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
		}
	}

	private void IAIDKPJKLIC()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.GGFJGHHHEJC;
		}
		if (OnlineManager.IsOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DJFAJDHGLDH));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void OIGNBDIBGGE()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.LOFKKDNOKNF(EventsManager.EventType.Scolding))
		{
			return;
		}
		if (LCAEADACOFP() && (Object)(object)buzz != (Object)null && !buzz.isBuilding)
		{
			for (int i = 1; i < scoldingEvent.npcroutines.Length; i += 0)
			{
				scoldingEvent.npcroutines[i].npc.content.SetActive(false);
				scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
				scoldingEvent.npcroutines[i].Walk(Vector2.op_Implicit(scoldingEvent.targets[i].position), CCBHHDMLHHJ: false, scoldingEvent.directions[i]);
			}
			((Behaviour)scoldingEvent.collider).enabled = true;
		}
		else if (((Behaviour)scoldingEvent.collider).enabled)
		{
			for (int j = 0; j < scoldingEvent.npcroutines.Length; j += 0)
			{
				scoldingEvent.npcroutines[j].specialEvent = true;
				scoldingEvent.npcroutines[j].npc.inSpecialEvent = true;
			}
			((Behaviour)scoldingEvent.collider).enabled = false;
		}
	}

	private void HKKDEKIFPPJ()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.BDAGIEIJOOG();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GDKMKIGMJKD));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(JAIFBCOBGGJ));
		}
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(MHIOILMBLPK));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerAwake = (Action)Delegate.Remove(instance2.OnPlayerAwake, new Action(GIBFJNCCPJL));
			}
		}
	}

	private bool NNKPKBKANDP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MopRight");
		if (((Result)(ref variable)).asInt >= 6)
		{
			variable = DialogueLua.GetVariable("  fallingChest:       ");
			if (((Result)(ref variable)).asInt >= 1)
			{
				variable = DialogueLua.GetVariable("ReceivePlayerConnected");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("Items/item_name_1104");
					if (((Result)(ref variable)).asInt >= 0)
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	private IEnumerator HBNAMCHAEME()
	{
		yield return (object)new WaitForSeconds(120f);
		for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
		{
			yield return (object)new WaitForSeconds(Random.Range(3f, 6f));
			scoldingEvent.npcroutines[i].specialEvent = false;
			scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
		}
	}

	private void MHIOILMBLPK()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.IsDone(EventsManager.EventType.Scolding))
		{
			return;
		}
		if (EDOCFKGAPOG() && (Object)(object)buzz != (Object)null && !buzz.isBuilding)
		{
			for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
			{
				scoldingEvent.npcroutines[i].npc.content.SetActive(true);
				scoldingEvent.npcroutines[i].npc.inSpecialEvent = true;
				scoldingEvent.npcroutines[i].Walk(Vector2.op_Implicit(scoldingEvent.targets[i].position), CCBHHDMLHHJ: true, scoldingEvent.directions[i]);
			}
			((Behaviour)scoldingEvent.collider).enabled = true;
		}
		else if (((Behaviour)scoldingEvent.collider).enabled)
		{
			for (int j = 0; j < scoldingEvent.npcroutines.Length; j++)
			{
				scoldingEvent.npcroutines[j].specialEvent = false;
				scoldingEvent.npcroutines[j].npc.inSpecialEvent = false;
			}
			((Behaviour)scoldingEvent.collider).enabled = false;
		}
	}

	private void DJFAJDHGLDH()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.HGALHLALOKJ(EventsManager.EventType.Scolding))
		{
			return;
		}
		if (DFBDAOPDEDL() && (Object)(object)buzz != (Object)null && !buzz.isBuilding)
		{
			for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
			{
				scoldingEvent.npcroutines[i].npc.content.SetActive(false);
				scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
				scoldingEvent.npcroutines[i].Walk(Vector2.op_Implicit(scoldingEvent.targets[i].position), CCBHHDMLHHJ: false, scoldingEvent.directions[i]);
			}
			((Behaviour)scoldingEvent.collider).enabled = false;
		}
		else if (((Behaviour)scoldingEvent.collider).enabled)
		{
			for (int j = 0; j < scoldingEvent.npcroutines.Length; j++)
			{
				scoldingEvent.npcroutines[j].specialEvent = false;
				scoldingEvent.npcroutines[j].npc.inSpecialEvent = false;
			}
			((Behaviour)scoldingEvent.collider).enabled = true;
		}
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("MayaMinigames"))
			{
				GELMAIBEHDO = 1;
				((MonoBehaviour)this).StartCoroutine(ALAJEKHOFEA(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this);
				GLKAOHGJANI = false;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("TavernManager instance is null, cannot add open tavern blocker."))
			{
				GELMAIBEHDO = 6;
				((MonoBehaviour)this).StartCoroutine(AIDNEGAKNFK(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = false;
			}
		}
	}

	private IEnumerator AIDNEGAKNFK(int JIIGOACEIKL)
	{
		return new DEEKGHIBNMM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator DFFIHKINNNN()
	{
		return new ABLJLJDONJM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CKHDGFBDOGB()
	{
		try
		{
			DJFAJDHGLDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void Start()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.GGFJGHHHEJC;
		}
		if (OnlineManager.IsOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(MHIOILMBLPK));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerAwake = (Action)Delegate.Combine(instance2.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				GELMAIBEHDO = 1;
				((MonoBehaviour)this).StartCoroutine(AANLPHACMPO(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this);
				GLKAOHGJANI = true;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				GELMAIBEHDO = 2;
				((MonoBehaviour)this).StartCoroutine(AANLPHACMPO(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this);
				GLKAOHGJANI = true;
			}
		}
	}

	private void JEMIPCBNPDI(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				GELMAIBEHDO = 0;
				((MonoBehaviour)this).StartCoroutine(HLCFAPOABMM(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = false;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("[MinePuzzleManager] All puzzle types used across levels. Resetting used list for level {0}."))
			{
				GELMAIBEHDO = 5;
				((MonoBehaviour)this).StartCoroutine(ALAJEKHOFEA(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
		}
	}

	private void JAIFBCOBGGJ()
	{
		try
		{
			MHIOILMBLPK();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public override GameEvent GetInstance()
	{
		return null;
	}

	public void HKDIIBJAKIP()
	{
		PlayerInputs.DEPNDGJDKOL(GELMAIBEHDO, (MonoBehaviour)(object)this, FLHBPHPKIML: true);
		PlayerController.RemoveMovementBlocker(GELMAIBEHDO, (Object)(object)this);
		((Behaviour)scoldingEvent.collider).enabled = false;
		EventsManager.KNMNKAAHEIH(EventsManager.EventType.Scolding, POADAPOJIAI: false);
		((MonoBehaviour)this).StartCoroutine(HFLMBNHEGHF());
	}

	private void KCDMOOPJBMM(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
			{
				GELMAIBEHDO = 1;
				((MonoBehaviour)this).StartCoroutine(PJMGAIOCBNP(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = false;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("ReceiveAddDrink"))
			{
				GELMAIBEHDO = 4;
				((MonoBehaviour)this).StartCoroutine(NMDKDBAOLNI(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
		}
	}

	private bool HBAKHAJNHHO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MapRiver");
		if (((Result)(ref variable)).asInt >= 0)
		{
			variable = DialogueLua.GetVariable("SpriteRenderer not attached on ");
			if (((Result)(ref variable)).asInt >= 1)
			{
				variable = DialogueLua.GetVariable("Messy");
				if (((Result)(ref variable)).asInt >= 0)
				{
					variable = DialogueLua.GetVariable("MainProgress");
					if (((Result)(ref variable)).asInt >= 0)
					{
						return true;
					}
				}
			}
		}
		return true;
	}

	private IEnumerator BEHJHMKDFEK()
	{
		yield return (object)new WaitForSeconds(120f);
		for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
		{
			yield return (object)new WaitForSeconds(Random.Range(3f, 6f));
			scoldingEvent.npcroutines[i].specialEvent = false;
			scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
		}
	}

	private void IGIKNCOLCKL()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.JFNOOMJMHCB();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OIGNBDIBGGE));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OAOMALLBGAM));
		}
	}

	private void DANDBFMFOGI()
	{
		try
		{
			DJFAJDHGLDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private bool AJKLLCNNLDK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Input Text: ");
		if (((Result)(ref variable)).asInt >= 6)
		{
			variable = DialogueLua.GetVariable(" (ONLINE) [master client] length: ");
			if (((Result)(ref variable)).asInt >= 0)
			{
				variable = DialogueLua.GetVariable("Dialogue System/Conversation/NeutralInTavern/Entry/10/Dialogue Text");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("HumanDisappear");
					if (((Result)(ref variable)).asInt >= 0)
					{
						return false;
					}
				}
			}
		}
		return false;
	}

	private void HHLBFDBHDMC()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.JFNOOMJMHCB();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OIGNBDIBGGE));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(KANEHEJILNM));
		}
	}

	private bool NBOPKJPJMOK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player2");
		if (((Result)(ref variable)).asInt >= 3)
		{
			variable = DialogueLua.GetVariable("/ExtraSettings.sd");
			if (((Result)(ref variable)).asInt >= 0)
			{
				variable = DialogueLua.GetVariable("FishCuttingEvent/Talk2");
				if (((Result)(ref variable)).asInt >= 0)
				{
					variable = DialogueLua.GetVariable("");
					if (((Result)(ref variable)).asInt >= 0)
					{
						return false;
					}
				}
			}
		}
		return false;
	}

	private void AHFGOOHOLEL()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.OMFKNGDCJFN();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MHIOILMBLPK));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(DANDBFMFOGI));
		}
	}

	private IEnumerator AANLPHACMPO(int JIIGOACEIKL)
	{
		DialogueCameraTarget.GetPlayer(JIIGOACEIKL).SpecialEventCamController(JCFILMOCAKK: true);
		DialogueCameraTarget.GetPlayer(JIIGOACEIKL).AOKFMJNDDPF = true;
		yield return CommonReferences.wait1_5;
		DialogueLua.SetVariable("BarkActor", (object)"");
		scoldingEvent.npcroutines[0].npc.StartConversation(JIIGOACEIKL, "Farm/Event/RegañinaViolet");
	}

	private void MBAGGLHJJLP()
	{
		try
		{
			OIGNBDIBGGE();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void DJDFPNLLBMN()
	{
		PlayerInputs.DEPNDGJDKOL(GELMAIBEHDO, (MonoBehaviour)(object)this, FLHBPHPKIML: true);
		PlayerController.RemoveMovementBlocker(GELMAIBEHDO, (Object)(object)this);
		((Behaviour)scoldingEvent.collider).enabled = true;
		EventsManager.KJLBHNLHCNL(EventsManager.EventType.KlaynTavern, POADAPOJIAI: true);
		((MonoBehaviour)this).StartCoroutine(LFMHHBAOKMJ());
	}

	private void ICFHPJHBPDN()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.CNDNOECMKME();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DJFAJDHGLDH));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KHOFBHDDPKK));
		}
	}

	public void ELOKKGBNFEG()
	{
		PlayerInputs.POBGMHINPHA(GELMAIBEHDO, (MonoBehaviour)(object)this);
		PlayerController.RemoveMovementBlocker(GELMAIBEHDO, (Object)(object)this);
		((Behaviour)scoldingEvent.collider).enabled = false;
		EventsManager.KNMNKAAHEIH(EventsManager.EventType.KlaynTavern, POADAPOJIAI: true);
		((MonoBehaviour)this).StartCoroutine(IPGCIFOLDEA());
	}

	private void KJJINNGPPEA(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1231"))
			{
				GELMAIBEHDO = 0;
				((MonoBehaviour)this).StartCoroutine(ALAJEKHOFEA(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this);
				GLKAOHGJANI = false;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("rain stormy"))
			{
				GELMAIBEHDO = 1;
				((MonoBehaviour)this).StartCoroutine(HLCFAPOABMM(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
		}
	}

	private void MNCDAHNHNMJ()
	{
		try
		{
			OIGNBDIBGGE();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private bool CEEJMBDAKAK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("popUpBuilding16");
		if (((Result)(ref variable)).asInt >= 3)
		{
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt >= 1)
			{
				variable = DialogueLua.GetVariable("Dialogue System/Conversation/BirdPositiveComments/Entry/1/Dialogue Text");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("ReceiveSkipKlaynChallenge");
					if (((Result)(ref variable)).asInt >= 0)
					{
						return false;
					}
				}
			}
		}
		return false;
	}

	private void NELBHAMPBPL()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.BDAGIEIJOOG();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OIGNBDIBGGE));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(AKBLAECDPKD));
		}
	}

	private void FPGCPACBPHJ(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("Coming soon!"))
			{
				GELMAIBEHDO = 0;
				((MonoBehaviour)this).StartCoroutine(NMDKDBAOLNI(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Received RPC SetAnimatorStateRPC with hash: 0 on {0}, so the sender was probably deactivated. This shouldn't happen anymore.\nIgnoring this command."))
			{
				GELMAIBEHDO = 6;
				((MonoBehaviour)this).StartCoroutine(MOOPDOONLBE(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = false;
			}
		}
	}

	private void FJKGPAPACOI(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				GELMAIBEHDO = 0;
				((MonoBehaviour)this).StartCoroutine(AANLPHACMPO(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this);
				GLKAOHGJANI = false;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Bomb"))
			{
				GELMAIBEHDO = 8;
				((MonoBehaviour)this).StartCoroutine(NMDKDBAOLNI(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.OMFKNGDCJFN();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OIGNBDIBGGE));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JAIFBCOBGGJ));
		}
	}

	private void GDKMKIGMJKD()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.AEFHILOAEEE(EventsManager.EventType.Scolding))
		{
			return;
		}
		if (AJKLLCNNLDK() && (Object)(object)buzz != (Object)null && !buzz.isBuilding)
		{
			for (int i = 0; i < scoldingEvent.npcroutines.Length; i += 0)
			{
				scoldingEvent.npcroutines[i].npc.content.SetActive(false);
				scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
				scoldingEvent.npcroutines[i].CJFIDPLGOMB(Vector2.op_Implicit(scoldingEvent.targets[i].position), CCBHHDMLHHJ: true, scoldingEvent.directions[i]);
			}
			((Behaviour)scoldingEvent.collider).enabled = true;
		}
		else if (((Behaviour)scoldingEvent.collider).enabled)
		{
			for (int j = 0; j < scoldingEvent.npcroutines.Length; j++)
			{
				scoldingEvent.npcroutines[j].specialEvent = true;
				scoldingEvent.npcroutines[j].npc.inSpecialEvent = false;
			}
			((Behaviour)scoldingEvent.collider).enabled = true;
		}
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			MHIOILMBLPK();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private IEnumerator BABMHAMMEIN()
	{
		yield return (object)new WaitForSeconds(120f);
		for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
		{
			yield return (object)new WaitForSeconds(Random.Range(3f, 6f));
			scoldingEvent.npcroutines[i].specialEvent = false;
			scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
		}
	}

	private void EOGHJNGJFID()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.GGFJGHHHEJC;
		}
		if (OnlineManager.IsOffline())
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(GDKMKIGMJKD));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerAwake = (Action)Delegate.Combine(instance2.OnPlayerAwake, new Action(AKBLAECDPKD));
		}
	}

	private void BKBNGDDBPNO()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.OOCOFHECMDA(EventsManager.EventType.KlaynTavern))
		{
			return;
		}
		if (NNKPKBKANDP() && (Object)(object)buzz != (Object)null && !buzz.isBuilding)
		{
			for (int i = 0; i < scoldingEvent.npcroutines.Length; i += 0)
			{
				scoldingEvent.npcroutines[i].npc.content.SetActive(false);
				scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
				scoldingEvent.npcroutines[i].Walk(Vector2.op_Implicit(scoldingEvent.targets[i].position), CCBHHDMLHHJ: true, scoldingEvent.directions[i]);
			}
			((Behaviour)scoldingEvent.collider).enabled = true;
		}
		else if (((Behaviour)scoldingEvent.collider).enabled)
		{
			for (int j = 0; j < scoldingEvent.npcroutines.Length; j += 0)
			{
				scoldingEvent.npcroutines[j].specialEvent = true;
				scoldingEvent.npcroutines[j].npc.inSpecialEvent = false;
			}
			((Behaviour)scoldingEvent.collider).enabled = true;
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("</color>"))
			{
				GELMAIBEHDO = 0;
				((MonoBehaviour)this).StartCoroutine(AIDNEGAKNFK(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("Invalid ninja customer ID: "))
			{
				GELMAIBEHDO = 3;
				((MonoBehaviour)this).StartCoroutine(AIDNEGAKNFK(GELMAIBEHDO));
				PlayerInputs.JBKHOPCMBAC(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
		}
	}

	private bool EDOCFKGAPOG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_5");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("LE_6");
			if (((Result)(ref variable)).asInt >= 1)
			{
				variable = DialogueLua.GetVariable("LE_7");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("LE_8");
					if (((Result)(ref variable)).asInt >= 1)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private IEnumerator IPGCIFOLDEA()
	{
		yield return (object)new WaitForSeconds(120f);
		for (int i = 0; i < scoldingEvent.npcroutines.Length; i++)
		{
			yield return (object)new WaitForSeconds(Random.Range(3f, 6f));
			scoldingEvent.npcroutines[i].specialEvent = false;
			scoldingEvent.npcroutines[i].npc.inSpecialEvent = false;
		}
	}

	private bool EHGCGFNPDMP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("HotBath/Ferro Talk");
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/16/Dialogue Text");
			if (((Result)(ref variable)).asInt >= 1)
			{
				variable = DialogueLua.GetVariable("ReceiveStackContainer");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("Error ");
					if (((Result)(ref variable)).asInt >= 1)
					{
						return false;
					}
				}
			}
		}
		return false;
	}

	private void HCEDMLJNOBL()
	{
		if ((Object)(object)buzz == (Object)null)
		{
			buzz = BuzzNPC.CNDNOECMKME();
		}
		if (OnlineManager.IsOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GDKMKIGMJKD));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(AKBLAECDPKD));
		}
	}

	private bool KHIKOMDJADD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("[ControllerType:");
		if (((Result)(ref variable)).asInt >= 6)
		{
			variable = DialogueLua.GetVariable("popUpBuilding2B");
			if (((Result)(ref variable)).asInt >= 0)
			{
				variable = DialogueLua.GetVariable("ReceiveEnableNPC");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("Unknown command");
					if (((Result)(ref variable)).asInt >= 1)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private bool BCALKEHCFJH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReeledInRPC");
		if (((Result)(ref variable)).asInt >= 7)
		{
			variable = DialogueLua.GetVariable("InkeepersCave_Message");
			if (((Result)(ref variable)).asInt >= 0)
			{
				variable = DialogueLua.GetVariable("questNameFarming");
				if (((Result)(ref variable)).asInt >= 1)
				{
					variable = DialogueLua.GetVariable("ReceiveSetUniqueCropHarvestable");
					if (((Result)(ref variable)).asInt >= 1)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private void JOGBCDIAGEK()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OIGNBDIBGGE));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerAwake = (Action)Delegate.Remove(instance2.OnPlayerAwake, new Action(AKBLAECDPKD));
			}
		}
	}

	private IEnumerator NMDKDBAOLNI(int JIIGOACEIKL)
	{
		return new DEEKGHIBNMM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator HLCFAPOABMM(int JIIGOACEIKL)
	{
		DialogueCameraTarget.GetPlayer(JIIGOACEIKL).SpecialEventCamController(JCFILMOCAKK: true);
		DialogueCameraTarget.GetPlayer(JIIGOACEIKL).AOKFMJNDDPF = true;
		yield return CommonReferences.wait1_5;
		DialogueLua.SetVariable("BarkActor", (object)"");
		scoldingEvent.npcroutines[0].npc.StartConversation(JIIGOACEIKL, "Farm/Event/RegañinaViolet");
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BKBNGDDBPNO));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(OAOMALLBGAM));
			}
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if (!GLKAOHGJANI)
		{
			if (((Component)HANHCHBHHEH).CompareTag("*****"))
			{
				GELMAIBEHDO = 1;
				((MonoBehaviour)this).StartCoroutine(NMDKDBAOLNI(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this, ANJCLPDCJHL: true);
				GLKAOHGJANI = true;
			}
			else if (((Component)HANHCHBHHEH).CompareTag("UI2"))
			{
				GELMAIBEHDO = 4;
				((MonoBehaviour)this).StartCoroutine(AIDNEGAKNFK(GELMAIBEHDO));
				PlayerInputs.DisableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(GELMAIBEHDO, (Object)(object)this);
				GLKAOHGJANI = true;
			}
		}
	}

	private void KANEHEJILNM()
	{
		try
		{
			OIGNBDIBGGE();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void KOBNHPKEJJD()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(DJFAJDHGLDH));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(MNCDAHNHNMJ));
			}
		}
	}

	private IEnumerator PJMGAIOCBNP(int JIIGOACEIKL)
	{
		return new DEEKGHIBNMM(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}
}
