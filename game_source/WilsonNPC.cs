using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class WilsonNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class ENBBNLELDFO : IEnumerator<object>, IEnumerator, IDisposable
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
		public ENBBNLELDFO(int _003C_003E1__state)
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
				goto IL_003b;
			case 1:
				_003C_003E1__state = -1;
				goto IL_003b;
			case 2:
				{
					_003C_003E1__state = -1;
					DialogueManager.Bark(bark, ((Component)GGFJGHHHEJC).transform);
					return false;
				}
				IL_003b:
				if (GGFJGHHHEJC.inBark)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
				return true;
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
	private sealed class IDIOKGAHHKO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WilsonNPC _003C_003E4__this;

		public int playerNum;

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
		public IDIOKGAHHKO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			WilsonNPC wilsonNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				wilsonNPC.StopConversation();
				if (OnlineManager.PlayingOnline())
				{
					wilsonNPC.onlineDialogue.SendStopConversation();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				wilsonNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				wilsonNPC.NJJCCIBDAPM();
				wilsonNPC.SelectDialogueUI(playerNum);
				wilsonNPC.CheckPossibleStates(playerNum);
				AnimatorStateInfo currentAnimatorStateInfo = wilsonNPC.wilsonAnimation.animator.GetCurrentAnimatorStateInfo(0);
				if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
				{
					Debug.Log((object)"Look");
					wilsonNPC.LookAtPlayer();
				}
				wilsonNPC.mouseUpTrigger = true;
				wilsonNPC.dialogue.OnUse();
				wilsonNPC.BEGCPKOAJCP = null;
				return false;
			}
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

	private static WilsonNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public NPCAnimation wilsonAnimation;

	public float timeBarks;

	private int GAGJHPKONIC;

	private int EBFHLIJCFOF;

	private float FDBCHJMHBKF;

	private float IEIHJNPHGAJ;

	private float IFGFABPMGGK = 2f;

	private float PMCKBLAPLKK = 1f;

	private bool HCCBOAMEEIJ = true;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_11";

	public static WilsonNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void CLJBKGOGBII()
	{
		PPHECNNMCNF();
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
		if (wilsonAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(1) && PlayerController.GetPlayer(1).characterAnimation.animator.GetBool("Moving"))
				{
					wilsonAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = true;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IsInDialogue(2) && PlayerController.GetPlayer(2).characterAnimation.animator.GetBool("Moving"))
			{
				wilsonAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
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

	[SpecialName]
	public static WilsonNPC DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator BEGMJLGDBAD(string GAGJHPKONIC)
	{
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		DialogueManager.Bark(GAGJHPKONIC, ((Component)GGFJGHHHEJC).transform);
	}

	private IEnumerator KFAOHCKAGIK(string GAGJHPKONIC)
	{
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		DialogueManager.Bark(GAGJHPKONIC, ((Component)GGFJGHHHEJC).transform);
	}

	public void CPFEBDHKJHN()
	{
		ShopUI.IEABDMDELFO(OFLELHKKNKC().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(BDAGIEIJOOG().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private IEnumerator BMIAIANJHDD(string GAGJHPKONIC)
	{
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		DialogueManager.Bark(GAGJHPKONIC, ((Component)GGFJGHHHEJC).transform);
	}

	private IEnumerator GAAJGBDPDMD(int JIIGOACEIKL)
	{
		return new IDIOKGAHHKO(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void FJIJNLKJGKC()
	{
		NOENLKHOFGK();
	}

	[SpecialName]
	public static WilsonNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	public override void InitDialogueStart()
	{
		if (mouseUpTrigger)
		{
			main = true;
			DisableDialogue();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.OnDialogueStart();
			}
			mouseUpTrigger = false;
		}
	}

	[SpecialName]
	public static WilsonNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void LOMMEJHJLBK()
	{
		ShopUI.IEKODILKIHJ(DIHCEGINELM().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(BGMJCCFNNDL().EHHOHCPHAAO).OpenUI();
	}

	public void OPGHBDIBDPC()
	{
		ShopUI.EAONFFENMCE(BGMJCCFNNDL().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void HEDGGNKENPB()
	{
		NOENLKHOFGK();
	}

	[SpecialName]
	public static WilsonNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator KMAAFPICLFK(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = wilsonAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = wilsonAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator KKKHEHHGDEO(int JIIGOACEIKL)
	{
		return new IDIOKGAHHKO(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator FCBLIFMAHMC(string GAGJHPKONIC)
	{
		return new ENBBNLELDFO(1)
		{
			bark = GAGJHPKONIC
		};
	}

	private IEnumerator EGKACBAALDI(string GAGJHPKONIC)
	{
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		DialogueManager.Bark(GAGJHPKONIC, ((Component)GGFJGHHHEJC).transform);
	}

	private void NOENLKHOFGK()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(1)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(8)).transform.position, ((Component)this).transform.position);
		}
		if (wilsonAnimation.CNKHDCIKHCO && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(1) && PlayerController.GetPlayer(0).characterAnimation.animator.GetBool("Intro11"))
				{
					wilsonAnimation.LookAtObject(((Component)PlayerController.OPHDCMJLLEC(0)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(0) && PlayerController.OPHDCMJLLEC(7).characterAnimation.animator.GetBool("ReceiveResetBento"))
			{
				wilsonAnimation.DGJJGINNOOH(((Component)PlayerController.OPHDCMJLLEC(4)).gameObject);
				busy = false;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null)
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
			HCCBOAMEEIJ = true;
		}
	}

	private IEnumerator POAGHBLBIDD(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		AnimatorStateInfo currentAnimatorStateInfo = wilsonAnimation.animator.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Idle"))
		{
			Debug.Log((object)"Look");
			LookAtPlayer();
		}
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void IBFBBFGBKAD()
	{
		dialogue.OnUse();
	}

	private IEnumerator JHLLNJLMDDL(string GAGJHPKONIC)
	{
		while (GGFJGHHHEJC.inBark)
		{
			yield return null;
		}
		yield return CommonReferences.wait01;
		DialogueManager.Bark(GAGJHPKONIC, ((Component)GGFJGHHHEJC).transform);
	}

	private IEnumerator LMKGEMBCIBB(int JIIGOACEIKL)
	{
		return new IDIOKGAHHKO(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse)
			{
				AnimatorStateInfo currentAnimatorStateInfo = wilsonAnimation.animator.GetCurrentAnimatorStateInfo(0);
				if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Sleep") && canTalk)
				{
					if (IsAvailableByProximity(JIIGOACEIKL))
					{
						if (BEGCPKOAJCP == null)
						{
							BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KACNGNMNFNK(JIIGOACEIKL));
						}
						return true;
					}
					goto IL_0083;
				}
			}
			if (!canTalk && !inUse)
			{
				StartObserverDialogue(JIIGOACEIKL);
			}
		}
		goto IL_0083;
		IL_0083:
		return false;
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	private void OICHMCIHMDP()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.NoPlayers())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(5)).transform.position, ((Component)this).transform.position);
		}
		if (wilsonAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(0) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("Received request begin replay"))
				{
					wilsonAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
					busy = false;
					HCCBOAMEEIJ = false;
				}
			}
			else if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(5) && PlayerController.OPHDCMJLLEC(1).characterAnimation.animator.GetBool("ActionBar7"))
			{
				wilsonAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(3)).gameObject, MAPFDGCKBLD: false);
				busy = true;
				HCCBOAMEEIJ = false;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null)
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
			HCCBOAMEEIJ = false;
		}
	}

	private void FixedUpdate()
	{
		KCNFAHCOPJI();
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			base.OnDestroy();
		}
	}

	public void PDFJIALIGCC(string bark)
	{
		((MonoBehaviour)BGMJCCFNNDL()).StartCoroutine(BMIAIANJHDD(bark));
	}

	public void GHHNOBDPPEP(string emotion)
	{
		DIHCEGINELM().emotionsController.EMMBEAHMDHE(emotion);
	}

	private IEnumerator JJIOFIPPHLO(string GAGJHPKONIC)
	{
		return new ENBBNLELDFO(1)
		{
			bark = GAGJHPKONIC
		};
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		Result variable;
		if (PlayerInventory.GetPlayer(base.EHHOHCPHAAO).HasItem(ItemDatabaseAccessor.GetItem(3462)) || PlayerInventory.GetPlayer(base.EHHOHCPHAAO).HasItem(ItemDatabaseAccessor.GetItem(3463)) || PlayerInventory.GetPlayer(base.EHHOHCPHAAO).HasItem(ItemDatabaseAccessor.GetItem(3464)) || PlayerInventory.GetPlayer(base.EHHOHCPHAAO).HasItem(ItemDatabaseAccessor.GetItem(3465)))
		{
			variable = DialogueLua.GetVariable("LE_11");
			if (((Result)(ref variable)).asInt == 1)
			{
				dialogue.conversation = "Wilson/Trash";
				return;
			}
		}
		variable = DialogueLua.GetVariable("LE_11");
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "Wilson/Introduce";
		}
		else
		{
			dialogue.conversation = "Wilson/Stand";
		}
	}

	public void TestBark()
	{
		dialogue.OnUse();
	}

	public void BarkSequence(string bark)
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(BEGMJLGDBAD(bark));
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inInteractiveBark && !inUse && !inEvent)
		{
			AnimatorStateInfo currentAnimatorStateInfo = wilsonAnimation.animator.GetCurrentAnimatorStateInfo(0);
			if (!((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsTag("Sleep") && IsAvailableByProximity(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
				return true;
			}
		}
		return false;
	}

	public void BDDBGLDDMHM()
	{
		dialogue.OnUse();
	}

	public void AEMADJHOCGH()
	{
		dialogue.OnUse();
	}

	public void LookAtPlayer()
	{
		if (FDBCHJMHBKF < PMCKBLAPLKK)
		{
			wilsonAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK)
		{
			wilsonAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void OGFKFGAMGCE()
	{
		NOENLKHOFGK();
	}

	private void PPHECNNMCNF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CAGIBNLHJBN())
		{
			return;
		}
		FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(0)).transform.position, ((Component)this).transform.position);
		if ((Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position, ((Component)this).transform.position);
		}
		if (wilsonAnimation.LHGMJFGOHFD() && HCCBOAMEEIJ)
		{
			if (FDBCHJMHBKF < PMCKBLAPLKK)
			{
				if (!CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(0) && PlayerController.OPHDCMJLLEC(0).characterAnimation.animator.GetBool(""))
				{
					wilsonAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject, MAPFDGCKBLD: false);
					busy = true;
					HCCBOAMEEIJ = true;
				}
			}
			else if ((Object)(object)PlayerController.GetPlayer(5) != (Object)null && IEIHJNPHGAJ < PMCKBLAPLKK && !CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(0) && PlayerController.GetPlayer(5).characterAnimation.animator.GetBool(" does not exist"))
			{
				wilsonAnimation.DGJJGINNOOH(((Component)PlayerController.GetPlayer(0)).gameObject, MAPFDGCKBLD: false);
				busy = false;
				HCCBOAMEEIJ = true;
			}
		}
		else if ((Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null)
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

	private void PGJLFLKDLAE()
	{
		KCNFAHCOPJI();
	}
}
