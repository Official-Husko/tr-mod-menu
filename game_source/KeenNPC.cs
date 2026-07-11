using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KeenNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class HNPDCADPIMP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeenNPC _003C_003E4__this;

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
			KeenNPC keenNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				PetraNPC.GGFJGHHHEJC.StopAllDialogues();
				if (OnlineManager.PlayingOnline())
				{
					keenNPC.onlineDialogue.SendStopConversation(2);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				keenNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				keenNPC.NJJCCIBDAPM();
				keenNPC.noPortrait = true;
				keenNPC.SelectDialogueUI(playerNum);
				keenNPC.CheckPossibleStates(playerNum);
				keenNPC.mouseUpTrigger = true;
				keenNPC.dialogue.OnUse();
				keenNPC.BEGCPKOAJCP = null;
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

	private static KeenNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public static KeenNPC GGFJGHHHEJC => IADEMLIIDPC;

	[SpecialName]
	public static KeenNPC GFMBEDCANNI()
	{
		return IADEMLIIDPC;
	}

	public void CFJNIKJFCPE(string emotion)
	{
		EAGMIHGJKNB().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static KeenNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	public void ALJAPDBHANO(string emotion)
	{
		AJIGOHGPFPP().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void HJBBGFPGGDO(string emotion)
	{
		EAGMIHGJKNB().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void OOJEGKJLOED(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void ACMMENIGKLK(string emotion)
	{
		MNFMOEKMJKN().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void HPKIOFCAOGB(string emotion)
	{
		OOKBNHMMFON().emotionsController.StartEmotion(emotion);
	}

	public void BPDPPBDHJEL(string emotion)
	{
		MKIEMMGGFEE().emotionsController.PIOCPGKDAOF(emotion);
	}

	private IEnumerator HJJBMEOCLBJ(int JIIGOACEIKL)
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

	private IEnumerator NLOGJODCNNE(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BPGJOFGCCIN(string emotion)
	{
		BGMJCCFNNDL().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static KeenNPC OLHBLKIAFOM()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator KKIPDJNOAML(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator FFBABCOAAGB(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
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

	[SpecialName]
	public static KeenNPC DGCNCEDIFOF()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator POAGHBLBIDD(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static KeenNPC MKIEMMGGFEE()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator DDDMMDDLCNC(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator MAEJJNNLIJB(int JIIGOACEIKL)
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

	public void FACKKGAODPO(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator EJGGJPDOPDD(int JIIGOACEIKL)
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

	public void PGFPIOGKHJE(string emotion)
	{
		LANAINBEMCM().emotionsController.NBFIDOGMLOK(emotion);
	}

	private IEnumerator OJEHIJGNNPB(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static KeenNPC NGPHACGDNJN()
	{
		return IADEMLIIDPC;
	}

	public void LGJONNIEAOM(string emotion)
	{
		BGMJCCFNNDL().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static KeenNPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private IEnumerator MFBGMANINML(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
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

	public void MCPDJHICBLA(string emotion)
	{
		JCMKNNOEONP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator CGNHHKDIBCB(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void EEBOKKANBEM(string emotion)
	{
		NBKKEINELDN().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator OJAFNDLNBAM(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void CGCCNBHFLEK(string emotion)
	{
		DGCNCEDIFOF().emotionsController.EMMBEAHMDHE(emotion);
	}

	private IEnumerator IOKBJAPAJPB(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static KeenNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator KANGHFHJOJH(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator GEMHJPLFEGO(int JIIGOACEIKL)
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

	private IEnumerator PFFLNKEHHMN(int JIIGOACEIKL)
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

	public void GLJBJKJNHAN(string emotion)
	{
		GFMBEDCANNI().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static KeenNPC MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	public void LLGDPOAGOJI(string emotion)
	{
		DEGPIHEEFHJ().emotionsController.PIOCPGKDAOF(emotion);
	}

	private IEnumerator ODCBPOLKBAN(int JIIGOACEIKL)
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

	public void LGMDDMFKIAD(string emotion)
	{
		LANAINBEMCM().emotionsController.EMMBEAHMDHE(emotion);
	}

	private IEnumerator DFMBFIKIHEH(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator CGGOBAFJGNI(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator LKAFINELIDI(int JIIGOACEIKL)
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

	private IEnumerator IODLBPHBNEF(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator KMJKDICGJPP(int JIIGOACEIKL)
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
	public static KeenNPC CFHEJAGKIII()
	{
		return IADEMLIIDPC;
	}

	public void HFLEIKDDPCO(string emotion)
	{
		OOKBNHMMFON().emotionsController.PIOCPGKDAOF(emotion);
	}

	private IEnumerator JMJLJDBOCOP(int JIIGOACEIKL)
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
	public static KeenNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	public void BMLJMLBEAOO(string emotion)
	{
		GFMBEDCANNI().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static KeenNPC AGGAGCBAGLL()
	{
		return IADEMLIIDPC;
	}

	public void IGNCCLNIIJM(string emotion)
	{
		HEKFJEKFMNO().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void GFNPDMNLNAP(string emotion)
	{
		HLMGBEGEAPC().emotionsController.StartEmotion(emotion);
	}

	public void GOLGBIFLEDM(string emotion)
	{
		OPDKAPNDBJE().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static KeenNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	public void DBPBPKCKBCB(string emotion)
	{
		NGPHACGDNJN().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void KIDDNGOMMJH(string emotion)
	{
		MLPCDJPLBAC().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator CLHIBLHMFFP(int JIIGOACEIKL)
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

	public void ELBPCLPMHHE(string emotion)
	{
		OPDKAPNDBJE().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static KeenNPC EAGMIHGJKNB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KeenNPC DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KeenNPC OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	public void BOIOLKHGNPO(string emotion)
	{
		FMIDAFEGDCD().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator ACIEGAOHBMM(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	[SpecialName]
	public static KeenNPC JCMKNNOEONP()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator MPFOBDNPJBO(int JIIGOACEIKL)
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
	public static KeenNPC POAGAIBEFBF()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KeenNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator OHGPGJJBEKK(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator GAAJGBDPDMD(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void PDNOKJKMEEJ(string emotion)
	{
		DGCNCEDIFOF().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static KeenNPC AJIGOHGPFPP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KeenNPC FMIDAFEGDCD()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KeenNPC MMLBHCGFMMJ()
	{
		return IADEMLIIDPC;
	}

	public void EFPPOOJFNJO(string emotion)
	{
		NGPHACGDNJN().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void HICGHFBHDHG(string emotion)
	{
		LANAINBEMCM().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator CCAACBLJADK(int JIIGOACEIKL)
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

	private IEnumerator DJEAHHMKJNL(int JIIGOACEIKL)
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
	public static KeenNPC HLMGBEGEAPC()
	{
		return IADEMLIIDPC;
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

	private IEnumerator AAHEIGEJKNA(int JIIGOACEIKL)
	{
		return new HNPDCADPIMP(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator DBKBPBGMDNB(int JIIGOACEIKL)
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
	public static KeenNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	public void LILHBLEFJMM(string emotion)
	{
		OPDKAPNDBJE().emotionsController.EMMBEAHMDHE(emotion);
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

	public void IAFBGAMAOID(string emotion)
	{
		AGGAGCBAGLL().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static KeenNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator JNHIGBEDPIF(int JIIGOACEIKL)
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

	public void CPGDOFFNPLD(string emotion)
	{
		JCMKNNOEONP().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator FLFNDIIKKJI(int JIIGOACEIKL)
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
	public static KeenNPC ACPHFLBLJAA()
	{
		return IADEMLIIDPC;
	}

	public void JNKMIEOLHDD(string emotion)
	{
		MMLBHCGFMMJ().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void ILLEBIGEIPC(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static KeenNPC OPDKAPNDBJE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KeenNPC MNFMOEKMJKN()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator LKLBDDFNANK(int JIIGOACEIKL)
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

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		if (GGFJGHHHEJC.animationBase.animator.GetBool("Sharp"))
		{
			dialogue.conversation = "City/Keen/Sharp";
		}
		else
		{
			dialogue.conversation = "City/Keen/Stand";
		}
	}

	private IEnumerator EHCOBKDAGCC(int JIIGOACEIKL)
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

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	[SpecialName]
	public static KeenNPC CHKMFEFOFKJ()
	{
		return IADEMLIIDPC;
	}
}
