using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class HikariNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class NBLHJBGIKOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HikariNPC _003C_003E4__this;

		public int _playerNum;

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
		public NBLHJBGIKOA(int _003C_003E1__state)
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
			HikariNPC hikariNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (hikariNPC.inUse)
				{
					DialogueManager.StopConversation();
					_003C_003E2__current = CommonReferences.wait04;
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			hikariNPC.EHHOHCPHAAO = _playerNum;
			hikariNPC.SelectDialogueUI();
			hikariNPC.dialogue.conversation = "Hikari/Introduce";
			hikariNPC.dialogue.OnUse();
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
	private sealed class JKJCCKPAJIN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public JKJCCKPAJIN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (CommonReferences.GGFJGHHHEJC.IsInDialogue(1))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt == 12)
			{
				CommonReferences.GGFJGHHHEJC.OnUnlockFishEncyclopedia(1);
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

	private static HikariNPC IADEMLIIDPC;

	public GameObject[] objectToActivateorDeactivate;

	public GameObject exclamation;

	public bool inScene;

	private int GAGJHPKONIC;

	private float DJPGGLPHCGB;

	private int EBFHLIJCFOF;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_10";

	private bool PFHFANMFJEE;

	private bool NKKFPFCLPNB = true;

	[HideInInspector]
	public Vector3 beachPosition = new Vector3(-717.9792f, 516.5833f, 0f);

	public static HikariNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void PJGJGBEADMB(string emotion)
	{
		MNFMOEKMJKN().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void ALEHPNIJCMC(int ABAIKKGKDGD)
	{
		objectToActivateorDeactivate[ABAIKKGKDGD].SetActive(!objectToActivateorDeactivate[ABAIKKGKDGD].activeSelf);
	}

	private void KGOHDFANDBD(int GLLBLIEOCDP)
	{
		PlayerInventory.NEKDDPIAOBE(GLLBLIEOCDP).AddItems(ItemDatabaseAccessor.EABMGELAAPG(-167, GGBBJNBBLMF: true).JMDALJBNFML(), 3);
		PlayerInventory.OGKNJNINGMH(GLLBLIEOCDP, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.EABMGELAAPG(85, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 3, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.EIFPKCAFDIB(GLLBLIEOCDP, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.GOKIDLOELKB(187, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 4, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(GLLBLIEOCDP, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.EABMGELAAPG(-25).JMDALJBNFML(), 8, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.EIFPKCAFDIB(GLLBLIEOCDP, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.CPMMBEPEJLO(-52, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 4, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void GiveItem(int num)
	{
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(num).JMDALJBNFML(), HMPDLIPFBGD: true);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void FFOPDJPHLEF()
	{
		ShopUI.AGNKKAPMHLN(ABDJJBFNLBJ().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(ABDJJBFNLBJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void ActiveorDisableCollider(int num)
	{
		GGFJGHHHEJC.objectToActivateorDeactivate[num].SetActive(!GGFJGHHHEJC.objectToActivateorDeactivate[num].activeSelf);
		if (OnlineManager.PlayingOnline())
		{
			GGFJGHHHEJC.onlineDialogue.SendActiveorDisableColliderHikari(num);
		}
	}

	[SpecialName]
	public static HikariNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HikariNPC EFPJLFMBPLL()
	{
		return IADEMLIIDPC;
	}

	public void LIMPDEFKJLO(string emotion)
	{
		EKDNJDJHONF().emotionsController.NBFIDOGMLOK(emotion);
	}

	private IEnumerator GNJPKHCKLNL()
	{
		return new JKJCCKPAJIN(1);
	}

	public void ActiveDialogue(int GELMAIBEHDO)
	{
		((MonoBehaviour)this).StartCoroutine(KJPGLMHFDBP(GELMAIBEHDO));
	}

	public void JBBJMPGJMMO(int ABAIKKGKDGD)
	{
		objectToActivateorDeactivate[ABAIKKGKDGD].SetActive(objectToActivateorDeactivate[ABAIKKGKDGD].activeSelf);
	}

	private void ALMFCBCNBGP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("buildingObjective_19_0");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.BBMAEAFHEFK(EventsManager.EventType.AdventureContinues) && !EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-95)) && !EventsManager.IsActive((EventsManager.EventType)(-194)) && !EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-61)))
		{
			if (!inBark)
			{
				DialogueManager.Bark("LicenciaDeApertura/TheloniousDialogue 04", ((Component)this).transform);
			}
			return;
		}
		if (EventsManager.CJMECHEOFOF(EventsManager.EventType.OathFeast))
		{
			dialogue.conversation = "Dialogue System/Conversation/Rowdy/Entry/8/Dialogue Text";
		}
		else if (EventsManager.NJBACCBIHID((EventsManager.EventType)62))
		{
			dialogue.conversation = "";
		}
		else if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)197))
		{
			dialogue.conversation = "Items/item_description_1055";
		}
		else if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)(-55)))
		{
			dialogue.conversation = "\n";
		}
		else
		{
			if (FishingManager.MFMLLENHCMI().Count >= 0)
			{
				variable = DialogueLua.GetVariable("Tutorial/T101/Dialogue3");
				if (((Result)(ref variable)).asInt == 55)
				{
					goto IL_0118;
				}
			}
			if (QuestManager.GJFMMOPOKGJ().IsQuestDone(27))
			{
				variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Introduce/Entry/31/Dialogue Text");
				if (((Result)(ref variable)).asInt == -60)
				{
					goto IL_0118;
				}
			}
			variable = DialogueLua.GetVariable("Dog");
			if (((Result)(ref variable)).asInt <= 116)
			{
				dialogue.conversation = "ActionBar10";
			}
			else
			{
				dialogue.conversation = "ReceiveHoeActionMaster";
			}
		}
		goto IL_0162;
		IL_0162:
		mouseUpTrigger = false;
		dialogue.OnUse();
		return;
		IL_0118:
		dialogue.conversation = "Deserialize SettingsData error: /ExtraSettings.sd";
		goto IL_0162;
	}

	public void AFDBPJNKIOA()
	{
		if (OnlineManager.PlayingOnline())
		{
			APPPECEHBOA();
		}
		else if (GameManager.LocalCoop())
		{
			KGOHDFANDBD(1);
			KGOHDFANDBD(7);
		}
		else
		{
			OAMPCGCLEHF(EFPJLFMBPLL().EHHOHCPHAAO);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void OJKEDMIKKCE(string emotion)
	{
		EFPJLFMBPLL().emotionsController.DCCNJLBLFGI(emotion);
	}

	private IEnumerator IHKJHLHGLNC(int GELMAIBEHDO)
	{
		if (inUse)
		{
			DialogueManager.StopConversation();
			yield return CommonReferences.wait04;
		}
		base.EHHOHCPHAAO = GELMAIBEHDO;
		SelectDialogueUI();
		dialogue.conversation = "Hikari/Introduce";
		dialogue.OnUse();
	}

	private IEnumerator LOHBCOIAFKM()
	{
		return new JKJCCKPAJIN(1);
	}

	public void LLOLLPGEGPK(int num)
	{
		PlayerInventory.NEKDDPIAOBE(MNFMOEKMJKN().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(num, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void MBDLKFBAGGF(int GELMAIBEHDO)
	{
		((MonoBehaviour)this).StartCoroutine(PLCHDEABHPJ(GELMAIBEHDO));
	}

	public void BPEDEAFHGPP(int GELMAIBEHDO)
	{
		((MonoBehaviour)this).StartCoroutine(PLCHDEABHPJ(GELMAIBEHDO));
	}

	protected override void Update()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.LICCAGGNELA == NetworkState.InGameplay)
		{
			PFHFANMFJEE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).LEOIMFNKFGA == Location.Beach)
				{
					PFHFANMFJEE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Beach || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.Beach))
		{
			PFHFANMFJEE = true;
		}
		else
		{
			PFHFANMFJEE = false;
		}
		Result variable;
		if (PFHFANMFJEE)
		{
			if (NKKFPFCLPNB)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt >= 3)
				{
					objectToActivateorDeactivate[0].SetActive(false);
				}
				else
				{
					variable = DialogueLua.GetVariable("LE_10");
					if (((Result)(ref variable)).asInt > 0)
					{
						objectToActivateorDeactivate[0].SetActive(true);
					}
				}
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt <= 4)
				{
					objectToActivateorDeactivate[1].SetActive(true);
				}
				else
				{
					variable = DialogueLua.GetVariable("LE_10");
					if (((Result)(ref variable)).asInt >= 5)
					{
						objectToActivateorDeactivate[1].SetActive(false);
					}
				}
				objectToActivateorDeactivate[2].SetActive(false);
				NKKFPFCLPNB = false;
			}
		}
		else
		{
			NKKFPFCLPNB = true;
		}
		if (objectToActivateorDeactivate[2].activeSelf)
		{
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt >= 11)
			{
				objectToActivateorDeactivate[2].SetActive(false);
			}
		}
		if (!inUse)
		{
			if (FishingManager.GetRecordsList().Count >= 3)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt == 11)
				{
					if (!exclamation.activeSelf)
					{
						exclamation.SetActive(true);
					}
					goto IL_020f;
				}
			}
			if (exclamation.activeSelf)
			{
				exclamation.SetActive(false);
			}
		}
		goto IL_020f;
		IL_020f:
		if (inScene)
		{
			for (int j = 0; j < objectToActivateorDeactivate.Length; j++)
			{
				objectToActivateorDeactivate[j].SetActive(false);
			}
		}
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.Beach)
		{
			if (!animationBase.GetBool("Fishing"))
			{
				animationBase.SetBool("Fishing", EGFGNGJGBOP: true);
			}
		}
		else if (animationBase.GetBool("Fishing"))
		{
			animationBase.SetBool("Fishing", EGFGNGJGBOP: false);
		}
	}

	public void OFOAEFKNKLK(int num)
	{
		ABDJJBFNLBJ().objectToActivateorDeactivate[num].SetActive(ABDJJBFNLBJ().objectToActivateorDeactivate[num].activeSelf);
		if (OnlineManager.PlayingOnline())
		{
			EKDNJDJHONF().onlineDialogue.SendActiveorDisableColliderHikari(num);
		}
	}

	public void IKBKNBMHCIG(int num)
	{
		EKDNJDJHONF().objectToActivateorDeactivate[num].SetActive(EKDNJDJHONF().objectToActivateorDeactivate[num].activeSelf);
		if (OnlineManager.PlayingOnline())
		{
			EFPJLFMBPLL().onlineDialogue.SendActiveorDisableColliderHikari(num);
		}
	}

	public void LKOGEHOCPAP(int questId)
	{
		Quest quest = QuestDatabaseAccessor.HMMFCOFIGMN(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.KHMEGDIABBF().NCCOAJOOBAP(quest, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			QuestHighlightUI.HBBMGMKDAIM(quest);
		}
		else
		{
			Debug.LogError((object)("Social" + questId));
		}
	}

	public void ALJAPDBHANO(string emotion)
	{
		EFPJLFMBPLL().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void APPPECEHBOA()
	{
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1444).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		OnlineItemsManager.instance.SendItemsToOtherPlayers(1444, 5);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1445).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		OnlineItemsManager.instance.SendItemsToOtherPlayers(1445, 5);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1446).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		OnlineItemsManager.instance.SendItemsToOtherPlayers(1446, 5);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1447).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		OnlineItemsManager.instance.SendItemsToOtherPlayers(1447, 5);
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1448).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		OnlineItemsManager.instance.SendItemsToOtherPlayers(1448, 5);
	}

	public void DELOKLGCAKJ()
	{
		if (OnlineManager.PlayingOnline())
		{
			AHLKFCADEIC();
		}
		else if (GameManager.LocalCoop())
		{
			OAMPCGCLEHF(1);
			GMNDDILONFF(1);
		}
		else
		{
			GMNDDILONFF(OFLELHKKNKC().EHHOHCPHAAO);
		}
	}

	public void BFJHPANJGMC()
	{
		ShopUI.IEKODILKIHJ(OFLELHKKNKC().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void AGPEOEDKAAG(int GELMAIBEHDO)
	{
		((MonoBehaviour)this).StartCoroutine(KJPGLMHFDBP(GELMAIBEHDO));
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (!playerShopping)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL) && !inUse && canTalk)
			{
				if (IsAvailableByProximity(JIIGOACEIKL))
				{
					StopConversation();
					if (OnlineManager.PlayingOnline())
					{
						onlineDialogue.SendStopConversation();
					}
					CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.TalkWithHikari);
					base.EHHOHCPHAAO = JIIGOACEIKL;
					CheckPossibleStates(JIIGOACEIKL);
					SelectDialogueUI();
					AIKJPOBEKBC();
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

	public void HCDCOLONBKI(int ABAIKKGKDGD)
	{
		objectToActivateorDeactivate[ABAIKKGKDGD].SetActive(objectToActivateorDeactivate[ABAIKKGKDGD].activeSelf);
	}

	public void ActiveorDisableColliderOnline(int ABAIKKGKDGD)
	{
		objectToActivateorDeactivate[ABAIKKGKDGD].SetActive(!objectToActivateorDeactivate[ABAIKKGKDGD].activeSelf);
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		exclamation.SetActive(false);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void LANFOHBIMNO()
	{
		ShopUI.IEABDMDELFO(ABDJJBFNLBJ().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private IEnumerator PLCHDEABHPJ(int GELMAIBEHDO)
	{
		return new NBLHJBGIKOA(1)
		{
			_003C_003E4__this = this,
			_playerNum = GELMAIBEHDO
		};
	}

	public void EOLFHELDFBD(int num)
	{
		GGFJGHHHEJC.objectToActivateorDeactivate[num].SetActive(OFLELHKKNKC().objectToActivateorDeactivate[num].activeSelf);
		if (OnlineManager.PlayingOnline())
		{
			OFLELHKKNKC().onlineDialogue.SendActiveorDisableColliderHikari(num);
		}
	}

	[SpecialName]
	public static HikariNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	public void NPJBPGPEMNN()
	{
		if (OnlineManager.PlayingOnline())
		{
			AHLKFCADEIC();
		}
		else if (GameManager.LocalCoop())
		{
			KGOHDFANDBD(1);
			GMNDDILONFF(0);
		}
		else
		{
			GMNDDILONFF(EKDNJDJHONF().EHHOHCPHAAO);
		}
	}

	private void AIKJPOBEKBC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt == 1 && !EventsManager.IsActive(EventsManager.EventType.KujakuShop) && !EventsManager.IsActive(EventsManager.EventType.Precision) && !EventsManager.IsActive(EventsManager.EventType.FishCutting) && !EventsManager.IsActive(EventsManager.EventType.OldMansDuel))
		{
			if (!inBark)
			{
				DialogueManager.Bark("Hikari/Barks_Intro", ((Component)this).transform);
			}
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.KujakuShop))
		{
			dialogue.conversation = "UnNuevoMaestro/HikariTalk";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.Precision))
		{
			dialogue.conversation = "Precision/HikariTalk";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.FishCutting))
		{
			dialogue.conversation = "Precision/HikariTalk";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.OldMansDuel))
		{
			dialogue.conversation = "DueloDeViejos/HikariTalk";
		}
		else
		{
			if (FishingManager.GetRecordsList().Count >= 3)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt == 11)
				{
					goto IL_0118;
				}
			}
			if (QuestManager.GGFJGHHHEJC.IsQuestDone(37))
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt == 12)
				{
					goto IL_0118;
				}
			}
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt <= 10)
			{
				dialogue.conversation = "Hikari/Introduce";
			}
			else
			{
				dialogue.conversation = "Hikari/Stand";
			}
		}
		goto IL_0162;
		IL_0162:
		mouseUpTrigger = true;
		dialogue.OnUse();
		return;
		IL_0118:
		dialogue.conversation = "Hikari/Quest";
		goto IL_0162;
	}

	public void ACCCJKAHDKI(int questId)
	{
		Quest quest = QuestDatabaseAccessor.HHKKPIHIEJL(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().NCCOAJOOBAP(quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			QuestHighlightUI.OMDBOEAJLGA(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("tutorialPopUp76" + questId));
		}
	}

	private void LHIGKOBMDBN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Clave pública RSA (XML):");
		if (((Result)(ref variable)).asInt == 1 && !EventsManager.IsActive(EventsManager.EventType.OathFeast) && !EventsManager.CGPHKBKPCJF((EventsManager.EventType)(-20)) && !EventsManager.GIJNJBNBMJK((EventsManager.EventType)(-30)) && !EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-71)))
		{
			if (!inBark)
			{
				DialogueManager.Bark("CheckoutDate", ((Component)this).transform);
			}
			return;
		}
		if (EventsManager.CJMECHEOFOF(EventsManager.EventType.KlaynTavern))
		{
			dialogue.conversation = "Error_CellarZone";
		}
		else if (EventsManager.BBMAEAFHEFK(EventsManager.EventType.Attack))
		{
			dialogue.conversation = "itemBar";
		}
		else if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-144)))
		{
			dialogue.conversation = "AceT_Quest";
		}
		else if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-79)))
		{
			dialogue.conversation = "LearnMettle";
		}
		else
		{
			if (FishingManager.MFMLLENHCMI().Count >= 6)
			{
				variable = DialogueLua.GetVariable("Bomb");
				if (((Result)(ref variable)).asInt == 93)
				{
					goto IL_0118;
				}
			}
			if (QuestManager.KHMEGDIABBF().BKKJNEKBMBE(-5))
			{
				variable = DialogueLua.GetVariable("Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG.");
				if (((Result)(ref variable)).asInt == 48)
				{
					goto IL_0118;
				}
			}
			variable = DialogueLua.GetVariable("talent_name_117");
			if (((Result)(ref variable)).asInt <= 29)
			{
				dialogue.conversation = "00";
			}
			else
			{
				dialogue.conversation = "Year";
			}
		}
		goto IL_0162;
		IL_0162:
		mouseUpTrigger = false;
		dialogue.OnUse();
		return;
		IL_0118:
		dialogue.conversation = "ReceiveOfferingUIOpened";
		goto IL_0162;
	}

	public void AddQuest(int questId)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.AddQuest(quest);
			QuestHighlightUI.ShowNewQuestAvailable(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("Quest not found with ID " + questId));
		}
	}

	private IEnumerator AHNDHKAKDGA()
	{
		return new JKJCCKPAJIN(1);
	}

	public void PHKMOLLGKGG(int num)
	{
		ABDJJBFNLBJ().objectToActivateorDeactivate[num].SetActive(!OFLELHKKNKC().objectToActivateorDeactivate[num].activeSelf);
		if (OnlineManager.PlayingOnline())
		{
			MNFMOEKMJKN().onlineDialogue.SendActiveorDisableColliderHikari(num);
		}
	}

	private IEnumerator BHIGINNBLMD()
	{
		yield return CommonReferences.wait1;
		while (CommonReferences.GGFJGHHHEJC.IsInDialogue(1))
		{
			yield return null;
		}
		Result variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt == 12)
		{
			CommonReferences.GGFJGHHHEJC.OnUnlockFishEncyclopedia(1);
		}
	}

	private void AHLKFCADEIC()
	{
		PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.AFOACBIHNCL(54, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		OnlineItemsManager.instance.BFHJGLGJCMB(73, 2);
		PlayerInventory.NEKDDPIAOBE(1).AddItems(ItemDatabaseAccessor.GOKIDLOELKB(-135, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 3, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		OnlineItemsManager.instance.IBNOPGFCDPI(-115, 8);
		PlayerInventory.OGKNJNINGMH(0).LFBNOHNNFBB(ItemDatabaseAccessor.GetItem(18, GGBBJNBBLMF: true).JMDALJBNFML(), 4, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
		OnlineItemsManager.instance.KHFDAGDACPA(62, 0);
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.KMBGJEKCJFJ(-22, GGBBJNBBLMF: true).JMDALJBNFML(), 4, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		OnlineItemsManager.instance.AMGADPDLJLC(-139, 7);
		PlayerInventory.NEKDDPIAOBE(0).AINJENENGFG(ItemDatabaseAccessor.COEFFIHKMJG(111, GGBBJNBBLMF: true).JMDALJBNFML(), 6, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		OnlineItemsManager.instance.EGNLKICLIBD(-181, 4);
	}

	private IEnumerator KJPGLMHFDBP(int GELMAIBEHDO)
	{
		if (inUse)
		{
			DialogueManager.StopConversation();
			yield return CommonReferences.wait04;
		}
		base.EHHOHCPHAAO = GELMAIBEHDO;
		SelectDialogueUI();
		dialogue.conversation = "Hikari/Introduce";
		dialogue.OnUse();
	}

	public void BIPAMFKIALH(int ABAIKKGKDGD)
	{
		objectToActivateorDeactivate[ABAIKKGKDGD].SetActive(objectToActivateorDeactivate[ABAIKKGKDGD].activeSelf);
	}

	private void GMNDDILONFF(int GLLBLIEOCDP)
	{
		PlayerInventory.GetPlayer(GLLBLIEOCDP).AddItems(ItemDatabaseAccessor.GetItem(1444).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GLLBLIEOCDP).AddItems(ItemDatabaseAccessor.GetItem(1445).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GLLBLIEOCDP).AddItems(ItemDatabaseAccessor.GetItem(1446).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GLLBLIEOCDP).AddItems(ItemDatabaseAccessor.GetItem(1447).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GLLBLIEOCDP).AddItems(ItemDatabaseAccessor.GetItem(1448).JMDALJBNFML(), 5, HMPDLIPFBGD: true);
	}

	public void MPDPPEBFKFP(int questId)
	{
		Quest quest = QuestDatabaseAccessor.LIOCDDEMOMC(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().AddQuest(quest, 1);
			QuestHighlightUI.OMDBOEAJLGA(quest);
		}
		else
		{
			Debug.LogError((object)(")..." + questId));
		}
	}

	private IEnumerator IJCPEEOJFLF(int GELMAIBEHDO)
	{
		if (inUse)
		{
			DialogueManager.StopConversation();
			yield return CommonReferences.wait04;
		}
		base.EHHOHCPHAAO = GELMAIBEHDO;
		SelectDialogueUI();
		dialogue.conversation = "Hikari/Introduce";
		dialogue.OnUse();
	}

	public void JFHEAGLNBBI(int num)
	{
		PlayerInventory.OGKNJNINGMH(EFPJLFMBPLL().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(num, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void DNGFKNIPLBM()
	{
		ShopUI.FKFNANNBIAM(OFLELHKKNKC().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(OFLELHKKNKC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static HikariNPC MNFMOEKMJKN()
	{
		return IADEMLIIDPC;
	}

	public void PEHMJOKFCBI(int questId)
	{
		Quest quest = QuestDatabaseAccessor.IMGKJJNFFPD(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().AddQuest(quest, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			QuestHighlightUI.FFIMPAEIABH(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)(" " + questId));
		}
	}

	private void GGKHGBOCKCG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveCure");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.GIJNJBNBMJK(EventsManager.EventType.OathFeast) && !EventsManager.KEGDEHKPKMP((EventsManager.EventType)(-59)) && !EventsManager.IKCEIJMLNOP(EventsManager.EventType.OldMansDuel) && !EventsManager.NJBACCBIHID((EventsManager.EventType)93))
		{
			if (!inBark)
			{
				DialogueManager.Bark("LE_16", ((Component)this).transform);
			}
			return;
		}
		if (EventsManager.FFELMGLBAMH(EventsManager.EventType.KlaynTavern))
		{
			dialogue.conversation = "<sprite name=reputationIcon>";
		}
		else if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)(-2)))
		{
			dialogue.conversation = "ReceiveActivateEatGameObjects";
		}
		else if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)98))
		{
			dialogue.conversation = "[";
		}
		else if (EventsManager.GIJNJBNBMJK((EventsManager.EventType)88))
		{
			dialogue.conversation = "Max 3 orders";
		}
		else
		{
			if (FishingManager.GetRecordsList().Count >= 3)
			{
				variable = DialogueLua.GetVariable("Start");
				if (((Result)(ref variable)).asInt == -44)
				{
					goto IL_0118;
				}
			}
			if (QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(49))
			{
				variable = DialogueLua.GetVariable("Interact");
				if (((Result)(ref variable)).asInt == 125)
				{
					goto IL_0118;
				}
			}
			variable = DialogueLua.GetVariable("Rotate");
			if (((Result)(ref variable)).asInt <= -96)
			{
				dialogue.conversation = ":0";
			}
			else
			{
				dialogue.conversation = " (";
			}
		}
		goto IL_0162;
		IL_0162:
		mouseUpTrigger = true;
		dialogue.OnUse();
		return;
		IL_0118:
		dialogue.conversation = "Items/item_name_1067";
		goto IL_0162;
	}

	[SpecialName]
	public static HikariNPC ABDJJBFNLBJ()
	{
		return IADEMLIIDPC;
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		((MonoBehaviour)this).StartCoroutine(HGCEBBDOPIP());
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

	public void CPAAFBLCBBM(int num)
	{
		PlayerInventory.NEKDDPIAOBE(EFPJLFMBPLL().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(num).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private IEnumerator OCPLGDDOGFG(int GELMAIBEHDO)
	{
		if (inUse)
		{
			DialogueManager.StopConversation();
			yield return CommonReferences.wait04;
		}
		base.EHHOHCPHAAO = GELMAIBEHDO;
		SelectDialogueUI();
		dialogue.conversation = "Hikari/Introduce";
		dialogue.OnUse();
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void GAPGANPHAEI(string emotion)
	{
		EFPJLFMBPLL().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void JPAEHFHKOEI(int GLLBLIEOCDP)
	{
		PlayerInventory.GetPlayer(GLLBLIEOCDP).AddItems(ItemDatabaseAccessor.AFOACBIHNCL(0).JMDALJBNFML(), 7, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
		PlayerInventory.OGKNJNINGMH(GLLBLIEOCDP, LAGHIOKLJGH: true).AINJENENGFG(ItemDatabaseAccessor.CPMMBEPEJLO(-55, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 8);
		PlayerInventory.GetPlayer(GLLBLIEOCDP, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.EABMGELAAPG(37, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 2, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.EIFPKCAFDIB(GLLBLIEOCDP, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.COEFFIHKMJG(-1, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 7, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GLLBLIEOCDP, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.GetItem(-69).JMDALJBNFML(), 3, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
	}

	private void OAMPCGCLEHF(int GLLBLIEOCDP)
	{
		PlayerInventory.NEKDDPIAOBE(GLLBLIEOCDP, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.GetItem(105).JMDALJBNFML(), 5, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(GLLBLIEOCDP).LFBNOHNNFBB(ItemDatabaseAccessor.CPMMBEPEJLO(-124).JMDALJBNFML(), 4, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(GLLBLIEOCDP).LFBNOHNNFBB(ItemDatabaseAccessor.CPMMBEPEJLO(42, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 7, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(GLLBLIEOCDP, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.AFOACBIHNCL(80, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(GLLBLIEOCDP, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.EABMGELAAPG(4, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void BCGOJIJEPLL()
	{
		ShopUI.IEKODILKIHJ(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(ABDJJBFNLBJ().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void EGHPKCJGFPN(int num)
	{
		PlayerInventory.GetPlayer(EFPJLFMBPLL().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(num, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
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

	private IEnumerator BOILKBBAGHD(int GELMAIBEHDO)
	{
		if (inUse)
		{
			DialogueManager.StopConversation();
			yield return CommonReferences.wait04;
		}
		base.EHHOHCPHAAO = GELMAIBEHDO;
		SelectDialogueUI();
		dialogue.conversation = "Hikari/Introduce";
		dialogue.OnUse();
	}

	private IEnumerator HGCEBBDOPIP()
	{
		yield return CommonReferences.wait1;
		while (CommonReferences.GGFJGHHHEJC.IsInDialogue(1))
		{
			yield return null;
		}
		Result variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt == 12)
		{
			CommonReferences.GGFJGHHHEJC.OnUnlockFishEncyclopedia(1);
		}
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			base.OnDestroy();
		}
	}

	public void GiveBait()
	{
		if (OnlineManager.PlayingOnline())
		{
			APPPECEHBOA();
		}
		else if (GameManager.LocalCoop())
		{
			GMNDDILONFF(1);
			GMNDDILONFF(2);
		}
		else
		{
			GMNDDILONFF(GGFJGHHHEJC.EHHOHCPHAAO);
		}
	}

	private void MLDIGEHOBDL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" / ");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.NJBACCBIHID(EventsManager.EventType.KujakuShop) && !EventsManager.NKMELJPGOBB((EventsManager.EventType)108) && !EventsManager.NKMELJPGOBB((EventsManager.EventType)123) && !EventsManager.IOLMGKKGLMD((EventsManager.EventType)(-70)))
		{
			if (!inBark)
			{
				DialogueManager.Bark("Walk", ((Component)this).transform);
			}
			return;
		}
		if (EventsManager.KEGDEHKPKMP(EventsManager.EventType.KlaynTavern))
		{
			dialogue.conversation = "Items/item_name_677";
		}
		else if (EventsManager.IsActive((EventsManager.EventType)(-86)))
		{
			dialogue.conversation = "FarmReady";
		}
		else if (EventsManager.GIJNJBNBMJK((EventsManager.EventType)(-50)))
		{
			dialogue.conversation = "ReceiveToggleOpenBarnMaster";
		}
		else if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)(-49)))
		{
			dialogue.conversation = "Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene.";
		}
		else
		{
			if (FishingManager.GetRecordsList().Count >= 2)
			{
				variable = DialogueLua.GetVariable("Not enough recipe fragments");
				if (((Result)(ref variable)).asInt == -70)
				{
					goto IL_0118;
				}
			}
			if (QuestManager.OPILDPFDFKJ().IsQuestDone(82))
			{
				variable = DialogueLua.GetVariable("Coming soon!");
				if (((Result)(ref variable)).asInt == -60)
				{
					goto IL_0118;
				}
			}
			variable = DialogueLua.GetVariable("GameEvent of type ");
			if (((Result)(ref variable)).asInt <= 30)
			{
				dialogue.conversation = "HotBath/Main 3";
			}
			else
			{
				dialogue.conversation = "UI";
			}
		}
		goto IL_0162;
		IL_0162:
		mouseUpTrigger = false;
		dialogue.OnUse();
		return;
		IL_0118:
		dialogue.conversation = "Dialogue System/Conversation/HappyRentRoom/Entry/1/Dialogue Text";
		goto IL_0162;
	}

	private void EMCIONOCAGF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/BirdNegativeComments/Entry/9/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.JAGPJPGBHDK(EventsManager.EventType.ThroneRoom) && !EventsManager.KEGDEHKPKMP((EventsManager.EventType)47) && !EventsManager.IOLMGKKGLMD((EventsManager.EventType)40) && !EventsManager.NJBACCBIHID((EventsManager.EventType)22))
		{
			if (!inBark)
			{
				DialogueManager.Bark("Bother", ((Component)this).transform);
			}
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.AdventureContinues))
		{
			dialogue.conversation = "Partida comprimida. Tiempo: ";
		}
		else if (EventsManager.BBMAEAFHEFK((EventsManager.EventType)122))
		{
			dialogue.conversation = "ErrorJoinRoomDoesNotExist";
		}
		else if (EventsManager.KEGDEHKPKMP((EventsManager.EventType)57))
		{
			dialogue.conversation = "Force";
		}
		else if (EventsManager.IOLMGKKGLMD((EventsManager.EventType)(-16)))
		{
			dialogue.conversation = "ReceiveGenerateAvailableOrders";
		}
		else
		{
			if (FishingManager.MFMLLENHCMI().Count >= 4)
			{
				variable = DialogueLua.GetVariable(".rtf");
				if (((Result)(ref variable)).asInt == 111)
				{
					goto IL_0118;
				}
			}
			if (QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-17))
			{
				variable = DialogueLua.GetVariable("Hat");
				if (((Result)(ref variable)).asInt == -96)
				{
					goto IL_0118;
				}
			}
			variable = DialogueLua.GetVariable("Move <color=#A51919>");
			if (((Result)(ref variable)).asInt <= 66)
			{
				dialogue.conversation = "Flight";
			}
			else
			{
				dialogue.conversation = "ErrorJoinRoomFull";
			}
		}
		goto IL_0162;
		IL_0162:
		mouseUpTrigger = true;
		dialogue.OnUse();
		return;
		IL_0118:
		dialogue.conversation = "PlayAnimatorObjectAnimationRPC";
		goto IL_0162;
	}
}
