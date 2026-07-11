using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AshNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class HNPDCADPIMP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AshNPC _003C_003E4__this;

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
		public HNPDCADPIMP(int _003C_003E1__state)
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
			AshNPC ashNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
				if (OnlineManager.PlayingOnline())
				{
					ashNPC.onlineDialogue.SendStopConversation(4);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				ashNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				ashNPC.NJJCCIBDAPM();
				ashNPC.noPortrait = true;
				ashNPC.SelectDialogueUI(playerNum);
				ashNPC.CheckPossibleStates(playerNum);
				ashNPC.mouseUpTrigger = true;
				ashNPC.dialogue.OnUse();
				ashNPC.BEGCPKOAJCP = null;
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

	private static AshNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public static AshNPC GGFJGHHHEJC => IADEMLIIDPC;

	private IEnumerator ANANILBDEJE(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static AshNPC MNFMOEKMJKN()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator DEHLHFDGJIG(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		dialogue.conversation = "City/Carpenters/Ash/Stand";
	}

	public void LGOKBJEJDKK(string emotion)
	{
		BADFKMEJOKE().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void BMLJMLBEAOO(string emotion)
	{
		ILMPOAEALPP().emotionsController.StartEmotion(emotion);
	}

	public void BPGJOFGCCIN(string emotion)
	{
		MKIEMMGGFEE().emotionsController.PIOCPGKDAOF(emotion);
	}

	private IEnumerator KJPCKEPAEBB(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	public void OJECLFGAAPN(string emotion)
	{
		ILMPOAEALPP().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EFOEDOJOFEH(string emotion)
	{
		AAFOFNEHPLC().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static AshNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator DBKBPBGMDNB(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC MPFJOKOJIOO()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator CGGOBAFJGNI(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator MJEJNMPMPGK(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void LGJONNIEAOM(string emotion)
	{
		LKDJNKLJKGO().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static AshNPC CMIHGBHPLFP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC EJECEDMPCOH()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator GEMHJPLFEGO(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator BFOANMDADNO(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC BNDNMBGJEKP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC KFGKCKCDMLG()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator HBPJFPIAOPI(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC KIALFDOKABP()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator GGBFGBLMNKB(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC MJCMPKPCNGB()
	{
		return IADEMLIIDPC;
	}

	public void HCCFPBJNLKC(string emotion)
	{
		MPFJOKOJIOO().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static AshNPC LPFNKEOJJKE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC ILMPOAEALPP()
	{
		return IADEMLIIDPC;
	}

	public void HFLEIKDDPCO(string emotion)
	{
		LKDJNKLJKGO().emotionsController.NBFIDOGMLOK(emotion);
	}

	private IEnumerator KKKHEHHGDEO(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC MKIEMMGGFEE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	public void ELBPCLPMHHE(string emotion)
	{
		GFMBEDCANNI().emotionsController.GPLECKGJFKM(emotion);
	}

	public void GOLGBIFLEDM(string emotion)
	{
		LKDJNKLJKGO().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator LKMKNLPHLNB(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static AshNPC OACNNJCLEDE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC GFMBEDCANNI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator MKJAFLIOOIG(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void HMEFIIDEMOL(string emotion)
	{
		CMIHGBHPLFP().emotionsController.GPLECKGJFKM(emotion);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private IEnumerator POAGHBLBIDD(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator DFMBFIKIHEH(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator GAAJGBDPDMD(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void KIDDNGOMMJH(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void DJCHJDHPCLK(string emotion)
	{
		MOJDNGDNCCO().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void IBDHCOEBDPF(string emotion)
	{
		KHMEGDIABBF().emotionsController.GPLECKGJFKM(emotion);
	}

	public void LJFLICPLPAE(string emotion)
	{
		KHMEGDIABBF().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static AshNPC KHMEGDIABBF()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator NDJBFCCNBAF(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator LJFACPFOPLE(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static AshNPC MPJJAPCFENH()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator MDOPGPBPBMB(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	public void ILLEBIGEIPC(string emotion)
	{
		MJCMPKPCNGB().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void GHHNOBDPPEP(string emotion)
	{
		KIALFDOKABP().emotionsController.EMMBEAHMDHE(emotion);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void PAIMGGCBBMB(string emotion)
	{
		MNFMOEKMJKN().emotionsController.EMMBEAHMDHE(emotion);
	}

	public override void InitDialogueStart()
	{
		if (mouseUpTrigger)
		{
			inInteractiveDialogue = true;
			main = true;
			DisableDialogue();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.OnDialogueStart(inInteractiveDialogue);
			}
			mouseUpTrigger = false;
		}
	}

	[SpecialName]
	public static AshNPC OKAPNFPFPFP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC DGCNCEDIFOF()
	{
		return IADEMLIIDPC;
	}

	public void LBEIJJCJLHB(string emotion)
	{
		EJECEDMPCOH().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator NCJMHOFECIG(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator LMKGEMBCIBB(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator OJAFNDLNBAM(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void FPKLJCGJBPL(string emotion)
	{
		MOJDNGDNCCO().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void BDLLGEDIHPA(string emotion)
	{
		BNDNMBGJEKP().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void GLJBJKJNHAN(string emotion)
	{
		MMLBHCGFMMJ().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator NLOGJODCNNE(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator EAAPAJAFMMD(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator DDDMMDDLCNC(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static AshNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	public void OEPALJIDLHC(string emotion)
	{
		KNOKBLFFNLM().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static AshNPC LKDJNKLJKGO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC BADFKMEJOKE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC MOJDNGDNCCO()
	{
		return IADEMLIIDPC;
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && canTalk)
		{
			if (IsAvailableByProximity(JIIGOACEIKL))
			{
				if (BEGCPKOAJCP == null)
				{
					BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KACNGNMNFNK(JIIGOACEIKL));
				}
				return true;
			}
		}
		else if (!canTalk && !inUse)
		{
			WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
			noPortrait = true;
			StartObserverDialogue(JIIGOACEIKL);
		}
		return false;
	}

	private IEnumerator OJOEHLJDOEE(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator CGNHHKDIBCB(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator MFBGMANINML(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator OEANNLEHEAI(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator KANGHFHJOJH(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator IBAHOLKDDJO(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator EHCOBKDAGCC(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void KKCEACEHNOF(string emotion)
	{
		JHMAMLIPBNN().emotionsController.GPLECKGJFKM(emotion);
	}

	public void EEBOKKANBEM(string emotion)
	{
		OKAPNFPFPFP().emotionsController.StartEmotion(emotion);
	}

	private IEnumerator GOAHFICLDIL(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void OOJEGKJLOED(string emotion)
	{
		GFMBEDCANNI().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static AshNPC MMLBHCGFMMJ()
	{
		return IADEMLIIDPC;
	}

	public void PFFAJBLGFDO(string emotion)
	{
		LKDJNKLJKGO().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static AshNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC OLHBLKIAFOM()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator DFNOKKPPGBL(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	[SpecialName]
	public static AshNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC JEEGOBGDLPE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AshNPC DHDOLCONMFJ()
	{
		return IADEMLIIDPC;
	}

	public void GACCDKPCDMP(string emotion)
	{
		KIALFDOKABP().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static AshNPC AAFOFNEHPLC()
	{
		return IADEMLIIDPC;
	}

	public void APPNAMFJDOA(string emotion)
	{
		KNOKBLFFNLM().emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator MPFOBDNPJBO(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator APEJOHGFHFE(int JIIGOACEIKL)
	{
		WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(4);
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		noPortrait = true;
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void LAANEEHHDLL(string emotion)
	{
		JHMAMLIPBNN().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator KNEABHKNKFH(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void LGMDDMFKIAD(string emotion)
	{
		JHMAMLIPBNN().emotionsController.PIOCPGKDAOF(emotion);
	}
}
