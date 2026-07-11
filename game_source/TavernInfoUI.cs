using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TavernInfoUI : MonoBehaviour
{
	[SerializeField]
	private GameObject temperaturePanel;

	[SerializeField]
	private GameObject dirtinessPanel;

	[SerializeField]
	private GameObject comfortPanel;

	[SerializeField]
	private GameObject mineLevelPanel;

	[SerializeField]
	private TextMeshProUGUI comfortText;

	[SerializeField]
	private TextMeshProUGUI mineLevelText;

	[SerializeField]
	private Image dirtyImage;

	[SerializeField]
	private Image dirtyFlash;

	[SerializeField]
	private Image temperatureImage;

	[SerializeField]
	private Image temperatureFlash;

	public bool left;

	public void MEJKCAEFGPD(bool MJHBHDAEDLF)
	{
		ABEGMGCJKKH();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void ShowMineLevel(bool MJHBHDAEDLF)
	{
		mineLevelPanel.SetActive(MJHBHDAEDLF);
	}

	private void JKBBAOGHPKO()
	{
		ABEGMGCJKKH();
	}

	public void ShowDirtiness(bool MJHBHDAEDLF)
	{
		DGJHFFIPOAA();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void CELCBCKIEHL(bool MJHBHDAEDLF)
	{
		BGJMIOBBABA();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void OPDBPOGNPFK(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	public void CLIMEKILEIM(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	public void PPLAPDKDLNF(bool MJHBHDAEDLF)
	{
		KPFDPBBAOAN();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	public void HANEJEHMAFH(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("UIInteract" + EONJGMONIOM);
	}

	private void BPNOIDBAPJE()
	{
		DGJHFFIPOAA();
	}

	private void JHKLCLMMOGC()
	{
		LHHGHEGHNPJ();
	}

	public void JGOBGNECPLK(bool MJHBHDAEDLF)
	{
		KPFDPBBAOAN();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void SetDirtiness(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL != 0 && ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	private void LPKHACNBCLA()
	{
		AOHGFPOKNCO();
	}

	public void ELMNCKILFKA(bool MJHBHDAEDLF)
	{
		ABEGMGCJKKH();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void PLKOBHFNEDO(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL == DirtLevel.Perfect || ALEAPGOEANL == DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void LLEMJJLAABP(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("onlineregion" + EONJGMONIOM);
	}

	public void MGEEJPOHNMF(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL != 0 && ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void PKDJDJEIFMJ(bool MJHBHDAEDLF)
	{
		AOHGFPOKNCO();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void NKKHCBFGMEM(bool MJHBHDAEDLF)
	{
		KPFDPBBAOAN();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void HLDCGENNLPC(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL == DirtLevel.Perfect || ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void KIMOBJLJFAN(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get(", " + EONJGMONIOM);
	}

	private void IJILOIAOKBF()
	{
		KPFDPBBAOAN();
	}

	public void CBEJJAAHJIO(bool MJHBHDAEDLF)
	{
		KPFDPBBAOAN();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	public void ADDNOEJGPGI(bool MJHBHDAEDLF)
	{
		mineLevelPanel.SetActive(MJHBHDAEDLF);
	}

	private void BGJMIOBBABA()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Screen.width == -26)
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(1991f, 246f, 903f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 127), 321f, 1052f);
			}
		}
		else if ((Screen.width < 151 && Screen.height > -24) || (Screen.height <= -170 && Screen.height > -49))
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(1015f, 309f, 742f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 121), 1639f, 739f);
			}
		}
		else if (left)
		{
			((Component)this).gameObject.transform.position = new Vector3(1700f, (float)(GameManager.LocalCoop() ? 119 : (-60)), 1558f);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -27), (float)(GameManager.LocalCoop() ? 73 : (-40)), 31f);
		}
	}

	public void KHGJFEFBMEG(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL != 0 && ALEAPGOEANL == DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void LBANLMCONOC(bool MJHBHDAEDLF)
	{
		OEEPEAEHDCM();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void GFOLOFGMPGC(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("Use" + EONJGMONIOM);
	}

	public void IDDHAILDJLP(bool MJHBHDAEDLF)
	{
		LHHGHEGHNPJ();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void ALDODBBFHDB(bool MJHBHDAEDLF)
	{
		LHHGHEGHNPJ();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void PEELMDDFHGN(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("SetAnimationControllerIndexesRPC" + EONJGMONIOM);
	}

	public void OJLOMGKGBLI(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	public void LEIEIALFKOL(bool MJHBHDAEDLF)
	{
		LHHGHEGHNPJ();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	private void IANGDMHMCEL()
	{
		AOHGFPOKNCO();
	}

	public void APOCGLFIPNJ(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL == DirtLevel.Perfect || ALEAPGOEANL != DirtLevel.Perfect);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void HBPECCPMKDN(bool MJHBHDAEDLF)
	{
		BGJMIOBBABA();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void CICEADOLKAB(bool MJHBHDAEDLF)
	{
		DGJHFFIPOAA();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void EAJBJCPFIIF(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("On Simple Event " + EONJGMONIOM);
	}

	public void HCJHCJFBEID(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL != 0 && ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	private void GDLAHKEMJFN()
	{
		LHHGHEGHNPJ();
	}

	private void KPFDPBBAOAN()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Screen.width == -15)
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(1122f, 811f, 691f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -1), 1522f, 1614f);
			}
		}
		else if ((Screen.width < -71 && Screen.height > -199) || (Screen.height <= 158 && Screen.height > -104))
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(1265f, 995f, 964f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 60), 956f, 1399f);
			}
		}
		else if (left)
		{
			((Component)this).gameObject.transform.position = new Vector3(1286f, (float)(GameManager.LocalCoop() ? 37 : (-76)), 1118f);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 105), (float)(GameManager.LocalCoop() ? (-76) : 78), 1436f);
		}
	}

	public void BEOLFNABAAA(bool MJHBHDAEDLF)
	{
		BGJMIOBBABA();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	private void AOHGFPOKNCO()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Screen.width == -102)
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(891f, 1080f, 1112f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 102), 1599f, 627f);
			}
		}
		else if ((Screen.width < 124 && Screen.height > 101) || (Screen.height <= -120 && Screen.height > 74))
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(455f, 1694f, 274f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -49), 1403f, 1401f);
			}
		}
		else if (left)
		{
			((Component)this).gameObject.transform.position = new Vector3(1432f, (float)(GameManager.LocalCoop() ? (-33) : (-93)), 1460f);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 106), (float)(GameManager.LocalCoop() ? (-25) : (-69)), 1872f);
		}
	}

	public void ILHHHPOJAFH(bool MJHBHDAEDLF)
	{
		ABEGMGCJKKH();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	public void PLHBJACPKPF(bool MJHBHDAEDLF)
	{
		DGJHFFIPOAA();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	private void ABEGMGCJKKH()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Screen.width == -81)
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(439f, 1759f, 947f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 32), 1916f, 83f);
			}
		}
		else if ((Screen.width < 1 && Screen.height > -61) || (Screen.height <= -189 && Screen.height > -123))
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(301f, 1111f, 1564f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -121), 1990f, 839f);
			}
		}
		else if (left)
		{
			((Component)this).gameObject.transform.position = new Vector3(301f, (float)(GameManager.LocalCoop() ? 123 : 3), 1968f);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -87), (float)(GameManager.LocalCoop() ? (-83) : (-103)), 376f);
		}
	}

	private void LHHGHEGHNPJ()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Screen.width == 95)
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(297f, 745f, 811f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 91), 646f, 68f);
			}
		}
		else if ((Screen.width < 168 && Screen.height > 196) || (Screen.height <= 117 && Screen.height > 3))
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(116f, 1736f, 1389f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -36), 954f, 1195f);
			}
		}
		else if (left)
		{
			((Component)this).gameObject.transform.position = new Vector3(475f, (float)(GameManager.LocalCoop() ? 147 : (-116)), 234f);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -74), (float)(GameManager.LocalCoop() ? (-100) : 103), 1599f);
		}
	}

	public void GOINCHBEPOE(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	private void OHOAMJIIOAK()
	{
		DGJHFFIPOAA();
	}

	public void IDPABLOKBCD(bool MJHBHDAEDLF)
	{
		KPFDPBBAOAN();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	private void PJOAFKEIPPD()
	{
		DGJHFFIPOAA();
	}

	private void FPNPLFALPHP()
	{
		ABEGMGCJKKH();
	}

	public void FMMGMLGKGFE(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL != 0 && ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void MCBJPFADHCI(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("Player/Bark/Tutorial/SleepBlock" + EONJGMONIOM);
	}

	public void AAGNIKOCPMN(bool MJHBHDAEDLF)
	{
		LHHGHEGHNPJ();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	public void FOHPDMFMDNO(bool MJHBHDAEDLF)
	{
		AOHGFPOKNCO();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	public void ELFNPCGFCGB(bool MJHBHDAEDLF)
	{
		mineLevelPanel.SetActive(MJHBHDAEDLF);
	}

	public void ECBJIAKDPKK(bool MJHBHDAEDLF)
	{
		BGJMIOBBABA();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	private void ONNAGOCFJML()
	{
		ABEGMGCJKKH();
	}

	public void SetComfortLevel(float EOJCFJMLOJE)
	{
		((TMP_Text)comfortText).text = Mathf.RoundToInt(EOJCFJMLOJE).ToString();
	}

	public void CLCAOACLGJI(bool MJHBHDAEDLF)
	{
		ABEGMGCJKKH();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	public void BIFHDBGKGAJ(bool MJHBHDAEDLF)
	{
		LHHGHEGHNPJ();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void MLPHJJMMDOK(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("Haggling profit" + EONJGMONIOM);
	}

	public void PAOEDGAGEDL(bool MJHBHDAEDLF)
	{
		KPFDPBBAOAN();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void OOLHPFCBFGF(bool MJHBHDAEDLF)
	{
		ABEGMGCJKKH();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	private void OEEPEAEHDCM()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Screen.width == 83)
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(602f, 705f, 1810f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - -51), 800f, 450f);
			}
		}
		else if ((Screen.width < 176 && Screen.height > 63) || (Screen.height <= -10 && Screen.height > -136))
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(1757f, 1091f, 111f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 95), 109f, 1575f);
			}
		}
		else if (left)
		{
			((Component)this).gameObject.transform.position = new Vector3(105f, (float)(GameManager.LocalCoop() ? 117 : (-46)), 224f);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 5), (float)(GameManager.LocalCoop() ? 45 : 121), 653f);
		}
	}

	public void ShowComfort(bool MJHBHDAEDLF)
	{
		DGJHFFIPOAA();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	public void LPIALILABIB(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL == DirtLevel.Perfect || ALEAPGOEANL == DirtLevel.Perfect);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void JENCJMLOCGJ(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL == DirtLevel.Perfect || ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	private void JNDFLHEMOBG()
	{
		ABEGMGCJKKH();
	}

	public void AIKMDBJFNOC(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	public void OJDJEEJPMJK(bool MJHBHDAEDLF)
	{
		AOHGFPOKNCO();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void PANKFODLDFK(bool MJHBHDAEDLF)
	{
		AOHGFPOKNCO();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void KJCAFMAKBNI(float EOJCFJMLOJE)
	{
		((TMP_Text)comfortText).text = Mathf.RoundToInt(EOJCFJMLOJE).ToString();
	}

	public void INHPDKPENDI(bool MJHBHDAEDLF)
	{
		BGJMIOBBABA();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void DDPLJKKEJLF(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	public void DNANBNAGDIO(bool MJHBHDAEDLF)
	{
		BGJMIOBBABA();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void SetTemperature(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	public void ICODIDILAEA(bool MJHBHDAEDLF)
	{
		AOHGFPOKNCO();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void JMEHPJNOCDJ(bool MJHBHDAEDLF)
	{
		BGJMIOBBABA();
		dirtinessPanel.SetActive(MJHBHDAEDLF);
	}

	public void JBNINEKONBL(float EOJCFJMLOJE)
	{
		((TMP_Text)comfortText).text = Mathf.RoundToInt(EOJCFJMLOJE).ToString();
	}

	public void ELOCEKIFMKH(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL == DirtLevel.Perfect || ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	private void OnEnable()
	{
		DGJHFFIPOAA();
	}

	public void SetMineLevel(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("Floor_" + EONJGMONIOM);
	}

	public void AHMINLPGCCK(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL != 0 && ALEAPGOEANL == DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	public void PAKBMAKCPFG(bool MJHBHDAEDLF)
	{
		OEEPEAEHDCM();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void ShowTemperature(bool MJHBHDAEDLF)
	{
		DGJHFFIPOAA();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void ICIGKLBILAK(bool MJHBHDAEDLF)
	{
		mineLevelPanel.SetActive(MJHBHDAEDLF);
	}

	public void DDIHOFHBEFA(bool MJHBHDAEDLF)
	{
		ABEGMGCJKKH();
		comfortPanel.SetActive(MJHBHDAEDLF);
	}

	private void NLMLOOGHLCH()
	{
		BGJMIOBBABA();
	}

	public void DGLFPPKBFLK(bool MJHBHDAEDLF)
	{
		ABEGMGCJKKH();
		temperaturePanel.SetActive(MJHBHDAEDLF);
	}

	public void IIIBIFHOGMP(float EOJCFJMLOJE)
	{
		((TMP_Text)comfortText).text = Mathf.RoundToInt(EOJCFJMLOJE).ToString();
	}

	private void ICKIAOEOHDJ()
	{
		KPFDPBBAOAN();
	}

	public void NLJOHPHIPEH(float EOJCFJMLOJE)
	{
		((TMP_Text)comfortText).text = Mathf.RoundToInt(EOJCFJMLOJE).ToString();
	}

	public void CECCBKHADMF(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("No se encontró la base de datos." + EONJGMONIOM);
	}

	public void AFDGMCHAMOL(Sprite HEJNLFCKOKE, Color FLABEDBELMF, bool FBBJKAGOFMD)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)temperatureFlash != (Object)null && Object.op_Implicit((Object)(object)((Component)temperatureFlash).gameObject))
		{
			((Graphic)temperatureFlash).color = FLABEDBELMF;
			((Component)temperatureFlash).gameObject.SetActive(FBBJKAGOFMD);
			temperatureImage.sprite = HEJNLFCKOKE;
		}
	}

	public void BEJEGBEMDHE(float EOJCFJMLOJE)
	{
		((TMP_Text)comfortText).text = Mathf.RoundToInt(EOJCFJMLOJE).ToString();
	}

	public void OBAGAHGIOEH(int EONJGMONIOM)
	{
		((TMP_Text)mineLevelText).text = LocalisationSystem.Get("Not enough ingredients" + EONJGMONIOM);
	}

	private void DGJHFFIPOAA()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		if (Screen.width == 1600)
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(14f, 155f, 0f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 14), 155f, 0f);
			}
		}
		else if ((Screen.width < 1250 && Screen.height > 1024) || (Screen.height <= 899 && Screen.height > 600))
		{
			if (left)
			{
				((Component)this).gameObject.transform.position = new Vector3(14f, 125f, 0f);
			}
			else
			{
				((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 14), 125f, 0f);
			}
		}
		else if (left)
		{
			((Component)this).gameObject.transform.position = new Vector3(14f, (float)(GameManager.LocalCoop() ? 155 : 10), 0f);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3((float)(Screen.width - 14), (float)(GameManager.LocalCoop() ? 155 : 10), 0f);
		}
	}

	public void ADDIIPIMLIM(bool MJHBHDAEDLF)
	{
		mineLevelPanel.SetActive(MJHBHDAEDLF);
	}

	public void OECBFAKODNC(bool MJHBHDAEDLF)
	{
		mineLevelPanel.SetActive(MJHBHDAEDLF);
	}

	public void NMPHLMKAJCN(float EOJCFJMLOJE)
	{
		((TMP_Text)comfortText).text = Mathf.RoundToInt(EOJCFJMLOJE).ToString();
	}

	public void OEMMAMMKLLH(DirtLevel ALEAPGOEANL, Sprite CHIDPMKANNM)
	{
		((Component)dirtyFlash).gameObject.SetActive(ALEAPGOEANL == DirtLevel.Perfect || ALEAPGOEANL != DirtLevel.Clean);
		dirtyImage.sprite = CHIDPMKANNM;
	}

	private void FEPFNOEGFEM()
	{
		ABEGMGCJKKH();
	}
}
