using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TheloniusNPC : DialogueNPCBase
{
	private static TheloniusNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_22";

	public static TheloniusNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void JAKFFLNLLDO(int num)
	{
		CastleFormEvent.instance.LCIMAAEEDCI(num);
	}

	public void KHCNNNJAMPL()
	{
	}

	[SpecialName]
	public static TheloniusNPC MIGKKKELOJO()
	{
		return IADEMLIIDPC;
	}

	public void PPLOLMEJAOA(int num)
	{
		CastleFormEvent.instance.GMNLPOLMCHB(num);
	}

	[SpecialName]
	public static TheloniusNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	public void BLJCLIIFJBM()
	{
	}

	[SpecialName]
	public static TheloniusNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		for (int i = 0; i < SceneReferences.instance.interactableForms.Length; i++)
		{
			if (!SceneReferences.instance.interactableForms[i].ICNNAEDJNLH)
			{
				return false;
			}
		}
		if (base.MouseUp(JIIGOACEIKL))
		{
			return true;
		}
		return false;
	}

	public void OGEMNLDNDBM(string emotion)
	{
		if (Object.op_Implicit((Object)(object)LDBJELPPBAI().emotionsController))
		{
			OFLELHKKNKC().emotionsController.EMMBEAHMDHE(emotion);
		}
	}

	[SpecialName]
	public static TheloniusNPC FMIDAFEGDCD()
	{
		return IADEMLIIDPC;
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		for (int i = 0; i < SceneReferences.instance.interactableForms.Length; i++)
		{
			if (!SceneReferences.instance.interactableForms[i].ICNNAEDJNLH)
			{
				return false;
			}
		}
		base.OnHover(JIIGOACEIKL);
		return true;
	}

	public void FJPJHODBNIJ()
	{
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void StartKlaynEvent()
	{
		CastleFormEvent.instance.StartKlaynEvent(GGFJGHHHEJC.EHHOHCPHAAO);
	}

	[SpecialName]
	public static TheloniusNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	private void HCEDMLJNOBL()
	{
	}

	private void FOHGHCPODBJ()
	{
	}

	public void LNCFHJBJIGI()
	{
	}

	private void Start()
	{
	}

	public void NLNFIOMGEFL(int num)
	{
		CastleFormEvent.instance.FKMNAOBGOKK(num);
	}

	public void PCNELAKBGJL()
	{
		CastleFormEvent.instance.StartKlaynEvent(MIGKKKELOJO().EHHOHCPHAAO);
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (OnlineManager.PlayingOnline())
		{
			int hKKKNMIKPCM = HKKKNMIKPCM;
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (hKKKNMIKPCM != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				string hDFMHCKKJJG = HDFMHCKKJJG;
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
			}
			OnlineDialogueManager instance2 = OnlineDialogueManager.instance;
			variable = DialogueLua.GetVariable("MainProgress");
			instance2.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
		}
	}

	public void GEMGNAILBMD()
	{
		CastleFormEvent.instance.GIDCOMCPOJF(KNOKBLFFNLM().EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	public void NLJPJGNLKLG(int num)
	{
		CastleFormEvent.instance.FKMNAOBGOKK(num);
	}

	[SpecialName]
	public static TheloniusNPC LDBJELPPBAI()
	{
		return IADEMLIIDPC;
	}

	private void HBMDEHPHAPF()
	{
	}

	public void LMBPIGBFGON(int num)
	{
		CastleFormEvent.instance.FKMNAOBGOKK(num);
	}

	[SpecialName]
	public static TheloniusNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	public void CJMLIEFAPKE()
	{
	}

	public void GOKMCECOBCK()
	{
	}

	private void PFLBPMIEKGF()
	{
	}

	public void EEPJLOBNIMM()
	{
	}

	public void GGKPEJPJDIJ(int num)
	{
		CastleFormEvent.instance.LCIMAAEEDCI(num);
	}

	public void POBFFGPDKLE()
	{
	}

	public void IDFEBLBEBMP()
	{
		CastleFormEvent.instance.GIDCOMCPOJF(EKDNJDJHONF().EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	public void LKLKHKFAFKE()
	{
	}

	public void FKMNAOBGOKK(int num)
	{
		CastleFormEvent.instance.CPDHKILEGOD(num);
	}

	public void OBNBHKHHBIN()
	{
	}

	public void KKCEACEHNOF(string emotion)
	{
		if (Object.op_Implicit((Object)(object)MAAAKALBBEE().emotionsController))
		{
			FMIDAFEGDCD().emotionsController.NMAPMPBAGMM(emotion);
		}
	}

	public void MKDDJGIBPED()
	{
	}

	private void NNBIAIMPNGL()
	{
	}

	public void AKNIJKAKKFD(string emotion)
	{
		if (Object.op_Implicit((Object)(object)EKDNJDJHONF().emotionsController))
		{
			MIGKKKELOJO().emotionsController.NMAPMPBAGMM(emotion);
		}
	}

	public void FBPFHIJMPNA(int num)
	{
		CastleFormEvent.instance.KDADFKKPNEB(num);
	}

	public void BBEAKOGODAE()
	{
		CastleFormEvent.instance.FAANBCAJLPC(OFLELHKKNKC().EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	public void AALKLCMEEND()
	{
		CastleFormEvent.instance.FAHCFENECAD(FMIDAFEGDCD().EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	private void MFMMHDPGCBO()
	{
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void EFOEDOJOFEH(string emotion)
	{
		if (Object.op_Implicit((Object)(object)HFIJHDBKCIA().emotionsController))
		{
			KNOKBLFFNLM().emotionsController.DCCNJLBLFGI(emotion);
		}
	}

	public void LCLNGAAFKNB()
	{
	}

	public void KINMMMAOOBK()
	{
		CastleFormEvent.instance.ELBLLKEMIPD(FMIDAFEGDCD().EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	public void LGOFLIDPACC()
	{
		CastleFormEvent.instance.FAANBCAJLPC(GGFJGHHHEJC.EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	public void LJFLICPLPAE(string emotion)
	{
		if (Object.op_Implicit((Object)(object)KNOKBLFFNLM().emotionsController))
		{
			GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
		}
	}

	public void PAGOONNCBNA()
	{
	}

	[SpecialName]
	public static TheloniusNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	public void ODJALKALOOA(int num)
	{
		CastleFormEvent.instance.KDADFKKPNEB(num);
	}

	public void StartEmotions(string emotion)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC.emotionsController))
		{
			GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
		}
	}

	public void MOEOKMMGLNH(int num)
	{
		CastleFormEvent.instance.LCIMAAEEDCI(num);
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void ActiveForm(int num)
	{
		CastleFormEvent.instance.ActiveForm(num);
	}

	public void NJPKHMNLDPF(int num)
	{
		CastleFormEvent.instance.NLNFIOMGEFL(num);
	}

	public void LILHBLEFJMM(string emotion)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC.emotionsController))
		{
			HFIJHDBKCIA().emotionsController.DCCNJLBLFGI(emotion);
		}
	}

	private void GJMLHECPGBP()
	{
	}

	public void MCPDJHICBLA(string emotion)
	{
		if (Object.op_Implicit((Object)(object)MIGKKKELOJO().emotionsController))
		{
			EKDNJDJHONF().emotionsController.DCCNJLBLFGI(emotion);
		}
	}

	public void IFICIKEFNJJ()
	{
	}

	public void BPDPPBDHJEL(string emotion)
	{
		if (Object.op_Implicit((Object)(object)OFLELHKKNKC().emotionsController))
		{
			GGFJGHHHEJC.emotionsController.DCCNJLBLFGI(emotion);
		}
	}

	public void OLOALFLNPEB()
	{
		CastleFormEvent.instance.HFDDDNMBDCF(OFLELHKKNKC().EHHOHCPHAAO);
	}

	private void LOHAMDHOLDD()
	{
	}

	public new void CheckExclamation()
	{
	}

	public void KLBCFAINJDF(int num)
	{
		CastleFormEvent.instance.FPMJFBJHLLM(num);
	}

	public void KCHBHKPJKFB()
	{
		CastleFormEvent.instance.GIDCOMCPOJF(KNOKBLFFNLM().EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (MissionsManager.instance.IsMissionActive(302))
		{
			dialogue.conversation = "LicenciaDeApertura/TheloniousDialogue 01";
		}
		else if (MissionsManager.instance.IsMissionActive(304))
		{
			dialogue.conversation = "LicenciaDeApertura/TheloniousDialogue 02";
		}
		else if (MissionsManager.instance.IsMissionActive(306))
		{
			dialogue.conversation = "LicenciaDeApertura/TheloniousDialogue 03";
		}
		else if (MissionsManager.instance.IsMissionActive(308))
		{
			dialogue.conversation = "LicenciaDeApertura/TheloniousDialogue 04";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.CastleForm))
		{
			MissionsManager.instance.StartMission(302);
			dialogue.conversation = "LicenciaDeApertura/TheloniousDialogue 01";
		}
		else
		{
			dialogue.conversation = "Castle/Talks/Thelonious";
		}
	}

	private void EEKOJEKPIMP()
	{
	}

	public void OCMHCNKLEKB()
	{
	}

	public void HLBDGEHCMIK(int num)
	{
		CastleFormEvent.instance.FKMNAOBGOKK(num);
	}

	public void NHIKCOFEGGA()
	{
		CastleFormEvent.instance.StartKlaynEvent(LDBJELPPBAI().EHHOHCPHAAO, GFNHAMCPEAK: false);
	}

	public void FMKJKFDLNBG()
	{
	}

	public void LAANEEHHDLL(string emotion)
	{
		if (Object.op_Implicit((Object)(object)HFIJHDBKCIA().emotionsController))
		{
			MIGKKKELOJO().emotionsController.DCCNJLBLFGI(emotion);
		}
	}

	[SpecialName]
	public static TheloniusNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	public void DOANCMIFNNN(int num)
	{
		CastleFormEvent.instance.NLNFIOMGEFL(num);
	}

	public void JECGJNDCMCG()
	{
	}
}
