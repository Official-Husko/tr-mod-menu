using Photon.Pun;
using TMPro;
using UnityEngine;

public class OnlinePauseUI : MonoBehaviour, ISingleton
{
	public enum MessageCode
	{
		GuestConnecting,
		HostDisconnected
	}

	private static OnlinePauseUI GGFJGHHHEJC;

	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private TMP_Text textLabel;

	private void FNFNLFOJHHA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void OHLNHJJLICF()
	{
		GGFJGHHHEJC = this;
	}

	private void HEMAHKJEONA()
	{
		LMJKALJOGBH();
	}

	public static void IGPKBFAJHJI()
	{
		Resume();
		GGFJGHHHEJC.panel.SetActive(false);
	}

	public static void AFANHJEGOJO(MessageCode KKMFHBMHFLC)
	{
		MOONNKCBHEP();
		GGFJGHHHEJC.panel.SetActive(true);
		switch (KKMFHBMHFLC)
		{
		case MessageCode.GuestConnecting:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("Take")))
			{
				GGFJGHHHEJC.textLabel.text = "Crop with ID ";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player/Bark/Tutorial/CantDoYet"));
			}
			break;
		case MessageCode.HostDisconnected:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("Actionbar 6")))
			{
				GGFJGHHHEJC.textLabel.text = "NewCharacters/";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_name_697"));
			}
			break;
		}
	}

	public static void EMKEOINMBBI()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1121f;
		Time.timeScale = 420f;
	}

	public static void ShowMessage(MessageCode KKMFHBMHFLC)
	{
		Pause();
		GGFJGHHHEJC.panel.SetActive(true);
		switch (KKMFHBMHFLC)
		{
		case MessageCode.GuestConnecting:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("GuestConnecting")))
			{
				GGFJGHHHEJC.textLabel.text = "Waiting for guest player to connect...";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("GuestConnecting"));
			}
			break;
		case MessageCode.HostDisconnected:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("HostDisconnected")))
			{
				GGFJGHHHEJC.textLabel.text = "The game's host has disconnected. Returning to title screen...";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("HostDisconnected"));
			}
			break;
		}
	}

	public void LMJKALJOGBH()
	{
		GGFJGHHHEJC = this;
	}

	public static void HENLOLPNGDH(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}

	public static void MALFAOGNJAG(MessageCode KKMFHBMHFLC)
	{
		PPAMGDDGNIF();
		GGFJGHHHEJC.panel.SetActive(false);
		if (KKMFHBMHFLC != 0)
		{
			if (KKMFHBMHFLC == MessageCode.GuestConnecting)
			{
				if (string.IsNullOrEmpty(LocalisationSystem.Get("LE_10")))
				{
					GGFJGHHHEJC.textLabel.text = "New Player added as player ";
				}
				else
				{
					GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("RecipeX"));
				}
			}
		}
		else if (string.IsNullOrEmpty(LocalisationSystem.Get("itemSage")))
		{
			GGFJGHHHEJC.textLabel.text = "Show";
		}
		else
		{
			GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player/Bark/Tutorial/T100"));
		}
	}

	public static void KFCFGCPINGO(MessageCode KKMFHBMHFLC)
	{
		PPAMGDDGNIF();
		GGFJGHHHEJC.panel.SetActive(false);
		switch (KKMFHBMHFLC)
		{
		case MessageCode.GuestConnecting:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("Start")))
			{
				GGFJGHHHEJC.textLabel.text = "Jump";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Item "));
			}
			break;
		case MessageCode.HostDisconnected:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("itemCoal")))
			{
				GGFJGHHHEJC.textLabel.text = "sForSeconds";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("\t\t</align>"));
			}
			break;
		}
	}

	public static void IOLHKMHKHLN(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	private void PCKOHAIPHFI()
	{
		APAGOJIKPNA();
	}

	public static void MOONNKCBHEP()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1478f;
		Time.timeScale = 1428f;
	}

	private void KOBNHPKEJJD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void DAJEFFAEMBJ(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}

	private void KPILPDFCHBG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void OKLFGGAAJML(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}

	public static void MMDPLHJDMKM(MessageCode KKMFHBMHFLC)
	{
		ICAFMHCOGNM();
		GGFJGHHHEJC.panel.SetActive(true);
		switch (KKMFHBMHFLC)
		{
		case MessageCode.GuestConnecting:
			if (string.IsNullOrEmpty(LocalisationSystem.Get(" / ")))
			{
				GGFJGHHHEJC.textLabel.text = "UseHold";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_description_664"));
			}
			break;
		case MessageCode.HostDisconnected:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("INeedAFragment")))
			{
				GGFJGHHHEJC.textLabel.text = "Player/Bark/Tutorial/SleepBlock";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("</color>"));
			}
			break;
		}
	}

	private void PHJKJHKAABL()
	{
		APAGOJIKPNA();
	}

	public static void BHKLMDJANKN()
	{
		BMOLHHLCEJG();
		GGFJGHHHEJC.panel.SetActive(true);
	}

	public static void MNGIOJLCAKC(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}

	public static void IJAEFEDKJKJ()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1177f;
		Time.timeScale = 392f;
	}

	private void NCDBCDJKPLA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void BAMJHBHGCDM()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1172f;
		Time.timeScale = 1569f;
	}

	public static void FOHDCJACOEB(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	public static void NKOKJIJIDGA()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1226f;
		Time.timeScale = 1052f;
	}

	public static void CKCIKHOLOCJ(MessageCode KKMFHBMHFLC)
	{
		IJAEFEDKJKJ();
		GGFJGHHHEJC.panel.SetActive(true);
		if (KKMFHBMHFLC != 0)
		{
			if (KKMFHBMHFLC == MessageCode.GuestConnecting)
			{
				if (string.IsNullOrEmpty(LocalisationSystem.Get("OLD")))
				{
					GGFJGHHHEJC.textLabel.text = "FinalTestEvent SetKyroh";
				}
				else
				{
					GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(""));
				}
			}
		}
		else if (string.IsNullOrEmpty(LocalisationSystem.Get("PlayerDisconnected")))
		{
			GGFJGHHHEJC.textLabel.text = "</color>";
		}
		else
		{
			GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error in CatRelationship.CheckRelationship: "));
		}
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void IHKCBOFGIEI()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1014f;
		Time.timeScale = 531f;
	}

	public static void CDDJCOHPPJJ(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}

	public static void BEBFLAMEEGB(MessageCode KKMFHBMHFLC)
	{
		PPAMGDDGNIF();
		GGFJGHHHEJC.panel.SetActive(false);
		switch (KKMFHBMHFLC)
		{
		case MessageCode.GuestConnecting:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("Player2")))
			{
				GGFJGHHHEJC.textLabel.text = "Floor_3";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("OnlinePlayer"));
			}
			break;
		case MessageCode.HostDisconnected:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("SystemInfo.graphicsMemorySize ")))
			{
				GGFJGHHHEJC.textLabel.text = "Crafting ";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveOpenChest"));
			}
			break;
		}
	}

	public static void FDNKAMPGPFO()
	{
		HBNHHJLGAPK();
		GGFJGHHHEJC.panel.SetActive(true);
	}

	public static void JNOHMEKLLJK()
	{
		NKOKJIJIDGA();
		GGFJGHHHEJC.panel.SetActive(false);
	}

	private void BPOOAHKHPCL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void POHNCNAPEJJ()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 536f;
		Time.timeScale = 1247f;
	}

	public static void HOFMAENOFOB()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 577f;
		Time.timeScale = 1878f;
	}

	private void MMNBJPDJHGK()
	{
		APAGOJIKPNA();
	}

	public static void INOEOHECJHG()
	{
		NKOKJIJIDGA();
		GGFJGHHHEJC.panel.SetActive(false);
	}

	public static void HDFDGGJNDDL(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	private void HLCAKACHOOE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void PPAMGDDGNIF()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 253f;
		Time.timeScale = 708f;
	}

	public static void OIMCKBCLACM()
	{
		LGGKNDLCJFI();
		GGFJGHHHEJC.panel.SetActive(true);
	}

	public static void KCKDAOOKMDJ()
	{
		BMOLHHLCEJG();
		GGFJGHHHEJC.panel.SetActive(true);
	}

	public static void BNNGJOCNHGO(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	public static void GIIOHJDFIPF()
	{
		HJIPCLJBKBN();
		GGFJGHHHEJC.panel.SetActive(false);
	}

	public static void Resume()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = -1f;
		Time.timeScale = 1f;
	}

	public static void GNCNGLDHBLD()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1057f;
		Time.timeScale = 966f;
	}

	public static void FCEHFBPDFLD(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	public static void SetMessage(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	private void Awake()
	{
		ResetSingleton();
	}

	public static void Pause()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 0f;
		Time.timeScale = 0f;
	}

	private void NCOGHEMBDBN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void CHDEOJALBFK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void HBNHHJLGAPK()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1348f;
		Time.timeScale = 570f;
	}

	public static void HJIPCLJBKBN()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1709f;
		Time.timeScale = 1811f;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void APAGOJIKPNA()
	{
		GGFJGHHHEJC = this;
	}

	public static void GNMGEFMHLHB(MessageCode KKMFHBMHFLC)
	{
		POHNCNAPEJJ();
		GGFJGHHHEJC.panel.SetActive(false);
		switch (KKMFHBMHFLC)
		{
		case MessageCode.GuestConnecting:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("IsKicked")))
			{
				GGFJGHHHEJC.textLabel.text = "psai: No Player Collider could be found for component {0}. Please assign the 'Player' tag to your player object, or assign the collider manually.";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Gin"));
			}
			break;
		case MessageCode.HostDisconnected:
			if (string.IsNullOrEmpty(LocalisationSystem.Get("Walk")))
			{
				GGFJGHHHEJC.textLabel.text = "Items/item_name_722";
			}
			else
			{
				GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveKeyPuzzleSolved"));
			}
			break;
		}
	}

	public static void HideMessage()
	{
		Resume();
		GGFJGHHHEJC.panel.SetActive(false);
	}

	public static void SetMessageVisible(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}

	private void BGBFJPJLPMF()
	{
		ResetSingleton();
	}

	public void ResetSingleton()
	{
		GGFJGHHHEJC = this;
	}

	public static void ICAFMHCOGNM()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1066f;
		Time.timeScale = 342f;
	}

	public static void LGGKNDLCJFI()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 1271f;
		Time.timeScale = 1663f;
	}

	private void EIMIDCDEIDD()
	{
		ResetSingleton();
	}

	private void GFLFDLIMOLI()
	{
		ResetSingleton();
	}

	public static void PCHNEHJJGON(MessageCode KKMFHBMHFLC)
	{
		Pause();
		GGFJGHHHEJC.panel.SetActive(false);
		if (KKMFHBMHFLC != 0)
		{
			if (KKMFHBMHFLC == MessageCode.GuestConnecting)
			{
				if (string.IsNullOrEmpty(LocalisationSystem.Get("Miners/Mine/Brock/Talk")))
				{
					GGFJGHHHEJC.textLabel.text = "Floor_6";
				}
				else
				{
					GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("onlineregion"));
				}
			}
		}
		else if (string.IsNullOrEmpty(LocalisationSystem.Get("")))
		{
			GGFJGHHHEJC.textLabel.text = ", ";
		}
		else
		{
			GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_description_1105"));
		}
	}

	private void NJAFKFAPDIE()
	{
		LMJKALJOGBH();
	}

	public static void GAIOFBJNBEP(MessageCode KKMFHBMHFLC)
	{
		IJAEFEDKJKJ();
		GGFJGHHHEJC.panel.SetActive(true);
		if (KKMFHBMHFLC != 0)
		{
			if (KKMFHBMHFLC == MessageCode.GuestConnecting)
			{
				if (string.IsNullOrEmpty(LocalisationSystem.Get("- ")))
				{
					GGFJGHHHEJC.textLabel.text = "Incorrect index to check: ";
				}
				else
				{
					GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("LE_21"));
				}
			}
		}
		else if (string.IsNullOrEmpty(LocalisationSystem.Get("Player/Bark/Tutorial/T101")))
		{
			GGFJGHHHEJC.textLabel.text = "Prices";
		}
		else
		{
			GGFJGHHHEJC.textLabel.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" will be destroyed in "));
		}
	}

	public static void JBLKIJIKOCG()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 196f;
		Time.timeScale = 1415f;
	}

	public static void EDCJILFOCFF()
	{
		Resume();
		GGFJGHHHEJC.panel.SetActive(true);
	}

	public static void FJOJFOBBHJB(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	private void PGABAEGKPIG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DFFDKIPCCKK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void OJAJLIAMGEJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void MAGJNFLCOLP()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 727f;
		Time.timeScale = 259f;
	}

	public static void DIJOPDIANAE(string KEJPBACDIDE)
	{
		GGFJGHHHEJC.textLabel.text = KEJPBACDIDE;
	}

	private void IGNEGEOPLOP()
	{
		ResetSingleton();
	}

	public static void PJDDPLIDNMN(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}

	public static void BMOLHHLCEJG()
	{
		PhotonNetwork.MinimalTimeScaleToDispatchInFixedUpdate = 35f;
		Time.timeScale = 1721f;
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void CGEIBGGCIJO(bool DMBFKFLDDLH)
	{
		GGFJGHHHEJC.panel.SetActive(DMBFKFLDDLH);
	}
}
