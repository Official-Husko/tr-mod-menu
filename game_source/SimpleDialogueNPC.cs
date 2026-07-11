using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class SimpleDialogueNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class LDEIKNIMPEI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleDialogueNPC _003C_003E4__this;

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
		public LDEIKNIMPEI(int _003C_003E1__state)
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
			SimpleDialogueNPC simpleDialogueNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				simpleDialogueNPC.dialogue.startConversationEntryID = simpleDialogueNPC.entryId;
				simpleDialogueNPC.dialogue.OnUse();
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
	private sealed class DFLEKAJDKDB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleDialogueNPC _003C_003E4__this;

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
		public DFLEKAJDKDB(int _003C_003E1__state)
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
			SimpleDialogueNPC simpleDialogueNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				simpleDialogueNPC.StopConversation();
				if (OnlineManager.PlayingOnline())
				{
					simpleDialogueNPC.onlineDialogue.SendStopConversation();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				simpleDialogueNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				simpleDialogueNPC.barkInit = false;
				simpleDialogueNPC.NJJCCIBDAPM();
				if (!simpleDialogueNPC.noBarkDialogue)
				{
					simpleDialogueNPC.barkDialogue = true;
				}
				else
				{
					simpleDialogueNPC.barkDialogue = false;
				}
				if (simpleDialogueNPC.noActorPortrait)
				{
					simpleDialogueNPC.noPortrait = true;
				}
				else
				{
					simpleDialogueNPC.noPortrait = false;
				}
				simpleDialogueNPC.SelectDialogueUI(playerNum);
				simpleDialogueNPC.CheckPossibleStates(playerNum);
				simpleDialogueNPC.mouseUpTrigger = true;
				simpleDialogueNPC.dialogue.OnUse();
				simpleDialogueNPC.BEGCPKOAJCP = null;
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

	private static SimpleDialogueNPC[] GJBBNHCMNJN = new SimpleDialogueNPC[51];

	public int id;

	public bool noBark;

	public bool noBarkDialogue;

	public bool noActorPortrait;

	[ConversationPopup(false)]
	public string conversation = string.Empty;

	[ConversationPopup(false)]
	public string bark = string.Empty;

	public float minBarkTime;

	public float maxBarkTime;

	[HideInInspector]
	public float barksTime;

	[HideInInspector]
	public bool barkInit;

	public void DOCHPOEOOAL(string emotion)
	{
		CIGMKCDEDGB(id).emotionsController.PIOCPGKDAOF(emotion);
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
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator FLFNDIIKKJI(int JIIGOACEIKL)
	{
		return new DFLEKAJDKDB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public static SimpleDialogueNPC CFPKMDMEMMP(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void ILLEBIGEIPC(string emotion)
	{
		PNBKEEPLOBK(id).emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator EJGGJPDOPDD(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator MPFOBDNPJBO(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator GMJJJIFGILC()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	protected virtual void KGPOCJEHHHH()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator IDDJECHKPOJ(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator DDPBPCHOCCK()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	private IEnumerator ONGPINMHHJN()
	{
		return new LDEIKNIMPEI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MCIEAPPDFKH(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HMLCIOJPFGK());
		}
		barkInit = false;
	}

	public static SimpleDialogueNPC IGLNLNNIHMK(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void OJAIPBJAMNO(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HOPKCLCKNMC());
		}
		barkInit = false;
	}

	protected override void NJJCCIBDAPM()
	{
		if (barkInit)
		{
			dialogue.conversation = bark;
		}
		else
		{
			dialogue.conversation = conversation;
		}
	}

	private IEnumerator DICGBNBBFLI()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	private IEnumerator DDDMMDDLCNC(int JIIGOACEIKL)
	{
		return new DFLEKAJDKDB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void CGDBAGPCOLH(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NOMPHNPNBCH());
		}
		barkInit = false;
	}

	protected virtual void JLCFNPBBKEK()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	protected virtual void MKLIAMJFHOF()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	protected virtual void IDPHKHGHJGN()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = true;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator BFANBIPCHBJ()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	public void LMIMOMALGDN(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HPAKACGJCAG());
		}
		barkInit = false;
	}

	public void JCNKIPBPOFC(string emotion)
	{
		BGNJFAJMAJN(id).emotionsController.StartEmotion(emotion);
	}

	protected virtual void OKAPGNGLOHO()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator HPAKACGJCAG()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	public void MHAOGIMHLAI(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KANNGCJNCCF());
		}
		barkInit = false;
	}

	public void IGNCCLNIIJM(string emotion)
	{
		PNBKEEPLOBK(id).emotionsController.StartEmotion(emotion);
	}

	public static SimpleDialogueNPC EKNJKOBMPOM(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	private IEnumerator IOKBJAPAJPB(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator OEGGNHHEGKI()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	public static SimpleDialogueNPC FABMMBDBNHG(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	private IEnumerator LOBPKLGMNCD()
	{
		return new LDEIKNIMPEI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KIDDNGOMMJH(string emotion)
	{
		FLFDIGHFHJM(id).emotionsController.PIOCPGKDAOF(emotion);
	}

	private IEnumerator DJOOPODBHBB()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	protected virtual void PBFGFECPPPO()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	protected virtual void HOFKJPBBLGP()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator MFBGMANINML(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator KFKAPPJICEN()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	public void GGGNPPBBCKJ(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(DDPBPCHOCCK());
		}
		barkInit = false;
	}

	protected virtual void CMLLBIDFNEB()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator JNCLFOBMGDM(int JIIGOACEIKL)
	{
		return new DFLEKAJDKDB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator IEAMJCICNFD()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	public void NJGKPGHNLDO(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AHEKOGIDOPI());
		}
		barkInit = false;
	}

	public static SimpleDialogueNPC CLJJHGKNIKO(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void BOIOLKHGNPO(string emotion)
	{
		BGNJFAJMAJN(id).emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EPMNMALMHKN(string emotion)
	{
		PNBKEEPLOBK(id).emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator IOMAPFEACFP()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	protected virtual void EOGHJNGJFID()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	protected override void Update()
	{
		base.Update();
		if (!noBark)
		{
			if (Time.time > barksTime && !inUse && !inBark)
			{
				barkInit = true;
				NJJCCIBDAPM();
				barkDialogue = true;
				SelectDialogueUI();
				main = true;
				DisableDialogue();
				dialogue.OnUse();
				barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
				barkInit = false;
				onlineBarkDialogue = true;
			}
			else if (inUse || inBark)
			{
				barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	protected virtual void APEIPGIHEKP()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public void PJGJGBEADMB(string emotion)
	{
		NMKCPJKNHCE(id).emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator EGJBFJGPLNE()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	private IEnumerator JMMNLAFGAKH()
	{
		return new LDEIKNIMPEI(1)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual void JECHMEFJABD()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator NDJBFCCNBAF(int JIIGOACEIKL)
	{
		return new DFLEKAJDKDB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator HOPKCLCKNMC()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	protected virtual void PLHEHGHFCJI()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator AHEKOGIDOPI()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	private IEnumerator MLEHFHNGMLG(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public static SimpleDialogueNPC CIGMKCDEDGB(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	private IEnumerator MAJHLPCGBOK(int JIIGOACEIKL)
	{
		return new DFLEKAJDKDB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	protected virtual void HNEGFBCKIIJ()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator HLDMGIOINAH(int JIIGOACEIKL)
	{
		return new DFLEKAJDKDB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public static SimpleDialogueNPC FHPDKLMFCLC(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void BGDEBCDFJCF(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(PCCOKAKHMFD());
		}
		barkInit = true;
	}

	private IEnumerator FLKNBBIFIOA()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	public void CBALKGMHPBJ(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HMLCIOJPFGK());
		}
		barkInit = false;
	}

	public static SimpleDialogueNPC BGNJFAJMAJN(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void OJKEDMIKKCE(string emotion)
	{
		OCLCOPFJHEN(id).emotionsController.NBFIDOGMLOK(emotion);
	}

	private IEnumerator CLHIBLHMFFP(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public void KKPEIJKIFKC(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KDFKLPGMJAJ());
		}
		barkInit = true;
	}

	public void BONCPBPBCJN(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KANNGCJNCCF());
		}
		barkInit = true;
	}

	private IEnumerator HMLCIOJPFGK()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	protected virtual void HELHNJDFPPF()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator KANNGCJNCCF()
	{
		return new LDEIKNIMPEI(1)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual void PGJJBPALEGM()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator IBAHOLKDDJO(int JIIGOACEIKL)
	{
		return new DFLEKAJDKDB(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator PCCOKAKHMFD()
	{
		return new LDEIKNIMPEI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NALMEBHEFND(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HPAKACGJCAG());
		}
		barkInit = false;
	}

	protected virtual void Start()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public void CCONMBKJBOM(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KANNGCJNCCF());
		}
		barkInit = false;
	}

	public void LFFJJDKCOPJ(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(IOMAPFEACFP());
		}
		barkInit = false;
	}

	public static SimpleDialogueNPC NMKCPJKNHCE(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public override DialogueNPCBase GetInstance()
	{
		return null;
	}

	public void OIDJLGHMPGH(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NOMPHNPNBCH());
		}
		barkInit = true;
	}

	protected virtual void BOIGOJGNNAK()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	protected virtual void HJDLNCOAKIK()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator KDFKLPGMJAJ()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	private IEnumerator PFFLNKEHHMN(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator KNGGLPDOMEN(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	protected virtual void OKHHJDNNNPF()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && canTalk && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
			return true;
		}
		ButtonsContext.GetPlayer(base.EHHOHCPHAAO).ResetButtons();
		return false;
	}

	private IEnumerator GAGCFKKHAMK()
	{
		return new LDEIKNIMPEI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void StartBark(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KFKAPPJICEN());
		}
		barkInit = false;
	}

	protected virtual void GBFPCABGAII()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && !inEvent && !inBark && canTalk && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (BEGCPKOAJCP == null)
			{
				BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KACNGNMNFNK(JIIGOACEIKL));
			}
			return true;
		}
		return false;
	}

	public static SimpleDialogueNPC OCLCOPFJHEN(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	private IEnumerator DEHLHFDGJIG(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator NOMPHNPNBCH()
	{
		yield return CommonReferences.wait05;
		dialogue.startConversationEntryID = entryId;
		dialogue.OnUse();
	}

	public void OPDLJIPHEDB(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NOMPHNPNBCH());
		}
		barkInit = false;
	}

	private IEnumerator IIBLIBHCECC(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private IEnumerator GOAHFICLDIL(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public static SimpleDialogueNPC GetInstances(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void COPJJNPEIJE(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = true;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AHEKOGIDOPI());
		}
		barkInit = true;
	}

	public void HMEKFPHDAML(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI(1);
		if (CDPAMNIPPEC)
		{
			main = false;
			DisableDialogue(CKJIHLIFPMF: true);
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EGJBFJGPLNE());
		}
		barkInit = true;
	}

	protected virtual void AEPBFPCHGPP()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public static SimpleDialogueNPC GFCCIHHJIHA(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public override void InitDialogueStart()
	{
		if (mouseUpTrigger)
		{
			main = true;
			onlineBarkDialogue = barkDialogue;
			inInteractiveDialogue = true;
			DisableDialogue();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.OnDialogueStart();
			}
			mouseUpTrigger = false;
		}
	}

	protected virtual void ODKGLIDMCNP()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = true;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public static SimpleDialogueNPC PNBKEEPLOBK(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void ACMMENIGKLK(string emotion)
	{
		FJCKKFLDKBL(id).emotionsController.GPLECKGJFKM(emotion);
	}

	public void ONMNKLPNCAH(string emotion)
	{
		FLFDIGHFHJM(id).emotionsController.EMMBEAHMDHE(emotion);
	}

	public static SimpleDialogueNPC FLFDIGHFHJM(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public static SimpleDialogueNPC EJHDJKECMMJ(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	public void PFFAJBLGFDO(string emotion)
	{
		OCLCOPFJHEN(id).emotionsController.NMAPMPBAGMM(emotion);
	}

	public void StartEmotions(string emotion)
	{
		GetInstances(id).emotionsController.StartEmotion(emotion);
	}

	protected virtual void NDGFPPOBCNP()
	{
		if (OnlineManager.ClientOnline())
		{
			((Behaviour)this).enabled = true;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public void KAPBBMKKLPA(bool CDPAMNIPPEC = false, bool OAMGEFAAKMI = true)
	{
		barkInit = OAMGEFAAKMI;
		NJJCCIBDAPM();
		barkDialogue = false;
		SelectDialogueUI();
		if (CDPAMNIPPEC)
		{
			main = true;
			DisableDialogue();
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(IEAMJCICNFD());
		}
		barkInit = true;
	}

	public static SimpleDialogueNPC FJCKKFLDKBL(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	protected override void Awake()
	{
		base.Awake();
		GJBBNHCMNJN[id] = this;
	}

	public void EFOEDOJOFEH(string emotion)
	{
		GFCCIHHJIHA(id).emotionsController.NBFIDOGMLOK(emotion);
	}

	public static SimpleDialogueNPC FFGFOMJIINE(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	private IEnumerator MKJAFLIOOIG(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	public static SimpleDialogueNPC HPNJBNCBMIK(int JFNMCNCHMEO)
	{
		return GJBBNHCMNJN[JFNMCNCHMEO];
	}

	private IEnumerator KLAHJNIGHMC(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	protected virtual void BGENEAOILOF()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			((Behaviour)this).enabled = false;
		}
		barksTime = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator CNEFNPILMPB(int JIIGOACEIKL)
	{
		StopConversation();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendStopConversation();
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		barkInit = false;
		NJJCCIBDAPM();
		if (!noBarkDialogue)
		{
			barkDialogue = true;
		}
		else
		{
			barkDialogue = false;
		}
		if (noActorPortrait)
		{
			noPortrait = true;
		}
		else
		{
			noPortrait = false;
		}
		SelectDialogueUI(JIIGOACEIKL);
		CheckPossibleStates(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}
}
