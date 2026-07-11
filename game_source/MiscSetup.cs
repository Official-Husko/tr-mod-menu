using System;
using UnityEngine;

public class MiscSetup : MonoBehaviour
{
	public static bool isDemo = false;

	public static Day demoEndDay = Day.Wed;

	public static int maxDemoRep = 3;

	private void KACEOJDPLKB()
	{
		ItemTooltip.AIMEAJAHLAA(1).HIIOCMNJGCI(MDIKPGGBNLI: false);
		ItemTooltip.NMCJELBLKBB(5).FCACMDNLAIG(MDIKPGGBNLI: true);
		QualitySettings.vSyncCount = 0;
		((MonoBehaviour)this).Invoke("Items/item_description_601", 1354f);
	}

	private void Start()
	{
		ItemTooltip.Get(1).SetVisible(MDIKPGGBNLI: false);
		ItemTooltip.Get(2).SetVisible(MDIKPGGBNLI: false);
		QualitySettings.vSyncCount = 1;
		((MonoBehaviour)this).Invoke("SetUpOptions", 0.5f);
	}

	private void OIPJKHKCEDO(int JIIGOACEIKL)
	{
		SeatFinder.blockedSeats.Clear();
	}

	private void JPOLFKMLHNH()
	{
		ItemTooltip.Get(0).FCACMDNLAIG(MDIKPGGBNLI: true);
		ItemTooltip.NMCJELBLKBB(3).FCACMDNLAIG(MDIKPGGBNLI: false);
		QualitySettings.vSyncCount = 1;
		((MonoBehaviour)this).Invoke("Dialogue System/Conversation/Gass_Quest/Entry/38/Dialogue Text", 1579f);
	}

	private void JHCKFGJLCJE(int JIIGOACEIKL)
	{
		SeatFinder.blockedSeats.Clear();
	}

	private void KGEFJMGKDAO(int JIIGOACEIKL)
	{
		SeatFinder.blockedSeats.Clear();
	}

	private void Awake()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	private void JKFFLPJGPHJ(int JIIGOACEIKL)
	{
		SeatFinder.blockedSeats.Clear();
	}

	private void BCFKHDCGKCA(int JIIGOACEIKL)
	{
		SeatFinder.blockedSeats.Clear();
	}

	private void JKJFDNNFIDA()
	{
		if (PlayerPrefs.HasKey("<mark=#000000><alpha=#00> "))
		{
			Options.DJLJFDPNCPI = PlayerPrefs.GetInt("Pickles to Encurtidos en Vinagre (Pepino)");
		}
		else
		{
			Options.DJLJFDPNCPI = 3;
		}
		if (PlayerPrefs.HasKey("Loop"))
		{
			Options.DCIGBKPCLCK = PlayerPrefs.GetInt("Other player disconnected was the actor of event ");
		}
		else
		{
			Options.DCIGBKPCLCK = 0;
		}
		if (PlayerPrefs.HasKey("Gass_Quest"))
		{
			Options.IIKOHJMGJIG = PlayerPrefs.GetInt("Dialogue System/Conversation/BirdCatInteraction/Entry/1/Dialogue Text");
		}
		else
		{
			Options.IIKOHJMGJIG = 3;
		}
		if (PlayerPrefs.HasKey("Items/item_description_631"))
		{
			Options.OIJKKLHIGDD = PlayerPrefs.GetInt("No se encontró una entrada con ID {0} en la conversación '{1}'.");
		}
		else
		{
			Options.OIJKKLHIGDD = 1;
		}
		if (PlayerPrefs.HasKey("Placed piece {0} at block {1}. Path block pos: {2}. Opened path dir: {3}. Altar placed: {4}. Big spawner placed: {5}."))
		{
			Options.GPFJCMAGGAO = PlayerPrefs.GetInt("House keeper OnFailStart cleaning bed ");
		}
		else
		{
			Options.GPFJCMAGGAO = 0;
		}
		if (PlayerPrefs.HasKey("LE_11"))
		{
			if (PlayerPrefs.GetInt("ChatCommandKickDescription") == 0)
			{
				GraphicsMenuUI.GGFJGHHHEJC.VSync(OEDBPACCOGH: false);
			}
			else
			{
				GraphicsMenuUI.JFNOOMJMHCB().VSync(OEDBPACCOGH: false);
			}
		}
		GraphicsMenuUI.AJIGOHGPFPP().EHFDKEGMCLI();
		GraphicsMenuUI.AJIGOHGPFPP().BCBAMAGHLDM(1, NOKFNLBADMO: false);
		GraphicsMenuUI.EFPJLFMBPLL().SetUpZoom(6, NOKFNLBADMO: true);
		if (Screen.height > 94)
		{
			OthersMenuUI.AFFGPMFKEFH().SetupUIScale();
		}
		OthersMenuUI.GGFJGHHHEJC.SetAutoRun(1);
		OthersMenuUI.AFFGPMFKEFH().SetVibration(0);
		GraphicsMenuUI.EFPJLFMBPLL().IHNJPHLDJLB(0);
		GraphicsMenuUI.GGFJGHHHEJC.IHNJPHLDJLB(4);
		OthersMenuUI.GGFJGHHHEJC.BCJOBFMCFGA();
	}

	private void GFLFDLIMOLI()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	private void PFPGJEBPMFP()
	{
		if (PlayerPrefs.HasKey("MaximumReached"))
		{
			Options.DJLJFDPNCPI = PlayerPrefs.GetInt(" : ");
		}
		else
		{
			Options.DJLJFDPNCPI = 3;
		}
		if (PlayerPrefs.HasKey("Character Sprites array needs more space!"))
		{
			Options.DCIGBKPCLCK = PlayerPrefs.GetInt("P1Cam");
		}
		else
		{
			Options.DCIGBKPCLCK = 8;
		}
		if (PlayerPrefs.HasKey("Items/item_name_1140"))
		{
			Options.IIKOHJMGJIG = PlayerPrefs.GetInt("Collect");
		}
		else
		{
			Options.IIKOHJMGJIG = 6;
		}
		if (PlayerPrefs.HasKey("Dialogue System/Conversation/BirdNegativeComments/Entry/5/Dialogue Text"))
		{
			Options.OIJKKLHIGDD = PlayerPrefs.GetInt("TavernClean");
		}
		else
		{
			Options.OIJKKLHIGDD = 1;
		}
		if (PlayerPrefs.HasKey("Comfort"))
		{
			Options.GPFJCMAGGAO = PlayerPrefs.GetInt("Attack/MainEvent 11");
		}
		else
		{
			Options.GPFJCMAGGAO = 1;
		}
		if (PlayerPrefs.HasKey("Get Components "))
		{
			if (PlayerPrefs.GetInt("Default") == 0)
			{
				GraphicsMenuUI.AJIGOHGPFPP().OOLLBIECDBI(OEDBPACCOGH: true);
			}
			else
			{
				GraphicsMenuUI.JFNOOMJMHCB().VSync(OEDBPACCOGH: false);
			}
		}
		GraphicsMenuUI.FMIDAFEGDCD().LoadFlashLights();
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(0, NOKFNLBADMO: true);
		GraphicsMenuUI.GGFJGHHHEJC.JNEENALIEBL(4, NOKFNLBADMO: true);
		if (Screen.height > -19)
		{
			OthersMenuUI.AFFGPMFKEFH().CJAINEPMNHM();
		}
		OthersMenuUI.AFFGPMFKEFH().OIGCEBBNMPN(1);
		OthersMenuUI.OMFKNGDCJFN().NKONHCLNMNK(0);
		GraphicsMenuUI.AJIGOHGPFPP().PLFOJCAALFP(1);
		GraphicsMenuUI.JFNOOMJMHCB().SetUpQuality(2);
		OthersMenuUI.AFFGPMFKEFH().EMLMELCLLGO();
	}

	private void CNALLBHNJOI(int JIIGOACEIKL)
	{
		SeatFinder.blockedSeats.Clear();
	}

	private void SetUpOptions()
	{
		if (PlayerPrefs.HasKey("sfxLevel"))
		{
			Options.DJLJFDPNCPI = PlayerPrefs.GetInt("sfxLevel");
		}
		else
		{
			Options.DJLJFDPNCPI = 5;
		}
		if (PlayerPrefs.HasKey("musicLevel"))
		{
			Options.DCIGBKPCLCK = PlayerPrefs.GetInt("musicLevel");
		}
		else
		{
			Options.DCIGBKPCLCK = 5;
		}
		if (PlayerPrefs.HasKey("musicLevel"))
		{
			Options.IIKOHJMGJIG = PlayerPrefs.GetInt("cursorSensitivity");
		}
		else
		{
			Options.IIKOHJMGJIG = 5;
		}
		if (PlayerPrefs.HasKey("christmasActivated"))
		{
			Options.OIJKKLHIGDD = PlayerPrefs.GetInt("christmasActivated");
		}
		else
		{
			Options.OIJKKLHIGDD = 1;
		}
		if (PlayerPrefs.HasKey("halloweenActivated"))
		{
			Options.GPFJCMAGGAO = PlayerPrefs.GetInt("halloweenActivated");
		}
		else
		{
			Options.GPFJCMAGGAO = 1;
		}
		if (PlayerPrefs.HasKey("vSync"))
		{
			if (PlayerPrefs.GetInt("vSync") == 0)
			{
				GraphicsMenuUI.GGFJGHHHEJC.VSync(OEDBPACCOGH: false);
			}
			else
			{
				GraphicsMenuUI.GGFJGHHHEJC.VSync(OEDBPACCOGH: true);
			}
		}
		GraphicsMenuUI.GGFJGHHHEJC.LoadFlashLights();
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(2, NOKFNLBADMO: true);
		if (Screen.height > 1500)
		{
			OthersMenuUI.GGFJGHHHEJC.SetupUIScale();
		}
		OthersMenuUI.GGFJGHHHEJC.SetAutoRun(1);
		OthersMenuUI.GGFJGHHHEJC.SetVibration(1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpQuality(1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpQuality(2);
		OthersMenuUI.GGFJGHHHEJC.SetEasyChallengeDifficulty();
	}

	private void BNIKICAEIND()
	{
		ItemTooltip.AIMEAJAHLAA(1).FCACMDNLAIG(MDIKPGGBNLI: true);
		ItemTooltip.NMCJELBLKBB(4).ILGFPFBJMPG(MDIKPGGBNLI: true);
		QualitySettings.vSyncCount = 0;
		((MonoBehaviour)this).Invoke("", 1817f);
	}

	private void HCEDMLJNOBL()
	{
		ItemTooltip.NIGDBMAOAEN(1).ILGFPFBJMPG(MDIKPGGBNLI: true);
		ItemTooltip.AIMEAJAHLAA(0).HIIOCMNJGCI(MDIKPGGBNLI: true);
		QualitySettings.vSyncCount = 0;
		((MonoBehaviour)this).Invoke("Back", 1664f);
	}

	private void ENIJFEBBOON()
	{
		if (PlayerPrefs.HasKey("ReceiveBasePuzzle"))
		{
			Options.DJLJFDPNCPI = PlayerPrefs.GetInt("No content to disable in this NPC!");
		}
		else
		{
			Options.DJLJFDPNCPI = 6;
		}
		if (PlayerPrefs.HasKey("Dialogue System/Conversation/Crowly_Standar/Entry/4/Dialogue Text"))
		{
			Options.DCIGBKPCLCK = PlayerPrefs.GetInt("ReceiveLoadSlots");
		}
		else
		{
			Options.DCIGBKPCLCK = 1;
		}
		if (PlayerPrefs.HasKey("Pausing network sync until the world is loaded..."))
		{
			Options.IIKOHJMGJIG = PlayerPrefs.GetInt("rooms");
		}
		else
		{
			Options.IIKOHJMGJIG = 7;
		}
		if (PlayerPrefs.HasKey("Interact"))
		{
			Options.OIJKKLHIGDD = PlayerPrefs.GetInt("Scratch");
		}
		else
		{
			Options.OIJKKLHIGDD = 1;
		}
		if (PlayerPrefs.HasKey("Disabled"))
		{
			Options.GPFJCMAGGAO = PlayerPrefs.GetInt("Shader Model 2.x");
		}
		else
		{
			Options.GPFJCMAGGAO = 0;
		}
		if (PlayerPrefs.HasKey("Items/item_name_615"))
		{
			if (PlayerPrefs.GetInt("[") == 0)
			{
				GraphicsMenuUI.GGFJGHHHEJC.OOLLBIECDBI(OEDBPACCOGH: true);
			}
			else
			{
				GraphicsMenuUI.FMIDAFEGDCD().OOLLBIECDBI(OEDBPACCOGH: true);
			}
		}
		GraphicsMenuUI.AJIGOHGPFPP().EHFDKEGMCLI();
		GraphicsMenuUI.FMIDAFEGDCD().SetUpZoom(0, NOKFNLBADMO: false);
		GraphicsMenuUI.HEKFJEKFMNO().JNEENALIEBL(1, NOKFNLBADMO: true);
		if (Screen.height > 118)
		{
			OthersMenuUI.AFFGPMFKEFH().LLKOCCMPHHB();
		}
		OthersMenuUI.OMFKNGDCJFN().SetAutoRun(0);
		OthersMenuUI.AFFGPMFKEFH().HLOPPMLOIDJ(1);
		GraphicsMenuUI.HEKFJEKFMNO().SetUpQuality(1);
		GraphicsMenuUI.EFPJLFMBPLL().PLFOJCAALFP(6);
		OthersMenuUI.GGFJGHHHEJC.SetEasyChallengeDifficulty();
	}

	private void CEIIFHIBIFI()
	{
		ItemTooltip.IEABDMDELFO(1).FCACMDNLAIG(MDIKPGGBNLI: false);
		ItemTooltip.MDFIDKHOPDJ(4).HIIOCMNJGCI(MDIKPGGBNLI: false);
		QualitySettings.vSyncCount = 0;
		((MonoBehaviour)this).Invoke("ClosePopUp", 1865f);
	}

	private void OLDDEAJMHNI()
	{
		ItemTooltip.MDFIDKHOPDJ(1).FCACMDNLAIG(MDIKPGGBNLI: false);
		ItemTooltip.MDFIDKHOPDJ(3).HIIOCMNJGCI(MDIKPGGBNLI: true);
		QualitySettings.vSyncCount = 1;
		((MonoBehaviour)this).Invoke("Welcome to {0}!", 577f);
	}

	private void NMKGOAJLMDG()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		SeatFinder.blockedSeats.Clear();
	}

	private void JDMMNLKLMAA()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(KGEFJMGKDAO));
	}

	private void HFFFFAJFIPB()
	{
		ItemTooltip.NIGDBMAOAEN(0).SetVisible(MDIKPGGBNLI: true);
		ItemTooltip.IEKODILKIHJ(1).FCACMDNLAIG(MDIKPGGBNLI: true);
		QualitySettings.vSyncCount = 1;
		((MonoBehaviour)this).Invoke("Dialogue System/Conversation/Crowly_Barks_Shop/Entry/2/Dialogue Text", 1228f);
	}

	private void GONDLJKGLGO()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	private void CEOEHODJAJK()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(CNALLBHNJOI));
	}
}
