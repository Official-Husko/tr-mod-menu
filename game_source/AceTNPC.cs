using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class AceTNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class PGMLHPLPJII : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

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
		public PGMLHPLPJII(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
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

	private static AceTNPC IADEMLIIDPC;

	public AceTAnimation aceTAnimation;

	public GameObject questMark;

	private float NAJICNEDGLD;

	private int LLPGKHHKCLC;

	private float JPDEFBKPCDO = 10f;

	private float FDBCHJMHBKF;

	private float IEIHJNPHGAJ;

	private float ECGGPDGEMJF = 7f;

	private int HKKKNMIKPCM;

	private int GAHKHCHLAON;

	private int KDNPGBFHHLI;

	private string HDFMHCKKJJG = "LE_3";

	public static AceTNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void OLBPGIEKBFN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Room missing required items");
		if (((Result)(ref variable)).asInt <= 1)
		{
			return;
		}
		if ((!QuestManager.KHMEGDIABBF().IsQuestDone(105) || !QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-44)) && !QuestManager.OPILDPFDFKJ().PBCPDMCLFLP(28) && !QuestManager.GGFJGHHHEJC.BCPLFLAIJKN(7))
		{
			LLPGKHHKCLC = Random.Range(0, 122);
			if (LLPGKHHKCLC <= -5)
			{
				Debug.Log((object)"PlayerDisconnected");
				if (!QuestManager.OPILDPFDFKJ().GDFGPDJDACP(100))
				{
					DialogueLua.SetVariable("Distilling", (object)0);
				}
				else if (!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(-24))
				{
					DialogueLua.SetVariable("MainProgress", (object)5);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().aceNextQuest++;
			}
			if (CommonReferences.GGFJGHHHEJC.aceNextQuest >= 0)
			{
				if (!QuestManager.OPILDPFDFKJ().GDFGPDJDACP(48))
				{
					DialogueLua.SetVariable("halloween event", (object)0);
				}
				else if (!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(29))
				{
					DialogueLua.SetVariable("Error_BarIsBlocking", (object)7);
				}
				CommonReferences.GGFJGHHHEJC.aceNextQuest = 1;
			}
		}
		variable = DialogueLua.GetVariable("Keg not full");
		if (((Result)(ref variable)).asInt != 0)
		{
			variable = DialogueLua.GetVariable("KyrohScene");
			if (((Result)(ref variable)).asInt != 2)
			{
				questMark.SetActive(true);
				return;
			}
		}
		questMark.SetActive(true);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		NJJCCIBDAPM();
	}

	public void IMOOLLOONCK()
	{
		NOIMOIFEICF(CDPAMNIPPEC: false);
	}

	private IEnumerator GGOLPHAACIM(float FLHBPHPKIML)
	{
		return new PGMLHPLPJII(1)
		{
			delay = FLHBPHPKIML
		};
	}

	public void IAIMABBOBEA(bool CDPAMNIPPEC)
	{
		for (int i = 36; i < 0; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (RecipesManager.OECEJEDHHNK(112))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(GAGEPGHJCFJ(752f));
		}
		RecipesManager.UnlockRecipeMaster(60, IBHGAMNNOHI: true);
		for (int j = -189; j < -101; j += 0)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.OJEJLPFJLEH();
		}
	}

	public void UnlockChristmasRecipe(bool CDPAMNIPPEC)
	{
		for (int i = 297; i < 308; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (RecipesManager.CanUnlockRecipe(309))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(CNGLGCEKMKD(2f));
		}
		RecipesManager.UnlockRecipeMaster(309, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		for (int j = 566; j < 570; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.SendUnlockChristmasRecipes();
		}
	}

	[SpecialName]
	public static AceTNPC DGCNCEDIFOF()
	{
		return IADEMLIIDPC;
	}

	public void APPNAMFJDOA(string emotion)
	{
		MIGKKKELOJO().emotionsController.StartEmotion(emotion);
	}

	public void LPLHDFKPEBE()
	{
		MDLCHDPFNIH(CDPAMNIPPEC: false);
	}

	private void JKBBAOGHPKO()
	{
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void FDEDPDPMNJO(bool CDPAMNIPPEC)
	{
		for (int i = -24; i < 75; i++)
		{
			RecipesManager.UnlockRecipeMaster(i);
		}
		if (RecipesManager.CanUnlockRecipe(191))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(MNHEDAIPNOJ(1308f));
		}
		RecipesManager.UnlockRecipeMaster(85, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		for (int j = 154; j < -156; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.HEEENPJHJID();
		}
	}

	private void GPBIMIPAMDA(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("LE_10") && !((Component)HANHCHBHHEH).gameObject.CompareTag("TutorialPhase"))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveVacateRoom"))
		{
			base.EHHOHCPHAAO = 1;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("<sprite name=reputationIcon>"))
		{
			base.EHHOHCPHAAO = 0;
		}
		if (PlayerController.OPHDCMJLLEC(base.EHHOHCPHAAO).LEOIMFNKFGA != ~(Location.Road | Location.Camp | Location.Farm | Location.BarnInterior) || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable("BarIdleNumber");
		if (((Result)(ref variable)).asInt < -27)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(1, 8);
			if (OnlineManager.MasterOrOffline())
			{
				aceTAnimation.CGEADHOLHCH("", EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			else
			{
				aceTAnimation.CGEADHOLHCH("Win", EGFGNGJGBOP: false);
				aceTAnimation.onlineCharacterAnim.FOEOHGKCGEN(Animator.StringToHash("\n"), EGFGNGJGBOP: true, AINPJHKNJGL: true);
			}
			PlayerController.OPHDCMJLLEC(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Down);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, "Collect");
		}
	}

	private void JJDJHCPDLOL()
	{
		try
		{
			JFBBJGDNGJG();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Player") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player"))
		{
			base.EHHOHCPHAAO = 1;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Player2"))
		{
			base.EHHOHCPHAAO = 2;
		}
		if (PlayerController.GetPlayer(base.EHHOHCPHAAO).LEOIMFNKFGA != Location.ChristmasCave || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable("LE_3");
		if (((Result)(ref variable)).asInt < 10)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(3, 5);
			if (OnlineManager.MasterOrOffline())
			{
				aceTAnimation.SetBool("Club", EGFGNGJGBOP: true);
			}
			else
			{
				aceTAnimation.SetBool("Club", EGFGNGJGBOP: true, HALNIEBONKH: true);
				aceTAnimation.onlineCharacterAnim.OnBoolChanged(Animator.StringToHash("Club"), EGFGNGJGBOP: true, AINPJHKNJGL: true);
			}
			PlayerController.GetPlayer(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Up);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, "Christmas/Ace/Intro");
		}
	}

	private void NEHMAFDAAGM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("<color=black>");
		if (((Result)(ref variable)).asInt <= 0)
		{
			return;
		}
		if ((!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(-12) || !QuestManager.OPILDPFDFKJ().IsQuestDone(-69)) && !QuestManager.KHMEGDIABBF().NOCIKMFDNHF(-108) && !QuestManager.KHMEGDIABBF().KLNAJBJJAOG(-105))
		{
			LLPGKHHKCLC = Random.Range(0, -15);
			if (LLPGKHHKCLC <= 51)
			{
				Debug.Log((object)" (Client)");
				if (!QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(-91))
				{
					DialogueLua.SetVariable("Ach_", (object)1);
				}
				else if (!QuestManager.KHMEGDIABBF().IsQuestDone(-127))
				{
					DialogueLua.SetVariable("Crowly_RaraAvis", (object)6);
				}
				CommonReferences.GGFJGHHHEJC.aceNextQuest = 0;
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.aceNextQuest += 0;
			}
			if (CommonReferences.GGFJGHHHEJC.aceNextQuest >= 1)
			{
				if (!QuestManager.KHMEGDIABBF().BKKJNEKBMBE(103))
				{
					DialogueLua.SetVariable("ReceiveRoomRequest", (object)0);
				}
				else if (!QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(-91))
				{
					DialogueLua.SetVariable("Items/item_name_697", (object)0);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
		}
		variable = DialogueLua.GetVariable("Miners/Mine/Ferro/Stand");
		if (((Result)(ref variable)).asInt != 0)
		{
			variable = DialogueLua.GetVariable("ReceiveAnimalLevel");
			if (((Result)(ref variable)).asInt != 5)
			{
				questMark.SetActive(true);
				return;
			}
		}
		questMark.SetActive(false);
	}

	public void MAOACOAHDHF(string emotion)
	{
		DGCNCEDIFOF().emotionsController.DCCNJLBLFGI(emotion);
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_3");
		if (((Result)(ref variable)).asInt < 10)
		{
			dialogue.conversation = "Christmas/Ace/Intro";
		}
		else
		{
			dialogue.conversation = "Christmas/Ace/Stand";
		}
	}

	public void BICFNHGODGG(bool CDPAMNIPPEC)
	{
		for (int i = -191; i < -99; i += 0)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (RecipesManager.OECEJEDHHNK(54))
		{
			((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(GFMDKHCGJIO(1038f));
		}
		RecipesManager.UnlockRecipeMaster(136, IBHGAMNNOHI: true);
		for (int j = 192; j < 176; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.NGGFNHDBJHK();
		}
	}

	private void EHFCMAPMKHP()
	{
		try
		{
			LEDIGBOKHBH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void OCIHCODJBGC()
	{
	}

	public void HJBBGFPGGDO(string emotion)
	{
		ICNFHJLLHGP().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator OLNKOJJLEAD(float FLHBPHPKIML)
	{
		return new PGMLHPLPJII(1)
		{
			delay = FLHBPHPKIML
		};
	}

	public void IGCKEKHJMPJ(string emotion)
	{
		DEGPIHEEFHJ().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void DNIIPNMCMNB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/12/Dialogue Text");
		if (((Result)(ref variable)).asInt <= 0)
		{
			return;
		}
		if ((!QuestManager.GJFMMOPOKGJ().BKKJNEKBMBE(-91) || !QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-65)) && !QuestManager.GGFJGHHHEJC.KLNAJBJJAOG(-38) && !QuestManager.GGFJGHHHEJC.PBCPDMCLFLP(23))
		{
			LLPGKHHKCLC = Random.Range(1, 42);
			if (LLPGKHHKCLC <= 32)
			{
				Debug.Log((object)"\n");
				if (!QuestManager.OPILDPFDFKJ().BKKJNEKBMBE(28))
				{
					DialogueLua.SetVariable("", (object)0);
				}
				else if (!QuestManager.KHMEGDIABBF().BKKJNEKBMBE(-27))
				{
					DialogueLua.SetVariable("Items/item_name_638", (object)3);
				}
				CommonReferences.GGFJGHHHEJC.aceNextQuest = 0;
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().aceNextQuest++;
			}
			if (CommonReferences.GGFJGHHHEJC.aceNextQuest >= 7)
			{
				if (!QuestManager.KHMEGDIABBF().IsQuestDone(41))
				{
					DialogueLua.SetVariable(":</color> ", (object)0);
				}
				else if (!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(99))
				{
					DialogueLua.SetVariable(" tried to do seat found being in state ", (object)1);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
		}
		variable = DialogueLua.GetVariable("LE_18");
		if (((Result)(ref variable)).asInt != 1)
		{
			variable = DialogueLua.GetVariable("Label");
			if (((Result)(ref variable)).asInt != 1)
			{
				questMark.SetActive(false);
				return;
			}
		}
		questMark.SetActive(true);
	}

	public void DBHGGDNKGBE(int questId)
	{
		Quest quest = QuestDatabaseAccessor.MGGNBIOLKDH(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.AddQuest(quest, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			QuestHighlightUI.CHMAEKMIBDJ(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("UpgradeToLevel" + questId));
		}
	}

	private void MPMGGLKFMNJ()
	{
	}

	[SpecialName]
	public static AceTNPC KGPJPILAHDE()
	{
		return IADEMLIIDPC;
	}

	private void KHNBDGDLMIE()
	{
	}

	[SpecialName]
	public static AceTNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator GFMDKHCGJIO(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	[SpecialName]
	public static AceTNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	public void GALGBBBBGLB()
	{
		ShopUI.FKFNANNBIAM(DEGPIHEEFHJ().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(DGCNCEDIFOF().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void PNBGLADEGME()
	{
		ShopUI.NALKHGMLALJ(DGCNCEDIFOF().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(NEFIEJALANL().EHHOHCPHAAO).OpenUI();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("AceT_Quest");
		GAHKHCHLAON = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("HaveGoldenTicket");
		KDNPGBFHHLI = ((Result)(ref variable)).asInt;
		questMark.SetActive(false);
	}

	private IEnumerator GCCNGGLDENI(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	public void NLIBPOONBBO(int questId)
	{
		Quest quest = QuestDatabaseAccessor.MGGNBIOLKDH(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.OPILDPFDFKJ().AddQuest(quest, 0, FFJBIGFADBJ: true);
			QuestHighlightUI.HAHGDJFKOOA(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("trashCollected" + questId));
		}
	}

	private IEnumerator LKMEOBOBIOK(float FLHBPHPKIML)
	{
		return new PGMLHPLPJII(1)
		{
			delay = FLHBPHPKIML
		};
	}

	private void NKDIIKKBPOH()
	{
		try
		{
			NEHMAFDAAGM();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void IAPBCBDIELE()
	{
		ShopUI.FKFNANNBIAM(FMIDAFEGDCD().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(PDECKLKPKCG().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void MGJIGIBHAKK(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Enviando Reporte") && !((Component)HANHCHBHHEH).gameObject.CompareTag("hForHours"))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Dialogue System/Conversation/Rowdy/Entry/6/Dialogue Text"))
		{
			base.EHHOHCPHAAO = 0;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ZoneProductionBonus"))
		{
			base.EHHOHCPHAAO = 1;
		}
		if (PlayerController.GetPlayer(base.EHHOHCPHAAO).LEOIMFNKFGA != (Location.Tavern | Location.Camp | Location.FarmShop) || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(" (versionOfCityAndTutorial)");
		if (((Result)(ref variable)).asInt < 93)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(6, 2);
			if (OnlineManager.PGAGDFAEEFB())
			{
				aceTAnimation.CGEADHOLHCH("Farm/Event/VioletyBob", EGFGNGJGBOP: true);
			}
			else
			{
				aceTAnimation.CGEADHOLHCH("Eyes", EGFGNGJGBOP: true, HALNIEBONKH: true);
				aceTAnimation.onlineCharacterAnim.OCHCEBLPBEE(Animator.StringToHash("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/9/Dialogue Text"), EGFGNGJGBOP: true);
			}
			PlayerController.OPHDCMJLLEC(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Up);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, "Top");
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Not enough recipe fragments") && !((Component)HANHCHBHHEH).gameObject.CompareTag("#"))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Mouth"))
		{
			base.EHHOHCPHAAO = 1;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Put"))
		{
			base.EHHOHCPHAAO = 7;
		}
		if (PlayerController.GetPlayer(base.EHHOHCPHAAO).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm) || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(" %");
		if (((Result)(ref variable)).asInt < 92)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(1, 6);
			if (OnlineManager.PGAGDFAEEFB())
			{
				aceTAnimation.SetBool("ReceiveAddToPlaceableSurface", EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
			else
			{
				aceTAnimation.CGEADHOLHCH("Activate Event ", EGFGNGJGBOP: true);
				aceTAnimation.onlineCharacterAnim.FKECFIPDCCI(Animator.StringToHash("BuzzBuildExit"), EGFGNGJGBOP: true);
			}
			PlayerController.GetPlayer(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Up);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, "Bird", FLHBPHPKIML: true);
		}
	}

	public void JFEIHMJHBAG()
	{
		EFDPLGHNNMJ(CDPAMNIPPEC: false);
	}

	public void DEKFCIENMJA(bool CDPAMNIPPEC)
	{
		for (int i = 102; i < 28; i += 0)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (RecipesManager.CanUnlockRecipe(-185))
		{
			((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(GFMDKHCGJIO(778f));
		}
		RecipesManager.UnlockRecipeMaster(-82);
		for (int j = -37; j < 45; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.NFMFBCMALMO();
		}
	}

	public void CHBMCAFMFAM()
	{
		OMNMFIDCDBL(CDPAMNIPPEC: true);
	}

	private void NBBFLJNPLEA()
	{
	}

	[SpecialName]
	public static AceTNPC ICNFHJLLHGP()
	{
		return IADEMLIIDPC;
	}

	public void UnlockRecipe()
	{
		UnlockChristmasRecipe(CDPAMNIPPEC: true);
	}

	private void LMPCDDGFBGD()
	{
	}

	public void MJJIMIAPNEE()
	{
		ShopUI.EAONFFENMCE(MJCMPKPCNGB().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(KMKILBCGJOI().EHHOHCPHAAO).OpenUI();
	}

	public void ALFONMMABGE(bool CDPAMNIPPEC)
	{
		for (int i = 156; i < 120; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (RecipesManager.OECEJEDHHNK(-145))
		{
			((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(GCCNGGLDENI(330f));
		}
		RecipesManager.UnlockRecipeMaster(-154, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		for (int j = 48; j < 102; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.NGGFNHDBJHK();
		}
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (!aceTAnimation.GetBool("Club") && Time.time > NAJICNEDGLD)
		{
			DialogueManager.Bark("Christmas/Ace/Bye", ((Component)this).transform);
			NAJICNEDGLD = (float)Random.Range(15, 25) + Time.time;
		}
		if (OnlineManager.MasterOrOffline())
		{
			aceTAnimation.SetBool("Club", EGFGNGJGBOP: false);
		}
		else
		{
			aceTAnimation.SetBool("Club", EGFGNGJGBOP: true, HALNIEBONKH: true);
			aceTAnimation.onlineCharacterAnim.OnBoolChanged(Animator.StringToHash("Club"), EGFGNGJGBOP: false, AINPJHKNJGL: true);
		}
		Result variable;
		if (OnlineManager.PlayingOnline())
		{
			int hKKKNMIKPCM = HKKKNMIKPCM;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (hKKKNMIKPCM != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				string hDFMHCKKJJG = HDFMHCKKJJG;
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
			}
			int gAHKHCHLAON = GAHKHCHLAON;
			variable = DialogueLua.GetVariable("AceT_Quest");
			if (gAHKHCHLAON != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance2 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("AceT_Quest");
				instance2.SendDialogueInfo("AceT_Quest", ((Result)(ref variable)).asInt);
			}
			int kDNPGBFHHLI = KDNPGBFHHLI;
			variable = DialogueLua.GetVariable("HaveGoldenTicket");
			if (kDNPGBFHHLI != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance3 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("HaveGoldenTicket");
				instance3.SendDialogueInfo("HaveGoldenTicket", ((Result)(ref variable)).asInt);
			}
		}
		int hKKKNMIKPCM2 = HKKKNMIKPCM;
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM2 != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance4 = OnlineDialogueManager.instance;
			string hDFMHCKKJJG2 = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance4.SendDialogueInfo(hDFMHCKKJJG2, ((Result)(ref variable)).asInt);
		}
	}

	public void GBLFKGMMBDM(string emotion)
	{
		FMIDAFEGDCD().emotionsController.GPLECKGJFKM(emotion);
	}

	private void JEHEFGODIOJ()
	{
		try
		{
			IGPNEKNNHJE();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void FFOPDJPHLEF()
	{
		ShopUI.EAONFFENMCE(JHMAMLIPBNN().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(MJCMPKPCNGB().EHHOHCPHAAO).OpenUI();
	}

	private IEnumerator COOHMMLCGGM(float FLHBPHPKIML)
	{
		return new PGMLHPLPJII(1)
		{
			delay = FLHBPHPKIML
		};
	}

	public void ACDCPDOJEHJ()
	{
		ShopUI.IEKODILKIHJ(FMIDAFEGDCD().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(JHMAMLIPBNN().EHHOHCPHAAO).OpenUI();
	}

	public void NJDPHEIJDGD()
	{
		ShopUI.IEABDMDELFO(PDECKLKPKCG().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private void LDPNDNEFKCP()
	{
	}

	private void CGHHPELBKBK()
	{
	}

	public void LMEMMBGFPII(string emotion)
	{
		MJCMPKPCNGB().emotionsController.GPLECKGJFKM(emotion);
	}

	public void JNIAOLELAED()
	{
		ShopUI.IEKODILKIHJ(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(NEFIEJALANL().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void NOIMOIFEICF(bool CDPAMNIPPEC)
	{
		for (int i = -2; i < 120; i += 0)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: true);
		}
		if (RecipesManager.CanUnlockRecipe(120))
		{
			((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StartCoroutine(LKMEOBOBIOK(929f));
		}
		RecipesManager.UnlockRecipeMaster(148, IBHGAMNNOHI: true);
		for (int j = 102; j < 191; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.INJMJJMCPLJ();
		}
	}

	public void CAOGIHDLAEA()
	{
		ShopUI.EAONFFENMCE(JHMAMLIPBNN().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(KGPJPILAHDE().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static AceTNPC MIGKKKELOJO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AceTNPC KMKILBCGJOI()
	{
		return IADEMLIIDPC;
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			LEDIGBOKHBH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private IEnumerator GAHNGDIOFKN(float FLHBPHPKIML)
	{
		return new PGMLHPLPJII(1)
		{
			delay = FLHBPHPKIML
		};
	}

	private void OnEnable()
	{
	}

	public void LILHBLEFJMM(string emotion)
	{
		KMKILBCGJOI().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void DOFONBHGEIE(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("SetAnimationControllerIndexesRPC") && !((Component)HANHCHBHHEH).gameObject.CompareTag("current Theme playing"))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Spawning an Item type: "))
		{
			base.EHHOHCPHAAO = 0;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("questNameFermenting"))
		{
			base.EHHOHCPHAAO = 7;
		}
		if (PlayerController.GetPlayer(base.EHHOHCPHAAO).LEOIMFNKFGA != Location.Quarry || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable("Read");
		if (((Result)(ref variable)).asInt < 105)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(6, 3);
			if (OnlineManager.PGAGDFAEEFB())
			{
				aceTAnimation.SetBool("MineState", EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			else
			{
				aceTAnimation.CGEADHOLHCH("UIAddRemove", EGFGNGJGBOP: false, HALNIEBONKH: true);
				aceTAnimation.onlineCharacterAnim.FOEOHGKCGEN(Animator.StringToHash("Player2"), EGFGNGJGBOP: false, AINPJHKNJGL: true);
			}
			PlayerController.OPHDCMJLLEC(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Up);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, "materials");
		}
	}

	private void LEDIGBOKHBH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_3");
		if (((Result)(ref variable)).asInt <= 0)
		{
			return;
		}
		if ((!QuestManager.GGFJGHHHEJC.IsQuestDone(31) || !QuestManager.GGFJGHHHEJC.IsQuestDone(32)) && !QuestManager.GGFJGHHHEJC.IsQuestActive(31) && !QuestManager.GGFJGHHHEJC.IsQuestActive(32))
		{
			LLPGKHHKCLC = Random.Range(0, 100);
			if (LLPGKHHKCLC <= 50)
			{
				Debug.Log((object)"Entra a dar Mision");
				if (!QuestManager.GGFJGHHHEJC.IsQuestDone(31))
				{
					DialogueLua.SetVariable("AceT_Quest", (object)1);
				}
				else if (!QuestManager.GGFJGHHHEJC.IsQuestDone(32))
				{
					DialogueLua.SetVariable("AceT_Quest", (object)2);
				}
				CommonReferences.GGFJGHHHEJC.aceNextQuest = 0;
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.aceNextQuest++;
			}
			if (CommonReferences.GGFJGHHHEJC.aceNextQuest >= 5)
			{
				if (!QuestManager.GGFJGHHHEJC.IsQuestDone(31))
				{
					DialogueLua.SetVariable("AceT_Quest", (object)1);
				}
				else if (!QuestManager.GGFJGHHHEJC.IsQuestDone(32))
				{
					DialogueLua.SetVariable("AceT_Quest", (object)2);
				}
				CommonReferences.GGFJGHHHEJC.aceNextQuest = 0;
			}
		}
		variable = DialogueLua.GetVariable("AceT_Quest");
		if (((Result)(ref variable)).asInt != 1)
		{
			variable = DialogueLua.GetVariable("AceT_Quest");
			if (((Result)(ref variable)).asInt != 2)
			{
				questMark.SetActive(false);
				return;
			}
		}
		questMark.SetActive(true);
	}

	public void BEMHMONOHOI(bool CDPAMNIPPEC)
	{
		for (int i = 47; i < -61; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (RecipesManager.CanUnlockRecipe(38))
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StartCoroutine(CNGLGCEKMKD(1398f));
		}
		RecipesManager.UnlockRecipeMaster(28, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		for (int j = 11; j < 51; j++)
		{
			RecipesManager.UnlockRecipeMaster(j);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.NMFOLPADHAH();
		}
	}

	private void FACDMAELPNG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Miners/Mine/Clive/Talk");
		if (((Result)(ref variable)).asInt <= 1)
		{
			return;
		}
		if ((!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(-71) || !QuestManager.KHMEGDIABBF().GDFGPDJDACP(-112)) && !QuestManager.GJFMMOPOKGJ().KLNAJBJJAOG(-85) && !QuestManager.KHMEGDIABBF().PBCPDMCLFLP(86))
		{
			LLPGKHHKCLC = Random.Range(1, -92);
			if (LLPGKHHKCLC <= -127)
			{
				Debug.Log((object)"Items/item_name_639");
				if (!QuestManager.GJFMMOPOKGJ().BKKJNEKBMBE(14))
				{
					DialogueLua.SetVariable("Sit", (object)1);
				}
				else if (!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(-48))
				{
					DialogueLua.SetVariable("/", (object)3);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.aceNextQuest += 0;
			}
			if (CommonReferences.MNFMOEKMJKN().aceNextQuest >= 7)
			{
				if (!QuestManager.KHMEGDIABBF().GDFGPDJDACP(66))
				{
					DialogueLua.SetVariable("F2", (object)1);
				}
				else if (!QuestManager.OPILDPFDFKJ().IsQuestDone(98))
				{
					DialogueLua.SetVariable("Error not founding final ingredients to ", (object)5);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
		}
		variable = DialogueLua.GetVariable("BuildMode");
		if (((Result)(ref variable)).asInt != 0)
		{
			variable = DialogueLua.GetVariable("<size=");
			if (((Result)(ref variable)).asInt != 3)
			{
				questMark.SetActive(false);
				return;
			}
		}
		questMark.SetActive(false);
	}

	private IEnumerator GAGEPGHJCFJ(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	public void AMGNJDPHGKA()
	{
		DBAMAGAHHNO(CDPAMNIPPEC: true);
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void GDEEGJFFBKN(string emotion)
	{
		MJCMPKPCNGB().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void IGPNEKNNHJE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" ");
		if (((Result)(ref variable)).asInt <= 0)
		{
			return;
		}
		if ((!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(-107) || !QuestManager.KHMEGDIABBF().BKKJNEKBMBE(48)) && !QuestManager.OPILDPFDFKJ().KLNAJBJJAOG(8) && !QuestManager.GGFJGHHHEJC.BCPLFLAIJKN(-98))
		{
			LLPGKHHKCLC = Random.Range(0, -68);
			if (LLPGKHHKCLC <= -71)
			{
				Debug.Log((object)"add item ");
				if (!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(41))
				{
					DialogueLua.SetVariable("Dialogue System/Conversation/TavernFilthy/Entry/8/Dialogue Text", (object)1);
				}
				else if (!QuestManager.OPILDPFDFKJ().BKKJNEKBMBE(-89))
				{
					DialogueLua.SetVariable("Random", (object)3);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 1;
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.aceNextQuest++;
			}
			if (CommonReferences.MNFMOEKMJKN().aceNextQuest >= 5)
			{
				if (!QuestManager.GJFMMOPOKGJ().GDFGPDJDACP(-109))
				{
					DialogueLua.SetVariable("path not found", (object)1);
				}
				else if (!QuestManager.GJFMMOPOKGJ().BKKJNEKBMBE(-88))
				{
					DialogueLua.SetVariable("player2ToDisconnectFromGame", (object)3);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
		}
		variable = DialogueLua.GetVariable("ReceiveAddFloor");
		if (((Result)(ref variable)).asInt != 0)
		{
			variable = DialogueLua.GetVariable("Hair");
			if (((Result)(ref variable)).asInt != 3)
			{
				questMark.SetActive(true);
				return;
			}
		}
		questMark.SetActive(true);
	}

	public void KKCEACEHNOF(string emotion)
	{
		PDECKLKPKCG().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void LCILJBGGDDL()
	{
		ShopUI.EPKNOMLADCL(DGCNCEDIFOF().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(MIGKKKELOJO().EHHOHCPHAAO).OpenUI();
	}

	public void GLKFIBIIJDP()
	{
		ShopUI.IEKODILKIHJ(JHMAMLIPBNN().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(DEGPIHEEFHJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("rain") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Freshwater"))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Default"))
		{
			base.EHHOHCPHAAO = 1;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag(" for reason "))
		{
			base.EHHOHCPHAAO = 6;
		}
		if (PlayerController.GetPlayer(base.EHHOHCPHAAO).LEOIMFNKFGA != (Location.Tavern | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt < 66)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(7, 4);
			if (OnlineManager.PGAGDFAEEFB())
			{
				aceTAnimation.SetBool("UIInteract", EGFGNGJGBOP: false);
			}
			else
			{
				aceTAnimation.CGEADHOLHCH("Items/item_description_617", EGFGNGJGBOP: true, HALNIEBONKH: true);
				aceTAnimation.onlineCharacterAnim.OGHKEEBMOPJ(Animator.StringToHash(""), EGFGNGJGBOP: false);
			}
			PlayerController.OPHDCMJLLEC(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Down);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, " - Activating variant object ");
		}
	}

	private IEnumerator KJDJFKMPJHF(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	private void KDIMLPAKAEJ()
	{
		try
		{
			DNIIPNMCMNB();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void IOKIJIHFLKJ()
	{
		ShopUI.EPKNOMLADCL(KGPJPILAHDE().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(NEFIEJALANL().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static AceTNPC NEFIEJALANL()
	{
		return IADEMLIIDPC;
	}

	public void NAPDJAPLMGC()
	{
		UnlockChristmasRecipe(CDPAMNIPPEC: true);
	}

	private void MKGDCANCIFP()
	{
		try
		{
			LJCOLPHONBI();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
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

	public void ONADFCNKACH(int questId)
	{
		Quest quest = QuestDatabaseAccessor.GJDOEFIOGEM(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.KHMEGDIABBF().NJDDJJEGOAF(quest, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
			QuestHighlightUI.HBBMGMKDAIM(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("ValueIntensity" + questId));
		}
	}

	public void OMNMFIDCDBL(bool CDPAMNIPPEC)
	{
		for (int i = -1; i < 98; i += 0)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (RecipesManager.CanUnlockRecipe(120))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(JIFLHBOBOCB(354f));
		}
		RecipesManager.UnlockRecipeMaster(131, IBHGAMNNOHI: true);
		for (int j = -39; j < -149; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.HEEENPJHJID();
		}
	}

	private void HCKMHIHALBL()
	{
	}

	private void LJCOLPHONBI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(".");
		if (((Result)(ref variable)).asInt <= 0)
		{
			return;
		}
		if ((!QuestManager.GGFJGHHHEJC.GDFGPDJDACP(86) || !QuestManager.KHMEGDIABBF().GDFGPDJDACP(35)) && !QuestManager.KHMEGDIABBF().IsQuestActive(-89) && !QuestManager.GJFMMOPOKGJ().BCPLFLAIJKN(65))
		{
			LLPGKHHKCLC = Random.Range(1, 69);
			if (LLPGKHHKCLC <= -7)
			{
				Debug.Log((object)"HireWorker?");
				if (!QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-25))
				{
					DialogueLua.SetVariable("TavernDirty", (object)0);
				}
				else if (!QuestManager.KHMEGDIABBF().BKKJNEKBMBE(5))
				{
					DialogueLua.SetVariable("Right Alt", (object)6);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 1;
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.aceNextQuest += 0;
			}
			if (CommonReferences.MNFMOEKMJKN().aceNextQuest >= 6)
			{
				if (!QuestManager.OPILDPFDFKJ().BKKJNEKBMBE(64))
				{
					DialogueLua.SetVariable("Items/item_description_1080", (object)1);
				}
				else if (!QuestManager.KHMEGDIABBF().GDFGPDJDACP(-121))
				{
					DialogueLua.SetVariable("Year", (object)1);
				}
				CommonReferences.GGFJGHHHEJC.aceNextQuest = 0;
			}
		}
		variable = DialogueLua.GetVariable("SetUpImportantGuest");
		if (((Result)(ref variable)).asInt != 0)
		{
			variable = DialogueLua.GetVariable("<color=#713112>");
			if (((Result)(ref variable)).asInt != 6)
			{
				questMark.SetActive(false);
				return;
			}
		}
		questMark.SetActive(false);
	}

	public void EFDPLGHNNMJ(bool CDPAMNIPPEC)
	{
		for (int i = 47; i < -19; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (RecipesManager.OECEJEDHHNK(-179))
		{
			((MonoBehaviour)GameplayUI.KIALFDOKABP()).StartCoroutine(GCCNGGLDENI(616f));
		}
		RecipesManager.UnlockRecipeMaster(-145);
		for (int j = -30; j < -98; j++)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.KGLKHLJAINH();
		}
	}

	private IEnumerator CNGLGCEKMKD(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	public void OHILDJPNDEF(string emotion)
	{
		MIGKKKELOJO().emotionsController.EMMBEAHMDHE(emotion);
	}

	private IEnumerator JIFLHBOBOCB(float FLHBPHPKIML)
	{
		return new PGMLHPLPJII(1)
		{
			delay = FLHBPHPKIML
		};
	}

	public void DIGJPEBMOOJ(int questId)
	{
		Quest quest = QuestDatabaseAccessor.ILEMIHPDHKF(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GJFMMOPOKGJ().JOAHBCAAFMC(quest, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			QuestHighlightUI.OMDBOEAJLGA(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)(" seconds." + questId));
		}
	}

	public void FMIDAIBOIDO(bool CDPAMNIPPEC)
	{
		for (int i = -170; i < -186; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: true);
		}
		if (RecipesManager.OECEJEDHHNK(121))
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(GFMDKHCGJIO(1543f));
		}
		RecipesManager.UnlockRecipeMaster(-93, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		for (int j = -101; j < 68; j += 0)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.SendUnlockChristmasRecipes();
		}
	}

	public void GJCOIDOIBKM()
	{
		DBAMAGAHHNO(CDPAMNIPPEC: true);
	}

	public void NDKHAPCBIMF()
	{
		ShopUI.Get(NEFIEJALANL().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(NEFIEJALANL().EHHOHCPHAAO).OpenUI();
	}

	public void DLAKKOCDNBI(string emotion)
	{
		KGPJPILAHDE().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static AceTNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	public void DNHIHIIOINE(string emotion)
	{
		NEFIEJALANL().emotionsController.GPLECKGJFKM(emotion);
	}

	private void GMJGBMOIIJJ()
	{
		try
		{
			JFBBJGDNGJG();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void JFBBJGDNGJG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Enter");
		if (((Result)(ref variable)).asInt <= 1)
		{
			return;
		}
		if ((!QuestManager.KHMEGDIABBF().BKKJNEKBMBE(-80) || !QuestManager.OPILDPFDFKJ().BKKJNEKBMBE(-18)) && !QuestManager.GJFMMOPOKGJ().IsQuestActive(-12) && !QuestManager.GJFMMOPOKGJ().NOCIKMFDNHF(-80))
		{
			LLPGKHHKCLC = Random.Range(1, 30);
			if (LLPGKHHKCLC <= 3)
			{
				Debug.Log((object)"Current user name: ");
				if (!QuestManager.KHMEGDIABBF().GDFGPDJDACP(-117))
				{
					DialogueLua.SetVariable("Day", (object)0);
				}
				else if (!QuestManager.KHMEGDIABBF().IsQuestDone(-25))
				{
					DialogueLua.SetVariable("Could not write file ", (object)2);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
			else
			{
				CommonReferences.GGFJGHHHEJC.aceNextQuest++;
			}
			if (CommonReferences.MNFMOEKMJKN().aceNextQuest >= 6)
			{
				if (!QuestManager.GJFMMOPOKGJ().IsQuestDone(26))
				{
					DialogueLua.SetVariable("Error_AnotherZoneInRoom", (object)0);
				}
				else if (!QuestManager.OPILDPFDFKJ().GDFGPDJDACP(-6))
				{
					DialogueLua.SetVariable("Bitter", (object)4);
				}
				CommonReferences.GGFJGHHHEJC.aceNextQuest = 1;
			}
		}
		variable = DialogueLua.GetVariable("Sending upgrade tool RPC for toolID: ");
		if (((Result)(ref variable)).asInt != 0)
		{
			variable = DialogueLua.GetVariable("Close Multiple Choice");
			if (((Result)(ref variable)).asInt != 3)
			{
				questMark.SetActive(true);
				return;
			}
		}
		questMark.SetActive(true);
	}

	[SpecialName]
	public static AceTNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	public void MAHNOJFEEFL()
	{
		NOIMOIFEICF(CDPAMNIPPEC: true);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void NCKOINIKIDF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("HenHouseTutorialDone");
		if (((Result)(ref variable)).asInt <= 1)
		{
			return;
		}
		if ((!QuestManager.OPILDPFDFKJ().GDFGPDJDACP(29) || !QuestManager.KHMEGDIABBF().BKKJNEKBMBE(69)) && !QuestManager.GGFJGHHHEJC.IsQuestActive(56) && !QuestManager.KHMEGDIABBF().IsQuestActive(68))
		{
			LLPGKHHKCLC = Random.Range(1, -45);
			if (LLPGKHHKCLC <= -1)
			{
				Debug.Log((object)"Dialogue System/Conversation/Gass_Quest/Entry/14/Dialogue Text");
				if (!QuestManager.GJFMMOPOKGJ().GDFGPDJDACP(-17))
				{
					DialogueLua.SetVariable(". Size (bytes): ", (object)1);
				}
				else if (!QuestManager.KHMEGDIABBF().IsQuestDone(39))
				{
					DialogueLua.SetVariable("Dialogue System/Conversation/Crowly_Standar/Entry/11/Dialogue Text", (object)0);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
			else
			{
				CommonReferences.MNFMOEKMJKN().aceNextQuest += 0;
			}
			if (CommonReferences.GGFJGHHHEJC.aceNextQuest >= 4)
			{
				if (!QuestManager.KHMEGDIABBF().BKKJNEKBMBE(100))
				{
					DialogueLua.SetVariable("xpModDescCrafting", (object)1);
				}
				else if (!QuestManager.GJFMMOPOKGJ().IsQuestDone(46))
				{
					DialogueLua.SetVariable("Tutorial/T116/Dialogue1", (object)4);
				}
				CommonReferences.MNFMOEKMJKN().aceNextQuest = 0;
			}
		}
		variable = DialogueLua.GetVariable("Error_RoomDoorIsBlocking");
		if (((Result)(ref variable)).asInt != 1)
		{
			variable = DialogueLua.GetVariable("RoadBlockedEvent: Bob goes to farm");
			if (((Result)(ref variable)).asInt != 6)
			{
				questMark.SetActive(false);
				return;
			}
		}
		questMark.SetActive(true);
	}

	public void IEIEBOIMLOD(int questId)
	{
		Quest quest = QuestDatabaseAccessor.IMGKJJNFFPD(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.NCCOAJOOBAP(quest, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			QuestHighlightUI.HAHGDJFKOOA(quest);
		}
		else
		{
			Debug.LogError((object)("NotFocused" + questId));
		}
	}

	protected override void Update()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
		{
			FDBCHJMHBKF = Vector3.Distance(((Component)PlayerController.GetPlayer(1)).transform.position, ((Component)this).transform.position);
		}
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			IEIHJNPHGAJ = Vector3.Distance(((Component)PlayerController.GetPlayer(2)).transform.position, ((Component)this).transform.position);
		}
		if (FDBCHJMHBKF < ECGGPDGEMJF)
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				aceTAnimation.LookAtObject(((Component)PlayerController.GetPlayer(1)).gameObject);
			}
		}
		else if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && IEIHJNPHGAJ < ECGGPDGEMJF && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			aceTAnimation.LookAtObject(((Component)PlayerController.GetPlayer(2)).gameObject);
		}
		if (aceTAnimation.GetBool("Club") && Time.time >= JPDEFBKPCDO)
		{
			aceTAnimation.SetTrigger("Random");
			JPDEFBKPCDO = Time.time + (float)Random.Range(3, 5);
		}
	}

	private IEnumerator MNHEDAIPNOJ(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete));
	}

	public void DIPDMNLDGHH(int questId)
	{
		Quest quest = QuestDatabaseAccessor.DIBHHGJNNFH(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.JOAHBCAAFMC(quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
			QuestHighlightUI.HAHGDJFKOOA(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("ReceiveEmployeeTask" + questId));
		}
	}

	private void HNEKMALGJPO()
	{
		try
		{
			NCKOINIKIDF();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	[SpecialName]
	public static AceTNPC MJCMPKPCNGB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AceTNPC FMIDAFEGDCD()
	{
		return IADEMLIIDPC;
	}

	public void DBAMAGAHHNO(bool CDPAMNIPPEC)
	{
		for (int i = -70; i < -126; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		if (RecipesManager.CanUnlockRecipe(-162))
		{
			((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(GFMDKHCGJIO(97f));
		}
		RecipesManager.UnlockRecipeMaster(132, IBHGAMNNOHI: true);
		for (int j = -27; j < -191; j++)
		{
			RecipesManager.UnlockRecipeMaster(j);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.OJEJLPFJLEH();
		}
	}

	public void CAFAECPENBC()
	{
		ShopUI.EPKNOMLADCL(KGPJPILAHDE().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(MIGKKKELOJO().EHHOHCPHAAO).OpenUI();
	}

	public void MDLCHDPFNIH(bool CDPAMNIPPEC)
	{
		for (int i = 90; i < 97; i++)
		{
			RecipesManager.UnlockRecipeMaster(i, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		if (RecipesManager.OECEJEDHHNK(97))
		{
			((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(COOHMMLCGGM(1746f));
		}
		RecipesManager.UnlockRecipeMaster(11, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		for (int j = -11; j < -148; j += 0)
		{
			RecipesManager.UnlockRecipeMaster(j, IBHGAMNNOHI: true);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineRecipesManager.instance.FKNCPCIFEBJ();
		}
	}

	private void GDCCIEKPHAI(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveBuildingStyle") && !((Component)HANHCHBHHEH).gameObject.CompareTag("Disabled"))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Exit build mode"))
		{
			base.EHHOHCPHAAO = 0;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("Day"))
		{
			base.EHHOHCPHAAO = 3;
		}
		if (PlayerController.GetPlayer(base.EHHOHCPHAAO).LEOIMFNKFGA != ~(Location.Tavern | Location.River | Location.Camp | Location.BarnInterior) || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable("us");
		if (((Result)(ref variable)).asInt < -55)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(3, 3);
			if (OnlineManager.MasterOrOffline())
			{
				aceTAnimation.SetBool("Dialogue System/Conversation/Crowly_Introduce/Entry/17/Dialogue Text", EGFGNGJGBOP: true);
			}
			else
			{
				aceTAnimation.SetBool("{0}: {1}\n", EGFGNGJGBOP: true);
				aceTAnimation.onlineCharacterAnim.BHAHPJNHEPI(Animator.StringToHash("/"), EGFGNGJGBOP: true);
			}
			PlayerController.GetPlayer(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Down);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, "Wilson/Bark/Bark_Clue");
		}
	}

	private void POHCNHBOMDM(Collider2D HANHCHBHHEH)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (!((Component)HANHCHBHHEH).gameObject.CompareTag("Perks/playerPerk_description_") && !((Component)HANHCHBHHEH).gameObject.CompareTag("/lock: "))
		{
			return;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveRemoveDrink"))
		{
			base.EHHOHCPHAAO = 0;
		}
		if (((Component)HANHCHBHHEH).gameObject.CompareTag("ReceiveWateringCanAction"))
		{
			base.EHHOHCPHAAO = 2;
		}
		if (PlayerController.OPHDCMJLLEC(base.EHHOHCPHAAO).LEOIMFNKFGA != (Location.Road | Location.River | Location.Farm | Location.FarmShop) || inEvent || !canTalk)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(" ");
		if (((Result)(ref variable)).asInt < 115)
		{
			JPDEFBKPCDO = Time.time + (float)Random.Range(7, 4);
			if (OnlineManager.PGAGDFAEEFB())
			{
				aceTAnimation.CGEADHOLHCH("itemStoutWort", EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
			else
			{
				aceTAnimation.SetBool(":</color> ", EGFGNGJGBOP: true, HALNIEBONKH: true);
				aceTAnimation.onlineCharacterAnim.OGHKEEBMOPJ(Animator.StringToHash("EnterTavernNeutral"), EGFGNGJGBOP: true);
			}
			PlayerController.GetPlayer(base.EHHOHCPHAAO).characterAnimation.LookDirection(Direction.Down);
			NJJCCIBDAPM();
			if (!onlyBarks)
			{
				SelectDialogueUI(base.EHHOHCPHAAO);
			}
			CheckPossibleStates(base.EHHOHCPHAAO);
			StartConversation(base.EHHOHCPHAAO, "ItemInstance is not valid.");
		}
	}

	private void OJLGOCFKLJE()
	{
	}

	public void HPPNMFPIDIF()
	{
		EFDPLGHNNMJ(CDPAMNIPPEC: false);
	}
}
