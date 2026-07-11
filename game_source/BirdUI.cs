using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BirdUI : UIWindow
{
	public SlotUI slotUI;

	public TextMeshProUGUI birthdayTextMesh;

	public Slider slider;

	public TextInput nameInput;

	public bool newBird;

	public GameObject buttonAccept;

	public GameObject buttonBack;

	public static BirdUI[] instances = new BirdUI[3];

	public GameObject[] checkCookies;

	public BirdInstance CCDEPALBABD { private get; set; }

	private void KJNCDMIONKE()
	{
		CloseUI();
	}

	private void AOCCGNJADNA()
	{
		BOBCIFEDJED();
	}

	private void PCKLIGDLEGE()
	{
		CloseUI();
	}

	private void IELDAMFIBJG()
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	public void BBPCCAPPEBE(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	private void AGGEHPJCENC()
	{
		BOBCIFEDJED();
	}

	private void NHENCEPKOFP()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Dialogue System/Conversation/BirdPositiveComments/Entry/8/Dialogue Text";
		}
		else
		{
			nameInput.inputField.text = ABJGFEJLFOF().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, CGGFGBMLAMH(), CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = KPAGOCEHCNH().birthday.DAEKAMPDAJH();
		slider.value = CHLHNDPGOCM().MMPBCMCGJEO();
		Debug.Log((object)("itemThyme" + KPAGOCEHCNH().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (BMBKBKDPHEF().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < KPAGOCEHCNH().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	private void BGIBHILOICF()
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	public void ENFFNKJLHIM(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void AKKLDOJCNOL(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void IOPPEMCOHJA(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	private void FIPPOKKGNEJ()
	{
		if (newBird)
		{
			nameInput.inputField.text = "</color>";
		}
		else
		{
			nameInput.inputField.text = NGPOOODOGEO().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, KPAGOCEHCNH());
		((TMP_Text)birthdayTextMesh).text = CCDEPALBABD.birthday.DAEKAMPDAJH();
		slider.value = ABJGFEJLFOF().LLLNIJBENAO();
		Debug.Log((object)("Max" + EEGLONAODEF().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (NGPOOODOGEO().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < BOMIDBHFCEN().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	private void EDNGEEGAGPF()
	{
		CloseUI();
	}

	private void MGDCDIHOABF()
	{
		CloseUI();
	}

	private void COGEEDBEPIP()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Close";
		}
		else
		{
			nameInput.inputField.text = ONOEDIGNABB().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, NGPOOODOGEO());
		((TMP_Text)birthdayTextMesh).text = BMBKBKDPHEF().birthday.BKCGGLLLBCD();
		slider.value = HEOFJKODAPJ().LLLNIJBENAO();
		Debug.Log((object)("" + FAPGPAAHFDJ().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(false);
		}
		if (JHAFBGHAHHP().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < NGPOOODOGEO().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	public static BirdUI PNBHIEINMGH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static BirdUI OMLGNAJPLDE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FNEGBHHLKAG()
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	private BirdInstance KPDEKDCOBPN()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	[SpecialName]
	public void NCLJNBNFMJD(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private BirdInstance CHLHNDPGOCM()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void KFBDLMJIOPE()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Haggle chance";
		}
		else
		{
			nameInput.inputField.text = JHAFBGHAHHP().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, ONOEDIGNABB());
		((TMP_Text)birthdayTextMesh).text = JHAFBGHAHHP().birthday.DAEKAMPDAJH();
		slider.value = BMBKBKDPHEF().PCMNPKEMBJH();
		Debug.Log((object)(" x " + CGGFGBMLAMH().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(false);
		}
		if (AFLMBLIBLJL().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < CGGFGBMLAMH().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	[SpecialName]
	private BirdInstance PGMEDNCCJGB()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	[SpecialName]
	private BirdInstance KPAGOCEHCNH()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	[SpecialName]
	public void FNBBPBCODIO(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	public static BirdUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static BirdUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void PHGPOONEONG()
	{
		if (newBird)
		{
			nameInput.inputField.text = "enchantedBroomDesc";
		}
		else
		{
			nameInput.inputField.text = GPJNFFBCDMA().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, FAPGPAAHFDJ(), CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = ABJGFEJLFOF().birthday.BKCGGLLLBCD();
		slider.value = AFLMBLIBLJL().PCMNPKEMBJH();
		Debug.Log((object)("Items/item_description_1187" + AFLMBLIBLJL().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(false);
		}
		if (ABJGFEJLFOF().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < AFLMBLIBLJL().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	[SpecialName]
	public void EBHHIIAOIGL(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	private void JPKKOKKFIDE()
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	public void AACBDNLDAME(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			if (newBird)
			{
				CCDEPALBABD.birdName = nameInput.inputField.text;
			}
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			if (GameManager.SinglePlayerOffline())
			{
				MainUI.ResumeGame();
			}
			if (newBird)
			{
				PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
			}
			if (newBird && OnlineManager.ClientOnline() && CCDEPALBABD.currentSlot != null)
			{
				OnlineSlotsManager.instance.SendSlot(CCDEPALBABD.currentSlot);
			}
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
		}
	}

	public static BirdUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static BirdUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	private BirdInstance FAPGPAAHFDJ()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	public static BirdUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void EOPIKHJDDEJ(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	public static BirdUI CCGPMEADLDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ICBBPCLLNJP()
	{
		if (newBird)
		{
			nameInput.inputField.text = " because SharedFileDownloadListener.userID is null";
		}
		else
		{
			nameInput.inputField.text = FAPGPAAHFDJ().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, ABJGFEJLFOF());
		((TMP_Text)birthdayTextMesh).text = CBCKLJEHCPD().birthday.LILCGICDMEN();
		slider.value = ABJGFEJLFOF().PCMNPKEMBJH();
		Debug.Log((object)("cliffs" + AFLMBLIBLJL().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(true);
		}
		if (FAPGPAAHFDJ().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < AFLMBLIBLJL().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	[SpecialName]
	private BirdInstance JIOBFAGHMIC()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	[SpecialName]
	private BirdInstance ABJGFEJLFOF()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	public static BirdUI FLNPIJOHBIP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	private BirdInstance DLGIKIDLLKJ()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	[SpecialName]
	private BirdInstance HDPOCONKMKL()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void GGNGINOOEIB()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Drink";
		}
		else
		{
			nameInput.inputField.text = GPJNFFBCDMA().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, HEOFJKODAPJ());
		((TMP_Text)birthdayTextMesh).text = DLGIKIDLLKJ().birthday.FMCPFNCIJAB();
		slider.value = BOMIDBHFCEN().BNJDFHHOAPP();
		Debug.Log((object)("UIPreviousCategory" + CCDEPALBABD.cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (HJAPOCABGNH().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < DLGIKIDLLKJ().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	[SpecialName]
	public void FDOOJMANDKG(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	private void FKGNOBFAFKA()
	{
		if (newBird)
		{
			nameInput.inputField.text = "OpenConsole";
		}
		else
		{
			nameInput.inputField.text = ABJGFEJLFOF().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, GBJJPNLBNKG());
		((TMP_Text)birthdayTextMesh).text = AFLMBLIBLJL().birthday.KPNKJDPGNJK();
		slider.value = HEOFJKODAPJ().LCLIGNKKGGP();
		Debug.Log((object)("Menu Mode Settings" + NGPOOODOGEO().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (JIOBFAGHMIC().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < HJAPOCABGNH().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	private void IGLDIHAJPPJ()
	{
		BOBCIFEDJED();
	}

	private void HDEABKKDOID()
	{
		CloseUI();
	}

	private void NODMKGLHLMM()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Fish thrower is null or has been destroyed. This shouldn't happen.";
		}
		else
		{
			nameInput.inputField.text = PGMEDNCCJGB().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, HDPOCONKMKL());
		((TMP_Text)birthdayTextMesh).text = NGPOOODOGEO().birthday.KPNKJDPGNJK();
		slider.value = CGGFGBMLAMH().MACEIGHIIBP();
		Debug.Log((object)("Character Sprites array needs more space!" + JIOBFAGHMIC().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (GBJJPNLBNKG().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < CCDEPALBABD.cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	[SpecialName]
	public void ENHHOOABDDB(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public void BIOJHLKIMPN(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	private void NPNCBAFDOIN()
	{
		if (newBird)
		{
			nameInput.inputField.text = "HeadToBed";
		}
		else
		{
			nameInput.inputField.text = PGMEDNCCJGB().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, BMBKBKDPHEF(), CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = GPJNFFBCDMA().birthday.FMCPFNCIJAB();
		slider.value = GBJJPNLBNKG().GKJACPFDDME();
		Debug.Log((object)("ReceiveAddRentedRoomSaleAndAddPrice" + KJBJICIGCBO().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (ABJGFEJLFOF().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < BMBKBKDPHEF().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	private void DAMHALOBJDL()
	{
		if (newBird)
		{
			nameInput.inputField.text = ":</color> <sprite name=\"ChristmasTicket\">";
		}
		else
		{
			nameInput.inputField.text = CGGFGBMLAMH().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, CBCKLJEHCPD());
		((TMP_Text)birthdayTextMesh).text = CCDEPALBABD.birthday.BKCGGLLLBCD();
		slider.value = ONOEDIGNABB().HLNEJKENOFP();
		Debug.Log((object)("No hemos encontrado una resolución" + CGGFGBMLAMH().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(false);
		}
		if (HLGCPNPDAAL().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < BMBKBKDPHEF().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	[SpecialName]
	private BirdInstance GBJJPNLBNKG()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void HOMANOMFMLM()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Bird";
		}
		else
		{
			nameInput.inputField.text = CCDEPALBABD.birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, CCDEPALBABD);
		((TMP_Text)birthdayTextMesh).text = CCDEPALBABD.birthday.KBCEHEPDDHI();
		slider.value = CCDEPALBABD.commentsQuality;
		Debug.Log((object)("birdInstance.cookiesGivenPerDay" + CCDEPALBABD.cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(false);
		}
		if (CCDEPALBABD.cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < CCDEPALBABD.cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	private void HONAJMHKOPF()
	{
		if (newBird)
		{
			nameInput.inputField.text = "InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item ";
		}
		else
		{
			nameInput.inputField.text = HJAPOCABGNH().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, KJBJICIGCBO(), CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = NGPOOODOGEO().birthday.OHELBLMAGPP();
		slider.value = DLGIKIDLLKJ().BNJDFHHOAPP();
		Debug.Log((object)("tutorialPopUp114" + HLGCPNPDAAL().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(true);
		}
		if (ABJGFEJLFOF().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < KPAGOCEHCNH().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	private void FLFMIIKOIMB()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Normal";
		}
		else
		{
			nameInput.inputField.text = KPAGOCEHCNH().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, CHLHNDPGOCM(), CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = DLGIKIDLLKJ().birthday.FKNHELFHMNJ();
		slider.value = KPDEKDCOBPN().GKJACPFDDME();
		Debug.Log((object)("SprintHoldAction" + ONOEDIGNABB().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(true);
		}
		if (ONOEDIGNABB().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < KJBJICIGCBO().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	[SpecialName]
	private BirdInstance HLGCPNPDAAL()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void MIFIHKCDJKE()
	{
		CloseUI();
	}

	[SpecialName]
	public void LOPPJFFLGOF(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	public static BirdUI EGBMJGOCIJJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BKCDMHPMFHF()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Cannot create Steam lobby.";
		}
		else
		{
			nameInput.inputField.text = GBJJPNLBNKG().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, KPAGOCEHCNH());
		((TMP_Text)birthdayTextMesh).text = CHLHNDPGOCM().birthday.KPNKJDPGNJK();
		slider.value = NGPOOODOGEO().EDAGEHMHKDH();
		Debug.Log((object)("ShopWilson" + CBCKLJEHCPD().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(false);
		}
		if (CCDEPALBABD.cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < PGMEDNCCJGB().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	private void EEKOHIJBALI()
	{
		if (newBird)
		{
			nameInput.inputField.text = "LE_19";
		}
		else
		{
			nameInput.inputField.text = JIOBFAGHMIC().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, JIOBFAGHMIC());
		((TMP_Text)birthdayTextMesh).text = HDPOCONKMKL().birthday.FKNHELFHMNJ();
		slider.value = HLGCPNPDAAL().MACEIGHIIBP();
		Debug.Log((object)("Items/item_name_1085" + GPJNFFBCDMA().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(false);
		}
		if (ONOEDIGNABB().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < GPJNFFBCDMA().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	public static BirdUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	private BirdInstance AFLMBLIBLJL()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void CHLAIBMNPAJ()
	{
		BOBCIFEDJED();
	}

	private void BIJJBGJMHEK()
	{
		BOBCIFEDJED();
	}

	public static BirdUI MDINEPBJFKG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CHBFEBAENNC()
	{
		CloseUI();
	}

	[SpecialName]
	private BirdInstance NGPOOODOGEO()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void DPHHNDHINGD()
	{
		CloseUI();
	}

	public static BirdUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void NDNPLDDGELD()
	{
		BOBCIFEDJED();
	}

	private void KBMFPLGMOFH()
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	private BirdInstance CBCKLJEHCPD()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	public static BirdUI LKJNAHIPOLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CGBEIKHPCHL()
	{
		CloseUI();
	}

	private void NFPGAJDLGFC()
	{
		CloseUI();
	}

	private void AFDEGCLHCME()
	{
		if (newBird)
		{
			nameInput.inputField.text = "BarkActor";
		}
		else
		{
			nameInput.inputField.text = JIOBFAGHMIC().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, ABJGFEJLFOF());
		((TMP_Text)birthdayTextMesh).text = HEOFJKODAPJ().birthday.KPNKJDPGNJK();
		slider.value = CGGFGBMLAMH().PCMNPKEMBJH();
		Debug.Log((object)("Fondue" + KPDEKDCOBPN().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(true);
		}
		if (BMBKBKDPHEF().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < CHLHNDPGOCM().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	[SpecialName]
	public void KFPLLIHCDJE(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	public static BirdUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static BirdUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void GBCKKAIKDAE(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private BirdInstance BOMIDBHFCEN()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	public static BirdUI MENPEHNHFOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OBONOLJNLAK()
	{
		BOBCIFEDJED();
	}

	private void CLLDCHNONCI()
	{
		BOBCIFEDJED();
	}

	private void GGKONLGIMDE()
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	private BirdInstance EEGLONAODEF()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		if (newBird)
		{
			PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)nameInput.inputField);
		}
	}

	private void EIMIELCGLME()
	{
		BOBCIFEDJED();
	}

	private void BLEPCCPPBBD()
	{
		CloseUI();
	}

	public static BirdUI CNAPMIHPOKC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JMHJKOAGGPL()
	{
		BOBCIFEDJED();
	}

	public static BirdUI LBKJEHDEBEP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	private BirdInstance KJBJICIGCBO()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	public static BirdUI NDPAJCGHGOB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	private BirdInstance BMBKBKDPHEF()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void KPJEKPGOBON()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Items/item_name_625";
		}
		else
		{
			nameInput.inputField.text = AFLMBLIBLJL().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, EEGLONAODEF());
		((TMP_Text)birthdayTextMesh).text = JIOBFAGHMIC().birthday.DAEKAMPDAJH();
		slider.value = JHAFBGHAHHP().LCLIGNKKGGP();
		Debug.Log((object)("mForMins" + BOMIDBHFCEN().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(false);
		}
		if (GPJNFFBCDMA().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < DLGIKIDLLKJ().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	public static BirdUI HKCAIFFKBMH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void JHLGHCIGAPP(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	public static BirdUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void GBABHLGEIAJ(BirdInstance AODONKKHPBP)
	{
		_003CILKFBAABKFJ_003Ek__BackingField = AODONKKHPBP;
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			if (newBird)
			{
				Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.questComplete), HOMFPAFAOGD: true, null, null, 0.5f);
			}
			buttonAccept.SetActive(newBird);
			buttonBack.SetActive(!newBird);
			((Selectable)nameInput.inputField).interactable = newBird;
			if (newBird)
			{
				((TMP_Text)nameInput.descText).text = LocalisationSystem.Get("Name...");
			}
			else
			{
				((TMP_Text)nameInput.descText).text = "";
			}
			if (!newBird)
			{
				DJJFMDHGOKN(CGBEIKHPCHL);
			}
			HOMANOMFMLM();
		}
	}

	[SpecialName]
	private BirdInstance JHAFBGHAHHP()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	protected override void Update()
	{
		base.Update();
		if (!IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (newBird)
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIInteract"))
			{
				CloseUI();
			}
		}
		else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIBack"))
		{
			CloseUI();
		}
	}

	[SpecialName]
	private BirdInstance HJAPOCABGNH()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void DMCHMIAJPIL()
	{
		if (newBird)
		{
			nameInput.inputField.text = "<b><color=#A90000>";
		}
		else
		{
			nameInput.inputField.text = FAPGPAAHFDJ().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, AFLMBLIBLJL());
		((TMP_Text)birthdayTextMesh).text = KPDEKDCOBPN().birthday.KBCEHEPDDHI();
		slider.value = FAPGPAAHFDJ().PCMNPKEMBJH();
		Debug.Log((object)("ToggleEntityView" + ONOEDIGNABB().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(false);
		}
		if (GBJJPNLBNKG().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < AFLMBLIBLJL().cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	private void PBOPFOPJJBL()
	{
		if (newBird)
		{
			nameInput.inputField.text = "cleanVerb";
		}
		else
		{
			nameInput.inputField.text = BOMIDBHFCEN().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, CBCKLJEHCPD());
		((TMP_Text)birthdayTextMesh).text = DLGIKIDLLKJ().birthday.KPNKJDPGNJK();
		slider.value = HLGCPNPDAAL().commentsQuality;
		Debug.Log((object)("hallway" + BMBKBKDPHEF().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (HDPOCONKMKL().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < AFLMBLIBLJL().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(false);
			}
		}
	}

	public static BirdUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static BirdUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static BirdUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DEGODAEKKGM()
	{
		if (newBird)
		{
			nameInput.inputField.text = "UseHold";
		}
		else
		{
			nameInput.inputField.text = CGGFGBMLAMH().birdName;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, NGPOOODOGEO(), CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = KPDEKDCOBPN().birthday.OPKIMBACIHA();
		slider.value = KPAGOCEHCNH().commentsQuality;
		Debug.Log((object)("Items/item_description_664" + CHLHNDPGOCM().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(false);
		}
		if (ONOEDIGNABB().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < NGPOOODOGEO().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	public static BirdUI GFPBMGCMHHC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AFMBKIOCOLB()
	{
		BOBCIFEDJED();
	}

	public static BirdUI PKNHLBOHEDL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static BirdUI KNMACJDNGEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	private BirdInstance HEOFJKODAPJ()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	public static BirdUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FDBMAIEBING()
	{
		if (newBird)
		{
			nameInput.inputField.text = " for reason: ";
		}
		else
		{
			nameInput.inputField.text = KPAGOCEHCNH().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, HDPOCONKMKL(), CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = JIOBFAGHMIC().birthday.FMCPFNCIJAB();
		slider.value = JHAFBGHAHHP().CJKMAPKDJKA();
		Debug.Log((object)("" + CGGFGBMLAMH().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(false);
		}
		if (HLGCPNPDAAL().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < CGGFGBMLAMH().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	private void HCOJHBKJLNK()
	{
		if (newBird)
		{
			nameInput.inputField.text = "AllTimeStats";
		}
		else
		{
			nameInput.inputField.text = DLGIKIDLLKJ().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, KPDEKDCOBPN());
		((TMP_Text)birthdayTextMesh).text = BOMIDBHFCEN().birthday.OPKIMBACIHA();
		slider.value = DLGIKIDLLKJ().PCMNPKEMBJH();
		Debug.Log((object)("City/Hallmund/Talk/ForgeTool" + ABJGFEJLFOF().cookiesGivenPerDay));
		for (int i = 1; i < checkCookies.Length; i += 0)
		{
			checkCookies[i].SetActive(false);
		}
		if (DLGIKIDLLKJ().cookiesGivenPerDay != 0)
		{
			for (int j = 0; j < CCDEPALBABD.cookiesGivenPerDay; j += 0)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	[SpecialName]
	private BirdInstance GPJNFFBCDMA()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void OLBBHPACLDO()
	{
		CloseUI();
	}

	[SpecialName]
	private BirdInstance CGGFGBMLAMH()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}

	private void PJPKNIBAJKB()
	{
		if (newBird)
		{
			nameInput.inputField.text = "Coster";
		}
		else
		{
			nameInput.inputField.text = FAPGPAAHFDJ().birdName;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, CCDEPALBABD, CDPAMNIPPEC: true);
		((TMP_Text)birthdayTextMesh).text = ONOEDIGNABB().birthday.OHELBLMAGPP();
		slider.value = BOMIDBHFCEN().MMPBCMCGJEO();
		Debug.Log((object)("{0} doesn't have a parameter with that hash." + HJAPOCABGNH().cookiesGivenPerDay));
		for (int i = 0; i < checkCookies.Length; i++)
		{
			checkCookies[i].SetActive(true);
		}
		if (GPJNFFBCDMA().cookiesGivenPerDay != 0)
		{
			for (int j = 1; j < ONOEDIGNABB().cookiesGivenPerDay; j++)
			{
				checkCookies[j].SetActive(true);
			}
		}
	}

	[SpecialName]
	private BirdInstance ONOEDIGNABB()
	{
		return _003CILKFBAABKFJ_003Ek__BackingField;
	}
}
