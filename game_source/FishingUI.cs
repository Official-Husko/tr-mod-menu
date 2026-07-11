using System.Collections;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class FishingUI : UIWindow
{
	public static FishingUI[] instances = new FishingUI[3];

	[SerializeField]
	private FishingManagerSettings settings;

	private FishingManagerSettings.DifficultySettings MLHCLDNJEAG;

	[SerializeField]
	private Transform buttonSignalPosition;

	[SerializeField]
	private RectTransform fishIcon;

	[SerializeField]
	private RectTransform box;

	[SerializeField]
	private RectTransform fishShakeSprite;

	[SerializeField]
	private RectTransform specialItemSprite;

	private Transform IPAGCNOAEHL;

	private Transform BEFEHJPOMHA;

	[SerializeField]
	private Slider progress;

	[SerializeField]
	private SliderBarAnimation greenBarAnimation;

	[SerializeField]
	private SliderBarAnimation redBarAnimation;

	[SerializeField]
	private Image boxGlow;

	[SerializeField]
	private Image boxImage;

	private float KBIGNAGEAFM = 130f;

	private float FEBHBADOJGF = 128f;

	public Fish fish;

	private float NHNNHMDIBGK = 11f;

	private float LCPMKENLFJE;

	private float FFNHJPMACGD;

	private float OIMHAAPEBIL;

	private float DNNFOPAGBPD;

	private bool PAOPFIIBHME;

	private float PCHLDBCBHPM;

	private float KGFOBNEKKKM;

	private float HNGHHLMFHIN;

	private float MMJGDDIJPGL;

	private Vector2 MAFLNEMCHJL;

	private float CDNOEKOOMKF;

	private float DBEFBFPAOAA;

	private float DCGBADKLANM;

	private bool FLMLLMHPJJA;

	private bool OOGIFKPEKMA = true;

	private float KGJLMIDPHPA;

	private float KCACMNACPBN;

	private float LNBOOGBBODA;

	private Color JHBKILBGPJH = new Color(1f, 1f, 1f, 0f);

	private int KGNEJBGLEIK;

	private const float DFDFDJONMCG = 50f;

	private const float FIGJLHNKDHL = 0.05f;

	[SerializeField]
	private GameObject clickWarningUIPanel;

	private const float MANOFBOKGBO = 2f;

	private float CLFCCDDJBNC;

	private byte LCHLHPPKCMD;

	private void BNHLIGKMGGJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Mathf.Abs(fishIcon.anchoredPosition.x - box.anchoredPosition.x) < DNNFOPAGBPD)
		{
			Slider obj = progress;
			obj.value += MLHCLDNJEAG.hitProgression * Time.deltaTime * 8f;
			CGNKFGGKJNJ(DBAMEOKNHGH: true, OFMLEELGNHG: true);
		}
		else
		{
			Slider obj2 = progress;
			obj2.value -= MLHCLDNJEAG.hitReduction * Time.deltaTime * 8f;
			CGNKFGGKJNJ(DBAMEOKNHGH: false, OFMLEELGNHG: true);
		}
	}

	private void JHAKOHMLJIL(bool DBAMEOKNHGH, bool OFMLEELGNHG)
	{
		if (OFMLEELGNHG)
		{
			if (DBAMEOKNHGH)
			{
				boxImage.sprite = settings.greenBox;
			}
			else
			{
				boxImage.sprite = settings.redBox;
			}
		}
		else
		{
			boxImage.sprite = settings.normalBox;
		}
	}

	public void StartFishingGame(Rod COHELLCBDMF)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		fish = FishingManager.SelectAFish(base.JIIGOACEIKL, COHELLCBDMF);
		if (fish.fishType != Fish.FishType.Trash)
		{
			FishingManager.AddFishInformation(fish);
		}
		CDNOEKOOMKF = Time.timeSinceLevelLoad + 1.5f;
		fishIcon.anchoredPosition = new Vector2(0f, 1f);
		box.anchoredPosition = new Vector2(0f, 1f);
		JFGGACGDDDF(fish);
		KHGFGGBOFEH();
	}

	private void INDLJCNOIDM()
	{
		clickWarningUIPanel.SetActive(true);
	}

	private void MLIGGDMNJKH()
	{
		if (CDNOEKOOMKF < Time.timeSinceLevelLoad)
		{
			Slider obj = progress;
			obj.value -= MLHCLDNJEAG.barReductionPerSecond * Time.deltaTime;
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		IPAGCNOAEHL = buttonSignalPosition;
		base.Awake();
	}

	private void JDPJDLPNDKB()
	{
		LCHLHPPKCMD++;
		((MonoBehaviour)this).StopCoroutine(JBPKEOANIEC());
		CLFCCDDJBNC = 691f;
		((MonoBehaviour)this).StartCoroutine(JBPKEOANIEC());
	}

	private void EILOJFDJLCF()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		PAOPFIIBHME = true;
		PCHLDBCBHPM = LCPMKENLFJE + Random.Range(LCPMKENLFJE * (0f - settings.randomVariation), LCPMKENLFJE * settings.randomVariation);
		DBEFBFPAOAA = 0f;
		MAFLNEMCHJL = fishIcon.anchoredPosition;
		KGFOBNEKKKM = FFNHJPMACGD + Random.Range(FFNHJPMACGD * (0f - settings.randomVariation), FFNHJPMACGD * settings.randomVariation);
		if (Random.Range(0, 100) > 50)
		{
			KGFOBNEKKKM *= -1f;
		}
		if (Mathf.Abs(fishIcon.anchoredPosition.x + KGFOBNEKKKM) > KBIGNAGEAFM)
		{
			KGFOBNEKKKM *= -1f;
		}
		HNGHHLMFHIN = fishIcon.anchoredPosition.x + KGFOBNEKKKM;
		if (Mathf.Abs(HNGHHLMFHIN) > KBIGNAGEAFM)
		{
			if (HNGHHLMFHIN > 0f)
			{
				HNGHHLMFHIN = KBIGNAGEAFM;
			}
			else
			{
				HNGHHLMFHIN = 0f - KBIGNAGEAFM;
			}
		}
		if (HNGHHLMFHIN > MAFLNEMCHJL.x)
		{
			((Transform)fishIcon).localScale = Vector3.one;
		}
		else
		{
			((Transform)fishIcon).localScale = new Vector3(-1f, 1f, 1f);
		}
	}

	private void GOGBKANAGNM()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / PCHLDBCBHPM;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (1061f * DCGBADKLANM - 1459f) + 1749f);
		if (DCGBADKLANM > 927f || Mathf.Abs(fishIcon.anchoredPosition.x - HNGHHLMFHIN) <= 1620f * Time.deltaTime)
		{
			fishIcon.anchoredPosition = new Vector2(HNGHHLMFHIN, 448f);
			KHGFGGBOFEH();
		}
		else
		{
			fishIcon.anchoredPosition = new Vector2(Mathf.Lerp(MAFLNEMCHJL.x, HNGHHLMFHIN, DCGBADKLANM), 1258f);
		}
	}

	private void DMEEJCJGNHD(bool DBAMEOKNHGH, bool OFMLEELGNHG)
	{
		PLPKGABDKKH(DBAMEOKNHGH);
		KCAOOLMFLCJ(DBAMEOKNHGH);
		OFBOKLFJEHL(DBAMEOKNHGH, OFMLEELGNHG);
		JHAKOHMLJIL(DBAMEOKNHGH, OFMLEELGNHG);
		OPPNHBNOLLN(OFMLEELGNHG);
	}

	private void HHGOCANNFDM(bool OEIALNKDNJB)
	{
		buttonSignalPosition = (OEIALNKDNJB ? BEFEHJPOMHA : IPAGCNOAEHL);
	}

	private void DNBLIKMOOOM()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / PCHLDBCBHPM;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (771f * DCGBADKLANM - 894f) + 162f);
		if (DCGBADKLANM > 1518f || Mathf.Abs(fishIcon.anchoredPosition.x - HNGHHLMFHIN) <= 867f * Time.deltaTime)
		{
			fishIcon.anchoredPosition = new Vector2(HNGHHLMFHIN, 767f);
			KHGFGGBOFEH();
		}
		else
		{
			fishIcon.anchoredPosition = new Vector2(Mathf.Lerp(MAFLNEMCHJL.x, HNGHHLMFHIN, DCGBADKLANM), 818f);
		}
	}

	private void GDPLKBIFBDL()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((Transform)box).position = Vector2.op_Implicit(new Vector2(CursorManager.CMDGPJEIIJI(base.JIIGOACEIKL).ADAKFICJPIK().x, 975f));
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x), 109f);
		}
		else
		{
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x + settings.gamepadMovementSpeed * PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).GNCBKEDHLHN("Level {0}: {1}") * Time.deltaTime), 1019f);
		}
		KEGCIILIJPM();
	}

	private void PLPKGABDKKH(bool MCGJIGLLANB)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (MCGJIGLLANB)
		{
			if (KGJLMIDPHPA < Time.timeSinceLevelLoad)
			{
				KGJLMIDPHPA = Time.timeSinceLevelLoad + settings.shakePeriod * Random.Range(54f, 1487f);
				fishShakeSprite.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2.zero + Random.insideUnitCircle * settings.shakeAmount)));
			}
		}
		else if (fishShakeSprite.anchoredPosition != Vector2.zero)
		{
			fishShakeSprite.anchoredPosition = Vector2.zero;
		}
	}

	private void DKNGHLGMDBK()
	{
		if (!PAOPFIIBHME && Time.timeSinceLevelLoad > MMJGDDIJPGL)
		{
			MLOIACFBPGK();
		}
		else if (!PAOPFIIBHME)
		{
			JBKLOKIPJCJ();
		}
		if (PAOPFIIBHME)
		{
			GOGBKANAGNM();
		}
	}

	private void BBMFCAIPKDE(bool MCGJIGLLANB)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (MCGJIGLLANB)
		{
			if (KGJLMIDPHPA < Time.timeSinceLevelLoad)
			{
				KGJLMIDPHPA = Time.timeSinceLevelLoad + settings.shakePeriod * Random.Range(1149f, 959f);
				fishShakeSprite.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2.zero + Random.insideUnitCircle * settings.shakeAmount), BJOCPBIKBEE: true));
			}
		}
		else if (fishShakeSprite.anchoredPosition != Vector2.zero)
		{
			fishShakeSprite.anchoredPosition = Vector2.zero;
		}
	}

	private void KCAOOLMFLCJ(bool FPMLHNFBKJJ)
	{
		if (FPMLHNFBKJJ)
		{
			greenBarAnimation.speed = Mathf.Lerp(greenBarAnimation.speed, 80f, Time.unscaledDeltaTime * 4f);
			redBarAnimation.speed = Mathf.Lerp(redBarAnimation.speed, 0f, Time.unscaledDeltaTime * 4f);
		}
		else if (!FPMLHNFBKJJ)
		{
			greenBarAnimation.speed = Mathf.Lerp(greenBarAnimation.speed, 0f, Time.unscaledDeltaTime * 4f);
			redBarAnimation.speed = Mathf.Lerp(redBarAnimation.speed, -80f, Time.unscaledDeltaTime * 4f);
		}
	}

	private void LateUpdate()
	{
		if (content.activeInHierarchy)
		{
			IPDMOGGBKNE();
			if (DLKCPKAOPMA())
			{
				PBCNONJMOMI();
			}
			if (EIAMGEJNMAP())
			{
				BNHLIGKMGGJ();
			}
			else
			{
				CGNKFGGKJNJ(DBAMEOKNHGH: false, OFMLEELGNHG: false);
			}
			PPFKCNPGOBL();
		}
	}

	private void IFAOHOFADDC()
	{
		if (!clickWarningUIPanel.activeSelf)
		{
			clickWarningUIPanel.SetActive(true);
			((MonoBehaviour)this).Invoke("NGALBAHCNFB", 3f);
		}
	}

	private void JPIOOKGOEAN(bool DBAMEOKNHGH, bool OFMLEELGNHG)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (OFMLEELGNHG)
		{
			if (DBAMEOKNHGH)
			{
				((Graphic)boxGlow).color = Color.Lerp(((Graphic)boxGlow).color, settings.positiveGlowColor, Time.unscaledDeltaTime * 1489f);
			}
			else
			{
				((Graphic)boxGlow).color = Color.Lerp(((Graphic)boxGlow).color, settings.negativeGlowColor, Time.unscaledDeltaTime * 903f);
			}
		}
		else
		{
			((Graphic)boxGlow).color = Color.Lerp(((Graphic)boxGlow).color, JHBKILBGPJH, Time.unscaledDeltaTime * 233f);
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			OOGIFKPEKMA = false;
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			NGALBAHCNFB();
		}
	}

	private void NDJALOIBDDE()
	{
		CPBCFPHFACE();
		MFJIDAEGCCE();
	}

	public override void CloseUI()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen() || !OOGIFKPEKMA)
		{
			return;
		}
		base.CloseUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		Result variable;
		if (FLMLLMHPJJA)
		{
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt > 10)
			{
				return;
			}
			variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt >= 8)
			{
				DialogueLua.SetVariable("FishMiniGameWin", (object)true);
				DialogueLua.SetVariable("LE_10", (object)10);
				if (OnlineManager.PlayingOnline())
				{
					OnlineDialogueManager instance = OnlineDialogueManager.instance;
					variable = DialogueLua.GetVariable("LE_10");
					instance.SendDialogueInfo("LE_10", ((Result)(ref variable)).asInt);
				}
				HikariNPC.GGFJGHHHEJC.ActiveDialogue(base.JIIGOACEIKL);
				HikariNPC.GGFJGHHHEJC.inTutorial = false;
			}
			return;
		}
		variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt > 10)
		{
			return;
		}
		variable = DialogueLua.GetVariable("LE_10");
		if (((Result)(ref variable)).asInt < 8)
		{
			return;
		}
		KGNEJBGLEIK++;
		if (KGNEJBGLEIK >= 3)
		{
			DialogueLua.SetVariable("FishMiniGameWin", (object)false);
			DialogueLua.SetVariable("LE_10", (object)10);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance2 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("LE_10");
				instance2.SendDialogueInfo("LE_10", ((Result)(ref variable)).asInt);
			}
			HikariNPC.GGFJGHHHEJC.ActiveDialogue(base.JIIGOACEIKL);
		}
		else
		{
			DialogueLua.SetVariable("LE_10", (object)9);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance3 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("LE_10");
				instance3.SendDialogueInfo("LE_10", ((Result)(ref variable)).asInt);
			}
			HikariNPC.GGFJGHHHEJC.ActiveDialogue(base.JIIGOACEIKL);
		}
	}

	private void CPONGJALOLH()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((Transform)box).position = Vector2.op_Implicit(new Vector2(CursorManager.CMDGPJEIIJI(base.JIIGOACEIKL).ILFGBIEOFEH().x, 1096f));
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x), 1199f);
		}
		else
		{
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x + settings.gamepadMovementSpeed * PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis(" x ") * Time.deltaTime), 1828f);
		}
		MONJPNJJLBH();
	}

	protected override void Update()
	{
		base.Update();
		if (content.activeInHierarchy)
		{
			NDJALOIBDDE();
		}
	}

	private void MJIDKDOOHDG(bool DBAMEOKNHGH, bool OFMLEELGNHG)
	{
		PLPKGABDKKH(DBAMEOKNHGH);
		KCAOOLMFLCJ(DBAMEOKNHGH);
		JPIOOKGOEAN(DBAMEOKNHGH, OFMLEELGNHG);
		JHAKOHMLJIL(DBAMEOKNHGH, OFMLEELGNHG);
		OPPNHBNOLLN(OFMLEELGNHG);
	}

	private void MLOIACFBPGK()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		PAOPFIIBHME = true;
		PCHLDBCBHPM = LCPMKENLFJE + Random.Range(LCPMKENLFJE * (0f - settings.randomVariation), LCPMKENLFJE * settings.randomVariation);
		DBEFBFPAOAA = 790f;
		MAFLNEMCHJL = fishIcon.anchoredPosition;
		KGFOBNEKKKM = FFNHJPMACGD + Random.Range(FFNHJPMACGD * (0f - settings.randomVariation), FFNHJPMACGD * settings.randomVariation);
		if (Random.Range(0, -28) > -27)
		{
			KGFOBNEKKKM *= 829f;
		}
		if (Mathf.Abs(fishIcon.anchoredPosition.x + KGFOBNEKKKM) > KBIGNAGEAFM)
		{
			KGFOBNEKKKM *= 164f;
		}
		HNGHHLMFHIN = fishIcon.anchoredPosition.x + KGFOBNEKKKM;
		if (Mathf.Abs(HNGHHLMFHIN) > KBIGNAGEAFM)
		{
			if (HNGHHLMFHIN > 952f)
			{
				HNGHHLMFHIN = KBIGNAGEAFM;
			}
			else
			{
				HNGHHLMFHIN = 0f - KBIGNAGEAFM;
			}
		}
		if (HNGHHLMFHIN > MAFLNEMCHJL.x)
		{
			((Transform)fishIcon).localScale = Vector3.one;
		}
		else
		{
			((Transform)fishIcon).localScale = new Vector3(177f, 1581f, 1132f);
		}
	}

	private void KHGFGGBOFEH()
	{
		PAOPFIIBHME = false;
		MMJGDDIJPGL = Time.timeSinceLevelLoad + OIMHAAPEBIL + Random.Range(OIMHAAPEBIL * (0f - settings.randomVariation), OIMHAAPEBIL * settings.randomVariation);
	}

	protected override void Start()
	{
		base.Start();
	}

	private IEnumerator JBPKEOANIEC()
	{
		while (CLFCCDDJBNC > 0f)
		{
			if (LCHLHPPKCMD >= 3)
			{
				IFAOHOFADDC();
			}
			CLFCCDDJBNC -= Time.deltaTime;
			yield return null;
		}
		LCHLHPPKCMD = 0;
	}

	private bool BPLNDNAFCNE()
	{
		if (!PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).DLFAMOCKNMA("Disabled"))
		{
			return false;
		}
		if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Room missing required items") || PlayerInputs.GetPlayer(base.JIIGOACEIKL).JCMOPOMLPLL("HollyShop"))
		{
			return false;
		}
		return false;
	}

	private void OPPNHBNOLLN(bool OFMLEELGNHG)
	{
		if (OFMLEELGNHG && !(Time.timeSinceLevelLoad < KCACMNACPBN))
		{
			KCACMNACPBN = Time.timeSinceLevelLoad + 0.05f * Random.Range(0.9f, 1.1f);
			FishingController.PlayReelClick(base.JIIGOACEIKL);
		}
	}

	private void KEGCIILIJPM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (Mathf.Abs(box.anchoredPosition.x) > FEBHBADOJGF)
		{
			if (box.anchoredPosition.x > 453f)
			{
				box.anchoredPosition = new Vector2(FEBHBADOJGF, 1034f);
			}
			else
			{
				box.anchoredPosition = new Vector2(0f - FEBHBADOJGF, 1728f);
			}
		}
	}

	private void JBKLOKIPJCJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (((Transform)fishIcon).localScale.x > 0f)
		{
			fishIcon.anchoredPosition = new Vector2(fishIcon.anchoredPosition.x + 5f * Time.deltaTime, 1f);
			if (Mathf.Abs(fishIcon.anchoredPosition.x) > KBIGNAGEAFM)
			{
				fishIcon.anchoredPosition = new Vector2(KBIGNAGEAFM, 1f);
			}
		}
		else
		{
			fishIcon.anchoredPosition = new Vector2(fishIcon.anchoredPosition.x - 5f * Time.deltaTime, 1f);
			if (Mathf.Abs(fishIcon.anchoredPosition.x) > KBIGNAGEAFM)
			{
				fishIcon.anchoredPosition = new Vector2(0f - KBIGNAGEAFM, 1f);
			}
		}
	}

	private void JFGGACGDDDF(Fish HLIHBIMBLMM)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		MLHCLDNJEAG = (settings.EASY_FISHING ? settings.easyMode : settings.normalMode);
		NHNNHMDIBGK = HLIHBIMBLMM.difficulty;
		LCPMKENLFJE = Mathf.Lerp(MLHCLDNJEAG.movementTime.max, MLHCLDNJEAG.movementTime.min, NHNNHMDIBGK / 50f);
		FFNHJPMACGD = Mathf.Lerp(MLHCLDNJEAG.movementDistance.min, MLHCLDNJEAG.movementDistance.max, NHNNHMDIBGK / 50f);
		OIMHAAPEBIL = Mathf.Lerp(MLHCLDNJEAG.stopTime.max, MLHCLDNJEAG.stopTime.min, NHNNHMDIBGK / 50f);
		progress.value = 0.3f;
		DNNFOPAGBPD = box.sizeDelta.x * 0.5f;
	}

	private void JOGPPAENIPK(bool OFMLEELGNHG)
	{
		if (OFMLEELGNHG && !(Time.timeSinceLevelLoad < KCACMNACPBN))
		{
			KCACMNACPBN = Time.timeSinceLevelLoad + 1699f * Random.Range(644f, 1864f);
			FishingController.CEADMPDAPHN(base.JIIGOACEIKL);
		}
	}

	private void HNEILFFLOAH()
	{
		LCHLHPPKCMD++;
		((MonoBehaviour)this).StopCoroutine(JBPKEOANIEC());
		CLFCCDDJBNC = 78f;
		((MonoBehaviour)this).StartCoroutine(JBPKEOANIEC());
	}

	private void OEJNKEJOIIL(bool MCGJIGLLANB)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (MCGJIGLLANB)
		{
			if (KGJLMIDPHPA < Time.timeSinceLevelLoad)
			{
				KGJLMIDPHPA = Time.timeSinceLevelLoad + settings.shakePeriod * Random.Range(0.9f, 1.1f);
				fishShakeSprite.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(Vector2.zero + Random.insideUnitCircle * settings.shakeAmount)));
			}
		}
		else if (fishShakeSprite.anchoredPosition != Vector2.zero)
		{
			fishShakeSprite.anchoredPosition = Vector2.zero;
		}
	}

	private void CGNKFGGKJNJ(bool DBAMEOKNHGH, bool OFMLEELGNHG)
	{
		OEJNKEJOIIL(DBAMEOKNHGH);
		KCAOOLMFLCJ(DBAMEOKNHGH);
		OFBOKLFJEHL(DBAMEOKNHGH, OFMLEELGNHG);
		JHAKOHMLJIL(DBAMEOKNHGH, OFMLEELGNHG);
		OPPNHBNOLLN(OFMLEELGNHG);
	}

	private bool PKBPDJCOLDA()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).JCMOPOMLPLL("Accept"))
		{
			return false;
		}
		if (PlayerInputs.DEGBDMMDIIL(base.JIIGOACEIKL).JCMOPOMLPLL(" to local storage for reason: ") || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Dialogue System/Conversation/HappyRentRoom/Entry/2/Dialogue Text"))
		{
			return false;
		}
		return true;
	}

	private void MFJIDAEGCCE()
	{
		if (CDNOEKOOMKF < Time.timeSinceLevelLoad)
		{
			Slider obj = progress;
			obj.value -= MLHCLDNJEAG.barReductionPerSecond * Time.deltaTime;
		}
	}

	private void ALCKOBFDBAN()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / PCHLDBCBHPM;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
		if (DCGBADKLANM > 1f || Mathf.Abs(fishIcon.anchoredPosition.x - HNGHHLMFHIN) <= 5f * Time.deltaTime)
		{
			fishIcon.anchoredPosition = new Vector2(HNGHHLMFHIN, 1f);
			KHGFGGBOFEH();
		}
		else
		{
			fishIcon.anchoredPosition = new Vector2(Mathf.Lerp(MAFLNEMCHJL.x, HNGHHLMFHIN, DCGBADKLANM), 1f);
		}
	}

	public void SetFishingIcon(MineFishingKeyItem FPBPEAAIOBK)
	{
		if ((Object)(object)FPBPEAAIOBK == (Object)null)
		{
			((Component)fishShakeSprite).gameObject.SetActive(true);
			((Component)specialItemSprite).gameObject.SetActive(false);
		}
		else
		{
			((Component)fishShakeSprite).gameObject.SetActive(false);
			((Component)specialItemSprite).gameObject.SetActive(true);
		}
	}

	private void MNHOAAIPPEC()
	{
		CPBCFPHFACE();
		MLIGGDMNJKH();
	}

	private void PPFKCNPGOBL()
	{
		if (progress.value == 1f && IsOpen())
		{
			FLMLLMHPJJA = true;
			OOGIFKPEKMA = true;
			CloseUI();
		}
		else if (progress.value == 0f && IsOpen())
		{
			FLMLLMHPJJA = false;
			fish = null;
			OOGIFKPEKMA = true;
			CloseUI();
		}
	}

	private void HGHJANFAHMP(bool FPMLHNFBKJJ)
	{
		if (FPMLHNFBKJJ)
		{
			greenBarAnimation.speed = Mathf.Lerp(greenBarAnimation.speed, 840f, Time.unscaledDeltaTime * 947f);
			redBarAnimation.speed = Mathf.Lerp(redBarAnimation.speed, 1243f, Time.unscaledDeltaTime * 1235f);
		}
		else if (!FPMLHNFBKJJ)
		{
			greenBarAnimation.speed = Mathf.Lerp(greenBarAnimation.speed, 613f, Time.unscaledDeltaTime * 1785f);
			redBarAnimation.speed = Mathf.Lerp(redBarAnimation.speed, 953f, Time.unscaledDeltaTime * 67f);
		}
	}

	private void CILGEBFIJNE()
	{
		DKNGHLGMDBK();
		MFJIDAEGCCE();
	}

	public static FishingUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private bool DLKCPKAOPMA()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Start"))
		{
			return true;
		}
		if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIInteract") || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIAddRemove"))
		{
			return true;
		}
		return false;
	}

	private void HPFAOACNLJF()
	{
		LCHLHPPKCMD += 0;
		((MonoBehaviour)this).StopCoroutine(JBPKEOANIEC());
		CLFCCDDJBNC = 121f;
		((MonoBehaviour)this).StartCoroutine(JBPKEOANIEC());
	}

	private void MONJPNJJLBH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (Mathf.Abs(box.anchoredPosition.x) > FEBHBADOJGF)
		{
			if (box.anchoredPosition.x > 0f)
			{
				box.anchoredPosition = new Vector2(FEBHBADOJGF, 1f);
			}
			else
			{
				box.anchoredPosition = new Vector2(0f - FEBHBADOJGF, 1f);
			}
		}
	}

	private bool EIAMGEJNMAP()
	{
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButton("Start"))
		{
			return true;
		}
		if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButton("UIInteract") || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButton("UIAddRemove"))
		{
			return true;
		}
		return false;
	}

	private void CPBCFPHFACE()
	{
		if (!PAOPFIIBHME && Time.timeSinceLevelLoad > MMJGDDIJPGL)
		{
			EILOJFDJLCF();
		}
		else if (!PAOPFIIBHME)
		{
			JBKLOKIPJCJ();
		}
		if (PAOPFIIBHME)
		{
			ALCKOBFDBAN();
		}
	}

	private void IPDMOGGBKNE()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((Transform)box).position = Vector2.op_Implicit(new Vector2(CursorManager.GetPlayer(base.JIIGOACEIKL).GetCursorPosition().x, 0f));
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x), 1f);
		}
		else
		{
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x + settings.gamepadMovementSpeed * PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis("UIHorizontal") * Time.deltaTime), 1f);
		}
		MONJPNJJLBH();
	}

	private void OFBOKLFJEHL(bool DBAMEOKNHGH, bool OFMLEELGNHG)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (OFMLEELGNHG)
		{
			if (DBAMEOKNHGH)
			{
				((Graphic)boxGlow).color = Color.Lerp(((Graphic)boxGlow).color, settings.positiveGlowColor, Time.unscaledDeltaTime * 15f);
			}
			else
			{
				((Graphic)boxGlow).color = Color.Lerp(((Graphic)boxGlow).color, settings.negativeGlowColor, Time.unscaledDeltaTime * 15f);
			}
		}
		else
		{
			((Graphic)boxGlow).color = Color.Lerp(((Graphic)boxGlow).color, JHBKILBGPJH, Time.unscaledDeltaTime * 15f);
		}
	}

	private void FHDADHEBDJF()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			((Transform)box).position = Vector2.op_Implicit(new Vector2(CursorManager.GetPlayer(base.JIIGOACEIKL).ADAKFICJPIK().x, 1362f));
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x), 1755f);
		}
		else
		{
			box.anchoredPosition = new Vector2(Utils.PMNDBKBJJNP(box.anchoredPosition.x + settings.gamepadMovementSpeed * PlayerInputs.GetPlayer(base.JIIGOACEIKL).GNCBKEDHLHN(", ") * Time.deltaTime), 921f);
		}
		KEGCIILIJPM();
	}

	private void PBCNONJMOMI()
	{
		LCHLHPPKCMD++;
		((MonoBehaviour)this).StopCoroutine(JBPKEOANIEC());
		CLFCCDDJBNC = 2f;
		((MonoBehaviour)this).StartCoroutine(JBPKEOANIEC());
	}

	private void OFABMIJAFMC(bool OEIALNKDNJB)
	{
		buttonSignalPosition = (OEIALNKDNJB ? BEFEHJPOMHA : IPAGCNOAEHL);
	}

	public static FishingUI CJMILOMGFJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AMJNHKHJNKE()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		PAOPFIIBHME = true;
		PCHLDBCBHPM = LCPMKENLFJE + Random.Range(LCPMKENLFJE * (0f - settings.randomVariation), LCPMKENLFJE * settings.randomVariation);
		DBEFBFPAOAA = 1186f;
		MAFLNEMCHJL = fishIcon.anchoredPosition;
		KGFOBNEKKKM = FFNHJPMACGD + Random.Range(FFNHJPMACGD * (0f - settings.randomVariation), FFNHJPMACGD * settings.randomVariation);
		if (Random.Range(0, 9) > 0)
		{
			KGFOBNEKKKM *= 469f;
		}
		if (Mathf.Abs(fishIcon.anchoredPosition.x + KGFOBNEKKKM) > KBIGNAGEAFM)
		{
			KGFOBNEKKKM *= 218f;
		}
		HNGHHLMFHIN = fishIcon.anchoredPosition.x + KGFOBNEKKKM;
		if (Mathf.Abs(HNGHHLMFHIN) > KBIGNAGEAFM)
		{
			if (HNGHHLMFHIN > 572f)
			{
				HNGHHLMFHIN = KBIGNAGEAFM;
			}
			else
			{
				HNGHHLMFHIN = 0f - KBIGNAGEAFM;
			}
		}
		if (HNGHHLMFHIN > MAFLNEMCHJL.x)
		{
			((Transform)fishIcon).localScale = Vector3.one;
		}
		else
		{
			((Transform)fishIcon).localScale = new Vector3(235f, 410f, 630f);
		}
	}

	private void NGALBAHCNFB()
	{
		clickWarningUIPanel.SetActive(false);
	}
}
