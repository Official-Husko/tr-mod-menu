using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class NessyNPC : DialogueNPCBase
{
	private static NessyNPC IADEMLIIDPC;

	public float timeBarks;

	public CrowlyEvent crowlyEvent;

	public float minBarkTime;

	public float maxBarkTime;

	private float AELCMIGFOAK;

	public NPCRoutine[] routines;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_21";

	private bool MEMGFCDNICE;

	public static NessyNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void EMCOGEPBACH()
	{
		DogSelectorUI.ALDNEMJHMOI().Open(OMFKNGDCJFN().EHHOHCPHAAO);
		PlayerInventory.OGKNJNINGMH(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(198, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private void FAKFFEFOKHF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		Result variable;
		switch (Random.Range(1, 8))
		{
		case 0:
			if (animationBase.animator.GetBool("Cat"))
			{
				dialogue.conversation = "Items/item_description_1038";
			}
			else if (animationBase.animator.GetBool("{0} photon instantiation. ViewID: {1}"))
			{
				dialogue.conversation = "Room missing required items";
			}
			else if (animationBase.animator.GetBool("No"))
			{
				dialogue.conversation = "attachment";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 7)
				{
					dialogue.conversation = "Player";
				}
				else
				{
					dialogue.conversation = "privatetest";
				}
			}
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUIPetShop();
				onlineBarkDialogue = true;
			}
			break;
		case 1:
			if (!((Component)MarcusNPC.OAPOJCODNCO()).gameObject.activeSelf)
			{
				break;
			}
			if (MarcusNPC.BDAGIEIJOOG().animationBase.animator.GetBool("debug service"))
			{
				MarcusNPC.LADDMEMMJFP().dialogue.conversation = "Items/item_name_706";
			}
			else if (MarcusNPC.OAPOJCODNCO().animationBase.animator.GetBool("PlayerPlatformIDRPC"))
			{
				MarcusNPC.NBKKEINELDN().dialogue.conversation = "Player2";
			}
			else if (MarcusNPC.MAAAKALBBEE().animationBase.animator.GetBool("SetBoolRPC"))
			{
				MarcusNPC.DCAEBALADIM().dialogue.conversation = "NeutralInTavern";
			}
			else if (MarcusNPC.DCAEBALADIM().animationBase.animator.GetBool(""))
			{
				MarcusNPC.LKOABOAADCD().dialogue.conversation = "ActionBar5";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 8)
				{
					MarcusNPC.LADDMEMMJFP().dialogue.conversation = " is Reading.";
				}
				else
				{
					MarcusNPC.MAIDHAPANEB().dialogue.conversation = "0";
				}
			}
			KNEHCFHGDFC();
			MarcusNPC.GGFJGHHHEJC.main = false;
			MarcusNPC.ABHIDHPMLLD().dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUIPetShop();
				MarcusNPC.BGMJCCFNNDL().onlineBarkDialogue = true;
			}
			break;
		}
	}

	public void JLLNBMNLAMF()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!MarcusNPC.ABHIDHPMLLD().inInteractiveDialogue)
		{
			MarcusNPC.NEFIEJALANL().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private IEnumerator LJFMKNCAAJH()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 2 && crowlyEvent.startCrowlyEvent)
			{
				CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
			}
			else
			{
				CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
			}
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CheckExclamation));
	}

	public void NOCPFIHMCLH(int questId)
	{
		Quest quest = QuestDatabaseAccessor.MFCLBOPPEBB(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.KHMEGDIABBF().NCCOAJOOBAP(quest, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
			QuestHighlightUI.NDABOMBDJFH(quest);
		}
		else
		{
			Debug.LogError((object)("\n<color=#822F00>" + questId));
		}
	}

	private IEnumerator BMFBKMILHAD()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 2 && crowlyEvent.startCrowlyEvent)
			{
				CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
			}
			else
			{
				CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
			}
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CheckExclamation));
	}

	public void LCLDDJLHBPL()
	{
		HFIJHDBKCIA().routine.StopRoutine();
		MarcusNPC.MAIDHAPANEB().routine.StopRoutine();
		JackyController.CNDNOECMKME().npc.SetActive(false);
	}

	public void ANFNEBBFFFA()
	{
		DialogueLua.SetVariable("Hide", (object)43);
	}

	public void LAOAHFLAIAP()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!MarcusNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			MarcusNPC.MAIDHAPANEB().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void LJBGLBDEKJH(int questId)
	{
		Quest quest = QuestDatabaseAccessor.LIOCDDEMOMC(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.NJDDJJEGOAF(quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			QuestHighlightUI.DFLEEAJJOBD(quest);
		}
		else
		{
			Debug.LogError((object)("Player" + questId));
		}
	}

	private void DOHLOJOIHFO()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CheckExclamation));
	}

	public void NOFGHCJLHFD()
	{
		PlayerInventory.NEKDDPIAOBE(BNDMEINJPAN().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(-122).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void MKFPKPJJOCP()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.GGFJGHHHEJC.content.activeInHierarchy || (Object)(object)MarcusNPC.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 2)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > 1000)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 1004)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.GGFJGHHHEJC.inUse && !MarcusNPC.GGFJGHHHEJC.inBark && MarcusNPC.GGFJGHHHEJC.canTalk)
		{
			IDHKFLCNIIP();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.GGFJGHHHEJC.inUse || MarcusNPC.GGFJGHHHEJC.inBark || !MarcusNPC.GGFJGHHHEJC.canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void CNNFGMCGOOB()
	{
		GGFJGHHHEJC.crowlyEvent.LEJKGGGGEBF(base.EHHOHCPHAAO, CDPAMNIPPEC: false);
	}

	public void DBCAOCAOGGB()
	{
		DialogueLua.SetVariable("Items/item_description_1036", (object)3);
		DFJGHOHPPEL().crowlyEvent.startCrowlyEvent = false;
	}

	public void PDAELELNEIB()
	{
		EBAIHKJHCCA().crowlyEvent.MGGIPCAKCJM(base.EHHOHCPHAAO, CDPAMNIPPEC: true);
	}

	private void PNNHMJGIEJL()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			KCEBLHNEAAC();
		}
	}

	public void GEEMEMFJMCH()
	{
		DFJGHOHPPEL().crowlyEvent.HIHKBOJCDJD(base.EHHOHCPHAAO, CDPAMNIPPEC: true);
	}

	public void GAADIDHFPGP(string emotion)
	{
		EBAIHKJHCCA().emotionsController.StartEmotion(emotion);
	}

	private void GOEGBOEMHLI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CAKMJKDLEOB));
	}

	private void MDOFDCIKDFO()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(5).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			HHJFIHKMAEI();
		}
	}

	public void BFANCGMDLGH()
	{
		PlayerInventory.NEKDDPIAOBE(HFIJHDBKCIA().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(87, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	[SpecialName]
	public static NessyNPC BNDMEINJPAN()
	{
		return IADEMLIIDPC;
	}

	public void GECEAGDCPCH()
	{
		PlayerInventory.NEKDDPIAOBE(EBAIHKJHCCA().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(81).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void OBLDAJIAFAM()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!MarcusNPC.ABHIDHPMLLD().inInteractiveDialogue)
		{
			MarcusNPC.GGFJGHHHEJC.StopConversation();
		}
	}

	private void EIJIHCGEBNE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(1, 6);
		Result variable;
		if (num != 0)
		{
			if (num != 0 || !((Component)MarcusNPC.MAIDHAPANEB()).gameObject.activeSelf)
			{
				return;
			}
			if (MarcusNPC.JHKLPLPBKCI().animationBase.animator.GetBool("Dialogue System/Conversation/Gass_Stand/Entry/6/Dialogue Text"))
			{
				MarcusNPC.POINNCPMEIG().dialogue.conversation = "itemChilliSeeds";
			}
			else if (MarcusNPC.HNNJEBNIPOI().animationBase.animator.GetBool(" "))
			{
				MarcusNPC.HNNJEBNIPOI().dialogue.conversation = "Player2";
			}
			else if (MarcusNPC.LADDMEMMJFP().animationBase.animator.GetBool("overnights"))
			{
				MarcusNPC.MAIDHAPANEB().dialogue.conversation = "PhaseItem";
			}
			else if (MarcusNPC.MAIDHAPANEB().animationBase.animator.GetBool(": "))
			{
				MarcusNPC.JHKLPLPBKCI().dialogue.conversation = "Happy";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 4)
				{
					MarcusNPC.POINNCPMEIG().dialogue.conversation = "ReceiveSetDirtiness";
				}
				else
				{
					MarcusNPC.OAPOJCODNCO().dialogue.conversation = "Toy";
				}
			}
			KNEHCFHGDFC();
			MarcusNPC.BGMJCCFNNDL().main = false;
			MarcusNPC.OAPOJCODNCO().dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUIPetShop();
				MarcusNPC.MAIDHAPANEB().onlineBarkDialogue = false;
			}
			return;
		}
		if (animationBase.animator.GetBool("Old KEG "))
		{
			dialogue.conversation = "vampirehouse";
		}
		else if (animationBase.animator.GetBool("UI2"))
		{
			dialogue.conversation = "bartenderDesc";
		}
		else if (animationBase.animator.GetBool("."))
		{
			dialogue.conversation = "is not a food instance";
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 8)
			{
				dialogue.conversation = "UI";
			}
			else
			{
				dialogue.conversation = "";
			}
		}
		KNEHCFHGDFC();
		main = true;
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.PCBOEBKIFAM();
			onlineBarkDialogue = false;
		}
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void JFPDLJDMOBC()
	{
		PlayerInventory.GetPlayer(MPLODJJFKAM().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.GetItem(-157, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	public void HLFLPNOOMNF()
	{
		ShopUI.IEABDMDELFO(DFJGHOHPPEL().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(DFJGHOHPPEL().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void JGPNBDIDJBF()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 2)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > 146)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < -133)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[1]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = false;
						((Behaviour)routines[0]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[0]).enabled = false;
				((Behaviour)routines[1]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[1];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.HHDBMDMFEMP() && ((Behaviour)routines[0]).enabled)
		{
			((Behaviour)routines[0]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1524f)
		{
			DGOOBGDLJFP();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[1]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[1]).enabled = true;
				((Behaviour)routines[1]).enabled = true;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_0116;
	}

	private void LJPPIKFAOAM()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null && PlayerController.OPHDCMJLLEC(2).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			FNHBFFHLFPB();
		}
	}

	public void FinishJackyQuest()
	{
		DialogueLua.SetVariable("LE_21", (object)1003);
	}

	protected override void Update()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (OnlineManager.MasterOrOffline() && !crowlyEvent.startCrowlyEvent && Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			MKFPKPJJOCP();
		}
	}

	private void IMICJCPJHDA()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null && PlayerController.GetPlayer(3).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			HHJFIHKMAEI();
		}
	}

	public void PDHFANEFGJN()
	{
		JackyController.GGFJGHHHEJC.PEFLEPMOEHB(CDPAMNIPPEC: false);
	}

	public void FOJLDMIPGDK()
	{
		if (!MarcusNPC.MAIDHAPANEB().inInteractiveDialogue)
		{
			MarcusNPC.NJNFHEPLEHL().StopConversation();
		}
	}

	private void EOGHJNGJFID()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(DINEBCGMLDI));
	}

	public void AOILENGIEED()
	{
		HFIJHDBKCIA().routine.StopRoutine();
		MarcusNPC.OKAPNFPFPFP().routine.StopRoutine();
		JackyController.NBKKEINELDN().npc.SetActive(true);
	}

	private void HHJFIHKMAEI()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 8)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > 76)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < 166)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[1]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[1]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[0]).enabled = false;
				((Behaviour)routines[1]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.ClientOnline() && ((Behaviour)routines[0]).enabled)
		{
			((Behaviour)routines[1]).enabled = true;
			((Behaviour)routines[0]).enabled = false;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1912f)
		{
			MKFPKPJJOCP();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[1]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[1]).enabled = true;
				((Behaviour)routines[0]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[1];
			}
		}
		goto IL_0116;
	}

	public void ANOHINJENOB()
	{
		DogSelectorUI.PNHHCHJCDNM().OFGKFMJKBON(OMFKNGDCJFN().EHHOHCPHAAO);
		PlayerInventory.EIFPKCAFDIB(OMFKNGDCJFN().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(48).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private IEnumerator EBHBPCEMDHD()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 2 && crowlyEvent.startCrowlyEvent)
			{
				CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
			}
			else
			{
				CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
			}
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CheckExclamation));
	}

	public void StopOtherDialogues()
	{
		if (!MarcusNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			MarcusNPC.GGFJGHHHEJC.StopConversation();
		}
	}

	public void HFNPOCDIDPP(int questId)
	{
		Quest quest = QuestDatabaseAccessor.GetQuest(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.JOAHBCAAFMC(quest, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			QuestHighlightUI.OMDBOEAJLGA(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)("OnConversationResponseMenuRPC" + questId));
		}
	}

	public void DOJKONOHPLD()
	{
		DogSelectorUI.PNHHCHJCDNM().OFGKFMJKBON(MPLODJJFKAM().EHHOHCPHAAO);
		PlayerInventory.EIFPKCAFDIB(BNDMEINJPAN().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(-181, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void OKIGLPDDFDJ()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!MarcusNPC.JHKLPLPBKCI().inInteractiveDialogue)
		{
			MarcusNPC.JHKLPLPBKCI().StopConversation();
		}
	}

	public void CELILHLBFBJ(int questId)
	{
		Quest quest = QuestDatabaseAccessor.ILEMIHPDHKF(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.NCCOAJOOBAP(quest, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			QuestHighlightUI.HAHGDJFKOOA(quest);
		}
		else
		{
			Debug.LogError((object)("<b>" + questId));
		}
	}

	public void BAOPDEGHMIC()
	{
		GGFJGHHHEJC.routine.StopRoutine();
		MarcusNPC.MAIDHAPANEB().routine.StopRoutine();
		JackyController.CNDNOECMKME().npc.SetActive(true);
	}

	[SpecialName]
	public static NessyNPC DFJGHOHPPEL()
	{
		return IADEMLIIDPC;
	}

	public void CAKMJKDLEOB()
	{
		((MonoBehaviour)this).StartCoroutine(LJFMKNCAAJH());
	}

	public void InitJackyEvent()
	{
		JackyController.GGFJGHHHEJC.InitJackyEvent(CDPAMNIPPEC: true);
	}

	private void PKINFPDGLNN()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.NEFIEJALANL().content.activeInHierarchy || (Object)(object)MarcusNPC.OAPOJCODNCO() == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 2)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > 185)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < -98)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.OKAPNFPFPFP().inUse && !MarcusNPC.HNNJEBNIPOI().inBark && MarcusNPC.CHKMFEFOFKJ().canTalk)
		{
			MAHGCFJECHC();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.LADDMEMMJFP().inUse || MarcusNPC.OKAPNFPFPFP().inBark || !MarcusNPC.ABHIDHPMLLD().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
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

	private void FDADCNCPGMK()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.DCAEBALADIM().content.activeInHierarchy || (Object)(object)MarcusNPC.MAAAKALBBEE() == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 5)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > -99)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < -4)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.ABHIDHPMLLD().inUse && !MarcusNPC.POINNCPMEIG().inBark && MarcusNPC.NBKKEINELDN().canTalk)
		{
			MAHGCFJECHC();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.MAIDHAPANEB().inUse || MarcusNPC.NEFIEJALANL().inBark || !MarcusNPC.LKOABOAADCD().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt >= 2)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt > 1000)
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 1004)
				{
					goto IL_005a;
				}
			}
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 3)
			{
				dialogue.conversation = "City/PetShop/Nessy/PerritosAbandonados";
				return;
			}
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 3002)
			{
				dialogue.conversation = "City/PetShop/Nessy/PerritosAbandonados3";
				return;
			}
			dialogue.conversation = "City/PetShop/Nessy/Stand";
			if ((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC != (Object)null)
			{
				DialogueLua.SetVariable("Cat", (object)true);
			}
			if ((Object)(object)DogNPC.instance != (Object)null)
			{
				DialogueLua.SetVariable("Dog", (object)true);
			}
			if (!OnlineManager.MasterOrOffline())
			{
				return;
			}
			if ((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC == (Object)null)
			{
				variable = DialogueLua.GetVariable("Cat");
				if (((Result)(ref variable)).asBool)
				{
					DialogueLua.SetVariable("Cat", (object)false);
				}
			}
			if ((Object)(object)DogNPC.instance == (Object)null)
			{
				variable = DialogueLua.GetVariable("Dog");
				if (((Result)(ref variable)).asBool)
				{
					DialogueLua.SetVariable("Dog", (object)false);
				}
			}
			return;
		}
		goto IL_005a;
		IL_005a:
		dialogue.conversation = "City/PetShop/Nessy/Intro";
		if ((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC != (Object)null)
		{
			DialogueLua.SetVariable("Cat", (object)true);
		}
	}

	public void AHPPNNCMOKO()
	{
		DogSelectorUI.GGFJGHHHEJC.OFGKFMJKBON(DFJGHOHPPEL().EHHOHCPHAAO);
		PlayerInventory.GetPlayer(EBAIHKJHCCA().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(-128, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	[SpecialName]
	public static NessyNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator PDJLPKLMHBD()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 2 && crowlyEvent.startCrowlyEvent)
			{
				CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
			}
			else
			{
				CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
			}
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CheckExclamation));
	}

	public void OHOFLFGLPDE()
	{
		JackyController.NBKKEINELDN().AJOPEMBGKKF(CDPAMNIPPEC: true);
	}

	public void DPMJEBCBBBJ()
	{
		if (!MarcusNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			MarcusNPC.HNNJEBNIPOI().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void OOEENAHJGPK()
	{
		if ((Object)(object)PlayerController.GetPlayer(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(3) != (Object)null && PlayerController.OPHDCMJLLEC(8).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			GKCFAMLIDFN();
		}
	}

	private void FAGKINHOIAD()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 1; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 1).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.OPHDCMJLLEC(5).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			HEMJBFMKKJC();
		}
	}

	public void BMNFEAHLBJB(string emotion)
	{
		BNDMEINJPAN().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void OOHPFKCGHDC()
	{
		DialogueLua.SetVariable("Dialogue System/Conversation/TavernClean/Entry/2/Dialogue Text", (object)(-98));
	}

	private void BOADFAFAIJG()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = false;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.OPHDCMJLLEC(5).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			FNHBFFHLFPB();
		}
	}

	protected override void KNEHCFHGDFC()
	{
		barkDialogue = true;
		GGFJGHHHEJC.SelectDialogueUI();
		MarcusNPC.GGFJGHHHEJC.barkDialogue = true;
		MarcusNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	public void MCIOGGCMPHD()
	{
		if (!MarcusNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			MarcusNPC.JHKLPLPBKCI().StopConversation(BGKCHMNJBLJ: false);
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

	[SpecialName]
	public static NessyNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	public void OIGDHLLJMAB()
	{
		DogSelectorUI.OOKBNHMMFON().Open(MPLODJJFKAM().EHHOHCPHAAO);
		PlayerInventory.OGKNJNINGMH(HFIJHDBKCIA().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-33, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void LKBJDABBENK()
	{
		JackyController.OAPOJCODNCO().IPPLOJEGDBA(CDPAMNIPPEC: false);
	}

	public void NNKENPOKAGO(int questId)
	{
		Quest quest = QuestDatabaseAccessor.IMGKJJNFFPD(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.KHMEGDIABBF().AddQuest(quest, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			QuestHighlightUI.CANBDKHONFE(quest);
		}
		else
		{
			Debug.LogError((object)("" + questId));
		}
	}

	public void BDBDHKNDKAJ()
	{
		PlayerInventory.GetPlayer(EBAIHKJHCCA().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(112).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private void EGACIHOKJLH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CheckExclamation));
	}

	public void HJCDGIHGILO()
	{
		GGFJGHHHEJC.routine.StopRoutine();
		MarcusNPC.NEFIEJALANL().routine.StopRoutine();
		JackyController.LDBJELPPBAI().npc.SetActive(true);
	}

	private void KNBHOHJIJBE()
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 0) == (Object)null) && PlayerController.GetPlayer(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.GetPlayer(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.OPHDCMJLLEC(5).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			HEMJBFMKKJC();
		}
	}

	public void StopAllDialogues()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!MarcusNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			MarcusNPC.GGFJGHHHEJC.StopConversation();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public void IJPJIPCHHKE()
	{
		JackyController.LDBJELPPBAI().InitJackyEvent(CDPAMNIPPEC: true);
	}

	private void OMAEGIAHOGI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(1, 6);
		Result variable;
		if (num != 0)
		{
			if (num != 0 || !((Component)MarcusNPC.BGMJCCFNNDL()).gameObject.activeSelf)
			{
				return;
			}
			if (MarcusNPC.JHKLPLPBKCI().animationBase.animator.GetBool(")"))
			{
				MarcusNPC.MAIDHAPANEB().dialogue.conversation = "DialogueStartRPC";
			}
			else if (MarcusNPC.OKAPNFPFPFP().animationBase.animator.GetBool("LE_21"))
			{
				MarcusNPC.MAIDHAPANEB().dialogue.conversation = "Build Mode";
			}
			else if (MarcusNPC.NEFIEJALANL().animationBase.animator.GetBool("TermasInterior/Rin/Stand"))
			{
				MarcusNPC.DCAEBALADIM().dialogue.conversation = "Game Over! Pool temperature out of safe range for too long.";
			}
			else if (MarcusNPC.POINNCPMEIG().animationBase.animator.GetBool(", "))
			{
				MarcusNPC.HNNJEBNIPOI().dialogue.conversation = ")";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 4)
				{
					MarcusNPC.NEFIEJALANL().dialogue.conversation = " is not supported by CanvasWorldScaler";
				}
				else
				{
					MarcusNPC.ABHIDHPMLLD().dialogue.conversation = "Items/item_name_1191";
				}
			}
			KNEHCFHGDFC();
			MarcusNPC.LADDMEMMJFP().main = true;
			MarcusNPC.BDAGIEIJOOG().dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.PCBOEBKIFAM();
				MarcusNPC.BGMJCCFNNDL().onlineBarkDialogue = false;
			}
			return;
		}
		if (animationBase.animator.GetBool("Invalid NPC photonID: {0} for NPCRoutine."))
		{
			dialogue.conversation = "Complete order";
		}
		else if (animationBase.animator.GetBool("tavernVisionActive"))
		{
			dialogue.conversation = " ";
		}
		else if (animationBase.animator.GetBool("ReceiveKeyPuzzle"))
		{
			dialogue.conversation = "tutorialPopUp82";
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 6)
			{
				dialogue.conversation = "Showing Keyboard ";
			}
			else
			{
				dialogue.conversation = "Wall";
			}
		}
		KNEHCFHGDFC();
		main = false;
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendResetDialogueUIPetShop();
			onlineBarkDialogue = false;
		}
	}

	private void MAHGCFJECHC()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		Result variable;
		switch (Random.Range(1, 2))
		{
		case 0:
			if (animationBase.animator.GetBool("mForMins"))
			{
				dialogue.conversation = "Cider";
			}
			else if (animationBase.animator.GetBool("Sending upgrade tool RPC for toolID: "))
			{
				dialogue.conversation = "dForDays";
			}
			else if (animationBase.animator.GetBool("WaterTrough"))
			{
				dialogue.conversation = "FishCuttingEvent/RetryTalk";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 6)
				{
					dialogue.conversation = "Generate All Routes";
				}
				else
				{
					dialogue.conversation = "Player minigame states: \n {0}, {1}, {2}, {3},";
				}
			}
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.PCBOEBKIFAM();
				onlineBarkDialogue = false;
			}
			break;
		case 1:
			if (!((Component)MarcusNPC.POINNCPMEIG()).gameObject.activeSelf)
			{
				break;
			}
			if (MarcusNPC.LKOABOAADCD().animationBase.animator.GetBool("Cancel"))
			{
				MarcusNPC.MAAAKALBBEE().dialogue.conversation = "ThemeType: ";
			}
			else if (MarcusNPC.NBKKEINELDN().animationBase.animator.GetBool("UpgradeToLevel"))
			{
				MarcusNPC.LADDMEMMJFP().dialogue.conversation = ":<color=#3a0603> +";
			}
			else if (MarcusNPC.NJNFHEPLEHL().animationBase.animator.GetBool("Pick up"))
			{
				MarcusNPC.NEFIEJALANL().dialogue.conversation = "";
			}
			else if (MarcusNPC.OKAPNFPFPFP().animationBase.animator.GetBool("ErrorServerTimeout"))
			{
				MarcusNPC.NEFIEJALANL().dialogue.conversation = "No MinePuzzleBase found for type {0} when trying to get required elements count";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 1)
				{
					MarcusNPC.DCAEBALADIM().dialogue.conversation = "\n";
				}
				else
				{
					MarcusNPC.NEFIEJALANL().dialogue.conversation = " ";
				}
			}
			KNEHCFHGDFC();
			MarcusNPC.BGMJCCFNNDL().main = true;
			MarcusNPC.OKAPNFPFPFP().dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUIPetShop();
				MarcusNPC.MAIDHAPANEB().onlineBarkDialogue = false;
			}
			break;
		}
	}

	public void PBJCCHNHGMA()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!MarcusNPC.LKOABOAADCD().inInteractiveDialogue)
		{
			MarcusNPC.MAAAKALBBEE().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void InitCrowlyEvent()
	{
		DialogueLua.SetVariable("LE_21", (object)2);
		GGFJGHHHEJC.crowlyEvent.startCrowlyEvent = true;
	}

	public void EDFDJPOHMCE()
	{
		DialogueLua.SetVariable("RoadBlocked/Main 2", (object)8);
		HFIJHDBKCIA().crowlyEvent.startCrowlyEvent = false;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void JPPIBMGCGKA()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.NBKKEINELDN().content.activeInHierarchy || (Object)(object)MarcusNPC.NEFIEJALANL() == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 5)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > 150)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < -117)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.GGFJGHHHEJC.inUse && !MarcusNPC.MAIDHAPANEB().inBark && MarcusNPC.JHKLPLPBKCI().canTalk)
		{
			MAHGCFJECHC();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.HEKFJEKFMNO().inUse || MarcusNPC.CHKMFEFOFKJ().inBark || !MarcusNPC.MAIDHAPANEB().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void EHBAHMOAAOK()
	{
		JackyController.GGFJGHHHEJC.InitJackyEvent(CDPAMNIPPEC: true);
	}

	public void LCLNGAAFKNB()
	{
		((MonoBehaviour)this).StartCoroutine(BMFBKMILHAD());
	}

	public void GCLEMKNLBJI()
	{
		DialogueLua.SetVariable("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/10/Dialogue Text", (object)54);
	}

	public void BKNJELKKGJC()
	{
		HFIJHDBKCIA().routine.StopRoutine();
		MarcusNPC.LADDMEMMJFP().routine.StopRoutine();
		JackyController.NBKKEINELDN().npc.SetActive(true);
	}

	[SpecialName]
	public static NessyNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	public void OLAKKCAOONE()
	{
		PlayerInventory.GetPlayer(EBAIHKJHCCA().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-145).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
	}

	public void BELAGEPNOBO()
	{
		PlayerInventory.OGKNJNINGMH(HFIJHDBKCIA().EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(183, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
	}

	public void HICGHFBHDHG(string emotion)
	{
		HFIJHDBKCIA().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void IPBJIPDNHCB()
	{
		JackyController.LDBJELPPBAI().OHOFLFGLPDE(CDPAMNIPPEC: false);
	}

	public void OAGKIMBFIHA()
	{
		((MonoBehaviour)this).StartCoroutine(PDJLPKLMHBD());
	}

	public void LHDBKHJFEJN()
	{
		GGFJGHHHEJC.routine.StopRoutine();
		MarcusNPC.GGFJGHHHEJC.routine.StopRoutine();
		JackyController.NBKKEINELDN().npc.SetActive(true);
	}

	private void HEMJBFMKKJC()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 1)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > 128)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < -37)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[0]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[1]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[1]).enabled = false;
				((Behaviour)routines[1]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.HHDBMDMFEMP() && ((Behaviour)routines[1]).enabled)
		{
			((Behaviour)routines[1]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 84f)
		{
			JPPIBMGCGKA();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				((Behaviour)routines[0]).enabled = false;
				((Behaviour)routines[1]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_0116;
	}

	public void IDPKDDHFGBF()
	{
		ShopUI.EPKNOMLADCL(EBAIHKJHCCA().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(EBAIHKJHCCA().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void CLPFAHMINAF()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.OAPOJCODNCO().content.activeInHierarchy || (Object)(object)MarcusNPC.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 7)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > 148)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 7)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.HNNJEBNIPOI().inUse && !MarcusNPC.NBKKEINELDN().inBark && MarcusNPC.NEFIEJALANL().canTalk)
		{
			MAHGCFJECHC();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.BDAGIEIJOOG().inUse || MarcusNPC.NEFIEJALANL().inBark || !MarcusNPC.GGFJGHHHEJC.canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (base.MouseUp(JIIGOACEIKL))
		{
			StopOtherDialogues();
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.TalkWithNessy);
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(9);
			}
			return true;
		}
		return false;
	}

	private void KOOOCCPMNHK()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 4)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > 166)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < 30)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[1]).enabled = false;
						((Behaviour)routines[1]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[1];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[1]).enabled)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				((Behaviour)routines[0]).enabled = false;
				((Behaviour)routines[1]).enabled = true;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[1];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.ClientOnline() && ((Behaviour)routines[1]).enabled)
		{
			((Behaviour)routines[1]).enabled = false;
			((Behaviour)routines[1]).enabled = false;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 649f)
		{
			DGOOBGDLJFP();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				((Behaviour)routines[1]).enabled = true;
				((Behaviour)routines[0]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[1];
			}
		}
		goto IL_0116;
	}

	public void GAGGNJCBMCK()
	{
		if (!MarcusNPC.POINNCPMEIG().inInteractiveDialogue)
		{
			MarcusNPC.NEFIEJALANL().StopConversation();
		}
	}

	private void OPBONFFCOCD()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.BDAGIEIJOOG().content.activeInHierarchy || (Object)(object)MarcusNPC.OKAPNFPFPFP() == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 2)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > -90)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 132)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.HEKFJEKFMNO().inUse && !MarcusNPC.MAIDHAPANEB().inBark && MarcusNPC.HNNJEBNIPOI().canTalk)
		{
			FAKFFEFOKHF();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.LADDMEMMJFP().inUse || MarcusNPC.ABHIDHPMLLD().inBark || !MarcusNPC.OKAPNFPFPFP().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void ADDHKOEGHJI()
	{
		ShopUI.EPKNOMLADCL(BNDMEINJPAN().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(BNDMEINJPAN().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void KHHIGGPNAND()
	{
		ShopUI.NALKHGMLALJ(HFIJHDBKCIA().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(EBAIHKJHCCA().EHHOHCPHAAO).OpenUI();
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
		if (GGFJGHHHEJC.inSpecialEvent)
		{
			GGFJGHHHEJC.inSpecialEvent = false;
		}
	}

	public void FinishAdoptionQuest()
	{
		DialogueLua.SetVariable("LE_21", (object)3002);
	}

	private void GKCFAMLIDFN()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 1)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > -158)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < 189)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.PGAGDFAEEFB())
					{
						((Behaviour)routines[0]).enabled = false;
						((Behaviour)routines[1]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[1]).enabled = false;
				((Behaviour)routines[0]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[1];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.HHDBMDMFEMP() && ((Behaviour)routines[0]).enabled)
		{
			((Behaviour)routines[0]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 1620f)
		{
			JPPIBMGCGKA();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				((Behaviour)routines[1]).enabled = false;
				((Behaviour)routines[1]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_0116;
	}

	private void MMAIAHJCIPF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(1, 2);
		Result variable;
		if (num != 0)
		{
			if (num != 0 || !((Component)MarcusNPC.HEKFJEKFMNO()).gameObject.activeSelf)
			{
				return;
			}
			if (MarcusNPC.MAIDHAPANEB().animationBase.animator.GetBool(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object."))
			{
				MarcusNPC.HEKFJEKFMNO().dialogue.conversation = "Get Components ";
			}
			else if (MarcusNPC.DCAEBALADIM().animationBase.animator.GetBool("ReceiveRemoveFromInteracting"))
			{
				MarcusNPC.BGMJCCFNNDL().dialogue.conversation = "Items/item_description_650";
			}
			else if (MarcusNPC.DCAEBALADIM().animationBase.animator.GetBool("Open"))
			{
				MarcusNPC.CHKMFEFOFKJ().dialogue.conversation = "Waiting for mine to load for client ";
			}
			else if (MarcusNPC.POINNCPMEIG().animationBase.animator.GetBool("Farm/Event/Love"))
			{
				MarcusNPC.HNNJEBNIPOI().dialogue.conversation = " </mark>";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 4)
				{
					MarcusNPC.ABHIDHPMLLD().dialogue.conversation = "Bird";
				}
				else
				{
					MarcusNPC.HNNJEBNIPOI().dialogue.conversation = "ReceiveAddQuestInfo";
				}
			}
			KNEHCFHGDFC();
			MarcusNPC.OKAPNFPFPFP().main = false;
			MarcusNPC.LADDMEMMJFP().dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.PCBOEBKIFAM();
				MarcusNPC.NJNFHEPLEHL().onlineBarkDialogue = false;
			}
			return;
		}
		if (animationBase.animator.GetBool("F2"))
		{
			dialogue.conversation = "No bucket of water";
		}
		else if (animationBase.animator.GetBool("Stone"))
		{
			dialogue.conversation = "Nature";
		}
		else if (animationBase.animator.GetBool("</color>"))
		{
			dialogue.conversation = "Hammer";
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 2)
			{
				dialogue.conversation = "Winner";
			}
			else
			{
				dialogue.conversation = " added to delivery chest";
			}
		}
		KNEHCFHGDFC();
		main = false;
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.SendResetDialogueUIPetShop();
			onlineBarkDialogue = true;
		}
	}

	public void EKLKNNBPKLG()
	{
		HFIJHDBKCIA().routine.StopRoutine();
		MarcusNPC.NJNFHEPLEHL().routine.StopRoutine();
		JackyController.OAPOJCODNCO().npc.SetActive(false);
	}

	public void IEMMPKJBINF()
	{
		DialogueLua.SetVariable("#.##%", (object)(-43));
	}

	public void HMKDMMGGOFD()
	{
		DogSelectorUI.BADFKMEJOKE().Open(GGFJGHHHEJC.EHHOHCPHAAO);
		PlayerInventory.EIFPKCAFDIB(MPLODJJFKAM().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(-85, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
	}

	private void PGJJBPALEGM()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OAGKIMBFIHA));
	}

	[SpecialName]
	public static NessyNPC MPLODJJFKAM()
	{
		return IADEMLIIDPC;
	}

	public void LIPKAONLLII()
	{
		DialogueLua.SetVariable("Received set minigame", (object)(-139));
	}

	public void BMJFLBPPCGO()
	{
		if (!MarcusNPC.NEFIEJALANL().inInteractiveDialogue)
		{
			MarcusNPC.HNNJEBNIPOI().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void DGOOBGDLJFP()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.POINNCPMEIG().content.activeInHierarchy || (Object)(object)MarcusNPC.LKOABOAADCD() == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 8)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > 46)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < -77)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.LADDMEMMJFP().inUse && !MarcusNPC.BGMJCCFNNDL().inBark && MarcusNPC.MAAAKALBBEE().canTalk)
		{
			MMAIAHJCIPF();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.MAAAKALBBEE().inUse || MarcusNPC.OAPOJCODNCO().inBark || !MarcusNPC.NJNFHEPLEHL().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void AOEDKILBNAK()
	{
		DialogueLua.SetVariable("Bed.instance doesnt exist. Cannot SendDeselectPlaceable uniqueId: ", (object)24);
	}

	public void FNAAKBNDCJJ(int questId)
	{
		Quest quest = QuestDatabaseAccessor.PALCOBBGFGM(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GJFMMOPOKGJ().JOAHBCAAFMC(quest, 0, FFJBIGFADBJ: true);
			QuestHighlightUI.CANBDKHONFE(quest, LFBJCGLGEIN: false);
		}
		else
		{
			Debug.LogError((object)(" : 00" + questId));
		}
	}

	public void MOEBKNMCBMP()
	{
		ShopUI.AGNKKAPMHLN(BNDMEINJPAN().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public new void CheckExclamation()
	{
		((MonoBehaviour)this).StartCoroutine(BMFBKMILHAD());
	}

	public void KOGHKPMOGBD()
	{
		PlayerInventory.GetPlayer(HFIJHDBKCIA().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(61, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	public void KCKGPHEACFO()
	{
		ShopUI.Get(BNDMEINJPAN().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void DINEBCGMLDI()
	{
		((MonoBehaviour)this).StartCoroutine(LJFMKNCAAJH());
	}

	public void ABJNIKPLGIP()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!MarcusNPC.OKAPNFPFPFP().inInteractiveDialogue)
		{
			MarcusNPC.ABHIDHPMLLD().StopConversation();
		}
	}

	private void IDHKFLCNIIP()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		Result variable;
		switch (Random.Range(0, 2))
		{
		case 0:
			if (animationBase.animator.GetBool("Pet"))
			{
				dialogue.conversation = "City/PetShop/Nessy/Barks_PetDog";
			}
			else if (animationBase.animator.GetBool("Play"))
			{
				dialogue.conversation = "City/PetShop/Nessy/Barks_PlayingCat";
			}
			else if (animationBase.animator.GetBool("Sit"))
			{
				dialogue.conversation = "City/PetShop/Nessy/Barks_CatSleep";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 2)
				{
					dialogue.conversation = "City/PetShop/Nessy/Intro_Barks";
				}
				else
				{
					dialogue.conversation = "City/PetShop/Nessy/Barks";
				}
			}
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUIPetShop();
				onlineBarkDialogue = true;
			}
			break;
		case 1:
			if (!((Component)MarcusNPC.GGFJGHHHEJC).gameObject.activeSelf)
			{
				break;
			}
			if (MarcusNPC.GGFJGHHHEJC.animationBase.animator.GetBool("Sweep"))
			{
				MarcusNPC.GGFJGHHHEJC.dialogue.conversation = "City/PetShop/Markus/Barks_Barrer";
			}
			else if (MarcusNPC.GGFJGHHHEJC.animationBase.animator.GetBool("Care"))
			{
				MarcusNPC.GGFJGHHHEJC.dialogue.conversation = "City/PetShop/Markus/Barks_RevisarPata";
			}
			else if (MarcusNPC.GGFJGHHHEJC.animationBase.animator.GetBool("Feed"))
			{
				MarcusNPC.GGFJGHHHEJC.dialogue.conversation = "City/PetShop/Markus/Barks_Turtle";
			}
			else if (MarcusNPC.GGFJGHHHEJC.animationBase.animator.GetBool("Price"))
			{
				MarcusNPC.GGFJGHHHEJC.dialogue.conversation = "City/PetShop/Markus/Barks_FeedDog";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 2)
				{
					MarcusNPC.GGFJGHHHEJC.dialogue.conversation = "City/PetShop/Markus/Intro_Barks";
				}
				else
				{
					MarcusNPC.GGFJGHHHEJC.dialogue.conversation = "City/PetShop/Markus/Barks";
				}
			}
			KNEHCFHGDFC();
			MarcusNPC.GGFJGHHHEJC.main = true;
			MarcusNPC.GGFJGHHHEJC.dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUIPetShop();
				MarcusNPC.GGFJGHHHEJC.onlineBarkDialogue = true;
			}
			break;
		}
	}

	public void LGFEDLDDOHJ()
	{
		HFIJHDBKCIA().crowlyEvent.DHNLDEOINNO(base.EHHOHCPHAAO, CDPAMNIPPEC: true);
	}

	public void FLADCCBEAFH(int questId)
	{
		Quest quest = QuestDatabaseAccessor.PALCOBBGFGM(questId);
		if (Object.op_Implicit((Object)(object)quest))
		{
			QuestManager.GGFJGHHHEJC.JOAHBCAAFMC(quest, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			QuestHighlightUI.NDABOMBDJFH(quest);
		}
		else
		{
			Debug.LogError((object)("Items/item_description_637" + questId));
		}
	}

	public void GKKLMANHKEC()
	{
		DialogueLua.SetVariable(":", (object)8);
		GGFJGHHHEJC.crowlyEvent.startCrowlyEvent = false;
	}

	public void KIOMHEIDHFN(string emotion)
	{
		HFIJHDBKCIA().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void HKKDEKIFPPJ()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OAGKIMBFIHA));
	}

	public void MoveCrowly()
	{
		GGFJGHHHEJC.crowlyEvent.Move(base.EHHOHCPHAAO, CDPAMNIPPEC: true);
	}

	public void GiveAdoptionSign()
	{
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1689).JMDALJBNFML(), HMPDLIPFBGD: true);
	}

	private void PNBGDLPNHKH()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = false;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(1).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null && PlayerController.GetPlayer(3).IsInPetShop()))
		{
			MEMGFCDNICE = true;
		}
		else
		{
			MEMGFCDNICE = false;
		}
		if (!MEMGFCDNICE)
		{
			KCEBLHNEAAC();
		}
	}

	private void MKNKBIPCBLJ()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 0)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > 173)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < -120)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[1]).enabled = true;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[1]).enabled = false;
				((Behaviour)routines[1]).enabled = true;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[1];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.ClientOnline() && ((Behaviour)routines[1]).enabled)
		{
			((Behaviour)routines[1]).enabled = true;
			((Behaviour)routines[0]).enabled = true;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 737f)
		{
			PKINFPDGLNN();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[1]).enabled)
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				((Behaviour)routines[0]).enabled = true;
				((Behaviour)routines[0]).enabled = true;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_0116;
	}

	private void FNHBFFHLFPB()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 8)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > 80)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < -46)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[1]).enabled = true;
						((Behaviour)routines[0]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[0]).enabled = false;
				((Behaviour)routines[1]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.HHDBMDMFEMP() && ((Behaviour)routines[0]).enabled)
		{
			((Behaviour)routines[0]).enabled = false;
			((Behaviour)routines[1]).enabled = true;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 44f)
		{
			MKFPKPJJOCP();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[1]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[0]).enabled = false;
				((Behaviour)routines[0]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_0116;
	}

	public void AEBGFJJLADM()
	{
		ShopUI.EAONFFENMCE(BNDMEINJPAN().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(MPLODJJFKAM().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void StopAllRoutines()
	{
		GGFJGHHHEJC.routine.StopRoutine();
		MarcusNPC.GGFJGHHHEJC.routine.StopRoutine();
		JackyController.GGFJGHHHEJC.npc.SetActive(false);
	}

	private void INJNEAHMJKJ()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		int num = Random.Range(0, 1);
		Result variable;
		if (num != 0)
		{
			if (num != 0 || !((Component)MarcusNPC.ABHIDHPMLLD()).gameObject.activeSelf)
			{
				return;
			}
			if (MarcusNPC.OKAPNFPFPFP().animationBase.animator.GetBool("LE_11"))
			{
				MarcusNPC.HNNJEBNIPOI().dialogue.conversation = "Dialogue System/Conversation/TooDark/Entry/8/Dialogue Text";
			}
			else if (MarcusNPC.MAAAKALBBEE().animationBase.animator.GetBool("in "))
			{
				MarcusNPC.MAAAKALBBEE().dialogue.conversation = "<color=#FFA726>+";
			}
			else if (MarcusNPC.POINNCPMEIG().animationBase.animator.GetBool("Key Altar puzzle: missing keys for the puzzle."))
			{
				MarcusNPC.NEFIEJALANL().dialogue.conversation = "Speed";
			}
			else if (MarcusNPC.LADDMEMMJFP().animationBase.animator.GetBool("screen_mode"))
			{
				MarcusNPC.NEFIEJALANL().dialogue.conversation = "KickedSpinDirection";
			}
			else
			{
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 8)
				{
					MarcusNPC.NJNFHEPLEHL().dialogue.conversation = "LE_14";
				}
				else
				{
					MarcusNPC.BGMJCCFNNDL().dialogue.conversation = "ReceiveSetTableParent";
				}
			}
			KNEHCFHGDFC();
			MarcusNPC.NEFIEJALANL().main = false;
			MarcusNPC.MAIDHAPANEB().dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUIPetShop();
				MarcusNPC.DCAEBALADIM().onlineBarkDialogue = false;
			}
			return;
		}
		if (animationBase.animator.GetBool("Object"))
		{
			dialogue.conversation = "Select File";
		}
		else if (animationBase.animator.GetBool("FishCuttingEvent/RetryTalk"))
		{
			dialogue.conversation = "[GetFallbackCandidates] Total fallback candidates: {0}";
		}
		else if (animationBase.animator.GetBool("ConnectionTimeout"))
		{
			dialogue.conversation = "Listview";
		}
		else
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 6)
			{
				dialogue.conversation = "Player/Bark/Tutorial/SleepBlock";
			}
			else
			{
				dialogue.conversation = "Welcome to {0}!";
			}
		}
		KNEHCFHGDFC();
		main = true;
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineDialogue.PCBOEBKIFAM();
			onlineBarkDialogue = false;
		}
	}

	public void OpenDogSelector()
	{
		DogSelectorUI.GGFJGHHHEJC.Open(GGFJGHHHEJC.EHHOHCPHAAO);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1692).JMDALJBNFML(), HMPDLIPFBGD: true);
	}

	public void EMNOPJDENPF()
	{
		PlayerInventory.EIFPKCAFDIB(GGFJGHHHEJC.EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(16, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CheckExclamation));
	}

	private void PFAAEIECHKL()
	{
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			return;
		}
		if (OnlineManager.PlayingOnline())
		{
			MEMGFCDNICE = true;
			for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i += 0)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i + 1) == (Object)null) && PlayerController.OPHDCMJLLEC(i + 0).IsInPetShop())
				{
					MEMGFCDNICE = true;
					break;
				}
			}
		}
		else if (PlayerController.OPHDCMJLLEC(0).IsInPetShop() || (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && PlayerController.OPHDCMJLLEC(7).IsInPetShop()))
		{
			MEMGFCDNICE = false;
		}
		else
		{
			MEMGFCDNICE = true;
		}
		if (!MEMGFCDNICE)
		{
			MKNKBIPCBLJ();
		}
	}

	private void NBDOBHOELNK()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (Time.time <= AELCMIGFOAK || !content.activeInHierarchy || !MarcusNPC.OKAPNFPFPFP().content.activeInHierarchy || (Object)(object)MarcusNPC.MAAAKALBBEE() == (Object)null)
		{
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt < 0)
		{
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt > -151)
		{
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt < 77)
			{
				return;
			}
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !MarcusNPC.ABHIDHPMLLD().inUse && !MarcusNPC.HEKFJEKFMNO().inBark && MarcusNPC.MAAAKALBBEE().canTalk)
		{
			MMAIAHJCIPF();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || !canTalk || MarcusNPC.DCAEBALADIM().inUse || MarcusNPC.GGFJGHHHEJC.inBark || !MarcusNPC.NJNFHEPLEHL().canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	private void KCEBLHNEAAC()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!crowlyEvent.startCrowlyEvent)
		{
			if (routine.currentRoutine == -1)
			{
				Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt < 2)
				{
					goto IL_006b;
				}
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				if (((Result)(ref variable)).asInt > 1000)
				{
					variable = DialogueLua.GetVariable(HDFMHCKKJJG);
					if (((Result)(ref variable)).asInt < 1004)
					{
						goto IL_006b;
					}
				}
				if (!((Behaviour)routines[0]).enabled)
				{
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)routines[0]).enabled = true;
						((Behaviour)routines[1]).enabled = false;
					}
					if ((Object)(object)onlineNPC != (Object)null)
					{
						onlineNPC.routine = routines[0];
					}
				}
			}
			goto IL_0116;
		}
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[0]).enabled = false;
				((Behaviour)routines[1]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[0];
			}
		}
		goto IL_018d;
		IL_018d:
		if (OnlineManager.ClientOnline() && ((Behaviour)routines[0]).enabled)
		{
			((Behaviour)routines[0]).enabled = false;
			((Behaviour)routines[1]).enabled = false;
		}
		return;
		IL_0116:
		if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			MKFPKPJJOCP();
		}
		goto IL_018d;
		IL_006b:
		if (((Behaviour)routines[0]).enabled)
		{
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)routines[1]).enabled = true;
				((Behaviour)routines[0]).enabled = false;
			}
			if ((Object)(object)onlineNPC != (Object)null)
			{
				onlineNPC.routine = routines[1];
			}
		}
		goto IL_0116;
	}

	public void INODCBFHBPM()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!MarcusNPC.POINNCPMEIG().inInteractiveDialogue)
		{
			MarcusNPC.JHKLPLPBKCI().StopConversation();
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}
}
