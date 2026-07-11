using System.Runtime.CompilerServices;
using UnityEngine;

public class TestOptions : UIWindow
{
	private static TestOptions IADEMLIIDPC;

	public Animator[] panelsAnimatorUI;

	public UIWindow[] panelsUI;

	private int HACEDOOFMBE;

	private float CMGDCLIIONE;

	public static TestOptions GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
			}
			return IADEMLIIDPC;
		}
	}

	[SpecialName]
	public static TestOptions LKDJNKLJKGO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void CBPIDDPHMIP(int KHEICLKLPDE)
	{
		FocusMainPanel(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void EDCNKEFPCID(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Items/item_name_1073");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("SalonDelTrono/TweekTalk");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/BirdNegativeComments/Entry/3/Dialogue Text");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Creando TXT. Tiempo: ");
			}
			panelsAnimatorUI[i].ResetTrigger("<br>");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Default");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("ButtonHold");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void JGGBJIEJOMH(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("City/Petra/Bark/Buy");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Toy");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("ReceiveAddItemOnTray");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("LE_4");
			}
			panelsAnimatorUI[i].ResetTrigger("<br/>Screen Size: ");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Walk");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger(" to ");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	[SpecialName]
	public static TestOptions MMLBHCGFMMJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void OOBBIJKEFPM(int KHEICLKLPDE)
	{
		HGIJGHCILDA(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void IFOEIDJAHFH(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Year");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Pick up");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("CliveProgress");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Tutorial/T131/Dialogue1");
			}
			panelsAnimatorUI[i].ResetTrigger(" ");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Direction");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Dialogue System/Conversation/BirdNegativeComments/Entry/9/Dialogue Text");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void JHOJBBIEGDP(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Cellar");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Cat");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Till");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Walk");
			}
			panelsAnimatorUI[i].ResetTrigger("UIPreviousCategory");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Door");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger(" found in slot ");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void PILOCNIGGKO(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"MainProgress");
		if (QuestHighlightUI.GOINABFEBCI() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.Get(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				AHBDGDCEFLA(QuestLogUI.IEABEDGCGHE(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FFOABBDFMNE(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			JPCHIEBJIJI(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions NGPHACGDNJN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void DOKJOACDAOH(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Items/item_description_705");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Player/Bark/Tutorial/CrafterBlock");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("BathhouseTeleport");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Can't select unless we're connected.");
			}
			panelsAnimatorUI[i].ResetTrigger("StartDialogueById ");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("UIAddRemove");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger(")</color>");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void AKHHMPMAAEC(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Item ");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("ReceiveGenerateMineLevel");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Piso {0}: Spawneando roca '{1}' en punto '{2}' (Posición: {3}).");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("");
			}
			panelsAnimatorUI[i].ResetTrigger("Player Bed with actor number {0} is already in the dictionary.");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Dialogue System/Conversation/NeutralInTavern/Entry/19/Dialogue Text");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void CLEGHMICGHJ(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"The mine piece ");
		if (QuestHighlightUI.FOKHDAGGAOF() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				KIGJICMCEIE(QuestLogUI.IEABEDGCGHE(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			ADLBOEGDHKO(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void CKNNHEMIBKC(int KHEICLKLPDE)
	{
		MPENJKPDGBL(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void IGAOJIBGJIK(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"BathhouseGameManager: Ending game.");
		if (QuestHighlightUI.ADHBAJFBFBD() && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.LJONDAEOMFJ(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				CANNODEKKGD(QuestLogUI.MENNLOGFNOK(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			ADLBOEGDHKO(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void KMKIOADKAIG(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)" ");
		if (QuestHighlightUI.ADHBAJFBFBD() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.DOGBDIOJAHO(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				ADLBOEGDHKO(QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (IsOpen())
		{
			CANNODEKKGD(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void ANMLMJBHCHI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"NoEresDigno/KyrohTalks");
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (BGLJFMHCFJF())
			{
				LPBAFDKPEHM(QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FFOABBDFMNE(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			PPBJHMLIPJM(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions MKIEMMGGFEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void LCCBFNCHFHK(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Dialogue System/Conversation/BirdNegativeComments/Entry/4/Dialogue Text");
		if (QuestHighlightUI.ADHBAJFBFBD() && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.FHBIFJNCOAI(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				BOODOFDJBNC(QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			HAIICCEMEAK(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void JPCHIEBJIJI(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Serve");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger(" ");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger(".");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Moving");
			}
			panelsAnimatorUI[i].ResetTrigger("- ");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Items/item_name_1038");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Guest");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void PanelToggleUI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"PanelToggleUI");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.Get(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				FocusMainPanel(QuestLogUI.Get(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.Get(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			FocusMainPanel(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions OPDKAPNDBJE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void CEDPABHOKDI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"itemFishSteak");
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.CKHAJHCDAHC(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				LPBAFDKPEHM(QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			AHBDGDCEFLA(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void BAOPIGMJBAI(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Items/item_description_1065");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("I have to wait other players");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("LE_17");
			}
			panelsAnimatorUI[i].ResetTrigger("BathhouseGame/Win");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Upgrade");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Bounce");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	[SpecialName]
	public static TestOptions HFIJHDBKCIA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void FocusMainPanel(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("NormalLeft");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("NormalLeftExterior");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("NormalRight");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("NormalRightExterior");
			}
			panelsAnimatorUI[i].ResetTrigger("Selected");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Normal");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Selected");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void CFBOFLLJGCB(int KHEICLKLPDE)
	{
		PPBJHMLIPJM(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void MPAANHHCJCN(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"UI/ColorPicker");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				IPBLFEIDBGN(QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			LACPMHMEPHC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void GOKJKHBCILD(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"MainProgress");
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.FHBIFJNCOAI(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				LBHMFNKDBHN(QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			NGGHKLLEDGF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions NEFIEJALANL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void ELGBIGHPJEK(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Trying to add a player that's already on the list.");
		if (QuestHighlightUI.GOINABFEBCI() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				NGGHKLLEDGF(QuestLogUI.MOMKLDLOAGD(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FFOABBDFMNE(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			LPBAFDKPEHM(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void AHBDGDCEFLA(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger(": ");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Put Out Fire");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("itemLargeRock");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("quest_description_19");
			}
			panelsAnimatorUI[i].ResetTrigger("Game");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("MopRight");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("0");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void PHPAHDKDAAP(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Items/item_description_1047");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				ADLBOEGDHKO(QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			NEKFCHILCJF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void HMNKFGMFIFK(int KHEICLKLPDE)
	{
		ADLBOEGDHKO(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void LACPMHMEPHC(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Level ");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/1/Dialogue Text");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("Guards finished walking.");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Clean");
			}
			panelsAnimatorUI[i].ResetTrigger("xp");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("itemFence");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Any");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void BEDKCKBAOKI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"(");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.FFOABBDFMNE(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				JGGBJIEJOMH(QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			LACPMHMEPHC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void LBHMFNKDBHN(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("\\[BouncerGender=[^\\]]*\\]");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("UIAddRemove");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("ReceiveSyncFoodTables");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Items/item_description_1049");
			}
			panelsAnimatorUI[i].ResetTrigger("Transfered ");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Items/item_description_681");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Received PlaceableMsg of another type not ContainerMsg to ");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void ADLBOEGDHKO(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger(" to user for reason ");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Christmas Event activated: ");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("ReceiveWorkArea");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Perk with id ");
			}
			panelsAnimatorUI[i].ResetTrigger("ReceiveChangeDrinkColorMaster");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("[Brown");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Interaction was initiated, but the object is not in range. Only possible in online.");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void LFPLHIGAEKM(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Direction");
		if (QuestHighlightUI.MNFNPNDBHOK() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.IGHMHMNPMLB(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				LPBAFDKPEHM(QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.CKHAJHCDAHC(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			LBHMFNKDBHN(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void HBHNNGKMDIF(int KHEICLKLPDE)
	{
		EDCNKEFPCID(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		MainUI.PauseGame();
	}

	[SpecialName]
	public static TestOptions EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void IKDOFGMPPBJ(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)" seconds.");
		if (QuestHighlightUI.PAHDLHGJFOM() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				LACPMHMEPHC(QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			MPENJKPDGBL(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void CANNODEKKGD(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("FloorTiles");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("quest_name_16");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Tutorial/Barn_Holly");
			}
			panelsAnimatorUI[i].ResetTrigger("LE_10");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("MainProgress");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Invalid photon ID ({0}) for the routine {1}. Its target NPC's photonID must be set in the scene.");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void NDIICCOBHKC(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("F2");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("ReceiveEmployees");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger(" ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("VERSION");
			}
			panelsAnimatorUI[i].ResetTrigger(" ");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("OnPhotonDisconnect. Clearing Steam lobbies and data.");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Received RPC SetAnimatorStateRPC with hash: 0 on {0}, so the sender was probably deactivated. This shouldn't happen anymore.\nIgnoring this command.");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void AOOMPGAKDGH(int KHEICLKLPDE)
	{
		NEKFCHILCJF(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions MAAAKALBBEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void IPBLFEIDBGN(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger(".");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("No hemos encontrado una resolución");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Player2");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("DecorationTile_5");
			}
			panelsAnimatorUI[i].ResetTrigger("Invalid playerNum");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Flight");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Dialogue System/Conversation/Gass_Introduce/Entry/20/Dialogue Text");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	[SpecialName]
	public static TestOptions JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void PBBLKMFMGPB(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"- ");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.DOGBDIOJAHO(JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				JPCHIEBJIJI(QuestLogUI.DOGBDIOJAHO(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FHBIFJNCOAI(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			AKHHMPMAAEC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			if (!IsOpen())
			{
				FocusMainPanel(-1, base.JIIGOACEIKL);
				ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
				GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			}
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void AAEEBNGHGOJ(int KHEICLKLPDE)
	{
		IFOEIDJAHFH(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void AOFCMDFCIPA(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Player/Bark/Error/NotAllPlayersHere");
		if (QuestHighlightUI.PAHDLHGJFOM() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.KJKABIBIJBD(JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				NGGHKLLEDGF(QuestLogUI.FFOABBDFMNE(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			ECEKHCDANIN(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void LKAGOGHMNOD(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"DEBUG_FAKE_ID");
		if (QuestHighlightUI.ADHBAJFBFBD() && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				DOKJOACDAOH(QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.MOMKLDLOAGD(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			AHBDGDCEFLA(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void GNALNOCJGMC(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Walk");
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.CKHAJHCDAHC(JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				NDIICCOBHKC(QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FFOABBDFMNE(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			HAIICCEMEAK(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void HGIJGHCILDA(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("DisableRightExterior");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Items/item_description_1039");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("kickedCustomers");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Object ");
			}
			panelsAnimatorUI[i].ResetTrigger("Items/item_description_653");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Failed to create a new game to host.\nPlease try again later.");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("ChangeAnim");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void BOODOFDJBNC(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Error_BarIsBlocking");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("City/Kujaku/Introduce");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("StopMusic/ButtonEndSegment");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("");
			}
			panelsAnimatorUI[i].ResetTrigger("SAVING: ");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("You have to assign a UI camera!");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("https://discord.gg/7rBtuZb");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	[SpecialName]
	public static TestOptions OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void NGGHKLLEDGF(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("GiveItem");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("itemKiwiSeeds");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("BForBook");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("[ControllerType:");
			}
			panelsAnimatorUI[i].ResetTrigger("Precision/DrinkEvent1");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("tutorial phase");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("RaraAvisDelivered");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void HOGOCGEIHAK(int KHEICLKLPDE)
	{
		NGGHKLLEDGF(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions GIKECEGLFOH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void NGONNLHBJLB(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger(", ");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("talent_name_114");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("FloorTiles");
			}
			panelsAnimatorUI[i].ResetTrigger("NotFocused");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("MineObstacleBark2");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("/Display Name");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void PPBJHMLIPJM(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("{0} HumanInfo string:\n");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("Items/item_name_705");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Style");
			}
			panelsAnimatorUI[i].ResetTrigger("LE_19");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("forest");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("You win!");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
		}
	}

	public void FocusMainPanelByCurrentPlayerUI(int KHEICLKLPDE)
	{
		FocusMainPanel(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void DOFHGPKLOHB(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("ReceiveWeatherInfo");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Talk");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Items/item_description_1102");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/UnhappyRentRoom/Entry/3/Dialogue Text");
			}
			panelsAnimatorUI[i].ResetTrigger("position");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("ActionBar6");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void HBPKEFMGLEF(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Look");
		if (QuestHighlightUI.IKNFIPPJLCB() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.FFOABBDFMNE(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				NEKFCHILCJF(QuestLogUI.CJMILOMGFJL(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.KJKABIBIJBD(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			IPBLFEIDBGN(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions GAGMPCEPONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void JONBOEINDID(int KHEICLKLPDE)
	{
		JPCHIEBJIJI(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions MOJDNGDNCCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void NJKPJGKENLJ(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"");
		if (QuestHighlightUI.NJDPGCGDCHJ() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				ADLBOEGDHKO(QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.Get(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			JPCHIEBJIJI(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions OACNNJCLEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void FOBKLMBKDBJ(int KHEICLKLPDE)
	{
		FocusMainPanel(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void CGGPJKIBHKK(int KHEICLKLPDE)
	{
		DOKJOACDAOH(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions IDIGFHEHIDM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TestOptions AAFOFNEHPLC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE && (!DecorationMode.IsAnyActive() || !Object.op_Implicit((Object)(object)SelectObject.GetPlayer(1).selectedGameObject)) && (!GameManager.LocalCoop() || !Object.op_Implicit((Object)(object)SelectObject.GetPlayer(2).selectedGameObject)))
		{
			base.OpenUI();
			if (IsOpen())
			{
				FocusMainPanel(HACEDOOFMBE, base.JIIGOACEIKL);
				ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
				GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			}
		}
	}

	[SpecialName]
	public static TestOptions HLMGBEGEAPC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void HKLHAKKLOGP(int KHEICLKLPDE)
	{
		NGGHKLLEDGF(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void PIKNAAGDPHA(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"{0} is not active.");
		if (QuestHighlightUI.PAHDLHGJFOM() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				JHOJBBIEGDP(QuestLogUI.HINOELPNLLC(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			ECEKHCDANIN(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions CFLBNDLLABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void CJELMNLKNJG(int KHEICLKLPDE)
	{
		AKHHMPMAAEC(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void EPHHDFGPEKC(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Error_TableNeedsFreeSpace");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.Get(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				DOFHGPKLOHB(QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			ECEKHCDANIN(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void PDOIICPLCCN(int KHEICLKLPDE)
	{
		AHBDGDCEFLA(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void CDHIJHLMJFO(int KHEICLKLPDE)
	{
		ECEKHCDANIN(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void MPENJKPDGBL(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Items/item_name_1446");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("RPCSetSpritesFromByteArray");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("NextItem");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("ExampleMethodSetImage");
			}
			panelsAnimatorUI[i].ResetTrigger("Items/item_description_679");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Select");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger(" ");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void PFKJHPAKFFL(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Can't find seat. Reason: CustomerEnterTime");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.IEABEDGCGHE(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (BGLJFMHCFJF())
			{
				DOKJOACDAOH(QuestLogUI.KJKABIBIJBD(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.KJKABIBIJBD(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			LACPMHMEPHC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void HAIICCEMEAK(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Sleep");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/Rowdy/Entry/4/Dialogue Text");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Listen");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("ReceiveOpenCloseTavern");
			}
			panelsAnimatorUI[i].ResetTrigger("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Player/Bark/Tutorial/CantDoYet");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("ERROR: The object ");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	[SpecialName]
	public static TestOptions CFHEJAGKIII()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void MCCFAEKLDEM(int KHEICLKLPDE)
	{
		ECEKHCDANIN(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void GNJDIOKGOLP(int KHEICLKLPDE)
	{
		NGONNLHBJLB(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void OKOJEMKPAJG(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/10/Dialogue Text");
		if (QuestHighlightUI.HLDMBJHNAPI() && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.ADHDODBKBKA(JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				BOODOFDJBNC(QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (IsOpen())
		{
			EDCNKEFPCID(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void GMMLECHPOFK(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Error_CannotPlaceTwoObjects");
		if (QuestHighlightUI.JFODJFFABCF() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				JHOJBBIEGDP(QuestLogUI.ADHDODBKBKA(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			JHOJBBIEGDP(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void FHOJOEKAKEI(int KHEICLKLPDE)
	{
		ECEKHCDANIN(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void MMLJGNIBMHD(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"OnFailStart cleaningTable");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.MOMKLDLOAGD(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				LACPMHMEPHC(QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FHBIFJNCOAI(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			HGIJGHCILDA(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void EGCLLIEENBC(int KHEICLKLPDE)
	{
		BOODOFDJBNC(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions MNFMOEKMJKN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void DDPEKFLDLDB(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"no ing");
		if (QuestHighlightUI.HLDMBJHNAPI() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.CJMILOMGFJL(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				BAOPIGMJBAI(QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.CJMILOMGFJL(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (IsOpen())
		{
			NDIICCOBHKC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void HNPGIIEACBD(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Dialogue System/Conversation/Gass_Introduce/Entry/25/Dialogue Text");
		if (QuestHighlightUI.IKNFIPPJLCB() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.DOGBDIOJAHO(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				JPCHIEBJIJI(QuestLogUI.ADHDODBKBKA(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (IsOpen())
		{
			IFOEIDJAHFH(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void EONBOMDFNPK(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"ReceiveAskHostForRoomToJoin");
		if (QuestHighlightUI.NJDPGCGDCHJ() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.CKHAJHCDAHC(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				CANNODEKKGD(QuestLogUI.CJMILOMGFJL(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FHBIFJNCOAI(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			NEKFCHILCJF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void GBEHJCINKLH(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Items/item_description_1105");
		if (QuestHighlightUI.IKNFIPPJLCB() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				KIGJICMCEIE(QuestLogUI.CJMILOMGFJL(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			JPCHIEBJIJI(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void LPBAFDKPEHM(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Pause");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("LE_11");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger(" PlayerNum: ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Right");
			}
			panelsAnimatorUI[i].ResetTrigger("DiscusionMineros/Main");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/5/Dialogue Text");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("ClosePopUp");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void BBFLOFKNGBA(int KHEICLKLPDE)
	{
		KIGJICMCEIE(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void CGGAJPDGBDK(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"OpenStats");
		if (QuestHighlightUI.HLDMBJHNAPI() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.LJONDAEOMFJ(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				DKBEEFCEDOF(QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (IsOpen())
		{
			DOFHGPKLOHB(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void CAHCPGBLNLL(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"LE_3");
		if (QuestHighlightUI.IKNFIPPJLCB() && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			if (QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				HAIICCEMEAK(QuestLogUI.Get(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.MOMKLDLOAGD(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			NEKFCHILCJF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void FPNCHIPMCGM(int KHEICLKLPDE)
	{
		LPBAFDKPEHM(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void KIGJICMCEIE(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Error_Mortar");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/CalmRowdyCustomer/Entry/1/Dialogue Text");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("\n<color=#822F00>");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("ChatCommandUnlockDescription");
			}
			panelsAnimatorUI[i].ResetTrigger("Player");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("talentShelves");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("GetOnlineObject() not found any uniqueId ");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void NCCBFFHJIOJ(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Floor_5");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.Get(JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				IFOEIDJAHFH(QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			NEKFCHILCJF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	protected override void Update()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextPage"))
		{
			if (HACEDOOFMBE < panelsAnimatorUI.Length - 1)
			{
				FocusMainPanel(HACEDOOFMBE + 1, base.JIIGOACEIKL);
			}
		}
		else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousPage") && HACEDOOFMBE > 0)
		{
			FocusMainPanel(HACEDOOFMBE - 1, base.JIIGOACEIKL);
		}
	}

	public void CBINFCNLDCN(int KHEICLKLPDE)
	{
		BOODOFDJBNC(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void MCCGKLDHCFI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Select");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.KJKABIBIJBD(JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				AHBDGDCEFLA(QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FHBIFJNCOAI(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			NDIICCOBHKC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions CHKMFEFOFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TestOptions DIHCEGINELM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void LPKFALCIEAD(int KHEICLKLPDE)
	{
		IPBLFEIDBGN(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions MAMKICHCPON()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void NFDHIIDMFOI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"");
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				LACPMHMEPHC(QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			IPBLFEIDBGN(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions MIGKKKELOJO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void FBDMPENPALJ(int KHEICLKLPDE)
	{
		AKHHMPMAAEC(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void EMFMPKNBJHG(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Items/item_name_1093");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.HINOELPNLLC(JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				DKBEEFCEDOF(QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (IsOpen())
		{
			LACPMHMEPHC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	public void DOHAKPHBALJ(int KHEICLKLPDE)
	{
		JGGBJIEJOMH(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void ODBEAIIELPP(int KHEICLKLPDE)
	{
		HAIICCEMEAK(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void CFAEMHJHFPI(int KHEICLKLPDE)
	{
		BAOPIGMJBAI(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static TestOptions KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void HHHJJOFJDMH(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"");
		if (QuestHighlightUI.PAHDLHGJFOM() && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.ADHDODBKBKA(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				LPBAFDKPEHM(QuestLogUI.HINOELPNLLC(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FHBIFJNCOAI(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			AKHHMPMAAEC(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static TestOptions LFPEPJBNCBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	public void NEKFCHILCJF(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("0");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger(" ");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("ReceiveFinishKlaynChallenge");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Hot");
			}
			panelsAnimatorUI[i].ResetTrigger(".xml");
			panelsUI[i].CloseUI();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("MaxProductValue");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("increase xp");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void ECEKHCDANIN(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("PlayerCharacterGenderChangeRPC");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("_Keybind_");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("itemShimejiMushrooms");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Accept");
			}
			panelsAnimatorUI[i].ResetTrigger("Puente_EA/Talk 1");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("ReceiveRoomRequest");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("UI2");
			panelsUI[KHEICLKLPDE].OFGKFMJKBON(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void DKBEEFCEDOF(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("itemPaleAle");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Tutorial/T135/Dialogue1");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Disconnected from network. Cause: ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("DefaultSettings");
			}
			panelsAnimatorUI[i].ResetTrigger("");
			panelsUI[i].BOBCIFEDJED();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("1");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("");
			panelsUI[KHEICLKLPDE].Open(JIIGOACEIKL);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	[SpecialName]
	public static TestOptions HFHPMKJGMPA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static TestOptions ABDJJBFNLBJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TestOptions>();
		}
		return IADEMLIIDPC;
	}
}
