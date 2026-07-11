using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class RhiaNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class NKBOOAMDLIA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RhiaNPC _003C_003E4__this;

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
		public NKBOOAMDLIA(int _003C_003E1__state)
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
			RhiaNPC rhiaNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (!rhiaNPC.inInteractiveDialogue)
				{
					rhiaNPC.StopConversation();
					if (OnlineManager.PlayingOnline())
					{
						rhiaNPC.onlineDialogue.SendStopConversation(7);
					}
				}
				if (!LiaNPC.GGFJGHHHEJC.inInteractiveDialogue)
				{
					LiaNPC.GGFJGHHHEJC.StopConversation();
					if (OnlineManager.PlayingOnline())
					{
						rhiaNPC.onlineDialogue.SendStopConversation(8);
					}
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				rhiaNPC.EHHOHCPHAAO = playerNum;
				CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(playerNum);
				rhiaNPC.NJJCCIBDAPM();
				rhiaNPC.CheckPossibleStates(playerNum);
				rhiaNPC.SelectDialogueUI(playerNum);
				rhiaNPC.mouseUpTrigger = true;
				rhiaNPC.dialogue.OnUse();
				rhiaNPC.BEGCPKOAJCP = null;
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

	private static RhiaNPC IADEMLIIDPC;

	private Coroutine BEGCPKOAJCP;

	public Collider2D shopCollider;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_15";

	public float minBarkTime;

	public float maxBarkTime;

	private float AELCMIGFOAK;

	public static RhiaNPC GGFJGHHHEJC => IADEMLIIDPC;

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && inShop && canTalk && LiaNPC.GGFJGHHHEJC.canTalk)
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
				StartObserverDialogue(JIIGOACEIKL);
			}
		}
		return false;
	}

	private IEnumerator KANGHFHJOJH(int JIIGOACEIKL)
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(7);
			}
		}
		if (!LiaNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			LiaNPC.GGFJGHHHEJC.StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(8);
			}
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		CheckPossibleStates(JIIGOACEIKL);
		SelectDialogueUI(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		LiaNPC.GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
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
		LiaNPC.GGFJGHHHEJC.barkDialogue = false;
		LiaNPC.GGFJGHHHEJC.SelectDialogueUI();
		dialogue.conversation = "City/Rhia/Stand";
		return;
		IL_0075:
		LiaNPC.GGFJGHHHEJC.barkDialogue = false;
		LiaNPC.GGFJGHHHEJC.SelectDialogueUI();
		dialogue.conversation = "City/Rhia/Introduce";
	}

	private void GNBNMHKDDMA()
	{
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !LiaNPC.ABHIDHPMLLD().inUse && !LiaNPC.KIALFDOKABP().inBark && LiaNPC.OMFKNGDCJFN().canTalk)
		{
			IDHKFLCNIIP();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || LiaNPC.CHPEMJMLDCN().inUse || LiaNPC.AJIGOHGPFPP().inBark || !LiaNPC.KIALFDOKABP().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void FDFDKMCMHMH()
	{
		PlayerInventory.EIFPKCAFDIB(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.EABMGELAAPG(-79, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.OGKNJNINGMH(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.GetItem(112).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(MAAAKALBBEE().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(-119, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(MAAAKALBBEE().EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.EABMGELAAPG(128, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		if (GameManager.LocalCoop())
		{
			int jFNMCNCHMEO = ((MAAAKALBBEE().EHHOHCPHAAO != 1) ? 1 : 8);
			PlayerInventory.GetPlayer(jFNMCNCHMEO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(117).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			PlayerInventory.NEKDDPIAOBE(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(171, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			PlayerInventory.OGKNJNINGMH(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(186, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML());
			PlayerInventory.GetPlayer(jFNMCNCHMEO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(192).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			PlayerInventory.NEKDDPIAOBE(jFNMCNCHMEO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(-143).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		}
		PlayerInventory.EIFPKCAFDIB(GGFJGHHHEJC.EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(-106, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		PlayerInventory.EIFPKCAFDIB(MAAAKALBBEE().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.EABMGELAAPG(-12, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 8, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.GetPlayer(MAAAKALBBEE().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.KMBGJEKCJFJ(-30, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 2, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.GetPlayer(MAAAKALBBEE().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.COEFFIHKMJG(-30).JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
		PlayerInventory.NEKDDPIAOBE(MAAAKALBBEE().EHHOHCPHAAO).AINJENENGFG(ItemDatabaseAccessor.COEFFIHKMJG(8, GGBBJNBBLMF: true).JMDALJBNFML(), 7, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true).AddItems(ItemDatabaseAccessor.GetItem(3).JMDALJBNFML(), 3, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.EIFPKCAFDIB(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.INJBNHPGCIJ(-37, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 8, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.GetPlayer(MAAAKALBBEE().EHHOHCPHAAO).AINJENENGFG(ItemDatabaseAccessor.AFOACBIHNCL(83, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.OGKNJNINGMH(MAAAKALBBEE().EHHOHCPHAAO).LFBNOHNNFBB(ItemDatabaseAccessor.COEFFIHKMJG(51, GGBBJNBBLMF: true).JMDALJBNFML(), 7);
		PlayerInventory.OGKNJNINGMH(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(182).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true).AddItems(ItemDatabaseAccessor.CPMMBEPEJLO(193, GGBBJNBBLMF: true).JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
		PlayerInventory.EIFPKCAFDIB(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.KMBGJEKCJFJ(87, GGBBJNBBLMF: true).JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
		PlayerInventory.OGKNJNINGMH(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(122, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		PlayerInventory.NEKDDPIAOBE(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.GetItem(18, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 8, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.OGKNJNINGMH(MAAAKALBBEE().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.GOKIDLOELKB(-43).JMDALJBNFML(), -39, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.OGKNJNINGMH(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(35, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private void IDHKFLCNIIP()
	{
		if (Random.Range(0, 2) == 0)
		{
			dialogue.conversation = "City/Rhia/Bark/Stand";
			KNEHCFHGDFC();
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUILiaRhia();
				onlineBarkDialogue = true;
			}
		}
		else
		{
			LiaNPC.GGFJGHHHEJC.dialogue.conversation = "City/Lia/Bark/Stand";
			KNEHCFHGDFC();
			LiaNPC.GGFJGHHHEJC.dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUILiaRhia();
				LiaNPC.GGFJGHHHEJC.onlineBarkDialogue = true;
			}
		}
	}

	public void IGNCCLNIIJM(string emotion)
	{
		MAAAKALBBEE().emotionsController.StartEmotion(emotion);
	}

	public void GiveItems()
	{
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1062).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1061).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1064).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1060).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		if (GameManager.LocalCoop())
		{
			int jFNMCNCHMEO = ((GGFJGHHHEJC.EHHOHCPHAAO != 1) ? 1 : 2);
			PlayerInventory.GetPlayer(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GetItem(1062).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			PlayerInventory.GetPlayer(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GetItem(1061).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			PlayerInventory.GetPlayer(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GetItem(1064).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			PlayerInventory.GetPlayer(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GetItem(1060).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			PlayerInventory.GetPlayer(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GetItem(1063).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		}
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(3076).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(3018).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(11).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(3019).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(4).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(3059).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(1245).JMDALJBNFML(), 4, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(1247).JMDALJBNFML(), 4, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(1118).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(609).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(630).JMDALJBNFML(), 8, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(74).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1133).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(1135).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 20, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1063).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private IEnumerator KKKHEHHGDEO(int JIIGOACEIKL)
	{
		return new NKBOOAMDLIA(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void APPNAMFJDOA(string emotion)
	{
		MAAAKALBBEE().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void KGKMJLOBHKE()
	{
		ShopUI.EPKNOMLADCL(MAAAKALBBEE().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(MAAAKALBBEE().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	protected override void Update()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (OnlineManager.MasterOrOffline() && inShop && LiaNPC.GGFJGHHHEJC.inShop && WorldTime.EDIPJBOOEHD > (float)(8 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(22 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			MKFPKPJJOCP();
		}
		if (((Component)this).transform.position.x <= -524f && ((Component)this).transform.position.x >= -526f && ((Component)this).transform.position.y >= 99f && ((Component)this).transform.position.y <= 100f)
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

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inEvent && canTalk && LiaNPC.GGFJGHHHEJC.canTalk)
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

	private void MKFPKPJJOCP()
	{
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !LiaNPC.GGFJGHHHEJC.inUse && !LiaNPC.GGFJGHHHEJC.inBark && LiaNPC.GGFJGHHHEJC.canTalk)
		{
			IDHKFLCNIIP();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || LiaNPC.GGFJGHHHEJC.inUse || LiaNPC.GGFJGHHHEJC.inBark || !LiaNPC.GGFJGHHHEJC.canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private IEnumerator KACNGNMNFNK(int JIIGOACEIKL)
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(7);
			}
		}
		if (!LiaNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			LiaNPC.GGFJGHHHEJC.StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(8);
			}
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		CheckPossibleStates(JIIGOACEIKL);
		SelectDialogueUI(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}

	private void BHNIDCJFGKD()
	{
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !LiaNPC.NBKKEINELDN().inUse && !LiaNPC.MAIDHAPANEB().inBark && LiaNPC.AJIGOHGPFPP().canTalk)
		{
			IDHKFLCNIIP();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || LiaNPC.CHPEMJMLDCN().inUse || LiaNPC.AJIGOHGPFPP().inBark || !LiaNPC.DEGPIHEEFHJ().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	private void Start()
	{
		AELCMIGFOAK = 120f + Time.time;
		CheckExclamation();
	}

	public void KHCNNNJAMPL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("OnlinePlayer");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
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

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	protected override void KNEHCFHGDFC()
	{
		barkDialogue = true;
		GGFJGHHHEJC.SelectDialogueUI();
		LiaNPC.GGFJGHHHEJC.barkDialogue = true;
		LiaNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	[SpecialName]
	public static RhiaNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
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

	public void BNGJIMBJEOA()
	{
		ShopUI.Get(MAAAKALBBEE().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void FACKKGAODPO(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void KJOJLHCDFPP()
	{
		AELCMIGFOAK = 105f + Time.time;
		CheckExclamation();
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

	public void CPFEBDHKJHN()
	{
		ShopUI.IEKODILKIHJ(MAAAKALBBEE().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(MAAAKALBBEE().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private IEnumerator HIPKJFFAFFP(int JIIGOACEIKL)
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(7);
			}
		}
		if (!LiaNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			LiaNPC.GGFJGHHHEJC.StopConversation();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(8);
			}
		}
		yield return null;
		base.EHHOHCPHAAO = JIIGOACEIKL;
		CommonReferences.GGFJGHHHEJC.SetPlayerDialogue(JIIGOACEIKL);
		NJJCCIBDAPM();
		CheckPossibleStates(JIIGOACEIKL);
		SelectDialogueUI(JIIGOACEIKL);
		mouseUpTrigger = true;
		dialogue.OnUse();
		BEGCPKOAJCP = null;
	}
}
