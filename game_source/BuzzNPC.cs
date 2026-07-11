using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BuzzNPC : DialogueNPCBase
{
	public enum BuzzState
	{
		Idle,
		Walk
	}

	[CompilerGenerated]
	private sealed class KKFLIGGPNHI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string bark;

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
		public KKFLIGGPNHI(int _003C_003E1__state)
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
				if (bark == "Farm/Event/Love")
				{
					goto IL_0055;
				}
				goto IL_00b3;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0055;
			case 2:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
				break;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00b3;
			case 4:
				{
					_003C_003E1__state = -1;
					GGFJGHHHEJC.Bark(bark, CDPAMNIPPEC: false);
					break;
				}
				IL_00b3:
				if (GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 4;
				return true;
				IL_0055:
				if (GGFJGHHHEJC.inBark || HollyNPC.GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
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
	private sealed class HBPFGJDOEIB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BuzzNPC _003C_003E4__this;

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
		public HBPFGJDOEIB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected O, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			int num = _003C_003E1__state;
			BuzzNPC buzzNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				buzzNPC.GAGJHPKONIC++;
				if (buzzNPC.GAGJHPKONIC > 3)
				{
					buzzNPC.GAGJHPKONIC = 1;
				}
				switch (buzzNPC.GAGJHPKONIC)
				{
				case 1:
					buzzNPC.Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", buzzNPC.GAGJHPKONIC);
					_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(2, 5));
					_003C_003E1__state = 1;
					return true;
				case 2:
					DialogueLua.SetVariable("BARKDOOR", (object)buzzNPC.GAGJHPKONIC);
					buzzNPC.BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", buzzNPC.GAGJHPKONIC, ((Component)buzzNPC.door).transform);
					_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(2, 5));
					_003C_003E1__state = 2;
					return true;
				case 3:
					DialogueLua.SetVariable("BARKDOOR", (object)buzzNPC.GAGJHPKONIC);
					buzzNPC.BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", buzzNPC.GAGJHPKONIC, ((Component)buzzNPC.door).transform);
					_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(2, 5));
					_003C_003E1__state = 3;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				DialogueLua.SetVariable("BARKDOOR", (object)buzzNPC.GAGJHPKONIC);
				buzzNPC.BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", buzzNPC.GAGJHPKONIC, ((Component)buzzNPC.door).transform);
				break;
			case 2:
				_003C_003E1__state = -1;
				buzzNPC.Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", buzzNPC.GAGJHPKONIC);
				break;
			case 3:
				_003C_003E1__state = -1;
				buzzNPC.Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", buzzNPC.GAGJHPKONIC);
				break;
			}
			buzzNPC.DJPGGLPHCGB = Time.time + Random.Range(10f, 20f);
			buzzNPC.EBFHLIJCFOF = Random.Range(0, 2);
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

	private static BuzzNPC IADEMLIIDPC;

	public BuzzStateBase currentBuzzState;

	public Animator boxAnimator;

	public NPCAnimation buzzAnimation;

	public GameObject boxPoint;

	public GameObject doorPoint;

	public Transform door;

	public SpriteRenderer doorSprite;

	public Sprite[] doorSprites;

	public float hour = 21f;

	public AudioObject closeDoorSound;

	public AudioObject rummageSound;

	[HideInInspector]
	public MultiAudioSource rummageAudio;

	public Collider2D buzzCollider;

	public bool inBuild;

	public bool isBuilding;

	private float FDBCHJMHBKF;

	private float IEIHJNPHGAJ;

	private float IFGFABPMGGK = 2f;

	private float PMCKBLAPLKK = 1f;

	private bool HCCBOAMEEIJ = true;

	private int GAGJHPKONIC;

	private float DJPGGLPHCGB;

	private int EBFHLIJCFOF;

	private int HKKKNMIKPCM;

	private int OFMPJIKGEOD;

	private string HDFMHCKKJJG = "BuzzProgress";

	public static BuzzNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name == "LE_2")
		{
			((Behaviour)buzzCollider).enabled = true;
		}
	}

	private void MMEDMKABALJ()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(5)).transform.position, ((Component)this).transform.position);
		}
		if (buzzAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("\n<color=#A95A00>"))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(8) && PlayerController.OPHDCMJLLEC(7).characterAnimation.animator.GetBool("[SelectSpawnersByMaxDistance] Ran out of candidates at step {0}/{1}."))
			{
				buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(2)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	[SpecialName]
	public static BuzzNPC NEFIEJALANL()
	{
		return IADEMLIIDPC;
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name == "BottomFarm")
		{
			((Behaviour)buzzCollider).enabled = false;
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void HILIALGLFLA()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			buzzAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(8)).gameObject);
		}
	}

	private void KEICGGPGIED(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name == "BuzzCanModify")
		{
			((Behaviour)buzzCollider).enabled = false;
		}
	}

	public void OKEPMLONDII()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(0)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(7)).gameObject);
		}
	}

	private void LJFPBEIFNKL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position, ((Component)this).transform.position);
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Items/item_name_596");
				if (!buzzAnimation.JEJPKGILEDB("UI"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
				}
				HCCBOAMEEIJ = false;
			}
			else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Send next game date as a host ");
				if (!buzzAnimation.JEJPKGILEDB("Collect"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(2)).gameObject, MAPFDGCKBLD: false);
				}
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("BarIdle");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("TavernServiceManager tavernStats is empty.");
			HCCBOAMEEIJ = false;
		}
	}

	public void IJKMCNKLBCF()
	{
		if (FarmConstructionUI.PFHFIJDDOME().AJPCBFHADHG(BDAGIEIJOOG().EHHOHCPHAAO))
		{
			FarmConstructionUI.PFHFIJDDOME().OFGKFMJKBON(BDAGIEIJOOG().EHHOHCPHAAO);
			FarmConstructionActionsUI.DCAEBALADIM().FocusTab(1);
		}
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			base.OnDestroy();
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
		}
	}

	public IEnumerator PIIKFEECGIA()
	{
		GAGJHPKONIC++;
		if (GAGJHPKONIC > 3)
		{
			GAGJHPKONIC = 1;
		}
		switch (GAGJHPKONIC)
		{
		case 1:
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			break;
		case 2:
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			break;
		case 3:
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			break;
		}
		DJPGGLPHCGB = Time.time + Random.Range(10f, 20f);
		EBFHLIJCFOF = Random.Range(0, 2);
	}

	public void ACJDKIEEGLF()
	{
		if (FarmConstructionUI.LKOABOAADCD().GHAIDJBFKJH(CNDNOECMKME().EHHOHCPHAAO))
		{
			FarmConstructionUI.GGFJGHHHEJC.OFGKFMJKBON(GGFJGHHHEJC.EHHOHCPHAAO);
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && !inBuild && canTalk)
			{
				if (IsAvailableByProximity(JIIGOACEIKL))
				{
					StopConversation();
					if (OnlineManager.PlayingOnline())
					{
						onlineDialogue.SendStopConversation();
					}
					isBuilding = FarmConstructionManager.HCGPNLDHHKF;
					if (!isBuilding)
					{
						DialogueLua.SetVariable("BuzzCanBuild", (object)true);
						if (FarmConstructionManager.HBCJHEBFBAO || FarmConstructionManager.CNEEPCGBBBL)
						{
							DialogueLua.SetVariable("BuzzCanModify", (object)true);
						}
						else
						{
							DialogueLua.SetVariable("BuzzCanModify", (object)false);
						}
					}
					else
					{
						DialogueLua.SetVariable("BuzzCanBuild", (object)false);
						DialogueLua.SetVariable("BuzzCanModify", (object)false);
					}
					if (inSpecialEvent)
					{
						base.EHHOHCPHAAO = JIIGOACEIKL;
						DialogueLua.SetVariable("BarkActor", (object)actorName);
						dialogue.conversation = "Farm/Event/RegañinaViolet";
						SelectDialogueUI();
						dialogue.OnUse();
						return true;
					}
					base.EHHOHCPHAAO = JIIGOACEIKL;
					NJJCCIBDAPM();
					SelectDialogueUI();
					AnimatorStateInfo currentAnimatorStateInfo = buzzAnimation.animator.GetCurrentAnimatorStateInfo(0);
					if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
					{
						Debug.Log((object)"Look");
						LookAtPlayer();
					}
					mouseUpTrigger = true;
					dialogue.OnUse();
					return true;
				}
			}
			else if (!canTalk && !inUse)
			{
				StartObserverDialogue(JIIGOACEIKL);
			}
		}
		return false;
	}

	public void ChangeState(BuzzState LGOEFKNEEOK)
	{
		if (!OnlineManager.ClientOnline())
		{
			switch (LGOEFKNEEOK)
			{
			case BuzzState.Idle:
				behaviour.SetTrigger("Idle");
				break;
			case BuzzState.Walk:
				behaviour.SetTrigger("Walk");
				break;
			default:
				Debug.LogError((object)("BuzzNPC: ChangeState called with invalid state: " + LGOEFKNEEOK));
				break;
			}
		}
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("FarmReady");
		if (((Result)(ref variable)).asInt == 0)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 0)
			{
				dialogue.conversation = "Farm/Buzz/Introduce";
				return;
			}
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 1)
			{
				dialogue.conversation = "Farm/Buzz/InteractiveBark";
			}
		}
		else
		{
			dialogue.conversation = "Farm/Buzz/Main";
		}
	}

	public void PCAJFCBBILK()
	{
		if (FarmConstructionUI.MIGKKKELOJO().AKGGHODACCC(CNDNOECMKME().EHHOHCPHAAO))
		{
			FarmConstructionUI.PFHFIJDDOME().Open(CNDNOECMKME().EHHOHCPHAAO);
		}
	}

	public void HHDCJGOFOFJ(string bark)
	{
		((MonoBehaviour)CNDNOECMKME()).StartCoroutine(BEGMJLGDBAD(bark));
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		isBuilding = FarmConstructionManager.HCGPNLDHHKF;
		if (OnlineManager.PlayingOnline())
		{
			int hKKKNMIKPCM = HKKKNMIKPCM;
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (hKKKNMIKPCM != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				string hDFMHCKKJJG = HDFMHCKKJJG;
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
			}
			int oFMPJIKGEOD = OFMPJIKGEOD;
			variable = DialogueLua.GetVariable("BuzzBuildExit");
			if (oFMPJIKGEOD != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance2 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("BuzzBuildExit");
				instance2.SendDialogueInfo("BuzzBuildExit", ((Result)(ref variable)).asInt);
			}
		}
	}

	private void GDKLCJBADLP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(8)).transform.position, ((Component)this).transform.position);
		}
		if (buzzAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(1) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("Festín del Juramento/GolpeKlayn"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.OPHDCMJLLEC(3).characterAnimation.animator.GetBool("BanquetEvent instance is null. Make sure it is initialized before calling DeactivateBanquetEvent."))
			{
				buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(5)).gameObject, MAPFDGCKBLD: false);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void GGEHIMDPAIA()
	{
		if (FarmConstructionUI.BGMJCCFNNDL().AICLKAILACC(JFNOOMJMHCB().EHHOHCPHAAO))
		{
			FarmConstructionUI.EKDNJDJHONF().Open(OMFKNGDCJFN().EHHOHCPHAAO);
		}
	}

	[SpecialName]
	public static BuzzNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void LPCKOLFKDDM()
	{
		if (FarmConstructionUI.PFHFIJDDOME().DEFNGIBDHBB(BDAGIEIJOOG().EHHOHCPHAAO))
		{
			FarmConstructionUI.PDECKLKPKCG().OFGKFMJKBON(KGPJPILAHDE().EHHOHCPHAAO);
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(1);
		}
	}

	public void PGJLFLKDLAE()
	{
		if (Object.op_Implicit((Object)(object)currentBuzzState))
		{
			currentBuzzState.EOGBEMPFJIJ();
		}
		if (FarmMoveManager.instance.moveActive)
		{
			if (!inUse && !inBark)
			{
				if (EBFHLIJCFOF == 1 && Time.time > DJPGGLPHCGB)
				{
					DialogueLua.SetVariable("\n", (object)0);
					Bark("ButtonHold", "Run", 1, CDPAMNIPPEC: false);
					DJPGGLPHCGB = Time.time + Random.Range(1027f, 346f);
					EBFHLIJCFOF = Random.Range(1, 3);
				}
			}
			else
			{
				DJPGGLPHCGB = Time.time + Random.Range(189f, 388f);
			}
			AMHNFLGAHPC();
		}
		else
		{
			CFAFNIMEMEI();
		}
	}

	private void PAJBIPKEAIG(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name == " ")
		{
			((Behaviour)buzzCollider).enabled = false;
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private void JMEEFAOFPIH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(5)).transform.position, ((Component)this).transform.position);
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("City/Keen/Bark/Stand");
				if (!buzzAnimation.JEJPKGILEDB(" from actor "))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
				}
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("LE_6");
				if (!buzzAnimation.JEJPKGILEDB("Tray"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(5)).gameObject);
				}
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("/");
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Player2");
			HCCBOAMEEIJ = false;
		}
	}

	public IEnumerator DelayBarksBuzzDoor()
	{
		GAGJHPKONIC++;
		if (GAGJHPKONIC > 3)
		{
			GAGJHPKONIC = 1;
		}
		switch (GAGJHPKONIC)
		{
		case 1:
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			break;
		case 2:
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			break;
		case 3:
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			break;
		}
		DJPGGLPHCGB = Time.time + Random.Range(10f, 20f);
		EBFHLIJCFOF = Random.Range(0, 2);
	}

	[SpecialName]
	public static BuzzNPC KGPJPILAHDE()
	{
		return IADEMLIIDPC;
	}

	private void GHCCKDPFLIN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("itemPepperoni");
				if (!buzzAnimation.JEJPKGILEDB("VERSION"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
				}
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Themes");
				if (!buzzAnimation.GetBool("ReceiveServeCustomerOrder"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(5)).gameObject, MAPFDGCKBLD: false);
				}
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger(")");
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Floor");
			HCCBOAMEEIJ = true;
		}
	}

	private void Start()
	{
		CheckConstruction();
	}

	private void CFAFNIMEMEI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.OPGGPLEOGCG())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(6)).transform.position, ((Component)this).transform.position);
		}
		if (buzzAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Controls"))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(7) && PlayerController.GetPlayer(6).characterAnimation.animator.GetBool(" "))
			{
				buzzAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(7)).gameObject, MAPFDGCKBLD: false);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = true;
		}
	}

	public void IIOJBKGFBNN()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (FarmConstructionManager.NLPIACLMFHM())
			{
				isBuilding = true;
				((Behaviour)routine).enabled = false;
				((Component)this).gameObject.SetActive(false);
			}
			else
			{
				isBuilding = true;
				((Behaviour)routine).enabled = true;
				((Component)this).gameObject.SetActive(true);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name == "BottomFarm")
		{
			((Behaviour)buzzCollider).enabled = true;
		}
	}

	private void KCNFAHCOPJI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(2)).transform.position, ((Component)this).transform.position);
		}
		if (buzzAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Moving"))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2) && PlayerController.GetPlayer(2).characterAnimation.animator.GetBool("Moving"))
			{
				buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = true;
		}
	}

	public void CheckConstruction()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (FarmConstructionManager.HCGPNLDHHKF)
			{
				isBuilding = true;
				((Behaviour)routine).enabled = false;
				((Component)this).gameObject.SetActive(false);
			}
			else
			{
				isBuilding = false;
				((Behaviour)routine).enabled = true;
				((Component)this).gameObject.SetActive(true);
			}
		}
	}

	public void BarksBuzzDoor()
	{
		if (!inUse && !inBark && EBFHLIJCFOF == 0 && Time.time > DJPGGLPHCGB)
		{
			((MonoBehaviour)this).StartCoroutine(DelayBarksBuzzDoor());
		}
	}

	public void OpenFarmConstructionMode()
	{
		if (FarmConstructionUI.GGFJGHHHEJC.CanOpenUI(GGFJGHHHEJC.EHHOHCPHAAO))
		{
			FarmConstructionUI.GGFJGHHHEJC.Open(GGFJGHHHEJC.EHHOHCPHAAO);
		}
	}

	private void BGENEAOILOF()
	{
		LENMPPEBBKC();
	}

	private void LGGHIEDHKJG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(2)).transform.position, ((Component)this).transform.position);
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Idle");
				if (!buzzAnimation.GetBool("Rummage"))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
				}
				HCCBOAMEEIJ = false;
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("Idle");
				if (!buzzAnimation.GetBool("Rummage"))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
				}
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("Walk");
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Walk");
			HCCBOAMEEIJ = true;
		}
	}

	public IEnumerator KDAOCGNKAEP()
	{
		return new HBPFGJDOEIB(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public static BuzzNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	public void MCGJNJCELJG()
	{
		if (!inUse && !inBark && EBFHLIJCFOF == 0 && Time.time > DJPGGLPHCGB)
		{
			((MonoBehaviour)this).StartCoroutine(PIIKFEECGIA());
		}
	}

	public void JJNMAGKMFEJ()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(8)).gameObject);
		}
	}

	public void KGKMJLOBHKE()
	{
		ShopUI.IEKODILKIHJ(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void ICKIIAHACEH(Collider2D HANHCHBHHEH)
	{
		if (((Object)((Component)HANHCHBHHEH).gameObject).name == "HollyAnimalShop")
		{
			((Behaviour)buzzCollider).enabled = true;
		}
	}

	private IEnumerator BEGMJLGDBAD(string GAGJHPKONIC)
	{
		if (GAGJHPKONIC == "Farm/Event/Love")
		{
			while (GGFJGHHHEJC.inBark || HollyNPC.GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
		else
		{
			while (GGFJGHHHEJC.inBark)
			{
				yield return null;
			}
			yield return CommonReferences.wait01;
			GGFJGHHHEJC.Bark(GAGJHPKONIC, CDPAMNIPPEC: false);
		}
	}

	private void GJMLHECPGBP()
	{
		LENMPPEBBKC();
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			CheckConstruction();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void LookAtPlayer()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	public void OpenFarmModificationMode()
	{
		if (FarmConstructionUI.GGFJGHHHEJC.CanOpenUI(GGFJGHHHEJC.EHHOHCPHAAO))
		{
			FarmConstructionUI.GGFJGHHHEJC.Open(GGFJGHHHEJC.EHHOHCPHAAO);
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(1);
		}
	}

	private void AMHNFLGAHPC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(6)).transform.position, ((Component)this).transform.position);
		}
		if (HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("XP Upgrades");
				if (!buzzAnimation.GetBool("dayAgo"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject);
				}
				HCCBOAMEEIJ = true;
			}
			else if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
			{
				behaviour.SetTrigger("MapCamp");
				if (!buzzAnimation.JEJPKGILEDB("Reverence"))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
				}
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				behaviour.SetTrigger("petshop travelling");
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			behaviour.SetTrigger("Wine");
			HCCBOAMEEIJ = false;
		}
	}

	public void NEJLJBNAOPA()
	{
		if (FarmConstructionUI.AAFOFNEHPLC().KBGEKGJDMBJ(JFNOOMJMHCB().EHHOHCPHAAO))
		{
			FarmConstructionUI.BGMJCCFNNDL().Open(CNDNOECMKME().EHHOHCPHAAO);
		}
	}

	public void JDJGFIJPCIF(string emotion)
	{
		OMFKNGDCJFN().emotionsController.StartEmotion(emotion);
	}

	public void JPPFLKKHOKG()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			buzzAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(1)).gameObject, MAPFDGCKBLD: false);
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			buzzAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(5)).gameObject);
		}
	}

	[SpecialName]
	public static BuzzNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	public void LENMPPEBBKC()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (FarmConstructionManager.IJCLOFLLLPA())
			{
				isBuilding = true;
				((Behaviour)routine).enabled = true;
				((Component)this).gameObject.SetActive(false);
			}
			else
			{
				isBuilding = true;
				((Behaviour)routine).enabled = false;
				((Component)this).gameObject.SetActive(false);
			}
		}
	}

	public void FixedUpdate()
	{
		if (Object.op_Implicit((Object)(object)currentBuzzState))
		{
			currentBuzzState.IMLDLPHOAOJ();
		}
		if (FarmMoveManager.instance.moveActive)
		{
			if (!inUse && !inBark)
			{
				if (EBFHLIJCFOF == 1 && Time.time > DJPGGLPHCGB)
				{
					DialogueLua.SetVariable("BARKBUZZ", (object)0);
					Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", 0);
					DJPGGLPHCGB = Time.time + Random.Range(10f, 20f);
					EBFHLIJCFOF = Random.Range(0, 2);
				}
			}
			else
			{
				DJPGGLPHCGB = Time.time + Random.Range(10f, 20f);
			}
			LGGHIEDHKJG();
		}
		else
		{
			KCNFAHCOPJI();
		}
	}

	public void AIOMHMFOPGA(BuzzState LGOEFKNEEOK)
	{
		if (!OnlineManager.ClientOnline())
		{
			if (LGOEFKNEEOK == BuzzState.Idle)
			{
				behaviour.SetTrigger("OnlinePlayer");
			}
			else if (LGOEFKNEEOK == BuzzState.Idle)
			{
				behaviour.SetTrigger("User logged on: ");
			}
			else
			{
				Debug.LogError((object)("Farm/Buzz/Door_Bark_Searching" + LGOEFKNEEOK));
			}
		}
	}

	public IEnumerator KDDFNHCOGGM()
	{
		GAGJHPKONIC++;
		if (GAGJHPKONIC > 3)
		{
			GAGJHPKONIC = 1;
		}
		switch (GAGJHPKONIC)
		{
		case 1:
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			break;
		case 2:
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			break;
		case 3:
			DialogueLua.SetVariable("BARKDOOR", (object)GAGJHPKONIC);
			BarkBuzzDoor("Farm/Buzz/Door_Bark_Searching", "BARKDOOR", GAGJHPKONIC, ((Component)door).transform);
			yield return (object)new WaitForSeconds((float)Random.Range(2, 5));
			Bark("Farm/Buzz/Bark_Searching", "BARKBUZZ", GAGJHPKONIC);
			break;
		}
		DJPGGLPHCGB = Time.time + Random.Range(10f, 20f);
		EBFHLIJCFOF = Random.Range(0, 2);
	}

	private void HNEKMALGJPO()
	{
		try
		{
			IIOJBKGFBNN();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void EHBFECEJGCE()
	{
		if (Object.op_Implicit((Object)(object)currentBuzzState))
		{
			currentBuzzState.PODKPPHHOAP();
		}
		if (FarmMoveManager.instance.moveActive)
		{
			if (!inUse && !inBark)
			{
				if (EBFHLIJCFOF == 0 && Time.time > DJPGGLPHCGB)
				{
					DialogueLua.SetVariable("Farm/Buzz/Door_Bark_Searching", (object)0);
					Bark("ActionBar9", "Crowly_Barks_Welcome", 1, CDPAMNIPPEC: false);
					DJPGGLPHCGB = Time.time + Random.Range(1654f, 951f);
					EBFHLIJCFOF = Random.Range(1, 7);
				}
			}
			else
			{
				DJPGGLPHCGB = Time.time + Random.Range(196f, 730f);
			}
			GHCCKDPFLIN();
		}
		else
		{
			CFAFNIMEMEI();
		}
	}

	private void BDJKNKIOPIJ()
	{
		IIOJBKGFBNN();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		NJJCCIBDAPM();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private IEnumerator MOHCDNHHLBE(string GAGJHPKONIC)
	{
		return new KKFLIGGPNHI(1)
		{
			bark = GAGJHPKONIC
		};
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("BuzzBuildExit");
		OFMPJIKGEOD = ((Result)(ref variable)).asInt;
	}

	private void DNCCDPKOJPB()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(6)).transform.position, ((Component)this).transform.position);
		}
		if (buzzAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("ActionBar8"))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(1) && PlayerController.GetPlayer(7).characterAnimation.animator.GetBool("Shield"))
			{
				buzzAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(3)).gameObject);
				busy = true;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = false;
		}
	}

	public void GNNLHOMNCHN(BuzzState LGOEFKNEEOK)
	{
		if (!OnlineManager.ClientOnline())
		{
			switch (LGOEFKNEEOK)
			{
			case BuzzState.Idle:
				behaviour.SetTrigger("psai [{0}]: Trigger fired: {1}");
				break;
			case BuzzState.Walk:
				behaviour.SetTrigger("description");
				break;
			default:
				Debug.LogError((object)("quest_description_25" + LGOEFKNEEOK));
				break;
			}
		}
	}

	public void NACAGDEBFBL()
	{
		ShopUI.AGNKKAPMHLN(OMFKNGDCJFN().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static BuzzNPC CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	public void BarkSequence(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(BEGMJLGDBAD(bark));
	}

	private void LDBMHLEFJCN()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		}
		if (buzzAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("LE_10"))
				{
					buzzAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(1) && PlayerController.OPHDCMJLLEC(7).characterAnimation.animator.GetBool("LE_17"))
			{
				buzzAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = true;
			HCCBOAMEEIJ = false;
		}
	}

	public void ODNOKGHNGCC()
	{
		if (!inUse && !inBark && EBFHLIJCFOF == 0 && Time.time > DJPGGLPHCGB)
		{
			((MonoBehaviour)this).StartCoroutine(PIIKFEECGIA());
		}
	}

	private void IDNHNKJEODI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(3)).transform.position, ((Component)this).transform.position);
		}
		if (buzzAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(0) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool(" is trying to initialize more than once."))
				{
					buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(3) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.OPHDCMJLLEC(3).characterAnimation.animator.GetBool("Open"))
			{
				buzzAnimation.LookAtObject(((Component)PlayerController.GetPlayer(4)).gameObject);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			if (FDBCHJMHBKF > IFGFABPMGGK && IEIHJNPHGAJ > IFGFABPMGGK)
			{
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if (FDBCHJMHBKF > IFGFABPMGGK)
		{
			busy = false;
			HCCBOAMEEIJ = false;
		}
	}
}
