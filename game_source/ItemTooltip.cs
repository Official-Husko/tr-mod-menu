using UnityEngine;

public class ItemTooltip : UIWindow
{
	public static ItemTooltip[] instances = new ItemTooltip[2];

	public static float delayTime = 0.5f;

	private ItemInstance BJHFNFAIPLL;

	private float KHNHFJMJCNA = 40f;

	private float BIBJJKLPODO = 40f;

	public float offsetVertical = 8f;

	public RectTransform canvas;

	private int FLHEDNDENNP;

	private bool KCCCICMGHID;

	private bool AIADOMPNHBD;

	private Vector2 AIAEDNIBGGL;

	private Vector2 MBNPNOJAJCB;

	[SerializeField]
	private TooltipPanel itemTooltip;

	[SerializeField]
	private BirdTooltipPanel birdTooltip;

	private TooltipPanel CMNFMBECBGE;

	private Vector2 GOOKKKGIGBL;

	private Vector2 PJDMDNGEBKM;

	private Vector2 PGBEEGPOINO;

	private Vector2 EPIGABHAJCJ;

	private void JEDCDHNMACA()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 1977f + BIBJJKLPODO;
	}

	public void JGGMEGPELNC(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		AIAEDNIBGGL = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	private void CCIHGBPAKMA()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 1502f + BIBJJKLPODO;
	}

	public void EILBJJGLCBG(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		AIAEDNIBGGL = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	public static ItemTooltip IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void GPPDAGBDIKM()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 994f - KHNHFJMJCNA;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	public static ItemTooltip AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JHELKBEOIJB(TooltipInfo BBJDPIJPLPA)
	{
		if (BBJDPIJPLPA.itemInstance != null && BBJDPIJPLPA.itemInstance is BirdInstance)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		CMNFMBECBGE.LBPEGFIMOHC(base.JIIGOACEIKL, BBJDPIJPLPA);
	}

	public void SetPosition(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		AIAEDNIBGGL = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	public void HIPGMDKJLCB(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EILBJJGLCBG(IMOBLFMHKOD, MBNPNOJAJCB);
		SetTooltipPosition(JFFBLKGIGIG: true);
		HIIOCMNJGCI(MDIKPGGBNLI: true, DNLMCHDOMOK);
	}

	public static ItemTooltip NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CEOOMNKDGLJ(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JGGMEGPELNC(IMOBLFMHKOD, MBNPNOJAJCB);
		SetTooltipPosition();
		ILGFPFBJMPG(MDIKPGGBNLI: true, DNLMCHDOMOK);
	}

	public void LEHBBMJLAIM(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		AIAEDNIBGGL = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	public void NBEIGGHAEMK(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool CCAICMBJAGH, bool EDFANMFDDEJ, bool PKBJMLACEMM)
	{
		if (HPHELAPHAHN != null && (BJHFNFAIPLL == null || BJHFNFAIPLL != HPHELAPHAHN))
		{
			base.JIIGOACEIKL = JIIGOACEIKL;
			BJHFNFAIPLL = HPHELAPHAHN;
			JHELKBEOIJB(HPHELAPHAHN.DLKGAOCFODF(JIIGOACEIKL, CCAICMBJAGH, EDFANMFDDEJ, PKBJMLACEMM, FCJLFPLAOJE: true));
		}
	}

	public void MDEILHDDGNL(bool JFFBLKGIGIG = false)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.ACIFGIBLENB().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		if (AIADOMPNHBD)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		EPIGABHAJCJ = CMNFMBECBGE.contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 1134f)
		{
			JEDCDHNMACA();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 800f)
		{
			EPKCPMHIDLJ();
		}
		else if (GameManager.SinglePlayer())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1605f)
			{
				IKBAOPOMAEP();
			}
			else
			{
				JEDCDHNMACA();
			}
		}
		else if (base.JIIGOACEIKL == 1)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1882f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1697f)
				{
					IKBAOPOMAEP();
				}
				else
				{
					CCIHGBPAKMA();
				}
			}
			else
			{
				EPKCPMHIDLJ();
			}
		}
		else if (base.JIIGOACEIKL == 8)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1841f)
			{
				LICGNKFKGPP();
			}
			else
			{
				HFLONKELKOI();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1188f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 916f + EPIGABHAJCJ.y / 1131f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 777f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		CMNFMBECBGE.contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	public void FillTooltipInfo(TooltipInfo BBJDPIJPLPA)
	{
		if (BBJDPIJPLPA.itemInstance != null && BBJDPIJPLPA.itemInstance is BirdInstance)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		CMNFMBECBGE.BKJKGMFLDCC(base.JIIGOACEIKL, BBJDPIJPLPA);
	}

	private void DPJCKHBONCG()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1453f - KHNHFJMJCNA;
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	public void DNPOMFHCLFJ(bool JFFBLKGIGIG = false)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		if (AIADOMPNHBD)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		EPIGABHAJCJ = CMNFMBECBGE.contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 989f)
		{
			CCIHGBPAKMA();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 419f)
		{
			CCBADNIHIIG();
		}
		else if (GameManager.NBFLEJHLGNB())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 439f)
			{
				DPJCKHBONCG();
			}
			else
			{
				OIANJNAKLLC();
			}
		}
		else if (base.JIIGOACEIKL == 0)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 340f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 767f)
				{
					HFLONKELKOI();
				}
				else
				{
					LICGNKFKGPP();
				}
			}
			else
			{
				CCBADNIHIIG();
			}
		}
		else if (base.JIIGOACEIKL == 6)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 709f)
			{
				JEDCDHNMACA();
			}
			else
			{
				DPJCKHBONCG();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1789f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 1029f + EPIGABHAJCJ.y / 79f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 1682f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		CMNFMBECBGE.contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	protected override void Update()
	{
		base.Update();
		if (FLHEDNDENNP > 0)
		{
			FLHEDNDENNP--;
		}
	}

	private void OGDDLNAECND()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 172f + BIBJJKLPODO;
	}

	public static ItemTooltip EOPIEMLAPFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OPPAAOMIAIJ(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EILBJJGLCBG(IMOBLFMHKOD, MBNPNOJAJCB);
		MDEILHDDGNL(JFFBLKGIGIG: true);
		HIIOCMNJGCI(MDIKPGGBNLI: false, DNLMCHDOMOK);
	}

	public void SetPositionAndEnable(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		SetPosition(IMOBLFMHKOD, MBNPNOJAJCB);
		SetTooltipPosition();
		SetVisible(MDIKPGGBNLI: true, DNLMCHDOMOK);
	}

	private void LICGNKFKGPP()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 2f + BIBJJKLPODO;
	}

	public void HIIOCMNJGCI(bool MDIKPGGBNLI, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (MDIKPGGBNLI)
		{
			if (DNLMCHDOMOK != null && DNLMCHDOMOK is BirdInstance)
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				KCCCICMGHID = true;
				AIADOMPNHBD = true;
			}
			else
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				KCCCICMGHID = false;
				AIADOMPNHBD = false;
			}
			FLHEDNDENNP = 8;
			itemTooltip.contentRectTransform.anchoredPosition = Vector2.one * 999f;
			birdTooltip.contentRectTransform.anchoredPosition = Vector2.one * 588f;
		}
		else
		{
			if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)birdTooltip.contentRectTransform).gameObject.SetActive(true);
			}
			if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)itemTooltip.contentRectTransform).gameObject.SetActive(false);
			}
			BJHFNFAIPLL = null;
			KCCCICMGHID = false;
			AIADOMPNHBD = true;
		}
	}

	private void BODEIHFOAMI()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 0)
		{
			DNPOMFHCLFJ(JFFBLKGIGIG: true);
		}
	}

	private void IKJIJICJIFG()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 0)
		{
			SetTooltipPosition(JFFBLKGIGIG: true);
		}
	}

	public void JCLBGLEFMMO(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		SetPosition(IMOBLFMHKOD, MBNPNOJAJCB);
		SetTooltipPosition(JFFBLKGIGIG: true);
		ILGFPFBJMPG(MDIKPGGBNLI: true, DNLMCHDOMOK);
	}

	public void LGDDFMNFNME(TooltipInfo BBJDPIJPLPA)
	{
		if (BBJDPIJPLPA.itemInstance != null && BBJDPIJPLPA.itemInstance is BirdInstance)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		CMNFMBECBGE.GJNAJIHGJHH(base.JIIGOACEIKL, BBJDPIJPLPA);
	}

	public void JCCNKAHICBJ(bool JFFBLKGIGIG = false)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().PGKPJEBAKJP(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().ACIFGIBLENB().ScreenToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().DGIILDNAMDA().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		if (AIADOMPNHBD)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		EPIGABHAJCJ = CMNFMBECBGE.contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.y;
		if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x < 1514f)
		{
			JEDCDHNMACA();
		}
		else if (GameManager.LocalCoop() && PJDMDNGEBKM.x - EPIGABHAJCJ.x > canvas.sizeDelta.x * 892f)
		{
			IKBAOPOMAEP();
		}
		else if (GameManager.EAOOLEFMIKE())
		{
			if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1584f)
			{
				HFLONKELKOI();
			}
			else
			{
				OGDDLNAECND();
			}
		}
		else if (base.JIIGOACEIKL == 1)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1476f)
			{
				if (PJDMDNGEBKM.x + EPIGABHAJCJ.x > canvas.sizeDelta.x * 1566f)
				{
					HFLONKELKOI();
				}
				else
				{
					CCIHGBPAKMA();
				}
			}
			else
			{
				CCBADNIHIIG();
			}
		}
		else if (base.JIIGOACEIKL == 6)
		{
			if (PJDMDNGEBKM.x < canvas.sizeDelta.x * 1043f)
			{
				OGDDLNAECND();
			}
			else
			{
				IKBAOPOMAEP();
			}
		}
		if (PJDMDNGEBKM.y - EPIGABHAJCJ.y - PGBEEGPOINO.y < 1048f)
		{
			PGBEEGPOINO.y = PGBEEGPOINO.y * 491f + EPIGABHAJCJ.y / 136f - PJDMDNGEBKM.y;
		}
		else
		{
			PGBEEGPOINO.y = 0f - PGBEEGPOINO.y - EPIGABHAJCJ.y / 200f + offsetVertical;
		}
		PGBEEGPOINO.x = Mathf.RoundToInt(PGBEEGPOINO.x);
		PGBEEGPOINO.y = Mathf.RoundToInt(PGBEEGPOINO.y);
		CMNFMBECBGE.contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	protected override void Awake()
	{
		base.Awake();
		instances[numInstance] = this;
	}

	private void DKFGDMNBAAK()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 0)
		{
			DNPOMFHCLFJ();
		}
	}

	public void AADJPLPKGHO(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EILBJJGLCBG(IMOBLFMHKOD, MBNPNOJAJCB);
		SetTooltipPosition(JFFBLKGIGIG: true);
		FCACMDNLAIG(MDIKPGGBNLI: false, DNLMCHDOMOK);
	}

	public void OOJMCKAKFIH(TooltipInfo BBJDPIJPLPA)
	{
		if (BBJDPIJPLPA.itemInstance != null && BBJDPIJPLPA.itemInstance is BirdInstance)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		CMNFMBECBGE.OKJPBLHCHCO(base.JIIGOACEIKL, BBJDPIJPLPA);
	}

	public void FCACMDNLAIG(bool MDIKPGGBNLI, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (MDIKPGGBNLI)
		{
			if (DNLMCHDOMOK != null && DNLMCHDOMOK is BirdInstance)
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				KCCCICMGHID = true;
				AIADOMPNHBD = false;
			}
			else
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(!MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				KCCCICMGHID = true;
				AIADOMPNHBD = true;
			}
			FLHEDNDENNP = 1;
			itemTooltip.contentRectTransform.anchoredPosition = Vector2.one * 1795f;
			birdTooltip.contentRectTransform.anchoredPosition = Vector2.one * 1931f;
		}
		else
		{
			if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)birdTooltip.contentRectTransform).gameObject.SetActive(true);
			}
			if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)itemTooltip.contentRectTransform).gameObject.SetActive(true);
			}
			BJHFNFAIPLL = null;
			KCCCICMGHID = true;
			AIADOMPNHBD = false;
		}
	}

	private void OAACLGCCGGI()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 1)
		{
			DNPOMFHCLFJ();
		}
	}

	public static ItemTooltip MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ItemTooltip Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void SetVisible(bool MDIKPGGBNLI, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (MDIKPGGBNLI)
		{
			if (DNLMCHDOMOK != null && DNLMCHDOMOK is BirdInstance)
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(!MDIKPGGBNLI);
				}
				KCCCICMGHID = false;
				AIADOMPNHBD = true;
			}
			else
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(!MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				KCCCICMGHID = true;
				AIADOMPNHBD = false;
			}
			FLHEDNDENNP = 2;
			itemTooltip.contentRectTransform.anchoredPosition = Vector2.one * -10000f;
			birdTooltip.contentRectTransform.anchoredPosition = Vector2.one * -10000f;
		}
		else
		{
			if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)birdTooltip.contentRectTransform).gameObject.SetActive(false);
			}
			if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)itemTooltip.contentRectTransform).gameObject.SetActive(false);
			}
			BJHFNFAIPLL = null;
			KCCCICMGHID = false;
			AIADOMPNHBD = false;
		}
	}

	private void NPHKFBIEMDO()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 0)
		{
			SetTooltipPosition(JFFBLKGIGIG: true);
		}
	}

	public void SetTooltipPosition(bool JFFBLKGIGIG = false)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (JFFBLKGIGIG)
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(base.JIIGOACEIKL).WorldToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
			else
			{
				GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Vector2.op_Implicit(AIAEDNIBGGL)));
			}
		}
		else
		{
			GOOKKKGIGBL = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetScreenCamera().ScreenToViewportPoint(Input.mousePosition));
		}
		PJDMDNGEBKM = new Vector2(GOOKKKGIGBL.x * canvas.sizeDelta.x, GOOKKKGIGBL.y * canvas.sizeDelta.y);
		PGBEEGPOINO = Vector2.zero;
		if (AIADOMPNHBD)
		{
			CMNFMBECBGE = birdTooltip;
		}
		else
		{
			CMNFMBECBGE = itemTooltip;
		}
		EPIGABHAJCJ = CMNFMBECBGE.contentRectTransform.sizeDelta;
		EPIGABHAJCJ.x *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.x;
		EPIGABHAJCJ.y *= ((Transform)CMNFMBECBGE.contentRectTransform).lossyScale.y;
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
		CMNFMBECBGE.contentRectTransform.anchoredPosition = PGBEEGPOINO + PJDMDNGEBKM;
	}

	private void PDCGDFPMLIC()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 124f - KHNHFJMJCNA;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	private void CCBADNIHIIG()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 629f - KHNHFJMJCNA;
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	private void ECJFMIKNAKG()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 0)
		{
			SetTooltipPosition(JFFBLKGIGIG: true);
		}
	}

	public static ItemTooltip LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void AECCMKBENLO(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		AIAEDNIBGGL = IMOBLFMHKOD;
		this.MBNPNOJAJCB = MBNPNOJAJCB;
	}

	private void HHJBMFOOHHO()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 158f + BIBJJKLPODO;
	}

	public void SetItemInstance(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool CCAICMBJAGH, bool EDFANMFDDEJ, bool PKBJMLACEMM)
	{
		if (HPHELAPHAHN != null && (BJHFNFAIPLL == null || BJHFNFAIPLL != HPHELAPHAHN))
		{
			base.JIIGOACEIKL = JIIGOACEIKL;
			BJHFNFAIPLL = HPHELAPHAHN;
			FillTooltipInfo(HPHELAPHAHN.MLCIDCBCMOA(JIIGOACEIKL, CCAICMBJAGH, EDFANMFDDEJ, PKBJMLACEMM));
		}
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

	public static ItemTooltip NIGDBMAOAEN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ILGFPFBJMPG(bool MDIKPGGBNLI, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (MDIKPGGBNLI)
		{
			if (DNLMCHDOMOK != null && DNLMCHDOMOK is BirdInstance)
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(!MDIKPGGBNLI);
				}
				KCCCICMGHID = false;
				AIADOMPNHBD = true;
			}
			else
			{
				if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf == MDIKPGGBNLI)
				{
					((Component)birdTooltip.contentRectTransform).gameObject.SetActive(!MDIKPGGBNLI);
				}
				if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf != MDIKPGGBNLI)
				{
					((Component)itemTooltip.contentRectTransform).gameObject.SetActive(MDIKPGGBNLI);
				}
				KCCCICMGHID = false;
				AIADOMPNHBD = false;
			}
			FLHEDNDENNP = 3;
			itemTooltip.contentRectTransform.anchoredPosition = Vector2.one * 772f;
			birdTooltip.contentRectTransform.anchoredPosition = Vector2.one * 714f;
		}
		else
		{
			if (((Component)birdTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)birdTooltip.contentRectTransform).gameObject.SetActive(false);
			}
			if (((Component)itemTooltip.contentRectTransform).gameObject.activeSelf)
			{
				((Component)itemTooltip.contentRectTransform).gameObject.SetActive(true);
			}
			BJHFNFAIPLL = null;
			KCCCICMGHID = false;
			AIADOMPNHBD = true;
		}
	}

	private void OIANJNAKLLC()
	{
		PGBEEGPOINO.x = EPIGABHAJCJ.x / 895f + BIBJJKLPODO;
	}

	private void BHLAGCODJGJ()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 0)
		{
			MDEILHDDGNL(JFFBLKGIGIG: true);
		}
	}

	private void LateUpdate()
	{
		if ((KCCCICMGHID || AIADOMPNHBD) && FLHEDNDENNP <= 0)
		{
			SetTooltipPosition();
		}
	}

	public void ICMGLBFHDJD(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JGGMEGPELNC(IMOBLFMHKOD, MBNPNOJAJCB);
		MDEILHDDGNL(JFFBLKGIGIG: true);
		FCACMDNLAIG(MDIKPGGBNLI: true, DNLMCHDOMOK);
	}

	private void EPKCPMHIDLJ()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1141f - KHNHFJMJCNA;
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	public static ItemTooltip IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void HFLONKELKOI()
	{
		PGBEEGPOINO.x = 0f - EPIGABHAJCJ.x / 1824f - KHNHFJMJCNA;
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			PGBEEGPOINO.x -= MBNPNOJAJCB.x;
			PGBEEGPOINO.y = MBNPNOJAJCB.y;
		}
	}

	public void FJOEGNKBHON(Vector2 IMOBLFMHKOD, Vector2 MBNPNOJAJCB, ItemInstance DNLMCHDOMOK = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		LEHBBMJLAIM(IMOBLFMHKOD, MBNPNOJAJCB);
		DNPOMFHCLFJ(JFFBLKGIGIG: true);
		FCACMDNLAIG(MDIKPGGBNLI: false, DNLMCHDOMOK);
	}
}
