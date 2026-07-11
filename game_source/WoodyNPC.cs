using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class WoodyNPC : DialogueNPCBase
{
	private static WoodyNPC IADEMLIIDPC;

	public float minBarkTime;

	public float maxBarkTime;

	public float timeBarks;

	private float AELCMIGFOAK;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_16";

	public static WoodyNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void GNMMELIJKML()
	{
		NIKCFNPEDCC();
	}

	private void FJCBGBBBCFD()
	{
		switch (Random.Range(1, 1))
		{
		case 0:
			dialogue.conversation = "Sharp";
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUISawmill();
				onlineBarkDialogue = true;
			}
			break;
		case 1:
			if (((Component)OakNPC.ELGNEJNLBNO()).gameObject.activeSelf)
			{
				if (OakNPC.NEFIEJALANL().animationBase.animator.GetBool("qualityWater"))
				{
					OakNPC.OKAPNFPFPFP().dialogue.conversation = "OneShotVolume";
				}
				else if (OakNPC.NGIMIHFFNMH().animationBase.animator.GetBool("Light fuse"))
				{
					OakNPC.CMIHGBHPLFP().dialogue.conversation = "Near";
				}
				else
				{
					OakNPC.MAIDHAPANEB().dialogue.conversation = " ";
				}
				KNEHCFHGDFC();
				OakNPC.DICHPHEOINO().main = true;
				OakNPC.HNNJEBNIPOI().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					OakNPC.DIHCEGINELM().onlineBarkDialogue = true;
				}
			}
			break;
		case 2:
			if (((Component)AshNPC.POINNCPMEIG()).gameObject.activeSelf)
			{
				AshNPC.OLHBLKIAFOM().dialogue.conversation = "Dialogue System/Conversation/Crowly_Introduce/Entry/26/Dialogue Text";
				KNEHCFHGDFC();
				AshNPC.OMFKNGDCJFN().main = false;
				AshNPC.OOKBNHMMFON().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					AshNPC.OJJDNLEFNPJ().onlineBarkDialogue = true;
				}
			}
			break;
		case 3:
			if (((Component)WillowNPC.DIHCEGINELM()).gameObject.activeSelf)
			{
				WillowNPC.BDAGIEIJOOG().dialogue.conversation = "";
				KNEHCFHGDFC();
				WillowNPC.DIHCEGINELM().main = false;
				WillowNPC.DIHCEGINELM().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					WillowNPC.HEKFJEKFMNO().onlineBarkDialogue = true;
				}
			}
			break;
		}
	}

	public void KIKMAPEKEGK()
	{
		if (!AshNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			AshNPC.OKAPNFPFPFP().StopConversation();
		}
		if (!OakNPC.OOKBNHMMFON().inInteractiveDialogue)
		{
			OakNPC.GGFJGHHHEJC.StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			WillowNPC.GGFJGHHHEJC.StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void MKFPKPJJOCP()
	{
		if (!((Object)(object)OakNPC.GGFJGHHHEJC == (Object)null) && !((Object)(object)AshNPC.GGFJGHHHEJC == (Object)null) && !((Object)(object)WillowNPC.GGFJGHHHEJC == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.GGFJGHHHEJC.inUse && !OakNPC.GGFJGHHHEJC.inBark && OakNPC.GGFJGHHHEJC.canTalk && !AshNPC.GGFJGHHHEJC.inUse && !AshNPC.GGFJGHHHEJC.inBark && AshNPC.GGFJGHHHEJC.canTalk && !WillowNPC.GGFJGHHHEJC.inUse && !WillowNPC.GGFJGHHHEJC.inBark && WillowNPC.GGFJGHHHEJC.canTalk)
			{
				IDHKFLCNIIP();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.GGFJGHHHEJC.inUse || OakNPC.GGFJGHHHEJC.inBark || !OakNPC.GGFJGHHHEJC.canTalk || AshNPC.GGFJGHHHEJC.inUse || AshNPC.GGFJGHHHEJC.inBark || !AshNPC.GGFJGHHHEJC.canTalk || WillowNPC.GGFJGHHHEJC.inUse || WillowNPC.GGFJGHHHEJC.inBark || !WillowNPC.GGFJGHHHEJC.canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	[SpecialName]
	public static WoodyNPC KHMEGDIABBF()
	{
		return IADEMLIIDPC;
	}

	private void BMIJLNCDDNF()
	{
		if (!((Object)(object)OakNPC.ELGNEJNLBNO() == (Object)null) && !((Object)(object)AshNPC.ELGNEJNLBNO() == (Object)null) && !((Object)(object)WillowNPC.PDECKLKPKCG() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.MAIDHAPANEB().inUse && !OakNPC.ELGNEJNLBNO().inBark && OakNPC.DIHCEGINELM().canTalk && !AshNPC.MPJJAPCFENH().inUse && !AshNPC.KIALFDOKABP().inBark && AshNPC.CMIHGBHPLFP().canTalk && !WillowNPC.PDECKLKPKCG().inUse && !WillowNPC.GGFJGHHHEJC.inBark && WillowNPC.PDECKLKPKCG().canTalk)
			{
				IDHKFLCNIIP();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.LKOABOAADCD().inUse || OakNPC.OKAPNFPFPFP().inBark || !OakNPC.CMIHGBHPLFP().canTalk || AshNPC.OACNNJCLEDE().inUse || AshNPC.BNDNMBGJEKP().inBark || !AshNPC.MNFMOEKMJKN().canTalk || WillowNPC.PDECKLKPKCG().inUse || WillowNPC.GGFJGHHHEJC.inBark || !WillowNPC.DIHCEGINELM().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	private void IDHKFLCNIIP()
	{
		switch (Random.Range(0, 4))
		{
		case 0:
			dialogue.conversation = "City/Woody/Bark/Stand";
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUISawmill();
				onlineBarkDialogue = true;
			}
			break;
		case 1:
			if (((Component)OakNPC.GGFJGHHHEJC).gameObject.activeSelf)
			{
				if (OakNPC.GGFJGHHHEJC.animationBase.animator.GetBool("Pipe"))
				{
					OakNPC.GGFJGHHHEJC.dialogue.conversation = "City/Carpenters/Oak/Bark/Smoke";
				}
				else if (OakNPC.GGFJGHHHEJC.animationBase.animator.GetBool("Chisel"))
				{
					OakNPC.GGFJGHHHEJC.dialogue.conversation = "City/Carpenters/Oak/Bark/Chisel";
				}
				else
				{
					OakNPC.GGFJGHHHEJC.dialogue.conversation = "City/Carpenters/Oak/Bark/Stand";
				}
				KNEHCFHGDFC();
				OakNPC.GGFJGHHHEJC.main = true;
				OakNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.SendResetDialogueUISawmill();
					OakNPC.GGFJGHHHEJC.onlineBarkDialogue = true;
				}
			}
			break;
		case 2:
			if (((Component)AshNPC.GGFJGHHHEJC).gameObject.activeSelf)
			{
				AshNPC.GGFJGHHHEJC.dialogue.conversation = "City/Carpenters/Ash/Bark";
				KNEHCFHGDFC();
				AshNPC.GGFJGHHHEJC.main = true;
				AshNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.SendResetDialogueUISawmill();
					AshNPC.GGFJGHHHEJC.onlineBarkDialogue = true;
				}
			}
			break;
		case 3:
			if (((Component)WillowNPC.GGFJGHHHEJC).gameObject.activeSelf)
			{
				WillowNPC.GGFJGHHHEJC.dialogue.conversation = "City/Carpenters/Willow/Bark";
				KNEHCFHGDFC();
				WillowNPC.GGFJGHHHEJC.main = true;
				WillowNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.SendResetDialogueUISawmill();
					WillowNPC.GGFJGHHHEJC.onlineBarkDialogue = true;
				}
			}
			break;
		}
	}

	public void POGNPLBAJNJ()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!AshNPC.KFGKCKCDMLG().inInteractiveDialogue)
		{
			AshNPC.POINNCPMEIG().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.OKAPNFPFPFP().inInteractiveDialogue)
		{
			OakNPC.DIHCEGINELM().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.BDAGIEIJOOG().inInteractiveDialogue)
		{
			WillowNPC.GGFJGHHHEJC.StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void NDCKDKHNJLE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("shakeTrigger");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void EICNDMGMPLE(string emotion)
	{
		MMLBHCGFMMJ().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void NPDIHCNECMB()
	{
		ShopUI.EPKNOMLADCL(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(CFHEJAGKIII().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void PKINFPDGLNN()
	{
		if (!((Object)(object)OakNPC.HNNJEBNIPOI() == (Object)null) && !((Object)(object)AshNPC.LPFNKEOJJKE() == (Object)null) && !((Object)(object)WillowNPC.BDAGIEIJOOG() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.MPFJOKOJIOO().inUse && !OakNPC.ELGNEJNLBNO().inBark && OakNPC.MPFJOKOJIOO().canTalk && !AshNPC.ABHIDHPMLLD().inUse && !AshNPC.OMFKNGDCJFN().inBark && AshNPC.OOKBNHMMFON().canTalk && !WillowNPC.PDECKLKPKCG().inUse && !WillowNPC.PDECKLKPKCG().inBark && WillowNPC.DIHCEGINELM().canTalk)
			{
				FJCBGBBBCFD();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.ELGNEJNLBNO().inUse || OakNPC.DIHCEGINELM().inBark || !OakNPC.NGIMIHFFNMH().canTalk || AshNPC.MPJJAPCFENH().inUse || AshNPC.KIALFDOKABP().inBark || !AshNPC.MMLBHCGFMMJ().canTalk || WillowNPC.DIHCEGINELM().inUse || WillowNPC.DIHCEGINELM().inBark || !WillowNPC.BDAGIEIJOOG().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static WoodyNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	public void OAGPGKGOCCO()
	{
		ShopUI.Get(BDAGIEIJOOG().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(EBAIHKJHCCA().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (base.MouseUp(JIIGOACEIKL))
		{
			StopOtherDialogues();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(3);
			}
			return true;
		}
		return false;
	}

	public void KKCEACEHNOF(string emotion)
	{
		MAIDHAPANEB().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void ADAPAMDCNEH()
	{
		ShopUI.IEKODILKIHJ(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(MMLBHCGFMMJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void GFBPIJMBNNF()
	{
		ShopUI.IEKODILKIHJ(MMLBHCGFMMJ().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(ABHIDHPMLLD().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void ALJAPDBHANO(string emotion)
	{
		BDAGIEIJOOG().emotionsController.GPLECKGJFKM(emotion);
	}

	public void StopOtherDialogues()
	{
		if (!AshNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			AshNPC.GGFJGHHHEJC.StopConversation();
		}
		if (!OakNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			OakNPC.GGFJGHHHEJC.StopConversation();
		}
		if (!WillowNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			WillowNPC.GGFJGHHHEJC.StopConversation();
		}
	}

	private void LJLKBKEADGI()
	{
		EEPJLOBNIMM();
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

	[SpecialName]
	public static WoodyNPC MMLBHCGFMMJ()
	{
		return IADEMLIIDPC;
	}

	public void JAJGMGJHKLG()
	{
		ShopUI.IEKODILKIHJ(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(MAIDHAPANEB().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void DPMJEBCBBBJ()
	{
		if (!AshNPC.BNDNMBGJEKP().inInteractiveDialogue)
		{
			AshNPC.MKIEMMGGFEE().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.NEFIEJALANL().inInteractiveDialogue)
		{
			OakNPC.DIHCEGINELM().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			WillowNPC.HEKFJEKFMNO().StopConversation();
		}
	}

	public void INMEJCEENHN()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!AshNPC.ILMPOAEALPP().inInteractiveDialogue)
		{
			AshNPC.ELGNEJNLBNO().StopConversation();
		}
		if (!OakNPC.ECGIAEFKKNA().inInteractiveDialogue)
		{
			OakNPC.MLPCDJPLBAC().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.PDECKLKPKCG().inInteractiveDialogue)
		{
			WillowNPC.BDAGIEIJOOG().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void HEHNBONKMGJ()
	{
		NDCKDKHNJLE();
	}

	public void EEPJLOBNIMM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("gold");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void NAFIFNLEPPK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Reputation increased by ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void DOCHPOEOOAL(string emotion)
	{
		HFIJHDBKCIA().emotionsController.StartEmotion(emotion);
	}

	public void LEMJPOBAJPO()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void DMFMNEMDFNP()
	{
		FMKJKFDLNBG();
	}

	public void GOBNAPEHHNC()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!AshNPC.JEEGOBGDLPE().inInteractiveDialogue)
		{
			AshNPC.EJECEDMPCOH().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.NGIMIHFFNMH().inInteractiveDialogue)
		{
			OakNPC.LKOABOAADCD().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			WillowNPC.PDECKLKPKCG().StopConversation();
		}
	}

	private void JGLKKKNKPBH()
	{
		if (!((Object)(object)OakNPC.GGFJGHHHEJC == (Object)null) && !((Object)(object)AshNPC.LKDJNKLJKGO() == (Object)null) && !((Object)(object)WillowNPC.BDAGIEIJOOG() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.HNNJEBNIPOI().inUse && !OakNPC.MLPCDJPLBAC().inBark && OakNPC.OKAPNFPFPFP().canTalk && !AshNPC.MJCMPKPCNGB().inUse && !AshNPC.LKDJNKLJKGO().inBark && AshNPC.HEKFJEKFMNO().canTalk && !WillowNPC.PDECKLKPKCG().inUse && !WillowNPC.HEKFJEKFMNO().inBark && WillowNPC.PDECKLKPKCG().canTalk)
			{
				HDLAJLIDHKM();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.ELGNEJNLBNO().inUse || OakNPC.DIHCEGINELM().inBark || !OakNPC.ECGIAEFKKNA().canTalk || AshNPC.KIALFDOKABP().inUse || AshNPC.HEKFJEKFMNO().inBark || !AshNPC.BADFKMEJOKE().canTalk || WillowNPC.GGFJGHHHEJC.inUse || WillowNPC.BDAGIEIJOOG().inBark || !WillowNPC.PDECKLKPKCG().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void IBDHCOEBDPF(string emotion)
	{
		ABHIDHPMLLD().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EIIHNJOICPE()
	{
		if (!AshNPC.OMFKNGDCJFN().inInteractiveDialogue)
		{
			AshNPC.MNFMOEKMJKN().StopConversation();
		}
		if (!OakNPC.ABDJJBFNLBJ().inInteractiveDialogue)
		{
			OakNPC.NGIMIHFFNMH().StopConversation();
		}
		if (!WillowNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			WillowNPC.BDAGIEIJOOG().StopConversation();
		}
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("LE_16");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			dialogue.conversation = "City/Woody/Introduce";
		}
		else
		{
			dialogue.conversation = "City/Woody/Stand";
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void LHFENGJLJMD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/3/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void BKILDJBIIHL(string emotion)
	{
		ABHIDHPMLLD().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void MCMKNBIBDFF()
	{
		FABLJFLFDJA();
	}

	public void IHFOJNJAALB(string emotion)
	{
		ABHIDHPMLLD().emotionsController.GPLECKGJFKM(emotion);
	}

	public void DJAIJKLCGOF()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!AshNPC.OMFKNGDCJFN().inInteractiveDialogue)
		{
			AshNPC.MPFJOKOJIOO().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.ABDJJBFNLBJ().inInteractiveDialogue)
		{
			OakNPC.OOKBNHMMFON().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			WillowNPC.GGFJGHHHEJC.StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void BDMEBLBLPIA()
	{
		FJPJHODBNIJ();
	}

	public void NJDPHEIJDGD()
	{
		ShopUI.IEABDMDELFO(MAIDHAPANEB().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(BDAGIEIJOOG().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void LPBNFCCLOPM()
	{
		switch (Random.Range(0, 3))
		{
		case 0:
			dialogue.conversation = "repUnlockFarmCarp";
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendResetDialogueUISawmill();
				onlineBarkDialogue = true;
			}
			break;
		case 1:
			if (((Component)OakNPC.OJJDNLEFNPJ()).gameObject.activeSelf)
			{
				if (OakNPC.MAIDHAPANEB().animationBase.animator.GetBool("\n"))
				{
					OakNPC.ELGNEJNLBNO().dialogue.conversation = " name";
				}
				else if (OakNPC.OOKBNHMMFON().animationBase.animator.GetBool("ReceiveHit"))
				{
					OakNPC.OMFKNGDCJFN().dialogue.conversation = " ";
				}
				else
				{
					OakNPC.ABDJJBFNLBJ().dialogue.conversation = "AddToSurface ";
				}
				KNEHCFHGDFC();
				OakNPC.MPFJOKOJIOO().main = true;
				OakNPC.ABDJJBFNLBJ().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.SendResetDialogueUISawmill();
					OakNPC.MPFJOKOJIOO().onlineBarkDialogue = false;
				}
			}
			break;
		case 2:
			if (((Component)AshNPC.KNOKBLFFNLM()).gameObject.activeSelf)
			{
				AshNPC.POINNCPMEIG().dialogue.conversation = " ";
				KNEHCFHGDFC();
				AshNPC.OLHBLKIAFOM().main = true;
				AshNPC.KFGKCKCDMLG().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					AshNPC.OLHBLKIAFOM().onlineBarkDialogue = true;
				}
			}
			break;
		case 3:
			if (((Component)WillowNPC.BDAGIEIJOOG()).gameObject.activeSelf)
			{
				WillowNPC.PDECKLKPKCG().dialogue.conversation = "Items/item_description_1123";
				KNEHCFHGDFC();
				WillowNPC.PDECKLKPKCG().main = false;
				WillowNPC.PDECKLKPKCG().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					WillowNPC.PDECKLKPKCG().onlineBarkDialogue = true;
				}
			}
			break;
		}
	}

	public void FMKJKFDLNBG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("NormalLeftExterior");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	[SpecialName]
	public static WoodyNPC CFHEJAGKIII()
	{
		return IADEMLIIDPC;
	}

	public void NIKCFNPEDCC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("???");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void LJKJDIJFJPL()
	{
		if (!((Object)(object)OakNPC.LKOABOAADCD() == (Object)null) && !((Object)(object)AshNPC.DHDOLCONMFJ() == (Object)null) && !((Object)(object)WillowNPC.GGFJGHHHEJC == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.OJJDNLEFNPJ().inUse && !OakNPC.HNNJEBNIPOI().inBark && OakNPC.OMFKNGDCJFN().canTalk && !AshNPC.LANAINBEMCM().inUse && !AshNPC.AAFOFNEHPLC().inBark && AshNPC.KIALFDOKABP().canTalk && !WillowNPC.DIHCEGINELM().inUse && !WillowNPC.HEKFJEKFMNO().inBark && WillowNPC.PDECKLKPKCG().canTalk)
			{
				FJCBGBBBCFD();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.MLPCDJPLBAC().inUse || OakNPC.MPFJOKOJIOO().inBark || !OakNPC.DIHCEGINELM().canTalk || AshNPC.OMFKNGDCJFN().inUse || AshNPC.DHDOLCONMFJ().inBark || !AshNPC.MNFMOEKMJKN().canTalk || WillowNPC.HEKFJEKFMNO().inUse || WillowNPC.DIHCEGINELM().inBark || !WillowNPC.DIHCEGINELM().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	private void IABEJCPMJOF()
	{
		NAFIFNLEPPK();
	}

	private void HFFFFAJFIPB()
	{
		NIKCFNPEDCC();
	}

	public void OGBOFKLCNGL()
	{
		if (!AshNPC.AAFOFNEHPLC().inInteractiveDialogue)
		{
			AshNPC.MOJDNGDNCCO().StopConversation();
		}
		if (!OakNPC.ELGNEJNLBNO().inInteractiveDialogue)
		{
			OakNPC.ABDJJBFNLBJ().StopConversation();
		}
		if (!WillowNPC.BDAGIEIJOOG().inInteractiveDialogue)
		{
			WillowNPC.BDAGIEIJOOG().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void BGFCHEIOKOG()
	{
		LHFENGJLJMD();
	}

	public void CJFCMOBFFNF(string emotion)
	{
		BDAGIEIJOOG().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void LJFLICPLPAE(string emotion)
	{
		BDAGIEIJOOG().emotionsController.StartEmotion(emotion);
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

	public void PGFPIOGKHJE(string emotion)
	{
		EBAIHKJHCCA().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void FJPJHODBNIJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Cheer");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void DLIKPDHJOEA()
	{
		if (!((Object)(object)OakNPC.OKAPNFPFPFP() == (Object)null) && !((Object)(object)AshNPC.ILMPOAEALPP() == (Object)null) && !((Object)(object)WillowNPC.HEKFJEKFMNO() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.GGFJGHHHEJC.inUse && !OakNPC.GGFJGHHHEJC.inBark && OakNPC.NGIMIHFFNMH().canTalk && !AshNPC.BADFKMEJOKE().inUse && !AshNPC.JEEGOBGDLPE().inBark && AshNPC.JEEGOBGDLPE().canTalk && !WillowNPC.PDECKLKPKCG().inUse && !WillowNPC.BDAGIEIJOOG().inBark && WillowNPC.HEKFJEKFMNO().canTalk)
			{
				HDLAJLIDHKM();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.DIHCEGINELM().inUse || OakNPC.OOKBNHMMFON().inBark || !OakNPC.OOKBNHMMFON().canTalk || AshNPC.ILMPOAEALPP().inUse || AshNPC.KHMEGDIABBF().inBark || !AshNPC.ILMPOAEALPP().canTalk || WillowNPC.DIHCEGINELM().inUse || WillowNPC.HEKFJEKFMNO().inBark || !WillowNPC.HEKFJEKFMNO().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	private void AHFGOOHOLEL()
	{
		FJPJHODBNIJ();
	}

	public void IODNBMPKGCG()
	{
		if (!AshNPC.KNOKBLFFNLM().inInteractiveDialogue)
		{
			AshNPC.LANAINBEMCM().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.MLPCDJPLBAC().inInteractiveDialogue)
		{
			OakNPC.OJJDNLEFNPJ().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.BDAGIEIJOOG().inInteractiveDialogue)
		{
			WillowNPC.DIHCEGINELM().StopConversation();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public void PBJCCHNHGMA()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!AshNPC.ABHIDHPMLLD().inInteractiveDialogue)
		{
			AshNPC.DGCNCEDIFOF().StopConversation();
		}
		if (!OakNPC.ECGIAEFKKNA().inInteractiveDialogue)
		{
			OakNPC.OKAPNFPFPFP().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			WillowNPC.DIHCEGINELM().StopConversation();
		}
	}

	public void AKOEOIEPJIH()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!AshNPC.DGCNCEDIFOF().inInteractiveDialogue)
		{
			AshNPC.KHMEGDIABBF().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.DIHCEGINELM().inInteractiveDialogue)
		{
			OakNPC.CMIHGBHPLFP().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			WillowNPC.BDAGIEIJOOG().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void PCHPJONNOFH()
	{
		if (!AshNPC.ABHIDHPMLLD().inInteractiveDialogue)
		{
			AshNPC.GFMBEDCANNI().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.CMIHGBHPLFP().inInteractiveDialogue)
		{
			OakNPC.OOKBNHMMFON().StopConversation();
		}
		if (!WillowNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			WillowNPC.GGFJGHHHEJC.StopConversation();
		}
	}

	[SpecialName]
	public static WoodyNPC ACPHFLBLJAA()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static WoodyNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void EJDPBEOHOFM()
	{
		ShopUI.NALKHGMLALJ(CFHEJAGKIII().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(MAIDHAPANEB().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void ACJPLCCDCHJ()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!AshNPC.KHMEGDIABBF().inInteractiveDialogue)
		{
			AshNPC.MMLBHCGFMMJ().StopConversation();
		}
		if (!OakNPC.HNNJEBNIPOI().inInteractiveDialogue)
		{
			OakNPC.OMFKNGDCJFN().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.HEKFJEKFMNO().inInteractiveDialogue)
		{
			WillowNPC.PDECKLKPKCG().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void BNJJBAJCBCC()
	{
		if (!((Object)(object)OakNPC.OJJDNLEFNPJ() == (Object)null) && !((Object)(object)AshNPC.JHMAMLIPBNN() == (Object)null) && !((Object)(object)WillowNPC.BDAGIEIJOOG() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.DICHPHEOINO().inUse && !OakNPC.MPFJOKOJIOO().inBark && OakNPC.HNNJEBNIPOI().canTalk && !AshNPC.MNFMOEKMJKN().inUse && !AshNPC.LKDJNKLJKGO().inBark && AshNPC.OACNNJCLEDE().canTalk && !WillowNPC.BDAGIEIJOOG().inUse && !WillowNPC.DIHCEGINELM().inBark && WillowNPC.HEKFJEKFMNO().canTalk)
			{
				LPBNFCCLOPM();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.MAIDHAPANEB().inUse || OakNPC.DIHCEGINELM().inBark || !OakNPC.NGIMIHFFNMH().canTalk || AshNPC.KHMEGDIABBF().inUse || AshNPC.BNDNMBGJEKP().inBark || !AshNPC.EJECEDMPCOH().canTalk || WillowNPC.BDAGIEIJOOG().inUse || WillowNPC.PDECKLKPKCG().inBark || !WillowNPC.BDAGIEIJOOG().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public void ALMHNMBHEPP()
	{
		ShopUI.JCBPABNCBPI(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(CFHEJAGKIII().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void IOKILGMHFNE(string emotion)
	{
		GGFJGHHHEJC.emotionsController.EMMBEAHMDHE(emotion);
	}

	private void PFPGLFMHHOA()
	{
		if (!((Object)(object)OakNPC.NEFIEJALANL() == (Object)null) && !((Object)(object)AshNPC.BNDNMBGJEKP() == (Object)null) && !((Object)(object)WillowNPC.BDAGIEIJOOG() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.OKAPNFPFPFP().inUse && !OakNPC.ECGIAEFKKNA().inBark && OakNPC.DICHPHEOINO().canTalk && !AshNPC.ABHIDHPMLLD().inUse && !AshNPC.DGCNCEDIFOF().inBark && AshNPC.KHMEGDIABBF().canTalk && !WillowNPC.GGFJGHHHEJC.inUse && !WillowNPC.HEKFJEKFMNO().inBark && WillowNPC.HEKFJEKFMNO().canTalk)
			{
				IDHKFLCNIIP();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.OJJDNLEFNPJ().inUse || OakNPC.ELGNEJNLBNO().inBark || !OakNPC.DIHCEGINELM().canTalk || AshNPC.OOKBNHMMFON().inUse || AshNPC.MPFJOKOJIOO().inBark || !AshNPC.MKIEMMGGFEE().canTalk || WillowNPC.BDAGIEIJOOG().inUse || WillowNPC.DIHCEGINELM().inBark || !WillowNPC.PDECKLKPKCG().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	private void FEHHPFJLBPP()
	{
		if (!((Object)(object)OakNPC.DIHCEGINELM() == (Object)null) && !((Object)(object)AshNPC.CMIHGBHPLFP() == (Object)null) && !((Object)(object)WillowNPC.GGFJGHHHEJC == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.GGFJGHHHEJC.inUse && !OakNPC.DICHPHEOINO().inBark && OakNPC.ECGIAEFKKNA().canTalk && !AshNPC.BNDNMBGJEKP().inUse && !AshNPC.OMFKNGDCJFN().inBark && AshNPC.AAFOFNEHPLC().canTalk && !WillowNPC.GGFJGHHHEJC.inUse && !WillowNPC.PDECKLKPKCG().inBark && WillowNPC.DIHCEGINELM().canTalk)
			{
				IPJOMINLGKO();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.NGIMIHFFNMH().inUse || OakNPC.NGIMIHFFNMH().inBark || !OakNPC.NGIMIHFFNMH().canTalk || AshNPC.KHMEGDIABBF().inUse || AshNPC.EKDNJDJHONF().inBark || !AshNPC.KFGKCKCDMLG().canTalk || WillowNPC.HEKFJEKFMNO().inUse || WillowNPC.GGFJGHHHEJC.inBark || !WillowNPC.HEKFJEKFMNO().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_16");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void HIACOEFHIFJ()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!AshNPC.LPFNKEOJJKE().inInteractiveDialogue)
		{
			AshNPC.KIALFDOKABP().StopConversation();
		}
		if (!OakNPC.DIHCEGINELM().inInteractiveDialogue)
		{
			OakNPC.GGFJGHHHEJC.StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.DIHCEGINELM().inInteractiveDialogue)
		{
			WillowNPC.BDAGIEIJOOG().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void CFJNIKJFCPE(string emotion)
	{
		ABHIDHPMLLD().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void StopAllDialogues()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!AshNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			AshNPC.GGFJGHHHEJC.StopConversation();
		}
		if (!OakNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			OakNPC.GGFJGHHHEJC.StopConversation();
		}
		if (!WillowNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			WillowNPC.GGFJGHHHEJC.StopConversation();
		}
	}

	public void JGKGLNEJINE()
	{
		if (!AshNPC.EJECEDMPCOH().inInteractiveDialogue)
		{
			AshNPC.MNFMOEKMJKN().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.MLPCDJPLBAC().inInteractiveDialogue)
		{
			OakNPC.HNNJEBNIPOI().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.BDAGIEIJOOG().inInteractiveDialogue)
		{
			WillowNPC.HEKFJEKFMNO().StopConversation();
		}
	}

	private void IGIKNCOLCKL()
	{
		FJPJHODBNIJ();
	}

	private void HDLAJLIDHKM()
	{
		switch (Random.Range(1, 0))
		{
		case 0:
			dialogue.conversation = "";
			KNEHCFHGDFC();
			main = false;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.KLEHMFNDKPH();
				onlineBarkDialogue = true;
			}
			break;
		case 1:
			if (((Component)OakNPC.ECGIAEFKKNA()).gameObject.activeSelf)
			{
				if (OakNPC.HNNJEBNIPOI().animationBase.animator.GetBool("No keg"))
				{
					OakNPC.NGIMIHFFNMH().dialogue.conversation = "Dialogue System/Conversation/Crowly_Standar/Entry/49/Dialogue Text";
				}
				else if (OakNPC.OOKBNHMMFON().animationBase.animator.GetBool("daysLeft"))
				{
					OakNPC.LKOABOAADCD().dialogue.conversation = "\n";
				}
				else
				{
					OakNPC.ABDJJBFNLBJ().dialogue.conversation = "Hire";
				}
				KNEHCFHGDFC();
				OakNPC.DIHCEGINELM().main = true;
				OakNPC.HNNJEBNIPOI().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.SendResetDialogueUISawmill();
					OakNPC.ABDJJBFNLBJ().onlineBarkDialogue = false;
				}
			}
			break;
		case 2:
			if (((Component)AshNPC.KHMEGDIABBF()).gameObject.activeSelf)
			{
				AshNPC.KNOKBLFFNLM().dialogue.conversation = " slotId: ";
				KNEHCFHGDFC();
				AshNPC.ELGNEJNLBNO().main = true;
				AshNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					AshNPC.JHMAMLIPBNN().onlineBarkDialogue = true;
				}
			}
			break;
		case 3:
			if (((Component)WillowNPC.GGFJGHHHEJC).gameObject.activeSelf)
			{
				WillowNPC.BDAGIEIJOOG().dialogue.conversation = "Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/3/Dialogue Text";
				KNEHCFHGDFC();
				WillowNPC.DIHCEGINELM().main = true;
				WillowNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					WillowNPC.DIHCEGINELM().onlineBarkDialogue = true;
				}
			}
			break;
		}
	}

	private void Start()
	{
		CheckExclamation();
	}

	private void BMEEJFOEODM()
	{
		if (!((Object)(object)OakNPC.GGFJGHHHEJC == (Object)null) && !((Object)(object)AshNPC.BADFKMEJOKE() == (Object)null) && !((Object)(object)WillowNPC.DIHCEGINELM() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.MLPCDJPLBAC().inUse && !OakNPC.OMFKNGDCJFN().inBark && OakNPC.HNNJEBNIPOI().canTalk && !AshNPC.LKDJNKLJKGO().inUse && !AshNPC.KFGKCKCDMLG().inBark && AshNPC.MMLBHCGFMMJ().canTalk && !WillowNPC.GGFJGHHHEJC.inUse && !WillowNPC.HEKFJEKFMNO().inBark && WillowNPC.DIHCEGINELM().canTalk)
			{
				HDLAJLIDHKM();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.OKAPNFPFPFP().inUse || OakNPC.CMIHGBHPLFP().inBark || !OakNPC.NGIMIHFFNMH().canTalk || AshNPC.DGCNCEDIFOF().inUse || AshNPC.ILMPOAEALPP().inBark || !AshNPC.LKDJNKLJKGO().canTalk || WillowNPC.PDECKLKPKCG().inUse || WillowNPC.HEKFJEKFMNO().inBark || !WillowNPC.HEKFJEKFMNO().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	private void MGDOFJIKLJD()
	{
		if (!((Object)(object)OakNPC.NEFIEJALANL() == (Object)null) && !((Object)(object)AshNPC.MOJDNGDNCCO() == (Object)null) && !((Object)(object)WillowNPC.HEKFJEKFMNO() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.NGIMIHFFNMH().inUse && !OakNPC.OMFKNGDCJFN().inBark && OakNPC.HNNJEBNIPOI().canTalk && !AshNPC.KIALFDOKABP().inUse && !AshNPC.KFGKCKCDMLG().inBark && AshNPC.CMIHGBHPLFP().canTalk && !WillowNPC.DIHCEGINELM().inUse && !WillowNPC.BDAGIEIJOOG().inBark && WillowNPC.DIHCEGINELM().canTalk)
			{
				LPBNFCCLOPM();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.ECGIAEFKKNA().inUse || OakNPC.OKAPNFPFPFP().inBark || !OakNPC.OMFKNGDCJFN().canTalk || AshNPC.JHMAMLIPBNN().inUse || AshNPC.MMLBHCGFMMJ().inBark || !AshNPC.EJECEDMPCOH().canTalk || WillowNPC.PDECKLKPKCG().inUse || WillowNPC.HEKFJEKFMNO().inBark || !WillowNPC.HEKFJEKFMNO().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	[SpecialName]
	public static WoodyNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	public void LFAPOMEEBJI()
	{
		ShopUI.JCBPABNCBPI(KHMEGDIABBF().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(MMLBHCGFMMJ().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void HMEFIIDEMOL(string emotion)
	{
		MAIDHAPANEB().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void IAFBFHALBJH(string emotion)
	{
		ABHIDHPMLLD().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void GOLGBIFLEDM(string emotion)
	{
		ABHIDHPMLLD().emotionsController.StartEmotion(emotion);
	}

	private void CLPFAHMINAF()
	{
		if (!((Object)(object)OakNPC.ECGIAEFKKNA() == (Object)null) && !((Object)(object)AshNPC.JHMAMLIPBNN() == (Object)null) && !((Object)(object)WillowNPC.GGFJGHHHEJC == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.ABDJJBFNLBJ().inUse && !OakNPC.LKOABOAADCD().inBark && OakNPC.NGIMIHFFNMH().canTalk && !AshNPC.ABHIDHPMLLD().inUse && !AshNPC.MJCMPKPCNGB().inBark && AshNPC.ABHIDHPMLLD().canTalk && !WillowNPC.HEKFJEKFMNO().inUse && !WillowNPC.HEKFJEKFMNO().inBark && WillowNPC.HEKFJEKFMNO().canTalk)
			{
				FJCBGBBBCFD();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.OKAPNFPFPFP().inUse || OakNPC.MPFJOKOJIOO().inBark || !OakNPC.MAIDHAPANEB().canTalk || AshNPC.OKAPNFPFPFP().inUse || AshNPC.KIALFDOKABP().inBark || !AshNPC.BADFKMEJOKE().canTalk || WillowNPC.GGFJGHHHEJC.inUse || WillowNPC.PDECKLKPKCG().inBark || !WillowNPC.GGFJGHHHEJC.canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public void JADFBPHNOFD()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!AshNPC.KNOKBLFFNLM().inInteractiveDialogue)
		{
			AshNPC.OJJDNLEFNPJ().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.ABDJJBFNLBJ().inInteractiveDialogue)
		{
			OakNPC.NEFIEJALANL().StopConversation();
		}
		if (!WillowNPC.PDECKLKPKCG().inInteractiveDialogue)
		{
			WillowNPC.PDECKLKPKCG().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void OIAHJHNPPCO()
	{
		FJPJHODBNIJ();
	}

	private void CGDGOOEPPJP()
	{
		if (!((Object)(object)OakNPC.LKOABOAADCD() == (Object)null) && !((Object)(object)AshNPC.MOJDNGDNCCO() == (Object)null) && !((Object)(object)WillowNPC.BDAGIEIJOOG() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.MPFJOKOJIOO().inUse && !OakNPC.HNNJEBNIPOI().inBark && OakNPC.CMIHGBHPLFP().canTalk && !AshNPC.AAFOFNEHPLC().inUse && !AshNPC.DGCNCEDIFOF().inBark && AshNPC.BADFKMEJOKE().canTalk && !WillowNPC.DIHCEGINELM().inUse && !WillowNPC.HEKFJEKFMNO().inBark && WillowNPC.GGFJGHHHEJC.canTalk)
			{
				FJCBGBBBCFD();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.OJJDNLEFNPJ().inUse || OakNPC.DICHPHEOINO().inBark || !OakNPC.GGFJGHHHEJC.canTalk || AshNPC.OMFKNGDCJFN().inUse || AshNPC.AAFOFNEHPLC().inBark || !AshNPC.CMIHGBHPLFP().canTalk || WillowNPC.GGFJGHHHEJC.inUse || WillowNPC.GGFJGHHHEJC.inBark || !WillowNPC.PDECKLKPKCG().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public void KGAOAEMLKLC()
	{
		if (!AshNPC.OJJDNLEFNPJ().inInteractiveDialogue)
		{
			AshNPC.KIALFDOKABP().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!OakNPC.MPFJOKOJIOO().inInteractiveDialogue)
		{
			OakNPC.MPFJOKOJIOO().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!WillowNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			WillowNPC.HEKFJEKFMNO().StopConversation();
		}
	}

	protected override void KNEHCFHGDFC()
	{
		barkDialogue = true;
		GGFJGHHHEJC.SelectDialogueUI();
		OakNPC.GGFJGHHHEJC.barkDialogue = true;
		OakNPC.GGFJGHHHEJC.SelectDialogueUI();
		AshNPC.GGFJGHHHEJC.barkDialogue = true;
		AshNPC.GGFJGHHHEJC.SelectDialogueUI();
		WillowNPC.GGFJGHHHEJC.barkDialogue = true;
		WillowNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	private void BOIEMKFMKFA()
	{
		if (!((Object)(object)OakNPC.NGIMIHFFNMH() == (Object)null) && !((Object)(object)AshNPC.EJECEDMPCOH() == (Object)null) && !((Object)(object)WillowNPC.DIHCEGINELM() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.LKOABOAADCD().inUse && !OakNPC.OMFKNGDCJFN().inBark && OakNPC.OOKBNHMMFON().canTalk && !AshNPC.HNNJEBNIPOI().inUse && !AshNPC.MKIEMMGGFEE().inBark && AshNPC.LPFNKEOJJKE().canTalk && !WillowNPC.DIHCEGINELM().inUse && !WillowNPC.BDAGIEIJOOG().inBark && WillowNPC.DIHCEGINELM().canTalk)
			{
				FJCBGBBBCFD();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.ECGIAEFKKNA().inUse || OakNPC.MLPCDJPLBAC().inBark || !OakNPC.MLPCDJPLBAC().canTalk || AshNPC.HNNJEBNIPOI().inUse || AshNPC.MPFJOKOJIOO().inBark || !AshNPC.KHMEGDIABBF().canTalk || WillowNPC.PDECKLKPKCG().inUse || WillowNPC.HEKFJEKFMNO().inBark || !WillowNPC.HEKFJEKFMNO().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	[SpecialName]
	public static WoodyNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	private void IAAGKLPMAMK()
	{
		FMKJKFDLNBG();
	}

	public void FABLJFLFDJA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Standar/Entry/6/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void IMPAEIJJJCH()
	{
		if (!AshNPC.LANAINBEMCM().inInteractiveDialogue)
		{
			AshNPC.AAFOFNEHPLC().StopConversation();
		}
		if (!OakNPC.DIHCEGINELM().inInteractiveDialogue)
		{
			OakNPC.DICHPHEOINO().StopConversation();
		}
		if (!WillowNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			WillowNPC.DIHCEGINELM().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void IPJOMINLGKO()
	{
		switch (Random.Range(0, 3))
		{
		case 0:
			dialogue.conversation = "Pirates/Chum/Talk";
			KNEHCFHGDFC();
			main = false;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.KLEHMFNDKPH();
				onlineBarkDialogue = false;
			}
			break;
		case 1:
			if (((Component)OakNPC.ABDJJBFNLBJ()).gameObject.activeSelf)
			{
				if (OakNPC.MAIDHAPANEB().animationBase.animator.GetBool("itemAromaHopsSeeds"))
				{
					OakNPC.OOKBNHMMFON().dialogue.conversation = "Mission with id ";
				}
				else if (OakNPC.GGFJGHHHEJC.animationBase.animator.GetBool("1"))
				{
					OakNPC.ABDJJBFNLBJ().dialogue.conversation = "Items/item_description_1095";
				}
				else
				{
					OakNPC.LKOABOAADCD().dialogue.conversation = "]";
				}
				KNEHCFHGDFC();
				OakNPC.NEFIEJALANL().main = false;
				OakNPC.MPFJOKOJIOO().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					OakNPC.LKOABOAADCD().onlineBarkDialogue = false;
				}
			}
			break;
		case 2:
			if (((Component)AshNPC.MOJDNGDNCCO()).gameObject.activeSelf)
			{
				AshNPC.MKIEMMGGFEE().dialogue.conversation = ":</color> <sprite name=\"ChristmasTicket\">";
				KNEHCFHGDFC();
				AshNPC.LANAINBEMCM().main = true;
				AshNPC.MPFJOKOJIOO().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					AshNPC.MPJJAPCFENH().onlineBarkDialogue = false;
				}
			}
			break;
		case 3:
			if (((Component)WillowNPC.HEKFJEKFMNO()).gameObject.activeSelf)
			{
				WillowNPC.BDAGIEIJOOG().dialogue.conversation = "Fortitude/MainEvent 6";
				KNEHCFHGDFC();
				WillowNPC.PDECKLKPKCG().main = false;
				WillowNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					onlineDialogue.KLEHMFNDKPH();
					WillowNPC.BDAGIEIJOOG().onlineBarkDialogue = true;
				}
			}
			break;
		}
	}

	private void PFLBPMIEKGF()
	{
		FABLJFLFDJA();
	}

	[SpecialName]
	public static WoodyNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	private void FDADCNCPGMK()
	{
		if (!((Object)(object)OakNPC.DICHPHEOINO() == (Object)null) && !((Object)(object)AshNPC.OLHBLKIAFOM() == (Object)null) && !((Object)(object)WillowNPC.HEKFJEKFMNO() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.ELGNEJNLBNO().inUse && !OakNPC.MPFJOKOJIOO().inBark && OakNPC.MAIDHAPANEB().canTalk && !AshNPC.AAFOFNEHPLC().inUse && !AshNPC.LPFNKEOJJKE().inBark && AshNPC.HEKFJEKFMNO().canTalk && !WillowNPC.PDECKLKPKCG().inUse && !WillowNPC.BDAGIEIJOOG().inBark && WillowNPC.DIHCEGINELM().canTalk)
			{
				FJCBGBBBCFD();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.NGIMIHFFNMH().inUse || OakNPC.MPFJOKOJIOO().inBark || !OakNPC.MAIDHAPANEB().canTalk || AshNPC.GFMBEDCANNI().inUse || AshNPC.JHMAMLIPBNN().inBark || !AshNPC.CMIHGBHPLFP().canTalk || WillowNPC.HEKFJEKFMNO().inUse || WillowNPC.BDAGIEIJOOG().inBark || !WillowNPC.PDECKLKPKCG().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public void OJKEDMIKKCE(string emotion)
	{
		ACPHFLBLJAA().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void DDCIFKOCKEB()
	{
		if (!((Object)(object)OakNPC.DIHCEGINELM() == (Object)null) && !((Object)(object)AshNPC.MMLBHCGFMMJ() == (Object)null) && !((Object)(object)WillowNPC.DIHCEGINELM() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !OakNPC.OMFKNGDCJFN().inUse && !OakNPC.ABDJJBFNLBJ().inBark && OakNPC.OMFKNGDCJFN().canTalk && !AshNPC.MJCMPKPCNGB().inUse && !AshNPC.KHMEGDIABBF().inBark && AshNPC.OOKBNHMMFON().canTalk && !WillowNPC.GGFJGHHHEJC.inUse && !WillowNPC.PDECKLKPKCG().inBark && WillowNPC.PDECKLKPKCG().canTalk)
			{
				FJCBGBBBCFD();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || !canTalk || OakNPC.ABDJJBFNLBJ().inUse || OakNPC.OKAPNFPFPFP().inBark || !OakNPC.OMFKNGDCJFN().canTalk || AshNPC.BNDNMBGJEKP().inUse || AshNPC.LPFNKEOJJKE().inBark || !AshNPC.GFMBEDCANNI().canTalk || WillowNPC.BDAGIEIJOOG().inUse || WillowNPC.GGFJGHHHEJC.inBark || !WillowNPC.DIHCEGINELM().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}
}
