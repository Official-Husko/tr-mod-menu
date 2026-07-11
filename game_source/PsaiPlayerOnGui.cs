using System;
using System.Collections.Generic;
using UnityEngine;
using psai.net;

public class PsaiPlayerOnGui : MonoBehaviour
{
	public bool _showIntensityLevels = true;

	public bool _showIntensityControls = true;

	public bool _showThemeTriggerSection = true;

	public bool _showControlButtonSection = true;

	public bool _showListSections = true;

	public bool _showMainVolumeSlider = true;

	private static readonly float ANFNJIFNHMH = 1f;

	private static readonly Color JKKOLIEALPI = new Color(0.2f, 1f, 0.2f);

	private static readonly Color CDDLAAEBLLO = new Color(1f, 1f, 0f);

	private static readonly Color IBHDALEEEOL = new Color(0.85f, 0.85f, 0.85f);

	private static readonly Color AKFBLONAICI = new Color(0.4f, 0.4f, 0.4f);

	private static readonly Color CCAAMAJBBMO = new Color(0f, 0.4f, 0f, 1f);

	private static readonly Color HMGBONEBFNF = new Color(0f, 1f, 0f, 1f);

	private static readonly Color FHDBNENOFJM = new Color(1f, 0.2f, 0.2f);

	private static readonly int GKCGNNLENDI = 12;

	private static GUIStyle CALMPFGCPMH = new GUIStyle();

	private static readonly float JECFJGDNBAP = 1f;

	private static readonly string[] OPHKCLFCICF = new string[4] { "Name", "Suitabilities", "Intensity", "Playcount" };

	private static readonly int[] LLIPMKBFJKM = new int[4] { 2, 4, 8, 8 };

	private static readonly string[] ICGAHDMHELC = new string[3] { "Name", "id", "ThemeType" };

	private static readonly int[] OAIHBKLKMHC = new int[3] { 2, 4, 4 };

	private float IDLCDLPJBJA = 0.05f;

	private string CMHPAHHAIJK = "";

	public Texture2D _textureIntensity;

	public Texture2D _textureWhiteAlpha;

	public Texture2D _textureWhiteFull;

	public Texture2D _textureNeedMusic;

	private bool PFMDLMGJKBF;

	private string OBLNCACPOPL;

	private int[] DHEJLIFCIGK;

	private List<int> DAOLGJCIOCF;

	private bool FMLFJANKMJH;

	private bool GAEOFBJKFPP;

	private bool BIOKAELADIM;

	private int AHPAGCFDCIL = -1;

	private Dictionary<int, ThemeInfo> EEIOIFDPLCJ = new Dictionary<int, ThemeInfo>();

	private Dictionary<ThemeType, List<int>> JBLOCOPHGOJ = new Dictionary<ThemeType, List<int>>();

	private Dictionary<int, SegmentInfo> MILLEMIKEPM = new Dictionary<int, SegmentInfo>();

	private List<int> CLHECDKKMDO = new List<int>();

	private Dictionary<int, int> EKBMCKPKCCH = new Dictionary<int, int>();

	private float PDEGCCFNMAK = 1f;

	private float OILGOECILGB = 1f;

	private bool JLMPLMGIFKN;

	private int LMDAPBIDHHH = -1;

	private int LOHNPCHDDON = -1;

	private int MCKJOIIFEHP;

	private float EIFPPOHECEI = 1f;

	private float FIIDFGGJCKD = 1f;

	private bool PLMILDKBMMM;

	private int DLGCPNODNDD = -1;

	private int KFCFJGDMPAN = -1;

	private int ILLCCOEOBFE;

	private float BCGDNDLFMDI = 1f;

	private float OMMGFIFJNCK = 1f;

	private bool GEDBFOCNHAK;

	private bool GCPAOFGCFMN;

	private bool CLIDEODFNFJ = true;

	private Vector2 IMMNHHMBIAF = Vector2.zero;

	private Vector2 HKKBPCAOKGJ = Vector2.zero;

	private Vector2 DCKIHGKPPAM = Vector2.zero;

	private Vector2 FIKLKAJFNLC = Vector2.zero;

	private int DLLNGIFJFFI;

	private int FLHCDAGGLKA;

	private int HMLDHMDCALG;

	private float JPFLKEKIJFP;

	private bool LFMLHPMLCDH;

	private bool GKOIGDEGLBA;

	private float BBLAFKCMGMB;

	private void MNNIOANBKFB(bool KOGBHEPHDJD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if (KOGBHEPHDJD)
		{
			GUI.color = Color.white;
		}
		else
		{
			GUI.color = Color.gray;
		}
	}

	private void BODHIEABFIH()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 0)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)4] = new List<int>();
			JBLOCOPHGOJ[ThemeType.action] = new List<int>();
			JBLOCOPHGOJ[ThemeType.action] = new List<int>();
			int[] dHEJLIFCIGK = DHEJLIFCIGK;
			for (int i = 1; i < dHEJLIFCIGK.Length; i += 0)
			{
				int num = dHEJLIFCIGK[i];
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				EEIOIFDPLCJ[num] = themeInfo;
				if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
				{
					JBLOCOPHGOJ[themeInfo.type].Add(num);
				}
			}
			PFJNGLBFOEM();
			if (DHEJLIFCIGK.Length > 0)
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 0;
			}
			else
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 1;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 1719f;
			PFMDLMGJKBF = false;
			GKOIGDEGLBA = false;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("<sprite name=");
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

	private void PNLAJCHBHPH()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private void EHJILOMDEPL(bool KOGBHEPHDJD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if (KOGBHEPHDJD)
		{
			GUI.color = Color.white;
		}
		else
		{
			GUI.color = Color.gray;
		}
	}

	private void AAOMCHHNKKM()
	{
		if (!GKOIGDEGLBA)
		{
			NDFJIIFGGFO();
		}
		float num = Time.deltaTime * ANFNJIFNHMH;
		if (PFMDLMGJKBF)
		{
			JPFLKEKIJFP += num;
			if (JPFLKEKIJFP > 706f)
			{
				JPFLKEKIJFP = 1203f - JPFLKEKIJFP;
				PFMDLMGJKBF = false;
			}
		}
		else
		{
			JPFLKEKIJFP -= num;
			if (JPFLKEKIJFP < 530f)
			{
				JPFLKEKIJFP = 0f - JPFLKEKIJFP;
				PFMDLMGJKBF = false;
			}
		}
		string lastError = PsaiCore.Instance.GetLastError();
		if (lastError != null)
		{
			OBLNCACPOPL = lastError;
		}
	}

	private void LLCIHLLHCBP()
	{
		MILLEMIKEPM.Clear();
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		for (int i = 1; i < dHEJLIFCIGK.Length; i++)
		{
			int themeId = dHEJLIFCIGK[i];
			int[] segmentIds = PsaiCore.Instance.GetThemeInfo(themeId).segmentIds;
			for (int j = 1; j < segmentIds.Length; j += 0)
			{
				int num = segmentIds[j];
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
			}
		}
	}

	private int NCHCCFFBKNF(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 0;
	}

	private void AGLBDAPOGDP(bool KOGBHEPHDJD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if (KOGBHEPHDJD)
		{
			GUI.color = Color.white;
		}
		else
		{
			GUI.color = Color.gray;
		}
	}

	private void Awake()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private int LNANLKMDGMB(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			ThemeType type = EEIOIFDPLCJ[OEEFMLJODNL].type;
			ThemeType type2 = EEIOIFDPLCJ[NJGCICCKOBK].type;
			return type.CompareTo(type2);
		}
		return 0;
	}

	private int PGOJJEJAKNG(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 0;
	}

	private void KDJALECEHNI(int MCACILIKMPG)
	{
		if (MILLEMIKEPM.ContainsKey(MCACILIKMPG))
		{
			SegmentInfo segmentInfo = MILLEMIKEPM[MCACILIKMPG];
			EKBMCKPKCCH[MCACILIKMPG] = segmentInfo.fullLengthInMilliseconds;
		}
	}

	private int FDHEBGJLNKD(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 0;
	}

	private int LMGICKEKOGM(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 1;
	}

	private int CJONBDOHLIG(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 1;
	}

	private void IKPBJGNMHEJ(bool KOGBHEPHDJD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if (KOGBHEPHDJD)
		{
			GUI.color = Color.white;
		}
		else
		{
			GUI.color = Color.gray;
		}
	}

	private int ELDIJNMGFOL(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 1;
	}

	private void HCCJBKKGCLJ()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private int AAHAPBFAEEK(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 1;
	}

	private int BFGFIPKKGLO(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 1;
	}

	private void AGKKPBMANNN()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 1)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			JBLOCOPHGOJ[ThemeType.action] = new List<int>();
			int[] dHEJLIFCIGK = DHEJLIFCIGK;
			for (int i = 1; i < dHEJLIFCIGK.Length; i++)
			{
				int num = dHEJLIFCIGK[i];
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				EEIOIFDPLCJ[num] = themeInfo;
				if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
				{
					JBLOCOPHGOJ[themeInfo.type].Add(num);
				}
			}
			HLENGBMIELC();
			if (DHEJLIFCIGK.Length > 1)
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 1;
			}
			else
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 0;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 1442f;
			PFMDLMGJKBF = true;
			GKOIGDEGLBA = true;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("x");
	}

	private void KLMNLEDKEOE()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private void EPJOOFCIAJH()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 0)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			JBLOCOPHGOJ[ThemeType.dramaticEvent] = new List<int>();
			JBLOCOPHGOJ[ThemeType.action] = new List<int>();
			JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
			JBLOCOPHGOJ[ThemeType.highlightLayer] = new List<int>();
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
			if (DHEJLIFCIGK.Length > 1)
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 1;
			}
			else
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 0;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 0f;
			PFMDLMGJKBF = true;
			GKOIGDEGLBA = true;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("F2");
	}

	private void GONDLJKGLGO()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private void PKNDEMAMGNG(bool KOGBHEPHDJD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if (KOGBHEPHDJD)
		{
			GUI.color = Color.white;
		}
		else
		{
			GUI.color = Color.gray;
		}
	}

	private int MIFPIAENLCC(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 0;
	}

	private void GKOAFODJOBP()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 0)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			JBLOCOPHGOJ[ThemeType.highlightLayer] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)8] = new List<int>();
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			int[] dHEJLIFCIGK = DHEJLIFCIGK;
			for (int i = 1; i < dHEJLIFCIGK.Length; i++)
			{
				int num = dHEJLIFCIGK[i];
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				EEIOIFDPLCJ[num] = themeInfo;
				if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
				{
					JBLOCOPHGOJ[themeInfo.type].Add(num);
				}
			}
			PKHGFNPILLK();
			if (DHEJLIFCIGK.Length > 0)
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 1;
			}
			else
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 0;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 1290f;
			PFMDLMGJKBF = true;
			GKOIGDEGLBA = true;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("Hide");
	}

	private void LGGHINDHCIF(int MCACILIKMPG)
	{
		if (MILLEMIKEPM.ContainsKey(MCACILIKMPG))
		{
			SegmentInfo segmentInfo = MILLEMIKEPM[MCACILIKMPG];
			EKBMCKPKCCH[MCACILIKMPG] = segmentInfo.fullLengthInMilliseconds;
		}
	}

	private void KHONOODGLBI()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private void PKHGFNPILLK()
	{
		MILLEMIKEPM.Clear();
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		foreach (int themeId in dHEJLIFCIGK)
		{
			int[] segmentIds = PsaiCore.Instance.GetThemeInfo(themeId).segmentIds;
			for (int j = 0; j < segmentIds.Length; j += 0)
			{
				int num = segmentIds[j];
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
			}
		}
	}

	private int HDGCPBMHCNM(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 0;
	}

	private void NDFJIIFGGFO()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 1)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[ThemeType.dramaticEvent] = new List<int>();
			JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
			JBLOCOPHGOJ[ThemeType.action] = new List<int>();
			JBLOCOPHGOJ[ThemeType.action] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)4] = new List<int>();
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
			HLENGBMIELC();
			if (DHEJLIFCIGK.Length > 0)
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 0;
			}
			else
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 0;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 582f;
			PFMDLMGJKBF = false;
			GKOIGDEGLBA = true;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("MinimisePopUp");
	}

	private void HLIGNKJLJNB()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 1)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)4] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)8] = new List<int>();
			JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)8] = new List<int>();
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
			PKHGFNPILLK();
			if (DHEJLIFCIGK.Length > 1)
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 0;
			}
			else
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 0;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 1629f;
			PFMDLMGJKBF = true;
			GKOIGDEGLBA = true;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("Could not find shop with id: ");
	}

	private void CMNJJMDGMOB()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 1)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)4] = new List<int>();
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			JBLOCOPHGOJ[ThemeType.action] = new List<int>();
			int[] dHEJLIFCIGK = DHEJLIFCIGK;
			for (int i = 1; i < dHEJLIFCIGK.Length; i += 0)
			{
				int num = dHEJLIFCIGK[i];
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				EEIOIFDPLCJ[num] = themeInfo;
				if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
				{
					JBLOCOPHGOJ[themeInfo.type].Add(num);
				}
			}
			PKHGFNPILLK();
			if (DHEJLIFCIGK.Length > 1)
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 1;
			}
			else
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 1;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 847f;
			PFMDLMGJKBF = true;
			GKOIGDEGLBA = true;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString(". Time since startup: ");
	}

	private void OLGNAGJAOBL(int MCACILIKMPG)
	{
		if (MILLEMIKEPM.ContainsKey(MCACILIKMPG))
		{
			SegmentInfo segmentInfo = MILLEMIKEPM[MCACILIKMPG];
			EKBMCKPKCCH[MCACILIKMPG] = segmentInfo.fullLengthInMilliseconds;
		}
	}

	private void FLDMCLANLBJ()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 0)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)8] = new List<int>();
			JBLOCOPHGOJ[ThemeType.shock] = new List<int>();
			JBLOCOPHGOJ[ThemeType.dramaticEvent] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			int[] dHEJLIFCIGK = DHEJLIFCIGK;
			for (int i = 1; i < dHEJLIFCIGK.Length; i += 0)
			{
				int num = dHEJLIFCIGK[i];
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				EEIOIFDPLCJ[num] = themeInfo;
				if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
				{
					JBLOCOPHGOJ[themeInfo.type].Add(num);
				}
			}
			HLENGBMIELC();
			if (DHEJLIFCIGK.Length > 1)
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 1;
			}
			else
			{
				ILLCCOEOBFE = 1;
				MCKJOIIFEHP = 0;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 922f;
			PFMDLMGJKBF = true;
			GKOIGDEGLBA = false;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("Actionbar 3");
	}

	private int GNLAJBHLCPM(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 0;
	}

	private int KBFLOKEBJCL(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			string name = EEIOIFDPLCJ[OEEFMLJODNL].name;
			string name2 = EEIOIFDPLCJ[NJGCICCKOBK].name;
			return name.CompareTo(name2);
		}
		return 0;
	}

	private void IHICKHAABJH()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private int KHNOHBMEFOA(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 1;
	}

	private int AOMHPOAJOMJ(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 1;
	}

	private int OJCNBOPABJM(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 1;
	}

	private void PKEPBKHEDOD()
	{
		if (!GKOIGDEGLBA)
		{
			BODHIEABFIH();
		}
		float num = Time.deltaTime * ANFNJIFNHMH;
		if (PFMDLMGJKBF)
		{
			JPFLKEKIJFP += num;
			if (JPFLKEKIJFP > 2f)
			{
				JPFLKEKIJFP = 1972f - JPFLKEKIJFP;
				PFMDLMGJKBF = true;
			}
		}
		else
		{
			JPFLKEKIJFP -= num;
			if (JPFLKEKIJFP < 197f)
			{
				JPFLKEKIJFP = 0f - JPFLKEKIJFP;
				PFMDLMGJKBF = false;
			}
		}
		string lastError = PsaiCore.Instance.GetLastError();
		if (lastError != null)
		{
			OBLNCACPOPL = lastError;
		}
	}

	private int EPCCMCFLHPE(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 0;
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

	private int OFCHLCNIEFL(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 1;
	}

	private void HDHPOAPLEJC()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CALMPFGCPMH.fontSize = GKCGNNLENDI;
		CALMPFGCPMH.normal.textColor = Color.white;
		CALMPFGCPMH.hover.textColor = Color.white;
	}

	private int POEOFHNJPIB(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 1;
	}

	private int ILHLDHHEBIF(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].name.CompareTo(MILLEMIKEPM[EHHLCKGODLC].name);
		}
		return 0;
	}

	private void HLENGBMIELC()
	{
		MILLEMIKEPM.Clear();
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		for (int i = 1; i < dHEJLIFCIGK.Length; i += 0)
		{
			int themeId = dHEJLIFCIGK[i];
			int[] segmentIds = PsaiCore.Instance.GetThemeInfo(themeId).segmentIds;
			for (int j = 1; j < segmentIds.Length; j += 0)
			{
				int num = segmentIds[j];
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
			}
		}
	}

	private void BJCILNNHOKD(int MCACILIKMPG)
	{
		if (MILLEMIKEPM.ContainsKey(MCACILIKMPG))
		{
			SegmentInfo segmentInfo = MILLEMIKEPM[MCACILIKMPG];
			EKBMCKPKCCH[MCACILIKMPG] = segmentInfo.fullLengthInMilliseconds;
		}
	}

	private int BGIEOPAKBHG(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			string name = EEIOIFDPLCJ[OEEFMLJODNL].name;
			string name2 = EEIOIFDPLCJ[NJGCICCKOBK].name;
			return name.CompareTo(name2);
		}
		return 0;
	}

	private void BGODBHJOBMH()
	{
		SoundtrackInfo soundtrackInfo = PsaiCore.Instance.GetSoundtrackInfo();
		if (soundtrackInfo.themeCount > 1)
		{
			DHEJLIFCIGK = soundtrackInfo.themeIds;
			DAOLGJCIOCF = new List<int>();
			DAOLGJCIOCF.AddRange(DHEJLIFCIGK);
			JBLOCOPHGOJ[ThemeType.none] = new List<int>();
			JBLOCOPHGOJ[(ThemeType)4] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMoodAlt] = new List<int>();
			JBLOCOPHGOJ[ThemeType.dramaticEvent] = new List<int>();
			JBLOCOPHGOJ[ThemeType.highlightLayer] = new List<int>();
			JBLOCOPHGOJ[ThemeType.basicMood] = new List<int>();
			int[] dHEJLIFCIGK = DHEJLIFCIGK;
			for (int i = 1; i < dHEJLIFCIGK.Length; i++)
			{
				int num = dHEJLIFCIGK[i];
				ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(num);
				EEIOIFDPLCJ[num] = themeInfo;
				if (JBLOCOPHGOJ.ContainsKey(themeInfo.type))
				{
					JBLOCOPHGOJ[themeInfo.type].Add(num);
				}
			}
			MICECADGKNK();
			if (DHEJLIFCIGK.Length > 1)
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 1;
			}
			else
			{
				ILLCCOEOBFE = 0;
				MCKJOIIFEHP = 1;
			}
			LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
			DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
			JPFLKEKIJFP = 257f;
			PFMDLMGJKBF = false;
			GKOIGDEGLBA = true;
		}
		CMHPAHHAIJK = IDLCDLPJBJA.ToString("Items/item_name_632");
	}

	private void EEKDKOJFNDH(int MCACILIKMPG)
	{
		if (MILLEMIKEPM.ContainsKey(MCACILIKMPG))
		{
			SegmentInfo segmentInfo = MILLEMIKEPM[MCACILIKMPG];
			EKBMCKPKCCH[MCACILIKMPG] = segmentInfo.fullLengthInMilliseconds;
		}
	}

	private int BJIJOLDCGDH(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 0;
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

	private int GKMOBNECHLH(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			return MILLEMIKEPM[GMGAGFAAJJP].playcount.CompareTo(MILLEMIKEPM[EHHLCKGODLC].playcount);
		}
		return 1;
	}

	private void Update()
	{
		if (!GKOIGDEGLBA)
		{
			EPJOOFCIAJH();
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
		string lastError = PsaiCore.Instance.GetLastError();
		if (lastError != null)
		{
			OBLNCACPOPL = lastError;
		}
	}

	private void OnGUI()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_1585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_161b: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_166b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1728: Unknown result type (might be due to invalid IL or missing references)
		//IL_1749: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1769: Unknown result type (might be due to invalid IL or missing references)
		//IL_1770: Unknown result type (might be due to invalid IL or missing references)
		//IL_1775: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Unknown result type (might be due to invalid IL or missing references)
		//IL_1953: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_2001: Unknown result type (might be due to invalid IL or missing references)
		//IL_2021: Unknown result type (might be due to invalid IL or missing references)
		//IL_2040: Unknown result type (might be due to invalid IL or missing references)
		//IL_2060: Unknown result type (might be due to invalid IL or missing references)
		//IL_207f: Unknown result type (might be due to invalid IL or missing references)
		//IL_209f: Unknown result type (might be due to invalid IL or missing references)
		//IL_20be: Unknown result type (might be due to invalid IL or missing references)
		//IL_20de: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2118: Unknown result type (might be due to invalid IL or missing references)
		//IL_214c: Unknown result type (might be due to invalid IL or missing references)
		//IL_216c: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_121f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2231: Unknown result type (might be due to invalid IL or missing references)
		//IL_2250: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1811: Unknown result type (might be due to invalid IL or missing references)
		//IL_2288: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_1838: Unknown result type (might be due to invalid IL or missing references)
		//IL_182c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_149b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1426: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c78: Unknown result type (might be due to invalid IL or missing references)
		GUI.skin.button.fontStyle = (FontStyle)0;
		GUIStyle val = new GUIStyle(GUI.skin.button);
		val.fontSize = GKCGNNLENDI;
		GUIStyle val2 = new GUIStyle(GUI.skin.box);
		val2.fontSize = GKCGNNLENDI;
		int num = 155;
		int num2 = 25;
		int num3 = num / 2;
		int num4 = 25;
		int num5 = 170;
		int num6 = 15;
		int num7 = 25;
		int num8 = 5;
		int num9 = num6;
		int num10 = 10;
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		int currentThemeId = PsaiCore.Instance.GetCurrentThemeId();
		int currentSegmentId = PsaiCore.Instance.GetCurrentSegmentId();
		int upcomingThemeId = psaiInfo.upcomingThemeId;
		bool flag = currentSegmentId != DLLNGIFJFFI;
		bool flag2 = currentThemeId != FLHCDAGGLKA;
		bool flag3 = false;
		SegmentInfo segmentInfo = new SegmentInfo();
		BBLAFKCMGMB += Time.deltaTime;
		if (BBLAFKCMGMB > JECFJGDNBAP)
		{
			BBLAFKCMGMB -= JECFJGDNBAP;
			flag3 = true;
		}
		if (MILLEMIKEPM.ContainsKey(currentSegmentId))
		{
			if (flag || flag3)
			{
				MILLEMIKEPM[currentSegmentId] = PsaiCore.Instance.GetSegmentInfo(currentSegmentId);
			}
			segmentInfo = MILLEMIKEPM[currentSegmentId];
		}
		Color backgroundColor = GUI.backgroundColor;
		if (psaiInfo.psaiState == PsaiState.notready)
		{
			GUI.color = Color.white;
			GUI.Label(new Rect((float)num9, (float)num10, (float)Screen.width, 200f), "NO SOUNDTRACK LOADED\n Troubleshooting:\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in the Project window.", CALMPFGCPMH);
			return;
		}
		num10 = num8;
		num9 = num6;
		GUI.color = Color.white;
		int num11 = Screen.width / 5;
		int num12 = num7;
		num9 = num5;
		int num13 = (int)((float)num7 * 2f / 2.5f);
		if (_showIntensityLevels)
		{
			num9 = num5;
			((Texture)_textureIntensity).wrapMode = (TextureWrapMode)0;
			((Texture)_textureWhiteAlpha).wrapMode = (TextureWrapMode)0;
			GUI.Box(new Rect((float)num9, (float)num10, (float)num11, (float)(num13 * 2)), "", val2);
			if (psaiInfo.psaiState == PsaiState.playing)
			{
				float intensity = segmentInfo.intensity;
				float currentIntensity = PsaiCore.Instance.GetCurrentIntensity();
				float upcomingIntensity = psaiInfo.upcomingIntensity;
				float num14 = (float)num11 * intensity;
				float num15 = num13;
				float num16 = num13;
				GUI.color = CCAAMAJBBMO;
				GUI.DrawTextureWithTexCoords(new Rect((float)num9, (float)num10, num14, (float)num13), (Texture)(object)_textureIntensity, new Rect(0f, 0f, 1f, 1f));
				if (Mathf.Abs(upcomingIntensity - currentIntensity) > 0.01f)
				{
					GUI.color = new Color(0.5f + 0.5f * JPFLKEKIJFP, 0.5f + 0.5f * JPFLKEKIJFP, 0f, 0.66f);
					GUI.DrawTextureWithTexCoords(new Rect((float)num9, (float)num10 + num16, (float)num11 * upcomingIntensity, num15), (Texture)(object)_textureIntensity, new Rect(0f, 0f, 1f, 1f));
				}
				else
				{
					GUI.color = HMGBONEBFNF;
					GUI.DrawTextureWithTexCoords(new Rect((float)num9, (float)num10 + num16, (float)num11 * currentIntensity, num15), (Texture)(object)_textureIntensity, new Rect(0f, 0f, 1f, 1f));
				}
			}
			num9 = num6;
			GUI.color = IBHDALEEEOL;
			GUI.Label(new Rect((float)num9, (float)(num10 - num8), 300f, (float)num7), "Segment Intensity:", CALMPFGCPMH);
			GUI.color = IBHDALEEEOL;
			GUI.Label(new Rect((float)num9, (float)(num10 - num8 + num13), 300f, (float)num7), "Dynamic Intensity:", CALMPFGCPMH);
		}
		if (_showIntensityControls)
		{
			num9 = num5 + num11 + num6;
			if (psaiInfo.psaiState == PsaiState.playing)
			{
				GUI.color = Color.white;
			}
			else
			{
				GUI.color = IBHDALEEEOL;
			}
		}
		if (_showIntensityControls)
		{
			bool flag4 = psaiInfo.psaiState == PsaiState.playing && !PsaiCore.Instance.CutSceneIsActive() && !PsaiCore.Instance.MenuModeIsActive();
			if (psaiInfo.intensityIsHeld)
			{
				GUI.color = JKKOLIEALPI;
				GUI.DrawTextureWithTexCoords(new Rect((float)num9, (float)num10, (float)num3, (float)(num12 + num13 * 2)), (Texture)(object)_textureWhiteFull, new Rect(0f, 0f, 1f, 1f));
			}
			if (flag4)
			{
				GUI.color = Color.white;
			}
			else
			{
				GUI.color = AKFBLONAICI;
			}
			if (GUI.Button(new Rect((float)num9, (float)num10, (float)num3, (float)(num12 + num13 * 2)), "Hold\nIntensity", val) && flag4)
			{
				PsaiCore.Instance.HoldCurrentIntensity(!psaiInfo.intensityIsHeld);
			}
			num9 += num3 + num6;
			if (GUI.Button(new Rect((float)num9, (float)num10, (float)num3, (float)(num12 + num13 * 2)), "add to\nIntensity", val))
			{
				if (IDLCDLPJBJA > 1f)
				{
					IDLCDLPJBJA = 1f;
				}
				if (IDLCDLPJBJA < -1f)
				{
					IDLCDLPJBJA = -1f;
				}
				CMHPAHHAIJK = IDLCDLPJBJA.ToString("F2");
				PsaiCore.Instance.AddToCurrentIntensity(IDLCDLPJBJA);
			}
			num9 += num3 + num6 / 2;
			GUI.color = IBHDALEEEOL;
			CMHPAHHAIJK = GUI.TextField(new Rect((float)num9, (float)(num10 + num12), (float)(num / 4), (float)(num13 * 2)), CMHPAHHAIJK, 25);
			if (!float.TryParse(CMHPAHHAIJK, out IDLCDLPJBJA))
			{
				CMHPAHHAIJK = IDLCDLPJBJA.ToString("F2");
			}
		}
		num10 += num13 * 2;
		num10 += num12;
		if (_showMainVolumeSlider)
		{
			int num17 = num6 * 2;
			num9 = Screen.width - num17;
			int num18 = num10 - num8;
			GUI.color = Color.white;
			OILGOECILGB = GUI.VerticalSlider(new Rect((float)num9, (float)(num10 - num18), (float)num17, (float)num18), PsaiCore.Instance.GetVolume(), 1f, 0f);
			PsaiCore.Instance.SetVolume(OILGOECILGB);
			GUI.Label(new Rect((float)(num9 - num17 * 2), (float)num8, 200f, (float)num7), "volume", CALMPFGCPMH);
			GUI.Label(new Rect((float)(num9 - num17 * 2), (float)num7, 200f, (float)num7), OILGOECILGB.ToString("F3"), CALMPFGCPMH);
		}
		int num19 = JBLOCOPHGOJ.Keys.Count * (num4 + num8);
		if (_showThemeTriggerSection)
		{
			num10 -= num7;
			num9 = num6;
			GUI.color = Color.white;
			GUI.Label(new Rect((float)num9, (float)num10, 200f, (float)num7), "set Start-Intensity: " + PDEGCCFNMAK.ToString("f3"), CALMPFGCPMH);
			num10 += num8 * 2;
			num9 = num5;
			float intensity2 = (PDEGCCFNMAK = GUI.HorizontalSlider(new Rect((float)num9, (float)num10, (float)num11, (float)num12), PDEGCCFNMAK, 0f, 1f));
			num10 += num7;
			num10 += num8;
			int num20 = 0;
			int num21 = num10;
			foreach (ThemeType key in JBLOCOPHGOJ.Keys)
			{
				num9 = num6;
				if (_showThemeTriggerSection)
				{
					GUI.color = IBHDALEEEOL;
					GUI.Label(new Rect((float)num9, (float)num10, (float)num5, 50f), Theme.ThemeTypeToString(key) + " :", CALMPFGCPMH);
				}
				List<int> list = JBLOCOPHGOJ[key];
				if (num20 < list.Count)
				{
					num20 = list.Count;
				}
				num10 += num2 + num8;
			}
			int num22 = num20 * (num + num6);
			FIKLKAJFNLC = GUI.BeginScrollView(new Rect((float)num5, (float)num21, (float)(Screen.width - num5), (float)num19), FIKLKAJFNLC, new Rect(0f, 0f, (float)num22, (float)num19));
			num10 = 0;
			bool kOGBHEPHDJD = !PsaiCore.Instance.CutSceneIsActive() && !PsaiCore.Instance.MenuModeIsActive();
			EHJILOMDEPL(kOGBHEPHDJD);
			foreach (ThemeType key2 in JBLOCOPHGOJ.Keys)
			{
				num9 = 0;
				foreach (int item in JBLOCOPHGOJ[key2])
				{
					ThemeInfo themeInfo = EEIOIFDPLCJ[item];
					if (themeInfo.type == ThemeType.highlightLayer && currentSegmentId != -1 && !PsaiCore.Instance.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(currentSegmentId, themeInfo.id))
					{
						GUI.enabled = false;
					}
					bool flag5 = false;
					if (item == psaiInfo.lastBasicMoodThemeId)
					{
						GUI.color = new Color(0f, 1f, 0f, 0.3f);
						flag5 = true;
					}
					if (item == upcomingThemeId)
					{
						GUI.color = new Color(1f, 1f, 0f, JPFLKEKIJFP);
						flag5 = true;
					}
					if (item == currentThemeId)
					{
						switch (psaiInfo.psaiState)
						{
						case PsaiState.playing:
							GUI.color = new Color(0.1f, 1f, 0.1f, 1f);
							break;
						case PsaiState.rest:
							GUI.color = new Color(0f, 0.5f, 0f, JPFLKEKIJFP);
							break;
						}
						flag5 = true;
					}
					if (flag5)
					{
						GUI.DrawTextureWithTexCoords(new Rect((float)num9, (float)num10, (float)num, (float)num4), (Texture)(object)_textureWhiteFull, new Rect(0f, 0f, 1f, 1f));
						GUI.color = Color.white;
					}
					GUI.color = Color.white;
					if (GUI.Button(new Rect((float)num9, (float)num10, (float)num, (float)num4), themeInfo.name, val))
					{
						PsaiCore.Instance.TriggerMusicTheme(themeInfo.id, intensity2);
						if (themeInfo.type == ThemeType.highlightLayer)
						{
							BIOKAELADIM = true;
						}
					}
					GUI.contentColor = backgroundColor;
					GUI.backgroundColor = backgroundColor;
					num9 += num + num6;
					GUI.enabled = true;
				}
				num10 += num2 + num8;
			}
			GUI.EndScrollView();
			num10 = num21;
		}
		else
		{
			num10 += num8 * 3;
		}
		num10 += num19;
		num9 = num6;
		num10 += num8;
		int num23 = (num2 + num7) * 2;
		int num24 = num23 + num8 * 2;
		int num25 = num + num6 * 2;
		int num26 = num25 * 5 + num6 * 4;
		int num27 = num24 + num8 + 5;
		if (_showControlButtonSection)
		{
			DCKIHGKPPAM = GUI.BeginScrollView(new Rect(0f, (float)num10, (float)Screen.width, (float)num27), DCKIHGKPPAM, new Rect(0f, 0f, (float)num26, (float)num23));
			num9 = Math.Max(0, (int)((float)(Screen.width - num26) / 2f - (float)num6 / 2f));
			int num21 = num10;
			num10 = 0;
			GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num25, (float)num23));
			int num28 = num6;
			int num29 = 0;
			bool flag6 = !LFMLHPMLCDH && (psaiInfo.psaiState == PsaiState.playing || psaiInfo.psaiState == PsaiState.rest) && !PsaiCore.Instance.CutSceneIsActive() && !PsaiCore.Instance.MenuModeIsActive();
			EHJILOMDEPL(flag6);
			GUI.Box(new Rect(0f, 0f, (float)num25, (float)num23), "Stop Music", val2);
			if (flag6)
			{
				num29 += num2;
				if (GUI.Button(new Rect((float)num28, (float)num29, (float)num, (float)num2), "immediately", val))
				{
					PsaiCore.Instance.StopMusic(immediately: true);
				}
				if (psaiInfo.psaiState == PsaiState.playing)
				{
					num29 += num2 + num8;
					if (psaiInfo.upcomingPsaiState == PsaiState.silence)
					{
						GUI.color = new Color(0.5f + 0.5f * JPFLKEKIJFP, 0.5f + 0.5f * JPFLKEKIJFP, 0f, 0.66f);
						GUI.DrawTextureWithTexCoords(new Rect((float)num28, (float)num29, (float)num, (float)num2), (Texture)(object)_textureWhiteFull, new Rect(0f, 0f, 1f, 1f));
					}
					GUI.color = Color.white;
					if (GUI.Button(new Rect((float)num28, (float)num29, (float)num, (float)num2), "via End-Segment", val))
					{
						PsaiCore.Instance.StopMusic(immediately: false);
					}
				}
			}
			GUI.EndGroup();
			num9 += num25 + num6;
			GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num25, (float)num23), CALMPFGCPMH);
			int num30 = num6;
			int num31 = 0;
			bool flag7 = !LFMLHPMLCDH && psaiInfo.psaiState == PsaiState.playing && !PsaiCore.Instance.CutSceneIsActive() && !PsaiCore.Instance.MenuModeIsActive();
			EHJILOMDEPL(flag7);
			GUI.Box(new Rect(0f, 0f, (float)num25, (float)num23), "Return To Last Basic Mood", val2);
			if (flag7)
			{
				num31 += num2;
				if (GUI.Button(new Rect((float)num30, (float)num31, (float)num, (float)num2), "immediately", val))
				{
					PsaiCore.Instance.ReturnToLastBasicMood(immediately: true);
				}
				num31 += num2 + num8;
				if (psaiInfo.returningToLastBasicMood)
				{
					GUI.color = new Color(0.5f + 0.5f * JPFLKEKIJFP, 0.5f + 0.5f * JPFLKEKIJFP, 0f, 0.66f);
					GUI.DrawTextureWithTexCoords(new Rect((float)num30, (float)num31, (float)num, (float)num2), (Texture)(object)_textureWhiteFull, new Rect(0f, 0f, 1f, 1f));
				}
				GUI.color = Color.white;
				if (GUI.Button(new Rect((float)num30, (float)num31, (float)num, (float)num2), "via End-Segment", val))
				{
					PsaiCore.Instance.ReturnToLastBasicMood(immediately: false);
				}
			}
			GUI.EndGroup();
			num9 += num25 + num6;
			GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num25, (float)num23), CALMPFGCPMH);
			int num32 = num6;
			int num33 = num2;
			bool flag8 = psaiInfo.psaiState == PsaiState.playing;
			EHJILOMDEPL(flag8);
			GUI.Box(new Rect(0f, 0f, (float)num25, (float)num23), "", val2);
			if (flag8)
			{
				string text;
				if (psaiInfo.paused)
				{
					GUI.backgroundColor = Color.white;
					text = "Play";
				}
				else
				{
					GUI.backgroundColor = AKFBLONAICI;
					text = "Pause";
				}
				if (GUI.Button(new Rect((float)num32, (float)num33, (float)num, (float)(num2 * 2)), text, val))
				{
					LFMLHPMLCDH = !psaiInfo.paused;
					PsaiCore.Instance.SetPaused(LFMLHPMLCDH);
				}
			}
			GUI.EndGroup();
			num9 += num25 + num6;
			if (JLMPLMGIFKN)
			{
				GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num25, (float)num24), CALMPFGCPMH);
				bool flag9 = !LFMLHPMLCDH;
				EHJILOMDEPL(flag9);
				int num34 = num6;
				int num35 = 0;
				num35 += num2;
				GUI.Box(new Rect(0f, 0f, (float)num25, (float)num24), "Menu Mode Settings", val2);
				if (flag9)
				{
					if (GUI.Button(new Rect((float)num34, (float)num35, (float)num, (float)num2), EEIOIFDPLCJ[LMDAPBIDHHH].name))
					{
						MCKJOIIFEHP++;
						if (MCKJOIIFEHP == DHEJLIFCIGK.Length)
						{
							MCKJOIIFEHP = 0;
						}
						LMDAPBIDHHH = DHEJLIFCIGK[MCKJOIIFEHP];
					}
					num35 += num2;
					GUI.Label(new Rect((float)num34, (float)num35, (float)num3, (float)num2), "intensity:", CALMPFGCPMH);
					GUI.Label(new Rect((float)(num34 + num3 / 4), (float)(num35 + 15), (float)num3, (float)num2), EIFPPOHECEI.ToString("F2"), CALMPFGCPMH);
					num35 += num8;
					float eIFPPOHECEI = GUI.HorizontalSlider(new Rect((float)(num34 + num3), (float)(num35 + num8), (float)num3, (float)num2), EIFPPOHECEI, 0f, 1f);
					EIFPPOHECEI = eIFPPOHECEI;
					num35 += num2;
					if (GUI.Button(new Rect((float)num34, (float)num35, (float)num3, (float)num2), "OK", val))
					{
						JLMPLMGIFKN = false;
						FIIDFGGJCKD = EIFPPOHECEI;
					}
					if (GUI.Button(new Rect((float)(num34 + num3), (float)num35, (float)num3, (float)num2), "Cancel", val))
					{
						JLMPLMGIFKN = false;
						EIFPPOHECEI = FIIDFGGJCKD;
						LMDAPBIDHHH = LOHNPCHDDON;
					}
				}
				GUI.EndGroup();
			}
			else
			{
				GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num25, (float)num23), CALMPFGCPMH);
				bool flag10 = !LFMLHPMLCDH;
				EHJILOMDEPL(flag10);
				int num36 = num6;
				int num37 = 0;
				num37 += num2;
				GUI.Box(new Rect(0f, 0f, (float)num25, (float)num23), "Menu Mode", val2);
				if (flag10)
				{
					if (!PsaiCore.Instance.MenuModeIsActive())
					{
						if (GUI.Button(new Rect((float)num36, (float)num37, (float)num, (float)num2), "Enter", val))
						{
							PsaiCore.Instance.MenuModeEnter(LMDAPBIDHHH, EIFPPOHECEI);
						}
						if (GUI.Button(new Rect((float)num36, (float)(num37 + num2 + num8), (float)num, (float)num2), "Configure", val))
						{
							JLMPLMGIFKN = true;
							LOHNPCHDDON = LMDAPBIDHHH;
							FIIDFGGJCKD = EIFPPOHECEI;
						}
					}
					else if (GUI.Button(new Rect((float)num36, (float)num37, (float)num, (float)num2), "Leave", val))
					{
						PsaiCore.Instance.MenuModeLeave();
					}
				}
				GUI.EndGroup();
			}
			num9 += num25 + num6;
			if (PLMILDKBMMM)
			{
				GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num25, (float)num24), CALMPFGCPMH);
				int num38 = 0;
				num38 += num2;
				GUI.Box(new Rect(0f, 0f, (float)num25, (float)num24), "CutScene Settings", val2);
				if (GUI.Button(new Rect((float)num6, (float)num38, (float)num, (float)num2), EEIOIFDPLCJ[DLGCPNODNDD].name, val))
				{
					ILLCCOEOBFE++;
					if (ILLCCOEOBFE == DHEJLIFCIGK.Length)
					{
						ILLCCOEOBFE = 0;
					}
					DLGCPNODNDD = DHEJLIFCIGK[ILLCCOEOBFE];
				}
				num38 += num2;
				GUI.Label(new Rect((float)num6, (float)num38, (float)num3, (float)num2), "intensity:", CALMPFGCPMH);
				GUI.Label(new Rect((float)(num6 + num3 / 4), (float)(num38 + 15), (float)num3, (float)num2), BCGDNDLFMDI.ToString("F2"), CALMPFGCPMH);
				num38 += num8;
				float bCGDNDLFMDI = GUI.HorizontalSlider(new Rect((float)(num6 + num3), (float)(num38 + num8), (float)num3, (float)num2), BCGDNDLFMDI, 0f, 1f);
				BCGDNDLFMDI = bCGDNDLFMDI;
				num38 += num2;
				if (GUI.Button(new Rect((float)num6, (float)num38, (float)num3, (float)num2), "OK", val))
				{
					PLMILDKBMMM = false;
					OMMGFIFJNCK = BCGDNDLFMDI;
				}
				if (GUI.Button(new Rect((float)(num6 + num3), (float)num38, (float)num3, (float)num2), "Cancel", val))
				{
					PLMILDKBMMM = false;
					BCGDNDLFMDI = OMMGFIFJNCK;
					DLGCPNODNDD = KFCFJGDMPAN;
				}
				GUI.EndGroup();
			}
			else
			{
				GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num25, (float)num23), CALMPFGCPMH);
				int num39 = num6;
				int num40 = 0;
				num40 += num2;
				bool flag11 = !LFMLHPMLCDH && !PsaiCore.Instance.MenuModeIsActive();
				EHJILOMDEPL(flag11);
				GUI.Box(new Rect(0f, 0f, (float)num25, (float)num23), "CutScene", val2);
				if (flag11)
				{
					if (!PsaiCore.Instance.CutSceneIsActive())
					{
						if (GUI.Button(new Rect((float)num39, (float)num40, (float)num, (float)num2), "Enter", val))
						{
							PsaiCore.Instance.CutSceneEnter(DLGCPNODNDD, BCGDNDLFMDI);
						}
						if (GUI.Button(new Rect((float)num39, (float)(num40 + num2 + num8), (float)num, (float)num2), "Configure", val))
						{
							PLMILDKBMMM = true;
							KFCFJGDMPAN = DLGCPNODNDD;
							OMMGFIFJNCK = BCGDNDLFMDI;
						}
					}
					else
					{
						if (GUI.Button(new Rect((float)num39, (float)num40, (float)num, (float)num2), "Leave immediately", val))
						{
							PsaiCore.Instance.CutSceneLeave(immediately: true, reset: false);
						}
						num40 += num2 + num8;
						if (GUI.Button(new Rect((float)num39, (float)num40, (float)num, (float)num2), "Leave smoothly", val))
						{
							PsaiCore.Instance.CutSceneLeave(immediately: false, reset: false);
						}
					}
				}
				GUI.EndGroup();
			}
			GUI.EndScrollView();
			num10 = num21;
		}
		GUI.color = Color.white;
		num10 += num24;
		num10 += num8 * 2;
		int num41 = num6;
		num9 = num41;
		int num42 = (int)((float)Screen.width / 2f) - num41 - num6;
		int num43 = num7 * 7;
		if (flag2)
		{
			AHPAGCFDCIL = PsaiCore.Instance.GetCurrentThemeId();
		}
		int num44 = num41 + num42 + num6;
		if (!_showListSections)
		{
			return;
		}
		num9 = num6;
		string text2 = (GEDBFOCNHAK ? "Listview" : "Playstate");
		if (GUI.Button(new Rect((float)num9, (float)num10, (float)num3, (float)num2), text2, val))
		{
			GEDBFOCNHAK = !GEDBFOCNHAK;
			GCPAOFGCFMN = GEDBFOCNHAK;
		}
		num10 += num2;
		num9 = num41;
		if (GEDBFOCNHAK)
		{
			int num45 = num42;
			int num46 = Screen.width - num44 - num6;
			int num47 = (int)((float)(Screen.height - num10) * 0.9f);
			int num48 = 22;
			int num49 = Mathf.Max(EEIOIFDPLCJ.Keys.Count * num48, num47);
			GUI.Label(new Rect((float)(num9 + num45 / 2), (float)(num10 - num48), (float)num45, (float)num48), "Themes", CALMPFGCPMH);
			GUI.Box(new Rect((float)num9, (float)num10, (float)num45, (float)num47), "", val2);
			for (int i = 0; i < OAIHBKLKMHC.Length; i++)
			{
				int num50 = num45 / OAIHBKLKMHC[i];
				if (GUI.Button(new Rect((float)num9, (float)num10, (float)num50, (float)num2), ICGAHDMHELC[i], GUIStyle.op_Implicit("Label")))
				{
					switch (i)
					{
					case 0:
						DAOLGJCIOCF.Sort(PMNDLICIFNF);
						break;
					case 1:
						DAOLGJCIOCF.Sort();
						break;
					case 2:
						DAOLGJCIOCF.Sort(IHPJDBCMDPD);
						break;
					}
					FMLFJANKMJH = !FMLFJANKMJH;
					if (FMLFJANKMJH)
					{
						DAOLGJCIOCF.Reverse();
					}
				}
				num9 += num50;
			}
			num9 = num41;
			GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num45, (float)num47), CALMPFGCPMH);
			IMMNHHMBIAF = GUI.BeginScrollView(new Rect(0f, (float)num48, (float)num45, (float)(num47 - num48)), IMMNHHMBIAF, new Rect(0f, 0f, (float)(num45 - num6 * 2), (float)num49), false, true);
			int num51 = 0;
			for (int j = 0; j < DHEJLIFCIGK.Length; j++)
			{
				ThemeInfo themeInfo2 = EEIOIFDPLCJ[DAOLGJCIOCF[j]];
				if (AHPAGCFDCIL == themeInfo2.id)
				{
					GUI.color = Color.white;
					GUI.DrawTextureWithTexCoords(new Rect(0f, (float)num51, (float)num45, (float)num48), (Texture)(object)_textureWhiteAlpha, new Rect(0f, 0f, 1f, 1f));
				}
				if (themeInfo2.id == currentThemeId)
				{
					GUI.color = JKKOLIEALPI;
				}
				else if (themeInfo2.id == upcomingThemeId)
				{
					GUI.color = CDDLAAEBLLO;
				}
				else if (AHPAGCFDCIL == themeInfo2.id)
				{
					GUI.color = Color.white;
				}
				else
				{
					GUI.color = IBHDALEEEOL;
				}
				int num52 = 0;
				for (int k = 0; k < OAIHBKLKMHC.Length; k++)
				{
					int num53 = num45 / OAIHBKLKMHC[k];
					string text3 = "";
					switch (k)
					{
					case 0:
						text3 = themeInfo2.name;
						break;
					case 1:
						text3 = themeInfo2.id.ToString();
						break;
					case 2:
						text3 = Theme.ThemeTypeToString(themeInfo2.type);
						break;
					}
					if (GUI.Button(new Rect((float)num52, (float)num51, (float)num45, (float)num48), text3, GUIStyle.op_Implicit("Label")))
					{
						AHPAGCFDCIL = themeInfo2.id;
					}
					num52 += num53;
				}
				num51 += num48;
			}
			GUI.EndScrollView();
			GUI.EndGroup();
			num9 = num44;
			GUI.color = Color.white;
			GUI.Label(new Rect((float)(num9 + num46 / 2), (float)(num10 - num48), (float)num46, (float)num48), "Segments", CALMPFGCPMH);
			GUI.Box(new Rect((float)num9, (float)num10, (float)num46, (float)num47), "", val2);
			if (EEIOIFDPLCJ.ContainsKey(AHPAGCFDCIL))
			{
				int[] segmentIds = EEIOIFDPLCJ[AHPAGCFDCIL].segmentIds;
				if (AHPAGCFDCIL != HMLDHMDCALG || GCPAOFGCFMN || BIOKAELADIM)
				{
					CLHECDKKMDO.Clear();
					CLHECDKKMDO.AddRange(segmentIds);
					PFJNGLBFOEM();
					BIOKAELADIM = false;
				}
				int num54 = Mathf.Max(EEIOIFDPLCJ[AHPAGCFDCIL].segmentIds.Length * num48, num47);
				for (int l = 0; l < LLIPMKBFJKM.Length; l++)
				{
					int num55 = num46 / LLIPMKBFJKM[l];
					if (GUI.Button(new Rect((float)num9, (float)num10, (float)num55, (float)num2), OPHKCLFCICF[l], GUIStyle.op_Implicit("Label")))
					{
						switch (l)
						{
						case 0:
							CLHECDKKMDO.Sort(ILHLDHHEBIF);
							break;
						case 1:
							CLHECDKKMDO.Sort(EDHDAAFKFAC);
							break;
						case 2:
							CLHECDKKMDO.Sort(COJJBHDMNFG);
							break;
						case 3:
							CLHECDKKMDO.Sort(HDGCPBMHCNM);
							break;
						}
						GAEOFBJKFPP = !GAEOFBJKFPP;
						if (GAEOFBJKFPP)
						{
							CLHECDKKMDO.Reverse();
						}
					}
					num9 += num55;
				}
				GUI.BeginGroup(new Rect((float)num44, (float)num10, (float)num46, (float)num47), CALMPFGCPMH);
				HKKBPCAOKGJ = GUI.BeginScrollView(new Rect(0f, (float)num48, (float)num46, (float)(num47 - num48)), HKKBPCAOKGJ, new Rect(0f, 0f, (float)(num46 - num6 * 2), (float)num54), false, true);
				int num56 = 0;
				for (int m = 0; m < CLHECDKKMDO.Count; m++)
				{
					int num57 = CLHECDKKMDO[m];
					if (num57 == currentSegmentId)
					{
						GUI.color = JKKOLIEALPI;
						if (flag && CLIDEODFNFJ)
						{
							HKKBPCAOKGJ.y = m * num48;
						}
					}
					else if (num57 == psaiInfo.targetSegmentId)
					{
						GUI.color = CDDLAAEBLLO;
					}
					else
					{
						GUI.color = IBHDALEEEOL;
					}
					if (EKBMCKPKCCH.ContainsKey(num57) && EKBMCKPKCCH[num57] > 0)
					{
						GUI.color = JKKOLIEALPI;
					}
					SegmentInfo segmentInfo2 = MILLEMIKEPM[num57];
					int num58 = 0;
					for (int n = 0; n < LLIPMKBFJKM.Length; n++)
					{
						string text4 = "";
						switch (n)
						{
						case 0:
							text4 = segmentInfo2.name;
							break;
						case 1:
							text4 = Segment.GetStringFromSegmentSuitabilities(segmentInfo2.segmentSuitabilitiesBitfield);
							break;
						case 2:
							text4 = segmentInfo2.intensity.ToString("F2");
							break;
						case 3:
							text4 = segmentInfo2.playcount.ToString();
							break;
						}
						int num59 = num46 / LLIPMKBFJKM[n];
						if (GUI.Button(new Rect((float)num58, (float)num56, (float)num59, (float)num48), text4, GUIStyle.op_Implicit("Label")))
						{
							PsaiCore.Instance.PlaySegment(num57);
							OLGNAGJAOBL(num57);
						}
						num58 += num59;
					}
					num56 += num48;
				}
				GUI.EndScrollView();
				GUI.EndGroup();
			}
		}
		else
		{
			num10 = Mathf.Max(num10, Screen.height - num43 - ((Texture)_textureNeedMusic).height - num2 - num7);
			if (psaiInfo.psaiState == PsaiState.playing)
			{
				GUI.color = Color.white;
			}
			else
			{
				GUI.color = AKFBLONAICI;
			}
			GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num42, (float)num43), CALMPFGCPMH);
			int num60 = 0;
			int num61 = (int)((float)num42 / 2f);
			GUI.Box(new Rect(0f, 0f, (float)num42, (float)num43), "current Theme playing", val2);
			int num62 = num6 + num6;
			num60 += num7;
			string text5 = "";
			string text6 = "";
			string text7 = "";
			if (currentThemeId > 0)
			{
				ThemeInfo themeInfo3 = EEIOIFDPLCJ[currentThemeId];
				text5 = themeInfo3.name;
				text6 = themeInfo3.id.ToString();
				text7 = Theme.ThemeTypeToString(themeInfo3.type);
			}
			GUI.Label(new Rect((float)num62, (float)num60, (float)num42, (float)num7), "Name: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num61, (float)num60, (float)num42, (float)num7), text5, CALMPFGCPMH);
			num60 += num7;
			GUI.Label(new Rect((float)num62, (float)num60, (float)num42, (float)num7), "id: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num61, (float)num60, (float)num42, (float)num7), text6, CALMPFGCPMH);
			num60 += num7;
			GUI.Label(new Rect((float)num62, (float)num60, (float)num42, (float)num7), "ThemeType: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num61, (float)num60, (float)num42, (float)num7), text7, CALMPFGCPMH);
			num60 += num7;
			num60 += num7;
			num60 += num7;
			GUI.Label(new Rect((float)num62, (float)num60, (float)num42, (float)num7), "psai state: " + psaiInfo.psaiState, CALMPFGCPMH);
			if (psaiInfo.remainingMillisecondsInRestMode > 0)
			{
				string text8 = "Waking up in: " + psaiInfo.remainingMillisecondsInRestMode;
				GUI.Label(new Rect((float)num61, (float)num60, (float)num42, (float)num7), text8, CALMPFGCPMH);
			}
			GUI.EndGroup();
			num9 = num44;
			int num63 = num42;
			int num64 = num43;
			GUI.BeginGroup(new Rect((float)num9, (float)num10, (float)num63, (float)num64), CALMPFGCPMH);
			int num65 = num6;
			int num66 = 0;
			int num67 = num63 / 2;
			GUI.Box(new Rect(0f, 0f, (float)num63, (float)num64), "current Segment playing", val2);
			num65 += num6;
			num66 += num7;
			string text9 = "";
			string text10 = "";
			string text11 = "";
			string text12 = "";
			string text13 = "";
			if (currentSegmentId > 0)
			{
				SegmentInfo segmentInfo3 = MILLEMIKEPM[currentSegmentId];
				text9 = segmentInfo3.name;
				text10 = segmentInfo3.id.ToString();
				text11 = segmentInfo3.intensity.ToString("F2");
				text12 = Segment.GetStringFromSegmentSuitabilities(segmentInfo3.segmentSuitabilitiesBitfield);
				text13 = segmentInfo3.playcount.ToString();
			}
			GUI.Label(new Rect((float)num65, (float)num66, (float)num42, (float)num7), "Name: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num67, (float)num66, (float)num42, (float)num7), text9);
			num66 += num7;
			GUI.Label(new Rect((float)num65, (float)num66, (float)num42, (float)num7), "id: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num67, (float)num66, (float)num42, (float)num7), text10);
			num66 += num7;
			GUI.Label(new Rect((float)num65, (float)num66, (float)num42, (float)num7), "Intensity: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num67, (float)num66, (float)num42, (float)num7), text11);
			num66 += num7;
			GUI.Label(new Rect((float)num65, (float)num66, (float)num42, (float)num7), "Suitabilities: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num67, (float)num66, (float)num42, (float)num7), text12);
			num66 += num7;
			GUI.Label(new Rect((float)num65, (float)num66, (float)num42, (float)num7), "times played: ");
			GUI.Label(new Rect((float)num67, (float)num66, (float)num42, (float)num7), text13);
			num66 += num7;
			string text14 = PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback().ToString();
			GUI.Label(new Rect((float)num65, (float)num66, (float)num63, (float)num7), "remaining ms: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num67, (float)num66, (float)num63, (float)num7), text14, CALMPFGCPMH);
			num66 += num7;
			string text15 = PsaiCore.Instance.GetRemainingMillisecondsUntilNextSegmentStart().ToString();
			GUI.Label(new Rect((float)num65, (float)num66, (float)num63, (float)num7), "ms until next Segment: ", CALMPFGCPMH);
			GUI.Label(new Rect((float)num67, (float)num66, (float)num63, (float)num7), text15, CALMPFGCPMH);
			GUI.EndGroup();
			if ((Object)(object)_textureNeedMusic != (Object)null)
			{
				GUI.color = Color.white;
				num10 += num43;
				num10 += num7;
				GUI.DrawTextureWithTexCoords(new Rect((float)(Screen.width - ((Texture)_textureNeedMusic).width - 22), (float)num10, (float)((Texture)_textureNeedMusic).width, (float)((Texture)_textureNeedMusic).height), (Texture)(object)_textureNeedMusic, new Rect(0f, 0f, 1f, 1f));
			}
		}
		num9 = num6;
		num10 = Screen.height - (CALMPFGCPMH.fontSize + 5);
		if (OBLNCACPOPL != null && OBLNCACPOPL.Length > 0)
		{
			GUI.color = FHDBNENOFJM;
			GUI.Label(new Rect((float)num9, (float)num10, (float)num42, (float)CALMPFGCPMH.fontSize), "last error: " + OBLNCACPOPL, CALMPFGCPMH);
		}
		FLHCDAGGLKA = currentThemeId;
		DLLNGIFJFFI = currentSegmentId;
		HMLDHMDCALG = AHPAGCFDCIL;
		GCPAOFGCFMN = false;
		if (EKBMCKPKCCH.Count <= 0)
		{
			return;
		}
		List<int> list2 = new List<int>();
		int[] array = new int[EKBMCKPKCCH.Count];
		EKBMCKPKCCH.Keys.CopyTo(array, 0);
		int[] array2 = array;
		foreach (int num69 in array2)
		{
			int num70 = EKBMCKPKCCH[num69];
			num70 -= (int)(Time.deltaTime * 1000f);
			if (num70 > 0)
			{
				EKBMCKPKCCH[num69] = num70;
			}
			else
			{
				list2.Add(num69);
			}
		}
		foreach (int item2 in list2)
		{
			EKBMCKPKCCH.Remove(item2);
		}
	}

	private int FNPPLMHFJNL(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			string name = EEIOIFDPLCJ[OEEFMLJODNL].name;
			string name2 = EEIOIFDPLCJ[NJGCICCKOBK].name;
			return name.CompareTo(name2);
		}
		return 0;
	}

	private int COJJBHDMNFG(int KLNCJOKDNGJ, int PCLMOAEIIAG)
	{
		if (MILLEMIKEPM.ContainsKey(KLNCJOKDNGJ) && MILLEMIKEPM.ContainsKey(PCLMOAEIIAG))
		{
			return MILLEMIKEPM[KLNCJOKDNGJ].intensity.CompareTo(MILLEMIKEPM[PCLMOAEIIAG].intensity);
		}
		return 0;
	}

	private int ICJFHBLAAOP(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			string name = EEIOIFDPLCJ[OEEFMLJODNL].name;
			string name2 = EEIOIFDPLCJ[NJGCICCKOBK].name;
			return name.CompareTo(name2);
		}
		return 1;
	}

	private void JPICPBKIIFH(bool KOGBHEPHDJD)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if (KOGBHEPHDJD)
		{
			GUI.color = Color.white;
		}
		else
		{
			GUI.color = Color.gray;
		}
	}

	private int GJNEMHMGGMN(int GMGAGFAAJJP, int EHHLCKGODLC)
	{
		if (MILLEMIKEPM.ContainsKey(GMGAGFAAJJP) && MILLEMIKEPM.ContainsKey(EHHLCKGODLC))
		{
			string stringFromSegmentSuitabilities = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[GMGAGFAAJJP].segmentSuitabilitiesBitfield);
			string stringFromSegmentSuitabilities2 = Segment.GetStringFromSegmentSuitabilities(MILLEMIKEPM[EHHLCKGODLC].segmentSuitabilitiesBitfield);
			return stringFromSegmentSuitabilities.CompareTo(stringFromSegmentSuitabilities2);
		}
		return 0;
	}

	private void MICECADGKNK()
	{
		MILLEMIKEPM.Clear();
		int[] dHEJLIFCIGK = DHEJLIFCIGK;
		for (int i = 1; i < dHEJLIFCIGK.Length; i += 0)
		{
			int themeId = dHEJLIFCIGK[i];
			int[] segmentIds = PsaiCore.Instance.GetThemeInfo(themeId).segmentIds;
			for (int j = 1; j < segmentIds.Length; j++)
			{
				int num = segmentIds[j];
				SegmentInfo segmentInfo = PsaiCore.Instance.GetSegmentInfo(num);
				MILLEMIKEPM[num] = segmentInfo;
			}
		}
	}

	private int CBBFAMOBIMP(int OEEFMLJODNL, int NJGCICCKOBK)
	{
		if (EEIOIFDPLCJ.ContainsKey(OEEFMLJODNL) && EEIOIFDPLCJ.ContainsKey(NJGCICCKOBK))
		{
			string name = EEIOIFDPLCJ[OEEFMLJODNL].name;
			string name2 = EEIOIFDPLCJ[NJGCICCKOBK].name;
			return name.CompareTo(name2);
		}
		return 1;
	}
}
