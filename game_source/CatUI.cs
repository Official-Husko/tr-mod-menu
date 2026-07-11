using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CatUI : UIWindow
{
	private static CatUI[] GJBBNHCMNJN = new CatUI[3];

	public SlotUI slotUI;

	public TextMeshProUGUI birthdayTextMesh;

	public Slider slider;

	public TextInput nameInput;

	[SerializeField]
	private Image catImage;

	[SerializeField]
	private AnimalBreeds catBreeds;

	[SerializeField]
	private GameObject foodCheck;

	[SerializeField]
	private GameObject waterCheck;

	[SerializeField]
	private GameObject petCheck;

	private string[] OGGPCGFKBEN = new string[13]
	{
		"Mango", "Kiwi", "Missy", "Felix", "Salem", "Roro", "Whiskers", "Hercules", "Nemo", "Nicky",
		"Nekolas", "Nana", "Bastet"
	};

	public static CatUI ENIICLMAPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static CatUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void BGFILNDGCJI()
	{
		if (!((Object)(object)SpawnCat.PNHHCHJCDNM() == (Object)null) || !((Object)(object)SpawnCat.MKIEMMGGFEE().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.AJIGOHGPFPP().catNPC.birthday.LILCGICDMEN();
			slider.value = (float)SpawnCat.LPFNKEOJJKE().catNPC.relationshipSystem.relationshipLevel / 943f;
			((TMP_Text)nameInput.descText).text = "ClosePopUp";
			nameInput.inputField.text = CDNEEOAMHME();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.MKIEMMGGFEE().catNPC.relationshipSystem.HHHIIEMEJLC());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[DPPAPCGMLEP()].icon;
			}
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			DJJFMDHGOKN(CGBEIKHPCHL);
			FillInfo();
		}
	}

	private void FFDLHHBKGPF()
	{
		BOBCIFEDJED();
	}

	public static CatUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void PLDKAONIIDM()
	{
		if (!((Object)(object)SpawnCat.KIALFDOKABP() == (Object)null) || !((Object)(object)SpawnCat.ELGNEJNLBNO().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.DIHCEGINELM().catNPC.birthday.OHELBLMAGPP();
			slider.value = (float)SpawnCat.PNHHCHJCDNM().catNPC.relationshipSystem.relationshipLevel / 250f;
			((TMP_Text)nameInput.descText).text = "NormalLeftExterior";
			nameInput.inputField.text = BEBMIFGHEOD();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.CHPEMJMLDCN().catNPC.relationshipSystem.IMEHNPOOBDC());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[DLJDFJAAFKD()].icon;
			}
		}
	}

	private string PJOMHDEEIMJ()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	public static CatUI GFPBMGCMHHC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void NODMKGLHLMM()
	{
		if (!((Object)(object)SpawnCat.CHPEMJMLDCN() == (Object)null) || !((Object)(object)SpawnCat.DIHCEGINELM().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.PNHHCHJCDNM().catNPC.birthday.KBCEHEPDDHI();
			slider.value = (float)SpawnCat.GAGMPCEPONF().catNPC.relationshipSystem.relationshipLevel / 50f;
			((TMP_Text)nameInput.descText).text = "Dialogue System/Conversation/Gass_Quest/Entry/26/Dialogue Text";
			nameInput.inputField.text = BEBMIFGHEOD();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.DIHCEGINELM().catNPC.relationshipSystem.PMGFGDLFKDG());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[EFNNBMGNLAL()].icon;
			}
		}
	}

	private void PHLCHCCAANF()
	{
		CloseUI();
	}

	public void PGHGFNPDHCB()
	{
		if (!((Object)(object)SpawnCat.CHPEMJMLDCN() == (Object)null) || !((Object)(object)SpawnCat.CMIHGBHPLFP().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.GAGMPCEPONF().catNPC.birthday.KPNKJDPGNJK();
			slider.value = (float)SpawnCat.GJFMMOPOKGJ().catNPC.relationshipSystem.relationshipLevel / 866f;
			((TMP_Text)nameInput.descText).text = "Eat";
			nameInput.inputField.text = HDNLLFBLCDC();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.CHPEMJMLDCN().catNPC.relationshipSystem.IMEHNPOOBDC());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[ILOCOPJANEA()].icon;
			}
		}
	}

	public void PFIIOAAPIGC()
	{
		if (!((Object)(object)SpawnCat.DIHCEGINELM() == (Object)null) || !((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.AJIGOHGPFPP().catNPC.birthday.KPNKJDPGNJK();
			slider.value = (float)SpawnCat.MKIEMMGGFEE().catNPC.relationshipSystem.relationshipLevel / 219f;
			((TMP_Text)nameInput.descText).text = "";
			nameInput.inputField.text = ELBEENPNABF();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.LPFNKEOJJKE().catNPC.relationshipSystem.FCLNEOMGDAN());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[MKLOLNCIFEG()].icon;
			}
		}
	}

	private void ODHPCMKJIOK()
	{
		CloseUI();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)nameInput.inputField);
		}
	}

	private string BECHNADBEEH()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private int FBHLKPAEBIB()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			180 => 0, 
			181 => 1, 
			182 => 6, 
			183 => 2, 
			184 => 2, 
			185 => 2, 
			_ => 0, 
		};
	}

	public void CHKIEBNKLHL()
	{
		if (!((Object)(object)SpawnCat.CHPEMJMLDCN() == (Object)null) || !((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.CMIHGBHPLFP().catNPC.birthday.BKCGGLLLBCD();
			slider.value = (float)SpawnCat.CMIHGBHPLFP().catNPC.relationshipSystem.relationshipLevel / 1646f;
			((TMP_Text)nameInput.descText).text = " without doWork attached to OnlineObject";
			nameInput.inputField.text = HNIDPPGEJIN();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.KIALFDOKABP().catNPC.relationshipSystem.GLBLGPJFAPB());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[FAHKHDKAKFN()].icon;
			}
		}
	}

	private void NJJFGJGIKMO()
	{
		CloseUI();
	}

	public static CatUI PPJMPMKLCME(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private int DPPAPCGMLEP()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			183 => 1, 
			184 => 1, 
			185 => 8, 
			186 => 4, 
			187 => 3, 
			188 => 8, 
			_ => 0, 
		};
	}

	public static CatUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private int CNAKBDPBCJE()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			117 => 0, 
			118 => 0, 
			119 => 0, 
			120 => 0, 
			121 => 2, 
			122 => 2, 
			_ => 0, 
		};
	}

	private int AAHOJONNKKE()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			-173 => 0, 
			-172 => 0, 
			-171 => 8, 
			-170 => 4, 
			-169 => 0, 
			-168 => 6, 
			_ => 0, 
		};
	}

	private int DLJDFJAAFKD()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			178 => 0, 
			179 => 0, 
			180 => 8, 
			181 => 2, 
			182 => 6, 
			183 => 8, 
			_ => 1, 
		};
	}

	private int NEJDOAGGOBI()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			400 => 0, 
			401 => 1, 
			402 => 2, 
			403 => 3, 
			404 => 4, 
			405 => 5, 
			_ => 0, 
		};
	}

	private string MIMCMCGFAGN()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private string CADCKEJODEI()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	public static CatUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static CatUI EKEDKKKPAEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void GGGKHLJLCJA()
	{
		if (!((Object)(object)SpawnCat.GAGMPCEPONF() == (Object)null) || !((Object)(object)SpawnCat.MKIEMMGGFEE().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.AJIGOHGPFPP().catNPC.birthday.KBCEHEPDDHI();
			slider.value = (float)SpawnCat.GJFMMOPOKGJ().catNPC.relationshipSystem.relationshipLevel / 1196f;
			((TMP_Text)nameInput.descText).text = "/Player.log";
			nameInput.inputField.text = JBHCJEKDMCP();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.PNHHCHJCDNM().catNPC.relationshipSystem.AKMMPOBHEOC());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[EJNKHLDIJMO()].icon;
			}
		}
	}

	public static CatUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void JOBPBLBLNKB()
	{
		if (!((Object)(object)SpawnCat.CHPEMJMLDCN() == (Object)null) || !((Object)(object)SpawnCat.DIHCEGINELM().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.CMIHGBHPLFP().catNPC.birthday.DAEKAMPDAJH();
			slider.value = (float)SpawnCat.LPFNKEOJJKE().catNPC.relationshipSystem.relationshipLevel / 1835f;
			((TMP_Text)nameInput.descText).text = "ReceiveFillFountain";
			nameInput.inputField.text = MFHPEKLGIHD();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.GAGMPCEPONF().catNPC.relationshipSystem.DKAGLEFKCJE());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[EJNKHLDIJMO()].icon;
			}
		}
	}

	public static CatUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void HBIONMJELMM()
	{
		BOBCIFEDJED();
	}

	public void HBDJKAHMDMJ()
	{
		if (!((Object)(object)SpawnCat.MKIEMMGGFEE() == (Object)null) || !((Object)(object)SpawnCat.KIALFDOKABP().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.DIHCEGINELM().catNPC.birthday.FMCPFNCIJAB();
			slider.value = (float)SpawnCat.CHPEMJMLDCN().catNPC.relationshipSystem.relationshipLevel / 1018f;
			((TMP_Text)nameInput.descText).text = "psai [{0}]: Trigger fired: {1}";
			nameInput.inputField.text = CECIPCMNPAM();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.PNHHCHJCDNM().catNPC.relationshipSystem.FCLNEOMGDAN());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[GLFCPEOEALK()].icon;
			}
		}
	}

	private string DKHGKFHOGNG()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private string CDNEEOAMHME()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	private string HEBABDGACDM()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIBack"))
		{
			CloseUI();
		}
	}

	private void EAIMHIDMANH()
	{
		BOBCIFEDJED();
	}

	private int KEDDAMMKNDP()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			-132 => 1, 
			-131 => 1, 
			-130 => 4, 
			-129 => 7, 
			-128 => 2, 
			-127 => 7, 
			_ => 1, 
		};
	}

	public static CatUI EGBMJGOCIJJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void NPNCBAFDOIN()
	{
		if (!((Object)(object)SpawnCat.GJFMMOPOKGJ() == (Object)null) || !((Object)(object)SpawnCat.LPFNKEOJJKE().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.PNHHCHJCDNM().catNPC.birthday.DAEKAMPDAJH();
			slider.value = (float)SpawnCat.DIHCEGINELM().catNPC.relationshipSystem.relationshipLevel / 1383f;
			((TMP_Text)nameInput.descText).text = "Dialogue System/Conversation/Crowly_Standar/Entry/16/Dialogue Text";
			nameInput.inputField.text = EKIOKGDBJGJ();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.DIHCEGINELM().catNPC.relationshipSystem.GLBLGPJFAPB());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[OGLPOHOMGGD()].icon;
			}
		}
	}

	private int MDKIPDBIICG()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			1 => 1, 
			2 => 1, 
			3 => 3, 
			4 => 1, 
			5 => 6, 
			6 => 0, 
			_ => 1, 
		};
	}

	private string MIKKONOHCBF()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	private int BEIPHMHFMPF()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			176 => 1, 
			177 => 1, 
			178 => 5, 
			179 => 3, 
			180 => 3, 
			181 => 4, 
			_ => 1, 
		};
	}

	private string ELBEENPNABF()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	public static CatUI ADHDODBKBKA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private int HNLIBPGAHJE()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			-122 => 1, 
			-121 => 1, 
			-120 => 4, 
			-119 => 6, 
			-118 => 2, 
			-117 => 4, 
			_ => 1, 
		};
	}

	private int EFNNBMGNLAL()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			-102 => 0, 
			-101 => 1, 
			-100 => 4, 
			-99 => 7, 
			-98 => 6, 
			-97 => 4, 
			_ => 0, 
		};
	}

	public static CatUI FBKOKJCKICN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void DAEGOOLKPIB()
	{
		BOBCIFEDJED();
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			CommonReferences.GGFJGHHHEJC.catName = nameInput.inputField.text;
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			if (GameManager.SinglePlayerOffline())
			{
				MainUI.ResumeGame();
			}
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
		}
	}

	private int CDJLNJNKMLC()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			166 => 0, 
			167 => 0, 
			168 => 0, 
			169 => 4, 
			170 => 1, 
			171 => 7, 
			_ => 0, 
		};
	}

	public void FPLJKMGHCGN()
	{
		if (!((Object)(object)SpawnCat.AJIGOHGPFPP() == (Object)null) || !((Object)(object)SpawnCat.GJFMMOPOKGJ().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.AJIGOHGPFPP().catNPC.birthday.BKCGGLLLBCD();
			slider.value = (float)SpawnCat.LPFNKEOJJKE().catNPC.relationshipSystem.relationshipLevel / 1119f;
			((TMP_Text)nameInput.descText).text = "Tutorial/T137/Dialogue1";
			nameInput.inputField.text = HNIDPPGEJIN();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.GGFJGHHHEJC.catNPC.relationshipSystem.EJEIJDFAGBM());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[OGLPOHOMGGD()].icon;
			}
		}
	}

	private string BEBMIFGHEOD()
	{
		if (string.IsNullOrEmpty(CommonReferences.MNFMOEKMJKN().catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	public void DNAKECBOLPO()
	{
		if (!((Object)(object)SpawnCat.AJIGOHGPFPP() == (Object)null) || !((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.GJFMMOPOKGJ().catNPC.birthday.FKNHELFHMNJ();
			slider.value = (float)SpawnCat.KIALFDOKABP().catNPC.relationshipSystem.relationshipLevel / 1010f;
			((TMP_Text)nameInput.descText).text = "letter";
			nameInput.inputField.text = HEBABDGACDM();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.ELGNEJNLBNO().catNPC.relationshipSystem.AILFGGBDGPJ());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[BEABHNEFJAL()].icon;
			}
		}
	}

	private int AIEEFKDIIGN()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			-80 => 1, 
			-79 => 1, 
			-78 => 2, 
			-77 => 8, 
			-76 => 1, 
			-75 => 5, 
			_ => 0, 
		};
	}

	private void EEJEMAKOOFJ()
	{
		CloseUI();
	}

	public void AHGKPCDIMFA()
	{
		if (!((Object)(object)SpawnCat.MKIEMMGGFEE() == (Object)null) || !((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.GAGMPCEPONF().catNPC.birthday.OHELBLMAGPP();
			slider.value = (float)SpawnCat.CHPEMJMLDCN().catNPC.relationshipSystem.relationshipLevel / 231f;
			((TMP_Text)nameInput.descText).text = "Cellar";
			nameInput.inputField.text = CDNEEOAMHME();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.CHPEMJMLDCN().catNPC.relationshipSystem.FCLNEOMGDAN());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[IKFIPPACDGI()].icon;
			}
		}
	}

	public static CatUI EOPIEMLAPFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private int MKLOLNCIFEG()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			-71 => 1, 
			-70 => 0, 
			-69 => 7, 
			-68 => 7, 
			-67 => 2, 
			-66 => 5, 
			_ => 1, 
		};
	}

	public void DEGODAEKKGM()
	{
		if (!((Object)(object)SpawnCat.DIHCEGINELM() == (Object)null) || !((Object)(object)SpawnCat.AJIGOHGPFPP().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.GAGMPCEPONF().catNPC.birthday.OPKIMBACIHA();
			slider.value = (float)SpawnCat.GJFMMOPOKGJ().catNPC.relationshipSystem.relationshipLevel / 1761f;
			((TMP_Text)nameInput.descText).text = "NormalRightExterior";
			nameInput.inputField.text = PJOMHDEEIMJ();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.AJIGOHGPFPP().catNPC.relationshipSystem.GLBLGPJFAPB());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[FAHKHDKAKFN()].icon;
			}
		}
	}

	public void OBJOBMBIHKB()
	{
		if (!((Object)(object)SpawnCat.PNHHCHJCDNM() == (Object)null) || !((Object)(object)SpawnCat.KIALFDOKABP().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.CMIHGBHPLFP().catNPC.birthday.LILCGICDMEN();
			slider.value = (float)SpawnCat.AJIGOHGPFPP().catNPC.relationshipSystem.relationshipLevel / 1468f;
			((TMP_Text)nameInput.descText).text = "Tutorial/T128/Dialogue2";
			nameInput.inputField.text = MIMCMCGFAGN();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.MKIEMMGGFEE().catNPC.relationshipSystem.DailyPetDone());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[BEABHNEFJAL()].icon;
			}
		}
	}

	private void CGBEIKHPCHL()
	{
		CloseUI();
	}

	private string EKIOKGDBJGJ()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private void EIMIELCGLME()
	{
		CloseUI();
	}

	public static CatUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static CatUI MHOKIBDMIPL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void FDBMAIEBING()
	{
		if (!((Object)(object)SpawnCat.GGFJGHHHEJC == (Object)null) || !((Object)(object)SpawnCat.NEFIEJALANL().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.ELGNEJNLBNO().catNPC.birthday.FMCPFNCIJAB();
			slider.value = (float)SpawnCat.NEFIEJALANL().catNPC.relationshipSystem.relationshipLevel / 224f;
			((TMP_Text)nameInput.descText).text = "The mine piece ";
			nameInput.inputField.text = MIKKONOHCBF();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.NEFIEJALANL().catNPC.relationshipSystem.PMGFGDLFKDG());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[NCPMDIHCOKL()].icon;
			}
		}
	}

	public static CatUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void OLBBHPACLDO()
	{
		CloseUI();
	}

	private string HJKOCOFKDPA()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	private string OGEHECDNHMB()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	public void ECNPLEICHCB()
	{
		if (!((Object)(object)SpawnCat.CHPEMJMLDCN() == (Object)null) || !((Object)(object)SpawnCat.KIALFDOKABP().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.NEFIEJALANL().catNPC.birthday.OHELBLMAGPP();
			slider.value = (float)SpawnCat.GAGMPCEPONF().catNPC.relationshipSystem.relationshipLevel / 1478f;
			((TMP_Text)nameInput.descText).text = "Tutorial/T137/Dialogue2";
			nameInput.inputField.text = CECIPCMNPAM();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.PNHHCHJCDNM().catNPC.relationshipSystem.EJEIJDFAGBM());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[DMHNJMFABGH()].icon;
			}
		}
	}

	public static CatUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void IELDAMFIBJG()
	{
		CloseUI();
	}

	public static CatUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private string JKPKGEHCDLL()
	{
		if (string.IsNullOrEmpty(CommonReferences.MNFMOEKMJKN().catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private int OGLPOHOMGGD()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			35 => 1, 
			36 => 1, 
			37 => 8, 
			38 => 5, 
			39 => 4, 
			40 => 4, 
			_ => 1, 
		};
	}

	private int FAHKHDKAKFN()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			141 => 0, 
			142 => 1, 
			143 => 5, 
			144 => 6, 
			145 => 1, 
			146 => 8, 
			_ => 1, 
		};
	}

	private void PJCJBJNOBDC()
	{
		BOBCIFEDJED();
	}

	public static CatUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static CatUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private int DMHNJMFABGH()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			23 => 0, 
			24 => 0, 
			25 => 0, 
			26 => 1, 
			27 => 7, 
			28 => 0, 
			_ => 0, 
		};
	}

	private string JBHCJEKDMCP()
	{
		if (string.IsNullOrEmpty(CommonReferences.MNFMOEKMJKN().catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private int ILOCOPJANEA()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			-195 => 1, 
			-194 => 0, 
			-193 => 1, 
			-192 => 7, 
			-191 => 0, 
			-190 => 8, 
			_ => 0, 
		};
	}

	public void FillInfo()
	{
		if (!((Object)(object)SpawnCat.GGFJGHHHEJC == (Object)null) || !((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.GGFJGHHHEJC.catNPC.birthday.KBCEHEPDDHI();
			slider.value = (float)SpawnCat.GGFJGHHHEJC.catNPC.relationshipSystem.relationshipLevel / 100f;
			((TMP_Text)nameInput.descText).text = "";
			nameInput.inputField.text = MIKKONOHCBF();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.GGFJGHHHEJC.catNPC.relationshipSystem.DailyPetDone());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[NEJDOAGGOBI()].icon;
			}
		}
	}

	private int GLFCPEOEALK()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			42 => 1, 
			43 => 1, 
			44 => 2, 
			45 => 7, 
			46 => 1, 
			47 => 5, 
			_ => 1, 
		};
	}

	public static CatUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private int IDEAMJAIOJD()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			-119 => 1, 
			-118 => 1, 
			-117 => 6, 
			-116 => 6, 
			-115 => 0, 
			-114 => 0, 
			_ => 0, 
		};
	}

	private void OOMJCPJEJEA()
	{
		CloseUI();
	}

	private string HJNDCPPNJBH()
	{
		if (string.IsNullOrEmpty(CommonReferences.MNFMOEKMJKN().catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private int EJNKHLDIJMO()
	{
		return CommonReferences.GGFJGHHHEJC.catSelected.id switch
		{
			-176 => 0, 
			-175 => 0, 
			-174 => 0, 
			-173 => 2, 
			-172 => 5, 
			-171 => 5, 
			_ => 0, 
		};
	}

	private void KGIACKKFILH()
	{
		BOBCIFEDJED();
	}

	private void CPMBJEFLKMI()
	{
		BOBCIFEDJED();
	}

	private int BEABHNEFJAL()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			114 => 0, 
			115 => 0, 
			116 => 1, 
			117 => 8, 
			118 => 4, 
			119 => 7, 
			_ => 1, 
		};
	}

	public void EECGBBPJJKI()
	{
		if (!((Object)(object)SpawnCat.KIALFDOKABP() == (Object)null) || !((Object)(object)SpawnCat.MKIEMMGGFEE().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.MKIEMMGGFEE().catNPC.birthday.KBCEHEPDDHI();
			slider.value = (float)SpawnCat.CHPEMJMLDCN().catNPC.relationshipSystem.relationshipLevel / 600f;
			((TMP_Text)nameInput.descText).text = "Transform";
			nameInput.inputField.text = OGEHECDNHMB();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.GJFMMOPOKGJ().catNPC.relationshipSystem.MJJLMLCHAHD());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[DLJDFJAAFKD()].icon;
			}
		}
	}

	private string CECIPCMNPAM()
	{
		if (string.IsNullOrEmpty(CommonReferences.MNFMOEKMJKN().catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	public void DAMHALOBJDL()
	{
		if (!((Object)(object)SpawnCat.KIALFDOKABP() == (Object)null) || !((Object)(object)SpawnCat.AJIGOHGPFPP().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.DIHCEGINELM().catNPC.birthday.KBCEHEPDDHI();
			slider.value = (float)SpawnCat.ELGNEJNLBNO().catNPC.relationshipSystem.relationshipLevel / 801f;
			((TMP_Text)nameInput.descText).text = "Intro16";
			nameInput.inputField.text = HJKOCOFKDPA();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.CMIHGBHPLFP().catNPC.relationshipSystem.HHHIIEMEJLC());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[EJNKHLDIJMO()].icon;
			}
		}
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
	}

	public void JBMLLEFNPNO()
	{
		if (!((Object)(object)SpawnCat.MKIEMMGGFEE() == (Object)null) || !((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.AJIGOHGPFPP().catNPC.birthday.KBCEHEPDDHI();
			slider.value = (float)SpawnCat.CHPEMJMLDCN().catNPC.relationshipSystem.relationshipLevel / 615f;
			((TMP_Text)nameInput.descText).text = "\n";
			nameInput.inputField.text = HJNDCPPNJBH();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.CMIHGBHPLFP().catNPC.relationshipSystem.FCLNEOMGDAN());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[IKFIPPACDGI()].icon;
			}
		}
	}

	public void EFEOOEONDIP()
	{
		if (!((Object)(object)SpawnCat.ELGNEJNLBNO() == (Object)null) || !((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.GAGMPCEPONF().catNPC.birthday.FMCPFNCIJAB();
			slider.value = (float)SpawnCat.GGFJGHHHEJC.catNPC.relationshipSystem.relationshipLevel / 73f;
			((TMP_Text)nameInput.descText).text = "LE_2";
			nameInput.inputField.text = JBHCJEKDMCP();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.DIHCEGINELM().catNPC.relationshipSystem.FCLNEOMGDAN());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[ILOCOPJANEA()].icon;
			}
		}
	}

	public void GGNGINOOEIB()
	{
		if (!((Object)(object)SpawnCat.PNHHCHJCDNM() == (Object)null) || !((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.KIALFDOKABP().catNPC.birthday.KPNKJDPGNJK();
			slider.value = (float)SpawnCat.PNHHCHJCDNM().catNPC.relationshipSystem.relationshipLevel / 718f;
			((TMP_Text)nameInput.descText).text = "Dialogue System/Conversation/Crowly_Introduce/Entry/18/Dialogue Text";
			nameInput.inputField.text = CDNEEOAMHME();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false));
			petCheck.SetActive(SpawnCat.DIHCEGINELM().catNPC.relationshipSystem.AOPFPGPLFLA());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[FBHLKPAEBIB()].icon;
			}
		}
	}

	private int NCPMDIHCOKL()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			123 => 1, 
			124 => 1, 
			125 => 7, 
			126 => 8, 
			127 => 2, 
			128 => 7, 
			_ => 0, 
		};
	}

	private void DNMAHEEHHJE()
	{
		CloseUI();
	}

	private string EIGILBGFEOF()
	{
		if (string.IsNullOrEmpty(CommonReferences.MNFMOEKMJKN().catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	private string HDNLLFBLCDC()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.MNFMOEKMJKN().catName;
	}

	public void EIDAACLJLAJ()
	{
		if (!((Object)(object)SpawnCat.CHPEMJMLDCN() == (Object)null) || !((Object)(object)SpawnCat.KIALFDOKABP().catNPC == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = SpawnCat.DIHCEGINELM().catNPC.birthday.OHELBLMAGPP();
			slider.value = (float)SpawnCat.DIHCEGINELM().catNPC.relationshipSystem.relationshipLevel / 1892f;
			((TMP_Text)nameInput.descText).text = "Dialogue System/Conversation/Crowly_Standar/Entry/48/Dialogue Text";
			nameInput.inputField.text = MIMCMCGFAGN();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true));
			petCheck.SetActive(SpawnCat.LPFNKEOJJKE().catNPC.relationshipSystem.EJEIJDFAGBM());
			if ((Object)(object)catBreeds != (Object)null && (Object)(object)catImage != (Object)null)
			{
				catImage.sprite = catBreeds.breeds[BEIPHMHFMPF()].icon;
			}
		}
	}

	public static CatUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private string HNIDPPGEJIN()
	{
		if (string.IsNullOrEmpty(CommonReferences.MNFMOEKMJKN().catName))
		{
			return OGGPCGFKBEN[Random.Range(0, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	private int IKFIPPACDGI()
	{
		return CommonReferences.MNFMOEKMJKN().catSelected.id switch
		{
			-115 => 0, 
			-114 => 1, 
			-113 => 6, 
			-112 => 1, 
			-111 => 2, 
			-110 => 3, 
			_ => 0, 
		};
	}

	private void OAJPHBOIOGL()
	{
		CloseUI();
	}

	public static CatUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private string MFHPEKLGIHD()
	{
		if (string.IsNullOrEmpty(CommonReferences.GGFJGHHHEJC.catName))
		{
			return OGGPCGFKBEN[Random.Range(1, OGGPCGFKBEN.Length)];
		}
		return CommonReferences.GGFJGHHHEJC.catName;
	}

	private void MAHCGLOJANP()
	{
		CloseUI();
	}

	private void AJHFGOPKLJH()
	{
		CloseUI();
	}
}
