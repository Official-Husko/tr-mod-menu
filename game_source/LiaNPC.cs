using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class LiaNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class NNHPFJGMBFG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LiaNPC _003C_003E4__this;

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
		public NNHPFJGMBFG(int _003C_003E1__state)
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
			LiaNPC liaNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (!liaNPC.inInteractiveDialogue)
				{
					liaNPC.StopConversation();
					if (OnlineManager.PlayingOnline())
					{
						liaNPC.onlineDialogue.SendStopConversation(8);
					}
				}
				if (!RhiaNPC.GGFJGHHHEJC.inInteractiveDialogue)
				{
					RhiaNPC.GGFJGHHHEJC.StopConversation();
					if (OnlineManager.PlayingOnline())
					{
						liaNPC.onlineDialogue.SendStopConversation(7);
					}
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				liaNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				liaNPC.NJJCCIBDAPM();
				liaNPC.SelectDialogueUI(playerNum);
				liaNPC.CheckPossibleStates(playerNum);
				if (RhiaNPC.GGFJGHHHEJC.dialogue.conversation == "City/Rhia/Introduce" && liaNPC.dialogue.conversation == "City/Rhia/Introduce")
				{
					RhiaNPC.GGFJGHHHEJC.mouseUpTrigger = true;
					RhiaNPC.GGFJGHHHEJC.dialogue.OnUse();
				}
				else
				{
					liaNPC.mouseUpTrigger = true;
					liaNPC.dialogue.OnUse();
				}
				liaNPC.BEGCPKOAJCP = null;
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

	private static LiaNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public Collider2D shopCollider;

	public float timeBarks;

	public static LiaNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void PIBMIDIMPHP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("UINextCategory");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static LiaNPC KIALFDOKABP()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator MHMCELIIKGO(int JIIGOACEIKL)
	{
		return new NNHPFJGMBFG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BPDPPBDHJEL(string emotion)
	{
		OMFKNGDCJFN().emotionsController.GPLECKGJFKM(emotion);
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && inShop && canTalk && RhiaNPC.GGFJGHHHEJC.canTalk)
			{
				if (IsAvailableByProximity(JIIGOACEIKL))
				{
					if (BEGCPKOAJCP == null)
					{
						BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KACNGNMNFNK(JIIGOACEIKL));
					}
					return true;
				}
				Debug.LogError((object)"Interaction was initiated, but the object is not in range. Only possible in online.");
			}
			else if (!canTalk && !inUse)
			{
				StartObserverDialogue(JIIGOACEIKL);
			}
		}
		return false;
	}

	[SpecialName]
	public static LiaNPC CHPEMJMLDCN()
	{
		return IADEMLIIDPC;
	}

	public void LGMDDMFKIAD(string emotion)
	{
		NBKKEINELDN().emotionsController.GPLECKGJFKM(emotion);
	}

	private void JLCFNPBBKEK()
	{
		PIBMIDIMPHP();
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && canTalk && RhiaNPC.GGFJGHHHEJC.canTalk)
			{
				if (IsAvailableByProximity(JIIGOACEIKL))
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
					return true;
				}
			}
			else if (!canTalk && !inUse && IsAvailableByProximity(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Listen"));
				return true;
			}
		}
		ButtonsContext.GetPlayer(base.EHHOHCPHAAO).ResetButtons();
		return false;
	}

	private IEnumerator IIBLIBHCECC(int JIIGOACEIKL)
	{
		return new NNHPFJGMBFG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void EFOEDOJOFEH(string emotion)
	{
		DEGPIHEEFHJ().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void LMEMMBGFPII(string emotion)
	{
		ELGNEJNLBNO().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static LiaNPC HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static LiaNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	public override void InitDialogueStart()
	{
		if (!mouseUpTrigger)
		{
			return;
		}
		if (RhiaNPC.GGFJGHHHEJC.dialogue.conversation == "City/Rhia/Introduce" && dialogue.conversation == "City/Rhia/Introduce")
		{
			RhiaNPC.GGFJGHHHEJC.main = true;
			RhiaNPC.GGFJGHHHEJC.DisableDialogue();
			if (OnlineManager.PlayingOnline())
			{
				RhiaNPC.GGFJGHHHEJC.onlineDialogue.OnDialogueStart();
			}
		}
		else
		{
			main = true;
			DisableDialogue();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.OnDialogueStart();
			}
		}
		mouseUpTrigger = false;
	}

	public void HLFLPNOOMNF()
	{
		ShopUI.JCBPABNCBPI(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(DEGPIHEEFHJ().EHHOHCPHAAO).OpenUI();
	}

	private void CFHOODNCOLK()
	{
		PIBMIDIMPHP();
	}

	[SpecialName]
	public static LiaNPC AJIGOHGPFPP()
	{
		return IADEMLIIDPC;
	}

	public void EFPPOOJFNJO(string emotion)
	{
		HNNJEBNIPOI().emotionsController.GPLECKGJFKM(emotion);
	}

	public void IOKIJIHFLKJ()
	{
		ShopUI.JCBPABNCBPI(KIALFDOKABP().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(NBKKEINELDN().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static LiaNPC NGIMIHFFNMH()
	{
		return IADEMLIIDPC;
	}

	private void NFABFPFLNEE()
	{
		PIBMIDIMPHP();
	}

	private void Start()
	{
		CheckExclamation();
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void DNHIHIIOINE(string emotion)
	{
		OMFKNGDCJFN().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void JPHEOLEEAPB()
	{
		LPEAJGIHMKI();
	}

	private IEnumerator EJGGJPDOPDD(int JIIGOACEIKL)
	{
		return new NNHPFJGMBFG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void FKMBKMPOMIH()
	{
		ShopUI.IEABDMDELFO(HNNJEBNIPOI().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(DEGPIHEEFHJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void DPBKPBPGCHO()
	{
		ShopUI.EPKNOMLADCL(DEGPIHEEFHJ().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(CHPEMJMLDCN().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void KIOMHEIDHFN(string emotion)
	{
		AJIGOHGPFPP().emotionsController.StartEmotion(emotion);
	}

	public void JJJMGKMNECG()
	{
		ShopUI.IEKODILKIHJ(NBKKEINELDN().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(CHPEMJMLDCN().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static LiaNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static LiaNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	private void HJDLNCOAKIK()
	{
		CheckExclamation();
	}

	private IEnumerator EGICNNFFLBD(int JIIGOACEIKL)
	{
		return new NNHPFJGMBFG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void DCKKIDMJKJM()
	{
		PIBMIDIMPHP();
	}

	public void JDJGFIJPCIF(string emotion)
	{
		ABHIDHPMLLD().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static LiaNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	public void LILHBLEFJMM(string emotion)
	{
		DICHPHEOINO().emotionsController.StartEmotion(emotion);
	}

	public void LPEAJGIHMKI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Eating");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	protected override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (((Component)this).transform.position.x <= -526f && ((Component)this).transform.position.x >= -527f && ((Component)this).transform.position.y >= 99f && ((Component)this).transform.position.y <= 100f)
		{
			if (!((Behaviour)shopCollider).enabled)
			{
				inShop = true;
				((Behaviour)shopCollider).enabled = true;
			}
		}
		else if (((Behaviour)shopCollider).enabled)
		{
			inShop = false;
			((Behaviour)shopCollider).enabled = false;
		}
	}

	private void KACEOJDPLKB()
	{
		PIBMIDIMPHP();
	}

	public void EIBOMLNHNLP()
	{
		ShopUI.Get(OMFKNGDCJFN().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static LiaNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void PFLBPMIEKGF()
	{
		LPEAJGIHMKI();
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(8);
			}
		}
		if (!RhiaNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			RhiaNPC.GGFJGHHHEJC.StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(7);
			}
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		if (RhiaNPC.GGFJGHHHEJC.dialogue.conversation == "City/Rhia/Introduce" && dialogue.conversation == "City/Rhia/Introduce")
		{
			RhiaNPC.GGFJGHHHEJC.mouseUpTrigger = true;
			RhiaNPC.GGFJGHHHEJC.dialogue.OnUse();
		}
		else
		{
			mouseUpTrigger = true;
			dialogue.OnUse();
		}
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static LiaNPC DICHPHEOINO()
	{
		return IADEMLIIDPC;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_15");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator KMJKDICGJPP(int JIIGOACEIKL)
	{
		return new NNHPFJGMBFG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		RhiaNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("LE_15");
		if (((Result)(ref variable)).asInt == 0)
		{
			if (NewTutorialManager.CCCLOBIOMCL)
			{
				variable = DialogueLua.GetVariable("TutorialPhase");
				if (((Result)(ref variable)).asInt == 0)
				{
					DialogueLua.SetVariable("TutorialPhase", (object)2);
					goto IL_0075;
				}
			}
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				DialogueLua.SetVariable("TutorialPhase", (object)0);
			}
			goto IL_0075;
		}
		RhiaNPC.GGFJGHHHEJC.barkDialogue = false;
		RhiaNPC.GGFJGHHHEJC.SelectDialogueUI();
		dialogue.conversation = "City/Lia/Stand";
		return;
		IL_0075:
		RhiaNPC.GGFJGHHHEJC.barkDialogue = false;
		RhiaNPC.GGFJGHHHEJC.SelectDialogueUI();
		RhiaNPC.GGFJGHHHEJC.dialogue.conversation = "City/Rhia/Introduce";
		dialogue.conversation = "City/Rhia/Introduce";
	}

	private void LOHAMDHOLDD()
	{
		LPEAJGIHMKI();
	}

	private void IDPHKHGHJGN()
	{
		LPEAJGIHMKI();
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private void HPIMHEMJMAA()
	{
		PIBMIDIMPHP();
	}

	private void IMIONHLAKIH()
	{
		CheckExclamation();
	}

	public void FPKLJCGJBPL(string emotion)
	{
		DCAEBALADIM().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void IAFBFHALBJH(string emotion)
	{
		DCAEBALADIM().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void MICJOFHJLLF()
	{
		ShopUI.EPKNOMLADCL(AJIGOHGPFPP().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(ABHIDHPMLLD().EHHOHCPHAAO).OpenUI();
	}

	public void FACKKGAODPO(string emotion)
	{
		ELGNEJNLBNO().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator POAGHBLBIDD(int JIIGOACEIKL)
	{
		return new NNHPFJGMBFG(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static LiaNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	public void ONMNKLPNCAH(string emotion)
	{
		GGFJGHHHEJC.emotionsController.EMMBEAHMDHE(emotion);
	}

	public void OJKEDMIKKCE(string emotion)
	{
		HNNJEBNIPOI().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static LiaNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}
}
