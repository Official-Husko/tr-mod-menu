using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BrookDWittNPC : DialogueNPCBase
{
	private static BrookDWittNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "BrookProgress";

	private bool EONHHOIDOIN;

	public static BrookDWittNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void FPDPAJHNGHK()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BDMEBEOBEHC));
		SelectDialogueUI();
	}

	private void OnWorldLoaded()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OnWorldLoaded));
	}

	public void CGCCNBHFLEK(string emotion)
	{
		KPDFIEMDDCL().emotionsController.GPLECKGJFKM(emotion);
	}

	private void CAIJLMJBMLA()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BJHFPGAEDFM));
		SelectDialogueUI();
	}

	private void OIBDBLCLACB()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PJJMNNCEGIH));
		SelectDialogueUI(1);
	}

	public void BPGJOFGCCIN(string emotion)
	{
		JCMKNNOEONP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void BDJKNKIOPIJ()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BJHFPGAEDFM));
		SelectDialogueUI();
	}

	private void NMMHEFGFMCC()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrookDWittNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	private void BGFEBEAJOCG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DFNJMHJFLFC));
		SelectDialogueUI();
	}

	public void PAIMGGCBBMB(string emotion)
	{
		HGJMGNJOHGF().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BrookDWittNPC DPJEGJBHBNP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrookDWittNPC DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	private void PNKBHILNBLM()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(NPCPLINCDLO));
	}

	private void INHHGMPOFBF()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BDMEBEOBEHC));
	}

	private void FKPNIHJGFBJ()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FLHPLJMOOBJ));
		SelectDialogueUI();
	}

	private void NDNBDEHFFJF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		SelectDialogueUI(1);
	}

	private void PJJMNNCEGIH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KLPCPEKNOBF));
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "Pirates/Brook/Saludo";
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.MothersRecipe))
		{
			Debug.Log((object)"Brook Recipe active");
			dialogue.conversation = "MothersRecipe/MainEvent";
			return;
		}
		if (EventsManager.IsDone(EventsManager.EventType.MothersRecipe) && MissionsManager.instance.IsMissionActive(317))
		{
			Debug.Log((object)"Brook Recipe turn in");
			dialogue.conversation = "MothersRecipe/Talk";
			return;
		}
		if (MissionsManager.instance.IsMissionActive(318) && PlayerInventory.GetPlayer(base.EHHOHCPHAAO).PlayerHasEnoughItemsAged(1820, 40, 1))
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.GiveBrookGrog);
			PlayerInventory.RemoveItems(base.EHHOHCPHAAO, 1820, 40);
			dialogue.conversation = "Fortitude/MainEvent 1";
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.Fortitude))
		{
			dialogue.conversation = "PirateMinigame/Talk";
			return;
		}
		if (EventsManager.IsDone(EventsManager.EventType.MothersRecipe) && !EventsManager.IsDone(EventsManager.EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			EventsManager.SetActive(EventsManager.EventType.Fortitude, DMBFKFLDDLH: true);
			dialogue.conversation = "PirateMinigame/Talk";
			return;
		}
		variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt >= 0)
		{
			dialogue.conversation = "Pirates/Brook/Stand";
		}
	}

	[SpecialName]
	public static BrookDWittNPC HGJMGNJOHGF()
	{
		return IADEMLIIDPC;
	}

	public void LBEIJJCJLHB(string emotion)
	{
		ABHIDHPMLLD().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void KNGKIIJCEEI()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FEMEFCNMOOL));
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OnWorldLoaded));
		SelectDialogueUI();
	}

	private void KILDJCPLOPP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NEJABGEEFJF));
		SelectDialogueUI();
	}

	public void DLAKKOCDNBI(string emotion)
	{
		GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
	}

	public void IOKILGMHFNE(string emotion)
	{
		LANAINBEMCM().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void OCBNLECPJBN()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
		SelectDialogueUI();
	}

	private void CHJKEPAAKEC()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JCIKKNPMGNB));
	}

	public void EFPPOOJFNJO(string emotion)
	{
		FMIDAFEGDCD().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void CKKLLIIIBEG(string emotion)
	{
		KEJMJMKEEGA().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void OLIDLCCMNKA(string emotion)
	{
		IECOPNFJBFD().emotionsController.StartEmotion(emotion);
	}

	private void LPNBCBIBNNI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PNKBHILNBLM));
		SelectDialogueUI(1);
	}

	public void OJKEDMIKKCE(string emotion)
	{
		LFPEPJBNCBF().emotionsController.GPLECKGJFKM(emotion);
	}

	private void EBAMOAEABNH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EFBEKNLOILH));
	}

	[SpecialName]
	public static BrookDWittNPC IECOPNFJBFD()
	{
		return IADEMLIIDPC;
	}

	private void GELMGKDMJFE()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
		SelectDialogueUI(1);
	}

	private void IDHCFOCEPMD()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PJBJEJCBJKH));
		SelectDialogueUI(1);
	}

	private void DCHJDHFOEFI()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PMBGABFEMPD));
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

	private void NPCPLINCDLO()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NPCPLINCDLO));
	}

	public void HMEFIIDEMOL(string emotion)
	{
		IECOPNFJBFD().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void OLEPHIJMLPB()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(FCLMPKFKMEF));
	}

	public void GACCDKPCDMP(string emotion)
	{
		JHMAMLIPBNN().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void NKDFMFFDGKC()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DCHJDHFOEFI));
		SelectDialogueUI();
	}

	private void JCIKKNPMGNB()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CAKEKPKEPBG));
	}

	private void CAKEKPKEPBG()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(LHKDMPIJOCL));
	}

	private void KIFMLPBFFDP()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NEJABGEEFJF));
		SelectDialogueUI(1);
	}

	private void LCHKONDHINE()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(JDFDLEEELFH));
		SelectDialogueUI();
	}

	private void PBFAEPOEKPG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FLHPLJMOOBJ));
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrookDWittNPC ACPHFLBLJAA()
	{
		return IADEMLIIDPC;
	}

	private void HIPNOPNJKCP()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CAKEKPKEPBG));
	}

	private void JDFDLEEELFH()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GJDFLBGADNE));
	}

	[SpecialName]
	public static BrookDWittNPC LFPEPJBNCBF()
	{
		return IADEMLIIDPC;
	}

	private void BIGFBGOMOBA()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CGHONFBKJEA));
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrookDWittNPC GFMBEDCANNI()
	{
		return IADEMLIIDPC;
	}

	private void FIBOIODLMAG()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EBAMOAEABNH));
	}

	[SpecialName]
	public static BrookDWittNPC OKAPNFPFPFP()
	{
		return IADEMLIIDPC;
	}

	private void FCLMPKFKMEF()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(EBAMOAEABNH));
	}

	private void ANLIOHACMGO()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PJBJEJCBJKH));
	}

	[SpecialName]
	public static BrookDWittNPC HKBJIIJHBJB()
	{
		return IADEMLIIDPC;
	}

	public void JAGIEEJADMN(string emotion)
	{
		FOPGLLMEEDE().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void CDOCKCOOPIM(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void BDLLGEDIHPA(string emotion)
	{
		LCNGJIFNEOK().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void BELOIFKPNMM()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(EFBEKNLOILH));
		SelectDialogueUI();
	}

	private void GNGADDPBJDC()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PMBGABFEMPD));
		SelectDialogueUI(1);
	}

	private void DHOMCKHIGNF()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PJBJEJCBJKH));
	}

	private void EGDIINMEMGE()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BJHFPGAEDFM));
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrookDWittNPC HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	private void HOFKJPBBLGP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PNKBHILNBLM));
		SelectDialogueUI();
	}

	public void LILHBLEFJMM(string emotion)
	{
		ABHIDHPMLLD().emotionsController.GPLECKGJFKM(emotion);
	}

	private void PHMFCIKFADH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(DCHJDHFOEFI));
	}

	private void FHEGBNMJADG()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(KNGKIIJCEEI));
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrookDWittNPC KPDFIEMDDCL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrookDWittNPC MNFMOEKMJKN()
	{
		return IADEMLIIDPC;
	}

	public void KIBIHBFJOJH(string emotion)
	{
		GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BrookDWittNPC BNDNMBGJEKP()
	{
		return IADEMLIIDPC;
	}

	private void EBNKNEIDDDI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static BrookDWittNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	public void EICNDMGMPLE(string emotion)
	{
		LCNGJIFNEOK().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void JCNKIPBPOFC(string emotion)
	{
		MAIDHAPANEB().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void BMLJMLBEAOO(string emotion)
	{
		HKBJIIJHBJB().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void NJNEKKGKEKA()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PNKBHILNBLM));
	}

	public void ACMMENIGKLK(string emotion)
	{
		JHMAMLIPBNN().emotionsController.StartEmotion(emotion);
	}

	private void HFMJPMEALMO()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(MFBPGPKONNO));
		SelectDialogueUI(1);
	}

	private void KLPCPEKNOBF()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OLEPHIJMLPB));
	}

	private void LDPGPIHCBCH()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FCLMPKFKMEF));
		SelectDialogueUI();
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public override void CheckExclamationSendOnline(bool sendOnline)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 || (!EventsManager.IsDone(EventsManager.EventType.MothersRecipe) && MissionsManager.instance.IsMissionActive(310)) || (EventsManager.IsDone(EventsManager.EventType.MothersRecipe) && !EventsManager.IsDone(EventsManager.EventType.Fortitude)))
		{
			GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline, NNDJFLDGKDL: true);
		}
		else
		{
			GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, sendOnline);
		}
	}

	private void PCMJOOALNFC()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PHMFCIKFADH));
	}

	public void NLBFEHJDELC(string emotion)
	{
		DOIKFJDLKJP().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void PAGIAAKPDCE()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PMBGABFEMPD));
		SelectDialogueUI(1);
	}

	private void BOIGOJGNNAK()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CAKEKPKEPBG));
		SelectDialogueUI();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (EventsManager.IsActive(EventsManager.EventType.Fortitude) || (MissionsManager.instance.IsMissionActive(318) && PlayerInventory.GetPlayer(base.EHHOHCPHAAO).PlayerHasEnoughItemsAged(1820, 40, 1)))
		{
			if (Utils.MMMFJPKECAB(Location.PirateShip))
			{
				return base.MouseUp(JIIGOACEIKL);
			}
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Error/NotAllPlayersHere");
			return false;
		}
		return base.MouseUp(JIIGOACEIKL);
	}

	private void HOKAPOOCJCC()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JCIKKNPMGNB));
		SelectDialogueUI();
	}

	private void HHLBFDBHDMC()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PCMJOOALNFC));
		SelectDialogueUI();
	}

	private void PJBJEJCBJKH()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(FEMEFCNMOOL));
	}

	[SpecialName]
	public static BrookDWittNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	private void OILHJENGGEL()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(MFBPGPKONNO));
		SelectDialogueUI(1);
	}

	private void FLHPLJMOOBJ()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PJJMNNCEGIH));
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void BNIKICAEIND()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GHHMKBNFIDN));
		SelectDialogueUI();
	}

	public void AMLCKCOBHGO(string emotion)
	{
		ACPHFLBLJAA().emotionsController.GPLECKGJFKM(emotion);
	}

	private void KEIICPHCIIF()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FLHPLJMOOBJ));
	}

	private void EFBEKNLOILH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(KLPCPEKNOBF));
	}

	[SpecialName]
	public static BrookDWittNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	public void LGMDDMFKIAD(string emotion)
	{
		ABHIDHPMLLD().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static BrookDWittNPC HFHPMKJGMPA()
	{
		return IADEMLIIDPC;
	}

	private void NEJABGEEFJF()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CGHONFBKJEA));
	}

	private void EEKOJEKPIMP()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(GHHMKBNFIDN));
		SelectDialogueUI(1);
	}

	private void BDMEBEOBEHC()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BDMEBEOBEHC));
	}

	private void NDGFPPOBCNP()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BJHFPGAEDFM));
		SelectDialogueUI();
	}

	public void DBMPAGNJFFK(string emotion)
	{
		LFPEPJBNCBF().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static BrookDWittNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrookDWittNPC JLNBMNKJCHE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrookDWittNPC MPJJAPCFENH()
	{
		return IADEMLIIDPC;
	}

	private void EDIDJHLJJBC()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EDIDJHLJJBC));
	}

	[SpecialName]
	public static BrookDWittNPC LCNGJIFNEOK()
	{
		return IADEMLIIDPC;
	}

	private void FEMEFCNMOOL()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EFBEKNLOILH));
	}

	[SpecialName]
	public static BrookDWittNPC FMIDAFEGDCD()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrookDWittNPC FOPGLLMEEDE()
	{
		return IADEMLIIDPC;
	}

	private void HLLCOCEAGHK()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(KNGKIIJCEEI));
	}

	[SpecialName]
	public static BrookDWittNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	private void GHHMKBNFIDN()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PHMFCIKFADH));
	}

	public void OOJEGKJLOED(string emotion)
	{
		DOIKFJDLKJP().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void KEPJNGGNAEK()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DFNJMHJFLFC));
		SelectDialogueUI(1);
	}

	private void CGHONFBKJEA()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DHOMCKHIGNF));
	}

	[SpecialName]
	public static BrookDWittNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrookDWittNPC KEJMJMKEEGA()
	{
		return IADEMLIIDPC;
	}

	public void GAPGANPHAEI(string emotion)
	{
		JLNBMNKJCHE().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void JNKMIEOLHDD(string emotion)
	{
		HKBJIIJHBJB().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void IAIDKPJKLIC()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CAKEKPKEPBG));
		SelectDialogueUI();
	}

	private void PMBGABFEMPD()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(JCIKKNPMGNB));
	}

	private void BJHFPGAEDFM()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(NEJABGEEFJF));
	}

	private void LOHAMDHOLDD()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OnWorldLoaded));
		SelectDialogueUI();
	}

	private void JPOLFKMLHNH()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(GHHMKBNFIDN));
		SelectDialogueUI();
	}

	private void ELPFAGMEFJP()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CHJKEPAAKEC));
		SelectDialogueUI(1);
	}

	private void MFBPGPKONNO()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NPCPLINCDLO));
	}

	[SpecialName]
	public static BrookDWittNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	private void DCKKIDMJKJM()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KLPCPEKNOBF));
		SelectDialogueUI(1);
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void IDPHKHGHJGN()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OnWorldLoaded));
		SelectDialogueUI(1);
	}

	private void DFNJMHJFLFC()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(NJNEKKGKEKA));
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void LHKDMPIJOCL()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BDMEBEOBEHC));
	}

	private void GJDFLBGADNE()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PNKBHILNBLM));
	}

	private void OLDDEAJMHNI()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(EDIDJHLJJBC));
		SelectDialogueUI(1);
	}

	private void EACIGGOOKGD()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PJJMNNCEGIH));
		SelectDialogueUI();
	}

	[SpecialName]
	public static BrookDWittNPC AJIGOHGPFPP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BrookDWittNPC JCMKNNOEONP()
	{
		return IADEMLIIDPC;
	}

	private void NPMLFHDHJBE()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OnWorldLoaded));
		SelectDialogueUI();
	}
}
