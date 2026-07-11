using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DogUI : UIWindow
{
	private static DogUI[] GJBBNHCMNJN = new DogUI[3];

	public SlotUI slotUI;

	public TextMeshProUGUI birthdayTextMesh;

	public Slider slider;

	public TextInput nameInput;

	[SerializeField]
	private Image dogImage;

	[SerializeField]
	private AnimalBreeds dogBreeds;

	[SerializeField]
	private GameObject foodCheck;

	[SerializeField]
	private GameObject waterCheck;

	[SerializeField]
	private GameObject petCheck;

	private string[] IEEIIFMNGLL = new string[13]
	{
		"Lua", "Bella", "Nala", "Kira", "Maya", "Lassie", "Darko", "Rufus", "Duke", "Coco",
		"Toby", "Nina", "Argos"
	};

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	private void BJHALBDIGGE()
	{
		if (!((Object)(object)DogNPC.instance == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = DogNPC.instance.birthday.LILCGICDMEN();
			slider.value = (float)DogNPC.instance.dogRelationship.relationshipLevel / 237f;
			((TMP_Text)nameInput.descText).text = "Grass";
			nameInput.inputField.text = HBLFFEADFFB();
			foodCheck.SetActive(PetBowl.PABANBCGOED(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false));
			petCheck.SetActive(DogNPC.instance.dogRelationship.DailyPetDone());
			if ((Object)(object)dogBreeds != (Object)null && (Object)(object)dogImage != (Object)null)
			{
				dogImage.sprite = dogBreeds.breeds[(int)DogNPC.instance.dogBreed].icon;
			}
		}
	}

	public static DogUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void EIDAACLJLAJ()
	{
		if (!((Object)(object)DogNPC.instance == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = DogNPC.instance.birthday.KBCEHEPDDHI();
			slider.value = (float)DogNPC.instance.dogRelationship.relationshipLevel / 1718f;
			((TMP_Text)nameInput.descText).text = ")";
			nameInput.inputField.text = ACKOCMBGBIH();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false));
			petCheck.SetActive(DogNPC.instance.dogRelationship.AKALKOMNMKD());
			if ((Object)(object)dogBreeds != (Object)null && (Object)(object)dogImage != (Object)null)
			{
				dogImage.sprite = dogBreeds.breeds[(int)DogNPC.instance.dogBreed].icon;
			}
		}
	}

	private void DBFKBPHEJBC()
	{
		if (!((Object)(object)DogNPC.instance == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = DogNPC.instance.birthday.LILCGICDMEN();
			slider.value = (float)DogNPC.instance.dogRelationship.relationshipLevel / 1850f;
			((TMP_Text)nameInput.descText).text = "/";
			nameInput.inputField.text = OPIGBHKFAHO();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false));
			petCheck.SetActive(DogNPC.instance.dogRelationship.HHHIIEMEJLC());
			if ((Object)(object)dogBreeds != (Object)null && (Object)(object)dogImage != (Object)null)
			{
				dogImage.sprite = dogBreeds.breeds[(int)DogNPC.instance.dogBreed].icon;
			}
		}
	}

	private void LJGOIGMHPHG()
	{
		CloseUI();
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIBack"))
		{
			CloseUI();
		}
	}

	public static DogUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private string ACKOCMBGBIH()
	{
		if (string.IsNullOrEmpty(DogNPC.instance.dogName))
		{
			return IEEIIFMNGLL[Random.Range(0, IEEIIFMNGLL.Length)];
		}
		return DogNPC.instance.dogName;
	}

	private string OPIGBHKFAHO()
	{
		if (string.IsNullOrEmpty(DogNPC.instance.dogName))
		{
			return IEEIIFMNGLL[Random.Range(1, IEEIIFMNGLL.Length)];
		}
		return DogNPC.instance.dogName;
	}

	private string MHGLFFBGEFN()
	{
		if (string.IsNullOrEmpty(DogNPC.instance.dogName))
		{
			return IEEIIFMNGLL[Random.Range(0, IEEIIFMNGLL.Length)];
		}
		return DogNPC.instance.dogName;
	}

	public static DogUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static DogUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private string FGMFGFNHHGI()
	{
		if (string.IsNullOrEmpty(DogNPC.instance.dogName))
		{
			return IEEIIFMNGLL[Random.Range(1, IEEIIFMNGLL.Length)];
		}
		return DogNPC.instance.dogName;
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			DogNPC.instance.dogName = nameInput.inputField.text;
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

	private void HOMANOMFMLM()
	{
		if (!((Object)(object)DogNPC.instance == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = DogNPC.instance.birthday.KBCEHEPDDHI();
			slider.value = (float)DogNPC.instance.dogRelationship.relationshipLevel / 100f;
			((TMP_Text)nameInput.descText).text = "";
			nameInput.inputField.text = HBLFFEADFFB();
			foodCheck.SetActive(PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false));
			petCheck.SetActive(DogNPC.instance.dogRelationship.DailyPetDone());
			if ((Object)(object)dogBreeds != (Object)null && (Object)(object)dogImage != (Object)null)
			{
				dogImage.sprite = dogBreeds.breeds[(int)DogNPC.instance.dogBreed].icon;
			}
		}
	}

	private string BMIIEAFBGLC()
	{
		if (string.IsNullOrEmpty(DogNPC.instance.dogName))
		{
			return IEEIIFMNGLL[Random.Range(1, IEEIIFMNGLL.Length)];
		}
		return DogNPC.instance.dogName;
	}

	public static DogUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void JPKKOKKFIDE()
	{
		CloseUI();
	}

	public static DogUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void OAJPHBOIOGL()
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

	private void PLDOJHACNKF()
	{
		if (!((Object)(object)DogNPC.instance == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = DogNPC.instance.birthday.OHELBLMAGPP();
			slider.value = (float)DogNPC.instance.dogRelationship.relationshipLevel / 75f;
			((TMP_Text)nameInput.descText).text = "Disabled";
			nameInput.inputField.text = HBLFFEADFFB();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true));
			waterCheck.SetActive(PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false));
			petCheck.SetActive(DogNPC.instance.dogRelationship.ELKEIADAOAA());
			if ((Object)(object)dogBreeds != (Object)null && (Object)(object)dogImage != (Object)null)
			{
				dogImage.sprite = dogBreeds.breeds[(int)DogNPC.instance.dogBreed].icon;
			}
		}
	}

	public static DogUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	private void OFOKIDPCKFG()
	{
		CloseUI();
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			DJJFMDHGOKN(CGBEIKHPCHL);
			HOMANOMFMLM();
		}
	}

	private string HBLFFEADFFB()
	{
		if (string.IsNullOrEmpty(DogNPC.instance.dogName))
		{
			return IEEIIFMNGLL[Random.Range(0, IEEIIFMNGLL.Length)];
		}
		return DogNPC.instance.dogName;
	}

	private void CGBEIKHPCHL()
	{
		CloseUI();
	}

	private void EIMIELCGLME()
	{
		CloseUI();
	}

	private void MGEBOKDGDPO()
	{
		if (!((Object)(object)DogNPC.instance == (Object)null))
		{
			((TMP_Text)birthdayTextMesh).text = DogNPC.instance.birthday.LILCGICDMEN();
			slider.value = (float)DogNPC.instance.dogRelationship.relationshipLevel / 120f;
			((TMP_Text)nameInput.descText).text = "Travelling time decreased to ";
			nameInput.inputField.text = BMIIEAFBGLC();
			foodCheck.SetActive(PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false));
			waterCheck.SetActive(PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false));
			petCheck.SetActive(DogNPC.instance.dogRelationship.FCLNEOMGDAN());
			if ((Object)(object)dogBreeds != (Object)null && (Object)(object)dogImage != (Object)null)
			{
				dogImage.sprite = dogBreeds.breeds[(int)DogNPC.instance.dogBreed].icon;
			}
		}
	}
}
