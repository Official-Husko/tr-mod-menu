using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OakNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class HNPDCADPIMP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OakNPC _003C_003E4__this;

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
			OakNPC oakNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				WoodyNPC.GGFJGHHHEJC.StopAllDialogues();
				if (OnlineManager.PlayingOnline())
				{
					oakNPC.onlineDialogue.SendStopConversation(4);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				oakNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				oakNPC.NJJCCIBDAPM();
				oakNPC.noPortrait = true;
				oakNPC.SelectDialogueUI(playerNum);
				oakNPC.CheckPossibleStates(playerNum);
				oakNPC.mouseUpTrigger = true;
				oakNPC.dialogue.OnUse();
				oakNPC.BEGCPKOAJCP = null;
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

	private static OakNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public static OakNPC GGFJGHHHEJC => IADEMLIIDPC;

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator MHMCELIIKGO(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static OakNPC ABDJJBFNLBJ()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator KEGMKOJDFKE(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void FACKKGAODPO(string emotion)
	{
		ECGIAEFKKNA().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void KIBIHBFJOJH(string emotion)
	{
		HNNJEBNIPOI().emotionsController.StartEmotion(emotion);
	}

	public void MONKBNPGGIG(string emotion)
	{
		DIHCEGINELM().emotionsController.NBFIDOGMLOK(emotion);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private IEnumerator PFFLNKEHHMN(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static OakNPC DICHPHEOINO()
	{
		return IADEMLIIDPC;
	}

	public void GDEEGJFFBKN(string emotion)
	{
		DIHCEGINELM().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void ALJAPDBHANO(string emotion)
	{
		MAIDHAPANEB().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator ACIEGAOHBMM(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static OakNPC OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator IOKBJAPAJPB(int JIIGOACEIKL)
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

	public void AKNIJKAKKFD(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static OakNPC HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OakNPC NGIMIHFFNMH()
	{
		return IADEMLIIDPC;
	}

	public void KDCHBIFCIBO(string emotion)
	{
		NEFIEJALANL().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator JMJLJDBOCOP(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static OakNPC MPFJOKOJIOO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OakNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OakNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	public void CJKKCFLCMKA(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static OakNPC OKAPNFPFPFP()
	{
		return IADEMLIIDPC;
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		if (animationBase.animator.GetBool("Pipe"))
		{
			dialogue.conversation = "City/Carpenters/Oak/Smoking";
		}
		else if (animationBase.animator.GetBool("Chisel"))
		{
			dialogue.conversation = "City/Carpenters/Oak/Chisel";
		}
		else
		{
			dialogue.conversation = "City/Carpenters/Oak/Stand";
		}
	}

	public void BOIOLKHGNPO(string emotion)
	{
		OKAPNFPFPFP().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void LBEIJJCJLHB(string emotion)
	{
		GGFJGHHHEJC.emotionsController.DCCNJLBLFGI(emotion);
	}

	public void FPKLJCGJBPL(string emotion)
	{
		HNNJEBNIPOI().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void BDLLGEDIHPA(string emotion)
	{
		NGIMIHFFNMH().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static OakNPC DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator EJGGJPDOPDD(int JIIGOACEIKL)
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
	public static OakNPC ECGIAEFKKNA()
	{
		return IADEMLIIDPC;
	}

	public void GAPGANPHAEI(string emotion)
	{
		ECGIAEFKKNA().emotionsController.GPLECKGJFKM(emotion);
	}

	public void EICNDMGMPLE(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static OakNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator NJEACJHONME(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator CMKNIFPHPHD(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator LKMKNLPHLNB(int JIIGOACEIKL)
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

	public void JDJGFIJPCIF(string emotion)
	{
		ECGIAEFKKNA().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static OakNPC MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	public void APPNAMFJDOA(string emotion)
	{
		DICHPHEOINO().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator IJHOKFCIICL(int JIIGOACEIKL)
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

	public void EFPPOOJFNJO(string emotion)
	{
		OOKBNHMMFON().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static OakNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	public void ABCLGBAJPIK(string emotion)
	{
		OMFKNGDCJFN().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void HICGHFBHDHG(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static OakNPC CMIHGBHPLFP()
	{
		return IADEMLIIDPC;
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

	private IEnumerator KMJKDICGJPP(int JIIGOACEIKL)
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

	public void HMEFIIDEMOL(string emotion)
	{
		NGIMIHFFNMH().emotionsController.PIOCPGKDAOF(emotion);
	}

	private IEnumerator HBPJFPIAOPI(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
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

	private IEnumerator KKIPDJNOAML(int JIIGOACEIKL)
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
	public static OakNPC NEFIEJALANL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OakNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}
}
