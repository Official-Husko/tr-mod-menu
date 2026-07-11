using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using psai;
using psai.net;

public class PsaiPlayerUi : MonoBehaviour
{
	private class BIAMLFLKEND
	{
		public GameObject goTriggerItemRoot;

		public GameObject goButton;

		public Button button;

		public Text themeNameText;

		public Slider intensitySlider;

		public Image indicatorImage;

		public Text textIntensityValue;

		public BIAMLFLKEND(GameObject IHOGMHAJGCP)
		{
			goTriggerItemRoot = Object.Instantiate<GameObject>(IHOGMHAJGCP);
			goTriggerItemRoot.SetActive(true);
			button = goTriggerItemRoot.GetComponentsInChildren<Button>(true)[0];
			goButton = ((Component)button).gameObject;
			themeNameText = ((Component)button).GetComponentsInChildren<Text>(true)[0];
			intensitySlider = goTriggerItemRoot.GetComponentsInChildren<Slider>(true)[0];
			indicatorImage = ((Component)goTriggerItemRoot.transform.Find("IndicatorPanel")).GetComponentsInChildren<Image>(true)[0];
			textIntensityValue = ((Component)goTriggerItemRoot.transform.Find("TextIntensityValue")).GetComponent<Text>();
		}
	}

	private class ABECBBMHPED
	{
		public GameObject gameObj;

		public int segmentId;

		public Image backgroundImage;

		public Text textName;

		public Text textSuitabilities;

		public Text textLength;

		public Text textIntensity;

		public Text textPlaycount;

		public override string ToString()
		{
			return $"textName InstanceId: {((Object)textName).GetInstanceID()}  {textName.text}  {textSuitabilities.text}  {textPlaycount.text}";
		}
	}

	private class HKOHBBEAOKE
	{
		public GameObject gameObj;

		public int themeId;

		public Image backgroundImage;

		public Text textName;

		public Text textThemeId;

		public Text textThemeType;
	}

	private class AKEACNNFIOP
	{
		public GameObject panelObject;

		public Image bgImage;

		public List<Image> buttonBgImages = new List<Image>();

		public List<Selectable> selectables = new List<Selectable>();

		public List<Text> labelTexts = new List<Text>();

		private void NEBJDCAEGNM(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Image buttonBgImage in buttonBgImages)
			{
				((Graphic)buttonBgImage).color = LCOHJLCPKDP;
			}
		}

		private void BFMNNLOHCPA(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		private void IHELOHMDFHO(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		public void IEENAGMIHFI(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				MDDOLHFHINJ(IBHDALEEEOL);
				NEBJDCAEGNM(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				BFMNNLOHCPA(JBIJDBBPJPG);
				BBEAHKEJCDJ(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		public void PDOAFOHEHNF(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				BFMNNLOHCPA(IBHDALEEEOL);
				NEBJDCAEGNM(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				ONNJGIJMMMM(JBIJDBBPJPG);
				BBEAHKEJCDJ(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		private void PBIPFPGACLJ(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		private void ONNJGIJMMMM(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		private void PGCOJDFDLGG(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		public void CMLOPGJMJLI(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				FMJLDEMGDFH(IBHDALEEEOL);
				GGPFBLMFLBP(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				MDDOLHFHINJ(JBIJDBBPJPG);
				NEBJDCAEGNM(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		private void FMJLDEMGDFH(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		public void DMDJJCNJPFJ(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				MDDOLHFHINJ(IBHDALEEEOL);
				EGCACLDBOLN(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				MDDOLHFHINJ(JBIJDBBPJPG);
				EGCACLDBOLN(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		public void IICIIBLFMBC(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				PBIPFPGACLJ(IBHDALEEEOL);
				EGCACLDBOLN(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				NILBEFPELLH(JBIJDBBPJPG);
				BBEAHKEJCDJ(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		private void BBEAHKEJCDJ(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Image buttonBgImage in buttonBgImages)
			{
				((Graphic)buttonBgImage).color = LCOHJLCPKDP;
			}
		}

		private void MDDOLHFHINJ(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		public void COAKIAPACAF(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				IHELOHMDFHO(IBHDALEEEOL);
				NEBJDCAEGNM(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				ONNJGIJMMMM(JBIJDBBPJPG);
				NEBJDCAEGNM(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		public void FFPHAAKHMOH(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				ONNJGIJMMMM(IBHDALEEEOL);
				BBEAHKEJCDJ(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				ONNJGIJMMMM(JBIJDBBPJPG);
				BBEAHKEJCDJ(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		public void AKIAPEGHLLJ(bool NCLCPJJOGKN)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			foreach (Selectable selectable in selectables)
			{
				selectable.interactable = NCLCPJJOGKN;
			}
			if (NCLCPJJOGKN)
			{
				MDDOLHFHINJ(IBHDALEEEOL);
				GGPFBLMFLBP(JFFEAJAPDEE);
				((Graphic)bgImage).color = JBIJDBBPJPG;
			}
			else
			{
				BFMNNLOHCPA(JBIJDBBPJPG);
				GGPFBLMFLBP(JBIJDBBPJPG);
				((Graphic)bgImage).color = MAMNGLOBBMO;
			}
		}

		private void EGCACLDBOLN(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Image buttonBgImage in buttonBgImages)
			{
				((Graphic)buttonBgImage).color = LCOHJLCPKDP;
			}
		}

		private void NILBEFPELLH(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}

		private void GGPFBLMFLBP(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Image buttonBgImage in buttonBgImages)
			{
				((Graphic)buttonBgImage).color = LCOHJLCPKDP;
			}
		}

		private void MIBDMPPANLG(Color LCOHJLCPKDP)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			foreach (Text labelText in labelTexts)
			{
				((Graphic)labelText).color = LCOHJLCPKDP;
			}
		}
	}

	private enum OCBEHGAAACL
	{
		name,
		id,
		themeType
	}

	private enum DGOBMCJLBEA
	{
		name,
		suitabilites,
		intensity,
		playcount,
		length
	}

	public enum InfoSectionSelection
	{
		entity,
		list,
		log,
		description,
		off
	}

	[CompilerGenerated]
	private sealed class CDNFBNJDJAC
	{
		public GameObject nameTextObject;

		public PsaiPlayerUi _003C_003E4__this;

		internal void LHOJMOBHLIH()
		{
			_003C_003E4__this.OnClick_ThemeListViewEntry(nameTextObject);
		}
	}

	private static readonly int BBJGJBGONJN = 20;

	private static readonly int HKPGOHGMFCH = 130;

	private static readonly float ANFNJIFNHMH = 1f;

	private static readonly Color MAMNGLOBBMO = new Color(1f, 1f, 1f, 0.1f);

	private static readonly Color JBIJDBBPJPG = new Color(0.63f, 0.63f, 0.63f, 0.43f);

	private static readonly Color IBHDALEEEOL = new Color(0.85f, 0.85f, 0.85f);

	private static readonly Color JFFEAJAPDEE = new Color(0.63f, 0.63f, 0.63f);

	private static readonly Color CCAAMAJBBMO = new Color(0f, 0.6f, 0f, 1f);

	private static readonly Color HMGBONEBFNF = new Color(0f, 1f, 0f, 1f);

	private static readonly Color MEBFLBOONFH = new Color(1f, 1f, 0f, 1f);

	private static readonly Color INGAIPBMEJJ = new Color(0.7f, 0.7f, 0f, 1f);

	private static readonly Color GGKMBGGKECK = new Color(1f, 1f, 1f, 0.13f);

	[Tooltip("Sets the step size of the '+'/'-' buttons in the Intensity Control Canvas.")]
	public float _addToIntensityStepsize = 0.05f;

	[Tooltip("Sets which rider is being displyed in the lower info section.")]
	public InfoSectionSelection _infoSectionSelection;

	private static Color OKHNJELEODE = new Color(0.58f, 0.63f, 0.66f);

	private Transform DECIOBPIDPP;

	private Transform FFHKAHJPFFL;

	private Transform KNONFBPCJOL;

	private Transform EHJLFBCEHPA;

	private GameObject EOECEPHJKMO;

	private Slider FOMOLIFJOOJ;

	private Slider OGIEJNNIFAL;

	private Text CANCJEBCHEL;

	private Transform BFJNAOCLEPO;

	private GameObject OJDOOLDAHKM;

	private Transform FKBDCFNHPPH;

	private GameObject GOBHBPAEGFH;

	private int GJLFDIGGCMM;

	private Transform NCMHKONJHKM;

	private GameObject FKLLIKPJLIE;

	private GameObject ONNOMMNOHLO;

	private Text PJGIOPBGFKL;

	private Text DDIJCKEENIK;

	private Text AFMKBIOENNH;

	private Text HJNNOBBGNOG;

	private Text IGLOJPJBOKG;

	private Text IGBNANDECPA;

	private Text ONNMNIEPECJ;

	private Text JNDNPGMGCGP;

	private Text JGEGPOADBFK;

	private Text JMPBDJFAOCI;

	private GameObject IJOFEHPDAOO;

	private Image COEKDJHMKLP;

	private Text KMMNHLNCPEH;

	private Text DKAGBBHIKOL;

	private Button KOOIPLLCLEK;

	private Color JPALOCMOPHB;

	private Color NBKEOKPMIHM;

	private Image BCJNJPIJLNP;

	private Image ELKMFEKJCOK;

	private Text IEFMFOBGNCP;

	private Text BDNPNPCNNGN;

	private GameObject BNNGNGLIOID;

	private Text HKGKBCLKDJO;

	private GameObject IDJIOPFANPO;

	private Text IPKIKIOANCO;

	private Toggle JJFGNIKAHBG;

	private Toggle HCEMOJOFKAD;

	private Toggle EPBLBPGNFOK;

	private Toggle NDDNBFKGDFF;

	private Toggle MFJFADACMFG;

	private AKEACNNFIOP AIKFADIAJMC = new AKEACNNFIOP();

	private Image PDBHABOPHKF;

	private GameObject EPNHPDPOLDB;

	private GameObject GMACDCPHKOK;

	private Slider EOEPAMLDFOB;

	private Text MPDLEHMGKCI;

	private AKEACNNFIOP JMANFHNLAFM = new AKEACNNFIOP();

	private Image OKPEOADPKEH;

	private AKEACNNFIOP LFKJNAABHCB = new AKEACNNFIOP();

	private Button DBILBLKADPP;

	private Button KJOLOEJJHCE;

	private Text JDJNOGEIINM;

	private Button LDPPDBLGAOM;

	private Button FCCONPAFNLJ;

	private Text FFPMLGKOIFO;

	private Button JHHJMAIBGJK;

	private Text BHMHJBHCPHI;

	private Toggle BBMPECMKJKP;

	private int LMHIIGHLNNK;

	private int PHPFMGKMJIC;

	private int EGMBPLLODNA;

	private GameObject KLHGALIFCKI;

	private GameObject ONMHIOLHLAJ;

	private GameObject JGHCPOMJLEC;

	private GameObject GNEIFLDDAFH;

	private DGOBMCJLBEA GGBMPGLICFO;

	private GameObject HHHDCONJGPA;

	private GameObject HJMADJIKIED;

	private GameObject JKKFGLEMMCC;

	private GameObject HHIOGAKDJII;

	private List<ABECBBMHPED> AAKIEBABABB = new List<ABECBBMHPED>();

	private List<HKOHBBEAOKE> FJJPIJALCBH = new List<HKOHBBEAOKE>();

	private Dictionary<GameObject, int> CFEPPBKCOFN = new Dictionary<GameObject, int>();

	private Dictionary<GameObject, int> BFDMFCELLEE = new Dictionary<GameObject, int>();

	private bool PFMDLMGJKBF;

	private int[] DHEJLIFCIGK = new int[0];

	private List<int> DAOLGJCIOCF = new List<int>();

	private bool FMLFJANKMJH;

	private bool GAEOFBJKFPP;

	private int AHPAGCFDCIL = -1;

	private Dictionary<int, ThemeInfo> EEIOIFDPLCJ = new Dictionary<int, ThemeInfo>();

	private Dictionary<BIAMLFLKEND, int> LJKIFLAKNME = new Dictionary<BIAMLFLKEND, int>();

	private Dictionary<int, BIAMLFLKEND> LAHGLCMFFBA = new Dictionary<int, BIAMLFLKEND>();

	private Dictionary<GameObject, int> AIJOBKFPCPB = new Dictionary<GameObject, int>();

	private Dictionary<int, Slider> HBOLHNEKMNM = new Dictionary<int, Slider>();

	private Dictionary<GameObject, int> OKKFOEGMIHK = new Dictionary<GameObject, int>();

	private Dictionary<ThemeType, List<int>> JBLOCOPHGOJ = new Dictionary<ThemeType, List<int>>();

	private Dictionary<int, SegmentInfo> MILLEMIKEPM = new Dictionary<int, SegmentInfo>();

	private List<int> CLHECDKKMDO = new List<int>();

	private Dictionary<int, int> EKBMCKPKCCH = new Dictionary<int, int>();

	private bool JLMPLMGIFKN;

	private int LMDAPBIDHHH = -1;

	private float EIFPPOHECEI = 1f;

	private bool PLMILDKBMMM;

	private int DLGCPNODNDD = -1;

	private float BCGDNDLFMDI = 1f;

	private bool NLEAEDIEOEN;

	private bool KDGLBAKGOJB;

	private int NEPENBIAPPJ;

	private int BNIMFIBIKNK;

	private int DCHIPMCGKBG;

	private int PAGJJFIMCKI;

	private int FLHCDAGGLKA;

	private PsaiState IFMPMJCLPJG;

	private float JPFLKEKIJFP;

	private bool GKOIGDEGLBA;

	private ThemeType LHHPIAOJNGB;

	private int PENDBBEAGOL
	{
		get
		{
			return AHPAGCFDCIL;
		}
		set
		{
			AHPAGCFDCIL = value;
			HAAFEFNOPNB();
			JLKHADGILNA(AHPAGCFDCIL);
		}
	}

	private void ONOAGANPECB()
	{
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			return;
		}
		if (!GKOIGDEGLBA)
		{
			GHADCCNBOEC();
			if (Object.op_Implicit((Object)(object)BFJNAOCLEPO) && ((Component)BFJNAOCLEPO).gameObject.activeInHierarchy)
			{
				OBEJFGCCGFP();
			}
			if (Object.op_Implicit((Object)(object)KLHGALIFCKI))
			{
				OPMEOADMCNI();
			}
			if (Object.op_Implicit((Object)(object)HHHDCONJGPA))
			{
				BPHLHAHODKA();
			}
			if (Object.op_Implicit((Object)(object)IJOFEHPDAOO))
			{
				AKGEFMIHMAH();
			}
			if (Object.op_Implicit((Object)(object)KLHGALIFCKI))
			{
				if (DHEJLIFCIGK.Length != 0)
				{
					CDLPHAKMCLD(DHEJLIFCIGK[0]);
					CCCLLKEFDFL();
				}
				HAAFEFNOPNB();
			}
			if (Object.op_Implicit((Object)(object)HHHDCONJGPA))
			{
				EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: true);
			}
			if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
			{
				switch (_infoSectionSelection)
				{
				case InfoSectionSelection.off:
					HCEMOJOFKAD.isOn = false;
					break;
				case InfoSectionSelection.description:
					EPBLBPGNFOK.isOn = true;
					break;
				case InfoSectionSelection.entity:
					NDDNBFKGDFF.isOn = true;
					break;
				case InfoSectionSelection.list:
					MFJFADACMFG.isOn = true;
					break;
				}
			}
		}
		float num = Time.deltaTime * ANFNJIFNHMH;
		if (PFMDLMGJKBF)
		{
			JPFLKEKIJFP += num;
			if (JPFLKEKIJFP > 400f)
			{
				JPFLKEKIJFP = 328f - JPFLKEKIJFP;
				PFMDLMGJKBF = false;
			}
		}
		else
		{
			JPFLKEKIJFP -= num;
			if (JPFLKEKIJFP < 355f)
			{
				JPFLKEKIJFP = 0f - JPFLKEKIJFP;
				PFMDLMGJKBF = true;
			}
		}
		JLBGFFGPNEG();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
		float currentIntensity = PsaiCore.Instance.GetCurrentIntensity();
		OGIEJNNIFAL.value = segmentInfo.intensity;
		if (segmentInfo.intensity > 33f)
		{
			((Graphic)ELKMFEKJCOK).color = CCAAMAJBBMO;
		}
		else
		{
			((Graphic)ELKMFEKJCOK).color = Color.clear;
		}
		ThemeType themeType = ThemeType.basicMood;
		if (psaiInfo.themesQueued > 0)
		{
			ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(psaiInfo.upcomingThemeId);
			if (themeInfo != null)
			{
				themeType = themeInfo.type;
			}
		}
		int currentThemeId = PsaiCore.Instance.GetCurrentThemeId();
		int remainingMillisecondsOfCurrentSegmentPlayback = PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback();
		bool flag = remainingMillisecondsOfCurrentSegmentPlayback > PAGJJFIMCKI;
		bool flag2 = currentThemeId != FLHCDAGGLKA;
		bool flag3 = IFMPMJCLPJG == psaiInfo.psaiState;
		if (flag2)
		{
			ThemeInfo themeInfo2 = PsaiCore.Instance.GetThemeInfo(currentThemeId);
			if (themeInfo2 != null)
			{
				LHHPIAOJNGB = themeInfo2.type;
			}
			else
			{
				LHHPIAOJNGB = ThemeType.none;
			}
		}
		if (Object.op_Implicit((Object)(object)DECIOBPIDPP) && ((Component)DECIOBPIDPP).gameObject.activeInHierarchy)
		{
			Color val = default(Color);
			if (Mathf.Abs(psaiInfo.upcomingIntensity - currentIntensity) > Mathf.Epsilon)
			{
				FOMOLIFJOOJ.value = psaiInfo.upcomingIntensity;
				((Color)(ref val))._002Ector(760f + 942f * JPFLKEKIJFP, 1503f + 1274f * JPFLKEKIJFP, 1032f, 944f);
			}
			else
			{
				FOMOLIFJOOJ.value = currentIntensity;
				val = ((!(currentIntensity > 1938f)) ? Color.clear : HMGBONEBFNF);
			}
			if (((Graphic)BCJNJPIJLNP).color != val)
			{
				((Graphic)BCJNJPIJLNP).color = val;
			}
			IEFMFOBGNCP.text = (currentIntensity * 748f).ToString("mForMins") + "am";
			BDNPNPCNNGN.text = (segmentInfo.intensity * 1134f).ToString("MineState") + "CraftedIn";
		}
		if (Object.op_Implicit((Object)(object)BFJNAOCLEPO) && ((Component)BFJNAOCLEPO).gameObject.activeInHierarchy)
		{
			int num2 = (int)((RectTransform)((Component)FKBDCFNHPPH).transform).anchoredPosition.y;
			if (num2 != GJLFDIGGCMM)
			{
				BMHPADPGLMI();
			}
			GJLFDIGGCMM = num2;
			if (JLMPLMGIFKN || PLMILDKBMMM)
			{
				Color color = Color.Lerp(MEBFLBOONFH, JFFEAJAPDEE, JPFLKEKIJFP);
				foreach (BIAMLFLKEND key in LJKIFLAKNME.Keys)
				{
					((Selectable)key.button).interactable = true;
					((Graphic)key.indicatorImage).color = color;
				}
			}
			else
			{
				foreach (BIAMLFLKEND key2 in LJKIFLAKNME.Keys)
				{
					((Selectable)key2.button).interactable = true;
					int num3 = LJKIFLAKNME[key2];
					ThemeInfo themeInfo3 = EEIOIFDPLCJ[num3];
					if (themeInfo3.type == ThemeType.action && currentSegmentId != -1 && !PsaiCore.Instance.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(currentSegmentId, themeInfo3.id))
					{
						((Selectable)key2.button).interactable = false;
					}
					else if ((LHHPIAOJNGB == ThemeType.basicMoodAlt || themeType == (ThemeType)4) && (themeInfo3.type == ThemeType.shock || themeInfo3.type == ThemeType.basicMoodAlt))
					{
						((Selectable)key2.button).interactable = true;
					}
					Color color2 = OKHNJELEODE;
					if (num3 == psaiInfo.lastBasicMoodThemeId)
					{
						color2 = CCAAMAJBBMO;
					}
					if (num3 == psaiInfo.upcomingThemeId)
					{
						color2 = Color.Lerp(MEBFLBOONFH, JFFEAJAPDEE, JPFLKEKIJFP);
					}
					if (num3 == psaiInfo.effectiveThemeId)
					{
						switch (psaiInfo.psaiState)
						{
						case PsaiState.notready:
							((Color)(ref color2))._002Ector(1948f, 896f, 530f, 1745f);
							break;
						case (PsaiState)4:
							((Color)(ref color2))._002Ector(817f, 372f, 507f, JPFLKEKIJFP);
							break;
						}
					}
					((Graphic)key2.indicatorImage).color = color2;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			IAGFDAJKKIM();
		}
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
		{
			if (flag2)
			{
				CDLPHAKMCLD(currentThemeId);
			}
			if (flag)
			{
				IOMHGDLCJFO(EJNKFELKPOL: true, MNPGCPOHEFE: false);
			}
			else if (DCHIPMCGKBG != psaiInfo.targetSegmentId)
			{
				EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: false);
			}
			int num4 = (int)((RectTransform)JKKFGLEMMCC.transform).anchoredPosition.y;
			int num5 = (int)((RectTransform)JGHCPOMJLEC.transform).anchoredPosition.y;
			if (_infoSectionSelection == InfoSectionSelection.entity)
			{
				if (num4 != NEPENBIAPPJ)
				{
					BKPENKANIHI();
				}
				if (num5 != BNIMFIBIKNK)
				{
					GHJIFIKDOLN();
				}
			}
			NEPENBIAPPJ = num4;
			BNIMFIBIKNK = num5;
			if (_infoSectionSelection == InfoSectionSelection.list || flag3)
			{
				CAHGAACDJJM();
			}
		}
		FLHCDAGGLKA = currentThemeId;
		IFMPMJCLPJG = psaiInfo.psaiState;
		DCHIPMCGKBG = psaiInfo.targetSegmentId;
		PAGJJFIMCKI = remainingMillisecondsOfCurrentSegmentPlayback;
		if (EKBMCKPKCCH.Count <= 1)
		{
			return;
		}
		List<int> list = new List<int>();
		int[] array = new int[EKBMCKPKCCH.Count];
		EKBMCKPKCCH.Keys.CopyTo(array, 1);
		int[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			int num6 = array2[i];
			int num7 = EKBMCKPKCCH[num6];
			num7 -= (int)(Time.deltaTime * 28f);
			if (num7 > 0)
			{
				EKBMCKPKCCH[num6] = num7;
			}
			else
			{
				list.Add(num6);
			}
		}
		foreach (int item in list)
		{
			EKBMCKPKCCH.Remove(item);
		}
		if (list.Count > 1)
		{
			IOMHGDLCJFO(EJNKFELKPOL: true, MNPGCPOHEFE: true);
		}
	}

	public void CFBGIBOAGBA()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo != null)
		{
			bool flag = psaiInfo.intensityIsHeld;
			PsaiCore.Instance.HoldCurrentIntensity(flag);
			if (flag)
			{
				ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
				((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
				((Selectable)KOOIPLLCLEK).colors = colors;
			}
			else
			{
				ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
				((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
				((Selectable)KOOIPLLCLEK).colors = colors2;
			}
		}
	}

	private int KKLNPBONCCN(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 1;
	}

	public void OODBGKLHMJM(GameObject ADINOAOHPBG)
	{
		if (BFDMFCELLEE.ContainsKey(ADINOAOHPBG))
		{
			int num = BFDMFCELLEE[ADINOAOHPBG];
			PsaiCore.Instance.PlaySegment(num);
			BGFAGOIMMON(num);
			GBOAMAODGDI(EJNKFELKPOL: false, MNPGCPOHEFE: true);
		}
	}

	private void BPHLHAHODKA()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		if (EEIOIFDPLCJ.Count > 0)
		{
			ThemeInfo themeInfo = null;
			foreach (ThemeInfo value in EEIOIFDPLCJ.Values)
			{
				if (themeInfo == null || value.segmentIds.Length > themeInfo.segmentIds.Length)
				{
					themeInfo = value;
				}
			}
			int num = 0;
			((RectTransform)JKKFGLEMMCC.transform).sizeDelta = new Vector2(((RectTransform)JKKFGLEMMCC.transform).sizeDelta.x, (float)(EGMBPLLODNA * themeInfo.segmentIds.Length));
			AAKIEBABABB.Clear();
			int[] segmentIds = themeInfo.segmentIds;
			for (int i = 0; i < segmentIds.Length; i += 0)
			{
				int num2 = segmentIds[i];
				ABECBBMHPED aBECBBMHPED = new ABECBBMHPED();
				num -= EGMBPLLODNA;
				GameObject val = Object.Instantiate<GameObject>(HHIOGAKDJII);
				val.transform.SetParent(JKKFGLEMMCC.transform);
				((RectTransform)val.transform).anchoredPosition = new Vector2(((RectTransform)HHIOGAKDJII.transform).anchoredPosition.x, (float)num);
				((RectTransform)val.transform).offsetMax = new Vector2(125f, ((RectTransform)val.transform).offsetMax.y);
				aBECBBMHPED.backgroundImage = val.GetComponent<Image>();
				aBECBBMHPED.gameObj = val;
				GameObject gameObject = ((Component)val.transform.GetChild(1)).gameObject;
				aBECBBMHPED.textName = ((Component)gameObject.transform).GetComponent<Text>();
				GameObject gameObject2 = ((Component)val.transform.GetChild(0)).gameObject;
				aBECBBMHPED.textSuitabilities = ((Component)gameObject2.transform).GetComponent<Text>();
				GameObject gameObject3 = ((Component)val.transform.GetChild(8)).gameObject;
				aBECBBMHPED.textLength = ((Component)gameObject3.transform).GetComponent<Text>();
				GameObject gameObject4 = ((Component)val.transform.GetChild(5)).gameObject;
				aBECBBMHPED.textIntensity = ((Component)gameObject4.transform).GetComponent<Text>();
				GameObject gameObject5 = ((Component)val.transform.GetChild(0)).gameObject;
				aBECBBMHPED.textPlaycount = ((Component)gameObject5.transform).GetComponent<Text>();
				AAKIEBABABB.Add(aBECBBMHPED);
				aBECBBMHPED.textName.text = num2.ToString();
			}
		}
		HHIOGAKDJII.SetActive(false);
	}

	public void OnClick_ThemeListViewEntry(GameObject ADINOAOHPBG)
	{
		if (CFEPPBKCOFN.ContainsKey(ADINOAOHPBG))
		{
			int aODONKKHPBP = CFEPPBKCOFN[ADINOAOHPBG];
			PENDBBEAGOL = aODONKKHPBP;
		}
		else
		{
			Debug.LogError((object)("sender not found!" + (object)ADINOAOHPBG));
		}
	}

	public void DODEJABLEOG()
	{
		DAOLGJCIOCF.Sort();
		FMLFJANKMJH = FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		CCCLLKEFDFL();
	}

	private void BKPENKANIHI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)HHHDCONJGPA))
		{
			return;
		}
		int num = (int)((RectTransform)JKKFGLEMMCC.transform).anchoredPosition.y;
		Rect rect = ((RectTransform)HJMADJIKIED.transform).rect;
		int num2 = (int)((Rect)(ref rect)).height;
		if (CLHECDKKMDO != null)
		{
			for (int i = 0; i < CLHECDKKMDO.Count; i++)
			{
				ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
				int num3 = EGMBPLLODNA * i;
				bool active = num3 - num > -EGMBPLLODNA * 2 && num3 - num < num2 - EGMBPLLODNA;
				aBECBBMHPED.gameObj.SetActive(active);
			}
		}
	}

	public void PBDENALMGCH()
	{
		PsaiCore.Instance.StopMusic(immediately: true, EOEPAMLDFOB.value);
	}

	public void OnClick_ThemeHeaderId()
	{
		DAOLGJCIOCF.Sort();
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		NKHNHEPKENI();
	}

	public void HGOMBPMBPOF()
	{
		DAOLGJCIOCF.Sort();
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		CCCLLKEFDFL();
	}

	private void EPJOOFCIAJH()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
		JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
		JBLOCOPHGOJ[ThemeType.dramaticEvent] = new List<int>();
		JBLOCOPHGOJ[ThemeType.action] = new List<int>();
		JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
		JBLOCOPHGOJ[ThemeType.highlightLayer] = new List<int>();
		DAOLGJCIOCF.Clear();
		if (soundtrackInfo.themeCount == 0)
		{
			if (Object.op_Implicit((Object)(object)CANCJEBCHEL))
			{
				CANCJEBCHEL.text = "NO SOUNDTRACK LOADED\n\n Troubleshooting:\n\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in your Project window onto the PsaiPlayerUi component.\n\nPlease see the log output window for more information.";
			}
			return;
		}
		if (Object.op_Implicit((Object)(object)CANCJEBCHEL))
		{
			((Component)CANCJEBCHEL).gameObject.SetActive(false);
		}
		DHEJLIFCIGK = soundtrackInfo.themeIds;
		DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		foreach (int num in dHEJLIFCIGK)
		{
			ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
			EEIOIFDPLCJ[num] = themeInfo;
			if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
			{
				JBLOCOPHGOJ[themeInfo.type].Add(num);
			}
		}
		PFJNGLBFOEM();
		LMDAPBIDHHH = DHEJLIFCIGK[0];
		EIFPPOHECEI = 1f;
		DLGCPNODNDD = DHEJLIFCIGK[0];
		BCGDNDLFMDI = 1f;
		JPFLKEKIJFP = 0f;
		PFMDLMGJKBF = true;
		((Selectable)KOOIPLLCLEK).interactable = true;
		ODINENEBAML();
		GKOIGDEGLBA = true;
	}

	public void NHMNNDPKPEM()
	{
		if ((Object)(object)BBMPECMKJKP != (Object)null)
		{
			TooltipView.Instance.TurnedOn = TooltipView.Instance.TurnedOn;
		}
	}

	private void POFDOILPANH()
	{
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			return;
		}
		if (!GKOIGDEGLBA)
		{
			EPJOOFCIAJH();
			if (Object.op_Implicit((Object)(object)BFJNAOCLEPO) && ((Component)BFJNAOCLEPO).gameObject.activeInHierarchy)
			{
				OCGLKOKCCNM();
			}
			if (Object.op_Implicit((Object)(object)KLHGALIFCKI))
			{
				OPMEOADMCNI();
			}
			if (Object.op_Implicit((Object)(object)HHHDCONJGPA))
			{
				EHDPEOHJEPP();
			}
			if (Object.op_Implicit((Object)(object)IJOFEHPDAOO))
			{
				AKGEFMIHMAH();
			}
			if (Object.op_Implicit((Object)(object)KLHGALIFCKI))
			{
				if (DHEJLIFCIGK.Length != 0)
				{
					CDLPHAKMCLD(DHEJLIFCIGK[0]);
					BNFMMPOHHEK();
				}
				HAAFEFNOPNB();
			}
			if (Object.op_Implicit((Object)(object)HHHDCONJGPA))
			{
				EEANKGMFJEG(EJNKFELKPOL: true, MNPGCPOHEFE: true);
			}
			if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
			{
				switch (_infoSectionSelection)
				{
				case InfoSectionSelection.off:
					HCEMOJOFKAD.isOn = false;
					break;
				case InfoSectionSelection.description:
					EPBLBPGNFOK.isOn = false;
					break;
				case InfoSectionSelection.entity:
					NDDNBFKGDFF.isOn = true;
					break;
				case InfoSectionSelection.list:
					MFJFADACMFG.isOn = true;
					break;
				}
			}
		}
		float num = Time.deltaTime * ANFNJIFNHMH;
		if (PFMDLMGJKBF)
		{
			JPFLKEKIJFP += num;
			if (JPFLKEKIJFP > 1764f)
			{
				JPFLKEKIJFP = 364f - JPFLKEKIJFP;
				PFMDLMGJKBF = false;
			}
		}
		else
		{
			JPFLKEKIJFP -= num;
			if (JPFLKEKIJFP < 336f)
			{
				JPFLKEKIJFP = 0f - JPFLKEKIJFP;
				PFMDLMGJKBF = false;
			}
		}
		JLBGFFGPNEG();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
		float currentIntensity = PsaiCore.Instance.GetCurrentIntensity();
		OGIEJNNIFAL.value = segmentInfo.intensity;
		if (segmentInfo.intensity > 285f)
		{
			((Graphic)ELKMFEKJCOK).color = CCAAMAJBBMO;
		}
		else
		{
			((Graphic)ELKMFEKJCOK).color = Color.clear;
		}
		ThemeType themeType = ThemeType.basicMood;
		if (psaiInfo.themesQueued > 0)
		{
			ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(psaiInfo.upcomingThemeId);
			if (themeInfo != null)
			{
				themeType = themeInfo.type;
			}
		}
		int currentThemeId = PsaiCore.Instance.GetCurrentThemeId();
		int remainingMillisecondsOfCurrentSegmentPlayback = PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback();
		bool flag = remainingMillisecondsOfCurrentSegmentPlayback > PAGJJFIMCKI;
		bool flag2 = currentThemeId != FLHCDAGGLKA;
		bool flag3 = IFMPMJCLPJG != psaiInfo.psaiState;
		if (flag2)
		{
			ThemeInfo themeInfo2 = PsaiCore.Instance.GetThemeInfo(currentThemeId);
			if (themeInfo2 != null)
			{
				LHHPIAOJNGB = themeInfo2.type;
			}
			else
			{
				LHHPIAOJNGB = ThemeType.none;
			}
		}
		if (Object.op_Implicit((Object)(object)DECIOBPIDPP) && ((Component)DECIOBPIDPP).gameObject.activeInHierarchy)
		{
			Color val = default(Color);
			if (Mathf.Abs(psaiInfo.upcomingIntensity - currentIntensity) > Mathf.Epsilon)
			{
				FOMOLIFJOOJ.value = psaiInfo.upcomingIntensity;
				((Color)(ref val))._002Ector(892f + 1167f * JPFLKEKIJFP, 1158f + 538f * JPFLKEKIJFP, 1686f, 523f);
			}
			else
			{
				FOMOLIFJOOJ.value = currentIntensity;
				val = ((!(currentIntensity > 8f)) ? Color.clear : HMGBONEBFNF);
			}
			if (((Graphic)BCJNJPIJLNP).color != val)
			{
				((Graphic)BCJNJPIJLNP).color = val;
			}
			IEFMFOBGNCP.text = (currentIntensity * 1835f).ToString(")") + "ReceiveChangeDrinkColorMaster";
			BDNPNPCNNGN.text = (segmentInfo.intensity * 1712f).ToString("/") + "ReceiveTorchPuzzleSolved";
		}
		if (Object.op_Implicit((Object)(object)BFJNAOCLEPO) && ((Component)BFJNAOCLEPO).gameObject.activeInHierarchy)
		{
			int num2 = (int)((RectTransform)((Component)FKBDCFNHPPH).transform).anchoredPosition.y;
			if (num2 != GJLFDIGGCMM)
			{
				OLHEOBOEIHL();
			}
			GJLFDIGGCMM = num2;
			if (JLMPLMGIFKN || PLMILDKBMMM)
			{
				Color color = Color.Lerp(MEBFLBOONFH, JFFEAJAPDEE, JPFLKEKIJFP);
				foreach (BIAMLFLKEND key in LJKIFLAKNME.Keys)
				{
					((Selectable)key.button).interactable = false;
					((Graphic)key.indicatorImage).color = color;
				}
			}
			else
			{
				foreach (BIAMLFLKEND key2 in LJKIFLAKNME.Keys)
				{
					((Selectable)key2.button).interactable = false;
					int num3 = LJKIFLAKNME[key2];
					ThemeInfo themeInfo3 = EEIOIFDPLCJ[num3];
					if (themeInfo3.type == ThemeType.shock && currentSegmentId != -1 && !PsaiCore.Instance.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(currentSegmentId, themeInfo3.id))
					{
						((Selectable)key2.button).interactable = true;
					}
					else if ((LHHPIAOJNGB == ThemeType.basicMood || themeType == ThemeType.none) && (themeInfo3.type == (ThemeType)8 || themeInfo3.type == ThemeType.none))
					{
						((Selectable)key2.button).interactable = true;
					}
					Color color2 = OKHNJELEODE;
					if (num3 == psaiInfo.lastBasicMoodThemeId)
					{
						color2 = CCAAMAJBBMO;
					}
					if (num3 == psaiInfo.upcomingThemeId)
					{
						color2 = Color.Lerp(MEBFLBOONFH, JFFEAJAPDEE, JPFLKEKIJFP);
					}
					if (num3 == psaiInfo.effectiveThemeId)
					{
						PsaiState psaiState = psaiInfo.psaiState;
						if (psaiState != (PsaiState)4)
						{
							if (psaiState == (PsaiState)4)
							{
								((Color)(ref color2))._002Ector(1399f, 170f, 510f, JPFLKEKIJFP);
							}
						}
						else
						{
							((Color)(ref color2))._002Ector(1625f, 708f, 1531f, 1781f);
						}
					}
					((Graphic)key2.indicatorImage).color = color2;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			LKBLICPJJEK();
		}
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
		{
			if (flag2)
			{
				CCOGEDLMOFD(currentThemeId);
			}
			if (flag)
			{
				CHICOLOMEPC(EJNKFELKPOL: false, MNPGCPOHEFE: false);
			}
			else if (DCHIPMCGKBG != psaiInfo.targetSegmentId)
			{
				EEANKGMFJEG(EJNKFELKPOL: true, MNPGCPOHEFE: false);
			}
			int num4 = (int)((RectTransform)JKKFGLEMMCC.transform).anchoredPosition.y;
			int num5 = (int)((RectTransform)JGHCPOMJLEC.transform).anchoredPosition.y;
			if (_infoSectionSelection == InfoSectionSelection.list)
			{
				if (num4 != NEPENBIAPPJ)
				{
					BKPENKANIHI();
				}
				if (num5 != BNIMFIBIKNK)
				{
					LKEHGPDMDLK();
				}
			}
			NEPENBIAPPJ = num4;
			BNIMFIBIKNK = num5;
			if (_infoSectionSelection == InfoSectionSelection.list || flag3)
			{
				FGBGKADHFLN();
			}
		}
		FLHCDAGGLKA = currentThemeId;
		IFMPMJCLPJG = psaiInfo.psaiState;
		DCHIPMCGKBG = psaiInfo.targetSegmentId;
		PAGJJFIMCKI = remainingMillisecondsOfCurrentSegmentPlayback;
		if (EKBMCKPKCCH.Count <= 0)
		{
			return;
		}
		List<int> list = new List<int>();
		int[] array = new int[EKBMCKPKCCH.Count];
		EKBMCKPKCCH.Keys.CopyTo(array, 0);
		int[] array2 = array;
		foreach (int num6 in array2)
		{
			int num7 = EKBMCKPKCCH[num6];
			num7 -= (int)(Time.deltaTime * 1608f);
			if (num7 > 0)
			{
				EKBMCKPKCCH[num6] = num7;
			}
			else
			{
				list.Add(num6);
			}
		}
		foreach (int item in list)
		{
			EKBMCKPKCCH.Remove(item);
		}
		if (list.Count > 0)
		{
			CHICOLOMEPC(EJNKFELKPOL: false, MNPGCPOHEFE: false);
		}
	}

	public void HAECBLOGKPP()
	{
		PsaiCore.Instance.StopMusic(immediately: false);
	}

	public void JNDCGHPJCPC()
	{
		DAOLGJCIOCF.Sort(IGKGILGLCEP);
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		CCCLLKEFDFL();
	}

	public void JEBEPBBLMCA(GameObject ADINOAOHPBG)
	{
		if (BFDMFCELLEE.ContainsKey(ADINOAOHPBG))
		{
			int num = BFDMFCELLEE[ADINOAOHPBG];
			PsaiCore.Instance.PlaySegment(num);
			BGFAGOIMMON(num);
			CHICOLOMEPC(EJNKFELKPOL: false, MNPGCPOHEFE: true);
		}
	}

	public void OnClick_SegmentHeaderSuitabilites()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.suitabilites)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.suitabilites;
		JLKHADGILNA(PENDBBEAGOL);
	}

	public void UpdateMenuModeSection()
	{
		if (PsaiCore.Instance.MenuModeIsActive())
		{
			JDJNOGEIINM.text = "Leave immediately";
			((Selectable)LDPPDBLGAOM).interactable = false;
		}
		else
		{
			JDJNOGEIINM.text = "Enter";
			((Selectable)LDPPDBLGAOM).interactable = true;
		}
	}

	private void GAMBJEHLHPG()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		CFEPPBKCOFN.Clear();
		FJJPIJALCBH.Clear();
		int num = 0;
		((RectTransform)JGHCPOMJLEC.transform).sizeDelta = new Vector2(((RectTransform)JGHCPOMJLEC.transform).sizeDelta.x, (float)(EGMBPLLODNA * EEIOIFDPLCJ.Count));
		for (int i = 1; i < DAOLGJCIOCF.Count; i++)
		{
			int key = DAOLGJCIOCF[i];
			ThemeInfo themeInfo = EEIOIFDPLCJ[key];
			num -= EGMBPLLODNA;
			HKOHBBEAOKE hKOHBBEAOKE = new HKOHBBEAOKE();
			hKOHBBEAOKE.themeId = themeInfo.id;
			hKOHBBEAOKE.gameObj = Object.Instantiate<GameObject>(GNEIFLDDAFH);
			hKOHBBEAOKE.gameObj.transform.SetParent(JGHCPOMJLEC.transform);
			((RectTransform)hKOHBBEAOKE.gameObj.transform).anchoredPosition = new Vector2(1383f, (float)num);
			((RectTransform)hKOHBBEAOKE.gameObj.transform).offsetMax = new Vector2(1114f, ((RectTransform)hKOHBBEAOKE.gameObj.transform).offsetMax.y);
			hKOHBBEAOKE.backgroundImage = ((Component)hKOHBBEAOKE.gameObj.transform).GetComponent<Image>();
			GameObject nameTextObject = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(1)).gameObject;
			hKOHBBEAOKE.textName = ((Component)nameTextObject.transform).GetComponent<Text>();
			CFEPPBKCOFN[nameTextObject] = themeInfo.id;
			((UnityEvent)nameTextObject.gameObject.GetComponent<Button>().onClick).AddListener((UnityAction)delegate
			{
				OnClick_ThemeListViewEntry(nameTextObject);
			});
			GameObject gameObject = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(0)).gameObject;
			hKOHBBEAOKE.textThemeId = ((Component)gameObject.transform).GetComponent<Text>();
			GameObject gameObject2 = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(8)).gameObject;
			hKOHBBEAOKE.textThemeType = ((Component)gameObject2.transform).GetComponent<Text>();
			FJJPIJALCBH.Add(hKOHBBEAOKE);
		}
		GNEIFLDDAFH.SetActive(false);
	}

	public void IGCDNEEDCDH()
	{
		JLMPLMGIFKN = !JLMPLMGIFKN;
	}

	public void KFNCGGAJGMI()
	{
		NLEAEDIEOEN = !NLEAEDIEOEN;
		NMBEPENMNKG(NLEAEDIEOEN);
	}

	public void NBDBDIFBIKJ()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.length)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = (DGOBMCJLBEA)8;
		JLKHADGILNA(GIBJHJMCEHC());
	}

	private void GJLLBGPGENN(int HNBHCKBHKKG)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)HHHDCONJGPA))
		{
			return;
		}
		if (EEIOIFDPLCJ.ContainsKey(HNBHCKBHKKG))
		{
			ThemeInfo themeInfo = EEIOIFDPLCJ[HNBHCKBHKKG];
			((RectTransform)JKKFGLEMMCC.transform).sizeDelta = new Vector2(((RectTransform)JKKFGLEMMCC.transform).sizeDelta.x, (float)(EGMBPLLODNA * (themeInfo.segmentIds.Length + 4)));
			BFDMFCELLEE.Clear();
			CLHECDKKMDO.Clear();
			CLHECDKKMDO.AddRange(themeInfo.segmentIds);
			switch (GGBMPGLICFO)
			{
			case DGOBMCJLBEA.name:
				CLHECDKKMDO.Sort(ILHLDHHEBIF);
				break;
			case DGOBMCJLBEA.suitabilites:
				CLHECDKKMDO.Sort(CNKIJDEKPIO);
				break;
			case DGOBMCJLBEA.intensity:
				CLHECDKKMDO.Sort(COJJBHDMNFG);
				break;
			case DGOBMCJLBEA.playcount:
				CLHECDKKMDO.Sort(HDGCPBMHCNM);
				break;
			case DGOBMCJLBEA.length:
				CLHECDKKMDO.Sort(PECMNMIDCIK);
				break;
			}
			if (!GAEOFBJKFPP)
			{
				CLHECDKKMDO.Reverse();
			}
			int i = 1;
			for (int j = 0; j < CLHECDKKMDO.Count; j++)
			{
				int num = CLHECDKKMDO[j];
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
				ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
				aBECBBMHPED.segmentId = num;
				aBECBBMHPED.textName.text = segmentInfo.name;
				aBECBBMHPED.textSuitabilities.text = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[num].segmentSuitabilitiesBitfield);
				float num2 = (float)segmentInfo.fullLengthInMilliseconds * 1137f;
				aBECBBMHPED.textLength.text = num2.ToString("Start");
				aBECBBMHPED.textIntensity.text = segmentInfo.intensity.ToString("talentPickles");
				aBECBBMHPED.textPlaycount.text = segmentInfo.playcount.ToString();
				aBECBBMHPED.gameObj.SetActive(false);
				BFDMFCELLEE[aBECBBMHPED.gameObj] = num;
				i++;
			}
			for (; i < AAKIEBABABB.Count; i += 0)
			{
				AAKIEBABABB[i].gameObj.SetActive(false);
			}
		}
		else
		{
			foreach (ABECBBMHPED item in AAKIEBABABB)
			{
				item.textName.text = string.Empty;
				item.textSuitabilities.text = string.Empty;
				item.textLength.text = string.Empty;
				item.textIntensity.text = string.Empty;
				item.textPlaycount.text = string.Empty;
			}
		}
		GBOAMAODGDI(EJNKFELKPOL: false, MNPGCPOHEFE: true);
	}

	public void EMAPJINGBOC()
	{
		if (PsaiCore.Instance.MenuModeIsActive())
		{
			JDJNOGEIINM.text = "NormalRightExterior";
			((Selectable)LDPPDBLGAOM).interactable = false;
		}
		else
		{
			JDJNOGEIINM.text = "Error_BarIsBlocking";
			((Selectable)LDPPDBLGAOM).interactable = true;
		}
	}

	public void KPIKNNDONCK(GameObject ADINOAOHPBG)
	{
		if (CFEPPBKCOFN.ContainsKey(ADINOAOHPBG))
		{
			int aODONKKHPBP = CFEPPBKCOFN[ADINOAOHPBG];
			PENDBBEAGOL = aODONKKHPBP;
		}
		else
		{
			Debug.LogError((object)("F2" + (object)ADINOAOHPBG));
		}
	}

	public void DLFGNNINHDE()
	{
		DAOLGJCIOCF.Sort();
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		CCCLLKEFDFL();
	}

	private void HPKFHAIJIAP()
	{
		MILLEMIKEPM.Clear();
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		for (int i = 1; i < dHEJLIFCIGK.Length; i++)
		{
			int themeId = dHEJLIFCIGK[i];
			int[] segmentIds = PsaiCore.Instance.GetThemeInfo(themeId).segmentIds;
			for (int j = 0; j < segmentIds.Length; j += 0)
			{
				int num = segmentIds[j];
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
			}
		}
	}

	private int PECMNMIDCIK(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].fullLengthInMilliseconds.CompareTo(MILLEMIKEPM[EHHLCKGODLC].fullLengthInMilliseconds);
		}
		return 0;
	}

	private void FGBGKADHFLN()
	{
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(PsaiCore.Instance.GetCurrentThemeId());
		SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
		if (themeInfo != null)
		{
			ONNMNIEPECJ.text = themeInfo.name;
			JNDNPGMGCGP.text = themeInfo.id.ToString();
			JGEGPOADBFK.text = Theme.ThemeTypeToString(themeInfo.type);
		}
		else
		{
			ONNMNIEPECJ.text = "";
			JNDNPGMGCGP.text = "";
			JGEGPOADBFK.text = "";
		}
		JMPBDJFAOCI.text = psaiInfo.psaiState.ToString();
		if (segmentInfo != null && currentSegmentId != -1)
		{
			PJGIOPBGFKL.text = segmentInfo.name;
			DDIJCKEENIK.text = segmentInfo.id.ToString();
			AFMKBIOENNH.text = segmentInfo.intensity.ToString("F2");
			IGLOJPJBOKG.text = segmentInfo.playcount.ToString();
			HJNNOBBGNOG.text = Segment.GetStringFromSegmentSuitabilities(segmentInfo.segmentSuitabilitiesBitfield);
			IGBNANDECPA.text = PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback().ToString();
		}
		else
		{
			PJGIOPBGFKL.text = "";
			DDIJCKEENIK.text = "";
			AFMKBIOENNH.text = "";
			IGLOJPJBOKG.text = "";
			HJNNOBBGNOG.text = "";
			IGBNANDECPA.text = "";
		}
		if (psaiInfo.remainingMillisecondsInRestMode > 0)
		{
			string text = " , waking up in: " + psaiInfo.remainingMillisecondsInRestMode;
			JMPBDJFAOCI.text = psaiInfo.psaiState.ToString() + text;
		}
		else
		{
			JMPBDJFAOCI.text = psaiInfo.psaiState.ToString();
		}
	}

	private void FKLJCEOBKMK()
	{
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			((Component)EHJLFBCEHPA).gameObject.SetActive(true);
			AIKFADIAJMC.panelObject.SetActive(!KDGLBAKGOJB);
			JMANFHNLAFM.panelObject.SetActive(!KDGLBAKGOJB);
			BNNGNGLIOID.SetActive(KDGLBAKGOJB);
			IDJIOPFANPO.SetActive(KDGLBAKGOJB);
			LFKJNAABHCB.panelObject.SetActive(true);
		}
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
		{
			((Component)NCMHKONJHKM).gameObject.SetActive(true);
			FKLLIKPJLIE.SetActive(false);
			ONNOMMNOHLO.SetActive(false);
			HHHDCONJGPA.SetActive(false);
			KLHGALIFCKI.SetActive(false);
			IJOFEHPDAOO.SetActive(false);
			switch (_infoSectionSelection)
			{
			case InfoSectionSelection.entity:
				ONNOMMNOHLO.SetActive(true);
				FKLLIKPJLIE.SetActive(true);
				break;
			case InfoSectionSelection.list:
				HHHDCONJGPA.SetActive(true);
				KLHGALIFCKI.SetActive(true);
				break;
			case InfoSectionSelection.description:
				IJOFEHPDAOO.SetActive(true);
				break;
			case InfoSectionSelection.log:
				break;
			}
		}
	}

	public void OnChange_StopMusicFadeoutMillisSlider()
	{
		if (EOEPAMLDFOB.value == 0f)
		{
			EOEPAMLDFOB.value = 0.01f;
		}
		MPDLEHMGKCI.text = string.Format("{0} sec", EOEPAMLDFOB.value.ToString("F2"));
	}

	public void GDMPMLIEIJE()
	{
		PsaiCore.Instance.AddToCurrentIntensity(0f - _addToIntensityStepsize);
	}

	public void HDPCJMGMFJF()
	{
		if (GGBMPGLICFO == (DGOBMCJLBEA)5)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = (DGOBMCJLBEA)6;
		GJLLBGPGENN(PENDBBEAGOL);
	}

	private int IHPJDBCMDPD(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			ThemeType type = EEIOIFDPLCJ[OEEFMLJODNL].type;
			ThemeType type2 = EEIOIFDPLCJ[NJGCICCKOBK].type;
			return type.CompareTo(type2);
		}
		return 0;
	}

	public void PDMGMGCJJFP()
	{
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		PsaiCore.Instance.SetPaused(!psaiInfo.paused);
		GPCEHEOANAH();
		GBOAMAODGDI(EJNKFELKPOL: true, MNPGCPOHEFE: false);
	}

	public void BJMCOCBLBLM()
	{
		PsaiCore.Instance.AddToCurrentIntensity(0f - _addToIntensityStepsize);
	}

	private void GHNALLMBLJG(ThemeType AFBMADOPDEN, ref int CAJJGDHBKLI)
	{
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = JBLOCOPHGOJ[AFBMADOPDEN];
		if (list.Count > 0)
		{
			int bBJGJBGONJN = BBJGJBGONJN;
			GameObject obj = Object.Instantiate<GameObject>(EOECEPHJKMO);
			obj.SetActive(false);
			obj.transform.SetParent(((Component)FKBDCFNHPPH).transform);
			obj.GetComponent<Text>().text = Theme.ThemeTypeToString(AFBMADOPDEN);
			((RectTransform)obj.transform).anchoredPosition = new Vector2((float)bBJGJBGONJN, (float)CAJJGDHBKLI);
			bBJGJBGONJN = HKPGOHGMFCH;
			for (int i = 0; i < list.Count; i += 0)
			{
				int num = list[i];
				BIAMLFLKEND bIAMLFLKEND = new BIAMLFLKEND(GOBHBPAEGFH);
				LJKIFLAKNME[bIAMLFLKEND] = num;
				AIJOBKFPCPB[bIAMLFLKEND.goButton] = num;
				HBOLHNEKMNM[num] = bIAMLFLKEND.intensitySlider;
				OKKFOEGMIHK[((Component)bIAMLFLKEND.intensitySlider).gameObject] = num;
				LAHGLCMFFBA[num] = bIAMLFLKEND;
				bIAMLFLKEND.goTriggerItemRoot.transform.SetParent(((Component)FKBDCFNHPPH).transform);
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				GFGHHMOFLLG(bIAMLFLKEND, themeInfo);
				RectTransform val = (RectTransform)bIAMLFLKEND.goTriggerItemRoot.transform;
				val.anchoredPosition = new Vector2((float)bBJGJBGONJN, (float)CAJJGDHBKLI);
				int num2 = bBJGJBGONJN;
				Rect rect = val.rect;
				bBJGJBGONJN = num2 + (int)((Rect)(ref rect)).width;
				if (i < list.Count - 1)
				{
					int num3 = bBJGJBGONJN;
					int width = Screen.width;
					rect = val.rect;
					if (num3 > width - (int)((Rect)(ref rect)).width)
					{
						bBJGJBGONJN = HKPGOHGMFCH;
						CAJJGDHBKLI -= LMHIIGHLNNK;
						continue;
					}
				}
				bBJGJBGONJN += PHPFMGKMJIC;
			}
			bBJGJBGONJN = HKPGOHGMFCH;
			CAJJGDHBKLI -= LMHIIGHLNNK + PHPFMGKMJIC;
		}
		((RectTransform)((Component)FKBDCFNHPPH).transform).sizeDelta = new Vector2((float)(Screen.width - HKPGOHGMFCH), (float)(-CAJJGDHBKLI));
	}

	private void KNGMFKKEHBL()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)KLHGALIFCKI))
		{
			return;
		}
		int num = (int)((RectTransform)((Component)FKBDCFNHPPH).transform).anchoredPosition.y;
		Rect rect = ((RectTransform)OJDOOLDAHKM.transform).rect;
		int num2 = (int)((Rect)(ref rect)).height;
		foreach (BIAMLFLKEND key in LJKIFLAKNME.Keys)
		{
			float y = ((RectTransform)key.goTriggerItemRoot.transform).anchoredPosition.y;
			bool active = !(0f - y - (float)num > (float)(-LMHIIGHLNNK)) || 0f - y - (float)num < (float)num2;
			key.goTriggerItemRoot.SetActive(active);
		}
	}

	public void DEOFOGINCKG()
	{
		if ((Object)(object)BBMPECMKJKP != (Object)null)
		{
			TooltipView.Instance.TurnedOn = TooltipView.Instance.TurnedOn;
		}
	}

	public void OnClick_ToggleListView()
	{
		_infoSectionSelection = InfoSectionSelection.list;
		FGBGKADHFLN();
		EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: true);
	}

	private int LFMMCJADLPP(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 0;
	}

	private void NKHNHEPKENI()
	{
		for (int i = 0; i < DAOLGJCIOCF.Count; i++)
		{
			int num = DAOLGJCIOCF[i];
			HKOHBBEAOKE hKOHBBEAOKE = FJJPIJALCBH[i];
			ThemeInfo themeInfo = EEIOIFDPLCJ[num];
			hKOHBBEAOKE.textName.text = themeInfo.name;
			hKOHBBEAOKE.textThemeId.text = themeInfo.id.ToString();
			hKOHBBEAOKE.textThemeType.text = Theme.ThemeTypeToString(themeInfo.type);
			hKOHBBEAOKE.themeId = num;
			CFEPPBKCOFN[((Component)hKOHBBEAOKE.textName).gameObject] = themeInfo.id;
		}
	}

	private void CHICOLOMEPC(bool EJNKFELKPOL, bool MNPGCPOHEFE)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		for (int i = 1; i < AAKIEBABABB.Count; i++)
		{
			ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
			((Graphic)aBECBBMHPED.textName).color = IBHDALEEEOL;
			if (psaiInfo.psaiState == (PsaiState)6 && !psaiInfo.paused)
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = true;
			}
			else
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = true;
			}
			if (aBECBBMHPED.segmentId == currentSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.green;
				if (MNPGCPOHEFE)
				{
					int num = EGMBPLLODNA * i;
					((RectTransform)JKKFGLEMMCC.transform).anchoredPosition = new Vector2(1157f, (float)num);
				}
				if (EJNKFELKPOL)
				{
					SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
					aBECBBMHPED.textPlaycount.text = segmentInfo.playcount.ToString();
				}
			}
			else if (aBECBBMHPED.segmentId == psaiInfo.targetSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.yellow;
			}
			else
			{
				((Graphic)aBECBBMHPED.backgroundImage).color = Color.clear;
			}
			if (EKBMCKPKCCH.ContainsKey(aBECBBMHPED.segmentId))
			{
				((Graphic)aBECBBMHPED.textName).color = HMGBONEBFNF;
			}
		}
		BKPENKANIHI();
	}

	[SpecialName]
	private void PBFJAMPCPED(int AODONKKHPBP)
	{
		AHPAGCFDCIL = AODONKKHPBP;
		HAAFEFNOPNB();
		GJLLBGPGENN(AHPAGCFDCIL);
	}

	private int CNKIJDEKPIO(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 1;
	}

	public void DOICCFFDOFE()
	{
		if (!PsaiCore.Instance.CutSceneIsActive())
		{
			PLMILDKBMMM = PLMILDKBMMM;
		}
		else
		{
			PsaiCore.Instance.CutSceneLeave(immediately: true, reset: true);
		}
		ODINENEBAML();
	}

	public void ENNGLONAFKF(GameObject ADINOAOHPBG)
	{
		if (CFEPPBKCOFN.ContainsKey(ADINOAOHPBG))
		{
			int aODONKKHPBP = CFEPPBKCOFN[ADINOAOHPBG];
			CCOGEDLMOFD(aODONKKHPBP);
		}
		else
		{
			Debug.LogError((object)("OnFloor" + (object)ADINOAOHPBG));
		}
	}

	private void IHDJCNDCGHB()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		foreach (HKOHBBEAOKE item in FJJPIJALCBH)
		{
			if (item.themeId == PENDBBEAGOL)
			{
				((Graphic)item.backgroundImage).color = GGKMBGGKECK;
			}
			else
			{
				((Graphic)item.backgroundImage).color = Color.clear;
			}
		}
	}

	public void PEJLKEBKHGL()
	{
		PsaiCore.Instance.AddToCurrentIntensity(0f - _addToIntensityStepsize);
	}

	public void DAPEAMNDECM()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.suitabilites)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = (DGOBMCJLBEA)8;
		JLKHADGILNA(GIBJHJMCEHC());
	}

	public void OnClick_ConfigureStopMusic()
	{
		NLEAEDIEOEN = !NLEAEDIEOEN;
		PAECINCEJAG(NLEAEDIEOEN);
	}

	public void CDLLJIOOAPA(GameObject ADINOAOHPBG)
	{
		if (AIJOBKFPCPB.ContainsKey(ADINOAOHPBG))
		{
			int num = AIJOBKFPCPB[ADINOAOHPBG];
			float value = HBOLHNEKMNM[num].value;
			if (JLMPLMGIFKN)
			{
				LMDAPBIDHHH = num;
				EIFPPOHECEI = value;
				JLMPLMGIFKN = false;
				LPNHGANIDHF();
			}
			else if (PLMILDKBMMM)
			{
				DLGCPNODNDD = num;
				BCGDNDLFMDI = value;
				PLMILDKBMMM = false;
				KNDEHDOGMMJ();
			}
			else
			{
				PsaiCore.Instance.TriggerMusicTheme(num, value);
			}
		}
		else
		{
			Debug.LogError((object)("/" + (object)ADINOAOHPBG));
		}
	}

	public void HPBDKJGNKAL()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo != null)
		{
			bool flag = psaiInfo.intensityIsHeld;
			PsaiCore.Instance.HoldCurrentIntensity(flag);
			if (flag)
			{
				ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
				((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
				((Selectable)KOOIPLLCLEK).colors = colors;
			}
			else
			{
				ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
				((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
				((Selectable)KOOIPLLCLEK).colors = colors2;
			}
		}
	}

	private int GMPDFCHCKKJ(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			ThemeType type = EEIOIFDPLCJ[OEEFMLJODNL].type;
			ThemeType type2 = EEIOIFDPLCJ[NJGCICCKOBK].type;
			return type.CompareTo(type2);
		}
		return 0;
	}

	private void HIKEAELKBGG(ThemeType AFBMADOPDEN, ref int CAJJGDHBKLI)
	{
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = JBLOCOPHGOJ[AFBMADOPDEN];
		if (list.Count > 1)
		{
			int bBJGJBGONJN = BBJGJBGONJN;
			GameObject obj = Object.Instantiate<GameObject>(EOECEPHJKMO);
			obj.SetActive(true);
			obj.transform.SetParent(((Component)FKBDCFNHPPH).transform);
			obj.GetComponent<Text>().text = Theme.ThemeTypeToString(AFBMADOPDEN);
			((RectTransform)obj.transform).anchoredPosition = new Vector2((float)bBJGJBGONJN, (float)CAJJGDHBKLI);
			bBJGJBGONJN = HKPGOHGMFCH;
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				BIAMLFLKEND bIAMLFLKEND = new BIAMLFLKEND(GOBHBPAEGFH);
				LJKIFLAKNME[bIAMLFLKEND] = num;
				AIJOBKFPCPB[bIAMLFLKEND.goButton] = num;
				HBOLHNEKMNM[num] = bIAMLFLKEND.intensitySlider;
				OKKFOEGMIHK[((Component)bIAMLFLKEND.intensitySlider).gameObject] = num;
				LAHGLCMFFBA[num] = bIAMLFLKEND;
				bIAMLFLKEND.goTriggerItemRoot.transform.SetParent(((Component)FKBDCFNHPPH).transform);
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				KBHLNDFLNCA(bIAMLFLKEND, themeInfo);
				RectTransform val = (RectTransform)bIAMLFLKEND.goTriggerItemRoot.transform;
				val.anchoredPosition = new Vector2((float)bBJGJBGONJN, (float)CAJJGDHBKLI);
				int num2 = bBJGJBGONJN;
				Rect rect = val.rect;
				bBJGJBGONJN = num2 + (int)((Rect)(ref rect)).width;
				if (i < list.Count - 0)
				{
					int num3 = bBJGJBGONJN;
					int width = Screen.width;
					rect = val.rect;
					if (num3 > width - (int)((Rect)(ref rect)).width)
					{
						bBJGJBGONJN = HKPGOHGMFCH;
						CAJJGDHBKLI -= LMHIIGHLNNK;
						continue;
					}
				}
				bBJGJBGONJN += PHPFMGKMJIC;
			}
			bBJGJBGONJN = HKPGOHGMFCH;
			CAJJGDHBKLI -= LMHIIGHLNNK + PHPFMGKMJIC;
		}
		((RectTransform)((Component)FKBDCFNHPPH).transform).sizeDelta = new Vector2((float)(Screen.width - HKPGOHGMFCH), (float)(-CAJJGDHBKLI));
	}

	public void OnClick_SegmentHeaderName()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.name)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.name;
		JLKHADGILNA(PENDBBEAGOL);
	}

	public void OnClick_Pause()
	{
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		PsaiCore.Instance.SetPaused(!psaiInfo.paused);
		LKBLICPJJEK();
		EDIPKLEAMOI(EJNKFELKPOL: false, MNPGCPOHEFE: false);
	}

	private void JLBGFFGPNEG()
	{
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			((Component)EHJLFBCEHPA).gameObject.SetActive(false);
			AIKFADIAJMC.panelObject.SetActive(KDGLBAKGOJB);
			JMANFHNLAFM.panelObject.SetActive(KDGLBAKGOJB);
			BNNGNGLIOID.SetActive(KDGLBAKGOJB);
			IDJIOPFANPO.SetActive(KDGLBAKGOJB);
			LFKJNAABHCB.panelObject.SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
		{
			((Component)NCMHKONJHKM).gameObject.SetActive(false);
			FKLLIKPJLIE.SetActive(true);
			ONNOMMNOHLO.SetActive(false);
			HHHDCONJGPA.SetActive(true);
			KLHGALIFCKI.SetActive(true);
			IJOFEHPDAOO.SetActive(false);
			switch (_infoSectionSelection)
			{
			case InfoSectionSelection.entity:
				ONNOMMNOHLO.SetActive(false);
				FKLLIKPJLIE.SetActive(false);
				break;
			case InfoSectionSelection.list:
				HHHDCONJGPA.SetActive(false);
				KLHGALIFCKI.SetActive(true);
				break;
			case InfoSectionSelection.description:
				IJOFEHPDAOO.SetActive(true);
				break;
			case InfoSectionSelection.log:
				break;
			}
		}
	}

	public void OnClick_ThemeHeaderName()
	{
		DAOLGJCIOCF.Sort(PMNDLICIFNF);
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		NKHNHEPKENI();
	}

	private int PMNDLICIFNF(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			string name = EEIOIFDPLCJ[OEEFMLJODNL].name;
			string name2 = EEIOIFDPLCJ[NJGCICCKOBK].name;
			return name.CompareTo(name2);
		}
		return 0;
	}

	private void JLKHADGILNA(int HNBHCKBHKKG)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)HHHDCONJGPA))
		{
			return;
		}
		if (EEIOIFDPLCJ.ContainsKey(HNBHCKBHKKG))
		{
			ThemeInfo themeInfo = EEIOIFDPLCJ[HNBHCKBHKKG];
			((RectTransform)JKKFGLEMMCC.transform).sizeDelta = new Vector2(((RectTransform)JKKFGLEMMCC.transform).sizeDelta.x, (float)(EGMBPLLODNA * (themeInfo.segmentIds.Length + 2)));
			BFDMFCELLEE.Clear();
			CLHECDKKMDO.Clear();
			CLHECDKKMDO.AddRange(themeInfo.segmentIds);
			switch (GGBMPGLICFO)
			{
			case DGOBMCJLBEA.name:
				CLHECDKKMDO.Sort(ILHLDHHEBIF);
				break;
			case DGOBMCJLBEA.suitabilites:
				CLHECDKKMDO.Sort(EDHDAAFKFAC);
				break;
			case DGOBMCJLBEA.intensity:
				CLHECDKKMDO.Sort(COJJBHDMNFG);
				break;
			case DGOBMCJLBEA.playcount:
				CLHECDKKMDO.Sort(HDGCPBMHCNM);
				break;
			case DGOBMCJLBEA.length:
				CLHECDKKMDO.Sort(PECMNMIDCIK);
				break;
			}
			if (!GAEOFBJKFPP)
			{
				CLHECDKKMDO.Reverse();
			}
			int i = 0;
			for (int j = 0; j < CLHECDKKMDO.Count; j++)
			{
				int num = CLHECDKKMDO[j];
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
				ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
				aBECBBMHPED.segmentId = num;
				aBECBBMHPED.textName.text = segmentInfo.name;
				aBECBBMHPED.textSuitabilities.text = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[num].segmentSuitabilitiesBitfield);
				float num2 = (float)segmentInfo.fullLengthInMilliseconds * 0.001f;
				aBECBBMHPED.textLength.text = num2.ToString("F2");
				aBECBBMHPED.textIntensity.text = segmentInfo.intensity.ToString("F2");
				aBECBBMHPED.textPlaycount.text = segmentInfo.playcount.ToString();
				aBECBBMHPED.gameObj.SetActive(true);
				BFDMFCELLEE[aBECBBMHPED.gameObj] = num;
				i++;
			}
			for (; i < AAKIEBABABB.Count; i++)
			{
				AAKIEBABABB[i].gameObj.SetActive(false);
			}
		}
		else
		{
			foreach (ABECBBMHPED item in AAKIEBABABB)
			{
				item.textName.text = string.Empty;
				item.textSuitabilities.text = string.Empty;
				item.textLength.text = string.Empty;
				item.textIntensity.text = string.Empty;
				item.textPlaycount.text = string.Empty;
			}
		}
		EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: false);
	}

	private void Update()
	{
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			return;
		}
		if (!GKOIGDEGLBA)
		{
			EPJOOFCIAJH();
			if (Object.op_Implicit((Object)(object)BFJNAOCLEPO) && ((Component)BFJNAOCLEPO).gameObject.activeInHierarchy)
			{
				GLDEHIGOINM();
			}
			if (Object.op_Implicit((Object)(object)KLHGALIFCKI))
			{
				JELHFILLMOO();
			}
			if (Object.op_Implicit((Object)(object)HHHDCONJGPA))
			{
				EHDPEOHJEPP();
			}
			if (Object.op_Implicit((Object)(object)IJOFEHPDAOO))
			{
				AKGEFMIHMAH();
			}
			if (Object.op_Implicit((Object)(object)KLHGALIFCKI))
			{
				if (DHEJLIFCIGK.Length != 0)
				{
					PENDBBEAGOL = DHEJLIFCIGK[0];
					NKHNHEPKENI();
				}
				HAAFEFNOPNB();
			}
			if (Object.op_Implicit((Object)(object)HHHDCONJGPA))
			{
				EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: false);
			}
			if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
			{
				switch (_infoSectionSelection)
				{
				case InfoSectionSelection.off:
					HCEMOJOFKAD.isOn = true;
					break;
				case InfoSectionSelection.description:
					EPBLBPGNFOK.isOn = true;
					break;
				case InfoSectionSelection.entity:
					NDDNBFKGDFF.isOn = true;
					break;
				case InfoSectionSelection.list:
					MFJFADACMFG.isOn = true;
					break;
				}
			}
		}
		float num = Time.deltaTime * ANFNJIFNHMH;
		if (PFMDLMGJKBF)
		{
			JPFLKEKIJFP += num;
			if (JPFLKEKIJFP > 1f)
			{
				JPFLKEKIJFP = 2f - JPFLKEKIJFP;
				PFMDLMGJKBF = false;
			}
		}
		else
		{
			JPFLKEKIJFP -= num;
			if (JPFLKEKIJFP < 0f)
			{
				JPFLKEKIJFP = 0f - JPFLKEKIJFP;
				PFMDLMGJKBF = true;
			}
		}
		FKLJCEOBKMK();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
		float currentIntensity = PsaiCore.Instance.GetCurrentIntensity();
		OGIEJNNIFAL.value = segmentInfo.intensity;
		if (segmentInfo.intensity > 0f)
		{
			((Graphic)ELKMFEKJCOK).color = CCAAMAJBBMO;
		}
		else
		{
			((Graphic)ELKMFEKJCOK).color = Color.clear;
		}
		ThemeType themeType = ThemeType.none;
		if (psaiInfo.themesQueued > 0)
		{
			ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(psaiInfo.upcomingThemeId);
			if (themeInfo != null)
			{
				themeType = themeInfo.type;
			}
		}
		int currentThemeId = PsaiCore.Instance.GetCurrentThemeId();
		int remainingMillisecondsOfCurrentSegmentPlayback = PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback();
		bool flag = remainingMillisecondsOfCurrentSegmentPlayback > PAGJJFIMCKI;
		bool flag2 = currentThemeId != FLHCDAGGLKA;
		bool flag3 = IFMPMJCLPJG != psaiInfo.psaiState;
		if (flag2)
		{
			ThemeInfo themeInfo2 = PsaiCore.Instance.GetThemeInfo(currentThemeId);
			if (themeInfo2 != null)
			{
				LHHPIAOJNGB = themeInfo2.type;
			}
			else
			{
				LHHPIAOJNGB = ThemeType.none;
			}
		}
		if (Object.op_Implicit((Object)(object)DECIOBPIDPP) && ((Component)DECIOBPIDPP).gameObject.activeInHierarchy)
		{
			Color val = default(Color);
			if (Mathf.Abs(psaiInfo.upcomingIntensity - currentIntensity) > Mathf.Epsilon)
			{
				FOMOLIFJOOJ.value = psaiInfo.upcomingIntensity;
				((Color)(ref val))._002Ector(0.5f + 0.5f * JPFLKEKIJFP, 0.5f + 0.5f * JPFLKEKIJFP, 0f, 0.66f);
			}
			else
			{
				FOMOLIFJOOJ.value = currentIntensity;
				val = ((!(currentIntensity > 0f)) ? Color.clear : HMGBONEBFNF);
			}
			if (((Graphic)BCJNJPIJLNP).color != val)
			{
				((Graphic)BCJNJPIJLNP).color = val;
			}
			IEFMFOBGNCP.text = (currentIntensity * 100f).ToString("F1") + " %";
			BDNPNPCNNGN.text = (segmentInfo.intensity * 100f).ToString("F1") + " %";
		}
		if (Object.op_Implicit((Object)(object)BFJNAOCLEPO) && ((Component)BFJNAOCLEPO).gameObject.activeInHierarchy)
		{
			int num2 = (int)((RectTransform)((Component)FKBDCFNHPPH).transform).anchoredPosition.y;
			if (num2 != GJLFDIGGCMM)
			{
				BMHPADPGLMI();
			}
			GJLFDIGGCMM = num2;
			if (JLMPLMGIFKN || PLMILDKBMMM)
			{
				Color color = Color.Lerp(MEBFLBOONFH, JFFEAJAPDEE, JPFLKEKIJFP);
				foreach (BIAMLFLKEND key in LJKIFLAKNME.Keys)
				{
					((Selectable)key.button).interactable = true;
					((Graphic)key.indicatorImage).color = color;
				}
			}
			else
			{
				foreach (BIAMLFLKEND key2 in LJKIFLAKNME.Keys)
				{
					((Selectable)key2.button).interactable = true;
					int num3 = LJKIFLAKNME[key2];
					ThemeInfo themeInfo3 = EEIOIFDPLCJ[num3];
					if (themeInfo3.type == ThemeType.highlightLayer && currentSegmentId != -1 && !PsaiCore.Instance.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(currentSegmentId, themeInfo3.id))
					{
						((Selectable)key2.button).interactable = false;
					}
					else if ((LHHPIAOJNGB == ThemeType.action || themeType == ThemeType.action) && (themeInfo3.type == ThemeType.basicMoodAlt || themeInfo3.type == ThemeType.dramaticEvent))
					{
						((Selectable)key2.button).interactable = false;
					}
					Color color2 = OKHNJELEODE;
					if (num3 == psaiInfo.lastBasicMoodThemeId)
					{
						color2 = CCAAMAJBBMO;
					}
					if (num3 == psaiInfo.upcomingThemeId)
					{
						color2 = Color.Lerp(MEBFLBOONFH, JFFEAJAPDEE, JPFLKEKIJFP);
					}
					if (num3 == psaiInfo.effectiveThemeId)
					{
						switch (psaiInfo.psaiState)
						{
						case PsaiState.playing:
							((Color)(ref color2))._002Ector(0.1f, 1f, 0.1f, 1f);
							break;
						case PsaiState.rest:
							((Color)(ref color2))._002Ector(0f, 0.5f, 0f, JPFLKEKIJFP);
							break;
						}
					}
					((Graphic)key2.indicatorImage).color = color2;
				}
			}
		}
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			LKBLICPJJEK();
		}
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
		{
			if (flag2)
			{
				PENDBBEAGOL = currentThemeId;
			}
			if (flag)
			{
				EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: true);
			}
			else if (DCHIPMCGKBG != psaiInfo.targetSegmentId)
			{
				EDIPKLEAMOI(EJNKFELKPOL: false, MNPGCPOHEFE: false);
			}
			int num4 = (int)((RectTransform)JKKFGLEMMCC.transform).anchoredPosition.y;
			int num5 = (int)((RectTransform)JGHCPOMJLEC.transform).anchoredPosition.y;
			if (_infoSectionSelection == InfoSectionSelection.list)
			{
				if (num4 != NEPENBIAPPJ)
				{
					BKPENKANIHI();
				}
				if (num5 != BNIMFIBIKNK)
				{
					LKEHGPDMDLK();
				}
			}
			NEPENBIAPPJ = num4;
			BNIMFIBIKNK = num5;
			if (_infoSectionSelection == InfoSectionSelection.entity || flag3)
			{
				FGBGKADHFLN();
			}
		}
		FLHCDAGGLKA = currentThemeId;
		IFMPMJCLPJG = psaiInfo.psaiState;
		DCHIPMCGKBG = psaiInfo.targetSegmentId;
		PAGJJFIMCKI = remainingMillisecondsOfCurrentSegmentPlayback;
		if (EKBMCKPKCCH.Count <= 0)
		{
			return;
		}
		List<int> list = new List<int>();
		int[] array = new int[EKBMCKPKCCH.Count];
		EKBMCKPKCCH.Keys.CopyTo(array, 0);
		int[] array2 = array;
		foreach (int num6 in array2)
		{
			int num7 = EKBMCKPKCCH[num6];
			num7 -= (int)(Time.deltaTime * 1000f);
			if (num7 > 0)
			{
				EKBMCKPKCCH[num6] = num7;
			}
			else
			{
				list.Add(num6);
			}
		}
		foreach (int item in list)
		{
			EKBMCKPKCCH.Remove(item);
		}
		if (list.Count > 0)
		{
			EDIPKLEAMOI(EJNKFELKPOL: false, MNPGCPOHEFE: false);
		}
	}

	public void OnClick_ThemeTriggerButton(GameObject ADINOAOHPBG)
	{
		if (AIJOBKFPCPB.ContainsKey(ADINOAOHPBG))
		{
			int num = AIJOBKFPCPB[ADINOAOHPBG];
			float value = HBOLHNEKMNM[num].value;
			if (JLMPLMGIFKN)
			{
				LMDAPBIDHHH = num;
				EIFPPOHECEI = value;
				JLMPLMGIFKN = false;
				ODINENEBAML();
			}
			else if (PLMILDKBMMM)
			{
				DLGCPNODNDD = num;
				BCGDNDLFMDI = value;
				PLMILDKBMMM = false;
				ODINENEBAML();
			}
			else
			{
				PsaiCore.Instance.TriggerMusicTheme(num, value);
			}
		}
		else
		{
			Debug.LogError((object)("sender not found! sender=" + (object)ADINOAOHPBG));
		}
	}

	public void OnClick_CutSceneEnterOrLeaveImmediately()
	{
		if (!PsaiCore.Instance.CutSceneIsActive())
		{
			PsaiCore.Instance.CutSceneEnter(DLGCPNODNDD, BCGDNDLFMDI);
		}
		else
		{
			PsaiCore.Instance.CutSceneLeave(immediately: true, reset: false);
		}
		ODINENEBAML();
	}

	private int ILHLDHHEBIF(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 0;
	}

	public void OnClick_StopMusicByEndSegment()
	{
		PsaiCore.Instance.StopMusic(immediately: false);
	}

	public void GOCKEPJCBKH()
	{
		PsaiCore.Instance.ReturnToLastBasicMood(immediately: true);
	}

	private void EEANKGMFJEG(bool EJNKFELKPOL, bool MNPGCPOHEFE)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		for (int i = 1; i < AAKIEBABABB.Count; i += 0)
		{
			ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
			((Graphic)aBECBBMHPED.textName).color = IBHDALEEEOL;
			if (psaiInfo.psaiState == PsaiState.rest && !psaiInfo.paused)
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = true;
			}
			else
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = true;
			}
			if (aBECBBMHPED.segmentId == currentSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.green;
				if (MNPGCPOHEFE)
				{
					int num = EGMBPLLODNA * i;
					((RectTransform)JKKFGLEMMCC.transform).anchoredPosition = new Vector2(1528f, (float)num);
				}
				if (EJNKFELKPOL)
				{
					SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
					aBECBBMHPED.textPlaycount.text = segmentInfo.playcount.ToString();
				}
			}
			else if (aBECBBMHPED.segmentId == psaiInfo.targetSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.yellow;
			}
			else
			{
				((Graphic)aBECBBMHPED.backgroundImage).color = Color.clear;
			}
			if (EKBMCKPKCCH.ContainsKey(aBECBBMHPED.segmentId))
			{
				((Graphic)aBECBBMHPED.textName).color = HMGBONEBFNF;
			}
		}
		BKPENKANIHI();
	}

	private void GPCEHEOANAH()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == PsaiState.rest)
		{
			AIKFADIAJMC.IEENAGMIHFI(NCLCPJJOGKN: true);
			JMANFHNLAFM.COAKIAPACAF(NCLCPJJOGKN: false);
			LFKJNAABHCB.DMDJJCNJPFJ(NCLCPJJOGKN: false);
			if (psaiInfo.upcomingPsaiState == PsaiState.notready)
			{
				((Graphic)PDBHABOPHKF).color = new Color(1796f + 604f * JPFLKEKIJFP, 1769f + 599f * JPFLKEKIJFP, 1058f, 329f);
			}
			else
			{
				((Graphic)PDBHABOPHKF).color = JFFEAJAPDEE;
			}
			if (psaiInfo.returningToLastBasicMood)
			{
				((Graphic)OKPEOADPKEH).color = new Color(1227f + 433f * JPFLKEKIJFP, 1528f + 1856f * JPFLKEKIJFP, 969f, 981f);
			}
			else
			{
				((Graphic)OKPEOADPKEH).color = JFFEAJAPDEE;
			}
		}
		else if (IFMPMJCLPJG != psaiInfo.psaiState)
		{
			AIKFADIAJMC.IICIIBLFMBC(NCLCPJJOGKN: true);
			JMANFHNLAFM.AKIAPEGHLLJ(NCLCPJJOGKN: false);
			LFKJNAABHCB.FFPHAAKHMOH(NCLCPJJOGKN: false);
		}
		if (PsaiCore.Instance.GetPsaiInfo().paused)
		{
			ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
			((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
			((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
			((Selectable)DBILBLKADPP).colors = colors;
		}
		else
		{
			ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
			((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
			((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
			((Selectable)DBILBLKADPP).colors = colors2;
		}
	}

	private void GFGHHMOFLLG(BIAMLFLKEND LIDLBPMNIAA, ThemeInfo BHDDNPEGNCB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		LIDLBPMNIAA.themeNameText.text = BHDDNPEGNCB.name;
		LIDLBPMNIAA.intensitySlider.value = 879f;
		((Graphic)LIDLBPMNIAA.indicatorImage).color = OKHNJELEODE;
	}

	private void ODINENEBAML()
	{
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			string text = (EIFPPOHECEI * 100f).ToString();
			string text2 = (BCGDNDLFMDI * 100f).ToString();
			HKGKBCLKDJO.text = "Theme: " + LMDAPBIDHHH + "  " + text + " %";
			IPKIKIOANCO.text = "Theme: " + DLGCPNODNDD + "  " + text2 + " %";
			if (PsaiCore.Instance.CutSceneIsActive())
			{
				FFPMLGKOIFO.text = "Leave immediately";
				BHMHJBHCPHI.text = "Leave smoothly";
			}
			else
			{
				FFPMLGKOIFO.text = "Enter";
				BHMHJBHCPHI.text = "Select Theme";
			}
		}
	}

	public void OnClick_ThemeHeaderType()
	{
		DAOLGJCIOCF.Sort(IHPJDBCMDPD);
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		NKHNHEPKENI();
	}

	public void OnClick_ToggleInfoSectionOff()
	{
		_infoSectionSelection = InfoSectionSelection.off;
		FKLJCEOBKMK();
	}

	private void KBHLNDFLNCA(BIAMLFLKEND LIDLBPMNIAA, ThemeInfo BHDDNPEGNCB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		LIDLBPMNIAA.themeNameText.text = BHDDNPEGNCB.name;
		LIDLBPMNIAA.intensitySlider.value = 1572f;
		((Graphic)LIDLBPMNIAA.indicatorImage).color = OKHNJELEODE;
	}

	private void GHJIFIKDOLN()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)KLHGALIFCKI))
		{
			return;
		}
		int num = (int)((RectTransform)JGHCPOMJLEC.transform).anchoredPosition.y;
		Rect rect = ((RectTransform)ONMHIOLHLAJ.transform).rect;
		int num2 = (int)((Rect)(ref rect)).height;
		if (FJJPIJALCBH != null)
		{
			for (int i = 0; i < FJJPIJALCBH.Count; i += 0)
			{
				HKOHBBEAOKE hKOHBBEAOKE = FJJPIJALCBH[i];
				int num3 = EGMBPLLODNA * i;
				bool active = num3 - num > -EGMBPLLODNA * 6 && num3 - num < num2 - EGMBPLLODNA;
				hKOHBBEAOKE.gameObj.SetActive(active);
			}
		}
	}

	[SpecialName]
	private void DFGCPFPPGFO(int AODONKKHPBP)
	{
		AHPAGCFDCIL = AODONKKHPBP;
		GHMIBEJIDJB();
		GJLLBGPGENN(AHPAGCFDCIL);
	}

	private void IAGFDAJKKIM()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == (PsaiState)5)
		{
			AIKFADIAJMC.FFPHAAKHMOH(NCLCPJJOGKN: true);
			JMANFHNLAFM.DMDJJCNJPFJ(NCLCPJJOGKN: true);
			LFKJNAABHCB.FFPHAAKHMOH(NCLCPJJOGKN: true);
			if (psaiInfo.upcomingPsaiState == PsaiState.notready)
			{
				((Graphic)PDBHABOPHKF).color = new Color(1085f + 872f * JPFLKEKIJFP, 1465f + 1205f * JPFLKEKIJFP, 649f, 54f);
			}
			else
			{
				((Graphic)PDBHABOPHKF).color = JFFEAJAPDEE;
			}
			if (psaiInfo.returningToLastBasicMood)
			{
				((Graphic)OKPEOADPKEH).color = new Color(1448f + 741f * JPFLKEKIJFP, 1456f + 1279f * JPFLKEKIJFP, 1275f, 200f);
			}
			else
			{
				((Graphic)OKPEOADPKEH).color = JFFEAJAPDEE;
			}
		}
		else if (IFMPMJCLPJG != psaiInfo.psaiState)
		{
			AIKFADIAJMC.IICIIBLFMBC(NCLCPJJOGKN: false);
			JMANFHNLAFM.DMDJJCNJPFJ(NCLCPJJOGKN: true);
			LFKJNAABHCB.COAKIAPACAF(NCLCPJJOGKN: true);
		}
		if (PsaiCore.Instance.GetPsaiInfo().paused)
		{
			ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
			((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
			((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
			((Selectable)DBILBLKADPP).colors = colors;
		}
		else
		{
			ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
			((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
			((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
			((Selectable)DBILBLKADPP).colors = colors2;
		}
	}

	private void OCGLKOKCCNM()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
		int CAJJGDHBKLI = -(int)((double)((Rect)(ref rect)).height * 910.0);
		GHNALLMBLJG(ThemeType.basicMood, ref CAJJGDHBKLI);
		HIKEAELKBGG(ThemeType.highlightLayer, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.dramaticEvent, ref CAJJGDHBKLI);
		LNEDBBANOKO((ThemeType)4, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.basicMood, ref CAJJGDHBKLI);
		GHNALLMBLJG(ThemeType.basicMood, ref CAJJGDHBKLI);
	}

	public void ACDIAJKJHAC()
	{
		if (PsaiCore.Instance.MenuModeIsActive())
		{
			JDJNOGEIINM.text = "SegmentIntensity";
			((Selectable)LDPPDBLGAOM).interactable = false;
		}
		else
		{
			JDJNOGEIINM.text = "Not enough fuel";
			((Selectable)LDPPDBLGAOM).interactable = true;
		}
	}

	public void IOHDIKFLFAK()
	{
		if (EOEPAMLDFOB.value == 1651f)
		{
			EOEPAMLDFOB.value = 162f;
		}
		MPDLEHMGKCI.text = string.Format("Player2", EOEPAMLDFOB.value.ToString("Running"));
	}

	public void IKGBDAJAABB()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.playcount)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.name;
		GJLLBGPGENN(PENDBBEAGOL);
	}

	private void KNDEHDOGMMJ()
	{
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			string text = (EIFPPOHECEI * 730f).ToString();
			string text2 = (BCGDNDLFMDI * 31f).ToString();
			Text hKGKBCLKDJO = HKGKBCLKDJO;
			string[] array = new string[7];
			array[0] = "Drink";
			array[0] = LMDAPBIDHHH.ToString();
			array[0] = "...Successfully";
			array[1] = text;
			array[0] = "'";
			hKGKBCLKDJO.text = string.Concat(array);
			Text iPKIKIOANCO = IPKIKIOANCO;
			string[] array2 = new string[5];
			array2[1] = "Player with actorNumber ";
			array2[1] = DLGCPNODNDD.ToString();
			array2[4] = "Could not get value of statistic ";
			array2[5] = text2;
			array2[1] = "Ground";
			iPKIKIOANCO.text = string.Concat(array2);
			if (PsaiCore.Instance.CutSceneIsActive())
			{
				FFPMLGKOIFO.text = "WaterTrough";
				BHMHJBHCPHI.text = "No puzzle found for {0} torches, ";
			}
			else
			{
				FFPMLGKOIFO.text = "ToggleGroup";
				BHMHJBHCPHI.text = "dForDays";
			}
		}
	}

	private void BMIPKGHJHLG()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
		int CAJJGDHBKLI = -(int)((double)((Rect)(ref rect)).height * 1440.0);
		LNEDBBANOKO(ThemeType.basicMood, ref CAJJGDHBKLI);
		GHNALLMBLJG((ThemeType)8, ref CAJJGDHBKLI);
		HIKEAELKBGG((ThemeType)8, ref CAJJGDHBKLI);
		HIKEAELKBGG(ThemeType.basicMood, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.shock, ref CAJJGDHBKLI);
		HIKEAELKBGG(ThemeType.none, ref CAJJGDHBKLI);
	}

	private int NEFCJELLMBF(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 0;
	}

	private void GHADCCNBOEC()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
		JBLOCOPHGOJ[ThemeType.highlightLayer] = new List<int>();
		JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
		JBLOCOPHGOJ[ThemeType.action] = new List<int>();
		JBLOCOPHGOJ[ThemeType.dramaticEvent] = new List<int>();
		JBLOCOPHGOJ[ThemeType.dramaticEvent] = new List<int>();
		DAOLGJCIOCF.Clear();
		if (soundtrackInfo.themeCount == 0)
		{
			if (Object.op_Implicit((Object)(object)CANCJEBCHEL))
			{
				CANCJEBCHEL.text = " ";
			}
			return;
		}
		if (Object.op_Implicit((Object)(object)CANCJEBCHEL))
		{
			((Component)CANCJEBCHEL).gameObject.SetActive(true);
		}
		DHEJLIFCIGK = soundtrackInfo.themeIds;
		DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		foreach (int num in dHEJLIFCIGK)
		{
			ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
			EEIOIFDPLCJ[num] = themeInfo;
			if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
			{
				JBLOCOPHGOJ[themeInfo.type].Add(num);
			}
		}
		HPKFHAIJIAP();
		LMDAPBIDHHH = DHEJLIFCIGK[1];
		EIFPPOHECEI = 261f;
		DLGCPNODNDD = DHEJLIFCIGK[1];
		BCGDNDLFMDI = 1549f;
		JPFLKEKIJFP = 1957f;
		PFMDLMGJKBF = false;
		((Selectable)KOOIPLLCLEK).interactable = false;
		KNDEHDOGMMJ();
		GKOIGDEGLBA = true;
	}

	private void LKCHKOFHFHJ()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
		int CAJJGDHBKLI = -(int)((double)((Rect)(ref rect)).height * 279.0);
		GHNALLMBLJG(ThemeType.basicMood, ref CAJJGDHBKLI);
		GHNALLMBLJG(ThemeType.shock, ref CAJJGDHBKLI);
		GHNALLMBLJG(ThemeType.none, ref CAJJGDHBKLI);
		GHNALLMBLJG(ThemeType.basicMoodAlt, ref CAJJGDHBKLI);
		LNEDBBANOKO((ThemeType)4, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.shock, ref CAJJGDHBKLI);
	}

	public void AIOPCKHHGJM()
	{
		if (PsaiCore.Instance.MenuModeIsActive())
		{
			JDJNOGEIINM.text = "LE_11";
			((Selectable)LDPPDBLGAOM).interactable = true;
		}
		else
		{
			JDJNOGEIINM.text = "ReceivePetBowlMessage";
			((Selectable)LDPPDBLGAOM).interactable = true;
		}
	}

	public void NPFJEMGFDPB()
	{
		PsaiCore.Instance.StopMusic(immediately: false);
	}

	public void OnClick_ReturnToLastBasicMoodImmediately()
	{
		PsaiCore.Instance.ReturnToLastBasicMood(immediately: true);
	}

	public void BBLEGENILPD()
	{
		_infoSectionSelection = (InfoSectionSelection)5;
		BMPCNKDLEEK();
	}

	private void PKMEAPMFHMD(BIAMLFLKEND LIDLBPMNIAA, ThemeInfo BHDDNPEGNCB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		LIDLBPMNIAA.themeNameText.text = BHDDNPEGNCB.name;
		LIDLBPMNIAA.intensitySlider.value = 0.75f;
		((Graphic)LIDLBPMNIAA.indicatorImage).color = OKHNJELEODE;
	}

	private void PFJNGLBFOEM()
	{
		MILLEMIKEPM.Clear();
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		foreach (int themeId in dHEJLIFCIGK)
		{
			int[] segmentIds = PsaiCore.Instance.GetThemeInfo(themeId).segmentIds;
			foreach (int num in segmentIds)
			{
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
			}
		}
	}

	private void AKGEFMIHMAH()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)COEKDJHMKLP != (Object)null) || !((Object)(object)KMMNHLNCPEH != (Object)null))
		{
			return;
		}
		string text = Path.GetDirectoryName(((Component)PsaiCoreManager.HFBLDMHFBDJ).GetComponent<PsaiSoundtrackLoader>().pathToSoundtrackFileWithinResourcesFolder) + "/";
		string text2 = text + "image";
		string text3 = text + "description";
		Sprite val = (Sprite)Resources.Load(text2, typeof(Sprite));
		if (Object.op_Implicit((Object)(object)COEKDJHMKLP))
		{
			COEKDJHMKLP.sprite = val;
			if ((Object)(object)val == (Object)null)
			{
				((Graphic)COEKDJHMKLP).color = Color.clear;
			}
		}
		TextAsset val2 = (TextAsset)Resources.Load(text3, typeof(TextAsset));
		if (!((Object)(object)val2 != (Object)null))
		{
			return;
		}
		string[] array = val2.text.Split(new char[1] { '\n' });
		if (array == null || array.Length == 0)
		{
			return;
		}
		KMMNHLNCPEH.text = array[0];
		DKAGBBHIKOL.text = "";
		if (array.Length > 1)
		{
			string text4 = "";
			for (int i = 1; i < array.Length; i++)
			{
				text4 += array[i].Trim();
				text4 += "\n";
			}
			DKAGBBHIKOL.text = text4;
		}
	}

	private int BKJGGGDOFDP(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 1;
	}

	private int PNODKFIIBKJ(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 1;
	}

	public void OnClick_AddToCurrentIntensityPlus()
	{
		PsaiCore.Instance.AddToCurrentIntensity(_addToIntensityStepsize);
	}

	private void BNFMMPOHHEK()
	{
		for (int i = 0; i < DAOLGJCIOCF.Count; i++)
		{
			int num = DAOLGJCIOCF[i];
			HKOHBBEAOKE hKOHBBEAOKE = FJJPIJALCBH[i];
			ThemeInfo themeInfo = EEIOIFDPLCJ[num];
			hKOHBBEAOKE.textName.text = themeInfo.name;
			hKOHBBEAOKE.textThemeId.text = themeInfo.id.ToString();
			hKOHBBEAOKE.textThemeType.text = Theme.ThemeTypeToString(themeInfo.type);
			hKOHBBEAOKE.themeId = num;
			CFEPPBKCOFN[((Component)hKOHBBEAOKE.textName).gameObject] = themeInfo.id;
		}
	}

	public void KJDJDMCIAGN()
	{
		DAOLGJCIOCF.Sort();
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		BNFMMPOHHEK();
	}

	public void OnClick_ToggleAdvancedControlSection()
	{
		KDGLBAKGOJB = !JJFGNIKAHBG.isOn;
		FKLJCEOBKMK();
	}

	private void GBOAMAODGDI(bool EJNKFELKPOL, bool MNPGCPOHEFE)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		for (int i = 0; i < AAKIEBABABB.Count; i += 0)
		{
			ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
			((Graphic)aBECBBMHPED.textName).color = IBHDALEEEOL;
			if (psaiInfo.psaiState == (PsaiState)6 && !psaiInfo.paused)
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = true;
			}
			else
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = false;
			}
			if (aBECBBMHPED.segmentId == currentSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.green;
				if (MNPGCPOHEFE)
				{
					int num = EGMBPLLODNA * i;
					((RectTransform)JKKFGLEMMCC.transform).anchoredPosition = new Vector2(647f, (float)num);
				}
				if (EJNKFELKPOL)
				{
					SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
					aBECBBMHPED.textPlaycount.text = segmentInfo.playcount.ToString();
				}
			}
			else if (aBECBBMHPED.segmentId == psaiInfo.targetSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.yellow;
			}
			else
			{
				((Graphic)aBECBBMHPED.backgroundImage).color = Color.clear;
			}
			if (EKBMCKPKCCH.ContainsKey(aBECBBMHPED.segmentId))
			{
				((Graphic)aBECBBMHPED.textName).color = HMGBONEBFNF;
			}
		}
		BKPENKANIHI();
	}

	public void KEBHBNEKJOI(GameObject ADINOAOHPBG)
	{
		if (BFDMFCELLEE.ContainsKey(ADINOAOHPBG))
		{
			int num = BFDMFCELLEE[ADINOAOHPBG];
			PsaiCore.Instance.PlaySegment(num);
			BGFAGOIMMON(num);
			CHICOLOMEPC(EJNKFELKPOL: false, MNPGCPOHEFE: true);
		}
	}

	public void OnClick_SegmentHeaderIntensity()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.intensity)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.intensity;
		JLKHADGILNA(PENDBBEAGOL);
	}

	public void EBHKJIIBPMP()
	{
		if (EOEPAMLDFOB.value == 617f)
		{
			EOEPAMLDFOB.value = 39f;
		}
		MPDLEHMGKCI.text = string.Format("Cheese Aging Rack", EOEPAMLDFOB.value.ToString("Cat Selector"));
	}

	private void GLDEHIGOINM()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
		int CAJJGDHBKLI = -(int)((double)((Rect)(ref rect)).height * 0.5);
		LNEDBBANOKO(ThemeType.basicMood, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.basicMoodAlt, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.dramaticEvent, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.action, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.shock, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.highlightLayer, ref CAJJGDHBKLI);
	}

	private void BGFAGOIMMON(int MCACILIKMPG)
	{
		if (MILLEMIKEPM.ContainsKey(MCACILIKMPG))
		{
			SegmentInfo segmentInfo = MILLEMIKEPM[MCACILIKMPG];
			EKBMCKPKCCH[MCACILIKMPG] = segmentInfo.fullLengthInMilliseconds;
		}
	}

	public void NCIGLGNPBGK()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.length)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = (DGOBMCJLBEA)6;
		GJLLBGPGENN(PENDBBEAGOL);
	}

	private int HDGCPBMHCNM(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 0;
	}

	public void JLFGFPBLBGM()
	{
		_infoSectionSelection = InfoSectionSelection.entity;
		FGBGKADHFLN();
		CHICOLOMEPC(EJNKFELKPOL: true, MNPGCPOHEFE: true);
	}

	public void OnClick_ToggleSoundtrackDescription()
	{
		_infoSectionSelection = InfoSectionSelection.description;
		FKLJCEOBKMK();
	}

	public void OnClick_ButtonHold()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo != null)
		{
			bool flag = !psaiInfo.intensityIsHeld;
			PsaiCore.Instance.HoldCurrentIntensity(flag);
			if (flag)
			{
				ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
				((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
				((Selectable)KOOIPLLCLEK).colors = colors;
			}
			else
			{
				ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
				((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
				((Selectable)KOOIPLLCLEK).colors = colors2;
			}
		}
	}

	private void PGKCFPOKHBO()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
		int CAJJGDHBKLI = -(int)((double)((Rect)(ref rect)).height * 486.0);
		LNEDBBANOKO(ThemeType.none, ref CAJJGDHBKLI);
		GHNALLMBLJG(ThemeType.basicMood, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.none, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.basicMood, ref CAJJGDHBKLI);
		GHNALLMBLJG(ThemeType.basicMoodAlt, ref CAJJGDHBKLI);
		LNEDBBANOKO((ThemeType)8, ref CAJJGDHBKLI);
	}

	public void KFGKHJCLIOH()
	{
		DAOLGJCIOCF.Sort();
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		BNFMMPOHHEK();
	}

	public void EFOMECDJLPJ()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.name)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.name;
		JLKHADGILNA(PENDBBEAGOL);
	}

	public void DPOKNLONFOA()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.name)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.intensity;
		GJLLBGPGENN(PENDBBEAGOL);
	}

	private int IGKGILGLCEP(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			string name = EEIOIFDPLCJ[OEEFMLJODNL].name;
			string name2 = EEIOIFDPLCJ[NJGCICCKOBK].name;
			return name.CompareTo(name2);
		}
		return 0;
	}

	public void OKECJKKBBEP()
	{
		_infoSectionSelection = InfoSectionSelection.list;
		FGBGKADHFLN();
		IOMHGDLCJFO(EJNKFELKPOL: true, MNPGCPOHEFE: true);
	}

	private void BECDDJLDIPA(BIAMLFLKEND LIDLBPMNIAA, ThemeInfo BHDDNPEGNCB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		LIDLBPMNIAA.themeNameText.text = BHDDNPEGNCB.name;
		LIDLBPMNIAA.intensitySlider.value = 101f;
		((Graphic)LIDLBPMNIAA.indicatorImage).color = OKHNJELEODE;
	}

	public void OnClick_StopMusicImmediately()
	{
		PsaiCore.Instance.StopMusic(immediately: true, EOEPAMLDFOB.value);
	}

	public void LGNNNHFKDDP()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo != null)
		{
			bool flag = psaiInfo.intensityIsHeld;
			PsaiCore.Instance.HoldCurrentIntensity(flag);
			if (flag)
			{
				ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
				((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
				((Selectable)KOOIPLLCLEK).colors = colors;
			}
			else
			{
				ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
				((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
				((Selectable)KOOIPLLCLEK).colors = colors2;
			}
		}
	}

	private void Awake()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			return;
		}
		DECIOBPIDPP = ((Component)this).gameObject.transform.Find("IntensitySectionCanvas/IntensitySection");
		FFHKAHJPFFL = ((Component)DECIOBPIDPP).transform.Find("IntensityBars");
		FOMOLIFJOOJ = ((Component)((Component)FFHKAHJPFFL).transform.Find("DynamicIntensity")).GetComponent<Slider>();
		OGIEJNNIFAL = ((Component)((Component)FFHKAHJPFFL).transform.Find("SegmentIntensity")).GetComponent<Slider>();
		BCJNJPIJLNP = ((Component)((Component)FOMOLIFJOOJ).transform.Find("Fill Area/Fill")).GetComponent<Image>();
		IEFMFOBGNCP = ((Component)((Component)FFHKAHJPFFL).transform.Find("DynamicIntensityValue")).GetComponent<Text>();
		BDNPNPCNNGN = ((Component)((Component)FFHKAHJPFFL).transform.Find("SegmentIntensityValue")).GetComponent<Text>();
		ELKMFEKJCOK = ((Component)((Component)OGIEJNNIFAL).transform.Find("Fill Area/Fill")).GetComponent<Image>();
		KNONFBPCJOL = ((Component)FFHKAHJPFFL).transform.Find("IntensityControls");
		KOOIPLLCLEK = ((Component)((Component)KNONFBPCJOL).transform.Find("ButtonHold")).GetComponent<Button>();
		ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
		JPALOCMOPHB = ((ColorBlock)(ref colors)).normalColor;
		colors = ((Selectable)KOOIPLLCLEK).colors;
		NBKEOKPMIHM = ((ColorBlock)(ref colors)).highlightedColor;
		BFJNAOCLEPO = ((Component)this).gameObject.transform.Find("ThemeTriggerCanvas");
		if (Object.op_Implicit((Object)(object)BFJNAOCLEPO))
		{
			GameObject gameObject = ((Component)((Component)BFJNAOCLEPO).transform.Find("ThemeTriggerSection")).gameObject;
			OJDOOLDAHKM = ((Component)gameObject.transform.Find("ScrollView")).gameObject;
			CANCJEBCHEL = ((Component)OJDOOLDAHKM.transform.Find("ErrorText")).gameObject.GetComponent<Text>();
			FKBDCFNHPPH = OJDOOLDAHKM.transform.Find("Content");
			GOBHBPAEGFH = ((Component)gameObject.transform.Find("ThemeTriggerPanelItemBlueprint")).gameObject;
			Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
			LMHIIGHLNNK = (int)((Rect)(ref rect)).height;
			GOBHBPAEGFH.SetActive(false);
			EOECEPHJKMO = ((Component)gameObject.transform.Find("ThemeTypeLabelBlueprint")).gameObject;
			EOECEPHJKMO.SetActive(false);
		}
		if ((Object)(object)((Component)this).gameObject.transform.Find("TooltipsCanvas") != (Object)null)
		{
			Transform val = ((Component)BFJNAOCLEPO).transform.Find("ToggleTooltips");
			if (Object.op_Implicit((Object)(object)val))
			{
				BBMPECMKJKP = ((Component)val).GetComponentInChildren<Toggle>();
				if ((Object)(object)BBMPECMKJKP != (Object)null && (Object)(object)TooltipView.Instance != (Object)null)
				{
					TooltipView.Instance.TurnedOn = BBMPECMKJKP.isOn;
				}
			}
		}
		EHJLFBCEHPA = ((Component)this).gameObject.transform.Find("EngineControlsCanvas/EngineControlSection");
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			AIKFADIAJMC.panelObject = ((Component)((Component)EHJLFBCEHPA).transform.Find("StopMusic")).gameObject;
			AIKFADIAJMC.bgImage = AIKFADIAJMC.panelObject.GetComponent<Image>();
			Text component = ((Component)AIKFADIAJMC.panelObject.transform.Find("Text")).GetComponent<Text>();
			GMACDCPHKOK = ((Component)((Component)EHJLFBCEHPA).transform.Find("StopMusic/ButtonImmediately")).gameObject;
			EPNHPDPOLDB = ((Component)((Component)EHJLFBCEHPA).transform.Find("StopMusic/ButtonEndSegment")).gameObject;
			Button val2 = EPNHPDPOLDB.GetComponentsInChildren<Button>(true)[0];
			Button val3 = GMACDCPHKOK.GetComponentsInChildren<Button>(true)[0];
			PDBHABOPHKF = ((Component)val2).GetComponent<Image>();
			Image component2 = ((Component)val3).GetComponent<Image>();
			AIKFADIAJMC.selectables.Add((Selectable)(object)val2);
			AIKFADIAJMC.selectables.Add((Selectable)(object)val3);
			AIKFADIAJMC.buttonBgImages.Add(PDBHABOPHKF);
			AIKFADIAJMC.buttonBgImages.Add(component2);
			Text componentInChildren = ((Component)val2).GetComponentInChildren<Text>();
			Text componentInChildren2 = ((Component)val3).GetComponentInChildren<Text>();
			AIKFADIAJMC.labelTexts.Add(component);
			AIKFADIAJMC.labelTexts.Add(componentInChildren);
			AIKFADIAJMC.labelTexts.Add(componentInChildren2);
			EOEPAMLDFOB = AIKFADIAJMC.panelObject.GetComponentInChildren<Slider>();
			Text item = ((Component)EOEPAMLDFOB).gameObject.GetComponentsInChildren<Text>()[0];
			MPDLEHMGKCI = ((Component)EOEPAMLDFOB).gameObject.GetComponentsInChildren<Text>()[1];
			AIKFADIAJMC.labelTexts.Add(MPDLEHMGKCI);
			AIKFADIAJMC.labelTexts.Add(item);
			PAECINCEJAG(EFOPEBJOGMO: false);
			JMANFHNLAFM.panelObject = ((Component)((Component)EHJLFBCEHPA).transform.Find("ReturnToBasicMood")).gameObject;
			JMANFHNLAFM.bgImage = JMANFHNLAFM.panelObject.GetComponent<Image>();
			Text component3 = ((Component)JMANFHNLAFM.panelObject.transform.Find("Text")).GetComponent<Text>();
			JMANFHNLAFM.labelTexts.Add(component3);
			Button val4 = ((Component)JMANFHNLAFM.panelObject.transform.Find("ButtonEndSegment")).GetComponentsInChildren<Button>(true)[0];
			Button val5 = ((Component)JMANFHNLAFM.panelObject.transform.Find("ButtonImmediately")).GetComponentsInChildren<Button>(true)[0];
			JMANFHNLAFM.selectables.Add((Selectable)(object)val4);
			JMANFHNLAFM.selectables.Add((Selectable)(object)val5);
			Image component4 = ((Component)val5).GetComponent<Image>();
			Image item2 = (OKPEOADPKEH = ((Component)val4).GetComponent<Image>());
			JMANFHNLAFM.buttonBgImages.Add(component4);
			JMANFHNLAFM.buttonBgImages.Add(item2);
			Text componentInChildren3 = ((Component)val4).GetComponentInChildren<Text>();
			Text componentInChildren4 = ((Component)val5).GetComponentInChildren<Text>();
			JMANFHNLAFM.labelTexts.Add(componentInChildren3);
			JMANFHNLAFM.labelTexts.Add(componentInChildren4);
			LFKJNAABHCB.panelObject = ((Component)((Component)EHJLFBCEHPA).transform.Find("Pause")).gameObject;
			LFKJNAABHCB.bgImage = LFKJNAABHCB.panelObject.GetComponent<Image>();
			DBILBLKADPP = ((Component)LFKJNAABHCB.panelObject.transform.Find("ButtonPause")).GetComponentsInChildren<Button>(true)[0];
			LFKJNAABHCB.selectables.Add((Selectable)(object)DBILBLKADPP);
			Image component5 = ((Component)DBILBLKADPP).GetComponent<Image>();
			LFKJNAABHCB.buttonBgImages.Add(component5);
			Image componentInChildren5 = ((Component)((Component)component5).transform).GetComponentInChildren<Image>();
			LFKJNAABHCB.buttonBgImages.Add(componentInChildren5);
			BNNGNGLIOID = ((Component)((Component)EHJLFBCEHPA).transform.Find("MenuMode")).gameObject;
			HKGKBCLKDJO = ((Component)BNNGNGLIOID.transform.Find("ThemeText")).GetComponentInChildren<Text>();
			KJOLOEJJHCE = ((Component)((Component)EHJLFBCEHPA).transform.Find("MenuMode/ButtonEnter")).GetComponent<Button>();
			JDJNOGEIINM = ((Component)((Component)KJOLOEJJHCE).transform).GetComponentsInChildren<Text>()[0];
			LDPPDBLGAOM = ((Component)((Component)EHJLFBCEHPA).transform.Find("MenuMode/ButtonConfigure")).GetComponent<Button>();
			IDJIOPFANPO = ((Component)((Component)EHJLFBCEHPA).transform.Find("CutSceneMode")).gameObject;
			IPKIKIOANCO = ((Component)IDJIOPFANPO.transform.Find("ThemeText")).GetComponentInChildren<Text>();
			FCCONPAFNLJ = ((Component)((Component)EHJLFBCEHPA).transform.Find("CutSceneMode/ButtonEnter")).GetComponent<Button>();
			FFPMLGKOIFO = ((Component)((Component)FCCONPAFNLJ).transform).GetComponentsInChildren<Text>()[0];
			JHHJMAIBGJK = ((Component)((Component)EHJLFBCEHPA).transform.Find("CutSceneMode/ButtonConfigure")).GetComponent<Button>();
			BHMHJBHCPHI = ((Component)((Component)JHHJMAIBGJK).transform).GetComponentsInChildren<Text>()[0];
		}
		NCMHKONJHKM = ((Component)this).gameObject.transform.Find("InfoSectionCanvas/InfoSection");
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM))
		{
			Transform val6 = ((Component)NCMHKONJHKM).transform.Find("ToggleGroup");
			HCEMOJOFKAD = ((Component)val6.Find("ToggleHideInfoSection")).GetComponent<Toggle>();
			EPBLBPGNFOK = ((Component)val6.Find("ToggleDescription")).GetComponent<Toggle>();
			NDDNBFKGDFF = ((Component)val6.Find("ToggleEntityView")).GetComponent<Toggle>();
			MFJFADACMFG = ((Component)val6.Find("ToggleListView")).GetComponent<Toggle>();
			JJFGNIKAHBG = ((Component)((Component)EHJLFBCEHPA).transform.Find("ToggleGroup/ToggleBasic")).GetComponentInChildren<Toggle>();
			FKLLIKPJLIE = ((Component)((Component)NCMHKONJHKM).transform.Find("CurrentThemeSection")).gameObject;
			ONNMNIEPECJ = ((Component)FKLLIKPJLIE.transform.Find("ValueName")).GetComponent<Text>();
			JNDNPGMGCGP = ((Component)FKLLIKPJLIE.transform.Find("ValueId")).GetComponent<Text>();
			JGEGPOADBFK = ((Component)FKLLIKPJLIE.transform.Find("ValueType")).GetComponent<Text>();
			JMPBDJFAOCI = ((Component)FKLLIKPJLIE.transform.Find("ValuePsaiState")).GetComponent<Text>();
			ONNOMMNOHLO = ((Component)((Component)NCMHKONJHKM).transform.Find("CurrentSegmentSection")).gameObject;
			PJGIOPBGFKL = ((Component)ONNOMMNOHLO.transform.Find("ValueName")).GetComponent<Text>();
			DDIJCKEENIK = ((Component)ONNOMMNOHLO.transform.Find("ValueId")).GetComponent<Text>();
			AFMKBIOENNH = ((Component)ONNOMMNOHLO.transform.Find("ValueIntensity")).GetComponent<Text>();
			IGLOJPJBOKG = ((Component)ONNOMMNOHLO.transform.Find("ValuePlaycount")).GetComponent<Text>();
			HJNNOBBGNOG = ((Component)ONNOMMNOHLO.transform.Find("ValueSuitabilities")).GetComponent<Text>();
			IGBNANDECPA = ((Component)ONNOMMNOHLO.transform.Find("ValueRemainingMs")).GetComponent<Text>();
			PHPFMGKMJIC = 10;
			KLHGALIFCKI = ((Component)((Component)NCMHKONJHKM).transform.Find("ThemeListView")).gameObject;
			ONMHIOLHLAJ = ((Component)KLHGALIFCKI.transform.Find("ThemeListScrollView")).gameObject;
			JGHCPOMJLEC = ((Component)ONMHIOLHLAJ.transform.Find("Content")).gameObject;
			GNEIFLDDAFH = ((Component)JGHCPOMJLEC.transform.Find("ListViewEntry")).gameObject;
			Text component6 = ((Component)GNEIFLDDAFH.transform.Find("Name")).GetComponent<Text>();
			EGMBPLLODNA = component6.font.lineHeight;
			HHHDCONJGPA = ((Component)((Component)NCMHKONJHKM).transform.Find("SegmentListView")).gameObject;
			HJMADJIKIED = ((Component)HHHDCONJGPA.transform.Find("SegmentListScrollView")).gameObject;
			JKKFGLEMMCC = ((Component)HJMADJIKIED.transform.Find("Content")).gameObject;
			HHIOGAKDJII = ((Component)JKKFGLEMMCC.transform.Find("ListViewEntry")).gameObject;
			IJOFEHPDAOO = ((Component)((Component)NCMHKONJHKM).transform.Find("SoundtrackDescriptionPanel")).gameObject;
			COEKDJHMKLP = ((Component)IJOFEHPDAOO.transform).GetComponentInChildren<Image>();
			Transform val7 = IJOFEHPDAOO.transform.Find("ScrollView/Content");
			KMMNHLNCPEH = ((Component)((Component)val7).transform.Find("TextPanel/Headline")).GetComponentInChildren<Text>();
			DKAGBBHIKOL = ((Component)((Component)val7).transform.Find("TextPanel/Description")).GetComponentInChildren<Text>();
		}
		FKLJCEOBKMK();
	}

	public void NENMBOOBDPE()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.intensity)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.suitabilites;
		GJLLBGPGENN(GIBJHJMCEHC());
	}

	private int LPPKDJGNFAM(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 1;
	}

	private void LNEDBBANOKO(ThemeType AFBMADOPDEN, ref int CAJJGDHBKLI)
	{
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		List<int> list = JBLOCOPHGOJ[AFBMADOPDEN];
		if (list.Count > 0)
		{
			int bBJGJBGONJN = BBJGJBGONJN;
			GameObject obj = Object.Instantiate<GameObject>(EOECEPHJKMO);
			obj.SetActive(true);
			obj.transform.SetParent(((Component)FKBDCFNHPPH).transform);
			obj.GetComponent<Text>().text = Theme.ThemeTypeToString(AFBMADOPDEN);
			((RectTransform)obj.transform).anchoredPosition = new Vector2((float)bBJGJBGONJN, (float)CAJJGDHBKLI);
			bBJGJBGONJN = HKPGOHGMFCH;
			for (int i = 0; i < list.Count; i++)
			{
				int num = list[i];
				BIAMLFLKEND bIAMLFLKEND = new BIAMLFLKEND(GOBHBPAEGFH);
				LJKIFLAKNME[bIAMLFLKEND] = num;
				AIJOBKFPCPB[bIAMLFLKEND.goButton] = num;
				HBOLHNEKMNM[num] = bIAMLFLKEND.intensitySlider;
				OKKFOEGMIHK[((Component)bIAMLFLKEND.intensitySlider).gameObject] = num;
				LAHGLCMFFBA[num] = bIAMLFLKEND;
				bIAMLFLKEND.goTriggerItemRoot.transform.SetParent(((Component)FKBDCFNHPPH).transform);
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				PKMEAPMFHMD(bIAMLFLKEND, themeInfo);
				RectTransform val = (RectTransform)bIAMLFLKEND.goTriggerItemRoot.transform;
				val.anchoredPosition = new Vector2((float)bBJGJBGONJN, (float)CAJJGDHBKLI);
				int num2 = bBJGJBGONJN;
				Rect rect = val.rect;
				bBJGJBGONJN = num2 + (int)((Rect)(ref rect)).width;
				if (i < list.Count - 1)
				{
					int num3 = bBJGJBGONJN;
					int width = Screen.width;
					rect = val.rect;
					if (num3 > width - (int)((Rect)(ref rect)).width)
					{
						bBJGJBGONJN = HKPGOHGMFCH;
						CAJJGDHBKLI -= LMHIIGHLNNK;
						continue;
					}
				}
				bBJGJBGONJN += PHPFMGKMJIC;
			}
			bBJGJBGONJN = HKPGOHGMFCH;
			CAJJGDHBKLI -= LMHIIGHLNNK + PHPFMGKMJIC;
		}
		((RectTransform)((Component)FKBDCFNHPPH).transform).sizeDelta = new Vector2((float)(Screen.width - HKPGOHGMFCH), (float)(-CAJJGDHBKLI));
	}

	public void OnClick_CutSceneConfigureOrLeaveSmoothly()
	{
		if (!PsaiCore.Instance.CutSceneIsActive())
		{
			PLMILDKBMMM = !PLMILDKBMMM;
		}
		else
		{
			PsaiCore.Instance.CutSceneLeave(immediately: false, reset: false);
		}
		ODINENEBAML();
	}

	public void COBPGNEGOGE()
	{
		_infoSectionSelection = InfoSectionSelection.list;
		CAHGAACDJJM();
		EDIPKLEAMOI(EJNKFELKPOL: false, MNPGCPOHEFE: true);
	}

	private void EDIPKLEAMOI(bool EJNKFELKPOL, bool MNPGCPOHEFE)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		for (int i = 0; i < AAKIEBABABB.Count; i++)
		{
			ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
			((Graphic)aBECBBMHPED.textName).color = IBHDALEEEOL;
			if (psaiInfo.psaiState == PsaiState.playing && !psaiInfo.paused)
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = false;
			}
			else
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = true;
			}
			if (aBECBBMHPED.segmentId == currentSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.green;
				if (MNPGCPOHEFE)
				{
					int num = EGMBPLLODNA * i;
					((RectTransform)JKKFGLEMMCC.transform).anchoredPosition = new Vector2(0f, (float)num);
				}
				if (EJNKFELKPOL)
				{
					SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
					aBECBBMHPED.textPlaycount.text = segmentInfo.playcount.ToString();
				}
			}
			else if (aBECBBMHPED.segmentId == psaiInfo.targetSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.yellow;
			}
			else
			{
				((Graphic)aBECBBMHPED.backgroundImage).color = Color.clear;
			}
			if (EKBMCKPKCCH.ContainsKey(aBECBBMHPED.segmentId))
			{
				((Graphic)aBECBBMHPED.textName).color = HMGBONEBFNF;
			}
		}
		BKPENKANIHI();
	}

	public void DBLONIPJCOD()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.name)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.suitabilites;
		JLKHADGILNA(PENDBBEAGOL);
	}

	public void MGJBLABBBCD()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.name)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.name;
		GJLLBGPGENN(PENDBBEAGOL);
	}

	private void EHDPEOHJEPP()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		if (EEIOIFDPLCJ.Count > 0)
		{
			ThemeInfo themeInfo = null;
			foreach (ThemeInfo value in EEIOIFDPLCJ.Values)
			{
				if (themeInfo == null || value.segmentIds.Length > themeInfo.segmentIds.Length)
				{
					themeInfo = value;
				}
			}
			int num = 0;
			((RectTransform)JKKFGLEMMCC.transform).sizeDelta = new Vector2(((RectTransform)JKKFGLEMMCC.transform).sizeDelta.x, (float)(EGMBPLLODNA * themeInfo.segmentIds.Length));
			AAKIEBABABB.Clear();
			int[] segmentIds = themeInfo.segmentIds;
			foreach (int num2 in segmentIds)
			{
				ABECBBMHPED aBECBBMHPED = new ABECBBMHPED();
				num -= EGMBPLLODNA;
				GameObject val = Object.Instantiate<GameObject>(HHIOGAKDJII);
				val.transform.SetParent(JKKFGLEMMCC.transform);
				((RectTransform)val.transform).anchoredPosition = new Vector2(((RectTransform)HHIOGAKDJII.transform).anchoredPosition.x, (float)num);
				((RectTransform)val.transform).offsetMax = new Vector2(0f, ((RectTransform)val.transform).offsetMax.y);
				aBECBBMHPED.backgroundImage = val.GetComponent<Image>();
				aBECBBMHPED.gameObj = val;
				GameObject gameObject = ((Component)val.transform.GetChild(0)).gameObject;
				aBECBBMHPED.textName = ((Component)gameObject.transform).GetComponent<Text>();
				GameObject gameObject2 = ((Component)val.transform.GetChild(1)).gameObject;
				aBECBBMHPED.textSuitabilities = ((Component)gameObject2.transform).GetComponent<Text>();
				GameObject gameObject3 = ((Component)val.transform.GetChild(2)).gameObject;
				aBECBBMHPED.textLength = ((Component)gameObject3.transform).GetComponent<Text>();
				GameObject gameObject4 = ((Component)val.transform.GetChild(3)).gameObject;
				aBECBBMHPED.textIntensity = ((Component)gameObject4.transform).GetComponent<Text>();
				GameObject gameObject5 = ((Component)val.transform.GetChild(4)).gameObject;
				aBECBBMHPED.textPlaycount = ((Component)gameObject5.transform).GetComponent<Text>();
				AAKIEBABABB.Add(aBECBBMHPED);
				aBECBBMHPED.textName.text = num2.ToString();
			}
		}
		HHIOGAKDJII.SetActive(false);
	}

	public void FMCMABJAEEL()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.name)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.name;
		JLKHADGILNA(PENDBBEAGOL);
	}

	public void GGAPHBHADAO()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo != null)
		{
			bool flag = !psaiInfo.intensityIsHeld;
			PsaiCore.Instance.HoldCurrentIntensity(flag);
			if (flag)
			{
				ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
				((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
				((Selectable)KOOIPLLCLEK).colors = colors;
			}
			else
			{
				ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
				((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
				((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
				((Selectable)KOOIPLLCLEK).colors = colors2;
			}
		}
	}

	private void HAAFEFNOPNB()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		foreach (HKOHBBEAOKE item in FJJPIJALCBH)
		{
			if (item.themeId == PENDBBEAGOL)
			{
				((Graphic)item.backgroundImage).color = GGKMBGGKECK;
			}
			else
			{
				((Graphic)item.backgroundImage).color = Color.clear;
			}
		}
	}

	public void GDBMPAHFOEN()
	{
		PsaiCore.Instance.ReturnToLastBasicMood(immediately: true);
	}

	private void GHMIBEJIDJB()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		foreach (HKOHBBEAOKE item in FJJPIJALCBH)
		{
			if (item.themeId == GIBJHJMCEHC())
			{
				((Graphic)item.backgroundImage).color = GGKMBGGKECK;
			}
			else
			{
				((Graphic)item.backgroundImage).color = Color.clear;
			}
		}
	}

	public void OnClick_ToggleTooltips()
	{
		if ((Object)(object)BBMPECMKJKP != (Object)null)
		{
			TooltipView.Instance.TurnedOn = !TooltipView.Instance.TurnedOn;
		}
	}

	public void NCJMOIGKOAJ()
	{
		PsaiCore.Instance.AddToCurrentIntensity(0f - _addToIntensityStepsize);
	}

	public void OnClick_SegmentHeaderLength()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.length)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.length;
		JLKHADGILNA(PENDBBEAGOL);
	}

	private void PAECINCEJAG(bool EFOPEBJOGMO)
	{
		NLEAEDIEOEN = EFOPEBJOGMO;
		((Component)EOEPAMLDFOB).gameObject.SetActive(NLEAEDIEOEN);
		GMACDCPHKOK.gameObject.SetActive(!NLEAEDIEOEN);
		EPNHPDPOLDB.gameObject.SetActive(!NLEAEDIEOEN);
	}

	private int FLIBOEKNAAD(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			ThemeType type = EEIOIFDPLCJ[OEEFMLJODNL].type;
			ThemeType type2 = EEIOIFDPLCJ[NJGCICCKOBK].type;
			return type.CompareTo(type2);
		}
		return 1;
	}

	public void OBAOMCCDDJG()
	{
		if (EOEPAMLDFOB.value == 514f)
		{
			EOEPAMLDFOB.value = 1336f;
		}
		MPDLEHMGKCI.text = string.Format("MainProgress", EOEPAMLDFOB.value.ToString("Segments"));
	}

	private void NHMEJDEAEFG(bool EFOPEBJOGMO)
	{
		NLEAEDIEOEN = EFOPEBJOGMO;
		((Component)EOEPAMLDFOB).gameObject.SetActive(NLEAEDIEOEN);
		GMACDCPHKOK.gameObject.SetActive(!NLEAEDIEOEN);
		EPNHPDPOLDB.gameObject.SetActive(!NLEAEDIEOEN);
	}

	public void BCCKJECBEEB()
	{
		DAOLGJCIOCF.Sort(PMNDLICIFNF);
		FMLFJANKMJH = !FMLFJANKMJH;
		if (!FMLFJANKMJH)
		{
			DAOLGJCIOCF.Reverse();
		}
		CCCLLKEFDFL();
	}

	public void IEIHLMKHACF()
	{
		if (GGBMPGLICFO == (DGOBMCJLBEA)5)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = (DGOBMCJLBEA)7;
		GJLLBGPGENN(GIBJHJMCEHC());
	}

	public void OnChange_ThemeIntensitySlider(GameObject ADINOAOHPBG)
	{
		if (OKKFOEGMIHK.ContainsKey(ADINOAOHPBG))
		{
			int key = OKKFOEGMIHK[ADINOAOHPBG];
			int num = (int)(HBOLHNEKMNM[key].value * 100f);
			LAHGLCMFFBA[key].textIntensityValue.text = num + " %";
		}
	}

	private void IOMHGDLCJFO(bool EJNKFELKPOL, bool MNPGCPOHEFE)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		for (int i = 0; i < AAKIEBABABB.Count; i++)
		{
			ABECBBMHPED aBECBBMHPED = AAKIEBABABB[i];
			((Graphic)aBECBBMHPED.textName).color = IBHDALEEEOL;
			if (psaiInfo.psaiState == (PsaiState)7 && !psaiInfo.paused)
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = true;
			}
			else
			{
				((Selectable)((Component)aBECBBMHPED.textName).GetComponent<Button>()).interactable = false;
			}
			if (aBECBBMHPED.segmentId == currentSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.green;
				if (MNPGCPOHEFE)
				{
					int num = EGMBPLLODNA * i;
					((RectTransform)JKKFGLEMMCC.transform).anchoredPosition = new Vector2(678f, (float)num);
				}
				if (EJNKFELKPOL)
				{
					SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
					aBECBBMHPED.textPlaycount.text = segmentInfo.playcount.ToString();
				}
			}
			else if (aBECBBMHPED.segmentId == psaiInfo.targetSegmentId)
			{
				((Graphic)aBECBBMHPED.textName).color = Color.yellow;
			}
			else
			{
				((Graphic)aBECBBMHPED.backgroundImage).color = Color.clear;
			}
			if (EKBMCKPKCCH.ContainsKey(aBECBBMHPED.segmentId))
			{
				((Graphic)aBECBBMHPED.textName).color = HMGBONEBFNF;
			}
		}
		BKPENKANIHI();
	}

	public void KPJNPOLJAOK()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.intensity)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.length;
		GJLLBGPGENN(GIBJHJMCEHC());
	}

	private void AHJPHGIJDJN(BIAMLFLKEND LIDLBPMNIAA, ThemeInfo BHDDNPEGNCB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		LIDLBPMNIAA.themeNameText.text = BHDDNPEGNCB.name;
		LIDLBPMNIAA.intensitySlider.value = 906f;
		((Graphic)LIDLBPMNIAA.indicatorImage).color = OKHNJELEODE;
	}

	[SpecialName]
	private void CDLPHAKMCLD(int AODONKKHPBP)
	{
		AHPAGCFDCIL = AODONKKHPBP;
		IHDJCNDCGHB();
		JLKHADGILNA(AHPAGCFDCIL);
	}

	private void LKEHGPDMDLK()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)KLHGALIFCKI))
		{
			return;
		}
		int num = (int)((RectTransform)JGHCPOMJLEC.transform).anchoredPosition.y;
		Rect rect = ((RectTransform)ONMHIOLHLAJ.transform).rect;
		int num2 = (int)((Rect)(ref rect)).height;
		if (FJJPIJALCBH != null)
		{
			for (int i = 0; i < FJJPIJALCBH.Count; i++)
			{
				HKOHBBEAOKE hKOHBBEAOKE = FJJPIJALCBH[i];
				int num3 = EGMBPLLODNA * i;
				bool active = num3 - num > -EGMBPLLODNA * 2 && num3 - num < num2 - EGMBPLLODNA;
				hKOHBBEAOKE.gameObj.SetActive(active);
			}
		}
	}

	private int IGHDHBACLBF(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 0;
	}

	public void OnClick_AddToCurrentIntensityMinus()
	{
		PsaiCore.Instance.AddToCurrentIntensity(0f - _addToIntensityStepsize);
	}

	public void OOPHONLEFIK()
	{
		PsaiCore.Instance.ReturnToLastBasicMood(immediately: true);
	}

	private int NJOGOOOONCM(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			ThemeType type = EEIOIFDPLCJ[OEEFMLJODNL].type;
			ThemeType type2 = EEIOIFDPLCJ[NJGCICCKOBK].type;
			return type.CompareTo(type2);
		}
		return 1;
	}

	public void CJGLADHDPEM()
	{
		if (!PsaiCore.Instance.CutSceneIsActive())
		{
			PsaiCore.Instance.CutSceneEnter(DLGCPNODNDD, BCGDNDLFMDI);
		}
		else
		{
			PsaiCore.Instance.CutSceneLeave(immediately: true, reset: true);
		}
		KNDEHDOGMMJ();
	}

	public void OnClick_ToggleEntityView()
	{
		_infoSectionSelection = InfoSectionSelection.entity;
		FGBGKADHFLN();
		EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: true);
	}

	public void EGBNJLINNDO()
	{
		if (!PsaiCore.Instance.CutSceneIsActive())
		{
			PsaiCore.Instance.CutSceneEnter(DLGCPNODNDD, BCGDNDLFMDI);
		}
		else
		{
			PsaiCore.Instance.CutSceneLeave(immediately: false, reset: false);
		}
		LPNHGANIDHF();
	}

	public void GPNKABKEEFC()
	{
		PsaiCore.Instance.StopMusic(immediately: true);
	}

	public void EPJIOFFNBHJ()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.name)
		{
			GAEOFBJKFPP = GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.suitabilites;
		JLKHADGILNA(GIBJHJMCEHC());
	}

	private void OPMEOADMCNI()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		CFEPPBKCOFN.Clear();
		FJJPIJALCBH.Clear();
		int num = 1;
		((RectTransform)JGHCPOMJLEC.transform).sizeDelta = new Vector2(((RectTransform)JGHCPOMJLEC.transform).sizeDelta.x, (float)(EGMBPLLODNA * EEIOIFDPLCJ.Count));
		for (int i = 1; i < DAOLGJCIOCF.Count; i++)
		{
			int key = DAOLGJCIOCF[i];
			ThemeInfo themeInfo = EEIOIFDPLCJ[key];
			num -= EGMBPLLODNA;
			HKOHBBEAOKE hKOHBBEAOKE = new HKOHBBEAOKE();
			hKOHBBEAOKE.themeId = themeInfo.id;
			hKOHBBEAOKE.gameObj = Object.Instantiate<GameObject>(GNEIFLDDAFH);
			hKOHBBEAOKE.gameObj.transform.SetParent(JGHCPOMJLEC.transform);
			((RectTransform)hKOHBBEAOKE.gameObj.transform).anchoredPosition = new Vector2(686f, (float)num);
			((RectTransform)hKOHBBEAOKE.gameObj.transform).offsetMax = new Vector2(1328f, ((RectTransform)hKOHBBEAOKE.gameObj.transform).offsetMax.y);
			hKOHBBEAOKE.backgroundImage = ((Component)hKOHBBEAOKE.gameObj.transform).GetComponent<Image>();
			GameObject nameTextObject = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(1)).gameObject;
			hKOHBBEAOKE.textName = ((Component)nameTextObject.transform).GetComponent<Text>();
			CFEPPBKCOFN[nameTextObject] = themeInfo.id;
			((UnityEvent)nameTextObject.gameObject.GetComponent<Button>().onClick).AddListener((UnityAction)delegate
			{
				OnClick_ThemeListViewEntry(nameTextObject);
			});
			GameObject gameObject = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(1)).gameObject;
			hKOHBBEAOKE.textThemeId = ((Component)gameObject.transform).GetComponent<Text>();
			GameObject gameObject2 = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(0)).gameObject;
			hKOHBBEAOKE.textThemeType = ((Component)gameObject2.transform).GetComponent<Text>();
			FJJPIJALCBH.Add(hKOHBBEAOKE);
		}
		GNEIFLDDAFH.SetActive(true);
	}

	private void OLHEOBOEIHL()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)KLHGALIFCKI))
		{
			return;
		}
		int num = (int)((RectTransform)((Component)FKBDCFNHPPH).transform).anchoredPosition.y;
		Rect rect = ((RectTransform)OJDOOLDAHKM.transform).rect;
		int num2 = (int)((Rect)(ref rect)).height;
		foreach (BIAMLFLKEND key in LJKIFLAKNME.Keys)
		{
			float y = ((RectTransform)key.goTriggerItemRoot.transform).anchoredPosition.y;
			bool active = !(0f - y - (float)num > (float)(-LMHIIGHLNNK)) || 0f - y - (float)num < (float)num2;
			key.goTriggerItemRoot.SetActive(active);
		}
	}

	private int LJCHFHBJALL(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 1;
	}

	private void LKBLICPJJEK()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == PsaiState.playing)
		{
			AIKFADIAJMC.FFPHAAKHMOH(NCLCPJJOGKN: true);
			JMANFHNLAFM.FFPHAAKHMOH(NCLCPJJOGKN: true);
			LFKJNAABHCB.FFPHAAKHMOH(NCLCPJJOGKN: true);
			if (psaiInfo.upcomingPsaiState == PsaiState.silence)
			{
				((Graphic)PDBHABOPHKF).color = new Color(0.5f + 0.5f * JPFLKEKIJFP, 0.5f + 0.5f * JPFLKEKIJFP, 0f, 1f);
			}
			else
			{
				((Graphic)PDBHABOPHKF).color = JFFEAJAPDEE;
			}
			if (psaiInfo.returningToLastBasicMood)
			{
				((Graphic)OKPEOADPKEH).color = new Color(0.5f + 0.5f * JPFLKEKIJFP, 0.5f + 0.5f * JPFLKEKIJFP, 0f, 1f);
			}
			else
			{
				((Graphic)OKPEOADPKEH).color = JFFEAJAPDEE;
			}
		}
		else if (IFMPMJCLPJG != psaiInfo.psaiState)
		{
			AIKFADIAJMC.FFPHAAKHMOH(NCLCPJJOGKN: false);
			JMANFHNLAFM.FFPHAAKHMOH(NCLCPJJOGKN: false);
			LFKJNAABHCB.FFPHAAKHMOH(NCLCPJJOGKN: false);
		}
		if (PsaiCore.Instance.GetPsaiInfo().paused)
		{
			ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
			((ColorBlock)(ref colors)).normalColor = INGAIPBMEJJ;
			((ColorBlock)(ref colors)).highlightedColor = MEBFLBOONFH;
			((Selectable)DBILBLKADPP).colors = colors;
		}
		else
		{
			ColorBlock colors2 = ((Selectable)KOOIPLLCLEK).colors;
			((ColorBlock)(ref colors2)).normalColor = JPALOCMOPHB;
			((ColorBlock)(ref colors2)).highlightedColor = NBKEOKPMIHM;
			((Selectable)DBILBLKADPP).colors = colors2;
		}
	}

	private void CCCLLKEFDFL()
	{
		for (int i = 1; i < DAOLGJCIOCF.Count; i += 0)
		{
			int num = DAOLGJCIOCF[i];
			HKOHBBEAOKE hKOHBBEAOKE = FJJPIJALCBH[i];
			ThemeInfo themeInfo = EEIOIFDPLCJ[num];
			hKOHBBEAOKE.textName.text = themeInfo.name;
			hKOHBBEAOKE.textThemeId.text = themeInfo.id.ToString();
			hKOHBBEAOKE.textThemeType.text = Theme.ThemeTypeToString(themeInfo.type);
			hKOHBBEAOKE.themeId = num;
			CFEPPBKCOFN[((Component)hKOHBBEAOKE.textName).gameObject] = themeInfo.id;
		}
	}

	private void ADFEBKCHAAJ(BIAMLFLKEND LIDLBPMNIAA, ThemeInfo BHDDNPEGNCB)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		LIDLBPMNIAA.themeNameText.text = BHDDNPEGNCB.name;
		LIDLBPMNIAA.intensitySlider.value = 1024f;
		((Graphic)LIDLBPMNIAA.indicatorImage).color = OKHNJELEODE;
	}

	private int CDCKANHDLFP(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 0;
	}

	public void OnClick_MenuModeEnterOrLeave()
	{
		if (!PsaiCore.Instance.MenuModeIsActive())
		{
			PsaiCore.Instance.MenuModeEnter(LMDAPBIDHHH, EIFPPOHECEI);
		}
		else
		{
			PsaiCore.Instance.MenuModeLeave();
		}
		UpdateMenuModeSection();
	}

	public void OnClick_SegmentListViewEntry(GameObject ADINOAOHPBG)
	{
		if (BFDMFCELLEE.ContainsKey(ADINOAOHPBG))
		{
			int num = BFDMFCELLEE[ADINOAOHPBG];
			PsaiCore.Instance.PlaySegment(num);
			BGFAGOIMMON(num);
			EDIPKLEAMOI(EJNKFELKPOL: true, MNPGCPOHEFE: true);
		}
	}

	public void OnClick_SegmentHeaderPlaycount()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.playcount)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.playcount;
		JLKHADGILNA(PENDBBEAGOL);
	}

	private void CAHGAACDJJM()
	{
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(PsaiCore.Instance.GetCurrentThemeId());
		SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
		if (themeInfo != null)
		{
			ONNMNIEPECJ.text = themeInfo.name;
			JNDNPGMGCGP.text = themeInfo.id.ToString();
			JGEGPOADBFK.text = Theme.ThemeTypeToString(themeInfo.type);
		}
		else
		{
			ONNMNIEPECJ.text = "Items/item_description_1179";
			JNDNPGMGCGP.text = "Master is Loading. Waiting...";
			JGEGPOADBFK.text = "Items/item_description_702";
		}
		JMPBDJFAOCI.text = psaiInfo.psaiState.ToString();
		if (segmentInfo != null && currentSegmentId != -1)
		{
			PJGIOPBGFKL.text = segmentInfo.name;
			DDIJCKEENIK.text = segmentInfo.id.ToString();
			AFMKBIOENNH.text = segmentInfo.intensity.ToString("Argos");
			IGLOJPJBOKG.text = segmentInfo.playcount.ToString();
			HJNNOBBGNOG.text = Segment.GetStringFromSegmentSuitabilities(segmentInfo.segmentSuitabilitiesBitfield);
			IGBNANDECPA.text = PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback().ToString();
		}
		else
		{
			PJGIOPBGFKL.text = "Victory";
			DDIJCKEENIK.text = "Items/item_description_629";
			AFMKBIOENNH.text = "Player2";
			IGLOJPJBOKG.text = "Tutorial/T";
			HJNNOBBGNOG.text = "itemWheatAle";
			IGBNANDECPA.text = "Peek";
		}
		if (psaiInfo.remainingMillisecondsInRestMode > 1)
		{
			string text = "Price sell" + psaiInfo.remainingMillisecondsInRestMode;
			JMPBDJFAOCI.text = psaiInfo.psaiState.ToString() + text;
		}
		else
		{
			JMPBDJFAOCI.text = psaiInfo.psaiState.ToString();
		}
	}

	private int EDHDAAFKFAC(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 0;
	}

	private void OBEJFGCCGFP()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
		int CAJJGDHBKLI = -(int)((double)((Rect)(ref rect)).height * 1517.0);
		LNEDBBANOKO(ThemeType.none, ref CAJJGDHBKLI);
		HIKEAELKBGG(ThemeType.basicMood, ref CAJJGDHBKLI);
		LNEDBBANOKO((ThemeType)4, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.basicMoodAlt, ref CAJJGDHBKLI);
		LNEDBBANOKO(ThemeType.basicMoodAlt, ref CAJJGDHBKLI);
		GHNALLMBLJG((ThemeType)4, ref CAJJGDHBKLI);
	}

	public void KMCGNHHGPCP()
	{
		if (PsaiCore.Instance.MenuModeIsActive())
		{
			JDJNOGEIINM.text = "OnlinePlayer";
			((Selectable)LDPPDBLGAOM).interactable = true;
		}
		else
		{
			JDJNOGEIINM.text = "Items/item_description_635";
			((Selectable)LDPPDBLGAOM).interactable = false;
		}
	}

	private void MPGPLILIJOD()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			return;
		}
		DECIOBPIDPP = ((Component)this).gameObject.transform.Find("Comfort");
		FFHKAHJPFFL = ((Component)DECIOBPIDPP).transform.Find("Floor_2");
		FOMOLIFJOOJ = ((Component)((Component)FFHKAHJPFFL).transform.Find("")).GetComponent<Slider>();
		OGIEJNNIFAL = ((Component)((Component)FFHKAHJPFFL).transform.Find("ChangeAnim")).GetComponent<Slider>();
		BCJNJPIJLNP = ((Component)((Component)FOMOLIFJOOJ).transform.Find("\n")).GetComponent<Image>();
		IEFMFOBGNCP = ((Component)((Component)FFHKAHJPFFL).transform.Find("Dialogue System/Conversation/Crowly_Standar/Entry/48/Dialogue Text")).GetComponent<Text>();
		BDNPNPCNNGN = ((Component)((Component)FFHKAHJPFFL).transform.Find("Eat")).GetComponent<Text>();
		ELKMFEKJCOK = ((Component)((Component)OGIEJNNIFAL).transform.Find("Tutorial/T131/Dialogue1")).GetComponent<Image>();
		KNONFBPCJOL = ((Component)FFHKAHJPFFL).transform.Find(" seconds.");
		KOOIPLLCLEK = ((Component)((Component)KNONFBPCJOL).transform.Find("Dig")).GetComponent<Button>();
		ColorBlock colors = ((Selectable)KOOIPLLCLEK).colors;
		JPALOCMOPHB = ((ColorBlock)(ref colors)).normalColor;
		colors = ((Selectable)KOOIPLLCLEK).colors;
		NBKEOKPMIHM = ((ColorBlock)(ref colors)).highlightedColor;
		BFJNAOCLEPO = ((Component)this).gameObject.transform.Find("Plant");
		if (Object.op_Implicit((Object)(object)BFJNAOCLEPO))
		{
			GameObject gameObject = ((Component)((Component)BFJNAOCLEPO).transform.Find("Items/item_description_1107")).gameObject;
			OJDOOLDAHKM = ((Component)gameObject.transform.Find("ReceiveUpdateBentoOnTray")).gameObject;
			CANCJEBCHEL = ((Component)OJDOOLDAHKM.transform.Find("BuzzCanModify")).gameObject.GetComponent<Text>();
			FKBDCFNHPPH = OJDOOLDAHKM.transform.Find("KlaynTakingDrink: No barrel found for drink request: ");
			GOBHBPAEGFH = ((Component)gameObject.transform.Find("enchantedBroom")).gameObject;
			Rect rect = ((RectTransform)GOBHBPAEGFH.transform).rect;
			LMHIIGHLNNK = (int)((Rect)(ref rect)).height;
			GOBHBPAEGFH.SetActive(true);
			EOECEPHJKMO = ((Component)gameObject.transform.Find(" is not supported by CanvasScreenSpaceScaler")).gameObject;
			EOECEPHJKMO.SetActive(false);
		}
		if ((Object)(object)((Component)this).gameObject.transform.Find("Get Components ") != (Object)null)
		{
			Transform val = ((Component)BFJNAOCLEPO).transform.Find("UI2");
			if (Object.op_Implicit((Object)(object)val))
			{
				BBMPECMKJKP = ((Component)val).GetComponentInChildren<Toggle>();
				if ((Object)(object)BBMPECMKJKP != (Object)null && (Object)(object)TooltipView.Instance != (Object)null)
				{
					TooltipView.Instance.TurnedOn = BBMPECMKJKP.isOn;
				}
			}
		}
		EHJLFBCEHPA = ((Component)this).gameObject.transform.Find("");
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			AIKFADIAJMC.panelObject = ((Component)((Component)EHJLFBCEHPA).transform.Find("tutorialPopUp80")).gameObject;
			AIKFADIAJMC.bgImage = AIKFADIAJMC.panelObject.GetComponent<Image>();
			Text component = ((Component)AIKFADIAJMC.panelObject.transform.Find("OnAnimationFinished")).GetComponent<Text>();
			GMACDCPHKOK = ((Component)((Component)EHJLFBCEHPA).transform.Find("<br/>Graphics Device Version: ")).gameObject;
			EPNHPDPOLDB = ((Component)((Component)EHJLFBCEHPA).transform.Find(" ")).gameObject;
			Button val2 = EPNHPDPOLDB.GetComponentsInChildren<Button>(false)[1];
			Button val3 = GMACDCPHKOK.GetComponentsInChildren<Button>(true)[1];
			PDBHABOPHKF = ((Component)val2).GetComponent<Image>();
			Image component2 = ((Component)val3).GetComponent<Image>();
			AIKFADIAJMC.selectables.Add((Selectable)(object)val2);
			AIKFADIAJMC.selectables.Add((Selectable)(object)val3);
			AIKFADIAJMC.buttonBgImages.Add(PDBHABOPHKF);
			AIKFADIAJMC.buttonBgImages.Add(component2);
			Text componentInChildren = ((Component)val2).GetComponentInChildren<Text>();
			Text componentInChildren2 = ((Component)val3).GetComponentInChildren<Text>();
			AIKFADIAJMC.labelTexts.Add(component);
			AIKFADIAJMC.labelTexts.Add(componentInChildren);
			AIKFADIAJMC.labelTexts.Add(componentInChildren2);
			EOEPAMLDFOB = AIKFADIAJMC.panelObject.GetComponentInChildren<Slider>();
			Text item = ((Component)EOEPAMLDFOB).gameObject.GetComponentsInChildren<Text>()[0];
			MPDLEHMGKCI = ((Component)EOEPAMLDFOB).gameObject.GetComponentsInChildren<Text>()[0];
			AIKFADIAJMC.labelTexts.Add(MPDLEHMGKCI);
			AIKFADIAJMC.labelTexts.Add(item);
			NMBEPENMNKG(EFOPEBJOGMO: true);
			JMANFHNLAFM.panelObject = ((Component)((Component)EHJLFBCEHPA).transform.Find("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/10/Dialogue Text")).gameObject;
			JMANFHNLAFM.bgImage = JMANFHNLAFM.panelObject.GetComponent<Image>();
			Text component3 = ((Component)JMANFHNLAFM.panelObject.transform.Find("CharacterChanged")).GetComponent<Text>();
			JMANFHNLAFM.labelTexts.Add(component3);
			Button val4 = ((Component)JMANFHNLAFM.panelObject.transform.Find("PlayerCharacterNameChangeRPC")).GetComponentsInChildren<Button>(true)[0];
			Button val5 = ((Component)JMANFHNLAFM.panelObject.transform.Find("Left Stick Up")).GetComponentsInChildren<Button>(true)[0];
			JMANFHNLAFM.selectables.Add((Selectable)(object)val4);
			JMANFHNLAFM.selectables.Add((Selectable)(object)val5);
			Image component4 = ((Component)val5).GetComponent<Image>();
			Image item2 = (OKPEOADPKEH = ((Component)val4).GetComponent<Image>());
			JMANFHNLAFM.buttonBgImages.Add(component4);
			JMANFHNLAFM.buttonBgImages.Add(item2);
			Text componentInChildren3 = ((Component)val4).GetComponentInChildren<Text>();
			Text componentInChildren4 = ((Component)val5).GetComponentInChildren<Text>();
			JMANFHNLAFM.labelTexts.Add(componentInChildren3);
			JMANFHNLAFM.labelTexts.Add(componentInChildren4);
			LFKJNAABHCB.panelObject = ((Component)((Component)EHJLFBCEHPA).transform.Find("Harvest")).gameObject;
			LFKJNAABHCB.bgImage = LFKJNAABHCB.panelObject.GetComponent<Image>();
			DBILBLKADPP = ((Component)LFKJNAABHCB.panelObject.transform.Find("LE_15")).GetComponentsInChildren<Button>(true)[0];
			LFKJNAABHCB.selectables.Add((Selectable)(object)DBILBLKADPP);
			Image component5 = ((Component)DBILBLKADPP).GetComponent<Image>();
			LFKJNAABHCB.buttonBgImages.Add(component5);
			Image componentInChildren5 = ((Component)((Component)component5).transform).GetComponentInChildren<Image>();
			LFKJNAABHCB.buttonBgImages.Add(componentInChildren5);
			BNNGNGLIOID = ((Component)((Component)EHJLFBCEHPA).transform.Find("Setup ")).gameObject;
			HKGKBCLKDJO = ((Component)BNNGNGLIOID.transform.Find("ReceiveIncreaseLevel")).GetComponentInChildren<Text>();
			KJOLOEJJHCE = ((Component)((Component)EHJLFBCEHPA).transform.Find("Current crafting:")).GetComponent<Button>();
			JDJNOGEIINM = ((Component)((Component)KJOLOEJJHCE).transform).GetComponentsInChildren<Text>()[0];
			LDPPDBLGAOM = ((Component)((Component)EHJLFBCEHPA).transform.Find("ReceiveCreateNewOrderQuest")).GetComponent<Button>();
			IDJIOPFANPO = ((Component)((Component)EHJLFBCEHPA).transform.Find("Chilly")).gameObject;
			IPKIKIOANCO = ((Component)IDJIOPFANPO.transform.Find("TavernInConstruction")).GetComponentInChildren<Text>();
			FCCONPAFNLJ = ((Component)((Component)EHJLFBCEHPA).transform.Find("SetAnimatorObjectFloatRPC")).GetComponent<Button>();
			FFPMLGKOIFO = ((Component)((Component)FCCONPAFNLJ).transform).GetComponentsInChildren<Text>()[1];
			JHHJMAIBGJK = ((Component)((Component)EHJLFBCEHPA).transform.Find("ClosePopUp")).GetComponent<Button>();
			BHMHJBHCPHI = ((Component)((Component)JHHJMAIBGJK).transform).GetComponentsInChildren<Text>()[0];
		}
		NCMHKONJHKM = ((Component)this).gameObject.transform.Find("Fortitude/MainEvent 2");
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM))
		{
			Transform val6 = ((Component)NCMHKONJHKM).transform.Find("Tutorial/T119/Dialogue1");
			HCEMOJOFKAD = ((Component)val6.Find("You have to use the PixelPerfectCamera script on the assigned UI camera!")).GetComponent<Toggle>();
			EPBLBPGNFOK = ((Component)val6.Find("[Awning] OnTriggerSet called. Hash: {0} | OpenHash: {1} | CloseHash: {2}")).GetComponent<Toggle>();
			NDDNBFKGDFF = ((Component)val6.Find("")).GetComponent<Toggle>();
			MFJFADACMFG = ((Component)val6.Find("LucenGrab")).GetComponent<Toggle>();
			JJFGNIKAHBG = ((Component)((Component)EHJLFBCEHPA).transform.Find("BARKBUZZ")).GetComponentInChildren<Toggle>();
			FKLLIKPJLIE = ((Component)((Component)NCMHKONJHKM).transform.Find("Plant")).gameObject;
			ONNMNIEPECJ = ((Component)FKLLIKPJLIE.transform.Find("HaveGoldenTicket")).GetComponent<Text>();
			JNDNPGMGCGP = ((Component)FKLLIKPJLIE.transform.Find("Player2")).GetComponent<Text>();
			JGEGPOADBFK = ((Component)FKLLIKPJLIE.transform.Find("per room")).GetComponent<Text>();
			JMPBDJFAOCI = ((Component)FKLLIKPJLIE.transform.Find("Stand")).GetComponent<Text>();
			ONNOMMNOHLO = ((Component)((Component)NCMHKONJHKM).transform.Find("NPCWalkTo is null in NPCRoutine. Make sure the routine ")).gameObject;
			PJGIOPBGFKL = ((Component)ONNOMMNOHLO.transform.Find("BirdInteract")).GetComponent<Text>();
			DDIJCKEENIK = ((Component)ONNOMMNOHLO.transform.Find("Items/item_name_1090")).GetComponent<Text>();
			AFMKBIOENNH = ((Component)ONNOMMNOHLO.transform.Find("Items/item_description_1077")).GetComponent<Text>();
			IGLOJPJBOKG = ((Component)ONNOMMNOHLO.transform.Find("Open")).GetComponent<Text>();
			HJNNOBBGNOG = ((Component)ONNOMMNOHLO.transform.Find("Floor")).GetComponent<Text>();
			IGBNANDECPA = ((Component)ONNOMMNOHLO.transform.Find("\n")).GetComponent<Text>();
			PHPFMGKMJIC = -10;
			KLHGALIFCKI = ((Component)((Component)NCMHKONJHKM).transform.Find("itemColiflowerSeeds")).gameObject;
			ONMHIOLHLAJ = ((Component)KLHGALIFCKI.transform.Find("Christmas Event activated: ")).gameObject;
			JGHCPOMJLEC = ((Component)ONMHIOLHLAJ.transform.Find("[ControllerType:")).gameObject;
			GNEIFLDDAFH = ((Component)JGHCPOMJLEC.transform.Find("Information")).gameObject;
			Text component6 = ((Component)GNEIFLDDAFH.transform.Find("DismissWorker?")).GetComponent<Text>();
			EGMBPLLODNA = component6.font.lineHeight;
			HHHDCONJGPA = ((Component)((Component)NCMHKONJHKM).transform.Find("dForDays")).gameObject;
			HJMADJIKIED = ((Component)HHHDCONJGPA.transform.Find("")).gameObject;
			JKKFGLEMMCC = ((Component)HJMADJIKIED.transform.Find("Deserialize SettingsData error: /ExtraSettings.sd")).gameObject;
			HHIOGAKDJII = ((Component)JKKFGLEMMCC.transform.Find("[Player2Name]")).gameObject;
			IJOFEHPDAOO = ((Component)((Component)NCMHKONJHKM).transform.Find("Player/Bark/Error/NotAllPlayersHere")).gameObject;
			COEKDJHMKLP = ((Component)IJOFEHPDAOO.transform).GetComponentInChildren<Image>();
			Transform val7 = IJOFEHPDAOO.transform.Find("ReceiveFoodSlotFromContainer");
			KMMNHLNCPEH = ((Component)((Component)val7).transform.Find("UISelectGamepad")).GetComponentInChildren<Text>();
			DKAGBBHIKOL = ((Component)((Component)val7).transform.Find("[MineVariantsSelector] All variants excluded for piece {0}. Regenerating pool.")).GetComponentInChildren<Text>();
		}
		FKLJCEOBKMK();
	}

	private int COJJBHDMNFG(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 0;
	}

	public void ILOAKMNNBOG()
	{
		if ((Object)(object)BBMPECMKJKP != (Object)null)
		{
			TooltipView.Instance.TurnedOn = TooltipView.Instance.TurnedOn;
		}
	}

	[SpecialName]
	private void CCOGEDLMOFD(int AODONKKHPBP)
	{
		AHPAGCFDCIL = AODONKKHPBP;
		IHDJCNDCGHB();
		GJLLBGPGENN(AHPAGCFDCIL);
	}

	public void KKCFKJMDEEF(GameObject ADINOAOHPBG)
	{
		if (CFEPPBKCOFN.ContainsKey(ADINOAOHPBG))
		{
			int aODONKKHPBP = CFEPPBKCOFN[ADINOAOHPBG];
			CDLPHAKMCLD(aODONKKHPBP);
		}
		else
		{
			Debug.LogError((object)("yForYears" + (object)ADINOAOHPBG));
		}
	}

	public void HJODONFAEAC()
	{
		PsaiCore.Instance.StopMusic(immediately: false, EOEPAMLDFOB.value);
	}

	private void LPNHGANIDHF()
	{
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			string text = (EIFPPOHECEI * 1674f).ToString();
			string text2 = (BCGDNDLFMDI * 969f).ToString();
			Text hKGKBCLKDJO = HKGKBCLKDJO;
			string[] array = new string[3];
			array[1] = "Next Reward";
			array[1] = LMDAPBIDHHH.ToString();
			array[0] = "KyrohNPC: Selected order with already ingredients in bento: ";
			array[0] = text;
			array[2] = "Are you sure to change all buttons to default values?";
			hKGKBCLKDJO.text = string.Concat(array);
			Text iPKIKIOANCO = IPKIKIOANCO;
			string[] array2 = new string[2];
			array2[1] = "Fertile soil object not found at ";
			array2[0] = DLGCPNODNDD.ToString();
			array2[2] = "Festín del Juramento/PresentacionMaestros 01";
			array2[8] = text2;
			array2[2] = "Dialogue System/Conversation/Gass_Introduce/Entry/17/Dialogue Text";
			iPKIKIOANCO.text = string.Concat(array2);
			if (PsaiCore.Instance.CutSceneIsActive())
			{
				FFPMLGKOIFO.text = "Sleep";
				BHMHJBHCPHI.text = "TermasInterior/Rin/Stand";
			}
			else
			{
				FFPMLGKOIFO.text = "(";
				BHMHJBHCPHI.text = "Sleep";
			}
		}
	}

	private int BMEBBBGFGCJ(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 0;
	}

	public void OnClick_ReturnToLastBasicMoodByEndSegment()
	{
		PsaiCore.Instance.ReturnToLastBasicMood(immediately: false);
	}

	private void BMPCNKDLEEK()
	{
		if (Object.op_Implicit((Object)(object)EHJLFBCEHPA) && ((Component)EHJLFBCEHPA).gameObject.activeInHierarchy)
		{
			((Component)EHJLFBCEHPA).gameObject.SetActive(true);
			AIKFADIAJMC.panelObject.SetActive(!KDGLBAKGOJB);
			JMANFHNLAFM.panelObject.SetActive(!KDGLBAKGOJB);
			BNNGNGLIOID.SetActive(KDGLBAKGOJB);
			IDJIOPFANPO.SetActive(KDGLBAKGOJB);
			LFKJNAABHCB.panelObject.SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)NCMHKONJHKM) && ((Component)NCMHKONJHKM).gameObject.activeInHierarchy)
		{
			((Component)NCMHKONJHKM).gameObject.SetActive(true);
			FKLLIKPJLIE.SetActive(true);
			ONNOMMNOHLO.SetActive(true);
			HHHDCONJGPA.SetActive(true);
			KLHGALIFCKI.SetActive(true);
			IJOFEHPDAOO.SetActive(true);
			switch (_infoSectionSelection)
			{
			case InfoSectionSelection.entity:
				ONNOMMNOHLO.SetActive(true);
				FKLLIKPJLIE.SetActive(false);
				break;
			case InfoSectionSelection.list:
				HHHDCONJGPA.SetActive(false);
				KLHGALIFCKI.SetActive(false);
				break;
			case InfoSectionSelection.description:
				IJOFEHPDAOO.SetActive(false);
				break;
			case InfoSectionSelection.log:
				break;
			}
		}
	}

	public void EGNJMHBJBMN()
	{
		if (EOEPAMLDFOB.value == 1500f)
		{
			EOEPAMLDFOB.value = 1568f;
		}
		MPDLEHMGKCI.text = string.Format("ChangeAnim", EOEPAMLDFOB.value.ToString("save"));
	}

	private void BMHPADPGLMI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)KLHGALIFCKI))
		{
			return;
		}
		int num = (int)((RectTransform)((Component)FKBDCFNHPPH).transform).anchoredPosition.y;
		Rect rect = ((RectTransform)OJDOOLDAHKM.transform).rect;
		int num2 = (int)((Rect)(ref rect)).height;
		foreach (BIAMLFLKEND key in LJKIFLAKNME.Keys)
		{
			float y = ((RectTransform)key.goTriggerItemRoot.transform).anchoredPosition.y;
			bool active = 0f - y - (float)num > (float)(-LMHIIGHLNNK) && 0f - y - (float)num < (float)num2;
			key.goTriggerItemRoot.SetActive(active);
		}
	}

	public void NEOJAALCGAJ()
	{
		if (GGBMPGLICFO == DGOBMCJLBEA.suitabilites)
		{
			GAEOFBJKFPP = !GAEOFBJKFPP;
		}
		GGBMPGLICFO = DGOBMCJLBEA.suitabilites;
		GJLLBGPGENN(PENDBBEAGOL);
	}

	private void NMBEPENMNKG(bool EFOPEBJOGMO)
	{
		NLEAEDIEOEN = EFOPEBJOGMO;
		((Component)EOEPAMLDFOB).gameObject.SetActive(NLEAEDIEOEN);
		GMACDCPHKOK.gameObject.SetActive(!NLEAEDIEOEN);
		EPNHPDPOLDB.gameObject.SetActive(NLEAEDIEOEN);
	}

	public void BLMIBGLBPDP()
	{
		NLEAEDIEOEN = NLEAEDIEOEN;
		PAECINCEJAG(NLEAEDIEOEN);
	}

	public void OnClick_ConfigureMenuMode()
	{
		JLMPLMGIFKN = !JLMPLMGIFKN;
	}

	private void JELHFILLMOO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		CFEPPBKCOFN.Clear();
		FJJPIJALCBH.Clear();
		int num = 0;
		((RectTransform)JGHCPOMJLEC.transform).sizeDelta = new Vector2(((RectTransform)JGHCPOMJLEC.transform).sizeDelta.x, (float)(EGMBPLLODNA * EEIOIFDPLCJ.Count));
		for (int i = 0; i < DAOLGJCIOCF.Count; i++)
		{
			int key = DAOLGJCIOCF[i];
			ThemeInfo themeInfo = EEIOIFDPLCJ[key];
			num -= EGMBPLLODNA;
			HKOHBBEAOKE hKOHBBEAOKE = new HKOHBBEAOKE();
			hKOHBBEAOKE.themeId = themeInfo.id;
			hKOHBBEAOKE.gameObj = Object.Instantiate<GameObject>(GNEIFLDDAFH);
			hKOHBBEAOKE.gameObj.transform.SetParent(JGHCPOMJLEC.transform);
			((RectTransform)hKOHBBEAOKE.gameObj.transform).anchoredPosition = new Vector2(0f, (float)num);
			((RectTransform)hKOHBBEAOKE.gameObj.transform).offsetMax = new Vector2(0f, ((RectTransform)hKOHBBEAOKE.gameObj.transform).offsetMax.y);
			hKOHBBEAOKE.backgroundImage = ((Component)hKOHBBEAOKE.gameObj.transform).GetComponent<Image>();
			GameObject nameTextObject = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(0)).gameObject;
			hKOHBBEAOKE.textName = ((Component)nameTextObject.transform).GetComponent<Text>();
			CFEPPBKCOFN[nameTextObject] = themeInfo.id;
			((UnityEvent)nameTextObject.gameObject.GetComponent<Button>().onClick).AddListener((UnityAction)delegate
			{
				OnClick_ThemeListViewEntry(nameTextObject);
			});
			GameObject gameObject = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(1)).gameObject;
			hKOHBBEAOKE.textThemeId = ((Component)gameObject.transform).GetComponent<Text>();
			GameObject gameObject2 = ((Component)hKOHBBEAOKE.gameObj.transform.GetChild(2)).gameObject;
			hKOHBBEAOKE.textThemeType = ((Component)gameObject2.transform).GetComponent<Text>();
			FJJPIJALCBH.Add(hKOHBBEAOKE);
		}
		GNEIFLDDAFH.SetActive(false);
	}

	[SpecialName]
	private int GIBJHJMCEHC()
	{
		return AHPAGCFDCIL;
	}

	public void MEGGMFCHMGA()
	{
		_infoSectionSelection = InfoSectionSelection.list;
		FGBGKADHFLN();
		CHICOLOMEPC(EJNKFELKPOL: false, MNPGCPOHEFE: true);
	}

	private int MFCPPKMCFCJ(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 0;
	}

	public void KJPCNELGFNJ()
	{
		_infoSectionSelection = (InfoSectionSelection)8;
		JLBGFFGPNEG();
	}
}
