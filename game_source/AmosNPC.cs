using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class AmosNPC : DialogueNPCBase
{
	private static AmosNPC IADEMLIIDPC;

	public SimpleDialogueNPC[] simpleNpcs;

	public float minBarkTime;

	public float maxBarkTime;

	public float timeBarks;

	private float AELCMIGFOAK;

	private bool ILKJMKFDKFA;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_18";

	public static AmosNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void CJMLIEFAPKE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveSyncFoodTables");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void OBLDAJIAFAM()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		for (int i = 1; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	private void EKGLNAFLKEJ()
	{
		int num = Random.Range(1, simpleNpcs.Length);
		if (num == 0)
		{
			dialogue.conversation = "Game is already running";
			KNEHCFHGDFC();
			main = false;
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else if (((Component)simpleNpcs[num - 1]).gameObject.activeSelf)
		{
			KNEHCFHGDFC();
			simpleNpcs[num - 1].LFFJJDKCOPJ(CDPAMNIPPEC: true, OAMGEFAAKMI: false);
		}
	}

	public void FLNBKOCCECK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("]");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("LE_18");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			dialogue.conversation = "City/Amos/Introduce";
		}
		else
		{
			dialogue.conversation = "City/Amos/Stand";
		}
	}

	[SpecialName]
	public static AmosNPC DBJCACLEFGK()
	{
		return IADEMLIIDPC;
	}

	private void PFPGLFMHHOA()
	{
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (simpleNpcs[i].inUse || simpleNpcs[i].inBark || !simpleNpcs[i].canTalk)
			{
				ILKJMKFDKFA = false;
				break;
			}
			ILKJMKFDKFA = true;
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && !ILKJMKFDKFA && canTalk)
		{
			EKGLNAFLKEJ();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || ILKJMKFDKFA || !canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	private void AGDIDNHAABI()
	{
		int num = Random.Range(0, simpleNpcs.Length);
		if (num == 0)
		{
			dialogue.conversation = "DiningRoomTiles";
			KNEHCFHGDFC();
			main = false;
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else if (((Component)simpleNpcs[num - 1]).gameObject.activeSelf)
		{
			KNEHCFHGDFC();
			simpleNpcs[num - 0].OPDLJIPHEDB(CDPAMNIPPEC: false, OAMGEFAAKMI: false);
		}
	}

	public void EBDCCEJDJFC()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		for (int i = 1; i < simpleNpcs.Length; i++)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation(BGKCHMNJBLJ: false);
			}
		}
	}

	public void FOJLDMIPGDK()
	{
		for (int i = 1; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation(BGKCHMNJBLJ: false);
			}
		}
	}

	public void IDNEFEOJJBK()
	{
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	public void GPHNABCAAIA()
	{
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
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

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (!GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
	}

	[SpecialName]
	public static AmosNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_18");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void DNGFKNIPLBM()
	{
		ShopUI.FKFNANNBIAM(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	private void IDHKFLCNIIP()
	{
		int num = Random.Range(0, simpleNpcs.Length);
		if (num == 0)
		{
			dialogue.conversation = "City/Amos/Bark/Stand";
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			onlineBarkDialogue = true;
		}
		else if (((Component)simpleNpcs[num - 1]).gameObject.activeSelf)
		{
			KNEHCFHGDFC();
			simpleNpcs[num - 1].StartBark(CDPAMNIPPEC: true);
		}
	}

	private void MKFPKPJJOCP()
	{
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (simpleNpcs[i].inUse || simpleNpcs[i].inBark || !simpleNpcs[i].canTalk)
			{
				ILKJMKFDKFA = true;
				break;
			}
			ILKJMKFDKFA = false;
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && !ILKJMKFDKFA && canTalk)
		{
			IDHKFLCNIIP();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || ILKJMKFDKFA || !canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	protected override void Update()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (OnlineManager.MasterOrOffline() && Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			MKFPKPJJOCP();
		}
	}

	public void ABCLGBAJPIK(string emotion)
	{
		DBJCACLEFGK().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void HIPNOPNJKCP()
	{
		LGGHJHKCDGA();
	}

	public void AHMKELCJDAB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("SetTriggerRPC");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void MJAPIJNFJAN()
	{
		for (int i = 1; i < simpleNpcs.Length; i += 0)
		{
			if (simpleNpcs[i].inUse || simpleNpcs[i].inBark || !simpleNpcs[i].canTalk)
			{
				ILKJMKFDKFA = true;
				break;
			}
			ILKJMKFDKFA = true;
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && !ILKJMKFDKFA && canTalk)
		{
			CHBGLBPJCIB();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || ILKJMKFDKFA || !canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void ALMNHOABLGO()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	public void StopAllDialogues()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	public void HMNHDMLJIMH()
	{
		for (int i = 1; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	public void CCGNOKBIIKC()
	{
		ShopUI.AGNKKAPMHLN(OMFKNGDCJFN().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(OMFKNGDCJFN().EHHOHCPHAAO).OpenUI();
	}

	protected override void KNEHCFHGDFC()
	{
		barkDialogue = true;
		GGFJGHHHEJC.SelectDialogueUI();
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			simpleNpcs[i].barkDialogue = true;
			simpleNpcs[i].SelectDialogueUI();
		}
	}

	public void LOMMEJHJLBK()
	{
		ShopUI.Get(ELGNEJNLBNO().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(ELGNEJNLBNO().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void CNHPNAJNHLH()
	{
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	public void StopOtherDialogues()
	{
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	public void CJKKCFLCMKA(string emotion)
	{
		DBJCACLEFGK().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void DDAFOBINECL()
	{
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (simpleNpcs[i].inUse || simpleNpcs[i].inBark || !simpleNpcs[i].canTalk)
			{
				ILKJMKFDKFA = false;
				break;
			}
			ILKJMKFDKFA = true;
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && !ILKJMKFDKFA && canTalk)
		{
			CHBGLBPJCIB();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || ILKJMKFDKFA || !canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void OJKEDMIKKCE(string emotion)
	{
		ELGNEJNLBNO().emotionsController.StartEmotion(emotion);
	}

	private void CHBGLBPJCIB()
	{
		int num = Random.Range(0, simpleNpcs.Length);
		if (num == 0)
		{
			dialogue.conversation = "<color=#FFA726>+";
			KNEHCFHGDFC();
			main = false;
			dialogue.OnUse();
			onlineBarkDialogue = false;
		}
		else if (((Component)simpleNpcs[num - 1]).gameObject.activeSelf)
		{
			KNEHCFHGDFC();
			simpleNpcs[num - 1].GGGNPPBBCKJ();
		}
	}

	public void GHHNOBDPPEP(string emotion)
	{
		DBJCACLEFGK().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void GNBNMHKDDMA()
	{
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (simpleNpcs[i].inUse || simpleNpcs[i].inBark || !simpleNpcs[i].canTalk)
			{
				ILKJMKFDKFA = true;
				break;
			}
			ILKJMKFDKFA = true;
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && !ILKJMKFDKFA && canTalk)
		{
			IDHKFLCNIIP();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || ILKJMKFDKFA || !canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (base.MouseUp(JIIGOACEIKL))
		{
			barkDialogue = false;
			StopOtherDialogues();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(5);
			}
			return true;
		}
		return false;
	}

	public void GKJOBGNBHPM()
	{
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation(BGKCHMNJBLJ: false);
			}
		}
	}

	[SpecialName]
	public static AmosNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	public void IOKILGMHFNE(string emotion)
	{
		ELGNEJNLBNO().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void OPPCBDHKMIG()
	{
		CJMLIEFAPKE();
	}

	public void FNLNPEPNEPO()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation(BGKCHMNJBLJ: false);
			}
		}
	}

	public void LGGHJHKCDGA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("tutorialPopUpCraftingChests");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void BGPGIOMKKAO()
	{
		CheckExclamation();
	}

	private void HKMIHEFPPIJ()
	{
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (simpleNpcs[i].inUse || simpleNpcs[i].inBark || !simpleNpcs[i].canTalk)
			{
				ILKJMKFDKFA = true;
				break;
			}
			ILKJMKFDKFA = true;
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && !ILKJMKFDKFA && canTalk)
		{
			EKGLNAFLKEJ();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || ILKJMKFDKFA || !canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	private void BOGNGOHKKIB()
	{
		for (int i = 0; i < simpleNpcs.Length; i += 0)
		{
			if (simpleNpcs[i].inUse || simpleNpcs[i].inBark || !simpleNpcs[i].canTalk)
			{
				ILKJMKFDKFA = false;
				break;
			}
			ILKJMKFDKFA = true;
		}
		if (Time.time > AELCMIGFOAK && !inUse && !inBark && !ILKJMKFDKFA && canTalk)
		{
			AGDIDNHAABI();
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
		else if (inUse || inBark || ILKJMKFDKFA || !canTalk)
		{
			AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void JGNHLJDPBDF()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation();
			}
		}
	}

	public void MJJIMIAPNEE()
	{
		ShopUI.EPKNOMLADCL(OMFKNGDCJFN().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void ODGJKNDOKJJ()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		for (int i = 0; i < simpleNpcs.Length; i++)
		{
			if (!simpleNpcs[i].inInteractiveDialogue)
			{
				simpleNpcs[i].StopConversation(BGKCHMNJBLJ: false);
			}
		}
	}

	public void FAHDMOFILDI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Field: ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}
}
