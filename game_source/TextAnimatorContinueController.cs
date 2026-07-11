using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;

public class TextAnimatorContinueController : MonoBehaviour
{
	public TextAnimatorContinueButtonFastForward standarUI;

	public GameObject button;

	public TextMeshProUGUI text;

	public int playerNum;

	private void NEPDNLPCCON()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).AAGNDCEODFO() == "Focused" && CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("Arguing") || PlayerInputs.DEGBDMMDIIL(playerNum).GetButtonDown("[RestoreNonAltarVariant] - VariantObjects: {0} - ({1}-{2}/{3}) ")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
			else if (CommonReferences.GGFJGHHHEJC.GMEEFHDEIGB(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILDGJELNPEI();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
		}
	}

	private void MCLAJGDIIBK()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).AAGNDCEODFO() == "Inventory full" && CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("ReceiveRequestTableOrderBanquetCustomer") || PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("Trying to add player but player list is full.")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.POLDHCKJINN(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.NAMLADDJICM();
			}
			else if (CommonReferences.MNFMOEKMJKN().GMEEFHDEIGB(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void DKNMGFDFLKL()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).AAGNDCEODFO() == "Dialogue System/Conversation/Crowly_Standar/Entry/44/Dialogue Text" && CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).GetButtonDown("Calendar") || PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL(": ")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.ODGALPDEIFG(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
			else if (CommonReferences.GGFJGHHHEJC.AGGLODBDMEO(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.NAMLADDJICM();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void CMDHELEDLBP()
	{
		if (PlayerInputs.GetPlayer(playerNum).CFICAAJGBOF == "ReceiveSimpleEvent" && CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL(" tried to do seat found being in state ") || PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("\">")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.ODGALPDEIFG(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
			else if (CommonReferences.GGFJGHHHEJC.GMEEFHDEIGB(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void DOKHLDBIDJB()
	{
		if (PlayerInputs.GetPlayer(playerNum).EECADEPLELA() == "ReceiveTalentFromOther" && CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("ReceiveDroppedItemMessage") || PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("ReceiveUpdateBentoOnTray")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.ODGALPDEIFG(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.FMBBAMNEHDM();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().SetExecute(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BOPAGJENIMD();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void FDHMOEDMPNG()
	{
		if (PlayerInputs.GetPlayer(playerNum).FGGHCBMKKIG() == "" && CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(playerNum) && (PlayerInputs.GetPlayer(playerNum).GetButtonDown("Failed to set rich presence key ") || PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL(".gz")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.POLDHCKJINN(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
			else if (CommonReferences.GGFJGHHHEJC.GMEEFHDEIGB(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().SetExecute(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void PKEPBKHEDOD()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).FGGHCBMKKIG() == "Building" && CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(playerNum) && (PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("() Ingredient ") || PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL(" and ")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.NAMLADDJICM();
			}
			else if (CommonReferences.GGFJGHHHEJC.AGGLODBDMEO(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.SetExecute(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void BBCPDBEOOKL()
	{
		if (PlayerInputs.GetPlayer(playerNum).EECADEPLELA() == "Initializing GalaxyPeer instance..." && CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("PressSPACE") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("Loop")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BOPAGJENIMD();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILDGJELNPEI();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void MMPMJNAFKHC()
	{
		if (PlayerInputs.GetPlayer(playerNum).CFICAAJGBOF == "Attack/MainEvent 8" && CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && (PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("Player2") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("Dialogue System/Conversation/Rowdy/Entry/8/Dialogue Text")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
			else if (CommonReferences.GGFJGHHHEJC.GMEEFHDEIGB(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void JBGFGOCPEFD()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).FGGHCBMKKIG() == "Peak" && CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && (PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("UI") || PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("fishing")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.FMBBAMNEHDM();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.HBGJFCNLGDA();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
		}
	}

	private void HIPNEFOEJPL()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).CFICAAJGBOF == "Scratch" && CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL(" (") || PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("Accept")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.ODGALPDEIFG(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.DHLCDOGJOLN();
			}
			else if (CommonReferences.MNFMOEKMJKN().GetExecute(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.GCNNNLKPPON();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void IIOHMDNGFDH()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).CFICAAJGBOF == "sprintToggle" && CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("Sleep") || PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("Spawn Dropped Item ")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
			else if (CommonReferences.GGFJGHHHEJC.GMEEFHDEIGB(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.HBGJFCNLGDA();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
		}
	}

	private void MNFMLJJBKNC()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).FGGHCBMKKIG() == "autoRun" && CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && (PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("CraftedIn") || PlayerInputs.DEGBDMMDIIL(playerNum).GetButtonDown(": ")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.NAMLADDJICM();
			}
			else if (CommonReferences.GGFJGHHHEJC.GMEEFHDEIGB(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.SetExecute(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void JMDOCHBJGKG()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).EECADEPLELA() == " not found. Cannot add to surface" && CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && (PlayerInputs.GetPlayer(playerNum).GetButtonDown("itemSickle") || PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("Trying to get a player's steam name but they're not playing on a steam platform")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
			else if (CommonReferences.GGFJGHHHEJC.AGGLODBDMEO(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().SetExecute(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.GCNNNLKPPON();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
		}
	}

	private void Update()
	{
		if (PlayerInputs.GetPlayer(playerNum).CFICAAJGBOF == "UI" && CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && (PlayerInputs.GetPlayer(playerNum).GetButtonDown("UIInteract") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("ClosePopUp")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.IsGamepadActive(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.SetExecute(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void FGGPGOEAEKK()
	{
		if (PlayerInputs.GetPlayer(playerNum).AAGNDCEODFO() == "descBucket" && CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("LE_10") || PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("Tutorial/T300/Dialogue1")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.ODGALPDEIFG(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BOPAGJENIMD();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
		}
	}

	private void AKLEFPLEGKK()
	{
		if (PlayerInputs.GetPlayer(playerNum).CFICAAJGBOF == "Put" && CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("ReceiveBathhouseEntranceEventLeftBathhouse") || PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("Roll")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
			else if (CommonReferences.MNFMOEKMJKN().AGGLODBDMEO(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.DHLCDOGJOLN();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void FPOIFOGELHC()
	{
		if (PlayerInputs.GetPlayer(playerNum).AAGNDCEODFO() == "Fireplace not attached on OnlineFireplace of placeable " && CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).GetButtonDown("") || PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("</color>")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.ODGALPDEIFG(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.NAMLADDJICM();
			}
			else if (CommonReferences.MNFMOEKMJKN().GMEEFHDEIGB(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void IAICCKPOBMJ()
	{
		if (PlayerInputs.GetPlayer(playerNum).EECADEPLELA() == " %" && CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && (PlayerInputs.GetPlayer(playerNum).GetButtonDown("Selected") || PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("RingBell")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
			else if (CommonReferences.MNFMOEKMJKN().GetExecute(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
		}
	}

	private void CKCHKHNBBFG()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).CFICAAJGBOF == "tutorialPopUp110" && CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && (PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("Serve")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.DHLCDOGJOLN();
			}
			else if (CommonReferences.MNFMOEKMJKN().GetExecute(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void NIHJCJJKDBA()
	{
		if (PlayerInputs.GetPlayer(playerNum).EECADEPLELA() == "Dialogue System/Conversation/TavernFilthy/Entry/7/Dialogue Text" && CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("ThemeTypeLabelBlueprint") || PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("Key2")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.DHLCDOGJOLN();
			}
			else if (CommonReferences.MNFMOEKMJKN().GetExecute(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BOPAGJENIMD();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void MGMLDHPOLGK()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).CFICAAJGBOF == "Dialogue System/Conversation/Gass_Barks_Bye/Entry/4/Dialogue Text" && CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA(", ") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("Items/item_description_633")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.FMBBAMNEHDM();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().SetExecute(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
		}
	}

	private void ELHCBGCEJDH()
	{
		if (PlayerInputs.GetPlayer(playerNum).EECADEPLELA() == "Bed without valid position" && CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && (PlayerInputs.GetPlayer(playerNum).GetButtonDown("Idle") || PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA("ReceiveSetDirtiness")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.DHLCDOGJOLN();
			}
			else if (CommonReferences.MNFMOEKMJKN().AGGLODBDMEO(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.DHLCDOGJOLN();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void BHLHCOALABE()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).AAGNDCEODFO() == "AceT_Quest" && CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("First initialization.") || PlayerInputs.DEGBDMMDIIL(playerNum).DLFAMOCKNMA(" is not in the correct layer. Please set it to Map or Object. to can occupy nodes")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
			else if (CommonReferences.MNFMOEKMJKN().GMEEFHDEIGB(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.FMBBAMNEHDM();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = true;
		}
	}

	private void PJLKGOACDEN()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).FGGHCBMKKIG() == "Toggle Build Mode" && CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(playerNum) && (PlayerInputs.GetPlayer(playerNum).DLFAMOCKNMA("UI2") || PlayerInputs.DEGBDMMDIIL(playerNum).GetButtonDown("NinjaChallengeEvent/Main 3")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.ODGALPDEIFG(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
			else if (CommonReferences.MNFMOEKMJKN().AGGLODBDMEO(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().HPDOMEIJAJI(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.SendSkipTypewriter();
			}
		}
		if (CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void ICMNODPLPBK()
	{
		if (PlayerInputs.GetPlayer(playerNum).AAGNDCEODFO() == "SwishEffect" && CommonReferences.MNFMOEKMJKN().IsInDialogue(playerNum) && (PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("Sleep") || PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("Use")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.GCNNNLKPPON();
			}
			else if (CommonReferences.MNFMOEKMJKN().AGGLODBDMEO(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BOPAGJENIMD();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter = false;
		}
	}

	private void GOJFGHKOFMF()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).FGGHCBMKKIG() == "/ExtraSettings.sd" && CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("\n\n") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("Popup missing.")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.BMIFGFKDDNC();
			}
			else if (CommonReferences.GGFJGHHHEJC.GMEEFHDEIGB(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = true;
		}
	}

	private void POFDOILPANH()
	{
		if (PlayerInputs.GetPlayer(playerNum).CFICAAJGBOF == "\n" && CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && (PlayerInputs.DEGBDMMDIIL(playerNum).JCMOPOMLPLL("Starting New Game Coroutine FINISHED") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("Error_CellarDoorIsBlocking")) && ((TMP_Text)text).maxVisibleCharacters > 1)
		{
			if (!PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.NAMLADDJICM();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.MNFMOEKMJKN().SetExecute(playerNum, JGJCFHPMKGF: false);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.GCNNNLKPPON();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(playerNum) && CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
		}
	}

	private void OAKGHDAABPM()
	{
		if (PlayerInputs.DEGBDMMDIIL(playerNum).CFICAAJGBOF == "Items/item_description_1180" && CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(playerNum) && (PlayerInputs.GetPlayer(playerNum).JCMOPOMLPLL("Finished generating level {0}. Total blocks: {1}. Opened paths: {2}. Altar placed: {3}. Big spawner placed: {4}. Puzzle type: {5}. Seed: {6}") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("ReceiveActiveMaiInBar")) && ((TMP_Text)text).maxVisibleCharacters > 0)
		{
			if (!PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
			else if (CommonReferences.GGFJGHHHEJC.GetExecute(playerNum))
			{
				CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(playerNum, JGJCFHPMKGF: true);
			}
			else
			{
				PluginsGameData.playerDialogue = playerNum;
				standarUI.OnFastForward();
				OnlineDialogueManager.instance.ILCCGBNJMGH();
			}
		}
		if (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum) && CommonReferences.GGFJGHHHEJC.onlineSkipTypeWriter)
		{
			standarUI.ForceSkipTypewriter();
			CommonReferences.MNFMOEKMJKN().onlineSkipTypeWriter = false;
		}
	}
}
