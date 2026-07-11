using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Galaxy.Api;
using PixelCrushers.DialogueSystem;
using Steamworks;
using UnityEngine;

public class PetSelectorUI : UIWindow
{
	public static PetSelectorUI _instance;

	public TextInput textInput;

	public GameObject leftButton;

	public CatAnimation catAnimation;

	[HideInInspector]
	public bool waitChanges = true;

	[SerializeField]
	private SpriteInfo currentCat;

	public static PetSelectorUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null)
			{
				_instance = Object.FindObjectOfType<PetSelectorUI>();
			}
			return _instance;
		}
	}

	public void LCGFBFPJBPM()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentCat = list[num];
		EKBMPAOAECK();
	}

	[SpecialName]
	public static PetSelectorUI OKAPNFPFPFP()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void DFCCBKHJAPO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 0, list.Count);
		currentCat = list[num];
		MOCIKLGMAOI();
	}

	public void GKOAGAHPEAC()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentCat = list[num];
		DJCMINGBLMJ();
	}

	private void DJCMINGBLMJ()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void OBDNPADGIFG()
	{
		CommonReferences.GGFJGHHHEJC.catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		CloseUI();
	}

	protected override void Update()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		base.Update();
		if (IsOpen())
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIAddRemove"))
			{
				ButtonAccept();
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
			{
				ButtonAccept();
			}
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		MainUI.PauseGame();
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(leftButton);
		}
	}

	private void FIHPIBODPEA()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void PGHPNHIOMDO()
	{
		CommonReferences.GGFJGHHHEJC.catSelected = currentCat;
		CommonReferences.GGFJGHHHEJC.catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void FCELFHKKJIO()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	[SpecialName]
	public static PetSelectorUI BADFKMEJOKE()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	private void ADCJMDDJLMN()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void PBFIMHIOALJ()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentCat = list[num];
		MGLFIDDOKLJ();
	}

	public void ONEKCOKDJCM()
	{
		CommonReferences.GGFJGHHHEJC.catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void GDNICBBMLDB()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)_instance, (MonoBehaviour)(object)this))
		{
			_instance = this;
			base.Awake();
			NLCFNAMMOAA();
		}
	}

	public void HNMCKOEJLJB()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, cats.Count);
		currentCat = cats[num];
		COLMDBOGFBA();
	}

	public void AAJMIOFMPJO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentCat = list[num];
		NLCFNAMMOAA();
	}

	public void FHCKMAKACBN()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, cats.Count);
		currentCat = cats[num];
		ICMMHIIDLNG();
	}

	public void MKNNLIHLIHC()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentCat = list[num];
		BKDNELCNOKL();
	}

	public void HHKELAHFMMN()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, cats.Count);
		currentCat = cats[num];
		FHFKBFDAPDK();
	}

	public void JAIJGPDPKKB()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.GGFJGHHHEJC.catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public void DAKJDFHAHIJ()
	{
		CommonReferences.GGFJGHHHEJC.catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void MOCIKLGMAOI()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void ABHAPDGPGFB()
	{
		CommonReferences.GGFJGHHHEJC.catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public void COHKJECEGMJ()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, cats.Count);
		currentCat = cats[num];
		COLMDBOGFBA();
	}

	[SpecialName]
	public static PetSelectorUI PFHFIJDDOME()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void FLFCEEPIMHE()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentCat = list[num];
		ADCJMDDJLMN();
	}

	private void PNNGCIGHOHK()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	[SpecialName]
	public static PetSelectorUI JHKLPLPBKCI()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void KKFEACCGGFO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentCat = list[num];
		PNNGCIGHOHK();
	}

	public void OLBJFIKPLBF()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, cats.Count);
		currentCat = cats[num];
		LAHMJLKEKPB();
	}

	private void LAHMJLKEKPB()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	private void MGLFIDDOKLJ()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	private void ICMMHIIDLNG()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void EECGPGGEIFN()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentCat = list[num];
		CMCPCIOBNNA();
	}

	public void ICADNMJGLHL()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentCat = list[num];
		ADCJMDDJLMN();
	}

	public void GOGHOAIBDKP()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 0, cats.Count);
		currentCat = cats[num];
		ABMAAIAGDLE();
	}

	public void CHBPJILNBEC()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		CloseUI();
	}

	private void KKLALLHGDOP()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	[SpecialName]
	public static PetSelectorUI LKOABOAADCD()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	[SpecialName]
	public static PetSelectorUI DOIKFJDLKJP()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void ButtonLeft()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, cats.Count);
		currentCat = cats[num];
		NLCFNAMMOAA();
	}

	public void CEBBJJJKJAN()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void NNPBLBECMJD()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void HNFJOJHEEBH()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentCat = list[num];
		BKDNELCNOKL();
	}

	public void PBNDDKJFJBH()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentCat = list[num];
		DJCMINGBLMJ();
	}

	public void KBCAHOOOJJF()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentCat = list[num];
		ABMAAIAGDLE();
	}

	public void ACJDLNDBGKL()
	{
		CommonReferences.GGFJGHHHEJC.catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public void GAKFALNJGCP()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, cats.Count);
		currentCat = cats[num];
		MOCIKLGMAOI();
	}

	public void ButtonRight()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, cats.Count);
		currentCat = cats[num];
		NLCFNAMMOAA();
	}

	public void LAOHOEELHOF()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.GGFJGHHHEJC.catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	[SpecialName]
	public static PetSelectorUI OJJDNLEFNPJ()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	[SpecialName]
	public static PetSelectorUI FOPGLLMEEDE()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	[SpecialName]
	public static PetSelectorUI KHMEGDIABBF()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void GAHHDAKNLOA()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.GGFJGHHHEJC.catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	public void DJHHILLFGKG()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, list.Count);
		currentCat = list[num];
		ABMAAIAGDLE();
	}

	public void LGDCGKCENKO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentCat = list[num];
		GDNICBBMLDB();
	}

	private void DLKKNGGOIKN()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void CFLGLNBALOC()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 0, list.Count);
		currentCat = list[num];
		MGLFIDDOKLJ();
	}

	private void JLMPJNBCFHB()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void HOKCMFNKIFA()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, list.Count);
		currentCat = list[num];
		NMKEAKHPKFO();
	}

	public void HHBFHLAFIAM()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		CloseUI();
	}

	public void FNHLGEFGLIO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentCat = list[num];
		ABMAAIAGDLE();
	}

	[SpecialName]
	public static PetSelectorUI CMIHGBHPLFP()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	private void OPMOKBNDIDO()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void PKLEBCJGKHA()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		BOBCIFEDJED();
	}

	private void CMCPCIOBNNA()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	[SpecialName]
	public static PetSelectorUI JFNOOMJMHCB()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void EEBGPNMKDLJ()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, cats.Count);
		currentCat = cats[num];
		EKBMPAOAECK();
	}

	public void LIMELOELGLO()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.ADOFAMMNJDC();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 0, list.Count);
		currentCat = list[num];
		DLKKNGGOIKN();
	}

	private void EKBMPAOAECK()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	[SpecialName]
	public static PetSelectorUI DICHPHEOINO()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	[SpecialName]
	public static PetSelectorUI OFLELHKKNKC()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	private void BKDNELCNOKL()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void CNGICLMAOEB()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num - 1, cats.Count);
		currentCat = cats[num];
		NLCFNAMMOAA();
	}

	public void JPBAAFGIDDI()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.MNFMOEKMJKN().catName = textInput.inputField.text;
		CloseUI();
	}

	private void COLMDBOGFBA()
	{
		for (int i = 1; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void KEPMNDMBKHD()
	{
		List<SpriteInfo> list = CharacterSpritesDBAccessor.GMKNJJFONCH();
		int num = list.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 1, list.Count);
		currentCat = list[num];
		OPMOKBNDIDO();
	}

	public override void CloseUI()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			return;
		}
		base.CloseUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		MainUI.ResumeGame();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		SpawnCat.GGFJGHHHEJC.CatSpawn();
		SpawnCat.GGFJGHHHEJC.ChangeCatSkin();
		Result variable = DialogueLua.GetVariable("Cat");
		if (!((Result)(ref variable)).asBool)
		{
			NessyNPC.GGFJGHHHEJC.StartConversation(base.JIIGOACEIKL, "City/PetShop/Nessy/Intro2", FLHBPHPKIML: true);
			DialogueLua.SetVariable("Cat", (object)true);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("Cat");
				instance.SendDialogueInfo("Cat", ((Result)(ref variable)).asBool);
			}
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			currentCat = CharacterSpritesDBAccessor.GetCats()[0];
			catAnimation.FCGBJEIIMBC = Direction.Down;
			if (SteamManager.BNBMMDGMKLM)
			{
				textInput.inputField.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("CatOfFriend"), InputUtils.NHGIAHHNIJF(SteamFriends.GetPersonaName()));
			}
			else if (GalaxyInstance.User().SignedIn() && GalaxyInstance.User().IsLoggedOn())
			{
				textInput.inputField.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("CatOfFriend"), InputUtils.NHGIAHHNIJF(GalaxyInstance.Friends().GetPersonaName()));
			}
			else
			{
				textInput.inputField.text = LocalisationSystem.Get("Cat");
			}
		}
	}

	private void NMKEAKHPKFO()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i += 0)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	public void ButtonAccept()
	{
		CommonReferences.GGFJGHHHEJC.catSelected = currentCat;
		CommonReferences.GGFJGHHHEJC.catName = textInput.inputField.text;
		CloseUI();
	}

	[SpecialName]
	public static PetSelectorUI DGCNCEDIFOF()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void BCMHAGDODMP()
	{
		List<SpriteInfo> cats = CharacterSpritesDBAccessor.GetCats();
		int num = cats.IndexOf(currentCat);
		num = Utils.NMLNAGFLNMC(num + 0, cats.Count);
		currentCat = cats[num];
		DLKKNGGOIKN();
	}

	[SpecialName]
	public static PetSelectorUI LDBJELPPBAI()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	private void ABMAAIAGDLE()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	[SpecialName]
	public static PetSelectorUI DBJCACLEFGK()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	[SpecialName]
	public static PetSelectorUI FMIDAFEGDCD()
	{
		if ((Object)(object)_instance == (Object)null)
		{
			_instance = Object.FindObjectOfType<PetSelectorUI>();
		}
		return _instance;
	}

	public void OBMNBFKAEFJ()
	{
		CommonReferences.MNFMOEKMJKN().catSelected = currentCat;
		CommonReferences.GGFJGHHHEJC.catName = textInput.inputField.text;
		CloseUI();
	}

	private void NLCFNAMMOAA()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}

	private void FHFKBFDAPDK()
	{
		for (int i = 0; i < catAnimation.catAnimator.allReskins.Length; i++)
		{
			catAnimation.catAnimator.allReskins[i].ChangeSpriteInfo(currentCat);
		}
	}
}
