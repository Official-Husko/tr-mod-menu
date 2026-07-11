using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class KujakuNPC : DialogueNPCBase
{
	private static KujakuNPC IADEMLIIDPC;

	public Collider2D shopCollider;

	public float timeBarks;

	private bool IEJHFPEKKAH;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_14";

	public static KujakuNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void AHPFECCLOBB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EKDNJDJHONF().dialogueEvent))
		{
			DEGPIHEEFHJ().barkDialogue = true;
			DEGPIHEEFHJ().mouseUpTrigger = false;
			BADFKMEJOKE().StartConversation(0, NEFIEJALANL().dialogueEvent);
			EKDNJDJHONF().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void ADFMHFLPNOF()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
	}

	private void CFIIEJDJFPB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	[SpecialName]
	public static KujakuNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	private void HBMDEHPHAPF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
	}

	public void OOLNCBPPLLE()
	{
		ShopUI.AGNKKAPMHLN(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(NEFIEJALANL().EHHOHCPHAAO).OpenUI();
	}

	public void HEACFLIHBBI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AHECKLFEFAB));
			walkTo.NOFKEMGPFEO();
		}
	}

	public void POCIILOJOJD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.EJPGFOEDPBG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(AHPFECCLOBB));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LHEHNNJGINH));
			walkTo.PEHELKCIECB();
		}
	}

	public void EEBOKKANBEM(string emotion)
	{
		GGFJGHHHEJC.emotionsController.DCCNJLBLFGI(emotion);
	}

	private void KLMENKODJNG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		HEACFLIHBBI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (EventsManager.IsActive(EventsManager.EventType.Precision) || EventsManager.IsActive(EventsManager.EventType.FishCutting))
		{
			if (Utils.MMMFJPKECAB(Location.KujakuHouse))
			{
				return base.MouseUp(JIIGOACEIKL);
			}
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Error/NotAllPlayersHere");
			return false;
		}
		if (inShop || EventsManager.IsActive(EventsManager.EventType.FishCutting))
		{
			return base.MouseUp(JIIGOACEIKL);
		}
		return false;
	}

	public override void CheckExclamationSendOnline(bool sendOnline)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt != 9 || EventsManager.IsDone(EventsManager.EventType.KujakuShop))
		{
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt != 11 || EventsManager.IsDone(EventsManager.EventType.Renegotiation))
			{
				variable = DialogueLua.GetVariable("MainProgress");
				if (((Result)(ref variable)).asInt == 14 && !EventsManager.IsDone(EventsManager.EventType.FishCutting))
				{
					GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline, NNDJFLDGKDL: true);
				}
				else
				{
					GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, sendOnline);
				}
				return;
			}
		}
		GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline);
	}

	private void HLLCOCEAGHK()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(JDFDLEEELFH));
	}

	public void LAPOFFKPCEM()
	{
		ShopUI.JCBPABNCBPI(EKDNJDJHONF().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static KujakuNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	private void CGONFNBEOHF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!playerCanInteract)
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	public void FNJODLOADKA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EKDNJDJHONF().dialogueEvent))
		{
			NEFIEJALANL().barkDialogue = false;
			MAAAKALBBEE().mouseUpTrigger = false;
			LANAINBEMCM().StartConversation(0, BADFKMEJOKE().dialogueEvent);
			DEGPIHEEFHJ().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void PLHEHGHFCJI()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(IPFECOIDGAE));
	}

	public void BPDPPBDHJEL(string emotion)
	{
		DEGPIHEEFHJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void FPKLJCGJBPL(string emotion)
	{
		MAAAKALBBEE().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static KujakuNPC BADFKMEJOKE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KujakuNPC NEFIEJALANL()
	{
		return IADEMLIIDPC;
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("LE_14");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsActive(EventsManager.EventType.Precision) && !EventsManager.IsActive(EventsManager.EventType.FishCutting))
		{
			dialogue.conversation = "City/Kujaku/Introduce";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.KujakuShop))
		{
			dialogue.conversation = "UnNuevoMaestro/KujakuTalk";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.Renegotiation))
		{
			dialogue.conversation = "Renegociando/MainEvent";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.Precision))
		{
			dialogue.conversation = "Precision/MainEvent";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.FishCutting))
		{
			dialogue.conversation = "FishCuttingEvent/RetryTalk";
		}
		else
		{
			dialogue.conversation = "City/Kujaku/Stand";
		}
	}

	public void GALGBBBBGLB()
	{
		ShopUI.AGNKKAPMHLN(NEFIEJALANL().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(LANAINBEMCM().EHHOHCPHAAO).OpenUI();
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.FNNPPBDFBCI(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
			walkTo.PEHELKCIECB();
		}
	}

	private void JDFDLEEELFH()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void KDBJHCAEGCM()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(HLLCOCEAGHK));
	}

	public void GBDMLNGDHFP()
	{
		ShopUI.AGNKKAPMHLN(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void ONMNKLPNCAH(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static KujakuNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	public void KIOMHEIDHFN(string emotion)
	{
		MAAAKALBBEE().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void DIKPOHPGNLG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	private void EILPPGGCANE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MLACFFDPKPA(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void MLACFFDPKPA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.CGFMBJFGLAG(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(EBLFKBEMCKL));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EILPPGGCANE));
			walkTo.EHDKLBLKBEO();
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	protected override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (((Component)this).transform.position.x <= -531f && ((Component)this).transform.position.x >= -532f && ((Component)this).transform.position.y >= 99f && ((Component)this).transform.position.y <= 100f)
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

	public void LAANEEHHDLL(string emotion)
	{
		BADFKMEJOKE().emotionsController.GPLECKGJFKM(emotion);
	}

	private void OFHGMEMFGCI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (inShop || EventsManager.IsActive(EventsManager.EventType.Precision) || EventsManager.IsActive(EventsManager.EventType.FishCutting))
		{
			base.OnHover(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void EOGHJNGJFID()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void CFHOODNCOLK()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
	}

	[SpecialName]
	public static KujakuNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	private void BGPGIOMKKAO()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
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

	private void KADEKJKCCKM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void IPFECOIDGAE()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
	}

	public void OnActionComplete()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, GGFJGHHHEJC.dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void LHEHNNJGINH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		POCIILOJOJD(targetWalkTo, endWalkDirection);
	}

	public void KPHMPFCPGGI()
	{
		ShopUI.AGNKKAPMHLN(EKDNJDJHONF().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(MAAAKALBBEE().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void LCGCIOGIMHE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public void EBLFKBEMCKL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(NEFIEJALANL().dialogueEvent))
		{
			LANAINBEMCM().barkDialogue = false;
			DEGPIHEEFHJ().mouseUpTrigger = false;
			DEGPIHEEFHJ().StartConversation(0, GGFJGHHHEJC.dialogueEvent);
			EKDNJDJHONF().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void KBCKFDDDEGE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(LANAINBEMCM().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			MAAAKALBBEE().mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, NEFIEJALANL().dialogueEvent);
			BADFKMEJOKE().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void AHECKLFEFAB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		POCIILOJOJD(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}
}
