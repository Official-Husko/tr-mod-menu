using UnityEngine;
using UnityEngine.UI;

public class CropInfoUI : UIWindow
{
	[SerializeField]
	private SegmentedProgressBar cropGrowthBar;

	[SerializeField]
	private SegmentedProgressBar cropWaterBar;

	[SerializeField]
	private GameObject cropGrowthBarContainer;

	[SerializeField]
	private GameObject cropWaterBarContainer;

	[SerializeField]
	private Sprite seed;

	[SerializeField]
	private Sprite leaf;

	[SerializeField]
	private Sprite apple;

	[SerializeField]
	private Image growthLeftIcon;

	[SerializeField]
	private Image growthRightIcon;

	[SerializeField]
	private SlotUI cropSlotUI;

	[SerializeField]
	private RectTransform contentRectTransform;

	public CropToolTip cropToolTip;

	public static CropInfoUI[] instances = new CropInfoUI[2];

	public static float delayTime = 0.5f;

	private Vector2 EADJALGGIGM;

	private Vector2 MBNPNOJAJCB;

	public RectTransform canvas;

	private int FLHEDNDENNP;

	private Vector2 GOOKKKGIGBL;

	private Vector2 PJDMDNGEBKM;

	private Vector2 PGBEEGPOINO;

	private Vector2 EPIGABHAJCJ;

	private float KHNHFJMJCNA = 40f;

	private float BIBJJKLPODO = 40f;

	public float offsetVertical = 8f;

	private bool MDIKPGGBNLI;

	public void EAGNJKKNLDK(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			Camera obj = CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = obj.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 408f)
		{
			HPMMBKIFLPG();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 1738f)
		{
			GMNNNDOAOIN();
		}
		else if (GameManager.NBFLEJHLGNB())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1387f)
			{
				FHDEEBIBAFI();
			}
			else
			{
				HIPPGHIEAOI();
			}
		}
		else if (base.JIIGOACEIKL == 1)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 547f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1232f)
				{
					IKBAOPOMAEP();
				}
				else
				{
					MLCIHMOEFNJ();
				}
			}
			else
			{
				FCFLJCLJDKJ();
			}
		}
		else if (base.JIIGOACEIKL == 6)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 674f)
			{
				HPMMBKIFLPG();
			}
			else
			{
				IKBAOPOMAEP();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 116f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1042f + EPIGABHAJCJ.y / 1554f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 962f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public static CropInfoUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void IOIPBOJFPGM(bool MDIKPGGBNLI, Vector2 IMOBLFMHKOD = default(Vector2), Vector2 MBNPNOJAJCB = default(Vector2), ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true, bool FJHOIAKFEFO = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			return;
		}
		AMHACPHBPLK(IMOBLFMHKOD, MBNPNOJAJCB);
		IHIAMJKAFPJ(JFFBLKGIGIG: true);
		if (DNLMCHDOMOK != null || Item.MLBOMGHINCA(DNLMCHDOMOK.KNFNJFFCFNO(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.AHHEMNHJPME())
			{
				cropSlotUI.IHENCGDNPBL.CIDBFIAJIBG(CDPAMNIPPEC: false);
			}
			cropSlotUI.IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			cropSlotUI.JOGLJKIFGNL();
		}
		cropGrowthBar.OBHPDEDIFLK(LFKJEGFJNIP, HDLEOKEFLBM);
		cropGrowthBarContainer.SetActive(FJHOIAKFEFO);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(true);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(false);
			}
			cropWaterBar.EPKPNOICMPN(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
		this.MDIKPGGBNLI = true;
		IDLAGJNLPJL();
	}

	public static CropInfoUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MJONLLPJFHG(bool MDIKPGGBNLI, Vector2 IMOBLFMHKOD = default(Vector2), Vector2 MBNPNOJAJCB = default(Vector2), ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true, bool FJHOIAKFEFO = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			return;
		}
		LEHBBMJLAIM(IMOBLFMHKOD, MBNPNOJAJCB);
		CCNHEOKPLMH();
		if (DNLMCHDOMOK != null || Item.MLBOMGHINCA(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.PKFKJNODGJF())
			{
				cropSlotUI.IHENCGDNPBL.CIDBFIAJIBG(CDPAMNIPPEC: false);
			}
			cropSlotUI.IHENCGDNPBL.DDHPGOPOPKJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
			cropSlotUI.JOGLJKIFGNL();
		}
		cropGrowthBar.OKODJBHMFEJ(LFKJEGFJNIP, HDLEOKEFLBM);
		cropGrowthBarContainer.SetActive(FJHOIAKFEFO);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(false);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(false);
			}
			cropWaterBar.ELOCEEBLMLC(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
		this.MDIKPGGBNLI = false;
		EDHEIFHAAKO();
	}

	public void LKFDEJEHHJL(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			Camera obj = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = obj.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 620f)
		{
			LLFIHBPMIAM();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 920f)
		{
			IKBAOPOMAEP();
		}
		else if (GameManager.HDBECFMPJHL())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1748f)
			{
				CCBADNIHIIG();
			}
			else
			{
				HPMMBKIFLPG();
			}
		}
		else if (base.JIIGOACEIKL == 1)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1074f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1487f)
				{
					CCBADNIHIIG();
				}
				else
				{
					HIPPGHIEAOI();
				}
			}
			else
			{
				FHDEEBIBAFI();
			}
		}
		else if (base.JIIGOACEIKL == 3)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 47f)
			{
				LLFIHBPMIAM();
			}
			else
			{
				FCFLJCLJDKJ();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 354f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1242f + EPIGABHAJCJ.y / 1237f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 796f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void LateUpdate()
	{
		if (IsOpen() && FLHEDNDENNP <= 0)
		{
			SetPanelPosition(JFFBLKGIGIG: true);
		}
	}

	public void KPNHJDGOBGM(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			Camera obj = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = obj.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 1372f)
		{
			LICGNKFKGPP();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 1387f)
		{
			FHDEEBIBAFI();
		}
		else if (GameManager.SinglePlayer())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1337f)
			{
				FHDEEBIBAFI();
			}
			else
			{
				LLFIHBPMIAM();
			}
		}
		else if (base.JIIGOACEIKL == 0)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 402f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 100f)
				{
					IKBAOPOMAEP();
				}
				else
				{
					HPMMBKIFLPG();
				}
			}
			else
			{
				CCBADNIHIIG();
			}
		}
		else if (base.JIIGOACEIKL == 8)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1805f)
			{
				MLCIHMOEFNJ();
			}
			else
			{
				IKBAOPOMAEP();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 323f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 855f + EPIGABHAJCJ.y / 1276f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 918f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void LICGNKFKGPP()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 2f + BIBJJKLPODO;
	}

	public void GPFDHBGIMLA(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EADJALGGIGM = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	private void CEMALNJFGKM()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 122f + BIBJJKLPODO;
	}

	private void HPMMBKIFLPG()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 1433f + BIBJJKLPODO;
	}

	private void FCFLJCLJDKJ()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 419f - KHNHFJMJCNA;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	private void MLCIHMOEFNJ()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 1697f + BIBJJKLPODO;
	}

	public void CCNHEOKPLMH(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			Camera mainCamera = CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = mainCamera.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 1631f)
		{
			HPMMBKIFLPG();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 1153f)
		{
			FCFLJCLJDKJ();
		}
		else if (GameManager.HDBECFMPJHL())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1627f)
			{
				FHDEEBIBAFI();
			}
			else
			{
				HIPPGHIEAOI();
			}
		}
		else if (base.JIIGOACEIKL == 1)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 760f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 973f)
				{
					IKBAOPOMAEP();
				}
				else
				{
					MLCIHMOEFNJ();
				}
			}
			else
			{
				FCFLJCLJDKJ();
			}
		}
		else if (base.JIIGOACEIKL == 8)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 633f)
			{
				LICGNKFKGPP();
			}
			else
			{
				GMNNNDOAOIN();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 599f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1059f + EPIGABHAJCJ.y / 657f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1857f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void FHDEEBIBAFI()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1588f - KHNHFJMJCNA;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	private void OMLNDHJAAJD()
	{
		if (HDEPMJIDJEM() && FLHEDNDENNP <= 1)
		{
			EAGNJKKNLDK();
		}
	}

	private void LLFIHBPMIAM()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 606f + BIBJJKLPODO;
	}

	public void SetPosition(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EADJALGGIGM = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	public void FGLHBPGIFLH(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			Camera mainCamera = CommonReferences.MNFMOEKMJKN().GetMainCamera(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = mainCamera.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 329f)
		{
			MLCIHMOEFNJ();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 581f)
		{
			FHDEEBIBAFI();
		}
		else if (GameManager.SinglePlayer())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1447f)
			{
				FHDEEBIBAFI();
			}
			else
			{
				MLCIHMOEFNJ();
			}
		}
		else if (base.JIIGOACEIKL == 0)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 637f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 273f)
				{
					FHDEEBIBAFI();
				}
				else
				{
					MLCIHMOEFNJ();
				}
			}
			else
			{
				FHDEEBIBAFI();
			}
		}
		else if (base.JIIGOACEIKL == 5)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 977f)
			{
				HIPPGHIEAOI();
			}
			else
			{
				GMNNNDOAOIN();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1133f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1274f + EPIGABHAJCJ.y / 1269f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1872f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void GMNNNDOAOIN()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 940f - KHNHFJMJCNA;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	public void KKOGEMLJBEA(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			Camera mainCamera = CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.DGIILDNAMDA().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = mainCamera.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 23f)
		{
			HPMMBKIFLPG();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 358f)
		{
			GMNNNDOAOIN();
		}
		else if (GameManager.EAOOLEFMIKE())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 239f)
			{
				FHDEEBIBAFI();
			}
			else
			{
				LICGNKFKGPP();
			}
		}
		else if (base.JIIGOACEIKL == 0)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 714f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 333f)
				{
					CCBADNIHIIG();
				}
				else
				{
					MLCIHMOEFNJ();
				}
			}
			else
			{
				FCFLJCLJDKJ();
			}
		}
		else if (base.JIIGOACEIKL == 3)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1729f)
			{
				LLFIHBPMIAM();
			}
			else
			{
				FCFLJCLJDKJ();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1211f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1692f + EPIGABHAJCJ.y / 1468f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 464f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public static CropInfoUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && FLHEDNDENNP > 0 && MDIKPGGBNLI)
		{
			FLHEDNDENNP--;
		}
	}

	public void AMHACPHBPLK(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EADJALGGIGM = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	private void DIMOLCECNGD()
	{
		if (HDEPMJIDJEM() && FLHEDNDENNP <= 0)
		{
			CCNHEOKPLMH();
		}
	}

	public static CropInfoUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void IHIAMJKAFPJ(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			Camera obj = CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = obj.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetScreenCamera().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 715f)
		{
			CEMALNJFGKM();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 1356f)
		{
			FHDEEBIBAFI();
		}
		else if (GameManager.NBFLEJHLGNB())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 669f)
			{
				IKBAOPOMAEP();
			}
			else
			{
				HIPPGHIEAOI();
			}
		}
		else if (base.JIIGOACEIKL == 1)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1021f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1636f)
				{
					IKBAOPOMAEP();
				}
				else
				{
					HPMMBKIFLPG();
				}
			}
			else
			{
				CCBADNIHIIG();
			}
		}
		else if (base.JIIGOACEIKL == 5)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 774f)
			{
				HIPPGHIEAOI();
			}
			else
			{
				FHDEEBIBAFI();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 919f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1836f + EPIGABHAJCJ.y / 1572f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1198f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void HIPPGHIEAOI()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 1967f + BIBJJKLPODO;
	}

	public static CropInfoUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Awake()
	{
		base.Awake();
		instances[numInstance] = this;
		if ((Object)(object)cropToolTip == (Object)null)
		{
			cropToolTip = ((Component)this).GetComponent<CropToolTip>();
		}
	}

	public void BEJMDOPAAKJ(bool MDIKPGGBNLI, Vector2 IMOBLFMHKOD = default(Vector2), Vector2 MBNPNOJAJCB = default(Vector2), ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true, bool FJHOIAKFEFO = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			return;
		}
		GPFDHBGIMLA(IMOBLFMHKOD, MBNPNOJAJCB);
		SetPanelPosition();
		if (DNLMCHDOMOK != null || Item.FKLOBGBIHLB(DNLMCHDOMOK.AFOACBIHNCL(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.LCHJGCHDHFO())
			{
				cropSlotUI.IHENCGDNPBL.FMEPMEKLHIJ(CDPAMNIPPEC: false);
			}
			cropSlotUI.IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: true);
			cropSlotUI.JOGLJKIFGNL();
		}
		cropGrowthBar.MEBBJOLFPEB(LFKJEGFJNIP, HDLEOKEFLBM);
		cropGrowthBarContainer.SetActive(!FJHOIAKFEFO);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(true);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(false);
			}
			cropWaterBar.IJHLKHCGKPE(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
		this.MDIKPGGBNLI = false;
		IDLAGJNLPJL();
	}

	private void LJCOPHJMDEL()
	{
		if (HDEPMJIDJEM() && FLHEDNDENNP <= 0)
		{
			IHIAMJKAFPJ();
		}
	}

	public void ShowCropInfoPanel(bool MDIKPGGBNLI, Vector2 IMOBLFMHKOD = default(Vector2), Vector2 MBNPNOJAJCB = default(Vector2), ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true, bool FJHOIAKFEFO = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			return;
		}
		SetPosition(IMOBLFMHKOD, MBNPNOJAJCB);
		SetPanelPosition(JFFBLKGIGIG: true);
		if (DNLMCHDOMOK != null || Item.MLBOMGHINCA(DNLMCHDOMOK.LHBPOPOIFLE(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.KPINNBKMOMO())
			{
				cropSlotUI.IHENCGDNPBL.MEODNPFJDMH(CDPAMNIPPEC: false);
			}
			cropSlotUI.IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK);
			cropSlotUI.UpdateSlot();
		}
		cropGrowthBar.SetSegmentCount(LFKJEGFJNIP, HDLEOKEFLBM);
		cropGrowthBarContainer.SetActive(!FJHOIAKFEFO);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(false);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(true);
			}
			cropWaterBar.SetSegmentCount(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
		this.MDIKPGGBNLI = true;
		OpenUI();
	}

	private void IKBAOPOMAEP()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 2f - KHNHFJMJCNA;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	public void SetPanelPosition(bool JFFBLKGIGIG = false)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			Camera mainCamera = CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL);
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(EADJALGGIGM)));
			}
			Rect rect = mainCamera.rect;
			GOOKKKGIGBL.x = Mathf.Lerp(((Rect)(ref rect)).x, ((Rect)(ref rect)).x + ((Rect)(ref rect)).width, GOOKKKGIGBL.x);
			GOOKKKGIGBL.y = Mathf.Lerp(((Rect)(ref rect)).y, ((Rect)(ref rect)).y + ((Rect)(ref rect)).height, GOOKKKGIGBL.y);
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		EPIGABHAJCJ = contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 0f)
		{
			LICGNKFKGPP();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 0.98f)
		{
			IKBAOPOMAEP();
		}
		else if (GameManager.SinglePlayer())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 0.96f)
			{
				IKBAOPOMAEP();
			}
			else
			{
				LICGNKFKGPP();
			}
		}
		else if (base.JIIGOACEIKL == 1)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 0.25f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 0.48f)
				{
					IKBAOPOMAEP();
				}
				else
				{
					LICGNKFKGPP();
				}
			}
			else
			{
				IKBAOPOMAEP();
			}
		}
		else if (base.JIIGOACEIKL == 2)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 0.75f)
			{
				LICGNKFKGPP();
			}
			else
			{
				IKBAOPOMAEP();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 0f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1.8f + EPIGABHAJCJ.y / 2f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 2f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public void JOPNBHENHBF(bool MDIKPGGBNLI, Vector2 IMOBLFMHKOD = default(Vector2), Vector2 MBNPNOJAJCB = default(Vector2), ItemInstance DNLMCHDOMOK = null, int LFKJEGFJNIP = 4, int HDLEOKEFLBM = 0, int NLDDPMKPLCO = 3, int DPIOKONFANI = 0, bool HMFIJEOLIGP = true, bool FJHOIAKFEFO = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!MDIKPGGBNLI)
		{
			return;
		}
		GPFDHBGIMLA(IMOBLFMHKOD, MBNPNOJAJCB);
		EAGNJKKNLDK(JFFBLKGIGIG: true);
		if (DNLMCHDOMOK != null || Item.FKLOBGBIHLB(DNLMCHDOMOK.LHBPOPOIFLE(), null))
		{
			if (!cropSlotUI.IHENCGDNPBL.PKFKJNODGJF())
			{
				cropSlotUI.IHENCGDNPBL.CIDBFIAJIBG(CDPAMNIPPEC: false);
			}
			cropSlotUI.IHENCGDNPBL.FEEOFAGCONJ(base.JIIGOACEIKL, DNLMCHDOMOK, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			cropSlotUI.PAMDPKDMLGC();
		}
		cropGrowthBar.SetSegmentCount(LFKJEGFJNIP, HDLEOKEFLBM);
		cropGrowthBarContainer.SetActive(!FJHOIAKFEFO);
		if (NLDDPMKPLCO == 0)
		{
			cropWaterBarContainer.SetActive(true);
		}
		else
		{
			if (!cropWaterBarContainer.activeSelf)
			{
				cropWaterBarContainer.SetActive(false);
			}
			cropWaterBar.NNEHCEPDIHM(NLDDPMKPLCO, DPIOKONFANI);
		}
		if (Object.op_Implicit((Object)(object)growthRightIcon) && Object.op_Implicit((Object)(object)growthLeftIcon) && Object.op_Implicit((Object)(object)leaf) && Object.op_Implicit((Object)(object)seed) && Object.op_Implicit((Object)(object)apple))
		{
			growthLeftIcon.sprite = (HMFIJEOLIGP ? leaf : seed);
			growthRightIcon.sprite = (HMFIJEOLIGP ? apple : leaf);
		}
		this.MDIKPGGBNLI = false;
		EDHEIFHAAKO();
	}

	private void CCBADNIHIIG()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1418f - KHNHFJMJCNA;
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	private void DLKFBJPKADF()
	{
		if (HDEPMJIDJEM() && FLHEDNDENNP <= 0)
		{
			FGLHBPGIFLH();
		}
	}

	public void LEHBBMJLAIM(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		EADJALGGIGM = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	public override void CloseUI()
	{
		base.CloseUI();
		MDIKPGGBNLI = false;
	}
}
