using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PetraNPC : DialogueNPCBase
{
	private static PetraNPC IADEMLIIDPC;

	public float minBarkTime;

	public float maxBarkTime;

	public float timeBarks;

	private float AELCMIGFOAK;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_17";

	public static PetraNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void LAANEEHHDLL(string emotion)
	{
		MPFJOKOJIOO().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void MNFMLBEJBEC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	private void HCEDMLJNOBL()
	{
		CheckExclamation();
	}

	private void IDPHKHGHJGN()
	{
		GMCLNBNFBCE();
	}

	[SpecialName]
	public static PetraNPC MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	public void FNLNPEPNEPO()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!BruceNPC.GIKECEGLFOH().inInteractiveDialogue)
		{
			BruceNPC.LKOABOAADCD().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!KeenNPC.JCMKNNOEONP().inInteractiveDialogue)
		{
			KeenNPC.HLMGBEGEAPC().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void LNNHOKMHJBK()
	{
		if (!BruceNPC.DPJEGJBHBNP().inInteractiveDialogue)
		{
			BruceNPC.PNHHCHJCDNM().StopConversation();
		}
		if (!KeenNPC.CHKMFEFOFKJ().inInteractiveDialogue)
		{
			KeenNPC.FMIDAFEGDCD().StopConversation();
		}
	}

	private void MKFPKPJJOCP()
	{
		if (!((Object)(object)KeenNPC.GGFJGHHHEJC == (Object)null) && !((Object)(object)BruceNPC.GGFJGHHHEJC == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !KeenNPC.GGFJGHHHEJC.inUse && !KeenNPC.GGFJGHHHEJC.inBark && KeenNPC.GGFJGHHHEJC.canTalk && !BruceNPC.GGFJGHHHEJC.inUse && !BruceNPC.GGFJGHHHEJC.inBark && BruceNPC.GGFJGHHHEJC.canTalk)
			{
				IDHKFLCNIIP();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || canTalk || KeenNPC.GGFJGHHHEJC.inUse || KeenNPC.GGFJGHHHEJC.inBark || !KeenNPC.GGFJGHHHEJC.canTalk || BruceNPC.GGFJGHHHEJC.inUse || BruceNPC.GGFJGHHHEJC.inBark || !BruceNPC.GGFJGHHHEJC.canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	private void FMIBJJNCGLA()
	{
		if (!((Object)(object)KeenNPC.BGMJCCFNNDL() == (Object)null) && !((Object)(object)BruceNPC.HGJMGNJOHGF() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !KeenNPC.OLHBLKIAFOM().inUse && !KeenNPC.AJIGOHGPFPP().inBark && KeenNPC.MLPCDJPLBAC().canTalk && !BruceNPC.PFHFIJDDOME().inUse && !BruceNPC.IECOPNFJBFD().inBark && BruceNPC.NHKAFANMEJC().canTalk)
			{
				DOLHCMDBNIE();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || canTalk || KeenNPC.BGMJCCFNNDL().inUse || KeenNPC.AJIGOHGPFPP().inBark || !KeenNPC.BGMJCCFNNDL().canTalk || BruceNPC.KFGKCKCDMLG().inUse || BruceNPC.GIKECEGLFOH().inBark || !BruceNPC.NGIMIHFFNMH().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	public void FAMELFOMHMM()
	{
		if (!BruceNPC.PNHHCHJCDNM().inInteractiveDialogue)
		{
			BruceNPC.GIKECEGLFOH().StopConversation();
		}
		if (!KeenNPC.MLPCDJPLBAC().inInteractiveDialogue)
		{
			KeenNPC.OPDKAPNDBJE().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void OIAHJHNPPCO()
	{
		CheckExclamation();
	}

	public void DPBKPBPGCHO()
	{
		ShopUI.IEABDMDELFO(MPFJOKOJIOO().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_17");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void EEPJLOBNIMM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("UI2");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	protected override void KNEHCFHGDFC()
	{
		barkDialogue = true;
		GGFJGHHHEJC.SelectDialogueUI();
		KeenNPC.GGFJGHHHEJC.barkDialogue = true;
		KeenNPC.GGFJGHHHEJC.SelectDialogueUI();
		BruceNPC.GGFJGHHHEJC.barkDialogue = true;
		BruceNPC.GGFJGHHHEJC.SelectDialogueUI();
	}

	public void StopOtherDialogues()
	{
		if (!BruceNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			BruceNPC.GGFJGHHHEJC.StopConversation();
		}
		if (!KeenNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			KeenNPC.GGFJGHHHEJC.StopConversation();
		}
	}

	public void OPGHBDIBDPC()
	{
		ShopUI.EAONFFENMCE(KNOKBLFFNLM().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void CAIJLMJBMLA()
	{
		HBEABOLLBAC();
	}

	public void HJLIMHBLEOK()
	{
		if (!BruceNPC.NGIMIHFFNMH().inInteractiveDialogue)
		{
			BruceNPC.IELEBCAELNI().StopConversation();
		}
		if (!KeenNPC.MLPCDJPLBAC().inInteractiveDialogue)
		{
			KeenNPC.EAGMIHGJKNB().StopConversation();
		}
	}

	public void EIBOMLNHNLP()
	{
		ShopUI.JCBPABNCBPI(MLPCDJPLBAC().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(KNOKBLFFNLM().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void MFMMHDPGCBO()
	{
		HBEABOLLBAC();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (base.MouseUp(JIIGOACEIKL))
		{
			StopOtherDialogues();
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendStopConversation(1);
			}
			return true;
		}
		return false;
	}

	private void DPEFKCOAHMG()
	{
		if (!((Object)(object)KeenNPC.ACPHFLBLJAA() == (Object)null) && !((Object)(object)BruceNPC.MPJJAPCFENH() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !KeenNPC.AGGAGCBAGLL().inUse && !KeenNPC.OAPOJCODNCO().inBark && KeenNPC.GGFJGHHHEJC.canTalk && !BruceNPC.JFNOOMJMHCB().inUse && !BruceNPC.DPJEGJBHBNP().inBark && BruceNPC.HGJMGNJOHGF().canTalk)
			{
				IDHKFLCNIIP();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || canTalk || KeenNPC.AGGAGCBAGLL().inUse || KeenNPC.NGPHACGDNJN().inBark || !KeenNPC.AGGAGCBAGLL().canTalk || BruceNPC.DEGPIHEEFHJ().inUse || BruceNPC.CFLFMDCHNLA().inBark || !BruceNPC.POINNCPMEIG().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	private void HIKINKKGJNN()
	{
		if (!((Object)(object)KeenNPC.MNFMOEKMJKN() == (Object)null) && !((Object)(object)BruceNPC.DEGPIHEEFHJ() == (Object)null))
		{
			if (Time.time > AELCMIGFOAK && !inUse && !inBark && canTalk && !KeenNPC.MNFMOEKMJKN().inUse && !KeenNPC.OAPOJCODNCO().inBark && KeenNPC.OAPOJCODNCO().canTalk && !BruceNPC.BNDMEINJPAN().inUse && !BruceNPC.LKOABOAADCD().inBark && BruceNPC.CFLBNDLLABP().canTalk)
			{
				IDHKFLCNIIP();
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
			else if (inUse || inBark || canTalk || KeenNPC.OJJDNLEFNPJ().inUse || KeenNPC.GFMBEDCANNI().inBark || !KeenNPC.POAGAIBEFBF().canTalk || BruceNPC.BNBMNOMFFBE().inUse || BruceNPC.BNDMEINJPAN().inBark || !BruceNPC.HGJMGNJOHGF().canTalk)
			{
				AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
			}
		}
	}

	[SpecialName]
	public static PetraNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	private void OLDDEAJMHNI()
	{
		MNFMLBEJBEC();
	}

	public void HBEABOLLBAC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("StairsUp");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static PetraNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	private void IDHKFLCNIIP()
	{
		switch (Random.Range(0, 3))
		{
		case 0:
			dialogue.conversation = "City/Petra/Bark/Stand";
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineBarkDialogue = true;
				onlineDialogue.SendResetDialogueUIBlacksmith();
			}
			break;
		case 1:
			if (((Component)KeenNPC.GGFJGHHHEJC).gameObject.activeSelf)
			{
				if (KeenNPC.GGFJGHHHEJC.animationBase.animator.GetBool("Sharp"))
				{
					KeenNPC.GGFJGHHHEJC.dialogue.conversation = "City/Keen/Bark/Sharp";
				}
				else
				{
					KeenNPC.GGFJGHHHEJC.dialogue.conversation = "City/Keen/Bark/Stand";
				}
				KNEHCFHGDFC();
				KeenNPC.GGFJGHHHEJC.main = true;
				KeenNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					KeenNPC.GGFJGHHHEJC.onlineBarkDialogue = true;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		case 2:
			if (((Component)BruceNPC.GGFJGHHHEJC).gameObject.activeSelf)
			{
				BruceNPC.GGFJGHHHEJC.dialogue.conversation = "City/Bruce/Bark/Stand";
				KNEHCFHGDFC();
				BruceNPC.GGFJGHHHEJC.main = true;
				BruceNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					BruceNPC.GGFJGHHHEJC.onlineBarkDialogue = true;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		}
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void HHKDOIPNIAF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Send next game date as a host ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public static PetraNPC MPFJOKOJIOO()
	{
		return IADEMLIIDPC;
	}

	public void StopAllDialogues()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!BruceNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			BruceNPC.GGFJGHHHEJC.StopConversation();
		}
		if (!KeenNPC.GGFJGHHHEJC.inInteractiveDialogue)
		{
			KeenNPC.GGFJGHHHEJC.StopConversation();
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

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public void AKOEOIEPJIH()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation(BGKCHMNJBLJ: false);
		}
		if (!BruceNPC.CNDNOECMKME().inInteractiveDialogue)
		{
			BruceNPC.MAAAKALBBEE().StopConversation();
		}
		if (!KeenNPC.LANAINBEMCM().inInteractiveDialogue)
		{
			KeenNPC.DGCNCEDIFOF().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	private void GNGADDPBJDC()
	{
		EEPJLOBNIMM();
	}

	private void KGGOBFDFAIP()
	{
		switch (Random.Range(0, 1))
		{
		case 0:
			dialogue.conversation = "popUpBuilding7";
			KNEHCFHGDFC();
			main = false;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineBarkDialogue = false;
				onlineDialogue.SendResetDialogueUIBlacksmith();
			}
			break;
		case 1:
			if (((Component)KeenNPC.HEKFJEKFMNO()).gameObject.activeSelf)
			{
				if (KeenNPC.MMLBHCGFMMJ().animationBase.animator.GetBool("itemLager"))
				{
					KeenNPC.OLHBLKIAFOM().dialogue.conversation = "ReciveMoveCrowly";
				}
				else
				{
					KeenNPC.FMIDAFEGDCD().dialogue.conversation = ": ";
				}
				KNEHCFHGDFC();
				KeenNPC.MLPCDJPLBAC().main = true;
				KeenNPC.OPDKAPNDBJE().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					KeenNPC.ACPHFLBLJAA().onlineBarkDialogue = false;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		case 2:
			if (((Component)BruceNPC.BNDMEINJPAN()).gameObject.activeSelf)
			{
				BruceNPC.MAAAKALBBEE().dialogue.conversation = "Try to join private room";
				KNEHCFHGDFC();
				BruceNPC.KADHMEPDIKM().main = false;
				BruceNPC.DEGPIHEEFHJ().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					BruceNPC.MPLODJJFKAM().onlineBarkDialogue = false;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		}
	}

	public void GMCLNBNFBCE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("TextPanel/Description");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void Start()
	{
		CheckExclamation();
	}

	private void DOLHCMDBNIE()
	{
		switch (Random.Range(0, 4))
		{
		case 0:
			dialogue.conversation = " ";
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineBarkDialogue = false;
				onlineDialogue.SendResetDialogueUIBlacksmith();
			}
			break;
		case 1:
			if (((Component)KeenNPC.BGMJCCFNNDL()).gameObject.activeSelf)
			{
				if (KeenNPC.ACPHFLBLJAA().animationBase.animator.GetBool("Dialogue System/Conversation/Crowly_Standar/Entry/48/Dialogue Text"))
				{
					KeenNPC.CFHEJAGKIII().dialogue.conversation = " ";
				}
				else
				{
					KeenNPC.OJJDNLEFNPJ().dialogue.conversation = "Player2";
				}
				KNEHCFHGDFC();
				KeenNPC.JCMKNNOEONP().main = true;
				KeenNPC.DEGPIHEEFHJ().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					KeenNPC.MMLBHCGFMMJ().onlineBarkDialogue = true;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		case 2:
			if (((Component)BruceNPC.HLMGBEGEAPC()).gameObject.activeSelf)
			{
				BruceNPC.KADHMEPDIKM().dialogue.conversation = "Smell";
				KNEHCFHGDFC();
				BruceNPC.KFGKCKCDMLG().main = false;
				BruceNPC.GGFJGHHHEJC.dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					BruceNPC.EJECEDMPCOH().onlineBarkDialogue = false;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		}
	}

	public void CGDJKAKGFEK()
	{
		if (!BruceNPC.MPJJAPCFENH().inInteractiveDialogue)
		{
			BruceNPC.EJECEDMPCOH().StopConversation();
		}
		if (!KeenNPC.EAGMIHGJKNB().inInteractiveDialogue)
		{
			KeenNPC.LANAINBEMCM().StopConversation();
		}
	}

	private void EGIOHCFKHHM()
	{
		switch (Random.Range(0, 8))
		{
		case 0:
			dialogue.conversation = "UIBack";
			KNEHCFHGDFC();
			main = true;
			dialogue.OnUse();
			if (OnlineManager.PlayingOnline())
			{
				onlineBarkDialogue = false;
				onlineDialogue.SendResetDialogueUIBlacksmith();
			}
			break;
		case 1:
			if (((Component)KeenNPC.OPDKAPNDBJE()).gameObject.activeSelf)
			{
				if (KeenNPC.NGPHACGDNJN().animationBase.animator.GetBool("Not enough money"))
				{
					KeenNPC.JCMKNNOEONP().dialogue.conversation = "Player/Bark/Tutorial/T116";
				}
				else
				{
					KeenNPC.GFMBEDCANNI().dialogue.conversation = "Jump";
				}
				KNEHCFHGDFC();
				KeenNPC.HEKFJEKFMNO().main = false;
				KeenNPC.DGCNCEDIFOF().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					KeenNPC.AJIGOHGPFPP().onlineBarkDialogue = true;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		case 2:
			if (((Component)BruceNPC.LKDJNKLJKGO()).gameObject.activeSelf)
			{
				BruceNPC.KFGKCKCDMLG().dialogue.conversation = "ClosePopUp";
				KNEHCFHGDFC();
				BruceNPC.PDECKLKPKCG().main = false;
				BruceNPC.LFPEPJBNCBF().dialogue.OnUse();
				if (OnlineManager.PlayingOnline())
				{
					BruceNPC.MPJJAPCFENH().onlineBarkDialogue = false;
					onlineDialogue.SendResetDialogueUIBlacksmith();
				}
			}
			break;
		}
	}

	public void MJECLLACGAN()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!BruceNPC.CFLFMDCHNLA().inInteractiveDialogue)
		{
			BruceNPC.JFJOKGAOPHA().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!KeenNPC.NGPHACGDNJN().inInteractiveDialogue)
		{
			KeenNPC.OLHBLKIAFOM().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void PHCPIJFCAHI()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!BruceNPC.OAPOJCODNCO().inInteractiveDialogue)
		{
			BruceNPC.NBKKEINELDN().StopConversation();
		}
		if (!KeenNPC.FMIDAFEGDCD().inInteractiveDialogue)
		{
			KeenNPC.EAGMIHGJKNB().StopConversation(BGKCHMNJBLJ: false);
		}
	}

	public void ODGJKNDOKJJ()
	{
		if (!inInteractiveDialogue)
		{
			StopConversation();
		}
		if (!BruceNPC.DOIKFJDLKJP().inInteractiveDialogue)
		{
			BruceNPC.MPLODJJFKAM().StopConversation(BGKCHMNJBLJ: false);
		}
		if (!KeenNPC.OPDKAPNDBJE().inInteractiveDialogue)
		{
			KeenNPC.GGFJGHHHEJC.StopConversation();
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

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("LE_17");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			dialogue.conversation = "City/Petra/Introduce";
		}
		else
		{
			dialogue.conversation = "City/Petra/Stand";
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

	public void CPFEBDHKJHN()
	{
		ShopUI.Get(MLPCDJPLBAC().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(MAAAKALBBEE().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void LANGHIOBJIH()
	{
		HHKDOIPNIAF();
	}
}
