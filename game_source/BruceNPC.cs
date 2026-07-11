using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BruceNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class HNPDCADPIMP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BruceNPC _003C_003E4__this;

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
			BruceNPC bruceNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				PetraNPC.GGFJGHHHEJC.StopAllDialogues();
				if (OnlineManager.PlayingOnline())
				{
					bruceNPC.onlineDialogue.SendStopConversation(2);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				bruceNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				bruceNPC.NJJCCIBDAPM();
				bruceNPC.noPortrait = true;
				bruceNPC.SelectDialogueUI(playerNum);
				bruceNPC.CheckPossibleStates(playerNum);
				bruceNPC.mouseUpTrigger = true;
				bruceNPC.dialogue.OnUse();
				bruceNPC.BEGCPKOAJCP = null;
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

	private Coroutine BEGCPKOAJCP;

	private static BruceNPC IADEMLIIDPC;

	public static BruceNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void PJGJGBEADMB(string emotion)
	{
		BDAGIEIJOOG().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void HCCFPBJNLKC(string emotion)
	{
		BNBMNOMFFBE().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BruceNPC LHKFIDJFPDB()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator OJAFNDLNBAM(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void ONMNKLPNCAH(string emotion)
	{
		LHKFIDJFPDB().emotionsController.StartEmotion(emotion);
	}

	public void LJFLICPLPAE(string emotion)
	{
		GIKECEGLFOH().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void ACMMENIGKLK(string emotion)
	{
		EJECEDMPCOH().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void DLAKKOCDNBI(string emotion)
	{
		LKOABOAADCD().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void EEBOKKANBEM(string emotion)
	{
		POINNCPMEIG().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static BruceNPC PFHFIJDDOME()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator EIPJDJJOMFN(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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
	public static BruceNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator BFOANMDADNO(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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
	public static BruceNPC JFJOKGAOPHA()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator FLGCODNHBAN(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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
	public static BruceNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	public void GFNPDMNLNAP(string emotion)
	{
		MAAAKALBBEE().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BruceNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	public void ONJOFPIPANN(string emotion)
	{
		NBENKBAIBOO().emotionsController.StartEmotion(emotion);
	}

	private IEnumerator KEGMKOJDFKE(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void LGOKBJEJDKK(string emotion)
	{
		KCFGPDHELKP().emotionsController.StartEmotion(emotion);
	}

	private IEnumerator KMAAFPICLFK(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator FFBABCOAAGB(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void OEPALJIDLHC(string emotion)
	{
		EKDNJDJHONF().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BruceNPC LKDJNKLJKGO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC GIKECEGLFOH()
	{
		return IADEMLIIDPC;
	}

	public void IOKILGMHFNE(string emotion)
	{
		GFMBEDCANNI().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BruceNPC GDAHBDMFPCB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC PNHHCHJCDNM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	public void GOLGBIFLEDM(string emotion)
	{
		LADDMEMMJFP().emotionsController.StartEmotion(emotion);
	}

	public void MLAEBHMJCJJ(string emotion)
	{
		DOIKFJDLKJP().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void LEADONDEOIC(string emotion)
	{
		BDAGIEIJOOG().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BruceNPC BNBMNOMFFBE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	public void GAADIDHFPGP(string emotion)
	{
		EKDNJDJHONF().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BruceNPC CFLBNDLLABP()
	{
		return IADEMLIIDPC;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private IEnumerator OJEHIJGNNPB(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	private IEnumerator KNEABHKNKFH(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator OEKHEHLIFDA(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator NCJMHOFECIG(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static BruceNPC KFGKCKCDMLG()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC MPJJAPCFENH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC LFPEPJBNCBF()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	public void MAOACOAHDHF(string emotion)
	{
		DPJEGJBHBNP().emotionsController.StartEmotion(emotion);
	}

	public void HPKIOFCAOGB(string emotion)
	{
		GFMBEDCANNI().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BruceNPC CFLFMDCHNLA()
	{
		return IADEMLIIDPC;
	}

	public void AAOEFHODHHA(string emotion)
	{
		BGMJCCFNNDL().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator PFFLNKEHHMN(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BPGJOFGCCIN(string emotion)
	{
		PDECKLKPKCG().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BruceNPC IELEBCAELNI()
	{
		return IADEMLIIDPC;
	}

	public void EICNDMGMPLE(string emotion)
	{
		PFHFIJDDOME().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BruceNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator MAJHLPCGBOK(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void HBJOLEPBLPH(string emotion)
	{
		BDAGIEIJOOG().emotionsController.NBFIDOGMLOK(emotion);
	}

	private IEnumerator EAAPAJAFMMD(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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
	public static BruceNPC KADHMEPDIKM()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void NLBFEHJDELC(string emotion)
	{
		CFLBNDLLABP().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void AKCJMLPHFEB(string emotion)
	{
		KCFGPDHELKP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator CMKNIFPHPHD(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void IBDHCOEBDPF(string emotion)
	{
		HLMGBEGEAPC().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void LBEIJJCJLHB(string emotion)
	{
		HGJMGNJOHGF().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BruceNPC CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator JPBMMJJJJJC(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BEECLHMOEIP(string emotion)
	{
		LKDJNKLJKGO().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator JPNBKLIEADD(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator HKLIOLNILJJ(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	private IEnumerator OHGPGJJBEKK(int JIIGOACEIKL)
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
		dialogue.conversation = "City/Bruce/Stand";
	}

	private IEnumerator JNHHAFBNFDI(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	private IEnumerator APEJOHGFHFE(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void JAGIEEJADMN(string emotion)
	{
		JFJOKGAOPHA().emotionsController.NBFIDOGMLOK(emotion);
	}

	private IEnumerator GHFIAHDPKJE(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
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
	public static BruceNPC LADDMEMMJFP()
	{
		return IADEMLIIDPC;
	}

	public void IKFIADANHCE(string emotion)
	{
		CNDNOECMKME().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BruceNPC NHKAFANMEJC()
	{
		return IADEMLIIDPC;
	}

	public void DOCHPOEOOAL(string emotion)
	{
		DCAEBALADIM().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void CPGDOFFNPLD(string emotion)
	{
		CFLBNDLLABP().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BruceNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	public void APEGJBHIPBF(string emotion)
	{
		PNHHCHJCDNM().emotionsController.DCCNJLBLFGI(emotion);
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
			noPortrait = true;
			StartObserverDialogue(JIIGOACEIKL);
		}
		return false;
	}

	[SpecialName]
	public static BruceNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator OHMBCGJBELG(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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
	public static BruceNPC GFMBEDCANNI()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator OEANNLEHEAI(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	private IEnumerator GCGAILMICOB(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void ALJAPDBHANO(string emotion)
	{
		KCFGPDHELKP().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BruceNPC KCFGPDHELKP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	public void FMCMAMOBOLN(string emotion)
	{
		BDAGIEIJOOG().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void ILLEBIGEIPC(string emotion)
	{
		KCFGPDHELKP().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void LILHBLEFJMM(string emotion)
	{
		DCAEBALADIM().emotionsController.NBFIDOGMLOK(emotion);
	}

	private IEnumerator JMJLJDBOCOP(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
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

	private IEnumerator BJOIBBHCHPH(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	private IEnumerator JNCLFOBMGDM(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void BMNFEAHLBJB(string emotion)
	{
		JFJOKGAOPHA().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator AFACOHNBGFK(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void JLFNGOAPGOM(string emotion)
	{
		LKOABOAADCD().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void BKILDJBIIHL(string emotion)
	{
		LADDMEMMJFP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator GOAHFICLDIL(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	private IEnumerator OGCBCPFFFOI(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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
	public static BruceNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	public void KAMIENKCHGK(string emotion)
	{
		GDAHBDMFPCB().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BruceNPC EJECEDMPCOH()
	{
		return IADEMLIIDPC;
	}

	public void LMEMMBGFPII(string emotion)
	{
		MPJJAPCFENH().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void AFDECDJICPD(string emotion)
	{
		POINNCPMEIG().emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator KPAAABNEPHG(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void OJKEDMIKKCE(string emotion)
	{
		NBKKEINELDN().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BruceNPC HGJMGNJOHGF()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator NLNEKJMFCDJ(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	public void FPDDJNENJHJ(string emotion)
	{
		NHKAFANMEJC().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BruceNPC BNDMEINJPAN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC NBENKBAIBOO()
	{
		return IADEMLIIDPC;
	}

	public void LGJONNIEAOM(string emotion)
	{
		LKOABOAADCD().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void IDKPDDOOJFN(string emotion)
	{
		DEGPIHEEFHJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator MHMCELIIKGO(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BJOILGMEFGD(string emotion)
	{
		BNDMEINJPAN().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static BruceNPC NGIMIHFFNMH()
	{
		return IADEMLIIDPC;
	}

	public void PAIMGGCBBMB(string emotion)
	{
		NHKAFANMEJC().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator JFPOPJGOFKH(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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
		CFLFMDCHNLA().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator POAGHBLBIDD(int JIIGOACEIKL)
	{
		PetraNPC.GGFJGHHHEJC.StopAllDialogues();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation(2);
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

	private IEnumerator AAHEIGEJKNA(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void OHILDJPNDEF(string emotion)
	{
		BDAGIEIJOOG().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator JLMIOIBKAKO(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static BruceNPC MPLODJJFKAM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BruceNPC HLMGBEGEAPC()
	{
		return IADEMLIIDPC;
	}

	public void OGIKAGKGKHK(string emotion)
	{
		NHKAFANMEJC().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BruceNPC IECOPNFJBFD()
	{
		return IADEMLIIDPC;
	}

	public void PALMKNNGBBI(string emotion)
	{
		LFPEPJBNCBF().emotionsController.StartEmotion(emotion);
	}

	public void BPDPPBDHJEL(string emotion)
	{
		MAAAKALBBEE().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BruceNPC DPJEGJBHBNP()
	{
		return IADEMLIIDPC;
	}
}
