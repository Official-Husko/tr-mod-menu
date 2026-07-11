using System;
using UnityEngine;

public class DecorationModeUI : MonoBehaviour
{
	private static DecorationModeUI GGFJGHHHEJC;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private RectTransform content1;

	[SerializeField]
	private RectTransform content2;

	private void CEPCBLFKEMK()
	{
		DecorationMode player = DecorationMode.GetPlayer(0);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(NNAMJKHJJFL));
		DecorationMode decorationMode = DecorationMode.HBDCJFLINDA(0);
		decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeExit, new Action<int>(KILOFKAGFBC));
	}

	private void JDAMCMODANB()
	{
		GGFJGHHHEJC = this;
	}

	private void BMCAGHAMOIC()
	{
		DecorationMode.OCJGHINCLJM(8).DMBFKFLDDLH = true;
		if (DecorationMode.OCJGHINCLJM(0).GABNNLJOMHI())
		{
			((Component)content).gameObject.SetActive(false);
		}
		((Component)content1).gameObject.SetActive(true);
		((Component)content2).gameObject.SetActive(false);
	}

	private void EEBLIBOJKEE()
	{
		DecorationMode.KKJABELKCNM(0).DDHHFMBJNHB(AODONKKHPBP: false);
		if (DecorationMode.OCJGHINCLJM(1).DBAEGBDEPFK())
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(false);
		((Component)content2).gameObject.SetActive(true);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	private void CHIJGHPHCNA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(COIIGAAGODB));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(OBDMANCPKPI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(GCGIAGGHHHP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(KEKOBCEAKMN));
	}

	private void Start()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void OMOPACKIMEF(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: true, null, null, 1594f);
			}
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.BNBMNOMFFBE().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: true, null, null, 1014f);
			}
			((Component)content).gameObject.SetActive(true);
			((Component)content1).gameObject.SetActive(true);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.GGFJGHHHEJC.MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: false, null, null, 732f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void PNJJEDEFAGO()
	{
		GGFJGHHHEJC = this;
	}

	private void LBKNGDMDIMB()
	{
		DecorationMode decorationMode = DecorationMode.FIHGMLABOBB(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(DHDIPFANLPN));
		DecorationMode decorationMode2 = DecorationMode.EKLMFMKPEBB(1);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(JDGJPOGGDNF));
	}

	private void AHFGOOHOLEL()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(COIIGAAGODB));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(FJAIAGPEEKM));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EMNLJAPHCKN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(IIIJJDIHELL));
	}

	private void MBBIGANCPNE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void KEKOBCEAKMN()
	{
		DecorationMode.FIHGMLABOBB(1).LHCCDCNLMKH(AODONKKHPBP: false);
		if (DecorationMode.ABMIMLLDAAH(0).IBEFDKHFBFM())
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(false);
		((Component)content2).gameObject.SetActive(false);
	}

	private void DBGBFJJAKHG()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode player = DecorationMode.GetPlayer(7);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(DHDIPFANLPN));
		DecorationMode decorationMode = DecorationMode.KAIIEDCCLHB(3);
		decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeExit, new Action<int>(JDGJPOGGDNF));
		((Component)content).gameObject.SetActive(false);
		if (DecorationMode.NPANPNIDKDG(0).KNFEPKBIHND())
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 3 - 8), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 3 - 1), (float)Screen.height);
	}

	private void DFNAGADHAJJ(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowClose), HOMFPAFAOGD: true, null, null, 1592f);
			}
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowClose), HOMFPAFAOGD: true, null, null, 753f);
			}
			((Component)content).gameObject.SetActive(true);
			((Component)content1).gameObject.SetActive(true);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.MAIDHAPANEB().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: false, null, null, 908f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void BLAJFMAAMDO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HPIMHEMJMAA()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.AJIGOHGPFPP();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(OCBFOEMAFPF));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(FHPPFBPGLCJ));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(KGBKCMCHEFP));
	}

	private void FNJNDDPBPOL(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.MAIDHAPANEB().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1558f);
	}

	private void ELAJKAGJOBP(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.OKAPNFPFPFP().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: true, null, null, 712f);
	}

	private void CHDEOJALBFK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HDDCIGADCCN(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 3 - 6), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 5 - 6), (float)DEIHFLFENJI);
	}

	private void GOJKOBEEMNA()
	{
		GGFJGHHHEJC = this;
	}

	private void JHIEAAJJDFF(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.MAIDHAPANEB().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 161f);
			}
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.GGFJGHHHEJC.NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowClose), HOMFPAFAOGD: false, null, null, 759f);
			}
			((Component)content).gameObject.SetActive(false);
			((Component)content1).gameObject.SetActive(true);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.BNBMNOMFFBE().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: true, null, null, 350f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void FOHGHCPODBJ()
	{
		GraphicsMenuUI instance = GraphicsMenuUI.GGFJGHHHEJC;
		instance.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(instance.OnResolutionChange, new Action<int, int, float>(NODAOFAFDPK));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(FJAIAGPEEKM));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(GCGIAGGHHHP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(IKJMMFBFMNG));
	}

	private void DFFDKIPCCKK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void BGDGLGBLNDI()
	{
		DecorationMode player = DecorationMode.GetPlayer(1);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(HPLFLOKOGGB));
		DecorationMode player2 = DecorationMode.GetPlayer(1);
		player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(KILOFKAGFBC));
	}

	private void FHPPFBPGLCJ()
	{
		DecorationMode decorationMode = DecorationMode.EKLMFMKPEBB(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(ELAJKAGJOBP));
		DecorationMode decorationMode2 = DecorationMode.NPANPNIDKDG(1);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(OGMNAPOCPGD));
	}

	private void FHOCCEBKHJI()
	{
		GGFJGHHHEJC = this;
	}

	private void DPDIIFJCNCJ(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (GameManager.EAOOLEFMIKE())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.ABDJJBFNLBJ().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1974f);
	}

	private void DHDIPFANLPN(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (GameManager.HDBECFMPJHL())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.MAIDHAPANEB().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1946f);
	}

	private void FHBIIJOHKJJ()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode decorationMode = DecorationMode.KAIIEDCCLHB(0);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(FNJNDDPBPOL));
		DecorationMode player = DecorationMode.GetPlayer(4);
		player.OnDecorationModeExit = (Action<int>)Delegate.Combine(player.OnDecorationModeExit, new Action<int>(OGMNAPOCPGD));
		((Component)content).gameObject.SetActive(false);
		if (DecorationMode.BGINAIDHDOM(1).DMBFKFLDDLH)
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 8 - 4), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 0 - 1), (float)Screen.height);
	}

	private void FBICFKDJANI(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (GameManager.EAOOLEFMIKE())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.ABDJJBFNLBJ().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1856f);
	}

	private void COIIGAAGODB(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 1 - 1), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 2), (float)DEIHFLFENJI);
	}

	private void JHCOHMEECDB(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (GameManager.HDBECFMPJHL())
			{
				((Component)content).gameObject.SetActive(false);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.OKAPNFPFPFP().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1529f);
	}

	private void AGMKPJONHJL()
	{
		DecorationMode decorationMode = DecorationMode.KKJABELKCNM(0);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(HPLFLOKOGGB));
		DecorationMode decorationMode2 = DecorationMode.HBDCJFLINDA(0);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(IEIIHONBOGI));
	}

	private void IEIIHONBOGI(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowClose), HOMFPAFAOGD: false, null, null, 618f);
			}
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: false, null, null, 1834f);
			}
			((Component)content).gameObject.SetActive(false);
			((Component)content1).gameObject.SetActive(true);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.MAIDHAPANEB().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: false, null, null, 1618f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void BGPCMOJIIFF(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.OKAPNFPFPFP().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: true, null, null, 390f);
			}
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.DIHCEGINELM().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: true, null, null, 1095f);
			}
			((Component)content).gameObject.SetActive(false);
			((Component)content1).gameObject.SetActive(false);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowClose), HOMFPAFAOGD: true, null, null, 261f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void JDGJPOGGDNF(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.OKAPNFPFPFP().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: false, null, null, 304f);
			}
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: false, null, null, 746f);
			}
			((Component)content).gameObject.SetActive(false);
			((Component)content1).gameObject.SetActive(true);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.DIHCEGINELM().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowClose), HOMFPAFAOGD: true, null, null, 851f);
			}
			((Component)content2).gameObject.SetActive(true);
		}
	}

	private void NNAMJKHJJFL(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (GameManager.NBFLEJHLGNB())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.GGFJGHHHEJC.CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1319f);
	}

	private void LHIFBLELKNA(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 6), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 6), (float)DEIHFLFENJI);
	}

	private void MIEDKJPOKJJ(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 4 - 0), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 7 - 2), (float)DEIHFLFENJI);
	}

	private void KHLHCFJAOCB(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 6 - 7), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 2 - 5), (float)DEIHFLFENJI);
	}

	private void BELOIFKPNMM()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(FJAIAGPEEKM));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(BMCAGHAMOIC));
	}

	private void PGABAEGKPIG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void CEOEHODJAJK()
	{
		GGFJGHHHEJC = this;
	}

	private void CDGBFBKMIGM()
	{
		DecorationMode player = DecorationMode.GetPlayer(1);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(NNAMJKHJJFL));
		DecorationMode player2 = DecorationMode.GetPlayer(0);
		player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(IEIIHONBOGI));
	}

	private void DKDLOBOLNFH()
	{
		GGFJGHHHEJC = this;
	}

	private void GECHJIGBPEN()
	{
		GGFJGHHHEJC = this;
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HINGECEDJAP()
	{
		GGFJGHHHEJC = this;
	}

	private void FJAIAGPEEKM()
	{
		DecorationMode decorationMode = DecorationMode.JDADPDBHJFO(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(FNJNDDPBPOL));
		DecorationMode decorationMode2 = DecorationMode.EKLMFMKPEBB(1);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(OGMNAPOCPGD));
	}

	private void KOKAGDJOFCH()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode decorationMode = DecorationMode.IGMCBPOPNCA(3);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(HPLFLOKOGGB));
		DecorationMode decorationMode2 = DecorationMode.IGMCBPOPNCA(2);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(OGMNAPOCPGD));
		((Component)content).gameObject.SetActive(false);
		if (DecorationMode.FIHGMLABOBB(0).IDPGEBNGDJD())
		{
			((Component)content1).gameObject.SetActive(false);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 8 - 7), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 3 - 1), (float)Screen.height);
	}

	private void KILOFKAGFBC(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
			}
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
			}
			((Component)content).gameObject.SetActive(false);
			((Component)content1).gameObject.SetActive(false);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void NPMLFHDHJBE()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.FMIDAFEGDCD();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(LHIFBLELKNA));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(EHEAPHCIJJE));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(KEKOBCEAKMN));
	}

	private void EIHMDMMOPCM()
	{
		GGFJGHHHEJC = this;
	}

	private void GONDLJKGLGO()
	{
		GGFJGHHHEJC = this;
	}

	private void IHICKHAABJH()
	{
		GGFJGHHHEJC = this;
	}

	private void ANMKBHKHABF()
	{
		DecorationMode.KAIIEDCCLHB(4).DMBFKFLDDLH = true;
		if (DecorationMode.BGINAIDHDOM(0).IBEFDKHFBFM())
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(true);
		((Component)content2).gameObject.SetActive(false);
	}

	private void CDPIKGAMPJM()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode decorationMode = DecorationMode.IGMCBPOPNCA(2);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(NNAMJKHJJFL));
		DecorationMode decorationMode2 = DecorationMode.BGINAIDHDOM(6);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(OMOPACKIMEF));
		((Component)content).gameObject.SetActive(true);
		if (DecorationMode.HBDCJFLINDA(1).DBAEGBDEPFK())
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 7 - 3), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 6 - 7), (float)Screen.height);
	}

	private void HADCIGKNFKK()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode player = DecorationMode.GetPlayer(2);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(HPLFLOKOGGB));
		DecorationMode player2 = DecorationMode.GetPlayer(2);
		player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(KILOFKAGFBC));
		((Component)content).gameObject.SetActive(false);
		if (DecorationMode.GetPlayer(1).DMBFKFLDDLH)
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 2 - 6), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 2 - 6), (float)Screen.height);
	}

	private void EBNENBFLEKB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(COIIGAAGODB));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(FJAIAGPEEKM));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(GCGIAGGHHHP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(BMCAGHAMOIC));
	}

	private void ECKJHEEBKOK(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 1 - 4), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 0 - 8), (float)DEIHFLFENJI);
	}

	private void OGMNAPOCPGD(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.BNBMNOMFFBE().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowClose), HOMFPAFAOGD: false, null, null, 1518f);
			}
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.MAIDHAPANEB().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowClose), HOMFPAFAOGD: true, null, null, 1872f);
			}
			((Component)content).gameObject.SetActive(true);
			((Component)content1).gameObject.SetActive(false);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.OKAPNFPFPFP().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: true, null, null, 363f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void MNFJAANPELP(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (GameManager.EAOOLEFMIKE())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(false);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(false);
		}
		Sound.ABDJJBFNLBJ().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1036f);
	}

	private void OBDMANCPKPI()
	{
		DecorationMode decorationMode = DecorationMode.KAIIEDCCLHB(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(DPDIIFJCNCJ));
		DecorationMode decorationMode2 = DecorationMode.BGINAIDHDOM(1);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(JHIEAAJJDFF));
	}

	private void KKGJGMCOHJK()
	{
		DecorationMode decorationMode = DecorationMode.BGINAIDHDOM(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(FBICFKDJANI));
		DecorationMode decorationMode2 = DecorationMode.IGMCBPOPNCA(0);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(IEIIHONBOGI));
	}

	private void IIIJJDIHELL()
	{
		DecorationMode.NPANPNIDKDG(2).LAJPGLFEAIC(AODONKKHPBP: false);
		if (DecorationMode.NPANPNIDKDG(0).DFNMDDHOIJI())
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(true);
		((Component)content2).gameObject.SetActive(true);
	}

	private void NODAOFAFDPK(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 7 - 6), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 5 - 5), (float)DEIHFLFENJI);
	}

	private void BDJKNKIOPIJ()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HDDCIGADCCN));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(AGMKPJONHJL));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CFMNPAOICDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(ANMKBHKHABF));
	}

	private void FJBPFOIALMK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void ICFHPJHBPDN()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.HEKFJEKFMNO();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(HDDCIGADCCN));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(CDGBFBKMIGM));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CDPIKGAMPJM));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(IJBIOMAHMBP));
	}

	private void IJBIOMAHMBP()
	{
		DecorationMode.IGMCBPOPNCA(2).LAJPGLFEAIC(AODONKKHPBP: false);
		if (DecorationMode.GetPlayer(1).GABNNLJOMHI())
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(true);
		((Component)content2).gameObject.SetActive(false);
	}

	private void IKJMMFBFMNG()
	{
		DecorationMode.FIHGMLABOBB(7).GAFDHNANIJF(AODONKKHPBP: false);
		if (DecorationMode.NPANPNIDKDG(0).IBEFDKHFBFM())
		{
			((Component)content).gameObject.SetActive(false);
		}
		((Component)content1).gameObject.SetActive(true);
		((Component)content2).gameObject.SetActive(false);
	}

	private void KGBKCMCHEFP()
	{
		DecorationMode.NPANPNIDKDG(5).LAJPGLFEAIC(AODONKKHPBP: false);
		if (DecorationMode.KKJABELKCNM(1).IBEFDKHFBFM())
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(true);
		((Component)content2).gameObject.SetActive(false);
	}

	private void EMNLJAPHCKN()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode decorationMode = DecorationMode.HBDCJFLINDA(0);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(DPDIIFJCNCJ));
		DecorationMode decorationMode2 = DecorationMode.IGMCBPOPNCA(5);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(JDGJPOGGDNF));
		((Component)content).gameObject.SetActive(false);
		if (DecorationMode.KAIIEDCCLHB(1).MDOKKKHKKKE())
		{
			((Component)content1).gameObject.SetActive(false);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 4 - 0), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 1 - 6), (float)Screen.height);
	}

	private void AGMLGNDDINL()
	{
		DecorationMode.GetPlayer(2).DMBFKFLDDLH = false;
		if (DecorationMode.GetPlayer(1).DMBFKFLDDLH)
		{
			((Component)content).gameObject.SetActive(true);
		}
		((Component)content1).gameObject.SetActive(false);
		((Component)content2).gameObject.SetActive(false);
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JECHMEFJABD()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.EFPJLFMBPLL();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(ECKJHEEBKOK));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(AGMKPJONHJL));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EMNLJAPHCKN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(KGBKCMCHEFP));
	}

	private void HJONOLGKFED(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			if (((Component)content).gameObject.activeInHierarchy)
			{
				Sound.BNBMNOMFFBE().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: true, null, null, 992f);
			}
			((Component)content).gameObject.SetActive(false);
		}
		else if (JIIGOACEIKL == 0)
		{
			if (((Component)content).gameObject.activeInHierarchy || ((Component)content1).gameObject.activeInHierarchy)
			{
				Sound.ABDJJBFNLBJ().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: true, null, null, 518f);
			}
			((Component)content).gameObject.SetActive(true);
			((Component)content1).gameObject.SetActive(true);
		}
		else
		{
			if (((Component)content2).gameObject.activeInHierarchy)
			{
				Sound.DIHCEGINELM().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowClose), HOMFPAFAOGD: false, null, null, 471f);
			}
			((Component)content2).gameObject.SetActive(false);
		}
	}

	private void GCGIAGGHHHP()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode decorationMode = DecorationMode.BGINAIDHDOM(3);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(MNFJAANPELP));
		DecorationMode decorationMode2 = DecorationMode.IGMCBPOPNCA(4);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(KILOFKAGFBC));
		((Component)content).gameObject.SetActive(true);
		if (DecorationMode.KAIIEDCCLHB(1).IDPGEBNGDJD())
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 0 - 5), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 8 - 0), (float)Screen.height);
	}

	private void BFJOEMCBJJO()
	{
		GGFJGHHHEJC = this;
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void HPLFLOKOGGB(int JIIGOACEIKL)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			((Component)content).gameObject.SetActive(true);
		}
		else if (JIIGOACEIKL == 1)
		{
			if (GameManager.SinglePlayer())
			{
				((Component)content).gameObject.SetActive(true);
			}
			else
			{
				((Component)content1).gameObject.SetActive(true);
			}
		}
		else
		{
			((Component)content2).gameObject.SetActive(true);
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
	}

	private void PCEFNHADDIG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void KACEOJDPLKB()
	{
		GraphicsMenuUI graphicsMenuUI = GraphicsMenuUI.JFNOOMJMHCB();
		graphicsMenuUI.OnResolutionChange = (Action<int, int, float>)Delegate.Combine(graphicsMenuUI.OnResolutionChange, new Action<int, int, float>(ECKJHEEBKOK));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(OBDMANCPKPI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(CFMNPAOICDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(IJBIOMAHMBP));
	}

	private void EHEAPHCIJJE()
	{
		DecorationMode decorationMode = DecorationMode.IGMCBPOPNCA(1);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(HPLFLOKOGGB));
		DecorationMode decorationMode2 = DecorationMode.FIHGMLABOBB(0);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(IEIIHONBOGI));
	}

	private void MFJIHCKEIIF()
	{
		GGFJGHHHEJC = this;
	}

	private void CFMNPAOICDB()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode player = DecorationMode.GetPlayer(1);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(FNJNDDPBPOL));
		DecorationMode decorationMode = DecorationMode.JDADPDBHJFO(0);
		decorationMode.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeExit, new Action<int>(JDGJPOGGDNF));
		((Component)content).gameObject.SetActive(false);
		if (DecorationMode.BGINAIDHDOM(0).DFNMDDHOIJI())
		{
			((Component)content1).gameObject.SetActive(true);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 1 - 1), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 8 - 1), (float)Screen.height);
	}

	private void FCICNFHLNLP()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		DecorationMode decorationMode = DecorationMode.JDADPDBHJFO(3);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(JHCOHMEECDB));
		DecorationMode decorationMode2 = DecorationMode.JDADPDBHJFO(8);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(KILOFKAGFBC));
		((Component)content).gameObject.SetActive(true);
		if (DecorationMode.JDADPDBHJFO(0).GABNNLJOMHI())
		{
			((Component)content1).gameObject.SetActive(false);
		}
		content1.sizeDelta = new Vector2((float)(Screen.width / 6 - 5), (float)Screen.height);
		content2.sizeDelta = new Vector2((float)(Screen.width / 8 - 1), (float)Screen.height);
	}

	private void OCBFOEMAFPF(int IFODFMEEMDM, int DEIHFLFENJI, float NMIBPBPEJIB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		content1.sizeDelta = new Vector2((float)(IFODFMEEMDM / 8 - 8), (float)DEIHFLFENJI);
		content2.sizeDelta = new Vector2((float)(IFODFMEEMDM / 3 - 2), (float)DEIHFLFENJI);
	}
}
