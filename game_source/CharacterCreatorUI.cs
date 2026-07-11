using System;
using System.Collections;
using Galaxy.Api;
using Sirenix.Utilities;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreatorUI : UIWindow
{
	private static CharacterCreatorUI[] GJBBNHCMNJN = new CharacterCreatorUI[3];

	public Action OnCharacterConfirm = delegate
	{
	};

	public CharacterCreator characterCreator;

	public CharacterAnimation characterAnimation;

	[SerializeField]
	private ColorButton[] colorButtons;

	[SerializeField]
	private TMP_InputField nameInput;

	[SerializeField]
	private TMP_InputField tavernInput;

	[SerializeField]
	private Image transparentImage;

	[SerializeField]
	private Image femaleFocused;

	[SerializeField]
	private Image maleFocused;

	[SerializeField]
	private GameObject[] maleGameObjectsToActivate;

	[SerializeField]
	private GameObject[] femaleGameObjectsToActivate;

	[SerializeField]
	private CharacterCreatorBodyPartText[] textsBodyParts;

	private float CMGDCLIIONE;

	private bool KBPGGKMPKHL;

	[HideInInspector]
	public static SaveData loadGame;

	[HideInInspector]
	public static string loadFilename;

	public GameObject[] cancelButton;

	public bool firstStart;

	private CharacterSprite[] KBJLPGNLCKA = new CharacterSprite[40];

	private bool POFGNGIEOGM;

	public void SetMaleGender()
	{
		if (characterCreator.JJDDMDIPGGC)
		{
			characterCreator.SetMaleGender();
			characterCreator.RandomMasc(GADKADLHDGJ: true);
		}
		else
		{
			characterCreator.SetMaleGender();
		}
		GJBGLIGCIKM(Gender.Male);
		CGMIECOLFKL(characterCreator.humanInfo.gender);
	}

	private void KGGFDJKFBAH(int JIIGOACEIKL)
	{
		if (IsOpen() && JIIGOACEIKL != base.JIIGOACEIKL)
		{
			PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).BDMFGOGAFGC("HouseKeeper");
		}
	}

	private void MOHLOLHLFBH()
	{
		if (!characterCreator.initialized)
		{
			characterCreator.Initialize();
		}
		SetMaleGender();
		if (base.JIIGOACEIKL == 2)
		{
			if (GameManager.GGFJGHHHEJC.character2Saved)
			{
				characterCreator.LoadCharacter(CommonReferences.GGFJGHHHEJC.player2CharacterSave);
			}
			else
			{
				characterCreator.RandomCharacter(GCANBIEGDOA: false);
			}
		}
		else
		{
			if (!PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.initialized)
			{
				PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.Initialize();
			}
			HumanInfo kDMNEEPDENI = ((!Utils.FFLNGLMHLBO()) ? PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.humanInfo : ((PlayerController.GetPlayer(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null) ? PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.humanInfo : PlayerController.GetPlayer(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin));
			characterCreator.CopyCreator(kDMNEEPDENI);
		}
		EEGKEGOFHCA();
		characterCreator.characterAnimation.SetDirection(Direction.Down);
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		try
		{
			if (base.JIIGOACEIKL == 1)
			{
				if (StringExtensions.IsNullOrWhitespace(PlayerInfo.HBILFLLKHGP))
				{
					if (SteamManager.BNBMMDGMKLM)
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName());
					}
					else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName());
					}
					else
					{
						nameInput.text = PlayerInfo.HBILFLLKHGP;
					}
				}
				else
				{
					nameInput.text = PlayerInfo.HBILFLLKHGP;
				}
			}
			else if (StringExtensions.IsNullOrWhitespace(PlayerInfo.KGDAOACEMJO))
			{
				if (SteamManager.BNBMMDGMKLM)
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName()) + " 2";
				}
				else if (GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName()) + " 2";
				}
				else
				{
					nameInput.text = PlayerInfo.KGDAOACEMJO;
				}
			}
			else
			{
				nameInput.text = PlayerInfo.KGDAOACEMJO;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error setting player name on CharacterCreatorUI: " + ex.Message));
		}
		try
		{
			if (StringExtensions.IsNullOrWhitespace(PlayerInfo.tavernName))
			{
				tavernInput.text = nameInput.text + "'s Tavern";
			}
			else
			{
				tavernInput.text = PlayerInfo.tavernName;
			}
			if (base.JIIGOACEIKL == 1)
			{
				((Selectable)tavernInput).interactable = true;
				((Component)tavernInput).GetComponent<Animator>().SetTrigger("Normal");
			}
			else
			{
				((Selectable)tavernInput).interactable = false;
			}
		}
		catch (Exception ex2)
		{
			Debug.LogError((object)("Error setting tavern name on CharacterCreatorUI: " + ex2.Message));
		}
		characterCreator.characterAnimation.FCGBJEIIMBC = Direction.Down;
		KBPGGKMPKHL = true;
	}

	private void FDHBPPOELAA()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BNFLJFFKMMN((Selectable)(object)colorButtons[0].button);
		}
	}

	private void OOEMCANKFKC()
	{
		for (int i = 1; i < colorButtons.Length; i++)
		{
			bool active = false;
			CharacterSprite characterSprite = characterCreator.humanInfo.CONPDKDNOBO(colorButtons[i].bodyPart);
			if ((Object)(object)characterSprite != (Object)null)
			{
				active = characterSprite.IHDDLCLJIEM(colorButtons[i].layer, MNEFABJOBFA: true);
			}
			((Component)colorButtons[i]).gameObject.SetActive(active);
		}
	}

	public void KEPPHBACAFP(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Shoes, EJMFJABBJDF);
	}

	private void BGNMDNEMMNA()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).NCGCKHGOJCM((Selectable)(object)colorButtons[0].button);
		}
	}

	private void BMFLGIPECKH()
	{
		if (!characterCreator.initialized)
		{
			characterCreator.EBIDJHHEMJP();
		}
		SetMaleGender();
		if (base.JIIGOACEIKL == 3)
		{
			if (GameManager.NJNFHEPLEHL().character2Saved)
			{
				characterCreator.GMHJOPNIGMJ(CommonReferences.MNFMOEKMJKN().player2CharacterSave);
			}
			else
			{
				characterCreator.OEBDHLPOHEE(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			}
		}
		else
		{
			if (!PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.initialized)
			{
				PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.Initialize();
			}
			HumanInfo kDMNEEPDENI = ((!Utils.FFLNGLMHLBO()) ? PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.humanInfo : ((PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null) ? PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.humanInfo : PlayerController.GetPlayer(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin));
			characterCreator.ALCCBILFPMK(kDMNEEPDENI);
		}
		EEGKEGOFHCA();
		characterCreator.characterAnimation.SetDirection(Direction.Down);
		Sound.GGFJGHHHEJC.LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1333f);
		try
		{
			if (base.JIIGOACEIKL == 0)
			{
				if (StringExtensions.IsNullOrWhitespace(PlayerInfo.OMNPAJOOOKO()))
				{
					if (SteamManager.BNBMMDGMKLM)
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName());
					}
					else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName());
					}
					else
					{
						nameInput.text = PlayerInfo.DLHDCFGMPCA();
					}
				}
				else
				{
					nameInput.text = PlayerInfo.GIHPMGBPMLC();
				}
			}
			else if (StringExtensions.IsNullOrWhitespace(PlayerInfo.EIHPOCHIMLM()))
			{
				if (SteamManager.BNBMMDGMKLM)
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName()) + "Eat";
				}
				else if (GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName()) + "You Lose";
				}
				else
				{
					nameInput.text = PlayerInfo.CKAIIAAKCNA();
				}
			}
			else
			{
				nameInput.text = PlayerInfo.HJGEJINMGIK();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Grass" + ex.Message));
		}
		try
		{
			if (StringExtensions.IsNullOrWhitespace(PlayerInfo.tavernName))
			{
				tavernInput.text = nameInput.text + "Items/item_name_1063";
			}
			else
			{
				tavernInput.text = PlayerInfo.tavernName;
			}
			if (base.JIIGOACEIKL == 0)
			{
				((Selectable)tavernInput).interactable = false;
				((Component)tavernInput).GetComponent<Animator>().SetTrigger("ReceiveCancelAllCrafting");
			}
			else
			{
				((Selectable)tavernInput).interactable = false;
			}
		}
		catch (Exception ex2)
		{
			Debug.LogError((object)("Character Save Error Detected" + ex2.Message));
		}
		characterCreator.characterAnimation.FCGBJEIIMBC = Direction.Up;
		KBPGGKMPKHL = true;
	}

	private void PIMPIPPOIKE()
	{
		if (!characterCreator.initialized)
		{
			characterCreator.Initialize();
		}
		HMOFLKAAGKL();
		if (base.JIIGOACEIKL == 4)
		{
			if (GameManager.NJNFHEPLEHL().character2Saved)
			{
				characterCreator.GMHJOPNIGMJ(CommonReferences.MNFMOEKMJKN().player2CharacterSave);
			}
			else
			{
				characterCreator.BAMEGNNLCFD(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
			}
		}
		else
		{
			if (!PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.initialized)
			{
				PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.EBIDJHHEMJP();
			}
			HumanInfo kDMNEEPDENI = ((!Utils.FFLNGLMHLBO()) ? PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.humanInfo : ((PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null) ? PlayerController.GetPlayer(base.JIIGOACEIKL).characterCreator.humanInfo : PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin));
			characterCreator.CopyCreator(kDMNEEPDENI);
		}
		EEGKEGOFHCA();
		characterCreator.characterAnimation.SetDirection(Direction.Up);
		Sound.MAIDHAPANEB().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowOpen), HOMFPAFAOGD: false, null, null, 468f);
		try
		{
			if (base.JIIGOACEIKL == 0)
			{
				if (StringExtensions.IsNullOrWhitespace(PlayerInfo.OFKJBCHKBCG()))
				{
					if (SteamManager.BNBMMDGMKLM)
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName());
					}
					else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName());
					}
					else
					{
						nameInput.text = PlayerInfo.AAHBADJONON();
					}
				}
				else
				{
					nameInput.text = PlayerInfo.HAPFMLBBJMK();
				}
			}
			else if (StringExtensions.IsNullOrWhitespace(PlayerInfo.PNANIHDHLNM()))
			{
				if (SteamManager.BNBMMDGMKLM)
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName()) + "ReceiveFormQuestInfo";
				}
				else if (GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName()) + "Interact";
				}
				else
				{
					nameInput.text = PlayerInfo.INJILLIIEDI();
				}
			}
			else
			{
				nameInput.text = PlayerInfo.JMLCJBEHKGC();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("BeginChatFade" + ex.Message));
		}
		try
		{
			if (StringExtensions.IsNullOrWhitespace(PlayerInfo.tavernName))
			{
				tavernInput.text = nameInput.text + "Top";
			}
			else
			{
				tavernInput.text = PlayerInfo.tavernName;
			}
			if (base.JIIGOACEIKL == 0)
			{
				((Selectable)tavernInput).interactable = true;
				((Component)tavernInput).GetComponent<Animator>().SetTrigger("DecorationTile_5");
			}
			else
			{
				((Selectable)tavernInput).interactable = false;
			}
		}
		catch (Exception ex2)
		{
			Debug.LogError((object)("MinimisePopUp" + ex2.Message));
		}
		characterCreator.characterAnimation.FCGBJEIIMBC = Direction.Up;
		KBPGGKMPKHL = false;
	}

	private void BNDDDEENGKF(int JIIGOACEIKL)
	{
		((Component)transparentImage).gameObject.SetActive(false);
		MainUI.AFOLANEJMBF(DHJFAGNJKOF: true);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(OHKJOCIOJFC));
	}

	public void JDICGLBANLA(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Torso, EJMFJABBJDF);
	}

	private void BFAPFLCJAHM()
	{
		if (!characterCreator.initialized)
		{
			characterCreator.Initialize();
		}
		HMOFLKAAGKL();
		if (base.JIIGOACEIKL == 4)
		{
			if (GameManager.NJNFHEPLEHL().character2Saved)
			{
				characterCreator.LoadCharacter(CommonReferences.GGFJGHHHEJC.player2CharacterSave);
			}
			else
			{
				characterCreator.BAMEGNNLCFD(GCANBIEGDOA: false, GADKADLHDGJ: true, JHIFLALPEBF: true);
			}
		}
		else
		{
			if (!PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.initialized)
			{
				PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.Initialize();
			}
			HumanInfo kDMNEEPDENI = ((!Utils.FFLNGLMHLBO()) ? PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.humanInfo : ((PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin == null) ? PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).characterCreator.humanInfo : PlayerController.GetPlayer(base.JIIGOACEIKL).characterSaveBeforeHalloweenSkin));
			characterCreator.ALCCBILFPMK(kDMNEEPDENI);
		}
		JONPEFEPDBC();
		characterCreator.characterAnimation.SetDirection(Direction.Down);
		Sound.GGFJGHHHEJC.CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiWindowOpen), HOMFPAFAOGD: true, null, null, 708f);
		try
		{
			if (base.JIIGOACEIKL == 0)
			{
				if (StringExtensions.IsNullOrWhitespace(PlayerInfo.CAIAAGKEDKJ()))
				{
					if (SteamManager.BNBMMDGMKLM)
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName());
					}
					else if (GalaxyInstance.User() != null && GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
					{
						nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName());
					}
					else
					{
						nameInput.text = PlayerInfo.AOHODGAIOAJ();
					}
				}
				else
				{
					nameInput.text = PlayerInfo.KNPFHOPLFKD();
				}
			}
			else if (StringExtensions.IsNullOrWhitespace(PlayerInfo.PHIDHHIFLBG()))
			{
				if (SteamManager.BNBMMDGMKLM)
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName()) + " ";
				}
				else if (GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
				{
					nameInput.text = InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName()) + "LE_13";
				}
				else
				{
					nameInput.text = PlayerInfo.JFKJFLGLNEJ();
				}
			}
			else
			{
				nameInput.text = PlayerInfo.EIELJGOIFIG();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ScrollView" + ex.Message));
		}
		try
		{
			if (StringExtensions.IsNullOrWhitespace(PlayerInfo.tavernName))
			{
				tavernInput.text = nameInput.text + "BathhouseEntrace/Main 3";
			}
			else
			{
				tavernInput.text = PlayerInfo.tavernName;
			}
			if (base.JIIGOACEIKL == 0)
			{
				((Selectable)tavernInput).interactable = false;
				((Component)tavernInput).GetComponent<Animator>().SetTrigger("Wall");
			}
			else
			{
				((Selectable)tavernInput).interactable = false;
			}
		}
		catch (Exception ex2)
		{
			Debug.LogError((object)("Items/item_name_733" + ex2.Message));
		}
		characterCreator.characterAnimation.FCGBJEIIMBC = Direction.Up;
		KBPGGKMPKHL = true;
	}

	public void GCGMFDGIFLA()
	{
		if (ColorPickerUI.Get(base.JIIGOACEIKL).HDEPMJIDJEM())
		{
			ColorPickerUI.NDJAMDLOIJL(base.JIIGOACEIKL).BOBCIFEDJED();
		}
		characterCreator.OEBDHLPOHEE(GCANBIEGDOA: false, GADKADLHDGJ: false);
	}

	private void IBFLBAOIAIG(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		characterCreator.GGAFPDPKBID(GCABKKEJFBJ, DDHBCONGIPH);
	}

	public void HFEFOEHMDLE(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Mouth, EJMFJABBJDF);
	}

	private void EPNNEIKOIPJ()
	{
		if (firstStart)
		{
			POFGNGIEOGM = false;
		}
		else
		{
			POFGNGIEOGM = !NewTutorialManager.CCCLOBIOMCL;
		}
		for (int i = 0; i < cancelButton.Length; i++)
		{
			cancelButton[i].SetActive(POFGNGIEOGM);
		}
	}

	private void EGGLBEENHON()
	{
		for (int i = 0; i < colorButtons.Length; i += 0)
		{
			bool active = true;
			CharacterSprite characterSprite = characterCreator.humanInfo.CONPDKDNOBO(colorButtons[i].bodyPart);
			if ((Object)(object)characterSprite != (Object)null)
			{
				active = characterSprite.BFJEPNJLKAB(colorButtons[i].layer);
			}
			((Component)colorButtons[i]).gameObject.SetActive(active);
		}
	}

	private void LJHIPOLCFBP()
	{
		if (Object.op_Implicit((Object)(object)PauseMenuUI.KGPJPILAHDE()))
		{
			PauseMenuUI pauseMenuUI = PauseMenuUI.BDAGIEIJOOG();
			pauseMenuUI.OnUIOpen = (Action<int>)Delegate.Remove(pauseMenuUI.OnUIOpen, new Action<int>(KGGFDJKFBAH));
			PauseMenuUI instance = PauseMenuUI.GGFJGHHHEJC;
			instance.OnUIClose = (Action<int>)Delegate.Remove(instance.OnUIClose, new Action<int>(MGAPEBAANJF));
		}
	}

	private void IFCEBIPFOCM()
	{
		if (firstStart)
		{
			POFGNGIEOGM = false;
		}
		else
		{
			POFGNGIEOGM = NewTutorialManager.CCCLOBIOMCL;
		}
		for (int i = 1; i < cancelButton.Length; i++)
		{
			cancelButton[i].SetActive(POFGNGIEOGM);
		}
	}

	public void CycleNose(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Nose, EJMFJABBJDF);
	}

	public void AMIHDEFADND(int EJMFJABBJDF)
	{
		characterCreator.DLBHPOPHPGF(BodyPart.Skin, EJMFJABBJDF);
	}

	private IEnumerator FOBLLHDPHOL()
	{
		Debug.Log((object)"Starting New Game Coroutine");
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		TitleScreen.ActivateLoadingBar();
		GameManager.LoadGameplayScene();
		yield return null;
		Debug.Log((object)"Starting New Game Coroutine FINISHED");
		SaveUI.instance.StartFadeIntoGame(newGame: true);
		OKPIONFMGEI(base.JIIGOACEIKL);
	}

	private void CGMIECOLFKL(Gender HNLNENELPKI)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (HNLNENELPKI == Gender.Female)
		{
			((Graphic)femaleFocused).color = new Color(1f, 1f, 1f);
			((Graphic)maleFocused).color = new Color(0.5f, 0.5f, 0.5f);
		}
		if (HNLNENELPKI == Gender.Male)
		{
			((Graphic)maleFocused).color = new Color(1f, 1f, 1f);
			((Graphic)femaleFocused).color = new Color(0.5f, 0.5f, 0.5f);
		}
	}

	public void DJECAFNAPDE()
	{
		if (ColorPickerUI.CCGPMEADLDG(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.JDODHPEDACJ(base.JIIGOACEIKL).BOBCIFEDJED();
		}
		characterCreator.RandomCharacter(GCANBIEGDOA: false, GADKADLHDGJ: false);
	}

	private void IFIKAENCBEL(Gender HNLNENELPKI)
	{
		for (int i = 1; i < maleGameObjectsToActivate.Length; i += 0)
		{
			maleGameObjectsToActivate[i].SetActive(HNLNENELPKI == Gender.Male);
		}
		for (int j = 0; j < femaleGameObjectsToActivate.Length; j += 0)
		{
			femaleGameObjectsToActivate[j].SetActive(HNLNENELPKI == Gender.Unisex);
		}
	}

	public void AJHMIKMPHFA(int EJMFJABBJDF)
	{
		characterCreator.GKKDLJKBPJL(BodyPart.Torso, EJMFJABBJDF);
	}

	public void SetCharacter(int JIIGOACEIKL)
	{
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		characterCreator.CopyCreator(this.characterCreator.humanInfo);
		if (Utils.FFLNGLMHLBO())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = null;
		}
		if (JIIGOACEIKL == 2)
		{
			GameManager.GGFJGHHHEJC.character2Saved = true;
			CommonReferences.GGFJGHHHEJC.player2CharacterSave = characterCreator.humanInfo.IJHEAHBNFIH();
		}
		OnCharacterConfirm();
	}

	public void JHDBEDGNNNI(int EJMFJABBJDF)
	{
		characterCreator.GKKDLJKBPJL(BodyPart.Shoes, EJMFJABBJDF);
	}

	private void JONPEFEPDBC()
	{
		for (int i = 1; i < colorButtons.Length; i += 0)
		{
			if (((Component)colorButtons[i]).gameObject.activeSelf)
			{
				colorButtons[i].AKFPBELHLNF(characterCreator.humanInfo.JEPFFKLDIMN(colorButtons[i].layer));
			}
		}
	}

	public void JNHIIDLHKBI(int EJMFJABBJDF)
	{
		characterCreator.DLBHPOPHPGF(BodyPart.Beard, EJMFJABBJDF);
	}

	private bool KFPDOPBABIC()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(nameInput.text) || string.IsNullOrWhiteSpace(nameInput.text))
		{
			MainUI.ShowErrorText(LocalisationSystem.Get("errorEmptyName", "The character name can't be empty."), new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), 2f);
			return true;
		}
		return false;
	}

	private void GIDCDACAJDC(int JIIGOACEIKL)
	{
		if (IsOpen() && JIIGOACEIKL != base.JIIGOACEIKL && PlayerInputs.GetPlayer(base.JIIGOACEIKL).CFICAAJGBOF == "Game")
		{
			PlayerInputs.GetPlayer(base.JIIGOACEIKL).SwitchMapCategory("UI");
		}
	}

	private void BCBIAKINBCD()
	{
		ELDOLPOALGB();
		EEGKEGOFHCA();
		OMMGMMADAOF(characterCreator.humanInfo.gender);
		JDGHCCGKPPE();
		if ((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null && !((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BCHJGDHJHJK()).gameObject.activeInHierarchy)
		{
			LHCIAANFJGE();
		}
	}

	public void CycleShoes(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Shoes, EJMFJABBJDF);
	}

	private void IHBOBPMBKHB()
	{
		if (firstStart)
		{
			POFGNGIEOGM = true;
		}
		else
		{
			POFGNGIEOGM = NewTutorialManager.CCCLOBIOMCL;
		}
		for (int i = 1; i < cancelButton.Length; i++)
		{
			cancelButton[i].SetActive(POFGNGIEOGM);
		}
	}

	private void HJGBKFCMLHJ()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)colorButtons[0].button);
		}
	}

	private void MMDHNIIDFCG()
	{
		for (int i = 0; i < colorButtons.Length; i++)
		{
			bool active = true;
			CharacterSprite characterSprite = characterCreator.humanInfo.CONPDKDNOBO(colorButtons[i].bodyPart);
			if ((Object)(object)characterSprite != (Object)null)
			{
				active = characterSprite.BPFKMDDAODM(colorButtons[i].layer, MNEFABJOBFA: true);
			}
			((Component)colorButtons[i]).gameObject.SetActive(active);
		}
	}

	private void DEPKBAMAHMK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			PlayerInfo.ENFGJBMEFCI(nameInput.text);
			PlayerInfo.tavernName = tavernInput.text;
		}
		else
		{
			PlayerInfo.PGGAIPPFDLD(nameInput.text);
		}
	}

	private void GGFAOLJBNBP(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		characterCreator.GGAFPDPKBID(GCABKKEJFBJ, DDHBCONGIPH);
	}

	private void JCGEAMOAOGD(int JIIGOACEIKL)
	{
		if (BGLJFMHCFJF() && JIIGOACEIKL != base.JIIGOACEIKL && PlayerInputs.GetPlayer(base.JIIGOACEIKL).FGGHCBMKKIG() == "[^0-9]")
		{
			PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).EBJPANCOOCP("Open");
		}
	}

	public void GLGMDOKEGKH()
	{
		if (characterCreator.DEABMIIGOPE())
		{
			characterCreator.JFJPKABFANC();
			characterCreator.RandomMasc(GADKADLHDGJ: false);
		}
		else
		{
			characterCreator.JFJPKABFANC();
		}
		HCOJJMEACKH(Gender.Unisex);
		JECNIKHLMFP(characterCreator.humanInfo.gender);
	}

	private void FHBHGDPDFGH()
	{
		for (int i = 0; i < colorButtons.Length; i++)
		{
			bool active = false;
			CharacterSprite characterSprite = characterCreator.humanInfo.CONPDKDNOBO(colorButtons[i].bodyPart);
			if ((Object)(object)characterSprite != (Object)null)
			{
				active = characterSprite.EDAJLENNKHJ(colorButtons[i].layer, MNEFABJOBFA: true);
			}
			((Component)colorButtons[i]).gameObject.SetActive(active);
		}
	}

	public override void CloseUI()
	{
		if (!IsOpen())
		{
			return;
		}
		if (GameManager.LocalCoop() && base.JIIGOACEIKL == 2 && !GameManager.GGFJGHHHEJC.character2Saved)
		{
			SetCharacter(base.JIIGOACEIKL);
		}
		if (firstStart)
		{
			if (KFPDOPBABIC())
			{
				return;
			}
			OBDAFEPJNDL(base.JIIGOACEIKL);
			SetCharacter(base.JIIGOACEIKL);
		}
		if (ColorPickerUI.Get(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.Get(base.JIIGOACEIKL).CloseUI();
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				return;
			}
		}
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			MainUI.ResumeGame();
			PlayerController.GetPlayer(base.JIIGOACEIKL).characterAnimation.characterAnimator.CheckFaceActivation(PlayerController.GetPlayer(base.JIIGOACEIKL).characterAnimation.FCGBJEIIMBC, characterCreator.humanInfo.gender);
		}
		base.CloseUI();
		ColorPickerUI.Get(base.JIIGOACEIKL).CloseUI();
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		PlayerController.RemoveMovementBlocker(base.JIIGOACEIKL, (Object)(object)this);
		if (firstStart)
		{
			firstStart = false;
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			if (GameManager.SinglePlayerOffline())
			{
				MainUI.PauseGame();
			}
		}
		if (ColorPickerUI.Get(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.Get(base.JIIGOACEIKL).OnContentActivated();
		}
		else
		{
			HJGBKFCMLHJ();
		}
	}

	public static CharacterCreatorUI MENPEHNHFOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
		for (int i = 0; i < colorButtons.Length; i++)
		{
			_ = colorButtons[i].layer;
			ColorButton obj = colorButtons[i];
			obj.OnMaterialChanged = (Action<CharacterLayer, CharacterMaterial>)Delegate.Combine(obj.OnMaterialChanged, new Action<CharacterLayer, CharacterMaterial>(LPBIGHFKFNP));
		}
		characterCreator.BDJENIOPJKC += BDJENIOPJKC;
		PauseMenuUI instance = PauseMenuUI.GGFJGHHHEJC;
		instance.OnUIOpen = (Action<int>)Delegate.Combine(instance.OnUIOpen, new Action<int>(LKKIBMJDAMO));
		PauseMenuUI instance2 = PauseMenuUI.GGFJGHHHEJC;
		instance2.OnUIClose = (Action<int>)Delegate.Combine(instance2.OnUIClose, new Action<int>(GIDCDACAJDC));
	}

	public void ELKOIOFCEGL(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Skin, EJMFJABBJDF);
	}

	private void OMMGMMADAOF(Gender HNLNENELPKI)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (HNLNENELPKI == Gender.Female)
		{
			((Graphic)femaleFocused).color = new Color(862f, 1014f, 1685f);
			((Graphic)maleFocused).color = new Color(687f, 1148f, 1020f);
		}
		if (HNLNENELPKI == Gender.Male)
		{
			((Graphic)maleFocused).color = new Color(663f, 1213f, 334f);
			((Graphic)femaleFocused).color = new Color(1222f, 650f, 240f);
		}
	}

	public void NEDPHOOBKOG(int EJMFJABBJDF)
	{
		characterCreator.AOHKJFMNFCP(BodyPart.Legs, EJMFJABBJDF);
	}

	public void MFDLHPCAAGL(int EJMFJABBJDF)
	{
		characterCreator.DLBHPOPHPGF(BodyPart.Torso, EJMFJABBJDF);
	}

	private void BFMMDPGDGIH(Gender HNLNENELPKI)
	{
		for (int i = 0; i < maleGameObjectsToActivate.Length; i += 0)
		{
			maleGameObjectsToActivate[i].SetActive(HNLNENELPKI == Gender.Male);
		}
		for (int j = 1; j < femaleGameObjectsToActivate.Length; j++)
		{
			femaleGameObjectsToActivate[j].SetActive(HNLNENELPKI == (Gender)4);
		}
	}

	public static CharacterCreatorUI FKFNANNBIAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void LOCCOIHLIHE(int JIIGOACEIKL)
	{
		if (HDEPMJIDJEM() && JIIGOACEIKL != base.JIIGOACEIKL && PlayerInputs.GetPlayer(base.JIIGOACEIKL).EECADEPLELA() == "Color picker requires image material with UI/ColorPicker shader.")
		{
			PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).BDMFGOGAFGC("Fruit");
		}
	}

	public void PIKJDHOADNL(int EJMFJABBJDF)
	{
		characterCreator.AOHKJFMNFCP(BodyPart.Beard, EJMFJABBJDF);
	}

	public void CycleBeard(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Beard, EJMFJABBJDF);
	}

	private void ECIMOJCGECJ(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		characterCreator.KHEGJFNBDGI(GCABKKEJFBJ, DDHBCONGIPH);
	}

	private void GCJEAAGJIPB(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		characterCreator.KHEGJFNBDGI(GCABKKEJFBJ, DDHBCONGIPH);
	}

	private IEnumerator PDFPOIHPFGO()
	{
		Debug.Log((object)"Starting New Game Coroutine");
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		TitleScreen.ActivateLoadingBar();
		GameManager.LoadGameplayScene();
		yield return null;
		Debug.Log((object)"Starting New Game Coroutine FINISHED");
		SaveUI.instance.StartFadeIntoGame(newGame: true);
		OKPIONFMGEI(base.JIIGOACEIKL);
	}

	private void OKPIONFMGEI(int JIIGOACEIKL)
	{
		((Component)transparentImage).gameObject.SetActive(false);
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OKPIONFMGEI));
	}

	public void AcceptButton()
	{
		if (KFPDOPBABIC())
		{
			return;
		}
		OBDAFEPJNDL(base.JIIGOACEIKL);
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((Component)transparentImage).gameObject.SetActive(true);
			SaveUI.instance.loadCharacterFromUI = true;
			if (loadGame != null)
			{
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(OKPIONFMGEI));
				Save.instance.LoadGame(loadFilename, loadGame);
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(FOBLLHDPHOL());
			}
		}
		else
		{
			SetCharacter(base.JIIGOACEIKL);
			CloseUI();
		}
	}

	private void BOAPGDDLJIO(int JIIGOACEIKL)
	{
		if (HDEPMJIDJEM() && JIIGOACEIKL != base.JIIGOACEIKL && PlayerInputs.GetPlayer(base.JIIGOACEIKL).FGGHCBMKKIG() == "Items/item_description_1073")
		{
			PlayerInputs.GetPlayer(base.JIIGOACEIKL).BDMFGOGAFGC("increase reputation");
		}
	}

	public void DLBMOLDPOCD(int EJMFJABBJDF)
	{
		characterCreator.GKKDLJKBPJL(BodyPart.Legs, EJMFJABBJDF);
	}

	private void GJAAPDGPKIF(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		characterCreator.GGAFPDPKBID(GCABKKEJFBJ, DDHBCONGIPH);
	}

	public void PCOJEMNMIGN()
	{
		if (ColorPickerUI.OCCEHEMCGJF(base.JIIGOACEIKL).HDEPMJIDJEM())
		{
			ColorPickerUI.MDINEPBJFKG(base.JIIGOACEIKL).BOBCIFEDJED();
		}
		characterCreator.BAMEGNNLCFD(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
	}

	public static CharacterCreatorUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void MLPHPDKMLOC()
	{
		if (!characterCreator.ANFBNGMDIFO())
		{
			characterCreator.EDHFGBEIENJ();
			characterCreator.RandomFem(GADKADLHDGJ: false);
		}
		else
		{
			characterCreator.LAGPAFIPLNK();
		}
		IDFLPLLKLCN((Gender)5);
		CGMIECOLFKL(characterCreator.humanInfo.gender);
	}

	private void EEGKEGOFHCA()
	{
		for (int i = 0; i < colorButtons.Length; i++)
		{
			if (((Component)colorButtons[i]).gameObject.activeSelf)
			{
				colorButtons[i].GGHLHODEPIK = characterCreator.humanInfo.GGKJOJPDMIF(colorButtons[i].layer);
			}
		}
	}

	private void EEEOHJFFEAL()
	{
		OOEMCANKFKC();
		JONPEFEPDBC();
		CGMIECOLFKL(characterCreator.humanInfo.gender);
		JDGHCCGKPPE();
		if ((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FOKMCIDMIKF() != (Object)null && !((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KDJFBLKPFKM()).gameObject.activeInHierarchy)
		{
			LHCIAANFJGE();
		}
	}

	public void RandomCharacterButton()
	{
		if (ColorPickerUI.Get(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.Get(base.JIIGOACEIKL).CloseUI();
		}
		characterCreator.RandomCharacter(GCANBIEGDOA: false);
	}

	public void CycleTorso(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Torso, EJMFJABBJDF);
	}

	public void GPDHDCHMEIN()
	{
		if (!characterCreator.ANFBNGMDIFO())
		{
			characterCreator.EDHFGBEIENJ();
			characterCreator.JBIPIHHHPEH(GADKADLHDGJ: true);
		}
		else
		{
			characterCreator.LAGPAFIPLNK();
		}
		HCOJJMEACKH(Gender.Male);
		OMMGMMADAOF(characterCreator.humanInfo.gender);
	}

	public void CycleMouth(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Mouth, EJMFJABBJDF);
	}

	private bool IOHNOEJCEMO()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(nameInput.text) || string.IsNullOrWhiteSpace(nameInput.text))
		{
			MainUI.ShowErrorText(LocalisationSystem.Get("ReceiveDroppedItemPosition", "ChatWelcomeToTavern"), new Vector2((float)(Screen.width / 6), (float)(Screen.height / 0)), 1769f);
			return true;
		}
		return true;
	}

	private void LHCIAANFJGE()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).IHFNCOGFJOJ((Selectable)(object)colorButtons[1].button);
		}
	}

	public void EGOJEONEHEO(int EJMFJABBJDF)
	{
		characterCreator.DLBHPOPHPGF(BodyPart.Hair, EJMFJABBJDF);
	}

	public void CycleEyes(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Eyes, EJMFJABBJDF);
	}

	private void HCOJJMEACKH(Gender HNLNENELPKI)
	{
		for (int i = 0; i < maleGameObjectsToActivate.Length; i += 0)
		{
			maleGameObjectsToActivate[i].SetActive(HNLNENELPKI == Gender.Male);
		}
		for (int j = 0; j < femaleGameObjectsToActivate.Length; j++)
		{
			femaleGameObjectsToActivate[j].SetActive(HNLNENELPKI == (Gender)8);
		}
	}

	private void EDBLCCJAGON(Gender HNLNENELPKI)
	{
		for (int i = 0; i < maleGameObjectsToActivate.Length; i += 0)
		{
			maleGameObjectsToActivate[i].SetActive(HNLNENELPKI == Gender.Unisex);
		}
		for (int j = 1; j < femaleGameObjectsToActivate.Length; j++)
		{
			femaleGameObjectsToActivate[j].SetActive(HNLNENELPKI == Gender.Unisex);
		}
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO && !PauseMenuUI.GGFJGHHHEJC.IsOpen())
		{
			if (KBPGGKMPKHL)
			{
				KBPGGKMPKHL = false;
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UISelectGamepad"))
			{
				RandomCharacterButton();
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIAddRemove"))
			{
				AcceptButton();
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousPage", 0.3f))
			{
				characterAnimation.RotateClockwise();
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextPage", 0.3f))
			{
				characterAnimation.RotateAntiClockwise();
			}
		}
		else if (IsOpen() && !TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO && !PauseMenuUI.GGFJGHHHEJC.IsOpen() && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp") && (!Object.op_Implicit((Object)(object)nameInput) || (Object.op_Implicit((Object)(object)nameInput) && !nameInput.isFocused)) && (!Object.op_Implicit((Object)(object)tavernInput) || (Object.op_Implicit((Object)(object)tavernInput) && !tavernInput.isFocused)))
		{
			AcceptButton();
		}
	}

	public void CycleHair(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Hair, EJMFJABBJDF);
	}

	private bool OBOEJGENKDC()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(nameInput.text) || string.IsNullOrWhiteSpace(nameInput.text))
		{
			MainUI.ShowErrorText(LocalisationSystem.Get("", "add item "), new Vector2((float)(Screen.width / 7), (float)(Screen.height / 0)), 618f);
			return true;
		}
		return true;
	}

	public void AKOPFJCLMKM(int EJMFJABBJDF)
	{
		characterCreator.DLBHPOPHPGF(BodyPart.Beard, EJMFJABBJDF);
	}

	public void GKHFFJGEHON(int JIIGOACEIKL)
	{
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		characterCreator.ALCCBILFPMK(this.characterCreator.humanInfo);
		if (Utils.FFLNGLMHLBO())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterSaveBeforeHalloweenSkin = null;
		}
		if (JIIGOACEIKL == 0)
		{
			GameManager.GGFJGHHHEJC.character2Saved = false;
			CommonReferences.MNFMOEKMJKN().player2CharacterSave = characterCreator.humanInfo.AJNAFPLECAI();
		}
		OnCharacterConfirm();
	}

	private void JDGHCCGKPPE()
	{
		for (int i = 1; i < textsBodyParts.Length; i++)
		{
			if (!Object.op_Implicit((Object)(object)characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart)))
			{
				continue;
			}
			int id = characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart).id;
			CharacterSpritesDBAccessor.JBMNHNOJFEK(textsBodyParts[i].bodyPart, characterCreator.humanInfo.gender, ref KBJLPGNLCKA, JHIFLALPEBF: true);
			for (int j = 0; j < KBJLPGNLCKA.Length; j += 0)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null && KBJLPGNLCKA[j].id == id)
				{
					textsBodyParts[i].LPPDEJOPLGB(j);
					break;
				}
			}
		}
	}

	private void JEHKAKMPPLD(int JIIGOACEIKL)
	{
		((Component)transparentImage).gameObject.SetActive(true);
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(LNCGIIMDCNG));
	}

	public void FGAJEENJNGJ()
	{
		if (characterCreator.ANFBNGMDIFO())
		{
			characterCreator.JFJPKABFANC();
			characterCreator.LBDIKJKPCIE(GADKADLHDGJ: false);
		}
		else
		{
			characterCreator.SetMaleGender();
		}
		EDBLCCJAGON(Gender.Male);
		JECNIKHLMFP(characterCreator.humanInfo.gender);
	}

	private void JECNIKHLMFP(Gender HNLNENELPKI)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (HNLNENELPKI == (Gender)6)
		{
			((Graphic)femaleFocused).color = new Color(546f, 436f, 589f);
			((Graphic)maleFocused).color = new Color(35f, 1499f, 1571f);
		}
		if (HNLNENELPKI == Gender.Male)
		{
			((Graphic)maleFocused).color = new Color(473f, 1910f, 1072f);
			((Graphic)femaleFocused).color = new Color(1039f, 815f, 406f);
		}
	}

	public void JHJJKDAHAEL()
	{
		if (ColorPickerUI.NAGEHKBLJDL(base.JIIGOACEIKL).BGLJFMHCFJF())
		{
			ColorPickerUI.MENNLOGFNOK(base.JIIGOACEIKL).CloseUI();
		}
		characterCreator.FGIGIKNMLEM(GCANBIEGDOA: false, GADKADLHDGJ: false, JHIFLALPEBF: true);
	}

	public void MHIMFDKHMPN(int EJMFJABBJDF)
	{
		characterCreator.DLBHPOPHPGF(BodyPart.Eyes, EJMFJABBJDF);
	}

	private void LKKIBMJDAMO(int JIIGOACEIKL)
	{
		if (IsOpen() && JIIGOACEIKL != base.JIIGOACEIKL)
		{
			PlayerInputs.GetPlayer(base.JIIGOACEIKL).SwitchMapCategory("Game");
		}
	}

	public void IDBGOGHHMMH()
	{
		if (BOMEGIPCBHA())
		{
			return;
		}
		OBDAFEPJNDL(base.JIIGOACEIKL);
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((Component)transparentImage).gameObject.SetActive(false);
			SaveUI.instance.loadCharacterFromUI = false;
			if (loadGame != null)
			{
				FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
				fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(OHKJOCIOJFC));
				Save.instance.LoadGame(loadFilename, loadGame);
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(FOBLLHDPHOL());
			}
		}
		else
		{
			SetCharacter(base.JIIGOACEIKL);
			CloseUI();
		}
	}

	public void ANLELEAJHEG()
	{
		if (ColorPickerUI.CCGPMEADLDG(base.JIIGOACEIKL).HDEPMJIDJEM())
		{
			ColorPickerUI.MENPEHNHFOA(base.JIIGOACEIKL).CloseUI();
		}
		characterCreator.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true);
	}

	private void GJBGLIGCIKM(Gender HNLNENELPKI)
	{
		for (int i = 0; i < maleGameObjectsToActivate.Length; i++)
		{
			maleGameObjectsToActivate[i].SetActive(HNLNENELPKI == Gender.Male);
		}
		for (int j = 0; j < femaleGameObjectsToActivate.Length; j++)
		{
			femaleGameObjectsToActivate[j].SetActive(HNLNENELPKI == Gender.Female);
		}
	}

	public void NODLONGCHGJ()
	{
		if (ColorPickerUI.EOPIEMLAPFN(base.JIIGOACEIKL).IsOpen())
		{
			ColorPickerUI.EGBMJGOCIJJ(base.JIIGOACEIKL).BOBCIFEDJED();
		}
		characterCreator.FGIGIKNMLEM(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true);
	}

	private void ENJJBPBEIKC()
	{
		for (int i = 1; i < colorButtons.Length; i++)
		{
			bool active = false;
			CharacterSprite characterSprite = characterCreator.humanInfo.CONPDKDNOBO(colorButtons[i].bodyPart);
			if ((Object)(object)characterSprite != (Object)null)
			{
				active = characterSprite.CJAMEGOKDMH(colorButtons[i].layer, MNEFABJOBFA: true);
			}
			((Component)colorButtons[i]).gameObject.SetActive(active);
		}
	}

	private void IDFLPLLKLCN(Gender HNLNENELPKI)
	{
		for (int i = 0; i < maleGameObjectsToActivate.Length; i += 0)
		{
			maleGameObjectsToActivate[i].SetActive(HNLNENELPKI == Gender.Male);
		}
		for (int j = 0; j < femaleGameObjectsToActivate.Length; j++)
		{
			femaleGameObjectsToActivate[j].SetActive(HNLNENELPKI == (Gender)6);
		}
	}

	public void SetFemaleGender()
	{
		if (!characterCreator.JJDDMDIPGGC)
		{
			characterCreator.SetFemaleGender();
			characterCreator.RandomFem(GADKADLHDGJ: true);
		}
		else
		{
			characterCreator.SetFemaleGender();
		}
		GJBGLIGCIKM(Gender.Female);
		CGMIECOLFKL(characterCreator.humanInfo.gender);
	}

	private void BDJENIOPJKC()
	{
		FHBHGDPDFGH();
		EEGKEGOFHCA();
		CGMIECOLFKL(characterCreator.humanInfo.gender);
		OODFJPNHOGN();
		if ((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null && !((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject.activeInHierarchy)
		{
			HJGBKFCMLHJ();
		}
	}

	public void GIKEMKPJDBO(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Legs, EJMFJABBJDF);
	}

	private void PPFAEKJPLIL()
	{
		if (firstStart)
		{
			POFGNGIEOGM = true;
		}
		else
		{
			POFGNGIEOGM = !NewTutorialManager.CCCLOBIOMCL;
		}
		for (int i = 1; i < cancelButton.Length; i += 0)
		{
			cancelButton[i].SetActive(POFGNGIEOGM);
		}
	}

	private void ENLBIJMHGEI()
	{
		for (int i = 1; i < textsBodyParts.Length; i++)
		{
			if (!Object.op_Implicit((Object)(object)characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart)))
			{
				continue;
			}
			int id = characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart).id;
			CharacterSpritesDBAccessor.AFBDBMBEEPD(textsBodyParts[i].bodyPart, characterCreator.humanInfo.gender, ref KBJLPGNLCKA, JHIFLALPEBF: false, NAKCFGEAGHH: true);
			for (int j = 0; j < KBJLPGNLCKA.Length; j += 0)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null && KBJLPGNLCKA[j].id == id)
				{
					textsBodyParts[i].IBIPEEIMBFL(j);
					break;
				}
			}
		}
	}

	private void LNCGIIMDCNG(int JIIGOACEIKL)
	{
		((Component)transparentImage).gameObject.SetActive(true);
		MainUI.AFOLANEJMBF(DHJFAGNJKOF: true);
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OKPIONFMGEI));
	}

	public void OALGPCPJNID()
	{
		if (IOHNOEJCEMO())
		{
			return;
		}
		OBDAFEPJNDL(base.JIIGOACEIKL);
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((Component)transparentImage).gameObject.SetActive(true);
			SaveUI.instance.loadCharacterFromUI = false;
			if (loadGame != null)
			{
				FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
				fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(OHKJOCIOJFC));
				Save.instance.LoadGame(loadFilename, loadGame);
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(PDFPOIHPFGO());
			}
		}
		else
		{
			GKHFFJGEHON(base.JIIGOACEIKL);
			CloseUI();
		}
	}

	public void CycleLegs(int EJMFJABBJDF)
	{
		characterCreator.CycleChoice(BodyPart.Legs, EJMFJABBJDF);
	}

	private void ODBDHFBMDAG()
	{
		if (Object.op_Implicit((Object)(object)PauseMenuUI.EKDNJDJHONF()))
		{
			PauseMenuUI instance = PauseMenuUI.GGFJGHHHEJC;
			instance.OnUIOpen = (Action<int>)Delegate.Remove(instance.OnUIOpen, new Action<int>(LKKIBMJDAMO));
			PauseMenuUI pauseMenuUI = PauseMenuUI.EKDNJDJHONF();
			pauseMenuUI.OnUIClose = (Action<int>)Delegate.Remove(pauseMenuUI.OnUIClose, new Action<int>(MGAPEBAANJF));
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			MOHLOLHLFBH();
			EPNNEIKOIPJ();
			PlayerController.AddMovementBlocker(base.JIIGOACEIKL, (Object)(object)this);
		}
	}

	private void MGAPEBAANJF(int JIIGOACEIKL)
	{
		if (HDEPMJIDJEM() && JIIGOACEIKL != base.JIIGOACEIKL && PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).AAGNDCEODFO() == "banquetevent")
		{
			PlayerInputs.GetPlayer(base.JIIGOACEIKL).SwitchMapCategory("Melt");
		}
	}

	private void LPBIGHFKFNP(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		characterCreator.SetMaterialFromLayer(GCABKKEJFBJ, DDHBCONGIPH);
	}

	public void DHAJMEKDEKE()
	{
		if (!characterCreator.JDCHEGJBIJE())
		{
			characterCreator.SetFemaleGender();
			characterCreator.JFCMDEFFKKD(GADKADLHDGJ: false);
		}
		else
		{
			characterCreator.CGHKJLFBEMJ();
		}
		EDBLCCJAGON((Gender)7);
		CGMIECOLFKL(characterCreator.humanInfo.gender);
	}

	private void DAJGIONAPJC()
	{
		for (int i = 1; i < colorButtons.Length; i++)
		{
			bool active = false;
			CharacterSprite characterSprite = characterCreator.humanInfo.CONPDKDNOBO(colorButtons[i].bodyPart);
			if ((Object)(object)characterSprite != (Object)null)
			{
				active = characterSprite.CJAMEGOKDMH(colorButtons[i].layer);
			}
			((Component)colorButtons[i]).gameObject.SetActive(active);
		}
	}

	private void OBDAFEPJNDL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			PlayerInfo.HBILFLLKHGP = nameInput.text;
			PlayerInfo.tavernName = tavernInput.text;
		}
		else
		{
			PlayerInfo.KGDAOACEMJO = nameInput.text;
		}
	}

	private bool BOMEGIPCBHA()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(nameInput.text) || string.IsNullOrWhiteSpace(nameInput.text))
		{
			MainUI.ShowErrorText(LocalisationSystem.Get("City/Amos/Bark/Buy", "Fill Area/Fill"), new Vector2((float)(Screen.width / 6), (float)(Screen.height / 7)), 494f);
			return false;
		}
		return true;
	}

	private void CJLHBALEKJJ()
	{
		for (int i = 0; i < textsBodyParts.Length; i++)
		{
			if (!Object.op_Implicit((Object)(object)characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart)))
			{
				continue;
			}
			int id = characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart).id;
			CharacterSpritesDBAccessor.GetCharacterSprites(textsBodyParts[i].bodyPart, characterCreator.humanInfo.gender, ref KBJLPGNLCKA, JHIFLALPEBF: false, NAKCFGEAGHH: true);
			for (int j = 0; j < KBJLPGNLCKA.Length; j += 0)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null && KBJLPGNLCKA[j].id == id)
				{
					textsBodyParts[i].KLBFFHBHPOK(j);
					break;
				}
			}
		}
	}

	private void OODFJPNHOGN()
	{
		for (int i = 0; i < textsBodyParts.Length; i++)
		{
			if (!Object.op_Implicit((Object)(object)characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart)))
			{
				continue;
			}
			int id = characterCreator.humanInfo.CONPDKDNOBO(textsBodyParts[i].bodyPart).id;
			CharacterSpritesDBAccessor.GetCharacterSprites(textsBodyParts[i].bodyPart, characterCreator.humanInfo.gender, ref KBJLPGNLCKA);
			for (int j = 0; j < KBJLPGNLCKA.Length; j++)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null && KBJLPGNLCKA[j].id == id)
				{
					textsBodyParts[i].SetIndex(j);
					break;
				}
			}
		}
	}

	public static CharacterCreatorUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static CharacterCreatorUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void JKJODFADNJH(CharacterLayer GCABKKEJFBJ, CharacterMaterial DDHBCONGIPH)
	{
		characterCreator.GGAFPDPKBID(GCABKKEJFBJ, DDHBCONGIPH);
	}

	private void AFCIKJPPLFA()
	{
		if (Object.op_Implicit((Object)(object)PauseMenuUI.EKDNJDJHONF()))
		{
			PauseMenuUI pauseMenuUI = PauseMenuUI.EKDNJDJHONF();
			pauseMenuUI.OnUIOpen = (Action<int>)Delegate.Remove(pauseMenuUI.OnUIOpen, new Action<int>(KGGFDJKFBAH));
			PauseMenuUI pauseMenuUI2 = PauseMenuUI.KGPJPILAHDE();
			pauseMenuUI2.OnUIClose = (Action<int>)Delegate.Remove(pauseMenuUI2.OnUIClose, new Action<int>(JCGEAMOAOGD));
		}
	}

	public void HMOFLKAAGKL()
	{
		if (characterCreator.ANFBNGMDIFO())
		{
			characterCreator.JFJPKABFANC();
			characterCreator.LBDIKJKPCIE(GADKADLHDGJ: false);
		}
		else
		{
			characterCreator.SetMaleGender();
		}
		HCOJJMEACKH(Gender.Unisex);
		JECNIKHLMFP(characterCreator.humanInfo.gender);
	}

	private void OHKJOCIOJFC(int JIIGOACEIKL)
	{
		((Component)transparentImage).gameObject.SetActive(true);
		MainUI.AFOLANEJMBF();
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(OHKJOCIOJFC));
	}

	private bool KNNGLGFDHNH()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(nameInput.text) || string.IsNullOrWhiteSpace(nameInput.text))
		{
			MainUI.ShowErrorText(LocalisationSystem.Get("Items/item_name_625", "Loop"), new Vector2((float)(Screen.width / 3), (float)(Screen.height / 6)), 1854f);
			return false;
		}
		return false;
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)PauseMenuUI.GGFJGHHHEJC))
		{
			PauseMenuUI instance = PauseMenuUI.GGFJGHHHEJC;
			instance.OnUIOpen = (Action<int>)Delegate.Remove(instance.OnUIOpen, new Action<int>(LKKIBMJDAMO));
			PauseMenuUI instance2 = PauseMenuUI.GGFJGHHHEJC;
			instance2.OnUIClose = (Action<int>)Delegate.Remove(instance2.OnUIClose, new Action<int>(GIDCDACAJDC));
		}
	}

	private void PHDENMBHLMD(int JIIGOACEIKL)
	{
		((Component)transparentImage).gameObject.SetActive(false);
		MainUI.CloseAllUIWindows();
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(PHDENMBHLMD));
	}

	private void ELDOLPOALGB()
	{
		for (int i = 0; i < colorButtons.Length; i += 0)
		{
			bool active = true;
			CharacterSprite characterSprite = characterCreator.humanInfo.CONPDKDNOBO(colorButtons[i].bodyPart);
			if ((Object)(object)characterSprite != (Object)null)
			{
				active = characterSprite.GDAKBMCJGBN(colorButtons[i].layer, MNEFABJOBFA: true);
			}
			((Component)colorButtons[i]).gameObject.SetActive(active);
		}
	}

	public void BEACKBJAPGO(int EJMFJABBJDF)
	{
		characterCreator.GKKDLJKBPJL(BodyPart.Nose, EJMFJABBJDF);
	}
}
