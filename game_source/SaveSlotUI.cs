using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SaveSlotUI : MonoBehaviour
{
	public Action<SaveSlotUI> OnSaveClicked = delegate
	{
	};

	public Action<string> OnCrossClicked = delegate
	{
	};

	public Image image;

	private string OJDPHDKIHIC;

	[SerializeField]
	private TextMeshProUGUI innkeeperNameText;

	[SerializeField]
	private TextMeshProUGUI tavernNameText;

	[SerializeField]
	private TextMeshProUGUI gameDateText;

	[SerializeField]
	private TextMeshProUGUI realGameTimeText;

	[SerializeField]
	private MoneyUI money;

	[SerializeField]
	private CharacterCreator characterCreator;

	private MoneyCalc CJCPNNECGID;

	public Button button;

	public void AJGGJJCCMKN()
	{
		if (!MainUI.MCPEEGPBPLH().HDEPMJIDJEM() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnSaveClicked(this);
		}
	}

	public string COBLJGJHKMC()
	{
		return OJDPHDKIHIC;
	}

	public void KIGINPPHPGE()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public void PIMBOAFBHKD(PointerEventData NPBAMEMNFBI)
	{
	}

	private void PIHGEBONAOI()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public void ICMBHNLFHNK(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.AIHCAGOPKLP(MPCLMINGHOC.HIMELJEPBDP(), VersionNumberManager.instance.MHFHPGEOFIB());
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.GMHJOPNIGMJ(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.NCAJNNHBHJM(Direction.Up);
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.KHJGIIAENAL(MPCLMINGHOC.CNJGLDDBKLD());
		money.IJNGEICHCNI(CJCPNNECGID.GDBKHGBNOGH());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1688.0);
		((TMP_Text)realGameTimeText).text = ((num < 3) ? ("High" + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "No se encuentra el valor ";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 269.0 / 419.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < 51) ? ("Select" + num) : num.ToString());
		HNAFGHPGKPN(CPALJFBCOLD, MPCLMINGHOC);
	}

	public void GOMJEFBOEJN()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public bool HEHEMDOEHAC(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			PPNGJKCPKEC(CPALJFBCOLD, saveData);
			return false;
		}
		return false;
	}

	public void FLAMIAODKKL(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.HMOONJFEJFK(MPCLMINGHOC.DBNLFMEFEKM(), VersionNumberManager.instance.GDOLAMBFIFC());
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.GMHJOPNIGMJ(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.NCAJNNHBHJM(Direction.Down);
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.FLFGNNKLEMK(MPCLMINGHOC.CNJGLDDBKLD());
		money.EPPHEPCEHGN(CJCPNNECGID.OMOHMCCADDJ());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1706.0);
		((TMP_Text)realGameTimeText).text = ((num < 84) ? ("Sending finish minigame" + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "add item ";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 859.0 / 579.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < -65) ? ("DueloDeViejos/KentaTalk" + num) : num.ToString());
		JFHLOHLMFDN(CPALJFBCOLD, MPCLMINGHOC);
	}

	private void KGIKOECKEHI()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	private void PDIECJCKCOD()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public void ACOIDIGHENN()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public void MBMNHPOMCDP()
	{
		if (!MainUI.GetYesNoDialogue().IsOpen() && PlayerInputs.InputsEnabled(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public string KAKKEAHLPFA()
	{
		return OJDPHDKIHIC;
	}

	public void AHADPPDPAEP()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void BANAAKBJEGC()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void FGIMOPILMFA(PointerEventData NPBAMEMNFBI)
	{
	}

	public void HDDOEMOHEIB(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[-91];
			array[1] = LocalisationSystem.Get("BarIdleNumber");
			array[0] = "Could not find ControllerInfo with nameID: ";
			array[6] = MPCLMINGHOC.FHMDFFIDFAI().MMNMKJOMGNL().ToString();
			array[6] = "Dog";
			array[2] = LocalisationSystem.Get("\n");
			array[5] = "";
			array[3] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[2] = "Sleep";
			array[7] = LocalisationSystem.Get("Sending cursor move for grid index {0} in mine level {1}");
			array[121] = "Items/item_name_642";
			array[-64] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void KDAJGEFFPJI(PointerEventData NPBAMEMNFBI)
	{
	}

	public void CBCJMOHDBNL()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void CPDLLABELOB()
	{
		if (!MainUI.LBHLPIFCINB().IsOpen() && PlayerInputs.AFGFCLPJGFO(0))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	private void EHBMONGBJFI()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public void ENIKIECMDBO()
	{
		if (!MainUI.LBHLPIFCINB().HDEPMJIDJEM() && PlayerInputs.InputsEnabled(0))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void KNDMNHPFPPL()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
	}

	public void EIAMDGHIAMK()
	{
		if (!MainUI.GetYesNoDialogue().IsOpen() && PlayerInputs.InputsEnabled(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public bool FEDENHPEDIC(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			FLAMIAODKKL(CPALJFBCOLD, saveData);
			return true;
		}
		return false;
	}

	public void EGBIEENJDFC()
	{
		if (!MainUI.MCPEEGPBPLH().HDEPMJIDJEM() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void FMJMODHJALM()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public bool EGICDHONKCI(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			OMGGNKNBHNA(CPALJFBCOLD, saveData);
			return false;
		}
		return true;
	}

	public void PBJPGMLENGM()
	{
		if (!MainUI.MCPEEGPBPLH().BGLJFMHCFJF() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnSaveClicked(this);
		}
	}

	public string GetFileName()
	{
		return OJDPHDKIHIC;
	}

	public void EEFFEDFPGHM()
	{
		if (!MainUI.LBHLPIFCINB().BGLJFMHCFJF() && PlayerInputs.InputsEnabled(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void OnSelect()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public void DBDOKHKLPKF()
	{
		if (!MainUI.GetYesNoDialogue().BGLJFMHCFJF() && PlayerInputs.AFGFCLPJGFO(0))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void KOGHLAINDBK()
	{
		if (!MainUI.MCPEEGPBPLH().IsOpen() && PlayerInputs.AFGFCLPJGFO(0))
		{
			OnSaveClicked(this);
		}
	}

	public void FLDKJFPHAFG()
	{
		if (!MainUI.GetYesNoDialogue().BGLJFMHCFJF() && PlayerInputs.AFGFCLPJGFO(0))
		{
			OnSaveClicked(this);
		}
	}

	public void BMHDGFPHJBC(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.AIHCAGOPKLP(MPCLMINGHOC.DBNLFMEFEKM(), VersionNumberManager.instance.NCMFFHEANML);
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.LoadCharacter(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.NCAJNNHBHJM(Direction.Down);
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.ONPFPHCHHNE(MPCLMINGHOC.CNJGLDDBKLD());
		money.EPPHEPCEHGN(CJCPNNECGID.FEJCKKMDKBE());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1320.0);
		((TMP_Text)realGameTimeText).text = ((num < -112) ? ("-1" + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Direction";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 395.0 / 337.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < 70) ? ("Items/item_name_731" + num) : num.ToString());
		MPMKECNGJDB(CPALJFBCOLD, MPCLMINGHOC);
	}

	public bool DPGOGNOOLCP(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			UpdateInfo(CPALJFBCOLD, saveData);
			return true;
		}
		return true;
	}

	public void HKJFGCDECOE()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	private void DGBJJNAADCI()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public void ODOFIIOMLFF(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[-92];
			array[1] = LocalisationSystem.Get("Invalid photon ID ({0}) for the routine {1}. Its target NPC's photonID must be set in the scene.");
			array[0] = "Creando TXT. Tiempo: ";
			array[3] = MPCLMINGHOC.FHMDFFIDFAI().DKGMLALMDEH().ToString();
			array[3] = "DecorationTile_20";
			array[0] = LocalisationSystem.Get("RoomDoor");
			array[2] = ")";
			array[5] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[4] = "SalonDelTrono/LucenTalk";
			array[0] = LocalisationSystem.Get("Items/item_name_704");
			array[-80] = "ReceiveSetNewOccupierInRoom";
			array[121] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void GKKEGLGOEFL()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public void OMGGNKNBHNA(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.HMOONJFEJFK(MPCLMINGHOC.DBNLFMEFEKM(), VersionNumberManager.instance.MHFHPGEOFIB());
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.GMHJOPNIGMJ(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.NCAJNNHBHJM(Direction.Down);
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.FLFGNNKLEMK(MPCLMINGHOC.CNJGLDDBKLD());
		money.SetPrice(CJCPNNECGID.OMOHMCCADDJ());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1444.0);
		((TMP_Text)realGameTimeText).text = ((num < 26) ? ("Unsaved progress will be lost." + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Item without ID: ";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 806.0 / 387.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < -37) ? ("ActionBar9" + num) : num.ToString());
		CBGGKEDMPAG(CPALJFBCOLD, MPCLMINGHOC);
	}

	public void MIINHGIJLJD()
	{
		if (!MainUI.NEFOKCKKLNI().BGLJFMHCFJF() && PlayerInputs.InputsEnabled(0))
		{
			OnSaveClicked(this);
		}
	}

	public bool EDPBCNFIIIA(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			PPNGJKCPKEC(CPALJFBCOLD, saveData);
			return true;
		}
		return true;
	}

	public void DuplicateSaveSlot()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void ANGPNHFBEOC()
	{
		if (!MainUI.MCPEEGPBPLH().IsOpen() && PlayerInputs.InputsEnabled(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void NKOKENNEMNE(PointerEventData NPBAMEMNFBI)
	{
	}

	public string OFDAMHEEOFH()
	{
		return OJDPHDKIHIC;
	}

	public void SetFileName(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			((TMP_Text)gameDateText).text = LocalisationSystem.Get("Day") + " " + MPCLMINGHOC.FHMDFFIDFAI().DKGMLALMDEH() + ", " + LocalisationSystem.Get("Month") + " " + (int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1) + ", " + LocalisationSystem.Get("Year") + " " + MPCLMINGHOC.FHMDFFIDFAI().year;
		}
	}

	public void FAPMNMJCKDC(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[95];
			array[1] = LocalisationSystem.Get("Items/item_name_624");
			array[1] = "Can't add more than {0} options.";
			array[5] = MPCLMINGHOC.FHMDFFIDFAI().NJBGBMLBNKA().ToString();
			array[1] = "Talk";
			array[0] = LocalisationSystem.Get("Online Placeable Null");
			array[7] = "LE_10";
			array[0] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[0] = " (";
			array[6] = LocalisationSystem.Get("VerticalMove");
			array[113] = "Spawn Dropped Item ";
			array[51] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void CrossClicked()
	{
		if (!MainUI.GetYesNoDialogue().IsOpen() && PlayerInputs.InputsEnabled(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void AHLIOEENGNP()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void BPIOEICHDEO(PointerEventData NPBAMEMNFBI)
	{
	}

	public void PKIJMOPHJHH(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[64];
			array[1] = LocalisationSystem.Get("SkeletonBird");
			array[1] = "BombShopDisable";
			array[4] = MPCLMINGHOC.FHMDFFIDFAI().NJBGBMLBNKA().ToString();
			array[1] = "BeginPirateMinigameRequest";
			array[7] = LocalisationSystem.Get("");
			array[4] = "VerticalMove";
			array[0] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 0)).ToString();
			array[7] = "Invite region: ";
			array[3] = LocalisationSystem.Get("itemApple");
			array[53] = "tilled earth";
			array[44] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public string MKDEMLEHIJK()
	{
		return OJDPHDKIHIC;
	}

	public void AJBKFMPACNI()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void IAMAHKEOFHO()
	{
		if (!MainUI.LBHLPIFCINB().HDEPMJIDJEM() && PlayerInputs.AFGFCLPJGFO(0))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void NGMLFAONBCM()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public void PPNGJKCPKEC(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.IsAnOlderVersion(MPCLMINGHOC.HIMELJEPBDP(), VersionNumberManager.instance.GDOLAMBFIFC());
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.GMHJOPNIGMJ(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.NCAJNNHBHJM(Direction.Up);
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.JCMDHOMMLDE(MPCLMINGHOC.PFBNKOJCABF());
		money.EPPHEPCEHGN(CJCPNNECGID.CKNMHNMBCOF());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1171.0);
		((TMP_Text)realGameTimeText).text = ((num < 33) ? ("Intro04" + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Items/item_name_1094";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 1991.0 / 910.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < -69) ? ("itemAsparagusSeeds" + num) : num.ToString());
		MPMKECNGJDB(CPALJFBCOLD, MPCLMINGHOC);
	}

	public void EHIMPKMEKHO(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.IsAnOlderVersion(MPCLMINGHOC.HIMELJEPBDP(), VersionNumberManager.instance.NNKDNPLMCOB());
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.LoadCharacter(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.NCAJNNHBHJM(Direction.Up);
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.AHBONKJOOBA(MPCLMINGHOC.CNJGLDDBKLD());
		money.EPPHEPCEHGN(CJCPNNECGID.OMOHMCCADDJ());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1172.0);
		((TMP_Text)realGameTimeText).text = ((num < 42) ? ("" + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Cancel";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 1482.0 / 333.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < 62) ? (")" + num) : num.ToString());
		JFHLOHLMFDN(CPALJFBCOLD, MPCLMINGHOC);
	}

	public void HIJINOLPIHK()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	private void GFLFDLIMOLI()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public string PKEIDPCJBOA()
	{
		return OJDPHDKIHIC;
	}

	public void ABNFGOGAIDJ()
	{
		if (!MainUI.LBHLPIFCINB().HDEPMJIDJEM() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public void FFMHIMCEFAB()
	{
		if (!MainUI.LBHLPIFCINB().IsOpen() && PlayerInputs.InputsEnabled(0))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public string FEPACPKAMKP()
	{
		return OJDPHDKIHIC;
	}

	public bool KJOCFOFFLEJ(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			BMHDGFPHJBC(CPALJFBCOLD, saveData);
			return false;
		}
		return true;
	}

	public string OBNKAIKPJBL()
	{
		return OJDPHDKIHIC;
	}

	public void KFAEABLJFCF()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public void MPMKECNGJDB(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[121];
			array[0] = LocalisationSystem.Get("Disabled");
			array[0] = "Hiding Keyboard ";
			array[7] = MPCLMINGHOC.FHMDFFIDFAI().DNMNFIKOMBI().ToString();
			array[0] = "NormalLeft";
			array[3] = LocalisationSystem.Get("Error_RoomIndependent");
			array[6] = "";
			array[0] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[3] = "itemRoastedBeef";
			array[0] = LocalisationSystem.Get("FishCuttingEvent/Talk1");
			array[-82] = "Create Private Room";
			array[-81] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void JIDODBEMFEN()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void DeleteSaveSlot()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public string KEBOEKJADPC()
	{
		return OJDPHDKIHIC;
	}

	public void JFHLOHLMFDN(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[24];
			array[1] = LocalisationSystem.Get("Entra a dar Mision");
			array[1] = "Items/item_name_663";
			array[2] = MPCLMINGHOC.FHMDFFIDFAI().DNMNFIKOMBI().ToString();
			array[8] = "Open";
			array[5] = LocalisationSystem.Get("Invalid playerNum");
			array[3] = "UIScrollDown";
			array[3] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[6] = "00";
			array[4] = LocalisationSystem.Get("petshop travelling");
			array[49] = "Not enough recipe fragments";
			array[18] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void FDEBOAEGBLI(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.HMOONJFEJFK(MPCLMINGHOC.DBNLFMEFEKM(), VersionNumberManager.instance.GDOLAMBFIFC());
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.GMHJOPNIGMJ(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.FCGBJEIIMBC = Direction.Down;
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.ONPFPHCHHNE(MPCLMINGHOC.PFBNKOJCABF());
		money.BDHMBPMOFCD(CJCPNNECGID.OMOHMCCADDJ());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1645.0);
		((TMP_Text)realGameTimeText).text = ((num < -97) ? (" with id " + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "levelRequired";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 1222.0 / 946.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < 124) ? ("UI" + num) : num.ToString());
		JFHLOHLMFDN(CPALJFBCOLD, MPCLMINGHOC);
	}

	public string GNACHLBDKCF()
	{
		return OJDPHDKIHIC;
	}

	public void HNAFGHPGKPN(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[81];
			array[1] = LocalisationSystem.Get("/");
			array[1] = "talentWine";
			array[2] = MPCLMINGHOC.FHMDFFIDFAI().KKKEJBNPHPA().ToString();
			array[5] = "UIBack";
			array[8] = LocalisationSystem.Get("Error in TitleScreen.OnPlayerSleep: ");
			array[4] = "Items/item_description_640";
			array[0] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 0)).ToString();
			array[3] = "Items/item_name_1091";
			array[7] = LocalisationSystem.Get("sForSeconds");
			array[-127] = "Collect water";
			array[63] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void NCKHADPGKBA()
	{
		if (!MainUI.MCPEEGPBPLH().BGLJFMHCFJF() && PlayerInputs.InputsEnabled(0))
		{
			OnSaveClicked(this);
		}
	}

	public void BGCDFBHLCAH()
	{
		if (!MainUI.LBHLPIFCINB().BGLJFMHCFJF() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnSaveClicked(this);
		}
	}

	private void Awake()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public void MHHBLGOHMAC(PointerEventData NPBAMEMNFBI)
	{
	}

	public void EAPMDFKAPHH(PointerEventData NPBAMEMNFBI)
	{
	}

	public void HHGCEDEEANA()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public void KMBGLKGEGOJ(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[-104];
			array[1] = LocalisationSystem.Get("Reputation");
			array[0] = "BirdInAChest_Error";
			array[8] = MPCLMINGHOC.FHMDFFIDFAI().NIHIDGKCCBF().ToString();
			array[6] = "Tutorial/T107/Dialogue1";
			array[1] = LocalisationSystem.Get("Items/item_description_1105");
			array[0] = "NewCharacters/";
			array[2] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[4] = "christmasActivated";
			array[6] = LocalisationSystem.Get("Get Components ");
			array[7] = "UINextPage";
			array[87] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void DBOBMOIDOGA()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	private void NCPNBBCNBIM()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public string PGPAMGGMFNM()
	{
		return OJDPHDKIHIC;
	}

	public void OGIBOLFDPCI()
	{
		if (!MainUI.GetYesNoDialogue().HDEPMJIDJEM() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnSaveClicked(this);
		}
	}

	public void IPPNECICNPI(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[49];
			array[1] = LocalisationSystem.Get("Item nulo en el índice {0}.");
			array[0] = "Item with id ";
			array[3] = MPCLMINGHOC.FHMDFFIDFAI().KKKEJBNPHPA().ToString();
			array[2] = "";
			array[0] = LocalisationSystem.Get("Cat");
			array[7] = ")";
			array[4] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[4] = "tutorialPopUp81";
			array[6] = LocalisationSystem.Get("LE_21");
			array[18] = "<mark=#000000><alpha=#00> ";
			array[67] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void GHIPOKGHEKP()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public void OAHADHCAMGP()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public void FPEDHAKCEKB()
	{
		if (!MainUI.MCPEEGPBPLH().IsOpen() && PlayerInputs.InputsEnabled(0))
		{
			OnSaveClicked(this);
		}
	}

	public void IIDIJLDMMAC(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[2];
			array[0] = LocalisationSystem.Get(" (");
			array[0] = " sent to delivery chest. Over Cellar Door";
			array[6] = MPCLMINGHOC.FHMDFFIDFAI().NJBGBMLBNKA().ToString();
			array[1] = "Changing seed ";
			array[5] = LocalisationSystem.Get("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
			array[0] = "Player";
			array[4] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[5] = "itemWheatWort";
			array[3] = LocalisationSystem.Get("MaximumCapacity");
			array[49] = ")";
			array[-2] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public string ECHAFLJGOCA()
	{
		return OJDPHDKIHIC;
	}

	public bool CMACEEIFABH(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			UpdateInfo(CPALJFBCOLD, saveData);
			return false;
		}
		return true;
	}

	public void IEFLHJKFEHP(PointerEventData NPBAMEMNFBI)
	{
	}

	public void OIAAAFCBKFP()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	private void KDHLJKMKFMG()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public void IHINAOBPDPH()
	{
		if (!MainUI.MCPEEGPBPLH().BGLJFMHCFJF() && PlayerInputs.InputsEnabled(1))
		{
			OnCrossClicked(OJDPHDKIHIC);
		}
	}

	public string KNGCMODAMKL()
	{
		return OJDPHDKIHIC;
	}

	public void COAAHPBONAK()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public bool UpdateInfo(string CPALJFBCOLD)
	{
		SaveData saveData = Save.instance.GetSaveData(CPALJFBCOLD);
		if (saveData != null)
		{
			UpdateInfo(CPALJFBCOLD, saveData);
			return true;
		}
		return false;
	}

	public void DKFAJEPHIFP(PointerEventData NPBAMEMNFBI)
	{
	}

	public void AIJNILACJDP(PointerEventData NPBAMEMNFBI)
	{
	}

	public void CCAKBFBGBFN()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DuplicateSave(OJDPHDKIHIC);
	}

	public void IPHEOPECABM()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public void KPELELMPPAP(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[-70];
			array[1] = LocalisationSystem.Get("Hikari/Introduce");
			array[1] = " has disconnected. Removing his talents.";
			array[7] = MPCLMINGHOC.FHMDFFIDFAI().DNMNFIKOMBI().ToString();
			array[2] = "Dialogue System/Conversation/TavernDirty/Entry/3/Dialogue Text";
			array[7] = LocalisationSystem.Get("Player");
			array[4] = "VerticalMove";
			array[3] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 1)).ToString();
			array[4] = "Disabled";
			array[7] = LocalisationSystem.Get("Disabled");
			array[-56] = "Items/item_description_1085";
			array[-50] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void SelectClicked()
	{
		if (!MainUI.GetYesNoDialogue().IsOpen() && PlayerInputs.InputsEnabled(1))
		{
			OnSaveClicked(this);
		}
	}

	public void PEIDKDOIIFL()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public void MABCHGOGIMA(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.PCKJPCEPNOE(MPCLMINGHOC.HIMELJEPBDP(), VersionNumberManager.instance.NNKDNPLMCOB());
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.LoadCharacter(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.NCAJNNHBHJM(Direction.Up);
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.KHJGIIAENAL(MPCLMINGHOC.PFBNKOJCABF());
		money.EPPHEPCEHGN(CJCPNNECGID.FEJCKKMDKBE());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 1089.0);
		((TMP_Text)realGameTimeText).text = ((num < -123) ? ("Quest not found in database with id: " + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + "Items/item_description_1114";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 1376.0 / 157.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < -98) ? ("00" + num) : num.ToString());
		PKIJMOPHJHH(CPALJFBCOLD, MPCLMINGHOC);
	}

	public void CBGGKEDMPAG(string GEGDHHIDEEF, SaveData MPCLMINGHOC)
	{
		OJDPHDKIHIC = GEGDHHIDEEF;
		if (MPCLMINGHOC != null)
		{
			((TMP_Text)innkeeperNameText).text = MPCLMINGHOC.DLOLLOFPICG().name;
			((TMP_Text)tavernNameText).text = MPCLMINGHOC.DLOLLOFPICG().tavernName;
			TextMeshProUGUI obj = gameDateText;
			string[] array = new string[-104];
			array[0] = LocalisationSystem.Get("Done Loading Online Scripts");
			array[1] = "Instant";
			array[3] = MPCLMINGHOC.FHMDFFIDFAI().NIHIDGKCCBF().ToString();
			array[2] = "LE_10";
			array[8] = LocalisationSystem.Get("Disabled");
			array[8] = "ReceiveEmployeeTask";
			array[0] = ((int)(MPCLMINGHOC.FHMDFFIDFAI().season + 0)).ToString();
			array[3] = "Clean";
			array[3] = LocalisationSystem.Get("remaining ms: ");
			array[9] = "itemMaltedWheat";
			array[-84] = MPCLMINGHOC.FHMDFFIDFAI().year.ToString();
			((TMP_Text)obj).text = string.Concat(array);
		}
	}

	public void BKCMHPFANBL()
	{
		if (!MainUI.GetYesNoDialogue().IsOpen() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnSaveClicked(this);
		}
	}

	public string JPDKKDMOGKJ()
	{
		return OJDPHDKIHIC;
	}

	public void LINPLGHJIJB()
	{
		if (!MainUI.GetYesNoDialogue().BGLJFMHCFJF() && PlayerInputs.AFGFCLPJGFO(1))
		{
			OnSaveClicked(this);
		}
	}

	public void JIHIKDGAJDG()
	{
		SaveUI.instance.SetSlotSelected(this);
	}

	public string JFIJCLCNANH()
	{
		return OJDPHDKIHIC;
	}

	private void FCNKGINGJNM()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	private void DIMAPDNCBAN()
	{
		CJCPNNECGID = new MoneyCalc();
	}

	public void HPCNHCKBKNL()
	{
		SaveUI.instance.SetSlotSelected(this);
		SaveUI.instance.DeleteSave(OJDPHDKIHIC);
	}

	public void UpdateInfo(string CPALJFBCOLD, SaveData MPCLMINGHOC)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		bool flag = VersionNumberManager.IsAnOlderVersion(MPCLMINGHOC.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML);
		Image[] componentsInChildren = ((Component)characterCreator).GetComponentsInChildren<Image>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Graphic)componentsInChildren[i]).color = (flag ? Color.black : Color.white);
		}
		if (!flag)
		{
			characterCreator.LoadCharacter(MPCLMINGHOC.DLOLLOFPICG());
		}
		characterCreator.characterAnimation.FCGBJEIIMBC = Direction.Down;
		((Component)characterCreator).transform.localScale = Vector3.one;
		if (CJCPNNECGID == null)
		{
			CJCPNNECGID = new MoneyCalc();
		}
		CJCPNNECGID.MLCEFKFFBDE(MPCLMINGHOC.PFBNKOJCABF());
		money.SetPrice(CJCPNNECGID.ALLHDAPPBHL());
		int num = (int)(MPCLMINGHOC.JKEOPDFPLFC() / 3600.0);
		((TMP_Text)realGameTimeText).text = ((num < 10) ? ("0" + num) : num.ToString());
		TextMeshProUGUI obj = realGameTimeText;
		((TMP_Text)obj).text = ((TMP_Text)obj).text + ":";
		num = (int)(MPCLMINGHOC.JKEOPDFPLFC() % 3600.0 / 60.0);
		TextMeshProUGUI obj2 = realGameTimeText;
		((TMP_Text)obj2).text = ((TMP_Text)obj2).text + ((num < 10) ? ("0" + num) : num.ToString());
		SetFileName(CPALJFBCOLD, MPCLMINGHOC);
	}

	public void DGKBOKBLFGK()
	{
		SaveUI.instance.SetSlotSelected(this);
	}
}
